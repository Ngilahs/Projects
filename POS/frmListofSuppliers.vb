Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmListofSuppliers
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqlr As String
    Dim y As Integer
    Dim dt As DataTable
    'Dim scAutoComplete As New AutoCompleteStringCollection
    Private Sub GetStockID()
        Try
            Dim con As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
            con.Open()
            sqlr = "SELECT StockInID FROM stockin ORDER BY StockInID DESC"
            cmd = New MySqlCommand(sqlr, con)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtStockinID.Text = dr("StockInID") + 1
            Else
                txtStockinID.Text = 1

            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
   

    Private Sub frmListofSuppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbldate.Text = Format(Now, "MM/dd/yyyy")
        'TXTITEMID.Focus()
        GetStockID()
        'GetSupplier()
        dtgCart.CurrentCell = dtgCart.Rows(0).Cells(0)
        dtgCart.Focus()
        'declaring a new textbox column in the datagridview
        'Dim txt As DataGridViewTextBoxColumn
        'adding a textbox column in the datagridview
        'dtgCart.Columns.Add(txt)

    End Sub
    Private Sub dtgCart_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs)
        '    Dim con As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
        '    'a set of commands in MySQL
        '    Dim cmd As New MySqlCommand
        '    'a Bridge between a database and datatable for retrieving and saving data.
        '    Dim da As New MySqlDataAdapter
        '    'a specific table in the database
        '    Dim dt As New DataTable

        '    'declare for a new textbox
        '    Dim txt As New TextBox
        '    con.Open()
        '    'set a new spicific table in the database 
        '    dt = New DataTable
        '    'set your commands for holding the data.
        '    With (cmd)
        '        .Connection = con
        '        .CommandText = "SELECT Supp_Name FROM suppliers"
        '    End With
        '    'filling the table in the database
        '    da.SelectCommand = cmd
        '    da.Fill(dt)

        '    Dim r As DataRow 'represents a row of data in the datatable
        '    For Each r In dt.Rows 'get a collection of rows that belongs to this table
        '        'the control shown to the user for editing the selected cell value
        '        If dtgCart.CurrentCell.ColumnIndex = 7 AndAlso TypeOf e.Control Is TextBox Then
        '            txt = e.Control
        '            'adding the specific row of the table in the AutoCompleteCustomSource of the textbox
        '            txt.AutoCompleteCustomSource.Add(r.Item("Supp_Name").ToString)
        '            txt.AutoCompleteMode = AutoCompleteMode.Suggest
        '            txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        '        End If
        '    Next
        '    'closing the connection
        '    con.Close()

        '    AddHandler e.Control.KeyPress, AddressOf dtgCart_KeyPress
    End Sub

    Private Sub dtgCart_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCart.CellEndEdit

        'dtgCart.CurrentRow.Cells(4).Value = dtgCart.CurrentRow.Cells(2).Value * dtgCart.CurrentRow.Cells(3).Value
        dtgCart.CurrentRow.Cells(5).Value = dtgCart.CurrentRow.Cells(5).Value - dtgCart.CurrentRow.Cells(3).Value


        Dim tot As Double
        Dim Bcode1 As String
        Dim Bcode2 As String
        Dim code As String
        Dim Sprice As String
        Dim Uprice As String
        Dim Mkup As Decimal
        Dim Avgprice As Decimal
        Dim Prvamt As Decimal
        Dim currntTotAmt As Decimal

        Try
            Dim conr As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
            conr.Open()

            sqlr = "SELECT Barcode, Description, UnitPrice, StocksOnHand, Selling_Price, ProductCode, UnitPrice FROM Product Where Barcode  = '" & dtgCart.CurrentRow.Cells(0).Value & "' OR ProductCode  = '" & dtgCart.CurrentRow.Cells(0).Value & "'"

            cmd = New MySqlCommand(sqlr, conr)
            dr = cmd.ExecuteReader

            Dim qty As Decimal = 0
            If dtgCart.CurrentRow.Cells(2).Value = Nothing Then
                qty = 1
            Else
                qty = dtgCart.CurrentRow.Cells(2).Value

            End If

            While (dr.Read() = True)
                Dim vat As Decimal
                Dim stockhand As Decimal
                Dim vatrate As Decimal = 16 / 116

                Bcode1 = dr("Barcode")
                Bcode2 = dr("ProductCode")
                stockhand = dr("StocksOnHand")

                Sprice = dr("Selling_Price")
                Uprice = dr("UnitPrice")

                Prvamt = stockhand * Uprice

               

                'Initial Unit Cost
                Dim unitcost As Decimal = 0
                If dtgCart.CurrentRow.Cells(3).Value = Nothing Then
                    unitcost = dr("UnitPrice")
                Else
                    unitcost = dtgCart.CurrentRow.Cells(3).Value
                End If

                'Initial Total sales
                Dim TotAmty As Decimal = 0
                If dtgCart.CurrentRow.Cells(4).Value = qty * unitcost Then
                    TotAmty = qty * unitcost
                Else
                    TotAmty = dtgCart.CurrentRow.Cells(4).Value
                    'unitcost = TotAmty / qty
                    'dtgCart.CurrentRow.Cells(2).Value = unitcost
                End If

                'Enter different barcodes
                If dtgCart.CurrentRow.Cells(0).Value = Bcode1 Then
                    Bcode1 = code
                    code = dtgCart.CurrentRow.Cells(0).Value
                Else
                    If dtgCart.CurrentRow.Cells(0).Value = Bcode2 Then
                        Bcode2 = code
                        code = dtgCart.CurrentRow.Cells(0).Value
                    End If
                End If
                'calculate vat
                vat = Format((Sprice * vatrate), "#,##0.00")

                Mkup = dtgCart.CurrentRow.Cells(6).Value - dtgCart.CurrentRow.Cells(3).Value
                dtgCart.CurrentRow.Cells(7).Value = Format((Mkup), "#,##0.00")


                ''dtgCart.CurrentRow.Cells(3).Value = dtgCart.CurrentRow.Cells(4).Value / dtgCart.CurrentRow.Cells(2).Value

                dtgCart.CurrentRow.SetValues(code, dr(1), qty, Format((unitcost), "#,##0.00"), TotAmty, vat, dr(4), Format((Mkup), "#,##0.00"), stockhand, stockhand + qty, ((qty * unitcost) + Prvamt) / (stockhand + qty))
            End While
            conr.Close()
            'Calculate total sales amount
            For i = 0 To dtgCart.Rows.Count - 1
                tot += dtgCart.Rows(i).Cells(4).Value
            Next
            LBLTotSale.Text = Format(tot, "#,##0.00")

            btnaddQty.Enabled = True
            btnVoid.Enabled = True
            btneditUCost.Enabled = True
            BtnAmt.Enabled = True
            GetStockID()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub

    'Private Sub dtgCart_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
    '    'If e.ColumnIndex = 4 Then
    '    '    e.Cancel = True
    '    'End If
    '    If e.ColumnIndex = 1 Then
    '        e.Cancel = True
    '    End If
    '    'If e.ColumnIndex = 5 Then
    '    '    e.Cancel = True
    '    'End If
    '    'If e.ColumnIndex = 6 Then
    '    '    e.Cancel = True
    '    'End If
    'End Sub
    'Private Sub dtgCart_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
    '    'If e.ColumnIndex = 4 AndAlso
    '    '    e.RowIndex - 1 Then
    '    '    e.Value = Convert.ToDouble(dtgCart(2, e.RowIndex).Value) * Convert.ToDouble(dtgCart(3, e.RowIndex).Value)
    '    'End If
    'End Sub
    'Private Sub dtgCart_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    dtgCart.Refresh()
    'End Sub
    'Private Sub dtgCart_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs)

    '    'If dtgCart.Item(e.ColumnIndex + 3, e.RowIndex).Value Is Nothing Then
    '    ' Show the user a message
    '    'MsgBox("Please ensure the cell has been given a value")

    '    ' Fail validation (prevent them from leaving the cell)
    '    'e.Cancel = True
    '    'End If

    'End Sub

    Private Sub dtgCart_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If dtgCart.CurrentCell.ColumnIndex = 0 Or _
            dtgCart.CurrentCell.ColumnIndex = 2 Or _
            dtgCart.CurrentCell.ColumnIndex = 3 Then
            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then
                        e.Handled = False '
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Deleteemptyrows()
        Try
            Dim conmy As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
            conmy.Open()
            sqlr = "Delete from stockIn where ProductBarcode = '';"
            cmd = New MySqlCommand(sqlr, conmy)
            dr = cmd.ExecuteReader
            conmy.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
        End Try
    End Sub
    Private Sub UpdateTransaction()
        If Len(Trim(txtSupplName.Text)) = 0 Then
            MessageBox.Show("Please enter Suuplier Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSupplName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtPurchamode.Text)) = 0 Then
            MessageBox.Show("Please enter Purchase Terms", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPurchamode.Focus()
            Exit Sub
        End If
        Try
            For Each r As DataGridViewRow In dtgCart.Rows
                Dim conm As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
                conm.Open()
                sqlr = "INSERT INTO stockIn (StockInID, ProductBarcode, Quantity, TotalItem_Price, Markup, VAT, Supplier_Name,  ModeofPurch, DateIn) " & _
                          " VALUES (" & txtStockinID.Text & ",'" & r.Cells(0).FormattedValue & "','" & r.Cells(2).FormattedValue & _
                          "','" & CDec(r.Cells(3).FormattedValue) & "', '" & r.Cells(5).FormattedValue & "', '" & r.Cells(6).FormattedValue & "',  '" & txtSupplName.Text & "', '" & txtPurchamode.Text & "', '" & lbldate.Text & "')"
                Dim cmdi As New MySqlCommand
                Dim dri As MySqlDataReader
                cmdi = New MySqlCommand(sqlr, conm)
                dri = cmdi.ExecuteReader
                conm.Close()

                For i = 0 To dtgCart.Rows.Count - 1
                    Dim coni As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
                    coni.Open()
                    sqlr = "UPDATE product SET StocksOnHand = '" & dtgCart.Rows(i).Cells(2).Value & "' WHERE Barcode = '" & dtgCart.Rows(i).Cells(0).Value & "' OR ProductCode = '" & dtgCart.Rows(i).Cells(0).Value & "'"
                    cmd = New MySqlCommand(sqlr, coni)
                    dr = cmd.ExecuteReader
                    coni.Close()
                Next
                For j = 0 To dtgCart.Rows.Count - 1
                    Dim coni As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
                    coni.Open()
                    sqlr = "UPDATE product SET UnitPrice = '" & dtgCart.Rows(j).Cells(4).Value & "' WHERE Barcode = '" & dtgCart.Rows(j).Cells(0).Value & "' OR ProductCode = '" & dtgCart.Rows(j).Cells(0).Value & "'"
                    cmd = New MySqlCommand(sqlr, coni)
                    dr = cmd.ExecuteReader
                    coni.Close()
                Next
            Next
            dtgCart.Rows.Clear()
            MsgBox("Stocks successfully added.", MsgBoxStyle.Information, "Add Stocks")
            LBLTotSale.Text = 0.0
            txtSupplName.Clear()
            txtPurchamode.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
        Deleteemptyrows()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        UpdateTransaction()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub btnaddQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddQty.Click
        Dim iCol = dtgCart.CurrentCell.ColumnIndex
        Dim iRow = dtgCart.CurrentCell.RowIndex
        If iCol = dtgCart.Columns.Count - 1 Then
            If iRow < dtgCart.Rows.Count - 1 Then
                dtgCart.CurrentCell = dtgCart(0, iRow + 1)
            End If
        Else
            dtgCart.CurrentCell = dtgCart(iCol + 2, iRow)
        End If

        Dim tot As Double
        Try

            Dim conr As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
            conr.Open()

            sqlr = "SELECT Barcode, Description, StocksOnHand, UnitPrice, VatCode, Selling_Price, ProductCode FROM Product Where Barcode  = '" & dtgCart.CurrentRow.Cells(0).Value & "'"

            cmd = New MySqlCommand(sqlr, conr)
            dr = cmd.ExecuteReader
            While (dr.Read() = True)
                Dim stqty As String
                Dim UP As String
                Dim v As Integer
                Dim inpt, inpt2 As Decimal
                Dim col1, col2, col3, col4, col5, col6 As String
                stqty = dr("StocksOnHand")
                UP = dr("UnitPrice")
                Dim totalAmt As String
                Dim Sprice As String

                totalAmt = stqty * UP
                Sprice = dr("Selling_Price")

                For Each R As DataGridViewRow In dtgCart.Rows

                    v = R.Selected

                    If v = -1 Then
                        col1 = R.Cells(1).FormattedValue
                        col2 = R.Cells(2).FormattedValue
                        col3 = R.Cells(3).FormattedValue
                        col4 = R.Cells(4).FormattedValue
                        col5 = R.Cells(5).FormattedValue
                        col6 = R.Cells(6).FormattedValue

                        inpt = InputBox("Item: " & R.Cells(1).FormattedValue, "Add Quantity", R.Cells(2).FormattedValue)

                        col2 = inpt + stqty
                        R.Cells(2).Value = col2

                        inpt2 = InputBox("Item: " & R.Cells(1).FormattedValue, "Enter Amount", R.Cells(3).FormattedValue)

                        col3 = Format((inpt2 + totalAmt), "#,##0.00")

                        R.Cells(3).Value = col3

                        col4 = Format((col3 / col2), "#,##0.00")
                        R.Cells(4).Value = col4
                        col5 = Format((Sprice - col4), "#,##0.00")
                        R.Cells(5).Value = col5
                        col6 = Format((Sprice * 16 / 116), "#,##0.00")
                        R.Cells(6).Value = col6
                        'col6 = col2 - col4
                        'R.Cells(4).Value = col4
                        'R.Cells(5).Value = Format((col5), "#,##0.00")
                        'R.Cells(6).Value = col6
                        'TXTITEMID.Focus()
                        'Sprice = dr("Selling_Price")
                        'UP = dr("UnitPrice")
                        'If UP > Sprice Then
                        '    MessageBox.Show("Buying price cannot be greater than Selling Price", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '    Exit Sub
                        'End If
                    End If
                Next
            End While

            conr.Close()

            For i = 0 To dtgCart.Rows.Count - 1
                tot += dtgCart.Rows(i).Cells(3).FormattedValue

            Next
            LBLTotSale.Text = Format((tot), "#,##0.00")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub TToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TToolStripMenuItem.Click
        Call btnaddQty_Click(sender, e)
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        Try
            dtgCart.Rows.Remove(dtgCart.CurrentRow)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub VoidToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoidToolStripMenuItem.Click
        Call btnVoid_Click(sender, e)
    End Sub
    Private Sub btnsupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsupplier.Click
        frmLoadSupplier.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        GetStockID()
        dtgCart.Rows.Clear()
        LBLTotSale.Text = 0.0
        txtSupplName.Clear()
        txtPurchamode.Clear()
        TXTITEMID.Focus()
    End Sub

    Private Sub btnpurchasemode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpurchasemode.Click
        frmLoadPurchaseterms1.ShowDialog()
    End Sub
    Private Sub btneditUCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditUCost.Click
        Dim iCol = dtgCart.CurrentCell.ColumnIndex
        Dim iRow = dtgCart.CurrentCell.RowIndex
        If iCol = dtgCart.Columns.Count - 1 Then
            If iRow < dtgCart.Rows.Count - 1 Then
                dtgCart.CurrentCell = dtgCart(0, iRow + 1)
            End If
        Else
            dtgCart.CurrentCell = dtgCart(iCol + 3, iRow)
        End If

    End Sub

    Private Sub BtnAmt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAmt.Click
        Dim iCol = dtgCart.CurrentCell.ColumnIndex
        Dim iRow = dtgCart.CurrentCell.RowIndex
        If iCol = dtgCart.Columns.Count - 1 Then
            If iRow < dtgCart.Rows.Count - 1 Then
                dtgCart.CurrentCell = dtgCart(0, iRow + 1)
            End If
        Else
            dtgCart.CurrentCell = dtgCart(iCol + 4, iRow)
        End If
    End Sub
    Private Sub TENDEREDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TENDEREDToolStripMenuItem.Click
        Call BtnAmt_Click(sender, e)
    End Sub
    Private Sub AddQtyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddQtyToolStripMenuItem.Click
        Call btneditUCost_Click(sender, e)
    End Sub

    Private Sub TXTITEMID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTITEMID.TextChanged
        Dim code As String
        Dim totalAmount As Decimal
        Dim Sprc As String
        Dim qtys As String
        Dim UPrc As String
        Dim TotalAmt As Decimal
        Dim vat As Decimal
        Dim vatrate As Decimal = 16 / 116
        Try
            Dim itemid As String = TXTITEMID.Text
            Dim tot As Double
            Dim conr As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
            conr.Open()
            sqlr = "SELECT Barcode, Description, UnitPrice, StocksOnHand, VatCode, Selling_Price, ProductCode FROM product Where Barcode  = '" & itemid & "'"
            cmd = New MySqlCommand(sqlr, conr)
            dr = cmd.ExecuteReader

            Dim qty As Decimal = 0
            If dtgCart.CurrentRow.Cells(3).Value = Nothing Then
                qty = 1
            Else
                qty = dtgCart.CurrentRow.Cells(3).Value
            End If

            While (dr.Read() = True)
                qtys = dr("StocksOnHand")
                UPrc = dr("UnitPrice")
                Sprc = dr("Selling_Price")

                'TotalAmt = Val(qtys) * dr(2)
                'Dim dr3 As Decimal
                'If dr(2) = 0 Then
                '    dr3 = 0
                'Else
                '    dr3 = Format((TotalAmt / dr(2)), "#,##0.00")
                'End If

                'Dim dr4 As Decimal
                'If dr(2) = 0 Then
                '    dr4 = 0
                'Else
                '    dr4 = Format((Sprc - dr3), "#,##0.00")
                'End If

                'If dr3 = 0 Then
                '    VAT = 0
                'Else
                '    VAT = Format((Sprc * vatrate), "#,##0.00")
                'End If
                dtgCart.CurrentRow.SetValues(dr(0), dr(1), qty, dr(2), qty * dr(2), qty * dr(2), qty * dr(2), qty * dr(2), qty * dr(2))

                TXTITEMID.Clear()
                TXTITEMID.Focus()
                conr.Close()
            End While

            For i = 0 To dtgCart.Rows.Count - 1
                tot += dtgCart.Rows(i).Cells(3).Value
            Next

            LBLTotSale.Text = Format(tot, "#,##0.00")

            btnaddQty.Enabled = True
            btnVoid.Enabled = True
            TXTITEMID.Focus()
            dtgCart.RowHeadersVisible = False
        Catch ex As Exception
            Dim errormsg As String = ex.Message
            '    MsgBox(ex.Message)
        End Try
        GetStockID()
    End Sub
End Class