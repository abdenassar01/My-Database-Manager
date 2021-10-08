Public Class Form1
    Dim confirm As Boolean = False

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    'Private Sub meLoad(sender As Object, e As EventArgs) Handles Me.Load
    'End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles checkBtn.Click
        If TextBoxValidation.Text <> "27701" Then
            MsgBox("Your Password Is Wrong Try Again!", MsgBoxStyle.Exclamation, "Password Wrong")
            confirm = False
        Else
            confirm = True
            TextBoxValidation.Hide()
            checkBtn.Hide()
            LabelWelcoming.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If confirm = False Then
            MsgBox("You are not  allowed to see that informations, you need to log in first", MsgBoxStyle.Exclamation, "Log in error")
        Else
            DisplayingPeaple.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If confirm = False Then
            MsgBox("You are not  allowed to see that informations, you need to log in first", MsgBoxStyle.Exclamation, "Log in error")
        Else
            AddingPeaple.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        
        If confirm = False Then
            MsgBox("You are not  allowed to see that informations, you need to log in first", MsgBoxStyle.Exclamation, "Log in error")
        Else
            Me.Hide()
            Note.Show()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If confirm = False Then
            MsgBox("You are not  allowed to see that informations, you need to log in first", MsgBoxStyle.Exclamation, "Log in error")
        Else
            Me.Hide()
            WebsiteManager.Show()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If confirm = False Then
            MsgBox("You are not  allowed to see that informations, you need to log in first", MsgBoxStyle.Exclamation, "Log in error")
        Else
            Me.Hide()
            AccountManager.Show()
        End If
        
    End Sub
End Class
