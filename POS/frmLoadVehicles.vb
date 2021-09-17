Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLoadVehicles
    Private Sub LoadVehicle()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT vehiclesid, vehicle_no from tbl_vehicles where vehicle_no LIKE '%" & txtvehicleRegNo.Text & "%' ORDER BY vehicle_no"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("vehiclesid").ToString)
                x.SubItems.Add(dr("vehicle_no"))
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmLoadVehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadVehicle()
    End Sub
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        frmTransporterRegister.txtVehicleId.Text = ListView1.FocusedItem.SubItems(0).Text
        frmTransporterRegister.txtvehicleRegNo.Text = ListView1.FocusedItem.SubItems(1).Text
        frmTransportRegisterUpdate.txtVehicleId.Text = ListView1.FocusedItem.SubItems(0).Text
        frmTransportRegisterUpdate.txtvehicleRegNo.Text = ListView1.FocusedItem.SubItems(1).Text
        frmIssueTransformer.txtVehicleID.Text = ListView1.FocusedItem.SubItems(0).Text
        frmIssueTransformer.cboVehicleNo.Text = ListView1.FocusedItem.SubItems(1).Text
        frmIssueTransformer.txtVehicleID1.Text = ListView1.FocusedItem.SubItems(0).Text
        frmIssueTransformer.cboVehicleNo1.Text = ListView1.FocusedItem.SubItems(1).Text
        Me.Close()
    End Sub

    Private Sub txtvehicleRegNo_TextChanged(sender As Object, e As EventArgs) Handles txtvehicleRegNo.TextChanged
        LoadVehicle()
    End Sub
End Class