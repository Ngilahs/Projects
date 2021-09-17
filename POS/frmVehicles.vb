Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class frmVehicles
    Dim y As Integer
    Private Sub frmVehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CSaveToolStripButton5.Enabled = True
        CUpdateToolStripButton3.Enabled = False
    End Sub
    Private Sub AddVehicles()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        ' MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtvehicleNo.Text = "" Or txtType.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtvehicleNo.Focus()
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_vehicles(vehicle_no, Type) VALUES('" & txtvehicleNo.Text & "', '" & txtType.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("New vehicle successfully added.", MsgBoxStyle.Information, "Add vehicle")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtvehicleNo.Text, TimeOfDay, "Added New vehicle")
    End Sub

    Private Sub UpdateVehicle()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        ' MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtvehicleNo.Text = "" Or txtType.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtvehicleNo.Focus()
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE tbl_vehicles SET vehicle_no= '" & txtvehicleNo.Text & "', Type = '" & txtType.Text & "' WHERE vehiclesid = '" & lblVehicleNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Vehicle successfully updated.", MsgBoxStyle.Information, "Update vehicle")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtvehicleNo.Text, TimeOfDay, "Updated vehicle Information")
    End Sub

    Private Sub txtvehicleNo_TextChanged(sender As Object, e As EventArgs) Handles txtvehicleNo.KeyUp
        'Check for duplicate entry of Category
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        ' MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            cmd = New MySqlCommand(Query, MysqlConn)
            With cmd
                .Connection = MysqlConn
                .CommandText = "SELECT COUNT(*) FROM tbl_vehicles WHERE vehicle_no  = '" & txtvehicleNo.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Vehicle No Already Exists!", MsgBoxStyle.Exclamation, "Add New Vehicle!")
                txtvehicleNo.Clear()
                txtvehicleNo.Focus()
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub txtSearchByCategory_TextChanged(sender As Object, e As EventArgs) Handles txtSearchByVehicle.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        ' MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT vehiclesid, vehicle_no, Type from tbl_vehicles where vehicle_no LIKE '" & txtSearchByVehicle.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("vehiclesid"), dr("vehicle_no"), dr("Type"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.lblVehicleNo.Text = dgw.Item(0, i).Value
        Me.txtvehicleNo.Text = dgw.Item(1, i).Value
        Me.txtType.Text = dgw.Item(2, i).Value
        CSaveToolStripButton5.Enabled = False
        CUpdateToolStripButton3.Enabled = True
    End Sub

    Private Sub CSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles CSaveToolStripButton5.Click
        AddVehicles()
        ClearAll()
    End Sub

    Private Sub CUpdateToolStripButton3_Click(sender As Object, e As EventArgs) Handles CUpdateToolStripButton3.Click
        UpdateVehicle()
        ClearAll()
    End Sub
    Private Sub ClearAll()
        txtType.Text = ""
        txtvehicleNo.Text = ""
        txtSearchByVehicle.Text = ""
        dgw.Rows.Clear()
    End Sub
End Class