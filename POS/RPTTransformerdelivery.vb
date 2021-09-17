Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RPTTransformerdelivery
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
tbl_issuetransformer.SchemeID,
schemes.SchemeNo,
schemes.Scheme_Name,
schemes.Scheme_Ref_No,
tbl_issuetransformer.IssuetransformerId,
tbl_issuetransformer.RcvtransformerId,
tbl_issuetransformer.ItemNo,
tbl_issuetransformer.vehicleId,
tbl_issuetransformer.subcontractorId,
tbl_issuetransformer.Qty,
tbl_issuetransformer.DateIssued,
tbl_issuetransformer.IssuedBy,
tbl_issuetransformer.Delivery_No,
tbl_receivetransformer.RcvtransformerId,
tbl_receivetransformer.SNO,
tbl_receivetransformer.STFNO,
tbl_receivetransformer.GNO,
product.ProductNo,
product.Description,
product.UnitofIssue,
tbl_vehicles.vehiclesid,
tbl_vehicles.vehicle_no,
tbl_subcontractors.subcontractors_ID,
schemes.Substation_No,
tbl_subcontractors.subcontractor_Name
FROM
tbl_issuetransformer
INNER JOIN schemes ON tbl_issuetransformer.SchemeID = schemes.SchemeNo
INNER JOIN product ON tbl_issuetransformer.ItemNo = product.ProductNo AND product.ProductNo = tbl_issuetransformer.ItemNo
INNER JOIN tbl_vehicles ON tbl_vehicles.vehiclesid = tbl_issuetransformer.vehicleId
INNER JOIN tbl_receivetransformer ON tbl_receivetransformer.ItemNo = product.ProductNo AND tbl_receivetransformer.RcvtransformerId = tbl_issuetransformer.RcvtransformerId
INNER JOIN tbl_subcontractors ON tbl_issuetransformer.subcontractorId = tbl_subcontractors.subcontractors_ID WHERE Delivery_No = @d1 Group By ItemNo ORDER BY DateIssued"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", cboDeliveryNo.Text)
            'cmd.Parameters.AddWithValue("@dt1", DateTimePicker1.Value.ToString("MM/dd/yyyy"))
            'cmd.Parameters.AddWithValue("@dt2", DateTimePicker2.Value.ToString("MM/dd/yyyy"))
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("ItemNo").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("Qty").ToString)
                x.SubItems.Add(dr("DateIssued").ToString)
                x.SubItems.Add(dr("UnitofIssue").ToString)
                x.SubItems.Add(dr("Delivery_No").ToString)
                x.SubItems.Add(dr("Scheme_Name").ToString)
                x.SubItems.Add(dr("Scheme_Ref_No").ToString)
                x.SubItems.Add(dr("vehicle_no").ToString)
                x.SubItems.Add(dr("subcontractor_Name").ToString)
                x.SubItems.Add(dr("Substation_No").ToString)
                x.SubItems.Add(dr("SNO").ToString)
                x.SubItems.Add(dr("GNO").ToString)
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub RPTTransformerdelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeliveryNos()
    End Sub
    Private Sub DeliveryNos()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Delivery_No from tbl_issuetransformer order by Delivery_No  DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboDeliveryNo.Items.Clear()
            Do While dr.Read = True
                cboDeliveryNo.Items.Add(dr("Delivery_No"))
                'cboDeliveryNo.Text = "DeliveryNo"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BtnShowReport_Click(sender As Object, e As EventArgs) Handles BtnShowReport.Click
        If cboDeliveryNo.Text = "" Then
            MsgBox("Choose Delivery No")
            Exit Sub
        End If
        Populatelistview()
        Dim Ds As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds.Tables("Transformerdeliverynote").NewRow()
            drow("Item_No") = ListView1.Items(i).Text
            drow("Description") = ListView1.Items(i).SubItems(1).Text
            drow("Quantity") = ListView1.Items(i).SubItems(2).Text
            drow("Date_Issued") = ListView1.Items(i).SubItems(3).Text
            drow("UnitofIssue") = ListView1.Items(i).SubItems(4).Text
            drow("Delivery_No") = ListView1.Items(i).SubItems(5).Text
            drow("Scheme_Name") = ListView1.Items(i).SubItems(6).Text
            drow("Scheme_Ref_No") = ListView1.Items(i).SubItems(7).Text
            drow("vehicle_no") = ListView1.Items(i).SubItems(8).Text
            drow("subcontractor_Name") = ListView1.Items(i).SubItems(9).Text
            drow("Substation_No") = ListView1.Items(i).SubItems(10).Text
            drow("SNO") = ListView1.Items(i).SubItems(11).Text
            drow("GNO") = ListView1.Items(i).SubItems(12).Text
            Ds.Tables("Transformerdeliverynote").Rows.Add(drow)
        Next i
        Dim freport As New RptDailySalesReport
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        'Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "RPTTransformerdeliverynote.rdlc")
        Me.ReportViewer1.LocalReport.ReportPath = "D:\MM\MM\POS\RPTTransformerdeliverynote.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds.Tables("Transformerdeliverynote")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        'Me.ShowDialog()
    End Sub
End Class