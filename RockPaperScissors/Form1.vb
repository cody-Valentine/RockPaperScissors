Public Class Form1

    Dim rock As Integer = 1
    Dim paper As Integer = 2
    Dim scissors As Integer = 3
    Dim player As Integer = 0 'player hand
    Dim com As Integer = 0  'com hand
    Dim scorePlayer As Integer = 0 'player score
    Dim scoreCom As Integer = 0 'com score
    Dim round As Integer = 1 'rounds played
    Dim tie As Integer = 0  'games tied
    Dim rand As New Random

    'sets blank hand and game to 1 on load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtWin.Text = 0
        txtLoss.Text = 0
        txtTie.Text = 0
        txtGame.Text = 1
    End Sub

    'update scores
    Private Sub update()
        txtWin.Text = scorePlayer
        txtLoss.Text = scoreCom
        reset()
    End Sub


    'resets button color and selected hand
    Private Sub reset()
        btnPaper.BackColor = DefaultBackColor
        btnRock.BackColor = DefaultBackColor
        btnScissors.BackColor = DefaultBackColor
        lblChecking.Visible = False
        player = 0
        com = 0
    End Sub

    'select rock
    Private Sub btnRock_Click(sender As Object, e As EventArgs) Handles btnRock.Click
        reset()
        player = 1
        btnRock.BackColor = Color.Peru
        lblChecking.Visible = True
        lblChecking.Text = "You: Rock"
    End Sub

    'select paper
    Private Sub btnPaper_Click(sender As Object, e As EventArgs) Handles btnPaper.Click, btnPaper.Click
        reset()
        player = 2
        btnPaper.BackColor = Color.Peru
        lblChecking.Visible = True
        lblChecking.Text = "You: Paper"
    End Sub

    'select Scissors
    Private Sub bntScissors_Click(sender As Object, e As EventArgs) Handles btnScissors.Click
        reset()
        player = 3
        btnScissors.BackColor = Color.Peru
        lblChecking.Visible = True
        lblChecking.Text = "You: Scissors"
    End Sub

    'Random computer hand
    Private Sub comHand()
        com = rand.Next(1, 4)
        If com = 1 Then
            lblChecking.Text += " / Com: Rock"
        End If
        If com = 2 Then
            lblChecking.Text += " / Com: Paper"
        End If
        If com = 3 Then
            lblChecking.Text += " / Com: Scissors"
        End If
    End Sub

    'plays the hand
    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles btnShoot.Click
        'Force player to select a button
        If player = 0 Then
            MessageBox.Show("Please pick 'Rock', 'Paper', or 'Scissors'")
            Return
        End If

        round += 1
        txtGame.Text = round.ToString

        comHand()

        'compare hands
        If player = 1 And com = 3 Or
            player = 2 And com = 1 Or
            player = 3 And com = 2 Then
            MessageBox.Show("You win")
            scorePlayer += 1
            txtWin.Text = scorePlayer.ToString
            reset()
            Return
        ElseIf player = 1 And com = 1 Or
                player = 2 And com = 2 Or
                player = 3 And com = 3 Then
            MessageBox.Show("You tied")
            tie += 1
            txtTie.Text = tie.ToString
            reset()
            Return
        Else
            MessageBox.Show("You Lost")
            scoreCom += 1
            txtLoss.Text = scoreCom.ToString
            reset()
            Return
        End If

        update()
    End Sub
End Class