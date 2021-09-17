<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvoicing
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoicing))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQtyperUoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblScheme = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.SchemeIDtxt = New System.Windows.Forms.TextBox()
        Me.lbldate = New System.Windows.Forms.DateTimePicker()
        Me.SchemeRefNotxt = New System.Windows.Forms.TextBox()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtConstituencyname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSubcontractor = New System.Windows.Forms.TextBox()
        Me.txtSchemeName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTXNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkMeteringcomplete = New System.Windows.Forms.CheckBox()
        Me.Details = New System.Windows.Forms.GroupBox()
        Me.cboVat = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtVatRate = New System.Windows.Forms.TextBox()
        Me.txtVatNo = New System.Windows.Forms.TextBox()
        Me.cboSubcontractor = New System.Windows.Forms.TextBox()
        Me.btnLoadSubcontractor = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmeterinstalled = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustomerNo = New System.Windows.Forms.TextBox()
        Me.chkEnableschemes = New System.Windows.Forms.CheckBox()
        Me.btnItemswithoutMetering = New System.Windows.Forms.Button()
        Me.btnLoadSchemes = New System.Windows.Forms.Button()
        Me.GrpbxPolessummary = New System.Windows.Forms.GroupBox()
        Me.txtLVStayRod = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtMVstaywire = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtMVConductor = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtPME = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtLVstaywire = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtstayinsulator = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtMVstayrod = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtLVConductor = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtMVWP = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtMVCP = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtWPLV = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtLVCP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPolesInstalled = New System.Windows.Forms.TextBox()
        Me.chkLineItemInstalled = New System.Windows.Forms.CheckBox()
        Me.chkMeterDone = New System.Windows.Forms.CheckBox()
        Me.lblTotalAmt = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PSaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ClearToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CloseToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.txtNil = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblTotalincvat = New System.Windows.Forms.Label()
        Me.chkLineInstallation = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt11MPoles = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt12MPoles = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt10MCP = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtCPWE = New System.Windows.Forms.TextBox()
        Me.txt11MCP = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt12MCP = New System.Windows.Forms.TextBox()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Details.SuspendLayout()
        Me.GrpbxPolessummary.SuspendLayout()
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
        Me.TextBox1.Size = New System.Drawing.Size(812, 28)
        Me.TextBox1.TabIndex = 140
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(377, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 16)
        Me.Label2.TabIndex = 223
        Me.Label2.Text = "Sub-Contractor Statement"
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        Me.dgw.AllowUserToOrderColumns = True
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
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.colQtyperUoM, Me.colUnits, Me.colQty, Me.colTotalprice})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(2, 102)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
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
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(811, 351)
        Me.dgw.TabIndex = 225
        '
        'Column7
        '
        Me.Column7.HeaderText = "BOQ No"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 75
        '
        'Column1
        '
        Me.Column1.HeaderText = "BOQ Description"
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(530, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 14)
        Me.Label19.TabIndex = 246
        Me.Label19.Text = "Date:"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(774, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 250
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(251, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 263
        Me.Label1.Text = "Z-Ref"
        '
        'txtCountyID
        '
        Me.txtCountyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCountyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCountyID.Enabled = False
        Me.txtCountyID.Location = New System.Drawing.Point(324, 12)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(13, 20)
        Me.txtCountyID.TabIndex = 266
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyID.Enabled = False
        Me.txtConstituencyID.Location = New System.Drawing.Point(343, 12)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(10, 20)
        Me.txtConstituencyID.TabIndex = 267
        '
        'SchemeIDtxt
        '
        Me.SchemeIDtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SchemeIDtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SchemeIDtxt.Enabled = False
        Me.SchemeIDtxt.Location = New System.Drawing.Point(668, 338)
        Me.SchemeIDtxt.Name = "SchemeIDtxt"
        Me.SchemeIDtxt.Size = New System.Drawing.Size(79, 20)
        Me.SchemeIDtxt.TabIndex = 265
        '
        'lbldate
        '
        Me.lbldate.CustomFormat = "MM/dd/yyyy"
        Me.lbldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.lbldate.Location = New System.Drawing.Point(567, 13)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(111, 20)
        Me.lbldate.TabIndex = 268
        '
        'SchemeRefNotxt
        '
        Me.SchemeRefNotxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SchemeRefNotxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SchemeRefNotxt.Location = New System.Drawing.Point(291, 12)
        Me.SchemeRefNotxt.Name = "SchemeRefNotxt"
        Me.SchemeRefNotxt.Size = New System.Drawing.Size(102, 20)
        Me.SchemeRefNotxt.TabIndex = 261
        '
        'txtCounty
        '
        Me.txtCounty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCounty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCounty.Enabled = False
        Me.txtCounty.Location = New System.Drawing.Point(453, 40)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(71, 20)
        Me.txtCounty.TabIndex = 275
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(398, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 14)
        Me.Label9.TabIndex = 276
        Me.Label9.Text = "County:"
        '
        'txtConstituencyname
        '
        Me.txtConstituencyname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyname.Enabled = False
        Me.txtConstituencyname.Location = New System.Drawing.Point(453, 13)
        Me.txtConstituencyname.Name = "txtConstituencyname"
        Me.txtConstituencyname.Size = New System.Drawing.Size(71, 20)
        Me.txtConstituencyname.TabIndex = 277
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(399, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 14)
        Me.Label10.TabIndex = 278
        Me.Label10.Text = "Consty:"
        '
        'txtSubcontractor
        '
        Me.txtSubcontractor.Location = New System.Drawing.Point(180, 14)
        Me.txtSubcontractor.Name = "txtSubcontractor"
        Me.txtSubcontractor.Size = New System.Drawing.Size(16, 20)
        Me.txtSubcontractor.TabIndex = 281
        '
        'txtSchemeName
        '
        Me.txtSchemeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeName.Enabled = False
        Me.txtSchemeName.Location = New System.Drawing.Point(58, 40)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(138, 20)
        Me.txtSchemeName.TabIndex = 284
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(252, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 14)
        Me.Label11.TabIndex = 285
        Me.Label11.Text = "TX:"
        '
        'txtTXNo
        '
        Me.txtTXNo.Enabled = False
        Me.txtTXNo.Location = New System.Drawing.Point(291, 42)
        Me.txtTXNo.Name = "txtTXNo"
        Me.txtTXNo.Size = New System.Drawing.Size(102, 20)
        Me.txtTXNo.TabIndex = 286
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 14)
        Me.Label6.TabIndex = 287
        Me.Label6.Text = "Contrct:"
        '
        'chkMeteringcomplete
        '
        Me.chkMeteringcomplete.AutoSize = True
        Me.chkMeteringcomplete.BackColor = System.Drawing.Color.Red
        Me.chkMeteringcomplete.Location = New System.Drawing.Point(673, 132)
        Me.chkMeteringcomplete.Name = "chkMeteringcomplete"
        Me.chkMeteringcomplete.Size = New System.Drawing.Size(95, 17)
        Me.chkMeteringcomplete.TabIndex = 288
        Me.chkMeteringcomplete.Text = "Metering Billed"
        Me.chkMeteringcomplete.UseVisualStyleBackColor = False
        '
        'Details
        '
        Me.Details.Controls.Add(Me.cboVat)
        Me.Details.Controls.Add(Me.Label25)
        Me.Details.Controls.Add(Me.txtVatRate)
        Me.Details.Controls.Add(Me.txtVatNo)
        Me.Details.Controls.Add(Me.cboSubcontractor)
        Me.Details.Controls.Add(Me.btnLoadSubcontractor)
        Me.Details.Controls.Add(Me.Label5)
        Me.Details.Controls.Add(Me.txtmeterinstalled)
        Me.Details.Controls.Add(Me.Label3)
        Me.Details.Controls.Add(Me.txtCustomerNo)
        Me.Details.Controls.Add(Me.chkEnableschemes)
        Me.Details.Controls.Add(Me.btnItemswithoutMetering)
        Me.Details.Controls.Add(Me.Label6)
        Me.Details.Controls.Add(Me.txtTXNo)
        Me.Details.Controls.Add(Me.Label11)
        Me.Details.Controls.Add(Me.txtConstituencyname)
        Me.Details.Controls.Add(Me.Label10)
        Me.Details.Controls.Add(Me.txtCounty)
        Me.Details.Controls.Add(Me.Label9)
        Me.Details.Controls.Add(Me.txtSchemeName)
        Me.Details.Controls.Add(Me.btnLoadSchemes)
        Me.Details.Controls.Add(Me.txtSubcontractor)
        Me.Details.Controls.Add(Me.SchemeRefNotxt)
        Me.Details.Controls.Add(Me.lbldate)
        Me.Details.Controls.Add(Me.txtConstituencyID)
        Me.Details.Controls.Add(Me.txtCountyID)
        Me.Details.Controls.Add(Me.Label1)
        Me.Details.Controls.Add(Me.Label7)
        Me.Details.Controls.Add(Me.lblScheme)
        Me.Details.Controls.Add(Me.Label19)
        Me.Details.Location = New System.Drawing.Point(1, 28)
        Me.Details.Name = "Details"
        Me.Details.Size = New System.Drawing.Size(812, 68)
        Me.Details.TabIndex = 224
        Me.Details.TabStop = False
        Me.Details.Text = "Details"
        '
        'cboVat
        '
        Me.cboVat.FormattingEnabled = True
        Me.cboVat.Location = New System.Drawing.Point(715, 12)
        Me.cboVat.Name = "cboVat"
        Me.cboVat.Size = New System.Drawing.Size(91, 21)
        Me.cboVat.TabIndex = 322
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Red
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(684, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(25, 14)
        Me.Label25.TabIndex = 321
        Me.Label25.Text = "Vat:"
        '
        'txtVatRate
        '
        Me.txtVatRate.Enabled = False
        Me.txtVatRate.Location = New System.Drawing.Point(739, 12)
        Me.txtVatRate.Name = "txtVatRate"
        Me.txtVatRate.Size = New System.Drawing.Size(22, 20)
        Me.txtVatRate.TabIndex = 324
        '
        'txtVatNo
        '
        Me.txtVatNo.Enabled = False
        Me.txtVatNo.Location = New System.Drawing.Point(766, 13)
        Me.txtVatNo.Name = "txtVatNo"
        Me.txtVatNo.Size = New System.Drawing.Size(13, 20)
        Me.txtVatNo.TabIndex = 323
        '
        'cboSubcontractor
        '
        Me.cboSubcontractor.Enabled = False
        Me.cboSubcontractor.Location = New System.Drawing.Point(58, 14)
        Me.cboSubcontractor.Name = "cboSubcontractor"
        Me.cboSubcontractor.Size = New System.Drawing.Size(159, 20)
        Me.cboSubcontractor.TabIndex = 310
        '
        'btnLoadSubcontractor
        '
        Me.btnLoadSubcontractor.BackColor = System.Drawing.Color.DarkGray
        Me.btnLoadSubcontractor.BackgroundImage = CType(resources.GetObject("btnLoadSubcontractor.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadSubcontractor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadSubcontractor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSubcontractor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSubcontractor.Location = New System.Drawing.Point(223, 16)
        Me.btnLoadSubcontractor.Name = "btnLoadSubcontractor"
        Me.btnLoadSubcontractor.Size = New System.Drawing.Size(22, 17)
        Me.btnLoadSubcontractor.TabIndex = 309
        Me.btnLoadSubcontractor.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(601, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 14)
        Me.Label5.TabIndex = 302
        Me.Label5.Text = "Mtrs:"
        '
        'txtmeterinstalled
        '
        Me.txtmeterinstalled.Enabled = False
        Me.txtmeterinstalled.Location = New System.Drawing.Point(639, 40)
        Me.txtmeterinstalled.Name = "txtmeterinstalled"
        Me.txtmeterinstalled.Size = New System.Drawing.Size(39, 20)
        Me.txtmeterinstalled.TabIndex = 299
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(530, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 14)
        Me.Label3.TabIndex = 298
        Me.Label3.Text = "Cust:"
        '
        'txtCustomerNo
        '
        Me.txtCustomerNo.Enabled = False
        Me.txtCustomerNo.Location = New System.Drawing.Point(567, 41)
        Me.txtCustomerNo.Name = "txtCustomerNo"
        Me.txtCustomerNo.Size = New System.Drawing.Size(28, 20)
        Me.txtCustomerNo.TabIndex = 297
        '
        'chkEnableschemes
        '
        Me.chkEnableschemes.AutoSize = True
        Me.chkEnableschemes.Location = New System.Drawing.Point(230, 45)
        Me.chkEnableschemes.Name = "chkEnableschemes"
        Me.chkEnableschemes.Size = New System.Drawing.Size(15, 14)
        Me.chkEnableschemes.TabIndex = 296
        Me.chkEnableschemes.UseVisualStyleBackColor = True
        '
        'btnItemswithoutMetering
        '
        Me.btnItemswithoutMetering.BackColor = System.Drawing.Color.Cyan
        Me.btnItemswithoutMetering.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemswithoutMetering.Location = New System.Drawing.Point(713, 35)
        Me.btnItemswithoutMetering.Name = "btnItemswithoutMetering"
        Me.btnItemswithoutMetering.Size = New System.Drawing.Size(93, 28)
        Me.btnItemswithoutMetering.TabIndex = 293
        Me.btnItemswithoutMetering.Text = "Load BOQs "
        Me.btnItemswithoutMetering.UseVisualStyleBackColor = False
        '
        'btnLoadSchemes
        '
        Me.btnLoadSchemes.BackColor = System.Drawing.Color.DarkGray
        Me.btnLoadSchemes.BackgroundImage = CType(resources.GetObject("btnLoadSchemes.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadSchemes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadSchemes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSchemes.Enabled = False
        Me.btnLoadSchemes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSchemes.Location = New System.Drawing.Point(202, 42)
        Me.btnLoadSchemes.Name = "btnLoadSchemes"
        Me.btnLoadSchemes.Size = New System.Drawing.Size(22, 17)
        Me.btnLoadSchemes.TabIndex = 283
        Me.btnLoadSchemes.UseVisualStyleBackColor = False
        '
        'GrpbxPolessummary
        '
        Me.GrpbxPolessummary.BackColor = System.Drawing.Color.Khaki
        Me.GrpbxPolessummary.Controls.Add(Me.txtLVStayRod)
        Me.GrpbxPolessummary.Controls.Add(Me.Label33)
        Me.GrpbxPolessummary.Controls.Add(Me.txtMVstaywire)
        Me.GrpbxPolessummary.Controls.Add(Me.Label32)
        Me.GrpbxPolessummary.Controls.Add(Me.txtMVConductor)
        Me.GrpbxPolessummary.Controls.Add(Me.Label31)
        Me.GrpbxPolessummary.Controls.Add(Me.txtPME)
        Me.GrpbxPolessummary.Controls.Add(Me.Label30)
        Me.GrpbxPolessummary.Controls.Add(Me.txtLVstaywire)
        Me.GrpbxPolessummary.Controls.Add(Me.Label29)
        Me.GrpbxPolessummary.Controls.Add(Me.txtstayinsulator)
        Me.GrpbxPolessummary.Controls.Add(Me.Label28)
        Me.GrpbxPolessummary.Controls.Add(Me.txtMVstayrod)
        Me.GrpbxPolessummary.Controls.Add(Me.Label27)
        Me.GrpbxPolessummary.Controls.Add(Me.txtLVConductor)
        Me.GrpbxPolessummary.Controls.Add(Me.Label26)
        Me.GrpbxPolessummary.Controls.Add(Me.txtMVWP)
        Me.GrpbxPolessummary.Controls.Add(Me.Label22)
        Me.GrpbxPolessummary.Controls.Add(Me.txtMVCP)
        Me.GrpbxPolessummary.Controls.Add(Me.Label23)
        Me.GrpbxPolessummary.Controls.Add(Me.Label20)
        Me.GrpbxPolessummary.Controls.Add(Me.txtWPLV)
        Me.GrpbxPolessummary.Controls.Add(Me.Label21)
        Me.GrpbxPolessummary.Controls.Add(Me.txtLVCP)
        Me.GrpbxPolessummary.Location = New System.Drawing.Point(819, 5)
        Me.GrpbxPolessummary.Name = "GrpbxPolessummary"
        Me.GrpbxPolessummary.Size = New System.Drawing.Size(168, 323)
        Me.GrpbxPolessummary.TabIndex = 300
        Me.GrpbxPolessummary.TabStop = False
        Me.GrpbxPolessummary.Text = "Material Issuance Summary"
        '
        'txtLVStayRod
        '
        Me.txtLVStayRod.Enabled = False
        Me.txtLVStayRod.Location = New System.Drawing.Point(64, 160)
        Me.txtLVStayRod.Name = "txtLVStayRod"
        Me.txtLVStayRod.Size = New System.Drawing.Size(79, 20)
        Me.txtLVStayRod.TabIndex = 333
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(2, 164)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(55, 12)
        Me.Label33.TabIndex = 334
        Me.Label33.Text = "Stay Rod LV:"
        '
        'txtMVstaywire
        '
        Me.txtMVstaywire.Enabled = False
        Me.txtMVstaywire.Location = New System.Drawing.Point(64, 238)
        Me.txtMVstaywire.Name = "txtMVstaywire"
        Me.txtMVstaywire.Size = New System.Drawing.Size(78, 20)
        Me.txtMVstaywire.TabIndex = 331
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(1, 243)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(62, 12)
        Me.Label32.TabIndex = 332
        Me.Label32.Text = "MV Stay Wire:"
        '
        'txtMVConductor
        '
        Me.txtMVConductor.Enabled = False
        Me.txtMVConductor.Location = New System.Drawing.Point(64, 133)
        Me.txtMVConductor.Name = "txtMVConductor"
        Me.txtMVConductor.Size = New System.Drawing.Size(78, 20)
        Me.txtMVConductor.TabIndex = 329
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(0, 137)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(65, 12)
        Me.Label31.TabIndex = 330
        Me.Label31.Text = "MV Conductor:"
        '
        'txtPME
        '
        Me.txtPME.Enabled = False
        Me.txtPME.Location = New System.Drawing.Point(64, 264)
        Me.txtPME.Name = "txtPME"
        Me.txtPME.Size = New System.Drawing.Size(78, 20)
        Me.txtPME.TabIndex = 327
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(1, 268)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(28, 12)
        Me.Label30.TabIndex = 328
        Me.Label30.Text = "PME:"
        '
        'txtLVstaywire
        '
        Me.txtLVstaywire.Enabled = False
        Me.txtLVstaywire.Location = New System.Drawing.Point(64, 212)
        Me.txtLVstaywire.Name = "txtLVstaywire"
        Me.txtLVstaywire.Size = New System.Drawing.Size(78, 20)
        Me.txtLVstaywire.TabIndex = 325
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(1, 216)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 12)
        Me.Label29.TabIndex = 326
        Me.Label29.Text = "LV Stay Wire:"
        '
        'txtstayinsulator
        '
        Me.txtstayinsulator.Enabled = False
        Me.txtstayinsulator.Location = New System.Drawing.Point(64, 290)
        Me.txtstayinsulator.Name = "txtstayinsulator"
        Me.txtstayinsulator.Size = New System.Drawing.Size(78, 20)
        Me.txtstayinsulator.TabIndex = 323
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(0, 294)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 12)
        Me.Label28.TabIndex = 324
        Me.Label28.Text = "Stay Insulator:"
        '
        'txtMVstayrod
        '
        Me.txtMVstayrod.Enabled = False
        Me.txtMVstayrod.Location = New System.Drawing.Point(64, 186)
        Me.txtMVstayrod.Name = "txtMVstayrod"
        Me.txtMVstayrod.Size = New System.Drawing.Size(78, 20)
        Me.txtMVstayrod.TabIndex = 321
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(2, 190)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(58, 12)
        Me.Label27.TabIndex = 322
        Me.Label27.Text = "Stay Rod MV:"
        '
        'txtLVConductor
        '
        Me.txtLVConductor.Enabled = False
        Me.txtLVConductor.Location = New System.Drawing.Point(64, 110)
        Me.txtLVConductor.Name = "txtLVConductor"
        Me.txtLVConductor.Size = New System.Drawing.Size(78, 20)
        Me.txtLVConductor.TabIndex = 319
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(0, 114)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 12)
        Me.Label26.TabIndex = 320
        Me.Label26.Text = "LV Conductor:"
        '
        'txtMVWP
        '
        Me.txtMVWP.Enabled = False
        Me.txtMVWP.Location = New System.Drawing.Point(64, 37)
        Me.txtMVWP.Name = "txtMVWP"
        Me.txtMVWP.Size = New System.Drawing.Size(78, 20)
        Me.txtMVWP.TabIndex = 315
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(0, 39)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 12)
        Me.Label22.TabIndex = 316
        Me.Label22.Text = "MV WP:"
        '
        'txtMVCP
        '
        Me.txtMVCP.Enabled = False
        Me.txtMVCP.Location = New System.Drawing.Point(64, 87)
        Me.txtMVCP.Name = "txtMVCP"
        Me.txtMVCP.Size = New System.Drawing.Size(78, 20)
        Me.txtMVCP.TabIndex = 317
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(1, 91)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 12)
        Me.Label23.TabIndex = 318
        Me.Label23.Text = "MV CP:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(1, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 12)
        Me.Label20.TabIndex = 312
        Me.Label20.Text = "LV WP:"
        '
        'txtWPLV
        '
        Me.txtWPLV.Enabled = False
        Me.txtWPLV.Location = New System.Drawing.Point(64, 14)
        Me.txtWPLV.Name = "txtWPLV"
        Me.txtWPLV.Size = New System.Drawing.Size(78, 20)
        Me.txtWPLV.TabIndex = 311
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(1, 66)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 12)
        Me.Label21.TabIndex = 314
        Me.Label21.Text = "LV CP:"
        '
        'txtLVCP
        '
        Me.txtLVCP.Enabled = False
        Me.txtLVCP.Location = New System.Drawing.Point(64, 62)
        Me.txtLVCP.Name = "txtLVCP"
        Me.txtLVCP.Size = New System.Drawing.Size(78, 20)
        Me.txtLVCP.TabIndex = 313
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(666, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 12)
        Me.Label4.TabIndex = 301
        Me.Label4.Text = "10m WP:"
        Me.Label4.Visible = False
        '
        'txtPolesInstalled
        '
        Me.txtPolesInstalled.Enabled = False
        Me.txtPolesInstalled.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPolesInstalled.Location = New System.Drawing.Point(716, 207)
        Me.txtPolesInstalled.Multiline = True
        Me.txtPolesInstalled.Name = "txtPolesInstalled"
        Me.txtPolesInstalled.Size = New System.Drawing.Size(23, 15)
        Me.txtPolesInstalled.TabIndex = 300
        Me.txtPolesInstalled.Visible = False
        '
        'chkLineItemInstalled
        '
        Me.chkLineItemInstalled.AutoSize = True
        Me.chkLineItemInstalled.BackColor = System.Drawing.Color.Red
        Me.chkLineItemInstalled.Location = New System.Drawing.Point(673, 155)
        Me.chkLineItemInstalled.Name = "chkLineItemInstalled"
        Me.chkLineItemInstalled.Size = New System.Drawing.Size(94, 17)
        Me.chkLineItemInstalled.TabIndex = 295
        Me.chkLineItemInstalled.Text = "LineItem Billed"
        Me.chkLineItemInstalled.UseVisualStyleBackColor = False
        '
        'chkMeterDone
        '
        Me.chkMeterDone.AutoSize = True
        Me.chkMeterDone.BackColor = System.Drawing.Color.White
        Me.chkMeterDone.Location = New System.Drawing.Point(360, 123)
        Me.chkMeterDone.Name = "chkMeterDone"
        Me.chkMeterDone.Size = New System.Drawing.Size(100, 17)
        Me.chkMeterDone.TabIndex = 293
        Me.chkMeterDone.Text = "Metering Status"
        Me.chkMeterDone.UseVisualStyleBackColor = False
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.AutoSize = True
        Me.lblTotalAmt.BackColor = System.Drawing.Color.Aqua
        Me.lblTotalAmt.Location = New System.Drawing.Point(886, 338)
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(97, 13)
        Me.lblTotalAmt.TabIndex = 226
        Me.lblTotalAmt.Text = "+++++++++++++++"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PSaveToolStripButton, Me.ClearToolStripButton, Me.CloseToolStripLabel})
        Me.ToolStrip1.Location = New System.Drawing.Point(816, 414)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(171, 35)
        Me.ToolStrip1.TabIndex = 251
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'PSaveToolStripButton
        '
        Me.PSaveToolStripButton.Image = CType(resources.GetObject("PSaveToolStripButton.Image"), System.Drawing.Image)
        Me.PSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PSaveToolStripButton.Name = "PSaveToolStripButton"
        Me.PSaveToolStripButton.Size = New System.Drawing.Size(51, 32)
        Me.PSaveToolStripButton.Text = "Save"
        '
        'ClearToolStripButton
        '
        Me.ClearToolStripButton.AutoSize = False
        Me.ClearToolStripButton.Image = CType(resources.GetObject("ClearToolStripButton.Image"), System.Drawing.Image)
        Me.ClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearToolStripButton.Name = "ClearToolStripButton"
        Me.ClearToolStripButton.Size = New System.Drawing.Size(65, 40)
        Me.ClearToolStripButton.Text = "Reset"
        '
        'CloseToolStripLabel
        '
        Me.CloseToolStripLabel.Name = "CloseToolStripLabel"
        Me.CloseToolStripLabel.Size = New System.Drawing.Size(36, 32)
        Me.CloseToolStripLabel.Text = "Close"
        '
        'txtNil
        '
        Me.txtNil.Enabled = False
        Me.txtNil.Location = New System.Drawing.Point(454, 402)
        Me.txtNil.Name = "txtNil"
        Me.txtNil.Size = New System.Drawing.Size(24, 20)
        Me.txtNil.TabIndex = 293
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(820, 338)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 294
        Me.Label14.Text = "Total:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(820, 358)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 295
        Me.Label15.Text = "Vat:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(820, 380)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 296
        Me.Label16.Text = "Tot+ Vat:"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.BackColor = System.Drawing.Color.Aqua
        Me.lblVat.Location = New System.Drawing.Point(886, 358)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(97, 13)
        Me.lblVat.TabIndex = 297
        Me.lblVat.Text = "+++++++++++++++"
        '
        'lblTotalincvat
        '
        Me.lblTotalincvat.AutoSize = True
        Me.lblTotalincvat.BackColor = System.Drawing.Color.Aqua
        Me.lblTotalincvat.Location = New System.Drawing.Point(886, 380)
        Me.lblTotalincvat.Name = "lblTotalincvat"
        Me.lblTotalincvat.Size = New System.Drawing.Size(97, 13)
        Me.lblTotalincvat.TabIndex = 298
        Me.lblTotalincvat.Text = "+++++++++++++++"
        '
        'chkLineInstallation
        '
        Me.chkLineInstallation.AutoSize = True
        Me.chkLineInstallation.BackColor = System.Drawing.Color.White
        Me.chkLineInstallation.Location = New System.Drawing.Point(488, 123)
        Me.chkLineInstallation.Name = "chkLineInstallation"
        Me.chkLineInstallation.Size = New System.Drawing.Size(132, 17)
        Me.chkLineInstallation.TabIndex = 299
        Me.chkLineInstallation.Text = "Line Installation Status"
        Me.chkLineInstallation.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(666, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 12)
        Me.Label8.TabIndex = 304
        Me.Label8.Text = "11m WP:"
        Me.Label8.Visible = False
        '
        'txt11MPoles
        '
        Me.txt11MPoles.Enabled = False
        Me.txt11MPoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt11MPoles.Location = New System.Drawing.Point(716, 232)
        Me.txt11MPoles.Multiline = True
        Me.txt11MPoles.Name = "txt11MPoles"
        Me.txt11MPoles.Size = New System.Drawing.Size(23, 16)
        Me.txt11MPoles.TabIndex = 303
        Me.txt11MPoles.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(666, 251)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 12)
        Me.Label12.TabIndex = 306
        Me.Label12.Text = "12m WP:"
        Me.Label12.Visible = False
        '
        'txt12MPoles
        '
        Me.txt12MPoles.Enabled = False
        Me.txt12MPoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt12MPoles.Location = New System.Drawing.Point(716, 251)
        Me.txt12MPoles.Multiline = True
        Me.txt12MPoles.Name = "txt12MPoles"
        Me.txt12MPoles.Size = New System.Drawing.Size(23, 16)
        Me.txt12MPoles.TabIndex = 305
        Me.txt12MPoles.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(661, 273)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 12)
        Me.Label13.TabIndex = 308
        Me.Label13.Text = "10m CP:"
        Me.Label13.Visible = False
        '
        'txt10MCP
        '
        Me.txt10MCP.Enabled = False
        Me.txt10MCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt10MCP.Location = New System.Drawing.Point(715, 271)
        Me.txt10MCP.Name = "txt10MCP"
        Me.txt10MCP.Size = New System.Drawing.Size(23, 18)
        Me.txt10MCP.TabIndex = 307
        Me.txt10MCP.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(639, 181)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(69, 12)
        Me.Label24.TabIndex = 314
        Me.Label24.Text = "10m CPW/E:"
        Me.Label24.Visible = False
        '
        'txtCPWE
        '
        Me.txtCPWE.Enabled = False
        Me.txtCPWE.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPWE.Location = New System.Drawing.Point(714, 178)
        Me.txtCPWE.Name = "txtCPWE"
        Me.txtCPWE.Size = New System.Drawing.Size(23, 18)
        Me.txtCPWE.TabIndex = 313
        Me.txtCPWE.Visible = False
        '
        'txt11MCP
        '
        Me.txt11MCP.Enabled = False
        Me.txt11MCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt11MCP.Location = New System.Drawing.Point(715, 294)
        Me.txt11MCP.Multiline = True
        Me.txt11MCP.Name = "txt11MCP"
        Me.txt11MCP.Size = New System.Drawing.Size(23, 16)
        Me.txt11MCP.TabIndex = 309
        Me.txt11MCP.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(661, 295)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 12)
        Me.Label17.TabIndex = 310
        Me.Label17.Text = "11m CP:"
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(660, 316)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 12)
        Me.Label18.TabIndex = 312
        Me.Label18.Text = "12m CP:"
        Me.Label18.Visible = False
        '
        'txt12MCP
        '
        Me.txt12MCP.Enabled = False
        Me.txt12MCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt12MCP.Location = New System.Drawing.Point(714, 316)
        Me.txt12MCP.Multiline = True
        Me.txt12MCP.Name = "txt12MCP"
        Me.txt12MCP.Size = New System.Drawing.Size(23, 16)
        Me.txt12MCP.TabIndex = 311
        Me.txt12MCP.Visible = False
        '
        'frmInvoicing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(989, 458)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.lblTotalincvat)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblVat)
        Me.Controls.Add(Me.lblTotalAmt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtNil)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Details)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GrpbxPolessummary)
        Me.Controls.Add(Me.txt12MPoles)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.chkMeterDone)
        Me.Controls.Add(Me.chkLineInstallation)
        Me.Controls.Add(Me.chkMeteringcomplete)
        Me.Controls.Add(Me.chkLineItemInstalled)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtCPWE)
        Me.Controls.Add(Me.txt11MCP)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt12MCP)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt10MCP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPolesInstalled)
        Me.Controls.Add(Me.txt11MPoles)
        Me.Controls.Add(Me.SchemeIDtxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmInvoicing"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Details.ResumeLayout(False)
        Me.Details.PerformLayout()
        Me.GrpbxPolessummary.ResumeLayout(False)
        Me.GrpbxPolessummary.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgw As DataGridView
    Friend WithEvents Label19 As Label
    Friend WithEvents lblScheme As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents SchemeIDtxt As TextBox
    Friend WithEvents lbldate As DateTimePicker
    Friend WithEvents SchemeRefNotxt As TextBox
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtConstituencyname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSubcontractor As TextBox
    Friend WithEvents btnLoadSchemes As Button
    Friend WithEvents txtSchemeName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTXNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkMeteringcomplete As CheckBox
    Friend WithEvents Details As GroupBox
    Friend WithEvents lblTotalAmt As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents PSaveToolStripButton As ToolStripButton
    Friend WithEvents ClearToolStripButton As ToolStripButton
    Friend WithEvents txtNil As TextBox
    Friend WithEvents chkMeterDone As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents lblTotalincvat As Label
    Friend WithEvents btnItemswithoutMetering As Button
    Friend WithEvents CloseToolStripLabel As ToolStripLabel
    Friend WithEvents chkLineItemInstalled As CheckBox
    Friend WithEvents chkLineInstallation As CheckBox
    Friend WithEvents chkEnableschemes As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustomerNo As TextBox
    Friend WithEvents txtmeterinstalled As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPolesInstalled As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt10MCP As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt12MPoles As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt11MPoles As TextBox
    Friend WithEvents btnLoadSubcontractor As Button
    Friend WithEvents cboSubcontractor As TextBox
    Friend WithEvents GrpbxPolessummary As GroupBox
    Friend WithEvents txt11MCP As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt12MCP As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtMVCP As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtMVWP As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtLVCP As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtWPLV As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtCPWE As TextBox
    Friend WithEvents cboVat As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtVatRate As TextBox
    Friend WithEvents txtVatNo As TextBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colQtyperUoM As DataGridViewTextBoxColumn
    Friend WithEvents colUnits As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colTotalprice As DataGridViewTextBoxColumn
    Friend WithEvents txtMVstayrod As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtLVConductor As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtMVConductor As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtPME As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtLVstaywire As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtstayinsulator As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtMVstaywire As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtLVStayRod As TextBox
    Friend WithEvents Label33 As Label
End Class
