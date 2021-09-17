Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmSuppliers

    Public adding As Boolean
    Public updating As Boolean
    Private Sub frmSuppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        getData()
        ConnDB()
        SaveData()
    End Sub

    Public Sub Loadsuppliers()
        Try
            sqL = "SELECT Supplier_ID, Supp_Name, Supp_Address, Supp_Contact, Contact_Person, Email_Address, Location FROM suppliers WHERE Supp_Name LIKE '" & lblSearch.Text & "%' ORDER By Supp_Name"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader()

            Dim x As ListViewItem
            lstviewSupp.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("Supplier_ID").ToString)
                x.SubItems.Add(dr("Supp_Name"))
                x.SubItems.Add(dr("Supp_Address"))
                x.SubItems.Add(dr("Supp_Contact"))
                x.SubItems.Add(dr("Contact_Person"))
                x.SubItems.Add(dr("Email_Address"))
                x.SubItems.Add(dr("Location"))

                lstviewSupp.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("Fill all the Fields with the Correct Data")
            Exit Sub
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton4.Click
        adding = True
        updating = False
        frmAddUpdateSupplier.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripButton2.Click
        Dim strSearch As String
        strSearch = InputBox("ENTER LAST NAME OF THE ", "Search CLient")
        lblSearch.Text = strSearch
        Loadsuppliers()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripButton3.Click
        If lstviewSupp.Items.Count = 0 Then
            MsgBox("Please select record to update", MsgBoxStyle.Exclamation, "Update")
            Exit Sub
        End If
        Try
            If lstviewSupp.FocusedItem.Text = "" Then
            Else
                adding = False
                updating = True
                frmAddUpdateSupplier.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteSupplier()
        Try
             Select MsgBox("Are You Sure You Want To Remove Item?", MsgBoxStyle.OkCancel, "POS")
                Case MsgBoxResult.Ok
                    sqL = "Delete from suppliers WHERE Supp_Name LIKE '" & lblSearch.Text & "%'"
                    ConnDB()
                    cmd = New MySqlCommand(sqL, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("New supplier successfully Deleted.", MsgBoxStyle.Information, "Delete Supplier")

                Case MsgBoxResult.Cancel
                    Exit Sub
            End Select
        Catch ex As Exception
            MsgBox("Fill all the Fields with the Correct Data")
            Exit Sub
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub
    Private Sub ToolStripButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonDelete.Click
        DeleteSupplier()
    End Sub
End Class