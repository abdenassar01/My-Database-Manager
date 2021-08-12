Imports System.Data.SqlClient

Public Class Note

    Dim connection As New SqlConnection("Data Source=DESKTOP-SE47S40 ; Initial Catalog = MyPersonalDB; Integrated Security =SSPI;")
    Dim sqlSelectquery As New SqlCommand("SELECT * FROM Notes; ", connection)

    Public Sub addNote()
        Dim sqlInsertquery As New SqlCommand("INSERT INTO Notes VALUES(@noteName, @noteBody, @noteDate);", connection)

        sqlInsertquery.Parameters.AddWithValue("@noteName", TextBox1.Text)
        sqlInsertquery.Parameters.AddWithValue("@noteBody", TextBox2.Text)
        sqlInsertquery.Parameters.AddWithValue("@noteDate", Date.Today)

        Try
            connection.Open()
            Try
                If TextBox1.Text = "" Or TextBox2.Text = "" Then
                    MsgBox("You Can't Create An Empty Note", MsgBoxStyle.Critical, "Error")
                Else
                    sqlInsertquery.ExecuteNonQuery()
                    MsgBox("Note Added Saccesfully", MsgBoxStyle.Information, "Sacces")
                    TextBox2.Text = ""
                    TextBox1.Text = ""
                    ListBox1.Items.Clear()
                    loadInfo()
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                MsgBox("Something Went Wrong", MsgBoxStyle.Exclamation, "Inknown error")
            End Try
        Catch ex As Exception
            MsgBox("Connection To Database Fields!", MsgBoxStyle.Exclamation, "Connetion error")
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub loadInfo()
        ListBox1.Items.Clear()
        connection.Close()
        Try
            connection.Open()
            Try
                Dim datareader As SqlDataReader = sqlSelectquery.ExecuteReader
                While datareader.Read()
                    ListBox1.Items.Add(datareader.Item(1))
                End While
            Catch ex As Exception
                MsgBox("Something Went Wrong", MsgBoxStyle.Exclamation, "Inknown error")
            End Try
        Catch ex As Exception
            'MsgBox(connection.State)
            MsgBox("Connection To Database Fields!", MsgBoxStyle.Exclamation, "Connetion error")
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub NoteDisplayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadInfo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addNote()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.Hide()
        DisplayNote.Show()
    End Sub


    Private Sub meClosed(sender As Object, e As EventArgs) Handles Me.FormClosed
        Form1.Show()
    End Sub
End Class