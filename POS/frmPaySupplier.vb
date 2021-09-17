Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmPaySupplier
    Dim y As Integer
    Private Sub GetPayID()
        Try
            sqL = "SELECT Pay_ID FROM pay_suppexpense ORDER BY Pay_ID DESC"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtPayID.Text = dr("Pay_ID") + 1
            Else
                txtPayID.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub Addpayforexpense()
        If txtPayID.Text = "" Or txtPayAmt.Text = "" Or lbldate.Text = "" Or txtStockID.Text = "" Or txtSuppExpName.Text = "" Or txtAmtPaid.Text = "" Or txtPayBalance.Text = "" Or txtPayVia.Text = "" Or txtpaymentmode.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPayAmt.Focus()
            Exit Sub
        End If
        Try
            sqL = "INSERT INTO pay_suppexpense(Pay_ID, Pay_Amt, Pay_Date, ExpStk_ID, SuppExp_Name, Amount_Paid, Balance_Amt,PayVia, ProdctExpnsDescrp) Values('" & txtPayID.Text & "', '" & txtPayAmt.Text & "', '" & lbldate.Text & "', '" & txtStockID.Text & "', '" & txtSuppExpName.Text & "', '" & txtAmtPaid.Text & "', '" & txtPayBalance.Text & "', '" & txtPayVia.Text & "', '" & txtpaymentmode.Text & "')"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            MsgBox("Pay successfully added.", MsgBoxStyle.Information, "Pay Supplier")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtPayID.Text, TimeOfDay, "Paid Supplier")
    End Sub
    Private Sub UpdateExpenseDetails()
        Try
            sqL = "UPDATE stockindetails SET DueAmt = DueAmt - '" & txtAmtPaid.Text & "'  WHERE  StockInDetailID = '" & txtStockID.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            'MsgBox("Expense successfully Updated.", MsgBoxStyle.Information, "Update Expense")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub frmPaySupplierExpense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbldate.Text = Format(Now, "MM/dd/yyyy")
        GetPayID()
        txtPayBalance.Text = ""
        txtAmtPaid.Text = ""
    End Sub
    Private Sub frmPaySupplierExpense_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub clearfields()
        'txtPayID.Text = ""
        txtPayAmt.Text = ""
        'lbldate.Text = ""
        txtStockID.Text = ""
        txtSuppExpName.Text = ""
        txtAmtPaid.Text = ""
        txtPayBalance.Text = ""
        txtPayVia.Text = ""
        txtpaymentmode.Text = ""
    End Sub
    Private Sub txtAmtPaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmtPaid.TextChanged
        txtPayBalance.Text = Val(txtDueAmt.Text) - Val(txtAmtPaid.Text)
    End Sub
    Private Sub txtAmtPaid_Keyup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmtPaid.KeyUp
        If Val(txtDueAmt.Text) < Val(txtAmtPaid.Text) Then
            MsgBox("Amount paid cannot be greater than Amount Due.", MsgBoxStyle.Information, "Pay Expense")
            txtAmtPaid.Clear()
            txtAmtPaid.Focus()
            Exit Sub
        End If
        If Val(txtAmtPaid.Text) > dgw.CurrentRow.Cells(5).Value Then
            MsgBox("Amount paid cannot be greater than Amount Due.", MsgBoxStyle.Information, "Pay Expense")
            txtAmtPaid.Clear()
            txtAmtPaid.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        clearfields()
        GetPayID()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PYSSaveToolStripButton5.Click
        Addpayforexpense()
        UpdateExpenseDetails()
        clearfields()
        GetPayID()
        'Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub txtbcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuppname.TextChanged
        Try
            sqL = "SELECT  StockInDetailID, TotalItem_Price, DateIn, Supplier_Name,  ModeofPurch, DueAmt FROM  stockindetails WHERE Supplier_Name LIKE '%" & txtSuppname.Text & "%'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("StockInDetailID"), dr("TotalItem_Price"), dr("DateIn"), dr("Supplier_Name"), dr("ModeofPurch"), dr("DueAmt"))
                y += 17
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.txtStockID.Text = dgw.Item(0, i).Value
        Me.txtPayAmt.Text = dgw.Item(1, i).Value
        Me.txtDateIn.Text = dgw.Item(2, i).Value
        Me.txtSuppExpName.Text = dgw.Item(3, i).Value
        Me.txtpaymentmode.Text = dgw.Item(4, i).Value
        Me.txtDueAmt.Text = dgw.Item(5, i).Value
        If Val(txtDueAmt.Text) = 0 Then
            MsgBox("Full Payment for this expense has been done.", MsgBoxStyle.Information, "Pay Expense")
            clearfields()
            GetPayID()
            Exit Sub
        End If
    End Sub

    Private Sub txtpname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpname.TextChanged
        Try
            sqL = "SELECT StockInDetailID, TotalItem_Price, DateIn, Supplier_Name,  ModeofPurch, DueAmt FROM  stockindetails WHERE TotalItem_Price LIKE '" & txtpname.Text & "%'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()

            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("StockInDetailID"), dr("TotalItem_Price"), dr("DateIn"), dr("Supplier_Name"), dr("ModeofPurch"), dr("DueAmt"))
                y += 17
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub Btnpaymode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnpaymode.Click
        frmLoadPaymentmode.ShowDialog()
    End Sub
End Class