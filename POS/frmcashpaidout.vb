Imports MySql.Data.MySqlClient
Public Class frmcashpaidout
    Dim sqll As String
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Public isAdmin As Boolean
    Public isSupervisor As Boolean
    Public Sub GetCashPaidoutSessionID()
        Try
            Dim con As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
            con.Open()
            sqll = "SELECT SessionPaidoutID FROM sessionpaidout ORDER BY SessionPaidoutID DESC"
            cmd = New MySqlCommand(sqll, con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                LBLCashpaidoutID.Text = dr("SessionPaidoutID") + 1
            Else
                LBLCashpaidoutID.Text = 1

            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Login()
        Try
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

            Dim conx As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
            conx.Open()
            sqll = "SELECT * FROM Staff WHERE Username = '" & txtUsername.Text & "' AND UPassword = '" & txtPassword.Text & "'"
            cmd = New MySqlCommand(sqll, conx)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                If LCase(dr("role")) = "administrator" Then
                    GroupBox1.Enabled = True
                    'Update Audit Trail Table
                    Audit_Trail(FrmMain.tsslUser.Text, FrmMain.tsslUser.Text, TimeOfDay, "LoggedIn to the System")
                    isAdmin = True
                    isSupervisor = True
                End If
                If LCase(dr("role")) = "supervisor" Then
                    GroupBox1.Enabled = True
                    'Update Audit Trail Table
                    Audit_Trail(FrmMain.tsslUser.Text, FrmMain.tsslUser.Text, TimeOfDay, "LoggedIn to the System")
                    isAdmin = True
                    isSupervisor = True
                End If
            Else
                MsgBox("Incorrect username or password.", MsgBoxStyle.Critical, "Login")
                txtUsername.SelectAll()
                txtPassword.SelectAll()
            End If
            conx.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Private Sub AddCashPaidOut()
        Try
            Dim cony As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
            cony.Open()
            sqll = "INSERT INTO sessionpaidout(SessionPaidoutID, sessionpayoutId, paidoutdate, PaidoutType, Amount, TillNo) VALUES('" & LBLCashpaidoutID.Text & "', '" & TxtSessIDCashPaid.Text & "','" & txtCashpaidoutSessionDate.Text & "', '" & txtDescription.Text & "', '" & txtAmt.Text & "', '" & txtTillNo.Text & "')"
            cmd = New MySqlCommand(sqll, cony)
            dr = cmd.ExecuteReader()
            'Update Audit Trail Table
            'Audit_Trail(FrmMain.tsslUser.Text, lblCategoryNo.Text, TimeOfDay, "Added New Category")
            MsgBox("Cash Paid Out successfully added.", MsgBoxStyle.Information, "Cash Paid Out")
            cony.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub UpdateCashPaidOut()
        Try
            Dim conm As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
            conm.Open()
            sqll = "UPDATE sessionpaidout SET sessionpayoutId = '" & TxtSessIDCashPaid.Text & "', paidoutdate = '" & txtCashpaidoutSessionDate.Text & "', PaidoutType= '" & txtDescription.Text & "', Amount= '" & txtAmt.Text & "', TillNo= '" & txtTillNo.Text & "' WHERE SessionPaidoutID = '" & LBLCashpaidoutID.Text & "'"
            cmd = New MySqlCommand(sqll, conm)
            dr = cmd.ExecuteReader()
            'Update Audit Trail Table
            'Audit_Trail(FrmMain.tsslUser.Text, lblCategoryNo.Text, TimeOfDay, "Updated Category Information")
            MsgBox("Cash Paid Out successfully updated.", MsgBoxStyle.Information, "Update Cash Paid Out")
            conm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
        'GetSessionID()
    End Sub

    Private Sub ZINSaveToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashPaidoutSaveToolStripButton3.Click
        If txtDescription.Text = "" Then
            MsgBox("Enter Cash Paid Out Description")
            txtDescription.Focus()
            Exit Sub
        End If
        If txtAmt.Text = "" Then
            MsgBox("Enter Cash Paid Out Amount")
            txtAmt.Focus()
            Exit Sub
        End If
        AddCashPaidOut()
        clearAllFields()
        GetCashPaidoutSessionID()
        Me.Close()
    End Sub
    Private Sub frmcashpaidout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetCashPaidoutSessionID()
        txtCashpaidoutSessionDate.Text = Format(Now, "MM/dd/yyyy")
        txtTillNo.Text = FrmMain.LBLComputerName.Text
        'TxtSessIDCashPaid.Text = FrmMain.SessionIDToolStripStatus.Text
        GroupBox1.Enabled = False
    End Sub
    Private Sub frmcashpaidout_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        AcceptButton = btnLogIn
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        Login()
    End Sub

    Private Sub ZINCloseToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZINCloseToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub clearAllFields()
        'LBLCashpaidoutID.Text = ""
        'TxtSessIDCashPaid.Text = ""
        'txtCashpaidoutSessionDate.Text = ""
        txtDescription.Text = ""
        txtAmt.Text = ""
        'txtTillNo.Text = ""
    End Sub
End Class