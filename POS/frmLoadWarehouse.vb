Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLoadWarehouse
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

    Private Sub txtwarehousename_TextChanged(sender As Object, e As EventArgs) Handles txtwarehousename.TextChanged
        LoadWarehouse()
    End Sub
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Me.Close()
    End Sub
End Class