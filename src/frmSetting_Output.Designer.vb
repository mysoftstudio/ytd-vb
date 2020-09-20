<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting_Output
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
        Me.grpOutputSettingsFSO = New System.Windows.Forms.GroupBox()
        Me.lblTextFSO6 = New System.Windows.Forms.Label()
        Me.btnSelectPathFSO = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ckbFSO_Overwrite_IfExist = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.ckbFSO_KeepOrig_FileName = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lblTextFSO3 = New System.Windows.Forms.Label()
        Me.ckbFSO_SaveVidThumbnail = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lblTextFSO2 = New System.Windows.Forms.Label()
        Me.lblTextFSO5 = New System.Windows.Forms.Label()
        Me.lblTextFSO1 = New System.Windows.Forms.Label()
        Me.txtFilePathFSO = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnSaveFSO = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMainInfoFSO = New Bunifu.Framework.UI.BunifuImageButton()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.grpOutputSettingsFSO.SuspendLayout()
        CType(Me.btnSelectPathFSO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveFSO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMainInfoFSO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'grpOutputSettingsFSO
        '
        Me.grpOutputSettingsFSO.Controls.Add(Me.lblTextFSO6)
        Me.grpOutputSettingsFSO.Controls.Add(Me.btnSelectPathFSO)
        Me.grpOutputSettingsFSO.Controls.Add(Me.ckbFSO_Overwrite_IfExist)
        Me.grpOutputSettingsFSO.Controls.Add(Me.ckbFSO_KeepOrig_FileName)
        Me.grpOutputSettingsFSO.Controls.Add(Me.lblTextFSO3)
        Me.grpOutputSettingsFSO.Controls.Add(Me.ckbFSO_SaveVidThumbnail)
        Me.grpOutputSettingsFSO.Controls.Add(Me.lblTextFSO2)
        Me.grpOutputSettingsFSO.Controls.Add(Me.lblTextFSO5)
        Me.grpOutputSettingsFSO.Controls.Add(Me.lblTextFSO1)
        Me.grpOutputSettingsFSO.Controls.Add(Me.txtFilePathFSO)
        Me.grpOutputSettingsFSO.Location = New System.Drawing.Point(13, 22)
        Me.grpOutputSettingsFSO.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOutputSettingsFSO.Name = "grpOutputSettingsFSO"
        Me.grpOutputSettingsFSO.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOutputSettingsFSO.Size = New System.Drawing.Size(420, 276)
        Me.grpOutputSettingsFSO.TabIndex = 1
        Me.grpOutputSettingsFSO.TabStop = False
        Me.grpOutputSettingsFSO.Text = "Output Settings"
        '
        'lblTextFSO6
        '
        Me.lblTextFSO6.AutoSize = True
        Me.lblTextFSO6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextFSO6.Location = New System.Drawing.Point(209, 103)
        Me.lblTextFSO6.Name = "lblTextFSO6"
        Me.lblTextFSO6.Size = New System.Drawing.Size(125, 15)
        Me.lblTextFSO6.TabIndex = 12
        Me.lblTextFSO6.Text = "Please Browse a Path"
        '
        'btnSelectPathFSO
        '
        Me.btnSelectPathFSO.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectPathFSO.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Import_50
        Me.btnSelectPathFSO.ImageActive = Nothing
        Me.btnSelectPathFSO.Location = New System.Drawing.Point(341, 103)
        Me.btnSelectPathFSO.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelectPathFSO.Name = "btnSelectPathFSO"
        Me.btnSelectPathFSO.Size = New System.Drawing.Size(38, 28)
        Me.btnSelectPathFSO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSelectPathFSO.TabIndex = 6
        Me.btnSelectPathFSO.TabStop = False
        Me.btnSelectPathFSO.Zoom = 10
        '
        'ckbFSO_Overwrite_IfExist
        '
        Me.ckbFSO_Overwrite_IfExist.BackColor = System.Drawing.Color.Tomato
        Me.ckbFSO_Overwrite_IfExist.ChechedOffColor = System.Drawing.Color.Tomato
        Me.ckbFSO_Overwrite_IfExist.Checked = False
        Me.ckbFSO_Overwrite_IfExist.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSO_Overwrite_IfExist.ForeColor = System.Drawing.Color.White
        Me.ckbFSO_Overwrite_IfExist.Location = New System.Drawing.Point(35, 200)
        Me.ckbFSO_Overwrite_IfExist.Margin = New System.Windows.Forms.Padding(5)
        Me.ckbFSO_Overwrite_IfExist.Name = "ckbFSO_Overwrite_IfExist"
        Me.ckbFSO_Overwrite_IfExist.Size = New System.Drawing.Size(20, 20)
        Me.ckbFSO_Overwrite_IfExist.TabIndex = 5
        '
        'ckbFSO_KeepOrig_FileName
        '
        Me.ckbFSO_KeepOrig_FileName.BackColor = System.Drawing.Color.Tomato
        Me.ckbFSO_KeepOrig_FileName.ChechedOffColor = System.Drawing.Color.Tomato
        Me.ckbFSO_KeepOrig_FileName.Checked = False
        Me.ckbFSO_KeepOrig_FileName.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSO_KeepOrig_FileName.ForeColor = System.Drawing.Color.White
        Me.ckbFSO_KeepOrig_FileName.Location = New System.Drawing.Point(35, 172)
        Me.ckbFSO_KeepOrig_FileName.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbFSO_KeepOrig_FileName.Name = "ckbFSO_KeepOrig_FileName"
        Me.ckbFSO_KeepOrig_FileName.Size = New System.Drawing.Size(20, 20)
        Me.ckbFSO_KeepOrig_FileName.TabIndex = 5
        '
        'lblTextFSO3
        '
        Me.lblTextFSO3.AutoSize = True
        Me.lblTextFSO3.ForeColor = System.Drawing.Color.Tomato
        Me.lblTextFSO3.Location = New System.Drawing.Point(63, 203)
        Me.lblTextFSO3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTextFSO3.Name = "lblTextFSO3"
        Me.lblTextFSO3.Size = New System.Drawing.Size(158, 17)
        Me.lblTextFSO3.TabIndex = 0
        Me.lblTextFSO3.Text = "Overwrite if Video Exist "
        '
        'ckbFSO_SaveVidThumbnail
        '
        Me.ckbFSO_SaveVidThumbnail.BackColor = System.Drawing.Color.Tomato
        Me.ckbFSO_SaveVidThumbnail.ChechedOffColor = System.Drawing.Color.Tomato
        Me.ckbFSO_SaveVidThumbnail.Checked = False
        Me.ckbFSO_SaveVidThumbnail.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ckbFSO_SaveVidThumbnail.Enabled = False
        Me.ckbFSO_SaveVidThumbnail.ForeColor = System.Drawing.Color.White
        Me.ckbFSO_SaveVidThumbnail.Location = New System.Drawing.Point(35, 143)
        Me.ckbFSO_SaveVidThumbnail.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbFSO_SaveVidThumbnail.Name = "ckbFSO_SaveVidThumbnail"
        Me.ckbFSO_SaveVidThumbnail.Size = New System.Drawing.Size(20, 20)
        Me.ckbFSO_SaveVidThumbnail.TabIndex = 5
        '
        'lblTextFSO2
        '
        Me.lblTextFSO2.AutoSize = True
        Me.lblTextFSO2.ForeColor = System.Drawing.Color.Tomato
        Me.lblTextFSO2.Location = New System.Drawing.Point(63, 172)
        Me.lblTextFSO2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTextFSO2.Name = "lblTextFSO2"
        Me.lblTextFSO2.Size = New System.Drawing.Size(179, 17)
        Me.lblTextFSO2.TabIndex = 0
        Me.lblTextFSO2.Text = "Keep original Video Name"
        '
        'lblTextFSO5
        '
        Me.lblTextFSO5.AutoSize = True
        Me.lblTextFSO5.Location = New System.Drawing.Point(18, 33)
        Me.lblTextFSO5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTextFSO5.Name = "lblTextFSO5"
        Me.lblTextFSO5.Size = New System.Drawing.Size(101, 17)
        Me.lblTextFSO5.TabIndex = 0
        Me.lblTextFSO5.Text = "Output Folder "
        '
        'lblTextFSO1
        '
        Me.lblTextFSO1.AutoSize = True
        Me.lblTextFSO1.ForeColor = System.Drawing.Color.Tomato
        Me.lblTextFSO1.Location = New System.Drawing.Point(63, 143)
        Me.lblTextFSO1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTextFSO1.Name = "lblTextFSO1"
        Me.lblTextFSO1.Size = New System.Drawing.Size(151, 17)
        Me.lblTextFSO1.TabIndex = 0
        Me.lblTextFSO1.Text = "Save Video Thumbnail"
        '
        'txtFilePathFSO
        '
        Me.txtFilePathFSO.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtFilePathFSO.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtFilePathFSO.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtFilePathFSO.BorderThickness = 3
        Me.txtFilePathFSO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilePathFSO.Enabled = False
        Me.txtFilePathFSO.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtFilePathFSO.ForeColor = System.Drawing.Color.Black
        Me.txtFilePathFSO.isPassword = False
        Me.txtFilePathFSO.Location = New System.Drawing.Point(21, 55)
        Me.txtFilePathFSO.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFilePathFSO.Name = "txtFilePathFSO"
        Me.txtFilePathFSO.Size = New System.Drawing.Size(358, 39)
        Me.txtFilePathFSO.TabIndex = 2
        Me.txtFilePathFSO.Text = "C:/"
        Me.txtFilePathFSO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSaveFSO
        '
        Me.btnSaveFSO.BackColor = System.Drawing.Color.White
        Me.btnSaveFSO.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Save_64
        Me.btnSaveFSO.ImageActive = Nothing
        Me.btnSaveFSO.Location = New System.Drawing.Point(383, 351)
        Me.btnSaveFSO.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveFSO.Name = "btnSaveFSO"
        Me.btnSaveFSO.Size = New System.Drawing.Size(50, 41)
        Me.btnSaveFSO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSaveFSO.TabIndex = 3
        Me.btnSaveFSO.TabStop = False
        Me.btnSaveFSO.Zoom = 10
        '
        'btnMainInfoFSO
        '
        Me.btnMainInfoFSO.BackColor = System.Drawing.Color.White
        Me.btnMainInfoFSO.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.btnMainInfoFSO.ImageActive = Nothing
        Me.btnMainInfoFSO.Location = New System.Drawing.Point(13, 353)
        Me.btnMainInfoFSO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMainInfoFSO.Name = "btnMainInfoFSO"
        Me.btnMainInfoFSO.Size = New System.Drawing.Size(31, 33)
        Me.btnMainInfoFSO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMainInfoFSO.TabIndex = 14
        Me.btnMainInfoFSO.TabStop = False
        Me.btnMainInfoFSO.Zoom = 10
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "Browse Save Location"
        '
        'frmSetting_Output
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(446, 399)
        Me.Controls.Add(Me.btnMainInfoFSO)
        Me.Controls.Add(Me.btnSaveFSO)
        Me.Controls.Add(Me.grpOutputSettingsFSO)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSetting_Output"
        Me.Text = "frmSetting_Output"
        Me.grpOutputSettingsFSO.ResumeLayout(False)
        Me.grpOutputSettingsFSO.PerformLayout()
        CType(Me.btnSelectPathFSO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveFSO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMainInfoFSO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents grpOutputSettingsFSO As GroupBox
    Friend WithEvents txtFilePathFSO As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnSaveFSO As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ckbFSO_KeepOrig_FileName As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents ckbFSO_SaveVidThumbnail As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lblTextFSO2 As Label
    Friend WithEvents lblTextFSO5 As Label
    Friend WithEvents lblTextFSO1 As Label
    Friend WithEvents btnSelectPathFSO As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ckbFSO_Overwrite_IfExist As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lblTextFSO3 As Label
    Friend WithEvents btnMainInfoFSO As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblTextFSO6 As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
End Class
