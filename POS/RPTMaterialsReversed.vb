Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RPTMaterialsReversed
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
                    reverseddelivery.ReversedDeliveryID,
                    reverseddelivery.DeliveryNo,
                    reverseddelivery.ItemNo,
                    reverseddelivery.ReverseDate,
                    reverseddelivery.QtyReturned,
                    reverseddelivery.AuthorizedBy,
                    delivery_details.DeliveryNo,
                    delivery_details.SchemeId,
                    schemes.Scheme_Name,
                    schemes.SchemeNo,
                    product.ProductNo,
                    product.Description,
                    product.UnitofIssue
                    FROM
                    reverseddelivery
                    INNER JOIN delivery_details ON delivery_details.DeliveryNo = reverseddelivery.DeliveryNo
                    INNER JOIN schemes ON schemes.SchemeNo = delivery_details.SchemeId
                    INNER JOIN product ON product.ProductNo = reverseddelivery.ItemNo "
            cmd = New MySqlCommand(Query, MysqlConn)
            'cmd.Parameters.AddWithValue("@dt1", DateTimePicker1.Value.ToString) where reverseddelivery.ReverseDate between @dt1 and @dt2
            'cmd.Parameters.AddWithValue("@dt2", DateTimePicker2.Value.ToString)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("ReversedDeliveryID").ToString)
                x.SubItems.Add(dr("DeliveryNo").ToString)
                x.SubItems.Add(dr("ItemNo").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("QtyReturned").ToString)
                x.SubItems.Add(dr("UnitofIssue").ToString)
                x.SubItems.Add(dr("ReverseDate").ToString)
                x.SubItems.Add(dr("Scheme_Name").ToString)
                x.SubItems.Add(dr("AuthorizedBy").ToString)
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadMaterialsReversed()
        Populatelistview()
        Dim Ds As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds.Tables("ReversedMaterials").NewRow()
            drow("Reverse_No") = ListView1.Items(i).Text
            drow("Delivery_No") = ListView1.Items(i).SubItems(1).Text
            drow("Item_No") = ListView1.Items(i).SubItems(2).Text
            drow("Description") = ListView1.Items(i).SubItems(3).Text
            drow("Qty_Reversed") = ListView1.Items(i).SubItems(4).Text
            drow("UnitofIssue") = ListView1.Items(i).SubItems(5).Text
            drow("Date") = ListView1.Items(i).SubItems(6).Text
            drow("Scheme_Name") = ListView1.Items(i).SubItems(7).Text
            drow("Reversedby") = ListView1.Items(i).SubItems(8).Text
            Ds.Tables("ReversedMaterials").Rows.Add(drow)
        Next i
        Dim freport As New RptDailySalesReport
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "MaterialsReversedReport.rdlc")
        'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\joshua\Desktop\MM\POS\MaterialsReversedReport.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds.Tables("ReversedMaterials")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        'Me.ShowDialog()
    End Sub
    Private Sub RPTMaterialsReversed_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnShowReport_Click(sender As Object, e As EventArgs) Handles BtnShowReport.Click
        LoadMaterialsReversed()
    End Sub
End Class