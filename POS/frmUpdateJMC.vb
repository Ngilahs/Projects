Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Configuration
Public Class frmUpdateJMC
    Dim y As Integer
    Private Sub frmUpdateJMC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadScheme()
        btnUpdateMeterDetails.Enabled = False
        btnDeleteMeterDetail.Enabled = False
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
    Private Sub LoadScheme()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                    schemes.SchemeNo,
                    schemes.Scheme_Ref_No,
                    schemes.Scheme_Name,
                    tbl_jmc.SchemeId,
                    tbl_jmc.JMCNo
                    FROM
                    schemes
                    INNER Join tbl_jmc ON tbl_jmc.SchemeId = schemes.SchemeNo"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboJMCNo.Items.Clear()
            Do While dr.Read = True
                cboJMCNo.Items.Add(dr("Scheme_Name"))
                cboJMCNo.Text = "Scheme name"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        MysqlConn.Close()
    End Sub
    Private Sub LoadSchemeInfo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                    schemes.SchemeNo,
                    schemes.Scheme_Ref_No,
                    schemes.Scheme_Name,
                    tbl_jmc.SchemeId,
                    tbl_jmc.JMCNo
                    FROM
                    schemes
                    INNER Join tbl_jmc ON tbl_jmc.SchemeId = schemes.SchemeNo where schemes.Scheme_Name = '" & cboJMCNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtSchemeID.Text = dr("SchemeNo")
                txtSchemeRefNo.Text = dr("Scheme_Ref_No")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        MysqlConn.Close()
    End Sub

    Private Sub txtSchemeRefNo_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeRefNo.TextChanged
        LoadSchemedetails()
        LoadJMC()
    End Sub
    Private Sub LoadJMC()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                    schemes.SchemeNo,
                    tbl_jmc.SchemeId,
                    tbl_jmcdetails.JMCDetailsNo,
                    tbl_jmcdetails.JMCNo,
                    tbl_jmc.JMCNo,
                    tbl_jmcdetails.PoleNo,
                    tbl_jmcdetails.PoleDesc,
                    tbl_jmcdetails.WP,
                    tbl_jmcdetails.CP,
                    tbl_jmcdetails.1PH,
                    tbl_jmcdetails.3PH,
                    tbl_jmcdetails.LVFittingWP,
                    tbl_jmcdetails.LVFittingCP,
                    tbl_jmcdetails.WPNStay,
                    tbl_jmcdetails.CPNStay,
                    tbl_jmcdetails.WPFStay,
                    tbl_jmcdetails.CPFStay,
                    tbl_jmcdetails.Strutstay,
                    tbl_jmcdetails.Dangerplate,
                    tbl_jmcdetails.Polecap,
                    tbl_jmcdetails.PME,
                    tbl_jmcdetails.Linetaps,
                    tbl_jmcdetails.1PHMeter,
                    tbl_jmcdetails.MCB,
                    tbl_jmcdetails.Meterbox,
                    tbl_jmcdetails.Universalclamps,
                    tbl_jmcdetails.Servicecable,
                    tbl_jmcdetails.servicecablefittings,
                    tbl_jmcdetails.EarthsetforRB,
                    tbl_jmcdetails.Readyboards
                    FROM
                    tbl_jmc
                    INNER JOIN tbl_jmcdetails ON tbl_jmcdetails.JMCNo = tbl_jmc.JMCNo
                    INNER JOIN schemes ON schemes.SchemeNo = tbl_jmc.SchemeId Where tbl_jmc.SchemeId = '" & txtSchemeID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgwz.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgwz.Rows.Add(dr(3), dr(2), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11), dr(12), dr(13), dr(14), dr(15), dr(16), dr(17), dr(18), dr(19), dr(20), dr(21), dr(22), dr(23), dr(24), dr(25), dr(26), dr(27), dr(28), dr(29))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub txtSchemeID_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeID.TextChanged
        'Dim MysqlConn As MySqlConnection
        'Dim cmd As MySqlCommand
        'MysqlConn = New MySqlConnection
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        'Dim dr As MySqlDataReader
        'Try
        '    MysqlConn.Open()
        '    Dim Query As String
        '    Query = "Select S.SchemeNo, S.Scheme_Ref_No, S.Scheme_Name, S.County_Id, S.Constituency_Id, S.No_of_Customers, S.Substation_No, CY.County_Name, CN.constituency_Name from schemes S Inner Join county CY on (S.County_Id = CY.County_No) Inner Join constituency CN on (S.Constituency_Id = CN.Constituency_No) where S.Scheme_Ref_No = '" & txtSchemeRefNo.Text & "'"
        '    cmd = New MySqlCommand(Query, MysqlConn)
        '    dr = cmd.ExecuteReader
        '    y = 0
        '    If dr.Read = True Then
        '        txtConstituencyID.Text = dr("Constituency_Id")
        '        txtConstituencyname.Text = dr("constituency_Name")
        '        txtCounty.Text = dr("County_Name")
        '        txtCountyID.Text = dr("County_Id")
        '        txtSchemeName.Text = dr("Scheme_Name")
        '        txtSchemeID.Text = dr("SchemeNo")
        '        txtTXNo.Text = dr("Substation_No")
        '    End If
        '    MysqlConn.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MysqlConn.Dispose()
        'End Try
    End Sub

    Private Sub cboJMCNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJMCNo.SelectedIndexChanged
        LoadSchemeInfo()
        LoadSchemedetails()
        LoadJMC()
    End Sub

    Private Sub dgwz_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwz.CellClick
        Dim i As Integer
        i = dgwz.CurrentRow.Index
        Me.txtJMCNo.Text = dgwz.Item(0, i).Value
        Me.txtJMCDetailNo.Text = dgwz.Item(1, i).Value
        Me.txtpoleno.Text = dgwz.Item(2, i).Value
        Me.txtPoleDescr.Text = dgwz.Item(3, i).Value
        Me.txtWP.Text = dgwz.Item(4, i).Value
        Me.txtCP.Text = dgwz.Item(5, i).Value
        Me.txt1PH.Text = dgwz.Item(6, i).Value
        Me.txt3PH.Text = dgwz.Item(7, i).Value
        Me.txtLVFittingWP.Text = dgwz.Item(8, i).Value
        Me.txtLVFittingCP.Text = dgwz.Item(9, i).Value
        Me.txtWPNStay.Text = dgwz.Item(10, i).Value
        Me.txtCPNStay.Text = dgwz.Item(11, i).Value
        Me.txtWPFStay.Text = dgwz.Item(12, i).Value
        ''''''''''''''''''''''''''''''''''''''''''
        Me.txtCPFStay.Text = dgwz.Item(13, i).Value
        Me.txtstrutstay.Text = dgwz.Item(14, i).Value
        Me.txtDangerplate.Text = dgwz.Item(15, i).Value
        Me.txtPoleCap.Text = dgwz.Item(16, i).Value
        Me.txtPME.Text = dgwz.Item(17, i).Value
        Me.txtLinetap.Text = dgwz.Item(18, i).Value
        Me.txt1PHMeter.Text = dgwz.Item(19, i).Value
        Me.txtMCB.Text = dgwz.Item(20, i).Value
        Me.txtMeterbox.Text = dgwz.Item(21, i).Value
        Me.txtUniversalClamps.Text = dgwz.Item(22, i).Value
        Me.txtServicecable.Text = dgwz.Item(23, i).Value
        Me.txtSCablefitting.Text = dgwz.Item(24, i).Value
        Me.txtEarthsetforRB.Text = dgwz.Item(25, i).Value
        Me.txtReadyBoards.Text = dgwz.Item(26, i).Value
        btnUpdateMeterDetails.Enabled = True
        btnDeleteMeterDetail.Enabled = True
        dgwz.Rows.Clear()
    End Sub

    Private Sub UpdateJMCDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update tbl_jmcdetails Set  PoleNo = '" & txtpoleno.Text & "', PoleDesc = '" & txtPoleDescr.Text & "', WP = '" & txtWP.Text & "', CP = '" & txtCP.Text & "', 1PH = '" & txt1PH.Text & "', 3PH = '" & txt3PH.Text & "', LVFittingWP = '" & txtLVFittingWP.Text & "', LVFittingCP = '" & txtLVFittingCP.Text & "', WPNStay = '" & txtWPNStay.Text & "', CPNStay = '" & txtCPNStay.Text & "', WPFStay = '" & txtWPFStay.Text & "', CPFStay = '" & txtCPFStay.Text & "', Strutstay = '" & txtstrutstay.Text & "',  Dangerplate = '" & txtDangerplate.Text & "', Polecap = '" & txtPoleCap.Text & "', PME = '" & txtPME.Text & "', Linetaps = '" & txtLinetap.Text & "', 1PHMeter = '" & txt1PHMeter.Text & "', MCB = '" & txtMCB.Text & "',  Meterbox = '" & txtMeterbox.Text & "', Universalclamps = '" & txtUniversalClamps.Text & "', Servicecable = '" & txtServicecable.Text & "', Servicecablefittings = '" & txtSCablefitting.Text & "', EarthsetforRB = '" & txtEarthsetforRB.Text & "', Readyboards = '" & txtReadyBoards.Text & "' where JMCNo = '" & txtJMCNo.Text & "' and JMCDetailsNo = '" & txtJMCDetailNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub btnLoadSchemes_Click(sender As Object, e As EventArgs) Handles btnLoadSchemes.Click
        frmLoadJMCScheme.ShowDialog()
    End Sub
    Private Sub UpdateJMCInformation()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update tbl_jmc set SchemeId = '" & txtSchemeID.Text & "' where JMCNo = '" & txtJMCNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnUpdateMeterDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateMeterDetails.Click
        UpdateJMCInformation()
        UpdateJMCDetails()
        btnUpdateMeterDetails.Enabled = False
        btnDeleteMeterDetail.Enabled = False
        Reset()
    End Sub
    Private Sub Reset()
        txtJMCNo.Text = ""
        txtJMCDetailNo.Text = ""
        txtpoleno.Text = ""
        txtPoleDescr.Text = ""
        txtWP.Text = ""
        txtCP.Text = ""
        txt1PH.Text = ""
        txt3PH.Text = ""
        txtLVFittingWP.Text = ""
        txtLVFittingCP.Text = ""
        txtWPNStay.Text = ""
        txtCPNStay.Text = ""
        txtWPFStay.Text = ""
        txtCPFStay.Text = ""
        txtstrutstay.Text = ""
        txtDangerplate.Text = ""
        txtPoleCap.Text = ""
        txtPME.Text = ""
        txtLinetap.Text = ""
        txt1PHMeter.Text = ""
        txtMCB.Text = ""
        txtMeterbox.Text = ""
        txtUniversalClamps.Text = ""
        txtServicecable.Text = ""
        txtSCablefitting.Text = ""
        txtEarthsetforRB.Text = ""
        txtReadyBoards.Text = ""
        txtSchemeName.Text = ""
        txtSchemeRefNo.Text = ""
        txtConstituencyname.Text = ""
        txtCounty.Text = ""
        txtTXNo.Text = ""
    End Sub
End Class