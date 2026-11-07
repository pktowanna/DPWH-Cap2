<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.loginpasswordtxt = New System.Windows.Forms.TextBox()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.loginusernametxt = New System.Windows.Forms.TextBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.registerlbl = New System.Windows.Forms.Label()
        Me.userid = New System.Windows.Forms.Label()
        Me.exitbtn = New System.Windows.Forms.Label()
        Me.forgotpasswordlbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.loginbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(144, 331)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(107, 35)
        Me.loginbtn.TabIndex = 2
        Me.loginbtn.Text = "Log-In"
        Me.loginbtn.UseVisualStyleBackColor = False
        Me.loginpasswordtxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.loginpasswordtxt.Location = New System.Drawing.Point(111, 192)
        Me.loginpasswordtxt.MaxLength = 20
        Me.loginpasswordtxt.Name = "loginpasswordtxt"
        Me.loginpasswordtxt.Size = New System.Drawing.Size(251, 32)
        Me.loginpasswordtxt.TabIndex = 1
        Me.loginpasswordtxt.UseSystemPasswordChar = True
        Me.Label117.AutoSize = True
        Me.Label117.BackColor = System.Drawing.Color.Transparent
        Me.Label117.Enabled = False
        Me.Label117.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.ForeColor = System.Drawing.Color.White
        Me.Label117.Location = New System.Drawing.Point(8, 196)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(101, 24)
        Me.Label117.TabIndex = 156
        Me.Label117.Text = "Password:"
        Me.loginusernametxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.loginusernametxt.Location = New System.Drawing.Point(111, 136)
        Me.loginusernametxt.MaxLength = 20
        Me.loginusernametxt.Name = "loginusernametxt"
        Me.loginusernametxt.Size = New System.Drawing.Size(251, 32)
        Me.loginusernametxt.TabIndex = 0
        Me.Label116.AutoSize = True
        Me.Label116.BackColor = System.Drawing.Color.Transparent
        Me.Label116.Enabled = False
        Me.Label116.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.ForeColor = System.Drawing.Color.White
        Me.Label116.Location = New System.Drawing.Point(2, 140)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(107, 24)
        Me.Label116.TabIndex = 154
        Me.Label116.Text = "Username:"
        Me.registerlbl.AutoSize = True
        Me.registerlbl.BackColor = System.Drawing.Color.Transparent
        Me.registerlbl.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerlbl.ForeColor = System.Drawing.Color.Black
        Me.registerlbl.Location = New System.Drawing.Point(323, 241)
        Me.registerlbl.Name = "registerlbl"
        Me.registerlbl.Size = New System.Drawing.Size(72, 21)
        Me.registerlbl.TabIndex = 3
        Me.registerlbl.Text = "Register"
        Me.userid.AutoSize = True
        Me.userid.BackColor = System.Drawing.Color.Transparent
        Me.userid.Enabled = False
        Me.userid.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid.ForeColor = System.Drawing.Color.Black
        Me.userid.Location = New System.Drawing.Point(322, 64)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(0, 21)
        Me.userid.TabIndex = 159
        Me.userid.Visible = False
        Me.exitbtn.AutoSize = True
        Me.exitbtn.BackColor = System.Drawing.Color.Transparent
        Me.exitbtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.ForeColor = System.Drawing.Color.Black
        Me.exitbtn.Location = New System.Drawing.Point(348, 9)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(52, 24)
        Me.exitbtn.TabIndex = 4
        Me.exitbtn.Text = "EXIT"
        Me.forgotpasswordlbl.AutoSize = True
        Me.forgotpasswordlbl.BackColor = System.Drawing.Color.Transparent
        Me.forgotpasswordlbl.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgotpasswordlbl.ForeColor = System.Drawing.Color.Black
        Me.forgotpasswordlbl.Location = New System.Drawing.Point(116, 241)
        Me.forgotpasswordlbl.Name = "forgotpasswordlbl"
        Me.forgotpasswordlbl.Size = New System.Drawing.Size(116, 21)
        Me.forgotpasswordlbl.TabIndex = 160
        Me.forgotpasswordlbl.Text = "Password Hint"
        Me.PictureBox1.Image = Global.DPWH_Cap2.My.Resources.Resources.eyehidden
        Me.PictureBox1.Location = New System.Drawing.Point(368, 192)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 161
        Me.PictureBox1.TabStop = False
        Me.AcceptButton = Me.loginbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = Global.DPWH_Cap2.My.Resources.Resources.Department_of_Public_Works_and_Highways__DPWH__svg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(406, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.forgotpasswordlbl)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.registerlbl)
        Me.Controls.Add(Me.loginpasswordtxt)
        Me.Controls.Add(Me.Label117)
        Me.Controls.Add(Me.loginusernametxt)
        Me.Controls.Add(Me.Label116)
        Me.Controls.Add(Me.loginbtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginbtn As Button
    Friend WithEvents loginpasswordtxt As TextBox
    Friend WithEvents Label117 As Label
    Friend WithEvents loginusernametxt As TextBox
    Friend WithEvents Label116 As Label
    Friend WithEvents registerlbl As Label
    Friend WithEvents userid As Label
    Friend WithEvents exitbtn As Label
    Friend WithEvents forgotpasswordlbl As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
