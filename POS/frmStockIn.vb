Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmStockIn
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Dim y As Integer
    Private Sub GetStockID()
        Try
            sqL = "SELECT StockInID FROM stockIn ORDER BY StockInID DESC"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtStockinID.Text = dr("StockInID") + 1
            Else
                txtStockinID.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub TxtEnterprdtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEnterprdtBarcode.TextChanged
        Try
            Dim maxrow As Integer
            Dim itemid As String = TxtEnterprdtBarcode.Text
            Dim tot As Double
            Dim Vatrate As Decimal = 16 / 116
            sqL = "SELECT ProductNo,ProductCode, Description, Barcode, StocksOnHand, ReorderLevel, CategoryName, Selling_Price, VatCode, UnitPrice FROM Product Where Barcode = '" & itemid & "' OR ProductCode = '" & itemid & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtProdDescrp.Text = dr("Description")
                txtProdBarcode.Text = TxtEnterprdtBarcode.Text
                txtVAT.Text = dr("Selling_Price") * Vatrate
                'txtMarkup.Text = Val(txtSellingPrc.Text) - Val(txtBuyingPrice.Text)
                txtBuyingPrice.Text = dr("UnitPrice")
                LBLProdNo.Text = dr("ProductNo")
                txtSellingPrc.Text = dr("Selling_Price")
                txtStockonhand.Text = dr("StocksOnHand")
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        txtMarkup.Text = Val(txtSellingPrc.Text) - Val(txtBuyingPrice.Text)
    End Sub

    Private Sub SaveinStockIn()
        If txtSupplierName.Text = Nothing Then
            MessageBox.Show("Please enter Suuplier Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSupplierName.Focus()
            Exit Sub
        End If
        If txtpurchasemode.Text = Nothing Then
            MessageBox.Show("Please enter Purchase Terms", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpurchasemode.Focus()
            Exit Sub
        End If
        Try
            sqL = "INSERT INTO stockIn (StockInID, ProductBarcode, Quantity, TotalItem_Price, VAT, Markup, Supplier_Name, ModeofPurch, DateIn, PNO, QtyRem, TimeS) Values('" & txtStockinID.Text & "','" & txtProdBarcode.Text & "', '" & txtQuantity.Text & "', '" & txtTotalPrice.Text & "', '" & txtVAT.Text & "', '" & txtMarkup.Text & "',  '" & txtSupplierName.Text & "', '" & txtpurchasemode.Text & "', '" & txtdatein.Text & "', '" & LBLProdNo.Text & "', '" & txtRemQty.Text & "', '" & TimeOfDay & "')"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Product UnitPrice
        Try
            sqL = "UPDATE product, stockIn SET product.UnitPrice = ((product.StocksOnHand * product.UnitPrice) + (stockIn.TotalItem_Price))/(product.StocksOnHand + stockIn.Quantity) WHERE stockIn.PNO = product.ProductNo AND StockInID = '" & txtStockinID.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Quantity
        Try
            sqL = "UPDATE product, stockIn SET product.StocksOnHand = product.StocksOnHand + stockIn.Quantity  WHERE stockIn.PNO = product.ProductNo AND StockInID = '" & txtStockinID.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        ''Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtProdBarcode.Text, TimeOfDay, "Updated Stock UnitPrice")
        ''Next
        MsgBox("Stocks successfully added.", MsgBoxStyle.Information, "Add Stocks")
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtStockinID.Text, TimeOfDay, "Received New Stock")
    End Sub
    Private Sub insertintostockindetails()
        Try
            sqL = "INSERT INTO stockindetails (StockInDetailID, TotalItem_Price, DateIn, Supplier_Name, ModeofPurch, DueAmt, PurchModeID, SuppID, TimeSD, ReceivedBy) VALUES ('" & txtStockinID.Text & "', '" & txtTotalPrice.Text & "', '" & txtdatein.Text & "', '" & txtSupplierName.Text & "', '" & txtpurchasemode.Text & "', '" & txtTotalPrice.Text & "', '" & txtPurchMdID.Text & "', '" & txtSuupID.Text & "', '" & TimeOfDay & "', '" & FrmMain.tsslUser.Text & "')"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub UpdateProduct()
        Try
            sqL = "UPDATE StockIn SET ProductBarcode = '" & txtProdBarcode.Text & "', Quantity = '" & txtQuantity.Text & "', TotalItem_Price = '" & txtTotalPrice.Text.Replace(",", "") & "',  Supplier_Name = '" & txtSupplierName.Text & "',  ModeofPurch  = '" & txtpurchasemode.Text & "' WHERE PNO = '" & LBLProdNo.Text & "' And StockInID = '" & txtStockinID.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            MsgBox("Product successfully Updated.", MsgBoxStyle.Information, "Update Product")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub updatestockindetails()
        Try
            sqL = "UPDATE stockindetails SET TotalItem_Price = '" & txtTotalPrice.Text.Replace(",", "") & "', DueAmt = '" & txtTotalPrice.Text.Replace(",", "") & "', Supplier_Name = '" & txtSupplierName.Text & "',  ModeofPurch  = '" & txtpurchasemode.Text & "' WHERE StockInDetailID = '" & txtStockinID.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmStockIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetStockID()
        clearfields()
        txtdatein.Text = Format(Now, "MM/dd/yyyy")
    End Sub
    Private Sub frmStockIn_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmProductSearch.Close()
        'frmListofMPESASales.Close()
    End Sub
    Private Sub clearfields()
        txtProdBarcode.Text = ""
        txtProdDescrp.Text = ""
        txtQuantity.Text = ""
        txtBuyingPrice.Text = ""
        txtTotalPrice.Text = ""
        txtMarkup.Text = ""
        txtVAT.Text = ""
        txtSupplierName.Text = ""
        txtpurchasemode.Text = ""
        TxtEnterprdtBarcode.Text = ""
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.txtStockinID.Text = dgw.Item(0, i).Value
        Me.txtProdBarcode.Text = dgw.Item(1, i).Value
        Me.txtProdDescrp.Text = dgw.Item(2, i).Value
        Me.txtdatein.Text = dgw.Item(3, i).Value
        Me.txtQuantity.Text = dgw.Item(4, i).Value
        Me.txtTotalPrice.Text = dgw.Item(5, i).Value
        Me.LBLProdNo.Text = dgw.Item(6, i).Value
        Me.txtSupplierName.Text = dgw.Item(7, i).Value
        Me.txtpurchasemode.Text = dgw.Item(8, i).Value
    End Sub
    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        txtTotalPrice.Text = Val(txtQuantity.Text) * Val(txtBuyingPrice.Text)
        txtRemQty.Text = Val(txtQuantity.Text) + Val(txtStockonhand.Text)
    End Sub
    Public Sub Loadproductdetailsfromdatagrid()
        For i = 0 To frmListofStock.dtgpdcts.Rows.Count - 1
            Dim maxrow As Integer
            Dim itemid As String = TxtEnterprdtBarcode.Text
            Dim tot As Double
            Dim Vatrate As Decimal = 16 / 116
            Dim conr As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
            conr.Open()
            Try
                sqll = "SELECT ProductNo, ProductCode, Description, Barcode, StocksOnHand, ReorderLevel, CategoryName, Selling_Price, VatCode, UnitPrice FROM Product Where ProductNo = '" & frmProductSearch.dtgpdcts.CurrentRow.Cells(6).Value & "'"
                cmd = New MySqlCommand(sqll, conr)
                dr = cmd.ExecuteReader
                    If dr.Read = True Then
                        TxtEnterprdtBarcode.Text = frmProductSearch.dtgpdcts.CurrentRow.Cells(0).Value
                        txtProdDescrp.Text = dr("Description")
                        txtProdBarcode.Text = TxtEnterprdtBarcode.Text
                        txtVAT.Text = dr("Selling_Price") * Vatrate
                        'txtMarkup.Text = dr("Selling_Price") - Val(txtBuyingPrice.Text)
                        txtMarkup.Text = Val(txtSellingPrc.Text) - Val(txtBuyingPrice.Text)
                        txtBuyingPrice.Text = dr("UnitPrice")
                        LBLProdNo.Text = dr("ProductNo")
                        txtSellingPrc.Text = dr("Selling_Price")
                    End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cmd.Dispose()
                conn.Close()
            End Try
        Next
    End Sub
    Private Sub txtProdBarcode_KeyUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProdBarcode.KeyUp
        Try
            Dim maxrow As Integer
            Dim itemid As String = txtProdBarcode.Text
            Dim tot As Double
            sqL = "SELECT Barcode, Description, StocksOnHand FROM Product Where Barcode = '" & itemid & "' "
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtProdDescrp.Text = dr("Description")
                txtProdBarcode.Text = dr("Barcode")
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub txtUnitCost_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuyingPrice.KeyUp
        txtTotalPrice.Text = Val(txtBuyingPrice.Text) * Val(txtQuantity.Text)
    End Sub
    Private Sub txtSellingPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim vatrate As Double
        vatrate = 16 / 116
        'If Val(txtSellingPrice.Text) < Val(txtUnitCost.Text) Then
        '    MsgBox("Selling Price cannot be Less than Buying Price", MsgBoxStyle.Exclamation, "Stock Purchases")
        'End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        frmProductSearch.Close()
        'frmListofMPESASales.Close()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QCKsaveToolStripButton5.Click
        SaveinStockIn()
        insertintostockindetails()
        GetStockID()
        clearfields()
        Me.Close()
        Call frmProductSearch.frmProductSearch_Load(sender, e)
        frmProductSearch.Close()
        'frmListofMPESASales.Close()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        GetStockID()
        clearfields()
        txtQuantity.Enabled = True
        txtTotalPrice.Enabled = True
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QCKUpdateToolStripButton3.Click
        UpdateProduct()
        updatestockindetails()
        GetStockID()
        clearfields()
        Me.Close()
        frmProductSearch.Close()
        'frmListofMPESASales.Close()
    End Sub
    Private Sub BtnSuppName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSuppName.Click
        frmLoadSupplier.ShowDialog()
    End Sub

    Private Sub btnmodeofpurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodeofpurchase.Click
        frmLoadPurchaseterms1.ShowDialog()
    End Sub

    Private Sub txtTotalPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalPrice.TextChanged
        txtBuyingPrice.Text = Val(txtTotalPrice.Text) / Val(txtQuantity.Text)
    End Sub
    Private Sub GetStockpurchased()
        Try
            sqL = "SELECT S.StockInID, S.ProductBarcode, P.Description, S.DateIn, S.Quantity, S.TotalItem_Price, S.PNO, S.Supplier_Name, S.ModeofPurch FROM stockIn S inner join product P on (S.PNO = P.ProductNo) WHERE DateIn BETWEEN @dt1 AND @dt2 ORDER BY DateIn"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@dt1", dtpDateFrom.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dt2", dtpDateTo.Value.ToString("MM/dd/yyyy"))
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8))
                y += 17
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        GetStockpurchased()
        txtQuantity.Enabled = True
        txtTotalPrice.Enabled = True
        txtBuyingPrice.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        GetStockID()
        clearfields()
        txtQuantity.Enabled = True
        txtTotalPrice.Enabled = True
        txtBuyingPrice.Enabled = True
        dgw.Rows.Clear()
    End Sub
End Class