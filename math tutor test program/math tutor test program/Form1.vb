Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        lblAnswer.Text = "101"
    End Sub
End Class
