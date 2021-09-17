Imports MySql.Data.MySqlClient
'Imports Microsoft.PointOfService
Imports System.Configuration
Imports System.IO
Public Class frmPrint
    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim y As Integer
    Private Sub LoadItemstoDatagrid()
        Try

            sql = "Select DI.Delivery_No, DI.Item_No, DI.Qty_Issued, DI.Qty_Rem, DI.Date_Issued, DI.Issue_Time, P.Description, P.UnitofIssue from delivery_items DI Inner Join product P on (DI.Item_No = P.ProductNo) Where DI.Delivery_No = '" & frmListofmaterials.dgw.CurrentRow.Cells(0).Value & "'"
            ConnDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            ListBox1.Text = ""
            ListBox2.Text = ""
            ListBox3.Text = ""
            y = 0
            Do While dr.Read = True
                ListBox1.Items.Add(dr("Item_No"))
                ListBox4.Items.Add(dr("Description"))
                'ListBox4.Items.Add(dr(""))
                ListBox2.Items.Add(dr("Qty_Issued"))
                ListBox3.Items.Add(dr("UnitofIssue"))
                'ListBox3.Items.Add(dr("Subtotal"))
                y += 24
            Loop
            ListBox1.Height += y
            ListBox2.Height += y
            ListBox3.Height += y
            ListBox4.Height += y
            'Panel2.Location = New Point(Me.Panel1.Location.X, Me.Panel1.Location.Y + ListBox1.Height)
            Panel1.Height += y
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub loadcompanyinfo()
        Try
            sql = "SELECT companydetailsID, ParentCoName, CompanyName, TelephoneNo, Email, VATNo, PINNo, Address, City, PostalCode, MpesaTillNo FROM companydetails"
            ConnDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                LblCName.Text = dr("CompanyName")
                lblPhysicaladdress.Text = dr("Address")
                lblStreet.Text = dr("TelephoneNo")
                lblpobox.Text = dr("MpesaTillNo")
                lblProject.Text = dr("PINNo")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub LoadReceiptInfo()
        Try
            sql = "Select DD.DeliveryNo, DD.IssueDate, DD.ItemCount, DD.SchemeId, DD.CountyId, DD.ConstituencyId, DD.UserName, DD.TillNo, DD.SessIDNo, DD.TimeX, S.Scheme_Name, C.County_Name, CN.constituency_Name FROM delivery_details DD inner join schemes S on (DD.SchemeId = S.SchemeNo) inner join county C on (DD.CountyId = C.County_No) inner join constituency CN on (CN.Constituency_No = DD.ConstituencyId) WHERE DD.DeliveryNo = '" & frmListofmaterials.dgw.CurrentRow.Cells(0).Value & "%'"
            ConnDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                LblDeliveryNo.Text = dr("DeliveryNo")
                LblDate.Text = Date.Now.ToString("MM/dd/yyyy")
                LblTime.Text = Date.Now.ToString("hh:mm:ss")
                lblTotalItems.Text = dr("ItemCount")
                lblCreatedBy.Text = (dr("UserName"))
                LblSchemeName.Text = dr("Scheme_Name")
                LblConstituency.Text = dr("constituency_Name")
                LblCounty.Text = dr("County_Name")
                LblApprovedBy.Text = dr("UserName")
                LBLSessionNo.Text = (dr("SessIDNo"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub saveimage()
        Dim x As Integer = Panel1.Location.X
        Dim y As Integer = Panel1.Location.Y
        Dim dock As DockStyle = Panel1.Dock
        Dim dgH As Integer = Panel1.Height
        Panel1.Visible = False
        Panel1.Dock = DockStyle.None
        Panel1.Location = New System.Drawing.Point(0, 0)
        'Panel1.Height = Panel1.ColumnHeadersHeight + (Panel1.Rows.Count * Panel1.RowTemplate.Height) + 3
        Dim bitmap As New Bitmap(Panel1.Bounds.Width, Panel1.Bounds.Height)
        Panel1.DrawToBitmap(bitmap, Panel1.Bounds)
        Panel1.Dock = dock
        Panel1.Location = New System.Drawing.Point(x, y)
        Panel1.Height = dgH
        Panel1.Visible = True
        'bitmap.Save(SFD.FileName)
        'End If
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub
    Private Sub frmPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadcompanyinfo()
        LoadItemstoDatagrid()
        LoadReceiptInfo()
        'PrintDocument1.Print()

        'Me.Close()
        Me.Show()

    End Sub
End Class