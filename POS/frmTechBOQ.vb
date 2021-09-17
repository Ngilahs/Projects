Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Configuration
Public Class frmTechBOQ
    Dim y As Integer
    Private Sub Details_Enter(sender As Object, e As EventArgs) Handles Details.Enter

    End Sub

    Private Sub btnLoadSchemes_Click(sender As Object, e As EventArgs) Handles btnLoadSchemes.Click
        frmLoadShcmInfo.ShowDialog()
    End Sub

    Private Sub SchemeInstallation()
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
                .CommandText = "SELECT COUNT(*) FROM tbl_billingdetails WHERE SchemeID  = '" & txtSchemeID1.Text & "' and LineItemCompleted = 0"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                'MsgBox("Continue with Invoicing", MsgBoxStyle.Exclamation, "Meter installation statement!")
                chklineIteminvoiced.Checked = True
                chklineIteminvoiced.Enabled = False
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

    Private Sub SchemeInvoiced()
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
                .CommandText = "SELECT COUNT(*) FROM tbl_billingdetails WHERE SchemeID = '" & txtSchemeID1.Text & "' and LineItemCompleted = 1"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Scheme Line Installation Invoiced!", MsgBoxStyle.Exclamation, "Scheme Invoicing!")
                chklineIteminvoiced.Checked = False
                btnAddMeterItems.Enabled = False
                chklineIteminvoiced.CheckState = 0
                ResetForm()
                txtSchemeName1.Text = ""
                txtSchemeRefNo1.Text = ""
                txtSchemeID1.Text = ""
                txtSubcontractor.Text = ""
                txtTXNo1.Text = ""
                txtCounty1.Text = ""
                txtConstituencyname1.Text = ""
                txtConstituencyname1.Text = ""
                txtCounty1.Text = ""
                txtVatNo.Text = ""
                txtVatRate.Text = ""
                cboVat.Text = ""
                LoadVatno()
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
    Private Sub CheckMeterInstallationComplete()
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
                'MsgBox("Meter BOQ not Invoiced!", MsgBoxStyle.Exclamation, "Sub-contractor BOQs!")
                chkMeterinvoiced.Checked = False
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub MeterInstallationCompleted()
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
                .CommandText = "SELECT COUNT(*) FROM tbl_billingdetails WHERE SchemeID  = '" & txtSchemeID1.Text & "' and MeteringCompleted = 1"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                'MsgBox("Meter BOQ Invoiced!", MsgBoxStyle.Exclamation, "Sub-contractor BOQs!")
                chkMeterinvoiced.Checked = True
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub ResetForm()
        dgw.Rows.Clear()
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
        cboSubcontractor.Text = ""
        txtCounty1.Text = ""
        txtConstituencyname1.Text = ""
        PSaveToolStripButton.Enabled = False
        txtVatNo.Text = ""
        txtVatRate.Text = ""
        cboVat.Text = ""
        LoadVatno()
    End Sub
    Private Sub btnLoadSubcontractor_Click(sender As Object, e As EventArgs) Handles btnLoadSubcontractor.Click
        frmLoadSubcontractors.ShowDialog()
    End Sub
    ' Load Items to datagrid
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
            Query = "SELECT ItemNo, Description, UoM, UnitRate, subcatID from tbl_billingparameters where subcatID = 5"
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
        PopulatedgwMeterInstallationItems()
        PSaveToolStripButton.Enabled = True
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
            Query = "Select S.SchemeNo, S.Scheme_Ref_No, S.Scheme_Name, S.County_Id, S.Constituency_Id, S.No_of_Customers, S.Substation_No, CY.County_Name, CN.constituency_Name from schemes S Inner Join county CY on (S.County_Id = CY.County_No) Inner Join constituency CN on (S.Constituency_Id = CN.Constituency_No) where S.Scheme_Ref_No = '" & txtSchemeRefNo1.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            If dr.Read = True Then
                txtConstituencyID1.Text = dr("Constituency_Id")
                txtConstituencyname1.Text = dr("constituency_Name")
                txtCounty1.Text = dr("County_Name")
                txtCountyID1.Text = dr("County_Id")
                txtSchemeName1.Text = dr("Scheme_Name")
                txtSchemeID1.Text = dr("SchemeNo")
                txtTXNo1.Text = dr("Substation_No")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub txtSchemeID1_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeID1.TextChanged
        SchemeInstallation()
        SchemeInvoiced()
        CheckMeterInstallationComplete()
        MeterInstallationCompleted()
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
    Private Sub dgw_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellEndEdit
        dgw.CurrentRow.Cells(5).Value = dgw.CurrentRow.Cells(3).Value.ToString() * dgw.CurrentRow.Cells(4).Value
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
    Private Sub txtSchemeRefNo1_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeRefNo1.TextChanged
        LoadSchemedetails()
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
            Query = "INSERT INTO tbl_billingdetails(Sub_contractorID, SchemeID, CountyID, ConstituencyID, BillingDate, SchemeRefNo, TXNo, Createdby, Workstation, MeteringCompleted, TotalAmt, Approved, Approvedby, Cancelled, Cancelledby, TotalVat, TotalIncVat, LineItemCompleted) VALUES ('" & txtSubcontractor.Text & "', '" & txtSchemeID1.Text & "', '" & txtCountyID1.Text & "', '" & txtConstituencyID1.Text & "', '" & lbldate.Text & "', '" & txtSchemeRefNo1.Text & "', '" & txtTXNo1.Text & "', '" & FrmMain.tsslUser.Text & "', '" & FrmMain.LBLComputerName.Text & "', '" & chkMeterinvoiced.CheckState & "', '" & lblTotalAmt.Text & "', '" & txtNil.Text & "','" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & lblVat.Text & "', '" & lblTotalincvat.Text & "', '" & chklineIteminvoiced.CheckState & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtSchemeRefNo1.Text, TimeOfDay, "Added new Technician Statement")
    End Sub

    Private Sub frmTechBOQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVatno()
        txtNil.Text = "0"
        PSaveToolStripButton.Enabled = False
        txtVatRate.Text = cboVat.Text
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
            Query = "UPDATE tbl_billingdetails SET MeteringCompleted = '" & chkMeterinvoiced.CheckState & "' where  SchemeID = '" & txtSchemeID1.Text & "'"
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
        chklineIteminvoiced.Checked = True
        InsertBillingDetails()
        InsertBillingItems()
        If chkMeterinvoiced.Checked = True Then
            UpdateMeterInstallation()
        End If
        If chkMeterinvoiced.Checked = False Then
            UpdateMeterInstallation()
        End If
        ResetForm()
        MsgBox("Line Installation Statement Successfully Created", MsgBoxStyle.Information, "Line Installation Invoice")
    End Sub

    Private Sub ClearToolStripButton_Click(sender As Object, e As EventArgs) Handles ResetFormToolStripButton.Click
        ResetForm()
    End Sub

    Private Sub cboVat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVat.SelectedIndexChanged
        LoadVATRate()
        txtVatRate.Text = cboVat.Text
    End Sub
End Class