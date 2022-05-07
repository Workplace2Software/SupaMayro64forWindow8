Public Class SteveHittingUUp

    Private Sub SteveHittingUUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Process.Start("https://gamaverse.com/parkour-block-2-game/")
        Me.Close()
    End Sub

    Private Sub SteveHittingUUp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub SteveHittingUUp_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.Minceraft, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub SteveHittingUUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Minceraft, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub SteveHittingUUp_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        My.Computer.Audio.Play(My.Resources.Minceraft, AudioPlayMode.BackgroundLoop)
    End Sub
End Class