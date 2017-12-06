<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RockPaperScissors
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
        Me.RockRadioButton = New System.Windows.Forms.RadioButton()
        Me.paperRadioButton = New System.Windows.Forms.RadioButton()
        Me.ScissorsRadioButton = New System.Windows.Forms.RadioButton()
        Me.shootbutton = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPlayerCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcompCount = New System.Windows.Forms.Label()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.PlayAgainButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RockRadioButton
        '
        Me.RockRadioButton.AutoSize = True
        Me.RockRadioButton.Location = New System.Drawing.Point(164, 50)
        Me.RockRadioButton.Name = "RockRadioButton"
        Me.RockRadioButton.Size = New System.Drawing.Size(51, 17)
        Me.RockRadioButton.TabIndex = 0
        Me.RockRadioButton.TabStop = True
        Me.RockRadioButton.Text = "Rock"
        Me.RockRadioButton.UseVisualStyleBackColor = True
        '
        'paperRadioButton
        '
        Me.paperRadioButton.AutoSize = True
        Me.paperRadioButton.Location = New System.Drawing.Point(164, 89)
        Me.paperRadioButton.Name = "paperRadioButton"
        Me.paperRadioButton.Size = New System.Drawing.Size(53, 17)
        Me.paperRadioButton.TabIndex = 1
        Me.paperRadioButton.TabStop = True
        Me.paperRadioButton.Text = "Paper"
        Me.paperRadioButton.UseVisualStyleBackColor = True
        '
        'ScissorsRadioButton
        '
        Me.ScissorsRadioButton.AutoSize = True
        Me.ScissorsRadioButton.Location = New System.Drawing.Point(164, 124)
        Me.ScissorsRadioButton.Name = "ScissorsRadioButton"
        Me.ScissorsRadioButton.Size = New System.Drawing.Size(64, 17)
        Me.ScissorsRadioButton.TabIndex = 2
        Me.ScissorsRadioButton.TabStop = True
        Me.ScissorsRadioButton.Text = "Scissors"
        Me.ScissorsRadioButton.UseVisualStyleBackColor = True
        '
        'shootbutton
        '
        Me.shootbutton.Location = New System.Drawing.Point(153, 264)
        Me.shootbutton.Name = "shootbutton"
        Me.shootbutton.Size = New System.Drawing.Size(75, 23)
        Me.shootbutton.TabIndex = 3
        Me.shootbutton.Text = "Shoot"
        Me.shootbutton.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(270, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Player Wins"
        '
        'lblPlayerCount
        '
        Me.lblPlayerCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlayerCount.Location = New System.Drawing.Point(97, 167)
        Me.lblPlayerCount.Name = "lblPlayerCount"
        Me.lblPlayerCount.Size = New System.Drawing.Size(84, 27)
        Me.lblPlayerCount.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Computer Wins"
        '
        'lblcompCount
        '
        Me.lblcompCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcompCount.Cursor = System.Windows.Forms.Cursors.UpArrow
        Me.lblcompCount.Location = New System.Drawing.Point(302, 167)
        Me.lblcompCount.Name = "lblcompCount"
        Me.lblcompCount.Size = New System.Drawing.Size(82, 27)
        Me.lblcompCount.TabIndex = 8
        '
        'ResultLabel
        '
        Me.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ResultLabel.Location = New System.Drawing.Point(97, 215)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(231, 23)
        Me.ResultLabel.TabIndex = 9
        '
        'PlayAgainButton
        '
        Me.PlayAgainButton.Location = New System.Drawing.Point(47, 264)
        Me.PlayAgainButton.Name = "PlayAgainButton"
        Me.PlayAgainButton.Size = New System.Drawing.Size(75, 23)
        Me.PlayAgainButton.TabIndex = 10
        Me.PlayAgainButton.Text = "Play Again"
        Me.PlayAgainButton.UseVisualStyleBackColor = True
        '
        'RockPaperScissors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 322)
        Me.Controls.Add(Me.PlayAgainButton)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.lblcompCount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPlayerCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.shootbutton)
        Me.Controls.Add(Me.ScissorsRadioButton)
        Me.Controls.Add(Me.paperRadioButton)
        Me.Controls.Add(Me.RockRadioButton)
        Me.Name = "RockPaperScissors"
        Me.Text = "Rock Paper Scissor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RockRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents paperRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ScissorsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents shootbutton As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayerCount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblcompCount As System.Windows.Forms.Label
    Friend WithEvents ResultLabel As System.Windows.Forms.Label
    Friend WithEvents PlayAgainButton As System.Windows.Forms.Button
End Class
