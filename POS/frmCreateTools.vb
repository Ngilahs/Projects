Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmCreateTools
    Dim y As Integer
    Private Sub AddTools()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            txtStocksOnHand.Text = "0"
            If txtDescription.Text = "" Or txtDescription.Text = "" Then
                MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Add New Tool!")
                Exit Sub
            Else
                MysqlConn.Open()
                Dim Query As String
                Query = "INSERT INTO tbl_tools(Tool_Description, CategoryID, Available_Qty, UnitofIssue) VALUES ('" & txtDescription.Text & "', '" & LBLCateID.Text & "', '" & txtqty.Text & "', '" & txtUnitofIssue.Text & "')"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MsgBox("Tool successfully added.", MsgBoxStyle.Information, "Add Tool")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtDescription.Text, TimeOfDay, "Added New Tool")
    End Sub
    Private Sub UpdateTool()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            If txtDescription.Text = "" Or txtCategory.Text = "" Then
                MsgBox("Please Select Record to Update!", MsgBoxStyle.Exclamation, "Update New Tool!")
            Else
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE tbl_tools SET Tool_Description = '" & txtDescription.Text & "', Available_Qty = '" & txtqty.Text & "', CategoryID ='" & LBLCateID.Text & "', UnitofIssue = '" & txtUnitofIssue.Text & "' WHERE ToolNo = '" & lblToolNo.Text & "'"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MsgBox("Tool successfully Updated.", MsgBoxStyle.Information, "Update Tool")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtDescription.Text, TimeOfDay, "Updated Item")
        'AllClearFields()
        txtDescription.Focus()
    End Sub

    Private Sub txttooldescription_TextChanged(sender As Object, e As EventArgs) Handles txttooldescription.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            'Tool_Description, CategoryID, Available_Qty, UnitofIssue
            Query = "SELECT T.ToolNo, T.Tool_Description, T.CategoryID, T.Available_Qty, UnitofIssue, C.CategoryNo, C.CategoryName from tbl_tools T INNER JOIN Category C on (C.CategoryNo = T.CategoryID) where T.Tool_Description LIKE '%" & txttooldescription.Text & "%' ORDER BY Description DESC LIMIT 200"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("ToolNo"), dr("Tool_Description"), dr("CategoryName"), dr("CategoryID"), dr("Available_Qty"), dr("UnitofIssue"))
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
        PUpdateToolStripButton3.Enabled = True
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.lblToolNo.Text = dgw.Item(0, i).Value
        Me.txtDescription.Text = dgw.Item(1, i).Value
        Me.txtCategory.Text = dgw.Item(2, i).Value
        Me.LBLCateID.Text = dgw.Item(3, i).Value
        Me.txtqty.Text = dgw.Item(4, i).Value
        Me.txtUnitofIssue.Text = dgw.Item(5, i).Value
        PSaveToolStripButton5.Enabled = False
        txtqty.Enabled = False
        txttooldescription.Text = ""
        dgw.Rows.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmLoadCategory.ShowDialog()
    End Sub

    Private Sub PSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles PSaveToolStripButton5.Click
        AddTools()
        ClearFields()
    End Sub

    Private Sub PUpdateToolStripButton3_Click(sender As Object, e As EventArgs) Handles PUpdateToolStripButton3.Click
        UpdateTool()
        ClearFields()
        PSaveToolStripButton5.Enabled = True
        PUpdateToolStripButton3.Enabled = False
    End Sub
    Private Sub ClearFields()
        lblToolNo.Text = ""
        txtDescription.Text = ""
        txtCategory.Text = ""
        LBLCateID.Text = ""
        txtqty.Text = ""
        txtUnitofIssue.Text = ""
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        ClearFields()
    End Sub

    Private Sub frmCreateTools_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PUpdateToolStripButton3.Enabled = False
        txtqty.Enabled = False
        txtqty.Text = 0
    End Sub
End Class