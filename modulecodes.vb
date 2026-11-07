Imports MySql.Data.MySqlClient
Imports QRCoder
Imports System.Configuration
Imports System.Drawing
Imports ZXing
Imports System.Windows.Forms
Imports System.ServiceProcess
Imports System.Net.NetworkInformation
Imports System.IO
Imports System
Imports System.Diagnostics
Imports System.Net.Sockets
Imports System.Threading
Imports Org.BouncyCastle.Pqc.Crypto.Utilities.PqcOtherInfoGenerator


Public Module GlobalVariables

    Public ReadOnly GlobalConnectionString As String = "Server=127.0.0.1;Port=3306;Database=supply;Uid=root;Pwd=;Pooling=false;Connection Timeout=5;"

    Public con As New MySqlConnection(GlobalConnectionString)

    Public Sub WaitForDatabaseBoot()
        Try
            If Not IsPortOpen("127.0.0.1", 3306) Then
                Throw New Exception("XAMPP MySQL server is not running. Please open the XAMPP Control Panel and start the MySQL module.")
            End If

            Dim connected As Boolean = False
            Dim attempts As Integer = 0

            Do While attempts < 3
                If CanConnectToSupply() Then
                    connected = True
                    Exit Do
                End If
                attempts += 1
                Thread.Sleep(1000)
            Loop

            If Not connected Then
                Throw New Exception("Connected to MySQL, but the database 'supply' was not found. " & Environment.NewLine &
                                    "Please open phpMyAdmin (http://localhost/phpmyadmin) and ensure you have created a database named 'supply'.")
            End If

        Catch ex As Exception
            MessageBox.Show("Database connection failed: " & Environment.NewLine & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Environment.Exit(1)
        End Try
    End Sub

    Private Function CanConnectToSupply() As Boolean
        Try
            Using c As New MySqlConnection(GlobalConnectionString)
                c.Open()
                Return True
            End Using
        Catch
            Return False
        End Try
    End Function

    Private Function IsPortOpen(host As String, port As Integer) As Boolean
        Try
            Using tcp As New TcpClient()
                Dim result = tcp.BeginConnect(host, port, Nothing, Nothing)
                Dim success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(2))
                If Not success Then Return False
                tcp.EndConnect(result)
                Return True
            End Using
        Catch
            Return False
        End Try
    End Function

End Module


Module modulecodes


    Public Sub RefreshLowStock(Optional frm As Dashboard = Nothing)
        Dim useForm As Dashboard = If(frm IsNot Nothing, frm, Dashboard)
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            Dim cmd As New MySqlCommand("
            SELECT COUNT(*) 
            FROM supply
            WHERE supplybalance > 0 AND supplybalance < 10
        ", con)
            useForm.lowsupplylbl.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Public Sub RefreshZeroStock(Optional frm As Dashboard = Nothing)
        Dim useForm As Dashboard = If(frm IsNot Nothing, frm, Dashboard)
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            Dim cmd As New MySqlCommand("
            SELECT COUNT(*) 
            FROM (
                SELECT ss.stockno
                FROM supplystock ss
                GROUP BY ss.stockno
                HAVING SUM(ss.qtybalance) = 0
            ) t
        ", con)
            useForm.zerosupplylbl.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Public Sub RefreshInsufficientRequestedSupply(Optional frm As Dashboard = Nothing)
        Dim useForm As Dashboard = If(frm IsNot Nothing, frm, Dashboard)
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            Dim query As String = "
            SELECT COUNT(*) FROM (
                SELECT 
                    rs.stockno,
                    rs.requested_qty,
                    s.supplybalance,
                    rs.approval,
                    r.status AS ris_status
                FROM ris_supply rs
                JOIN supply s ON rs.stockno = s.stockno
                JOIN ris r ON rs.risnumber = r.risnumber
                WHERE rs.requested_qty > s.supplybalance
            ) AS x
            WHERE
                (x.approval = 0)
                OR
                (x.approval IN (1,2) AND x.ris_status = 'pending')
        "
            Dim cmd As New MySqlCommand(query, con)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            useForm.insufficientrequestedsupplylbl.Text = count.ToString()
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Public Sub LoadLowSupply(frm As Dashboard)
        frm.supplyandmaterialstypecmb.Text = "Low"
        Dim query As String = "
        SELECT 
            stockno,
            description,
            supplybalance
        FROM supply
        WHERE supplybalance > 0 AND supplybalance < 10
    "
        Try
            Using con As New MySqlConnection(GlobalConnectionString)
                Using cmd As New MySqlCommand(query, con)
                    con.Open()

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        frm.supplyandmaterialsdgv.Rows.Clear()
                        While reader.Read()
                            Dim idx As Integer = frm.supplyandmaterialsdgv.Rows.Add()
                            With frm.supplyandmaterialsdgv.Rows(idx)
                                .Cells("supply_stockno").Value = reader("stockno").ToString()
                                .Cells("supply_description").Value = reader("description").ToString()
                                .Cells("supply_balanceqty").Value = reader("supplybalance").ToString()
                                .Cells("supply_status").Value = "Low"
                                .Cells("supply_status").Style.BackColor = Color.FromArgb(255, 192, 128)
                            End With
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading low supplies: " & ex.Message)
        End Try
        frm.maintbc.SelectedTab = frm.supplyandmaterialstab
    End Sub

    Public Sub LoadSupplyAndMaterials(frm As Dashboard)
        If frm.supplyandmaterialsdgv.Columns.Count = 0 Then Exit Sub
        Dim baseQuery As String = "
        SELECT 
            s.stockno,
            s.description,
            s.supplybalance,
            IFNULL(SUM(
                CASE 
                    WHEN r.approval = 0 THEN IFNULL(r.requested_qty,0)
                    WHEN r.approval IN (1,2) AND IFNULL(rs.status,'') = 'pending' THEN IFNULL(r.requested_qty,0)
                    ELSE 0
                END
            ), 0) AS total_requested
        FROM supply s
        LEFT JOIN ris_supply r ON s.stockno = r.stockno
        LEFT JOIN ris rs ON r.risnumber = rs.risnumber
        WHERE 1=1
    "
        If Not String.IsNullOrWhiteSpace(frm.supplyandmaterialssearchtxt.Text) Then
            baseQuery &= " AND (s.description LIKE @search OR s.stockno LIKE @search) "
        End If
        Select Case frm.supplyandmaterialstypecmb.Text
            Case "Low"
                baseQuery &= " AND s.supplybalance > 0 AND s.supplybalance < 10 "
            Case "Zero"
                baseQuery &= " AND s.supplybalance = 0 "
            Case "Requested Insufficient"
                baseQuery &= "
                AND s.stockno IN (
                    SELECT s2.stockno
                    FROM supply s2
                    LEFT JOIN ris_supply r2 ON s2.stockno = r2.stockno
                    LEFT JOIN ris rs2 ON r2.risnumber = rs2.risnumber
                    GROUP BY s2.stockno, s2.supplybalance
                    HAVING IFNULL(SUM(
                        CASE
                            WHEN r2.approval = 0 THEN IFNULL(r2.requested_qty,0)
                            WHEN r2.approval IN (1,2) AND IFNULL(rs2.status,'') = 'pending' THEN IFNULL(r2.requested_qty,0)
                            ELSE 0
                        END
                    ),0) > s2.supplybalance
                )"
            Case "Stock No."
                If Not String.IsNullOrWhiteSpace(frm.supplyandmaterialssearchtxt.Text) Then
                    baseQuery &= " AND s.stockno = @search "
                End If
            Case "Description"
                If Not String.IsNullOrWhiteSpace(frm.supplyandmaterialssearchtxt.Text) Then
                    baseQuery &= " AND s.description = @search "
                End If
        End Select
        baseQuery &= "
        GROUP BY s.stockno, s.description, s.supplybalance
        ORDER BY s.description ASC
    "
        Try
            Using con As New MySqlConnection(GlobalConnectionString)
                Using cmd As New MySqlCommand(baseQuery, con)
                    If Not String.IsNullOrWhiteSpace(frm.supplyandmaterialssearchtxt.Text) Then
                        cmd.Parameters.AddWithValue("@search", "%" & frm.supplyandmaterialssearchtxt.Text.Trim() & "%")
                    End If
                    con.Open()

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        frm.supplyandmaterialsdgv.Rows.Clear()
                        While reader.Read()
                            Dim stockno As String = If(IsDBNull(reader("stockno")), "", reader("stockno").ToString())
                            Dim description As String = If(IsDBNull(reader("description")), "", reader("description").ToString())
                            Dim requested As Integer = If(IsDBNull(reader("total_requested")), 0, Convert.ToInt32(reader("total_requested")))
                            Dim balance As Integer = If(IsDBNull(reader("supplybalance")), 0, Convert.ToInt32(reader("supplybalance")))
                            Dim status As String = "Okay"
                            If requested > balance Then
                                status = "Supply Insufficient"
                            ElseIf balance = 0 Then
                                status = "Zero"
                            ElseIf balance < 10 Then
                                status = "Low"
                            End If
                            Dim idx As Integer = frm.supplyandmaterialsdgv.Rows.Add()
                            With frm.supplyandmaterialsdgv.Rows(idx)
                                .Cells("supply_stockno").Value = stockno
                                .Cells("supply_description").Value = description
                                .Cells("supply_quantityrequested").Value = requested
                                .Cells("supply_balanceqty").Value = balance
                                .Cells("supply_status").Value = status
                                Select Case status
                                    Case "Supply Insufficient"
                                        .Cells("supply_status").Style.BackColor = Color.Gold
                                    Case "Zero"
                                        .Cells("supply_status").Style.BackColor = Color.Red
                                    Case "Low"
                                        .Cells("supply_status").Style.BackColor = Color.Orange
                                    Case "Okay"
                                        .Cells("supply_status").Style.BackColor = Color.LightGreen
                                End Select
                            End With
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading supply data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub AddStockButtonClick(dgv As DataGridView, e As DataGridViewCellEventArgs)
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                If dgv.Columns(e.ColumnIndex).Name = "supply_addstock" Then
                    Dim stockno As String = dgv.Rows(e.RowIndex).Cells("supply_stockno").Value.ToString()
                    AddStock.addstockstocknolbl.Text = stockno
                    AddStock.addstockdatedtp.Value = DateTime.Now
                    AddStock.Show()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error handling AddStock button: " & ex.Message)
        End Try
    End Sub

    Public Sub ShowQRFromRow(dgv As DataGridView, e As DataGridViewCellEventArgs)
        Try
            If e.RowIndex >= 0 AndAlso dgv.Columns(e.ColumnIndex).Name = "supply_qr" Then
                Dim stockno As String = dgv.Rows(e.RowIndex).Cells("supply_stockno").Value.ToString()
                Dim description As String = dgv.Rows(e.RowIndex).Cells("supply_description").Value.ToString()
                Dim qrGen As New QRCodeGenerator()
                Dim qrData As QRCodeData = qrGen.CreateQrCode(stockno, QRCodeGenerator.ECCLevel.Q)
                Dim qrCode As New QRCode(qrData)
                Dim qrImage As Bitmap = qrCode.GetGraphic(5)
                QR.qrpic.Image = qrImage
                QR.qrlabellbl.Text = description
                QR.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show("Error generating QR: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private ReadOnly connString As String = GlobalConnectionString

    Public Sub RefreshPendingPARApproval(Optional frm As Dashboard = Nothing)
        Dim useForm As Dashboard = If(frm IsNot Nothing, frm, Dashboard)
        Try
            Using con As New MySqlConnection(GlobalConnectionString)
                con.Open()

                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM par WHERE issuedby IS NULL OR issuedby = ''", con)
                useForm.pendingparapprovallbl.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error refreshing Pending PAR Approval: " & ex.Message)
        End Try
    End Sub

    Public Sub RefreshPendingRISApproval(Optional frm As Dashboard = Nothing)
        Dim useForm As Dashboard = If(frm IsNot Nothing, frm, Dashboard)
        Try
            Using con As New MySqlConnection(GlobalConnectionString)
                con.Open()

                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM ris WHERE issuedby IS NULL OR issuedby = ''", con)
                useForm.pendingrrspandprsapprovallbl.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error refreshing Pending RIS Approval: " & ex.Message)
        End Try
    End Sub

    Public Sub RefreshEquipmentsIn(Optional frm As Dashboard = Nothing)
        Dim useForm As Dashboard = If(frm IsNot Nothing, frm, Dashboard)
        Try
            Using con As New MySqlConnection(GlobalConnectionString)
                con.Open()

                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM equipment WHERE status = 'IN'", con)
                useForm.equipmentsinlbl.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error refreshing Equipments IN: " & ex.Message)
        End Try
    End Sub

    Public Sub RefreshEquipmentsOut(Optional frm As Dashboard = Nothing)
        Dim useForm As Dashboard = If(frm IsNot Nothing, frm, Dashboard)
        Try
            Using con As New MySqlConnection(GlobalConnectionString)
                con.Open()

                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM equipment WHERE status = 'OUT'", con)
                useForm.equipmentsoutlbl.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error refreshing Equipments OUT: " & ex.Message)
        End Try
    End Sub

    Public Sub RefreshAllDashboardCounters(Optional frm As Dashboard = Nothing)
        RefreshPendingPARApproval(frm)
        RefreshPendingRISApproval(frm)
        RefreshEquipmentsIn(frm)
        RefreshEquipmentsOut(frm)
        LoadDashboardCounts(frm)
    End Sub

    Public Sub LoadEquipmentsData(Optional frm As Dashboard = Nothing)
        If frm.equipmentsdgv.Columns.Count = 0 Then Exit Sub
        Dim useForm As Dashboard = If(frm IsNot Nothing, frm, Dashboard)
        Dim connStringLocal As String = GlobalConnectionString
        Dim query As String = "
        SELECT propertynumber, 
               description,
               status,
               SUBSTRING_INDEX(description, '\n', 1) AS primarydesc
        FROM equipment
        WHERE 1=1
    "
        If Not String.IsNullOrWhiteSpace(useForm.equipmentssearchtxt.Text) Then
            query &= " AND (propertynumber LIKE @search OR SUBSTRING_INDEX(description, '\n', 1) LIKE @search)"
        End If
        Select Case useForm.equipmentstypecmb.Text
            Case "In"
                query &= " AND status = 'IN'"
            Case "Out"
                query &= " AND status = 'OUT'"
        End Select
        Try
            Using conLocal As New MySqlConnection(GlobalConnectionString)
                Using cmd As New MySqlCommand(query, conLocal)
                    If Not String.IsNullOrWhiteSpace(useForm.equipmentssearchtxt.Text) Then
                        cmd.Parameters.AddWithValue("@search", "%" & useForm.equipmentssearchtxt.Text.Trim() & "%")
                    End If
                    conLocal.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        useForm.equipmentsdgv.Rows.Clear()
                        While reader.Read()
                            Dim idx As Integer = useForm.equipmentsdgv.Rows.Add()
                            With useForm.equipmentsdgv.Rows(idx)
                                .Cells("equipmentsid").Value = reader("propertynumber").ToString()
                                .Cells("equipmentdescription").Value = reader("description").ToString()
                                .Cells("equipmentstatus").Value = reader("status").ToString()
                            End With
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading equipments: " & ex.Message)
        End Try
    End Sub

    Public Sub LoadGasData(Optional frm As Dashboard = Nothing)
        If frm Is Nothing OrElse frm.gasviewdgv.Columns.Count = 0 Then Exit Sub

        Dim useForm As Dashboard = frm
        Dim connStringLocal As String = (GlobalConnectionString)

        Dim query As String = "
        SELECT gasdate, 
               stocknumber, 
               requestedby
        FROM gas
        WHERE 1=1
    "

        If Not String.IsNullOrWhiteSpace(useForm.gassearchtxt.Text) Then
            query &= " AND (stocknumber LIKE @search OR requestedby LIKE @search)"
        End If

        query &= " AND gasdate BETWEEN @fromDate AND @toDate"

        query &= " ORDER BY gasdate DESC"

        Try
            Using conLocal As New MySqlConnection(connStringLocal)
                Using cmd As New MySqlCommand(query, conLocal)
                    If Not String.IsNullOrWhiteSpace(useForm.gassearchtxt.Text) Then
                        cmd.Parameters.AddWithValue("@search", "%" & useForm.gassearchtxt.Text.Trim() & "%")
                    Else
                        cmd.Parameters.AddWithValue("@search", "%%") ' Placeholder when no search
                    End If

                    cmd.Parameters.AddWithValue("@fromDate", useForm.gasfromdtp.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@toDate", useForm.gastodtm.Value.ToString("yyyy-MM-dd"))

                    conLocal.Open()

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        useForm.gasviewdgv.Rows.Clear()

                        While reader.Read()
                            Dim idx As Integer = useForm.gasviewdgv.Rows.Add()
                            With useForm.gasviewdgv.Rows(idx)
                                .Cells("gasdate").Value = Convert.ToDateTime(reader("gasdate")).ToString("yyyy-MM-dd")
                                .Cells("gasstocknumber").Value = reader("stocknumber").ToString()
                                .Cells("gasrequestedby").Value = reader("requestedby").ToString()
                            End With
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading GAS data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private connStr As String = (GlobalConnectionString)






    Public Sub LoadEquipmentCounts(Optional frm As Dashboard = Nothing)
        Dim useForm As Dashboard = If(frm IsNot Nothing, frm, Dashboard)
        Dim connStrLocal As String = (GlobalConnectionString)

        Using connLocal As New MySqlConnection(connStrLocal)
            Try
                connLocal.Open()

                Dim cmdIn As New MySqlCommand("SELECT COUNT(*) FROM equipment WHERE status = 'IN'", connLocal)
                Dim inCount As Integer = Convert.ToInt32(cmdIn.ExecuteScalar())

                Dim cmdOut As New MySqlCommand("SELECT COUNT(*) FROM equipment WHERE status = 'OUT'", connLocal)
                Dim outCount As Integer = Convert.ToInt32(cmdOut.ExecuteScalar())

                useForm.equipmentsinlbl.Text = inCount.ToString()
                useForm.equipmentsoutlbl.Text = outCount.ToString()

            Catch ex As Exception
                MessageBox.Show("Error loading equipment counts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Public Sub ScanQRCodeSearch(targetTextBox As TextBox, triggerButton As Button)
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp"

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim qrReader As New BarcodeReader()
                Dim result = qrReader.Decode(New Bitmap(ofd.FileName))

                If result IsNot Nothing Then
                    targetTextBox.Text = result.Text
                    triggerButton.PerformClick()
                Else
                    MessageBox.Show("No QR code detected in the selected image.", "Scan Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End Using
    End Sub


    Public Sub LoadRecentActivity(dashboard As Dashboard)

        If dashboard.recentactivitydgv.Columns.Count = 0 Then Return

        Dim query As String = ""
        Dim filter As String = dashboard.activitytypecmb.Text.Trim()
        Dim rangeFilter As String = dashboard.rangecmb.Text.Trim()
        Dim dateCondition As String = ""

        Select Case rangeFilter
            Case "Today"
                dateCondition = "DATE(NOW())"
            Case "Previous Week"
                dateCondition = "DATE_SUB(CURDATE(), INTERVAL 7 DAY)"
            Case "Previous Month"
                dateCondition = "DATE_SUB(CURDATE(), INTERVAL 1 MONTH)"
            Case Else
                dateCondition = "DATE_SUB(NOW(), INTERVAL 48 HOUR)"
        End Select

        Select Case filter
            Case "All"
                query = $"
    SELECT gas.stocknumber AS id, 'Gas' AS activitytype, 'Gas Slip' AS activitytransactiontype, DATE_FORMAT(gasdate, '%Y-%m-%d') AS activitydate 
    FROM gas WHERE gasdate >= {dateCondition}
    UNION ALL
    SELECT ics.icsno AS id, 'Equipments', 'ICS', DATE_FORMAT(icsdate, '%Y-%m-%d') 
    FROM ics WHERE icsdate >= {dateCondition}
    UNION ALL
    SELECT par.parnumber AS id, 'Equipments', 'PAR', DATE_FORMAT(date, '%Y-%m-%d') 
    FROM par WHERE date >= {dateCondition}
    UNION ALL
    SELECT prs.prsnumber AS id, 'Equipments', 'PRS', DATE_FORMAT(date, '%Y-%m-%d') 
    FROM prs WHERE date >= {dateCondition}
    UNION ALL
    SELECT rrsp.rrspnumber AS id, 'Equipments', 'RRSP', DATE_FORMAT(date, '%Y-%m-%d') 
    FROM rrsp WHERE date >= {dateCondition}
    UNION ALL
    SELECT ris.risnumber AS id, 'Requests', 'RIS', DATE_FORMAT(date, '%Y-%m-%d') 
    FROM ris WHERE date >= {dateCondition}
    UNION ALL
    SELECT supplystock.supplystockid AS id, 'Supply & Materials', 'Stock Card', DATE_FORMAT(supplystockdate, '%Y-%m-%d') 
    FROM supplystock WHERE supplystockdate >= {dateCondition};"

            Case "Requests"
                query = $"
    SELECT ris.risnumber AS id, 'Requests' AS activitytype, 'RIS' AS activitytransactiontype, DATE_FORMAT(date, '%Y-%m-%d') AS activitydate 
    FROM ris WHERE date >= {dateCondition};"

            Case "Supply & Materials"
                query = $"
            SELECT supplystock.supplystockid AS id, 'Supply & Materials' AS activitytype, 'Stock Card' AS activitytransactiontype, 
                   DATE_FORMAT(supplystock.supplystockdate, '%Y-%m-%d') AS activitydate 
            FROM supplystock WHERE supplystock.supplystockdate >= {dateCondition};"

            Case "Equipments"
                query = $"
            SELECT ics.icsno AS id, 'Equipments' AS activitytype, 'ICS' AS activitytransactiontype, 
                   DATE_FORMAT(icsdate, '%Y-%m-%d') AS activitydate 
            FROM ics WHERE icsdate >= {dateCondition}
            UNION ALL
            SELECT par.parnumber AS id, 'Equipments', 'PAR', DATE_FORMAT(par.date, '%Y-%m-%d') 
            FROM par WHERE par.date >= {dateCondition}
            UNION ALL
            SELECT prs.prsnumber AS id, 'Equipments', 'PRS', DATE_FORMAT(prs.date, '%Y-%m-%d') 
            FROM prs WHERE prs.date >= {dateCondition}
            UNION ALL
            SELECT rrsp.rrspnumber AS id, 'Equipments', 'RRSP', DATE_FORMAT(rrsp.date, '%Y-%m-%d') 
            FROM rrsp WHERE rrsp.date >= {dateCondition};"

            Case "Gas"
                query = $"
            SELECT gas.stocknumber AS id, 'Gas' AS activitytype, 'Gas Slip' AS activitytransactiontype, 
                   DATE_FORMAT(gasdate, '%Y-%m-%d') AS activitydate 
            FROM gas WHERE gasdate >= {dateCondition};"
        End Select

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dashboard.recentactivitydgv.Rows.Clear()

                        While reader.Read()
                            dashboard.recentactivitydgv.Rows.Add(
                            reader("id").ToString(),
                            reader("activitytype").ToString(),
                            reader("activitytransactiontype").ToString(),
                            reader("activitydate").ToString()
                        )
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading activities: " & ex.Message)
        End Try
    End Sub


    Public Sub LoadEquipmentActivity(dashboard As Dashboard)
        If dashboard.equipmentactivitydgv.Columns.Count = 0 Then Exit Sub

        Dim filter As String = dashboard.equipmentactivitytypecmb.Text.Trim()
        Dim searchText As String = dashboard.equipmentactivitysearchtxt.Text.Trim()
        Dim fromDate As Date = dashboard.equipmentactivityfromdtm.Value.Date
        Dim toDate As Date = dashboard.equipmentactivitytodtm.Value.Date

        Dim query As String = ""
        Dim dateFilterICS As String = $"icsdate BETWEEN '{fromDate:yyyy-MM-dd}' AND '{toDate:yyyy-MM-dd}'"
        Dim dateFilterOthers As String = $"date BETWEEN '{fromDate:yyyy-MM-dd}' AND '{toDate:yyyy-MM-dd}'"

        Select Case filter
            Case "All"
                query = $"
                SELECT ics.icsno AS documentid, 'Inventory Custodian Slip' AS documenttype, DATE_FORMAT(icsdate, '%Y-%m-%d') AS documentdate 
                FROM ics WHERE {dateFilterICS}
                UNION ALL
                SELECT par.parnumber AS documentid, 'Property Acknowledgement Receipt' AS documenttype, DATE_FORMAT(date, '%Y-%m-%d') AS documentdate 
                FROM par WHERE {dateFilterOthers}
                UNION ALL
                SELECT prs.prsnumber AS documentid, 'Property Return Slip' AS documenttype, DATE_FORMAT(date, '%Y-%m-%d') AS documentdate 
                FROM prs WHERE {dateFilterOthers}
                UNION ALL
                SELECT rrsp.rrspnumber AS documentid, 'Receipt of Returned Semi-Expendable Property' AS documenttype, DATE_FORMAT(date, '%Y-%m-%d') AS documentdate 
                FROM rrsp WHERE {dateFilterOthers}
            "

            Case "ICS"
                query = $"SELECT icsno AS documentid, 'Inventory Custodian Slip' AS documenttype, DATE_FORMAT(icsdate, '%Y-%m-%d') AS documentdate FROM ics WHERE {dateFilterICS}"

            Case "PAR"
                query = $"SELECT parnumber AS documentid, 'Property Acknowledgement Receipt' AS documenttype, DATE_FORMAT(date, '%Y-%m-%d') AS documentdate FROM par WHERE {dateFilterOthers}"

            Case "PRS"
                query = $"SELECT prsnumber AS documentid, 'Property Return Slip' AS documenttype, DATE_FORMAT(date, '%Y-%m-%d') AS documentdate FROM prs WHERE {dateFilterOthers}"

            Case "RRSP"
                query = $"SELECT rrspnumber AS documentid, 'Receipt of Returned Semi-Expendable Property' AS documenttype, DATE_FORMAT(date, '%Y-%m-%d') AS documentdate FROM rrsp WHERE {dateFilterOthers}"
        End Select

        If Not String.IsNullOrWhiteSpace(searchText) Then
            query = $"SELECT * FROM ({query}) AS temp WHERE documentid LIKE '%{MySqlHelper.EscapeString(searchText)}%' ORDER BY documentdate DESC"
        Else
            query = $"SELECT * FROM ({query}) AS temp ORDER BY documentdate DESC"
        End If

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dashboard.equipmentactivitydgv.Rows.Clear()

                        While reader.Read()
                            dashboard.equipmentactivitydgv.Rows.Add(
                            reader("documentid").ToString(),
                            reader("documenttype").ToString(),
                            reader("documentdate").ToString()
                        )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading equipment activity: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SetDatagrids(frm As Form)

        Dim targetGrids As String() = {
        "recentactivitydgv",
        "requestsdgv",
        "supplyandmaterialsdgv",
        "maintbc",
        "gasviewdgv",
        "risdgv",
        "pardgv",
        "rrspdgv",
        "prsdgv",
        "gasslipdgv",
        "icsdgv",
        "equipmentactivitydgv",
        "accountdgv",
        "movementlogdgv",
        "movementlogdescriptiondgv",
        "oicdgv",
        "stockcardsdgv",
        "employeesdgv"
    }

        ApplyGridSettingsRecursive(frm, targetGrids)

    End Sub

    Private Sub ApplyGridSettingsRecursive(
    parent As Control,
    targetGrids As String()
)

        For Each ctrl As Control In parent.Controls

            If TypeOf ctrl Is DataGridView AndAlso
           targetGrids.Contains(ctrl.Name,
                                StringComparer.OrdinalIgnoreCase) Then

                Dim dgv As DataGridView = DirectCast(ctrl, DataGridView)

                With dgv
                    .ColumnHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter

                    .ColumnHeadersDefaultCellStyle.WrapMode =
                    DataGridViewTriState.True

                    .RowHeadersVisible = False

                    .DefaultCellStyle.WrapMode =
                    DataGridViewTriState.True

                    .AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.AllCells

                    .AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.AllCells

                    For Each col As DataGridViewColumn In .Columns

                        If TypeOf col Is DataGridViewCheckBoxColumn Then
                            col.Visible = True
                            col.AutoSizeMode =
                            DataGridViewAutoSizeColumnMode.AllCells
                            col.MinimumWidth = 30
                        End If

                    Next
                End With

            End If

            If ctrl.HasChildren Then
                ApplyGridSettingsRecursive(ctrl, targetGrids)
            End If

        Next

    End Sub
    Public Sub LoadRISData(frm As Dashboard)

        If frm.requestsdgv.Columns.Count = 0 Then Exit Sub

        Dim baseQuery As String = "
SELECT 
    risnumber,
    `date`,
    office,
    requestedby,
    status
FROM ris
WHERE 1=1
"

        baseQuery &= " AND `date` BETWEEN @fromDate AND @toDate "

        Select Case frm.requeststypecmb.Text
            Case "Pending"
                baseQuery &= " AND status = 'Pending' "
            Case "Approved"
                baseQuery &= " AND status = 'Approved' "
            Case "Office"
                baseQuery &= " AND office IN ('Administrative','Construction','Finance','Maintenance','Planning and Design','Quality Assurance','ODE') "
            Case "All"
        End Select

        baseQuery &= " ORDER BY `date` DESC "

        Try
            Using con As New MySqlConnection(GlobalConnectionString)
                Using cmd As New MySqlCommand(baseQuery, con)
                    cmd.Parameters.AddWithValue("@fromDate", frm.requestsfromdtp.Value.Date)
                    cmd.Parameters.AddWithValue("@toDate", frm.requeststodtp.Value.Date)

                    con.Open()

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        frm.requestsdgv.Rows.Clear()

                        While reader.Read()
                            Dim risNumber As String = reader("risnumber").ToString()
                            Dim risDate As Date = Convert.ToDateTime(reader("date"))
                            Dim office As String = reader("office").ToString()
                            Dim requestedBy As String = reader("requestedby").ToString()
                            Dim status As String = reader("status").ToString()

                            Dim rowColor As Color = Color.White
                            Select Case status.ToLower()
                                Case "pending" : rowColor = Color.LightYellow
                                Case "approved" : rowColor = Color.LightGreen
                            End Select

                            Dim idx As Integer = frm.requestsdgv.Rows.Add()
                            With frm.requestsdgv.Rows(idx)
                                .Cells("request_id").Value = risNumber
                                .Cells("request_date").Value = risDate.ToString("yyyy-MM-dd")
                                .Cells("request_office").Value = office
                                .Cells("request_requestedby").Value = requestedBy
                                .Cells("request_status").Value = status
                            End With

                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading RIS data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub LoadDashboardCounts(dashboard As Dashboard)

        Dim pendingQuery As String = "
        SELECT
            (SELECT COUNT(*) FROM par
             WHERE approvedby IS NULL OR TRIM(approvedby) = '')
            +
            (SELECT COUNT(*) FROM prs
             WHERE approvedby IS NULL OR TRIM(approvedby) = '')
    "

        Dim pendingRISQuery As String = "
        SELECT COUNT(*)
        FROM ris
        WHERE approvedbydesignation IS NULL
           OR TRIM(approvedbydesignation) = ''
    "

        Dim supplyQuery As String = "
        SELECT COUNT(*) FROM supply
    "

        Dim equipmentQuery As String = "
        SELECT COUNT(*) FROM equipment
    "

        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Using cmd As New MySqlCommand(pendingQuery, conn)
                    Dim pendingCount As Integer =
                        Convert.ToInt32(cmd.ExecuteScalar())

                    dashboard.Pending.Text = pendingCount.ToString()
                End Using

                Using cmd As New MySqlCommand(pendingRISQuery, conn)
                    Dim pendingRISCount As Integer =
                        Convert.ToInt32(cmd.ExecuteScalar())

                    dashboard.pendingissuanceapprovallbl.Text =
                        pendingRISCount.ToString()
                End Using

                Using cmd As New MySqlCommand(supplyQuery, conn)
                    Dim supplyCount As Integer =
                        Convert.ToInt32(cmd.ExecuteScalar())

                    dashboard.supplyandmaterials.Text =
                        supplyCount.ToString()
                End Using

                Using cmd As New MySqlCommand(equipmentQuery, conn)
                    Dim equipmentCount As Integer =
                        Convert.ToInt32(cmd.ExecuteScalar())

                    dashboard.equip.Text = equipmentCount.ToString()
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Error loading dashboard counts: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

    End Sub

End Module
