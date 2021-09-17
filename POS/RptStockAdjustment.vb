Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RptStockAdjustment
    Public Sub Populatelistview()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
tbl_stockadjustmentline.StockadjustmentlineId,
tbl_stockadjustmentline.StockAdjustID,
tbl_stockadjustmentline.ProductNo,
tbl_stockadjustmentline.AdjustmentQty,
tbl_stockadjustmentline.CurrentStock,
tbl_stockadjustmentline.AdjustedStock,
tbl_stockadjustmentline.AdjustmentDate,
tbl_stockadjustmentline.AdjustmentType,
tbl_stockadjustmentline.AccountName,
tbl_stockadjustmentline.Reason,
tbl_stockadjustmentline.Remarks,
tbl_stockadjustmentline.AdjustedBy,
product.ProductNo,
product.Description,
product.UnitofIssue

FROM
product
INNER JOIN tbl_stockadjustmentline ON tbl_stockadjustmentline.ProductNo = product.ProductNo
 where CountyId = @d1 Group By Item_No, SchemeId"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtCounty.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("StockAdjustID").ToString)
                x.SubItems.Add(dr("ProductNo").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("UnitofIssue").ToString)
                x.SubItems.Add(dr("AdjustmentQty").ToString)
                x.SubItems.Add(dr("CurrentStock").ToString)
                x.SubItems.Add(dr("AdjustedStock").ToString)
                x.SubItems.Add(dr("AdjustmentDate").ToString)
                x.SubItems.Add(dr("AdjustmentType").ToString)
                x.SubItems.Add(dr("AccountName").ToString)
                x.SubItems.Add(dr("Reason").ToString)
                x.SubItems.Add(dr("Remarks").ToString)
                x.SubItems.Add(dr("AdjustedBy").ToString)
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub PopulateStockAdjustment()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT vehiclesid, vehicle_no, Type from tbl_stockadjustment ORDER BY vehicle_no"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboAdjustmentNo.Items.Clear()
            Do While dr.Read = True
                cboAdjustmentNo.Items.Add(dr("vehicle_no"))
                cboAdjustmentNo.Text = "Description"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub RptStockAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populatelistview()
    End Sub
End Class