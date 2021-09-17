Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class frmAudittrail
    Dim y As Integer
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Private Sub PopulateUsers()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Username From staff order by StaffID"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cmbUserID.Items.Clear()
            Do While dr.Read = True
                cmbUserID.Items.Add(dr("Username"))
            Loop
            MysqlConn.Close()
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub GetAuditTrail()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT A.User_ID, A.Record_ID, A.Action, A.Date, A.Timex, A.log_ID, S.Username FROM audittrail A Inner Join staff S on (A.User_ID = S.Username ) WHERE A.User_ID = @Name AND Date BETWEEN @dt1 AND @dt2 ORDER BY Date, Timex Asc"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@dt1", dtpDateFrom.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dt2", dtpDateTo.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@Name", cmbUserID.Text)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("log_ID"), dr("User_ID"), dr("Record_ID"), dr("Action"), dr("Date"), dr("Timex"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub DeleteRecord()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Dim RowsAffected As Integer = 0
            Query = "Delete from audittrail Where User_ID = '" & cmbUserID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "deleted the all logs till date '" & Now & "'"
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Reset()
                getData()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, cmbUserID.Text, TimeOfDay, "Deleted Audit Trail")
        Me.Close()
    End Sub
    Sub Reset()
        cmbUserID.SelectedIndex = -1
        dtpDateFrom.Text = Today
        dtpDateTo.Text = Now
        GetData()
        PopulateUsers()
        dgw.Rows.Clear()
    End Sub
    Private Sub frmAudittrail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ATDeleteToolStripButton2.Enabled = False
        PopulateUsers()
        GetAuditTrail()
    End Sub
    Private Sub frmAudittrail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        GetAuditTrail()
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ATDeleteToolStripButton2.Click
        Try
            If MessageBox.Show("Do you really want to delete all logs?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GetAuditTrailforallUsers()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT A.User_ID, A.Record_ID, A.Action, A.Date, A.Timex, A.log_ID, S.Username FROM audittrail A Inner Join staff S on (A.User_ID = S.Username ) WHERE Date BETWEEN @dt1 AND @dt2 ORDER BY Date, Timex Asc"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@dt1", dtpDateFrom.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dt2", dtpDateTo.Value.ToString("MM/dd/yyyy"))
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("log_ID"), dr("User_ID"), dr("Record_ID"), dr("Action"), dr("Date"), dr("Timex"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub btnLogforallusers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogforallusers.Click
        GetAuditTrailforallUsers()
    End Sub
End Class