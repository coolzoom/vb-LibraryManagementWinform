Public Class Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If BunifuCircleProgressbar1.Value < 100 Then
            BunifuCircleProgressbar1.Value += 5
        ElseIf BunifuCircleProgressbar1.Value = 100 Then
            Timer1.Stop()
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class