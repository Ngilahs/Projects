Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Configuration

Public Class FrmMain
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Dim y As Integer
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddUpdateCategory.MdiParent = Me
        frmAddUpdateCategory.Show()
    End Sub

    Public Sub GetSessionID()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SessionID, ClosingAmt FROM sessionzin ORDER BY SessionID DESC"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                If dr("ClosingAmt") > "0.00" Then
                    ''SessionIDToolStripStatus.Text = dr("SessionID") + 1
                Else
                    'SessionIDToolStripStatus.Text = dr("SessionID")
                End If
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnDB()
        getData()
        SaveData()
        'frmUserRights.ShowDialog()
        frmUserRights.CboUsers.Text = frmLogin.txtUsername.Text
        frmUserRights.getuserpermission()
        frmUserRights.updatepermissions()
        frmUserRights.Close()
        'Call frmUserRights.frmUserRights_Load(sender, e)
        'lblDate.Text = Format(Now, "MM/dd/yyyy")
        'lblTimer.Text = TimeOfDay
        LBLComputerName.Text = Environment.MachineName
        AddHandler Microsoft.Win32.SystemEvents.PowerModeChanged, AddressOf PowerModeChanged
        AddHandler Microsoft.Win32.SystemEvents.SessionEnding, AddressOf Handler_SessionEnding
        GetSessionID()

    End Sub
    Public Sub Handler_SessionEnding(ByVal sender As Object, ByVal e As Microsoft.Win32.SessionEndingEventArgs)
        If e.Reason = Microsoft.Win32.SessionEndReasons.Logoff Then
            MessageBox.Show("User is logging off")
        ElseIf e.Reason = Microsoft.Win32.SessionEndReasons.SystemShutdown Then
            MessageBox.Show("System is shutting down")
        End If
    End Sub
    Private Sub PowerModeChanged(ByVal sender As System.Object, ByVal e As Microsoft.Win32.PowerModeChangedEventArgs)
        Select Case e.Mode
            Case Microsoft.Win32.PowerModes.Resume
                MessageBox.Show("Windows is resuming from sleep")
            Case Microsoft.Win32.PowerModes.Suspend
                MessageBox.Show("Goodnite Team")
        End Select
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmPOS.Visible = True Then
            MsgBox("Receive Stock input form is in active! Close it before exit", MsgBoxStyle.Information)
            frmPOS.Focus()
            e.Cancel = True
        Else
            Dim dr As Object
            If e.CloseReason = CloseReason.UserClosing Then
                dr = MsgBox("Exit Application..?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question)
                If dr = vbYes Then
                    frmLogin.Dispose()
                    'Me.NotifyIcon.Dispose()
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            End If
        End If

    End Sub


    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addupdateproductToolStripMenuItem.Click
        frmAddUpdateProduct.MdiParent = Me
        frmAddUpdateProduct.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStaff.MdiParent = Me
        frmStaff.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductToolStripButton2.Click
        frmAddUpdateProduct.MdiParent = Me
        frmAddUpdateProduct.Show()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmListofMPESASales.MdiParent = Me
        'frmListofMPESASales.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApprovalToolStripButton6.Click
        frmDeliveryApproval.MdiParent = Me
        frmDeliveryApproval.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POSToolStripButton5.Click
        'FrmPointofSale.MdiParent = Me
        'FrmPointofSale.Show()
        frmMaterialIssuance.MdiParent = Me
        frmMaterialIssuance.Show()
    End Sub

    Private Sub POSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        'frmAddUpdateSupplier.MdiParent = Me
        'frmAddUpdateSupplier.Show()
        frmPOS.MdiParent = Me
        frmPOS.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmCategoryList.MdiParent = Me
        'frmCategoryList.Show()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripButton8.Click
        frmPOS.MdiParent = Me
        frmPOS.Show()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialDeliveryNoteToolStripButton7.Click
        RPTMaterialDeliveryNote.MdiParent = Me
        RPTMaterialDeliveryNote.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockInToolStripButton1.Click
        RPTItemReceipts.MdiParent = Me
        RPTItemReceipts.Show()
    End Sub

    Private Sub DailySalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RPTMaterialDeliveryNote.MdiParent = Me
        RPTMaterialDeliveryNote.Show()
    End Sub

    Private Sub ExpensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdjuststockToolStripMenuItem.Click
        FrmStockAdjustment.MdiParent = Me
        FrmStockAdjustment.Show()
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialIssuedToolStripButton9.Click
        frmMaterialsIssued.MdiParent = Me
        frmMaterialsIssued.Show()
    End Sub

    Private Sub VatToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SalesDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'RpSalesProductRP.MdiParent = Me
        'RpSalesProductRP.Show()
    End Sub

    Private Sub StockPurchasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmRPTStockIn.MdiParent = Me
        'frmRPTStockIn.Show()
    End Sub

    Private Sub ExpensesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'RPTExpenses.MdiParent = Me
        'RPTExpenses.Show()
    End Sub

    Private Sub PaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPaySupplier.MdiParent = Me
        frmPaySupplier.Show()

    End Sub

    Private Sub PayExpensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmExpense.MdiParent = Me
        'frmExpense.Show()
    End Sub

    Private Sub PaySuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmcashpaidout.MdiParent = Me
        frmcashpaidout.Show()
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliverytoschemesToolStripButton10.Click
        RPTMaterialIssueScheme.MdiParent = Me
        RPTMaterialIssueScheme.Show()
    End Sub

    Private Sub TestReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailysalesReportToolStripMenuItem.Click
        RPTMaterialDeliveryNote.MdiParent = Me
        RPTMaterialDeliveryNote.Show()
    End Sub

    Private Sub ProductwiseSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductwiseSalesToolStripMenuItem.Click
        RPTProductwise.MdiParent = Me
        RPTProductwise.Show()
    End Sub

    Private Sub StockPurchasesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockPurchasesReportToolStripMenuItem.Click
        RPTItemReceipts.MdiParent = Me
        RPTItemReceipts.Show()
    End Sub

    Private Sub ExpensesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchemeReportToolStripMenuItem.Click
        RPTMaterialIssueScheme.MdiParent = Me
        RPTMaterialIssueScheme.Show()
    End Sub

    Private Sub SummaryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentReportToolStripMenuItem.Click
        RPTMaterialsReceivedforPeriod.MdiParent = Me
        RPTMaterialsReceivedforPeriod.Show()
    End Sub

    Private Sub ProductStatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductwisepurchasesToolStripMenuItem.Click
        RPTProductHistory.MdiParent = Me
        RPTProductHistory.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        'frmLogin.Show()
        'Me.Show()
        'tsslUser.Text = UCase(frmLogin.txtUsername.Text)
        ''frmUserRights.ShowDialog()
        ''Update Audit Trail Table
        'Audit_Trail(tsslUser.Text, tsslUser.Text, TimeOfDay, "LoggedIn to the System")
        ''isCashier = True
        ''isAdmin = True
        'frmUserRights.CboUsers.Text = frmLogin.txtUsername.Text
        'frmUserRights.getuserpermission()
        'frmUserRights.updatepermissions()
        'frmUserRights.Close()
        'frmLogin.txtUsername.Text = ""
        'frmLogin.txtPassword.Text = ""
        'frmLogin.txtUsername.Focus()
        ''Update Audit Trail Table
        'Audit_Trail(tsslUser.Text, tsslUser.Text, TimeOfDay, "LoggedOut of the System")

    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SearchProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductlookupToolStripMenuItem.Click
        frmProductSearch.MdiParent = Me
        frmProductSearch.Show()
    End Sub

    Private Sub PaymentsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmListofSuppliers.MdiParent = Me
        frmListofSuppliers.Show()
    End Sub
    Private Sub ReceiveGoodsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveGoodsToolStripMenuItem.Click
        frmPOS.MdiParent = Me
        frmPOS.Show()
    End Sub

    Private Sub ListOfGoodsReceivedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmListPurchases.MdiParent = Me
        'frmListPurchases.Show()
    End Sub

    Private Sub NewSubcategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSubcategoryToolStripMenuItem.Click
        frmSubCategory.MdiParent = Me
        frmSubCategory.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Schemes2ToolStripMenuItem.Click
        frmScheme.MdiParent = Me
        frmScheme.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupdatabaseToolStripMenuItem.Click
        frmbackuprestoredb.MdiParent = Me
        frmbackuprestoredb.Show()
    End Sub

    Private Sub ListOfCashSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmListofStock.MdiParent = Me
        frmListofStock.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addsystemusersToolStripMenuItem6.Click
        frmAddUpdateStaff.MdiParent = Me
        frmAddUpdateStaff.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAttendance.MdiParent = Me
        frmAttendance.Show()
    End Sub

    Private Sub HowDoIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEmployeeAttendanceRecord.MdiParent = Me
        frmEmployeeAttendanceRecord.Show()
    End Sub

    Private Sub PayExpenseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUpdateMaterialDel.MdiParent = Me
        frmUpdateMaterialDel.Show()
    End Sub

    Private Sub PaySupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPaySupplier.MdiParent = Me
        frmPaySupplier.Show()
    End Sub

    Private Sub PaymentModesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEmployee_registration.MdiParent = Me
        frmEmployee_registration.Show()
    End Sub

    Private Sub PurchaseTermsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmPurchasemode.MdiParent = Me
        'frmPurchasemode.Show()
        FrmPointofSale.MdiParent = Me
        FrmPointofSale.Show()
    End Sub

    Private Sub CompanyDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyDetailsToolStripMenuItem.Click
        frmCompanyDetails.MdiParent = Me
        frmCompanyDetails.Show()
    End Sub
    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AudittrailToolStripMenuItem5.Click
        frmAudittrail.MdiParent = Me
        frmAudittrail.Show()
    End Sub

    Private Sub LookUpStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListofStockrcvedToolStripMenuItem.Click
        frmListofStock.MdiParent = Me
        frmListofStock.Show()
    End Sub

    Private Sub ReturnGoodsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceivetoolssToolStripMenuItem.Click
        'frmTransformstock.MdiParent = Me
        'frmTransformstock.Show()
        frmReceiveTools.MdiParent = Me
        frmReceiveTools.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmChangePassword.MdiParent = Me
        frmChangePassword.Show()
    End Sub
    Private Sub VoidItemsListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoidItemsListToolStripMenuItem.Click
        frmVoidItems.MdiParent = Me
        frmVoidItems.Show()
    End Sub

    Private Sub ItemJournalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductJournalToolStripMenuItem.Click
        frmProductJournal.MdiParent = Me
        frmProductJournal.Show()
    End Sub

    Private Sub SetUserAccessRightsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetUserAccessRightsToolStripMenuItem.Click
        frmUserRights.MdiParent = Me
        frmUserRights.Show()
    End Sub

    Private Sub VatToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmVATSetting.MdiParent = Me
        frmVATSetting.Show()
    End Sub
    Private Sub DatabaseToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseToolStripMenuItem.Click
        frmDatabase.MdiParent = Me
        frmDatabase.Show()
    End Sub
    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        If MessageBox.Show("Are You Sure You want to Close Application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub QuickStockPurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsAllocationPurchaseToolStripMenuItem.Click
        frmIssueTools.MdiParent = Me
        frmIssueTools.Show()
    End Sub
    Private Sub ActivationToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivationToolStripMenuItem.Click
        frmActivation.MdiParent = Me
        frmActivation.Show()
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Update Audit Trail Table
        Audit_Trail(tsslUser.Text, tsslUser.Text, TimeOfDay, "LoggedIn to the System")
        Me.Close()
        'frmLogin.Show()
        'frmLogin.txtUsername.Text = ""
        'frmLogin.txtPassword.Text = ""
        'frmLogin.txtUsername.Focus()

    End Sub

    Private Sub StaffToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddUpdateStaff.MdiParent = Me
        frmAddUpdateStaff.Show()
    End Sub

    Private Sub ToolStripButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCompanyDetails.MdiParent = Me
        frmCompanyDetails.Show()
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAudittrail.MdiParent = Me
        frmAudittrail.Show()
    End Sub

    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUserRights.MdiParent = Me
        frmUserRights.Show()
    End Sub

    Private Sub ToolStripButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmListofmaterials.MdiParent = Me
        frmListofmaterials.Show()
    End Sub

    Private Sub CreditPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmcreditpayment.MdiParent = Me
        'frmcreditpayment.Show()
    End Sub

    Private Sub MonthlySummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountyMaterialToolStripMenuItem.Click
        RPTMaterialIssuanceCounty.MdiParent = Me
        RPTMaterialIssuanceCounty.Show()
    End Sub

    Private Sub OpeningClosingStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmStockAdjustment.MdiParent = Me
        FrmStockAdjustment.Show()
    End Sub

    Private Sub CashFlowStatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''frmCashFlow.MdiParent = Me
        ''frmCashFlow.Show()
    End Sub

    Private Sub ProfitLossAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmProfitLossAccount.MdiParent = Me
        frmProfitLossAccount.Show()
    End Sub

    Private Sub OpeningBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FrmOpeningBal.MdiParent = Me
        'FrmOpeningBal.Show()
    End Sub

    Private Sub CashPaidOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmcashpaidout.MdiParent = Me
        frmcashpaidout.Show()
    End Sub

    Private Sub ZoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LaunchPOSToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaunchPOSToolStripMenuItem2.Click
        Call BtnLaunchPOS_Click(sender, e)
    End Sub
    Private Sub BuyStockToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyStockToolStripMenuItem2.Click
        Call BtnBuyStock_Click(sender, e)
    End Sub
    Private Sub BtnLaunchPOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMaterialIssuance.MdiParent = Me
        frmMaterialIssuance.Show()
    End Sub

    Private Sub BtnBuyStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPOS.MdiParent = Me
        frmPOS.Show()
    End Sub
    Private Sub ItemLookUpToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemLookUpToolStripMenuItem2.Click
        'Call BtnItemLookup_Click(sender, e)
        frmDeliveryApproval.MdiParent = Me
        frmDeliveryApproval.Show()
    End Sub

    Private Sub BtnItemLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItemLookup.Click
        frmProductSearch.MdiParent = Me
        frmProductSearch.Show()
    End Sub


    Private Sub CashsalesToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateToolsToolStripButton1.Click
        frmInvoicing.MdiParent = Me
        frmInvoicing.Show()
    End Sub
    Private Sub UserLogToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserLogToolStripButton2.Click
        frmAudittrail.MdiParent = Me
        frmAudittrail.Show()
    End Sub

    Private Sub PrivilagesToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrivilagesToolStripButton3.Click
        frmUserRights.MdiParent = Me
        frmUserRights.Show()
    End Sub

    Private Sub ListOfCreditSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmToolsReceived.MdiParent = Me
        frmToolsReceived.Show()
    End Sub

    Private Sub ListOfMPesaSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmIssuedTools.MdiParent = Me
        frmIssuedTools.Show()
    End Sub

    Private Sub POSSessionHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmPOSSessionHistory.MdiParent = Me
        'frmPOSSessionHistory.Show()
    End Sub

    Private Sub DetailedReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ChartOfAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmChartofAccounts.MdiParent = Me
        'frmChartofAccounts.Show()
    End Sub

    Private Sub ReverseSaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmRejectionIn.MdiParent = Me
        frmRejectionIn.Show()
    End Sub

    Private Sub LToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmListofmaterials.MdiParent = Me
        frmListofmaterials.Show()
    End Sub

    Private Sub CountyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountyToolStripMenuItem.Click
        frmCounty.MdiParent = Me
        frmCounty.Show()
    End Sub

    Private Sub ConstituencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstituencyToolStripMenuItem.Click
        frmConstituencies.MdiParent = Me
        frmConstituencies.Show()
    End Sub

    Private Sub DeparmentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmDepartment.MdiParent = Me
        frmDepartment.Show()
    End Sub

    Private Sub DesignationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmWorkCategory.MdiParent = Me
        frmWorkCategory.Show()
    End Sub

    Private Sub ConstituencyMaterialIssuanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstituencyMaterialIssuanceToolStripMenuItem.Click
        RPTMaterialIssueConstituency.MdiParent = Me
        RPTMaterialIssueConstituency.Show()
    End Sub

    Private Sub GroupMaterialPerCountyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupMaterialPerCountyToolStripMenuItem.Click
        RPTGroupedMaterialCounty.MdiParent = Me
        RPTGroupedMaterialCounty.Show()
    End Sub

    Private Sub GroupMaterialPerSchemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupMaterialPerSchemeToolStripMenuItem.Click
        RPTGroupMaterialPerScheme.MdiParent = Me
        RPTGroupMaterialPerScheme.Show()
    End Sub

    Private Sub GroupMaterialDeliveryPerConstituencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupMaterialDeliveryPerConstituencyToolStripMenuItem.Click
        RPTGroupedMaterialConstituency.MdiParent = Me
        RPTGroupedMaterialConstituency.Show()
    End Sub

    Private Sub GroupMaterialReversedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupMaterialReversedToolStripMenuItem.Click
        RPTMaterialsReversed.MdiParent = Me
        RPTMaterialsReversed.Show()
    End Sub
    Private Sub ReturnIssuanceToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReturnIssuanceToolStripMenuItem.Click
        frmRejectionIn.MdiParent = Me
        frmRejectionIn.Show()
    End Sub

    Private Sub IssueMaterialsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CreateToolsToolStripMenuItem2.Click
        frmCreateTools.MdiParent = Me
        frmCreateTools.Show()
    End Sub

    Private Sub MaterialReceiptsPerDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialReceiptsPerDateToolStripMenuItem.Click
        MaterialGroupedReceipts.MdiParent = Me
        MaterialGroupedReceipts.Show()
    End Sub

    Private Sub MnuDeliveryApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmDeliveryApproval.MdiParent = Me
        frmDeliveryApproval.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MetersToolStripMenuItem.Click

    End Sub

    Private Sub DeliveryApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub CreateToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        frmCreateTools.MdiParent = Me
        frmCreateTools.Show()
    End Sub

    Private Sub CreateRolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateRolesToolStripMenuItem.Click
        frmRole.MdiParent = Me
        frmRole.Show()
    End Sub

    Private Sub CreateStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateStaffToolStripMenuItem.Click
        frmEmployees.MdiParent = Me
        frmEmployees.Show()
    End Sub

    Private Sub SchemeMaterialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchemeMaterialsToolStripMenuItem.Click
        frmLoadSchemeMaterials.MdiParent = Me
        frmLoadSchemeMaterials.Show()
    End Sub

    Private Sub SessionIDToolStripStatus_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        frmAddUpdateSupplier.MdiParent = Me
        frmAddUpdateSupplier.Show()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ReturnToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolsToolStripMenuItem.Click
        frmReturnTools.MdiParent = Me
        frmReturnTools.Show()
    End Sub

    Private Sub UpdateMaterialDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmUpdateDelivery.MdiParent = Me
        frmUpdateDelivery.Show()
    End Sub

    Private Sub IssuancePerDocumentNoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RPTConsolidatedMaterialsIssuedtosub.MdiParent = Me
        RPTConsolidatedMaterialsIssuedtosub.Show()
    End Sub

    Private Sub IssueMaterialsToSubContractorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'frmIssueSubContractor.MdiParent = Me
        'frmIssueSubContractor.Show()
    End Sub

    Private Sub CreateSubContractorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateSubContractorToolStripMenuItem.Click
        frmSubcontractors.MdiParent = Me
        frmSubcontractors.Show()
    End Sub

    Private Sub ListOfMaterialsReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmListofmaterials.MdiParent = Me
        frmListofmaterials.Show()
    End Sub

    Private Sub CancelMaterialReceiptsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelMaterialReceiptsToolStripMenuItem.Click
        frmReceiptCancel.MdiParent = Me
        frmReceiptCancel.Show()
    End Sub

    Private Sub VehiclesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiclesToolStripMenuItem.Click
        frmVehicles.MdiParent = Me
        frmVehicles.Show()
    End Sub

    Private Sub ConsolidatedMaterialIssuanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsolidatedMaterialIssuanceToolStripMenuItem.Click
        frmConsolidatedMaterialIssuance.MdiParent = Me
        frmConsolidatedMaterialIssuance.Show()
    End Sub

    Private Sub MaterialReceivedPerSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialReceivedPerSupplierToolStripMenuItem.Click
        RPTMaterialsReceivedPerSupplier.MdiParent = Me
        RPTMaterialsReceivedPerSupplier.Show()
    End Sub

    Private Sub ListOfSubContractorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfSubContractorsToolStripMenuItem.Click
        frmListofSubcontractors.MdiParent = Me
        frmListofSubcontractors.Show()
    End Sub

    Private Sub SubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubToolStripMenuItem.Click
        frmAssignSubScheme.MdiParent = Me
        frmAssignSubScheme.Show()
    End Sub

    Private Sub MaterialReceivedPerCountyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialReceivedPerCountyToolStripMenuItem.Click
        frmMaterialReceivedPerCounty.MdiParent = Me
        frmMaterialReceivedPerCounty.Show()
    End Sub

    Private Sub MaterialIssuanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialIssuanceToolStripMenuItem.Click
        frmMaterialIssuance.MdiParent = Me
        frmMaterialIssuance.Show()
    End Sub

    Private Sub ListOfAvailableStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfAvailableStockToolStripMenuItem.Click
        RptAvailableMaterials.MdiParent = Me
        RptAvailableMaterials.Show()
    End Sub

    Private Sub UpdateMaterialReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMaterialReceiptToolStripMenuItem.Click
        frmUpdateReceipts.MdiParent = Me
        frmUpdateReceipts.Show()
    End Sub

    Private Sub BatchIssueanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDeliveryToolStripMenuItem.Click
        frmUpdateDelivery.MdiParent = Me
        frmUpdateDelivery.Show()
    End Sub

    Private Sub MaterialsIssuedToSubContractorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialsIssuedToSubContractorToolStripMenuItem.Click
        RPTMaterialIssuedtoCounty.MdiParent = Me
        RPTMaterialIssuedtoCounty.Show()
    End Sub

    Private Sub LoadMaterialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadMaterialsToolStripMenuItem.Click
        frmLoadMaterials.MdiParent = Me
        frmLoadMaterials.Show()
    End Sub

    Private Sub MaterialHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialHistoryToolStripMenuItem.Click
        RptMaterialssuedtowholeproject.MdiParent = Me
        RptMaterialssuedtowholeproject.Show()
    End Sub
    Private Sub MaterialsIssuedVsReturnedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialsIssuedVsReturnedToolStripMenuItem.Click
        RPTMaterialIssuedvsReturned.MdiParent = Me
        RPTMaterialIssuedvsReturned.Show()
    End Sub

    Private Sub BillingItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingItemsToolStripMenuItem.Click
        frmBillingItems.MdiParent = Me
        frmBillingItems.Show()
    End Sub

    Private Sub InvoicingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmInvoicing.MdiParent = Me
        frmInvoicing.Show()
    End Sub

    Private Sub InvoiceApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmInvoiceapproval.MdiParent = Me
        frmInvoiceapproval.Show()
    End Sub

    Private Sub UpdateInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmInvoiceUpdate.MdiParent = Me
        frmInvoiceUpdate.Show()
    End Sub

    Private Sub ListOfInvoicesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmListofInvoices.MdiParent = Me
        frmListofInvoices.Show()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub WarehousesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WarehousesToolStripMenuItem.Click
        frmWarehouses.MdiParent = Me
        frmWarehouses.Show()
    End Sub

    Private Sub TransportersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransportersToolStripMenuItem.Click
        frmTransporter.MdiParent = Me
        frmTransporter.Show()
    End Sub

    Private Sub TransportRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransportRegisterToolStripMenuItem.Click
        frmTransporterRegister.MdiParent = Me
        frmTransporterRegister.Show()
    End Sub

    Private Sub UpdateRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRegisterToolStripMenuItem.Click
        frmTransportRegisterUpdate.MdiParent = Me
        frmTransportRegisterUpdate.Show()
    End Sub

    Private Sub UpdateReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmUpdateMtrlReceived.MdiParent = Me
        frmUpdateMtrlReceived.Show()
    End Sub

    Private Sub SubContrctStatementToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RPTSubcontractorstatement.MdiParent = Me
        RPTSubcontractorstatement.Show()
    End Sub

    Private Sub ApproveDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApproveDeliveryToolStripMenuItem.Click
        frmDeliveryApproval.MdiParent = Me
        frmDeliveryApproval.Show()
    End Sub

    Private Sub MaterialsIssuedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialsIssuedToolStripMenuItem.Click
        frmListofmaterials.MdiParent = Me
        frmListofmaterials.Show()
    End Sub

    Private Sub ToolsReceivedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolsReceivedToolStripMenuItem.Click
        frmToolsReceived.MdiParent = Me
        frmToolsReceived.Show()
    End Sub

    Private Sub ToolsIssuedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolsIssuedToolStripMenuItem.Click
        frmIssuedTools.MdiParent = Me
        frmIssuedTools.Show()
    End Sub

    Private Sub MaterialIssuedPerSubContractorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialIssuedPerSubContractorToolStripMenuItem.Click
        RPTConsolidatedMaterialsIssuedtosub.MdiParent = Me
        RPTConsolidatedMaterialsIssuedtosub.Show()
    End Sub

    Private Sub MeterInstallationStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeterInstallationStatementToolStripMenuItem.Click
        'frmMeteringStmnt.MdiParent = Me
        'frmMeteringStmnt.Show()
    End Sub

    Private Sub VATSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VATSettingsToolStripMenuItem.Click
        frmVATSetting.MdiParent = Me
        frmVATSetting.Show()
    End Sub

    Private Sub ReceiveMetersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveMetersToolStripMenuItem.Click
        frmReceiveMeters.MdiParent = Me
        frmReceiveMeters.Show()
    End Sub

    Private Sub IssueMetersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueMetersToolStripMenuItem.Click
        frmIssueMeters.MdiParent = Me
        frmIssueMeters.Show()
    End Sub

    Private Sub UpdateCustomerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCustomerDetailsToolStripMenuItem.Click
        frmUpdateCustomerlist.MdiParent = Me
        frmUpdateCustomerlist.Show()
    End Sub

    Private Sub TechncianBoQToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TechncianBoQToolStripMenuItem.Click
        frmTechBOQ.MdiParent = Me
        frmTechBOQ.Show()
    End Sub

    Private Sub SchemeCustomerListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchemeCustomerListToolStripMenuItem.Click
        RPTSchemeMeterList.MdiParent = Me
        RPTSchemeMeterList.Show()
    End Sub

    Private Sub CountyCustomerListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountyCustomerListToolStripMenuItem.Click
        RPTCountyCustomerList.MdiParent = Me
        RPTCountyCustomerList.Show()
    End Sub

    Private Sub ProjectCustomerListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectCustomerListToolStripMenuItem.Click
        RPTProjectCustomerList.MdiParent = Me
        RPTProjectCustomerList.Show()
    End Sub

    Private Sub SearchCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchCustomerToolStripMenuItem.Click
        frmProjectCustomerListSummary.MdiParent = Me
        frmProjectCustomerListSummary.Show()
    End Sub

    Private Sub MaterialsIssuedToProjectPerSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialsIssuedToProjectPerSupplierToolStripMenuItem.Click
        RPTMaterialsIssuedtoProjectPerSupplier.MdiParent = Me
        RPTMaterialsIssuedtoProjectPerSupplier.Show()
    End Sub

    Private Sub ConstituencyCustomerListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstituencyCustomerListToolStripMenuItem.Click

    End Sub

    Private Sub MeterStatementToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RPTMeterInstallationStmnt.MdiParent = Me
        RPTMeterInstallationStmnt.Show()
    End Sub

    Private Sub PrintStatementToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrintStatementToolStripMenuItem1.Click
        RPTMeterInstallationStmnt.MdiParent = Me
        RPTMeterInstallationStmnt.Show()
    End Sub

    Private Sub MeteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeteToolStripMenuItem.Click
        frmMeteringStmnt.MdiParent = Me
        frmMeteringStmnt.Show()
    End Sub

    Private Sub MaterialSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialSummaryToolStripMenuItem.Click

    End Sub

    Private Sub ReceivedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceivedToolStripMenuItem.Click
        RptAvailableMaterials.MdiParent = Me
        RptAvailableMaterials.Show()
    End Sub

    Private Sub FilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilterToolStripMenuItem.Click
        frmProductSearch.MdiParent = Me
        frmProductSearch.Show()
    End Sub

    Private Sub FilterMaterialIssuedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilterMaterialIssuedToolStripMenuItem.Click
        frmMaterialsDelivered.MdiParent = Me
        frmMaterialsDelivered.Show()
    End Sub

    Private Sub IssuedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssuedToolStripMenuItem.Click
        frmConsolidatedMaterialIssuance.MdiParent = Me
        frmConsolidatedMaterialIssuance.Show()
    End Sub

    Private Sub FilterMateraislReceivedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilterMateraislReceivedToolStripMenuItem.Click
        frmMaterialsrecieved.MdiParent = Me
        frmMaterialsrecieved.Show()
    End Sub

    Private Sub DeliveredToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeliveredToolStripMenuItem.Click
        RPTMaterialsReceivedforPeriod.MdiParent = Me
        RPTMaterialsReceivedforPeriod.Show()
    End Sub

    Private Sub StatementSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatementSummaryToolStripMenuItem.Click
        frmListofInvoices.MdiParent = Me
        frmListofInvoices.Show()
    End Sub

    Private Sub MeterInstallationSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeterInstallationSummaryToolStripMenuItem.Click
        frmMeterInstallationCost.MdiParent = Me
        frmMeterInstallationCost.Show()
    End Sub

    Private Sub LineConstructionSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LineConstructionSummaryToolStripMenuItem.Click
        frmLineConstructionCost.MdiParent = Me
        frmLineConstructionCost.Show()
    End Sub

    Private Sub JMCToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles JMCToolStripMenuItem.Click
        frmJMCDetails.MdiParent = Me
        frmJMCDetails.Show()
    End Sub

    Private Sub UpdateJMCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateJMCToolStripMenuItem.Click
        frmUpdateJMC.MdiParent = Me
        frmUpdateJMC.Show()
    End Sub

    Private Sub ReceiveTransformerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveTransformerToolStripMenuItem.Click
        frmReceiveTransformer.MdiParent = Me
        frmReceiveTransformer.Show()
    End Sub

    Private Sub IssueTransformerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueTransformerToolStripMenuItem.Click
        frmIssueTransformer.MdiParent = Me
        frmIssueTransformer.Show()
    End Sub

    Private Sub PaymentStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentStatusToolStripMenuItem.Click
        frmPaymentStatus.MdiParent = Me
        frmPaymentStatus.Show()
    End Sub

    Private Sub SchemeStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchemeStatusToolStripMenuItem.Click
        frmSchemePaymentStatus.MdiParent = Me
        frmSchemePaymentStatus.Show()
    End Sub

    Private Sub TransformerDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransformerDeliveryToolStripMenuItem.Click
        RPTTransformerdelivery.MdiParent = Me
        RPTTransformerdelivery.Show()
    End Sub

    Private Sub TransformersIssuedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransformersIssuedToolStripMenuItem.Click
        RPTTransformersIssued.MdiParent = Me
        RPTTransformersIssued.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click

    End Sub

    Private Sub BillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingToolStripMenuItem.Click

    End Sub

    Private Sub SchemeMeterRBSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchemeMeterRBSummaryToolStripMenuItem.Click
        RPTSchemeMeterRBReport.MdiParent = Me
        RPTSchemeMeterRBReport.Show()
    End Sub

    Private Sub GenerateStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateStatementToolStripMenuItem.Click
        frmInvoicing.MdiParent = Me
        frmInvoicing.Show()
    End Sub

    Private Sub ApproveStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApproveStatementToolStripMenuItem.Click
        frmInvoiceapproval.MdiParent = Me
        frmInvoiceapproval.Show()
    End Sub

    Private Sub UpdateStatementToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateStatementToolStripMenuItem1.Click
        frmInvoiceUpdate.MdiParent = Me
        frmInvoiceUpdate.Show()
    End Sub

    Private Sub PrintStatementToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PrintStatementToolStripMenuItem2.Click
        RPTSubcontractorstatement.MdiParent = Me
        RPTSubcontractorstatement.Show()
    End Sub

    Private Sub ListOfStatementsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListOfStatementsToolStripMenuItem1.Click
        frmListofInvoices.MdiParent = Me
        frmListofInvoices.Show()
    End Sub

    Private Sub StockAdjustmentReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockAdjustmentReportToolStripMenuItem.Click
        RptStockAdjustment.MdiParent = Me
        RptStockAdjustment.Show()
    End Sub
End Class