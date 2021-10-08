Imports System.Data.SqlClient

Public Class AccountManager

    Dim connection As New SqlConnection("Data Source=DESKTOP-SE47S40 ; Initial Catalog = MyPersonalDB; Integrated Security =SSPI;")
    Dim selectQuery As New SqlCommand("Select * From AccountManger;", connection)
    Dim insertQuery As New SqlCommand("INSERT INTO AccountManger VALUES(@name, @login,@password, @additionalInfo, @url);", connection)

    Sub sqlInsertData(url As String, Name As String, login As String, password As String, additionalinfo As String)
        Try
            connection.Open()
            Try
                insertQuery.Parameters.AddWithValue("@name", Name)
                insertQuery.Parameters.AddWithValue("@login", login)
                insertQuery.Parameters.AddWithValue("@password", password)
                insertQuery.Parameters.AddWithValue("@additionalInfo", additionalinfo)
                insertQuery.Parameters.AddWithValue("@url", url)

                insertQuery.ExecuteNonQuery()
                MsgBox("Item Registred Saccefully!", MsgBoxStyle.Information, "Sacces")

                nameText.Text = ""
                urlText.Text = ""
                loginText.Text = ""
                passwordText.Text = ""
                additInfoText.Text = ""

            Catch ex As Exception
                MsgBox("Something Went Wrong", MsgBoxStyle.Exclamation, "Inknown error")
                'MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox("Connection To Database Fields!", MsgBoxStyle.Exclamation, "Connetion error")
        Finally
            connection.Close()
        End Try
    End Sub


    Sub SqlReader()
        Try
            connection.Open()
            Try
                Dim sqlReader As SqlDataReader = selectQuery.ExecuteReader

                WebsitesName.Items.Clear()
                While sqlReader.Read()
                    WebsitesName.Items.Add(sqlReader.Item(1))
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub AccountManager_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub AccountManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlReader()
    End Sub

    Private Sub RememberBtn_Click(sender As Object, e As EventArgs) Handles RememberBtn.Click
        sqlInsertData(urlText.Text, nameText.Text, loginText.Text, passwordText.Text, additInfoText.Text)
        SqlReader()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WebsitesName.SelectedIndexChanged

        Me.Hide()
        DisplayInfoAccount.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If passwordText.UseSystemPasswordChar = False Then
            passwordText.UseSystemPasswordChar = True
        Else
            passwordText.UseSystemPasswordChar = False
        End If
    End Sub
End Class