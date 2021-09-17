Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class FrmStockAdjustment
    Dim y As Integer
    Dim a As String

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
            cboSearchMaterials.Items.Clear()
            Do While dr.Read = True
                cboSearchMaterials.Items.Add(dr("Description"))
                cboSearchMaterials.Text = "Description"
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
            Query = "SELECT  ProductNo, Description, StocksOnHand, ReorderLevel, CateID, SubCateID, PrefSupplier, UnitofIssue from Product where Description = '" & cboSearchMaterials.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                LBLPrdctNo.Text = dr("ProductNo")
                LBLCurrentStck.Text = dr("StocksOnHand")
                txtdescription.Text = dr("Description")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PopulateUsers()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT username From staff order by username"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            CboAcctName.Items.Clear()
            Do While dr.Read = True
                CboAcctName.Items.Add(dr("username"))
                CboAcctName.Text = "None"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub FrmClosingOpeningStck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadItems()
        PopulateReason()
        PopulateUsers()
        PopulateAdjustmentType()
        txtDate.Text = Format(Now, "MM/dd/yyyy")

    End Sub
    Private Sub AddstockAdjustment()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If dgw.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please enter materials to adjust", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_stockadjustment(AdjustmentDate,  Adjustmentby, Description) Values('" & txtDate.Text & "', '" & FrmMain.tsslUser.Text & "', '" & txtRemarks.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub AddstockAdjustmentLine()
        For Each r As DataGridViewRow In dgw.Rows
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            If dgw.Rows(0).Cells(0).Value = Nothing Then
                MessageBox.Show("Please enter materials to adjust", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "INSERT INTO tbl_stockadjustmentline(StockAdjustID, ProductNo,  AdjustmentQty, CurrentStock, AdjustedStock, AdjustmentDate, AdjustmentType, AccountName, Reason, Remarks, AdjustedBy) Values((Select MAX(stockadjustmentId) from tbl_stockadjustment), '" & (r.Cells(1).Value) & "', '" & (r.Cells(3).Value) & "', '" & (r.Cells(4).Value) & "', '" & (r.Cells(5).Value) & "', '" & (r.Cells(6).Value) & "', '" & (r.Cells(7).Value) & "', '" & (r.Cells(8).Value) & "','" & (r.Cells(9).Value) & "','" & (r.Cells(10).Value) & "','" & (r.Cells(11).Value) & "')"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Next
        MsgBox("Stock Successfully Adjusted.", MsgBoxStyle.Information, "Stock Adjustment")
    End Sub

    Private Sub clearallfields()
        LBLPrdctNo.Text = ""
        txtdescription.Text = ""
        txtadjstqty.Text = ""
        LBLCurrentStck.Text = ""
        CboAcctName.Text = ""
        cboReason.Text = ""
        txtRemarks.Text = ""
        txtstckadjstmntID.Text = ""
        CboAdjustmentType.Text = ""
        dgw.Rows.Clear()
    End Sub

    Private Sub ClearFields()
        lblAdjustedSkt.Text = "###########"
        LBLCurrentStck.Text = "###########"
        LBLPrdctNo.Text = "###########"
        txtdescription.Text = ""
        txtadjstqty.Text = ""
        CboAcctName.Text = ""
        cboReason.Text = ""
        txtRemarks.Text = ""
        txtstckadjstmntID.Text = ""
        CboAdjustmentType.Text = ""

    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        'Me.LBLStckAdjustmentNo.Text = dgw.Item(0, i).Value
        'Me.LBLPrdctNo.Text = dgw.Item(1, i).Value
        'Me.txtdescription.Text = dgw.Item(2, i).Value
        'Me.txtDate.Text = dgw.Item(3, i).Value
        'Me.txtadjstqty.Text = dgw.Item(4, i).Value
        'Me.txtValue.Text = dgw.Item(6, i).Value
        'Me.cboReason.Text = dgw.Item(7, i).Value
        'Me.CboAcctName.Text = dgw.Item(8, i).Value
        'Me.TxtRemarks.Text = dgw.Item(9, i).Value
        'Me.LBLCurrentStck.Text = dgw.Item(10, i).Value
    End Sub
    Private Sub PopulateReason()
        cboReason.Items.Clear()
        cboReason.Items.Add("Damage")
        cboReason.Items.Add("Shortage")
        cboReason.Items.Add("Excess")
        cboReason.Items.Add("Expiry")
    End Sub
    Private Sub PopulateAdjustmentType()
        CboAdjustmentType.Items.Clear()
        CboAdjustmentType.Items.Add("Positive Adjustment")
        CboAdjustmentType.Items.Add("Negative Adjustment")
    End Sub
    Private Sub loadproductdetails()
        'Try
        '    sqL = "SELECT ProductNo, Description, Barcode, ProductCode, StocksOnHand, Selling_Price, VatCode, UnitPrice from Product where Barcode = '" & txtPrdctBarcode.Text & "' OR ProductCode = '" & txtPrdctBarcode.Text & "'"
        '    ConnDB()
        '    cmd = New MySqlCommand(sqL, conn)
        '    dr = cmd.ExecuteReader
        '    Do While dr.Read = True
        '        LBLPrdctNo.Text = dr("ProductNo")
        '        txtdescription.Text = dr("Description")
        '        LBLCurrentStck.Text = dr("StocksOnHand")
        '        'LBLBuyingPrc.Text = dr("UnitPrice")
        '    Loop
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'Finally
        '    cmd.Dispose()
        '    conn.Close()
        'End Try
    End Sub
    Private Sub txtPrdctBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadproductdetails()
    End Sub
    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        clearallfields()
    End Sub
    Private Sub txtadjstqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtadjstqty.TextChanged
        'lblAdjustedSkt.Text = Format(Val(LBLCurrentStck.Text) + Val(txtadjstqty.Text))
    End Sub
    Private Sub OCSSaveToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OCSSaveToolStripButton5.Click
        AddstockAdjustment()
        AddstockAdjustmentLine()
        'Update Audit Trail Table
        'Audit_Trail(FrmMain.tsslUser.Text, LBLStckAdjustmentNo.Text, TimeOfDay, "Adjusted Stock")
        clearallfields()
        'StockAdjustmentID()
    End Sub
    Private Sub PositiveAdjustment()
        lblAdjustedSkt.Text = Format(Val(LBLCurrentStck.Text) + Val(txtadjstqty.Text))
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If LBLPrdctNo.Text = "" Or txtdescription.Text = "" Or txtadjstqty.Text = "" Or LBLCurrentStck.Text = "" Or CboAcctName.Text = "" Or cboReason.Text = "" Or txtRemarks.Text = "" Or CboAdjustmentType.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Stock Adjustment!")
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE product SET StocksOnHand = StocksOnHand + '" & txtadjstqty.Text & "' WHERE ProductNo = '" & LBLPrdctNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub NegativeAdjustment()
        lblAdjustedSkt.Text = Format(Val(LBLCurrentStck.Text) - Val(txtadjstqty.Text))
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If LBLPrdctNo.Text = "" Or txtdescription.Text = "" Or txtadjstqty.Text = "" Or LBLCurrentStck.Text = "" Or CboAcctName.Text = "" Or cboReason.Text = "" Or txtRemarks.Text = "" Or CboAdjustmentType.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Stock Adjustment!")
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE product SET StocksOnHand = StocksOnHand - '" & txtadjstqty.Text & "' WHERE ProductNo = '" & LBLPrdctNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub LoadAdjustedStock()
        'Try
        '    sqL = "Select SA.StockAdjustID, SA.ProductNo, P.Description, SA.AdjustmentQty, SA.AdjustmentDate, SA.CurrentStock, SA.AdjustmentValue, SA.AdjustmentType, SA.AccountName, SA.Reason, SA.Remarks, SA.AdjustedBy FROM stockadjustment SA INNER JOIN product P ON (SA.ProductNo = P.ProductNo) WHERE StockAdjustID LIKE '" & txtstckadjstmntID.Text & "%'"
        '    ConnDB()
        '    cmd = New MySqlCommand(sqL, conn)
        '    dr = cmd.ExecuteReader
        '    dgw.Rows.Clear()
        '    y = 0
        '    Do While dr.Read = True
        '        dgw.Rows.Add(dr("StockAdjustID"), dr("ProductNo"), dr("Description"), dr("AdjustmentDate"), dr("AdjustmentQty"), dr("AdjustmentType"), dr("AdjustmentValue"), dr("Reason"), dr("AccountName"), dr("Remarks"), dr("CurrentStock"))
        '        y += 17
        '    Loop
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'Finally
        '    cmd.Dispose()
        '    conn.Close()
        'End Try
    End Sub
    Private Sub LoadAdjustedStockBtwDates()
        'Try
        '    sqL = "Select SA.StockAdjustID, SA.ProductNo, P.Description, SA.AdjustmentQty, SA.AdjustmentDate, SA.CurrentStock, SA.AdjustmentValue, SA.AdjustmentType, SA.AccountName, SA.Reason, SA.Remarks, SA.AdjustedBy FROM stockadjustment SA INNER JOIN product P ON (SA.ProductNo = P.ProductNo) WHERE AdjustmentDate BETWEEN @dt1 AND @dt2 ORDER BY AdjustmentDate"
        '    ConnDB()
        '    cmd = New MySqlCommand(sqL, conn)
        '    cmd.Parameters.AddWithValue("@dt1", DateTimePickerFrom.Value.ToString("MM/dd/yyyy"))
        '    cmd.Parameters.AddWithValue("@dt2", DateTimePickerTo.Value.ToString("MM/dd/yyyy"))
        '    dr = cmd.ExecuteReader
        '    dgw.Rows.Clear()
        '    y = 0
        '    Do While dr.Read = True
        '        dgw.Rows.Add(dr("StockAdjustID"), dr("ProductNo"), dr("Description"), dr("AdjustmentDate"), dr("AdjustmentQty"), dr("AdjustmentType"), dr("AdjustmentValue"), dr("Reason"), dr("AccountName"), dr("Remarks"), dr("CurrentStock"))
        '        y += 17
        '    Loop
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'Finally
        '    cmd.Dispose()
        '    conn.Close()
        'End Try
    End Sub
    Private Sub txtstckadjstmntID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstckadjstmntID.TextChanged
        LoadAdjustedStock()
    End Sub

    Private Sub BtnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoad.Click
        LoadAdjustedStockBtwDates()
    End Sub

    Private Sub cboSearchMaterials_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchMaterials.SelectedIndexChanged
        PopulateItemCodeTextboxes()
    End Sub
    Private Sub AddItemstoGrid()
        If LBLPrdctNo.Text = "" Then
            MessageBox.Show("Please enter Material to adjust", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LBLPrdctNo.Focus()
            Return
        End If

        If LBLCurrentStck.Text = "" Then
            MessageBox.Show("Please enter current stock", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LBLCurrentStck.Focus()
            Return
        End If

        If txtadjstqty.Text = "" Then
            MessageBox.Show("Please enter Qty to adjust", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtadjstqty.Focus()
            Return
        End If

        If CboAdjustmentType.Text = "" Then
            MessageBox.Show("Please enter Adjustment type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CboAdjustmentType.Focus()
            Return
        End If

        If txtRemarks.Text = "" Then
            MessageBox.Show("Please enter Remarks", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRemarks.Focus()
            Return
        End If
        If cboReason.Text = "" Then
            MessageBox.Show("Please enter Reason", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboReason.Focus()
            Return
        End If
        If CboAcctName.Text = "" Then
            MessageBox.Show("Please enter Account Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CboAcctName.Focus()
            Return
        End If

        Dim rnum As Integer = dgw.Rows.Add()
        dgw.Rows.Item(rnum).Cells(0).Value = LBLPrdctNo.Text
        dgw.Rows.Item(rnum).Cells(1).Value = LBLPrdctNo.Text
        dgw.Rows.Item(rnum).Cells(2).Value = txtdescription.Text
        dgw.Rows.Item(rnum).Cells(3).Value = txtadjstqty.Text
        dgw.Rows.Item(rnum).Cells(4).Value = LBLCurrentStck.Text
        dgw.Rows.Item(rnum).Cells(5).Value = lblAdjustedSkt.Text
        dgw.Rows.Item(rnum).Cells(6).Value = txtDate.Text
        dgw.Rows.Item(rnum).Cells(7).Value = CboAdjustmentType.Text
        dgw.Rows.Item(rnum).Cells(8).Value = CboAcctName.Text
        dgw.Rows.Item(rnum).Cells(9).Value = cboReason.Text
        dgw.Rows.Item(rnum).Cells(10).Value = txtRemarks.Text
        dgw.Rows.Item(rnum).Cells(11).Value = FrmMain.tsslUser.Text

    End Sub

    Private Sub btnAddtoGrid_Click(sender As Object, e As EventArgs) Handles btnAddtoGrid.Click
        If MessageBox.Show("Are you sure you want to adjust quantity of this material? The process is not reversable!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If CboAdjustmentType.Text = ("Positive Adjustment") Then
                PositiveAdjustment()
            ElseIf CboAdjustmentType.Text = ("Negative Adjustment") Then
                NegativeAdjustment()
            End If
            AddItemstoGrid()
            ClearFields()
        End If

    End Sub
End Class