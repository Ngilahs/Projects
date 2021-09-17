Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLoadPaymentmode
    Private Sub loadpaymode()
        Try
            sqL = "SELECT * FROM paymodes WHERE PayModeName LIKE '" & txtCatName.Text & "%' ORDER BY PayModeName "
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("PayModeID").ToString)
                x.SubItems.Add(dr("PayModeName"))
                x.SubItems.Add(dr("Description"))
                ListView1.Items.Add(x)
            Loop
          Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmLoadPaymentmode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadpaymode()
    End Sub
    Private Sub frmLoadPaymentmode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        'frmUpdateMaterialDel.txtPayVia.Text = ListView1.FocusedItem.SubItems(1).Text
        frmPaySupplier.txtPayVia.Text = ListView1.FocusedItem.SubItems(1).Text
        'frmcreditpayment.txtPayVia1.Text = ListView1.FocusedItem.SubItems(1).Text
        Me.Close()
    End Sub
End Class