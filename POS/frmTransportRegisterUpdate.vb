Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmTransportRegisterUpdate
    Dim y As Integer
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
                'cboTransporter.Text = "Transporter"
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
                'cbowarehouses.Text = "Warehouse"
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
                'cboDeliveryNo.Text = "Delivery Note"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmTransportRegisterUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadtransporters()
        LoadWarehouses()
        LoadDeliverynotes()
        btnInsert.Enabled = False
    End Sub

    Private Sub cbowarehouses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbowarehouses.SelectedIndexChanged
        LoadWarehouseID()
    End Sub

    Private Sub cboTransporter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTransporter.SelectedIndexChanged
        LoadTransporterID()
    End Sub

    Private Sub btnLoadSchemes_Click(sender As Object, e As EventArgs) Handles btnLoadSchemes.Click
        frmLoadMaterials.ShowDialog()
    End Sub

    Private Sub btnLoadVehicles_Click(sender As Object, e As EventArgs) Handles btnLoadVehicles.Click
        frmLoadVehicles.ShowDialog()
    End Sub

    Private Sub LoadTransTasks()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Transportdetailsid, Taskdescription, TransporterId, VehicleId, TransDate, WarehouseID, SiteName from tbl_transportdetails where SiteName LIKE '%" & txtsite.Text & "%' or Taskdescription LIKE '%" & txtsite.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw1.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw1.Rows.Add(dr("Transportdetailsid"), dr("Taskdescription"), dr("SiteName"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub txtsite_TextChanged(sender As Object, e As EventArgs) Handles txtsite.TextChanged
        LoadTransTasks()
    End Sub
    Private Sub LoadTaskDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
tbl_transportdetails.Transportdetailsid,
tbl_transportdetails.Taskdescription,
tbl_transportdetails.TransporterId,
tbl_transportdetails.VehicleId,
tbl_transportdetails.WarehouseID,
tbl_transportdetails.SiteName,
tbl_transportdetails.KmtoSite,
tbl_transportdetails.Amount,
tbl_transportdetails.TransDate,
tbl_warehouse.warehousename,
tbl_transporter.Transportername,
tbl_vehicles.vehicle_no
FROM
tbl_transportdetails INNER Join tbl_transporter ON tbl_transporter.TransporterId = tbl_transportdetails.TransporterId
INNER Join tbl_vehicles ON tbl_vehicles.vehiclesid = tbl_transportdetails.VehicleId
INNER Join tbl_warehouse ON tbl_warehouse.warehouseId = tbl_transportdetails.WarehouseID where tbl_transportdetails.Transportdetailsid = '" & dgw1.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            'dgw1.Rows.Clear()
            Do While dr.Read = True
                LblTaskNo.Text = dr("Transportdetailsid")
                txtTaskDescription.Text = dr("Taskdescription")
                cbowarehouses.Text = dr("warehousename")
                txtwarehouseid.Text = dr("WarehouseID")
                txtSitename.Text = dr("SiteName")
                txtKilometers.Text = dr("KmtoSite")
                txtvehicleRegNo.Text = dr("vehicle_no")
                txtAmount.Text = dr("Amount")
                txtVehicleId.Text = dr("VehicleId")
                txtwarehouseid.Text = dr("WarehouseID")
                LblTaskNo.Text = dr("Transportdetailsid")
                cboTransporter.Text = dr("Transportername")
                lblTransporttaskId.Text = dr("Transportdetailsid")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub dgw1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw1.CellContentClick
        LoadTaskDetails()
        LoadTransportTasks()
    End Sub
    Private Sub LoadTransportTasks()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                    tbl_transportregisteritems.TransportregisterId,
                    tbl_transportregisteritems.Taskdescription,
                    tbl_transportregisteritems.DeliveryNo,
                    tbl_transportregisteritems.WarehouseId,
                    tbl_transportregisteritems.SchemeId,
                    tbl_transportregisteritems.Cost,
                    schemes.Scheme_Name,
                    tbl_warehouse.warehousename
                    FROM
                    schemes
                    INNER JOIN tbl_transportregisteritems ON tbl_transportregisteritems.SchemeId = schemes.SchemeNo
                    INNER JOIN delivery_details ON delivery_details.DeliveryNo = tbl_transportregisteritems.DeliveryNo
                    INNER JOIN tbl_warehouse ON tbl_transportregisteritems.WarehouseId = tbl_warehouse.warehouseId where TransportregisterId =  '" & LblTaskNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("TransportregisterId"), dr("Taskdescription"), dr("DeliveryNo"), dr("warehousename"), dr("WarehouseId"), dr("Scheme_Name"), dr("SchemeId"), dr("Cost"), 1)
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadSchemeDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                    tbl_transportregisteritems.SchemeId,
                    schemes.Scheme_Name,
                    schemes.Scheme_Ref_No,
                    schemes.Substation_No,
                    schemes.County_Id,
                    schemes.Constituency_Id,
                    constituency.constituency_Name,
                    county.County_Name
                    FROM
                    tbl_transportregisteritems
                    INNER JOIN schemes ON schemes.SchemeNo = tbl_transportregisteritems.SchemeId
                    INNER JOIN constituency ON constituency.Constituency_No = schemes.Constituency_Id
                    INNER JOIN county ON county.County_No = schemes.County_Id where SchemeId = '" & txtSchemeID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            'dgw1.Rows.Clear()
            Do While dr.Read = True
                txtSchemeRefNo.Text = dr("Scheme_Ref_No")
                txtCountyID.Text = dr("County_Id")
                txtConstituencyID.Text = dr("Constituency_Id")
                txtConstituencyname.Text = dr("constituency_Name")
                txtCounty.Text = dr("County_Name")
                txtTxno.Text = dr("Substation_No")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim dr As DataGridViewRow = dgw.SelectedRows(0)
        lblTransporttaskId.Text = dr.Cells(0).Value.ToString()
        cboDeliveryNo.Text = dr.Cells(2).Value.ToString()
        txtSchemeName.Text = dr.Cells(5).Value.ToString()
        txtSchemeID.Text = dr.Cells(6).Value.ToString()
    End Sub


    Private Sub CheckTransportRegistertoUpdate()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            'BillingID, ItemNo txtItemCode
            MysqlConn.Open()
            Dim Query As String
            cmd = New MySqlCommand(Query, MysqlConn)
            With cmd
                .Connection = MysqlConn
                .CommandText = "SELECT COUNT(*) FROM tbl_transportregisteritems WHERE TransportregisterId  = '" & lblTransporttaskId.Text & "' and DeliveryNo = '" & cboDeliveryNo.Text & "' and WarehouseId  = '" & txtwarehouseid.Text & "' and SchemeId = '" & txtSchemeID.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Please click updating button to post changes", MsgBoxStyle.Exclamation, "Update Transport Register!")
                btnInsert.Text = "Updating"
                btnInsert.Enabled = True
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub CheckTransportRegistertoInsert()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            'BillingID, ItemNo txtItemCode
            MysqlConn.Open()
            Dim Query As String
            cmd = New MySqlCommand(Query, MysqlConn)
            With cmd
                .Connection = MysqlConn
                .CommandText = "Select COUNT(*) FROM tbl_transportregisteritems WHERE TransportregisterId  = '" & lblTransporttaskId.Text & "' and DeliveryNo = '" & cboDeliveryNo.Text & "' and WarehouseId  = '" & txtwarehouseid.Text & "' and SchemeId = '" & txtSchemeID.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) < 1 Then
                MsgBox("Please click saving button to post changes", MsgBoxStyle.Exclamation, "Update Transport Register!")
                btnInsert.Text = "Saving"
                btnInsert.Enabled = True
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
        LoadSchemeDetails()
    End Sub

    Private Sub btnAddScheme_Click(sender As Object, e As EventArgs) Handles AddTransportRegiterItems.Click
        If txtSchemeID.Text = "" Then
            MessageBox.Show("Please select record in the table below to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtSchemeID.Focus()
            Return
        End If
        If txtwarehouseid.Text = "" Then
            MessageBox.Show("Please select Warehouse", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            cbowarehouses.Focus()
            Return
        End If
        If txtVehicleId.Text = "" Then
            MessageBox.Show("Please select Vehicle No", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtVehicleId.Focus()
            Return
        End If
        If txttransId.Text = "" Then
            MessageBox.Show("Please enter Transporter", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            cboTransporter.Focus()
            Return
        End If
        CheckTransportRegistertoUpdate()
        CheckTransportRegistertoInsert()
        btnInsert.Enabled = True
    End Sub
    Private Sub CountSchemesdelivered()
        Dim Scheme As Decimal
        For r = 0 To dgw.Rows.Count - 1
            Scheme += dgw.Rows(r).Cells(8).Value
            txtCount.Text = Scheme + 1
        Next
    End Sub
    Private Sub calculation()
        Dim amt As Decimal
        For r = 0 To dgw.Rows.Count - 1
            amt = Val(txtAmount.Text) / Val(txtCount.Text)
            txtCost.Text = Format(amt, "#,##0.00")
        Next
    End Sub
    'Insert if the items are not available in the database
    Private Sub InsertTransportTaskItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Insert into tbl_transportregisteritems (TransportregisterId, Taskdescription, DeliveryNo, WarehouseId, SchemeId, Cost) VALUES ('" & lblTransporttaskId.Text & "', '" & txtTaskDescription.Text & "', '" & cboDeliveryNo.Text & "', '" & txtwarehouseid.Text & "', '" & txtSchemeID.Text & "', '" & txtCost.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    'update cost after insert event
    Private Sub UpdateTransportCostafterInsert()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            If txtSchemeID.Text = "" Then
                MessageBox.Show("Please enter records to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtSchemeID.Focus()
                Return
            End If
            If cboDeliveryNo.Text = "" Then
                MessageBox.Show("Please select Delivery No", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cboDeliveryNo.Focus()
                Return
            End If
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE tbl_transportregisteritems SET Cost = '" & txtCost.Text & "'WHERE TransportregisterId  = '" & lblTransporttaskId.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Transport Register successfully Updated.", MsgBoxStyle.Information, "Update Transport Register")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblTransporttaskId.Text, TimeOfDay, "Update Transport Register Cost")
    End Sub
    'update Transport Register details
    Private Sub UpdateInvoiceDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            If txtwarehouseid.Text = "" Then
                MessageBox.Show("Please select Warehouse", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cbowarehouses.Focus()
                Return
            End If
            If txtVehicleId.Text = "" Then
                MessageBox.Show("Please select Vehicle No", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtVehicleId.Focus()
                Return
            End If
            If txttransId.Text = "" Then
                MessageBox.Show("Please enter Transporter", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cboTransporter.Focus()
                Return
            End If
            If txtSchemeID.Text = "" Then
                MessageBox.Show("Please select record in the table below to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtSchemeID.Focus()
                Return
            End If
            MysqlConn.Open()
            Dim Query As String
            'Transportdetailsid, Taskdescription, TransporterId, VehicleId, TransDate, WarehouseID, SiteName, KmtoSite, Amount, createdby
            Query = "UPDATE tbl_transportdetails SET TransporterId = '" & txttransId.Text & "', VehicleId = '" & txtVehicleId.Text & "', WarehouseID = '" & txtwarehouseid.Text & "', KmtoSite = '" & txtKilometers.Text & "', Amount = '" & txtAmount.Text & "' WHERE Transportdetailsid = '" & lblTransporttaskId.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            'MsgBox("Item successfully Updated.", MsgBoxStyle.Information, "Update Item")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblTransporttaskId.Text, TimeOfDay, "Updated Transport Register Details")
        Reset()
        getData()
    End Sub

    Private Sub CountSchemesdelivered2()
        Dim Scheme As Decimal
        For r = 0 To dgw.Rows.Count - 1
            Scheme += dgw.Rows(r).Cells(8).Value
            txtCount.Text = Scheme
        Next
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If txtSchemeID.Text = "" Then
            MessageBox.Show("Please select record in the table below to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtSchemeID.Focus()
            Return
        End If
        If txtwarehouseid.Text = "" Then
            MessageBox.Show("Please select Warehouse", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            cbowarehouses.Focus()
            Return
        End If
        If txtVehicleId.Text = "" Then
            MessageBox.Show("Please select Vehicle No", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtVehicleId.Focus()
            Return
        End If
        If txttransId.Text = "" Then
            MessageBox.Show("Please enter Transporter", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            cboTransporter.Focus()
            Return
        End If

        If btnInsert.Text = "Saving" Then
            CountSchemesdelivered()
            calculation()
            InsertTransportTaskItems()
            UpdateTransportCostafterInsert()
            ResetForm()
            btnInsert.Enabled = False
        Else
            If btnInsert.Text = "Updating" Then
                CountSchemesdelivered2()
                calculation()
                UpdateInvoiceDetails()
                UpdateTransportCostafterInsert()
                ResetForm()
                btnInsert.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub CountSchemes()
        Dim Scheme As Decimal
        For r = 0 To dgw.Rows.Count - 1
            Scheme += dgw.Rows(r).Cells(8).Value
            txtCount.Text = Scheme
        Next
    End Sub
    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        CountSchemes()
        calculation()
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
    Private Sub ResetForm()
        txtTaskDescription.Text = ""
        cboDeliveryNo.Text = ""
        cbowarehouses.Text = ""
        txtwarehouseid.Text = ""
        txtSchemeName.Text = ""
        txtSchemeID.Text = ""
        txtOne.Text = ""
        cboTransporter.Text = ""
        txtSchemeID.Text = ""
        txtCountyID.Text = ""
        txtConstituencyID.Text = ""
        txtConstituencyname.Text = ""
        txtCounty.Text = ""
        txtSchemeName.Text = ""
        txtSchemeRefNo.Text = ""
        txtTxno.Text = ""
        cboDeliveryNo.Text = ""
        txtSitename.Text = ""
        txtKilometers.Text = ""
        txtvehicleRegNo.Text = ""
        txtAmount.Text = ""
        txtVehicleId.Text = ""
        txtwarehouseid.Text = ""
        txttransId.Text = ""
        txtCount.Text = ""
        btnInsert.Text = "Save"
        cboTransporter.Enabled = True
        txtvehicleRegNo.Enabled = True
        Loadtransporters()
        LoadWarehouses()
        LoadDeliverynotes()
        dgw.Rows.Clear()
    End Sub
End Class