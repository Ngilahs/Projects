Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports Microsoft.PointOfService
Imports System.Globalization
Imports System.IO
Public Class frmPrintProduct
    Dim TextToPrint As String = ""
    Public Sub PrintHeader()
        'Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
        'conn.Open()
        Try
            sqL = "SELECT companydetailsID, ParentCoName, CompanyName, TelephoneNo, Email, VATNo, PINNo, Address, City, PostalCode, MpesaTillNo FROM companydetails"
            'cmd = New MySqlCommand(sqL, conn)
            'dr = cmd.ExecuteReader()
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                TextToPrint = ""
                'send Business Name 
                Dim StringToPrint As String = ""
                Dim LineLen As Integer = StringToPrint.Length
                Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
                TextToPrint &= dr("CompanyName") & Environment.NewLine
                'TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine

                'send address name
                StringToPrint = ""
                LineLen = StringToPrint.Length
                Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 2))
                TextToPrint &= dr("Address") & Environment.NewLine
                'TextToPrint &= spcLen2 & StringToPrint & Environment.NewLine

                ' send TelephoneNo
                StringToPrint = ""
                LineLen = StringToPrint.Length
                Dim spcLen3 As New String(" "c, Math.Round((33 - LineLen) / 2))
                TextToPrint &= "MobileNo:" & dr("TelephoneNo") & Environment.NewLine
                'TextToPrint &= spcLen3 & StringToPrint & Environment.NewLine

                ' send Mpesa Till Number
                StringToPrint = ""
                LineLen = StringToPrint.Length
                Dim spcLen4 As New String(" "c, Math.Round((33 - LineLen) / 2))
                TextToPrint &= "MpesaTillNo:" & dr("MpesaTillNo") & Environment.NewLine
                'TextToPrint &= spcLen4 & StringToPrint & Environment.NewLine

                'send PINNo
                StringToPrint = ""
                LineLen = StringToPrint.Length
                Dim spcLen4b As New String(" "c, Math.Round((33 - LineLen) / 2))
                TextToPrint &= "PINNo:" & dr("PINNo") & Environment.NewLine
                'TextToPrint &= spcLen4b & StringToPrint & Environment.NewLine
                'conn.Close()

                'send Date & Time
                StringToPrint = ""
                LineLen = StringToPrint.Length
                Dim spcLen5 As New String(" "c, Math.Round((33 - LineLen) / 2))
                'TextToPrint &= spcLen5 & StringToPrint & Environment.NewLine
                TextToPrint &= "Date:" & Date.Now.ToString("MM/dd/yyyy") & "Time:" & Date.Now.ToString("hh:mm:ss") & Environment.NewLine
                'TextToPrint &= spcLen5 & StringToPrint & Environment.NewLine

                'send Transaction No & Receipt No
                StringToPrint = " "
                LineLen = StringToPrint.Length
                Dim spcLen6 As New String(" "c, Math.Round((33 - LineLen) / 2))
                'TextToPrint &= spcLen5 & StringToPrint & Environment.NewLine
                TextToPrint &= "Trans#: " & FrmPointofSale.LblDeliveryNo.Text & " " & "Recpt#: " & frmPayment.txtreceiptno.Text & Environment.NewLine
                'TextToPrint &= spcLen6 & StringToPrint & Environment.NewLine

                'send Till No
                StringToPrint = " "
                LineLen = StringToPrint.Length
                Dim spcLen7 As New String(" "c, Math.Round((33 - LineLen) / 2))
                'TextToPrint &= spcLen5 & StringToPrint & Environment.NewLine
                TextToPrint &= "Till No:" & FrmMain.LBLComputerName.Text & Environment.NewLine
                'TextToPrint &= spcLen7 & StringToPrint & Environment.NewLine

                'Draw Line
                StringToPrint = " "
                LineLen = StringToPrint.Length
                'Dim spcLen7 As New String(" "c, Math.Round((33 - LineLen) / 2))
                'TextToPrint &= spcLen5 & StringToPrint & Environment.NewLine
                TextToPrint &= "--------------------------------------------------------" & Environment.NewLine
                'TextToPrint &= spcLen7 & StringToPrint & Environment.NewLine

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Public Sub ItemsToBePrinted()
        'Dim cont As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
        'cont.Open()
        Try
            sqL = "Select  SD.ItemBarcode, P.Description, SD.TransQTY, P.Selling_Price, CONCAT(SD.Subtotal,' ',SD.VatCode) AS Subtotal FROM sales_details SD inner join product P on (P.ProductNo = SD.ItemBarcode) WHERE TransID = '" & FrmPointofSale.LblDeliveryNo.Text & "'"
            'cmd = New MySqlCommand(sqL, cont)
            'dr = cmd.ExecuteReader
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            Dim StringToPrint As String = ""
            Dim LineLen As String = StringToPrint.Length
            Dim spcLen8 As New String(" "c, Math.Round((33 - LineLen) / 2))
            TextToPrint &= "Item       " & " " & "Qty" & "  " & "    " & "Amount" & Environment.NewLine
            'Draw Line
            StringToPrint = " "
            LineLen = StringToPrint.Length
            'Dim spcLen7 As New String(" "c, Math.Round((33 - LineLen) / 2))
            'TextToPrint &= spcLen5 & StringToPrint & Environment.NewLine
            TextToPrint &= "--------------------------------" & Environment.NewLine
            'TextToPrint &= spcLen7 & StringToPrint & Environment.NewLine
            Do While dr.Read = True
                TextToPrint &= dr("ItemBarcode") & "        " & dr("TransQTY") & "        " & dr("Selling_Price") & Environment.NewLine
                TextToPrint &= dr("Description") & dr("Subtotal") & Environment.NewLine
                TextToPrint &= StringToPrint & Environment.NewLine
            Loop
            'cont.Close()
            'Draw Line
            StringToPrint = " "
            LineLen = StringToPrint.Length
            'Dim spcLen7 As New String(" "c, Math.Round((33 - LineLen) / 2))
            'TextToPrint &= spcLen5 & StringToPrint & Environment.NewLine
            TextToPrint &= "--------------------------------" & Environment.NewLine
            'TextToPrint &= spcLen7 & StringToPrint & Environment.NewLine
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Sub printFooter()
        'Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
        'conn.Open()
        Try
            sqL = "SELECT TransID, TOTALPRICE, TENDEREDAMOUNT, CHANGEAMOUNT, VATABLEAMT, VAT, ITEMCOUNT, RECEIPTNO, PaymentOption, Customer, SessIDNo FROM s_payment WHERE TransID = '" & FrmPointofSale.LblDeliveryNo.Text & "' "
            'cmd = New MySqlCommand(sqL, conn)
            'dr = cmd.ExecuteReader()
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then

                TextToPrint &= Environment.NewLine & Environment.NewLine
                Dim globalLengt As Integer = 0

                'SubTotal Amount
                'Dim StringToPrint As String = "Sub Total:          " & FormatCurrency(dr("TOTALPRICE"), , , TriState.True, TriState.True)  'Change here to subtotal
                'Dim LineLen As String = StringToPrint.Length
                'globalLengt = StringToPrint.Length
                'Dim spcLen9 As New String(" "c, Math.Round((33 - LineLen)))
                'TextToPrint &= Environment.NewLine & spcLen9 & StringToPrint & Environment.NewLine

                Dim StringToPrint As String = ""
                Dim LineLen As String = StringToPrint.Length
                Dim spcLen9 As New String(" "c, Math.Round((33 - LineLen) / 2))
                TextToPrint &= "Sub Total:" & "           " & dr("TOTALPRICE") & Environment.NewLine
                'TextToPrint &= spcLen9 & StringToPrint & Environment.NewLine

                'Tendered(Amount)
                'StringToPrint = "Tendered         " & FormatCurrency(dr("TENDEREDAMOUNT"), , , TriState.True, TriState.True)  'Change here to subtotal
                'LineLen = StringToPrint.Length
                'globalLengt = StringToPrint.Length
                'Dim spcLen10 As New String(" "c, Math.Round((33 - LineLen)))
                'TextToPrint &= Environment.NewLine & spcLen10 & StringToPrint & Environment.NewLine

                StringToPrint = ""
                LineLen = StringToPrint.Length
                Dim spcLen10 As New String(" "c, Math.Round((33 - LineLen) / 2))
                TextToPrint &= "Tendered:" & "             " & dr("TENDEREDAMOUNT") & Environment.NewLine
                'TextToPrint &= spcLen10 & StringToPrint & Environment.NewLine

                'Change Amount
                'StringToPrint = "Change   " & FormatCurrency(dr("CHANGEAMOUNT"), , , TriState.True, TriState.True)  'Change here to subtotal
                'LineLen = StringToPrint.Length
                'globalLengt = StringToPrint.Length
                'Dim spcLen11 As New String(" "c, Math.Round((33 - LineLen)))
                'TextToPrint &= Environment.NewLine & spcLen11 & StringToPrint & Environment.NewLine

                StringToPrint = ""
                LineLen = StringToPrint.Length
                Dim spcLen11 As New String(" "c, Math.Round((33 - LineLen) / 2))
                TextToPrint &= "Change:" & "                 " & dr("CHANGEAMOUNT") & Environment.NewLine
                'TextToPrint &= spcLen11 & StringToPrint & Environment.NewLine

                'Draw Line
                StringToPrint = " "
                LineLen = StringToPrint.Length
                'Dim spcLen7 As New String(" "c, Math.Round((33 - LineLen) / 2))
                'TextToPrint &= spcLen5 & StringToPrint & Environment.NewLine
                TextToPrint &= "--------------------------------" & Environment.NewLine
                'TextToPrint &= spcLen7 & StringToPrint & Environment.NewLine

                'Item Count
                StringToPrint = " "
                LineLen = globalLengt
                Dim spcLen12 As New String(" "c, Math.Round((33 - LineLen)))
                TextToPrint &= "Total Items " & dr("ITEMCOUNT") & Environment.NewLine
                'TextToPrint &= spcLen12 & StringToPrint & Environment.NewLine

                'Vat Declaration
                StringToPrint = " "
                LineLen = globalLengt
                Dim spcLen13 As New String(" "c, Math.Round((33 - LineLen)))
                TextToPrint &= "Prices Inclusive of Taxes Where Applicable" & Environment.NewLine
                'TextToPrint &= spcLen13 & StringToPrint & Environment.NewLine

                'Vat Calculation VATABLEAMT, VAT
                StringToPrint = " "
                LineLen = globalLengt
                Dim spcLen14 As New String(" "c, Math.Round((33 - LineLen)))
                TextToPrint &= "Code" & " " & "Rate" & " " & "VatableAmt" & " " & "Vat" & Environment.NewLine
                TextToPrint &= "A" & "    " & "16%" & "   " & dr("VATABLEAMT") & "   " & dr("VAT") & Environment.NewLine
                'TextToPrint &= StringToPrint & Environment.NewLine

                'Send Customer & Till No
                StringToPrint = " "
                LineLen = globalLengt
                Dim spcLen15 As New String(" "c, Math.Round((33 - LineLen)))
                TextToPrint &= "Cust:  " & dr("Customer") & Environment.NewLine
                'TextToPrint &= spcLen15 & StringToPrint & Environment.NewLine


                'Served By
                StringToPrint = " "
                LineLen = globalLengt
                Dim spcLen16 As New String(" "c, Math.Round((33 - LineLen)))
                TextToPrint &= "Served By:  " & FrmMain.tsslUser.Text & Environment.NewLine
                'TextToPrint &= Environment.NewLine & spcLen16 & StringToPrint & Environment.NewLine

                'Message
                StringToPrint = " "
                LineLen = globalLengt
                Dim spcLen17 As New String(" "c, Math.Round((33 - LineLen)))
                TextToPrint &= "Thank You Come Again!" & Environment.NewLine
                'TextToPrint &= Environment.NewLine & spcLen17 & StringToPrint & Environment.NewLine

                'Receipt End
                StringToPrint = " "
                LineLen = globalLengt
                Dim spcLen18 As New String(" "c, Math.Round((33 - LineLen)))
                TextToPrint &= "THIS IS END OF LEGAL RECEIPT" & Environment.NewLine
                'TextToPrint &= spcLen18 & StringToPrint & Environment.NewLine
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub PrintDocument3_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        Static currentChar As Integer
        Dim textfont As Font = New Font("Courier New", 10, FontStyle.Bold)
        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument3.DefaultPageSettings
            h = 0
            w = 0
            left = 0
            top = 0
        End With
        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer


        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, b, format)


        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub
    Private Sub frmPrintReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintDocument3.PrinterSettings.PrinterName = "E-PoS 76mm Impact Dot Matrix Printer"
        PrintHeader()
        ItemsToBePrinted()
        printFooter()
        PrintDocument3.Print()
        Me.Close()
    End Sub

    
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'frmPrintProduct
        '
        Me.ClientSize = New System.Drawing.Size(222, 381)
        Me.Name = "frmPrintProduct"
        Me.ResumeLayout(False)

    End Sub
End Class

