<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateMtrlReceived
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateMtrlReceived))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtReceiptdelivery = New System.Windows.Forms.TextBox()
        Me.dgw1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblBillNo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDocumentNo = New System.Windows.Forms.TextBox()
        Me.lbldateRS = New System.Windows.Forms.DateTimePicker()
        Me.txtDeliveryNote = New System.Windows.Forms.TextBox()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSchemeName = New System.Windows.Forms.ComboBox()
        Me.btnsupplierRS = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSupplNameRS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStockinIDRS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddtoGrid = New System.Windows.Forms.Button()
        Me.txtreceivedQty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboSearchItem = New System.Windows.Forms.ComboBox()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSupplierID = New System.Windows.Forms.TextBox()
        Me.txtSchmID = New System.Windows.Forms.TextBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.dgwReceiptSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchemeNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(539, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 20)
        Me.Label2.TabIndex = 229
        Me.Label2.Text = "Update Material Receipt"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(1, 1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1257, 38)
        Me.TextBox1.TabIndex = 228
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(1007, 45)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 13)
        Me.Label23.TabIndex = 308
        Me.Label23.Text = "Receipt No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtReceiptdelivery)
        Me.GroupBox2.Controls.Add(Me.dgw1)
        Me.GroupBox2.Location = New System.Drawing.Point(952, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 463)
        Me.GroupBox2.TabIndex = 306
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Receipts"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(36, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(235, 13)
        Me.Label15.TabIndex = 255
        Me.Label15.Text = "Receipt No/Delivery No/Supplier Name:"
        '
        'txtReceiptdelivery
        '
        Me.txtReceiptdelivery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtReceiptdelivery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtReceiptdelivery.Location = New System.Drawing.Point(8, 40)
        Me.txtReceiptdelivery.Name = "txtReceiptdelivery"
        Me.txtReceiptdelivery.Size = New System.Drawing.Size(288, 20)
        Me.txtReceiptdelivery.TabIndex = 253
        '
        'dgw1
        '
        Me.dgw1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgw1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgw1.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw1.Location = New System.Drawing.Point(6, 74)
        Me.dgw1.MultiSelect = False
        Me.dgw1.Name = "dgw1"
        Me.dgw1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw1.Size = New System.Drawing.Size(294, 383)
        Me.dgw1.TabIndex = 44
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Receipt"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Delivery"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'LblBillNo
        '
        Me.LblBillNo.AutoSize = True
        Me.LblBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBillNo.Location = New System.Drawing.Point(1096, 42)
        Me.LblBillNo.Name = "LblBillNo"
        Me.LblBillNo.Size = New System.Drawing.Size(112, 16)
        Me.LblBillNo.TabIndex = 307
        Me.LblBillNo.Text = "#############"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboSchemeName)
        Me.GroupBox1.Controls.Add(Me.txtDocumentNo)
        Me.GroupBox1.Controls.Add(Me.lbldateRS)
        Me.GroupBox1.Controls.Add(Me.txtDeliveryNote)
        Me.GroupBox1.Controls.Add(Me.txtSchemeID)
        Me.GroupBox1.Controls.Add(Me.txtConstituencyID)
        Me.GroupBox1.Controls.Add(Me.txtCountyID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnsupplierRS)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtSupplNameRS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtStockinIDRS)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnAddtoGrid)
        Me.GroupBox1.Controls.Add(Me.txtreceivedQty)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboSearchItem)
        Me.GroupBox1.Controls.Add(Me.txtItemNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSupplierID)
        Me.GroupBox1.Controls.Add(Me.txtSchmID)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(945, 73)
        Me.GroupBox1.TabIndex = 309
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items Received"
        '
        'txtDocumentNo
        '
        Me.txtDocumentNo.BackColor = System.Drawing.Color.White
        Me.txtDocumentNo.Location = New System.Drawing.Point(357, 44)
        Me.txtDocumentNo.Name = "txtDocumentNo"
        Me.txtDocumentNo.Size = New System.Drawing.Size(129, 20)
        Me.txtDocumentNo.TabIndex = 234
        '
        'lbldateRS
        '
        Me.lbldateRS.CustomFormat = "dd/MM/yyyy"
        Me.lbldateRS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.lbldateRS.Location = New System.Drawing.Point(776, 44)
        Me.lbldateRS.Name = "lbldateRS"
        Me.lbldateRS.Size = New System.Drawing.Size(112, 20)
        Me.lbldateRS.TabIndex = 250
        '
        'txtDeliveryNote
        '
        Me.txtDeliveryNote.BackColor = System.Drawing.Color.White
        Me.txtDeliveryNote.Location = New System.Drawing.Point(617, 47)
        Me.txtDeliveryNote.Name = "txtDeliveryNote"
        Me.txtDeliveryNote.Size = New System.Drawing.Size(10, 20)
        Me.txtDeliveryNote.TabIndex = 232
        Me.txtDeliveryNote.Visible = False
        '
        'txtSchemeID
        '
        Me.txtSchemeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeID.Enabled = False
        Me.txtSchemeID.Location = New System.Drawing.Point(649, 47)
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
        Me.txtConstituencyID.Location = New System.Drawing.Point(668, 47)
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
        Me.txtCountyID.Location = New System.Drawing.Point(633, 47)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(13, 20)
        Me.txtCountyID.TabIndex = 245
        Me.txtCountyID.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(279, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 231
        Me.Label10.Text = "Delivery No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(492, 50)
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
        Me.cboSchemeName.Location = New System.Drawing.Point(577, 47)
        Me.cboSchemeName.Name = "cboSchemeName"
        Me.cboSchemeName.Size = New System.Drawing.Size(101, 21)
        Me.cboSchemeName.TabIndex = 230
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
        'txtStockinIDRS
        '
        Me.txtStockinIDRS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStockinIDRS.Enabled = False
        Me.txtStockinIDRS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockinIDRS.Location = New System.Drawing.Point(776, 15)
        Me.txtStockinIDRS.MaxLength = 50
        Me.txtStockinIDRS.Name = "txtStockinIDRS"
        Me.txtStockinIDRS.Size = New System.Drawing.Size(112, 22)
        Me.txtStockinIDRS.TabIndex = 174
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 217
        Me.Label1.Text = "Item Name :"
        '
        'btnAddtoGrid
        '
        Me.btnAddtoGrid.BackColor = System.Drawing.Color.Cyan
        Me.btnAddtoGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoGrid.Location = New System.Drawing.Point(894, 15)
        Me.btnAddtoGrid.Name = "btnAddtoGrid"
        Me.btnAddtoGrid.Size = New System.Drawing.Size(45, 79)
        Me.btnAddtoGrid.TabIndex = 225
        Me.btnAddtoGrid.Text = "Add "
        Me.btnAddtoGrid.UseVisualStyleBackColor = False
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
        'txtItemNo
        '
        Me.txtItemNo.BackColor = System.Drawing.Color.White
        Me.txtItemNo.Enabled = False
        Me.txtItemNo.Location = New System.Drawing.Point(356, 18)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(130, 20)
        Me.txtItemNo.TabIndex = 218
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(279, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 216
        Me.Label7.Text = "Item No:"
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
        'txtSchmID
        '
        Me.txtSchmID.Enabled = False
        Me.txtSchmID.Location = New System.Drawing.Point(579, 48)
        Me.txtSchmID.Name = "txtSchmID"
        Me.txtSchmID.Size = New System.Drawing.Size(23, 20)
        Me.txtSchmID.TabIndex = 249
        Me.txtSchmID.Visible = False
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwReceiptSupplier, Me.Column11, Me.Column7, Me.Column9, Me.DocumentNo, Me.SchemeNo})
        Me.dgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(1, 121)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(945, 459)
        Me.dgw.TabIndex = 310
        '
        'dgwReceiptSupplier
        '
        Me.dgwReceiptSupplier.HeaderText = "Receipt No"
        Me.dgwReceiptSupplier.Name = "dgwReceiptSupplier"
        Me.dgwReceiptSupplier.ReadOnly = True
        Me.dgwReceiptSupplier.Width = 180
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
        Me.Column7.Width = 300
        '
        'Column9
        '
        Me.Column9.HeaderText = "Quantity In"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
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
        Me.SchemeNo.HeaderText = "Delivery No"
        Me.SchemeNo.Name = "SchemeNo"
        Me.SchemeNo.ReadOnly = True
        Me.SchemeNo.Visible = False
        '
        'frmUpdateMtrlReceived
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 584)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LblBillNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmUpdateMtrlReceived"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtReceiptdelivery As TextBox
    Friend WithEvents dgw1 As DataGridView
    Friend WithEvents LblBillNo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDocumentNo As TextBox
    Friend WithEvents lbldateRS As DateTimePicker
    Friend WithEvents txtDeliveryNote As TextBox
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboSchemeName As ComboBox
    Friend WithEvents btnsupplierRS As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSupplNameRS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStockinIDRS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddtoGrid As Button
    Friend WithEvents txtreceivedQty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboSearchItem As ComboBox
    Friend WithEvents txtItemNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSupplierID As TextBox
    Friend WithEvents txtSchmID As TextBox
    Friend WithEvents dgw As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents dgwReceiptSupplier As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DocumentNo As DataGridViewTextBoxColumn
    Friend WithEvents SchemeNo As DataGridViewTextBoxColumn
End Class
