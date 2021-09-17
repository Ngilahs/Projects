<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPTItemReceipts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPTItemReceipts))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSupplierName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colItemNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDateIn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColstockinId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDocNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtTAmt = New System.Windows.Forms.TextBox()
        Me.txtQntySold = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSupplierDNote = New System.Windows.Forms.TextBox()
        Me.cboSearchItem = New System.Windows.Forms.ComboBox()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnShowReport = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colItemName, Me.colQty, Me.colSupplierName, Me.colItemNo, Me.ColDateIn, Me.ColstockinId, Me.ColDocNo})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(21, 80)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(641, 115)
        Me.ListView1.TabIndex = 22
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'colItemName
        '
        Me.colItemName.DisplayIndex = 1
        Me.colItemName.Text = "Item Name"
        Me.colItemName.Width = 193
        '
        'colQty
        '
        Me.colQty.DisplayIndex = 2
        Me.colQty.Text = "Qty"
        Me.colQty.Width = 45
        '
        'colSupplierName
        '
        Me.colSupplierName.DisplayIndex = 3
        Me.colSupplierName.Text = "Supplier Name"
        Me.colSupplierName.Width = 134
        '
        'colItemNo
        '
        Me.colItemNo.DisplayIndex = 0
        Me.colItemNo.Text = "Item No"
        Me.colItemNo.Width = 103
        '
        'ColDateIn
        '
        Me.ColDateIn.Text = "Date In"
        Me.ColDateIn.Width = 110
        '
        'ColstockinId
        '
        Me.ColstockinId.Text = "StockID"
        '
        'ColDocNo
        '
        Me.ColDocNo.Text = "Doc No"
        '
        'txtTAmt
        '
        Me.txtTAmt.Location = New System.Drawing.Point(377, 148)
        Me.txtTAmt.Name = "txtTAmt"
        Me.txtTAmt.Size = New System.Drawing.Size(92, 20)
        Me.txtTAmt.TabIndex = 23
        Me.txtTAmt.Visible = False
        '
        'txtQntySold
        '
        Me.txtQntySold.Location = New System.Drawing.Point(485, 148)
        Me.txtQntySold.Name = "txtQntySold"
        Me.txtQntySold.Size = New System.Drawing.Size(97, 20)
        Me.txtQntySold.TabIndex = 24
        Me.txtQntySold.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 49)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(878, 435)
        Me.ReportViewer1.TabIndex = 25
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Controls.Add(Me.btnLoad)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtSupplierDNote)
        Me.GroupBox3.Controls.Add(Me.cboSearchItem)
        Me.GroupBox3.Controls.Add(Me.txtItemNo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.BtnShowReport)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(-2, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(878, 42)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Parameters"
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoad.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoad.Location = New System.Drawing.Point(801, 11)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(65, 22)
        Me.btnLoad.TabIndex = 224
        Me.btnLoad.Text = "&Load "
        Me.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(555, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 223
        Me.Label1.Text = "Supplier Delivery No:"
        '
        'txtSupplierDNote
        '
        Me.txtSupplierDNote.Location = New System.Drawing.Point(686, 12)
        Me.txtSupplierDNote.Name = "txtSupplierDNote"
        Me.txtSupplierDNote.Size = New System.Drawing.Size(109, 21)
        Me.txtSupplierDNote.TabIndex = 222
        '
        'cboSearchItem
        '
        Me.cboSearchItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSearchItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSearchItem.FormattingEnabled = True
        Me.cboSearchItem.Location = New System.Drawing.Point(85, 15)
        Me.cboSearchItem.Name = "cboSearchItem"
        Me.cboSearchItem.Size = New System.Drawing.Size(128, 21)
        Me.cboSearchItem.TabIndex = 221
        '
        'txtItemNo
        '
        Me.txtItemNo.BackColor = System.Drawing.Color.White
        Me.txtItemNo.Enabled = False
        Me.txtItemNo.Location = New System.Drawing.Point(169, 15)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(44, 21)
        Me.txtItemNo.TabIndex = 220
        Me.txtItemNo.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(330, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Material Received Report"
        '
        'BtnShowReport
        '
        Me.BtnShowReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnShowReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnShowReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowReport.Image = CType(resources.GetObject("BtnShowReport.Image"), System.Drawing.Image)
        Me.BtnShowReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnShowReport.Location = New System.Drawing.Point(219, 13)
        Me.BtnShowReport.Name = "BtnShowReport"
        Me.BtnShowReport.Size = New System.Drawing.Size(65, 22)
        Me.BtnShowReport.TabIndex = 37
        Me.BtnShowReport.Text = "&Load "
        Me.BtnShowReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnShowReport.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Receipt No:"
        '
        'RPTItemReceipts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 488)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtTAmt)
        Me.Controls.Add(Me.txtQntySold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "RPTItemReceipts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material Received"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents colItemNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colItemName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colQty As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSupplierName As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtTAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtQntySold As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnShowReport As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSearchItem As ComboBox
    Friend WithEvents txtItemNo As TextBox
    Friend WithEvents ColDateIn As ColumnHeader
    Friend WithEvents ColstockinId As ColumnHeader
    Friend WithEvents txtSupplierDNote As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ColDocNo As ColumnHeader
End Class
