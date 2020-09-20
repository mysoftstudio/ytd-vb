<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistory))
        Me.lblTextFH1 = New System.Windows.Forms.Label()
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ListViewHistory_varFH = New System.Windows.Forms.ListView()
        Me.clhFHL_varDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhFHL_varSource = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhFHL_varVidUrl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhFHL_varSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhFHL_varFormat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhFHL_varQuality = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhFHL_varVidTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhFHL_varPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSaveFH = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnRefreshFH = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnExportFH = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.imgbtnFH_Setting = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgbtnFH_MoreInfos = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgbtnFH_YouTubeSmall = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgbtnFH_Save = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgbtnFH_Refresh = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgbtnFH_Preview = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgbtnFH_Export = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnClearFH = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.imgbtnFH_Setting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnFH_MoreInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnFH_YouTubeSmall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnFH_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnFH_Refresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnFH_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnFH_Export, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTextFH1
        '
        Me.lblTextFH1.AutoSize = True
        Me.lblTextFH1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblTextFH1.Location = New System.Drawing.Point(12, 39)
        Me.lblTextFH1.Name = "lblTextFH1"
        Me.lblTextFH1.Size = New System.Drawing.Size(246, 20)
        Me.lblTextFH1.TabIndex = 0
        Me.lblTextFH1.Text = "A Resume of all  Your Downloads"
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'ListViewHistory_varFH
        '
        Me.ListViewHistory_varFH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListViewHistory_varFH.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhFHL_varDate, Me.clhFHL_varSource, Me.clhFHL_varVidUrl, Me.clhFHL_varSize, Me.clhFHL_varFormat, Me.clhFHL_varQuality, Me.clhFHL_varVidTitle, Me.clhFHL_varPath})
        Me.ListViewHistory_varFH.Font = New System.Drawing.Font("Century Gothic", 9.25!)
        Me.ListViewHistory_varFH.GridLines = True
        Me.ListViewHistory_varFH.Location = New System.Drawing.Point(12, 73)
        Me.ListViewHistory_varFH.Name = "ListViewHistory_varFH"
        Me.ListViewHistory_varFH.Size = New System.Drawing.Size(651, 325)
        Me.ListViewHistory_varFH.TabIndex = 1
        Me.ListViewHistory_varFH.UseCompatibleStateImageBehavior = False
        Me.ListViewHistory_varFH.View = System.Windows.Forms.View.Details
        '
        'clhFHL_varDate
        '
        Me.clhFHL_varDate.Text = "Date Time : "
        Me.clhFHL_varDate.Width = 112
        '
        'clhFHL_varSource
        '
        Me.clhFHL_varSource.Text = "Source : "
        Me.clhFHL_varSource.Width = 68
        '
        'clhFHL_varVidUrl
        '
        Me.clhFHL_varVidUrl.Text = "Video Url :"
        Me.clhFHL_varVidUrl.Width = 174
        '
        'clhFHL_varSize
        '
        Me.clhFHL_varSize.Text = "Size :"
        Me.clhFHL_varSize.Width = 43
        '
        'clhFHL_varFormat
        '
        Me.clhFHL_varFormat.Text = "Format :"
        '
        'clhFHL_varQuality
        '
        Me.clhFHL_varQuality.Text = "Quality :"
        Me.clhFHL_varQuality.Width = 64
        '
        'clhFHL_varVidTitle
        '
        Me.clhFHL_varVidTitle.Text = "Video Title :"
        Me.clhFHL_varVidTitle.Width = 297
        '
        'clhFHL_varPath
        '
        Me.clhFHL_varPath.Text = "Path : "
        Me.clhFHL_varPath.Width = 317
        '
        'btnSaveFH
        '
        Me.btnSaveFH.ActiveBorderThickness = 1
        Me.btnSaveFH.ActiveCornerRadius = 1
        Me.btnSaveFH.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveFH.ActiveForecolor = System.Drawing.Color.White
        Me.btnSaveFH.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveFH.BackColor = System.Drawing.Color.White
        Me.btnSaveFH.BackgroundImage = CType(resources.GetObject("btnSaveFH.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveFH.ButtonText = "Save"
        Me.btnSaveFH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveFH.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btnSaveFH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveFH.IdleBorderThickness = 1
        Me.btnSaveFH.IdleCornerRadius = 1
        Me.btnSaveFH.IdleFillColor = System.Drawing.Color.White
        Me.btnSaveFH.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveFH.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveFH.Location = New System.Drawing.Point(582, 23)
        Me.btnSaveFH.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSaveFH.Name = "btnSaveFH"
        Me.btnSaveFH.Size = New System.Drawing.Size(79, 36)
        Me.btnSaveFH.TabIndex = 17
        Me.btnSaveFH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRefreshFH
        '
        Me.btnRefreshFH.ActiveBorderThickness = 1
        Me.btnRefreshFH.ActiveCornerRadius = 1
        Me.btnRefreshFH.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFH.ActiveForecolor = System.Drawing.Color.White
        Me.btnRefreshFH.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFH.BackColor = System.Drawing.Color.White
        Me.btnRefreshFH.BackgroundImage = CType(resources.GetObject("btnRefreshFH.BackgroundImage"), System.Drawing.Image)
        Me.btnRefreshFH.ButtonText = "Refresh"
        Me.btnRefreshFH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshFH.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btnRefreshFH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFH.IdleBorderThickness = 1
        Me.btnRefreshFH.IdleCornerRadius = 1
        Me.btnRefreshFH.IdleFillColor = System.Drawing.Color.White
        Me.btnRefreshFH.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFH.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFH.Location = New System.Drawing.Point(410, 23)
        Me.btnRefreshFH.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRefreshFH.Name = "btnRefreshFH"
        Me.btnRefreshFH.Size = New System.Drawing.Size(79, 36)
        Me.btnRefreshFH.TabIndex = 17
        Me.btnRefreshFH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExportFH
        '
        Me.btnExportFH.ActiveBorderThickness = 1
        Me.btnExportFH.ActiveCornerRadius = 1
        Me.btnExportFH.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnExportFH.ActiveForecolor = System.Drawing.Color.White
        Me.btnExportFH.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnExportFH.BackColor = System.Drawing.Color.White
        Me.btnExportFH.BackgroundImage = CType(resources.GetObject("btnExportFH.BackgroundImage"), System.Drawing.Image)
        Me.btnExportFH.ButtonText = "Load"
        Me.btnExportFH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportFH.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btnExportFH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnExportFH.IdleBorderThickness = 1
        Me.btnExportFH.IdleCornerRadius = 1
        Me.btnExportFH.IdleFillColor = System.Drawing.Color.White
        Me.btnExportFH.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnExportFH.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnExportFH.Location = New System.Drawing.Point(321, 23)
        Me.btnExportFH.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExportFH.Name = "btnExportFH"
        Me.btnExportFH.Size = New System.Drawing.Size(79, 36)
        Me.btnExportFH.TabIndex = 17
        Me.btnExportFH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgbtnFH_Setting
        '
        Me.imgbtnFH_Setting.BackColor = System.Drawing.Color.White
        Me.imgbtnFH_Setting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFH_Setting.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Settings_64
        Me.imgbtnFH_Setting.ImageActive = Nothing
        Me.imgbtnFH_Setting.Location = New System.Drawing.Point(640, 405)
        Me.imgbtnFH_Setting.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnFH_Setting.Name = "imgbtnFH_Setting"
        Me.imgbtnFH_Setting.Size = New System.Drawing.Size(23, 23)
        Me.imgbtnFH_Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFH_Setting.TabIndex = 23
        Me.imgbtnFH_Setting.TabStop = False
        Me.imgbtnFH_Setting.Zoom = 10
        '
        'imgbtnFH_MoreInfos
        '
        Me.imgbtnFH_MoreInfos.BackColor = System.Drawing.Color.White
        Me.imgbtnFH_MoreInfos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFH_MoreInfos.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.imgbtnFH_MoreInfos.ImageActive = Nothing
        Me.imgbtnFH_MoreInfos.Location = New System.Drawing.Point(611, 405)
        Me.imgbtnFH_MoreInfos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnFH_MoreInfos.Name = "imgbtnFH_MoreInfos"
        Me.imgbtnFH_MoreInfos.Size = New System.Drawing.Size(23, 23)
        Me.imgbtnFH_MoreInfos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFH_MoreInfos.TabIndex = 24
        Me.imgbtnFH_MoreInfos.TabStop = False
        Me.imgbtnFH_MoreInfos.Zoom = 10
        '
        'imgbtnFH_YouTubeSmall
        '
        Me.imgbtnFH_YouTubeSmall.BackColor = System.Drawing.Color.White
        Me.imgbtnFH_YouTubeSmall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFH_YouTubeSmall.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_YouTube_48
        Me.imgbtnFH_YouTubeSmall.ImageActive = Nothing
        Me.imgbtnFH_YouTubeSmall.Location = New System.Drawing.Point(582, 405)
        Me.imgbtnFH_YouTubeSmall.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnFH_YouTubeSmall.Name = "imgbtnFH_YouTubeSmall"
        Me.imgbtnFH_YouTubeSmall.Size = New System.Drawing.Size(23, 23)
        Me.imgbtnFH_YouTubeSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFH_YouTubeSmall.TabIndex = 24
        Me.imgbtnFH_YouTubeSmall.TabStop = False
        Me.imgbtnFH_YouTubeSmall.Zoom = 10
        '
        'imgbtnFH_Save
        '
        Me.imgbtnFH_Save.BackColor = System.Drawing.Color.White
        Me.imgbtnFH_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFH_Save.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Save_64
        Me.imgbtnFH_Save.ImageActive = Nothing
        Me.imgbtnFH_Save.Location = New System.Drawing.Point(553, 405)
        Me.imgbtnFH_Save.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnFH_Save.Name = "imgbtnFH_Save"
        Me.imgbtnFH_Save.Size = New System.Drawing.Size(23, 23)
        Me.imgbtnFH_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFH_Save.TabIndex = 24
        Me.imgbtnFH_Save.TabStop = False
        Me.imgbtnFH_Save.Zoom = 10
        '
        'imgbtnFH_Refresh
        '
        Me.imgbtnFH_Refresh.BackColor = System.Drawing.Color.White
        Me.imgbtnFH_Refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFH_Refresh.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Reset_64
        Me.imgbtnFH_Refresh.ImageActive = Nothing
        Me.imgbtnFH_Refresh.Location = New System.Drawing.Point(524, 405)
        Me.imgbtnFH_Refresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnFH_Refresh.Name = "imgbtnFH_Refresh"
        Me.imgbtnFH_Refresh.Size = New System.Drawing.Size(23, 23)
        Me.imgbtnFH_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFH_Refresh.TabIndex = 24
        Me.imgbtnFH_Refresh.TabStop = False
        Me.imgbtnFH_Refresh.Zoom = 10
        '
        'imgbtnFH_Preview
        '
        Me.imgbtnFH_Preview.BackColor = System.Drawing.Color.White
        Me.imgbtnFH_Preview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFH_Preview.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Preview_Pane_64
        Me.imgbtnFH_Preview.ImageActive = Nothing
        Me.imgbtnFH_Preview.Location = New System.Drawing.Point(495, 405)
        Me.imgbtnFH_Preview.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnFH_Preview.Name = "imgbtnFH_Preview"
        Me.imgbtnFH_Preview.Size = New System.Drawing.Size(23, 23)
        Me.imgbtnFH_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFH_Preview.TabIndex = 24
        Me.imgbtnFH_Preview.TabStop = False
        Me.imgbtnFH_Preview.Zoom = 10
        '
        'imgbtnFH_Export
        '
        Me.imgbtnFH_Export.BackColor = System.Drawing.Color.White
        Me.imgbtnFH_Export.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnFH_Export.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Import_50
        Me.imgbtnFH_Export.ImageActive = Nothing
        Me.imgbtnFH_Export.Location = New System.Drawing.Point(466, 405)
        Me.imgbtnFH_Export.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnFH_Export.Name = "imgbtnFH_Export"
        Me.imgbtnFH_Export.Size = New System.Drawing.Size(23, 23)
        Me.imgbtnFH_Export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnFH_Export.TabIndex = 24
        Me.imgbtnFH_Export.TabStop = False
        Me.imgbtnFH_Export.Zoom = 10
        '
        'btnClearFH
        '
        Me.btnClearFH.ActiveBorderThickness = 1
        Me.btnClearFH.ActiveCornerRadius = 1
        Me.btnClearFH.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFH.ActiveForecolor = System.Drawing.Color.White
        Me.btnClearFH.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFH.BackColor = System.Drawing.Color.White
        Me.btnClearFH.BackgroundImage = CType(resources.GetObject("btnClearFH.BackgroundImage"), System.Drawing.Image)
        Me.btnClearFH.ButtonText = "Clear"
        Me.btnClearFH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearFH.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btnClearFH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFH.IdleBorderThickness = 1
        Me.btnClearFH.IdleCornerRadius = 1
        Me.btnClearFH.IdleFillColor = System.Drawing.Color.White
        Me.btnClearFH.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFH.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFH.Location = New System.Drawing.Point(497, 23)
        Me.btnClearFH.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClearFH.Name = "btnClearFH"
        Me.btnClearFH.Size = New System.Drawing.Size(79, 36)
        Me.btnClearFH.TabIndex = 17
        Me.btnClearFH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(675, 436)
        Me.Controls.Add(Me.imgbtnFH_Setting)
        Me.Controls.Add(Me.imgbtnFH_Export)
        Me.Controls.Add(Me.imgbtnFH_Preview)
        Me.Controls.Add(Me.imgbtnFH_Refresh)
        Me.Controls.Add(Me.imgbtnFH_Save)
        Me.Controls.Add(Me.imgbtnFH_YouTubeSmall)
        Me.Controls.Add(Me.imgbtnFH_MoreInfos)
        Me.Controls.Add(Me.btnClearFH)
        Me.Controls.Add(Me.btnExportFH)
        Me.Controls.Add(Me.btnRefreshFH)
        Me.Controls.Add(Me.btnSaveFH)
        Me.Controls.Add(Me.ListViewHistory_varFH)
        Me.Controls.Add(Me.lblTextFH1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHistory"
        Me.Text = "frmHistory"
        CType(Me.imgbtnFH_Setting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnFH_MoreInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnFH_YouTubeSmall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnFH_Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnFH_Refresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnFH_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnFH_Export, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTextFH1 As Label
    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ListViewHistory_varFH As ListView
    Friend WithEvents clhFHL_varDate As ColumnHeader
    Friend WithEvents clhFHL_varSource As ColumnHeader
    Friend WithEvents clhFHL_varVidTitle As ColumnHeader
    Friend WithEvents clhFHL_varVidUrl As ColumnHeader
    Friend WithEvents clhFHL_varSize As ColumnHeader
    Friend WithEvents clhFHL_varFormat As ColumnHeader
    Friend WithEvents clhFHL_varQuality As ColumnHeader
    Friend WithEvents clhFHL_varPath As ColumnHeader
    Friend WithEvents btnExportFH As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnRefreshFH As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSaveFH As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents imgbtnFH_Setting As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgbtnFH_MoreInfos As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgbtnFH_Preview As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgbtnFH_Refresh As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgbtnFH_Save As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgbtnFH_YouTubeSmall As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgbtnFH_Export As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnClearFH As Bunifu.Framework.UI.BunifuThinButton2
End Class
