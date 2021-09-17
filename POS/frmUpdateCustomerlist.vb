Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Configuration
Public Class frmUpdateCustomerlist
    Dim y As Integer
    Private Sub LoadMeterReceipts()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT MeterReceiptNo from tbl_meterrvcd_info Where SchemeID = '" & txtSchemeID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                cboBatchNo.Items.Add(dr("MeterReceiptNo"))
                cboBatchNo.Text = "Batch No"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadSchemedetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select S.SchemeNo, S.Scheme_Ref_No, S.Scheme_Name, S.County_Id, S.Constituency_Id, S.No_of_Customers, S.Substation_No, CY.County_Name, CN.constituency_Name from schemes S Inner Join county CY on (S.County_Id = CY.County_No) Inner Join constituency CN on (S.Constituency_Id = CN.Constituency_No) where S.Scheme_Ref_No = '" & txtSchemeRefNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            y = 0
            If dr.Read = True Then
                txtConstituencyID.Text = dr("Constituency_Id")
                txtConstituencyname.Text = dr("constituency_Name")
                txtCounty.Text = dr("County_Name")
                txtCountyID.Text = dr("County_Id")
                txtSchemeName.Text = dr("Scheme_Name")
                txtSchemeID.Text = dr("SchemeNo")
                txtTXNo.Text = dr("Substation_No")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnLoadSchemes_Click(sender As Object, e As EventArgs) Handles btnLoadSchemes.Click
        frmLoadSchemedetails.ShowDialog()
    End Sub

    Private Sub txtSchemeRefNo_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeRefNo.TextChanged
        LoadSchemedetails()
    End Sub

    Private Sub LoadMeterdetailslist()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT MeterRcptNo, SchemeID, CustomerName, IDNo, PoleNo, PhoneNo, XCoordinate, YCoordinate, YRefNo, WorkOrder, MeterNo, ConnectionStatus, Gender, Earthing, Remarks, IssuanceStatus, MeterrvcdCustDetailNo from tbl_meterrvcd_details Where MeterRcptNo = '" & cboBatchNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgwz.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgwz.Rows.Add(dr("MeterRcptNo"), dr("CustomerName"), dr("IDNo"), dr("PoleNo"), dr("PhoneNo"), dr("XCoordinate"), dr("YCoordinate"), dr("YRefNo"), dr("MeterNo"), dr("Earthing"), dr("ConnectionStatus"), dr("IssuanceStatus"), dr("Remarks"), dr("MeterrvcdCustDetailNo"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub cboBatchNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBatchNo.SelectedIndexChanged
        LoadMeterdetailslist()
    End Sub

    Private Sub txtSchemeID_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeID.TextChanged
        LoadMeterReceipts()
    End Sub

    Private Sub frmUpdateCustomerlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnUpdateMeterDetails.Enabled = False
    End Sub

    Private Sub dgwz_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwz.CellContentClick
        Dim i As Integer
        i = dgwz.CurrentRow.Index
        Me.txtBatchNo.Text = dgwz.Item(0, i).Value
        Me.txtName.Text = dgwz.Item(1, i).Value
        Me.txtIDNo.Text = dgwz.Item(2, i).Value
        Me.txtPoleNo.Text = dgwz.Item(3, i).Value
        Me.txtPhoneno.Text = dgwz.Item(4, i).Value
        Me.txtXcoordinate.Text = dgwz.Item(5, i).Value
        Me.txtYcoord.Text = dgwz.Item(6, i).Value
        Me.txtYRefNo.Text = dgwz.Item(7, i).Value
        Me.txtMeterNo.Text = dgwz.Item(8, i).Value
        Me.txtEarthing.Text = dgwz.Item(9, i).Value
        Me.txtconnecttatus.Text = dgwz.Item(10, i).Value
        Me.txtIssuestatus.Text = dgwz.Item(11, i).Value
        Me.txtRemarks.Text = dgwz.Item(12, i).Value
        Me.txtMeterDetailNo.Text = dgwz.Item(13, i).Value
        btnUpdateMeterDetails.Enabled = True
        dgwz.Rows.Clear()
    End Sub

    Private Sub UpdateMeterMaster()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update tbl_meterrvcd_details SET CustomerName = '" & txtName.Text & "', IDNo = '" & txtIDNo.Text & "', PoleNo = '" & txtPoleNo.Text & "', PhoneNo = '" & txtPhoneno.Text & "', XCoordinate = '" & txtXcoordinate.Text & "', YCoordinate = '" & txtYcoord.Text & "', YRefNo = '" & txtYRefNo.Text & "', MeterNo = '" & txtMeterNo.Text & "', ConnectionStatus = '" & txtconnecttatus.Text & "', Earthing = '" & txtEarthing.Text & "', Remarks = '" & txtRemarks.Text & "', IssuanceStatus = '" & txtIssuestatus.Text & "' Where MeterrvcdCustDetailNo = '" & txtMeterDetailNo.Text & "' and MeterRcptNo = '" & cboBatchNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgwz.Rows.Clear()
            y = 0
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        Resetform()
        MsgBox("Scheme Meter master list successfully updated")
    End Sub
    Private Sub Resetform()
        Me.txtBatchNo.Text = ""
        Me.txtName.Text = ""
        Me.txtIDNo.Text = ""
        Me.txtPoleNo.Text = ""
        Me.txtPhoneno.Text = ""
        Me.txtXcoordinate.Text = ""
        Me.txtYcoord.Text = ""
        Me.txtYRefNo.Text = ""
        Me.txtMeterNo.Text = ""
        Me.txtEarthing.Text = ""
        Me.txtconnecttatus.Text = ""
        Me.txtIssuestatus.Text = ""
        Me.txtRemarks.Text = ""
        Me.txtMeterDetailNo.Text = ""
        dgwz.Rows.Clear()
    End Sub
    Private Sub btnUpdateMeterDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateMeterDetails.Click
        UpdateMeterMaster()
    End Sub

    Private Sub DeleteMeterdetail()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from tbl_meterrvcd_details Where MeterrvcdCustDetailNo = '" & txtMeterDetailNo.Text & "' and MeterRcptNo = '" & cboBatchNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgwz.Rows.Clear()
            y = 0
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        Resetform()
        MsgBox("Meter Detail successfully Deleted")
    End Sub
    Private Sub btnDeleteMeterDetail_Click(sender As Object, e As EventArgs) Handles btnDeleteMeterDetail.Click
        If MessageBox.Show("Are you sure you want to delete the record? Once deleted cannot be restored!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            DeleteMeterdetail()
        End If
    End Sub
End Class