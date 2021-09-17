Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLodWarehouse
    Private Sub LoadWarehouse()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT warehouseId, warehousename from tbl_warehouse where  warehousename LIKE '%" & txtwarehousename.Text & "%' ORDER BY  warehousename"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("warehouseId").ToString)
                x.SubItems.Add(dr("warehousename"))
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmLodWarehouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        frmReceiveMeters.txtwarehouseID.Text = ListView1.FocusedItem.SubItems(0).Text
        frmReceiveMeters.txtWarehouseName.Text = ListView1.FocusedItem.SubItems(1).Text
        frmIssueMeters.txtwarehouseID.Text = ListView1.FocusedItem.SubItems(0).Text
        frmIssueMeters.txtWarehouseName.Text = ListView1.FocusedItem.SubItems(1).Text

        Me.Close()
    End Sub

    Private Sub txtwarehousename_TextChanged(sender As Object, e As EventArgs) Handles txtwarehousename.TextChanged
        LoadWarehouse()
    End Sub
End Class