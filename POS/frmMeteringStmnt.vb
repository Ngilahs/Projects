Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Configuration
Public Class frmMeteringStmnt
    Dim y As Integer
    Private Sub btnLoadSubcontractor_Click(sender As Object, e As EventArgs) Handles btnLoadSubcontractor.Click
        frmLoadSubcontractors.ShowDialog()
    End Sub
    Private Sub btnLoadSchemes_Click(sender As Object, e As EventArgs) Handles btnLoadSchemes.Click
        frmLoadMaterials.ShowDialog()
    End Sub
    Private Sub MeterInstallation()
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
                .CommandText = "SELECT COUNT(*) FROM tbl_billingdetails WHERE SchemeID  = '" & txtSchemeID1.Text & "' and MeteringCompleted = 0"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                'MsgBox("Continue with Invoicing", MsgBoxStyle.Exclamation, "Meter installation statement!")
                chkMeterDone.Checked = True
                chkMeterDone.Enabled = False
                btnAddMeterItems.Enabled = True
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub MeterInvoiced()
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
                .CommandText = "SELECT COUNT(*) FROM tbl_billingdetails WHERE SchemeID = '" & txtSchemeID1.Text & "' and MeteringCompleted = 1"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Scheme Meter Installation Invoiced!", MsgBoxStyle.Exclamation, "Meter Installation Invoice!")
                chkMeterDone.Checked = False
                btnAddMeterItems.Enabled = False
                chkMeterDone.CheckState = 0
                txtSchemeName1.Text = ""
                txtSchemeRefNo1.Text = ""
                txtSchemeID1.Text = ""
                txtSubcontractor.Text = ""
                txtTXNo1.Text = ""
                txtCounty1.Text = ""
                txtConstituencyname1.Text = ""
                txtConstituencyname1.Text = ""
                txtCounty1.Text = ""
                btnAddMeterItems.Enabled = True
                txtVatNo.Text = ""
                txtVatRate.Text = ""
                cboVat.Text = ""
                LoadVatno()
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Public Sub CountMetersInstalled()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                    tbl_billingdetails.BillingdetailID,
                    tbl_billingdetails.SchemeID,
                    tbl_billingitems.BillingID,
                    tbl_billingitems.ItemNo,
                    Sum(tbl_billingitems.Qty) as Qty
                    FROM
                    tbl_billingdetails
                    INNER Join tbl_billingitems ON tbl_billingitems.BillingID = tbl_billingdetails.BillingdetailID WHERE SchemeID = @d1 And ItemNo = 32"

            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID1.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty").Equals(DBNull.Value) Then
                    txtmeterinstalled.Text = 0
                Else
                    txtmeterinstalled.Text = dr("Qty")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub btnAddMeterItems_Click(sender As Object, e As EventArgs) Handles btnAddMeterItems.Click
        If txtSchemeID1.Text = "" Then
            MessageBox.Show("Please enter Scheme Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtSubcontractor.Text = "" Then
            MessageBox.Show("Please enter Sub-contractor Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtVatNo.Text = "" Then
            MessageBox.Show("Please select Vatrate", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        txtBal.Text = Val(txtCustomerNo.Text) - Val(txtmeterinstalled.Text)
        CheckBalance()
        PSaveToolStripButton.Enabled = True
    End Sub
    Private Sub CheckBalance()
        If Val(txtBal.Text) = 0 Then
            MsgBox("Scheme Meter Installation is fully invoiced")
            ResetForm()
        Else
            PopulatedgwMeterInstallationItems()
        End If
    End Sub
    Private Sub PopulatedgwMeterInstallationItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Dim qty As Decimal = 0.00
        Dim Total As Decimal = 0.00
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ItemNo, Description, UoM, UnitRate, subcatID from tbl_billingparameters where subcatID = 4"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), Format(qty, "#,##0.00"), Format(Total, "#,##0.00"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        dgw.CurrentRow.Cells(4).Selected = True
    End Sub
    Private Sub txtSchemeID_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeID1.TextChanged
        MeterInstallation()
        MeterInvoiced()
        CountMetersInstalled()
    End Sub
    Private Sub CheckMeterInstallationComplete()
        Dim Meterstoinstall As Decimal
        Meterstoinstall = Val(dgw.Rows(0).Cells(4).Value)
        If Meterstoinstall > Val(txtBal.Text) Then
            MsgBox("Meter to Install cannot be greater than target customers")
            dgw.Rows(0).Cells(4).Value = 0.00
            dgw.Rows(0).Cells(5).Value = 0.00
        End If
    End Sub
    Private Sub confirmallmetersinstalled()
        Dim MetersInstalled As Decimal
        MetersInstalled = Val(dgw.Rows(0).Cells(4).Value)
        If MetersInstalled = txtCustomerNo.Text Then
            chkallmetersinstalled.Checked = True
        End If
        If MetersInstalled < txtCustomerNo.Text Then
            chkallmetersinstalled.Checked = False
        End If
        If txtCustomerNo.Text = MetersInstalled + Val(txtmeterinstalled.Text) Then
            chkallmetersinstalled.Checked = True
        End If
    End Sub
    Private Sub chkEnableschemes_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableschemes.CheckedChanged
        If chkEnableschemes.Checked = True Then
            btnLoadSchemes.Enabled = True
        End If
    End Sub
    Private Sub getqty()
        Dim TotAmt As Decimal
        'Dim Vat As Decimal = 0.16
        Dim Totvat As Decimal
        Dim TotalIncVat As Decimal
        For r = 0 To dgw.Rows.Count - 1
            TotAmt += dgw.Rows(r).Cells(5).Value
            lblTotalAmt.Text = Format(TotAmt, "#,##0.00")
            Totvat = TotAmt * Val(txtVatRate.Text)
            TotalIncVat = TotAmt + Totvat
            lblVat.Text = Format(Totvat, "#,##0.00")
            lblTotalincvat.Text = Format(TotalIncVat, "#,##0.00")
        Next
    End Sub
    'Save Billing Items
    Private Sub InsertBillingItems()
        For Each r As DataGridViewRow In dgw.Rows
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Insert into tbl_billingitems (BillingID, ItemNo, Qty, Total, Billingdate) VALUES ((Select MAX(BillingdetailID) from tbl_billingdetails),'" & (r.Cells(0).Value) & "', '" & r.Cells(4).Value & "', '" & r.Cells(5).Value & "', '" & lbldate.Text & "')"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Next
    End Sub
    'Save Billing Details
    Private Sub InsertBillingDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_billingdetails(Sub_contractorID, SchemeID, CountyID, ConstituencyID, BillingDate, SchemeRefNo, TXNo, Createdby, Workstation, MeteringCompleted, TotalAmt, Approved, Approvedby, Cancelled, Cancelledby, TotalVat, TotalIncVat) VALUES ('" & txtSubcontractor.Text & "', '" & txtSchemeID1.Text & "', '" & txtCountyID1.Text & "', '" & txtConstituencyID1.Text & "', '" & lbldate.Text & "', '" & txtSchemeRefNo1.Text & "', '" & txtTXNo1.Text & "', '" & FrmMain.tsslUser.Text & "', '" & FrmMain.LBLComputerName.Text & "', '" & chkallmetersinstalled.CheckState & "', '" & lblTotalAmt.Text & "', '" & txtNil.Text & "','" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & lblVat.Text & "', '" & lblTotalincvat.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, LblBillNo.Text, TimeOfDay, "Added new meter installation invoice")
    End Sub
    Private Sub ResetForm()
        dgw.Rows.Clear()
        LblBillNo.Text = "##########"
        txtSubcontractor.Text = ""
        txtSchemeID1.Text = ""
        txtCountyID1.Text = ""
        txtConstituencyID1.Text = ""
        lbldate.Text = ""
        txtSchemeRefNo1.Text = ""
        txtTXNo1.Text = ""
        lblTotalAmt.Text = "++++++++++"
        txtCounty1.Text = ""
        txtConstituencyname1.Text = ""
        txtSchemeName1.Text = ""
        lblVat.Text = "+++++++++++"
        lblTotalincvat.Text = "+++++++++++"
        txtCustomerNo.Text = ""
        txtmeterinstalled.Text = ""
        chkMeterDone.CheckState = 0
        chkallmetersinstalled.Checked = False
        chkEnableschemes.Enabled = True
        cboSubcontractor.Text = ""
        txtBal.Text = ""
        txtCustomerNo.Text = ""
        txtCounty1.Text = ""
        txtConstituencyname1.Text = ""
        PSaveToolStripButton.Enabled = False
        txtVatNo.Text = ""
        txtVatRate.Text = ""
        cboVat.Text = ""
        LoadVatno()
    End Sub

    Private Sub CloseToolStripLabel_Click(sender As Object, e As EventArgs) Handles CloseToolStripLabel.Click
        Me.Close()
    End Sub
    Private Sub ClearToolStripButton_Click(sender As Object, e As EventArgs) Handles ClearToolStripButton.Click
        chkMeteringcomplete.Enabled = False
        btnAddMeterItems.Enabled = True
        chkMeteringcomplete.CheckState = 0
        ResetForm()
        dgw.Rows.Clear()
    End Sub
    Private Sub UpdateMeterInstallation()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE tbl_billingdetails SET MeteringCompleted = 1 where  SchemeID = '" & txtSchemeID1.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub PSaveToolStripButton_Click(sender As Object, e As EventArgs) Handles PSaveToolStripButton.Click
        confirmallmetersinstalled()
        InsertBillingDetails()
        InsertBillingItems()
        If chkallmetersinstalled.Checked = True Then
            UpdateMeterInstallation()
        End If
        ResetForm()
        MsgBox("New Meter Installation statement successfully created", MsgBoxStyle.Information, "Meter Installation Invoice")
    End Sub

    Private Sub LoadVatno()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT VatNo,VatRate,VatCode from vat ORDER BY VatRate"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboVat.Items.Clear()
            Do While dr.Read = True
                cboVat.Items.Add(dr("VatRate"))
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadVATRate()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT VatNo,VatRate,VatCode FROM vat WHERE VatRate = '" & cboVat.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            While (dr.Read)
                If dr IsNot Nothing Then
                    txtVatNo.Text = dr.Item("VatNo")
                End If
            End While
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmMeteringStmnt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVatno()
        PSaveToolStripButton.Enabled = False
        txtNil.Text = 0
    End Sub

    Private Sub dgw_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellEndEdit
        dgw.CurrentRow.Cells(5).Value = dgw.CurrentRow.Cells(3).Value.ToString() * dgw.CurrentRow.Cells(4).Value
        CheckMeterInstallationComplete()
        getqty()
    End Sub
    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgw.EditingControlShowing
        If dgw.CurrentCell.ColumnIndex = 4 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
    End Sub

    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If (Not Char.IsControl(e.KeyChar) _
                AndAlso (Not Char.IsDigit(e.KeyChar) _
                AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnCheckMeters_Click(sender As Object, e As EventArgs)
        confirmallmetersinstalled()
    End Sub
    Private Sub cboVat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVat.SelectedIndexChanged
        LoadVATRate()
        txtVatRate.Text = cboVat.Text
    End Sub
End Class