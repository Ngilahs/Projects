Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RPTProductHistory
   
    Public Sub Populatelistview()
        Try
            sqL = "SELECT S.PNO, P.Description, S.Supplier_Name, S.DateIN, S.Quantity, S.TotalItem_Price FROM product P INNER JOIN stockIn S ON (S.PNO = P.ProductNo)  WHERE Description = @Item AND DateIN BETWEEN @dt1 AND @dt2"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@dt1", DateTimePicker1.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dt2", DateTimePicker2.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@Item", cbotxtItemDescs.Text.ToString)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("PNO").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("Supplier_Name").ToString)
                x.SubItems.Add(dr("DateIN").ToString)
                x.SubItems.Add(dr("Quantity").ToString)
                x.SubItems.Add(Format(dr("TotalItem_Price"), "#,##0.00"))
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Sum  stock purchased
        Dim dblTotal As Decimal = 0
        Dim dblTemp As Decimal
        For Each lvItem As ListViewItem In ListView1.Items
            If Decimal.TryParse(lvItem.SubItems(5).Text, dblTemp) Then
                dblTotal += dblTemp
            End If
        Next
        txtTAmt.Text = dblTotal

        'calculate quantity of items sold

        Dim dblTotals As Double = 0
        Dim dblTemps As Double
        For Each lvItem As ListViewItem In ListView1.Items
            If Double.TryParse(lvItem.SubItems(4).Text, dblTemps) Then
                dblTotals += dblTemps
            End If
        Next
        txtQntySold.Text = dblTotals
    End Sub
    Private Sub populateproducts()
        Try
            sqL = "SELECT ProductNo, Description From product Order by ProductNo"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            cbotxtItemDescs.Items.Clear()
            Do While dr.Read = True
                cbotxtItemDescs.Items.Add(dr("Description"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub btnPrintreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintreport.Click
        Populatelistview()
        If cbotxtItemDescs.Text = "" Then
            MsgBox("Enter Product Name")
        Else
            Dim Ds3 As New DataSet3
            Dim drow As DataRow
            Dim i As Integer

            For i = 0 To ListView1.Items.Count - 1
                drow = Ds3.Tables("DataTableStockIn").NewRow()
                drow("ProCode") = ListView1.Items(i).Text
                drow("ProductName") = ListView1.Items(i).SubItems(1).Text
                drow("SupplierName") = ListView1.Items(i).SubItems(2).Text
                drow("DateIn") = ListView1.Items(i).SubItems(3).Text
                drow("QuantityIn") = ListView1.Items(i).SubItems(4).Text
                drow("Amount") = ListView1.Items(i).SubItems(5).Text

                Ds3.Tables("DataTableStockIn").Rows.Add(drow)
            Next i
            Dim freport As New RPTProductwise
            Me.ReportViewer1.Reset()
            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Dim exeFolder As String = Application.StartupPath
            Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "RptProductPurchaseHistory.rdlc")
            'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\Administrator\Documents\Visual Studio 2010\Projects\POS\POS\RptProductPurchaseHistory.rdlc"
            'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\julius pc\Documents\Visual Studio 2010\Projects\POS1\POS\RptProductPurchaseHistory.rdlc"
            Me.ReportViewer1.LocalReport.DataSources.Clear()

            Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", Ds3.Tables("DataTableStockIn")))
            Me.ReportViewer1.DocumentMapCollapsed = True
            Me.ReportViewer1.RefreshReport()
            'Me.ShowDialog()
        End If
    End Sub
    Private Sub RPTProductHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
        populateproducts()
    End Sub
    Private Sub RPTProductHistory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class