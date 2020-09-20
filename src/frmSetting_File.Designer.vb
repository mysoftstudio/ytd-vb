<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetting_File
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetting_File))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtFileNameFSF = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.grpFileSettingsFSF = New System.Windows.Forms.GroupBox()
        Me.switch_Nothimg2FSL = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.switch_NothimgFSL = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.switchOriginal_YoutubeTileFSF = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.lblTextFSF1 = New System.Windows.Forms.Label()
        Me.lblCkbTextFSA3 = New System.Windows.Forms.Label()
        Me.lblCkbTextFSA2 = New System.Windows.Forms.Label()
        Me.btnNameInfoFSL = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblInfos_FileNameFSL = New System.Windows.Forms.Label()
        Me.lblFileNameFLF = New System.Windows.Forms.Label()
        Me.btnMainInfoFSL = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSaveFSL = New Bunifu.Framework.UI.BunifuImageButton()
        Me.grpFileSettingsFSF.SuspendLayout()
        CType(Me.btnNameInfoFSL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMainInfoFSL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveFSL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'txtFileNameFSF
        '
        Me.txtFileNameFSF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFileNameFSF.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtFileNameFSF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFileNameFSF.HintForeColor = System.Drawing.Color.Empty
        Me.txtFileNameFSF.HintText = ""
        Me.txtFileNameFSF.isPassword = False
        Me.txtFileNameFSF.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtFileNameFSF.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtFileNameFSF.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtFileNameFSF.LineThickness = 3
        Me.txtFileNameFSF.Location = New System.Drawing.Point(101, 54)
        Me.txtFileNameFSF.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFileNameFSF.Name = "txtFileNameFSF"
        Me.txtFileNameFSF.Size = New System.Drawing.Size(291, 43)
        Me.txtFileNameFSF.TabIndex = 2
        Me.txtFileNameFSF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'grpFileSettingsFSF
        '
        Me.grpFileSettingsFSF.Controls.Add(Me.switch_Nothimg2FSL)
        Me.grpFileSettingsFSF.Controls.Add(Me.switch_NothimgFSL)
        Me.grpFileSettingsFSF.Controls.Add(Me.switchOriginal_YoutubeTileFSF)
        Me.grpFileSettingsFSF.Controls.Add(Me.lblTextFSF1)
        Me.grpFileSettingsFSF.Controls.Add(Me.lblCkbTextFSA3)
        Me.grpFileSettingsFSF.Controls.Add(Me.lblCkbTextFSA2)
        Me.grpFileSettingsFSF.Controls.Add(Me.btnNameInfoFSL)
        Me.grpFileSettingsFSF.Controls.Add(Me.lblInfos_FileNameFSL)
        Me.grpFileSettingsFSF.Controls.Add(Me.txtFileNameFSF)
        Me.grpFileSettingsFSF.Controls.Add(Me.lblFileNameFLF)
        Me.grpFileSettingsFSF.Location = New System.Drawing.Point(12, 33)
        Me.grpFileSettingsFSF.Margin = New System.Windows.Forms.Padding(4)
        Me.grpFileSettingsFSF.Name = "grpFileSettingsFSF"
        Me.grpFileSettingsFSF.Padding = New System.Windows.Forms.Padding(4)
        Me.grpFileSettingsFSF.Size = New System.Drawing.Size(420, 274)
        Me.grpFileSettingsFSF.TabIndex = 3
        Me.grpFileSettingsFSF.TabStop = False
        Me.grpFileSettingsFSF.Text = "File Settings"
        '
        'switch_Nothimg2FSL
        '
        Me.switch_Nothimg2FSL.BackColor = System.Drawing.Color.Transparent
        Me.switch_Nothimg2FSL.BackgroundImage = CType(resources.GetObject("switch_Nothimg2FSL.BackgroundImage"), System.Drawing.Image)
        Me.switch_Nothimg2FSL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.switch_Nothimg2FSL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switch_Nothimg2FSL.Enabled = False
        Me.switch_Nothimg2FSL.Location = New System.Drawing.Point(81, 243)
        Me.switch_Nothimg2FSL.Margin = New System.Windows.Forms.Padding(12, 16, 12, 16)
        Me.switch_Nothimg2FSL.Name = "switch_Nothimg2FSL"
        Me.switch_Nothimg2FSL.OffColor = System.Drawing.Color.Tomato
        Me.switch_Nothimg2FSL.OnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.switch_Nothimg2FSL.Size = New System.Drawing.Size(35, 20)
        Me.switch_Nothimg2FSL.TabIndex = 16
        Me.switch_Nothimg2FSL.Value = False
        '
        'switch_NothimgFSL
        '
        Me.switch_NothimgFSL.BackColor = System.Drawing.Color.Transparent
        Me.switch_NothimgFSL.BackgroundImage = CType(resources.GetObject("switch_NothimgFSL.BackgroundImage"), System.Drawing.Image)
        Me.switch_NothimgFSL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.switch_NothimgFSL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switch_NothimgFSL.Enabled = False
        Me.switch_NothimgFSL.Location = New System.Drawing.Point(81, 205)
        Me.switch_NothimgFSL.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.switch_NothimgFSL.Name = "switch_NothimgFSL"
        Me.switch_NothimgFSL.OffColor = System.Drawing.Color.Tomato
        Me.switch_NothimgFSL.OnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.switch_NothimgFSL.Size = New System.Drawing.Size(35, 20)
        Me.switch_NothimgFSL.TabIndex = 17
        Me.switch_NothimgFSL.Value = False
        '
        'switchOriginal_YoutubeTileFSF
        '
        Me.switchOriginal_YoutubeTileFSF.BackColor = System.Drawing.Color.Transparent
        Me.switchOriginal_YoutubeTileFSF.BackgroundImage = CType(resources.GetObject("switchOriginal_YoutubeTileFSF.BackgroundImage"), System.Drawing.Image)
        Me.switchOriginal_YoutubeTileFSF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.switchOriginal_YoutubeTileFSF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switchOriginal_YoutubeTileFSF.Location = New System.Drawing.Point(81, 160)
        Me.switchOriginal_YoutubeTileFSF.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.switchOriginal_YoutubeTileFSF.Name = "switchOriginal_YoutubeTileFSF"
        Me.switchOriginal_YoutubeTileFSF.OffColor = System.Drawing.Color.Tomato
        Me.switchOriginal_YoutubeTileFSF.OnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.switchOriginal_YoutubeTileFSF.Size = New System.Drawing.Size(35, 20)
        Me.switchOriginal_YoutubeTileFSF.TabIndex = 18
        Me.switchOriginal_YoutubeTileFSF.Value = True
        '
        'lblTextFSF1
        '
        Me.lblTextFSF1.AutoSize = True
        Me.lblTextFSF1.ForeColor = System.Drawing.Color.Black
        Me.lblTextFSF1.Location = New System.Drawing.Point(127, 163)
        Me.lblTextFSF1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTextFSF1.Name = "lblTextFSF1"
        Me.lblTextFSF1.Size = New System.Drawing.Size(144, 17)
        Me.lblTextFSF1.TabIndex = 13
        Me.lblTextFSF1.Text = "Original YouTube Title"
        '
        'lblCkbTextFSA3
        '
        Me.lblCkbTextFSA3.AutoSize = True
        Me.lblCkbTextFSA3.ForeColor = System.Drawing.Color.Tomato
        Me.lblCkbTextFSA3.Location = New System.Drawing.Point(134, 246)
        Me.lblCkbTextFSA3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCkbTextFSA3.Name = "lblCkbTextFSA3"
        Me.lblCkbTextFSA3.Size = New System.Drawing.Size(137, 17)
        Me.lblCkbTextFSA3.TabIndex = 14
        Me.lblCkbTextFSA3.Text = "Resolution Standard"
        '
        'lblCkbTextFSA2
        '
        Me.lblCkbTextFSA2.AutoSize = True
        Me.lblCkbTextFSA2.ForeColor = System.Drawing.Color.Tomato
        Me.lblCkbTextFSA2.Location = New System.Drawing.Point(129, 205)
        Me.lblCkbTextFSA2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCkbTextFSA2.Name = "lblCkbTextFSA2"
        Me.lblCkbTextFSA2.Size = New System.Drawing.Size(202, 17)
        Me.lblCkbTextFSA2.TabIndex = 15
        Me.lblCkbTextFSA2.Text = "Always Convert audio to mp3"
        '
        'btnNameInfoFSL
        '
        Me.btnNameInfoFSL.BackColor = System.Drawing.Color.White
        Me.btnNameInfoFSL.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.btnNameInfoFSL.ImageActive = Nothing
        Me.btnNameInfoFSL.Location = New System.Drawing.Point(382, 106)
        Me.btnNameInfoFSL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNameInfoFSL.Name = "btnNameInfoFSL"
        Me.btnNameInfoFSL.Size = New System.Drawing.Size(12, 16)
        Me.btnNameInfoFSL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnNameInfoFSL.TabIndex = 12
        Me.btnNameInfoFSL.TabStop = False
        Me.btnNameInfoFSL.Zoom = 10
        '
        'lblInfos_FileNameFSL
        '
        Me.lblInfos_FileNameFSL.AutoSize = True
        Me.lblInfos_FileNameFSL.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfos_FileNameFSL.Location = New System.Drawing.Point(98, 102)
        Me.lblInfos_FileNameFSL.Name = "lblInfos_FileNameFSL"
        Me.lblInfos_FileNameFSL.Size = New System.Drawing.Size(278, 15)
        Me.lblInfos_FileNameFSL.TabIndex = 11
        Me.lblInfos_FileNameFSL.Text = "Sensitive case please no special charactar allow"
        '
        'lblFileNameFLF
        '
        Me.lblFileNameFLF.AutoSize = True
        Me.lblFileNameFLF.Location = New System.Drawing.Point(8, 67)
        Me.lblFileNameFLF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFileNameFLF.Name = "lblFileNameFLF"
        Me.lblFileNameFLF.Size = New System.Drawing.Size(84, 17)
        Me.lblFileNameFLF.TabIndex = 1
        Me.lblFileNameFLF.Text = "File Name : "
        '
        'btnMainInfoFSL
        '
        Me.btnMainInfoFSL.BackColor = System.Drawing.Color.White
        Me.btnMainInfoFSL.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.btnMainInfoFSL.ImageActive = Nothing
        Me.btnMainInfoFSL.Location = New System.Drawing.Point(12, 355)
        Me.btnMainInfoFSL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMainInfoFSL.Name = "btnMainInfoFSL"
        Me.btnMainInfoFSL.Size = New System.Drawing.Size(31, 33)
        Me.btnMainInfoFSL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMainInfoFSL.TabIndex = 9
        Me.btnMainInfoFSL.TabStop = False
        Me.btnMainInfoFSL.Zoom = 10
        '
        'btnSaveFSL
        '
        Me.btnSaveFSL.BackColor = System.Drawing.Color.White
        Me.btnSaveFSL.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Save_64
        Me.btnSaveFSL.ImageActive = Nothing
        Me.btnSaveFSL.Location = New System.Drawing.Point(378, 351)
        Me.btnSaveFSL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveFSL.Name = "btnSaveFSL"
        Me.btnSaveFSL.Size = New System.Drawing.Size(64, 35)
        Me.btnSaveFSL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSaveFSL.TabIndex = 9
        Me.btnSaveFSL.TabStop = False
        Me.btnSaveFSL.Zoom = 10
        '
        'frmSetting_File
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(446, 399)
        Me.Controls.Add(Me.btnMainInfoFSL)
        Me.Controls.Add(Me.btnSaveFSL)
        Me.Controls.Add(Me.grpFileSettingsFSF)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSetting_File"
        Me.Text = "frmSetting_File"
        Me.grpFileSettingsFSF.ResumeLayout(False)
        Me.grpFileSettingsFSF.PerformLayout()
        CType(Me.btnNameInfoFSL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMainInfoFSL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveFSL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents grpFileSettingsFSF As GroupBox
    Friend WithEvents txtFileNameFSF As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblFileNameFLF As Label
    Friend WithEvents btnSaveFSL As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMainInfoFSL As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblInfos_FileNameFSL As Label
    Friend WithEvents btnNameInfoFSL As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents switch_Nothimg2FSL As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents switch_NothimgFSL As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents switchOriginal_YoutubeTileFSF As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents lblTextFSF1 As Label
    Friend WithEvents lblCkbTextFSA3 As Label
    Friend WithEvents lblCkbTextFSA2 As Label
End Class
