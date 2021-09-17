<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcashpaidout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcashpaidout))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLSessionID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtSessIDCashPaid = New System.Windows.Forms.TextBox()
        Me.LBLCashpaidoutID = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTillNo = New System.Windows.Forms.TextBox()
        Me.txtCashpaidoutSessionDate = New System.Windows.Forms.TextBox()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CashPaidoutSaveToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ZINCloseToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 32)
        Me.Panel1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(78, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Cash Paid Out"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(139, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Session ID:"
        '
        'LBLSessionID
        '
        Me.LBLSessionID.AutoSize = True
        Me.LBLSessionID.Enabled = False
        Me.LBLSessionID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSessionID.Location = New System.Drawing.Point(93, 24)
        Me.LBLSessionID.Name = "LBLSessionID"
        Me.LBLSessionID.Size = New System.Drawing.Size(0, 14)
        Me.LBLSessionID.TabIndex = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSessIDCashPaid)
        Me.GroupBox1.Controls.Add(Me.LBLCashpaidoutID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTillNo)
        Me.GroupBox1.Controls.Add(Me.txtCashpaidoutSessionDate)
        Me.GroupBox1.Controls.Add(Me.txtAmt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LBLSessionID)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 162)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paid out Details"
        '
        'TxtSessIDCashPaid
        '
        Me.TxtSessIDCashPaid.Enabled = False
        Me.TxtSessIDCashPaid.Location = New System.Drawing.Point(208, 18)
        Me.TxtSessIDCashPaid.Name = "TxtSessIDCashPaid"
        Me.TxtSessIDCashPaid.Size = New System.Drawing.Size(81, 20)
        Me.TxtSessIDCashPaid.TabIndex = 139
        '
        'LBLCashpaidoutID
        '
        Me.LBLCashpaidoutID.AutoSize = True
        Me.LBLCashpaidoutID.Enabled = False
        Me.LBLCashpaidoutID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCashpaidoutID.Location = New System.Drawing.Point(63, 20)
        Me.LBLCashpaidoutID.Name = "LBLCashpaidoutID"
        Me.LBLCashpaidoutID.Size = New System.Drawing.Size(70, 14)
        Me.LBLCashpaidoutID.TabIndex = 138
        Me.LBLCashpaidoutID.Text = "#######"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Ref No"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(93, 46)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(133, 22)
        Me.txtDescription.TabIndex = 136
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Description:"
        '
        'txtTillNo
        '
        Me.txtTillNo.Enabled = False
        Me.txtTillNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTillNo.Location = New System.Drawing.Point(93, 105)
        Me.txtTillNo.Name = "txtTillNo"
        Me.txtTillNo.Size = New System.Drawing.Size(133, 22)
        Me.txtTillNo.TabIndex = 134
        '
        'txtCashpaidoutSessionDate
        '
        Me.txtCashpaidoutSessionDate.Enabled = False
        Me.txtCashpaidoutSessionDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashpaidoutSessionDate.Location = New System.Drawing.Point(93, 133)
        Me.txtCashpaidoutSessionDate.Name = "txtCashpaidoutSessionDate"
        Me.txtCashpaidoutSessionDate.Size = New System.Drawing.Size(133, 22)
        Me.txtCashpaidoutSessionDate.TabIndex = 133
        '
        'txtAmt
        '
        Me.txtAmt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt.Location = New System.Drawing.Point(93, 77)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(133, 22)
        Me.txtAmt.TabIndex = 132
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Till No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Session Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = " Amount:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLogIn)
        Me.GroupBox2.Controls.Add(Me.txtPassword)
        Me.GroupBox2.Controls.Add(Me.txtUsername)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 97)
        Me.GroupBox2.TabIndex = 127
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Authorization"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogIn.Image = CType(resources.GetObject("btnLogIn.Image"), System.Drawing.Image)
        Me.btnLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogIn.Location = New System.Drawing.Point(242, 45)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(62, 28)
        Me.btnLogIn.TabIndex = 172
        Me.btnLogIn.Text = "Login"
        Me.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(104, 66)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(122, 22)
        Me.txtPassword.TabIndex = 128
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(104, 28)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(122, 22)
        Me.txtUsername.TabIndex = 127
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Password:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Login Name:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightGray
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.CashPaidoutSaveToolStripButton3, Me.ZINCloseToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(47, 302)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(191, 32)
        Me.ToolStrip1.TabIndex = 169
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 29)
        Me.ToolStripLabel1.Text = "   "
        '
        'CashPaidoutSaveToolStripButton3
        '
        Me.CashPaidoutSaveToolStripButton3.AutoSize = False
        Me.CashPaidoutSaveToolStripButton3.Image = CType(resources.GetObject("CashPaidoutSaveToolStripButton3.Image"), System.Drawing.Image)
        Me.CashPaidoutSaveToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CashPaidoutSaveToolStripButton3.Name = "CashPaidoutSaveToolStripButton3"
        Me.CashPaidoutSaveToolStripButton3.Size = New System.Drawing.Size(65, 40)
        Me.CashPaidoutSaveToolStripButton3.Text = "&Save"
        '
        'ZINCloseToolStripButton1
        '
        Me.ZINCloseToolStripButton1.AutoSize = False
        Me.ZINCloseToolStripButton1.Image = CType(resources.GetObject("ZINCloseToolStripButton1.Image"), System.Drawing.Image)
        Me.ZINCloseToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZINCloseToolStripButton1.Name = "ZINCloseToolStripButton1"
        Me.ZINCloseToolStripButton1.Size = New System.Drawing.Size(65, 40)
        Me.ZINCloseToolStripButton1.Text = "Clos&e"
        '
        'frmcashpaidout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 336)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "frmcashpaidout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Paid Out"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBLSessionID As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTillNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCashpaidoutSessionDate As System.Windows.Forms.TextBox
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CashPaidoutSaveToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ZINCloseToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents LBLCashpaidoutID As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtSessIDCashPaid As System.Windows.Forms.TextBox
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
End Class
