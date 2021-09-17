<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReceiveMeters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceiveMeters))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtWarehouseName = New System.Windows.Forms.TextBox()
        Me.txtwarehouseID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBrowseexcel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQtyrcvd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTXNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtConstituencyname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSchemeName = New System.Windows.Forms.TextBox()
        Me.btnLoadSchemes = New System.Windows.Forms.Button()
        Me.txtSchemeRefNo = New System.Windows.Forms.TextBox()
        Me.lbldate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScheme = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgwx = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.DuplicatesToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.CSaveToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.CVoidToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.dgwz = New System.Windows.Forms.DataGridView()
        Me.colSchemeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgwx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgwz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(1, 1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(933, 40)
        Me.TextBox1.TabIndex = 168
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(385, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 20)
        Me.Label7.TabIndex = 222
        Me.Label7.Text = "Create Customers"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtWarehouseName)
        Me.GroupBox1.Controls.Add(Me.txtwarehouseID)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnBrowseexcel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtQtyrcvd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTXNo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtConstituencyname)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCounty)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSchemeName)
        Me.GroupBox1.Controls.Add(Me.btnLoadSchemes)
        Me.GroupBox1.Controls.Add(Me.txtSchemeRefNo)
        Me.GroupBox1.Controls.Add(Me.lbldate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblScheme)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtConstituencyID)
        Me.GroupBox1.Controls.Add(Me.txtSchemeID)
        Me.GroupBox1.Controls.Add(Me.txtCountyID)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(933, 68)
        Me.GroupBox1.TabIndex = 223
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
        Me.cboStatus.Location = New System.Drawing.Point(759, 36)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(67, 21)
        Me.cboStatus.TabIndex = 325
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(771, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 14)
        Me.Label8.TabIndex = 324
        Me.Label8.Text = "Status:"
        '
        'txtWarehouseName
        '
        Me.txtWarehouseName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtWarehouseName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtWarehouseName.Enabled = False
        Me.txtWarehouseName.Location = New System.Drawing.Point(454, 35)
        Me.txtWarehouseName.Name = "txtWarehouseName"
        Me.txtWarehouseName.Size = New System.Drawing.Size(98, 20)
        Me.txtWarehouseName.TabIndex = 306
        '
        'txtwarehouseID
        '
        Me.txtwarehouseID.Location = New System.Drawing.Point(520, 35)
        Me.txtwarehouseID.Name = "txtwarehouseID"
        Me.txtwarehouseID.Size = New System.Drawing.Size(23, 20)
        Me.txtwarehouseID.TabIndex = 313
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(558, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 17)
        Me.Button1.TabIndex = 312
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnBrowseexcel
        '
        Me.btnBrowseexcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBrowseexcel.Location = New System.Drawing.Point(832, 10)
        Me.btnBrowseexcel.Name = "btnBrowseexcel"
        Me.btnBrowseexcel.Size = New System.Drawing.Size(94, 51)
        Me.btnBrowseexcel.TabIndex = 308
        Me.btnBrowseexcel.Text = "Import Customer List"
        Me.btnBrowseexcel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(385, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 14)
        Me.Label5.TabIndex = 307
        Me.Label5.Text = " Warehouse:"
        '
        'txtQtyrcvd
        '
        Me.txtQtyrcvd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtQtyrcvd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtQtyrcvd.Location = New System.Drawing.Point(659, 37)
        Me.txtQtyrcvd.Name = "txtQtyrcvd"
        Me.txtQtyrcvd.Size = New System.Drawing.Size(97, 20)
        Me.txtQtyrcvd.TabIndex = 304
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(586, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 14)
        Me.Label4.TabIndex = 305
        Me.Label4.Text = "Total Meters"
        '
        'txtTXNo
        '
        Me.txtTXNo.Enabled = False
        Me.txtTXNo.Location = New System.Drawing.Point(54, 39)
        Me.txtTXNo.Name = "txtTXNo"
        Me.txtTXNo.Size = New System.Drawing.Size(141, 20)
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
        Me.txtConstituencyname.Location = New System.Drawing.Point(455, 10)
        Me.txtConstituencyname.Name = "txtConstituencyname"
        Me.txtConstituencyname.Size = New System.Drawing.Size(125, 20)
        Me.txtConstituencyname.TabIndex = 294
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(385, 13)
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
        Me.txtCounty.Location = New System.Drawing.Point(258, 39)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(122, 20)
        Me.txtCounty.TabIndex = 292
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(201, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 14)
        Me.Label9.TabIndex = 293
        Me.Label9.Text = "County:"
        '
        'txtSchemeName
        '
        Me.txtSchemeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeName.Enabled = False
        Me.txtSchemeName.Location = New System.Drawing.Point(54, 13)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(113, 20)
        Me.txtSchemeName.TabIndex = 297
        '
        'btnLoadSchemes
        '
        Me.btnLoadSchemes.BackColor = System.Drawing.Color.DarkGray
        Me.btnLoadSchemes.BackgroundImage = CType(resources.GetObject("btnLoadSchemes.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadSchemes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadSchemes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSchemes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSchemes.Location = New System.Drawing.Point(173, 14)
        Me.btnLoadSchemes.Name = "btnLoadSchemes"
        Me.btnLoadSchemes.Size = New System.Drawing.Size(22, 17)
        Me.btnLoadSchemes.TabIndex = 296
        Me.btnLoadSchemes.UseVisualStyleBackColor = False
        '
        'txtSchemeRefNo
        '
        Me.txtSchemeRefNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeRefNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeRefNo.Location = New System.Drawing.Point(258, 10)
        Me.txtSchemeRefNo.Name = "txtSchemeRefNo"
        Me.txtSchemeRefNo.Size = New System.Drawing.Size(122, 20)
        Me.txtSchemeRefNo.TabIndex = 289
        '
        'lbldate
        '
        Me.lbldate.CustomFormat = "MM/dd/yyyy"
        Me.lbldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.lbldate.Location = New System.Drawing.Point(659, 11)
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
        Me.Label1.Location = New System.Drawing.Point(201, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 290
        Me.Label1.Text = "Schm Ref"
        '
        'lblScheme
        '
        Me.lblScheme.AutoSize = True
        Me.lblScheme.BackColor = System.Drawing.Color.White
        Me.lblScheme.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheme.ForeColor = System.Drawing.Color.Black
        Me.lblScheme.Location = New System.Drawing.Point(6, 15)
        Me.lblScheme.Name = "lblScheme"
        Me.lblScheme.Size = New System.Drawing.Size(42, 14)
        Me.lblScheme.TabIndex = 288
        Me.lblScheme.Text = "Scheme"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(586, 13)
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
        Me.txtConstituencyID.Location = New System.Drawing.Point(364, 10)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(16, 20)
        Me.txtConstituencyID.TabIndex = 311
        '
        'txtSchemeID
        '
        Me.txtSchemeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeID.Enabled = False
        Me.txtSchemeID.Location = New System.Drawing.Point(335, 10)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(23, 20)
        Me.txtSchemeID.TabIndex = 309
        '
        'txtCountyID
        '
        Me.txtCountyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCountyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCountyID.Enabled = False
        Me.txtCountyID.Location = New System.Drawing.Point(305, 10)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(24, 20)
        Me.txtCountyID.TabIndex = 310
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgwx
        '
        Me.dgwx.AllowUserToAddRows = False
        Me.dgwx.AllowUserToDeleteRows = False
        Me.dgwx.BackgroundColor = System.Drawing.Color.Wheat
        Me.dgwx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwx.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgwx.Location = New System.Drawing.Point(1, 121)
        Me.dgwx.Name = "dgwx"
        Me.dgwx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgwx.Size = New System.Drawing.Size(933, 278)
        Me.dgwx.TabIndex = 224
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DuplicatesToolStripButton4, Me.CSaveToolStripButton5, Me.CVoidToolStripButton3, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(340, 402)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(279, 35)
        Me.ToolStrip1.TabIndex = 226
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'DuplicatesToolStripButton4
        '
        Me.DuplicatesToolStripButton4.AutoSize = False
        Me.DuplicatesToolStripButton4.Image = CType(resources.GetObject("DuplicatesToolStripButton4.Image"), System.Drawing.Image)
        Me.DuplicatesToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DuplicatesToolStripButton4.Name = "DuplicatesToolStripButton4"
        Me.DuplicatesToolStripButton4.Size = New System.Drawing.Size(80, 50)
        Me.DuplicatesToolStripButton4.Text = "&Duplicates"
        Me.DuplicatesToolStripButton4.ToolTipText = "Duplicates"
        '
        'CSaveToolStripButton5
        '
        Me.CSaveToolStripButton5.Image = CType(resources.GetObject("CSaveToolStripButton5.Image"), System.Drawing.Image)
        Me.CSaveToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CSaveToolStripButton5.Name = "CSaveToolStripButton5"
        Me.CSaveToolStripButton5.Size = New System.Drawing.Size(51, 32)
        Me.CSaveToolStripButton5.Text = "Save"
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
        'dgwz
        '
        Me.dgwz.AllowUserToAddRows = False
        Me.dgwz.AllowUserToDeleteRows = False
        Me.dgwz.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.dgwz.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgwz.BackgroundColor = System.Drawing.Color.White
        Me.dgwz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwz.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgwz.ColumnHeadersHeight = 24
        Me.dgwz.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSchemeID, Me.colmterno})
        Me.dgwz.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwz.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgwz.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgwz.EnableHeadersVisualStyles = False
        Me.dgwz.GridColor = System.Drawing.Color.DarkOrange
        Me.dgwz.Location = New System.Drawing.Point(660, 121)
        Me.dgwz.MultiSelect = False
        Me.dgwz.Name = "dgwz"
        Me.dgwz.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwz.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgwz.RowHeadersWidth = 25
        Me.dgwz.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgwz.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgwz.RowTemplate.Height = 18
        Me.dgwz.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgwz.Size = New System.Drawing.Size(173, 278)
        Me.dgwz.TabIndex = 228
        '
        'colSchemeID
        '
        Me.colSchemeID.HeaderText = "Scheme ID"
        Me.colSchemeID.Name = "colSchemeID"
        Me.colSchemeID.Width = 50
        '
        'colmterno
        '
        Me.colmterno.HeaderText = "Meter No"
        Me.colmterno.Name = "colmterno"
        Me.colmterno.ReadOnly = True
        Me.colmterno.Width = 90
        '
        'frmReceiveMeters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 439)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgwx)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgwz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmReceiveMeters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgwx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgwz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents txtWarehouseName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQtyrcvd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBrowseexcel As Button
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colQtyperUoM As DataGridViewTextBoxColumn
    Friend WithEvents colUnits As DataGridViewTextBoxColumn
    Friend WithEvents colXco As DataGridViewTextBoxColumn
    Friend WithEvents colY As DataGridViewTextBoxColumn
    Friend WithEvents colMeterno As DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dgwx As DataGridView
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtwarehouseID As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents CSaveToolStripButton5 As ToolStripButton
    Friend WithEvents DuplicatesToolStripButton4 As ToolStripButton
    Friend WithEvents CVoidToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents dgwz As DataGridView
    Friend WithEvents colSchemeID As DataGridViewTextBoxColumn
    Friend WithEvents colmterno As DataGridViewTextBoxColumn
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label8 As Label
End Class
