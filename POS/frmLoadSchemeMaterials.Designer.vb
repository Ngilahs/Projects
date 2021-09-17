<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadSchemeMaterials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoadSchemeMaterials))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.MasterlistSaveToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.PUpdateToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSchemeName = New System.Windows.Forms.TextBox()
        Me.txtSchemeRefNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddtoGrid = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtytoIssue = New System.Windows.Forms.TextBox()
        Me.cmdSearchItems = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgwIssueItems = New System.Windows.Forms.DataGridView()
        Me.dgwIssueMaterialsItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsUnitofIssue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtItemcount = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblScheme = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.TextBox()
        Me.txtUnitofIssue = New System.Windows.Forms.TextBox()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAllocationNo = New System.Windows.Forms.Label()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgwIssueItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 41)
        Me.Panel1.TabIndex = 176
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(347, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Scheme Material Masterlist "
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.MasterlistSaveToolStripButton5, Me.PUpdateToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(319, 497)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(281, 41)
        Me.ToolStrip1.TabIndex = 185
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 38)
        Me.ToolStripLabel1.Text = "   "
        '
        'MasterlistSaveToolStripButton5
        '
        Me.MasterlistSaveToolStripButton5.Image = CType(resources.GetObject("MasterlistSaveToolStripButton5.Image"), System.Drawing.Image)
        Me.MasterlistSaveToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MasterlistSaveToolStripButton5.Name = "MasterlistSaveToolStripButton5"
        Me.MasterlistSaveToolStripButton5.Size = New System.Drawing.Size(51, 38)
        Me.MasterlistSaveToolStripButton5.Text = "Save"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(283, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 262
        Me.Label1.Text = "Scheme No"
        '
        'txtSchemeName
        '
        Me.txtSchemeName.Enabled = False
        Me.txtSchemeName.Location = New System.Drawing.Point(545, 46)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(106, 20)
        Me.txtSchemeName.TabIndex = 261
        '
        'txtSchemeRefNo
        '
        Me.txtSchemeRefNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeRefNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeRefNo.Location = New System.Drawing.Point(352, 44)
        Me.txtSchemeRefNo.Name = "txtSchemeRefNo"
        Me.txtSchemeRefNo.Size = New System.Drawing.Size(104, 20)
        Me.txtSchemeRefNo.TabIndex = 260
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(658, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 259
        Me.Label6.Text = "UoM"
        '
        'btnAddtoGrid
        '
        Me.btnAddtoGrid.BackColor = System.Drawing.Color.Cyan
        Me.btnAddtoGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoGrid.Location = New System.Drawing.Point(837, 15)
        Me.btnAddtoGrid.Name = "btnAddtoGrid"
        Me.btnAddtoGrid.Size = New System.Drawing.Size(73, 53)
        Me.btnAddtoGrid.TabIndex = 257
        Me.btnAddtoGrid.Text = "Add Item"
        Me.btnAddtoGrid.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 256
        Me.Label4.Text = "Qty to Issue:"
        '
        'txtQtytoIssue
        '
        Me.txtQtytoIssue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtQtytoIssue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtQtytoIssue.Location = New System.Drawing.Point(91, 43)
        Me.txtQtytoIssue.Name = "txtQtytoIssue"
        Me.txtQtytoIssue.Size = New System.Drawing.Size(186, 20)
        Me.txtQtytoIssue.TabIndex = 255
        '
        'cmdSearchItems
        '
        Me.cmdSearchItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmdSearchItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmdSearchItems.FormattingEnabled = True
        Me.cmdSearchItems.Location = New System.Drawing.Point(91, 15)
        Me.cmdSearchItems.Name = "cmdSearchItems"
        Me.cmdSearchItems.Size = New System.Drawing.Size(186, 21)
        Me.cmdSearchItems.TabIndex = 254
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "Search Item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(283, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 252
        Me.Label2.Text = "Item No:"
        '
        'dgwIssueItems
        '
        Me.dgwIssueItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgwIssueItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwIssueItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwIssueMaterialsItemNo, Me.dgwIssueMaterialsItemName, Me.dgwIssueMaterialsQty, Me.dgwIssueMaterialsUnitofIssue})
        Me.dgwIssueItems.Location = New System.Drawing.Point(20, 19)
        Me.dgwIssueItems.Name = "dgwIssueItems"
        Me.dgwIssueItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgwIssueItems.Size = New System.Drawing.Size(890, 329)
        Me.dgwIssueItems.TabIndex = 250
        '
        'dgwIssueMaterialsItemNo
        '
        Me.dgwIssueMaterialsItemNo.HeaderText = "Item No"
        Me.dgwIssueMaterialsItemNo.Name = "dgwIssueMaterialsItemNo"
        Me.dgwIssueMaterialsItemNo.ReadOnly = True
        Me.dgwIssueMaterialsItemNo.Width = 150
        '
        'dgwIssueMaterialsItemName
        '
        Me.dgwIssueMaterialsItemName.HeaderText = "Item Name"
        Me.dgwIssueMaterialsItemName.Name = "dgwIssueMaterialsItemName"
        Me.dgwIssueMaterialsItemName.ReadOnly = True
        Me.dgwIssueMaterialsItemName.Width = 300
        '
        'dgwIssueMaterialsQty
        '
        Me.dgwIssueMaterialsQty.HeaderText = "Projected Quantity"
        Me.dgwIssueMaterialsQty.Name = "dgwIssueMaterialsQty"
        Me.dgwIssueMaterialsQty.Width = 200
        '
        'dgwIssueMaterialsUnitofIssue
        '
        Me.dgwIssueMaterialsUnitofIssue.HeaderText = "Unit of Issue"
        Me.dgwIssueMaterialsUnitofIssue.Name = "dgwIssueMaterialsUnitofIssue"
        Me.dgwIssueMaterialsUnitofIssue.ReadOnly = True
        Me.dgwIssueMaterialsUnitofIssue.Width = 150
        '
        'txtItemcount
        '
        Me.txtItemcount.Enabled = False
        Me.txtItemcount.Location = New System.Drawing.Point(736, 16)
        Me.txtItemcount.Name = "txtItemcount"
        Me.txtItemcount.Size = New System.Drawing.Size(95, 20)
        Me.txtItemcount.TabIndex = 248
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(658, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 13)
        Me.Label18.TabIndex = 247
        Me.Label18.Text = "Item Count:"
        '
        'lblScheme
        '
        Me.lblScheme.AutoSize = True
        Me.lblScheme.BackColor = System.Drawing.Color.DimGray
        Me.lblScheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheme.ForeColor = System.Drawing.Color.Cyan
        Me.lblScheme.Location = New System.Drawing.Point(462, 48)
        Me.lblScheme.Name = "lblScheme"
        Me.lblScheme.Size = New System.Drawing.Size(77, 13)
        Me.lblScheme.TabIndex = 249
        Me.lblScheme.Text = "Scheme Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(462, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 13)
        Me.Label19.TabIndex = 246
        Me.Label19.Text = "Date Issued:"
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbldate.Enabled = False
        Me.lbldate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(547, 15)
        Me.lbldate.MaxLength = 50
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(105, 22)
        Me.lbldate.TabIndex = 245
        '
        'txtUnitofIssue
        '
        Me.txtUnitofIssue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtUnitofIssue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtUnitofIssue.Enabled = False
        Me.txtUnitofIssue.Location = New System.Drawing.Point(736, 45)
        Me.txtUnitofIssue.Name = "txtUnitofIssue"
        Me.txtUnitofIssue.Size = New System.Drawing.Size(95, 20)
        Me.txtUnitofIssue.TabIndex = 258
        '
        'txtItemCode
        '
        Me.txtItemCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtItemCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtItemCode.Enabled = False
        Me.txtItemCode.Location = New System.Drawing.Point(352, 17)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(104, 20)
        Me.txtItemCode.TabIndex = 251
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddtoGrid)
        Me.GroupBox1.Controls.Add(Me.lblAllocationNo)
        Me.GroupBox1.Controls.Add(Me.txtSchemeName)
        Me.GroupBox1.Controls.Add(Me.txtCountyID)
        Me.GroupBox1.Controls.Add(Me.txtConstituencyID)
        Me.GroupBox1.Controls.Add(Me.txtSchemeID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtItemCode)
        Me.GroupBox1.Controls.Add(Me.txtUnitofIssue)
        Me.GroupBox1.Controls.Add(Me.txtSchemeRefNo)
        Me.GroupBox1.Controls.Add(Me.lbldate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.lblScheme)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtQtytoIssue)
        Me.GroupBox1.Controls.Add(Me.txtItemcount)
        Me.GroupBox1.Controls.Add(Me.cmdSearchItems)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(916, 85)
        Me.GroupBox1.TabIndex = 263
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Material"
        '
        'lblAllocationNo
        '
        Me.lblAllocationNo.AutoSize = True
        Me.lblAllocationNo.Location = New System.Drawing.Point(849, 23)
        Me.lblAllocationNo.Name = "lblAllocationNo"
        Me.lblAllocationNo.Size = New System.Drawing.Size(42, 13)
        Me.lblAllocationNo.TabIndex = 266
        Me.lblAllocationNo.Text = "#####"
        '
        'txtCountyID
        '
        Me.txtCountyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCountyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCountyID.Location = New System.Drawing.Point(577, 46)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(28, 20)
        Me.txtCountyID.TabIndex = 264
        Me.txtCountyID.Visible = False
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConstituencyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtConstituencyID.Location = New System.Drawing.Point(547, 46)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(24, 20)
        Me.txtConstituencyID.TabIndex = 265
        Me.txtConstituencyID.Visible = False
        '
        'txtSchemeID
        '
        Me.txtSchemeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeID.Location = New System.Drawing.Point(611, 46)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(24, 20)
        Me.txtSchemeID.TabIndex = 263
        Me.txtSchemeID.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgwIssueItems)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(916, 354)
        Me.GroupBox2.TabIndex = 264
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scheme Materials"
        '
        'frmLoadSchemeMaterials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 547)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmLoadSchemeMaterials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgwIssueItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents MasterlistSaveToolStripButton5 As ToolStripButton
    Friend WithEvents PUpdateToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSchemeName As TextBox
    Friend WithEvents txtSchemeRefNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddtoGrid As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQtytoIssue As TextBox
    Friend WithEvents cmdSearchItems As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgwIssueItems As DataGridView
    Friend WithEvents txtItemcount As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents lblScheme As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbldate As TextBox
    Friend WithEvents txtUnitofIssue As TextBox
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents dgwIssueMaterialsItemNo As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsItemName As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsQty As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsUnitofIssue As DataGridViewTextBoxColumn
    Friend WithEvents lblAllocationNo As Label
End Class
