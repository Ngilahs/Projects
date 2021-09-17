Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Public Class frmCashSales
    Dim y As Integer
    Private Sub calcMarkUp()
        Dim tot As Decimal
        Dim amt As Decimal
        Dim vat As Decimal
        'Calculate total markup amount
        For i = 0 To dgw.Rows.Count - 1
            tot += dgw.Rows(i).Cells(5).Value
            amt += dgw.Rows(i).Cells(3).Value
            vat += dgw.Rows(i).Cells(6).Value
        Next
        LBLMarkup1.Text = Format(tot, "#,##0.00")
        LBlAmt1.Text = Format(amt, "#,##0.00")
        LBLVat1.Text = Format(vat, "#,##0.00")
    End Sub
    Private Sub clearall()
        LBLMarkup1.Text = ""
        LBlAmt1.Text = ""
        LBLVat1.Text = ""
        dgw.Rows.Clear()
        txtsearchsname1.Text = ""
        txtReceiptNo1.Text = ""
        txtTotalAmt1.Text = ""
        'txtTillNo.Text = ""
    End Sub
    Private Sub frmListofCreditSales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub txtsearchsname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearchsname1.TextChanged
        Try

            sqL = "Select TransID, RECEIPTNO, TRANSDATE, TOTALPRICE, TENDEREDAMOUNT, CHANGEAMOUNT, MkUp, AMTTOCALCVAT, VATABLEAMT, VAT, ITEMCOUNT, TillNo, PaymentOption, Customer, UserName, SessIDNo, TimeX FROM s_payment WHERE PaymentOption = 'Cash' AND TransID LIKE '" & txtsearchsname1.Text & "%'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("TransID"), dr("RECEIPTNO"), dr("TRANSDATE"), dr("TOTALPRICE"), dr("TENDEREDAMOUNT"), dr("MkUp"), dr("VAT"), dr("ITEMCOUNT"), dr("TillNo"), dr("PaymentOption"), dr("Customer"), dr("UserName"), dr("SessIDNo"), dr("TimeX"))
                y += 17
            Loop

            calcMarkUp()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub txtReceiptNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReceiptNo1.TextChanged
        Try

            sqL = "Select TransID, RECEIPTNO, TRANSDATE, TOTALPRICE, TENDEREDAMOUNT, CHANGEAMOUNT, MkUp, AMTTOCALCVAT, VATABLEAMT, VAT, ITEMCOUNT, TillNo, PaymentOption, Customer, UserName, SessIDNo, TimeX FROM s_payment WHERE PaymentOption = 'Cash' AND RECEIPTNO LIKE '%" & txtReceiptNo1.Text & "%'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("TransID"), dr("RECEIPTNO"), dr("TRANSDATE"), dr("TOTALPRICE"), dr("TENDEREDAMOUNT"), dr("MkUp"), dr("VAT"), dr("ITEMCOUNT"), dr("TillNo"), dr("PaymentOption"), dr("Customer"), dr("UserName"), dr("SessIDNo"), dr("TimeX"))
                y += 17
            Loop

            calcMarkUp()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub txtTotalAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalAmt1.TextChanged
        Try

            sqL = "Select TransID, RECEIPTNO, TRANSDATE, TOTALPRICE, TENDEREDAMOUNT, CHANGEAMOUNT, MkUp, AMTTOCALCVAT, VATABLEAMT, VAT, ITEMCOUNT, TillNo, PaymentOption, Customer, UserName, SessIDNo, TimeX FROM s_payment WHERE PaymentOption = 'Cash' AND TOTALPRICE LIKE '%" & txtTotalAmt1.Text & "%'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("TransID"), dr("RECEIPTNO"), dr("TRANSDATE"), dr("TOTALPRICE"), dr("TENDEREDAMOUNT"), dr("MkUp"), dr("VAT"), dr("ITEMCOUNT"), dr("TillNo"), dr("PaymentOption"), dr("Customer"), dr("UserName"), dr("SessIDNo"), dr("TimeX"))
                y += 17
            Loop

            calcMarkUp()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub GetListofCreditSales()
        Try

            sqL = "Select TransID, RECEIPTNO, TRANSDATE, TOTALPRICE, TENDEREDAMOUNT, CHANGEAMOUNT, MkUp, AMTTOCALCVAT, VATABLEAMT, VAT, ITEMCOUNT, TillNo, PaymentOption, Customer, UserName, SessIDNo, TimeX FROM s_payment WHERE PaymentOption = 'Cash' AND TRANSDATE BETWEEN @dt1 AND @dt2 ORDER BY TRANSDATE"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@dt1", dtpDateFrom1.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dt2", dtpDateTo1.Value.ToString("MM/dd/yyyy"))
            dr = cmd.ExecuteReader

            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("TransID"), dr("RECEIPTNO"), dr("TRANSDATE"), dr("TOTALPRICE"), dr("TENDEREDAMOUNT"), dr("MkUp"), dr("VAT"), dr("ITEMCOUNT"), dr("TillNo"), dr("PaymentOption"), dr("Customer"), dr("UserName"), dr("SessIDNo"), dr("TimeX"))
                y += 17
            Loop

            calcMarkUp()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub btnLCSGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLCSGetData1.Click
        GetListofCreditSales()
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        clearall()
    End Sub

    Private Sub btnLCSExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLCSExportExcel.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = dgw.RowCount
            colsTotal = dgw.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dgw.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dgw.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub
    
End Class