<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnChangePassword = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.NewPassword = New System.Windows.Forms.TextBox()
        Me.OldPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 35)
        Me.Panel1.TabIndex = 166
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Change Password"
        '
        'UserID
        '
        Me.UserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.UserID.Location = New System.Drawing.Point(131, 42)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(222, 20)
        Me.UserID.TabIndex = 169
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(49, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 176
        Me.Label4.Text = "User Name :"
        '
        'BtnChangePassword
        '
        Me.BtnChangePassword.BackColor = System.Drawing.Color.Aqua
        Me.BtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnChangePassword.Location = New System.Drawing.Point(107, 152)
        Me.BtnChangePassword.Name = "BtnChangePassword"
        Me.BtnChangePassword.Size = New System.Drawing.Size(60, 30)
        Me.BtnChangePassword.TabIndex = 174
        Me.BtnChangePassword.Text = "&Update"
        Me.BtnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnChangePassword.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 15)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Confirm Password :"
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Location = New System.Drawing.Point(131, 126)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword.Size = New System.Drawing.Size(222, 20)
        Me.ConfirmPassword.TabIndex = 173
        '
        'NewPassword
        '
        Me.NewPassword.Location = New System.Drawing.Point(131, 100)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPassword.Size = New System.Drawing.Size(222, 20)
        Me.NewPassword.TabIndex = 172
        '
        'OldPassword
        '
        Me.OldPassword.Location = New System.Drawing.Point(131, 67)
        Me.OldPassword.Name = "OldPassword"
        Me.OldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.OldPassword.Size = New System.Drawing.Size(222, 20)
        Me.OldPassword.TabIndex = 170
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(30, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "New Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(36, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "Old Password :"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(210, 152)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(56, 30)
        Me.btnClose.TabIndex = 177
        Me.btnClose.Text = "&Cancel"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 187)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.UserID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnChangePassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ConfirmPassword)
        Me.Controls.Add(Me.NewPassword)
        Me.Controls.Add(Me.OldPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "frmChangePassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnChangePassword As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents NewPassword As System.Windows.Forms.TextBox
    Friend WithEvents OldPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClose As Button
End Class
