<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateMaterialDel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateMaterialDel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSavedetails = New System.Windows.Forms.ToolStrip()
        Me.UpdateDeliveryMaterialToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblDeliveryNo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSchemeName = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCountyName = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtConstituencyName = New System.Windows.Forms.TextBox()
        Me.txtItemCount = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTillNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIssuanceTime = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIssuancedate = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddMatdgw = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNil = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQtyonHand = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtytoIssue = New System.Windows.Forms.TextBox()
        Me.cmdSearchItems = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.txtRemStock = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.btnSavedetails.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AddMatdgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 33)
        Me.Panel1.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(215, 6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(182, 19)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Update Material Delivery"
        '
        'btnSavedetails
        '
        Me.btnSavedetails.AutoSize = False
        Me.btnSavedetails.BackColor = System.Drawing.Color.LightGray
        Me.btnSavedetails.Dock = System.Windows.Forms.DockStyle.None
        Me.btnSavedetails.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.btnSavedetails.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateDeliveryMaterialToolStripButton5, Me.ToolStripButton1})
        Me.btnSavedetails.Location = New System.Drawing.Point(241, 456)
        Me.btnSavedetails.Name = "btnSavedetails"
        Me.btnSavedetails.Size = New System.Drawing.Size(138, 33)
        Me.btnSavedetails.TabIndex = 35
        Me.btnSavedetails.Text = "ToolStrip1"
        Me.btnSavedetails.UseWaitCursor = True
        '
        'UpdateDeliveryMaterialToolStripButton5
        '
        Me.UpdateDeliveryMaterialToolStripButton5.Image = CType(resources.GetObject("UpdateDeliveryMaterialToolStripButton5.Image"), System.Drawing.Image)
        Me.UpdateDeliveryMaterialToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UpdateDeliveryMaterialToolStripButton5.Name = "UpdateDeliveryMaterialToolStripButton5"
        Me.UpdateDeliveryMaterialToolStripButton5.Size = New System.Drawing.Size(51, 30)
        Me.UpdateDeliveryMaterialToolStripButton5.Text = "Save"
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.LblDeliveryNo)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.txtSchemeName)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txtCountyName)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.txtConstituencyName)
        Me.GroupBox5.Controls.Add(Me.txtItemCount)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.txtUserName)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.txtTillNo)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtIssuanceTime)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtIssuancedate)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtSchemeID)
        Me.GroupBox5.Controls.Add(Me.txtCountyID)
        Me.GroupBox5.Controls.Add(Me.txtConstituencyID)
        Me.GroupBox5.Location = New System.Drawing.Point(1, 41)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(616, 72)
        Me.GroupBox5.TabIndex = 170
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = " Delivery Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(533, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 14)
        Me.Label6.TabIndex = 210
        Me.Label6.Text = "Item Count:"
        '
        'LblDeliveryNo
        '
        Me.LblDeliveryNo.Enabled = False
        Me.LblDeliveryNo.Location = New System.Drawing.Point(56, 22)
        Me.LblDeliveryNo.Margin = New System.Windows.Forms.Padding(2)
        Me.LblDeliveryNo.Name = "LblDeliveryNo"
        Me.LblDeliveryNo.Size = New System.Drawing.Size(75, 20)
        Me.LblDeliveryNo.TabIndex = 206
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(136, 25)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 14)
        Me.Label24.TabIndex = 201
        Me.Label24.Text = "Schm: "
        '
        'txtSchemeName
        '
        Me.txtSchemeName.Enabled = False
        Me.txtSchemeName.Location = New System.Drawing.Point(184, 20)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(80, 20)
        Me.txtSchemeName.TabIndex = 200
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(137, 50)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 14)
        Me.Label23.TabIndex = 199
        Me.Label23.Text = "Cnty: "
        '
        'txtCountyName
        '
        Me.txtCountyName.Enabled = False
        Me.txtCountyName.Location = New System.Drawing.Point(184, 46)
        Me.txtCountyName.Name = "txtCountyName"
        Me.txtCountyName.Size = New System.Drawing.Size(80, 20)
        Me.txtCountyName.TabIndex = 198
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(275, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 14)
        Me.Label22.TabIndex = 197
        Me.Label22.Text = "Contcy:"
        '
        'txtConstituencyName
        '
        Me.txtConstituencyName.Enabled = False
        Me.txtConstituencyName.Location = New System.Drawing.Point(324, 19)
        Me.txtConstituencyName.Name = "txtConstituencyName"
        Me.txtConstituencyName.Size = New System.Drawing.Size(74, 20)
        Me.txtConstituencyName.TabIndex = 196
        '
        'txtItemCount
        '
        Me.txtItemCount.Enabled = False
        Me.txtItemCount.Location = New System.Drawing.Point(536, 42)
        Me.txtItemCount.Name = "txtItemCount"
        Me.txtItemCount.Size = New System.Drawing.Size(37, 20)
        Me.txtItemCount.TabIndex = 194
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(404, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 14)
        Me.Label20.TabIndex = 193
        Me.Label20.Text = "Created:"
        '
        'txtUserName
        '
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(457, 14)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(70, 20)
        Me.txtUserName.TabIndex = 192
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 14)
        Me.Label19.TabIndex = 191
        Me.Label19.Text = "W.S:"
        '
        'txtTillNo
        '
        Me.txtTillNo.Enabled = False
        Me.txtTillNo.Location = New System.Drawing.Point(56, 46)
        Me.txtTillNo.Name = "txtTillNo"
        Me.txtTillNo.Size = New System.Drawing.Size(75, 20)
        Me.txtTillNo.TabIndex = 190
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(275, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 14)
        Me.Label9.TabIndex = 187
        Me.Label9.Text = "Time: "
        '
        'txtIssuanceTime
        '
        Me.txtIssuanceTime.Enabled = False
        Me.txtIssuanceTime.Location = New System.Drawing.Point(324, 42)
        Me.txtIssuanceTime.Name = "txtIssuanceTime"
        Me.txtIssuanceTime.Size = New System.Drawing.Size(74, 20)
        Me.txtIssuanceTime.TabIndex = 186
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(404, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 14)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Date:"
        '
        'txtIssuancedate
        '
        Me.txtIssuancedate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIssuancedate.Enabled = False
        Me.txtIssuancedate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssuancedate.Location = New System.Drawing.Point(457, 43)
        Me.txtIssuancedate.MaxLength = 50
        Me.txtIssuancedate.Name = "txtIssuancedate"
        Me.txtIssuancedate.Size = New System.Drawing.Size(70, 22)
        Me.txtIssuancedate.TabIndex = 170
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 14)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Del No :"
        '
        'txtSchemeID
        '
        Me.txtSchemeID.Location = New System.Drawing.Point(252, 20)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(12, 20)
        Me.txtSchemeID.TabIndex = 209
        Me.txtSchemeID.Visible = False
        '
        'txtCountyID
        '
        Me.txtCountyID.Location = New System.Drawing.Point(252, 46)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(12, 20)
        Me.txtCountyID.TabIndex = 207
        Me.txtCountyID.Visible = False
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.Location = New System.Drawing.Point(376, 19)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(12, 20)
        Me.txtConstituencyID.TabIndex = 208
        Me.txtConstituencyID.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddMatdgw)
        Me.GroupBox1.Controls.Add(Me.txtNil)
        Me.GroupBox1.Controls.Add(Me.txtRemStock)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 274)
        Me.GroupBox1.TabIndex = 171
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Delivery Items"
        '
        'AddMatdgw
        '
        Me.AddMatdgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.AddMatdgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.AddMatdgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AddMatdgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column7, Me.PriceColumn, Me.Column9, Me.Column10})
        Me.AddMatdgw.GridColor = System.Drawing.Color.DarkOrange
        Me.AddMatdgw.Location = New System.Drawing.Point(6, 19)
        Me.AddMatdgw.MultiSelect = False
        Me.AddMatdgw.Name = "AddMatdgw"
        Me.AddMatdgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.AddMatdgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.AddMatdgw.Size = New System.Drawing.Size(604, 249)
        Me.AddMatdgw.TabIndex = 44
        '
        'Column4
        '
        Me.Column4.HeaderText = "Del No"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item No"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 75
        '
        'Column7
        '
        Me.Column7.HeaderText = "Descrp"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'PriceColumn
        '
        Me.PriceColumn.HeaderText = "Qty"
        Me.PriceColumn.Name = "PriceColumn"
        Me.PriceColumn.Width = 50
        '
        'Column9
        '
        Me.Column9.HeaderText = "Date "
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 75
        '
        'Column10
        '
        Me.Column10.HeaderText = "Time"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 75
        '
        'txtNil
        '
        Me.txtNil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtNil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtNil.Enabled = False
        Me.txtNil.Location = New System.Drawing.Point(507, 92)
        Me.txtNil.Name = "txtNil"
        Me.txtNil.Size = New System.Drawing.Size(36, 20)
        Me.txtNil.TabIndex = 269
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCheck)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtUom)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtQtyonHand)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtQtytoIssue)
        Me.GroupBox2.Controls.Add(Me.cmdSearchItems)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtItemCode)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(608, 43)
        Me.GroupBox2.TabIndex = 172
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Materials"
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCheck.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(556, 9)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(46, 31)
        Me.btnCheck.TabIndex = 270
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(471, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 14)
        Me.Label2.TabIndex = 269
        Me.Label2.Text = "UoM:"
        '
        'txtUom
        '
        Me.txtUom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtUom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtUom.Enabled = False
        Me.txtUom.Location = New System.Drawing.Point(514, 17)
        Me.txtUom.Name = "txtUom"
        Me.txtUom.Size = New System.Drawing.Size(36, 20)
        Me.txtUom.TabIndex = 268
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(381, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 14)
        Me.Label1.TabIndex = 267
        Me.Label1.Text = "Stck:"
        '
        'txtQtyonHand
        '
        Me.txtQtyonHand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtQtyonHand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtQtyonHand.Enabled = False
        Me.txtQtyonHand.Location = New System.Drawing.Point(424, 17)
        Me.txtQtyonHand.Name = "txtQtyonHand"
        Me.txtQtyonHand.Size = New System.Drawing.Size(41, 20)
        Me.txtQtyonHand.TabIndex = 266
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(299, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 14)
        Me.Label4.TabIndex = 263
        Me.Label4.Text = "Qty:"
        '
        'txtQtytoIssue
        '
        Me.txtQtytoIssue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtQtytoIssue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtQtytoIssue.Location = New System.Drawing.Point(335, 16)
        Me.txtQtytoIssue.Name = "txtQtytoIssue"
        Me.txtQtytoIssue.Size = New System.Drawing.Size(35, 20)
        Me.txtQtytoIssue.TabIndex = 262
        '
        'cmdSearchItems
        '
        Me.cmdSearchItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmdSearchItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmdSearchItems.FormattingEnabled = True
        Me.cmdSearchItems.Location = New System.Drawing.Point(48, 15)
        Me.cmdSearchItems.Name = "cmdSearchItems"
        Me.cmdSearchItems.Size = New System.Drawing.Size(132, 21)
        Me.cmdSearchItems.TabIndex = 261
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 14)
        Me.Label5.TabIndex = 260
        Me.Label5.Text = " Item:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(186, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 259
        Me.Label3.Text = "Item No:"
        '
        'txtItemCode
        '
        Me.txtItemCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtItemCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtItemCode.Enabled = False
        Me.txtItemCode.Location = New System.Drawing.Point(244, 16)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(49, 20)
        Me.txtItemCode.TabIndex = 258
        '
        'txtRemStock
        '
        Me.txtRemStock.Enabled = False
        Me.txtRemStock.Location = New System.Drawing.Point(507, 118)
        Me.txtRemStock.Name = "txtRemStock"
        Me.txtRemStock.Size = New System.Drawing.Size(36, 20)
        Me.txtRemStock.TabIndex = 211
        '
        'frmUpdateMaterialDel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 498)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSavedetails)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmUpdateMaterialDel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.btnSavedetails.ResumeLayout(False)
        Me.btnSavedetails.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AddMatdgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnSavedetails As System.Windows.Forms.ToolStrip
    Friend WithEvents UpdateDeliveryMaterialToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LblDeliveryNo As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtSchemeName As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtCountyName As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtConstituencyName As TextBox
    Friend WithEvents txtItemCount As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtTillNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIssuanceTime As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtIssuancedate As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AddMatdgw As DataGridView
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents PriceColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQtytoIssue As TextBox
    Friend WithEvents cmdSearchItems As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQtyonHand As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUom As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents txtNil As TextBox
    Friend WithEvents txtRemStock As TextBox
End Class
