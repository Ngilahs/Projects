Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmMaterialsDelivered
    Dim y As Integer
    Public Sub SeaarchItemNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
delivery_details.CountyId,
delivery_details.ConstituencyId,
delivery_items.Item_No,
product.ProductNo,
product.Description,
product.UnitofIssue,
product.PrefSupplier,
suppliers.Supplier_ID,
suppliers.Supp_Name,
county.County_No,
county.County_Name,
constituency.Constituency_No,
constituency.constituency_Name,
schemes.SchemeNo,
schemes.Scheme_Ref_No,
delivery_details.ContractorId,
delivery_items.Delivery_No,
schemes.Scheme_Name,
sum(delivery_items.Qty_Issued) as Qty_Issued,
delivery_items.Date_Issued
FROM delivery_details
INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
INNER Join product ON delivery_items.Item_No = product.ProductNo
INNER Join suppliers ON product.PrefSupplier = suppliers.Supplier_ID
INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId
INNER Join constituency ON constituency.Constituency_No = delivery_details.ConstituencyId
INNER Join county ON county.County_No = delivery_details.CountyId where product.Description Like '%" & txtFilterbyMaterialDesc.Text & "%' Group By Item_No, SchemeId"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgwIssueItems.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgwIssueItems.Rows.Add(dr("Item_No"), dr("Description"), dr("Qty_Issued"), dr("UnitofIssue"), dr("Scheme_Name"), dr("Scheme_Ref_No"), dr("constituency_Name"), dr("County_Name"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    '    Public Sub SeaarchSchemeCounty()
    '        Dim MysqlConn As MySqlConnection
    '        Dim cmd As MySqlCommand
    '        MysqlConn = New MySqlConnection
    '        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
    '        Dim dr As MySqlDataReader
    '        Try
    '            MysqlConn.Open()
    '            Dim Query As String
    '            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
    'delivery_details.CountyId,
    'delivery_details.ConstituencyId,
    'delivery_items.Item_No,
    'product.ProductNo,
    'product.Description,
    'product.UnitofIssue,
    'product.PrefSupplier,
    'suppliers.Supplier_ID,
    'suppliers.Supp_Name,
    'county.County_No,
    'county.County_Name,
    'constituency.Constituency_No,
    'constituency.constituency_Name,
    'schemes.SchemeNo,
    'schemes.Scheme_Ref_No,
    'delivery_details.ContractorId,
    'delivery_items.Delivery_No,
    'schemes.Scheme_Name,
    'sum(delivery_items.Qty_Issued) as Qty_Issued,
    'delivery_items.Date_Issued
    'FROM delivery_details
    'INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
    'INNER Join product ON delivery_items.Item_No = product.ProductNo
    'INNER Join suppliers ON product.PrefSupplier = suppliers.Supplier_ID
    'INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId
    'INNER Join constituency ON constituency.Constituency_No = delivery_details.ConstituencyId
    'INNER Join county ON county.County_No = delivery_details.CountyId where schemes.Scheme_Name Like '%" & txtSchemeconstcounty.Text & "%' Or county.County_Name Like '%" & txtSchemeconstcounty.Text & "%' Group By Item_No"
    '            cmd = New MySqlCommand(Query, MysqlConn)
    '            dr = cmd.ExecuteReader
    '            dgwIssueItems.Rows.Clear()
    '            y = 0
    '            Do While dr.Read = True
    '                dgwIssueItems.Rows.Add(dr("Item_No"), dr("Description"), dr("Qty_Issued"), dr("UnitofIssue"), dr("Scheme_Name"), dr("Scheme_Ref_No"), dr("constituency_Name"), dr("County_Name"))
    '                y += 17
    '            Loop
    '            MysqlConn.Close()
    '        Catch ex As MySqlException
    '            MessageBox.Show(ex.Message)
    '        Finally
    '            MysqlConn.Dispose()
    '        End Try

    '    End Sub
    Private Sub frmMaterialsDelivered_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub getqty()
        Dim qty As Decimal
        For r = 0 To dgwIssueItems.Rows.Count - 1
            qty += dgwIssueItems.Rows(r).Cells(2).Value
            lblTotal.Text = qty
        Next
    End Sub
    Private Sub txtFilterbyMaterialDesc_TextChanged(sender As Object, e As EventArgs) Handles txtFilterbyMaterialDesc.TextChanged
        SeaarchItemNo()
        getqty()
    End Sub

    Private Sub txtSchemeconstcounty_TextChanged(sender As Object, e As EventArgs)
        'SeaarchSchemeCounty()
        getqty()
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

            rowsTotal = dgwIssueItems.RowCount
            colsTotal = dgwIssueItems.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dgwIssueItems.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dgwIssueItems.Rows(I).Cells(j).Value
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class