<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employees
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
        Me.closebtn = New System.Windows.Forms.Button()
        Me.updateemployeebtn = New System.Windows.Forms.Button()
        Me.employeedesignationtxt = New System.Windows.Forms.TextBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.employeelastnametxt = New System.Windows.Forms.TextBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.employeemiddleinitialtxt = New System.Windows.Forms.TextBox()
        Me.employeefirstnametxt = New System.Windows.Forms.TextBox()
        Me.employeeidlbl = New System.Windows.Forms.Label()
        Me.employeesdgv = New System.Windows.Forms.DataGridView()
        Me.employeeid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeedesignation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.employeesearchtxt = New System.Windows.Forms.TextBox()
        Me.addnewemployeebtn = New System.Windows.Forms.Button()
        CType(Me.employeesdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.closebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closebtn.ForeColor = System.Drawing.Color.White
        Me.closebtn.Location = New System.Drawing.Point(31, 543)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(75, 35)
        Me.closebtn.TabIndex = 185
        Me.closebtn.Text = "Back"
        Me.closebtn.UseVisualStyleBackColor = False
        Me.updateemployeebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.updateemployeebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateemployeebtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateemployeebtn.ForeColor = System.Drawing.Color.White
        Me.updateemployeebtn.Location = New System.Drawing.Point(866, 543)
        Me.updateemployeebtn.Name = "updateemployeebtn"
        Me.updateemployeebtn.Size = New System.Drawing.Size(107, 35)
        Me.updateemployeebtn.TabIndex = 184
        Me.updateemployeebtn.Text = "Update"
        Me.updateemployeebtn.UseVisualStyleBackColor = False
        Me.employeedesignationtxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.employeedesignationtxt.Location = New System.Drawing.Point(385, 96)
        Me.employeedesignationtxt.MaxLength = 40
        Me.employeedesignationtxt.Name = "employeedesignationtxt"
        Me.employeedesignationtxt.Size = New System.Drawing.Size(284, 32)
        Me.employeedesignationtxt.TabIndex = 175
        Me.Label116.AutoSize = True
        Me.Label116.BackColor = System.Drawing.Color.Transparent
        Me.Label116.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(256, 99)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(123, 24)
        Me.Label116.TabIndex = 174
        Me.Label116.Text = "Designation:"
        Me.employeelastnametxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.employeelastnametxt.Location = New System.Drawing.Point(551, 39)
        Me.employeelastnametxt.MaxLength = 40
        Me.employeelastnametxt.Name = "employeelastnametxt"
        Me.employeelastnametxt.Size = New System.Drawing.Size(442, 32)
        Me.employeelastnametxt.TabIndex = 173
        Me.Label106.AutoSize = True
        Me.Label106.BackColor = System.Drawing.Color.Transparent
        Me.Label106.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.Label106.Location = New System.Drawing.Point(751, 16)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(89, 21)
        Me.Label106.TabIndex = 172
        Me.Label106.Text = "Last Name"
        Me.Label107.AutoSize = True
        Me.Label107.BackColor = System.Drawing.Color.Transparent
        Me.Label107.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.Label107.Location = New System.Drawing.Point(453, 16)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(105, 21)
        Me.Label107.TabIndex = 171
        Me.Label107.Text = "Middle Initial"
        Me.Label108.AutoSize = True
        Me.Label108.BackColor = System.Drawing.Color.Transparent
        Me.Label108.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.Location = New System.Drawing.Point(145, 16)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(91, 21)
        Me.Label108.TabIndex = 170
        Me.Label108.Text = "Frist Name"
        Me.employeemiddleinitialtxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.employeemiddleinitialtxt.Location = New System.Drawing.Point(477, 39)
        Me.employeemiddleinitialtxt.MaxLength = 1
        Me.employeemiddleinitialtxt.Name = "employeemiddleinitialtxt"
        Me.employeemiddleinitialtxt.Size = New System.Drawing.Size(56, 32)
        Me.employeemiddleinitialtxt.TabIndex = 169
        Me.employeefirstnametxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.employeefirstnametxt.Location = New System.Drawing.Point(12, 39)
        Me.employeefirstnametxt.MaxLength = 40
        Me.employeefirstnametxt.Name = "employeefirstnametxt"
        Me.employeefirstnametxt.Size = New System.Drawing.Size(445, 32)
        Me.employeefirstnametxt.TabIndex = 168
        Me.employeeidlbl.AutoSize = True
        Me.employeeidlbl.BackColor = System.Drawing.Color.Transparent
        Me.employeeidlbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeidlbl.Location = New System.Drawing.Point(12, 99)
        Me.employeeidlbl.Name = "employeeidlbl"
        Me.employeeidlbl.Size = New System.Drawing.Size(31, 24)
        Me.employeeidlbl.TabIndex = 186
        Me.employeeidlbl.Text = "ID"
        Me.employeeidlbl.Visible = False
        Me.employeesdgv.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employeesdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.employeesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeesdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employeeid, Me.employeename, Me.employeedesignation})
        Me.employeesdgv.Location = New System.Drawing.Point(31, 199)
        Me.employeesdgv.Name = "employeesdgv"
        Me.employeesdgv.RowHeadersWidth = 51
        Me.employeesdgv.RowTemplate.Height = 24
        Me.employeesdgv.Size = New System.Drawing.Size(942, 326)
        Me.employeesdgv.TabIndex = 187
        Me.employeeid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.employeeid.HeaderText = "Document ID"
        Me.employeeid.MinimumWidth = 90
        Me.employeeid.Name = "employeeid"
        Me.employeeid.ReadOnly = True
        Me.employeeid.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.employeeid.Visible = False
        Me.employeeid.Width = 125
        Me.employeename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.employeename.HeaderText = "Employee Name"
        Me.employeename.MinimumWidth = 6
        Me.employeename.Name = "employeename"
        Me.employeename.ReadOnly = True
        Me.employeedesignation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.employeedesignation.HeaderText = "Employee Designation"
        Me.employeedesignation.MinimumWidth = 6
        Me.employeedesignation.Name = "employeedesignation"
        Me.employeedesignation.ReadOnly = True
        Me.employeedesignation.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employeedesignation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(122, 165)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 24)
        Me.Label24.TabIndex = 189
        Me.Label24.Text = "Search: "
        Me.employeesearchtxt.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.employeesearchtxt.Location = New System.Drawing.Point(205, 161)
        Me.employeesearchtxt.Name = "employeesearchtxt"
        Me.employeesearchtxt.Size = New System.Drawing.Size(667, 32)
        Me.employeesearchtxt.TabIndex = 188
        Me.addnewemployeebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.addnewemployeebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addnewemployeebtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addnewemployeebtn.ForeColor = System.Drawing.Color.White
        Me.addnewemployeebtn.Location = New System.Drawing.Point(690, 94)
        Me.addnewemployeebtn.Name = "addnewemployeebtn"
        Me.addnewemployeebtn.Size = New System.Drawing.Size(107, 35)
        Me.addnewemployeebtn.TabIndex = 190
        Me.addnewemployeebtn.Text = "Add New"
        Me.addnewemployeebtn.UseVisualStyleBackColor = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 590)
        Me.Controls.Add(Me.addnewemployeebtn)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.employeesearchtxt)
        Me.Controls.Add(Me.employeesdgv)
        Me.Controls.Add(Me.employeeidlbl)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.updateemployeebtn)
        Me.Controls.Add(Me.employeedesignationtxt)
        Me.Controls.Add(Me.Label116)
        Me.Controls.Add(Me.employeelastnametxt)
        Me.Controls.Add(Me.Label106)
        Me.Controls.Add(Me.Label107)
        Me.Controls.Add(Me.Label108)
        Me.Controls.Add(Me.employeemiddleinitialtxt)
        Me.Controls.Add(Me.employeefirstnametxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employees"
        CType(Me.employeesdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closebtn As Button
    Friend WithEvents updateemployeebtn As Button
    Friend WithEvents employeedesignationtxt As TextBox
    Friend WithEvents Label116 As Label
    Friend WithEvents employeelastnametxt As TextBox
    Friend WithEvents Label106 As Label
    Friend WithEvents Label107 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents employeemiddleinitialtxt As TextBox
    Friend WithEvents employeefirstnametxt As TextBox
    Friend WithEvents employeeidlbl As Label
    Friend WithEvents employeesdgv As DataGridView
    Friend WithEvents employeeid As DataGridViewTextBoxColumn
    Friend WithEvents employeename As DataGridViewTextBoxColumn
    Friend WithEvents employeedesignation As DataGridViewTextBoxColumn
    Friend WithEvents Label24 As Label
    Friend WithEvents employeesearchtxt As TextBox
    Friend WithEvents addnewemployeebtn As Button
End Class
