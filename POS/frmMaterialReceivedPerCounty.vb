Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class frmMaterialReceivedPerCounty
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
                        county.County_Name,
                        schemes.County_Id,
                        stockindetails.SchemeID,
                        Sum(stockin.Quantity) as Quantity,
                        stockin.PNO,
                        product.Description,
                        county.County_No,
                        schemes.SchemeNo,
                        suppliers.Supp_Name,
                        stockindetails.StockInDetailID,
                        stockindetails.SuppID,
                        stockin.StockInID
                        FROM
                        stockin
                        INNER JOIN stockindetails ON stockin.StockInID = stockindetails.StockInDetailID
                        INNER JOIN schemes ON stockindetails.SchemeID = schemes.SchemeNo
                        INNER JOIN product ON product.ProductNo = stockin.PNO
                        INNER JOIN suppliers ON stockindetails.SuppID = suppliers.Supplier_ID
                        INNER JOIN county ON schemes.County_Id = county.County_No Where County_No = @d3 Group By PNO"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d3", txtCounty.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("PNO").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("Quantity").ToString)
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
    Private Sub LoadMaterialsReceivedPerCounty()
        Populatelistview()
        Dim Ds1 As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds1.Tables("MaterialReceivedPerCounty").NewRow()
            drow("PNO") = ListView1.Items(i).Text
            drow("Description") = ListView1.Items(i).SubItems(1).Text
            drow("Quantity") = ListView1.Items(i).SubItems(2).Text
            drow("County_Name") = ListView1.Items(i).SubItems(3).Text
            drow("Supp_Name") = ListView1.Items(i).SubItems(4).Text
            Ds1.Tables("MaterialReceivedPerCounty").Rows.Add(drow)
        Next i
        Dim freport As New RPTProductwise
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "MaterialReceivedReportPerCounty.rdlc")
        'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\joshua\Desktop\FinalMM\MM\POS\MaterialsReceivedPerSupplier.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds1.Tables("MaterialReceivedPerCounty")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
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
            Query = "SELECT County_No, County_Name from county ORDER BY County_Name DESC LIMIT 100"
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

    Private Sub frmMaterialReceivedPerCounty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCountyName()
    End Sub

    Private Sub cboCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCounty.SelectedIndexChanged
        CountyID()
    End Sub

    Private Sub BtnShowReport_Click(sender As Object, e As EventArgs) Handles BtnShowReport.Click
        LoadMaterialsReceivedPerCounty()
    End Sub

End Class