Public Class Form1
    Sub calcSideC(ByVal Aside As Double, ByVal Bside As Double)
        Dim Cside As Double
        Cside = Math.Sqrt(Aside * Aside + Bside * Bside)
        txtSideC.Text = Cside.ToString
    End Sub
    Sub calcSideB(ByVal Aside As Double, ByVal Cside As Double)
        Dim Bside As Double
        Bside = Math.Sqrt(Cside * Cside - Aside * Aside)
        txtSideB.Text = Bside.ToString
    End Sub
     Sub calcSideA(ByVal Bside As Double, ByVal Cside As Double)
        Dim Aside As Double
        Aside = Math.Sqrt(Cside * Cside - Bside * Bside)
        txtSideA.Text = Aside.ToString
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Dim result As Double
        If radioC.Checked = True Then
            calcSideC(CDbl(txtSideA.Text), CDbl(txtSideB.Text))
        ElseIf radioB.Checked = True Then
            calcSideB(CDbl(txtSideA.Text), CDbl(txtSideC.Text))
        ElseIf radioA.Checked = True Then
            calcSideA(CDbl(txtSideB.Text), CDbl(txtSideC.Text))
        End If
    End Sub
End Class
