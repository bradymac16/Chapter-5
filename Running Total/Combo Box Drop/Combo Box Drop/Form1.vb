Public Class Form1

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArtist.SelectedIndexChanged

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        txtCOuntry.Text = cboCountrys.Text
        txtPlay.Text = cboPlays.Text
        txtArtist.Text = cboArtist.Text
    End Sub
End Class
