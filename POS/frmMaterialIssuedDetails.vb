Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmMaterialIssuedDetails
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
                Query = "Select delivery_details.DeliveryNo,
                    delivery_details.IssueDate,
                    delivery_details.SchemeId,
                    delivery_details.UserName,
                    delivery_details.Status,
                    delivery_items.Delivery_No,
                    delivery_items.Qty_Issued,
                    delivery_items.Item_No,
                    delivery_items.Date_Issued,
                    schemes.SchemeNo,
                    schemes.Scheme_Ref_No,
                    schemes.Scheme_Name,
                    product.ProductNo,
                    product.Description,
                    product.UnitofIssue
                    FROM
                    delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId
                    INNER Join product ON product.ProductNo = delivery_items.Item_No where Delivery_No ='" & frmMaterialsIssued.dtgpdcts.CurrentRow.Cells(0).Value & "'"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                dtgpdcts.Rows.Clear()
                y = 0
                Do While dr.Read = True
                    dtgpdcts.Rows.Add(dr("Delivery_No"), dr("Item_No"), dr("Description"), dr("Qty_Issued"), dr("Date_Issued"), dr("Scheme_Name"))
                Loop
            Next
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
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

    Private Sub frmMaterialIssuedDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItemstoDatagrid()
    End Sub
End Class