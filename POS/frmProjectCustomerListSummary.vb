Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmProjectCustomerListSummary
    Dim y As Integer
    Private Sub LoadCustomerList()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select
                    tbl_meterrvcd_details.MeterRcptNo,
                    tbl_meterrvcd_details.SchemeID,
                    tbl_meterrvcd_details.CustomerName,
                    tbl_meterrvcd_details.IDNo,
                    tbl_meterrvcd_details.PoleNo,
                    tbl_meterrvcd_details.PhoneNo,
                    tbl_meterrvcd_details.XCoordinate,
                    tbl_meterrvcd_details.YCoordinate,
                    tbl_meterrvcd_details.YRefNo,
                    tbl_meterrvcd_details.WorkOrder,
                    tbl_meterrvcd_details.MeterNo,
                    tbl_meterrvcd_details.ConnectionStatus,
                    tbl_meterrvcd_details.Gender,
                    tbl_meterrvcd_details.Earthing,
                    tbl_meterrvcd_details.Remarks,
                    tbl_meterrvcd_details.IssuanceStatus,
                    schemes.Scheme_Name,
                    tbl_meterrvcd_info.SchemeID,
                    constituency.constituency_Name,
                    county.County_Name,
                    tbl_meterrvcd_info.Qtyrcvd,
                    schemes.Scheme_Ref_No,
                    schemes.County_Id,
                    schemes.Substation_No,
                    schemes.Constituency_Id
                    FROM
            tbl_meterrvcd_details
            INNER Join tbl_meterrvcd_info ON tbl_meterrvcd_details.MeterRcptNo = tbl_meterrvcd_info.MeterReceiptNo
                    INNER Join schemes ON schemes.SchemeNo = tbl_meterrvcd_info.SchemeID
                    INNER Join constituency ON constituency.Constituency_No = schemes.Constituency_Id
                    INNER Join county ON county.County_No = schemes.County_Id  where tbl_meterrvcd_details.MeterNo Like '%" & txtFilterbyIDMeterNo.Text & "%' or  tbl_meterrvcd_details.IDNo Like '%" & txtFilterbyIDMeterNo.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgwv.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgwv.Rows.Add(dr("CustomerName"), dr("IDNo"), dr("PoleNo"), dr("PhoneNo"), dr("XCoordinate"), dr("YCoordinate"), dr("YRefNo"), dr("MeterNo"), dr("Earthing"), dr("ConnectionStatus"), dr("IssuanceStatus"), dr("Remarks"), dr("Scheme_Name"), dr("Scheme_Ref_No"), dr("Substation_No"), dr("constituency_Name"), dr("County_Name"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        lblTotalCustomers.Text = dgwv.RowCount
    End Sub

    Private Sub LoadCustomerList2()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select
                    tbl_meterrvcd_details.MeterRcptNo,
                    tbl_meterrvcd_details.SchemeID,
                    tbl_meterrvcd_details.CustomerName,
                    tbl_meterrvcd_details.IDNo,
                    tbl_meterrvcd_details.PoleNo,
                    tbl_meterrvcd_details.PhoneNo,
                    tbl_meterrvcd_details.XCoordinate,
                    tbl_meterrvcd_details.YCoordinate,
                    tbl_meterrvcd_details.YRefNo,
                    tbl_meterrvcd_details.WorkOrder,
                    tbl_meterrvcd_details.MeterNo,
                    tbl_meterrvcd_details.ConnectionStatus,
                    tbl_meterrvcd_details.Gender,
                    tbl_meterrvcd_details.Earthing,
                    tbl_meterrvcd_details.Remarks,
                    tbl_meterrvcd_details.IssuanceStatus,
                    schemes.Scheme_Name,
                    tbl_meterrvcd_info.SchemeID,
                    constituency.constituency_Name,
                    county.County_Name,
                    tbl_meterrvcd_info.Qtyrcvd,
                    schemes.Scheme_Ref_No,
                    schemes.County_Id,
                    schemes.Substation_No,
                    schemes.Constituency_Id
                    FROM
            tbl_meterrvcd_details
            INNER Join tbl_meterrvcd_info ON tbl_meterrvcd_details.MeterRcptNo = tbl_meterrvcd_info.MeterReceiptNo
                    INNER Join schemes ON schemes.SchemeNo = tbl_meterrvcd_info.SchemeID
                    INNER Join constituency ON constituency.Constituency_No = schemes.Constituency_Id
                    INNER Join county ON county.County_No = schemes.County_Id  where schemes.Scheme_Name Like '%" & txtcountytxnozrefscheme.Text & "%' or  constituency.constituency_Name Like '%" & txtcountytxnozrefscheme.Text & "%' or county.County_Name Like '%" & txtcountytxnozrefscheme.Text & "%' or  schemes.Substation_No Like '%" & txtcountytxnozrefscheme.Text & "%' or  schemes.Scheme_Ref_No Like '%" & txtcountytxnozrefscheme.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgwv.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgwv.Rows.Add(dr("CustomerName"), dr("IDNo"), dr("PoleNo"), dr("PhoneNo"), dr("XCoordinate"), dr("YCoordinate"), dr("YRefNo"), dr("MeterNo"), dr("Earthing"), dr("ConnectionStatus"), dr("IssuanceStatus"), dr("Remarks"), dr("Scheme_Name"), dr("Scheme_Ref_No"), dr("Substation_No"), dr("constituency_Name"), dr("County_Name"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        lblTotalCustomers.Text = dgwv.RowCount
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

            rowsTotal = dgwv.RowCount
            colsTotal = dgwv.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dgwv.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dgwv.Rows(I).Cells(j).Value
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

    Private Sub frmProjectCustomerListSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtFilterbyIDMeterNo_TextChanged(sender As Object, e As EventArgs) Handles txtFilterbyIDMeterNo.TextChanged
        LoadCustomerList()
    End Sub

    Private Sub txtcountytxnozrefscheme_TextChanged(sender As Object, e As EventArgs) Handles txtcountytxnozrefscheme.TextChanged
        LoadCustomerList2()
    End Sub
End Class