<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTopMenu_Preview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTopMenu_Preview))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblText1 = New System.Windows.Forms.Label()
        Me.lblText2 = New System.Windows.Forms.Label()
        Me.lblVidName_varFTMP = New System.Windows.Forms.Label()
        Me.lblText4 = New System.Windows.Forms.Label()
        Me.pgbAnimateFTMP = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.lblText3 = New System.Windows.Forms.Label()
        Me.lblVidSize_varFTMP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'lblText1
        '
        Me.lblText1.AutoSize = True
        Me.lblText1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText1.Location = New System.Drawing.Point(56, 70)
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Size = New System.Drawing.Size(502, 18)
        Me.lblText1.TabIndex = 0
        Me.lblText1.Text = "Here You Could have a preview of Your Video before downloading"
        '
        'lblText2
        '
        Me.lblText2.AutoSize = True
        Me.lblText2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText2.Location = New System.Drawing.Point(126, 88)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(359, 18)
        Me.lblText2.TabIndex = 0
        Me.lblText2.Text = "Check Your Setting, for more information here : "
        '
        'lblVidName_varFTMP
        '
        Me.lblVidName_varFTMP.AutoSize = True
        Me.lblVidName_varFTMP.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidName_varFTMP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblVidName_varFTMP.Location = New System.Drawing.Point(170, 9)
        Me.lblVidName_varFTMP.Name = "lblVidName_varFTMP"
        Me.lblVidName_varFTMP.Size = New System.Drawing.Size(240, 20)
        Me.lblVidName_varFTMP.TabIndex = 10
        Me.lblVidName_varFTMP.Text = "Lensko - Let's Go! [NCS Release]"
        '
        'lblText4
        '
        Me.lblText4.AutoSize = True
        Me.lblText4.Location = New System.Drawing.Point(12, 9)
        Me.lblText4.Name = "lblText4"
        Me.lblText4.Size = New System.Drawing.Size(159, 20)
        Me.lblText4.TabIndex = 9
        Me.lblText4.Text = "Current Video Ttitle : "
        '
        'pgbAnimateFTMP
        '
        Me.pgbAnimateFTMP.animated = True
        Me.pgbAnimateFTMP.animationIterval = 5
        Me.pgbAnimateFTMP.animationSpeed = 1
        Me.pgbAnimateFTMP.BackColor = System.Drawing.Color.Transparent
        Me.pgbAnimateFTMP.BackgroundImage = CType(resources.GetObject("pgbAnimateFTMP.BackgroundImage"), System.Drawing.Image)
        Me.pgbAnimateFTMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.pgbAnimateFTMP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.pgbAnimateFTMP.LabelVisible = False
        Me.pgbAnimateFTMP.LineProgressThickness = 4
        Me.pgbAnimateFTMP.LineThickness = 5
        Me.pgbAnimateFTMP.Location = New System.Drawing.Point(592, 26)
        Me.pgbAnimateFTMP.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.pgbAnimateFTMP.MaxValue = 100
        Me.pgbAnimateFTMP.Name = "pgbAnimateFTMP"
        Me.pgbAnimateFTMP.ProgressBackColor = System.Drawing.Color.Transparent
        Me.pgbAnimateFTMP.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.pgbAnimateFTMP.Size = New System.Drawing.Size(70, 70)
        Me.pgbAnimateFTMP.TabIndex = 12
        Me.pgbAnimateFTMP.Value = 50
        '
        'lblText3
        '
        Me.lblText3.AutoSize = True
        Me.lblText3.Location = New System.Drawing.Point(17, 40)
        Me.lblText3.Name = "lblText3"
        Me.lblText3.Size = New System.Drawing.Size(154, 20)
        Me.lblText3.TabIndex = 8
        Me.lblText3.Text = "Current Video Size : "
        '
        'lblVidSize_varFTMP
        '
        Me.lblVidSize_varFTMP.AutoSize = True
        Me.lblVidSize_varFTMP.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidSize_varFTMP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblVidSize_varFTMP.Location = New System.Drawing.Point(170, 40)
        Me.lblVidSize_varFTMP.Name = "lblVidSize_varFTMP"
        Me.lblVidSize_varFTMP.Size = New System.Drawing.Size(63, 20)
        Me.lblVidSize_varFTMP.TabIndex = 11
        Me.lblVidSize_varFTMP.Text = "1.25 GB"
        '
        'frmTopMenu_Preview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(681, 114)
        Me.Controls.Add(Me.pgbAnimateFTMP)
        Me.Controls.Add(Me.lblVidSize_varFTMP)
        Me.Controls.Add(Me.lblVidName_varFTMP)
        Me.Controls.Add(Me.lblText3)
        Me.Controls.Add(Me.lblText4)
        Me.Controls.Add(Me.lblText2)
        Me.Controls.Add(Me.lblText1)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmTopMenu_Preview"
        Me.Text = "frmTopMenu_Preview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblText2 As Label
    Friend WithEvents lblText1 As Label
    Friend WithEvents lblVidName_varFTMP As Label
    Friend WithEvents lblText4 As Label
    Friend WithEvents pgbAnimateFTMP As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents lblVidSize_varFTMP As Label
    Friend WithEvents lblText3 As Label
End Class
