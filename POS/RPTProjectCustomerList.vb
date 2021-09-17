Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RPTProjectCustomerList
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
                    INNER Join county ON county.County_No = schemes.County_Id"
            cmd = New MySqlCommand(Query, MysqlConn)
            'cmd.Parameters.AddWithValue("@d1", txtCounty.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("CustomerName").ToString)
                x.SubItems.Add(dr("IDNo").ToString)
                x.SubItems.Add(dr("PhoneNo").ToString)
                x.SubItems.Add(dr("PoleNo").ToString)
                x.SubItems.Add(dr("XCoordinate").ToString)
                x.SubItems.Add(dr("YCoordinate").ToString)
                x.SubItems.Add(dr("YRefNo").ToString)
                x.SubItems.Add(dr("WorkOrder").ToString)
                x.SubItems.Add(dr("MeterNo").ToString)
                x.SubItems.Add(dr("Earthing").ToString)
                x.SubItems.Add(dr("ConnectionStatus").ToString)
                x.SubItems.Add(dr("IssuanceStatus").ToString)
                x.SubItems.Add(dr("Remarks").ToString)
                x.SubItems.Add(dr("Scheme_Name").ToString)
                x.SubItems.Add(dr("constituency_Name").ToString)
                x.SubItems.Add(dr("County_Name").ToString)
                x.SubItems.Add(dr("Scheme_Ref_No").ToString)
                x.SubItems.Add(dr("Substation_No").ToString)
                x.SubItems.Add(("1").ToString)
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Dim dblTotal As Decimal = 0
        Dim dblTemp As Decimal
        For Each lvItem As ListViewItem In ListView1.Items
            If Decimal.TryParse(lvItem.SubItems(18).Text, dblTemp) Then
                dblTotal += dblTemp
            End If
        Next
        txtCountMeters.Text = dblTotal
    End Sub

    Private Sub LoadReport()
        Populatelistview()
        Dim Ds1 As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds1.Tables("CustomerList").NewRow()
            drow("CustomerName") = ListView1.Items(i).Text
            drow("IDNo") = ListView1.Items(i).SubItems(1).Text
            drow("PhoneNo") = ListView1.Items(i).SubItems(2).Text
            drow("PoleNo") = ListView1.Items(i).SubItems(3).Text
            drow("XCoordinate") = ListView1.Items(i).SubItems(4).Text
            drow("YCoordinate") = ListView1.Items(i).SubItems(5).Text
            drow("YRefNo") = ListView1.Items(i).SubItems(6).Text
            drow("WorkOrder") = ListView1.Items(i).SubItems(7).Text
            drow("MeterNo") = ListView1.Items(i).SubItems(8).Text
            drow("Earthing") = ListView1.Items(i).SubItems(9).Text
            drow("ConnectionStatus") = ListView1.Items(i).SubItems(10).Text
            drow("IssuanceStatus") = ListView1.Items(i).SubItems(11).Text
            drow("Remarks") = ListView1.Items(i).SubItems(12).Text
            drow("Scheme_Name") = ListView1.Items(i).SubItems(13).Text
            drow("constituency_Name") = ListView1.Items(i).SubItems(14).Text
            drow("County_Name") = ListView1.Items(i).SubItems(15).Text
            drow("Scheme_Ref_No") = ListView1.Items(i).SubItems(16).Text
            drow("Substation_No") = ListView1.Items(i).SubItems(17).Text
            'drow("1") = ListView1.Items(i).SubItems(17).Text
            Ds1.Tables("CustomerList").Rows.Add(drow)
        Next i
        Dim freport As New RPTMaterialIssueScheme
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        'Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "RPTProjectCustomerList.rdlc")
        Me.ReportViewer1.LocalReport.ReportPath = "F:\DesktopB4Format\MM\POS\RPTProjectCustomerList.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds1.Tables("CustomerList")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Dim rptparameter As ReportParameter
        rptparameter = New ReportParameter("TotalMeters", txtCountMeters.Text)
        Me.ReportViewer1.LocalReport.SetParameters(rptparameter)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub RPTProjectCustomerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTNLoadMeterlistreport_Click(sender As Object, e As EventArgs) Handles BTNLoadMeterlistreport.Click
        LoadReport()
    End Sub
End Class