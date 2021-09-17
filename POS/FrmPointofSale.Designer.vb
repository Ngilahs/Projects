<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPointofSale
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPointofSale))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Mnstrp_ShortCutMenu = New System.Windows.Forms.MenuStrip()
        Me.VoidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TENDEREDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POS2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickItemEditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecallTransactionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblScheme = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtItemcount = New System.Windows.Forms.TextBox()
        Me.LblDeliveryNo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgwIssueItems = New System.Windows.Forms.DataGridView()
        Me.dgwIssueMaterialsItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsQtyBal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsUnitofIssue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDocu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSchemeRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDeliveryNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStockInDetailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdSearchItems = New System.Windows.Forms.ComboBox()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.LBLZeroValue = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtytoIssue = New System.Windows.Forms.TextBox()
        Me.btnAddtoGrid = New System.Windows.Forms.Button()
        Me.txtUoM = New System.Windows.Forms.TextBox()
        Me.txtRemQty = New System.Windows.Forms.TextBox()
        Me.txtUnitofIssue = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSchemeRefNo = New System.Windows.Forms.TextBox()
        Me.CboSchemeName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkApproved = New System.Windows.Forms.CheckBox()
        Me.txtApprovedby = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PSaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.LookupToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.VoidToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ClearToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtDeliveryNote = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtInStock = New System.Windows.Forms.TextBox()
        Me.txtSchemeRefNoFrom = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboDocumentNo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSchmeID = New System.Windows.Forms.TextBox()
        Me.txtStockinDetailID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboVehicleNo = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.DateTimePicker()
        Me.txtVehicleID = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMaterialName = New System.Windows.Forms.TextBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwItemsStockonHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReorderLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStkinID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSchmId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChkCancelled = New System.Windows.Forms.CheckBox()
        Me.txtCacelledby = New System.Windows.Forms.TextBox()
        Me.txtTotStock = New System.Windows.Forms.TextBox()
        Me.Mnstrp_ShortCutMenu.SuspendLayout()
        CType(Me.dgwIssueItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1084, 38)
        Me.TextBox1.TabIndex = 138
        '
        'Mnstrp_ShortCutMenu
        '
        Me.Mnstrp_ShortCutMenu.AutoSize = False
        Me.Mnstrp_ShortCutMenu.BackColor = System.Drawing.Color.Transparent
        Me.Mnstrp_ShortCutMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.Mnstrp_ShortCutMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoidToolStripMenuItem, Me.TToolStripMenuItem, Me.PrintSaveToolStripMenuItem, Me.ScrToolStripMenuItem, Me.TENDEREDToolStripMenuItem, Me.ESCToolStripMenuItem, Me.POS2ToolStripMenuItem, Me.QuickItemEditToolStripMenuItem1, Me.RecallTransactionToolStripMenuItem1})
        Me.Mnstrp_ShortCutMenu.Location = New System.Drawing.Point(500, 500)
        Me.Mnstrp_ShortCutMenu.Name = "Mnstrp_ShortCutMenu"
        Me.Mnstrp_ShortCutMenu.Size = New System.Drawing.Size(28, 29)
        Me.Mnstrp_ShortCutMenu.TabIndex = 24
        Me.Mnstrp_ShortCutMenu.Text = "MenuStrip1"
        Me.Mnstrp_ShortCutMenu.Visible = False
        '
        'VoidToolStripMenuItem
        '
        Me.VoidToolStripMenuItem.AutoSize = False
        Me.VoidToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VoidToolStripMenuItem.Name = "VoidToolStripMenuItem"
        Me.VoidToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.VoidToolStripMenuItem.Size = New System.Drawing.Size(43, 62)
        Me.VoidToolStripMenuItem.Text = "Void"
        '
        'TToolStripMenuItem
        '
        Me.TToolStripMenuItem.AutoSize = False
        Me.TToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TToolStripMenuItem.Name = "TToolStripMenuItem"
        Me.TToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.TToolStripMenuItem.Size = New System.Drawing.Size(38, 62)
        Me.TToolStripMenuItem.Text = "Qty"
        '
        'PrintSaveToolStripMenuItem
        '
        Me.PrintSaveToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PrintSaveToolStripMenuItem.Name = "PrintSaveToolStripMenuItem"
        Me.PrintSaveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.PrintSaveToolStripMenuItem.Size = New System.Drawing.Size(73, 25)
        Me.PrintSaveToolStripMenuItem.Text = "PrintSave"
        '
        'ScrToolStripMenuItem
        '
        Me.ScrToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ScrToolStripMenuItem.Name = "ScrToolStripMenuItem"
        Me.ScrToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.ScrToolStripMenuItem.Size = New System.Drawing.Size(101, 25)
        Me.ScrToolStripMenuItem.Text = "ScrollGridview"
        '
        'TENDEREDToolStripMenuItem
        '
        Me.TENDEREDToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TENDEREDToolStripMenuItem.Name = "TENDEREDToolStripMenuItem"
        Me.TENDEREDToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.TENDEREDToolStripMenuItem.Size = New System.Drawing.Size(79, 25)
        Me.TENDEREDToolStripMenuItem.Text = "TENDERED"
        '
        'ESCToolStripMenuItem
        '
        Me.ESCToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ESCToolStripMenuItem.Name = "ESCToolStripMenuItem"
        Me.ESCToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ESCToolStripMenuItem.Size = New System.Drawing.Size(101, 25)
        Me.ESCToolStripMenuItem.Text = "QuickPurchase"
        '
        'POS2ToolStripMenuItem
        '
        Me.POS2ToolStripMenuItem.Name = "POS2ToolStripMenuItem"
        Me.POS2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.POS2ToolStripMenuItem.Size = New System.Drawing.Size(47, 25)
        Me.POS2ToolStripMenuItem.Text = "POS2"
        '
        'QuickItemEditToolStripMenuItem1
        '
        Me.QuickItemEditToolStripMenuItem1.Name = "QuickItemEditToolStripMenuItem1"
        Me.QuickItemEditToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.QuickItemEditToolStripMenuItem1.Size = New System.Drawing.Size(127, 25)
        Me.QuickItemEditToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'RecallTransactionToolStripMenuItem1
        '
        Me.RecallTransactionToolStripMenuItem1.Name = "RecallTransactionToolStripMenuItem1"
        Me.RecallTransactionToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F20
        Me.RecallTransactionToolStripMenuItem1.Size = New System.Drawing.Size(127, 25)
        Me.RecallTransactionToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 157
        Me.Label19.Text = "Date :"
        '
        'lblScheme
        '
        Me.lblScheme.AutoSize = True
        Me.lblScheme.BackColor = System.Drawing.Color.DimGray
        Me.lblScheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheme.ForeColor = System.Drawing.Color.Cyan
        Me.lblScheme.Location = New System.Drawing.Point(169, 57)
        Me.lblScheme.Name = "lblScheme"
        Me.lblScheme.Size = New System.Drawing.Size(41, 13)
        Me.lblScheme.TabIndex = 175
        Me.lblScheme.Text = " Name:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(169, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 160
        Me.Label18.Text = "Count:"
        '
        'txtItemcount
        '
        Me.txtItemcount.Enabled = False
        Me.txtItemcount.Location = New System.Drawing.Point(218, 14)
        Me.txtItemcount.Name = "txtItemcount"
        Me.txtItemcount.Size = New System.Drawing.Size(98, 20)
        Me.txtItemcount.TabIndex = 161
        '
        'LblDeliveryNo
        '
        Me.LblDeliveryNo.AutoSize = True
        Me.LblDeliveryNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeliveryNo.Location = New System.Drawing.Point(329, 11)
        Me.LblDeliveryNo.Name = "LblDeliveryNo"
        Me.LblDeliveryNo.Size = New System.Drawing.Size(32, 16)
        Me.LblDeliveryNo.TabIndex = 199
        Me.LblDeliveryNo.Text = "###"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(815, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 198
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(487, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 221
        Me.Label2.Text = "Issue Materials"
        '
        'dgwIssueItems
        '
        Me.dgwIssueItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgwIssueItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwIssueItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwIssueMaterialsItemNo, Me.dgwIssueMaterialsItemName, Me.dgwIssueMaterialsQty, Me.dgwIssueMaterialsQtyBal, Me.dgwIssueMaterialsUnitofIssue, Me.colDocu, Me.colSchemeRef, Me.colDeliveryNo, Me.colStockInDetailID})
        Me.dgwIssueItems.Location = New System.Drawing.Point(315, 169)
        Me.dgwIssueItems.Name = "dgwIssueItems"
        Me.dgwIssueItems.ReadOnly = True
        Me.dgwIssueItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgwIssueItems.Size = New System.Drawing.Size(768, 306)
        Me.dgwIssueItems.TabIndex = 224
        '
        'dgwIssueMaterialsItemNo
        '
        Me.dgwIssueMaterialsItemNo.HeaderText = "Item No"
        Me.dgwIssueMaterialsItemNo.Name = "dgwIssueMaterialsItemNo"
        Me.dgwIssueMaterialsItemNo.ReadOnly = True
        Me.dgwIssueMaterialsItemNo.Width = 120
        '
        'dgwIssueMaterialsItemName
        '
        Me.dgwIssueMaterialsItemName.HeaderText = "Item Name"
        Me.dgwIssueMaterialsItemName.Name = "dgwIssueMaterialsItemName"
        Me.dgwIssueMaterialsItemName.ReadOnly = True
        Me.dgwIssueMaterialsItemName.Width = 175
        '
        'dgwIssueMaterialsQty
        '
        Me.dgwIssueMaterialsQty.HeaderText = "Qty"
        Me.dgwIssueMaterialsQty.Name = "dgwIssueMaterialsQty"
        Me.dgwIssueMaterialsQty.ReadOnly = True
        Me.dgwIssueMaterialsQty.Width = 120
        '
        'dgwIssueMaterialsQtyBal
        '
        Me.dgwIssueMaterialsQtyBal.HeaderText = "Qty Bal"
        Me.dgwIssueMaterialsQtyBal.Name = "dgwIssueMaterialsQtyBal"
        Me.dgwIssueMaterialsQtyBal.ReadOnly = True
        Me.dgwIssueMaterialsQtyBal.Visible = False
        Me.dgwIssueMaterialsQtyBal.Width = 55
        '
        'dgwIssueMaterialsUnitofIssue
        '
        Me.dgwIssueMaterialsUnitofIssue.HeaderText = "UoM"
        Me.dgwIssueMaterialsUnitofIssue.Name = "dgwIssueMaterialsUnitofIssue"
        Me.dgwIssueMaterialsUnitofIssue.ReadOnly = True
        Me.dgwIssueMaterialsUnitofIssue.Width = 65
        '
        'colDocu
        '
        Me.colDocu.HeaderText = "Doc No."
        Me.colDocu.Name = "colDocu"
        Me.colDocu.ReadOnly = True
        Me.colDocu.Width = 150
        '
        'colSchemeRef
        '
        Me.colSchemeRef.HeaderText = "Schm Ref"
        Me.colSchemeRef.Name = "colSchemeRef"
        Me.colSchemeRef.ReadOnly = True
        Me.colSchemeRef.Visible = False
        '
        'colDeliveryNo
        '
        Me.colDeliveryNo.HeaderText = "D.No"
        Me.colDeliveryNo.Name = "colDeliveryNo"
        Me.colDeliveryNo.ReadOnly = True
        Me.colDeliveryNo.Visible = False
        '
        'colStockInDetailID
        '
        Me.colStockInDetailID.HeaderText = "StockInID"
        Me.colStockInDetailID.Name = "colStockInDetailID"
        Me.colStockInDetailID.ReadOnly = True
        Me.colStockInDetailID.Width = 75
        '
        'txtSchemeID
        '
        Me.txtSchemeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeID.Enabled = False
        Me.txtSchemeID.Location = New System.Drawing.Point(123, 39)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(19, 20)
        Me.txtSchemeID.TabIndex = 225
        '
        'txtItemCode
        '
        Me.txtItemCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtItemCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtItemCode.Enabled = False
        Me.txtItemCode.Location = New System.Drawing.Point(100, 85)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(145, 20)
        Me.txtItemCode.TabIndex = 227
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 228
        Me.Label3.Text = "Item No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 229
        Me.Label5.Text = "Select Item:"
        '
        'cmdSearchItems
        '
        Me.cmdSearchItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmdSearchItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmdSearchItems.Enabled = False
        Me.cmdSearchItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearchItems.FormattingEnabled = True
        Me.cmdSearchItems.Location = New System.Drawing.Point(100, 49)
        Me.cmdSearchItems.Name = "cmdSearchItems"
        Me.cmdSearchItems.Size = New System.Drawing.Size(145, 21)
        Me.cmdSearchItems.TabIndex = 230
        '
        'txtCountyID
        '
        Me.txtCountyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCountyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCountyID.Enabled = False
        Me.txtCountyID.Location = New System.Drawing.Point(109, 39)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(10, 20)
        Me.txtCountyID.TabIndex = 231
        Me.txtCountyID.Visible = False
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyID.Enabled = False
        Me.txtConstituencyID.Location = New System.Drawing.Point(93, 39)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(10, 20)
        Me.txtConstituencyID.TabIndex = 232
        Me.txtConstituencyID.Visible = False
        '
        'LBLZeroValue
        '
        Me.LBLZeroValue.AutoSize = True
        Me.LBLZeroValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLZeroValue.Location = New System.Drawing.Point(821, 407)
        Me.LBLZeroValue.Name = "LBLZeroValue"
        Me.LBLZeroValue.Size = New System.Drawing.Size(14, 13)
        Me.LBLZeroValue.TabIndex = 234
        Me.LBLZeroValue.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 236
        Me.Label4.Text = "Qty:"
        '
        'txtQtytoIssue
        '
        Me.txtQtytoIssue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtQtytoIssue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtQtytoIssue.Location = New System.Drawing.Point(53, 15)
        Me.txtQtytoIssue.Name = "txtQtytoIssue"
        Me.txtQtytoIssue.Size = New System.Drawing.Size(110, 20)
        Me.txtQtytoIssue.TabIndex = 235
        '
        'btnAddtoGrid
        '
        Me.btnAddtoGrid.BackColor = System.Drawing.Color.Cyan
        Me.btnAddtoGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoGrid.Location = New System.Drawing.Point(321, 42)
        Me.btnAddtoGrid.Name = "btnAddtoGrid"
        Me.btnAddtoGrid.Size = New System.Drawing.Size(40, 67)
        Me.btnAddtoGrid.TabIndex = 237
        Me.btnAddtoGrid.Text = "Add "
        Me.btnAddtoGrid.UseVisualStyleBackColor = False
        '
        'txtUoM
        '
        Me.txtUoM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtUoM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtUoM.Enabled = False
        Me.txtUoM.Location = New System.Drawing.Point(219, 86)
        Me.txtUoM.Name = "txtUoM"
        Me.txtUoM.Size = New System.Drawing.Size(97, 20)
        Me.txtUoM.TabIndex = 238
        '
        'txtRemQty
        '
        Me.txtRemQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRemQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRemQty.Location = New System.Drawing.Point(520, 13)
        Me.txtRemQty.Name = "txtRemQty"
        Me.txtRemQty.Size = New System.Drawing.Size(18, 20)
        Me.txtRemQty.TabIndex = 239
        Me.txtRemQty.Visible = False
        '
        'txtUnitofIssue
        '
        Me.txtUnitofIssue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtUnitofIssue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtUnitofIssue.Location = New System.Drawing.Point(544, 12)
        Me.txtUnitofIssue.Name = "txtUnitofIssue"
        Me.txtUnitofIssue.Size = New System.Drawing.Size(14, 20)
        Me.txtUnitofIssue.TabIndex = 240
        Me.txtUnitofIssue.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(173, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "UoM:"
        '
        'txtSchemeRefNo
        '
        Me.txtSchemeRefNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeRefNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeRefNo.Location = New System.Drawing.Point(54, 38)
        Me.txtSchemeRefNo.Name = "txtSchemeRefNo"
        Me.txtSchemeRefNo.Size = New System.Drawing.Size(109, 20)
        Me.txtSchemeRefNo.TabIndex = 242
        '
        'CboSchemeName
        '
        Me.CboSchemeName.Enabled = False
        Me.CboSchemeName.Location = New System.Drawing.Point(218, 52)
        Me.CboSchemeName.Name = "CboSchemeName"
        Me.CboSchemeName.Size = New System.Drawing.Size(98, 20)
        Me.CboSchemeName.TabIndex = 243
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 244
        Me.Label1.Text = "Schm#"
        '
        'chkApproved
        '
        Me.chkApproved.AutoSize = True
        Me.chkApproved.Location = New System.Drawing.Point(451, 494)
        Me.chkApproved.Name = "chkApproved"
        Me.chkApproved.Size = New System.Drawing.Size(56, 17)
        Me.chkApproved.TabIndex = 245
        Me.chkApproved.Text = "Status"
        Me.chkApproved.UseVisualStyleBackColor = True
        Me.chkApproved.Visible = False
        '
        'txtApprovedby
        '
        Me.txtApprovedby.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtApprovedby.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtApprovedby.Enabled = False
        Me.txtApprovedby.Location = New System.Drawing.Point(503, 493)
        Me.txtApprovedby.Name = "txtApprovedby"
        Me.txtApprovedby.Size = New System.Drawing.Size(13, 20)
        Me.txtApprovedby.TabIndex = 246
        Me.txtApprovedby.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.PSaveToolStripButton, Me.LookupToolStripButton3, Me.VoidToolStripButton4, Me.ClearToolStripButton, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(365, 478)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(339, 41)
        Me.ToolStrip1.TabIndex = 249
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
        'LookupToolStripButton3
        '
        Me.LookupToolStripButton3.AutoSize = False
        Me.LookupToolStripButton3.Image = CType(resources.GetObject("LookupToolStripButton3.Image"), System.Drawing.Image)
        Me.LookupToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LookupToolStripButton3.Name = "LookupToolStripButton3"
        Me.LookupToolStripButton3.Size = New System.Drawing.Size(65, 40)
        Me.LookupToolStripButton3.Text = "&Lookup"
        '
        'VoidToolStripButton4
        '
        Me.VoidToolStripButton4.AutoSize = False
        Me.VoidToolStripButton4.Image = CType(resources.GetObject("VoidToolStripButton4.Image"), System.Drawing.Image)
        Me.VoidToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.VoidToolStripButton4.Name = "VoidToolStripButton4"
        Me.VoidToolStripButton4.Size = New System.Drawing.Size(65, 50)
        Me.VoidToolStripButton4.Text = "&Void"
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
        'txtDeliveryNote
        '
        Me.txtDeliveryNote.BackColor = System.Drawing.Color.White
        Me.txtDeliveryNote.Enabled = False
        Me.txtDeliveryNote.Location = New System.Drawing.Point(370, 52)
        Me.txtDeliveryNote.Name = "txtDeliveryNote"
        Me.txtDeliveryNote.Size = New System.Drawing.Size(31, 20)
        Me.txtDeliveryNote.TabIndex = 253
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(248, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 257
        Me.Label12.Text = "In Stock"
        '
        'txtInStock
        '
        Me.txtInStock.Enabled = False
        Me.txtInStock.Location = New System.Drawing.Point(308, 85)
        Me.txtInStock.Name = "txtInStock"
        Me.txtInStock.Size = New System.Drawing.Size(93, 20)
        Me.txtInStock.TabIndex = 256
        '
        'txtSchemeRefNoFrom
        '
        Me.txtSchemeRefNoFrom.BackColor = System.Drawing.Color.White
        Me.txtSchemeRefNoFrom.Enabled = False
        Me.txtSchemeRefNoFrom.Location = New System.Drawing.Point(308, 12)
        Me.txtSchemeRefNoFrom.Name = "txtSchemeRefNoFrom"
        Me.txtSchemeRefNoFrom.Size = New System.Drawing.Size(93, 20)
        Me.txtSchemeRefNoFrom.TabIndex = 255
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(252, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 254
        Me.Label11.Text = "Schm#:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(248, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 252
        Me.Label10.Text = "Tot Store:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 250
        Me.Label9.Text = "Document No:"
        '
        'cboDocumentNo
        '
        Me.cboDocumentNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboDocumentNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDocumentNo.Enabled = False
        Me.cboDocumentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDocumentNo.FormattingEnabled = True
        Me.cboDocumentNo.Location = New System.Drawing.Point(100, 8)
        Me.cboDocumentNo.Name = "cboDocumentNo"
        Me.cboDocumentNo.Size = New System.Drawing.Size(145, 21)
        Me.cboDocumentNo.TabIndex = 251
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotStock)
        Me.GroupBox1.Controls.Add(Me.txtSchemeRefNoFrom)
        Me.GroupBox1.Controls.Add(Me.txtSchmeID)
        Me.GroupBox1.Controls.Add(Me.txtItemCode)
        Me.GroupBox1.Controls.Add(Me.txtStockinDetailID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmdSearchItems)
        Me.GroupBox1.Controls.Add(Me.txtDeliveryNote)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtInStock)
        Me.GroupBox1.Controls.Add(Me.txtUnitofIssue)
        Me.GroupBox1.Controls.Add(Me.txtRemQty)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboDocumentNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(315, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 119)
        Me.GroupBox1.TabIndex = 258
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "From"
        '
        'txtSchmeID
        '
        Me.txtSchmeID.Enabled = False
        Me.txtSchmeID.Location = New System.Drawing.Point(370, 13)
        Me.txtSchmeID.Name = "txtSchmeID"
        Me.txtSchmeID.Size = New System.Drawing.Size(31, 20)
        Me.txtSchmeID.TabIndex = 259
        '
        'txtStockinDetailID
        '
        Me.txtStockinDetailID.Enabled = False
        Me.txtStockinDetailID.Location = New System.Drawing.Point(161, 86)
        Me.txtStockinDetailID.Name = "txtStockinDetailID"
        Me.txtStockinDetailID.Size = New System.Drawing.Size(31, 20)
        Me.txtStockinDetailID.TabIndex = 258
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboVehicleNo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lbldate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtQtytoIssue)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.btnAddtoGrid)
        Me.GroupBox2.Controls.Add(Me.LblDeliveryNo)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtItemcount)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtUoM)
        Me.GroupBox2.Controls.Add(Me.lblScheme)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtSchemeRefNo)
        Me.GroupBox2.Controls.Add(Me.CboSchemeName)
        Me.GroupBox2.Controls.Add(Me.txtConstituencyID)
        Me.GroupBox2.Controls.Add(Me.txtCountyID)
        Me.GroupBox2.Controls.Add(Me.txtSchemeID)
        Me.GroupBox2.Controls.Add(Me.txtVehicleID)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(722, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 119)
        Me.GroupBox2.TabIndex = 259
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Issue Details"
        '
        'cboVehicleNo
        '
        Me.cboVehicleNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboVehicleNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVehicleNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehicleNo.FormattingEnabled = True
        Me.cboVehicleNo.Location = New System.Drawing.Point(54, 89)
        Me.cboVehicleNo.Name = "cboVehicleNo"
        Me.cboVehicleNo.Size = New System.Drawing.Size(109, 21)
        Me.cboVehicleNo.TabIndex = 253
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 252
        Me.Label14.Text = "Vehicle:"
        '
        'lbldate
        '
        Me.lbldate.CustomFormat = "MM/dd/yyyy"
        Me.lbldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.lbldate.Location = New System.Drawing.Point(53, 62)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(110, 20)
        Me.lbldate.TabIndex = 251
        '
        'txtVehicleID
        '
        Me.txtVehicleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtVehicleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtVehicleID.Enabled = False
        Me.txtVehicleID.Location = New System.Drawing.Point(137, 89)
        Me.txtVehicleID.Name = "txtVehicleID"
        Me.txtVehicleID.Size = New System.Drawing.Size(22, 20)
        Me.txtVehicleID.TabIndex = 254
        Me.txtVehicleID.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtMaterialName)
        Me.GroupBox3.Controls.Add(Me.BtnReset)
        Me.GroupBox3.Controls.Add(Me.txtDocNo)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.dgw)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 44)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(309, 431)
        Me.GroupBox3.TabIndex = 260
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Documents"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(137, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Materail Name:"
        Me.Label13.UseWaitCursor = True
        '
        'txtMaterialName
        '
        Me.txtMaterialName.BackColor = System.Drawing.Color.White
        Me.txtMaterialName.Location = New System.Drawing.Point(129, 30)
        Me.txtMaterialName.Name = "txtMaterialName"
        Me.txtMaterialName.Size = New System.Drawing.Size(116, 20)
        Me.txtMaterialName.TabIndex = 22
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(251, 28)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(52, 23)
        Me.BtnReset.TabIndex = 21
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'txtDocNo
        '
        Me.txtDocNo.BackColor = System.Drawing.Color.White
        Me.txtDocNo.Location = New System.Drawing.Point(13, 30)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(110, 20)
        Me.txtDocNo.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Document No:"
        Me.Label8.UseWaitCursor = True
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FloralWhite
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.dgwItemsStockonHand, Me.ReorderLevel, Me.colPNO, Me.colStkinID, Me.colSchmId})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(6, 62)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(297, 363)
        Me.dgw.TabIndex = 10
        '
        'Column7
        '
        Me.Column7.HeaderText = "Doc No"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 65
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 90
        '
        'dgwItemsStockonHand
        '
        Me.dgwItemsStockonHand.HeaderText = "Qty"
        Me.dgwItemsStockonHand.Name = "dgwItemsStockonHand"
        Me.dgwItemsStockonHand.ReadOnly = True
        Me.dgwItemsStockonHand.Width = 45
        '
        'ReorderLevel
        '
        Me.ReorderLevel.HeaderText = "From"
        Me.ReorderLevel.Name = "ReorderLevel"
        Me.ReorderLevel.ReadOnly = True
        Me.ReorderLevel.Width = 75
        '
        'colPNO
        '
        Me.colPNO.HeaderText = "PNO"
        Me.colPNO.Name = "colPNO"
        Me.colPNO.ReadOnly = True
        Me.colPNO.Visible = False
        Me.colPNO.Width = 25
        '
        'colStkinID
        '
        Me.colStkinID.HeaderText = "StockInID"
        Me.colStkinID.Name = "colStkinID"
        Me.colStkinID.ReadOnly = True
        Me.colStkinID.Visible = False
        Me.colStkinID.Width = 25
        '
        'colSchmId
        '
        Me.colSchmId.HeaderText = "SchmNo"
        Me.colSchmId.Name = "colSchmId"
        Me.colSchmId.ReadOnly = True
        Me.colSchmId.Visible = False
        Me.colSchmId.Width = 25
        '
        'ChkCancelled
        '
        Me.ChkCancelled.AutoSize = True
        Me.ChkCancelled.Location = New System.Drawing.Point(522, 496)
        Me.ChkCancelled.Name = "ChkCancelled"
        Me.ChkCancelled.Size = New System.Drawing.Size(89, 17)
        Me.ChkCancelled.TabIndex = 261
        Me.ChkCancelled.Text = "CancelStatus"
        Me.ChkCancelled.UseVisualStyleBackColor = True
        Me.ChkCancelled.Visible = False
        '
        'txtCacelledby
        '
        Me.txtCacelledby.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCacelledby.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCacelledby.Enabled = False
        Me.txtCacelledby.Location = New System.Drawing.Point(617, 494)
        Me.txtCacelledby.Name = "txtCacelledby"
        Me.txtCacelledby.Size = New System.Drawing.Size(10, 20)
        Me.txtCacelledby.TabIndex = 262
        Me.txtCacelledby.Visible = False
        '
        'txtTotStock
        '
        Me.txtTotStock.Enabled = False
        Me.txtTotStock.Location = New System.Drawing.Point(308, 52)
        Me.txtTotStock.Name = "txtTotStock"
        Me.txtTotStock.Size = New System.Drawing.Size(96, 20)
        Me.txtTotStock.TabIndex = 262
        '
        'FrmPointofSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1084, 519)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtApprovedby)
        Me.Controls.Add(Me.chkApproved)
        Me.Controls.Add(Me.dgwIssueItems)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LBLZeroValue)
        Me.Controls.Add(Me.Mnstrp_ShortCutMenu)
        Me.Controls.Add(Me.txtCacelledby)
        Me.Controls.Add(Me.ChkCancelled)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmPointofSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Mnstrp_ShortCutMenu.ResumeLayout(False)
        Me.Mnstrp_ShortCutMenu.PerformLayout()
        CType(Me.dgwIssueItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Mnstrp_ShortCutMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents VoidToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TENDEREDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ESCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POS2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuickItemEditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecallTransactionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtItemcount As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblScheme As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LblDeliveryNo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgwIssueItems As DataGridView
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdSearchItems As ComboBox
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents LBLZeroValue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQtytoIssue As TextBox
    Friend WithEvents btnAddtoGrid As Button
    Friend WithEvents txtUoM As TextBox
    Friend WithEvents txtRemQty As TextBox
    Friend WithEvents txtUnitofIssue As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSchemeRefNo As TextBox
    Friend WithEvents CboSchemeName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkApproved As CheckBox
    Friend WithEvents txtApprovedby As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents PSaveToolStripButton As ToolStripButton
    Friend WithEvents LookupToolStripButton3 As ToolStripButton
    Friend WithEvents VoidToolStripButton4 As ToolStripButton
    Friend WithEvents ClearToolStripButton As ToolStripButton
    Friend WithEvents txtDeliveryNote As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtInStock As TextBox
    Friend WithEvents txtSchemeRefNoFrom As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboDocumentNo As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgw As DataGridView
    Friend WithEvents txtDocNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnReset As Button
    Friend WithEvents txtStockinDetailID As TextBox
    Friend WithEvents dgwIssueMaterialsItemNo As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsItemName As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsQty As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsQtyBal As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsUnitofIssue As DataGridViewTextBoxColumn
    Friend WithEvents colDocu As DataGridViewTextBoxColumn
    Friend WithEvents colSchemeRef As DataGridViewTextBoxColumn
    Friend WithEvents colDeliveryNo As DataGridViewTextBoxColumn
    Friend WithEvents colStockInDetailID As DataGridViewTextBoxColumn
    Friend WithEvents txtSchmeID As TextBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dgwItemsStockonHand As DataGridViewTextBoxColumn
    Friend WithEvents ReorderLevel As DataGridViewTextBoxColumn
    Friend WithEvents colPNO As DataGridViewTextBoxColumn
    Friend WithEvents colStkinID As DataGridViewTextBoxColumn
    Friend WithEvents colSchmId As DataGridViewTextBoxColumn
    Friend WithEvents ChkCancelled As CheckBox
    Friend WithEvents txtCacelledby As TextBox
    Friend WithEvents lbldate As DateTimePicker
    Friend WithEvents txtMaterialName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboVehicleNo As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtVehicleID As TextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtTotStock As TextBox
End Class
