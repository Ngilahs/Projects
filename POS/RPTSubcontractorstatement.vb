Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RPTSubcontractorstatement
    Public Sub Populatelistview()
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
tbl_billingdetails.SchemeRefNo,
tbl_billingdetails.TXNo,
tbl_billingdetails.Approved,
tbl_billingdetails.TotalAmt,
tbl_billingdetails.TotalVat,
tbl_billingdetails.TotalIncVat,
tbl_billingitems.ItemNo,
tbl_billingitems.Qty,
tbl_billingitems.Total, 
tbl_billingdetails.BillingDate,
tbl_billingparameters.Description,
tbl_billingparameters.UoM,
tbl_billingparameters.UnitRate,
schemes.SchemeNo,
schemes.Scheme_Ref_No,
schemes.Substation_No,
schemes.Scheme_Name,
tbl_subcontractors.subcontractor_Name,
tbl_subcontractors.Location,
tbl_subcontractors.Phone_No,
tbl_subcontractors.Address,
tbl_billingparameters.DateCreated,
category.CategoryName,
tbl_billingparameters.categoryID
FROM
tbl_billingdetails
INNER JOIN tbl_billingitems ON tbl_billingitems.BillingID = tbl_billingdetails.BillingdetailID
INNER JOIN tbl_billingparameters ON tbl_billingparameters.ItemNo = tbl_billingitems.ItemNo
INNER JOIN schemes ON schemes.SchemeNo = tbl_billingdetails.SchemeID
INNER JOIN category ON tbl_billingparameters.categoryID = category.CategoryNo
INNER JOIN tbl_subcontractors ON tbl_billingdetails.Sub_contractorID = tbl_subcontractors.subcontractors_ID Where BillingdetailID = @d1 and tbl_billingitems.Qty > 0 and Approved = 1"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", cboInvoiceNo.Text)
            'TotalAmt, TotalVat, TotalIncVat
            ' Location, Phone_No, Address
            'cmd.Parameters.AddWithValue("@dt1", DateTimePicker1.Value.ToString("MM/dd/yyyy"))
            'cmd.Parameters.AddWithValue("@dt2", DateTimePicker2.Value.ToString("MM/dd/yyyy"))
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("BillingdetailID").ToString)
                x.SubItems.Add(dr("ItemNo").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("UoM").ToString)
                x.SubItems.Add(dr("Qty").ToString)
                x.SubItems.Add(dr("UnitRate").ToString)
                x.SubItems.Add(dr("Total").ToString)
                x.SubItems.Add(dr("Scheme_Name").ToString)
                x.SubItems.Add(dr("subcontractor_Name").ToString)
                x.SubItems.Add(dr("Scheme_Ref_No").ToString)
                x.SubItems.Add(dr("Substation_No").ToString)
                x.SubItems.Add(dr("BillingDate").ToString)
                x.SubItems.Add(dr("TotalAmt").ToString)
                x.SubItems.Add(dr("TotalVat").ToString)
                x.SubItems.Add(dr("TotalIncVat").ToString)
                x.SubItems.Add(dr("Location").ToString)
                x.SubItems.Add(dr("Phone_No").ToString)
                x.SubItems.Add(dr("Address").ToString)
                x.SubItems.Add(dr("CategoryName").ToString)
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub InvoiceNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select BillingdetailID from tbl_billingdetails where Approved = '1'  and tbl_billingdetails.Cancelled = '0'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboInvoiceNo.Items.Clear()
            Do While dr.Read = True
                cboInvoiceNo.Items.Add(dr("BillingdetailID"))
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub RPTSubcontractorstatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InvoiceNo()
    End Sub

    Private Sub BtnShowReport_Click(sender As Object, e As EventArgs) Handles BtnShowReport.Click
        If cboInvoiceNo.Text = "" Then
            MessageBox.Show("Please select InvoiceNo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboInvoiceNo.Focus()
            Return
        End If
        Populatelistview()
        Dim Ds As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds.Tables("ContractorInvoice").NewRow()
            drow("BillingdetailID") = ListView1.Items(i).Text
            drow("ItemNo") = ListView1.Items(i).SubItems(1).Text
            drow("Description") = ListView1.Items(i).SubItems(2).Text
            drow("UoM") = ListView1.Items(i).SubItems(3).Text
            drow("Qty") = ListView1.Items(i).SubItems(4).Text
            drow("UnitRate") = ListView1.Items(i).SubItems(5).Text
            drow("Total") = ListView1.Items(i).SubItems(6).Text
            drow("Scheme_Name") = ListView1.Items(i).SubItems(7).Text
            drow("subcontractor_Name") = ListView1.Items(i).SubItems(8).Text
            drow("Scheme_Ref_No") = ListView1.Items(i).SubItems(9).Text
            drow("Substation_No") = ListView1.Items(i).SubItems(10).Text
            drow("BillingDate") = ListView1.Items(i).SubItems(11).Text
            drow("TotalAmt") = ListView1.Items(i).SubItems(12).Text
            drow("TotalVat") = ListView1.Items(i).SubItems(13).Text
            drow("TotalIncVat") = ListView1.Items(i).SubItems(14).Text
            drow("Location") = ListView1.Items(i).SubItems(15).Text
            drow("Phone_No") = ListView1.Items(i).SubItems(16).Text
            drow("Address") = ListView1.Items(i).SubItems(17).Text
            drow("CategoryName") = ListView1.Items(i).SubItems(18).Text
            Ds.Tables("ContractorInvoice").Rows.Add(drow)
        Next i
        Dim freport As New RptDailySalesReport
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "RPTContractorInvoice.rdlc")
        'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\joshua\Desktop\MM\POS\MaterialDeliveryNote.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds.Tables("ContractorInvoice")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        'Me.ShowDialog()
        'x.SubItems.Add(dr("TotalAmt").ToString)
        'x.SubItems.Add(dr("TotalVat").ToString)
        'x.SubItems.Add(dr("TotalIncVat").ToString)
        'x.SubItems.Add(dr("Location").ToString)
        'x.SubItems.Add(dr("Phone_No").ToString)
        'x.SubItems.Add(dr("Address").ToString)
    End Sub

    Private Sub btnMovetoLastrecord_Click(sender As Object, e As EventArgs) Handles btnMovetoLastrecord.Click
        GetStatementNo()
    End Sub
    Public Sub GetStatementNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT BillingdetailID FROM tbl_billingdetails ORDER BY BillingdetailID DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                cboInvoiceNo.Text = dr("BillingdetailID")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub GetStatementNoUpbyOneRec()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT BillingdetailID FROM tbl_billingdetails ORDER BY BillingdetailID DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                cboInvoiceNo.Text = dr("BillingdetailID") - 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnMoveUpOnerecord_Click(sender As Object, e As EventArgs) Handles btnMoveUpOnerecord.Click
        GetStatementNoUpbyOneRec()
    End Sub
    Public Sub GetStatementNoFirstRec()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT BillingdetailID FROM tbl_billingdetails ORDER BY BillingdetailID ASC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                cboInvoiceNo.Text = dr("BillingdetailID")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnMoveFirstRecord_Click(sender As Object, e As EventArgs) Handles btnMoveFirstRecord.Click
        GetStatementNoFirstRec()
    End Sub

    Public Sub GetStatementNoFirstRecupbyone()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT BillingdetailID FROM tbl_billingdetails ORDER BY BillingdetailID ASC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                cboInvoiceNo.Text = dr("BillingdetailID") + 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub btnMovetofirstrecordupbyone_Click(sender As Object, e As EventArgs) Handles btnMovetofirstrecordupbyone.Click
        GetStatementNoFirstRecupbyone()
    End Sub
End Class