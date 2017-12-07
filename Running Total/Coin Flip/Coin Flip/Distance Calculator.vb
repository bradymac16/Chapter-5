Public Class Distance_Calculator
    Dim intSpeed As Integer
    Dim strSpeed As String

    'Time in hours
    Dim intTime As Integer
    Dim strTime As String

    'distance
    Dim intTotal As Integer
    Dim strDistance As String
    'user input
    Dim strInput As String
    Dim intCount As Integer = 1
    Sub mathCalc()
        intTotal = intSpeed * intCount

        'create a string to display the distance
        strDistance = intCount.ToString() & "             " & intTotal.ToString()

        'add the string to the list box
        lstCalculations.Items.Add(strDistance)

        'add 1 to the counter
        intCount += 1
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        strInput = InputBox("What is the speed in miles-per-hour?", "Enter Speed")
        'Convert the input to a decimal
        If Decimal.TryParse(strInput, intSpeed) Then

            'prompt the user to enter hours
            strInput = InputBox("What is the amount of time in hours?" & intCount.ToString(), "Enter Time")

            'Convert the input to a decimal
            If Decimal.TryParse(strInput, intTime) Then

                'create a string to display the speed and time
                strSpeed = "Vehicle Speed: " & intSpeed.ToString() & " MPH"
                strTime = "Time Traveled: " & intTime.ToString() & " hours"

                'insert speed and time to list box
                lstCalculations.Items.Insert(0, strSpeed)
                lstCalculations.Items.Insert(1, strTime)

                'create a heading
                lstCalculations.Items.Insert(2, "Hours" & "     " & "Distance Traveled")

                'insert a line
                lstCalculations.Items.Insert(3, "______________________")



                'Calculate the distance
                Do Until intCount > intTime
                    mathCalc()
                Loop

                'add total distance
                lstCalculations.Items.Add("Total Distance: " & intSpeed * intTime)

            End If

        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class