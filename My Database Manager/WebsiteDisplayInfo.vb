Imports System.Data.SqlClient

Public Class WebsiteDisplayInfo

    'Declaring The Connection String As a global varible
    Dim connection As New SqlConnection("Data Source=DESKTOP-SE47S40 ; Initial Catalog = MyPersonalDB; Integrated Security =SSPI;")

    'The Varaible That Hold The Name of the web site in order to use it in the where clause to Display info About it
    Dim siteName As String = WebsiteManager.dataDisplayer.SelectedItem

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        WebsiteManager.Show()
    End Sub

    Private Sub ClosFormEvent(sender As Object, e As EventArgs) Handles Me.FormClosed
        WebsiteManager.Show()
    End Sub

    Private Sub WebsiteDisplayInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim selectQuery As New SqlCommand("SELECT * FROM Websites WHERE siteName = @siteName ;", connection)

        Try
            connection.Open()
            Try

                'Assagning The parametre Value
                selectQuery.Parameters.AddWithValue("@siteName", siteName)

                Dim infoDisplayer As SqlDataReader = selectQuery.ExecuteReader
                While infoDisplayer.Read()
                    websiteBox.Text = infoDisplayer.Item(1)
                    urlBox.Text = infoDisplayer.Item(2)
                    DiscBox.Text = infoDisplayer.Item(3)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim deleteQuery As New SqlCommand("DELETE FROM Websites WHERE  siteName = @siteName ;", connection)

        deleteQuery.Parameters.AddWithValue("@siteName", siteName)

        Try
            connection.Open()
            Try
                deleteQuery.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Something Went Wrong", MsgBoxStyle.Exclamation, "Error")
            End Try
        Catch ex As Exception
            MsgBox("Connection To Database Field! ", MsgBoxStyle.Exclamation, "Connection Error")
        Finally
            connection.Close()
        End Try

        'calling the function To refresh the content of the listBox
        WebsiteManager.DisplaySite()

        'After Deleting An item We need To go Back becouse there is nothing to be displayed
        Me.Close()
    End Sub

End Class