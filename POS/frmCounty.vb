Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmCounty
    Dim y As Integer
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Private originalSize As Size
    Private Sub AddScheme()
        Dim MysqlConn As MySqlConnection
        Dim COMMAND As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim READER As MySqlDataReader
        If txtCountyName.Text = "" Or txtNoConstituency.Text = "" Or txtNoofCust.Text = "" Or txtNoConstituency.Text = "" Or txtSubstNo.Text = "" Or txtNoofCust.Text = "" Or txtNoofSchemes.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Add New County!")
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO county (County_Name, Constituencies, Customers, Substations, Schemes) VALUES ('" & txtCountyName.Text & "', '" & txtNoConstituency.Text & "', '" & txtNoofCust.Text & "', '" & txtSubstNo.Text & "', '" & txtNoofSchemes.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MsgBox("New County successfully added.", MsgBoxStyle.Information, "Add County")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtCountyName.Text, TimeOfDay, "Added new County")
        Me.Close()
    End Sub
    Private Sub Updatescheme()
        Dim MysqlConn As MySqlConnection
        Dim COMMAND As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim READER As MySqlDataReader
        If txtCountyName.Text = "" Or txtNoConstituency.Text = "" Or txtNoofCust.Text = "" Or txtNoConstituency.Text = "" Or txtSubstNo.Text = "" Or txtNoofCust.Text = "" Or txtNoofSchemes.Text = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Exclamation, "Update New County!")
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update county SET County_Name = '" & txtCountyName.Text & "', Constituencies = '" & txtNoConstituency.Text & "', Customers = '" & txtNoofCust.Text & "', Substations = '" & txtSubstNo.Text & "', Schemes = '" & txtNoofSchemes.Text & "' where County_No = '" & txtCountyNo.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MsgBox("County successfully updated.", MsgBoxStyle.Information, "Update County")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        'Update Audit Trail Table 
        Audit_Trail(FrmMain.tsslUser.Text, txtCountyName.Text, TimeOfDay, "Updated County Information")
        Me.Close()
    End Sub
    Private Sub SearchCounty()
        Dim MysqlConn As MySqlConnection
        Dim COMMAND As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select County_No, County_Name, Constituencies, Customers, Substations, Schemes from county where County_Name like '%" & txtsearchsname.Text & "%'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            If READER.Read = True Then
                txtCountyNo.Text = READER("County_No")
                txtCountyName.Text = READER("County_Name")
                txtNoConstituency.Text = READER("Constituencies")
                txtNoofSchemes.Text = READER("Schemes")
                txtNoofCust.Text = READER("Customers")
                txtSubstNo.Text = READER("Substations")
            End If
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub ClearAllFields()
        txtCountyNo.Text = ""
        txtCountyName.Text = ""
        txtNoConstituency.Text = ""
        txtNoofSchemes.Text = ""
        txtNoofCust.Text = ""
        txtSubstNo.Text = ""
    End Sub

    Private Sub CUSSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles CUSSaveToolStripButton5.Click
        AddScheme()
        ClearAllFields()
        CUSUpdateToolStripButton3.Enabled = True
    End Sub

    Private Sub CUSUpdateToolStripButton3_Click(sender As Object, e As EventArgs) Handles CUSUpdateToolStripButton3.Click
        Updatescheme()
        ClearAllFields()
        CUSSaveToolStripButton5.Enabled = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        SearchCounty()
        CUSSaveToolStripButton5.Enabled = False
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripbtnClearall.Click
        ClearAllFields()
    End Sub

    Private Sub txtsearchsname_TextChanged(sender As Object, e As EventArgs) Handles txtsearchsname.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        ' MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select County_No, County_Name, Constituencies, Customers, Substations, Schemes from county where County_Name like '%" & txtsearchsname.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("County_No"), dr("County_Name"), dr("Constituencies"), dr("Customers"), dr("Substations"), dr("Schemes"))
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
        Me.txtCountyNo.Text = dgw.Item(0, i).Value
        Me.txtCountyName.Text = dgw.Item(1, i).Value
        Me.txtNoConstituency.Text = dgw.Item(2, i).Value
        Me.txtNoofCust.Text = dgw.Item(3, i).Value
        Me.txtSubstNo.Text = dgw.Item(4, i).Value
        Me.txtNoofSchemes.Text = dgw.Item(5, i).Value
        CUSSaveToolStripButton5.Enabled = False
        CUSUpdateToolStripButton3.Enabled = True
    End Sub

    Private Sub frmCounty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- get client Moniter Resolution
        Dim monitorWidth As Integer = My.Computer.Screen.WorkingArea.Size.Width
        Dim monitorHeight As Integer = My.Computer.Screen.WorkingArea.Size.Height
        ' --- adjust size of this form ** this does NOT make consideration of DPI (eg. 125%, 150%) **
        Me.Width = monitorWidth / 2
        Me.Height = monitorHeight / 2
    End Sub

    Private Sub frmCounty_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        ' --- adjust size and location of Controls on this form
        If Not Me.WindowState = FormWindowState.Minimized Then
            Dim ScaleSize As New SizeF _
                (CSng((Me.ClientSize.Width / Me.originalSize.Width)),
                CSng((Me.ClientSize.Height / Me.originalSize.Height)))
            ' ---
            For Each ctrl As Control In Me.Controls
                If (TypeOf ctrl Is ListBox) Then
                    DirectCast(ctrl, ListBox).IntegralHeight = False
                End If
                Dim fntscl As Single = ctrl.Font.Size * ScaleSize.Height
                ctrl.Font = New Font(ctrl.Font.FontFamily, fntscl, ctrl.Font.Style, ctrl.Font.Unit)
                ctrl.Scale(ScaleSize)
            Next
            ' ---
            Me.originalSize = Me.ClientSize
        End If
        Me.Text = "AdjustFormSize : " & Me.Width & " x " & Me.Height
    End Sub
End Class