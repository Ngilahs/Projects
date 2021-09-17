<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCash = New System.Windows.Forms.MaskedTextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtreceiptno = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RDBCashPayment = New System.Windows.Forms.RadioButton()
        Me.RDBMpesa = New System.Windows.Forms.RadioButton()
        Me.RDBVisacard = New System.Windows.Forms.RadioButton()
        Me.txtTransDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBNCredit = New System.Windows.Forms.RadioButton()
        Me.LBLTRNID = New System.Windows.Forms.Label()
        Me.Mnstrp_ShortCutMenu = New System.Windows.Forms.MenuStrip()
        Me.ESCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Mnstrp_ShortCutMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCash)
        Me.GroupBox1.Controls.Add(Me.txtChange)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 188)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(213, 74)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(265, 60)
        Me.txtCash.TabIndex = 11
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.Color.White
        Me.txtChange.Enabled = False
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(213, 140)
        Me.txtChange.Multiline = True
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(266, 42)
        Me.txtChange.TabIndex = 13
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "CHANGE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CASH TENDERED:"
        '
        'txtTA
        '
        Me.txtTA.BackColor = System.Drawing.Color.White
        Me.txtTA.Enabled = False
        Me.txtTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTA.Location = New System.Drawing.Point(213, 19)
        Me.txtTA.Multiline = True
        Me.txtTA.Name = "txtTA"
        Me.txtTA.Size = New System.Drawing.Size(265, 49)
        Me.txtTA.TabIndex = 9
        Me.txtTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "TOTAL AMOUNT:"
        '
        'txtreceiptno
        '
        Me.txtreceiptno.Enabled = False
        Me.txtreceiptno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreceiptno.Location = New System.Drawing.Point(68, 305)
        Me.txtreceiptno.Name = "txtreceiptno"
        Me.txtreceiptno.Size = New System.Drawing.Size(97, 26)
        Me.txtreceiptno.TabIndex = 115
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1, 310)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 17)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Rcpt No:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(86, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(357, 73)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "PAYMENT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 62)
        Me.Panel1.TabIndex = 11
        '
        'RDBCashPayment
        '
        Me.RDBCashPayment.AutoSize = True
        Me.RDBCashPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBCashPayment.Location = New System.Drawing.Point(12, 19)
        Me.RDBCashPayment.Name = "RDBCashPayment"
        Me.RDBCashPayment.Size = New System.Drawing.Size(68, 22)
        Me.RDBCashPayment.TabIndex = 116
        Me.RDBCashPayment.TabStop = True
        Me.RDBCashPayment.Text = "Cash"
        Me.RDBCashPayment.UseVisualStyleBackColor = True
        '
        'RDBMpesa
        '
        Me.RDBMpesa.AutoSize = True
        Me.RDBMpesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBMpesa.Location = New System.Drawing.Point(84, 19)
        Me.RDBMpesa.Name = "RDBMpesa"
        Me.RDBMpesa.Size = New System.Drawing.Size(85, 22)
        Me.RDBMpesa.TabIndex = 117
        Me.RDBMpesa.TabStop = True
        Me.RDBMpesa.Text = "M-pesa"
        Me.RDBMpesa.UseVisualStyleBackColor = True
        '
        'RDBVisacard
        '
        Me.RDBVisacard.AutoSize = True
        Me.RDBVisacard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBVisacard.Location = New System.Drawing.Point(313, 19)
        Me.RDBVisacard.Name = "RDBVisacard"
        Me.RDBVisacard.Size = New System.Drawing.Size(146, 22)
        Me.RDBVisacard.TabIndex = 118
        Me.RDBVisacard.TabStop = True
        Me.RDBVisacard.Text = "Visa/Dedit Card"
        Me.RDBVisacard.UseVisualStyleBackColor = True
        '
        'txtTransDate
        '
        Me.txtTransDate.Enabled = False
        Me.txtTransDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransDate.Location = New System.Drawing.Point(226, 306)
        Me.txtTransDate.Name = "txtTransDate"
        Me.txtTransDate.Size = New System.Drawing.Size(87, 26)
        Me.txtTransDate.TabIndex = 119
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(171, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Date :"
        Me.Label4.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(433, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 31)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBNCredit)
        Me.GroupBox2.Controls.Add(Me.RDBVisacard)
        Me.GroupBox2.Controls.Add(Me.RDBMpesa)
        Me.GroupBox2.Controls.Add(Me.RDBCashPayment)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(482, 45)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Options"
        '
        'RBNCredit
        '
        Me.RBNCredit.AutoSize = True
        Me.RBNCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBNCredit.Location = New System.Drawing.Point(191, 20)
        Me.RBNCredit.Name = "RBNCredit"
        Me.RBNCredit.Size = New System.Drawing.Size(74, 22)
        Me.RBNCredit.TabIndex = 119
        Me.RBNCredit.TabStop = True
        Me.RBNCredit.Text = "Credit"
        Me.RBNCredit.UseVisualStyleBackColor = True
        '
        'LBLTRNID
        '
        Me.LBLTRNID.AutoSize = True
        Me.LBLTRNID.Location = New System.Drawing.Point(345, 310)
        Me.LBLTRNID.Name = "LBLTRNID"
        Me.LBLTRNID.Size = New System.Drawing.Size(16, 17)
        Me.LBLTRNID.TabIndex = 123
        Me.LBLTRNID.Text = "#"
        '
        'Mnstrp_ShortCutMenu
        '
        Me.Mnstrp_ShortCutMenu.AutoSize = False
        Me.Mnstrp_ShortCutMenu.BackColor = System.Drawing.Color.Transparent
        Me.Mnstrp_ShortCutMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.Mnstrp_ShortCutMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ESCToolStripMenuItem})
        Me.Mnstrp_ShortCutMenu.Location = New System.Drawing.Point(164, 297)
        Me.Mnstrp_ShortCutMenu.Name = "Mnstrp_ShortCutMenu"
        Me.Mnstrp_ShortCutMenu.Size = New System.Drawing.Size(28, 29)
        Me.Mnstrp_ShortCutMenu.TabIndex = 125
        Me.Mnstrp_ShortCutMenu.Text = "MenuStrip1"
        Me.Mnstrp_ShortCutMenu.Visible = False
        '
        'ESCToolStripMenuItem
        '
        Me.ESCToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ESCToolStripMenuItem.Name = "ESCToolStripMenuItem"
        Me.ESCToolStripMenuItem.Size = New System.Drawing.Size(123, 25)
        Me.ESCToolStripMenuItem.Text = "QuickPurchase"
        '
        'frmPayment
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(488, 340)
        Me.Controls.Add(Me.Mnstrp_ShortCutMenu)
        Me.Controls.Add(Me.LBLTRNID)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTransDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtreceiptno)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Mnstrp_ShortCutMenu.ResumeLayout(False)
        Me.Mnstrp_ShortCutMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtreceiptno As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RDBCashPayment As System.Windows.Forms.RadioButton
    Friend WithEvents RDBMpesa As System.Windows.Forms.RadioButton
    Friend WithEvents RDBVisacard As System.Windows.Forms.RadioButton
    Friend WithEvents txtTransDate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBNCredit As System.Windows.Forms.RadioButton
    Friend WithEvents LBLTRNID As System.Windows.Forms.Label
    Friend WithEvents Mnstrp_ShortCutMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ESCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
