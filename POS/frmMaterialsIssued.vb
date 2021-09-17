Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class frmMaterialsIssued
    Dim y As Integer
    Private Sub GetMaterialIssued()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
delivery_details.DeliveryNo,
delivery_details.IssueDate,
delivery_details.SchemeId,
delivery_details.UserName,
schemes.SchemeNo,
schemes.Scheme_Ref_No,
schemes.Scheme_Name,
schemes.SchemeNo,
delivery_details.ItemCount
FROM
delivery_details
INNER JOIN schemes ON schemes.SchemeNo = delivery_details.SchemeId "
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@dt1", dtpDateFrom.Value.ToString())
            cmd.Parameters.AddWithValue("@dt2", dtpDateTo.Value.ToString())
            dr = cmd.ExecuteReader
            dtgpdcts.Rows.Clear()
            'WHERE IssueDate BETWEEN @dt1 And @dt2 ORDER BY IssueDate
            y = 0
            Do While dr.Read = True
                dtgpdcts.Rows.Add(dr("DeliveryNo"), dr("Scheme_Name"), dr("IssueDate"), dr("ItemCount"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        GetMaterialIssued()
    End Sub

    Private Sub dtgpdcts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgpdcts.CellClick
        frmMaterialIssuedDetails.Show()
    End Sub
End Class