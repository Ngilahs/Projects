<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockIn
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockIn))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRemQty = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSellingPrc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPurchMdID = New System.Windows.Forms.TextBox()
        Me.txtSuupID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpurchasemode = New System.Windows.Forms.TextBox()
        Me.txtBuyingPrice = New System.Windows.Forms.TextBox()
        Me.txtProdDescrp = New System.Windows.Forms.TextBox()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.txtProdBarcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.txtMarkup = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStockinID = New System.Windows.Forms.Label()
        Me.txtdatein = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtStockonhand = New System.Windows.Forms.TextBox()
        Me.LBLProdNo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtEnterprdtBarcode = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.QCKsaveToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.QCKUpdateToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnmodeofpurchase = New System.Windows.Forms.Button()
        Me.BtnSuppName = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(826, 56)
        Me.Panel1.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(257, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(325, 47)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Quick Stocks Purchase"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRemQty)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtSellingPrc)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtPurchMdID)
        Me.GroupBox1.Controls.Add(Me.txtSuupID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtpurchasemode)
        Me.GroupBox1.Controls.Add(Me.btnmodeofpurchase)
        Me.GroupBox1.Controls.Add(Me.BtnSuppName)
        Me.GroupBox1.Controls.Add(Me.txtBuyingPrice)
        Me.GroupBox1.Controls.Add(Me.txtProdDescrp)
        Me.GroupBox1.Controls.Add(Me.txtSupplierName)
        Me.GroupBox1.Controls.Add(Me.txtProdBarcode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtVAT)
        Me.GroupBox1.Controls.Add(Me.txtMarkup)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 129)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(827, 199)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'txtRemQty
        '
        Me.txtRemQty.Enabled = False
        Me.txtRemQty.Location = New System.Drawing.Point(731, 52)
        Me.txtRemQty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRemQty.Name = "txtRemQty"
        Me.txtRemQty.Size = New System.Drawing.Size(79, 27)
        Me.txtRemQty.TabIndex = 182
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(661, 55)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 20)
        Me.Label16.TabIndex = 181
        Me.Label16.Text = "Rem Qty:"
        '
        'txtSellingPrc
        '
        Me.txtSellingPrc.Location = New System.Drawing.Point(117, 165)
        Me.txtSellingPrc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSellingPrc.Name = "txtSellingPrc"
        Me.txtSellingPrc.Size = New System.Drawing.Size(208, 27)
        Me.txtSellingPrc.TabIndex = 180
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 169)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 20)
        Me.Label14.TabIndex = 179
        Me.Label14.Text = "Selling Price:"
        '
        'txtPurchMdID
        '
        Me.txtPurchMdID.Location = New System.Drawing.Point(695, 146)
        Me.txtPurchMdID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPurchMdID.Name = "txtPurchMdID"
        Me.txtPurchMdID.Size = New System.Drawing.Size(115, 27)
        Me.txtPurchMdID.TabIndex = 178
        '
        'txtSuupID
        '
        Me.txtSuupID.Location = New System.Drawing.Point(695, 98)
        Me.txtSuupID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSuupID.Name = "txtSuupID"
        Me.txtSuupID.Size = New System.Drawing.Size(115, 27)
        Me.txtSuupID.TabIndex = 177
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(335, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mode of Purchase:"
        '
        'txtpurchasemode
        '
        Me.txtpurchasemode.Location = New System.Drawing.Point(477, 148)
        Me.txtpurchasemode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpurchasemode.Name = "txtpurchasemode"
        Me.txtpurchasemode.Size = New System.Drawing.Size(171, 27)
        Me.txtpurchasemode.TabIndex = 1
        '
        'txtBuyingPrice
        '
        Me.txtBuyingPrice.Location = New System.Drawing.Point(117, 127)
        Me.txtBuyingPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuyingPrice.Name = "txtBuyingPrice"
        Me.txtBuyingPrice.Size = New System.Drawing.Size(208, 27)
        Me.txtBuyingPrice.TabIndex = 16
        '
        'txtProdDescrp
        '
        Me.txtProdDescrp.Location = New System.Drawing.Point(117, 52)
        Me.txtProdDescrp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProdDescrp.Name = "txtProdDescrp"
        Me.txtProdDescrp.Size = New System.Drawing.Size(208, 27)
        Me.txtProdDescrp.TabIndex = 15
        '
        'txtSupplierName
        '
        Me.txtSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSupplierName.Location = New System.Drawing.Point(475, 97)
        Me.txtSupplierName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(173, 27)
        Me.txtSupplierName.TabIndex = 3
        '
        'txtProdBarcode
        '
        Me.txtProdBarcode.Location = New System.Drawing.Point(117, 20)
        Me.txtProdBarcode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProdBarcode.Name = "txtProdBarcode"
        Me.txtProdBarcode.Size = New System.Drawing.Size(208, 27)
        Me.txtProdBarcode.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Supplier Name:"
        '
        'txtVAT
        '
        Me.txtVAT.Location = New System.Drawing.Point(731, 16)
        Me.txtVAT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(79, 27)
        Me.txtVAT.TabIndex = 11
        '
        'txtMarkup
        '
        Me.txtMarkup.Location = New System.Drawing.Point(477, 52)
        Me.txtMarkup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMarkup.Name = "txtMarkup"
        Me.txtMarkup.Size = New System.Drawing.Size(173, 27)
        Me.txtMarkup.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(343, 55)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 20)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Markup:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(661, 20)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "VAT:"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(475, 14)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(177, 27)
        Me.txtTotalPrice.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(343, 17)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Amount:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(117, 91)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(208, 27)
        Me.txtQuantity.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 91)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Quantity In:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 130)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Buying Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Description :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Barcode :"
        '
        'txtStockinID
        '
        Me.txtStockinID.AutoSize = True
        Me.txtStockinID.Location = New System.Drawing.Point(355, 27)
        Me.txtStockinID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtStockinID.Name = "txtStockinID"
        Me.txtStockinID.Size = New System.Drawing.Size(48, 17)
        Me.txtStockinID.TabIndex = 17
        Me.txtStockinID.Text = "#####"
        '
        'txtdatein
        '
        Me.txtdatein.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdatein.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatein.Location = New System.Drawing.Point(475, 23)
        Me.txtdatein.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtdatein.MaxLength = 50
        Me.txtdatein.Name = "txtdatein"
        Me.txtdatein.Size = New System.Drawing.Size(124, 26)
        Me.txtdatein.TabIndex = 170
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(416, 27)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 17)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Trans Date:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(281, 27)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Order No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(247, 599)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(447, 91)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightGray
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.QCKsaveToolStripButton5, Me.ToolStripButton4, Me.QCKUpdateToolStripButton3, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(25, 26)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(403, 62)
        Me.ToolStrip1.TabIndex = 31
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(21, 59)
        Me.ToolStripLabel1.Text = "   "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnReset)
        Me.GroupBox4.Controls.Add(Me.dtpDateTo)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox4.Controls.Add(Me.btnGetData)
        Me.GroupBox4.Controls.Add(Me.dgw)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(7, 330)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(880, 274)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search Stock"
        '
        'BtnReset
        '
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(620, 27)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(101, 25)
        Me.BtnReset.TabIndex = 40
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(319, 27)
        Me.dtpDateTo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(157, 27)
        Me.dtpDateTo.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 31)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 20)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "To :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "From :"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(76, 27)
        Me.dtpDateFrom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(157, 27)
        Me.dtpDateFrom.TabIndex = 36
        '
        'btnGetData
        '
        Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetData.Location = New System.Drawing.Point(499, 27)
        Me.btnGetData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(101, 25)
        Me.btnGetData.TabIndex = 35
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column2, Me.Column1, Me.Column7, Me.Quantity, Me.Column4, Me.Column3, Me.colSupp, Me.Column8})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(8, 63)
        Me.dgw.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(859, 204)
        Me.dgw.TabIndex = 10
        '
        'Column9
        '
        Me.Column9.HeaderText = "StkID"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "B.Code"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 60
        '
        'Column1
        '
        Me.Column1.HeaderText = "Description"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 85
        '
        'Column7
        '
        Me.Column7.HeaderText = "Date"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 50
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Qty"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "Amount"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "PNo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 35
        '
        'colSupp
        '
        Me.colSupp.HeaderText = "Supplier"
        Me.colSupp.Name = "colSupp"
        Me.colSupp.ReadOnly = True
        Me.colSupp.Width = 90
        '
        'Column8
        '
        Me.Column8.HeaderText = "P.Mode"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 90
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtStockonhand)
        Me.GroupBox5.Controls.Add(Me.LBLProdNo)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtdatein)
        Me.GroupBox5.Controls.Add(Me.txtStockinID)
        Me.GroupBox5.Controls.Add(Me.TxtEnterprdtBarcode)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 60)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(823, 62)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Search Product"
        '
        'txtStockonhand
        '
        Me.txtStockonhand.Location = New System.Drawing.Point(761, 23)
        Me.txtStockonhand.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStockonhand.Name = "txtStockonhand"
        Me.txtStockonhand.Size = New System.Drawing.Size(48, 22)
        Me.txtStockonhand.TabIndex = 183
        Me.txtStockonhand.Visible = False
        '
        'LBLProdNo
        '
        Me.LBLProdNo.AutoSize = True
        Me.LBLProdNo.Location = New System.Drawing.Point(691, 28)
        Me.LBLProdNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLProdNo.Name = "LBLProdNo"
        Me.LBLProdNo.Size = New System.Drawing.Size(48, 17)
        Me.LBLProdNo.TabIndex = 172
        Me.LBLProdNo.Text = "#####"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(608, 28)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 17)
        Me.Label10.TabIndex = 171
        Me.Label10.Text = "Product No:"
        '
        'TxtEnterprdtBarcode
        '
        Me.TxtEnterprdtBarcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtEnterprdtBarcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtEnterprdtBarcode.Location = New System.Drawing.Point(113, 23)
        Me.TxtEnterprdtBarcode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEnterprdtBarcode.Name = "TxtEnterprdtBarcode"
        Me.TxtEnterprdtBarcode.Size = New System.Drawing.Size(159, 22)
        Me.TxtEnterprdtBarcode.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 27)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 17)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Enter Barcode:"
        '
        'QCKsaveToolStripButton5
        '
        Me.QCKsaveToolStripButton5.Image = CType(resources.GetObject("QCKsaveToolStripButton5.Image"), System.Drawing.Image)
        Me.QCKsaveToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.QCKsaveToolStripButton5.Name = "QCKsaveToolStripButton5"
        Me.QCKsaveToolStripButton5.Size = New System.Drawing.Size(60, 59)
        Me.QCKsaveToolStripButton5.Text = "Save"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(65, 40)
        Me.ToolStripButton4.Text = "&New Item"
        '
        'QCKUpdateToolStripButton3
        '
        Me.QCKUpdateToolStripButton3.AutoSize = False
        Me.QCKUpdateToolStripButton3.Image = CType(resources.GetObject("QCKUpdateToolStripButton3.Image"), System.Drawing.Image)
        Me.QCKUpdateToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.QCKUpdateToolStripButton3.Name = "QCKUpdateToolStripButton3"
        Me.QCKUpdateToolStripButton3.Size = New System.Drawing.Size(65, 40)
        Me.QCKUpdateToolStripButton3.Text = "&Update"
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
        'btnmodeofpurchase
        '
        Me.btnmodeofpurchase.BackColor = System.Drawing.Color.DarkGray
        Me.btnmodeofpurchase.BackgroundImage = CType(resources.GetObject("btnmodeofpurchase.BackgroundImage"), System.Drawing.Image)
        Me.btnmodeofpurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnmodeofpurchase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmodeofpurchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmodeofpurchase.Location = New System.Drawing.Point(660, 155)
        Me.btnmodeofpurchase.Margin = New System.Windows.Forms.Padding(4)
        Me.btnmodeofpurchase.Name = "btnmodeofpurchase"
        Me.btnmodeofpurchase.Size = New System.Drawing.Size(29, 21)
        Me.btnmodeofpurchase.TabIndex = 11
        Me.btnmodeofpurchase.UseVisualStyleBackColor = False
        '
        'BtnSuppName
        '
        Me.BtnSuppName.BackColor = System.Drawing.Color.DarkGray
        Me.BtnSuppName.BackgroundImage = CType(resources.GetObject("BtnSuppName.BackgroundImage"), System.Drawing.Image)
        Me.BtnSuppName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSuppName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSuppName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSuppName.Location = New System.Drawing.Point(657, 101)
        Me.BtnSuppName.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSuppName.Name = "BtnSuppName"
        Me.BtnSuppName.Size = New System.Drawing.Size(29, 21)
        Me.BtnSuppName.TabIndex = 12
        Me.BtnSuppName.UseVisualStyleBackColor = False
        '
        'frmStockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 693)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmStockIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase One Item"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpurchasemode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVAT As System.Windows.Forms.TextBox
    Friend WithEvents txtMarkup As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBuyingPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtProdDescrp As System.Windows.Forms.TextBox
    Friend WithEvents txtProdBarcode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents QCKUpdateToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents QCKsaveToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSuppName As System.Windows.Forms.Button
    Friend WithEvents btnmodeofpurchase As System.Windows.Forms.Button
    Friend WithEvents txtdatein As System.Windows.Forms.TextBox
    Friend WithEvents txtStockinID As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtEnterprdtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents LBLProdNo As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPurchMdID As System.Windows.Forms.TextBox
    Friend WithEvents txtSuupID As System.Windows.Forms.TextBox
    Friend WithEvents txtSellingPrc As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtRemQty As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtStockonhand As System.Windows.Forms.TextBox
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSupp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
