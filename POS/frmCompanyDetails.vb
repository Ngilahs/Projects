Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmCompanyDetails
    Dim y As Integer
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Private Sub GetcompanyDetailNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT companydetailsID FROM companydetails ORDER BY companydetailsID DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblRefNo.Text = dr("companydetailsID") + 1
            Else
                lblRefNo.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub AddCompany()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If lblRefNo.Text = "" Or txtParentConame.Text = "" Or txtComName.Text = "" Or txttelephoneNo.Text = "" Or txtEmail.Text = "" Or txtVatNo.Text = "" Or txtPinNo.Text = "" Or txtAddress.Text = "" Or txtCity.Text = "" Or txtPostalCode.Text = "" Or txtMpesatill.Text = "" Then
            MsgBox("Please fill-up all fields to Save!")
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO companydetails(companydetailsID, ParentCoName, companyName, TelephoneNo, Email, VATNo, PINNo, Address, City, PostalCode, MpesaTillNo) VALUES('" & lblRefNo.Text & "', '" & txtParentConame.Text & "', '" & txtComName.Text & "', '" & txttelephoneNo.Text & "', '" & txtEmail.Text & "', '" & txtVatNo.Text & "', '" & txtPinNo.Text & "', '" & txtAddress.Text & "', '" & txtCity.Text & "', '" & txtPostalCode.Text & "', '" & txtMpesatill.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Company Details successfully added.", MsgBoxStyle.Information, "Add CompanyDetails")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblRefNo.Text, TimeOfDay, "Added New Company Details")
        clearallfields()
        GetcompanyDetailNo()
    End Sub
    Private Sub UpdateCompanyDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If lblRefNo.Text = "" Or txtParentConame.Text = "" Or txtComName.Text = "" Or txttelephoneNo.Text = "" Or txtEmail.Text = "" Or txtVatNo.Text = "" Or txtPinNo.Text = "" Or txtAddress.Text = "" Or txtCity.Text = "" Or txtPostalCode.Text = "" Or txtMpesatill.Text = "" Then
            MsgBox("Please fill-up all fields to Update!")
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE companydetails SET ParentCoName= '" & txtParentConame.Text & "', companyName = '" & txtComName.Text & "', TelephoneNo= '" & txttelephoneNo.Text & "', Email = '" & txtEmail.Text & "', VATNo= '" & txtVatNo.Text & "', PINNo = '" & txtPinNo.Text & "', Address = '" & txtAddress.Text & "', City = '" & txtCity.Text & "', PostalCode  = '" & txtPostalCode.Text & "', MpesaTillNo = '" & txtMpesatill.Text & "' WHERE companydetailsID = '" & lblRefNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Company Details successfully updated.", MsgBoxStyle.Information, "Update Company Details")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblRefNo.Text, TimeOfDay, "Updated Company Details")
        clearallfields()
        GetcompanyDetailNo()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveToolStripButton5.Click
        GetcompanyDetailNo()
        AddCompany()
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub clearfields()
        'lblRefNo.Text = ""
        txtParentConame.Text = ""
        txtComName.Text = ""
        txttelephoneNo.Text = ""
        txtEmail.Text = ""
        txtVatNo.Text = ""
        txtPinNo.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtPostalCode.Text = ""
        txtMpesatill.Text = ""
    End Sub
    Private Sub clearallfields()
        lblRefNo.Text = ""
        txtParentConame.Text = ""
        txtComName.Text = ""
        txttelephoneNo.Text = ""
        txtEmail.Text = ""
        txtVatNo.Text = ""
        txtPinNo.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtPostalCode.Text = ""
        txtMpesatill.Text = ""
    End Sub
    Private Sub frmCompanyDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearfields()
        GetcompanyDetailNo()
    End Sub
    Private Sub frmCompanyDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        clearallfields()
        GetcompanyDetailNo()
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripButton3.Click
        UpdateCompanyDetails()
        clearfields()
        GetcompanyDetailNo()
        Me.Close()
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.lblRefNo.Text = dgw.Item(0, i).Value
        Me.txtParentConame.Text = dgw.Item(1, i).Value
        Me.txtComName.Text = dgw.Item(2, i).Value
        Me.txttelephoneNo.Text = dgw.Item(3, i).Value
        Me.txtEmail.Text = dgw.Item(4, i).Value
        Me.txtVatNo.Text = dgw.Item(5, i).Value
        Me.txtPinNo.Text = dgw.Item(6, i).Value
        Me.txtMpesatill.Text = dgw.Item(7, i).Value
        Me.txtAddress.Text = dgw.Item(8, i).Value
        Me.txtCity.Text = dgw.Item(9, i).Value
        Me.txtPostalCode.Text = dgw.Item(10, i).Value
    End Sub
    Private Sub txtSerchComname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerchComname.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT companydetailsID, ParentCoName, companyName, TelephoneNo, Email, VATNo, PINNo, MpesaTillNo, Address, City, PostalCode from companydetails where companyName LIKE '" & txtSerchComname.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("companydetailsID"), dr("ParentCoName"), dr("companyName"), dr("TelephoneNo"), dr("Email"), dr("VATNo"), dr("PINNo"), dr("MpesaTillNo"), dr("Address"), dr("City"), dr("PostalCode"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dgw.Rows.Clear()
        clearallfields()
    End Sub
End Class