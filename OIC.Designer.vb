<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OIC
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.oiccancelbtn = New System.Windows.Forms.Button()
        Me.oicfinishbtn = New System.Windows.Forms.Button()
        Me.oicreceivedbylastnametxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.oicreceivedbymiddleinitialtxt = New System.Windows.Forms.TextBox()
        Me.oicreceivedbyfirstnametxt = New System.Windows.Forms.TextBox()
        Me.oicreceivedbydesignationtxt = New System.Windows.Forms.TextBox()
        Me.oicdgv = New System.Windows.Forms.DataGridView()
        Me.oicid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oicname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defaultuser = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.oicaccess = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.signaturelbl = New System.Windows.Forms.Label()
        Me.signaturepic = New System.Windows.Forms.PictureBox()
        CType(Me.oicdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signaturepic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.Label131.AutoSize = True
        Me.Label131.BackColor = System.Drawing.Color.Transparent
        Me.Label131.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label131.Location = New System.Drawing.Point(12, 78)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(123, 24)
        Me.Label131.TabIndex = 155
        Me.Label131.Text = "Designation:"
        Me.oiccancelbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.oiccancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oiccancelbtn.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.oiccancelbtn.ForeColor = System.Drawing.Color.White
        Me.oiccancelbtn.Location = New System.Drawing.Point(777, 400)
        Me.oiccancelbtn.Name = "oiccancelbtn"
        Me.oiccancelbtn.Size = New System.Drawing.Size(98, 35)
        Me.oiccancelbtn.TabIndex = 154
        Me.oiccancelbtn.Text = "Cancel"
        Me.oiccancelbtn.UseVisualStyleBackColor = False
        Me.oicfinishbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.oicfinishbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.oicfinishbtn.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.oicfinishbtn.ForeColor = System.Drawing.Color.White
        Me.oicfinishbtn.Location = New System.Drawing.Point(890, 400)
        Me.oicfinishbtn.Name = "oicfinishbtn"
        Me.oicfinishbtn.Size = New System.Drawing.Size(107, 35)
        Me.oicfinishbtn.TabIndex = 153
        Me.oicfinishbtn.Text = "Finish"
        Me.oicfinishbtn.UseVisualStyleBackColor = False
        Me.oicreceivedbylastnametxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.oicreceivedbylastnametxt.Location = New System.Drawing.Point(555, 36)
        Me.oicreceivedbylastnametxt.MaxLength = 50
        Me.oicreceivedbylastnametxt.Name = "oicreceivedbylastnametxt"
        Me.oicreceivedbylastnametxt.Size = New System.Drawing.Size(442, 32)
        Me.oicreceivedbylastnametxt.TabIndex = 152
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.Label2.Location = New System.Drawing.Point(755, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Last Name"
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.Label4.Location = New System.Drawing.Point(457, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 21)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Middle Initial"
        Me.Label124.AutoSize = True
        Me.Label124.BackColor = System.Drawing.Color.Transparent
        Me.Label124.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label124.Location = New System.Drawing.Point(149, 13)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(91, 21)
        Me.Label124.TabIndex = 149
        Me.Label124.Text = "First Name"
        Me.oicreceivedbymiddleinitialtxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.oicreceivedbymiddleinitialtxt.Location = New System.Drawing.Point(481, 36)
        Me.oicreceivedbymiddleinitialtxt.MaxLength = 1
        Me.oicreceivedbymiddleinitialtxt.Name = "oicreceivedbymiddleinitialtxt"
        Me.oicreceivedbymiddleinitialtxt.Size = New System.Drawing.Size(56, 32)
        Me.oicreceivedbymiddleinitialtxt.TabIndex = 148
        Me.oicreceivedbyfirstnametxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.oicreceivedbyfirstnametxt.Location = New System.Drawing.Point(16, 36)
        Me.oicreceivedbyfirstnametxt.MaxLength = 50
        Me.oicreceivedbyfirstnametxt.Name = "oicreceivedbyfirstnametxt"
        Me.oicreceivedbyfirstnametxt.Size = New System.Drawing.Size(445, 32)
        Me.oicreceivedbyfirstnametxt.TabIndex = 147
        Me.oicreceivedbydesignationtxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.oicreceivedbydesignationtxt.Location = New System.Drawing.Point(137, 74)
        Me.oicreceivedbydesignationtxt.MaxLength = 50
        Me.oicreceivedbydesignationtxt.Name = "oicreceivedbydesignationtxt"
        Me.oicreceivedbydesignationtxt.Size = New System.Drawing.Size(860, 32)
        Me.oicreceivedbydesignationtxt.TabIndex = 146
        Me.oicdgv.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.oicdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.oicdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.oicdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.oicid, Me.oicname, Me.defaultuser, Me.oicaccess})
        Me.oicdgv.Location = New System.Drawing.Point(17, 187)
        Me.oicdgv.Name = "oicdgv"
        Me.oicdgv.RowHeadersWidth = 51
        Me.oicdgv.RowTemplate.Height = 24
        Me.oicdgv.Size = New System.Drawing.Size(980, 185)
        Me.oicdgv.TabIndex = 157
        Me.oicid.HeaderText = "ID"
        Me.oicid.MinimumWidth = 6
        Me.oicid.Name = "oicid"
        Me.oicid.ReadOnly = True
        Me.oicid.Width = 50
        Me.oicname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.oicname.HeaderText = "Name"
        Me.oicname.MinimumWidth = 6
        Me.oicname.Name = "oicname"
        Me.oicname.ReadOnly = True
        Me.defaultuser.HeaderText = "Default User"
        Me.defaultuser.MinimumWidth = 6
        Me.defaultuser.Name = "defaultuser"
        Me.defaultuser.Width = 125
        Me.oicaccess.HeaderText = "Access"
        Me.oicaccess.MinimumWidth = 6
        Me.oicaccess.Name = "oicaccess"
        Me.oicaccess.Width = 125
        Me.signaturelbl.AutoSize = True
        Me.signaturelbl.BackColor = System.Drawing.Color.Transparent
        Me.signaturelbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signaturelbl.Location = New System.Drawing.Point(439, 121)
        Me.signaturelbl.Name = "signaturelbl"
        Me.signaturelbl.Size = New System.Drawing.Size(163, 24)
        Me.signaturelbl.TabIndex = 158
        Me.signaturelbl.Text = "Upload Signature"
        Me.signaturepic.Location = New System.Drawing.Point(620, 121)
        Me.signaturepic.Name = "signaturepic"
        Me.signaturepic.Size = New System.Drawing.Size(59, 55)
        Me.signaturepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.signaturepic.TabIndex = 159
        Me.signaturepic.TabStop = False
        Me.signaturepic.Visible = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 447)
        Me.Controls.Add(Me.signaturepic)
        Me.Controls.Add(Me.signaturelbl)
        Me.Controls.Add(Me.oicdgv)
        Me.Controls.Add(Me.Label131)
        Me.Controls.Add(Me.oiccancelbtn)
        Me.Controls.Add(Me.oicfinishbtn)
        Me.Controls.Add(Me.oicreceivedbylastnametxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label124)
        Me.Controls.Add(Me.oicreceivedbymiddleinitialtxt)
        Me.Controls.Add(Me.oicreceivedbyfirstnametxt)
        Me.Controls.Add(Me.oicreceivedbydesignationtxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OIC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OIC"
        CType(Me.oicdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signaturepic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label131 As Label
    Friend WithEvents oiccancelbtn As Button
    Friend WithEvents oicfinishbtn As Button
    Friend WithEvents oicreceivedbylastnametxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label124 As Label
    Friend WithEvents oicreceivedbymiddleinitialtxt As TextBox
    Friend WithEvents oicreceivedbyfirstnametxt As TextBox
    Friend WithEvents oicreceivedbydesignationtxt As TextBox
    Friend WithEvents oicdgv As DataGridView
    Friend WithEvents signaturelbl As Label
    Friend WithEvents signaturepic As PictureBox
    Friend WithEvents oicid As DataGridViewTextBoxColumn
    Friend WithEvents oicname As DataGridViewTextBoxColumn
    Friend WithEvents defaultuser As DataGridViewCheckBoxColumn
    Friend WithEvents oicaccess As DataGridViewCheckBoxColumn
End Class
