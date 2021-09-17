<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDeliveryApproval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeliveryApproval))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkCancelDelivery = New System.Windows.Forms.CheckBox()
        Me.chkApproveDelivery = New System.Windows.Forms.CheckBox()
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
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStockinID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDocNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ApproveToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.CancelDeliveryToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnAddMaterial = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1137, 36)
        Me.Panel1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(463, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(216, 20)
        Me.Label7.TabIndex = 222
        Me.Label7.Text = "Material Delivery Approval"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 418)
        Me.GroupBox2.TabIndex = 168
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pending Delivery Notes"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Location = New System.Drawing.Point(0, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(247, 393)
        Me.ListView1.TabIndex = 172
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Delivery No"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Scheme"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Issuance Date"
        Me.ColumnHeader3.Width = 95
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkCancelDelivery)
        Me.GroupBox5.Controls.Add(Me.chkApproveDelivery)
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
        Me.GroupBox5.Location = New System.Drawing.Point(278, 46)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(850, 72)
        Me.GroupBox5.TabIndex = 169
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = " Delivery Details"
        '
        'chkCancelDelivery
        '
        Me.chkCancelDelivery.AutoSize = True
        Me.chkCancelDelivery.Location = New System.Drawing.Point(737, 49)
        Me.chkCancelDelivery.Name = "chkCancelDelivery"
        Me.chkCancelDelivery.Size = New System.Drawing.Size(100, 17)
        Me.chkCancelDelivery.TabIndex = 214
        Me.chkCancelDelivery.Text = "Cancel Delivery"
        Me.chkCancelDelivery.UseVisualStyleBackColor = True
        '
        'chkApproveDelivery
        '
        Me.chkApproveDelivery.AutoSize = True
        Me.chkApproveDelivery.Location = New System.Drawing.Point(737, 16)
        Me.chkApproveDelivery.Name = "chkApproveDelivery"
        Me.chkApproveDelivery.Size = New System.Drawing.Size(107, 17)
        Me.chkApproveDelivery.TabIndex = 213
        Me.chkApproveDelivery.Text = "Approve Delivery"
        Me.chkApproveDelivery.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(655, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 210
        Me.Label6.Text = "Item Count:"
        '
        'LblDeliveryNo
        '
        Me.LblDeliveryNo.Enabled = False
        Me.LblDeliveryNo.Location = New System.Drawing.Point(78, 20)
        Me.LblDeliveryNo.Margin = New System.Windows.Forms.Padding(2)
        Me.LblDeliveryNo.Name = "LblDeliveryNo"
        Me.LblDeliveryNo.Size = New System.Drawing.Size(90, 20)
        Me.LblDeliveryNo.TabIndex = 206
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(174, 23)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(52, 13)
        Me.Label24.TabIndex = 201
        Me.Label24.Text = "Scheme: "
        '
        'txtSchemeName
        '
        Me.txtSchemeName.Enabled = False
        Me.txtSchemeName.Location = New System.Drawing.Point(232, 19)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(91, 20)
        Me.txtSchemeName.TabIndex = 200
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(174, 52)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(46, 13)
        Me.Label23.TabIndex = 199
        Me.Label23.Text = "County: "
        '
        'txtCountyName
        '
        Me.txtCountyName.Enabled = False
        Me.txtCountyName.Location = New System.Drawing.Point(232, 46)
        Me.txtCountyName.Name = "txtCountyName"
        Me.txtCountyName.Size = New System.Drawing.Size(91, 20)
        Me.txtCountyName.TabIndex = 198
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(331, 23)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 13)
        Me.Label22.TabIndex = 197
        Me.Label22.Text = "Constituency:"
        '
        'txtConstituencyName
        '
        Me.txtConstituencyName.Enabled = False
        Me.txtConstituencyName.Location = New System.Drawing.Point(408, 20)
        Me.txtConstituencyName.Name = "txtConstituencyName"
        Me.txtConstituencyName.Size = New System.Drawing.Size(74, 20)
        Me.txtConstituencyName.TabIndex = 196
        '
        'txtItemCount
        '
        Me.txtItemCount.Enabled = False
        Me.txtItemCount.Location = New System.Drawing.Point(651, 43)
        Me.txtItemCount.Name = "txtItemCount"
        Me.txtItemCount.Size = New System.Drawing.Size(80, 20)
        Me.txtItemCount.TabIndex = 194
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(489, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 193
        Me.Label20.Text = "Created:"
        '
        'txtUserName
        '
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(542, 20)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(90, 20)
        Me.txtUserName.TabIndex = 192
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 13)
        Me.Label19.TabIndex = 191
        Me.Label19.Text = "Till Name:"
        '
        'txtTillNo
        '
        Me.txtTillNo.Enabled = False
        Me.txtTillNo.Location = New System.Drawing.Point(78, 48)
        Me.txtTillNo.Name = "txtTillNo"
        Me.txtTillNo.Size = New System.Drawing.Size(90, 20)
        Me.txtTillNo.TabIndex = 190
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(329, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 187
        Me.Label9.Text = "Time: "
        '
        'txtIssuanceTime
        '
        Me.txtIssuanceTime.Enabled = False
        Me.txtIssuanceTime.Location = New System.Drawing.Point(408, 46)
        Me.txtIssuanceTime.Name = "txtIssuanceTime"
        Me.txtIssuanceTime.Size = New System.Drawing.Size(74, 20)
        Me.txtIssuanceTime.TabIndex = 186
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(489, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Date:"
        '
        'txtIssuancedate
        '
        Me.txtIssuancedate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIssuancedate.Enabled = False
        Me.txtIssuancedate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssuancedate.Location = New System.Drawing.Point(542, 43)
        Me.txtIssuancedate.MaxLength = 50
        Me.txtIssuancedate.Name = "txtIssuancedate"
        Me.txtIssuancedate.Size = New System.Drawing.Size(90, 22)
        Me.txtIssuancedate.TabIndex = 170
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(5, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Delivery No :"
        '
        'txtSchemeID
        '
        Me.txtSchemeID.Location = New System.Drawing.Point(292, 19)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(12, 20)
        Me.txtSchemeID.TabIndex = 209
        Me.txtSchemeID.Visible = False
        '
        'txtCountyID
        '
        Me.txtCountyID.Location = New System.Drawing.Point(292, 46)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(12, 20)
        Me.txtCountyID.TabIndex = 207
        Me.txtCountyID.Visible = False
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.Location = New System.Drawing.Point(470, 20)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(12, 20)
        Me.txtConstituencyID.TabIndex = 208
        Me.txtConstituencyID.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddMaterial)
        Me.GroupBox1.Controls.Add(Me.dgw)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox1.Controls.Add(Me.btnGetData)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(278, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(850, 386)
        Me.GroupBox1.TabIndex = 170
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Select Item "
        '
        'dgw
        '
        Me.dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column7, Me.PriceColumn, Me.Column9, Me.Column10, Me.colStockinID, Me.colDocNo})
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(6, 45)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(838, 335)
        Me.dgw.TabIndex = 43
        '
        'Column4
        '
        Me.Column4.HeaderText = "Delivery No"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item No"
        Me.Column1.Name = "Column1"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Description"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 250
        '
        'PriceColumn
        '
        Me.PriceColumn.HeaderText = "Qty Issued"
        Me.PriceColumn.Name = "PriceColumn"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Date Issued"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 90
        '
        'Column10
        '
        Me.Column10.HeaderText = "Time Issued"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 110
        '
        'colStockinID
        '
        Me.colStockinID.HeaderText = "StockinID"
        Me.colStockinID.Name = "colStockinID"
        Me.colStockinID.Visible = False
        Me.colStockinID.Width = 60
        '
        'colDocNo
        '
        Me.colDocNo.HeaderText = "Doc No#"
        Me.colDocNo.Name = "colDocNo"
        Me.colDocNo.Visible = False
        Me.colDocNo.Width = 60
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(792, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 20)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(215, 17)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(79, 23)
        Me.dtpDateTo.TabIndex = 39
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(171, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(26, 15)
        Me.Label26.TabIndex = 38
        Me.Label26.Text = "To :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(25, 22)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(41, 15)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = "From :"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(72, 17)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(81, 23)
        Me.dtpDateFrom.TabIndex = 36
        '
        'btnGetData
        '
        Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetData.Location = New System.Drawing.Point(334, 20)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(61, 20)
        Me.btnGetData.TabIndex = 35
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApproveToolStripButton2, Me.CancelDeliveryToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(30, 464)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(160, 40)
        Me.ToolStrip1.TabIndex = 171
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ApproveToolStripButton2
        '
        Me.ApproveToolStripButton2.Image = CType(resources.GetObject("ApproveToolStripButton2.Image"), System.Drawing.Image)
        Me.ApproveToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ApproveToolStripButton2.Name = "ApproveToolStripButton2"
        Me.ApproveToolStripButton2.Size = New System.Drawing.Size(72, 37)
        Me.ApproveToolStripButton2.Text = "Approve"
        '
        'CancelDeliveryToolStripButton
        '
        Me.CancelDeliveryToolStripButton.AutoSize = False
        Me.CancelDeliveryToolStripButton.Image = CType(resources.GetObject("CancelDeliveryToolStripButton.Image"), System.Drawing.Image)
        Me.CancelDeliveryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelDeliveryToolStripButton.Name = "CancelDeliveryToolStripButton"
        Me.CancelDeliveryToolStripButton.Size = New System.Drawing.Size(65, 40)
        Me.CancelDeliveryToolStripButton.Text = " Cancel "
        '
        'btnAddMaterial
        '
        Me.btnAddMaterial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMaterial.Location = New System.Drawing.Point(670, 22)
        Me.btnAddMaterial.Name = "btnAddMaterial"
        Me.btnAddMaterial.Size = New System.Drawing.Size(81, 20)
        Me.btnAddMaterial.TabIndex = 44
        Me.btnAddMaterial.Text = "Add Material"
        Me.btnAddMaterial.UseVisualStyleBackColor = True
        '
        'frmDeliveryApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 512)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmDeliveryApproval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents dgw As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents btnGetData As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ApproveToolStripButton2 As ToolStripButton
    Friend WithEvents CancelDeliveryToolStripButton As ToolStripButton
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents chkApproveDelivery As CheckBox
    Friend WithEvents chkCancelDelivery As CheckBox
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents PriceColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents colStockinID As DataGridViewTextBoxColumn
    Friend WithEvents colDocNo As DataGridViewTextBoxColumn
    Friend WithEvents btnAddMaterial As Button
End Class
