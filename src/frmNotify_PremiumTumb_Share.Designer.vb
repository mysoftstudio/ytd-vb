<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotify_PremiumTumb_Share
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotify_PremiumTumb_Share))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnMoreInfos = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMainInfoNPS = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnOkNPS = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblMainTitleNPS = New System.Windows.Forms.Label()
        Me.lbltextMain = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.lblDontShow = New System.Windows.Forms.Label()
        CType(Me.btnMoreInfos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMainInfoNPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
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
        Me.btnMoreInfos.TabIndex = 37
        Me.btnMoreInfos.TabStop = False
        Me.btnMoreInfos.Zoom = 10
        '
        'btnMainInfoNPS
        '
        Me.btnMainInfoNPS.BackColor = System.Drawing.Color.Transparent
        Me.btnMainInfoNPS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainInfoNPS.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Info_48
        Me.btnMainInfoNPS.ImageActive = Nothing
        Me.btnMainInfoNPS.Location = New System.Drawing.Point(554, 295)
        Me.btnMainInfoNPS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMainInfoNPS.Name = "btnMainInfoNPS"
        Me.btnMainInfoNPS.Size = New System.Drawing.Size(23, 23)
        Me.btnMainInfoNPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMainInfoNPS.TabIndex = 39
        Me.btnMainInfoNPS.TabStop = False
        Me.btnMainInfoNPS.Zoom = 10
        '
        'btnOkNPS
        '
        Me.btnOkNPS.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnOkNPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnOkNPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOkNPS.BorderRadius = 0
        Me.btnOkNPS.ButtonText = "OK"
        Me.btnOkNPS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOkNPS.DisabledColor = System.Drawing.Color.Gray
        Me.btnOkNPS.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnOkNPS.Iconcolor = System.Drawing.Color.Transparent
        Me.btnOkNPS.Iconimage = CType(resources.GetObject("btnOkNPS.Iconimage"), System.Drawing.Image)
        Me.btnOkNPS.Iconimage_right = Nothing
        Me.btnOkNPS.Iconimage_right_Selected = Nothing
        Me.btnOkNPS.Iconimage_Selected = Nothing
        Me.btnOkNPS.IconMarginLeft = 0
        Me.btnOkNPS.IconMarginRight = 0
        Me.btnOkNPS.IconRightVisible = True
        Me.btnOkNPS.IconRightZoom = 0R
        Me.btnOkNPS.IconVisible = False
        Me.btnOkNPS.IconZoom = 90.0R
        Me.btnOkNPS.IsTab = False
        Me.btnOkNPS.Location = New System.Drawing.Point(220, 258)
        Me.btnOkNPS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOkNPS.Name = "btnOkNPS"
        Me.btnOkNPS.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnOkNPS.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnOkNPS.OnHoverTextColor = System.Drawing.Color.White
        Me.btnOkNPS.selected = False
        Me.btnOkNPS.Size = New System.Drawing.Size(136, 46)
        Me.btnOkNPS.TabIndex = 36
        Me.btnOkNPS.Text = "OK"
        Me.btnOkNPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnOkNPS.Textcolor = System.Drawing.Color.White
        Me.btnOkNPS.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblMainTitleNPS
        '
        Me.lblMainTitleNPS.AutoSize = True
        Me.lblMainTitleNPS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitleNPS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblMainTitleNPS.Location = New System.Drawing.Point(131, 21)
        Me.lblMainTitleNPS.Name = "lblMainTitleNPS"
        Me.lblMainTitleNPS.Size = New System.Drawing.Size(293, 21)
        Me.lblMainTitleNPS.TabIndex = 34
        Me.lblMainTitleNPS.Text = "Welcome, Please Read the Following"
        '
        'lbltextMain
        '
        Me.lbltextMain.AutoSize = True
        Me.lbltextMain.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltextMain.ForeColor = System.Drawing.Color.Black
        Me.lbltextMain.Location = New System.Drawing.Point(26, 65)
        Me.lbltextMain.Name = "lbltextMain"
        Me.lbltextMain.Size = New System.Drawing.Size(551, 168)
        Me.lbltextMain.TabIndex = 35
        Me.lbltextMain.Text = resources.GetString("lbltextMain.Text")
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
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
        Me.lblDontShow.TabIndex = 43
        Me.lblDontShow.Text = "Don't Show anymore"
        '
        'frmNotify_PremiumTumb_Share
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(589, 331)
        Me.Controls.Add(Me.lblDontShow)
        Me.Controls.Add(Me.btnMoreInfos)
        Me.Controls.Add(Me.btnMainInfoNPS)
        Me.Controls.Add(Me.btnOkNPS)
        Me.Controls.Add(Me.lblMainTitleNPS)
        Me.Controls.Add(Me.lbltextMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNotify_PremiumTumb_Share"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Premium - MySoft YouTube Downloader"
        CType(Me.btnMoreInfos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMainInfoNPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnMoreInfos As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMainInfoNPS As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnOkNPS As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblMainTitleNPS As Label
    Friend WithEvents lbltextMain As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents lblDontShow As Label
End Class
