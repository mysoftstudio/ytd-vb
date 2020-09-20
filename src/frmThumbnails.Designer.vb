<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThumbnails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThumbnails))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblTextFT5 = New System.Windows.Forms.Label()
        Me.lblTextFT3 = New System.Windows.Forms.Label()
        Me.lblTextFT2 = New System.Windows.Forms.Label()
        Me.lblTextFT4 = New System.Windows.Forms.Label()
        Me.lblTextFT1 = New System.Windows.Forms.Label()
        Me.lblVidName_varFT = New System.Windows.Forms.Label()
        Me.imgbtnSaveFT = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSaveFT = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSettingFT = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMainInfoFT = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnRefreshFT = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.picImg2_varFT = New System.Windows.Forms.PictureBox()
        Me.picImg1_varFT = New System.Windows.Forms.PictureBox()
        Me.picDefaultImage_varFT = New System.Windows.Forms.PictureBox()
        Me.picLargeImage_varFT = New System.Windows.Forms.PictureBox()
        CType(Me.imgbtnSaveFT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettingFT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMainInfoFT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImg2_varFT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImg1_varFT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDefaultImage_varFT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLargeImage_varFT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'lblTextFT5
        '
        Me.lblTextFT5.AutoSize = True
        Me.lblTextFT5.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblTextFT5.Location = New System.Drawing.Point(290, 408)
        Me.lblTextFT5.Name = "lblTextFT5"
        Me.lblTextFT5.Size = New System.Drawing.Size(300, 20)
        Me.lblTextFT5.TabIndex = 0
        Me.lblTextFT5.Text = "Default Thumbnail Height : 480px * 360px "
        '
        'lblTextFT3
        '
        Me.lblTextFT3.AutoSize = True
        Me.lblTextFT3.Font = New System.Drawing.Font("Century Gothic", 9.25!)
        Me.lblTextFT3.ForeColor = System.Drawing.Color.Tomato
        Me.lblTextFT3.Location = New System.Drawing.Point(17, 271)
        Me.lblTextFT3.Name = "lblTextFT3"
        Me.lblTextFT3.Size = New System.Drawing.Size(135, 17)
        Me.lblTextFT3.TabIndex = 0
        Me.lblTextFT3.Text = "Alternative Image 1"
        '
        'lblTextFT2
        '
        Me.lblTextFT2.AutoSize = True
        Me.lblTextFT2.Font = New System.Drawing.Font("Century Gothic", 9.25!)
        Me.lblTextFT2.Location = New System.Drawing.Point(33, 138)
        Me.lblTextFT2.Name = "lblTextFT2"
        Me.lblTextFT2.Size = New System.Drawing.Size(101, 17)
        Me.lblTextFT2.TabIndex = 0
        Me.lblTextFT2.Text = "Default Image"
        '
        'lblTextFT4
        '
        Me.lblTextFT4.AutoSize = True
        Me.lblTextFT4.Font = New System.Drawing.Font("Century Gothic", 9.25!)
        Me.lblTextFT4.ForeColor = System.Drawing.Color.Tomato
        Me.lblTextFT4.Location = New System.Drawing.Point(13, 393)
        Me.lblTextFT4.Name = "lblTextFT4"
        Me.lblTextFT4.Size = New System.Drawing.Size(135, 17)
        Me.lblTextFT4.TabIndex = 0
        Me.lblTextFT4.Text = "Alternative Image 2"
        '
        'lblTextFT1
        '
        Me.lblTextFT1.AutoSize = True
        Me.lblTextFT1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblTextFT1.Location = New System.Drawing.Point(12, 9)
        Me.lblTextFT1.Name = "lblTextFT1"
        Me.lblTextFT1.Size = New System.Drawing.Size(122, 20)
        Me.lblTextFT1.TabIndex = 16
        Me.lblTextFT1.Text = "Thumbnails for : "
        '
        'lblVidName_varFT
        '
        Me.lblVidName_varFT.AutoSize = True
        Me.lblVidName_varFT.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblVidName_varFT.Location = New System.Drawing.Point(140, 9)
        Me.lblVidName_varFT.Name = "lblVidName_varFT"
        Me.lblVidName_varFT.Size = New System.Drawing.Size(240, 20)
        Me.lblVidName_varFT.TabIndex = 17
        Me.lblVidName_varFT.Text = "Lensko - Let's Go! [NCS Release]"
        '
        'imgbtnSaveFT
        '
        Me.imgbtnSaveFT.BackColor = System.Drawing.Color.White
        Me.imgbtnSaveFT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnSaveFT.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Save_64
        Me.imgbtnSaveFT.ImageActive = Nothing
        Me.imgbtnSaveFT.Location = New System.Drawing.Point(246, 408)
        Me.imgbtnSaveFT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnSaveFT.Name = "imgbtnSaveFT"
        Me.imgbtnSaveFT.Size = New System.Drawing.Size(23, 23)
        Me.imgbtnSaveFT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnSaveFT.TabIndex = 26
        Me.imgbtnSaveFT.TabStop = False
        Me.imgbtnSaveFT.Zoom = 10
        '
        'btnSaveFT
        '
        Me.btnSaveFT.ActiveBorderThickness = 1
        Me.btnSaveFT.ActiveCornerRadius = 1
        Me.btnSaveFT.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveFT.ActiveForecolor = System.Drawing.Color.White
        Me.btnSaveFT.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveFT.BackColor = System.Drawing.Color.White
        Me.btnSaveFT.BackgroundImage = CType(resources.GetObject("btnSaveFT.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveFT.ButtonText = "Save"
        Me.btnSaveFT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveFT.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btnSaveFT.ForeColor = System.Drawing.Color.Tomato
        Me.btnSaveFT.IdleBorderThickness = 1
        Me.btnSaveFT.IdleCornerRadius = 1
        Me.btnSaveFT.IdleFillColor = System.Drawing.Color.White
        Me.btnSaveFT.IdleForecolor = System.Drawing.Color.Tomato
        Me.btnSaveFT.IdleLineColor = System.Drawing.Color.Tomato
        Me.btnSaveFT.Location = New System.Drawing.Point(480, 1)
        Me.btnSaveFT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSaveFT.Name = "btnSaveFT"
        Me.btnSaveFT.Size = New System.Drawing.Size(79, 36)
        Me.btnSaveFT.TabIndex = 20
        Me.btnSaveFT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSettingFT
        '
        Me.btnSettingFT.BackColor = System.Drawing.Color.White
        Me.btnSettingFT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettingFT.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Settings_64
        Me.btnSettingFT.ImageActive = Nothing
        Me.btnSettingFT.Location = New System.Drawing.Point(217, 408)
        Me.btnSettingFT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSettingFT.Name = "btnSettingFT"
        Me.btnSettingFT.Size = New System.Drawing.Size(24, 23)
        Me.btnSettingFT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSettingFT.TabIndex = 18
        Me.btnSettingFT.TabStop = False
        Me.btnSettingFT.Zoom = 10
        '
        'btnMainInfoFT
        '
        Me.btnMainInfoFT.BackColor = System.Drawing.Color.White
        Me.btnMainInfoFT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainInfoFT.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.btnMainInfoFT.ImageActive = Nothing
        Me.btnMainInfoFT.Location = New System.Drawing.Point(188, 408)
        Me.btnMainInfoFT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMainInfoFT.Name = "btnMainInfoFT"
        Me.btnMainInfoFT.Size = New System.Drawing.Size(23, 23)
        Me.btnMainInfoFT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMainInfoFT.TabIndex = 19
        Me.btnMainInfoFT.TabStop = False
        Me.btnMainInfoFT.Zoom = 10
        '
        'btnRefreshFT
        '
        Me.btnRefreshFT.ActiveBorderThickness = 1
        Me.btnRefreshFT.ActiveCornerRadius = 1
        Me.btnRefreshFT.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFT.ActiveForecolor = System.Drawing.Color.White
        Me.btnRefreshFT.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFT.BackColor = System.Drawing.Color.White
        Me.btnRefreshFT.BackgroundImage = CType(resources.GetObject("btnRefreshFT.BackgroundImage"), System.Drawing.Image)
        Me.btnRefreshFT.ButtonText = "Refresh"
        Me.btnRefreshFT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshFT.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btnRefreshFT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFT.IdleBorderThickness = 1
        Me.btnRefreshFT.IdleCornerRadius = 1
        Me.btnRefreshFT.IdleFillColor = System.Drawing.Color.White
        Me.btnRefreshFT.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFT.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFT.Location = New System.Drawing.Point(569, 1)
        Me.btnRefreshFT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRefreshFT.Name = "btnRefreshFT"
        Me.btnRefreshFT.Size = New System.Drawing.Size(79, 36)
        Me.btnRefreshFT.TabIndex = 15
        Me.btnRefreshFT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picImg2_varFT
        '
        Me.picImg2_varFT.BackColor = System.Drawing.Color.White
        Me.picImg2_varFT.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.default_no_image
        Me.picImg2_varFT.Location = New System.Drawing.Point(27, 300)
        Me.picImg2_varFT.Name = "picImg2_varFT"
        Me.picImg2_varFT.Size = New System.Drawing.Size(120, 90)
        Me.picImg2_varFT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImg2_varFT.TabIndex = 1
        Me.picImg2_varFT.TabStop = False
        '
        'picImg1_varFT
        '
        Me.picImg1_varFT.BackColor = System.Drawing.Color.White
        Me.picImg1_varFT.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.default_no_image
        Me.picImg1_varFT.Location = New System.Drawing.Point(27, 177)
        Me.picImg1_varFT.Name = "picImg1_varFT"
        Me.picImg1_varFT.Size = New System.Drawing.Size(120, 90)
        Me.picImg1_varFT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImg1_varFT.TabIndex = 1
        Me.picImg1_varFT.TabStop = False
        '
        'picDefaultImage_varFT
        '
        Me.picDefaultImage_varFT.BackColor = System.Drawing.Color.White
        Me.picDefaultImage_varFT.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.default_no_image
        Me.picDefaultImage_varFT.Location = New System.Drawing.Point(27, 45)
        Me.picDefaultImage_varFT.Name = "picDefaultImage_varFT"
        Me.picDefaultImage_varFT.Size = New System.Drawing.Size(120, 90)
        Me.picDefaultImage_varFT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDefaultImage_varFT.TabIndex = 1
        Me.picDefaultImage_varFT.TabStop = False
        '
        'picLargeImage_varFT
        '
        Me.picLargeImage_varFT.BackColor = System.Drawing.Color.White
        Me.picLargeImage_varFT.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.default_no_image
        Me.picLargeImage_varFT.Location = New System.Drawing.Point(154, 45)
        Me.picLargeImage_varFT.Name = "picLargeImage_varFT"
        Me.picLargeImage_varFT.Size = New System.Drawing.Size(509, 356)
        Me.picLargeImage_varFT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLargeImage_varFT.TabIndex = 1
        Me.picLargeImage_varFT.TabStop = False
        '
        'frmThumbnails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(675, 436)
        Me.Controls.Add(Me.imgbtnSaveFT)
        Me.Controls.Add(Me.btnSaveFT)
        Me.Controls.Add(Me.btnSettingFT)
        Me.Controls.Add(Me.btnMainInfoFT)
        Me.Controls.Add(Me.lblVidName_varFT)
        Me.Controls.Add(Me.lblTextFT1)
        Me.Controls.Add(Me.btnRefreshFT)
        Me.Controls.Add(Me.picImg2_varFT)
        Me.Controls.Add(Me.picImg1_varFT)
        Me.Controls.Add(Me.picDefaultImage_varFT)
        Me.Controls.Add(Me.picLargeImage_varFT)
        Me.Controls.Add(Me.lblTextFT2)
        Me.Controls.Add(Me.lblTextFT4)
        Me.Controls.Add(Me.lblTextFT3)
        Me.Controls.Add(Me.lblTextFT5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmThumbnails"
        Me.Text = "frmThumbnails"
        CType(Me.imgbtnSaveFT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettingFT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMainInfoFT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImg2_varFT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImg1_varFT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDefaultImage_varFT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLargeImage_varFT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblTextFT5 As Label
    Friend WithEvents picLargeImage_varFT As PictureBox
    Friend WithEvents picImg2_varFT As PictureBox
    Friend WithEvents picImg1_varFT As PictureBox
    Friend WithEvents picDefaultImage_varFT As PictureBox
    Friend WithEvents lblTextFT2 As Label
    Friend WithEvents lblTextFT4 As Label
    Friend WithEvents lblTextFT3 As Label
    Friend WithEvents btnRefreshFT As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblTextFT1 As Label
    Friend WithEvents lblVidName_varFT As Label
    Friend WithEvents btnSettingFT As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMainInfoFT As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSaveFT As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents imgbtnSaveFT As Bunifu.Framework.UI.BunifuImageButton
End Class
