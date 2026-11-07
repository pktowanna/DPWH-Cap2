<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStock
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
        Me.Label73 = New System.Windows.Forms.Label()
        Me.addstockdatedtp = New System.Windows.Forms.DateTimePicker()
        Me.addstockquantitytxt = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.addstockreorderpointtxt = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.addstockcancelbtn = New System.Windows.Forms.Button()
        Me.addstockfinishbtn = New System.Windows.Forms.Button()
        Me.addstockstocknolbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        Me.Label73.AutoSize = True
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(279, 34)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(66, 24)
        Me.Label73.TabIndex = 85
        Me.Label73.Text = "Date: "
        Me.addstockdatedtp.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addstockdatedtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.addstockdatedtp.Location = New System.Drawing.Point(347, 30)
        Me.addstockdatedtp.Name = "addstockdatedtp"
        Me.addstockdatedtp.Size = New System.Drawing.Size(200, 32)
        Me.addstockdatedtp.TabIndex = 84
        Me.addstockquantitytxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.addstockquantitytxt.Location = New System.Drawing.Point(126, 30)
        Me.addstockquantitytxt.Name = "addstockquantitytxt"
        Me.addstockquantitytxt.Size = New System.Drawing.Size(134, 32)
        Me.addstockquantitytxt.TabIndex = 83
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(25, 34)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(99, 24)
        Me.Label71.TabIndex = 82
        Me.Label71.Text = "Quantity: "
        Me.addstockreorderpointtxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.addstockreorderpointtxt.Location = New System.Drawing.Point(180, 78)
        Me.addstockreorderpointtxt.Name = "addstockreorderpointtxt"
        Me.addstockreorderpointtxt.Size = New System.Drawing.Size(367, 32)
        Me.addstockreorderpointtxt.TabIndex = 87
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(21, 82)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(157, 24)
        Me.Label69.TabIndex = 86
        Me.Label69.Text = "Re-order Point:  "
        Me.addstockcancelbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.addstockcancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addstockcancelbtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addstockcancelbtn.ForeColor = System.Drawing.Color.White
        Me.addstockcancelbtn.Location = New System.Drawing.Point(170, 132)
        Me.addstockcancelbtn.Name = "addstockcancelbtn"
        Me.addstockcancelbtn.Size = New System.Drawing.Size(98, 35)
        Me.addstockcancelbtn.TabIndex = 89
        Me.addstockcancelbtn.Text = "Cancel"
        Me.addstockcancelbtn.UseVisualStyleBackColor = False
        Me.addstockfinishbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.addstockfinishbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addstockfinishbtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addstockfinishbtn.ForeColor = System.Drawing.Color.White
        Me.addstockfinishbtn.Location = New System.Drawing.Point(283, 132)
        Me.addstockfinishbtn.Name = "addstockfinishbtn"
        Me.addstockfinishbtn.Size = New System.Drawing.Size(107, 35)
        Me.addstockfinishbtn.TabIndex = 88
        Me.addstockfinishbtn.Text = "Finish"
        Me.addstockfinishbtn.UseVisualStyleBackColor = False
        Me.addstockstocknolbl.AutoSize = True
        Me.addstockstocknolbl.BackColor = System.Drawing.Color.Transparent
        Me.addstockstocknolbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addstockstocknolbl.Location = New System.Drawing.Point(437, 136)
        Me.addstockstocknolbl.Name = "addstockstocknolbl"
        Me.addstockstocknolbl.Size = New System.Drawing.Size(0, 24)
        Me.addstockstocknolbl.TabIndex = 90
        Me.addstockstocknolbl.Visible = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(577, 186)
        Me.Controls.Add(Me.addstockstocknolbl)
        Me.Controls.Add(Me.addstockcancelbtn)
        Me.Controls.Add(Me.addstockfinishbtn)
        Me.Controls.Add(Me.addstockreorderpointtxt)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.addstockdatedtp)
        Me.Controls.Add(Me.addstockquantitytxt)
        Me.Controls.Add(Me.Label71)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddStock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label73 As Label
    Friend WithEvents addstockdatedtp As DateTimePicker
    Friend WithEvents addstockquantitytxt As TextBox
    Friend WithEvents Label71 As Label
    Friend WithEvents addstockreorderpointtxt As TextBox
    Friend WithEvents Label69 As Label
    Friend WithEvents addstockcancelbtn As Button
    Friend WithEvents addstockfinishbtn As Button
    Friend WithEvents addstockstocknolbl As Label
End Class
