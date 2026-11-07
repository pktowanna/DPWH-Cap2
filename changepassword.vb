Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Configuration

Public Class changepassword

    Private Sub finishbtn_Click(sender As Object, e As EventArgs) Handles finishbtn.Click
        Dim connStr As String = (GlobalConnectionString)

        If String.IsNullOrWhiteSpace(newpasswordtxt.Text) OrElse String.IsNullOrWhiteSpace(confirmpasswordtxt.Text) Then
            MessageBox.Show("Please fill out all password fields.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If newpasswordtxt.Text <> confirmpasswordtxt.Text Then
            MessageBox.Show("New password and confirmation do not match.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim HashPassword As Func(Of String, String) =
        Function(pwd As String)
            Using sha As SHA256 = SHA256.Create()
                Dim bytes As Byte() = sha.ComputeHash(Encoding.UTF8.GetBytes(pwd))
                Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
            End Using
        End Function

        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                Dim userId As String = idlbl.Text.Trim()

                If oldpasswordtxt.Enabled Then
                    Dim selectQuery As String = "SELECT password FROM account WHERE ID = @id"
                    Dim existingPwd As String = ""

                    Using cmdSelect As New MySqlCommand(selectQuery, conn)
                        cmdSelect.Parameters.AddWithValue("@id", userId)
                        Dim result = cmdSelect.ExecuteScalar()
                        If result IsNot Nothing Then existingPwd = result.ToString()
                    End Using

                    Dim enteredOldPwd As String = oldpasswordtxt.Text
                    Dim enteredOldHash As String = HashPassword(enteredOldPwd)

                    If enteredOldPwd <> existingPwd AndAlso enteredOldHash <> existingPwd Then
                        MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    Dim newHash As String = HashPassword(newpasswordtxt.Text)
                    Dim updateQuery As String = "UPDATE account SET password=@pwd, passkey='' WHERE ID=@id"

                    Using cmdUpdate As New MySqlCommand(updateQuery, conn)
                        cmdUpdate.Parameters.AddWithValue("@pwd", newHash)
                        cmdUpdate.Parameters.AddWithValue("@id", userId)
                        cmdUpdate.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    Exit Sub
                End If

                If Not oldpasswordtxt.Enabled Then
                    Dim newHash As String = HashPassword(newpasswordtxt.Text)
                    Dim updateQuery As String = "UPDATE account SET password=@pwd, passkey='' WHERE ID=@id"

                    Using cmdUpdate As New MySqlCommand(updateQuery, conn)
                        cmdUpdate.Parameters.AddWithValue("@pwd", newHash)
                        cmdUpdate.Parameters.AddWithValue("@id", userId)
                        cmdUpdate.ExecuteNonQuery()
                    End Using

                    Form1.Show()
                    MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Close()
    End Sub

    Private Sub showoldpasswordpb_MouseDown(sender As Object, e As MouseEventArgs) Handles showoldpasswordpb.MouseDown
        oldpasswordtxt.UseSystemPasswordChar = False
        showoldpasswordpb.Image = My.Resources.eyevisible

    End Sub

    Private Sub showoldpasswordpb_MouseUp(sender As Object, e As MouseEventArgs) Handles showoldpasswordpb.MouseUp
        oldpasswordtxt.UseSystemPasswordChar = True
        showoldpasswordpb.Image = My.Resources.eyehidden
    End Sub

    Private Sub showoldpasswordpb_MouseLeave(sender As Object, e As EventArgs) Handles showoldpasswordpb.MouseLeave
        oldpasswordtxt.UseSystemPasswordChar = True
        showoldpasswordpb.Image = My.Resources.eyehidden
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        newpasswordtxt.UseSystemPasswordChar = False
        PictureBox1.Image = My.Resources.eyevisible
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        newpasswordtxt.UseSystemPasswordChar = True
        PictureBox1.Image = My.Resources.eyehidden
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        newpasswordtxt.UseSystemPasswordChar = True
        PictureBox1.Image = My.Resources.eyehidden
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        confirmpasswordtxt.UseSystemPasswordChar = False
        PictureBox2.Image = My.Resources.eyevisible
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        confirmpasswordtxt.UseSystemPasswordChar = True
        PictureBox2.Image = My.Resources.eyehidden
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        confirmpasswordtxt.UseSystemPasswordChar = True
        PictureBox2.Image = My.Resources.eyehidden
    End Sub

End Class