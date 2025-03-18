Public Class Splash_screen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timerprogressbar.Tick
        Progrsbar.Width += 20
        If Progrsbar.Width >= 799 Then
            Timerprogressbar.Stop()
            Me.Hide()
            Dim log = New login
            log.Show()
            Timerprogressbar.Enabled = False
        End If
    End Sub
End Class
