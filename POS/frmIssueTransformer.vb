Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmIssueTransformer

    Private Sub LoadTransformers()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                    product.ProductNo,
                    product.Description,
                    tbl_receivetransformer.RcvtransformerId,
                    tbl_receivetransformer.ItemNo,
                    tbl_receivetransformer.Transformerissued,
                    tbl_receivetransformer.GNO
                    FROM
                    tbl_receivetransformer
                    INNER JOIN product ON tbl_receivetransformer.ItemNo = product.ProductNo Where Transformerissued = '0'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                cmdSearchItems.Items.Add(dr("GNO"))
                cmdSearchItems.Text = "GNO"

            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PopulateTransformerdetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                    product.ProductNo,
                    product.Description,
                    tbl_receivetransformer.RcvtransformerId,
                    tbl_receivetransformer.ItemNo,
                    tbl_receivetransformer.SNO,
                    tbl_receivetransformer.STFNO,
                    tbl_receivetransformer.GNO,
                    tbl_receivetransformer.SuppID,
                    tbl_receivetransformer.DeliveryNo,
                    tbl_receivetransformer.Qty,
                    tbl_receivetransformer.DateIn,
                     tbl_receivetransformer.DateIn,
                    tbl_receivetransformer.ReceivedBy
                    FROM
                    tbl_receivetransformer
                    INNER JOIN product ON tbl_receivetransformer.ItemNo = product.ProductNo where tbl_receivetransformer.GNO = '" & cmdSearchItems.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtItemCode.Text = dr("ItemNo")
                txtGNo.Text = dr("GNO")
                txtSNo.Text = dr("SNO")
                txtName.Text = dr("Description")
                txtRecvtransformer.Text = dr("RcvtransformerId")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub AddIssueTransformertoscheme()
        If txtItemCode.Text = "" Or txtGNo.Text = "" Or txtSchemeID.Text = "" Or txtSubcontractor.Text = "" Or txtVehicleID.Text = "" Then
            MessageBox.Show("Please fill all fields to continue", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_issuetransformer (Delivery_No,RcvtransformerId,ItemNo,SchemeID,vehicleId,subcontractorId,Qty,DateIssued,IssuedBy) VALUES ((Select MAX(DeliveryNo) from delivery_details),'" & txtRecvtransformer.Text & "', '" & txtItemCode.Text & "','" & txtSchemeID.Text & "','" & txtVehicleID.Text & "', '" & txtSubcontractor.Text & "', '" & txtQtytoIssue.Text & "', '" & lbldateRS.Text & "','" & FrmMain.tsslUser.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        MsgBox("Transformer details successfully added")
    End Sub

    Private Sub btnLoadSchemes_Click(sender As Object, e As EventArgs) Handles btnLoadSchemes.Click
        frmLoadSchemedetails.ShowDialog()
    End Sub

    Private Sub btnLoadSubcontractor_Click(sender As Object, e As EventArgs) Handles btnLoadSubcontractor.Click
        frmLoadSubcontractors.ShowDialog()
    End Sub

    Private Sub btnLoadVehicle_Click(sender As Object, e As EventArgs) Handles btnLoadVehicle.Click
        frmLoadVehicles.ShowDialog()
    End Sub
    Private Sub LoadTransformers1()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                tbl_receivetransformer.RcvtransformerId,
                tbl_issuetransformer.RcvtransformerId,
                tbl_issuetransformer.IssuetransformerId,
                tbl_receivetransformer.Transformerissued,
                tbl_issuetransformer.Delivery_No,
                tbl_receivetransformer.GNO,
                tbl_receivetransformer.SNO,
                tbl_issuetransformer.ItemNo
                FROM
                tbl_receivetransformer
                INNER JOIN tbl_issuetransformer ON tbl_issuetransformer.RcvtransformerId = tbl_receivetransformer.RcvtransformerId where tbl_receivetransformer.Transformerissued = 1"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                cbosearchIssuanceGNo.Items.Add(dr("Delivery_No"))
                cbosearchIssuanceGNo.Text = "Delivery No"

            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmIssueTransformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransformers()
        LoadTransformers1()
        txtQtytoIssue.Text = "1"
        txtQtytoIssue1.Text = "1"
        txttransformerIssueno.Text = "1"
        txtNil.Text = "0"
    End Sub

    Private Sub cmdSearchItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdSearchItems.SelectedIndexChanged
        PopulateTransformerdetails()
    End Sub

    Private Sub PSaveToolStripButton_Click(sender As Object, e As EventArgs) Handles PSaveToolStripButton.Click
        chkTransformerissued.Checked = True
        chkIssuetoSubContractor.Checked = True
        SaveDeliveryDetails1()
        InsertDeliveryItems()
        InsertDeliveryItems1()
        AddIssueTransformertoscheme()
        UpdateTransformerIssuancestatus()
        UpdateTransformerInventory()
        Resetform()
    End Sub
    Private Sub Resetform()
        txtItemCode.Text = ""
        txtGNo.Text = ""
        txtSNo.Text = ""
        txtName.Text = ""
        txtRecvtransformer.Text = ""
        txtConstituencyname.Text = ""
        txtCounty.Text = ""
        txtSchemeID.Text = ""
        txtSchemeName.Text = ""
        txtSchemeRefNo.Text = ""
        txtTXNo.Text = ""
        txtVehicleID.Text = ""
        txtSubcontractor.Text = ""
        txtqtybal.Text = ""
        txtName.Text = ""
        cboVehicleNo.Text = ""
        cboSubcontractor.Text = ""
        txtSchemeName.Text = ""
        txtCountyID.Text = ""
        txtConstituencyID.Text = ""
    End Sub

    Private Sub UpdateTransformerIssuancestatus()
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        Try
            MysqlConny.Open()
            Dim Querys As String
            Querys = "UPDATE tbl_receivetransformer SET Transformerissued =  '" & chkTransformerissued.CheckState & "' WHERE RcvtransformerId = '" & txtRecvtransformer.Text & "'"
            cmd = New MySqlCommand(Querys, MysqlConny)
            dr = cmd.ExecuteReader
            MysqlConny.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConny.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtItemCode.Text, TimeOfDay, "Updated Transformer Issuance status")

    End Sub
    Private Sub UpdateTransformerInventory()
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        Try
            MysqlConny.Open()
            Dim Querys As String
            Querys = "UPDATE product SET StocksOnHand = StocksOnHand - '" & txtQtytoIssue.Text & "' WHERE ProductNo = '" & txtItemCode.Text & "'"
            cmd = New MySqlCommand(Querys, MysqlConny)
            dr = cmd.ExecuteReader
            MysqlConny.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConny.Dispose()
        End Try

        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtGNo.Text, TimeOfDay, "Updated Transformer Inventory")

    End Sub
    Private Sub SaveDeliveryDetails1()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            ''" & LblDeliveryNo.Text & "', DeliveryNo,
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO delivery_details(IssueDate, ItemCount, SchemeId, CountyId, ConstituencyId, UserName, TillNo, TimeX, Status, Approvedby, CancelStatus, CancelledBy, VehicleID, IssuetoSub, ContractorId) VALUES ('" & lbldateRS.Text & "', '" & txtQtytoIssue.Text & "', '" & txtSchemeID.Text & "', '" & txtCountyID.Text & "', '" & txtConstituencyID.Text & "', '" & FrmMain.tsslUser.Text & "', '" & FrmMain.LBLComputerName.Text & "', '" & TimeOfDay & "', '" & chkApproved.CheckState & "','" & txtApprovedby.Text & "', '" & ChkCancelled.CheckState & "', '" & txtCacelledby.Text & "','" & txtVehicleID.Text & "', '" & chkIssuetoSubContractor.CheckState & "', '" & txtSubcontractor.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtGNo.Text, TimeOfDay, "Added New Delivery")
    End Sub

    Private Sub InsertDeliveryItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'delivery_details
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Insert into delivery_items (Delivery_No, Item_No, Qty_Issued, Qty_Rem, Date_Issued, Issue_Time, DocumentNo, SchemeRefNo, DeliveryNo, StockInID) VALUES ((Select MAX(DeliveryNo) from delivery_details), '" & txtItemCode.Text & "', '" & txtQtytoIssue.Text & "', '" & txtqtybal.Text & "', '" & lbldateRS.Text & "', '" & TimeOfDay & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub InsertDeliveryItems1()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'delivery_details
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Insert into delivery_items_2 (Delivery_No, Item_No, Qty_Issued, Qty_Rem, Date_Issued, Issue_Time, DocumentNo, SchemeRefNo, DeliveryNo, StockInID) VALUES ((Select MAX(DeliveryNo) from delivery_details), '" & txtItemCode.Text & "', '" & txtQtytoIssue.Text & "', '" & txtqtybal.Text & "', '" & lbldateRS.Text & "', '" & TimeOfDay & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub cboVehicleNo_TextChanged(sender As Object, e As EventArgs) Handles cboVehicleNo.TextChanged


    End Sub

    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT  ProductNo, StocksOnHand from Product where ProductNo = '" & txtItemCode.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtstkonhand.Text = dr("StocksOnHand")
            End If

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        txtqtybal.Text = Val(txtstkonhand.Text) - Val(txtQtytoIssue.Text)
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Me.Close()
    End Sub
    Private Sub loadIssuancedetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
product.ProductNo,
product.Description,
tbl_issuetransformer.IssuetransformerId,
tbl_issuetransformer.RcvtransformerId,
tbl_issuetransformer.ItemNo,
tbl_issuetransformer.SchemeID,
tbl_issuetransformer.vehicleId,
tbl_issuetransformer.subcontractorId,
tbl_issuetransformer.Qty,
tbl_issuetransformer.DateIssued,
tbl_issuetransformer.IssuedBy,
tbl_issuetransformer.Delivery_No,
tbl_receivetransformer.RcvtransformerId,
tbl_receivetransformer.SNO,
tbl_receivetransformer.STFNO,
tbl_receivetransformer.GNO,
tbl_receivetransformer.SuppID,
tbl_receivetransformer.ItemNo,
tbl_receivetransformer.DeliveryNo,
tbl_receivetransformer.Qty,
tbl_receivetransformer.DateIn,
tbl_receivetransformer.ReceivedBy,
tbl_receivetransformer.Transformerissued,
schemes.SchemeNo,
schemes.Scheme_Name,
tbl_vehicles.vehiclesid,
tbl_vehicles.vehicle_no,
tbl_subcontractors.subcontractors_ID,
tbl_subcontractors.subcontractor_Name,
schemes.Scheme_Ref_No,
schemes.County_Id,
schemes.Constituency_Id,
county.County_No,
county.County_Name,
constituency.Constituency_No,
constituency.constituency_Name,
schemes.Substation_No
FROM
tbl_receivetransformer
INNER JOIN tbl_issuetransformer ON tbl_receivetransformer.RcvtransformerId = tbl_issuetransformer.RcvtransformerId
INNER JOIN product ON tbl_receivetransformer.ItemNo = product.ProductNo AND tbl_issuetransformer.ItemNo = product.ProductNo
INNER JOIN tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = tbl_issuetransformer.subcontractorId
INNER JOIN tbl_vehicles ON tbl_vehicles.vehiclesid = tbl_issuetransformer.vehicleId
INNER JOIN schemes ON schemes.SchemeNo = tbl_issuetransformer.SchemeID
INNER JOIN constituency ON schemes.Constituency_Id = constituency.Constituency_No
INNER JOIN county ON schemes.County_Id = county.County_No where tbl_issuetransformer.Delivery_No = '" & cbosearchIssuanceGNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtItemCode1.Text = dr("ItemNo")
                txtGNo1.Text = dr("GNO")
                txtSNo1.Text = dr("SNO")
                txtName1.Text = dr("Description")
                txtRecvtransformer1.Text = dr("RcvtransformerId")
                txtConstituencyname1.Text = dr("constituency_Name")
                txtCounty1.Text = dr("County_Name")
                txtSchemeID1.Text = dr("SchemeID")
                txtSchemeName1.Text = dr("Scheme_Name")
                txtSchemeRefNo1.Text = dr("Scheme_Ref_No")
                txtTXNo1.Text = dr("Substation_No")
                txtVehicleID1.Text = dr("vehicleId")
                txtSubcontractor1.Text = dr("subcontractors_ID")
                cboVehicleNo1.Text = dr("vehicle_no")
                cboSubcontractor1.Text = dr("subcontractor_Name")
                txtSchemeName1.Text = dr("Scheme_Name")
                txtCountyID1.Text = dr("County_Id")
                txtConstituencyID1.Text = dr("Constituency_Id")
                txttransformerIssueno.Text = dr("IssuetransformerId")
                txtDNo.Text = dr("Delivery_No")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub cbosearchIssuanceNo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosearchIssuanceGNo.SelectedIndexChanged
        loadIssuancedetails()
    End Sub

    Private Sub btnldschms_Click(sender As Object, e As EventArgs) Handles btnldschms.Click
        frmLoadSchemedetails.ShowDialog()
    End Sub

    Private Sub btnldcontractor_Click(sender As Object, e As EventArgs) Handles btnldcontractor.Click
        frmLoadSubcontractors.ShowDialog()
    End Sub

    Private Sub btnldvehicle_Click(sender As Object, e As EventArgs) Handles btnldvehicle.Click
        frmLoadVehicles.ShowDialog()
    End Sub
    Private Sub UpdateTransformerIssuance()
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        Try
            MysqlConny.Open()
            Dim Querys As String
            Querys = "UPDATE tbl_issuetransformer SET SchemeID = '" & txtSchemeID1.Text & "', vehicleId = '" & txtVehicleID1.Text & "', subcontractorId = '" & txtSubcontractor1.Text & "' WHERE IssuetransformerId = '" & txttransformerIssueno.Text & "'"
            cmd = New MySqlCommand(Querys, MysqlConny)
            dr = cmd.ExecuteReader
            MysqlConny.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConny.Dispose()
        End Try

    End Sub

    Private Sub UpdateDeliverydetails()
        'INSERT INTO delivery_details(IssueDate, ItemCount, SchemeId, CountyId, ConstituencyId, UserName, TillNo, TimeX, Status, Approvedby, CancelStatus, CancelledBy, VehicleID, IssuetoSub, ContractorId)
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        Try
            MysqlConny.Open()
            Dim Querys As String
            Querys = "UPDATE delivery_details SET SchemeId = '" & txtSchemeID1.Text & "', VehicleID = '" & txtVehicleID1.Text & "', ContractorId = '" & txtSubcontractor1.Text & "' WHERE DeliveryNo = '" & txtDNo.Text & "'"
            cmd = New MySqlCommand(Querys, MysqlConny)
            dr = cmd.ExecuteReader
            MysqlConny.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConny.Dispose()
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MessageBox.Show("Are you Sure You want to update delivery?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            UpdateTransformerIssuance()
            UpdateDeliverydetails()
        End If
        MsgBox("Transformer issuance successfully updated")
    End Sub
    Private Sub UpdateTransformerIssuanceState()
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        Try
            MysqlConny.Open()
            Dim Querys As String
            Querys = "UPDATE tbl_receivetransformer SET Transformerissued =  '" & chkTranformerIssued.CheckState & "' WHERE RcvtransformerId = '" & txtRecvtransformer.Text & "'and GNO = '" & txtGNo1.Text & "'"
            cmd = New MySqlCommand(Querys, MysqlConny)
            dr = cmd.ExecuteReader
            MysqlConny.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConny.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtItemCode.Text, TimeOfDay, "Updated Transformer Issuance status")
    End Sub
    Private Sub UpdateDeliveryItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'delivery_details
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update delivery_items set Qty_Issued = 0 where Item_No = '" & txtItemCode1.Text & "' and Delivery_No = '" & txtDNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub UpdateTransformerIssuanceinReceive()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'delivery_details
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update tbl_receivetransformer set Transformerissued = 0 where GNO = '" & txtGNo1.Text & "' and RcvtransformerId = '" & txtRecvtransformer1.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub UpdateInventoryafterCancel()
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        Try
            MysqlConny.Open()
            Dim Querys As String
            Querys = "UPDATE product SET StocksOnHand = StocksOnHand + 1 WHERE ProductNo = '" & txtItemCode1.Text & "'"
            cmd = New MySqlCommand(Querys, MysqlConny)
            dr = cmd.ExecuteReader
            MysqlConny.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConny.Dispose()
        End Try

        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtGNo.Text, TimeOfDay, "Updated Transformer Inventory")

    End Sub

    Private Sub CancelToolStripLabel5_Click(sender As Object, e As EventArgs) Handles CancelToolStripLabel5.Click
        If MessageBox.Show("Are You Sure You want to cancel delivery?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            chkTranformerIssued.Checked = False
            UpdateTransformerIssuanceState()
            UpdateTransformerIssuanceinReceive()
            UpdateDeliveryItems()
            UpdateInventoryafterCancel()
            MsgBox("Transformer issuance successfully cancelled")
        End If
    End Sub
End Class