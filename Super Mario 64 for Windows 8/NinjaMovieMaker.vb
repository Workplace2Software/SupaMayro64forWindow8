Public Class NinjaMovieMaker

    Private Sub NinjaMovieMaker_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub NinjaMovieMaker_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.NinjaMovieMaker, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        Process.Start("https://www.ninjamaker.com")
        My.Computer.Audio.Play(My.Resources.WelcomeToNinjaMovieMaker, AudioPlayMode.WaitToComplete)
        Me.Close()
    End Sub
End Class