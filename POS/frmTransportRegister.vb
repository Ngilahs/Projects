Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmTransporterRegister
    Public Sub GetTransportTaskNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Transportdetailsid FROM tbl_transportdetails ORDER BY Transportdetailsid DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblTransporttaskId.Text = dr("Transportdetailsid") + 1
            Else
                lblTransporttaskId.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub Loadtransporters()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select TransporterId, Transportername from tbl_transporter"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboTransporter.Items.Clear()
            Do While dr.Read = True
                cboTransporter.Items.Add(dr("Transportername"))
                cboTransporter.Text = "Transporter"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadTransporterID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select TransporterId, Transportername from tbl_transporter where Transportername = '" & cboTransporter.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txttransId.Text = dr("TransporterId")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadWarehouses()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select warehouseId, warehousename from tbl_warehouse"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cbowarehouses.Items.Clear()
            Do While dr.Read = True
                cbowarehouses.Items.Add(dr("warehousename"))
                cbowarehouses.Text = "Warehouse"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadWarehouseID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select warehouseId, warehousename from tbl_warehouse where warehousename = '" & cbowarehouses.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtwarehouseid.Text = dr("warehouseId")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadDeliverynotes()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select DeliveryNo from delivery_details"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboDeliveryNo.Items.Clear()
            Do While dr.Read = True
                cboDeliveryNo.Items.Add(dr("DeliveryNo"))
                cboDeliveryNo.Text = "Delivery Note"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmTransportRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOne.Text = 1
        Loadtransporters()
        LoadWarehouses()
        LoadDeliverynotes()
    End Sub

    Private Sub btnLoadVehicles_Click(sender As Object, e As EventArgs) Handles btnLoadVehicles.Click
        frmLoadVehicles.ShowDialog()
    End Sub

    Private Sub btnWarehouse_Click(sender As Object, e As EventArgs)
        frmLodWarehouse.ShowDialog()
    End Sub

    Private Sub cboTransporter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTransporter.SelectedIndexChanged
        LoadTransporterID()
    End Sub

    Private Sub cbowarehouses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbowarehouses.SelectedIndexChanged
        LoadWarehouseID()
    End Sub

    Private Sub btnLoadSchemes_Click(sender As Object, e As EventArgs) Handles btnLoadSchemes.Click
        frmLoadMaterials.ShowDialog()
    End Sub
    Private Sub txtRate_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtqtyinvoiced_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilometers.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtAmount_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAddScheme_Click(sender As Object, e As EventArgs) Handles btnAddScheme.Click
        If txtTaskDescription.Text = "" Then
            MessageBox.Show("Please enter Task Description", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtSchemeID.Text = "" Then
            MessageBox.Show("Please enter Scheme Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtVehicleId.Text = "" Then
            MessageBox.Show("Please Choose Vehicle Reg No", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtwarehouseid.Text = "" Then
            MessageBox.Show("Please Choose Warehouse Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txttransId.Text = "" Then
            MessageBox.Show("Please Choose Transporter", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtKilometers.Text = "" Then
            MessageBox.Show("Please enter Kilometers covered", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtSitename.Text = "" Then
            MessageBox.Show("Please enter Site name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cboDeliveryNo.Text = "" Then
            MessageBox.Show("Please enter Site name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim rnum As Integer = dgw.Rows.Add()
        dgw.Rows.Item(rnum).Cells(0).Value = txtTaskDescription.Text
        dgw.Rows.Item(rnum).Cells(1).Value = cboDeliveryNo.Text
        dgw.Rows.Item(rnum).Cells(2).Value = cbowarehouses.Text
        dgw.Rows.Item(rnum).Cells(3).Value = txtwarehouseid.Text
        dgw.Rows.Item(rnum).Cells(4).Value = txtSchemeName.Text
        dgw.Rows.Item(rnum).Cells(5).Value = txtSchemeID.Text
        dgw.Rows.Item(rnum).Cells(6).Value = txtOne.Text
        CountSchemesdelivered()
        cboTransporter.Enabled = False
        txtvehicleRegNo.Enabled = False
        calculation()
        txtSchemeID.Text = ""
        txtCountyID.Text = ""
        txtConstituencyID.Text = ""
        txtConstituencyname.Text = ""
        txtCounty.Text = ""
        txtSchemeName.Text = ""
        txtSchemeRefNo.Text = ""
        txtTXNo.Text = ""
        cboDeliveryNo.Text = ""
    End Sub
    Private Sub CountSchemesdelivered()
        Dim Scheme As Decimal
        For r = 0 To dgw.Rows.Count - 1
            Scheme += dgw.Rows(r).Cells(6).Value
            txtCount.Text = Scheme
        Next
    End Sub
    Private Sub calculation()
        Dim amt As Decimal
        For r = 0 To dgw.Rows.Count - 1
            amt = txtAmount.Text / txtCount.Text
            dgw.Rows(r).Cells(7).Value = Format(amt, "#,##0.00")
        Next
    End Sub

    Private Sub InsertTransportDetails()
        If txtTaskDescription.Text = "" Then
            MessageBox.Show("Please enter Task Description", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtVehicleId.Text = "" Then
            MessageBox.Show("Please Choose Vehicle Reg No", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtwarehouseid.Text = "" Then
            MessageBox.Show("Please Choose Warehouse Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txttransId.Text = "" Then
            MessageBox.Show("Please Choose Transporter", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtKilometers.Text = "" Then
            MessageBox.Show("Please enter Kilometers covered", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtSitename.Text = "" Then
            MessageBox.Show("Please enter Site name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Dim lastinserted As Integer
        Try
            MysqlConn.Open()
            Dim Query As String
            ' Query = "INSERT INTO tbl_transportdetails(Transportdetailsid, Taskdescription, TransporterId, VehicleId, TransDate, WarehouseID, SiteName, KmtoSite, Amount, createdby) VALUES ('" & lblTransporttaskId.Text & "', '" & txtTaskDescription.Text & "', '" & txttransId.Text & "', '" & txtVehicleId.Text & "', '" & lbldate.Text & "', '" & txtwarehouseid.Text & "', '" & txtSitename.Text & "', '" & txtKilometers.Text & "', '" & txtAmount.Text & "', '" & FrmMain.tsslUser.Text & "')"
            Query = "INSERT INTO tbl_transportdetails(Taskdescription, TransporterId, VehicleId, TransDate, WarehouseID, SiteName, KmtoSite, Amount, createdby) VALUES ('" & txtTaskDescription.Text & "', '" & txttransId.Text & "', '" & txtVehicleId.Text & "', '" & lbldate.Text & "', '" & txtwarehouseid.Text & "', '" & txtSitename.Text & "', '" & txtKilometers.Text & "', '" & txtAmount.Text & "', '" & FrmMain.tsslUser.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblTransporttaskId.Text, TimeOfDay, "Added New Transport Task")
    End Sub
    Private Sub InsertTransportTaskItems()
        For Each r As DataGridViewRow In dgw.Rows
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Query As String
                ''" & lblTransporttaskId.Text & "',
                Query = "Insert into tbl_transportregisteritems (TransportregisterId, Taskdescription, DeliveryNo, WarehouseId, SchemeId, Cost) VALUES ((SELECT MAX(Transportdetailsid) from tbl_transportdetails ), '" & (r.Cells(0).Value) & "', '" & (r.Cells(1).Value) & "', '" & r.Cells(3).Value & "', '" & r.Cells(5).Value & "', '" & r.Cells(7).Value & "')"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub ResetForm()
        txtTaskDescription.Text = ""
        cboDeliveryNo.Text = ""
        cbowarehouses.Text = ""
        txtwarehouseid.Text = ""
        txtSchemeName.Text = ""
        txtSchemeID.Text = ""
        txtOne.Text = ""
        cboTransporter.Enabled = True
        txtvehicleRegNo.Enabled = True
        calculation()
        txtSchemeID.Text = ""
        txtCountyID.Text = ""
        txtConstituencyID.Text = ""
        txtConstituencyname.Text = ""
        txtCounty.Text = ""
        txtSchemeName.Text = ""
        txtSchemeRefNo.Text = ""
        txtTXNo.Text = ""
        cboDeliveryNo.Text = ""
        txtSitename.Text = ""
        txtKilometers.Text = ""
        txtvehicleRegNo.Text = ""
        txtAmount.Text = ""
        txtVehicleId.Text = ""
        txtwarehouseid.Text = ""
        txttransId.Text = ""
        Loadtransporters()
        LoadWarehouses()
        LoadDeliverynotes()
        dgw.Rows.Clear()
        GetTransportTaskNo()
    End Sub
    Private Sub SaveTransportTask_Click(sender As Object, e As EventArgs) Handles SaveTransportTask.Click
        Dim rnum As Integer
        If dgw.RowCount = 0 Then
            MessageBox.Show("Please enter Scheme to transport to!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        'GetTransportTaskNo()
        InsertTransportDetails()
        InsertTransportTaskItems()
        ResetForm()
        MsgBox("Transport Task successfully added.", MsgBoxStyle.Information, "Add Transport Task")

    End Sub

    Private Sub btnNewItem_Click(sender As Object, e As EventArgs) Handles btnNewItem.Click
        ResetForm()
    End Sub

    Private Sub ResetTransportRegister_Click(sender As Object, e As EventArgs) Handles ResetTransportRegister.Click
        ResetForm()
    End Sub


End Class