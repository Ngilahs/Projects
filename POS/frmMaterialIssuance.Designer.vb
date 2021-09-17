<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaterialIssuance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterialIssuance))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Details = New System.Windows.Forms.GroupBox()
        Me.txtTXNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSchemeName = New System.Windows.Forms.TextBox()
        Me.btnLoadSchemes = New System.Windows.Forms.Button()
        Me.chkIssuetoSubContractor = New System.Windows.Forms.CheckBox()
        Me.cboSubcontractor = New System.Windows.Forms.ComboBox()
        Me.txtSubcontractor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtConstituencyname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.txtSchemeRefNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboVehicleNo = New System.Windows.Forms.ComboBox()
        Me.txtVehicleID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.DateTimePicker()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.txtUnitofIssue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddtoGrid = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtytoIssue = New System.Windows.Forms.TextBox()
        Me.cmdSearchItems = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblDeliveryNo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtItemcount = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblScheme = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtQtyonHand = New System.Windows.Forms.TextBox()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.txtRemQty = New System.Windows.Forms.TextBox()
        Me.dgwIssueItems = New System.Windows.Forms.DataGridView()
        Me.dgwIssueMaterialsItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsQtyBal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsUnitofIssue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PSaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ClearToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtApprovedby = New System.Windows.Forms.TextBox()
        Me.chkApproved = New System.Windows.Forms.CheckBox()
        Me.txtCacelledby = New System.Windows.Forms.TextBox()
        Me.ChkCancelled = New System.Windows.Forms.CheckBox()
        Me.txtNil = New System.Windows.Forms.TextBox()
        Me.txtCurrentItemNo = New System.Windows.Forms.TextBox()
        Me.Details.SuspendLayout()
        CType(Me.dgwIssueItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(1, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1119, 38)
        Me.TextBox1.TabIndex = 139
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(514, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 222
        Me.Label2.Text = "Issue Materials"
        '
        'Details
        '
        Me.Details.Controls.Add(Me.txtTXNo)
        Me.Details.Controls.Add(Me.Label11)
        Me.Details.Controls.Add(Me.txtSchemeName)
        Me.Details.Controls.Add(Me.btnLoadSchemes)
        Me.Details.Controls.Add(Me.chkIssuetoSubContractor)
        Me.Details.Controls.Add(Me.cboSubcontractor)
        Me.Details.Controls.Add(Me.txtSubcontractor)
        Me.Details.Controls.Add(Me.Label10)
        Me.Details.Controls.Add(Me.txtConstituencyname)
        Me.Details.Controls.Add(Me.Label9)
        Me.Details.Controls.Add(Me.txtCounty)
        Me.Details.Controls.Add(Me.txtSchemeRefNo)
        Me.Details.Controls.Add(Me.Label8)
        Me.Details.Controls.Add(Me.cboVehicleNo)
        Me.Details.Controls.Add(Me.txtVehicleID)
        Me.Details.Controls.Add(Me.Label14)
        Me.Details.Controls.Add(Me.lbldate)
        Me.Details.Controls.Add(Me.txtSchemeID)
        Me.Details.Controls.Add(Me.txtConstituencyID)
        Me.Details.Controls.Add(Me.txtCountyID)
        Me.Details.Controls.Add(Me.txtUnitofIssue)
        Me.Details.Controls.Add(Me.Label1)
        Me.Details.Controls.Add(Me.Label6)
        Me.Details.Controls.Add(Me.btnAddtoGrid)
        Me.Details.Controls.Add(Me.Label4)
        Me.Details.Controls.Add(Me.txtQtytoIssue)
        Me.Details.Controls.Add(Me.cmdSearchItems)
        Me.Details.Controls.Add(Me.Label5)
        Me.Details.Controls.Add(Me.Label3)
        Me.Details.Controls.Add(Me.LblDeliveryNo)
        Me.Details.Controls.Add(Me.Label7)
        Me.Details.Controls.Add(Me.txtItemcount)
        Me.Details.Controls.Add(Me.Label18)
        Me.Details.Controls.Add(Me.lblScheme)
        Me.Details.Controls.Add(Me.Label19)
        Me.Details.Controls.Add(Me.txtQtyonHand)
        Me.Details.Controls.Add(Me.txtItemCode)
        Me.Details.Controls.Add(Me.txtRemQty)
        Me.Details.Location = New System.Drawing.Point(2, 44)
        Me.Details.Name = "Details"
        Me.Details.Size = New System.Drawing.Size(1118, 100)
        Me.Details.TabIndex = 223
        Me.Details.TabStop = False
        Me.Details.Text = "Details"
        '
        'txtTXNo
        '
        Me.txtTXNo.Enabled = False
        Me.txtTXNo.Location = New System.Drawing.Point(734, 46)
        Me.txtTXNo.Name = "txtTXNo"
        Me.txtTXNo.Size = New System.Drawing.Size(104, 20)
        Me.txtTXNo.TabIndex = 286
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(681, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 285
        Me.Label11.Text = "TX No:"
        '
        'txtSchemeName
        '
        Me.txtSchemeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeName.Enabled = False
        Me.txtSchemeName.Location = New System.Drawing.Point(349, 46)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(119, 20)
        Me.txtSchemeName.TabIndex = 284
        '
        'btnLoadSchemes
        '
        Me.btnLoadSchemes.BackColor = System.Drawing.Color.DarkGray
        Me.btnLoadSchemes.BackgroundImage = CType(resources.GetObject("btnLoadSchemes.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadSchemes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadSchemes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSchemes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSchemes.Location = New System.Drawing.Point(474, 49)
        Me.btnLoadSchemes.Name = "btnLoadSchemes"
        Me.btnLoadSchemes.Size = New System.Drawing.Size(22, 17)
        Me.btnLoadSchemes.TabIndex = 283
        Me.btnLoadSchemes.UseVisualStyleBackColor = False
        '
        'chkIssuetoSubContractor
        '
        Me.chkIssuetoSubContractor.AutoSize = True
        Me.chkIssuetoSubContractor.BackColor = System.Drawing.Color.DarkTurquoise
        Me.chkIssuetoSubContractor.Location = New System.Drawing.Point(844, 20)
        Me.chkIssuetoSubContractor.Name = "chkIssuetoSubContractor"
        Me.chkIssuetoSubContractor.Size = New System.Drawing.Size(125, 17)
        Me.chkIssuetoSubContractor.TabIndex = 282
        Me.chkIssuetoSubContractor.Text = "Issue Sub-Contractor"
        Me.chkIssuetoSubContractor.UseVisualStyleBackColor = False
        '
        'cboSubcontractor
        '
        Me.cboSubcontractor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSubcontractor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubcontractor.Enabled = False
        Me.cboSubcontractor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubcontractor.FormattingEnabled = True
        Me.cboSubcontractor.Location = New System.Drawing.Point(844, 38)
        Me.cboSubcontractor.Name = "cboSubcontractor"
        Me.cboSubcontractor.Size = New System.Drawing.Size(125, 21)
        Me.cboSubcontractor.TabIndex = 279
        '
        'txtSubcontractor
        '
        Me.txtSubcontractor.Location = New System.Drawing.Point(914, 38)
        Me.txtSubcontractor.Name = "txtSubcontractor"
        Me.txtSubcontractor.Size = New System.Drawing.Size(16, 20)
        Me.txtSubcontractor.TabIndex = 281
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 278
        Me.Label10.Text = "Constituency:"
        '
        'txtConstituencyname
        '
        Me.txtConstituencyname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyname.Enabled = False
        Me.txtConstituencyname.Location = New System.Drawing.Point(96, 71)
        Me.txtConstituencyname.Name = "txtConstituencyname"
        Me.txtConstituencyname.Size = New System.Drawing.Size(186, 20)
        Me.txtConstituencyname.TabIndex = 277
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(288, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 276
        Me.Label9.Text = "County:"
        '
        'txtCounty
        '
        Me.txtCounty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCounty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCounty.Enabled = False
        Me.txtCounty.Location = New System.Drawing.Point(349, 71)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(144, 20)
        Me.txtCounty.TabIndex = 275
        '
        'txtSchemeRefNo
        '
        Me.txtSchemeRefNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeRefNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeRefNo.Enabled = False
        Me.txtSchemeRefNo.Location = New System.Drawing.Point(545, 44)
        Me.txtSchemeRefNo.Name = "txtSchemeRefNo"
        Me.txtSchemeRefNo.Size = New System.Drawing.Size(123, 20)
        Me.txtSchemeRefNo.TabIndex = 261
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(684, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 273
        Me.Label8.Text = "UoM:"
        '
        'cboVehicleNo
        '
        Me.cboVehicleNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboVehicleNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVehicleNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehicleNo.FormattingEnabled = True
        Me.cboVehicleNo.Location = New System.Drawing.Point(545, 70)
        Me.cboVehicleNo.Name = "cboVehicleNo"
        Me.cboVehicleNo.Size = New System.Drawing.Size(123, 21)
        Me.cboVehicleNo.TabIndex = 271
        '
        'txtVehicleID
        '
        Me.txtVehicleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtVehicleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtVehicleID.Enabled = False
        Me.txtVehicleID.Location = New System.Drawing.Point(646, 71)
        Me.txtVehicleID.Name = "txtVehicleID"
        Me.txtVehicleID.Size = New System.Drawing.Size(22, 20)
        Me.txtVehicleID.TabIndex = 272
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(499, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 270
        Me.Label14.Text = "Vehicle:"
        '
        'lbldate
        '
        Me.lbldate.CustomFormat = "MM/dd/yyyy"
        Me.lbldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.lbldate.Location = New System.Drawing.Point(545, 19)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(123, 20)
        Me.lbldate.TabIndex = 268
        '
        'txtSchemeID
        '
        Me.txtSchemeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeID.Enabled = False
        Me.txtSchemeID.Location = New System.Drawing.Point(646, 44)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(13, 20)
        Me.txtSchemeID.TabIndex = 265
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyID.Enabled = False
        Me.txtConstituencyID.Location = New System.Drawing.Point(633, 44)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(10, 20)
        Me.txtConstituencyID.TabIndex = 267
        '
        'txtCountyID
        '
        Me.txtCountyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCountyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCountyID.Enabled = False
        Me.txtCountyID.Location = New System.Drawing.Point(614, 44)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(13, 20)
        Me.txtCountyID.TabIndex = 266
        '
        'txtUnitofIssue
        '
        Me.txtUnitofIssue.Enabled = False
        Me.txtUnitofIssue.Location = New System.Drawing.Point(734, 71)
        Me.txtUnitofIssue.Name = "txtUnitofIssue"
        Me.txtUnitofIssue.Size = New System.Drawing.Size(104, 20)
        Me.txtUnitofIssue.TabIndex = 264
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(503, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 263
        Me.Label1.Text = "Ref No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(681, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 260
        Me.Label6.Text = "Stock:"
        '
        'btnAddtoGrid
        '
        Me.btnAddtoGrid.BackColor = System.Drawing.Color.Cyan
        Me.btnAddtoGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoGrid.Location = New System.Drawing.Point(1002, 38)
        Me.btnAddtoGrid.Name = "btnAddtoGrid"
        Me.btnAddtoGrid.Size = New System.Drawing.Size(87, 53)
        Me.btnAddtoGrid.TabIndex = 258
        Me.btnAddtoGrid.Text = "Add "
        Me.btnAddtoGrid.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 257
        Me.Label4.Text = "Qty to Issue:"
        '
        'txtQtytoIssue
        '
        Me.txtQtytoIssue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtQtytoIssue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtQtytoIssue.Location = New System.Drawing.Point(96, 45)
        Me.txtQtytoIssue.Name = "txtQtytoIssue"
        Me.txtQtytoIssue.Size = New System.Drawing.Size(186, 20)
        Me.txtQtytoIssue.TabIndex = 256
        '
        'cmdSearchItems
        '
        Me.cmdSearchItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmdSearchItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmdSearchItems.FormattingEnabled = True
        Me.cmdSearchItems.Location = New System.Drawing.Point(96, 18)
        Me.cmdSearchItems.Name = "cmdSearchItems"
        Me.cmdSearchItems.Size = New System.Drawing.Size(186, 21)
        Me.cmdSearchItems.TabIndex = 255
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 254
        Me.Label5.Text = "Search Item:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 253
        Me.Label3.Text = "Item No:"
        '
        'LblDeliveryNo
        '
        Me.LblDeliveryNo.AutoSize = True
        Me.LblDeliveryNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeliveryNo.Location = New System.Drawing.Point(1001, 18)
        Me.LblDeliveryNo.Name = "LblDeliveryNo"
        Me.LblDeliveryNo.Size = New System.Drawing.Size(88, 16)
        Me.LblDeliveryNo.TabIndex = 251
        Me.LblDeliveryNo.Text = "##########"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(774, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 250
        '
        'txtItemcount
        '
        Me.txtItemcount.Enabled = False
        Me.txtItemcount.Location = New System.Drawing.Point(891, 67)
        Me.txtItemcount.Name = "txtItemcount"
        Me.txtItemcount.Size = New System.Drawing.Size(78, 20)
        Me.txtItemcount.TabIndex = 248
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(841, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 247
        Me.Label18.Text = "Count:"
        '
        'lblScheme
        '
        Me.lblScheme.AutoSize = True
        Me.lblScheme.BackColor = System.Drawing.Color.DimGray
        Me.lblScheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheme.ForeColor = System.Drawing.Color.Cyan
        Me.lblScheme.Location = New System.Drawing.Point(288, 48)
        Me.lblScheme.Name = "lblScheme"
        Me.lblScheme.Size = New System.Drawing.Size(46, 13)
        Me.lblScheme.TabIndex = 249
        Me.lblScheme.Text = "Scheme"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(499, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 13)
        Me.Label19.TabIndex = 246
        Me.Label19.Text = "Date:"
        '
        'txtQtyonHand
        '
        Me.txtQtyonHand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtQtyonHand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtQtyonHand.Enabled = False
        Me.txtQtyonHand.Location = New System.Drawing.Point(734, 19)
        Me.txtQtyonHand.Name = "txtQtyonHand"
        Me.txtQtyonHand.Size = New System.Drawing.Size(104, 20)
        Me.txtQtyonHand.TabIndex = 259
        '
        'txtItemCode
        '
        Me.txtItemCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtItemCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtItemCode.Enabled = False
        Me.txtItemCode.Location = New System.Drawing.Point(349, 19)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(144, 20)
        Me.txtItemCode.TabIndex = 252
        '
        'txtRemQty
        '
        Me.txtRemQty.Enabled = False
        Me.txtRemQty.Location = New System.Drawing.Point(754, 19)
        Me.txtRemQty.Name = "txtRemQty"
        Me.txtRemQty.Size = New System.Drawing.Size(20, 20)
        Me.txtRemQty.TabIndex = 269
        Me.txtRemQty.Visible = False
        '
        'dgwIssueItems
        '
        Me.dgwIssueItems.AllowUserToAddRows = False
        Me.dgwIssueItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgwIssueItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwIssueItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwIssueMaterialsItemNo, Me.dgwIssueMaterialsItemName, Me.dgwIssueMaterialsQty, Me.dgwIssueMaterialsQtyBal, Me.dgwIssueMaterialsUnitofIssue})
        Me.dgwIssueItems.Location = New System.Drawing.Point(1, 161)
        Me.dgwIssueItems.Name = "dgwIssueItems"
        Me.dgwIssueItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgwIssueItems.Size = New System.Drawing.Size(1119, 351)
        Me.dgwIssueItems.TabIndex = 225
        '
        'dgwIssueMaterialsItemNo
        '
        Me.dgwIssueMaterialsItemNo.HeaderText = "Item No"
        Me.dgwIssueMaterialsItemNo.Name = "dgwIssueMaterialsItemNo"
        Me.dgwIssueMaterialsItemNo.ReadOnly = True
        Me.dgwIssueMaterialsItemNo.Width = 250
        '
        'dgwIssueMaterialsItemName
        '
        Me.dgwIssueMaterialsItemName.HeaderText = "Item Name"
        Me.dgwIssueMaterialsItemName.Name = "dgwIssueMaterialsItemName"
        Me.dgwIssueMaterialsItemName.ReadOnly = True
        Me.dgwIssueMaterialsItemName.Width = 300
        '
        'dgwIssueMaterialsQty
        '
        Me.dgwIssueMaterialsQty.HeaderText = "Quantity"
        Me.dgwIssueMaterialsQty.Name = "dgwIssueMaterialsQty"
        Me.dgwIssueMaterialsQty.Width = 120
        '
        'dgwIssueMaterialsQtyBal
        '
        Me.dgwIssueMaterialsQtyBal.HeaderText = "Quantity Balance"
        Me.dgwIssueMaterialsQtyBal.Name = "dgwIssueMaterialsQtyBal"
        Me.dgwIssueMaterialsQtyBal.ReadOnly = True
        Me.dgwIssueMaterialsQtyBal.Width = 150
        '
        'dgwIssueMaterialsUnitofIssue
        '
        Me.dgwIssueMaterialsUnitofIssue.HeaderText = "Unit of Issue"
        Me.dgwIssueMaterialsUnitofIssue.Name = "dgwIssueMaterialsUnitofIssue"
        Me.dgwIssueMaterialsUnitofIssue.ReadOnly = True
        Me.dgwIssueMaterialsUnitofIssue.Width = 150
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.PSaveToolStripButton, Me.ClearToolStripButton, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(451, 515)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(210, 41)
        Me.ToolStrip1.TabIndex = 250
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 38)
        Me.ToolStripLabel1.Text = "   "
        '
        'PSaveToolStripButton
        '
        Me.PSaveToolStripButton.Image = CType(resources.GetObject("PSaveToolStripButton.Image"), System.Drawing.Image)
        Me.PSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PSaveToolStripButton.Name = "PSaveToolStripButton"
        Me.PSaveToolStripButton.Size = New System.Drawing.Size(51, 38)
        Me.PSaveToolStripButton.Text = "Save"
        '
        'ClearToolStripButton
        '
        Me.ClearToolStripButton.AutoSize = False
        Me.ClearToolStripButton.Image = CType(resources.GetObject("ClearToolStripButton.Image"), System.Drawing.Image)
        Me.ClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearToolStripButton.Name = "ClearToolStripButton"
        Me.ClearToolStripButton.Size = New System.Drawing.Size(65, 40)
        Me.ClearToolStripButton.Text = "Reset Form"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 38)
        Me.ToolStripLabel2.Text = "Close"
        '
        'txtApprovedby
        '
        Me.txtApprovedby.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtApprovedby.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtApprovedby.Enabled = False
        Me.txtApprovedby.Location = New System.Drawing.Point(602, 532)
        Me.txtApprovedby.Name = "txtApprovedby"
        Me.txtApprovedby.Size = New System.Drawing.Size(13, 20)
        Me.txtApprovedby.TabIndex = 264
        Me.txtApprovedby.Visible = False
        '
        'chkApproved
        '
        Me.chkApproved.AutoSize = True
        Me.chkApproved.Location = New System.Drawing.Point(508, 534)
        Me.chkApproved.Name = "chkApproved"
        Me.chkApproved.Size = New System.Drawing.Size(56, 17)
        Me.chkApproved.TabIndex = 263
        Me.chkApproved.Text = "Status"
        Me.chkApproved.UseVisualStyleBackColor = True
        Me.chkApproved.Visible = False
        '
        'txtCacelledby
        '
        Me.txtCacelledby.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCacelledby.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCacelledby.Enabled = False
        Me.txtCacelledby.Location = New System.Drawing.Point(586, 530)
        Me.txtCacelledby.Name = "txtCacelledby"
        Me.txtCacelledby.Size = New System.Drawing.Size(10, 20)
        Me.txtCacelledby.TabIndex = 266
        Me.txtCacelledby.Visible = False
        '
        'ChkCancelled
        '
        Me.ChkCancelled.AutoSize = True
        Me.ChkCancelled.Location = New System.Drawing.Point(556, 533)
        Me.ChkCancelled.Name = "ChkCancelled"
        Me.ChkCancelled.Size = New System.Drawing.Size(89, 17)
        Me.ChkCancelled.TabIndex = 265
        Me.ChkCancelled.Text = "CancelStatus"
        Me.ChkCancelled.UseVisualStyleBackColor = True
        Me.ChkCancelled.Visible = False
        '
        'txtNil
        '
        Me.txtNil.Enabled = False
        Me.txtNil.Location = New System.Drawing.Point(488, 531)
        Me.txtNil.Name = "txtNil"
        Me.txtNil.Size = New System.Drawing.Size(10, 20)
        Me.txtNil.TabIndex = 270
        '
        'txtCurrentItemNo
        '
        Me.txtCurrentItemNo.Enabled = False
        Me.txtCurrentItemNo.Location = New System.Drawing.Point(942, 256)
        Me.txtCurrentItemNo.Name = "txtCurrentItemNo"
        Me.txtCurrentItemNo.Size = New System.Drawing.Size(68, 20)
        Me.txtCurrentItemNo.TabIndex = 271
        Me.txtCurrentItemNo.Visible = False
        '
        'frmMaterialIssuance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 565)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtApprovedby)
        Me.Controls.Add(Me.txtCacelledby)
        Me.Controls.Add(Me.ChkCancelled)
        Me.Controls.Add(Me.dgwIssueItems)
        Me.Controls.Add(Me.Details)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.chkApproved)
        Me.Controls.Add(Me.txtNil)
        Me.Controls.Add(Me.txtCurrentItemNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmMaterialIssuance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Details.ResumeLayout(False)
        Me.Details.PerformLayout()
        CType(Me.dgwIssueItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Details As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSchemeRefNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddtoGrid As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQtytoIssue As TextBox
    Friend WithEvents cmdSearchItems As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblDeliveryNo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtItemcount As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents lblScheme As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtQtyonHand As TextBox
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents dgwIssueItems As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents PSaveToolStripButton As ToolStripButton
    Friend WithEvents ClearToolStripButton As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtUnitofIssue As TextBox
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents lbldate As DateTimePicker
    Friend WithEvents txtApprovedby As TextBox
    Friend WithEvents chkApproved As CheckBox
    Friend WithEvents txtCacelledby As TextBox
    Friend WithEvents ChkCancelled As CheckBox
    Friend WithEvents txtRemQty As TextBox
    Friend WithEvents cboVehicleNo As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtVehicleID As TextBox
    Friend WithEvents txtNil As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtConstituencyname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents dgwIssueMaterialsItemNo As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsItemName As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsQty As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsQtyBal As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsUnitofIssue As DataGridViewTextBoxColumn
    Friend WithEvents chkIssuetoSubContractor As CheckBox
    Friend WithEvents cboSubcontractor As ComboBox
    Friend WithEvents txtSubcontractor As TextBox
    Friend WithEvents btnLoadSchemes As Button
    Friend WithEvents txtSchemeName As TextBox
    Friend WithEvents txtCurrentItemNo As TextBox
    Friend WithEvents txtTXNo As TextBox
    Friend WithEvents Label11 As Label
End Class
