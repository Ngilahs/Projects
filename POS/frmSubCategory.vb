Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmSubCategory
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Dim y As Integer

    Private Sub GetCategoryNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SubcategoryID FROM subcategory ORDER BY SubcategoryID DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtsubcategoryID.Text = dr("SubcategoryID") + 1
            Else
                txtsubcategoryID.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub AddSubCategory()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If Len(Trim(txtSubCategory.Text)) = 0 Then
            MessageBox.Show("Please enter sub category", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSubCategory.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbCategory.Text)) = 0 Then
            MessageBox.Show("Please select category", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCategory.Focus()
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO subcategory (SubcategoryName, Category, CatgryID) VALUES ('" & txtSubCategory.Text & "', '" & cmbCategory.Text & "', '" & LBLCatID.Text & "' )"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("New subcategory successfully added.", MsgBoxStyle.Information, "Add subCategory")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtSubCategory.Text, TimeOfDay, "Added Material SubCategory")
        clearfields()
        GetCategoryNo()
    End Sub
    Private Sub populateVATCombo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT CategoryName, CategoryNo From category order by CategoryNo"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cmbCategory.Items.Clear()
            Do While dr.Read = True
                cmbCategory.Items.Add(dr("CategoryName"))
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub updatesubcategory()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If Len(Trim(txtSubCategory.Text)) = 0 Then
            MessageBox.Show("Please enter sub category", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSubCategory.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbCategory.Text)) = 0 Then
            MessageBox.Show("Please select category", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCategory.Focus()
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE subcategory SET SubcategoryName= '" & txtSubCategory.Text & "', Category = '" & cmbCategory.Text & "', CatgryID = '" & LBLCatID.Text & "' WHERE SubcategoryID = '" & txtsubcategoryID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Subcategory successfully updated.", MsgBoxStyle.Information, "Update SubCategory")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtSubCategory.Text, TimeOfDay, "Updated SubCategory Information")
        clearfields()
        GetCategoryNo()
        populateVATCombo()
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.txtsubcategoryID.Text = dgw.Item(0, i).Value
        Me.txtSubCategory.Text = dgw.Item(1, i).Value
        Me.cmbCategory.Text = dgw.Item(2, i).Value
        populateVATCombo()
        SCTSaveToolStripButton5.Enabled = False
        SCTUpdateToolStripButton3.Enabled = True
    End Sub
    Private Sub Loadsubcategory()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select  SubcategoryID, SubcategoryName, Category from subcategory where SubcategoryName = '" & txtSearchBySubCategory.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtsubcategoryID.Text = dr("SubcategoryID")
                txtSubCategory.Text = dr("SubcategoryName")
                cmbCategory.Text = dr("Category")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmSubCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetCategoryNo()
        populateVATCombo()
        SCTSaveToolStripButton5.Enabled = True
        SCTUpdateToolStripButton3.Enabled = False

    End Sub
    Private Sub frmSubCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub cmbCategory_Format(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListControlConvertEventArgs) Handles cmbCategory.Format
        If (e.DesiredType Is GetType(String)) Then
            e.Value = e.Value.ToString.Trim
        End If
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCTSaveToolStripButton5.Click
        AddSubCategory()
        clearfields()
        GetCategoryNo()
        Me.Close()
    End Sub
    Private Sub clearfields()
        txtsubcategoryID.Text = ""
        cmbCategory.Items.Clear()
        txtSubCategory.Text = ""
        LBLCatID.Text = ""
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        GetCategoryNo()
        'cmbCategory.Items.Clear()
        txtSubCategory.Text = ""
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCTUpdateToolStripButton3.Click
        updatesubcategory()
        clearfields()
        GetCategoryNo()
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Loadsubcategory()
    End Sub

    Private Sub txtSearchBySubCategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchBySubCategory.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SubcategoryID, SubcategoryName, Category from subcategory where SubcategoryName LIKE '" & txtSearchBySubCategory.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("SubcategoryID"), dr("SubcategoryName"), dr("Category"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub txtSearchByCategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchByCategory.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SubcategoryID, SubcategoryName, Category from subcategory where Category LIKE '" & txtSearchByCategory.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("SubcategoryID"), dr("SubcategoryName"), dr("Category"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub txtSubCategory_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubCategory.KeyUp
        'Check for duplicate entry of product sub category
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
                .CommandText = "SELECT COUNT(*) FROM subcategory WHERE SubcategoryName  = '" & txtSubCategory.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Product Sub-Category Already Exists!", MsgBoxStyle.Exclamation, "Add New Sub-Category!")
                txtSubCategory.Clear()
                txtSubCategory.Focus()
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clearfields()
        txtSearchByCategory.Text = ""
        txtSearchBySubCategory.Text = ""
        LBLCatID.Text = ""
        dgw.Rows.Clear()
        GetCategoryNo()
    End Sub
    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT CategoryNo, CategoryName FROM Category Where CategoryName  = '" & cmbCategory.Text & "' "
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            While (dr.Read)
                If dr IsNot Nothing Then
                    LBLCatID.Text = dr.Item("CategoryNo")
                End If
            End While
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

End Class
