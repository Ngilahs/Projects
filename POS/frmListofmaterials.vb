Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration

Public Class frmListofmaterials
    Dim sqls As String
    Dim cmds As New MySqlCommand
    Dim drs As MySqlDataReader
    Dim y As Integer
    Private Sub calcMarkUp()
        Dim tot As Decimal
        Dim amt As Decimal
        Dim vat As Decimal
        'Calculate total markup amount
        For i = 0 To dgw.Rows.Count - 1
            tot += dgw.Rows(i).Cells(6).Value
            amt += dgw.Rows(i).Cells(3).Value
            vat += dgw.Rows(i).Cells(9).Value
        Next
        'txtmarkup.Text = Format(tot, "#,##0.00")
        'txtAmt.Text = Format(amt, "#,##0.00")
        'txtVat.Text = Format(vat, "#,##0.00")
    End Sub
    Private Sub clearall()
        'txtmarkup.Text = ""
        'txtAmt.Text = ""
        'txtVat.Text = ""
        dgw.Rows.Clear()
        'txtsearchsname.Text = ""
        txtDeliveryNo.Text = ""
        'txtTotalAmt.Text = ""

    End Sub
    Private Sub frmListofcashsales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub txtsearchsname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    sqL = "Select TransID, RECEIPTNO, TRANSDATE, TOTALPRICE, TENDEREDAMOUNT, CHANGEAMOUNT, MkUp, AMTTOCALCVAT, VATABLEAMT, VAT, ITEMCOUNT, TillNo, UserName, SessIDNo, TimeX FROM s_payment WHERE TransID LIKE '" & txtsearchsname.Text & "%'"
        '    ConnDB()
        '    cmd = New MySqlCommand(sqL, conn)
        '    dr = cmd.ExecuteReader
        '    dgw.Rows.Clear()
        '    y = 0
        '    Do While dr.Read = True
        '        dgw.Rows.Add(dr("TransID"), dr("RECEIPTNO"), dr("TRANSDATE"), dr("TOTALPRICE"), dr("TENDEREDAMOUNT"), dr("CHANGEAMOUNT"), dr("MkUp"), dr("AMTTOCALCVAT"), dr("VATABLEAMT"), dr("VAT"), dr("ITEMCOUNT"), dr("TillNo"), dr("UserName"), dr("SessIDNo"), dr("TimeX"))
        '        y += 17
        '    Loop
        '    calcMarkUp()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'Finally
        '    cmd.Dispose()
        '    conn.Close()
        'End Try
    End Sub

    Private Sub txtReceiptNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeliveryNo.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select DD.DeliveryNo, DD.IssueDate, DD.ItemCount, DD.SchemeId, DD.CountyId, DD.ConstituencyId, DD.UserName, DD.TillNo, DD.SessIDNo, DD.TimeX, S.Scheme_Name, C.County_Name, CN.constituency_Name FROM delivery_details DD inner join schemes S on (DD.SchemeId = S.SchemeNo) inner join county C on (DD.CountyId = C.County_No) inner join constituency CN on (CN.Constituency_No = DD.ConstituencyId) WHERE DD.DeliveryNo LIKE '" & txtDeliveryNo.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                    dgw.Rows.Add(dr("DeliveryNo"), dr("IssueDate"), dr("ItemCount"), dr("Scheme_Name"), dr("constituency_Name"), dr("County_Name"), dr("UserName"))
                    y += 17
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub


    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        frmLoadItemsIssued.Show()
    End Sub


    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLCSExportExcel.Click
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


    Private Sub BtnGetTillNoData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        clearall()
    End Sub


    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        frmLoadItemsIssued.Show()
    End Sub

    Private Sub frmListofmaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
