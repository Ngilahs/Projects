<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateTools
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateTools))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtUnitofIssue = New System.Windows.Forms.TextBox()
        Me.lblMinimumStock = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtStocksOnHand = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLCateID = New System.Windows.Forms.Label()
        Me.lblToolNo = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.txttooldescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PSaveToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.PUpdateToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSuppID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwItemsStockonHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 35)
        Me.Panel1.TabIndex = 175
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(278, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Create Tool "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtUnitofIssue)
        Me.GroupBox1.Controls.Add(Me.lblMinimumStock)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtqty)
        Me.GroupBox1.Controls.Add(Me.txtStocksOnHand)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LBLCateID)
        Me.GroupBox1.Controls.Add(Me.lblToolNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 84)
        Me.GroupBox1.TabIndex = 176
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tool & Equipment Details"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(83, 20)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(173, 23)
        Me.txtDescription.TabIndex = 1
        '
        'txtUnitofIssue
        '
        Me.txtUnitofIssue.Location = New System.Drawing.Point(408, 19)
        Me.txtUnitofIssue.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.txtUnitofIssue.MaxLength = 13
        Me.txtUnitofIssue.Name = "txtUnitofIssue"
        Me.txtUnitofIssue.Size = New System.Drawing.Size(210, 23)
        Me.txtUnitofIssue.TabIndex = 466
        '
        'lblMinimumStock
        '
        Me.lblMinimumStock.AutoSize = True
        Me.lblMinimumStock.BackColor = System.Drawing.Color.Transparent
        Me.lblMinimumStock.ForeColor = System.Drawing.Color.Black
        Me.lblMinimumStock.Location = New System.Drawing.Point(319, 19)
        Me.lblMinimumStock.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.lblMinimumStock.Name = "lblMinimumStock"
        Me.lblMinimumStock.Size = New System.Drawing.Size(75, 15)
        Me.lblMinimumStock.TabIndex = 478
        Me.lblMinimumStock.Text = "Unit of Issue:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(319, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Available Qty:"
        '
        'txtqty
        '
        Me.txtqty.BackColor = System.Drawing.Color.White
        Me.txtqty.Location = New System.Drawing.Point(408, 49)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(210, 23)
        Me.txtqty.TabIndex = 14
        '
        'txtStocksOnHand
        '
        Me.txtStocksOnHand.AutoSize = True
        Me.txtStocksOnHand.Location = New System.Drawing.Point(449, 130)
        Me.txtStocksOnHand.Name = "txtStocksOnHand"
        Me.txtStocksOnHand.Size = New System.Drawing.Size(0, 15)
        Me.txtStocksOnHand.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGray
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(234, 55)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 17)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tool Name :"
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.White
        Me.txtCategory.Location = New System.Drawing.Point(83, 51)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(145, 23)
        Me.txtCategory.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Category :"
        '
        'LBLCateID
        '
        Me.LBLCateID.AutoSize = True
        Me.LBLCateID.Location = New System.Drawing.Point(207, 56)
        Me.LBLCateID.Name = "LBLCateID"
        Me.LBLCateID.Size = New System.Drawing.Size(21, 15)
        Me.LBLCateID.TabIndex = 23
        Me.LBLCateID.Text = "##"
        Me.LBLCateID.Visible = False
        '
        'lblToolNo
        '
        Me.lblToolNo.AutoSize = True
        Me.lblToolNo.Location = New System.Drawing.Point(207, 26)
        Me.lblToolNo.Name = "lblToolNo"
        Me.lblToolNo.Size = New System.Drawing.Size(14, 15)
        Me.lblToolNo.TabIndex = 479
        Me.lblToolNo.Text = "#"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnReset)
        Me.GroupBox4.Controls.Add(Me.txttooldescription)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(2, 133)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(642, 40)
        Me.GroupBox4.TabIndex = 177
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search Tools"
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(582, 12)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(52, 23)
        Me.BtnReset.TabIndex = 20
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'txttooldescription
        '
        Me.txttooldescription.BackColor = System.Drawing.Color.White
        Me.txttooldescription.Location = New System.Drawing.Point(83, 14)
        Me.txttooldescription.Name = "txttooldescription"
        Me.txttooldescription.Size = New System.Drawing.Size(156, 20)
        Me.txttooldescription.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Tool Name :"
        Me.Label7.UseWaitCursor = True
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
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column3, Me.colSuppID, Me.dgwItemsStockonHand, Me.Column2})
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
        Me.dgw.Location = New System.Drawing.Point(2, 179)
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
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(642, 197)
        Me.dgw.TabIndex = 178
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.PSaveToolStripButton5, Me.PUpdateToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(198, 388)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(281, 41)
        Me.ToolStrip1.TabIndex = 179
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
        'Column7
        '
        Me.Column7.HeaderText = "Tool No"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 65
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tool Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Category Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 120
        '
        'colSuppID
        '
        Me.colSuppID.HeaderText = "Category ID"
        Me.colSuppID.Name = "colSuppID"
        Me.colSuppID.ReadOnly = True
        Me.colSuppID.Visible = False
        '
        'dgwItemsStockonHand
        '
        Me.dgwItemsStockonHand.HeaderText = "Available Quantity"
        Me.dgwItemsStockonHand.Name = "dgwItemsStockonHand"
        Me.dgwItemsStockonHand.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Unit of Issue"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'frmCreateTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 438)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCreateTools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents txtUnitofIssue As TextBox
    Private WithEvents lblMinimumStock As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents txtStocksOnHand As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLCateID As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnReset As Button
    Friend WithEvents txttooldescription As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgw As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents PSaveToolStripButton5 As ToolStripButton
    Friend WithEvents PUpdateToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents lblToolNo As Label
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents colSuppID As DataGridViewTextBoxColumn
    Friend WithEvents dgwItemsStockonHand As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
