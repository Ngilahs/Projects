<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPTMaterialsReceivedPerSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPTMaterialsReceivedPerSupplier))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboSupplierName = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnShowReport = New System.Windows.Forms.Button()
        Me.lblupplierId = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColStockinNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colItemNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDateIn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColSupplier = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Controls.Add(Me.cboSupplierName)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.BtnShowReport)
        Me.GroupBox3.Controls.Add(Me.lblupplierId)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(923, 41)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Parameters"
        '
        'cboSupplierName
        '
        Me.cboSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSupplierName.FormattingEnabled = True
        Me.cboSupplierName.Location = New System.Drawing.Point(71, 14)
        Me.cboSupplierName.Name = "cboSupplierName"
        Me.cboSupplierName.Size = New System.Drawing.Size(165, 21)
        Me.cboSupplierName.TabIndex = 170
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 169
        Me.Label11.Text = "Supplier :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(352, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Materials Received Per Supplier"
        '
        'BtnShowReport
        '
        Me.BtnShowReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnShowReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnShowReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowReport.Image = CType(resources.GetObject("BtnShowReport.Image"), System.Drawing.Image)
        Me.BtnShowReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnShowReport.Location = New System.Drawing.Point(240, 15)
        Me.BtnShowReport.Name = "BtnShowReport"
        Me.BtnShowReport.Size = New System.Drawing.Size(67, 22)
        Me.BtnShowReport.TabIndex = 37
        Me.BtnShowReport.Text = "&Load "
        Me.BtnShowReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnShowReport.UseVisualStyleBackColor = False
        '
        'lblupplierId
        '
        Me.lblupplierId.AutoSize = True
        Me.lblupplierId.Location = New System.Drawing.Point(115, 18)
        Me.lblupplierId.Name = "lblupplierId"
        Me.lblupplierId.Size = New System.Drawing.Size(31, 13)
        Me.lblupplierId.TabIndex = 171
        Me.lblupplierId.Text = "XXX"
        Me.lblupplierId.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 45)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(923, 401)
        Me.ReportViewer1.TabIndex = 45
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColStockinNo, Me.colItemNo, Me.colItemName, Me.colQty, Me.ColDateIn, Me.ColSupplier})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(15, 109)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(773, 37)
        Me.ListView1.TabIndex = 46
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'ColStockinNo
        '
        Me.ColStockinNo.Text = "Receipt#"
        '
        'colItemNo
        '
        Me.colItemNo.Text = "Item No"
        Me.colItemNo.Width = 103
        '
        'colItemName
        '
        Me.colItemName.Text = "Item Name"
        Me.colItemName.Width = 193
        '
        'colQty
        '
        Me.colQty.Text = "Qty"
        Me.colQty.Width = 114
        '
        'ColDateIn
        '
        Me.ColDateIn.Text = "Date Received"
        Me.ColDateIn.Width = 108
        '
        'ColSupplier
        '
        Me.ColSupplier.Text = "Supplier"
        Me.ColSupplier.Width = 118
        '
        'RPTMaterialsReceivedPerSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "RPTMaterialsReceivedPerSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Materials Received Per Supplier"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnShowReport As Button
    Friend WithEvents cboSupplierName As ComboBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColStockinNo As ColumnHeader
    Friend WithEvents colItemNo As ColumnHeader
    Friend WithEvents colItemName As ColumnHeader
    Friend WithEvents colQty As ColumnHeader
    Friend WithEvents ColDateIn As ColumnHeader
    Friend WithEvents ColSupplier As ColumnHeader
    Friend WithEvents lblupplierId As Label
End Class
