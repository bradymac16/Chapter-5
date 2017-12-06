Public Class Distance_Calculator

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decDistanceTravelled As Decimal
        Dim decNumberofHoursInput As Decimal
        Dim decMPHSpeedInput As Decimal
        Dim intCounter As Integer = 1
        Dim decTotalDistance As Decimal = 0
        Dim blnFlag As Boolean
        Try
            For intCounter = 1 To decNumberofHoursInput
                decMPHSpeedInput = InputBox("Please enter your average rate speed in MPH", "Speed")
                decNumberofHoursInput = InputBox("Please enter the number of hours you spent", "Hours")
                If IsNumeric(decMPHSpeedInput) Or decNumberofHoursInput < 0 Then
                    MessageBox.Show("Please enter a number greater than zero.")

                Else
                    'Calculation       
                    decDistanceTravelled = decNumberofHoursInput * decMPHSpeedInput
                    'Listbox
                    blnFlag = True

                    lstOutput.Items.Add("Vehicle Speed:" & decMPHSpeedInput.ToString & "MPH" & "Time Travelled:" & ControlChars.CrLf _
        & decNumberofHoursInput.ToString & "hours" & ControlChars.CrLf & "Hours" & "Distance Travelled" & ControlChars.CrLf _
        & "******************************************")
                    Do While decNumberofHoursInput > 1
                        decNumberofHoursInput = decNumberofHoursInput - 1
                    Loop
                    Do While blnFlag = True
                        lstOutput.Items.Add(decNumberofHoursInput.ToString)
                        blnFlag = False
                    Loop
                End If
                'If IsNumeric(decNumberofHoursInput) And IsNumeric(decMPHSpeedInput) Then
                '    If decNumberofHoursInput < 0 Then
                '        MessageBox.Show("Please enter a number greater than zero.")
                '    Else
                '        decDistanceTravelled = decNumberofHoursInput * decMPHSpeedInput

                '    End If
                'End If
                'Output
                If intCounter = decNumberofHoursInput Then
                    lstOutput.Items.Add("Total Distance: " & decTotalDistance.ToString)
                End If
            Next
        Catch ex As Exception
        End Try

    End Sub

    Private Sub lstOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOutput.SelectedIndexChanged

    End Sub
End Class