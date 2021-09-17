Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RPTMaterialIssuanceCounty
    Public Sub Populatelistview()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
delivery_details.CountyId,
delivery_details.ConstituencyId,
delivery_items.Item_No,
product.ProductNo,
product.Description,
product.UnitofIssue,
county.County_No,
county.County_Name,
constituency.Constituency_No,
constituency.constituency_Name,
schemes.SchemeNo,
schemes.Scheme_Ref_No,
delivery_items.Delivery_No,
schemes.Scheme_Name,
delivery_items.Qty_Issued,
delivery_items.Date_Issued
FROM delivery_details
INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
INNER Join product ON delivery_items.Item_No = product.ProductNo
INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId
INNER Join constituency ON constituency.Constituency_No = delivery_details.ConstituencyId
INNER Join county ON county.County_No = delivery_details.CountyId Where County_No = @d3"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d3", txtCounty.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("Delivery_No").ToString)
                x.SubItems.Add(dr("Item_No").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("Qty_Issued").ToString)
                x.SubItems.Add(dr("UnitofIssue").ToString)
                x.SubItems.Add(dr("Date_Issued").ToString)
                x.SubItems.Add(dr("County_Name").ToString)
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub LoadCountyName()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT County_No, County_Name from county ORDER BY County_Name"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboCounty.Items.Clear()
            Do While dr.Read = True
                cboCounty.Items.Add(dr("County_Name"))
                'cboDeliveryNo.Text = "DeliveryNo"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub CountyID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT County_No, County_Name from county where County_Name = '" & cboCounty.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtCounty.Text = dr("County_No")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub RPTMaterialIssuanceCounty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCountyName()
    End Sub

    Private Sub LoadIssuancePerCountyReport()
        Populatelistview()
        Dim Ds1 As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds1.Tables("MaterialsPerCounty").NewRow()
            drow("Delivery_No") = ListView1.Items(i).Text
            drow("Item_No") = ListView1.Items(i).SubItems(1).Text
            drow("Description") = ListView1.Items(i).SubItems(2).Text
            drow("Qty_Issued") = ListView1.Items(i).SubItems(3).Text
            drow("UnitofIssue") = ListView1.Items(i).SubItems(4).Text
            drow("Date_Issued") = ListView1.Items(i).SubItems(5).Text
            drow("County_Name") = ListView1.Items(i).SubItems(6).Text
            Ds1.Tables("MaterialsPerCounty").Rows.Add(drow)
        Next i
        Dim freport As New RPTMaterialIssueScheme
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "MaterialIssuancepercounty.rdlc")
        'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\joshua\Desktop\MM\POS\MaterialIssuancepercounty.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds1.Tables("MaterialsPerCounty")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        'Me.ShowDialog()
    End Sub
    Private Sub cboCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCounty.SelectedIndexChanged
        CountyID()
    End Sub

    Private Sub BTNLoadExpensereport_Click(sender As Object, e As EventArgs) Handles BTNLoadExpensereport.Click
        LoadIssuancePerCountyReport()
    End Sub
End Class