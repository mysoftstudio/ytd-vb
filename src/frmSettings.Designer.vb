<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlTopMenu = New System.Windows.Forms.Panel()
        Me.btnCloseTM = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlDisplayHM = New System.Windows.Forms.Panel()
        Me.grpPremiumHM = New Bunifu.Framework.UI.BunifuCards()
        Me.lblPremiumFeaturesSM12 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM6 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM5 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM3 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM2 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM1 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM7 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM8 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM11 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM10 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM9 = New System.Windows.Forms.Label()
        Me.btnGetPremiumDM = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.picCheckMarkSM11 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM10 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM9 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM8 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM7 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM6 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM5 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM4 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM3 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM2 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM1 = New System.Windows.Forms.PictureBox()
        Me.pnlMainMenu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblCopyrightMM = New System.Windows.Forms.Label()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.pnlAvatarMenu = New System.Windows.Forms.Panel()
        Me.lblSettingMM = New System.Windows.Forms.Label()
        Me.imgAvatarMM = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnVersionInfosMM = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnGeneralMM = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnOutputMM = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnFileMM = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAdvancedMM = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pnlTopMenu.SuspendLayout()
        CType(Me.btnCloseTM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDisplayHM.SuspendLayout()
        Me.grpPremiumHM.SuspendLayout()
        CType(Me.picCheckMarkSM11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMainMenu.SuspendLayout()
        Me.pnlAvatarMenu.SuspendLayout()
        CType(Me.imgAvatarMM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'pnlTopMenu
        '
        Me.pnlTopMenu.BackColor = System.Drawing.Color.White
        Me.pnlTopMenu.Controls.Add(Me.btnCloseTM)
        Me.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMenu.Location = New System.Drawing.Point(226, 0)
        Me.pnlTopMenu.Name = "pnlTopMenu"
        Me.pnlTopMenu.Size = New System.Drawing.Size(455, 39)
        Me.pnlTopMenu.TabIndex = 2
        '
        'btnCloseTM
        '
        Me.btnCloseTM.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseTM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseTM.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Close_Window_64
        Me.btnCloseTM.ImageActive = Nothing
        Me.btnCloseTM.Location = New System.Drawing.Point(422, 3)
        Me.btnCloseTM.Name = "btnCloseTM"
        Me.btnCloseTM.Size = New System.Drawing.Size(27, 27)
        Me.btnCloseTM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCloseTM.TabIndex = 0
        Me.btnCloseTM.TabStop = False
        Me.btnCloseTM.Zoom = 10
        '
        'pnlDisplayHM
        '
        Me.pnlDisplayHM.BackColor = System.Drawing.SystemColors.Control
        Me.pnlDisplayHM.Controls.Add(Me.grpPremiumHM)
        Me.pnlDisplayHM.Location = New System.Drawing.Point(229, 38)
        Me.pnlDisplayHM.Name = "pnlDisplayHM"
        Me.pnlDisplayHM.Size = New System.Drawing.Size(446, 399)
        Me.pnlDisplayHM.TabIndex = 4
        '
        'grpPremiumHM
        '
        Me.grpPremiumHM.BackColor = System.Drawing.Color.White
        Me.grpPremiumHM.BorderRadius = 5
        Me.grpPremiumHM.BottomSahddow = True
        Me.grpPremiumHM.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.grpPremiumHM.Controls.Add(Me.lblPremiumFeaturesSM12)
        Me.grpPremiumHM.Controls.Add(Me.lblPremiumFeaturesSM6)
        Me.grpPremiumHM.Controls.Add(Me.lblPremiumFeaturesSM5)
        Me.grpPremiumHM.Controls.Add(Me.lblPremiumFeaturesSM3)
        Me.grpPremiumHM.Controls.Add(Me.lblPremiumFeaturesSM2)
        Me.grpPremiumHM.Controls.Add(Me.lblPremiumFeaturesSM1)
        Me.grpPremiumHM.Controls.Add(Me.lblPremiumFeaturesSM7)
        Me.grpPremiumHM.Controls.Add(Me.lblPremiumFeaturesSM8)
        Me.grpPremiumHM.Controls.Add(Me.lblPremiumFeaturesSM11)
        Me.grpPremiumHM.Controls.Add(Me.lblPremiumFeaturesSM10)
        Me.grpPremiumHM.Controls.Add(Me.lblPremiumFeaturesSM9)
        Me.grpPremiumHM.Controls.Add(Me.btnGetPremiumDM)
        Me.grpPremiumHM.Controls.Add(Me.picCheckMarkSM11)
        Me.grpPremiumHM.Controls.Add(Me.picCheckMarkSM10)
        Me.grpPremiumHM.Controls.Add(Me.picCheckMarkSM9)
        Me.grpPremiumHM.Controls.Add(Me.picCheckMarkSM8)
        Me.grpPremiumHM.Controls.Add(Me.picCheckMarkSM7)
        Me.grpPremiumHM.Controls.Add(Me.picCheckMarkSM6)
        Me.grpPremiumHM.Controls.Add(Me.picCheckMarkSM5)
        Me.grpPremiumHM.Controls.Add(Me.picCheckMarkSM4)
        Me.grpPremiumHM.Controls.Add(Me.picCheckMarkSM3)
        Me.grpPremiumHM.Controls.Add(Me.picCheckMarkSM2)
        Me.grpPremiumHM.Controls.Add(Me.picCheckMarkSM1)
        Me.grpPremiumHM.Cursor = System.Windows.Forms.Cursors.Cross
        Me.grpPremiumHM.LeftSahddow = False
        Me.grpPremiumHM.Location = New System.Drawing.Point(54, 6)
        Me.grpPremiumHM.Name = "grpPremiumHM"
        Me.grpPremiumHM.RightSahddow = True
        Me.grpPremiumHM.ShadowDepth = 20
        Me.grpPremiumHM.Size = New System.Drawing.Size(326, 379)
        Me.grpPremiumHM.TabIndex = 2
        '
        'lblPremiumFeaturesSM12
        '
        Me.lblPremiumFeaturesSM12.AutoSize = True
        Me.lblPremiumFeaturesSM12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM12.Location = New System.Drawing.Point(50, 11)
        Me.lblPremiumFeaturesSM12.Name = "lblPremiumFeaturesSM12"
        Me.lblPremiumFeaturesSM12.Size = New System.Drawing.Size(153, 20)
        Me.lblPremiumFeaturesSM12.TabIndex = 2
        Me.lblPremiumFeaturesSM12.Text = "Auto-History Mailing"
        '
        'lblPremiumFeaturesSM6
        '
        Me.lblPremiumFeaturesSM6.AutoSize = True
        Me.lblPremiumFeaturesSM6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM6.Location = New System.Drawing.Point(52, 278)
        Me.lblPremiumFeaturesSM6.Name = "lblPremiumFeaturesSM6"
        Me.lblPremiumFeaturesSM6.Size = New System.Drawing.Size(212, 20)
        Me.lblPremiumFeaturesSM6.TabIndex = 2
        Me.lblPremiumFeaturesSM6.Text = "Video Likes and Information"
        '
        'lblPremiumFeaturesSM5
        '
        Me.lblPremiumFeaturesSM5.AutoSize = True
        Me.lblPremiumFeaturesSM5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM5.Location = New System.Drawing.Point(52, 250)
        Me.lblPremiumFeaturesSM5.Name = "lblPremiumFeaturesSM5"
        Me.lblPremiumFeaturesSM5.Size = New System.Drawing.Size(155, 20)
        Me.lblPremiumFeaturesSM5.TabIndex = 2
        Me.lblPremiumFeaturesSM5.Text = "Live Video Counter "
        '
        'lblPremiumFeaturesSM3
        '
        Me.lblPremiumFeaturesSM3.AutoSize = True
        Me.lblPremiumFeaturesSM3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM3.Location = New System.Drawing.Point(50, 227)
        Me.lblPremiumFeaturesSM3.Name = "lblPremiumFeaturesSM3"
        Me.lblPremiumFeaturesSM3.Size = New System.Drawing.Size(106, 20)
        Me.lblPremiumFeaturesSM3.TabIndex = 2
        Me.lblPremiumFeaturesSM3.Text = " Video Player"
        '
        'lblPremiumFeaturesSM2
        '
        Me.lblPremiumFeaturesSM2.AutoSize = True
        Me.lblPremiumFeaturesSM2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM2.Location = New System.Drawing.Point(52, 201)
        Me.lblPremiumFeaturesSM2.Name = "lblPremiumFeaturesSM2"
        Me.lblPremiumFeaturesSM2.Size = New System.Drawing.Size(159, 20)
        Me.lblPremiumFeaturesSM2.TabIndex = 2
        Me.lblPremiumFeaturesSM2.Text = "QR CODE Link sharer"
        '
        'lblPremiumFeaturesSM1
        '
        Me.lblPremiumFeaturesSM1.AutoSize = True
        Me.lblPremiumFeaturesSM1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM1.Location = New System.Drawing.Point(52, 170)
        Me.lblPremiumFeaturesSM1.Name = "lblPremiumFeaturesSM1"
        Me.lblPremiumFeaturesSM1.Size = New System.Drawing.Size(243, 20)
        Me.lblPremiumFeaturesSM1.TabIndex = 2
        Me.lblPremiumFeaturesSM1.Text = "Thumbnails and GIF Auto Maker "
        '
        'lblPremiumFeaturesSM7
        '
        Me.lblPremiumFeaturesSM7.AutoSize = True
        Me.lblPremiumFeaturesSM7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM7.Location = New System.Drawing.Point(52, 141)
        Me.lblPremiumFeaturesSM7.Name = "lblPremiumFeaturesSM7"
        Me.lblPremiumFeaturesSM7.Size = New System.Drawing.Size(226, 20)
        Me.lblPremiumFeaturesSM7.TabIndex = 2
        Me.lblPremiumFeaturesSM7.Text = "Faster Speed And Best Quality"
        '
        'lblPremiumFeaturesSM8
        '
        Me.lblPremiumFeaturesSM8.AutoSize = True
        Me.lblPremiumFeaturesSM8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM8.Location = New System.Drawing.Point(52, 111)
        Me.lblPremiumFeaturesSM8.Name = "lblPremiumFeaturesSM8"
        Me.lblPremiumFeaturesSM8.Size = New System.Drawing.Size(129, 20)
        Me.lblPremiumFeaturesSM8.TabIndex = 2
        Me.lblPremiumFeaturesSM8.Text = "Commercial Use"
        '
        'lblPremiumFeaturesSM11
        '
        Me.lblPremiumFeaturesSM11.AutoSize = True
        Me.lblPremiumFeaturesSM11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM11.Location = New System.Drawing.Point(50, 37)
        Me.lblPremiumFeaturesSM11.Name = "lblPremiumFeaturesSM11"
        Me.lblPremiumFeaturesSM11.Size = New System.Drawing.Size(190, 20)
        Me.lblPremiumFeaturesSM11.TabIndex = 2
        Me.lblPremiumFeaturesSM11.Text = "More Advanced Themes"
        '
        'lblPremiumFeaturesSM10
        '
        Me.lblPremiumFeaturesSM10.AutoSize = True
        Me.lblPremiumFeaturesSM10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM10.Location = New System.Drawing.Point(52, 62)
        Me.lblPremiumFeaturesSM10.Name = "lblPremiumFeaturesSM10"
        Me.lblPremiumFeaturesSM10.Size = New System.Drawing.Size(94, 20)
        Me.lblPremiumFeaturesSM10.TabIndex = 2
        Me.lblPremiumFeaturesSM10.Text = "Auto-Player"
        '
        'lblPremiumFeaturesSM9
        '
        Me.lblPremiumFeaturesSM9.AutoSize = True
        Me.lblPremiumFeaturesSM9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM9.Location = New System.Drawing.Point(52, 85)
        Me.lblPremiumFeaturesSM9.Name = "lblPremiumFeaturesSM9"
        Me.lblPremiumFeaturesSM9.Size = New System.Drawing.Size(141, 20)
        Me.lblPremiumFeaturesSM9.TabIndex = 2
        Me.lblPremiumFeaturesSM9.Text = "Autmatic Updates"
        '
        'btnGetPremiumDM
        '
        Me.btnGetPremiumDM.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGetPremiumDM.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGetPremiumDM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGetPremiumDM.BorderRadius = 0
        Me.btnGetPremiumDM.ButtonText = "Get Premium"
        Me.btnGetPremiumDM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetPremiumDM.DisabledColor = System.Drawing.Color.Gray
        Me.btnGetPremiumDM.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGetPremiumDM.Iconimage = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Best_Seller_32
        Me.btnGetPremiumDM.Iconimage_right = Nothing
        Me.btnGetPremiumDM.Iconimage_right_Selected = Nothing
        Me.btnGetPremiumDM.Iconimage_Selected = Nothing
        Me.btnGetPremiumDM.IconMarginLeft = 0
        Me.btnGetPremiumDM.IconMarginRight = 0
        Me.btnGetPremiumDM.IconRightVisible = True
        Me.btnGetPremiumDM.IconRightZoom = 0R
        Me.btnGetPremiumDM.IconVisible = False
        Me.btnGetPremiumDM.IconZoom = 90.0R
        Me.btnGetPremiumDM.IsTab = False
        Me.btnGetPremiumDM.Location = New System.Drawing.Point(42, 312)
        Me.btnGetPremiumDM.Margin = New System.Windows.Forms.Padding(6)
        Me.btnGetPremiumDM.Name = "btnGetPremiumDM"
        Me.btnGetPremiumDM.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGetPremiumDM.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnGetPremiumDM.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGetPremiumDM.selected = False
        Me.btnGetPremiumDM.Size = New System.Drawing.Size(223, 48)
        Me.btnGetPremiumDM.TabIndex = 1
        Me.btnGetPremiumDM.Text = "Get Premium"
        Me.btnGetPremiumDM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGetPremiumDM.Textcolor = System.Drawing.Color.White
        Me.btnGetPremiumDM.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'picCheckMarkSM11
        '
        Me.picCheckMarkSM11.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM11.Image = CType(resources.GetObject("picCheckMarkSM11.Image"), System.Drawing.Image)
        Me.picCheckMarkSM11.Location = New System.Drawing.Point(22, 276)
        Me.picCheckMarkSM11.Name = "picCheckMarkSM11"
        Me.picCheckMarkSM11.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM11.TabIndex = 1
        Me.picCheckMarkSM11.TabStop = False
        '
        'picCheckMarkSM10
        '
        Me.picCheckMarkSM10.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM10.Image = CType(resources.GetObject("picCheckMarkSM10.Image"), System.Drawing.Image)
        Me.picCheckMarkSM10.Location = New System.Drawing.Point(22, 250)
        Me.picCheckMarkSM10.Name = "picCheckMarkSM10"
        Me.picCheckMarkSM10.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM10.TabIndex = 1
        Me.picCheckMarkSM10.TabStop = False
        '
        'picCheckMarkSM9
        '
        Me.picCheckMarkSM9.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM9.Image = CType(resources.GetObject("picCheckMarkSM9.Image"), System.Drawing.Image)
        Me.picCheckMarkSM9.Location = New System.Drawing.Point(22, 227)
        Me.picCheckMarkSM9.Name = "picCheckMarkSM9"
        Me.picCheckMarkSM9.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM9.TabIndex = 1
        Me.picCheckMarkSM9.TabStop = False
        '
        'picCheckMarkSM8
        '
        Me.picCheckMarkSM8.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM8.Image = CType(resources.GetObject("picCheckMarkSM8.Image"), System.Drawing.Image)
        Me.picCheckMarkSM8.Location = New System.Drawing.Point(22, 201)
        Me.picCheckMarkSM8.Name = "picCheckMarkSM8"
        Me.picCheckMarkSM8.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM8.TabIndex = 1
        Me.picCheckMarkSM8.TabStop = False
        '
        'picCheckMarkSM7
        '
        Me.picCheckMarkSM7.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM7.Image = CType(resources.GetObject("picCheckMarkSM7.Image"), System.Drawing.Image)
        Me.picCheckMarkSM7.Location = New System.Drawing.Point(22, 170)
        Me.picCheckMarkSM7.Name = "picCheckMarkSM7"
        Me.picCheckMarkSM7.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM7.TabIndex = 1
        Me.picCheckMarkSM7.TabStop = False
        '
        'picCheckMarkSM6
        '
        Me.picCheckMarkSM6.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM6.Image = CType(resources.GetObject("picCheckMarkSM6.Image"), System.Drawing.Image)
        Me.picCheckMarkSM6.Location = New System.Drawing.Point(22, 141)
        Me.picCheckMarkSM6.Name = "picCheckMarkSM6"
        Me.picCheckMarkSM6.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM6.TabIndex = 1
        Me.picCheckMarkSM6.TabStop = False
        '
        'picCheckMarkSM5
        '
        Me.picCheckMarkSM5.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM5.Image = CType(resources.GetObject("picCheckMarkSM5.Image"), System.Drawing.Image)
        Me.picCheckMarkSM5.Location = New System.Drawing.Point(22, 111)
        Me.picCheckMarkSM5.Name = "picCheckMarkSM5"
        Me.picCheckMarkSM5.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM5.TabIndex = 1
        Me.picCheckMarkSM5.TabStop = False
        '
        'picCheckMarkSM4
        '
        Me.picCheckMarkSM4.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM4.Image = CType(resources.GetObject("picCheckMarkSM4.Image"), System.Drawing.Image)
        Me.picCheckMarkSM4.Location = New System.Drawing.Point(22, 85)
        Me.picCheckMarkSM4.Name = "picCheckMarkSM4"
        Me.picCheckMarkSM4.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM4.TabIndex = 1
        Me.picCheckMarkSM4.TabStop = False
        '
        'picCheckMarkSM3
        '
        Me.picCheckMarkSM3.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM3.Image = CType(resources.GetObject("picCheckMarkSM3.Image"), System.Drawing.Image)
        Me.picCheckMarkSM3.Location = New System.Drawing.Point(22, 63)
        Me.picCheckMarkSM3.Name = "picCheckMarkSM3"
        Me.picCheckMarkSM3.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM3.TabIndex = 1
        Me.picCheckMarkSM3.TabStop = False
        '
        'picCheckMarkSM2
        '
        Me.picCheckMarkSM2.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM2.Image = CType(resources.GetObject("picCheckMarkSM2.Image"), System.Drawing.Image)
        Me.picCheckMarkSM2.Location = New System.Drawing.Point(20, 37)
        Me.picCheckMarkSM2.Name = "picCheckMarkSM2"
        Me.picCheckMarkSM2.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM2.TabIndex = 1
        Me.picCheckMarkSM2.TabStop = False
        '
        'picCheckMarkSM1
        '
        Me.picCheckMarkSM1.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM1.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Ok_50
        Me.picCheckMarkSM1.Location = New System.Drawing.Point(20, 11)
        Me.picCheckMarkSM1.Name = "picCheckMarkSM1"
        Me.picCheckMarkSM1.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM1.TabIndex = 1
        Me.picCheckMarkSM1.TabStop = False
        '
        'pnlMainMenu
        '
        Me.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.pnlMainMenu.BackgroundImage = CType(resources.GetObject("pnlMainMenu.BackgroundImage"), System.Drawing.Image)
        Me.pnlMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlMainMenu.Controls.Add(Me.lblCopyrightMM)
        Me.pnlMainMenu.Controls.Add(Me.lblMainTitle)
        Me.pnlMainMenu.Controls.Add(Me.pnlAvatarMenu)
        Me.pnlMainMenu.Controls.Add(Me.btnVersionInfosMM)
        Me.pnlMainMenu.Controls.Add(Me.btnGeneralMM)
        Me.pnlMainMenu.Controls.Add(Me.btnOutputMM)
        Me.pnlMainMenu.Controls.Add(Me.btnFileMM)
        Me.pnlMainMenu.Controls.Add(Me.btnAdvancedMM)
        Me.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMainMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.pnlMainMenu.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.pnlMainMenu.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.pnlMainMenu.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.pnlMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainMenu.Name = "pnlMainMenu"
        Me.pnlMainMenu.Quality = 10
        Me.pnlMainMenu.Size = New System.Drawing.Size(226, 441)
        Me.pnlMainMenu.TabIndex = 3
        '
        'lblCopyrightMM
        '
        Me.lblCopyrightMM.AutoSize = True
        Me.lblCopyrightMM.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyrightMM.ForeColor = System.Drawing.Color.White
        Me.lblCopyrightMM.Location = New System.Drawing.Point(13, 412)
        Me.lblCopyrightMM.Name = "lblCopyrightMM"
        Me.lblCopyrightMM.Size = New System.Drawing.Size(185, 16)
        Me.lblCopyrightMM.TabIndex = 0
        Me.lblCopyrightMM.Text = "© MySoft Studio |Franz Nkemaka"
        '
        'lblMainTitle
        '
        Me.lblMainTitle.AutoSize = True
        Me.lblMainTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMainTitle.Font = New System.Drawing.Font("LONE WOLF PERSONAL USE", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitle.ForeColor = System.Drawing.Color.White
        Me.lblMainTitle.Location = New System.Drawing.Point(3, 12)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(221, 12)
        Me.lblMainTitle.TabIndex = 0
        Me.lblMainTitle.Text = "MySoft YouTube Downloader"
        '
        'pnlAvatarMenu
        '
        Me.pnlAvatarMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlAvatarMenu.Controls.Add(Me.lblSettingMM)
        Me.pnlAvatarMenu.Controls.Add(Me.imgAvatarMM)
        Me.pnlAvatarMenu.ForeColor = System.Drawing.Color.White
        Me.pnlAvatarMenu.Location = New System.Drawing.Point(0, 38)
        Me.pnlAvatarMenu.Name = "pnlAvatarMenu"
        Me.pnlAvatarMenu.Size = New System.Drawing.Size(226, 114)
        Me.pnlAvatarMenu.TabIndex = 2
        '
        'lblSettingMM
        '
        Me.lblSettingMM.AutoSize = True
        Me.lblSettingMM.BackColor = System.Drawing.Color.Transparent
        Me.lblSettingMM.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingMM.ForeColor = System.Drawing.Color.White
        Me.lblSettingMM.Location = New System.Drawing.Point(69, 71)
        Me.lblSettingMM.Name = "lblSettingMM"
        Me.lblSettingMM.Size = New System.Drawing.Size(86, 24)
        Me.lblSettingMM.TabIndex = 0
        Me.lblSettingMM.Text = "Settings"
        '
        'imgAvatarMM
        '
        Me.imgAvatarMM.BackColor = System.Drawing.Color.Transparent
        Me.imgAvatarMM.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Administrative_Tools_50
        Me.imgAvatarMM.ImageActive = Nothing
        Me.imgAvatarMM.Location = New System.Drawing.Point(75, 17)
        Me.imgAvatarMM.Name = "imgAvatarMM"
        Me.imgAvatarMM.Size = New System.Drawing.Size(71, 51)
        Me.imgAvatarMM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgAvatarMM.TabIndex = 0
        Me.imgAvatarMM.TabStop = False
        Me.imgAvatarMM.Zoom = 10
        '
        'btnVersionInfosMM
        '
        Me.btnVersionInfosMM.ActiveBorderThickness = 1
        Me.btnVersionInfosMM.ActiveCornerRadius = 20
        Me.btnVersionInfosMM.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnVersionInfosMM.ActiveForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnVersionInfosMM.ActiveLineColor = System.Drawing.Color.Transparent
        Me.btnVersionInfosMM.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnVersionInfosMM.BackgroundImage = CType(resources.GetObject("btnVersionInfosMM.BackgroundImage"), System.Drawing.Image)
        Me.btnVersionInfosMM.ButtonText = "1.0"
        Me.btnVersionInfosMM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVersionInfosMM.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVersionInfosMM.ForeColor = System.Drawing.Color.White
        Me.btnVersionInfosMM.IdleBorderThickness = 1
        Me.btnVersionInfosMM.IdleCornerRadius = 20
        Me.btnVersionInfosMM.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnVersionInfosMM.IdleForecolor = System.Drawing.Color.White
        Me.btnVersionInfosMM.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnVersionInfosMM.Location = New System.Drawing.Point(64, 369)
        Me.btnVersionInfosMM.Margin = New System.Windows.Forms.Padding(5)
        Me.btnVersionInfosMM.Name = "btnVersionInfosMM"
        Me.btnVersionInfosMM.Size = New System.Drawing.Size(91, 35)
        Me.btnVersionInfosMM.TabIndex = 1
        Me.btnVersionInfosMM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGeneralMM
        '
        Me.btnGeneralMM.Activecolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGeneralMM.BackColor = System.Drawing.Color.Transparent
        Me.btnGeneralMM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGeneralMM.BorderRadius = 0
        Me.btnGeneralMM.ButtonText = "General"
        Me.btnGeneralMM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGeneralMM.DisabledColor = System.Drawing.Color.Gray
        Me.btnGeneralMM.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGeneralMM.Iconimage = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Download_641
        Me.btnGeneralMM.Iconimage_right = Nothing
        Me.btnGeneralMM.Iconimage_right_Selected = Nothing
        Me.btnGeneralMM.Iconimage_Selected = Nothing
        Me.btnGeneralMM.IconMarginLeft = 0
        Me.btnGeneralMM.IconMarginRight = 0
        Me.btnGeneralMM.IconRightVisible = True
        Me.btnGeneralMM.IconRightZoom = 0R
        Me.btnGeneralMM.IconVisible = True
        Me.btnGeneralMM.IconZoom = 90.0R
        Me.btnGeneralMM.IsTab = False
        Me.btnGeneralMM.Location = New System.Drawing.Point(0, 152)
        Me.btnGeneralMM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGeneralMM.Name = "btnGeneralMM"
        Me.btnGeneralMM.Normalcolor = System.Drawing.Color.Transparent
        Me.btnGeneralMM.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGeneralMM.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGeneralMM.selected = True
        Me.btnGeneralMM.Size = New System.Drawing.Size(226, 48)
        Me.btnGeneralMM.TabIndex = 0
        Me.btnGeneralMM.Text = "General"
        Me.btnGeneralMM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneralMM.Textcolor = System.Drawing.Color.White
        Me.btnGeneralMM.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnOutputMM
        '
        Me.btnOutputMM.Activecolor = System.Drawing.Color.Transparent
        Me.btnOutputMM.BackColor = System.Drawing.Color.Transparent
        Me.btnOutputMM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOutputMM.BorderRadius = 0
        Me.btnOutputMM.ButtonText = "Output"
        Me.btnOutputMM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOutputMM.DisabledColor = System.Drawing.Color.Gray
        Me.btnOutputMM.Iconcolor = System.Drawing.Color.Transparent
        Me.btnOutputMM.Iconimage = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Export_64
        Me.btnOutputMM.Iconimage_right = Nothing
        Me.btnOutputMM.Iconimage_right_Selected = Nothing
        Me.btnOutputMM.Iconimage_Selected = Nothing
        Me.btnOutputMM.IconMarginLeft = 0
        Me.btnOutputMM.IconMarginRight = 0
        Me.btnOutputMM.IconRightVisible = True
        Me.btnOutputMM.IconRightZoom = 0R
        Me.btnOutputMM.IconVisible = True
        Me.btnOutputMM.IconZoom = 90.0R
        Me.btnOutputMM.IsTab = False
        Me.btnOutputMM.Location = New System.Drawing.Point(0, 262)
        Me.btnOutputMM.Name = "btnOutputMM"
        Me.btnOutputMM.Normalcolor = System.Drawing.Color.Transparent
        Me.btnOutputMM.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnOutputMM.OnHoverTextColor = System.Drawing.Color.White
        Me.btnOutputMM.selected = False
        Me.btnOutputMM.Size = New System.Drawing.Size(226, 48)
        Me.btnOutputMM.TabIndex = 0
        Me.btnOutputMM.Text = "Output"
        Me.btnOutputMM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOutputMM.Textcolor = System.Drawing.Color.White
        Me.btnOutputMM.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnFileMM
        '
        Me.btnFileMM.Activecolor = System.Drawing.Color.Transparent
        Me.btnFileMM.BackColor = System.Drawing.Color.Transparent
        Me.btnFileMM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFileMM.BorderRadius = 0
        Me.btnFileMM.ButtonText = "File"
        Me.btnFileMM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFileMM.DisabledColor = System.Drawing.Color.Gray
        Me.btnFileMM.Iconcolor = System.Drawing.Color.Transparent
        Me.btnFileMM.Iconimage = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_File_64
        Me.btnFileMM.Iconimage_right = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Video_Playlist_64
        Me.btnFileMM.Iconimage_right_Selected = Nothing
        Me.btnFileMM.Iconimage_Selected = Nothing
        Me.btnFileMM.IconMarginLeft = 0
        Me.btnFileMM.IconMarginRight = 0
        Me.btnFileMM.IconRightVisible = True
        Me.btnFileMM.IconRightZoom = 0R
        Me.btnFileMM.IconVisible = True
        Me.btnFileMM.IconZoom = 90.0R
        Me.btnFileMM.IsTab = False
        Me.btnFileMM.Location = New System.Drawing.Point(0, 208)
        Me.btnFileMM.Name = "btnFileMM"
        Me.btnFileMM.Normalcolor = System.Drawing.Color.Transparent
        Me.btnFileMM.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnFileMM.OnHoverTextColor = System.Drawing.Color.White
        Me.btnFileMM.selected = False
        Me.btnFileMM.Size = New System.Drawing.Size(226, 48)
        Me.btnFileMM.TabIndex = 0
        Me.btnFileMM.Text = "File"
        Me.btnFileMM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFileMM.Textcolor = System.Drawing.Color.White
        Me.btnFileMM.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAdvancedMM
        '
        Me.btnAdvancedMM.Activecolor = System.Drawing.Color.Transparent
        Me.btnAdvancedMM.BackColor = System.Drawing.Color.Transparent
        Me.btnAdvancedMM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdvancedMM.BorderRadius = 0
        Me.btnAdvancedMM.ButtonText = "Advanced"
        Me.btnAdvancedMM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdvancedMM.DisabledColor = System.Drawing.Color.Gray
        Me.btnAdvancedMM.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAdvancedMM.Iconimage = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Sorting_Options_64
        Me.btnAdvancedMM.Iconimage_right = Nothing
        Me.btnAdvancedMM.Iconimage_right_Selected = Nothing
        Me.btnAdvancedMM.Iconimage_Selected = Nothing
        Me.btnAdvancedMM.IconMarginLeft = 0
        Me.btnAdvancedMM.IconMarginRight = 0
        Me.btnAdvancedMM.IconRightVisible = True
        Me.btnAdvancedMM.IconRightZoom = 0R
        Me.btnAdvancedMM.IconVisible = True
        Me.btnAdvancedMM.IconZoom = 90.0R
        Me.btnAdvancedMM.IsTab = False
        Me.btnAdvancedMM.Location = New System.Drawing.Point(0, 310)
        Me.btnAdvancedMM.Name = "btnAdvancedMM"
        Me.btnAdvancedMM.Normalcolor = System.Drawing.Color.Transparent
        Me.btnAdvancedMM.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnAdvancedMM.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAdvancedMM.selected = False
        Me.btnAdvancedMM.Size = New System.Drawing.Size(226, 48)
        Me.btnAdvancedMM.TabIndex = 0
        Me.btnAdvancedMM.Text = "Advanced"
        Me.btnAdvancedMM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdvancedMM.Textcolor = System.Drawing.Color.White
        Me.btnAdvancedMM.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(681, 441)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.Controls.Add(Me.pnlMainMenu)
        Me.Controls.Add(Me.pnlDisplayHM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.Text = "Settings - MySoft YouTube Downloader"
        Me.pnlTopMenu.ResumeLayout(False)
        CType(Me.btnCloseTM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDisplayHM.ResumeLayout(False)
        Me.grpPremiumHM.ResumeLayout(False)
        Me.grpPremiumHM.PerformLayout()
        CType(Me.picCheckMarkSM11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMainMenu.ResumeLayout(False)
        Me.pnlMainMenu.PerformLayout()
        Me.pnlAvatarMenu.ResumeLayout(False)
        Me.pnlAvatarMenu.PerformLayout()
        CType(Me.imgAvatarMM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlTopMenu As Panel
    Friend WithEvents btnCloseTM As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnlMainMenu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lblCopyrightMM As Label
    Friend WithEvents btnVersionInfosMM As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblMainTitle As Label
    Friend WithEvents pnlAvatarMenu As Panel
    Friend WithEvents imgAvatarMM As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnGeneralMM As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnOutputMM As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnFileMM As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAdvancedMM As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblSettingMM As Label
    Friend WithEvents pnlDisplayHM As Panel
    Friend WithEvents grpPremiumHM As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblPremiumFeaturesSM12 As Label
    Friend WithEvents lblPremiumFeaturesSM6 As Label
    Friend WithEvents lblPremiumFeaturesSM5 As Label
    Friend WithEvents lblPremiumFeaturesSM3 As Label
    Friend WithEvents lblPremiumFeaturesSM2 As Label
    Friend WithEvents lblPremiumFeaturesSM1 As Label
    Friend WithEvents lblPremiumFeaturesSM7 As Label
    Friend WithEvents lblPremiumFeaturesSM8 As Label
    Friend WithEvents lblPremiumFeaturesSM11 As Label
    Friend WithEvents lblPremiumFeaturesSM10 As Label
    Friend WithEvents lblPremiumFeaturesSM9 As Label
    Friend WithEvents btnGetPremiumDM As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents picCheckMarkSM11 As PictureBox
    Friend WithEvents picCheckMarkSM10 As PictureBox
    Friend WithEvents picCheckMarkSM9 As PictureBox
    Friend WithEvents picCheckMarkSM8 As PictureBox
    Friend WithEvents picCheckMarkSM7 As PictureBox
    Friend WithEvents picCheckMarkSM6 As PictureBox
    Friend WithEvents picCheckMarkSM5 As PictureBox
    Friend WithEvents picCheckMarkSM4 As PictureBox
    Friend WithEvents picCheckMarkSM3 As PictureBox
    Friend WithEvents picCheckMarkSM2 As PictureBox
    Friend WithEvents picCheckMarkSM1 As PictureBox
End Class
