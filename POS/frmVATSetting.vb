Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class frmVATSetting
    Private Sub GetVATID()
        Try
            sqL = "SELECT VatNo FROM vat ORDER BY VatNo DESC"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtVATID.Text = dr("VatNo") + 1
            Else
                txtVATID.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub frmVATSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateVATNo()
        BtnUpdate.Enabled = False
    End Sub
    Private Sub frmVATSetting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub AddVAT()
        If txtVATRate.Text = "" Then
            MessageBox.Show("Please enter Vat Rate", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtVATRate.Focus()
            Return
        End If
        If txtVATCode.Text = "" Then
            MessageBox.Show("Please enter Vat Code", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtVATCode.Focus()
            Return
        End If
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO vat (VatRate, VatCode) values('" & txtVATRate.Text & "', '" & txtVATCode.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("VAT successfully added.", MsgBoxStyle.Information, "VAT Payment")
            txtVATID.Text = ""
            txtVATRate.Text = ""
            txtVATCode.Text = ""
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        restform()

    End Sub

    Private Sub BtnSaveExpenses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveVAT.Click
        AddVAT()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub LoadupdatesVAT()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT VatNo,VatRate,VatCode FROM vat WHERE VatNo = '" & cmdSearchItems.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            While (dr.Read)
                If dr IsNot Nothing Then
                    txtVATID.Text = dr.Item("VatNo")
                    txtVATRate.Text = dr.Item("VatRate")
                    txtVATCode.Text = dr.Item("VatCode")

                End If
            End While
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub UpdateVAT()
        If txtVATRate.Text = "" Then
            MessageBox.Show("Please enter Vat Rate", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtVATRate.Focus()
            Return
        End If
        If txtVATCode.Text = "" Then
            MessageBox.Show("Please enter Vat Code", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtVATCode.Focus()
            Return
        End If
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE vat SET VatRate = '" & txtVATRate.Text & "', VatCode = '" & txtVATCode.Text & "' WHERE  VatNo = '" & txtVATID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("VAT successfully Updated.", MsgBoxStyle.Information, "Update VAT")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        txtVATID.Text = ""
        txtVATRate.Text = ""
        txtVATCode.Text = ""
        restform()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        UpdateVAT()
    End Sub
    Private Sub PopulateVATNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM vat order by VatNo"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cmdSearchItems.Items.Clear()
            Do While dr.Read = True
                cmdSearchItems.Items.Add(dr("VatNo"))
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub cmdSearchItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdSearchItems.SelectedIndexChanged
        BtnSaveVAT.Enabled = False
        BtnUpdate.Enabled = True
        LoadupdatesVAT()
    End Sub
    Private Sub restform()
        txtVATID.Text = ""
        txtVATRate.Text = ""
        txtVATCode.Text = ""
        BtnSaveVAT.Enabled = True
        BtnUpdate.Enabled = False
    End Sub
End Class