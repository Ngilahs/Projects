Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmPOS
    Dim qty As Double
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Private flag_cell_edited As Boolean
    Private currentRow As Integer
    Private currentColumn As Integer
    Private flag_cell_edited1 As Boolean
    Private currentRow1 As Integer
    Private currentColumn1 As Integer
    Dim y As Integer
    Dim Ds As New DataSet
    Dim changes As DataSet
    Dim drow As DataRow
    Dim i As Integer
    Private Sub GetStockID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT StockInDetailID FROM stockindetails ORDER BY StockInDetailID DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtStockinIDRS.Text = dr("StockInDetailID") + 1
            Else
                txtStockinIDRS.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub GetunclearedPurchaseID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT idunclearedDetailID FROM uncleareddetail ORDER BY idunclearedDetailID DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtUnclearedPurchaseID.Text = dr("idunclearedDetailID") + 1
            Else
                txtUnclearedPurchaseID.Text = 1
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub frmPOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            GetStockID()
            GetunclearedPurchaseID()
            'lbldateRS.Text = Format(Now, "MM/dd/yyyy")
            Timer1.Start()
            PopulateItemsCount()
            populateItems()
            LoadSchemes()
            AddHandler Microsoft.Win32.SystemEvents.SessionEnding, AddressOf Handler_SessionEnding
        Catch ex As Exception
        End Try
        FrmPointofSale.Close()
    End Sub
    Public Sub Handler_SessionEnding(ByVal sender As Object, ByVal e As Microsoft.Win32.SessionEndingEventArgs)
        If e.Reason = Microsoft.Win32.SessionEndReasons.Logoff Then
            MessageBox.Show("User is logging off")
        ElseIf e.Reason = Microsoft.Win32.SessionEndReasons.SystemShutdown Then
            insertintounclearedpurchasetable()
            insertintouncleareddetails()
            Deleteemptyrowsfromuncleareddetail()
            MessageBox.Show("System is shutting down")
        End If
    End Sub

    Private Sub btnVoidrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If MessageBox.Show("Are You Sure You want to Void the item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                dtgCartItems.Rows.Remove(dtgCartItems.CurrentRow)
            End If
            Dim tot As Double
            For i = 0 To dtgCartItems.Rows.Count - 1
                tot += dtgCartItems.Rows(i).Cells(5).Value
            Next
        Catch ex As Exception
            MessageBox.Show("Please Focus on the Item to Void", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
        End Try
    End Sub
    Private Sub VoidToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoidToolStripMenuItem.Click
        Call btnVoidrt_Click(sender, e)
    End Sub

    Private Sub dtgCartItems_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCartItems.CellEndEdit
        Dim errMessage As String = String.Empty

        Dim tot As Decimal
        Dim vatrate As String = 16 / 116
        Dim Bcode1 As String
        Dim Bcode2 As String
        Dim code As String
        Dim Sprice As String
        Dim Uprice As String
        Dim Stkhand As String
        Dim TotAmt As Decimal

        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ProductNo, Description, UnitPrice, StocksOnHand, VatCode, Selling_Price, Barcode, ProductCode From product Where Barcode = '" & dtgCartItems.CurrentRow.Cells(0).Value & "' OR ProductCode = '" & dtgCartItems.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader

            Dim qty As Decimal = 1
            If dtgCartItems.CurrentRow.Cells(2).Value = Nothing Then
                qty = 1
            Else
                qty = dtgCartItems.CurrentRow.Cells(2).Value
            End If
            If dr.Read = True Then
                'Add Items to the datagrid Barcode 
                Bcode1 = dr("Barcode")
                Bcode2 = dr("ProductCode")
                Sprice = dr("Selling_Price")
                Uprice = dr("UnitPrice")
                Stkhand = dr("StocksOnHand")
                TotAmt = Uprice * Stkhand
                ''Edit Item Price
                Dim Prc As String = 0
                If dtgCartItems.CurrentRow.Cells(3).Value = Nothing Then
                    Prc = dr("UnitPrice").ToString
                Else
                    Prc = dtgCartItems.CurrentRow.Cells(3).Value
                End If
                'Edit Item Amount
                Dim Amt As Decimal = 0
                If dtgCartItems.CurrentRow.Cells(5).Value = Nothing Then
                    Amt = Format((Prc * qty), "#,##0.00")
                Else
                    Amt = dtgCartItems.CurrentRow.Cells(5).Value
                End If
                'Capture two Barcodes
                If dtgCartItems.CurrentRow.Cells(0).Value = Bcode1 Then
                    Bcode1 = code
                    code = dtgCartItems.CurrentRow.Cells(0).Value
                Else
                    If dtgCartItems.CurrentRow.Cells(0).Value = Bcode2 Then
                        Bcode2 = code
                        code = dtgCartItems.CurrentRow.Cells(0).Value
                    End If
                End If
                'Calculate price, amount, Qty
                If dtgCartItems.CurrentRow.Cells(5).Selected Then
                    Prc = Format(Amt / qty, "#,##0.00")
                End If
                If dtgCartItems.CurrentRow.Cells(3).Selected Then
                    Amt = Format(Prc * qty, "#,##0.00")
                End If
                If dtgCartItems.CurrentRow.Cells(2).Selected Then
                    Amt = Format(Prc * qty, "#,##0.00")
                End If
                dtgCartItems.CurrentRow.SetValues(code, dr(1), qty, Prc, dr(5), Amt, Format((dr(5) * (vatrate)), "#,##0.00"), dr(5) - Prc, dr(3), dr(3) + qty, Format(((Prc * qty) + TotAmt) / (qty + Stkhand), "#,##0.00"), dr(0))
            Else
                MessageBox.Show("Item Barcode Does not Exist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dtgCartItems.Rows.Remove(dtgCartItems.CurrentRow)
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        GetunclearedPurchaseID()
        If e.ColumnIndex = 0 Then
            flag_cell_edited = True
            currentColumn = e.ColumnIndex
            currentRow = e.RowIndex
        Else
            flag_cell_edited1 = False
        End If

        If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Then
            flag_cell_edited1 = True
            currentColumn = e.ColumnIndex
            currentRow = e.RowIndex
        Else
            flag_cell_edited1 = False
        End If
        'insert into uncleared purchase table
        SaveUnclearedPurchase(txtStockinIDRS.Text, dtgCartItems.CurrentRow.Cells(0).Value, dtgCartItems.CurrentRow.Cells(1).Value, dtgCartItems.CurrentRow.Cells(2).Value, dtgCartItems.CurrentRow.Cells(5).Value, dtgCartItems.CurrentRow.Cells(6).Value, dtgCartItems.CurrentRow.Cells(7).Value, dtgCartItems.CurrentRow.Cells(3).Value, dtgCartItems.CurrentRow.Cells(4).Value, dtgCartItems.CurrentRow.Cells(8).Value, dtgCartItems.CurrentRow.Cells(9).Value, dtgCartItems.CurrentRow.Cells(10).Value, dtgCartItems.CurrentRow.Cells(11).Value, txtUnclearedPurchaseID.Text)

        'Move to barcode cell after editing quantity 
        'Calculate total receipt amount
        For i = 0 To dtgCartItems.Rows.Count - 1
            tot += dtgCartItems.Rows(i).Cells(5).Value
        Next
        GetStockID()
    End Sub
    'Restrict mouse Click in the POS Grid
    Private Sub dtgCartItems_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgCartItems.CellMouseDown
        If e.Button = MouseButtons.Left Then
            'dtgCartItems.CurrentRow.Cells(11).Selected = True
            'dtgCartItems.ClearSelection()
            Exit Sub
        End If
    End Sub
    Private Sub dtgCartItems_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgCartItems.SelectionChanged
        If flag_cell_edited Then
            dtgCartItems.CurrentCell = dtgCartItems.Rows(currentRow).Cells(2)
            flag_cell_edited = False
        End If
        If flag_cell_edited1 Then
            dtgCartItems.CurrentCell = dtgCartItems.Rows(currentRow + 1).Cells(0)
            flag_cell_edited1 = False
        End If
    End Sub
    Private Sub LoadtoDatagridunclearedpurchasegrid()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ProductBarcode, Description, Quantity, TotalItem_Price, VAT, Markup, BPrc, SPrc, QtyBal, TQty, AvgPrc, UPPNO, idunclearedDetailID FROM unclearedpurchase Where idunclearedDetailID "
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dtgCartItems.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dtgCartItems.Rows.Add(dr("ProductBarcode"), dr("Description"), dr("Quantity"), dr("BPrc"), dr("SPrc"), dr("TotalItem_Price"), dr("VAT"), dr("Markup"), dr("QtyBal"), dr("TQty"), dr("AvgPrc"), dr("UPPNO"), dr("idunclearedDetailID"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmPOS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If dtgCartItems.Rows(0).Cells(0).Value IsNot Nothing Then
        '    insertintounclearedpurchasetable()
        '    insertintouncleareddetails()
        '    Deleteemptyrowsfromuncleareddetail()
        'End If
    End Sub
    Private Sub Deleteemptyrows()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from stockIn where ProductBarcode = '';"
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
            Query = "Delete from stockin where Quantity = '';"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub DeleteemptyrowsStockMaterials()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from stockinMaterials where Quantity = '';"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub InsertintoStockin()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader

        If txtSupplNameRS.Text = Nothing Then
            MessageBox.Show("Please enter Suuplier Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSupplNameRS.Focus()
            Exit Sub
        End If
        If dtgCartItems.Rows(0).Cells(0).Value = "" Then
            MessageBox.Show("Please enter Items To Receive", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each r As DataGridViewRow In dtgCartItems.Rows
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "INSERT INTO stockin (StockInID, PNO, Quantity, QtyRem, Supplier_Name, DateIn, DocumentNo, SchemeID) " &
                             " VALUES ((Select MAX(StockInDetailID) from stockindetails),'" & CInt(r.Cells(0).Value) &
                             "','" & r.Cells(2).Value & "', '" & CDec(r.Cells(3).Value) & "', '" & txtSupplierID.Text & "', '" & lbldateRS.Text & "', '" & txtDocumentNo.Text & "', '" & txtSchmID.Text & "')"

                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
            ''Update Audit Trail Table
            Audit_Trail(FrmMain.tsslUser.Text, r.Cells(0).FormattedValue, TimeOfDay, "Updated Stock Quantity")
        Next
        DeleteemptyrowsfromTempStockin()
    End Sub
    Private Sub InsertintoStockinMaterials()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader

        If txtSupplNameRS.Text = Nothing Then
            MessageBox.Show("Please enter Suplier Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSupplNameRS.Focus()
            Exit Sub
        End If
        If dtgCartItems.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please enter Items To Receive", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each r As DataGridViewRow In dtgCartItems.Rows
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "INSERT INTO stockinMaterials (StockInID, PNO, Quantity, QtyRem, Supplier_Name, DateIn, DocumentNo, SchemeID) " &
                             " VALUES ((Select MAX(StockInDetailID) from stockindetails), '" & CInt(r.Cells(0).Value) &
                             "','" & r.Cells(2).Value & "', '" & CDec(r.Cells(3).Value) & "', '" & txtSupplierID.Text & "', '" & lbldateRS.Text & "', '" & txtDocumentNo.Text & "', '" & txtSchmID.Text & "')"

                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Next
        DeleteemptyrowsStockMaterials()
    End Sub
    Private Sub Updatematerials()
        'Update Quantity
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        For i = 0 To dtgCartItems.Rows.Count - 1
            Try
                MysqlConny.Open()
                Dim Querys As String
                Querys = "UPDATE product SET StocksOnHand = StocksOnHand + '" & dtgCartItems.Rows(i).Cells(2).Value & "' WHERE ProductNo = '" & dtgCartItems.Rows(i).Cells(0).Value & "'"
                cmd = New MySqlCommand(Querys, MysqlConny)
                dr = cmd.ExecuteReader
                MysqlConny.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConny.Dispose()
            End Try
        Next
        dtgCartItems.Rows.Clear()
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtStockinIDRS.Text, TimeOfDay, "Received New Materials")
        txtSupplNameRS.Clear()
    End Sub
    Private Sub UpdatestockinfromTemptbl()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader

        If txtSupplNameRS.Text = Nothing Then
            MessageBox.Show("Please enter Suuplier Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSupplNameRS.Focus()
            Exit Sub
        End If
        If dtgCartItems.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please enter Items To Purchase", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO stockIn (StockInID, PNO, Quantity, QtyRem, Supplier_Name, DateIn) SELECT StockInID, PNO, Sum(Quantity) as Quantity, RemQty, Supplier_Name, DateIn FROM tempstockin WHERE StockInID = '" & txtStockinIDRS.Text & "'  GROUP BY PNO"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Quantity
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        For i = 0 To dtgCartItems.Rows.Count - 1
            Try
                MysqlConny.Open()
                Dim Querys As String
                Querys = "UPDATE product SET StocksOnHand = StocksOnHand + '" & dtgCartItems.Rows(i).Cells(2).Value & "' WHERE ProductNo = '" & dtgCartItems.Rows(i).Cells(0).Value & "'"
                cmd = New MySqlCommand(Querys, MysqlConny)
                dr = cmd.ExecuteReader
                MysqlConny.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConny.Dispose()
            End Try
        Next
        dtgCartItems.Rows.Clear()
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtStockinIDRS.Text, TimeOfDay, "Received New Materials")
        txtSupplNameRS.Clear()

        MsgBox("Materials successfully added.", MsgBoxStyle.Information, "Add Materials")
    End Sub
    Private Sub Deleteemptyrowsinstockindetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from stockindetails where SuppID = '';"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub insertintostockindetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO stockindetails (DateIn, SuppID, ReceivedBy, DocumentNo, SchemeID) VALUES ('" & lbldateRS.Text & "', '" & txtSupplierID.Text & "', '" & FrmMain.tsslUser.Text & "', '" & txtDocumentNo.Text & "','" & txtSchmID.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub btnsupplierRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsupplierRS.Click
        frmLoadSupplier.ShowDialog()
    End Sub

    Private Sub RSStaveToolStripButton52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dtgCartItems.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please enter Stock to Purchase", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        InsertintoStockin()
        InsertintoStockinMaterials()
        Updatematerials()
        insertintostockindetails()
        GetStockID()
        txtSupplierID.Text = ""
        Me.Close()
        'Call frmPOS_Load(sender, e)
    End Sub
    Private Sub ToolStripButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dtgCartItems.Rows.Clear()
        'LBLTotSaleRS.Text = 0.0
        txtSupplNameRS.Clear()
        'txtPurchamodeRS.Clear()
    End Sub
    Private Sub dtgCart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgCartItems.KeyDown
        If e.KeyCode = Keys.F8 Then
            e.SuppressKeyPress = True
            Dim iCol = dtgCartItems.CurrentCell.ColumnIndex
            Dim iRow = dtgCartItems.CurrentCell.RowIndex
            If iCol = dtgCartItems.Columns.Count - 1 Then
                If iRow < dtgCartItems.Rows.Count - 1 Then
                    dtgCartItems.CurrentCell = dtgCartItems(0, iRow + 2)
                End If
            Else
                dtgCartItems.CurrentCell = dtgCartItems(iCol + 3, iRow)
            End If
        End If
    End Sub
    Private Sub dtgCartItems_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dtgCartItems.KeyUp
        'If e.KeyCode = Keys.Enter Then
        '    If (dtgCartItems.CurrentRow.Index + 1) = (dtgCartItems.Rows.Count) Then
        '        dtgCartItems.CurrentCell = dtgCartItems(1, dtgCartItems.Rows.Count - 1)
        '    End If
        'End If
    End Sub
    Private Sub dtgCart_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtgCartItems.KeyPress
        'If dtgCartItems.CurrentCell.ColumnIndex = 0 Or _
        If dtgCartItems.CurrentCell.ColumnIndex = 1 Then
            'dtgCart.CurrentCell.ColumnIndex = 4 Then
            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then
                        e.Handled = False
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub dtgCartItems_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgCartItems.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf dtgCart_KeyPress
    End Sub
    Private Sub dtgCart_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dtgCartItems.CellBeginEdit
        If e.ColumnIndex = 1 Then
            e.Cancel = True
        End If
        If e.ColumnIndex = 6 Then
            e.Cancel = True
        End If
    End Sub
    Private Sub btnaddQtyRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim iCol = dtgCartItems.CurrentCell.ColumnIndex
            Dim iRow = dtgCartItems.CurrentCell.RowIndex
            If iCol = dtgCartItems.Columns.Count - 1 Then
                If iRow < dtgCartItems.Rows.Count - 1 Then
                    dtgCartItems.CurrentCell = dtgCartItems(0, iRow + 1)
                End If
            Else
                dtgCartItems.CurrentCell = dtgCartItems(iCol + 2, iRow)
            End If
        Catch ex As Exception
            MessageBox.Show("Please Select Item to Edit Quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
        End Try
    End Sub
    Private Sub TToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TToolStripMenuItem.Click
        Call btnaddQtyRS_Click(sender, e)
    End Sub

    Private Sub Btnproductlookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmProductSearch.Visible = True
    End Sub
    Private Sub PrintSaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSaveToolStripMenuItem.Click
        'Call Btnproductlookup_Click(sender, e)
    End Sub
    Public Sub insertintouncleareddetails()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO uncleareddetail (StockInID, TotalItem_Price, DateIn, idunclearedDetailID) VALUES ('" & txtStockinIDRS.Text & "', '" & lbldateRS.Text & "', '" & txtUnclearedPurchaseID.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub insertintounclearedpurchasetable()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        For Each r As DataGridViewRow In dtgCartItems.Rows

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "INSERT INTO unclearedpurchase (StockInID, ProductBarcode, Description, Quantity, TotalItem_Price, VAT, Markup, BPrc, SPrc, QtyBal, TQty, AvgPrc, UPPNO, idunclearedDetailID) " &
                             " VALUES ('" & txtStockinIDRS.Text & "', '" & r.Cells(0).FormattedValue & "', '" & r.Cells(1).Value & "', '" & r.Cells(2).Value &
                             "','" & CDec(r.Cells(5).Value) & "', '" & CDec(r.Cells(6).Value) & "', '" & CDec(r.Cells(7).Value) & "', '" & CDec(r.Cells(3).Value) & "', '" & CDec(r.Cells(4).Value) & "', '" & r.Cells(8).Value & "', '" & r.Cells(9).Value & "', '" & CDec(r.Cells(10).Value) & "', '" & CInt(r.Cells(11).Value) & "', '" & txtUnclearedPurchaseID.Text & "')"
                cmd = New MySqlCommand(Query, MysqlConn)
                dr = cmd.ExecuteReader
                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
            ''Update Audit Trail Table 
            Audit_Trail(FrmMain.tsslUser.Text, dtgCartItems.CurrentRow.Cells(0).FormattedValue, TimeOfDay, "Updated Stock Quantity")
        Next

        Deleteemptyrowsfromunclearedpurchase()
    End Sub
    Private Sub loadunclearedpurchasegrid()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            sqll = "SELECT ProductBarcode, Description, Quantity, TotalItem_Price, VAT, Markup, DateIn, BPrc, SPrc, QtyBal, TQty, AvgPrc FROM unclearedpurchase Where StockInID = '" & txtStockinIDRS.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dtgCartItems.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dtgCartItems.Rows.Add(dr("ProductBarcode"), dr("Description"), dr("Quantity"), dr("BPrc"), dr("SPrc"), dr("TotalItem_Price"), dr("VAT"), dr("SPrc"), dr("Markup"), dr("QtyBal"), dr("TQty"), dr("AvgPrc"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub deletefromunclearedpurchase()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete From unclearedpurchase Where idunclearedDetailID = '" & txtUnclearedPurchaseID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub deletefromuncleareddetail()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete FROM uncleareddetail Where idunclearedDetailID = '" & txtUnclearedPurchaseID.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub deletefromtempheldpurchases()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete FROM tempheldpurchases Where StockInID = '" & txtStockinIDRS.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Deleteemptyrowsfromuncleareddetail()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from uncleareddetail where TotalItem_Price = 0.00"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub DeleteemptyTotAmtrowsfromunclearedpurchases()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from unclearedpurchase where TotalItem_Price = 0.00"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub Deleteemptyrowsfromunclearedpurchase()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from unclearedpurchase where ProductBarcode = '';"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BTNQucikItempurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStockIn.Show()
    End Sub

    Private Sub BTNQuickEditQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmQuickEdit.Show()
    End Sub
    Private Sub QuickItemPurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickItemPurchaseToolStripMenuItem.Click
        Call BTNQucikItempurchase_Click(sender, e)
    End Sub
    Private Sub QuickItemEditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickItemEditToolStripMenuItem.Click
        Call BTNQuickEditQty_Click(sender, e)
    End Sub
    Private Sub CloseToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dtgCartItems.Rows(0).Cells(0).Value IsNot Nothing Then
            insertintounclearedpurchasetable()
            insertintouncleareddetails()
            Deleteemptyrowsfromuncleareddetail()
        End If
        Me.Hide()
    End Sub
    Private Sub clearallfields()
        dtgCartItems.Rows.Clear()
        txtSupplNameRS.Clear()
        txtSupplierID.Clear()
    End Sub
    Private Sub PopulateItemsCount()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT idunclearedDetailID From uncleareddetail ORDER BY idunclearedDetailID"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BtnClearReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClearReset.Click
        dtgCartItems.Rows.Clear()
        txtSupplNameRS.Clear()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dtgCartItems.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please enter Item to Receive", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        InsertintoStockin()
        Updatematerials()
        insertintostockindetails()
        GetStockID()
        deletefromunclearedpurchase()
        deletefromuncleareddetail()
        txtSupplierID.Text = ""
        'txtPurchMdID.Text = ""
        'Call frmPOS_Load(sender, e)
        Me.Close()
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
            Query = "SELECT ProductNo, Description from product ORDER BY Description DESC LIMIT 300"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboSearchItem.Items.Clear()
            Do While dr.Read = True
                cboSearchItem.Items.Add(dr("Description"))
                cboSearchItem.Text = "Description"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
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
            Query = "SELECT  ProductNo, Description, StocksOnHand, ReorderLevel, CateID, SubCateID, PrefSupplier, UnitofIssue from Product where Description = '" & cboSearchItem.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtItemNo.Text = dr("ProductNo")
                txtStckonHand.Text = dr("StocksOnHand")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub cboSearchItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchItem.SelectedIndexChanged
        PopulateTextboxes()
    End Sub
    Private Sub CalculateTotQty()
        txtTotalQty.Text = Val(txtreceivedQty.Text) + Val(txtStckonHand.Text)
    End Sub
    Private Sub txtreceivedQty_TextChanged(sender As Object, e As EventArgs) Handles txtreceivedQty.TextChanged
        CalculateTotQty()
        AcceptButton = btnAddtoGrid
    End Sub
    Private Sub AddItemstoGrid()
        If txtreceivedQty.Text = "" Then
            MessageBox.Show("Please enter Quantity to Receive", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtreceivedQty.Focus()
            Return
            Exit Sub
        End If

        If txtItemNo.Text = "" Then
            MessageBox.Show("Please Select Material to Receive from dropdown list", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return
        End If

        If txtSchemeRef.Text = "" Then
            MessageBox.Show("Please Select Scheme Name from dropdown list", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSchemeRef.Focus()
            Return
        End If
        If txtSupplNameRS.Text = "" Then
            MessageBox.Show("Please Select Supplier", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSupplNameRS.Focus()
            Return
        End If
        If txtDocumentNo.Text = "" Then
            MessageBox.Show("Please Enter Document No", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDocumentNo.Focus()
            Return
        End If
        'If txtDeliveryNote.Text = "" Then
        '    MessageBox.Show("Please Enter Delivery No", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtDeliveryNote.Focus()
        '    Return
        'End If
        Dim rnum As Integer = dtgCartItems.Rows.Add()
            dtgCartItems.Rows.Item(rnum).Cells(0).Value = txtItemNo.Text
            dtgCartItems.Rows.Item(rnum).Cells(1).Value = cboSearchItem.Text
            dtgCartItems.Rows.Item(rnum).Cells(2).Value = txtreceivedQty.Text
            dtgCartItems.Rows.Item(rnum).Cells(3).Value = txtStckonHand.Text
            dtgCartItems.Rows.Item(rnum).Cells(4).Value = txtTotalQty.Text
            dtgCartItems.Rows.Item(rnum).Cells(5).Value = txtSupplNameRS.Text
        dtgCartItems.Rows.Item(rnum).Cells(6).Value = txtDocumentNo.Text
        txtMaterialtoReceive.Text = txtItemNo.Text
        dtgCartItems.Rows.Item(rnum).Cells(7).Value = txtSchmID.Text
    End Sub
    Private Sub btnAddtoGrid_Click(sender As Object, e As EventArgs) Handles btnAddtoGrid.Click
        AddItemstoGrid()
        dropDuplicateRows()
        populateItems()
        ClearTextboxes()
        LoadSchemes()
        cboSchemeName.Enabled = False
        txtDocumentNo.Enabled = False
        txtDeliveryNote.Enabled = False
        btnsupplierRS.Enabled = False
        lbldateRS.Enabled = False
    End Sub
    Public Sub dropDuplicateRows()
        For intI As Integer = dtgCartItems.Rows.Count - 1 To 0 Step -1
            For intJ As Integer = dtgCartItems.Rows.Count - 1 To intI + 1 Step -1
                If dtgCartItems.Rows(intI).Cells(0).Value = dtgCartItems.Rows(intJ).Cells(0).Value Then
                    'dtgCartItems.Rows(intI).Cells(2).Value = Val(dtgCartItems.Rows(intI).Cells(2).Value) + Val(txtreceivedQty.Text)
                    'dtgCartItems.Rows.RemoveAt(intJ)
                    dtgCartItems.Rows.RemoveAt(intJ)
                    MsgBox("Please Double Click the Existing Item and Enter the Right Quantity", MsgBoxStyle.Exclamation, "Material Delivery!")
                    Exit Sub
                End If
            Next intJ
        Next intI
    End Sub
    Private Sub ClearTextboxes()
        txtItemNo.Text = ""
        txtreceivedQty.Text = ""
        txtStckonHand.Text = ""
        txtTotalQty.Text = ""
        txtItemNo.Text = ""
        'txtSchemeID.Text = ""
        'txtCountyID.Text = ""
        'txtConstituencyID.Text = ""
        'txtSchemeRef.Text = ""
    End Sub
    'Auto Search items to Update
    Private Sub AutoSearchItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ProductNo, Description from product ORDER BY Description DESC LIMIT 20"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboSearchItem.Items.Clear()
            Do While dr.Read = True
                cboSearchItem.Items.Add(dr("Description"))
                cboSearchItem.Text = "Description"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub cboAutoSearchItems_SelectedIndexChanged(sender As Object, e As EventArgs)
        AutoSearchItems()
    End Sub
    Private Sub btnOpenSuppliers_Click(sender As Object, e As EventArgs)
        frmLoadSupplier.ShowDialog()
    End Sub
    Private Sub ReCalculateQty()
    End Sub
    Private Sub txtItemQty_TextChanged(sender As Object, e As EventArgs)
        ReCalculateQty()
    End Sub
    Private Sub MyTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtreceivedQty.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDocumentNo_TextChanged(sender As Object, e As EventArgs) Handles txtDocumentNo.KeyUp
        'Check for duplicate entry of Document No
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
                .CommandText = "SELECT COUNT(*) FROM stockin WHERE DocumentNo  = '" & txtDocumentNo.Text & "'"
            End With
            Dim result = cmd.ExecuteScalar()
            If Convert.ToInt32(result) > 0 And txtDocumentNo.Text <> "NILLNULL" Then
                MsgBox("Material for this scheme has been added!", MsgBoxStyle.Exclamation, "Add New Material!")
                txtDocumentNo.Clear()
                Exit Sub
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub txtDocumentNo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDocumentNo.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
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
            Query = "Select SchemeNo, Scheme_Ref_No, Scheme_Name, County_Id, Constituency_Id from schemes where Scheme_Name = '" & cboSchemeName.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtSchemeID.Text = dr("SchemeNo")
                txtCountyID.Text = dr("County_Id")
                txtConstituencyID.Text = dr("Constituency_Id")
                txtSchemeRef.Text = dr("Scheme_Ref_No")
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadSchemename()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SchemeNo, Scheme_Name from schemes where Scheme_Name  = '" & cboSchemeName.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                txtSchemeID.Text = dr("SchemeNo")
                txtSchmID.Text = dr("SchemeNo")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub cboSchemeName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSchemeName.SelectedIndexChanged
        LoadSchemename()
        LoadSchemeCountyID()
    End Sub
    Private Sub LoadSchemes()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SchemeNo, Scheme_Name from schemes"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            cboSchemeName.Items.Clear()
            Do While dr.Read = True
                cboSchemeName.Items.Add(dr("Scheme_Name"))
                cboSchemeName.Text = "Scheme Name"
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PSaveToolStripButton_Click(sender As Object, e As EventArgs) Handles PSaveToolStripButton.Click
        If txtMaterialtoReceive.Text = "" Then
            MsgBox("Add Materials to Receive!", MsgBoxStyle.Exclamation, "Receive Materials!")
            Exit Sub
        End If
        'GetStockID()
        insertintostockindetails()
        InsertintoStockin()
        InsertintoStockinMaterials()
        Updatematerials()
        GetStockID()
        txtSupplierID.Text = ""
        ResetForm()
        MsgBox("Materials successfully Received.", MsgBoxStyle.Information, "Receive Materials")
    End Sub

    Private Sub VoidToolStripButton4_Click(sender As Object, e As EventArgs)
        Dim tot As Decimal
        If dtgCartItems.Rows(0).Cells(0).Value = Nothing Then
            MessageBox.Show("Please enter Item to Void ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try

            If MessageBox.Show("Are You Sure You want to Void the item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                dtgCartItems.Rows.Remove(dtgCartItems.CurrentRow)
            End If
        Catch ex As Exception
            MessageBox.Show("Please Select Item to Void", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally

        End Try

    End Sub

    Private Sub ClearToolStripButton_Click(sender As Object, e As EventArgs) Handles ClearToolStripButton.Click
        If MessageBox.Show("Are You Sure You Want to Reset the Form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            PopulateItemsCount()
            populateItems()
            LoadSchemes()
            cboSchemeName.Enabled = True
            txtDocumentNo.Enabled = True
            txtDeliveryNote.Enabled = True
            btnsupplierRS.Enabled = True
            lbldateRS.Enabled = True
            txtSchemeRef.Text = ""
            txtSupplNameRS.Text = ""
            txtDocumentNo.Text = ""
            txtDeliveryNote.Text = ""
            txtItemNo.Text = ""
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Me.Close()
    End Sub

    Private Sub dtgCartItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCartItems.CellContentDoubleClick
        Dim i As Integer
        i = dtgCartItems.CurrentRow.Index
        Me.txtItemNo.Text = dtgCartItems.Item(0, i).Value
        Me.cboSearchItem.Text = dtgCartItems.Item(1, i).Value
        Me.txtreceivedQty.Text = dtgCartItems.Item(2, i).Value
        'Me.txtUnitofIssue.Text = dtgCartItems.Item(4, i).Value
        dtgCartItems.Rows.Remove(dtgCartItems.CurrentRow)
    End Sub

    Private Sub ResetForm()
        PopulateItemsCount()
        populateItems()
        LoadSchemes()
        cboSchemeName.Enabled = True
        txtDocumentNo.Enabled = True
        txtDeliveryNote.Enabled = True
        btnsupplierRS.Enabled = True
        lbldateRS.Enabled = True
        txtSchemeRef.Text = ""
        txtSupplNameRS.Text = ""
        txtDocumentNo.Text = ""
        txtDeliveryNote.Text = ""
        txtreceivedQty.Text = ""
        txtTotalQty.Text = ""
        txtStckonHand.Text = ""
        txtItemNo.Text = ""
    End Sub

    Private Sub LookupToolStripButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtDocumentNo_TextChanged(sender As Object, e As KeyEventArgs) Handles txtDocumentNo.KeyUp

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class

