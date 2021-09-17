<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterialReceivedPerCounty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterialReceivedPerCounty))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colItemNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCounty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSupplier = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboCounty = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnShowReport = New System.Windows.Forms.Button()
        Me.txtCounty = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colItemNo, Me.colItemName, Me.colQty, Me.colCounty, Me.colSupplier})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(82, 109)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(561, 41)
        Me.ListView1.TabIndex = 46
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
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
        'colCounty
        '
        Me.colCounty.Text = "County"
        '
        'colSupplier
        '
        Me.colSupplier.Text = "Supplier"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Controls.Add(Me.cboCounty)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.BtnShowReport)
        Me.GroupBox3.Controls.Add(Me.txtCounty)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(794, 65)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Parameters"
        '
        'cboCounty
        '
        Me.cboCounty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboCounty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCounty.FormattingEnabled = True
        Me.cboCounty.Location = New System.Drawing.Point(6, 32)
        Me.cboCounty.Name = "cboCounty"
        Me.cboCounty.Size = New System.Drawing.Size(141, 21)
        Me.cboCounty.TabIndex = 172
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 171
        Me.Label11.Text = "County Name :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(724, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 26)
        Me.Button1.TabIndex = 170
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(303, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Materials Received Per County"
        '
        'BtnShowReport
        '
        Me.BtnShowReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnShowReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnShowReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowReport.Image = CType(resources.GetObject("BtnShowReport.Image"), System.Drawing.Image)
        Me.BtnShowReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnShowReport.Location = New System.Drawing.Point(153, 31)
        Me.BtnShowReport.Name = "BtnShowReport"
        Me.BtnShowReport.Size = New System.Drawing.Size(65, 22)
        Me.BtnShowReport.TabIndex = 37
        Me.BtnShowReport.Text = "&Load "
        Me.BtnShowReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnShowReport.UseVisualStyleBackColor = False
        '
        'txtCounty
        '
        Me.txtCounty.AutoSize = True
        Me.txtCounty.Location = New System.Drawing.Point(109, 36)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(31, 13)
        Me.txtCounty.TabIndex = 173
        Me.txtCounty.Text = "XXX"
        Me.txtCounty.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 71)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(794, 373)
        Me.ReportViewer1.TabIndex = 48
        '
        'frmMaterialReceivedPerCounty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmMaterialReceivedPerCounty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material Received Per County"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents colItemNo As ColumnHeader
    Friend WithEvents colItemName As ColumnHeader
    Friend WithEvents colQty As ColumnHeader
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnShowReport As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cboCounty As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCounty As Label
    Friend WithEvents colCounty As ColumnHeader
    Friend WithEvents colSupplier As ColumnHeader
End Class
