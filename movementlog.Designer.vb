<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class movementlog
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
        Me.supplystockcardbackbtn = New System.Windows.Forms.Button()
        Me.movementlogdgv = New System.Windows.Forms.DataGridView()
        Me.movementlogid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movementlogdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movementlogdocumenttype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movementlogreceivingpersonel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movementlogview = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.movementlogstatustxt = New System.Windows.Forms.Label()
        Me.asdad = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.movementlogpropertynumbertxt = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.movementlogdescriptiondgv = New System.Windows.Forms.DataGridView()
        Me.movementlogdescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.equQRbtn = New System.Windows.Forms.Button()
        Me.printmovementlogbtn = New System.Windows.Forms.Button()
        CType(Me.movementlogdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.movementlogdescriptiondgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.supplystockcardbackbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.supplystockcardbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supplystockcardbackbtn.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.supplystockcardbackbtn.ForeColor = System.Drawing.Color.White
        Me.supplystockcardbackbtn.Location = New System.Drawing.Point(27, 784)
        Me.supplystockcardbackbtn.Name = "supplystockcardbackbtn"
        Me.supplystockcardbackbtn.Size = New System.Drawing.Size(98, 35)
        Me.supplystockcardbackbtn.TabIndex = 103
        Me.supplystockcardbackbtn.Text = "Back"
        Me.supplystockcardbackbtn.UseVisualStyleBackColor = False
        Me.movementlogdgv.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.movementlogdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.movementlogdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.movementlogdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.movementlogid, Me.movementlogdate, Me.movementlogdocumenttype, Me.movementlogreceivingpersonel, Me.movementlogview})
        Me.movementlogdgv.Location = New System.Drawing.Point(26, 454)
        Me.movementlogdgv.Name = "movementlogdgv"
        Me.movementlogdgv.RowHeadersWidth = 51
        Me.movementlogdgv.RowTemplate.Height = 24
        Me.movementlogdgv.Size = New System.Drawing.Size(942, 312)
        Me.movementlogdgv.TabIndex = 102
        Me.movementlogid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.movementlogid.HeaderText = "Document ID"
        Me.movementlogid.MinimumWidth = 90
        Me.movementlogid.Name = "movementlogid"
        Me.movementlogid.ReadOnly = True
        Me.movementlogid.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.movementlogid.Width = 125
        Me.movementlogdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.movementlogdate.HeaderText = "Date"
        Me.movementlogdate.MinimumWidth = 80
        Me.movementlogdate.Name = "movementlogdate"
        Me.movementlogdate.ReadOnly = True
        Me.movementlogdate.Width = 125
        Me.movementlogdocumenttype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.movementlogdocumenttype.HeaderText = "Document Type"
        Me.movementlogdocumenttype.MinimumWidth = 6
        Me.movementlogdocumenttype.Name = "movementlogdocumenttype"
        Me.movementlogdocumenttype.ReadOnly = True
        Me.movementlogreceivingpersonel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.movementlogreceivingpersonel.HeaderText = "Receiving Personel"
        Me.movementlogreceivingpersonel.MinimumWidth = 6
        Me.movementlogreceivingpersonel.Name = "movementlogreceivingpersonel"
        Me.movementlogreceivingpersonel.ReadOnly = True
        Me.movementlogreceivingpersonel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.movementlogreceivingpersonel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.movementlogview.HeaderText = ""
        Me.movementlogview.MinimumWidth = 6
        Me.movementlogview.Name = "movementlogview"
        Me.movementlogview.Text = "View Details"
        Me.movementlogview.UseColumnTextForButtonValue = True
        Me.movementlogview.Width = 125
        Me.movementlogstatustxt.AutoSize = True
        Me.movementlogstatustxt.BackColor = System.Drawing.Color.Transparent
        Me.movementlogstatustxt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movementlogstatustxt.Location = New System.Drawing.Point(186, 162)
        Me.movementlogstatustxt.Name = "movementlogstatustxt"
        Me.movementlogstatustxt.Size = New System.Drawing.Size(116, 24)
        Me.movementlogstatustxt.TabIndex = 99
        Me.movementlogstatustxt.Text = "0000-00000"
        Me.asdad.AutoSize = True
        Me.asdad.BackColor = System.Drawing.Color.Transparent
        Me.asdad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asdad.Location = New System.Drawing.Point(23, 162)
        Me.asdad.Name = "asdad"
        Me.asdad.Size = New System.Drawing.Size(157, 24)
        Me.asdad.TabIndex = 98
        Me.asdad.Text = "Current Status : "
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 24)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Description : "
        Me.movementlogpropertynumbertxt.AutoSize = True
        Me.movementlogpropertynumbertxt.BackColor = System.Drawing.Color.Transparent
        Me.movementlogpropertynumbertxt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movementlogpropertynumbertxt.Location = New System.Drawing.Point(202, 105)
        Me.movementlogpropertynumbertxt.Name = "movementlogpropertynumbertxt"
        Me.movementlogpropertynumbertxt.Size = New System.Drawing.Size(116, 24)
        Me.movementlogpropertynumbertxt.TabIndex = 95
        Me.movementlogpropertynumbertxt.Text = "0000-00000"
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(22, 105)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(174, 24)
        Me.Label71.TabIndex = 94
        Me.Label71.Text = "Property Number :"
        Me.movementlogdescriptiondgv.BackgroundColor = System.Drawing.Color.White
        Me.movementlogdescriptiondgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.movementlogdescriptiondgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.movementlogdescription})
        Me.movementlogdescriptiondgv.Location = New System.Drawing.Point(179, 224)
        Me.movementlogdescriptiondgv.Name = "movementlogdescriptiondgv"
        Me.movementlogdescriptiondgv.RowHeadersWidth = 51
        Me.movementlogdescriptiondgv.RowTemplate.Height = 24
        Me.movementlogdescriptiondgv.Size = New System.Drawing.Size(448, 213)
        Me.movementlogdescriptiondgv.TabIndex = 104
        Me.movementlogdescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.movementlogdescription.HeaderText = "Description"
        Me.movementlogdescription.MinimumWidth = 6
        Me.movementlogdescription.Name = "movementlogdescription"
        Me.movementlogdescription.ReadOnly = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(319, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 34)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Equipment Movement Log"
        Me.equQRbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.equQRbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.equQRbtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equQRbtn.ForeColor = System.Drawing.Color.White
        Me.equQRbtn.Location = New System.Drawing.Point(870, 402)
        Me.equQRbtn.Name = "equQRbtn"
        Me.equQRbtn.Size = New System.Drawing.Size(98, 35)
        Me.equQRbtn.TabIndex = 106
        Me.equQRbtn.Text = "QR Code"
        Me.equQRbtn.UseVisualStyleBackColor = False
        Me.printmovementlogbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.printmovementlogbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printmovementlogbtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printmovementlogbtn.ForeColor = System.Drawing.Color.White
        Me.printmovementlogbtn.Location = New System.Drawing.Point(752, 402)
        Me.printmovementlogbtn.Name = "printmovementlogbtn"
        Me.printmovementlogbtn.Size = New System.Drawing.Size(98, 35)
        Me.printmovementlogbtn.TabIndex = 107
        Me.printmovementlogbtn.Text = "Print"
        Me.printmovementlogbtn.UseVisualStyleBackColor = False
        Me.printmovementlogbtn.Visible = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(996, 831)
        Me.Controls.Add(Me.printmovementlogbtn)
        Me.Controls.Add(Me.equQRbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.movementlogdescriptiondgv)
        Me.Controls.Add(Me.supplystockcardbackbtn)
        Me.Controls.Add(Me.movementlogdgv)
        Me.Controls.Add(Me.movementlogstatustxt)
        Me.Controls.Add(Me.asdad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.movementlogpropertynumbertxt)
        Me.Controls.Add(Me.Label71)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "movementlog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "movementlog"
        CType(Me.movementlogdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.movementlogdescriptiondgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents supplystockcardbackbtn As Button
    Friend WithEvents movementlogdgv As DataGridView
    Friend WithEvents movementlogstatustxt As Label
    Friend WithEvents asdad As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents movementlogpropertynumbertxt As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents movementlogdescriptiondgv As DataGridView
    Friend WithEvents movementlogdescription As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents movementlogid As DataGridViewTextBoxColumn
    Friend WithEvents movementlogdate As DataGridViewTextBoxColumn
    Friend WithEvents movementlogdocumenttype As DataGridViewTextBoxColumn
    Friend WithEvents movementlogreceivingpersonel As DataGridViewTextBoxColumn
    Friend WithEvents movementlogview As DataGridViewButtonColumn
    Friend WithEvents equQRbtn As Button
    Friend WithEvents printmovementlogbtn As Button
End Class
