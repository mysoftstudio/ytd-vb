<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStats_DownloadStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStats_DownloadStats))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.grpVidInfosFSDS = New System.Windows.Forms.GroupBox()
        Me.lblDownSize_varFSDS = New System.Windows.Forms.Label()
        Me.lblTextFSDS4 = New System.Windows.Forms.Label()
        Me.lblNothingFSDS2 = New System.Windows.Forms.Label()
        Me.lblVidElapsedTime_varFSDS = New System.Windows.Forms.Label()
        Me.lblVidTotalSize_varFSDS = New System.Windows.Forms.Label()
        Me.lblSavingPath_varFSDS = New System.Windows.Forms.Label()
        Me.lblVidTitle_varFSDS = New System.Windows.Forms.Label()
        Me.lblVidTitleTextFSDS = New System.Windows.Forms.Label()
        Me.lblTextFSDS3 = New System.Windows.Forms.Label()
        Me.lblNothing_FSDS = New System.Windows.Forms.Label()
        Me.lblTextFSDS1 = New System.Windows.Forms.Label()
        Me.lblTextFSDS2 = New System.Windows.Forms.Label()
        Me.grpProgressFSDS = New System.Windows.Forms.GroupBox()
        Me.gpgbDownStatus_varFSDS = New Bunifu.Framework.UI.BunifuGauge()
        Me.lblStatus_varFSDS = New System.Windows.Forms.Label()
        Me.pgbUI_Ac = New System.Windows.Forms.ProgressBar()
        Me.TimerUI = New System.Windows.Forms.Timer(Me.components)
        Me.grpVidInfosFSDS.SuspendLayout()
        Me.grpProgressFSDS.SuspendLayout()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'grpVidInfosFSDS
        '
        Me.grpVidInfosFSDS.Controls.Add(Me.lblDownSize_varFSDS)
        Me.grpVidInfosFSDS.Controls.Add(Me.lblTextFSDS4)
        Me.grpVidInfosFSDS.Controls.Add(Me.lblNothingFSDS2)
        Me.grpVidInfosFSDS.Controls.Add(Me.lblVidElapsedTime_varFSDS)
        Me.grpVidInfosFSDS.Controls.Add(Me.lblVidTotalSize_varFSDS)
        Me.grpVidInfosFSDS.Controls.Add(Me.lblSavingPath_varFSDS)
        Me.grpVidInfosFSDS.Controls.Add(Me.lblVidTitle_varFSDS)
        Me.grpVidInfosFSDS.Controls.Add(Me.lblVidTitleTextFSDS)
        Me.grpVidInfosFSDS.Controls.Add(Me.lblTextFSDS3)
        Me.grpVidInfosFSDS.Controls.Add(Me.lblNothing_FSDS)
        Me.grpVidInfosFSDS.Controls.Add(Me.lblTextFSDS1)
        Me.grpVidInfosFSDS.Controls.Add(Me.lblTextFSDS2)
        Me.grpVidInfosFSDS.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.grpVidInfosFSDS.Location = New System.Drawing.Point(12, 5)
        Me.grpVidInfosFSDS.Name = "grpVidInfosFSDS"
        Me.grpVidInfosFSDS.Size = New System.Drawing.Size(362, 221)
        Me.grpVidInfosFSDS.TabIndex = 3
        Me.grpVidInfosFSDS.TabStop = False
        Me.grpVidInfosFSDS.Text = "Video Informations"
        '
        'lblDownSize_varFSDS
        '
        Me.lblDownSize_varFSDS.AutoSize = True
        Me.lblDownSize_varFSDS.Location = New System.Drawing.Point(169, 92)
        Me.lblDownSize_varFSDS.Name = "lblDownSize_varFSDS"
        Me.lblDownSize_varFSDS.Size = New System.Drawing.Size(45, 20)
        Me.lblDownSize_varFSDS.TabIndex = 0
        Me.lblDownSize_varFSDS.Text = "0 MB"
        '
        'lblTextFSDS4
        '
        Me.lblTextFSDS4.AutoSize = True
        Me.lblTextFSDS4.Location = New System.Drawing.Point(74, 62)
        Me.lblTextFSDS4.Name = "lblTextFSDS4"
        Me.lblTextFSDS4.Size = New System.Drawing.Size(89, 20)
        Me.lblTextFSDS4.TabIndex = 0
        Me.lblTextFSDS4.Text = "Saving To : "
        '
        'lblNothingFSDS2
        '
        Me.lblNothingFSDS2.AutoSize = True
        Me.lblNothingFSDS2.ForeColor = System.Drawing.Color.Tomato
        Me.lblNothingFSDS2.Location = New System.Drawing.Point(169, 190)
        Me.lblNothingFSDS2.Name = "lblNothingFSDS2"
        Me.lblNothingFSDS2.Size = New System.Drawing.Size(109, 20)
        Me.lblNothingFSDS2.TabIndex = 0
        Me.lblNothingFSDS2.Text = "Not Available"
        '
        'lblVidElapsedTime_varFSDS
        '
        Me.lblVidElapsedTime_varFSDS.AutoSize = True
        Me.lblVidElapsedTime_varFSDS.ForeColor = System.Drawing.Color.Tomato
        Me.lblVidElapsedTime_varFSDS.Location = New System.Drawing.Point(171, 157)
        Me.lblVidElapsedTime_varFSDS.Name = "lblVidElapsedTime_varFSDS"
        Me.lblVidElapsedTime_varFSDS.Size = New System.Drawing.Size(109, 20)
        Me.lblVidElapsedTime_varFSDS.TabIndex = 0
        Me.lblVidElapsedTime_varFSDS.Text = "Not Available"
        '
        'lblVidTotalSize_varFSDS
        '
        Me.lblVidTotalSize_varFSDS.AutoSize = True
        Me.lblVidTotalSize_varFSDS.Location = New System.Drawing.Point(169, 125)
        Me.lblVidTotalSize_varFSDS.Name = "lblVidTotalSize_varFSDS"
        Me.lblVidTotalSize_varFSDS.Size = New System.Drawing.Size(45, 20)
        Me.lblVidTotalSize_varFSDS.TabIndex = 0
        Me.lblVidTotalSize_varFSDS.Text = "0 MB"
        '
        'lblSavingPath_varFSDS
        '
        Me.lblSavingPath_varFSDS.AutoSize = True
        Me.lblSavingPath_varFSDS.Location = New System.Drawing.Point(169, 62)
        Me.lblSavingPath_varFSDS.Name = "lblSavingPath_varFSDS"
        Me.lblSavingPath_varFSDS.Size = New System.Drawing.Size(136, 20)
        Me.lblSavingPath_varFSDS.TabIndex = 0
        Me.lblSavingPath_varFSDS.Text = "Path Comes Here"
        '
        'lblVidTitle_varFSDS
        '
        Me.lblVidTitle_varFSDS.AutoSize = True
        Me.lblVidTitle_varFSDS.Location = New System.Drawing.Point(169, 33)
        Me.lblVidTitle_varFSDS.Name = "lblVidTitle_varFSDS"
        Me.lblVidTitle_varFSDS.Size = New System.Drawing.Size(117, 20)
        Me.lblVidTitle_varFSDS.TabIndex = 0
        Me.lblVidTitle_varFSDS.Text = "Title Goes Here"
        '
        'lblVidTitleTextFSDS
        '
        Me.lblVidTitleTextFSDS.AutoSize = True
        Me.lblVidTitleTextFSDS.Location = New System.Drawing.Point(68, 33)
        Me.lblVidTitleTextFSDS.Name = "lblVidTitleTextFSDS"
        Me.lblVidTitleTextFSDS.Size = New System.Drawing.Size(95, 20)
        Me.lblVidTitleTextFSDS.TabIndex = 0
        Me.lblVidTitleTextFSDS.Text = "Video Title : "
        '
        'lblTextFSDS3
        '
        Me.lblTextFSDS3.AutoSize = True
        Me.lblTextFSDS3.Location = New System.Drawing.Point(8, 92)
        Me.lblTextFSDS3.Name = "lblTextFSDS3"
        Me.lblTextFSDS3.Size = New System.Drawing.Size(155, 20)
        Me.lblTextFSDS3.TabIndex = 0
        Me.lblTextFSDS3.Text = "File Download Size : "
        '
        'lblNothing_FSDS
        '
        Me.lblNothing_FSDS.AutoSize = True
        Me.lblNothing_FSDS.ForeColor = System.Drawing.Color.Tomato
        Me.lblNothing_FSDS.Location = New System.Drawing.Point(47, 190)
        Me.lblNothing_FSDS.Name = "lblNothing_FSDS"
        Me.lblNothing_FSDS.Size = New System.Drawing.Size(116, 20)
        Me.lblNothing_FSDS.TabIndex = 0
        Me.lblNothing_FSDS.Text = "Time Remaing :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTextFSDS1
        '
        Me.lblTextFSDS1.AutoSize = True
        Me.lblTextFSDS1.Location = New System.Drawing.Point(52, 157)
        Me.lblTextFSDS1.Name = "lblTextFSDS1"
        Me.lblTextFSDS1.Size = New System.Drawing.Size(113, 20)
        Me.lblTextFSDS1.TabIndex = 0
        Me.lblTextFSDS1.Text = "Time Elapsed : "
        '
        'lblTextFSDS2
        '
        Me.lblTextFSDS2.AutoSize = True
        Me.lblTextFSDS2.Location = New System.Drawing.Point(52, 125)
        Me.lblTextFSDS2.Name = "lblTextFSDS2"
        Me.lblTextFSDS2.Size = New System.Drawing.Size(111, 20)
        Me.lblTextFSDS2.TabIndex = 0
        Me.lblTextFSDS2.Text = "File Total Size : "
        '
        'grpProgressFSDS
        '
        Me.grpProgressFSDS.Controls.Add(Me.gpgbDownStatus_varFSDS)
        Me.grpProgressFSDS.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProgressFSDS.Location = New System.Drawing.Point(380, 5)
        Me.grpProgressFSDS.Name = "grpProgressFSDS"
        Me.grpProgressFSDS.Size = New System.Drawing.Size(244, 221)
        Me.grpProgressFSDS.TabIndex = 3
        Me.grpProgressFSDS.TabStop = False
        Me.grpProgressFSDS.Text = "Progress"
        '
        'gpgbDownStatus_varFSDS
        '
        Me.gpgbDownStatus_varFSDS.BackgroundImage = CType(resources.GetObject("gpgbDownStatus_varFSDS.BackgroundImage"), System.Drawing.Image)
        Me.gpgbDownStatus_varFSDS.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.gpgbDownStatus_varFSDS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.gpgbDownStatus_varFSDS.Location = New System.Drawing.Point(9, 35)
        Me.gpgbDownStatus_varFSDS.Margin = New System.Windows.Forms.Padding(6)
        Me.gpgbDownStatus_varFSDS.Name = "gpgbDownStatus_varFSDS"
        Me.gpgbDownStatus_varFSDS.ProgressBgColor = System.Drawing.Color.Gray
        Me.gpgbDownStatus_varFSDS.ProgressColor1 = System.Drawing.Color.Tomato
        Me.gpgbDownStatus_varFSDS.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.gpgbDownStatus_varFSDS.Size = New System.Drawing.Size(211, 149)
        Me.gpgbDownStatus_varFSDS.Suffix = ""
        Me.gpgbDownStatus_varFSDS.TabIndex = 1
        Me.gpgbDownStatus_varFSDS.Thickness = 30
        Me.gpgbDownStatus_varFSDS.Value = 0
        '
        'lblStatus_varFSDS
        '
        Me.lblStatus_varFSDS.AutoSize = True
        Me.lblStatus_varFSDS.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus_varFSDS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblStatus_varFSDS.Location = New System.Drawing.Point(227, 235)
        Me.lblStatus_varFSDS.Name = "lblStatus_varFSDS"
        Me.lblStatus_varFSDS.Size = New System.Drawing.Size(156, 18)
        Me.lblStatus_varFSDS.TabIndex = 4
        Me.lblStatus_varFSDS.Text = "Starting Download..."
        '
        'pgbUI_Ac
        '
        Me.pgbUI_Ac.Location = New System.Drawing.Point(537, 238)
        Me.pgbUI_Ac.Name = "pgbUI_Ac"
        Me.pgbUI_Ac.Size = New System.Drawing.Size(87, 15)
        Me.pgbUI_Ac.TabIndex = 30
        Me.pgbUI_Ac.Visible = False
        '
        'TimerUI
        '
        Me.TimerUI.Interval = 10
        '
        'frmStats_DownloadStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(636, 262)
        Me.Controls.Add(Me.pgbUI_Ac)
        Me.Controls.Add(Me.lblStatus_varFSDS)
        Me.Controls.Add(Me.grpVidInfosFSDS)
        Me.Controls.Add(Me.grpProgressFSDS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStats_DownloadStats"
        Me.Text = "frmStats_DownloadStats"
        Me.grpVidInfosFSDS.ResumeLayout(False)
        Me.grpVidInfosFSDS.PerformLayout()
        Me.grpProgressFSDS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents grpVidInfosFSDS As GroupBox
    Friend WithEvents grpProgressFSDS As GroupBox
    Friend WithEvents gpgbDownStatus_varFSDS As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents lblTextFSDS2 As Label
    Friend WithEvents lblTextFSDS3 As Label
    Friend WithEvents lblNothing_FSDS As Label
    Friend WithEvents lblTextFSDS1 As Label
    Friend WithEvents lblTextFSDS4 As Label
    Friend WithEvents lblVidTitleTextFSDS As Label
    Friend WithEvents lblNothingFSDS2 As Label
    Friend WithEvents lblVidElapsedTime_varFSDS As Label
    Friend WithEvents lblVidTotalSize_varFSDS As Label
    Friend WithEvents lblDownSize_varFSDS As Label
    Friend WithEvents lblSavingPath_varFSDS As Label
    Friend WithEvents lblVidTitle_varFSDS As Label
    Friend WithEvents lblStatus_varFSDS As Label
    Friend WithEvents pgbUI_Ac As ProgressBar
    Friend WithEvents TimerUI As Timer
End Class
