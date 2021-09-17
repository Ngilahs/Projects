Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmListofStock
    Dim y As Integer
    Private Sub frmListofStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub GetStockpurchased()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                    stockindetails.StockInDetailID,
                    stockindetails.SuppID,
                    stockindetails.DateIn,
                    stockindetails.ReceivedBy,
                    suppliers.Supp_Name,
                    suppliers.Supplier_ID
                    FROM
                    suppliers
                    INNER Join stockindetails ON stockindetails.SuppID = suppliers.Supplier_ID ORDER BY DateIn Desc"
            cmd = New MySqlCommand(Query, MysqlConn)
            'cmd.Parameters.AddWithValue("@dt1", dtpDateFrom.Value.ToString("MM/dd/yyyy"))
            'cmd.Parameters.AddWithValue("@dt2", dtpDateTo.Value.ToString("MM/dd/yyyy"))
            dr = cmd.ExecuteReader
            dtgpdcts.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dtgpdcts.Rows.Add(dr("StockInDetailID"), dr("Supp_Name"), dr("DateIn"), dr("ReceivedBy"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmListofStock_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim tot As Decimal
        If e.KeyCode = Keys.Enter Then
            Dim drr As New System.Windows.Forms.DataGridViewRow
            For Each drr In dtgpdcts.SelectedRows
                'frmBalaSheet.dtgCart.Rows.Add(drr.Cells(0).Value, drr.Cells(1).Value, 1, drr.Cells(2).Value, Format(drr.Cells(2).Value * 1, "#,##0.00"), drr.Cells(3).Value, drr.Cells(4).Value, drr.Cells(5).Value)
                For i = 0 To FrmPointofSale.dgwIssueItems.Rows.Count - 1
                    tot += FrmPointofSale.dgwIssueItems.Rows(i).Cells(4).Value
                Next
                'frmBalaSheet.LBLTotSale0.Text = Format(tot, "#,##0.00")
            Next
            Me.Close()
        End If
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub dtgpdcts_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgpdcts.CellClick
        frmStockPurchaseDetails.Show()
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
    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        GetStockpurchased()
    End Sub
    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        dtgpdcts.Rows.Clear()
    End Sub

    
End Class