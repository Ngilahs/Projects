Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class frmAddUpdateSupplier
    Dim y As Integer
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Private Sub GetSupplierID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Supplier_ID FROM suppliers ORDER BY Supplier_ID DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblSupplierID.Text = dr("Supplier_ID") + 1
            Else
                lblSupplierID.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub AddSupplier()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtSuppname.Text = "" Or txtContactPerson.Text = "" Or txtSuppaddress.Text = "" Or txtmobileNo.Text = "" Or txtlocation.Text = "" Or txtEmailAddress.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSuppname.Focus()
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO suppliers (Supplier_ID, Supp_Name, Supp_Address, Supp_Contact, Contact_Person, Email_Address, Location) VALUES('" & lblSupplierID.Text & "', '" & txtSuppname.Text & "', '" & txtSuppaddress.Text & "', '" & txtmobileNo.Text & "', '" & txtContactPerson.Text & "', '" & txtEmailAddress.Text & "', '" & txtlocation.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("New supplier successfully added.", MsgBoxStyle.Information, "Add Supplier")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblSupplierID.Text, TimeOfDay, "Added New Supplier")
        AllClearFields()
        GetSupplierID()
    End Sub
    Private Sub UpdateSupplier()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtSuppname.Text = "" Or txtContactPerson.Text = "" Or txtSuppaddress.Text = "" Or txtmobileNo.Text = "" Or txtlocation.Text = "" Or txtEmailAddress.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSuppname.Focus()
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update suppliers SET Supp_Name = '" & txtSuppname.Text & "', Supp_Address = '" & txtSuppaddress.Text & "', Supp_Contact = '" & txtmobileNo.Text & "', Contact_Person = '" & txtContactPerson.Text & "', Email_Address = '" & txtEmailAddress.Text & "', Location = '" & txtlocation.Text & "'   WHERE Supplier_ID = '" & lblSupplierID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Supplier record successfully updated", MsgBoxStyle.Information, "Update Supplier")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblSupplierID.Text, TimeOfDay, "Update Supplier information")
        AllClearFields()
        dgw.Rows.Clear()
        GetSupplierID()
    End Sub
    Private Sub ClearFields()
        txtSuppname.Text = ""
        txtSuppaddress.Text = ""
        txtmobileNo.Text = ""
        txtContactPerson.Text = ""
        txtEmailAddress.Text = ""
        txtlocation.Text = ""
    End Sub
    Private Sub AllClearFields()
        lblSupplierID.Text = ""
        txtSuppname.Text = ""
        txtSuppaddress.Text = ""
        txtmobileNo.Text = ""
        txtContactPerson.Text = ""
        txtEmailAddress.Text = ""
        txtlocation.Text = ""
    End Sub
    Private Sub frmAddUpdateSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ClearFields()
        SPSaveToolStripButton5.Enabled = True
        SPUpdateToolStripButton3.Enabled = false
    End Sub
    Private Sub frmAddUpdateSupplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SPSaveToolStripButton5.Click
        GetSupplierID()
        AddSupplier()
        Me.Close()
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SPUpdateToolStripButton3.Click
        UpdateSupplier()
        Me.Close()
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        GetSupplierID()
        ClearFields()
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.lblSupplierID.Text = dgw.Item(0, i).Value
        Me.txtSuppname.Text = dgw.Item(1, i).Value
        Me.txtSuppaddress.Text = dgw.Item(2, i).Value
        Me.txtmobileNo.Text = dgw.Item(3, i).Value
        Me.txtContactPerson.Text = dgw.Item(4, i).Value
        Me.txtEmailAddress.Text = dgw.Item(5, i).Value
        Me.txtlocation.Text = dgw.Item(6, i).Value
        SPSaveToolStripButton5.Enabled = False
        SPUpdateToolStripButton3.Enabled = True
    End Sub
    Private Sub txtsearchsname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearchsname.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Supplier_ID, Supp_Name, Supp_Address, Supp_Contact, Contact_Person, Email_Address, Location FROM suppliers where Supp_Name LIKE '%" & txtsearchsname.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("Supplier_ID"), dr("Supp_Name"), dr("Supp_Address"), dr("Supp_Contact"), dr("Contact_Person"), dr("Email_Address"), dr("Location"))
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
    End Sub

    Private Sub txtSuppname_KeyUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuppname.KeyUp
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            cmd = New MySqlCommand(Query, MysqlConn)
            With cmd
                .Connection = MysqlConn
                .CommandText = "SELECT COUNT(*) FROM suppliers WHERE Supp_Name  = '" & txtSuppname.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Supplier Name Already Exists!", MsgBoxStyle.Exclamation, "Add Supplier!")
                txtSuppname.Clear()
                txtSuppname.Focus()
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class