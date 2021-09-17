Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmUpdateMaterialDel
    Dim y As Integer
    Private Sub LoadRecallIssuancedetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT DD.DeliveryNo, DD.IssueDate, DD.ItemCount, DD.SchemeId, DD.CountyId, DD.ConstituencyId, DD.UserName, DD.TillNo, DD.SessIDNo, DD.TimeX, S.Scheme_Name, C.County_Name, CN.constituency_Name FROM delivery_details DD inner join schemes S on (DD.SchemeId = S.SchemeNo) inner join county C on (DD.CountyId = C.County_No) inner join constituency CN on (CN.Constituency_No = DD.ConstituencyId) where DD.DeliveryNo = '" & frmDeliveryApproval.ListView1.FocusedItem.SubItems(0).Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                LblDeliveryNo.Text = dr("DeliveryNo")
                txtIssuancedate.Text = dr("IssueDate")
                txtSchemeName.Text = dr("Scheme_Name")
                txtCountyName.Text = dr("County_Name")
                txtConstituencyName.Text = dr("constituency_Name")
                txtItemCount.Text = dr("ItemCount")
                txtUserName.Text = dr("UserName")
                txtTillNo.Text = dr("TillNo")
                txtIssuanceTime.Text = dr("TimeX")
                txtSchemeID.Text = dr("SchemeId")
                txtConstituencyID.Text = dr("ConstituencyId")
                txtCountyID.Text = dr("CountyId")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadRecallTransPosItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT DI.Delivery_No, DI.Item_No, DI.Qty_Issued, DI.Qty_Rem, DI.Date_Issued, DI.Issue_Time, DI.DocumentNo, DI.StockInID, P.Description FROM delivery_items DI Inner Join product P on (DI.Item_No = P.ProductNo) Where DI.Delivery_No = '" & LblDeliveryNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            AddMatdgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                AddMatdgw.Rows.Add(dr("Delivery_No"), dr("Item_No"), dr("Description"), dr("Qty_Issued"), dr("Date_Issued"), dr("Issue_Time"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub txtSchemeName_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeName.TextChanged

    End Sub

    Private Sub frmUpdateMaterialDel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecallIssuancedetails()
        LoadRecallTransPosItems()
        LoadItems()
        txtNil.Text = 0
        btnSavedetails.Enabled = False
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
                txtUom.Text = dr("UnitofIssue")
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

    Private Sub txtQtytoIssue_TextChanged(sender As Object, e As EventArgs) Handles txtQtytoIssue.TextChanged
        If Val(txtQtytoIssue.Text) > Val(txtQtyonHand.Text) Then
            MsgBox("Quantity to Issue cannot be greater than available stock!", MsgBoxStyle.Exclamation, "Add Delivery Materials!")
            txtQtytoIssue.Clear()
            Exit Sub

        End If
        txtRemStock.Text = Val(txtQtyonHand.Text) - Val(txtQtytoIssue.Text)
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
            Query = "Insert into delivery_items (Delivery_No, Item_No, Qty_Issued, Qty_Rem, Date_Issued, Issue_Time, DocumentNo, SchemeRefNo, DeliveryNo, StockInID) VALUES ('" & LblDeliveryNo.Text & "', '" & txtItemCode.Text & "', '" & txtQtytoIssue.Text & "', '" & txtRemStock.Text & "', '" & txtIssuancedate.Text & "', '" & TimeOfDay & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub InsertDeliveryItems2()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'delivery_details
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Insert into delivery_items_2 (Delivery_No, Item_No, Qty_Issued, Qty_Rem, Date_Issued, Issue_Time, DocumentNo, SchemeRefNo, DeliveryNo, StockInID) VALUES ('" & LblDeliveryNo.Text & "', '" & txtItemCode.Text & "', '" & txtQtytoIssue.Text & "', '" & txtRemStock.Text & "', '" & txtIssuancedate.Text & "', '" & TimeOfDay & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub AddtoGrid()
        If txtItemCode.Text = "" Then
            MessageBox.Show("Please select Item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtItemCode.Focus()
            Return
        End If
        Dim rnum As Integer = AddMatdgw.Rows.Add()
        AddMatdgw.Rows.Item(rnum).Cells(0).Value = LblDeliveryNo.Text
        AddMatdgw.Rows.Item(rnum).Cells(1).Value = txtItemCode.Text
        AddMatdgw.Rows.Item(rnum).Cells(2).Value = cmdSearchItems.Text
        AddMatdgw.Rows.Item(rnum).Cells(3).Value = txtQtytoIssue.Text
        AddMatdgw.Rows.Item(rnum).Cells(4).Value = txtIssuancedate
        AddMatdgw.Rows.Item(rnum).Cells(5).Value = txtIssuanceTime
        btnSavedetails.Enabled = True
    End Sub
    Private Sub Dropduplicate()
        For intI As Integer = AddMatdgw.Rows.Count - 1 To 0 Step -1
            For intJ As Integer = AddMatdgw.Rows.Count - 1 To intI + 1 Step -1
                If AddMatdgw.Rows(intI).Cells(1).Value = AddMatdgw.Rows(intJ).Cells(1).Value Then
                    AddMatdgw.Rows.RemoveAt(intJ)
                    MsgBox("The item already exists in the delivery", MsgBoxStyle.Exclamation, "Add delivery item!")
                    btnSavedetails.Enabled = False
                    Exit Sub
                End If
            Next intJ
        Next intI
    End Sub
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        AddtoGrid()
        Dropduplicate()
    End Sub


    Private Sub UpdateQuantity()
        'Update Quantity
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE product SET StocksOnHand = StocksOnHand - '" & txtQtytoIssue.Text & "' WHERE ProductNo = '" & txtItemCode.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub UpdateQuantityinStockInMaterials()
        'Update Quantity
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE stockinmaterials SET Quantity = Quantity - '" & txtQtytoIssue.Text & "' WHERE PNO = '" & txtItemCode.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub Reset()
        AddMatdgw.Rows.Clear()
        LblDeliveryNo.Text = ""
        txtItemCode.Text = ""
        cmdSearchItems.Text = ""
        txtQtytoIssue.Text = ""
        txtUom.Text = ""
        txtRemStock.Text = ""

    End Sub

    Private Sub UpdateDeliveryMaterialToolStripButton5_Click(sender As Object, e As EventArgs) Handles UpdateDeliveryMaterialToolStripButton5.Click
        InsertDeliveryItems()
        InsertDeliveryItems2()
        UpdateQuantity()
        UpdateQuantityinStockInMaterials()
        MsgBox("New Delivery successfully added.", MsgBoxStyle.Information, "Add Delivery")
        Reset()
        Me.Close()
    End Sub
End Class