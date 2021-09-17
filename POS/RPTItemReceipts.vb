Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RPTItemReceipts
    Public Sub Populatelistview()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select stockin.StockInID,
                    product.Description,
                    product.UnitofIssue,
                    stockin.PNO,
                    stockin.Quantity,
                    stockin.DateIn,
                    stockin.Supplier_Name,
                    stockindetails.StockInDetailID,
                    stockin.DocumentNo,
                    stockindetails.SuppID,
                    stockindetails.DateIn,
                    stockindetails.ReceivedBy,
                    suppliers.Supp_Name
                    FROM
                    product
                    INNER JOIN stockin ON stockin.PNO = product.ProductNo
                    INNER JOIN stockindetails ON stockin.StockInID = stockindetails.StockInDetailID
                    INNER JOIN suppliers ON stockindetails.SuppID = suppliers.Supplier_ID where StockInID = @d1"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", cboSearchItem.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("PNO").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("Quantity").ToString)
                x.SubItems.Add(dr("UnitofIssue").ToString)
                x.SubItems.Add(dr("Supp_Name").ToString)
                x.SubItems.Add(dr("DateIn").ToString)
                x.SubItems.Add(dr("StockInID").ToString)
                x.SubItems.Add(dr("DocumentNo").ToString)
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub PopulatelistviewwithSupplierDelNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select stockin.StockInID,
                    product.Description,
                    product.UnitofIssue,
                    stockin.PNO,
                    stockin.Quantity,
                    stockin.DateIn,
                    stockin.Supplier_Name,
                    stockindetails.StockInDetailID,
                    stockindetails.SuppID,
                    stockin.DocumentNo,
                    stockindetails.DateIn,
                    stockindetails.ReceivedBy,
                    suppliers.Supp_Name
                    FROM
                    product
                    INNER JOIN stockin ON stockin.PNO = product.ProductNo
                    INNER JOIN stockindetails ON stockin.StockInID = stockindetails.StockInDetailID
                    INNER JOIN suppliers ON stockindetails.SuppID = suppliers.Supplier_ID where  stockin.DocumentNo = @d1"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSupplierDNote.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("PNO").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("Quantity").ToString)
                x.SubItems.Add(dr("UnitofIssue").ToString)
                x.SubItems.Add(dr("Supp_Name").ToString)
                x.SubItems.Add(dr("DateIn").ToString)
                x.SubItems.Add(dr("StockInID").ToString)
                x.SubItems.Add(dr("DocumentNo").ToString)
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub PopulateReceipts()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT StockInDetailID from stockindetails Order By StockInDetailID"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                cboSearchItem.Items.Add(dr("StockInDetailID"))
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub PopulateItemNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT  ProductNo, Description from Product where Description = '" & cboSearchItem.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtItemNo.Text = dr("ProductNo")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub RPTStockPurchases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateReceipts()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub RPTStockPurchases_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub btnPrintreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowReport.Click

        Populatelistview()
        Dim Ds1 As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds1.Tables("MaterialReceipts").NewRow()
            drow("PNO") = ListView1.Items(i).Text
            drow("Description") = ListView1.Items(i).SubItems(1).Text
            drow("Quantity") = ListView1.Items(i).SubItems(2).Text
            drow("UnitofIssue") = ListView1.Items(i).SubItems(3).Text
            drow("Supp_Name") = ListView1.Items(i).SubItems(4).Text
            drow("DateIn") = ListView1.Items(i).SubItems(5).Text
            drow("StockInID") = ListView1.Items(i).SubItems(6).Text
            drow("DocumentNo") = ListView1.Items(i).SubItems(7).Text
            Ds1.Tables("MaterialReceipts").Rows.Add(drow)
        Next i
        Dim freport As New RPTProductwise
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "MaterialReceipts.rdlc")
        'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\joshua\Desktop\MM\POS\MaterialReceipts.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds1.Tables("MaterialReceipts")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        'Me.ShowDialog()
    End Sub

    Private Sub BtnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowReport.Click

    End Sub

    Private Sub cboSearchItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchItem.SelectedIndexChanged
        PopulateItemNo()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        PopulatelistviewwithSupplierDelNo()
        Dim Ds1 As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds1.Tables("MaterialReceipts").NewRow()
            drow("PNO") = ListView1.Items(i).Text
            drow("Description") = ListView1.Items(i).SubItems(1).Text
            drow("Quantity") = ListView1.Items(i).SubItems(2).Text
            drow("UnitofIssue") = ListView1.Items(i).SubItems(3).Text
            drow("Supp_Name") = ListView1.Items(i).SubItems(4).Text
            drow("DateIn") = ListView1.Items(i).SubItems(5).Text
            drow("StockInID") = ListView1.Items(i).SubItems(6).Text
            drow("DocumentNo") = ListView1.Items(i).SubItems(7).Text
            Ds1.Tables("MaterialReceipts").Rows.Add(drow)
        Next i
        Dim freport As New RPTProductwise
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "MaterialReceipts.rdlc")
        'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\joshua\Desktop\MM\POS\MaterialReceipts.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds1.Tables("MaterialReceipts")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        'Me.ShowDialog()

    End Sub
End Class