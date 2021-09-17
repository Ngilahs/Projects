Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmLoadItemsIssued
    Private Sub LoadItemsIssuedtoDatagrid()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            For i = 0 To FrmPointofSale.dgwIssueItems.Rows.Count - 1
                Query = "Select DI.Delivery_No, DI.Item_No, DI.Qty_Issued, DI.Qty_Rem, DI.Date_Issued, DI.Issue_Time, P.Description, P.UnitofIssue from delivery_items DI Inner Join product P on (DI.Item_No = P.ProductNo) Where DI.Delivery_No = '" & frmListofmaterials.dgw.CurrentRow.Cells(0).Value & "'"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                dtgpdcts.Rows.Clear()
                Do While dr.Read = True
                    dtgpdcts.Rows.Add(dr("Delivery_No"), dr("Item_No"), dr("Description"), dr("Qty_Issued"), dr("Date_Issued"), dr("Issue_Time"), dr("UnitofIssue"))
                Loop
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub frmLoadItemsIssued_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItemsIssuedtoDatagrid()
    End Sub
    Private bitmap As Bitmap
    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        'Resize DataGridView to full height.
        Dim height As Integer = dtgpdcts.Height
        dtgpdcts.Height = dtgpdcts.RowCount * dtgpdcts.RowTemplate.Height

        'Create a Bitmap and draw the DataGridView on it.
        bitmap = New Bitmap(Me.dtgpdcts.Width, Me.dtgpdcts.Height)
        dtgpdcts.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.dtgpdcts.Width, Me.dtgpdcts.Height))

        'Resize DataGridView back to original height.
        dtgpdcts.Height = height

        'Show the Print Preview Dialog.
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnLoadDeliveryNote_Click(sender As Object, e As EventArgs)
        frmPrint.Show()
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