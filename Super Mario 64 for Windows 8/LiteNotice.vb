Public Class LiteNotice

    Private Sub LiteNotice_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        DidntPay.ShowDialog()
    End Sub

    Private Sub LiteNotice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.trial, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub LiteNotice_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        My.Computer.Audio.Play(My.Resources.trial, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub LiteNotice_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.trial, AudioPlayMode.BackgroundLoop)
    End Sub
End Class