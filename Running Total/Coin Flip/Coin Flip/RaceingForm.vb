Public Class RaceingForm
    Dim intCubsCount As Integer
    Dim intIndiansCount As Integer
    Dim intNationalsCount As Integer
    Dim intAstrosCount As Integer

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim intCount1, intCOunt2, intCount3, intCount4 As Integer
        Dim rand As New Random


        Dim intScore As Integer = 1
        Dim intYouwin As Integer = 10

        For intCount1 = 60 To rand.Next(250) + 500
            picRacer1.Left = intCount1
        Next
        For intCOunt2 = 60 To rand.Next(250) + 500
            PicRacer2.Left = intCOunt2
        Next
        For intCount3 = 60 To rand.Next(250) + 500
            PicRacer3.Left = intCount3
        Next
        For intCount4 = 60 To rand.Next(250) + 500
            PicRacer4.Left = intCount4
        Next
        If intCount1 > intCOunt2 And intCount3 And intCount4 Then
            intCubsCount += 1
        ElseIf intCOunt2 > intCount1 And intCount3 and intCount4 Then
            intIndiansCount += 1
        ElseIf intCount3 > intCount1 And intCOunt2 And intCount4 Then
            intNationalsCount += 1
        ElseIf intCount4 > intCount1 And intCOunt2 And intCount3 Then
            intAstrosCount += 1
        End If
        lblAstrosCount.Text = intAstrosCount.ToString
        lblCubsCount.Text = intCubsCount.ToString
        lblIndiansCount.Text = intIndiansCount.ToString
        lblNationalsCount.Text = intNationalsCount.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class