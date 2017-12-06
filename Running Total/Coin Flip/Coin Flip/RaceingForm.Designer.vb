<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RaceingForm
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
        Me.btnRace = New System.Windows.Forms.Button()
        Me.PicRacer4 = New System.Windows.Forms.PictureBox()
        Me.PicRacer3 = New System.Windows.Forms.PictureBox()
        Me.PicRacer2 = New System.Windows.Forms.PictureBox()
        Me.picRacer1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNationalsCount = New System.Windows.Forms.Label()
        Me.lblAstrosCount = New System.Windows.Forms.Label()
        Me.lblIndiansCount = New System.Windows.Forms.Label()
        Me.lblCubsCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PicRacer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRacer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRacer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRacer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRace
        '
        Me.btnRace.Location = New System.Drawing.Point(34, 383)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(75, 23)
        Me.btnRace.TabIndex = 0
        Me.btnRace.Text = "Race"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'PicRacer4
        '
        Me.PicRacer4.Image = Global.Coin_Flip.My.Resources.Resources.astros
        Me.PicRacer4.Location = New System.Drawing.Point(12, 264)
        Me.PicRacer4.Name = "PicRacer4"
        Me.PicRacer4.Size = New System.Drawing.Size(97, 81)
        Me.PicRacer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRacer4.TabIndex = 4
        Me.PicRacer4.TabStop = False
        '
        'PicRacer3
        '
        Me.PicRacer3.Image = Global.Coin_Flip.My.Resources.Resources.national_s
        Me.PicRacer3.Location = New System.Drawing.Point(12, 177)
        Me.PicRacer3.Name = "PicRacer3"
        Me.PicRacer3.Size = New System.Drawing.Size(97, 81)
        Me.PicRacer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRacer3.TabIndex = 3
        Me.PicRacer3.TabStop = False
        '
        'PicRacer2
        '
        Me.PicRacer2.Image = Global.Coin_Flip.My.Resources.Resources.indiana
        Me.PicRacer2.Location = New System.Drawing.Point(12, 90)
        Me.PicRacer2.Name = "PicRacer2"
        Me.PicRacer2.Size = New System.Drawing.Size(97, 81)
        Me.PicRacer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRacer2.TabIndex = 2
        Me.PicRacer2.TabStop = False
        '
        'picRacer1
        '
        Me.picRacer1.Image = Global.Coin_Flip.My.Resources.Resources.cubs
        Me.picRacer1.Location = New System.Drawing.Point(12, 3)
        Me.picRacer1.Name = "picRacer1"
        Me.picRacer1.Size = New System.Drawing.Size(97, 81)
        Me.picRacer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRacer1.TabIndex = 1
        Me.picRacer1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNationalsCount)
        Me.GroupBox1.Controls.Add(Me.lblAstrosCount)
        Me.GroupBox1.Controls.Add(Me.lblIndiansCount)
        Me.GroupBox1.Controls.Add(Me.lblCubsCount)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(168, 372)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 115)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Wins"
        '
        'lblNationalsCount
        '
        Me.lblNationalsCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNationalsCount.Location = New System.Drawing.Point(193, 15)
        Me.lblNationalsCount.Name = "lblNationalsCount"
        Me.lblNationalsCount.Size = New System.Drawing.Size(67, 23)
        Me.lblNationalsCount.TabIndex = 9
        '
        'lblAstrosCount
        '
        Me.lblAstrosCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAstrosCount.Location = New System.Drawing.Point(193, 75)
        Me.lblAstrosCount.Name = "lblAstrosCount"
        Me.lblAstrosCount.Size = New System.Drawing.Size(67, 23)
        Me.lblAstrosCount.TabIndex = 8
        '
        'lblIndiansCount
        '
        Me.lblIndiansCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndiansCount.Location = New System.Drawing.Point(60, 74)
        Me.lblIndiansCount.Name = "lblIndiansCount"
        Me.lblIndiansCount.Size = New System.Drawing.Size(67, 23)
        Me.lblIndiansCount.TabIndex = 7
        '
        'lblCubsCount
        '
        Me.lblCubsCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCubsCount.Location = New System.Drawing.Point(60, 16)
        Me.lblCubsCount.Name = "lblCubsCount"
        Me.lblCubsCount.Size = New System.Drawing.Size(67, 23)
        Me.lblCubsCount.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Astros:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nationals:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Indians:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cubs:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(34, 427)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'RaceingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 499)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRace)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PicRacer4)
        Me.Controls.Add(Me.PicRacer3)
        Me.Controls.Add(Me.PicRacer2)
        Me.Controls.Add(Me.picRacer1)
        Me.Name = "RaceingForm"
        Me.Text = "Raceing Form"
        CType(Me.PicRacer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRacer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRacer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRacer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents picRacer1 As System.Windows.Forms.PictureBox
    Friend WithEvents PicRacer2 As System.Windows.Forms.PictureBox
    Friend WithEvents PicRacer3 As System.Windows.Forms.PictureBox
    Friend WithEvents PicRacer4 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNationalsCount As System.Windows.Forms.Label
    Friend WithEvents lblAstrosCount As System.Windows.Forms.Label
    Friend WithEvents lblIndiansCount As System.Windows.Forms.Label
    Friend WithEvents lblCubsCount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
