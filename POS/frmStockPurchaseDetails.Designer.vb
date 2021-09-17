<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockPurchaseDetails
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
        Me.dtgpdcts = New System.Windows.Forms.DataGridView()
        Me.colBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUnitprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStockonHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.dtgpdcts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgpdcts
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgpdcts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgpdcts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgpdcts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBarcode, Me.Column1, Me.Column5, Me.Column2, Me.ColUnitprice, Me.colStockonHand})
        Me.dtgpdcts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgpdcts.GridColor = System.Drawing.Color.DarkOrange
        Me.dtgpdcts.Location = New System.Drawing.Point(2, 32)
        Me.dtgpdcts.Name = "dtgpdcts"
        Me.dtgpdcts.ReadOnly = True
        Me.dtgpdcts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgpdcts.Size = New System.Drawing.Size(769, 421)
        Me.dtgpdcts.TabIndex = 185
        '
        'colBarcode
        '
        Me.colBarcode.HeaderText = "Stock No"
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.ReadOnly = True
        Me.colBarcode.Width = 95
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 90
        '
        'Column5
        '
        Me.Column5.HeaderText = "Description"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 80
        '
        'ColUnitprice
        '
        Me.ColUnitprice.HeaderText = "Date "
        Me.ColUnitprice.Name = "ColUnitprice"
        Me.ColUnitprice.ReadOnly = True
        '
        'colStockonHand
        '
        Me.colStockonHand.HeaderText = "Supplier"
        Me.colStockonHand.Name = "colStockonHand"
        Me.colStockonHand.ReadOnly = True
        '
        'btnExportExcel
        '
        Me.btnExportExcel.BackColor = System.Drawing.Color.Cyan
        Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(661, 8)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(96, 20)
        Me.btnExportExcel.TabIndex = 186
        Me.btnExportExcel.Text = "&Export To Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.btnExportExcel)
        Me.Panel2.Location = New System.Drawing.Point(2, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(769, 33)
        Me.Panel2.TabIndex = 187
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.DarkOrange
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(237, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(216, 20)
        Me.Label15.TabIndex = 223
        Me.Label15.Text = "List of Materials Received"
        '
        'frmStockPurchaseDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 455)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dtgpdcts)
        Me.KeyPreview = True
        Me.Name = "frmStockPurchaseDetails"
        Me.Text = "Material Received Details"
        CType(Me.dtgpdcts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgpdcts As System.Windows.Forms.DataGridView
    Friend WithEvents btnExportExcel As System.Windows.Forms.Button
    Friend WithEvents colBarcode As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents ColUnitprice As DataGridViewTextBoxColumn
    Friend WithEvents colStockonHand As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
End Class
