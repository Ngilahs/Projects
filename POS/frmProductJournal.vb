Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmProductJournal
    Dim y As Integer
    Private Sub GetStockpurchased()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select stockin.StockInID, stockin.PNO, stockin.Quantity, stockin.QtyRem, product.Description, product.StocksOnHand, stockin.DateIn, 'Received Material' FROM product INNER Join stockin ON stockin.PNO = product.ProductNo UNION Select
  delivery_items.Delivery_No, delivery_items.Item_No, delivery_items.Qty_Issued, delivery_items.Qty_Rem, product.Description, product.StocksOnHand, delivery_items.Date_Issued, 'Issued Material' FROM
 product INNER Join delivery_items ON delivery_items.Item_No = product.ProductNo Order by PNO ASC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dtgCart.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dtgCart.Rows.Add(dr("PNO"), dr("Description"), dr("StockInID"), dr("Quantity"), dr("QtyRem"), dr("StocksOnHand"), dr("DateIn"), dr(7))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        GetStockpurchased()
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = dtgCart.RowCount
            colsTotal = dtgCart.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dtgCart.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dtgCart.Rows(I).Cells(j).Value
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

    Private Sub frmProductJournal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class