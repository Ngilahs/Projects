<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadItemsIssued
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoadItemsIssued))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtgpdcts = New System.Windows.Forms.DataGridView()
        Me.colBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescrp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnLCSExportExcel = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgpdcts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnLCSExportExcel)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(757, 33)
        Me.Panel2.TabIndex = 184
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.DarkOrange
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(278, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(196, 20)
        Me.Label15.TabIndex = 223
        Me.Label15.Text = "List of Materials Issued"
        '
        'dtgpdcts
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgpdcts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgpdcts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgpdcts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBarcode, Me.Column1, Me.Column5, Me.Column2, Me.ColDescrp, Me.Column3, Me.Column4})
        Me.dtgpdcts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgpdcts.GridColor = System.Drawing.Color.DarkOrange
        Me.dtgpdcts.Location = New System.Drawing.Point(0, 34)
        Me.dtgpdcts.Name = "dtgpdcts"
        Me.dtgpdcts.ReadOnly = True
        Me.dtgpdcts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgpdcts.Size = New System.Drawing.Size(757, 465)
        Me.dtgpdcts.TabIndex = 186
        '
        'colBarcode
        '
        Me.colBarcode.HeaderText = "Delivery No"
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 90
        '
        'Column5
        '
        Me.Column5.HeaderText = "Description"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity Issued"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'ColDescrp
        '
        Me.ColDescrp.HeaderText = "Date Issued"
        Me.ColDescrp.Name = "ColDescrp"
        Me.ColDescrp.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Issue Time"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 90
        '
        'Column4
        '
        Me.Column4.HeaderText = "Unit of Issue"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnLCSExportExcel
        '
        Me.btnLCSExportExcel.BackColor = System.Drawing.Color.Aqua
        Me.btnLCSExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLCSExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLCSExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLCSExportExcel.Location = New System.Drawing.Point(617, 3)
        Me.btnLCSExportExcel.Name = "btnLCSExportExcel"
        Me.btnLCSExportExcel.Size = New System.Drawing.Size(75, 22)
        Me.btnLCSExportExcel.TabIndex = 224
        Me.btnLCSExportExcel.Text = "&Export Excel"
        Me.btnLCSExportExcel.UseVisualStyleBackColor = False
        '
        'frmLoadItemsIssued
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 511)
        Me.Controls.Add(Me.dtgpdcts)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmLoadItemsIssued"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dtgpdcts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents dtgpdcts As DataGridView
    Friend WithEvents colBarcode As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents ColDescrp As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnLCSExportExcel As Button
End Class
