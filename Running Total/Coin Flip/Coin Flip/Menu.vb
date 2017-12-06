Public Class Menu

    Private Sub btnRock_Click(sender As Object, e As EventArgs) Handles btnRock.Click
        Dim Box = New RockPaperScissors()
        Box.Show()
    End Sub

    Private Sub btnSumofNumbers_Click(sender As Object, e As EventArgs) Handles btnSumofNumbers.Click
        Dim Box = New SumOfNumbers()
        Box.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Box = New LightOnLightOff
        Box.Show()
    End Sub

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim Box = New RaceingForm
        Box.Show()
    End Sub

    Private Sub btnCoinToss_Click(sender As Object, e As EventArgs) Handles btnCoinToss.Click
    End Sub
End Class