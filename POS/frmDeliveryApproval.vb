Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmDeliveryApproval
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
            Query = "SELECT DD.DeliveryNo, DD.IssueDate, DD.ItemCount, DD.SchemeId, DD.CountyId, DD.ConstituencyId, DD.UserName, DD.TillNo, DD.SessIDNo, DD.TimeX, S.Scheme_Name, C.County_Name, CN.constituency_Name FROM delivery_details DD inner join schemes S on (DD.SchemeId = S.SchemeNo) inner join county C on (DD.CountyId = C.County_No) inner join constituency CN on (CN.Constituency_No = DD.ConstituencyId)"
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
                dgw.Rows.Add(dr("Delivery_No"), dr("Item_No"), dr("Description"), dr("Qty_Issued"), dr("Date_Issued"), dr("Issue_Time"), dr("StockInID"), dr("DocumentNo"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub LoadDeliveries()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT DD.DeliveryNo, DD.IssueDate, DD.ItemCount, DD.SchemeId, DD.CountyId, DD.ConstituencyId, DD.UserName, DD.TillNo, DD.SessIDNo, DD.TimeX, DD.Status, S.Scheme_Name, C.County_Name, CN.constituency_Name FROM delivery_details DD inner join schemes S on (DD.SchemeId = S.SchemeNo) inner join county C on (DD.CountyId = C.County_No) inner join constituency CN on (CN.Constituency_No = DD.ConstituencyId) Where DD.Status = '0' and DD.CancelStatus = '0'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("DeliveryNo").ToString)
                x.SubItems.Add(dr("Scheme_Name"))
                x.SubItems.Add(dr("IssueDate"))

                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmDeliveryApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApproveToolStripButton2.Enabled = False
        CancelDeliveryToolStripButton.Enabled = False
        LoadDeliveries()
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        'frmAddUpdateProduct.txtCategory.Text = ListView1.FocusedItem.SubItems(1).Text
        'frmAddUpdateProduct.LBLCateID.Text = ListView1.FocusedItem.SubItems(0).Text
        'frmAddUpdateProduct.txtCategory.Tag = ListView1.FocusedItem.Text
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select DD.DeliveryNo, DD.IssueDate, DD.ItemCount, DD.SchemeId, DD.CountyId, DD.ConstituencyId, DD.UserName, DD.TillNo, DD.SessIDNo, DD.TimeX, DD.Status, S.Scheme_Name, C.County_Name, CN.constituency_Name FROM delivery_details DD inner join schemes S on (DD.SchemeId = S.SchemeNo) inner join county C on (DD.CountyId = C.County_No) inner join constituency CN on (CN.Constituency_No = DD.ConstituencyId) WHERE DD.DeliveryNo = '" & ListView1.FocusedItem.SubItems(0).Text & "'"
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
    'Insert Delivery approval
    Private Sub InsertDeliveryApprovalDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO deliveryapproval (Delivery_No, ApprovalDate, Approved, ApprovedBy) Values ('" & LblDeliveryNo.Text & "', '" & Format(Now, "MM/dd/yyyy") & "', '" & chkApproveDelivery.CheckState & "', '" & FrmMain.tsslUser.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Delivery successfully Approved.", MsgBoxStyle.Information, "Approve Delivery")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    'Update Delivery details
    Private Sub updatedeliverydetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE delivery_details SET  Status = '" & chkApproveDelivery.CheckState & "', Approvedby = '" & FrmMain.tsslUser.Text & "'  WHERE DeliveryNo = '" & LblDeliveryNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ApproveToolStripButton2_Click(sender As Object, e As EventArgs) Handles ApproveToolStripButton2.Click
        If dgw.Rows(0).Cells(0).Value = Nothing Or LblDeliveryNo.Text = "" Then
            MessageBox.Show("Enter Delivery to Approve", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        InsertDeliveryApprovalDetails()
        updatedeliverydetails()
        ''Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, LblDeliveryNo.Text, TimeOfDay, "Approved Material Delivery")
        ResetForm()
        frmDeliveryApproval_Load(e, e)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles CancelDeliveryToolStripButton.Click
        If dgw.Rows(0).Cells(0).Value = Nothing Or LblDeliveryNo.Text = "" Then
            MessageBox.Show("Enter Delivery to Cancel", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        InsertDeliveryCancelDetails()
        updateCanceldeliverydetails()
        UpdateQuantityafterCancelDelivery()
        UpdateQuantityinStockInMaterialsafterCanceldelivery()
        ''Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, LblDeliveryNo.Text, TimeOfDay, "Cancelled Material Delivery")
        ResetForm()
        frmDeliveryApproval_Load(e, e)
    End Sub
    'Insert Cancel Delivery
    Private Sub InsertDeliveryCancelDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO deliverycancel (Delivery_No, CancelDate, Cancelled, CancelledBy) Values ('" & LblDeliveryNo.Text & "', '" & Format(Now, "MM/dd/yyyy") & "', '" & chkCancelDelivery.CheckState & "', '" & FrmMain.tsslUser.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Delivery successfully Cancelled.", MsgBoxStyle.Information, "Cancel Delivery")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    'Update Delivery details
    Private Sub updateCanceldeliverydetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE delivery_details SET  CancelStatus = '" & chkCancelDelivery.CheckState & "', CancelledBy = '" & FrmMain.tsslUser.Text & "'  WHERE DeliveryNo = '" & LblDeliveryNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub UpdateQuantityafterCancelDelivery()
        'Update Quantity
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        For i = 0 To dgw.Rows.Count - 1
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE product SET StocksOnHand = StocksOnHand + '" & dgw.Rows(i).Cells(3).Value & "' WHERE ProductNo = '" & dgw.Rows(i).Cells(1).Value & "'"
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
    Private Sub UpdateQuantityinStockInMaterialsafterCanceldelivery()
        'Update Quantity   DI.Delivery_No, DI.Item_No
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        For i = 0 To dgw.Rows.Count - 1
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE delivery_items SET Qty_Issued = Qty_Issued - '" & dgw.Rows(i).Cells(3).Value & "' WHERE Item_No = '" & dgw.Rows(i).Cells(1).Value & "' AND Delivery_No = '" & dgw.Rows(i).Cells(0).Value & "'"
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

    Private Sub chkCancelDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles chkCancelDelivery.CheckStateChanged
        If chkCancelDelivery.Checked = True Then
            ApproveToolStripButton2.Enabled = False
            CancelDeliveryToolStripButton.Enabled = True
        End If
    End Sub

    Private Sub chkApproveDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles chkApproveDelivery.CheckStateChanged
        If chkApproveDelivery.Checked = True Then
            CancelDeliveryToolStripButton.Enabled = False
            ApproveToolStripButton2.Enabled = True
        End If
    End Sub

    Private Sub ResetForm()
        LblDeliveryNo.Text = ""
        txtIssuancedate.Text = ""
        txtSchemeName.Text = ""
        txtCountyName.Text = ""
        txtConstituencyName.Text = ""
        txtItemCount.Text = ""
        txtUserName.Text = ""
        txtTillNo.Text = ""
        txtIssuanceTime.Text = ""
        txtSchemeID.Text = ""
        txtConstituencyID.Text = ""
        txtCountyID.Text = ""
        dgw.Rows.Clear()
        CancelDeliveryToolStripButton.Enabled = False
        ApproveToolStripButton2.Enabled = False
        chkCancelDelivery.Enabled = True
        chkApproveDelivery.Enabled = True
        chkCancelDelivery.Checked = False
        chkApproveDelivery.Checked = False

    End Sub

    Private Sub btnAddMaterial_Click(sender As Object, e As EventArgs) Handles btnAddMaterial.Click
        If dgw.Rows(0).Cells(0).Value = Nothing Or LblDeliveryNo.Text = "" Then
            MessageBox.Show("Enter delivery to add delivery materials", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmUpdateMaterialDel.ShowDialog()
    End Sub
End Class