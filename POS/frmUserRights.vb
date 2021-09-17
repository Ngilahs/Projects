
Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmUserRights
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Dim y As Integer
    Private Sub frmUserRights_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        UpdateAdministratorAlways()
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub menupermission()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If chkFilemenu.Checked = True Then
            FrmMain.FileToolStripMenuItem.Enabled = True
        Else
            FrmMain.FileToolStripMenuItem.Enabled = False
        End If
        If chckMaterialsmenu.Checked = True Then
            FrmMain.MastersToolStripMenuItem.Enabled = True
        Else
            FrmMain.MastersToolStripMenuItem.Enabled = False
        End If
        If chkInventory.Checked = True Then
            FrmMain.InventoryToolStripMenuItem.Enabled = True
        Else
            FrmMain.InventoryToolStripMenuItem.Enabled = False
        End If
        If chckSchemes.Checked = True Then
            FrmMain.SchemeToolStripMenuItem.Enabled = True
        Else
            FrmMain.SchemeToolStripMenuItem.Enabled = False
        End If
        'If chckRegisters.Checked = True Then
        '    FrmMain.RegistersToolStripMenuItem.Enabled = True
        'Else
        '    FrmMain.RegistersToolStripMenuItem.Enabled = False
        'End If
        If chckReports.Checked = True Then
            FrmMain.ReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReportToolStripMenuItem.Enabled = False
        End If
        If ChkAdministration.Checked = True Then
            FrmMain.ProjectSummaryToolStripMenuItem4.Enabled = True
        Else
            FrmMain.ProjectSummaryToolStripMenuItem4.Enabled = False
        End If
        If chkTools.Checked = True Then
            FrmMain.ToolStripMenuItem1.Enabled = True
        Else
            FrmMain.ToolStripMenuItem1.Enabled = False
        End If

        'file Menu
        If ChkCompanydetails.Checked = True Then
            FrmMain.CompanyDetailsToolStripMenuItem.Enabled = True
        Else
            FrmMain.CompanyDetailsToolStripMenuItem.Enabled = False
        End If
        If chkchangepassword.Checked = True Then
            FrmMain.ChangePasswordToolStripMenuItem.Enabled = True
        Else
            FrmMain.ChangePasswordToolStripMenuItem.Enabled = False
        End If
        If chcklogout.Checked = True Then
            FrmMain.ExitToolStripMenuItem.Enabled = True
        Else
            FrmMain.ExitToolStripMenuItem.Enabled = False
        End If
        'Masters 
        If Chkaddupdateproduct.Checked = True Then
            FrmMain.addupdateproductToolStripMenuItem.Enabled = True
        Else
            FrmMain.addupdateproductToolStripMenuItem.Enabled = False
        End If
        If chkCategory.Checked = True Then
            FrmMain.CategoryToolStripMenuItem.Enabled = True
        Else
            FrmMain.CategoryToolStripMenuItem.Enabled = False
        End If
        If chkSubcategory.Checked = True Then
            FrmMain.NewSubcategoryToolStripMenuItem.Enabled = True
        Else
            FrmMain.NewSubcategoryToolStripMenuItem.Enabled = False
        End If
        If chkAdjuststock.Checked = True Then
            FrmMain.AdjuststockToolStripMenuItem.Enabled = True
        Else
            FrmMain.AdjuststockToolStripMenuItem.Enabled = False
        End If
        If chckSearchProduct.Checked = True Then
            FrmMain.ProductlookupToolStripMenuItem.Enabled = True
        Else
            FrmMain.ProductlookupToolStripMenuItem.Enabled = False
        End If
        If chkProductJournal.Checked = True Then
            FrmMain.ProductJournalToolStripMenuItem.Enabled = True
        Else
            FrmMain.ProductJournalToolStripMenuItem.Enabled = False
        End If
        'Transactions Menu
        If ChkaddReceiveMaterials.Checked = True Then
            'FrmMain.ReceiveMaterialsToolStripMenuItem.Enabled = True
        Else
            'FrmMain.ReceiveMaterialsToolStripMenuItem.Enabled = True
        End If
        If chkIssueMaterials.Checked = True Then
            'FrmMain.IssueMaterialsToolStripMenuItem.Enabled = True
        Else
            'FrmMain.IssueMaterialsToolStripMenuItem.Enabled = False
        End If
        If chkreceivestock.Checked = True Then
            FrmMain.ReceiveGoodsToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReceiveGoodsToolStripMenuItem.Enabled = False
        End If
        If chkreturnmaterials.Checked = True Then
            FrmMain.ReturnIssuanceToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReturnIssuanceToolStripMenuItem.Enabled = False
        End If
        If chkreceivetools.Checked = True Then
            FrmMain.ReceivetoolssToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReceivetoolssToolStripMenuItem.Enabled = False
        End If
        'Customers Menu 
        If chkaddupdatecutomers.Checked = True Then
            FrmMain.Schemes2ToolStripMenuItem.Enabled = True
        Else
            FrmMain.Schemes2ToolStripMenuItem.Enabled = False
        End If
        If chklistofcashsales.Checked = True Then
            'FrmMain.ListOfCashSalesToolStripMenuItem.Enabled = True
        Else
            'FrmMain.ListOfCashSalesToolStripMenuItem.Enabled = False
        End If
        'Finance Menu Paymentmodes, NewExpense, ListofExpense, Payexpense, Paysupplier,  Vatdetails
        If chkDeliveryApproval.Checked = True Then
            'FrmMain.PaymentModesToolStripMenuItem.Enabled = True
        Else
            'FrmMain.PaymentModesToolStripMenuItem.Enabled = False
        End If
        If chkSchemes.Checked = True Then
            FrmMain.Schemes2ToolStripMenuItem.Enabled = True
        Else
            FrmMain.Schemes2ToolStripMenuItem.Enabled = False
        End If
        If chkConstituency.Checked = True Then
            FrmMain.ListofexpensesoolStripMenuItem.Enabled = True
        Else
            FrmMain.ListofexpensesoolStripMenuItem.Enabled = False
        End If
        If chkCounty.Checked = True Then
            'FrmMain.PayExpenseToolStripMenuItem.Enabled = True
        Else
            'FrmMain.PaySupplierToolStripMenuItem.Enabled = True
        End If
        If chkReverseIssuance.Checked = True Then
            'FrmMain.PaySupplierToolStripMenuItem.Enabled = True
        Else
            'FrmMain.PaySupplierToolStripMenuItem.Enabled = False
        End If
        If chkVatdetails.Checked = True Then
            'FrmMain.VatToolStripMenuItem.Enabled = True
        Else
            'FrmMain.VatToolStripMenuItem.Enabled = False
        End If
        'Report Menu Dailysales, productwisesales,  Stockpurchases, Productwisepurchases, Expenses, Payments
        If chkdailysales.Checked = True Then
            FrmMain.DailysalesReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.DailysalesReportToolStripMenuItem.Enabled = False
        End If
        If chkproductwisesales.Checked = True Then
            FrmMain.ProductwiseSalesToolStripMenuItem.Enabled = True
        Else
            FrmMain.ProductwiseSalesToolStripMenuItem.Enabled = False
        End If
        If chkstockpurchases.Checked = True Then
            FrmMain.StockPurchasesReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.StockPurchasesReportToolStripMenuItem.Enabled = False
        End If
        If chkproductwisepurchases.Checked = True Then
            FrmMain.ProductwisepurchasesToolStripMenuItem.Enabled = True
        Else
            FrmMain.ProductwisepurchasesToolStripMenuItem.Enabled = False
        End If
        If chkexpenses.Checked = True Then
            FrmMain.SchemeReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.SchemeReportToolStripMenuItem.Enabled = False
        End If
        If chkpayments.Checked = True Then
            FrmMain.PaymentReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.PaymentReportToolStripMenuItem.Enabled = False
        End If
        'Administration Addusers , Audittrail, Voiditemlist, Useraccessrights
        If chkaddusers.Checked = True Then
            FrmMain.addsystemusersToolStripMenuItem6.Enabled = True
        Else
            FrmMain.addsystemusersToolStripMenuItem6.Enabled = False
        End If
        If chkaudittrail.Checked = True Then
            FrmMain.AudittrailToolStripMenuItem5.Enabled = True
        Else
            FrmMain.AudittrailToolStripMenuItem5.Enabled = False
        End If
        If chkvoiditemaudit.Checked = True Then
            FrmMain.VoidItemsListToolStripMenuItem.Enabled = True
        Else
            FrmMain.VoidItemsListToolStripMenuItem.Enabled = False
        End If
        If chkUserAccessrights.Checked = True Then
            FrmMain.SetUserAccessRightsToolStripMenuItem.Enabled = True
        Else
            FrmMain.SetUserAccessRightsToolStripMenuItem.Enabled = False
        End If
        'Tools Menu Backupdatabase, Systemsettings
        If chkBackupdatabase.Checked = True Then
            FrmMain.BackupdatabaseToolStripMenuItem.Enabled = True
        Else
            FrmMain.BackupdatabaseToolStripMenuItem.Enabled = False
        End If
        If chkSystemsettings.Checked = True Then
            FrmMain.SystemsettingsToolStripMenuItem.Enabled = True
        Else
            FrmMain.SystemsettingsToolStripMenuItem.Enabled = True
        End If
        'Changepassword
        If chkChangepword.Checked = True Then
            frmChangePassword.BtnChangePassword.Enabled = True
        Else
            frmChangePassword.BtnChangePassword.Enabled = False
        End If
        'Company Details CDSave, CDUpdate
        If chkCDsave.Checked = True Then
            frmCompanyDetails.saveToolStripButton5.Enabled = True
        Else
            frmCompanyDetails.saveToolStripButton5.Enabled = False
        End If
        If chkCDupdate.Checked = True Then
            frmCompanyDetails.UpdateToolStripButton3.Enabled = True
        Else
            frmCompanyDetails.UpdateToolStripButton3.Enabled = False
        End If
        'Product Details PSave, PUpdate, CSave, CUpdate, SCTSave, SCTUpdate
        If chkPsave.Checked = True Then
            frmAddUpdateProduct.PSaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateProduct.PSaveToolStripButton5.Enabled = False
        End If
        If ChkPUpdate.Checked = True Then
            frmAddUpdateProduct.PUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateProduct.PUpdateToolStripButton3.Enabled = False
        End If
        If chkCTSave.Checked = True Then
            frmAddUpdateCategory.CSaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateCategory.CSaveToolStripButton5.Enabled = False
        End If
        If ChkCTUpdate.Checked = True Then
            frmAddUpdateCategory.CUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateCategory.CUpdateToolStripButton3.Enabled = False
        End If
        If ChkSCTSave.Checked = True Then
            frmSubCategory.SCTSaveToolStripButton5.Enabled = True
        Else
            frmSubCategory.SCTSaveToolStripButton5.Enabled = False
        End If
        If ChkSCTUpdate.Checked = True Then
            frmSubCategory.SCTUpdateToolStripButton3.Enabled = True
        Else
            frmSubCategory.SCTUpdateToolStripButton3.Enabled = False
        End If
        'Supplier Menu SPSave, SPUpdate, PTSave,  PTUpdate, RSSave, TSTransform, TSSave
        If chkSPSave.Checked = True Then
            frmAddUpdateSupplier.SPSaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateSupplier.SPSaveToolStripButton5.Enabled = False
        End If
        If chkSPUpdate.Checked = True Then
            frmAddUpdateSupplier.SPUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateSupplier.SPUpdateToolStripButton3.Enabled = False
        End If
        If chkPTSave.Checked = True Then
            'frmPurchasemode.PTSaveToolStripButton5.Enabled = True
        Else
            'frmPurchasemode.PTSaveToolStripButton5.Enabled = False
        End If
        If chkUpdatematerialsreceived.Checked = True Then
            'frmPurchasemode.PTUpdateToolStripButton3.Enabled = True
        Else
            'frmPurchasemode.PTUpdateToolStripButton3.Enabled = False
        End If
        If chkRSSave.Checked = True Then
            'frmCashFlow.RSStaveToolStripButton52.Enabled = True
        Else
            'frmCashFlow.RSStaveToolStripButton52.Enabled = False
        End If
        If ChkCancelMaterialReceipts.Checked = True Then
            frmTransformstock.TSTransformToolStripButton4.Enabled = True
        Else
            frmTransformstock.TSTransformToolStripButton4.Enabled = False
        End If
        If chkTSSave.Checked = True Then
            frmTransformstock.TSSaveToolStripButton5.Enabled = True
        Else
            frmTransformstock.TSSaveToolStripButton5.Enabled = False
        End If
        'Customers CUSSave, CUSUpdate, LCSGetData, LCSExportToExcel
        If chkCUSSave.Checked = True Then
            frmScheme.CUSSaveToolStripButton5.Enabled = True
        Else
            frmScheme.CUSSaveToolStripButton5.Enabled = False
        End If
        If chkCUSUpdate.Checked = True Then
            frmScheme.CUSUpdateToolStripButton3.Enabled = True
        Else
            frmScheme.CUSUpdateToolStripButton3.Enabled = False
        End If
        If ChkLCSGetdata.Checked = True Then
            'frmListofmaterials.btnLCSGetData.Enabled = True
        Else
            'frmListofmaterials.btnLCSGetData.Enabled = False
        End If
        If ChkLCSExporttoExcel.Checked = True Then
            frmListofmaterials.btnLCSExportExcel.Enabled = True
        Else
            frmListofmaterials.btnLCSExportExcel.Enabled = False
        End If
        'Finance PYMSave, PYMUpdate, NWEXSave,  NWEXUpdate, LOESave, LOEUpdate, PYESave, PYSSave
        If ChkCreateToolsSave.Checked = True Then
            FrmMain.CreateToolsToolStripMenuItem2.Enabled = True
        Else
            FrmMain.CreateToolsToolStripMenuItem2.Enabled = False
        End If
        If ChkCreateEmpRoles.Checked = True Then
            FrmMain.CreateRolesToolStripMenuItem.Enabled = True
        Else
            FrmMain.CreateRolesToolStripMenuItem.Enabled = False
        End If
        If ChkCreateStaff.Checked = True Then
            FrmMain.CreateStaffToolStripMenuItem.Enabled = True
        Else
            FrmMain.CreateStaffToolStripMenuItem.Enabled = False
        End If
        If ChkCreateSuppliers.Checked = True Then
            FrmMain.SuppliersToolStripMenuItem.Enabled = True
        Else
            FrmMain.SuppliersToolStripMenuItem.Enabled = False
        End If
        If ChkLOESave.Checked = True Then
            frmAddUpdateExpenses.LOESaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateExpenses.LOESaveToolStripButton5.Enabled = False
        End If
        If ChkLOEUpdate.Checked = True Then
            frmAddUpdateExpenses.LOEUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateExpenses.LOEUpdateToolStripButton3.Enabled = True
        End If
        If ChkPYEsave.Checked = True Then
            frmUpdateMaterialDel.UpdateDeliveryMaterialToolStripButton5.Enabled = True
        Else
            frmUpdateMaterialDel.UpdateDeliveryMaterialToolStripButton5.Enabled = False
        End If
        If ChkPYSSave.Checked = True Then
            frmPaySupplier.PYSSaveToolStripButton5.Enabled = True
        Else
            frmPaySupplier.PYSSaveToolStripButton5.Enabled = False
        End If
        'Administration AUSave, AUUpdate, AUDelete, ATDelete, VIADelete, UACSave, UACUpdate, UACDelete 
        If ChkAUSave.Checked = True Then
            frmAddUpdateStaff.AUSaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateStaff.AUSaveToolStripButton5.Enabled = False
        End If
        If ChkAUpdate.Checked = True Then
            frmAddUpdateStaff.AUUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateStaff.AUUpdateToolStripButton3.Enabled = False
        End If
        If chkAUDelete.Checked = True Then
            'frmAddUpdateStaff.AUDeleteToolStripButton2.Enabled = True
        Else
            'frmAddUpdateStaff.AUDeleteToolStripButton2.Enabled = False
        End If
        If ChkATDelete.Checked = True Then
            frmAudittrail.ATDeleteToolStripButton2.Enabled = True
        Else
            frmAudittrail.ATDeleteToolStripButton2.Enabled = False
        End If
        If chkVIADelete.Checked = True Then
            frmVoidItems.VIADeleteToolStripButton2.Enabled = True
        Else
            frmVoidItems.VIADeleteToolStripButton2.Enabled = False
        End If
        If ChkUACSave.Checked = True Then
            UACSaveToolStripButton5.Enabled = True
        Else
            UACSaveToolStripButton5.Enabled = False
        End If
        If chkUACUpdate.Checked = True Then
            UACUpdateToolStripButton3.Enabled = True
        Else
            UACUpdateToolStripButton3.Enabled = False
        End If
        If ChkUACDelete.Checked = True Then
            'UACDeleteToolStripButton2.Enabled = True
        Else
            'UACDeleteToolStripButton2.Enabled = False
        End If
        'POS  FVoid, FTenderAmt, FPOS2, FPrice, FItemslookup, FEditQty, FItemQuickedit, POSForm
        'POS FVoid, FTenderAmt, FPOS2, FPrice, FItemslookup, FEditQty, FItemQuickedit, POSForm
        If ChkPOSVoid.Checked = True Then
            FrmPointofSale.VoidToolStripButton4.Enabled = True
        Else
            FrmPointofSale.VoidToolStripButton4.Enabled = False
        End If
        If chkPOSTenderAmt.Checked = True Then
            FrmPointofSale.PSaveToolStripButton.Enabled = True
        Else
            FrmPointofSale.PSaveToolStripButton.Enabled = False
        End If
        If chkPOSopenPOS2.Checked = True Then
            'FrmPointofSale.BTNOpenPOS2.Enabled = True
        Else
            'FrmPointofSale.BTNOpenPOS2.Enabled = False
        End If
        If chkPOSEditPrice.Checked = True Then
            'FrmPointofSale.BtnChgPrice.Enabled = True
        Else
            'FrmPointofSale.BtnChgPrice.Enabled = False
        End If
        If chkPOSItemsLookup.Checked = True Then
            FrmPointofSale.LookupToolStripButton3.Enabled = True
        Else
            FrmPointofSale.LookupToolStripButton3.Enabled = False
        End If
        If chkPOSEditQty.Checked = True Then
            'FrmPointofSale.btnaddQty.Enabled = True
        Else
            'FrmPointofSale.btnaddQty.Enabled = False
        End If
        If chkPOSItemquickEdit.Checked = True Then
            'FrmPointofSale.BTNQucikItemEdit.Enabled = True
        Else
            'FrmPointofSale.BTNQucikItemEdit.Enabled = False
        End If
        If ChkPOS.Checked = True Then
            FrmPointofSale.Enabled = True
        Else
            FrmPointofSale.Enabled = False
        End If
        'Menu Bar TSBProduct, TSBStock, TSBStaff, TSBCategory, TSBPOS, TSBVoidItems, TSBDailySales, TSBStockIn, TSBPayments, TSBExpenses  
        If chkTSBProduct.Checked = True Then
            FrmMain.ProductToolStripButton2.Enabled = True
        Else
            FrmMain.ProductToolStripButton2.Enabled = False
        End If
        If chkTSBNewstock.Checked = True Then
            FrmMain.StockToolStripButton8.Enabled = True
        Else
            FrmMain.StockToolStripButton8.Enabled = False
        End If
        If chkTSBPOS.Checked = True Then
            FrmMain.POSToolStripButton5.Enabled = True
        Else
            FrmMain.POSToolStripButton5.Enabled = False
        End If
        If chkTSBVoidItems.Checked = True Then
            FrmMain.MaterialIssuedToolStripButton9.Enabled = True
        Else
            FrmMain.MaterialIssuedToolStripButton9.Enabled = False
        End If
        If chkTSBDailysales.Checked = True Then
            FrmMain.MaterialDeliveryNoteToolStripButton7.Enabled = True
        Else
            FrmMain.MaterialDeliveryNoteToolStripButton7.Enabled = False
        End If
        If chkTSBStockIn.Checked = True Then
            FrmMain.StockInToolStripButton1.Enabled = True
        Else
            FrmMain.StockInToolStripButton1.Enabled = False
        End If
        If chkTSBPayments.Checked = True Then
            FrmMain.DeliverytoschemesToolStripButton10.Enabled = True
        Else
            FrmMain.DeliverytoschemesToolStripButton10.Enabled = False
        End If
        If chkTSBExpenses.Checked = True Then
            FrmMain.ApprovalToolStripButton6.Enabled = True
        Else
            FrmMain.ApprovalToolStripButton6.Enabled = False
        End If
        'POS Updates POSRecallsale, POSQckstkPurc, POSDeleteUncleredsale, POSUpdateRecall     
        If chkPOSRecallsale.Checked = True Then
            'FrmPointofSale.BTNRecallTrans.Enabled = True
        Else
            'FrmPointofSale.BTNRecallTrans.Enabled = False
        End If
        If chkPOSQckstkpurch.Checked = True Then
            'FrmPointofSale.BTNqckpurchase.Enabled = True
        Else
            'FrmPointofSale.BTNqckpurchase.Enabled = False
        End If
        If chkPOSdeleteunclredsale.Checked = True Then
            'FrmPointofSale.BtnRecoverUnclearedsale.Enabled = True
        Else
            'FrmPointofSale.BtnRecoverUnclearedsale.Enabled = False
        End If
        If chkPOSsaverecallsale.Checked = True Then
            'FrmPointofSale.BtnUpdate.Enabled = True
        Else
            'FrmPointofSale.BtnUpdate.Enabled = False
        End If
        'frmProductQuickEdit Qckstockpurch, QckstkSave, QckStkUpdate,  MNBCompany, MNBUserLog, MNBPrivilages,  MNBCashsales
        'Qckstockpurch, QckstkSave, QckStkUpdate,  MNBCompany, MNBUserLog, MNBPrivilages,  MNBCashsales
        If chkAllocateTools.Checked = True Then
            FrmMain.ToolsAllocationPurchaseToolStripMenuItem.Enabled = True
        Else
            FrmMain.ToolsAllocationPurchaseToolStripMenuItem.Enabled = False
        End If
        If chkReturnTools.Checked = True Then
            FrmMain.ReturnToolsToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReturnToolsToolStripMenuItem.Enabled = False
        End If
        If chkupdateDelivery.Checked = True Then
            'FrmMain.UpdateMaterialDeliveryToolStripMenuItem.Enabled = True
        Else
            'FrmMain.UpdateMaterialDeliveryToolStripMenuItem.Enabled = False
        End If
        If chkMNUserlog.Checked = True Then
            FrmMain.UserLogToolStripButton2.Enabled = True
        Else
            FrmMain.UserLogToolStripButton2.Enabled = False
        End If
        If chkMNPrivilages.Checked = True Then
            FrmMain.PrivilagesToolStripButton3.Enabled = True
        Else
            FrmMain.PrivilagesToolStripButton3.Enabled = False
        End If
        If chkMNSales.Checked = True Then
            FrmMain.CreateToolsToolStripButton1.Enabled = True
        Else
            FrmMain.CreateToolsToolStripButton1.Enabled = False
        End If
        'POS Grid POSGridPrice, POSGridAmount
        'Pos POSGridPrice, POSGridAmount
        If ChkPOSGridPrice.Checked = True Then
            FrmPointofSale.dgwIssueItems.Columns(2).ReadOnly = True
        Else
            FrmPointofSale.dgwIssueItems.Columns(2).ReadOnly = False
        End If
        If ChkPOSGridAmt.Checked = True Then
            FrmPointofSale.dgwIssueItems.Columns(4).ReadOnly = True
        Else
            FrmPointofSale.dgwIssueItems.Columns(4).ReadOnly = False
        End If
        'Invoicing
        If chkInvoicing.Checked = True Then
            FrmMain.BillingToolStripMenuItem.Enabled = True
        Else
            FrmMain.BillingToolStripMenuItem.Enabled = False
        End If
        'Invoicing Menus
        'Billing Items
        If chkBillingItems.Checked = True Then
            FrmMain.BillingItemsToolStripMenuItem.Enabled = True
        Else
            FrmMain.BillingItemsToolStripMenuItem.Enabled = False
        End If
        'create statement
        If chkCreateStatement.Checked = True Then
            'FrmMain.CreateStatementToolStripMenuItem.Enabled = True
        Else
            'FrmMain.CreateStatementToolStripMenuItem.Enabled = False
        End If
        'statement approval
        If chkStatementapproval.Checked = True Then
            'FrmMain.StatementApprovalToolStripMenuItem.Enabled = True
        Else
            'FrmMain.StatementApprovalToolStripMenuItem.Enabled = False
        End If
        'Update Statement
        If chkUpdateStatement.Checked = True Then
            'FrmMain.UpdateStatementToolStripMenuItem.Enabled = True
        Else
            'FrmMain.UpdateStatementToolStripMenuItem.Enabled = False
        End If
        'List of statement
        If chkListofStatements.Checked = True Then
            'FrmMain.ListofstatementsToolStripMenuItem.Enabled = True
        Else
            'FrmMain.ListofstatementsToolStripMenuItem.Enabled = False
        End If
        'print statement
        If chkPrintStatement.Checked = True Then
            'FrmMain.PrintStatementToolStripMenuItem.Enabled = True
        Else
            'FrmMain.PrintStatementToolStripMenuItem.Enabled = False
        End If
        'Transport
        If chkTransport.Checked = True Then
            FrmMain.TransportToolStripMenuItem.Enabled = True
        Else
            FrmMain.TransportToolStripMenuItem.Enabled = False
        End If
        'Transport Menu
        'warehouses
        If chkWarehouse.Checked = True Then
            FrmMain.WarehousesToolStripMenuItem.Enabled = True
        Else
            FrmMain.WarehousesToolStripMenuItem.Enabled = False
        End If
        'transporters
        If chkTransporter.Checked = True Then
            FrmMain.TransportersToolStripMenuItem.Enabled = True
        Else
            FrmMain.TransportersToolStripMenuItem.Enabled = False
        End If
        'transport register
        If chkTransportregister.Checked = True Then
            FrmMain.TransportRegisterToolStripMenuItem.Enabled = True
        Else
            FrmMain.TransportRegisterToolStripMenuItem.Enabled = False
        End If
        'update transport register
        If chkUpdateTransportregister.Checked = True Then
            FrmMain.UpdateRegisterToolStripMenuItem.Enabled = True
        Else
            FrmMain.UpdateRegisterToolStripMenuItem.Enabled = False
        End If
        'Inventory Menu
        'Material Issuance
        If chkIssueMaterials.Checked = True Then
            FrmMain.MaterialIssuanceToolStripMenuItem.Enabled = True
        Else
            FrmMain.MaterialIssuanceToolStripMenuItem.Enabled = False
        End If
        'Delivery Approval
        If chkDeliveryApproval.Checked = True Then
            FrmMain.ApproveDeliveryToolStripMenuItem.Enabled = True
        Else
            FrmMain.ApproveDeliveryToolStripMenuItem.Enabled = False

        End If
        'Update Delivery
        If chkupdateDelivery.Checked = True Then
            FrmMain.UpdateDeliveryToolStripMenuItem.Enabled = True
        Else
            FrmMain.UpdateDeliveryToolStripMenuItem.Enabled = False
        End If
        'Return materials
        If chkreturnmaterials.Checked = True Then
            FrmMain.ReturnIssuanceToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReturnIssuanceToolStripMenuItem.Enabled = False
        End If
        'Receive Materials
        If chkreceivestock.Checked = True Then
            FrmMain.ReceiveGoodsToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReceiveGoodsToolStripMenuItem.Enabled = False
        End If
        'Update Materials Received
        If chkUpdatematerialsreceived.Checked = True Then
            FrmMain.UpdateMaterialReceiptToolStripMenuItem.Enabled = True
        Else
            FrmMain.UpdateMaterialReceiptToolStripMenuItem.Enabled = False
        End If
        'CancelMaterialReceipts
        If ChkCancelMaterialReceipts.Checked = True Then
            FrmMain.CancelMaterialReceiptsToolStripMenuItem.Enabled = True
        Else
            FrmMain.CancelMaterialReceiptsToolStripMenuItem.Enabled = False
        End If
        'Metering Menu
        If chkMeters.Checked = True Then
            FrmMain.MetersToolStripMenuItem.Enabled = True
        Else
            FrmMain.MetersToolStripMenuItem.Enabled = False
        End If
        'Receive Meters
        If chkReceiveMeters.Checked = True Then
            FrmMain.ReceiveMetersToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReceiveMetersToolStripMenuItem.Enabled = False
        End If
        'Issue Meters
        If chkIssueMeters.Checked = True Then
            FrmMain.IssueMetersToolStripMenuItem.Enabled = True
        Else
            FrmMain.IssueMetersToolStripMenuItem.Enabled = False
        End If
        'Update Meterlist
        If chkUpdateMeters.Checked = True Then
            FrmMain.UpdateCustomerDetailsToolStripMenuItem.Enabled = True
        Else
            FrmMain.UpdateCustomerDetailsToolStripMenuItem.Enabled = False
        End If
        'Meter BoQs
        If chkMeterBoQ.Checked = True Then
            FrmMain.MeterInstallationStatementToolStripMenuItem.Enabled = True
        Else
            FrmMain.MeterInstallationStatementToolStripMenuItem.Enabled = False
        End If
        'Technician BoQs
        If chkTechBoQ.Checked = True Then
            FrmMain.TechncianBoQToolStripMenuItem.Enabled = True
        Else
            FrmMain.TechncianBoQToolStripMenuItem.Enabled = False
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO groupusers (UserGroupName, File, Product, Suppliers, Customers, Finance, Reports, Administration, Tools, CompanyDetails, ChangePassord, Logout, Addupdateproduct, Category, Subcategory, AdjustStock, Productlookup, ProductJournal, AddUpdateSupplier, Purchaseterms, ReceiveStock, ListofStockreceived, TransformStock, Addupdatecustomers, Listofcashsales, Paymentmodes, NewExpense, ListofExpense, Payexpense, Paysupplier,  Vatdetails, Dailysales, productwisesales,  Stockpurchases, Productwisepurchases, Expenses, Payments, Addusers , Audittrail, Voiditemlist, Useraccessrights, Backupdatabase, Systemsettings, Changepassword, CDSave, CDUpdate, PSave, PUpdate, CSave, CUpdate, SCTSave, SCTUpdate, SPSave, SPUpdate, PTSave,  PTUpdate, RSSave, TSTransform, TSSave, CUSSave, CUSUpdate, LCSGetData, LCSExportToExcel, PYMSave, PYMUpdate, NWEXSave, NWEXUpdate, LOESave, LOEUpdate, PYESave, PYSSave, AUSave, AUUpdate, AUDelete, ATDelete, VIADelete, UACSave, UACUpdate, UACDelete, FVoid, FTenderAmt, FPOS2, FPrice, FItemslookup, FEditQty, FItemQuickedit, POSForm, TSBProduct, TSBStock, TSBPOS, TSBVoidItems, TSBDailySales, TSBStockIn, TSBPayments, TSBExpenses, POSRecallsale, POSQckstkPurc, POSDeleteUncleredsale, POSUpdateRecall, Qckstockpurch, QckstkSave, QckStkUpdate, MNBUserLog, MNBPrivilages, MNBCashsales, POSGridPrice, POSGridAmount, Invoicing, InvoicingItems, Createstatement, Statementapproval, Updatestatement, ListofInvoices, Printstatement, MnuTransport, Warehouse, Transporter, Transportregister, UpdateTransRegister, MaterialIssuance, ApproveDelivery, UpdateDelivery, ReturnMaterials, ReceiveMaterials, UpdateMatReceipt, CancelMatReceipt, mnuMeters, Receivemeters, IssueMeters, UpdateMeters, MeterBoQ, TechBoQ) VALUES ('" & CboUsers.Text & "', '" & chkFilemenu.CheckState & "', '" & chckMaterialsmenu.CheckState & "', '" & chkInventory.CheckState & "', '" & chkCustomersMenu.CheckState & "', '" & chckSchemes.CheckState & "', '" & chckReports.CheckState & "', '" & ChkAdministration.CheckState & "', '" & chkTools.CheckState & "', '" & ChkCompanydetails.CheckState & "', '" & chkchangepassword.CheckState & "', '" & chcklogout.CheckState & "', '" & Chkaddupdateproduct.CheckState & "', '" & chkCategory.CheckState & "', '" & chkSubcategory.CheckState & "', '" & chkAdjuststock.CheckState & "', '" & chckSearchProduct.CheckState & "', '" & chkProductJournal.CheckState & "', '" & ChkaddReceiveMaterials.CheckState & "', '" & chkIssueMaterials.CheckState & "', '" & chkreceivestock.CheckState & "', '" & chkreturnmaterials.CheckState & "', '" & chkreceivetools.CheckState & "', '" & chkaddupdatecutomers.CheckState & "', '" & chklistofcashsales.CheckState & "', '" & chkDeliveryApproval.CheckState & "', '" & chkSchemes.CheckState & "', '" & chkConstituency.CheckState & "', '" & chkCounty.CheckState & "', '" & chkReverseIssuance.CheckState & "', '" & chkVatdetails.CheckState & "', '" & chkdailysales.CheckState & "', '" & chkproductwisesales.CheckState & "', '" & chkstockpurchases.CheckState & "', '" & chkproductwisepurchases.CheckState & "', '" & chkexpenses.CheckState & "', '" & chkpayments.CheckState & "', '" & chkaddusers.CheckState & "', '" & chkaudittrail.CheckState & "', '" & chkvoiditemaudit.CheckState & "', '" & chkUserAccessrights.CheckState & "', '" & chkBackupdatabase.CheckState & "', '" & chkSystemsettings.CheckState & "', '" & chkChangepword.CheckState & "', '" & chkCDsave.CheckState & "', '" & chkCDupdate.CheckState & "', '" & chkPsave.CheckState & "', '" & ChkPUpdate.CheckState & "', '" & chkCTSave.CheckState & "', '" & ChkCTUpdate.CheckState & "', '" & ChkSCTSave.CheckState & "', '" & ChkSCTUpdate.CheckState & "', '" & chkSPSave.CheckState & "', '" & chkSPUpdate.CheckState & "', '" & chkPTSave.CheckState & "', '" & chkUpdatematerialsreceived.CheckState & "', '" & chkRSSave.CheckState & "', '" & ChkCancelMaterialReceipts.CheckState & "', '" & chkTSSave.CheckState & "', '" & chkCUSSave.CheckState & "', '" & chkCUSUpdate.CheckState & "', '" & ChkLCSGetdata.CheckState & "', '" & ChkLCSExporttoExcel.CheckState & "', '" & ChkCreateToolsSave.CheckState & "', '" & ChkCreateEmpRoles.CheckState & "', '" & ChkCreateStaff.CheckState & "', '" & ChkCreateSuppliers.CheckState & "', '" & ChkLOESave.CheckState & "', '" & ChkLOEUpdate.CheckState & "', '" & ChkPYEsave.CheckState & "', '" & ChkPYSSave.CheckState & "', '" & ChkAUSave.CheckState & "', '" & ChkAUpdate.CheckState & "', '" & chkAUDelete.CheckState & "', '" & ChkATDelete.CheckState & "', '" & chkVIADelete.CheckState & "', '" & ChkUACSave.CheckState & "', '" & chkUACUpdate.CheckState & "', '" & ChkUACDelete.CheckState & "', '" & ChkPOSVoid.CheckState & "', '" & chkPOSTenderAmt.CheckState & "', '" & chkPOSopenPOS2.CheckState & "', '" & chkPOSEditPrice.CheckState & "', '" & chkPOSItemsLookup.CheckState & "', '" & chkPOSEditQty.CheckState & "', '" & chkPOSItemquickEdit.CheckState & "', '" & ChkPOS.CheckState & "', '" & chkTSBProduct.CheckState & "', '" & chkTSBNewstock.CheckState & "','" & chkTSBPOS.CheckState & "', '" & chkTSBVoidItems.CheckState & "', '" & chkTSBDailysales.CheckState & "', '" & chkTSBStockIn.CheckState & "', '" & chkTSBPayments.CheckState & "', '" & chkTSBExpenses.CheckState & "', '" & chkPOSRecallsale.CheckState & "', '" & chkPOSQckstkpurch.CheckState & "', '" & chkPOSdeleteunclredsale.CheckState & "', '" & chkPOSsaverecallsale.CheckState & "', '" & chkAllocateTools.CheckState & "', '" & chkReturnTools.CheckState & "', '" & chkupdateDelivery.CheckState & "', '" & chkMNUserlog.CheckState & "', '" & chkMNPrivilages.CheckState & "', '" & chkMNSales.CheckState & "', '" & ChkPOSGridPrice.CheckState & "', '" & ChkPOSGridAmt.CheckState & "', '" & chkInvoicing.CheckState & "', '" & chkBillingItems.CheckState & "', '" & chkCreateStatement.CheckState & "', '" & chkStatementapproval.CheckState & "', '" & chkUpdateStatement.CheckState & "', '" & chkListofStatements.CheckState & "', '" & chkPrintStatement.CheckState & "', '" & chkTransport.CheckState & "', '" & chkWarehouse.CheckState & "', '" & chkTransporter.CheckState & "', '" & chkTransportregister.CheckState & "', '" & chkUpdateTransportregister.CheckState & "', '" & chkIssueMaterials.CheckState & "', '" & chkDeliveryApproval.CheckState & "', '" & chkupdateDelivery.CheckState & "', '" & chkreturnmaterials.CheckState & "', '" & chkreceivestock.CheckState & "', '" & chkUpdatematerialsreceived.CheckState & "', '" & ChkCancelMaterialReceipts.CheckState & "','" & chkMeters.CheckState & "', '" & chkReceiveMeters.CheckState & "', '" & chkIssueMeters.CheckState & "', '" & chkUpdateMeters.CheckState & "', '" & chkMeterBoQ.CheckState & "', '" & chkTechBoQ.CheckState & "')"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader()
            MsgBox("Right successfully added.", MsgBoxStyle.Information, "Add Group Rights")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
            MysqlConn.Close()
        End Try
    End Sub
    Public Sub getuserpermission()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT UserGroupName, File, Product, Suppliers, Customers, Finance, Reports, Administration, Tools, CompanyDetails, ChangePassord, Logout, Addupdateproduct, Category, Subcategory, AdjustStock, Productlookup, ProductJournal, AddUpdateSupplier, Purchaseterms, ReceiveStock, ListofStockreceived, TransformStock, Addupdatecustomers, Listofcashsales, Paymentmodes, NewExpense, ListofExpense, Payexpense, Paysupplier,  Vatdetails, Dailysales, productwisesales,  Stockpurchases, Productwisepurchases, Expenses, Payments, Addusers , Audittrail, Voiditemlist, Useraccessrights, Backupdatabase, Systemsettings, Changepassword, CDSave, CDUpdate, PSave, PUpdate, CSave, CUpdate, SCTSave, SCTUpdate, SPSave, SPUpdate, PTSave,  PTUpdate, RSSave, TSTransform, TSSave, CUSSave, CUSUpdate, LCSGetData, LCSExportToExcel, PYMSave, PYMUpdate, NWEXSave,  NWEXUpdate, LOESave, LOEUpdate, PYESave, PYSSave, AUSave, AUUpdate, AUDelete, ATDelete, VIADelete, UACSave, UACUpdate, UACDelete, FVoid, FTenderAmt, FPOS2, FPrice, FItemslookup, FEditQty, FItemQuickedit, POSForm, TSBProduct, TSBStock, TSBPOS, TSBVoidItems, TSBDailySales, TSBStockIn, TSBPayments, TSBExpenses, POSRecallsale, POSQckstkPurc, POSDeleteUncleredsale, POSUpdateRecall, Qckstockpurch, QckstkSave, QckStkUpdate, MNBUserLog, MNBPrivilages, MNBCashsales, POSGridPrice, POSGridAmount, Invoicing, InvoicingItems, Createstatement, Statementapproval, Updatestatement, ListofInvoices, Printstatement, MnuTransport, Warehouse, Transporter, Transportregister, UpdateTransRegister, MaterialIssuance, ApproveDelivery, UpdateDelivery, ReturnMaterials, ReceiveMaterials, UpdateMatReceipt, CancelMatReceipt, mnuMeters, Receivemeters, IssueMeters, UpdateMeters, MeterBoQ, TechBoQ From groupusers Where  UserGroupName = '" & CboUsers.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader()
            Do While dr.Read = True
                CboUsers.Text = dr("UserGroupName")
                chkFilemenu.CheckState = dr("File")
                chckMaterialsmenu.CheckState = dr("Product")
                chkInventory.CheckState = dr("Suppliers")
                chkCustomersMenu.CheckState = dr("Customers")
                chckSchemes.CheckState = dr("Finance")
                chckReports.CheckState = dr("Reports")
                ChkAdministration.CheckState = dr("Administration")
                chkTools.CheckState = dr("Tools")
                ChkCompanydetails.CheckState = dr("CompanyDetails")
                chkchangepassword.CheckState = dr("ChangePassord")
                chcklogout.CheckState = dr("Logout")
                Chkaddupdateproduct.CheckState = dr("Addupdateproduct")
                chkCategory.CheckState = dr("Category")
                chkSubcategory.CheckState = dr("Subcategory")
                chkAdjuststock.CheckState = dr("AdjustStock")
                chckSearchProduct.CheckState = dr("Productlookup")
                chkProductJournal.CheckState = dr("ProductJournal")
                ChkaddReceiveMaterials.CheckState = dr("AddUpdateSupplier")
                chkIssueMaterials.CheckState = dr("Purchaseterms")
                chkreceivestock.CheckState = dr("ReceiveStock")
                chkreturnmaterials.CheckState = dr("ListofStockreceived")
                chkreceivetools.CheckState = dr("TransformStock")
                chkaddupdatecutomers.CheckState = dr("Addupdatecustomers")
                chklistofcashsales.CheckState = dr("Listofcashsales")
                'Paymentmodes, NewExpense, ListofExpense, Payexpense, Paysupplier,  Vatdetails
                chkDeliveryApproval.CheckState = dr("Paymentmodes")
                chkSchemes.CheckState = dr("NewExpense")
                chkConstituency.CheckState = dr("ListofExpense")
                chkCounty.CheckState = dr("Payexpense")
                chkReverseIssuance.CheckState = dr("Paysupplier")
                chkVatdetails.CheckState = dr("Vatdetails")
                'Dailysales, productwisesales,  Stockpurchases, Productwisepurchases, Expenses, Payments
                chkdailysales.CheckState = dr("Dailysales")
                chkproductwisesales.CheckState = dr("productwisesales")
                chkstockpurchases.CheckState = dr("Stockpurchases")
                chkproductwisepurchases.CheckState = dr("Productwisepurchases")
                chkexpenses.CheckState = dr("Expenses")
                chkpayments.CheckState = dr("Payments")
                'Administration Addusers , Audittrail, Voiditemlist, Useraccessrights
                chkaddusers.CheckState = dr("Addusers")
                chkaudittrail.CheckState = dr("Audittrail")
                chkvoiditemaudit.CheckState = dr("Voiditemlist")
                chkUserAccessrights.CheckState = dr("Useraccessrights")
                'Tools Menu Backupdatabase, Systemsettings
                chkBackupdatabase.CheckState = dr("Backupdatabase")
                chkSystemsettings.CheckState = dr("Systemsettings")
                'Changepassword
                chkChangepword.CheckState = dr("Changepassword")
                'Company Details CDSave, CDUpdate
                chkCDsave.CheckState = dr("CDSave")
                chkCDupdate.CheckState = dr("CDUpdate")
                'Product Details PSave, PUpdate, CSave, CUpdate, SCTSave, SCTUpdate
                chkPsave.CheckState = dr("PSave")
                ChkPUpdate.CheckState = dr("PUpdate")
                chkCTSave.CheckState = dr("CSave")
                ChkCTUpdate.CheckState = dr("CUpdate")
                ChkSCTSave.CheckState = dr("SCTSave")
                ChkSCTUpdate.CheckState = dr("SCTUpdate")
                'Supplier SPSave, SPUpdate, PTSave,  PTUpdate, RSSave, TSTransform, TSSave
                chkSPSave.CheckState = dr("SPSave")
                chkSPUpdate.CheckState = dr("SPUpdate")
                chkPTSave.CheckState = dr("PTSave")
                chkUpdatematerialsreceived.CheckState = dr("PTUpdate")
                chkRSSave.CheckState = dr("RSSave")
                ChkCancelMaterialReceipts.CheckState = dr("TSTransform")
                chkTSSave.CheckState = dr("TSSave")
                'Customers CUSSave, CUSUpdate, LCSGetData, LCSExportToExcel
                chkCUSSave.CheckState = dr("CUSSave")
                chkCUSUpdate.CheckState = dr("CUSUpdate")
                ChkLCSGetdata.CheckState = dr("LCSGetData")
                ChkLCSExporttoExcel.CheckState = dr("LCSExportToExcel")
                'Finance PYMSave, PYMUpdate, NWEXSave,  NWEXUpdate, LOESave, LOEUpdate, PYESave, PYSSave
                ChkCreateToolsSave.CheckState = dr("PYMSave")
                ChkCreateEmpRoles.CheckState = dr("PYMUpdate")
                ChkCreateStaff.CheckState = dr("NWEXSave")
                ChkCreateSuppliers.CheckState = dr("NWEXUpdate")
                ChkLOESave.CheckState = dr("LOESave")
                ChkLOEUpdate.CheckState = dr("LOEUpdate")
                ChkPYEsave.CheckState = dr("PYESave")
                ChkPYSSave.CheckState = dr("PYSSave")
                'Administration AUSave, AUUpdate, AUDelete, ATDelete, VIADelete, UACSave, UACUpdate, UACDelete 
                ChkAUSave.CheckState = dr("AUSave")
                ChkAUpdate.CheckState = dr("AUUpdate")
                chkAUDelete.CheckState = dr("AUDelete")
                ChkATDelete.CheckState = dr("ATDelete")
                chkVIADelete.CheckState = dr("VIADelete")
                ChkUACSave.CheckState = dr("UACSave")
                chkUACUpdate.CheckState = dr("UACUpdate")
                ChkUACDelete.CheckState = dr("UACDelete")
                'POS FVoid, FTenderAmt, FPOS2, FPrice, FItemslookup, FEditQty, FItemQuickedit, POSForm
                ChkPOSVoid.CheckState = dr("FVoid")
                chkPOSTenderAmt.CheckState = dr("FTenderAmt")
                chkPOSopenPOS2.CheckState = dr("FPOS2")
                chkPOSEditPrice.CheckState = dr("FPrice")
                chkPOSItemsLookup.CheckState = dr("FItemslookup")
                chkPOSEditQty.CheckState = dr("FEditQty")
                chkPOSItemquickEdit.CheckState = dr("FItemQuickedit")
                ChkPOS.CheckState = dr("POSForm")
                'Menu Bar TSBProduct, TSBStock, TSBStaff, TSBCategory, TSBPOS, TSBVoidItems, TSBDailySales, TSBStockIn, TSBPayments, TSBExpenses  
                chkTSBProduct.CheckState = dr("TSBProduct")
                chkTSBNewstock.CheckState = dr("TSBStock")
                chkTSBPOS.CheckState = dr("TSBPOS")
                chkTSBVoidItems.CheckState = dr("TSBVoidItems")
                chkTSBDailysales.CheckState = dr("TSBDailySales")
                chkTSBStockIn.CheckState = dr("TSBStockIn")
                chkTSBPayments.CheckState = dr("TSBPayments")
                chkTSBExpenses.CheckState = dr("TSBExpenses")
                'POS UpdatesPOSRecallsale, POSQckstkPurc, POSDeleteUncleredsale, POSUpdateRecall
                chkPOSRecallsale.CheckState = dr("POSRecallsale")
                chkPOSQckstkpurch.CheckState = dr("POSQckstkPurc")
                chkPOSdeleteunclredsale.CheckState = dr("POSDeleteUncleredsale")
                chkPOSsaverecallsale.CheckState = dr("POSUpdateRecall")
                'Qckstockpurch, QckstkSave, QckStkUpdate,  MNBCompany, MNBUserLog, MNBPrivilages,  MNBCashsales
                chkAllocateTools.CheckState = dr("Qckstockpurch")
                chkReturnTools.CheckState = dr("QckstkSave")
                chkupdateDelivery.CheckState = dr("QckStkUpdate")
                chkMNUserlog.CheckState = dr("MNBUserLog")
                chkMNPrivilages.CheckState = dr("MNBPrivilages")
                chkMNSales.CheckState = dr("MNBCashsales")
                'POSGridPrice, POSGridAmount
                ChkPOSGridPrice.CheckState = dr("POSGridPrice")
                ChkPOSGridAmt.CheckState = dr("POSGridAmount")
                'Invoicing
                'Invoicing, InvoicingItems, Createstatement, Statementapproval, Updatestatement, ListofInvoices, Printstatement
                chkInvoicing.CheckState = dr("Invoicing")
                chkBillingItems.CheckState = dr("InvoicingItems")
                chkCreateStatement.CheckState = dr("Createstatement")
                chkStatementapproval.CheckState = dr("Statementapproval")
                chkUpdateStatement.CheckState = dr("Updatestatement")
                chkListofStatements.CheckState = dr("ListofInvoices")
                chkPrintStatement.CheckState = dr("Printstatement")
                'Transport
                'MnuTransport, Warehouse, Transporter, Transportregister, UpdateTransRegister
                chkTransport.CheckState = dr("MnuTransport")
                chkWarehouse.CheckState = dr("Warehouse")
                chkTransporter.CheckState = dr("Transporter")
                chkTransportregister.CheckState = dr("Transportregister")
                chkUpdateTransportregister.CheckState = dr("UpdateTransRegister")
                ' Inventory
                'MaterialIssuance, ApproveDelivery, UpdateDelivery, ReturnMaterials, ReceiveMaterials, UpdateMatReceipt, CancelMatReceipt 
                chkIssueMaterials.CheckState = dr("MaterialIssuance")
                chkDeliveryApproval.CheckState = dr("ApproveDelivery")
                chkupdateDelivery.CheckState = dr("UpdateDelivery")
                chkreturnmaterials.CheckState = dr("ReturnMaterials")
                chkreceivestock.CheckState = dr("ReceiveMaterials")
                chkUpdatematerialsreceived.CheckState = dr("UpdateMatReceipt")
                ChkCancelMaterialReceipts.CheckState = dr("CancelMatReceipt")
                'Meters mnuMeters, Receivemeters, IssueMeters, UpdateMeters
                chkMeters.CheckState = dr("mnuMeters")
                chkReceiveMeters.CheckState = dr("Receivemeters")
                chkIssueMeters.CheckState = dr("IssueMeters")
                chkUpdateMeters.CheckState = dr("UpdateMeters")
                'MeterBoQ, TechBoQ
                chkMeterBoQ.CheckState = dr("MeterBoQ")
                chkTechBoQ.CheckState = dr("TechBoQ")
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
            MysqlConn.Close()
        End Try
    End Sub
    Public Sub updatepermissions()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)

        Dim dr As MySqlDataReader
        If chkFilemenu.Checked = True Then
            FrmMain.FileToolStripMenuItem.Enabled = True
        Else
            FrmMain.FileToolStripMenuItem.Enabled = False
        End If
        If chckMaterialsmenu.Checked = True Then
            FrmMain.MastersToolStripMenuItem.Enabled = True
        Else
            FrmMain.MastersToolStripMenuItem.Enabled = False
        End If
        If chkInventory.Checked = True Then
            FrmMain.InventoryToolStripMenuItem.Enabled = True
        Else
            FrmMain.InventoryToolStripMenuItem.Enabled = False
        End If
        If chkCustomersMenu.Checked = True Then
            FrmMain.SchemeToolStripMenuItem.Enabled = True
        Else
            FrmMain.SchemeToolStripMenuItem.Enabled = False
        End If
        If chckSchemes.Checked = True Then
            FrmMain.SchemeToolStripMenuItem.Enabled = True
        Else
            FrmMain.SchemeToolStripMenuItem.Enabled = False
        End If
        If chckReports.Checked = True Then
            FrmMain.ReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReportToolStripMenuItem.Enabled = False
        End If
        If ChkAdministration.Checked = True Then
            FrmMain.ProjectSummaryToolStripMenuItem4.Enabled = True
        Else
            FrmMain.ProjectSummaryToolStripMenuItem4.Enabled = False
        End If
        If chkTools.Checked = True Then
            FrmMain.ToolStripMenuItem1.Enabled = True
        Else
            FrmMain.ToolStripMenuItem1.Enabled = False
        End If
        'filemenu
        If ChkCompanydetails.Checked = True Then
            FrmMain.CompanyDetailsToolStripMenuItem.Enabled = True
        Else
            FrmMain.CompanyDetailsToolStripMenuItem.Enabled = False
        End If
        If chkchangepassword.Checked = True Then
            FrmMain.ChangePasswordToolStripMenuItem.Enabled = True
        Else
            FrmMain.ChangePasswordToolStripMenuItem.Enabled = False
        End If
        If chcklogout.Checked = True Then
            FrmMain.ExitToolStripMenuItem.Enabled = True
        Else
            FrmMain.ExitToolStripMenuItem.Enabled = False
        End If
        'Product Menu 
        If Chkaddupdateproduct.Checked = True Then
            FrmMain.addupdateproductToolStripMenuItem.Enabled = True
        Else
            FrmMain.addupdateproductToolStripMenuItem.Enabled = False
        End If
        If chkCategory.Checked = True Then
            FrmMain.CategoryToolStripMenuItem.Enabled = True
        Else
            FrmMain.CategoryToolStripMenuItem.Enabled = False
        End If
        If chkSubcategory.Checked = True Then
            FrmMain.NewSubcategoryToolStripMenuItem.Enabled = True
        Else
            FrmMain.NewSubcategoryToolStripMenuItem.Enabled = False
        End If
        If chkAdjuststock.Checked = True Then
            FrmMain.AdjuststockToolStripMenuItem.Enabled = True
        Else
            FrmMain.AdjuststockToolStripMenuItem.Enabled = False
        End If
        If chckSearchProduct.Checked = True Then
            FrmMain.ProductlookupToolStripMenuItem.Enabled = True
        Else
            FrmMain.ProductlookupToolStripMenuItem.Enabled = False
        End If
        If chkProductJournal.Checked = True Then
            FrmMain.ProductJournalToolStripMenuItem.Enabled = True
        Else
            FrmMain.ProductJournalToolStripMenuItem.Enabled = False
        End If
        'Supplier Menu
        If ChkaddReceiveMaterials.Checked = True Then
            'FrmMain.ReceiveMaterialsToolStripMenuItem.Enabled = True
        Else
            'FrmMain.ReceiveMaterialsToolStripMenuItem.Enabled = True
        End If
        If chkIssueMaterials.Checked = True Then
            'FrmMain.IssueMaterialsToolStripMenuItem.Enabled = True
        Else
            'FrmMain.IssueMaterialsToolStripMenuItem.Enabled = False
        End If
        If chkreceivestock.Checked = True Then
            FrmMain.ReceiveGoodsToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReceiveGoodsToolStripMenuItem.Enabled = False
        End If
        If chkreturnmaterials.Checked = True Then
            FrmMain.ListofStockrcvedToolStripMenuItem.Enabled = True
        Else
            FrmMain.ListofStockrcvedToolStripMenuItem.Enabled = False
        End If
        If chkreceivetools.Checked = True Then
            FrmMain.ReceivetoolssToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReceivetoolssToolStripMenuItem.Enabled = False
        End If
        'Customers Menu 
        If chkaddupdatecutomers.Checked = True Then
            FrmMain.Schemes2ToolStripMenuItem.Enabled = True
        Else
            FrmMain.Schemes2ToolStripMenuItem.Enabled = False
        End If
        If chklistofcashsales.Checked = True Then
            'FrmMain.ListOfCashSalesToolStripMenuItem.Enabled = True
        Else
            'FrmMain.ListOfCashSalesToolStripMenuItem.Enabled = False
        End If
        'Registers Menu
        'Finance Menu Paymentmodes, NewExpense, ListofExpense, Payexpense, Paysupplier,  Vatdetails
        If chkDeliveryApproval.Checked = True Then
            'FrmMain.MnuDeliveryApprovalToolStripMenuItem.Enabled = True
        Else
            'FrmMain.MnuDeliveryApprovalToolStripMenuItem.Enabled = False
        End If
        If chkSchemes.Checked = True Then
            FrmMain.Schemes2ToolStripMenuItem.Enabled = True
        Else
            FrmMain.Schemes2ToolStripMenuItem.Enabled = False
        End If
        If chkConstituency.Checked = True Then
            FrmMain.ConstituencyToolStripMenuItem.Enabled = True
        Else
            FrmMain.ConstituencyToolStripMenuItem.Enabled = False
        End If
        If chkCounty.Checked = True Then
            FrmMain.CountyToolStripMenuItem.Enabled = True
        Else
            FrmMain.CountyToolStripMenuItem.Enabled = False
        End If
        If chkReverseIssuance.Checked = True Then
            'FrmMain.ReverseSaleToolStripMenuItem.Enabled = True
        Else
            'FrmMain.ReverseSaleToolStripMenuItem.Enabled = False
        End If
        If chkVatdetails.Checked = True Then
            'FrmMain.VatToolStripMenuItem.Enabled = True
        Else
            'FrmMain.VatToolStripMenuItem.Enabled = False
        End If
        'Report Menu Dailysales, productwisesales,  Stockpurchases, Productwisepurchases, Expenses, Payments
        If chkdailysales.Checked = True Then
            FrmMain.DailysalesReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.DailysalesReportToolStripMenuItem.Enabled = False
        End If
        If chkproductwisesales.Checked = True Then
            FrmMain.ProductwiseSalesToolStripMenuItem.Enabled = True
        Else
            FrmMain.ProductwiseSalesToolStripMenuItem.Enabled = False
        End If
        If chkstockpurchases.Checked = True Then
            FrmMain.StockPurchasesReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.StockPurchasesReportToolStripMenuItem.Enabled = False
        End If
        If chkproductwisepurchases.Checked = True Then
            FrmMain.ProductwisepurchasesToolStripMenuItem.Enabled = True
        Else
            FrmMain.ProductwisepurchasesToolStripMenuItem.Enabled = False
        End If
        If chkexpenses.Checked = True Then
            FrmMain.SchemeReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.SchemeReportToolStripMenuItem.Enabled = False
        End If
        If chkpayments.Checked = True Then
            FrmMain.PaymentReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.PaymentReportToolStripMenuItem.Enabled = False
        End If
        'Administration Addusers , Audittrail, Voiditemlist, Useraccessrights
        If chkaddusers.Checked = True Then
            FrmMain.addsystemusersToolStripMenuItem6.Enabled = True
        Else
            FrmMain.addsystemusersToolStripMenuItem6.Enabled = False
        End If
        If chkaudittrail.Checked = True Then
            FrmMain.AudittrailToolStripMenuItem5.Enabled = True
        Else
            FrmMain.AudittrailToolStripMenuItem5.Enabled = False
        End If
        If chkvoiditemaudit.Checked = True Then
            FrmMain.VoidItemsListToolStripMenuItem.Enabled = True
        Else
            FrmMain.VoidItemsListToolStripMenuItem.Enabled = False
        End If
        If chkUserAccessrights.Checked = True Then
            FrmMain.SetUserAccessRightsToolStripMenuItem.Enabled = True
        Else
            FrmMain.SetUserAccessRightsToolStripMenuItem.Enabled = False
        End If
        'Tools Menu Backupdatabase, Systemsettings
        If chkBackupdatabase.Checked = True Then
            FrmMain.BackupdatabaseToolStripMenuItem.Enabled = True
        Else
            FrmMain.BackupdatabaseToolStripMenuItem.Enabled = False
        End If
        If chkSystemsettings.Checked = True Then
            FrmMain.SystemsettingsToolStripMenuItem.Enabled = True
        Else
            FrmMain.SystemsettingsToolStripMenuItem.Enabled = True
        End If
        'Changepassword
        If chkChangepword.Checked = True Then
            frmChangePassword.BtnChangePassword.Enabled = True
        Else
            frmChangePassword.BtnChangePassword.Enabled = False
        End If
        'Company Details CDSave, CDUpdate
        If chkCDsave.Checked = True Then
            frmCompanyDetails.saveToolStripButton5.Enabled = True
        Else
            frmCompanyDetails.saveToolStripButton5.Enabled = False
        End If
        If chkCDupdate.Checked = True Then
            frmCompanyDetails.UpdateToolStripButton3.Enabled = True
        Else
            frmCompanyDetails.UpdateToolStripButton3.Enabled = False
        End If
        'Product Details PSave, PUpdate, CSave, CUpdate, SCTSave, SCTUpdate
        If chkPsave.Checked = True Then
            frmAddUpdateProduct.PSaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateProduct.PSaveToolStripButton5.Enabled = False
        End If
        If ChkPUpdate.Checked = True Then
            frmAddUpdateProduct.PUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateProduct.PUpdateToolStripButton3.Enabled = False
        End If
        If chkCTSave.Checked = True Then
            frmAddUpdateCategory.CSaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateCategory.CSaveToolStripButton5.Enabled = False

        End If
        If ChkCTUpdate.Checked = True Then
            frmAddUpdateCategory.CUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateCategory.CUpdateToolStripButton3.Enabled = False
        End If
        If ChkSCTSave.Checked = True Then
            frmSubCategory.SCTSaveToolStripButton5.Enabled = True
        Else
            frmSubCategory.SCTSaveToolStripButton5.Enabled = False
        End If
        If ChkSCTUpdate.Checked = True Then
            frmSubCategory.SCTUpdateToolStripButton3.Enabled = True
        Else
            frmSubCategory.SCTUpdateToolStripButton3.Enabled = False
        End If
        'Suppliers SPSave, SPUpdate, PTSave,  PTUpdate, RSSave, TSTransform, TSSave
        If chkSPSave.Checked = True Then
            frmAddUpdateSupplier.SPSaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateSupplier.SPSaveToolStripButton5.Enabled = False
        End If
        If chkSPUpdate.Checked = True Then
            frmAddUpdateSupplier.SPUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateSupplier.SPUpdateToolStripButton3.Enabled = False
        End If
        If chkPTSave.Checked = True Then
            'frmPurchasemode.PTSaveToolStripButton5.Enabled = True
        Else
            'frmPurchasemode.PTSaveToolStripButton5.Enabled = False
        End If
        If chkUpdatematerialsreceived.Checked = True Then
            'frmPurchasemode.PTUpdateToolStripButton3.Enabled = True
        Else
            'frmPurchasemode.PTUpdateToolStripButton3.Enabled = False
        End If
        If chkRSSave.Checked = True Then
            'frmCashFlow.RSStaveToolStripButton52.Enabled = True
        Else
            'frmCashFlow.RSStaveToolStripButton52.Enabled = False
        End If
        If ChkCancelMaterialReceipts.Checked = True Then
            frmTransformstock.TSTransformToolStripButton4.Enabled = True
        Else
            frmTransformstock.TSTransformToolStripButton4.Enabled = False
        End If
        If chkTSSave.Checked = True Then
            frmTransformstock.TSSaveToolStripButton5.Enabled = True
        Else
            frmTransformstock.TSSaveToolStripButton5.Enabled = False
        End If
        'Customers CUSSave, CUSUpdate, LCSGetData, LCSExportToExcel
        If chkCUSSave.Checked = True Then
            frmScheme.CUSSaveToolStripButton5.Enabled = True
        Else
            frmScheme.CUSSaveToolStripButton5.Enabled = False
        End If
        If chkCUSUpdate.Checked = True Then
            frmScheme.CUSUpdateToolStripButton3.Enabled = True
        Else
            frmScheme.CUSUpdateToolStripButton3.Enabled = False
        End If
        If ChkLCSGetdata.Checked = True Then
            'frmListofmaterials.btnLCSGetData.Enabled = True
        Else
            'frmListofmaterials.btnLCSGetData.Enabled = False
        End If
        If ChkLCSExporttoExcel.Checked = True Then
            frmListofmaterials.btnLCSExportExcel.Enabled = True
        Else
            frmListofmaterials.btnLCSExportExcel.Enabled = False
        End If
        'Finance PYMSave, PYMUpdate, NWEXSave,  NWEXUpdate, LOESave, LOEUpdate, PYESave, PYSSave
        If ChkCreateToolsSave.Checked = True Then
            FrmMain.CreateToolsToolStripMenuItem2.Enabled = True
        Else
            FrmMain.CreateToolsToolStripMenuItem2.Enabled = False
        End If
        If ChkCreateEmpRoles.Checked = True Then
            FrmMain.CreateRolesToolStripMenuItem.Enabled = True
        Else
            FrmMain.CreateRolesToolStripMenuItem.Enabled = False
        End If
        If ChkCreateStaff.Checked = True Then
            FrmMain.CreateStaffToolStripMenuItem.Enabled = True
        Else
            FrmMain.CreateStaffToolStripMenuItem.Enabled = False
        End If
        If ChkCreateSuppliers.Checked = True Then
            FrmMain.SuppliersToolStripMenuItem.Enabled = True
        Else
            FrmMain.SuppliersToolStripMenuItem.Enabled = False
        End If
        If ChkLOESave.Checked = True Then
            frmAddUpdateExpenses.LOESaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateExpenses.LOESaveToolStripButton5.Enabled = False
        End If
        If ChkLOEUpdate.Checked = True Then
            frmAddUpdateExpenses.LOEUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateExpenses.LOEUpdateToolStripButton3.Enabled = True
        End If
        If ChkPYEsave.Checked = True Then
            frmUpdateMaterialDel.UpdateDeliveryMaterialToolStripButton5.Enabled = True
        Else
            frmUpdateMaterialDel.UpdateDeliveryMaterialToolStripButton5.Enabled = False
        End If
        If ChkPYSSave.Checked = True Then
            frmPaySupplier.PYSSaveToolStripButton5.Enabled = True
        Else
            frmPaySupplier.PYSSaveToolStripButton5.Enabled = False
        End If
        ' Administration AUSave, AUUpdate, AUDelete, ATDelete, VIADelete, UACSave, UACUpdate, UACDelete 
        If ChkAUSave.Checked = True Then
            frmAddUpdateStaff.AUSaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateStaff.AUSaveToolStripButton5.Enabled = False
        End If
        If ChkAUpdate.Checked = True Then
            frmAddUpdateStaff.AUUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateStaff.AUUpdateToolStripButton3.Enabled = False
        End If
        If chkAUDelete.Checked = True Then
            'frmAddUpdateStaff.AUDeleteToolStripButton2.Enabled = True
        Else
            'frmAddUpdateStaff.AUDeleteToolStripButton2.Enabled = False
        End If
        If ChkATDelete.Checked = True Then
            frmAudittrail.ATDeleteToolStripButton2.Enabled = True
        Else
            frmAudittrail.ATDeleteToolStripButton2.Enabled = False
        End If
        If chkVIADelete.Checked = True Then
            frmVoidItems.VIADeleteToolStripButton2.Enabled = True
        Else
            frmVoidItems.VIADeleteToolStripButton2.Enabled = False
        End If
        If ChkUACSave.Checked = True Then
            Me.UACSaveToolStripButton5.Enabled = True
        Else
            Me.UACSaveToolStripButton5.Enabled = False

        End If
        If chkUACUpdate.Checked = True Then
            UACUpdateToolStripButton3.Enabled = True
        Else
            UACUpdateToolStripButton3.Enabled = False
        End If
        If ChkUACDelete.Checked = True Then
            'UACDeleteToolStripButton2.Enabled = True
        Else
            'UACDeleteToolStripButton2.Enabled = False
        End If
        'POS FVoid, FTenderAmt, FPOS2, FPrice, FItemslookup, FEditQty, FItemQuickedit, POSForm
        If ChkPOSVoid.Checked = True Then
            FrmPointofSale.VoidToolStripButton4.Enabled = True
        Else
            FrmPointofSale.VoidToolStripButton4.Enabled = False
        End If
        If chkPOSTenderAmt.Checked = True Then
            FrmPointofSale.PSaveToolStripButton.Enabled = True
        Else
            FrmPointofSale.PSaveToolStripButton.Enabled = False
        End If
        If chkPOSopenPOS2.Checked = True Then
            'FrmPointofSale.BTNOpenPOS2.Enabled = True
        Else
            'FrmPointofSale.BTNOpenPOS2.Enabled = False
        End If
        If chkPOSEditPrice.Checked = True Then
            'FrmPointofSale.BtnChgPrice.Enabled = True
        Else
            'FrmPointofSale.BtnChgPrice.Enabled = False
        End If
        If chkPOSItemsLookup.Checked = True Then
            FrmPointofSale.LookupToolStripButton3.Enabled = True
        Else
            FrmPointofSale.LookupToolStripButton3.Enabled = False
        End If
        If chkPOSEditQty.Checked = True Then
            'FrmPointofSale.btnaddQty.Enabled = True
        Else
            'FrmPointofSale.btnaddQty.Enabled = False
        End If
        If chkPOSItemquickEdit.Checked = True Then
            'FrmPointofSale.BTNQucikItemEdit.Enabled = True
        Else
            'FrmPointofSale.BTNQucikItemEdit.Enabled = False
        End If
        If ChkPOS.Checked = True Then
            FrmPointofSale.Enabled = True
        Else
            FrmPointofSale.Enabled = False
        End If
        'Menu Bar TSBProduct, TSBStock, TSBStaff, TSBCategory, TSBPOS, TSBVoidItems, TSBDailySales, TSBStockIn, TSBPayments, TSBExpenses  
        If chkTSBProduct.Checked = True Then
            FrmMain.ProductToolStripButton2.Enabled = True
        Else
            FrmMain.ProductToolStripButton2.Enabled = False
        End If
        If chkTSBNewstock.Checked = True Then
            FrmMain.StockToolStripButton8.Enabled = True
        Else
            FrmMain.StockToolStripButton8.Enabled = False
        End If
        If chkTSBPOS.Checked = True Then
            FrmMain.POSToolStripButton5.Enabled = True
        Else
            FrmMain.POSToolStripButton5.Enabled = False
        End If
        If chkTSBVoidItems.Checked = True Then
            FrmMain.MaterialIssuedToolStripButton9.Enabled = True
        Else
            FrmMain.MaterialIssuedToolStripButton9.Enabled = False
        End If
        If chkTSBDailysales.Checked = True Then
            FrmMain.MaterialDeliveryNoteToolStripButton7.Enabled = True
        Else
            FrmMain.MaterialDeliveryNoteToolStripButton7.Enabled = False
        End If
        If chkTSBStockIn.Checked = True Then
            FrmMain.StockInToolStripButton1.Enabled = True
        Else
            FrmMain.StockInToolStripButton1.Enabled = False
        End If
        If chkTSBPayments.Checked = True Then
            FrmMain.DeliverytoschemesToolStripButton10.Enabled = True
        Else
            FrmMain.DeliverytoschemesToolStripButton10.Enabled = False
        End If
        If chkTSBExpenses.Checked = True Then
            FrmMain.ApprovalToolStripButton6.Enabled = True
        Else
            FrmMain.ApprovalToolStripButton6.Enabled = False
        End If
        'POS UpdatesPOSRecallsale, POSQckstkPurc, POSDeleteUncleredsale, POSUpdateRecall
        If chkPOSRecallsale.Checked = True Then
            'FrmPointofSale.BTNRecallTrans.Enabled = True
        Else
            'FrmPointofSale.BTNRecallTrans.Enabled = False
        End If
        If chkPOSQckstkpurch.Checked = True Then
            'FrmPointofSale.BTNqckpurchase.Enabled = True
        Else
            'FrmPointofSale.BTNqckpurchase.Enabled = False
        End If
        If chkPOSdeleteunclredsale.Checked = True Then
            'FrmPointofSale.BtnRecoverUnclearedsale.Enabled = True
        Else
            'FrmPointofSale.BtnRecoverUnclearedsale.Enabled = False
        End If
        If chkPOSsaverecallsale.Checked = True Then
            'FrmPointofSale.BtnUpdate.Enabled = True
        Else
            'FrmPointofSale.BtnUpdate.Enabled = False
        End If
        'Qckstockpurch, QckstkSave, QckStkUpdate,  MNBCompany, MNBUserLog, MNBPrivilages,  MNBCashsales
        If chkAllocateTools.Checked = True Then
            FrmMain.ToolsAllocationPurchaseToolStripMenuItem.Enabled = True
        Else
            FrmMain.ToolsAllocationPurchaseToolStripMenuItem.Enabled = False
        End If
        If chkReturnTools.Checked = True Then
            frmStockIn.QCKsaveToolStripButton5.Enabled = True
        Else
            frmStockIn.QCKsaveToolStripButton5.Enabled = False
        End If
        If chkupdateDelivery.Checked = True Then
            frmStockIn.QCKUpdateToolStripButton3.Enabled = True
        Else
            frmStockIn.QCKUpdateToolStripButton3.Enabled = False
        End If
        If chkMNUserlog.Checked = True Then
            FrmMain.UserLogToolStripButton2.Enabled = True
        Else
            FrmMain.UserLogToolStripButton2.Enabled = False
        End If
        If chkMNPrivilages.Checked = True Then
            FrmMain.PrivilagesToolStripButton3.Enabled = True
        Else
            FrmMain.PrivilagesToolStripButton3.Enabled = False
        End If
        If chkMNSales.Checked = True Then
            FrmMain.CreateToolsToolStripButton1.Enabled = True
        Else
            FrmMain.CreateToolsToolStripButton1.Enabled = False
        End If
        'Pos POSGridPrice, POSGridAmount
        If ChkPOSGridPrice.Checked = True Then
            FrmPointofSale.dgwIssueItems.Columns(2).Selected = False
        Else
            FrmPointofSale.dgwIssueItems.Columns(2).Selected = True
        End If
        If ChkPOSGridAmt.Checked = True Then
            FrmPointofSale.dgwIssueItems.Columns(4).Selected = False
        Else
            FrmPointofSale.dgwIssueItems.Columns(4).Selected = True
        End If
        'Invoicing Menus
        'Billing Items
        If chkBillingItems.Checked = True Then
            FrmMain.BillingItemsToolStripMenuItem.Enabled = True
        Else
            FrmMain.BillingItemsToolStripMenuItem.Enabled = False
        End If
        'create statement
        If chkCreateStatement.Checked = True Then
            'FrmMain.CreateStatementToolStripMenuItem.Enabled = True
        Else
            'FrmMain.CreateStatementToolStripMenuItem.Enabled = False
        End If
        'statement approval
        If chkStatementapproval.Checked = True Then
            'FrmMain.StatementApprovalToolStripMenuItem.Enabled = True
        Else
            'FrmMain.StatementApprovalToolStripMenuItem.Enabled = False
        End If
        'Update Statement
        If chkUpdateStatement.Checked = True Then
            'FrmMain.UpdateStatementToolStripMenuItem.Enabled = True
        Else
            'FrmMain.UpdateStatementToolStripMenuItem.Enabled = False
        End If
        'List of statement
        If chkListofStatements.Checked = True Then
            'FrmMain.ListofstatementsToolStripMenuItem.Enabled = True
        Else
            'FrmMain.ListofstatementsToolStripMenuItem.Enabled = False
        End If
        'print statement
        If chkPrintStatement.Checked = True Then
            'FrmMain.PrintStatementToolStripMenuItem.Enabled = True
        Else
            'FrmMain.PrintStatementToolStripMenuItem.Enabled = False
        End If

        'Transport Menu
        'warehouses
        If chkWarehouse.Checked = True Then
            FrmMain.WarehousesToolStripMenuItem.Enabled = True
        Else
            FrmMain.WarehousesToolStripMenuItem.Enabled = False
        End If
        'transporters
        If chkTransporter.Checked = True Then
            FrmMain.TransportersToolStripMenuItem.Enabled = True
        Else
            FrmMain.TransportersToolStripMenuItem.Enabled = False
        End If
        'transport register
        If chkTransportregister.Checked = True Then
            FrmMain.TransportRegisterToolStripMenuItem.Enabled = True
        Else
            FrmMain.TransportRegisterToolStripMenuItem.Enabled = False
        End If
        'update transport register
        If chkUpdateTransportregister.Checked = True Then
            FrmMain.UpdateRegisterToolStripMenuItem.Enabled = True
        Else
            FrmMain.UpdateRegisterToolStripMenuItem.Enabled = False
        End If

        'Inventory Menu
        'Material Issuance
        If chkIssueMaterials.Checked = True Then
            FrmMain.MaterialIssuanceToolStripMenuItem.Enabled = True
        Else
            FrmMain.MaterialIssuanceToolStripMenuItem.Enabled = False
        End If
        'Delivery Approval
        If chkDeliveryApproval.Checked = True Then
            FrmMain.ApproveDeliveryToolStripMenuItem.Enabled = True
        Else
            FrmMain.ApproveDeliveryToolStripMenuItem.Enabled = False

        End If
        'Update Delivery
        If chkupdateDelivery.Checked = True Then
            FrmMain.UpdateDeliveryToolStripMenuItem.Enabled = True
        Else
            FrmMain.UpdateDeliveryToolStripMenuItem.Enabled = False
        End If
        'Return materials
        If chkreturnmaterials.Checked = True Then
            FrmMain.ReturnIssuanceToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReturnIssuanceToolStripMenuItem.Enabled = False
        End If
        'Receive Materials
        If chkreceivestock.Checked = True Then
            FrmMain.ReceiveGoodsToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReceiveGoodsToolStripMenuItem.Enabled = False
        End If
        'Update Materials Received
        If chkUpdatematerialsreceived.Checked = True Then
            FrmMain.UpdateMaterialReceiptToolStripMenuItem.Enabled = True
        Else
            FrmMain.UpdateMaterialReceiptToolStripMenuItem.Enabled = False
        End If
        'CancelMaterialReceipts
        If ChkCancelMaterialReceipts.Checked = True Then
            FrmMain.CancelMaterialReceiptsToolStripMenuItem.Enabled = True
        Else
            FrmMain.CancelMaterialReceiptsToolStripMenuItem.Enabled = False
        End If
        'Meters
        'Metering Menu
        If chkMeters.Checked = True Then
            FrmMain.MetersToolStripMenuItem.Enabled = True
        Else
            FrmMain.MetersToolStripMenuItem.Enabled = False
        End If
        'Receive Meters
        If chkReceiveMeters.Checked = True Then
            FrmMain.ReceiveMetersToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReceiveMetersToolStripMenuItem.Enabled = False
        End If
        'Issue Meters
        If chkIssueMeters.Checked = True Then
            FrmMain.IssueMetersToolStripMenuItem.Enabled = True
        Else
            FrmMain.IssueMetersToolStripMenuItem.Enabled = False
        End If
        'Update Meterlist
        If chkUpdateMeters.Checked = True Then
            FrmMain.UpdateCustomerDetailsToolStripMenuItem.Enabled = True
        Else
            FrmMain.UpdateCustomerDetailsToolStripMenuItem.Enabled = False
        End If
        'Meter BoQs
        If chkMeterBoQ.Checked = True Then
            FrmMain.MeterInstallationStatementToolStripMenuItem.Enabled = True
        Else
            FrmMain.MeterInstallationStatementToolStripMenuItem.Enabled = False
        End If
        'Technician BoQs
        If chkTechBoQ.Checked = True Then
            FrmMain.TechncianBoQToolStripMenuItem.Enabled = True
        Else
            FrmMain.TechncianBoQToolStripMenuItem.Enabled = False
        End If

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE groupusers Set File = '" & chkFilemenu.CheckState & "', Product = '" & chckMaterialsmenu.CheckState & "', Suppliers = '" & chkInventory.CheckState & "', Customers = '" & chkCustomersMenu.CheckState & "', Finance = '" & chckSchemes.CheckState & "', Reports = '" & chckReports.CheckState & "', Administration = '" & ChkAdministration.CheckState & "', Tools = '" & chkTools.CheckState & "', CompanyDetails = '" & ChkCompanydetails.CheckState & "', ChangePassord = '" & chkchangepassword.CheckState & "', Logout = '" & chcklogout.CheckState & "', Addupdateproduct = '" & Chkaddupdateproduct.CheckState & "', Category = '" & chkCategory.CheckState & "', Subcategory = '" & chkSubcategory.CheckState & "', AdjustStock = '" & chkAdjuststock.CheckState & "', Productlookup = '" & chckSearchProduct.CheckState & "', ProductJournal = '" & chkProductJournal.CheckState & "', AddUpdateSupplier = '" & ChkaddReceiveMaterials.CheckState & "', Purchaseterms = '" & chkIssueMaterials.CheckState & "', ReceiveStock = '" & chkreceivestock.CheckState & "', ListofStockreceived = '" & chkreturnmaterials.CheckState & "', TransformStock = '" & chkreceivetools.CheckState & "', Addupdatecustomers = '" & chkaddupdatecutomers.CheckState & "', Listofcashsales = '" & chklistofcashsales.CheckState & "', Paymentmodes = '" & chkDeliveryApproval.CheckState & "', NewExpense = '" & chkSchemes.CheckState & "', ListofExpense = '" & chkConstituency.CheckState & "', Payexpense = '" & chkCounty.CheckState & "', Paysupplier = '" & chkReverseIssuance.CheckState & "',  Vatdetails = '" & chkVatdetails.CheckState & "', Dailysales = '" & chkdailysales.CheckState & "', productwisesales = '" & chkproductwisesales.CheckState & "',  Stockpurchases = '" & chkstockpurchases.CheckState & "', Productwisepurchases = '" & chkproductwisepurchases.CheckState & "', Expenses = '" & chkexpenses.CheckState & "', Payments = '" & chkpayments.CheckState & "', Addusers = '" & chkaddusers.CheckState & "' , Audittrail = '" & chkaudittrail.CheckState & "', Voiditemlist = '" & chkvoiditemaudit.CheckState & "', Useraccessrights = '" & chkUserAccessrights.CheckState & "', Backupdatabase = '" & chkBackupdatabase.CheckState & "', Systemsettings = '" & chkSystemsettings.CheckState & "', Changepassword = '" & chkChangepword.CheckState & "', CDSave = '" & chkCDsave.CheckState & "', CDUpdate = '" & chkCDupdate.CheckState & "', PSave = '" & chkPsave.CheckState & "', PUpdate = '" & ChkPUpdate.CheckState & "', CSave = '" & chkCTSave.CheckState & "', CUpdate = '" & ChkCTUpdate.CheckState & "', SCTSave = '" & ChkSCTSave.CheckState & "', SCTUpdate = '" & ChkSCTUpdate.CheckState & "', SPSave = '" & chkSPSave.CheckState & "', SPUpdate = '" & chkSPUpdate.CheckState & "', PTSave = '" & chkPTSave.CheckState & "',  PTUpdate = '" & chkUpdatematerialsreceived.CheckState & "', RSSave = '" & chkRSSave.CheckState & "', TSTransform = '" & ChkCancelMaterialReceipts.CheckState & "', TSSave = '" & chkTSSave.CheckState & "', CUSSave = '" & chkCUSSave.CheckState & "', CUSUpdate = '" & chkCUSUpdate.CheckState & "', LCSGetData = '" & ChkLCSGetdata.CheckState & "', LCSExportToExcel = '" & ChkLCSExporttoExcel.CheckState & "', PYMSave = '" & ChkCreateToolsSave.CheckState & "' , PYMUpdate = '" & ChkCreateEmpRoles.CheckState & "', NWEXSave = '" & ChkCreateStaff.CheckState & "',  NWEXUpdate = '" & ChkCreateSuppliers.CheckState & "', LOESave = '" & ChkLOESave.CheckState & "', LOEUpdate = '" & ChkLOEUpdate.CheckState & "', PYESave = '" & ChkPYEsave.CheckState & "', PYSSave = '" & ChkPYSSave.CheckState & "', AUSave = '" & ChkAUSave.CheckState & "', AUUpdate = '" & ChkAUpdate.CheckState & "', AUDelete = '" & chkAUDelete.CheckState & "', ATDelete = '" & ChkATDelete.CheckState & "', VIADelete = '" & chkVIADelete.CheckState & "', UACSave = '" & ChkUACSave.CheckState & "', UACUpdate = '" & chkUACUpdate.CheckState & "', UACDelete = '" & ChkUACDelete.CheckState & "', FVoid = '" & ChkPOSVoid.CheckState & "', FTenderAmt = '" & chkPOSTenderAmt.CheckState & "', FPOS2 = '" & chkPOSopenPOS2.CheckState & "', FPrice = '" & chkPOSEditPrice.CheckState & "', FItemslookup = '" & chkPOSItemsLookup.CheckState & "', FEditQty = '" & chkPOSEditQty.CheckState & "', FItemQuickedit = '" & chkPOSItemquickEdit.CheckState & "', POSForm = '" & ChkPOS.CheckState & "', TSBProduct = '" & chkTSBProduct.CheckState & "', TSBStock = '" & chkTSBNewstock.CheckState & "', TSBPOS = '" & chkTSBPOS.CheckState & "', TSBVoidItems = '" & chkTSBVoidItems.CheckState & "', TSBDailySales = '" & chkTSBDailysales.CheckState & "', TSBStockIn = '" & chkTSBStockIn.CheckState & "', TSBPayments = '" & chkTSBPayments.CheckState & "', TSBExpenses = '" & chkTSBExpenses.CheckState & "', POSRecallsale = '" & chkPOSRecallsale.CheckState & "', POSQckstkPurc = '" & chkPOSQckstkpurch.CheckState & "', POSDeleteUncleredsale = '" & chkPOSdeleteunclredsale.CheckState & "', POSUpdateRecall = '" & chkPOSsaverecallsale.CheckState & "', Qckstockpurch = '" & chkAllocateTools.CheckState & "', QckstkSave = '" & chkReturnTools.CheckState & "', QckStkUpdate = '" & chkupdateDelivery.CheckState & "', MNBUserLog = '" & chkMNUserlog.CheckState & "', MNBPrivilages = '" & chkMNPrivilages.CheckState & "', MNBCashsales = '" & chkMNSales.CheckState & "', POSGridPrice = '" & ChkPOSGridPrice.CheckState & "', POSGridAmount = '" & ChkPOSGridAmt.CheckState & "', Invoicing = '" & chkInvoicing.CheckState & "',  InvoicingItems = '" & chkBillingItems.CheckState & "', Createstatement = '" & chkCreateStatement.CheckState & "', Statementapproval = '" & chkStatementapproval.CheckState & "', Updatestatement = '" & chkUpdateStatement.CheckState & "', ListofInvoices = '" & chkListofStatements.CheckState & "', Printstatement = '" & chkPrintStatement.CheckState & "', MnuTransport = '" & chkTransport.CheckState & "', Warehouse = '" & chkWarehouse.CheckState & "', Transporter = '" & chkTransporter.CheckState & "', Transportregister = '" & chkTransportregister.CheckState & "', UpdateTransRegister = '" & chkUpdateTransportregister.CheckState & "', MaterialIssuance = '" & chkIssueMaterials.CheckState & "' , ApproveDelivery = '" & chkDeliveryApproval.CheckState & "', UpdateDelivery = '" & chkupdateDelivery.CheckState & "', ReturnMaterials = '" & chkreturnmaterials.CheckState & "', ReceiveMaterials = '" & chkreceivestock.CheckState & "', UpdateMatReceipt = '" & chkUpdatematerialsreceived.CheckState & "', CancelMatReceipt = '" & ChkCancelMaterialReceipts.CheckState & "', mnuMeters = '" & chkMeters.CheckState & "', Receivemeters = '" & chkReceiveMeters.CheckState & "', IssueMeters = '" & chkIssueMeters.CheckState & "', UpdateMeters = '" & chkUpdateMeters.CheckState & "', MeterBoQ = '" & chkMeterBoQ.CheckState & "', TechBoQ = '" & chkTechBoQ.CheckState & "' Where UserGroupName = '" & CboUsers.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader()
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
            MysqlConn.Close()
        End Try
    End Sub
    Public Sub updateadmin()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        If chkFilemenu.Checked = True Then
            FrmMain.FileToolStripMenuItem.Enabled = True
        Else
            FrmMain.FileToolStripMenuItem.Enabled = True
        End If
        If chckMaterialsmenu.Checked = True Then
            FrmMain.MastersToolStripMenuItem.Enabled = True
        Else
            FrmMain.MastersToolStripMenuItem.Enabled = True
        End If
        If chkInventory.Checked = True Then
            FrmMain.InventoryToolStripMenuItem.Enabled = True
        Else
            FrmMain.InventoryToolStripMenuItem.Enabled = True
        End If
        If chkCustomersMenu.Checked = True Then
            FrmMain.SchemeToolStripMenuItem.Enabled = True
        Else
            FrmMain.SchemeToolStripMenuItem.Enabled = True
        End If
        If chckSchemes.Checked = True Then
            FrmMain.MetersToolStripMenuItem.Enabled = True
        Else
            FrmMain.MetersToolStripMenuItem.Enabled = True
        End If
        If chckReports.Checked = True Then
            FrmMain.ReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReportToolStripMenuItem.Enabled = True
        End If
        If ChkAdministration.Checked = True Then
            FrmMain.ProjectSummaryToolStripMenuItem4.Enabled = True
        Else
            FrmMain.ProjectSummaryToolStripMenuItem4.Enabled = True
        End If
        If chkTools.Checked = True Then
            FrmMain.ToolStripMenuItem1.Enabled = True
        Else
            FrmMain.ToolStripMenuItem1.Enabled = True
        End If
        'filemenu
        If ChkCompanydetails.Checked = True Then
            FrmMain.CompanyDetailsToolStripMenuItem.Enabled = True
        Else
            FrmMain.CompanyDetailsToolStripMenuItem.Enabled = True
        End If
        If chkchangepassword.Checked = True Then
            FrmMain.ChangePasswordToolStripMenuItem.Enabled = True
        Else
            FrmMain.ChangePasswordToolStripMenuItem.Enabled = True
        End If
        If chcklogout.Checked = True Then
            FrmMain.ExitToolStripMenuItem.Enabled = True
        Else
            FrmMain.ExitToolStripMenuItem.Enabled = True
        End If
        'Product Menu 
        If Chkaddupdateproduct.Checked = True Then
            FrmMain.addupdateproductToolStripMenuItem.Enabled = True
        Else
            FrmMain.addupdateproductToolStripMenuItem.Enabled = True
        End If
        If chkCategory.Checked = True Then
            FrmMain.CategoryToolStripMenuItem.Enabled = True
        Else
            FrmMain.CategoryToolStripMenuItem.Enabled = True
        End If
        If chkSubcategory.Checked = True Then
            FrmMain.NewSubcategoryToolStripMenuItem.Enabled = True
        Else
            FrmMain.NewSubcategoryToolStripMenuItem.Enabled = True
        End If
        If chkAdjuststock.Checked = True Then
            FrmMain.AdjuststockToolStripMenuItem.Enabled = True
        Else
            FrmMain.AdjuststockToolStripMenuItem.Enabled = True
        End If
        If chckSearchProduct.Checked = True Then
            FrmMain.ProductlookupToolStripMenuItem.Enabled = True
        Else
            FrmMain.ProductlookupToolStripMenuItem.Enabled = True
        End If
        If chkProductJournal.Checked = True Then
            FrmMain.ProductJournalToolStripMenuItem.Enabled = True
        Else
            FrmMain.ProductJournalToolStripMenuItem.Enabled = True
        End If
        'Supplier Menu
        If ChkaddReceiveMaterials.Checked = True Then
            'FrmMain.ReceiveMaterialsToolStripMenuItem.Enabled = True
        Else
            'FrmMain.ReceiveMaterialsToolStripMenuItem.Enabled = True
        End If
        If chkIssueMaterials.Checked = True Then
            'FrmMain.IssueMaterialsToolStripMenuItem.Enabled = True
        Else
            'FrmMain.IssueMaterialsToolStripMenuItem.Enabled = True
        End If
        If chkreceivestock.Checked = True Then
            FrmMain.ReceiveGoodsToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReceiveGoodsToolStripMenuItem.Enabled = True
        End If
        If chkreturnmaterials.Checked = True Then
            FrmMain.ListofStockrcvedToolStripMenuItem.Enabled = True
        Else
            FrmMain.ListofStockrcvedToolStripMenuItem.Enabled = True
        End If
        If chkreceivetools.Checked = True Then
            FrmMain.ReceivetoolssToolStripMenuItem.Enabled = True
        Else
            FrmMain.ReceivetoolssToolStripMenuItem.Enabled = True
        End If
        'Customers Menu 
        If chkaddupdatecutomers.Checked = True Then
            FrmMain.Schemes2ToolStripMenuItem.Enabled = True
        Else
            FrmMain.Schemes2ToolStripMenuItem.Enabled = True
        End If
        If chklistofcashsales.Checked = True Then
            'FrmMain.ListOfCashSalesToolStripMenuItem.Enabled = True
        Else
            'FrmMain.ListOfCashSalesToolStripMenuItem.Enabled = True
        End If
        'Finance Menu
        'Finance Menu Paymentmodes, NewExpense, ListofExpense, Payexpense, Paysupplier,  Vatdetails
        If chkDeliveryApproval.Checked = True Then
            'FrmMain.PaymentModesToolStripMenuItem.Enabled = True
        Else
            'FrmMain.PaymentModesToolStripMenuItem.Enabled = True
        End If
        If chkSchemes.Checked = True Then
            FrmMain.Schemes2ToolStripMenuItem.Enabled = True
        Else
            FrmMain.Schemes2ToolStripMenuItem.Enabled = True
        End If
        If chkConstituency.Checked = True Then
            'FrmMain.ListofexpensesoolStripMenuItem.Enabled = True
        Else
            'FrmMain.ListofexpensesoolStripMenuItem.Enabled = True
        End If
        If chkCounty.Checked = True Then
            'FrmMain.PayExpenseToolStripMenuItem.Enabled = True
        Else
            'FrmMain.PayExpenseToolStripMenuItem.Enabled = True
        End If
        If chkReverseIssuance.Checked = True Then
            'FrmMain.PaySupplierToolStripMenuItem.Enabled = True
        Else
            'FrmMain.PaySupplierToolStripMenuItem.Enabled = True
        End If
        If chkVatdetails.Checked = True Then
            'FrmMain.VatToolStripMenuItem.Enabled = True
        Else
            'FrmMain.VatToolStripMenuItem.Enabled = True
        End If
        'Report Menu Dailysales, productwisesales,  Stockpurchases, Productwisepurchases, Expenses, Payments
        If chkdailysales.Checked = True Then
            FrmMain.DailysalesReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.DailysalesReportToolStripMenuItem.Enabled = True
        End If
        If chkproductwisesales.Checked = True Then
            FrmMain.ProductwiseSalesToolStripMenuItem.Enabled = True
        Else
            FrmMain.ProductwiseSalesToolStripMenuItem.Enabled = True
        End If
        If chkstockpurchases.Checked = True Then
            FrmMain.StockPurchasesReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.StockPurchasesReportToolStripMenuItem.Enabled = True
        End If
        If chkproductwisepurchases.Checked = True Then
            FrmMain.ProductwisepurchasesToolStripMenuItem.Enabled = True
        Else
            FrmMain.ProductwisepurchasesToolStripMenuItem.Enabled = True
        End If
        If chkexpenses.Checked = True Then
            FrmMain.SchemeReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.SchemeReportToolStripMenuItem.Enabled = True
        End If
        If chkpayments.Checked = True Then
            FrmMain.PaymentReportToolStripMenuItem.Enabled = True
        Else
            FrmMain.PaymentReportToolStripMenuItem.Enabled = True
        End If
        'Administration Addusers , Audittrail, Voiditemlist, Useraccessrights
        If chkaddusers.Checked = True Then
            FrmMain.addsystemusersToolStripMenuItem6.Enabled = True
        Else
            FrmMain.addsystemusersToolStripMenuItem6.Enabled = True
        End If
        If chkaudittrail.Checked = True Then
            FrmMain.AudittrailToolStripMenuItem5.Enabled = True
        Else
            FrmMain.AudittrailToolStripMenuItem5.Enabled = True
        End If
        If chkvoiditemaudit.Checked = True Then
            FrmMain.VoidItemsListToolStripMenuItem.Enabled = True
        Else
            FrmMain.VoidItemsListToolStripMenuItem.Enabled = True
        End If
        If chkUserAccessrights.Checked = True Then
            FrmMain.SetUserAccessRightsToolStripMenuItem.Enabled = True
        Else
            FrmMain.SetUserAccessRightsToolStripMenuItem.Enabled = True
        End If
        'Tools Menu Backupdatabase, Systemsettings
        If chkBackupdatabase.Checked = True Then
            FrmMain.BackupdatabaseToolStripMenuItem.Enabled = True
        Else
            FrmMain.BackupdatabaseToolStripMenuItem.Enabled = True
        End If
        If chkSystemsettings.Checked = True Then
            FrmMain.SystemsettingsToolStripMenuItem.Enabled = True
        Else
            FrmMain.SystemsettingsToolStripMenuItem.Enabled = True
        End If
        'Changepassword
        If chkChangepword.Checked = True Then
            frmChangePassword.BtnChangePassword.Enabled = True
        Else
            frmChangePassword.BtnChangePassword.Enabled = True
        End If
        'Company Details CDSave, CDUpdate
        If chkCDsave.Checked = True Then
            frmCompanyDetails.saveToolStripButton5.Enabled = True
        Else
            frmCompanyDetails.saveToolStripButton5.Enabled = True
        End If
        If chkCDupdate.Checked = True Then
            frmCompanyDetails.UpdateToolStripButton3.Enabled = True
        Else
            frmCompanyDetails.UpdateToolStripButton3.Enabled = True
        End If
        'Product Details PSave, PUpdate, CSave, CUpdate, SCTSave, SCTUpdate
        If chkPsave.Checked = True Then
            frmAddUpdateProduct.PSaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateProduct.PSaveToolStripButton5.Enabled = True
        End If
        If ChkPUpdate.Checked = True Then
            frmAddUpdateProduct.PUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateProduct.PUpdateToolStripButton3.Enabled = True
        End If
        If chkCTSave.Checked = True Then
            frmAddUpdateCategory.CSaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateCategory.CSaveToolStripButton5.Enabled = True
        End If
        If ChkCTUpdate.Checked = True Then
            frmAddUpdateCategory.CUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateCategory.CUpdateToolStripButton3.Enabled = True
        End If
        If ChkSCTSave.Checked = True Then
            frmSubCategory.SCTSaveToolStripButton5.Enabled = True
        Else
            frmSubCategory.SCTSaveToolStripButton5.Enabled = True
        End If
        If ChkSCTUpdate.Checked = True Then
            frmSubCategory.SCTUpdateToolStripButton3.Enabled = True
        Else
            frmSubCategory.SCTUpdateToolStripButton3.Enabled = True
        End If
        'Suppliers SPSave, SPUpdate, PTSave,  PTUpdate, RSSave, TSTransform, TSSave
        If chkSPSave.Checked = True Then
            frmAddUpdateSupplier.SPSaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateSupplier.SPSaveToolStripButton5.Enabled = True
        End If
        If chkSPUpdate.Checked = True Then
            frmAddUpdateSupplier.SPUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateSupplier.SPUpdateToolStripButton3.Enabled = True
        End If
        If chkPTSave.Checked = True Then
            'frmPurchasemode.PTSaveToolStripButton5.Enabled = True
        Else
            'frmPurchasemode.PTSaveToolStripButton5.Enabled = True
        End If
        If chkUpdatematerialsreceived.Checked = True Then
            'frmPurchasemode.PTUpdateToolStripButton3.Enabled = True
        Else
            'frmPurchasemode.PTUpdateToolStripButton3.Enabled = True
        End If
        If chkRSSave.Checked = True Then
            'frmCashFlow.RSStaveToolStripButton52.Enabled = True
        Else
            'frmCashFlow.RSStaveToolStripButton52.Enabled = True
        End If
        If ChkCancelMaterialReceipts.Checked = True Then
            frmTransformstock.TSTransformToolStripButton4.Enabled = True
        Else
            frmTransformstock.TSTransformToolStripButton4.Enabled = True
        End If
        If chkTSSave.Checked = True Then
            frmTransformstock.TSSaveToolStripButton5.Enabled = True
        Else
            frmTransformstock.TSSaveToolStripButton5.Enabled = True
        End If
        'Customers CUSSave, CUSUpdate, LCSGetData, LCSExportToExcel
        If chkCUSSave.Checked = True Then
            frmScheme.CUSSaveToolStripButton5.Enabled = True
        Else
            frmScheme.CUSSaveToolStripButton5.Enabled = True
        End If
        If chkCUSUpdate.Checked = True Then
            frmScheme.CUSUpdateToolStripButton3.Enabled = True
        Else
            frmScheme.CUSUpdateToolStripButton3.Enabled = True
        End If
        If ChkLCSGetdata.Checked = True Then
            'frmListofmaterials.btnLCSGetData.Enabled = True
        Else
            'frmListofmaterials.btnLCSGetData.Enabled = True
        End If
        If ChkLCSExporttoExcel.Checked = True Then
            frmListofmaterials.btnLCSExportExcel.Enabled = True
        Else
            frmListofmaterials.btnLCSExportExcel.Enabled = True
        End If
        'Finance PYMSave, PYMUpdate, NWEXSave,  NWEXUpdate, LOESave, LOEUpdate, PYESave, PYSSave
        If ChkCreateToolsSave.Checked = True Then
            FrmMain.CreateToolsToolStripMenuItem2.Enabled = True
        Else
            FrmMain.CreateToolsToolStripMenuItem2.Enabled = True
        End If
        If ChkCreateEmpRoles.Checked = True Then
            FrmMain.CreateRolesToolStripMenuItem.Enabled = True
        Else
            FrmMain.CreateRolesToolStripMenuItem.Enabled = True
        End If
        If ChkCreateStaff.Checked = True Then
            FrmMain.CreateStaffToolStripMenuItem.Enabled = True
        Else
            FrmMain.CreateStaffToolStripMenuItem.Enabled = True
        End If
        If ChkCreateSuppliers.Checked = True Then
            FrmMain.SuppliersToolStripMenuItem.Enabled = True
        Else
            FrmMain.SuppliersToolStripMenuItem.Enabled = True
        End If
        If ChkLOESave.Checked = True Then
            frmAddUpdateExpenses.LOESaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateExpenses.LOESaveToolStripButton5.Enabled = True
        End If
        If ChkLOEUpdate.Checked = True Then
            frmAddUpdateExpenses.LOEUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateExpenses.LOEUpdateToolStripButton3.Enabled = True
        End If
        If ChkPYEsave.Checked = True Then
            frmUpdateMaterialDel.UpdateDeliveryMaterialToolStripButton5.Enabled = True
        Else
            frmUpdateMaterialDel.UpdateDeliveryMaterialToolStripButton5.Enabled = True
        End If
        If ChkPYSSave.Checked = True Then
            frmPaySupplier.PYSSaveToolStripButton5.Enabled = True
        Else
            frmPaySupplier.PYSSaveToolStripButton5.Enabled = True
        End If
        ' Administration AUSave, AUUpdate, AUDelete, ATDelete, VIADelete, UACSave, UACUpdate, UACDelete 
        If ChkAUSave.Checked = True Then
            frmAddUpdateStaff.AUSaveToolStripButton5.Enabled = True
        Else
            frmAddUpdateStaff.AUSaveToolStripButton5.Enabled = True
        End If
        If ChkAUpdate.Checked = True Then
            frmAddUpdateStaff.AUUpdateToolStripButton3.Enabled = True
        Else
            frmAddUpdateStaff.AUUpdateToolStripButton3.Enabled = True
        End If
        If chkAUDelete.Checked = True Then
            'frmAddUpdateStaff.AUDeleteToolStripButton2.Enabled = True
        Else
            'frmAddUpdateStaff.AUDeleteToolStripButton2.Enabled = True
        End If
        If ChkATDelete.Checked = True Then
            frmAudittrail.ATDeleteToolStripButton2.Enabled = True
        Else
            frmAudittrail.ATDeleteToolStripButton2.Enabled = True
        End If
        If chkVIADelete.Checked = True Then
            frmVoidItems.VIADeleteToolStripButton2.Enabled = True
        Else
            frmVoidItems.VIADeleteToolStripButton2.Enabled = True
        End If
        If ChkUACSave.Checked = True Then
            Me.UACSaveToolStripButton5.Enabled = True
        Else
            Me.UACSaveToolStripButton5.Enabled = True

        End If
        If chkUACUpdate.Checked = True Then
            UACUpdateToolStripButton3.Enabled = True
        Else
            UACUpdateToolStripButton3.Enabled = True
        End If
        If ChkUACDelete.Checked = True Then
            'UACDeleteToolStripButton2.Enabled = True
        Else
            'UACDeleteToolStripButton2.Enabled = True
        End If
        'POS FVoid, FTenderAmt, FPOS2, FPrice, FItemslookup, FEditQty, FItemQuickedit, POSForm
        If ChkPOSVoid.Checked = True Then
            FrmPointofSale.VoidToolStripButton4.Enabled = True
        Else
            FrmPointofSale.VoidToolStripButton4.Enabled = True
        End If
        If chkPOSTenderAmt.Checked = True Then
            FrmPointofSale.PSaveToolStripButton.Enabled = True
        Else
            FrmPointofSale.PSaveToolStripButton.Enabled = True
        End If
        If chkPOSopenPOS2.Checked = True Then
            'FrmPointofSale.BTNOpenPOS2.Enabled = True
        Else
            'FrmPointofSale.BTNOpenPOS2.Enabled = True
        End If
        If chkPOSEditPrice.Checked = True Then
            'FrmPointofSale.BtnChgPrice.Enabled = True
        Else
            'FrmPointofSale.BtnChgPrice.Enabled = True
        End If
        If chkPOSItemsLookup.Checked = True Then
            FrmPointofSale.LookupToolStripButton3.Enabled = True
        Else
            FrmPointofSale.LookupToolStripButton3.Enabled = True
        End If
        If chkPOSEditQty.Checked = True Then
            'FrmPointofSale.btnaddQty.Enabled = True
        Else
            'FrmPointofSale.btnaddQty.Enabled = True
        End If
        If chkPOSItemquickEdit.Checked = True Then
            'FrmPointofSale.BTNQucikItemEdit.Enabled = True
        Else
            'FrmPointofSale.BTNQucikItemEdit.Enabled = True
        End If
        If ChkPOS.Checked = True Then
            FrmPointofSale.Enabled = True
        Else
            FrmPointofSale.Enabled = True
        End If
        'Menu Bar TSBProduct, TSBStock, TSBStaff, TSBCategory, TSBPOS, TSBVoidItems, TSBDailySales, TSBStockIn, TSBPayments, TSBExpenses  
        If chkTSBProduct.Checked = True Then
            FrmMain.ProductToolStripButton2.Enabled = True
        Else
            FrmMain.ProductToolStripButton2.Enabled = True
        End If
        If chkTSBNewstock.Checked = True Then
            FrmMain.StockToolStripButton8.Enabled = True
        Else
            FrmMain.StockToolStripButton8.Enabled = True
        End If
        If chkTSBPOS.Checked = True Then
            FrmMain.POSToolStripButton5.Enabled = True
        Else
            FrmMain.POSToolStripButton5.Enabled = True
        End If
        If chkTSBVoidItems.Checked = True Then
            FrmMain.MaterialIssuedToolStripButton9.Enabled = True
        Else
            FrmMain.MaterialIssuedToolStripButton9.Enabled = True
        End If
        If chkTSBDailysales.Checked = True Then
            FrmMain.MaterialDeliveryNoteToolStripButton7.Enabled = True
        Else
            FrmMain.MaterialDeliveryNoteToolStripButton7.Enabled = False
        End If
        If chkTSBStockIn.Checked = True Then
            FrmMain.StockInToolStripButton1.Enabled = True
        Else
            FrmMain.StockInToolStripButton1.Enabled = True
        End If
        If chkTSBPayments.Checked = True Then
            FrmMain.DeliverytoschemesToolStripButton10.Enabled = True
        Else
            FrmMain.DeliverytoschemesToolStripButton10.Enabled = True
        End If
        If chkTSBExpenses.Checked = True Then
            FrmMain.ApprovalToolStripButton6.Enabled = True
        Else
            FrmMain.ApprovalToolStripButton6.Enabled = True
        End If
        'POS UpdatesPOSRecallsale, POSQckstkPurc, POSDeleteUncleredsale, POSUpdateRecall
        If chkPOSRecallsale.Checked = True Then
            'FrmPointofSale.BTNRecallTrans.Enabled = True
        Else
            'FrmPointofSale.BTNRecallTrans.Enabled = True
        End If
        If chkPOSQckstkpurch.Checked = True Then
            'FrmPointofSale.BTNqckpurchase.Enabled = True
        Else
            'FrmPointofSale.BTNqckpurchase.Enabled = True
        End If
        If chkPOSdeleteunclredsale.Checked = True Then
            'FrmPointofSale.BtnRecoverUnclearedsale.Enabled = True
        Else
            'FrmPointofSale.BtnRecoverUnclearedsale.Enabled = True
        End If
        If chkPOSsaverecallsale.Checked = True Then
            'FrmPointofSale.BtnUpdate.Enabled = True
        Else
            'FrmPointofSale.BtnUpdate.Enabled = True
        End If
        'Qckstockpurch, QckstkSave, QckStkUpdate,  MNBCompany, MNBUserLog, MNBPrivilages,  MNBCashsales
        If chkAllocateTools.Checked = True Then
            FrmMain.ToolsAllocationPurchaseToolStripMenuItem.Enabled = True
        Else
            FrmMain.ToolsAllocationPurchaseToolStripMenuItem.Enabled = True
        End If
        If chkReturnTools.Checked = True Then
            frmStockIn.QCKsaveToolStripButton5.Enabled = True
        Else
            frmStockIn.QCKsaveToolStripButton5.Enabled = True
        End If
        If chkupdateDelivery.Checked = True Then
            frmStockIn.QCKUpdateToolStripButton3.Enabled = True
        Else
            frmStockIn.QCKUpdateToolStripButton3.Enabled = True
        End If
        If chkMNUserlog.Checked = True Then
            FrmMain.UserLogToolStripButton2.Enabled = True
        Else
            FrmMain.UserLogToolStripButton2.Enabled = False
        End If
        If chkMNPrivilages.Checked = True Then
            FrmMain.PrivilagesToolStripButton3.Enabled = True
        Else
            FrmMain.PrivilagesToolStripButton3.Enabled = False
        End If
        If chkMNSales.Checked = True Then
            FrmMain.CreateToolsToolStripButton1.Enabled = True
        Else
            FrmMain.CreateToolsToolStripButton1.Enabled = False
        End If
        'Pos POSGridPrice, POSGridAmount
        If ChkPOSGridPrice.Checked = True Then
            FrmPointofSale.dgwIssueItems.Columns(2).ReadOnly = True
        Else
            FrmPointofSale.dgwIssueItems.Columns(2).ReadOnly = True
        End If
        If ChkPOSGridAmt.Checked = True Then
            FrmPointofSale.dgwIssueItems.Columns(4).ReadOnly = True
        Else
            FrmPointofSale.dgwIssueItems.Columns(4).ReadOnly = True
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE groupusers Set File = '" & chkFilemenu.CheckState & "', Product = '" & chckMaterialsmenu.CheckState & "', Suppliers = '" & chkInventory.CheckState & "', Customers = '" & chkCustomersMenu.CheckState & "', Finance = '" & chckSchemes.CheckState & "', Reports = '" & chckReports.CheckState & "', Administration = '" & ChkAdministration.CheckState & "', Tools = '" & chkTools.CheckState & "', CompanyDetails = '" & ChkCompanydetails.CheckState & "', ChangePassord = '" & chkchangepassword.CheckState & "', Logout = '" & chcklogout.CheckState & "', Addupdateproduct = '" & Chkaddupdateproduct.CheckState & "', Category = '" & chkCategory.CheckState & "', Subcategory = '" & chkSubcategory.CheckState & "', AdjustStock = '" & chkAdjuststock.CheckState & "', Productlookup = '" & chckSearchProduct.CheckState & "', ProductJournal = '" & chkProductJournal.CheckState & "', AddUpdateSupplier = '" & ChkaddReceiveMaterials.CheckState & "', Purchaseterms = '" & chkIssueMaterials.CheckState & "', ReceiveStock = '" & chkreceivestock.CheckState & "', ListofStockreceived = '" & chkreturnmaterials.CheckState & "', TransformStock = '" & chkreceivetools.CheckState & "', Addupdatecustomers = '" & chkaddupdatecutomers.CheckState & "', Listofcashsales = '" & chklistofcashsales.CheckState & "', Paymentmodes = '" & chkDeliveryApproval.CheckState & "', NewExpense = '" & chkSchemes.CheckState & "', ListofExpense = '" & chkConstituency.CheckState & "', Payexpense = '" & chkCounty.CheckState & "', Paysupplier = '" & chkReverseIssuance.CheckState & "',  Vatdetails = '" & chkVatdetails.CheckState & "', Dailysales = '" & chkdailysales.CheckState & "', productwisesales = '" & chkproductwisesales.CheckState & "',  Stockpurchases = '" & chkstockpurchases.CheckState & "', Productwisepurchases = '" & chkproductwisepurchases.CheckState & "', Expenses = '" & chkexpenses.CheckState & "', Payments = '" & chkpayments.CheckState & "', Addusers = '" & chkaddusers.CheckState & "' , Audittrail = '" & chkaudittrail.CheckState & "', Voiditemlist = '" & chkvoiditemaudit.CheckState & "', Useraccessrights = '" & chkUserAccessrights.CheckState & "', Backupdatabase = '" & chkBackupdatabase.CheckState & "', Systemsettings = '" & chkSystemsettings.CheckState & "', Changepassword = '" & chkChangepword.CheckState & "', CDSave = '" & chkCDsave.CheckState & "', CDUpdate = '" & chkCDupdate.CheckState & "', PSave = '" & chkPsave.CheckState & "', PUpdate = '" & ChkPUpdate.CheckState & "', CSave = '" & chkCTSave.CheckState & "', CUpdate = '" & ChkCTUpdate.CheckState & "', SCTSave = '" & ChkSCTSave.CheckState & "', SCTUpdate = '" & ChkSCTUpdate.CheckState & "', SPSave = '" & chkSPSave.CheckState & "', SPUpdate = '" & chkSPUpdate.CheckState & "', PTSave = '" & chkPTSave.CheckState & "',  PTUpdate = '" & chkUpdatematerialsreceived.CheckState & "', RSSave = '" & chkRSSave.CheckState & "', TSTransform = '" & ChkCancelMaterialReceipts.CheckState & "', TSSave = '" & chkTSSave.CheckState & "', CUSSave = '" & chkCUSSave.CheckState & "', CUSUpdate = '" & chkCUSUpdate.CheckState & "', LCSGetData = '" & ChkLCSGetdata.CheckState & "', LCSExportToExcel = '" & ChkLCSExporttoExcel.CheckState & "', PYMSave = '" & ChkCreateToolsSave.CheckState & "' , PYMUpdate = '" & ChkCreateEmpRoles.CheckState & "', NWEXSave = '" & ChkCreateStaff.CheckState & "',  NWEXUpdate = '" & ChkCreateSuppliers.CheckState & "', LOESave = '" & ChkLOESave.CheckState & "', LOEUpdate = '" & ChkLOEUpdate.CheckState & "', PYESave = '" & ChkPYEsave.CheckState & "', PYSSave = '" & ChkPYSSave.CheckState & "', AUSave = '" & ChkAUSave.CheckState & "', AUUpdate = '" & ChkAUpdate.CheckState & "', AUDelete = '" & chkAUDelete.CheckState & "', ATDelete = '" & ChkATDelete.CheckState & "', VIADelete = '" & chkVIADelete.CheckState & "', UACSave = '" & ChkUACSave.CheckState & "', UACUpdate = '" & chkUACUpdate.CheckState & "', UACDelete = '" & ChkUACDelete.CheckState & "', FVoid = '" & ChkPOSVoid.CheckState & "', FTenderAmt = '" & chkPOSTenderAmt.CheckState & "', FPOS2 = '" & chkPOSopenPOS2.CheckState & "', FPrice = '" & chkPOSEditPrice.CheckState & "', FItemslookup = '" & chkPOSItemsLookup.CheckState & "', FEditQty = '" & chkPOSEditQty.CheckState & "', FItemQuickedit = '" & chkPOSItemquickEdit.CheckState & "', POSForm = '" & ChkPOS.CheckState & "', TSBProduct = '" & chkTSBProduct.CheckState & "', TSBStock = '" & chkTSBNewstock.CheckState & "', TSBPOS = '" & chkTSBPOS.CheckState & "', TSBVoidItems = '" & chkTSBVoidItems.CheckState & "', TSBDailySales = '" & chkTSBDailysales.CheckState & "', TSBStockIn = '" & chkTSBStockIn.CheckState & "', TSBPayments = '" & chkTSBPayments.CheckState & "', TSBExpenses = '" & chkTSBExpenses.CheckState & "', POSRecallsale = '" & chkPOSRecallsale.CheckState & "', POSQckstkPurc = '" & chkPOSQckstkpurch.CheckState & "', POSDeleteUncleredsale = '" & chkPOSdeleteunclredsale.CheckState & "', POSUpdateRecall = '" & chkPOSsaverecallsale.CheckState & "', Qckstockpurch = '" & chkAllocateTools.CheckState & "', QckstkSave = '" & chkReturnTools.CheckState & "', QckStkUpdate = '" & chkupdateDelivery.CheckState & "', MNBUserLog = '" & chkMNUserlog.CheckState & "', MNBPrivilages = '" & chkMNPrivilages.CheckState & "', MNBCashsales = '" & chkMNSales.CheckState & "', POSGridPrice = '" & ChkPOSGridPrice.CheckState & "', POSGridAmount = '" & ChkPOSGridAmt.CheckState & "' Where UserGroupName = '" & txtAdmin.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
            MysqlConn.Close()
        End Try
    End Sub
    Private Sub PopulateUsers()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT username From staff order by username"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            CboUsers.Items.Clear()
            Do While dr.Read = True
                CboUsers.Items.Add(dr("username"))
            Loop
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub UpdateAdministratorAlways()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection
         MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE groupusers Set File = '" & txtValueOne.Text & "', Product = '" & txtValueOne.Text & "', Suppliers = '" & txtValueOne.Text & "', Customers = '" & txtValueOne.Text & "', Finance = '" & txtValueOne.Text & "', Reports = '" & txtValueOne.Text & "', Administration = '" & txtValueOne.Text & "', Tools = '" & txtValueOne.Text & "', CompanyDetails = '" & txtValueOne.Text & "', ChangePassord = '" & txtValueOne.Text & "', Logout = '" & txtValueOne.Text & "', Addupdateproduct = '" & txtValueOne.Text & "', Category = '" & txtValueOne.Text & "', Subcategory = '" & txtValueOne.Text & "', AdjustStock = '" & txtValueOne.Text & "', Productlookup = '" & txtValueOne.Text & "', ProductJournal = '" & txtValueOne.Text & "', AddUpdateSupplier = '" & txtValueOne.Text & "', Purchaseterms = '" & txtValueOne.Text & "', ReceiveStock = '" & txtValueOne.Text & "', ListofStockreceived = '" & txtValueOne.Text & "', TransformStock = '" & txtValueOne.Text & "', Addupdatecustomers = '" & txtValueOne.Text & "', Listofcashsales = '" & txtValueOne.Text & "', Paymentmodes = '" & txtValueOne.Text & "', NewExpense = '" & txtValueOne.Text & "', ListofExpense = '" & txtValueOne.Text & "', Payexpense = '" & txtValueOne.Text & "', Paysupplier = '" & txtValueOne.Text & "',  Vatdetails = '" & txtValueOne.Text & "', Dailysales = '" & txtValueOne.Text & "', productwisesales = '" & txtValueOne.Text & "',  Stockpurchases = '" & txtValueOne.Text & "', Productwisepurchases = '" & txtValueOne.Text & "', Expenses = '" & txtValueOne.Text & "', Payments = '" & txtValueOne.Text & "', Addusers = '" & txtValueOne.Text & "' , Audittrail = '" & txtValueOne.Text & "', Voiditemlist = '" & txtValueOne.Text & "', Useraccessrights = '" & txtValueOne.Text & "', Backupdatabase = '" & txtValueOne.Text & "', Systemsettings = '" & txtValueOne.Text & "', Changepassword = '" & txtValueOne.Text & "', CDSave = '" & txtValueOne.Text & "', CDUpdate = '" & txtValueOne.Text & "', PSave = '" & txtValueOne.Text & "', PUpdate = '" & txtValueOne.Text & "', CSave = '" & txtValueOne.Text & "', CUpdate = '" & txtValueOne.Text & "', SCTSave = '" & txtValueOne.Text & "', SCTUpdate = '" & txtValueOne.Text & "', SPSave = '" & txtValueOne.Text & "', SPUpdate = '" & txtValueOne.Text & "', PTSave = '" & txtValueOne.Text & "',  PTUpdate = '" & txtValueOne.Text & "', RSSave = '" & txtValueOne.Text & "', TSTransform = '" & txtValueOne.Text & "', TSSave = '" & txtValueOne.Text & "', CUSSave = '" & txtValueOne.Text & "', CUSUpdate = '" & txtValueOne.Text & "', LCSGetData = '" & txtValueOne.Text & "', LCSExportToExcel = '" & txtValueOne.Text & "', PYMSave = '" & txtValueOne.Text & "' , PYMUpdate = '" & txtValueOne.Text & "', NWEXSave = '" & txtValueOne.Text & "',  NWEXUpdate = '" & txtValueOne.Text & "', LOESave = '" & txtValueOne.Text & "', LOEUpdate = '" & txtValueOne.Text & "', PYESave = '" & txtValueOne.Text & "', PYSSave = '" & txtValueOne.Text & "', AUSave = '" & txtValueOne.Text & "', AUUpdate = '" & txtValueOne.Text & "', AUDelete = '" & txtValueOne.Text & "', ATDelete = '" & txtValueOne.Text & "', VIADelete = '" & txtValueOne.Text & "', UACSave = '" & txtValueOne.Text & "', UACUpdate = '" & txtValueOne.Text & "', UACDelete = '" & txtValueOne.Text & "', FVoid = '" & txtValueOne.Text & "', FTenderAmt = '" & txtValueOne.Text & "', FPOS2 = '" & txtValueOne.Text & "', FPrice = '" & txtValueOne.Text & "', FItemslookup = '" & txtValueOne.Text & "', FEditQty = '" & txtValueOne.Text & "', FItemQuickedit = '" & txtValueOne.Text & "', POSForm = '" & txtValueOne.Text & "', TSBProduct = '" & txtValueOne.Text & "', TSBStock = '" & txtValueOne.Text & "', TSBPOS = '" & txtValueOne.Text & "', TSBVoidItems = '" & txtValueOne.Text & "', TSBDailySales = '" & txtValueOne.Text & "', TSBStockIn = '" & txtValueOne.Text & "', TSBPayments = '" & txtValueOne.Text & "', TSBExpenses = '" & txtValueOne.Text & "', POSRecallsale = '" & txtValueOne.Text & "', POSQckstkPurc = '" & txtValueOne.Text & "', POSDeleteUncleredsale = '" & txtValueOne.Text & "', POSUpdateRecall = '" & txtValueOne.Text & "', Qckstockpurch = '" & txtValueOne.Text & "', QckstkSave = '" & txtValueOne.Text & "', QckStkUpdate = '" & txtValueOne.Text & "', MNBUserLog = '" & txtValueOne.Text & "', MNBPrivilages = '" & txtValueOne.Text & "', MNBCashsales = '" & txtValueOne.Text & "', POSGridPrice = '" & txtValueOne.Text & "', POSGridAmount = '" & txtValueOne.Text & "', Invoicing = '" & txtValueOne.Text & "', InvoicingItems = '" & txtValueOne.Text & "', Createstatement = '" & txtValueOne.Text & "', Statementapproval = '" & txtValueOne.Text & "', Updatestatement = '" & txtValueOne.Text & "', ListofInvoices = '" & txtValueOne.Text & "', Printstatement = '" & txtValueOne.Text & "', MnuTransport = '" & txtValueOne.Text & "', Warehouse = '" & txtValueOne.Text & "', Transporter = '" & txtValueOne.Text & "', Transportregister = '" & txtValueOne.Text & "', UpdateTransRegister = '" & txtValueOne.Text & "', MaterialIssuance = '" & txtValueOne.Text & "', ApproveDelivery = '" & txtValueOne.Text & "', UpdateDelivery = '" & txtValueOne.Text & "', ReturnMaterials = '" & txtValueOne.Text & "', ReceiveMaterials = '" & txtValueOne.Text & "', UpdateMatReceipt = '" & txtValueOne.Text & "', CancelMatReceipt = '" & txtValueOne.Text & "', mnuMeters = '" & txtValueOne.Text & "', Receivemeters = '" & txtValueOne.Text & "', IssueMeters = '" & txtValueOne.Text & "', UpdateMeters = '" & txtValueOne.Text & "', MeterBoQ = '" & txtValueOne.Text & "', TechBoQ = '" & txtValueOne.Text & "' Where UserGroupName = '" & txtAdmin.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader()
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Sub frmUserRights_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateAdministratorAlways()
        'CboUsers.Text = FrmMain.tsslUser.Text
        txtAdmin.Text = "administrator"
        txtValueOne.Text = "1"

        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        'MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        Dim dr As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * From groupusers Where UserGroupName = '" & CboUsers.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        PopulateUsers()

    End Sub
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UACSaveToolStripButton5.Click
        menupermission()
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        getuserpermission()
        updateadmin()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UACUpdateToolStripButton3.Click
        updatepermissions()
        UpdateAdministratorAlways()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        getuserpermission()
        updatepermissions()
        UpdateAdministratorAlways()
        Me.Close()
    End Sub


End Class



