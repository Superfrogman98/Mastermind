Public Class frmSelectColor
    Private Sub btnYellow_Click(sender As Object, e As EventArgs) Handles btnYellow.Click
        frmMastermind.selectedColor = Color.Yellow
        Me.Close()

    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        frmMastermind.selectedColor = Color.Green
        Me.Close()
    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        frmMastermind.selectedColor = Color.Blue
        Me.Close()
    End Sub

    Private Sub btnAqua_Click(sender As Object, e As EventArgs) Handles btnAqua.Click
        frmMastermind.selectedColor = Color.Aqua
        Me.Close()
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        frmMastermind.selectedColor = Color.Red
        Me.Close()
    End Sub

    Private Sub btnSilver_Click(sender As Object, e As EventArgs) Handles btnSilver.Click
        frmMastermind.selectedColor = Color.Silver
        Me.Close()
    End Sub

    'makes it so the user can only select one of a color in their guess
    Private Sub frmSelectColor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'makes all buttons enabled
        Dim btnCurrent As Button
        For intI = 0 To frmMastermind.arrColors.Length - 1
            If frmMastermind.arrColors(intI) <> "" Then
                btnCurrent = Me.Controls("btn" & frmMastermind.arrColors(intI))
                btnCurrent.Enabled = True
            End If

        Next
        'in normal will disable the already selected colors
        If frmMastermind.boolDifficult = False Then
            For intI = 0 To frmMastermind.arrSelectedColors.Length - 1
                If frmMastermind.arrSelectedColors(intI) <> "" Then
                    btnCurrent = Me.Controls("btn" & frmMastermind.arrSelectedColors(intI))
                    btnCurrent.Enabled = False
                End If

            Next
        End If
    End Sub
End Class