Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmRejectionIn
    Dim y As Integer
    Dim Totprc As Decimal
    Dim mkup As Decimal
    Dim amttocalcvat As Decimal
    Dim vatableamt As Decimal
    Dim vatt As Decimal
    Dim itemcnt As Decimal
    Private Sub frmRejectionIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PostChangesToolStripButton5.Enabled = False
    End Sub
    Private Sub LoadRecallIssuancedetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT DD.DeliveryNo, DD.IssueDate, DD.ItemCount, DD.SchemeId, DD.CountyId, DD.ConstituencyId, DD.Status, DD.UserName, DD.TillNo, DD.SessIDNo, DD.TimeX, S.Scheme_Name, C.County_Name, CN.constituency_Name FROM delivery_details DD inner join schemes S on (DD.SchemeId = S.SchemeNo) inner join county C on (DD.CountyId = C.County_No) inner join constituency CN on (CN.Constituency_No = DD.ConstituencyId) WHERE DD.DeliveryNo = '" & txtEnterDeliveryNo.Text & "'and DD.Status = 1"
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
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("Delivery_No"), dr("Item_No"), dr("Description"), dr("Qty_Issued"), dr("Date_Issued"), dr("Issue_Time"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub LblRecptNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblDeliveryNo.KeyUp
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select DD.DeliveryNo, DD.IssueDate, DD.ItemCount, DD.SchemeId, DD.CountyId, DD.ConstituencyId, DD.UserName, DD.TillNo, DD.Status DD.SessIDNo, DD.TimeX, S.Scheme_Name, C.County_Name, CN.constituency_Name FROM delivery_details DD inner join schemes S on (DD.SchemeId = S.SchemeNo) inner join county C on (DD.CountyId = C.County_No) inner join constituency CN on (CN.Constituency_No = DD.ConstituencyId) WHERE DD.DeliveryNo = '" & LblDeliveryNo.Text & "' and DD.Status = 1"
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
        LoadRecallTransPosItems()
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.txtDeliveryNo2.Text = dgw.Item(0, i).Value
        Me.txtItemNo.Text = dgw.Item(1, i).Value
        Me.txtitemDescription.Text = dgw.Item(2, i).Value
        Me.txtQuantityIssued.Text = dgw.Item(3, i).Value
        Me.txtDateIssued.Text = dgw.Item(4, i).Value
        Me.txtIntialQty.Text = dgw.Item(3, i).Value
        dgw.Rows.Clear()
    End Sub
    Private Sub ReverseSaleToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReverseSaleToolStripButton2.Click
        If txtqtyreversed.Text = Nothing Then
            MessageBox.Show("Please Enter Quantity to Return", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim Subtot As Decimal
        Dim Mkup As Decimal
        Dim vat As Decimal
        Dim QtyIssued As Decimal
        Dim QtyReversed As Decimal
        Dim ItemCount As Decimal
        Dim RemQty As Decimal
        QtyIssued = txtQuantityIssued.Text
        QtyReversed = txtqtyreversed.Text
        ItemCount = txtItemCount.Text
        Subtot = QtyIssued - QtyReversed
        RemQty = ItemCount - QtyReversed
        txtQuantityIssued.Text = Subtot
        txtItemCount.Text = RemQty
        PostChangesToolStripButton5.Enabled = True
        txtqtyreversed.Enabled = False
        ReverseSaleToolStripButton2.Enabled = False
    End Sub
    Private Sub Reset()
        LblDeliveryNo.Text = ""
        txtIssuancedate.Text = ""
        txtSchemeName.Text = ""
        txtCountyName.Text = ""
        txtConstituencyName.Text = ""
        txtItemCount.Text = ""
        txtUserName.Text = ""
        txtTillNo.Text = ""
        txtIssuanceTime.Text = ""
        txtTillNo.Text = ""
        txtUserName.Text = ""
        'LBLSessID.Text = ""
        txtItemNo.Text = ""
        txtitemDescription.Text = ""
        txtQuantityIssued.Text = ""
        txtDateIssued.Text = ""
        dgw.Rows.Clear()
        txtqtyreversed.Text = ""
        txtEnterDeliveryNo.Text = ""
        txtDeliveryNo2.Text = ""

    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        Reset()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub updatedeliverydetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE delivery_details SET  ItemCount = '" & txtItemCount.Text & "' WHERE DeliveryNo = '" & LblDeliveryNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub UpdateDeliveryItemsTable()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE delivery_items SET Qty_Issued = '" & txtQuantityIssued.Text & "' WHERE Delivery_No = '" & txtDeliveryNo2.Text & "' AND Item_No = '" & txtItemNo.Text & "'"
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
            Query = "UPDATE product SET StocksOnHand = StocksOnHand + '" & txtqtyreversed.Text & "' WHERE ProductNo = '" & txtItemNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub UpdateQuantityinStockInMaterialsafterReturnMaterials()
        'Update Quantity
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE stockinmaterials SET Quantity = Quantity + '" & txtqtyreversed.Text & "' WHERE PNO = '" & txtItemNo.Text & "' AND StockInID = '" & LblDeliveryNo.Text & "'"
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
            Query = "INSERT INTO reverseddelivery (DeliveryNo, ItemNo, ReverseDate, QtyReturned, AuthorizedBy, Intialqty, Currentqty) Values ('" & LblDeliveryNo.Text & "', '" & txtItemNo.Text & "', '" & Format(Now, "MM/dd/yyyy") & "', '" & txtqtyreversed.Text & "', '" & FrmMain.tsslUser.Text & "', '" & txtIntialQty.Text & "', '" & txtQuantityIssued.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Material Delivery successfully Updated.", MsgBoxStyle.Information, "Update Delivery")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub PostChangesToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostChangesToolStripButton5.Click
        If txtItemNo.Text = "" Or txtitemDescription.Text = "" Then
            MessageBox.Show("Please select a record the table below to continue", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtqtyreversed.Text = Nothing Then
            MessageBox.Show("Enter Quantity to Update", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        UpdateQuantityinStockInMaterialsafterReturnMaterials()
        updatedeliverydetails()
        UpdateDeliveryItemsTable()
        UpdateproductQty()
        AddReversaleDetails()
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, LblDeliveryNo.Text, TimeOfDay, "Reversed A Delivery")
        Reset()
        'ReverseRefID()
        Me.Close()
    End Sub

    Private Sub txtEnterDeliveryNo_TextChanged(sender As Object, e As EventArgs) Handles txtEnterDeliveryNo.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select DD.DeliveryNo, DD.IssueDate, DD.ItemCount, DD.SchemeId, DD.CountyId, DD.ConstituencyId, DD.UserName, DD.TillNo, DD.SessIDNo, DD.TimeX, S.Scheme_Name, C.County_Name, CN.constituency_Name FROM delivery_details DD inner join schemes S on (DD.SchemeId = S.SchemeNo) inner join county C on (DD.CountyId = C.County_No) inner join constituency CN on (CN.Constituency_No = DD.ConstituencyId) WHERE DD.DeliveryNo = '" & txtEnterDeliveryNo.Text & "' and DD.Status = 1"
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
        LoadRecallTransPosItems()

    End Sub

    Private Sub LblRecptNo_TextChanged(sender As Object, e As KeyEventArgs) Handles LblDeliveryNo.KeyUp

    End Sub

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT DI.Delivery_No, DI.Item_No, DI.Qty_Issued, DI.Qty_Rem, DI.Date_Issued, DI.Issue_Time, P.Description FROM delivery_items DI Inner Join product P on (DI.Item_No = P.ProductNo) Where DI.Date_Issued BETWEEN @dt1 AND @dt2 ORDER BY DI.Date_Issued"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@dt1", dtpDateFrom.Value.ToString("MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dt2", dtpDateTo.Value.ToString("MM/dd/yyyy"))
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("Delivery_No"), dr("Item_No"), dr("Description"), dr("Qty_Issued"), dr("Date_Issued"), dr("Issue_Time"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub txtqtyreversed_TextChanged(sender As Object, e As EventArgs) Handles txtqtyreversed.TextChanged
        If Val(txtqtyreversed.Text) > Val(txtQuantityIssued.Text) Then
            MsgBox("Return Qty cannot be greater than issued Qty!", MsgBoxStyle.Exclamation, "Return Materials!")
            txtqtyreversed.Clear()
            Exit Sub
        End If
    End Sub
    Private Sub txtqtyreversed_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtqtyreversed.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub
End Class