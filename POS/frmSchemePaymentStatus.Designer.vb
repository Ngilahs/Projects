<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchemePaymentStatus
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Details = New System.Windows.Forms.GroupBox()
        Me.gbBESstatus = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSchemeName1 = New System.Windows.Forms.TextBox()
        Me.txtSubcontractor = New System.Windows.Forms.TextBox()
        Me.txtSchemeRefNo1 = New System.Windows.Forms.TextBox()
        Me.txtSchemeID1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScheme = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.chkstatementInvoiced = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.txtStatementNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSubcontractor = New System.Windows.Forms.TextBox()
        Me.colSchmId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatementNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLineAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMeterAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubcontractor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Details.SuspendLayout()
        Me.gbBESstatus.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(346, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 18)
        Me.Label7.TabIndex = 222
        Me.Label7.Text = "Scheme Status"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(797, 32)
        Me.Panel1.TabIndex = 3
        '
        'Details
        '
        Me.Details.Controls.Add(Me.txtAmount)
        Me.Details.Controls.Add(Me.Label5)
        Me.Details.Controls.Add(Me.txtStatementNo)
        Me.Details.Controls.Add(Me.Label3)
        Me.Details.Controls.Add(Me.txtCategory)
        Me.Details.Controls.Add(Me.Label4)
        Me.Details.Controls.Add(Me.gbBESstatus)
        Me.Details.Controls.Add(Me.cboSubcontractor)
        Me.Details.Controls.Add(Me.Label6)
        Me.Details.Controls.Add(Me.txtSchemeName1)
        Me.Details.Controls.Add(Me.txtSubcontractor)
        Me.Details.Controls.Add(Me.txtSchemeRefNo1)
        Me.Details.Controls.Add(Me.txtSchemeID1)
        Me.Details.Controls.Add(Me.Label1)
        Me.Details.Controls.Add(Me.Label2)
        Me.Details.Controls.Add(Me.lblScheme)
        Me.Details.Location = New System.Drawing.Point(0, 235)
        Me.Details.Name = "Details"
        Me.Details.Size = New System.Drawing.Size(676, 147)
        Me.Details.TabIndex = 226
        Me.Details.TabStop = False
        Me.Details.Text = "Details"
        '
        'gbBESstatus
        '
        Me.gbBESstatus.Controls.Add(Me.CheckBox2)
        Me.gbBESstatus.Controls.Add(Me.chkstatementInvoiced)
        Me.gbBESstatus.Location = New System.Drawing.Point(12, 69)
        Me.gbBESstatus.Name = "gbBESstatus"
        Me.gbBESstatus.Size = New System.Drawing.Size(337, 75)
        Me.gbBESstatus.TabIndex = 327
        Me.gbBESstatus.TabStop = False
        Me.gbBESstatus.Text = "BES"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 14)
        Me.Label6.TabIndex = 287
        Me.Label6.Text = "Sub-Con:"
        '
        'txtSchemeName1
        '
        Me.txtSchemeName1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeName1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeName1.Enabled = False
        Me.txtSchemeName1.Location = New System.Drawing.Point(54, 40)
        Me.txtSchemeName1.Name = "txtSchemeName1"
        Me.txtSchemeName1.Size = New System.Drawing.Size(135, 20)
        Me.txtSchemeName1.TabIndex = 284
        '
        'txtSubcontractor
        '
        Me.txtSubcontractor.Location = New System.Drawing.Point(145, 14)
        Me.txtSubcontractor.Name = "txtSubcontractor"
        Me.txtSubcontractor.Size = New System.Drawing.Size(16, 20)
        Me.txtSubcontractor.TabIndex = 281
        '
        'txtSchemeRefNo1
        '
        Me.txtSchemeRefNo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeRefNo1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeRefNo1.Location = New System.Drawing.Point(245, 16)
        Me.txtSchemeRefNo1.Name = "txtSchemeRefNo1"
        Me.txtSchemeRefNo1.Size = New System.Drawing.Size(175, 20)
        Me.txtSchemeRefNo1.TabIndex = 261
        '
        'txtSchemeID1
        '
        Me.txtSchemeID1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSchemeID1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSchemeID1.Enabled = False
        Me.txtSchemeID1.Location = New System.Drawing.Point(302, 16)
        Me.txtSchemeID1.Name = "txtSchemeID1"
        Me.txtSchemeID1.Size = New System.Drawing.Size(13, 20)
        Me.txtSchemeID1.TabIndex = 265
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(195, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 14)
        Me.Label1.TabIndex = 263
        Me.Label1.Text = " Ref-No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(774, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 250
        '
        'lblScheme
        '
        Me.lblScheme.AutoSize = True
        Me.lblScheme.BackColor = System.Drawing.Color.White
        Me.lblScheme.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheme.ForeColor = System.Drawing.Color.Black
        Me.lblScheme.Location = New System.Drawing.Point(6, 43)
        Me.lblScheme.Name = "lblScheme"
        Me.lblScheme.Size = New System.Drawing.Size(42, 14)
        Me.lblScheme.TabIndex = 249
        Me.lblScheme.Text = "Scheme"
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        Me.dgw.AllowUserToOrderColumns = True
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
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSchmId, Me.colStatementNo, Me.Column7, Me.Column1, Me.colCategory, Me.ColLineAmt, Me.colMeterAmt, Me.colUnits, Me.colSubcontractor})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(0, 38)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(797, 191)
        Me.dgw.TabIndex = 227
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnLoad)
        Me.Panel3.Location = New System.Drawing.Point(681, 236)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(111, 143)
        Me.Panel3.TabIndex = 228
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(13, 98)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 28)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(13, 54)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(82, 28)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(13, 10)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(82, 28)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'chkstatementInvoiced
        '
        Me.chkstatementInvoiced.AutoSize = True
        Me.chkstatementInvoiced.Location = New System.Drawing.Point(6, 19)
        Me.chkstatementInvoiced.Name = "chkstatementInvoiced"
        Me.chkstatementInvoiced.Size = New System.Drawing.Size(118, 17)
        Me.chkstatementInvoiced.TabIndex = 320
        Me.chkstatementInvoiced.Text = "Statement Invoiced"
        Me.chkstatementInvoiced.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 42)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(98, 17)
        Me.CheckBox2.TabIndex = 321
        Me.CheckBox2.Text = "Statement Paid"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'txtStatementNo
        '
        Me.txtStatementNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtStatementNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtStatementNo.Enabled = False
        Me.txtStatementNo.Location = New System.Drawing.Point(500, 13)
        Me.txtStatementNo.Name = "txtStatementNo"
        Me.txtStatementNo.Size = New System.Drawing.Size(170, 20)
        Me.txtStatementNo.TabIndex = 330
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(439, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 14)
        Me.Label3.TabIndex = 331
        Me.Label3.Text = "Stmnt No:"
        '
        'txtCategory
        '
        Me.txtCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCategory.Enabled = False
        Me.txtCategory.Location = New System.Drawing.Point(500, 39)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(170, 20)
        Me.txtCategory.TabIndex = 328
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(439, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 14)
        Me.Label4.TabIndex = 329
        Me.Label4.Text = "Category:"
        '
        'cboSubcontractor
        '
        Me.cboSubcontractor.Enabled = False
        Me.cboSubcontractor.Location = New System.Drawing.Point(56, 14)
        Me.cboSubcontractor.Name = "cboSubcontractor"
        Me.cboSubcontractor.Size = New System.Drawing.Size(133, 20)
        Me.cboSubcontractor.TabIndex = 310
        '
        'colSchmId
        '
        Me.colSchmId.HeaderText = " Id#"
        Me.colSchmId.Name = "colSchmId"
        Me.colSchmId.Visible = False
        Me.colSchmId.Width = 50
        '
        'colStatementNo
        '
        Me.colStatementNo.HeaderText = "Stmnt No"
        Me.colStatementNo.Name = "colStatementNo"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Name"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Z-Ref"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'colCategory
        '
        Me.colCategory.HeaderText = "Category"
        Me.colCategory.Name = "colCategory"
        '
        'ColLineAmt
        '
        Me.ColLineAmt.HeaderText = "Statement Amt"
        Me.ColLineAmt.Name = "ColLineAmt"
        '
        'colMeterAmt
        '
        Me.colMeterAmt.HeaderText = "Statement Invoiced"
        Me.colMeterAmt.Name = "colMeterAmt"
        Me.colMeterAmt.Width = 125
        '
        'colUnits
        '
        Me.colUnits.HeaderText = "Statement Paid"
        Me.colUnits.Name = "colUnits"
        '
        'colSubcontractor
        '
        Me.colSubcontractor.HeaderText = "Sub-Contractor"
        Me.colSubcontractor.Name = "colSubcontractor"
        '
        'txtAmount
        '
        Me.txtAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAmount.Location = New System.Drawing.Point(245, 42)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(175, 20)
        Me.txtAmount.TabIndex = 332
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(195, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 14)
        Me.Label5.TabIndex = 333
        Me.Label5.Text = "Amnt"
        '
        'frmSchemePaymentStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 381)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.Details)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmSchemePaymentStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Details.ResumeLayout(False)
        Me.Details.PerformLayout()
        Me.gbBESstatus.ResumeLayout(False)
        Me.gbBESstatus.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Details As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSchemeName1 As TextBox
    Friend WithEvents txtSubcontractor As TextBox
    Friend WithEvents txtSchemeRefNo1 As TextBox
    Friend WithEvents txtSchemeID1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblScheme As Label
    Friend WithEvents dgw As DataGridView
    Friend WithEvents gbBESstatus As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents chkstatementInvoiced As CheckBox
    Friend WithEvents txtStatementNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboSubcontractor As TextBox
    Friend WithEvents colSchmId As DataGridViewTextBoxColumn
    Friend WithEvents colStatementNo As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colCategory As DataGridViewTextBoxColumn
    Friend WithEvents ColLineAmt As DataGridViewTextBoxColumn
    Friend WithEvents colMeterAmt As DataGridViewTextBoxColumn
    Friend WithEvents colUnits As DataGridViewTextBoxColumn
    Friend WithEvents colSubcontractor As DataGridViewTextBoxColumn
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label5 As Label
End Class
