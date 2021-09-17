Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLoadExpense
    Dim y As Integer
    Private Sub LoadExpense()
        Try
            sqL = "SELECT * FROM expensecat WHERE ExpenseName LIKE '" & txtExpName.Text & "%' ORDER BY ExpenseName "
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("ExpenseID").ToString)
                x.SubItems.Add(dr("ExpenseName"))
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
    Private Sub frmLoadExpense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadExpense()
    End Sub
    Private Sub frmLoadExpense_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        frmAddUpdateExpenses.txtexpensename.Text = ListView1.FocusedItem.SubItems(1).Text
        frmAddUpdateExpenses.LBLEXPID.Text = ListView1.FocusedItem.SubItems(0).Text
        frmAddUpdateExpenses.txtexpensename.Tag = ListView1.FocusedItem.Text
        Me.Close()
    End Sub
End Class