<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QR
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
        Me.qrexitbtn = New System.Windows.Forms.Button()
        Me.qrsavebtn = New System.Windows.Forms.Button()
        Me.qrpic = New System.Windows.Forms.PictureBox()
        Me.qrlabellbl = New System.Windows.Forms.Label()
        Me.printqrbtn = New System.Windows.Forms.Button()
        CType(Me.qrpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.qrexitbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.qrexitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.qrexitbtn.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.qrexitbtn.ForeColor = System.Drawing.Color.White
        Me.qrexitbtn.Location = New System.Drawing.Point(12, 303)
        Me.qrexitbtn.Name = "qrexitbtn"
        Me.qrexitbtn.Size = New System.Drawing.Size(54, 35)
        Me.qrexitbtn.TabIndex = 91
        Me.qrexitbtn.Text = "Exit"
        Me.qrexitbtn.UseVisualStyleBackColor = False
        Me.qrsavebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.qrsavebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.qrsavebtn.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.qrsavebtn.ForeColor = System.Drawing.Color.White
        Me.qrsavebtn.Location = New System.Drawing.Point(99, 303)
        Me.qrsavebtn.Name = "qrsavebtn"
        Me.qrsavebtn.Size = New System.Drawing.Size(144, 35)
        Me.qrsavebtn.TabIndex = 90
        Me.qrsavebtn.Text = "Save as Image"
        Me.qrsavebtn.UseVisualStyleBackColor = False
        Me.qrpic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.qrpic.Location = New System.Drawing.Point(67, 43)
        Me.qrpic.Name = "qrpic"
        Me.qrpic.Size = New System.Drawing.Size(220, 220)
        Me.qrpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.qrpic.TabIndex = 92
        Me.qrpic.TabStop = False
        Me.qrlabellbl.AutoSize = True
        Me.qrlabellbl.BackColor = System.Drawing.Color.Transparent
        Me.qrlabellbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qrlabellbl.Location = New System.Drawing.Point(93, 266)
        Me.qrlabellbl.Name = "qrlabellbl"
        Me.qrlabellbl.Size = New System.Drawing.Size(0, 24)
        Me.qrlabellbl.TabIndex = 93
        Me.qrlabellbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.qrlabellbl.Visible = False
        Me.printqrbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.printqrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printqrbtn.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.printqrbtn.ForeColor = System.Drawing.Color.White
        Me.printqrbtn.Location = New System.Drawing.Point(277, 303)
        Me.printqrbtn.Name = "printqrbtn"
        Me.printqrbtn.Size = New System.Drawing.Size(61, 35)
        Me.printqrbtn.TabIndex = 94
        Me.printqrbtn.Text = "Print"
        Me.printqrbtn.UseVisualStyleBackColor = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(350, 350)
        Me.Controls.Add(Me.printqrbtn)
        Me.Controls.Add(Me.qrlabellbl)
        Me.Controls.Add(Me.qrpic)
        Me.Controls.Add(Me.qrexitbtn)
        Me.Controls.Add(Me.qrsavebtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QR"
        CType(Me.qrpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents qrexitbtn As Button
    Friend WithEvents qrsavebtn As Button
    Friend WithEvents qrpic As PictureBox
    Friend WithEvents qrlabellbl As Label
    Friend WithEvents printqrbtn As Button
End Class
