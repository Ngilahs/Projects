Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLogin
    Public isCashier As Boolean
    Public isAdmin As Boolean
    Public isAdministrator As Boolean
    Public isSupervisor As Boolean
    Public isCustomerCare As Boolean
    Public strCashierID As String
    Dim sqll As String
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub Login()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If Len(Trim(txtUsername.Text)) = 0 Then
            MessageBox.Show("Please enter UserName", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If
        If Len(Trim(txtPassword.Text)) = 0 Then
            MessageBox.Show("Please enter Password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Exit Sub
            btnLogIn.Focus()
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM Staff WHERE Username = '" & txtUsername.Text & "' AND UPassword = '" & txtPassword.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then

                If LCase(dr("role")) = "admin" Then
                    MsgBox("Welcome to Last Mile Material Management", MsgBoxStyle.Information, "Login")
                    FrmMain.Show()
                    FrmMain.tsslUser.Text = UCase(txtUsername.Text)
                    FrmMain.tsslUser.Tag = dr("StaffID")
                    'frmUserRights.ShowDialog()
                    isCashier = True
                    isAdmin = True
                    isAdministrator = True
                    isSupervisor = True
                    isCustomerCare = True
                    Me.Hide()
                End If

                If LCase(dr("role")) = "stores" Then
                    MsgBox("Welcome to Last Mile Material Management", MsgBoxStyle.Information, "Login")
                    FrmMain.Show()
                    FrmMain.tsslUser.Text = UCase(txtUsername.Text)
                    FrmMain.tsslUser.Tag = dr("StaffID")
                    'frmUserRights.ShowDialog()
                    isCashier = True
                    isAdmin = True
                    isAdministrator = True
                    isSupervisor = True
                    isCustomerCare = True
                    Me.Hide()
                End If
                If LCase(dr("role")) = "administrator" Then
                    MsgBox("Welcome to Last Mile Material Management", MsgBoxStyle.Information, "Login")
                    FrmMain.Show()
                    FrmMain.tsslUser.Text = UCase(txtUsername.Text)
                    FrmMain.tsslUser.Tag = dr("StaffID")
                    'frmUserRights.ShowDialog()
                    isCashier = True
                    isAdmin = True
                    isAdministrator = True
                    isSupervisor = True
                    isCustomerCare = True
                    Me.Hide()
                End If
                If LCase(dr("role")) = "supervisor" Then
                    MsgBox("Welcome to Last Mile Material Management", MsgBoxStyle.Information, "Login")
                    FrmMain.Show()
                    FrmMain.tsslUser.Text = UCase(txtUsername.Text)
                    FrmMain.tsslUser.Tag = dr("StaffID")
                    'frmUserRights.ShowDialog()
                    isCashier = True
                    isAdmin = True
                    isAdministrator = True
                    isSupervisor = True
                    isCustomerCare = True
                    Me.Hide()
                End If
                If LCase(dr("role")) = "technical" Then
                    MsgBox("Welcome to Last Mile Material Management", MsgBoxStyle.Information, "Login")
                    FrmMain.Show()
                    FrmMain.tsslUser.Text = UCase(txtUsername.Text)
                    FrmMain.tsslUser.Tag = dr("StaffID")
                    'frmUserRights.ShowDialog()
                    isCashier = True
                    isAdmin = True
                    isAdministrator = True
                    isSupervisor = True
                    isCustomerCare = True
                    Me.Hide()
                End If
                If LCase(dr("role")) = "operations" Then
                    MsgBox("Welcome to Last Mile Material Management", MsgBoxStyle.Information, "Login")
                    FrmMain.Show()
                    FrmMain.tsslUser.Text = UCase(txtUsername.Text)
                    FrmMain.tsslUser.Tag = dr("StaffID")
                    'frmUserRights.ShowDialog()
                    isCashier = True
                    isAdmin = True
                    isAdministrator = True
                    isSupervisor = True
                    isCustomerCare = True
                    Me.Hide()
                End If
                If LCase(dr("role")) = "humanresources" Then
                    MsgBox("Welcome to Last Mile Material Management", MsgBoxStyle.Information, "Login")
                    FrmMain.Show()
                    FrmMain.tsslUser.Text = UCase(txtUsername.Text)
                    FrmMain.tsslUser.Tag = dr("StaffID")
                    'frmUserRights.ShowDialog()
                    isCashier = True
                    isAdmin = True
                    isAdministrator = True
                    isSupervisor = True
                    isCustomerCare = True
                    Me.Hide()
                End If
                If LCase(dr("role")) = "finance" Then
                    MsgBox("Welcome to Last Mile Material Management", MsgBoxStyle.Information, "Login")
                    FrmMain.Show()
                    FrmMain.tsslUser.Text = UCase(txtUsername.Text)
                    FrmMain.tsslUser.Tag = dr("StaffID")
                    'frmUserRights.ShowDialog()
                    isCashier = True
                    isAdmin = True
                    isAdministrator = True
                    isSupervisor = True
                    isCustomerCare = True
                    Me.Hide()
                End If
            Else
                MsgBox("Incorrect username or password.", MsgBoxStyle.Critical, "Login")
                txtUsername.SelectAll()
                txtPassword.SelectAll()
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, FrmMain.tsslUser.Text, TimeOfDay, "LoggedIn to the System")
    End Sub
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        AcceptButton = btnLogIn
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        AcceptButton = btnLogIn
        If txtUsername.Text = "" Then
            txtUsername.Focus()
        End If
    End Sub
    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If

        If e.KeyCode = Keys.F12 Then
            frmDatabase.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "taskmgr" Then
                selProcess.Kill()
                Exit For
            End If
        Next
    End Sub
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnDB()
        getData()
        SaveData()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        Login()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo, "Close Window") = MsgBoxResult.Yes Then
            End
        End If
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        frmChangePassword.Show()
        frmChangePassword.UserID.Text = ""
        frmChangePassword.OldPassword.Text = ""
        frmChangePassword.NewPassword.Text = ""
        frmChangePassword.ConfirmPassword.Text = ""
        frmChangePassword.UserID.Focus()
    End Sub
End Class
