Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmMaterialsrecieved
    Dim y As Integer
    Private Sub MaterialsReceived()
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
                    Sum(stockin.Quantity) as Quantity,
                    stockin.DateIn,
                    stockin.Supplier_Name,
                    stockindetails.StockInDetailID,
                    stockindetails.SuppID,
                    stockindetails.ReceivedBy,
                    suppliers.Supp_Name,
                    stockindetails.DateIn
                    FROM
                    product
                    INNER JOIN stockin ON stockin.PNO = product.ProductNo
                    INNER JOIN stockindetails ON stockin.StockInID = stockindetails.StockInDetailID
                    INNER JOIN suppliers ON stockindetails.SuppID = suppliers.Supplier_ID where product.Description Like '%" & txtFilterbyMaterialDesc.Text & "%'  Group By stockin.PNO"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgwIssueItems.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgwIssueItems.Rows.Add(dr("PNO"), dr("Description"), dr("Quantity"), dr("UnitofIssue"), dr("Supp_Name"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    'Private Sub MaterialsReceivedperSupplier()
    '    Dim MysqlConn As MySqlConnection
    '    Dim cmd As MySqlCommand
    '    MysqlConn = New MySqlConnection
    '    MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
    '    Dim dr As MySqlDataReader
    '    Try
    '        MysqlConn.Open()
    '        Dim Query As String
    '        Query = "Select stockin.StockInID,
    '                product.Description,
    '                product.UnitofIssue,
    '                stockin.PNO,
    '                stockin.Quantity,
    '                stockin.DateIn,
    '                stockin.Supplier_Name,
    '                stockindetails.StockInDetailID,
    '                stockindetails.SuppID,
    '                stockindetails.ReceivedBy,
    '                suppliers.Supp_Name,
    '                stockindetails.DateIn
    '                FROM
    '                product
    '                INNER JOIN stockin ON stockin.PNO = product.ProductNo
    '                INNER JOIN stockindetails ON stockin.StockInID = stockindetails.StockInDetailID
    '                INNER JOIN suppliers ON stockindetails.SuppID = suppliers.Supplier_ID where suppliers.Supp_Name Like '%" & txtsuppliers.Text & "%'  Group By stockin.PNO"
    '        cmd = New MySqlCommand(Query, MysqlConn)
    '        dr = cmd.ExecuteReader
    '        dgwIssueItems.Rows.Clear()
    '        y = 0
    '        Do While dr.Read = True
    '            dgwIssueItems.Rows.Add(dr("PNO"), dr("Description"), dr("Quantity"), dr("UnitofIssue"), dr("Supp_Name"))
    '            y += 17
    '        Loop
    '        MysqlConn.Close()
    '    Catch ex As MySqlException
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        MysqlConn.Dispose()
    '    End Try

    'End Sub

    Private Sub frmMaterialsrecieved_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub getqty()
        Dim qty As Decimal
        For r = 0 To dgwIssueItems.Rows.Count - 1
            qty += dgwIssueItems.Rows(r).Cells(2).Value
            lblTotal.Text = qty
        Next
    End Sub

    Private Sub txtFilterbyMaterialDesc_TextChanged(sender As Object, e As EventArgs) Handles txtFilterbyMaterialDesc.TextChanged
        MaterialsReceived()
        getqty()
    End Sub

    Private Sub txtsuppliers_TextChanged(sender As Object, e As EventArgs)
        'MaterialsReceivedperSupplier()
    End Sub
End Class