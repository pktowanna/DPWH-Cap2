Public Class movementlog

    Private Sub supplystockcardbackbtn_Click(sender As Object, e As EventArgs) Handles supplystockcardbackbtn.Click
        Me.Close()
    End Sub

    Private Sub movementlogdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles movementlogdgv.CellContentClick
        If e.RowIndex < 0 Then Return
        If movementlogdgv.Columns(e.ColumnIndex).Name <> "movementlogview" Then Return

        Dim docType As String = movementlogdgv.Rows(e.RowIndex).Cells("movementlogdocumenttype").Value?.ToString()
        Dim docId As String = movementlogdgv.Rows(e.RowIndex).Cells("movementlogid").Value?.ToString()

        If String.IsNullOrWhiteSpace(docType) OrElse String.IsNullOrWhiteSpace(docId) Then
            MessageBox.Show("Invalid document type or ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Select Case docType
            Case "Inventory Custodian Slip"
                Dashboard.PrintICS(documentId:=docId)

            Case "Property Acknowledgement Receipt"
                Dashboard.PrintPAR(documentId:=docId)

            Case "Property Return Slip"
                Dashboard.PrintPRS(documentId:=docId)

            Case "Receipt of Returned Semi-Expendable Property"
                Dashboard.PrintRRSP(documentId:=docId)

            Case Else
                MessageBox.Show("Unknown document type: " & docType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub

    Private Sub OpenQRFromMovementLog()
        Try
            Dim propNumber As String = movementlogpropertynumbertxt.Text.Trim()

            If String.IsNullOrWhiteSpace(propNumber) Then
                MessageBox.Show("Property number is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            QR.qrlabellbl.Text = propNumber

            Dim qrGen As New QRCoder.QRCodeGenerator()
            Dim qrData = qrGen.CreateQrCode(propNumber, QRCoder.QRCodeGenerator.ECCLevel.Q)
            Dim qrCode As New QRCoder.QRCode(qrData)
            Dim qrImage As Bitmap = qrCode.GetGraphic(20)

            QR.qrpic.Image = qrImage

            QR.Show()

        Catch ex As Exception
            MessageBox.Show("Failed to generate QR code: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub equQRbtn_Click(sender As Object, e As EventArgs) Handles equQRbtn.Click
        OpenQRFromMovementLog()
    End Sub

End Class