Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmStockPurchaseDetails
    Dim sqls As String
    Dim cmds As New MySqlCommand
    Dim drs As MySqlDataReader
    Dim y As Integer
    Private Sub LoadItemstoDatagrid()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            For i = 0 To frmListofStock.dtgpdcts.Rows.Count - 1
                If (MysqlConn.State = ConnectionState.Open) Then
                    MysqlConn.Close()
                End If
                MysqlConn.Open()
                Dim Query As String
                Query = "Select stockin.StockInID,
                        stockin.PNO,
                        stockin.Quantity,
                        stockin.DateIn,
                        stockin.Supplier_Name,
                        product.ProductNo,
                        product.Description,
                        suppliers.Supp_Name
                        FROM
                        stockin
                        INNER Join product ON stockin.PNO = product.ProductNo
                        INNER Join suppliers ON suppliers.Supplier_ID = stockin.Supplier_Name Where StockInID ='" & frmListofStock.dtgpdcts.CurrentRow.Cells(0).Value & "'"
                cmd = New MySqlCommand(Query, MysqlConn)
                drs = cmd.ExecuteReader
                dtgpdcts.Rows.Clear()
                y = 0
                Do While drs.Read = True
                    dtgpdcts.Rows.Add(drs("StockInID"), drs("PNO"), drs("Description"), drs("Quantity"), drs("DateIn"), drs("Supp_Name"))
                Loop
            Next
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmStockPurchaseDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadItemstoDatagrid()
    End Sub
    Private Sub frmStockPurchaseDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = dtgpdcts.RowCount
            colsTotal = dtgpdcts.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dtgpdcts.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dtgpdcts.Rows(I).Cells(j).Value
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