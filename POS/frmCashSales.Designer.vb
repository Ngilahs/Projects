<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashSales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.txtTotalAmt1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReceiptNo1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsearchsname1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpDateFrom1 = New System.Windows.Forms.DateTimePicker()
        Me.btnLCSGetData1 = New System.Windows.Forms.Button()
        Me.dtpDateTo1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.btnLCSExportExcel = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBlAmt1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLVat1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LBLMarkup1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReorderLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Quantity, Me.Column9, Me.Column6, Me.Column8, Me.Column10, Me.Column4, Me.ReorderLevel, Me.ColUser, Me.Column11, Me.Column5})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(13, 129)
        Me.dgw.Margin = New System.Windows.Forms.Padding(4)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(1349, 406)
        Me.dgw.TabIndex = 189
        '
        'txtTotalAmt1
        '
        Me.txtTotalAmt1.BackColor = System.Drawing.Color.White
        Me.txtTotalAmt1.Location = New System.Drawing.Point(316, 84)
        Me.txtTotalAmt1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalAmt1.Name = "txtTotalAmt1"
        Me.txtTotalAmt1.Size = New System.Drawing.Size(123, 22)
        Me.txtTotalAmt1.TabIndex = 196
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 195
        Me.Label2.Text = "Amount :"
        '
        'txtReceiptNo1
        '
        Me.txtReceiptNo1.BackColor = System.Drawing.Color.White
        Me.txtReceiptNo1.Location = New System.Drawing.Point(170, 84)
        Me.txtReceiptNo1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReceiptNo1.Name = "txtReceiptNo1"
        Me.txtReceiptNo1.Size = New System.Drawing.Size(111, 22)
        Me.txtReceiptNo1.TabIndex = 194
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 193
        Me.Label1.Text = " Receipt No :"
        '
        'txtsearchsname1
        '
        Me.txtsearchsname1.BackColor = System.Drawing.Color.White
        Me.txtsearchsname1.Location = New System.Drawing.Point(23, 82)
        Me.txtsearchsname1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearchsname1.Name = "txtsearchsname1"
        Me.txtsearchsname1.Size = New System.Drawing.Size(126, 22)
        Me.txtsearchsname1.TabIndex = 191
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 61)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 192
        Me.Label9.Text = " Trans Ref No :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.dtpDateFrom1)
        Me.GroupBox3.Controls.Add(Me.btnLCSGetData1)
        Me.GroupBox3.Controls.Add(Me.dtpDateTo1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(468, 53)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(331, 68)
        Me.GroupBox3.TabIndex = 190
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cash Sales by Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 20)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 17)
        Me.Label11.TabIndex = 169
        Me.Label11.Text = "From :"
        '
        'dtpDateFrom1
        '
        Me.dtpDateFrom1.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom1.Location = New System.Drawing.Point(12, 39)
        Me.dtpDateFrom1.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateFrom1.Name = "dtpDateFrom1"
        Me.dtpDateFrom1.Size = New System.Drawing.Size(107, 22)
        Me.dtpDateFrom1.TabIndex = 168
        '
        'btnLCSGetData1
        '
        Me.btnLCSGetData1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLCSGetData1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLCSGetData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLCSGetData1.Location = New System.Drawing.Point(240, 20)
        Me.btnLCSGetData1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLCSGetData1.Name = "btnLCSGetData1"
        Me.btnLCSGetData1.Size = New System.Drawing.Size(83, 43)
        Me.btnLCSGetData1.TabIndex = 167
        Me.btnLCSGetData1.Text = "Get Data"
        Me.btnLCSGetData1.UseVisualStyleBackColor = True
        '
        'dtpDateTo1
        '
        Me.dtpDateTo1.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo1.Location = New System.Drawing.Point(128, 39)
        Me.dtpDateTo1.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateTo1.Name = "dtpDateTo1"
        Me.dtpDateTo1.Size = New System.Drawing.Size(104, 22)
        Me.dtpDateTo1.TabIndex = 171
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 17)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "To :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1371, 44)
        Me.Panel1.TabIndex = 197
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(458, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 43)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "List of Cash Sales"
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.Aqua
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(1038, 77)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(100, 28)
        Me.BtnReset.TabIndex = 175
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'btnLCSExportExcel
        '
        Me.btnLCSExportExcel.AutoSize = True
        Me.btnLCSExportExcel.BackColor = System.Drawing.Color.Aqua
        Me.btnLCSExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLCSExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLCSExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLCSExportExcel.Location = New System.Drawing.Point(860, 77)
        Me.btnLCSExportExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLCSExportExcel.Name = "btnLCSExportExcel"
        Me.btnLCSExportExcel.Size = New System.Drawing.Size(119, 28)
        Me.btnLCSExportExcel.TabIndex = 174
        Me.btnLCSExportExcel.Text = "&Export To Excel"
        Me.btnLCSExportExcel.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel2.Controls.Add(Me.LBlAmt1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(13, 564)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(361, 38)
        Me.FlowLayoutPanel2.TabIndex = 200
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(304, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "KSHs"
        '
        'LBlAmt1
        '
        Me.LBlAmt1.AutoSize = True
        Me.LBlAmt1.BackColor = System.Drawing.Color.DimGray
        Me.LBlAmt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBlAmt1.ForeColor = System.Drawing.Color.Cyan
        Me.LBlAmt1.Location = New System.Drawing.Point(230, 0)
        Me.LBlAmt1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBlAmt1.Name = "LBlAmt1"
        Me.LBlAmt1.Size = New System.Drawing.Size(66, 29)
        Me.LBlAmt1.TabIndex = 7
        Me.LBlAmt1.Text = "0.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(129, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 25)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Amount:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.LBLVat1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(805, 564)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(361, 38)
        Me.FlowLayoutPanel1.TabIndex = 199
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "KSHs"
        '
        'LBLVat1
        '
        Me.LBLVat1.AutoSize = True
        Me.LBLVat1.BackColor = System.Drawing.Color.DimGray
        Me.LBLVat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLVat1.ForeColor = System.Drawing.Color.Cyan
        Me.LBLVat1.Location = New System.Drawing.Point(230, 0)
        Me.LBLVat1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLVat1.Name = "LBLVat1"
        Me.LBLVat1.Size = New System.Drawing.Size(66, 29)
        Me.LBLVat1.TabIndex = 7
        Me.LBLVat1.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(153, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "VAT :"
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel6.Controls.Add(Me.LBLMarkup1)
        Me.FlowLayoutPanel6.Controls.Add(Me.Label17)
        Me.FlowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(408, 564)
        Me.FlowLayoutPanel6.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(361, 38)
        Me.FlowLayoutPanel6.TabIndex = 198
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(304, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 20)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "KSHs"
        '
        'LBLMarkup1
        '
        Me.LBLMarkup1.AutoSize = True
        Me.LBLMarkup1.BackColor = System.Drawing.Color.DimGray
        Me.LBLMarkup1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMarkup1.ForeColor = System.Drawing.Color.Cyan
        Me.LBLMarkup1.Location = New System.Drawing.Point(230, 0)
        Me.LBLMarkup1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLMarkup1.Name = "LBLMarkup1"
        Me.LBLMarkup1.Size = New System.Drawing.Size(66, 29)
        Me.LBLMarkup1.TabIndex = 7
        Me.LBLMarkup1.Text = "0.00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(122, 0)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 25)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "MarkUp :"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Tran ID #"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 70
        '
        'Column1
        '
        Me.Column1.HeaderText = "Rcpt No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 60
        '
        'Column3
        '
        Me.Column3.HeaderText = "Amt"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 60
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Tendered"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 70
        '
        'Column9
        '
        Me.Column9.HeaderText = "MarkUp"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 70
        '
        'Column6
        '
        Me.Column6.HeaderText = "Vat"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 50
        '
        'Column8
        '
        Me.Column8.HeaderText = "Items"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = "Till No"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "Payment"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 90
        '
        'ReorderLevel
        '
        Me.ReorderLevel.HeaderText = "Customer"
        Me.ReorderLevel.Name = "ReorderLevel"
        Me.ReorderLevel.ReadOnly = True
        Me.ReorderLevel.Width = 65
        '
        'ColUser
        '
        Me.ColUser.HeaderText = "User Name"
        Me.ColUser.Name = "ColUser"
        Me.ColUser.ReadOnly = True
        Me.ColUser.Width = 85
        '
        'Column11
        '
        Me.Column11.HeaderText = "Sess ID"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 65
        '
        'Column5
        '
        Me.Column5.HeaderText = "Time"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 65
        '
        'frmCashSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1375, 641)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel6)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLCSExportExcel)
        Me.Controls.Add(Me.txtTotalAmt1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReceiptNo1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsearchsname1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgw)
        Me.Name = "frmCashSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalAmt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsearchsname1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFrom1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLCSGetData1 As System.Windows.Forms.Button
    Friend WithEvents dtpDateTo1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents btnLCSExportExcel As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LBlAmt1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLVat1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel6 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LBLMarkup1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReorderLevel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
