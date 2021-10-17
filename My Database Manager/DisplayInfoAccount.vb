Imports System.Data.SqlClient

Public Class DisplayInfoAccount

    Dim connection As New SqlConnection("Data Source=DESKTOP-SE47S40 ; Initial Catalog = MyPersonalDB; Integrated Security =SSPI;")

    Private Sub displayInfo()
        Dim selectQuery As New SqlCommand("Select * From AccountManger Where NameSite = @name;", connection)

        Try
            connection.Open()
            Try
                selectQuery.Parameters.AddWithValue("@name", AccountManager.WebsitesName.SelectedItem)

                Dim dataReader As SqlDataReader = selectQuery.ExecuteReader

                While dataReader.Read()
                    nameBox.Text = dataReader.Item(1)
                    urlBox.Text = dataReader.Item(5)
                    loginBox.Text = dataReader.Item(2)
                    passwordBox.Text = dataReader.Item(3)
                    additInfo.Text = dataReader.Item(4)
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
        AccountManager.Show()
    End Sub

    Private Sub MeLoad(sender As Object, e As EventArgs) Handles MyBase.Shown
        displayInfo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles delete.Click
        'Write the command to delete the priticuler item from database
        Dim deleteQuery As New SqlCommand("delete From AccountManger Where NameSite = @name;", connection)

        Try
            connection.Open()
            Try
                deleteQuery.Parameters.AddWithValue("@name", AccountManager.WebsitesName.SelectedItem)

                If MsgBox("Are You Really Want To Remove That Item", MsgBoxStyle.YesNo, "Warning") = 6 Then
                    deleteQuery.ExecuteNonQuery()
                    MsgBox("item removed saccesfully", MsgBoxStyle.Information, "sacces")
                    Me.Close()
                    AccountManager.SqlReader()
                    AccountManager.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If passwordBox.UseSystemPasswordChar = False Then
            passwordBox.UseSystemPasswordChar = True
        Else
            passwordBox.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        AccountManager.Show()

    End Sub
End Class