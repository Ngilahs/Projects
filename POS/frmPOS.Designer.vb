<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dtgCartItems = New System.Windows.Forms.DataGridView()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwReceiptSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchemeNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mnstrp_ShortCutMenu = New System.Windows.Forms.MenuStrip()
        Me.VoidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TENDEREDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POS2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickItemPurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickItemEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoldStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtUnclearedPurchaseID = New System.Windows.Forms.TextBox()
        Me.txtSupplierID = New System.Windows.Forms.TextBox()
        Me.txtStockinIDRS = New System.Windows.Forms.TextBox()
        Me.btnsupplierRS = New System.Windows.Forms.Button()
        Me.txtSupplNameRS = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblUnclearedID = New System.Windows.Forms.Label()
        Me.BtnClearReset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.cboSearchItem = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtreceivedQty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStckonHand = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddtoGrid = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDocumentNo = New System.Windows.Forms.TextBox()
        Me.lbldateRS = New System.Windows.Forms.DateTimePicker()
        Me.txtDeliveryNote = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSchemeRef = New System.Windows.Forms.TextBox()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSchemeName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalQty = New System.Windows.Forms.TextBox()
        Me.txtSchmID = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.PSaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ClearToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtMaterialtoReceive = New System.Windows.Forms.TextBox()
        CType(Me.dtgCartItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Mnstrp_ShortCutMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(3, -1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(947, 36)
        Me.TextBox1.TabIndex = 166
        '
        'dtgCartItems
        '
        Me.dtgCartItems.AllowUserToAddRows = False
        Me.dtgCartItems.AllowUserToDeleteRows = False
        Me.dtgCartItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgCartItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCartItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column7, Me.Column9, Me.Column4, Me.Column5, Me.dgwReceiptSupplier, Me.DocumentNo, Me.SchemeNo})
        Me.dtgCartItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgCartItems.GridColor = System.Drawing.Color.DarkOrange
        Me.dtgCartItems.Location = New System.Drawing.Point(5, 113)
        Me.dtgCartItems.MultiSelect = False
        Me.dtgCartItems.Name = "dtgCartItems"
        Me.dtgCartItems.ReadOnly = True
        Me.dtgCartItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCartItems.Size = New System.Drawing.Size(928, 283)
        Me.dtgCartItems.TabIndex = 0
        '
        'Column11
        '
        Me.Column11.HeaderText = "Item No"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Item Name"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.Width = 200
        '
        'Column9
        '
        Me.Column9.HeaderText = "Quantity In"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Available Stock "
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        Me.Column4.Width = 75
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total Quantity"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'dgwReceiptSupplier
        '
        Me.dgwReceiptSupplier.HeaderText = "Supplier"
        Me.dgwReceiptSupplier.Name = "dgwReceiptSupplier"
        Me.dgwReceiptSupplier.ReadOnly = True
        Me.dgwReceiptSupplier.Width = 180
        '
        'DocumentNo
        '
        Me.DocumentNo.HeaderText = "Delivery No"
        Me.DocumentNo.Name = "DocumentNo"
        Me.DocumentNo.ReadOnly = True
        Me.DocumentNo.Width = 150
        '
        'SchemeNo
        '
        Me.SchemeNo.HeaderText = "Scheme No"
        Me.SchemeNo.Name = "SchemeNo"
        Me.SchemeNo.ReadOnly = True
        Me.SchemeNo.Visible = False
        '
        'Mnstrp_ShortCutMenu
        '
        Me.Mnstrp_ShortCutMenu.AutoSize = False
        Me.Mnstrp_ShortCutMenu.BackColor = System.Drawing.Color.Transparent
        Me.Mnstrp_ShortCutMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.Mnstrp_ShortCutMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoidToolStripMenuItem, Me.TToolStripMenuItem, Me.PrintSaveToolStripMenuItem, Me.ScrToolStripMenuItem, Me.TENDEREDToolStripMenuItem, Me.ESCToolStripMenuItem, Me.POS2ToolStripMenuItem, Me.QuickItemPurchaseToolStripMenuItem, Me.QuickItemEditToolStripMenuItem, Me.HoldStockToolStripMenuItem})
        Me.Mnstrp_ShortCutMenu.Location = New System.Drawing.Point(713, 441)
        Me.Mnstrp_ShortCutMenu.Name = "Mnstrp_ShortCutMenu"
        Me.Mnstrp_ShortCutMenu.Size = New System.Drawing.Size(28, 29)
        Me.Mnstrp_ShortCutMenu.TabIndex = 181
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
        Me.ScrToolStripMenuItem.Size = New System.Drawing.Size(101, 25)
        Me.ScrToolStripMenuItem.Text = "ScrollGridview"
        '
        'TENDEREDToolStripMenuItem
        '
        Me.TENDEREDToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TENDEREDToolStripMenuItem.Name = "TENDEREDToolStripMenuItem"
        Me.TENDEREDToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.TENDEREDToolStripMenuItem.Size = New System.Drawing.Size(79, 25)
        Me.TENDEREDToolStripMenuItem.Text = "TENDERED"
        '
        'ESCToolStripMenuItem
        '
        Me.ESCToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ESCToolStripMenuItem.Name = "ESCToolStripMenuItem"
        Me.ESCToolStripMenuItem.Size = New System.Drawing.Size(39, 25)
        Me.ESCToolStripMenuItem.Text = "ESC"
        '
        'POS2ToolStripMenuItem
        '
        Me.POS2ToolStripMenuItem.Name = "POS2ToolStripMenuItem"
        Me.POS2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.POS2ToolStripMenuItem.Size = New System.Drawing.Size(47, 25)
        Me.POS2ToolStripMenuItem.Text = "POS2"
        '
        'QuickItemPurchaseToolStripMenuItem
        '
        Me.QuickItemPurchaseToolStripMenuItem.Name = "QuickItemPurchaseToolStripMenuItem"
        Me.QuickItemPurchaseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.QuickItemPurchaseToolStripMenuItem.Size = New System.Drawing.Size(126, 25)
        Me.QuickItemPurchaseToolStripMenuItem.Text = "ToolStripMenuItem7"
        '
        'QuickItemEditToolStripMenuItem
        '
        Me.QuickItemEditToolStripMenuItem.Name = "QuickItemEditToolStripMenuItem"
        Me.QuickItemEditToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.QuickItemEditToolStripMenuItem.Size = New System.Drawing.Size(195, 25)
        Me.QuickItemEditToolStripMenuItem.Text = "QuickItemeditToolStripMenuItem"
        '
        'HoldStockToolStripMenuItem
        '
        Me.HoldStockToolStripMenuItem.Name = "HoldStockToolStripMenuItem"
        Me.HoldStockToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HoldStockToolStripMenuItem.Size = New System.Drawing.Size(126, 25)
        Me.HoldStockToolStripMenuItem.Text = "ToolStripMenuItem7"
        '
        'txtUnclearedPurchaseID
        '
        Me.txtUnclearedPurchaseID.Enabled = False
        Me.txtUnclearedPurchaseID.Location = New System.Drawing.Point(843, 616)
        Me.txtUnclearedPurchaseID.Name = "txtUnclearedPurchaseID"
        Me.txtUnclearedPurchaseID.Size = New System.Drawing.Size(50, 20)
        Me.txtUnclearedPurchaseID.TabIndex = 205
        '
        'txtSupplierID
        '
        Me.txtSupplierID.Enabled = False
        Me.txtSupplierID.Location = New System.Drawing.Point(588, 18)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.Size = New System.Drawing.Size(14, 20)
        Me.txtSupplierID.TabIndex = 175
        Me.txtSupplierID.Visible = False
        '
        'txtStockinIDRS
        '
        Me.txtStockinIDRS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStockinIDRS.Enabled = False
        Me.txtStockinIDRS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockinIDRS.Location = New System.Drawing.Point(776, 15)
        Me.txtStockinIDRS.MaxLength = 50
        Me.txtStockinIDRS.Name = "txtStockinIDRS"
        Me.txtStockinIDRS.Size = New System.Drawing.Size(95, 22)
        Me.txtStockinIDRS.TabIndex = 174
        '
        'btnsupplierRS
        '
        Me.btnsupplierRS.BackColor = System.Drawing.Color.DarkGray
        Me.btnsupplierRS.BackgroundImage = CType(resources.GetObject("btnsupplierRS.BackgroundImage"), System.Drawing.Image)
        Me.btnsupplierRS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnsupplierRS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsupplierRS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsupplierRS.Location = New System.Drawing.Point(684, 19)
        Me.btnsupplierRS.Name = "btnsupplierRS"
        Me.btnsupplierRS.Size = New System.Drawing.Size(22, 17)
        Me.btnsupplierRS.TabIndex = 10
        Me.btnsupplierRS.UseVisualStyleBackColor = False
        '
        'txtSupplNameRS
        '
        Me.txtSupplNameRS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSupplNameRS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSupplNameRS.Enabled = False
        Me.txtSupplNameRS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplNameRS.Location = New System.Drawing.Point(577, 16)
        Me.txtSupplNameRS.Name = "txtSupplNameRS"
        Me.txtSupplNameRS.Size = New System.Drawing.Size(101, 22)
        Me.txtSupplNameRS.TabIndex = 180
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(492, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Supplier Name:"
        '
        'lblUnclearedID
        '
        Me.lblUnclearedID.AutoSize = True
        Me.lblUnclearedID.Location = New System.Drawing.Point(12, 436)
        Me.lblUnclearedID.Name = "lblUnclearedID"
        Me.lblUnclearedID.Size = New System.Drawing.Size(0, 13)
        Me.lblUnclearedID.TabIndex = 204
        '
        'BtnClearReset
        '
        Me.BtnClearReset.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnClearReset.ForeColor = System.Drawing.Color.Black
        Me.BtnClearReset.Location = New System.Drawing.Point(899, 612)
        Me.BtnClearReset.Name = "BtnClearReset"
        Me.BtnClearReset.Size = New System.Drawing.Size(75, 27)
        Me.BtnClearReset.TabIndex = 212
        Me.BtnClearReset.Text = "Reset/Clear"
        Me.BtnClearReset.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 217
        Me.Label2.Text = "Item Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 216
        Me.Label6.Text = "Item No:"
        '
        'txtItemNo
        '
        Me.txtItemNo.BackColor = System.Drawing.Color.White
        Me.txtItemNo.Enabled = False
        Me.txtItemNo.Location = New System.Drawing.Point(356, 18)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(130, 20)
        Me.txtItemNo.TabIndex = 218
        '
        'cboSearchItem
        '
        Me.cboSearchItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSearchItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSearchItem.FormattingEnabled = True
        Me.cboSearchItem.Location = New System.Drawing.Point(70, 15)
        Me.cboSearchItem.Name = "cboSearchItem"
        Me.cboSearchItem.Size = New System.Drawing.Size(197, 21)
        Me.cboSearchItem.TabIndex = 219
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(403, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 20)
        Me.Label7.TabIndex = 220
        Me.Label7.Text = "Receive Materials"
        '
        'txtreceivedQty
        '
        Me.txtreceivedQty.BackColor = System.Drawing.Color.White
        Me.txtreceivedQty.Location = New System.Drawing.Point(70, 45)
        Me.txtreceivedQty.Name = "txtreceivedQty"
        Me.txtreceivedQty.Size = New System.Drawing.Size(197, 20)
        Me.txtreceivedQty.TabIndex = 222
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 221
        Me.Label8.Text = "Quantity:"
        '
        'txtStckonHand
        '
        Me.txtStckonHand.BackColor = System.Drawing.Color.White
        Me.txtStckonHand.Enabled = False
        Me.txtStckonHand.Location = New System.Drawing.Point(577, 47)
        Me.txtStckonHand.Name = "txtStckonHand"
        Me.txtStckonHand.ReadOnly = True
        Me.txtStckonHand.Size = New System.Drawing.Size(123, 20)
        Me.txtStckonHand.TabIndex = 224
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(492, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 223
        Me.Label1.Text = " StockonHand:"
        '
        'btnAddtoGrid
        '
        Me.btnAddtoGrid.BackColor = System.Drawing.Color.Cyan
        Me.btnAddtoGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoGrid.Location = New System.Drawing.Point(877, 14)
        Me.btnAddtoGrid.Name = "btnAddtoGrid"
        Me.btnAddtoGrid.Size = New System.Drawing.Size(45, 79)
        Me.btnAddtoGrid.TabIndex = 225
        Me.btnAddtoGrid.Text = "Add "
        Me.btnAddtoGrid.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDocumentNo)
        Me.GroupBox1.Controls.Add(Me.lbldateRS)
        Me.GroupBox1.Controls.Add(Me.txtDeliveryNote)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtSchemeRef)
        Me.GroupBox1.Controls.Add(Me.txtSchemeID)
        Me.GroupBox1.Controls.Add(Me.txtConstituencyID)
        Me.GroupBox1.Controls.Add(Me.txtCountyID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboSchemeName)
        Me.GroupBox1.Controls.Add(Me.btnsupplierRS)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtSupplNameRS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtStockinIDRS)
        Me.GroupBox1.Controls.Add(Me.txtTotalQty)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnAddtoGrid)
        Me.GroupBox1.Controls.Add(Me.txtStckonHand)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtreceivedQty)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboSearchItem)
        Me.GroupBox1.Controls.Add(Me.txtItemNo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSupplierID)
        Me.GroupBox1.Controls.Add(Me.txtSchmID)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(928, 101)
        Me.GroupBox1.TabIndex = 226
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items Received"
        '
        'txtDocumentNo
        '
        Me.txtDocumentNo.BackColor = System.Drawing.Color.White
        Me.txtDocumentNo.Location = New System.Drawing.Point(577, 70)
        Me.txtDocumentNo.Name = "txtDocumentNo"
        Me.txtDocumentNo.Size = New System.Drawing.Size(123, 20)
        Me.txtDocumentNo.TabIndex = 234
        '
        'lbldateRS
        '
        Me.lbldateRS.CustomFormat = "dd/MM/yyyy"
        Me.lbldateRS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.lbldateRS.Location = New System.Drawing.Point(776, 44)
        Me.lbldateRS.Name = "lbldateRS"
        Me.lbldateRS.Size = New System.Drawing.Size(95, 20)
        Me.lbldateRS.TabIndex = 250
        '
        'txtDeliveryNote
        '
        Me.txtDeliveryNote.BackColor = System.Drawing.Color.White
        Me.txtDeliveryNote.Location = New System.Drawing.Point(633, 70)
        Me.txtDeliveryNote.Name = "txtDeliveryNote"
        Me.txtDeliveryNote.Size = New System.Drawing.Size(10, 20)
        Me.txtDeliveryNote.TabIndex = 232
        Me.txtDeliveryNote.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(297, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 248
        Me.Label12.Text = "Schm Ref:"
        '
        'txtSchemeRef
        '
        Me.txtSchemeRef.Enabled = False
        Me.txtSchemeRef.Location = New System.Drawing.Point(356, 71)
        Me.txtSchemeRef.Name = "txtSchemeRef"
        Me.txtSchemeRef.Size = New System.Drawing.Size(130, 20)
        Me.txtSchemeRef.TabIndex = 247
        '
        'txtSchemeID
        '
        Me.txtSchemeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeID.Enabled = False
        Me.txtSchemeID.Location = New System.Drawing.Point(665, 70)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(13, 20)
        Me.txtSchemeID.TabIndex = 244
        Me.txtSchemeID.Visible = False
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyID.Enabled = False
        Me.txtConstituencyID.Location = New System.Drawing.Point(684, 70)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(10, 20)
        Me.txtConstituencyID.TabIndex = 246
        Me.txtConstituencyID.Visible = False
        '
        'txtCountyID
        '
        Me.txtCountyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCountyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCountyID.Enabled = False
        Me.txtCountyID.Location = New System.Drawing.Point(646, 70)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(13, 20)
        Me.txtCountyID.TabIndex = 245
        Me.txtCountyID.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(492, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 231
        Me.Label10.Text = "Delivery No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 229
        Me.Label3.Text = "Scheme :"
        '
        'cboSchemeName
        '
        Me.cboSchemeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSchemeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSchemeName.FormattingEnabled = True
        Me.cboSchemeName.Location = New System.Drawing.Point(70, 70)
        Me.cboSchemeName.Name = "cboSchemeName"
        Me.cboSchemeName.Size = New System.Drawing.Size(197, 21)
        Me.cboSchemeName.TabIndex = 230
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(706, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 227
        Me.Label4.Text = "Receipt No:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(297, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 227
        Me.Label9.Text = "Total Qty:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(706, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 228
        Me.Label5.Text = "Date Rcvd:"
        '
        'txtTotalQty
        '
        Me.txtTotalQty.BackColor = System.Drawing.Color.White
        Me.txtTotalQty.Enabled = False
        Me.txtTotalQty.Location = New System.Drawing.Point(356, 47)
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.Size = New System.Drawing.Size(130, 20)
        Me.txtTotalQty.TabIndex = 226
        '
        'txtSchmID
        '
        Me.txtSchmID.Enabled = False
        Me.txtSchmID.Location = New System.Drawing.Point(159, 71)
        Me.txtSchmID.Name = "txtSchmID"
        Me.txtSchmID.Size = New System.Drawing.Size(35, 20)
        Me.txtSchmID.TabIndex = 249
        Me.txtSchmID.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(3, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(947, 474)
        Me.TabControl1.TabIndex = 229
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.dtgCartItems)
        Me.TabPage1.Controls.Add(Me.txtMaterialtoReceive)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(939, 448)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Receive Materials"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.PSaveToolStripButton, Me.ClearToolStripButton, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(370, 399)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(220, 46)
        Me.ToolStrip1.TabIndex = 250
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(16, 43)
        Me.ToolStripLabel2.Text = "   "
        '
        'PSaveToolStripButton
        '
        Me.PSaveToolStripButton.Image = CType(resources.GetObject("PSaveToolStripButton.Image"), System.Drawing.Image)
        Me.PSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PSaveToolStripButton.Name = "PSaveToolStripButton"
        Me.PSaveToolStripButton.Size = New System.Drawing.Size(51, 43)
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(36, 43)
        Me.ToolStripLabel1.Text = "Close"
        '
        'txtMaterialtoReceive
        '
        Me.txtMaterialtoReceive.BackColor = System.Drawing.Color.White
        Me.txtMaterialtoReceive.Location = New System.Drawing.Point(753, 220)
        Me.txtMaterialtoReceive.Name = "txtMaterialtoReceive"
        Me.txtMaterialtoReceive.Size = New System.Drawing.Size(72, 20)
        Me.txtMaterialtoReceive.TabIndex = 251
        Me.txtMaterialtoReceive.Visible = False
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnClearReset)
        Me.Controls.Add(Me.txtUnclearedPurchaseID)
        Me.Controls.Add(Me.lblUnclearedID)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Mnstrp_ShortCutMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtgCartItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Mnstrp_ShortCutMenu.ResumeLayout(False)
        Me.Mnstrp_ShortCutMenu.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dtgCartItems As System.Windows.Forms.DataGridView
    Friend WithEvents Mnstrp_ShortCutMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents VoidToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TENDEREDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ESCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POS2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnsupplierRS As System.Windows.Forms.Button
    Friend WithEvents txtSupplNameRS As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtStockinIDRS As System.Windows.Forms.TextBox
    Friend WithEvents QuickItemPurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuickItemEditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HoldStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUnclearedID As System.Windows.Forms.Label
    Friend WithEvents txtUnclearedPurchaseID As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierID As System.Windows.Forms.TextBox
    Friend WithEvents BtnClearReset As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtItemNo As TextBox
    Friend WithEvents cboSearchItem As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtreceivedQty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStckonHand As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddtoGrid As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTotalQty As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label9 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtDocumentNo As TextBox
    Friend WithEvents txtDeliveryNote As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboSchemeName As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSchemeRef As TextBox
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents txtSchmID As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents PSaveToolStripButton As ToolStripButton
    Friend WithEvents ClearToolStripButton As ToolStripButton
    Friend WithEvents lbldateRS As DateTimePicker
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txtMaterialtoReceive As TextBox
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents dgwReceiptSupplier As DataGridViewTextBoxColumn
    Friend WithEvents DocumentNo As DataGridViewTextBoxColumn
    Friend WithEvents SchemeNo As DataGridViewTextBoxColumn
End Class
