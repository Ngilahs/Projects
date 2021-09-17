<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvoiceUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceUpdate))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Details = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboVat = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtVatRate = New System.Windows.Forms.TextBox()
        Me.txtVatNo = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LblBillNo = New System.Windows.Forms.Label()
        Me.txtBillingItemNo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtrevisedQty = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtunitrt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtqtyinvoiced = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTXNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtConstituencyname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSchemeName = New System.Windows.Forms.TextBox()
        Me.btnLoadSchemes = New System.Windows.Forms.Button()
        Me.cboSubcontractor = New System.Windows.Forms.ComboBox()
        Me.txtSubcontractor = New System.Windows.Forms.TextBox()
        Me.txtSchemeRefNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.DateTimePicker()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.txtUnitofIssue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.cmdSearchItems = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblScheme = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.chkMeteringcomplete = New System.Windows.Forms.CheckBox()
        Me.lblTotalincvat = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblTotalAmt = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.colInvoiceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQtyperUoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBillingItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtNil = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpboxenablestatementno = New System.Windows.Forms.GroupBox()
        Me.btnEnablestatement = New System.Windows.Forms.Button()
        Me.txtapprove = New System.Windows.Forms.TextBox()
        Me.txtStatementNo = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtcancel = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtschmname = New System.Windows.Forms.TextBox()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.dgw1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtLVConductor = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtMVWP = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtMVCP = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtWPLV = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtLVCP = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txt12MPoles = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtCPWE = New System.Windows.Forms.TextBox()
        Me.txt11MCP = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txt12MCP = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txt10MCP = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtPolesInstalled = New System.Windows.Forms.TextBox()
        Me.txt11MPoles = New System.Windows.Forms.TextBox()
        Me.Details.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpboxenablestatementno.SuspendLayout()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpbxPolessummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'Details
        '
        Me.Details.Controls.Add(Me.Label23)
        Me.Details.Controls.Add(Me.cboVat)
        Me.Details.Controls.Add(Me.Label27)
        Me.Details.Controls.Add(Me.txtVatRate)
        Me.Details.Controls.Add(Me.txtVatNo)
        Me.Details.Controls.Add(Me.Label26)
        Me.Details.Controls.Add(Me.LblBillNo)
        Me.Details.Controls.Add(Me.txtBillingItemNo)
        Me.Details.Controls.Add(Me.Label18)
        Me.Details.Controls.Add(Me.txtrevisedQty)
        Me.Details.Controls.Add(Me.Label13)
        Me.Details.Controls.Add(Me.txtTotal)
        Me.Details.Controls.Add(Me.txtunitrt)
        Me.Details.Controls.Add(Me.Label12)
        Me.Details.Controls.Add(Me.Label6)
        Me.Details.Controls.Add(Me.txtqtyinvoiced)
        Me.Details.Controls.Add(Me.Label4)
        Me.Details.Controls.Add(Me.txtTXNo)
        Me.Details.Controls.Add(Me.Label11)
        Me.Details.Controls.Add(Me.txtConstituencyname)
        Me.Details.Controls.Add(Me.Label10)
        Me.Details.Controls.Add(Me.txtCounty)
        Me.Details.Controls.Add(Me.Label9)
        Me.Details.Controls.Add(Me.txtSchemeName)
        Me.Details.Controls.Add(Me.btnLoadSchemes)
        Me.Details.Controls.Add(Me.cboSubcontractor)
        Me.Details.Controls.Add(Me.txtSubcontractor)
        Me.Details.Controls.Add(Me.txtSchemeRefNo)
        Me.Details.Controls.Add(Me.Label8)
        Me.Details.Controls.Add(Me.lbldate)
        Me.Details.Controls.Add(Me.txtSchemeID)
        Me.Details.Controls.Add(Me.txtConstituencyID)
        Me.Details.Controls.Add(Me.txtCountyID)
        Me.Details.Controls.Add(Me.txtUnitofIssue)
        Me.Details.Controls.Add(Me.Label1)
        Me.Details.Controls.Add(Me.btnCompute)
        Me.Details.Controls.Add(Me.cmdSearchItems)
        Me.Details.Controls.Add(Me.Label5)
        Me.Details.Controls.Add(Me.Label3)
        Me.Details.Controls.Add(Me.Label7)
        Me.Details.Controls.Add(Me.lblScheme)
        Me.Details.Controls.Add(Me.Label19)
        Me.Details.Controls.Add(Me.txtItemCode)
        Me.Details.Location = New System.Drawing.Point(3, 45)
        Me.Details.Name = "Details"
        Me.Details.Size = New System.Drawing.Size(660, 124)
        Me.Details.TabIndex = 225
        Me.Details.TabStop = False
        Me.Details.Text = "Details"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(574, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 12)
        Me.Label23.TabIndex = 305
        Me.Label23.Text = "Stmnt No:"
        '
        'cboVat
        '
        Me.cboVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVat.FormattingEnabled = True
        Me.cboVat.Location = New System.Drawing.Point(464, 92)
        Me.cboVat.Name = "cboVat"
        Me.cboVat.Size = New System.Drawing.Size(102, 20)
        Me.cboVat.TabIndex = 326
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Red
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(433, 98)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(23, 12)
        Me.Label27.TabIndex = 325
        Me.Label27.Text = "Vat:"
        '
        'txtVatRate
        '
        Me.txtVatRate.Enabled = False
        Me.txtVatRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVatRate.Location = New System.Drawing.Point(506, 94)
        Me.txtVatRate.Name = "txtVatRate"
        Me.txtVatRate.Size = New System.Drawing.Size(22, 18)
        Me.txtVatRate.TabIndex = 328
        '
        'txtVatNo
        '
        Me.txtVatNo.Enabled = False
        Me.txtVatNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVatNo.Location = New System.Drawing.Point(531, 94)
        Me.txtVatNo.Name = "txtVatNo"
        Me.txtVatNo.Size = New System.Drawing.Size(13, 18)
        Me.txtVatNo.TabIndex = 327
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(300, 99)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(26, 12)
        Me.Label26.TabIndex = 308
        Me.Label26.Text = "SNo:"
        '
        'LblBillNo
        '
        Me.LblBillNo.AutoSize = True
        Me.LblBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBillNo.Location = New System.Drawing.Point(576, 46)
        Me.LblBillNo.Name = "LblBillNo"
        Me.LblBillNo.Size = New System.Drawing.Size(70, 12)
        Me.LblBillNo.TabIndex = 251
        Me.LblBillNo.Text = "#############"
        '
        'txtBillingItemNo
        '
        Me.txtBillingItemNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtBillingItemNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBillingItemNo.Enabled = False
        Me.txtBillingItemNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillingItemNo.Location = New System.Drawing.Point(341, 95)
        Me.txtBillingItemNo.Name = "txtBillingItemNo"
        Me.txtBillingItemNo.Size = New System.Drawing.Size(85, 18)
        Me.txtBillingItemNo.TabIndex = 307
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(147, 99)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 12)
        Me.Label18.TabIndex = 306
        Me.Label18.Text = "Qty"
        '
        'txtrevisedQty
        '
        Me.txtrevisedQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtrevisedQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtrevisedQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrevisedQty.Location = New System.Drawing.Point(191, 95)
        Me.txtrevisedQty.Name = "txtrevisedQty"
        Me.txtrevisedQty.Size = New System.Drawing.Size(100, 18)
        Me.txtrevisedQty.TabIndex = 305
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(430, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 12)
        Me.Label13.TabIndex = 292
        Me.Label13.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(464, 69)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(102, 18)
        Me.txtTotal.TabIndex = 291
        '
        'txtunitrt
        '
        Me.txtunitrt.Enabled = False
        Me.txtunitrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunitrt.Location = New System.Drawing.Point(527, 43)
        Me.txtunitrt.Name = "txtunitrt"
        Me.txtunitrt.Size = New System.Drawing.Size(39, 18)
        Me.txtunitrt.TabIndex = 290
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(493, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 12)
        Me.Label12.TabIndex = 289
        Me.Label12.Text = "Rate:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 12)
        Me.Label6.TabIndex = 287
        Me.Label6.Text = "Sub:"
        '
        'txtqtyinvoiced
        '
        Me.txtqtyinvoiced.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtqtyinvoiced.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtqtyinvoiced.Enabled = False
        Me.txtqtyinvoiced.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqtyinvoiced.Location = New System.Drawing.Point(46, 93)
        Me.txtqtyinvoiced.Name = "txtqtyinvoiced"
        Me.txtqtyinvoiced.Size = New System.Drawing.Size(99, 18)
        Me.txtqtyinvoiced.TabIndex = 256
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 12)
        Me.Label4.TabIndex = 257
        Me.Label4.Text = "Qty:"
        '
        'txtTXNo
        '
        Me.txtTXNo.Enabled = False
        Me.txtTXNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTXNo.Location = New System.Drawing.Point(341, 66)
        Me.txtTXNo.Name = "txtTXNo"
        Me.txtTXNo.Size = New System.Drawing.Size(85, 18)
        Me.txtTXNo.TabIndex = 286
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(298, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 12)
        Me.Label11.TabIndex = 285
        Me.Label11.Text = "TX No:"
        '
        'txtConstituencyname
        '
        Me.txtConstituencyname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyname.Enabled = False
        Me.txtConstituencyname.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConstituencyname.Location = New System.Drawing.Point(341, 41)
        Me.txtConstituencyname.Name = "txtConstituencyname"
        Me.txtConstituencyname.Size = New System.Drawing.Size(85, 18)
        Me.txtConstituencyname.TabIndex = 277
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(298, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 12)
        Me.Label10.TabIndex = 278
        Me.Label10.Text = "Const:"
        '
        'txtCounty
        '
        Me.txtCounty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCounty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCounty.Enabled = False
        Me.txtCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCounty.Location = New System.Drawing.Point(191, 45)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(100, 18)
        Me.txtCounty.TabIndex = 275
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(147, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 12)
        Me.Label9.TabIndex = 276
        Me.Label9.Text = "County:"
        '
        'txtSchemeName
        '
        Me.txtSchemeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeName.Enabled = False
        Me.txtSchemeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchemeName.Location = New System.Drawing.Point(46, 67)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(75, 18)
        Me.txtSchemeName.TabIndex = 284
        '
        'btnLoadSchemes
        '
        Me.btnLoadSchemes.BackColor = System.Drawing.Color.DarkGray
        Me.btnLoadSchemes.BackgroundImage = CType(resources.GetObject("btnLoadSchemes.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadSchemes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadSchemes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSchemes.Enabled = False
        Me.btnLoadSchemes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadSchemes.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadSchemes.Location = New System.Drawing.Point(123, 69)
        Me.btnLoadSchemes.Name = "btnLoadSchemes"
        Me.btnLoadSchemes.Size = New System.Drawing.Size(22, 17)
        Me.btnLoadSchemes.TabIndex = 283
        Me.btnLoadSchemes.UseVisualStyleBackColor = False
        '
        'cboSubcontractor
        '
        Me.cboSubcontractor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSubcontractor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubcontractor.Enabled = False
        Me.cboSubcontractor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubcontractor.FormattingEnabled = True
        Me.cboSubcontractor.Location = New System.Drawing.Point(47, 43)
        Me.cboSubcontractor.Name = "cboSubcontractor"
        Me.cboSubcontractor.Size = New System.Drawing.Size(98, 20)
        Me.cboSubcontractor.TabIndex = 279
        '
        'txtSubcontractor
        '
        Me.txtSubcontractor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubcontractor.Location = New System.Drawing.Point(126, 44)
        Me.txtSubcontractor.Name = "txtSubcontractor"
        Me.txtSubcontractor.Size = New System.Drawing.Size(16, 18)
        Me.txtSubcontractor.TabIndex = 281
        '
        'txtSchemeRefNo
        '
        Me.txtSchemeRefNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeRefNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeRefNo.Enabled = False
        Me.txtSchemeRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchemeRefNo.Location = New System.Drawing.Point(191, 71)
        Me.txtSchemeRefNo.Name = "txtSchemeRefNo"
        Me.txtSchemeRefNo.Size = New System.Drawing.Size(100, 18)
        Me.txtSchemeRefNo.TabIndex = 261
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(432, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 273
        Me.Label8.Text = "UoM:"
        '
        'lbldate
        '
        Me.lbldate.CustomFormat = "MM/dd/yyyy"
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.lbldate.Location = New System.Drawing.Point(466, 17)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(102, 18)
        Me.lbldate.TabIndex = 268
        '
        'txtSchemeID
        '
        Me.txtSchemeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeID.Enabled = False
        Me.txtSchemeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchemeID.Location = New System.Drawing.Point(260, 71)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(13, 18)
        Me.txtSchemeID.TabIndex = 265
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyID.Enabled = False
        Me.txtConstituencyID.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConstituencyID.Location = New System.Drawing.Point(244, 71)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(10, 18)
        Me.txtConstituencyID.TabIndex = 267
        '
        'txtCountyID
        '
        Me.txtCountyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCountyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCountyID.Enabled = False
        Me.txtCountyID.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountyID.Location = New System.Drawing.Point(225, 71)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(13, 18)
        Me.txtCountyID.TabIndex = 266
        '
        'txtUnitofIssue
        '
        Me.txtUnitofIssue.Enabled = False
        Me.txtUnitofIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitofIssue.Location = New System.Drawing.Point(466, 45)
        Me.txtUnitofIssue.Name = "txtUnitofIssue"
        Me.txtUnitofIssue.Size = New System.Drawing.Size(21, 18)
        Me.txtUnitofIssue.TabIndex = 264
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(147, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 12)
        Me.Label1.TabIndex = 263
        Me.Label1.Text = "Ref No"
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.Cyan
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(576, 71)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(78, 43)
        Me.btnCompute.TabIndex = 258
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'cmdSearchItems
        '
        Me.cmdSearchItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmdSearchItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmdSearchItems.Enabled = False
        Me.cmdSearchItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearchItems.FormattingEnabled = True
        Me.cmdSearchItems.Location = New System.Drawing.Point(47, 18)
        Me.cmdSearchItems.Name = "cmdSearchItems"
        Me.cmdSearchItems.Size = New System.Drawing.Size(244, 20)
        Me.cmdSearchItems.TabIndex = 255
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 12)
        Me.Label5.TabIndex = 254
        Me.Label5.Text = "BoQ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(300, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 12)
        Me.Label3.TabIndex = 253
        Me.Label3.Text = "BoQ:"
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
        Me.lblScheme.BackColor = System.Drawing.Color.DimGray
        Me.lblScheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheme.ForeColor = System.Drawing.Color.Cyan
        Me.lblScheme.Location = New System.Drawing.Point(6, 73)
        Me.lblScheme.Name = "lblScheme"
        Me.lblScheme.Size = New System.Drawing.Size(29, 12)
        Me.lblScheme.TabIndex = 249
        Me.lblScheme.Text = "Schm"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(432, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 12)
        Me.Label19.TabIndex = 246
        Me.Label19.Text = "Date:"
        '
        'txtItemCode
        '
        Me.txtItemCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtItemCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtItemCode.Enabled = False
        Me.txtItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(341, 16)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(85, 18)
        Me.txtItemCode.TabIndex = 252
        '
        'chkMeteringcomplete
        '
        Me.chkMeteringcomplete.AutoSize = True
        Me.chkMeteringcomplete.BackColor = System.Drawing.Color.Red
        Me.chkMeteringcomplete.Enabled = False
        Me.chkMeteringcomplete.Location = New System.Drawing.Point(298, 207)
        Me.chkMeteringcomplete.Name = "chkMeteringcomplete"
        Me.chkMeteringcomplete.Size = New System.Drawing.Size(120, 17)
        Me.chkMeteringcomplete.TabIndex = 288
        Me.chkMeteringcomplete.Text = "Metering Completed"
        Me.chkMeteringcomplete.UseVisualStyleBackColor = False
        '
        'lblTotalincvat
        '
        Me.lblTotalincvat.AutoSize = True
        Me.lblTotalincvat.BackColor = System.Drawing.Color.Aqua
        Me.lblTotalincvat.Location = New System.Drawing.Point(54, 369)
        Me.lblTotalincvat.Name = "lblTotalincvat"
        Me.lblTotalincvat.Size = New System.Drawing.Size(85, 12)
        Me.lblTotalincvat.TabIndex = 304
        Me.lblTotalincvat.Text = "++++++++++++++++"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(11, 345)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 13)
        Me.Label20.TabIndex = 301
        Me.Label20.Text = "Vat:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 368)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 302
        Me.Label21.Text = "Tot+Vat:"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.BackColor = System.Drawing.Color.Aqua
        Me.lblVat.Location = New System.Drawing.Point(54, 346)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(85, 12)
        Me.lblVat.TabIndex = 303
        Me.lblVat.Text = "++++++++++++++++"
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.AutoSize = True
        Me.lblTotalAmt.BackColor = System.Drawing.Color.Aqua
        Me.lblTotalAmt.Location = New System.Drawing.Point(54, 322)
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(85, 12)
        Me.lblTotalAmt.TabIndex = 299
        Me.lblTotalAmt.Text = "++++++++++++++++"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 322)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 300
        Me.Label22.Text = "Total:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(3, 1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1046, 38)
        Me.TextBox1.TabIndex = 226
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(456, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 15)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "Update Statement "
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
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colInvoiceNo, Me.Column7, Me.Column1, Me.colQtyperUoM, Me.colUnits, Me.colQty, Me.colTotalprice, Me.colBillingItemNo})
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
        Me.dgw.Location = New System.Drawing.Point(3, 169)
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
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(660, 270)
        Me.dgw.TabIndex = 228
        '
        'colInvoiceNo
        '
        Me.colInvoiceNo.HeaderText = "Stmnt No"
        Me.colInvoiceNo.Name = "colInvoiceNo"
        Me.colInvoiceNo.ReadOnly = True
        Me.colInvoiceNo.Width = 75
        '
        'Column7
        '
        Me.Column7.HeaderText = "BoQ No"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "BoQ Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 300
        '
        'colQtyperUoM
        '
        Me.colQtyperUoM.HeaderText = "UoM"
        Me.colQtyperUoM.Name = "colQtyperUoM"
        Me.colQtyperUoM.ReadOnly = True
        Me.colQtyperUoM.Width = 40
        '
        'colUnits
        '
        Me.colUnits.HeaderText = " Rate"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.ReadOnly = True
        Me.colUnits.Width = 50
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        Me.colQty.Width = 40
        '
        'colTotalprice
        '
        Me.colTotalprice.HeaderText = "Total"
        Me.colTotalprice.Name = "colTotalprice"
        Me.colTotalprice.ReadOnly = True
        Me.colTotalprice.Width = 75
        '
        'colBillingItemNo
        '
        Me.colBillingItemNo.HeaderText = "BillingItemNo"
        Me.colBillingItemNo.Name = "colBillingItemNo"
        Me.colBillingItemNo.ReadOnly = True
        Me.colBillingItemNo.Visible = False
        Me.colBillingItemNo.Width = 75
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblTotalincvat)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtschmname)
        Me.GroupBox2.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox2.Controls.Add(Me.lblVat)
        Me.GroupBox2.Controls.Add(Me.dgw1)
        Me.GroupBox2.Controls.Add(Me.lblTotalAmt)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(669, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 394)
        Me.GroupBox2.TabIndex = 229
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Invoices"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.txtNil)
        Me.Panel3.Location = New System.Drawing.Point(159, 320)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(98, 68)
        Me.Panel3.TabIndex = 231
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(5, 35)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(89, 28)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(4, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(89, 26)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtNil
        '
        Me.txtNil.Enabled = False
        Me.txtNil.Location = New System.Drawing.Point(45, 41)
        Me.txtNil.Name = "txtNil"
        Me.txtNil.Size = New System.Drawing.Size(21, 18)
        Me.txtNil.TabIndex = 287
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Symbol", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(155, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 12)
        Me.Label17.TabIndex = 256
        Me.Label17.Text = "Scheme Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.grpboxenablestatementno)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.btnLogIn)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 123)
        Me.GroupBox1.TabIndex = 230
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login to Update Approved Statement"
        '
        'grpboxenablestatementno
        '
        Me.grpboxenablestatementno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpboxenablestatementno.Controls.Add(Me.btnEnablestatement)
        Me.grpboxenablestatementno.Controls.Add(Me.txtapprove)
        Me.grpboxenablestatementno.Controls.Add(Me.txtStatementNo)
        Me.grpboxenablestatementno.Controls.Add(Me.Label25)
        Me.grpboxenablestatementno.Controls.Add(Me.txtcancel)
        Me.grpboxenablestatementno.Location = New System.Drawing.Point(3, 76)
        Me.grpboxenablestatementno.Name = "grpboxenablestatementno"
        Me.grpboxenablestatementno.Size = New System.Drawing.Size(237, 43)
        Me.grpboxenablestatementno.TabIndex = 178
        Me.grpboxenablestatementno.TabStop = False
        Me.grpboxenablestatementno.Text = "Statement No"
        '
        'btnEnablestatement
        '
        Me.btnEnablestatement.BackColor = System.Drawing.Color.Red
        Me.btnEnablestatement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnablestatement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnablestatement.Font = New System.Drawing.Font("Segoe UI Symbol", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnablestatement.Location = New System.Drawing.Point(140, 8)
        Me.btnEnablestatement.Name = "btnEnablestatement"
        Me.btnEnablestatement.Size = New System.Drawing.Size(85, 28)
        Me.btnEnablestatement.TabIndex = 178
        Me.btnEnablestatement.Text = "Enable Update"
        Me.btnEnablestatement.UseVisualStyleBackColor = False
        '
        'txtapprove
        '
        Me.txtapprove.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapprove.Location = New System.Drawing.Point(164, 13)
        Me.txtapprove.Name = "txtapprove"
        Me.txtapprove.Size = New System.Drawing.Size(18, 22)
        Me.txtapprove.TabIndex = 306
        '
        'txtStatementNo
        '
        Me.txtStatementNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatementNo.Location = New System.Drawing.Point(57, 13)
        Me.txtStatementNo.Name = "txtStatementNo"
        Me.txtStatementNo.Size = New System.Drawing.Size(77, 22)
        Me.txtStatementNo.TabIndex = 177
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Symbol", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 12)
        Me.Label25.TabIndex = 176
        Me.Label25.Text = "Stmnt No:"
        '
        'txtcancel
        '
        Me.txtcancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcancel.Location = New System.Drawing.Point(187, 13)
        Me.txtcancel.Name = "txtcancel"
        Me.txtcancel.Size = New System.Drawing.Size(20, 22)
        Me.txtcancel.TabIndex = 307
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(14, 86)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(0, 17)
        Me.Label24.TabIndex = 177
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogIn.Image = CType(resources.GetObject("btnLogIn.Image"), System.Drawing.Image)
        Me.btnLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogIn.Location = New System.Drawing.Point(178, 24)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(62, 30)
        Me.btnLogIn.TabIndex = 176
        Me.btnLogIn.Text = "Login"
        Me.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(50, 43)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(120, 22)
        Me.txtPassword.TabIndex = 175
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(52, 15)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(120, 22)
        Me.txtUsername.TabIndex = 174
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Symbol", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 12)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Password:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Symbol", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 12)
        Me.Label16.TabIndex = 172
        Me.Label16.Text = "Name:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Symbol", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(29, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 12)
        Me.Label15.TabIndex = 255
        Me.Label15.Text = "Statement No:"
        '
        'txtschmname
        '
        Me.txtschmname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtschmname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtschmname.Font = New System.Drawing.Font("Segoe UI Symbol", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtschmname.Location = New System.Drawing.Point(133, 32)
        Me.txtschmname.Name = "txtschmname"
        Me.txtschmname.Size = New System.Drawing.Size(124, 19)
        Me.txtschmname.TabIndex = 254
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtInvoiceNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Segoe UI Symbol", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(8, 32)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(116, 19)
        Me.txtInvoiceNo.TabIndex = 253
        '
        'dgw1
        '
        Me.dgw1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgw1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgw1.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw1.Location = New System.Drawing.Point(6, 58)
        Me.dgw1.MultiSelect = False
        Me.dgw1.Name = "dgw1"
        Me.dgw1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw1.Size = New System.Drawing.Size(251, 132)
        Me.dgw1.TabIndex = 44
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Stmnt"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 65
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Scheme"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sub-Contrct"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 70
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
        Me.GrpbxPolessummary.Controls.Add(Me.Label34)
        Me.GrpbxPolessummary.Controls.Add(Me.txtLVConductor)
        Me.GrpbxPolessummary.Controls.Add(Me.Label35)
        Me.GrpbxPolessummary.Controls.Add(Me.txtMVWP)
        Me.GrpbxPolessummary.Controls.Add(Me.Label36)
        Me.GrpbxPolessummary.Controls.Add(Me.txtMVCP)
        Me.GrpbxPolessummary.Controls.Add(Me.Label37)
        Me.GrpbxPolessummary.Controls.Add(Me.Label38)
        Me.GrpbxPolessummary.Controls.Add(Me.txtWPLV)
        Me.GrpbxPolessummary.Controls.Add(Me.Label39)
        Me.GrpbxPolessummary.Controls.Add(Me.txtLVCP)
        Me.GrpbxPolessummary.Location = New System.Drawing.Point(935, 45)
        Me.GrpbxPolessummary.Name = "GrpbxPolessummary"
        Me.GrpbxPolessummary.Size = New System.Drawing.Size(114, 391)
        Me.GrpbxPolessummary.TabIndex = 301
        Me.GrpbxPolessummary.TabStop = False
        Me.GrpbxPolessummary.Text = "Summary"
        '
        'txtLVStayRod
        '
        Me.txtLVStayRod.Enabled = False
        Me.txtLVStayRod.Location = New System.Drawing.Point(64, 160)
        Me.txtLVStayRod.Name = "txtLVStayRod"
        Me.txtLVStayRod.Size = New System.Drawing.Size(46, 20)
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
        Me.txtMVstaywire.Size = New System.Drawing.Size(46, 20)
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
        Me.txtMVConductor.Size = New System.Drawing.Size(46, 20)
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
        Me.txtPME.Size = New System.Drawing.Size(46, 20)
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
        Me.txtLVstaywire.Size = New System.Drawing.Size(46, 20)
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
        Me.txtstayinsulator.Size = New System.Drawing.Size(46, 20)
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
        Me.txtMVstayrod.Size = New System.Drawing.Size(46, 20)
        Me.txtMVstayrod.TabIndex = 321
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(2, 190)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(58, 12)
        Me.Label34.TabIndex = 322
        Me.Label34.Text = "Stay Rod MV:"
        '
        'txtLVConductor
        '
        Me.txtLVConductor.Enabled = False
        Me.txtLVConductor.Location = New System.Drawing.Point(64, 110)
        Me.txtLVConductor.Name = "txtLVConductor"
        Me.txtLVConductor.Size = New System.Drawing.Size(46, 20)
        Me.txtLVConductor.TabIndex = 319
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(0, 114)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(62, 12)
        Me.Label35.TabIndex = 320
        Me.Label35.Text = "LV Conductor:"
        '
        'txtMVWP
        '
        Me.txtMVWP.Enabled = False
        Me.txtMVWP.Location = New System.Drawing.Point(64, 37)
        Me.txtMVWP.Name = "txtMVWP"
        Me.txtMVWP.Size = New System.Drawing.Size(46, 20)
        Me.txtMVWP.TabIndex = 315
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(0, 39)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(39, 12)
        Me.Label36.TabIndex = 316
        Me.Label36.Text = "MV WP:"
        '
        'txtMVCP
        '
        Me.txtMVCP.Enabled = False
        Me.txtMVCP.Location = New System.Drawing.Point(64, 87)
        Me.txtMVCP.Name = "txtMVCP"
        Me.txtMVCP.Size = New System.Drawing.Size(46, 20)
        Me.txtMVCP.TabIndex = 317
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(1, 91)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(36, 12)
        Me.Label37.TabIndex = 318
        Me.Label37.Text = "MV CP:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(1, 18)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(36, 12)
        Me.Label38.TabIndex = 312
        Me.Label38.Text = "LV WP:"
        '
        'txtWPLV
        '
        Me.txtWPLV.Enabled = False
        Me.txtWPLV.Location = New System.Drawing.Point(64, 14)
        Me.txtWPLV.Name = "txtWPLV"
        Me.txtWPLV.Size = New System.Drawing.Size(46, 20)
        Me.txtWPLV.TabIndex = 311
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(1, 66)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(33, 12)
        Me.Label39.TabIndex = 314
        Me.Label39.Text = "LV CP:"
        '
        'txtLVCP
        '
        Me.txtLVCP.Enabled = False
        Me.txtLVCP.Location = New System.Drawing.Point(64, 62)
        Me.txtLVCP.Name = "txtLVCP"
        Me.txtLVCP.Size = New System.Drawing.Size(46, 20)
        Me.txtLVCP.TabIndex = 313
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(503, 262)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(50, 12)
        Me.Label40.TabIndex = 318
        Me.Label40.Text = "11m WP:"
        Me.Label40.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(503, 279)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(50, 12)
        Me.Label41.TabIndex = 320
        Me.Label41.Text = "12m WP:"
        Me.Label41.Visible = False
        '
        'txt12MPoles
        '
        Me.txt12MPoles.Enabled = False
        Me.txt12MPoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt12MPoles.Location = New System.Drawing.Point(553, 279)
        Me.txt12MPoles.Multiline = True
        Me.txt12MPoles.Name = "txt12MPoles"
        Me.txt12MPoles.Size = New System.Drawing.Size(23, 16)
        Me.txt12MPoles.TabIndex = 319
        Me.txt12MPoles.Visible = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(476, 209)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(69, 12)
        Me.Label42.TabIndex = 328
        Me.Label42.Text = "10m CPW/E:"
        Me.Label42.Visible = False
        '
        'txtCPWE
        '
        Me.txtCPWE.Enabled = False
        Me.txtCPWE.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPWE.Location = New System.Drawing.Point(551, 206)
        Me.txtCPWE.Name = "txtCPWE"
        Me.txtCPWE.Size = New System.Drawing.Size(23, 18)
        Me.txtCPWE.TabIndex = 327
        Me.txtCPWE.Visible = False
        '
        'txt11MCP
        '
        Me.txt11MCP.Enabled = False
        Me.txt11MCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt11MCP.Location = New System.Drawing.Point(552, 322)
        Me.txt11MCP.Multiline = True
        Me.txt11MCP.Name = "txt11MCP"
        Me.txt11MCP.Size = New System.Drawing.Size(23, 16)
        Me.txt11MCP.TabIndex = 323
        Me.txt11MCP.Visible = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(498, 323)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(48, 12)
        Me.Label43.TabIndex = 324
        Me.Label43.Text = "11m CP:"
        Me.Label43.Visible = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(497, 344)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(48, 12)
        Me.Label44.TabIndex = 326
        Me.Label44.Text = "12m CP:"
        Me.Label44.Visible = False
        '
        'txt12MCP
        '
        Me.txt12MCP.Enabled = False
        Me.txt12MCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt12MCP.Location = New System.Drawing.Point(551, 344)
        Me.txt12MCP.Multiline = True
        Me.txt12MCP.Name = "txt12MCP"
        Me.txt12MCP.Size = New System.Drawing.Size(23, 16)
        Me.txt12MCP.TabIndex = 325
        Me.txt12MCP.Visible = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(498, 301)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(48, 12)
        Me.Label45.TabIndex = 322
        Me.Label45.Text = "10m CP:"
        Me.Label45.Visible = False
        '
        'txt10MCP
        '
        Me.txt10MCP.Enabled = False
        Me.txt10MCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt10MCP.Location = New System.Drawing.Point(552, 299)
        Me.txt10MCP.Name = "txt10MCP"
        Me.txt10MCP.Size = New System.Drawing.Size(23, 18)
        Me.txt10MCP.TabIndex = 321
        Me.txt10MCP.Visible = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(503, 237)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(50, 12)
        Me.Label46.TabIndex = 316
        Me.Label46.Text = "10m WP:"
        Me.Label46.Visible = False
        '
        'txtPolesInstalled
        '
        Me.txtPolesInstalled.Enabled = False
        Me.txtPolesInstalled.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPolesInstalled.Location = New System.Drawing.Point(553, 235)
        Me.txtPolesInstalled.Multiline = True
        Me.txtPolesInstalled.Name = "txtPolesInstalled"
        Me.txtPolesInstalled.Size = New System.Drawing.Size(23, 15)
        Me.txtPolesInstalled.TabIndex = 315
        Me.txtPolesInstalled.Visible = False
        '
        'txt11MPoles
        '
        Me.txt11MPoles.Enabled = False
        Me.txt11MPoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt11MPoles.Location = New System.Drawing.Point(553, 260)
        Me.txt11MPoles.Multiline = True
        Me.txt11MPoles.Name = "txt11MPoles"
        Me.txt11MPoles.Size = New System.Drawing.Size(23, 16)
        Me.txt11MPoles.TabIndex = 317
        Me.txt11MPoles.Visible = False
        '
        'frmInvoiceUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1051, 445)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GrpbxPolessummary)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.chkMeteringcomplete)
        Me.Controls.Add(Me.Details)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.txt12MPoles)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.txtCPWE)
        Me.Controls.Add(Me.txt11MCP)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.txt12MCP)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.txt10MCP)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.txtPolesInstalled)
        Me.Controls.Add(Me.txt11MPoles)
        Me.MaximizeBox = False
        Me.Name = "frmInvoiceUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Details.ResumeLayout(False)
        Me.Details.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpboxenablestatementno.ResumeLayout(False)
        Me.grpboxenablestatementno.PerformLayout()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpbxPolessummary.ResumeLayout(False)
        Me.GrpbxPolessummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Details As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtunitrt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents chkMeteringcomplete As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtqtyinvoiced As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTXNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtConstituencyname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSchemeName As TextBox
    Friend WithEvents btnLoadSchemes As Button
    Friend WithEvents cboSubcontractor As ComboBox
    Friend WithEvents txtSubcontractor As TextBox
    Friend WithEvents txtSchemeRefNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbldate As DateTimePicker
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents txtUnitofIssue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents cmdSearchItems As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblBillNo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblScheme As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgw As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgw1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtschmname As TextBox
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblTotalincvat As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents lblTotalAmt As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtrevisedQty As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtNil As TextBox
    Friend WithEvents grpboxenablestatementno As GroupBox
    Friend WithEvents btnEnablestatement As Button
    Friend WithEvents txtStatementNo As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtcancel As TextBox
    Friend WithEvents txtapprove As TextBox
    Friend WithEvents txtBillingItemNo As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents cboVat As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtVatRate As TextBox
    Friend WithEvents txtVatNo As TextBox
    Friend WithEvents colInvoiceNo As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colQtyperUoM As DataGridViewTextBoxColumn
    Friend WithEvents colUnits As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colTotalprice As DataGridViewTextBoxColumn
    Friend WithEvents colBillingItemNo As DataGridViewTextBoxColumn
    Friend WithEvents GrpbxPolessummary As GroupBox
    Friend WithEvents txtLVStayRod As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtMVstaywire As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtMVConductor As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtPME As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtLVstaywire As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtstayinsulator As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtMVstayrod As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtLVConductor As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtMVWP As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txtMVCP As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents txtWPLV As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents txtLVCP As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents txt12MPoles As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtCPWE As TextBox
    Friend WithEvents txt11MCP As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents txt12MCP As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents txt10MCP As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents txtPolesInstalled As TextBox
    Friend WithEvents txt11MPoles As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
