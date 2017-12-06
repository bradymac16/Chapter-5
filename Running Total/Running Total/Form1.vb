Public Class Form1

    Private Sub lbl_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Const intNUM_DAYS As Integer = 5  'The number of days
        Dim intCount As Integer = 1       ' Loop Counter
        Dim decSales As Decimal = 0       ' To hold daily sales
        Dim decTotal As Decimal = 0       ' to hold string input
        Dim strInput As String            ' To hold string input

        ' Get the sales for each day.
        Do While intCount <= intNUM_DAYS
            strInput = InputBox("Enter the sales for day " & intCount.ToString())
            If Decimal.TryParse(strInput, decSales) Then
                ' decTotal =+ decsales 'Shortcut version
                decTotal = decSales + decTotal
                ' intCount += 1 " Shortcut Version
                intCount = intCount + 1
            Else
                MessageBox.Show("Enter a numeric value")
            End If
        Loop
        lblResult.Text = decTotal.ToString("c")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
