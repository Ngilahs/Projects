Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration

Public Class frmIssuedToolsDetails
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
                Query = "SELECT
                        tbl_employees.Employee_ID,
                        tbl_employees.Employee_Name,
                        tbl_issue_tools_details.Issue_tools_details_No,
                        tbl_issue_tools_details.Issued_To,
                        tbl_issue_tools_details.Issued_By,
                        tbl_issue_tools_details.Issue_Date,
                        tbl_issue_tools.Tool_No,
                        tbl_issue_tools.Issue_Tools_No,
                        tbl_issue_tools.QtyIssued,
                        tbl_issue_tools.Date_Issued,
                        tbl_tools.ToolNo,
                        tbl_tools.Tool_Description
                        FROM
                        tbl_issue_tools_details
                        INNER JOIN tbl_employees ON tbl_issue_tools_details.Issued_To = tbl_employees.Employee_ID
                        INNER JOIN tbl_issue_tools ON tbl_issue_tools.Issue_Tools_No = tbl_issue_tools_details.Issue_tools_details_No
                        INNER JOIN tbl_tools ON tbl_tools.ToolNo = tbl_issue_tools.Tool_No
                        Where Issue_tools_details_No ='" & frmIssuedTools.dgwTools.CurrentRow.Cells(0).Value & "'"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                dgwTools.Rows.Clear()
                y = 0
                Do While dr.Read = True
                    dgwTools.Rows.Add(dr("Issue_tools_details_No"), dr("Tool_No"), dr("Tool_Description"), dr("QtyIssued"), dr("Issue_Date"))
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

            rowsTotal = dgwTools.RowCount
            colsTotal = dgwTools.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dgwTools.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dgwTools.Rows(I).Cells(j).Value
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

    Private Sub frmIssuedToolsDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItemstoDatagrid()
    End Sub
End Class