Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class frmStaff
    Public adding As Boolean
    Public updating As Boolean

    Public Sub LoadStaffs()

        Try
            sqL = "SELECT StaffID, CONCAT(Lastname, ', ', Firstname, ' ', MI) as ClientName, CONCAT(Street, ', ', Barangay, ', ', City , ', ', Province) as Address, ContactNo, username, role FROM Staff WHERE LASTNAME LIKE '" & lblSearch.Text & "%' ORDER By Lastname"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader()

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr("StaffId").ToString)
                x.SubItems.Add(dr("ClientName"))
                x.SubItems.Add(dr("ContactNo"))
                x.SubItems.Add(dr("Address"))
                x.SubItems.Add(dr("username"))
                x.SubItems.Add(dr("Role"))

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("Fill all the Fields with the Correct Data")
            Exit Sub
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        getData()
        ConnDB()
        SaveData()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton4.Click
        adding = True
        updating = False
        frmAddUpdateStaff.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripButton2.Click
        Dim strSearch As String
        strSearch = InputBox("ENTER LAST NAME OF THE STAFF.", "Search CLient")
        lblSearch.Text = strSearch
        LoadStaffs()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripButton3.Click
        If ListView1.Items.Count = 0 Then
            MsgBox("Please select record to update", MsgBoxStyle.Exclamation, "Update")
            Exit Sub
        End If
        Try
            If ListView1.FocusedItem.Text = "" Then
            Else
                adding = False
                updating = True
                frmAddUpdateStaff.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class

