Public Class Population_Calculator

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Declare variables for calculation
        Dim intCount As Integer
        Dim dblTotal As Double

        'Calculate population, and display output
        lstOutput.Items.Add("Day Approximate Population")
        lstOutput.Items.Add("-----------------------------------")
        dblTotal = 2
        intCount = 1


        lstOutput.Items.Add(intCount.ToString + " " + dblTotal.ToString)

        For intCount = intCount + 1 To cboDays.Text
            dblTotal = (CDbl(txtIncreasePct.Text * dblTotal) / 100) + dblTotal
            lstOutput.Items.Add(intCount.ToString + " " + dblTotal.ToString)
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class