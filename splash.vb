Public Class splashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Timer1.Stop()
            Me.Hide()
            LogIn.Show()
        Else
            ProgressBar1.PerformStep()
            lblPercent.Text = ProgressBar1.Value & ("%")
        End If
    End Sub
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub lblPercent_Click(sender As Object, e As EventArgs) Handles lblPercent.Click

    End Sub
End Class
