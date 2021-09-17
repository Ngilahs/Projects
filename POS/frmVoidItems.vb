Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmVoidItems
    Dim y As Integer
    Private Sub PopulateUsers()
        Try
            sqL = "SELECT Username From staff order by StaffID"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            cmbUsersID.Items.Clear()
            Do While dr.Read = True
                cmbUsersID.Items.Add(dr("Username"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub GetAuditTrail()
        Try
            sqL = "SELECT void_itemId, User_ID, TransID, ItemBarcode, VoidQty, TransDate, Timex FROM void_items WHERE User_ID = @Name AND TransDate BETWEEN @dt1 AND @dt2 ORDER BY TransDate"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@dt1", dtpsDateFrom.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dt2", dtpsDateTo.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@Name", cmbUsersID.Text)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("void_itemId"), dr("User_ID"), dr("TransID"), dr("ItemBarcode"), dr("VoidQty"), dr("TransDate"), dr("Timex"))
                y += 17
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Public Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            sqL = "Delete from void_items Where User_ID = '" & cmbUsersID.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "deleted the all void items list till date '" & Now & "'"
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Reset()
                getData()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, cmbUsersID.Text, TimeOfDay, "Deleted Void Item List")
    End Sub
    Sub Reset()
        cmbUsersID.SelectedIndex = -1
        dtpsDateFrom.Text = Today
        dtpsDateTo.Text = Now
        GetData()
        PopulateUsers()
        dgw.Rows.Clear()
    End Sub
    Private Sub frmVoidItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateUsers()
        GetAuditTrail()
    End Sub
    Private Sub frmVoidItems_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub btnsGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsGetData.Click
        GetAuditTrail()
    End Sub

    Private Sub btnsReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsReset.Click
        Reset()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIADeleteToolStripButton2.Click
        Try
            If MessageBox.Show("Do you really want to delete all void items list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GetVoidItemsAuditTrailForAllUsers()
        Try
            sqL = "SELECT void_itemId, User_ID, TransID, ItemBarcode, VoidQty, TransDate, Timex FROM void_items WHERE TransDate BETWEEN @dt1 AND @dt2 ORDER BY TransDate"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)

            cmd.Parameters.AddWithValue("@dt1", dtpsDateFrom.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dt2", dtpsDateTo.Value.ToString("MM/dd/yyyy"))
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("void_itemId"), dr("User_ID"), dr("TransID"), dr("ItemBarcode"), dr("VoidQty"), dr("TransDate"), dr("Timex"))
                y += 17
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub btnLogforallusers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogforallusers.Click
        GetVoidItemsAuditTrailForAllUsers()
    End Sub
End Class