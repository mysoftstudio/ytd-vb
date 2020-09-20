<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStats))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.sepSystemStatusFS = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlDisplayFS = New System.Windows.Forms.Panel()
        Me.lblCopyrightFS = New System.Windows.Forms.Label()
        Me.sepDownStatusFS = New Bunifu.Framework.UI.BunifuSeparator()
        Me.btnVersionInfosFS = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSystemStatsFS = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnDownloadStatsFS = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnlTopMenu = New System.Windows.Forms.Panel()
        Me.btnUpgradeTM = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.btnCloseTM = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlTopMenu.SuspendLayout()
        CType(Me.btnCloseTM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'sepSystemStatusFS
        '
        Me.sepSystemStatusFS.BackColor = System.Drawing.Color.Transparent
        Me.sepSystemStatusFS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.sepSystemStatusFS.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.sepSystemStatusFS.LineThickness = 10
        Me.sepSystemStatusFS.Location = New System.Drawing.Point(66, 86)
        Me.sepSystemStatusFS.Name = "sepSystemStatusFS"
        Me.sepSystemStatusFS.Size = New System.Drawing.Size(246, 5)
        Me.sepSystemStatusFS.TabIndex = 5
        Me.sepSystemStatusFS.Transparency = 255
        Me.sepSystemStatusFS.Vertical = False
        Me.sepSystemStatusFS.Visible = False
        '
        'pnlDisplayFS
        '
        Me.pnlDisplayFS.Location = New System.Drawing.Point(12, 97)
        Me.pnlDisplayFS.Name = "pnlDisplayFS"
        Me.pnlDisplayFS.Size = New System.Drawing.Size(636, 262)
        Me.pnlDisplayFS.TabIndex = 6
        '
        'lblCopyrightFS
        '
        Me.lblCopyrightFS.AutoSize = True
        Me.lblCopyrightFS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyrightFS.ForeColor = System.Drawing.Color.Black
        Me.lblCopyrightFS.Location = New System.Drawing.Point(468, 377)
        Me.lblCopyrightFS.Name = "lblCopyrightFS"
        Me.lblCopyrightFS.Size = New System.Drawing.Size(185, 16)
        Me.lblCopyrightFS.TabIndex = 2
        Me.lblCopyrightFS.Text = "© MySoft Studio |Franz Nkemaka"
        '
        'sepDownStatusFS
        '
        Me.sepDownStatusFS.BackColor = System.Drawing.Color.Transparent
        Me.sepDownStatusFS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.sepDownStatusFS.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.sepDownStatusFS.LineThickness = 10
        Me.sepDownStatusFS.Location = New System.Drawing.Point(322, 86)
        Me.sepDownStatusFS.Name = "sepDownStatusFS"
        Me.sepDownStatusFS.Size = New System.Drawing.Size(246, 5)
        Me.sepDownStatusFS.TabIndex = 7
        Me.sepDownStatusFS.Transparency = 255
        Me.sepDownStatusFS.Vertical = False
        Me.sepDownStatusFS.Visible = False
        '
        'btnVersionInfosFS
        '
        Me.btnVersionInfosFS.ActiveBorderThickness = 1
        Me.btnVersionInfosFS.ActiveCornerRadius = 20
        Me.btnVersionInfosFS.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnVersionInfosFS.ActiveForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnVersionInfosFS.ActiveLineColor = System.Drawing.Color.Transparent
        Me.btnVersionInfosFS.BackColor = System.Drawing.Color.White
        Me.btnVersionInfosFS.BackgroundImage = CType(resources.GetObject("btnVersionInfosFS.BackgroundImage"), System.Drawing.Image)
        Me.btnVersionInfosFS.ButtonText = "1.0"
        Me.btnVersionInfosFS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVersionInfosFS.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVersionInfosFS.ForeColor = System.Drawing.Color.White
        Me.btnVersionInfosFS.IdleBorderThickness = 1
        Me.btnVersionInfosFS.IdleCornerRadius = 20
        Me.btnVersionInfosFS.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnVersionInfosFS.IdleForecolor = System.Drawing.Color.White
        Me.btnVersionInfosFS.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnVersionInfosFS.Location = New System.Drawing.Point(14, 367)
        Me.btnVersionInfosFS.Margin = New System.Windows.Forms.Padding(5)
        Me.btnVersionInfosFS.Name = "btnVersionInfosFS"
        Me.btnVersionInfosFS.Size = New System.Drawing.Size(69, 32)
        Me.btnVersionInfosFS.TabIndex = 3
        Me.btnVersionInfosFS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSystemStatsFS
        '
        Me.btnSystemStatsFS.ActiveBorderThickness = 1
        Me.btnSystemStatsFS.ActiveCornerRadius = 1
        Me.btnSystemStatsFS.ActiveFillColor = System.Drawing.Color.White
        Me.btnSystemStatsFS.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSystemStatsFS.ActiveLineColor = System.Drawing.Color.White
        Me.btnSystemStatsFS.BackColor = System.Drawing.Color.White
        Me.btnSystemStatsFS.BackgroundImage = CType(resources.GetObject("btnSystemStatsFS.BackgroundImage"), System.Drawing.Image)
        Me.btnSystemStatsFS.ButtonText = "System Stats"
        Me.btnSystemStatsFS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSystemStatsFS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSystemStatsFS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSystemStatsFS.IdleBorderThickness = 1
        Me.btnSystemStatsFS.IdleCornerRadius = 1
        Me.btnSystemStatsFS.IdleFillColor = System.Drawing.Color.White
        Me.btnSystemStatsFS.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSystemStatsFS.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSystemStatsFS.Location = New System.Drawing.Point(144, 47)
        Me.btnSystemStatsFS.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSystemStatsFS.Name = "btnSystemStatsFS"
        Me.btnSystemStatsFS.Size = New System.Drawing.Size(168, 49)
        Me.btnSystemStatsFS.TabIndex = 5
        Me.btnSystemStatsFS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDownloadStatsFS
        '
        Me.btnDownloadStatsFS.ActiveBorderThickness = 1
        Me.btnDownloadStatsFS.ActiveCornerRadius = 1
        Me.btnDownloadStatsFS.ActiveFillColor = System.Drawing.Color.White
        Me.btnDownloadStatsFS.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnDownloadStatsFS.ActiveLineColor = System.Drawing.Color.White
        Me.btnDownloadStatsFS.BackColor = System.Drawing.Color.White
        Me.btnDownloadStatsFS.BackgroundImage = CType(resources.GetObject("btnDownloadStatsFS.BackgroundImage"), System.Drawing.Image)
        Me.btnDownloadStatsFS.ButtonText = "Download Stats"
        Me.btnDownloadStatsFS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownloadStatsFS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownloadStatsFS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnDownloadStatsFS.IdleBorderThickness = 1
        Me.btnDownloadStatsFS.IdleCornerRadius = 1
        Me.btnDownloadStatsFS.IdleFillColor = System.Drawing.Color.White
        Me.btnDownloadStatsFS.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnDownloadStatsFS.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnDownloadStatsFS.Location = New System.Drawing.Point(322, 47)
        Me.btnDownloadStatsFS.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDownloadStatsFS.Name = "btnDownloadStatsFS"
        Me.btnDownloadStatsFS.Size = New System.Drawing.Size(168, 49)
        Me.btnDownloadStatsFS.TabIndex = 5
        Me.btnDownloadStatsFS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTopMenu
        '
        Me.pnlTopMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.pnlTopMenu.Controls.Add(Me.btnUpgradeTM)
        Me.pnlTopMenu.Controls.Add(Me.lblMainTitle)
        Me.pnlTopMenu.Controls.Add(Me.btnCloseTM)
        Me.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopMenu.Name = "pnlTopMenu"
        Me.pnlTopMenu.Size = New System.Drawing.Size(665, 39)
        Me.pnlTopMenu.TabIndex = 8
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
        Me.btnUpgradeTM.Location = New System.Drawing.Point(271, 0)
        Me.btnUpgradeTM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpgradeTM.Name = "btnUpgradeTM"
        Me.btnUpgradeTM.Size = New System.Drawing.Size(101, 34)
        Me.btnUpgradeTM.TabIndex = 9
        Me.btnUpgradeTM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMainTitle
        '
        Me.lblMainTitle.AutoSize = True
        Me.lblMainTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMainTitle.Font = New System.Drawing.Font("LONE WOLF PERSONAL USE", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitle.ForeColor = System.Drawing.Color.White
        Me.lblMainTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(45, 12)
        Me.lblMainTitle.TabIndex = 3
        Me.lblMainTitle.Text = "Stats"
        '
        'btnCloseTM
        '
        Me.btnCloseTM.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseTM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseTM.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Close_Window_641
        Me.btnCloseTM.ImageActive = Nothing
        Me.btnCloseTM.Location = New System.Drawing.Point(626, 7)
        Me.btnCloseTM.Name = "btnCloseTM"
        Me.btnCloseTM.Size = New System.Drawing.Size(27, 27)
        Me.btnCloseTM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCloseTM.TabIndex = 0
        Me.btnCloseTM.TabStop = False
        Me.btnCloseTM.Zoom = 10
        '
        'frmStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(665, 402)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.Controls.Add(Me.sepDownStatusFS)
        Me.Controls.Add(Me.lblCopyrightFS)
        Me.Controls.Add(Me.btnVersionInfosFS)
        Me.Controls.Add(Me.pnlDisplayFS)
        Me.Controls.Add(Me.sepSystemStatusFS)
        Me.Controls.Add(Me.btnSystemStatsFS)
        Me.Controls.Add(Me.btnDownloadStatsFS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStats"
        Me.Text = "Stats - MySoft YouTube Downloader"
        Me.pnlTopMenu.ResumeLayout(False)
        Me.pnlTopMenu.PerformLayout()
        CType(Me.btnCloseTM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents sepSystemStatusFS As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlDisplayFS As Panel
    Friend WithEvents btnDownloadStatsFS As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSystemStatsFS As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblCopyrightFS As Label
    Friend WithEvents btnVersionInfosFS As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents sepDownStatusFS As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlTopMenu As Panel
    Friend WithEvents lblMainTitle As Label
    Friend WithEvents btnCloseTM As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnUpgradeTM As Bunifu.Framework.UI.BunifuThinButton2
End Class
