Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmMeterInstallationCost
    Dim y As Integer
    Private Sub LoadStatements()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                    tbl_billingdetails.BillingdetailID,
                    tbl_billingdetails.Sub_contractorID,
                    tbl_billingdetails.SchemeID,
                    tbl_billingdetails.TotalAmt,
                    tbl_billingdetails.TotalVat,
                    tbl_billingdetails.TotalIncVat,
                    tbl_billingparameters.subcatID,
                    tbl_billingitems.ItemNo,
                    tbl_billingitems.Qty,
                    subcategory.SubcategoryName,
                    schemes.SchemeNo,
                    schemes.Scheme_Ref_No,
                    schemes.Scheme_Name,
                    tbl_billingparameters.ItemNo,
                    tbl_subcontractors.subcontractor_Name
                    FROM
                    tbl_billingdetails
                    INNER JOIN tbl_billingitems ON tbl_billingitems.BillingID = tbl_billingdetails.BillingdetailID
                    INNER JOIN tbl_billingparameters ON tbl_billingparameters.ItemNo = tbl_billingitems.ItemNo
                    INNER JOIN subcategory ON subcategory.SubcategoryID = tbl_billingparameters.subcatID
                    INNER JOIN schemes ON schemes.SchemeNo = tbl_billingdetails.SchemeID
                    INNER JOIN tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = tbl_billingdetails.Sub_contractorID Where tbl_billingparameters.subcatID = 4 Group by tbl_billingdetails.BillingdetailID"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw1.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw1.Rows.Add(dr("BillingdetailID"), dr("Scheme_Name"), dr("Scheme_Ref_No"), dr("subcontractor_Name"), dr("TotalAmt"), dr("TotalVat"), dr("TotalIncVat"), dr("SubcategoryName"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmMeterInstallationCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CountMetersInstalled()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                    tbl_billingdetails.BillingdetailID,
                    tbl_billingdetails.Sub_contractorID,
                    tbl_billingdetails.SchemeID,
                    tbl_billingdetails.TotalAmt,
                    tbl_billingdetails.TotalVat,
                    tbl_billingdetails.TotalIncVat,
                    tbl_billingparameters.subcatID,
                    tbl_billingitems.ItemNo,
                    subcategory.SubcategoryName,
                    schemes.SchemeNo,
                    schemes.Scheme_Ref_No,
                    schemes.Scheme_Name,
                    tbl_billingparameters.ItemNo,
                    tbl_subcontractors.subcontractor_Name,
                    Sum(tbl_billingitems.Qty) as Qty
                    FROM
                    tbl_billingdetails
                    INNER JOIN tbl_billingitems ON tbl_billingitems.BillingID = tbl_billingdetails.BillingdetailID
                    INNER JOIN tbl_billingparameters ON tbl_billingparameters.ItemNo = tbl_billingitems.ItemNo
                    INNER JOIN subcategory ON subcategory.SubcategoryID = tbl_billingparameters.subcatID
                    INNER JOIN schemes ON schemes.SchemeNo = tbl_billingdetails.SchemeID
                    INNER JOIN tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = tbl_billingdetails.Sub_contractorID Where tbl_billingparameters.subcatID = 4 and tbl_billingitems.ItemNo = 32"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw1.Rows.Clear()
            y = 0
            If dr.Read = True Then
                lblTotMeters.Text = dr("Qty").ToString()
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub btnGenerateList_Click(sender As Object, e As EventArgs) Handles btnGenerateList.Click
        LoadStatements()
        GetTotal()
        'CountMetersInstalled()
    End Sub

    Private Sub LoadInvoices()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                    tbl_billingdetails.BillingdetailID,
                    tbl_billingdetails.Sub_contractorID,
                    tbl_billingdetails.SchemeID,
                    tbl_billingdetails.TotalAmt,
                    tbl_billingdetails.TotalVat,
                    tbl_billingdetails.TotalIncVat,
                    tbl_billingparameters.subcatID,
                    tbl_billingitems.ItemNo,
                    subcategory.SubcategoryName,
                    schemes.SchemeNo,
                    schemes.Scheme_Ref_No,
                    schemes.Scheme_Name,
                    tbl_billingparameters.ItemNo,
                    tbl_subcontractors.subcontractor_Name
                    FROM
                    tbl_billingdetails
                    INNER JOIN tbl_billingitems ON tbl_billingitems.BillingID = tbl_billingdetails.BillingdetailID
                    INNER JOIN tbl_billingparameters ON tbl_billingparameters.ItemNo = tbl_billingitems.ItemNo
                    INNER JOIN subcategory ON subcategory.SubcategoryID = tbl_billingparameters.subcatID
                    INNER JOIN schemes ON schemes.SchemeNo = tbl_billingdetails.SchemeID
                    INNER JOIN tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = tbl_billingdetails.Sub_contractorID Where tbl_billingparameters.subcatID = 4 and tbl_billingdetails.BillingdetailID like '%" & txtCategory.Text & "%' or schemes.Scheme_Name like '%" & txtCategory.Text & "%' or tbl_subcontractors.subcontractor_Name like '%" & txtCategory.Text & "%' Or subcategory.SubcategoryName like '%" & txtCategory.Text & "%' Group By  tbl_billingdetails.BillingdetailID"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw1.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw1.Rows.Add(dr("BillingdetailID"), dr("Scheme_Name"), dr("Scheme_Ref_No"), dr("subcontractor_Name"), dr("TotalAmt"), dr("TotalVat"), dr("TotalIncVat"), dr("SubcategoryName"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub txtCategory_TextChanged(sender As Object, e As EventArgs) Handles txtCategory.TextChanged
        LoadInvoices()
        GetTotal()
    End Sub

    Private Sub GetTotal()
        Dim TotAmt As Decimal
        Dim Totvat As Decimal
        Dim TotalIncVat As Decimal
        For r = 0 To dgw1.Rows.Count - 1
            TotAmt += dgw1.Rows(r).Cells(4).Value
            Totvat += dgw1.Rows(r).Cells(5).Value
            TotalIncVat += dgw1.Rows(r).Cells(6).Value
        Next
        lblTotalAmt.Text = Format(TotAmt, "#,##0.00").ToString()
        lblVat.Text = Format(Totvat, "#,##0.00").ToString()
        lblTotalincvat.Text = Format(TotalIncVat, "#,##0.00").ToString()
    End Sub

    Private Sub GetTotalforScheme()
        Dim TotAmt1 As Decimal
        Dim Totvat1 As Decimal
        Dim TotalIncVat1 As Decimal
        'dgw.CurrentRow.Cells(0).Value
        lblschmtotal.Text = dgw1.CurrentRow.Cells(4).Value
        lblschmvat.Text = dgw1.CurrentRow.Cells(5).Value
        lblschmtotincvat.Text = dgw1.CurrentRow.Cells(6).Value
    End Sub
    Private Sub LoadStatementItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT tbl_billingitems.BillingID, tbl_billingitems.ItemNo, tbl_billingitems.Qty, tbl_billingitems.Total, tbl_billingitems.Billingdate, tbl_billingparameters.Description, tbl_billingparameters.UnitRate, tbl_billingparameters.UoM
            FROM tbl_billingitems INNER JOIN tbl_billingparameters ON tbl_billingparameters.ItemNo = tbl_billingitems.ItemNo where tbl_billingitems.BillingID = '" & dgw1.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1), dr(5), dr(7), dr(6), dr(2), dr(3))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub dgw1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw1.CellContentClick
        LoadStatementItems()
        GetTotalforScheme()
    End Sub

    Private Sub btnLCSExportExcel_Click(sender As Object, e As EventArgs) Handles btnLCSExportExcel.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = dgw1.RowCount
            colsTotal = dgw1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dgw1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dgw1.Rows(I).Cells(j).Value
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

    Private Sub btnexporttoexcel_Click(sender As Object, e As EventArgs) Handles btnexporttoexcel.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = dgw.RowCount
            colsTotal = dgw.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dgw.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dgw.Rows(I).Cells(j).Value
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