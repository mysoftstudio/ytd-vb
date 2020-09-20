<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTopMenu_Play
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTopMenu_Play))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblText3 = New System.Windows.Forms.Label()
        Me.lblText1 = New System.Windows.Forms.Label()
        Me.lblText2 = New System.Windows.Forms.Label()
        Me.lblVidName_varFTMPV = New System.Windows.Forms.Label()
        Me.lblFileFormatFTMPV_var = New System.Windows.Forms.Label()
        Me.lblText4 = New System.Windows.Forms.Label()
        Me.lblFilePathFTMPV_var = New System.Windows.Forms.Label()
        Me.pgbAnimateFTMPV = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.lblUpgradePremiumFTMPV = New System.Windows.Forms.Label()
        Me.TimerUI = New System.Windows.Forms.Timer(Me.components)
        Me.pgbUI_Ac = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'lblText3
        '
        Me.lblText3.AutoSize = True
        Me.lblText3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText3.Location = New System.Drawing.Point(143, 87)
        Me.lblText3.Name = "lblText3"
        Me.lblText3.Size = New System.Drawing.Size(422, 18)
        Me.lblText3.TabIndex = 5
        Me.lblText3.Text = "You Can Easily Open Video File or your download Video "
        '
        'lblText1
        '
        Me.lblText1.AutoSize = True
        Me.lblText1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText1.Location = New System.Drawing.Point(12, 28)
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Size = New System.Drawing.Size(143, 20)
        Me.lblText1.TabIndex = 5
        Me.lblText1.Text = "Currently Playing : "
        '
        'lblText2
        '
        Me.lblText2.AutoSize = True
        Me.lblText2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText2.Location = New System.Drawing.Point(53, 59)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(98, 20)
        Me.lblText2.TabIndex = 5
        Me.lblText2.Text = "File Format  :"
        '
        'lblVidName_varFTMPV
        '
        Me.lblVidName_varFTMPV.AutoSize = True
        Me.lblVidName_varFTMPV.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidName_varFTMPV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblVidName_varFTMPV.Location = New System.Drawing.Point(161, 28)
        Me.lblVidName_varFTMPV.Name = "lblVidName_varFTMPV"
        Me.lblVidName_varFTMPV.Size = New System.Drawing.Size(240, 20)
        Me.lblVidName_varFTMPV.TabIndex = 11
        Me.lblVidName_varFTMPV.Text = "Lensko - Let's Go! [NCS Release]"
        '
        'lblFileFormatFTMPV_var
        '
        Me.lblFileFormatFTMPV_var.AutoSize = True
        Me.lblFileFormatFTMPV_var.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileFormatFTMPV_var.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblFileFormatFTMPV_var.Location = New System.Drawing.Point(157, 59)
        Me.lblFileFormatFTMPV_var.Name = "lblFileFormatFTMPV_var"
        Me.lblFileFormatFTMPV_var.Size = New System.Drawing.Size(45, 20)
        Me.lblFileFormatFTMPV_var.TabIndex = 11
        Me.lblFileFormatFTMPV_var.Text = ".MP4"
        '
        'lblText4
        '
        Me.lblText4.AutoSize = True
        Me.lblText4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText4.Location = New System.Drawing.Point(269, 59)
        Me.lblText4.Name = "lblText4"
        Me.lblText4.Size = New System.Drawing.Size(81, 20)
        Me.lblText4.TabIndex = 5
        Me.lblText4.Text = "File Path  :"
        '
        'lblFilePathFTMPV_var
        '
        Me.lblFilePathFTMPV_var.AutoSize = True
        Me.lblFilePathFTMPV_var.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilePathFTMPV_var.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblFilePathFTMPV_var.Location = New System.Drawing.Point(356, 59)
        Me.lblFilePathFTMPV_var.Name = "lblFilePathFTMPV_var"
        Me.lblFilePathFTMPV_var.Size = New System.Drawing.Size(225, 20)
        Me.lblFilePathFTMPV_var.TabIndex = 11
        Me.lblFilePathFTMPV_var.Text = "C:/Storage/Downöload /Idsd"
        '
        'pgbAnimateFTMPV
        '
        Me.pgbAnimateFTMPV.animated = True
        Me.pgbAnimateFTMPV.animationIterval = 5
        Me.pgbAnimateFTMPV.animationSpeed = 1
        Me.pgbAnimateFTMPV.BackColor = System.Drawing.Color.Transparent
        Me.pgbAnimateFTMPV.BackgroundImage = CType(resources.GetObject("pgbAnimateFTMPV.BackgroundImage"), System.Drawing.Image)
        Me.pgbAnimateFTMPV.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.pgbAnimateFTMPV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.pgbAnimateFTMPV.LabelVisible = False
        Me.pgbAnimateFTMPV.LineProgressThickness = 4
        Me.pgbAnimateFTMPV.LineThickness = 5
        Me.pgbAnimateFTMPV.Location = New System.Drawing.Point(592, 18)
        Me.pgbAnimateFTMPV.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.pgbAnimateFTMPV.MaxValue = 100
        Me.pgbAnimateFTMPV.Name = "pgbAnimateFTMPV"
        Me.pgbAnimateFTMPV.ProgressBackColor = System.Drawing.Color.Transparent
        Me.pgbAnimateFTMPV.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.pgbAnimateFTMPV.Size = New System.Drawing.Size(70, 70)
        Me.pgbAnimateFTMPV.TabIndex = 13
        Me.pgbAnimateFTMPV.Value = 50
        '
        'lblUpgradePremiumFTMPV
        '
        Me.lblUpgradePremiumFTMPV.AutoSize = True
        Me.lblUpgradePremiumFTMPV.Font = New System.Drawing.Font("Century Gothic", 13.25!)
        Me.lblUpgradePremiumFTMPV.ForeColor = System.Drawing.Color.Tomato
        Me.lblUpgradePremiumFTMPV.Location = New System.Drawing.Point(173, 9)
        Me.lblUpgradePremiumFTMPV.Name = "lblUpgradePremiumFTMPV"
        Me.lblUpgradePremiumFTMPV.Size = New System.Drawing.Size(337, 21)
        Me.lblUpgradePremiumFTMPV.TabIndex = 14
        Me.lblUpgradePremiumFTMPV.Text = "Please Upgrade To Premium For More"
        '
        'TimerUI
        '
        Me.TimerUI.Interval = 10
        '
        'pgbUI_Ac
        '
        Me.pgbUI_Ac.Location = New System.Drawing.Point(485, 33)
        Me.pgbUI_Ac.Name = "pgbUI_Ac"
        Me.pgbUI_Ac.Size = New System.Drawing.Size(96, 15)
        Me.pgbUI_Ac.TabIndex = 30
        '
        'frmTopMenu_Play
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(681, 114)
        Me.Controls.Add(Me.pgbUI_Ac)
        Me.Controls.Add(Me.lblUpgradePremiumFTMPV)
        Me.Controls.Add(Me.pgbAnimateFTMPV)
        Me.Controls.Add(Me.lblFileFormatFTMPV_var)
        Me.Controls.Add(Me.lblFilePathFTMPV_var)
        Me.Controls.Add(Me.lblVidName_varFTMPV)
        Me.Controls.Add(Me.lblText4)
        Me.Controls.Add(Me.lblText2)
        Me.Controls.Add(Me.lblText1)
        Me.Controls.Add(Me.lblText3)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmTopMenu_Play"
        Me.Text = "frmTopMenu_Play"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblText2 As Label
    Friend WithEvents lblText1 As Label
    Friend WithEvents lblText3 As Label
    Friend WithEvents lblFileFormatFTMPV_var As Label
    Friend WithEvents lblFilePathFTMPV_var As Label
    Friend WithEvents lblVidName_varFTMPV As Label
    Friend WithEvents lblText4 As Label
    Friend WithEvents pgbAnimateFTMPV As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents lblUpgradePremiumFTMPV As Label
    Friend WithEvents pgbUI_Ac As ProgressBar
    Friend WithEvents TimerUI As Timer
End Class
