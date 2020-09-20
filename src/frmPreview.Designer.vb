<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreview))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.webbNavigateURL = New System.Windows.Forms.WebBrowser()
        Me.lblTextFP2 = New System.Windows.Forms.Label()
        Me.btnStopFP = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblVidName_varFP = New System.Windows.Forms.Label()
        Me.lblTextFP1 = New System.Windows.Forms.Label()
        Me.txt_UrlChange = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'webbNavigateURL
        '
        Me.webbNavigateURL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.webbNavigateURL.Location = New System.Drawing.Point(0, 106)
        Me.webbNavigateURL.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webbNavigateURL.Name = "webbNavigateURL"
        Me.webbNavigateURL.Size = New System.Drawing.Size(675, 330)
        Me.webbNavigateURL.TabIndex = 0
        '
        'lblTextFP2
        '
        Me.lblTextFP2.AutoSize = True
        Me.lblTextFP2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblTextFP2.Location = New System.Drawing.Point(12, 26)
        Me.lblTextFP2.Name = "lblTextFP2"
        Me.lblTextFP2.Size = New System.Drawing.Size(310, 20)
        Me.lblTextFP2.TabIndex = 1
        Me.lblTextFP2.Text = "Preview your Video Before Downloading"
        '
        'btnStopFP
        '
        Me.btnStopFP.ActiveBorderThickness = 1
        Me.btnStopFP.ActiveCornerRadius = 1
        Me.btnStopFP.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnStopFP.ActiveForecolor = System.Drawing.Color.White
        Me.btnStopFP.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnStopFP.BackColor = System.Drawing.Color.White
        Me.btnStopFP.BackgroundImage = CType(resources.GetObject("btnStopFP.BackgroundImage"), System.Drawing.Image)
        Me.btnStopFP.ButtonText = "Stop"
        Me.btnStopFP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStopFP.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopFP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnStopFP.IdleBorderThickness = 1
        Me.btnStopFP.IdleCornerRadius = 1
        Me.btnStopFP.IdleFillColor = System.Drawing.Color.White
        Me.btnStopFP.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnStopFP.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnStopFP.Location = New System.Drawing.Point(563, 26)
        Me.btnStopFP.Margin = New System.Windows.Forms.Padding(5)
        Me.btnStopFP.Name = "btnStopFP"
        Me.btnStopFP.Size = New System.Drawing.Size(98, 36)
        Me.btnStopFP.TabIndex = 2
        Me.btnStopFP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVidName_varFP
        '
        Me.lblVidName_varFP.AutoSize = True
        Me.lblVidName_varFP.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblVidName_varFP.Location = New System.Drawing.Point(113, 75)
        Me.lblVidName_varFP.Name = "lblVidName_varFP"
        Me.lblVidName_varFP.Size = New System.Drawing.Size(240, 20)
        Me.lblVidName_varFP.TabIndex = 1
        Me.lblVidName_varFP.Text = "Lensko - Let's Go! [NCS Release]"
        '
        'lblTextFP1
        '
        Me.lblTextFP1.AutoSize = True
        Me.lblTextFP1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblTextFP1.Location = New System.Drawing.Point(12, 75)
        Me.lblTextFP1.Name = "lblTextFP1"
        Me.lblTextFP1.Size = New System.Drawing.Size(95, 20)
        Me.lblTextFP1.TabIndex = 1
        Me.lblTextFP1.Text = "Video Title : "
        '
        'txt_UrlChange
        '
        Me.txt_UrlChange.Location = New System.Drawing.Point(72, 52)
        Me.txt_UrlChange.Name = "txt_UrlChange"
        Me.txt_UrlChange.Size = New System.Drawing.Size(404, 20)
        Me.txt_UrlChange.TabIndex = 3
        Me.txt_UrlChange.Visible = False
        '
        'frmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(675, 436)
        Me.Controls.Add(Me.txt_UrlChange)
        Me.Controls.Add(Me.btnStopFP)
        Me.Controls.Add(Me.lblVidName_varFP)
        Me.Controls.Add(Me.lblTextFP1)
        Me.Controls.Add(Me.lblTextFP2)
        Me.Controls.Add(Me.webbNavigateURL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPreview"
        Me.Text = "frmPreview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents webbNavigateURL As WebBrowser
    Friend WithEvents lblTextFP2 As Label
    Friend WithEvents btnStopFP As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblVidName_varFP As Label
    Friend WithEvents lblTextFP1 As Label
    Friend WithEvents txt_UrlChange As TextBox
End Class
