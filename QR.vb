Imports System.Drawing.Printing
Public Class QR

    Private WithEvents printDoc As New PrintDocument()

    Private Sub printqrbtn_Click(sender As Object, e As EventArgs) Handles printqrbtn.Click
        Try
            Dim pd As New PrintDialog()
            pd.Document = printDoc

            If pd.ShowDialog() = DialogResult.OK Then
                printDoc.Print()
            End If
        Catch ex As Exception
            MessageBox.Show("Error printing QR: " & ex.Message)
        End Try
    End Sub

    Private Sub printDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        Try

            If qrpic.Image IsNot Nothing Then
                Dim img As Image = qrpic.Image
                Dim x As Integer = (e.PageBounds.Width - img.Width) \ 2
                Dim y As Integer = (e.PageBounds.Height - img.Height) \ 2
                e.Graphics.DrawImage(img, x, y, img.Width, img.Height)
            End If
        Catch ex As Exception
            MessageBox.Show("Error rendering print page: " & ex.Message)
        End Try
    End Sub
    Private Sub qrsavebtn_Click(sender As Object, e As EventArgs) Handles qrsavebtn.Click

        If qrpic.Image Is Nothing Then
            MessageBox.Show("No QR code to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim defaultFileName As String = If(String.IsNullOrWhiteSpace(qrlabellbl.Text), "QRCode", qrlabellbl.Text)

        Using sfd As New SaveFileDialog()
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp"
            sfd.FileName = defaultFileName & ".png"
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Dim ext As String = System.IO.Path.GetExtension(sfd.FileName).ToLower()
                    Dim format As Imaging.ImageFormat = Imaging.ImageFormat.Png
                    If ext = ".jpg" OrElse ext = ".jpeg" Then
                        format = Imaging.ImageFormat.Jpeg
                    ElseIf ext = ".bmp" Then
                        format = Imaging.ImageFormat.Bmp
                    End If

                    qrpic.Image.Save(sfd.FileName, format)

                    MessageBox.Show("QR Code saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    qrlabellbl.Text = ""
                    qrpic.Image = Nothing

                    Me.Close()

                Catch ex As Exception
                    MessageBox.Show("Error saving image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub qrexitbtn_Click(sender As Object, e As EventArgs) Handles qrexitbtn.Click
        Me.Close()
    End Sub

    Private Sub QR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class