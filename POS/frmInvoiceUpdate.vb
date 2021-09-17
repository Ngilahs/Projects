Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmInvoiceUpdate
    Dim y As Integer
    Public isAdministrator As Boolean
    Private Sub LoadSubcontractors()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select subcontractors_ID,subcontractor_Name from tbl_subcontractors"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboSubcontractor.Items.Clear()
            Do While dr.Read = True
                cboSubcontractor.Items.Add(dr("subcontractor_Name"))
                cboSubcontractor.Text = "Sub-contractor"
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
            Query = "Select subcontractors_ID,subcontractor_Name from tbl_subcontractors where subcontractor_Name = '" & cboSubcontractor.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtSubcontractor.Text = dr("subcontractors_ID")

            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT Description from tbl_billingparameters ORDER BY Description DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cmdSearchItems.Items.Clear()
            Do While dr.Read = True
                cmdSearchItems.Items.Add(dr("Description"))
                cmdSearchItems.Text = "Description"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PopulateItemCodeTextboxes()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ItemNo, Description, UoM, UnitRate from tbl_billingparameters where Description = '" & cmdSearchItems.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtItemCode.Text = dr("ItemNo")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub PopulateTextboxbasedonItemNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ItemNo, Description, UoM, UnitRate from tbl_billingparameters where ItemNo = '" & txtItemCode.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtunitrt.Text = dr("UnitRate")
                txtUnitofIssue.Text = dr("UoM")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadInvoices()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT tbl_billingdetails.BillingdetailID, tbl_billingdetails.Sub_contractorID, tbl_billingdetails.SchemeID, schemes.Scheme_Name, tbl_subcontractors.subcontractor_Name, tbl_billingdetails.Approved, tbl_billingdetails.Cancelled FROM
            tbl_billingdetails INNER Join tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = tbl_billingdetails.Sub_contractorID
            INNER Join schemes ON schemes.SchemeNo = tbl_billingdetails.SchemeID where tbl_billingdetails.Cancelled = '1'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw1.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw1.Rows.Add(dr("BillingdetailID"), dr("Scheme_Name"), dr("subcontractor_Name"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmInvoiceUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInvoices()
        LoadSubcontractors()
        'LoadItems()
        btnUpdate.Enabled = False
        txtNil.Text = 0
        txtUsername.Text = "administrator"
        txtapprove.Text = 0
        txtcancel.Text = 1
        txtUsername.Enabled = False
        grpboxenablestatementno.Enabled = False
        btnEnablestatement.Enabled = False
        LoadVatno()
        btnUpdate.Enabled = False
    End Sub

    Private Sub LoadInvoicesDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT tbl_billingdetails.BillingdetailID, tbl_billingdetails.Sub_contractorID, tbl_billingdetails.SchemeID, tbl_billingdetails.CountyID,tbl_billingdetails.ConstituencyID,
            tbl_billingdetails.BillingDate, tbl_billingdetails.SchemeRefNo, tbl_billingdetails.TXNo, tbl_billingdetails.Createdby, tbl_billingdetails.Workstation, tbl_billingdetails.TotalAmt,
            tbl_billingdetails.TotalVat, tbl_billingdetails.TotalIncVat, tbl_subcontractors.subcontractor_Name, schemes.Scheme_Name, county.County_Name, constituency.constituency_Name
            FROM tbl_billingdetails INNER JOIN tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = tbl_billingdetails.Sub_contractorID INNER JOIN schemes ON schemes.SchemeNo = tbl_billingdetails.SchemeID
            INNER JOIN county ON county.County_No = tbl_billingdetails.CountyID INNER JOIN constituency ON constituency.Constituency_No = tbl_billingdetails.ConstituencyID where tbl_billingdetails.BillingdetailID = '" & dgw1.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            'dgw1.Rows.Clear()
            Do While dr.Read = True
                LblBillNo.Text = dr("BillingdetailID")
                txtTXNo.Text = dr("TXNo")
                txtSchemeName.Text = dr("Scheme_Name")
                txtCounty.Text = dr("County_Name")
                txtConstituencyname.Text = dr("constituency_Name")
                lblVat.Text = dr("TotalVat")
                txtUsername.Text = dr("Createdby")
                cboSubcontractor.Text = dr("subcontractor_Name")
                lblTotalAmt.Text = dr("TotalAmt")
                txtSchemeID.Text = dr("SchemeId")
                txtConstituencyID.Text = dr("ConstituencyId")
                txtCountyID.Text = dr("CountyId")
                lblTotalincvat.Text = dr("TotalIncVat")
                txtSchemeRefNo.Text = dr("SchemeRefNo")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub LoadInvoiceItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT tbl_billingitems.BillingID, tbl_billingitems.ItemNo, tbl_billingitems.Qty, tbl_billingitems.Total, tbl_billingitems.Billingdate, tbl_billingparameters.Description, tbl_billingparameters.UnitRate, tbl_billingparameters.UoM, tbl_billingitems.billingitemno
            FROM tbl_billingitems INNER JOIN tbl_billingparameters ON tbl_billingparameters.ItemNo = tbl_billingitems.ItemNo where tbl_billingitems.BillingID = '" & LblBillNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("BillingID"), dr("ItemNo"), dr("Description"), dr("UoM"), dr("UnitRate"), dr("Qty"), dr("Total"), dr("billingitemno"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        Calculateaftervoid()
    End Sub

    Private Sub dgw1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw1.CellContentClick
        LoadInvoicesDetails()
        LoadInvoiceItems()
    End Sub

    Private Sub dgw_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellDoubleClick
        Dim subtotal As Decimal
        Dim subvat As Decimal
        Dim subtotvat As Decimal
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            'LblBillNo.Text = dr.Cells(0).Value.ToString()
            txtItemCode.Text = dr.Cells(1).Value.ToString()
            cmdSearchItems.Text = dr.Cells(2).Value.ToString()
            txtUnitofIssue.Text = dr.Cells(3).Value.ToString()
            txtunitrt.Text = dr.Cells(4).Value.ToString()
            txtqtyinvoiced.Text = dr.Cells(5).Value.ToString()
            txtTotal.Text = dr.Cells(6).Value.ToString()
            txtBillingItemNo.Text = dr.Cells(7).Value.ToString()
            btnUpdate.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'dgw.Rows.Remove(dgw.CurrentRow)
        subtotal = lblTotalAmt.Text - txtTotal.Text
        lblTotalAmt.Text = Format(subtotal, "#,##0.00")
        subvat = 0.16 * subtotal
        lblVat.Text = Format(subvat, "#,##0.00")
        subtotvat = subtotal + subvat
        lblTotalincvat.Text = Format(subtotvat, "#,##0.00")
    End Sub

    Private Sub UpdateInvoiceItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try

            If txtItemCode.Text = "" Then
                MessageBox.Show("Please select Item Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtItemCode.Focus()
                Return
            End If
            If cmdSearchItems.Text = "" Then
                MessageBox.Show("Please select Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmdSearchItems.Focus()
                Return
            End If
            If txtrevisedQty.Text = "" Then
                MessageBox.Show("Please enter quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtrevisedQty.Focus()
                Return
            End If
            MysqlConn.Open()
            Dim Query As String
            'ItemNo, Description, UoM, UnitRate, DateCreated
            Query = "UPDATE tbl_billingitems SET Qty = '" & txtrevisedQty.Text & "', Total = '" & txtTotal.Text & "' WHERE ItemNo = '" & txtItemCode.Text & "' and BillingID = '" & LblBillNo.Text & "' and billingitemno = '" & txtBillingItemNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Invoice Item successfully Updated.", MsgBoxStyle.Information, "Update Invoice Item")

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtItemCode.Text, TimeOfDay, "Updated Item")
        Reset()
        getData()
    End Sub
    ' Insert Billing Items not in Invoice
    Private Sub InsertBillingItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Insert into tbl_billingitems (BillingID, ItemNo, Qty, Total, Billingdate) VALUES (" & LblBillNo.Text & ", '" & txtItemCode.Text & "', '" & txtrevisedQty.Text & "', '" & txtTotal.Text & "', '" & lbldate.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    'Update Billing Details after invoicing
    Private Sub UpdateInvoiceDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try

            If txtItemCode.Text = "" Then
                MessageBox.Show("Please select Item Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtItemCode.Focus()
                Return
            End If
            If cmdSearchItems.Text = "" Then
                MessageBox.Show("Please select Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmdSearchItems.Focus()
                Return
            End If
            If txtrevisedQty.Text = "" Then
                MessageBox.Show("Please enter quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtqtyinvoiced.Focus()
                Return
            End If
            MysqlConn.Open()
            Dim Query As String
            'ItemNo, Description, UoM, UnitRate, DateCreated
            Query = "UPDATE tbl_billingdetails SET TotalAmt = '" & lblTotalAmt.Text & "', TotalIncVat = '" & lblTotalincvat.Text & "', TotalVat = '" & lblVat.Text & "', Approved = '" & txtNil.Text & "', Approvedby ='" & txtNil.Text & "', Cancelled = '" & txtNil.Text & "', Cancelledby = '" & txtNil.Text & "' WHERE BillingdetailID = '" & LblBillNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            'MsgBox("Item successfully Updated.", MsgBoxStyle.Information, "Update Item")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtItemCode.Text, TimeOfDay, "Updated Item")
        Reset()
        getData()
    End Sub
    Private Sub cboSubcontractor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubcontractor.SelectedIndexChanged
        LoadSubcontractorID()
    End Sub

    Private Sub btnLoadSchemes_Click(sender As Object, e As EventArgs) Handles btnLoadSchemes.Click
        frmLoadMaterials.ShowDialog()
    End Sub

    Private Sub cmdSearchItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdSearchItems.SelectedIndexChanged
        PopulateItemCodeTextboxes()
        PopulateTextboxbasedonItemNo()
    End Sub
    Public Sub dropDuplicateRows()
        For intI As Integer = dgw.Rows.Count - 1 To 0 Step -1
            For intJ As Integer = dgw.Rows.Count - 1 To intI + 1 Step -1
                If dgw.Rows(intI).Cells(0).Value = dgw.Rows(intJ).Cells(0).Value Then
                    dgw.Rows.RemoveAt(intJ)
                    btnUpdate.Enabled = True
                    MsgBox("Invoice item already exists", MsgBoxStyle.Exclamation, "Invoice items!")
                    Exit Sub
                End If
            Next intJ
        Next intI
    End Sub
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        If txtItemCode.Text = "" Then
            MessageBox.Show("Please select Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtItemCode.Focus()
            Return
        End If
        If cmdSearchItems.Text = "" Then
            MessageBox.Show("Please select Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            cmdSearchItems.Focus()
            Return
        End If
        If txtVatNo.Text = "" Then
            MessageBox.Show("Please select Vatrate", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim MVWPPoles As Decimal
        Dim MVCPPoles As Decimal
        Dim LVWPPoles As Decimal
        Dim LVCPPoles As Decimal
        Dim Mvconductor As Decimal
        Dim Lvconductor As Decimal
        Dim Lvstayrod As Decimal
        Dim Mvstayrod As Decimal
        Dim PME As Decimal
        'MVWPPoles = Val(dgw.Rows(4).Cells(4).Value) + Val(dgw.Rows(5).Cells(4).Value) + Val(dgw.Rows(12).Cells(4).Value)
        'MVCPPoles = Val(dgw.Rows(6).Cells(4).Value) + Val(dgw.Rows(7).Cells(4).Value)
        'LVWPPoles = Val(dgw.Rows(15).Cells(4).Value) + Val(dgw.Rows(16).Cells(4).Value) + Val(dgw.Rows(23).Cells(4).Value)
        'LVCPPoles = Val(dgw.Rows(17).Cells(4).Value) + Val(dgw.Rows(18).Cells(4).Value)

        'If txtItemCode.Text = 5 Then
        If dgw.Rows(4).Cells(5).Selected = True Then
            MVWPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(5).Cells(5).Value) + Val(dgw.Rows(12).Cells(5).Value)
            If MVWPPoles <> txtMVWP.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        'If txtItemCode.Text = 6 Then
        If dgw.Rows(5).Cells(5).Selected = True Then
            MVWPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(4).Cells(5).Value) + Val(dgw.Rows(12).Cells(5).Value)
            If MVWPPoles <> txtMVWP.Text Then
                'If LVCPPoles <> txtLVCP.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        'If txtItemCode.Text = 7 Then
        If dgw.Rows(6).Cells(5).Selected = True Then
            MVCPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(7).Cells(5).Value)
            If MVCPPoles <> txtMVCP.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If
        'If txtItemCode.Text = 8 Then
        If dgw.Rows(7).Cells(5).Selected = True Then
            MVCPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(6).Cells(5).Value)
            If MVCPPoles <> txtMVCP.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        'If txtItemCode.Text = 14 Then
        If dgw.Rows(15).Cells(5).Selected = True Then
            LVWPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(16).Cells(5).Value) + Val(dgw.Rows(23).Cells(5).Value)
            If LVWPPoles <> txtWPLV.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        'If txtItemCode.Text = 15 Then
        If dgw.Rows(16).Cells(5).Selected = True Then
            LVWPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(15).Cells(5).Value) + Val(dgw.Rows(23).Cells(5).Value)
            If LVWPPoles <> txtWPLV.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        'If txtItemCode.Text = 16 Then
        If dgw.Rows(17).Cells(5).Selected = True Then
            LVCPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(18).Cells(5).Value)
            If LVCPPoles <> txtLVCP.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        'If txtItemCode.Text = 17 Then
        If dgw.Rows(18).Cells(5).Selected = True Then
            LVCPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(17).Cells(5).Value)
            If LVCPPoles <> txtLVCP.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        Mvconductor = Val(dgw.Rows(8).Cells(5).Value)
        Lvconductor = Val(dgw.Rows(19).Cells(5).Value)
        Mvstayrod = Val(dgw.Rows(9).Cells(5).Value) + Val(dgw.Rows(10).Cells(5).Value) + Val(dgw.Rows(11).Cells(5).Value)
        Lvstayrod = Val(dgw.Rows(20).Cells(5).Value) + Val(dgw.Rows(21).Cells(5).Value) + Val(dgw.Rows(22).Cells(5).Value)
        PME = Val(dgw.Rows(24).Cells(4).Value)

        If dgw.Rows(24).Cells(5).Selected = True Then
            If txtrevisedQty.Text <> txtPME.Text Then
                MessageBox.Show("Please reconcile PMEs to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If
        If dgw.Rows(9).Cells(5).Selected = True Then
            Mvstayrod = Val(txtrevisedQty.Text) + Val(dgw.Rows(10).Cells(5).Value) + Val(dgw.Rows(11).Cells(5).Value)
            If Mvstayrod <> txtMVstayrod.Text Then
                MessageBox.Show("Please reconcile MV Stays to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If
        If dgw.Rows(10).Cells(5).Selected = True Then
            Mvstayrod = Val(txtrevisedQty.Text) + Val(dgw.Rows(9).Cells(5).Value) + Val(dgw.Rows(11).Cells(5).Value)
            If Mvstayrod <> txtMVstayrod.Text Then
                MessageBox.Show("Please reconcile MV Stays to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If
        If dgw.Rows(11).Cells(5).Selected = True Then
            Mvstayrod = Val(txtrevisedQty.Text) + Val(dgw.Rows(9).Cells(5).Value) + Val(dgw.Rows(10).Cells(5).Value)
            If Mvstayrod <> txtMVstayrod.Text Then
                MessageBox.Show("Please reconcile MV Stays to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        'Lvstayrod = Val(dgw.Rows(20).Cells(5).Value) + Val(dgw.Rows(21).Cells(5).Value) + Val(dgw.Rows(22).Cells(5).Value)
        If dgw.Rows(20).Cells(5).Selected = True Then
            Lvstayrod = Val(txtrevisedQty.Text) + Val(dgw.Rows(21).Cells(5).Value) + Val(dgw.Rows(22).Cells(5).Value)
            If Lvstayrod <> txtLVStayRod.Text Then
                MessageBox.Show("Please reconcile LV Stays to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        If dgw.Rows(21).Cells(5).Selected = True Then
            Lvstayrod = Val(txtrevisedQty.Text) + Val(dgw.Rows(20).Cells(5).Value) + Val(dgw.Rows(22).Cells(5).Value)
            If Lvstayrod <> txtLVStayRod.Text Then
                MessageBox.Show("Please reconcile LV Stays to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        If dgw.Rows(22).Cells(5).Selected = True Then
            Lvstayrod = Val(txtrevisedQty.Text) + Val(dgw.Rows(20).Cells(5).Value) + Val(dgw.Rows(21).Cells(5).Value)
            If Lvstayrod <> txtLVStayRod.Text Then
                MessageBox.Show("Please reconcile LV Stays to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim TotalAmt As Decimal
        Dim SubTotAmt As Decimal
        'Dim Vat As Decimal = 0.16
        Dim Totvat As Decimal
        Dim TotalIncVat As Decimal
        TotalAmt = Val(txtrevisedQty.Text) * Val(txtunitrt.Text)
        txtTotal.Text = TotalAmt
        'lblTotalAmt.Text = Val(lblTotalAmt.Text) + Val(txtTotal.Text)
        SubTotAmt = lblTotalAmt.Text + TotalAmt
        lblTotalAmt.Text = Format(SubTotAmt, "#,##0.00")
        'Totvat = SubTotAmt * Vat
        Totvat = SubTotAmt * Val(txtVatRate.Text)
        TotalIncVat = SubTotAmt + Totvat
        lblVat.Text = Format(Totvat, "#,##0.00")
        lblTotalincvat.Text = Format(TotalIncVat, "#,##0.00")
        CheckSchemeInvoicedtoUpdate()
        CheckInvoicedtoInsert()
        btnUpdate.Enabled = True
    End Sub
    Private Sub getqty()
        Dim TotAmt As Decimal
        Dim Vat As Decimal = 0.16
        Dim Totvat As Decimal
        Dim TotalIncVat As Decimal
        lblTotalAmt.Text = Format(TotAmt, "#,##0.00")
        Totvat = TotAmt * Vat
        TotalIncVat = TotAmt + Totvat
        lblVat.Text = Format(Totvat, "#,##0.00")
        lblTotalincvat.Text = Format(TotalIncVat, "#,##0.00")
    End Sub
    Private Sub CheckSchemeInvoicedtoUpdate()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            'BillingID, ItemNo txtItemCode
            MysqlConn.Open()
            Dim Query As String
            cmd = New MySqlCommand(Query, MysqlConn)
            With cmd
                .Connection = MysqlConn
                .CommandText = "SELECT COUNT(*) FROM tbl_billingitems WHERE BillingID  = '" & LblBillNo.Text & "' and ItemNo = '" & txtItemCode.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Please click update button to post changes", MsgBoxStyle.Exclamation, "Update invoice!")
                btnUpdate.Enabled = True
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
    Private Sub CheckInvoicedtoInsert()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            'BillingID, ItemNo txtItemCode
            MysqlConn.Open()
            Dim Query As String
            cmd = New MySqlCommand(Query, MysqlConn)
            With cmd
                .Connection = MysqlConn
                .CommandText = "SELECT COUNT(*) FROM tbl_billingitems WHERE BillingID  = '" & LblBillNo.Text & "' and ItemNo = '" & txtItemCode.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) < 1 Then
                MsgBox("Please click insert button to save new invoice item", MsgBoxStyle.Exclamation, "Update invoice!")
                btnUpdate.Enabled = False
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
        'LblBillNo.Text = "##########"
        txtSubcontractor.Text = ""
        txtSchemeID.Text = ""
        txtCountyID.Text = ""
        txtConstituencyID.Text = ""
        lbldate.Text = ""
        txtSchemeRefNo.Text = ""
        txtTXNo.Text = ""
        'lblTotalAmt.Text = "++++++++++"
        txtCounty.Text = ""
        txtConstituencyname.Text = ""
        txtunitrt.Text = ""
        txtUnitofIssue.Text = ""
        txtItemCode.Text = ""
        txtSchemeName.Text = ""
        'lblVat.Text = "+++++++++++"
        'lblTotalincvat.Text = "+++++++++++"
        txtqtyinvoiced.Text = ""
        txtrevisedQty.Text = ""
        txtTotal.Text = ""
        txtVatNo.Text = ""
        txtVatRate.Text = ""
        cboVat.Text = ""
        LoadItems()
        LoadSubcontractors()
    End Sub
    Private Sub LoadInvoicesDetailsafterInsertorUpdate()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT tbl_billingdetails.BillingdetailID, tbl_billingdetails.Sub_contractorID, tbl_billingdetails.SchemeID, tbl_billingdetails.CountyID,tbl_billingdetails.ConstituencyID,
            tbl_billingdetails.BillingDate, tbl_billingdetails.SchemeRefNo, tbl_billingdetails.TXNo, tbl_billingdetails.Createdby, tbl_billingdetails.Workstation, tbl_billingdetails.TotalAmt,
            tbl_billingdetails.TotalVat, tbl_billingdetails.TotalIncVat, tbl_subcontractors.subcontractor_Name, schemes.Scheme_Name, county.County_Name, constituency.constituency_Name
            FROM tbl_billingdetails INNER JOIN tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = tbl_billingdetails.Sub_contractorID INNER JOIN schemes ON schemes.SchemeNo = tbl_billingdetails.SchemeID
            INNER JOIN county ON county.County_No = tbl_billingdetails.CountyID INNER JOIN constituency ON constituency.Constituency_No = tbl_billingdetails.ConstituencyID where tbl_billingdetails.BillingdetailID = '" & LblBillNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            'dgw1.Rows.Clear()
            Do While dr.Read = True
                txtTXNo.Text = dr("TXNo")
                txtSchemeName.Text = dr("Scheme_Name")
                txtCounty.Text = dr("County_Name")
                txtConstituencyname.Text = dr("constituency_Name")
                lblVat.Text = dr("TotalVat")
                txtUsername.Text = dr("Createdby")
                cboSubcontractor.Text = dr("subcontractor_Name")
                lblTotalAmt.Text = dr("TotalAmt")
                txtSchemeID.Text = dr("SchemeId")
                txtConstituencyID.Text = dr("ConstituencyId")
                txtCountyID.Text = dr("CountyId")
                lblTotalincvat.Text = dr("TotalIncVat")
                txtSchemeRefNo.Text = dr("SchemeRefNo")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs)
        InsertBillingItems()
        UpdateInvoiceDetails()
        ResetForm()
        LoadInvoices()
        LoadInvoicesDetailsafterInsertorUpdate()
        LoadInvoiceItems()
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateInvoiceItems()
        UpdateInvoiceDetails()
        ResetForm()
        LoadInvoices()
        LoadInvoicesDetailsafterInsertorUpdate()
        LoadInvoiceItems()
        btnUpdate.Enabled = False
    End Sub

    Private Sub txtInvoiceNo_TextChanged(sender As Object, e As EventArgs) Handles txtInvoiceNo.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT tbl_billingdetails.BillingdetailID, tbl_billingdetails.Sub_contractorID, tbl_billingdetails.SchemeID, schemes.Scheme_Name, tbl_subcontractors.subcontractor_Name, tbl_billingdetails.Approved, tbl_billingdetails.Cancelled FROM
            tbl_billingdetails INNER Join tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = tbl_billingdetails.Sub_contractorID
            INNER Join schemes ON schemes.SchemeNo = tbl_billingdetails.SchemeID where tbl_billingdetails.Cancelled = '0' and tbl_billingdetails.BillingdetailID LIKE '%" & txtInvoiceNo.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw1.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw1.Rows.Add(dr("BillingdetailID"), dr("Scheme_Name"), dr("subcontractor_Name"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub txtschmname_TextChanged(sender As Object, e As EventArgs) Handles txtschmname.TextChanged
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select tbl_billingdetails.BillingdetailID, tbl_billingdetails.Sub_contractorID, tbl_billingdetails.SchemeID, schemes.Scheme_Name, tbl_subcontractors.subcontractor_Name, tbl_billingdetails.Approved, tbl_billingdetails.Cancelled FROM
            tbl_billingdetails INNER Join tbl_subcontractors ON tbl_subcontractors.subcontractors_ID = tbl_billingdetails.Sub_contractorID
            INNER Join schemes ON schemes.SchemeNo = tbl_billingdetails.SchemeID where tbl_billingdetails.Cancelled = '0' and schemes.Scheme_Name LIKE '%" & txtschmname.Text & "%'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw1.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw1.Rows.Add(dr("BillingdetailID"), dr("Scheme_Name"), dr("subcontractor_Name"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Calculateaftervoid()
        Dim TotAmt As Decimal
        'Dim Vat As Decimal = 0.16
        Dim Totvat As Decimal
        Dim TotalIncVat As Decimal
        For r = 0 To dgw.Rows.Count - 1
            TotAmt += dgw.Rows(r).Cells(6).Value
            lblTotalAmt.Text = Format(TotAmt, "#,##0.00")
            'Totvat = TotAmt * Vat
            Totvat = TotAmt * Val(txtVatRate.Text)
            TotalIncVat = TotAmt + Totvat
            lblVat.Text = Format(Totvat, "#,##0.00")
            lblTotalincvat.Text = Format(TotalIncVat, "#,##0.00")
        Next
    End Sub

    Private Sub UpdateInvoiceDetailsaftervoid()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try

            If txtItemCode.Text = "" Then
                MessageBox.Show("Please select Item Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtItemCode.Focus()
                Return
            End If
            If cmdSearchItems.Text = "" Then
                MessageBox.Show("Please select Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmdSearchItems.Focus()
                Return
            End If
            MysqlConn.Open()
            Dim Query As String
            'ItemNo, Description, UoM, UnitRate, DateCreated
            Query = "UPDATE tbl_billingdetails SET TotalAmt = '" & lblTotalAmt.Text & "', TotalIncVat = '" & lblTotalincvat.Text & "', TotalVat = '" & lblVat.Text & "' WHERE BillingdetailID = '" & LblBillNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            'MsgBox("Item successfully Updated.", MsgBoxStyle.Information, "Update Item")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtItemCode.Text, TimeOfDay, "Delete Item from Invoice Items")
    End Sub
    'BillingID, ItemNo
    Private Sub DeletefromInvoiceItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "delete from tbl_billingitems where ItemNo ='" & txtItemCode.Text & "' and BillingID = '" & LblBillNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub checkifitemexists()
        For intI As Integer = dgw.Rows.Count - 1 To 0 Step -1
            For intJ As Integer = dgw.Rows.Count - 1 To intI + 1 Step -1
                If txtItemCode.Text = dgw.Rows(intJ).Cells(1).Value Then
                    MsgBox("Invoice item already exists", MsgBoxStyle.Exclamation, "Invoice items!")
                    txtItemCode.Text = ""
                    cmdSearchItems.Text = ""
                    txtunitrt.Text = ""
                    txtUnitofIssue.Text = ""
                    LoadItems()
                    Return
                End If
            Next intJ
        Next intI
    End Sub
    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged

    End Sub

    Private Sub txtrevisedQty_TextChanged(sender As Object, e As EventArgs) Handles txtrevisedQty.TextChanged

    End Sub
    Private Sub txtrevisedQty_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtrevisedQty.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Resetform2()
        LblBillNo.Text = ""
        txtTXNo.Text = ""
        txtSchemeName.Text = ""
        txtCounty.Text = ""
        txtConstituencyname.Text = ""
        lblVat.Text = ""
        txtUsername.Text = ""
        cboSubcontractor.Text = ""
        lblTotalAmt.Text = ""
        txtSchemeID.Text = ""
        txtConstituencyID.Text = ""
        txtCountyID.Text = ""
        lblTotalincvat.Text = ""
        txtSchemeRefNo.Text = ""
        dgw.Rows.Clear()
    End Sub

    Private Sub Login()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If Len(Trim(txtUsername.Text)) = 0 Then
            MessageBox.Show("Please enter UserName", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If
        If Len(Trim(txtPassword.Text)) = 0 Then
            MessageBox.Show("Please enter Password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Exit Sub
            btnLogIn.Focus()
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM Staff WHERE Username = '" & txtUsername.Text & "' AND UPassword = '" & txtPassword.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then

                If LCase(dr("role")) = "administrator" Then
                    MsgBox("Enter StatementNo to Enable Update", MsgBoxStyle.Information, "Login")
                    grpboxenablestatementno.Enabled = True
                    btnEnablestatement.Enabled = True
                    isAdministrator = True
                End If
            Else
                MsgBox("Incorrect password.", MsgBoxStyle.Critical, "Login")
                txtPassword.SelectAll()
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, FrmMain.tsslUser.Text, TimeOfDay, "LoggedIn to enable statement update")
    End Sub

    Private Sub EnableUpdate()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'Update to enable update
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE tbl_billingdetails SET Approved = '" & txtapprove.Text & "', Cancelled = '" & txtcancel.Text & "'  WHERE BillingdetailID = '" & txtStatementNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MsgBox("Statement successfully Enabled.", MsgBoxStyle.Information, "Update Statement")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnEnablestatement_Click(sender As Object, e As EventArgs) Handles btnEnablestatement.Click
        EnableUpdate()
        LoadInvoices()
        grpboxenablestatementno.Enabled = False
        btnEnablestatement.Enabled = False
        txtStatementNo.Text = ""
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Login()
        txtPassword.Text = ""
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

    Private Sub cboVat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVat.SelectedIndexChanged
        LoadVATRate()
        txtVatRate.Text = cboVat.Text
    End Sub

    'Ten meter poles used 
    Public Sub Tenmeterpolesused()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        'Try
        MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where schemes.SchemeNo = @d1 and Item_No = 2134"
        cmd = New MySqlCommand(Query, MysqlConn)
        cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txtPolesInstalled.Text = 0
                Else
                    txtPolesInstalled.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MysqlConn.Dispose()
        'End Try
    End Sub
    '11 M poles used
    Public Sub Elevenmeterpolesused()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2212"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txt11MPoles.Text = 0
                Else
                    txt11MPoles.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    '12M Poles used
    Public Sub Twelvemeterpolesused()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2206"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txt12MPoles.Text = 0
                Else
                    txt12MPoles.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub TenmeterCPsused()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2199"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txt10MCP.Text = 0
                Else
                    txt10MCP.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    'Twelvemeterpolesused(), TenmeterCPsused(),  ElvenmeterCPsused()
    Public Sub ElvenmeterCPsused()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2204"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txt11MCP.Text = 0
                Else
                    txt11MCP.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub TenmeterCPsusedWithEarth()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2198"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txtCPWE.Text = 0
                Else
                    txtCPWE.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub MVConductor75MM()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2202"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txtMVConductor.Text = 0
                Else
                    txtMVConductor.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub LVConductor50MM()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2201"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txtLVConductor.Text = 0
                Else
                    txtLVConductor.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub LVStayRod()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2143"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txtLVStayRod.Text = 0
                Else
                    txtLVStayRod.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub MVStayRod()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2079"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txtMVstayrod.Text = 0
                Else
                    txtMVstayrod.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub LVStaywire()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2015"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txtLVstaywire.Text = 0
                Else
                    txtLVstaywire.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub MVStaywire()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2075"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txtMVstaywire.Text = 0
                Else
                    txtMVstaywire.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub PME()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2025"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txtPME.Text = 0
                Else
                    txtPME.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub StayInsulator()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select delivery_details.DeliveryNo, delivery_details.SchemeId,
                    delivery_items.Item_No,
                    product.ProductNo,
                    schemes.SchemeNo,
                    delivery_items.Delivery_No,
                    SUM(delivery_items.Qty_Issued) as Qty_Issued
                    FROM delivery_details
                    INNER Join delivery_items ON delivery_items.Delivery_No = delivery_details.DeliveryNo
                    INNER Join product ON delivery_items.Item_No = product.ProductNo
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2025"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", txtSchemeID.Text)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            If dr.Read = True Then
                If dr("Qty_Issued").Equals(DBNull.Value) Then
                    txtstayinsulator.Text = 0
                Else
                    txtstayinsulator.Text = dr("Qty_Issued")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub CompareMaterialIssued()
        Dim Mvconductor As Decimal
        Dim Lvconductor As Decimal
        Dim Lvstayrod As Decimal
        Dim Mvstayrod As Decimal
        Dim PME As Decimal
        Mvconductor = Val(dgw.Rows(8).Cells(4).Value)
        Lvconductor = Val(dgw.Rows(19).Cells(4).Value)
        Mvstayrod = Val(dgw.Rows(9).Cells(4).Value) + Val(dgw.Rows(10).Cells(4).Value) + Val(dgw.Rows(11).Cells(4).Value)
        Lvstayrod = Val(dgw.Rows(20).Cells(4).Value) + Val(dgw.Rows(21).Cells(4).Value) + Val(dgw.Rows(22).Cells(4).Value)
        PME = Val(dgw.Rows(24).Cells(4).Value)
        If PME <> txtPME.Text Then
            MsgBox("Please reconcile PMEs to continue!", MsgBoxStyle.Exclamation, "Invoicing!")
            dgw.Rows(24).Cells(4).Value = 0.00
            Exit Sub
        End If
        If Mvstayrod <> txtMVstayrod.Text Then
            MsgBox("Please reconcile MV Stays to continue!", MsgBoxStyle.Exclamation, "Invoicing!")
            dgw.Rows(9).Cells(4).Value = 0.00
            dgw.Rows(10).Cells(4).Value = 0.00
            dgw.Rows(11).Cells(4).Value = 0.00
            Exit Sub
        End If
        If Lvstayrod <> txtLVStayRod.Text Then
            MsgBox("Please reconcile LV Stays to continue!", MsgBoxStyle.Exclamation, "Invoicing!")
            dgw.Rows(20).Cells(4).Value = 0.00
            dgw.Rows(21).Cells(4).Value = 0.00
            dgw.Rows(22).Cells(4).Value = 0.00
            Exit Sub
        End If
    End Sub
    Private Sub computePolesissuedinscheme()
        txtWPLV.Text = txtPolesInstalled.Text
        txtLVCP.Text = Val(txt10MCP.Text) + Val(txtCPWE.Text)
        txtMVWP.Text = Val(txt11MPoles.Text) + Val(txt12MPoles.Text)
        txtMVCP.Text = Val(txt11MCP.Text) + Val(txt12MCP.Text)
    End Sub
    Private Sub txtSchemeID_TextChanged(sender As Object, e As EventArgs) Handles txtSchemeID.TextChanged
        Tenmeterpolesused()
        Elevenmeterpolesused()
        Twelvemeterpolesused()
        TenmeterCPsused()
        TenmeterCPsusedWithEarth()
        ElvenmeterCPsused()
        MVConductor75MM()
        LVConductor50MM()
        LVStayRod()
        MVStayRod()
        LVStaywire()
        MVStaywire()
        PME()
        computePolesissuedinscheme()
    End Sub
    'Pole Reconciliation
    Private Sub comparevalues()
        Dim MVWPPoles As Decimal
        Dim MVCPPoles As Decimal
        Dim LVWPPoles As Decimal
        Dim LVCPPoles As Decimal
        MVWPPoles = Val(dgw.Rows(4).Cells(4).Value) + Val(dgw.Rows(5).Cells(4).Value) + Val(dgw.Rows(12).Cells(4).Value)
        MVCPPoles = Val(dgw.Rows(6).Cells(4).Value) + Val(dgw.Rows(7).Cells(4).Value)
        LVWPPoles = Val(dgw.Rows(15).Cells(4).Value) + Val(dgw.Rows(16).Cells(4).Value) + Val(dgw.Rows(23).Cells(4).Value)
        LVCPPoles = Val(dgw.Rows(17).Cells(4).Value) + Val(dgw.Rows(18).Cells(4).Value)

        If txtItemCode.Text = 5 Then
            MVWPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(5).Cells(4).Value) + Val(dgw.Rows(12).Cells(4).Value)
            If MVWPPoles <> txtMVWP.Text Then
                'If LVWPPoles <> txtWPLV.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If
        If txtItemCode.Text = 6 Then
            MVWPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(4).Cells(4).Value) + Val(dgw.Rows(12).Cells(4).Value)
            If MVWPPoles <> txtMVWP.Text Then
                'If LVCPPoles <> txtLVCP.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        If txtItemCode.Text = 7 Then
            MVCPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(7).Cells(4).Value)
            If MVCPPoles <> txtMVCP.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If
        If txtItemCode.Text = 8 Then
            MVCPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(6).Cells(4).Value)
            If MVCPPoles <> txtMVCP.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        If txtItemCode.Text = 14 Then
            LVWPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(16).Cells(4).Value) + Val(dgw.Rows(23).Cells(4).Value)
            If LVWPPoles <> txtWPLV.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        If txtItemCode.Text = 15 Then
            LVWPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(15).Cells(4).Value) + Val(dgw.Rows(23).Cells(4).Value)
            If LVWPPoles <> txtWPLV.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        If txtItemCode.Text = 16 Then
            LVCPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(17).Cells(4).Value)
            If LVCPPoles <> txtLVCP.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If

        If txtItemCode.Text = 17 Then
            LVCPPoles = Val(txtrevisedQty.Text) + Val(dgw.Rows(18).Cells(4).Value)
            If LVCPPoles <> txtLVCP.Text Then
                MessageBox.Show("Please reconcile poles to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtrevisedQty.Text = 0.00
                Exit Sub
            End If
        End If



    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub
End Class