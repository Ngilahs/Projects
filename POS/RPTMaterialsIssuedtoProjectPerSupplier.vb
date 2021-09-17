Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RPTMaterialsIssuedtoProjectPerSupplier
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
product.PrefSupplier,
suppliers.Supplier_ID,
suppliers.Supp_Name,
county.County_No,
county.County_Name,
constituency.Constituency_No,
constituency.constituency_Name,
schemes.SchemeNo,
schemes.Scheme_Ref_No,
delivery_details.ContractorId,
delivery_items.Delivery_No,
schemes.Scheme_Name,
sum(delivery_items.Qty_Issued) as Qty_Issued,
delivery_items.Date_Issued
FROM delivery_details
INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
INNER Join product ON delivery_items.Item_No = product.ProductNo
INNER Join suppliers ON product.PrefSupplier = suppliers.Supplier_ID
INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId
INNER Join constituency ON constituency.Constituency_No = delivery_details.ConstituencyId
INNER Join county ON county.County_No = delivery_details.CountyId where suppliers.Supplier_ID = '" & lblupplierId.Text & "' Group By Item_No, SchemeId"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("Item_No").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("Qty_Issued").ToString)
                x.SubItems.Add(dr("UnitofIssue").ToString)
                x.SubItems.Add(dr("Scheme_Name").ToString)
                x.SubItems.Add(dr("Scheme_Ref_No").ToString)
                x.SubItems.Add(dr("County_Name").ToString)
                x.SubItems.Add(dr("Supp_Name").ToString)
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub LoadMaterialsissuedtoprojectpersupplier()
        Populatelistview()
        Dim Ds1 As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds1.Tables("MaterialIssuedtoprojectpersupplier").NewRow()
            drow("Item_No") = ListView1.Items(i).Text
            drow("Description") = ListView1.Items(i).SubItems(1).Text
            drow("Qty_Issued") = ListView1.Items(i).SubItems(2).Text
            drow("UnitofIssue") = ListView1.Items(i).SubItems(3).Text
            drow("Scheme_Name") = ListView1.Items(i).SubItems(4).Text
            drow("Scheme_Ref_No") = ListView1.Items(i).SubItems(5).Text
            drow("County_Name") = ListView1.Items(i).SubItems(6).Text
            drow("Supp_Name") = ListView1.Items(i).SubItems(7).Text
            Ds1.Tables("MaterialIssuedtoprojectpersupplier").Rows.Add(drow)
        Next i
        Dim freport As New RPTMaterialIssueScheme
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "MaterialsIssuedtoprojectpersupplier.rdlc")
        'Me.ReportViewer1.LocalReport.ReportPath = "F:\DesktopB4Format\MM\POS\MaterialsIssuedtoprojectpersupplier.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds1.Tables("MaterialIssuedtoprojectpersupplier")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        'Me.ShowDialog()
    End Sub

    Private Sub LoadSupplierName()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Supplier_ID, Supp_Name from suppliers ORDER BY Supp_Name"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboSupplierName.Items.Clear()
            Do While dr.Read = True
                cboSupplierName.Items.Add(dr("Supp_Name"))
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub SupplierID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Supplier_ID, Supp_Name from suppliers where Supp_Name = '" & cboSupplierName.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblupplierId.Text = dr("Supplier_ID")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub RPTMaterialsIssuedtoProjectPerSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSupplierName()
    End Sub

    Private Sub BtnShowReport_Click(sender As Object, e As EventArgs) Handles BtnShowReport.Click
        LoadMaterialsissuedtoprojectpersupplier()
    End Sub

    Private Sub cboSupplierName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSupplierName.SelectedIndexChanged
        SupplierID()
    End Sub
End Class