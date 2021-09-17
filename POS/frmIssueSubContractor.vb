Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Configuration

Public Class frmIssueSubContractor
    Dim y As Integer
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
    Private Sub txtDocNo_TextChanged(sender As Object, e As EventArgs) Handles txtDocNo.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'Try
        MysqlConn.Open()
        Dim Query As String
        Query = "SELECT SM.DocumentNo, SM.PNO, SM.Quantity, SM.StockInID, SM.SchemeID, P.ProductNo, P.Description, P.UnitofIssue, S.Scheme_Ref_No, S.Scheme_Name, S.SchemeNo from stockinmaterials SM INNER JOIN product P ON SM.PNO = P.ProductNo INNER Join schemes S ON S.SchemeNo = SM.SchemeID where SM.DocumentNo LIKE '%" & txtDocNo.Text & "%'"
        cmd = New MySqlCommand(Query, MysqlConn)
        dr = cmd.ExecuteReader
        dgw.Rows.Clear()
        y = 0
        Do While dr.Read = True
            dgw.Rows.Add(dr("DocumentNo"), dr("Description"), dr("Quantity"), dr("Scheme_Name"), dr("PNO"), dr("StockInID"), dr("SchemeID"), dr("UnitofIssue"))
            y += 17
        Loop
        MysqlConn.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        MysqlConn.Dispose()
        'End Try
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
        Me.txtUoM.Text = dgw.Item(7, i).Value
        dgw.Rows.Clear()
        PopulateTextboxbasedonItemNo()
    End Sub
    Private Sub ClearFromGroupBox()
        cboDocumentNo.Text = ""
        txtSchemeRefNoFrom.Text = ""
        txtDeliveryNote.Text = ""
        txtStockinDetailID.Text = ""
        cmdSearchItems.Text = ""
        txtInStock.Text = ""
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        dgw.Rows.Clear()
    End Sub
    Private Sub CalculateTotQty()

        txtRemQty.Text = Val(txtInStock.Text) - Val(txtQtytoIssue.Text)

    End Sub

    Private Sub txtQtytoIssue_TextChanged(sender As Object, e As EventArgs) Handles txtQtytoIssue.TextChanged
        If Val(txtQtytoIssue.Text) > Val(txtInStock.Text) Then
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
    Private Sub AddItemstoGrid()
        If Trim(CboSchemeName.Text) = "" Or txtSchemeID.Text = "" Or txtItemCode.Text = "" Then
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
    Private Sub getqty()
        Dim qty As Decimal
        For r = 0 To dgwIssueItems.Rows.Count - 1
            qty += dgwIssueItems.Rows(r).Cells(2).Value
            txtItemcount.Text = qty
        Next
    End Sub
    Private Sub ClearTextboxes()
        txtItemCode.Text = ""
        txtQtytoIssue.Text = ""
        txtRemQty.Text = ""
        txtUnitofIssue.Text = ""
        txtUoM.Text = ""
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
        'PopulateDocumentNoDetails()
    End Sub

    Private Sub txtSchemeRefNo_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeRefNo.KeyUp
        LoadSchemeCountyID()
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

    Private Sub frmIssueSubContractor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldate.Text = Format(Now, "MM/dd/yyyy")
        txtItemcount.Text = "0"
        txtApprovedby.Text = "None"
        chkIssuetoSubContractor.Checked = False
        cboSubcontractor.Visible = False
        lblsubcontractor.Visible = False
        txtSubcontractor.Visible = False
        LoadSubcontractors()

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
            Query = "SELECT subcontractors_ID,subcontractor_Name from tbl_subcontractors"
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
            Query = "SELECT subcontractors_ID,subcontractor_Name from tbl_subcontractors where subcontractor_Name = '" & cboSubcontractor.Text & "'"
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

    Private Sub VoidToolStripButton4_Click(sender As Object, e As EventArgs) Handles VoidToolStripButton4.Click
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
    Private Sub SaveDeliveryDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'Try
        MysqlConn.Open()
        Dim Query As String
        Query = "INSERT INTO delivery_details (DeliveryNo, IssueDate, ItemCount, SchemeId, CountyId, ConstituencyId, UserName, TillNo,TimeX, Status, Approvedby, CancelStatus, CancelledBy) VALUES ('" & LblDeliveryNo.Text & "', '" & lbldate.Text & "', '" & txtItemcount.Text & "', '" & txtSchemeID.Text & "', '" & txtCountyID.Text & "', '" & txtConstituencyID.Text & "', '" & FrmMain.tsslUser.Text & "', '" & FrmMain.LBLComputerName.Text & "', '" & TimeOfDay & "', '" & chkApproved.CheckState & "','" & txtApprovedby.Text & "', '" & ChkCancelled.CheckState & "', '" & txtCacelledby.Text & "')"
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
    End Sub
    Private Sub Checksubcontractor()
        If chkIssuetoSubContractor.Checked = True Then
            cboSubcontractor.Visible = True
            cboSubcontractor.Enabled = True
            cboSubcontractor.Visible = True
            lblsubcontractor.Visible = True
            txtSubcontractor.Visible = True
        Else
            cboSubcontractor.Visible = False
            cboSubcontractor.Enabled = False
            cboSubcontractor.Visible = False
            lblsubcontractor.Visible = False
            txtSubcontractor.Visible = False
        End If
    End Sub

    Private Sub chkIssuetoSubContractor_CheckedChanged(sender As Object, e As EventArgs) Handles chkIssuetoSubContractor.CheckedChanged
        Checksubcontractor()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub cboSubcontractor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubcontractor.SelectedIndexChanged
        LoadSubcontractorID()
    End Sub
End Class