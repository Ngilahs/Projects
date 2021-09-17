<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuppliers))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.NewToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.UpdateToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.SearchToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.lstviewSupp = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.ToolStripButtonDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightGray
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.NewToolStripButton4, Me.UpdateToolStripButton3, Me.SearchToolStripButton2, Me.ToolStripButton1, Me.ToolStripButtonDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(780, 40)
        Me.ToolStrip1.TabIndex = 30
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 37)
        Me.ToolStripLabel1.Text = "   "
        '
        'NewToolStripButton4
        '
        Me.NewToolStripButton4.AutoSize = False
        Me.NewToolStripButton4.Image = CType(resources.GetObject("NewToolStripButton4.Image"), System.Drawing.Image)
        Me.NewToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton4.Name = "NewToolStripButton4"
        Me.NewToolStripButton4.Size = New System.Drawing.Size(65, 40)
        Me.NewToolStripButton4.Text = "&New"
        '
        'UpdateToolStripButton3
        '
        Me.UpdateToolStripButton3.AutoSize = False
        Me.UpdateToolStripButton3.Image = CType(resources.GetObject("UpdateToolStripButton3.Image"), System.Drawing.Image)
        Me.UpdateToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UpdateToolStripButton3.Name = "UpdateToolStripButton3"
        Me.UpdateToolStripButton3.Size = New System.Drawing.Size(65, 40)
        Me.UpdateToolStripButton3.Text = "&Update"
        '
        'SearchToolStripButton2
        '
        Me.SearchToolStripButton2.AutoSize = False
        Me.SearchToolStripButton2.Image = CType(resources.GetObject("SearchToolStripButton2.Image"), System.Drawing.Image)
        Me.SearchToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolStripButton2.Name = "SearchToolStripButton2"
        Me.SearchToolStripButton2.Size = New System.Drawing.Size(65, 40)
        Me.SearchToolStripButton2.Text = "&Search"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(65, 40)
        Me.ToolStripButton1.Text = "Clos&e"
        '
        'lstviewSupp
        '
        Me.lstviewSupp.BackColor = System.Drawing.Color.White
        Me.lstviewSupp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lstviewSupp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstviewSupp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstviewSupp.FullRowSelect = True
        Me.lstviewSupp.GridLines = True
        Me.lstviewSupp.Location = New System.Drawing.Point(0, 40)
        Me.lstviewSupp.Name = "lstviewSupp"
        Me.lstviewSupp.Size = New System.Drawing.Size(780, 258)
        Me.lstviewSupp.TabIndex = 31
        Me.lstviewSupp.UseCompatibleStateImageBehavior = False
        Me.lstviewSupp.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Supplier ID"
        Me.ColumnHeader4.Width = 94
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Supplier Name "
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 138
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Supplier Address."
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 104
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Contact No"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 113
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Contact Person"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 107
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Email Address"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 108
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Location"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 158
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(468, 24)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(41, 13)
        Me.lblSearch.TabIndex = 32
        Me.lblSearch.Text = "Search"
        Me.lblSearch.Visible = False
        '
        'ToolStripButtonDelete
        '
        Me.ToolStripButtonDelete.AutoSize = False
        Me.ToolStripButtonDelete.Image = CType(resources.GetObject("ToolStripButtonDelete.Image"), System.Drawing.Image)
        Me.ToolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDelete.Name = "ToolStripButtonDelete"
        Me.ToolStripButtonDelete.Size = New System.Drawing.Size(65, 40)
        Me.ToolStripButtonDelete.Text = "&Delete"
        '
        'frmSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 298)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lstviewSupp)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmSuppliers"
        Me.Text = "Suppliers"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NewToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents UpdateToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lstviewSupp As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripButtonDelete As System.Windows.Forms.ToolStripButton
End Class
