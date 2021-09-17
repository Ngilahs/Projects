Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLoadSubcategory
    Dim y As Integer
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String

    Private Sub LoadSubCategory()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM subcategory WHERE SubcategoryName LIKE '" & txtCatName.Text & "%' ORDER BY SubcategoryName "
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            'aSubcategoryID, SubcategoryName, Category
            Do While dr.Read = True
                x = New ListViewItem(dr("SubcategoryID").ToString)
                x.SubItems.Add(dr("SubcategoryName"))
                x.SubItems.Add(dr("Category"))
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmLoadSubcategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSubCategory()
    End Sub
    Private Sub frmLoadSubcategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        frmAddUpdateProduct.txtsubcategory.Text = ListView1.FocusedItem.SubItems(1).Text
        frmAddUpdateProduct.LBLSubCateID.Text = ListView1.FocusedItem.SubItems(0).Text
        frmAddUpdateProduct.txtsubcategory.Tag = ListView1.FocusedItem.Text
        frmBillingItems.subcatId.Text = ListView1.FocusedItem.SubItems(0).Text
        frmBillingItems.txtSubcategory.Text = ListView1.FocusedItem.SubItems(1).Text

        Me.Close()
    End Sub
End Class