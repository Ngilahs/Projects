<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScheme))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.lblSchemeRefNo = New System.Windows.Forms.TextBox()
        Me.txtNoofCust = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSubstNo = New System.Windows.Forms.TextBox()
        Me.cboConstituency = New System.Windows.Forms.ComboBox()
        Me.cboCounty = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSchemeName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtConstituencyID = New System.Windows.Forms.TextBox()
        Me.txtSchemeNo = New System.Windows.Forms.TextBox()
        Me.txtCountyID = New System.Windows.Forms.TextBox()
        Me.txtsearchsname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CUSSaveToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.CUSUpdateToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DeleteToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 34)
        Me.Panel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(426, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 221
        Me.Label1.Text = "Schemes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.TextBox23)
        Me.GroupBox1.Controls.Add(Me.lblSchemeRefNo)
        Me.GroupBox1.Controls.Add(Me.txtNoofCust)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtSubstNo)
        Me.GroupBox1.Controls.Add(Me.cboConstituency)
        Me.GroupBox1.Controls.Add(Me.cboCounty)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSchemeName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtConstituencyID)
        Me.GroupBox1.Controls.Add(Me.txtSchemeNo)
        Me.GroupBox1.Controls.Add(Me.txtCountyID)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(947, 78)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scheme Information"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(653, 52)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(43, 15)
        Me.Label42.TabIndex = 94
        Me.Label42.Text = "TX No:"
        '
        'TextBox23
        '
        Me.TextBox23.BackColor = System.Drawing.Color.White
        Me.TextBox23.Location = New System.Drawing.Point(1056, 54)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(86, 23)
        Me.TextBox23.TabIndex = 76
        '
        'lblSchemeRefNo
        '
        Me.lblSchemeRefNo.BackColor = System.Drawing.Color.White
        Me.lblSchemeRefNo.Location = New System.Drawing.Point(96, 19)
        Me.lblSchemeRefNo.Name = "lblSchemeRefNo"
        Me.lblSchemeRefNo.Size = New System.Drawing.Size(235, 23)
        Me.lblSchemeRefNo.TabIndex = 37
        '
        'txtNoofCust
        '
        Me.txtNoofCust.BackColor = System.Drawing.Color.White
        Me.txtNoofCust.Location = New System.Drawing.Point(759, 14)
        Me.txtNoofCust.Name = "txtNoofCust"
        Me.txtNoofCust.Size = New System.Drawing.Size(176, 23)
        Me.txtNoofCust.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(653, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 15)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "No of Customers:"
        '
        'txtSubstNo
        '
        Me.txtSubstNo.BackColor = System.Drawing.Color.White
        Me.txtSubstNo.Location = New System.Drawing.Point(759, 46)
        Me.txtSubstNo.Name = "txtSubstNo"
        Me.txtSubstNo.Size = New System.Drawing.Size(176, 23)
        Me.txtSubstNo.TabIndex = 26
        '
        'cboConstituency
        '
        Me.cboConstituency.FormattingEnabled = True
        Me.cboConstituency.Location = New System.Drawing.Point(423, 49)
        Me.cboConstituency.Name = "cboConstituency"
        Me.cboConstituency.Size = New System.Drawing.Size(177, 23)
        Me.cboConstituency.TabIndex = 23
        '
        'cboCounty
        '
        Me.cboCounty.FormattingEnabled = True
        Me.cboCounty.Location = New System.Drawing.Point(423, 19)
        Me.cboCounty.Name = "cboCounty"
        Me.cboCounty.Size = New System.Drawing.Size(177, 23)
        Me.cboCounty.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(337, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Constituency:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "County :"
        '
        'txtSchemeName
        '
        Me.txtSchemeName.BackColor = System.Drawing.Color.White
        Me.txtSchemeName.Location = New System.Drawing.Point(96, 46)
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(235, 23)
        Me.txtSchemeName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Scheme Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Scheme Ref No:"
        '
        'txtConstituencyID
        '
        Me.txtConstituencyID.Location = New System.Drawing.Point(478, 49)
        Me.txtConstituencyID.Name = "txtConstituencyID"
        Me.txtConstituencyID.Size = New System.Drawing.Size(20, 23)
        Me.txtConstituencyID.TabIndex = 96
        Me.txtConstituencyID.Visible = False
        '
        'txtSchemeNo
        '
        Me.txtSchemeNo.Location = New System.Drawing.Point(227, 19)
        Me.txtSchemeNo.Name = "txtSchemeNo"
        Me.txtSchemeNo.Size = New System.Drawing.Size(20, 23)
        Me.txtSchemeNo.TabIndex = 97
        Me.txtSchemeNo.Visible = False
        '
        'txtCountyID
        '
        Me.txtCountyID.Location = New System.Drawing.Point(487, 19)
        Me.txtCountyID.Name = "txtCountyID"
        Me.txtCountyID.Size = New System.Drawing.Size(20, 23)
        Me.txtCountyID.TabIndex = 95
        Me.txtCountyID.Visible = False
        '
        'txtsearchsname
        '
        Me.txtsearchsname.BackColor = System.Drawing.Color.White
        Me.txtsearchsname.Location = New System.Drawing.Point(225, 13)
        Me.txtsearchsname.Name = "txtsearchsname"
        Me.txtsearchsname.Size = New System.Drawing.Size(320, 20)
        Me.txtsearchsname.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(208, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Scheme Name / Z-Ref No:/TX No :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightGray
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CUSSaveToolStripButton5, Me.ToolStripLabel1, Me.ToolStripButton4, Me.CUSUpdateToolStripButton3, Me.ToolStripButton1, Me.DeleteToolStripLabel})
        Me.ToolStrip1.Location = New System.Drawing.Point(344, 517)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(320, 35)
        Me.ToolStrip1.TabIndex = 31
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CUSSaveToolStripButton5
        '
        Me.CUSSaveToolStripButton5.Image = CType(resources.GetObject("CUSSaveToolStripButton5.Image"), System.Drawing.Image)
        Me.CUSSaveToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CUSSaveToolStripButton5.Name = "CUSSaveToolStripButton5"
        Me.CUSSaveToolStripButton5.Size = New System.Drawing.Size(51, 32)
        Me.CUSSaveToolStripButton5.Text = "Save"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 32)
        Me.ToolStripLabel1.Text = "   "
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(65, 40)
        Me.ToolStripButton4.Text = "&Cancel"
        '
        'CUSUpdateToolStripButton3
        '
        Me.CUSUpdateToolStripButton3.AutoSize = False
        Me.CUSUpdateToolStripButton3.Image = CType(resources.GetObject("CUSUpdateToolStripButton3.Image"), System.Drawing.Image)
        Me.CUSUpdateToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CUSUpdateToolStripButton3.Name = "CUSUpdateToolStripButton3"
        Me.CUSUpdateToolStripButton3.Size = New System.Drawing.Size(65, 40)
        Me.CUSUpdateToolStripButton3.Text = "&Update"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(65, 40)
        Me.ToolStripButton1.Text = "Clos&e"
        '
        'DeleteToolStripLabel
        '
        Me.DeleteToolStripLabel.Name = "DeleteToolStripLabel"
        Me.DeleteToolStripLabel.Size = New System.Drawing.Size(40, 32)
        Me.DeleteToolStripLabel.Text = "Delete"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgw)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtsearchsname)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(947, 390)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Scheme"
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FloralWhite
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column8, Me.Column5, Me.Column9, Me.Column6, Me.Column7})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.DarkOrange
        Me.dgw.Location = New System.Drawing.Point(6, 39)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(929, 334)
        Me.dgw.TabIndex = 20
        '
        'Column1
        '
        Me.Column1.HeaderText = "#No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 30
        '
        'Column2
        '
        Me.Column2.HeaderText = "Scheme Ref #"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Scheme Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "County"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "CtyID"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        Me.Column8.Width = 20
        '
        'Column5
        '
        Me.Column5.HeaderText = "Constituency"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column9
        '
        Me.Column9.HeaderText = "ConstID"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        Me.Column9.Width = 20
        '
        'Column6
        '
        Me.Column6.HeaderText = "No of Customers"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 120
        '
        'Column7
        '
        Me.Column7.HeaderText = "Tx No"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'frmScheme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 556)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmScheme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSchemeName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsearchsname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CUSUpdateToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CUSSaveToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cboConstituency As ComboBox
    Friend WithEvents cboCounty As ComboBox
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents lblSchemeRefNo As TextBox
    Friend WithEvents txtNoofCust As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSubstNo As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtConstituencyID As TextBox
    Friend WithEvents txtCountyID As TextBox
    Friend WithEvents txtSchemeNo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgw As DataGridView
    Friend WithEvents DeleteToolStripLabel As ToolStripLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
