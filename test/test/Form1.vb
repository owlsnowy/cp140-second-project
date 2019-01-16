Public Class Form1

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        lblCityStateZip.Visible = True
        lblName.Visible = True
        lblStreet.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
