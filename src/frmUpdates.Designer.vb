<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdates))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlTopMenu = New System.Windows.Forms.Panel()
        Me.btnUpgradeTM = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.btnThemeTM = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnGiftTM = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnUserTM = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCloseTM = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblTextFU = New System.Windows.Forms.Label()
        Me.lblCopyrightFU = New System.Windows.Forms.Label()
        Me.picUpToDate_varFU = New System.Windows.Forms.PictureBox()
        Me.btnVersionInfosFU = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnUpdate_varFU = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnCheckUpdates_varFU = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pgbChecking_varFU = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.picNewVersion_VarFU = New System.Windows.Forms.PictureBox()
        Me.wbbDownloadNewVersion_varFU = New System.Windows.Forms.WebBrowser()
        Me.blTextFU2 = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.NotifyIconDownFinish = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.pnlTopMenu.SuspendLayout()
        CType(Me.btnThemeTM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGiftTM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUserTM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseTM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUpToDate_varFU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNewVersion_VarFU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'pnlTopMenu
        '
        Me.pnlTopMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.pnlTopMenu.Controls.Add(Me.btnUpgradeTM)
        Me.pnlTopMenu.Controls.Add(Me.lblMainTitle)
        Me.pnlTopMenu.Controls.Add(Me.btnThemeTM)
        Me.pnlTopMenu.Controls.Add(Me.btnGiftTM)
        Me.pnlTopMenu.Controls.Add(Me.btnUserTM)
        Me.pnlTopMenu.Controls.Add(Me.btnCloseTM)
        Me.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopMenu.Name = "pnlTopMenu"
        Me.pnlTopMenu.Size = New System.Drawing.Size(642, 39)
        Me.pnlTopMenu.TabIndex = 4
        '
        'btnUpgradeTM
        '
        Me.btnUpgradeTM.ActiveBorderThickness = 1
        Me.btnUpgradeTM.ActiveCornerRadius = 1
        Me.btnUpgradeTM.ActiveFillColor = System.Drawing.Color.Transparent
        Me.btnUpgradeTM.ActiveForecolor = System.Drawing.Color.White
        Me.btnUpgradeTM.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnUpgradeTM.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnUpgradeTM.BackgroundImage = CType(resources.GetObject("btnUpgradeTM.BackgroundImage"), System.Drawing.Image)
        Me.btnUpgradeTM.ButtonText = "Upgrade Now"
        Me.btnUpgradeTM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpgradeTM.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpgradeTM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnUpgradeTM.IdleBorderThickness = 1
        Me.btnUpgradeTM.IdleCornerRadius = 1
        Me.btnUpgradeTM.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnUpgradeTM.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnUpgradeTM.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnUpgradeTM.Location = New System.Drawing.Point(240, 3)
        Me.btnUpgradeTM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpgradeTM.Name = "btnUpgradeTM"
        Me.btnUpgradeTM.Size = New System.Drawing.Size(101, 34)
        Me.btnUpgradeTM.TabIndex = 11
        Me.btnUpgradeTM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMainTitle
        '
        Me.lblMainTitle.AutoSize = True
        Me.lblMainTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMainTitle.Font = New System.Drawing.Font("LONE WOLF PERSONAL USE", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitle.ForeColor = System.Drawing.Color.White
        Me.lblMainTitle.Location = New System.Drawing.Point(35, 13)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(131, 12)
        Me.lblMainTitle.TabIndex = 3
        Me.lblMainTitle.Text = "Check For Updates"
        '
        'btnThemeTM
        '
        Me.btnThemeTM.BackColor = System.Drawing.Color.Transparent
        Me.btnThemeTM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThemeTM.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Change_Theme_64
        Me.btnThemeTM.ImageActive = Nothing
        Me.btnThemeTM.Location = New System.Drawing.Point(481, 3)
        Me.btnThemeTM.Name = "btnThemeTM"
        Me.btnThemeTM.Size = New System.Drawing.Size(27, 27)
        Me.btnThemeTM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnThemeTM.TabIndex = 0
        Me.btnThemeTM.TabStop = False
        Me.btnThemeTM.Zoom = 10
        '
        'btnGiftTM
        '
        Me.btnGiftTM.BackColor = System.Drawing.Color.Transparent
        Me.btnGiftTM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGiftTM.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Gift_48
        Me.btnGiftTM.ImageActive = Nothing
        Me.btnGiftTM.Location = New System.Drawing.Point(415, 3)
        Me.btnGiftTM.Name = "btnGiftTM"
        Me.btnGiftTM.Size = New System.Drawing.Size(27, 27)
        Me.btnGiftTM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGiftTM.TabIndex = 0
        Me.btnGiftTM.TabStop = False
        Me.btnGiftTM.Zoom = 10
        '
        'btnUserTM
        '
        Me.btnUserTM.BackColor = System.Drawing.Color.Transparent
        Me.btnUserTM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserTM.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_User_641
        Me.btnUserTM.ImageActive = Nothing
        Me.btnUserTM.Location = New System.Drawing.Point(448, 5)
        Me.btnUserTM.Name = "btnUserTM"
        Me.btnUserTM.Size = New System.Drawing.Size(27, 27)
        Me.btnUserTM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnUserTM.TabIndex = 0
        Me.btnUserTM.TabStop = False
        Me.btnUserTM.Zoom = 10
        '
        'btnCloseTM
        '
        Me.btnCloseTM.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseTM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseTM.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Close_Window_641
        Me.btnCloseTM.ImageActive = Nothing
        Me.btnCloseTM.Location = New System.Drawing.Point(609, 3)
        Me.btnCloseTM.Name = "btnCloseTM"
        Me.btnCloseTM.Size = New System.Drawing.Size(27, 27)
        Me.btnCloseTM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCloseTM.TabIndex = 0
        Me.btnCloseTM.TabStop = False
        Me.btnCloseTM.Zoom = 10
        '
        'lblTextFU
        '
        Me.lblTextFU.AutoSize = True
        Me.lblTextFU.BackColor = System.Drawing.Color.Transparent
        Me.lblTextFU.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextFU.ForeColor = System.Drawing.Color.Black
        Me.lblTextFU.Location = New System.Drawing.Point(33, 125)
        Me.lblTextFU.Name = "lblTextFU"
        Me.lblTextFU.Size = New System.Drawing.Size(506, 126)
        Me.lblTextFU.TabIndex = 5
        Me.lblTextFU.Text = resources.GetString("lblTextFU.Text")
        '
        'lblCopyrightFU
        '
        Me.lblCopyrightFU.AutoSize = True
        Me.lblCopyrightFU.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyrightFU.ForeColor = System.Drawing.Color.Black
        Me.lblCopyrightFU.Location = New System.Drawing.Point(448, 353)
        Me.lblCopyrightFU.Name = "lblCopyrightFU"
        Me.lblCopyrightFU.Size = New System.Drawing.Size(185, 16)
        Me.lblCopyrightFU.TabIndex = 8
        Me.lblCopyrightFU.Text = "© MySoft Studio |Franz Nkemaka"
        '
        'picUpToDate_varFU
        '
        Me.picUpToDate_varFU.BackColor = System.Drawing.Color.Transparent
        Me.picUpToDate_varFU.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.Logo_OK_KL_2017
        Me.picUpToDate_varFU.Location = New System.Drawing.Point(390, 45)
        Me.picUpToDate_varFU.Name = "picUpToDate_varFU"
        Me.picUpToDate_varFU.Size = New System.Drawing.Size(226, 87)
        Me.picUpToDate_varFU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUpToDate_varFU.TabIndex = 10
        Me.picUpToDate_varFU.TabStop = False
        Me.picUpToDate_varFU.Visible = False
        Me.picUpToDate_varFU.WaitOnLoad = True
        '
        'btnVersionInfosFU
        '
        Me.btnVersionInfosFU.ActiveBorderThickness = 1
        Me.btnVersionInfosFU.ActiveCornerRadius = 20
        Me.btnVersionInfosFU.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnVersionInfosFU.ActiveForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnVersionInfosFU.ActiveLineColor = System.Drawing.Color.Transparent
        Me.btnVersionInfosFU.BackColor = System.Drawing.Color.White
        Me.btnVersionInfosFU.BackgroundImage = CType(resources.GetObject("btnVersionInfosFU.BackgroundImage"), System.Drawing.Image)
        Me.btnVersionInfosFU.ButtonText = "1.0"
        Me.btnVersionInfosFU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVersionInfosFU.Font = New System.Drawing.Font("Century Gothic", 9.25!)
        Me.btnVersionInfosFU.ForeColor = System.Drawing.Color.White
        Me.btnVersionInfosFU.IdleBorderThickness = 1
        Me.btnVersionInfosFU.IdleCornerRadius = 20
        Me.btnVersionInfosFU.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnVersionInfosFU.IdleForecolor = System.Drawing.Color.White
        Me.btnVersionInfosFU.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnVersionInfosFU.Location = New System.Drawing.Point(14, 337)
        Me.btnVersionInfosFU.Margin = New System.Windows.Forms.Padding(5)
        Me.btnVersionInfosFU.Name = "btnVersionInfosFU"
        Me.btnVersionInfosFU.Size = New System.Drawing.Size(52, 32)
        Me.btnVersionInfosFU.TabIndex = 9
        Me.btnVersionInfosFU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdate_varFU
        '
        Me.btnUpdate_varFU.ActiveBorderThickness = 1
        Me.btnUpdate_varFU.ActiveCornerRadius = 20
        Me.btnUpdate_varFU.ActiveFillColor = System.Drawing.Color.Transparent
        Me.btnUpdate_varFU.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnUpdate_varFU.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnUpdate_varFU.BackColor = System.Drawing.Color.White
        Me.btnUpdate_varFU.BackgroundImage = CType(resources.GetObject("btnUpdate_varFU.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate_varFU.ButtonText = "Update Now"
        Me.btnUpdate_varFU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate_varFU.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_varFU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnUpdate_varFU.IdleBorderThickness = 1
        Me.btnUpdate_varFU.IdleCornerRadius = 2
        Me.btnUpdate_varFU.IdleFillColor = System.Drawing.Color.White
        Me.btnUpdate_varFU.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnUpdate_varFU.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnUpdate_varFU.Location = New System.Drawing.Point(219, 270)
        Me.btnUpdate_varFU.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUpdate_varFU.Name = "btnUpdate_varFU"
        Me.btnUpdate_varFU.Size = New System.Drawing.Size(180, 49)
        Me.btnUpdate_varFU.TabIndex = 7
        Me.btnUpdate_varFU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUpdate_varFU.Visible = False
        '
        'btnCheckUpdates_varFU
        '
        Me.btnCheckUpdates_varFU.ActiveBorderThickness = 1
        Me.btnCheckUpdates_varFU.ActiveCornerRadius = 20
        Me.btnCheckUpdates_varFU.ActiveFillColor = System.Drawing.Color.Transparent
        Me.btnCheckUpdates_varFU.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnCheckUpdates_varFU.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnCheckUpdates_varFU.BackColor = System.Drawing.Color.White
        Me.btnCheckUpdates_varFU.BackgroundImage = CType(resources.GetObject("btnCheckUpdates_varFU.BackgroundImage"), System.Drawing.Image)
        Me.btnCheckUpdates_varFU.ButtonText = "Check Updates"
        Me.btnCheckUpdates_varFU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckUpdates_varFU.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckUpdates_varFU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnCheckUpdates_varFU.IdleBorderThickness = 1
        Me.btnCheckUpdates_varFU.IdleCornerRadius = 2
        Me.btnCheckUpdates_varFU.IdleFillColor = System.Drawing.Color.White
        Me.btnCheckUpdates_varFU.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnCheckUpdates_varFU.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnCheckUpdates_varFU.Location = New System.Drawing.Point(219, 270)
        Me.btnCheckUpdates_varFU.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCheckUpdates_varFU.Name = "btnCheckUpdates_varFU"
        Me.btnCheckUpdates_varFU.Size = New System.Drawing.Size(180, 49)
        Me.btnCheckUpdates_varFU.TabIndex = 7
        Me.btnCheckUpdates_varFU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pgbChecking_varFU
        '
        Me.pgbChecking_varFU.animated = True
        Me.pgbChecking_varFU.animationIterval = 5
        Me.pgbChecking_varFU.animationSpeed = 3
        Me.pgbChecking_varFU.BackColor = System.Drawing.Color.Transparent
        Me.pgbChecking_varFU.BackgroundImage = CType(resources.GetObject("pgbChecking_varFU.BackgroundImage"), System.Drawing.Image)
        Me.pgbChecking_varFU.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.pgbChecking_varFU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.pgbChecking_varFU.LabelVisible = False
        Me.pgbChecking_varFU.LineProgressThickness = 8
        Me.pgbChecking_varFU.LineThickness = 5
        Me.pgbChecking_varFU.Location = New System.Drawing.Point(458, 250)
        Me.pgbChecking_varFU.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.pgbChecking_varFU.MaxValue = 100
        Me.pgbChecking_varFU.Name = "pgbChecking_varFU"
        Me.pgbChecking_varFU.ProgressBackColor = System.Drawing.Color.White
        Me.pgbChecking_varFU.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.pgbChecking_varFU.Size = New System.Drawing.Size(69, 69)
        Me.pgbChecking_varFU.TabIndex = 6
        Me.pgbChecking_varFU.Value = 30
        Me.pgbChecking_varFU.Visible = False
        '
        'picNewVersion_VarFU
        '
        Me.picNewVersion_VarFU.BackColor = System.Drawing.Color.Transparent
        Me.picNewVersion_VarFU.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.new_2
        Me.picNewVersion_VarFU.Location = New System.Drawing.Point(481, 72)
        Me.picNewVersion_VarFU.Name = "picNewVersion_VarFU"
        Me.picNewVersion_VarFU.Size = New System.Drawing.Size(160, 140)
        Me.picNewVersion_VarFU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNewVersion_VarFU.TabIndex = 10
        Me.picNewVersion_VarFU.TabStop = False
        Me.picNewVersion_VarFU.Visible = False
        Me.picNewVersion_VarFU.WaitOnLoad = True
        '
        'wbbDownloadNewVersion_varFU
        '
        Me.wbbDownloadNewVersion_varFU.Location = New System.Drawing.Point(311, 231)
        Me.wbbDownloadNewVersion_varFU.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbbDownloadNewVersion_varFU.Name = "wbbDownloadNewVersion_varFU"
        Me.wbbDownloadNewVersion_varFU.Size = New System.Drawing.Size(49, 31)
        Me.wbbDownloadNewVersion_varFU.TabIndex = 11
        Me.wbbDownloadNewVersion_varFU.Visible = False
        '
        'blTextFU2
        '
        Me.blTextFU2.AutoSize = True
        Me.blTextFU2.Font = New System.Drawing.Font("LONE WOLF PERSONAL USE", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blTextFU2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.blTextFU2.Location = New System.Drawing.Point(146, 72)
        Me.blTextFU2.Name = "blTextFU2"
        Me.blTextFU2.Size = New System.Drawing.Size(318, 35)
        Me.blTextFU2.TabIndex = 12
        Me.blTextFU2.Text = "Check For Updates"
        Me.blTextFU2.UseCompatibleTextRendering = True
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(83, 289)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(100, 20)
        Me.txtVersion.TabIndex = 14
        Me.txtVersion.Visible = False
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
        'frmUpdates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(642, 378)
        Me.Controls.Add(Me.picNewVersion_VarFU)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.blTextFU2)
        Me.Controls.Add(Me.wbbDownloadNewVersion_varFU)
        Me.Controls.Add(Me.picUpToDate_varFU)
        Me.Controls.Add(Me.btnVersionInfosFU)
        Me.Controls.Add(Me.lblCopyrightFU)
        Me.Controls.Add(Me.btnCheckUpdates_varFU)
        Me.Controls.Add(Me.pgbChecking_varFU)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.Controls.Add(Me.lblTextFU)
        Me.Controls.Add(Me.btnUpdate_varFU)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdates"
        Me.Text = "Updates - MySoft YouTube Dowloader"
        Me.pnlTopMenu.ResumeLayout(False)
        Me.pnlTopMenu.PerformLayout()
        CType(Me.btnThemeTM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGiftTM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUserTM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseTM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUpToDate_varFU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNewVersion_VarFU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlTopMenu As Panel
    Friend WithEvents lblMainTitle As Label
    Friend WithEvents btnThemeTM As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnGiftTM As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnUserTM As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCloseTM As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblTextFU As Label
    Friend WithEvents pgbChecking_varFU As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents btnUpdate_varFU As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnCheckUpdates_varFU As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblCopyrightFU As Label
    Friend WithEvents btnVersionInfosFU As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents picUpToDate_varFU As PictureBox
    Friend WithEvents picNewVersion_VarFU As PictureBox
    Friend WithEvents wbbDownloadNewVersion_varFU As WebBrowser
    Friend WithEvents blTextFU2 As Label
    Friend WithEvents btnUpgradeTM As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents NotifyIconDownFinish As NotifyIcon
End Class
