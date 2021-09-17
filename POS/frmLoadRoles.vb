Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLoadRoles

    Private Sub LoadRoles()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM tbl_role ORDER BY Role_Name Desc"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("Role_ID").ToString)
                x.SubItems.Add(dr("Role_Name"))
                x.SubItems.Add(dr("Role_Description"))

                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmLoadRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoles()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        frmEmployees.txtRolename.Text = ListView1.FocusedItem.SubItems(1).Text
        frmEmployees.LBLRoleID.Text = ListView1.FocusedItem.SubItems(0).Text
        Me.Close()
    End Sub
End Class