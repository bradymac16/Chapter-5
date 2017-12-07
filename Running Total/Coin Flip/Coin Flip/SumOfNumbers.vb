Public Class SumOfNumbers

    Private Sub btnEnterNumbers_Click(sender As Object, e As EventArgs) Handles btnEnterNumbers.Click
        Dim StrInput As String
        Dim IntCount As Integer = 0
        Dim intInput As Integer
        Dim IntNumScore As Integer

        StrInput = InputBox("Enter a positive integer value", "Input Needed", 10)

        If Integer.TryParse(StrInput, intInput) Then
            If intInput < 0 Then
                MessageBox.Show("Please Input postive number.")
            Else
                Do Until IntCount = intInput
                    StrInput += 1
                    IntNumScore += IntCount
                Loop
                MessageBox.Show("The sum of the numbers 1 through " & intInput & "is" & IntNumScore)
            End If
        Else
            MessageBox.Show("Please input a valid number.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class