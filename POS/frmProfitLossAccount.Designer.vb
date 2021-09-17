<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfitLossAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfitLossAccount))
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.ColRecptNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMkup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgw1 = New System.Windows.Forms.DataGridView()
        Me.colExpRefNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColExpname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colexpDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEntityname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColExpAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrintreport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLTotSales = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBLTotVat = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBLMkup = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLTotExpenses = New System.Windows.Forms.Label()
        Me.btnLCSExportExcel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDiscountscommissions = New System.Windows.Forms.TextBox()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(57, 13)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(129, 21)
        Me.DateTimePickerFrom.TabIndex = 18
        '
        'dgw
        '
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRecptNo, Me.Coldate, Me.colAmt, Me.colMkup, Me.colVat})
        Me.dgw.Location = New System.Drawing.Point(3, 105)
        Me.dgw.Name = "dgw"
        Me.dgw.Size = New System.Drawing.Size(548, 160)
        Me.dgw.TabIndex = 22
        '
        'ColRecptNo
        '
        Me.ColRecptNo.HeaderText = "Receipt No"
        Me.ColRecptNo.Name = "ColRecptNo"
        '
        'Coldate
        '
        Me.Coldate.HeaderText = "Date"
        Me.Coldate.Name = "Coldate"
        '
        'colAmt
        '
        Me.colAmt.HeaderText = "Amount"
        Me.colAmt.Name = "colAmt"
        '
        'colMkup
        '
        Me.colMkup.HeaderText = "Mark Up"
        Me.colMkup.Name = "colMkup"
        '
        'colVat
        '
        Me.colVat.HeaderText = "Vat"
        Me.colVat.Name = "colVat"
        '
        'dgw1
        '
        Me.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colExpRefNo, Me.ColExpname, Me.colexpDate, Me.ColEntityname, Me.ColExpAmt})
        Me.dgw1.Location = New System.Drawing.Point(3, 362)
        Me.dgw1.Name = "dgw1"
        Me.dgw1.Size = New System.Drawing.Size(548, 147)
        Me.dgw1.TabIndex = 23
        '
        'colExpRefNo
        '
        Me.colExpRefNo.HeaderText = "Expense Ref #"
        Me.colExpRefNo.Name = "colExpRefNo"
        '
        'ColExpname
        '
        Me.ColExpname.HeaderText = "Expense Name"
        Me.ColExpname.Name = "ColExpname"
        '
        'colexpDate
        '
        Me.colexpDate.HeaderText = "Date"
        Me.colexpDate.Name = "colexpDate"
        '
        'ColEntityname
        '
        Me.ColEntityname.HeaderText = "Entity Name"
        Me.ColEntityname.Name = "ColEntityname"
        '
        'ColExpAmt
        '
        Me.ColExpAmt.HeaderText = "Amount"
        Me.ColExpAmt.Name = "ColExpAmt"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.btnPrintreport)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerFrom)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerTo)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1025, 68)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Parameters"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(752, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 31)
        Me.Button2.TabIndex = 199
        Me.Button2.Text = "&Load Profit and Loss Account"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(346, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Profit and Loss Account"
        '
        'btnPrintreport
        '
        Me.btnPrintreport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnPrintreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrintreport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintreport.Image = CType(resources.GetObject("btnPrintreport.Image"), System.Drawing.Image)
        Me.btnPrintreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintreport.Location = New System.Drawing.Point(206, 19)
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
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerTo.Location = New System.Drawing.Point(57, 41)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(129, 21)
        Me.DateTimePickerTo.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(175, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Total Sales"
        '
        'LBLTotSales
        '
        Me.LBLTotSales.AutoSize = True
        Me.LBLTotSales.BackColor = System.Drawing.Color.DimGray
        Me.LBLTotSales.ForeColor = System.Drawing.Color.Cyan
        Me.LBLTotSales.Location = New System.Drawing.Point(241, 289)
        Me.LBLTotSales.Name = "LBLTotSales"
        Me.LBLTotSales.Size = New System.Drawing.Size(42, 13)
        Me.LBLTotSales.TabIndex = 43
        Me.LBLTotSales.Text = "#####"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkOrange
        Me.Label6.Location = New System.Drawing.Point(454, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Vat"
        '
        'LBLTotVat
        '
        Me.LBLTotVat.AutoSize = True
        Me.LBLTotVat.BackColor = System.Drawing.Color.DimGray
        Me.LBLTotVat.ForeColor = System.Drawing.Color.Cyan
        Me.LBLTotVat.Location = New System.Drawing.Point(493, 290)
        Me.LBLTotVat.Name = "LBLTotVat"
        Me.LBLTotVat.Size = New System.Drawing.Size(35, 13)
        Me.LBLTotVat.TabIndex = 45
        Me.LBLTotVat.Text = "####"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DarkOrange
        Me.Label8.Location = New System.Drawing.Point(299, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Mark Up"
        '
        'LBLMkup
        '
        Me.LBLMkup.AutoSize = True
        Me.LBLMkup.BackColor = System.Drawing.Color.DimGray
        Me.LBLMkup.ForeColor = System.Drawing.Color.Cyan
        Me.LBLMkup.Location = New System.Drawing.Point(364, 290)
        Me.LBLMkup.Name = "LBLMkup"
        Me.LBLMkup.Size = New System.Drawing.Size(35, 13)
        Me.LBLMkup.TabIndex = 47
        Me.LBLMkup.Text = "####"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(389, 537)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Total Expenses"
        '
        'LBLTotExpenses
        '
        Me.LBLTotExpenses.AutoSize = True
        Me.LBLTotExpenses.BackColor = System.Drawing.Color.DimGray
        Me.LBLTotExpenses.ForeColor = System.Drawing.Color.Cyan
        Me.LBLTotExpenses.Location = New System.Drawing.Point(509, 537)
        Me.LBLTotExpenses.Name = "LBLTotExpenses"
        Me.LBLTotExpenses.Size = New System.Drawing.Size(42, 13)
        Me.LBLTotExpenses.TabIndex = 49
        Me.LBLTotExpenses.Text = "#####"
        '
        'btnLCSExportExcel
        '
        Me.btnLCSExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLCSExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLCSExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLCSExportExcel.Location = New System.Drawing.Point(469, 77)
        Me.btnLCSExportExcel.Name = "btnLCSExportExcel"
        Me.btnLCSExportExcel.Size = New System.Drawing.Size(82, 24)
        Me.btnLCSExportExcel.TabIndex = 173
        Me.btnLCSExportExcel.Text = "&Export Excel"
        Me.btnLCSExportExcel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(457, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 21)
        Me.Button1.TabIndex = 174
        Me.Button1.Text = "&Export Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DimGray
        Me.Label7.ForeColor = System.Drawing.Color.Cyan
        Me.Label7.Location = New System.Drawing.Point(0, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 175
        Me.Label7.Text = "Monthly Expenses"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DimGray
        Me.Label9.ForeColor = System.Drawing.Color.Cyan
        Me.Label9.Location = New System.Drawing.Point(12, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 176
        Me.Label9.Text = "Monthly Sales"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.DarkOrange
        Me.Label15.Location = New System.Drawing.Point(175, 323)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 13)
        Me.Label15.TabIndex = 207
        Me.Label15.Text = "Discounts and Comms"
        '
        'txtDiscountscommissions
        '
        Me.txtDiscountscommissions.Location = New System.Drawing.Point(293, 316)
        Me.txtDiscountscommissions.Name = "txtDiscountscommissions"
        Me.txtDiscountscommissions.Size = New System.Drawing.Size(117, 20)
        Me.txtDiscountscommissions.TabIndex = 208
        '
        'frmProfitLossAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 753)
        Me.Controls.Add(Me.txtDiscountscommissions)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLCSExportExcel)
        Me.Controls.Add(Me.LBLTotExpenses)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LBLMkup)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LBLTotVat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LBLTotSales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgw1)
        Me.Controls.Add(Me.dgw)
        Me.Name = "frmProfitLossAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profit and Loss Account"
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePickerFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents dgw1 As System.Windows.Forms.DataGridView
    Friend WithEvents colExpRefNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColExpname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colexpDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColEntityname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColExpAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrintreport As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LBLTotSales As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LBLTotVat As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LBLMkup As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLTotExpenses As System.Windows.Forms.Label
    Friend WithEvents btnLCSExportExcel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ColRecptNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMkup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDiscountscommissions As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
