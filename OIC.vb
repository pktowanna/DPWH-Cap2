Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Configuration

Public Class OIC

    Public Sub LoadOICData()
        Dim connString As String = (GlobalConnectionString)

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim query As String = "
                SELECT 
                    ID, 
                    FN, 
                    MI, 
                    LN
                FROM account
                WHERE status = 'active'
                AND ID NOT IN (999, 1000)
            "

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        oicdgv.Rows.Clear()

                        While reader.Read()
                            Dim id As String = reader("ID").ToString()
                            Dim fn As String = reader("FN").ToString()
                            Dim mi As String = reader("MI").ToString()
                            Dim ln As String = reader("LN").ToString()

                            Dim fullname As String = $"{fn} {If(mi = "", "", mi.Substring(0, 1) & ". ")}{ln}"

                            oicdgv.Rows.Add(id, fullname)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading OIC data: " & ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OIC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOICData()
    End Sub

    Private Sub signaturelbl_Click(sender As Object, e As EventArgs) Handles signaturelbl.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "PNG Files|*.png|JPEG Files|*.jpg;*.jpeg|All Files|*.*"
            ofd.Title = "Select Signature Image"

            If ofd.ShowDialog() = DialogResult.OK Then
                signaturepic.Image = Image.FromFile(ofd.FileName)

                If signaturepic.Image IsNot Nothing Then
                    signaturelbl.ForeColor = Color.Blue
                End If
            End If
        End Using
    End Sub

    Public Sub LoadOICInfo(Optional frm As Dashboard = Nothing)
        Dim useForm As Dashboard = If(frm IsNot Nothing, frm, Dashboard)
        Dim connStr As String = (GlobalConnectionString)

        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                useForm.oicname.Items.Clear()
                useForm.oicdesignation.Clear()

                Dim query As String = "
            SELECT 
                oic.oicid,
                oic.name,
                oic.designation,
                oicaccount.defaultuser
            FROM oicaccount
            INNER JOIN oic ON oic.oicid = oicaccount.oicid
            WHERE oicaccount.ID = @userid;
        "

                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userid", useForm.userid.Text.Trim())

                Dim defaultOicId As String = ""
                Dim defaultOicName As String = ""
                Dim defaultOicDesignation As String = ""

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim oicName As String = reader("name").ToString()
                        Dim oicDesignation As String = reader("designation").ToString()

                        Dim defaultStr As String = reader("defaultuser").ToString().Trim()
                        Dim isDefault As Boolean = (defaultStr = "1")

                        useForm.oicname.Items.Add(oicName)

                        If isDefault Then
                            defaultOicId = reader("oicid").ToString()
                            defaultOicName = oicName
                            defaultOicDesignation = oicDesignation
                        End If
                    End While
                End Using

                If Not String.IsNullOrWhiteSpace(defaultOicName) Then
                    useForm.oicname.Text = defaultOicName
                    useForm.oicdesignation.Text = defaultOicDesignation
                ElseIf useForm.oicname.Items.Count > 0 Then
                    useForm.oicname.SelectedIndex = 0

                    Dim selectedName As String = useForm.oicname.Text
                    Dim getDesigCmd As New MySqlCommand("
                SELECT designation FROM oic WHERE name = @name LIMIT 1", conn)
                    getDesigCmd.Parameters.AddWithValue("@name", selectedName)
                    Dim result = getDesigCmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        useForm.oicdesignation.Text = result.ToString()
                    End If
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading OIC info: " & ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub oiccancelbtn_Click(sender As Object, e As EventArgs) Handles oiccancelbtn.Click
        Dim result As DialogResult = MessageBox.Show(
            "All fields will be erased. Do you want to continue?",
            "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub oicfinishbtn_Click(sender As Object, e As EventArgs) Handles oicfinishbtn.Click
        If String.IsNullOrWhiteSpace(oicreceivedbyfirstnametxt.Text) OrElse
           String.IsNullOrWhiteSpace(oicreceivedbymiddleinitialtxt.Text) OrElse
           String.IsNullOrWhiteSpace(oicreceivedbylastnametxt.Text) OrElse
           String.IsNullOrWhiteSpace(oicreceivedbydesignationtxt.Text) Then

            MessageBox.Show("Please fill in all required fields.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasAccessChecked As Boolean = False
        For Each row As DataGridViewRow In oicdgv.Rows
            If Not row.IsNewRow Then
                Dim isChecked As Boolean = False
                If row.Cells("oicaccess").Value IsNot Nothing Then
                    Boolean.TryParse(row.Cells("oicaccess").Value.ToString(), isChecked)
                End If

                If isChecked Then
                    hasAccessChecked = True
                    Exit For
                End If
            End If
        Next

        If Not hasAccessChecked Then
            MessageBox.Show("Please select at least one OIC Access.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim connStr As String = (GlobalConnectionString)
        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim trans As MySqlTransaction = conn.BeginTransaction()

            Try
                Dim fullName As String = $"{oicreceivedbyfirstnametxt.Text.Trim()} {oicreceivedbymiddleinitialtxt.Text.Trim()}. {oicreceivedbylastnametxt.Text.Trim()}"
                Dim signatureBytes As Byte() = Nothing

                If signaturepic.Image IsNot Nothing Then
                    Using ms As New MemoryStream()
                        signaturepic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                        signatureBytes = ms.ToArray()
                    End Using
                End If

                Dim insertOicCmd As New MySqlCommand("
                INSERT INTO oic (name, designation, office, oicsignature)
                VALUES (@name, @designation, @office, @oicsignature);
                SELECT LAST_INSERT_ID();
            ", conn, trans)

                insertOicCmd.Parameters.AddWithValue("@name", fullName)
                insertOicCmd.Parameters.AddWithValue("@designation", oicreceivedbydesignationtxt.Text.Trim())
                insertOicCmd.Parameters.AddWithValue("@office", "None")

                If signatureBytes IsNot Nothing Then
                    insertOicCmd.Parameters.Add("@oicsignature", MySqlDbType.LongBlob).Value = signatureBytes
                Else
                    insertOicCmd.Parameters.Add("@oicsignature", MySqlDbType.LongBlob).Value = DBNull.Value
                End If

                Dim newOicId As Integer = Convert.ToInt32(insertOicCmd.ExecuteScalar())

                For Each row As DataGridViewRow In oicdgv.Rows
                    If Not row.IsNewRow Then
                        Dim isAccessChecked As Boolean = False
                        Dim isDefaultChecked As Boolean = False

                        If row.Cells("oicaccess").Value IsNot Nothing Then
                            Boolean.TryParse(row.Cells("oicaccess").Value.ToString(), isAccessChecked)
                        End If
                        If row.Cells("defaultuser").Value IsNot Nothing Then
                            Boolean.TryParse(row.Cells("defaultuser").Value.ToString(), isDefaultChecked)
                        End If

                        If isAccessChecked Then
                            Dim accountId As Integer = Convert.ToInt32(row.Cells("oicid").Value)

                            Dim defaultValueStr As String = If(isDefaultChecked, "1", "0")

                            Dim insertAccountCmd As New MySqlCommand("
                            INSERT INTO oicaccount (oicid, ID, defaultuser)
                            VALUES (@oicid, @ID, @defaultuser)
                        ", conn, trans)

                            insertAccountCmd.Parameters.AddWithValue("@oicid", newOicId)
                            insertAccountCmd.Parameters.AddWithValue("@ID", accountId)
                            insertAccountCmd.Parameters.AddWithValue("@defaultuser", defaultValueStr)
                            insertAccountCmd.ExecuteNonQuery()
                        End If
                    End If
                Next

                trans.Commit()
                MessageBox.Show("OIC record saved successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadOICInfo()
                Me.Close()

            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("Error saving OIC: " & ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub






End Class