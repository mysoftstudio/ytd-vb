<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlay))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlButtonsFPS = New System.Windows.Forms.Panel()
        Me.imgbtnFPS_VolumeUp = New System.Windows.Forms.PictureBox()
        Me.NoFunctionFPV7 = New System.Windows.Forms.PictureBox()
        Me.imgbtnFPS_Pause = New System.Windows.Forms.PictureBox()
        Me.imgbtnFPS_Play = New System.Windows.Forms.PictureBox()
        Me.NoFunctionFPV6 = New System.Windows.Forms.PictureBox()
        Me.imgbtnFPS_Stop = New System.Windows.Forms.PictureBox()
        Me.imgbtnFPS_VolumeDown = New System.Windows.Forms.PictureBox()
        Me.NoFunctionFPV4 = New System.Windows.Forms.PictureBox()
        Me.NoFunctionFPV5 = New System.Windows.Forms.PictureBox()
        Me.pnlMenuFPS = New System.Windows.Forms.Panel()
        Me.imgbtnFPV_YouTube = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgbtnFPV_Setting = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgbtnFPV_MoreInfos = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblTextFPV1 = New System.Windows.Forms.Label()
        Me.btnPlayFPS = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnImportFPV = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NoFunctionFPV1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NoFunctionFPV3 = New System.Windows.Forms.PictureBox()
        Me.NoFunctionFPV35 = New System.Windows.Forms.Panel()
        Me.NoFunctionFPV2 = New System.Windows.Forms.PictureBox()
        Me.picBackFontFPS2 = New System.Windows.Forms.PictureBox()
        Me.picBackFontFPS = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.AxVLCPlugin21 = New AxAXVLC.AxVLCPlugin2()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.NotifyIconDownFinish = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.pnlButtonsFPS.SuspendLayout()
        CType(Me.imgbtnFPS_VolumeUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoFunctionFPV7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnFPS_Pause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnFPS_Play, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoFunctionFPV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnFPS_Stop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnFPS_VolumeDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoFunctionFPV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoFunctionFPV5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenuFPS.SuspendLayout()
        CType(Me.imgbtnFPV_YouTube, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnFPV_Setting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnFPV_MoreInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoFunctionFPV3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NoFunctionFPV35.SuspendLayout()
        CType(Me.NoFunctionFPV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackFontFPS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackFontFPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'pnlButtonsFPS
        '
        Me.pnlButtonsFPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlButtonsFPS.Controls.Add(Me.imgbtnFPS_VolumeUp)
        Me.pnlButtonsFPS.Controls.Add(Me.NoFunctionFPV7)
        Me.pnlButtonsFPS.Controls.Add(Me.imgbtnFPS_Pause)
        Me.pnlButtonsFPS.Controls.Add(Me.imgbtnFPS_Play)
        Me.pnlButtonsFPS.Controls.Add(Me.NoFunctionFPV6)
        Me.pnlButtonsFPS.Controls.Add(Me.imgbtnFPS_Stop)
        Me.pnlButtonsFPS.Controls.Add(Me.imgbtnFPS_VolumeDown)
        Me.pnlButtonsFPS.Controls.Add(Me.NoFunctionFPV4)
        Me.pnlButtonsFPS.Controls.Add(Me.NoFunctionFPV5)
        Me.pnlButtonsFPS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtonsFPS.Location = New System.Drawing.Point(177, 377)
        Me.pnlButtonsFPS.Name = "pnlButtonsFPS"
        Me.pnlButtonsFPS.Size = New System.Drawing.Size(498, 59)
        Me.pnlButtonsFPS.TabIndex = 0
        '
        'imgbtnFPS_VolumeUp
        '
        Me.imgbtnFPS_VolumeUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgbtnFPS_VolumeUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFPS_VolumeUp.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.volume_up_48
        Me.imgbtnFPS_VolumeUp.Location = New System.Drawing.Point(399, 23)
        Me.imgbtnFPS_VolumeUp.Name = "imgbtnFPS_VolumeUp"
        Me.imgbtnFPS_VolumeUp.Size = New System.Drawing.Size(29, 24)
        Me.imgbtnFPS_VolumeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFPS_VolumeUp.TabIndex = 14
        Me.imgbtnFPS_VolumeUp.TabStop = False
        '
        'NoFunctionFPV7
        '
        Me.NoFunctionFPV7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NoFunctionFPV7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NoFunctionFPV7.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.repeat_48
        Me.NoFunctionFPV7.Location = New System.Drawing.Point(320, 23)
        Me.NoFunctionFPV7.Name = "NoFunctionFPV7"
        Me.NoFunctionFPV7.Size = New System.Drawing.Size(29, 24)
        Me.NoFunctionFPV7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NoFunctionFPV7.TabIndex = 14
        Me.NoFunctionFPV7.TabStop = False
        '
        'imgbtnFPS_Pause
        '
        Me.imgbtnFPS_Pause.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgbtnFPS_Pause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFPS_Pause.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.pause_48
        Me.imgbtnFPS_Pause.Location = New System.Drawing.Point(220, 9)
        Me.imgbtnFPS_Pause.Name = "imgbtnFPS_Pause"
        Me.imgbtnFPS_Pause.Size = New System.Drawing.Size(43, 40)
        Me.imgbtnFPS_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFPS_Pause.TabIndex = 9
        Me.imgbtnFPS_Pause.TabStop = False
        Me.imgbtnFPS_Pause.Visible = False
        '
        'imgbtnFPS_Play
        '
        Me.imgbtnFPS_Play.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgbtnFPS_Play.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFPS_Play.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.play_48
        Me.imgbtnFPS_Play.Location = New System.Drawing.Point(220, 9)
        Me.imgbtnFPS_Play.Name = "imgbtnFPS_Play"
        Me.imgbtnFPS_Play.Size = New System.Drawing.Size(43, 40)
        Me.imgbtnFPS_Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFPS_Play.TabIndex = 9
        Me.imgbtnFPS_Play.TabStop = False
        '
        'NoFunctionFPV6
        '
        Me.NoFunctionFPV6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NoFunctionFPV6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NoFunctionFPV6.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.end_48
        Me.NoFunctionFPV6.Location = New System.Drawing.Point(290, 23)
        Me.NoFunctionFPV6.Name = "NoFunctionFPV6"
        Me.NoFunctionFPV6.Size = New System.Drawing.Size(29, 24)
        Me.NoFunctionFPV6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NoFunctionFPV6.TabIndex = 13
        Me.NoFunctionFPV6.TabStop = False
        '
        'imgbtnFPS_Stop
        '
        Me.imgbtnFPS_Stop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgbtnFPS_Stop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFPS_Stop.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.stop_48
        Me.imgbtnFPS_Stop.Location = New System.Drawing.Point(259, 23)
        Me.imgbtnFPS_Stop.Name = "imgbtnFPS_Stop"
        Me.imgbtnFPS_Stop.Size = New System.Drawing.Size(29, 24)
        Me.imgbtnFPS_Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFPS_Stop.TabIndex = 10
        Me.imgbtnFPS_Stop.TabStop = False
        '
        'imgbtnFPS_VolumeDown
        '
        Me.imgbtnFPS_VolumeDown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgbtnFPS_VolumeDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFPS_VolumeDown.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.volume_down_48
        Me.imgbtnFPS_VolumeDown.Location = New System.Drawing.Point(72, 25)
        Me.imgbtnFPS_VolumeDown.Name = "imgbtnFPS_VolumeDown"
        Me.imgbtnFPS_VolumeDown.Size = New System.Drawing.Size(29, 24)
        Me.imgbtnFPS_VolumeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFPS_VolumeDown.TabIndex = 12
        Me.imgbtnFPS_VolumeDown.TabStop = False
        '
        'NoFunctionFPV4
        '
        Me.NoFunctionFPV4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NoFunctionFPV4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NoFunctionFPV4.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.shuffle_48
        Me.NoFunctionFPV4.Location = New System.Drawing.Point(155, 23)
        Me.NoFunctionFPV4.Name = "NoFunctionFPV4"
        Me.NoFunctionFPV4.Size = New System.Drawing.Size(29, 24)
        Me.NoFunctionFPV4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NoFunctionFPV4.TabIndex = 12
        Me.NoFunctionFPV4.TabStop = False
        '
        'NoFunctionFPV5
        '
        Me.NoFunctionFPV5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NoFunctionFPV5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NoFunctionFPV5.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.skip_to_start_48
        Me.NoFunctionFPV5.Location = New System.Drawing.Point(185, 23)
        Me.NoFunctionFPV5.Name = "NoFunctionFPV5"
        Me.NoFunctionFPV5.Size = New System.Drawing.Size(29, 24)
        Me.NoFunctionFPV5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NoFunctionFPV5.TabIndex = 11
        Me.NoFunctionFPV5.TabStop = False
        '
        'pnlMenuFPS
        '
        Me.pnlMenuFPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlMenuFPS.Controls.Add(Me.imgbtnFPV_YouTube)
        Me.pnlMenuFPS.Controls.Add(Me.imgbtnFPV_Setting)
        Me.pnlMenuFPS.Controls.Add(Me.imgbtnFPV_MoreInfos)
        Me.pnlMenuFPS.Controls.Add(Me.lblTextFPV1)
        Me.pnlMenuFPS.Controls.Add(Me.btnPlayFPS)
        Me.pnlMenuFPS.Controls.Add(Me.btnImportFPV)
        Me.pnlMenuFPS.Controls.Add(Me.NoFunctionFPV1)
        Me.pnlMenuFPS.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenuFPS.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenuFPS.Name = "pnlMenuFPS"
        Me.pnlMenuFPS.Size = New System.Drawing.Size(177, 436)
        Me.pnlMenuFPS.TabIndex = 1
        '
        'imgbtnFPV_YouTube
        '
        Me.imgbtnFPV_YouTube.BackColor = System.Drawing.Color.Transparent
        Me.imgbtnFPV_YouTube.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFPV_YouTube.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_YouTube_48
        Me.imgbtnFPV_YouTube.ImageActive = Nothing
        Me.imgbtnFPV_YouTube.Location = New System.Drawing.Point(60, 400)
        Me.imgbtnFPV_YouTube.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnFPV_YouTube.Name = "imgbtnFPV_YouTube"
        Me.imgbtnFPV_YouTube.Size = New System.Drawing.Size(23, 23)
        Me.imgbtnFPV_YouTube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFPV_YouTube.TabIndex = 26
        Me.imgbtnFPV_YouTube.TabStop = False
        Me.imgbtnFPV_YouTube.Zoom = 10
        '
        'imgbtnFPV_Setting
        '
        Me.imgbtnFPV_Setting.BackColor = System.Drawing.Color.Transparent
        Me.imgbtnFPV_Setting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFPV_Setting.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Settings_64
        Me.imgbtnFPV_Setting.ImageActive = Nothing
        Me.imgbtnFPV_Setting.Location = New System.Drawing.Point(118, 400)
        Me.imgbtnFPV_Setting.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnFPV_Setting.Name = "imgbtnFPV_Setting"
        Me.imgbtnFPV_Setting.Size = New System.Drawing.Size(23, 23)
        Me.imgbtnFPV_Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFPV_Setting.TabIndex = 22
        Me.imgbtnFPV_Setting.TabStop = False
        Me.imgbtnFPV_Setting.Zoom = 10
        '
        'imgbtnFPV_MoreInfos
        '
        Me.imgbtnFPV_MoreInfos.BackColor = System.Drawing.Color.Transparent
        Me.imgbtnFPV_MoreInfos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFPV_MoreInfos.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.imgbtnFPV_MoreInfos.ImageActive = Nothing
        Me.imgbtnFPV_MoreInfos.Location = New System.Drawing.Point(89, 400)
        Me.imgbtnFPV_MoreInfos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnFPV_MoreInfos.Name = "imgbtnFPV_MoreInfos"
        Me.imgbtnFPV_MoreInfos.Size = New System.Drawing.Size(23, 23)
        Me.imgbtnFPV_MoreInfos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFPV_MoreInfos.TabIndex = 23
        Me.imgbtnFPV_MoreInfos.TabStop = False
        Me.imgbtnFPV_MoreInfos.Zoom = 10
        '
        'lblTextFPV1
        '
        Me.lblTextFPV1.AutoSize = True
        Me.lblTextFPV1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextFPV1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblTextFPV1.Location = New System.Drawing.Point(12, 15)
        Me.lblTextFPV1.Name = "lblTextFPV1"
        Me.lblTextFPV1.Size = New System.Drawing.Size(120, 19)
        Me.lblTextFPV1.TabIndex = 20
        Me.lblTextFPV1.Text = "Now playing..."
        '
        'btnPlayFPS
        '
        Me.btnPlayFPS.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnPlayFPS.BackColor = System.Drawing.Color.Transparent
        Me.btnPlayFPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlayFPS.BorderRadius = 0
        Me.btnPlayFPS.ButtonText = "Now Playing"
        Me.btnPlayFPS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlayFPS.DisabledColor = System.Drawing.Color.Gray
        Me.btnPlayFPS.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPlayFPS.Iconimage = Global.MySoft_YouTube_Downloader.My.Resources.Resources.play_48
        Me.btnPlayFPS.Iconimage_right = Nothing
        Me.btnPlayFPS.Iconimage_right_Selected = Nothing
        Me.btnPlayFPS.Iconimage_Selected = Nothing
        Me.btnPlayFPS.IconMarginLeft = 0
        Me.btnPlayFPS.IconMarginRight = 0
        Me.btnPlayFPS.IconRightVisible = True
        Me.btnPlayFPS.IconRightZoom = 0R
        Me.btnPlayFPS.IconVisible = True
        Me.btnPlayFPS.IconZoom = 70.0R
        Me.btnPlayFPS.IsTab = False
        Me.btnPlayFPS.Location = New System.Drawing.Point(4, 85)
        Me.btnPlayFPS.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlayFPS.Name = "btnPlayFPS"
        Me.btnPlayFPS.Normalcolor = System.Drawing.Color.Transparent
        Me.btnPlayFPS.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnPlayFPS.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPlayFPS.selected = False
        Me.btnPlayFPS.Size = New System.Drawing.Size(221, 50)
        Me.btnPlayFPS.TabIndex = 9
        Me.btnPlayFPS.Text = "Now Playing"
        Me.btnPlayFPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlayFPS.Textcolor = System.Drawing.Color.White
        Me.btnPlayFPS.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        '
        'btnImportFPV
        '
        Me.btnImportFPV.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnImportFPV.BackColor = System.Drawing.Color.Transparent
        Me.btnImportFPV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportFPV.BorderRadius = 0
        Me.btnImportFPV.ButtonText = "Import Music/Video"
        Me.btnImportFPV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportFPV.DisabledColor = System.Drawing.Color.Gray
        Me.btnImportFPV.Iconcolor = System.Drawing.Color.Transparent
        Me.btnImportFPV.Iconimage = Global.MySoft_YouTube_Downloader.My.Resources.Resources.import_48
        Me.btnImportFPV.Iconimage_right = Nothing
        Me.btnImportFPV.Iconimage_right_Selected = Nothing
        Me.btnImportFPV.Iconimage_Selected = Nothing
        Me.btnImportFPV.IconMarginLeft = 0
        Me.btnImportFPV.IconMarginRight = 0
        Me.btnImportFPV.IconRightVisible = True
        Me.btnImportFPV.IconRightZoom = 0R
        Me.btnImportFPV.IconVisible = True
        Me.btnImportFPV.IconZoom = 70.0R
        Me.btnImportFPV.IsTab = False
        Me.btnImportFPV.Location = New System.Drawing.Point(2, 143)
        Me.btnImportFPV.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImportFPV.Name = "btnImportFPV"
        Me.btnImportFPV.Normalcolor = System.Drawing.Color.Transparent
        Me.btnImportFPV.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnImportFPV.OnHoverTextColor = System.Drawing.Color.White
        Me.btnImportFPV.selected = False
        Me.btnImportFPV.Size = New System.Drawing.Size(219, 50)
        Me.btnImportFPV.TabIndex = 9
        Me.btnImportFPV.Text = "Import Music/Video"
        Me.btnImportFPV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportFPV.Textcolor = System.Drawing.Color.White
        Me.btnImportFPV.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        '
        'NoFunctionFPV1
        '
        Me.NoFunctionFPV1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.NoFunctionFPV1.BackColor = System.Drawing.Color.Transparent
        Me.NoFunctionFPV1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NoFunctionFPV1.BorderRadius = 0
        Me.NoFunctionFPV1.ButtonText = "MyPlayList"
        Me.NoFunctionFPV1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NoFunctionFPV1.DisabledColor = System.Drawing.Color.Gray
        Me.NoFunctionFPV1.Iconcolor = System.Drawing.Color.Transparent
        Me.NoFunctionFPV1.Iconimage = Global.MySoft_YouTube_Downloader.My.Resources.Resources.playlist_48
        Me.NoFunctionFPV1.Iconimage_right = Nothing
        Me.NoFunctionFPV1.Iconimage_right_Selected = Nothing
        Me.NoFunctionFPV1.Iconimage_Selected = Nothing
        Me.NoFunctionFPV1.IconMarginLeft = 0
        Me.NoFunctionFPV1.IconMarginRight = 0
        Me.NoFunctionFPV1.IconRightVisible = True
        Me.NoFunctionFPV1.IconRightZoom = 0R
        Me.NoFunctionFPV1.IconVisible = True
        Me.NoFunctionFPV1.IconZoom = 70.0R
        Me.NoFunctionFPV1.IsTab = False
        Me.NoFunctionFPV1.Location = New System.Drawing.Point(2, 201)
        Me.NoFunctionFPV1.Margin = New System.Windows.Forms.Padding(4)
        Me.NoFunctionFPV1.Name = "NoFunctionFPV1"
        Me.NoFunctionFPV1.Normalcolor = System.Drawing.Color.Transparent
        Me.NoFunctionFPV1.OnHovercolor = System.Drawing.Color.Tomato
        Me.NoFunctionFPV1.OnHoverTextColor = System.Drawing.Color.White
        Me.NoFunctionFPV1.selected = False
        Me.NoFunctionFPV1.Size = New System.Drawing.Size(221, 50)
        Me.NoFunctionFPV1.TabIndex = 9
        Me.NoFunctionFPV1.Text = "MyPlayList"
        Me.NoFunctionFPV1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NoFunctionFPV1.Textcolor = System.Drawing.Color.White
        Me.NoFunctionFPV1.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        '
        'NoFunctionFPV3
        '
        Me.NoFunctionFPV3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.NoFunctionFPV3.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.NoFunctionFPV3.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.fast_forward_48
        Me.NoFunctionFPV3.Location = New System.Drawing.Point(413, 0)
        Me.NoFunctionFPV3.Name = "NoFunctionFPV3"
        Me.NoFunctionFPV3.Size = New System.Drawing.Size(34, 18)
        Me.NoFunctionFPV3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NoFunctionFPV3.TabIndex = 16
        Me.NoFunctionFPV3.TabStop = False
        '
        'NoFunctionFPV35
        '
        Me.NoFunctionFPV35.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.NoFunctionFPV35.Controls.Add(Me.NoFunctionFPV2)
        Me.NoFunctionFPV35.Controls.Add(Me.NoFunctionFPV3)
        Me.NoFunctionFPV35.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NoFunctionFPV35.Location = New System.Drawing.Point(177, 359)
        Me.NoFunctionFPV35.Name = "NoFunctionFPV35"
        Me.NoFunctionFPV35.Size = New System.Drawing.Size(498, 18)
        Me.NoFunctionFPV35.TabIndex = 17
        '
        'NoFunctionFPV2
        '
        Me.NoFunctionFPV2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.NoFunctionFPV2.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.NoFunctionFPV2.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.fast_backward_48
        Me.NoFunctionFPV2.Location = New System.Drawing.Point(0, 0)
        Me.NoFunctionFPV2.Name = "NoFunctionFPV2"
        Me.NoFunctionFPV2.Size = New System.Drawing.Size(34, 18)
        Me.NoFunctionFPV2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NoFunctionFPV2.TabIndex = 16
        Me.NoFunctionFPV2.TabStop = False
        '
        'picBackFontFPS2
        '
        Me.picBackFontFPS2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picBackFontFPS2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.picBackFontFPS2.BackgroundImage = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Video_Call_64
        Me.picBackFontFPS2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picBackFontFPS2.Location = New System.Drawing.Point(339, 61)
        Me.picBackFontFPS2.Name = "picBackFontFPS2"
        Me.picBackFontFPS2.Size = New System.Drawing.Size(241, 239)
        Me.picBackFontFPS2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBackFontFPS2.TabIndex = 18
        Me.picBackFontFPS2.TabStop = False
        '
        'picBackFontFPS
        '
        Me.picBackFontFPS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picBackFontFPS.BackColor = System.Drawing.Color.Transparent
        Me.picBackFontFPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picBackFontFPS.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.albumartbg
        Me.picBackFontFPS.Location = New System.Drawing.Point(320, 15)
        Me.picBackFontFPS.Name = "picBackFontFPS"
        Me.picBackFontFPS.Size = New System.Drawing.Size(275, 303)
        Me.picBackFontFPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBackFontFPS.TabIndex = 19
        Me.picBackFontFPS.TabStop = False
        '
        'AxVLCPlugin21
        '
        Me.AxVLCPlugin21.Dock = System.Windows.Forms.DockStyle.Top
        Me.AxVLCPlugin21.Enabled = True
        Me.AxVLCPlugin21.Location = New System.Drawing.Point(177, 0)
        Me.AxVLCPlugin21.Name = "AxVLCPlugin21"
        Me.AxVLCPlugin21.OcxState = CType(resources.GetObject("AxVLCPlugin21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPlugin21.Size = New System.Drawing.Size(498, 359)
        Me.AxVLCPlugin21.TabIndex = 20
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'NotifyIconDownFinish
        '
        Me.NotifyIconDownFinish.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.NotifyIconDownFinish.BalloonTipText = "Please Check Your Path "
        Me.NotifyIconDownFinish.BalloonTipTitle = "Download Sucessfully Completed"
        Me.NotifyIconDownFinish.Icon = CType(resources.GetObject("NotifyIconDownFinish.Icon"), System.Drawing.Icon)
        Me.NotifyIconDownFinish.Text = "NotifyIconDownFinish"
        Me.NotifyIconDownFinish.Visible = True
        '
        'frmPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(675, 436)
        Me.Controls.Add(Me.AxVLCPlugin21)
        Me.Controls.Add(Me.picBackFontFPS2)
        Me.Controls.Add(Me.picBackFontFPS)
        Me.Controls.Add(Me.NoFunctionFPV35)
        Me.Controls.Add(Me.pnlButtonsFPS)
        Me.Controls.Add(Me.pnlMenuFPS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPlay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmPlay"
        Me.pnlButtonsFPS.ResumeLayout(False)
        CType(Me.imgbtnFPS_VolumeUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoFunctionFPV7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnFPS_Pause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnFPS_Play, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoFunctionFPV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnFPS_Stop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnFPS_VolumeDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoFunctionFPV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoFunctionFPV5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenuFPS.ResumeLayout(False)
        Me.pnlMenuFPS.PerformLayout()
        CType(Me.imgbtnFPV_YouTube, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnFPV_Setting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnFPV_MoreInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoFunctionFPV3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NoFunctionFPV35.ResumeLayout(False)
        CType(Me.NoFunctionFPV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackFontFPS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackFontFPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlMenuFPS As Panel
    Friend WithEvents pnlButtonsFPS As Panel
    Friend WithEvents NoFunctionFPV7 As PictureBox
    Friend WithEvents imgbtnFPS_Play As PictureBox
    Friend WithEvents NoFunctionFPV6 As PictureBox
    Friend WithEvents imgbtnFPS_Stop As PictureBox
    Friend WithEvents NoFunctionFPV4 As PictureBox
    Friend WithEvents NoFunctionFPV5 As PictureBox
    Friend WithEvents btnPlayFPS As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnImportFPV As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents NoFunctionFPV1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents imgbtnFPS_VolumeUp As PictureBox
    Friend WithEvents imgbtnFPS_VolumeDown As PictureBox
    Friend WithEvents NoFunctionFPV35 As Panel
    Friend WithEvents NoFunctionFPV2 As PictureBox
    Friend WithEvents NoFunctionFPV3 As PictureBox
    Friend WithEvents picBackFontFPS2 As PictureBox
    Friend WithEvents picBackFontFPS As PictureBox
    Friend WithEvents lblTextFPV1 As Label
    Friend WithEvents imgbtnFPV_Setting As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgbtnFPV_MoreInfos As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgbtnFPV_YouTube As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgbtnFPS_Pause As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents AxVLCPlugin21 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents NotifyIconDownFinish As NotifyIcon
End Class
