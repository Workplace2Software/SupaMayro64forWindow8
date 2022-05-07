Public Class Form1
    Dim r As New Random

    Private Sub Form1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        SteveHittingUUp.ShowDialog()
    End Sub

    Private Sub Form1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        If r.Next(1, 10) = 7 Then
            LiteNotice.ShowDialog()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        If r.Next(1, 10) = 4 Then
            NinjaMovieMaker.ShowDialog()
        End If
    End Sub
End Class
