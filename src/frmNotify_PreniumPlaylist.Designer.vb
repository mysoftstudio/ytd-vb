<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotify_PreniumPlaylist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotify_PreniumPlaylist))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lbltextMain = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnMoreInfos = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMainInfoNPL = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnOkNPL = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblMainTitleNPL = New System.Windows.Forms.Label()
        Me.btnGetPremiumNPL = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblPremiumFeaturesSM12 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM6 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM5 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM3 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM2 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM1 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM7 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM8 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM10 = New System.Windows.Forms.Label()
        Me.lblPremiumFeaturesSM9 = New System.Windows.Forms.Label()
        Me.picCheckMarkSM11 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM10 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM9 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM8 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM7 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM6 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM5 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM4 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM3 = New System.Windows.Forms.PictureBox()
        Me.picCheckMarkSM1 = New System.Windows.Forms.PictureBox()
        Me.BunifuDragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.lblDontShow = New System.Windows.Forms.Label()
        CType(Me.btnMoreInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMainInfoNPL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckMarkSM1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'lbltextMain
        '
        Me.lbltextMain.AutoSize = True
        Me.lbltextMain.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltextMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltextMain.Location = New System.Drawing.Point(54, 55)
        Me.lbltextMain.Name = "lbltextMain"
        Me.lbltextMain.Size = New System.Drawing.Size(458, 57)
        Me.lbltextMain.TabIndex = 41
        Me.lbltextMain.Text = "In this Section you could simply have more feeatures if you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You are downloading " &
    "a playlist, it's a Premium feature. Get" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Prenium to download playlists and more!" &
    ""
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'btnMoreInfos
        '
        Me.btnMoreInfos.BackColor = System.Drawing.Color.Transparent
        Me.btnMoreInfos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoreInfos.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_More_Info_48
        Me.btnMoreInfos.ImageActive = Nothing
        Me.btnMoreInfos.Location = New System.Drawing.Point(518, 291)
        Me.btnMoreInfos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMoreInfos.Name = "btnMoreInfos"
        Me.btnMoreInfos.Size = New System.Drawing.Size(23, 23)
        Me.btnMoreInfos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMoreInfos.TabIndex = 43
        Me.btnMoreInfos.TabStop = False
        Me.btnMoreInfos.Zoom = 10
        '
        'btnMainInfoNPL
        '
        Me.btnMainInfoNPL.BackColor = System.Drawing.Color.Transparent
        Me.btnMainInfoNPL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainInfoNPL.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.btnMainInfoNPL.ImageActive = Nothing
        Me.btnMainInfoNPL.Location = New System.Drawing.Point(547, 291)
        Me.btnMainInfoNPL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMainInfoNPL.Name = "btnMainInfoNPL"
        Me.btnMainInfoNPL.Size = New System.Drawing.Size(23, 23)
        Me.btnMainInfoNPL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMainInfoNPL.TabIndex = 44
        Me.btnMainInfoNPL.TabStop = False
        Me.btnMainInfoNPL.Zoom = 10
        '
        'btnOkNPL
        '
        Me.btnOkNPL.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnOkNPL.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnOkNPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOkNPL.BorderRadius = 0
        Me.btnOkNPL.ButtonText = "Continue"
        Me.btnOkNPL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOkNPL.DisabledColor = System.Drawing.Color.Gray
        Me.btnOkNPL.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnOkNPL.Iconcolor = System.Drawing.Color.Transparent
        Me.btnOkNPL.Iconimage = CType(resources.GetObject("btnOkNPL.Iconimage"), System.Drawing.Image)
        Me.btnOkNPL.Iconimage_right = Nothing
        Me.btnOkNPL.Iconimage_right_Selected = Nothing
        Me.btnOkNPL.Iconimage_Selected = Nothing
        Me.btnOkNPL.IconMarginLeft = 0
        Me.btnOkNPL.IconMarginRight = 0
        Me.btnOkNPL.IconRightVisible = True
        Me.btnOkNPL.IconRightZoom = 0R
        Me.btnOkNPL.IconVisible = False
        Me.btnOkNPL.IconZoom = 90.0R
        Me.btnOkNPL.IsTab = False
        Me.btnOkNPL.Location = New System.Drawing.Point(338, 257)
        Me.btnOkNPL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOkNPL.Name = "btnOkNPL"
        Me.btnOkNPL.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnOkNPL.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnOkNPL.OnHoverTextColor = System.Drawing.Color.White
        Me.btnOkNPL.selected = False
        Me.btnOkNPL.Size = New System.Drawing.Size(120, 43)
        Me.btnOkNPL.TabIndex = 42
        Me.btnOkNPL.Text = "Continue"
        Me.btnOkNPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnOkNPL.Textcolor = System.Drawing.Color.White
        Me.btnOkNPL.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblMainTitleNPL
        '
        Me.lblMainTitleNPL.AutoSize = True
        Me.lblMainTitleNPL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitleNPL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblMainTitleNPL.Location = New System.Drawing.Point(124, 17)
        Me.lblMainTitleNPL.Name = "lblMainTitleNPL"
        Me.lblMainTitleNPL.Size = New System.Drawing.Size(293, 21)
        Me.lblMainTitleNPL.TabIndex = 40
        Me.lblMainTitleNPL.Text = "Welcome, Please Read the Following"
        '
        'btnGetPremiumNPL
        '
        Me.btnGetPremiumNPL.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGetPremiumNPL.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGetPremiumNPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGetPremiumNPL.BorderRadius = 0
        Me.btnGetPremiumNPL.ButtonText = "Get Premium"
        Me.btnGetPremiumNPL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetPremiumNPL.DisabledColor = System.Drawing.Color.Gray
        Me.btnGetPremiumNPL.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnGetPremiumNPL.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGetPremiumNPL.Iconimage = CType(resources.GetObject("btnGetPremiumNPL.Iconimage"), System.Drawing.Image)
        Me.btnGetPremiumNPL.Iconimage_right = Nothing
        Me.btnGetPremiumNPL.Iconimage_right_Selected = Nothing
        Me.btnGetPremiumNPL.Iconimage_Selected = Nothing
        Me.btnGetPremiumNPL.IconMarginLeft = 0
        Me.btnGetPremiumNPL.IconMarginRight = 0
        Me.btnGetPremiumNPL.IconRightVisible = True
        Me.btnGetPremiumNPL.IconRightZoom = 0R
        Me.btnGetPremiumNPL.IconVisible = False
        Me.btnGetPremiumNPL.IconZoom = 90.0R
        Me.btnGetPremiumNPL.IsTab = False
        Me.btnGetPremiumNPL.Location = New System.Drawing.Point(128, 257)
        Me.btnGetPremiumNPL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGetPremiumNPL.Name = "btnGetPremiumNPL"
        Me.btnGetPremiumNPL.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGetPremiumNPL.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnGetPremiumNPL.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGetPremiumNPL.selected = False
        Me.btnGetPremiumNPL.Size = New System.Drawing.Size(120, 43)
        Me.btnGetPremiumNPL.TabIndex = 42
        Me.btnGetPremiumNPL.Text = "Get Premium"
        Me.btnGetPremiumNPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGetPremiumNPL.Textcolor = System.Drawing.Color.White
        Me.btnGetPremiumNPL.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblPremiumFeaturesSM12
        '
        Me.lblPremiumFeaturesSM12.AutoSize = True
        Me.lblPremiumFeaturesSM12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM12.Location = New System.Drawing.Point(334, 129)
        Me.lblPremiumFeaturesSM12.Name = "lblPremiumFeaturesSM12"
        Me.lblPremiumFeaturesSM12.Size = New System.Drawing.Size(153, 20)
        Me.lblPremiumFeaturesSM12.TabIndex = 66
        Me.lblPremiumFeaturesSM12.Text = "Auto-History Mailing"
        '
        'lblPremiumFeaturesSM6
        '
        Me.lblPremiumFeaturesSM6.AutoSize = True
        Me.lblPremiumFeaturesSM6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM6.Location = New System.Drawing.Point(70, 129)
        Me.lblPremiumFeaturesSM6.Name = "lblPremiumFeaturesSM6"
        Me.lblPremiumFeaturesSM6.Size = New System.Drawing.Size(212, 20)
        Me.lblPremiumFeaturesSM6.TabIndex = 64
        Me.lblPremiumFeaturesSM6.Text = "Video Likes and Information"
        '
        'lblPremiumFeaturesSM5
        '
        Me.lblPremiumFeaturesSM5.AutoSize = True
        Me.lblPremiumFeaturesSM5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM5.Location = New System.Drawing.Point(70, 208)
        Me.lblPremiumFeaturesSM5.Name = "lblPremiumFeaturesSM5"
        Me.lblPremiumFeaturesSM5.Size = New System.Drawing.Size(155, 20)
        Me.lblPremiumFeaturesSM5.TabIndex = 63
        Me.lblPremiumFeaturesSM5.Text = "Live Video Counter "
        '
        'lblPremiumFeaturesSM3
        '
        Me.lblPremiumFeaturesSM3.AutoSize = True
        Me.lblPremiumFeaturesSM3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM3.Location = New System.Drawing.Point(70, 185)
        Me.lblPremiumFeaturesSM3.Name = "lblPremiumFeaturesSM3"
        Me.lblPremiumFeaturesSM3.Size = New System.Drawing.Size(106, 20)
        Me.lblPremiumFeaturesSM3.TabIndex = 62
        Me.lblPremiumFeaturesSM3.Text = " Video Player"
        '
        'lblPremiumFeaturesSM2
        '
        Me.lblPremiumFeaturesSM2.AutoSize = True
        Me.lblPremiumFeaturesSM2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM2.Location = New System.Drawing.Point(70, 159)
        Me.lblPremiumFeaturesSM2.Name = "lblPremiumFeaturesSM2"
        Me.lblPremiumFeaturesSM2.Size = New System.Drawing.Size(159, 20)
        Me.lblPremiumFeaturesSM2.TabIndex = 61
        Me.lblPremiumFeaturesSM2.Text = "QR CODE Link sharer"
        '
        'lblPremiumFeaturesSM1
        '
        Me.lblPremiumFeaturesSM1.AutoSize = True
        Me.lblPremiumFeaturesSM1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM1.Location = New System.Drawing.Point(334, 229)
        Me.lblPremiumFeaturesSM1.Name = "lblPremiumFeaturesSM1"
        Me.lblPremiumFeaturesSM1.Size = New System.Drawing.Size(243, 20)
        Me.lblPremiumFeaturesSM1.TabIndex = 60
        Me.lblPremiumFeaturesSM1.Text = "Thumbnails and GIF Auto Maker "
        '
        'lblPremiumFeaturesSM7
        '
        Me.lblPremiumFeaturesSM7.AutoSize = True
        Me.lblPremiumFeaturesSM7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM7.Location = New System.Drawing.Point(70, 229)
        Me.lblPremiumFeaturesSM7.Name = "lblPremiumFeaturesSM7"
        Me.lblPremiumFeaturesSM7.Size = New System.Drawing.Size(226, 20)
        Me.lblPremiumFeaturesSM7.TabIndex = 59
        Me.lblPremiumFeaturesSM7.Text = "Faster Speed And Best Quality"
        '
        'lblPremiumFeaturesSM8
        '
        Me.lblPremiumFeaturesSM8.AutoSize = True
        Me.lblPremiumFeaturesSM8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM8.Location = New System.Drawing.Point(334, 203)
        Me.lblPremiumFeaturesSM8.Name = "lblPremiumFeaturesSM8"
        Me.lblPremiumFeaturesSM8.Size = New System.Drawing.Size(129, 20)
        Me.lblPremiumFeaturesSM8.TabIndex = 58
        Me.lblPremiumFeaturesSM8.Text = "Commercial Use"
        '
        'lblPremiumFeaturesSM10
        '
        Me.lblPremiumFeaturesSM10.AutoSize = True
        Me.lblPremiumFeaturesSM10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM10.Location = New System.Drawing.Point(334, 158)
        Me.lblPremiumFeaturesSM10.Name = "lblPremiumFeaturesSM10"
        Me.lblPremiumFeaturesSM10.Size = New System.Drawing.Size(94, 20)
        Me.lblPremiumFeaturesSM10.TabIndex = 65
        Me.lblPremiumFeaturesSM10.Text = "Auto-Player"
        '
        'lblPremiumFeaturesSM9
        '
        Me.lblPremiumFeaturesSM9.AutoSize = True
        Me.lblPremiumFeaturesSM9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumFeaturesSM9.Location = New System.Drawing.Point(334, 181)
        Me.lblPremiumFeaturesSM9.Name = "lblPremiumFeaturesSM9"
        Me.lblPremiumFeaturesSM9.Size = New System.Drawing.Size(141, 20)
        Me.lblPremiumFeaturesSM9.TabIndex = 56
        Me.lblPremiumFeaturesSM9.Text = "Autmatic Updates"
        '
        'picCheckMarkSM11
        '
        Me.picCheckMarkSM11.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM11.Image = CType(resources.GetObject("picCheckMarkSM11.Image"), System.Drawing.Image)
        Me.picCheckMarkSM11.Location = New System.Drawing.Point(40, 127)
        Me.picCheckMarkSM11.Name = "picCheckMarkSM11"
        Me.picCheckMarkSM11.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM11.TabIndex = 54
        Me.picCheckMarkSM11.TabStop = False
        '
        'picCheckMarkSM10
        '
        Me.picCheckMarkSM10.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM10.Image = CType(resources.GetObject("picCheckMarkSM10.Image"), System.Drawing.Image)
        Me.picCheckMarkSM10.Location = New System.Drawing.Point(40, 208)
        Me.picCheckMarkSM10.Name = "picCheckMarkSM10"
        Me.picCheckMarkSM10.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM10.TabIndex = 53
        Me.picCheckMarkSM10.TabStop = False
        '
        'picCheckMarkSM9
        '
        Me.picCheckMarkSM9.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM9.Image = CType(resources.GetObject("picCheckMarkSM9.Image"), System.Drawing.Image)
        Me.picCheckMarkSM9.Location = New System.Drawing.Point(40, 185)
        Me.picCheckMarkSM9.Name = "picCheckMarkSM9"
        Me.picCheckMarkSM9.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM9.TabIndex = 52
        Me.picCheckMarkSM9.TabStop = False
        '
        'picCheckMarkSM8
        '
        Me.picCheckMarkSM8.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM8.Image = CType(resources.GetObject("picCheckMarkSM8.Image"), System.Drawing.Image)
        Me.picCheckMarkSM8.Location = New System.Drawing.Point(40, 159)
        Me.picCheckMarkSM8.Name = "picCheckMarkSM8"
        Me.picCheckMarkSM8.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM8.TabIndex = 51
        Me.picCheckMarkSM8.TabStop = False
        '
        'picCheckMarkSM7
        '
        Me.picCheckMarkSM7.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM7.Image = CType(resources.GetObject("picCheckMarkSM7.Image"), System.Drawing.Image)
        Me.picCheckMarkSM7.Location = New System.Drawing.Point(304, 229)
        Me.picCheckMarkSM7.Name = "picCheckMarkSM7"
        Me.picCheckMarkSM7.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM7.TabIndex = 50
        Me.picCheckMarkSM7.TabStop = False
        '
        'picCheckMarkSM6
        '
        Me.picCheckMarkSM6.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM6.Image = CType(resources.GetObject("picCheckMarkSM6.Image"), System.Drawing.Image)
        Me.picCheckMarkSM6.Location = New System.Drawing.Point(40, 225)
        Me.picCheckMarkSM6.Name = "picCheckMarkSM6"
        Me.picCheckMarkSM6.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM6.TabIndex = 49
        Me.picCheckMarkSM6.TabStop = False
        '
        'picCheckMarkSM5
        '
        Me.picCheckMarkSM5.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM5.Image = CType(resources.GetObject("picCheckMarkSM5.Image"), System.Drawing.Image)
        Me.picCheckMarkSM5.Location = New System.Drawing.Point(304, 203)
        Me.picCheckMarkSM5.Name = "picCheckMarkSM5"
        Me.picCheckMarkSM5.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM5.TabIndex = 48
        Me.picCheckMarkSM5.TabStop = False
        '
        'picCheckMarkSM4
        '
        Me.picCheckMarkSM4.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM4.Image = CType(resources.GetObject("picCheckMarkSM4.Image"), System.Drawing.Image)
        Me.picCheckMarkSM4.Location = New System.Drawing.Point(304, 181)
        Me.picCheckMarkSM4.Name = "picCheckMarkSM4"
        Me.picCheckMarkSM4.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM4.TabIndex = 47
        Me.picCheckMarkSM4.TabStop = False
        '
        'picCheckMarkSM3
        '
        Me.picCheckMarkSM3.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM3.Image = CType(resources.GetObject("picCheckMarkSM3.Image"), System.Drawing.Image)
        Me.picCheckMarkSM3.Location = New System.Drawing.Point(304, 159)
        Me.picCheckMarkSM3.Name = "picCheckMarkSM3"
        Me.picCheckMarkSM3.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM3.TabIndex = 46
        Me.picCheckMarkSM3.TabStop = False
        '
        'picCheckMarkSM1
        '
        Me.picCheckMarkSM1.BackColor = System.Drawing.Color.Transparent
        Me.picCheckMarkSM1.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Ok_50
        Me.picCheckMarkSM1.Location = New System.Drawing.Point(304, 129)
        Me.picCheckMarkSM1.Name = "picCheckMarkSM1"
        Me.picCheckMarkSM1.Size = New System.Drawing.Size(24, 20)
        Me.picCheckMarkSM1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckMarkSM1.TabIndex = 45
        Me.picCheckMarkSM1.TabStop = False
        '
        'BunifuDragControl
        '
        Me.BunifuDragControl.Fixed = True
        Me.BunifuDragControl.Horizontal = True
        Me.BunifuDragControl.TargetControl = Me
        Me.BunifuDragControl.Vertical = True
        '
        'lblDontShow
        '
        Me.lblDontShow.AutoSize = True
        Me.lblDontShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDontShow.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDontShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDontShow.Location = New System.Drawing.Point(12, 305)
        Me.lblDontShow.Name = "lblDontShow"
        Me.lblDontShow.Size = New System.Drawing.Size(143, 17)
        Me.lblDontShow.TabIndex = 67
        Me.lblDontShow.Text = "Don't Show anymore"
        '
        'frmNotify_PreniumPlaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(589, 331)
        Me.Controls.Add(Me.lblDontShow)
        Me.Controls.Add(Me.lblPremiumFeaturesSM12)
        Me.Controls.Add(Me.lblPremiumFeaturesSM6)
        Me.Controls.Add(Me.lblPremiumFeaturesSM5)
        Me.Controls.Add(Me.lblPremiumFeaturesSM3)
        Me.Controls.Add(Me.lblPremiumFeaturesSM2)
        Me.Controls.Add(Me.lblPremiumFeaturesSM1)
        Me.Controls.Add(Me.lblPremiumFeaturesSM7)
        Me.Controls.Add(Me.lblPremiumFeaturesSM8)
        Me.Controls.Add(Me.lblPremiumFeaturesSM10)
        Me.Controls.Add(Me.lblPremiumFeaturesSM9)
        Me.Controls.Add(Me.picCheckMarkSM11)
        Me.Controls.Add(Me.picCheckMarkSM10)
        Me.Controls.Add(Me.picCheckMarkSM9)
        Me.Controls.Add(Me.picCheckMarkSM8)
        Me.Controls.Add(Me.picCheckMarkSM7)
        Me.Controls.Add(Me.picCheckMarkSM6)
        Me.Controls.Add(Me.picCheckMarkSM5)
        Me.Controls.Add(Me.picCheckMarkSM4)
        Me.Controls.Add(Me.picCheckMarkSM3)
        Me.Controls.Add(Me.picCheckMarkSM1)
        Me.Controls.Add(Me.lbltextMain)
        Me.Controls.Add(Me.btnMoreInfos)
        Me.Controls.Add(Me.btnMainInfoNPL)
        Me.Controls.Add(Me.btnGetPremiumNPL)
        Me.Controls.Add(Me.btnOkNPL)
        Me.Controls.Add(Me.lblMainTitleNPL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNotify_PreniumPlaylist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Premium - MySoft YouTube Downloader"
        CType(Me.btnMoreInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMainInfoNPL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckMarkSM1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lbltextMain As Label
    Friend WithEvents btnMoreInfos As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMainInfoNPL As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnOkNPL As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblMainTitleNPL As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnGetPremiumNPL As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblPremiumFeaturesSM12 As Label
    Friend WithEvents lblPremiumFeaturesSM6 As Label
    Friend WithEvents lblPremiumFeaturesSM5 As Label
    Friend WithEvents lblPremiumFeaturesSM3 As Label
    Friend WithEvents lblPremiumFeaturesSM2 As Label
    Friend WithEvents lblPremiumFeaturesSM1 As Label
    Friend WithEvents lblPremiumFeaturesSM7 As Label
    Friend WithEvents lblPremiumFeaturesSM8 As Label
    Friend WithEvents lblPremiumFeaturesSM10 As Label
    Friend WithEvents lblPremiumFeaturesSM9 As Label
    Friend WithEvents picCheckMarkSM11 As PictureBox
    Friend WithEvents picCheckMarkSM10 As PictureBox
    Friend WithEvents picCheckMarkSM9 As PictureBox
    Friend WithEvents picCheckMarkSM8 As PictureBox
    Friend WithEvents picCheckMarkSM7 As PictureBox
    Friend WithEvents picCheckMarkSM6 As PictureBox
    Friend WithEvents picCheckMarkSM5 As PictureBox
    Friend WithEvents picCheckMarkSM4 As PictureBox
    Friend WithEvents picCheckMarkSM3 As PictureBox
    Friend WithEvents picCheckMarkSM1 As PictureBox
    Friend WithEvents BunifuDragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents lblDontShow As Label
End Class
