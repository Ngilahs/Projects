Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmUpdateMtrlReceived
    Dim m As Integer
    Dim y As Integer
    Private Sub LoadMaterialReceipts()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            'stockindetails(StockInDetailID, DateIn, SuppID, ReceivedBy, DocumentNo, DeliveryNo, SchemeID
            MysqlConn.Open()
            Dim Query As String
            Query = "Select S.StockInDetailID, S.DateIn, S.DocumentNo, S.SchemeID, S.SuppID, SS.Scheme_Name, SS.SchemeNo, SP.Supplier_ID, SP.Supp_Name FROM stockindetails S inner join schemes SS on (S.SchemeId = SS.SchemeNo) inner join suppliers SP on (SP.Supplier_ID = S.SuppID) WHERE S.StockInDetailID  LIKE '%" & txtReceiptdelivery.Text & "%' or SP.Supp_Name  LIKE '%" & txtReceiptdelivery.Text & "%' or S.DocumentNo LIKE '%" & txtReceiptdelivery.Text & "%' and S.DocumentNo <> '0ZXXXXX00012100005851111100'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            dgw1.Rows.Clear()
            m = 0
            Do While dr.Read = True
                dgw1.Rows.Add(dr("StockInDetailID"), dr("DocumentNo"), dr("Supp_Name"))
                m += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmUpdateMtrlReceived_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtReceiptdelivery_TextChanged(sender As Object, e As EventArgs) Handles txtReceiptdelivery.TextChanged
        LoadMaterialReceipts()
    End Sub
    Private Sub LoadReceiptItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            'StockInID, PNO, Quantity, QtyRem, Supplier_Name, DateIn, DocumentNo, DeliveryNo, SchemeID
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT S.StockInID, S.PNO, S.Quantity, S.Supplier_Name, S.DateIn, S.DocumentNo, S.SchemeID, P.Description FROM stockin S Inner Join product P on (P.ProductNo = S.PNo) Where S.StockInID = '" & dgw1.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("StockInID"), dr("PNO"), dr("Description"), dr("Quantity"), dr("DocumentNo"))
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
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select S.StockInDetailID, S.DateIn, S.DocumentNo, S.SchemeID, S.SuppID, SS.Scheme_Name, SS.SchemeNo, SP.Supplier_ID, SP.Supp_Name FROM stockindetails S inner join schemes SS on (S.SchemeId = SS.SchemeNo) inner join suppliers SP on (SP.Supplier_ID = S.SuppID) WHERE S.StockInDetailID = '" & dgw1.CurrentCell.Value & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtStockinIDRS.Text = dr("StockInDetailID")
                'lbldateRS.Text = dr("DateIn")
                cboSchemeName.Text = dr("Scheme_Name")
                txtSupplNameRS.Text = dr("Supp_Name")
                txtSchemeID.Text = dr("Scheme_Name")
                txtDocumentNo.Text = dr("DocumentNo")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        LoadReceiptItems()
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim dr As DataGridViewRow = dgw.SelectedRows(0)
        txtStockinIDRS.Text = dr.Cells(0).Value.ToString()
        txtItemNo.Text = dr.Cells(1).Value.ToString()
        cboSearchItem.Text = dr.Cells(2).Value.ToString()
        txtreceivedQty.Text = dr.Cells(3).Value.ToString()
        txtStockinIDRS.Text = dr.Cells(4).Value.ToString()
        'txtqtyinvoiced.Text = dr.Cells(5).Value.ToString()
        'txtTotal.Text = dr.Cells(6).Value.ToString()
        'btnUpdate.Enabled = True
    End Sub
End Class