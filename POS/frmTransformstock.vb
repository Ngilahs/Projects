Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmTransformstock
    
    Public Sub GetTransformIDs()
        Try
            sqL = "SELECT TransformstockID FROM transformstock ORDER BY TransformstockID DESC"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtTrefNo.Text = dr("TransformstockID") + 1
            Else
                txtTrefNo.Text = 1

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub frmTransformstock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetTransformIDs()
    End Sub
    Private Sub txtSBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSBarcode.TextChanged
        Try
            Dim itemid As String = txtSBarcode.Text
            Dim tot As Double
            Dim Bcode1 As String
            Dim Bcode2 As String
            Dim code As String
            sqL = "SELECT Barcode, Description, StocksOnHand, UnitPrice, ProductCode FROM product Where Barcode = '" & itemid & "' OR ProductCode = '" & itemid & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                Bcode1 = dr("Barcode")
                Bcode2 = dr("ProductCode")
                'Capture two Barcodes
                If txtSBarcode.Text = Bcode1 Then
                    Bcode1 = code
                    code = txtSBarcode.Text
                Else
                    If txtSBarcode.Text = Bcode2 Then
                        Bcode2 = code
                        code = txtSBarcode.Text
                    End If
                End If
                txtSBarcode.Text = code
                txtSDescription.Text = dr("Description")
                txtSCurrentlevel.Text = dr("StocksOnHand")
                LblUnitprice.Text = dr("UnitPrice")
                'txtSQty.Text = dr("Barcode")
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub txtDBarcd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDBarcd.TextChanged
        Try
            Dim itemid As String = txtDBarcd.Text
            Dim tot As Double
            Dim Bcode3 As String
            Dim Bcode4 As String
            Dim code1 As String
            sqL = "SELECT Barcode, Description, StocksOnHand, UnitPrice, ProductCode FROM product Where Barcode = '" & itemid & "' OR ProductCode = '" & itemid & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                Bcode3 = dr("Barcode")
                Bcode4 = dr("ProductCode")
                'Capture two Barcodes
                If txtDBarcd.Text = Bcode3 Then
                    Bcode3 = code1
                    code1 = txtDBarcd.Text
                Else
                    If txtDBarcd.Text = Bcode4 Then
                        Bcode4 = code1
                        code1 = txtDBarcd.Text
                    End If
                End If
                txtDBarcd.Text = code1
                txtDdescrp.Text = dr("Description")
                txtDcurrentlvl.Text = dr("StocksOnHand")
                LbldestUnitprc.Text = dr("UnitPrice")
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub UpdateDestinationQuantity()
        Try
            sqL = "UPDATE Product SET StocksOnhand =  '" & txtDcurrentlvl.Text & "' WHERE Barcode = '" & txtDBarcd.Text & "' OR ProductCode = '" & txtDBarcd.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtDBarcd.Text, TimeOfDay, "Increased Stock Quantity through Transformation")
    End Sub
    Private Sub UpdateSourceQuantity()
        Try
            sqL = "UPDATE Product SET StocksOnhand = '" & txtSCurrentlevel.Text & "' WHERE Barcode = '" & txtSBarcode.Text & "' OR ProductCode = '" & txtSBarcode.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtSBarcode.Text, TimeOfDay, "Reduced Stock Quantity through Transformation")
    End Sub
    Public Sub SaveTransformedStock()
        Try
            If Val(txtSCurrentlevel.Text) < 1 Then
                MessageBox.Show("Quantity to transform cannot be less than Zero", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                sqL = "INSERT INTO transformstock(Src_Barcode, Src_Descrp, Src_Currentlvl, Src_Qty, Src_Amt, Dst_Barcode, Dst_Descrp, Dst_CurrentLvl, Dst_Qty, Dst_Amt, Transformdate) Values('" & txtSBarcode.Text & "', '" & txtSDescription.Text & "', '" & txtSCurrentlevel.Text & "', '" & txtSQty.Text & "','" & txtSAmt.Text & "', '" & txtDBarcd.Text & "', '" & txtDdescrp.Text & "','" & txtDcurrentlvl.Text & "','" & txtDqty.Text & "','" & txtDAmt.Text & "','" & Date.Now.ToString("MM/dd/yyyy") & "')"
                ConnDB()
                cmd = New MySqlCommand(sqL, conn)
                dr = cmd.ExecuteReader
                MsgBox("Stocks successfully Transformed", MsgBoxStyle.Information, "Transform Stocks")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtTrefNo.Text, TimeOfDay, "Transformed Stock")
        UpdateSourceQuantity()
        UpdateDestinationQuantity()
        clearfields()
        GetTransformIDs()
    End Sub
    Private Sub TransformStock()
        Dim DUPrc As Decimal
        Dim SrcUntPrc As Decimal
        Dim Srcstck As Decimal
        Dim DstStck As Decimal
        If Len(Trim(txtSBarcode.Text)) = 0 Then
            MessageBox.Show("Please enter Source Barcode", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSBarcode.Focus()
            Exit Sub
        End If
        If Len(Trim(txtDBarcd.Text)) = 0 Then
            MessageBox.Show("Please enter Destination Barcode", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDBarcd.Focus()
            Exit Sub
        End If
        Try
            sqL = "SELECT Barcode, Description, StocksOnHand, UnitPrice, ProductCode FROM product Where Barcode = '" & txtSBarcode.Text & "' OR ProductCode = '" & txtSBarcode.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                SrcUntPrc = dr("UnitPrice")
                Srcstck = dr("StocksOnHand")
                txtSAmt.Text = Val(txtSQty.Text) * SrcUntPrc
                txtSCurrentlevel.Text = Srcstck - Val(txtSQty.Text)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        Try
            sqL = "SELECT Barcode, Description, StocksOnHand, UnitPrice, ProductCode FROM product Where Barcode = '" & txtDBarcd.Text & "' OR ProductCode = '" & txtDBarcd.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                DUPrc = dr("UnitPrice")
                DstStck = dr("StocksOnHand")
                txtDAmt.Text = txtSAmt.Text
                txtDAmt.Text = Val(txtDqty.Text) * DUPrc
                txtDcurrentlvl.Text = DstStck + Val(txtDqty.Text)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub clearfields()
        txtSBarcode.Text = ""
        txtSDescription.Text = ""
        txtSCurrentlevel.Text = ""
        txtSQty.Text = ""
        txtSAmt.Text = ""
        txtDBarcd.Text = ""
        txtDdescrp.Text = ""
        txtDcurrentlvl.Text = ""
        txtDqty.Text = ""
        txtDAmt.Text = ""
        LbldestUnitprc.Text = ""
        LblUnitprice.Text = ""
    End Sub
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSSaveToolStripButton5.Click
        SaveTransformedStock()
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSTransformToolStripButton4.Click
        TransformStock()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        clearfields()
        GetTransformIDs()
    End Sub
    Private Sub txtSQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSQty.TextChanged
        'If Val(txtSQty.Text) > Val(txtSCurrentlevel.Text) Then
        '    MessageBox.Show("Quantity to transform cannot be greater than current stock", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtSQty.Clear()
        '    Exit Sub
        'End If
        'txtSQty.Text = Val(txtSAmt.Text) / Val(LblUnitprice.Text)
    End Sub
    Private Sub txtDqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDqty.TextChanged
        'txtDqty.Text = Val(txtSAmt.Text) / Val(LbldestUnitprc.Text)
    End Sub

    Private Sub txtDAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDAmt.TextChanged
        txtDqty.Text = CInt(Val(txtSAmt.Text) / Val(LbldestUnitprc.Text))
    End Sub

    Private Sub txtSAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSAmt.TextChanged
        If Val(txtSQty.Text) > Val(txtSCurrentlevel.Text) Then
            MessageBox.Show("Quantity to transform cannot be greater than current stock", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSQty.Clear()
            Exit Sub
        End If
        txtSQty.Text = CInt(Val(txtSAmt.Text) / Val(LblUnitprice.Text))
    End Sub
End Class