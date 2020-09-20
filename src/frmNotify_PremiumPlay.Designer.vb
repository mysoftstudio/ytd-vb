<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotify_PremiumPlay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotify_PremiumPlay))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnOkNPP = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lbltextMain = New System.Windows.Forms.Label()
        Me.lblMainTitleNPP = New System.Windows.Forms.Label()
        Me.btnMoreInfos = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMainInfoNPP = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.lblDontShow = New System.Windows.Forms.Label()
        CType(Me.btnMoreInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMainInfoNPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'btnOkNPP
        '
        Me.btnOkNPP.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnOkNPP.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnOkNPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOkNPP.BorderRadius = 0
        Me.btnOkNPP.ButtonText = "OK"
        Me.btnOkNPP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOkNPP.DisabledColor = System.Drawing.Color.Gray
        Me.btnOkNPP.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnOkNPP.Iconcolor = System.Drawing.Color.Transparent
        Me.btnOkNPP.Iconimage = CType(resources.GetObject("btnOkNPP.Iconimage"), System.Drawing.Image)
        Me.btnOkNPP.Iconimage_right = Nothing
        Me.btnOkNPP.Iconimage_right_Selected = Nothing
        Me.btnOkNPP.Iconimage_Selected = Nothing
        Me.btnOkNPP.IconMarginLeft = 0
        Me.btnOkNPP.IconMarginRight = 0
        Me.btnOkNPP.IconRightVisible = True
        Me.btnOkNPP.IconRightZoom = 0R
        Me.btnOkNPP.IconVisible = False
        Me.btnOkNPP.IconZoom = 90.0R
        Me.btnOkNPP.IsTab = False
        Me.btnOkNPP.Location = New System.Drawing.Point(217, 271)
        Me.btnOkNPP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOkNPP.Name = "btnOkNPP"
        Me.btnOkNPP.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnOkNPP.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnOkNPP.OnHoverTextColor = System.Drawing.Color.White
        Me.btnOkNPP.selected = False
        Me.btnOkNPP.Size = New System.Drawing.Size(136, 46)
        Me.btnOkNPP.TabIndex = 5
        Me.btnOkNPP.Text = "OK"
        Me.btnOkNPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnOkNPP.Textcolor = System.Drawing.Color.White
        Me.btnOkNPP.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lbltextMain
        '
        Me.lbltextMain.AutoSize = True
        Me.lbltextMain.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltextMain.ForeColor = System.Drawing.Color.Black
        Me.lbltextMain.Location = New System.Drawing.Point(21, 50)
        Me.lbltextMain.Name = "lbltextMain"
        Me.lbltextMain.Size = New System.Drawing.Size(551, 189)
        Me.lbltextMain.TabIndex = 3
        Me.lbltextMain.Text = resources.GetString("lbltextMain.Text")
        '
        'lblMainTitleNPP
        '
        Me.lblMainTitleNPP.AutoSize = True
        Me.lblMainTitleNPP.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitleNPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblMainTitleNPP.Location = New System.Drawing.Point(140, 9)
        Me.lblMainTitleNPP.Name = "lblMainTitleNPP"
        Me.lblMainTitleNPP.Size = New System.Drawing.Size(293, 21)
        Me.lblMainTitleNPP.TabIndex = 3
        Me.lblMainTitleNPP.Text = "Welcome, Please Read the Following"
        '
        'btnMoreInfos
        '
        Me.btnMoreInfos.BackColor = System.Drawing.Color.Transparent
        Me.btnMoreInfos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoreInfos.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_More_Info_48
        Me.btnMoreInfos.ImageActive = Nothing
        Me.btnMoreInfos.Location = New System.Drawing.Point(525, 295)
        Me.btnMoreInfos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMoreInfos.Name = "btnMoreInfos"
        Me.btnMoreInfos.Size = New System.Drawing.Size(23, 23)
        Me.btnMoreInfos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMoreInfos.TabIndex = 40
        Me.btnMoreInfos.TabStop = False
        Me.btnMoreInfos.Zoom = 10
        '
        'btnMainInfoNPP
        '
        Me.btnMainInfoNPP.BackColor = System.Drawing.Color.Transparent
        Me.btnMainInfoNPP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainInfoNPP.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.btnMainInfoNPP.ImageActive = Nothing
        Me.btnMainInfoNPP.Location = New System.Drawing.Point(554, 295)
        Me.btnMainInfoNPP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMainInfoNPP.Name = "btnMainInfoNPP"
        Me.btnMainInfoNPP.Size = New System.Drawing.Size(23, 23)
        Me.btnMainInfoNPP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMainInfoNPP.TabIndex = 41
        Me.btnMainInfoNPP.TabStop = False
        Me.btnMainInfoNPP.Zoom = 10
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
        Me.lblDontShow.Location = New System.Drawing.Point(22, 295)
        Me.lblDontShow.Name = "lblDontShow"
        Me.lblDontShow.Size = New System.Drawing.Size(143, 17)
        Me.lblDontShow.TabIndex = 42
        Me.lblDontShow.Text = "Don't Show anymore"
        '
        'frmNotify_PremiumPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(589, 331)
        Me.Controls.Add(Me.lblDontShow)
        Me.Controls.Add(Me.btnMoreInfos)
        Me.Controls.Add(Me.btnMainInfoNPP)
        Me.Controls.Add(Me.btnOkNPP)
        Me.Controls.Add(Me.lblMainTitleNPP)
        Me.Controls.Add(Me.lbltextMain)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmNotify_PremiumPlay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notice - MySoft YouTube Downloader"
        CType(Me.btnMoreInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMainInfoNPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnOkNPP As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblMainTitleNPP As Label
    Friend WithEvents lbltextMain As Label
    Friend WithEvents btnMoreInfos As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMainInfoNPP As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents lblDontShow As Label
End Class
