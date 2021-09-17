Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmIssueTools
    Private Sub PopulateTools()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'tbl_tools(Tool_Description, CategoryID, Available_Qty, UnitofIssue
        'Try
        MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ToolNo, Tool_Description from tbl_tools ORDER BY Tool_Description"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboSearchTools.Items.Clear()
            Do While dr.Read = True
                cboSearchTools.Items.Add(dr("Tool_Description"))
            'cboSearchTools.Text = "Description"
        Loop
            MysqlConn.Close()
        'Catch ex As MySqlException
        'MessageBox.Show(ex.Message)
        'Finally
        MysqlConn.Dispose()
        'End Try
    End Sub
    Private Sub PopulateEmployees()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Employee_ID, Employee_Name from tbl_employees ORDER BY Employee_Name"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboSearchTools.Items.Clear()
            Do While dr.Read = True
                cboEmployeeName.Items.Add(dr("Employee_Name"))
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub PopulateEmployeesNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Employee_ID, Employee_Name from tbl_employees where Employee_Name = '" & cboEmployeeName.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboSearchTools.Items.Clear()
            Do While dr.Read = True
                txtEmployeeNo.Text = dr("Employee_ID")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub PopulateToolNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ToolNo, Tool_Description, Available_Qty, UnitofIssue from tbl_tools where Tool_Description = '" & cboSearchTools.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtToolNo.Text = dr("ToolNo")
                txtAvailableQty.Text = dr("Available_Qty")
                txtUnitofIssue.Text = dr("UnitofIssue")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub frmIssueTools_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateEmployees()
        lbldate.Text = Format(Now, "MM/dd/yyyy")
        PopulateTools()
    End Sub

    Private Sub cboSearchTools_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchTools.SelectedIndexChanged
        PopulateToolNo()
    End Sub
    Private Sub GetReceiveID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Issue_tools_details_No FROM tbl_issue_tools_details ORDER BY Issue_tools_details_No DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblIssuanceNo.Text = dr("Issue_tools_details_No") + 1
            Else
                lblIssuanceNo.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub SaveIssuedTools()
        For Each r As DataGridViewRow In dgw.Rows
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
             MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Insert into tbl_issue_tools (Issue_Tools_No, Tool_No, QtyIssued, Date_Issued) VALUES (" & lblIssuanceNo.Text & ", '" & r.Cells(0).Value & "', '" & r.Cells(2).Value & "', '" & lbldate.Text & "')"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Next
        UpdateQuantity()
        MsgBox("Tools successfully added.", MsgBoxStyle.Information, "Add Tools")
    End Sub
    Private Sub SaveReceivedDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Insert into tbl_issue_tools_details (Issue_tools_details_No, Issued_To, Issued_By, Issue_Date) VALUES ('" & lblIssuanceNo.Text & "','" & txtEmployeeNo.Text & "', '" & FrmMain.tsslUser.Text & "', '" & lbldate.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub UpdateQuantity()
        'Update Quantity
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        For i = 0 To dgw.Rows.Count - 1
            Try
                MysqlConn.Open()
                Dim Querys As String
                Querys = "UPDATE tbl_tools SET Available_Qty = Available_Qty - '" & dgw.Rows(i).Cells(2).Value & "' WHERE ToolNo = '" & dgw.Rows(i).Cells(0).Value & "'"
                cmd = New MySqlCommand(Querys, MysqlConn)
                dr = cmd.ExecuteReader
                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Next
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblIssuanceNo.Text, TimeOfDay, "Received New Tools")
    End Sub
    Private Sub AddItemstoGrid()
        If Trim(cboSearchTools.Text) = "" Or txtToolNo.Text = "" Or txtQtytoIssue.Text = "" Or txtEmployeeNo.Text = "" Or Trim(cboEmployeeName.Text) = "" Then
            MsgBox("Please Fill all TextBoxes")
        Else
            Dim rnum As Integer = dgw.Rows.Add()
            dgw.Rows.Item(rnum).Cells(0).Value = txtToolNo.Text
            dgw.Rows.Item(rnum).Cells(1).Value = cboSearchTools.Text
            dgw.Rows.Item(rnum).Cells(2).Value = txtQtytoIssue.Text
            dgw.Rows.Item(rnum).Cells(3).Value = txtQtyBal.Text
            dgw.Rows.Item(rnum).Cells(4).Value = txtUnitofIssue.Text

        End If
    End Sub
    Public Sub dropDuplicateRows()
        For intI As Integer = dgw.Rows.Count - 1 To 0 Step -1
            For intJ As Integer = dgw.Rows.Count - 1 To intI + 1 Step -1
                If dgw.Rows(intI).Cells(0).Value = dgw.Rows(intJ).Cells(0).Value Then
                    dgw.Rows(intI).Cells(2).Value = Val(dgw.Rows(intI).Cells(2).Value) + Val(txtQtytoIssue.Text)
                    dgw.Rows.RemoveAt(intJ)
                End If
            Next intJ
        Next intI
    End Sub

    Private Sub btnAddtoGrid_Click(sender As Object, e As EventArgs) Handles btnAddtoGrid.Click
        AddItemstoGrid()
        dropDuplicateRows()
        cboEmployeeName.Enabled = False
        Clear()

    End Sub
    Private Sub Clear()
        txtToolNo.Text = ""
        txtQtytoIssue.Text = ""
        txtQtyBal.Text = ""
        txtUnitofIssue.Text = ""
        PopulateEmployees()
        PopulateTools()
    End Sub
    Private Sub CalculateTotQty()
        txtQtyBal.Text = Val(txtAvailableQty.Text) - Val(txtQtytoIssue.Text)
    End Sub
    Private Sub txtQtyIn_TextChanged(sender As Object, e As EventArgs) Handles txtQtytoIssue.TextChanged
        If Val(txtQtytoIssue.Text) > Val(txtAvailableQty.Text) Then
            MsgBox("Quantity to Issue cannot be greater than available stock!", MsgBoxStyle.Exclamation, "Issue Tools!")
            txtQtytoIssue.Clear()
            Exit Sub
        End If
        CalculateTotQty()
    End Sub

    Private Sub PSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles PSaveToolStripButton5.Click
        GetReceiveID()
        SaveReceivedDetails()
        SaveIssuedTools()
        DeleteEmptyRowinissuetools()
        dgw.Rows.Clear()
        cboEmployeeName.Enabled = True
        txtEmployeeNo.Text = ""

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles VoidToolStripButton.Click
        If dgw.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please enter Item ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try

            If MessageBox.Show("Are You Sure You want to Void the tool?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                dgw.Rows.Remove(dgw.CurrentRow)
            End If
        Catch ex As Exception
            MessageBox.Show("Please Select Item to Void", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
        End Try

    End Sub
    Private Sub MyTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtytoIssue.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DeleteEmptyRowinissuetools()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from tbl_issue_tools where Tool_No = '';"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub cboEmployeeName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmployeeName.SelectedIndexChanged
        PopulateEmployeesNo()
    End Sub
End Class