<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPTMaterialIssueConstituency
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPTMaterialIssueConstituency))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboConstituency = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNLoadExpensereport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 53)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(911, 422)
        Me.ReportViewer1.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Controls.Add(Me.cboConstituency)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.BTNLoadExpensereport)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtSchemeID)
        Me.GroupBox3.Controls.Add(Me.txtConstituencyID)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(911, 45)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Parameters"
        '
        'cboConstituency
        '
        Me.cboConstituency.FormattingEnabled = True
        Me.cboConstituency.Location = New System.Drawing.Point(98, 16)
        Me.cboConstituency.Name = "cboConstituency"
        Me.cboConstituency.Size = New System.Drawing.Size(119, 21)
        Me.cboConstituency.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(361, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Material Issuance Per Constituency"
        '
        'BTNLoadExpensereport
        '
        Me.BTNLoadExpensereport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BTNLoadExpensereport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLoadExpensereport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNLoadExpensereport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLoadExpensereport.Image = CType(resources.GetObject("BTNLoadExpensereport.Image"), System.Drawing.Image)
        Me.BTNLoadExpensereport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNLoadExpensereport.Location = New System.Drawing.Point(223, 15)
        Me.BTNLoadExpensereport.Name = "BTNLoadExpensereport"
        Me.BTNLoadExpensereport.Size = New System.Drawing.Size(63, 22)
        Me.BTNLoadExpensereport.TabIndex = 37
        Me.BTNLoadExpensereport.Text = "&Load "
        Me.BTNLoadExpensereport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNLoadExpensereport.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Constituency:"
        '
        'txtSchemeID
        '
        Me.txtSchemeID.Location = New System.Drawing.Point(98, 16)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(27, 21)
        Me.txtSchemeID.TabIndex = 45
        Me.txtSchemeID.Visible = False
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.Location = New System.Drawing.Point(131, 16)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(27, 21)
        Me.txtConstituencyID.TabIndex = 46
        Me.txtConstituencyID.Visible = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader4, Me.ColumnHeader7})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 123)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(726, 82)
        Me.ListView1.TabIndex = 41
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Delivery No"
        Me.ColumnHeader1.Width = 103
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item No"
        Me.ColumnHeader2.Width = 193
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 114
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Qty Issued"
        Me.ColumnHeader5.Width = 125
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Unit of Issued"
        Me.ColumnHeader6.Width = 105
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date Issued"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Scheme Name"
        '
        'RPTMaterialIssueConstituency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 476)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "RPTMaterialIssueConstituency"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material Issueance Per Constituency"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboConstituency As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNLoadExpensereport As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents txtConstituencyID As TextBox
End Class
