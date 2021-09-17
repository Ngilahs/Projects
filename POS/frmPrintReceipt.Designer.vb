<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintReceipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()
> Private Sub InitializeComponent()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BTNPrintPreview = New System.Windows.Forms.Button()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(52, 35)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(156, 34)
        Me.BtnPrint.TabIndex = 0
        Me.BtnPrint.Text = "Print"
        '
        'BTNPrintPreview
        '
        Me.BTNPrintPreview.Location = New System.Drawing.Point(51, 712)
        Me.BTNPrintPreview.Name = "BTNPrintPreview"
        Me.BTNPrintPreview.Size = New System.Drawing.Size(129, 29)
        Me.BTNPrintPreview.TabIndex = 3
        Me.BTNPrintPreview.Text = "Print Preview"
        '
        'PrintDocument3
        '
        '
        'frmPrintReceipt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(248, 753)
        Me.Controls.Add(Me.BTNPrintPreview)
        Me.MaximizeBox = False
        Me.Name = "frmPrintReceipt"
        Me.Text = "Print Receipt"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BTNPrintPreview As System.Windows.Forms.Button
    Friend WithEvents PrintDocument3 As System.Drawing.Printing.PrintDocument
End Class
