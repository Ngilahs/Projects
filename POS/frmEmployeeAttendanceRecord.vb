Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmEmployeeAttendanceRecord
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Sub fillcombo()

        Try
            Dim cs As String = "Server=DESKTOP-KN30JND; Database=PayrollManagerDB; User Id =sa; Password=kabandis@2013; Connect Timeout = 120;"

            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(employeeid) FROM employeeattendance", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            EmployeeID.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                EmployeeID.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EmployeeAttendanceRecord_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        'frmMainMenu.Show()
    End Sub
    Private Sub EmployeeAttendanceRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombo()
        DataGridView2.DataSource = GetData()
    End Sub
    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Try
            If Len(Trim(EmployeeID.Text)) = 0 Then
                MessageBox.Show("Please select employee id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                EmployeeID.Focus()
                Exit Sub
            End If
            Total.Visible = True
            Dim cs As String = "Server=DESKTOP-KN30JND; Database=PayrollManagerDB; User Id =sa; Password=kabandis@2013; Connect Timeout = 120;"
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("select RTrim(WorkingDate)[Working Date],Rtrim(Status)[Status], RTRIM(InTime)[In Time],Rtrim(OutTime)[Out Time],RTRIM(Overtime)[Overtime] from employeeAttendance where WorkingDate between @date1 and @date2 and EmployeeId='" & EmployeeID.Text & "' order by workingdate", con)
            cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "WorkingDate").Value = DateFrom.Value.Date
            cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "WorkingDate").Value = DateTo.Value.Date



            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "EmployeeAttendance")

            DataGridView1.DataSource = myDataSet.Tables("EmployeeAttendance").DefaultView


            Me.DataGridView1.Columns("overtime").DefaultCellStyle.Format = "HH:mm:ss"
            Dim sumHour As Integer = 0

            Dim sumMinute As Integer = 0

            Dim sumSecond As Integer = 0

            For Each dr As DataRow In myDataSet.Tables("EmployeeAttendance").Rows

                Dim tim As TimeSpan = TimeSpan.Parse(dr("Overtime").ToString())
                sumHour += tim.Hours

                sumMinute += tim.Minutes

                sumSecond += tim.Seconds

            Next



            Dim sp As New TimeSpan(sumHour, sumMinute, sumSecond)

            Me.TotalOvertime.Text = sp.ToString()

            con.Close()


            con.Open()


            Dim cp As String = "select count(status) from employeeattendance where WorkingDate between @date1 and @date2 and status='P' and  employeeid=@find "

            cmd = New SqlCommand(cp)
            cmd.Connection = con

            cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "WorkingDate").Value = DateFrom.Value.Date
            cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "WorkingDate").Value = DateTo.Value.Date

            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 30, "employeeid"))
            cmd.Parameters("@find").Value = Trim(EmployeeID.Text)

            Dim result = cmd.ExecuteScalar()

            TextBox2.Text = Convert.ToString(result)



            If con.State = ConnectionState.Open Then
                con.Close()
            End If



            con.Open()


            Dim cp1 As String = "select count(status) from employeeattendance where WorkingDate between @date1 and @date2 and  employeeid=@find "

            cmd = New SqlCommand(cp1)
            cmd.Connection = con

            cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "WorkingDate").Value = DateFrom.Value.Date
            cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "WorkingDate").Value = DateTo.Value.Date

            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 30, "employeeid"))
            cmd.Parameters("@find").Value = Trim(EmployeeID.Text)

            Dim result1 = cmd.ExecuteScalar()

            TextBox1.Text = Convert.ToString(result1)



            If con.State = ConnectionState.Open Then
                con.Close()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        DataGridView1.DataSource = Nothing
        Total.Visible = False
        EmployeeID.Text = ""
        EmployeeName.Text = ""
        DateFrom.Text = Today
        DateTo.Text = Today
    End Sub

    Private Sub EmployeeID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeID.SelectedIndexChanged
        Try


            Dim cs As String = "Server=DESKTOP-KN30JND; Database=PayrollManagerDB; User Id =sa; Password=kabandis@2013; Connect Timeout = 120;"

            con = New SqlConnection(cs)

            con.Open()


            Dim ct As String = "select employeename from employeeattendance where employeeid=@find"


            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 30, "employeeid"))
            cmd.Parameters("@find").Value = Trim(EmployeeID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then

                EmployeeName.Text = Trim(rdr.GetString(0))




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

    Private Const ConnectionString As String = "Server=DESKTOP-KN30JND; Database=PayrollManagerDB; User Id =sa; Password=kabandis@2013; Connect Timeout = 120;"
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





End Class