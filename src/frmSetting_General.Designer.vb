<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetting_General
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetting_General))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblVidQualityFSG = New System.Windows.Forms.Label()
        Me.grbVidFSG = New System.Windows.Forms.GroupBox()
        Me.btnVidInfoFSG = New Bunifu.Framework.UI.BunifuImageButton()
        Me.switchHomeTutoFSG = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.lblHomeTuto_FeaturesFSG = New System.Windows.Forms.Label()
        Me.lblVidFormatFSG = New System.Windows.Forms.Label()
        Me.dpdVidFormatFSG = New Bunifu.Framework.UI.BunifuDropdown()
        Me.dpdVidQualityFSG = New Bunifu.Framework.UI.BunifuDropdown()
        Me.grbFontFSG = New System.Windows.Forms.GroupBox()
        Me.btnFontInfoFSG = New Bunifu.Framework.UI.BunifuImageButton()
        Me.switchAppearence_AsDefaultFSG = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.lblGreenFSG = New System.Windows.Forms.Label()
        Me.lblDefaultFSG = New System.Windows.Forms.Label()
        Me.lblBlueFSG = New System.Windows.Forms.Label()
        Me.lblRedFSG = New System.Windows.Forms.Label()
        Me.txtGreenFSG = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtBlueFSG = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtRedFSG = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblBgColorFSG = New System.Windows.Forms.Label()
        Me.btnMainInfoFSG = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSaveFSG = New Bunifu.Framework.UI.BunifuImageButton()
        Me.grbVidFSG.SuspendLayout()
        CType(Me.btnVidInfoFSG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFontFSG.SuspendLayout()
        CType(Me.btnFontInfoFSG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMainInfoFSG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveFSG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'lblVidQualityFSG
        '
        Me.lblVidQualityFSG.AutoSize = True
        Me.lblVidQualityFSG.Location = New System.Drawing.Point(8, 34)
        Me.lblVidQualityFSG.Name = "lblVidQualityFSG"
        Me.lblVidQualityFSG.Size = New System.Drawing.Size(158, 17)
        Me.lblVidQualityFSG.TabIndex = 1
        Me.lblVidQualityFSG.Text = "Default Video Quality : "
        '
        'grbVidFSG
        '
        Me.grbVidFSG.Controls.Add(Me.btnVidInfoFSG)
        Me.grbVidFSG.Controls.Add(Me.switchHomeTutoFSG)
        Me.grbVidFSG.Controls.Add(Me.lblHomeTuto_FeaturesFSG)
        Me.grbVidFSG.Controls.Add(Me.lblVidFormatFSG)
        Me.grbVidFSG.Controls.Add(Me.lblVidQualityFSG)
        Me.grbVidFSG.Controls.Add(Me.dpdVidFormatFSG)
        Me.grbVidFSG.Controls.Add(Me.dpdVidQualityFSG)
        Me.grbVidFSG.Location = New System.Drawing.Point(16, 15)
        Me.grbVidFSG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbVidFSG.Name = "grbVidFSG"
        Me.grbVidFSG.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbVidFSG.Size = New System.Drawing.Size(401, 133)
        Me.grbVidFSG.TabIndex = 2
        Me.grbVidFSG.TabStop = False
        Me.grbVidFSG.Text = "Video "
        '
        'btnVidInfoFSG
        '
        Me.btnVidInfoFSG.BackColor = System.Drawing.Color.White
        Me.btnVidInfoFSG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVidInfoFSG.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.btnVidInfoFSG.ImageActive = Nothing
        Me.btnVidInfoFSG.Location = New System.Drawing.Point(383, 109)
        Me.btnVidInfoFSG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVidInfoFSG.Name = "btnVidInfoFSG"
        Me.btnVidInfoFSG.Size = New System.Drawing.Size(12, 16)
        Me.btnVidInfoFSG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnVidInfoFSG.TabIndex = 14
        Me.btnVidInfoFSG.TabStop = False
        Me.btnVidInfoFSG.Zoom = 10
        '
        'switchHomeTutoFSG
        '
        Me.switchHomeTutoFSG.BackColor = System.Drawing.Color.Transparent
        Me.switchHomeTutoFSG.BackgroundImage = CType(resources.GetObject("switchHomeTutoFSG.BackgroundImage"), System.Drawing.Image)
        Me.switchHomeTutoFSG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.switchHomeTutoFSG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switchHomeTutoFSG.Location = New System.Drawing.Point(13, 105)
        Me.switchHomeTutoFSG.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.switchHomeTutoFSG.Name = "switchHomeTutoFSG"
        Me.switchHomeTutoFSG.OffColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.switchHomeTutoFSG.OnColor = System.Drawing.Color.Tomato
        Me.switchHomeTutoFSG.Size = New System.Drawing.Size(35, 20)
        Me.switchHomeTutoFSG.TabIndex = 13
        Me.switchHomeTutoFSG.Value = False
        '
        'lblHomeTuto_FeaturesFSG
        '
        Me.lblHomeTuto_FeaturesFSG.AutoSize = True
        Me.lblHomeTuto_FeaturesFSG.Location = New System.Drawing.Point(58, 107)
        Me.lblHomeTuto_FeaturesFSG.Name = "lblHomeTuto_FeaturesFSG"
        Me.lblHomeTuto_FeaturesFSG.Size = New System.Drawing.Size(187, 17)
        Me.lblHomeTuto_FeaturesFSG.TabIndex = 12
        Me.lblHomeTuto_FeaturesFSG.Text = "Home Tutorials and features"
        '
        'lblVidFormatFSG
        '
        Me.lblVidFormatFSG.AutoSize = True
        Me.lblVidFormatFSG.Location = New System.Drawing.Point(8, 71)
        Me.lblVidFormatFSG.Name = "lblVidFormatFSG"
        Me.lblVidFormatFSG.Size = New System.Drawing.Size(159, 17)
        Me.lblVidFormatFSG.TabIndex = 1
        Me.lblVidFormatFSG.Text = "Default Video Format : "
        '
        'dpdVidFormatFSG
        '
        Me.dpdVidFormatFSG.BackColor = System.Drawing.Color.Transparent
        Me.dpdVidFormatFSG.BorderRadius = 3
        Me.dpdVidFormatFSG.DisabledColor = System.Drawing.Color.Gray
        Me.dpdVidFormatFSG.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpdVidFormatFSG.ForeColor = System.Drawing.Color.White
        Me.dpdVidFormatFSG.Items = New String() {".Mp4", ".3gp", ".webm"}
        Me.dpdVidFormatFSG.Location = New System.Drawing.Point(172, 65)
        Me.dpdVidFormatFSG.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dpdVidFormatFSG.Name = "dpdVidFormatFSG"
        Me.dpdVidFormatFSG.NomalColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.dpdVidFormatFSG.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.dpdVidFormatFSG.selectedIndex = 0
        Me.dpdVidFormatFSG.Size = New System.Drawing.Size(130, 23)
        Me.dpdVidFormatFSG.TabIndex = 4
        '
        'dpdVidQualityFSG
        '
        Me.dpdVidQualityFSG.BackColor = System.Drawing.Color.Transparent
        Me.dpdVidQualityFSG.BorderRadius = 3
        Me.dpdVidQualityFSG.DisabledColor = System.Drawing.Color.Gray
        Me.dpdVidQualityFSG.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpdVidQualityFSG.ForeColor = System.Drawing.Color.White
        Me.dpdVidQualityFSG.Items = New String() {"1440p HD", "1080p HD", "720p HD", "480p", "360p", "240p", "144p"}
        Me.dpdVidQualityFSG.Location = New System.Drawing.Point(172, 34)
        Me.dpdVidQualityFSG.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dpdVidQualityFSG.Name = "dpdVidQualityFSG"
        Me.dpdVidQualityFSG.NomalColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.dpdVidQualityFSG.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.dpdVidQualityFSG.selectedIndex = 2
        Me.dpdVidQualityFSG.Size = New System.Drawing.Size(196, 23)
        Me.dpdVidQualityFSG.TabIndex = 4
        '
        'grbFontFSG
        '
        Me.grbFontFSG.Controls.Add(Me.btnFontInfoFSG)
        Me.grbFontFSG.Controls.Add(Me.switchAppearence_AsDefaultFSG)
        Me.grbFontFSG.Controls.Add(Me.lblGreenFSG)
        Me.grbFontFSG.Controls.Add(Me.lblDefaultFSG)
        Me.grbFontFSG.Controls.Add(Me.lblBlueFSG)
        Me.grbFontFSG.Controls.Add(Me.lblRedFSG)
        Me.grbFontFSG.Controls.Add(Me.txtGreenFSG)
        Me.grbFontFSG.Controls.Add(Me.txtBlueFSG)
        Me.grbFontFSG.Controls.Add(Me.txtRedFSG)
        Me.grbFontFSG.Controls.Add(Me.lblBgColorFSG)
        Me.grbFontFSG.ForeColor = System.Drawing.Color.Tomato
        Me.grbFontFSG.Location = New System.Drawing.Point(16, 167)
        Me.grbFontFSG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbFontFSG.Name = "grbFontFSG"
        Me.grbFontFSG.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbFontFSG.Size = New System.Drawing.Size(404, 146)
        Me.grbFontFSG.TabIndex = 8
        Me.grbFontFSG.TabStop = False
        Me.grbFontFSG.Text = "Appearence"
        '
        'btnFontInfoFSG
        '
        Me.btnFontInfoFSG.BackColor = System.Drawing.Color.White
        Me.btnFontInfoFSG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFontInfoFSG.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.btnFontInfoFSG.ImageActive = Nothing
        Me.btnFontInfoFSG.Location = New System.Drawing.Point(383, 123)
        Me.btnFontInfoFSG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFontInfoFSG.Name = "btnFontInfoFSG"
        Me.btnFontInfoFSG.Size = New System.Drawing.Size(12, 16)
        Me.btnFontInfoFSG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnFontInfoFSG.TabIndex = 13
        Me.btnFontInfoFSG.TabStop = False
        Me.btnFontInfoFSG.Zoom = 10
        '
        'switchAppearence_AsDefaultFSG
        '
        Me.switchAppearence_AsDefaultFSG.BackColor = System.Drawing.Color.Transparent
        Me.switchAppearence_AsDefaultFSG.BackgroundImage = CType(resources.GetObject("switchAppearence_AsDefaultFSG.BackgroundImage"), System.Drawing.Image)
        Me.switchAppearence_AsDefaultFSG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.switchAppearence_AsDefaultFSG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switchAppearence_AsDefaultFSG.Location = New System.Drawing.Point(354, 62)
        Me.switchAppearence_AsDefaultFSG.Margin = New System.Windows.Forms.Padding(5, 9, 5, 9)
        Me.switchAppearence_AsDefaultFSG.Name = "switchAppearence_AsDefaultFSG"
        Me.switchAppearence_AsDefaultFSG.OffColor = System.Drawing.Color.Tomato
        Me.switchAppearence_AsDefaultFSG.OnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.switchAppearence_AsDefaultFSG.Size = New System.Drawing.Size(35, 20)
        Me.switchAppearence_AsDefaultFSG.TabIndex = 13
        Me.switchAppearence_AsDefaultFSG.Value = True
        '
        'lblGreenFSG
        '
        Me.lblGreenFSG.AutoSize = True
        Me.lblGreenFSG.Location = New System.Drawing.Point(177, 59)
        Me.lblGreenFSG.Name = "lblGreenFSG"
        Me.lblGreenFSG.Size = New System.Drawing.Size(47, 17)
        Me.lblGreenFSG.TabIndex = 6
        Me.lblGreenFSG.Text = "Green"
        '
        'lblDefaultFSG
        '
        Me.lblDefaultFSG.AutoSize = True
        Me.lblDefaultFSG.Location = New System.Drawing.Point(346, 91)
        Me.lblDefaultFSG.Name = "lblDefaultFSG"
        Me.lblDefaultFSG.Size = New System.Drawing.Size(55, 17)
        Me.lblDefaultFSG.TabIndex = 1
        Me.lblDefaultFSG.Text = "Default"
        '
        'lblBlueFSG
        '
        Me.lblBlueFSG.AutoSize = True
        Me.lblBlueFSG.Location = New System.Drawing.Point(134, 59)
        Me.lblBlueFSG.Name = "lblBlueFSG"
        Me.lblBlueFSG.Size = New System.Drawing.Size(34, 17)
        Me.lblBlueFSG.TabIndex = 6
        Me.lblBlueFSG.Text = "Blue"
        '
        'lblRedFSG
        '
        Me.lblRedFSG.AutoSize = True
        Me.lblRedFSG.Location = New System.Drawing.Point(86, 59)
        Me.lblRedFSG.Name = "lblRedFSG"
        Me.lblRedFSG.Size = New System.Drawing.Size(33, 17)
        Me.lblRedFSG.TabIndex = 6
        Me.lblRedFSG.Text = "Red"
        '
        'txtGreenFSG
        '
        Me.txtGreenFSG.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtGreenFSG.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtGreenFSG.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtGreenFSG.BorderThickness = 3
        Me.txtGreenFSG.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGreenFSG.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtGreenFSG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGreenFSG.isPassword = False
        Me.txtGreenFSG.Location = New System.Drawing.Point(180, 81)
        Me.txtGreenFSG.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtGreenFSG.Name = "txtGreenFSG"
        Me.txtGreenFSG.Size = New System.Drawing.Size(40, 27)
        Me.txtGreenFSG.TabIndex = 5
        Me.txtGreenFSG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtBlueFSG
        '
        Me.txtBlueFSG.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtBlueFSG.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtBlueFSG.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtBlueFSG.BorderThickness = 3
        Me.txtBlueFSG.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBlueFSG.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtBlueFSG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBlueFSG.isPassword = False
        Me.txtBlueFSG.Location = New System.Drawing.Point(128, 81)
        Me.txtBlueFSG.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtBlueFSG.Name = "txtBlueFSG"
        Me.txtBlueFSG.Size = New System.Drawing.Size(40, 27)
        Me.txtBlueFSG.TabIndex = 5
        Me.txtBlueFSG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtRedFSG
        '
        Me.txtRedFSG.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtRedFSG.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtRedFSG.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtRedFSG.BorderThickness = 3
        Me.txtRedFSG.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRedFSG.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtRedFSG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRedFSG.isPassword = False
        Me.txtRedFSG.Location = New System.Drawing.Point(79, 81)
        Me.txtRedFSG.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtRedFSG.Name = "txtRedFSG"
        Me.txtRedFSG.Size = New System.Drawing.Size(40, 27)
        Me.txtRedFSG.TabIndex = 5
        Me.txtRedFSG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblBgColorFSG
        '
        Me.lblBgColorFSG.AutoSize = True
        Me.lblBgColorFSG.Location = New System.Drawing.Point(8, 40)
        Me.lblBgColorFSG.Name = "lblBgColorFSG"
        Me.lblBgColorFSG.Size = New System.Drawing.Size(138, 17)
        Me.lblBgColorFSG.TabIndex = 1
        Me.lblBgColorFSG.Text = "Background Color : "
        '
        'btnMainInfoFSG
        '
        Me.btnMainInfoFSG.BackColor = System.Drawing.Color.White
        Me.btnMainInfoFSG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainInfoFSG.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.btnMainInfoFSG.ImageActive = Nothing
        Me.btnMainInfoFSG.Location = New System.Drawing.Point(27, 351)
        Me.btnMainInfoFSG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMainInfoFSG.Name = "btnMainInfoFSG"
        Me.btnMainInfoFSG.Size = New System.Drawing.Size(31, 33)
        Me.btnMainInfoFSG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMainInfoFSG.TabIndex = 10
        Me.btnMainInfoFSG.TabStop = False
        Me.btnMainInfoFSG.Zoom = 10
        '
        'btnSaveFSG
        '
        Me.btnSaveFSG.BackColor = System.Drawing.Color.White
        Me.btnSaveFSG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveFSG.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Save_64
        Me.btnSaveFSG.ImageActive = Nothing
        Me.btnSaveFSG.Location = New System.Drawing.Point(385, 351)
        Me.btnSaveFSG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveFSG.Name = "btnSaveFSG"
        Me.btnSaveFSG.Size = New System.Drawing.Size(35, 35)
        Me.btnSaveFSG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSaveFSG.TabIndex = 7
        Me.btnSaveFSG.TabStop = False
        Me.btnSaveFSG.Zoom = 15
        '
        'frmSetting_General
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(446, 399)
        Me.Controls.Add(Me.btnMainInfoFSG)
        Me.Controls.Add(Me.grbFontFSG)
        Me.Controls.Add(Me.btnSaveFSG)
        Me.Controls.Add(Me.grbVidFSG)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSetting_General"
        Me.Text = "frmSetting_General"
        Me.grbVidFSG.ResumeLayout(False)
        Me.grbVidFSG.PerformLayout()
        CType(Me.btnVidInfoFSG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFontFSG.ResumeLayout(False)
        Me.grbFontFSG.PerformLayout()
        CType(Me.btnFontInfoFSG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMainInfoFSG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveFSG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblVidQualityFSG As Label
    Friend WithEvents grbVidFSG As GroupBox
    Friend WithEvents lblVidFormatFSG As Label
    Friend WithEvents btnSaveFSG As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents grbFontFSG As GroupBox
    Friend WithEvents lblBgColorFSG As Label
    Friend WithEvents lblGreenFSG As Label
    Friend WithEvents lblBlueFSG As Label
    Friend WithEvents lblRedFSG As Label
    Friend WithEvents txtRedFSG As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtBlueFSG As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtGreenFSG As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents dpdVidFormatFSG As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents dpdVidQualityFSG As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents switchHomeTutoFSG As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents lblHomeTuto_FeaturesFSG As Label
    Friend WithEvents btnMainInfoFSG As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnFontInfoFSG As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnVidInfoFSG As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents switchAppearence_AsDefaultFSG As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents lblDefaultFSG As Label
End Class
