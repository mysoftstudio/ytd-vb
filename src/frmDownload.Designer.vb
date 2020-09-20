<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDownload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDownload))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.gpbVidUrlFD = New System.Windows.Forms.GroupBox()
        Me.btnClearAll_FD = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnReqDownLinkFD = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.picMarkFD_Download = New System.Windows.Forms.PictureBox()
        Me.picMarkFD_Paste = New System.Windows.Forms.PictureBox()
        Me.picMarkFD_Copie = New System.Windows.Forms.PictureBox()
        Me.llblClear_varFD = New System.Windows.Forms.LinkLabel()
        Me.llblActualise_varFD = New System.Windows.Forms.LinkLabel()
        Me.llblPaste_varFD = New System.Windows.Forms.LinkLabel()
        Me.btnSettingFD = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgbtnCopieFD = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgbtnDownloadFD = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgbtnPasteFD = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgYouTubeBigFD = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMainInfoFD = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblPremiumFeaturesSM1 = New System.Windows.Forms.Label()
        Me.txtURL_varFD = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cbbFormat_strFD = New System.Windows.Forms.ComboBox()
        Me.cbbQuality_strFD = New System.Windows.Forms.ComboBox()
        Me.gpbVidInfosFD = New System.Windows.Forms.GroupBox()
        Me.lblVidPlaylist_varFD = New System.Windows.Forms.Label()
        Me.lblVidUrl_varFD = New System.Windows.Forms.Label()
        Me.lblVidName_varFD = New System.Windows.Forms.Label()
        Me.lblVidFormat_varFD = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblVidSize_varFD = New System.Windows.Forms.Label()
        Me.lblTextFD4 = New System.Windows.Forms.Label()
        Me.lblTextFD3 = New System.Windows.Forms.Label()
        Me.lblTextFD2 = New System.Windows.Forms.Label()
        Me.lblTextFD1 = New System.Windows.Forms.Label()
        Me.btnDownloadFD = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.NotifyIconDownFinish = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.gpbVidUrlFD.SuspendLayout()
        CType(Me.picMarkFD_Download, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMarkFD_Paste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMarkFD_Copie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettingFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnCopieFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnDownloadFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnPasteFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgYouTubeBigFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMainInfoFD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbVidInfosFD.SuspendLayout()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'gpbVidUrlFD
        '
        Me.gpbVidUrlFD.Controls.Add(Me.btnClearAll_FD)
        Me.gpbVidUrlFD.Controls.Add(Me.btnReqDownLinkFD)
        Me.gpbVidUrlFD.Controls.Add(Me.picMarkFD_Download)
        Me.gpbVidUrlFD.Controls.Add(Me.picMarkFD_Paste)
        Me.gpbVidUrlFD.Controls.Add(Me.picMarkFD_Copie)
        Me.gpbVidUrlFD.Controls.Add(Me.llblClear_varFD)
        Me.gpbVidUrlFD.Controls.Add(Me.llblActualise_varFD)
        Me.gpbVidUrlFD.Controls.Add(Me.llblPaste_varFD)
        Me.gpbVidUrlFD.Controls.Add(Me.btnSettingFD)
        Me.gpbVidUrlFD.Controls.Add(Me.imgbtnCopieFD)
        Me.gpbVidUrlFD.Controls.Add(Me.imgbtnDownloadFD)
        Me.gpbVidUrlFD.Controls.Add(Me.imgbtnPasteFD)
        Me.gpbVidUrlFD.Controls.Add(Me.imgYouTubeBigFD)
        Me.gpbVidUrlFD.Controls.Add(Me.btnMainInfoFD)
        Me.gpbVidUrlFD.Controls.Add(Me.lblPremiumFeaturesSM1)
        Me.gpbVidUrlFD.Controls.Add(Me.txtURL_varFD)
        Me.gpbVidUrlFD.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.gpbVidUrlFD.Location = New System.Drawing.Point(12, 12)
        Me.gpbVidUrlFD.Name = "gpbVidUrlFD"
        Me.gpbVidUrlFD.Size = New System.Drawing.Size(651, 210)
        Me.gpbVidUrlFD.TabIndex = 0
        Me.gpbVidUrlFD.TabStop = False
        Me.gpbVidUrlFD.Text = "Video URL"
        '
        'btnClearAll_FD
        '
        Me.btnClearAll_FD.ActiveBorderThickness = 1
        Me.btnClearAll_FD.ActiveCornerRadius = 15
        Me.btnClearAll_FD.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearAll_FD.ActiveForecolor = System.Drawing.Color.White
        Me.btnClearAll_FD.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearAll_FD.BackColor = System.Drawing.Color.White
        Me.btnClearAll_FD.BackgroundImage = CType(resources.GetObject("btnClearAll_FD.BackgroundImage"), System.Drawing.Image)
        Me.btnClearAll_FD.ButtonText = "Clear All "
        Me.btnClearAll_FD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearAll_FD.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll_FD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearAll_FD.IdleBorderThickness = 1
        Me.btnClearAll_FD.IdleCornerRadius = 20
        Me.btnClearAll_FD.IdleFillColor = System.Drawing.Color.White
        Me.btnClearAll_FD.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearAll_FD.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearAll_FD.Location = New System.Drawing.Point(10, 129)
        Me.btnClearAll_FD.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClearAll_FD.Name = "btnClearAll_FD"
        Me.btnClearAll_FD.Size = New System.Drawing.Size(93, 41)
        Me.btnClearAll_FD.TabIndex = 13
        Me.btnClearAll_FD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReqDownLinkFD
        '
        Me.btnReqDownLinkFD.ActiveBorderThickness = 1
        Me.btnReqDownLinkFD.ActiveCornerRadius = 15
        Me.btnReqDownLinkFD.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnReqDownLinkFD.ActiveForecolor = System.Drawing.Color.White
        Me.btnReqDownLinkFD.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnReqDownLinkFD.BackColor = System.Drawing.Color.White
        Me.btnReqDownLinkFD.BackgroundImage = CType(resources.GetObject("btnReqDownLinkFD.BackgroundImage"), System.Drawing.Image)
        Me.btnReqDownLinkFD.ButtonText = "Request Download"
        Me.btnReqDownLinkFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReqDownLinkFD.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReqDownLinkFD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnReqDownLinkFD.IdleBorderThickness = 1
        Me.btnReqDownLinkFD.IdleCornerRadius = 2
        Me.btnReqDownLinkFD.IdleFillColor = System.Drawing.Color.White
        Me.btnReqDownLinkFD.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnReqDownLinkFD.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnReqDownLinkFD.Location = New System.Drawing.Point(229, 161)
        Me.btnReqDownLinkFD.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReqDownLinkFD.Name = "btnReqDownLinkFD"
        Me.btnReqDownLinkFD.Size = New System.Drawing.Size(181, 41)
        Me.btnReqDownLinkFD.TabIndex = 13
        Me.btnReqDownLinkFD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picMarkFD_Download
        '
        Me.picMarkFD_Download.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Ok_50
        Me.picMarkFD_Download.Location = New System.Drawing.Point(427, 141)
        Me.picMarkFD_Download.Name = "picMarkFD_Download"
        Me.picMarkFD_Download.Size = New System.Drawing.Size(16, 18)
        Me.picMarkFD_Download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMarkFD_Download.TabIndex = 0
        Me.picMarkFD_Download.TabStop = False
        Me.picMarkFD_Download.Visible = False
        '
        'picMarkFD_Paste
        '
        Me.picMarkFD_Paste.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Ok_50
        Me.picMarkFD_Paste.Location = New System.Drawing.Point(313, 141)
        Me.picMarkFD_Paste.Name = "picMarkFD_Paste"
        Me.picMarkFD_Paste.Size = New System.Drawing.Size(16, 18)
        Me.picMarkFD_Paste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMarkFD_Paste.TabIndex = 0
        Me.picMarkFD_Paste.TabStop = False
        Me.picMarkFD_Paste.Visible = False
        '
        'picMarkFD_Copie
        '
        Me.picMarkFD_Copie.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Ok_50
        Me.picMarkFD_Copie.Location = New System.Drawing.Point(205, 141)
        Me.picMarkFD_Copie.Name = "picMarkFD_Copie"
        Me.picMarkFD_Copie.Size = New System.Drawing.Size(16, 18)
        Me.picMarkFD_Copie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMarkFD_Copie.TabIndex = 0
        Me.picMarkFD_Copie.TabStop = False
        Me.picMarkFD_Copie.Visible = False
        '
        'llblClear_varFD
        '
        Me.llblClear_varFD.AutoSize = True
        Me.llblClear_varFD.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.llblClear_varFD.Location = New System.Drawing.Point(343, 58)
        Me.llblClear_varFD.Name = "llblClear_varFD"
        Me.llblClear_varFD.Size = New System.Drawing.Size(49, 20)
        Me.llblClear_varFD.TabIndex = 12
        Me.llblClear_varFD.TabStop = True
        Me.llblClear_varFD.Text = "Clear"
        '
        'llblActualise_varFD
        '
        Me.llblActualise_varFD.AutoSize = True
        Me.llblActualise_varFD.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.llblActualise_varFD.Location = New System.Drawing.Point(398, 58)
        Me.llblActualise_varFD.Name = "llblActualise_varFD"
        Me.llblActualise_varFD.Size = New System.Drawing.Size(76, 20)
        Me.llblActualise_varFD.TabIndex = 12
        Me.llblActualise_varFD.TabStop = True
        Me.llblActualise_varFD.Text = "Actualise"
        '
        'llblPaste_varFD
        '
        Me.llblPaste_varFD.AutoSize = True
        Me.llblPaste_varFD.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.llblPaste_varFD.Location = New System.Drawing.Point(480, 58)
        Me.llblPaste_varFD.Name = "llblPaste_varFD"
        Me.llblPaste_varFD.Size = New System.Drawing.Size(49, 20)
        Me.llblPaste_varFD.TabIndex = 12
        Me.llblPaste_varFD.TabStop = True
        Me.llblPaste_varFD.Text = "Paste"
        '
        'btnSettingFD
        '
        Me.btnSettingFD.BackColor = System.Drawing.Color.White
        Me.btnSettingFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettingFD.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Settings_64
        Me.btnSettingFD.ImageActive = Nothing
        Me.btnSettingFD.Location = New System.Drawing.Point(607, 179)
        Me.btnSettingFD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSettingFD.Name = "btnSettingFD"
        Me.btnSettingFD.Size = New System.Drawing.Size(23, 23)
        Me.btnSettingFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSettingFD.TabIndex = 11
        Me.btnSettingFD.TabStop = False
        Me.btnSettingFD.Zoom = 10
        '
        'imgbtnCopieFD
        '
        Me.imgbtnCopieFD.BackColor = System.Drawing.Color.White
        Me.imgbtnCopieFD.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Copy_Link_64
        Me.imgbtnCopieFD.ImageActive = Nothing
        Me.imgbtnCopieFD.Location = New System.Drawing.Point(185, 89)
        Me.imgbtnCopieFD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnCopieFD.Name = "imgbtnCopieFD"
        Me.imgbtnCopieFD.Size = New System.Drawing.Size(55, 49)
        Me.imgbtnCopieFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnCopieFD.TabIndex = 11
        Me.imgbtnCopieFD.TabStop = False
        Me.imgbtnCopieFD.Zoom = 10
        '
        'imgbtnDownloadFD
        '
        Me.imgbtnDownloadFD.BackColor = System.Drawing.Color.White
        Me.imgbtnDownloadFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnDownloadFD.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Download_64
        Me.imgbtnDownloadFD.ImageActive = Nothing
        Me.imgbtnDownloadFD.Location = New System.Drawing.Point(405, 89)
        Me.imgbtnDownloadFD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnDownloadFD.Name = "imgbtnDownloadFD"
        Me.imgbtnDownloadFD.Size = New System.Drawing.Size(55, 49)
        Me.imgbtnDownloadFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnDownloadFD.TabIndex = 11
        Me.imgbtnDownloadFD.TabStop = False
        Me.imgbtnDownloadFD.Zoom = 10
        '
        'imgbtnPasteFD
        '
        Me.imgbtnPasteFD.BackColor = System.Drawing.Color.White
        Me.imgbtnPasteFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnPasteFD.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Paste_64
        Me.imgbtnPasteFD.ImageActive = Nothing
        Me.imgbtnPasteFD.Location = New System.Drawing.Point(297, 89)
        Me.imgbtnPasteFD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnPasteFD.Name = "imgbtnPasteFD"
        Me.imgbtnPasteFD.Size = New System.Drawing.Size(55, 49)
        Me.imgbtnPasteFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnPasteFD.TabIndex = 11
        Me.imgbtnPasteFD.TabStop = False
        Me.imgbtnPasteFD.Zoom = 10
        '
        'imgYouTubeBigFD
        '
        Me.imgYouTubeBigFD.BackColor = System.Drawing.Color.White
        Me.imgYouTubeBigFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgYouTubeBigFD.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.Solid_color_You_Tube_logo
        Me.imgYouTubeBigFD.ImageActive = Nothing
        Me.imgYouTubeBigFD.Location = New System.Drawing.Point(6, 179)
        Me.imgYouTubeBigFD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgYouTubeBigFD.Name = "imgYouTubeBigFD"
        Me.imgYouTubeBigFD.Size = New System.Drawing.Size(50, 23)
        Me.imgYouTubeBigFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgYouTubeBigFD.TabIndex = 11
        Me.imgYouTubeBigFD.TabStop = False
        Me.imgYouTubeBigFD.Zoom = 10
        '
        'btnMainInfoFD
        '
        Me.btnMainInfoFD.BackColor = System.Drawing.Color.White
        Me.btnMainInfoFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainInfoFD.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.btnMainInfoFD.ImageActive = Nothing
        Me.btnMainInfoFD.Location = New System.Drawing.Point(578, 179)
        Me.btnMainInfoFD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMainInfoFD.Name = "btnMainInfoFD"
        Me.btnMainInfoFD.Size = New System.Drawing.Size(23, 23)
        Me.btnMainInfoFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMainInfoFD.TabIndex = 11
        Me.btnMainInfoFD.TabStop = False
        Me.btnMainInfoFD.Zoom = 10
        '
        'lblPremiumFeaturesSM1
        '
        Me.lblPremiumFeaturesSM1.AutoSize = True
        Me.lblPremiumFeaturesSM1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM1.Location = New System.Drawing.Point(95, 33)
        Me.lblPremiumFeaturesSM1.Name = "lblPremiumFeaturesSM1"
        Me.lblPremiumFeaturesSM1.Size = New System.Drawing.Size(48, 20)
        Me.lblPremiumFeaturesSM1.TabIndex = 3
        Me.lblPremiumFeaturesSM1.Text = "URL : "
        '
        'txtURL_varFD
        '
        Me.txtURL_varFD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtURL_varFD.Enabled = False
        Me.txtURL_varFD.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtURL_varFD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtURL_varFD.HintForeColor = System.Drawing.Color.Empty
        Me.txtURL_varFD.HintText = ""
        Me.txtURL_varFD.isPassword = False
        Me.txtURL_varFD.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtURL_varFD.LineIdleColor = System.Drawing.Color.Gray
        Me.txtURL_varFD.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtURL_varFD.LineThickness = 3
        Me.txtURL_varFD.Location = New System.Drawing.Point(150, 20)
        Me.txtURL_varFD.Margin = New System.Windows.Forms.Padding(4)
        Me.txtURL_varFD.Name = "txtURL_varFD"
        Me.txtURL_varFD.Size = New System.Drawing.Size(379, 33)
        Me.txtURL_varFD.TabIndex = 0
        Me.txtURL_varFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cbbFormat_strFD
        '
        Me.cbbFormat_strFD.FormattingEnabled = True
        Me.cbbFormat_strFD.Location = New System.Drawing.Point(451, 398)
        Me.cbbFormat_strFD.Name = "cbbFormat_strFD"
        Me.cbbFormat_strFD.Size = New System.Drawing.Size(212, 21)
        Me.cbbFormat_strFD.TabIndex = 15
        '
        'cbbQuality_strFD
        '
        Me.cbbQuality_strFD.FormattingEnabled = True
        Me.cbbQuality_strFD.Location = New System.Drawing.Point(22, 398)
        Me.cbbQuality_strFD.Name = "cbbQuality_strFD"
        Me.cbbQuality_strFD.Size = New System.Drawing.Size(211, 21)
        Me.cbbQuality_strFD.TabIndex = 14
        '
        'gpbVidInfosFD
        '
        Me.gpbVidInfosFD.Controls.Add(Me.lblVidPlaylist_varFD)
        Me.gpbVidInfosFD.Controls.Add(Me.lblVidUrl_varFD)
        Me.gpbVidInfosFD.Controls.Add(Me.lblVidName_varFD)
        Me.gpbVidInfosFD.Controls.Add(Me.lblVidFormat_varFD)
        Me.gpbVidInfosFD.Controls.Add(Me.Label9)
        Me.gpbVidInfosFD.Controls.Add(Me.lblVidSize_varFD)
        Me.gpbVidInfosFD.Controls.Add(Me.lblTextFD4)
        Me.gpbVidInfosFD.Controls.Add(Me.lblTextFD3)
        Me.gpbVidInfosFD.Controls.Add(Me.lblTextFD2)
        Me.gpbVidInfosFD.Controls.Add(Me.lblTextFD1)
        Me.gpbVidInfosFD.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.gpbVidInfosFD.Location = New System.Drawing.Point(12, 222)
        Me.gpbVidInfosFD.Name = "gpbVidInfosFD"
        Me.gpbVidInfosFD.Size = New System.Drawing.Size(651, 155)
        Me.gpbVidInfosFD.TabIndex = 0
        Me.gpbVidInfosFD.TabStop = False
        Me.gpbVidInfosFD.Text = "Video Informations "
        Me.gpbVidInfosFD.Visible = False
        '
        'lblVidPlaylist_varFD
        '
        Me.lblVidPlaylist_varFD.AutoSize = True
        Me.lblVidPlaylist_varFD.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidPlaylist_varFD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblVidPlaylist_varFD.Location = New System.Drawing.Point(229, 93)
        Me.lblVidPlaylist_varFD.Name = "lblVidPlaylist_varFD"
        Me.lblVidPlaylist_varFD.Size = New System.Drawing.Size(30, 20)
        Me.lblVidPlaylist_varFD.TabIndex = 3
        Me.lblVidPlaylist_varFD.Text = "No"
        '
        'lblVidUrl_varFD
        '
        Me.lblVidUrl_varFD.AutoSize = True
        Me.lblVidUrl_varFD.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidUrl_varFD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblVidUrl_varFD.Location = New System.Drawing.Point(229, 61)
        Me.lblVidUrl_varFD.Name = "lblVidUrl_varFD"
        Me.lblVidUrl_varFD.Size = New System.Drawing.Size(370, 20)
        Me.lblVidUrl_varFD.TabIndex = 3
        Me.lblVidUrl_varFD.Text = "https://www.youtube.com/watch?v=mSLuJYtl89Y"
        '
        'lblVidName_varFD
        '
        Me.lblVidName_varFD.AutoSize = True
        Me.lblVidName_varFD.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidName_varFD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblVidName_varFD.Location = New System.Drawing.Point(230, 31)
        Me.lblVidName_varFD.Name = "lblVidName_varFD"
        Me.lblVidName_varFD.Size = New System.Drawing.Size(240, 20)
        Me.lblVidName_varFD.TabIndex = 3
        Me.lblVidName_varFD.Text = "Lensko - Let's Go! [NCS Release]"
        '
        'lblVidFormat_varFD
        '
        Me.lblVidFormat_varFD.AutoSize = True
        Me.lblVidFormat_varFD.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidFormat_varFD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblVidFormat_varFD.Location = New System.Drawing.Point(454, 122)
        Me.lblVidFormat_varFD.Name = "lblVidFormat_varFD"
        Me.lblVidFormat_varFD.Size = New System.Drawing.Size(45, 20)
        Me.lblVidFormat_varFD.TabIndex = 3
        Me.lblVidFormat_varFD.Text = ".MP4"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(325, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Video Format :  "
        '
        'lblVidSize_varFD
        '
        Me.lblVidSize_varFD.AutoSize = True
        Me.lblVidSize_varFD.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidSize_varFD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblVidSize_varFD.Location = New System.Drawing.Point(216, 122)
        Me.lblVidSize_varFD.Name = "lblVidSize_varFD"
        Me.lblVidSize_varFD.Size = New System.Drawing.Size(63, 20)
        Me.lblVidSize_varFD.TabIndex = 3
        Me.lblVidSize_varFD.Text = "1.25 GB"
        '
        'lblTextFD4
        '
        Me.lblTextFD4.AutoSize = True
        Me.lblTextFD4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextFD4.Location = New System.Drawing.Point(125, 122)
        Me.lblTextFD4.Name = "lblTextFD4"
        Me.lblTextFD4.Size = New System.Drawing.Size(99, 20)
        Me.lblTextFD4.TabIndex = 3
        Me.lblTextFD4.Text = "Video Size :  "
        '
        'lblTextFD3
        '
        Me.lblTextFD3.AutoSize = True
        Me.lblTextFD3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextFD3.Location = New System.Drawing.Point(22, 93)
        Me.lblTextFD3.Name = "lblTextFD3"
        Me.lblTextFD3.Size = New System.Drawing.Size(204, 20)
        Me.lblTextFD3.TabIndex = 3
        Me.lblTextFD3.Text = "Video Fetch From Playlist :  "
        '
        'lblTextFD2
        '
        Me.lblTextFD2.AutoSize = True
        Me.lblTextFD2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextFD2.Location = New System.Drawing.Point(126, 61)
        Me.lblTextFD2.Name = "lblTextFD2"
        Me.lblTextFD2.Size = New System.Drawing.Size(100, 20)
        Me.lblTextFD2.TabIndex = 3
        Me.lblTextFD2.Text = "Video URL :  "
        '
        'lblTextFD1
        '
        Me.lblTextFD1.AutoSize = True
        Me.lblTextFD1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextFD1.Location = New System.Drawing.Point(111, 31)
        Me.lblTextFD1.Name = "lblTextFD1"
        Me.lblTextFD1.Size = New System.Drawing.Size(113, 20)
        Me.lblTextFD1.TabIndex = 3
        Me.lblTextFD1.Text = "Video Name : "
        '
        'btnDownloadFD
        '
        Me.btnDownloadFD.ActiveBorderThickness = 1
        Me.btnDownloadFD.ActiveCornerRadius = 15
        Me.btnDownloadFD.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnDownloadFD.ActiveForecolor = System.Drawing.Color.White
        Me.btnDownloadFD.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnDownloadFD.BackColor = System.Drawing.Color.White
        Me.btnDownloadFD.BackgroundImage = CType(resources.GetObject("btnDownloadFD.BackgroundImage"), System.Drawing.Image)
        Me.btnDownloadFD.ButtonText = "Download"
        Me.btnDownloadFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownloadFD.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownloadFD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnDownloadFD.IdleBorderThickness = 1
        Me.btnDownloadFD.IdleCornerRadius = 2
        Me.btnDownloadFD.IdleFillColor = System.Drawing.Color.White
        Me.btnDownloadFD.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnDownloadFD.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnDownloadFD.Location = New System.Drawing.Point(246, 385)
        Me.btnDownloadFD.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDownloadFD.Name = "btnDownloadFD"
        Me.btnDownloadFD.Size = New System.Drawing.Size(181, 41)
        Me.btnDownloadFD.TabIndex = 13
        Me.btnDownloadFD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDownloadFD.Visible = False
        '
        'NotifyIconDownFinish
        '
        Me.NotifyIconDownFinish.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIconDownFinish.BalloonTipText = "Please Check Your Path "
        Me.NotifyIconDownFinish.BalloonTipTitle = "Download Sucessfully Completed"
        Me.NotifyIconDownFinish.Icon = CType(resources.GetObject("NotifyIconDownFinish.Icon"), System.Drawing.Icon)
        Me.NotifyIconDownFinish.Text = "NotifyIconDownFinish"
        Me.NotifyIconDownFinish.Visible = True
        '
        'frmDownload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(675, 436)
        Me.Controls.Add(Me.cbbFormat_strFD)
        Me.Controls.Add(Me.cbbQuality_strFD)
        Me.Controls.Add(Me.btnDownloadFD)
        Me.Controls.Add(Me.gpbVidInfosFD)
        Me.Controls.Add(Me.gpbVidUrlFD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDownload"
        Me.Text = "frmDownload"
        Me.gpbVidUrlFD.ResumeLayout(False)
        Me.gpbVidUrlFD.PerformLayout()
        CType(Me.picMarkFD_Download, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMarkFD_Paste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMarkFD_Copie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettingFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnCopieFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnDownloadFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnPasteFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgYouTubeBigFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMainInfoFD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbVidInfosFD.ResumeLayout(False)
        Me.gpbVidInfosFD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents gpbVidInfosFD As GroupBox
    Friend WithEvents gpbVidUrlFD As GroupBox
    Friend WithEvents txtURL_varFD As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblPremiumFeaturesSM1 As Label
    Friend WithEvents btnSettingFD As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgbtnPasteFD As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgYouTubeBigFD As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMainInfoFD As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents picMarkFD_Download As PictureBox
    Friend WithEvents picMarkFD_Paste As PictureBox
    Friend WithEvents picMarkFD_Copie As PictureBox
    Friend WithEvents llblClear_varFD As LinkLabel
    Friend WithEvents llblActualise_varFD As LinkLabel
    Friend WithEvents llblPaste_varFD As LinkLabel
    Friend WithEvents imgbtnCopieFD As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgbtnDownloadFD As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblTextFD1 As Label
    Friend WithEvents lblVidPlaylist_varFD As Label
    Friend WithEvents lblVidUrl_varFD As Label
    Friend WithEvents lblVidName_varFD As Label
    Friend WithEvents lblTextFD4 As Label
    Friend WithEvents lblTextFD3 As Label
    Friend WithEvents lblTextFD2 As Label
    Friend WithEvents lblVidFormat_varFD As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblVidSize_varFD As Label
    Friend WithEvents btnReqDownLinkFD As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnDownloadFD As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cbbFormat_strFD As ComboBox
    Friend WithEvents cbbQuality_strFD As ComboBox
    Friend WithEvents NotifyIconDownFinish As NotifyIcon
    Friend WithEvents btnClearAll_FD As Bunifu.Framework.UI.BunifuThinButton2
End Class
