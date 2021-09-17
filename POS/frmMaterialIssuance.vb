Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Configuration

Public Class frmMaterialIssuance
    Public Sub GetDeliveryNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT DeliveryNo FROM delivery_details ORDER BY DeliveryNo DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                LblDeliveryNo.Text = dr("DeliveryNo") + 1
            Else
                LblDeliveryNo.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub PopulateItemCodeTextboxes()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT  ProductNo, Description, StocksOnHand, ReorderLevel, CateID, SubCateID, PrefSupplier, UnitofIssue from Product where Description = '" & cmdSearchItems.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtItemCode.Text = dr("ProductNo")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub PopulateTextboxbasedonItemNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT  ProductNo, Description, StocksOnHand, ReorderLevel, CateID, SubCateID, PrefSupplier, UnitofIssue from Product where ProductNo = '" & txtItemCode.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtQtyonHand.Text = dr("StocksOnHand")
                txtUnitofIssue.Text = dr("UnitofIssue")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadSchemeCountyID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select SchemeNo, Scheme_Ref_No, Scheme_Name, County_Id, Constituency_Id from schemes where Scheme_Ref_No = '" & txtSchemeRefNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtSchemeID.Text = dr("SchemeNo")
                txtCountyID.Text = dr("County_Id")
                txtConstituencyID.Text = dr("Constituency_Id")
                txtSchemeName.Text = dr("Scheme_Name")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ProductNo, Description from product ORDER BY Description"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cmdSearchItems.Items.Clear()
            Do While dr.Read = True
                cmdSearchItems.Items.Add(dr("Description"))
                cmdSearchItems.Text = "Description"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub cmdSearchItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdSearchItems.SelectedIndexChanged
        PopulateItemCodeTextboxes()
        PopulateTextboxbasedonItemNo()
    End Sub
    Private Sub frmMaterialIssuance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItems()
        PopulateVehicles()
        txtNil.Text = 0
        chkIssuetoSubContractor.Checked = False
        cboSubcontractor.Enabled = False
        'lblsubcontractor.Enabled = False
        txtSubcontractor.Enabled = False
        LoadSubcontractors()
    End Sub


    Private Sub SaveDeliveryItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If dgwIssueItems.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please enter Items To Issue", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        For Each r As DataGridViewRow In dgwIssueItems.Rows
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Insert into delivery_items (Delivery_No, Item_No, Qty_Issued, Qty_Rem, Date_Issued, Issue_Time) " &
                             " VALUES ('" & LblDeliveryNo.Text & "', '" & r.Cells(0).Value &
                             "','" & r.Cells(2).Value & "', '" & CDec(r.Cells(3).Value) & "', '" & lbldate.Text & "')"

                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader

                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
            ''Update Audit Trail Table
            Audit_Trail(FrmMain.tsslUser.Text, r.Cells(0).FormattedValue, TimeOfDay, "Issued Materials")
        Next

    End Sub
    Private Sub SaveDeliveryDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO delivery_details (DeliveryNo, IssueDate, ItemCount, SchemeId, CountyId, ConstituencyId, UserName, TillNo, SessIDNo, TimeX, Status, Approvedby) VALUES ('" & LblDeliveryNo.Text & "', '" & lbldate.Text & "', '" & txtItemcount.Text & "', '" & txtSchemeID.Text & "', '" & txtCountyID.Text & "', '" & txtConstituencyID.Text & "', '" & FrmMain.tsslUser.Text & "', '" & FrmMain.LBLComputerName.Text & "', '" & TimeOfDay & "', '" & chkApproved.CheckState & "', '" & txtApprovedby.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("New Delivery successfully added.", MsgBoxStyle.Information, "Add Delivery")

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, LblDeliveryNo.Text, TimeOfDay, "Added new Delivery")
    End Sub
    Private Sub ClearAllTextboxes()
        txtSchemeID.Text = ""
        txtCountyID.Text = ""
        txtConstituencyID.Text = ""
        txtSchemeName.Text = ""
        LblDeliveryNo.Text = ""
        txtItemcount.Text = ""
        dgwIssueItems.Rows.Clear()
        txtConstituencyname.Text = ""
        txtCounty.Text = ""
        txtTXNo.Text = ""
    End Sub
    Private Sub ClearTextboxes()
        txtItemCode.Text = ""
        txtQtytoIssue.Text = ""
        txtRemQty.Text = ""
        txtUnitofIssue.Text = ""
        txtQtyonHand.Text = ""
    End Sub
    Private Sub getqty()
        Dim qty As Decimal
        For r = 0 To dgwIssueItems.Rows.Count - 1
            qty += dgwIssueItems.Rows(r).Cells(2).Value
            txtItemcount.Text = qty
        Next
    End Sub
    Private Sub CalculateTotQty()
        txtRemQty.Text = Val(txtQtyonHand.Text) - Val(txtQtytoIssue.Text)
    End Sub
    Private Sub AddItemstoGrid()
        If txtQtytoIssue.Text = "" Then
            MessageBox.Show("Please enter Quantity to Issue", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQtytoIssue.Focus()
            Return
        End If

        If txtItemCode.Text = "" Then
            MessageBox.Show("Please enter Material to Issue", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmdSearchItems.Focus()
            Return
        End If

        If txtSchemeName.Text = "" Then
            MessageBox.Show("Please enter Scheme Refrence No", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSchemeRefNo.Focus()
            Return
        End If

        If txtVehicleID.Text = "" Then
            MessageBox.Show("Please enter Vehicle No", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtVehicleID.Focus()
            Return
        End If
        Dim rnum As Integer = dgwIssueItems.Rows.Add()
        dgwIssueItems.Rows.Item(rnum).Cells(0).Value = txtItemCode.Text
        dgwIssueItems.Rows.Item(rnum).Cells(1).Value = cmdSearchItems.Text
        dgwIssueItems.Rows.Item(rnum).Cells(2).Value = txtQtytoIssue.Text
        dgwIssueItems.Rows.Item(rnum).Cells(3).Value = txtRemQty.Text
        dgwIssueItems.Rows.Item(rnum).Cells(4).Value = txtUnitofIssue.Text
        txtCurrentItemNo.Text = txtItemCode.Text
        txtSchemeRefNo.Enabled = False
        txtSchemeName.Enabled = False
        cboVehicleNo.Enabled = False
    End Sub
    Public Sub dropDuplicateRows()
        For intI As Integer = dgwIssueItems.Rows.Count - 1 To 0 Step -1
            For intJ As Integer = dgwIssueItems.Rows.Count - 1 To intI + 1 Step -1
                If dgwIssueItems.Rows(intI).Cells(0).Value = dgwIssueItems.Rows(intJ).Cells(0).Value Then
                    dgwIssueItems.Rows.RemoveAt(intJ)
                    MsgBox("Please Double Click the Existing Item and Enter the Right Quantity", MsgBoxStyle.Exclamation, "Material Delivery!")
                    Exit Sub
                    'dgwIssueItems.Rows(intI).Cells(2).Value = Val(dgwIssueItems.Rows(intI).Cells(2).Value) + Val(txtQtytoIssue.Text)
                End If
            Next intJ
        Next intI
    End Sub
    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
    Private Sub btnAddtoGrid_Click(sender As Object, e As EventArgs) Handles btnAddtoGrid.Click
        AddItemstoGrid()
        dropDuplicateRows()
        getqty()
        ClearTextboxes()
        LoadItems()
    End Sub

    Private Sub txtQtytoIssue_TextChanged(sender As Object, e As EventArgs) Handles txtQtytoIssue.TextChanged
        If Val(txtQtytoIssue.Text) > Val(txtQtyonHand.Text) Then
            MsgBox("Quantity to Issue cannot be greater than available stock!", MsgBoxStyle.Exclamation, "Issue Materials!")
            txtQtytoIssue.Clear()
            Exit Sub
        End If
        CalculateTotQty()
    End Sub

    Private Sub VoidToolStripButton4_Click(sender As Object, e As EventArgs) 
        Dim tot As Decimal
        If dgwIssueItems.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please enter Item ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try

            If MessageBox.Show("Are You Sure You want to Void the item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                dgwIssueItems.Rows.Remove(dgwIssueItems.CurrentRow)
            End If
        Catch ex As Exception
            MessageBox.Show("Please Select Item to Void", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally

        End Try
        For i = 0 To dgwIssueItems.Rows.Count - 1
            tot += dgwIssueItems.Rows(i).Cells(2).Value
        Next
        txtItemcount.Text = tot
    End Sub

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

    Private Sub cboVehicleNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVehicleNo.SelectedIndexChanged
        PopulateVehicleID()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Me.Close()
    End Sub

    Private Sub ClearToolStripButton_Click(sender As Object, e As EventArgs) Handles ClearToolStripButton.Click
        If MessageBox.Show("Are You Sure You Want to Reset the Form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            dgwIssueItems.Rows.Clear()
            Reset()
        End If

    End Sub


    Private Sub MyTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtytoIssue.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub InsertDeliveryItems()
        For Each r As DataGridViewRow In dgwIssueItems.Rows
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            'delivery_details
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Insert into delivery_items (Delivery_No, Item_No, Qty_Issued, Qty_Rem, Date_Issued, Issue_Time, DocumentNo, SchemeRefNo, DeliveryNo, StockInID) VALUES ((Select MAX(DeliveryNo) from delivery_details), '" & (r.Cells(0).Value) & "', '" & r.Cells(2).Value & "', '" & r.Cells(3).Value & "', '" & lbldate.Text & "', '" & TimeOfDay & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "')"
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
    Private Sub InsertDeliveryItems1()
        For Each r As DataGridViewRow In dgwIssueItems.Rows
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Insert into delivery_items_2 (Delivery_No, Item_No, Qty_Issued, Qty_Rem, Date_Issued, Issue_Time, DocumentNo, SchemeRefNo, DeliveryNo, StockInID) VALUES ((Select MAX(DeliveryNo) from delivery_details), '" & (r.Cells(0).Value) & "', '" & r.Cells(2).Value & "', '" & r.Cells(3).Value & "', '" & lbldate.Text & "', '" & TimeOfDay & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "')"
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
    Private Sub UpdateQuantity()
        'Update Quantity
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        For i = 0 To dgwIssueItems.Rows.Count - 1
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE product SET StocksOnHand = StocksOnHand - '" & dgwIssueItems.Rows(i).Cells(2).Value & "' WHERE ProductNo = '" & dgwIssueItems.Rows(i).Cells(0).Value & "'"
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
    Private Sub UpdateQuantityinStockInMaterials()
        'Update Quantity
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        For i = 0 To dgwIssueItems.Rows.Count - 1
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE stockinmaterials SET Quantity = Quantity - '" & dgwIssueItems.Rows(i).Cells(2).Value & "' WHERE PNO = '" & dgwIssueItems.Rows(i).Cells(0).Value & "'"
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
    Private Sub DeleteEmptyDeliveryNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from delivery_details where ItemCount = 0 and SchemeId = 0 and CountyId = 0;"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub DeleteEmptyDocNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from delivery_items where Qty_Issued = '' and Item_No = '' and Qty_Rem = 0;"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
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
            Query = "INSERT INTO delivery_details(IssueDate, ItemCount, SchemeId, CountyId, ConstituencyId, UserName, TillNo, TimeX, Status, Approvedby, CancelStatus, CancelledBy, VehicleID, IssuetoSub, ContractorId) VALUES ('" & lbldate.Text & "', '" & txtItemcount.Text & "', '" & txtSchemeID.Text & "', '" & txtCountyID.Text & "', '" & txtConstituencyID.Text & "', '" & FrmMain.tsslUser.Text & "', '" & FrmMain.LBLComputerName.Text & "', '" & TimeOfDay & "', '" & chkApproved.CheckState & "','" & txtApprovedby.Text & "', '" & ChkCancelled.CheckState & "', '" & txtCacelledby.Text & "','" & txtVehicleID.Text & "', '" & chkIssuetoSubContractor.CheckState & "', '" & txtSubcontractor.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, LblDeliveryNo.Text, TimeOfDay, "Added New Delivery")
    End Sub
    Private Sub Reset()
        dgwIssueItems.Rows.Clear()
        cmdSearchItems.Items.Clear()
        cboVehicleNo.Items.Clear()
        txtItemCode.Text = ""
        txtQtytoIssue.Text = ""
        txtRemQty.Text = ""
        txtUnitofIssue.Text = ""
        txtQtyonHand.Text = ""
        txtSchemeRefNo.Text = ""
        txtItemcount.Text = ""
        txtSchemeName.Text = ""
        txtConstituencyname.Text = ""
        txtCounty.Text = ""
        txtCurrentItemNo.Text = ""
        txtSchemeRefNo.Enabled = True
        cboVehicleNo.Enabled = True
        txtSchemeName.Enabled = True
        LoadItems()
        PopulateVehicles()
        LoadItems()
        PopulateVehicles()
        txtNil.Text = 0
        chkIssuetoSubContractor.Checked = False
        cboSubcontractor.Enabled = False
        'lblsubcontractor.Enabled = False
        txtSubcontractor.Enabled = False
        LoadSubcontractors()
        GetDeliveryNo()
        txtTXNo.Text = ""
    End Sub
    Private Sub PSaveToolStripButton_Click(sender As Object, e As EventArgs) Handles PSaveToolStripButton.Click
        If txtConstituencyID.Text = "" Or txtCountyID.Text = "" Or txtSchemeID.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Material Delivery!")
            Exit Sub
        End If
        If txtCurrentItemNo.Text = "" Then
            MsgBox("Add Materials to Issue!", MsgBoxStyle.Exclamation, "Material Delivery!")
            Exit Sub
        End If
        'GetDeliveryNo()
        SaveDeliveryDetails1()
        InsertDeliveryItems()
        InsertDeliveryItems1()
        UpdateQuantityinStockInMaterials()
        UpdateQuantity()
        DeleteEmptyDocNo()
        ClearAllTextboxes()
        txtSchemeRefNo.Enabled = True
        txtSchemeName.Enabled = True
        Reset()
        MsgBox("New Delivery successfully added.", MsgBoxStyle.Information, "Add Delivery")
    End Sub

    Private Sub dgwIssueItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwIssueItems.CellDoubleClick
        Dim i As Integer
        i = dgwIssueItems.CurrentRow.Index
        Me.txtItemCode.Text = dgwIssueItems.Item(0, i).Value
        Me.cmdSearchItems.Text = dgwIssueItems.Item(1, i).Value
        Me.txtQtytoIssue.Text = dgwIssueItems.Item(2, i).Value
        Me.txtUnitofIssue.Text = dgwIssueItems.Item(4, i).Value
        dgwIssueItems.Rows.Remove(dgwIssueItems.CurrentRow)
    End Sub

    Private Sub CboSchemeName_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Loadcounty()
        'LoadConstituency()
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
                txtSubcontractor.Text = dr("subcontractors_ID")

            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub Checksubcontractor()
        If chkIssuetoSubContractor.Checked = True Then
            cboSubcontractor.Enabled = True
            'lblsubcontractor.Enabled = True
            txtSubcontractor.Enabled = True
        Else
            cboSubcontractor.Enabled = False
            'lblsubcontractor.Enabled = False
            txtSubcontractor.Enabled = False
        End If
    End Sub
    Private Sub cboSubcontractor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubcontractor.SelectedIndexChanged
        LoadSubcontractorID()
    End Sub

    Private Sub chkIssuetoSubContractor_CheckedChanged(sender As Object, e As EventArgs) Handles chkIssuetoSubContractor.CheckedChanged
        Checksubcontractor()
    End Sub

    Private Sub btnLoadMaterials_Click(sender As Object, e As EventArgs) Handles btnLoadSchemes.Click
        frmLoadMaterials.ShowDialog()
    End Sub
    Private Sub txtSchemeRefNo_TextChanged_1(sender As Object, e As EventArgs) Handles txtSchemeRefNo.ModifiedChanged
        'Loadcounty()
        'LoadConstituency()
    End Sub

    Private Sub BTNLastInsertID_Click(sender As Object, e As EventArgs)
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
                txtSubcontractor.Text = dr("subcontractors_ID")

            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class