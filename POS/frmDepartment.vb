Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmDepartment
    Dim y As Integer
    Private Sub Clear()
        txtDepartmentName.Text = ""
        txtdescription.Text = ""
        txtDepartmentNo.Text = ""
        txtDeptmanager.Text = ""
    End Sub

    Private Sub AddDepartment()

        If Len(Trim(txtDepartmentName.Text)) = 0 Then
            MessageBox.Show("Please enter Department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDepartmentName.Focus()
            Exit Sub
        End If

        Try
            sqL = "INSERT INTO department(department_Name, department_description, department_Manager) VALUES (@d2, @d3, @d4)"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@d2", txtDepartmentName.Text)
            cmd.Parameters.AddWithValue("@d3", txtdescription.Text)
            cmd.Parameters.AddWithValue("@d4", txtDeptmanager.Text)
            dr = cmd.ExecuteReader
            MsgBox("Department successfully added.", MsgBoxStyle.Information, "Add Department")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtDepartmentName.Text, TimeOfDay, "Added New Department")
        Clear()
        txtDepartmentName.Focus()
    End Sub

    Private Sub UpdateDepartmentDetails()
        Try
            If Len(Trim(txtDepartmentNo.Text)) = 0 Then
                MessageBox.Show("Please select Department id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDepartmentNo.Focus()
                Exit Sub
            End If
            sqL = "UPDATE department SET department_Name=@d2, department_description=@d3, department_Manager=@d4 WHERE department_Id = '" & txtDepartmentNo.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@d2", txtDepartmentName.Text.ToString)
            cmd.Parameters.AddWithValue("@d3", txtdescription.Text.ToString)
            cmd.Parameters.AddWithValue("@d4", txtDeptmanager.Text.ToString)
            If MessageBox.Show("Are you sure want to update the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                dr = cmd.ExecuteReader
                MessageBox.Show("Successfully updated", "Department Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtDepartmentNo.Text, TimeOfDay, "Updated Department Details")
        txtDepartmentNo.Focus()
    End Sub

    Private Sub CreateConstituentSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles CreateDepartmentSave.Click
        AddDepartment()
        Clear()
    End Sub

    Private Sub CConstiupdateToolStripButton3_Click(sender As Object, e As EventArgs) Handles updateDepartment.Click
        UpdateDepartmentDetails()
        Clear()
    End Sub
    Private Sub Searchdepartment()
        Try
            sqL = "Select department_Id, department_Name, department_description, department_Manager from department where department_Name like '%" & txtDepartmentName.Text & "%'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtDepartmentNo.Text = dr("department_Id")
                txtDepartmentName.Text = dr("department_Name")
                txtdescription.Text = dr("department_description")
                txtDeptmanager.Text = dr("department_Manager")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub txtsearchDeptname_TextChanged(sender As Object, e As EventArgs) Handles txtsearchDeptname.TextChanged
        Try
            sqL = "Select department_Id, department_Name, department_description, department_Manager from department where department_Name like '%" & txtsearchDeptname.Text & "%'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("department_Id"), dr("department_Name"), dr("department_description"), dr("department_Manager"))
                y += 17
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.txtDepartmentNo.Text = dgw.Item(0, i).Value
        Me.txtDepartmentName.Text = dgw.Item(1, i).Value
        Me.txtDeptmanager.Text = dgw.Item(2, i).Value
        Me.txtdescription.Text = dgw.Item(3, i).Value

    End Sub
End Class