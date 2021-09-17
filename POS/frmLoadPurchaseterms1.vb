Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLoadPurchaseterms1
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Dim y As Integer
    Private Sub LoadPurchaseterms()
        Try
            sqL = "SELECT * FROM purchasemode WHERE purchsmodename LIKE '" & txtCatName.Text & "%' ORDER BY purchsmodename "
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("purchasemodeID").ToString)
                x.SubItems.Add(dr("purchsmodename"))
                x.SubItems.Add(dr("Terms"))
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub frmLoadPurchaseterms1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPurchaseterms()
    End Sub
    Private Sub frmLoadPurchaseterms1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        frmListofSuppliers.txtPurchamode.Text = ListView1.FocusedItem.SubItems(1).Text
        frmListofSuppliers.txtPurchamode.Tag = ListView1.FocusedItem.Text
        'frmBalaSheet.txtPurchamode0.Text = ListView1.FocusedItem.SubItems(1).Text
        'frmCashFlow.txtPurchamodeRS.Text = ListView1.FocusedItem.SubItems(1).Text txtPurchMdID
        'frmPOS.txtPurchamodeRS.Text = ListView1.FocusedItem.SubItems(1).Text
        'frmPOS.txtPurchMdID.Text = ListView1.FocusedItem.SubItems(0).Text
        'frmStockIn.txtpurchasemode.Text = ListView1.FocusedItem.SubItems(1).Text
        'frmStockIn.txtPurchMdID.Text = ListView1.FocusedItem.SubItems(0).Text
        Me.Close()
    End Sub
End Class