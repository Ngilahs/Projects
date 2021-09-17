<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptStockAdjustment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptStockAdjustment))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colStkadjustmentId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColProductNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDescr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAdjQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCurrentQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColAdjustedQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAdjustType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAccountname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colReason = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRemarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAdjustedby = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboAdjustmentNo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNLoadExpensereport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colStkadjustmentId, Me.ColProductNo, Me.ColDescr, Me.colAdjQty, Me.colCurrentQty, Me.ColAdjustedQty, Me.colDate, Me.colAdjustType, Me.colAccountname, Me.colReason, Me.colRemarks, Me.colAdjustedby})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 72)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(977, 238)
        Me.ListView1.TabIndex = 43
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colStkadjustmentId
        '
        Me.colStkadjustmentId.Text = "No#"
        Me.colStkadjustmentId.Width = 105
        '
        'ColProductNo
        '
        Me.ColProductNo.Text = "Product No"
        Me.ColProductNo.Width = 114
        '
        'ColDescr
        '
        Me.ColDescr.Text = "Description"
        Me.ColDescr.Width = 125
        '
        'colAdjQty
        '
        Me.colAdjQty.Text = "Count Qty"
        Me.colAdjQty.Width = 105
        '
        'colCurrentQty
        '
        Me.colCurrentQty.Text = "Current Qty"
        '
        'ColAdjustedQty
        '
        Me.ColAdjustedQty.Text = "Adjusted Qty"
        '
        'colDate
        '
        Me.colDate.Text = "Date"
        '
        'colAdjustType
        '
        Me.colAdjustType.Text = "Adjustment Type"
        '
        'colAccountname
        '
        Me.colAccountname.Text = "Name"
        '
        'colReason
        '
        Me.colReason.Text = "Reason"
        '
        'colRemarks
        '
        Me.colRemarks.Text = "Remarks"
        '
        'colAdjustedby
        '
        Me.colAdjustedby.Text = "Adjusted by"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Controls.Add(Me.cboAdjustmentNo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.BTNLoadExpensereport)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtCounty)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1007, 47)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Parameters"
        '
        'cboAdjustmentNo
        '
        Me.cboAdjustmentNo.FormattingEnabled = True
        Me.cboAdjustmentNo.Location = New System.Drawing.Point(112, 19)
        Me.cboAdjustmentNo.Name = "cboAdjustmentNo"
        Me.cboAdjustmentNo.Size = New System.Drawing.Size(169, 21)
        Me.cboAdjustmentNo.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(437, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Stock Adjustment Report"
        '
        'BTNLoadExpensereport
        '
        Me.BTNLoadExpensereport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BTNLoadExpensereport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLoadExpensereport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNLoadExpensereport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLoadExpensereport.Image = CType(resources.GetObject("BTNLoadExpensereport.Image"), System.Drawing.Image)
        Me.BTNLoadExpensereport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNLoadExpensereport.Location = New System.Drawing.Point(287, 21)
        Me.BTNLoadExpensereport.Name = "BTNLoadExpensereport"
        Me.BTNLoadExpensereport.Size = New System.Drawing.Size(59, 20)
        Me.BTNLoadExpensereport.TabIndex = 37
        Me.BTNLoadExpensereport.Text = "&Load "
        Me.BTNLoadExpensereport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNLoadExpensereport.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Adjustment No#"
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(352, 21)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(79, 21)
        Me.txtCounty.TabIndex = 45
        '
        'RptStockAdjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ListView1)
        Me.MaximizeBox = False
        Me.Name = "RptStockAdjustment"
        Me.Text = "RptStockAdjustment"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents colStkadjustmentId As ColumnHeader
    Friend WithEvents ColProductNo As ColumnHeader
    Friend WithEvents ColDescr As ColumnHeader
    Friend WithEvents colAdjQty As ColumnHeader
    Friend WithEvents colCurrentQty As ColumnHeader
    Friend WithEvents ColAdjustedQty As ColumnHeader
    Friend WithEvents colDate As ColumnHeader
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboAdjustmentNo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNLoadExpensereport As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents colAdjustType As ColumnHeader
    Friend WithEvents colAccountname As ColumnHeader
    Friend WithEvents colReason As ColumnHeader
    Friend WithEvents colRemarks As ColumnHeader
    Friend WithEvents colAdjustedby As ColumnHeader
End Class
