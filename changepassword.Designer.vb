<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepassword
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
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.finishbtn = New System.Windows.Forms.Button()
        Me.confirmpasswordtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newpasswordtxt = New System.Windows.Forms.TextBox()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.oldpasswordtxt = New System.Windows.Forms.TextBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.idlbl = New System.Windows.Forms.Label()
        Me.showoldpasswordpb = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.showoldpasswordpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.cancelbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelbtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelbtn.ForeColor = System.Drawing.Color.White
        Me.cancelbtn.Location = New System.Drawing.Point(143, 207)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(98, 35)
        Me.cancelbtn.TabIndex = 65
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = False
        Me.finishbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.finishbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.finishbtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finishbtn.ForeColor = System.Drawing.Color.White
        Me.finishbtn.Location = New System.Drawing.Point(256, 207)
        Me.finishbtn.Name = "finishbtn"
        Me.finishbtn.Size = New System.Drawing.Size(107, 35)
        Me.finishbtn.TabIndex = 64
        Me.finishbtn.Text = "Finish"
        Me.finishbtn.UseVisualStyleBackColor = False
        Me.confirmpasswordtxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.confirmpasswordtxt.Location = New System.Drawing.Point(202, 136)
        Me.confirmpasswordtxt.Name = "confirmpasswordtxt"
        Me.confirmpasswordtxt.Size = New System.Drawing.Size(246, 32)
        Me.confirmpasswordtxt.TabIndex = 152
        Me.confirmpasswordtxt.UseSystemPasswordChar = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 24)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "Confirm Password:"
        Me.newpasswordtxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.newpasswordtxt.Location = New System.Drawing.Point(202, 82)
        Me.newpasswordtxt.Name = "newpasswordtxt"
        Me.newpasswordtxt.Size = New System.Drawing.Size(246, 32)
        Me.newpasswordtxt.TabIndex = 150
        Me.newpasswordtxt.UseSystemPasswordChar = True
        Me.Label117.AutoSize = True
        Me.Label117.BackColor = System.Drawing.Color.Transparent
        Me.Label117.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(99, 86)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(101, 24)
        Me.Label117.TabIndex = 149
        Me.Label117.Text = "Password:"
        Me.oldpasswordtxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.oldpasswordtxt.Location = New System.Drawing.Point(202, 26)
        Me.oldpasswordtxt.Name = "oldpasswordtxt"
        Me.oldpasswordtxt.Size = New System.Drawing.Size(246, 32)
        Me.oldpasswordtxt.TabIndex = 148
        Me.oldpasswordtxt.UseSystemPasswordChar = True
        Me.Label116.AutoSize = True
        Me.Label116.BackColor = System.Drawing.Color.Transparent
        Me.Label116.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(63, 29)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(137, 24)
        Me.Label116.TabIndex = 147
        Me.Label116.Text = "Old Password:"
        Me.idlbl.AutoSize = True
        Me.idlbl.BackColor = System.Drawing.Color.Transparent
        Me.idlbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idlbl.Location = New System.Drawing.Point(24, 218)
        Me.idlbl.Name = "idlbl"
        Me.idlbl.Size = New System.Drawing.Size(28, 24)
        Me.idlbl.TabIndex = 153
        Me.idlbl.Text = "Id"
        Me.idlbl.Visible = False
        Me.showoldpasswordpb.Image = Global.DPWH_Cap2.My.Resources.Resources.eyehidden
        Me.showoldpasswordpb.Location = New System.Drawing.Point(454, 26)
        Me.showoldpasswordpb.Name = "showoldpasswordpb"
        Me.showoldpasswordpb.Size = New System.Drawing.Size(32, 32)
        Me.showoldpasswordpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.showoldpasswordpb.TabIndex = 154
        Me.showoldpasswordpb.TabStop = False
        Me.PictureBox1.Image = Global.DPWH_Cap2.My.Resources.Resources.eyehidden
        Me.PictureBox1.Location = New System.Drawing.Point(454, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 155
        Me.PictureBox1.TabStop = False
        Me.PictureBox2.Image = Global.DPWH_Cap2.My.Resources.Resources.eyehidden
        Me.PictureBox2.Location = New System.Drawing.Point(454, 136)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 156
        Me.PictureBox2.TabStop = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(519, 270)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.showoldpasswordpb)
        Me.Controls.Add(Me.idlbl)
        Me.Controls.Add(Me.confirmpasswordtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newpasswordtxt)
        Me.Controls.Add(Me.Label117)
        Me.Controls.Add(Me.oldpasswordtxt)
        Me.Controls.Add(Me.Label116)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.finishbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "changepassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "changepassword"
        CType(Me.showoldpasswordpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelbtn As Button
    Friend WithEvents finishbtn As Button
    Friend WithEvents confirmpasswordtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents newpasswordtxt As TextBox
    Friend WithEvents Label117 As Label
    Friend WithEvents oldpasswordtxt As TextBox
    Friend WithEvents Label116 As Label
    Friend WithEvents idlbl As Label
    Friend WithEvents showoldpasswordpb As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
