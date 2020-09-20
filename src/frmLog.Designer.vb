<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLog))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtLogFile_varFL = New System.Windows.Forms.TextBox()
        Me.pnlTopMenu = New System.Windows.Forms.Panel()
        Me.btnUpgradeTM = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.btnCloseFL = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSaveFL = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnClearFL = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnRefreshFL = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuDragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.pnlTopMenu.SuspendLayout()
        CType(Me.btnCloseFL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'txtLogFile_varFL
        '
        Me.txtLogFile_varFL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLogFile_varFL.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogFile_varFL.Location = New System.Drawing.Point(15, 59)
        Me.txtLogFile_varFL.Multiline = True
        Me.txtLogFile_varFL.Name = "txtLogFile_varFL"
        Me.txtLogFile_varFL.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLogFile_varFL.Size = New System.Drawing.Size(543, 301)
        Me.txtLogFile_varFL.TabIndex = 0
        '
        'pnlTopMenu
        '
        Me.pnlTopMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.pnlTopMenu.Controls.Add(Me.btnUpgradeTM)
        Me.pnlTopMenu.Controls.Add(Me.lblMainTitle)
        Me.pnlTopMenu.Controls.Add(Me.btnCloseFL)
        Me.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopMenu.Name = "pnlTopMenu"
        Me.pnlTopMenu.Size = New System.Drawing.Size(570, 39)
        Me.pnlTopMenu.TabIndex = 10
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
        Me.btnUpgradeTM.Location = New System.Drawing.Point(235, 2)
        Me.btnUpgradeTM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpgradeTM.Name = "btnUpgradeTM"
        Me.btnUpgradeTM.Size = New System.Drawing.Size(101, 34)
        Me.btnUpgradeTM.TabIndex = 10
        Me.btnUpgradeTM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMainTitle
        '
        Me.lblMainTitle.AutoSize = True
        Me.lblMainTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMainTitle.Font = New System.Drawing.Font("LONE WOLF PERSONAL USE", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitle.ForeColor = System.Drawing.Color.White
        Me.lblMainTitle.Location = New System.Drawing.Point(50, 18)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(37, 12)
        Me.lblMainTitle.TabIndex = 3
        Me.lblMainTitle.Text = "Log "
        '
        'btnCloseFL
        '
        Me.btnCloseFL.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseFL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseFL.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Close_Window_641
        Me.btnCloseFL.ImageActive = Nothing
        Me.btnCloseFL.Location = New System.Drawing.Point(531, 3)
        Me.btnCloseFL.Name = "btnCloseFL"
        Me.btnCloseFL.Size = New System.Drawing.Size(27, 27)
        Me.btnCloseFL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCloseFL.TabIndex = 0
        Me.btnCloseFL.TabStop = False
        Me.btnCloseFL.Zoom = 10
        '
        'btnSaveFL
        '
        Me.btnSaveFL.ActiveBorderThickness = 1
        Me.btnSaveFL.ActiveCornerRadius = 20
        Me.btnSaveFL.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveFL.ActiveForecolor = System.Drawing.Color.White
        Me.btnSaveFL.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveFL.BackColor = System.Drawing.Color.White
        Me.btnSaveFL.BackgroundImage = CType(resources.GetObject("btnSaveFL.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveFL.ButtonText = "Save"
        Me.btnSaveFL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveFL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveFL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveFL.IdleBorderThickness = 1
        Me.btnSaveFL.IdleCornerRadius = 2
        Me.btnSaveFL.IdleFillColor = System.Drawing.Color.White
        Me.btnSaveFL.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveFL.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveFL.Location = New System.Drawing.Point(115, 384)
        Me.btnSaveFL.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSaveFL.Name = "btnSaveFL"
        Me.btnSaveFL.Size = New System.Drawing.Size(133, 40)
        Me.btnSaveFL.TabIndex = 18
        Me.btnSaveFL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClearFL
        '
        Me.btnClearFL.ActiveBorderThickness = 1
        Me.btnClearFL.ActiveCornerRadius = 20
        Me.btnClearFL.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFL.ActiveForecolor = System.Drawing.Color.White
        Me.btnClearFL.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFL.BackColor = System.Drawing.Color.White
        Me.btnClearFL.BackgroundImage = CType(resources.GetObject("btnClearFL.BackgroundImage"), System.Drawing.Image)
        Me.btnClearFL.ButtonText = "Clear"
        Me.btnClearFL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearFL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFL.IdleBorderThickness = 1
        Me.btnClearFL.IdleCornerRadius = 2
        Me.btnClearFL.IdleFillColor = System.Drawing.Color.White
        Me.btnClearFL.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFL.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFL.Location = New System.Drawing.Point(258, 384)
        Me.btnClearFL.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClearFL.Name = "btnClearFL"
        Me.btnClearFL.Size = New System.Drawing.Size(133, 40)
        Me.btnClearFL.TabIndex = 19
        Me.btnClearFL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRefreshFL
        '
        Me.btnRefreshFL.ActiveBorderThickness = 1
        Me.btnRefreshFL.ActiveCornerRadius = 20
        Me.btnRefreshFL.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFL.ActiveForecolor = System.Drawing.Color.White
        Me.btnRefreshFL.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFL.BackColor = System.Drawing.Color.White
        Me.btnRefreshFL.BackgroundImage = CType(resources.GetObject("btnRefreshFL.BackgroundImage"), System.Drawing.Image)
        Me.btnRefreshFL.ButtonText = "Refresh"
        Me.btnRefreshFL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshFL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshFL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFL.IdleBorderThickness = 1
        Me.btnRefreshFL.IdleCornerRadius = 2
        Me.btnRefreshFL.IdleFillColor = System.Drawing.Color.White
        Me.btnRefreshFL.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFL.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefreshFL.Location = New System.Drawing.Point(401, 384)
        Me.btnRefreshFL.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRefreshFL.Name = "btnRefreshFL"
        Me.btnRefreshFL.Size = New System.Drawing.Size(133, 40)
        Me.btnRefreshFL.TabIndex = 19
        Me.btnRefreshFL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDragControl
        '
        Me.BunifuDragControl.Fixed = True
        Me.BunifuDragControl.Horizontal = True
        Me.BunifuDragControl.TargetControl = Me
        Me.BunifuDragControl.Vertical = True
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtLog.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtLog.Location = New System.Drawing.Point(27, 401)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(35, 23)
        Me.txtLog.TabIndex = 20
        Me.txtLog.Visible = False
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(570, 448)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.btnSaveFL)
        Me.Controls.Add(Me.btnRefreshFL)
        Me.Controls.Add(Me.btnClearFL)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.Controls.Add(Me.txtLogFile_varFL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLog"
        Me.Text = "Log - MySoft YouTube Downloader"
        Me.pnlTopMenu.ResumeLayout(False)
        Me.pnlTopMenu.PerformLayout()
        CType(Me.btnCloseFL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtLogFile_varFL As TextBox
    Friend WithEvents pnlTopMenu As Panel
    Friend WithEvents lblMainTitle As Label
    Friend WithEvents btnCloseFL As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSaveFL As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnRefreshFL As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnClearFL As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnUpgradeTM As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuDragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents txtLog As TextBox
End Class
