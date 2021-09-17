Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration

Public Class RPTPayments
    Public Sub Populatelistview()
        Try
            
            sqL = "SELECT Pay_ID, ExpStk_ID, SuppExp_Name, Pay_Date, Pay_Amt, Amount_Paid, Balance_Amt, PayVia FROM pay_suppexpense Where Pay_Date BETWEEN @dt1 AND @dt2 ORDER BY Pay_Date"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@dt1", DateTimePickerFrom.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dt2", DateTimePickerTo.Value.ToString("MM/dd/yyyy"))
            dr = cmd.ExecuteReader
            'Where Pay_Date BETWEEN @dt1 AND @dt2
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("Pay_ID").ToString)
                x.SubItems.Add(dr("ExpStk_ID").ToString)
                x.SubItems.Add(dr("SuppExp_Name").ToString)
                x.SubItems.Add(dr("Pay_Date").ToString)
                x.SubItems.Add(dr("Pay_Amt").ToString)
                x.SubItems.Add(dr("Amount_Paid").ToString)
                x.SubItems.Add(dr("Balance_Amt").ToString)
                x.SubItems.Add(dr("PayVia").ToString)

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Sum  Expenses
        Dim dblTotal As Decimal = 0
        Dim dblTemp As Decimal
        For Each lvItem As ListViewItem In ListView1.Items
            If Decimal.TryParse(lvItem.SubItems(5).Text, dblTemp) Then
                dblTotal += dblTemp
            End If
        Next
        txtAmtPay.Text = dblTotal

    End Sub

    Private Sub btnPrintreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintreport.Click
        Populatelistview()
        Dim Ds5 As New DataSet5
        Dim drow As DataRow
        Dim i As Integer

        For i = 0 To ListView1.Items.Count - 1
            drow = Ds5.Tables("PaymentsdataTable").NewRow()
            drow("PayRefID") = ListView1.Items(i).Text
            drow("ExpStockRefID") = ListView1.Items(i).SubItems(1).Text
            drow("EntyExpname") = ListView1.Items(i).SubItems(2).Text
            drow("PayDate") = ListView1.Items(i).SubItems(3).Text
            drow("Amounttopay") = ListView1.Items(i).SubItems(4).Text
            drow("Amtpaid") = ListView1.Items(i).SubItems(5).Text
            drow("Bal") = ListView1.Items(i).SubItems(6).Text
            drow("Paidvia") = ListView1.Items(i).SubItems(7).Text
            Ds5.Tables("PaymentsdataTable").Rows.Add(drow)
        Next i
        Dim freport As New RPTPayments
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "RPTPayments.rdlc")
        ''Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\Administrator\Documents\Visual Studio 2010\Projects\POS\POS\RPTPayments.rdlc"
        'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\julius pc\Documents\Visual Studio 2010\Projects\POS1\POS\RPTPayments.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet5", Ds5.Tables("PaymentsdataTable")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        'Me.ShowDialog()
    End Sub

    Private Sub RPTPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub RPTPayments_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    
End Class