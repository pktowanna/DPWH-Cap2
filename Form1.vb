Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Configuration
Imports System.IO
Imports System.Diagnostics
Imports System.Linq
Imports System.Management
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System
Imports System.Windows.Forms
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalVariables.WaitForDatabaseBoot()
        ApplyRoundedStyleToAllButtons(Me)

        Dashboard.supplyandmaterialstypecmb.SelectedIndex = 0
        Dashboard.requeststypecmb.SelectedIndex = 0
        Dashboard.activitytypecmb.SelectedIndex = 0
        Dashboard.equipmentstypecmb.SelectedIndex = 0
        Dashboard.accounttypecmb.SelectedIndex = 0
        Dashboard.rangecmb.SelectedIndex = 0
        Dashboard.equipmentactivitytypecmb.SelectedIndex = 0
        Dashboard.requestsfromdtp.Value = Date.Now.AddMonths(-1)
        Dashboard.gasfromdtp.Value = Date.Now.AddMonths(-1)
        Dashboard.equipmentactivityfromdtm.Value = Date.Now.AddMonths(-1)
    End Sub

    Private Function ComputeSha256Hash(rawData As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub LoginUser()
        Const MaxTries As Integer = 4
        Try
            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()

                Dim query As String = "SELECT * FROM account WHERE username=@username"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", loginusernametxt.Text.Trim())

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim accountID As String = reader("ID").ToString()
                            Dim accountStatus As String = reader("status").ToString().ToLower()
                            Dim failedTries As Integer = If(IsDBNull(reader("failedtries")), 0, Convert.ToInt32(reader("failedtries")))

                            If accountStatus <> "active" Then
                                MessageBox.Show("Account is not active. Contact User Admin (IT).", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                loginpasswordtxt.Clear()
                                Exit Sub
                            End If

                            Dim dbPassword As String = reader("password").ToString()
                            Dim dbPasskey As String = reader("passkey").ToString()
                            Dim inputPassword As String = loginpasswordtxt.Text.Trim()
                            Dim hashedInput As String = ComputeSha256Hash(inputPassword)
                            Dim userType As String = reader("usertype").ToString()
                            Dim FN As String = reader("FN").ToString()
                            Dim MI As String = reader("MI").ToString()
                            Dim LN As String = reader("LN").ToString()
                            Dim fullName As String = $"{FN} {If(MI <> "", MI.Substring(0, 1) & ". ", "")}{LN}"

                            If Not String.IsNullOrEmpty(inputPassword) AndAlso
                           (inputPassword = dbPassword OrElse hashedInput = dbPassword OrElse inputPassword = dbPasskey) Then

                                reader.Close()
                                Using updateCmd As New MySqlCommand("UPDATE account SET failedtries=0 WHERE ID=@id", conn)
                                    updateCmd.Parameters.AddWithValue("@id", accountID)
                                    updateCmd.ExecuteNonQuery()
                                End Using

                                If inputPassword = dbPasskey Then
                                    changepassword.oldpasswordtxt.Enabled = False
                                    changepassword.idlbl.Text = accountID
                                    loginusernametxt.Clear()
                                    loginpasswordtxt.Clear()
                                    Me.Hide()
                                    changepassword.Show()
                                    Exit Sub
                                End If

                                Dashboard.userid.Text = accountID
                                Dashboard.userlvl.Text = userType
                                Dashboard.nameofuser.Text = fullName
                                loginusernametxt.Clear()
                                loginpasswordtxt.Clear()
                                Me.Hide()
                                Dashboard.Show()
                            Else
                                failedTries += 1
                                reader.Close()

                                If failedTries >= MaxTries Then
                                    Using lockCmd As New MySqlCommand("UPDATE account SET status='deactivated', failedtries=@tries WHERE ID=@id", conn)
                                        lockCmd.Parameters.AddWithValue("@id", accountID)
                                        lockCmd.Parameters.AddWithValue("@tries", failedTries)
                                        lockCmd.ExecuteNonQuery()
                                    End Using
                                    MessageBox.Show("Account Locked. Contact User Admin (IT).", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Else
                                    Using failCmd As New MySqlCommand("UPDATE account SET failedtries=@tries WHERE ID=@id", conn)
                                        failCmd.Parameters.AddWithValue("@id", accountID)
                                        failCmd.Parameters.AddWithValue("@tries", failedTries)
                                        failCmd.ExecuteNonQuery()
                                    End Using
                                    Dim triesLeft As Integer = MaxTries - failedTries
                                    MessageBox.Show($"Wrong Username or Password. Tries Left: {triesLeft}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    loginpasswordtxt.Clear()
                                End If
                            End If
                        Else
                            MessageBox.Show("Wrong Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        LoginUser()
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        If MessageBox.Show("Are you sure you want to exit?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub registerlbl_Click(sender As Object, e As EventArgs) Handles registerlbl.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        loginpasswordtxt.UseSystemPasswordChar = False
        PictureBox1.Image = My.Resources.eyevisible
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        loginpasswordtxt.UseSystemPasswordChar = True
        PictureBox1.Image = My.Resources.eyehidden
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        loginpasswordtxt.UseSystemPasswordChar = True
        PictureBox1.Image = My.Resources.eyehidden
    End Sub

    Private Sub forgotpasswordlbl_Click(sender As Object, e As EventArgs) Handles forgotpasswordlbl.Click
        Dim username As String = loginusernametxt.Text.Trim()

        If String.IsNullOrEmpty(username) Then
            MessageBox.Show("Please enter your username first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try

            Using conn As New MySqlConnection(GlobalConnectionString)
                conn.Open()


                Dim query As String = "SELECT clue FROM account WHERE username = @username LIMIT 1"
                Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim clueObj = cmd.ExecuteScalar()

                    If clueObj IsNot Nothing AndAlso Not IsDBNull(clueObj) Then
                        MessageBox.Show("Password hint: " & clueObj.ToString(), "Password Hint", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No password hint found for this username.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error fetching password hint: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
