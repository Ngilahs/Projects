Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmEmployees
    Dim y As Integer
    Private Sub AddStaff()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            If txtStaffName.Text = "" Or txtPhoneNo.Text = "" Or txtnationalIDNo.Text = "" Then
                MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Add Staff!")
                Exit Sub
            Else
                MysqlConn.Open()
                Dim Query As String
                Query = "INSERT INTO tbl_employees(Employee_Name, Role_Id, Id_No, Phone_No) VALUES ('" & txtStaffName.Text & "', '" & LBLRoleID.Text & "', '" & txtPhoneNo.Text & "', '" & txtnationalIDNo.Text & "')"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MsgBox("Staff successfully added.", MsgBoxStyle.Information, "Add Staff")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, LBLRoleID.Text, TimeOfDay, "Added New Staff")
        Clearall()
        txtStaffName.Focus()
    End Sub
    Private Sub UpdateStaff()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader

        Try
            If txtStaffName.Text = "" Or txtPhoneNo.Text = "" Or txtnationalIDNo.Text = "" Then
                MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Update Staff!")
                Exit Sub
            Else

                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE tbl_employees SET Employee_Name = '" & txtStaffName.Text & "', Role_Id = '" & LBLRoleID.Text & "', Phone_No = '" & txtPhoneNo.Text & "', Id_No ='" & txtnationalIDNo.Text & "' WHERE Employee_ID = '" & lblStaffNo.Text & "'"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MsgBox("Staff successfully Updated.", MsgBoxStyle.Information, "Update Staff")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtnationalIDNo.Text, TimeOfDay, "Updated Staff")
        Clearall()
        txtStaffName.Focus()
    End Sub
    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PSaveToolStripButton5.Enabled = True
        PUpdateToolStripButton3.Enabled = False
    End Sub
    Private Sub Clearall()
        txtStaffName.Text = ""
        LBLRoleID.Text = ""
        txtPhoneNo.Text = ""
        txtnationalIDNo.Text = ""
        LBLRoleID.Text = ""
        txtRolename.Text = ""
    End Sub

    Private Sub txtpdes_TextChanged(sender As Object, e As EventArgs) Handles txtstaffs.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT E.Employee_ID, E.Employee_Name, E.Role_Id, E.Id_No, E.Phone_No, E.Location, E.County, E.Next_of_Kin, E.Next_of_kin_phoneNo, R.Role_Name from tbl_employees E INNER JOIN tbl_role R on (E.Role_Id = R.Role_ID) where E.Employee_Name LIKE '%" & txtstaffs.Text & "%' ORDER BY Employee_Name DESC LIMIT 200"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("Employee_ID"), dr("Employee_Name"), dr("Role_Name"), dr("Role_Id"), dr("Phone_No"), dr("Id_No"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmLoadRoles.ShowDialog()
    End Sub

    Private Sub PSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles PSaveToolStripButton5.Click
        AddStaff()
        Clearall()
    End Sub
    Private Sub PUpdateToolStripButton3_Click(sender As Object, e As EventArgs) Handles PUpdateToolStripButton3.Click
        UpdateStaff()
        PSaveToolStripButton5.Enabled = True
        PUpdateToolStripButton3.Enabled = False
        Clearall()
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.lblStaffNo.Text = dgw.Item(0, i).Value
        Me.txtStaffName.Text = dgw.Item(1, i).Value
        Me.txtRolename.Text = dgw.Item(2, i).Value
        Me.LBLRoleID.Text = dgw.Item(3, i).Value
        Me.txtPhoneNo.Text = dgw.Item(4, i).Value
        Me.txtnationalIDNo.Text = dgw.Item(5, i).Value
        PSaveToolStripButton5.Enabled = False
        PUpdateToolStripButton3.Enabled = True
        dgw.Rows.Clear()
        txtstaffs.Text = ""
    End Sub
    Private Sub txtPhoneNo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhoneNo.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtnationalIDNo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnationalIDNo.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtKinPhoneNo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class