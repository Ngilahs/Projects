Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmRole
    Dim y As Integer
    Private Sub AddRole()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtRoleName.Text = "" Or txtRoleDescription.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Add New Staff Role!")
        End If
        Try

            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_role (Role_Name, Role_Description) VALUES ('" & txtRoleName.Text & "', '" & txtRoleDescription.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Staff Role successfully added.", MsgBoxStyle.Information, "Add Staff Role")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtRoleName.Text, TimeOfDay, "Added New Staff Role")
    End Sub
    Private Sub UpdateRole()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtRoleName.Text = "" Or txtRoleDescription.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE tbl_role SET Role_Name= '" & txtRoleName.Text & "', Role_Description = '" & txtRoleDescription.Text & "' WHERE Role_ID = '" & lblRoleID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Role successfully updated.", MsgBoxStyle.Information, "Update Role")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblRoleID.Text, TimeOfDay, "Updated Staff Role Information")
    End Sub
    Private Sub ClearAll()
        txtRoleName.Text = ""
        txtRoleDescription.Text = ""
        lblRoleID.Text = ""
    End Sub
    Private Sub frmRole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PSaveToolStripButton5.Enabled = True
        PUpdateToolStripButton3.Enabled = False
    End Sub

    Private Sub txtStaffRoleName_TextChanged(sender As Object, e As EventArgs) Handles txtStaffRoleName.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Role_ID, Role_Name, Role_Description from tbl_role where Role_Name LIKE '" & txtStaffRoleName.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("Role_ID"), dr("Role_Name"), dr("Role_Description"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.lblRoleID.Text = dgw.Item(0, i).Value
        Me.txtRoleName.Text = dgw.Item(1, i).Value
        Me.txtRoleDescription.Text = dgw.Item(2, i).Value
        PSaveToolStripButton5.Enabled = False
        PUpdateToolStripButton3.Enabled = True
    End Sub

    Private Sub PSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles PSaveToolStripButton5.Click
        AddRole()
        ClearAll()

    End Sub

    Private Sub PUpdateToolStripButton3_Click(sender As Object, e As EventArgs) Handles PUpdateToolStripButton3.Click
        UpdateRole()
        ClearAll()
        PSaveToolStripButton5.Enabled = True
        PUpdateToolStripButton3.Enabled = False
    End Sub
End Class