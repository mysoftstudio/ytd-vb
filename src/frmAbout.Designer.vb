<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlHomeFA = New System.Windows.Forms.Panel()
        Me.btnCloseF = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblCopyrightFA = New System.Windows.Forms.Label()
        Me.lblMySoftStudio_linkFA = New System.Windows.Forms.Label()
        Me.btnMoreInfosFA = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHomeFA.SuspendLayout()
        CType(Me.btnCloseF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMoreInfosFA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'pnlHomeFA
        '
        Me.pnlHomeFA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.pnlHomeFA.BackgroundImage = Global.MySoft_YouTube_Downloader.My.Resources.Resources.MYD_Normal
        Me.pnlHomeFA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlHomeFA.Controls.Add(Me.btnCloseF)
        Me.pnlHomeFA.Controls.Add(Me.Label1)
        Me.pnlHomeFA.Location = New System.Drawing.Point(-5, -2)
        Me.pnlHomeFA.Name = "pnlHomeFA"
        Me.pnlHomeFA.Size = New System.Drawing.Size(424, 305)
        Me.pnlHomeFA.TabIndex = 0
        '
        'btnCloseF
        '
        Me.btnCloseF.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseF.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_Close_Window_641
        Me.btnCloseF.ImageActive = Nothing
        Me.btnCloseF.Location = New System.Drawing.Point(381, 10)
        Me.btnCloseF.Name = "btnCloseF"
        Me.btnCloseF.Size = New System.Drawing.Size(27, 27)
        Me.btnCloseF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCloseF.TabIndex = 11
        Me.btnCloseF.TabStop = False
        Me.btnCloseF.Zoom = 10
        '
        'lblCopyrightFA
        '
        Me.lblCopyrightFA.AutoSize = True
        Me.lblCopyrightFA.Font = New System.Drawing.Font("Century Gothic", 8.75!)
        Me.lblCopyrightFA.ForeColor = System.Drawing.Color.Black
        Me.lblCopyrightFA.Location = New System.Drawing.Point(54, 368)
        Me.lblCopyrightFA.Name = "lblCopyrightFA"
        Me.lblCopyrightFA.Size = New System.Drawing.Size(297, 17)
        Me.lblCopyrightFA.TabIndex = 9
        Me.lblCopyrightFA.Text = "Copyright : ©2017 MySoft Studio |Franz Nkemaka"
        '
        'lblMySoftStudio_linkFA
        '
        Me.lblMySoftStudio_linkFA.AutoSize = True
        Me.lblMySoftStudio_linkFA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMySoftStudio_linkFA.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblMySoftStudio_linkFA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblMySoftStudio_linkFA.Location = New System.Drawing.Point(107, 338)
        Me.lblMySoftStudio_linkFA.Name = "lblMySoftStudio_linkFA"
        Me.lblMySoftStudio_linkFA.Size = New System.Drawing.Size(192, 17)
        Me.lblMySoftStudio_linkFA.TabIndex = 9
        Me.lblMySoftStudio_linkFA.Text = "http://www.mysoftstudio.ml"
        '
        'btnMoreInfosFA
        '
        Me.btnMoreInfosFA.BackColor = System.Drawing.Color.Transparent
        Me.btnMoreInfosFA.Image = Global.MySoft_YouTube_Downloader.My.Resources.Resources.icons8_More_Info_48
        Me.btnMoreInfosFA.ImageActive = Nothing
        Me.btnMoreInfosFA.Location = New System.Drawing.Point(367, 359)
        Me.btnMoreInfosFA.Name = "btnMoreInfosFA"
        Me.btnMoreInfosFA.Size = New System.Drawing.Size(36, 32)
        Me.btnMoreInfosFA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMoreInfosFA.TabIndex = 10
        Me.btnMoreInfosFA.TabStop = False
        Me.btnMoreInfosFA.Zoom = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("LONE WOLF PERSONAL USE", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "MySoft YouTube Downloader"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(415, 403)
        Me.Controls.Add(Me.btnMoreInfosFA)
        Me.Controls.Add(Me.lblMySoftStudio_linkFA)
        Me.Controls.Add(Me.lblCopyrightFA)
        Me.Controls.Add(Me.pnlHomeFA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About - MySoft YouTube Downloader"
        Me.pnlHomeFA.ResumeLayout(False)
        Me.pnlHomeFA.PerformLayout()
        CType(Me.btnCloseF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMoreInfosFA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlHomeFA As Panel
    Friend WithEvents lblMySoftStudio_linkFA As Label
    Friend WithEvents lblCopyrightFA As Label
    Friend WithEvents btnMoreInfosFA As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCloseF As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As Label
End Class
