Public Class LightOnLightOff
    Dim lightTrunOn As Integer 'Global Class Variable Counter
    Private Sub btnLightSwitch_Click(sender As Object, e As EventArgs) Handles btnLightSwitch.Click
        Dim intLightOn As Integer
        Dim rand As New Random

        intLightOn = rand.Next(2)

        If intLightOn = 0 Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            lightTrunOn = lightTrunOn + 1
        Else
            PictureBox1.Visible = False
            PictureBox2.Visible = True
        End If
        lblResult.Text = lightTrunOn
    End Sub

    Private Sub LightOnLightOff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class