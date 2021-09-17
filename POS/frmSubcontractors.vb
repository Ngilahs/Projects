Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class frmSubcontractors
    Dim y As Integer
    Private Sub GetSubcontractorID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT subcontractors_ID FROM tbl_subcontractors ORDER BY subcontractors_ID DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtSubcontractorId.Text = dr("subcontractors_ID") + 1
            Else
                txtSubcontractorId.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub AddSubcontractor()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try

            If txtname.Text = "" Or txtLocation.Text = "" Or txtContactPerson.Text = "" Then
                MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Add New Sub-Contractor!")
                Exit Sub
            Else
                MysqlConn.Open()
                Dim Query As String
                Query = "INSERT INTO tbl_subcontractors(subcontractor_Name,BusinessReg_No, Location, Email_address, OfficeNo, Contact_person, Phone_No, Address) VALUES ('" & txtname.Text & "', '" & txtRegNo.Text & "', '" & txtLocation.Text & "', '" & txtEmail.Text & "','" & txtOfficeNo.Text & "', '" & txtContactPerson.Text & "', '" & txtPhoneNo.Text & "', '" & txtAddress.Text & "')"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MsgBox("Sub-Contractor successfully added.", MsgBoxStyle.Information, "Add Sub-Contractor")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtSubcontractorId.Text, TimeOfDay, "Added New Sub-Contractor")
    End Sub
    Private Sub UpdateSubContractor()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtname.Text = "" Or txtLocation.Text = "" Or txtContactPerson.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Update Sub-Contractor!")
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update tbl_subcontractors SET subcontractor_Name = '" & txtname.Text & "', BusinessReg_No = '" & txtRegNo.Text & "',  Location = '" & txtLocation.Text & "',  Email_address = '" & txtEmail.Text & "', OfficeNo ='" & txtOfficeNo.Text & "', Contact_person = '" & txtContactPerson.Text & "', Address = '" & txtAddress.Text & "' WHERE subcontractors_ID = '" & txtSubcontractorId.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Sub-Contractor record successfully updated", MsgBoxStyle.Information, "Update Sub-Contractor")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtSubcontractorId.Text, TimeOfDay, "Updated Sub-Contractor Information")
        dgw.Rows.Clear()

    End Sub

    Private Sub frmSubcontractors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AUSaveToolStripButton5.Enabled = True
        AUUpdateToolStripButton3.Enabled = False
    End Sub

    Private Sub AUSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles AUSaveToolStripButton5.Click
        AddSubcontractor()
        ClearAll()
    End Sub

    Private Sub AUUpdateToolStripButton3_Click(sender As Object, e As EventArgs) Handles AUUpdateToolStripButton3.Click
        UpdateSubContractor()
        ClearAll()
    End Sub

    Private Sub txtSubname_TextChanged(sender As Object, e As EventArgs) Handles txtSubname.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT subcontractors_ID,subcontractor_Name,BusinessReg_No, Location, Email_address, OfficeNo, Contact_person, Phone_No, Address FROM tbl_subcontractors where subcontractor_Name LIKE '%" & txtSubname.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("subcontractors_ID"), dr("subcontractor_Name"), dr("BusinessReg_No"), dr("Location"), dr("Email_address"), dr("OfficeNo"), dr("Contact_person"), dr("Address"), dr("Phone_No"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.txtSubcontractorId.Text = dgw.Item(0, i).Value
        Me.txtname.Text = dgw.Item(1, i).Value
        Me.txtRegNo.Text = dgw.Item(2, i).Value
        Me.txtLocation.Text = dgw.Item(3, i).Value
        Me.txtEmail.Text = dgw.Item(4, i).Value
        Me.txtOfficeNo.Text = dgw.Item(5, i).Value
        Me.txtContactPerson.Text = dgw.Item(6, i).Value
        Me.txtAddress.Text = dgw.Item(7, i).Value
        Me.txtPhoneNo.Text = dgw.Item(8, i).Value
        AUSaveToolStripButton5.Enabled = False
        AUUpdateToolStripButton3.Enabled = True
    End Sub
    Private Sub ClearAll()
        txtSubcontractorId.Text = ""
        txtname.Text = ""
        txtRegNo.Text = ""
        txtLocation.Text = ""
        txtEmail.Text = ""
        txtOfficeNo.Text = ""
        txtContactPerson.Text = ""
        txtAddress.Text = ""
        txtPhoneNo.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgw.Rows.Clear()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.KeyUp
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            'subcontractors_ID,subcontractor_Name,BusinessReg_No, Location, Email_address, OfficeNo, Contact_person, Phone_No, Address FROM tbl_subcontractors
            MysqlConn.Open()
            Dim Query As String
            cmd = New MySqlCommand(Query, MysqlConn)
            With cmd
                .Connection = MysqlConn
                .CommandText = "SELECT COUNT(*) FROM tbl_subcontractors WHERE subcontractor_Name  = '" & txtname.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Sub-Contractor Already Exists!", MsgBoxStyle.Exclamation, "Add New sub-contractor!")
                txtname.Clear()
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        txtSubcontractorId.Text = ""
        txtname.Text = ""
        txtRegNo.Text = ""
        txtLocation.Text = ""
        txtEmail.Text = ""
        txtOfficeNo.Text = ""
        txtContactPerson.Text = ""
        txtAddress.Text = ""
        txtPhoneNo.Text = ""
    End Sub
End Class