Option Explicit On
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Imports System.Data.OleDb

Public Class frmReceiveMeters
    Dim y As Integer
    Private Sub LoadSchemedetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select S.SchemeNo, S.Scheme_Ref_No, S.Scheme_Name, S.County_Id, S.Constituency_Id, S.No_of_Customers, S.Substation_No, CY.County_Name, CN.constituency_Name from schemes S Inner Join county CY on (S.County_Id = CY.County_No) Inner Join constituency CN on (S.Constituency_Id = CN.Constituency_No) where S.Scheme_Ref_No = '" & txtSchemeRefNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            y = 0
            If dr.Read = True Then
                txtConstituencyID.Text = dr("Constituency_Id")
                txtConstituencyname.Text = dr("constituency_Name")
                txtCounty.Text = dr("County_Name")
                txtCountyID.Text = dr("County_Id")
                txtSchemeName.Text = dr("Scheme_Name")
                txtSchemeID.Text = dr("SchemeNo")
                txtTXNo.Text = dr("Substation_No")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub frmReceiveMeters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CSaveToolStripButton5.Enabled = False
        cboStatus.Text = "Not Issued"
    End Sub

    Private Sub RemoveEmptyRows()
        For y As Integer = dgwx.Rows.Count - 1 To 0 Step -1
            If y = dgwx.NewRowIndex Then Continue For
            Dim empty As Boolean = True
            For x As Integer = 0 To dgwx.Rows(y).Cells.Count - 1
                If dgwx.Rows(y).Cells(x).Value IsNot Nothing AndAlso dgwx.Rows(y).Cells(x).Value.ToString <> "" Then
                    empty = False
                End If
            Next
            If empty Then
                dgwx.Rows.RemoveAt(y)
            End If
        Next
    End Sub

    Private Sub ImportList()
        Dim conn As OleDbConnection
        Dim dta As OleDbDataAdapter
        Dim dts As DataSet
        Dim excel As String
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then

            Dim fi As New FileInfo(OpenFileDialog.FileName)
            Dim FileName As String = OpenFileDialog.FileName

            excel = fi.FullName
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
            dta = New OleDbDataAdapter("Select * From [Sheet1$]", conn)
            dts = New DataSet
            dta.Fill(dts, "[Sheet1$]")
            dgwx.DataSource = dts
            dgwx.DataMember = "[Sheet1$]"
            conn.Close()

            With dgwx
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Customer Name"
                .Columns(1).HeaderCell.Value = "ID No"
                .Columns(2).HeaderCell.Value = "Pole No"
                .Columns(3).HeaderCell.Value = "Phone No"
                .Columns(4).HeaderCell.Value = "X-Co-ordinate"
                .Columns(5).HeaderCell.Value = "Y-Co-ordinate"
                .Columns(6).HeaderCell.Value = "Y-Ref No"
                .Columns(7).HeaderCell.Value = "Work Order"
                .Columns(8).HeaderCell.Value = "Meter No"
                .Columns(9).HeaderCell.Value = "Connection Status"
                .Columns(10).HeaderCell.Value = "Gender"
                .Columns(11).HeaderCell.Value = "Earthing"
                .Columns(12).HeaderCell.Value = "Remarks"

            End With
            dgwx.Columns.Item(0).Width = 200
            dgwx.Columns.Item(1).Width = 100
            dgwx.Columns.Item(2).Width = 75
            dgwx.Columns.Item(3).Width = 100
            dgwx.Columns.Item(4).Width = 90
            dgwx.Columns.Item(5).Width = 90
            dgwx.Columns.Item(6).Width = 100
            dgwx.Columns.Item(7).Width = 100
            dgwx.Columns.Item(8).Width = 100
            dgwx.Columns.Item(9).Width = 100
            dgwx.Columns.Item(10).Width = 100
            dgwx.Columns.Item(11).Width = 100
            dgwx.Columns.Item(12).Width = 100
            dgwx.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
    End Sub
    'Save Customer Items
    Private Sub InsertCustomerMeterdetails()
        For Each r As DataGridViewRow In dgwx.Rows
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Insert into tbl_meterrvcd_details(MeterRcptNo, SchemeID, CustomerName, IDNo, PoleNo, PhoneNo, XCoordinate, YCoordinate, YRefNo, WorkOrder, MeterNo, ConnectionStatus, Gender, Earthing, Remarks, IssuanceStatus) VALUES ((Select MAX(MeterReceiptNo) from tbl_meterrvcd_info), '" & txtSchemeID.Text & "','" & (r.Cells(0).Value) & "', '" & r.Cells(1).Value & "', '" & r.Cells(2).Value & "', '" & (r.Cells(3).Value) & "', '" & r.Cells(4).Value & "', '" & r.Cells(5).Value & "', '" & (r.Cells(6).Value) & "', '" & r.Cells(7).Value & "', '" & r.Cells(8).Value & "', '" & (r.Cells(9).Value) & "', '" & r.Cells(10).Value & "', '" & r.Cells(11).Value & "', '" & r.Cells(12).Value & "', '" & cboStatus.Text & "')"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Next
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtSchemeRefNo.Text, TimeOfDay, "Added Customer List")
    End Sub
    'Save customer details
    Private Sub InsertCustomerMeterInfo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_meterrvcd_info(SchemeID, ZRefNo, CountyID, ConstituencyID, Datercvd, Qtyrcvd, ReceivedBy, Workstation, IssuanceStatus) VALUES ('" & txtSchemeID.Text & "', '" & txtSchemeRefNo.Text & "','" & txtCountyID.Text & "', '" & txtConstituencyID.Text & "', '" & lbldate.Text & "', '" & txtQtyrcvd.Text & "', '" & FrmMain.tsslUser.Text & "', '" & FrmMain.LBLComputerName.Text & "', '" & cboStatus.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub btnBrowseexcel_Click(sender As Object, e As EventArgs) Handles btnBrowseexcel.Click
        If txtSchemeID.Text = "" Then
            MessageBox.Show("Please select Scheme Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtwarehouseID.Text = "" Then
            MessageBox.Show("Please select KPLC Warehouse", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ImportList()
    End Sub
    Private Sub txtSchemeRefNo_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeRefNo.TextChanged
        LoadSchemedetails()
    End Sub

    Private Sub btnLoadSchemes_Click(sender As Object, e As EventArgs) Handles btnLoadSchemes.Click
        frmLoadSchemedetails.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmLodWarehouse.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        DeleteEmptyRows()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub ResetForm()
        txtSchemeID.Text = ""
        txtSchemeRefNo.Text = ""
        txtCountyID.Text = ""
        txtConstituencyID.Text = ""
        lbldate.Text = ""
        txtQtyrcvd.Text = ""
        txtWarehouseName.Text = ""
        txtwarehouseID.Text = ""
        txtTXNo.Text = ""
        txtSchemeName.Text = ""
        txtConstituencyname.Text = ""
        txtCounty.Text = ""
        dgwx.DataSource = Nothing
        dgwx.Rows.Clear()
        dgwz.Rows.Clear()

    End Sub
    Private Sub DeleteEmptyRows()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from tbl_meterrvcd_details where CustomerName = '';"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub CSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles CSaveToolStripButton5.Click
        For Each r As DataGridViewRow In dgwx.Rows
            If r.DefaultCellStyle.BackColor = Color.Red Then
                MessageBox.Show("Please remove duplicates to continue", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
                Exit Sub
            End If
        Next
        InsertCustomerMeterInfo()
        InsertCustomerMeterdetails()
        ResetForm()
        MsgBox("Customer List Successfully Uploaded.", MsgBoxStyle.Information, "Metering")

    End Sub
    Private Sub CheckDuplicate()
        For Each r As DataGridViewRow In dgwx.Rows
            Dim style2 = Me.dgwx.DefaultCellStyle.Clone()
            style2.BackColor = Color.Red
            For Each v As DataGridViewRow In dgwz.Rows
                If r.Cells(8).Value.ToString() = v.Cells(1).Value.ToString() Then
                    r.Cells(8).Style = style2
                    r.DefaultCellStyle.BackColor = Color.Red
                Else
                End If
            Next
        Next
    End Sub
    Private Sub btnCheckMeters_Click(sender As Object, e As EventArgs)
        CheckDuplicate()
        RemoveEmptyRows()
        CSaveToolStripButton5.Enabled = True
    End Sub
    Private Sub LoadMeterdetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SchemeID, MeterNo from tbl_meterrvcd_details"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgwz.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgwz.Rows.Add(dr("SchemeID"), dr("MeterNo"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub txtSchemeID_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeID.TextChanged
        LoadMeterdetails()
    End Sub

    Private Sub CVoidToolStripButton3_Click(sender As Object, e As EventArgs) Handles CVoidToolStripButton3.Click
        If dgwx.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please customer list to continue ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try

            If MessageBox.Show("Are You Sure You want to Remove this customer from the list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                dgwx.Rows.Remove(dgwx.CurrentRow)
            End If
        Catch ex As Exception
            MessageBox.Show("Please Select Item to Void", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally

        End Try
    End Sub
    Private Sub DuplicatesToolStripButton4_Click(sender As Object, e As EventArgs) Handles DuplicatesToolStripButton4.Click
        If txtSchemeID.Text = "" Then
            MessageBox.Show("Please select Scheme Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtwarehouseID.Text = "" Then
            MessageBox.Show("Please select KPLC Warehouse", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtQtyrcvd.Text = "" Then
            MessageBox.Show("Please enter total number of meters received", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        CheckDuplicate()
        RemoveEmptyRows()
        CSaveToolStripButton5.Enabled = True
    End Sub
End Class