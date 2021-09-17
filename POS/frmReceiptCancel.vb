Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Configuration
Public Class frmReceiptCancel
    Dim y As Integer
    Private Sub frmReceiptCancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadMaterialReceipts()
        lbldateRS.Text = Format(Now, "MM/dd/yyyy")
        txtDoccccNo.Text = "0ZXXXXX00012100005851111100"

    End Sub
    Private Sub LoadMaterialReceipts()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            'stockindetails(StockInDetailID, DateIn, SuppID, ReceivedBy, DocumentNo, DeliveryNo, SchemeID
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT StockInDetailID, DateIn, SuppID, ReceivedBy, DocumentNo, SchemeID from stockindetails where StockInDetailID  LIKE '%" & txtSearchReceiptNo.Text & "%'  " '"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Dim x As ListViewItem
            dgw1.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw1.Rows.Add(dr("StockInDetailID"), dr("DateIn"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ListView1_Doubleclick(sender As Object, e As EventArgs)
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            'StockInDetailID, DateIn, SuppID, ReceivedBy, DocumentNo, DeliveryNo, SchemeID from stockindetails
            MysqlConn.Open()
            Dim Query As String
            Query = "Select S.StockInDetailID, S.DateIn, S.DocumentNo, S.SchemeID, S.SuppID, SS.Scheme_Name, SS.SchemeNo, SP.Supplier_ID, SP.Supp_Name FROM stockindetails S inner join schemes SS on (S.SchemeId = SS.SchemeNo) inner join suppliers SP on (SP.Supplier_ID = S.SuppID) WHERE S.StockInDetailID = '" & dgw1.CurrentCell.Value & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                LblReceiptNo.Text = dr("StockInDetailID")
                txtIssuancedate.Text = dr("DateIn")
                txtSchemeName.Text = dr("Scheme_Name")
                txtSupplier.Text = dr("Supp_Name")
                txtSchemeID.Text = dr("Scheme_Name")
                txtDocuNo.Text = dr("DocumentNo")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        LoadReceiptItems()
    End Sub

    Private Sub LoadReceiptItems()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            'StockInID, PNO, Quantity, QtyRem, Supplier_Name, DateIn, DocumentNo, DeliveryNo, SchemeID
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT S.StockInID, S.PNO, S.Quantity, S.Supplier_Name, S.DateIn, S.DocumentNo, S.SchemeID, P.Description FROM stockin S Inner Join product P on (P.ProductNo = S.PNo) Where S.StockInID = '" & LblReceiptNo.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dgw.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgw.Rows.Add(dr("StockInID"), dr("PNO"), dr("Description"), dr("Quantity"), dr("DocumentNo"), dr("DateIn"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub AddCancelReceipts()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        ' MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_cancelreceipts(ReceiptNo, Date, Cancelledby) VALUES ('" & LblReceiptNo.Text & "', '" & lbldateRS.Text & "', '" & FrmMain.tsslUser.Text & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, LblReceiptNo.Text, TimeOfDay, "Cancelled Delivery")

    End Sub

    Private Sub UpdateStockIn()
        'Update Quantity
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        For i = 0 To dgw.Rows.Count - 1
            Try
                MysqlConny.Open()
                Dim Querys As String
                Querys = "UPDATE stockin SET Quantity = Quantity - '" & dgw.Rows(i).Cells(3).Value & "' WHERE StockInID = '" & LblReceiptNo.Text & "' and PNO = '" & dgw.Rows(i).Cells(1).Value & "'"
                cmd = New MySqlCommand(Querys, MysqlConny)
                dr = cmd.ExecuteReader
                MysqlConny.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConny.Dispose()
            End Try
        Next
    End Sub
    Private Sub UpdateStockInmaterials()
        'Update Quantity
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        For i = 0 To dgw.Rows.Count - 1
            Try
                MysqlConny.Open()
                Dim Querys As String
                Querys = "UPDATE stockinmaterials SET Quantity = Quantity - '" & dgw.Rows(i).Cells(3).Value & "' WHERE StockInID = '" & LblReceiptNo.Text & "' and PNO = '" & dgw.Rows(i).Cells(1).Value & "'"
                cmd = New MySqlCommand(Querys, MysqlConny)
                dr = cmd.ExecuteReader
                MysqlConny.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConny.Dispose()
            End Try
        Next
    End Sub

    Private Sub UpdateMaterials()
        'Update Quantity
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        For i = 0 To dgw.Rows.Count - 1
            Try
                MysqlConny.Open()
                Dim Querys As String
                Querys = "UPDATE product SET StocksOnHand = StocksOnHand - '" & dgw.Rows(i).Cells(3).Value & "' WHERE ProductNo = '" & dgw.Rows(i).Cells(1).Value & "'"
                cmd = New MySqlCommand(Querys, MysqlConny)
                dr = cmd.ExecuteReader
                MysqlConny.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConny.Dispose()
            End Try
        Next
        'dtgCartItems.Rows.Clear()
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, LblReceiptNo.Text, TimeOfDay, "Updated Materials from Cancel Receipt")
    End Sub
    Private Sub UpdateDocumentNo()
        'Update Quantity
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        Try
            MysqlConny.Open()
            Dim Querys As String
            Querys = "UPDATE stockindetails SET DocumentNo = '" & txtDoccccNo.Text & "'"
            cmd = New MySqlCommand(Querys, MysqlConny)
            dr = cmd.ExecuteReader
            MysqlConny.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConny.Dispose()
        End Try
    End Sub
    Private Sub UpdateDocumentNoinStockin()
        'Update Quantity
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        For i = 0 To dgw.Rows.Count - 1
            Try
                MysqlConny.Open()
                Dim Querys As String
                Querys = "UPDATE stockin SET DocumentNo = '" & txtDoccccNo.Text & "' WHERE StockInID = '" & LblReceiptNo.Text & "' and PNO = '" & dgw.Rows(i).Cells(1).Value & "' and DocumentNo = '" & txtDocuNo.Text & "'"
                cmd = New MySqlCommand(Querys, MysqlConny)
                dr = cmd.ExecuteReader
                MysqlConny.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConny.Dispose()
            End Try
        Next
    End Sub
    Private Sub UpdateDocumentNoinStockinmaterials()
        'Update Quantity
        Dim MysqlConny As MySqlConnection
        Dim cmdy As MySqlCommand
        MysqlConny = New MySqlConnection
        MysqlConny = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dry As MySqlDataReader
        For i = 0 To dgw.Rows.Count - 1
            Try
                MysqlConny.Open()
                Dim Querys As String
                Querys = "UPDATE stockinmaterials SET DocumentNo = '" & txtDoccccNo.Text & "' WHERE StockInID = '" & LblReceiptNo.Text & "' and PNO = '" & dgw.Rows(i).Cells(1).Value & "' and DocumentNo = '" & txtDocuNo.Text & "'"
                cmd = New MySqlCommand(Querys, MysqlConny)
                dr = cmd.ExecuteReader
                MysqlConny.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConny.Dispose()
            End Try
        Next
    End Sub
    Private Sub CancelReceiptToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelReceiptToolStripButton.Click
        If MessageBox.Show("Are You Sure You want to Cancel this receipt?Please Confirm", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            AddCancelReceipts()
            UpdateMaterials()
            UpdateStockIn()
            UpdateStockInmaterials()
            UpdateDocumentNo()
            UpdateDocumentNoinStockin()
            UpdateDocumentNoinStockinmaterials()
        Else
            Exit Sub
        End If
        MsgBox("Materials Receipt successfully Cancelled.", MsgBoxStyle.Information, "Cancel Materials")
        Me.Close()
    End Sub

    Private Sub txtSearchReceiptNo_TextChanged(sender As Object, e As EventArgs) Handles txtSearchReceiptNo.TextChanged
        LoadMaterialReceipts()
    End Sub

    Private Sub dgw1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw1.CellContentClick
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            'StockInDetailID, DateIn, SuppID, ReceivedBy, DocumentNo, DeliveryNo, SchemeID from stockindetails
            MysqlConn.Open()
            Dim Query As String
            Query = "Select S.StockInDetailID, S.DateIn, S.DocumentNo, S.DeliveryNo, S.SchemeID, S.SuppID, SS.Scheme_Name, SS.SchemeNo, SP.Supplier_ID, SP.Supp_Name FROM stockindetails S inner join schemes SS on (S.SchemeId = SS.SchemeNo) inner join suppliers SP on (SP.Supplier_ID = S.SuppID) WHERE S.StockInDetailID = '" & dgw1.CurrentCell.Value & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                LblReceiptNo.Text = dr("StockInDetailID")
                txtIssuancedate.Text = dr("DateIn")
                txtSchemeName.Text = dr("Scheme_Name")
                txtSupplier.Text = dr("Supp_Name")
                txtSchemeID.Text = dr("Scheme_Name")
                txtDocuNo.Text = dr("DocumentNo")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        LoadReceiptItems()
    End Sub
End Class