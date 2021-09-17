Option Explicit On
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Imports System.Data.OleDb
Public Class frmJMCDetails
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


    Private Sub frmJMCDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLoadSchemes_Click(sender As Object, e As EventArgs) Handles btnLoadSchemes.Click
        frmLoadJMCScheme.ShowDialog()
    End Sub

    Private Sub txtSchemeRefNo_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeRefNo.TextChanged
        LoadSchemedetails()
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
                .Columns(0).HeaderCell.Value = "Pole No"
                .Columns(1).HeaderCell.Value = "Descr"
                .Columns(2).HeaderCell.Value = "WP"
                .Columns(3).HeaderCell.Value = "CP"
                .Columns(4).HeaderCell.Value = "1PH"
                .Columns(5).HeaderCell.Value = "3PH"
                .Columns(6).HeaderCell.Value = "LVFittingWP"
                .Columns(7).HeaderCell.Value = "LVFittingCP"
                .Columns(8).HeaderCell.Value = "WPN-Stay"
                .Columns(9).HeaderCell.Value = "CPN-Stay"
                .Columns(10).HeaderCell.Value = "WPF-Stay"
                .Columns(11).HeaderCell.Value = "CPF-Saty"
                .Columns(12).HeaderCell.Value = "Strut-Stay"
                .Columns(13).HeaderCell.Value = "Danger Plate"
                .Columns(14).HeaderCell.Value = "Polecap"
                .Columns(15).HeaderCell.Value = "PME"
                .Columns(16).HeaderCell.Value = "Linetaps"
                .Columns(17).HeaderCell.Value = "1PHMeter"
                .Columns(18).HeaderCell.Value = "MCB"
                .Columns(19).HeaderCell.Value = "Meterbox"
                .Columns(20).HeaderCell.Value = "UniversalClamps"
                .Columns(21).HeaderCell.Value = "S-Cable"
                .Columns(22).HeaderCell.Value = "S-cablefittings"
                .Columns(23).HeaderCell.Value = "EarthsetforR-Boards"
                .Columns(24).HeaderCell.Value = "ReadyBoards"


            End With
            dgwx.Columns.Item(0).Width = 75.ToString()
            dgwx.Columns.Item(1).Width = 75
            dgwx.Columns.Item(2).Width = 50
            dgwx.Columns.Item(3).Width = 50
            dgwx.Columns.Item(4).Width = 50
            dgwx.Columns.Item(5).Width = 50
            dgwx.Columns.Item(6).Width = 75
            dgwx.Columns.Item(7).Width = 75
            dgwx.Columns.Item(8).Width = 75
            dgwx.Columns.Item(9).Width = 75
            dgwx.Columns.Item(10).Width = 75
            dgwx.Columns.Item(11).Width = 75
            dgwx.Columns.Item(12).Width = 75
            dgwx.Columns.Item(13).Width = 75
            dgwx.Columns.Item(14).Width = 75
            dgwx.Columns.Item(15).Width = 75
            dgwx.Columns.Item(16).Width = 75
            dgwx.Columns.Item(17).Width = 75
            dgwx.Columns.Item(18).Width = 75
            dgwx.Columns.Item(19).Width = 75
            dgwx.Columns.Item(20).Width = 75
            dgwx.Columns.Item(21).Width = 75
            dgwx.Columns.Item(22).Width = 75
            dgwx.Columns.Item(23).Width = 75
            dgwx.Columns.Item(24).Width = 75

            dgwx.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
    End Sub

    Private Sub btnBrowseexcel_Click(sender As Object, e As EventArgs) Handles btnBrowseexcel.Click
        If txtSchemeID.Text = "" Then
            MessageBox.Show("Please select Scheme Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ImportList()
    End Sub

    Private Sub CheckSchemeJMCUploaded()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            cmd = New MySqlCommand(Query, MysqlConn)
            With cmd
                .Connection = MysqlConn
                .CommandText = "SELECT COUNT(*) FROM tbl_jmc WHERE SchemeId  = '" & txtSchemeID.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Scheme JMC Uploaded!", MsgBoxStyle.Exclamation, "JMC!")
                txtSchemeName.Text = ""
                txtSchemeRefNo.Text = ""
                txtSchemeID.Text = ""
                txtConstituencyID.Text = ""
                txtCounty.Text = ""
                txtTXNo.Text = ""
                txtCounty.Text = ""
                txtConstituencyname.Text = ""
                txtConstituencyname.Text = ""
                txtCounty.Text = ""
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub txtSchemeID_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeID.TextChanged
        CheckSchemeJMCUploaded()
    End Sub

    Private Sub InsertJMC()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_jmc(SchemeId, Date, Createdby, Workstation) VALUES ('" & txtSchemeID.Text & "', '" & lbldate.Text & "', '" & FrmMain.tsslUser.Text & "', '" & FrmMain.LBLComputerName.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub InsertJMCdetails()
        For Each r As DataGridViewRow In dgwx.Rows
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Insert into tbl_jmcdetails(JMCNo, PoleNo, PoleDesc, WP, CP, 1PH, 3PH, LVFittingWP, LVFittingCP, WPNStay, CPNStay, WPFStay, CPFStay, Strutstay,  Dangerplate, Polecap, PME, Linetaps, 1PHMeter, MCB,  Meterbox, Universalclamps, Servicecable, Servicecablefittings, EarthsetforRB, Readyboards) VALUES ((Select MAX(JMCNo) from tbl_jmc), '" & (r.Cells(0).Value) & "', '" & r.Cells(1).Value & "', '" & r.Cells(2).Value & "', '" & (r.Cells(3).Value) & "', '" & r.Cells(4).Value & "', '" & r.Cells(5).Value & "', '" & (r.Cells(6).Value) & "', '" & r.Cells(7).Value & "', '" & r.Cells(8).Value & "', '" & (r.Cells(9).Value) & "', '" & r.Cells(10).Value & "', '" & r.Cells(11).Value & "', '" & r.Cells(12).Value & "', '" & r.Cells(13).Value & "', '" & r.Cells(14).Value & "', '" & r.Cells(15).Value & "', '" & r.Cells(16).Value & "', '" & r.Cells(17).Value & "', '" & r.Cells(18).Value & "', '" & r.Cells(19).Value & "', '" & r.Cells(20).Value & "', '" & r.Cells(21).Value & "', '" & r.Cells(22).Value & "', '" & r.Cells(23).Value & "', '" & r.Cells(24).Value & "')"
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
        Audit_Trail(FrmMain.tsslUser.Text, txtSchemeRefNo.Text, TimeOfDay, "Added JMC")
    End Sub

    Private Sub CSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles CSaveToolStripButton5.Click
        If txtSchemeID.Text = "" Then
            MessageBox.Show("Please select Scheme Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        InsertJMC()
        InsertJMCdetails()
        MsgBox("JMC details successfully added.", MsgBoxStyle.Information, "JMC")
        Reset()
    End Sub
    Private Sub Reset()
        txtSchemeName.Text = ""
        txtSchemeRefNo.Text = ""
        txtSchemeID.Text = ""
        txtConstituencyID.Text = ""
        txtCounty.Text = ""
        txtTXNo.Text = ""
        txtCounty.Text = ""
        txtConstituencyname.Text = ""
        txtConstituencyname.Text = ""
        txtCounty.Text = ""
        dgwx.Columns.Clear()
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

    Private Sub CVoidToolStripButton3_Click(sender As Object, e As EventArgs) Handles CVoidToolStripButton3.Click
        Try

            If MessageBox.Show("Are You Sure You want to remove this row from the list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                dgwx.Rows.Remove(dgwx.CurrentRow)
            End If
        Catch ex As Exception
            MessageBox.Show("Please Select Item to Void", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally

        End Try

        RemoveEmptyRows()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Reset()
    End Sub
End Class