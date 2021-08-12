Imports System.Data.SqlClient

Public Class DisplayNote

    Dim connection As New SqlConnection("Data Source=DESKTOP-SE47S40 ; Initial Catalog = MyPersonalDB; Integrated Security =SSPI;")
    Dim sqlSelectNote As New SqlCommand("SELECT * FROM Notes where  NoteName = @noteName ; ", connection)
    Dim nameNote As String = Note.ListBox1.SelectedItem
    Dim sqlDeletequery As New SqlCommand("DELETE FROM Notes where NoteName = '" & nameNote & "' ;", connection)


    Public Sub deleteNote()
        Try
            connection.Open()
            Try
                'sqlDeletequery.Parameters.AddWithValue("@noteName", nameNote)
                Dim ReturnVal As Integer = sqlDeletequery.ExecuteNonQuery

                If ReturnVal = 0 Then
                    MsgBox("something Went Wrong Wit deleting ", MsgBoxStyle.Exclamation, "Deletion Fields")
                Else
                    MsgBox("You Have Deleted The Note Saccefully", MsgBoxStyle.Information, "Delete Sacceed")
                End If
            Catch ex As Exception
                MsgBox("Something Went Wrong", MsgBoxStyle.Exclamation, "Inknown error")
            End Try
        Catch ex As Exception
            MsgBox("Connection To Database Fields!", MsgBoxStyle.Exclamation, "Connetion error")
        Finally
            connection.Close()
        End Try

    End Sub


    Private Sub DisplayNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()
            Try
                sqlSelectNote.Parameters.AddWithValue("@noteName", nameNote)
                Dim datareader As SqlDataReader = sqlSelectNote.ExecuteReader
                While datareader.Read()
                    TextBox1.Text = datareader.Item(1)
                    TextBox2.Text = datareader.Item(2)
                    dateLabel.Text = datareader.Item(3)
                End While
            Catch ex As Exception
                MsgBox("Something Went Wrong", MsgBoxStyle.Exclamation, "Inknown error")
            End Try
        Catch ex As Exception
            MsgBox("Connection To Database Fields!", MsgBoxStyle.Exclamation, "Connetion error")
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Me.FormClosed
        Note.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Note.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        deleteNote()
        Note.loadInfo()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        Note.Show()
    End Sub
End Class