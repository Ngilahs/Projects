<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.NewToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.UpdateToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.SearchToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DeleteToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightGray
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.NewToolStripButton4, Me.UpdateToolStripButton3, Me.SearchToolStripButton2, Me.ToolStripButton1, Me.DeleteToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(989, 40)
        Me.ToolStrip1.TabIndex = 29
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
        'DeleteToolStripButton5
        '
        Me.DeleteToolStripButton5.AutoSize = False
        Me.DeleteToolStripButton5.Image = CType(resources.GetObject("DeleteToolStripButton5.Image"), System.Drawing.Image)
        Me.DeleteToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton5.Name = "DeleteToolStripButton5"
        Me.DeleteToolStripButton5.Size = New System.Drawing.Size(65, 40)
        Me.DeleteToolStripButton5.Text = "&Delete"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 40)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(989, 474)
        Me.ListView1.TabIndex = 30
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Staff ID"
        Me.ColumnHeader4.Width = 94
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Name "
        Me.ColumnHeader5.Width = 206
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Contact No."
        Me.ColumnHeader6.Width = 104
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Address"
        Me.ColumnHeader7.Width = 350
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Username"
        Me.ColumnHeader8.Width = 131
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Role"
        Me.ColumnHeader9.Width = 90
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(374, 9)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(0, 13)
        Me.lblSearch.TabIndex = 31
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 514)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff"
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
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeleteToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblSearch As System.Windows.Forms.Label
End Class
