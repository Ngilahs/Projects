﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RPTMaterialDeliveryNote
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPTMaterialDeliveryNote))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtQtysold = New System.Windows.Forms.TextBox()
        Me.txtSumTotalAmt = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnMovetofirstrecordupbyone = New System.Windows.Forms.Button()
        Me.btnMoveFirstRecord = New System.Windows.Forms.Button()
        Me.btnMoveUpOnerecord = New System.Windows.Forms.Button()
        Me.btnMovetoLastrecord = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDeliveryNo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnShowReport = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader10, Me.ColumnHeader9, Me.ColumnHeader11})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(2, 116)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(771, 103)
        Me.ListView1.TabIndex = 12
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item No"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 105
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantity"
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date Issued"
        Me.ColumnHeader4.Width = 51
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Unit of Issue"
        Me.ColumnHeader5.Width = 125
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Delivery No"
        Me.ColumnHeader6.Width = 114
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Scheme Name"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "SchemeRefNo"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Vehicle No"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Sub-Contractor"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "substation"
        '
        'txtQtysold
        '
        Me.txtQtysold.Location = New System.Drawing.Point(391, 251)
        Me.txtQtysold.Name = "txtQtysold"
        Me.txtQtysold.Size = New System.Drawing.Size(88, 20)
        Me.txtQtysold.TabIndex = 16
        Me.txtQtysold.Visible = False
        '
        'txtSumTotalAmt
        '
        Me.txtSumTotalAmt.Location = New System.Drawing.Point(500, 251)
        Me.txtSumTotalAmt.Name = "txtSumTotalAmt"
        Me.txtSumTotalAmt.Size = New System.Drawing.Size(88, 20)
        Me.txtSumTotalAmt.TabIndex = 17
        Me.txtSumTotalAmt.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 65)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(979, 520)
        Me.ReportViewer1.TabIndex = 18
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Controls.Add(Me.btnMovetofirstrecordupbyone)
        Me.GroupBox3.Controls.Add(Me.btnMoveFirstRecord)
        Me.GroupBox3.Controls.Add(Me.btnMoveUpOnerecord)
        Me.GroupBox3.Controls.Add(Me.btnMovetoLastrecord)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cboDeliveryNo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.BtnShowReport)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(979, 57)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Parameters"
        '
        'btnMovetofirstrecordupbyone
        '
        Me.btnMovetofirstrecordupbyone.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovetofirstrecordupbyone.ForeColor = System.Drawing.Color.Red
        Me.btnMovetofirstrecordupbyone.Location = New System.Drawing.Point(135, 29)
        Me.btnMovetofirstrecordupbyone.Name = "btnMovetofirstrecordupbyone"
        Me.btnMovetofirstrecordupbyone.Size = New System.Drawing.Size(15, 21)
        Me.btnMovetofirstrecordupbyone.TabIndex = 48
        Me.btnMovetofirstrecordupbyone.Text = ">"
        Me.btnMovetofirstrecordupbyone.UseVisualStyleBackColor = True
        '
        'btnMoveFirstRecord
        '
        Me.btnMoveFirstRecord.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveFirstRecord.ForeColor = System.Drawing.Color.Red
        Me.btnMoveFirstRecord.Location = New System.Drawing.Point(92, 29)
        Me.btnMoveFirstRecord.Name = "btnMoveFirstRecord"
        Me.btnMoveFirstRecord.Size = New System.Drawing.Size(37, 21)
        Me.btnMoveFirstRecord.TabIndex = 47
        Me.btnMoveFirstRecord.Text = "<<<"
        Me.btnMoveFirstRecord.UseVisualStyleBackColor = True
        '
        'btnMoveUpOnerecord
        '
        Me.btnMoveUpOnerecord.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveUpOnerecord.ForeColor = System.Drawing.Color.Red
        Me.btnMoveUpOnerecord.Location = New System.Drawing.Point(285, 30)
        Me.btnMoveUpOnerecord.Name = "btnMoveUpOnerecord"
        Me.btnMoveUpOnerecord.Size = New System.Drawing.Size(13, 21)
        Me.btnMoveUpOnerecord.TabIndex = 46
        Me.btnMoveUpOnerecord.Text = "<"
        Me.btnMoveUpOnerecord.UseVisualStyleBackColor = True
        '
        'btnMovetoLastrecord
        '
        Me.btnMovetoLastrecord.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovetoLastrecord.ForeColor = System.Drawing.Color.Red
        Me.btnMovetoLastrecord.Location = New System.Drawing.Point(304, 30)
        Me.btnMovetoLastrecord.Name = "btnMovetoLastrecord"
        Me.btnMovetoLastrecord.Size = New System.Drawing.Size(42, 21)
        Me.btnMovetoLastrecord.TabIndex = 45
        Me.btnMovetoLastrecord.Text = ">>>"
        Me.btnMovetoLastrecord.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Delivery No:"
        '
        'cboDeliveryNo
        '
        Me.cboDeliveryNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboDeliveryNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDeliveryNo.FormattingEnabled = True
        Me.cboDeliveryNo.Location = New System.Drawing.Point(156, 29)
        Me.cboDeliveryNo.Name = "cboDeliveryNo"
        Me.cboDeliveryNo.Size = New System.Drawing.Size(123, 21)
        Me.cboDeliveryNo.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(455, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Material Delivery Note"
        '
        'BtnShowReport
        '
        Me.BtnShowReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnShowReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnShowReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowReport.Image = CType(resources.GetObject("BtnShowReport.Image"), System.Drawing.Image)
        Me.BtnShowReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnShowReport.Location = New System.Drawing.Point(355, 29)
        Me.BtnShowReport.Name = "BtnShowReport"
        Me.BtnShowReport.Size = New System.Drawing.Size(63, 22)
        Me.BtnShowReport.TabIndex = 37
        Me.BtnShowReport.Text = "&Load "
        Me.BtnShowReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnShowReport.UseVisualStyleBackColor = False
        '
        'RPTMaterialDeliveryNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 588)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtSumTotalAmt)
        Me.Controls.Add(Me.txtQtysold)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "RPTMaterialDeliveryNote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material Delivery Note"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtQtysold As System.Windows.Forms.TextBox
    Friend WithEvents txtSumTotalAmt As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnShowReport As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents cboDeliveryNo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents btnMovetofirstrecordupbyone As Button
    Friend WithEvents btnMoveFirstRecord As Button
    Friend WithEvents btnMoveUpOnerecord As Button
    Friend WithEvents btnMovetoLastrecord As Button
End Class
