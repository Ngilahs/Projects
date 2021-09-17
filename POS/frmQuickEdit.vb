Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmQuickEdit
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Private Sub loadproductdetails()
        Try
            sqL = "SELECT ProductNo, Description, Barcode, ProductCode, StocksOnHand, ReorderLevel, CategoryName, Selling_Price, VatCode, UnitPrice from Product where Barcode = '" & txtbcode.Text & "' OR ProductCode = '" & txtbcode.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtQBarcode.Text = dr("Barcode")
                TxtQBarcode2.Text = dr("ProductCode")
                txtQDescription.Text = dr("Description")
                txtQRetailPrice.Text = dr("Selling_Price")
                txtQUnitPrice.Text = dr("UnitPrice")
                txtQQty.Text = dr("StocksOnHand")
                LBLProdNo.Text = dr("ProductNo")
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub ClearAllFields()
        txtQBarcode.Text = ""
        TxtQBarcode2.Text = ""
        txtQDescription.Text = ""
        txtQRetailPrice.Text = ""
        txtQUnitPrice.Text = ""
        txtQQty.Text = ""
        txtbcode.Text = ""
        LBLProdNo.Text = ""
    End Sub
    Private Sub UpdateQuickProductEdit()
        Try
            'Update products Table
            sqL = "UPDATE Product SET ProductCode = '" & TxtQBarcode2.Text & "', Description = '" & txtQDescription.Text & "', Barcode = '" & txtQBarcode.Text & "', StocksOnHand = '" & txtQQty.Text.Replace(",", "") & "', Selling_Price = '" & txtQRetailPrice.Text & "', UnitPrice = '" & txtQUnitPrice.Text & "' WHERE ProductNo = '" & LBLProdNo.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            MsgBox("Product successfully Updated.", MsgBoxStyle.Information, "Update Product")
            ClearAllFields()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        txtbcode.Focus()
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtQBarcode.Text, TimeOfDay, "Updated Product")
    End Sub
    Public Sub LoadItemstoQuickEditfromgrid()

        For i = 0 To frmProductSearch.dtgpdcts.Rows.Count - 1
            Dim conr As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
            conr.Open()
            Try
                sqll = "SELECT ProductNo, Description, Barcode, ProductCode, StocksOnHand, ReorderLevel, CategoryName, Selling_Price, VatCode, UnitPrice from Product where Barcode = '" & frmProductSearch.dtgpdcts.CurrentRow.Cells(0).Value & "'"
                cmd = New MySqlCommand(sqll, conr)
                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    txtQBarcode.Text = dr("Barcode")
                    TxtQBarcode2.Text = dr("ProductCode")
                    txtQDescription.Text = dr("Description")
                    txtQRetailPrice.Text = dr("Selling_Price")
                    txtQUnitPrice.Text = dr("UnitPrice")
                    txtQQty.Text = dr("StocksOnHand")
                    LBLProdNo.Text = dr("ProductNo")
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Dispose()
                conn.Close()
            End Try
        Next
    End Sub
   
    Private Sub frmProductQuickEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub frmProductQuickEdit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmProductSearch.Close()
        'frmListofMPESASales.Close()
    End Sub
    Private Sub txtbcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbcode.TextChanged
        loadproductdetails()
    End Sub
    Private Sub BTNSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSave.Click
        UpdateQuickProductEdit()
        Me.Close()
        Call frmProductSearch.frmProductSearch_Load(sender, e)
        frmProductSearch.Close()
        'frmListofMPESASales.Close()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
        frmProductSearch.Close()
        'frmListofMPESASales.Close()
    End Sub
End Class