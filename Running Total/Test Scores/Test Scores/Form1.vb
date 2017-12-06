Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGetScores_Click(sender As Object, e As EventArgs) Handles btnGetScores.Click
        'This procedure gets the test scores, then calculates and displays the average.
        Dim intNumScores As Integer = 5   ' The number of test scores 
        Dim dblTestScore As Double        ' To hold a test score 
        Dim dblTotal As Double = 0        ' Accumulator, initilized to 0
        Dim dblAverage As Double          ' The average of the test scores
        Dim strInput As String            ' To hold user input
        Dim intCount As Integer = 1       ' Counter variable, initilized to 1

        ' Prompt the user for the number of test scores. 
        strInput = InputBox(" How many test scoresdo you want to average?")

        'Convert the input to an integer.
        If Integer.TryParse(strInput, intNumScores) Then

            'Get the test scores.
            Do Until intCount > intNumScores
                ' Propmt the user for a score.
                strInput = InputBox("Enter test score" & intCount.ToString())

                'Convert the input to a double.
                If Double.TryParse(strInput, dblTestScore) Then

                    ' Add the score to the accumulator.
                    dblTotal += dblTestScore

                    ' Add 1 to the counter.
                    intCount += 1
                Else
                    'Invalid test score.
                    MessageBox.Show(" Enter a numeric test score.")
                End If
            Loop

            'Calculate and display the average.
            If intNumScores > 0 Then
                dblAverage = dblTotal / intNumScores
                lblResult.Text = dblAverage.ToString()
            End If

        Else

        End If
    End Sub
End Class
