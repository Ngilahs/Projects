Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class frmAddUpdateStaff
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Dim y As Integer
    Private Sub GetStaffID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT StaffID FROM STAFF ORDER BY StaffID DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblSupplierID.Text = dr("StaffID") + 1
            Else
                lblSupplierID.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub AddStaff()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If lblSupplierID.Text = "" Or txtLastname.Text = "" Or txtFirstname.Text = "" Or txtnationalID.Text = "" Or txtCounty.Text = "" Or txtContractNo.Text = "" Or txtUsername.Text = "" Or txtRole.Text = "" Or txtPassword.Text = "" Or txtConfirmPWD.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLastname.Focus()
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO STAFF(Lastname, Firstname, NationalID, County, ContactNo, Username, Role, UPassword) VALUES('" & txtLastname.Text & "', '" & txtFirstname.Text & "', '" & txtnationalID.Text & "', '" & txtCounty.Text & "', '" & txtContractNo.Text & "', '" & txtUsername.Text & "', '" & txtRole.Text & "', '" & txtPassword.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("New staff successfully added.", MsgBoxStyle.Information, "Add Staff")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtLastname.Text, TimeOfDay, "Added New Staff")
        AllClearFields()
        GetStaffID()
    End Sub
    Private Sub UpdateStaff()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If lblSupplierID.Text = "" Or txtLastname.Text = "" Or txtFirstname.Text = "" Or txtnationalID.Text = "" Or txtCounty.Text = "" Or txtContractNo.Text = "" Or txtUsername.Text = "" Or txtRole.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLastname.Focus()
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update STAFF SET Lastname = '" & txtLastname.Text & "', Firstname = '" & txtFirstname.Text & "', NationalID = '" & txtnationalID.Text & "', County = '" & txtCounty.Text & "', ContactNo = '" & txtContractNo.Text & "', Username ='" & txtUsername.Text & "', Role = '" & txtRole.Text & "', UPassword = '" & txtPassword.Text & "' WHERE StaffID = '" & lblSupplierID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Staff record successfully updated", MsgBoxStyle.Information, "Update Staff")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtLastname.Text, TimeOfDay, "Updated Staff Information")
        AllClearFields()
        dgw.Rows.Clear()
        GetStaffID()
    End Sub
    Private Sub PopulateRoles()
        txtRole.Items.Clear()
        txtRole.Items.Add("Administrator")
        txtRole.Items.Add("Supervisor")
        txtRole.Items.Add("Technical")
        txtRole.Items.Add("Human Resources")
        txtRole.Items.Add("Finance")
        txtRole.Items.Add("Operations")
        txtRole.Items.Add("IT")
        txtRole.Items.Add("Admin")

    End Sub
    Private Sub LoadUpdateStaff()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM STAFF WHERE StaffID = '" & frmStaff.ListView1.FocusedItem.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblSupplierID.Text = dr("StaffID")
                txtLastname.Text = dr("lastname")
                txtFirstname.Text = dr("Firstname")
                txtnationalID.Text = dr("NationalID")
                txtCounty.Text = dr("County")
                txtContractNo.Text = dr("ContactNo")
                txtUsername.Text = dr("username")
                txtRole.Text = dr("Role")
                txtPassword.Text = dr("UPassword")
                txtConfirmPWD.Text = dr("UPassword")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ClearFields()
        'lblSupplierID.Text = ""
        txtLastname.Text = ""
        txtFirstname.Text = ""
        txtnationalID.Text = ""
        txtCounty.Text = ""
        txtContractNo.Text = ""
        txtUsername.Text = ""
        txtRole.Text = ""
        txtPassword.Text = ""
        txtConfirmPWD.Text = ""
    End Sub
    Private Sub AllClearFields()
        lblSupplierID.Text = ""
        txtLastname.Text = ""
        txtFirstname.Text = ""
        txtnationalID.Text = ""
        txtCounty.Text = ""
        txtContractNo.Text = ""
        txtUsername.Text = ""
        txtRole.Text = ""
        txtPassword.Text = ""
        txtConfirmPWD.Text = ""
    End Sub


    Private Sub frmAddUpdateStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearFields()
        GetStaffID()
        PopulateRoles()
        AUSaveToolStripButton5.Enabled = True
        AUUpdateToolStripButton3.Enabled = False
    End Sub
    Private Sub frmAddUpdateStaff_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AUSaveToolStripButton5.Click
        AddStaff()
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        ClearFields()
        GetStaffID()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AUUpdateToolStripButton3.Click
        UpdateStaff()
        Me.Close()
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.lblSupplierID.Text = dgw.Item(0, i).Value
        Me.txtLastname.Text = dgw.Item(1, i).Value
        Me.txtFirstname.Text = dgw.Item(2, i).Value
        Me.txtnationalID.Text = dgw.Item(3, i).Value
        Me.txtCounty.Text = dgw.Item(4, i).Value
        Me.txtContractNo.Text = dgw.Item(5, i).Value
        Me.txtUsername.Text = dgw.Item(6, i).Value
        Me.txtRole.Text = dgw.Item(7, i).Value
        Me.txtPassword.Text = dgw.Item(8, i).Value
        'Me.txtUsername.Text = dgw.Item(6, i).Value
        AUSaveToolStripButton5.Enabled = False
        AUUpdateToolStripButton3.Enabled = True
    End Sub
    Private Sub TxtLname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLname.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT StaffID, Lastname, Firstname, NationalID, County, ContactNo, Username, Role, UPassword FROM staff where Lastname LIKE '%" & TxtLname.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("StaffID"), dr("Lastname"), dr("Firstname"), dr("NationalID"), dr("ContactNo"), dr("County"), dr("Username"), dr("Role"), dr("UPassword"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub txtIdNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdNo.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT StaffID, Lastname, Firstname, NationalID, ContactNo, County, Username, Role, UPassword FROM staff where NationalID LIKE '%" & txtIdNo.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("StaffID"), dr("Lastname"), dr("Firstname"), dr("NationalID"), dr("ContactNo"), dr("County"), dr("Username"), dr("Role"), dr("UPassword"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dgw.Rows.Clear()
    End Sub

    Private Sub txtUsername_KeyUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.KeyUp
        'Check for duplicate entry of product sub category
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            cmd = New MySqlCommand(Query, MysqlConn)
            With cmd
                .Connection = MysqlConn
                .CommandText = "SELECT COUNT(*) FROM staff WHERE Username  = '" & txtUsername.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Username Already Exists!", MsgBoxStyle.Exclamation, "Add New Staff!")
                txtUsername.Clear()
                txtUsername.Focus()
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


End Class

