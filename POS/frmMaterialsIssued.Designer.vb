<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterialsIssued
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.dtgpdcts = New System.Windows.Forms.DataGridView()
        Me.colBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescrp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUnitprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStockonHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgpdcts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(799, 33)
        Me.Panel2.TabIndex = 184
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.DarkOrange
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(175, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(196, 20)
        Me.Label15.TabIndex = 223
        Me.Label15.Text = "List of Materials Issued"
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.Red
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(479, 57)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(76, 20)
        Me.BtnReset.TabIndex = 191
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "MM/dd/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(151, 57)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(119, 20)
        Me.dtpDateTo.TabIndex = 190
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "To :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "From :"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "MM/dd/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(12, 57)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(119, 20)
        Me.dtpDateFrom.TabIndex = 187
        '
        'btnGetData
        '
        Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetData.Location = New System.Drawing.Point(286, 57)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(76, 20)
        Me.btnGetData.TabIndex = 186
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'btnExportExcel
        '
        Me.btnExportExcel.BackColor = System.Drawing.Color.Aqua
        Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(379, 57)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(82, 20)
        Me.btnExportExcel.TabIndex = 185
        Me.btnExportExcel.Text = "&Export Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = False
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
        Me.dtgpdcts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBarcode, Me.ColDescrp, Me.ColUnitprice, Me.colStockonHand})
        Me.dtgpdcts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgpdcts.GridColor = System.Drawing.Color.DarkOrange
        Me.dtgpdcts.Location = New System.Drawing.Point(0, 83)
        Me.dtgpdcts.Name = "dtgpdcts"
        Me.dtgpdcts.ReadOnly = True
        Me.dtgpdcts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgpdcts.Size = New System.Drawing.Size(573, 366)
        Me.dtgpdcts.TabIndex = 192
        '
        'colBarcode
        '
        Me.colBarcode.HeaderText = "Delivery No"
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.ReadOnly = True
        Me.colBarcode.Width = 150
        '
        'ColDescrp
        '
        Me.ColDescrp.HeaderText = "Scheme"
        Me.ColDescrp.Name = "ColDescrp"
        Me.ColDescrp.ReadOnly = True
        '
        'ColUnitprice
        '
        Me.ColUnitprice.HeaderText = "Delivery Date"
        Me.ColUnitprice.Name = "ColUnitprice"
        Me.ColUnitprice.ReadOnly = True
        Me.ColUnitprice.Width = 120
        '
        'colStockonHand
        '
        Me.colStockonHand.HeaderText = "Approval Status"
        Me.colStockonHand.Name = "colStockonHand"
        Me.colStockonHand.ReadOnly = True
        Me.colStockonHand.Width = 150
        '
        'frmMaterialsIssued
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 450)
        Me.Controls.Add(Me.dtgpdcts)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.Controls.Add(Me.btnGetData)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmMaterialsIssued"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Materials Issued"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dtgpdcts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnReset As Button
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents btnGetData As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents dtgpdcts As DataGridView
    Friend WithEvents colBarcode As DataGridViewTextBoxColumn
    Friend WithEvents ColDescrp As DataGridViewTextBoxColumn
    Friend WithEvents ColUnitprice As DataGridViewTextBoxColumn
    Friend WithEvents colStockonHand As DataGridViewTextBoxColumn
End Class
