Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class frmProfitLossAccount
    Dim y As Integer
    Private Sub SalesSummary()
        Try
            sqL = "Select RECEIPTNO, TRANSDATE, TOTALPRICE, MkUp, VAT FROM s_payment WHERE TRANSDATE BETWEEN @dt1 AND @dt2 ORDER BY TRANSDATE"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@dt1", DateTimePickerFrom.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dt2", DateTimePickerTo.Value.ToString("MM/dd/yyyy"))
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("RECEIPTNO"), dr("TRANSDATE"), dr("TOTALPRICE"), dr("MkUp"), dr("VAT"))
                y += 17
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub ExpenseSummary()
        Try
            sqL = "SELECT ExpenseID, Expense_Name, PaymentDate, Amount_Paid, Person_paid from expense_details WHERE PaymentDate BETWEEN @dt1 AND @dt2 ORDER BY PaymentDate"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@dt1", DateTimePickerFrom.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dt2", DateTimePickerTo.Value.ToString("MM/dd/yyyy"))
            dr = cmd.ExecuteReader
            dgw1.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw1.Rows.Add(dr("ExpenseID"), dr("Expense_Name"), dr("PaymentDate"), dr("Person_paid"), dr("Amount_Paid"))
                y += 17
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    'Private Sub GetStockpurchased()
    '    Try
    '        Dim con As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
    '        con.Open()
    '        sqls = "SELECT StockInDetailID, DateIn, Supplier_Name, ModeofPurch, TotalItem_Price FROM stockindetails WHERE DateIn BETWEEN @dt1 AND @dt2 ORDER BY DateIn"
    '        cmds = New MySqlCommand(sqls, con)
    '        cmds.Parameters.AddWithValue("@dt1", DateTimePickerFrom.Value.ToString("MM/dd/yyyy"))
    '        cmds.Parameters.AddWithValue("@dt2", DateTimePickerTo.Value.ToString("MM/dd/yyyy"))
    '        drs = cmds.ExecuteReader
    '        dgw2.Rows.Clear()
    '        y = 0
    '        Do While drs.Read = True
    '            dgw2.Rows.Add(drs(0), drs(1), drs(2), drs(3), drs(4))
    '            y += 17
    '        Loop
    '        con.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '    End Try
    'End Sub
    Private Sub calcTotSales()
        Dim totAmt As Decimal
        Dim Vat As Decimal
        Dim Markup As Decimal
        'Calculate total markup amount
        For i = 0 To dgw.Rows.Count - 1
            totAmt += dgw.Rows(i).Cells(2).Value
            Markup += dgw.Rows(i).Cells(3).Value
            Vat += dgw.Rows(i).Cells(4).Value
        Next
        LBLTotSales.Text = Format(totAmt, "#,##0.00")
        LBLTotVat.Text = Format(Vat, "#,##0.00")
        LBLMkup.Text = Format(Markup, "#,##0.00")
    End Sub
    Private Sub calcTotalExp()
        Dim totExpenes As Decimal
        'Calculate total markup amount
        For i = 0 To dgw1.Rows.Count - 1
            totExpenes += dgw1.Rows(i).Cells(4).Value
        Next
        LBLTotExpenses.Text = Format(totExpenes, "#,##0.00")
    End Sub
    Private Sub btnPrintreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintreport.Click
        SalesSummary()
        ExpenseSummary()
        'GetOpeningandClosingStock()
        'GetStockSummary()
        calcTotSales()
        calcTotalExp()
        'EqualizeAll()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = dgw1.RowCount
            colsTotal = dgw1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dgw1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dgw1.Rows(I).Cells(j).Value
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dgw.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Click Button to Load Sales, Expenses and Purchases ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'If TxtOpeningStock.Text = "" Or TxtClosingStock.Text = "" Or txtDiscountscommissions.Text = "" Then
        '    MsgBox("Enter Opening Stock, Closing Stock and Dicount/Commissions")
        '    Exit Sub
        'Else
        'frmProfitLoss.Show()
        'End If

    End Sub
   
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If dgw.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Click Button to Load Sales, Expenses and Purchases ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'If TxtOpeningStock.Text = "" Or TxtClosingStock.Text = "" Or txtDiscountscommissions.Text = "" Then
        '    MsgBox("Enter Opening Stock, Closing Stock and Dicount/Commissions")
        '    Exit Sub
        'Else
        'frmProfitLoss.Show()
        'End If
    End Sub

    Private Sub frmProfitLossAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDiscountscommissions.Text = "0.00"

    End Sub

    Private Sub LoadStockSummary()
        Dim TotalStockCost As Decimal
        Dim TotalStockandVAT As Decimal
        ''For i = 0 To dgwStkSummary.Rows.Count - 1
        ''    TotalStockCost += dgwStkSummary.Rows(i).Cells(4).Value
        ''    TotalStockandVAT += dgwStkSummary.Rows(i).Cells(5).Value
        ''    'vat += dgw.Rows(i).Cells(9).Value
        ''Next
        ''LBLTotalStockCost.Text = Format(TotalStockCost, "#,##0.00")
        ''LBLTotCostVAT.Text = Format(TotalStockandVAT, "#,##0.00")
        ' ''LBLVat.Text = Format(vat, "#,##0.00")
    End Sub
   
   
End Class