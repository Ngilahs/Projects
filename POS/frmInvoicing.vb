Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Configuration

Public Class frmInvoicing
    Dim y As Integer
    Private Sub LoadSchemedetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select S.SchemeNo, S.Scheme_Ref_No, S.Scheme_Name, S.County_Id, S.Constituency_Id, S.No_of_Customers, S.Substation_No, CY.County_Name, CN.constituency_Name from schemes S Inner Join county CY on (S.County_Id = CY.County_No) Inner Join constituency CN on (S.Constituency_Id = CN.Constituency_No) where S.Scheme_Ref_No = '" & SchemeRefNotxt.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            If dr.Read = True Then
                txtConstituencyID.Text = dr("Constituency_Id")
                txtConstituencyname.Text = dr("constituency_Name")
                txtCounty.Text = dr("County_Name")
                txtCountyID.Text = dr("County_Id")
                txtSchemeName.Text = dr("Scheme_Name")
                SchemeIDtxt.Text = dr("SchemeNo")
                txtCustomerNo.Text = dr("No_of_Customers")
                txtTXNo.Text = dr("Substation_No")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmInvoicing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnItemswithoutMetering.Enabled = True
        chkMeteringcomplete.Enabled = False
        LoadVatno()
        'LoadSubcontractors()
        'LoadItems()
        txtNil.Text = 0
        txt12MCP.Text = 0
    End Sub

    Private Sub btnLoadSchemes_Click(sender As Object, e As EventArgs) Handles btnLoadSchemes.Click
        frmLoadSchm.ShowDialog()
    End Sub
    Private Sub btnLoadSubcontractor_Click(sender As Object, e As EventArgs) Handles btnLoadSubcontractor.Click
        frmLoadSubcontractors.ShowDialog()
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
            'cmdSearchItems.Items.Clear()
            Do While dr.Read = True
                'cmdSearchItems.Items.Add(dr("Description"))
                'cmdSearchItems.Text = "Description"
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
            'Query = "SELECT ItemNo, Description, UoM, UnitRate from tbl_billingparameters where Description = '" & cmdSearchItems.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                'txtItemCode.Text = dr("ItemNo")
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
            'Query = "SELECT ItemNo, Description, UoM, UnitRate from tbl_billingparameters where ItemNo = '" & txtItemCode.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                'txtunitrt.Text = dr("UnitRate")
                'txtUnitofIssue.Text = dr("UoM")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub cboSubcontractor_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub cmdSearchItems_SelectedIndexChanged(sender As Object, e As EventArgs)
        PopulateItemCodeTextboxes()
        PopulateTextboxbasedonItemNo()
    End Sub

    Private Sub txtQtytoIssue_TextChanged(sender As Object, e As EventArgs)
        Dim TotalAmt As Decimal
        'TotalAmt = Val(txtQtytoIssue.Text) * Val(txtunitrt.Text)
        'txtTotal.Text = Format(TotalAmt, "#,##0.00")
    End Sub

    Public Sub dropDuplicateRows()
        For intI As Integer = dgw.Rows.Count - 1 To 0 Step -1
            For intJ As Integer = dgw.Rows.Count - 1 To intI + 1 Step -1
                If dgw.Rows(intI).Cells(0).Value = dgw.Rows(intJ).Cells(0).Value Then
                    dgw.Rows.RemoveAt(intJ)
                    MsgBox("Please Double Click the Existing Item and Enter the Right Quantity", MsgBoxStyle.Exclamation, "Material Delivery!")
                    Exit Sub
                    'dgwIssueItems.Rows(intI).Cells(2).Value = Val(dgwIssueItems.Rows(intI).Cells(2).Value) + Val(txtQtytoIssue.Text)
                End If
            Next intJ
        Next intI
    End Sub
    Private Sub btnAddtoGrid_Click(sender As Object, e As EventArgs)
        btnItemswithoutMetering.Enabled = False
        chkMeteringcomplete.Enabled = False
        chkMeteringcomplete.Checked = True
        chkLineItemInstalled.Checked = False
        chkLineItemInstalled.Enabled = False
        If SchemeIDtxt.Text = "" Then
            MessageBox.Show("Please enter Scheme Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtSubcontractor.Text = "" Then
            MessageBox.Show("Please enter Sub-contractor Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        PopulatedgwMeterInstallationItems()
        chkMeteringcomplete.Checked = True

    End Sub
    Private Sub Meterinstllation()
        If chkMeterDone.Checked = True Then
            For intI As Integer = dgw.Rows.Count - 1 To 0 Step -1
                For intJ As Integer = dgw.Rows.Count - 1 To intI + 1 Step -1
                    If dgw.Rows(intI).Cells(0).Value < 31 Or dgw.Rows(intI).Cells(0).Value > 32 Then
                        dgw.Rows.RemoveAt(intJ)
                        MsgBox("Please enter meter installation details only", MsgBoxStyle.Exclamation, "Invoicing!")
                        ResetForm()
                        Exit Sub
                    End If
                Next intJ
            Next intI
        End If

    End Sub
    'Ten meter poles used 
    Public Sub Tenmeterpolesused()
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
                    INNER Join schemes ON schemes.SchemeNo = delivery_details.SchemeId Where SchemeNo = @d1 and Item_No = 2134"
            cmd = New MySqlCommand(Query, MysqlConn)
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
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
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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
    Private Sub computePolesissuedinscheme()
        txtWPLV.Text = txtPolesInstalled.Text
        txtLVCP.Text = Val(txt10MCP.Text) + Val(txtCPWE.Text)
        txtMVWP.Text = Val(txt11MPoles.Text) + Val(txt12MPoles.Text)
        txtMVCP.Text = Val(txt11MCP.Text) + Val(txt12MCP.Text)
    End Sub

    Private Sub getqty()
        Dim TotAmt As Decimal
        'Dim Vat As Decimal = 0.16
        Dim Totvat As Decimal
        Dim TotalIncVat As Decimal
        For r = 0 To dgw.Rows.Count - 1
            TotAmt += dgw.Rows(r).Cells(5).Value
            lblTotalAmt.Text = Format(TotAmt, "#,##0.00")
            'Totvat = TotAmt * Vat
            Totvat = TotAmt * Val(txtVatRate.Text)
            TotalIncVat = TotAmt + Totvat
            lblVat.Text = Format(Totvat, "#,##0.00")
            lblTotalincvat.Text = Format(TotalIncVat, "#,##0.00")
        Next
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
            Query = "INSERT INTO tbl_billingdetails(Sub_contractorID, SchemeID, CountyID, ConstituencyID, BillingDate, SchemeRefNo, TXNo, Createdby, Workstation, MeteringCompleted, TotalAmt, Approved, Approvedby, Cancelled, Cancelledby, TotalVat, TotalIncVat, LineItemCompleted) VALUES ('" & txtSubcontractor.Text & "', '" & SchemeIDtxt.Text & "', '" & txtCountyID.Text & "', '" & txtConstituencyID.Text & "', '" & lbldate.Text & "', '" & SchemeRefNotxt.Text & "', '" & txtTXNo.Text & "', '" & FrmMain.tsslUser.Text & "', '" & FrmMain.LBLComputerName.Text & "', '" & chkMeteringcomplete.CheckState & "', '" & lblTotalAmt.Text & "', '" & txtNil.Text & "','" & txtNil.Text & "', '" & txtNil.Text & "', '" & txtNil.Text & "', '" & lblVat.Text & "', '" & lblTotalincvat.Text & "', '" & chkLineItemInstalled.CheckState & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, SchemeRefNotxt.Text, TimeOfDay, "Added New Contractor Invoice")
    End Sub
    Private Sub CheckSchemeInvoiced()
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
                .CommandText = "SELECT COUNT(*) FROM tbl_billingdetails WHERE SchemeID  = '" & SchemeIDtxt.Text & "' and  LineItemCompleted = 1"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                MsgBox("Scheme is invoiced!", MsgBoxStyle.Exclamation, "Sub-contractor BOQs!")
                chkLineInstallation.Checked = True
                chkMeterDone.Checked = False
                chkLineItemInstalled.Checked = True
                chkLineItemInstalled.Enabled = False
                btnItemswithoutMetering.Enabled = False
                ResetForm()
                txtSchemeName.Text = ""
                SchemeRefNotxt.Text = ""
                SchemeIDtxt.Text = ""
                txtSubcontractor.Text = ""
                txtTXNo.Text = ""
                txtCounty.Text = ""
                txtConstituencyname.Text = ""
                txtConstituencyname.Text = ""
                txtCounty.Text = ""
                txtVatNo.Text = ""
                txtVatRate.Text = ""
                cboVat.Text = ""
                LoadVatno()
                btnItemswithoutMetering.Enabled = True
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub CheckIfAllMeteringDone()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT
                    tbl_billingdetails.SchemeID,
                    tbl_billingitems.ItemNo,
                    sum(tbl_billingitems.Qty) as Qty,
                    tbl_billingdetails.BillingdetailID
                    FROM
                    tbl_billingdetails
                    INNER JOIN tbl_billingitems ON tbl_billingitems.BillingID = tbl_billingdetails.BillingdetailID where tbl_billingdetails.SchemeID = '" & SchemeIDtxt.Text & "' and tbl_billingitems.ItemNo =  32 group by tbl_billingitems.ItemNo"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtmeterinstalled.Text = (dr("Qty"))
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    'CheckSchemeInvoiced() CheckLineItemandMeter() CheckMeterInstallationComplete() MeterInstallationCompleted() 

    Private Sub CheckLineItemandMeter()
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
                .CommandText = "SELECT COUNT(*) FROM tbl_billingdetails WHERE SchemeID  = '" & SchemeIDtxt.Text & "' and LineItemCompleted = 0"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                'MsgBox("Continue Invoicing", MsgBoxStyle.Exclamation, "Sub-contractor BOQs!")
                chkMeterDone.Checked = True
                chkMeterDone.Enabled = False
                chkLineInstallation.Checked = False
                chkLineItemInstalled.Checked = True
                chkLineItemInstalled.Enabled = False
                btnItemswithoutMetering.Enabled = False
                btnItemswithoutMetering.Enabled = True
                Exit Sub
            End If
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
                .CommandText = "SELECT COUNT(*) FROM tbl_billingdetails WHERE SchemeID  = '" & SchemeIDtxt.Text & "' and MeteringCompleted = 0"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                'MsgBox("Meter BOQ not Invoiced!", MsgBoxStyle.Exclamation, "Sub-contractor BOQs!")
                chkMeterDone.Checked = False
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
                .CommandText = "SELECT COUNT(*) FROM tbl_billingdetails WHERE SchemeID  = '" & SchemeIDtxt.Text & "' and MeteringCompleted = 1"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                'MsgBox("Meter BOQ Invoiced!", MsgBoxStyle.Exclamation, "Sub-contractor BOQs!")
                chkMeterDone.Checked = True
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
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
            Query = "UPDATE tbl_billingdetails SET MeteringCompleted = 1 where  SchemeID = '" & SchemeIDtxt.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub UpdateLineInstallation()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE tbl_billingdetails SET LineItemCompleted = 1 where  SchemeID = '" & SchemeIDtxt.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader

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
        SchemeIDtxt.Text = ""
        txtCountyID.Text = ""
        txtConstituencyID.Text = ""
        lbldate.Text = ""
        SchemeRefNotxt.Text = ""
        txtTXNo.Text = ""
        lblTotalAmt.Text = "++++++++++"
        txtCounty.Text = ""
        txtConstituencyname.Text = ""
        txtSchemeName.Text = ""
        lblVat.Text = "+++++++++++"
        lblTotalincvat.Text = "+++++++++++"
        txtCustomerNo.Text = ""
        txtmeterinstalled.Text = ""
        txtPolesInstalled.Text = ""
        chkLineInstallation.CheckState = 0
        chkMeterDone.CheckState = 0
        chkEnableschemes.Enabled = True
        cboSubcontractor.Text = ""
        txtVatNo.Text = ""
        txtVatRate.Text = ""
        cboVat.Text = ""
        LoadVatno()
    End Sub

    Private Sub PSaveToolStripButton_Click(sender As Object, e As EventArgs) Handles PSaveToolStripButton.Click
        Dim Mvconductor As Decimal
        Dim Lvconductor As Decimal
        Dim Lvstayrod As Decimal
        Dim Mvstayrod As Decimal
        Dim PME As Decimal
        Dim MVWPPoles As Decimal
        Dim MVCPPoles As Decimal
        Dim LVWPPoles As Decimal
        Dim LVCPPoles As Decimal
        Mvconductor = Val(dgw.Rows(8).Cells(4).Value)
        Lvconductor = Val(dgw.Rows(19).Cells(4).Value)
        Mvstayrod = Val(dgw.Rows(9).Cells(4).Value) + Val(dgw.Rows(10).Cells(4).Value) + Val(dgw.Rows(11).Cells(4).Value)
        Lvstayrod = Val(dgw.Rows(20).Cells(4).Value) + Val(dgw.Rows(21).Cells(4).Value) + Val(dgw.Rows(22).Cells(4).Value)
        PME = Val(dgw.Rows(24).Cells(4).Value)
        If PME <> txtPME.Text Then
            MessageBox.Show("Please reconcile PMEs to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgw.Rows(24).Cells(4).Value = 0.00
            Exit Sub
        End If
        If Mvstayrod <> txtMVstayrod.Text Then
            MessageBox.Show("Please reconcile MV Stays to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgw.Rows(9).Cells(4).Value = 0.00
            dgw.Rows(10).Cells(4).Value = 0.00
            dgw.Rows(11).Cells(4).Value = 0.00
            Exit Sub
        End If
        If Lvstayrod <> txtLVStayRod.Text Then
            MessageBox.Show("Please reconcile LV Stays to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgw.Rows(20).Cells(4).Value = 0.00
            dgw.Rows(21).Cells(4).Value = 0.00
            dgw.Rows(22).Cells(4).Value = 0.00
            Exit Sub
        End If

        MVWPPoles = Val(dgw.Rows(4).Cells(4).Value) + Val(dgw.Rows(5).Cells(4).Value) + Val(dgw.Rows(12).Cells(4).Value)
        MVCPPoles = Val(dgw.Rows(6).Cells(4).Value) + Val(dgw.Rows(7).Cells(4).Value)
        LVWPPoles = Val(dgw.Rows(15).Cells(4).Value) + Val(dgw.Rows(16).Cells(4).Value) + Val(dgw.Rows(23).Cells(4).Value)
        LVCPPoles = Val(dgw.Rows(17).Cells(4).Value) + Val(dgw.Rows(18).Cells(4).Value)

        If dgw.Rows(19).Cells(4).Selected = True Then
            If LVWPPoles <> txtWPLV.Text Then
                MessageBox.Show("Please reconcile poles first to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dgw.Rows(15).Cells(4).Value = 0.00
                dgw.Rows(16).Cells(4).Value = 0.00
                dgw.Rows(15).Cells(5).Value = 0.00
                dgw.Rows(16).Cells(5).Value = 0.00
                Exit Sub
            End If

            If LVCPPoles <> txtLVCP.Text Then
                MessageBox.Show("Please reconcile poles first to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dgw.Rows(17).Cells(4).Value = 0.00
                dgw.Rows(18).Cells(4).Value = 0.00
                dgw.Rows(17).Cells(5).Value = 0.00
                dgw.Rows(18).Cells(5).Value = 0.00
                Exit Sub
            End If
        End If

        If dgw.Rows(8).Cells(4).Selected = True Then
            If MVWPPoles <> txtMVWP.Text Then
                MessageBox.Show("Please reconcile poles first to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dgw.Rows(4).Cells(4).Value = 0.00
                dgw.Rows(5).Cells(4).Value = 0.00
                dgw.Rows(4).Cells(5).Value = 0.00
                dgw.Rows(5).Cells(5).Value = 0.00
                Exit Sub
            End If

            If MVCPPoles <> txtMVCP.Text Then
                MessageBox.Show("Please reconcile poles first to continue! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dgw.Rows(6).Cells(4).Value = 0.00
                dgw.Rows(7).Cells(4).Value = 0.00
                dgw.Rows(6).Cells(5).Value = 0.00
                dgw.Rows(7).Cells(5).Value = 0.00
                Exit Sub
            End If
        End If
        chkLineItemInstalled.Checked = True
        InsertBillingDetails()
        InsertBillingItems()
        If chkLineInstallation.Checked = True Then
            UpdateLineInstallation()
        End If
        If chkMeterDone.Checked = True Then
            UpdateMeterInstallation()
        End If
        ResetForm()
        MsgBox("New invoicing details successfully added.", MsgBoxStyle.Information, "Add Billing")
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs)
        dropItemswhereqtyzero()
        'Me.Close()
    End Sub

    Private Sub Populatedgw()
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
            Query = "SELECT ItemNo, Description, UoM, UnitRate, subcatID from tbl_billingparameters where subcatID = 6"
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
    End Sub
    Private Sub btnItemswithoutMetering_Click(sender As Object, e As EventArgs) Handles btnItemswithoutMetering.Click
        chkMeteringcomplete.Enabled = False
        chkMeteringcomplete.Checked = False
        chkLineItemInstalled.Checked = True
        chkLineItemInstalled.Enabled = False
        If SchemeIDtxt.Text = "" Then
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
        Populatedgw()
    End Sub
    Private Sub dgw_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellEndEdit
        dgw.CurrentRow.Cells(5).Value = dgw.CurrentRow.Cells(3).Value.ToString() * dgw.CurrentRow.Cells(4).Value
        comparevalues()
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
    Public Sub dropItemswhereqtyzero()
        For Each r As DataGridViewRow In dgw.Rows
            For intI As Integer = dgw.Rows.Count - 1 To 0 Step -1
                For intJ As Integer = dgw.Rows.Count - 1 To intI + 1 Step -1
                    If dgw.Rows(intI).Cells(4).Value = 0.00 Then
                        dgw.Rows.RemoveAt(intI)
                        'dgw.Rows.RemoveAt(intJ)
                        'MsgBox("Please Double Click the Existing Item and Enter the Right Quantity", MsgBoxStyle.Exclamation, "Material Delivery!")
                        Exit Sub
                        'dgwIssueItems.Rows(intI).Cells(2).Value = Val(dgwIssueItems.Rows(intI).Cells(2).Value) + Val(txtQtytoIssue.Text)
                    End If
                Next intJ
            Next intI
        Next
    End Sub
    Private Sub PopulatedgwAllItems()
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
            Query = "SELECT ItemNo, Description, UoM, UnitRate from tbl_billingparameters"
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
            Query = "SELECT ItemNo, Description, UoM, UnitRate from tbl_billingparameters where ItemNo > 31"
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
    Private Sub ClearToolStripButton_Click(sender As Object, e As EventArgs) Handles ClearToolStripButton.Click
        btnItemswithoutMetering.Enabled = True
        chkMeteringcomplete.Enabled = False
        chkMeteringcomplete.CheckState = 0
        chkLineItemInstalled.CheckState = 0
        ResetForm()
        dgw.Rows.Clear()
    End Sub

    Private Sub CloseToolStripLabel_Click(sender As Object, e As EventArgs) Handles CloseToolStripLabel.Click
        Me.Close()
    End Sub
    Private Sub txtSchemeRefNo_TextChanged(sender As Object, e As EventArgs) Handles SchemeRefNotxt.TextChanged
        LoadSchemedetails()
    End Sub

    Private Sub chkEnableschemes_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableschemes.CheckedChanged
        If chkEnableschemes.Checked = True Then
            btnLoadSchemes.Enabled = True
        End If
    End Sub

    Private Sub txtSchemeID_TextChanged(sender As Object, e As EventArgs) Handles SchemeIDtxt.TextChanged
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
        'CheckIfAllMeteringDone()
        'CheckSchemeInvoiced()
        'CheckLineItemandMeter()
        CheckSchemeInvoiced()
        CheckLineItemandMeter()
        CheckMeterInstallationComplete()
        MeterInstallationCompleted()
    End Sub
    'compare poles invoiced with poles issued 
    Private Sub comparevalues()
        Dim MVWPPoles As Decimal
        Dim MVCPPoles As Decimal
        Dim LVWPPoles As Decimal
        Dim LVCPPoles As Decimal
        MVWPPoles = Val(dgw.Rows(4).Cells(4).Value) + Val(dgw.Rows(5).Cells(4).Value) + Val(dgw.Rows(12).Cells(4).Value)
        MVCPPoles = Val(dgw.Rows(6).Cells(4).Value) + Val(dgw.Rows(7).Cells(4).Value)
        LVWPPoles = Val(dgw.Rows(15).Cells(4).Value) + Val(dgw.Rows(16).Cells(4).Value) + Val(dgw.Rows(23).Cells(4).Value)
        LVCPPoles = Val(dgw.Rows(17).Cells(4).Value) + Val(dgw.Rows(18).Cells(4).Value)

        If dgw.Rows(19).Cells(4).Selected = True Then
            If LVWPPoles <> txtWPLV.Text Then
                MsgBox("Please reconcile poles first to continue!", MsgBoxStyle.Exclamation, "Invoicing!")
                dgw.Rows(15).Cells(4).Value = 0.00
                dgw.Rows(16).Cells(4).Value = 0.00
                dgw.Rows(15).Cells(5).Value = 0.00
                dgw.Rows(16).Cells(5).Value = 0.00
                Exit Sub
            End If

            If LVCPPoles <> txtLVCP.Text Then
                MsgBox("Please reconcile poles first to continue!", MsgBoxStyle.Exclamation, "Invoicing!")
                dgw.Rows(17).Cells(4).Value = 0.00
                dgw.Rows(18).Cells(4).Value = 0.00
                dgw.Rows(17).Cells(5).Value = 0.00
                dgw.Rows(18).Cells(5).Value = 0.00
                Exit Sub
            End If
        End If

        If dgw.Rows(8).Cells(4).Selected = True Then
            If MVWPPoles <> txtMVWP.Text Then
                MsgBox("Please reconcile poles first to continue!", MsgBoxStyle.Exclamation, "Invoicing!")
                dgw.Rows(4).Cells(4).Value = 0.00
                dgw.Rows(5).Cells(4).Value = 0.00
                dgw.Rows(4).Cells(5).Value = 0.00
                dgw.Rows(5).Cells(5).Value = 0.00
                Exit Sub
            End If

            If MVCPPoles <> txtMVCP.Text Then
                MsgBox("Please reconcile poles first to continue!", MsgBoxStyle.Exclamation, "Invoicing!")
                dgw.Rows(6).Cells(4).Value = 0.00
                dgw.Rows(7).Cells(4).Value = 0.00
                dgw.Rows(6).Cells(5).Value = 0.00
                dgw.Rows(7).Cells(5).Value = 0.00
                Exit Sub
            End If
        End If

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
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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
            cmd.Parameters.AddWithValue("@d1", SchemeIDtxt.Text)
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

    Private Sub cboVat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVat.SelectedIndexChanged
        LoadVATRate()
        txtVatRate.Text = cboVat.Text
    End Sub
End Class