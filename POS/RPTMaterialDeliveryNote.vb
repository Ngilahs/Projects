Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Configuration
Public Class RPTMaterialDeliveryNote
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
delivery_details.DeliveryNo,
delivery_details.IssueDate,
delivery_details.ItemCount,
delivery_details.SchemeId,
delivery_details.VehicleID,
delivery_items.Delivery_No,
delivery_items.Item_No,
delivery_items.Qty_Issued,
delivery_items.DocumentNo,
schemes.SchemeNo,
schemes.Scheme_Ref_No,
schemes.Scheme_Name,
schemes.Substation_No,
product.ProductNo,
product.Description,
product.UnitofIssue,
tbl_subcontractors.subcontractors_ID,
tbl_subcontractors.subcontractor_Name,
tbl_vehicles.vehiclesid,
tbl_vehicles.vehicle_no
FROM
delivery_details
INNER JOIN delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
INNER JOIN tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = delivery_details.ContractorId
INNER JOIN schemes ON delivery_details.SchemeId = schemes.SchemeNo
INNER JOIN product ON product.ProductNo = delivery_items.Item_No
INNER JOIN tbl_vehicles ON tbl_vehicles.vehiclesid = delivery_details.VehicleID WHERE Delivery_No = @d1 Group By Item_No ORDER BY Date_Issued"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", cboDeliveryNo.Text)
            'cmd.Parameters.AddWithValue("@dt1", DateTimePicker1.Value.ToString("MM/dd/yyyy"))
            'cmd.Parameters.AddWithValue("@dt2", DateTimePicker2.Value.ToString("MM/dd/yyyy"))
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("Item_No").ToString)
                x.SubItems.Add(dr("Description").ToString)
                x.SubItems.Add(dr("Qty_Issued").ToString)
                x.SubItems.Add(dr("IssueDate").ToString)
                x.SubItems.Add(dr("UnitofIssue").ToString)
                x.SubItems.Add(dr("Delivery_No").ToString)
                x.SubItems.Add(dr("Scheme_Name").ToString)
                x.SubItems.Add(dr("Scheme_Ref_No").ToString)
                x.SubItems.Add(dr("vehicle_no").ToString)
                x.SubItems.Add(dr("subcontractor_Name").ToString)
                x.SubItems.Add(dr("Substation_No").ToString)

                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Sum  daily sales
        Dim dblTotal As Decimal = 0
        Dim dblTemp As Decimal
        For Each lvItem As ListViewItem In ListView1.Items
            If Decimal.TryParse(lvItem.SubItems(2).Text, dblTemp) Then
                dblTotal += dblTemp
            End If
        Next
        txtSumTotalAmt.Text = dblTotal

        'calculate quantity of items sold

        Dim dblTotals As Double = 0
        Dim dblTemps As Double

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
            Query = "SELECT DeliveryNo, Status from delivery_details where Status = '1' and CancelStatus = '0' ORDER BY DeliveryNo DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboDeliveryNo.Items.Clear()
            Do While dr.Read = True
                cboDeliveryNo.Items.Add(dr("DeliveryNo"))
                'cboDeliveryNo.Text = "DeliveryNo"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub btnPrintreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowReport.Click
        If cboDeliveryNo.Text = "" Then
            MsgBox("Choose Delivery No")
            Exit Sub
        End If
        Populatelistview()
        Dim Ds As New DataSet1
        Dim drow As DataRow
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            drow = Ds.Tables("DailySalesdataTable").NewRow()
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
            Ds.Tables("DailySalesdataTable").Rows.Add(drow)
        Next i
        Dim freport As New RptDailySalesReport
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Dim exeFolder As String = Application.StartupPath
        Me.ReportViewer1.LocalReport.ReportPath = Path.Combine(exeFolder, "MaterialsDeliveryNotetoScheme.rdlc")
        'Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\joshua\Desktop\MM\POS\MaterialDeliveryNote.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Ds.Tables("DailySalesdataTable")))
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        'Me.ShowDialog()
    End Sub
    Private Sub frmTestReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DeliveryNos()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub frmTestReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Public Sub GetLastDeliveryNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT DeliveryNo, Status from delivery_details where Status = '1' and CancelStatus = '0' ORDER BY DeliveryNo DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                cboDeliveryNo.Text = dr("DeliveryNo")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub GetDeliveryNoUpbyOneRec()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT DeliveryNo, Status from delivery_details where Status = '1' and CancelStatus = '0' ORDER BY DeliveryNo DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                cboDeliveryNo.Text = dr("DeliveryNo") - 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub GetFirstDeliveryNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT DeliveryNo, Status from delivery_details where Status = '1' and CancelStatus = '0' ORDER BY DeliveryNo ASC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                cboDeliveryNo.Text = dr("DeliveryNo")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub GetDelievryNoFirstRecupbyone()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT DeliveryNo, Status from delivery_details where Status = '1' and CancelStatus = '0' ORDER BY DeliveryNo ASC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                cboDeliveryNo.Text = dr("DeliveryNo") + 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnMoveFirstRecord_Click(sender As Object, e As EventArgs) Handles btnMoveFirstRecord.Click
        GetFirstDeliveryNo()
    End Sub

    Private Sub btnMovetofirstrecordupbyone_Click(sender As Object, e As EventArgs) Handles btnMovetofirstrecordupbyone.Click
        GetDelievryNoFirstRecupbyone()
    End Sub

    Private Sub btnMoveUpOnerecord_Click(sender As Object, e As EventArgs) Handles btnMoveUpOnerecord.Click
        GetDeliveryNoUpbyOneRec()
    End Sub

    Private Sub btnMovetoLastrecord_Click(sender As Object, e As EventArgs) Handles btnMovetoLastrecord.Click
        GetLastDeliveryNo()
    End Sub
End Class