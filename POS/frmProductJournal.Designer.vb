<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductJournal
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
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtgCart = New System.Windows.Forms.DataGridView()
        Me.colBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescrp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStockonHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVatcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColQtyRem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dtgCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGetData
        '
        Me.btnGetData.BackColor = System.Drawing.Color.Cyan
        Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetData.Location = New System.Drawing.Point(170, 21)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(76, 20)
        Me.btnGetData.TabIndex = 185
        Me.btnGetData.Text = "Load"
        Me.btnGetData.UseVisualStyleBackColor = False
        '
        'btnExportExcel
        '
        Me.btnExportExcel.BackColor = System.Drawing.Color.Cyan
        Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(810, 21)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(93, 20)
        Me.btnExportExcel.TabIndex = 184
        Me.btnExportExcel.Text = "&Export To Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(944, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 20)
        Me.Button1.TabIndex = 188
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dtgCart
        '
        Me.dtgCart.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBarcode, Me.ColDescrp, Me.colStockonHand, Me.colVatcode, Me.ColQtyRem, Me.Column1, Me.Column2, Me.Column3})
        Me.dtgCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgCart.GridColor = System.Drawing.Color.DarkOrange
        Me.dtgCart.Location = New System.Drawing.Point(3, 94)
        Me.dtgCart.Name = "dtgCart"
        Me.dtgCart.ReadOnly = True
        Me.dtgCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCart.Size = New System.Drawing.Size(1049, 437)
        Me.dtgCart.TabIndex = 189
        '
        'colBarcode
        '
        Me.colBarcode.HeaderText = "Material No"
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.ReadOnly = True
        Me.colBarcode.Width = 120
        '
        'ColDescrp
        '
        Me.ColDescrp.HeaderText = "Description"
        Me.ColDescrp.Name = "ColDescrp"
        Me.ColDescrp.ReadOnly = True
        Me.ColDescrp.Width = 190
        '
        'colStockonHand
        '
        Me.colStockonHand.HeaderText = "Trans. No"
        Me.colStockonHand.Name = "colStockonHand"
        Me.colStockonHand.ReadOnly = True
        Me.colStockonHand.Width = 120
        '
        'colVatcode
        '
        Me.colVatcode.HeaderText = " Quantity"
        Me.colVatcode.Name = "colVatcode"
        Me.colVatcode.ReadOnly = True
        '
        'ColQtyRem
        '
        Me.ColQtyRem.HeaderText = "Qty Bal"
        Me.ColQtyRem.Name = "ColQtyRem"
        Me.ColQtyRem.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Stock-in-Warehouse"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 145
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Type"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1049, 32)
        Me.Panel1.TabIndex = 190
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(450, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(224, 20)
        Me.Label7.TabIndex = 222
        Me.Label7.Text = "Material Movement Journal"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnGetData)
        Me.GroupBox1.Controls.Add(Me.btnExportExcel)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1049, 47)
        Me.GroupBox1.TabIndex = 191
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Material Movement Parameters"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "Load Material Movement"
        '
        'frmProductJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 552)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtgCart)
        Me.Name = "frmProductJournal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtgCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents btnExportExcel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtgCart As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents colBarcode As DataGridViewTextBoxColumn
    Friend WithEvents ColDescrp As DataGridViewTextBoxColumn
    Friend WithEvents colStockonHand As DataGridViewTextBoxColumn
    Friend WithEvents colVatcode As DataGridViewTextBoxColumn
    Friend WithEvents ColQtyRem As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
