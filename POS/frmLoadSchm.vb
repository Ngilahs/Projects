Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLoadSchm
    Private Sub LoadSupplier()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT S.SchemeNo, S.Scheme_Name, S.No_of_Customers, S.Substation_No, S.Scheme_Ref_No, S.County_Id, S.Constituency_Id, C.County_No, C.County_Name, CN.Constituency_No, CN.constituency_Name from schemes S INNER Join constituency CN ON CN.Constituency_No = S.Constituency_Id INNER Join county C ON C.County_No = S.County_Id where Scheme_Name LIKE '%" & txtItemName.Text & "%' ORDER BY Scheme_Name"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("Scheme_Name").ToString)
                x.SubItems.Add(dr("Scheme_Ref_No"))
                x.SubItems.Add(dr("SchemeNo"))
                x.SubItems.Add(dr("Substation_No"))
                x.SubItems.Add(dr("County_Id"))
                x.SubItems.Add(dr("Constituency_Id"))
                x.SubItems.Add(dr("constituency_Name"))
                x.SubItems.Add(dr("County_Name"))
                x.SubItems.Add(dr("No_of_Customers"))
                ListView1.Items.Add(x)
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub txtItemName_TextChanged(sender As Object, e As EventArgs) Handles txtItemName.TextChanged
        LoadSupplier()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        frmInvoicing.txtSchemeName.Text = ListView1.FocusedItem.SubItems(0).Text
        frmInvoicing.SchemeRefNotxt.Text = ListView1.FocusedItem.SubItems(1).Text
        frmInvoicing.SchemeIDtxt.Text = ListView1.FocusedItem.SubItems(2).Text
        frmInvoicing.txtTXNo.Text = ListView1.FocusedItem.SubItems(3).Text
        frmInvoicing.txtCountyID.Text = ListView1.FocusedItem.SubItems(4).Text
        frmInvoicing.txtConstituencyID.Text = ListView1.FocusedItem.SubItems(5).Text
        frmInvoicing.txtConstituencyname.Text = ListView1.FocusedItem.SubItems(6).Text
        frmInvoicing.txtCounty.Text = ListView1.FocusedItem.SubItems(7).Text
        frmInvoicing.txtCustomerNo.Text = ListView1.FocusedItem.SubItems(8).Text
        Me.Close()
    End Sub

    Private Sub frmLoadSchm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class