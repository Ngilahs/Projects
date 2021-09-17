Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLoadSupplier
    Dim y As Integer
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String

    Private Sub frmLoadSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSupplier()
    End Sub
    Private Sub frmLoadSupplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub LoadSupplier()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Supplier_ID, Supp_Name, Supp_Contact FROM suppliers WHERE Supp_Name LIKE '" & txtCatName.Text & "%' ORDER BY Supp_Name "
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("Supplier_ID").ToString)
                x.SubItems.Add(dr("Supp_Name"))
                x.SubItems.Add(dr("Supp_Contact"))

                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        frmListofSuppliers.txtSupplName.Text = ListView1.FocusedItem.SubItems(1).Text
        frmListofSuppliers.txtSupplName.Tag = ListView1.FocusedItem.Text
        frmAddUpdateProduct.txtPreSupplier.Text = ListView1.FocusedItem.SubItems(1).Text
        frmAddUpdateProduct.lblPrefSupplierID.Text = ListView1.FocusedItem.SubItems(0).Text
        frmPOS.txtSupplNameRS.Text = ListView1.FocusedItem.SubItems(1).Text
        frmPOS.txtSupplierID.Text = ListView1.FocusedItem.SubItems(0).Text
        frmStockIn.txtSupplierName.Text = ListView1.FocusedItem.SubItems(1).Text
        frmStockIn.txtSuupID.Text = ListView1.FocusedItem.SubItems(0).Text
        frmUpdateReceipts.txtsupplier.Text = ListView1.FocusedItem.SubItems(1).Text
        frmUpdateReceipts.txtSupplierId.Text = ListView1.FocusedItem.SubItems(0).Text
        frmReceiveTransformer.txtSupplNameRS.Text = ListView1.FocusedItem.SubItems(1).Text
        frmReceiveTransformer.txtSupplierID.Text = ListView1.FocusedItem.SubItems(0).Text
        Me.Close()
    End Sub
End Class