<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTopMenu_Share
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblText1 = New System.Windows.Forms.Label()
        Me.lblText3 = New System.Windows.Forms.Label()
        Me.lblText2 = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblUpgradePremiumFTMS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'lblText1
        '
        Me.lblText1.AutoSize = True
        Me.lblText1.Font = New System.Drawing.Font("Century Gothic", 13.25!)
        Me.lblText1.Location = New System.Drawing.Point(195, 9)
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Size = New System.Drawing.Size(265, 21)
        Me.lblText1.TabIndex = 6
        Me.lblText1.Text = "MySoft YouTube Downloader"
        '
        'lblText3
        '
        Me.lblText3.AutoSize = True
        Me.lblText3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText3.Location = New System.Drawing.Point(63, 30)
        Me.lblText3.Name = "lblText3"
        Me.lblText3.Size = New System.Drawing.Size(557, 20)
        Me.lblText3.TabIndex = 6
        Me.lblText3.Text = "With MySoft YouTube Downloader can also help you to share Direct Videos "
        '
        'lblText2
        '
        Me.lblText2.AutoSize = True
        Me.lblText2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText2.Location = New System.Drawing.Point(87, 56)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(172, 20)
        Me.lblText2.TabIndex = 6
        Me.lblText2.Text = "Use QR Code To Share"
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(265, 56)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(312, 20)
        Me.lblText.TabIndex = 6
        Me.lblText.Text = "If you need Help don't forget to Open This"
        '
        'lblUpgradePremiumFTMS
        '
        Me.lblUpgradePremiumFTMS.AutoSize = True
        Me.lblUpgradePremiumFTMS.Font = New System.Drawing.Font("Century Gothic", 13.25!)
        Me.lblUpgradePremiumFTMS.ForeColor = System.Drawing.Color.Tomato
        Me.lblUpgradePremiumFTMS.Location = New System.Drawing.Point(172, 84)
        Me.lblUpgradePremiumFTMS.Name = "lblUpgradePremiumFTMS"
        Me.lblUpgradePremiumFTMS.Size = New System.Drawing.Size(337, 21)
        Me.lblUpgradePremiumFTMS.TabIndex = 8
        Me.lblUpgradePremiumFTMS.Text = "Please Upgrade To Premium For More"
        '
        'frmTopMenu_Share
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(681, 114)
        Me.Controls.Add(Me.lblUpgradePremiumFTMS)
        Me.Controls.Add(Me.lblText3)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lblText2)
        Me.Controls.Add(Me.lblText1)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmTopMenu_Share"
        Me.Text = "frmTopMenu_Share"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblText3 As Label
    Friend WithEvents lblText1 As Label
    Friend WithEvents lblText As Label
    Friend WithEvents lblText2 As Label
    Friend WithEvents lblUpgradePremiumFTMS As Label
End Class
