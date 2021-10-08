Imports System.Data.SqlClient

Public Class AddingPeaple
    Dim connection As New SqlConnection("Data Source=DESKTOP-SE47S40 ; Initial Catalog = MyPersonalDB; Integrated Security =SSPI;")
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub meClose(sender As Object, e As EventArgs) Handles Me.FormClosed
        Form1.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlInsertQuery As New SqlCommand("Insert into peaple(FirstName, lastName, Email, phone, Adress) Values(@firstName, @lastName, @email, @phone, @adress);", connection)

        sqlInsertQuery.Parameters.AddWithValue("@firstName", firstnameBox.Text)
        sqlInsertQuery.Parameters.AddWithValue("@lastName", lastNameBox.Text)
        sqlInsertQuery.Parameters.AddWithValue("@email", EmailBox.Text)
        sqlInsertQuery.Parameters.AddWithValue("@phone", phoneBox.Text)
        sqlInsertQuery.Parameters.AddWithValue("@adress", addresBox.Text)
        Try
            connection.Open()
            Try
                sqlInsertQuery.ExecuteNonQuery()
                firstnameBox.Text = ""
                lastNameBox.Text = ""
                EmailBox.Text = ""
                addresBox.Text = ""
                phoneBox.Text = ""
            Catch ex As Exception
                'MsgBox(ex.Message)
                MsgBox("Someting Went Wrong", MsgBoxStyle.Exclamation, "Error")
            End Try
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("Connection To Database Fields", MsgBoxStyle.Exclamation, "Data Error")
        Finally
            connection.Close()
        End Try
    End Sub
End Class