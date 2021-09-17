<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployees
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployees))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.txtstaffs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStaffNo = New System.Windows.Forms.Label()
        Me.txtnationalIDNo = New System.Windows.Forms.TextBox()
        Me.lblMaximumStock = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtStocksOnHand = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRolename = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLRoleID = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PSaveToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.PUpdateToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwItemsStockonHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSuppID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReorderLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwitemCateID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(200, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 266
        Me.Label2.Text = " Staff"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(-4, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(482, 41)
        Me.TextBox1.TabIndex = 265
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnReset)
        Me.GroupBox4.Controls.Add(Me.txtstaffs)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 134)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(473, 40)
        Me.GroupBox4.TabIndex = 269
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search Staff"
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.Red
        Me.BtnReset.Location = New System.Drawing.Point(421, 14)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(52, 23)
        Me.BtnReset.TabIndex = 20
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'txtstaffs
        '
        Me.txtstaffs.BackColor = System.Drawing.Color.White
        Me.txtstaffs.Location = New System.Drawing.Point(76, 14)
        Me.txtstaffs.Name = "txtstaffs"
        Me.txtstaffs.Size = New System.Drawing.Size(196, 20)
        Me.txtstaffs.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Staff Name :"
        Me.Label7.UseWaitCursor = True
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
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
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.dgwItemsStockonHand, Me.colSuppID, Me.ReorderLevel, Me.dgwitemCateID})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(5, 180)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
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
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(473, 255)
        Me.dgw.TabIndex = 268
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnationalIDNo)
        Me.GroupBox1.Controls.Add(Me.lblMaximumStock)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNo)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtStocksOnHand)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txtStaffName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRolename)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LBLRoleID)
        Me.GroupBox1.Controls.Add(Me.lblStaffNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 83)
        Me.GroupBox1.TabIndex = 267
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Staff Information"
        '
        'lblStaffNo
        '
        Me.lblStaffNo.AutoSize = True
        Me.lblStaffNo.Location = New System.Drawing.Point(197, 24)
        Me.lblStaffNo.Name = "lblStaffNo"
        Me.lblStaffNo.Size = New System.Drawing.Size(21, 15)
        Me.lblStaffNo.TabIndex = 485
        Me.lblStaffNo.Text = "##"
        Me.lblStaffNo.Visible = False
        '
        'txtnationalIDNo
        '
        Me.txtnationalIDNo.Location = New System.Drawing.Point(359, 49)
        Me.txtnationalIDNo.Name = "txtnationalIDNo"
        Me.txtnationalIDNo.Size = New System.Drawing.Size(103, 23)
        Me.txtnationalIDNo.TabIndex = 482
        '
        'lblMaximumStock
        '
        Me.lblMaximumStock.AutoSize = True
        Me.lblMaximumStock.BackColor = System.Drawing.Color.Transparent
        Me.lblMaximumStock.ForeColor = System.Drawing.Color.Black
        Me.lblMaximumStock.Location = New System.Drawing.Point(284, 53)
        Me.lblMaximumStock.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.lblMaximumStock.Name = "lblMaximumStock"
        Me.lblMaximumStock.Size = New System.Drawing.Size(69, 15)
        Me.lblMaximumStock.TabIndex = 473
        Me.lblMaximumStock.Text = "National ID:"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.BackColor = System.Drawing.Color.White
        Me.txtPhoneNo.Location = New System.Drawing.Point(359, 16)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(103, 23)
        Me.txtPhoneNo.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(284, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 15)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Phone No:"
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
        Me.Button3.Location = New System.Drawing.Point(244, 52)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 17)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtStaffName
        '
        Me.txtStaffName.BackColor = System.Drawing.Color.White
        Me.txtStaffName.Location = New System.Drawing.Point(76, 18)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(162, 23)
        Me.txtStaffName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Staff Name :"
        '
        'txtRolename
        '
        Me.txtRolename.BackColor = System.Drawing.Color.White
        Me.txtRolename.Location = New System.Drawing.Point(76, 49)
        Me.txtRolename.Name = "txtRolename"
        Me.txtRolename.Size = New System.Drawing.Size(162, 23)
        Me.txtRolename.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Staff Role :"
        '
        'LBLRoleID
        '
        Me.LBLRoleID.AutoSize = True
        Me.LBLRoleID.Location = New System.Drawing.Point(217, 52)
        Me.LBLRoleID.Name = "LBLRoleID"
        Me.LBLRoleID.Size = New System.Drawing.Size(21, 15)
        Me.LBLRoleID.TabIndex = 23
        Me.LBLRoleID.Text = "##"
        Me.LBLRoleID.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.PSaveToolStripButton5, Me.PUpdateToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(112, 452)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(281, 41)
        Me.ToolStrip1.TabIndex = 270
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
        Me.Column7.HeaderText = "Emp No"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = " Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 75
        '
        'dgwItemsStockonHand
        '
        Me.dgwItemsStockonHand.HeaderText = "Role Name"
        Me.dgwItemsStockonHand.Name = "dgwItemsStockonHand"
        Me.dgwItemsStockonHand.ReadOnly = True
        Me.dgwItemsStockonHand.Width = 75
        '
        'colSuppID
        '
        Me.colSuppID.HeaderText = "Role ID"
        Me.colSuppID.Name = "colSuppID"
        Me.colSuppID.ReadOnly = True
        Me.colSuppID.Width = 65
        '
        'ReorderLevel
        '
        Me.ReorderLevel.HeaderText = "Phone No"
        Me.ReorderLevel.Name = "ReorderLevel"
        Me.ReorderLevel.ReadOnly = True
        Me.ReorderLevel.Width = 75
        '
        'dgwitemCateID
        '
        Me.dgwitemCateID.HeaderText = "National ID"
        Me.dgwitemCateID.Name = "dgwitemCateID"
        Me.dgwitemCateID.ReadOnly = True
        Me.dgwitemCateID.Width = 65
        '
        'frmEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 495)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnReset As Button
    Friend WithEvents txtstaffs As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgw As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtnationalIDNo As TextBox
    Private WithEvents lblMaximumStock As Label
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtStocksOnHand As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRolename As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLRoleID As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents PSaveToolStripButton5 As ToolStripButton
    Friend WithEvents PUpdateToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents lblStaffNo As Label
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dgwItemsStockonHand As DataGridViewTextBoxColumn
    Friend WithEvents colSuppID As DataGridViewTextBoxColumn
    Friend WithEvents ReorderLevel As DataGridViewTextBoxColumn
    Friend WithEvents dgwitemCateID As DataGridViewTextBoxColumn
End Class
