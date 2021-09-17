<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProjectCustomerListSummary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgwv = New System.Windows.Forms.DataGridView()
        Me.colCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustIDNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPhoneNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYCoordinate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colXcoodinate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYRefNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEarthing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColConnectionstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIssuance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colScheme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colZRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTXNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColConstituency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCounty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFilterbyIDMeterNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalCustomers = New System.Windows.Forms.Label()
        Me.txtcountytxnozrefscheme = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgwv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(-1, -1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(978, 40)
        Me.TextBox1.TabIndex = 168
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(410, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 19)
        Me.Label7.TabIndex = 222
        Me.Label7.Text = "Customer List Summary"
        '
        'dgwv
        '
        Me.dgwv.AllowUserToAddRows = False
        Me.dgwv.AllowUserToDeleteRows = False
        Me.dgwv.AllowUserToOrderColumns = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FloralWhite
        Me.dgwv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgwv.BackgroundColor = System.Drawing.Color.White
        Me.dgwv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgwv.ColumnHeadersHeight = 24
        Me.dgwv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCustomerName, Me.colCustIDNo, Me.colPole, Me.ColPhoneNo, Me.colYCoordinate, Me.colXcoodinate, Me.colYRefNo, Me.colmterno, Me.colEarthing, Me.ColConnectionstatus, Me.ColIssuance, Me.colRemarks, Me.colScheme, Me.colZRef, Me.colTXNo, Me.ColConstituency, Me.colCounty})
        Me.dgwv.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwv.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgwv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgwv.EnableHeadersVisualStyles = False
        Me.dgwv.GridColor = System.Drawing.Color.DarkOrange
        Me.dgwv.Location = New System.Drawing.Point(-1, 93)
        Me.dgwv.MultiSelect = False
        Me.dgwv.Name = "dgwv"
        Me.dgwv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwv.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgwv.RowHeadersWidth = 25
        Me.dgwv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.dgwv.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgwv.RowTemplate.Height = 18
        Me.dgwv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgwv.Size = New System.Drawing.Size(978, 355)
        Me.dgwv.TabIndex = 231
        '
        'colCustomerName
        '
        Me.colCustomerName.HeaderText = "Name"
        Me.colCustomerName.Name = "colCustomerName"
        '
        'colCustIDNo
        '
        Me.colCustIDNo.HeaderText = "ID No"
        Me.colCustIDNo.Name = "colCustIDNo"
        Me.colCustIDNo.Width = 75
        '
        'colPole
        '
        Me.colPole.HeaderText = "Pole No"
        Me.colPole.Name = "colPole"
        Me.colPole.Width = 55
        '
        'ColPhoneNo
        '
        Me.ColPhoneNo.HeaderText = "Phone No"
        Me.ColPhoneNo.Name = "ColPhoneNo"
        Me.ColPhoneNo.Width = 75
        '
        'colYCoordinate
        '
        Me.colYCoordinate.HeaderText = "YCo-ord"
        Me.colYCoordinate.Name = "colYCoordinate"
        Me.colYCoordinate.Width = 75
        '
        'colXcoodinate
        '
        Me.colXcoodinate.HeaderText = "XCo-ord"
        Me.colXcoodinate.Name = "colXcoodinate"
        Me.colXcoodinate.Width = 75
        '
        'colYRefNo
        '
        Me.colYRefNo.HeaderText = "YRefNo"
        Me.colYRefNo.Name = "colYRefNo"
        Me.colYRefNo.Width = 75
        '
        'colmterno
        '
        Me.colmterno.HeaderText = "Meter No"
        Me.colmterno.Name = "colmterno"
        Me.colmterno.ReadOnly = True
        Me.colmterno.Width = 70
        '
        'colEarthing
        '
        Me.colEarthing.HeaderText = "Earthing"
        Me.colEarthing.Name = "colEarthing"
        Me.colEarthing.Width = 70
        '
        'ColConnectionstatus
        '
        Me.ColConnectionstatus.HeaderText = "C-Status"
        Me.ColConnectionstatus.Name = "ColConnectionstatus"
        Me.ColConnectionstatus.Width = 75
        '
        'ColIssuance
        '
        Me.ColIssuance.HeaderText = "Issuance"
        Me.ColIssuance.Name = "ColIssuance"
        Me.ColIssuance.Width = 55
        '
        'colRemarks
        '
        Me.colRemarks.HeaderText = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Width = 55
        '
        'colScheme
        '
        Me.colScheme.HeaderText = "Scheme"
        Me.colScheme.Name = "colScheme"
        Me.colScheme.Width = 75
        '
        'colZRef
        '
        Me.colZRef.HeaderText = "Z-Ref No"
        Me.colZRef.Name = "colZRef"
        Me.colZRef.Width = 75
        '
        'colTXNo
        '
        Me.colTXNo.HeaderText = "TX No"
        Me.colTXNo.Name = "colTXNo"
        Me.colTXNo.Width = 65
        '
        'ColConstituency
        '
        Me.ColConstituency.HeaderText = "Constituency"
        Me.ColConstituency.Name = "ColConstituency"
        Me.ColConstituency.Width = 75
        '
        'colCounty
        '
        Me.colCounty.HeaderText = "County"
        Me.colCounty.Name = "colCounty"
        Me.colCounty.Width = 75
        '
        'txtFilterbyIDMeterNo
        '
        Me.txtFilterbyIDMeterNo.Location = New System.Drawing.Point(106, 16)
        Me.txtFilterbyIDMeterNo.Name = "txtFilterbyIDMeterNo"
        Me.txtFilterbyIDMeterNo.Size = New System.Drawing.Size(149, 20)
        Me.txtFilterbyIDMeterNo.TabIndex = 301
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Cyan
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 300
        Me.Label11.Text = "ID No/ Meter No:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExportExcel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblTotalCustomers)
        Me.GroupBox1.Controls.Add(Me.txtcountytxnozrefscheme)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFilterbyIDMeterNo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(978, 43)
        Me.GroupBox1.TabIndex = 302
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Details"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.BackColor = System.Drawing.Color.Cyan
        Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(873, 15)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(96, 20)
        Me.btnExportExcel.TabIndex = 306
        Me.btnExportExcel.Text = "&Export To Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(644, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 305
        Me.Label3.Text = "Total Customers"
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.AutoSize = True
        Me.lblTotalCustomers.Location = New System.Drawing.Point(733, 20)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Size = New System.Drawing.Size(49, 13)
        Me.lblTotalCustomers.TabIndex = 304
        Me.lblTotalCustomers.Text = "XXXXXX"
        '
        'txtcountytxnozrefscheme
        '
        Me.txtcountytxnozrefscheme.Location = New System.Drawing.Point(511, 16)
        Me.txtcountytxnozrefscheme.Name = "txtcountytxnozrefscheme"
        Me.txtcountytxnozrefscheme.Size = New System.Drawing.Size(127, 20)
        Me.txtcountytxnozrefscheme.TabIndex = 303
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Aqua
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(270, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 13)
        Me.Label1.TabIndex = 302
        Me.Label1.Text = "Scheme/ Constituency/County/Z-Ref/TX No:"
        '
        'frmProjectCustomerListSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 457)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgwv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmProjectCustomerListSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgwv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgwv As DataGridView
    Friend WithEvents colCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents colCustIDNo As DataGridViewTextBoxColumn
    Friend WithEvents colPole As DataGridViewTextBoxColumn
    Friend WithEvents ColPhoneNo As DataGridViewTextBoxColumn
    Friend WithEvents colYCoordinate As DataGridViewTextBoxColumn
    Friend WithEvents colXcoodinate As DataGridViewTextBoxColumn
    Friend WithEvents colYRefNo As DataGridViewTextBoxColumn
    Friend WithEvents colmterno As DataGridViewTextBoxColumn
    Friend WithEvents colEarthing As DataGridViewTextBoxColumn
    Friend WithEvents ColConnectionstatus As DataGridViewTextBoxColumn
    Friend WithEvents ColIssuance As DataGridViewTextBoxColumn
    Friend WithEvents colRemarks As DataGridViewTextBoxColumn
    Friend WithEvents colScheme As DataGridViewTextBoxColumn
    Friend WithEvents colZRef As DataGridViewTextBoxColumn
    Friend WithEvents colTXNo As DataGridViewTextBoxColumn
    Friend WithEvents ColConstituency As DataGridViewTextBoxColumn
    Friend WithEvents colCounty As DataGridViewTextBoxColumn
    Friend WithEvents txtFilterbyIDMeterNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalCustomers As Label
    Friend WithEvents txtcountytxnozrefscheme As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExportExcel As Button
End Class
