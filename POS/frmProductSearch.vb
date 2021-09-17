Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Configuration
Public Class frmProductSearch
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqlr As String
    Dim y As Integer
    Dim rowIndex As Integer = 0
    'Dim rs As New Resizer
    Public Class Resizer
        'Public curcol, currow As Integer
        '----------------------------------------------------------
        ' ControlInfo
        ' Structure of original state of all processed controls
        '----------------------------------------------------------
        Private Structure ControlInfo
            'Public name As String
            'Public parentName As String
            'Public leftOffsetPercent As Double
            'Public topOffsetPercent As Double
            'Public heightPercent As Double
            'Public originalHeight As Integer
            'Public originalWidth As Integer
            'Public widthPercent As Double
            'Public originalFontSize As Single
        End Structure

        '-------------------------------------------------------------------------
        ' ctrlDict
        ' Dictionary of (control name, control info) for all processed controls
        '-------------------------------------------------------------------------
        Private ctrlDict As Dictionary(Of String, ControlInfo) = New Dictionary(Of String, ControlInfo)

        '----------------------------------------------------------------------------------------
        ' FindAllControls
        ' Recursive function to process all controls contained in the initially passed
        ' control container and store it in the Control dictionary
        '----------------------------------------------------------------------------------------
        Public Sub FindAllControls(ByVal thisCtrl As Control)

            '-- If the current control has a parent, store all original relative position
            '-- and size information in the dictionary.
            '-- Recursively call FindAllControls for each control contained in the
            '-- current Control
            'For Each ctl As Control In thisCtrl.Controls
            '    Try
            '        If Not IsNothing(ctl.Parent) Then
            '            Dim parentHeight = ctl.Parent.Height
            '            Dim parentWidth = ctl.Parent.Width

            '            Dim c As New ControlInfo
            '            c.name = ctl.Name
            '            c.parentName = ctl.Parent.Name
            '            c.topOffsetPercent = Convert.ToDouble(ctl.Top) / Convert.ToDouble(parentHeight)
            '            c.leftOffsetPercent = Convert.ToDouble(ctl.Left) / Convert.ToDouble(parentWidth)
            '            c.heightPercent = Convert.ToDouble(ctl.Height) / Convert.ToDouble(parentHeight)
            '            c.widthPercent = Convert.ToDouble(ctl.Width) / Convert.ToDouble(parentWidth)
            '            c.originalFontSize = ctl.Font.Size
            '            c.originalHeight = ctl.Height
            '            c.originalWidth = ctl.Width
            '            ctrlDict.Add(c.name, c)
            '        End If

            '    Catch ex As Exception
            '        Debug.Print(ex.Message)
            '    End Try

            '    If ctl.Controls.Count > 0 Then
            '        FindAllControls(ctl)
            '    End If

            'Next '-- For Each

        End Sub

        '----------------------------------------------------------------------------------------
        ' ResizeAllControls
        ' Recursive function to resize and reposition all controls contained in the Control
        ' dictionary
        '----------------------------------------------------------------------------------------
        'Public Sub ResizeAllControls(ByVal thisCtrl As Control)

        '    Dim fontRatioW As Single
        '    Dim fontRatioH As Single
        '    Dim fontRatio As Single
        '    Dim f As Font

        '    '-- Resize and reposition all controls in the passed control
        '    For Each ctl As Control In thisCtrl.Controls
        '        Try
        '            If Not IsNothing(ctl.Parent) Then
        '                Dim parentHeight = ctl.Parent.Height
        '                Dim parentWidth = ctl.Parent.Width

        '                Dim c As New ControlInfo

        '                Dim ret As Boolean = False
        '                Try
        '                    '-- Get the current control's info from the control info dictionary
        '                    ret = ctrlDict.TryGetValue(ctl.Name, c)

        '                    '-- If found, adjust the current control based on control relative
        '                    '-- size and position information stored in the dictionary
        '                    If (ret) Then
        '                        '-- Size
        '                        ctl.Width = Int(parentWidth * c.widthPercent)
        '                        ctl.Height = Int(parentHeight * c.heightPercent)

        '                        '-- Position
        '                        ctl.Top = Int(parentHeight * c.topOffsetPercent)
        '                        ctl.Left = Int(parentWidth * c.leftOffsetPercent)

        '                        '-- Font
        '                        f = ctl.Font
        '                        fontRatioW = ctl.Width / c.originalWidth
        '                        fontRatioH = ctl.Height / c.originalHeight
        '                        fontRatio = (fontRatioW +
        '                        fontRatioH) / 2 '-- average change in control Height and Width
        '                        ctl.Font = New Font(f.FontFamily,
        '                        c.originalFontSize * fontRatio, f.Style)

        '                    End If
        '                Catch
        '                End Try
        '            End If
        '        Catch ex As Exception
        '        End Try

        '        '-- Recursive call for controls contained in the current control
        '        If ctl.Controls.Count > 0 Then
        '            ResizeAllControls(ctl)
        '        End If

        '    Next '-- For Each
        'End Sub

    End Class

    Public Sub frmProductSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearchPrdct.Focus()
        'rs.FindAllControls(Me)
    End Sub
   
    Private Sub frmProductSearch_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        'rs.ResizeAllControls(Me)
    End Sub
    Private Sub txtSearchPrdct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchPrdct.TextChanged

        Dim Sprice As String
            Dim Uprice As String
            Dim Mkup As String
            Dim TotMkup As Decimal
            Dim vatrate As String = 16 / 116
            Dim MysqlConn As MySqlConnection
            Dim cmd As MySqlCommand
            MysqlConn = New MySqlConnection
             MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
            Dim dr As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Query As String
            Query = "SELECT ProductNo, Description, StocksOnHand, QtyperUoM, ReorderLevel, CateID, SubCateID, PrefSupplier, UnitofIssue FROM Product WHERE ProductNo LIKE '%" & txtSearchPrdct.Text & "%' OR Description LIKE '%" & txtSearchPrdct.Text & "%' ORDER BY Description DESC LIMIT 50"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dtgpdcts.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dtgpdcts.Rows.Add(dr("ProductNo"), dr("Description"), dr("QtyperUoM"), dr("StocksOnHand"), dr("StocksOnHand") / dr("QtyperUoM"), dr("UnitofIssue"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmProductSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim tot As Decimal
        Dim TotMkup As Decimal
        Dim vatrate As String = 16 / 116
        If FrmPointofSale.Visible Then
            If e.KeyCode = Keys.Enter Then
                Dim drr As New System.Windows.Forms.DataGridViewRow
                If dtgpdcts.CurrentRow.Cells(3).Value < 0 Then
                    'MessageBox.Show("Selling Price Cannot Be Less Than Buying Price ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If MessageBox.Show("Selling Price Cannot Be Less Than Buying Price!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                        dtgpdcts.Rows.Remove(dtgpdcts.CurrentRow)
                        If MessageBox.Show("Selling Price Cannot Be Less Than Buying Price!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                            dtgpdcts.Rows.Remove(dtgpdcts.CurrentRow)
                            Exit Sub
                        End If
                    End If
                    Me.Close()
                End If

                For Each drr In dtgpdcts.SelectedRows
                    FrmPointofSale.dgwIssueItems.Rows.Add(drr.Cells(0).Value, drr.Cells(1).Value, 1, drr.Cells(3).Value - 1, drr.Cells(4).Value)


                Next
                Me.Close()
            End If
        End If

        If frmPOS.Visible Then
            If e.KeyCode = Keys.Enter Then
                Dim drrs As New System.Windows.Forms.DataGridViewRow
                For Each drrs In dtgpdcts.SelectedRows
                    frmPOS.dtgCartItems.Rows.Add(drrs.Cells(0).Value, drrs.Cells(1).Value, 1, drrs.Cells(3).Value - 1, drrs.Cells(4).Value)

                Next
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    
    Private Sub BTNProductQuickedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmQuickEdit.Show()
    End Sub
    Private Sub DataGridView1_CellMouseUp_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgpdcts.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Me.dtgpdcts.Rows(e.RowIndex).Selected = True
            Me.rowIndex = e.RowIndex
            Me.dtgpdcts.CurrentCell = Me.dtgpdcts.Rows(e.RowIndex).Cells(1)
            Me.ContextMenuStrip1.Show(Me.dtgpdcts, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub
    Private Sub EditProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditProductToolStripMenuItem.Click
        If Not Me.dtgpdcts.Rows(Me.rowIndex).IsNewRow Then
            frmQuickEdit.Show()
            frmQuickEdit.LoadItemstoQuickEditfromgrid()
        End If
    End Sub

    Private Sub QuickPurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickPurchaseToolStripMenuItem.Click
        If Not Me.dtgpdcts.Rows(Me.rowIndex).IsNewRow Then
            frmStockIn.Show()
            frmStockIn.Loadproductdetailsfromdatagrid()
        End If
    End Sub

    Private Sub btnLCSExportExcel_Click(sender As Object, e As EventArgs) Handles btnLCSExportExcel.Click
        Dim Sprice As String
        Dim Uprice As String
        Dim Mkup As String
        Dim TotMkup As Decimal
        Dim vatrate As String = 16 / 116
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT ProductNo, Description, StocksOnHand, QtyperUoM, ReorderLevel, CateID, SubCateID, PrefSupplier, UnitofIssue FROM Product ORDER BY Description DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            dtgpdcts.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dtgpdcts.Rows.Add(dr("ProductNo"), dr("Description"), dr("QtyperUoM"), dr("StocksOnHand"), dr("StocksOnHand") / dr("QtyperUoM"), dr("UnitofIssue"))
                y += 17
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = dtgpdcts.RowCount
            colsTotal = dtgpdcts.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dtgpdcts.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dtgpdcts.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub
End Class

