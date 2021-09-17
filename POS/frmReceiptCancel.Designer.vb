<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiptCancel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceiptCancel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblReceiptNo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSchemeName = New System.Windows.Forms.TextBox()
        Me.txtDeliveryNo = New System.Windows.Forms.TextBox()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIssuancedate = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.txtDocuNo = New System.Windows.Forms.TextBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDocNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CancelReceiptToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.lbldateRS = New System.Windows.Forms.TextBox()
        Me.txtDoccccNo = New System.Windows.Forms.TextBox()
        Me.txtSearchReceiptNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgw1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 36)
        Me.Panel1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(377, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 20)
        Me.Label7.TabIndex = 222
        Me.Label7.Text = "Cancel Receipts"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgw1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtSearchReceiptNo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 398)
        Me.GroupBox2.TabIndex = 169
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material Receipts"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.LblReceiptNo)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.txtSchemeName)
        Me.GroupBox5.Controls.Add(Me.txtSupplier)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtIssuancedate)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtSchemeID)
        Me.GroupBox5.Location = New System.Drawing.Point(274, 53)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(695, 59)
        Me.GroupBox5.TabIndex = 170
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Receipt Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(636, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 217
        Me.Label3.Text = "Delivery#: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "Supplier: "
        '
        'LblReceiptNo
        '
        Me.LblReceiptNo.Enabled = False
        Me.LblReceiptNo.Location = New System.Drawing.Point(77, 20)
        Me.LblReceiptNo.Margin = New System.Windows.Forms.Padding(2)
        Me.LblReceiptNo.Name = "LblReceiptNo"
        Me.LblReceiptNo.Size = New System.Drawing.Size(113, 20)
        Me.LblReceiptNo.TabIndex = 206
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(194, 23)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(52, 13)
        Me.Label24.TabIndex = 201
        Me.Label24.Text = "Scheme: "
        '
        'txtSchemeName
        '
        Me.txtSchemeName.Enabled = False
        Me.txtSchemeName.Location = New System.Drawing.Point(252, 20)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(113, 20)
        Me.txtSchemeName.TabIndex = 200
        '
        'txtDeliveryNo
        '
        Me.txtDeliveryNo.Enabled = False
        Me.txtDeliveryNo.Location = New System.Drawing.Point(700, 184)
        Me.txtDeliveryNo.Name = "txtDeliveryNo"
        Me.txtDeliveryNo.Size = New System.Drawing.Size(78, 20)
        Me.txtDeliveryNo.TabIndex = 194
        Me.txtDeliveryNo.Visible = False
        '
        'txtSupplier
        '
        Me.txtSupplier.Enabled = False
        Me.txtSupplier.Location = New System.Drawing.Point(426, 18)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(100, 20)
        Me.txtSupplier.TabIndex = 186
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(537, 23)
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
        Me.txtIssuancedate.Location = New System.Drawing.Point(576, 17)
        Me.txtIssuancedate.MaxLength = 50
        Me.txtIssuancedate.Name = "txtIssuancedate"
        Me.txtIssuancedate.Size = New System.Drawing.Size(113, 22)
        Me.txtIssuancedate.TabIndex = 170
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(5, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Receipt No :"
        '
        'txtSchemeID
        '
        Me.txtSchemeID.Location = New System.Drawing.Point(353, 20)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(12, 20)
        Me.txtSchemeID.TabIndex = 209
        Me.txtSchemeID.Visible = False
        '
        'txtDocuNo
        '
        Me.txtDocuNo.Enabled = False
        Me.txtDocuNo.Location = New System.Drawing.Point(526, 181)
        Me.txtDocuNo.Name = "txtDocuNo"
        Me.txtDocuNo.Size = New System.Drawing.Size(61, 20)
        Me.txtDocuNo.TabIndex = 207
        Me.txtDocuNo.Visible = False
        '
        'dgw
        '
        Me.dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column7, Me.PriceColumn, Me.colDocNo, Me.Column9})
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(277, 118)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(692, 323)
        Me.dgw.TabIndex = 171
        '
        'Column4
        '
        Me.Column4.HeaderText = "Receipt No"
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
        '
        'PriceColumn
        '
        Me.PriceColumn.HeaderText = "Qty Received"
        Me.PriceColumn.Name = "PriceColumn"
        '
        'colDocNo
        '
        Me.colDocNo.HeaderText = "Doc No#"
        Me.colDocNo.Name = "colDocNo"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Date "
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 90
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.CancelReceiptToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(419, 444)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(101, 40)
        Me.ToolStrip1.TabIndex = 172
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 37)
        Me.ToolStripLabel1.Text = "   "
        '
        'CancelReceiptToolStripButton
        '
        Me.CancelReceiptToolStripButton.AutoSize = False
        Me.CancelReceiptToolStripButton.Image = CType(resources.GetObject("CancelReceiptToolStripButton.Image"), System.Drawing.Image)
        Me.CancelReceiptToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelReceiptToolStripButton.Name = "CancelReceiptToolStripButton"
        Me.CancelReceiptToolStripButton.Size = New System.Drawing.Size(65, 40)
        Me.CancelReceiptToolStripButton.Text = " Cancel "
        '
        'lbldateRS
        '
        Me.lbldateRS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbldateRS.Enabled = False
        Me.lbldateRS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldateRS.Location = New System.Drawing.Point(800, 156)
        Me.lbldateRS.MaxLength = 50
        Me.lbldateRS.Name = "lbldateRS"
        Me.lbldateRS.Size = New System.Drawing.Size(86, 22)
        Me.lbldateRS.TabIndex = 218
        Me.lbldateRS.Visible = False
        '
        'txtDoccccNo
        '
        Me.txtDoccccNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDoccccNo.Enabled = False
        Me.txtDoccccNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoccccNo.Location = New System.Drawing.Point(800, 184)
        Me.txtDoccccNo.MaxLength = 50
        Me.txtDoccccNo.Name = "txtDoccccNo"
        Me.txtDoccccNo.Size = New System.Drawing.Size(86, 22)
        Me.txtDoccccNo.TabIndex = 219
        Me.txtDoccccNo.Visible = False
        '
        'txtSearchReceiptNo
        '
        Me.txtSearchReceiptNo.Location = New System.Drawing.Point(115, 33)
        Me.txtSearchReceiptNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchReceiptNo.Name = "txtSearchReceiptNo"
        Me.txtSearchReceiptNo.Size = New System.Drawing.Size(132, 20)
        Me.txtSearchReceiptNo.TabIndex = 207
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(6, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 208
        Me.Label4.Text = "Search Receipt No :"
        '
        'dgw1
        '
        Me.dgw1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgw1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6})
        Me.dgw1.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw1.Location = New System.Drawing.Point(6, 65)
        Me.dgw1.MultiSelect = False
        Me.dgw1.Name = "dgw1"
        Me.dgw1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw1.Size = New System.Drawing.Size(241, 333)
        Me.dgw1.TabIndex = 209
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Receipt No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date "
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(470, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "Doc No: "
        '
        'frmReceiptCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 484)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDeliveryNo)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtDoccccNo)
        Me.Controls.Add(Me.lbldateRS)
        Me.Controls.Add(Me.txtDocuNo)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmReceiptCancel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LblReceiptNo As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtSchemeName As TextBox
    Friend WithEvents txtDeliveryNo As TextBox
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtIssuancedate As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents txtDocuNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgw As DataGridView
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents PriceColumn As DataGridViewTextBoxColumn
    Friend WithEvents colDocNo As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents CancelReceiptToolStripButton As ToolStripButton
    Friend WithEvents lbldateRS As TextBox
    Friend WithEvents txtDoccccNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearchReceiptNo As TextBox
    Friend WithEvents dgw1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
