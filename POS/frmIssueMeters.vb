Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Configuration
Public Class frmIssueMeters
    Dim y As Integer
    Private Sub PopulateVehicles()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT vehiclesid, vehicle_no, Type from tbl_vehicles ORDER BY vehicle_no"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboVehicleNo.Items.Clear()
            Do While dr.Read = True
                cboVehicleNo.Items.Add(dr("vehicle_no"))
                cboVehicleNo.Text = "Description"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadSubcontractors()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select subcontractors_ID,subcontractor_Name from tbl_subcontractors"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                cboSubcontractor.Items.Add(dr("subcontractor_Name"))
                cboSubcontractor.Text = "Sub-contractor"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmIssueMeters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateVehicles()
        LoadSubcontractors()
        cboStatus.Text = "Issued"
    End Sub
    Private Sub PopulateVehicleID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT vehiclesid, vehicle_no, Type from tbl_vehicles where vehicle_no ='" & cboVehicleNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            'cboSearchItem.Items.Clear()
            If dr.Read = True Then
                txtVehicleID.Text = dr("vehiclesid")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadSubcontractorID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select subcontractors_ID,subcontractor_Name from tbl_subcontractors where subcontractor_Name = '" & cboSubcontractor.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtSubcontractorID.Text = dr("subcontractors_ID")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub cboSubcontractor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubcontractor.SelectedIndexChanged
        LoadSubcontractorID()
    End Sub

    Private Sub cboVehicleNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVehicleNo.SelectedIndexChanged
        PopulateVehicleID()
    End Sub
    Private Sub LoadMeterReceipts()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT MeterReceiptNo from tbl_meterrvcd_info Where SchemeID = '" & txtSchemeID.Text & "' and IssuanceStatus = 'Not Issued'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                cboBatchNo.Items.Add(dr("MeterReceiptNo"))
                cboBatchNo.Text = "Batch No"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    'List meter details
    Private Sub LoadMeterdetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT MeterRcptNo, CustomerName, IDNo, PhoneNo,  MeterNo, MeterrvcdCustDetailNo from tbl_meterrvcd_details Where MeterRcptNo = '" & cboBatchNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgwz.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgwz.Rows.Add(dr("MeterRcptNo"), dr("CustomerName"), dr("IDNo"), dr("PhoneNo"), dr("MeterNo"), dr("MeterrvcdCustDetailNo"))
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
        LoadMeterReceipts()
    End Sub

    Private Sub cboBatchNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBatchNo.SelectedIndexChanged
        LoadMeterdetails()
        txtQtyIssued.Text = dgwz.RowCount
        btnLoadSchemes.Enabled = False
        txtSchemeRefNo.Enabled = False
    End Sub
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
    Private Sub txtSchemeRefNo_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeRefNo.TextChanged
        LoadSchemedetails()
    End Sub

    Private Sub btnLoadSchemes_Click(sender As Object, e As EventArgs) Handles btnLoadSchemes.Click
        frmLoadSchemedetails.ShowDialog()
    End Sub

    Private Sub btnLoadWarehouses_Click(sender As Object, e As EventArgs) Handles btnLoadWarehouses.Click
        frmLodWarehouse.ShowDialog()
    End Sub

    Private Sub CVoidToolStripButton3_Click(sender As Object, e As EventArgs) Handles CVoidToolStripButton3.Click
        If dgwz.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please customer list to continue ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try

            If MessageBox.Show("Are You Sure You want to Remove this customer from the list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                dgwz.Rows.Remove(dgwz.CurrentRow)
            End If
        Catch ex As Exception
            MessageBox.Show("Please Select Item to Void", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally

        End Try
        txtQtyIssued.Text = dgwz.RowCount
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub InsertMeterIssuanceItems()
        For Each r As DataGridViewRow In dgwz.Rows
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Insert into tbl_issuemeter_items(meterissuanceno, meterno, status) VALUES ((Select MAX(MeterissuanceNo) from tbl_issuemeter_details), '" & (r.Cells(4).Value) & "', '" & cboStatus.Text & "')"
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
    Private Sub InsertMeterIssuanceDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_issuemeter_details(SchemeID, WarehouseID, VehicleID, SubcontractorID, QtyIssued, DateIssued, IssuedBy, Workstation) VALUES ('" & txtSchemeID.Text & "', '" & txtwarehouseID.Text & "', '" & txtVehicleID.Text & "', '" & txtSubcontractorID.Text & "', '" & txtQtyIssued.Text & "','" & lbldate.Text & "', '" & FrmMain.tsslUser.Text & "', '" & FrmMain.LBLComputerName.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub UpdateMeterMasterIssuanceStatus()
        'Update Quantity
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        For i = 0 To dgwz.Rows.Count - 1
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE tbl_meterrvcd_details SET IssuanceStatus = '" & cboStatus.Text & "' WHERE MeterRcptNo = '" & dgwz.Rows(i).Cells(0).Value & "' and MeterNo = '" & dgwz.Rows(i).Cells(4).Value & "' and MeterrvcdCustDetailNo = '" & dgwz.Rows(i).Cells(5).Value & "'"
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
    Private Sub UpdateMeterMasterInfo()
        'Update Quantity
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        For i = 0 To dgwz.Rows.Count - 1
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE tbl_meterrvcd_info SET IssuanceStatus = '" & cboStatus.Text & "' WHERE MeterReceiptNo = '" & dgwz.Rows(i).Cells(0).Value & "'"
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
    Private Sub Resetform()
        txtSchemeID.Text = ""
        txtwarehouseID.Text = ""
        txtVehicleID.Text = ""
        txtSubcontractorID.Text = ""
        txtQtyIssued.Text = ""
        txtSchemeRefNo.Text = ""
        txtTXNo.Text = ""
        txtConstituencyname.Text = ""
        txtCounty.Text = ""
        txtSchemeName.Text = ""
        dgwz.Rows.Clear()
        LoadMeterReceipts()
        PopulateVehicleID()
        LoadSubcontractors()
    End Sub

    Private Sub CSaveIssueMetersToolStripButton5_Click(sender As Object, e As EventArgs) Handles CSaveIssueMetersToolStripButton5.Click
        If txtSchemeID.Text = "" Then
            MessageBox.Show("Please select Scheme Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtwarehouseID.Text = "" Then
            MessageBox.Show("Please select Warehouse", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtSubcontractorID.Text = "" Then
            MessageBox.Show("Please select Sub-Contractor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtVehicleID.Text = "" Then
            MessageBox.Show("Please select Vehicle", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtQtyIssued.Text = "" Then
            MessageBox.Show("Please select BatchNo to List Meters to be issued to continue", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        InsertMeterIssuanceDetails()
        InsertMeterIssuanceItems()
        UpdateMeterMasterIssuanceStatus()
        UpdateMeterMasterInfo()
        MsgBox("Meters successfully Issued.", MsgBoxStyle.Information, "Metering")
        Resetform()
        'Me.Close()
    End Sub
End Class

