Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmWarehouses
    Dim y As Integer
    Private Sub AddWarehouse()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            If txtname.Text = "" Then
                MessageBox.Show("Please enter warehouse name", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtname.Focus()
                Return
            End If
            If txtaddress.Text = "" Then
                MessageBox.Show("Please enter warehouse address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtaddress.Focus()
                Return
            End If
            If txtlocation.Text = "" Then
                MessageBox.Show("Please enter warehouse location", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtlocation.Focus()
                Return
            End If
            If txtPhoneno.Text = "" Then
                MessageBox.Show("Please enter phone no", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtPhoneno.Focus()
                Return
            End If
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into tbl_warehouse(warehousename, Location, Contactperson, PhoneNo, Address) VALUES (@d1, @d2, @d3, @d4,@d5)"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtname.Text)
            cmd.Parameters.AddWithValue("@d2", txtlocation.Text)
            cmd.Parameters.AddWithValue("@d3", txtcontact.Text)
            cmd.Parameters.AddWithValue("@d4", txtPhoneno.Text)
            cmd.Parameters.AddWithValue("@d5", txtaddress.Text)
            dr = cmd.ExecuteReader
            MsgBox("Warehouse successfully added.", MsgBoxStyle.Information, "Added new warehouse")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table  txtQtyperUoM, 
        Audit_Trail(FrmMain.tsslUser.Text, txtname.Text, TimeOfDay, "Added New warehouse")
        Reset()
        txtname.Focus()
        Getdata()
    End Sub

    Private Sub UpdateWarehouse()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try

            If txtname.Text = "" Then
                MessageBox.Show("Please enter warehouse name", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtname.Focus()
                Return
            End If
            If txtaddress.Text = "" Then
                MessageBox.Show("Please enter warehouse address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtaddress.Focus()
                Return
            End If
            If txtlocation.Text = "" Then
                MessageBox.Show("Please enter warehouse location", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtlocation.Focus()
                Return
            End If
            If txtPhoneno.Text = "" Then
                MessageBox.Show("Please enter phone no", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtPhoneno.Focus()
                Return
            End If
            MysqlConn.Open()
            Dim Query As String
            'warehousename, Location, Contactperson, PhoneNo, Address
            Query = "UPDATE tbl_warehouse SET warehousename = @d1, Location= @d2, Contactperson = @d3, Address = @d4, PhoneNo = @d5 WHERE warehouseId = @d6"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtname.Text)
            cmd.Parameters.AddWithValue("@d2", txtlocation.Text)
            cmd.Parameters.AddWithValue("@d3", txtcontact.Text)
            cmd.Parameters.AddWithValue("@d4", txtaddress.Text)
            cmd.Parameters.AddWithValue("@d5", txtPhoneno.Text)
            cmd.Parameters.AddWithValue("@d6", txtwarehouseid.Text)
            dr = cmd.ExecuteReader
            MsgBox("Warehouse successfully Updated.", MsgBoxStyle.Information, "Update Warehouse")

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtwarehouseid.Text, TimeOfDay, "Updated Warehouse")
        Reset()
        txtname.Focus()
        Getdata()
    End Sub
    Private Sub frmWarehouses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getdata()
    End Sub

    Public Sub Getdata()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select warehouseId, warehousename, Address, Location, Contactperson, PhoneNo from tbl_warehouse"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5))
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
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            txtwarehouseid.Text = dr.Cells(0).Value.ToString()
            txtname.Text = dr.Cells(1).Value.ToString()
            txtaddress.Text = dr.Cells(2).Value.ToString()
            txtlocation.Text = dr.Cells(3).Value.ToString
            txtcontact.Text = dr.Cells(4).Value.ToString()
            txtPhoneno.Text = dr.Cells(5).Value.ToString()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AddWarehouse()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateWarehouse()
    End Sub

    Private Sub Reset()
        txtname.Text = ""
        txtlocation.Text = ""
        txtcontact.Text = ""
        txtPhoneno.Text = ""
        txtaddress.Text = ""
        txtwarehouseid.Text = ""
    End Sub
End Class