<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPTPayments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPTPayments))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtAmtPay = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrintreport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataSet5 = New POS.DataSet5()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(27, 163)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(887, 20)
        Me.ListView1.TabIndex = 16
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Pay Ref No"
        Me.ColumnHeader1.Width = 103
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Expense|Stock Ref No"
        Me.ColumnHeader2.Width = 193
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Supplier|Expense Name"
        Me.ColumnHeader3.Width = 114
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Pay Date"
        Me.ColumnHeader5.Width = 125
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Amount Due"
        Me.ColumnHeader6.Width = 105
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount Paid"
        Me.ColumnHeader4.Width = 92
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Balance"
        Me.ColumnHeader7.Width = 154
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Paid Via"
        Me.ColumnHeader8.Width = 243
        '
        'txtAmtPay
        '
        Me.txtAmtPay.Location = New System.Drawing.Point(457, 126)
        Me.txtAmtPay.Name = "txtAmtPay"
        Me.txtAmtPay.Size = New System.Drawing.Size(107, 20)
        Me.txtAmtPay.TabIndex = 20
        Me.txtAmtPay.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "POS.RPTPayments.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 71)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1072, 681)
        Me.ReportViewer1.TabIndex = 24
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Controls.Add(Me.DateTimePickerTo)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerFrom)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.btnPrintreport)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1030, 68)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Parameters"
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerTo.Location = New System.Drawing.Point(57, 39)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(141, 21)
        Me.DateTimePickerTo.TabIndex = 40
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(57, 13)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(141, 21)
        Me.DateTimePickerFrom.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(448, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Payments Report"
        '
        'btnPrintreport
        '
        Me.btnPrintreport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnPrintreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrintreport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintreport.Image = CType(resources.GetObject("btnPrintreport.Image"), System.Drawing.Image)
        Me.btnPrintreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintreport.Location = New System.Drawing.Point(241, 20)
        Me.btnPrintreport.Name = "btnPrintreport"
        Me.btnPrintreport.Size = New System.Drawing.Size(102, 31)
        Me.btnPrintreport.TabIndex = 37
        Me.btnPrintreport.Text = "&Load Report"
        Me.btnPrintreport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrintreport.UseVisualStyleBackColor = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "To:"
        '
        'DataSet5
        '
        Me.DataSet5.DataSetName = "DataSet5"
        Me.DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RPTPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 753)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtAmtPay)
        Me.Controls.Add(Me.ListView1)
        Me.KeyPreview = True
        Me.Name = "RPTPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payments Report"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtAmtPay As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSet5 As POS.DataSet5
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrintreport As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerFrom As System.Windows.Forms.DateTimePicker
End Class
