Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmBillingItems
    Dim y As Integer

    Private Sub GetBillingItemNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ItemNo FROM tbl_billingparameters ORDER BY ItemNo DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtItemmNo.Text = dr("ItemNo")
            Else
                txtItemmNo.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub AddBilling()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            If txtItemDescription.Text = "" Then
                MessageBox.Show("Please select Item Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtItemDescription.Focus()
                Return
            End If
            If txtItemUnitofIssue.Text = "" Then
                MessageBox.Show("Please enter UoM", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtItemUnitofIssue.Focus()
                Return
            End If
            If txtUnits.Text = "" Then
                MessageBox.Show("Please enter Unit Rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtUnits.Focus()
                Return
            End If
            MysqlConn.Open()
            Dim Query As String
            'ItemNo, Description, UoM, UnitRate, DateCreated
            Query = "INSERT INTO tbl_billingparameters(Description, UoM, UnitRate, DateCreated, categoryID, subcatID) VALUES ('" & txtItemDescription.Text & "', '" & txtItemUnitofIssue.Text & "', '" & txtUnits.Text & "', @d1, '" & txtCategoryID.Text & "', '" & subcatId.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", System.DateTime.Now)
            dr = cmd.ExecuteReader
            MsgBox("Billing Item successfully added.", MsgBoxStyle.Information, "Added Billing Item")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        GetBillingItemNo()
        'Update Audit Trail Table  txtQtyperUoM, 
        Audit_Trail(FrmMain.tsslUser.Text, txtItemNo.Text, TimeOfDay, "Added New Billing Item")
        Reset()
        txtItemDescription.Focus()
        Getdata()
    End Sub
    Private Sub UpdateBillingItem()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try

            If txtItemDescription.Text = "" Then
                MessageBox.Show("Please select Item Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtItemDescription.Focus()
                Return
            End If
            If txtItemNo.Text = "" Then
                MessageBox.Show("Please select Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtItemNo.Focus()
                Return
            End If
            If txtItemUnitofIssue.Text = "" Then
                MessageBox.Show("Please enter UoM", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtItemUnitofIssue.Focus()
                Return
            End If
            If txtUnits.Text = "" Then
                MessageBox.Show("Please enter Unit Rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtUnits.Focus()
                Return
            End If
            MysqlConn.Open()
                Dim Query As String
            'ItemNo, Description, UoM, UnitRate, DateCreated
            Query = "UPDATE tbl_billingparameters SET Description = '" & txtItemDescription.Text & "', UoM = '" & txtItemUnitofIssue.Text & "', UnitRate = '" & txtUnits.Text & "', categoryID = '" & txtCategoryID.Text & "', subcatID = '" & subcatId.Text & "' WHERE ItemNo = '" & txtItemNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MsgBox("Item successfully Updated.", MsgBoxStyle.Information, "Update Item")

                MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtItemNo.Text, TimeOfDay, "Updated Invoicing Item")
        Reset()
        txtItemDescription.Focus()
        Getdata()
    End Sub
    Private Sub Reset()
        txtItemDescription.Text = ""
        txtItemNo.Text = ""
        txtUnits.Text = ""
        txtItemUnitofIssue.Text = ""
        txtItemmNo.Text = ""
        txtCategoryID.Text = ""
        txtCategoryName.Text = ""
        txtSubcategory.Text = ""
        subcatId.Text = ""
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Reset()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AddBilling()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateBillingItem()
    End Sub
    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            txtItemNo.Text = dr.Cells(0).Value.ToString()
            txtItemDescription.Text = dr.Cells(1).Value.ToString()
            txtItemUnitofIssue.Text = dr.Cells(2).Value.ToString()
            txtUnits.Text = dr.Cells(3).Value.ToString()
            txtCategoryID.Text = dr.Cells(4).Value.ToString()
            txtCategoryName.Text = dr.Cells(5).Value.ToString()
            subcatId.Text = dr.Cells(6).Value.ToString()
            txtSubcategory.Text = dr.Cells(7).Value.ToString()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub Getdata()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
tbl_billingparameters.ItemNo,
tbl_billingparameters.Description,
tbl_billingparameters.UoM,
tbl_billingparameters.UnitRate,
tbl_billingparameters.DateCreated,
tbl_billingparameters.categoryID,
category.CategoryName,
tbl_billingparameters.subcatID,
subcategory.SubcategoryName
FROM
category
INNER JOIN tbl_billingparameters ON tbl_billingparameters.categoryID = category.CategoryNo
INNER JOIN subcategory ON tbl_billingparameters.subcatID = subcategory.SubcategoryID"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(5), dr(6), dr(7), dr(8))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmBillingItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getdata()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        frmLoadCategory.ShowDialog()
    End Sub

    Private Sub btnSubCat_Click(sender As Object, e As EventArgs) Handles btnSubCat.Click
        frmLoadSubcategory.ShowDialog()
    End Sub
End Class