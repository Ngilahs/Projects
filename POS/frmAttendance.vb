Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmAttendance
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Attendance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'frmMainMenu.Show()
    End Sub
    Sub fillcombo()

        Try
            Dim cs As String = "Server=Joshua-PC; Database=PayrollManagerDB; User Id =sa; Password=123; Connect Timeout = 120;"

            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(employeeid) FROM employeeregistration", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            EmployeeID.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                EmployeeID.Items.Add(drow(0).ToString())

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Attendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombo()
        DataGridView1.DataSource = GetData()
    End Sub

    Private Sub EmployeeID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeID.SelectedIndexChanged
        Try
            Delete.Enabled = True

            Dim cs As String = "Server=Joshua-PC; Database=PayrollManagerDB; User Id =sa; Password=123; Connect Timeout = 120;"

            con = New SqlConnection(cs)

            con.Open()


            Dim ct As String = "select employeename,basicworkingtime from employeeregistration where employeeid=@find"


            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 30, "employeeid"))
            cmd.Parameters("@find").Value = Trim(EmployeeID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then

                EmployeeName.Text = Trim(rdr.GetString(0))
                BasicWorkingTime.Text = Trim(rdr.GetString(1))




            End If

            If Not rdr Is Nothing Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub clear()
        WorkingDate.Text = Today
        EmployeeID.Text = ""
        EmployeeName.Text = ""
        InTime.Text = Now
        OutTime.Text = Now
        Overtime.Text = ""
        Status.Text = ""
        BasicWorkingTime.Text = ""
    End Sub
    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        clear()
        Delete.Enabled = False
        Update_Record.Enabled = False
        TextBox1.Visible = False
        TextBox2.Visible = False
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        If Len(Trim(EmployeeID.Text)) = 0 Then
            MessageBox.Show("Please select employee id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EmployeeID.Focus()
            Exit Sub
        End If
        If Len(Trim(Status.Text)) = 0 Then
            MessageBox.Show("Please select Status", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Status.Focus()
            Exit Sub
        End If

        Try
            Dim cs As String = "Server=Joshua-PC; Database=PayrollManagerDB; User Id =sa; Password=123; Connect Timeout = 120;"
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select employeeid,workingdate from employeeattendance where employeeid='" & EmployeeID.Text & "' and workingdate= '" & WorkingDate.Text & "'"

            cmd = New SqlCommand(ct)
            cmd.Connection = con

            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Employee today's attendance is already saved", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                EmployeeID.Focus()


                If Not rdr Is Nothing Then
                    rdr.Close()
                End If

            Else



                Dim ck As String = "Server=Joshua-PC; Database=PayrollManagerDB; User Id =sa; Password=123; Connect Timeout = 120;"
                con = New SqlConnection(ck)
                con.Open()

                Dim cb As String = "insert into employeeAttendance(Workingdate,employeeid,employeename,status,intime,outtime,overtime,basicworkingtime) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)"

                cmd = New SqlCommand(cb)

                cmd.Connection = con

                cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 30, "Workingdate"))

                cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "employeeid"))

                cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.VarChar, 100, "employeename"))
                cmd.Parameters.Add(New SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "status"))
                cmd.Parameters.Add(New SqlParameter("@d5", System.Data.SqlDbType.NChar, 30, "intime"))
                cmd.Parameters.Add(New SqlParameter("@d6", System.Data.SqlDbType.NChar, 30, "outtime"))
                cmd.Parameters.Add(New SqlParameter("@d7", System.Data.SqlDbType.NChar, 10, "overtime"))
                cmd.Parameters.Add(New SqlParameter("@d8", System.Data.SqlDbType.NChar, 10, "basicworkingtime"))


                cmd.Parameters("@d1").Value = WorkingDate.Text

                cmd.Parameters("@d2").Value = EmployeeID.Text

                cmd.Parameters("@d3").Value = EmployeeName.Text
                cmd.Parameters("@d4").Value = Status.Text
                If Status.Text = "P" Then
                    cmd.Parameters("@d5").Value = InTime.Text
                    cmd.Parameters("@d6").Value = OutTime.Text
                ElseIf Status.Text = "A" Then
                    cmd.Parameters("@d5").Value = TextBox1.Text
                    cmd.Parameters("@d6").Value = TextBox2.Text
                End If

                cmd.Parameters("@d7").Value = Overtime.Text

                cmd.Parameters("@d8").Value = BasicWorkingTime.Text

                cmd.ExecuteReader()
                MessageBox.Show("Successfully saved", "Employee Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Close()
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Try
            If EmployeeID.Text = "" Then
                MessageBox.Show("Please select employee id", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Update_Record.Enabled = True
            Delete.Enabled = True
            Dim cs As String = "Server=Joshua-PC; Database=PayrollManagerDB; User Id =sa; Password=123; Connect Timeout = 120;"

            con = New SqlConnection(cs)

            con.Open()


            Dim ct As String = "select Employeename,Basicworkingtime,status,intime,outtime,overtime from EmployeeAttendance  where employeeid=@find and WorkingDate=@find1"


            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 30, "employeeid"))
            cmd.Parameters("@find").Value = Trim(EmployeeID.Text)
            cmd.Parameters.Add(New SqlParameter("@find1", System.Data.SqlDbType.NChar, 30, "workingdate"))
            cmd.Parameters("@find1").Value = Trim(WorkingDate.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then

                EmployeeName.Text = Trim(rdr.GetString(0))
                BasicWorkingTime.Text = Trim(rdr.GetString(1))
                Status.Text = Trim(rdr.GetString(2))
                If Status.Text = "P" Then
                    InTime.Text = Trim(rdr.GetString(3))
                    OutTime.Text = Trim(rdr.GetString(4))
                ElseIf Status.Text = "A" Then
                    TextBox1.Visible = True
                    TextBox2.Visible = True
                    TextBox1.Text = Trim(rdr.GetString(3))
                    TextBox2.Text = Trim(rdr.GetString(4))
                End If
                InTime.Text = Trim(rdr.GetString(3))
                OutTime.Text = Trim(rdr.GetString(4))
                Overtime.Text = Trim(rdr.GetString(5))


            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If

            If Not rdr Is Nothing Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Update_Record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_Record.Click

        Try
            Dim ck As String = "Server=Joshua-PC; Database=PayrollManagerDB; User Id =sa; Password=123; Connect Timeout = 120;"
            con = New SqlConnection(ck)
            con.Open()

            Dim cb As String = "update employeeAttendance set employeename=@d3,status=@d4,intime=@d5,outtime=@d6,overtime=@d7,basicworkingtime=@d8 where workingdate=@d1 and Employeeid=@d2"

            cmd = New SqlCommand(cb)

            cmd.Connection = con


            cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 30, "Workingdate"))

            cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "employeeid"))

            cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.VarChar, 100, "employeename"))
            cmd.Parameters.Add(New SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "status"))
            cmd.Parameters.Add(New SqlParameter("@d5", System.Data.SqlDbType.NChar, 30, "intime"))
            cmd.Parameters.Add(New SqlParameter("@d6", System.Data.SqlDbType.NChar, 30, "outtime"))
            cmd.Parameters.Add(New SqlParameter("@d7", System.Data.SqlDbType.NChar, 10, "overtime"))
            cmd.Parameters.Add(New SqlParameter("@d8", System.Data.SqlDbType.NChar, 10, "basicworkingtime"))


            cmd.Parameters("@d1").Value = WorkingDate.Text

            cmd.Parameters("@d2").Value = EmployeeID.Text

            cmd.Parameters("@d3").Value = EmployeeName.Text
            cmd.Parameters("@d4").Value = Status.Text
            If Status.Text = "P" Then
                cmd.Parameters("@d5").Value = InTime.Text
                cmd.Parameters("@d6").Value = OutTime.Text
            ElseIf Status.Text = "A" Then
                cmd.Parameters("@d5").Value = TextBox1.Text
                cmd.Parameters("@d6").Value = TextBox2.Text
            End If

            cmd.Parameters("@d7").Value = Overtime.Text

            cmd.Parameters("@d8").Value = BasicWorkingTime.Text
            If MessageBox.Show("Are you sure want to update the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


                cmd.ExecuteReader()
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Delete.Enabled = False
                Update_Record.Enabled = False
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Close()




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ViewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewRecord.Click
        Me.Hide()
        frmEmployeeAttendanceRecord.Show()
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Try

            If EmployeeID.Text = "" Then
                MessageBox.Show("Please select employee id", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If EmployeeID.Items.Count > 0 Then
                If MessageBox.Show("Do you really want to delete the records?" & vbCrLf & "You can not restore the records" & vbCrLf & "It will delete all the records permanently" & vbCrLf & "related to selected employee", "Employee's Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    delete_records()



                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub delete_records()
        Try



            Dim RowsAffected As Integer = 0

            Dim cs As String = "Server=Joshua-PC; Database=PayrollManagerDB; User Id =sa; Password=123; Connect Timeout = 120;"

            con = New SqlConnection(cs)

            con.Open()


            Dim cq As String = "delete from employeeattendance where EmployeeID=@DELETE1;"


            cmd = New SqlCommand(cq)

            cmd.Connection = con

            cmd.Parameters.Add(New SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 30, "EmployeeID"))


            cmd.Parameters("@DELETE1").Value = Trim(EmployeeID.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clear()
                EmployeeID.Focus()
                Update_Record.Enabled = False
                Delete.Enabled = False
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)




                If con.State = ConnectionState.Open Then

                    con.Close()
                End If

                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Const ConnectionString As String = "Server=Joshua-PC; Database=PayrollManagerDB; User Id =sa; Password=123; Connect Timeout = 120;"
    Private ReadOnly Property Connection() As SqlConnection
        Get
            Dim ConnectionToFetch As New SqlConnection(ConnectionString)
            ConnectionToFetch.Open()
            Return ConnectionToFetch
        End Get
    End Property
    Public Function GetData() As DataView
        Dim SelectQry = "SELECT RTRIM(EmployeeName)[Employee Name],RTRIM(EmployeeID)[Employee ID] FROM EmployeeRegistration order by employeename"
        Dim SampleSource As New DataSet
        Dim TableView As DataView
        Try
            Dim SampleCommand As New SqlCommand()
            Dim SampleDataAdapter = New SqlDataAdapter()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = Connection
            SampleDataAdapter.SelectCommand = SampleCommand
            SampleDataAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView
        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return TableView
    End Function

    Private Sub Overtime_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Overtime.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then

            e.Handled = True

        End If
    End Sub










    Private Sub Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Status.SelectedIndexChanged
        If Status.Text = "P" Then
            TextBox1.Visible = False
            TextBox2.Visible = False
            InTime.Enabled = True
            OutTime.Enabled = True
            InTime.Text = Now
            OutTime.Text = Now
            Overtime.Text = ""


        ElseIf Status.Text = "A" Then
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox1.Text = "00:00:00"
            TextBox2.Text = "00:00:00"
            Overtime.Text = "00:00:00"
        End If
    End Sub

    Private Sub OutTime_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutTime.ValueChanged
        Dim ts As TimeSpan
        TimeSpan.TryParse(BasicWorkingTime.Text, ts)
        Dim duration As TimeSpan = OutTime.Value - InTime.Value
        Overtime.Text = Convert.ToString(duration - ts)
    End Sub

   
    Private Sub InTime_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles InTime.ValueChanged
        Dim ts As TimeSpan
        TimeSpan.TryParse(BasicWorkingTime.Text, ts)
        Dim duration As TimeSpan = OutTime.Value - InTime.Value
        Overtime.Text = Convert.ToString(duration - ts)
    End Sub
End Class