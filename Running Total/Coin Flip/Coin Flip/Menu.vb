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

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDistanceCalculator.Click
        Dim Box = New Distance_Calculator
        Box.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Box = New Population_Calculator
        Box.Show()
    End Sub

    Private Sub btnRandomNumberGuessingGame_Click(sender As Object, e As EventArgs) Handles btnRandomNumberGuessingGame.Click
        Dim Box = New Random_Number_Guessing_Game_Enhancement
        Box.Show()
    End Sub
End Class