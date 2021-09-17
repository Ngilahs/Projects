Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class frmLoadSubcontractors
    Private Sub LoadSubcontractors()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select subcontractors_ID,subcontractor_Name from tbl_subcontractors where subcontractor_Name LIKE '%" & txtsubcontractorName.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("subcontractors_ID").ToString)
                x.SubItems.Add(dr("subcontractor_Name"))
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub txtsubcontractorName_TextChanged(sender As Object, e As EventArgs) Handles txtsubcontractorName.TextChanged
        LoadSubcontractors()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        frmInvoicing.txtSubcontractor.Text = ListView1.FocusedItem.SubItems(0).Text
        frmInvoicing.cboSubcontractor.Text = ListView1.FocusedItem.SubItems(1).Text
        frmMeteringStmnt.txtSubcontractor.Text = ListView1.FocusedItem.SubItems(0).Text
        frmMeteringStmnt.cboSubcontractor.Text = ListView1.FocusedItem.SubItems(1).Text
        frmTechBOQ.txtSubcontractor.Text = ListView1.FocusedItem.SubItems(0).Text
        frmTechBOQ.cboSubcontractor.Text = ListView1.FocusedItem.SubItems(1).Text
        frmIssueTransformer.cboSubcontractor.Text = ListView1.FocusedItem.SubItems(1).Text
        frmIssueTransformer.txtSubcontractor.Text = ListView1.FocusedItem.SubItems(0).Text
        frmIssueTransformer.cboSubcontractor1.Text = ListView1.FocusedItem.SubItems(1).Text
        frmIssueTransformer.txtSubcontractor1.Text = ListView1.FocusedItem.SubItems(0).Text
        Me.Close()
    End Sub


End Class