<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnGetPremiumDM = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblDontShow = New System.Windows.Forms.Label()
        Me.DragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Close_Window_64
        Me.PictureBox1.Location = New System.Drawing.Point(367, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(11, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Do you enjoy MySoft YouTube Downloader?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(355, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Participate in a quick survey, and share  your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                          impress" &
    "ions"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.MYD_Normal
        Me.PictureBox2.Location = New System.Drawing.Point(147, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(141, 103)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'btnGetPremiumDM
        '
        Me.btnGetPremiumDM.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGetPremiumDM.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGetPremiumDM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGetPremiumDM.BorderRadius = 7
        Me.btnGetPremiumDM.ButtonText = "Send Your Feedbacks"
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
        Me.btnGetPremiumDM.Location = New System.Drawing.Point(94, 188)
        Me.btnGetPremiumDM.Margin = New System.Windows.Forms.Padding(6)
        Me.btnGetPremiumDM.Name = "btnGetPremiumDM"
        Me.btnGetPremiumDM.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGetPremiumDM.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnGetPremiumDM.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGetPremiumDM.selected = False
        Me.btnGetPremiumDM.Size = New System.Drawing.Size(217, 39)
        Me.btnGetPremiumDM.TabIndex = 3
        Me.btnGetPremiumDM.Text = "Send Your Feedbacks"
        Me.btnGetPremiumDM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGetPremiumDM.Textcolor = System.Drawing.Color.White
        Me.btnGetPremiumDM.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "Not Now"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Best_Seller_32
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = False
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(105, 239)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(164, 32)
        Me.BunifuFlatButton1.TabIndex = 3
        Me.BunifuFlatButton1.Text = "Not Now"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblDontShow
        '
        Me.lblDontShow.AutoSize = True
        Me.lblDontShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDontShow.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDontShow.Location = New System.Drawing.Point(115, 305)
        Me.lblDontShow.Name = "lblDontShow"
        Me.lblDontShow.Size = New System.Drawing.Size(143, 17)
        Me.lblDontShow.TabIndex = 1
        Me.lblDontShow.Text = "Don't Show anymore"
        '
        'DragControl
        '
        Me.DragControl.Fixed = True
        Me.DragControl.Horizontal = True
        Me.DragControl.TargetControl = Me
        Me.DragControl.Vertical = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(418, 331)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.btnGetPremiumDM)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblDontShow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome To MySoft YouTube Downloader"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnGetPremiumDM As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblDontShow As Label
    Friend WithEvents DragControl As Bunifu.Framework.UI.BunifuDragControl
End Class
