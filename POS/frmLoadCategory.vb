Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLoadCategory
    Dim y As Integer
    Private Sub LoadCategory()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM Category WHERE CategoryName LIKE '" & txtCatName.Text & "%' ORDER BY CategoryName "
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("CategoryNo").ToString)
                x.SubItems.Add(dr("CategoryName"))
                x.SubItems.Add(dr("Description"))

                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub frmLoadCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCategory()
    End Sub
    Private Sub frmLoadCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        frmAddUpdateProduct.txtCategory.Text = ListView1.FocusedItem.SubItems(1).Text
        frmAddUpdateProduct.LBLCateID.Text = ListView1.FocusedItem.SubItems(0).Text
        frmAddUpdateProduct.txtCategory.Tag = ListView1.FocusedItem.Text
        frmCreateTools.txtCategory.Text = ListView1.FocusedItem.SubItems(1).Text
        frmCreateTools.LBLCateID.Text = ListView1.FocusedItem.SubItems(0).Text
        frmBillingItems.txtCategoryID.Text = ListView1.FocusedItem.SubItems(0).Text
        frmBillingItems.txtCategoryName.Text = ListView1.FocusedItem.SubItems(1).Text
        Me.Close()
    End Sub

    
End Class