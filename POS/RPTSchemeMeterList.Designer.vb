<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPTSchemeMeterList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPTSchemeMeterList))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboSchemeName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSchemeID = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colIDNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPhoneNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPoleNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colXcoordinate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYcoordinate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYRefNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWorkorder = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMeterNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEarthing = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colConnectionStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colIssueStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRemarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSchemeName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colConstituencyname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCountyName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtCountMeters = New System.Windows.Forms.TextBox()
        Me.colZRefNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTNLoadMeterlistreport = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Controls.Add(Me.cboSchemeName)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.BTNLoadMeterlistreport)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtSchemeID)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(825, 57)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Parameters"
        '
        'cboSchemeName
        '
        Me.cboSchemeName.FormattingEnabled = True
        Me.cboSchemeName.Location = New System.Drawing.Point(67, 24)
        Me.cboSchemeName.Name = "cboSchemeName"
        Me.cboSchemeName.Size = New System.Drawing.Size(137, 21)
        Me.cboSchemeName.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(295, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = " Scheme Customer $ Meter List"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Scheme:"
        '
        'txtSchemeID
        '
        Me.txtSchemeID.Location = New System.Drawing.Point(67, 24)
        Me.txtSchemeID.Name = "txtSchemeID"
        Me.txtSchemeID.Size = New System.Drawing.Size(27, 21)
        Me.txtSchemeID.TabIndex = 45
        Me.txtSchemeID.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 64)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(825, 422)
        Me.ReportViewer1.TabIndex = 41
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colIDNo, Me.colPhoneNo, Me.colPoleNo, Me.colXcoordinate, Me.colYcoordinate, Me.colYRefNo, Me.colWorkorder, Me.colMeterNo, Me.colEarthing, Me.colConnectionStatus, Me.colIssueStatus, Me.colRemarks, Me.colSchemeName, Me.colConstituencyname, Me.colCountyName, Me.colZRefNo, Me.ColQty})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 64)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(802, 128)
        Me.ListView1.TabIndex = 42
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 75
        '
        'colIDNo
        '
        Me.colIDNo.Text = "ID No"
        Me.colIDNo.Width = 50
        '
        'colPhoneNo
        '
        Me.colPhoneNo.Text = "Phone No"
        '
        'colPoleNo
        '
        Me.colPoleNo.Text = "Pole No"
        Me.colPoleNo.Width = 50
        '
        'colXcoordinate
        '
        Me.colXcoordinate.Text = "XCo-ordinate"
        Me.colXcoordinate.Width = 75
        '
        'colYcoordinate
        '
        Me.colYcoordinate.Text = "YCo-ordinate"
        Me.colYcoordinate.Width = 75
        '
        'colYRefNo
        '
        Me.colYRefNo.Text = "Y-RefNo"
        '
        'colWorkorder
        '
        Me.colWorkorder.Text = "Workorder"
        '
        'colMeterNo
        '
        Me.colMeterNo.Text = "Meter No"
        '
        'colEarthing
        '
        Me.colEarthing.Text = "Earthing"
        '
        'colConnectionStatus
        '
        Me.colConnectionStatus.Text = "Connection Status"
        '
        'colIssueStatus
        '
        Me.colIssueStatus.Text = "Issue Status"
        '
        'colRemarks
        '
        Me.colRemarks.Text = "Remarks"
        '
        'colSchemeName
        '
        Me.colSchemeName.Text = "Scheme name"
        '
        'colConstituencyname
        '
        Me.colConstituencyname.Text = "Constituency Name"
        '
        'colCountyName
        '
        Me.colCountyName.Text = "County Name"
        '
        'ColQty
        '
        Me.ColQty.Text = "Qty"
        '
        'txtCountMeters
        '
        Me.txtCountMeters.Location = New System.Drawing.Point(36, 198)
        Me.txtCountMeters.Name = "txtCountMeters"
        Me.txtCountMeters.Size = New System.Drawing.Size(84, 20)
        Me.txtCountMeters.TabIndex = 43
        '
        'colZRefNo
        '
        Me.colZRefNo.Text = "Z-Ref No"
        '
        'BTNLoadMeterlistreport
        '
        Me.BTNLoadMeterlistreport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BTNLoadMeterlistreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLoadMeterlistreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNLoadMeterlistreport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLoadMeterlistreport.Image = CType(resources.GetObject("BTNLoadMeterlistreport.Image"), System.Drawing.Image)
        Me.BTNLoadMeterlistreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNLoadMeterlistreport.Location = New System.Drawing.Point(210, 25)
        Me.BTNLoadMeterlistreport.Name = "BTNLoadMeterlistreport"
        Me.BTNLoadMeterlistreport.Size = New System.Drawing.Size(61, 20)
        Me.BTNLoadMeterlistreport.TabIndex = 37
        Me.BTNLoadMeterlistreport.Text = "&Load "
        Me.BTNLoadMeterlistreport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNLoadMeterlistreport.UseVisualStyleBackColor = False
        '
        'RPTSchemeMeterList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 491)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtCountMeters)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "RPTSchemeMeterList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scheme Customer $ Meter List"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboSchemeName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNLoadMeterlistreport As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSchemeID As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ListView1 As ListView
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colIDNo As ColumnHeader
    Friend WithEvents colPoleNo As ColumnHeader
    Friend WithEvents colXcoordinate As ColumnHeader
    Friend WithEvents colYcoordinate As ColumnHeader
    Friend WithEvents colYRefNo As ColumnHeader
    Friend WithEvents colMeterNo As ColumnHeader
    Friend WithEvents colEarthing As ColumnHeader
    Friend WithEvents colConnectionStatus As ColumnHeader
    Friend WithEvents colIssueStatus As ColumnHeader
    Friend WithEvents colRemarks As ColumnHeader
    Friend WithEvents colPhoneNo As ColumnHeader
    Friend WithEvents colWorkorder As ColumnHeader
    Friend WithEvents colSchemeName As ColumnHeader
    Friend WithEvents colConstituencyname As ColumnHeader
    Friend WithEvents colCountyName As ColumnHeader
    Friend WithEvents ColQty As ColumnHeader
    Friend WithEvents txtCountMeters As TextBox
    Friend WithEvents colZRefNo As ColumnHeader
End Class
