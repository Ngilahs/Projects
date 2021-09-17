Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmAddUpdateProduct

    Dim y As Integer
    Private Property txtvatcode As Object

    Private Sub GetProductNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ProductNo FROM Product ORDER BY ProductNo DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblProductNo.Text = dr("ProductNo") + 1
            Else
                lblProductNo.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub AddProducts()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            txtStocksOnHand.Text = "0"
            If txtDescription.Text = "" Or txtReorderLevel.Text = "" Then
                MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Add New Item!")
                Exit Sub
            Else
                MysqlConn.Open()
                Dim Query As String
                Query = "INSERT INTO Product(ProductNo, Description, StocksOnHand, ReorderLevel, CateID, SubCateID, PrefSupplier, QtyperUoM, UnitofIssue) VALUES ('" & lblProductNo.Text & "', '" & txtDescription.Text & "', '" & txtqty.Text & "', '" & txtReorderLevel.Text & "','" & LBLCateID.Text & "', '" & LBLSubCateID.Text & "', '" & lblPrefSupplierID.Text & "', '" & txtQtyperUoM.Text & "', '" & txtUnitofIssue.Text & "')"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MsgBox("Item successfully added.", MsgBoxStyle.Information, "Add Item")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table  txtQtyperUoM, 
        Audit_Trail(FrmMain.tsslUser.Text, lblProductNo.Text, TimeOfDay, "Added New Item")
        AllClearFields()
        lblProductNo.Focus()
    End Sub
    Private Sub UpdateProduct()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            If txtDescription.Text = "" Or txtReorderLevel.Text = "" Or lblProductNo.Text = "" Or txtCategory.Text = "" Then
                MsgBox("Please Select Record to Update!", MsgBoxStyle.Exclamation, "Update New Item!")
            Else
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE Product SET Description = '" & txtDescription.Text & "', StocksOnHand = '" & txtqty.Text & "', ReorderLevel = '" & txtReorderLevel.Text & "', CateID ='" & LBLCateID.Text & "', SubCateID = '" & LBLSubCateID.Text & "', PrefSupplier = '" & lblPrefSupplierID.Text & "', UnitofIssue = '" & txtUnitofIssue.Text & "', QtyperUoM = '" & txtQtyperUoM.Text & "' WHERE ProductNo = '" & lblProductNo.Text & "'"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MsgBox("Item successfully Updated.", MsgBoxStyle.Information, "Update Item")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblProductNo.Text, TimeOfDay, "Updated Item")
        AllClearFields()
        txtDescription.Focus()
    End Sub
    Private Sub AllClearFields()
        lblProductNo.Text = ""
        txtDescription.Text = ""
        txtCategory.Text = ""
        txtqty.Text = "0"
        txtReorderLevel.Text = ""
        'cmbVAT.Text = ""
        txtsubcategory.Text = ""
        txtPreSupplier.Text = ""
        lblPrefSupplierID.Text = ""
        txtUnitofIssue.Text = ""
        txtItemNo.Clear()
        txtpdes.Clear()
        dgw.Rows.Clear()
    End Sub
    Private Sub ClearFields()
        'lblProductNo.Text = ""
        txtDescription.Text = ""
        txtCategory.Text = ""
        txtqty.Text = "0"
        txtReorderLevel.Text = ""
        txtsubcategory.Text = ""
        'cmbVAT.Text = ""
        dgw.Rows.Clear()
    End Sub
    Private Sub txtQtyperUoM_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtyperUoM.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmAddUpdateProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearFields()
        'GetProductNo()
        txtqty.Text = "0"
        LBLCateID.Text = "1"
        LBLSubCateID.Text = "1"
        txtCategory.Text = "Any"
        txtsubcategory.Text = "Any"
        PUpdateToolStripButton3.Enabled = False
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmLoadCategory.ShowDialog()
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PSaveToolStripButton5.Click
        GetProductNo()
        AddProducts()
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        'GetProductNo()
        txtDescription.Text = ""
        txtCategory.Text = ""
        txtReorderLevel.Text = ""
        'cmbVAT.Text = "A"
        txtqty.Text = "0"
    End Sub
    Private Sub txtbcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemNo.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Dim Units As Decimal
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT P.ProductNo, P.Description, P.StocksOnHand, P.ReorderLevel, P.QtyperUoM, P.CateID, P.SubCateID, P.PrefSupplier, P.UnitofIssue, C.CategoryNo, C.CategoryName, S.SubcategoryID, S.SubcategoryName, SP.Supplier_ID, SP.Supp_Name from Product P INNER JOIN Category C on (C.CategoryNo = P.CateID) INNER JOIN subcategory S on (S.SubcategoryID = P.SubCateID) INNER JOIN suppliers SP on (P.PrefSupplier = SP.Supplier_ID)  where P.ProductNo LIKE '%" & txtpdes.Text & "%' ORDER BY Description DESC LIMIT 200"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("ProductNo"), dr("Description"), dr("QtyperUoM"), dr("StocksOnHand") / dr("QtyperUoM"), dr("StocksOnHand"), dr("ReorderLevel"), dr("CateID"), dr("CategoryName"), dr("SubCateID"), dr("SubcategoryName"), dr("UnitofIssue"), dr("PrefSupplier"), dr("Supp_Name"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.lblProductNo.Text = dgw.Item(0, i).Value
        Me.txtDescription.Text = dgw.Item(1, i).Value
        Me.txtQtyperUoM.Text = dgw.Item(2, i).Value
        Me.txtUnits.Text = dgw.Item(3, i).Value
        Me.txtqty.Text = dgw.Item(4, i).Value
        Me.txtReorderLevel.Text = dgw.Item(5, i).Value
        Me.LBLCateID.Text = dgw.Item(6, i).Value
        Me.txtCategory.Text = dgw.Item(7, i).Value
        Me.LBLSubCateID.Text = dgw.Item(8, i).Value
        Me.txtsubcategory.Text = dgw.Item(9, i).Value
        Me.txtUnitofIssue.Text = dgw.Item(10, i).Value
        Me.lblPrefSupplierID.Text = dgw.Item(11, i).Value
        Me.txtPreSupplier.Text = dgw.Item(12, i).Value
        PSaveToolStripButton5.Enabled = False
        PUpdateToolStripButton3.Enabled = True
        dgw.Rows.Clear()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PUpdateToolStripButton3.Click
        txtItemNo.Text = ""
        txtpdes.Text = ""
        dgw.Rows.Clear()
        UpdateProduct()
        Me.Close()
    End Sub

    Private Sub txtpdes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpdes.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT P.ProductNo, P.Description, P.StocksOnHand, P.QtyperUoM, P.ReorderLevel, P.CateID, P.SubCateID, P.PrefSupplier, P.UnitofIssue, C.CategoryNo, C.CategoryName, S.SubcategoryID, S.SubcategoryName, SP.Supplier_ID, SP.Supp_Name from Product P INNER JOIN Category C on (C.CategoryNo = P.CateID) INNER JOIN subcategory S on (S.SubcategoryID = P.SubCateID) INNER JOIN suppliers SP on (P.PrefSupplier = SP.Supplier_ID)  where P.Description LIKE '%" & txtpdes.Text & "%' ORDER BY Description DESC LIMIT 200"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("ProductNo"), dr("Description"), dr("QtyperUoM"), dr("StocksOnHand") / dr("QtyperUoM"), dr("StocksOnHand"), dr("ReorderLevel"), dr("CateID"), dr("CategoryName"), dr("SubCateID"), dr("SubcategoryName"), dr("UnitofIssue"), dr("PrefSupplier"), dr("Supp_Name"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        dgw.Rows.Clear()
        AllClearFields()
        GetProductNo()
        PSaveToolStripButton5.Enabled = True
    End Sub

    Private Sub Btnsubcategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsubcategory.Click
        frmLoadSubcategory.ShowDialog()
    End Sub

    Private Sub BtnOpeningClosingStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmStockAdjustment.Show()
    End Sub

    Private Sub btnLCSExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = dgw.RowCount
            colsTotal = dgw.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dgw.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dgw.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.KeyUp
        'Check for duplicate entry of product Barcode
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
                .CommandText = "SELECT COUNT(*) FROM Product WHERE Description  = '" & txtDescription.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 And txtDescription.Text <> "NILLNULL" Then
                MsgBox("Material Already Exists!", MsgBoxStyle.Exclamation, "Add New Material!")
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BtnLoadSupplier_Click(sender As Object, e As EventArgs) Handles BtnLoadSupplier.Click
        frmLoadSupplier.ShowDialog()
    End Sub
    Private Sub MyTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtReorderLevel.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class