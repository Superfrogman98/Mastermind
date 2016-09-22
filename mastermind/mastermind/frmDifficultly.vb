Public Class frmDifficultly
    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        frmMastermind.boolDifficult = False
        Me.Close()
    End Sub

    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        frmMastermind.boolDifficult = True
        Me.Close()
    End Sub
End Class