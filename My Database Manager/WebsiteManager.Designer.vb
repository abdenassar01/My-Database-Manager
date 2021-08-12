<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebsiteManager
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
        Me.dataDisplayer = New System.Windows.Forms.CheckedListBox()
        Me.websiteName = New System.Windows.Forms.TextBox()
        Me.websiteUrl = New System.Windows.Forms.TextBox()
        Me.websiteDisc = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dataDisplayer
        '
        Me.dataDisplayer.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.dataDisplayer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataDisplayer.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataDisplayer.FormattingEnabled = True
        Me.dataDisplayer.Location = New System.Drawing.Point(0, 0)
        Me.dataDisplayer.Name = "dataDisplayer"
        Me.dataDisplayer.Size = New System.Drawing.Size(180, 352)
        Me.dataDisplayer.TabIndex = 0
        '
        'websiteName
        '
        Me.websiteName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.websiteName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.websiteName.Location = New System.Drawing.Point(350, 51)
        Me.websiteName.Name = "websiteName"
        Me.websiteName.Size = New System.Drawing.Size(350, 20)
        Me.websiteName.TabIndex = 1
        '
        'websiteUrl
        '
        Me.websiteUrl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.websiteUrl.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.websiteUrl.Location = New System.Drawing.Point(350, 79)
        Me.websiteUrl.Name = "websiteUrl"
        Me.websiteUrl.Size = New System.Drawing.Size(350, 20)
        Me.websiteUrl.TabIndex = 2
        '
        'websiteDisc
        '
        Me.websiteDisc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.websiteDisc.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.websiteDisc.Location = New System.Drawing.Point(350, 106)
        Me.websiteDisc.Name = "websiteDisc"
        Me.websiteDisc.Size = New System.Drawing.Size(350, 180)
        Me.websiteDisc.TabIndex = 3
        Me.websiteDisc.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(180, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(532, 43)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add New Account"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(214, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name           : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(214, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "URL              :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(214, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Discription  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(261, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(368, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Try To Use A Unique Name"
        '
        'WebsiteManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(712, 347)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.websiteDisc)
        Me.Controls.Add(Me.websiteUrl)
        Me.Controls.Add(Me.websiteName)
        Me.Controls.Add(Me.dataDisplayer)
        Me.MaximumSize = New System.Drawing.Size(728, 386)
        Me.MinimumSize = New System.Drawing.Size(728, 386)
        Me.Name = "WebsiteManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Website Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataDisplayer As System.Windows.Forms.CheckedListBox
    Friend WithEvents websiteName As System.Windows.Forms.TextBox
    Friend WithEvents websiteUrl As System.Windows.Forms.TextBox
    Friend WithEvents websiteDisc As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
