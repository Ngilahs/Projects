Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLoadMaterials
    Private Sub frmLoadMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSupplier()
    End Sub
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
        frmMaterialIssuance.txtSchemeName.Text = ListView1.FocusedItem.SubItems(0).Text
        frmMaterialIssuance.txtSchemeRefNo.Text = ListView1.FocusedItem.SubItems(1).Text
        frmMaterialIssuance.txtSchemeID.Text = ListView1.FocusedItem.SubItems(2).Text
        frmMaterialIssuance.txtTXNo.Text = ListView1.FocusedItem.SubItems(3).Text
        frmMaterialIssuance.txtCountyID.Text = ListView1.FocusedItem.SubItems(4).Text
        frmMaterialIssuance.txtConstituencyID.Text = ListView1.FocusedItem.SubItems(5).Text
        frmMaterialIssuance.txtConstituencyname.Text = ListView1.FocusedItem.SubItems(6).Text
        frmMaterialIssuance.txtCounty.Text = ListView1.FocusedItem.SubItems(7).Text
        frmTransporterRegister.txtSchemeName.Text = ListView1.FocusedItem.SubItems(0).Text
        frmTransporterRegister.txtSchemeRefNo.Text = ListView1.FocusedItem.SubItems(1).Text
        frmTransporterRegister.txtSchemeID.Text = ListView1.FocusedItem.SubItems(2).Text
        frmTransporterRegister.txtTXNo.Text = ListView1.FocusedItem.SubItems(3).Text
        frmTransporterRegister.txtCountyID.Text = ListView1.FocusedItem.SubItems(4).Text
        frmTransporterRegister.txtConstituencyID.Text = ListView1.FocusedItem.SubItems(5).Text
        frmTransporterRegister.txtConstituencyname.Text = ListView1.FocusedItem.SubItems(6).Text
        frmTransporterRegister.txtCounty.Text = ListView1.FocusedItem.SubItems(7).Text
        frmTransportRegisterUpdate.txtSchemeName.Text = ListView1.FocusedItem.SubItems(0).Text
        frmTransportRegisterUpdate.txtSchemeRefNo.Text = ListView1.FocusedItem.SubItems(1).Text
        frmTransportRegisterUpdate.txtSchemeID.Text = ListView1.FocusedItem.SubItems(2).Text
        frmTransportRegisterUpdate.txtTxno.Text = ListView1.FocusedItem.SubItems(3).Text
        frmTransportRegisterUpdate.txtCountyID.Text = ListView1.FocusedItem.SubItems(4).Text
        frmTransportRegisterUpdate.txtConstituencyID.Text = ListView1.FocusedItem.SubItems(5).Text
        frmTransportRegisterUpdate.txtConstituencyname.Text = ListView1.FocusedItem.SubItems(6).Text
        frmTransportRegisterUpdate.txtCounty.Text = ListView1.FocusedItem.SubItems(7).Text
        frmMeteringStmnt.txtSchemeName1.Text = ListView1.FocusedItem.SubItems(0).Text
        frmMeteringStmnt.txtSchemeRefNo1.Text = ListView1.FocusedItem.SubItems(1).Text
        frmMeteringStmnt.txtSchemeID1.Text = ListView1.FocusedItem.SubItems(2).Text
        frmMeteringStmnt.txtTXNo1.Text = ListView1.FocusedItem.SubItems(3).Text
        frmMeteringStmnt.txtCountyID1.Text = ListView1.FocusedItem.SubItems(4).Text
        frmMeteringStmnt.txtConstituencyID1.Text = ListView1.FocusedItem.SubItems(5).Text
        frmMeteringStmnt.txtConstituencyname1.Text = ListView1.FocusedItem.SubItems(6).Text
        frmMeteringStmnt.txtCounty1.Text = ListView1.FocusedItem.SubItems(7).Text
        frmMeteringStmnt.txtCustomerNo.Text = ListView1.FocusedItem.SubItems(8).Text

        Me.Close()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class