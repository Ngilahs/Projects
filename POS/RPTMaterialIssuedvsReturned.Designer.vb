<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPTMaterialIssuedvsReturned
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPTMaterialIssuedvsReturned))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNLoadExpensereport = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColDeliveryNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColItemNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColOriginalQtyIssued = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColQtyReturned = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColQtyConsumed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColUoM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColSubcontractor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSchemename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSchemeRefNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.BTNLoadExpensereport)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1004, 46)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Parameters"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(355, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Material Issued vs Returned vs Consumed"
        '
        'BTNLoadExpensereport
        '
        Me.BTNLoadExpensereport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BTNLoadExpensereport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLoadExpensereport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNLoadExpensereport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLoadExpensereport.Image = CType(resources.GetObject("BTNLoadExpensereport.Image"), System.Drawing.Image)
        Me.BTNLoadExpensereport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNLoadExpensereport.Location = New System.Drawing.Point(29, 17)
        Me.BTNLoadExpensereport.Name = "BTNLoadExpensereport"
        Me.BTNLoadExpensereport.Size = New System.Drawing.Size(61, 20)
        Me.BTNLoadExpensereport.TabIndex = 37
        Me.BTNLoadExpensereport.Text = "&Load "
        Me.BTNLoadExpensereport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNLoadExpensereport.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColDeliveryNo, Me.ColItemNo, Me.ColDescription, Me.ColOriginalQtyIssued, Me.ColQtyReturned, Me.ColQtyConsumed, Me.ColUoM, Me.ColSubcontractor, Me.colSchemename, Me.colSchemeRefNo})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 80)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(956, 65)
        Me.ListView1.TabIndex = 41
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColDeliveryNo
        '
        Me.ColDeliveryNo.Text = "Delivery No"
        Me.ColDeliveryNo.Width = 103
        '
        'ColItemNo
        '
        Me.ColItemNo.Text = "Item No"
        Me.ColItemNo.Width = 82
        '
        'ColDescription
        '
        Me.ColDescription.Text = "Description"
        Me.ColDescription.Width = 207
        '
        'ColOriginalQtyIssued
        '
        Me.ColOriginalQtyIssued.Text = "Original Qty Issued"
        Me.ColOriginalQtyIssued.Width = 125
        '
        'ColQtyReturned
        '
        Me.ColQtyReturned.Text = "QtyReturned"
        Me.ColQtyReturned.Width = 105
        '
        'ColQtyConsumed
        '
        Me.ColQtyConsumed.Text = "Qty Consumed"
        '
        'ColUoM
        '
        Me.ColUoM.Text = "UoM"
        Me.ColUoM.Width = 53
        '
        'ColSubcontractor
        '
        Me.ColSubcontractor.Text = "Sub-Contractor"
        Me.ColSubcontractor.Width = 151
        '
        'colSchemename
        '
        Me.colSchemename.Text = "Scheme Name"
        '
        'colSchemeRefNo
        '
        Me.colSchemeRefNo.Text = "Ref No"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 52)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1004, 395)
        Me.ReportViewer1.TabIndex = 42
        '
        'RPTMaterialIssuedvsReturned
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "RPTMaterialIssuedvsReturned"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material Returned vs Issued vs Consumed"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNLoadExpensereport As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColDeliveryNo As ColumnHeader
    Friend WithEvents ColItemNo As ColumnHeader
    Friend WithEvents ColDescription As ColumnHeader
    Friend WithEvents ColOriginalQtyIssued As ColumnHeader
    Friend WithEvents ColQtyReturned As ColumnHeader
    Friend WithEvents ColUoM As ColumnHeader
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ColSubcontractor As ColumnHeader
    Friend WithEvents ColQtyConsumed As ColumnHeader
    Friend WithEvents colSchemename As ColumnHeader
    Friend WithEvents colSchemeRefNo As ColumnHeader
End Class
