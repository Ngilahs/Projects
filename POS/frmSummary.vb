Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmSummary
    Public Sub Populatelistview()
        Try
            Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
            conn.Open()
            sqL = "SELECT SD.Item_ID, SD.Item_Description, SD.Item_QTY, SD.Item_Price, SD.Total_Price, SS.salesdate, PS.Pay_ID, PS.SuppExp_Name, PS.Pay_Amt, PS.Pay_Date FROM sales_details SD, sales_sold SS, pay_suppexpense PS WHERE Pay_Date, salesdate BETWEEN @dt1 AND @dt2 GROUP BY Item_ID, SuppExp_Name"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@dt1", DateTimePicker1.Value)
            cmd.Parameters.AddWithValue("@dt2", DateTimePicker2.Value)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("Item_ID").ToString)
                x.SubItems.Add(dr("Item_Description").ToString)
                x.SubItems.Add(dr("Item_QTY").ToString)
                x.SubItems.Add(dr("Item_Price").ToString)
                x.SubItems.Add(dr("Total_Price").ToString)
                'x.SubItems.Add(dr("salesdate").ToString)
                x.SubItems.Add(dr("Pay_ID").ToString)
                x.SubItems.Add(dr("SuppExp_Name").ToString)
                x.SubItems.Add(dr("Pay_Amt").ToString)
                'x.SubItems.Add(dr("Pay_Date").ToString)

                ListView1.Items.Add(x)
            Loop
            'Sum  Expenses
            Dim dblTotal As Decimal = 0
            Dim dblTemp As Decimal
            For Each lvItem As ListViewItem In ListView1.Items
                If Decimal.TryParse(lvItem.SubItems(4).Text, dblTemp) Then
                    dblTotal += dblTemp
                End If
            Next
            TotAmtSales.Text = dblTotal
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class