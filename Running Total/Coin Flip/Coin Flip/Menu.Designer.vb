<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnRock = New System.Windows.Forms.Button()
        Me.btnSumofNumbers = New System.Windows.Forms.Button()
        Me.btnCoinToss = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRace = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRock
        '
        Me.btnRock.Location = New System.Drawing.Point(99, 48)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(104, 23)
        Me.btnRock.TabIndex = 0
        Me.btnRock.Text = "Rock"
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'btnSumofNumbers
        '
        Me.btnSumofNumbers.Location = New System.Drawing.Point(99, 77)
        Me.btnSumofNumbers.Name = "btnSumofNumbers"
        Me.btnSumofNumbers.Size = New System.Drawing.Size(104, 23)
        Me.btnSumofNumbers.TabIndex = 1
        Me.btnSumofNumbers.Text = "Sum Of Numbers"
        Me.btnSumofNumbers.UseVisualStyleBackColor = True
        '
        'btnCoinToss
        '
        Me.btnCoinToss.Location = New System.Drawing.Point(99, 106)
        Me.btnCoinToss.Name = "btnCoinToss"
        Me.btnCoinToss.Size = New System.Drawing.Size(104, 23)
        Me.btnCoinToss.TabIndex = 2
        Me.btnCoinToss.Text = "Coin Toss"
        Me.btnCoinToss.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Light Switch"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRace
        '
        Me.btnRace.Location = New System.Drawing.Point(99, 164)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(104, 23)
        Me.btnRace.TabIndex = 4
        Me.btnRace.Text = "Race"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnRace)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCoinToss)
        Me.Controls.Add(Me.btnSumofNumbers)
        Me.Controls.Add(Me.btnRock)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents btnSumofNumbers As System.Windows.Forms.Button
    Friend WithEvents btnCoinToss As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnRace As System.Windows.Forms.Button
End Class
