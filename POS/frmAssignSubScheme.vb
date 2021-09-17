Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class frmAssignSubScheme
    Dim y As Integer
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub LoadSchemes()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SchemeNo, Scheme_Name from schemes"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                cboscheme.Items.Add(dr("Scheme_Name"))
                cboscheme.Text = "Scheme"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadSchemeCountyID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select SchemeNo, Scheme_Ref_No, Scheme_Name, County_Id, Constituency_Id from schemes where Scheme_Name = '" & cboscheme.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtschmId.Text = dr("SchemeNo")
                txtcountyId.Text = dr("County_Id")
                txtconstitId.Text = dr("Constituency_Id")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadSubcontractors()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT subcontractors_ID,subcontractor_Name from tbl_subcontractors"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                cboSubcontractorName.Items.Add(dr("subcontractor_Name"))
                cboSubcontractorName.Text = "Sub-contractor"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadSubcontractorID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT subcontractors_ID,subcontractor_Name from tbl_subcontractors where subcontractor_Name = '" & cboSubcontractorName.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtSubcontractId.Text = dr("subcontractors_ID")

            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub frmAssignSubScheme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSchemes()
        LoadSubcontractors()
    End Sub

    Private Sub cboSubcontractorName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubcontractorName.SelectedIndexChanged
        LoadSubcontractorID()
    End Sub

    Private Sub cboscheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboscheme.SelectedIndexChanged
        LoadSchemeCountyID()
        CheckifSchemeisAllocated()
    End Sub
    Private Sub AddSubcontractor()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try

            If txtSubcontractId.Text = "" Or txtschmId.Text = "" Then
                MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Assign Sub-Contractor scheme!")
                Exit Sub
            Else
                MysqlConn.Open()
                Dim Query As String
                Query = "INSERT INTO tbl_subcontractorschemes(SubcontratorId, SchemeId, constituencyId, countyId, Assignedby, DateAssigned) VALUES ('" & txtSubcontractId.Text & "', '" & txtschmId.Text & "', '" & txtconstitId.Text & "', '" & txtcountyId.Text & "','" & FrmMain.tsslUser.Text & "', '" & lbldate.Text & "')"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MsgBox("Scheme Successfully Assigned to Sub-Contractor .", MsgBoxStyle.Information, "Assign Sub-Contractor to Scheme")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtSubcontractId.Text, TimeOfDay, "Assign Sub-Contractor Scheme")
    End Sub
    Private Sub UpdateSubContractor()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtSubcontractId.Text = "" Or txtschmId.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Update Sub-Contractor scheme!")
            Exit Sub
        Else
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update tbl_subcontractorschemes SET SubcontratorId = '" & txtSubcontractId.Text & "', SchemeId = '" & txtschmId.Text & "',  constituencyId = '" & txtconstitId.Text & "',  countyId = '" & txtcountyId.Text & "' WHERE SubSchemeAssignId = '" & txtAssignId.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Sub-Contractor Scheme record successfully updated", MsgBoxStyle.Information, "Update Sub-Contractor Scheme")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtSubcontractId.Text, TimeOfDay, "Updated Sub-Contractor Scheme Information")
        dgw.Rows.Clear()

    End Sub

    Private Sub AUSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles AUSaveToolStripButton5.Click
        AddSubcontractor()
        Clearall()
    End Sub

    Private Sub AUUpdateToolStripButton3_Click(sender As Object, e As EventArgs) Handles AUUpdateToolStripButton3.Click
        UpdateSubContractor()
        Clearall()
    End Sub

    Private Sub TxtLname_TextChanged(sender As Object, e As EventArgs) Handles txtsubconname.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SS.SubSchemeAssignId, SS.SubcontratorId, SS.SchemeId, SS.constituencyId, SS.countyId, SS.Assignedby, SS.DateAssigned, SC.subcontractor_Name, SC.subcontractors_ID, S.SchemeNo, S.Scheme_Name FROM tbl_subcontractorschemes SS Inner Join tbl_subcontractors SC On SS.SubcontratorId = SC.subcontractors_ID Inner Join schemes S on S.SchemeNo = SS.SchemeId where subcontractor_Name LIKE '%" & txtsubconname.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("subcontractor_Name"), dr("SubcontratorId"), dr("Scheme_Name"), dr("SchemeId"), dr("constituencyId"), dr("countyId"), dr("DateAssigned"), dr("SubSchemeAssignId"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub Clearall()
        txtSubcontractId.Text = ""
        txtschmId.Text = ""
        txtconstitId.Text = ""
        txtcountyId.Text = ""
        cboSubcontractorName.Items.Clear()
        cboscheme.Items.Clear()
        LoadSchemes()
        LoadSubcontractors()
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.cboSubcontractorName.Text = dgw.Item(0, i).Value
        Me.txtSubcontractId.Text = dgw.Item(1, i).Value
        Me.cboscheme.Text = dgw.Item(2, i).Value
        Me.txtschmId.Text = dgw.Item(3, i).Value
        Me.txtconstitId.Text = dgw.Item(4, i).Value
        Me.txtcountyId.Text = dgw.Item(5, i).Value
        Me.txtAssignId.Text = dgw.Item(7, i).Value
        AUSaveToolStripButton5.Enabled = False
        AUUpdateToolStripButton3.Enabled = True
    End Sub

    Private Sub CheckifSchemeisAllocated()
        'Check for duplicate entry of product Barcode
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
                .CommandText = "SELECT COUNT(*) FROM tbl_subcontractorschemes WHERE SchemeId  = '" & txtschmId.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Scheme is Allocated!", MsgBoxStyle.Exclamation, "Allocate Scheme!")
                txtschmId.Text = ""
                cboscheme.Items.Clear()
                LoadSchemes()
                cboscheme.Text = "Scheme"
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