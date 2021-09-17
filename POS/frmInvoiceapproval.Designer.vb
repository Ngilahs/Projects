<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvoiceapproval
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceapproval))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgw1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotIncVat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtWorkstation = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSchmRefNo = New System.Windows.Forms.TextBox()
        Me.chkCancelDelivery = New System.Windows.Forms.CheckBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.chkApproveDelivery = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSchemeName = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCountyName = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtConstituencyName = New System.Windows.Forms.TextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtSubcontrt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotAmt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTxNo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ApproveInvoiceToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.CancelInvoiceToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.CloseInvoiceapprovalToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 27)
        Me.Panel1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(426, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 223
        Me.Label7.Text = "Statement Approval"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgw1)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 408)
        Me.GroupBox2.TabIndex = 169
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pending Statements"
        '
        'dgw1
        '
        Me.dgw1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgw1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgw1.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw1.Location = New System.Drawing.Point(6, 16)
        Me.dgw1.MultiSelect = False
        Me.dgw1.Name = "dgw1"
        Me.dgw1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw1.Size = New System.Drawing.Size(307, 386)
        Me.dgw1.TabIndex = 44
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Invoice "
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Scheme"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sub-Contrct"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txtTotIncVat)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtWorkstation)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.txtSchmRefNo)
        Me.GroupBox5.Controls.Add(Me.chkCancelDelivery)
        Me.GroupBox5.Controls.Add(Me.txtUserName)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.chkApproveDelivery)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.txtSchemeName)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txtCountyName)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.txtConstituencyName)
        Me.GroupBox5.Controls.Add(Me.txtVat)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.txtSubcontrt)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtTotAmt)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtTxNo)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtSchemeID)
        Me.GroupBox5.Controls.Add(Me.txtCountyID)
        Me.GroupBox5.Controls.Add(Me.txtConstituencyID)
        Me.GroupBox5.Location = New System.Drawing.Point(327, 35)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(642, 124)
        Me.GroupBox5.TabIndex = 170
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Statement Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(361, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 226
        Me.Label5.Text = "Tot Inc Vat:"
        '
        'txtTotIncVat
        '
        Me.txtTotIncVat.Enabled = False
        Me.txtTotIncVat.Location = New System.Drawing.Point(438, 98)
        Me.txtTotIncVat.Name = "txtTotIncVat"
        Me.txtTotIncVat.Size = New System.Drawing.Size(123, 20)
        Me.txtTotIncVat.TabIndex = 225
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(361, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 224
        Me.Label8.Text = "Workstation"
        '
        'txtWorkstation
        '
        Me.txtWorkstation.Enabled = False
        Me.txtWorkstation.Location = New System.Drawing.Point(438, 73)
        Me.txtWorkstation.Name = "txtWorkstation"
        Me.txtWorkstation.Size = New System.Drawing.Size(123, 20)
        Me.txtWorkstation.TabIndex = 223
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(361, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 221
        Me.Label10.Text = "Schm ref:"
        '
        'txtSchmRefNo
        '
        Me.txtSchmRefNo.BackColor = System.Drawing.Color.White
        Me.txtSchmRefNo.Enabled = False
        Me.txtSchmRefNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchmRefNo.Location = New System.Drawing.Point(438, 45)
        Me.txtSchmRefNo.MaxLength = 50
        Me.txtSchmRefNo.Name = "txtSchmRefNo"
        Me.txtSchmRefNo.Size = New System.Drawing.Size(123, 22)
        Me.txtSchmRefNo.TabIndex = 222
        '
        'chkCancelDelivery
        '
        Me.chkCancelDelivery.AutoSize = True
        Me.chkCancelDelivery.Location = New System.Drawing.Point(574, 97)
        Me.chkCancelDelivery.Name = "chkCancelDelivery"
        Me.chkCancelDelivery.Size = New System.Drawing.Size(62, 17)
        Me.chkCancelDelivery.TabIndex = 214
        Me.chkCancelDelivery.Text = "Cancel "
        Me.chkCancelDelivery.UseVisualStyleBackColor = True
        '
        'txtUserName
        '
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(250, 19)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(108, 20)
        Me.txtUserName.TabIndex = 192
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(201, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 193
        Me.Label20.Text = "Created:"
        '
        'chkApproveDelivery
        '
        Me.chkApproveDelivery.AutoSize = True
        Me.chkApproveDelivery.Location = New System.Drawing.Point(567, 17)
        Me.chkApproveDelivery.Name = "chkApproveDelivery"
        Me.chkApproveDelivery.Size = New System.Drawing.Size(69, 17)
        Me.chkApproveDelivery.TabIndex = 213
        Me.chkApproveDelivery.Text = "Approve "
        Me.chkApproveDelivery.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 210
        Me.Label6.Text = "Vat:"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Enabled = False
        Me.txtInvoiceNo.Location = New System.Drawing.Point(78, 20)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(119, 20)
        Me.txtInvoiceNo.TabIndex = 206
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 74)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(52, 13)
        Me.Label24.TabIndex = 201
        Me.Label24.Text = "Scheme: "
        '
        'txtSchemeName
        '
        Me.txtSchemeName.Enabled = False
        Me.txtSchemeName.Location = New System.Drawing.Point(78, 70)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(119, 20)
        Me.txtSchemeName.TabIndex = 200
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(201, 52)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(46, 13)
        Me.Label23.TabIndex = 199
        Me.Label23.Text = "County: "
        '
        'txtCountyName
        '
        Me.txtCountyName.Enabled = False
        Me.txtCountyName.Location = New System.Drawing.Point(250, 45)
        Me.txtCountyName.Name = "txtCountyName"
        Me.txtCountyName.Size = New System.Drawing.Size(108, 20)
        Me.txtCountyName.TabIndex = 198
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(361, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 13)
        Me.Label22.TabIndex = 197
        Me.Label22.Text = "Constituency:"
        '
        'txtConstituencyName
        '
        Me.txtConstituencyName.Enabled = False
        Me.txtConstituencyName.Location = New System.Drawing.Point(438, 17)
        Me.txtConstituencyName.Name = "txtConstituencyName"
        Me.txtConstituencyName.Size = New System.Drawing.Size(123, 20)
        Me.txtConstituencyName.TabIndex = 196
        '
        'txtVat
        '
        Me.txtVat.Enabled = False
        Me.txtVat.Location = New System.Drawing.Point(250, 100)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(108, 20)
        Me.txtVat.TabIndex = 194
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 191
        Me.Label19.Text = "Sub-Contrct:"
        '
        'txtSubcontrt
        '
        Me.txtSubcontrt.Enabled = False
        Me.txtSubcontrt.Location = New System.Drawing.Point(78, 45)
        Me.txtSubcontrt.Name = "txtSubcontrt"
        Me.txtSubcontrt.Size = New System.Drawing.Size(119, 20)
        Me.txtSubcontrt.TabIndex = 190
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 187
        Me.Label9.Text = "Total Amt"
        '
        'txtTotAmt
        '
        Me.txtTotAmt.Enabled = False
        Me.txtTotAmt.Location = New System.Drawing.Point(76, 98)
        Me.txtTotAmt.Name = "txtTotAmt"
        Me.txtTotAmt.Size = New System.Drawing.Size(121, 20)
        Me.txtTotAmt.TabIndex = 186
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(201, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Tx No:"
        '
        'txtTxNo
        '
        Me.txtTxNo.BackColor = System.Drawing.Color.White
        Me.txtTxNo.Enabled = False
        Me.txtTxNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTxNo.Location = New System.Drawing.Point(250, 71)
        Me.txtTxNo.MaxLength = 50
        Me.txtTxNo.Name = "txtTxNo"
        Me.txtTxNo.Size = New System.Drawing.Size(108, 22)
        Me.txtTxNo.TabIndex = 170
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(5, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Invoice No :"
        '
        'txtSchemeID
        '
        Me.txtSchemeID.Location = New System.Drawing.Point(134, 70)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(12, 20)
        Me.txtSchemeID.TabIndex = 209
        Me.txtSchemeID.Visible = False
        '
        'txtCountyID
        '
        Me.txtCountyID.Location = New System.Drawing.Point(300, 45)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(12, 20)
        Me.txtCountyID.TabIndex = 207
        Me.txtCountyID.Visible = False
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.Location = New System.Drawing.Point(485, 17)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(12, 20)
        Me.txtConstituencyID.TabIndex = 208
        Me.txtConstituencyID.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgw)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox1.Controls.Add(Me.btnGetData)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(327, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 284)
        Me.GroupBox1.TabIndex = 171
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Select Item "
        '
        'dgw
        '
        Me.dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column7, Me.PriceColumn, Me.colUoM, Me.ColRate, Me.Column10})
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(9, 51)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(626, 227)
        Me.dgw.TabIndex = 43
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(567, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 20)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(204, 22)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(79, 23)
        Me.dtpDateTo.TabIndex = 39
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(172, 22)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(25, 15)
        Me.Label26.TabIndex = 38
        Me.Label26.Text = "To :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(29, 22)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(41, 15)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = "From :"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(76, 22)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(81, 23)
        Me.dtpDateFrom.TabIndex = 36
        '
        'btnGetData
        '
        Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetData.Location = New System.Drawing.Point(398, 25)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ApproveInvoiceToolStripButton2, Me.CancelInvoiceToolStripButton3, Me.CloseInvoiceapprovalToolStripButton, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(416, 446)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(238, 39)
        Me.ToolStrip1.TabIndex = 172
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 36)
        Me.ToolStripLabel1.Text = "   "
        '
        'ApproveInvoiceToolStripButton2
        '
        Me.ApproveInvoiceToolStripButton2.Image = CType(resources.GetObject("ApproveInvoiceToolStripButton2.Image"), System.Drawing.Image)
        Me.ApproveInvoiceToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ApproveInvoiceToolStripButton2.Name = "ApproveInvoiceToolStripButton2"
        Me.ApproveInvoiceToolStripButton2.Size = New System.Drawing.Size(72, 36)
        Me.ApproveInvoiceToolStripButton2.Text = "Approve"
        '
        'CancelInvoiceToolStripButton3
        '
        Me.CancelInvoiceToolStripButton3.AutoSize = False
        Me.CancelInvoiceToolStripButton3.Image = CType(resources.GetObject("CancelInvoiceToolStripButton3.Image"), System.Drawing.Image)
        Me.CancelInvoiceToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelInvoiceToolStripButton3.Name = "CancelInvoiceToolStripButton3"
        Me.CancelInvoiceToolStripButton3.Size = New System.Drawing.Size(65, 40)
        Me.CancelInvoiceToolStripButton3.Text = " Cancel "
        '
        'CloseInvoiceapprovalToolStripButton
        '
        Me.CloseInvoiceapprovalToolStripButton.AutoSize = False
        Me.CloseInvoiceapprovalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseInvoiceapprovalToolStripButton.Name = "CloseInvoiceapprovalToolStripButton"
        Me.CloseInvoiceapprovalToolStripButton.Size = New System.Drawing.Size(65, 40)
        Me.CloseInvoiceapprovalToolStripButton.Text = "Close"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Invoice#"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 65
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item No"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 75
        '
        'Column7
        '
        Me.Column7.HeaderText = "Description"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 200
        '
        'PriceColumn
        '
        Me.PriceColumn.HeaderText = "Qty "
        Me.PriceColumn.Name = "PriceColumn"
        Me.PriceColumn.Width = 50
        '
        'colUoM
        '
        Me.colUoM.HeaderText = "UoM"
        Me.colUoM.Name = "colUoM"
        Me.colUoM.Width = 40
        '
        'ColRate
        '
        Me.ColRate.HeaderText = "Rate"
        Me.ColRate.Name = "ColRate"
        Me.ColRate.Width = 75
        '
        'Column10
        '
        Me.Column10.HeaderText = "Total"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 75
        '
        'frmInvoiceapproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 490)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmInvoiceapproval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents chkCancelDelivery As CheckBox
    Friend WithEvents chkApproveDelivery As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtSchemeName As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtCountyName As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtConstituencyName As TextBox
    Friend WithEvents txtVat As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtSubcontrt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotAmt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTxNo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgw As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents btnGetData As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotIncVat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtWorkstation As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSchmRefNo As TextBox
    Friend WithEvents dgw1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ApproveInvoiceToolStripButton2 As ToolStripButton
    Friend WithEvents CloseInvoiceapprovalToolStripButton As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CancelInvoiceToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents PriceColumn As DataGridViewTextBoxColumn
    Friend WithEvents colUoM As DataGridViewTextBoxColumn
    Friend WithEvents ColRate As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
