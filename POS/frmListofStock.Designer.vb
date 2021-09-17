<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListofStock
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
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtgpdcts = New System.Windows.Forms.DataGridView()
        Me.colBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescrp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUnitprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStockonHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgpdcts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExportExcel
        '
        Me.btnExportExcel.BackColor = System.Drawing.Color.Cyan
        Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(281, 57)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(82, 20)
        Me.btnExportExcel.TabIndex = 6
        Me.btnExportExcel.Text = "&Export Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = False
        '
        'btnGetData
        '
        Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetData.Location = New System.Drawing.Point(12, 57)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(104, 20)
        Me.btnGetData.TabIndex = 30
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(564, 57)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(76, 20)
        Me.BtnReset.TabIndex = 35
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Location = New System.Drawing.Point(2, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(650, 33)
        Me.Panel2.TabIndex = 183
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.DarkOrange
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(182, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(216, 20)
        Me.Label15.TabIndex = 223
        Me.Label15.Text = "List of Materials Received"
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
        Me.dtgpdcts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBarcode, Me.ColDescrp, Me.ColUnitprice, Me.colStockonHand})
        Me.dtgpdcts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgpdcts.GridColor = System.Drawing.Color.DarkOrange
        Me.dtgpdcts.Location = New System.Drawing.Point(2, 97)
        Me.dtgpdcts.Name = "dtgpdcts"
        Me.dtgpdcts.ReadOnly = True
        Me.dtgpdcts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgpdcts.Size = New System.Drawing.Size(650, 334)
        Me.dtgpdcts.TabIndex = 184
        '
        'colBarcode
        '
        Me.colBarcode.HeaderText = "Stock Ref No"
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.ReadOnly = True
        Me.colBarcode.Width = 150
        '
        'ColDescrp
        '
        Me.ColDescrp.HeaderText = "Supplier Name"
        Me.ColDescrp.Name = "ColDescrp"
        Me.ColDescrp.ReadOnly = True
        Me.ColDescrp.Width = 150
        '
        'ColUnitprice
        '
        Me.ColUnitprice.HeaderText = "Receive Date"
        Me.ColUnitprice.Name = "ColUnitprice"
        Me.ColUnitprice.ReadOnly = True
        Me.ColUnitprice.Width = 120
        '
        'colStockonHand
        '
        Me.colStockonHand.HeaderText = "Received By"
        Me.colStockonHand.Name = "colStockonHand"
        Me.colStockonHand.ReadOnly = True
        Me.colStockonHand.Width = 150
        '
        'frmListofStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 443)
        Me.Controls.Add(Me.dtgpdcts)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.btnGetData)
        Me.Controls.Add(Me.btnExportExcel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmListofStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dtgpdcts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExportExcel As System.Windows.Forms.Button
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtgpdcts As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents colBarcode As DataGridViewTextBoxColumn
    Friend WithEvents ColDescrp As DataGridViewTextBoxColumn
    Friend WithEvents ColUnitprice As DataGridViewTextBoxColumn
    Friend WithEvents colStockonHand As DataGridViewTextBoxColumn
End Class
