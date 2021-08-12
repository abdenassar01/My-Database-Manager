Imports System.Data.SqlClient

Public Class WebsiteManager

    'Declaring The Connection String As a global varible
    Dim connection As New SqlConnection("Data Source=DESKTOP-SE47S40 ; Initial Catalog = MyPersonalDB; Integrated Security =SSPI;")

   

    Public Sub DisplaySite()

        Dim DisplayDataQuery As New SqlCommand("SELECT * FROM Websites;", connection)

        'Handling The exeption of Connection Stayed Open From The first Call of The Function
        connection.Close()

        'Handling The Duplicate 
        dataDisplayer.Items.Clear()

        Try
            connection.Open()
            Try
                Dim dataReader As SqlDataReader = DisplayDataQuery.ExecuteReader

                While dataReader.Read()
                    dataDisplayer.Items.Add(dataReader.Item(1))
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
    Private Sub WebsiteManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySite()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Using Parametre Save the apps from the SQL Injenction attack
        Dim DisplayDataQuery As New SqlCommand("INSERT INTO Websites Values(@webSiteName, @websiteUrl, @Discription);", connection)

        Try
            connection.Open()
            Try
                If websiteName.Text = "" Or websiteUrl.Text = "" Then
                    MsgBox("You Must Provide Enough Data", MsgBoxStyle.Critical, "Missing Data")
                Else
                    'Assagning the the values to the parametre 
                    DisplayDataQuery.Parameters.AddWithValue("@webSiteName", websiteName.Text)
                    DisplayDataQuery.Parameters.AddWithValue("@websiteUrl", websiteUrl.Text)
                    DisplayDataQuery.Parameters.AddWithValue("@Discription", websiteDisc.Text)

                    DisplayDataQuery.ExecuteNonQuery()

                    websiteName.Text = ""
                    websiteUrl.Text = ""
                    websiteDisc.Text = ""

                    'Refrech The ListBox To Desplay The added Item
                    DisplaySite()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub dataDisplayer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dataDisplayer.SelectedIndexChanged
        Me.Hide()
        WebsiteDisplayInfo.Show()
    End Sub

    Private Sub FormClosedSub(sender As Object, e As EventArgs) Handles Me.FormClosing
        Form1.Show()
    End Sub
End Class