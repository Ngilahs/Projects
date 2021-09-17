Option Explicit On
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.Configuration
Module ModuleAudittrail
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String

    Public Sub Audit_Trail(ByVal user_ID As String, ByVal Record_ID As String, ByVal xtime As String, ByVal xAction As String)
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO audittrail (User_ID, Record_ID, Action, Date, Timex, log_ID) VALUES ('" & user_ID & "', '" & Record_ID & "', '" & xAction & "', '" & Format(Now, "MM/dd/yyyy") & "', '" & xtime & "', '" & LOGID & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub POSVoid_Items(ByVal Trans_ID As Integer, ByVal user_ID As String, ByVal Barcode As String, ByVal Quantity As Decimal, ByVal xtime As String)
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO void_items (TransID, User_ID, ItemBarcode, VoidQty, TransDate, Timex, void_itemId) VALUES ('" & Trans_ID & "', '" & user_ID & "', '" & Barcode & "', '" & Quantity & "', '" & Format(Now, "MM/dd/yyyy") & "', '" & xtime & "', '" & LOGID & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub SaveUnclearedPurchase(ByVal StockIn_ID As Integer, ByVal PBcode As String, ByVal Desc As String, ByVal Qty As Decimal, ByVal TotAmt As Decimal, ByVal vat As Decimal, ByVal Mkp As Decimal, ByVal BuyPrc As Decimal, ByVal SellPrc As Decimal, ByVal QttyBal As Decimal, ByVal TotQty As Decimal, ByVal AvergPrc As Decimal, ByVal P_NO As Integer, ByVal UCPID As Integer)
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "INSERT INTO tempheldpurchases (StockInID, ProductBarcode, Description, Quantity, TotalItem_Price, VAT, Markup, BPrc, SPrc, QtyBal, TQty, AvgPrc, unclearedpurchaseID, PNO, UCTID) " &
                         " VALUES ('" & StockIn_ID & "', '" & PBcode & "', '" & Desc & "', '" & Qty &
                         "','" & TotAmt & "', '" & vat & "', '" & Mkp & "', '" & BuyPrc & "', '" & SellPrc & "', '" & QttyBal & "', '" & TotQty & "', '" & AvergPrc & "', '" & LOGID & "', '" & P_NO & "', '" & UCPID & "')"

            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
        MessageBox.Show(ex.Message)
        Finally
        MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub SaveinUnclearedTransTabless(ByVal Trans_ID As Integer, ByVal ItemBcode As String, ByVal TransQtyy As Decimal, ByVal SubTot As Decimal, ByVal RemmQtyy As Decimal, ByVal MkkUp As Decimal, ByVal Descrp As String, ByVal VATT As String, ByVal Prc As Decimal, ByVal Pno As Decimal)
        Try
            sqL = "INSERT INTO tempunclearedsale (TransID, ItemBarcode, TransQTY, Subtotal, RemQty, Mkup, Description, VAT, Price, PNO) VALUES (" & Trans_ID & ",'" & ItemBcode & "', '" & TransQtyy & "', '" & SubTot & "', '" & RemmQtyy & "', '" & MkkUp & "', '" & Descrp & "', '" & VATT & "', '" & Prc & "', '" & Pno & "')"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Public Sub SaveClosingOpeningBalance(ByVal StockSumm_ID As Integer, ByVal OpenStck As Decimal, ByVal ClosingStck As Decimal, ByVal OpnClsMonth As String)
        Try
            sqL = "INSERT INTO stocksummary (StockSummaryID, OpeningStock, OpeningDate, ClosingStock, Month) VALUES (" & StockSumm_ID & ",'" & OpenStck & "', '" & Format(Now, "MM/dd/yyyy") & "', '" & ClosingStck & "', '" & OpnClsMonth & "')"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Public Function Encrypted(ByVal password As String) As String
        Dim strmsg As String = String.Empty
        Dim encode As Byte() = New Byte(password.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(password)
        strmsg = Convert.ToBase64String(encode)
        Return strmsg
    End Function
    Public Function Encrypt(ByVal password As String) As String
        Dim strmsg As String = String.Empty
        Dim encode As Byte() = New Byte(password.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(password)
        strmsg = Convert.ToBase64String(encode)
        Return strmsg
    End Function
    Public Function Decrypt(ByVal encryptpwd As String) As String
        Dim decryptpwd As String = String.Empty
        Dim encodepwd As New UTF8Encoding()
        Dim Decode As Decoder = encodepwd.GetDecoder()
        Dim todecode_byte As Byte() = Convert.FromBase64String(encryptpwd)
        Dim charCount As Integer = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)
        Dim decoded_char As Char() = New Char(charCount - 1) {}
        Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0)
        decryptpwd = New [String](decoded_char)
        Return decryptpwd
    End Function
   

End Module