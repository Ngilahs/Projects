Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class frmAddUpdateExpenses
    Dim y As Integer
    Dim CW As Integer = Me.Width ' Current Width
    Dim CH As Integer = Me.Height ' Current Height
    Dim IW As Integer = Me.Width ' Initial Width
    Dim IH As Integer = Me.Height ' Initial Height
    Private Sub GetExpenseID()
        Try
            sqL = "SELECT ExpenseID FROM expense_details ORDER BY ExpenseID DESC"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtexpenseID.Text = dr("ExpenseID") + 1
            Else
                txtexpenseID.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub frmAddUpdateExpenses_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
        Next
       
        CW = Me.Width
        CH = Me.Height

    End Sub

    Private Sub LoadExpenseDetails()
        Try
            sqL = "SELECT * FROM expense_details "
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtexpenseID.Text = dr("ExpenseID")
                txtexpensename.Text = dr("Expense_Name")
                dtpExpensesDate.Text = dr("PaymentDate")
                txtExpenseAmt.Text = dr("Amount_Paid")
                txtpersonpaid.Text = dr("Person_paid")
                txtIDNo.Text = dr("ID_No")
                txtmobilephone.Text = dr("Mobile_Phone_No")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub UpdateExpenses()
        If txtexpenseID.Text = "" Or txtexpensename.Text = "" Or txtExpenseAmt.Text = "" Or txtpersonpaid.Text = "" Or txtmobilephone.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtexpensename.Focus()
            Exit Sub
        End If
        Try
            sqL = "UPDATE expense_details SET ExpenseID = '" & txtexpenseID.Text & "', Expense_Name = '" & txtexpensename.Text & "', PaymentDate = '" & dtpExpensesDate.Text & "', Amount_Paid = '" & CDec(txtExpenseAmt.Text) & "',  Person_paid ='" & txtpersonpaid.Text & "', ID_No = '" & txtIDNo.Text & "', Mobile_Phone_No = '" & txtmobilephone.Text & "', ExpAmtDue = '" & txtExpenseAmt.Text & "', ExpIDNo = '" & LBLEXPID.Text & "' WHERE ExpenseID = '" & txtexpenseID.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            MsgBox("Expense successfully Updated.", MsgBoxStyle.Information, "Update Expense")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtexpenseID.Text, TimeOfDay, "Updated Expense Information")
        ALLClearFields()
        GetExpenseID()
    End Sub
    Private Sub AddExpense()
        If txtexpenseID.Text = "" Or txtexpensename.Text = "" Or txtExpenseAmt.Text = "" Or LBLEXPID.Text = "" Or txtmobilephone.Text = "" Then
            MessageBox.Show("Please Fill All the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtexpensename.Focus()
            Exit Sub
        End If
        Try
            sqL = "INSERT INTO expense_details(ExpenseID, Expense_Name, PaymentDate, Amount_Paid, Person_paid, ID_No, Mobile_Phone_No, ExpAmtDue, ExpIDNo) Values('" & txtexpenseID.Text & "', '" & txtexpensename.Text & "', '" & dtpExpensesDate.Text.ToString & "', '" & txtExpenseAmt.Text & "', '" & txtpersonpaid.Text & "', '" & txtIDNo.Text & "', '" & txtmobilephone.Text & "', '" & txtExpenseAmt.Text & "', '" & LBLEXPID.Text & "')"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            MsgBox("Expense successfully added.", MsgBoxStyle.Information, "Expense Payment")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtexpenseID.Text, TimeOfDay, "Added New Expense")
        ALLClearFields()
        GetExpenseID()
    End Sub
    Private Sub frmExpenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor = Cursors.Default
        ClearFields()
        GetExpenseID()
        dtpExpensesDate.Text = Format(Now, "MM/dd/yyyy")
        IW = Me.Width
        IH = Me.Height
       
    End Sub
    Private Sub frmExpenses_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub ClearFields()
        'txtexpenseID.Text = ""
        txtexpensename.Text = ""
        txtExpenseAmt.Text = ""
        txtpersonpaid.Text = ""
        txtIDNo.Text = ""
        txtmobilephone.Text = ""
        txtExpenseDue.Text = ""
        LBLEXPID.Text = ""
    End Sub
    Private Sub ALLClearFields()
        txtexpenseID.Text = ""
        txtexpensename.Text = ""
        txtExpenseAmt.Text = ""
        txtpersonpaid.Text = ""
        txtIDNo.Text = ""
        txtmobilephone.Text = ""
        txtExpenseDue.Text = ""
        LBLEXPID.Text = ""
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub dgw_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellClick
        Dim i As Integer
        i = dgw.CurrentRow.Index
        Me.txtexpenseID.Text = dgw.Item(0, i).Value
        Me.txtexpensename.Text = dgw.Item(1, i).Value
        Me.dtpExpensesDate.Text = dgw.Item(2, i).Value
        Me.txtExpenseAmt.Text = dgw.Item(3, i).Value
        Me.txtpersonpaid.Text = dgw.Item(4, i).Value
        Me.txtIDNo.Text = dgw.Item(5, i).Value
        Me.txtmobilephone.Text = dgw.Item(6, i).Value
        Me.LBLEXPID.Text = dgw.Item(7, i).Value
        Me.txtExpenseDue.Text = dgw.Item(8, i).Value

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        ClearFields()
        GetExpenseID()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOEUpdateToolStripButton3.Click
        UpdateExpenses()
        'Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOESaveToolStripButton5.Click
        AddExpense()
        'Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub BtnLoadExpense_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadExpense.Click
        frmLoadExpense.ShowDialog()
    End Sub

    Private Sub txtsearchsname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearchsname.TextChanged
        Try
            sqL = "SELECT ExpenseID, Expense_Name, PaymentDate, Amount_Paid, Person_paid, Mobile_Phone_No, ID_No, ExpAmtDue, ExpIDNo from expense_details where Expense_Name LIKE '%" & txtsearchsname.Text & "%'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("ExpenseID"), dr("Expense_Name"), dr("PaymentDate"), dr("Amount_Paid"), dr("Person_paid"), dr("Mobile_Phone_No"), dr("ID_No"), dr("ExpIDNo"), dr("ExpAmtDue"))
                y += 17
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub BTNRESET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRESET.Click
        dgw.Rows.Clear()
    End Sub

  
    
End Class