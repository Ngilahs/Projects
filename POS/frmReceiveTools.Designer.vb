<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiveTools
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceiveTools))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddtoGrid = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtyIn = New System.Windows.Forms.TextBox()
        Me.cmdSearchtools = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttotalqty = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.TextBox()
        Me.txtQtyonHand = New System.Windows.Forms.TextBox()
        Me.txttoolno = New System.Windows.Forms.TextBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.dgwIssueMaterialsItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsQtyBal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsUnitofIssue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDocuNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PSaveToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.VoidToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txtunitofissue = New System.Windows.Forms.TextBox()
        Me.lblReceiveNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(213, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 258
        Me.Label6.Text = "Avl Qty:"
        '
        'btnAddtoGrid
        '
        Me.btnAddtoGrid.BackColor = System.Drawing.Color.Cyan
        Me.btnAddtoGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoGrid.Location = New System.Drawing.Point(606, 75)
        Me.btnAddtoGrid.Name = "btnAddtoGrid"
        Me.btnAddtoGrid.Size = New System.Drawing.Size(45, 25)
        Me.btnAddtoGrid.TabIndex = 256
        Me.btnAddtoGrid.Text = "Add"
        Me.btnAddtoGrid.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 255
        Me.Label4.Text = "Quantity In:"
        '
        'txtQtyIn
        '
        Me.txtQtyIn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtQtyIn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtQtyIn.Location = New System.Drawing.Point(90, 78)
        Me.txtQtyIn.Name = "txtQtyIn"
        Me.txtQtyIn.Size = New System.Drawing.Size(117, 20)
        Me.txtQtyIn.TabIndex = 254
        '
        'cmdSearchtools
        '
        Me.cmdSearchtools.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmdSearchtools.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmdSearchtools.FormattingEnabled = True
        Me.cmdSearchtools.Location = New System.Drawing.Point(90, 47)
        Me.cmdSearchtools.Name = "cmdSearchtools"
        Me.cmdSearchtools.Size = New System.Drawing.Size(117, 21)
        Me.cmdSearchtools.TabIndex = 253
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 252
        Me.Label5.Text = "Search Tools:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(213, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 251
        Me.Label3.Text = "Tools No:"
        '
        'txttotalqty
        '
        Me.txttotalqty.Enabled = False
        Me.txttotalqty.Location = New System.Drawing.Point(328, 78)
        Me.txttotalqty.Name = "txttotalqty"
        Me.txttotalqty.Size = New System.Drawing.Size(25, 20)
        Me.txttotalqty.TabIndex = 248
        Me.txttotalqty.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(359, 49)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 13)
        Me.Label19.TabIndex = 246
        Me.Label19.Text = "Date:"
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbldate.Enabled = False
        Me.lbldate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(401, 45)
        Me.lbldate.MaxLength = 50
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(91, 22)
        Me.lbldate.TabIndex = 245
        '
        'txtQtyonHand
        '
        Me.txtQtyonHand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtQtyonHand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtQtyonHand.Enabled = False
        Me.txtQtyonHand.Location = New System.Drawing.Point(278, 78)
        Me.txtQtyonHand.Name = "txtQtyonHand"
        Me.txtQtyonHand.Size = New System.Drawing.Size(79, 20)
        Me.txtQtyonHand.TabIndex = 257
        '
        'txttoolno
        '
        Me.txttoolno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txttoolno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txttoolno.Enabled = False
        Me.txttoolno.Location = New System.Drawing.Point(281, 47)
        Me.txttoolno.Name = "txttoolno"
        Me.txttoolno.Size = New System.Drawing.Size(76, 20)
        Me.txttoolno.TabIndex = 250
        '
        'dgw
        '
        Me.dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwIssueMaterialsItemNo, Me.dgwIssueMaterialsItemName, Me.dgwIssueMaterialsQty, Me.dgwIssueMaterialsQtyBal, Me.dgwIssueMaterialsUnitofIssue, Me.colDocuNo})
        Me.dgw.Location = New System.Drawing.Point(9, 104)
        Me.dgw.Name = "dgw"
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(643, 251)
        Me.dgw.TabIndex = 262
        '
        'dgwIssueMaterialsItemNo
        '
        Me.dgwIssueMaterialsItemNo.HeaderText = "Tool No"
        Me.dgwIssueMaterialsItemNo.Name = "dgwIssueMaterialsItemNo"
        Me.dgwIssueMaterialsItemNo.ReadOnly = True
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
        '
        'dgwIssueMaterialsQtyBal
        '
        Me.dgwIssueMaterialsQtyBal.HeaderText = "Qty Bal"
        Me.dgwIssueMaterialsQtyBal.Name = "dgwIssueMaterialsQtyBal"
        Me.dgwIssueMaterialsQtyBal.ReadOnly = True
        Me.dgwIssueMaterialsQtyBal.Width = 75
        '
        'dgwIssueMaterialsUnitofIssue
        '
        Me.dgwIssueMaterialsUnitofIssue.HeaderText = "UoM"
        Me.dgwIssueMaterialsUnitofIssue.Name = "dgwIssueMaterialsUnitofIssue"
        Me.dgwIssueMaterialsUnitofIssue.ReadOnly = True
        Me.dgwIssueMaterialsUnitofIssue.Width = 75
        '
        'colDocuNo
        '
        Me.colDocuNo.HeaderText = "Doc No"
        Me.colDocuNo.Name = "colDocuNo"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(-4, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(665, 41)
        Me.TextBox1.TabIndex = 263
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(200, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 20)
        Me.Label2.TabIndex = 264
        Me.Label2.Text = " Receive Tools / Equipments"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.PSaveToolStripButton5, Me.VoidToolStripButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(243, 358)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(223, 41)
        Me.ToolStrip1.TabIndex = 265
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
        'VoidToolStripButton2
        '
        Me.VoidToolStripButton2.AutoSize = False
        Me.VoidToolStripButton2.Image = CType(resources.GetObject("VoidToolStripButton2.Image"), System.Drawing.Image)
        Me.VoidToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.VoidToolStripButton2.Name = "VoidToolStripButton2"
        Me.VoidToolStripButton2.Size = New System.Drawing.Size(65, 40)
        Me.VoidToolStripButton2.Text = "Vo&id"
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
        'txtunitofissue
        '
        Me.txtunitofissue.Enabled = False
        Me.txtunitofissue.Location = New System.Drawing.Point(401, 78)
        Me.txtunitofissue.Name = "txtunitofissue"
        Me.txtunitofissue.Size = New System.Drawing.Size(91, 20)
        Me.txtunitofissue.TabIndex = 266
        '
        'lblReceiveNo
        '
        Me.lblReceiveNo.AutoSize = True
        Me.lblReceiveNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiveNo.Location = New System.Drawing.Point(554, 81)
        Me.lblReceiveNo.Name = "lblReceiveNo"
        Me.lblReceiveNo.Size = New System.Drawing.Size(47, 13)
        Me.lblReceiveNo.TabIndex = 267
        Me.lblReceiveNo.Text = "#####"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(359, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 268
        Me.Label1.Text = "Unit:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(497, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 269
        Me.Label7.Text = "Doc No:"
        '
        'txtDocNo
        '
        Me.txtDocNo.Location = New System.Drawing.Point(557, 46)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(95, 20)
        Me.txtDocNo.TabIndex = 270
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(497, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 271
        Me.Label8.Text = "Rcpt No:"
        '
        'frmReceiveTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 401)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDocNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblReceiveNo)
        Me.Controls.Add(Me.txtunitofissue)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAddtoGrid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQtyIn)
        Me.Controls.Add(Me.cmdSearchtools)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.txtQtyonHand)
        Me.Controls.Add(Me.txttoolno)
        Me.Controls.Add(Me.txttotalqty)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmReceiveTools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddtoGrid As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQtyIn As TextBox
    Friend WithEvents cmdSearchtools As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txttotalqty As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lbldate As TextBox
    Friend WithEvents txtQtyonHand As TextBox
    Friend WithEvents txttoolno As TextBox
    Friend WithEvents dgw As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents PSaveToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents txtunitofissue As TextBox
    Friend WithEvents lblReceiveNo As Label
    Friend WithEvents VoidToolStripButton2 As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDocNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgwIssueMaterialsItemNo As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsItemName As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsQty As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsQtyBal As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsUnitofIssue As DataGridViewTextBoxColumn
    Friend WithEvents colDocuNo As DataGridViewTextBoxColumn
End Class
