Public Class frmMastermind
    'programmer: Max Buckel
    'Date: 2016-9-19
    'function: program for a game of mastermind


    'global variable
    Public selectedColor As Color 'public and global so that the selection form can access
    Dim objColorform As New frmSelectColor 'adds the selection form as and object so it can be shown
    Dim objDifficultlyForm As New frmDifficultly
    Dim intCurrentPlay As Integer = 0   'the current play, used to step the row
    Public arrColors() As String = {"Yellow", "Green", "Blue", "Aqua", "Red", "Silver"} 'holds the colors that can be used for the key
    Public arrSelectedColors(3) As String
    Dim arrKey(arrColors.Length - 1) As String  'creates  a key thats the same length as colors
    Dim intWins = 0 'holds the wins and losses
    Dim intLoses = 0
    Public boolDifficult As Boolean = False


    'close the program
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    'handles a cell click
    Private Sub dgvPlayer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlayer.CellClick
        'location of color window
        Dim intColorLocationY As Integer = Me.Location.Y + (58 + (intCurrentPlay + 1) * 60)
        Dim intColorLocationX As Integer = Me.Location.X + (22 + e.ColumnIndex * 60)
        Dim pntColor As New Point(intColorLocationX, intColorLocationY)


        selectedColor = Color.White
        dgvPlayer.Rows(intCurrentPlay).Cells(e.ColumnIndex).Style.SelectionBackColor = Color.SteelBlue
        frmSelectColor.Location = pntColor
        frmSelectColor.ShowDialog()
        dgvPlayer.Rows(intCurrentPlay).Cells(e.ColumnIndex).Style.BackColor = selectedColor
        dgvPlayer.Rows(intCurrentPlay).Cells(e.ColumnIndex).Style.SelectionBackColor = selectedColor
        arrSelectedColors(e.ColumnIndex) = dgvPlayer.Rows(intCurrentPlay).Cells(e.ColumnIndex).Style.BackColor.Name

    End Sub

    'checks the current play against the key
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'declare variables
        Dim intPerfect As Integer = 0
        Dim intColor As Integer = 0
        Dim strCurrentColor As String
        Dim arrCurrentRow(3) As String
        Dim current As Label
        'location of the button
        Dim intCheckLocation = btnCheck.Location.Y
        Dim pntCheck As New Point(btnCheck.Location.X, intCheckLocation)

        If intCurrentPlay < 9 Then
            'validates for 4 colors and creates an array from the current row
            For intI = 0 To 3
                If dgvPlayer.Rows(intCurrentPlay).Cells(intI).Style.BackColor.Name = "0" Or dgvPlayer.Rows(intCurrentPlay).Cells(intI).Style.BackColor.Name = "White" Then
                    MessageBox.Show("4 colors Not selected", "Invalid Input")
                    Exit Sub
                Else
                    arrCurrentRow(intI) = dgvPlayer.Rows(intCurrentPlay).Cells(intI).Style.BackColor.Name
                    arrSelectedColors(intI) = ""
                End If
            Next

            For intI = 0 To 3
                strCurrentColor = dgvPlayer.Rows(intCurrentPlay).Cells(intI).Style.BackColor.Name
                'if the current matches the keys current then adds to perfect
                If strCurrentColor = arrKey(intI) Then
                    intPerfect += 1
                    'if the key has a color match in the current row, then adds to the color match
                ElseIf Array.IndexOf(arrCurrentRow, arrKey(intI)) > -1 Then
                    intColor += 1
                End If
            Next

            'displays the number of perfect and color matches
            If intPerfect > 0 Then
                For intI = 0 To intPerfect - 1
                    current = Me.Controls("lblPerfect" & intCurrentPlay)
                    current.Text += "o"
                Next
            End If

            If intColor > 0 Then
                For intI = 0 To intColor - 1
                    current = Me.Controls("lblColor" & intCurrentPlay)
                    current.Text += "o"
                Next
            End If


            intCurrentPlay += 1 'increase down here so that the boxes can be checked, but so that the lose condition can also check propery

            'check if the player wins, loses, or what to display on the labels
            If intPerfect = 4 Then
                MessageBox.Show("Congratulations, you wil", "Win Message")
                btnCheck.Enabled = False
                intWins += 1
                lblWins.Text = "Wins: " & intWins
            Else
                If intCurrentPlay = 9 Then
                    MessageBox.Show("You lose", "Lose Message")
                    btnCheck.Enabled = False
                    intLoses += 1
                    lblLoses.Text = "Loses: " & intLoses
                    pntCheck.Y += 160
                End If
            End If

            'moves the check button down

            pntCheck.Y += 60
            btnCheck.Location = pntCheck
        End If
    End Sub


    'randomizes an arrays order
    Private Sub RandomizeArray(ByVal items() As String)
        Dim max_index As Integer = items.Length - 1
        Dim rnd As New Random
        For intI As Integer = 0 To max_index - 1
            ' Pick an item for position i.
            Dim strPlace As String = rnd.Next(intI, max_index + 1)

            ' Swap them.
            Dim strTemp As String = items(intI)
            items(intI) = items(strPlace)
            items(strPlace) = strTemp
        Next intI
    End Sub


    'creates a key array
    Private Sub create_key(difficulty)
        ReDim arrKey(arrColors.Length - 1)

        If boolDifficult = False Then
            For intI = 0 To arrColors.Length - 1
                arrKey(intI) = arrColors(intI)
            Next
            RandomizeArray(arrKey)
        Else
            Dim rnd As New Random
            For intI As Integer = 0 To arrKey.Length - 1
                Dim randomColor As String = rnd.Next(0, arrColors.Length)
                arrKey(intI) = arrColors(randomColor)
            Next

        End If

    End Sub


    'handles the main for loading, sets the row amount, the height, and creates a key
    Private Sub frmMastermind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmDifficultly.ShowDialog()
        create_key(boolDifficult)
        ReDim Preserve arrKey(3)
        dgvPlayer.RowCount = 9
        For intI = 0 To 9 Step 1
            dgvPlayer.Rows(intI).Height = 60
        Next
    End Sub

    'reset the game
    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        frmDifficultly.ShowDialog()
        'holds a label for the hint rows
        Dim current As Label
        'creates a new key
        create_key(boolDifficult)
        ReDim Preserve arrKey(3)
        intCurrentPlay = 0

        'moves the check button back to top
        Dim intCheckLocation = btnCheck.Location.Y
        Dim pntCheck As New Point(btnCheck.Location.X, intCheckLocation)
        pntCheck.Y = 27
        btnCheck.Location = pntCheck
        btnCheck.Enabled = True
        'clears the row colors and hints
        For intI = 0 To 8 Step 1
            For intX = 0 To 3 Step 1
                dgvPlayer.Rows(intI).Cells(intX).Style.BackColor = Color.White
                dgvPlayer.Rows(intI).Cells(intX).Style.SelectionBackColor = Color.White
            Next
            current = Me.Controls("lblPerfect" & intI)
            current.Text = ""
            current = Me.Controls("lblColor" & intI)
            current.Text = ""
        Next
    End Sub


End Class
