<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetting_Advanced
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetting_Advanced))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.grpAdvancedSettingFSA = New System.Windows.Forms.GroupBox()
        Me.ckbFSA_AutoSaveSets = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.ckbFSA_AutoCkUpdates = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.ckbFSA_DownloadThumbs = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.ckbFSA_SendEmail = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.ckbFSA_AddHistory = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.ckbFSA_ExportHistorx = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.ckbFSA_PreviewVid = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.ckbFSA_PasteURLs = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lblCkbTextFSA7 = New System.Windows.Forms.Label()
        Me.lblCkbTextFSA6 = New System.Windows.Forms.Label()
        Me.lblCkbTextFSA5 = New System.Windows.Forms.Label()
        Me.lblCkbTextFSA4 = New System.Windows.Forms.Label()
        Me.lblCkbTextFSA8 = New System.Windows.Forms.Label()
        Me.lblCkbTextFSA3 = New System.Windows.Forms.Label()
        Me.lblCkbTextFSA2 = New System.Windows.Forms.Label()
        Me.lblCkbTextFSA1 = New System.Windows.Forms.Label()
        Me.lblCkbTextFSA11 = New System.Windows.Forms.Label()
        Me.lblCkbTextFSA10 = New System.Windows.Forms.Label()
        Me.btnMainInfoFSA = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSaveFSA = New Bunifu.Framework.UI.BunifuImageButton()
        Me.switchSoundEnableFSA = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.switchOffDownloadDoneFSA = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.btnAddSoundFSA = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnLowSoundFSA = New Bunifu.Framework.UI.BunifuImageButton()
        Me.grpAdvancedSettingFSA.SuspendLayout()
        CType(Me.btnMainInfoFSA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveFSA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddSoundFSA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLowSoundFSA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'grpAdvancedSettingFSA
        '
        Me.grpAdvancedSettingFSA.Controls.Add(Me.ckbFSA_AutoSaveSets)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.ckbFSA_AutoCkUpdates)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.ckbFSA_DownloadThumbs)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.ckbFSA_SendEmail)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.ckbFSA_AddHistory)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.ckbFSA_ExportHistorx)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.ckbFSA_PreviewVid)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.ckbFSA_PasteURLs)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.lblCkbTextFSA7)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.lblCkbTextFSA6)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.lblCkbTextFSA5)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.lblCkbTextFSA4)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.lblCkbTextFSA8)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.lblCkbTextFSA3)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.lblCkbTextFSA2)
        Me.grpAdvancedSettingFSA.Controls.Add(Me.lblCkbTextFSA1)
        Me.grpAdvancedSettingFSA.Location = New System.Drawing.Point(12, 13)
        Me.grpAdvancedSettingFSA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAdvancedSettingFSA.Name = "grpAdvancedSettingFSA"
        Me.grpAdvancedSettingFSA.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAdvancedSettingFSA.Size = New System.Drawing.Size(400, 262)
        Me.grpAdvancedSettingFSA.TabIndex = 2
        Me.grpAdvancedSettingFSA.TabStop = False
        Me.grpAdvancedSettingFSA.Text = "Advanced Settings"
        '
        'ckbFSA_AutoSaveSets
        '
        Me.ckbFSA_AutoSaveSets.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSA_AutoSaveSets.ChechedOffColor = System.Drawing.Color.Tomato
        Me.ckbFSA_AutoSaveSets.Checked = True
        Me.ckbFSA_AutoSaveSets.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSA_AutoSaveSets.ForeColor = System.Drawing.Color.White
        Me.ckbFSA_AutoSaveSets.Location = New System.Drawing.Point(31, 227)
        Me.ckbFSA_AutoSaveSets.Margin = New System.Windows.Forms.Padding(16, 27, 16, 27)
        Me.ckbFSA_AutoSaveSets.Name = "ckbFSA_AutoSaveSets"
        Me.ckbFSA_AutoSaveSets.Size = New System.Drawing.Size(20, 20)
        Me.ckbFSA_AutoSaveSets.TabIndex = 9
        '
        'ckbFSA_AutoCkUpdates
        '
        Me.ckbFSA_AutoCkUpdates.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSA_AutoCkUpdates.ChechedOffColor = System.Drawing.Color.Tomato
        Me.ckbFSA_AutoCkUpdates.Checked = True
        Me.ckbFSA_AutoCkUpdates.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSA_AutoCkUpdates.ForeColor = System.Drawing.Color.White
        Me.ckbFSA_AutoCkUpdates.Location = New System.Drawing.Point(32, 201)
        Me.ckbFSA_AutoCkUpdates.Margin = New System.Windows.Forms.Padding(12, 21, 12, 21)
        Me.ckbFSA_AutoCkUpdates.Name = "ckbFSA_AutoCkUpdates"
        Me.ckbFSA_AutoCkUpdates.Size = New System.Drawing.Size(20, 20)
        Me.ckbFSA_AutoCkUpdates.TabIndex = 9
        '
        'ckbFSA_DownloadThumbs
        '
        Me.ckbFSA_DownloadThumbs.BackColor = System.Drawing.Color.Tomato
        Me.ckbFSA_DownloadThumbs.ChechedOffColor = System.Drawing.Color.Tomato
        Me.ckbFSA_DownloadThumbs.Checked = False
        Me.ckbFSA_DownloadThumbs.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSA_DownloadThumbs.Enabled = False
        Me.ckbFSA_DownloadThumbs.ForeColor = System.Drawing.Color.White
        Me.ckbFSA_DownloadThumbs.Location = New System.Drawing.Point(32, 170)
        Me.ckbFSA_DownloadThumbs.Margin = New System.Windows.Forms.Padding(9, 16, 9, 16)
        Me.ckbFSA_DownloadThumbs.Name = "ckbFSA_DownloadThumbs"
        Me.ckbFSA_DownloadThumbs.Size = New System.Drawing.Size(20, 20)
        Me.ckbFSA_DownloadThumbs.TabIndex = 9
        '
        'ckbFSA_SendEmail
        '
        Me.ckbFSA_SendEmail.BackColor = System.Drawing.Color.Tomato
        Me.ckbFSA_SendEmail.ChechedOffColor = System.Drawing.Color.Tomato
        Me.ckbFSA_SendEmail.Checked = False
        Me.ckbFSA_SendEmail.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSA_SendEmail.Enabled = False
        Me.ckbFSA_SendEmail.ForeColor = System.Drawing.Color.White
        Me.ckbFSA_SendEmail.Location = New System.Drawing.Point(32, 143)
        Me.ckbFSA_SendEmail.Margin = New System.Windows.Forms.Padding(7, 12, 7, 12)
        Me.ckbFSA_SendEmail.Name = "ckbFSA_SendEmail"
        Me.ckbFSA_SendEmail.Size = New System.Drawing.Size(20, 20)
        Me.ckbFSA_SendEmail.TabIndex = 9
        '
        'ckbFSA_AddHistory
        '
        Me.ckbFSA_AddHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSA_AddHistory.ChechedOffColor = System.Drawing.Color.Tomato
        Me.ckbFSA_AddHistory.Checked = True
        Me.ckbFSA_AddHistory.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSA_AddHistory.ForeColor = System.Drawing.Color.White
        Me.ckbFSA_AddHistory.Location = New System.Drawing.Point(31, 115)
        Me.ckbFSA_AddHistory.Margin = New System.Windows.Forms.Padding(5, 9, 5, 9)
        Me.ckbFSA_AddHistory.Name = "ckbFSA_AddHistory"
        Me.ckbFSA_AddHistory.Size = New System.Drawing.Size(20, 20)
        Me.ckbFSA_AddHistory.TabIndex = 9
        '
        'ckbFSA_ExportHistorx
        '
        Me.ckbFSA_ExportHistorx.BackColor = System.Drawing.Color.Tomato
        Me.ckbFSA_ExportHistorx.ChechedOffColor = System.Drawing.Color.Tomato
        Me.ckbFSA_ExportHistorx.Checked = False
        Me.ckbFSA_ExportHistorx.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSA_ExportHistorx.Enabled = False
        Me.ckbFSA_ExportHistorx.ForeColor = System.Drawing.Color.White
        Me.ckbFSA_ExportHistorx.Location = New System.Drawing.Point(32, 85)
        Me.ckbFSA_ExportHistorx.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.ckbFSA_ExportHistorx.Name = "ckbFSA_ExportHistorx"
        Me.ckbFSA_ExportHistorx.Size = New System.Drawing.Size(20, 20)
        Me.ckbFSA_ExportHistorx.TabIndex = 9
        '
        'ckbFSA_PreviewVid
        '
        Me.ckbFSA_PreviewVid.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSA_PreviewVid.ChechedOffColor = System.Drawing.Color.Tomato
        Me.ckbFSA_PreviewVid.Checked = True
        Me.ckbFSA_PreviewVid.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSA_PreviewVid.ForeColor = System.Drawing.Color.White
        Me.ckbFSA_PreviewVid.Location = New System.Drawing.Point(33, 55)
        Me.ckbFSA_PreviewVid.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ckbFSA_PreviewVid.Name = "ckbFSA_PreviewVid"
        Me.ckbFSA_PreviewVid.Size = New System.Drawing.Size(20, 20)
        Me.ckbFSA_PreviewVid.TabIndex = 9
        '
        'ckbFSA_PasteURLs
        '
        Me.ckbFSA_PasteURLs.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSA_PasteURLs.ChechedOffColor = System.Drawing.Color.Tomato
        Me.ckbFSA_PasteURLs.Checked = True
        Me.ckbFSA_PasteURLs.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSA_PasteURLs.ForeColor = System.Drawing.Color.White
        Me.ckbFSA_PasteURLs.Location = New System.Drawing.Point(34, 25)
        Me.ckbFSA_PasteURLs.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ckbFSA_PasteURLs.Name = "ckbFSA_PasteURLs"
        Me.ckbFSA_PasteURLs.Size = New System.Drawing.Size(20, 20)
        Me.ckbFSA_PasteURLs.TabIndex = 10
        '
        'lblCkbTextFSA7
        '
        Me.lblCkbTextFSA7.AutoSize = True
        Me.lblCkbTextFSA7.Location = New System.Drawing.Point(60, 201)
        Me.lblCkbTextFSA7.Name = "lblCkbTextFSA7"
        Me.lblCkbTextFSA7.Size = New System.Drawing.Size(142, 17)
        Me.lblCkbTextFSA7.TabIndex = 7
        Me.lblCkbTextFSA7.Text = "Auto Check Updates"
        '
        'lblCkbTextFSA6
        '
        Me.lblCkbTextFSA6.AutoSize = True
        Me.lblCkbTextFSA6.ForeColor = System.Drawing.Color.Tomato
        Me.lblCkbTextFSA6.Location = New System.Drawing.Point(58, 173)
        Me.lblCkbTextFSA6.Name = "lblCkbTextFSA6"
        Me.lblCkbTextFSA6.Size = New System.Drawing.Size(187, 17)
        Me.lblCkbTextFSA6.TabIndex = 7
        Me.lblCkbTextFSA6.Text = "Auto Download Thumbnails"
        '
        'lblCkbTextFSA5
        '
        Me.lblCkbTextFSA5.AutoSize = True
        Me.lblCkbTextFSA5.ForeColor = System.Drawing.Color.Tomato
        Me.lblCkbTextFSA5.Location = New System.Drawing.Point(62, 146)
        Me.lblCkbTextFSA5.Name = "lblCkbTextFSA5"
        Me.lblCkbTextFSA5.Size = New System.Drawing.Size(117, 17)
        Me.lblCkbTextFSA5.TabIndex = 7
        Me.lblCkbTextFSA5.Text = "Auto Send Email "
        '
        'lblCkbTextFSA4
        '
        Me.lblCkbTextFSA4.AutoSize = True
        Me.lblCkbTextFSA4.Location = New System.Drawing.Point(64, 115)
        Me.lblCkbTextFSA4.Name = "lblCkbTextFSA4"
        Me.lblCkbTextFSA4.Size = New System.Drawing.Size(115, 17)
        Me.lblCkbTextFSA4.TabIndex = 7
        Me.lblCkbTextFSA4.Text = "Auto Add History"
        '
        'lblCkbTextFSA8
        '
        Me.lblCkbTextFSA8.AutoSize = True
        Me.lblCkbTextFSA8.Location = New System.Drawing.Point(64, 230)
        Me.lblCkbTextFSA8.Name = "lblCkbTextFSA8"
        Me.lblCkbTextFSA8.Size = New System.Drawing.Size(127, 17)
        Me.lblCkbTextFSA8.TabIndex = 7
        Me.lblCkbTextFSA8.Text = "Auto Save Settings"
        '
        'lblCkbTextFSA3
        '
        Me.lblCkbTextFSA3.AutoSize = True
        Me.lblCkbTextFSA3.ForeColor = System.Drawing.Color.Tomato
        Me.lblCkbTextFSA3.Location = New System.Drawing.Point(62, 85)
        Me.lblCkbTextFSA3.Name = "lblCkbTextFSA3"
        Me.lblCkbTextFSA3.Size = New System.Drawing.Size(128, 17)
        Me.lblCkbTextFSA3.TabIndex = 7
        Me.lblCkbTextFSA3.Text = "Auto Export History"
        '
        'lblCkbTextFSA2
        '
        Me.lblCkbTextFSA2.AutoSize = True
        Me.lblCkbTextFSA2.Location = New System.Drawing.Point(60, 55)
        Me.lblCkbTextFSA2.Name = "lblCkbTextFSA2"
        Me.lblCkbTextFSA2.Size = New System.Drawing.Size(136, 17)
        Me.lblCkbTextFSA2.TabIndex = 7
        Me.lblCkbTextFSA2.Text = "Auto Preview Video"
        '
        'lblCkbTextFSA1
        '
        Me.lblCkbTextFSA1.AutoSize = True
        Me.lblCkbTextFSA1.Location = New System.Drawing.Point(60, 25)
        Me.lblCkbTextFSA1.Name = "lblCkbTextFSA1"
        Me.lblCkbTextFSA1.Size = New System.Drawing.Size(211, 17)
        Me.lblCkbTextFSA1.TabIndex = 8
        Me.lblCkbTextFSA1.Text = "Auto-paste URLs from clipboard"
        '
        'lblCkbTextFSA11
        '
        Me.lblCkbTextFSA11.AutoSize = True
        Me.lblCkbTextFSA11.Location = New System.Drawing.Point(126, 311)
        Me.lblCkbTextFSA11.Name = "lblCkbTextFSA11"
        Me.lblCkbTextFSA11.Size = New System.Drawing.Size(101, 17)
        Me.lblCkbTextFSA11.TabIndex = 7
        Me.lblCkbTextFSA11.Text = "Enable Sounds"
        '
        'lblCkbTextFSA10
        '
        Me.lblCkbTextFSA10.AutoSize = True
        Me.lblCkbTextFSA10.Location = New System.Drawing.Point(123, 279)
        Me.lblCkbTextFSA10.Name = "lblCkbTextFSA10"
        Me.lblCkbTextFSA10.Size = New System.Drawing.Size(308, 17)
        Me.lblCkbTextFSA10.TabIndex = 7
        Me.lblCkbTextFSA10.Text = "Shutdown Computer When Download Is done"
        '
        'btnMainInfoFSA
        '
        Me.btnMainInfoFSA.BackColor = System.Drawing.Color.White
        Me.btnMainInfoFSA.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.btnMainInfoFSA.ImageActive = Nothing
        Me.btnMainInfoFSA.Location = New System.Drawing.Point(12, 353)
        Me.btnMainInfoFSA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMainInfoFSA.Name = "btnMainInfoFSA"
        Me.btnMainInfoFSA.Size = New System.Drawing.Size(31, 33)
        Me.btnMainInfoFSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMainInfoFSA.TabIndex = 12
        Me.btnMainInfoFSA.TabStop = False
        Me.btnMainInfoFSA.Zoom = 10
        '
        'btnSaveFSA
        '
        Me.btnSaveFSA.BackColor = System.Drawing.Color.White
        Me.btnSaveFSA.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Save_64
        Me.btnSaveFSA.ImageActive = Nothing
        Me.btnSaveFSA.Location = New System.Drawing.Point(370, 350)
        Me.btnSaveFSA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveFSA.Name = "btnSaveFSA"
        Me.btnSaveFSA.Size = New System.Drawing.Size(64, 35)
        Me.btnSaveFSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSaveFSA.TabIndex = 8
        Me.btnSaveFSA.TabStop = False
        Me.btnSaveFSA.Zoom = 10
        '
        'switchSoundEnableFSA
        '
        Me.switchSoundEnableFSA.BackColor = System.Drawing.Color.Transparent
        Me.switchSoundEnableFSA.BackgroundImage = CType(resources.GetObject("switchSoundEnableFSA.BackgroundImage"), System.Drawing.Image)
        Me.switchSoundEnableFSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.switchSoundEnableFSA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switchSoundEnableFSA.Location = New System.Drawing.Point(81, 308)
        Me.switchSoundEnableFSA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.switchSoundEnableFSA.Name = "switchSoundEnableFSA"
        Me.switchSoundEnableFSA.OffColor = System.Drawing.Color.Tomato
        Me.switchSoundEnableFSA.OnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.switchSoundEnableFSA.Size = New System.Drawing.Size(35, 20)
        Me.switchSoundEnableFSA.TabIndex = 7
        Me.switchSoundEnableFSA.Value = True
        '
        'switchOffDownloadDoneFSA
        '
        Me.switchOffDownloadDoneFSA.BackColor = System.Drawing.Color.Transparent
        Me.switchOffDownloadDoneFSA.BackgroundImage = CType(resources.GetObject("switchOffDownloadDoneFSA.BackgroundImage"), System.Drawing.Image)
        Me.switchOffDownloadDoneFSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.switchOffDownloadDoneFSA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switchOffDownloadDoneFSA.Location = New System.Drawing.Point(81, 276)
        Me.switchOffDownloadDoneFSA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.switchOffDownloadDoneFSA.Name = "switchOffDownloadDoneFSA"
        Me.switchOffDownloadDoneFSA.OffColor = System.Drawing.Color.Tomato
        Me.switchOffDownloadDoneFSA.OnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.switchOffDownloadDoneFSA.Size = New System.Drawing.Size(35, 20)
        Me.switchOffDownloadDoneFSA.TabIndex = 7
        Me.switchOffDownloadDoneFSA.Value = False
        '
        'btnAddSoundFSA
        '
        Me.btnAddSoundFSA.BackColor = System.Drawing.Color.Transparent
        Me.btnAddSoundFSA.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Speaker_64
        Me.btnAddSoundFSA.ImageActive = Nothing
        Me.btnAddSoundFSA.Location = New System.Drawing.Point(6, 275)
        Me.btnAddSoundFSA.Name = "btnAddSoundFSA"
        Me.btnAddSoundFSA.Size = New System.Drawing.Size(32, 30)
        Me.btnAddSoundFSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAddSoundFSA.TabIndex = 13
        Me.btnAddSoundFSA.TabStop = False
        Me.btnAddSoundFSA.Zoom = 10
        '
        'btnLowSoundFSA
        '
        Me.btnLowSoundFSA.BackColor = System.Drawing.Color.Transparent
        Me.btnLowSoundFSA.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Low_Volume_64
        Me.btnLowSoundFSA.ImageActive = Nothing
        Me.btnLowSoundFSA.Location = New System.Drawing.Point(6, 311)
        Me.btnLowSoundFSA.Name = "btnLowSoundFSA"
        Me.btnLowSoundFSA.Size = New System.Drawing.Size(32, 30)
        Me.btnLowSoundFSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLowSoundFSA.TabIndex = 13
        Me.btnLowSoundFSA.TabStop = False
        Me.btnLowSoundFSA.Zoom = 10
        '
        'frmSetting_Advanced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(446, 399)
        Me.Controls.Add(Me.btnLowSoundFSA)
        Me.Controls.Add(Me.btnAddSoundFSA)
        Me.Controls.Add(Me.btnMainInfoFSA)
        Me.Controls.Add(Me.btnSaveFSA)
        Me.Controls.Add(Me.switchSoundEnableFSA)
        Me.Controls.Add(Me.switchOffDownloadDoneFSA)
        Me.Controls.Add(Me.grpAdvancedSettingFSA)
        Me.Controls.Add(Me.lblCkbTextFSA11)
        Me.Controls.Add(Me.lblCkbTextFSA10)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSetting_Advanced"
        Me.Text = "frmSetting_Advanced"
        Me.grpAdvancedSettingFSA.ResumeLayout(False)
        Me.grpAdvancedSettingFSA.PerformLayout()
        CType(Me.btnMainInfoFSA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveFSA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddSoundFSA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLowSoundFSA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents grpAdvancedSettingFSA As GroupBox
    Friend WithEvents switchOffDownloadDoneFSA As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents ckbFSA_PreviewVid As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents ckbFSA_PasteURLs As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lblCkbTextFSA2 As Label
    Friend WithEvents lblCkbTextFSA1 As Label
    Friend WithEvents lblCkbTextFSA3 As Label
    Friend WithEvents ckbFSA_AutoSaveSets As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents ckbFSA_AutoCkUpdates As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents ckbFSA_DownloadThumbs As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents ckbFSA_SendEmail As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents ckbFSA_AddHistory As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents ckbFSA_ExportHistorx As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lblCkbTextFSA7 As Label
    Friend WithEvents lblCkbTextFSA6 As Label
    Friend WithEvents lblCkbTextFSA5 As Label
    Friend WithEvents lblCkbTextFSA4 As Label
    Friend WithEvents lblCkbTextFSA8 As Label
    Friend WithEvents lblCkbTextFSA11 As Label
    Friend WithEvents lblCkbTextFSA10 As Label
    Friend WithEvents switchSoundEnableFSA As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents btnSaveFSA As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMainInfoFSA As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnLowSoundFSA As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAddSoundFSA As Bunifu.Framework.UI.BunifuImageButton
End Class
