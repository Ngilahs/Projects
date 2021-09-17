<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadJMCScheme
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtschemeName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colSchemeName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSchemeRefNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSchemeNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColTXNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colcountyid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colConstituency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colconstitu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCounty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNoofCust = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(217, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 16)
        Me.Label7.TabIndex = 222
        Me.Label7.Text = "Load Scheme"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 32)
        Me.Panel1.TabIndex = 7
        '
        'txtschemeName
        '
        Me.txtschemeName.Location = New System.Drawing.Point(99, 36)
        Me.txtschemeName.Name = "txtschemeName"
        Me.txtschemeName.Size = New System.Drawing.Size(450, 20)
        Me.txtschemeName.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Scheme Name :"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSchemeName, Me.colSchemeRefNo, Me.colSchemeNo, Me.ColTXNo, Me.colcountyid, Me.colConstituency, Me.colconstitu, Me.colCounty, Me.colNoofCust})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(1, 62)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(548, 290)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colSchemeName
        '
        Me.colSchemeName.Text = "Scheme Name"
        Me.colSchemeName.Width = 101
        '
        'colSchemeRefNo
        '
        Me.colSchemeRefNo.Text = "Scheme Ref"
        Me.colSchemeRefNo.Width = 173
        '
        'colSchemeNo
        '
        Me.colSchemeNo.Text = "Scheme No"
        Me.colSchemeNo.Width = 150
        '
        'ColTXNo
        '
        Me.ColTXNo.Text = "TX No"
        Me.ColTXNo.Width = 200
        '
        'colcountyid
        '
        Me.colcountyid.Text = "County"
        '
        'colConstituency
        '
        Me.colConstituency.Text = "Constituency"
        '
        'colconstitu
        '
        Me.colconstitu.Text = "Constituency"
        '
        'colCounty
        '
        Me.colCounty.Text = "County"
        '
        'colNoofCust
        '
        Me.colNoofCust.Text = "Customers"
        '
        'frmLoadJMCScheme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 354)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtschemeName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmLoadJMCScheme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtschemeName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents colSchemeName As ColumnHeader
    Friend WithEvents colSchemeRefNo As ColumnHeader
    Friend WithEvents colSchemeNo As ColumnHeader
    Friend WithEvents ColTXNo As ColumnHeader
    Friend WithEvents colcountyid As ColumnHeader
    Friend WithEvents colConstituency As ColumnHeader
    Friend WithEvents colconstitu As ColumnHeader
    Friend WithEvents colCounty As ColumnHeader
    Friend WithEvents colNoofCust As ColumnHeader
End Class
