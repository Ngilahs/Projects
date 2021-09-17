Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmReceiveTools
    Private Sub PopulateTools()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'tbl_tools(Tool_Description, CategoryID, Available_Qty, UnitofIssue
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ToolNo, Tool_Description from tbl_tools ORDER BY Tool_Description"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cmdSearchtools.Items.Clear()
            Do While dr.Read = True
                cmdSearchtools.Items.Add(dr("Tool_Description"))
                cmdSearchtools.Text = "Description"
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
        'tbl_tools(Tool_Description, CategoryID, Available_Qty, UnitofIssue
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ToolNo, Tool_Description, Available_Qty, UnitofIssue from tbl_tools where Tool_Description = '" & cmdSearchtools.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txttoolno.Text = dr("ToolNo")
                txtQtyonHand.Text = dr("Available_Qty")
                txtunitofissue.Text = dr("UnitofIssue")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub cmdSearchtools_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdSearchtools.SelectedIndexChanged
        PopulateToolNo()
    End Sub

    Private Sub frmReceiveTools_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTools()
        lbldate.Text = Format(Now, "MM/dd/yyyy")
        GetReceiveID()
    End Sub
    Private Sub CalculateTotQty()
        txttotalqty.Text = Val(txtQtyonHand.Text) + Val(txtQtyIn.Text)
    End Sub
    Private Sub txtQtyIn_TextChanged(sender As Object, e As EventArgs) Handles txtQtyIn.TextChanged
        CalculateTotQty()
    End Sub
    Private Sub AddItemstoGrid()
        If Trim(cmdSearchtools.Text) = "" Or txttoolno.Text = "" Or txtQtyIn.Text = "" Or txtDocNo.Text = "" Then
            MsgBox("Please Fill all TextBoxes")
        Else
            Dim rnum As Integer = dgw.Rows.Add()
            dgw.Rows.Item(rnum).Cells(0).Value = txttoolno.Text
            dgw.Rows.Item(rnum).Cells(1).Value = cmdSearchtools.Text
            dgw.Rows.Item(rnum).Cells(2).Value = txtQtyIn.Text
            dgw.Rows.Item(rnum).Cells(3).Value = txttotalqty.Text
            dgw.Rows.Item(rnum).Cells(4).Value = txtunitofissue.Text
            dgw.Rows.Item(rnum).Cells(5).Value = txtDocNo.Text

        End If

    End Sub
    Public Sub dropDuplicateRows()
        For intI As Integer = dgw.Rows.Count - 1 To 0 Step -1
            For intJ As Integer = dgw.Rows.Count - 1 To intI + 1 Step -1
                If dgw.Rows(intI).Cells(0).Value = dgw.Rows(intJ).Cells(0).Value Then
                    dgw.Rows(intI).Cells(2).Value = Val(dgw.Rows(intI).Cells(2).Value) + Val(txtQtyIn.Text)
                    dgw.Rows.RemoveAt(intJ)
                End If
            Next intJ
        Next intI
    End Sub
    Private Sub Clear()
        txttoolno.Text = ""
        cmdSearchtools.Text = "Description"
        txtQtyIn.Text = ""
        txttotalqty.Text = ""
        txtunitofissue.Text = ""
        txtDocNo.Enabled = False
    End Sub
    Private Sub btnAddtoGrid_Click(sender As Object, e As EventArgs) Handles btnAddtoGrid.Click
        AddItemstoGrid()
        dropDuplicateRows()
        Clear()
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
            Query = "SELECT Receive_no FROM tbl_receivetoolsdetails ORDER BY Receive_no DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblReceiveNo.Text = dr("Receive_no") + 1
            Else
                lblReceiveNo.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub SaveReceivedTools()
        For Each r As DataGridViewRow In dgw.Rows
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
             MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            Try
                'Receive_id, " & lblReceiveNo.Text & ",
                MysqlConn.Open()
                Dim Query As String
                Query = "Insert into tbl_receive_tools (Receive_id, Tool_No, Qty_Received, Date_Received, Document_No) VALUES (" & lblReceiveNo.Text & ", '" & r.Cells(0).Value & "', '" & r.Cells(2).Value & "', '" & lbldate.Text & "', '" & txtDocNo.Text & "')"
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
            'Receive_no, '" & lblReceiveNo.Text & "',
            MysqlConn.Open()
            Dim Query As String
            Query = "Insert into tbl_receivetoolsdetails (Receive_no, DateReceived, Receivedby, Document_No) VALUES ('" & lblReceiveNo.Text & "', '" & lbldate.Text & "', '" & FrmMain.tsslUser.Text & "', '" & txtDocNo.Text & "')"
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
                Querys = "UPDATE tbl_tools SET Available_Qty = Available_Qty + '" & dgw.Rows(i).Cells(2).Value & "' WHERE ToolNo = '" & dgw.Rows(i).Cells(0).Value & "'"
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
        Audit_Trail(FrmMain.tsslUser.Text, txttoolno.Text, TimeOfDay, "Received New Tools")
    End Sub

    Private Sub PSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles PSaveToolStripButton5.Click
        GetReceiveID()
        SaveReceivedDetails()
        SaveReceivedTools()
        DeleteEmptyRowinreceivetools()
        Clear()
        dgw.Rows.Clear()
        txtQtyonHand.Text = ""
        txtDocNo.Text = ""
        txtDocNo.Enabled = True


    End Sub
    Private Sub MyTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtyIn.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub DeleteEmptyRowinreceivetools()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from tbl_receive_tools where Tool_No = '';"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles VoidToolStripButton2.Click
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

    Private Sub txtDocumentNo_KeyUp(sender As Object, e As EventArgs) Handles txtDocNo.KeyUp
        'Check for duplicate entry of Document No
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
                .CommandText = "SELECT COUNT(*) FROM tbl_receivetoolsdetails WHERE Document_No  = '" & txtDocNo.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 And txtDocNo.Text <> "NILLNULL" Then
                MsgBox("Document No has been added!", MsgBoxStyle.Exclamation, "Add New Tool & Equipment!")
                txtDocNo.Clear()
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class