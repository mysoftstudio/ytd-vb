<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTopMenu_Download
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTopMenu_Download))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblText5 = New System.Windows.Forms.Label()
        Me.lblLastDownFTMD_var = New System.Windows.Forms.Label()
        Me.gpgbDownloadProgressFTMD = New Bunifu.Framework.UI.BunifuGauge()
        Me.lblText1 = New System.Windows.Forms.Label()
        Me.lblText2 = New System.Windows.Forms.Label()
        Me.lblVidFormat_varFTMD = New System.Windows.Forms.Label()
        Me.lblText3 = New System.Windows.Forms.Label()
        Me.lblVidName_varFTMD = New System.Windows.Forms.Label()
        Me.lblVidSize_varFTMD = New System.Windows.Forms.Label()
        Me.lblText6 = New System.Windows.Forms.Label()
        Me.lblProgressValueFTMD_var = New System.Windows.Forms.Label()
        Me.picMoreInfos = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblText55 = New System.Windows.Forms.Label()
        Me.lblCurrentStatus_varFTMD = New System.Windows.Forms.Label()
        Me.pgbUI_Ac = New System.Windows.Forms.ProgressBar()
        Me.TimerUI = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picMoreInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'lblText5
        '
        Me.lblText5.AutoSize = True
        Me.lblText5.Location = New System.Drawing.Point(12, 64)
        Me.lblText5.Name = "lblText5"
        Me.lblText5.Size = New System.Drawing.Size(191, 20)
        Me.lblText5.TabIndex = 0
        Me.lblText5.Text = "Last Download  Was On :"
        '
        'lblLastDownFTMD_var
        '
        Me.lblLastDownFTMD_var.AutoSize = True
        Me.lblLastDownFTMD_var.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblLastDownFTMD_var.Location = New System.Drawing.Point(209, 64)
        Me.lblLastDownFTMD_var.Name = "lblLastDownFTMD_var"
        Me.lblLastDownFTMD_var.Size = New System.Drawing.Size(127, 20)
        Me.lblLastDownFTMD_var.TabIndex = 0
        Me.lblLastDownFTMD_var.Text = "14:33 06/09/2017"
        '
        'gpgbDownloadProgressFTMD
        '
        Me.gpgbDownloadProgressFTMD.BackColor = System.Drawing.Color.Transparent
        Me.gpgbDownloadProgressFTMD.BackgroundImage = CType(resources.GetObject("gpgbDownloadProgressFTMD.BackgroundImage"), System.Drawing.Image)
        Me.gpgbDownloadProgressFTMD.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.gpgbDownloadProgressFTMD.Location = New System.Drawing.Point(526, 0)
        Me.gpgbDownloadProgressFTMD.Margin = New System.Windows.Forms.Padding(5)
        Me.gpgbDownloadProgressFTMD.Name = "gpgbDownloadProgressFTMD"
        Me.gpgbDownloadProgressFTMD.ProgressBgColor = System.Drawing.Color.Gray
        Me.gpgbDownloadProgressFTMD.ProgressColor1 = System.Drawing.Color.Tomato
        Me.gpgbDownloadProgressFTMD.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.gpgbDownloadProgressFTMD.Size = New System.Drawing.Size(141, 118)
        Me.gpgbDownloadProgressFTMD.Suffix = ""
        Me.gpgbDownloadProgressFTMD.TabIndex = 3
        Me.gpgbDownloadProgressFTMD.Thickness = 15
        Me.gpgbDownloadProgressFTMD.Value = 0
        '
        'lblText1
        '
        Me.lblText1.AutoSize = True
        Me.lblText1.Location = New System.Drawing.Point(12, 9)
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Size = New System.Drawing.Size(159, 20)
        Me.lblText1.TabIndex = 0
        Me.lblText1.Text = "Current Video Ttitle : "
        '
        'lblText2
        '
        Me.lblText2.AutoSize = True
        Me.lblText2.Location = New System.Drawing.Point(17, 40)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(154, 20)
        Me.lblText2.TabIndex = 0
        Me.lblText2.Text = "Current Video Size : "
        '
        'lblVidFormat_varFTMD
        '
        Me.lblVidFormat_varFTMD.AutoSize = True
        Me.lblVidFormat_varFTMD.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidFormat_varFTMD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblVidFormat_varFTMD.Location = New System.Drawing.Point(360, 40)
        Me.lblVidFormat_varFTMD.Name = "lblVidFormat_varFTMD"
        Me.lblVidFormat_varFTMD.Size = New System.Drawing.Size(45, 20)
        Me.lblVidFormat_varFTMD.TabIndex = 4
        Me.lblVidFormat_varFTMD.Text = ".MP4"
        '
        'lblText3
        '
        Me.lblText3.AutoSize = True
        Me.lblText3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText3.Location = New System.Drawing.Point(248, 40)
        Me.lblText3.Name = "lblText3"
        Me.lblText3.Size = New System.Drawing.Size(123, 20)
        Me.lblText3.TabIndex = 5
        Me.lblText3.Text = "Video Format :  "
        '
        'lblVidName_varFTMD
        '
        Me.lblVidName_varFTMD.AutoSize = True
        Me.lblVidName_varFTMD.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidName_varFTMD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblVidName_varFTMD.Location = New System.Drawing.Point(170, 9)
        Me.lblVidName_varFTMD.Name = "lblVidName_varFTMD"
        Me.lblVidName_varFTMD.Size = New System.Drawing.Size(240, 20)
        Me.lblVidName_varFTMD.TabIndex = 6
        Me.lblVidName_varFTMD.Text = "Lensko - Let's Go! [NCS Release]"
        '
        'lblVidSize_varFTMD
        '
        Me.lblVidSize_varFTMD.AutoSize = True
        Me.lblVidSize_varFTMD.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidSize_varFTMD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblVidSize_varFTMD.Location = New System.Drawing.Point(170, 40)
        Me.lblVidSize_varFTMD.Name = "lblVidSize_varFTMD"
        Me.lblVidSize_varFTMD.Size = New System.Drawing.Size(63, 20)
        Me.lblVidSize_varFTMD.TabIndex = 7
        Me.lblVidSize_varFTMD.Text = "1.25 GB"
        '
        'lblText6
        '
        Me.lblText6.AutoSize = True
        Me.lblText6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText6.Location = New System.Drawing.Point(385, 60)
        Me.lblText6.Name = "lblText6"
        Me.lblText6.Size = New System.Drawing.Size(133, 20)
        Me.lblText6.TabIndex = 5
        Me.lblText6.Text = "Progress Value :  "
        '
        'lblProgressValueFTMD_var
        '
        Me.lblProgressValueFTMD_var.AutoSize = True
        Me.lblProgressValueFTMD_var.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgressValueFTMD_var.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblProgressValueFTMD_var.Location = New System.Drawing.Point(385, 85)
        Me.lblProgressValueFTMD_var.Name = "lblProgressValueFTMD_var"
        Me.lblProgressValueFTMD_var.Size = New System.Drawing.Size(126, 20)
        Me.lblProgressValueFTMD_var.TabIndex = 5
        Me.lblProgressValueFTMD_var.Text = "512MB / 1.25 GB"
        '
        'picMoreInfos
        '
        Me.picMoreInfos.BackColor = System.Drawing.Color.Transparent
        Me.picMoreInfos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfos.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_More_Info_48
        Me.picMoreInfos.ImageActive = Nothing
        Me.picMoreInfos.Location = New System.Drawing.Point(643, 6)
        Me.picMoreInfos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picMoreInfos.Name = "picMoreInfos"
        Me.picMoreInfos.Size = New System.Drawing.Size(26, 23)
        Me.picMoreInfos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMoreInfos.TabIndex = 28
        Me.picMoreInfos.TabStop = False
        Me.picMoreInfos.Zoom = 10
        '
        'lblText55
        '
        Me.lblText55.AutoSize = True
        Me.lblText55.Location = New System.Drawing.Point(12, 88)
        Me.lblText55.Name = "lblText55"
        Me.lblText55.Size = New System.Drawing.Size(122, 20)
        Me.lblText55.TabIndex = 0
        Me.lblText55.Text = "Current Status : "
        '
        'lblCurrentStatus_varFTMD
        '
        Me.lblCurrentStatus_varFTMD.AutoSize = True
        Me.lblCurrentStatus_varFTMD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblCurrentStatus_varFTMD.Location = New System.Drawing.Point(140, 88)
        Me.lblCurrentStatus_varFTMD.Name = "lblCurrentStatus_varFTMD"
        Me.lblCurrentStatus_varFTMD.Size = New System.Drawing.Size(94, 20)
        Me.lblCurrentStatus_varFTMD.TabIndex = 0
        Me.lblCurrentStatus_varFTMD.Text = "Searching..."
        '
        'pgbUI_Ac
        '
        Me.pgbUI_Ac.Location = New System.Drawing.Point(445, 14)
        Me.pgbUI_Ac.Name = "pgbUI_Ac"
        Me.pgbUI_Ac.Size = New System.Drawing.Size(96, 15)
        Me.pgbUI_Ac.TabIndex = 29
        Me.pgbUI_Ac.Visible = False
        '
        'TimerUI
        '
        Me.TimerUI.Interval = 10
        '
        'frmTopMenu_Download
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(681, 114)
        Me.Controls.Add(Me.pgbUI_Ac)
        Me.Controls.Add(Me.picMoreInfos)
        Me.Controls.Add(Me.lblVidSize_varFTMD)
        Me.Controls.Add(Me.lblVidName_varFTMD)
        Me.Controls.Add(Me.lblVidFormat_varFTMD)
        Me.Controls.Add(Me.lblProgressValueFTMD_var)
        Me.Controls.Add(Me.lblText6)
        Me.Controls.Add(Me.lblText3)
        Me.Controls.Add(Me.gpgbDownloadProgressFTMD)
        Me.Controls.Add(Me.lblCurrentStatus_varFTMD)
        Me.Controls.Add(Me.lblLastDownFTMD_var)
        Me.Controls.Add(Me.lblText2)
        Me.Controls.Add(Me.lblText1)
        Me.Controls.Add(Me.lblText55)
        Me.Controls.Add(Me.lblText5)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmTopMenu_Download"
        Me.Text = "frmTopMenu_Download"
        CType(Me.picMoreInfos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblLastDownFTMD_var As Label
    Friend WithEvents lblText5 As Label
    Friend WithEvents gpgbDownloadProgressFTMD As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents lblText2 As Label
    Friend WithEvents lblText1 As Label
    Friend WithEvents lblVidFormat_varFTMD As Label
    Friend WithEvents lblText3 As Label
    Friend WithEvents lblVidName_varFTMD As Label
    Friend WithEvents lblVidSize_varFTMD As Label
    Friend WithEvents lblProgressValueFTMD_var As Label
    Friend WithEvents lblText6 As Label
    Friend WithEvents picMoreInfos As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblCurrentStatus_varFTMD As Label
    Friend WithEvents lblText55 As Label
    Friend WithEvents pgbUI_Ac As ProgressBar
    Friend WithEvents TimerUI As Timer
End Class
