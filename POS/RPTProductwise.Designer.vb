<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPTProductwise
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPTProductwise))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtQtysold2 = New System.Windows.Forms.TextBox()
        Me.txtSumTotalAmt2 = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cbotxtItemDesc = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnShowReport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Product Name"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(57, 42)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(130, 21)
        Me.DateTimePicker2.TabIndex = 18
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(57, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(130, 21)
        Me.DateTimePicker1.TabIndex = 17
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(35, 143)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(762, 28)
        Me.ListView1.TabIndex = 21
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Code"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Product Name"
        Me.ColumnHeader2.Width = 193
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date"
        Me.ColumnHeader3.Width = 114
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Product Price"
        Me.ColumnHeader4.Width = 126
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Quantity"
        Me.ColumnHeader5.Width = 125
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total Amount"
        Me.ColumnHeader6.Width = 178
        '
        'txtQtysold2
        '
        Me.txtQtysold2.Location = New System.Drawing.Point(668, 117)
        Me.txtQtysold2.Name = "txtQtysold2"
        Me.txtQtysold2.Size = New System.Drawing.Size(64, 20)
        Me.txtQtysold2.TabIndex = 23
        Me.txtQtysold2.Visible = False
        '
        'txtSumTotalAmt2
        '
        Me.txtSumTotalAmt2.Location = New System.Drawing.Point(579, 117)
        Me.txtSumTotalAmt2.Name = "txtSumTotalAmt2"
        Me.txtSumTotalAmt2.Size = New System.Drawing.Size(83, 20)
        Me.txtSumTotalAmt2.TabIndex = 22
        Me.txtSumTotalAmt2.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 70)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1015, 682)
        Me.ReportViewer1.TabIndex = 24
        '
        'cbotxtItemDesc
        '
        Me.cbotxtItemDesc.FormattingEnabled = True
        Me.cbotxtItemDesc.Location = New System.Drawing.Point(286, 30)
        Me.cbotxtItemDesc.Name = "cbotxtItemDesc"
        Me.cbotxtItemDesc.Size = New System.Drawing.Size(232, 21)
        Me.cbotxtItemDesc.TabIndex = 25
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cbotxtItemDesc)
        Me.GroupBox3.Controls.Add(Me.BtnShowReport)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1015, 68)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Parameters"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(652, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 23)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Product Wise Purchase Report"
        '
        'BtnShowReport
        '
        Me.BtnShowReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnShowReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnShowReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowReport.Image = CType(resources.GetObject("BtnShowReport.Image"), System.Drawing.Image)
        Me.BtnShowReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnShowReport.Location = New System.Drawing.Point(524, 27)
        Me.BtnShowReport.Name = "BtnShowReport"
        Me.BtnShowReport.Size = New System.Drawing.Size(102, 31)
        Me.BtnShowReport.TabIndex = 37
        Me.BtnShowReport.Text = "&Load Report"
        Me.BtnShowReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnShowReport.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "From :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "To:"
        '
        'RPTProductwise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 753)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtQtysold2)
        Me.Controls.Add(Me.txtSumTotalAmt2)
        Me.Controls.Add(Me.ListView1)
        Me.KeyPreview = True
        Me.Name = "RPTProductwise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Wise Report"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtQtysold2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSumTotalAmt2 As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cbotxtItemDesc As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnShowReport As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
