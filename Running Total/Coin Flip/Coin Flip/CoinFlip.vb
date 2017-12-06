Public Class Form1
    Dim HeadsToal As Integer = 0
    Dim TailsToal As Integer = 0
    Private Sub btnToss_Click(sender As Object, e As EventArgs) Handles btnToss.Click
        Dim intsideup As Integer   ' To indicate which side is up
        Dim rand As New Random     ' Random number generator

        'Get a random number in the range of 0 through 1.
        '0 means tails up, and 1 means heads up.
        intsideup = rand.Next(2)

        ' Display the side that is up 
        If intsideup = 0 Then
            ' 0 means tails is up, so display the tails
            ' image and hide the heads immage
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            TailsToal = 1 + TailsToal
        Else
            ' 1 means heads is up, so display the heads
            ' image and hide the tails image.
            PictureBox2.Visible = True
            PictureBox1.Visible = False
            HeadsToal = 1 + HeadsToal
        End If
        lbltailstotal.Text = TailsToal.ToString("n")
        lblheadstotal.Text = HeadsToal.ToString("n")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
