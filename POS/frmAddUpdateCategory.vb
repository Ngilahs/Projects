Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class frmAddUpdateCategory
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Dim y As Integer
    Private Sub GetCategoryNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        ' MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT CategoryNo FROM Category ORDER BY CategoryNo DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblCategoryNo.Text = dr("CategoryNo") + 1
            Else
                lblCategoryNo.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadUpdateCategory()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM Category"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblCategoryNo.Text = dr("CategoryNo")
                txtCatName.Text = dr("CategoryName")
                txtDescription.Text = dr("Description")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub AddCategory()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtCatName.Text = "" Or lblCategoryNo.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCatName.Focus()
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO Category(CategoryName, Description) VALUES('" & txtCatName.Text & "', '" & txtDescription.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("New category successfully added.", MsgBoxStyle.Information, "Add Category")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblCategoryNo.Text, TimeOfDay, "Added New Category")
        AllCLearFields()
        GetCategoryNo()
    End Sub

    Private Sub UpdateCategory()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        ' MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtCatName.Text = "" Or lblCategoryNo.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCatName.Focus()
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE Category SET CategoryName= '" & txtCatName.Text & "', Description = '" & txtDescription.Text & "' WHERE CategoryNo = '" & lblCategoryNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Category successfully updated.", MsgBoxStyle.Information, "Update Category")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblCategoryNo.Text, TimeOfDay, "Updated Category Information")
        AllCLearFields()
        GetCategoryNo()

    End Sub
    Private Sub txtCatName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCatName.KeyUp
        'Check for duplicate entry of Category
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        ' MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            cmd = New MySqlCommand(Query, MysqlConn)
            With cmd
                .Connection = MysqlConn
                .CommandText = "SELECT COUNT(*) FROM Category WHERE CategoryName  = '" & txtCatName.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Product Category Already Exists!", MsgBoxStyle.Exclamation, "Add New Category!")
                txtCatName.Clear()
                txtCatName.Focus()
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub CLearFields()
        'lblCategoryNo.Text = ""
        txtCatName.Text = ""
        txtDescription.Text = ""
    End Sub
    Private Sub AllCLearFields()
        lblCategoryNo.Text = ""
        txtCatName.Text = ""
        txtDescription.Text = ""
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmAddUpdateCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CLearFields()
        GetCategoryNo()
        CSaveToolStripButton5.Enabled = True
        CUpdateToolStripButton3.Enabled = False

    End Sub
    Private Sub frmAddUpdateCategory_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        'rs.ResizeAllControls(Me)
        dgw.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right)
    End Sub
    Private Sub frmAddUpdateCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSaveToolStripButton5.Click
        AddCategory()
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        GetCategoryNo()
        CLearFields()
    End Sub

    Private Sub txtSearchByCategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchByCategory.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        ' MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT CategoryNo, CategoryName, Description from Category where CategoryName LIKE '" & txtSearchByCategory.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("CategoryNo"), dr("CategoryName"), dr("Description"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUpdateToolStripButton3.Click
        UpdateCategory()
        Me.Close()
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.lblCategoryNo.Text = dgw.Item(0, i).Value
        Me.txtCatName.Text = dgw.Item(1, i).Value
        Me.txtDescription.Text = dgw.Item(2, i).Value
        CSaveToolStripButton5.Enabled = False
        CUpdateToolStripButton3.Enabled = True
    End Sub

    Private Sub BTNRESET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRESET.Click
        dgw.Rows.Clear()
    End Sub
End Class
