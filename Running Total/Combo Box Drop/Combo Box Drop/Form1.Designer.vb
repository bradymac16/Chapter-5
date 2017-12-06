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
        Me.cboCountrys = New System.Windows.Forms.ComboBox()
        Me.cboArtist = New System.Windows.Forms.ComboBox()
        Me.cboPlays = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCOuntry = New System.Windows.Forms.TextBox()
        Me.txtPlay = New System.Windows.Forms.TextBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCountrys
        '
        Me.cboCountrys.FormattingEnabled = True
        Me.cboCountrys.Items.AddRange(New Object() {"England ", "Ireland", "ScottLand ", "Wales"})
        Me.cboCountrys.Location = New System.Drawing.Point(148, 35)
        Me.cboCountrys.Name = "cboCountrys"
        Me.cboCountrys.Size = New System.Drawing.Size(121, 21)
        Me.cboCountrys.TabIndex = 0
        '
        'cboArtist
        '
        Me.cboArtist.FormattingEnabled = True
        Me.cboArtist.Items.AddRange(New Object() {"Michelangelo", "Raphael ", "da Vinci"})
        Me.cboArtist.Location = New System.Drawing.Point(148, 110)
        Me.cboArtist.Name = "cboArtist"
        Me.cboArtist.Size = New System.Drawing.Size(121, 21)
        Me.cboArtist.TabIndex = 1
        '
        'cboPlays
        '
        Me.cboPlays.FormattingEnabled = True
        Me.cboPlays.Items.AddRange(New Object() {"Hamlet", "Much Ado about Nothing", "romeo and Juliet", "A comedy off Errors", "The Merchant of Venice"})
        Me.cboPlays.Location = New System.Drawing.Point(148, 74)
        Me.cboPlays.Name = "cboPlays"
        Me.cboPlays.Size = New System.Drawing.Size(121, 21)
        Me.cboPlays.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Chose A Country"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Chose A Play"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Chose An Artist"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtArtist)
        Me.GroupBox1.Controls.Add(Me.txtPlay)
        Me.GroupBox1.Controls.Add(Me.txtCOuntry)
        Me.GroupBox1.Location = New System.Drawing.Point(314, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 137)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Choices"
        '
        'txtCOuntry
        '
        Me.txtCOuntry.Location = New System.Drawing.Point(50, 28)
        Me.txtCOuntry.Name = "txtCOuntry"
        Me.txtCOuntry.Size = New System.Drawing.Size(100, 20)
        Me.txtCOuntry.TabIndex = 0
        '
        'txtPlay
        '
        Me.txtPlay.Location = New System.Drawing.Point(50, 62)
        Me.txtPlay.Name = "txtPlay"
        Me.txtPlay.Size = New System.Drawing.Size(100, 20)
        Me.txtPlay.TabIndex = 1
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(50, 98)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(100, 20)
        Me.txtArtist.TabIndex = 2
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(79, 192)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 37)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "Show Selections"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(221, 192)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 37)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(354, 192)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPlays)
        Me.Controls.Add(Me.cboArtist)
        Me.Controls.Add(Me.cboCountrys)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCountrys As System.Windows.Forms.ComboBox
    Friend WithEvents cboArtist As System.Windows.Forms.ComboBox
    Friend WithEvents cboPlays As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtArtist As System.Windows.Forms.TextBox
    Friend WithEvents txtPlay As System.Windows.Forms.TextBox
    Friend WithEvents txtCOuntry As System.Windows.Forms.TextBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
