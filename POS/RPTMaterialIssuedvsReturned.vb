Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RPTMaterialIssuedvsReturned
    Public Sub Populatelistview()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT product.ProductNo,
product.Description,
product.UnitofIssue,
delivery_items_2.Delivery_No,
delivery_items_2.Item_No,
delivery_items.Delivery_No,
delivery_items.Item_No,
delivery_items_2.Qty_Issued AS Original_Qty_Issued,
delivery_items.Qty_Issued as Qty_Consumed,
sum(reverseddelivery.QtyReturned) as QtyReturned,
delivery_details.DeliveryNo,
delivery_details.IssueDate,
delivery_details.SchemeId,
reverseddelivery.DeliveryNo,
reverseddelivery.ItemNo,
tbl_subcontractors.subcontractors_ID,
tbl_subcontractors.subcontractor_Name,
delivery_details.ContractorId
FROM
delivery_items_2
INNER JOIN delivery_items ON delivery_items.Delivery_No = delivery_items_2.Delivery_No
INNER JOIN delivery_details ON delivery_details.DeliveryNo = delivery_items.Delivery_No
INNER JOIN reverseddelivery ON reverseddelivery.DeliveryNo = delivery_details.DeliveryNo
INNER JOIN product ON product.ProductNo = reverseddelivery.ItemNo AND product.ProductNo = reverseddelivery.ItemNo AND product.ProductNo = delivery_items.Item_No AND product.ProductNo = delivery_items_2.Item_No
INNER JOIN tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = delivery_details.ContractorId GROUP BY reverseddelivery.DeliveryNo, reverseddelivery.ItemNo"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("Delivery_No").ToString)
                x.SubItems.Add(dr("Item_No").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("Original_Qty_Issued").ToString)
                x.SubItems.Add(dr("QtyReturned").ToString)
                x.SubItems.Add(dr("Qty_Consumed").ToString)
                x.SubItems.Add(dr("UnitofIssue").ToString)
                x.SubItems.Add(dr("subcontractor_Name").ToString)
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadExpensesReport()
        Populatelistview()
        Dim Ds1 As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds1.Tables("MaterialIssuedvsReturned").NewRow()
            drow("Delivery_No") = ListView1.Items(i).Text
            drow("Item_No") = ListView1.Items(i).SubItems(1).Text
            drow("Description") = ListView1.Items(i).SubItems(2).Text
            drow("Original_Qty_Issued") = ListView1.Items(i).SubItems(3).Text
            drow("QtyReturned") = ListView1.Items(i).SubItems(4).Text
            drow("Qty_Consumed") = ListView1.Items(i).SubItems(5).Text
            drow("UnitofIssue") = ListView1.Items(i).SubItems(6).Text
            drow("subcontractor_Name") = ListView1.Items(i).SubItems(7).Text
            Ds1.Tables("MaterialIssuedvsReturned").Rows.Add(drow)
        Next i
        Dim freport As New RPTMaterialIssueScheme
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "MaterialIssuedReturnedConsumed.rdlc")
        'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\joshua\Desktop\MM\POS\MaterialIssuanceperscheme.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds1.Tables("MaterialIssuedvsReturned")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        'Me.ShowDialog()
    End Sub

    Private Sub BTNLoadExpensereport_Click(sender As Object, e As EventArgs) Handles BTNLoadExpensereport.Click
        LoadExpensesReport()
    End Sub

    'Private Sub LoadSchemeName()
    '    Dim MysqlConn As MySqlConnection
    '    Dim cmd As MySqlCommand
    '    MysqlConn = New MySqlConnection
    '    MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
    '    Dim dr As MySqlDataReader
    '    Try
    '        MysqlConn.Open()
    '        Dim Query As String
    '        Query = "SELECT Scheme_Name, Scheme_Ref_No, SchemeNo from schemes ORDER BY Scheme_Name"
    '        cmd = New MySqlCommand(Query, MysqlConn)
    '        dr = cmd.ExecuteReader
    '        cboSchemeName.Items.Clear()
    '        Do While dr.Read = True
    '            cboSchemeName.Items.Add(dr("Scheme_Name"))
    '        Loop
    '        MysqlConn.Close()
    '    Catch ex As MySqlException
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        MysqlConn.Dispose()
    '    End Try
    'End Sub

    'Private Sub SchemeID()
    '    Dim MysqlConn As MySqlConnection
    '    Dim cmd As MySqlCommand
    '    MysqlConn = New MySqlConnection
    '    MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
    '    Dim dr As MySqlDataReader
    '    Try
    '        MysqlConn.Open()
    '        Dim Query As String
    '        Query = "SELECT SchemeNo, Scheme_Name, Scheme_Ref_No from Schemes where Scheme_Name = '" & cboSchemeName.Text & "'"
    '        cmd = New MySqlCommand(Query, MysqlConn)
    '        dr = cmd.ExecuteReader
    '        If dr.Read = True Then
    '            txtSchemeID.Text = dr("SchemeNo")
    '        End If
    '        MysqlConn.Close()
    '    Catch ex As MySqlException
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        MysqlConn.Dispose()
    '    End Try
    'End Sub

    Private Sub RPTMaterialIssuedvsReturned_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadSchemeName()
    End Sub

    Private Sub cboSchemeName_SelectedIndexChanged(sender As Object, e As EventArgs)
        'SchemeID()
    End Sub
End Class