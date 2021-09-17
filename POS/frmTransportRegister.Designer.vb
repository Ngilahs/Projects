<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransporterRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransporterRegister))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Details = New System.Windows.Forms.GroupBox()
        Me.lblTransporttaskId = New System.Windows.Forms.Label()
        Me.cboDeliveryNo = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbowarehouses = New System.Windows.Forms.ComboBox()
        Me.cboTransporter = New System.Windows.Forms.ComboBox()
        Me.txttransId = New System.Windows.Forms.TextBox()
        Me.txtvehicleRegNo = New System.Windows.Forms.TextBox()
        Me.btnLoadVehicles = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSitename = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTaskDescription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKilometers = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTXNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtConstituencyname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSchemeName = New System.Windows.Forms.TextBox()
        Me.btnLoadSchemes = New System.Windows.Forms.Button()
        Me.txtwarehouseid = New System.Windows.Forms.TextBox()
        Me.txtSchemeRefNo = New System.Windows.Forms.TextBox()
        Me.lbldate = New System.Windows.Forms.DateTimePicker()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.btnAddScheme = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtVehicleId = New System.Windows.Forms.TextBox()
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.ColTaskDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDeliveryNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWarehouseId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSchemeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SaveTransportTask = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ResetTransportRegister = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.Details.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(380, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 20)
        Me.Label7.TabIndex = 232
        Me.Label7.Text = "Transport Register"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(-1, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(909, 40)
        Me.TextBox1.TabIndex = 231
        '
        'Details
        '
        Me.Details.Controls.Add(Me.lblTransporttaskId)
        Me.Details.Controls.Add(Me.cboDeliveryNo)
        Me.Details.Controls.Add(Me.Label17)
        Me.Details.Controls.Add(Me.cbowarehouses)
        Me.Details.Controls.Add(Me.cboTransporter)
        Me.Details.Controls.Add(Me.txttransId)
        Me.Details.Controls.Add(Me.txtvehicleRegNo)
        Me.Details.Controls.Add(Me.btnLoadVehicles)
        Me.Details.Controls.Add(Me.Label1)
        Me.Details.Controls.Add(Me.txtAmount)
        Me.Details.Controls.Add(Me.Label15)
        Me.Details.Controls.Add(Me.txtSitename)
        Me.Details.Controls.Add(Me.Label13)
        Me.Details.Controls.Add(Me.Label12)
        Me.Details.Controls.Add(Me.Label8)
        Me.Details.Controls.Add(Me.Label3)
        Me.Details.Controls.Add(Me.Label14)
        Me.Details.Controls.Add(Me.txtTaskDescription)
        Me.Details.Controls.Add(Me.Label6)
        Me.Details.Controls.Add(Me.txtKilometers)
        Me.Details.Controls.Add(Me.Label4)
        Me.Details.Controls.Add(Me.txtTXNo)
        Me.Details.Controls.Add(Me.Label11)
        Me.Details.Controls.Add(Me.txtConstituencyname)
        Me.Details.Controls.Add(Me.Label10)
        Me.Details.Controls.Add(Me.txtCounty)
        Me.Details.Controls.Add(Me.Label9)
        Me.Details.Controls.Add(Me.txtSchemeName)
        Me.Details.Controls.Add(Me.btnLoadSchemes)
        Me.Details.Controls.Add(Me.txtwarehouseid)
        Me.Details.Controls.Add(Me.txtSchemeRefNo)
        Me.Details.Controls.Add(Me.lbldate)
        Me.Details.Controls.Add(Me.txtSchemeID)
        Me.Details.Controls.Add(Me.txtConstituencyID)
        Me.Details.Controls.Add(Me.txtCountyID)
        Me.Details.Controls.Add(Me.btnAddScheme)
        Me.Details.Controls.Add(Me.Label5)
        Me.Details.Controls.Add(Me.Label2)
        Me.Details.Controls.Add(Me.Label19)
        Me.Details.Controls.Add(Me.txtVehicleId)
        Me.Details.Controls.Add(Me.txtOne)
        Me.Details.Controls.Add(Me.txtCount)
        Me.Details.Location = New System.Drawing.Point(-1, 46)
        Me.Details.Name = "Details"
        Me.Details.Size = New System.Drawing.Size(909, 124)
        Me.Details.TabIndex = 233
        Me.Details.TabStop = False
        Me.Details.Text = "Details"
        '
        'lblTransporttaskId
        '
        Me.lblTransporttaskId.AutoSize = True
        Me.lblTransporttaskId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransporttaskId.Location = New System.Drawing.Point(788, 21)
        Me.lblTransporttaskId.Name = "lblTransporttaskId"
        Me.lblTransporttaskId.Size = New System.Drawing.Size(95, 13)
        Me.lblTransporttaskId.TabIndex = 334
        Me.lblTransporttaskId.Text = "###########"
        '
        'cboDeliveryNo
        '
        Me.cboDeliveryNo.FormattingEnabled = True
        Me.cboDeliveryNo.Location = New System.Drawing.Point(337, 17)
        Me.cboDeliveryNo.Name = "cboDeliveryNo"
        Me.cboDeliveryNo.Size = New System.Drawing.Size(164, 21)
        Me.cboDeliveryNo.TabIndex = 333
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(270, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 332
        Me.Label17.Text = "Dvry No:"
        '
        'cbowarehouses
        '
        Me.cbowarehouses.FormattingEnabled = True
        Me.cbowarehouses.Location = New System.Drawing.Point(86, 47)
        Me.cbowarehouses.Name = "cbowarehouses"
        Me.cbowarehouses.Size = New System.Drawing.Size(178, 21)
        Me.cbowarehouses.TabIndex = 329
        '
        'cboTransporter
        '
        Me.cboTransporter.FormattingEnabled = True
        Me.cboTransporter.Location = New System.Drawing.Point(589, 16)
        Me.cboTransporter.Name = "cboTransporter"
        Me.cboTransporter.Size = New System.Drawing.Size(117, 21)
        Me.cboTransporter.TabIndex = 328
        '
        'txttransId
        '
        Me.txttransId.Enabled = False
        Me.txttransId.Location = New System.Drawing.Point(680, 16)
        Me.txttransId.Name = "txttransId"
        Me.txttransId.Size = New System.Drawing.Size(16, 20)
        Me.txttransId.TabIndex = 327
        '
        'txtvehicleRegNo
        '
        Me.txtvehicleRegNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtvehicleRegNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtvehicleRegNo.Enabled = False
        Me.txtvehicleRegNo.Location = New System.Drawing.Point(86, 98)
        Me.txtvehicleRegNo.Name = "txtvehicleRegNo"
        Me.txtvehicleRegNo.Size = New System.Drawing.Size(150, 20)
        Me.txtvehicleRegNo.TabIndex = 321
        '
        'btnLoadVehicles
        '
        Me.btnLoadVehicles.BackColor = System.Drawing.Color.DarkGray
        Me.btnLoadVehicles.BackgroundImage = CType(resources.GetObject("btnLoadVehicles.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadVehicles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadVehicles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadVehicles.Location = New System.Drawing.Point(242, 99)
        Me.btnLoadVehicles.Name = "btnLoadVehicles"
        Me.btnLoadVehicles.Size = New System.Drawing.Size(22, 17)
        Me.btnLoadVehicles.TabIndex = 320
        Me.btnLoadVehicles.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 319
        Me.Label1.Text = "Ref No:"
        '
        'txtAmount
        '
        Me.txtAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAmount.Location = New System.Drawing.Point(791, 69)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(106, 20)
        Me.txtAmount.TabIndex = 315
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(712, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 316
        Me.Label15.Text = "Amount:"
        '
        'txtSitename
        '
        Me.txtSitename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSitename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSitename.Location = New System.Drawing.Point(337, 45)
        Me.txtSitename.Name = "txtSitename"
        Me.txtSitename.Size = New System.Drawing.Size(164, 20)
        Me.txtSitename.TabIndex = 313
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(270, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 314
        Me.Label13.Text = "County:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 312
        Me.Label12.Text = "Vehicle:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 310
        Me.Label8.Text = "Scheme:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(417, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 309
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 308
        Me.Label14.Text = "Task:"
        '
        'txtTaskDescription
        '
        Me.txtTaskDescription.Location = New System.Drawing.Point(86, 14)
        Me.txtTaskDescription.Multiline = True
        Me.txtTaskDescription.Name = "txtTaskDescription"
        Me.txtTaskDescription.Size = New System.Drawing.Size(178, 25)
        Me.txtTaskDescription.TabIndex = 307
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 287
        Me.Label6.Text = " Warehouse:"
        '
        'txtKilometers
        '
        Me.txtKilometers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtKilometers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtKilometers.Location = New System.Drawing.Point(791, 42)
        Me.txtKilometers.Name = "txtKilometers"
        Me.txtKilometers.Size = New System.Drawing.Size(106, 20)
        Me.txtKilometers.TabIndex = 256
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(710, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 257
        Me.Label4.Text = "Kms Site:"
        '
        'txtTXNo
        '
        Me.txtTXNo.Enabled = False
        Me.txtTXNo.Location = New System.Drawing.Point(589, 70)
        Me.txtTXNo.Name = "txtTXNo"
        Me.txtTXNo.Size = New System.Drawing.Size(117, 20)
        Me.txtTXNo.TabIndex = 286
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(507, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 285
        Me.Label11.Text = "Tx No:"
        '
        'txtConstituencyname
        '
        Me.txtConstituencyname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyname.Enabled = False
        Me.txtConstituencyname.Location = New System.Drawing.Point(589, 44)
        Me.txtConstituencyname.Name = "txtConstituencyname"
        Me.txtConstituencyname.Size = New System.Drawing.Size(117, 20)
        Me.txtConstituencyname.TabIndex = 277
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(507, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 278
        Me.Label10.Text = "Const:"
        '
        'txtCounty
        '
        Me.txtCounty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCounty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCounty.Enabled = False
        Me.txtCounty.Location = New System.Drawing.Point(337, 72)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(164, 20)
        Me.txtCounty.TabIndex = 275
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(270, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 276
        Me.Label9.Text = "Site Name:"
        '
        'txtSchemeName
        '
        Me.txtSchemeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeName.Enabled = False
        Me.txtSchemeName.Location = New System.Drawing.Point(86, 71)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(150, 20)
        Me.txtSchemeName.TabIndex = 284
        '
        'btnLoadSchemes
        '
        Me.btnLoadSchemes.BackColor = System.Drawing.Color.DarkGray
        Me.btnLoadSchemes.BackgroundImage = CType(resources.GetObject("btnLoadSchemes.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadSchemes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadSchemes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSchemes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSchemes.Location = New System.Drawing.Point(242, 72)
        Me.btnLoadSchemes.Name = "btnLoadSchemes"
        Me.btnLoadSchemes.Size = New System.Drawing.Size(22, 17)
        Me.btnLoadSchemes.TabIndex = 283
        Me.btnLoadSchemes.UseVisualStyleBackColor = False
        '
        'txtwarehouseid
        '
        Me.txtwarehouseid.Enabled = False
        Me.txtwarehouseid.Location = New System.Drawing.Point(220, 47)
        Me.txtwarehouseid.Name = "txtwarehouseid"
        Me.txtwarehouseid.Size = New System.Drawing.Size(16, 20)
        Me.txtwarehouseid.TabIndex = 281
        '
        'txtSchemeRefNo
        '
        Me.txtSchemeRefNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeRefNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeRefNo.Enabled = False
        Me.txtSchemeRefNo.Location = New System.Drawing.Point(337, 98)
        Me.txtSchemeRefNo.Name = "txtSchemeRefNo"
        Me.txtSchemeRefNo.Size = New System.Drawing.Size(164, 20)
        Me.txtSchemeRefNo.TabIndex = 261
        '
        'lbldate
        '
        Me.lbldate.CustomFormat = "MM/dd/yyyy"
        Me.lbldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.lbldate.Location = New System.Drawing.Point(589, 96)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(117, 20)
        Me.lbldate.TabIndex = 268
        '
        'txtSchemeID
        '
        Me.txtSchemeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeID.Enabled = False
        Me.txtSchemeID.Location = New System.Drawing.Point(385, 98)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(13, 20)
        Me.txtSchemeID.TabIndex = 265
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyID.Enabled = False
        Me.txtConstituencyID.Location = New System.Drawing.Point(369, 98)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(10, 20)
        Me.txtConstituencyID.TabIndex = 267
        '
        'txtCountyID
        '
        Me.txtCountyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCountyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCountyID.Enabled = False
        Me.txtCountyID.Location = New System.Drawing.Point(350, 98)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(13, 20)
        Me.txtCountyID.TabIndex = 266
        '
        'btnAddScheme
        '
        Me.btnAddScheme.BackColor = System.Drawing.Color.Cyan
        Me.btnAddScheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddScheme.Location = New System.Drawing.Point(791, 92)
        Me.btnAddScheme.Name = "btnAddScheme"
        Me.btnAddScheme.Size = New System.Drawing.Size(108, 24)
        Me.btnAddScheme.TabIndex = 258
        Me.btnAddScheme.Text = "Add"
        Me.btnAddScheme.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(507, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 254
        Me.Label5.Text = "Transporter:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(774, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 250
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(507, 100)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 13)
        Me.Label19.TabIndex = 246
        Me.Label19.Text = "Date:"
        '
        'txtVehicleId
        '
        Me.txtVehicleId.Enabled = False
        Me.txtVehicleId.Location = New System.Drawing.Point(196, 98)
        Me.txtVehicleId.Name = "txtVehicleId"
        Me.txtVehicleId.Size = New System.Drawing.Size(16, 20)
        Me.txtVehicleId.TabIndex = 326
        '
        'txtOne
        '
        Me.txtOne.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtOne.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtOne.Location = New System.Drawing.Point(652, 70)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(22, 20)
        Me.txtOne.TabIndex = 331
        '
        'txtCount
        '
        Me.txtCount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCount.Location = New System.Drawing.Point(680, 70)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(22, 20)
        Me.txtCount.TabIndex = 330
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColTaskDescription, Me.ColDeliveryNo, Me.Column7, Me.colWarehouseId, Me.Column1, Me.colSchemeID, Me.colCount, Me.ColCost})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(2, 176)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(906, 396)
        Me.dgw.TabIndex = 234
        '
        'ColTaskDescription
        '
        Me.ColTaskDescription.HeaderText = "Task"
        Me.ColTaskDescription.Name = "ColTaskDescription"
        Me.ColTaskDescription.ReadOnly = True
        Me.ColTaskDescription.Width = 150
        '
        'ColDeliveryNo
        '
        Me.ColDeliveryNo.HeaderText = "Delivery No"
        Me.ColDeliveryNo.Name = "ColDeliveryNo"
        Me.ColDeliveryNo.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "From Warehouse"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'colWarehouseId
        '
        Me.colWarehouseId.HeaderText = "WarehouseId"
        Me.colWarehouseId.Name = "colWarehouseId"
        Me.colWarehouseId.ReadOnly = True
        Me.colWarehouseId.Width = 75
        '
        'Column1
        '
        Me.Column1.HeaderText = "To Scheme"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 180
        '
        'colSchemeID
        '
        Me.colSchemeID.HeaderText = "SchemeID"
        Me.colSchemeID.Name = "colSchemeID"
        Me.colSchemeID.ReadOnly = True
        Me.colSchemeID.Width = 75
        '
        'colCount
        '
        Me.colCount.HeaderText = "Count"
        Me.colCount.Name = "colCount"
        Me.colCount.ReadOnly = True
        Me.colCount.Width = 50
        '
        'ColCost
        '
        Me.ColCost.HeaderText = "Cost"
        Me.ColCost.Name = "ColCost"
        Me.ColCost.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightGray
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveTransportTask, Me.ToolStripLabel1, Me.btnNewItem, Me.ResetTransportRegister, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(310, 575)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(282, 35)
        Me.ToolStrip1.TabIndex = 235
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SaveTransportTask
        '
        Me.SaveTransportTask.Image = CType(resources.GetObject("SaveTransportTask.Image"), System.Drawing.Image)
        Me.SaveTransportTask.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveTransportTask.Name = "SaveTransportTask"
        Me.SaveTransportTask.Size = New System.Drawing.Size(51, 32)
        Me.SaveTransportTask.Text = "Save"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 32)
        Me.ToolStripLabel1.Text = "   "
        '
        'btnNewItem
        '
        Me.btnNewItem.AutoSize = False
        Me.btnNewItem.Image = CType(resources.GetObject("btnNewItem.Image"), System.Drawing.Image)
        Me.btnNewItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNewItem.Name = "btnNewItem"
        Me.btnNewItem.Size = New System.Drawing.Size(65, 40)
        Me.btnNewItem.Text = "&Cancel"
        '
        'ResetTransportRegister
        '
        Me.ResetTransportRegister.AutoSize = False
        Me.ResetTransportRegister.Image = CType(resources.GetObject("ResetTransportRegister.Image"), System.Drawing.Image)
        Me.ResetTransportRegister.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ResetTransportRegister.Name = "ResetTransportRegister"
        Me.ResetTransportRegister.Size = New System.Drawing.Size(65, 40)
        Me.ResetTransportRegister.Text = "&Reset"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = False
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(65, 40)
        Me.btnClose.Text = "Clos&e"
        '
        'frmTransporterRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 611)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.Details)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmTransporterRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Details.ResumeLayout(False)
        Me.Details.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Details As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKilometers As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTXNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtConstituencyname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSchemeName As TextBox
    Friend WithEvents btnLoadSchemes As Button
    Friend WithEvents txtwarehouseid As TextBox
    Friend WithEvents txtSchemeRefNo As TextBox
    Friend WithEvents lbldate As DateTimePicker
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents btnAddScheme As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents dgw As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTaskDescription As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SaveTransportTask As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btnNewItem As ToolStripButton
    Friend WithEvents ResetTransportRegister As ToolStripButton
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSitename As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtvehicleRegNo As TextBox
    Friend WithEvents btnLoadVehicles As Button
    Friend WithEvents txttransId As TextBox
    Friend WithEvents txtVehicleId As TextBox
    Friend WithEvents cboTransporter As ComboBox
    Friend WithEvents cbowarehouses As ComboBox
    Friend WithEvents txtCount As TextBox
    Friend WithEvents txtOne As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cboDeliveryNo As ComboBox
    Friend WithEvents ColTaskDescription As DataGridViewTextBoxColumn
    Friend WithEvents ColDeliveryNo As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents colWarehouseId As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colSchemeID As DataGridViewTextBoxColumn
    Friend WithEvents colCount As DataGridViewTextBoxColumn
    Friend WithEvents ColCost As DataGridViewTextBoxColumn
    Friend WithEvents lblTransporttaskId As Label
End Class
