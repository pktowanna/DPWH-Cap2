Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Configuration


Public Class Form2

    Private Sub registerfinishbtn_Click(sender As Object, e As EventArgs) Handles registerfinishbtn.Click

        If String.IsNullOrWhiteSpace(registerfirstnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(registermiddleinitialtxt.Text) OrElse
       String.IsNullOrWhiteSpace(registerlastnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(registerusertypecmb.Text) OrElse
       String.IsNullOrWhiteSpace(registerdepartmentcmb.Text) OrElse
       String.IsNullOrWhiteSpace(registerusernametxt.Text) OrElse
       String.IsNullOrWhiteSpace(registerpasswordtxt.Text) OrElse
       String.IsNullOrWhiteSpace(registerconfirmpasswordtxt.Text) OrElse
       String.IsNullOrWhiteSpace(registerpasswordcluetxt.Text) Then

            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If registermiddleinitialtxt.Text.Length <> 1 Then
            MessageBox.Show("Middle Initial must be a single letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            registermiddleinitialtxt.Text = registermiddleinitialtxt.Text.ToUpper()
        End If

        If registerpasswordtxt.Text <> registerconfirmpasswordtxt.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim passwordPattern As String = "^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{9,}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(registerpasswordtxt.Text.Trim(), passwordPattern) Then
            MessageBox.Show("Password must be at least 9 characters and contain both letters and numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim hashedPassword As String = ComputeSha256Hash(registerpasswordtxt.Text.Trim())

        Dim connString As String = GlobalConnectionString
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM account WHERE username = @username"
                Using cmd As New MySqlCommand(checkQuery, conn)
                    cmd.Parameters.AddWithValue("@username", registerusernametxt.Text.Trim())
                    Dim userExists As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If userExists > 0 Then
                        MessageBox.Show("Username already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                Dim insertQuery As String =
                "INSERT INTO account " &
                "(FN, MI, LN, usertype, department, status, username, password, clue, access) " &
                "VALUES (@FN, @MI, @LN, @usertype, @department, 'pending', @username, @password, @clue, 0)"

                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@FN", registerfirstnametxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@MI", registermiddleinitialtxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@LN", registerlastnametxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@usertype", registerusertypecmb.Text.Trim())
                    cmd.Parameters.AddWithValue("@department", registerdepartmentcmb.Text.Trim())
                    cmd.Parameters.AddWithValue("@username", registerusernametxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", hashedPassword)
                    cmd.Parameters.AddWithValue("@clue", registerpasswordcluetxt.Text.Trim())

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Registration Complete! Wait for account approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                registerfirstnametxt.Clear()
                registermiddleinitialtxt.Clear()
                registerlastnametxt.Clear()
                registerusertypecmb.SelectedIndex = -1
                registerdepartmentcmb.SelectedIndex = -1
                registerusernametxt.Clear()
                registerpasswordtxt.Clear()
                registerconfirmpasswordtxt.Clear()
                registerpasswordcluetxt.Clear()

                Me.Close()
                Form1.Show()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

    End Sub



    Private Function ComputeSha256Hash(rawData As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData))

            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub registercancelbtn_Click(sender As Object, e As EventArgs) Handles registercancelbtn.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        registerpasswordtxt.UseSystemPasswordChar = False
        PictureBox1.Image = My.Resources.eyevisible
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        registerpasswordtxt.UseSystemPasswordChar = True
        PictureBox1.Image = My.Resources.eyehidden
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        registerpasswordtxt.UseSystemPasswordChar = True
        PictureBox1.Image = My.Resources.eyehidden
    End Sub
    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        registerconfirmpasswordtxt.UseSystemPasswordChar = False
        PictureBox2.Image = My.Resources.eyevisible
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        registerconfirmpasswordtxt.UseSystemPasswordChar = True
        PictureBox2.Image = My.Resources.eyehidden
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        registerconfirmpasswordtxt.UseSystemPasswordChar = True
        PictureBox2.Image = My.Resources.eyehidden
    End Sub

    Private Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        registerpasswordcluetxt.UseSystemPasswordChar = False
        PictureBox3.Image = My.Resources.eyevisible
    End Sub

    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseUp
        registerpasswordcluetxt.UseSystemPasswordChar = True
        PictureBox3.Image = My.Resources.eyehidden
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        registerpasswordcluetxt.UseSystemPasswordChar = True
        PictureBox3.Image = My.Resources.eyehidden
    End Sub

End Class