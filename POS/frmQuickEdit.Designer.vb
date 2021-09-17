<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuickEdit
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQBarcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQRetailPrice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtQDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbcode = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQQty = New System.Windows.Forms.TextBox()
        Me.TxtQBarcode2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.LBLProdNo = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 40)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 37)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Quick Product Edit"
        '
        'txtQBarcode
        '
        Me.txtQBarcode.BackColor = System.Drawing.Color.White
        Me.txtQBarcode.Location = New System.Drawing.Point(73, 13)
        Me.txtQBarcode.Name = "txtQBarcode"
        Me.txtQBarcode.Size = New System.Drawing.Size(181, 20)
        Me.txtQBarcode.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Barcode 1 :"
        '
        'txtQRetailPrice
        '
        Me.txtQRetailPrice.Location = New System.Drawing.Point(78, 165)
        Me.txtQRetailPrice.Name = "txtQRetailPrice"
        Me.txtQRetailPrice.Size = New System.Drawing.Size(176, 20)
        Me.txtQRetailPrice.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Selling Price:"
        '
        'txtQDescription
        '
        Me.txtQDescription.BackColor = System.Drawing.Color.White
        Me.txtQDescription.Location = New System.Drawing.Point(73, 65)
        Me.txtQDescription.Name = "txtQDescription"
        Me.txtQDescription.Size = New System.Drawing.Size(181, 20)
        Me.txtQDescription.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Description :"
        '
        'txtQUnitPrice
        '
        Me.txtQUnitPrice.BackColor = System.Drawing.Color.White
        Me.txtQUnitPrice.Location = New System.Drawing.Point(78, 133)
        Me.txtQUnitPrice.Name = "txtQUnitPrice"
        Me.txtQUnitPrice.Size = New System.Drawing.Size(176, 20)
        Me.txtQUnitPrice.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Buying Price:"
        '
        'txtbcode
        '
        Me.txtbcode.BackColor = System.Drawing.Color.White
        Me.txtbcode.Location = New System.Drawing.Point(76, 48)
        Me.txtbcode.Name = "txtbcode"
        Me.txtbcode.Size = New System.Drawing.Size(106, 20)
        Me.txtbcode.TabIndex = 24
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(2, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Enter Barcode:"
        Me.Label16.UseWaitCursor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtQQty)
        Me.GroupBox1.Controls.Add(Me.TxtQBarcode2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtQUnitPrice)
        Me.GroupBox1.Controls.Add(Me.txtQBarcode)
        Me.GroupBox1.Controls.Add(Me.txtQDescription)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtQRetailPrice)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 191)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Quantity:"
        '
        'txtQQty
        '
        Me.txtQQty.BackColor = System.Drawing.Color.White
        Me.txtQQty.Location = New System.Drawing.Point(73, 98)
        Me.txtQQty.Name = "txtQQty"
        Me.txtQQty.Size = New System.Drawing.Size(181, 20)
        Me.txtQQty.TabIndex = 26
        '
        'TxtQBarcode2
        '
        Me.TxtQBarcode2.BackColor = System.Drawing.Color.White
        Me.TxtQBarcode2.Location = New System.Drawing.Point(73, 39)
        Me.TxtQBarcode2.Name = "TxtQBarcode2"
        Me.TxtQBarcode2.Size = New System.Drawing.Size(181, 20)
        Me.TxtQBarcode2.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Barcode 2 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(185, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Product No:"
        Me.Label5.UseWaitCursor = True
        '
        'BTNSave
        '
        Me.BTNSave.BackColor = System.Drawing.Color.DarkOrange
        Me.BTNSave.Location = New System.Drawing.Point(61, 271)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(89, 32)
        Me.BTNSave.TabIndex = 28
        Me.BTNSave.Text = "Save"
        Me.BTNSave.UseVisualStyleBackColor = False
        '
        'LBLProdNo
        '
        Me.LBLProdNo.AutoSize = True
        Me.LBLProdNo.Location = New System.Drawing.Point(252, 54)
        Me.LBLProdNo.Name = "LBLProdNo"
        Me.LBLProdNo.Size = New System.Drawing.Size(42, 13)
        Me.LBLProdNo.TabIndex = 29
        Me.LBLProdNo.Text = "#####"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnClose.Location = New System.Drawing.Point(174, 271)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(89, 32)
        Me.BtnClose.TabIndex = 30
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'frmQuickEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 303)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LBLProdNo)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbcode)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmQuickEdit"
        Me.Text = "Product Quick Edit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQRetailPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtQDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtbcode As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtQBarcode2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BTNSave As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQQty As System.Windows.Forms.TextBox
    Friend WithEvents LBLProdNo As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
