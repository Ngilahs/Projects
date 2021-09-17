<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillingItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillingItems))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSubCat = New System.Windows.Forms.Button()
        Me.txtSubcategory = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.subcatId = New System.Windows.Forms.TextBox()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.txtCategoryName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCategoryID = New System.Windows.Forms.TextBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtItemUnitofIssue = New System.Windows.Forms.TextBox()
        Me.lblMinimumStock = New System.Windows.Forms.Label()
        Me.txtStocksOnHand = New System.Windows.Forms.Label()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblItemNo = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.txtItemmNo = New System.Windows.Forms.TextBox()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQtyperUoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategoryID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCategoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubCatID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubCatName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(3, -1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(932, 40)
        Me.TextBox1.TabIndex = 167
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(434, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 221
        Me.Label7.Text = "BOQ Items"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSubCat)
        Me.GroupBox1.Controls.Add(Me.txtSubcategory)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.subcatId)
        Me.GroupBox1.Controls.Add(Me.btnCategory)
        Me.GroupBox1.Controls.Add(Me.txtCategoryName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCategoryID)
        Me.GroupBox1.Controls.Add(Me.txtUnits)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtItemUnitofIssue)
        Me.GroupBox1.Controls.Add(Me.lblMinimumStock)
        Me.GroupBox1.Controls.Add(Me.txtStocksOnHand)
        Me.GroupBox1.Controls.Add(Me.txtItemDescription)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblItemNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 355)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 192)
        Me.GroupBox1.TabIndex = 222
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BOQ Details"
        '
        'btnSubCat
        '
        Me.btnSubCat.BackColor = System.Drawing.Color.DarkGray
        Me.btnSubCat.BackgroundImage = CType(resources.GetObject("btnSubCat.BackgroundImage"), System.Drawing.Image)
        Me.btnSubCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSubCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubCat.Location = New System.Drawing.Point(453, 162)
        Me.btnSubCat.Name = "btnSubCat"
        Me.btnSubCat.Size = New System.Drawing.Size(22, 17)
        Me.btnSubCat.TabIndex = 492
        Me.btnSubCat.UseVisualStyleBackColor = False
        '
        'txtSubcategory
        '
        Me.txtSubcategory.Enabled = False
        Me.txtSubcategory.Location = New System.Drawing.Point(101, 159)
        Me.txtSubcategory.Name = "txtSubcategory"
        Me.txtSubcategory.Size = New System.Drawing.Size(336, 22)
        Me.txtSubcategory.TabIndex = 495
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 163)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 494
        Me.Label3.Text = "Sub-Category:"
        '
        'subcatId
        '
        Me.subcatId.Enabled = False
        Me.subcatId.Location = New System.Drawing.Point(418, 159)
        Me.subcatId.Name = "subcatId"
        Me.subcatId.Size = New System.Drawing.Size(19, 22)
        Me.subcatId.TabIndex = 493
        '
        'btnCategory
        '
        Me.btnCategory.BackColor = System.Drawing.Color.DarkGray
        Me.btnCategory.BackgroundImage = CType(resources.GetObject("btnCategory.BackgroundImage"), System.Drawing.Image)
        Me.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCategory.Location = New System.Drawing.Point(452, 132)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(22, 17)
        Me.btnCategory.TabIndex = 228
        Me.btnCategory.UseVisualStyleBackColor = False
        '
        'txtCategoryName
        '
        Me.txtCategoryName.Enabled = False
        Me.txtCategoryName.Location = New System.Drawing.Point(101, 130)
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Size = New System.Drawing.Size(336, 22)
        Me.txtCategoryName.TabIndex = 491
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 134)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 490
        Me.Label1.Text = "Category:"
        '
        'txtCategoryID
        '
        Me.txtCategoryID.Enabled = False
        Me.txtCategoryID.Location = New System.Drawing.Point(418, 130)
        Me.txtCategoryID.Name = "txtCategoryID"
        Me.txtCategoryID.Size = New System.Drawing.Size(19, 22)
        Me.txtCategoryID.TabIndex = 228
        '
        'txtUnits
        '
        Me.txtUnits.BackColor = System.Drawing.Color.White
        Me.txtUnits.Location = New System.Drawing.Point(101, 102)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(374, 22)
        Me.txtUnits.TabIndex = 488
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 487
        Me.Label6.Text = "Unit Rate:"
        '
        'txtItemUnitofIssue
        '
        Me.txtItemUnitofIssue.Location = New System.Drawing.Point(101, 71)
        Me.txtItemUnitofIssue.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.txtItemUnitofIssue.MaxLength = 13
        Me.txtItemUnitofIssue.Name = "txtItemUnitofIssue"
        Me.txtItemUnitofIssue.Size = New System.Drawing.Size(374, 22)
        Me.txtItemUnitofIssue.TabIndex = 466
        '
        'lblMinimumStock
        '
        Me.lblMinimumStock.AutoSize = True
        Me.lblMinimumStock.BackColor = System.Drawing.Color.Transparent
        Me.lblMinimumStock.ForeColor = System.Drawing.Color.Black
        Me.lblMinimumStock.Location = New System.Drawing.Point(6, 71)
        Me.lblMinimumStock.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.lblMinimumStock.Name = "lblMinimumStock"
        Me.lblMinimumStock.Size = New System.Drawing.Size(35, 13)
        Me.lblMinimumStock.TabIndex = 478
        Me.lblMinimumStock.Text = "UoM:"
        '
        'txtStocksOnHand
        '
        Me.txtStocksOnHand.AutoSize = True
        Me.txtStocksOnHand.Location = New System.Drawing.Point(449, 130)
        Me.txtStocksOnHand.Name = "txtStocksOnHand"
        Me.txtStocksOnHand.Size = New System.Drawing.Size(0, 13)
        Me.txtStocksOnHand.TabIndex = 11
        '
        'txtItemDescription
        '
        Me.txtItemDescription.BackColor = System.Drawing.Color.White
        Me.txtItemDescription.Location = New System.Drawing.Point(101, 17)
        Me.txtItemDescription.Multiline = True
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(374, 51)
        Me.txtItemDescription.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "BOQ Description :"
        '
        'lblItemNo
        '
        Me.lblItemNo.BackColor = System.Drawing.Color.White
        Me.lblItemNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblItemNo.Location = New System.Drawing.Point(270, 20)
        Me.lblItemNo.Name = "lblItemNo"
        Me.lblItemNo.Size = New System.Drawing.Size(51, 22)
        Me.lblItemNo.TabIndex = 2
        Me.lblItemNo.Text = " "
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.colQtyperUoM, Me.colUnits, Me.colCategoryID, Me.ColCategoryName, Me.colSubCatID, Me.colSubCatName})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(3, 45)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(932, 304)
        Me.dgw.TabIndex = 224
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnDelete)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnNew)
        Me.Panel3.Location = New System.Drawing.Point(824, 363)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(111, 174)
        Me.Panel3.TabIndex = 225
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(13, 103)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(82, 28)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(13, 134)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 28)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(13, 72)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(82, 28)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(13, 41)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 28)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(13, 10)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(82, 28)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'txtItemNo
        '
        Me.txtItemNo.Enabled = False
        Me.txtItemNo.Location = New System.Drawing.Point(646, 363)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(110, 20)
        Me.txtItemNo.TabIndex = 226
        Me.txtItemNo.Visible = False
        '
        'txtItemmNo
        '
        Me.txtItemmNo.Enabled = False
        Me.txtItemmNo.Location = New System.Drawing.Point(646, 389)
        Me.txtItemmNo.Name = "txtItemmNo"
        Me.txtItemmNo.Size = New System.Drawing.Size(110, 20)
        Me.txtItemmNo.TabIndex = 227
        Me.txtItemmNo.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "BOQ No"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "BOQ Description"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 500
        '
        'colQtyperUoM
        '
        Me.colQtyperUoM.HeaderText = "UoM"
        Me.colQtyperUoM.Name = "colQtyperUoM"
        Me.colQtyperUoM.ReadOnly = True
        Me.colQtyperUoM.Width = 50
        '
        'colUnits
        '
        Me.colUnits.HeaderText = "Unit Rate"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.ReadOnly = True
        '
        'colCategoryID
        '
        Me.colCategoryID.HeaderText = "CateID"
        Me.colCategoryID.Name = "colCategoryID"
        Me.colCategoryID.ReadOnly = True
        Me.colCategoryID.Visible = False
        Me.colCategoryID.Width = 75
        '
        'ColCategoryName
        '
        Me.ColCategoryName.HeaderText = "Cat Name"
        Me.ColCategoryName.Name = "ColCategoryName"
        Me.ColCategoryName.ReadOnly = True
        Me.ColCategoryName.Width = 75
        '
        'colSubCatID
        '
        Me.colSubCatID.HeaderText = "Sub-CatID"
        Me.colSubCatID.Name = "colSubCatID"
        Me.colSubCatID.ReadOnly = True
        Me.colSubCatID.Visible = False
        Me.colSubCatID.Width = 75
        '
        'colSubCatName
        '
        Me.colSubCatName.HeaderText = "Sub-Cat "
        Me.colSubCatName.Name = "colSubCatName"
        Me.colSubCatName.ReadOnly = True
        Me.colSubCatName.Width = 75
        '
        'frmBillingItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 549)
        Me.Controls.Add(Me.txtItemmNo)
        Me.Controls.Add(Me.txtItemNo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmBillingItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Label6 As Label
    Private WithEvents txtItemUnitofIssue As TextBox
    Private WithEvents lblMinimumStock As Label
    Friend WithEvents txtStocksOnHand As Label
    Friend WithEvents txtItemDescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblItemNo As Label
    Friend WithEvents dgw As DataGridView
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents txtItemNo As TextBox
    Friend WithEvents txtItemmNo As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents txtCategoryID As TextBox
    Friend WithEvents btnCategory As Button
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents btnSubCat As Button
    Friend WithEvents txtSubcategory As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents subcatId As TextBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colQtyperUoM As DataGridViewTextBoxColumn
    Friend WithEvents colUnits As DataGridViewTextBoxColumn
    Friend WithEvents colCategoryID As DataGridViewTextBoxColumn
    Friend WithEvents ColCategoryName As DataGridViewTextBoxColumn
    Friend WithEvents colSubCatID As DataGridViewTextBoxColumn
    Friend WithEvents colSubCatName As DataGridViewTextBoxColumn
End Class
