Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmSchemePaymentStatus
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
tbl_billingdetails.StatementInvoiced,
tbl_billingdetails.StatementPaid,
tbl_billingitems.BillingID,
tbl_billingparameters.subcatID,
tbl_subcontractors.subcontractor_Name,
tbl_subcontractors.subcontractors_ID,
schemes.Scheme_Ref_No,
schemes.SchemeNo,
schemes.Scheme_Name,
subcategory.SubcategoryID,
subcategory.SubcategoryName
FROM
tbl_billingdetails
INNER JOIN tbl_billingitems ON tbl_billingitems.BillingID = tbl_billingdetails.BillingdetailID
INNER JOIN tbl_billingparameters ON tbl_billingparameters.ItemNo = tbl_billingitems.ItemNo
INNER JOIN tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = tbl_billingdetails.Sub_contractorID
INNER JOIN schemes ON schemes.SchemeNo = tbl_billingdetails.SchemeID
INNER JOIN subcategory ON subcategory.SubcategoryID = tbl_billingparameters.subcatID group by tbl_billingdetails.SchemeID"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("SchemeID"), dr("BillingdetailID"), dr("Scheme_Name"), dr("Scheme_Ref_No"), dr("SubcategoryName"), dr("TotalAmt"), dr("StatementInvoiced"), dr("StatementPaid"), dr("subcontractor_Name"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        FillDatagrid()
    End Sub
    Private Sub FillDatagrid()
        For i = 0 To dgw.Rows.Count - 1
            If dgw.Rows(i).Cells(6).Value = 1 Then
                dgw.Rows(i).Cells(6).Value = "Yes"
            Else
                If dgw.Rows(i).Cells(6).Value = 0 Then
                    dgw.Rows(i).Cells(6).Value = "No"
                End If
            End If
            If dgw.Rows(i).Cells(7).Value = 1 Then
                dgw.Rows(i).Cells(7).Value = "Yes"
            Else
                If dgw.Rows(i).Cells(7).Value = 0 Then
                    dgw.Rows(i).Cells(7).Value = "No"
                End If
            End If
        Next
    End Sub
    Private Sub txtCustomerNo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmSchemePaymentStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadStatements()
    End Sub
    Private Sub ConvertBoolean()
        If dgw.CurrentRow.Cells(6).Value = "Yes" Then
            chkstatementInvoiced.Checked = True
        Else
            If dgw.CurrentRow.Cells(6).Value = "No" Then
                chkstatementInvoiced.Checked = False
            End If
        End If
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        txtStatementNo.Text = dgw.Item(1, i).Value
        cboSubcontractor.Text = dgw.Item(8, i).Value
        txtSchemeRefNo1.Text = dgw.Item(3, i).Value
        txtSchemeName1.Text = dgw.Item(2, i).Value
        txtCategory.Text = dgw.Item(4, i).Value
        txtAmount.Text = dgw.Item(5, i).Value
        'chkstatementInvoiced.Text = dgw.Item(6, i).Value
        'ConvertBoolean()
    End Sub
End Class