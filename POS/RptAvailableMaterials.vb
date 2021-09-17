Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RptAvailableMaterials
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
                    product.ProductNo,
                    product.Description,
                    product.StocksOnHand,
                    product.UnitofIssue
                    FROM
                    product"
            cmd = New MySqlCommand(Query, MysqlConn)
            'cmd.Parameters.AddWithValue("@d1", txtItemNo.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("ProductNo").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("StocksOnHand").ToString)
                x.SubItems.Add(dr("UnitofIssue").ToString)
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BtnShowReport_Click(sender As Object, e As EventArgs) Handles BtnShowReport.Click
        Populatelistview()
        Dim Ds1 As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds1.Tables("AvailableStocks").NewRow()
            drow("ProductNo") = ListView1.Items(i).Text
            drow("Description") = ListView1.Items(i).SubItems(1).Text
            drow("StocksOnHand") = ListView1.Items(i).SubItems(2).Text
            drow("UnitofIssue") = ListView1.Items(i).SubItems(3).Text
            Ds1.Tables("AvailableStocks").Rows.Add(drow)
        Next i
        Dim freport As New RPTProductwise
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "RptAvailableStocks.rdlc")
        'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\joshua\Desktop\FinalMM\MM\POS\MaterialsReceivedPerSupplier.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds1.Tables("AvailableStocks")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        'Me.ShowDialog()
    End Sub
    Private Sub PopulateMaterials()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ProductNo, Description from Product Order By Description"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                cboSearchItem.Items.Add(dr("Description"))
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub PopulateItemNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT  ProductNo, Description from Product where Description = '" & cboSearchItem.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtItemNo.Text = dr("ProductNo")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub RptAvailableMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateMaterials()

    End Sub

    Private Sub cboSearchItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchItem.SelectedIndexChanged
        PopulateItemNo()
    End Sub
End Class