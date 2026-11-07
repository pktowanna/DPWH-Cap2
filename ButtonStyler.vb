
Imports System.Drawing.Drawing2D

Module ButtonStyler
    Public Sub ApplyRoundedStyleToAllButtons(parent As Control, Optional cornerRadius As Integer = 5)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)

                btn.Region = New Region(GetRoundedRect(btn.ClientRectangle, cornerRadius))

                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
            End If

            If ctrl.HasChildren Then
                ApplyRoundedStyleToAllButtons(ctrl, cornerRadius)
            End If
        Next
    End Sub

    Private Function GetRoundedRect(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim diameter = radius * 2

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()

        Return path
    End Function
End Module
