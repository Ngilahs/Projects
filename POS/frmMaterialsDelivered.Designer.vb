<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterialsDelivered
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
        Me.dgwIssueItems = New System.Windows.Forms.DataGridView()
        Me.dgwIssueMaterialsItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwIssueMaterialsUnitofIssue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSchemeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRefNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colConstituency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCounty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtFilterbyMaterialDesc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgwIssueItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(0, -2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(883, 26)
        Me.TextBox1.TabIndex = 227
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(361, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 15)
        Me.Label2.TabIndex = 228
        Me.Label2.Text = "Material Delivery Summaries"
        '
        'dgwIssueItems
        '
        Me.dgwIssueItems.AllowUserToAddRows = False
        Me.dgwIssueItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgwIssueItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwIssueItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwIssueMaterialsItemNo, Me.dgwIssueMaterialsItemName, Me.dgwIssueMaterialsQty, Me.dgwIssueMaterialsUnitofIssue, Me.colSchemeName, Me.colRefNo, Me.colConstituency, Me.colCounty})
        Me.dgwIssueItems.Location = New System.Drawing.Point(0, 86)
        Me.dgwIssueItems.Name = "dgwIssueItems"
        Me.dgwIssueItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgwIssueItems.Size = New System.Drawing.Size(883, 359)
        Me.dgwIssueItems.TabIndex = 229
        '
        'dgwIssueMaterialsItemNo
        '
        Me.dgwIssueMaterialsItemNo.HeaderText = "Item No"
        Me.dgwIssueMaterialsItemNo.Name = "dgwIssueMaterialsItemNo"
        Me.dgwIssueMaterialsItemNo.ReadOnly = True
        Me.dgwIssueMaterialsItemNo.Width = 75
        '
        'dgwIssueMaterialsItemName
        '
        Me.dgwIssueMaterialsItemName.HeaderText = "Item Name"
        Me.dgwIssueMaterialsItemName.Name = "dgwIssueMaterialsItemName"
        Me.dgwIssueMaterialsItemName.ReadOnly = True
        Me.dgwIssueMaterialsItemName.Width = 250
        '
        'dgwIssueMaterialsQty
        '
        Me.dgwIssueMaterialsQty.HeaderText = "Qty"
        Me.dgwIssueMaterialsQty.Name = "dgwIssueMaterialsQty"
        Me.dgwIssueMaterialsQty.Width = 75
        '
        'dgwIssueMaterialsUnitofIssue
        '
        Me.dgwIssueMaterialsUnitofIssue.HeaderText = "UoM"
        Me.dgwIssueMaterialsUnitofIssue.Name = "dgwIssueMaterialsUnitofIssue"
        Me.dgwIssueMaterialsUnitofIssue.ReadOnly = True
        Me.dgwIssueMaterialsUnitofIssue.Width = 50
        '
        'colSchemeName
        '
        Me.colSchemeName.HeaderText = "Scheme "
        Me.colSchemeName.Name = "colSchemeName"
        Me.colSchemeName.Width = 75
        '
        'colRefNo
        '
        Me.colRefNo.HeaderText = "Ref No"
        Me.colRefNo.Name = "colRefNo"
        '
        'colConstituency
        '
        Me.colConstituency.HeaderText = "Constituency"
        Me.colConstituency.Name = "colConstituency"
        '
        'colCounty
        '
        Me.colCounty.HeaderText = "County"
        Me.colCounty.Name = "colCounty"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExportExcel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.txtFilterbyMaterialDesc)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(883, 50)
        Me.GroupBox1.TabIndex = 230
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Parameters"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.BackColor = System.Drawing.Color.Cyan
        Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(774, 24)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(96, 20)
        Me.btnExportExcel.TabIndex = 308
        Me.btnExportExcel.Text = "&Export To Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Cyan
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(424, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 305
        Me.Label3.Text = "Total "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(465, 22)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(56, 13)
        Me.lblTotal.TabIndex = 304
        Me.lblTotal.Text = "XXXXXXX"
        '
        'txtFilterbyMaterialDesc
        '
        Me.txtFilterbyMaterialDesc.Location = New System.Drawing.Point(100, 19)
        Me.txtFilterbyMaterialDesc.Name = "txtFilterbyMaterialDesc"
        Me.txtFilterbyMaterialDesc.Size = New System.Drawing.Size(197, 20)
        Me.txtFilterbyMaterialDesc.TabIndex = 303
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Cyan
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 302
        Me.Label11.Text = "Material  Name"
        '
        'frmMaterialsDelivered
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 444)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgwIssueItems)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmMaterialsDelivered"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Materials Delivered "
        CType(Me.dgwIssueItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgwIssueItems As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFilterbyMaterialDesc As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dgwIssueMaterialsItemNo As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsItemName As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsQty As DataGridViewTextBoxColumn
    Friend WithEvents dgwIssueMaterialsUnitofIssue As DataGridViewTextBoxColumn
    Friend WithEvents colSchemeName As DataGridViewTextBoxColumn
    Friend WithEvents colRefNo As DataGridViewTextBoxColumn
    Friend WithEvents colConstituency As DataGridViewTextBoxColumn
    Friend WithEvents colCounty As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnExportExcel As Button
End Class
