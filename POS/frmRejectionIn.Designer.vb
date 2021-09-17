<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRejectionIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRejectionIn))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblDeliveryNo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSchemeName = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCountyName = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtConstituencyName = New System.Windows.Forms.TextBox()
        Me.txtItemCount = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTillNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIssuanceTime = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIssuancedate = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDeliveryNo2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtqtyreversed = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDateIssued = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtitemDescription = New System.Windows.Forms.TextBox()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.txtQuantityIssued = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIntialQty = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ReverseSaleToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.PostChangesToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txtEnterDeliveryNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.LblDeliveryNo)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.txtSchemeName)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txtCountyName)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.txtConstituencyName)
        Me.GroupBox5.Controls.Add(Me.txtItemCount)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.txtUserName)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.txtTillNo)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtIssuanceTime)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtIssuancedate)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtSchemeID)
        Me.GroupBox5.Controls.Add(Me.txtCountyID)
        Me.GroupBox5.Controls.Add(Me.txtConstituencyID)
        Me.GroupBox5.Location = New System.Drawing.Point(118, 48)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(773, 82)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = " Delivery Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(530, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 210
        Me.Label6.Text = "Item Count:"
        '
        'LblDeliveryNo
        '
        Me.LblDeliveryNo.Enabled = False
        Me.LblDeliveryNo.Location = New System.Drawing.Point(78, 20)
        Me.LblDeliveryNo.Margin = New System.Windows.Forms.Padding(2)
        Me.LblDeliveryNo.Name = "LblDeliveryNo"
        Me.LblDeliveryNo.Size = New System.Drawing.Size(90, 20)
        Me.LblDeliveryNo.TabIndex = 206
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(174, 23)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(52, 13)
        Me.Label24.TabIndex = 201
        Me.Label24.Text = "Scheme: "
        '
        'txtSchemeName
        '
        Me.txtSchemeName.Enabled = False
        Me.txtSchemeName.Location = New System.Drawing.Point(227, 20)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(96, 20)
        Me.txtSchemeName.TabIndex = 200
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(174, 55)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(46, 13)
        Me.Label23.TabIndex = 199
        Me.Label23.Text = "County: "
        '
        'txtCountyName
        '
        Me.txtCountyName.Enabled = False
        Me.txtCountyName.Location = New System.Drawing.Point(227, 49)
        Me.txtCountyName.Name = "txtCountyName"
        Me.txtCountyName.Size = New System.Drawing.Size(96, 20)
        Me.txtCountyName.TabIndex = 198
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(329, 23)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 13)
        Me.Label22.TabIndex = 197
        Me.Label22.Text = "Constituency:"
        '
        'txtConstituencyName
        '
        Me.txtConstituencyName.Enabled = False
        Me.txtConstituencyName.Location = New System.Drawing.Point(406, 20)
        Me.txtConstituencyName.Name = "txtConstituencyName"
        Me.txtConstituencyName.Size = New System.Drawing.Size(118, 20)
        Me.txtConstituencyName.TabIndex = 196
        '
        'txtItemCount
        '
        Me.txtItemCount.Enabled = False
        Me.txtItemCount.Location = New System.Drawing.Point(597, 48)
        Me.txtItemCount.Name = "txtItemCount"
        Me.txtItemCount.Size = New System.Drawing.Size(90, 20)
        Me.txtItemCount.TabIndex = 194
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(530, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 193
        Me.Label20.Text = "Created By:"
        '
        'txtUserName
        '
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(598, 20)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(90, 20)
        Me.txtUserName.TabIndex = 192
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 191
        Me.Label19.Text = "W.Station:"
        '
        'txtTillNo
        '
        Me.txtTillNo.Enabled = False
        Me.txtTillNo.Location = New System.Drawing.Point(78, 48)
        Me.txtTillNo.Name = "txtTillNo"
        Me.txtTillNo.Size = New System.Drawing.Size(90, 20)
        Me.txtTillNo.TabIndex = 190
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(329, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 187
        Me.Label9.Text = "Issuance Time: "
        '
        'txtIssuanceTime
        '
        Me.txtIssuanceTime.Enabled = False
        Me.txtIssuanceTime.Location = New System.Drawing.Point(406, 48)
        Me.txtIssuanceTime.Name = "txtIssuanceTime"
        Me.txtIssuanceTime.Size = New System.Drawing.Size(118, 20)
        Me.txtIssuanceTime.TabIndex = 186
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(705, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Date "
        '
        'txtIssuancedate
        '
        Me.txtIssuancedate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIssuancedate.Enabled = False
        Me.txtIssuancedate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssuancedate.Location = New System.Drawing.Point(693, 46)
        Me.txtIssuancedate.MaxLength = 50
        Me.txtIssuancedate.Name = "txtIssuancedate"
        Me.txtIssuancedate.Size = New System.Drawing.Size(67, 22)
        Me.txtIssuancedate.TabIndex = 170
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(5, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Delivery No :"
        '
        'txtSchemeID
        '
        Me.txtSchemeID.Location = New System.Drawing.Point(311, 20)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(12, 20)
        Me.txtSchemeID.TabIndex = 209
        Me.txtSchemeID.Visible = False
        '
        'txtCountyID
        '
        Me.txtCountyID.Location = New System.Drawing.Point(311, 49)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(12, 20)
        Me.txtCountyID.TabIndex = 207
        Me.txtCountyID.Visible = False
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.Location = New System.Drawing.Point(512, 20)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(12, 20)
        Me.txtConstituencyID.TabIndex = 208
        Me.txtConstituencyID.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDeliveryNo2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtqtyreversed)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtDateIssued)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtitemDescription)
        Me.GroupBox1.Controls.Add(Me.txtItemNo)
        Me.GroupBox1.Controls.Add(Me.txtQuantityIssued)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIntialQty)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(118, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 70)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'txtDeliveryNo2
        '
        Me.txtDeliveryNo2.Enabled = False
        Me.txtDeliveryNo2.Location = New System.Drawing.Point(432, 11)
        Me.txtDeliveryNo2.Name = "txtDeliveryNo2"
        Me.txtDeliveryNo2.Size = New System.Drawing.Size(100, 23)
        Me.txtDeliveryNo2.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(364, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Delivery No:"
        '
        'txtqtyreversed
        '
        Me.txtqtyreversed.Location = New System.Drawing.Point(622, 37)
        Me.txtqtyreversed.Name = "txtqtyreversed"
        Me.txtqtyreversed.Size = New System.Drawing.Size(146, 23)
        Me.txtqtyreversed.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DarkOrange
        Me.Label11.Location = New System.Drawing.Point(549, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Return Qty:"
        '
        'txtDateIssued
        '
        Me.txtDateIssued.Enabled = False
        Me.txtDateIssued.Location = New System.Drawing.Point(256, 11)
        Me.txtDateIssued.Name = "txtDateIssued"
        Me.txtDateIssued.Size = New System.Drawing.Size(102, 23)
        Me.txtDateIssued.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Date:"
        '
        'txtitemDescription
        '
        Me.txtitemDescription.Enabled = False
        Me.txtitemDescription.Location = New System.Drawing.Point(88, 37)
        Me.txtitemDescription.Name = "txtitemDescription"
        Me.txtitemDescription.Size = New System.Drawing.Size(444, 23)
        Me.txtitemDescription.TabIndex = 15
        '
        'txtItemNo
        '
        Me.txtItemNo.Enabled = False
        Me.txtItemNo.Location = New System.Drawing.Point(88, 11)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(122, 23)
        Me.txtItemNo.TabIndex = 14
        '
        'txtQuantityIssued
        '
        Me.txtQuantityIssued.Enabled = False
        Me.txtQuantityIssued.Location = New System.Drawing.Point(622, 11)
        Me.txtQuantityIssued.Name = "txtQuantityIssued"
        Me.txtQuantityIssued.Size = New System.Drawing.Size(146, 23)
        Me.txtQuantityIssued.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(551, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Qty Issued:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 40)
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
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item No :"
        '
        'txtIntialQty
        '
        Me.txtIntialQty.Location = New System.Drawing.Point(722, 37)
        Me.txtIntialQty.Name = "txtIntialQty"
        Me.txtIntialQty.Size = New System.Drawing.Size(35, 23)
        Me.txtIntialQty.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Location = New System.Drawing.Point(4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 36)
        Me.Panel1.TabIndex = 11
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.DarkOrange
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(337, 5)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(263, 17)
        Me.Label29.TabIndex = 223
        Me.Label29.Text = "Return Issued Materials to Warehouse"
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
        Me.GroupBox4.Location = New System.Drawing.Point(10, 212)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(881, 312)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " Select Item "
        '
        'dgw
        '
        Me.dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column7, Me.PriceColumn, Me.Column9, Me.Column10})
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(6, 45)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(869, 254)
        Me.dgw.TabIndex = 43
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.Red
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(816, 19)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(52, 20)
        Me.BtnReset.TabIndex = 40
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(226, 16)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(79, 23)
        Me.dtpDateTo.TabIndex = 39
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(183, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(25, 15)
        Me.Label26.TabIndex = 38
        Me.Label26.Text = "To :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(38, 17)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(41, 15)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = "From :"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(90, 16)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(81, 23)
        Me.dtpDateFrom.TabIndex = 36
        '
        'btnGetData
        '
        Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetData.Location = New System.Drawing.Point(327, 17)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ReverseSaleToolStripButton2, Me.PostChangesToolStripButton5, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(372, 527)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(270, 40)
        Me.ToolStrip1.TabIndex = 31
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 37)
        Me.ToolStripLabel1.Text = "   "
        '
        'ReverseSaleToolStripButton2
        '
        Me.ReverseSaleToolStripButton2.Image = CType(resources.GetObject("ReverseSaleToolStripButton2.Image"), System.Drawing.Image)
        Me.ReverseSaleToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReverseSaleToolStripButton2.Name = "ReverseSaleToolStripButton2"
        Me.ReverseSaleToolStripButton2.Size = New System.Drawing.Size(62, 37)
        Me.ReverseSaleToolStripButton2.Text = "Return"
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
        'txtEnterDeliveryNo
        '
        Me.txtEnterDeliveryNo.Location = New System.Drawing.Point(2, 46)
        Me.txtEnterDeliveryNo.Name = "txtEnterDeliveryNo"
        Me.txtEnterDeliveryNo.Size = New System.Drawing.Size(94, 20)
        Me.txtEnterDeliveryNo.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Aqua
        Me.Label3.Location = New System.Drawing.Point(11, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = " Delivery No "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtEnterDeliveryNo)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(102, 161)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Delivery"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Delivery No"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item No"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Description"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'PriceColumn
        '
        Me.PriceColumn.HeaderText = "Qty Issued"
        Me.PriceColumn.Name = "PriceColumn"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Date Issued"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Time Issued"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 120
        '
        'frmRejectionIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(893, 570)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmRejectionIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtIssuancedate As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtitemDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantityIssued As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtSchemeName As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCountyName As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtConstituencyName As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCount As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTillNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIssuanceTime As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents txtEnterDeliveryNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PostChangesToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents LblDeliveryNo As System.Windows.Forms.TextBox
    Friend WithEvents txtDateIssued As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtqtyreversed As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ReverseSaleToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label29 As Label
    Friend WithEvents txtDeliveryNo2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIntialQty As TextBox
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents PriceColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
