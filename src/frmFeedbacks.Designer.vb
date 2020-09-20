<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFeedbacks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFeedbacks))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlTopMenu = New System.Windows.Forms.Panel()
        Me.btnUpgradeTM = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.btnCloseF = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtMotive_Pb_varF = New System.Windows.Forms.TextBox()
        Me.lblFeedbackTextF1 = New System.Windows.Forms.Label()
        Me.lblFeedbackTextF3 = New System.Windows.Forms.Label()
        Me.lblFeedbackTextF4 = New System.Windows.Forms.Label()
        Me.txtEmailF = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtSocialUserF = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.dpdSocialNetF = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Rating_varStars = New Bunifu.Framework.UI.BunifuRating()
        Me.lblFeedbackTextF5 = New System.Windows.Forms.Label()
        Me.lblFeedbackTextF2 = New System.Windows.Forms.Label()
        Me.lblCopyrightFU = New System.Windows.Forms.Label()
        Me.btnSubmitF = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnClose = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuDragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.txtRank = New System.Windows.Forms.TextBox()
        Me.txtSocialNet = New System.Windows.Forms.TextBox()
        Me.pnlTopMenu.SuspendLayout()
        CType(Me.btnCloseF, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlTopMenu.Size = New System.Drawing.Size(690, 39)
        Me.pnlTopMenu.TabIndex = 9
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
        Me.btnUpgradeTM.Location = New System.Drawing.Point(295, 2)
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
        Me.lblMainTitle.Location = New System.Drawing.Point(50, 18)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(65, 12)
        Me.lblMainTitle.TabIndex = 3
        Me.lblMainTitle.Text = "FeedBack"
        '
        'btnCloseF
        '
        Me.btnCloseF.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseF.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Close_Window_641
        Me.btnCloseF.ImageActive = Nothing
        Me.btnCloseF.Location = New System.Drawing.Point(651, 5)
        Me.btnCloseF.Name = "btnCloseF"
        Me.btnCloseF.Size = New System.Drawing.Size(27, 27)
        Me.btnCloseF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCloseF.TabIndex = 0
        Me.btnCloseF.TabStop = False
        Me.btnCloseF.Zoom = 10
        '
        'txtMotive_Pb_varF
        '
        Me.txtMotive_Pb_varF.BackColor = System.Drawing.Color.White
        Me.txtMotive_Pb_varF.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMotive_Pb_varF.Location = New System.Drawing.Point(52, 100)
        Me.txtMotive_Pb_varF.Multiline = True
        Me.txtMotive_Pb_varF.Name = "txtMotive_Pb_varF"
        Me.txtMotive_Pb_varF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotive_Pb_varF.Size = New System.Drawing.Size(602, 132)
        Me.txtMotive_Pb_varF.TabIndex = 10
        '
        'lblFeedbackTextF1
        '
        Me.lblFeedbackTextF1.AutoSize = True
        Me.lblFeedbackTextF1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedbackTextF1.Location = New System.Drawing.Point(48, 64)
        Me.lblFeedbackTextF1.Name = "lblFeedbackTextF1"
        Me.lblFeedbackTextF1.Size = New System.Drawing.Size(129, 20)
        Me.lblFeedbackTextF1.TabIndex = 12
        Me.lblFeedbackTextF1.Text = "Problem Details :"
        '
        'lblFeedbackTextF3
        '
        Me.lblFeedbackTextF3.AutoSize = True
        Me.lblFeedbackTextF3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedbackTextF3.Location = New System.Drawing.Point(48, 266)
        Me.lblFeedbackTextF3.Name = "lblFeedbackTextF3"
        Me.lblFeedbackTextF3.Size = New System.Drawing.Size(130, 20)
        Me.lblFeedbackTextF3.TabIndex = 12
        Me.lblFeedbackTextF3.Text = "Contact E-Mail : "
        '
        'lblFeedbackTextF4
        '
        Me.lblFeedbackTextF4.AutoSize = True
        Me.lblFeedbackTextF4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedbackTextF4.Location = New System.Drawing.Point(47, 315)
        Me.lblFeedbackTextF4.Name = "lblFeedbackTextF4"
        Me.lblFeedbackTextF4.Size = New System.Drawing.Size(129, 20)
        Me.lblFeedbackTextF4.TabIndex = 12
        Me.lblFeedbackTextF4.Text = "Online Contact: "
        '
        'txtEmailF
        '
        Me.txtEmailF.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtEmailF.BorderColorIdle = System.Drawing.Color.Gray
        Me.txtEmailF.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtEmailF.BorderThickness = 2
        Me.txtEmailF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailF.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtEmailF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmailF.isPassword = False
        Me.txtEmailF.Location = New System.Drawing.Point(185, 258)
        Me.txtEmailF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmailF.Name = "txtEmailF"
        Me.txtEmailF.Size = New System.Drawing.Size(360, 32)
        Me.txtEmailF.TabIndex = 14
        Me.txtEmailF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtSocialUserF
        '
        Me.txtSocialUserF.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtSocialUserF.BorderColorIdle = System.Drawing.Color.Gray
        Me.txtSocialUserF.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtSocialUserF.BorderThickness = 2
        Me.txtSocialUserF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSocialUserF.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSocialUserF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSocialUserF.isPassword = False
        Me.txtSocialUserF.Location = New System.Drawing.Point(185, 342)
        Me.txtSocialUserF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSocialUserF.Name = "txtSocialUserF"
        Me.txtSocialUserF.Size = New System.Drawing.Size(360, 24)
        Me.txtSocialUserF.TabIndex = 14
        Me.txtSocialUserF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dpdSocialNetF
        '
        Me.dpdSocialNetF.BackColor = System.Drawing.Color.Transparent
        Me.dpdSocialNetF.BorderRadius = 3
        Me.dpdSocialNetF.DisabledColor = System.Drawing.Color.Gray
        Me.dpdSocialNetF.Font = New System.Drawing.Font("Century Gothic", 9.25!)
        Me.dpdSocialNetF.ForeColor = System.Drawing.Color.White
        Me.dpdSocialNetF.Items = New String() {"Skype ", "WhatsApp", "Facebook", "Messenger", "Instagram ", "Twitter"}
        Me.dpdSocialNetF.Location = New System.Drawing.Point(40, 342)
        Me.dpdSocialNetF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dpdSocialNetF.Name = "dpdSocialNetF"
        Me.dpdSocialNetF.NomalColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.dpdSocialNetF.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.dpdSocialNetF.selectedIndex = -1
        Me.dpdSocialNetF.Size = New System.Drawing.Size(138, 24)
        Me.dpdSocialNetF.TabIndex = 15
        '
        'Rating_varStars
        '
        Me.Rating_varStars.BackColor = System.Drawing.Color.Transparent
        Me.Rating_varStars.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Rating_varStars.Location = New System.Drawing.Point(185, 390)
        Me.Rating_varStars.Name = "Rating_varStars"
        Me.Rating_varStars.Size = New System.Drawing.Size(161, 37)
        Me.Rating_varStars.TabIndex = 16
        Me.Rating_varStars.Value = 0
        '
        'lblFeedbackTextF5
        '
        Me.lblFeedbackTextF5.AutoSize = True
        Me.lblFeedbackTextF5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedbackTextF5.Location = New System.Drawing.Point(115, 407)
        Me.lblFeedbackTextF5.Name = "lblFeedbackTextF5"
        Me.lblFeedbackTextF5.Size = New System.Drawing.Size(63, 20)
        Me.lblFeedbackTextF5.TabIndex = 12
        Me.lblFeedbackTextF5.Text = "Rating: "
        '
        'lblFeedbackTextF2
        '
        Me.lblFeedbackTextF2.AutoSize = True
        Me.lblFeedbackTextF2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedbackTextF2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblFeedbackTextF2.Location = New System.Drawing.Point(449, 64)
        Me.lblFeedbackTextF2.Name = "lblFeedbackTextF2"
        Me.lblFeedbackTextF2.Size = New System.Drawing.Size(205, 20)
        Me.lblFeedbackTextF2.TabIndex = 12
        Me.lblFeedbackTextF2.Text = "Report / Positive Comment"
        '
        'lblCopyrightFU
        '
        Me.lblCopyrightFU.AutoSize = True
        Me.lblCopyrightFU.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyrightFU.ForeColor = System.Drawing.Color.Black
        Me.lblCopyrightFU.Location = New System.Drawing.Point(12, 470)
        Me.lblCopyrightFU.Name = "lblCopyrightFU"
        Me.lblCopyrightFU.Size = New System.Drawing.Size(185, 16)
        Me.lblCopyrightFU.TabIndex = 18
        Me.lblCopyrightFU.Text = "© MySoft Studio |Franz Nkemaka"
        '
        'btnSubmitF
        '
        Me.btnSubmitF.ActiveBorderThickness = 1
        Me.btnSubmitF.ActiveCornerRadius = 20
        Me.btnSubmitF.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSubmitF.ActiveForecolor = System.Drawing.Color.White
        Me.btnSubmitF.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSubmitF.BackColor = System.Drawing.Color.White
        Me.btnSubmitF.BackgroundImage = CType(resources.GetObject("btnSubmitF.BackgroundImage"), System.Drawing.Image)
        Me.btnSubmitF.ButtonText = "Submit"
        Me.btnSubmitF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmitF.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSubmitF.IdleBorderThickness = 1
        Me.btnSubmitF.IdleCornerRadius = 2
        Me.btnSubmitF.IdleFillColor = System.Drawing.Color.White
        Me.btnSubmitF.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSubmitF.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSubmitF.Location = New System.Drawing.Point(402, 441)
        Me.btnSubmitF.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSubmitF.Name = "btnSubmitF"
        Me.btnSubmitF.Size = New System.Drawing.Size(133, 40)
        Me.btnSubmitF.TabIndex = 17
        Me.btnSubmitF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.ActiveBorderThickness = 1
        Me.btnClose.ActiveCornerRadius = 20
        Me.btnClose.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClose.ActiveForecolor = System.Drawing.Color.White
        Me.btnClose.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.ButtonText = "Close"
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClose.IdleBorderThickness = 1
        Me.btnClose.IdleCornerRadius = 2
        Me.btnClose.IdleFillColor = System.Drawing.Color.White
        Me.btnClose.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClose.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(545, 441)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(133, 40)
        Me.btnClose.TabIndex = 17
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDragControl
        '
        Me.BunifuDragControl.Fixed = True
        Me.BunifuDragControl.Horizontal = True
        Me.BunifuDragControl.TargetControl = Me
        Me.BunifuDragControl.Vertical = True
        '
        'txtRank
        '
        Me.txtRank.Location = New System.Drawing.Point(234, 294)
        Me.txtRank.Name = "txtRank"
        Me.txtRank.Size = New System.Drawing.Size(311, 20)
        Me.txtRank.TabIndex = 19
        Me.txtRank.Visible = False
        '
        'txtSocialNet
        '
        Me.txtSocialNet.Location = New System.Drawing.Point(234, 317)
        Me.txtSocialNet.Name = "txtSocialNet"
        Me.txtSocialNet.Size = New System.Drawing.Size(311, 20)
        Me.txtSocialNet.TabIndex = 19
        Me.txtSocialNet.Visible = False
        '
        'frmFeedbacks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(690, 495)
        Me.Controls.Add(Me.txtSocialNet)
        Me.Controls.Add(Me.txtRank)
        Me.Controls.Add(Me.lblCopyrightFU)
        Me.Controls.Add(Me.btnSubmitF)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Rating_varStars)
        Me.Controls.Add(Me.dpdSocialNetF)
        Me.Controls.Add(Me.txtSocialUserF)
        Me.Controls.Add(Me.txtEmailF)
        Me.Controls.Add(Me.lblFeedbackTextF5)
        Me.Controls.Add(Me.lblFeedbackTextF4)
        Me.Controls.Add(Me.lblFeedbackTextF3)
        Me.Controls.Add(Me.lblFeedbackTextF2)
        Me.Controls.Add(Me.lblFeedbackTextF1)
        Me.Controls.Add(Me.txtMotive_Pb_varF)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFeedbacks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Feedbacks - MySoft YouTube Downloader"
        Me.pnlTopMenu.ResumeLayout(False)
        Me.pnlTopMenu.PerformLayout()
        CType(Me.btnCloseF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlTopMenu As Panel
    Friend WithEvents lblMainTitle As Label
    Friend WithEvents btnCloseF As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtMotive_Pb_varF As TextBox
    Friend WithEvents Rating_varStars As Bunifu.Framework.UI.BunifuRating
    Friend WithEvents dpdSocialNetF As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txtSocialUserF As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtEmailF As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblFeedbackTextF5 As Label
    Friend WithEvents lblFeedbackTextF4 As Label
    Friend WithEvents lblFeedbackTextF3 As Label
    Friend WithEvents lblFeedbackTextF1 As Label
    Friend WithEvents btnSubmitF As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblFeedbackTextF2 As Label
    Friend WithEvents lblCopyrightFU As Label
    Friend WithEvents btnUpgradeTM As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuDragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents txtRank As TextBox
    Friend WithEvents txtSocialNet As TextBox
End Class
