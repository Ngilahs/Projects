Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmEmployee_registration
    Private Sub Employee_registration_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'frmMainMenu.Show()
    End Sub

    Sub clear()
        txtEmployeeID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtMobileNo.Text = ""
        txtIdNo.Text = ""
        cboDesignation.Text = ""
        cboDepartment.Text = ""
        txtDateOfJoining.Text = Today
        CboWorkCateId.Text = ""
        txtBasicWorkingTime.Text = ""
    End Sub
    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        clear()
        Update_Record.Enabled = False
        Delete.Enabled = False
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        AddEmployee()
        clear()
    End Sub
    Private Sub AddEmployee()

        If Len(Trim(txtFirstName.Text)) = 0 Then
            MessageBox.Show("Please enter First name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFirstName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtLastName.Text)) = 0 Then
            MessageBox.Show("Please enter Last name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFirstName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtMobileNo.Text)) = 0 Then
            MessageBox.Show("Please enter mobile no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMobileNo.Focus()
            Exit Sub
        End If
        If Len(Trim(txtIdNo.Text)) = 0 Then
            MessageBox.Show("Please enter Id no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMobileNo.Focus()
            Exit Sub
        End If
        If Len(Trim(CboWorkCateId.Text)) = 0 Then
            MessageBox.Show("Please enter Category Id.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMobileNo.Focus()
            Exit Sub
        End If
        If Len(Trim(cboDepartment.Text)) = 0 Then
            MessageBox.Show("Please enter department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboDepartment.Focus()
            Exit Sub
        End If
        If Len(Trim(cboDesignation.Text)) = 0 Then
            MessageBox.Show("Please enter designation", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboDesignation.Focus()
            Exit Sub
        End If
        If Len(Trim(txtDateOfJoining.Text)) = 0 Then
            MessageBox.Show("Please enter Date of Joining", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDateOfJoining.Focus()
            Exit Sub
        End If
        If Len(Trim(txtBasicWorkingTime.Text)) = 0 Then
            MessageBox.Show("Please enter basic working time", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBasicWorkingTime.Focus()
            Exit Sub
        End If
        'Try
        sqL = "INSERT INTO employeeregistration(emp_fname, emp_Lname, emp_PhoneNo, emp_IdNo, work_cateId, designation_Id, department_Id, working_hrs, Joining_Date) VALUES (@d2, @d3, @d4, @d5, @d6, @d7, @d8, @d9, @d10)"
        ConnDB()
            cmd = New MySqlCommand(sqL, conn)
        'cmd.Parameters.Add("@d1", txtEmployeeID.Text.ToString) employeeid, @d1 Joining_Date  @10
        cmd.Parameters.AddWithValue("@d2", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@d3", txtLastName.Text)
            cmd.Parameters.AddWithValue("@d4", txtMobileNo.Text)
            cmd.Parameters.AddWithValue("@d5", txtIdNo.Text)
            cmd.Parameters.AddWithValue("@d6", CboWorkCateId.Text)
            cmd.Parameters.AddWithValue("@d7", cboDesignation.Text)
            cmd.Parameters.AddWithValue("@d8", cboDepartment.Text)
        cmd.Parameters.AddWithValue("@d9", txtBasicWorkingTime.Text)
        cmd.Parameters.AddWithValue("@d10", txtDateOfJoining.Value.ToString("MM/dd/yyyy"))
        'cmd.Parameters.AddWithValue("@d10", txtDateOfJoining.Text.ToString)
        dr = cmd.ExecuteReader
        MsgBox("Employee successfully added.", MsgBoxStyle.Information, "Add Employee")

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        cmd.Dispose()
            conn.Close()
        'End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtEmployeeID.Text, TimeOfDay, "Added New Employee")
        clear()
        txtEmployeeID.Focus()
    End Sub
    Private Sub LoadEmployeeId()
        Try
            sqL = "SELECT employeeid From employeeregistration order by employeeid"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            txtEmployeeID.Items.Clear()
            Do While dr.Read = True
                txtEmployeeID.Items.Add(dr("employeeid"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Sub Filldepartment()
        'Try
        '    Dim cs As String = "Server=DESKTOP-KN30JND; Database=PayrollManagerDB; User Id =sa; Password=kabandis@2013; Connect Timeout = 120;"

        '    Dim CN As New SqlConnection(cs)

        '    CN.Open()
        '    adp = New SqlDataAdapter()
        '    adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(department) FROM employeeregistration", CN)
        '    ds = New DataSet("ds")

        '    adp.Fill(ds)
        '    dtable = ds.Tables(0)
        '    cboDepartment.Items.Clear()

        '    For Each drow As DataRow In dtable.Rows
        '        cboDepartment.Items.Add(drow(0).ToString())

        '    Next
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Sub FillDesignation()
        'Try
        '    Dim cs As String = "Server=DESKTOP-KN30JND; Database=PayrollManagerDB; User Id =sa; Password=kabandis@2013; Connect Timeout = 120;"

        '    Dim CN As New SqlConnection(cs)

        '    CN.Open()
        '    adp = New SqlDataAdapter()
        '    adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(designation) FROM employeeregistration", CN)
        '    ds = New DataSet("ds")

        '    adp.Fill(ds)
        '    dtable = ds.Tables(0)
        '    cboDesignation.Items.Clear()

        '    For Each drow As DataRow In dtable.Rows
        '        cboDesignation.Items.Add(drow(0).ToString())

        '    Next
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub Employee_registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEmployeeId()
        'AutoComplete()
        Filldepartment()
        FillDesignation()
    End Sub
    Private Sub Department_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDepartment.KeyPress
        '        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
        'Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
        'And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
        'Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
        '            'space accepted
        '            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
        '                e.Handled = True
        '            End If
        '        End If
        '        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then

        '            e.Handled = False
        '        End If
    End Sub
    Private Sub Designation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDesignation.KeyPress
        '        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
        'Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
        'And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
        'Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
        '            'space accepted
        '            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
        '                e.Handled = True
        '            End If
        '        End If
        '        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then

        '            e.Handled = False
        '        End If
    End Sub

    Private Sub EmployeeID_Format(ByVal sender As Object, ByVal e As System.Windows.Forms.ListControlConvertEventArgs) Handles txtEmployeeID.Format
        'If e.DesiredType Is GetType(String) Then
        '    e.Value = e.Value.ToString.Trim
        'End If
    End Sub
    Private Sub UpdateEmployee()
        Try
            If Len(Trim(txtEmployeeID.Text)) = 0 Then
                MessageBox.Show("Please select employee id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEmployeeID.Focus()
                Exit Sub
            End If
            sqL = "UPDATE employeeregistration SET emp_fname=@d2, emp_Lname=@d3, emp_PhoneNo=@d4, emp_IdNo=@d5, work_cateId=@d6, designation_Id=@d7, department_Id=@d8, working_hrs=@d9, Joining_Date=@d10 WHERE employeeid = '" & txtEmployeeID.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@d2", txtFirstName.Text.ToString)
            cmd.Parameters.AddWithValue("@d3", txtLastName.Text.ToString)
            cmd.Parameters.AddWithValue("@d4", txtMobileNo.Text.ToString)
            cmd.Parameters.AddWithValue("@d5", txtIdNo.Text.ToString)
            cmd.Parameters.AddWithValue("@d6", CboWorkCateId.Text.ToString)
            cmd.Parameters.AddWithValue("@d7", cboDesignation.Text.ToString)
            cmd.Parameters.AddWithValue("@d8", cboDepartment.Text.ToString)
            cmd.Parameters.AddWithValue("@d9", txtBasicWorkingTime.Text.ToString)
            cmd.Parameters.AddWithValue("@d10", txtDateOfJoining.Value.ToString("MM/dd/yyyy"))
            'cmd.Parameters.AddWithValue("@d10", txtDateOfJoining.Text.ToString) Joining_Date=@d10
            If MessageBox.Show("Are you sure want to update the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                dr = cmd.ExecuteReader
                MessageBox.Show("Successfully updated", "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtEmployeeID.Text, TimeOfDay, "Updated Employee Details")
        clear()
        txtEmployeeID.Focus()
    End Sub
    Private Sub EmployeeID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeeID.SelectedIndexChanged
        Try

            Update_Record.Enabled = True
            Delete.Enabled = True
            sqL = "select emp_fname, emp_Lname, emp_PhoneNo, emp_IdNo, work_cateId, designation_Id, department_Id, working_hrs from employeeregistration where employeeid = '" & txtEmployeeID.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader()
            If dr.Read Then
                'employeeid, emp_fname, emp_Lname, emp_PhoneNo, emp_IdNo, work_cateId, designation_Id, department_Id, working_hrs, Joining_Date
                txtFirstName.Text = dr("emp_fname")
                txtLastName.Text = dr("emp_Lname")
                txtMobileNo.Text = dr("emp_PhoneNo")
                txtIdNo.Text = dr("emp_IdNo")
                CboWorkCateId.Text = dr("work_cateId")
                cboDesignation.Text = dr("designation_Id")
                cboDepartment.Text = dr("department_Id")
                txtBasicWorkingTime.Text = dr("working_hrs")
                'txtDateOfJoining.Text = dr("emp_fname")

            Else
                MessageBox.Show("No Record found" & vbCrLf & "Please enter valid employee id", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            If Not dr Is Nothing Then
                dr.Close()
            End If
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_Record.Click
        UpdateEmployee()
    End Sub
    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Try

            If txtEmployeeID.Text = "" Then
                MessageBox.Show("Please select employee id", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If txtEmployeeID.Items.Count > 0 Then
                If MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    delete_records()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub delete_records()
        Try
            sqL = "select EmployeeID from employeeattendance where EmployeeID = '" & txtEmployeeID.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            'cmd.Parameters.AddWithValue("@d2", txtEmployeeID.Text.ToString)
            dr = cmd.ExecuteReader()
            If dr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()
                If Not dr Is Nothing Then
                    dr.Close()
                End If
                Exit Sub
            End If
            sqL = "select EmployeeID from employeepayment where EmployeeID='" & txtEmployeeID.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            'cmd.Parameters.AddWithValue("@d2", txtEmployeeID.Text.ToString)
            dr = cmd.ExecuteReader()
            If dr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()
                If Not dr Is Nothing Then
                    dr.Close()
                End If
                Exit Sub
            End If
            sqL = "select EmployeeID from advanceentry where EmployeeID='" & txtEmployeeID.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            'cmd.Parameters.AddWithValue("@d2", txtEmployeeID.Text.ToString)
            dr = cmd.ExecuteReader()
            If dr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()
                If Not dr Is Nothing Then
                    dr.Close()
                End If
                Exit Sub
            End If
            Dim RowsAffected As Integer
            sqL = "delete from employeeregistration where EmployeeID='" & txtEmployeeID.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            'cmd.Parameters.AddWithValue("@DELETE1", txtEmployeeID.Text.ToString)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtEmployeeID.Text, TimeOfDay, "Deleted Employee Details")
        clear()
        txtEmployeeID.Focus()
    End Sub

    Private Sub Department_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepartment.TextChanged
        Dim selectionStart As Integer = Me.cboDepartment.SelectionStart

        Me.cboDepartment.Text = Me.cboDepartment.Text.ToUpper()
        Me.cboDepartment.SelectionStart = selectionStart
    End Sub

    Private Sub Designation_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDesignation.TextChanged
        Dim selectionStart As Integer = Me.cboDesignation.SelectionStart

        Me.cboDesignation.Text = Me.cboDesignation.Text.ToUpper()
        Me.cboDesignation.SelectionStart = selectionStart
    End Sub

    Private Sub ViewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewRecord.Click
        Me.Hide()
        'frmEmployeesRecord.Show()
    End Sub

    Private Sub EmployeeName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstName.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'space accepted
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then

            e.Handled = False
        End If
    End Sub

    Private Sub Email_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIdNo.Validating
        'Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        'If txtIdNo.Text.Length > 0 Then
        '    If Not rEMail.IsMatch(txtIdNo.Text) Then
        '        MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        '        txtIdNo.SelectAll()
        '        e.Cancel = True
        '    End If
        'End If
    End Sub

    Private Sub EmployeeID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmployeeID.TextChanged
        'Dim selectionStart As Integer = Me.txtEmployeeID.SelectionStart

        'Me.txtEmployeeID.Text = Me.txtEmployeeID.Text.ToUpper()
        'Me.txtEmployeeID.SelectionStart = selectionStart
    End Sub
End Class