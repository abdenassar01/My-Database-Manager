<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountManager))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RememberBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.urlText = New System.Windows.Forms.TextBox()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.loginText = New System.Windows.Forms.TextBox()
        Me.passwordText = New System.Windows.Forms.TextBox()
        Me.additInfoText = New System.Windows.Forms.TextBox()
        Me.WebsitesName = New System.Windows.Forms.ListBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.RememberBtn)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.urlText)
        Me.Panel2.Controls.Add(Me.nameText)
        Me.Panel2.Controls.Add(Me.loginText)
        Me.Panel2.Controls.Add(Me.passwordText)
        Me.Panel2.Controls.Add(Me.additInfoText)
        Me.Panel2.Location = New System.Drawing.Point(185, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(519, 416)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkMagenta
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(421, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 24)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "<>"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RememberBtn
        '
        Me.RememberBtn.BackColor = System.Drawing.Color.DeepPink
        Me.RememberBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RememberBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RememberBtn.FlatAppearance.BorderSize = 0
        Me.RememberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.RememberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RememberBtn.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RememberBtn.ForeColor = System.Drawing.Color.White
        Me.RememberBtn.Location = New System.Drawing.Point(287, 357)
        Me.RememberBtn.Name = "RememberBtn"
        Me.RememberBtn.Size = New System.Drawing.Size(218, 48)
        Me.RememberBtn.TabIndex = 7
        Me.RememberBtn.Text = "Remember Me"
        Me.RememberBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(48, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(428, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fill The Form With Correct Info"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Additionl Info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(25, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Login"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(25, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Website URL"
        '
        'urlText
        '
        Me.urlText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.urlText.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.urlText.Location = New System.Drawing.Point(191, 110)
        Me.urlText.Name = "urlText"
        Me.urlText.Size = New System.Drawing.Size(268, 24)
        Me.urlText.TabIndex = 0
        '
        'nameText
        '
        Me.nameText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nameText.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameText.Location = New System.Drawing.Point(191, 70)
        Me.nameText.MaxLength = 15
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(268, 24)
        Me.nameText.TabIndex = 0
        '
        'loginText
        '
        Me.loginText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.loginText.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginText.Location = New System.Drawing.Point(191, 153)
        Me.loginText.Name = "loginText"
        Me.loginText.Size = New System.Drawing.Size(268, 24)
        Me.loginText.TabIndex = 0
        '
        'passwordText
        '
        Me.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passwordText.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordText.Location = New System.Drawing.Point(191, 201)
        Me.passwordText.Name = "passwordText"
        Me.passwordText.Size = New System.Drawing.Size(268, 24)
        Me.passwordText.TabIndex = 0
        Me.passwordText.UseSystemPasswordChar = True
        '
        'additInfoText
        '
        Me.additInfoText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.additInfoText.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.additInfoText.Location = New System.Drawing.Point(191, 252)
        Me.additInfoText.Multiline = True
        Me.additInfoText.Name = "additInfoText"
        Me.additInfoText.Size = New System.Drawing.Size(268, 99)
        Me.additInfoText.TabIndex = 0
        '
        'WebsitesName
        '
        Me.WebsitesName.BackColor = System.Drawing.Color.DeepPink
        Me.WebsitesName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WebsitesName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebsitesName.ForeColor = System.Drawing.Color.White
        Me.WebsitesName.FormattingEnabled = True
        Me.WebsitesName.ItemHeight = 23
        Me.WebsitesName.Location = New System.Drawing.Point(0, 0)
        Me.WebsitesName.Name = "WebsitesName"
        Me.WebsitesName.Size = New System.Drawing.Size(189, 414)
        Me.WebsitesName.TabIndex = 2
        '
        'AccountManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 411)
        Me.Controls.Add(Me.WebsitesName)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(718, 450)
        Me.Name = "AccountManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Manager"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RememberBtn As System.Windows.Forms.Button
    Friend WithEvents WebsitesName As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents additInfoText As System.Windows.Forms.TextBox
    Friend WithEvents urlText As System.Windows.Forms.TextBox
    Friend WithEvents nameText As System.Windows.Forms.TextBox
    Friend WithEvents loginText As System.Windows.Forms.TextBox
    Friend WithEvents passwordText As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
