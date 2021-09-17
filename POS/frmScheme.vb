Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmScheme
    Dim y As Integer
    Private Sub AddScheme()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtSchemeName.Text = "" Or lblSchemeRefNo.Text = "" Or txtSchemeName.Text = "" Or txtCountyID.Text = "" Or txtConstituencyID.Text = "" Or txtNoofCust.Text = "" Or txtSubstNo.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Add New Scheme!")
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO schemes (Scheme_Ref_No, Scheme_Name, County_Id, Constituency_Id, No_of_Customers, Substation_No) VALUES('" & lblSchemeRefNo.Text & "', '" & txtSchemeName.Text & "', '" & txtCountyID.Text & "', '" & txtConstituencyID.Text & "', '" & txtNoofCust.Text & "', '" & txtSubstNo.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("New Scheme successfully added.", MsgBoxStyle.Information, "Add Scheme")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblSchemeRefNo.Text, TimeOfDay, "Added new Scheme")
    End Sub
    Private Sub Updatescheme()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtSchemeName.Text = "" Or lblSchemeRefNo.Text = "" Or txtSchemeName.Text = "" Or txtCountyID.Text = "" Or txtConstituencyID.Text = "" Or txtNoofCust.Text = "" Or txtSubstNo.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Update New Scheme!")
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update schemes SET Scheme_Ref_No = '" & lblSchemeRefNo.Text & "', Scheme_Name = '" & txtSchemeName.Text & "', County_Id = '" & txtCountyID.Text & "', Constituency_Id = '" & txtConstituencyID.Text & "', No_of_Customers = '" & txtNoofCust.Text & "', Substation_No = '" & txtSubstNo.Text & "' where SchemeNo = '" & txtSchemeNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Scheme record successfully updated", MsgBoxStyle.Information, "Update Scheme")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, lblSchemeRefNo.Text, TimeOfDay, "Updated Scheme Information")

    End Sub
    Private Sub Searchscheme()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select S.SchemeNo, S.Scheme_Ref_No, S.Scheme_Name, S.County_Id, S.Constituency_Id, S.No_of_Customers, S.Substation_No, CY.County_Name, CN.constituency_Name from schemes S Inner Join county CY on (S.County_Id = CY.County_No) Inner Join constituency CN on (S.Constituency_Id = CN.Constituency_No) where S.Scheme_Name like '%" & txtsearchsname.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboCounty.Items.Clear()
            cboConstituency.Items.Clear()
            If dr.Read = True Then
                txtSchemeNo.Text = dr("SchemeNo")
                txtSchemeName.Text = dr("Scheme_Name")
                lblSchemeRefNo.Text = dr("Scheme_Ref_No")
                txtCountyID.Text = dr("County_Id")
                txtConstituencyID.Text = dr("Constituency_Id")
                txtNoofCust.Text = dr("No_of_Customers")
                txtSubstNo.Text = dr("Substation_No")
                cboCounty.Text = dr("County_Name")
                cboConstituency.Text = dr("constituency_Name")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub ClearFields()
        txtSchemeName.Text = ""
        lblSchemeRefNo.Text = ""
        txtCountyID.Text = ""
        txtConstituencyID.Text = ""
        txtNoofCust.Text = ""
        txtSubstNo.Text = ""
        cboCounty.Text = ""
        cboConstituency.Text = ""
    End Sub
    Private Sub LoadCounty()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT County_No, County_Name from county ORDER BY County_Name DESC LIMIT 20"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            'cboCounty.Items.Clear()
            Do While dr.Read = True
                cboCounty.Items.Add(dr("County_Name"))
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadCountyID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT County_No, County_Name from county Where County_Name  = '" & cboCounty.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtCountyID.Text = dr("County_No")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadConstituency()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Constituency_No, constituency_Name, county_Id from constituency where county_Id = '" & txtCountyID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                cboConstituency.Items.Add(dr("constituency_Name"))
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadConstituencyID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Constituency_No, constituency_Name, county_Id from constituency Where constituency_Name  = '" & cboConstituency.Text & "' and county_Id = '" & txtCountyID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtConstituencyID.Text = dr("Constituency_No")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub AllClearFields()
        lblSchemeRefNo.Text = ""
        txtSchemeName.Text = ""
    End Sub
    Private Sub frmCustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCounty()
        'LoadSchemename()
        LoadSchemes()
    End Sub
    Private Sub frmCustomers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        ClearFields()
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSUpdateToolStripButton3.Click
        Updatescheme()
        AllClearFields()
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSSaveToolStripButton5.Click
        AddScheme()
        AllClearFields()
        Me.Close()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        CUSSaveToolStripButton5.Enabled = False
        Searchscheme()
        LoadCounty()
    End Sub

    Private Sub cboCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCounty.SelectedIndexChanged
        cboConstituency.Text = ""
        txtConstituencyID.Text = ""
        LoadCountyID()
        LoadConstituency()
    End Sub
    Private Sub cboCounty_TextChanged(sender As Object, e As EventArgs) Handles cboCounty.TextChanged
        cboConstituency.Items.Clear()
    End Sub

    Private Sub cboConstituency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboConstituency.SelectedIndexChanged
        LoadConstituencyID()
    End Sub

    Private Sub LoadSchemes()
        'Dim MysqlConn As MySqlConnection
        'Dim cmd As MySqlCommand
        'MysqlConn = New MySqlConnection
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        'Dim dr As MySqlDataReader
        'Try
        '    MysqlConn.Open()
        '    Dim Query As String
        '    Query = "SELECT SchemeNo, Scheme_Name from schemes"
        '    cmd = New MySqlCommand(Query, MysqlConn)
        '    dr = cmd.ExecuteReader
        '    Do While dr.Read = True
        '        cboPullSchemeName.Items.Add(dr("Scheme_Name"))
        '    Loop
        '    MysqlConn.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MysqlConn.Dispose()
        'End Try
    End Sub
    Private Sub SearchSchemewithID()
        'Dim MysqlConn As MySqlConnection
        'Dim cmd As MySqlCommand
        'MysqlConn = New MySqlConnection
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        'Dim dr As MySqlDataReader
        'Try
        '    MysqlConn.Open()
        '    Dim Query As String
        '    Query = "Select S.SchemeNo, S.Scheme_Ref_No, S.Scheme_Name, S.County_Id, S.Constituency_Id, S.No_of_Customers, S.Substation_No, CY.County_Name, CN.constituency_Name from schemes S Inner Join county CY on (S.County_Id = CY.County_No) Inner Join constituency CN on (S.Constituency_Id = CN.Constituency_No) where S.SchemeNo = '" & txtschemeID.Text & "'"
        '    cmd = New MySqlCommand(Query, MysqlConn)
        '    dr = cmd.ExecuteReader
        '    cboCounty.Items.Clear()
        '    cboConstituency.Items.Clear()
        '    If dr.Read = True Then
        '        txtSchemeNo.Text = dr("SchemeNo")
        '        txtSchemeName.Text = dr("Scheme_Name")
        '        lblSchemeNo.Text = dr("Scheme_Ref_No")
        '        txtCountyID.Text = dr("County_Id")
        '        txtConstituencyID.Text = dr("Constituency_Id")
        '        txtNoofCust.Text = dr("No_of_Customers")
        '        txtSubstNo.Text = dr("Substation_No")
        '        cboCounty.Text = dr("County_Name")
        '        cboConstituency.Text = dr("constituency_Name")
        '    End If
        '    MysqlConn.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MysqlConn.Dispose()
        'End Try
    End Sub
    Private Sub txtsearchsname_TextChanged(sender As Object, e As EventArgs) Handles txtsearchsname.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select S.SchemeNo, S.Scheme_Ref_No, S.Scheme_Name, S.County_Id, S.Constituency_Id, S.No_of_Customers, S.Substation_No, CY.County_Name, CN.constituency_Name from schemes S Inner Join county CY on (S.County_Id = CY.County_No) Inner Join constituency CN on (S.Constituency_Id = CN.Constituency_No) where S.Scheme_Name like '%" & txtsearchsname.Text & "%'or S.Substation_No like '%" & txtsearchsname.Text & "%' or S.Scheme_Ref_No like '%" & txtsearchsname.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("SchemeNo"), dr("Scheme_Ref_No"), dr("Scheme_Name"), dr("County_Name"), dr("County_Id"), dr("constituency_Name"), dr("Constituency_Id"), dr("No_of_Customers"), dr("Substation_No"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            MysqlConn.Open()
                Dim Query As String
            Query = "SELECT S.SchemeNo, SS.SchemeID FROM schemes S INNER JOIN stockinmaterials SS ON S.SchemeNo = SS.SchemeID where SchemeNo=@d1"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", Val(txtSchemeNo.Text))
            dr = cmd.ExecuteReader()
            If dr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Material Received", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not dr Is Nothing Then
                    dr.Close()
                End If
                Exit Sub
            End If
            MysqlConn.Close()
            Dim MysqlConn1 As MySqlConnection
            MysqlConn1 = New MySqlConnection
            MysqlConn1 = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr1 As MySqlDataReader
            MysqlConn1.Open()
            Dim Query1 As String
            Query1 = "SELECT S.SchemeNo, SD.SchemeID FROM schemes S INNER JOIN stockindetails SD ON S.SchemeNo = SD.SchemeID where SchemeNo=@d1"
            cmd = New MySqlCommand(Query1, MysqlConn1)
            cmd.Parameters.AddWithValue("@d1", Val(txtSchemeNo.Text))
            dr1 = cmd.ExecuteReader()
            If dr1.Read Then
                MessageBox.Show("Unable to delete..Already in use in Material Issuance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not dr1 Is Nothing Then
                    dr1.Close()
                End If
                Exit Sub
            End If
            MysqlConn1.Close()
            Dim MysqlConn2 As MySqlConnection
            MysqlConn2 = New MySqlConnection
            MysqlConn2 = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr2 As MySqlDataReader
            MysqlConn2.Open()
            Dim Query2 As String
            Query2 = "delete from schemes where SchemeNo=@d1"
            cmd = New MySqlCommand(Query1, MysqlConn1)
            cmd.Parameters.AddWithValue("@d1", Val(txtSchemeNo.Text))
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                'Update Audit Trail Table
                Audit_Trail(FrmMain.tsslUser.Text, txtSchemeName.Text, TimeOfDay, "Deleted Scheme Information")
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                If MysqlConn2.State = ConnectionState.Open Then
                    MysqlConn2.Close()
                End If
                MysqlConn2.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        txtSchemeNo.Text = dgw.Item(0, i).Value
        lblSchemeRefNo.Text = dgw.Item(1, i).Value
        txtSchemeName.Text = dgw.Item(2, i).Value
        cboCounty.Text = dgw.Item(3, i).Value
        txtCountyID.Text = dgw.Item(4, i).Value
        cboConstituency.Text = dgw.Item(5, i).Value
        txtConstituencyID.Text = dgw.Item(6, i).Value
        txtNoofCust.Text = dgw.Item(7, i).Value
        txtSubstNo.Text = dgw.Item(8, i).Value
        CUSSaveToolStripButton5.Enabled = False
        CUSUpdateToolStripButton3.Enabled = True

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles DeleteToolStripLabel.Click
        If txtSchemeName.Text = "" Or lblSchemeRefNo.Text = "" Or txtSchemeName.Text = "" Or txtCountyID.Text = "" Or txtConstituencyID.Text = "" Or txtNoofCust.Text = "" Or txtSubstNo.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Update New Scheme!")
            Exit Sub
        End If
        DeleteRecord()
    End Sub

    Private Sub lblSchemeRefNo_TextChanged(sender As Object, e As EventArgs) Handles lblSchemeRefNo.KeyUp
        'Check for duplicate entry of Scheme reference no
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
                .CommandText = "SELECT COUNT(*) FROM schemes WHERE Scheme_Ref_No  = '" & lblSchemeRefNo.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Scheme Z ReferenceNo Already Exists!", MsgBoxStyle.Exclamation, "Add New Scheme!")
                lblSchemeRefNo.Clear()
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