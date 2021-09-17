Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmInvoiceapproval
    Dim y As Integer
    Private Sub LoadInvoices()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT tbl_billingdetails.BillingdetailID, tbl_billingdetails.Sub_contractorID, tbl_billingdetails.SchemeID, schemes.Scheme_Name, tbl_subcontractors.subcontractor_Name, tbl_billingdetails.Approved, tbl_billingdetails.Cancelled FROM
            tbl_billingdetails INNER Join tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = tbl_billingdetails.Sub_contractorID
            INNER Join schemes ON schemes.SchemeNo = tbl_billingdetails.SchemeID where tbl_billingdetails.Approved = '0'  and tbl_billingdetails.Cancelled = '0'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw1.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw1.Rows.Add(dr("BillingdetailID"), dr("Scheme_Name"), dr("subcontractor_Name"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadInvoicesDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT tbl_billingdetails.BillingdetailID, tbl_billingdetails.Sub_contractorID, tbl_billingdetails.SchemeID, tbl_billingdetails.CountyID,tbl_billingdetails.ConstituencyID,
            tbl_billingdetails.BillingDate, tbl_billingdetails.SchemeRefNo, tbl_billingdetails.TXNo, tbl_billingdetails.Createdby, tbl_billingdetails.Workstation, tbl_billingdetails.TotalAmt,
            tbl_billingdetails.TotalVat, tbl_billingdetails.TotalIncVat, tbl_subcontractors.subcontractor_Name, schemes.Scheme_Name, county.County_Name, constituency.constituency_Name
            FROM tbl_billingdetails INNER JOIN tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = tbl_billingdetails.Sub_contractorID INNER JOIN schemes ON schemes.SchemeNo = tbl_billingdetails.SchemeID
            INNER JOIN county ON county.County_No = tbl_billingdetails.CountyID INNER JOIN constituency ON constituency.Constituency_No = tbl_billingdetails.ConstituencyID where tbl_billingdetails.BillingdetailID = '" & dgw1.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            'dgw1.Rows.Clear()
            Do While dr.Read = True
                txtInvoiceNo.Text = dr("BillingdetailID")
                txtTxNo.Text = dr("TXNo")
                txtSchemeName.Text = dr("Scheme_Name")
                txtCountyName.Text = dr("County_Name")
                txtConstituencyName.Text = dr("constituency_Name")
                txtVat.Text = dr("TotalVat")
                txtUserName.Text = dr("Createdby")
                txtSubcontrt.Text = dr("subcontractor_Name")
                txtTotAmt.Text = dr("TotalAmt")
                txtSchemeID.Text = dr("SchemeId")
                txtConstituencyID.Text = dr("ConstituencyId")
                txtCountyID.Text = dr("CountyId")
                txtTotIncVat.Text = dr("TotalIncVat")
                txtSchmRefNo.Text = dr("SchemeRefNo")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadInvoiceItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT tbl_billingitems.BillingID, tbl_billingitems.ItemNo, tbl_billingitems.Qty, tbl_billingitems.Total, tbl_billingitems.Billingdate, tbl_billingparameters.Description, tbl_billingparameters.UnitRate, tbl_billingparameters.UoM
            FROM tbl_billingitems INNER JOIN tbl_billingparameters ON tbl_billingparameters.ItemNo = tbl_billingitems.ItemNo where tbl_billingitems.BillingID = '" & txtInvoiceNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1), dr(5), dr(2), dr(7), dr(6), dr(3))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmInvoiceapproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInvoices()
        ApproveInvoiceToolStripButton2.Enabled = False
        CancelInvoiceToolStripButton3.Enabled = False
    End Sub

    Private Sub CancelDeliveryToolStripButton_Click(sender As Object, e As EventArgs) Handles CloseInvoiceapprovalToolStripButton.Click
        Me.Close()
    End Sub

    Private Sub dgw1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw1.CellContentClick
        LoadInvoicesDetails()
        LoadInvoiceItems()
    End Sub

    Private Sub chkCancelDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles chkCancelDelivery.CheckStateChanged
        If chkCancelDelivery.Checked = True Then
            ApproveInvoiceToolStripButton2.Enabled = False
            CancelInvoiceToolStripButton3.Enabled = True
            chkApproveDelivery.Checked = False
        End If
    End Sub

    Private Sub chkApproveDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles chkApproveDelivery.CheckedChanged
        If chkApproveDelivery.Checked = True Then
            CancelInvoiceToolStripButton3.Enabled = False
            ApproveInvoiceToolStripButton2.Enabled = True
            chkCancelDelivery.Checked = False
        End If
    End Sub

    Private Sub UpdateApproveDelivery()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'Approved, Approvedby
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE tbl_billingdetails SET Approved = '" & chkApproveDelivery.CheckState & "', Approvedby = '" & FrmMain.tsslUser.Text & "'  WHERE BillingdetailID = '" & txtInvoiceNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub UpdateCancelDelivery()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'Cancelled, Cancelledby
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE tbl_billingdetails SET Cancelled = '" & chkCancelDelivery.CheckState & "', Cancelledby = '" & FrmMain.tsslUser.Text & "'  WHERE BillingdetailID = '" & txtInvoiceNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    'Insert Cancel Invoice
    Private Sub InsertInvoiceCancelDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_statementcancel (InvoiceNo, CancelDate, Cancelled, CancelledBy) Values ('" & txtInvoiceNo.Text & "', '" & Format(Now, "MM/dd/yyyy") & "', '" & chkCancelDelivery.CheckState & "', '" & FrmMain.tsslUser.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Invoice successfully Cancelled.", MsgBoxStyle.Information, "Cancel Contractor Invoice")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    'Insert Approve Invoice
    Private Sub InsertInvoiceApproveDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_statementapprove (InvoiceNo, ApproveDate, Approved, ApprovedBy) Values ('" & txtInvoiceNo.Text & "', '" & Format(Now, "MM/dd/yyyy") & "', '" & chkApproveDelivery.CheckState & "', '" & FrmMain.tsslUser.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Invoice successfully Approved.", MsgBoxStyle.Information, "Approve Contractor Invoice")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    'Approve Invoice
    Private Sub ApproveInvoiceToolStripButton2_Click(sender As Object, e As EventArgs) Handles ApproveInvoiceToolStripButton2.Click
        If dgw.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please select the invoice to approve ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtInvoiceNo.Text = "" Then
            MessageBox.Show("Please select the invoice to approve", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        UpdateApproveDelivery()
        InsertInvoiceApproveDetails()
        Reset()
        LoadInvoices()
    End Sub
    'Cancel Invoice
    Private Sub CancelInvoiceToolStripButton3_Click(sender As Object, e As EventArgs) Handles CancelInvoiceToolStripButton3.Click
        If dgw.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please select the invoice to cancel ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtInvoiceNo.Text = "" Then
            MessageBox.Show("Please select the invoice to cancel", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        UpdateCancelDelivery()
        InsertInvoiceCancelDetails()
        Reset()
        LoadInvoices()
    End Sub

    Private Sub Reset()
        txtInvoiceNo.Text = ""
        txtTxNo.Text = ""
        txtSchemeName.Text = ""
        txtCountyName.Text = ""
        txtConstituencyName.Text = ""
        txtVat.Text = ""
        txtUserName.Text = ""
        txtSubcontrt.Text = ""
        txtTotAmt.Text = ""
        txtSchemeID.Text = ""
        txtConstituencyID.Text = ""
        txtCountyID.Text = ""
        txtTotIncVat.Text = ""
        txtSchmRefNo.Text = ""
        dgw.Rows.Clear()
    End Sub
End Class