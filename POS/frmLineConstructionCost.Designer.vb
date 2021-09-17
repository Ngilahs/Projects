<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineConstructionCost
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.btnLCSExportExcel = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgw1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSchm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTotalIncVat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalincvat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalAmt = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.colInvoiceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQtyperUoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblschmtotincvat = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblschmvat = New System.Windows.Forms.Label()
        Me.lblschmtotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnexporttoexcel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerateList = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCompletedSchms = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(-1, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1093, 38)
        Me.TextBox1.TabIndex = 229
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.lblCompletedSchms)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnGenerateList)
        Me.GroupBox2.Controls.Add(Me.txtCategory)
        Me.GroupBox2.Controls.Add(Me.btnLCSExportExcel)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.dgw1)
        Me.GroupBox2.Controls.Add(Me.lblTotalincvat)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblTotalAmt)
        Me.GroupBox2.Controls.Add(Me.lblVat)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(-1, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(513, 465)
        Me.GroupBox2.TabIndex = 231
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Statements"
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(9, 30)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(198, 20)
        Me.txtCategory.TabIndex = 306
        '
        'btnLCSExportExcel
        '
        Me.btnLCSExportExcel.BackColor = System.Drawing.Color.Aqua
        Me.btnLCSExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLCSExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLCSExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLCSExportExcel.Location = New System.Drawing.Point(430, 23)
        Me.btnLCSExportExcel.Name = "btnLCSExportExcel"
        Me.btnLCSExportExcel.Size = New System.Drawing.Size(75, 22)
        Me.btnLCSExportExcel.TabIndex = 256
        Me.btnLCSExportExcel.Text = "&Export Excel"
        Me.btnLCSExportExcel.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(201, 13)
        Me.Label15.TabIndex = 255
        Me.Label15.Text = "Stmnt/Schm/Contractor/Category:"
        '
        'dgw1
        '
        Me.dgw1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgw1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.colSchm, Me.DataGridViewTextBoxColumn3, Me.colTotalAmt, Me.colVat, Me.ColTotalIncVat, Me.colCategory})
        Me.dgw1.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw1.Location = New System.Drawing.Point(6, 58)
        Me.dgw1.MultiSelect = False
        Me.dgw1.Name = "dgw1"
        Me.dgw1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw1.Size = New System.Drawing.Size(499, 371)
        Me.dgw1.TabIndex = 44
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Stmnt"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Scheme"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'colSchm
        '
        Me.colSchm.HeaderText = "Ref No"
        Me.colSchm.Name = "colSchm"
        Me.colSchm.Width = 75
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Contrct"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'colTotalAmt
        '
        Me.colTotalAmt.HeaderText = "Tot Amt"
        Me.colTotalAmt.Name = "colTotalAmt"
        Me.colTotalAmt.Width = 70
        '
        'colVat
        '
        Me.colVat.HeaderText = "Vat"
        Me.colVat.Name = "colVat"
        Me.colVat.Width = 70
        '
        'ColTotalIncVat
        '
        Me.ColTotalIncVat.HeaderText = "Tot+Vat"
        Me.ColTotalIncVat.Name = "ColTotalIncVat"
        Me.ColTotalIncVat.Width = 70
        '
        'colCategory
        '
        Me.colCategory.HeaderText = "Cat"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Width = 75
        '
        'lblTotalincvat
        '
        Me.lblTotalincvat.AutoSize = True
        Me.lblTotalincvat.BackColor = System.Drawing.Color.Aqua
        Me.lblTotalincvat.Location = New System.Drawing.Point(409, 434)
        Me.lblTotalincvat.Name = "lblTotalincvat"
        Me.lblTotalincvat.Size = New System.Drawing.Size(79, 13)
        Me.lblTotalincvat.TabIndex = 304
        Me.lblTotalincvat.Text = "++++++++++++"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 434)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 300
        Me.Label3.Text = "Project Total:"
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.AutoSize = True
        Me.lblTotalAmt.BackColor = System.Drawing.Color.Aqua
        Me.lblTotalAmt.Location = New System.Drawing.Point(119, 434)
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(61, 13)
        Me.lblTotalAmt.TabIndex = 299
        Me.lblTotalAmt.Text = "+++++++++"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.BackColor = System.Drawing.Color.Aqua
        Me.lblVat.Location = New System.Drawing.Point(230, 434)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(61, 13)
        Me.lblVat.TabIndex = 303
        Me.lblVat.Text = "+++++++++"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 301
        Me.Label1.Text = "Vat:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(318, 434)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 302
        Me.Label16.Text = "Total Inc Vat:"
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FloralWhite
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgw.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colInvoiceNo, Me.Column7, Me.Column1, Me.colQtyperUoM, Me.colUnits, Me.colQty, Me.colTotalprice})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(518, 42)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(574, 429)
        Me.dgw.TabIndex = 232
        '
        'colInvoiceNo
        '
        Me.colInvoiceNo.HeaderText = "Stmnt#"
        Me.colInvoiceNo.Name = "colInvoiceNo"
        Me.colInvoiceNo.ReadOnly = True
        Me.colInvoiceNo.Width = 60
        '
        'Column7
        '
        Me.Column7.HeaderText = "BoQ#"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 60
        '
        'Column1
        '
        Me.Column1.HeaderText = "BoQ Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 200
        '
        'colQtyperUoM
        '
        Me.colQtyperUoM.HeaderText = "UoM"
        Me.colQtyperUoM.Name = "colQtyperUoM"
        Me.colQtyperUoM.ReadOnly = True
        Me.colQtyperUoM.Width = 50
        '
        'colUnits
        '
        Me.colUnits.HeaderText = "Rate"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.ReadOnly = True
        Me.colUnits.Width = 60
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        Me.colQty.Width = 35
        '
        'colTotalprice
        '
        Me.colTotalprice.HeaderText = "Total"
        Me.colTotalprice.Name = "colTotalprice"
        Me.colTotalprice.ReadOnly = True
        Me.colTotalprice.Width = 80
        '
        'lblschmtotincvat
        '
        Me.lblschmtotincvat.AutoSize = True
        Me.lblschmtotincvat.BackColor = System.Drawing.Color.Aqua
        Me.lblschmtotincvat.Location = New System.Drawing.Point(1005, 481)
        Me.lblschmtotincvat.Name = "lblschmtotincvat"
        Me.lblschmtotincvat.Size = New System.Drawing.Size(79, 13)
        Me.lblschmtotincvat.TabIndex = 318
        Me.lblschmtotincvat.Text = "++++++++++++"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(800, 481)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 315
        Me.Label5.Text = "Vat:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(914, 481)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 316
        Me.Label6.Text = "Total Inc Vat:"
        '
        'lblschmvat
        '
        Me.lblschmvat.AutoSize = True
        Me.lblschmvat.BackColor = System.Drawing.Color.Aqua
        Me.lblschmvat.Location = New System.Drawing.Point(826, 481)
        Me.lblschmvat.Name = "lblschmvat"
        Me.lblschmvat.Size = New System.Drawing.Size(61, 13)
        Me.lblschmvat.TabIndex = 317
        Me.lblschmvat.Text = "+++++++++"
        '
        'lblschmtotal
        '
        Me.lblschmtotal.AutoSize = True
        Me.lblschmtotal.BackColor = System.Drawing.Color.Aqua
        Me.lblschmtotal.Location = New System.Drawing.Point(715, 481)
        Me.lblschmtotal.Name = "lblschmtotal"
        Me.lblschmtotal.Size = New System.Drawing.Size(61, 13)
        Me.lblschmtotal.TabIndex = 313
        Me.lblschmtotal.Text = "+++++++++"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(620, 481)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 314
        Me.Label9.Text = "Scheme Total:"
        '
        'btnexporttoexcel
        '
        Me.btnexporttoexcel.BackColor = System.Drawing.Color.Aqua
        Me.btnexporttoexcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexporttoexcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexporttoexcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexporttoexcel.Location = New System.Drawing.Point(530, 476)
        Me.btnexporttoexcel.Name = "btnexporttoexcel"
        Me.btnexporttoexcel.Size = New System.Drawing.Size(84, 22)
        Me.btnexporttoexcel.TabIndex = 312
        Me.btnexporttoexcel.Text = "&Export Excel"
        Me.btnexporttoexcel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(437, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 17)
        Me.Label2.TabIndex = 319
        Me.Label2.Text = "Line Construction Statements"
        '
        'btnGenerateList
        '
        Me.btnGenerateList.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateList.Location = New System.Drawing.Point(211, 28)
        Me.btnGenerateList.Name = "btnGenerateList"
        Me.btnGenerateList.Size = New System.Drawing.Size(80, 22)
        Me.btnGenerateList.TabIndex = 307
        Me.btnGenerateList.Text = "Generate List"
        Me.btnGenerateList.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 308
        Me.Label4.Text = "Schemes Completed"
        '
        'lblCompletedSchms
        '
        Me.lblCompletedSchms.AutoSize = True
        Me.lblCompletedSchms.Location = New System.Drawing.Point(318, 32)
        Me.lblCompletedSchms.Name = "lblCompletedSchms"
        Me.lblCompletedSchms.Size = New System.Drawing.Size(63, 13)
        Me.lblCompletedSchms.TabIndex = 309
        Me.lblCompletedSchms.Text = "XXXXXXXX"
        '
        'frmLineConstructionCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 510)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblschmtotincvat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblschmvat)
        Me.Controls.Add(Me.lblschmtotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnexporttoexcel)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmLineConstructionCost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents btnLCSExportExcel As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents dgw1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents colSchm As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents colTotalAmt As DataGridViewTextBoxColumn
    Friend WithEvents colVat As DataGridViewTextBoxColumn
    Friend WithEvents ColTotalIncVat As DataGridViewTextBoxColumn
    Friend WithEvents colCategory As DataGridViewTextBoxColumn
    Friend WithEvents lblTotalincvat As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalAmt As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents dgw As DataGridView
    Friend WithEvents colInvoiceNo As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colQtyperUoM As DataGridViewTextBoxColumn
    Friend WithEvents colUnits As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colTotalprice As DataGridViewTextBoxColumn
    Friend WithEvents lblschmtotincvat As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblschmvat As Label
    Friend WithEvents lblschmtotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnexporttoexcel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerateList As Button
    Friend WithEvents lblCompletedSchms As Label
    Friend WithEvents Label4 As Label
End Class
