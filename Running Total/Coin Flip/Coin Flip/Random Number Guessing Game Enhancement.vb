Public Class Random_Number_Guessing_Game_Enhancement

    Dim Counter As Integer
    Dim CG As Integer
    Dim intWins As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Dim Number As New Random
        CG = Number.Next(100) + 1
        Counter = 0
        TextBox1.Text = ("")
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim UG As Integer
        UG = CInt(TextBox1.Text)
        Counter = Counter + 1
        Try
            If UG = CG Then
                MessageBox.Show("You guessed my Number!")
                intWins = 1 + intWins
            ElseIf UG < CG Then
                MessageBox.Show("Your guess is too low")
            ElseIf UG > CG Then
                MessageBox.Show("Your guess is too high.")
            End If
            lblWins.Text = intWins.ToString("n")
        Catch E1 As InvalidCastException
            MessageBox.Show("Please enter a number and try agian")
        End Try

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim R As DialogResult
        R = MessageBox.Show("Are you sure you want to quit?", "Game Quit", MessageBoxButtons.YesNo)
        If R = Windows.Forms.DialogResult.No Then
            btnNewGame.PerformClick()
        ElseIf R = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class