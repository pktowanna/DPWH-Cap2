<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplystockcard
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.stocknumberlbl = New System.Windows.Forms.Label()
        Me.descriptionlbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.itemlbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.unitlbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.stockcardsdgv = New System.Windows.Forms.DataGridView()
        Me.supplyid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currentbalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateadded = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.viewstockcard = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.supplystockcardbackbtn = New System.Windows.Forms.Button()
        CType(Me.stockcardsdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(38, 39)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(153, 24)
        Me.Label71.TabIndex = 84
        Me.Label71.Text = "Stock Number : "
        Me.stocknumberlbl.AutoSize = True
        Me.stocknumberlbl.BackColor = System.Drawing.Color.Transparent
        Me.stocknumberlbl.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stocknumberlbl.Location = New System.Drawing.Point(213, 39)
        Me.stocknumberlbl.Name = "stocknumberlbl"
        Me.stocknumberlbl.Size = New System.Drawing.Size(119, 24)
        Me.stocknumberlbl.TabIndex = 85
        Me.stocknumberlbl.Text = "0000-00000"
        Me.descriptionlbl.AutoSize = True
        Me.descriptionlbl.BackColor = System.Drawing.Color.Transparent
        Me.descriptionlbl.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionlbl.Location = New System.Drawing.Point(213, 79)
        Me.descriptionlbl.Name = "descriptionlbl"
        Me.descriptionlbl.Size = New System.Drawing.Size(119, 24)
        Me.descriptionlbl.TabIndex = 87
        Me.descriptionlbl.Text = "0000-00000"
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 24)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Description : "
        Me.itemlbl.AutoSize = True
        Me.itemlbl.BackColor = System.Drawing.Color.Transparent
        Me.itemlbl.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemlbl.Location = New System.Drawing.Point(213, 123)
        Me.itemlbl.Name = "itemlbl"
        Me.itemlbl.Size = New System.Drawing.Size(119, 24)
        Me.itemlbl.TabIndex = 89
        Me.itemlbl.Text = "0000-00000"
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 24)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Item : "
        Me.unitlbl.AutoSize = True
        Me.unitlbl.BackColor = System.Drawing.Color.Transparent
        Me.unitlbl.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitlbl.Location = New System.Drawing.Point(213, 167)
        Me.unitlbl.Name = "unitlbl"
        Me.unitlbl.Size = New System.Drawing.Size(119, 24)
        Me.unitlbl.TabIndex = 91
        Me.unitlbl.Text = "0000-00000"
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 24)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Unit of Measure : "
        Me.stockcardsdgv.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.stockcardsdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.stockcardsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stockcardsdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.supplyid, Me.currentbalance, Me.dateadded, Me.viewstockcard})
        Me.stockcardsdgv.Location = New System.Drawing.Point(42, 226)
        Me.stockcardsdgv.Name = "stockcardsdgv"
        Me.stockcardsdgv.RowHeadersWidth = 51
        Me.stockcardsdgv.RowTemplate.Height = 24
        Me.stockcardsdgv.Size = New System.Drawing.Size(579, 312)
        Me.stockcardsdgv.TabIndex = 92
        Me.supplyid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.supplyid.HeaderText = "Supply ID"
        Me.supplyid.MinimumWidth = 100
        Me.supplyid.Name = "supplyid"
        Me.supplyid.ReadOnly = True
        Me.supplyid.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.supplyid.Width = 125
        Me.currentbalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.currentbalance.HeaderText = "Current Balance"
        Me.currentbalance.MinimumWidth = 100
        Me.currentbalance.Name = "currentbalance"
        Me.currentbalance.ReadOnly = True
        Me.currentbalance.Width = 125
        Me.dateadded.HeaderText = "Date Added"
        Me.dateadded.MinimumWidth = 6
        Me.dateadded.Name = "dateadded"
        Me.dateadded.ReadOnly = True
        Me.dateadded.Width = 125
        Me.viewstockcard.HeaderText = ""
        Me.viewstockcard.MinimumWidth = 6
        Me.viewstockcard.Name = "viewstockcard"
        Me.viewstockcard.ReadOnly = True
        Me.viewstockcard.Text = "View Stock Card"
        Me.viewstockcard.UseColumnTextForButtonValue = True
        Me.viewstockcard.Width = 150
        Me.supplystockcardbackbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.supplystockcardbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supplystockcardbackbtn.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.supplystockcardbackbtn.ForeColor = System.Drawing.Color.White
        Me.supplystockcardbackbtn.Location = New System.Drawing.Point(42, 557)
        Me.supplystockcardbackbtn.Name = "supplystockcardbackbtn"
        Me.supplystockcardbackbtn.Size = New System.Drawing.Size(98, 35)
        Me.supplystockcardbackbtn.TabIndex = 93
        Me.supplystockcardbackbtn.Text = "Back"
        Me.supplystockcardbackbtn.UseVisualStyleBackColor = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(661, 612)
        Me.Controls.Add(Me.supplystockcardbackbtn)
        Me.Controls.Add(Me.stockcardsdgv)
        Me.Controls.Add(Me.unitlbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.itemlbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.descriptionlbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.stocknumberlbl)
        Me.Controls.Add(Me.Label71)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "supplystockcard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "supplystockcard"
        CType(Me.stockcardsdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label71 As Label
    Friend WithEvents stocknumberlbl As Label
    Friend WithEvents descriptionlbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents itemlbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents unitlbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents stockcardsdgv As DataGridView
    Friend WithEvents supplyid As DataGridViewTextBoxColumn
    Friend WithEvents currentbalance As DataGridViewTextBoxColumn
    Friend WithEvents dateadded As DataGridViewTextBoxColumn
    Friend WithEvents viewstockcard As DataGridViewButtonColumn
    Friend WithEvents supplystockcardbackbtn As Button
End Class
