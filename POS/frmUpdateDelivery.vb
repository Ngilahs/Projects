Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmUpdateDelivery
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
            Query = "SELECT DD.DeliveryNo, DD.IssueDate, DD.ItemCount, DD.SchemeId, DD.CountyId, DD.ConstituencyId, DD.UserName, DD.TillNo, DD.SessIDNo, DD.TimeX, S.Scheme_Name, C.County_Name, CN.constituency_Name FROM delivery_details DD inner join schemes S on (DD.SchemeId = S.SchemeNo) inner join county C on (DD.CountyId = C.County_No) inner join constituency CN on (CN.Constituency_No = DD.ConstituencyId) WHERE DD.DeliveryNo = '" & txtEnterDeliveryNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                LblDeliveryNo.Text = dr("DeliveryNo")
                txtIssuancedate.Text = dr("IssueDate")
                txtSchemeName.Text = dr("Scheme_Name")
                txtCountyName.Text = dr("County_Name")
                txtConstituencyName.Text = dr("constituency_Name")
                txtItemCount.Text = dr("ItemCount")
                txtItemcnt.Text = dr("ItemCount")
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
            Query = "SELECT DI.Delivery_No, DI.Item_No, DI.Qty_Issued, DI.Qty_Rem, DI.DocumentNo, DI.StockInID, DI.SchemeRefNo, DI.DeliveryNo, DI.Date_Issued, DI.Issue_Time, P.Description FROM delivery_items DI Inner Join product P on (DI.Item_No = P.ProductNo) Where DI.Delivery_No = '" & LblDeliveryNo.Text & "'"
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

    Private Sub txtEnterDeliveryNo_TextChanged(sender As Object, e As EventArgs) Handles txtEnterDeliveryNo.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select DD.DeliveryNo, DD.IssueDate, DD.ItemCount, DD.SchemeId, DD.CountyId, DD.ConstituencyId, DD.UserName, DD.TillNo, DD.SessIDNo, DD.TimeX, S.Scheme_Name, C.County_Name, CN.constituency_Name FROM delivery_details DD inner join schemes S on (DD.SchemeId = S.SchemeNo) inner join county C on (DD.CountyId = C.County_No) inner join constituency CN on (CN.Constituency_No = DD.ConstituencyId) WHERE DD.DeliveryNo = '" & txtEnterDeliveryNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                LblDeliveryNo.Text = dr("DeliveryNo")
                txtIssuancedate.Text = dr("IssueDate")
                txtSchemeName.Text = dr("Scheme_Name")
                txtCountyName.Text = dr("County_Name")
                txtConstituencyName.Text = dr("constituency_Name")
                txtItemCount.Text = dr("ItemCount")
                txtItemcnt.Text = dr("ItemCount")
                txtUserName.Text = dr("UserName")
                txtTillNo.Text = dr("TillNo")
                txtIssuanceTime.Text = dr("TimeX")
                txtSchemeID.Text = dr("SchemeId")
                txtConstituencyID.Text = dr("ConstituencyId")
                txtCountyID.Text = dr("CountyId")
                txtCountyID.Text = dr("CountyId")
                txtCountyID.Text = dr("CountyId")
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

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.txtItemNo.Text = dgw.Item(1, i).Value
        Me.txtitemDescription.Text = dgw.Item(2, i).Value
        Me.txtQuantityIssued.Text = dgw.Item(3, i).Value
        Me.txtDateIssued.Text = dgw.Item(4, i).Value
        Me.txtDeliveryNo2.Text = dgw.Item(0, i).Value
        Me.txtIntialQty.Text = dgw.Item(3, i).Value
        dgw.Rows.Remove(dgw.CurrentRow)
    End Sub

    Private Sub txtqtyreversed_TextChanged(sender As Object, e As EventArgs) Handles txtqtyreversed.TextChanged
        If Val(txtqtyreversed.Text) > Val(txtQuantityIssued.Text) Then
            MessageBox.Show("Quantity to reverse cannot be greater than Quantity Issued", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtqtyreversed.Clear()
            Exit Sub
        End If
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
        dgw.Rows.Clear()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Reset()
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
            Query = "UPDATE product SET StocksOnHand = StocksOnHand - '" & txtIntialQty.Text & "' WHERE ProductNo = '" & txtItemNo.Text & "'"
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

    Private Sub PostChangesToolStripButton5_Click(sender As Object, e As EventArgs) Handles PostChangesToolStripButton5.Click
        If txtItemNo.Text = "" Then
            MessageBox.Show("Please select a record the table below to continue", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtqtyreversed.Text = Nothing Then
            MessageBox.Show("Enter Quantity to Update", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If chkSubtract.Checked = False Then
            MessageBox.Show("Please Tick the subtract check box to continue", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'UpdateproductQtyBeforeReverse()
        updatedeliverydetails()
        UpdateDeliveryItemsTable()
        UpdateproductQty()
        AddReversaleDetails()
        Reset()
    End Sub

    Private Sub frmUpdateDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chkSubtract_CheckedChanged(sender As Object, e As EventArgs) Handles chkSubtract.CheckedChanged
        If txtqtyreversed.Text = Nothing Then
            MessageBox.Show("Enter Quantity to Update", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If chkSubtract.Checked = True Then
            Dim FinalQty As Decimal
            Dim QtyIssue As Decimal
            Dim QtyReverse As Decimal
            QtyIssue = txtQuantityIssued.Text
            QtyReverse = txtqtyreversed.Text
            FinalQty = QtyIssue - QtyReverse
            txtQuantityIssued.Text = FinalQty
            txtItemCount.Text = Val(txtItemCount.Text) - QtyReverse
            chkSubtract.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNRst.Click
        txtQuantityIssued.Text = txtIntialQty.Text
        txtItemCount.Text = txtItemcnt.Text
        chkSubtract.Checked = False
        chkSubtract.Enabled = True
        txtqtyreversed.Clear()
    End Sub
End Class