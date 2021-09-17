Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmPaymentmodes
    Dim y As Integer
    Private Sub GetpaymodeNo()
        Try
            sqL = "SELECT PayModeID FROM paymodes ORDER BY PayModeID DESC"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                lblPayModeNo.Text = dr("PayModeID") + 1
            Else
                lblPayModeNo.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub AddPayMode()
            If lblPayModeNo.Text = "" Or txtPayModeName.Text = "" Or txtDescription.Text = "" Then
                MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Add Payment Mode!")
                Exit Sub
            End If
            Try
                sqL = "INSERT INTO paymodes(PayModeID, PayModeName, Description) VALUES('" & lblPayModeNo.Text & "', '" & txtPayModeName.Text & "', '" & txtDescription.Text & "')"
                ConnDB()
                cmd = New MySqlCommand(sqL, conn)
                dr = cmd.ExecuteReader
                MsgBox("New Pay Mode successfully added.", MsgBoxStyle.Information, "Add Pay Mode")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cmd.Dispose()
                conn.Close()
            End Try
            'Update Audit Trail Table
            Audit_Trail(FrmMain.tsslUser.Text, lblPayModeNo.Text, TimeOfDay, "Added new Payment mode")
    End Sub

    Private Sub UpdatePayMode()
        If lblPayModeNo.Text = "" Or txtPayModeName.Text = "" Or txtDescription.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Add Payment Mode!")
            Exit Sub
        End If
        Try
            sqL = "UPDATE paymodes SET PayModeName= '" & txtPayModeName.Text & "', Description = '" & txtDescription.Text & "' WHERE PayModeID = '" & lblPayModeNo.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            MsgBox("Pay Mode successfully updated.", MsgBoxStyle.Information, "Update Pay Mode")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblPayModeNo.Text, TimeOfDay, "Updated Payment mode")
    End Sub
    Private Sub CLearFields()
        txtPayModeName.Text = ""
        txtDescription.Text = ""
    End Sub

    Private Sub frmPaymentmodes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetpaymodeNo()
        CLearFields()
    End Sub
    Private Sub frmPaymentmodes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub txtSearchByCategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchByCategory.TextChanged
        Try
            sqL = "SELECT PayModeID, PayModeName, Description from paymodes where PayModeName LIKE '" & txtSearchByCategory.Text & "%'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("PayModeID"), dr("PayModeName"), dr("Description"))
                y += 17
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        GetpaymodeNo()
        CLearFields()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PYMUpdateToolStripButton3.Click
        UpdatePayMode()
        CLearFields()
        GetpaymodeNo()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PYMSaveToolStripButton5.Click
        AddPayMode()
        CLearFields()
        GetpaymodeNo()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.lblPayModeNo.Text = dgw.Item(0, i).Value
        Me.txtPayModeName.Text = dgw.Item(1, i).Value
        Me.txtDescription.Text = dgw.Item(2, i).Value
    End Sub
End Class