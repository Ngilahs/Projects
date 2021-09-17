Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RPTProductwise
    Public Sub Populatelistview()
        Try
            sqL = "SELECT SD.ItemBarcode, P.Description, SUM(SD.TransQTY) as TransQTY, P.Selling_Price, SUM(SD.TransQTY * P.Selling_Price) as Total_Price, SD.TransDate FROM sales_details SD inner join product P on (SD.ItemBarcode = P.ProductNo) WHERE P.Description = @Item AND TransDate BETWEEN @dt1 AND @dt2 GROUP BY ItemBarcode"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@dt1", DateTimePicker1.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dt2", DateTimePicker2.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@Item", cbotxtItemDesc.Text.ToString)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("ItemBarcode").ToString)
                x.SubItems.Add(dr("Description").ToString)
                'x.SubItems.Add(dr("TransDate").ToString)
                x.SubItems.Add(dr("Selling_Price").ToString)
                x.SubItems.Add(dr("TransQTY").ToString)
                x.SubItems.Add(Format(dr("Total_Price"), "#,##0.00").ToString)

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Sum  daily sales
        Dim dblTotal As Decimal = 0
        Dim dblTemp As Decimal
        For Each lvItem As ListViewItem In ListView1.Items
            If Decimal.TryParse(lvItem.SubItems(4).Text, dblTemp) Then
                dblTotal += dblTemp
            End If
        Next
        txtSumTotalAmt2.Text = dblTotal

        'calculate quantity of items sold

        Dim dblTotals As Double = 0
        Dim dblTemps As Double
        For Each lvItem As ListViewItem In ListView1.Items
            If Double.TryParse(lvItem.SubItems(3).Text, dblTemps) Then
                dblTotals += dblTemps
            End If
        Next
        txtQtysold2.Text = dblTotals
    End Sub
    Private Sub populateproducts()
        Try
            sqL = "SELECT ProductNo, Description From product Order by ProductNo"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            cbotxtItemDesc.Items.Clear()
            Do While dr.Read = True
                cbotxtItemDesc.Items.Add(dr("Description"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub RPTProductwise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
        populateproducts()
    End Sub
    Private Sub RPTProductwise_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub BtnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowReport.Click
        Populatelistview()
        If cbotxtItemDesc.Text = "" Then
            MsgBox("Enter Product Name")
            Exit Sub
        End If
        Dim Ds2 As New DataSet2
        Dim drow As DataRow
        Dim i As Integer

        For i = 0 To ListView1.Items.Count - 1
            drow = Ds2.Tables("DataTableProductsales").NewRow()
            drow("ItemCode") = ListView1.Items(i).Text
            drow("ItemDesc") = ListView1.Items(i).SubItems(1).Text
            drow("ItemPrice") = ListView1.Items(i).SubItems(2).Text
            drow("Qty") = ListView1.Items(i).SubItems(3).Text
            drow("Amount") = ListView1.Items(i).SubItems(4).Text
            Ds2.Tables("DataTableProductsales").Rows.Add(drow)
        Next i
        Dim freport As New RPTProductwise
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "RptProductWise.rdlc")
        'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\Administrator\Documents\Visual Studio 2010\Projects\POS\POS\RptProductWise.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", Ds2.Tables("DataTableProductsales")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        'Me.ShowDialog()
    End Sub



End Class