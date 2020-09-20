<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShare
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShare))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.picAndroidPreview_varFS = New System.Windows.Forms.PictureBox()
        Me.picDirectDownLink_varFS = New System.Windows.Forms.PictureBox()
        Me.btnSaveDDL_FS = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSaveAP_FS = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtDirectDownLink_varFS = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblTextFS1 = New System.Windows.Forms.Label()
        Me.lblTextFS2 = New System.Windows.Forms.Label()
        Me.lblTextFS3 = New System.Windows.Forms.Label()
        Me.lblVidName_varFS = New System.Windows.Forms.Label()
        Me.btnSettingFS = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMainInfoFS = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblTextFS4 = New System.Windows.Forms.Label()
        Me.imgbtnSaveFS = New Bunifu.Framework.UI.BunifuImageButton()
        Me.SaveFileDialogQR_Code_AP = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialogQR_Code_DDL = New System.Windows.Forms.SaveFileDialog()
        CType(Me.picAndroidPreview_varFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDirectDownLink_varFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettingFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMainInfoFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbtnSaveFS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'picAndroidPreview_varFS
        '
        Me.picAndroidPreview_varFS.BackColor = System.Drawing.Color.White
        Me.picAndroidPreview_varFS.Location = New System.Drawing.Point(429, 134)
        Me.picAndroidPreview_varFS.Name = "picAndroidPreview_varFS"
        Me.picAndroidPreview_varFS.Size = New System.Drawing.Size(213, 183)
        Me.picAndroidPreview_varFS.TabIndex = 0
        Me.picAndroidPreview_varFS.TabStop = False
        '
        'picDirectDownLink_varFS
        '
        Me.picDirectDownLink_varFS.BackColor = System.Drawing.Color.White
        Me.picDirectDownLink_varFS.Location = New System.Drawing.Point(38, 134)
        Me.picDirectDownLink_varFS.Name = "picDirectDownLink_varFS"
        Me.picDirectDownLink_varFS.Size = New System.Drawing.Size(232, 183)
        Me.picDirectDownLink_varFS.TabIndex = 0
        Me.picDirectDownLink_varFS.TabStop = False
        '
        'btnSaveDDL_FS
        '
        Me.btnSaveDDL_FS.ActiveBorderThickness = 1
        Me.btnSaveDDL_FS.ActiveCornerRadius = 1
        Me.btnSaveDDL_FS.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveDDL_FS.ActiveForecolor = System.Drawing.Color.White
        Me.btnSaveDDL_FS.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveDDL_FS.BackColor = System.Drawing.Color.White
        Me.btnSaveDDL_FS.BackgroundImage = CType(resources.GetObject("btnSaveDDL_FS.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveDDL_FS.ButtonText = "Save"
        Me.btnSaveDDL_FS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveDDL_FS.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btnSaveDDL_FS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveDDL_FS.IdleBorderThickness = 1
        Me.btnSaveDDL_FS.IdleCornerRadius = 1
        Me.btnSaveDDL_FS.IdleFillColor = System.Drawing.Color.White
        Me.btnSaveDDL_FS.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveDDL_FS.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveDDL_FS.Location = New System.Drawing.Point(115, 325)
        Me.btnSaveDDL_FS.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSaveDDL_FS.Name = "btnSaveDDL_FS"
        Me.btnSaveDDL_FS.Size = New System.Drawing.Size(79, 36)
        Me.btnSaveDDL_FS.TabIndex = 16
        Me.btnSaveDDL_FS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSaveAP_FS
        '
        Me.btnSaveAP_FS.ActiveBorderThickness = 1
        Me.btnSaveAP_FS.ActiveCornerRadius = 1
        Me.btnSaveAP_FS.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveAP_FS.ActiveForecolor = System.Drawing.Color.White
        Me.btnSaveAP_FS.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveAP_FS.BackColor = System.Drawing.Color.White
        Me.btnSaveAP_FS.BackgroundImage = CType(resources.GetObject("btnSaveAP_FS.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveAP_FS.ButtonText = "Save"
        Me.btnSaveAP_FS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveAP_FS.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btnSaveAP_FS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveAP_FS.IdleBorderThickness = 1
        Me.btnSaveAP_FS.IdleCornerRadius = 1
        Me.btnSaveAP_FS.IdleFillColor = System.Drawing.Color.White
        Me.btnSaveAP_FS.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveAP_FS.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSaveAP_FS.Location = New System.Drawing.Point(511, 325)
        Me.btnSaveAP_FS.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSaveAP_FS.Name = "btnSaveAP_FS"
        Me.btnSaveAP_FS.Size = New System.Drawing.Size(79, 36)
        Me.btnSaveAP_FS.TabIndex = 16
        Me.btnSaveAP_FS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDirectDownLink_varFS
        '
        Me.txtDirectDownLink_varFS.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtDirectDownLink_varFS.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDirectDownLink_varFS.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtDirectDownLink_varFS.BorderThickness = 3
        Me.txtDirectDownLink_varFS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDirectDownLink_varFS.Enabled = False
        Me.txtDirectDownLink_varFS.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDirectDownLink_varFS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDirectDownLink_varFS.isPassword = False
        Me.txtDirectDownLink_varFS.Location = New System.Drawing.Point(26, 59)
        Me.txtDirectDownLink_varFS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDirectDownLink_varFS.Name = "txtDirectDownLink_varFS"
        Me.txtDirectDownLink_varFS.Size = New System.Drawing.Size(626, 44)
        Me.txtDirectDownLink_varFS.TabIndex = 18
        Me.txtDirectDownLink_varFS.Text = "Link Comes Here"
        Me.txtDirectDownLink_varFS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblTextFS1
        '
        Me.lblTextFS1.AutoSize = True
        Me.lblTextFS1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblTextFS1.Location = New System.Drawing.Point(34, 35)
        Me.lblTextFS1.Name = "lblTextFS1"
        Me.lblTextFS1.Size = New System.Drawing.Size(225, 20)
        Me.lblTextFS1.TabIndex = 19
        Me.lblTextFS1.Text = "Direct Video Download Link : "
        '
        'lblTextFS2
        '
        Me.lblTextFS2.AutoSize = True
        Me.lblTextFS2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblTextFS2.Location = New System.Drawing.Point(68, 111)
        Me.lblTextFS2.Name = "lblTextFS2"
        Me.lblTextFS2.Size = New System.Drawing.Size(173, 20)
        Me.lblTextFS2.TabIndex = 19
        Me.lblTextFS2.Text = "Direct Download Link: "
        '
        'lblTextFS3
        '
        Me.lblTextFS3.AutoSize = True
        Me.lblTextFS3.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblTextFS3.Location = New System.Drawing.Point(463, 111)
        Me.lblTextFS3.Name = "lblTextFS3"
        Me.lblTextFS3.Size = New System.Drawing.Size(140, 20)
        Me.lblTextFS3.TabIndex = 19
        Me.lblTextFS3.Text = "Android Preview :"
        '
        'lblVidName_varFS
        '
        Me.lblVidName_varFS.AutoSize = True
        Me.lblVidName_varFS.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblVidName_varFS.Location = New System.Drawing.Point(265, 35)
        Me.lblVidName_varFS.Name = "lblVidName_varFS"
        Me.lblVidName_varFS.Size = New System.Drawing.Size(240, 20)
        Me.lblVidName_varFS.TabIndex = 20
        Me.lblVidName_varFS.Text = "Lensko - Let's Go! [NCS Release]"
        '
        'btnSettingFS
        '
        Me.btnSettingFS.BackColor = System.Drawing.Color.White
        Me.btnSettingFS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettingFS.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Settings_64
        Me.btnSettingFS.ImageActive = Nothing
        Me.btnSettingFS.Location = New System.Drawing.Point(338, 228)
        Me.btnSettingFS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSettingFS.Name = "btnSettingFS"
        Me.btnSettingFS.Size = New System.Drawing.Size(23, 23)
        Me.btnSettingFS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSettingFS.TabIndex = 21
        Me.btnSettingFS.TabStop = False
        Me.btnSettingFS.Zoom = 10
        '
        'btnMainInfoFS
        '
        Me.btnMainInfoFS.BackColor = System.Drawing.Color.White
        Me.btnMainInfoFS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainInfoFS.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.btnMainInfoFS.ImageActive = Nothing
        Me.btnMainInfoFS.Location = New System.Drawing.Point(309, 228)
        Me.btnMainInfoFS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMainInfoFS.Name = "btnMainInfoFS"
        Me.btnMainInfoFS.Size = New System.Drawing.Size(23, 23)
        Me.btnMainInfoFS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMainInfoFS.TabIndex = 22
        Me.btnMainInfoFS.TabStop = False
        Me.btnMainInfoFS.Zoom = 10
        '
        'lblTextFS4
        '
        Me.lblTextFS4.AutoSize = True
        Me.lblTextFS4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.lblTextFS4.Location = New System.Drawing.Point(276, 205)
        Me.lblTextFS4.Name = "lblTextFS4"
        Me.lblTextFS4.Size = New System.Drawing.Size(147, 19)
        Me.lblTextFS4.TabIndex = 19
        Me.lblTextFS4.Text = "Do You Need Help ?"
        '
        'imgbtnSaveFS
        '
        Me.imgbtnSaveFS.BackColor = System.Drawing.Color.White
        Me.imgbtnSaveFS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgbtnSaveFS.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Save_64
        Me.imgbtnSaveFS.ImageActive = Nothing
        Me.imgbtnSaveFS.Location = New System.Drawing.Point(364, 228)
        Me.imgbtnSaveFS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgbtnSaveFS.Name = "imgbtnSaveFS"
        Me.imgbtnSaveFS.Size = New System.Drawing.Size(23, 23)
        Me.imgbtnSaveFS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgbtnSaveFS.TabIndex = 25
        Me.imgbtnSaveFS.TabStop = False
        Me.imgbtnSaveFS.Zoom = 10
        '
        'SaveFileDialogQR_Code_AP
        '
        Me.SaveFileDialogQR_Code_AP.Filter = "PNG Image|*.png"
        '
        'SaveFileDialogQR_Code_DDL
        '
        Me.SaveFileDialogQR_Code_DDL.Filter = "PNG Image|*.png"
        '
        'frmShare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(675, 436)
        Me.Controls.Add(Me.imgbtnSaveFS)
        Me.Controls.Add(Me.btnSettingFS)
        Me.Controls.Add(Me.btnMainInfoFS)
        Me.Controls.Add(Me.lblVidName_varFS)
        Me.Controls.Add(Me.lblTextFS3)
        Me.Controls.Add(Me.lblTextFS4)
        Me.Controls.Add(Me.lblTextFS2)
        Me.Controls.Add(Me.lblTextFS1)
        Me.Controls.Add(Me.txtDirectDownLink_varFS)
        Me.Controls.Add(Me.btnSaveAP_FS)
        Me.Controls.Add(Me.btnSaveDDL_FS)
        Me.Controls.Add(Me.picDirectDownLink_varFS)
        Me.Controls.Add(Me.picAndroidPreview_varFS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmShare"
        Me.Text = "frmShare"
        CType(Me.picAndroidPreview_varFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDirectDownLink_varFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettingFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMainInfoFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbtnSaveFS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents picDirectDownLink_varFS As PictureBox
    Friend WithEvents picAndroidPreview_varFS As PictureBox
    Friend WithEvents txtDirectDownLink_varFS As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnSaveAP_FS As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSaveDDL_FS As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblTextFS3 As Label
    Friend WithEvents lblTextFS2 As Label
    Friend WithEvents lblTextFS1 As Label
    Friend WithEvents lblVidName_varFS As Label
    Friend WithEvents btnSettingFS As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMainInfoFS As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblTextFS4 As Label
    Friend WithEvents imgbtnSaveFS As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents SaveFileDialogQR_Code_AP As SaveFileDialog
    Friend WithEvents SaveFileDialogQR_Code_DDL As SaveFileDialog
End Class
