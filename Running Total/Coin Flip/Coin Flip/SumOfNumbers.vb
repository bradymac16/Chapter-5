Public Class SumOfNumbers

    Private Sub btnEnterNumbers_Click(sender As Object, e As EventArgs) Handles btnEnterNumbers.Click
        Dim strUserInput
        Dim IntUserInput As Integer
        Dim intI As Integer
        Dim Total As Integer = 0
        strUserInput = InputBox("Enter a positive integer value", "Input Needed", 10)
        'If strUserInput < String.Empty Then
        '    Try
        '        IntUserInput = CInt(strUserInput)
        '        If IntUserInput < 0 Then
        '            MessageBox.Show("Negative numbers are not accepted.")
        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show("Quantity amount must be numeric.")
        '    End Try
        '    'Show messagebox, 
        'Else
        '    'IntUserInput = (IntUserInput + i)
        '    InputBox(MessageBox.Show("Sum of Numbers", "The sum of numbers" & (i + IntUserInput), MessageBoxButtons.OK))
        'End If
        
        lblResult.Text = Total = IntUserInput + 1
    End Sub
End Class