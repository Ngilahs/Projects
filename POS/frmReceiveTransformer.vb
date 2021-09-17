Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmReceiveTransformer
    Dim y As Integer
    Private Sub AddTransformer()
        If txtDeliveryNo.Text = "" Or txtGNo.Text = "" Or txtItemNo.Text = "" Or txtSFTNo.Text = "" Or txtSupplierID.Text = "" Or txtSNo.Text = "" Then
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
            Query = "INSERT INTO tbl_receivetransformer (SNO,STFNO,GNO,SuppID,ItemNo,DeliveryNo,Qty,DateIn,ReceivedBy,Transformerissued) VALUES ('" & txtSNo.Text & "', '" & txtSFTNo.Text & "','" & txtGNo.Text & "','" & txtSupplierID.Text & "', '" & txtItemNo.Text & "', '" & txtDeliveryNo.Text & "', '" & txtreceivedQty.Text & "','" & lbldateRS.Text & "','" & FrmMain.tsslUser.Text & "', '" & chkTransformerissued.CheckState & "' )"
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
    Private Sub UpdateTransformerdetails()
        If txtDeliveryNo1.Text = "" Or txtGNo1.Text = "" Or txtItemNo1.Text = "" Or txtSFTNo1.Text = "" Or txtSupplierID1.Text = "" Or txtSNo1.Text = "" Then
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
            Query = "Update tbl_receivetransformer set SNO = '" & txtSNo1.Text & "', STFNO = '" & txtSFTNo1.Text & "', GNO = '" & txtGNo1.Text & "', SuppID = '" & txtSupplierID1.Text & "', ItemNo = '" & txtItemNo1.Text & "', DeliveryNo = '" & txtDeliveryNo1.Text & "', Qty = '" & txtreceivedQty1.Text & "' where RcvtransformerId = '" & txtTransRcvId.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        MsgBox("Transformer details successfully Updated")
    End Sub
    Private Sub ReceiveTransformer_Click(sender As Object, e As EventArgs) Handles ReceiveTransformer.Click

    End Sub

    Private Sub populateItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ProductNo, Description from product ORDER BY Description DESC LIMIT 300"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboSearchItem.Items.Clear()
            Do While dr.Read = True
                cboSearchItem.Items.Add(dr("Description"))
                cboSearchItem.Text = "Description"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PopulateTextboxes()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT  ProductNo, Description, StocksOnHand, ReorderLevel, CateID, SubCateID, PrefSupplier, UnitofIssue from Product where Description = '" & cboSearchItem.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtItemNo.Text = dr("ProductNo")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub cboSearchItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchItem.SelectedIndexChanged
        PopulateTextboxes()
        txtreceivedQty.Text = "1"
    End Sub

    Private Sub frmReceiveTransformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateItems()
        txtreceivedQty.Text = "1"
        txtreceivedQty1.Text = "1"

    End Sub

    Private Sub btnsupplierRS_Click(sender As Object, e As EventArgs) Handles btnsupplierRS.Click
        frmLoadSupplier.ShowDialog()
    End Sub

    Private Sub PSaveToolStripButton_Click(sender As Object, e As EventArgs) Handles PSaveToolStripButton.Click
        AddTransformer()
        insertintostockindetails()
        InsertintoStockinMaterials()
        InsertintoStockin()
        Updatematerials()
        ResetForm()
        txtreceivedQty.Text = "1"
    End Sub

    Private Sub UpdateToolStripButton_Click(sender As Object, e As EventArgs) Handles UpdateToolStripButton.Click
        UpdateTransformerdetails()
        ResetForm1()
        txtreceivedQty.Text = "1"
    End Sub

    Private Sub ToolStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub
    Private Sub dtgCartItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCartItems.CellContentClick
        Dim i As Integer
        i = dtgCartItems.CurrentRow.Index
        Me.txtTransRcvId.Text = dtgCartItems.Item(0, i).Value
        Me.txtItemNo1.Text = dtgCartItems.Item(1, i).Value
        Me.cboSearchItem1.Text = dtgCartItems.Item(2, i).Value
        Me.txtreceivedQty1.Text = dtgCartItems.Item(3, i).Value
        Me.txtSFTNo1.Text = dtgCartItems.Item(4, i).Value
        Me.txtSNo1.Text = dtgCartItems.Item(5, i).Value
        Me.txtGNo1.Text = dtgCartItems.Item(6, i).Value
        Me.txtDeliveryNo1.Text = dtgCartItems.Item(7, i).Value
        Me.txtSupplNameRS1.Text = dtgCartItems.Item(8, i).Value
        Me.txtSupplierID1.Text = dtgCartItems.Item(9, i).Value
        dtgCartItems.Rows.Clear()

    End Sub
    Private Sub ResetForm1()
        txtTransRcvId.Text = ""
        txtItemNo1.Text = ""
        txtreceivedQty1.Text = ""
        txtSFTNo1.Text = ""
        txtSNo1.Text = ""
        txtGNo1.Text = ""
        txtDeliveryNo1.Text = ""
        txtSupplNameRS1.Text = ""
        txtSupplierID1.Text = ""
        dtgCartItems.Rows.Clear()
    End Sub

    Private Sub ResetForm()
        txtTransRcvId.Text = ""
        txtItemNo.Text = ""
        txtreceivedQty.Text = ""
        txtSFTNo.Text = ""
        txtSNo.Text = ""
        txtGNo.Text = ""
        txtDeliveryNo.Text = ""
        txtSupplNameRS.Text = ""
        txtSupplierID.Text = ""
        dtgCartItems.Rows.Clear()
    End Sub

    Private Sub txtSearchGNoSNOSTFNo_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearchGNoSNOSTFNo.TextChanged
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
            tbl_receivetransformer.SNO,
            tbl_receivetransformer.STFNO,
            tbl_receivetransformer.GNO,
            tbl_receivetransformer.SuppID,
            tbl_receivetransformer.ItemNo,
            tbl_receivetransformer.DeliveryNo,
            tbl_receivetransformer.Qty,
            tbl_receivetransformer.DateIn,
            tbl_receivetransformer.ReceivedBy,
            suppliers.Supplier_ID,
            suppliers.Supp_Name,
            product.ProductNo,
            product.Description
            FROM
            tbl_receivetransformer
            INNER JOIN product ON tbl_receivetransformer.ItemNo = product.ProductNo
            INNER JOIN suppliers ON tbl_receivetransformer.SuppID = suppliers.Supplier_ID where SNO LIKE '%" & txtSearchGNoSNOSTFNo.Text & "%' Or STFNO LIKE '%" & txtSearchGNoSNOSTFNo.Text & "%' Or GNO LIKE '%" & txtSearchGNoSNOSTFNo.Text & "%' Or DeliveryNo Like '%" & txtSearchGNoSNOSTFNo.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dtgCartItems.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dtgCartItems.Rows.Add(dr("RcvtransformerId"), dr("ItemNo"), dr("Description"), dr("Qty"), dr("STFNO"), dr("SNO"), dr("GNO"), dr("DeliveryNo"), dr("Supp_Name"), dr("Supplier_ID"), dr("DateIn"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Updatematerials()
        'Update Quantity
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        Try
                MysqlConny.Open()
                Dim Querys As String
            Querys = "UPDATE product SET StocksOnHand = StocksOnHand + 1 WHERE ProductNo = '" & txtItemNo.Text & "'"
            cmd = New MySqlCommand(Querys, MysqlConny)
                dr = cmd.ExecuteReader
                MysqlConny.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConny.Dispose()
            End Try

        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtItemNo.Text, TimeOfDay, "Received New Transformer")
        txtSupplNameRS.Clear()
    End Sub

    Private Sub cboSearchItem1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchItem1.SelectedIndexChanged

    End Sub

    Private Sub txtSNo_KeyUp(sender As Object, e As EventArgs) Handles txtSNo.KeyUp
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
                .CommandText = "SELECT COUNT(*) FROM tbl_receivetransformer WHERE SNO  = '" & txtSNo.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Transformer S/NO Already Exists!", MsgBoxStyle.Exclamation, "Add New Transformer!")
                txtSNo.Clear()
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


    End Sub

    Private Sub txtGNo_KeyUp(sender As Object, e As EventArgs) Handles txtGNo.KeyUp
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
                .CommandText = "SELECT COUNT(*) FROM tbl_receivetransformer WHERE GNO  = '" & txtGNo.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Transformer G/NO Already Exists!", MsgBoxStyle.Exclamation, "Add New Transformer!")
                txtGNo.Clear()
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub txtSFTNo_KeyUp(sender As Object, e As EventArgs) Handles txtSFTNo.KeyUp
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
                .CommandText = "SELECT COUNT(*) FROM tbl_receivetransformer WHERE STFNO  = '" & txtSFTNo.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Transformer STFNO Already Exists!", MsgBoxStyle.Exclamation, "Add New Transformer!")
                txtSFTNo.Clear()
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub insertintostockindetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO stockindetails (DateIn, SuppID, ReceivedBy, DocumentNo, SchemeID) VALUES ('" & lbldateRS.Text & "', '" & txtSupplierID.Text & "', '" & FrmMain.tsslUser.Text & "', '" & txtSFTNo.Text & "','" & txtGNo.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    'Insert into material receicpt main table
    Private Sub InsertintoStockinMaterials()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtSupplNameRS.Text = Nothing Then
            MessageBox.Show("Please enter Suplier Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSupplNameRS.Focus()
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO stockinMaterials (StockInID, PNO, Quantity, QtyRem, Supplier_Name, DateIn, DocumentNo, SchemeID) " &
                         " VALUES ((Select MAX(StockInDetailID) from stockindetails), '" & txtItemNo.Text &
                         "','" & txtreceivedQty.Text & "', '" & txtreceivedQty.Text & "', '" & txtSupplierID.Text & "', '" & lbldateRS.Text & "', '" & txtSFTNo.Text & "', '" & txtGNo.Text & "')"

            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub InsertintoStockin()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader

        If txtSupplNameRS.Text = Nothing Then
            MessageBox.Show("Please enter Suuplier Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSupplNameRS.Focus()
            Exit Sub
        End If
        Try
                MysqlConn.Open()
                Dim Query As String
            Query = "INSERT INTO stockin (StockInID, PNO, Quantity, QtyRem, Supplier_Name, DateIn, DocumentNo, SchemeID) " &
                         " VALUES ((Select MAX(StockInDetailID) from stockindetails), '" & txtItemNo.Text &
                         "','" & txtreceivedQty.Text & "', '" & txtreceivedQty.Text & "', '" & txtSupplierID.Text & "', '" & lbldateRS.Text & "', '" & txtSFTNo.Text & "', '" & txtGNo.Text & "')"

            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        ''Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtSFTNo.Text, TimeOfDay, "Updated Stock Quantity")

    End Sub
End Class