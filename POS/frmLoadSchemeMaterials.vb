Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmLoadSchemeMaterials
    Private Sub GetMasterlistAllocationNo()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT scheme_material_allo_no FROM tbl_scheme_material ORDER BY scheme_material_allo_no DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblAllocationNo.Text = dr("scheme_material_allo_no") + 1
            Else
                lblAllocationNo.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PopulateTextboxes()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT  ProductNo, Description, StocksOnHand, ReorderLevel, CateID, SubCateID, PrefSupplier, UnitofIssue from Product where Description = '" & cmdSearchItems.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtItemCode.Text = dr("ProductNo")
                txtUnitofIssue.Text = dr("UnitofIssue")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub cmdSearchItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdSearchItems.SelectedIndexChanged
        PopulateTextboxes()
    End Sub
    Private Sub populateItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ProductNo, Description from product ORDER BY Description DESC LIMIT 200"
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

    Private Sub frmLoadSchemeMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateItems()
        lbldate.Text = Format(Now, "MM/dd/yyyy")
        txtItemcount.Text = "0"
    End Sub
    Private Sub LoadSchemeCountyID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select SchemeNo, Scheme_Ref_No, Scheme_Name, County_Id, Constituency_Id from schemes where Scheme_Ref_No = '" & txtSchemeRefNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtSchemeID.Text = dr("SchemeNo")
                txtCountyID.Text = dr("County_Id")
                txtConstituencyID.Text = dr("Constituency_Id")
                txtSchemeName.Text = dr("Scheme_Name")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub txtSchemeRefNo_KeyUp(sender As Object, e As EventArgs) Handles txtSchemeRefNo.KeyUp
        LoadSchemeCountyID()
    End Sub
    Public Sub dropDuplicateRows()
        For intI As Integer = dgwIssueItems.Rows.Count - 1 To 0 Step -1
            For intJ As Integer = dgwIssueItems.Rows.Count - 1 To intI + 1 Step -1
                If dgwIssueItems.Rows(intI).Cells(0).Value = dgwIssueItems.Rows(intJ).Cells(0).Value Then
                    dgwIssueItems.Rows(intI).Cells(2).Value = Val(dgwIssueItems.Rows(intI).Cells(2).Value) + Val(txtQtytoIssue.Text)
                    dgwIssueItems.Rows.RemoveAt(intJ)
                End If
            Next intJ
        Next intI
    End Sub
    Private Sub getqty()
        Dim qty As Decimal
        For r = 0 To dgwIssueItems.Rows.Count - 1
            qty += dgwIssueItems.Rows(r).Cells(2).Value
            txtItemcount.Text = qty
        Next
    End Sub
    Private Sub ClearTextboxesafterAddtogrid()
        txtItemCode.Text = ""
        txtQtytoIssue.Text = ""
    End Sub
    Private Sub AddItemstoGrid()
        If Trim(txtSchemeName.Text) = "" Or txtSchemeID.Text = "" Or txtItemCode.Text = "" Then
            MsgBox("Please Fill all TextBoxes")
        Else
            Dim rnum As Integer = dgwIssueItems.Rows.Add()
            dgwIssueItems.Rows.Item(rnum).Cells(0).Value = txtItemCode.Text
            dgwIssueItems.Rows.Item(rnum).Cells(1).Value = cmdSearchItems.Text
            dgwIssueItems.Rows.Item(rnum).Cells(2).Value = txtQtytoIssue.Text
            dgwIssueItems.Rows.Item(rnum).Cells(3).Value = txtUnitofIssue.Text

        End If
    End Sub

    Private Sub btnAddtoGrid_Click(sender As Object, e As EventArgs) Handles btnAddtoGrid.Click
        checkduplicateschememasterlist()
        AddItemstoGrid()
        dropDuplicateRows()
        getqty()
        ClearTextboxesafterAddtogrid()
        txtSchemeRefNo.Enabled = False
    End Sub

    Private Sub checkduplicateschememasterlist()
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
                .CommandText = "SELECT COUNT(*) FROM tbl_scheme_material_details WHERE item_no  = '" & txtItemCode.Text & "' and scheme_no  = '" & txtSchemeID.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 Then
                ClearTextboxesafterAddtogrid()
                MsgBox("Material Exists in Scheme Masterlist!", MsgBoxStyle.Exclamation, "Add Scheme Masterlist!")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        Exit Sub
    End Sub
    Private Sub Clearallaftersave()
        txtItemCode.Text = ""
        txtQtytoIssue.Text = ""
        txtConstituencyID.Text = ""
        txtCountyID.Text = ""
        txtSchemeID.Text = ""
        txtSchemeRefNo.Text = ""
        txtItemcount.Text = ""
        txtQtytoIssue.Text = ""
        txtUnitofIssue.Text = ""
        txtSchemeName.Text = ""
        dgwIssueItems.Rows.Clear()
    End Sub

    Private Sub Insertschemematerial()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_scheme_material (scheme_material_allo_no, scheme_no, CountyID, ConstituencyID, date_allocated, allocated_by) VALUES ('" & lblAllocationNo.Text & "', '" & txtSchemeID.Text & "', '" & txtCountyID.Text & "', '" & txtConstituencyID.Text & "', '" & lbldate.Text & "', '" & FrmMain.tsslUser.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub DeleteemptyrowsfromTempStockin()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from tbl_scheme_material_details where item_no = '';"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub insertintoSchemeDetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader

        If txtSchemeRefNo.Text = Nothing Then
            MessageBox.Show("Please enter Scheme Ref No", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSchemeRefNo.Focus()
            Exit Sub
        End If
        If dgwIssueItems.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please enter Items To Scheme Materlist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each r As DataGridViewRow In dgwIssueItems.Rows
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "INSERT INTO tbl_scheme_material_details (scheme_material_alloc_no, scheme_no, item_no, qty, CountyID, ConstituencyID) " &
                             " VALUES ('" & lblAllocationNo.Text & "', '" & txtSchemeID.Text & "', '" & r.Cells(0).Value &
                             "','" & r.Cells(2).Value & "', '" & txtCountyID.Text & "', '" & txtConstituencyID.Text & "')"

                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
            ''Update Audit Trail Table
            Audit_Trail(FrmMain.tsslUser.Text, r.Cells(0).FormattedValue, TimeOfDay, "Allocated Materials to scheme")
        Next
        DeleteemptyrowsfromTempStockin()
        Clearallaftersave()
        MsgBox("Scheme Material Materiallist successfully added.", MsgBoxStyle.Information, "Add Scheme Material Masterlist")
    End Sub

    Private Sub MasterlistSaveToolStripButton5_Click(sender As Object, e As EventArgs) Handles MasterlistSaveToolStripButton5.Click
        GetMasterlistAllocationNo()
        Insertschemematerial()
        insertintoSchemeDetails()
    End Sub
    Private Sub MyTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtytoIssue.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


End Class