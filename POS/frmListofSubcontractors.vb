Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class frmListofSubcontractors
    Dim y As Integer
    Private Sub ListofSubcontractors()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT subcontractors_ID,subcontractor_Name,BusinessReg_No, Location, Email_address, OfficeNo, Contact_person, Phone_No, Address FROM tbl_subcontractors"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("subcontractor_Name"), dr("Location"), dr("Email_address"), dr("OfficeNo"), dr("Contact_person"), dr("Address"), dr("Phone_No"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub frmListofSubcontractors_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub LoadToolStripButton5_Click(sender As Object, e As EventArgs) Handles LoadToolStripButton5.Click
        ListofSubcontractors()
    End Sub
End Class