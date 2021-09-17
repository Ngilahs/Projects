<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVATSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVATSetting))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnSaveVAT = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtVATRate = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtVATCode = New System.Windows.Forms.TextBox()
        Me.txtVATID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmdSearchItems = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.BtnSaveVAT)
        Me.GroupBox2.Controls.Add(Me.BtnUpdate)
        Me.GroupBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.GroupBox2.Location = New System.Drawing.Point(13, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 50)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.UseWaitCursor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(94, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 21)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "&Cancel"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.UseWaitCursor = True
        '
        'BtnSaveVAT
        '
        Me.BtnSaveVAT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnSaveVAT.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.BtnSaveVAT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSaveVAT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveVAT.Image = CType(resources.GetObject("BtnSaveVAT.Image"), System.Drawing.Image)
        Me.BtnSaveVAT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSaveVAT.Location = New System.Drawing.Point(6, 17)
        Me.BtnSaveVAT.Name = "BtnSaveVAT"
        Me.BtnSaveVAT.Size = New System.Drawing.Size(72, 23)
        Me.BtnSaveVAT.TabIndex = 0
        Me.BtnSaveVAT.Text = "&Save "
        Me.BtnSaveVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSaveVAT.UseVisualStyleBackColor = False
        Me.BtnSaveVAT.UseWaitCursor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnUpdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Image = CType(resources.GetObject("BtnUpdate.Image"), System.Drawing.Image)
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(176, 17)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(80, 23)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = False
        Me.BtnUpdate.UseWaitCursor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtVATRate)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtVATCode)
        Me.GroupBox3.Controls.Add(Me.txtVATID)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.GroupBox3.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(293, 158)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "VAT Details"
        Me.GroupBox3.UseWaitCursor = True
        '
        'txtVATRate
        '
        Me.txtVATRate.Location = New System.Drawing.Point(75, 19)
        Me.txtVATRate.Name = "txtVATRate"
        Me.txtVATRate.Size = New System.Drawing.Size(204, 20)
        Me.txtVATRate.TabIndex = 5
        Me.txtVATRate.UseWaitCursor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = " VAT Rate:"
        Me.Label20.UseWaitCursor = True
        '
        'txtVATCode
        '
        Me.txtVATCode.Location = New System.Drawing.Point(75, 47)
        Me.txtVATCode.Name = "txtVATCode"
        Me.txtVATCode.Size = New System.Drawing.Size(204, 20)
        Me.txtVATCode.TabIndex = 1
        Me.txtVATCode.UseWaitCursor = True
        '
        'txtVATID
        '
        Me.txtVATID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtVATID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtVATID.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.txtVATID.Location = New System.Drawing.Point(246, 19)
        Me.txtVATID.Name = "txtVATID"
        Me.txtVATID.Size = New System.Drawing.Size(33, 20)
        Me.txtVATID.TabIndex = 3
        Me.txtVATID.UseWaitCursor = True
        Me.txtVATID.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "VAT Code:"
        Me.Label3.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(319, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Select Vat No:"
        Me.Label5.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(168, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 226
        Me.Label2.Text = "VAT Settings"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(-1, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(419, 38)
        Me.TextBox1.TabIndex = 225
        '
        'cmdSearchItems
        '
        Me.cmdSearchItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmdSearchItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmdSearchItems.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSearchItems.FormattingEnabled = True
        Me.cmdSearchItems.Location = New System.Drawing.Point(322, 70)
        Me.cmdSearchItems.Name = "cmdSearchItems"
        Me.cmdSearchItems.Size = New System.Drawing.Size(73, 21)
        Me.cmdSearchItems.TabIndex = 256
        '
        'frmVATSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 228)
        Me.Controls.Add(Me.cmdSearchItems)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.KeyPreview = True
        Me.Name = "frmVATSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnSaveVAT As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVATRate As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtVATID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVATCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmdSearchItems As ComboBox
End Class
