<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIssueTools
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIssueTools))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.dgwToolNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsQtyBal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsUnitofIssue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIssuanceNo = New System.Windows.Forms.Label()
        Me.btnAddtoGrid = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtytoIssue = New System.Windows.Forms.TextBox()
        Me.cboSearchTools = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.TextBox()
        Me.txtToolNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PSaveToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.VoidToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txtAvailableQty = New System.Windows.Forms.TextBox()
        Me.txtQtyBal = New System.Windows.Forms.TextBox()
        Me.txtUnitofIssue = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmployeeNo = New System.Windows.Forms.Label()
        Me.cboEmployeeName = New System.Windows.Forms.ComboBox()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(649, 39)
        Me.TextBox1.TabIndex = 282
        '
        'dgw
        '
        Me.dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwToolNo, Me.dgwIssueMaterialsItemName, Me.dgwIssueMaterialsQty, Me.dgwIssueMaterialsQtyBal, Me.dgwIssueMaterialsUnitofIssue})
        Me.dgw.Location = New System.Drawing.Point(9, 108)
        Me.dgw.Name = "dgw"
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(636, 255)
        Me.dgw.TabIndex = 281
        '
        'dgwToolNo
        '
        Me.dgwToolNo.HeaderText = "Tool No"
        Me.dgwToolNo.Name = "dgwToolNo"
        Me.dgwToolNo.ReadOnly = True
        '
        'dgwIssueMaterialsItemName
        '
        Me.dgwIssueMaterialsItemName.HeaderText = "Tool Name"
        Me.dgwIssueMaterialsItemName.Name = "dgwIssueMaterialsItemName"
        Me.dgwIssueMaterialsItemName.ReadOnly = True
        '
        'dgwIssueMaterialsQty
        '
        Me.dgwIssueMaterialsQty.HeaderText = "Quantity"
        Me.dgwIssueMaterialsQty.Name = "dgwIssueMaterialsQty"
        Me.dgwIssueMaterialsQty.Width = 120
        '
        'dgwIssueMaterialsQtyBal
        '
        Me.dgwIssueMaterialsQtyBal.HeaderText = "Qty Balance"
        Me.dgwIssueMaterialsQtyBal.Name = "dgwIssueMaterialsQtyBal"
        Me.dgwIssueMaterialsQtyBal.ReadOnly = True
        '
        'dgwIssueMaterialsUnitofIssue
        '
        Me.dgwIssueMaterialsUnitofIssue.HeaderText = "Unit of Issue"
        Me.dgwIssueMaterialsUnitofIssue.Name = "dgwIssueMaterialsUnitofIssue"
        Me.dgwIssueMaterialsUnitofIssue.ReadOnly = True
        Me.dgwIssueMaterialsUnitofIssue.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(226, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 280
        Me.Label1.Text = "Issued To:"
        '
        'lblIssuanceNo
        '
        Me.lblIssuanceNo.AutoSize = True
        Me.lblIssuanceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssuanceNo.Location = New System.Drawing.Point(617, 51)
        Me.lblIssuanceNo.Name = "lblIssuanceNo"
        Me.lblIssuanceNo.Size = New System.Drawing.Size(35, 13)
        Me.lblIssuanceNo.TabIndex = 277
        Me.lblIssuanceNo.Text = "###:"
        '
        'btnAddtoGrid
        '
        Me.btnAddtoGrid.BackColor = System.Drawing.Color.Cyan
        Me.btnAddtoGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoGrid.Location = New System.Drawing.Point(614, 72)
        Me.btnAddtoGrid.Name = "btnAddtoGrid"
        Me.btnAddtoGrid.Size = New System.Drawing.Size(38, 25)
        Me.btnAddtoGrid.TabIndex = 275
        Me.btnAddtoGrid.Text = "Add "
        Me.btnAddtoGrid.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 274
        Me.Label4.Text = "Qty to Issue:"
        '
        'txtQtytoIssue
        '
        Me.txtQtytoIssue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtQtytoIssue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtQtytoIssue.Location = New System.Drawing.Point(97, 80)
        Me.txtQtytoIssue.Name = "txtQtytoIssue"
        Me.txtQtytoIssue.Size = New System.Drawing.Size(123, 20)
        Me.txtQtytoIssue.TabIndex = 273
        '
        'cboSearchTools
        '
        Me.cboSearchTools.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSearchTools.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSearchTools.FormattingEnabled = True
        Me.cboSearchTools.Location = New System.Drawing.Point(97, 49)
        Me.cboSearchTools.Name = "cboSearchTools"
        Me.cboSearchTools.Size = New System.Drawing.Size(123, 21)
        Me.cboSearchTools.TabIndex = 272
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 271
        Me.Label5.Text = "Search Tools:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(226, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 270
        Me.Label3.Text = "Tool No:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(422, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 13)
        Me.Label19.TabIndex = 265
        Me.Label19.Text = "Date:"
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbldate.Enabled = False
        Me.lbldate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(466, 47)
        Me.lbldate.MaxLength = 50
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(145, 22)
        Me.lbldate.TabIndex = 264
        '
        'txtToolNo
        '
        Me.txtToolNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtToolNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtToolNo.Enabled = False
        Me.txtToolNo.Location = New System.Drawing.Point(288, 49)
        Me.txtToolNo.Name = "txtToolNo"
        Me.txtToolNo.Size = New System.Drawing.Size(132, 20)
        Me.txtToolNo.TabIndex = 269
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(216, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 18)
        Me.Label2.TabIndex = 283
        Me.Label2.Text = " Issue Tools / Equipments"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.PSaveToolStripButton5, Me.VoidToolStripButton, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(232, 366)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(228, 41)
        Me.ToolStrip1.TabIndex = 284
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
        'VoidToolStripButton
        '
        Me.VoidToolStripButton.AutoSize = False
        Me.VoidToolStripButton.Image = CType(resources.GetObject("VoidToolStripButton.Image"), System.Drawing.Image)
        Me.VoidToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.VoidToolStripButton.Name = "VoidToolStripButton"
        Me.VoidToolStripButton.Size = New System.Drawing.Size(65, 40)
        Me.VoidToolStripButton.Text = "Vo&id"
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
        'txtAvailableQty
        '
        Me.txtAvailableQty.Enabled = False
        Me.txtAvailableQty.Location = New System.Drawing.Point(577, 48)
        Me.txtAvailableQty.Name = "txtAvailableQty"
        Me.txtAvailableQty.Size = New System.Drawing.Size(27, 20)
        Me.txtAvailableQty.TabIndex = 285
        Me.txtAvailableQty.Visible = False
        '
        'txtQtyBal
        '
        Me.txtQtyBal.Enabled = False
        Me.txtQtyBal.Location = New System.Drawing.Point(577, 77)
        Me.txtQtyBal.Name = "txtQtyBal"
        Me.txtQtyBal.Size = New System.Drawing.Size(27, 20)
        Me.txtQtyBal.TabIndex = 286
        Me.txtQtyBal.Visible = False
        '
        'txtUnitofIssue
        '
        Me.txtUnitofIssue.Enabled = False
        Me.txtUnitofIssue.Location = New System.Drawing.Point(466, 77)
        Me.txtUnitofIssue.Name = "txtUnitofIssue"
        Me.txtUnitofIssue.Size = New System.Drawing.Size(145, 20)
        Me.txtUnitofIssue.TabIndex = 287
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(426, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 288
        Me.Label6.Text = "Unit:"
        '
        'txtEmployeeNo
        '
        Me.txtEmployeeNo.AutoSize = True
        Me.txtEmployeeNo.Location = New System.Drawing.Point(399, 84)
        Me.txtEmployeeNo.Name = "txtEmployeeNo"
        Me.txtEmployeeNo.Size = New System.Drawing.Size(21, 13)
        Me.txtEmployeeNo.TabIndex = 289
        Me.txtEmployeeNo.Text = "##"
        '
        'cboEmployeeName
        '
        Me.cboEmployeeName.FormattingEnabled = True
        Me.cboEmployeeName.Location = New System.Drawing.Point(288, 80)
        Me.cboEmployeeName.Name = "cboEmployeeName"
        Me.cboEmployeeName.Size = New System.Drawing.Size(132, 21)
        Me.cboEmployeeName.TabIndex = 290
        '
        'frmIssueTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 407)
        Me.Controls.Add(Me.cboEmployeeName)
        Me.Controls.Add(Me.txtEmployeeNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtUnitofIssue)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblIssuanceNo)
        Me.Controls.Add(Me.btnAddtoGrid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQtytoIssue)
        Me.Controls.Add(Me.cboSearchTools)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.txtToolNo)
        Me.Controls.Add(Me.txtQtyBal)
        Me.Controls.Add(Me.txtAvailableQty)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmIssueTools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgw As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIssuanceNo As Label
    Friend WithEvents btnAddtoGrid As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQtytoIssue As TextBox
    Friend WithEvents cboSearchTools As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbldate As TextBox
    Friend WithEvents txtToolNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents PSaveToolStripButton5 As ToolStripButton
    Friend WithEvents txtAvailableQty As TextBox
    Friend WithEvents txtQtyBal As TextBox
    Friend WithEvents txtUnitofIssue As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents VoidToolStripButton As ToolStripButton
    Friend WithEvents dgwToolNo As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsItemName As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsQty As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsQtyBal As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsUnitofIssue As DataGridViewTextBoxColumn
    Friend WithEvents txtEmployeeNo As Label
    Friend WithEvents cboEmployeeName As ComboBox
End Class
