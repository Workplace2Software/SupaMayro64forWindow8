Public Class DidntPay
    Dim clicked As Boolean = False

    Private Sub DidntPay_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If clicked = False Then
            e.Cancel = True
            My.Computer.Audio.Play(My.Resources.fkyou, AudioPlayMode.Background)
        Else
            My.Computer.Audio.Play(My.Resources.WindowBroken, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub DidntPay_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.fkyou, AudioPlayMode.Background)
        clicked = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clicked = True
        Me.Close()
    End Sub

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        My.Computer.Audio.Play(My.Resources.PISSEDGuy, AudioPlayMode.WaitToComplete)
    End Sub
End Class