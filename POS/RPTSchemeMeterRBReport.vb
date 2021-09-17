Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RPTSchemeMeterRBReport
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
                    tbl_billingdetails.BillingDate,
                    tbl_billingdetails.TotalAmt,
                    tbl_billingdetails.TotalVat,
                    tbl_billingdetails.TotalIncVat,
                    tbl_billingitems.BillingID,
                    tbl_billingitems.ItemNo,
                    tbl_billingitems.Qty,
                    tbl_billingitems.Total,
                    tbl_billingparameters.ItemNo,
                    tbl_billingparameters.Description,
                    tbl_billingparameters.UoM,
                    tbl_billingparameters.UnitRate,
                    tbl_billingparameters.subcatID,
                    subcategory.SubcategoryName,
                    schemes.Scheme_Ref_No,
                    schemes.Scheme_Name,
                    tbl_subcontractors.Location,
                    tbl_subcontractors.Phone_No,
                    tbl_subcontractors.Address,
                    tbl_subcontractors.subcontractor_Name 
                    FROM
                    tbl_billingdetails
                    INNER Join tbl_billingitems ON tbl_billingitems.BillingID = tbl_billingdetails.BillingdetailID
                    INNER Join tbl_billingparameters ON tbl_billingitems.ItemNo = tbl_billingparameters.ItemNo
                    INNER Join schemes ON tbl_billingdetails.SchemeID = schemes.SchemeNo
                     INNER Join tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = tbl_billingdetails.Sub_contractorID
                    INNER Join subcategory ON subcategory.SubcategoryID = tbl_billingparameters.subcatID where SchemeID = @d1 and subcatID = 4 and  tbl_billingdetails.BillingDate Between @dt2 and @dt3 order by BillingdetailID"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtschemeid.Text)
            cmd.Parameters.AddWithValue("@dt2", dtpDateFrom.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dt3", dtpDateTo.Value.ToString("MM/dd/yyyy"))
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
                x.SubItems.Add(dr("BillingDate").ToString)
                x.SubItems.Add(dr("TotalAmt").ToString)
                x.SubItems.Add(dr("TotalVat").ToString)
                x.SubItems.Add(dr("TotalIncVat").ToString)
                x.SubItems.Add(dr("Location").ToString)
                x.SubItems.Add(dr("Phone_No").ToString)
                x.SubItems.Add(dr("Address").ToString)
                x.SubItems.Add(dr("SubcategoryName").ToString)
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadMeteringStatement()
        Populatelistview()
        If txtschemeid.Text = "" Then
            MessageBox.Show("Please select Scheme", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Populatelistview()
        Dim Ds As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds.Tables("MeteringStatement").NewRow()
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
            drow("BillingDate") = ListView1.Items(i).SubItems(10).Text
            drow("TotalAmt") = ListView1.Items(i).SubItems(11).Text
            drow("TotalVat") = ListView1.Items(i).SubItems(12).Text
            drow("TotalIncVat") = ListView1.Items(i).SubItems(13).Text
            drow("Location") = ListView1.Items(i).SubItems(14).Text
            drow("Phone_No") = ListView1.Items(i).SubItems(15).Text
            drow("Address") = ListView1.Items(i).SubItems(16).Text
            drow("SubcategoryName") = ListView1.Items(i).SubItems(17).Text
            Ds.Tables("MeteringStatement").Rows.Add(drow)
        Next i
        Dim freport As New RptDailySalesReport
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        'Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "RPTMeteringStatement.rdlc")
        Me.ReportViewer1.LocalReport.ReportPath = "F:\DesktopB4Format\MM\POS\RPTMeteringStatement.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds.Tables("MeteringStatement")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub LoadSchemeName()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Scheme_Name, Scheme_Ref_No, SchemeNo from schemes ORDER BY Scheme_Name"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboSchemeName.Items.Clear()
            Do While dr.Read = True
                cboSchemeName.Items.Add(dr("Scheme_Name"))

            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub SchemeID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SchemeNo, Scheme_Name, Scheme_Ref_No from Schemes where Scheme_Name = '" & cboSchemeName.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtschemeid.Text = dr("SchemeNo")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub RPTSchemeMeterRBReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSchemeName()
    End Sub

    Private Sub BtnShowReport_Click(sender As Object, e As EventArgs) Handles BtnShowReport.Click
        LoadMeteringStatement()
    End Sub

    Private Sub cboschemename_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboschemename.SelectedIndexChanged
        SchemeID()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class