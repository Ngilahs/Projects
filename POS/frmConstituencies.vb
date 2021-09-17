Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmConstituencies
    Dim y As Integer
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Private Sub AddConstituency()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtConstituentName.Text = "" Or cboCountyName.Text = "" Or txtNoofCust.Text = "" Or txtSubstNo.Text = "" Or txtNoofCust.Text = "" Or txtNoofSchemes.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Add New Constituency!")
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO constituency (constituency_Name, county_Id, customers, substations, schemes) VALUES ('" & txtConstituentName.Text & "', '" & txtCountyID.Text & "', '" & txtNoofCust.Text & "', '" & txtSubstNo.Text & "', '" & txtNoofSchemes.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("New Constituency successfully added.", MsgBoxStyle.Information, "Add Constituency")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtConstituentName.Text, TimeOfDay, "Added new Constituency")
        Me.Close()
    End Sub
    Private Sub UpdateConstituency()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If txtConstituentName.Text = "" Or cboCountyName.Text = "" Or txtNoofCust.Text = "" Or txtSubstNo.Text = "" Or txtNoofCust.Text = "" Or txtNoofSchemes.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Update New Constituency!")
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update constituency SET constituency_Name = '" & txtConstituentName.Text & "', county_Id = '" & txtCountyID.Text & "', customers = '" & txtNoofCust.Text & "', Substations = '" & txtSubstNo.Text & "', Schemes = '" & txtNoofSchemes.Text & "' where Constituency_No = '" & txtConstituencyNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("constituency record successfully updated", MsgBoxStyle.Information, "Update Constituency")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table County_Name, Constituencies, Customers, Substations, Schemes
        Audit_Trail(FrmMain.tsslUser.Text, txtConstituentName.Text, TimeOfDay, "Updated Constituency Information")
        Me.Close()
    End Sub
    Private Sub SearchCounty()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select CN.Constituency_No, CN.constituency_Name, CN.county_Id, CN.customers, CN.substations, CN.schemes, CY.County_Name from constituency CN inner join county CY on (CN.county_Id = CY.County_No) where CN.constituency_Name like '" & txtsearchsname.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboCountyName.Items.Clear()
            If dr.Read = True Then
                txtConstituencyNo.Text = dr("Constituency_No")
                txtConstituentName.Text = dr("constituency_Name")
                txtCountyID.Text = dr("county_Id")
                txtNoofSchemes.Text = dr("Schemes")
                txtNoofCust.Text = dr("Customers")
                txtSubstNo.Text = dr("Substations")
                cboCountyName.Text = dr("County_Name")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub LoadCounties()
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
            cboCountyName.Items.Clear()
            Do While dr.Read = True
                cboCountyName.Items.Add(dr("County_Name"))
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
            Query = "SELECT County_No, County_Name from county Where County_Name  = '" & cboCountyName.Text & "'"
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
    Private Sub LoadCountyName()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT County_No, County_Name from county Where County_No  = '" & txtCountyID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                cboCountyName.Text = dr("County_Name")
            End If
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Not dr.IsClosed Then dr.Close()
            MysqlConn.Close()
        End Try
    End Sub
    Private Sub ClearAllTextboxes()
        txtConstituencyNo.Text = ""
        txtConstituentName.Text = ""
        txtCountyID.Text = ""
        cboCountyName.Text = ""
        txtNoofSchemes.Text = ""
        txtNoofCust.Text = ""
        txtSubstNo.Text = ""
        txtsearchsname.Text = ""
    End Sub
    Private Sub frmConstituencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCounties()
    End Sub

    Private Sub cboCountyName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCountyName.SelectedIndexChanged
        LoadCountyID()
    End Sub

    Private Sub CreateConstituentSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles CreateConstituentSaveToolStripButton5.Click
        AddConstituency()
        ClearAllTextboxes()
    End Sub

    Private Sub CConstiupdateToolStripButton3_Click(sender As Object, e As EventArgs) Handles CConstiupdateToolStripButton3.Click
        UpdateConstituency()
        ClearAllTextboxes()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNewItem_Click(sender As Object, e As EventArgs) Handles btnNewItem.Click
        ClearAllTextboxes()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        SearchCounty()
    End Sub

    Private Sub txtConstituentName_TextChanged(sender As Object, e As EventArgs) Handles txtConstituentName.KeyUp
        'Check for duplicate entry of product sub category
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
                .CommandText = "SELECT COUNT(*) FROM constituency WHERE constituency_Name  = '" & txtConstituentName.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Constituency Already Exists!", MsgBoxStyle.Exclamation, "Add New Constituency!")
                txtConstituentName.Clear()
                txtConstituentName.Focus()
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            MysqlConn.Close()
        End Try
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
            Query = "Select CN.Constituency_No, CN.constituency_Name, CN.county_Id, CN.customers, CN.substations, CN.schemes, CY.County_Name from constituency CN inner join county CY on (CN.county_Id = CY.County_No) where CN.constituency_Name like '" & txtsearchsname.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("Constituency_No"), dr("constituency_Name"), dr("County_Name"), dr("county_Id"), dr("Customers"), dr("Substations"), dr("Schemes"))
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
        Me.txtConstituencyNo.Text = dgw.Item(0, i).Value
        Me.txtConstituentName.Text = dgw.Item(1, i).Value
        Me.cboCountyName.Text = dgw.Item(2, i).Value
        Me.txtCountyID.Text = dgw.Item(3, i).Value
        Me.txtNoofCust.Text = dgw.Item(4, i).Value
        Me.txtSubstNo.Text = dgw.Item(5, i).Value
        Me.txtNoofSchemes.Text = dgw.Item(6, i).Value
        CreateConstituentSaveToolStripButton5.Enabled = False
        CConstiupdateToolStripButton3.Enabled = True
    End Sub
End Class