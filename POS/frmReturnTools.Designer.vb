<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnTools
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReturnTools))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEnterIssuanceNo = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIssuedto = New System.Windows.Forms.TextBox()
        Me.LblIssuanceNo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIssuancedate = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIssuanceNo2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtqtyreversed = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtitemDescription = New System.Windows.Forms.TextBox()
        Me.txttoolNo = New System.Windows.Forms.TextBox()
        Me.txtQuantityIssued = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.RetrunSaleToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.PostChangesToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 25)
        Me.Panel1.TabIndex = 12
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.DarkOrange
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(181, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(112, 20)
        Me.Label29.TabIndex = 223
        Me.Label29.Text = "Return Tools"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtEnterIssuanceNo)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(102, 80)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Issuance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Aqua
        Me.Label3.Location = New System.Drawing.Point(11, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Issuance No "
        '
        'txtEnterIssuanceNo
        '
        Me.txtEnterIssuanceNo.Location = New System.Drawing.Point(2, 46)
        Me.txtEnterIssuanceNo.Name = "txtEnterIssuanceNo"
        Me.txtEnterIssuanceNo.Size = New System.Drawing.Size(94, 20)
        Me.txtEnterIssuanceNo.TabIndex = 42
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txtIssuedto)
        Me.GroupBox5.Controls.Add(Me.LblIssuanceNo)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.txtUserName)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtIssuancedate)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Location = New System.Drawing.Point(110, 33)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(382, 77)
        Me.GroupBox5.TabIndex = 34
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Issuance Details"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(174, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 212
        Me.Label7.Text = "Issued To:"
        '
        'txtIssuedto
        '
        Me.txtIssuedto.Enabled = False
        Me.txtIssuedto.Location = New System.Drawing.Point(247, 50)
        Me.txtIssuedto.Name = "txtIssuedto"
        Me.txtIssuedto.Size = New System.Drawing.Size(113, 20)
        Me.txtIssuedto.TabIndex = 211
        '
        'LblIssuanceNo
        '
        Me.LblIssuanceNo.Enabled = False
        Me.LblIssuanceNo.Location = New System.Drawing.Point(78, 20)
        Me.LblIssuanceNo.Margin = New System.Windows.Forms.Padding(2)
        Me.LblIssuanceNo.Name = "LblIssuanceNo"
        Me.LblIssuanceNo.Size = New System.Drawing.Size(90, 20)
        Me.LblIssuanceNo.TabIndex = 206
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 193
        Me.Label20.Text = "Issued By:"
        '
        'txtUserName
        '
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(78, 50)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(90, 20)
        Me.txtUserName.TabIndex = 192
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(174, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Date Issued:"
        '
        'txtIssuancedate
        '
        Me.txtIssuancedate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIssuancedate.Enabled = False
        Me.txtIssuancedate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssuancedate.Location = New System.Drawing.Point(247, 19)
        Me.txtIssuancedate.MaxLength = 50
        Me.txtIssuancedate.Name = "txtIssuancedate"
        Me.txtIssuancedate.Size = New System.Drawing.Size(113, 22)
        Me.txtIssuancedate.TabIndex = 170
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(5, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Issuance No :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIssuanceNo2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtqtyreversed)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtitemDescription)
        Me.GroupBox1.Controls.Add(Me.txttoolNo)
        Me.GroupBox1.Controls.Add(Me.txtQuantityIssued)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 66)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'txtIssuanceNo2
        '
        Me.txtIssuanceNo2.Enabled = False
        Me.txtIssuanceNo2.Location = New System.Drawing.Point(355, 37)
        Me.txtIssuanceNo2.Name = "txtIssuanceNo2"
        Me.txtIssuanceNo2.Size = New System.Drawing.Size(104, 23)
        Me.txtIssuanceNo2.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(367, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Issuance No:"
        '
        'txtqtyreversed
        '
        Me.txtqtyreversed.Location = New System.Drawing.Point(283, 37)
        Me.txtqtyreversed.Name = "txtqtyreversed"
        Me.txtqtyreversed.Size = New System.Drawing.Size(66, 23)
        Me.txtqtyreversed.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DarkOrange
        Me.Label11.Location = New System.Drawing.Point(176, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Qty to Return:"
        '
        'txtitemDescription
        '
        Me.txtitemDescription.Enabled = False
        Me.txtitemDescription.Location = New System.Drawing.Point(88, 37)
        Me.txtitemDescription.Name = "txtitemDescription"
        Me.txtitemDescription.Size = New System.Drawing.Size(82, 23)
        Me.txtitemDescription.TabIndex = 15
        '
        'txttoolNo
        '
        Me.txttoolNo.Enabled = False
        Me.txttoolNo.Location = New System.Drawing.Point(88, 11)
        Me.txttoolNo.Name = "txttoolNo"
        Me.txttoolNo.Size = New System.Drawing.Size(82, 23)
        Me.txttoolNo.TabIndex = 14
        '
        'txtQuantityIssued
        '
        Me.txtQuantityIssued.Enabled = False
        Me.txtQuantityIssued.Location = New System.Drawing.Point(283, 11)
        Me.txtQuantityIssued.Name = "txtQuantityIssued"
        Me.txtQuantityIssued.Size = New System.Drawing.Size(66, 23)
        Me.txtQuantityIssued.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(176, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Quantity Issued:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Description :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tool No :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgw)
        Me.GroupBox4.Controls.Add(Me.BtnReset)
        Me.GroupBox4.Controls.Add(Me.dtpDateTo)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox4.Controls.Add(Me.btnGetData)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(2, 188)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(490, 212)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Select Details"
        '
        'dgw
        '
        Me.dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column7, Me.PriceColumn})
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(6, 45)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(474, 157)
        Me.dgw.TabIndex = 43
        '
        'Column4
        '
        Me.Column4.HeaderText = "Issuance No"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tool No"
        Me.Column1.Name = "Column1"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Description"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'PriceColumn
        '
        Me.PriceColumn.HeaderText = "Qty Issued"
        Me.PriceColumn.Name = "PriceColumn"
        '
        'BtnReset
        '
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(428, 17)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(52, 20)
        Me.BtnReset.TabIndex = 40
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(172, 16)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(79, 23)
        Me.dtpDateTo.TabIndex = 39
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(140, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(26, 15)
        Me.Label26.TabIndex = 38
        Me.Label26.Text = "To :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 22)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(41, 15)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = "From :"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(53, 16)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(81, 23)
        Me.dtpDateFrom.TabIndex = 36
        '
        'btnGetData
        '
        Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetData.Location = New System.Drawing.Point(266, 17)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(61, 20)
        Me.btnGetData.TabIndex = 35
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.RetrunSaleToolStripButton2, Me.PostChangesToolStripButton5, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(110, 403)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(265, 40)
        Me.ToolStrip1.TabIndex = 37
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 37)
        Me.ToolStripLabel1.Text = "   "
        '
        'RetrunSaleToolStripButton2
        '
        Me.RetrunSaleToolStripButton2.Image = CType(resources.GetObject("RetrunSaleToolStripButton2.Image"), System.Drawing.Image)
        Me.RetrunSaleToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RetrunSaleToolStripButton2.Name = "RetrunSaleToolStripButton2"
        Me.RetrunSaleToolStripButton2.Size = New System.Drawing.Size(62, 37)
        Me.RetrunSaleToolStripButton2.Text = "Return"
        '
        'PostChangesToolStripButton5
        '
        Me.PostChangesToolStripButton5.Image = CType(resources.GetObject("PostChangesToolStripButton5.Image"), System.Drawing.Image)
        Me.PostChangesToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PostChangesToolStripButton5.Name = "PostChangesToolStripButton5"
        Me.PostChangesToolStripButton5.Size = New System.Drawing.Size(99, 37)
        Me.PostChangesToolStripButton5.Text = "Post Changes"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(65, 40)
        Me.ToolStripButton1.Text = "Clos&e"
        '
        'frmReturnTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 447)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmReturnTools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEnterIssuanceNo As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LblIssuanceNo As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtIssuancedate As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIssuanceNo2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtqtyreversed As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtitemDescription As TextBox
    Friend WithEvents txttoolNo As TextBox
    Friend WithEvents txtQuantityIssued As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgw As DataGridView
    Friend WithEvents BtnReset As Button
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents btnGetData As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents RetrunSaleToolStripButton2 As ToolStripButton
    Friend WithEvents PostChangesToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIssuedto As TextBox
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents PriceColumn As DataGridViewTextBoxColumn
End Class
