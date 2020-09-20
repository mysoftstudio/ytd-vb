<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTopMenu_Thumbnails
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
        Me.lblUpgradePremiumFTMT = New System.Windows.Forms.Label()
        Me.picYouTUbe = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgbtnFTMT_MoreInfos = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.picYouTUbe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnFTMT_MoreInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'lblUpgradePremiumFTMT
        '
        Me.lblUpgradePremiumFTMT.AutoSize = True
        Me.lblUpgradePremiumFTMT.Font = New System.Drawing.Font("Century Gothic", 13.25!)
        Me.lblUpgradePremiumFTMT.ForeColor = System.Drawing.Color.Tomato
        Me.lblUpgradePremiumFTMT.Location = New System.Drawing.Point(172, 41)
        Me.lblUpgradePremiumFTMT.Name = "lblUpgradePremiumFTMT"
        Me.lblUpgradePremiumFTMT.Size = New System.Drawing.Size(337, 21)
        Me.lblUpgradePremiumFTMT.TabIndex = 7
        Me.lblUpgradePremiumFTMT.Text = "Please Upgrade To Premium For More"
        '
        'picYouTUbe
        '
        Me.picYouTUbe.BackColor = System.Drawing.Color.Transparent
        Me.picYouTUbe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picYouTUbe.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_YouTube_48
        Me.picYouTUbe.ImageActive = Nothing
        Me.picYouTUbe.Location = New System.Drawing.Point(301, 66)
        Me.picYouTUbe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picYouTUbe.Name = "picYouTUbe"
        Me.picYouTUbe.Size = New System.Drawing.Size(37, 35)
        Me.picYouTUbe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picYouTUbe.TabIndex = 26
        Me.picYouTUbe.TabStop = False
        Me.picYouTUbe.Zoom = 10
        '
        'imgbtnFTMT_MoreInfos
        '
        Me.imgbtnFTMT_MoreInfos.BackColor = System.Drawing.Color.Transparent
        Me.imgbtnFTMT_MoreInfos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFTMT_MoreInfos.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.imgbtnFTMT_MoreInfos.ImageActive = Nothing
        Me.imgbtnFTMT_MoreInfos.Location = New System.Drawing.Point(359, 66)
        Me.imgbtnFTMT_MoreInfos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnFTMT_MoreInfos.Name = "imgbtnFTMT_MoreInfos"
        Me.imgbtnFTMT_MoreInfos.Size = New System.Drawing.Size(37, 35)
        Me.imgbtnFTMT_MoreInfos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFTMT_MoreInfos.TabIndex = 27
        Me.imgbtnFTMT_MoreInfos.TabStop = False
        Me.imgbtnFTMT_MoreInfos.Zoom = 10
        '
        'frmTopMenu_Thumbnails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(681, 114)
        Me.Controls.Add(Me.picYouTUbe)
        Me.Controls.Add(Me.imgbtnFTMT_MoreInfos)
        Me.Controls.Add(Me.lblUpgradePremiumFTMT)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmTopMenu_Thumbnails"
        Me.Text = "frmTopMenu_Thuimbnails"
        CType(Me.picYouTUbe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnFTMT_MoreInfos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblUpgradePremiumFTMT As Label
    Friend WithEvents picYouTUbe As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgbtnFTMT_MoreInfos As Bunifu.Framework.UI.BunifuImageButton
End Class
