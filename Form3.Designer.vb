<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.icscancelbtn = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.qrentry = New System.Windows.Forms.TextBox()
        Me.scantype = New System.Windows.Forms.Label()
        Me.txtbxlbl = New System.Windows.Forms.Label()
        Me.btnbtn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        Me.icscancelbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.icscancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.icscancelbtn.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.icscancelbtn.ForeColor = System.Drawing.Color.White
        Me.icscancelbtn.Location = New System.Drawing.Point(65, 76)
        Me.icscancelbtn.Name = "icscancelbtn"
        Me.icscancelbtn.Size = New System.Drawing.Size(86, 34)
        Me.icscancelbtn.TabIndex = 120
        Me.icscancelbtn.TabStop = False
        Me.icscancelbtn.Text = "Back"
        Me.icscancelbtn.UseVisualStyleBackColor = False
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(54, 29)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(121, 34)
        Me.Label.TabIndex = 144
        Me.Label.Text = "Scan QR"
        Me.qrentry.Location = New System.Drawing.Point(120, 20)
        Me.qrentry.Name = "qrentry"
        Me.qrentry.Size = New System.Drawing.Size(1, 22)
        Me.qrentry.TabIndex = 145
        Me.scantype.AutoSize = True
        Me.scantype.BackColor = System.Drawing.Color.Transparent
        Me.scantype.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scantype.Location = New System.Drawing.Point(0, 45)
        Me.scantype.Name = "scantype"
        Me.scantype.Size = New System.Drawing.Size(59, 34)
        Me.scantype.TabIndex = 146
        Me.scantype.Text = "Sca"
        Me.scantype.Visible = False
        Me.txtbxlbl.AutoSize = True
        Me.txtbxlbl.BackColor = System.Drawing.Color.Transparent
        Me.txtbxlbl.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxlbl.Location = New System.Drawing.Point(0, 73)
        Me.txtbxlbl.Name = "txtbxlbl"
        Me.txtbxlbl.Size = New System.Drawing.Size(59, 34)
        Me.txtbxlbl.TabIndex = 147
        Me.txtbxlbl.Text = "Sca"
        Me.txtbxlbl.Visible = False
        Me.btnbtn.AutoSize = True
        Me.btnbtn.BackColor = System.Drawing.Color.Transparent
        Me.btnbtn.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbtn.Location = New System.Drawing.Point(181, 20)
        Me.btnbtn.Name = "btnbtn"
        Me.btnbtn.Size = New System.Drawing.Size(59, 34)
        Me.btnbtn.TabIndex = 148
        Me.btnbtn.Text = "Sca"
        Me.btnbtn.Visible = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(215, 119)
        Me.Controls.Add(Me.btnbtn)
        Me.Controls.Add(Me.txtbxlbl)
        Me.Controls.Add(Me.scantype)
        Me.Controls.Add(Me.qrentry)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.icscancelbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents icscancelbtn As Button
    Friend WithEvents Label As Label
    Friend WithEvents qrentry As TextBox
    Friend WithEvents scantype As Label
    Friend WithEvents txtbxlbl As Label
    Friend WithEvents btnbtn As Label
End Class
