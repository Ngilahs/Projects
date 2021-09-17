<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIssueMeters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIssueMeters))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSubcontractor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboVehicleNo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboBatchNo = New System.Windows.Forms.ComboBox()
        Me.txtWarehouseName = New System.Windows.Forms.TextBox()
        Me.txtwarehouseID = New System.Windows.Forms.TextBox()
        Me.btnLoadWarehouses = New System.Windows.Forms.Button()
        Me.btnLoadSchemes = New System.Windows.Forms.Button()
        Me.txtSchemeName = New System.Windows.Forms.TextBox()
        Me.lblScheme = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQtyIssued = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTXNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtConstituencyname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSchemeRefNo = New System.Windows.Forms.TextBox()
        Me.lbldate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.txtSubcontractorID = New System.Windows.Forms.TextBox()
        Me.txtVehicleID = New System.Windows.Forms.TextBox()
        Me.dgwz = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CSaveIssueMetersToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.CVoidToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.colMeterRcptNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustIDNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPhoneNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMeterrcvdetailsNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgwz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(3, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(768, 40)
        Me.TextBox1.TabIndex = 169
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(330, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 20)
        Me.Label7.TabIndex = 223
        Me.Label7.Text = "Issue Meters"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboSubcontractor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboVehicleNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboBatchNo)
        Me.GroupBox1.Controls.Add(Me.txtWarehouseName)
        Me.GroupBox1.Controls.Add(Me.txtwarehouseID)
        Me.GroupBox1.Controls.Add(Me.btnLoadWarehouses)
        Me.GroupBox1.Controls.Add(Me.btnLoadSchemes)
        Me.GroupBox1.Controls.Add(Me.txtSchemeName)
        Me.GroupBox1.Controls.Add(Me.lblScheme)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtQtyIssued)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTXNo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtConstituencyname)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCounty)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSchemeRefNo)
        Me.GroupBox1.Controls.Add(Me.lbldate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtConstituencyID)
        Me.GroupBox1.Controls.Add(Me.txtSchemeID)
        Me.GroupBox1.Controls.Add(Me.txtCountyID)
        Me.GroupBox1.Controls.Add(Me.txtSubcontractorID)
        Me.GroupBox1.Controls.Add(Me.txtVehicleID)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 96)
        Me.GroupBox1.TabIndex = 224
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scheme Details"
        '
        'cboStatus
        '
        Me.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStatus.Enabled = False
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Issued", "Not Issued", "Returned"})
        Me.cboStatus.Location = New System.Drawing.Point(655, 64)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(97, 21)
        Me.cboStatus.TabIndex = 323
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(593, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 14)
        Me.Label8.TabIndex = 322
        Me.Label8.Text = "Status:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(377, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 14)
        Me.Label6.TabIndex = 321
        Me.Label6.Text = "Sub-Contrctr:"
        '
        'cboSubcontractor
        '
        Me.cboSubcontractor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSubcontractor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubcontractor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubcontractor.FormattingEnabled = True
        Me.cboSubcontractor.Location = New System.Drawing.Point(454, 65)
        Me.cboSubcontractor.Name = "cboSubcontractor"
        Me.cboSubcontractor.Size = New System.Drawing.Size(133, 21)
        Me.cboSubcontractor.TabIndex = 319
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(191, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 14)
        Me.Label3.TabIndex = 317
        Me.Label3.Text = "Vehicle:"
        '
        'cboVehicleNo
        '
        Me.cboVehicleNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboVehicleNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVehicleNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehicleNo.FormattingEnabled = True
        Me.cboVehicleNo.Location = New System.Drawing.Point(241, 68)
        Me.cboVehicleNo.Name = "cboVehicleNo"
        Me.cboVehicleNo.Size = New System.Drawing.Size(130, 21)
        Me.cboVehicleNo.TabIndex = 316
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 315
        Me.Label2.Text = "Batch No:"
        '
        'cboBatchNo
        '
        Me.cboBatchNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboBatchNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBatchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBatchNo.FormattingEnabled = True
        Me.cboBatchNo.Location = New System.Drawing.Point(63, 65)
        Me.cboBatchNo.Name = "cboBatchNo"
        Me.cboBatchNo.Size = New System.Drawing.Size(122, 21)
        Me.cboBatchNo.TabIndex = 314
        '
        'txtWarehouseName
        '
        Me.txtWarehouseName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtWarehouseName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtWarehouseName.Enabled = False
        Me.txtWarehouseName.Location = New System.Drawing.Point(454, 39)
        Me.txtWarehouseName.Name = "txtWarehouseName"
        Me.txtWarehouseName.Size = New System.Drawing.Size(105, 20)
        Me.txtWarehouseName.TabIndex = 306
        '
        'txtwarehouseID
        '
        Me.txtwarehouseID.Location = New System.Drawing.Point(536, 39)
        Me.txtwarehouseID.Name = "txtwarehouseID"
        Me.txtwarehouseID.Size = New System.Drawing.Size(23, 20)
        Me.txtwarehouseID.TabIndex = 313
        '
        'btnLoadWarehouses
        '
        Me.btnLoadWarehouses.BackColor = System.Drawing.Color.DarkGray
        Me.btnLoadWarehouses.BackgroundImage = CType(resources.GetObject("btnLoadWarehouses.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadWarehouses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadWarehouses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadWarehouses.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadWarehouses.Location = New System.Drawing.Point(565, 40)
        Me.btnLoadWarehouses.Name = "btnLoadWarehouses"
        Me.btnLoadWarehouses.Size = New System.Drawing.Size(22, 17)
        Me.btnLoadWarehouses.TabIndex = 312
        Me.btnLoadWarehouses.UseVisualStyleBackColor = False
        '
        'btnLoadSchemes
        '
        Me.btnLoadSchemes.BackColor = System.Drawing.Color.DarkGray
        Me.btnLoadSchemes.BackgroundImage = CType(resources.GetObject("btnLoadSchemes.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadSchemes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadSchemes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSchemes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSchemes.Location = New System.Drawing.Point(349, 15)
        Me.btnLoadSchemes.Name = "btnLoadSchemes"
        Me.btnLoadSchemes.Size = New System.Drawing.Size(22, 17)
        Me.btnLoadSchemes.TabIndex = 296
        Me.btnLoadSchemes.UseVisualStyleBackColor = False
        '
        'txtSchemeName
        '
        Me.txtSchemeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeName.Enabled = False
        Me.txtSchemeName.Location = New System.Drawing.Point(241, 14)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(102, 20)
        Me.txtSchemeName.TabIndex = 297
        '
        'lblScheme
        '
        Me.lblScheme.AutoSize = True
        Me.lblScheme.BackColor = System.Drawing.Color.White
        Me.lblScheme.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheme.ForeColor = System.Drawing.Color.Black
        Me.lblScheme.Location = New System.Drawing.Point(193, 16)
        Me.lblScheme.Name = "lblScheme"
        Me.lblScheme.Size = New System.Drawing.Size(42, 14)
        Me.lblScheme.TabIndex = 288
        Me.lblScheme.Text = "Scheme"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(377, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 14)
        Me.Label5.TabIndex = 307
        Me.Label5.Text = " Warehouse:"
        '
        'txtQtyIssued
        '
        Me.txtQtyIssued.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtQtyIssued.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtQtyIssued.Enabled = False
        Me.txtQtyIssued.Location = New System.Drawing.Point(655, 37)
        Me.txtQtyIssued.Name = "txtQtyIssued"
        Me.txtQtyIssued.Size = New System.Drawing.Size(97, 20)
        Me.txtQtyIssued.TabIndex = 304
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(593, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 14)
        Me.Label4.TabIndex = 305
        Me.Label4.Text = "Qty Issued"
        '
        'txtTXNo
        '
        Me.txtTXNo.Enabled = False
        Me.txtTXNo.Location = New System.Drawing.Point(63, 39)
        Me.txtTXNo.Name = "txtTXNo"
        Me.txtTXNo.Size = New System.Drawing.Size(122, 20)
        Me.txtTXNo.TabIndex = 299
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 14)
        Me.Label11.TabIndex = 298
        Me.Label11.Text = "TX No:"
        '
        'txtConstituencyname
        '
        Me.txtConstituencyname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyname.Enabled = False
        Me.txtConstituencyname.Location = New System.Drawing.Point(454, 12)
        Me.txtConstituencyname.Name = "txtConstituencyname"
        Me.txtConstituencyname.Size = New System.Drawing.Size(133, 20)
        Me.txtConstituencyname.TabIndex = 294
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(377, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 14)
        Me.Label10.TabIndex = 295
        Me.Label10.Text = "Constituency:"
        '
        'txtCounty
        '
        Me.txtCounty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCounty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCounty.Enabled = False
        Me.txtCounty.Location = New System.Drawing.Point(241, 40)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(130, 20)
        Me.txtCounty.TabIndex = 292
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(191, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 14)
        Me.Label9.TabIndex = 293
        Me.Label9.Text = "County:"
        '
        'txtSchemeRefNo
        '
        Me.txtSchemeRefNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeRefNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeRefNo.Location = New System.Drawing.Point(63, 14)
        Me.txtSchemeRefNo.Name = "txtSchemeRefNo"
        Me.txtSchemeRefNo.Size = New System.Drawing.Size(124, 20)
        Me.txtSchemeRefNo.TabIndex = 289
        '
        'lbldate
        '
        Me.lbldate.CustomFormat = "MM/dd/yyyy"
        Me.lbldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.lbldate.Location = New System.Drawing.Point(655, 12)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(97, 20)
        Me.lbldate.TabIndex = 291
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 290
        Me.Label1.Text = "Schm Ref"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(593, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 14)
        Me.Label19.TabIndex = 287
        Me.Label19.Text = "Date:"
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyID.Enabled = False
        Me.txtConstituencyID.Location = New System.Drawing.Point(156, 14)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(19, 20)
        Me.txtConstituencyID.TabIndex = 311
        '
        'txtSchemeID
        '
        Me.txtSchemeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeID.Enabled = False
        Me.txtSchemeID.Location = New System.Drawing.Point(127, 14)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(23, 20)
        Me.txtSchemeID.TabIndex = 309
        '
        'txtCountyID
        '
        Me.txtCountyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCountyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCountyID.Enabled = False
        Me.txtCountyID.Location = New System.Drawing.Point(97, 14)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(24, 20)
        Me.txtCountyID.TabIndex = 310
        '
        'txtSubcontractorID
        '
        Me.txtSubcontractorID.Location = New System.Drawing.Point(571, 65)
        Me.txtSubcontractorID.Name = "txtSubcontractorID"
        Me.txtSubcontractorID.Size = New System.Drawing.Size(16, 20)
        Me.txtSubcontractorID.TabIndex = 320
        '
        'txtVehicleID
        '
        Me.txtVehicleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtVehicleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtVehicleID.Enabled = False
        Me.txtVehicleID.Location = New System.Drawing.Point(349, 69)
        Me.txtVehicleID.Name = "txtVehicleID"
        Me.txtVehicleID.Size = New System.Drawing.Size(22, 20)
        Me.txtVehicleID.TabIndex = 318
        '
        'dgwz
        '
        Me.dgwz.AllowUserToAddRows = False
        Me.dgwz.AllowUserToDeleteRows = False
        Me.dgwz.AllowUserToOrderColumns = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FloralWhite
        Me.dgwz.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgwz.BackgroundColor = System.Drawing.Color.White
        Me.dgwz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwz.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgwz.ColumnHeadersHeight = 24
        Me.dgwz.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMeterRcptNo, Me.colCustomerName, Me.colCustIDNo, Me.ColPhoneNo, Me.colmterno, Me.colMeterrcvdetailsNo})
        Me.dgwz.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwz.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgwz.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgwz.EnableHeadersVisualStyles = False
        Me.dgwz.GridColor = System.Drawing.Color.DarkOrange
        Me.dgwz.Location = New System.Drawing.Point(3, 148)
        Me.dgwz.MultiSelect = False
        Me.dgwz.Name = "dgwz"
        Me.dgwz.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwz.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgwz.RowHeadersWidth = 25
        Me.dgwz.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.dgwz.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgwz.RowTemplate.Height = 18
        Me.dgwz.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgwz.Size = New System.Drawing.Size(768, 264)
        Me.dgwz.TabIndex = 229
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CSaveIssueMetersToolStripButton5, Me.CVoidToolStripButton3, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(272, 415)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(218, 35)
        Me.ToolStrip1.TabIndex = 230
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CSaveIssueMetersToolStripButton5
        '
        Me.CSaveIssueMetersToolStripButton5.Image = CType(resources.GetObject("CSaveIssueMetersToolStripButton5.Image"), System.Drawing.Image)
        Me.CSaveIssueMetersToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CSaveIssueMetersToolStripButton5.Name = "CSaveIssueMetersToolStripButton5"
        Me.CSaveIssueMetersToolStripButton5.Size = New System.Drawing.Size(51, 32)
        Me.CSaveIssueMetersToolStripButton5.Text = "Save"
        '
        'CVoidToolStripButton3
        '
        Me.CVoidToolStripButton3.AutoSize = False
        Me.CVoidToolStripButton3.Image = CType(resources.GetObject("CVoidToolStripButton3.Image"), System.Drawing.Image)
        Me.CVoidToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CVoidToolStripButton3.Name = "CVoidToolStripButton3"
        Me.CVoidToolStripButton3.Size = New System.Drawing.Size(65, 40)
        Me.CVoidToolStripButton3.Text = "&Void Row"
        Me.CVoidToolStripButton3.ToolTipText = "Void Row"
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
        'colMeterRcptNo
        '
        Me.colMeterRcptNo.HeaderText = "Meter Receipt No"
        Me.colMeterRcptNo.Name = "colMeterRcptNo"
        '
        'colCustomerName
        '
        Me.colCustomerName.HeaderText = "Customer Name"
        Me.colCustomerName.Name = "colCustomerName"
        Me.colCustomerName.Width = 200
        '
        'colCustIDNo
        '
        Me.colCustIDNo.HeaderText = "ID No"
        Me.colCustIDNo.Name = "colCustIDNo"
        Me.colCustIDNo.Width = 120
        '
        'ColPhoneNo
        '
        Me.ColPhoneNo.HeaderText = "Phone No"
        Me.ColPhoneNo.Name = "ColPhoneNo"
        '
        'colmterno
        '
        Me.colmterno.HeaderText = "Meter No"
        Me.colmterno.Name = "colmterno"
        Me.colmterno.ReadOnly = True
        Me.colmterno.Width = 125
        '
        'colMeterrcvdetailsNo
        '
        Me.colMeterrcvdetailsNo.HeaderText = "Meter DetailsNo"
        Me.colMeterrcvdetailsNo.Name = "colMeterrcvdetailsNo"
        '
        'frmIssueMeters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 452)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgwz)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmIssueMeters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgwz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtWarehouseName As TextBox
    Friend WithEvents txtwarehouseID As TextBox
    Friend WithEvents btnLoadWarehouses As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQtyIssued As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTXNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtConstituencyname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSchemeName As TextBox
    Friend WithEvents btnLoadSchemes As Button
    Friend WithEvents txtSchemeRefNo As TextBox
    Friend WithEvents lbldate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScheme As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents dgwz As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents CSaveIssueMetersToolStripButton5 As ToolStripButton
    Friend WithEvents CVoidToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents cboBatchNo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboVehicleNo As ComboBox
    Friend WithEvents txtVehicleID As TextBox
    Friend WithEvents cboSubcontractor As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSubcontractorID As TextBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents colMeterRcptNo As DataGridViewTextBoxColumn
    Friend WithEvents colCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents colCustIDNo As DataGridViewTextBoxColumn
    Friend WithEvents ColPhoneNo As DataGridViewTextBoxColumn
    Friend WithEvents colmterno As DataGridViewTextBoxColumn
    Friend WithEvents colMeterrcvdetailsNo As DataGridViewTextBoxColumn
End Class
