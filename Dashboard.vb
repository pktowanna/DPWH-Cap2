
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportAppServer.DataDefModel
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Drawing
Imports QRCoder
Imports System.Text
Imports modulecodes
Imports System.IO
Imports System.Diagnostics
Imports System.Text.RegularExpressions
Imports System.Linq
Imports ZXing




Public Class Dashboard

    Private hoveredNode As TreeNode = Nothing
    Private lastClickTime As DateTime = DateTime.MinValue
    Private lastClickedNode As TreeNode = Nothing
    Private WithEvents AutoRefreshTimer As New Timer()


    Public Sub TreeViewDesign()
        With TreeView1
            .DrawMode = TreeViewDrawMode.OwnerDrawAll
            .ShowLines = False
            .ShowRootLines = False
            .ShowPlusMinus = True
            .FullRowSelect = True
            .BorderStyle = BorderStyle.None
            .ItemHeight = 40
        End With

        RemoveHandler TreeView1.DrawNode, AddressOf TreeView1_DrawNode
        AddHandler TreeView1.DrawNode, AddressOf TreeView1_DrawNode

        RemoveHandler TreeView1.NodeMouseClick, AddressOf TreeView1_NodeMouseClick
        AddHandler TreeView1.NodeMouseClick, AddressOf TreeView1_NodeMouseClick

        RemoveHandler TreeView1.NodeMouseDoubleClick, AddressOf TreeView1_NodeMouseDoubleClick
        AddHandler TreeView1.NodeMouseDoubleClick, AddressOf TreeView1_NodeMouseDoubleClick

        RemoveHandler TreeView1.MouseMove, AddressOf TreeView1_MouseMove
        AddHandler TreeView1.MouseMove, AddressOf TreeView1_MouseMove

        RemoveHandler TreeView1.MouseLeave, AddressOf TreeView1_MouseLeave
        AddHandler TreeView1.MouseLeave, AddressOf TreeView1_MouseLeave
    End Sub

    Public Sub TabControlDesign()
        maintbc.Appearance = TabAppearance.FlatButtons
        maintbc.ItemSize = New Size(0, 1)
        maintbc.SizeMode = TabSizeMode.Fixed
    End Sub

    Private Sub ClearDatePicker()
        pardateaquireddtm.Format = DateTimePickerFormat.Custom
        pardateaquireddtm.CustomFormat = " "
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSupplyAndMaterials(Me)
        TreeViewDesign()
        TabControlDesign()
        LoadAutoCompleteData()
        MakeLabelCircular(notificationnumberlbl)
        RefreshAllDashboardCounters(Me)
        LoadOICInfo()
        LoadEquipmentCounts(Me)
        LoadEquipmentsData(Me)
        LoadRecentActivity(Me)
        LoadGasData(Me)
        LoadRISData(Me)
        ClearDatePicker()
        SetAllNextNumbers()
        LoadBackupPath()
        LoadEquipmentActivity(Me)
        LoadAccounts()
        ApplyRoundedStyleToAllButtons(Me)
        Notification()
        RefreshNotification()
        EnableHandCursor()
        LoadEmployeesForSuggestion()
        InitializeEmployeeSuggestions()
        risdgv.AllowUserToAddRows = False
        SetDatagridRows()
        SetDatagrids(Me)




        Select Case userlvl.Text
            Case "Client"
                ClientLogIn()
            Case "UserAdmin"
                UserAdminLogIn()
            Case "Admin"
                AdminLogIn()
        End Select

        RunAutoRefreshTasks()
        AutoRefreshTimer.Interval = 10 * 60 * 1000
        AutoRefreshTimer.Start()
        prspurposecmb.SelectedIndex = 3

    End Sub

    Public Sub SetDatagridRows()

        Dim grids As DataGridView() = {
        requestsdgv,
        equipmentsdgv,
        gasviewdgv,
        risdgv,
        pardescriptiondgv,
        pardgv,
        rrspdgv,
        prsdgv,
        accountdgv,
        icsdgv,
        equipmentactivitydgv
    }

        For Each dgv As DataGridView In grids

            With dgv
                .EnableHeadersVisualStyles = False
                .RowTemplate.Height = 35
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            End With

            Dim baseFont As New Font("Bahnschrift", 10.8F, FontStyle.Regular)

            dgv.DefaultCellStyle = New DataGridViewCellStyle With {
            .Font = baseFont,
            .Alignment = DataGridViewContentAlignment.MiddleLeft,
            .SelectionBackColor = Color.FromArgb(225, 241, 253),
            .SelectionForeColor = Color.Black
        }

            dgv.RowsDefaultCellStyle = New DataGridViewCellStyle With {
            .Font = baseFont,
            .BackColor = Color.White,
            .SelectionBackColor = Color.FromArgb(225, 241, 253),
            .SelectionForeColor = Color.Black,
            .Alignment = DataGridViewContentAlignment.MiddleLeft
        }

            dgv.AlternatingRowsDefaultCellStyle = New DataGridViewCellStyle With {
            .Font = baseFont,
            .BackColor = Color.FromArgb(245, 245, 245),
            .SelectionBackColor = Color.FromArgb(225, 241, 253),
            .SelectionForeColor = Color.Black,
            .Alignment = DataGridViewContentAlignment.MiddleLeft
        }

            dgv.ColumnHeadersDefaultCellStyle = New DataGridViewCellStyle With {
            .Font = New Font("Bahnschrift", 11.0F, FontStyle.Bold),
            .BackColor = Color.White,
            .ForeColor = Color.Black,
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        }


            For Each col As DataGridViewColumn In dgv.Columns
                If TypeOf col Is DataGridViewButtonColumn Then
                    col.DefaultCellStyle.Font = baseFont
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    col.DefaultCellStyle.ForeColor = Color.Black
                    CType(col, DataGridViewButtonColumn).FlatStyle = FlatStyle.Flat
                End If
            Next

        Next

    End Sub




    Private Sub RunAutoRefreshTasks()
        RefreshNotification()
        LoadEquipmentCounts(Me)
        LoadEquipmentsData(Me)
        LoadRecentActivity(Me)
        LoadGasData(Me)
        LoadRISData(Me)
        LoadEquipmentActivity(Me)
        LoadSupplyAndMaterials(Me)
        RefreshAllDashboardCounters(Me)
        LoadAutoCompleteData()
        LoadAccounts()
        ApplyRoundedStyleToAllButtons(Me)
        Notification()


    End Sub
    Private Sub RefreshAll()
        ApplyRoundedStyleToAllButtons(Form1)
        supplyandmaterialstypecmb.SelectedIndex = 0
        requeststypecmb.SelectedIndex = 0
        activitytypecmb.SelectedIndex = 0
        equipmentstypecmb.SelectedIndex = 0
        rangecmb.SelectedIndex = 0
        equipmentactivitytypecmb.SelectedIndex = 0
        requestsfromdtp.Value = Date.Now.AddMonths(-1)
        gasfromdtp.Value = Date.Now.AddMonths(-1)
        equipmentactivityfromdtm.Value = Date.Now.AddMonths(-1)
        LoadSupplyAndMaterials(Me)
        TreeViewDesign()
        TabControlDesign()
        LoadAutoCompleteData()
        MakeLabelCircular(notificationnumberlbl)
        RefreshAllDashboardCounters(Me)
        LoadOICInfo()
        LoadEquipmentCounts(Me)
        LoadEquipmentsData(Me)
        LoadSupplyAndMaterials(Me)
        LoadRecentActivity(Me)
        LoadGasData(Me)
        LoadRISData(Me)
        ClearDatePicker()
        LoadBackupPath()
        LoadEquipmentActivity(Me)
        LoadAccounts()
        ApplyRoundedStyleToAllButtons(Me)
        Notification()
        RefreshNotification()
        risdgv.AllowUserToAddRows = False

        Select Case userlvl.Text
            Case "Client"
                ClientLogIn()
            Case "UserAdmin"
                UserAdminLogIn()
            Case "Admin"
                AdminLogIn()
        End Select

        RunAutoRefreshTasks()
        AutoRefreshTimer.Interval = 10 * 60 * 1000
        AutoRefreshTimer.Start()
        prspurposecmb.SelectedIndex = 3

    End Sub


    Private Sub TreeView1_DrawNode(sender As Object, e As DrawTreeNodeEventArgs)

        Dim tree As TreeView = CType(sender, TreeView)
        Dim node As TreeNode = e.Node
        Dim selectedNode As TreeNode = tree.SelectedNode
        Dim isSelected As Boolean = (node Is selectedNode)
        Dim isHovered As Boolean = (hoveredNode Is node)

        Dim isDisabled As Boolean = (node.Tag IsNot Nothing AndAlso node.Tag.ToString().ToLower() = "disabled")

        Dim sidebarColor As Color = Color.FromArgb(33, 29, 112)
        Dim selectedColor As Color = Color.FromArgb(23, 19, 92)
        Dim hoverColor As Color = Color.FromArgb(55, 51, 140)
        Dim textColor As Color = Color.White
        Dim subItemColor As Color = Color.White
        Dim disabledColor As Color = Color.Gray

        Dim backColor As Color
        If isDisabled Then
            backColor = sidebarColor
        Else
            backColor = If(isSelected, selectedColor, If(isHovered, hoverColor, sidebarColor))
        End If

        Using backBrush As Brush = New SolidBrush(backColor)
            e.Graphics.FillRectangle(backBrush, e.Bounds)
        End Using

        Dim font As Font
        Dim textCol As Color

        If isDisabled Then
            font = New Font(tree.Font, FontStyle.Italic)
            textCol = disabledColor
        Else
            font = If(isSelected, New Font(tree.Font, FontStyle.Bold), tree.Font)
            textCol = If(isSelected, Color.White, If(node.Level = 0, textColor, subItemColor))
        End If

        Dim indent As Integer = node.Level * 20
        Dim textX As Integer = e.Bounds.Left + indent + 10
        Dim textY As Integer = e.Bounds.Top + (e.Bounds.Height - font.Height) \ 2
        Dim textBounds As New Rectangle(textX, textY, e.Bounds.Width - textX - 30, font.Height)

        If node.Level > 0 Then
            Dim lineX As Integer = e.Bounds.Left + indent + 5
            e.Graphics.DrawLine(Pens.White, lineX, e.Bounds.Top + 8, lineX, e.Bounds.Bottom - 8)
        End If

        TextRenderer.DrawText(e.Graphics, node.Text, font, textBounds, textCol, TextFormatFlags.NoPrefix)

        If node.Nodes.Count > 0 Then
            Dim expandIcon As Image = If(
            node.IsExpanded,
            If(isSelected, My.Resources.arrowmaxs, My.Resources.arrowmax),
            If(isSelected, My.Resources.arrowmins, My.Resources.arrowmin)
        )

            Dim iconSize As Size = New Size(16, 16)
            Dim iconXRight As Integer = tree.Width - iconSize.Width - 10
            Dim iconYRight As Integer = e.Bounds.Top + (e.Bounds.Height - iconSize.Height) \ 2

            If isDisabled Then
                Dim grayMatrix As New Imaging.ColorMatrix(New Single()() {
                New Single() {0.3F, 0.3F, 0.3F, 0, 0},
                New Single() {0.3F, 0.3F, 0.3F, 0, 0},
                New Single() {0.3F, 0.3F, 0.3F, 0, 0},
                New Single() {0, 0, 0, 1, 0},
                New Single() {0, 0, 0, 0, 1}
            })

                Dim attrs As New Imaging.ImageAttributes()
                attrs.SetColorMatrix(grayMatrix)
                e.Graphics.DrawImage(expandIcon,
                                 New Rectangle(iconXRight, iconYRight, iconSize.Width, iconSize.Height),
                                 0, 0, expandIcon.Width, expandIcon.Height,
                                 GraphicsUnit.Pixel, attrs)
            Else
                e.Graphics.DrawImage(expandIcon, New Rectangle(iconXRight, iconYRight, iconSize.Width, iconSize.Height))
            End If
        End If
    End Sub


    Private Sub TreeView1_MouseMove(sender As Object, e As MouseEventArgs)
        Dim currentNode As TreeNode = TreeView1.GetNodeAt(e.Location)

        If currentNode IsNot Nothing AndAlso currentNode.Tag IsNot Nothing AndAlso currentNode.Tag.ToString().ToLower() = "disabled" Then
            If hoveredNode IsNot Nothing Then
                hoveredNode = Nothing
                TreeView1.Invalidate()
            End If
            Exit Sub
        End If

        If currentNode IsNot hoveredNode Then
            hoveredNode = currentNode
            TreeView1.Invalidate()
        End If
    End Sub



    Private Sub TreeView1_MouseLeave(sender As Object, e As EventArgs)
        hoveredNode = Nothing
        TreeView1.Invalidate()
    End Sub


    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)

        If e.Node.Tag IsNot Nothing AndAlso e.Node.Tag.ToString() = "disabled" Then
            Return
        End If

        lastClickTime = DateTime.Now
        lastClickedNode = e.Node

        Dim key As String = If(String.IsNullOrWhiteSpace(e.Node.Name), e.Node.Text, e.Node.Name).Trim().ToLower()

        If e.Node.Nodes.Count > 0 Then
            For Each parent As TreeNode In TreeView1.Nodes
                If parent IsNot e.Node Then parent.Collapse()
            Next
            e.Node.Toggle()
            Exit Sub
        End If

        If e.Node.Nodes.Count = 0 Then
            TreeView1.SelectedNode = e.Node
            HandleNodeSelection(e.Node)
        End If
    End Sub




    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs)
        If e.Node.Tag IsNot Nothing AndAlso e.Node.Tag.ToString() = "disabled" Then
            Return
        End If

        Dim key As String = If(String.IsNullOrWhiteSpace(e.Node.Name), e.Node.Text, e.Node.Name).Trim().ToLower()

        If e.Node.Nodes.Count > 0 Then
            For Each parent As TreeNode In TreeView1.Nodes
                If parent IsNot e.Node Then
                    parent.Collapse()
                End If
            Next

            e.Node.Expand()

            Dim firstChild As TreeNode = e.Node.Nodes.Cast(Of TreeNode)().FirstOrDefault()
            If firstChild IsNot Nothing Then
                TreeView1.SelectedNode = firstChild
                HandleNodeSelection(firstChild)
            End If
        End If

        If e.Node.Nodes.Count = 0 Then
            TreeView1.SelectedNode = e.Node
            HandleNodeSelection(e.Node)
        End If
    End Sub


    Private Sub TreeView1_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
        If e.Node.Tag IsNot Nothing AndAlso e.Node.Tag.ToString() = "disabled" Then
            e.Cancel = True
        End If
    End Sub

    Private Sub MakeLabelCircular(lbl As Label)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, lbl.Width, lbl.Height)
        lbl.Region = New Region(path)
        lbl.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub HandleNodeSelection(node As TreeNode)
        Dim key As String = If(String.IsNullOrWhiteSpace(node.Name), node.Text, node.Name).Trim().ToLower()

        Select Case key

            Case "recenttransactionstv"
                maintbc.SelectedTab = TabPage1

            Case "viewrequisition"
                maintbc.SelectedTab = requeststab
            Case "newsupplyrequest"
                maintbc.SelectedTab = ristab

            Case "samviewsupply"
                maintbc.SelectedTab = supplyandmaterialstab
            Case "addnewsupply"
                maintbc.SelectedTab = newstocktab

            Case "equipmentactivity"
                maintbc.SelectedTab = equipmentactivitytab
            Case "viewequipments"
                maintbc.SelectedTab = equipmentstab
            Case "addnewequipment"
                maintbc.SelectedTab = parsignaturestab
            Case "equipmentout"
                maintbc.SelectedTab = icsdetailstab

            Case "viewgastransactions"
                maintbc.SelectedTab = gastab
            Case "newgassliprequest"
                maintbc.SelectedTab = gasdetailstab

            Case "myaccount"
                maintbc.SelectedTab = accountsettingstab
            Case "systemsettings"
                maintbc.SelectedTab = systemsettings
            Case "usersettings"
                maintbc.SelectedTab = usersettings
        End Select
    End Sub


    Private Sub SelectTab(key As String)
        key = key.Trim().ToLower()


        Dim targetNode As TreeNode = TreeView1.Nodes.Cast(Of TreeNode)() _
                                 .SelectMany(Function(n) n.Nodes.Cast(Of TreeNode)()) _
                                 .FirstOrDefault(Function(n) (If(String.IsNullOrWhiteSpace(n.Name), n.Text, n.Name).Trim().ToLower()) = key)

        If targetNode IsNot Nothing Then

            TreeView1.SelectedNode = targetNode
            TreeView1.Invalidate()
            HandleNodeSelection(targetNode)
        Else

            Select Case key
                Case "recenttransactionstv" : maintbc.SelectedTab = TabPage1
                Case "viewrequisition" : maintbc.SelectedTab = requeststab
                Case "newsupplyrequest" : maintbc.SelectedTab = ristab
                Case "samviewsupply" : maintbc.SelectedTab = supplyandmaterialstab
                Case "addnewsupply" : maintbc.SelectedTab = newstocktab
                Case "equipmentactivity" : maintbc.SelectedTab = equipmentactivitytab
                Case "viewequipments" : maintbc.SelectedTab = equipmentstab
                Case "addnewequipment" : maintbc.SelectedTab = parsignaturestab
                Case "equipmentout" : maintbc.SelectedTab = icsdetailstab
                Case "viewgastransactions" : maintbc.SelectedTab = gastab
                Case "newgassliprequest" : maintbc.SelectedTab = gasdetailstab
                Case "myaccount" : maintbc.SelectedTab = accountsettingstab
            End Select
        End If
    End Sub


    Public Sub AdminLogIn()
        Try
            For Each node As TreeNode In TreeView1.Nodes
                If node.Name.ToLower() = "accountsettings" Then
                    Dim childNodesToRemove As New List(Of TreeNode)

                    For Each child As TreeNode In node.Nodes
                        If child.Name.ToLower() = "usersettings" Then
                            childNodesToRemove.Add(child)
                        End If
                    Next

                    For Each childNode In childNodesToRemove
                        node.Nodes.Remove(childNode)
                    Next
                End If

                node.ForeColor = SystemColors.WindowText
                node.NodeFont = New Font(TreeView1.Font, FontStyle.Regular)
                node.Tag = "enabled"

                For Each child As TreeNode In node.Nodes
                    child.ForeColor = SystemColors.WindowText
                    child.NodeFont = New Font(TreeView1.Font, FontStyle.Regular)
                    child.Tag = "enabled"
                Next
            Next

            risdgv.Columns("ris_releasedquantity").ReadOnly = False
            risdgv.Columns("ris_instock").ReadOnly = False
            risdgv.Columns("ris_outofstock").ReadOnly = False
            risdgv.Columns("ris_qtybalance").Visible = True
            Label119.Visible = False
            accounttypecmb.Visible = False
            accountdgv.Visible = False
            Label36.Visible = False
            addofficerinchargebtn.Visible = False
            addemployeesbtn.Visible = True
            SetupRIS_CheckBehavior()

        Catch ex As Exception
            MessageBox.Show("Error applying AdminLogIn settings: " & ex.Message)
        End Try
    End Sub

    Public Sub UserAdminLogIn()
        Try
            Dim nodesToRemove As New List(Of TreeNode)

            For Each node As TreeNode In TreeView1.Nodes
                If node.Name.ToLower() <> "accountsettings" Then
                    nodesToRemove.Add(node)
                Else
                    For Each child As TreeNode In node.Nodes
                        child.ForeColor = SystemColors.WindowText
                        child.NodeFont = New Font(TreeView1.Font, FontStyle.Regular)
                        child.Tag = "enabled"
                    Next

                End If
            Next

            For Each node In nodesToRemove
                TreeView1.Nodes.Remove(node)
            Next

            accountrestoredatabasebtn.Visible = False
            TreeView1.Refresh()

            Dim tab As TabPage = maintbc.TabPages.Cast(Of TabPage)().FirstOrDefault(Function(t) t.Name = "accountsettingstab")
            If tab IsNot Nothing Then maintbc.SelectTab(tab)

        Catch ex As Exception
            MessageBox.Show("Error applying UserAdminLogIn settings: " & ex.Message)
        End Try
    End Sub






    Public Sub ClientLogIn()
        Try
            Dim connStr As String = GlobalConnectionString
            Dim accessValue As Integer = 0

            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Dim accessQuery As String = "SELECT access FROM account WHERE ID = @id"
                Using cmd As New MySqlCommand(accessQuery, conn)
                    cmd.Parameters.AddWithValue("@id", userid.Text.Trim())
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        accessValue = Convert.ToInt32(result)
                    End If
                End Using
            End Using

            If accessValue = 1 Then
                viewsupplylistbtn.Visible = True
            End If


            Dim disableList As String() = {"dashboard", "supplyandmaterialstv", "equipments", "gas"}

            Dim nodesToRemove As New List(Of TreeNode)

            For Each node As TreeNode In TreeView1.Nodes
                If disableList.Contains(node.Name.ToLower()) Then
                    nodesToRemove.Add(node)
                ElseIf node.Name.ToLower() = "requests" Then
                    Dim childNodesToRemove As New List(Of TreeNode)
                    For Each child As TreeNode In node.Nodes
                        Select Case child.Name.ToLower()
                            Case "viewrequisition"
                                childNodesToRemove.Add(child)
                            Case "newsupplyrequest"
                        End Select
                    Next
                    For Each childNode In childNodesToRemove
                        node.Nodes.Remove(childNode)
                    Next

                ElseIf node.Name.ToLower() = "accountsettings" Then
                    Dim childNodesToRemove As New List(Of TreeNode)

                    For Each child As TreeNode In node.Nodes
                        If child.Name.ToLower() = "usersettings" OrElse child.Name.ToLower() = "systemsettings" Then
                            childNodesToRemove.Add(child)
                        End If
                    Next

                    For Each childNode In childNodesToRemove
                        node.Nodes.Remove(childNode)
                    Next
                End If
            Next

            For Each node In nodesToRemove
                TreeView1.Nodes.Remove(node)
            Next

            risdgv.Columns("ris_instock").Visible = False
            risdgv.Columns("ris_outofstock").Visible = False
            risdgv.Columns("ris_releasedquantity").Visible = False
            notificationiconpic.Visible = False
            Label134.Visible = False
            Label34.Visible = False
            Label133.Visible = False
            Label119.Visible = False
            Label12.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            requestsfromdtp.Visible = False
            requeststodtp.Visible = False
            oicname.Visible = False
            oicdesignation.Visible = False
            addofficerinchargebtn.Visible = False
            accounttypecmb.Visible = False
            accountdgv.Visible = False
            pathbtn.Visible = False
            pathtxt.Visible = False
            accountrestoredatabasebtn.Visible = False
            accountbackupdatabasebtn.Visible = False
            requestsdgv.Visible = False
            requeststypecmb.Visible = False
            risnumbertxt.Enabled = False
            Label36.Visible = False
            Label4.Visible = False
            Button7.Visible = True
            Button8.Visible = True
            riscancelbtn.Visible = False

            SetComboBoxesBasedOnDepartment()
            TreeView1.Refresh()
            SelectTab("newsupplyrequest")

            Dim tab As TabPage = maintbc.TabPages.Cast(Of TabPage)().FirstOrDefault(Function(t) t.Name = "newsupplyrequest")
            If tab IsNot Nothing Then maintbc.SelectTab(tab)

        Catch ex As Exception
            MessageBox.Show("Error applying ClientLogIn settings: " & ex.Message)
        End Try
    End Sub




    Private Sub SetComboBoxesBasedOnDepartment()
        Dim userId As String = Me.userid.Text.Trim()

        If String.IsNullOrEmpty(userId) Then
            MessageBox.Show("User ID is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim departments() As String = {
        "Administrative",      ' Index 0
        "Construction",        ' Index 1
        "Finance",             ' Index 2
        "Maintenance",         ' Index 3
        "Planning and Design", ' Index 4
        "Quality Assurance",   ' Index 5
        "ODE"                  ' Index 6
    }

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Dim query As String = "SELECT department FROM account WHERE id = @userid LIMIT 1"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userid", userId)

                    Dim departmentObj As Object = cmd.ExecuteScalar()

                    If departmentObj IsNot Nothing AndAlso Not IsDBNull(departmentObj) Then
                        Dim dept As String = departmentObj.ToString().Trim()

                        Dim index As Integer = Array.IndexOf(departments, dept)

                        If index >= 0 Then
                            risofficecmb.SelectedIndex = index
                        Else
                            MessageBox.Show($"Department '{dept}' is not mapped to an index.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Department not found for this user ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving department: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub EnableHandCursor()
        Dim handControls As Control() = {
        refreshpicbox,
        notificationiconpic,
        logouticonpic,
        logoutlbl,
        zerosupplypnl,
        Label7,
        zerosupplylbl,
        PictureBox8,
        insufficientrequestedsupplypnl,
        Label5,
        PictureBox7,
        insufficientrequestedsupplylbl,
        lowsupplypnl,
        Label3,
        lowsupplylbl,
        PictureBox6
    }

        For Each c As Control In handControls
            AddHandler c.MouseEnter, AddressOf Control_MouseEnter
            AddHandler c.MouseLeave, AddressOf Control_MouseLeave
        Next
    End Sub

    Private Sub Control_MouseEnter(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Control_MouseLeave(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub RefreshNotification()
        RefreshLowStock(Me)
        RefreshZeroStock(Me)
        RefreshInsufficientRequestedSupply(Me)
    End Sub
    Private Sub Notification()
        Dim connString As String = GlobalConnectionString

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()



                Dim userType As String = ""
                Dim queryUserType As String = "SELECT usertype FROM account WHERE ID = @id"
                Using cmd As New MySqlCommand(queryUserType, conn)
                    cmd.Parameters.AddWithValue("@id", userid.Text)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        userType = result.ToString()
                    Else

                        notificationnumberlbl.Visible = False
                        Exit Sub
                    End If
                End Using

                Dim countQuery As String = ""
                Dim pendingCount As Integer = 0


                If userType = "Admin" Then
                    countQuery = "SELECT COUNT(*) FROM ris WHERE status = 'pending'"
                ElseIf userType = "UserAdmin" Then
                    countQuery = "SELECT COUNT(*) FROM account WHERE status = 'pending'"
                Else

                    notificationnumberlbl.Visible = False
                    Exit Sub
                End If

                Using countCmd As New MySqlCommand(countQuery, conn)
                    pendingCount = Convert.ToInt32(countCmd.ExecuteScalar())
                End Using


                If pendingCount = 0 Then
                    notificationnumberlbl.Visible = False
                Else
                    notificationnumberlbl.Text = pendingCount.ToString()
                    notificationnumberlbl.Visible = True
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking notifications: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAccounts()

        Dim filter As String = accounttypecmb.Text.Trim()

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Dim pendingQuery As String = "SELECT COUNT(*) FROM account WHERE status = 'pending' AND ID NOT IN (999, 1000)"
                Using cmdPending As New MySqlCommand(pendingQuery, conn)
                    Label101.Text = cmdPending.ExecuteScalar().ToString()
                End Using

                Dim activeQuery As String = "SELECT COUNT(*) FROM account WHERE status = 'active' AND ID NOT IN (999, 1000)"
                Using cmdActive As New MySqlCommand(activeQuery, conn)
                    Label103.Text = cmdActive.ExecuteScalar().ToString()
                End Using

                Dim query As String = "SELECT ID, FN, MI, LN, usertype, status, passkey, access FROM account WHERE ID NOT IN (999, 1000)"

                Select Case filter.ToLower()
                    Case "pending"
                        query &= " AND status = 'pending'"
                    Case "requesting password reset"
                        query &= " AND passkey <> '' AND passkey IS NOT NULL"
                    Case "active"
                        query &= " AND status = 'active'"
                    Case "inactive"
                        query &= " AND status = 'deactivated'"
                    Case "all"
                    Case Else
                End Select

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        accountdgv.Rows.Clear()

                        While reader.Read()
                            Dim id As String = reader("ID").ToString()
                            Dim firstName As String = reader("FN").ToString()
                            Dim middleInitial As String = reader("MI").ToString()
                            Dim lastName As String = reader("LN").ToString()
                            Dim userType As String = reader("usertype").ToString()
                            Dim status As String = reader("status").ToString()
                            Dim passkey As String = reader("passkey").ToString()

                            Dim accessVal As String = If(reader("access") Is DBNull.Value, "0", reader("access").ToString())
                            Dim isChecked As Boolean = (accessVal = "1")

                            Dim middleChar As String = If(String.IsNullOrWhiteSpace(middleInitial), "", middleInitial.Trim() & ".")
                            Dim fullName As String = $"{firstName} {middleChar} {lastName}".Trim()

                            Dim statusBtnText As String = ""
                            Select Case status.Trim().ToLower()
                                Case "active"
                                    statusBtnText = "Deactivate"
                                Case "pending"
                                    statusBtnText = "Approve"
                                Case "deactivated"
                                    statusBtnText = "Activate"
                                Case Else
                                    statusBtnText = "Unknown"
                            End Select

                            Dim rowIndex As Integer = accountdgv.Rows.Add()
                            With accountdgv.Rows(rowIndex)
                                .Cells("accountuserid").Value = id
                                .Cells("user").Value = fullName
                                .Cells("usertype").Value = userType
                                .Cells("accountpasskey").Value = passkey
                                .Cells("status").Value = status
                                .Cells("sendpasskeybutton").Value = "Send Passkey"
                                .Cells("statusbutton").Value = statusBtnText

                                If String.Equals(userType.Trim(), "client", StringComparison.OrdinalIgnoreCase) Then
                                    .Cells("access").Value = isChecked
                                    .Cells("access").ReadOnly = False

                                    .Cells("access").Style.BackColor = accountdgv.DefaultCellStyle.BackColor
                                    .Cells("access").Style.ForeColor = accountdgv.DefaultCellStyle.ForeColor
                                Else
                                    .Cells("access").Value = False
                                    .Cells("access").ReadOnly = True

                                    Dim disabledStyle As New DataGridViewCellStyle()
                                    disabledStyle.BackColor = Color.LightGray
                                    disabledStyle.ForeColor = Color.DarkGray
                                    .Cells("access").Style = disabledStyle
                                End If
                            End With
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading accounts: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub logouticonpic_Click(sender As Object, e As EventArgs) Handles logouticonpic.Click
        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to log out?",
        "Confirm Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            Application.Restart()
        End If
    End Sub

    Private Sub ChooseAndSaveBackupPath()
        Try

            Using folderDialog As New FolderBrowserDialog()
                folderDialog.Description = "Select a folder where database backups will be saved."
                folderDialog.ShowNewFolderButton = True

                If folderDialog.ShowDialog() <> DialogResult.OK Then
                    MessageBox.Show("No folder selected.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Dim selectedPath As String = folderDialog.SelectedPath


                Using conn As New MySqlConnection(GlobalConnectionString)
                    conn.Open()



                    Dim countQuery As String = "SELECT COUNT(*) FROM path"
                    Dim recordCount As Integer
                    Using cmd As New MySqlCommand(countQuery, conn)
                        recordCount = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using

                    If recordCount > 0 Then

                        Dim updateQuery As String = "UPDATE path SET path = @path"
                        Using cmd As New MySqlCommand(updateQuery, conn)
                            cmd.Parameters.AddWithValue("@path", selectedPath)
                            cmd.ExecuteNonQuery()
                        End Using
                    Else

                        Dim insertQuery As String = "INSERT INTO path (path) VALUES (@path)"
                        Using cmd As New MySqlCommand(insertQuery, conn)
                            cmd.Parameters.AddWithValue("@path", selectedPath)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using


                pathtxt.Text = selectedPath
                LoadBackupPath()


                MessageBox.Show("Backup path saved successfully!" & vbCrLf &
                            "Path: " & selectedPath,
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Using

        Catch ex As Exception
            MessageBox.Show("Error setting backup path:" & vbCrLf & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BackupDatabase()
        Try
            Dim backupFolder As String = pathtxt.Text.Trim()

            If String.IsNullOrEmpty(backupFolder) OrElse Not Directory.Exists(backupFolder) Then
                MessageBox.Show("Backup path is invalid or does not exist.")
                Exit Sub
            End If

            Dim fileName As String = $"supply_backup_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.sql"
            Dim fullPath As String = Path.Combine(backupFolder, fileName)


            Dim builder As New MySqlConnectionStringBuilder(GlobalConnectionString)
            Dim dbServer = builder.Server
            Dim dbUser = builder.UserID
            Dim dbPass = builder.Password
            Dim dbName = builder.Database

            Dim mysqldumpPath As String = "C:\xampp\mysql\bin\mysqldump.exe"
            If Not File.Exists(mysqldumpPath) Then
                MessageBox.Show("mysqldump.exe not found.")
                Exit Sub
            End If


            Dim arguments As String =
            $"--user={dbUser} --password={dbPass} --host={dbServer} {dbName} --result-file=""{fullPath}"" --routines --events --triggers"

            Dim psi As New ProcessStartInfo() With {
            .FileName = mysqldumpPath,
            .Arguments = arguments,
            .RedirectStandardError = True,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }

            Using process As Process = Process.Start(psi)
                process.WaitForExit()
                Dim errorOutput As String = process.StandardError.ReadToEnd()

                If process.ExitCode = 0 Then
                    MessageBox.Show("Backup completed successfully!" & vbCrLf & fullPath)
                Else
                    MessageBox.Show("Backup failed:" & vbCrLf & errorOutput)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Backup error: " & ex.Message)
        End Try
    End Sub

    Private Sub RestoreDatabase()
        Try
            Using openDialog As New OpenFileDialog()
                openDialog.Title = "Select Backup File"
                openDialog.Filter = "SQL Files (*.sql)|*.sql"

                If Directory.Exists(pathtxt.Text.Trim()) Then
                    openDialog.InitialDirectory = pathtxt.Text.Trim()
                End If

                If openDialog.ShowDialog() <> DialogResult.OK Then Exit Sub

                Dim backupFile As String = openDialog.FileName

                Dim builder As New MySqlConnectionStringBuilder(GlobalConnectionString)
                Dim dbServer = builder.Server
                Dim dbUser = builder.UserID
                Dim dbPass = builder.Password
                Dim dbName = builder.Database

                Dim baseDir As String = AppDomain.CurrentDomain.BaseDirectory
                Dim mysqlPath As String = Path.Combine(baseDir, "mysql", "bin", "mysql.exe")

                If Not File.Exists(mysqlPath) Then
                    MessageBox.Show("Portable mysql.exe engine not found in the application layout structure.", "Engine Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim warning As String =
            "⚠ Restoring will ERASE all current data in the database." & vbCrLf &
            "Do you want to continue?"

                If MessageBox.Show(warning, "Restore Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
                    Exit Sub
                End If

                Dim baseConnString As String = $"Server={dbServer};Port=3306;Uid={dbUser};Pwd={dbPass};Pooling=false;SSLMode=None;"
                Using conn As New MySqlConnection(baseConnString)
                    conn.Open()
                    Using cmd As New MySqlCommand($"DROP DATABASE IF EXISTS {dbName}; CREATE DATABASE {dbName};", conn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                Dim arguments As String =
            $"--user={dbUser} --password={dbPass} --host={dbServer} {dbName} < ""{backupFile}"""

                Dim psi As New ProcessStartInfo() With {
                .FileName = "cmd.exe",
                .Arguments = $"/c """"{mysqlPath}"" {arguments}""",
                .RedirectStandardError = True,
                .UseShellExecute = False,
                .CreateNoWindow = True
            }

                Using process As Process = Process.Start(psi)
                    process.WaitForExit()

                    Dim errorOutput As String = process.StandardError.ReadToEnd()

                    If process.ExitCode = 0 Then
                        MessageBox.Show("Database restored successfully from local backup source.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Restore failed:" & vbCrLf & errorOutput, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

                RefreshAll()
            End Using

        Catch ex As Exception
            MessageBox.Show("Restore system pipeline exception error: " & ex.Message, "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub LoadBackupPath()
        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Dim query As String = "SELECT path FROM path LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        pathtxt.Text = result.ToString()
                    Else
                        pathtxt.Text = "No path set"
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading backup path:" & vbCrLf & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub SetAllNextNumbers()
        Dim connStr As String = (GlobalConnectionString)
        Try

            risnumbertxt.Text = GetNextFormattedNumber(connStr, "ris", "risnumber", "YYYY-MM-00000")
            icsnumbertxt.Text = GetNextFormattedNumber(connStr, "ics", "icsno", "YYYY-MM-00000")
            parnotxt.Text = GetNextFormattedNumber(connStr, "par", "parnumber", "YYYY-MM-00000")


            gasstocknotxt.Text = GetNextFormattedNumber(connStr, "gas", "stocknumber", "YYYY-00000")
            prsnumbertxt.Text = GetNextFormattedNumber(connStr, "prs", "prsnumber", "YYYY-00000")
            rrspnumbertxt.Text = GetNextFormattedNumber(connStr, "rrsp", "rrspnumber", "YYYY-00000")
            stockcardstocknumbertxt.Text = GetNextFormattedNumber(connStr, "supply", "stockno", "YYYY-00000")


            stockcardstockidtxt.Text = GetNextFormattedNumber(connStr, "supplystock", "supplystockid", "00000")

        Catch ex As Exception
            MessageBox.Show("Error generating next numbers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function GetNextFormattedNumber(connStr As String, tableName As String, columnName As String, formatType As String) As String
        Dim nextNum As Integer = 1
        Dim formattedNumber As String = ""

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Dim datePrefix As String = ""
                Dim prefixFilter As String = ""
                Dim regexPattern As String = ""




                Select Case formatType
                    Case "YYYY-MM-00000"
                        datePrefix = Date.Now.ToString("yyyy-MM-")
                        regexPattern = "^\d{4}-\d{2}-\d{5}$"

                    Case "YYYY-00000"
                        datePrefix = Date.Now.ToString("yyyy-")
                        regexPattern = "^\d{4}-\d{5}$"

                    Case "00000"
                        regexPattern = "^\d{5}$"
                End Select




                Dim query As String
                If datePrefix <> "" Then
                    query = $"SELECT {columnName} FROM {tableName} WHERE {columnName} LIKE @prefix"
                Else
                    query = $"SELECT {columnName} FROM {tableName}"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If datePrefix <> "" Then
                        cmd.Parameters.AddWithValue("@prefix", datePrefix & "%")
                    End If

                    Dim validNumbers As New List(Of Integer)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim value As String = reader(columnName).ToString().Trim()


                            If value = "" Then Continue While


                            If Regex.IsMatch(value, regexPattern) Then

                                Dim numericPart As String = value.Split("-"c).Last()

                                Dim num As Integer
                                If Integer.TryParse(numericPart, num) Then
                                    validNumbers.Add(num)
                                End If
                            End If
                        End While
                    End Using


                    If validNumbers.Count > 0 Then
                        nextNum = validNumbers.Max() + 1
                    Else
                        nextNum = 1
                    End If
                End Using
            End Using


            Select Case formatType
                Case "YYYY-MM-00000"
                    formattedNumber = Date.Now.ToString("yyyy-MM-") & nextNum.ToString("D5")

                Case "YYYY-00000"
                    formattedNumber = Date.Now.ToString("yyyy-") & nextNum.ToString("D5")

                Case "00000"
                    formattedNumber = nextNum.ToString("D5")
            End Select


            If formattedNumber = "" Then
                formattedNumber = "00001"
            End If

        Catch ex As Exception

            formattedNumber = "ERROR-" & Date.Now.ToString("HHmmss")
        End Try

        Return formattedNumber
    End Function








    Dim autoCollection As New AutoCompleteStringCollection()
    Private Sub LoadAutoCompleteData()
        Dim connString As String = (GlobalConnectionString)
        Dim autoCompleteSupply As New AutoCompleteStringCollection()
        Dim autoCompleteEquipments As New AutoCompleteStringCollection()
        Dim autoCompleteEquipmentsInICS As New AutoCompleteStringCollection()
        Dim autoCompleteEquipmentsOutRRSP As New AutoCompleteStringCollection()
        Dim autoCompleteEquipmentsOutPRS As New AutoCompleteStringCollection()
        Dim autoCompleteGas As New AutoCompleteStringCollection()

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()



                Dim query1 As String = "SELECT DISTINCT description FROM supply WHERE description IS NOT NULL"
                Using cmd As New MySqlCommand(query1, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            autoCompleteSupply.Add(reader("description").ToString().Trim())
                        End While
                    End Using
                End Using


                Dim query2 As String = "
                SELECT propertynumber, SUBSTRING_INDEX(description, '\n', 1) AS description
                FROM equipment
                WHERE description IS NOT NULL AND propertynumber IS NOT NULL"
                Using cmd As New MySqlCommand(query2, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim propNum As String = reader("propertynumber").ToString().Trim()
                            Dim desc As String = reader("description").ToString().Trim()
                            If Not String.IsNullOrWhiteSpace(propNum) Then autoCompleteEquipments.Add(propNum)
                            If Not String.IsNullOrWhiteSpace(desc) Then autoCompleteEquipments.Add(desc)
                        End While
                    End Using
                End Using



                Dim queryICS As String = "
                SELECT propertynumber, description 
                FROM equipment 
                WHERE status = 'IN' 
                  AND description IS NOT NULL 
                  AND propertynumber IS NOT NULL"
                Using cmd As New MySqlCommand(queryICS, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim propNum As String = reader("propertynumber").ToString().Trim()
                            Dim desc As String = reader("description").ToString().Trim()
                            Dim firstLine As String = desc.Split({vbCrLf, vbLf}, StringSplitOptions.None)(0).Trim()
                            autoCompleteEquipmentsInICS.Add(propNum)
                            autoCompleteEquipmentsInICS.Add(firstLine)
                        End While
                    End Using
                End Using



                Dim queryRRSP As String = "
                SELECT propertynumber, description 
                FROM equipment 
                WHERE status = 'OUT' 
                  AND cost < 50000 
                  AND (description IS NOT NULL OR propertynumber IS NOT NULL)"
                Using cmd As New MySqlCommand(queryRRSP, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            If Not IsDBNull(reader("propertynumber")) Then
                                autoCompleteEquipmentsOutRRSP.Add(reader("propertynumber").ToString().Trim())
                            End If
                            If Not IsDBNull(reader("description")) Then
                                Dim desc As String = reader("description").ToString().Trim()
                                Dim firstLine As String = desc.Split({vbCrLf, vbLf}, StringSplitOptions.None)(0).Trim()
                                autoCompleteEquipmentsOutRRSP.Add(firstLine)
                            End If
                        End While
                    End Using
                End Using



                Dim queryPRS As String = "
                SELECT propertynumber, description 
                FROM equipment 
                WHERE status = 'OUT' 
                  AND cost >= 50000 
                  AND (description IS NOT NULL OR propertynumber IS NOT NULL)"
                Using cmd As New MySqlCommand(queryPRS, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            If Not IsDBNull(reader("propertynumber")) Then
                                autoCompleteEquipmentsOutPRS.Add(reader("propertynumber").ToString().Trim())
                            End If
                            If Not IsDBNull(reader("description")) Then
                                Dim desc As String = reader("description").ToString().Trim()
                                Dim firstLine As String = desc.Split({vbCrLf, vbLf}, StringSplitOptions.None)(0).Trim()
                                autoCompleteEquipmentsOutPRS.Add(firstLine)
                            End If
                        End While
                    End Using
                End Using



                Dim queryGas As String = "
                SELECT DISTINCT stocknumber AS value FROM gas WHERE stocknumber IS NOT NULL
                UNION
                SELECT DISTINCT requestedby AS value FROM gas WHERE requestedby IS NOT NULL"
                Using cmd As New MySqlCommand(queryGas, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            autoCompleteGas.Add(reader("value").ToString().Trim())
                        End While
                    End Using
                End Using

            End Using



            With risdescriptiontxt
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteCustomSource = autoCompleteSupply
            End With

            With supplyandmaterialssearchtxt
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteCustomSource = autoCompleteSupply
            End With

            With equipmentssearchtxt
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteCustomSource = autoCompleteEquipments
            End With

            With icssearchtxt
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteCustomSource = autoCompleteEquipmentsInICS
            End With

            With rrspsearchtxt
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteCustomSource = autoCompleteEquipmentsOutRRSP
            End With

            With prssearchtxt
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteCustomSource = autoCompleteEquipmentsOutPRS
            End With

            With gassearchtxt
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteCustomSource = autoCompleteGas
            End With

        Catch ex As Exception
            MessageBox.Show("Error loading autocomplete data: " & ex.Message)
        End Try
    End Sub


    Private Sub risdgv_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles risdgv.CurrentCellDirtyStateChanged
        If risdgv Is Nothing Then Return
        If risdgv.IsCurrentCellDirty Then
            risdgv.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub risdgv_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles risdgv.DataBindingComplete
        SetupRIS_CheckBehavior()
    End Sub


    Public Sub SetupRIS_CheckBehavior()

        If risdgv Is Nothing Then Return


        Dim requiredCols = New String() {"ris_instock", "ris_outofstock", "ris_requestedquantity", "ris_releasedquantity"}
        For Each c In requiredCols
            If Not risdgv.Columns.Contains(c) Then
                MessageBox.Show($"RIS DataGridView must have '{c}' column.", "Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next


        risdgv.Columns("ris_instock").ReadOnly = True
        risdgv.Columns("ris_outofstock").ReadOnly = True


        For Each row As DataGridViewRow In risdgv.Rows
            If row Is Nothing OrElse row.IsNewRow Then Continue For

            Dim rqText As String = Convert.ToString(row.Cells("ris_requestedquantity").Value).Trim()
            Dim rlText As String = Convert.ToString(row.Cells("ris_releasedquantity").Value).Trim()

            If String.Equals(rqText, rlText, StringComparison.Ordinal) Then

                row.Cells("ris_instock").Value = "✔"
                row.Cells("ris_outofstock").Value = ""
            Else

                row.Cells("ris_instock").Value = ""
                row.Cells("ris_outofstock").Value = "✔"
            End If
        Next
    End Sub


    Private Sub risdgv_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles risdgv.EditingControlShowing
        If risdgv Is Nothing Then Return
        If risdgv.CurrentCell Is Nothing Then Return

        Dim colName As String = risdgv.Columns(risdgv.CurrentCell.ColumnIndex).Name
        If colName = "ris_instock" OrElse colName = "ris_outofstock" Then
            Dim txtBox As TextBox = TryCast(e.Control, TextBox)
            If txtBox IsNot Nothing Then txtBox.ReadOnly = True
        End If
    End Sub


    Private Sub risdgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles risdgv.CellClick
        If risdgv Is Nothing Then Return
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex >= risdgv.Rows.Count Then Exit Sub

        Dim row As DataGridViewRow = risdgv.Rows(e.RowIndex)
        Dim colName As String = risdgv.Columns(e.ColumnIndex).Name


        If colName = "removeris" Then
            If risdgv.RowCount > 1 Then risdgv.Rows.RemoveAt(e.RowIndex)
            Exit Sub
        End If


        Dim rqText As String = Convert.ToString(row.Cells("ris_requestedquantity").Value).Trim()

        If colName = "ris_instock" Then

            row.Cells("ris_instock").Value = "✔"
            row.Cells("ris_outofstock").Value = ""
            row.Cells("ris_releasedquantity").Value = rqText
            Exit Sub
        End If

        If colName = "ris_outofstock" Then

            row.Cells("ris_outofstock").Value = "✔"
            row.Cells("ris_instock").Value = ""
            row.Cells("ris_releasedquantity").Value = ""
            Exit Sub
        End If
    End Sub

    Private Sub risdgv_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles risdgv.CellValueChanged
        If risdgv Is Nothing Then Return
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex >= risdgv.Rows.Count Then Exit Sub

        Dim colName As String = risdgv.Columns(e.ColumnIndex).Name
        Dim row As DataGridViewRow = risdgv.Rows(e.RowIndex)


        If colName <> "ris_requestedquantity" AndAlso colName <> "ris_releasedquantity" Then
            Return
        End If


        Dim rqText As String = Convert.ToString(row.Cells("ris_requestedquantity").Value).Trim()
        Dim rlText As String = Convert.ToString(row.Cells("ris_releasedquantity").Value).Trim()

        If String.Equals(rqText, rlText, StringComparison.Ordinal) Then
            row.Cells("ris_instock").Value = "✔"
            row.Cells("ris_outofstock").Value = ""
        Else
            row.Cells("ris_instock").Value = ""
            row.Cells("ris_outofstock").Value = "✔"
        End If
    End Sub


    Private Sub AddNewRISRow(stockno As String, unit As String, description As String, requestedQtyText As String, remarks As String)

        risdgv.Rows.Add(
        stockno,                 ' ris_stockno
        unit,                    ' ris_unit
        description,             ' ris_description
        requestedQtyText,        ' ris_requestedquantity
        "",                      ' ris_qtybalance
        "",                      ' ris_instock
        "",                      ' ris_outofstock
        "",                      ' ris_releasedquantity
        remarks,                 ' ris_remarks
        Nothing
    )
    End Sub



    Private Sub ris_add_Click(sender As Object, e As EventArgs) Handles ris_add.Click

        If String.IsNullOrWhiteSpace(risdescriptiontxt.Text) Then
            MessageBox.Show("Please enter a description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(risquantitytxt.Text) Then
            MessageBox.Show("Please enter a quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim requestedQty As Integer
        If Not Integer.TryParse(risquantitytxt.Text, requestedQty) Then
            MessageBox.Show("Quantity must be a whole number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim connString As String = (GlobalConnectionString)
        Dim stockno As String = ""
        Dim unit As String = ""
        Dim description As String = ""

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()


                Dim query As String = "
                SELECT stockno, unit, description 
                FROM supply 
                WHERE description = @description 
                LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@description", risdescriptiontxt.Text)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            stockno = reader("stockno").ToString()
                            unit = reader("unit").ToString()
                            description = reader("description").ToString()
                        Else
                            MessageBox.Show("No matching item found in supply table.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End Using
                End Using


                Dim foundRow As DataGridViewRow = Nothing
                For Each row As DataGridViewRow In risdgv.Rows
                    If row.Cells("ris_stockno").Value IsNot Nothing AndAlso
                   row.Cells("ris_stockno").Value.ToString() = stockno Then
                        foundRow = row
                        Exit For
                    End If
                Next


                If foundRow IsNot Nothing Then

                    Dim currentQty As Integer = Convert.ToInt32(foundRow.Cells("ris_requestedquantity").Value)
                    foundRow.Cells("ris_requestedquantity").Value = currentQty + requestedQty
                    foundRow.Cells("ris_remarks").Value = risremarkstxt.Text
                Else

                    risdgv.Rows.Add(
                    stockno,                      ' ris_stockno
                    unit,                         ' ris_unit
                    description,                   ' ris_description
                    requestedQty,                  ' ris_requestedquantity
                    "",                            ' ris_qtybalance 
                    "",                            ' ris_instock 
                    "",                            ' ris_outofstock 
                    "",                            ' ris_releasedquantity 
                    risremarkstxt.Text,
                    Nothing
                )
                End If


                risdescriptiontxt.Clear()
                risremarkstxt.Clear()
                risquantitytxt.Clear()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub










    Private Sub risremovebtn_Click(sender As Object, e As EventArgs) Handles risremovebtn.Click
        If risdgv.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select an item to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedRowIndexes = risdgv.SelectedCells.Cast(Of DataGridViewCell)().
                                 Select(Function(c) c.RowIndex).
                                 Distinct().
                                 OrderByDescending(Function(i) i).
                                 ToList()

        Dim message As String
        If selectedRowIndexes.Count > 1 Then
            message = "Do you want to remove multiple rows?"
        Else
            message = "Are you sure you want to remove the selected item?"
        End If

        Dim result As DialogResult = MessageBox.Show(message, "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            For Each rowIndex In selectedRowIndexes
                risdgv.Rows.RemoveAt(rowIndex)
            Next
            risdgv.ClearSelection()
        End If
    End Sub


    Private Sub risnextbtn_Click(sender As Object, e As EventArgs) Handles risnextbtn.Click
        If String.IsNullOrWhiteSpace(risofficecmb.Text) Then
            MessageBox.Show("Please select an office.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(risdate.Text) Then
            MessageBox.Show("Please select a date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(risemailaddresstxt.Text) Then
            MessageBox.Show("Please enter an email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(risemailaddresstxt.Text, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(risphonenumbertxt.Text) Then
            MessageBox.Show("Please enter a phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Dim phone As String = risphonenumbertxt.Text.Trim()
            If Not ((phone.Length = 11 AndAlso phone.StartsWith("09")) OrElse
                (phone.Length = 13 AndAlso phone.StartsWith("+63"))) Then

                MessageBox.Show("Phone number must be 11 digits starting with '09' or 13 characters starting with '+63'.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        If risdgv.Rows.Count = 0 Then
            MessageBox.Show("Add Items to Request", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Dim query As String = "SELECT usertype FROM account WHERE ID = @ID LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", userid.Text.Trim())

                    Dim usertypeObj As Object = cmd.ExecuteScalar()

                    If usertypeObj IsNot Nothing Then
                        Dim usertype As String = usertypeObj.ToString()

                        If usertype = "Admin" Then

                            risreceivedbyfirstnametxt.Enabled = True
                            risreceivedbydesignationtxt.Enabled = True

                            rissaveandapprove.Visible = True

                        ElseIf usertype = "Client" Then

                            risreceivedbyfirstnametxt.Enabled = False
                            risreceivedbydesignationtxt.Enabled = False

                            rissaveandapprove.Visible = False
                        End If

                    Else
                        MessageBox.Show("User account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error checking user type: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        maintbc.SelectedTab = rissignaturestab
    End Sub



    Private hasInsufficientStock As Boolean = False
















    Private Sub GenerateRISReportFromDatabase()
        Dim risNumber As String = risnumbertxt.Text.Trim()
        If risNumber = "" Then
            MessageBox.Show("Please enter a RIS number.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim connString As String = (GlobalConnectionString)

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                DataSet.RISdatatable.Clear()
                DataSet.RISgrid.Clear()

                Dim risHeaderQuery As String = "
SELECT risnumber, office, date AS risdate, requestedby, requestedbydesignation,
       approvedby, approvedbydesignation, issuedby, issuedbydesignation,
       recievedby, receivedbydesignation, purpose
FROM ris
WHERE risnumber = @risnumber
"
                Dim headerRow As DataSet.RISdatatableRow = DataSet.RISdatatable.NewRISdatatableRow()
                Using cmd As New MySqlCommand(risHeaderQuery, conn)
                    cmd.Parameters.AddWithValue("@risnumber", risNumber)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            headerRow.risnumber = reader("risnumber").ToString()
                            headerRow.risoffice = reader("office").ToString()
                            headerRow.risdate = Convert.ToDateTime(reader("risdate")).ToString("yyyy-MM-dd")

                            headerRow.risrequestedby = reader("requestedby").ToString()
                            headerRow.risrequestedbydesignation = reader("requestedbydesignation").ToString()

                            headerRow.risapprovedby = reader("approvedby").ToString()
                            headerRow.risapprovedbydesignation = reader("approvedbydesignation").ToString()

                            headerRow.risissuedby = reader("issuedby").ToString()
                            headerRow.risissuedbydesignation = reader("issuedbydesignation").ToString()

                            headerRow.risreceivedby = reader("recievedby").ToString()
                            headerRow.risreceivedbydesignation = reader("receivedbydesignation").ToString()

                            headerRow.rispurpose = reader("purpose").ToString()
                        Else
                            MessageBox.Show("No RIS record found for this number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End Using
                End Using
                DataSet.RISdatatable.Rows.Add(headerRow)

                Dim risItemsQuery As String = "
SELECT 
    rs.stockno,
    s.unit,
    s.description,
    rs.requested_qty,
    rs.approved_qty,
    rs.approval,
    rs.remarks
FROM ris_supply rs
INNER JOIN supply s ON rs.stockno = s.stockno
WHERE rs.risnumber = @risnumber
GROUP BY rs.stockno
"
                Using cmd As New MySqlCommand(risItemsQuery, conn)
                    cmd.Parameters.AddWithValue("@risnumber", risNumber)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim itemRow As DataSet.RISgridRow = DataSet.RISgrid.NewRISgridRow()

                            itemRow.risstocknumber = reader("stockno").ToString()
                            itemRow.risunit = reader("unit").ToString()
                            itemRow.risdescription = reader("description").ToString()
                            itemRow.risquantityrequested = reader("requested_qty").ToString()
                            itemRow.risquantityreleased = reader("approved_qty").ToString()
                            itemRow.risremarks = If(IsDBNull(reader("remarks")), "", reader("remarks").ToString())

                            Dim approvalValue As Integer = Convert.ToInt32(reader("approval"))
                            itemRow.risyes = If(approvalValue = 1, "✓", "")
                            itemRow.risno = If(approvalValue = 2, "✓", "")

                            DataSet.RISgrid.Rows.Add(itemRow)
                        End While
                    End Using
                End Using

                Dim report As New RIS()
                report.SetDataSource(DataSet)

                CRViewer.CrystalReportViewer1.ReportSource = report
                CRViewer.CrystalReportViewer1.Refresh()
                CRViewer.ShowDialog()
            End Using

        Catch ex As Exception
            MessageBox.Show("❌ Error generating RIS report: " & ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub ResetRIS_UI()
        risnumbertxt.Clear()
        risofficecmb.SelectedIndex = -1
        risemailaddresstxt.Clear()
        risphonenumbertxt.Clear()

        risrequestedbyfirstnametxt.Clear()
        risdesignationtxt.Clear()

        risapprovedbyfirstnametxt.Clear()
        risapprovedbydesignationtxt.Clear()

        risreceivedbyfirstnametxt.Clear()
        risreceivedbydesignationtxt.Clear()
        rispurposetxt.Clear()
        risdgv.Rows.Clear()
        risdgv.Columns("ris_instock").ReadOnly = True
        risdgv.Columns("ris_outofstock").ReadOnly = True
        risdgv.Columns("ris_releasedquantity").ReadOnly = True
        risfinishbtn.Text = "Finish"
        rissaveandapprove.Text = "Save and Approve"

    End Sub

    Private Sub riscancelbtn_Click(sender As Object, e As EventArgs) Handles riscancelbtn.Click

        Dim confirm As DialogResult = MessageBox.Show(
        "Are you sure you want to cancel? All fields will be cleared.",
        "Cancel Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    )

        If confirm = DialogResult.Yes Then

            risnumbertxt.Clear()
            risofficecmb.SelectedIndex = -1
            risemailaddresstxt.Clear()
            risphonenumbertxt.Clear()

            risrequestedbyfirstnametxt.Clear()
            risdesignationtxt.Clear()

            risapprovedbyfirstnametxt.Clear()
            risapprovedbydesignationtxt.Clear()

            risreceivedbyfirstnametxt.Clear()
            risreceivedbydesignationtxt.Clear()
            rispurposetxt.Clear()
            risdgv.Rows.Clear()
            risfinishbtn.Show()
            rissaveandapprove.Text = "Save and Approve"
            risdgv.Columns("ris_instock").ReadOnly = True
            risdgv.Columns("ris_outofstock").ReadOnly = True
            SetAllNextNumbers()
            SelectTab("viewrequisition")
            risfinishbtn.Visible = True
        End If


    End Sub

    Private Sub supplyandmaterialssearchtxt_TextChanged(sender As Object, e As EventArgs) Handles supplyandmaterialssearchtxt.TextChanged
        LoadSupplyAndMaterials(Me)
    End Sub

    Private Sub supplyandmaterialstypecmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles supplyandmaterialstypecmb.SelectedIndexChanged
        LoadSupplyAndMaterials(Me)


    End Sub



    Private Sub supplyandmaterialsdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles supplyandmaterialsdgv.CellContentClick
        AddStockButtonClick(supplyandmaterialsdgv, e)
        ShowQRFromRow(supplyandmaterialsdgv, e)


        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim columnName As String = supplyandmaterialsdgv.Columns(e.ColumnIndex).Name




        If columnName = "supply_edit" Then
            Dim selectedStockNo As String = supplyandmaterialsdgv.Rows(e.RowIndex).Cells("supply_stockno").Value.ToString().Trim()

            If String.IsNullOrEmpty(selectedStockNo) Then
                MessageBox.Show("Invalid Stock Number selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim connString As String = (GlobalConnectionString)
            Try
                Using con As New MySqlConnection(connString)
                    con.Open()

                    Dim query As String = "SELECT stockno, item, description, unit, supplybalance, qr FROM supply WHERE stockno = @stockno"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@stockno", selectedStockNo)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                stockcardstocknumbertxt.Text = reader("stockno").ToString()
                                stockcarddescriptiontxt.Text = reader("description").ToString()
                                stockcardunitofmeasuretxt.Text = reader("unit").ToString()
                                stockcardquantitytxt.Text = reader("supplybalance").ToString()
                                stockcardstockidtxt.Text = reader("stockno").ToString()
                                stockcardreorderpointtxt.Clear()
                                stockcarddatedtm.Value = DateTime.Now
                            Else
                                MessageBox.Show("No record found for this stock number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End Using
                    End Using
                End Using

                stockcardfinishbtn.Text = "Update"
                maintbc.SelectedTab = newstocktab
                stockcardstocknumbertxt.ReadOnly = True
                stockcardquantitytxt.ReadOnly = True
                stockcardstockidtxt.Visible = False
                Label66.Visible = False

            Catch ex As Exception
                MessageBox.Show("Error loading supply details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If




        If columnName = "supply_details" Then
            Dim stockNo As String = supplyandmaterialsdgv.Rows(e.RowIndex).Cells("supply_stockno").Value.ToString().Trim()

            If String.IsNullOrEmpty(stockNo) Then
                MessageBox.Show("No stock number found in this row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            supplystockcard.stocknumberlbl.Text = stockNo

            supplystockcard.LoadStockCardData()


            supplystockcard.Show()
            supplystockcard.BringToFront()
        End If
    End Sub






    Private Sub stockcardfinishbtn_Click(sender As Object, e As EventArgs) Handles stockcardfinishbtn.Click

        If String.IsNullOrWhiteSpace(stockcarddescriptiontxt.Text) OrElse
   String.IsNullOrWhiteSpace(stockcardstocknumbertxt.Text) OrElse
   String.IsNullOrWhiteSpace(stockcardstockidtxt.Text) OrElse
   String.IsNullOrWhiteSpace(stockcardunitofmeasuretxt.Text) OrElse
   String.IsNullOrWhiteSpace(stockcardquantitytxt.Text) Then

            MessageBox.Show("Important fields should be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim confirmResult = MessageBox.Show("Check all details if correct. Continue?",
                                    "Confirm Submission",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then Exit Sub


        Dim connString As String = (GlobalConnectionString)

        Try
            Using con As New MySqlConnection(connString)
                con.Open()


                If stockcardfinishbtn.Text = "Finish" Then


                    Dim querySupply As String = "
                INSERT INTO supply (stockno, item, description, unit, supplybalance, qr)
                VALUES (@stockno, @item, @description, @unit, @supplybalance, @qr)
            "
                    Using cmd As New MySqlCommand(querySupply, con)
                        cmd.Parameters.AddWithValue("@stockno", stockcardstocknumbertxt.Text)
                        cmd.Parameters.AddWithValue("@item", stockcarddescriptiontxt.Text)
                        cmd.Parameters.AddWithValue("@description", stockcarddescriptiontxt.Text)
                        cmd.Parameters.AddWithValue("@unit", stockcardunitofmeasuretxt.Text)
                        cmd.Parameters.AddWithValue("@supplybalance", stockcardquantitytxt.Text)
                        cmd.Parameters.AddWithValue("@qr", stockcardstocknumbertxt.Text)
                        cmd.ExecuteNonQuery()
                    End Using


                    Dim queryStock As String = "
                INSERT INTO supplystock (stockid, stockno, qtybalance, receiptqty, supplystockdate, reorderpoint, office)
                VALUES (@stockid, @stockno, @qtybalance, @receiptqty, @date, @reorderpoint, @office)
            "
                    Using cmd As New MySqlCommand(queryStock, con)
                        cmd.Parameters.AddWithValue("@stockid", stockcardstockidtxt.Text)
                        cmd.Parameters.AddWithValue("@stockno", stockcardstocknumbertxt.Text)
                        cmd.Parameters.AddWithValue("@qtybalance", stockcardquantitytxt.Text)
                        cmd.Parameters.AddWithValue("@receiptqty", stockcardquantitytxt.Text)
                        cmd.Parameters.AddWithValue("@date", stockcarddatedtm.Value)
                        cmd.Parameters.AddWithValue("@reorderpoint", If(String.IsNullOrWhiteSpace(stockcardreorderpointtxt.Text), 0, stockcardreorderpointtxt.Text))
                        cmd.Parameters.AddWithValue("@office", "Supply Unit")
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("New Stock Card added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    Dim qrGenerator As New QRCodeGenerator()
                    Dim qrData = qrGenerator.CreateQrCode(stockcardstocknumbertxt.Text, QRCodeGenerator.ECCLevel.Q)
                    Dim qrCode As New QRCode(qrData)
                    Dim qrImage As Bitmap = qrCode.GetGraphic(6)

                    QR.qrpic.Image = qrImage
                    QR.qrlabellbl.Text = stockcarddescriptiontxt.Text
                    QR.ShowDialog()



                ElseIf stockcardfinishbtn.Text = "Update" Then

                    Dim queryUpdateSupply As String = "
                UPDATE supply
                SET item = @item,
                    description = @description,
                    unit = @unit,
                    supplybalance = @supplybalance
                WHERE stockno = @stockno
            "
                    Using cmd As New MySqlCommand(queryUpdateSupply, con)
                        cmd.Parameters.AddWithValue("@item", stockcarddescriptiontxt.Text)
                        cmd.Parameters.AddWithValue("@description", stockcarddescriptiontxt.Text)
                        cmd.Parameters.AddWithValue("@unit", stockcardunitofmeasuretxt.Text)
                        cmd.Parameters.AddWithValue("@supplybalance", stockcardquantitytxt.Text)
                        cmd.Parameters.AddWithValue("@stockno", stockcardstocknumbertxt.Text)
                        cmd.ExecuteNonQuery()
                    End Using




                    Dim queryUpdateStock As String = "
                UPDATE supplystock
                SET supplystockdate = @date,
                    reorderpoint = @reorderpoint
                WHERE stockno = @stockno
            "
                    Using cmd As New MySqlCommand(queryUpdateStock, con)

                        cmd.Parameters.AddWithValue("@date", stockcarddatedtm.Value)
                        cmd.Parameters.AddWithValue("@reorderpoint", If(String.IsNullOrWhiteSpace(stockcardreorderpointtxt.Text), 0, stockcardreorderpointtxt.Text))
                        cmd.Parameters.AddWithValue("@stockno", stockcardstocknumbertxt.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                    stockcardstocknumbertxt.ReadOnly = False
                    stockcardfinishbtn.Text = "Finish"
                    stockcardquantitytxt.ReadOnly = False
                    MessageBox.Show("Stock Card updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using


            stockcarddescriptiontxt.Clear()
            stockcardstocknumbertxt.Clear()
            stockcardstockidtxt.Clear()
            stockcardunitofmeasuretxt.Clear()
            stockcardquantitytxt.Clear()
            stockcardreorderpointtxt.Clear()
            stockcarddatedtm.Value = DateTime.Now
            stockcardstockidtxt.Visible = True
            Label66.Visible = True

            SelectTab("samviewsupply")
            LoadSupplyAndMaterials(Me)
            LoadAutoCompleteData()
            SetAllNextNumbers()

        Catch ex As Exception
            MessageBox.Show("Error saving Stock Card: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub equipmentstypecmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles equipmentstypecmb.SelectedIndexChanged
        LoadEquipmentsData(Me)
    End Sub

    Private Sub equipmentssearchtxt_TextChanged(sender As Object, e As EventArgs) Handles equipmentssearchtxt.TextChanged
        LoadEquipmentsData(Me)
    End Sub

    Private Sub equipmentinbtn_Click(sender As Object, e As EventArgs) Handles equipmentinbtn.Click

        maintbc.SelectedTab = rrspdetailstab

    End Sub

    Private Sub paraddbtn_Click(sender As Object, e As EventArgs) Handles paraddbtn.Click

        If String.IsNullOrWhiteSpace(parprimarydescriptiontxt.Text) Then
            MessageBox.Show("Enter description", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If pardateaquireddtm.CustomFormat = " " Then
            MessageBox.Show("Please select a date before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim formattedtext As New System.Text.StringBuilder()
        formattedtext.AppendLine(parprimarydescriptiontxt.Text)


        formattedtext.AppendLine()


        For Each row As DataGridViewRow In pardescriptiondgv.Rows
            If Not row.IsNewRow Then
                Dim spec As String = If(row.Cells("parspecification").Value, "").ToString().Trim()
                Dim val As String = If(row.Cells("parvalue").Value, "").ToString().Trim()

                If Not String.IsNullOrEmpty(spec) AndAlso Not String.IsNullOrEmpty(val) Then
                    formattedtext.AppendLine(spec & " : " & val)
                End If
            End If
        Next


        Dim newrowindex As Integer = pardgv.Rows.Add()
        pardgv.Rows(newrowindex).Cells("pardescription").Value = formattedtext.ToString()
        pardgv.Rows(newrowindex).Cells("pardateaquired").Value = pardateaquireddtm.Value.ToString("yyyy-MM-dd")


        parprimarydescriptiontxt.Clear()
        pardescriptiondgv.Rows.Clear()
        ClearDatePicker()


        parprimarydescriptiontxt.Focus()


        pardgv.ClearSelection()
    End Sub




    Private Sub addnewequipmentbtn_Click(sender As Object, e As EventArgs) Handles addnewequipmentbtn.Click
        SelectTab("addnewequipment")
    End Sub

    Private Sub parnextbtn_Click(sender As Object, e As EventArgs) Handles parnextbtn.Click

        Dim IsValidMiddleInitial As Func(Of TextBox, Boolean) = Function(txt)
                                                                    Return Not String.IsNullOrWhiteSpace(txt.Text) AndAlso txt.Text.Length = 1 AndAlso Char.IsLetter(txt.Text(0)) AndAlso Char.IsUpper(txt.Text(0))
                                                                End Function


        Dim requiredTextboxes As TextBox() = {
        parnotxt,
        parrecommendingapprovalfirstnametxt,
        parrecommendingapprovalpositiontxt,
        parapprovedbyfirstnametxt,
        parapprovedbypositiontxt,
        parreceivedbyfirstnametxt,
        parreceivedbypositiontxt
    }


        For Each txt As TextBox In requiredTextboxes
            If String.IsNullOrWhiteSpace(txt.Text) Then
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt.Focus()
                Return
            End If
        Next


        maintbc.SelectedTab = paritemstab
    End Sub

    Private Sub parbackbtn_Click(sender As Object, e As EventArgs) Handles parbackbtn.Click
        maintbc.SelectedTab = parsignaturestab
    End Sub

    Private Sub parfinishbtn_Click(sender As Object, e As EventArgs) Handles parfinishbtn.Click

        If pardgv.Rows.Count = 0 Then
            MessageBox.Show("No items to save. Please add items first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If String.IsNullOrWhiteSpace(oicname.Text) Then
            MessageBox.Show("Please select the Issued By (OIC Name).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            oicname.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(oicdesignation.Text) Then
            MessageBox.Show("Please enter the Issued By Designation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            oicdesignation.Focus()
            Return
        End If

        For Each row As DataGridViewRow In pardgv.Rows
            If row.IsNewRow Then Continue For

            Dim requiredColumns As String() = {"pardescription", "parunit", "parquantity", "pardateaquired", "paramount"}
            For Each colName In requiredColumns
                If row.Cells(colName).Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells(colName).Value.ToString()) Then
                    MessageBox.Show("Please fill out all fields in each row before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Next
        Next

        Dim recommendingApproval As String = parrecommendingapprovalfirstnametxt.Text.Trim()
        Dim approvedBy As String = parapprovedbyfirstnametxt.Text.Trim()
        Dim receivedBy As String = parreceivedbyfirstnametxt.Text.Trim()


        Using conn As New MySqlConnection(GlobalConnectionString)
            conn.Open()
            Dim trans As MySqlTransaction = conn.BeginTransaction()

            Try
                Dim parCmd As New MySqlCommand("INSERT IGNORE INTO par 
            (parnumber, recommendingapproval, recommendingapprovaldesignation, 
             approvedby, approvedbydesignation, receivedby, receivedbydesignation, 
             issuedby, issuedbydesignation, date, note) 
            VALUES (@parnumber, @recommendingapproval, @recommendingapprovaldesignation, 
             @approvedby, @approvedbydesignation, @receivedby, @receivedbydesignation, 
             @issuedby, @issuedbydesignation, @date, @note)", conn, trans)

                parCmd.Parameters.AddWithValue("@parnumber", parnotxt.Text.Trim())
                parCmd.Parameters.AddWithValue("@recommendingapproval", recommendingApproval)
                parCmd.Parameters.AddWithValue("@recommendingapprovaldesignation", parrecommendingapprovalpositiontxt.Text.Trim())
                parCmd.Parameters.AddWithValue("@approvedby", approvedBy)
                parCmd.Parameters.AddWithValue("@approvedbydesignation", parapprovedbypositiontxt.Text.Trim())
                parCmd.Parameters.AddWithValue("@receivedby", receivedBy)
                parCmd.Parameters.AddWithValue("@receivedbydesignation", parreceivedbypositiontxt.Text.Trim())
                parCmd.Parameters.AddWithValue("@issuedby", oicname.Text.Trim())
                parCmd.Parameters.AddWithValue("@issuedbydesignation", oicdesignation.Text.Trim())
                parCmd.Parameters.AddWithValue("@date", pardatedtm.Value.ToString("yyyy-MM-dd"))
                parCmd.Parameters.AddWithValue("@note", parnotetxt.Text.Trim())
                parCmd.ExecuteNonQuery()

                Dim eqCmd As New MySqlCommand("
                INSERT INTO equipment 
                (propertynumber, description, unit, quantity, date, status, cost, type)
                VALUES (@propertynumber, @description, @unit, @quantity, @date, @status, @cost, @type)", conn, trans)

                eqCmd.Parameters.Add("@propertynumber", MySqlDbType.VarChar)
                eqCmd.Parameters.Add("@description", MySqlDbType.VarChar)
                eqCmd.Parameters.Add("@unit", MySqlDbType.VarChar)
                eqCmd.Parameters.Add("@quantity", MySqlDbType.Int32)
                eqCmd.Parameters.Add("@date", MySqlDbType.VarChar)
                eqCmd.Parameters.Add("@status", MySqlDbType.VarChar)
                eqCmd.Parameters.Add("@cost", MySqlDbType.Decimal)
                eqCmd.Parameters.Add("@type", MySqlDbType.VarChar)

                Dim eqInOutCmd As New MySqlCommand("
                INSERT INTO equipment_inout (sliptype, sliptypeid, propertynumber)
                VALUES (@sliptype, @sliptypeid, @propertynumber)", conn, trans)

                eqInOutCmd.Parameters.Add("@sliptype", MySqlDbType.VarChar).Value = "PAR"
                eqInOutCmd.Parameters.Add("@sliptypeid", MySqlDbType.VarChar).Value = parnotxt.Text.Trim()
                eqInOutCmd.Parameters.Add("@propertynumber", MySqlDbType.VarChar)

                For Each row As DataGridViewRow In pardgv.Rows
                    If row.IsNewRow Then Continue For

                    Dim propertyNumber As String = row.Cells("parpropertynumber").Value?.ToString().Trim()
                    Dim description As String = row.Cells("pardescription").Value?.ToString().Trim()
                    Dim unit As String = row.Cells("parunit").Value?.ToString().Trim()
                    Dim quantity As Integer = Convert.ToInt32(row.Cells("parquantity").Value)
                    Dim dateAcquired As String = row.Cells("pardateaquired").Value?.ToString().Trim()
                    Dim cost As Decimal = Convert.ToDecimal(row.Cells("paramount").Value)

                    Dim eqType As String = If(cost > 50000, "more", "less")

                    eqCmd.Parameters("@propertynumber").Value = propertyNumber
                    eqCmd.Parameters("@description").Value = description
                    eqCmd.Parameters("@unit").Value = unit
                    eqCmd.Parameters("@quantity").Value = quantity
                    eqCmd.Parameters("@date").Value = dateAcquired
                    eqCmd.Parameters("@status").Value = "OUT"
                    eqCmd.Parameters("@cost").Value = cost
                    eqCmd.Parameters("@type").Value = eqType
                    eqCmd.ExecuteNonQuery()

                    eqInOutCmd.Parameters("@propertynumber").Value = propertyNumber
                    eqInOutCmd.ExecuteNonQuery()
                Next

                trans.Commit()




                Try
                    DataSet.PARdatatable.Clear()
                    DataSet.PARgrid.Clear()

                    Dim headerRow As DataSet.PARdatatableRow = DataSet.PARdatatable.NewPARdatatableRow()

                    headerRow.parnumber = parnotxt.Text.Trim()
                    headerRow.pardate = pardatedtm.Value.ToString("yyyy-MM-dd")
                    headerRow.parnote = parnotetxt.Text.Trim()

                    headerRow.parrecommendingapproval = parrecommendingapprovalfirstnametxt.Text.Trim()
                    headerRow.parrecommendingapprovaldesignation = parrecommendingapprovalpositiontxt.Text.Trim()

                    headerRow.parapprovedby = parapprovedbyfirstnametxt.Text.Trim()
                    headerRow.parapprovedbydesignation = parapprovedbypositiontxt.Text.Trim()

                    headerRow.parissuedby = oicname.Text.Trim()
                    headerRow.parissuedbydesignation = oicdesignation.Text.Trim()

                    headerRow.parreceivedby = parreceivedbyfirstnametxt.Text.Trim()
                    headerRow.parreceivedbydesignation = parreceivedbypositiontxt.Text.Trim()


                    DataSet.PARdatatable.Rows.Add(headerRow)

                    For Each dgvr As DataGridViewRow In pardgv.Rows
                        If dgvr.IsNewRow Then Continue For
                        Dim bodyRow As DataSet.PARgridRow = DataSet.PARgrid.NewPARgridRow()
                        bodyRow.parquantity = If(dgvr.Cells("parquantity").Value, "").ToString()
                        bodyRow.parunit = If(dgvr.Cells("parunit").Value, "").ToString()
                        bodyRow.pardescription = If(dgvr.Cells("pardescription").Value, "").ToString()
                        bodyRow.parpropertynumber = If(dgvr.Cells("parpropertynumber").Value, "").ToString()
                        bodyRow.pardateaquired = If(dgvr.Cells("pardateaquired").Value, "").ToString()
                        bodyRow.paramount = If(dgvr.Cells("paramount").Value, "").ToString()
                        DataSet.PARgrid.Rows.Add(bodyRow)
                    Next

                    Dim report As New PAR()
                    report.SetDataSource(DataSet)
                    CRViewer.CrystalReportViewer1.ReportSource = report
                    CRViewer.CrystalReportViewer1.Refresh()
                    CRViewer.ShowDialog()

                Catch ex As Exception
                    MessageBox.Show("Error generating PAR report: " & ex.Message,
                "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try



                MessageBox.Show("PAR saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)




            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("Error saving PAR: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            parnotxt.Clear()
            parrecommendingapprovalfirstnametxt.Clear()
            parrecommendingapprovalpositiontxt.Clear()
            parapprovedbyfirstnametxt.Clear()
            parapprovedbypositiontxt.Clear()
            parreceivedbyfirstnametxt.Clear()
            parreceivedbypositiontxt.Clear()
            parnotetxt.Clear()
            oicname.SelectedIndex = -1
            oicdesignation.Clear()
            pardgv.Rows.Clear()
            pardescriptiondgv.Rows.Clear()

            LoadAutoCompleteData()
            LoadEquipmentCounts(Me)
            LoadEquipmentsData(Me)
            LoadRecentActivity(Me)
            SelectTab("viewequipments")
            SetAllNextNumbers()
        End Using
    End Sub







    Private Sub pardescriptiondgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles pardescriptiondgv.CellContentClick
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)

        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
        If e.ColumnIndex >= dgv.Columns.Count Then Exit Sub
        If e.RowIndex >= dgv.Rows.Count - 1 Then Exit Sub
        If dgv.RowCount <= 1 Then Exit Sub

        If dgv.Columns(e.ColumnIndex).Name = "pardescriptionremove" Then
            dgv.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub


    Private Sub parcancelbtn_Click(sender As Object, e As EventArgs) Handles parcancelbtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit? All fields will be cleared.",
                                                 "Confirm Exit",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            parnotxt.Clear()
            parrecommendingapprovalfirstnametxt.Clear()
            parrecommendingapprovalpositiontxt.Clear()
            parapprovedbyfirstnametxt.Clear()
            parapprovedbypositiontxt.Clear()
            parreceivedbyfirstnametxt.Clear()
            parreceivedbypositiontxt.Clear()
            parnotetxt.Clear()
            pardgv.Rows.Clear()
            pardescriptiondgv.Rows.Clear()
            SetAllNextNumbers()

            SelectTab("viewequipments")
        End If
    End Sub

    Private Sub equipmentoutbtn_Click(sender As Object, e As EventArgs) Handles equipmentoutbtn.Click
        maintbc.SelectedTab = icsdetailstab

    End Sub

    Private Sub icssearchtxt_TextChanged(sender As Object, e As EventArgs) Handles icssearchtxt.TextChanged
        Dim connString As String = (GlobalConnectionString)
        Dim description As String = icssearchtxt.Text.Trim()

        If String.IsNullOrWhiteSpace(description) Then
            icsaddlbl.Text = ""
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Dim query As String = "SELECT propertynumber FROM equipment WHERE status = 'IN' AND description = @description LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@description", description)

                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        icsaddlbl.Text = result.ToString()
                    Else
                        icsaddlbl.Text = "" ' Clear if no match
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading property number: " & ex.Message)
        End Try
    End Sub

    Private Sub SetPropertyNumberLabelForCheckout(searchBox As TextBox, targetLabel As Label)
        Dim connString As String = GlobalConnectionString
        Dim input As String = searchBox.Text.Trim()

        If String.IsNullOrWhiteSpace(input) Then
            targetLabel.Text = ""
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()


                Dim query As String = "
                SELECT propertynumber, description 
                FROM equipment 
                WHERE status = 'OUT' 
                  AND (propertynumber = @input OR description LIKE @inputLike)
                LIMIT 1
            "
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@input", input)
                    cmd.Parameters.AddWithValue("@inputLike", input & "%")

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then

                            targetLabel.Text = reader("propertynumber").ToString().Trim()
                        Else
                            targetLabel.Text = ""
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading property number: " & ex.Message)
        End Try
    End Sub


    Private Sub UpdateICSTotal()
        Dim total As Decimal = 0D

        For Each row As DataGridViewRow In icsdgv.Rows
            If Not row.IsNewRow Then
                Dim cellValue = row.Cells("icstotalcost").Value
                If cellValue IsNot Nothing AndAlso IsNumeric(cellValue) Then
                    total += Convert.ToDecimal(cellValue)
                End If
            End If
        Next

        icstotallbl.Text = total.ToString("N2") ' format with 2 decimal
    End Sub

    Private Sub addicsbtn_Click(sender As Object, e As EventArgs) Handles addicsbtn.Click

        If String.IsNullOrWhiteSpace(icssearchtxt.Text) Then
            MessageBox.Show("Please enter a property number or description before adding.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim connString As String = (GlobalConnectionString)
        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()


                Dim query As String = "
                SELECT quantity, unit, cost, description, propertynumber
                FROM equipment
                WHERE propertynumber = @search OR description LIKE @searchDesc
                LIMIT 1"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", icssearchtxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@searchDesc", "%" & icssearchtxt.Text.Trim() & "%")

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then

                            Dim propNum As String = reader("propertynumber").ToString()
                            icsaddlbl.Text = propNum

                            For Each r As DataGridViewRow In icsdgv.Rows
                                If Not r.IsNewRow AndAlso r.Cells("icspropertynumber").Value IsNot Nothing AndAlso
                               r.Cells("icspropertynumber").Value.ToString() = propNum Then
                                    MessageBox.Show("This equipment is already added.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Exit Sub
                                End If
                            Next

                            Dim qty As Integer = Convert.ToInt32(reader("quantity"))
                            Dim unit As String = reader("unit").ToString()
                            Dim cost As Decimal = Convert.ToDecimal(reader("cost"))
                            Dim rawDesc As String = reader("description").ToString()

                            Dim parts As String() = rawDesc.Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)
                            Dim desc As String = ""
                            If parts.Length > 0 Then
                                Dim firstLine As String = parts(0).Trim()
                                Dim rest As String = String.Join(Environment.NewLine, parts.Skip(1).Select(Function(x) x.Trim()))
                                desc = firstLine & If(String.IsNullOrEmpty(rest), "", Environment.NewLine & rest)
                            Else
                                desc = rawDesc.Trim()
                            End If

                            Dim totalCost As Decimal = qty * cost

                            Dim rowIndex As Integer = icsdgv.Rows.Add()
                            Dim newRow As DataGridViewRow = icsdgv.Rows(rowIndex)

                            newRow.Cells("icsquantity").Value = qty
                            newRow.Cells("icsunit").Value = unit
                            newRow.Cells("icsunitcost").Value = cost
                            newRow.Cells("icstotalcost").Value = totalCost
                            newRow.Cells("icsitemdescription").Value = desc
                            newRow.Cells("icspropertynumber").Value = propNum
                        Else
                            MessageBox.Show("Equipment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End Using
                End Using
            End Using

            icsaddlbl.Text = ""
            icssearchtxt.Text = ""
            icsdgv.ClearSelection()
            UpdateICSTotal()

        Catch ex As Exception
            MessageBox.Show("Error adding equipment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub icsfinishbtn_Click(sender As Object, e As EventArgs) Handles icsfinishbtn.Click
        If String.IsNullOrWhiteSpace(icsfirstnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(icsdesignationtxt.Text) OrElse
       String.IsNullOrWhiteSpace(icsnumbertxt.Text) OrElse
       icsdgv.Rows.Count = 0 Then

            MessageBox.Show("Please complete all required fields and add at least one item.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()


                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim fullname As String = icsfirstnametxt.Text.Trim()

                        Dim insertICS As String = "INSERT INTO ics (icsno, icsdate, purpose, total, receivedfrom, receivedfromdesignation, receivedby, receivedbydesignation) 
                                               VALUES (@icsno, @icsdate, @purpose, @total, @receivedfrom, @receivedfromdesignation, @receivedby, @receivedbydesignation)"

                        Using cmd As New MySqlCommand(insertICS, conn, trans)
                            cmd.Parameters.AddWithValue("@icsno", icsnumbertxt.Text)
                            cmd.Parameters.AddWithValue("@icsdate", icsdatedtp.Value.ToString("yyyy-MM-dd"))
                            cmd.Parameters.AddWithValue("@purpose", icspurposetxt.Text)
                            Dim cleanTotal As Decimal = 0D

                            If Decimal.TryParse(icstotallbl.Text.Replace(",", ""), cleanTotal) Then
                                cmd.Parameters.AddWithValue("@total", cleanTotal)
                            Else
                                MessageBox.Show("Total amount is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                            cmd.Parameters.AddWithValue("@receivedfrom", oicname.Text)
                            cmd.Parameters.AddWithValue("@receivedfromdesignation", oicdesignation.Text)
                            cmd.Parameters.AddWithValue("@receivedby", fullname)
                            cmd.Parameters.AddWithValue("@receivedbydesignation", icsdesignationtxt.Text)
                            cmd.ExecuteNonQuery()
                        End Using

                        For Each row As DataGridViewRow In icsdgv.Rows
                            If Not row.IsNewRow Then
                                Dim propertyNum As String = row.Cells("icspropertynumber").Value.ToString()

                                Dim insertInOut As String = "INSERT INTO equipment_inout (sliptype, sliptypeid, propertynumber, remarks) 
                                                         VALUES (@sliptype, @sliptypeid, @propertynumber, @remarks)"
                                Using cmd As New MySqlCommand(insertInOut, conn, trans)
                                    cmd.Parameters.AddWithValue("@sliptype", "ICS")
                                    cmd.Parameters.AddWithValue("@sliptypeid", icsnumbertxt.Text)
                                    cmd.Parameters.AddWithValue("@propertynumber", propertyNum)
                                    cmd.Parameters.AddWithValue("@remarks", If(row.Cells("icsestimatedusefullife").Value, "").ToString())

                                    cmd.ExecuteNonQuery()
                                End Using

                                Dim updateEquip As String = "UPDATE equipment SET status = 'OUT' WHERE propertynumber = @propertynumber"
                                Using cmdUpdate As New MySqlCommand(updateEquip, conn, trans)
                                    cmdUpdate.Parameters.AddWithValue("@propertynumber", propertyNum)
                                    cmdUpdate.ExecuteNonQuery()
                                End Using
                            End If
                        Next

                        trans.Commit()
                        MessageBox.Show("ICS has been successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)




                        Try
                            DataSet.ICSdatatable.Clear()
                            DataSet.ICSgrid.Clear()



                            Dim headerRow As DataSet.ICSdatatableRow = DataSet.ICSdatatable.NewICSdatatableRow()

                            headerRow.icsnumber = icsnumbertxt.Text.Trim()
                            headerRow.icsdate = icsdatedtp.Value.ToString("yyyy-MM-dd")
                            headerRow.icspurpose = icspurposetxt.Text.Trim()
                            headerRow.icstotal = icstotallbl.Text.Trim()
                            headerRow.icsreceivedfrom = oicname.Text.Trim()
                            headerRow.icsreceivedfromdesignation = oicdesignation.Text.Trim()

                            Dim recvBy As String = icsfirstnametxt.Text.Trim()


                            headerRow.icsreceivedby = recvBy.Trim()
                            headerRow.icsreceivedbydesignation = icsdesignationtxt.Text.Trim()

                            DataSet.ICSdatatable.Rows.Add(headerRow)



                            For Each dgvr As DataGridViewRow In icsdgv.Rows
                                If dgvr.IsNewRow Then Continue For

                                Dim bodyRow As DataSet.ICSgridRow = DataSet.ICSgrid.NewICSgridRow()

                                bodyRow.icsquantity = dgvr.Cells("icsquantity").Value?.ToString()
                                bodyRow.icsunit = dgvr.Cells("icsunit").Value?.ToString()
                                bodyRow.icsunitcost = dgvr.Cells("icsunitcost").Value?.ToString()
                                bodyRow.icstotalcost = dgvr.Cells("icstotalcost").Value?.ToString()
                                bodyRow.icsdescription = dgvr.Cells("icsitemdescription").Value?.ToString()
                                bodyRow.icsinventoryitemnumber = dgvr.Cells("icspropertynumber").Value?.ToString()
                                bodyRow.icsestimateduserfullife = dgvr.Cells("icsestimatedusefullife").Value?.ToString()

                                DataSet.ICSgrid.Rows.Add(bodyRow)
                            Next



                            Dim report As New ICS()  ' ICS.rpt Crystal Report
                            report.SetDataSource(DataSet)

                            With CRViewer.CrystalReportViewer1
                                .ReportSource = report
                                .Refresh()
                            End With

                            CRViewer.ShowDialog()

                        Catch ex As Exception
                            MessageBox.Show("Error generating ICS report: " & ex.Message,
                    "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try





                        icsfirstnametxt.Clear()
                        icsdesignationtxt.Clear()
                        icsnumbertxt.Clear()
                        icspurposetxt.Clear()
                        icstotallbl.Text = ""
                        icsdgv.Rows.Clear()

                        LoadAutoCompleteData()
                        RefreshEquipmentsIn()
                        RefreshEquipmentsOut()
                        SetAllNextNumbers()
                        LoadEquipmentActivity(Me)
                        LoadEquipmentsData(Me)
                        SelectTab("viewequipments")


                    Catch ex As Exception
                        trans.Rollback()
                        MessageBox.Show("Error while saving ICS (rolled back): " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function SafeCell(cell As DataGridViewCell) As String
        If cell Is Nothing OrElse cell.Value Is Nothing OrElse IsDBNull(cell.Value) Then
            Return ""
        Else
            Return cell.Value.ToString().Trim()
        End If
    End Function

    Private Sub gasfinishbtn_Click(sender As Object, e As EventArgs) Handles gasfinishbtn.Click

        If String.IsNullOrWhiteSpace(gasstocknotxt.Text) OrElse
       String.IsNullOrWhiteSpace(gassectioncmb.Text) OrElse
       gasslipdgv.Rows.Count = 0 OrElse
       String.IsNullOrWhiteSpace(gasrequestedbyfirstnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(gasrequestedbypositiontxt.Text) OrElse
       String.IsNullOrWhiteSpace(gasapprovalrecommendedfirstnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(gasapprovalrecommendedpositiontxt.Text) OrElse
       String.IsNullOrWhiteSpace(gasapprovedforissuancefirstnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(gasapprovedforissuancepositiontxt.Text) OrElse
       String.IsNullOrWhiteSpace(oicname.Text) OrElse
       String.IsNullOrWhiteSpace(oicdesignation.Text) Then

            MessageBox.Show("Please fill in all required fields before saving.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()


                If gasfinishbtn.Text = "Finish" Then

                    For Each row As DataGridViewRow In gasslipdgv.Rows
                        If row.IsNewRow Then Continue For

                        Dim insertGas As String =
                    "INSERT INTO gas 
                    (stocknumber, office, gasdate, quantitytobeissued, unit, description, balanceafterthisuse, purpose,
                     requestedby, requestedbydesignation,
                     approvalrecommendedby, approvalrecommendedbydesignation,
                     approvedforissuanceby, approvedforissuancebydesignation,
                     issuedby, issuedbydesignation,
                     receivedby, receivedbydesignation,
                     requestedbyid)
                    VALUES
                    (@stocknumber, @office, @gasdate, @quantitytobeissued, @unit, @description, @balanceafterthisuse, @purpose,
                     @requestedby, @requestedbydesignation,
                     @approvalrecommendedby, @approvalrecommendedbydesignation,
                     @approvedforissuanceby, @approvedforissuancebydesignation,
                     @issuedby, @issuedbydesignation,
                     @receivedby, @receivedbydesignation,
                     @requestedbyid);"

                        Using cmd As New MySqlCommand(insertGas, conn)
                            Dim qty As Integer = Val(SafeCell(row.Cells("gas_quantitytobeissued")))
                            Dim bal As Integer = Val(SafeCell(row.Cells("gas_balance")))

                            cmd.Parameters.AddWithValue("@stocknumber", gasstocknotxt.Text)
                            cmd.Parameters.AddWithValue("@office", gassectioncmb.Text)
                            cmd.Parameters.AddWithValue("@gasdate", gasdatedtm.Value.ToString("yyyy-MM-dd"))
                            cmd.Parameters.AddWithValue("@quantitytobeissued", qty)
                            cmd.Parameters.AddWithValue("@unit", SafeCell(row.Cells("gas_unit")))
                            cmd.Parameters.AddWithValue("@description", SafeCell(row.Cells("gas_description")))
                            cmd.Parameters.AddWithValue("@balanceafterthisuse", bal)
                            cmd.Parameters.AddWithValue("@purpose", SafeCell(row.Cells("gas_purpose")))

                            Dim requestedBy As String = gasrequestedbyfirstnametxt.Text.Trim()
                            Dim recommendedBy As String = gasapprovalrecommendedfirstnametxt.Text.Trim()
                            Dim approvedBy As String = gasapprovedforissuancefirstnametxt.Text.Trim()

                            cmd.Parameters.AddWithValue("@requestedby", requestedBy)
                            cmd.Parameters.AddWithValue("@requestedbydesignation", gasrequestedbypositiontxt.Text)
                            cmd.Parameters.AddWithValue("@approvalrecommendedby", recommendedBy)
                            cmd.Parameters.AddWithValue("@approvalrecommendedbydesignation", gasapprovalrecommendedpositiontxt.Text)
                            cmd.Parameters.AddWithValue("@approvedforissuanceby", approvedBy)
                            cmd.Parameters.AddWithValue("@approvedforissuancebydesignation", gasapprovedforissuancepositiontxt.Text)
                            cmd.Parameters.AddWithValue("@issuedby", oicname.Text)
                            cmd.Parameters.AddWithValue("@issuedbydesignation", oicdesignation.Text)
                            cmd.Parameters.AddWithValue("@receivedby", requestedBy)
                            cmd.Parameters.AddWithValue("@receivedbydesignation", gasrequestedbypositiontxt.Text)
                            cmd.Parameters.AddWithValue("@requestedbyid", gasstocknotxt.Text)

                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                ElseIf gasfinishbtn.Text = "Update" Then

                    Dim dbIssuedBy As String = ""
                    Dim dbIssuedByDesignation As String = ""

                    Using fetch As New MySqlCommand("SELECT issuedby, issuedbydesignation FROM gas WHERE stocknumber=@stocknumber LIMIT 1;", conn)
                        fetch.Parameters.AddWithValue("@stocknumber", gasstocknotxt.Text)
                        Using rdr As MySqlDataReader = fetch.ExecuteReader()
                            If rdr.Read() Then
                                dbIssuedBy = rdr("issuedby").ToString()
                                dbIssuedByDesignation = rdr("issuedbydesignation").ToString()
                            End If
                        End Using
                    End Using

                    Using del As New MySqlCommand("DELETE FROM gas WHERE stocknumber=@stocknumber;", conn)
                        del.Parameters.AddWithValue("@stocknumber", gasstocknotxt.Text)
                        del.ExecuteNonQuery()
                    End Using

                    For Each row As DataGridViewRow In gasslipdgv.Rows
                        If row.IsNewRow Then Continue For

                        Dim updateGas As String =
                    "INSERT INTO gas 
                    (stocknumber, office, gasdate, quantitytobeissued, unit, description, balanceafterthisuse, purpose,
                     requestedby, requestedbydesignation,
                     approvalrecommendedby, approvalrecommendedbydesignation,
                     approvedforissuanceby, approvedforissuancebydesignation,
                     issuedby, issuedbydesignation,
                     receivedby, receivedbydesignation,
                     requestedbyid)
                    VALUES
                    (@stocknumber, @office, @gasdate, @quantitytobeissued, @unit, @description, @balanceafterthisuse, @purpose,
                     @requestedby, @requestedbydesignation,
                     @approvalrecommendedby, @approvalrecommendedbydesignation,
                     @approvedforissuanceby, @approvedforissuancebydesignation,
                     @issuedby, @issuedbydesignation,
                     @receivedby, @receivedbydesignation,
                     @requestedbyid);"

                        Using cmd As New MySqlCommand(updateGas, conn)
                            Dim qty As Integer = Val(SafeCell(row.Cells("gas_quantitytobeissued")))
                            Dim bal As Integer = Val(SafeCell(row.Cells("gas_balance")))

                            cmd.Parameters.AddWithValue("@stocknumber", gasstocknotxt.Text)
                            cmd.Parameters.AddWithValue("@office", gassectioncmb.Text)
                            cmd.Parameters.AddWithValue("@gasdate", gasdatedtm.Value.ToString("yyyy-MM-dd"))
                            cmd.Parameters.AddWithValue("@quantitytobeissued", qty)
                            cmd.Parameters.AddWithValue("@unit", SafeCell(row.Cells("gas_unit")))
                            cmd.Parameters.AddWithValue("@description", SafeCell(row.Cells("gas_description")))
                            cmd.Parameters.AddWithValue("@balanceafterthisuse", bal)
                            cmd.Parameters.AddWithValue("@purpose", SafeCell(row.Cells("gas_purpose")))

                            Dim requestedBy As String = gasrequestedbyfirstnametxt.Text.Trim()
                            Dim recommendedBy As String = gasapprovalrecommendedfirstnametxt.Text.Trim()
                            Dim approvedBy As String = gasapprovedforissuancefirstnametxt.Text.Trim()

                            cmd.Parameters.AddWithValue("@requestedby", requestedBy)
                            cmd.Parameters.AddWithValue("@requestedbydesignation", gasrequestedbypositiontxt.Text)
                            cmd.Parameters.AddWithValue("@approvalrecommendedby", recommendedBy)
                            cmd.Parameters.AddWithValue("@approvalrecommendedbydesignation", gasapprovalrecommendedpositiontxt.Text)
                            cmd.Parameters.AddWithValue("@approvedforissuanceby", approvedBy)
                            cmd.Parameters.AddWithValue("@approvedforissuancebydesignation", gasapprovedforissuancepositiontxt.Text)
                            cmd.Parameters.AddWithValue("@issuedby", dbIssuedBy)
                            cmd.Parameters.AddWithValue("@issuedbydesignation", dbIssuedByDesignation)
                            cmd.Parameters.AddWithValue("@receivedby", requestedBy)
                            cmd.Parameters.AddWithValue("@receivedbydesignation", gasrequestedbypositiontxt.Text)
                            cmd.Parameters.AddWithValue("@requestedbyid", gasstocknotxt.Text)

                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    gasfinishbtn.Text = "Finish"
                End If
            End Using

            Try
                DataSet.GASdatatable.Clear()
                DataSet.GASgrid.Clear()

                Dim headerRow As DataSet.GASdatatableRow = DataSet.GASdatatable.NewGASdatatableRow()
                headerRow.gassection = gassectioncmb.Text.Trim()
                headerRow.gasstocknumber = gasstocknotxt.Text.Trim()
                headerRow.gasdate = gasdatedtm.Value.ToString("yyyy-MM-dd")

                Dim requestedBy As String = gasrequestedbyfirstnametxt.Text.Trim()
                Dim recommendedBy As String = gasapprovalrecommendedfirstnametxt.Text.Trim()
                Dim approvedBy As String = gasapprovedforissuancefirstnametxt.Text.Trim()

                headerRow.gasrequestedby = requestedBy
                headerRow.gasrequestedbyposition = gasrequestedbypositiontxt.Text
                headerRow.gasapprovalrecommendedby = recommendedBy
                headerRow.gasapprovedfor = approvedBy
                headerRow.gasapprovedforposition = gasapprovedforissuancepositiontxt.Text

                If gasfinishbtn.Text = "Finish" Then
                    headerRow.gasissuedby = oicname.Text
                    headerRow.gasissuedbyposition = oicdesignation.Text
                Else
                    headerRow.gasissuedby = ""
                    headerRow.gasissuedbyposition = ""
                End If

                DataSet.GASdatatable.Rows.Add(headerRow)

                For Each r As DataGridViewRow In gasslipdgv.Rows
                    If r.IsNewRow Then Continue For

                    Dim row As DataSet.GASgridRow = DataSet.GASgrid.NewGASgridRow()
                    row.gasqty = SafeCell(r.Cells("gas_quantitytobeissued"))
                    row.gasunit = SafeCell(r.Cells("gas_unit"))
                    row.gasdescription = SafeCell(r.Cells("gas_description"))
                    row.gasbalance = SafeCell(r.Cells("gas_balance"))
                    row.gaspurpose = SafeCell(r.Cells("gas_purpose"))

                    DataSet.GASgrid.Rows.Add(row)
                Next

                Dim report As New Gas()
                report.SetDataSource(DataSet)
                CRViewer.CrystalReportViewer1.ReportSource = report
                CRViewer.CrystalReportViewer1.Refresh()
                CRViewer.ShowDialog()

            Catch ex As Exception
                MessageBox.Show("Report generation failed: " & ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            gasstocknotxt.Clear()
            gassectioncmb.SelectedIndex = -1
            gasdatedtm.Value = Date.Now
            gasrequestedbyfirstnametxt.Clear()
            gasrequestedbypositiontxt.Clear()
            gasapprovalrecommendedfirstnametxt.Clear()
            gasapprovalrecommendedpositiontxt.Clear()
            gasapprovedforissuancefirstnametxt.Clear()
            gasapprovedforissuancepositiontxt.Clear()
            gasslipdgv.Rows.Clear()

            gasstocknotxt.ReadOnly = False
            gasfinishbtn.Text = "Finish"
            LoadGasData(Me)
            SetAllNextNumbers()
            SelectTab("viewgastransactions")

        Catch ex As Exception
            MessageBox.Show("Error while saving GAS: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub





    Private Sub gascancelbtn_Click(sender As Object, e As EventArgs) Handles gascancelbtn.Click
        Dim result As DialogResult = MessageBox.Show("All fields will be cleared. Do you want to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            gasstocknotxt.Clear()
            gassectioncmb.SelectedIndex = -1
            gasrequestedbyfirstnametxt.Clear()
            gasrequestedbypositiontxt.Clear()
            gasapprovalrecommendedfirstnametxt.Clear()
            gasapprovalrecommendedpositiontxt.Clear()
            gasapprovedforissuancefirstnametxt.Clear()
            gasapprovedforissuancepositiontxt.Clear()
            gasslipdgv.Rows.Clear()
            gasfinishbtn.Text = "Finish"
            SetAllNextNumbers()
            SelectTab("viewgastransactions")
        End If
    End Sub


    Private connectionString As String = (GlobalConnectionString)
    Private Sub rrspaddbtn_Click(sender As Object, e As EventArgs) Handles rrspaddbtn.Click


        Dim searchValue As String = rrspsearchlbl.Text.Trim()
        If searchValue = "" Then
            MessageBox.Show("Please enter a search value.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()


                Dim endUser As String = rrspfirstnametxt.Text.Trim()

                Dim propertyNumber As String = Nothing

                Dim query As String = "SELECT propertynumber, description, unit, quantity, cost FROM equipment WHERE status='OUT' AND cost<50000"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim propNo As String = reader("propertynumber").ToString().Trim()
                            Dim desc As String = reader("description").ToString().Trim()
                            Dim firstLine As String = desc.Split({vbCrLf, vbLf}, StringSplitOptions.None)(0).Trim()
                            If searchValue = propNo OrElse searchValue = firstLine Then
                                propertyNumber = propNo
                                Exit While
                            End If
                        End While
                    End Using
                End Using

                If propertyNumber Is Nothing Then
                    MessageBox.Show("No matching equipment found with status 'OUT' and cost < 50,000.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                For Each row As DataGridViewRow In rrspdgv.Rows
                    If row.Cells("rrsp_propertynumber").Value IsNot Nothing AndAlso
                   row.Cells("rrsp_propertynumber").Value.ToString() = propertyNumber Then
                        MessageBox.Show("This property number is already in the list.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        rrspsearchtxt.Clear()
                        rrspsearchtxt.Focus()
                        Return
                    End If
                Next

                Dim qty As Integer = 0
                Dim unit As String = ""
                Dim descFull As String = ""
                Dim cost As Decimal = 0D

                Dim queryEquip As String = "SELECT quantity, unit, description, cost FROM equipment WHERE propertynumber=@prop LIMIT 1"
                Using cmdEquip As New MySqlCommand(queryEquip, conn)
                    cmdEquip.Parameters.AddWithValue("@prop", propertyNumber)
                    Using r = cmdEquip.ExecuteReader()
                        If r.Read() Then
                            qty = Convert.ToInt32(r("quantity"))
                            unit = r("unit").ToString()
                            descFull = r("description").ToString()
                            cost = Convert.ToDecimal(r("cost"))
                        End If
                    End Using
                End Using

                If cost * qty > 50000 Then
                    MessageBox.Show("Total cost exceeds 50,000. Cannot add item.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim latestSlipNumber As String = ""
                Dim latestEndUser As String = ""
                Dim latestDate As DateTime = DateTime.MinValue
                Dim slipRecords As New List(Of Tuple(Of String, String))()
                Dim queryInOut As String = "SELECT sliptype, sliptypeid FROM equipment_inout WHERE propertynumber=@prop"
                Using cmdInOut As New MySqlCommand(queryInOut, conn)
                    cmdInOut.Parameters.AddWithValue("@prop", propertyNumber)
                    Using readerInOut As MySqlDataReader = cmdInOut.ExecuteReader()
                        While readerInOut.Read()
                            slipRecords.Add(Tuple.Create(readerInOut("sliptype").ToString(), readerInOut("sliptypeid").ToString()))
                        End While
                    End Using
                End Using

                For Each rec In slipRecords
                    Dim slipType As String = rec.Item1
                    Dim slipID As String = rec.Item2

                    If slipType = "ICS" Then
                        Dim queryICS As String = "SELECT icsno, receivedby, icsdate FROM ics WHERE icsno=@id LIMIT 1"
                        Using cmdICS As New MySqlCommand(queryICS, conn)
                            cmdICS.Parameters.AddWithValue("@id", slipID)
                            Using r As MySqlDataReader = cmdICS.ExecuteReader()
                                If r.Read() Then
                                    Dim dt As DateTime = Convert.ToDateTime(r("icsdate"))
                                    If dt > latestDate Then
                                        latestDate = dt
                                        latestSlipNumber = r("icsno").ToString()
                                        latestEndUser = r("receivedby").ToString()
                                    End If
                                End If
                            End Using
                        End Using
                    ElseIf slipType = "PAR" Then
                        Dim queryPAR As String = "SELECT parnumber, receivedby, date FROM par WHERE parnumber=@id LIMIT 1"
                        Using cmdPAR As New MySqlCommand(queryPAR, conn)
                            cmdPAR.Parameters.AddWithValue("@id", slipID)
                            Using r As MySqlDataReader = cmdPAR.ExecuteReader()
                                If r.Read() Then
                                    Dim dt As DateTime = Convert.ToDateTime(r("date"))
                                    If dt > latestDate Then
                                        latestDate = dt
                                        latestSlipNumber = r("parnumber").ToString()
                                        latestEndUser = r("receivedby").ToString()
                                    End If
                                End If
                            End Using
                        End Using
                    End If
                Next

                Dim rowIndex As Integer = rrspdgv.Rows.Add()
                rrspdgv.Rows(rowIndex).Cells("rrsp_quantity").Value = qty
                rrspdgv.Rows(rowIndex).Cells("rrsp_unit").Value = unit
                rrspdgv.Rows(rowIndex).Cells("rrsp_itemdescription").Value = descFull
                rrspdgv.Rows(rowIndex).Cells("rrsp_propertynumber").Value = propertyNumber
                rrspdgv.Rows(rowIndex).Cells("rrsp_icsgpnumber").Value = latestSlipNumber
                rrspdgv.Rows(rowIndex).Cells("rrsp_enduser").Value = latestEndUser

                rrspdgv.Rows(rowIndex).Cells("rrsp_remarks").Value = ""

            End Using

            rrspsearchtxt.Clear()
            rrspdgv.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub rrspfinishbtn_Click(sender As Object, e As EventArgs) Handles rrspfinishbtn.Click
        If String.IsNullOrWhiteSpace(rrspnumbertxt.Text) OrElse
       String.IsNullOrWhiteSpace(rrspdatedtm.Text) OrElse
       String.IsNullOrWhiteSpace(rrspfirstnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(rrspdesignationtxt.Text) OrElse
       String.IsNullOrWhiteSpace(oicname.Text) OrElse
       String.IsNullOrWhiteSpace(oicdesignation.Text) Then
            MessageBox.Show("Please fill in all required fields. Remarks can be left empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If rrspdgv.Rows.Count = 0 OrElse rrspdgv.Rows.Cast(Of DataGridViewRow).All(Function(r) r.IsNewRow) Then
            MessageBox.Show("Please add at least one item to the RRSP before saving.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim returnedBy As String = rrspfirstnametxt.Text.Trim()

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()


                Dim rrspInsert As String = "
                INSERT IGNORE INTO rrsp (rrspnumber, date, returnedby, returnedbydesignation, receivedby, receivedbydesignation)
                VALUES (@rrspnumber, @date, @returnedby, @returnedbydesignation, @receivedby, @receivedbydesignation)
            "
                Using cmd As New MySqlCommand(rrspInsert, conn)
                    cmd.Parameters.AddWithValue("@rrspnumber", rrspnumbertxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@date", rrspdatedtm.Value)
                    cmd.Parameters.AddWithValue("@returnedby", returnedBy)
                    cmd.Parameters.AddWithValue("@returnedbydesignation", rrspdesignationtxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@receivedby", oicname.Text.Trim())
                    cmd.Parameters.AddWithValue("@receivedbydesignation", oicdesignation.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

                For Each dgvr As DataGridViewRow In rrspdgv.Rows
                    If dgvr.IsNewRow Then Continue For

                    Dim propertyNumber As String = If(dgvr.Cells("rrsp_propertynumber").Value, "").ToString().Trim()
                    Dim remarks As String = If(dgvr.Cells("rrsp_remarks").Value, "").ToString().Trim()
                    If String.IsNullOrWhiteSpace(propertyNumber) Then Continue For

                    Dim insertQuery As String = "
                    INSERT INTO equipment_inout (sliptype, sliptypeid, propertynumber, remarks)
                    VALUES ('RRSP', @sliptypeid, @propertynumber, @remarks)
                "
                    Using cmd As New MySqlCommand(insertQuery, conn)
                        cmd.Parameters.AddWithValue("@sliptypeid", rrspnumbertxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@propertynumber", propertyNumber)
                        cmd.Parameters.AddWithValue("@remarks", remarks)
                        cmd.ExecuteNonQuery()
                    End Using

                    Dim updateQuery As String = "
                    UPDATE equipment
                    SET status = 'IN'
                    WHERE propertynumber = @propertynumber
                "
                    Using cmd As New MySqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@propertynumber", propertyNumber)
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using


            MessageBox.Show("RRSP has been successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            DataSet.RRSPdatatable.Clear()
            DataSet.RRSPgrid.Clear()


            Dim headerRow As DataSet.RRSPdatatableRow = DataSet.RRSPdatatable.NewRRSPdatatableRow()
            headerRow.rrspnumber = rrspnumbertxt.Text
            headerRow.rrspdate = rrspdatedtm.Value.ToString("yyyy-MM-dd")
            Dim formattedName As String = rrspfirstnametxt.Text.Trim()
            headerRow.rrsprelieving = formattedName
            headerRow.rrspreturnedby = formattedName
            headerRow.rrspreturnedbydesignation = rrspdesignationtxt.Text
            headerRow.rrspreceivedby = oicname.Text
            headerRow.rrspreceivedbydesignation = oicdesignation.Text
            DataSet.RRSPdatatable.Rows.Add(headerRow)


            For Each dgvr As DataGridViewRow In rrspdgv.Rows
                If dgvr.IsNewRow Then Continue For

                Dim bodyRow As DataSet.RRSPgridRow = DataSet.RRSPgrid.NewRRSPgridRow()
                bodyRow.rrspdescription = If(dgvr.Cells("rrsp_itemdescription").Value, "").ToString()
                bodyRow.rrspquantity = If(dgvr.Cells("rrsp_quantity").Value, "").ToString()
                bodyRow.rrspunit = If(dgvr.Cells("rrsp_unit").Value, "").ToString()
                bodyRow.rrspicsgpnumber = If(dgvr.Cells("rrsp_icsgpnumber").Value, "").ToString()
                bodyRow.rrspenduser = If(dgvr.Cells("rrsp_enduser").Value, "").ToString()
                bodyRow.rrspremarks = If(dgvr.Cells("rrsp_remarks").Value, "").ToString()
                DataSet.RRSPgrid.Rows.Add(bodyRow)
            Next


            Dim report As New RRSP()
            report.SetDataSource(DataSet)
            CRViewer.CrystalReportViewer1.ReportSource = report
            CRViewer.CrystalReportViewer1.Refresh()
            CRViewer.ShowDialog()

            rrspnumbertxt.Clear()
            rrspfirstnametxt.Clear()
            rrspdesignationtxt.Clear()
            rrspdatedtm.Value = DateTime.Now
            rrspdgv.Rows.Clear()
            rrspsearchtxt.Clear()


            LoadAutoCompleteData()
            LoadEquipmentCounts(Me)
            LoadEquipmentsData(Me)
            LoadRecentActivity(Me)
            SelectTab("viewequipments")
            SetAllNextNumbers()

        Catch ex As Exception
            MessageBox.Show("Error while saving RRSP: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub









    Private Sub rrspcancelbtn_Click(sender As Object, e As EventArgs) Handles rrspcancelbtn.Click
        Dim result As DialogResult = MessageBox.Show("All fields will be cleared. Do you want to continue?",
                                                     "Confirm Cancel",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            rrspnumbertxt.Clear()
            rrspfirstnametxt.Clear()
            rrspdesignationtxt.Clear()
            rrspsearchtxt.Clear()
            rrspdatedtm.Value = DateTime.Now
            rrspdgv.Rows.Clear()
            SetAllNextNumbers()

            SelectTab("viewequipments")
        End If
    End Sub

    Private Sub prsaddbtn_Click(sender As Object, e As EventArgs) Handles prsaddbtn.Click


        If String.IsNullOrWhiteSpace(prssearchlbl.Text) Then
            MessageBox.Show("Please enter a description or property number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim searchText As String = prssearchlbl.Text.Trim()
        Using conn As New MySqlConnection(GlobalConnectionString)
            conn.Open()


            Dim propertyNumber As String = Nothing
            Dim queryFind As String = "SELECT propertynumber FROM equipment WHERE (description = @search OR propertynumber = @search) AND status = 'OUT' LIMIT 1"
            Using cmdFind As New MySqlCommand(queryFind, conn)
                cmdFind.Parameters.AddWithValue("@search", searchText)
                Dim result = cmdFind.ExecuteScalar()
                If result Is Nothing Then
                    MessageBox.Show("No matching equipment found with status 'OUT'.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                propertyNumber = result.ToString()
            End Using


            For Each row As DataGridViewRow In prsdgv.Rows
                If row.Cells("prs_propertynumber").Value IsNot Nothing AndAlso
               row.Cells("prs_propertynumber").Value.ToString() = propertyNumber Then
                    MessageBox.Show("This property number is already in the list.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    prssearchtxt.Clear()
                    prssearchtxt.Focus()
                    Exit Sub
                End If
            Next


            Dim qty As Integer = 0
            Dim unit As String = ""
            Dim desc As String = ""
            Dim cost As Decimal = 0D

            Dim queryEquip As String = "SELECT quantity, unit, description, cost FROM equipment WHERE propertynumber = @prop LIMIT 1"
            Using cmdEquip As New MySqlCommand(queryEquip, conn)
                cmdEquip.Parameters.AddWithValue("@prop", propertyNumber)
                Using r = cmdEquip.ExecuteReader()
                    If r.Read() Then
                        qty = Convert.ToInt32(r("quantity"))
                        unit = r("unit").ToString()
                        desc = r("description").ToString()
                        cost = Convert.ToDecimal(r("cost"))
                    End If
                End Using
            End Using


            Dim latestUser As String = ""
            Dim latestDate As DateTime = DateTime.MinValue
            Dim slipRecords As New List(Of Tuple(Of String, String))()

            Dim queryInOut As String = "SELECT sliptype, sliptypeid FROM equipment_inout WHERE propertynumber = @prop"
            Using cmdInOut As New MySqlCommand(queryInOut, conn)
                cmdInOut.Parameters.AddWithValue("@prop", propertyNumber)
                Using readerInOut As MySqlDataReader = cmdInOut.ExecuteReader()
                    While readerInOut.Read()
                        slipRecords.Add(Tuple.Create(readerInOut("sliptype").ToString(),
                                                 readerInOut("sliptypeid").ToString()))
                    End While
                End Using
            End Using


            For Each rec In slipRecords
                Dim sliptype As String = rec.Item1
                Dim slipid As String = rec.Item2

                If sliptype = "ICS" Then
                    Dim queryICS As String = "SELECT receivedby, icsdate FROM ics WHERE icsno = @id LIMIT 1"
                    Using cmdICS As New MySqlCommand(queryICS, conn)
                        cmdICS.Parameters.AddWithValue("@id", slipid)
                        Using r As MySqlDataReader = cmdICS.ExecuteReader()
                            If r.Read() Then
                                Dim rcv As String = r("receivedby").ToString()
                                Dim dt As DateTime = Convert.ToDateTime(r("icsdate"))
                                If dt > latestDate Then
                                    latestDate = dt
                                    latestUser = rcv
                                End If
                            End If
                        End Using
                    End Using

                ElseIf sliptype = "PAR" Then
                    Dim queryPAR As String = "SELECT receivedby, date FROM par WHERE parnumber = @id LIMIT 1"
                    Using cmdPAR As New MySqlCommand(queryPAR, conn)
                        cmdPAR.Parameters.AddWithValue("@id", slipid)
                        Using r As MySqlDataReader = cmdPAR.ExecuteReader()
                            If r.Read() Then
                                Dim rcv As String = r("receivedby").ToString()
                                Dim dt As DateTime = Convert.ToDateTime(r("date"))
                                If dt > latestDate Then
                                    latestDate = dt
                                    latestUser = rcv
                                End If
                            End If
                        End Using
                    End Using
                End If
            Next


            Dim totalValue As Decimal = qty * cost


            prsdgv.Rows.Add(qty, unit, desc, propertyNumber, "", latestUser, cost, totalValue, "", "")


            Dim grandTotal As Decimal = 0D
            For Each row As DataGridViewRow In prsdgv.Rows
                If row.Cells("prs_totalvalue").Value IsNot Nothing Then
                    grandTotal += Convert.ToDecimal(row.Cells("prs_totalvalue").Value)
                End If
            Next
            prstotallbl.Text = grandTotal.ToString("N2")
        End Using


        prssearchtxt.Clear()
        prsdgv.ClearSelection()
    End Sub


    Private Sub prsfinishbtn_Click(sender As Object, e As EventArgs) Handles prsfinishbtn.Click

        If String.IsNullOrWhiteSpace(prsfirstnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(prsdesignationtxt.Text) OrElse
       prsofficecmb.SelectedIndex = -1 OrElse
       (String.IsNullOrWhiteSpace(prspurposecmb.Text) AndAlso String.IsNullOrWhiteSpace(prsothertxt.Text)) Then

            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If prsdgv.Rows.Count = 0 OrElse prsdgv.Rows.Cast(Of DataGridViewRow).All(Function(r) r.IsNewRow) Then
            MessageBox.Show("Please add at least one equipment item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Dim tran As MySqlTransaction = conn.BeginTransaction()

                Try


                    Dim insertedSummary As New System.Text.StringBuilder


                    For Each row As DataGridViewRow In prsdgv.Rows
                        If row.IsNewRow Then Continue For

                        Dim propertyNumber As String = If(row.Cells("prs_propertynumber").Value, "").ToString().Trim()
                        Dim remarks As String = If(row.Cells("prs_remarks").Value, "").ToString().Trim()

                        If propertyNumber = "" Then Continue For

                        Dim insertInOut As String = "
        INSERT INTO equipment_inout 
        (sliptype, sliptypeid, propertynumber, remarks)
        VALUES (@sliptype, @sliptypeid, @propertynumber, @remarks)
    "

                        Using cmd As New MySqlCommand(insertInOut, conn, tran)
                            cmd.Parameters.AddWithValue("@sliptype", "PRS")
                            cmd.Parameters.AddWithValue("@sliptypeid", prsnumbertxt.Text.Trim())
                            cmd.Parameters.AddWithValue("@propertynumber", propertyNumber)
                            cmd.Parameters.AddWithValue("@remarks", remarks)
                            cmd.ExecuteNonQuery()
                        End Using

                        insertedSummary.AppendLine("Slip Type: PRS")
                        insertedSummary.AppendLine("Slip Number: " & prsnumbertxt.Text.Trim())
                        insertedSummary.AppendLine("Property Number: " & propertyNumber)
                        insertedSummary.AppendLine("Remarks: " & remarks)
                        insertedSummary.AppendLine("---------------------------------------------------")
                        insertedSummary.AppendLine()

                        Dim updateEquip As String = "
        UPDATE equipment 
        SET status = 'IN' 
        WHERE propertynumber = @propertynumber
    "

                        Using cmd As New MySqlCommand(updateEquip, conn, tran)
                            cmd.Parameters.AddWithValue("@propertynumber", propertyNumber)
                            cmd.ExecuteNonQuery()
                        End Using

                    Next





                    Dim returnedByDesignation As String = ""
                    Dim returnedBy As String = ""
                    Dim firstPropertyNumber As String = prsdgv.Rows(0).Cells("prs_propertynumber").Value.ToString()

                    Dim queryInOut As String = "SELECT sliptype, sliptypeid FROM equipment_inout WHERE propertynumber = @prop"
                    Using cmd As New MySqlCommand(queryInOut, conn, tran)
                        cmd.Parameters.AddWithValue("@prop", firstPropertyNumber)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            Dim slipRecords As New List(Of Tuple(Of String, String))()
                            While reader.Read()
                                slipRecords.Add(Tuple.Create(reader("sliptype").ToString(), reader("sliptypeid").ToString()))
                            End While
                            reader.Close()

                            Dim latestNumber As String = "00000"
                            For Each rec In slipRecords
                                Dim sliptype As String = rec.Item1
                                Dim slipid As String = rec.Item2

                                If sliptype = "ICS" Then
                                    Dim queryICS As String = "SELECT receivedby, receivedbydesignation FROM ics WHERE icsno = @id LIMIT 1"
                                    Using cmdICS As New MySqlCommand(queryICS, conn, tran)
                                        cmdICS.Parameters.AddWithValue("@id", slipid)
                                        Using r = cmdICS.ExecuteReader()
                                            If r.Read() Then
                                                Dim currentNumber As String = slipid.Split("-"c)(2)
                                                If String.Compare(currentNumber, latestNumber) > 0 Then
                                                    latestNumber = currentNumber
                                                    returnedByDesignation = r("receivedbydesignation").ToString()
                                                    returnedBy = r("receivedby").ToString()
                                                End If
                                            End If
                                        End Using
                                    End Using

                                ElseIf sliptype = "PAR" Then
                                    Dim queryPAR As String = "SELECT receivedby, receivedbydesignation FROM par WHERE parnumber = @id LIMIT 1"
                                    Using cmdPAR As New MySqlCommand(queryPAR, conn, tran)
                                        cmdPAR.Parameters.AddWithValue("@id", slipid)
                                        Using r = cmdPAR.ExecuteReader()
                                            If r.Read() Then
                                                Dim currentNumber As String = slipid.Split("-"c)(2)
                                                If String.Compare(currentNumber, latestNumber) > 0 Then
                                                    latestNumber = currentNumber
                                                    returnedByDesignation = r("receivedbydesignation").ToString()
                                                    returnedBy = r("receivedby").ToString()
                                                End If
                                            End If
                                        End Using
                                    End Using
                                End If
                            Next
                        End Using
                    End Using



                    Dim fullname As String = prsfirstnametxt.Text.Trim()

                    Dim purpose As String = If(prspurposecmb.Text.Trim() = "Other:", prsothertxt.Text.Trim(), prspurposecmb.Text.Trim())

                    Dim insertPRS As String = "
                    INSERT INTO prs 
                    (prsnumber, date, office, purpose, note, returnedby, returnedbydesignation, 
                     receivedby, receivedbydesignation, approvedby, approvedbydesignation) 
                    VALUES 
                    (@prsnumber, @date, @office, @purpose, @note, @returnedby, @returnedbydesignation, 
                     @receivedby, @receivedbydesignation, @approvedby, @approvedbydesignation)
                "

                    Using cmd As New MySqlCommand(insertPRS, conn, tran)
                        cmd.Parameters.AddWithValue("@prsnumber", prsnumbertxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@date", prsdatedtm.Value.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@office", prsofficecmb.Text)
                        cmd.Parameters.AddWithValue("@purpose", purpose)
                        cmd.Parameters.AddWithValue("@note", prsnotetxt.Text)
                        cmd.Parameters.AddWithValue("@returnedby", returnedBy)
                        cmd.Parameters.AddWithValue("@returnedbydesignation", returnedByDesignation)
                        cmd.Parameters.AddWithValue("@receivedby", oicname.Text)
                        cmd.Parameters.AddWithValue("@receivedbydesignation", oicdesignation.Text)
                        cmd.Parameters.AddWithValue("@approvedby", fullname)
                        cmd.Parameters.AddWithValue("@approvedbydesignation", prsdesignationtxt.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    tran.Commit()

                    DataSet.PRSdatatable.Clear()
                    DataSet.PRSgrid.Clear()

                    Dim headerRow As DataSet.PRSdatatableRow = DataSet.PRSdatatable.NewPRSdatatableRow()
                    headerRow.prsoffice = prsofficecmb.Text
                    headerRow.prspurpose = purpose
                    headerRow.prsdate = prsdatedtm.Value.ToString("yyyy-MM-dd")
                    headerRow.prsnote = prsnotetxt.Text
                    headerRow.prsreturnedby = returnedBy
                    headerRow.prsreturnedbydesignation = returnedByDesignation
                    headerRow.prsreceivedby = oicname.Text
                    headerRow.prsreceivedbydesignation = oicdesignation.Text
                    headerRow.prsapprovedby = fullname
                    headerRow.prsapprovedbydesignation = prsdesignationtxt.Text
                    DataSet.PRSdatatable.Rows.Add(headerRow)

                    For Each row As DataGridViewRow In prsdgv.Rows
                        If row.IsNewRow Then Continue For
                        Dim bodyRow As DataSet.PRSgridRow = DataSet.PRSgrid.NewPRSgridRow()
                        bodyRow.prsquantity = If(row.Cells("prs_qty").Value, "").ToString()
                        bodyRow.prsunit = If(row.Cells("prs_unit").Value, "").ToString()
                        bodyRow.prsdescription = If(row.Cells("prs_itemdescription").Value, "").ToString()
                        bodyRow.prspropertynumber = If(row.Cells("prs_propertynumber").Value, "").ToString()
                        bodyRow.prsarenumber = If(row.Cells("prs_areno").Value, "").ToString()
                        bodyRow.prsnameofenduser = If(row.Cells("prs_enduser").Value, "").ToString()
                        bodyRow.prsunitvalue = Decimal.Parse(If(row.Cells("prs_unitvalue").Value, "0").ToString())
                        bodyRow.prstotalvalue = Decimal.Parse(If(row.Cells("prs_totalvalue").Value, "0").ToString())
                        bodyRow.prsremarks = If(row.Cells("prs_remarks").Value, "").ToString()
                        DataSet.PRSgrid.Rows.Add(bodyRow)
                    Next

                    Dim report As New PRS()
                    report.SetDataSource(DataSet)
                    CRViewer.CrystalReportViewer1.ReportSource = report
                    CRViewer.CrystalReportViewer1.Refresh()
                    CRViewer.ShowDialog()

                    MessageBox.Show("PRS has been successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    prsfirstnametxt.Clear()
                    prsdesignationtxt.Clear()
                    prsnumbertxt.Clear()
                    prsofficecmb.SelectedIndex = -1
                    prspurposecmb.SelectedIndex = -1
                    prsothertxt.Clear()
                    prsnotetxt.Clear()
                    prsdgv.Rows.Clear()
                    prsdatedtm.Value = DateTime.Now

                    LoadAutoCompleteData()
                    LoadEquipmentCounts(Me)
                    LoadEquipmentsData(Me)
                    LoadRecentActivity(Me)
                    SelectTab("viewequipments")
                    SetAllNextNumbers()

                Catch ex As Exception

                    MessageBox.Show("Transaction rolled back: " & ex.Message)

                    tran.Rollback()
                    MessageBox.Show("Error while saving PRS: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub prscancelbtn_Click(sender As Object, e As EventArgs) Handles prscancelbtn.Click

        If MessageBox.Show("All fields will be cleared. Do you want to continue?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    If ctrl.Name <> "oicname" AndAlso ctrl.Name <> "oicdesignation" Then
                        DirectCast(ctrl, TextBox).Clear()
                    End If
                End If
            Next


            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is ComboBox Then
                    If ctrl.Name <> "oicname" Then
                        DirectCast(ctrl, ComboBox).SelectedIndex = -1
                    End If
                End If
            Next


            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is DateTimePicker Then
                    DirectCast(ctrl, DateTimePicker).Value = DateTime.Now
                End If
            Next


            prsdgv.Rows.Clear()


            prstotallbl.Text = "0.00"
            prsfirstnametxt.Clear()
            prsdesignationtxt.Clear()
            prsnumbertxt.Clear()

            SetAllNextNumbers()

            SelectTab("viewequipments")
        End If
    End Sub

    Private Sub rrspscanbtn_Click(sender As Object, e As EventArgs)
        ScanQRCodeSearch(rrspsearchtxt, rrspaddbtn)
    End Sub

    Private Sub logoutlbl_Click(sender As Object, e As EventArgs) Handles logoutlbl.Click
        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to log out?",
        "Confirm Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            Application.Restart()
        End If
    End Sub



    Private Sub activitytypecmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles activitytypecmb.SelectedIndexChanged
        LoadRecentActivity(Me)
    End Sub

    Private Sub stockcardcancelbtn_Click(sender As Object, e As EventArgs) Handles stockcardcancelbtn.Click
        stockcardstocknumbertxt.Clear()
        stockcarddescriptiontxt.Clear()
        stockcardstockidtxt.Clear()
        stockcardunitofmeasuretxt.Clear()
        stockcardreorderpointtxt.Clear()
        stockcardquantitytxt.Clear()
        stockcarddatedtm.Value = DateTime.Now
        stockcardfinishbtn.Text = "Finish"
        SelectTab("samviewsupply")
        SetAllNextNumbers()
    End Sub

    Private Sub prspurposecmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prspurposecmb.SelectedIndexChanged
        If prspurposecmb.Text.Trim() = "Other:" Then
            prsothertxt.Enabled = True
        Else
            prsothertxt.Enabled = False
            prsothertxt.Clear() ' 
        End If
    End Sub

    Private Sub gasfromdtp_ValueChanged(sender As Object, e As EventArgs) Handles gasfromdtp.ValueChanged
        LoadGasData(Me)
    End Sub

    Private Sub gastodtm_ValueChanged(sender As Object, e As EventArgs) Handles gastodtm.ValueChanged
        LoadGasData(Me)
    End Sub

    Private Sub gassearchtxt_TextChanged(sender As Object, e As EventArgs) Handles gassearchtxt.TextChanged
        LoadGasData(Me)
    End Sub

    Private Sub risbackbtn_Click(sender As Object, e As EventArgs) Handles risbackbtn.Click
        maintbc.SelectedTab = ristab
    End Sub

    Private Sub requestsfromdtp_ValueChanged(sender As Object, e As EventArgs) Handles requestsfromdtp.ValueChanged
        LoadRISData(Me)
    End Sub

    Private Sub requeststodtp_ValueChanged(sender As Object, e As EventArgs) Handles requeststodtp.ValueChanged
        LoadRISData(Me)
    End Sub

    Private Sub requeststypecmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles requeststypecmb.SelectedIndexChanged
        LoadRISData(Me)
    End Sub

    Private Sub addofficerinchargebtn_Click(sender As Object, e As EventArgs) Handles addofficerinchargebtn.Click
        OIC.Show()
    End Sub

    Private Sub pendingrrspandprsapprovalpnl_Paint(sender As Object, e As PaintEventArgs) Handles pendingrrspandprsapprovalpnl.Paint

    End Sub

    Private Sub equipmentsinpnl_Paint(sender As Object, e As PaintEventArgs) Handles equipmentsinpnl.Paint

    End Sub

    Private Sub pardateaquireddtm_ValueChanged(sender As Object, e As EventArgs) Handles pardateaquireddtm.ValueChanged
        pardateaquireddtm.Format = DateTimePickerFormat.Short
        pardateaquireddtm.CustomFormat = Nothing
    End Sub

    Private Sub icscancelbtn_Click(sender As Object, e As EventArgs) Handles icscancelbtn.Click


        If MessageBox.Show("All fields will be cleared. Do you want to continue?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            icsfirstnametxt.Clear()
            icsdesignationtxt.Clear()
            icsnumbertxt.Clear()
            icspurposetxt.Clear()
            icstotallbl.Text = ""
            icsdgv.Rows.Clear()
            SetAllNextNumbers()


            SelectTab("viewequipments")
        End If
    End Sub

    Private Sub pathbtn_Click(sender As Object, e As EventArgs) Handles pathbtn.Click
        ChooseAndSaveBackupPath()
    End Sub

    Private Sub rangecmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rangecmb.SelectedIndexChanged
        LoadRecentActivity(Me)
    End Sub

    Private Sub recentactivityprintbtn_Click(sender As Object, e As EventArgs)
        Try

            DataSet.Dashboardgrid.Clear()


            For Each dgvr As DataGridViewRow In recentactivitydgv.Rows
                If dgvr.IsNewRow Then Continue For

                Dim row As DataSet.DashboardgridRow = DataSet.Dashboardgrid.NewDashboardgridRow()

                row.activitytype = If(dgvr.Cells("activitytype").Value, "").ToString()
                row.transactiontype = If(dgvr.Cells("activitytransactiontype").Value, "").ToString()
                row.dashboardmaindate = If(dgvr.Cells("activitydate").Value, "").ToString()

                DataSet.Dashboardgrid.Rows.Add(row)
            Next


            Dim report As New dashboardmain()
            report.SetDataSource(DataSet)


            report.SetParameterValue("type", activitytypecmb.Text.Trim())


            CRViewer.CrystalReportViewer1.ReportSource = report
            CRViewer.CrystalReportViewer1.Refresh()
            CRViewer.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error generating Dashboard report: " & ex.Message,
                    "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub recentactivityprintbtn_Click_1(sender As Object, e As EventArgs)
        Try

            DataSet.Dashboardgrid.Clear()


            For Each dgvr As DataGridViewRow In recentactivitydgv.Rows
                If dgvr.IsNewRow Then Continue For

                Dim row As DataSet.DashboardgridRow = DataSet.Dashboardgrid.NewDashboardgridRow()

                row.activitytype = If(dgvr.Cells("activitytype").Value, "").ToString()
                row.transactiontype = If(dgvr.Cells("activitytransactiontype").Value, "").ToString()
                row.dashboardmaindate = If(dgvr.Cells("activitydate").Value, "").ToString()

                DataSet.Dashboardgrid.Rows.Add(row)
            Next


            Dim report As New dashboardmain()
            report.SetDataSource(DataSet)


            report.SetParameterValue("type", activitytypecmb.Text.Trim())


            CRViewer.CrystalReportViewer1.ReportSource = report
            CRViewer.CrystalReportViewer1.Refresh()
            CRViewer.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error generating Dashboard report: " & ex.Message,
                    "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub accountrestoredatabasebtn_Click(sender As Object, e As EventArgs) Handles accountrestoredatabasebtn.Click
        RestoreDatabase()
    End Sub

    Private Sub accountbackupdatabasebtn_Click(sender As Object, e As EventArgs) Handles accountbackupdatabasebtn.Click
        BackupDatabase()
    End Sub

    Private Sub equipmentactivitytypecmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles equipmentactivitytypecmb.SelectedIndexChanged
        LoadEquipmentActivity(Me)
    End Sub

    Private Sub equipmentactivitytodtm_ValueChanged(sender As Object, e As EventArgs) Handles equipmentactivitytodtm.ValueChanged
        LoadEquipmentActivity(Me)
    End Sub

    Private Sub equipmentactivityfromdtm_ValueChanged(sender As Object, e As EventArgs) Handles equipmentactivityfromdtm.ValueChanged
        LoadEquipmentActivity(Me)
    End Sub

    Private Sub equipmentactivitysearchbtn_Click(sender As Object, e As EventArgs) Handles equipmentactivitysearchbtn.Click
        LoadEquipmentActivity(Me)
    End Sub

    Private Sub DeleteRIS(risNumber As String)
        If String.IsNullOrWhiteSpace(risNumber) Then
            MessageBox.Show("No RIS number selected to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim connString As String = (GlobalConnectionString)

        If MessageBox.Show($"Are you sure you want to delete RIS {risNumber} and all related records?", "Confirm Delete",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Using tran As MySqlTransaction = conn.BeginTransaction()


                    Dim risItems As New DataTable()
                    Using da As New MySqlDataAdapter("SELECT stockno, approved_qty FROM ris_supply WHERE risnumber=@risnumber", conn)
                        da.SelectCommand.Parameters.AddWithValue("@risnumber", risNumber)
                        da.Fill(risItems)
                    End Using


                    For Each row As DataRow In risItems.Rows
                        Dim stockNo As String = Convert.ToString(row("stockno"))
                        Dim approvedQty As Integer = If(IsDBNull(row("approved_qty")), 0, CInt(row("approved_qty")))


                        Using updateSupplyCmd As New MySqlCommand(
                        "UPDATE supply SET supplybalance = supplybalance + @qty WHERE stockno = @stockno", conn, tran)
                            updateSupplyCmd.Parameters.AddWithValue("@qty", approvedQty)
                            updateSupplyCmd.Parameters.AddWithValue("@stockno", stockNo)
                            updateSupplyCmd.ExecuteNonQuery()
                        End Using

                        Using deleteStockCmd As New MySqlCommand(
                        "DELETE FROM supplystock WHERE reference=@ref AND stockno=@stockno", conn, tran)
                            deleteStockCmd.Parameters.AddWithValue("@ref", risNumber)
                            deleteStockCmd.Parameters.AddWithValue("@stockno", stockNo)
                            deleteStockCmd.ExecuteNonQuery()
                        End Using
                    Next


                    Using deleteRIS_SupplyCmd As New MySqlCommand(
                    "DELETE FROM ris_supply WHERE risnumber=@risnumber", conn, tran)
                        deleteRIS_SupplyCmd.Parameters.AddWithValue("@risnumber", risNumber)
                        deleteRIS_SupplyCmd.ExecuteNonQuery()
                    End Using


                    Using deleteRISCmd As New MySqlCommand(
                    "DELETE FROM ris WHERE risnumber=@risnumber", conn, tran)
                        deleteRISCmd.Parameters.AddWithValue("@risnumber", risNumber)
                        deleteRISCmd.ExecuteNonQuery()
                    End Using


                    tran.Commit()
                End Using
            End Using

            MessageBox.Show($"RIS {risNumber} and related records successfully deleted and stock restored.",
                        "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadRecentActivity(Me)
            LoadRISData(Me)
            SetAllNextNumbers()
            LoadSupplyAndMaterials(Me)

        Catch ex As Exception
            MessageBox.Show("❌ Error deleting RIS: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub requestsdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles requestsdgv.CellContentClick


        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim columnName As String = requestsdgv.Columns(e.ColumnIndex).Name
        Dim risNumber As String = Convert.ToString(requestsdgv.Rows(e.RowIndex).Cells("request_id").Value)
        If String.IsNullOrWhiteSpace(risNumber) Then Exit Sub




        If columnName = "request_edit" Then
            Try
                Dim connString As String = (GlobalConnectionString)
                Using con As New MySqlConnection(connString)
                    con.Open()

                    Dim queryRIS As String = "
SELECT risnumber, office, date, emailadd, phonenumber,
       requestedby, approvedby, recievedby,
       requestedbydesignation, approvedbydesignation, receivedbydesignation,
       purpose, status
FROM ris
WHERE risnumber = @risnumber
LIMIT 1"
                    Using cmd As New MySqlCommand(queryRIS, con)
                        cmd.Parameters.AddWithValue("@risnumber", risNumber)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                risnumbertxt.Text = reader("risnumber").ToString()
                                risofficecmb.Text = reader("office").ToString()
                                risdate.Value = Convert.ToDateTime(reader("date"))
                                risemailaddresstxt.Text = reader("emailadd").ToString()
                                risphonenumbertxt.Text = reader("phonenumber").ToString()
                                rispurposetxt.Text = reader("purpose").ToString()

                                risrequestedbyfirstnametxt.Text = reader("requestedby").ToString()
                                risdesignationtxt.Text = reader("requestedbydesignation").ToString()

                                risapprovedbyfirstnametxt.Text = reader("approvedby").ToString()
                                risapprovedbydesignationtxt.Text = reader("approvedbydesignation").ToString()

                                risreceivedbyfirstnametxt.Text = reader("recievedby").ToString()
                                risreceivedbydesignationtxt.Text = reader("receivedbydesignation").ToString()


                                Dim status As String = reader("status").ToString()
                                Select Case status
                                    Case "pending"
                                        risfinishbtn.Text = "Update"
                                        risfinishbtn.Visible = True
                                        rissaveandapprove.Text = "Update and Approve"
                                        rissaveandapprove.Visible = True
                                    Case "approved"
                                        risfinishbtn.Visible = False
                                        rissaveandapprove.Text = "Update Approved"
                                        rissaveandapprove.Visible = True
                                    Case Else
                                        risfinishbtn.Text = "Update"
                                        risfinishbtn.Visible = True
                                        rissaveandapprove.Text = "Update and Approve"
                                        rissaveandapprove.Visible = True
                                End Select
                            End If
                        End Using
                    End Using

                    risdgv.Rows.Clear()
                    Dim queryItems As String = "
SELECT 
    rs.stockno,
    s.unit,
    s.description,
    s.supplybalance,
    rs.requested_qty,
    rs.approved_qty,
    rs.remarks,
    rs.approval
FROM ris_supply rs
INNER JOIN supply s ON rs.stockno = s.stockno
WHERE rs.risnumber = @risnumber
GROUP BY rs.stockno
"
                    Using cmd As New MySqlCommand(queryItems, con)
                        cmd.Parameters.AddWithValue("@risnumber", risNumber)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                Dim inStockMark As String = ""
                                Dim outOfStockMark As String = ""
                                Dim approvalValue As Integer = Convert.ToInt32(reader("approval"))

                                If approvalValue = 1 Then
                                    inStockMark = "✔"
                                ElseIf approvalValue = 2 Then
                                    outOfStockMark = "✔"
                                End If

                                risdgv.Rows.Add(
                            reader("stockno").ToString(),
                            reader("unit").ToString(),
                            reader("description").ToString(),
                            reader("requested_qty").ToString(),
                            reader("supplybalance").ToString(),
                            inStockMark,
                            outOfStockMark,
                            reader("approved_qty").ToString(),
                            reader("remarks").ToString()
                        )
                            End While
                        End Using
                    End Using

                    maintbc.SelectedTab = ristab
                    ris_releasedquantity.ReadOnly = False
                    risdgv.Columns("ris_instock").ReadOnly = False
                    risdgv.Columns("ris_outofstock").ReadOnly = False
                    risreceivedbyfirstnametxt.Enabled = True
                    risreceivedbydesignationtxt.Enabled = True

                    SetupRIS_CheckBehavior()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading RIS for editing: " & ex.Message, "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Exit Sub
        End If



        If columnName = "request_print" Then
            PrintRIS(risNumber)
            Exit Sub
        End If
    End Sub




    Private Sub PrintRIS(risNumber As String)
        If String.IsNullOrWhiteSpace(risNumber) Then
            MessageBox.Show("Please enter a RIS number.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim connStr As String = (GlobalConnectionString)

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()



                DataSet.RISdatatable.Clear()
                DataSet.RISgrid.Clear()

                Dim headerQuery As String = "
                SELECT risnumber, office, date AS risdate, requestedby, requestedbydesignation,
                       approvedby, approvedbydesignation, issuedby, issuedbydesignation,
                       recievedby, receivedbydesignation, purpose
                FROM ris
                WHERE risnumber = @risnumber
            "

                Dim headerRow As DataSet.RISdatatableRow = DataSet.RISdatatable.NewRISdatatableRow()

                Using cmd As New MySqlCommand(headerQuery, conn)
                    cmd.Parameters.AddWithValue("@risnumber", risNumber)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            headerRow.risnumber = reader("risnumber").ToString()
                            headerRow.risoffice = reader("office").ToString()
                            headerRow.risdate = Convert.ToDateTime(reader("risdate")).ToString("yyyy-MM-dd")

                            headerRow.risrequestedby = reader("requestedby").ToString()
                            headerRow.risrequestedbydesignation = reader("requestedbydesignation").ToString()

                            headerRow.risapprovedby = reader("approvedby").ToString()
                            headerRow.risapprovedbydesignation = reader("approvedbydesignation").ToString()

                            headerRow.risissuedby = reader("issuedby").ToString()
                            headerRow.risissuedbydesignation = reader("issuedbydesignation").ToString()

                            headerRow.risreceivedby = reader("recievedby").ToString()
                            headerRow.risreceivedbydesignation = reader("receivedbydesignation").ToString()

                            headerRow.rispurpose = reader("purpose").ToString()
                        Else
                            MessageBox.Show("No RIS record found for this number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End Using
                End Using


                DataSet.RISdatatable.Rows.Add(headerRow)


                Dim itemsQuery As String = "
                SELECT rs.stockno,
                       s.unit,
                       s.description,
                       rs.requested_qty,
                       rs.approved_qty,
                       rs.approval,
                       rs.remarks
                FROM ris_supply rs
                INNER JOIN supply s ON rs.stockno = s.stockno
                WHERE rs.risnumber = @risnumber
            "

                Using cmd As New MySqlCommand(itemsQuery, conn)
                    cmd.Parameters.AddWithValue("@risnumber", risNumber)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim itemRow As DataSet.RISgridRow = DataSet.RISgrid.NewRISgridRow()

                            itemRow.risstocknumber = reader("stockno").ToString()
                            itemRow.risunit = reader("unit").ToString()
                            itemRow.risdescription = reader("description").ToString()

                            itemRow.risquantityrequested = reader("requested_qty").ToString()
                            itemRow.risquantityreleased = reader("approved_qty").ToString()


                            itemRow.risremarks = If(IsDBNull(reader("remarks")), "", reader("remarks").ToString())


                            Dim approvalValue As Integer = Convert.ToInt32(reader("approval"))
                            itemRow.risyes = If(approvalValue = 1, "✓", "")
                            itemRow.risno = If(approvalValue = 2, "✓", "")

                            DataSet.RISgrid.Rows.Add(itemRow)
                        End While
                    End Using
                End Using


                Dim report As New RIS()
                report.SetDataSource(DataSet)

                CRViewer.CrystalReportViewer1.ReportSource = report
                CRViewer.CrystalReportViewer1.Refresh()
                CRViewer.ShowDialog()
            End Using

        Catch ex As Exception
            MessageBox.Show("❌ Error generating RIS report: " & ex.Message,
                        "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub







    Private Sub gasviewdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gasviewdgv.CellContentClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim columnName As String = gasviewdgv.Columns(e.ColumnIndex).Name


        If columnName = "gasedit" Then
            Dim selectedStockNumber As String = gasviewdgv.Rows(e.RowIndex).Cells("gasstocknumber").Value.ToString()

            Try
                Using conn As New MySqlConnection(GlobalConnectionString)
                    conn.Open()



                    Dim queryHeader As String = "
                    SELECT stocknumber, office, gasdate,
                           requestedby, requestedbydesignation,
                           approvalrecommendedby, approvalrecommendedbydesignation,
                           approvedforissuanceby, approvedforissuancebydesignation,
                           issuedby, issuedbydesignation,
                           receivedby, receivedbydesignation
                    FROM gas
                    WHERE stocknumber = @stocknumber
                    LIMIT 1
                "

                    Using cmd As New MySqlCommand(queryHeader, conn)
                        cmd.Parameters.AddWithValue("@stocknumber", selectedStockNumber)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then

                                gasstocknotxt.Text = reader("stocknumber").ToString()
                                gassectioncmb.Text = reader("office").ToString()
                                gasdatedtm.Value = Convert.ToDateTime(reader("gasdate"))

                                gasrequestedbypositiontxt.Text = reader("requestedbydesignation").ToString()
                                gasapprovalrecommendedpositiontxt.Text = reader("approvalrecommendedbydesignation").ToString()
                                gasapprovedforissuancepositiontxt.Text = reader("approvedforissuancebydesignation").ToString()
                                oicname.Text = reader("issuedby").ToString()
                                oicdesignation.Text = reader("issuedbydesignation").ToString()


                                gasrequestedbyfirstnametxt.Text = reader("requestedby").ToString().Trim()
                                gasapprovalrecommendedfirstnametxt.Text = reader("approvalrecommendedby").ToString().Trim()
                                gasapprovedforissuancefirstnametxt.Text = reader("approvedforissuanceby").ToString().Trim()

                            End If
                        End Using
                    End Using


                    Dim queryItems As String = "
                    SELECT quantitytobeissued, unit, description, balanceafterthisuse, purpose
                    FROM gas
                    WHERE stocknumber = @stocknumber
                "
                    Using cmdItems As New MySqlCommand(queryItems, conn)
                        cmdItems.Parameters.AddWithValue("@stocknumber", selectedStockNumber)
                        Using reader As MySqlDataReader = cmdItems.ExecuteReader()
                            gasslipdgv.Rows.Clear()
                            While reader.Read()
                                gasslipdgv.Rows.Add(
                                reader("quantitytobeissued").ToString(),
                                reader("unit").ToString(),
                                reader("description").ToString(),
                                reader("balanceafterthisuse").ToString(),
                                reader("purpose").ToString()
                            )
                            End While
                        End Using
                    End Using
                End Using

                gasstocknotxt.ReadOnly = True
                gasfinishbtn.Text = "Update"
                SelectTab("newgassliprequest")

            Catch ex As Exception
                MessageBox.Show("Error loading GAS record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Exit Sub
        End If



        If columnName = "gasviewdetails" Then
            Dim reportStockNumber As String = gasviewdgv.Rows(e.RowIndex).Cells("gasstocknumber").Value.ToString().Trim()
            If reportStockNumber = "" Then
                MessageBox.Show("No GAS stock number found in this row.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Try
                DataSet.GASdatatable.Clear()
                DataSet.GASgrid.Clear()

                Using con As New MySqlConnection(GlobalConnectionString)
                    con.Open()


                    Dim headerQuery As String = "
                    SELECT office, stocknumber, gasdate,
                           requestedby, requestedbydesignation,
                           approvalrecommendedby, approvalrecommendedbydesignation,
                           approvedforissuanceby, approvedforissuancebydesignation,
                           issuedby, issuedbydesignation
                    FROM gas
                    WHERE stocknumber = @stocknumber
                    LIMIT 1;
                "

                    Dim headerRow As DataSet.GASdatatableRow = DataSet.GASdatatable.NewGASdatatableRow()
                    Using cmd As New MySqlCommand(headerQuery, con)
                        cmd.Parameters.AddWithValue("@stocknumber", reportStockNumber)
                        Using dr As MySqlDataReader = cmd.ExecuteReader()
                            If dr.Read() Then
                                headerRow.gassection = dr("office").ToString()
                                headerRow.gasstocknumber = dr("stocknumber").ToString()
                                headerRow.gasdate = Convert.ToDateTime(dr("gasdate")).ToString("yyyy-MM-dd")
                                headerRow.gasrequestedby = dr("requestedby").ToString()
                                headerRow.gasrequestedbyposition = dr("requestedbydesignation").ToString()
                                headerRow.gasapprovalrecommendedby = dr("approvalrecommendedby").ToString()
                                headerRow.gasapprovedfor = dr("approvedforissuanceby").ToString()
                                headerRow.gasapprovedforposition = dr("approvedforissuancebydesignation").ToString()
                                headerRow.gasissuedby = dr("issuedby").ToString()
                                headerRow.gasissuedbyposition = dr("issuedbydesignation").ToString()
                            Else
                                MessageBox.Show("No GAS record found for Stock No: " & reportStockNumber, "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        End Using
                    End Using

                    DataSet.GASdatatable.Rows.Add(headerRow)


                    Dim itemQuery As String = "
                    SELECT quantitytobeissued, unit, description, balanceafterthisuse, purpose
                    FROM gas
                    WHERE stocknumber = @stocknumber;
                "

                    Using cmd As New MySqlCommand(itemQuery, con)
                        cmd.Parameters.AddWithValue("@stocknumber", reportStockNumber)
                        Using dr As MySqlDataReader = cmd.ExecuteReader()
                            While dr.Read()
                                Dim bodyRow As DataSet.GASgridRow = DataSet.GASgrid.NewGASgridRow()
                                bodyRow.gasqty = dr("quantitytobeissued").ToString()
                                bodyRow.gasunit = dr("unit").ToString()
                                bodyRow.gasdescription = dr("description").ToString()
                                bodyRow.gasbalance = dr("balanceafterthisuse").ToString()
                                bodyRow.gaspurpose = dr("purpose").ToString()
                                DataSet.GASgrid.Rows.Add(bodyRow)
                            End While
                        End Using
                    End Using
                End Using

                Dim report As New Gas()
                report.SetDataSource(DataSet)
                CRViewer.CrystalReportViewer1.ReportSource = report
                CRViewer.CrystalReportViewer1.Refresh()
                CRViewer.ShowDialog()

            Catch ex As Exception
                MessageBox.Show("Error loading GAS report: " & ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub SplitFullName(fullName As String, first As TextBox, middle As TextBox, last As TextBox)
        Try
            Dim parts() As String = fullName.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)

            first.Text = ""
            middle.Text = ""
            last.Text = ""

            If parts.Length = 1 Then
                first.Text = parts(0)
            ElseIf parts.Length = 2 Then
                first.Text = parts(0)
                last.Text = parts(1)
            ElseIf parts.Length >= 3 Then
                first.Text = parts(0)
                If parts(1).Length = 2 AndAlso parts(1).EndsWith(".") Then
                    middle.Text = parts(1).Substring(0, 1)
                    last.Text = String.Join(" ", parts.Skip(2))
                Else
                    last.Text = String.Join(" ", parts.Skip(1))
                End If
            End If

        Catch
            first.Text = fullName
            middle.Text = ""
            last.Text = ""
        End Try
    End Sub









    Private Sub gasslipdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gasslipdgv.CellContentClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
        If gasslipdgv.Columns(e.ColumnIndex).Name <> "gas_remove" Then Exit Sub
        If gasslipdgv.Rows(e.RowIndex).IsNewRow Then Exit Sub

        Dim totalDataRows As Integer = gasslipdgv.Rows.Count - 1

        If totalDataRows > 1 Then
            gasslipdgv.Rows.RemoveAt(e.RowIndex)
        Else
            For Each cell As DataGridViewCell In gasslipdgv.Rows(e.RowIndex).Cells
                If cell.OwningColumn.Name <> "gas_remove" Then
                    cell.Value = Nothing
                End If
            Next
        End If
    End Sub


    Private Sub equipmentsdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles equipmentsdgv.CellContentClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim columnName As String = equipmentsdgv.Columns(e.ColumnIndex).Name
        If columnName <> "equipmentsmovementlog" Then Exit Sub

        Try

            Dim selectedRow As DataGridViewRow = equipmentsdgv.Rows(e.RowIndex)
            Dim equipmentId As String = selectedRow.Cells("equipmentsid").Value.ToString()
            Dim equipmentDescription As String = selectedRow.Cells("equipmentdescription").Value.ToString()
            Dim equipmentStatus As String = selectedRow.Cells("equipmentstatus").Value.ToString()

            Dim movementForm As New movementlog()
            movementForm.movementlogpropertynumbertxt.Text = equipmentId
            movementForm.movementlogstatustxt.Text = equipmentStatus

            movementForm.movementlogdescriptiondgv.Rows.Clear()
            Dim descriptionParts() As String = equipmentDescription _
            .Replace(vbCr, "") _
            .Split({vbLf, ",", ";"}, StringSplitOptions.RemoveEmptyEntries)

            For Each desc As String In descriptionParts
                Dim cleanDesc As String = desc.Trim()
                If cleanDesc <> "" Then
                    movementForm.movementlogdescriptiondgv.Rows.Add(cleanDesc)
                End If
            Next


            Dim connString As String = GlobalConnectionString
            Dim propertyNo As String = MySqlHelper.EscapeString(equipmentId.Trim())

            Dim query As String = $"
SELECT ei.equipmentinoutid,
       ei.sliptypeid AS documentid,
       CASE ei.sliptype
           WHEN 'ICS' THEN 'Inventory Custodian Slip'
           WHEN 'PAR' THEN 'Property Acknowledgement Receipt'
           WHEN 'PRS' THEN 'Property Return Slip'
           WHEN 'RRSP' THEN 'Receipt of Returned Semi-Expendable Property'
       END AS documenttype,
       (CASE ei.sliptype
           WHEN 'ICS' THEN (SELECT DATE_FORMAT(icsdate,'%Y-%m-%d') FROM ics WHERE icsno = ei.sliptypeid)
           WHEN 'PAR' THEN (SELECT DATE_FORMAT(date,'%Y-%m-%d') FROM par WHERE parnumber = ei.sliptypeid)
           WHEN 'PRS' THEN (SELECT DATE_FORMAT(date,'%Y-%m-%d') FROM prs WHERE prsnumber = ei.sliptypeid)
           WHEN 'RRSP' THEN (SELECT DATE_FORMAT(date,'%Y-%m-%d') FROM rrsp WHERE rrspnumber = ei.sliptypeid)
       END) AS documentdate,
       (CASE ei.sliptype
           WHEN 'ICS' THEN (SELECT receivedby FROM ics WHERE icsno = ei.sliptypeid)
           WHEN 'PAR' THEN (SELECT receivedby FROM par WHERE parnumber = ei.sliptypeid)
           WHEN 'PRS' THEN (SELECT receivedby FROM prs WHERE prsnumber = ei.sliptypeid)
           WHEN 'RRSP' THEN (SELECT receivedby FROM rrsp WHERE rrspnumber = ei.sliptypeid)
       END) AS receivedby
FROM equipment_inout ei
WHERE ei.propertynumber = '{propertyNo}'
ORDER BY ei.equipmentinoutid DESC;
"


            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        movementForm.movementlogdgv.Rows.Clear()

                        While reader.Read()
                            movementForm.movementlogdgv.Rows.Add(
                            reader("documentid").ToString(),
                            reader("documentdate").ToString(),
                            reader("documenttype").ToString(),
                            reader("receivedby").ToString(),
                            "View"
                        )
                        End While
                    End Using
                End Using
            End Using


            movementForm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error loading Movement Log: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Public Sub LoadOICInfo()
        Dim connStr As String = GlobalConnectionString

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()


                oicname.Items.Clear()
                oicdesignation.Clear()
                oicname.DisplayMember = "Value"
                oicname.ValueMember = "Key"

                Dim query As String = "
                SELECT oic.oicid, oic.name, oic.designation, oicaccount.defaultuser
                FROM oicaccount
                INNER JOIN oic ON oic.oicid = oicaccount.oicid
                WHERE oicaccount.ID = @userid;
            "
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userid", userid.Text.Trim())

                    Dim defaultOicId As Integer = -1
                    Dim defaultOicDesignation As String = ""

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim oicId As Integer = Convert.ToInt32(reader("oicid"))
                            Dim oicNameVal As String = If(IsDBNull(reader("name")), "", reader("name").ToString())
                            Dim oicDesignationVal As String = If(IsDBNull(reader("designation")), "", reader("designation").ToString())
                            Dim isDefault As Boolean = (Not IsDBNull(reader("defaultuser")) AndAlso reader("defaultuser").ToString() = "1")

                            oicname.Items.Add(New KeyValuePair(Of Integer, String)(oicId, oicNameVal))

                            If isDefault Then
                                defaultOicId = oicId
                                defaultOicDesignation = oicDesignationVal
                            End If
                        End While
                    End Using

                    If oicname.Items.Count > 0 Then
                        If defaultOicId <> -1 Then
                            For i As Integer = 0 To oicname.Items.Count - 1
                                Dim kvp As KeyValuePair(Of Integer, String) = DirectCast(oicname.Items(i), KeyValuePair(Of Integer, String))
                                If kvp.Key = defaultOicId Then
                                    oicname.SelectedIndex = i
                                    oicdesignation.Text = defaultOicDesignation
                                    Exit For
                                End If
                            Next
                        Else
                            oicname.SelectedIndex = 0
                            UpdateOICDesignation()
                        End If
                    Else
                        oicdesignation.Clear()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("error loading oic info: " & ex.Message,
                        "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub oicname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles oicname.SelectedIndexChanged
        UpdateOICDesignation()
    End Sub

    Private Sub UpdateOICDesignation()
        Try
            If oicname.SelectedIndex = -1 Then
                oicdesignation.Clear()
                Exit Sub
            End If

            Dim selectedKvp As KeyValuePair(Of Integer, String) = DirectCast(oicname.SelectedItem, KeyValuePair(Of Integer, String))
            Dim selectedOicId As Integer = selectedKvp.Key

            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Dim cmd As New MySqlCommand("SELECT designation FROM oic WHERE oicid=@oicid LIMIT 1", conn)
                cmd.Parameters.AddWithValue("@oicid", selectedOicId)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    oicdesignation.Text = result.ToString()
                Else
                    oicdesignation.Clear()
                End If
            End Using

        Catch ex As Exception
            oicdesignation.Clear()
            MessageBox.Show("error updating designation: " & ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub accountdgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles accountdgv.CellClick

        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim columnName As String = accountdgv.Columns(e.ColumnIndex).Name
        Dim connStr As String = (GlobalConnectionString)

        Try
            Dim selectedID As String = accountdgv.Rows(e.RowIndex).Cells("accountuserid").Value.ToString()



            If columnName = "statusbutton" Then
                Dim btnText As String = accountdgv.Rows(e.RowIndex).Cells("statusbutton").Value.ToString()
                Dim newStatus As String = ""

                Select Case btnText.Trim().ToLower()
                    Case "activate", "approve"
                        newStatus = "active"
                    Case "deactivate"
                        newStatus = "deactivated"
                    Case Else
                        MessageBox.Show("Unknown action for this status.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                End Select


                If MessageBox.Show($"Are you sure you want to set this account to '{newStatus}'?",
                           "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub


                Using conn As New MySqlConnection(GlobalConnectionString)
                    conn.Open()

                    Dim updateQuery As String = "UPDATE account SET status = @status WHERE ID = @id"
                    Using cmd As New MySqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@status", newStatus)
                        cmd.Parameters.AddWithValue("@id", selectedID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show($"Account status updated to '{newStatus}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                LoadAccounts()
                Notification()


            ElseIf columnName = "sendpasskeybutton" Then

                Dim rand As New Random()
                Dim newPasskey As String = rand.Next(1000, 9999).ToString()

                Using conn As New MySqlConnection(GlobalConnectionString)
                    conn.Open()

                    Dim updateQuery As String = "UPDATE account SET passkey = @passkey WHERE ID = @id"
                    Using cmd As New MySqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@passkey", newPasskey)
                        cmd.Parameters.AddWithValue("@id", selectedID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show($"New passkey '{newPasskey}' assigned to user ID {selectedID}.", "Passkey Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)


                LoadAccounts()


            ElseIf columnName = "access" Then
                If accountdgv.Rows(e.RowIndex).Cells("access").ReadOnly Then Exit Sub

                Dim cell As DataGridViewCell = accountdgv.Rows(e.RowIndex).Cells("access")

                Dim isCurrentlyChecked As Boolean = If(cell.Value IsNot Nothing AndAlso CBool(cell.Value), True, False)

                Dim message As String = ""
                Dim targetValue As Integer = 0

                If isCurrentlyChecked Then
                    message = "Are you sure you want to deny this user access to check supplies?"
                    targetValue = 0
                Else
                    message = "Are you sure you want to allow this user access to check supplies?"
                    targetValue = 1
                End If

                Dim result As DialogResult = MessageBox.Show(message, "Confirm Access Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Using conn As New MySqlConnection(GlobalConnectionString)
                        conn.Open()

                        Dim updateQuery As String = "UPDATE account SET access = @access WHERE ID = @id"
                        Using cmd As New MySqlCommand(updateQuery, conn)
                            cmd.Parameters.AddWithValue("@access", targetValue)
                            cmd.Parameters.AddWithValue("@id", selectedID)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    cell.Value = Not isCurrentlyChecked
                    accountdgv.EndEdit()

                    LoadAccounts()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error performing action: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






    Private Sub accounttypecmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles accounttypecmb.SelectedIndexChanged
        LoadAccounts()
    End Sub


    Private Sub changepasswordbtn_Click(sender As Object, e As EventArgs) Handles changepasswordbtn.Click
        changepassword.idlbl.Text = userid.Text
        changepassword.ShowDialog()
    End Sub

    Private Sub addnewsupplybtn_Click(sender As Object, e As EventArgs) Handles addnewsupplybtn.Click
        SelectTab("addnewsupply")
    End Sub

    Private Sub newrequestbtn_Click(sender As Object, e As EventArgs) Handles newrequestbtn.Click
        SelectTab("newsupplyrequest")
    End Sub

    Private Sub newgasslipbtn_Click(sender As Object, e As EventArgs) Handles newgasslipbtn.Click
        SelectTab("newgassliprequest")
    End Sub

    Private Sub logoutlbl_MouseHover(sender As Object, e As EventArgs) Handles logoutlbl.MouseHover
        logoutlbl.Cursor = Cursors.Hand
    End Sub
    Private Sub logoutlbl_MouseLeave(sender As Object, e As EventArgs) Handles logoutlbl.MouseLeave
        logoutlbl.Cursor = Cursors.Default
    End Sub

    Private Sub refreshpicbox_Click(sender As Object, e As EventArgs) Handles refreshpicbox.Click
        RefreshAll()
    End Sub

    Private Sub refreshpicbox_MouseHover(sender As Object, e As EventArgs) Handles refreshpicbox.MouseHover
        logoutlbl.Cursor = Cursors.Hand
    End Sub

    Private Sub refreshpicbox_MouseLeave(sender As Object, e As EventArgs) Handles refreshpicbox.MouseLeave
        logoutlbl.Cursor = Cursors.Default
    End Sub

    Public Sub PrintPAR(documentId As String)
        Try
            DataSet.PARdatatable.Clear()
            DataSet.PARgrid.Clear()

            Dim connStr As String = (GlobalConnectionString)


            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()


                Dim headerCmd As New MySqlCommand("
            SELECT parnumber, date, note,
                   recommendingapproval, recommendingapprovaldesignation,
                   approvedby, approvedbydesignation,
                   receivedby, receivedbydesignation,
                   issuedby, issuedbydesignation
            FROM par
            WHERE parnumber = @documentId", conn)

                headerCmd.Parameters.AddWithValue("@documentId", documentId)

                Using rdr = headerCmd.ExecuteReader()
                    If rdr.Read() Then
                        Dim headerRow As DataSet.PARdatatableRow = DataSet.PARdatatable.NewPARdatatableRow()

                        headerRow.parnumber = rdr("parnumber").ToString()
                        headerRow.pardate = Convert.ToDateTime(rdr("date")).ToString("yyyy-MM-dd") ' Date only
                        headerRow.parnote = rdr("note").ToString()
                        headerRow.parrecommendingapproval = rdr("recommendingapproval").ToString()
                        headerRow.parrecommendingapprovaldesignation = rdr("recommendingapprovaldesignation").ToString()
                        headerRow.parapprovedby = rdr("approvedby").ToString()
                        headerRow.parapprovedbydesignation = rdr("approvedbydesignation").ToString()
                        headerRow.parreceivedby = rdr("receivedby").ToString()
                        headerRow.parreceivedbydesignation = rdr("receivedbydesignation").ToString()
                        headerRow.parissuedby = rdr("issuedby").ToString()
                        headerRow.parissuedbydesignation = rdr("issuedbydesignation").ToString()

                        DataSet.PARdatatable.Rows.Add(headerRow)
                    Else
                        MessageBox.Show("PAR not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using


                Dim itemsCmd As New MySqlCommand("
            SELECT propertynumber, description, unit, quantity, date, cost
            FROM equipment
            WHERE type IN ('more','less') AND propertynumber IN (
                SELECT propertynumber FROM equipment_inout
                WHERE sliptype = 'PAR' AND sliptypeid = @documentId
            )", conn)

                itemsCmd.Parameters.AddWithValue("@documentId", documentId)

                Using rdr = itemsCmd.ExecuteReader()
                    While rdr.Read()
                        Dim bodyRow As DataSet.PARgridRow = DataSet.PARgrid.NewPARgridRow()

                        bodyRow.parquantity = rdr("quantity").ToString()
                        bodyRow.parunit = rdr("unit").ToString()
                        bodyRow.pardescription = rdr("description").ToString()
                        bodyRow.parpropertynumber = rdr("propertynumber").ToString()
                        bodyRow.pardateaquired = Convert.ToDateTime(rdr("date")).ToString("yyyy-MM-dd") ' Date only
                        bodyRow.paramount = rdr("cost").ToString()

                        DataSet.PARgrid.Rows.Add(bodyRow)
                    End While
                End Using
            End Using

            Dim report As New PAR()
            report.SetDataSource(DataSet)
            CRViewer.CrystalReportViewer1.ReportSource = report
            CRViewer.CrystalReportViewer1.Refresh()
            CRViewer.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error printing PAR: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub PrintRRSP(documentId As String)
        Try

            DataSet.RRSPdatatable.Clear()
            DataSet.RRSPgrid.Clear()

            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()




                Dim headerCmd As New MySqlCommand("
                SELECT rrspnumber, date, returnedby, returnedbydesignation,
                       receivedby, receivedbydesignation
                FROM rrsp
                WHERE rrspnumber = @rrspnumber
            ", conn)
                headerCmd.Parameters.AddWithValue("@rrspnumber", documentId)

                Using rdr = headerCmd.ExecuteReader()
                    If rdr.Read() Then
                        Dim headerRow As DataSet.RRSPdatatableRow = DataSet.RRSPdatatable.NewRRSPdatatableRow()

                        headerRow.rrspnumber = rdr("rrspnumber").ToString()
                        headerRow.rrspdate = Convert.ToDateTime(rdr("date")).ToString("yyyy-MM-dd")
                        headerRow.rrspreturnedby = rdr("returnedby").ToString()
                        headerRow.rrspreturnedbydesignation = rdr("returnedbydesignation").ToString()
                        headerRow.rrspreceivedby = rdr("receivedby").ToString()
                        headerRow.rrspreceivedbydesignation = rdr("receivedbydesignation").ToString()
                        headerRow.rrsprelieving = rdr("returnedby").ToString()

                        DataSet.RRSPdatatable.Rows.Add(headerRow)
                    Else
                        MessageBox.Show("RRSP document not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using


                Dim itemsCmd As New MySqlCommand("
                SELECT ei.equipmentinoutid, ei.propertynumber, ei.remarks,
                       e.description, e.unit
                FROM equipment_inout ei
                INNER JOIN equipment e ON e.propertynumber = ei.propertynumber
                WHERE ei.sliptype = 'RRSP' AND ei.sliptypeid = @rrspnumber
            ", conn)
                itemsCmd.Parameters.AddWithValue("@rrspnumber", documentId)


                Dim itemsList As New List(Of Dictionary(Of String, Object))()
                Using rdr = itemsCmd.ExecuteReader()
                    While rdr.Read()
                        Dim row As New Dictionary(Of String, Object)
                        row("equipmentinoutid") = rdr("equipmentinoutid")
                        row("propertynumber") = rdr("propertynumber").ToString()
                        row("remarks") = If(rdr("remarks") IsNot DBNull.Value, rdr("remarks").ToString(), "")
                        row("description") = rdr("description").ToString()
                        row("unit") = rdr("unit").ToString()
                        itemsList.Add(row)
                    End While
                End Using


                For Each item In itemsList
                    Dim propertyNumber As String = item("propertynumber").ToString()
                    Dim rrspEIOID As Integer = Convert.ToInt32(item("equipmentinoutid"))
                    Dim endUser As String = ""
                    Dim slipIdValue As String = ""

                    Dim slipCmd As New MySqlCommand("
                    SELECT ei.sliptype, ei.sliptypeid
                    FROM equipment_inout ei
                    WHERE ei.propertynumber = @prop AND ei.equipmentinoutid < @eid
                    ORDER BY ei.equipmentinoutid DESC
                    LIMIT 1
                ", conn)
                    slipCmd.Parameters.AddWithValue("@prop", propertyNumber)
                    slipCmd.Parameters.AddWithValue("@eid", rrspEIOID)

                    Using slipReader As MySqlDataReader = slipCmd.ExecuteReader()
                        If slipReader.Read() Then
                            Dim slipType As String = slipReader("sliptype").ToString()
                            Dim slipId As String = slipReader("sliptypeid").ToString()
                            slipIdValue = slipId

                            slipReader.Close() ' 
                            If slipType = "ICS" Then
                                Dim cmdICS As New MySqlCommand("SELECT receivedby FROM ics WHERE icsno = @id LIMIT 1", conn)
                                cmdICS.Parameters.AddWithValue("@id", slipId)
                                Dim result = cmdICS.ExecuteScalar()
                                endUser = If(result IsNot Nothing, result.ToString(), "")
                            ElseIf slipType = "PAR" Then
                                Dim cmdPAR As New MySqlCommand("SELECT receivedby FROM par WHERE parnumber = @id LIMIT 1", conn)
                                cmdPAR.Parameters.AddWithValue("@id", slipId)
                                Dim result = cmdPAR.ExecuteScalar()
                                endUser = If(result IsNot Nothing, result.ToString(), "")
                            End If
                        End If
                    End Using

                    Dim bodyRow As DataSet.RRSPgridRow = DataSet.RRSPgrid.NewRRSPgridRow()
                    bodyRow.rrspdescription = item("description").ToString()
                    bodyRow.rrspunit = item("unit").ToString()
                    bodyRow.rrspquantity = "1" ' default quantity
                    bodyRow.rrspremarks = item("remarks").ToString()
                    bodyRow.rrspenduser = endUser
                    bodyRow.rrspicsgpnumber = slipIdValue
                    DataSet.RRSPgrid.Rows.Add(bodyRow)
                Next
            End Using


            Dim report As New RRSP()
            report.SetDataSource(DataSet)
            CRViewer.CrystalReportViewer1.ReportSource = report
            CRViewer.CrystalReportViewer1.Refresh()
            CRViewer.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error printing RRSP: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub







    Public Sub PrintICS(documentId As String)
        Try

            DataSet.ICSdatatable.Clear()
            DataSet.ICSgrid.Clear()

            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()



                Dim headerCmd As New MySqlCommand("
                SELECT icsno, icsdate, purpose, receivedfrom, receivedfromdesignation,
                       receivedby, receivedbydesignation
                FROM ics
                WHERE icsno = @icsno
            ", conn)
                headerCmd.Parameters.AddWithValue("@icsno", documentId)

                Dim headerRow As DataSet.ICSdatatableRow = Nothing
                Using rdr = headerCmd.ExecuteReader()
                    If rdr.Read() Then
                        headerRow = DataSet.ICSdatatable.NewICSdatatableRow()
                        headerRow.icsnumber = rdr("icsno").ToString()
                        headerRow.icsdate = Convert.ToDateTime(rdr("icsdate")).ToString("yyyy-MM-dd")
                        headerRow.icspurpose = rdr("purpose").ToString()
                        headerRow.icsreceivedfrom = rdr("receivedfrom").ToString()
                        headerRow.icsreceivedfromdesignation = rdr("receivedfromdesignation").ToString()
                        headerRow.icsreceivedby = rdr("receivedby").ToString()
                        headerRow.icsreceivedbydesignation = rdr("receivedbydesignation").ToString()
                        headerRow.icstotal = "0.00"
                        DataSet.ICSdatatable.Rows.Add(headerRow)
                    Else
                        MessageBox.Show("ICS document not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using


                Dim itemsCmd As New MySqlCommand("
                SELECT 
                    e.propertynumber,
                    e.description,
                    e.unit,
                    e.cost AS unitcost,
                    e.quantity,
                    ei.remarks AS estimatedusefullife
                FROM equipment_inout ei
                INNER JOIN equipment e ON ei.propertynumber = e.propertynumber
                WHERE ei.sliptype = 'ICS' AND ei.sliptypeid = @icsno
            ", conn)
                itemsCmd.Parameters.AddWithValue("@icsno", documentId)

                Dim totalSum As Decimal = 0D

                Using rdr = itemsCmd.ExecuteReader()
                    While rdr.Read()
                        Dim quantity As Decimal = 0D
                        Dim unitCost As Decimal = 0D

                        Decimal.TryParse(rdr("quantity").ToString(), quantity)
                        Decimal.TryParse(rdr("unitcost").ToString(), unitCost)

                        Dim rowTotal As Decimal = quantity * unitCost
                        totalSum += rowTotal

                        Dim bodyRow As DataSet.ICSgridRow = DataSet.ICSgrid.NewICSgridRow()
                        bodyRow.icsinventoryitemnumber = rdr("propertynumber").ToString()
                        bodyRow.icsdescription = rdr("description").ToString()
                        bodyRow.icsunit = rdr("unit").ToString()
                        bodyRow.icsquantity = quantity.ToString("N0")
                        bodyRow.icsunitcost = unitCost.ToString("N2")
                        bodyRow.icstotalcost = rowTotal.ToString("N2") ' total cost as string
                        bodyRow.icsestimateduserfullife = If(rdr("estimatedusefullife") IsNot DBNull.Value, rdr("estimatedusefullife").ToString(), "")

                        DataSet.ICSgrid.Rows.Add(bodyRow)
                    End While
                End Using


                If headerRow IsNot Nothing Then
                    headerRow.icstotal = totalSum.ToString("N2")
                End If
            End Using


            Dim report As New ICS()
            report.SetDataSource(DataSet)
            CRViewer.CrystalReportViewer1.ReportSource = report
            CRViewer.CrystalReportViewer1.Refresh()
            CRViewer.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error printing ICS: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub PrintPRS(documentId As String)
        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()



                Dim headerCmd As New MySqlCommand("SELECT * FROM prs WHERE prsnumber = @id LIMIT 1", conn)
                headerCmd.Parameters.AddWithValue("@id", documentId)

                Using headerReader As MySqlDataReader = headerCmd.ExecuteReader()
                    If Not headerReader.Read() Then
                        MessageBox.Show("PRS document not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    DataSet.PRSdatatable.Clear()

                    Dim headerRow As DataSet.PRSdatatableRow = DataSet.PRSdatatable.NewPRSdatatableRow()
                    headerRow.prsoffice = headerReader("office").ToString()
                    headerRow.prspurpose = headerReader("purpose").ToString()
                    headerRow.prsdate = Convert.ToDateTime(headerReader("date")).ToString("yyyy-MM-dd")
                    headerRow.prsnote = headerReader("note").ToString()
                    headerRow.prsreturnedby = headerReader("returnedby").ToString()
                    headerRow.prsreturnedbydesignation = headerReader("returnedbydesignation").ToString()
                    headerRow.prsreceivedby = headerReader("receivedby").ToString()
                    headerRow.prsreceivedbydesignation = headerReader("receivedbydesignation").ToString()
                    headerRow.prsapprovedby = headerReader("approvedby").ToString()
                    headerRow.prsapprovedbydesignation = headerReader("approvedbydesignation").ToString()

                    headerRow.prstotal = 0D
                    DataSet.PRSdatatable.Rows.Add(headerRow)
                End Using

                DataSet.PRSgrid.Clear()

                Dim detailCmd As New MySqlCommand("
                SELECT ei.equipmentinoutid, ei.propertynumber, ei.remarks,
                       e.description, e.unit, e.cost, e.quantity
                FROM equipment_inout ei
                INNER JOIN equipment e ON ei.propertynumber = e.propertynumber
                WHERE ei.sliptype = 'PRS' AND ei.sliptypeid = @id
            ", conn)
                detailCmd.Parameters.AddWithValue("@id", documentId)

                Dim items As New List(Of Dictionary(Of String, Object))()

                Using reader As MySqlDataReader = detailCmd.ExecuteReader()
                    While reader.Read()
                        Dim row As New Dictionary(Of String, Object)
                        row("equipmentinoutid") = reader("equipmentinoutid")
                        row("propertynumber") = reader("propertynumber").ToString()
                        row("remarks") = reader("remarks").ToString()
                        row("description") = reader("description").ToString()
                        row("unit") = reader("unit").ToString()
                        row("cost") = If(reader("cost") IsNot DBNull.Value, Convert.ToDecimal(reader("cost")), 0D)
                        row("quantity") = If(reader("quantity") IsNot DBNull.Value, Convert.ToDecimal(reader("quantity")), 1D)
                        items.Add(row)
                    End While
                End Using


                Dim grandTotal As Decimal = 0D

                For Each item In items
                    Dim propertyNumber As String = item("propertynumber").ToString()
                    Dim prsEIOID As Integer = Convert.ToInt32(item("equipmentinoutid"))
                    Dim endUser As String = ""

                    Dim slipCmd As New MySqlCommand("
                    SELECT ei.sliptype, ei.sliptypeid
                    FROM equipment_inout ei
                    WHERE ei.propertynumber = @prop AND ei.equipmentinoutid < @eid
                    ORDER BY ei.equipmentinoutid DESC
                    LIMIT 1
                ", conn)
                    slipCmd.Parameters.AddWithValue("@prop", propertyNumber)
                    slipCmd.Parameters.AddWithValue("@eid", prsEIOID)

                    Dim slipType As String = ""
                    Dim slipId As String = ""

                    Using slipReader As MySqlDataReader = slipCmd.ExecuteReader()
                        If slipReader.Read() Then
                            slipType = slipReader("sliptype").ToString()
                            slipId = slipReader("sliptypeid").ToString()
                        End If
                    End Using

                    If slipType = "ICS" Then
                        Dim cmdICS As New MySqlCommand("SELECT receivedby FROM ics WHERE icsno = @id LIMIT 1", conn)
                        cmdICS.Parameters.AddWithValue("@id", slipId)
                        Dim result = cmdICS.ExecuteScalar()
                        endUser = If(result IsNot Nothing, result.ToString(), "")
                    ElseIf slipType = "PAR" Then
                        Dim cmdPAR As New MySqlCommand("SELECT receivedby FROM par WHERE parnumber = @id LIMIT 1", conn)
                        cmdPAR.Parameters.AddWithValue("@id", slipId)
                        Dim result = cmdPAR.ExecuteScalar()
                        endUser = If(result IsNot Nothing, result.ToString(), "")
                    End If

                    Dim bodyRow As DataSet.PRSgridRow = DataSet.PRSgrid.NewPRSgridRow()
                    bodyRow.prsquantity = item("quantity").ToString()
                    bodyRow.prsunit = item("unit").ToString()
                    bodyRow.prsdescription = item("description").ToString()
                    bodyRow.prspropertynumber = propertyNumber
                    bodyRow.prsarenumber = ""
                    bodyRow.prsnameofenduser = endUser
                    bodyRow.prsunitvalue = Convert.ToDecimal(item("cost"))
                    bodyRow.prstotalvalue = bodyRow.prsunitvalue * Convert.ToDecimal(bodyRow.prsquantity)
                    bodyRow.prsremarks = item("remarks").ToString()

                    DataSet.PRSgrid.Rows.Add(bodyRow)

                    grandTotal += bodyRow.prstotalvalue
                Next

                If DataSet.PRSdatatable.Rows.Count > 0 Then
                    DataSet.PRSdatatable.Rows(0)("prstotal") = grandTotal
                End If

                Dim report As New PRS() ' PRS.rpt
                report.SetDataSource(DataSet)
                CRViewer.CrystalReportViewer1.ReportSource = report
                CRViewer.CrystalReportViewer1.Refresh()
                CRViewer.ShowDialog()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error printing PRS: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub equipmentactivitydgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles equipmentactivitydgv.CellContentClick

        If e.RowIndex < 0 Then Return
        If equipmentactivitydgv.Columns(e.ColumnIndex).Name <> "print" Then Return


        Dim docType As String = equipmentactivitydgv.Rows(e.RowIndex).Cells("documenttype").Value?.ToString()
        Dim docId As String = equipmentactivitydgv.Rows(e.RowIndex).Cells("documentid").Value?.ToString()


        If String.IsNullOrWhiteSpace(docType) OrElse String.IsNullOrWhiteSpace(docId) Then
            MessageBox.Show("Invalid document type or ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Select Case docType
            Case "Inventory Custodian Slip"

                PrintICS(documentId:=docId)

            Case "Property Acknowledgement Receipt"

                PrintPAR(documentId:=docId)

            Case "Property Return Slip"

                PrintPRS(documentId:=docId)

            Case "Receipt of Returned Semi-Expendable Property"

                PrintRRSP(documentId:=docId)

            Case Else
                MessageBox.Show("Unknown document type: " & docType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        supplyandmaterialstypecmb.Text = "Low"
        SelectTab("samviewsupply")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        supplyandmaterialstypecmb.Text = "Low"
        SelectTab("samviewsupply")
    End Sub

    Private Sub lowsupplylbl_Click(sender As Object, e As EventArgs)
        supplyandmaterialstypecmb.Text = "Low"
        SelectTab("samviewsupply")
    End Sub


    Private Sub zerosupplypnl_Click(sender As Object, e As EventArgs) Handles zerosupplypnl.Click
        supplyandmaterialstypecmb.Text = "Zero"
        SelectTab("samviewsupply")
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        supplyandmaterialstypecmb.Text = "Zero"
        SelectTab("samviewsupply")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        supplyandmaterialstypecmb.Text = "Zero"
        SelectTab("samviewsupply")
    End Sub



    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        supplyandmaterialstypecmb.Text = "Requested Insufficient"
        SelectTab("samviewsupply")
    End Sub

    Private Sub insufficientrequestedsupplypnl_Click(sender As Object, e As EventArgs) Handles insufficientrequestedsupplypnl.Click
        supplyandmaterialstypecmb.Text = "Requested Insufficient"
        SelectTab("samviewsupply")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        supplyandmaterialstypecmb.Text = "Requested Insufficient"
        SelectTab("samviewsupply")
    End Sub

    Public Sub NotifClick()

        If userlvl.Text = "Admin" Then
            requeststypecmb.Text = "Pending"
            SelectTab("viewrequisition")
        End If

    End Sub


    Private Sub notificationiconpic_Click(sender As Object, e As EventArgs) Handles notificationiconpic.Click
        NotifClick()

    End Sub

    Private Sub rissaveandapprove_Click(sender As Object, e As EventArgs) Handles rissaveandapprove.Click
        Try

            Dim confirmMsg As String = ""

            Select Case rissaveandapprove.Text
                Case "Save and Approve"
                    confirmMsg = "Are you sure you want to approve and finalize this RIS?"
                    Dim requiredFields As Control() = {
                    risreceivedbyfirstnametxt,
                    risreceivedbydesignationtxt, oicname, oicdesignation
                }

                    For Each ctrl As Control In requiredFields
                        If TypeOf ctrl Is TextBox AndAlso String.IsNullOrWhiteSpace(ctrl.Text) Then
                            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            ctrl.Focus()
                            Exit Sub
                        ElseIf TypeOf ctrl Is ComboBox AndAlso DirectCast(ctrl, ComboBox).SelectedIndex = -1 Then
                            MessageBox.Show("Please select a value for all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            ctrl.Focus()
                            Exit Sub
                        End If
                    Next

                Case "Update and Approve"
                    confirmMsg = "Are you sure you want to update and approve this RIS?"
                Case "Update Approved"
                    confirmMsg = "Are you sure you want to update and finalize this approved RIS?"
                Case Else
                    Exit Sub
            End Select

            If MessageBox.Show(confirmMsg, "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub


            Dim success As Boolean = False
            Dim errorMsg As String = ""

            Select Case rissaveandapprove.Text
                Case "Save and Approve"
                    success = SaveRISData()
                    If Not success Then
                        MessageBox.Show("Failed to save RIS data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    success = ApproveRIS(errorMsg)
                    If Not success Then
                        MessageBox.Show("Failed to approve RIS. " & errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    GenerateRISReportFromDatabase()

                Case "Update and Approve"
                    success = UpdateRISData()
                    success = ApproveRIS(errorMsg)
                    If Not success Then
                        MessageBox.Show("Failed to approve RIS. " & errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    GenerateRISReportFromDatabase()

                Case "Update Approved"
                    success = UpdateRISData()
                    If Not success Then
                        MessageBox.Show("Failed to update RIS data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    success = UpdateApprovedRIS(errorMsg)
                    If Not success Then
                        MessageBox.Show("Failed to finalize approved RIS. " & errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    GenerateRISReportFromDatabase()
            End Select


            If success Then

                LoadSupplyAndMaterials(Me)
                ResetRIS_UI()
                SelectTab("viewrequisition")
                LoadRecentActivity(Me)
                LoadRISData(Me)
                Notification()
                RefreshNotification()
                SetAllNextNumbers()
                risfinishbtn.Visible = True
            End If

        Catch ex As Exception
            MessageBox.Show("Error during operation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






    Private Sub risfinishbtn_Click(sender As Object, e As EventArgs) Handles risfinishbtn.Click
        Try

            If String.IsNullOrWhiteSpace(risrequestedbyfirstnametxt.Text) _
       OrElse String.IsNullOrWhiteSpace(risdesignationtxt.Text) _
       OrElse String.IsNullOrWhiteSpace(risapprovedbyfirstnametxt.Text) _
       OrElse String.IsNullOrWhiteSpace(risapprovedbydesignationtxt.Text) Then

                MessageBox.Show("All signature fields must be filled before continuing.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Dim confirmMsg As String = ""

            If risfinishbtn.Text = "Finish" Then
                confirmMsg = "Are you sure you want to save and finalize this RIS?"
            ElseIf risfinishbtn.Text = "Update" Then
                confirmMsg = "Are you sure you want to update this RIS?"
            Else
                Exit Sub
            End If

            If MessageBox.Show(confirmMsg, "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub


            Dim success As Boolean = False

            If risfinishbtn.Text = "Finish" Then
                success = SaveRISData()

                If Not success Then
                    MessageBox.Show("Failed to save RIS data. Please check your entries or database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

            ElseIf risfinishbtn.Text = "Update" Then
                success = UpdateRISData()

                If Not success Then
                    MessageBox.Show("Failed to update RIS data. Please check if the RIS number exists and your entries.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                GenerateRISReportFromDatabase()
            End If


            If success Then
                LoadSupplyAndMaterials(Me)

                ResetRIS_UI()
                SelectTab("viewrequisition")
                LoadRecentActivity(Me)
                LoadRISData(Me)
                SetAllNextNumbers()
                Notification()
                RefreshNotification()


                If risfinishbtn.Text = "Update" Then
                    risreceivedbyfirstnametxt.Enabled = False
                    risreceivedbydesignationtxt.Enabled = False
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error during operation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function ApproveRIS(ByRef errorMsg As String) As Boolean
        Try

            Dim requiredFields As Control() = {
            risreceivedbyfirstnametxt,
            risreceivedbydesignationtxt, oicname, oicdesignation
        }

            For Each ctrl As Control In requiredFields
                If TypeOf ctrl Is TextBox AndAlso String.IsNullOrWhiteSpace(ctrl.Text) Then
                    errorMsg = "Please fill all required fields."
                    Return False
                End If
            Next

            Dim connString As String = (GlobalConnectionString)
            Dim risNumber As String = risnumbertxt.Text.Trim()

            Using con As New MySqlConnection(connString)
                con.Open()


                Using cmdCheck As New MySqlCommand("
                SELECT rs.stockno,
                       SUM(rs.approved_qty) AS totalRequested,
                       s.supplybalance
                FROM ris_supply rs
                JOIN supply s ON TRIM(rs.stockno) = TRIM(s.stockno)
                WHERE rs.risnumber = @risnumber
                GROUP BY rs.stockno, s.supplybalance", con)

                    cmdCheck.Parameters.AddWithValue("@risnumber", risNumber)

                    Using rdr = cmdCheck.ExecuteReader()
                        While rdr.Read()
                            Dim stockno As String = rdr("stockno").ToString().Trim()
                            Dim requested As Integer = 0
                            Dim balance As Integer = 0

                            Integer.TryParse(rdr("totalRequested").ToString(), requested)
                            Integer.TryParse(rdr("supplybalance").ToString(), balance)

                            If requested > balance Then
                                errorMsg = $"Insufficient stock for {stockno}: Requested={requested}, Balance={balance}"
                                Return False
                            End If
                        End While
                    End Using
                End Using


                Dim receivedBy As String = risreceivedbyfirstnametxt.Text.Trim()



                Dim risItems As New Dictionary(Of String, Integer)
                Using cmd As New MySqlCommand("
                SELECT stockno, approved_qty
                FROM ris_supply
                WHERE risnumber=@risnumber", con)
                    cmd.Parameters.AddWithValue("@risnumber", risNumber)
                    Using rdr = cmd.ExecuteReader()
                        While rdr.Read()
                            Dim stockno As String = rdr("stockno").ToString().Trim()
                            Dim approvedQty As Integer = 0
                            If Not IsDBNull(rdr("approved_qty")) Then
                                Integer.TryParse(rdr("approved_qty").ToString(), approvedQty)
                            End If
                            risItems(stockno) = approvedQty
                        End While
                    End Using
                End Using


                Using trans As MySqlTransaction = con.BeginTransaction()

                    Dim updateRIS As String = "
                    UPDATE ris SET 
                        status='approved',
                        issuedby=@issuedby,
                        recievedby=@recievedby,
                        requestedby=@requestedby,
                        approvedby=@approvedby,
                        requestedbydesignation=@requestedbydesignation,
                        approvedbydesignation=@approvedbydesignation,
                        issuedbydesignation=@issuedbydesignation,
                        receivedbydesignation=@receivedbydesignation,
                        purpose=@purpose
                    WHERE risnumber=@risnumber
                "

                    Using cmd As New MySqlCommand(updateRIS, con, trans)
                        cmd.Parameters.AddWithValue("@issuedby", oicname.Text.Trim())
                        cmd.Parameters.AddWithValue("@recievedby", risreceivedbyfirstnametxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@requestedby", risrequestedbyfirstnametxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@approvedby", risapprovedbyfirstnametxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@requestedbydesignation", risdesignationtxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@approvedbydesignation", risapprovedbydesignationtxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@issuedbydesignation", oicdesignation.Text.Trim())
                        cmd.Parameters.AddWithValue("@receivedbydesignation", risreceivedbydesignationtxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@purpose", rispurposetxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@risnumber", risNumber)
                        cmd.ExecuteNonQuery()
                    End Using



                    For Each kvp In risItems
                        Dim stockno As String = kvp.Key
                        Dim approvedQty As Integer = kvp.Value


                        Using cmdRollback As New MySqlCommand("
                        UPDATE supply s
                        JOIN supplystock ss ON s.stockno = ss.stockno
                        SET s.supplybalance = s.supplybalance + ss.qtyrequest
                        WHERE ss.risnumber=@risnumber AND ss.stockno=@stockno", con, trans)
                            cmdRollback.Parameters.AddWithValue("@risnumber", risNumber)
                            cmdRollback.Parameters.AddWithValue("@stockno", stockno)
                            cmdRollback.ExecuteNonQuery()
                        End Using


                        Using cmdDel As New MySqlCommand("DELETE FROM supplystock WHERE risnumber=@risnumber AND stockno=@stockno", con, trans)
                            cmdDel.Parameters.AddWithValue("@risnumber", risNumber)
                            cmdDel.Parameters.AddWithValue("@stockno", stockno)
                            cmdDel.ExecuteNonQuery()
                        End Using


                        Dim qtyToAllocate As Integer = approvedQty
                        Using cmdStockIds As New MySqlCommand("
                        SELECT DISTINCT stockid
                        FROM supplystock
                        WHERE stockno=@stockno AND qtybalance > 0 AND (risnumber IS NULL OR risnumber='')
                        ORDER BY supplystockid ASC", con, trans)
                            cmdStockIds.Parameters.AddWithValue("@stockno", stockno)
                            Dim stockIds As New List(Of Integer)
                            Using rdrIds = cmdStockIds.ExecuteReader()
                                While rdrIds.Read()
                                    stockIds.Add(Convert.ToInt32(rdrIds("stockid")))
                                End While
                            End Using

                            For Each sId In stockIds
                                If qtyToAllocate <= 0 Then Exit For

                                Dim latestBalance As Integer = 0
                                Dim latestRowDate, latestReceipt, latestReference, latestOffice, latestReorder As Object

                                Using cmdLatest As New MySqlCommand("
                                SELECT * FROM supplystock WHERE stockid=@stockid AND stockno=@stockno ORDER BY supplystockid DESC LIMIT 1", con, trans)
                                    cmdLatest.Parameters.AddWithValue("@stockid", sId)
                                    cmdLatest.Parameters.AddWithValue("@stockno", stockno)
                                    Using rdrLatest = cmdLatest.ExecuteReader()
                                        If rdrLatest.Read() Then
                                            Integer.TryParse(rdrLatest("qtybalance").ToString(), latestBalance)
                                            latestRowDate = rdrLatest("supplystockdate")
                                            latestReceipt = If(rdrLatest("receiptqty") Is DBNull.Value, Nothing, rdrLatest("receiptqty"))
                                            latestReference = If(rdrLatest("reference") Is DBNull.Value, Nothing, rdrLatest("reference"))
                                            latestOffice = rdrLatest("office")
                                            latestReorder = rdrLatest("reorderpoint")
                                        Else
                                            Continue For
                                        End If
                                    End Using
                                End Using

                                If latestBalance <= 0 Then Continue For

                                Dim allocate As Integer = Math.Min(latestBalance, qtyToAllocate)

                                Using cmdIns As New MySqlCommand("
                                INSERT INTO supplystock
                                (stockid, stockno, risnumber, supplystockdate, reference, receiptqty,
                                 qtyrequest, qtybalance, office, noofdaystoconsume, reorderpoint)
                                VALUES (@stockid,@stockno,@risnumber,@supplystockdate,@reference,
                                        @receiptqty,@qtyrequest,@qtybalance,@office,@noofdaystoconsume,@reorderpoint)", con, trans)
                                    cmdIns.Parameters.AddWithValue("@stockid", sId)
                                    cmdIns.Parameters.AddWithValue("@stockno", stockno)
                                    cmdIns.Parameters.AddWithValue("@risnumber", risNumber)
                                    cmdIns.Parameters.AddWithValue("@supplystockdate", latestRowDate)
                                    cmdIns.Parameters.AddWithValue("@reference", latestReference)
                                    cmdIns.Parameters.AddWithValue("@receiptqty", latestReceipt)
                                    cmdIns.Parameters.AddWithValue("@qtyrequest", allocate)
                                    cmdIns.Parameters.AddWithValue("@qtybalance", latestBalance - allocate)
                                    cmdIns.Parameters.AddWithValue("@office", latestOffice)
                                    cmdIns.Parameters.AddWithValue("@noofdaystoconsume", receivedBy)
                                    cmdIns.Parameters.AddWithValue("@reorderpoint", latestReorder)
                                    cmdIns.ExecuteNonQuery()
                                End Using


                                Using cmdSup As New MySqlCommand("UPDATE supply SET supplybalance = supplybalance - @qty WHERE stockno=@stockno", con, trans)
                                    cmdSup.Parameters.AddWithValue("@qty", allocate)
                                    cmdSup.Parameters.AddWithValue("@stockno", stockno)
                                    cmdSup.ExecuteNonQuery()
                                End Using

                                qtyToAllocate -= allocate
                            Next
                        End Using


                        Using cmdApp As New MySqlCommand("UPDATE ris_supply SET approval=1, approved_qty=@approved_qty WHERE risnumber=@risnumber AND stockno=@stockno", con, trans)
                            cmdApp.Parameters.AddWithValue("@approved_qty", approvedQty)
                            cmdApp.Parameters.AddWithValue("@risnumber", risNumber)
                            cmdApp.Parameters.AddWithValue("@stockno", stockno)
                            cmdApp.ExecuteNonQuery()
                        End Using
                    Next

                    trans.Commit()

                End Using
            End Using

            Return True
        Catch ex As Exception
            errorMsg = ex.Message
            Return False
        End Try
    End Function



    Private Function UpdateApprovedRIS(ByRef errorMsg As String) As Boolean
        Try
            Dim connString As String = (GlobalConnectionString)
            Dim risNumber As String = risnumbertxt.Text.Trim()


            If String.IsNullOrWhiteSpace(risNumber) Then
                errorMsg = "RIS number is empty."
                Return False
            End If

            Using con As New MySqlConnection(connString)
                con.Open()


                Dim receivedBy As String = ""
                Using cmdRec As New MySqlCommand("SELECT recievedby FROM ris WHERE risnumber=@risnumber", con)
                    cmdRec.Parameters.AddWithValue("@risnumber", risNumber)
                    receivedBy = cmdRec.ExecuteScalar()?.ToString()
                End Using

                If String.IsNullOrWhiteSpace(receivedBy) Then
                    errorMsg = "Recipient information is missing from RIS."
                    Return False
                End If


                Dim risItems As New Dictionary(Of String, Integer)
                Using cmd As New MySqlCommand("SELECT stockno, approved_qty FROM ris_supply WHERE risnumber=@risnumber", con)
                    cmd.Parameters.AddWithValue("@risnumber", risNumber)
                    Using rdr = cmd.ExecuteReader()
                        While rdr.Read()
                            Dim stockno As String = rdr("stockno").ToString()
                            Dim approvedQty As Integer = If(IsDBNull(rdr("approved_qty")), 0, Convert.ToInt32(rdr("approved_qty")))
                            risItems(stockno) = approvedQty
                        End While
                    End Using
                End Using


                For Each kvp In risItems
                    Dim stockno As String = kvp.Key
                    Dim approvedQty As Integer = kvp.Value

                    Using cmdCheck As New MySqlCommand("SELECT supplybalance FROM supply WHERE stockno=@stockno", con)
                        cmdCheck.Parameters.AddWithValue("@stockno", stockno)
                        Dim balanceObj = cmdCheck.ExecuteScalar()
                        Dim balance As Integer = If(balanceObj Is DBNull.Value OrElse balanceObj Is Nothing, 0, Convert.ToInt32(balanceObj))
                        If approvedQty > balance Then
                            errorMsg = $"Insufficient balance for stock {stockno}. Requested: {approvedQty}, Available: {balance}."
                            Return False
                        End If
                    End Using
                Next


                Using trans As MySqlTransaction = con.BeginTransaction()
                    For Each kvp In risItems
                        Dim stockno As String = kvp.Key
                        Dim approvedQty As Integer = kvp.Value

                        If approvedQty <= 0 Then Continue For


                        Using cmdRoll As New MySqlCommand("
                        UPDATE supply s
                        JOIN supplystock ss ON s.stockno = ss.stockno
                        SET s.supplybalance = s.supplybalance + ss.qtyrequest
                        WHERE ss.risnumber=@risnumber AND ss.stockno=@stockno", con, trans)
                            cmdRoll.Parameters.AddWithValue("@risnumber", risNumber)
                            cmdRoll.Parameters.AddWithValue("@stockno", stockno)
                            cmdRoll.ExecuteNonQuery()
                        End Using

                        Using cmdDel As New MySqlCommand("DELETE FROM supplystock WHERE risnumber=@risnumber AND stockno=@stockno", con, trans)
                            cmdDel.Parameters.AddWithValue("@risnumber", risNumber)
                            cmdDel.Parameters.AddWithValue("@stockno", stockno)
                            cmdDel.ExecuteNonQuery()
                        End Using

                        Dim qtyToAllocate As Integer = approvedQty
                        Using cmdStockIds As New MySqlCommand("
                        SELECT DISTINCT stockid FROM supplystock
                        WHERE stockno=@stockno AND qtybalance>0 AND (risnumber IS NULL OR risnumber='')
                        ORDER BY supplystockid ASC", con, trans)
                            cmdStockIds.Parameters.AddWithValue("@stockno", stockno)
                            Dim stockIds As New List(Of Integer)
                            Using rdrIds = cmdStockIds.ExecuteReader()
                                While rdrIds.Read()
                                    stockIds.Add(Convert.ToInt32(rdrIds("stockid")))
                                End While
                            End Using

                            For Each sId In stockIds
                                If qtyToAllocate <= 0 Then Exit For

                                Dim latestBalance As Integer = 0
                                Dim latestRowDate, latestReceipt, latestReference, latestOffice, latestReorder As Object

                                Using cmdLatest As New MySqlCommand("
                                SELECT * FROM supplystock WHERE stockid=@stockid AND stockno=@stockno ORDER BY supplystockid DESC LIMIT 1", con, trans)
                                    cmdLatest.Parameters.AddWithValue("@stockid", sId)
                                    cmdLatest.Parameters.AddWithValue("@stockno", stockno)
                                    Using rdrLatest = cmdLatest.ExecuteReader()
                                        If rdrLatest.Read() Then
                                            latestBalance = If(IsDBNull(rdrLatest("qtybalance")), 0, Convert.ToInt32(rdrLatest("qtybalance")))
                                            latestRowDate = rdrLatest("supplystockdate")
                                            latestReceipt = If(rdrLatest("receiptqty") Is DBNull.Value, Nothing, rdrLatest("receiptqty"))
                                            latestReference = If(rdrLatest("reference") Is DBNull.Value, Nothing, rdrLatest("reference"))
                                            latestOffice = If(rdrLatest("office") Is DBNull.Value, Nothing, rdrLatest("office"))
                                            latestReorder = If(rdrLatest("reorderpoint") Is DBNull.Value, Nothing, rdrLatest("reorderpoint"))
                                        Else
                                            Continue For
                                        End If
                                    End Using
                                End Using

                                If latestBalance <= 0 Then Continue For

                                Dim allocate As Integer = Math.Min(latestBalance, qtyToAllocate)

                                Using cmdIns As New MySqlCommand("
                                INSERT INTO supplystock
                                (stockid, stockno, risnumber, supplystockdate, reference, receiptqty, qtyrequest, qtybalance, office, noofdaystoconsume, reorderpoint)
                                VALUES (@stockid,@stockno,@risnumber,@supplystockdate,@reference,@receiptqty,@qtyrequest,@qtybalance,@office,@noofdaystoconsume,@reorderpoint)", con, trans)
                                    cmdIns.Parameters.AddWithValue("@stockid", sId)
                                    cmdIns.Parameters.AddWithValue("@stockno", stockno)
                                    cmdIns.Parameters.AddWithValue("@risnumber", risNumber)
                                    cmdIns.Parameters.AddWithValue("@supplystockdate", latestRowDate)
                                    cmdIns.Parameters.AddWithValue("@reference", latestReference)
                                    cmdIns.Parameters.AddWithValue("@receiptqty", latestReceipt)
                                    cmdIns.Parameters.AddWithValue("@qtyrequest", allocate)
                                    cmdIns.Parameters.AddWithValue("@qtybalance", latestBalance - allocate)
                                    cmdIns.Parameters.AddWithValue("@office", latestOffice)
                                    cmdIns.Parameters.AddWithValue("@noofdaystoconsume", receivedBy)
                                    cmdIns.Parameters.AddWithValue("@reorderpoint", latestReorder)
                                    cmdIns.ExecuteNonQuery()
                                End Using

                                Using cmdSup As New MySqlCommand("UPDATE supply SET supplybalance = supplybalance - @qty WHERE stockno=@stockno", con, trans)
                                    cmdSup.Parameters.AddWithValue("@qty", allocate)
                                    cmdSup.Parameters.AddWithValue("@stockno", stockno)
                                    cmdSup.ExecuteNonQuery()
                                End Using

                                qtyToAllocate -= allocate
                            Next
                        End Using

                        Using cmdApp As New MySqlCommand("
                        UPDATE ris_supply SET approved_qty=@approved_qty, approval=1 WHERE risnumber=@risnumber AND stockno=@stockno", con, trans)
                            cmdApp.Parameters.AddWithValue("@approved_qty", approvedQty)
                            cmdApp.Parameters.AddWithValue("@risnumber", risNumber)
                            cmdApp.Parameters.AddWithValue("@stockno", stockno)
                            cmdApp.ExecuteNonQuery()
                        End Using
                    Next

                    Dim updateHeader As String = "
                    UPDATE ris SET 
                        issuedby = @issuedby,
                        recievedby = @recievedby,
                        requestedby = @requestedby,
                        approvedby = @approvedby,
                        requestedbydesignation = @requestedbydesignation,
                        approvedbydesignation = @approvedbydesignation,
                        issuedbydesignation = @issuedbydesignation,
                        receivedbydesignation = @receivedbydesignation,
                        purpose = @purpose
                    WHERE risnumber = @risnumber"
                    Using cmdHeader As New MySqlCommand(updateHeader, con, trans)
                        cmdHeader.Parameters.AddWithValue("@issuedby", oicname.Text.Trim())
                        cmdHeader.Parameters.AddWithValue("@recievedby", receivedBy)
                        cmdHeader.Parameters.AddWithValue("@requestedby", risrequestedbyfirstnametxt.Text.Trim())
                        cmdHeader.Parameters.AddWithValue("@approvedby", risapprovedbyfirstnametxt.Text.Trim())
                        cmdHeader.Parameters.AddWithValue("@requestedbydesignation", risdesignationtxt.Text.Trim())
                        cmdHeader.Parameters.AddWithValue("@approvedbydesignation", risapprovedbydesignationtxt.Text.Trim())
                        cmdHeader.Parameters.AddWithValue("@issuedbydesignation", oicdesignation.Text.Trim())
                        cmdHeader.Parameters.AddWithValue("@receivedbydesignation", risreceivedbydesignationtxt.Text.Trim())
                        cmdHeader.Parameters.AddWithValue("@purpose", rispurposetxt.Text.Trim())
                        cmdHeader.Parameters.AddWithValue("@risnumber", risNumber)
                        cmdHeader.ExecuteNonQuery()
                    End Using

                    trans.Commit()
                End Using
            End Using

            Return True
        Catch ex As Exception
            errorMsg = ex.Message
            Return False
        End Try
    End Function


    Private Function UpdateRISData() As Boolean
        If String.IsNullOrWhiteSpace(risnumbertxt.Text) Then Return False

        Dim connString As String = (GlobalConnectionString)
        Dim risNumber As String = risnumbertxt.Text.Trim()

        Try
            Using con As New MySqlConnection(connString)
                con.Open()
                Using tran As MySqlTransaction = con.BeginTransaction()

                    Dim updateRIS As String =
                    "UPDATE ris SET " &
                    "office=@office, date=@date, emailadd=@emailadd, phonenumber=@phonenumber, " &
                    "requestedby=@requestedby, approvedby=@approvedby, requestedbydesignation=@requestedbydesignation, " &
                    "approvedbydesignation=@approvedbydesignation, purpose=@purpose " &
                    "WHERE risnumber=@risnumber"

                    Using cmd As New MySqlCommand(updateRIS, con, tran)
                        cmd.Parameters.AddWithValue("@office", risofficecmb.Text)
                        cmd.Parameters.AddWithValue("@date", risdate.Value.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@emailadd", risemailaddresstxt.Text)
                        cmd.Parameters.AddWithValue("@phonenumber", risphonenumbertxt.Text)
                        cmd.Parameters.AddWithValue("@requestedby", risrequestedbyfirstnametxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@approvedby", risapprovedbyfirstnametxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@requestedbydesignation", risdesignationtxt.Text)
                        cmd.Parameters.AddWithValue("@approvedbydesignation", risapprovedbydesignationtxt.Text)
                        cmd.Parameters.AddWithValue("@purpose", rispurposetxt.Text)
                        cmd.Parameters.AddWithValue("@risnumber", risNumber)
                        cmd.ExecuteNonQuery()
                    End Using


                    Dim dbStockNos As New List(Of String)
                    Using cmd As New MySqlCommand("SELECT stockno FROM ris_supply WHERE risnumber=@risnumber", con, tran)
                        cmd.Parameters.AddWithValue("@risnumber", risNumber)
                        Using rdr As MySqlDataReader = cmd.ExecuteReader()
                            While rdr.Read()
                                dbStockNos.Add(rdr("stockno").ToString())
                            End While
                        End Using
                    End Using


                    Dim dgvStockNos As New List(Of String)
                    For Each row As DataGridViewRow In risdgv.Rows
                        If row.IsNewRow Then Continue For
                        Dim stockno As String = Convert.ToString(row.Cells("ris_stockno").Value)
                        If Not String.IsNullOrWhiteSpace(stockno) Then dgvStockNos.Add(stockno)
                    Next


                    Dim stockNosToDelete As List(Of String) = dbStockNos.Where(Function(x) Not dgvStockNos.Contains(x)).ToList()
                    If stockNosToDelete.Count > 0 Then
                        Using cmdDelete As New MySqlCommand("DELETE FROM ris_supply WHERE risnumber=@risnumber AND stockno=@stockno", con, tran)
                            For Each s In stockNosToDelete
                                cmdDelete.Parameters.Clear()
                                cmdDelete.Parameters.AddWithValue("@risnumber", risNumber)
                                cmdDelete.Parameters.AddWithValue("@stockno", s)
                                cmdDelete.ExecuteNonQuery()
                            Next
                        End Using
                    End If


                    Dim checkExistsSQL As String = "SELECT COUNT(*) FROM ris_supply WHERE risnumber=@risnumber AND stockno=@stockno"
                    Dim updateSupplySQL As String = "UPDATE ris_supply SET requested_qty=@requested_qty, approved_qty=@approved_qty, remarks=@remarks, approval=@approval WHERE risnumber=@risnumber AND stockno=@stockno"
                    Dim insertSupplySQL As String = "INSERT INTO ris_supply (risnumber, stockno, requested_qty, approved_qty, remarks, approval) VALUES (@risnumber, @stockno, @requested_qty, @approved_qty, @remarks, @approval)"

                    Using cmdCheck As New MySqlCommand(checkExistsSQL, con, tran)
                        Using cmdUpdate As New MySqlCommand(updateSupplySQL, con, tran)
                            Using cmdInsert As New MySqlCommand(insertSupplySQL, con, tran)
                                For Each row As DataGridViewRow In risdgv.Rows
                                    If row.IsNewRow Then Continue For
                                    Dim stockno As String = Convert.ToString(row.Cells("ris_stockno").Value)
                                    If String.IsNullOrWhiteSpace(stockno) Then Continue For

                                    Dim requestedQty As Decimal = Val(row.Cells("ris_requestedquantity").Value)
                                    Dim approvedQty As Decimal = Val(row.Cells("ris_releasedquantity").Value)
                                    Dim remarks As String = Convert.ToString(row.Cells("ris_remarks").Value)

                                    Dim approvalValue As Integer = 0
                                    If Convert.ToString(row.Cells("ris_instock").Value) = "✔" Then approvalValue = 1
                                    If Convert.ToString(row.Cells("ris_outofstock").Value) = "✔" Then approvalValue = 2


                                    cmdCheck.Parameters.Clear()
                                    cmdCheck.Parameters.AddWithValue("@risnumber", risNumber)
                                    cmdCheck.Parameters.AddWithValue("@stockno", stockno)
                                    Dim exists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                                    If exists > 0 Then
                                        cmdUpdate.Parameters.Clear()
                                        cmdUpdate.Parameters.AddWithValue("@requested_qty", requestedQty)
                                        cmdUpdate.Parameters.AddWithValue("@approved_qty", approvedQty)
                                        cmdUpdate.Parameters.AddWithValue("@remarks", remarks)
                                        cmdUpdate.Parameters.AddWithValue("@approval", approvalValue)
                                        cmdUpdate.Parameters.AddWithValue("@risnumber", risNumber)
                                        cmdUpdate.Parameters.AddWithValue("@stockno", stockno)
                                        cmdUpdate.ExecuteNonQuery()
                                    Else
                                        cmdInsert.Parameters.Clear()
                                        cmdInsert.Parameters.AddWithValue("@risnumber", risNumber)
                                        cmdInsert.Parameters.AddWithValue("@stockno", stockno)
                                        cmdInsert.Parameters.AddWithValue("@requested_qty", requestedQty)
                                        cmdInsert.Parameters.AddWithValue("@approved_qty", approvedQty)
                                        cmdInsert.Parameters.AddWithValue("@remarks", remarks)
                                        cmdInsert.Parameters.AddWithValue("@approval", approvalValue)
                                        cmdInsert.ExecuteNonQuery()
                                    End If
                                Next
                            End Using
                        End Using
                    End Using

                    tran.Commit()
                End Using
            End Using

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function SaveRISData() As Boolean
        Dim connString As String = (GlobalConnectionString)

        Try
            Using con As New MySqlConnection(connString)
                con.Open()
                Using tran As MySqlTransaction = con.BeginTransaction()

                    Dim insertRIS As String =
                    "INSERT INTO ris (risnumber, office, date, emailadd, phonenumber, requestedby, approvedby, " &
                    "requestedbydesignation, approvedbydesignation, purpose, status) " &
                    "VALUES (@risnumber, @office, @date, @emailadd, @phonenumber, @requestedby, @approvedby, " &
                    "@requestedbydesignation, @approvedbydesignation, @purpose, @status)"

                    Using cmd As New MySqlCommand(insertRIS, con, tran)
                        cmd.Parameters.AddWithValue("@risnumber", risnumbertxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@office", risofficecmb.Text)
                        cmd.Parameters.AddWithValue("@date", risdate.Value.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@emailadd", risemailaddresstxt.Text)
                        cmd.Parameters.AddWithValue("@phonenumber", risphonenumbertxt.Text)
                        cmd.Parameters.AddWithValue("@requestedby", risrequestedbyfirstnametxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@approvedby", risapprovedbyfirstnametxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@requestedbydesignation", risdesignationtxt.Text)
                        cmd.Parameters.AddWithValue("@approvedbydesignation", risapprovedbydesignationtxt.Text)
                        cmd.Parameters.AddWithValue("@purpose", rispurposetxt.Text)
                        cmd.Parameters.AddWithValue("@status", "Pending")
                        cmd.ExecuteNonQuery()
                    End Using

                    Dim insertSupply As String =
                    "INSERT INTO ris_supply (risnumber, stockno, requested_qty, approved_qty, remarks, approval) " &
                    "VALUES (@risnumber, @stockno, @requested_qty, @approved_qty, @remarks, @approval)"

                    Using cmd As New MySqlCommand(insertSupply, con, tran)
                        For Each row As DataGridViewRow In risdgv.Rows
                            If row.IsNewRow Then Continue For
                            Dim stockno As String = Convert.ToString(row.Cells("ris_stockno").Value)
                            If String.IsNullOrWhiteSpace(stockno) Then Continue For

                            Dim requestedQty As Decimal = 0
                            Decimal.TryParse(Convert.ToString(row.Cells("ris_requestedquantity").Value), requestedQty)
                            Dim approvedQty As Decimal = 0
                            Decimal.TryParse(Convert.ToString(row.Cells("ris_releasedquantity").Value), approvedQty)
                            Dim remarks As String = Convert.ToString(row.Cells("ris_remarks").Value)

                            Dim approvalValue As Integer = 0
                            If Convert.ToString(row.Cells("ris_instock").Value) = "✔" Then approvalValue = 1
                            If Convert.ToString(row.Cells("ris_outofstock").Value) = "✔" Then approvalValue = 2

                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@risnumber", risnumbertxt.Text.Trim())
                            cmd.Parameters.AddWithValue("@stockno", stockno)
                            cmd.Parameters.AddWithValue("@requested_qty", requestedQty)
                            cmd.Parameters.AddWithValue("@approved_qty", approvedQty)
                            cmd.Parameters.AddWithValue("@remarks", remarks)
                            cmd.Parameters.AddWithValue("@approval", approvalValue)
                            cmd.ExecuteNonQuery()
                        Next
                        risfinishbtn.Text = "Finish"
                    End Using

                    tran.Commit()

                End Using
            End Using

            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub prsscanbtn_Click(sender As Object, e As EventArgs)
        ScanQRCodeSearch(prssearchtxt, prsaddbtn)
    End Sub

    Private Sub icsscanbtn_Click(sender As Object, e As EventArgs)
        ScanQRCodeSearch(icssearchtxt, addicsbtn)
    End Sub

    Private Sub lowsupplypnl_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub pardgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles pardgv.CellContentClick

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub
        If pardgv.Columns(e.ColumnIndex).Name <> "parremove" Then Exit Sub
        If pardgv.Rows(e.RowIndex).IsNewRow Then Exit Sub

        pardgv.Rows.RemoveAt(e.RowIndex)


    End Sub

    Private Sub prsdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles prsdgv.CellContentClick

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        If prsdgv.Columns(e.ColumnIndex).Name <> "prsremove" Then Exit Sub

        If prsdgv.Rows(e.RowIndex).IsNewRow Then Exit Sub

        prsdgv.Rows.RemoveAt(e.RowIndex)

        Dim grandTotal As Decimal = 0D

        For Each row As DataGridViewRow In prsdgv.Rows
            If row.IsNewRow Then Continue For
            If row.Cells("prs_totalvalue").Value IsNot Nothing Then
                Dim val As Decimal
                If Decimal.TryParse(row.Cells("prs_totalvalue").Value.ToString(), val) Then
                    grandTotal += val
                End If
            End If
        Next

        prstotallbl.Text = grandTotal.ToString("N2")

    End Sub


    Private Sub rrspdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles rrspdgv.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub
        If rrspdgv.Columns(e.ColumnIndex).Name <> "rrspremove" Then Exit Sub
        If rrspdgv.Rows(e.RowIndex).IsNewRow Then Exit Sub

        rrspdgv.Rows.RemoveAt(e.RowIndex)
    End Sub


    Private Sub icsdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles icsdgv.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub
        If icsdgv.Columns(e.ColumnIndex).Name <> "icsremove" Then Exit Sub
        If icsdgv.Rows(e.RowIndex).IsNewRow Then Exit Sub

        icsdgv.Rows.RemoveAt(e.RowIndex)
    End Sub

    Private Sub risdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles risdgv.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub
        If risdgv.Columns(e.ColumnIndex).Name <> "removeris" Then Exit Sub
        If risdgv.Rows(e.RowIndex).IsNewRow Then Exit Sub

        risdgv.Rows.RemoveAt(e.RowIndex)
    End Sub


    Private Sub icsscan_Click(sender As Object, e As EventArgs) Handles icsscan.Click
        Dim result As DialogResult = MessageBox.Show(
        "Scan an image? If no, the scanner will be used.",
        "Select Scan Method",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            Using ofd As New OpenFileDialog()
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
                ofd.Title = "Select QR Code Image"
                ofd.Multiselect = False ' Single selection only

                If ofd.ShowDialog() = DialogResult.OK Then
                    Try
                        Using bitmap As New Bitmap(ofd.FileName)
                            Dim reader As New ZXing.BarcodeReader()
                            reader.Options.PossibleFormats = New List(Of ZXing.BarcodeFormat) From {
                            ZXing.BarcodeFormat.QR_CODE
                        }

                            Dim scanResult = reader.Decode(bitmap)

                            If scanResult IsNot Nothing Then
                                icssearchtxt.Text = scanResult.Text
                            Else
                                MessageBox.Show("No valid QR code found in the image.", "Scan Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error reading image file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using

        ElseIf result = DialogResult.No Then
            Form3.Show()
            Form3.txtbxlbl.Text = "icssearchtxt"
            Form3.btnbtn.Text = "addicsbtn"
        End If
    End Sub

    Private Sub scanprs_Click(sender As Object, e As EventArgs) Handles scanprs.Click
        Dim result As DialogResult = MessageBox.Show(
        "Scan an image? If no, the scanner will be used.",
        "Select Scan Method",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            Using ofd As New OpenFileDialog()
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
                ofd.Title = "Select QR Code Image"
                ofd.Multiselect = False ' Single selection only

                If ofd.ShowDialog() = DialogResult.OK Then
                    Try
                        Using bitmap As New Bitmap(ofd.FileName)
                            Dim reader As New ZXing.BarcodeReader()
                            reader.Options.PossibleFormats = New List(Of ZXing.BarcodeFormat) From {
                            ZXing.BarcodeFormat.QR_CODE
                        }

                            Dim scanResult = reader.Decode(bitmap)

                            If scanResult IsNot Nothing Then
                                prssearchtxt.Text = scanResult.Text
                            Else
                                MessageBox.Show("No valid QR code found in the image.", "Scan Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error reading image file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using

        ElseIf result = DialogResult.No Then
            Form3.Show()
            Form3.txtbxlbl.Text = "prssearchtxt"
            Form3.btnbtn.Text = "prsaddbtn"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show(
        "Scan an image? If no, the scanner will be used.",
        "Select Scan Method",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            Using ofd As New OpenFileDialog()
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
                ofd.Title = "Select QR Code Image"
                ofd.Multiselect = False ' Single selection only

                If ofd.ShowDialog() = DialogResult.OK Then
                    Try
                        Using bitmap As New Bitmap(ofd.FileName)
                            Dim reader As New ZXing.BarcodeReader()
                            reader.Options.PossibleFormats = New List(Of ZXing.BarcodeFormat) From {
                            ZXing.BarcodeFormat.QR_CODE
                        }

                            Dim scanResult = reader.Decode(bitmap)

                            If scanResult IsNot Nothing Then
                                rrspsearchtxt.Text = scanResult.Text
                            Else
                                MessageBox.Show("No valid QR code found in the image.", "Scan Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error reading image file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using

        ElseIf result = DialogResult.No Then
            Form3.Show()
            Form3.txtbxlbl.Text = "rrspsearchtxt"
            Form3.btnbtn.Text = "rrspaddbtn"
        End If

    End Sub

    Private Sub rrspsearchtxt_TextChanged(sender As Object, e As EventArgs) Handles rrspsearchtxt.TextChanged
        SetPropertyNumberLabelForCheckout(rrspsearchtxt, rrspsearchlbl)
    End Sub

    Private Sub prssearchtxt_TextChanged(sender As Object, e As EventArgs) Handles prssearchtxt.TextChanged
        SetPropertyNumberLabelForCheckout(prssearchtxt, prssearchlbl)
    End Sub

    Private Sub addemployeesbtn_Click(sender As Object, e As EventArgs) Handles addemployeesbtn.Click
        Employees.ShowDialog()
    End Sub

    Private employeeList As New List(Of KeyValuePair(Of String, String))

    Public Sub LoadEmployeesForSuggestion()
        Dim connString As String = GlobalConnectionString
        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Dim query As String = "SELECT employeename, employeedesignation FROM employee"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        employeeList.Clear()
                        While reader.Read()
                            employeeList.Add(New KeyValuePair(Of String, String)(
                                reader("employeename").ToString().Trim(),
                                reader("employeedesignation").ToString().Trim()
                            ))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employees for suggestion: " & ex.Message)
        End Try
    End Sub

    Private Sub SuggestEmployee(textBox As TextBox, positionTextBox As TextBox)
        If textBox Is Nothing OrElse positionTextBox Is Nothing Then Return
        If employeeList Is Nothing Then employeeList = New List(Of KeyValuePair(Of String, String))()

        Dim source As New AutoCompleteStringCollection()
        source.AddRange(employeeList.Select(Function(x) x.Key).ToArray())

        textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        textBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        textBox.AutoCompleteCustomSource = source

        Dim ApplyEmployeeSelection = Sub()
                                         If employeeList Is Nothing OrElse textBox Is Nothing OrElse positionTextBox Is Nothing Then Return
                                         Dim selectedName As String = textBox.Text.Trim()
                                         Dim emp = employeeList.FirstOrDefault(Function(x) x.Key.Equals(selectedName, StringComparison.OrdinalIgnoreCase))
                                         If Not String.IsNullOrEmpty(emp.Key) Then
                                             textBox.Text = emp.Key
                                             positionTextBox.Text = emp.Value
                                             textBox.SelectionStart = textBox.Text.Length
                                         End If
                                     End Sub

        AddHandler textBox.Leave, Sub(sender, e)
                                      ApplyEmployeeSelection()
                                  End Sub

        AddHandler textBox.KeyDown, Sub(sender, e)
                                        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab Then
                                            ApplyEmployeeSelection()
                                            e.Handled = True
                                        End If
                                    End Sub
    End Sub



    Public Sub InitializeEmployeeSuggestions()
        SuggestEmployee(parrecommendingapprovalfirstnametxt, parrecommendingapprovalpositiontxt)
        SuggestEmployee(parapprovedbyfirstnametxt, parapprovedbypositiontxt)
        SuggestEmployee(parreceivedbyfirstnametxt, parreceivedbypositiontxt)
        SuggestEmployee(rrspfirstnametxt, rrspdesignationtxt)
        SuggestEmployee(prsfirstnametxt, prsdesignationtxt)
        SuggestEmployee(gasrequestedbyfirstnametxt, gasrequestedbypositiontxt)
        SuggestEmployee(gasapprovalrecommendedfirstnametxt, gasapprovalrecommendedpositiontxt)
        SuggestEmployee(gasapprovedforissuancefirstnametxt, gasapprovedforissuancepositiontxt)
        SuggestEmployee(icsfirstnametxt, icsdesignationtxt)
        SuggestEmployee(risrequestedbyfirstnametxt, risdesignationtxt)
        SuggestEmployee(risapprovedbyfirstnametxt, risapprovedbydesignationtxt)
        SuggestEmployee(risreceivedbyfirstnametxt, risreceivedbydesignationtxt)
    End Sub


    Private Sub lowsupplypnl_Click(sender As Object, e As EventArgs) Handles lowsupplypnl.Click
        supplyandmaterialstypecmb.Text = "Low"
        SelectTab("samviewsupply")
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        supplyandmaterialstypecmb.Text = "Low"
        SelectTab("samviewsupply")
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        supplyandmaterialstypecmb.Text = "Low"
        SelectTab("samviewsupply")
    End Sub

    Private Sub lowsupplylbl_Click_1(sender As Object, e As EventArgs) Handles lowsupplylbl.Click
        supplyandmaterialstypecmb.Text = "Low"
        SelectTab("samviewsupply")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        maintbc.SelectedTab = ristab
    End Sub

    Private Sub viewsupplylistbtn_Click(sender As Object, e As EventArgs) Handles viewsupplylistbtn.Click
        maintbc.SelectedTab = supplyandmaterialstab
        insufficientrequestedsupplypnl.Visible = False
        lowsupplypnl.Visible = False
        zerosupplypnl.Visible = False
        addnewsupplybtn.Visible = False
        Button4.Visible = False

        Button6.Visible = True

        If supplyandmaterialsdgv.Columns.Contains("supply_addstock") Then supplyandmaterialsdgv.Columns("supply_addstock").Visible = False
        If supplyandmaterialsdgv.Columns.Contains("supply_edit") Then supplyandmaterialsdgv.Columns("supply_edit").Visible = False
        If supplyandmaterialsdgv.Columns.Contains("supply_details") Then supplyandmaterialsdgv.Columns("supply_details").Visible = False
        If supplyandmaterialsdgv.Columns.Contains("supply_qr") Then supplyandmaterialsdgv.Columns("supply_qr").Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        maintbc.SelectedTab = ristab
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim confirm As DialogResult = MessageBox.Show(
        "Are you sure you want to clear? All fields will be cleared.",
        "Cancel Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    )

        If confirm = DialogResult.Yes Then

            risnumbertxt.Clear()
            risofficecmb.SelectedIndex = -1
            risemailaddresstxt.Clear()
            risphonenumbertxt.Clear()

            risrequestedbyfirstnametxt.Clear()
            risdesignationtxt.Clear()

            risapprovedbyfirstnametxt.Clear()
            risapprovedbydesignationtxt.Clear()

            risreceivedbyfirstnametxt.Clear()
            risreceivedbydesignationtxt.Clear()
            rispurposetxt.Clear()
            risdgv.Rows.Clear()
            risfinishbtn.Show()
            rissaveandapprove.Text = "Save and Approve"
            risdgv.Columns("ris_instock").ReadOnly = True
            risdgv.Columns("ris_outofstock").ReadOnly = True
            SetAllNextNumbers()
            risfinishbtn.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        maintbc.SelectedTab = prsdetailstab
    End Sub


End Class
