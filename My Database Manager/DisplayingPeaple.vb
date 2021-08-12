Imports System.Data.SqlClient

Public Class DisplayingPeaple
    Dim connection As New SqlConnection("Data Source=DESKTOP-SE47S40 ; Initial Catalog = MyPersonalDB; Integrated Security =SSPI;")
    Dim querySelectPeaple As New SqlCommand("Select * from Peaple;", connection)

    Private Sub DisplayingPeaple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        Dim querySelectPeaple As New SqlCommand("Select * from Peaple;", connection)
        firstNameText.Text = vbCrLf
        lastNameText.Text = vbCrLf
        emailText.Text = vbCrLf
        phoneText.Text = vbCrLf
        adressText.Text = vbCrLf
        Try
            connection.Open()
            Try
                Dim datareader As SqlDataReader = querySelectPeaple.ExecuteReader

                While datareader.Read()
                    firstNameText.Text += datareader.Item(1) & vbCrLf & "----------------------" & vbCrLf
                    lastNameText.Text += datareader.Item(2) & vbCrLf & "---------------------" & vbCrLf
                    emailText.Text += datareader.Item(3) & vbCrLf & "------------------------------------------" & vbCrLf
                    phoneText.Text += datareader.Item(4) & vbCrLf & "----------------------------" & vbCrLf
                    adressText.Text += datareader.Item(5) & vbCrLf & "------------------------------------" & vbCrLf
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox("Connection To Database Fields", MsgBoxStyle.Exclamation, "Data Error")
        End Try
    End Sub

    Private Sub closeForm() Handles Me.FormClosed
        Form1.Show()
    End Sub
End Class