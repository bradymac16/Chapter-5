Public Class RockPaperScissors
    Dim PlayerCount1 As Integer = 0
    Dim compCount As Integer = 0
    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles shootbutton.Click
        Randomize()

        Dim Num As Integer
        Const Rock = 1
        Const Paper = 2
        Const Scissors = 3

        Num = CInt((3 * Rnd()))

        If RockRadioButton.Checked And Num = Rock Then
            ResultLabel.Text = "Computer chose Rock too. Tie!"
        ElseIf RockRadioButton.Checked And Num = Paper Then
            ResultLabel.Text = "Computer chose paper. You Lose!"
            compCount += 1
        ElseIf RockRadioButton.Checked And Num = Scissors Then
            ResultLabel.Text = "Computer threw scissors. You Win!"
            PlayerCount1 += 1

        ElseIf paperRadioButton.Checked And Num = Rock Then
            ResultLabel.Text = "Computer chose Rock. You Win!"
            PlayerCount1 += 1
        ElseIf paperRadioButton.Checked And Num = Paper Then
            ResultLabel.Text = "Computer chose paper too. Tie!"
        ElseIf paperRadioButton.Checked And Num = Scissors Then
            ResultLabel.Text = "Computer threw scissors. You Lose!"
            compCount += 1

        ElseIf ScissorsRadioButton.Checked And Num = Rock Then
            ResultLabel.Text = "Computer chose Rock. You Lose!"
            compCount += 1
        ElseIf ScissorsRadioButton.Checked And Num = Paper Then
            ResultLabel.Text = "Computer chose paper. You Win!"
            PlayerCount1 += 1
        ElseIf ScissorsRadioButton.Checked And Num = Scissors Then
            ResultLabel.Text = "Computer chose scissors too. Tie!"
        End If
        lblPlayerCount.Text = PlayerCount1
        lblcompCount.Text = compCount
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class