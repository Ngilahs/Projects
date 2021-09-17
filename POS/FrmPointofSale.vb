Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Configuration
Public Class FrmPointofSale
    Dim y As Integer
    'a Bridge between a database and datatable for retrieving and saving data.
    Dim da As New MySqlDataAdapter
    'a specific table in the database
    Dim dt As New DataTable
    Public qty As Decimal = 1
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim StockonHand As Decimal
    Dim IssueQty As Decimal
    Dim sqll As String

    Public Sub GetSalesIDs()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT TransID FROM sales_sold ORDER BY TransID DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
            Else
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
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
    Public Sub InsertRecepitNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO delivery_details (DeliveryNo, IssueDate, ItemCount, SchemeId, CountyId, ConstituencyId, UserName, TillNo, SessIDNo, TimeX) VALUES ('" & LblDeliveryNo.Text & "', '" & LBLZeroValue.Text & "', '" & LBLZeroValue.Text & "', '" & LBLZeroValue.Text & "', '" & LBLZeroValue.Text & "', '" & LBLZeroValue.Text & "', '" & LBLZeroValue.Text & "', '" & LBLZeroValue.Text & "', '" & LBLZeroValue.Text & "', '" & LBLZeroValue.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub dtgCart_CellMouseDoubleClickn(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Left Then
            'dtgCart.CurrentRow.Cells(4).Selected = True
            Exit Sub
        End If
    End Sub
    'Move focus in the first cell in the POS Grid
    Private Sub dtgCart_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If flag_cell_edited1 Then
        '    dtgCart.CurrentCell = dtgCart.Rows(currentRow + 1).Cells(0)
        '    flag_cell_edited1 = False
        'End If
    End Sub
    'Populate Customers in POS
    Private Sub populatecustomer()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SchemeNo, Scheme_Ref_No, Scheme_Name, County_Id, Constituency_Id, No_of_Customers from schemes where Scheme_Ref_No = '" & txtSchemeRefNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub FrmPointofSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'lbldate.Text = Format(Now, "MM/dd/yyyy")
        dgwIssueItems.CurrentCell = dgwIssueItems.Rows(0).Cells(0)
        txtItemcount.Text = "0"
        txtApprovedby.Text = "None"
        Try
            Timer1.Start()
        Catch ex As Exception
        End Try
        populatecustomer()
        frmPOS.Close()
        Dim dt As New DataTable
        'LoadItems()
        'AutoSearchItems()
        'PopulateDocumentNofromStockinDetails()
        PopulateVehicles()
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
            cmd.Dispose()
            conn.Close()
        End Try
        For i = 0 To dgwIssueItems.Rows.Count - 1
            tot += dgwIssueItems.Rows(i).Cells(2).Value
        Next
        txtItemcount.Text = tot
    End Sub
    Private Sub dtgCart_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgwIssueItems.CellBeginEdit
        If dgwIssueItems.CurrentRow.Cells(2).Value IsNot Nothing And dgwIssueItems.CurrentRow.Cells(2).Value <> 1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub cboSearchItem_SelectedIndexChanged(sender As Object, e As EventArgs)
        FillItemstoIssue()
    End Sub
    Private Sub FillItemstoIssue()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If dgwIssueItems.CurrentRow.Cells(2).Value = Nothing Then
            qty = 1
        Else
            qty = dgwIssueItems.CurrentRow.Cells(2).Value
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select ProductNo, Description, StocksOnHand, ReorderLevel, CateID, SubCateID, PrefSupplier, UnitofIssue From  Product where ProductNo = '" & txtItemCode.Text & "' AND Description = '" & txtSchemeID.Text & "' OR Description = '" & cmdSearchItems.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                dgwIssueItems.Rows.Add(dr("ProductNo"), dr("Description"), qty, dr("StocksOnHand") - qty, dr("UnitofIssue"))
                y += 17
            Loop
            getqty()
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub getqty()
        Dim qty As Decimal
        For r = 0 To dgwIssueItems.Rows.Count - 1
            qty += dgwIssueItems.Rows(r).Cells(2).Value
            txtItemcount.Text = qty
        Next
    End Sub
    Private Sub PopulateItemCode()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select ProductNo, Description from product where Description ='" & txtSchemeID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            'cboSearchItem.Items.Clear()
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

    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeID.KeyDown
        PopulateItemCode()
        txtSchemeID.Text = ""
    End Sub
    Private Sub dgwIssueItems_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwIssueItems.CellEndEdit
        If e.ColumnIndex = 2 Then
        End If
        For r = 0 To dgwIssueItems.Rows.Count - 1
            If dgwIssueItems.Rows(r).Cells(2).Selected = True Then
                dgwIssueItems.CurrentRow.Cells(3).Value = dgwIssueItems.CurrentRow.Cells(3).Value - dgwIssueItems.CurrentRow.Cells(2).Value
                dgwIssueItems.Rows(r + 1).Cells(0).Selected = True
            Else
                txtSchemeID.Select()
            End If
        Next
        If dgwIssueItems.CurrentRow.Cells(2).Selected = True Then
            dgwIssueItems.CurrentRow.Cells(2).Selected = False
        End If
        dgwIssueItems.CurrentRow.Cells(3).Value = dgwIssueItems.CurrentRow.Cells(3).Value + 1
        getqty()
    End Sub
    Private Sub AutoSearchItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ProductNo, Description from product ORDER BY Description DESC LIMIT 200"
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
                txtUoM.Text = dr("StocksOnHand")
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
                CboSchemeName.Text = dr("Scheme_Name")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
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
        'Try
        MysqlConn.Open()
            Dim Query As String
        Query = "INSERT INTO delivery_details (DeliveryNo, IssueDate, ItemCount, SchemeId, CountyId, ConstituencyId, UserName, TillNo,TimeX, Status, Approvedby, CancelStatus, CancelledBy, VehicleID) VALUES ('" & LblDeliveryNo.Text & "', '" & lbldate.Text & "', '" & txtItemcount.Text & "', '" & txtSchemeID.Text & "', '" & txtCountyID.Text & "', '" & txtConstituencyID.Text & "', '" & FrmMain.tsslUser.Text & "', '" & FrmMain.LBLComputerName.Text & "', '" & TimeOfDay & "', '" & chkApproved.CheckState & "','" & txtApprovedby.Text & "', '" & ChkCancelled.CheckState & "', '" & txtCacelledby.Text & "','" & txtVehicleID.Text & "')"
        cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("New Delivery successfully added.", MsgBoxStyle.Information, "Add Delivery")

            MysqlConn.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MysqlConn.Dispose()
        'End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, LblDeliveryNo.Text, TimeOfDay, "Added new Delivery")
    End Sub
    Private Sub ClearAllTextboxes()
        txtSchemeID.Text = ""
        txtCountyID.Text = ""
        txtConstituencyID.Text = ""
        CboSchemeName.Text = ""
        LblDeliveryNo.Text = ""
        txtItemcount.Text = ""
        txtSchemeRefNo.Text = ""
        dgwIssueItems.Rows.Clear()
    End Sub
    Private Sub InsertintoTempDeliveryTable()
        For Each r As DataGridViewRow In dgwIssueItems.Rows
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Insert into tempdelivery_items (TempDelivery_No, TempItem_No, TempQty_Issued, TempQty_Rem, TempDate_Issued, TempIssue_Time) VALUES (" & LblDeliveryNo.Text & ", '" & (r.Cells(0).Value) & "', '" & r.Cells(2).Value & "', '" & r.Cells(3).Value & "', '" & lbldate.Text & "', '" & TimeOfDay & "')"
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


    Private Sub DeleteEmptyRowinDeliveryitems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from tempdelivery_items where TempItem_No = '';"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub InsertDeliveryItems()
        For Each r As DataGridViewRow In dgwIssueItems.Rows
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            'Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Insert into delivery_items (Delivery_No, Item_No, Qty_Issued, Qty_Rem, Date_Issued, Issue_Time, DocumentNo,SchemeRefNo, DeliveryNo, StockInID) VALUES (" & LblDeliveryNo.Text & ", '" & (r.Cells(0).Value) & "', '" & r.Cells(2).Value & "', '" & r.Cells(3).Value & "', '" & lbldate.Text & "', '" & TimeOfDay & "', '" & r.Cells(5).Value & "', '" & r.Cells(6).Value & "', '" & r.Cells(7).Value & "', '" & r.Cells(8).Value & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
            'Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
            'Finally
            MysqlConn.Dispose()
            'End Try
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
                Query = "UPDATE stockinmaterials SET Quantity = Quantity - '" & dgwIssueItems.Rows(i).Cells(2).Value & "' WHERE PNO = '" & dgwIssueItems.Rows(i).Cells(0).Value & "' AND DocumentNo = '" & dgwIssueItems.Rows(i).Cells(5).Value & "'"
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
    Private Sub CboSchemeName_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadSchemeCountyID()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ClearAllTextboxes()
    End Sub

    Private Sub FrmPointofSale_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        DeleteEmptyDeliveryNo()
    End Sub
    Private Sub CalculateTotQty()

        txtRemQty.Text = Val(txtInStock.Text) - Val(txtQtytoIssue.Text)

    End Sub
    Private Sub AddItemstoGrid()
        If Trim(CboSchemeName.Text) = "" Or txtSchemeID.Text = "" Or txtItemCode.Text = "" Or Trim(cboVehicleNo.Text) = "" Then
            MsgBox("Please Fill all TextBoxes")
        Else
            If Val(txtQtytoIssue.Text) > Val(txtInStock.Text) Then
                MsgBox("Quantity to Issue cannot be greater than available stock!", MsgBoxStyle.Exclamation, "Issue Materials!")
                txtQtytoIssue.Clear()
                Exit Sub
            End If
            Dim rnum As Integer = dgwIssueItems.Rows.Add()
            dgwIssueItems.Rows.Item(rnum).Cells(0).Value = txtItemCode.Text
            dgwIssueItems.Rows.Item(rnum).Cells(1).Value = cmdSearchItems.Text
            dgwIssueItems.Rows.Item(rnum).Cells(2).Value = txtQtytoIssue.Text
            dgwIssueItems.Rows.Item(rnum).Cells(3).Value = txtRemQty.Text
            dgwIssueItems.Rows.Item(rnum).Cells(4).Value = txtUoM.Text
            dgwIssueItems.Rows.Item(rnum).Cells(5).Value = cboDocumentNo.Text
            dgwIssueItems.Rows.Item(rnum).Cells(6).Value = txtSchmeID.Text
            dgwIssueItems.Rows.Item(rnum).Cells(7).Value = txtDeliveryNote.Text
            dgwIssueItems.Rows.Item(rnum).Cells(8).Value = txtStockinDetailID.Text
        End If
    End Sub
    Private Sub ClearTextboxes()
        txtItemCode.Text = ""
        txtQtytoIssue.Text = ""
        txtRemQty.Text = ""
        txtUnitofIssue.Text = ""
        txtUoM.Text = ""
    End Sub

    Private Sub btnAddtoGrid_Click(sender As Object, e As EventArgs) Handles btnAddtoGrid.Click
        AddItemstoGrid()
        PSaveToolStripButton.Enabled = True
        VoidToolStripButton4.Enabled = True
        ClearToolStripButton.Enabled = True

        dropDuplicateRows()
        getqty()
        txtSchemeRefNo.Enabled = False
        ClearTextboxes()
        ClearFromGroupBox()
        PopulateDocumentNoDetails()
        lbldate.Enabled = False
    End Sub
    Private Sub txtQtytoIssue_TextChanged(sender As Object, e As EventArgs) Handles txtQtytoIssue.TextChanged
        If Val(txtQtytoIssue.Text) > Val(txtInStock.Text) Then
            MsgBox("Quantity to Issue cannot be greater than available stock!", MsgBoxStyle.Exclamation, "Issue Materials!")
            txtQtytoIssue.Clear()
            Exit Sub
        End If
        If Val(txtQtytoIssue.Text) > Val(txtTotStock.Text) Then
            MsgBox("Quantity to Issue cannot be greater than available stock!", MsgBoxStyle.Exclamation, "Issue Materials!")
            txtQtytoIssue.Clear()
            Exit Sub
        End If
        If cboDocumentNo.Text = "" Or txtSchemeRefNoFrom.Text = "" Or txtStockinDetailID.Text = "" Or cmdSearchItems.Text = "" Or cmdSearchItems.Text = Nothing Then
            MsgBox("Select Document No & Materials to Issue to continue!", MsgBoxStyle.Exclamation, "Delivery!")
            Exit Sub
        End If
        CalculateTotQty()
    End Sub

    Private Sub txtSchemeRefNo_KeyUp(sender As Object, e As EventArgs) Handles txtSchemeRefNo.KeyUp
        LoadSchemeCountyID()
    End Sub
    Private Sub MyTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtytoIssue.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub dropDuplicateRows()
        For intI As Integer = dgwIssueItems.Rows.Count - 1 To 0 Step -1
            For intJ As Integer = dgwIssueItems.Rows.Count - 1 To intI + 1 Step -1
                If dgwIssueItems.Rows(intI).Cells(0).Value = dgwIssueItems.Rows(intJ).Cells(0).Value Then
                    If dgwIssueItems.Rows(intI).Cells(5).Value = dgwIssueItems.Rows(intJ).Cells(5).Value Then
                        'dgwIssueItems.Rows(intI).Cells(2).Value = Val(dgwIssueItems.Rows(intI).Cells(2).Value) + Val(txtQtytoIssue.Text)
                        dgwIssueItems.Rows.RemoveAt(intJ)
                        MsgBox("Please Void the existing Item and Enter the right Quantity", MsgBoxStyle.Exclamation, "Material Delivery!")
                        Exit Sub
                    End If
                End If
            Next intJ
        Next intI
    End Sub
    Private Sub PSaveToolStripButton_Click(sender As Object, e As EventArgs) Handles PSaveToolStripButton.Click
        If txtConstituencyID.Text = "" Or txtCountyID.Text = "" Or txtSchemeID.Text = "" Or dgwIssueItems.Rows(0).Cells(0).Value = Nothing Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Material Delivery!")
            Exit Sub
        End If
        GetDeliveryNo()
        InsertDeliveryItems()
        DeleteEmptyRowinDeliveryitems()
        UpdateQuantityinStockInMaterials()
        UpdateQuantity()
        SaveDeliveryDetails()
        DeleteEmptyDocNo()
        ClearAllTextboxes()
        txtSchemeRefNo.Enabled = True
        Me.Close()
    End Sub

    Private Sub BTNF5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles VoidToolStripButton4.Click
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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ClearToolStripButton.Click
        ClearAllTextboxes()
        ClearFromGroupBox()
        txtSchemeRefNo.Text = ""
        dgw.Rows.Clear()
        txtQtytoIssue.Text = ""
        txtDocNo.Text = ""
    End Sub

    Private Sub PopulateDocumentNofromStockinDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT DocumentNo, SuppID from stockindetails ORDER BY DocumentNo DESC LIMIT 100"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboDocumentNo.Items.Clear()
            Do While dr.Read = True
                cboDocumentNo.Items.Add(dr("DocumentNo"))
                cboDocumentNo.Text = "DocumentNo"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PopulateDocumentNoDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT DocumentNo, DeliveryNo, SchemeID, SuppID, StockInDetailID from stockindetails where DocumentNo = '" & cboDocumentNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtSchemeRefNoFrom.Text = dr("SchemeID")
                txtDeliveryNote.Text = dr("DeliveryNo")
                txtStockinDetailID.Text = dr("StockInDetailID")
                txtItemCode.Text = ""
                txtInStock.Text = ""
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub PullDocumentNoMaterials()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SM.DocumentNo, SM.PNO, P.ProductNo, P.Description from stockinmaterials SM INNER Join product P ON SM.PNO = P.ProductNo where DocumentNo = '" & cboDocumentNo.Text & "'"
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

    Private Sub PopulateVehicles()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT vehiclesid, vehicle_no, Type from tbl_vehicles ORDER BY vehicle_no DESC LIMIT 10"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboDocumentNo.Items.Clear()
            Do While dr.Read = True
                cboVehicleNo.Items.Add(dr("vehicle_no"))

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
    Private Sub PopulateMaterialDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SM.DocumentNo, SM.PNO, SM.Quantity, SM.StockInID, P.ProductNo, P.Description, P.UnitofIssue from stockinmaterials SM INNER Join product P ON SM.PNO = P.ProductNo where P.Description = '" & cmdSearchItems.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtItemCode.Text = dr("ProductNo")
                'txtInStock.Text = dr("Quantity")
                txtUoM.Text = dr("UnitofIssue")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub cboDocumentNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocumentNo.SelectedIndexChanged
        PullDocumentNoMaterials()
        PopulateDocumentNoDetails()
    End Sub
    Private Sub cmdSearchItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdSearchItems.SelectedIndexChanged
        PopulateMaterialDetails()
    End Sub

    Private Sub txtDocNo_TextChanged(sender As Object, e As EventArgs) Handles txtDocNo.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'Try
        MysqlConn.Open()
            Dim Query As String
        Query = "SELECT SM.DocumentNo, SM.PNO, SM.Quantity, SM.StockInID, SM.SchemeID, P.ProductNo, P.Description, S.Scheme_Ref_No, S.Scheme_Name, S.SchemeNo from stockinmaterials SM INNER JOIN product P ON SM.PNO = P.ProductNo INNER Join schemes S ON S.SchemeNo = SM.SchemeID where SM.DocumentNo LIKE '%" & txtDocNo.Text & "%'"
        cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
            dgw.Rows.Add(dr("DocumentNo"), dr("Description"), dr("Quantity"), dr("Scheme_Name"), dr("PNO"), dr("StockInID"), dr("SchemeID"))
            y += 17
            Loop
            MysqlConn.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        MysqlConn.Dispose()
        'End Try
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        dgw.Rows.Clear()
    End Sub
    Private Sub ClearFromGroupBox()
        cboDocumentNo.Text = ""
        txtSchemeRefNoFrom.Text = ""
        txtDeliveryNote.Text = ""
        txtStockinDetailID.Text = ""
        cmdSearchItems.Text = ""
        txtInStock.Text = ""
    End Sub

    Private Sub txtItemCode_TextChanged_1(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SM.DocumentNo, SM.PNO, SM.Quantity, SM.StockInID, P.ProductNo, P.Description, P.UnitofIssue from stockinmaterials SM INNER Join product P ON SM.PNO = P.ProductNo where PNO = '" & txtItemCode.Text & "'and DocumentNo = '" & cboDocumentNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtInStock.Text = dr("Quantity")
                txtUoM.Text = dr("UnitofIssue")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub PopulateItemNoStock()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT  ProductNo, Description, StocksOnHand,UnitofIssue from Product where ProductNo = '" & txtItemCode.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtTotStock.Text = dr("StocksOnHand")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub dgw_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellDoubleClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.cboDocumentNo.Text = dgw.Item(0, i).Value
        Me.cmdSearchItems.Text = dgw.Item(1, i).Value
        Me.txtInStock.Text = dgw.Item(2, i).Value
        Me.txtSchemeRefNoFrom.Text = dgw.Item(3, i).Value
        Me.txtItemCode.Text = dgw.Item(4, i).Value
        Me.txtStockinDetailID.Text = dgw.Item(5, i).Value
        Me.txtDeliveryNote.Text = dgw.Item(5, i).Value
        Me.txtSchmeID.Text = dgw.Item(6, i).Value
        PopulateItemNoStock()
        dgw.Rows.Clear()
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.cboDocumentNo.Text = dgw.Item(0, i).Value
        Me.cmdSearchItems.Text = dgw.Item(1, i).Value
        Me.txtInStock.Text = dgw.Item(2, i).Value
        Me.txtSchemeRefNoFrom.Text = dgw.Item(3, i).Value
        Me.txtItemCode.Text = dgw.Item(4, i).Value
        Me.txtStockinDetailID.Text = dgw.Item(5, i).Value
        Me.txtDeliveryNote.Text = dgw.Item(5, i).Value
        Me.txtSchmeID.Text = dgw.Item(6, i).Value
        PopulateItemNoStock()
        dgw.Rows.Clear()
    End Sub

    Private Sub txtSchemeRefNo_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeRefNo.TextChanged

    End Sub

    Private Sub txtMaterialName_TextChanged(sender As Object, e As EventArgs) Handles txtMaterialName.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'Try
        MysqlConn.Open()
        Dim Query As String
        Query = "SELECT SM.DocumentNo, SM.PNO, SM.Quantity, SM.StockInID, SM.SchemeID, P.ProductNo, P.Description, S.Scheme_Ref_No, S.Scheme_Name, S.SchemeNo from stockinmaterials SM INNER JOIN product P ON SM.PNO = P.ProductNo INNER Join schemes S ON S.SchemeNo = SM.SchemeID where P.Description LIKE '%" & txtMaterialName.Text & "%'"
        cmd = New MySqlCommand(Query, MysqlConn)
        dr = cmd.ExecuteReader
        dgw.Rows.Clear()
        y = 0
        Do While dr.Read = True
            dgw.Rows.Add(dr("DocumentNo"), dr("Description"), dr("Quantity"), dr("Scheme_Name"), dr("PNO"), dr("StockInID"), dr("SchemeID"))
            y += 17
        Loop
        MysqlConn.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        MysqlConn.Dispose()
        'End Try
    End Sub

    Private Sub cboVehicleNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVehicleNo.SelectedIndexChanged
        PopulateVehicleID()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Me.Close()
    End Sub
End Class

