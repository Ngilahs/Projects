<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrint))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.LblCName = New System.Windows.Forms.Label()
        Me.lblPhysicaladdress = New System.Windows.Forms.Label()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblpobox = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblDeliveryNo = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCreatedBy = New System.Windows.Forms.Label()
        Me.LblSchemeName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LblApprovedBy = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.subTotal = New System.Windows.Forms.Label()
        Me.lblOR = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.lblTelphone = New System.Windows.Forms.Label()
        Me.lblMobilephone = New System.Windows.Forms.Label()
        Me.lblfax = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblSchemerefNo = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LblConstituency = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.LblCounty = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblSessionNo = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'LblCName
        '
        Me.LblCName.AutoSize = True
        Me.LblCName.Location = New System.Drawing.Point(571, 8)
        Me.LblCName.Name = "LblCName"
        Me.LblCName.Size = New System.Drawing.Size(35, 15)
        Me.LblCName.TabIndex = 0
        Me.LblCName.Text = "####"
        '
        'lblPhysicaladdress
        '
        Me.lblPhysicaladdress.AutoSize = True
        Me.lblPhysicaladdress.Location = New System.Drawing.Point(571, 23)
        Me.lblPhysicaladdress.Name = "lblPhysicaladdress"
        Me.lblPhysicaladdress.Size = New System.Drawing.Size(35, 15)
        Me.lblPhysicaladdress.TabIndex = 1
        Me.lblPhysicaladdress.Text = "####"
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Location = New System.Drawing.Point(571, 38)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(35, 15)
        Me.lblStreet.TabIndex = 3
        Me.lblStreet.Text = "####"
        '
        'lblpobox
        '
        Me.lblpobox.AutoSize = True
        Me.lblpobox.Location = New System.Drawing.Point(571, 53)
        Me.lblpobox.Name = "lblpobox"
        Me.lblpobox.Size = New System.Drawing.Size(42, 15)
        Me.lblpobox.TabIndex = 5
        Me.lblpobox.Text = "#####"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Project:"
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Location = New System.Drawing.Point(79, 74)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(126, 15)
        Me.lblProject.TabIndex = 7
        Me.lblProject.Text = "Last Mile Connectvity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(211, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Delivery No:"
        '
        'LblDeliveryNo
        '
        Me.LblDeliveryNo.AutoSize = True
        Me.LblDeliveryNo.Location = New System.Drawing.Point(95, 89)
        Me.LblDeliveryNo.Name = "LblDeliveryNo"
        Me.LblDeliveryNo.Size = New System.Drawing.Size(35, 15)
        Me.LblDeliveryNo.TabIndex = 11
        Me.LblDeliveryNo.Text = "####"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Location = New System.Drawing.Point(301, 89)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(70, 15)
        Me.LblTime.TabIndex = 12
        Me.LblTime.Text = "#########"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Location = New System.Drawing.Point(301, 69)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(70, 15)
        Me.LblDate.TabIndex = 13
        Me.LblDate.Text = "#########"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(211, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 15)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Time:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Scheme Name:"
        '
        'lblCreatedBy
        '
        Me.lblCreatedBy.AutoSize = True
        Me.lblCreatedBy.Location = New System.Drawing.Point(301, 104)
        Me.lblCreatedBy.Name = "lblCreatedBy"
        Me.lblCreatedBy.Size = New System.Drawing.Size(70, 15)
        Me.lblCreatedBy.TabIndex = 16
        Me.lblCreatedBy.Text = "#########"
        '
        'LblSchemeName
        '
        Me.LblSchemeName.AutoSize = True
        Me.LblSchemeName.Location = New System.Drawing.Point(95, 104)
        Me.LblSchemeName.Name = "LblSchemeName"
        Me.LblSchemeName.Size = New System.Drawing.Size(35, 15)
        Me.LblSchemeName.TabIndex = 17
        Me.LblSchemeName.Text = "####"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Item Code"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(212, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 15)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Created By#:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(719, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "UoM"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(583, 189)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 19)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Quantity"
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(29, 207)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(128, 15)
        Me.ListBox1.TabIndex = 23
        '
        'ListBox3
        '
        Me.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 15
        Me.ListBox3.Location = New System.Drawing.Point(722, 207)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(75, 15)
        Me.ListBox3.TabIndex = 25
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(212, 123)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(83, 15)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "Approved By:"
        '
        'LblApprovedBy
        '
        Me.LblApprovedBy.AutoSize = True
        Me.LblApprovedBy.Location = New System.Drawing.Point(301, 123)
        Me.LblApprovedBy.Name = "LblApprovedBy"
        Me.LblApprovedBy.Size = New System.Drawing.Size(70, 15)
        Me.LblApprovedBy.TabIndex = 49
        Me.LblApprovedBy.Text = "#########"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(211, 146)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 14)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "Total Items:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(1, 174)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(819, 15)
        Me.Label27.TabIndex = 77
        Me.Label27.Text = resources.GetString("Label27.Text")
        '
        'lblTotalItems
        '
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.Location = New System.Drawing.Point(301, 144)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(13, 15)
        Me.lblTotalItems.TabIndex = 103
        Me.lblTotalItems.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label49)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label50)
        Me.Panel2.Controls.Add(Me.Label51)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label53)
        Me.Panel2.Controls.Add(Me.Label54)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label44)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label43)
        Me.Panel2.Controls.Add(Me.Label45)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label46)
        Me.Panel2.Controls.Add(Me.Label33)
        Me.Panel2.Controls.Add(Me.Label47)
        Me.Panel2.Controls.Add(Me.Label39)
        Me.Panel2.Controls.Add(Me.Label48)
        Me.Panel2.Controls.Add(Me.Label34)
        Me.Panel2.Controls.Add(Me.Label40)
        Me.Panel2.Controls.Add(Me.Label32)
        Me.Panel2.Controls.Add(Me.Label41)
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.Label36)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Controls.Add(Me.Label38)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.lblOR)
        Me.Panel2.Controls.Add(Me.subTotal)
        Me.Panel2.Location = New System.Drawing.Point(4, 507)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 219)
        Me.Panel2.TabIndex = 80
        '
        'subTotal
        '
        Me.subTotal.AutoSize = True
        Me.subTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTotal.Location = New System.Drawing.Point(8, 16)
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Size = New System.Drawing.Size(138, 19)
        Me.subTotal.TabIndex = 93
        Me.subTotal.Text = "Created By Stores:"
        '
        'lblOR
        '
        Me.lblOR.AutoSize = True
        Me.lblOR.Location = New System.Drawing.Point(241, 200)
        Me.lblOR.Name = "lblOR"
        Me.lblOR.Size = New System.Drawing.Size(311, 15)
        Me.lblOR.TabIndex = 97
        Me.lblOR.Text = "*THIS IS THE ORIGINAL DELIVERY NOTE**********"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(138, 24)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(215, 15)
        Me.Label28.TabIndex = 112
        Me.Label28.Text = "----------------------------------------------------"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(6, 43)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(141, 19)
        Me.Label38.TabIndex = 130
        Me.Label38.Text = "Checked By PE/PS:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(140, 47)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(215, 15)
        Me.Label37.TabIndex = 131
        Me.Label37.Text = "----------------------------------------------------"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(359, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 19)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "Sign:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(361, 43)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(43, 19)
        Me.Label36.TabIndex = 132
        Me.Label36.Text = "Sign:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(395, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(207, 15)
        Me.Label29.TabIndex = 127
        Me.Label29.Text = "--------------------------------------------------"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(6, 73)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(152, 19)
        Me.Label42.TabIndex = 136
        Me.Label42.Text = "Checked by Security:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(397, 51)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(207, 15)
        Me.Label35.TabIndex = 133
        Me.Label35.Text = "--------------------------------------------------"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(140, 76)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(215, 15)
        Me.Label41.TabIndex = 137
        Me.Label41.Text = "----------------------------------------------------"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(608, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(47, 19)
        Me.Label32.TabIndex = 128
        Me.Label32.Text = "Date:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(361, 72)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(43, 19)
        Me.Label40.TabIndex = 138
        Me.Label40.Text = "Sign:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(608, 43)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 19)
        Me.Label34.TabIndex = 134
        Me.Label34.Text = "Date:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(8, 100)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(133, 19)
        Me.Label48.TabIndex = 136
        Me.Label48.Text = "Approved By CM:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(397, 77)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(211, 15)
        Me.Label39.TabIndex = 139
        Me.Label39.Text = "---------------------------------------------------"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(138, 104)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(215, 15)
        Me.Label47.TabIndex = 137
        Me.Label47.Text = "----------------------------------------------------"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(661, 24)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(131, 15)
        Me.Label33.TabIndex = 129
        Me.Label33.Text = "-------------------------------"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(361, 100)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(43, 19)
        Me.Label46.TabIndex = 138
        Me.Label46.Text = "Sign:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(608, 74)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 19)
        Me.Label19.TabIndex = 140
        Me.Label19.Text = "Date:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(397, 104)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(211, 15)
        Me.Label45.TabIndex = 139
        Me.Label45.Text = "---------------------------------------------------"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(4, 153)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(103, 19)
        Me.Label43.TabIndex = 143
        Me.Label43.Text = "Delivered By:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(666, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 15)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "------------------------------"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(134, 157)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(215, 15)
        Me.Label25.TabIndex = 144
        Me.Label25.Text = "----------------------------------------------------"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(613, 101)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(47, 19)
        Me.Label44.TabIndex = 140
        Me.Label44.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(666, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 15)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "------------------------------"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(8, 181)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(100, 19)
        Me.Label54.TabIndex = 143
        Me.Label54.Text = "Received By:"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(138, 185)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(215, 15)
        Me.Label53.TabIndex = 144
        Me.Label53.Text = "----------------------------------------------------"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(666, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(131, 15)
        Me.Label16.TabIndex = 142
        Me.Label16.Text = "-------------------------------"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 134)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(475, 19)
        Me.Label20.TabIndex = 143
        Me.Label20.Text = "I CONFIRM RECEIVING ABOVE ITEMS IN GOOD CONDITION"
        '
        'ListBox2
        '
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(586, 206)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(63, 15)
        Me.ListBox2.TabIndex = 81
        '
        'lblTelphone
        '
        Me.lblTelphone.AutoSize = True
        Me.lblTelphone.Location = New System.Drawing.Point(571, 73)
        Me.lblTelphone.Name = "lblTelphone"
        Me.lblTelphone.Size = New System.Drawing.Size(42, 15)
        Me.lblTelphone.TabIndex = 82
        Me.lblTelphone.Text = "#####"
        '
        'lblMobilephone
        '
        Me.lblMobilephone.AutoSize = True
        Me.lblMobilephone.Location = New System.Drawing.Point(571, 88)
        Me.lblMobilephone.Name = "lblMobilephone"
        Me.lblMobilephone.Size = New System.Drawing.Size(42, 15)
        Me.lblMobilephone.TabIndex = 83
        Me.lblMobilephone.Text = "#####"
        '
        'lblfax
        '
        Me.lblfax.AutoSize = True
        Me.lblfax.Location = New System.Drawing.Point(571, 103)
        Me.lblfax.Name = "lblfax"
        Me.lblfax.Size = New System.Drawing.Size(42, 15)
        Me.lblfax.TabIndex = 84
        Me.lblfax.Text = "#####"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(571, 125)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 15)
        Me.lblEmail.TabIndex = 85
        Me.lblEmail.Text = "#####"
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Location = New System.Drawing.Point(571, 143)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(42, 15)
        Me.lblWebsite.TabIndex = 86
        Me.lblWebsite.Text = "#####"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Scheme Ref#:"
        '
        'LblSchemerefNo
        '
        Me.LblSchemerefNo.AutoSize = True
        Me.LblSchemerefNo.Location = New System.Drawing.Point(95, 123)
        Me.LblSchemerefNo.Name = "LblSchemerefNo"
        Me.LblSchemerefNo.Size = New System.Drawing.Size(35, 15)
        Me.LblSchemerefNo.TabIndex = 88
        Me.LblSchemerefNo.Text = "####"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 141)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 15)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "Constituency:"
        '
        'LblConstituency
        '
        Me.LblConstituency.AutoSize = True
        Me.LblConstituency.Location = New System.Drawing.Point(95, 141)
        Me.LblConstituency.Name = "LblConstituency"
        Me.LblConstituency.Size = New System.Drawing.Size(35, 15)
        Me.LblConstituency.TabIndex = 90
        Me.LblConstituency.Text = "####"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(9, 159)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(50, 15)
        Me.Label30.TabIndex = 91
        Me.Label30.Text = "County:"
        '
        'LblCounty
        '
        Me.LblCounty.AutoSize = True
        Me.LblCounty.Location = New System.Drawing.Point(93, 161)
        Me.LblCounty.Name = "LblCounty"
        Me.LblCounty.Size = New System.Drawing.Size(35, 15)
        Me.LblCounty.TabIndex = 92
        Me.LblCounty.Text = "####"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(198, 189)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(121, 19)
        Me.Label31.TabIndex = 93
        Me.Label31.Text = "Item Description"
        '
        'ListBox4
        '
        Me.ListBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.IntegralHeight = False
        Me.ListBox4.ItemHeight = 15
        Me.ListBox4.Location = New System.Drawing.Point(201, 207)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(128, 15)
        Me.ListBox4.TabIndex = 94
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 19)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "MATERIAL DELIVERY"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LblSessionNo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ListBox4)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.LblCounty)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.LblConstituency)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.LblSchemerefNo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblWebsite)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblfax)
        Me.Panel1.Controls.Add(Me.lblMobilephone)
        Me.Panel1.Controls.Add(Me.lblTelphone)
        Me.Panel1.Controls.Add(Me.ListBox2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblTotalItems)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.LblApprovedBy)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.ListBox3)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.LblSchemeName)
        Me.Panel1.Controls.Add(Me.lblCreatedBy)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.LblDate)
        Me.Panel1.Controls.Add(Me.LblTime)
        Me.Panel1.Controls.Add(Me.LblDeliveryNo)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblProject)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblpobox)
        Me.Panel1.Controls.Add(Me.lblStreet)
        Me.Panel1.Controls.Add(Me.lblPhysicaladdress)
        Me.Panel1.Controls.Add(Me.LblCName)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 730)
        Me.Panel1.TabIndex = 0
        '
        'LblSessionNo
        '
        Me.LblSessionNo.AutoSize = True
        Me.LblSessionNo.Location = New System.Drawing.Point(301, 159)
        Me.LblSessionNo.Name = "LblSessionNo"
        Me.LblSessionNo.Size = New System.Drawing.Size(70, 15)
        Me.LblSessionNo.TabIndex = 104
        Me.LblSessionNo.Text = "#########"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(666, 162)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 15)
        Me.Label14.TabIndex = 146
        Me.Label14.Text = "-------------------------------"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(613, 158)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 19)
        Me.Label21.TabIndex = 145
        Me.Label21.Text = "Date:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(397, 161)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(211, 15)
        Me.Label22.TabIndex = 144
        Me.Label22.Text = "---------------------------------------------------"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(361, 157)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 19)
        Me.Label23.TabIndex = 143
        Me.Label23.Text = "Sign:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(666, 185)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(131, 15)
        Me.Label24.TabIndex = 146
        Me.Label24.Text = "-------------------------------"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(613, 181)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(47, 19)
        Me.Label49.TabIndex = 145
        Me.Label49.Text = "Date:"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(397, 184)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(211, 15)
        Me.Label50.TabIndex = 144
        Me.Label50.Text = "---------------------------------------------------"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(361, 180)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(43, 19)
        Me.Label51.TabIndex = 143
        Me.Label51.Text = "Sign:"
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(814, 728)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPrint"
        Me.Text = "Print"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Label31 As Label
    Friend WithEvents LblCounty As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents LblConstituency As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents LblSchemerefNo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblWebsite As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblfax As Label
    Friend WithEvents lblMobilephone As Label
    Friend WithEvents lblTelphone As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblOR As Label
    Friend WithEvents subTotal As Label
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents LblApprovedBy As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblSchemeName As Label
    Friend WithEvents lblCreatedBy As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents LblTime As Label
    Friend WithEvents LblDeliveryNo As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblProject As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblpobox As Label
    Friend WithEvents lblStreet As Label
    Friend WithEvents lblPhysicaladdress As Label
    Friend WithEvents LblCName As Label
    Friend WithEvents LblSessionNo As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
End Class
