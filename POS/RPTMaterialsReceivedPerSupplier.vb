Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration

Public Class RPTMaterialsReceivedPerSupplier
    Public Sub Populatelistview()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select stockin.StockInID,
                    product.Description,
                    stockin.PNO,
                    stockin.Quantity,
                    stockin.DateIn,
                    stockin.Supplier_Name,
                    stockindetails.StockInDetailID,
                    stockindetails.SuppID,
                    stockindetails.ReceivedBy,
                    suppliers.Supp_Name,
                    stockindetails.DateIn
                    FROM
                    product
                    INNER JOIN stockin ON stockin.PNO = product.ProductNo
                    INNER JOIN stockindetails ON stockin.StockInID = stockindetails.StockInDetailID
                    INNER JOIN suppliers ON stockindetails.SuppID = suppliers.Supplier_ID where stockindetails.SuppID = @dt1 Order By stockin.StockInID ASC"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@dt1", lblupplierId.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("StockInID").ToString)
                x.SubItems.Add(dr("PNO").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("Quantity").ToString)
                x.SubItems.Add(dr("DateIn").ToString)
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

    Private Sub RPTMaterialsReceivedPerSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSupplierName()
    End Sub

    Private Sub cboSupplierName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSupplierName.SelectedIndexChanged
        SupplierID()
    End Sub

    Private Sub BtnShowReport_Click(sender As Object, e As EventArgs) Handles BtnShowReport.Click
        Populatelistview()
        Dim Ds1 As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds1.Tables("MaterialsReceivedPerDate").NewRow()
            drow("StockInID") = ListView1.Items(i).Text
            drow("PNO") = ListView1.Items(i).SubItems(1).Text
            drow("Description") = ListView1.Items(i).SubItems(2).Text
            drow("Quantity") = ListView1.Items(i).SubItems(3).Text
            drow("DateIn") = ListView1.Items(i).SubItems(4).Text
            drow("Supp_Name") = ListView1.Items(i).SubItems(5).Text
            Ds1.Tables("MaterialsReceivedPerDate").Rows.Add(drow)
        Next i
        Dim freport As New RPTProductwise
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "MaterialsReceivedPerSupplier.rdlc")
        'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\joshua\Desktop\FinalMM\MM\POS\MaterialsReceivedPerSupplier.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds1.Tables("MaterialsReceivedPerDate")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        'Me.ShowDialog()
    End Sub
End Class