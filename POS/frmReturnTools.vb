Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmReturnTools
    Dim y As Integer
    Private Sub frmReturnTools_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub LoadToolIssuancedetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            'Query = "SELECT ID.Issue_tools_details_No, ID.Issued_To, ID.Issued_By, ID.Issue_Date FROM tbl_issue_tools_details ID INNER JOIN schemes S on (DD.SchemeId = S.SchemeNo) inner join county C on (DD.CountyId = C.County_No) inner join constituency CN on (CN.Constituency_No = DD.ConstituencyId) WHERE DD.DeliveryNo = '" & txtEnterIssuanceNo.Text & "'"
            Query = "SELECT TID.Issue_tools_details_No, TID.Issued_To, TID.Issued_By, TID.Issue_Date, TE.Employee_ID, TE.Employee_Name FROM tbl_issue_tools_details TID inner join tbl_employees TE on TID.Issued_To = TE.Employee_ID  WHERE Issue_tools_details_No = '" & txtEnterIssuanceNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                LblIssuanceNo.Text = dr("Issue_tools_details_No")
                txtIssuancedate.Text = dr("Issue_Date")
                txtUserName.Text = dr("Issued_By")
                txtIssuedto.Text = dr("Employee_Name")

            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadIssuedToolstoGrid()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            'Query = "SELECT ID.Issue_tools_details_No, ID.Issued_To, ID.Issued_By, ID.Issue_Date FROM tbl_issue_tools_details ID INNER JOIN schemes S on (DD.SchemeId = S.SchemeNo) inner join county C on (DD.CountyId = C.County_No) inner join constituency CN on (CN.Constituency_No = DD.ConstituencyId) WHERE DD.DeliveryNo = '" & txtEnterIssuanceNo.Text & "'"
            Query = "SELECT IT.Issue_Tools_No, IT.Tool_No, IT.QtyIssued, ID.Issue_tools_details_No, ID.Issued_To, ID.Issued_By, ID.Issue_Date, T.ToolNo, T.Tool_Description FROM tbl_issue_tools_details ID Inner Join tbl_issue_tools IT On ID.Issue_tools_details_No = IT.Issue_Tools_No Inner Join tbl_tools T on T.ToolNo = IT.Tool_No WHERE Issue_tools_details_No = '" & txtEnterIssuanceNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("Issue_Tools_No"), dr("Tool_No"), dr("Tool_Description"), dr("QtyIssued"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub txtEnterIssuanceNo_TextChanged(sender As Object, e As EventArgs) Handles txtEnterIssuanceNo.TextChanged
        LoadToolIssuancedetails()
        LoadIssuedToolstoGrid()
    End Sub
    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.txttoolNo.Text = dgw.Item(1, i).Value
        Me.txtitemDescription.Text = dgw.Item(2, i).Value
        Me.txtQuantityIssued.Text = dgw.Item(3, i).Value
        Me.txtIssuanceNo2.Text = dgw.Item(0, i).Value
        dgw.Rows.Remove(dgw.CurrentRow)
    End Sub

    Private Sub RetrunSaleToolStripButton2_Click(sender As Object, e As EventArgs) Handles RetrunSaleToolStripButton2.Click
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
        Subtot = QtyIssued - QtyReversed
        RemQty = ItemCount - QtyReversed
        txtQuantityIssued.Text = Subtot
        txtqtyreversed.Enabled = False
        RetrunSaleToolStripButton2.Enabled = False
    End Sub

    Private Sub txtqtyreversed_TextChanged(sender As Object, e As EventArgs) Handles txtqtyreversed.TextChanged
        If Val(txtqtyreversed.Text) > Val(txtQuantityIssued.Text) Then
            MsgBox("Return Qty cannot be greater than issued Qty!", MsgBoxStyle.Exclamation, "Return Materials!")
            txtqtyreversed.Clear()
            Exit Sub
        End If
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
            Query = "INSERT INTO returntools (IssuanceNo,ToolNo, ReverseDate, QtyReturned, AuthorizedBy) Values ('" & txtIssuanceNo2.Text & "', '" & txttoolNo.Text & "', '" & Format(Now, "MM/dd/yyyy") & "', '" & txtqtyreversed.Text & "', '" & FrmMain.tsslUser.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Tool/s Issued successfully Returned.", MsgBoxStyle.Information, "Retrun Tools to Store")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'RemoveEmptyReverseRowNo()
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
            Query = "UPDATE tbl_issue_tools SET QtyIssued = '" & txtQuantityIssued.Text & "' WHERE Issue_Tools_No = '" & txtIssuanceNo2.Text & "' AND Tool_No = '" & txttoolNo.Text & "'"
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
            Query = "UPDATE tbl_tools SET Available_Qty = Available_Qty + '" & txtqtyreversed.Text & "' WHERE ToolNo = '" & txttoolNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub ClearAll()
        LblIssuanceNo.Text = ""
        txtIssuancedate.Text = ""
        txtUserName.Text = ""
        txtIssuedto.Text = ""
        Me.txttoolNo.Text = ""
        Me.txtitemDescription.Text = ""
        Me.txtQuantityIssued.Text = ""
        Me.txtIssuanceNo2.Text = ""
        dgw.Rows.Clear()
        Me.txtqtyreversed.Text = ""
        Me.txtEnterIssuanceNo.Text = ""
    End Sub
    Private Sub PostChangesToolStripButton5_Click(sender As Object, e As EventArgs) Handles PostChangesToolStripButton5.Click
        UpdateDeliveryItemsTable()
        UpdateproductQty()
        AddReversaleDetails()
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtIssuanceNo2.Text, TimeOfDay, "Returned Tool to store")
        ClearAll()
    End Sub
    Private Sub MyTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtqtyreversed.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class