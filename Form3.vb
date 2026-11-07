Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActiveControl = qrentry
    End Sub
    Public Sub ScanQRUsingScanner()

        Dim targetTextBox As TextBox =
        CType(Dashboard.Controls.Find(txtbxlbl.Text, True)(0), TextBox)

        Dim targetButton As Button =
        CType(Dashboard.Controls.Find(btnbtn.Text, True)(0), Button)

        targetTextBox.Text = qrentry.Text
        targetButton.PerformClick()

        qrentry.Clear()
        Me.Close()
    End Sub
    Private Sub qrentry_Leave(sender As Object, e As EventArgs) Handles qrentry.Leave
        If Not TypeOf Me.ActiveControl Is Button Then
            Me.BeginInvoke(Sub() qrentry.Focus())
        End If
    End Sub
    Private Sub qrentry_KeyDown(sender As Object, e As KeyEventArgs) Handles qrentry.KeyDown
        If e.KeyCode = Keys.Enter Then

            ScanQRUsingScanner()
        End If
    End Sub
    Private Sub icscancelbtn_Click(sender As Object, e As EventArgs) Handles icscancelbtn.Click
        Me.Close()
    End Sub
End Class