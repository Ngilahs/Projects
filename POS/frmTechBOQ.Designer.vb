<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTechBOQ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTechBOQ))
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Details = New System.Windows.Forms.GroupBox()
        Me.cboSubcontractor = New System.Windows.Forms.TextBox()
        Me.btnLoadSubcontractor = New System.Windows.Forms.Button()
        Me.btnAddMeterItems = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTXNo1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtConstituencyname1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCounty1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSchemeName1 = New System.Windows.Forms.TextBox()
        Me.btnLoadSchemes = New System.Windows.Forms.Button()
        Me.txtSubcontractor = New System.Windows.Forms.TextBox()
        Me.txtSchemeRefNo1 = New System.Windows.Forms.TextBox()
        Me.lbldate = New System.Windows.Forms.DateTimePicker()
        Me.txtSchemeID1 = New System.Windows.Forms.TextBox()
        Me.txtConstituencyID1 = New System.Windows.Forms.TextBox()
        Me.txtCountyID1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblScheme = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQtyperUoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalincvat = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblTotalAmt = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PSaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ResetFormToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CloseToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.chklineIteminvoiced = New System.Windows.Forms.CheckBox()
        Me.chkMeterinvoiced = New System.Windows.Forms.CheckBox()
        Me.txtNil = New System.Windows.Forms.TextBox()
        Me.cboVat = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVatRate = New System.Windows.Forms.TextBox()
        Me.txtVatNo = New System.Windows.Forms.TextBox()
        Me.Details.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(316, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 16)
        Me.Label2.TabIndex = 226
        Me.Label2.Text = "Techncian Statement"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(2, 1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(789, 28)
        Me.TextBox1.TabIndex = 225
        '
        'Details
        '
        Me.Details.Controls.Add(Me.cboVat)
        Me.Details.Controls.Add(Me.Label8)
        Me.Details.Controls.Add(Me.txtVatRate)
        Me.Details.Controls.Add(Me.txtVatNo)
        Me.Details.Controls.Add(Me.cboSubcontractor)
        Me.Details.Controls.Add(Me.btnLoadSubcontractor)
        Me.Details.Controls.Add(Me.btnAddMeterItems)
        Me.Details.Controls.Add(Me.Label6)
        Me.Details.Controls.Add(Me.txtTXNo1)
        Me.Details.Controls.Add(Me.Label11)
        Me.Details.Controls.Add(Me.txtConstituencyname1)
        Me.Details.Controls.Add(Me.Label10)
        Me.Details.Controls.Add(Me.txtCounty1)
        Me.Details.Controls.Add(Me.Label9)
        Me.Details.Controls.Add(Me.txtSchemeName1)
        Me.Details.Controls.Add(Me.btnLoadSchemes)
        Me.Details.Controls.Add(Me.txtSubcontractor)
        Me.Details.Controls.Add(Me.txtSchemeRefNo1)
        Me.Details.Controls.Add(Me.lbldate)
        Me.Details.Controls.Add(Me.txtSchemeID1)
        Me.Details.Controls.Add(Me.txtConstituencyID1)
        Me.Details.Controls.Add(Me.txtCountyID1)
        Me.Details.Controls.Add(Me.Label1)
        Me.Details.Controls.Add(Me.Label7)
        Me.Details.Controls.Add(Me.lblScheme)
        Me.Details.Controls.Add(Me.Label19)
        Me.Details.Location = New System.Drawing.Point(2, 35)
        Me.Details.Name = "Details"
        Me.Details.Size = New System.Drawing.Size(789, 68)
        Me.Details.TabIndex = 227
        Me.Details.TabStop = False
        Me.Details.Text = "Details"
        '
        'cboSubcontractor
        '
        Me.cboSubcontractor.Enabled = False
        Me.cboSubcontractor.Location = New System.Drawing.Point(56, 14)
        Me.cboSubcontractor.Name = "cboSubcontractor"
        Me.cboSubcontractor.Size = New System.Drawing.Size(116, 20)
        Me.cboSubcontractor.TabIndex = 310
        '
        'btnLoadSubcontractor
        '
        Me.btnLoadSubcontractor.BackColor = System.Drawing.Color.DarkGray
        Me.btnLoadSubcontractor.BackgroundImage = CType(resources.GetObject("btnLoadSubcontractor.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadSubcontractor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadSubcontractor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSubcontractor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSubcontractor.Location = New System.Drawing.Point(178, 15)
        Me.btnLoadSubcontractor.Name = "btnLoadSubcontractor"
        Me.btnLoadSubcontractor.Size = New System.Drawing.Size(22, 17)
        Me.btnLoadSubcontractor.TabIndex = 309
        Me.btnLoadSubcontractor.UseVisualStyleBackColor = False
        '
        'btnAddMeterItems
        '
        Me.btnAddMeterItems.BackColor = System.Drawing.Color.Cyan
        Me.btnAddMeterItems.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMeterItems.Location = New System.Drawing.Point(680, 36)
        Me.btnAddMeterItems.Name = "btnAddMeterItems"
        Me.btnAddMeterItems.Size = New System.Drawing.Size(101, 23)
        Me.btnAddMeterItems.TabIndex = 258
        Me.btnAddMeterItems.Text = "Techncian BOQs"
        Me.btnAddMeterItems.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 14)
        Me.Label6.TabIndex = 287
        Me.Label6.Text = "Sub-Con:"
        '
        'txtTXNo1
        '
        Me.txtTXNo1.Enabled = False
        Me.txtTXNo1.Location = New System.Drawing.Point(276, 39)
        Me.txtTXNo1.Name = "txtTXNo1"
        Me.txtTXNo1.Size = New System.Drawing.Size(131, 20)
        Me.txtTXNo1.TabIndex = 286
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(227, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 14)
        Me.Label11.TabIndex = 285
        Me.Label11.Text = "TX No:"
        '
        'txtConstituencyname1
        '
        Me.txtConstituencyname1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyname1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyname1.Enabled = False
        Me.txtConstituencyname1.Location = New System.Drawing.Point(462, 16)
        Me.txtConstituencyname1.Name = "txtConstituencyname1"
        Me.txtConstituencyname1.Size = New System.Drawing.Size(94, 20)
        Me.txtConstituencyname1.TabIndex = 277
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(413, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 14)
        Me.Label10.TabIndex = 278
        Me.Label10.Text = "Consty:"
        '
        'txtCounty1
        '
        Me.txtCounty1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCounty1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCounty1.Enabled = False
        Me.txtCounty1.Location = New System.Drawing.Point(463, 40)
        Me.txtCounty1.Name = "txtCounty1"
        Me.txtCounty1.Size = New System.Drawing.Size(93, 20)
        Me.txtCounty1.TabIndex = 275
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(413, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 14)
        Me.Label9.TabIndex = 276
        Me.Label9.Text = "County:"
        '
        'txtSchemeName1
        '
        Me.txtSchemeName1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeName1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeName1.Enabled = False
        Me.txtSchemeName1.Location = New System.Drawing.Point(54, 40)
        Me.txtSchemeName1.Name = "txtSchemeName1"
        Me.txtSchemeName1.Size = New System.Drawing.Size(118, 20)
        Me.txtSchemeName1.TabIndex = 284
        '
        'btnLoadSchemes
        '
        Me.btnLoadSchemes.BackColor = System.Drawing.Color.DarkGray
        Me.btnLoadSchemes.BackgroundImage = CType(resources.GetObject("btnLoadSchemes.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadSchemes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadSchemes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSchemes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSchemes.Location = New System.Drawing.Point(178, 41)
        Me.btnLoadSchemes.Name = "btnLoadSchemes"
        Me.btnLoadSchemes.Size = New System.Drawing.Size(22, 17)
        Me.btnLoadSchemes.TabIndex = 283
        Me.btnLoadSchemes.UseVisualStyleBackColor = False
        '
        'txtSubcontractor
        '
        Me.txtSubcontractor.Location = New System.Drawing.Point(145, 14)
        Me.txtSubcontractor.Name = "txtSubcontractor"
        Me.txtSubcontractor.Size = New System.Drawing.Size(16, 20)
        Me.txtSubcontractor.TabIndex = 281
        '
        'txtSchemeRefNo1
        '
        Me.txtSchemeRefNo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeRefNo1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeRefNo1.Location = New System.Drawing.Point(276, 13)
        Me.txtSchemeRefNo1.Name = "txtSchemeRefNo1"
        Me.txtSchemeRefNo1.Size = New System.Drawing.Size(131, 20)
        Me.txtSchemeRefNo1.TabIndex = 261
        '
        'lbldate
        '
        Me.lbldate.CustomFormat = "MM/dd/yyyy"
        Me.lbldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.lbldate.Location = New System.Drawing.Point(562, 40)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(104, 20)
        Me.lbldate.TabIndex = 268
        '
        'txtSchemeID1
        '
        Me.txtSchemeID1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeID1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeID1.Enabled = False
        Me.txtSchemeID1.Location = New System.Drawing.Point(336, 13)
        Me.txtSchemeID1.Name = "txtSchemeID1"
        Me.txtSchemeID1.Size = New System.Drawing.Size(13, 20)
        Me.txtSchemeID1.TabIndex = 265
        '
        'txtConstituencyID1
        '
        Me.txtConstituencyID1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyID1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyID1.Enabled = False
        Me.txtConstituencyID1.Location = New System.Drawing.Point(355, 13)
        Me.txtConstituencyID1.Name = "txtConstituencyID1"
        Me.txtConstituencyID1.Size = New System.Drawing.Size(10, 20)
        Me.txtConstituencyID1.TabIndex = 267
        '
        'txtCountyID1
        '
        Me.txtCountyID1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCountyID1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCountyID1.Enabled = False
        Me.txtCountyID1.Location = New System.Drawing.Point(317, 13)
        Me.txtCountyID1.Name = "txtCountyID1"
        Me.txtCountyID1.Size = New System.Drawing.Size(13, 20)
        Me.txtCountyID1.TabIndex = 266
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(226, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 14)
        Me.Label1.TabIndex = 263
        Me.Label1.Text = " Ref-No"
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
        'lblScheme
        '
        Me.lblScheme.AutoSize = True
        Me.lblScheme.BackColor = System.Drawing.Color.White
        Me.lblScheme.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheme.ForeColor = System.Drawing.Color.Black
        Me.lblScheme.Location = New System.Drawing.Point(6, 43)
        Me.lblScheme.Name = "lblScheme"
        Me.lblScheme.Size = New System.Drawing.Size(42, 14)
        Me.lblScheme.TabIndex = 249
        Me.lblScheme.Text = "Scheme"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(595, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 14)
        Me.Label19.TabIndex = 246
        Me.Label19.Text = "Date:"
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        Me.dgw.AllowUserToOrderColumns = True
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.FloralWhite
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle31
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.colQtyperUoM, Me.colUnits, Me.colQty, Me.colTotalprice})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle33
        Me.dgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(2, 109)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle34.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle34
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle35
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(789, 298)
        Me.dgw.TabIndex = 228
        '
        'Column7
        '
        Me.Column7.HeaderText = "BoQ No"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 75
        '
        'Column1
        '
        Me.Column1.HeaderText = "BoQ Description"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 400
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
        Me.colUnits.HeaderText = "Unit Rate"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.ReadOnly = True
        Me.colUnits.Width = 90
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Width = 50
        '
        'colTotalprice
        '
        Me.colTotalprice.HeaderText = "Total"
        Me.colTotalprice.Name = "colTotalprice"
        Me.colTotalprice.ReadOnly = True
        Me.colTotalprice.Width = 90
        '
        'lblTotalincvat
        '
        Me.lblTotalincvat.AutoSize = True
        Me.lblTotalincvat.BackColor = System.Drawing.Color.Aqua
        Me.lblTotalincvat.Location = New System.Drawing.Point(664, 422)
        Me.lblTotalincvat.Name = "lblTotalincvat"
        Me.lblTotalincvat.Size = New System.Drawing.Size(79, 13)
        Me.lblTotalincvat.TabIndex = 312
        Me.lblTotalincvat.Text = "++++++++++++"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(449, 422)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 309
        Me.Label15.Text = "Vat:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(573, 422)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 310
        Me.Label16.Text = "Total Inc Vat:"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.BackColor = System.Drawing.Color.Aqua
        Me.lblVat.Location = New System.Drawing.Point(485, 422)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(61, 13)
        Me.lblVat.TabIndex = 311
        Me.lblVat.Text = "+++++++++"
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.AutoSize = True
        Me.lblTotalAmt.BackColor = System.Drawing.Color.Aqua
        Me.lblTotalAmt.Location = New System.Drawing.Point(374, 422)
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(61, 13)
        Me.lblTotalAmt.TabIndex = 306
        Me.lblTotalAmt.Text = "+++++++++"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(320, 422)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 308
        Me.Label14.Text = "Total:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PSaveToolStripButton, Me.ResetFormToolStripButton, Me.CloseToolStripLabel})
        Me.ToolStrip1.Location = New System.Drawing.Point(145, 410)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(172, 31)
        Me.ToolStrip1.TabIndex = 307
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'PSaveToolStripButton
        '
        Me.PSaveToolStripButton.Image = CType(resources.GetObject("PSaveToolStripButton.Image"), System.Drawing.Image)
        Me.PSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PSaveToolStripButton.Name = "PSaveToolStripButton"
        Me.PSaveToolStripButton.Size = New System.Drawing.Size(51, 28)
        Me.PSaveToolStripButton.Text = "Save"
        '
        'ResetFormToolStripButton
        '
        Me.ResetFormToolStripButton.AutoSize = False
        Me.ResetFormToolStripButton.Image = CType(resources.GetObject("ResetFormToolStripButton.Image"), System.Drawing.Image)
        Me.ResetFormToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ResetFormToolStripButton.Name = "ResetFormToolStripButton"
        Me.ResetFormToolStripButton.Size = New System.Drawing.Size(65, 40)
        Me.ResetFormToolStripButton.Text = "Reset Form"
        '
        'CloseToolStripLabel
        '
        Me.CloseToolStripLabel.Name = "CloseToolStripLabel"
        Me.CloseToolStripLabel.Size = New System.Drawing.Size(36, 28)
        Me.CloseToolStripLabel.Text = "Close"
        '
        'chklineIteminvoiced
        '
        Me.chklineIteminvoiced.AutoSize = True
        Me.chklineIteminvoiced.Location = New System.Drawing.Point(23, 109)
        Me.chklineIteminvoiced.Name = "chklineIteminvoiced"
        Me.chklineIteminvoiced.Size = New System.Drawing.Size(113, 17)
        Me.chklineIteminvoiced.TabIndex = 313
        Me.chklineIteminvoiced.Text = "Line Item Invoiced"
        Me.chklineIteminvoiced.UseVisualStyleBackColor = True
        '
        'chkMeterinvoiced
        '
        Me.chkMeterinvoiced.AutoSize = True
        Me.chkMeterinvoiced.Location = New System.Drawing.Point(147, 109)
        Me.chkMeterinvoiced.Name = "chkMeterinvoiced"
        Me.chkMeterinvoiced.Size = New System.Drawing.Size(97, 17)
        Me.chkMeterinvoiced.TabIndex = 314
        Me.chkMeterinvoiced.Text = "Meter Invoiced"
        Me.chkMeterinvoiced.UseVisualStyleBackColor = True
        '
        'txtNil
        '
        Me.txtNil.Enabled = False
        Me.txtNil.Location = New System.Drawing.Point(357, 324)
        Me.txtNil.Name = "txtNil"
        Me.txtNil.Size = New System.Drawing.Size(24, 20)
        Me.txtNil.TabIndex = 315
        '
        'cboVat
        '
        Me.cboVat.FormattingEnabled = True
        Me.cboVat.Location = New System.Drawing.Point(680, 13)
        Me.cboVat.Name = "cboVat"
        Me.cboVat.Size = New System.Drawing.Size(101, 21)
        Me.cboVat.TabIndex = 318
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Red
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(641, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 14)
        Me.Label8.TabIndex = 317
        Me.Label8.Text = "Vat:"
        '
        'txtVatRate
        '
        Me.txtVatRate.Enabled = False
        Me.txtVatRate.Location = New System.Drawing.Point(729, 14)
        Me.txtVatRate.Name = "txtVatRate"
        Me.txtVatRate.Size = New System.Drawing.Size(22, 20)
        Me.txtVatRate.TabIndex = 320
        '
        'txtVatNo
        '
        Me.txtVatNo.Enabled = False
        Me.txtVatNo.Location = New System.Drawing.Point(757, 14)
        Me.txtVatNo.Name = "txtVatNo"
        Me.txtVatNo.Size = New System.Drawing.Size(23, 20)
        Me.txtVatNo.TabIndex = 319
        '
        'frmTechBOQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 444)
        Me.Controls.Add(Me.lblTotalincvat)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblVat)
        Me.Controls.Add(Me.lblTotalAmt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.Details)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtNil)
        Me.Controls.Add(Me.chkMeterinvoiced)
        Me.Controls.Add(Me.chklineIteminvoiced)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmTechBOQ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Details.ResumeLayout(False)
        Me.Details.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Details As GroupBox
    Friend WithEvents cboSubcontractor As TextBox
    Friend WithEvents btnLoadSubcontractor As Button
    Friend WithEvents btnAddMeterItems As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTXNo1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtConstituencyname1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCounty1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSchemeName1 As TextBox
    Friend WithEvents btnLoadSchemes As Button
    Friend WithEvents txtSubcontractor As TextBox
    Friend WithEvents txtSchemeRefNo1 As TextBox
    Friend WithEvents lbldate As DateTimePicker
    Friend WithEvents txtSchemeID1 As TextBox
    Friend WithEvents txtConstituencyID1 As TextBox
    Friend WithEvents txtCountyID1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblScheme As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents dgw As DataGridView
    Friend WithEvents lblTotalincvat As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents lblTotalAmt As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents PSaveToolStripButton As ToolStripButton
    Friend WithEvents ResetFormToolStripButton As ToolStripButton
    Friend WithEvents CloseToolStripLabel As ToolStripLabel
    Friend WithEvents chklineIteminvoiced As CheckBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colQtyperUoM As DataGridViewTextBoxColumn
    Friend WithEvents colUnits As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colTotalprice As DataGridViewTextBoxColumn
    Friend WithEvents chkMeterinvoiced As CheckBox
    Friend WithEvents txtNil As TextBox
    Friend WithEvents cboVat As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVatRate As TextBox
    Friend WithEvents txtVatNo As TextBox
End Class
