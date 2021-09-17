Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmUpdateReceipts

    Dim y As Integer
    Dim m As Integer

    Private Sub LoadReceipts()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'Try
        MysqlConn.Open()
        Dim Query As String
        Query = "Select
stockin.StockInID,
stockin.PNO,
stockin.Quantity,
stockin.DateIn,
suppliers.Supplier_ID,
suppliers.Supp_Name,
stockindetails.StockInDetailID,
stockin.DocumentNo,
product.ProductNo,
product.Description,
schemes.SchemeNo,
schemes.Scheme_Name,
county.County_No,
county.County_Name,
stockindetails.SuppID,
constituency.Constituency_No,
constituency.constituency_Name,
stockindetails.SchemeID
FROM
stockin
INNER JOIN stockindetails ON stockin.StockInID = stockindetails.StockInDetailID
INNER JOIN suppliers ON stockindetails.SuppID = suppliers.Supplier_ID
INNER JOIN product ON stockin.PNO = product.ProductNo
INNER JOIN schemes ON schemes.SchemeNo = stockindetails.SchemeID
INNER JOIN constituency ON constituency.Constituency_No = schemes.Constituency_Id
INNER JOIN county ON county.County_No = schemes.County_Id WHERE stockin.StockInID = '" & txtReceiptNo.Text & "'"
        cmd = New MySqlCommand(Query, MysqlConn)
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            LblstockinID.Text = dr("StockInID")
            txtIssuancedate.Text = dr("DateIn")
            txtSchemeName.Text = dr("Scheme_Name")
            txtCountyName.Text = dr("County_Name")
            txtConstituencyName.Text = dr("constituency_Name")
            txtSchemeID.Text = dr("SchemeID")
            txtConstituencyID.Text = dr("Constituency_No")
            txtCountyID.Text = dr("County_No")
            txtsupplier.Text = dr("Supp_Name")
            txtSupplierId.Text = dr("Supplier_ID")
        Loop
        MysqlConn.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        MysqlConn.Dispose()
        'End Try
    End Sub

    Private Sub LoadDeliveryNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'Try
        MysqlConn.Open()
        Dim Query As String
        Query = "Select
stockin.StockInID,
stockin.PNO,
stockin.Quantity,
stockin.DateIn,
suppliers.Supplier_ID,
suppliers.Supp_Name,
stockindetails.StockInDetailID,
stockin.DocumentNo,
product.ProductNo,
product.Description,
schemes.SchemeNo,
schemes.Scheme_Name,
county.County_No,
county.County_Name,
stockindetails.SuppID,
constituency.Constituency_No,
constituency.constituency_Name,
stockindetails.SchemeID
FROM
stockin
INNER JOIN stockindetails ON stockin.StockInID = stockindetails.StockInDetailID
INNER JOIN suppliers ON stockindetails.SuppID = suppliers.Supplier_ID
INNER JOIN product ON stockin.PNO = product.ProductNo
INNER JOIN schemes ON schemes.SchemeNo = stockindetails.SchemeID
INNER JOIN constituency ON constituency.Constituency_No = schemes.Constituency_Id
INNER JOIN county ON county.County_No = schemes.County_Id WHERE stockin.DocumentNo = '" & txtSupplierDNote.Text & "'"
        cmd = New MySqlCommand(Query, MysqlConn)
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            LblstockinID.Text = dr("StockInID")
            txtIssuancedate.Text = dr("DateIn")
            txtSchemeName.Text = dr("Scheme_Name")
            txtCountyName.Text = dr("County_Name")
            txtConstituencyName.Text = dr("constituency_Name")
            txtSchemeID.Text = dr("SchemeID")
            txtConstituencyID.Text = dr("Constituency_No")
            txtCountyID.Text = dr("County_No")
            txtsupplier.Text = dr("Supp_Name")
            txtSupplierId.Text = dr("Supplier_ID")
        Loop
        MysqlConn.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        MysqlConn.Dispose()
        'End Try
    End Sub
    Private Sub LoadSchemes()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SchemeNo, Scheme_Name from schemes"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            txtSchemeName.Items.Clear()
            Do While dr.Read = True
                txtSchemeName.Items.Add(dr("Scheme_Name"))
                txtSchemeName.Text = "Scheme Name"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadSchemename()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SchemeNo, Scheme_Name, Scheme_Ref_No, County_Id, Constituency_Id from schemes where Scheme_Name  = '" & txtSchemeName.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtSchemeID.Text = dr("SchemeNo")
                txtConstituencyID.Text = dr("Constituency_Id")
                txtCountyID.Text = dr("County_Id")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub Loadcounty()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT County_Name, County_No from county where County_No  = '" & txtCountyID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtCountyName.Text = dr("County_Name")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadConstituency()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT constituency_Name from constituency where Constituency_No  = '" & txtConstituencyID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtConstituencyName.Text = dr("constituency_Name")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmUpdateReceipts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSchemes()
    End Sub

    Private Sub txtEnterDeliveryNo_TextChanged(sender As Object, e As EventArgs) Handles txtReceiptNo.TextChanged
        LoadReceipts()
        LoadReceiptdetails()
    End Sub
    Private Sub LoadReceiptdetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
stockin.StockInID,
stockin.PNO,
stockin.Quantity,
stockin.DateIn,
stockin.Supplier_Name,
stockin.DocumentNo,
stockin.SchemeID,
product.ProductNo,
product.Description,
product.UnitofIssue
FROM
product
INNER JOIN stockin ON stockin.PNO = product.ProductNo WHERE stockin.StockInID = '" & LblstockinID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("StockInID"), dr("PNO"), dr("Description"), dr("Quantity"), dr("DateIn"), dr("DocumentNo"), dr("UnitofIssue"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.txtItemNo.Text = dgw.Item(1, i).Value
        Me.txtitemDescription.Text = dgw.Item(2, i).Value
        Me.txtQuantityIssued.Text = dgw.Item(3, i).Value
        Me.txtDateIssued.Text = dgw.Item(4, i).Value
        Me.txtReceiptID.Text = dgw.Item(0, i).Value
        Me.txtDocNo.Text = dgw.Item(5, i).Value
        Me.txtUoM.Text = dgw.Item(6, i).Value
        Me.txtRcvdqty2.Text = dgw.Item(3, i).Value
        dgw.Rows.Remove(dgw.CurrentRow)
    End Sub

    Private Sub txtqtyreversed_TextChanged(sender As Object, e As EventArgs) Handles txtqtyreversed.TextChanged

        If Val(txtqtyreversed.Text) > Val(txtQuantityIssued.Text) Then
            MessageBox.Show("Quantity to reverse cannot be greater than Quantity Issued", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtqtyreversed.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub ReverseSaleToolStripButton2_Click(sender As Object, e As EventArgs)
        'If txtqtyreversed.Text = Nothing Then
        '    MessageBox.Show("Enter Quantity to Update", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'End If
        'If chkAdd.Checked = True Then
        '    Dim Subtot As Decimal
        '    Dim QtyIssued As Decimal
        '    Dim QtyReversed As Decimal
        '    QtyIssued = txtQuantityIssued.Text
        '    QtyReversed = txtqtyreversed.Text
        '    Subtot = QtyIssued + QtyReversed
        '    txtQuantityIssued.Text = Subtot
        'ElseIf chkSubtract.Checked = True Then
        '    Dim FinalQty As Decimal
        '    Dim QtyIssue As Decimal
        '    Dim QtyReverse As Decimal
        '    QtyIssue = txtQuantityIssued.Text
        '    QtyReverse = txtqtyreversed.Text
        '    FinalQty = QtyIssue + QtyReverse
        '    txtQuantityIssued.Text = FinalQty
        'End If

    End Sub
    Private Sub UpdateproductQtyBeforeReverse()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE product SET StocksOnHand = StocksOnHand - '" & txtRcvdqty2.Text & "' WHERE ProductNo = '" & txtItemNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub AddReversaleDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO reversedreceipt (ReceiptNo, ItemNo, UpdateDate, QtyUpdated, IntialQty, CurrentQty, AuthorizedBy) Values ('" & LblstockinID.Text & "', '" & txtItemNo.Text & "', '" & Format(Now, "MM/dd/yyyy") & "', '" & txtqtyreversed.Text & "', '" & txtRcvdqty2.Text & "', '" & txtQuantityIssued.Text & "', '" & FrmMain.tsslUser.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Receipt successfully upadted", MsgBoxStyle.Information, "Update Receipt")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'RemoveEmptyReverseRowNo()
    End Sub

    Private Sub Updateschemeinstockin()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE stockin SET SchemeID = '" & txtSchemeID.Text & "' WHERE StockInID = '" & txtReceiptID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub UpdateStockInMaterialsTable()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE stockin SET Quantity = '" & txtQuantityIssued.Text & "', DateIn = '" & txtIssuancedate.Text & "' WHERE StockInID = '" & LblstockinID.Text & "' AND PNO = '" & txtItemNo.Text & "'AND DocumentNo = '" & txtDocNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub UpdateStockInDate()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE stockin SET  DateIn = '" & txtIssuancedate.Text & "' WHERE StockInID = '" & LblstockinID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub UpdateproductQty()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE product SET StocksOnHand = StocksOnHand + '" & txtQuantityIssued.Text & "' WHERE ProductNo = '" & txtItemNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub chkAdd_CheckedChanged(sender As Object, e As EventArgs) Handles chkAdd.CheckedChanged
        chkSubtract.Checked = False
        If txtqtyreversed.Text = Nothing Then
            MessageBox.Show("Enter Quantity to Update", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If chkAdd.Checked = True Then
            chkSubtract.Enabled = False
            Dim Subtot As Decimal
            Dim QtyIssued As Decimal
            Dim QtyReversed As Decimal
            QtyIssued = txtQuantityIssued.Text
            QtyReversed = txtqtyreversed.Text
            Subtot = QtyIssued + QtyReversed
            txtQuantityIssued.Text = Subtot
            chkAdd.Enabled = False
        End If
    End Sub

    Private Sub chkSubtract_CheckedChanged(sender As Object, e As EventArgs) Handles chkSubtract.CheckedChanged
        chkAdd.Checked = False
        If txtqtyreversed.Text = Nothing Then
            MessageBox.Show("Enter Quantity to Update", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If chkSubtract.Checked = True Then
            chkAdd.Enabled = False
            Dim FinalQty As Decimal
            Dim QtyIssue As Decimal
            Dim QtyReverse As Decimal
            QtyIssue = txtQuantityIssued.Text
            QtyReverse = txtqtyreversed.Text
            FinalQty = QtyIssue - QtyReverse
            txtQuantityIssued.Text = FinalQty
            chkSubtract.Enabled = False
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        txtQuantityIssued.Text = txtRcvdqty2.Text
        chkSubtract.Checked = False
        chkAdd.Checked = False
        chkSubtract.Enabled = True
        chkAdd.Enabled = True
        txtqtyreversed.Clear()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub PostChangesToolStripButton5_Click(sender As Object, e As EventArgs) Handles PostChangesToolStripButton5.Click
        'txtItemNo
        If txtItemNo.Text = "" Then
            MessageBox.Show("Please select row from the table below to update quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'txtQuantityIssued
        If txtQuantityIssued.Text = "" Then
            MessageBox.Show("Please select row from the table below to update quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtqtyreversed.Text = "" Then
            MessageBox.Show("Please Enter Quantity to Adjust", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        UpdateproductQtyBeforeReverse()
        AddReversaleDetails()
        UpdateStockInMaterialsTable()
        Updateschemeinstockin()
        UpdateproductQty()
        UpdateStockindetails()
        UpdateStockInDate()
        ''Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtReceiptID.Text, TimeOfDay, "Updated Material Receipt")
        reset()
    End Sub
    Private Sub reset()
        Me.txtItemNo.Text = ""
        Me.txtitemDescription.Text = ""
        Me.txtDateIssued.Text = ""
        Me.txtReceiptID.Text = ""
        Me.txtDocNo.Text = ""
        Me.txtUoM.Text = ""
        Me.txtRcvdqty2.Text = ""
        Me.txtQuantityIssued.Text = ""
        Me.txtqtyreversed.Text = ""
    End Sub

    Private Sub txtSchemeName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSchemeName.SelectedIndexChanged
        LoadSchemename()
        LoadConstituency()
        Loadcounty()
    End Sub
    'txtIssuancedate
    Private Sub UpdateStockindetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            If LblstockinID.Text = "" Or txtsupplier.Text = "" Or txtSchemeID.Text = "" Then
                MsgBox("Please Select Record to Update!", MsgBoxStyle.Exclamation, "Update New Item!")
            Else
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE stockindetails SET SuppID = '" & txtSupplierId.Text & "', SchemeID = '" & txtSchemeID.Text & "', DateIn = '" & txtIssuancedate.Text & "' WHERE StockInDetailID = '" & LblstockinID.Text & "'"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub btnsupplierRS_Click(sender As Object, e As EventArgs) Handles btnsupplierRS.Click
        frmLoadSupplier.ShowDialog()
    End Sub

    Private Sub MyTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtqtyreversed.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSupplierDNote_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierDNote.TextChanged
        LoadDeliveryNo()
        LoadReceiptdetails()
    End Sub
    Private Sub LoadMaterialReceipts()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            'stockindetails(StockInDetailID, DateIn, SuppID, ReceivedBy, DocumentNo, DeliveryNo, SchemeID
            MysqlConn.Open()
            Dim Query As String
            Query = "Select S.StockInDetailID, S.DateIn, S.DocumentNo, S.SchemeID, S.SuppID, SS.Scheme_Name, SS.SchemeNo, SP.Supplier_ID, SP.Supp_Name FROM stockindetails S inner join schemes SS on (S.SchemeId = SS.SchemeNo) inner join suppliers SP on (SP.Supplier_ID = S.SuppID) WHERE S.StockInDetailID  LIKE '%" & txtReceiptdelivery.Text & "%' or SP.Supp_Name  LIKE '%" & txtReceiptdelivery.Text & "%' or S.DocumentNo LIKE '%" & txtReceiptdelivery.Text & "%' and S.DocumentNo <> '0ZXXXXX00012100005851111100'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw1.Rows.Clear()
            m = 0
            Do While dr.Read = True
                dgw1.Rows.Add(dr("StockInDetailID"), dr("DocumentNo"), dr("Supp_Name"))
                m += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub dgw1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw1.CellContentClick
        Dim i As Integer
        i = dgw1.CurrentRow.Index
        Me.txtReceiptNo.Text = dgw1.Item(0, i).Value
        dgw1.Rows.Clear()
    End Sub
    Private Sub txtReceiptdelivery_TextChanged(sender As Object, e As EventArgs) Handles txtReceiptdelivery.TextChanged
        LoadMaterialReceipts()
    End Sub
End Class