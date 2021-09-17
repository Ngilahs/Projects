<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmToolsReceivedDetails
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgwTools = New System.Windows.Forms.DataGridView()
        Me.dgwIssueMaterialsQtyBal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwToolNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsUnitofIssue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        CType(Me.dgwTools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(1, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(686, 39)
        Me.TextBox1.TabIndex = 284
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(233, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 18)
        Me.Label2.TabIndex = 285
        Me.Label2.Text = "List of Tools Received Details"
        '
        'dgwTools
        '
        Me.dgwTools.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgwTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwTools.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwIssueMaterialsQtyBal, Me.dgwToolNo, Me.dgwIssueMaterialsItemName, Me.dgwIssueMaterialsQty, Me.dgwIssueMaterialsUnitofIssue})
        Me.dgwTools.Location = New System.Drawing.Point(1, 47)
        Me.dgwTools.Name = "dgwTools"
        Me.dgwTools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgwTools.Size = New System.Drawing.Size(686, 333)
        Me.dgwTools.TabIndex = 286
        '
        'dgwIssueMaterialsQtyBal
        '
        Me.dgwIssueMaterialsQtyBal.HeaderText = "Receipt No"
        Me.dgwIssueMaterialsQtyBal.Name = "dgwIssueMaterialsQtyBal"
        Me.dgwIssueMaterialsQtyBal.ReadOnly = True
        Me.dgwIssueMaterialsQtyBal.Width = 120
        '
        'dgwToolNo
        '
        Me.dgwToolNo.HeaderText = "Tool No"
        Me.dgwToolNo.Name = "dgwToolNo"
        Me.dgwToolNo.ReadOnly = True
        Me.dgwToolNo.Width = 120
        '
        'dgwIssueMaterialsItemName
        '
        Me.dgwIssueMaterialsItemName.HeaderText = "Description"
        Me.dgwIssueMaterialsItemName.Name = "dgwIssueMaterialsItemName"
        Me.dgwIssueMaterialsItemName.ReadOnly = True
        Me.dgwIssueMaterialsItemName.Width = 130
        '
        'dgwIssueMaterialsQty
        '
        Me.dgwIssueMaterialsQty.HeaderText = "Quantity"
        Me.dgwIssueMaterialsQty.Name = "dgwIssueMaterialsQty"
        Me.dgwIssueMaterialsQty.Width = 120
        '
        'dgwIssueMaterialsUnitofIssue
        '
        Me.dgwIssueMaterialsUnitofIssue.HeaderText = "Received By"
        Me.dgwIssueMaterialsUnitofIssue.Name = "dgwIssueMaterialsUnitofIssue"
        Me.dgwIssueMaterialsUnitofIssue.ReadOnly = True
        Me.dgwIssueMaterialsUnitofIssue.Width = 150
        '
        'btnExportExcel
        '
        Me.btnExportExcel.BackColor = System.Drawing.Color.Aqua
        Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(594, 7)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(82, 20)
        Me.btnExportExcel.TabIndex = 287
        Me.btnExportExcel.Text = "&Export Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = False
        '
        'frmToolsReceivedDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 381)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.dgwTools)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmToolsReceivedDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgwTools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgwTools As DataGridView
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents dgwIssueMaterialsQtyBal As DataGridViewTextBoxColumn
    Friend WithEvents dgwToolNo As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsItemName As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsQty As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsUnitofIssue As DataGridViewTextBoxColumn
End Class
