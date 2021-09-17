Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class frmPaymentStatus
    Dim y As Integer
    Private Sub AddPaymentStatus()
        If txtPayStatusname.Text = "" Or txtDescription.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPayStatusname.Focus()
            Exit Sub
        End If
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Insert into tbl_paymentstatus(paystatusname, description) Values ('" & txtPayStatusname.Text & "', '" & txtDescription.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("New payment status successfully added.", MsgBoxStyle.Information, "Add Payment Status")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtPayStatusname.Text, TimeOfDay, "Added Payment Status")
    End Sub

    Private Sub UpdatePaymentStatus()
        If txtPayStatusname.Text = "" Or txtDescription.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPayStatusname.Focus()
            Exit Sub
        End If
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update tbl_paymentstatus Set paystatusname = '" & txtPayStatusname.Text & "', description = '" & txtDescription.Text & "' WHERE statusId = '" & lblPaystatusId.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Payment Status successfully updated.", MsgBoxStyle.Information, "Update Payment Status")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblPaystatusId.Text, TimeOfDay, "Updated Payment Status Information")

    End Sub
    Private Sub frmPaymentStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CSaveToolStripButton5.Enabled = True
        CUpdateToolStripButton3.Enabled = False
    End Sub

    Private Sub CloseToolStripButton1_Click(sender As Object, e As EventArgs) Handles CloseToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub CSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles CSaveToolStripButton5.Click
        AddPaymentStatus()
        ResetForm()
    End Sub

    Private Sub CUpdateToolStripButton3_Click(sender As Object, e As EventArgs) Handles CUpdateToolStripButton3.Click
        UpdatePaymentStatus()
        ResetForm()
        CSaveToolStripButton5.Enabled = True
        CUpdateToolStripButton3.Enabled = False
    End Sub

    Private Sub ResetForm()
        txtPayStatusname.Text = ""
        txtDescription.Text = ""
        lblPaystatusId.Text = ""
        dgw.Rows.Clear()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select statusId, paystatusname, description from tbl_paymentstatus where paystatusname like '%" & txtSearch.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1), dr(2))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub dgw_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.lblPaystatusId.Text = dgw.Item(0, i).Value
        Me.txtPayStatusname.Text = dgw.Item(1, i).Value
        Me.txtDescription.Text = dgw.Item(2, i).Value
        CSaveToolStripButton5.Enabled = False
        CUpdateToolStripButton3.Enabled = True
    End Sub
End Class