<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcopyofReceipt
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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBLSessionNo = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Vatableamt = New System.Windows.Forms.Label()
        Me.lblVATtot = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LBLCustomer = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblvatamt = New System.Windows.Forms.Label()
        Me.lblvatableamt = New System.Windows.Forms.Label()
        Me.lblThank = New System.Windows.Forms.Label()
        Me.lblOR = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.subTotal = New System.Windows.Forms.Label()
        Me.Change = New System.Windows.Forms.Label()
        Me.vat = New System.Windows.Forms.Label()
        Me.lblTendered = New System.Windows.Forms.Label()
        Me.Tendered = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.LBLTillNo = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblSaletype = New System.Windows.Forms.Label()
        Me.lblReceiptNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblTransNo = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPin = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMpesaTillNo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblMobileNo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblCName = New System.Windows.Forms.Label()
        Me.BTNReprintReceipt = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ListBox2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.LBLTillNo)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.ListBox3)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.LblSaletype)
        Me.Panel1.Controls.Add(Me.lblReceiptNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.LblDate)
        Me.Panel1.Controls.Add(Me.LblTime)
        Me.Panel1.Controls.Add(Me.LblTransNo)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblPin)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblMpesaTillNo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LblMobileNo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LblCName)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 372)
        Me.Panel1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 14
        Me.ListBox2.Location = New System.Drawing.Point(129, 143)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(42, 14)
        Me.ListBox2.TabIndex = 81
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.LBLSessionNo)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Vatableamt)
        Me.Panel2.Controls.Add(Me.lblVATtot)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.LBLCustomer)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblTotalItems)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.lblvatamt)
        Me.Panel2.Controls.Add(Me.lblvatableamt)
        Me.Panel2.Controls.Add(Me.lblThank)
        Me.Panel2.Controls.Add(Me.lblOR)
        Me.Panel2.Controls.Add(Me.lblSubtotal)
        Me.Panel2.Controls.Add(Me.lblChange)
        Me.Panel2.Controls.Add(Me.subTotal)
        Me.Panel2.Controls.Add(Me.Change)
        Me.Panel2.Controls.Add(Me.vat)
        Me.Panel2.Controls.Add(Me.lblTendered)
        Me.Panel2.Controls.Add(Me.Tendered)
        Me.Panel2.Location = New System.Drawing.Point(3, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 211)
        Me.Panel2.TabIndex = 80
        '
        'LBLSessionNo
        '
        Me.LBLSessionNo.AutoSize = True
        Me.LBLSessionNo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSessionNo.Location = New System.Drawing.Point(201, 139)
        Me.LBLSessionNo.Name = "LBLSessionNo"
        Me.LBLSessionNo.Size = New System.Drawing.Size(37, 14)
        Me.LBLSessionNo.TabIndex = 127
        Me.LBLSessionNo.Text = "#####"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(135, 139)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 14)
        Me.Label20.TabIndex = 126
        Me.Label20.Text = "Session No:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(0, 165)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(243, 14)
        Me.Label16.TabIndex = 123
        Me.Label16.Text = "-----------------------------------------------------------"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(0, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(243, 14)
        Me.Label14.TabIndex = 122
        Me.Label14.Text = "-----------------------------------------------------------"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(243, 14)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "-----------------------------------------------------------"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(14, 111)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(15, 14)
        Me.Label23.TabIndex = 120
        Me.Label23.Text = "A"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(49, 111)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 13)
        Me.Label25.TabIndex = 119
        Me.Label25.Text = "16%"
        '
        'Vatableamt
        '
        Me.Vatableamt.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vatableamt.Location = New System.Drawing.Point(88, 112)
        Me.Vatableamt.Name = "Vatableamt"
        Me.Vatableamt.Size = New System.Drawing.Size(66, 13)
        Me.Vatableamt.TabIndex = 118
        Me.Vatableamt.Text = "0.00"
        Me.Vatableamt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVATtot
        '
        Me.lblVATtot.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVATtot.Location = New System.Drawing.Point(155, 113)
        Me.lblVATtot.Name = "lblVATtot"
        Me.lblVATtot.Size = New System.Drawing.Size(69, 12)
        Me.lblVATtot.TabIndex = 117
        Me.lblVATtot.Text = "0.00"
        Me.lblVATtot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(4, 3)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(243, 14)
        Me.Label28.TabIndex = 112
        Me.Label28.Text = "-----------------------------------------------------------"
        '
        'LBLCustomer
        '
        Me.LBLCustomer.AutoSize = True
        Me.LBLCustomer.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCustomer.Location = New System.Drawing.Point(36, 137)
        Me.LBLCustomer.Name = "LBLCustomer"
        Me.LBLCustomer.Size = New System.Drawing.Size(37, 14)
        Me.LBLCustomer.TabIndex = 111
        Me.LBLCustomer.Text = "#####"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(9, 137)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 14)
        Me.Label24.TabIndex = 110
        Me.Label24.Text = "Cust:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(87, 151)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 14)
        Me.Label22.TabIndex = 109
        Me.Label22.Text = "#####"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 151)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 14)
        Me.Label21.TabIndex = 108
        Me.Label21.Text = "Served By:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(44, 97)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 14)
        Me.Label19.TabIndex = 106
        Me.Label19.Text = "Rate%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 14)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Prices inclusive of taxes where applicable"
        '
        'lblTotalItems
        '
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.Location = New System.Drawing.Point(89, 68)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(13, 14)
        Me.lblTotalItems.TabIndex = 103
        Me.lblTotalItems.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(4, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 14)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "Total Items:"
        '
        'lblvatamt
        '
        Me.lblvatamt.AutoSize = True
        Me.lblvatamt.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvatamt.Location = New System.Drawing.Point(173, 98)
        Me.lblvatamt.Name = "lblvatamt"
        Me.lblvatamt.Size = New System.Drawing.Size(51, 14)
        Me.lblvatamt.TabIndex = 99
        Me.lblvatamt.Text = "VAT Amt"
        '
        'lblvatableamt
        '
        Me.lblvatableamt.AutoSize = True
        Me.lblvatableamt.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvatableamt.Location = New System.Drawing.Point(94, 98)
        Me.lblvatableamt.Name = "lblvatableamt"
        Me.lblvatableamt.Size = New System.Drawing.Size(66, 14)
        Me.lblvatableamt.TabIndex = 98
        Me.lblvatableamt.Text = "Vatable Amt:"
        '
        'lblThank
        '
        Me.lblThank.AutoSize = True
        Me.lblThank.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThank.Location = New System.Drawing.Point(42, 177)
        Me.lblThank.Name = "lblThank"
        Me.lblThank.Size = New System.Drawing.Size(160, 13)
        Me.lblThank.TabIndex = 96
        Me.lblThank.Text = "Thank You Come Again!"
        '
        'lblOR
        '
        Me.lblOR.AutoSize = True
        Me.lblOR.Location = New System.Drawing.Point(7, 190)
        Me.lblOR.Name = "lblOR"
        Me.lblOR.Size = New System.Drawing.Size(234, 14)
        Me.lblOR.TabIndex = 97
        Me.lblOR.Text = "****THIS IS A COPY OF LEGAL RECEPIT***"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(144, 16)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(80, 13)
        Me.lblSubtotal.TabIndex = 91
        Me.lblSubtotal.Text = "0.00"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.Transparent
        Me.lblChange.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(144, 40)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(80, 15)
        Me.lblChange.TabIndex = 92
        Me.lblChange.Text = "0.00"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'subTotal
        '
        Me.subTotal.AutoSize = True
        Me.subTotal.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTotal.Location = New System.Drawing.Point(3, 16)
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Size = New System.Drawing.Size(39, 14)
        Me.subTotal.TabIndex = 93
        Me.subTotal.Text = "Totals:"
        '
        'Change
        '
        Me.Change.AutoSize = True
        Me.Change.BackColor = System.Drawing.Color.Transparent
        Me.Change.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Change.Location = New System.Drawing.Point(4, 40)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(44, 14)
        Me.Change.TabIndex = 95
        Me.Change.Text = "Change:"
        '
        'vat
        '
        Me.vat.AutoSize = True
        Me.vat.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vat.Location = New System.Drawing.Point(5, 98)
        Me.vat.Name = "vat"
        Me.vat.Size = New System.Drawing.Size(33, 14)
        Me.vat.TabIndex = 90
        Me.vat.Text = "Code:"
        '
        'lblTendered
        '
        Me.lblTendered.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTendered.Location = New System.Drawing.Point(144, 29)
        Me.lblTendered.Name = "lblTendered"
        Me.lblTendered.Size = New System.Drawing.Size(80, 13)
        Me.lblTendered.TabIndex = 88
        Me.lblTendered.Text = "0.00"
        Me.lblTendered.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tendered
        '
        Me.Tendered.AutoSize = True
        Me.Tendered.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tendered.Location = New System.Drawing.Point(4, 29)
        Me.Tendered.Name = "Tendered"
        Me.Tendered.Size = New System.Drawing.Size(55, 14)
        Me.Tendered.TabIndex = 89
        Me.Tendered.Text = "Tendered :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(1, 113)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(243, 14)
        Me.Label27.TabIndex = 77
        Me.Label27.Text = "-----------------------------------------------------------"
        '
        'LBLTillNo
        '
        Me.LBLTillNo.AutoSize = True
        Me.LBLTillNo.Location = New System.Drawing.Point(176, 99)
        Me.LBLTillNo.Name = "LBLTillNo"
        Me.LBLTillNo.Size = New System.Drawing.Size(43, 14)
        Me.LBLTillNo.TabIndex = 49
        Me.LBLTillNo.Text = "######"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(123, 99)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(27, 14)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "Till:"
        '
        'ListBox3
        '
        Me.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 14
        Me.ListBox3.Location = New System.Drawing.Point(177, 144)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(61, 14)
        Me.ListBox3.TabIndex = 25
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(3, 142)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(134, 12)
        Me.ListBox1.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(138, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 14)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Qty"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(190, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 14)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Amt"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(122, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 14)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Receipt #:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 14)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Item"
        '
        'LblSaletype
        '
        Me.LblSaletype.AutoSize = True
        Me.LblSaletype.Location = New System.Drawing.Point(52, 101)
        Me.LblSaletype.Name = "LblSaletype"
        Me.LblSaletype.Size = New System.Drawing.Size(31, 14)
        Me.LblSaletype.TabIndex = 17
        Me.LblSaletype.Text = "####"
        '
        'lblReceiptNo
        '
        Me.lblReceiptNo.AutoSize = True
        Me.lblReceiptNo.Location = New System.Drawing.Point(176, 87)
        Me.lblReceiptNo.Name = "lblReceiptNo"
        Me.lblReceiptNo.Size = New System.Drawing.Size(43, 14)
        Me.lblReceiptNo.TabIndex = 16
        Me.lblReceiptNo.Text = "######"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 14)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Sale:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(122, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 14)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Time:"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Location = New System.Drawing.Point(52, 75)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(31, 14)
        Me.LblDate.TabIndex = 13
        Me.LblDate.Text = "####"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Location = New System.Drawing.Point(176, 73)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(37, 14)
        Me.LblTime.TabIndex = 12
        Me.LblTime.Text = "#####"
        '
        'LblTransNo
        '
        Me.LblTransNo.AutoSize = True
        Me.LblTransNo.Location = New System.Drawing.Point(52, 87)
        Me.LblTransNo.Name = "LblTransNo"
        Me.LblTransNo.Size = New System.Drawing.Size(31, 14)
        Me.LblTransNo.TabIndex = 11
        Me.LblTransNo.Text = "####"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 14)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Trans #:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 14)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Date:"
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Location = New System.Drawing.Point(90, 61)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(31, 14)
        Me.lblPin.TabIndex = 7
        Me.lblPin.Text = "####"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "PIN:"
        '
        'lblMpesaTillNo
        '
        Me.lblMpesaTillNo.AutoSize = True
        Me.lblMpesaTillNo.Location = New System.Drawing.Point(147, 48)
        Me.lblMpesaTillNo.Name = "lblMpesaTillNo"
        Me.lblMpesaTillNo.Size = New System.Drawing.Size(37, 14)
        Me.lblMpesaTillNo.TabIndex = 5
        Me.lblMpesaTillNo.Text = "#####"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "M-pesa Till No:"
        '
        'LblMobileNo
        '
        Me.LblMobileNo.AutoSize = True
        Me.LblMobileNo.Location = New System.Drawing.Point(126, 35)
        Me.LblMobileNo.Name = "LblMobileNo"
        Me.LblMobileNo.Size = New System.Drawing.Size(31, 14)
        Me.LblMobileNo.TabIndex = 3
        Me.LblMobileNo.Text = "####"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mobile No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "####"
        '
        'LblCName
        '
        Me.LblCName.AutoSize = True
        Me.LblCName.Location = New System.Drawing.Point(45, 9)
        Me.LblCName.Name = "LblCName"
        Me.LblCName.Size = New System.Drawing.Size(31, 14)
        Me.LblCName.TabIndex = 0
        Me.LblCName.Text = "####"
        '
        'BTNReprintReceipt
        '
        Me.BTNReprintReceipt.Location = New System.Drawing.Point(67, 376)
        Me.BTNReprintReceipt.Name = "BTNReprintReceipt"
        Me.BTNReprintReceipt.Size = New System.Drawing.Size(74, 20)
        Me.BTNReprintReceipt.TabIndex = 2
        Me.BTNReprintReceipt.Text = "Print"
        Me.BTNReprintReceipt.UseVisualStyleBackColor = True
        '
        'frmcopyofReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(252, 396)
        Me.Controls.Add(Me.BTNReprintReceipt)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmcopyofReceipt"
        Me.Text = "Printing Copy of Receipt>>>>>>>>"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Vatableamt As System.Windows.Forms.Label
    Friend WithEvents lblVATtot As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents LBLCustomer As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalItems As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblvatamt As System.Windows.Forms.Label
    Friend WithEvents lblvatableamt As System.Windows.Forms.Label
    Friend WithEvents lblThank As System.Windows.Forms.Label
    Friend WithEvents lblOR As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents subTotal As System.Windows.Forms.Label
    Friend WithEvents Change As System.Windows.Forms.Label
    Friend WithEvents vat As System.Windows.Forms.Label
    Friend WithEvents lblTendered As System.Windows.Forms.Label
    Friend WithEvents Tendered As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents LBLTillNo As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblSaletype As System.Windows.Forms.Label
    Friend WithEvents lblReceiptNo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents LblTime As System.Windows.Forms.Label
    Friend WithEvents LblTransNo As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblPin As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMpesaTillNo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblMobileNo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblCName As System.Windows.Forms.Label
    Friend WithEvents LBLSessionNo As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents BTNReprintReceipt As System.Windows.Forms.Button
End Class
