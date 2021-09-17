
Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLoadSchemedetails
    Private Sub LoadSchemedetails()
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
        LoadSchemedetails()
    End Sub
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        frmReceiveMeters.txtSchemeName.Text = ListView1.FocusedItem.SubItems(0).Text
        frmReceiveMeters.txtSchemeRefNo.Text = ListView1.FocusedItem.SubItems(1).Text
        frmReceiveMeters.txtSchemeID.Text = ListView1.FocusedItem.SubItems(2).Text
        frmReceiveMeters.txtTXNo.Text = ListView1.FocusedItem.SubItems(3).Text
        frmReceiveMeters.txtCountyID.Text = ListView1.FocusedItem.SubItems(4).Text
        frmReceiveMeters.txtConstituencyID.Text = ListView1.FocusedItem.SubItems(5).Text
        frmReceiveMeters.txtConstituencyname.Text = ListView1.FocusedItem.SubItems(6).Text
        frmReceiveMeters.txtCounty.Text = ListView1.FocusedItem.SubItems(7).Text
        frmIssueMeters.txtSchemeName.Text = ListView1.FocusedItem.SubItems(0).Text
        frmIssueMeters.txtSchemeRefNo.Text = ListView1.FocusedItem.SubItems(1).Text
        frmIssueMeters.txtSchemeID.Text = ListView1.FocusedItem.SubItems(2).Text
        frmIssueMeters.txtTXNo.Text = ListView1.FocusedItem.SubItems(3).Text
        frmIssueMeters.txtCountyID.Text = ListView1.FocusedItem.SubItems(4).Text
        frmIssueMeters.txtConstituencyID.Text = ListView1.FocusedItem.SubItems(5).Text
        frmIssueMeters.txtConstituencyname.Text = ListView1.FocusedItem.SubItems(6).Text
        frmIssueMeters.txtCounty.Text = ListView1.FocusedItem.SubItems(7).Text
        'Customer list
        frmUpdateCustomerlist.txtSchemeName.Text = ListView1.FocusedItem.SubItems(0).Text
        frmUpdateCustomerlist.txtSchemeRefNo.Text = ListView1.FocusedItem.SubItems(1).Text
        frmUpdateCustomerlist.txtSchemeID.Text = ListView1.FocusedItem.SubItems(2).Text
        frmUpdateCustomerlist.txtTXNo.Text = ListView1.FocusedItem.SubItems(3).Text
        frmUpdateCustomerlist.txtCountyID.Text = ListView1.FocusedItem.SubItems(4).Text
        frmUpdateCustomerlist.txtConstituencyID.Text = ListView1.FocusedItem.SubItems(5).Text
        frmUpdateCustomerlist.txtConstituencyname.Text = ListView1.FocusedItem.SubItems(6).Text
        frmUpdateCustomerlist.txtCounty.Text = ListView1.FocusedItem.SubItems(7).Text
        'Upload JMC Details
        frmJMCDetails.txtSchemeName.Text = ListView1.FocusedItem.SubItems(0).Text
        frmJMCDetails.txtSchemeRefNo.Text = ListView1.FocusedItem.SubItems(1).Text
        frmJMCDetails.txtSchemeID.Text = ListView1.FocusedItem.SubItems(2).Text
        frmJMCDetails.txtTXNo.Text = ListView1.FocusedItem.SubItems(3).Text
        frmJMCDetails.txtCountyID.Text = ListView1.FocusedItem.SubItems(4).Text
        frmJMCDetails.txtConstituencyID.Text = ListView1.FocusedItem.SubItems(5).Text
        frmJMCDetails.txtConstituencyname.Text = ListView1.FocusedItem.SubItems(6).Text
        frmJMCDetails.txtCounty.Text = ListView1.FocusedItem.SubItems(7).Text
        'Issue Transformer
        frmIssueTransformer.txtSchemeName.Text = ListView1.FocusedItem.SubItems(0).Text
        frmIssueTransformer.txtSchemeRefNo.Text = ListView1.FocusedItem.SubItems(1).Text
        frmIssueTransformer.txtSchemeID.Text = ListView1.FocusedItem.SubItems(2).Text
        frmIssueTransformer.txtTXNo.Text = ListView1.FocusedItem.SubItems(3).Text
        frmIssueTransformer.txtCountyID.Text = ListView1.FocusedItem.SubItems(4).Text
        frmIssueTransformer.txtConstituencyID.Text = ListView1.FocusedItem.SubItems(5).Text
        frmIssueTransformer.txtConstituencyname.Text = ListView1.FocusedItem.SubItems(6).Text
        frmIssueTransformer.txtCounty.Text = ListView1.FocusedItem.SubItems(7).Text
        'Update transformer issuance
        frmIssueTransformer.txtSchemeName1.Text = ListView1.FocusedItem.SubItems(0).Text
        frmIssueTransformer.txtSchemeRefNo1.Text = ListView1.FocusedItem.SubItems(1).Text
        frmIssueTransformer.txtSchemeID1.Text = ListView1.FocusedItem.SubItems(2).Text
        frmIssueTransformer.txtTXNo1.Text = ListView1.FocusedItem.SubItems(3).Text
        frmIssueTransformer.txtCountyID1.Text = ListView1.FocusedItem.SubItems(4).Text
        frmIssueTransformer.txtConstituencyID1.Text = ListView1.FocusedItem.SubItems(5).Text
        frmIssueTransformer.txtConstituencyname1.Text = ListView1.FocusedItem.SubItems(6).Text
        frmIssueTransformer.txtCounty1.Text = ListView1.FocusedItem.SubItems(7).Text
        Me.Close()
    End Sub
    Private Sub frmLoadSchemedetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSchemedetails()
    End Sub
End Class