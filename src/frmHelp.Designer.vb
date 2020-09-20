<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlTopMenu = New System.Windows.Forms.Panel()
        Me.btnUpgradeTM = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.btnCloseF = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblFeedbackTextFH1 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.lblFeedbackTextFH2 = New System.Windows.Forms.Label()
        Me.lblMySoftStudio_linkFH = New System.Windows.Forms.Label()
        Me.lblFeedbackTextFH3 = New System.Windows.Forms.Label()
        Me.MailTo_FH = New System.Windows.Forms.Label()
        Me.btnMailUS_ContactFH = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMoreInfosFH = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnFeedback_contactFH = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAboutFH = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTopMenu.SuspendLayout()
        CType(Me.btnCloseF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMailUS_ContactFH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMoreInfosFH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFeedback_contactFH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAboutFH, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlTopMenu.Controls.Add(Me.btnCloseF)
        Me.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopMenu.Name = "pnlTopMenu"
        Me.pnlTopMenu.Size = New System.Drawing.Size(799, 39)
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
        Me.btnUpgradeTM.Location = New System.Drawing.Point(344, 0)
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
        Me.lblMainTitle.Location = New System.Drawing.Point(46, 9)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(33, 12)
        Me.lblMainTitle.TabIndex = 3
        Me.lblMainTitle.Text = "Help"
        '
        'btnCloseF
        '
        Me.btnCloseF.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseF.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Close_Window_641
        Me.btnCloseF.ImageActive = Nothing
        Me.btnCloseF.Location = New System.Drawing.Point(740, 5)
        Me.btnCloseF.Name = "btnCloseF"
        Me.btnCloseF.Size = New System.Drawing.Size(27, 27)
        Me.btnCloseF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCloseF.TabIndex = 0
        Me.btnCloseF.TabStop = False
        Me.btnCloseF.Zoom = 10
        '
        'lblFeedbackTextFH1
        '
        Me.lblFeedbackTextFH1.AutoSize = True
        Me.lblFeedbackTextFH1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedbackTextFH1.Location = New System.Drawing.Point(33, 42)
        Me.lblFeedbackTextFH1.Name = "lblFeedbackTextFH1"
        Me.lblFeedbackTextFH1.Size = New System.Drawing.Size(324, 20)
        Me.lblFeedbackTextFH1.TabIndex = 13
        Me.lblFeedbackTextFH1.Text = "How to Start ? MySoft YouTube Dowloader :"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 65)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(799, 413)
        Me.WebBrowser1.TabIndex = 14
        '
        'lblFeedbackTextFH2
        '
        Me.lblFeedbackTextFH2.AutoSize = True
        Me.lblFeedbackTextFH2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedbackTextFH2.Location = New System.Drawing.Point(21, 499)
        Me.lblFeedbackTextFH2.Name = "lblFeedbackTextFH2"
        Me.lblFeedbackTextFH2.Size = New System.Drawing.Size(287, 20)
        Me.lblFeedbackTextFH2.TabIndex = 15
        Me.lblFeedbackTextFH2.Text = "Not Satisty ? More Services ?  Visit Us : "
        '
        'lblMySoftStudio_linkFH
        '
        Me.lblMySoftStudio_linkFH.AutoSize = True
        Me.lblMySoftStudio_linkFH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMySoftStudio_linkFH.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblMySoftStudio_linkFH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblMySoftStudio_linkFH.Location = New System.Drawing.Point(314, 502)
        Me.lblMySoftStudio_linkFH.Name = "lblMySoftStudio_linkFH"
        Me.lblMySoftStudio_linkFH.Size = New System.Drawing.Size(192, 17)
        Me.lblMySoftStudio_linkFH.TabIndex = 16
        Me.lblMySoftStudio_linkFH.Text = "http://www.mysoftstudio.ml"
        '
        'lblFeedbackTextFH3
        '
        Me.lblFeedbackTextFH3.AutoSize = True
        Me.lblFeedbackTextFH3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedbackTextFH3.Location = New System.Drawing.Point(209, 533)
        Me.lblFeedbackTextFH3.Name = "lblFeedbackTextFH3"
        Me.lblFeedbackTextFH3.Size = New System.Drawing.Size(99, 20)
        Me.lblFeedbackTextFH3.TabIndex = 17
        Me.lblFeedbackTextFH3.Text = "Contact Us :"
        '
        'MailTo_FH
        '
        Me.MailTo_FH.AutoSize = True
        Me.MailTo_FH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MailTo_FH.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.MailTo_FH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.MailTo_FH.Location = New System.Drawing.Point(314, 536)
        Me.MailTo_FH.Name = "MailTo_FH"
        Me.MailTo_FH.Size = New System.Drawing.Size(181, 17)
        Me.MailTo_FH.TabIndex = 16
        Me.MailTo_FH.Text = "mysoftstudio.mail@gmx.de"
        '
        'btnMailUS_ContactFH
        '
        Me.btnMailUS_ContactFH.BackColor = System.Drawing.Color.Transparent
        Me.btnMailUS_ContactFH.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Contact_Details_50
        Me.btnMailUS_ContactFH.ImageActive = Nothing
        Me.btnMailUS_ContactFH.Location = New System.Drawing.Point(745, 521)
        Me.btnMailUS_ContactFH.Name = "btnMailUS_ContactFH"
        Me.btnMailUS_ContactFH.Size = New System.Drawing.Size(42, 32)
        Me.btnMailUS_ContactFH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMailUS_ContactFH.TabIndex = 18
        Me.btnMailUS_ContactFH.TabStop = False
        Me.btnMailUS_ContactFH.Zoom = 10
        '
        'btnMoreInfosFH
        '
        Me.btnMoreInfosFH.BackColor = System.Drawing.Color.Transparent
        Me.btnMoreInfosFH.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_More_Info_48
        Me.btnMoreInfosFH.ImageActive = Nothing
        Me.btnMoreInfosFH.Location = New System.Drawing.Point(700, 521)
        Me.btnMoreInfosFH.Name = "btnMoreInfosFH"
        Me.btnMoreInfosFH.Size = New System.Drawing.Size(39, 32)
        Me.btnMoreInfosFH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMoreInfosFH.TabIndex = 19
        Me.btnMoreInfosFH.TabStop = False
        Me.btnMoreInfosFH.Zoom = 10
        '
        'btnFeedback_contactFH
        '
        Me.btnFeedback_contactFH.BackColor = System.Drawing.Color.Transparent
        Me.btnFeedback_contactFH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFeedback_contactFH.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Feedback_64
        Me.btnFeedback_contactFH.ImageActive = Nothing
        Me.btnFeedback_contactFH.Location = New System.Drawing.Point(657, 524)
        Me.btnFeedback_contactFH.Name = "btnFeedback_contactFH"
        Me.btnFeedback_contactFH.Size = New System.Drawing.Size(37, 29)
        Me.btnFeedback_contactFH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnFeedback_contactFH.TabIndex = 20
        Me.btnFeedback_contactFH.TabStop = False
        Me.btnFeedback_contactFH.Zoom = 10
        '
        'btnAboutFH
        '
        Me.btnAboutFH.BackColor = System.Drawing.Color.Transparent
        Me.btnAboutFH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAboutFH.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_About_64
        Me.btnAboutFH.ImageActive = Nothing
        Me.btnAboutFH.Location = New System.Drawing.Point(614, 524)
        Me.btnAboutFH.Name = "btnAboutFH"
        Me.btnAboutFH.Size = New System.Drawing.Size(37, 29)
        Me.btnAboutFH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAboutFH.TabIndex = 21
        Me.btnAboutFH.TabStop = False
        Me.btnAboutFH.Zoom = 10
        '
        'BunifuDragControl
        '
        Me.BunifuDragControl.Fixed = True
        Me.BunifuDragControl.Horizontal = True
        Me.BunifuDragControl.TargetControl = Me
        Me.BunifuDragControl.Vertical = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(554, 481)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Open with Browser ?"
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(799, 565)
        Me.Controls.Add(Me.btnAboutFH)
        Me.Controls.Add(Me.btnFeedback_contactFH)
        Me.Controls.Add(Me.btnMoreInfosFH)
        Me.Controls.Add(Me.btnMailUS_ContactFH)
        Me.Controls.Add(Me.lblFeedbackTextFH3)
        Me.Controls.Add(Me.MailTo_FH)
        Me.Controls.Add(Me.lblMySoftStudio_linkFH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFeedbackTextFH2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.lblFeedbackTextFH1)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHelp"
        Me.Text = "Help | Documentation - MySoft YouTube Downloader"
        Me.pnlTopMenu.ResumeLayout(False)
        Me.pnlTopMenu.PerformLayout()
        CType(Me.btnCloseF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMailUS_ContactFH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMoreInfosFH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFeedback_contactFH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAboutFH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlTopMenu As Panel
    Friend WithEvents lblMainTitle As Label
    Friend WithEvents btnCloseF As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblFeedbackTextFH2 As Label
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents lblFeedbackTextFH1 As Label
    Friend WithEvents lblMySoftStudio_linkFH As Label
    Friend WithEvents lblFeedbackTextFH3 As Label
    Friend WithEvents MailTo_FH As Label
    Friend WithEvents btnMailUS_ContactFH As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMoreInfosFH As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnFeedback_contactFH As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAboutFH As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnUpgradeTM As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuDragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label1 As Label
End Class
