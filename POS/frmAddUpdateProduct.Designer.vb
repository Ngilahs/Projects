<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddUpdateProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddUpdateProduct))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtyperUoM = New System.Windows.Forms.TextBox()
        Me.txtPreSupplier = New System.Windows.Forms.TextBox()
        Me.BtnLoadSupplier = New System.Windows.Forms.Button()
        Me.txtUnitofIssue = New System.Windows.Forms.TextBox()
        Me.lblMinimumStock = New System.Windows.Forms.Label()
        Me.lblMaximumStock = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Btnsubcategory = New System.Windows.Forms.Button()
        Me.txtsubcategory = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtStocksOnHand = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReorderLevel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPrefSupplierID = New System.Windows.Forms.Label()
        Me.LBLSubCateID = New System.Windows.Forms.Label()
        Me.LBLCateID = New System.Windows.Forms.Label()
        Me.lblProductNo = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PSaveToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.PUpdateToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQtyperUoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwItemsStockonHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReorderLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwitemCateID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwItemSubCatID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSuppID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.txtpdes = New System.Windows.Forms.TextBox()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUnits)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtQtyperUoM)
        Me.GroupBox1.Controls.Add(Me.txtPreSupplier)
        Me.GroupBox1.Controls.Add(Me.BtnLoadSupplier)
        Me.GroupBox1.Controls.Add(Me.txtUnitofIssue)
        Me.GroupBox1.Controls.Add(Me.lblMinimumStock)
        Me.GroupBox1.Controls.Add(Me.lblMaximumStock)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtqty)
        Me.GroupBox1.Controls.Add(Me.Btnsubcategory)
        Me.GroupBox1.Controls.Add(Me.txtsubcategory)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtStocksOnHand)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtReorderLevel)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblPrefSupplierID)
        Me.GroupBox1.Controls.Add(Me.LBLSubCateID)
        Me.GroupBox1.Controls.Add(Me.LBLCateID)
        Me.GroupBox1.Controls.Add(Me.lblProductNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(969, 110)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Material Details"
        '
        'txtUnits
        '
        Me.txtUnits.BackColor = System.Drawing.Color.White
        Me.txtUnits.Enabled = False
        Me.txtUnits.Location = New System.Drawing.Point(804, 75)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.ReadOnly = True
        Me.txtUnits.Size = New System.Drawing.Size(157, 23)
        Me.txtUnits.TabIndex = 488
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(727, 81)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 487
        Me.Label6.Text = "Units:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(727, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 486
        Me.Label4.Text = "Qty/UoM:"
        '
        'txtQtyperUoM
        '
        Me.txtQtyperUoM.BackColor = System.Drawing.Color.White
        Me.txtQtyperUoM.Location = New System.Drawing.Point(804, 46)
        Me.txtQtyperUoM.Name = "txtQtyperUoM"
        Me.txtQtyperUoM.Size = New System.Drawing.Size(157, 23)
        Me.txtQtyperUoM.TabIndex = 485
        '
        'txtPreSupplier
        '
        Me.txtPreSupplier.Location = New System.Drawing.Point(520, 48)
        Me.txtPreSupplier.Name = "txtPreSupplier"
        Me.txtPreSupplier.Size = New System.Drawing.Size(144, 23)
        Me.txtPreSupplier.TabIndex = 482
        '
        'BtnLoadSupplier
        '
        Me.BtnLoadSupplier.BackColor = System.Drawing.Color.DarkGray
        Me.BtnLoadSupplier.BackgroundImage = CType(resources.GetObject("BtnLoadSupplier.BackgroundImage"), System.Drawing.Image)
        Me.BtnLoadSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnLoadSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLoadSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLoadSupplier.Location = New System.Drawing.Point(670, 53)
        Me.BtnLoadSupplier.Name = "BtnLoadSupplier"
        Me.BtnLoadSupplier.Size = New System.Drawing.Size(22, 17)
        Me.BtnLoadSupplier.TabIndex = 479
        Me.BtnLoadSupplier.UseVisualStyleBackColor = False
        '
        'txtUnitofIssue
        '
        Me.txtUnitofIssue.Location = New System.Drawing.Point(804, 19)
        Me.txtUnitofIssue.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.txtUnitofIssue.MaxLength = 13
        Me.txtUnitofIssue.Name = "txtUnitofIssue"
        Me.txtUnitofIssue.Size = New System.Drawing.Size(157, 23)
        Me.txtUnitofIssue.TabIndex = 466
        '
        'lblMinimumStock
        '
        Me.lblMinimumStock.AutoSize = True
        Me.lblMinimumStock.BackColor = System.Drawing.Color.Transparent
        Me.lblMinimumStock.ForeColor = System.Drawing.Color.Black
        Me.lblMinimumStock.Location = New System.Drawing.Point(727, 21)
        Me.lblMinimumStock.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.lblMinimumStock.Name = "lblMinimumStock"
        Me.lblMinimumStock.Size = New System.Drawing.Size(36, 15)
        Me.lblMinimumStock.TabIndex = 478
        Me.lblMinimumStock.Text = "UoM:"
        '
        'lblMaximumStock
        '
        Me.lblMaximumStock.AutoSize = True
        Me.lblMaximumStock.BackColor = System.Drawing.Color.Transparent
        Me.lblMaximumStock.ForeColor = System.Drawing.Color.Black
        Me.lblMaximumStock.Location = New System.Drawing.Point(430, 52)
        Me.lblMaximumStock.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.lblMaximumStock.Name = "lblMaximumStock"
        Me.lblMaximumStock.Size = New System.Drawing.Size(79, 15)
        Me.lblMaximumStock.TabIndex = 473
        Me.lblMaximumStock.Text = "Pref-Supplier:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(430, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Stock:"
        '
        'txtqty
        '
        Me.txtqty.BackColor = System.Drawing.Color.White
        Me.txtqty.Enabled = False
        Me.txtqty.Location = New System.Drawing.Point(520, 77)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(144, 23)
        Me.txtqty.TabIndex = 14
        '
        'Btnsubcategory
        '
        Me.Btnsubcategory.BackColor = System.Drawing.Color.DarkGray
        Me.Btnsubcategory.BackgroundImage = CType(resources.GetObject("Btnsubcategory.BackgroundImage"), System.Drawing.Image)
        Me.Btnsubcategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btnsubcategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnsubcategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnsubcategory.Location = New System.Drawing.Point(327, 79)
        Me.Btnsubcategory.Name = "Btnsubcategory"
        Me.Btnsubcategory.Size = New System.Drawing.Size(22, 17)
        Me.Btnsubcategory.TabIndex = 22
        Me.Btnsubcategory.UseVisualStyleBackColor = False
        '
        'txtsubcategory
        '
        Me.txtsubcategory.BackColor = System.Drawing.Color.White
        Me.txtsubcategory.Location = New System.Drawing.Point(121, 77)
        Me.txtsubcategory.Name = "txtsubcategory"
        Me.txtsubcategory.Size = New System.Drawing.Size(200, 23)
        Me.txtsubcategory.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 15)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Subcategory :"
        '
        'txtStocksOnHand
        '
        Me.txtStocksOnHand.AutoSize = True
        Me.txtStocksOnHand.Location = New System.Drawing.Point(449, 130)
        Me.txtStocksOnHand.Name = "txtStocksOnHand"
        Me.txtStocksOnHand.Size = New System.Drawing.Size(0, 15)
        Me.txtStocksOnHand.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGray
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(327, 52)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 17)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(121, 20)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(200, 23)
        Me.txtDescription.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Item Name :"
        '
        'txtReorderLevel
        '
        Me.txtReorderLevel.BackColor = System.Drawing.Color.White
        Me.txtReorderLevel.Location = New System.Drawing.Point(520, 20)
        Me.txtReorderLevel.Name = "txtReorderLevel"
        Me.txtReorderLevel.Size = New System.Drawing.Size(144, 23)
        Me.txtReorderLevel.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(430, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Reorder Level :"
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.White
        Me.txtCategory.Location = New System.Drawing.Point(121, 48)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(200, 23)
        Me.txtCategory.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Category :"
        '
        'lblPrefSupplierID
        '
        Me.lblPrefSupplierID.AutoSize = True
        Me.lblPrefSupplierID.Location = New System.Drawing.Point(670, 52)
        Me.lblPrefSupplierID.Name = "lblPrefSupplierID"
        Me.lblPrefSupplierID.Size = New System.Drawing.Size(21, 15)
        Me.lblPrefSupplierID.TabIndex = 480
        Me.lblPrefSupplierID.Text = "##"
        Me.lblPrefSupplierID.Visible = False
        '
        'LBLSubCateID
        '
        Me.LBLSubCateID.AutoSize = True
        Me.LBLSubCateID.Location = New System.Drawing.Point(327, 81)
        Me.LBLSubCateID.Name = "LBLSubCateID"
        Me.LBLSubCateID.Size = New System.Drawing.Size(21, 15)
        Me.LBLSubCateID.TabIndex = 24
        Me.LBLSubCateID.Text = "##"
        Me.LBLSubCateID.Visible = False
        '
        'LBLCateID
        '
        Me.LBLCateID.AutoSize = True
        Me.LBLCateID.Location = New System.Drawing.Point(324, 54)
        Me.LBLCateID.Name = "LBLCateID"
        Me.LBLCateID.Size = New System.Drawing.Size(21, 15)
        Me.LBLCateID.TabIndex = 23
        Me.LBLCateID.Text = "##"
        Me.LBLCateID.Visible = False
        '
        'lblProductNo
        '
        Me.lblProductNo.BackColor = System.Drawing.Color.White
        Me.lblProductNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProductNo.Location = New System.Drawing.Point(270, 20)
        Me.lblProductNo.Name = "lblProductNo"
        Me.lblProductNo.Size = New System.Drawing.Size(51, 22)
        Me.lblProductNo.TabIndex = 2
        Me.lblProductNo.Text = " "
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.PSaveToolStripButton5, Me.PUpdateToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(360, 455)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(281, 41)
        Me.ToolStrip1.TabIndex = 30
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 38)
        Me.ToolStripLabel1.Text = "   "
        '
        'PSaveToolStripButton5
        '
        Me.PSaveToolStripButton5.Image = CType(resources.GetObject("PSaveToolStripButton5.Image"), System.Drawing.Image)
        Me.PSaveToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PSaveToolStripButton5.Name = "PSaveToolStripButton5"
        Me.PSaveToolStripButton5.Size = New System.Drawing.Size(51, 38)
        Me.PSaveToolStripButton5.Text = "Save"
        '
        'PUpdateToolStripButton3
        '
        Me.PUpdateToolStripButton3.AutoSize = False
        Me.PUpdateToolStripButton3.Image = CType(resources.GetObject("PUpdateToolStripButton3.Image"), System.Drawing.Image)
        Me.PUpdateToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PUpdateToolStripButton3.Name = "PUpdateToolStripButton3"
        Me.PUpdateToolStripButton3.Size = New System.Drawing.Size(65, 40)
        Me.PUpdateToolStripButton3.Text = "&Update"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(65, 50)
        Me.ToolStripButton4.Text = "&New Item"
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
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.colQtyperUoM, Me.colUnits, Me.dgwItemsStockonHand, Me.ReorderLevel, Me.dgwitemCateID, Me.Column3, Me.dgwItemSubCatID, Me.Column2, Me.Column4, Me.colSuppID, Me.Column9})
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
        Me.dgw.Location = New System.Drawing.Point(2, 195)
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
        Me.dgw.Size = New System.Drawing.Size(969, 257)
        Me.dgw.TabIndex = 9
        '
        'Column7
        '
        Me.Column7.HeaderText = "Item No"
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
        'colQtyperUoM
        '
        Me.colQtyperUoM.HeaderText = "Qty/UoM"
        Me.colQtyperUoM.Name = "colQtyperUoM"
        Me.colQtyperUoM.ReadOnly = True
        '
        'colUnits
        '
        Me.colUnits.HeaderText = "Units"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.ReadOnly = True
        '
        'dgwItemsStockonHand
        '
        Me.dgwItemsStockonHand.HeaderText = "Stock on Hand"
        Me.dgwItemsStockonHand.Name = "dgwItemsStockonHand"
        Me.dgwItemsStockonHand.ReadOnly = True
        '
        'ReorderLevel
        '
        Me.ReorderLevel.HeaderText = "R. Level"
        Me.ReorderLevel.Name = "ReorderLevel"
        Me.ReorderLevel.ReadOnly = True
        Me.ReorderLevel.Width = 75
        '
        'dgwitemCateID
        '
        Me.dgwitemCateID.HeaderText = "Cat ID"
        Me.dgwitemCateID.Name = "dgwitemCateID"
        Me.dgwitemCateID.ReadOnly = True
        Me.dgwitemCateID.Visible = False
        Me.dgwitemCateID.Width = 25
        '
        'Column3
        '
        Me.Column3.HeaderText = "Category"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 75
        '
        'dgwItemSubCatID
        '
        Me.dgwItemSubCatID.HeaderText = "Sub CatID"
        Me.dgwItemSubCatID.Name = "dgwItemSubCatID"
        Me.dgwItemSubCatID.ReadOnly = True
        Me.dgwItemSubCatID.Visible = False
        Me.dgwItemSubCatID.Width = 25
        '
        'Column2
        '
        Me.Column2.HeaderText = "Sub Category"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 95
        '
        'Column4
        '
        Me.Column4.HeaderText = "Unit of Issue"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 75
        '
        'colSuppID
        '
        Me.colSuppID.HeaderText = "SuppID"
        Me.colSuppID.Name = "colSuppID"
        Me.colSuppID.ReadOnly = True
        Me.colSuppID.Visible = False
        Me.colSuppID.Width = 50
        '
        'Column9
        '
        Me.Column9.HeaderText = "Preferred Supplier"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Item Name :"
        Me.Label7.UseWaitCursor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnReset)
        Me.GroupBox4.Controls.Add(Me.txtpdes)
        Me.GroupBox4.Controls.Add(Me.txtItemNo)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(2, 149)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(969, 40)
        Me.GroupBox4.TabIndex = 166
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search Items"
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(909, 14)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(52, 23)
        Me.BtnReset.TabIndex = 20
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'txtpdes
        '
        Me.txtpdes.BackColor = System.Drawing.Color.White
        Me.txtpdes.Location = New System.Drawing.Point(76, 16)
        Me.txtpdes.Name = "txtpdes"
        Me.txtpdes.Size = New System.Drawing.Size(343, 20)
        Me.txtpdes.TabIndex = 18
        '
        'txtItemNo
        '
        Me.txtItemNo.BackColor = System.Drawing.Color.White
        Me.txtItemNo.Location = New System.Drawing.Point(520, 14)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(124, 20)
        Me.txtItemNo.TabIndex = 17
        Me.txtItemNo.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(969, 34)
        Me.Panel1.TabIndex = 174
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(414, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Create Materials"
        '
        'frmAddUpdateProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(975, 505)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmAddUpdateProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                       "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblProductNo As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReorderLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStocksOnHand As System.Windows.Forms.Label
    Friend WithEvents cmbVAT As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PUpdateToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PSaveToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents txtpdes As System.Windows.Forms.TextBox
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtsubcategory As System.Windows.Forms.TextBox
    Friend WithEvents Btnsubcategory As System.Windows.Forms.Button
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LBLSubCateID As System.Windows.Forms.Label
    Friend WithEvents LBLCateID As System.Windows.Forms.Label
    Private WithEvents txtUnitofIssue As TextBox
    Private WithEvents lblMinimumStock As Label
    Private WithEvents lblMaximumStock As Label
    Friend WithEvents lblPrefSupplierID As Label
    Friend WithEvents BtnLoadSupplier As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPreSupplier As TextBox
    Friend WithEvents txtUnits As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents Label4 As Label
    Friend WithEvents txtQtyperUoM As TextBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colQtyperUoM As DataGridViewTextBoxColumn
    Friend WithEvents colUnits As DataGridViewTextBoxColumn
    Friend WithEvents dgwItemsStockonHand As DataGridViewTextBoxColumn
    Friend WithEvents ReorderLevel As DataGridViewTextBoxColumn
    Friend WithEvents dgwitemCateID As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents dgwItemSubCatID As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents colSuppID As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
