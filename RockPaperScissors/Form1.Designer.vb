<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.txtWin = New System.Windows.Forms.TextBox()
        Me.lblLoss = New System.Windows.Forms.Label()
        Me.lblTie = New System.Windows.Forms.Label()
        Me.lblGame = New System.Windows.Forms.Label()
        Me.lblChecking = New System.Windows.Forms.Label()
        Me.txtLoss = New System.Windows.Forms.TextBox()
        Me.txtTie = New System.Windows.Forms.TextBox()
        Me.txtGame = New System.Windows.Forms.TextBox()
        Me.btnPaper = New System.Windows.Forms.Button()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.btnScissors = New System.Windows.Forms.Button()
        Me.btnShoot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.Location = New System.Drawing.Point(76, 28)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(32, 13)
        Me.lblWins.TabIndex = 0
        Me.lblWins.Text = "Win: "
        '
        'txtWin
        '
        Me.txtWin.Enabled = False
        Me.txtWin.Location = New System.Drawing.Point(114, 25)
        Me.txtWin.Name = "txtWin"
        Me.txtWin.Size = New System.Drawing.Size(100, 20)
        Me.txtWin.TabIndex = 1
        '
        'lblLoss
        '
        Me.lblLoss.AutoSize = True
        Me.lblLoss.Location = New System.Drawing.Point(73, 54)
        Me.lblLoss.Name = "lblLoss"
        Me.lblLoss.Size = New System.Drawing.Size(35, 13)
        Me.lblLoss.TabIndex = 2
        Me.lblLoss.Text = "Loss: "
        '
        'lblTie
        '
        Me.lblTie.AutoSize = True
        Me.lblTie.Location = New System.Drawing.Point(80, 80)
        Me.lblTie.Name = "lblTie"
        Me.lblTie.Size = New System.Drawing.Size(28, 13)
        Me.lblTie.TabIndex = 3
        Me.lblTie.Text = "Tie: "
        '
        'lblGame
        '
        Me.lblGame.AutoSize = True
        Me.lblGame.Location = New System.Drawing.Point(67, 106)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(41, 13)
        Me.lblGame.TabIndex = 5
        Me.lblGame.Text = "Game: "
        '
        'lblChecking
        '
        Me.lblChecking.AutoSize = True
        Me.lblChecking.Location = New System.Drawing.Point(59, 137)
        Me.lblChecking.Name = "lblChecking"
        Me.lblChecking.Size = New System.Drawing.Size(0, 13)
        Me.lblChecking.TabIndex = 6
        '
        'txtLoss
        '
        Me.txtLoss.Enabled = False
        Me.txtLoss.Location = New System.Drawing.Point(114, 51)
        Me.txtLoss.Name = "txtLoss"
        Me.txtLoss.Size = New System.Drawing.Size(100, 20)
        Me.txtLoss.TabIndex = 7
        '
        'txtTie
        '
        Me.txtTie.Enabled = False
        Me.txtTie.Location = New System.Drawing.Point(114, 77)
        Me.txtTie.Name = "txtTie"
        Me.txtTie.Size = New System.Drawing.Size(100, 20)
        Me.txtTie.TabIndex = 8
        '
        'txtGame
        '
        Me.txtGame.Enabled = False
        Me.txtGame.Location = New System.Drawing.Point(114, 103)
        Me.txtGame.Name = "txtGame"
        Me.txtGame.Size = New System.Drawing.Size(100, 20)
        Me.txtGame.TabIndex = 9
        '
        'btnPaper
        '
        Me.btnPaper.Location = New System.Drawing.Point(93, 171)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(75, 23)
        Me.btnPaper.TabIndex = 10
        Me.btnPaper.Text = "&Paper"
        Me.btnPaper.UseVisualStyleBackColor = True
        '
        'btnRock
        '
        Me.btnRock.Location = New System.Drawing.Point(12, 170)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(75, 23)
        Me.btnRock.TabIndex = 11
        Me.btnRock.Text = "&Rock"
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'btnScissors
        '
        Me.btnScissors.Location = New System.Drawing.Point(174, 170)
        Me.btnScissors.Name = "btnScissors"
        Me.btnScissors.Size = New System.Drawing.Size(75, 23)
        Me.btnScissors.TabIndex = 13
        Me.btnScissors.Text = "&Scissors"
        Me.btnScissors.UseVisualStyleBackColor = True
        '
        'btnShoot
        '
        Me.btnShoot.Location = New System.Drawing.Point(93, 200)
        Me.btnShoot.Name = "btnShoot"
        Me.btnShoot.Size = New System.Drawing.Size(75, 23)
        Me.btnShoot.TabIndex = 14
        Me.btnShoot.Text = "Shoot"
        Me.btnShoot.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 242)
        Me.Controls.Add(Me.btnShoot)
        Me.Controls.Add(Me.btnScissors)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.txtGame)
        Me.Controls.Add(Me.txtTie)
        Me.Controls.Add(Me.txtLoss)
        Me.Controls.Add(Me.lblChecking)
        Me.Controls.Add(Me.lblGame)
        Me.Controls.Add(Me.lblTie)
        Me.Controls.Add(Me.lblLoss)
        Me.Controls.Add(Me.txtWin)
        Me.Controls.Add(Me.lblWins)
        Me.Name = "Form1"
        Me.Text = "Rock Paper Scissors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWins As System.Windows.Forms.Label
    Friend WithEvents txtWin As System.Windows.Forms.TextBox
    Friend WithEvents lblLoss As System.Windows.Forms.Label
    Friend WithEvents lblTie As System.Windows.Forms.Label
    Friend WithEvents lblGame As System.Windows.Forms.Label
    Friend WithEvents lblChecking As System.Windows.Forms.Label
    Friend WithEvents txtLoss As System.Windows.Forms.TextBox
    Friend WithEvents txtTie As System.Windows.Forms.TextBox
    Friend WithEvents txtGame As System.Windows.Forms.TextBox
    Friend WithEvents btnPaper As System.Windows.Forms.Button
    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents btnScissors As System.Windows.Forms.Button
    Friend WithEvents btnShoot As System.Windows.Forms.Button

End Class
