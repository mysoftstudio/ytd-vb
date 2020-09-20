<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStats_SystemStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStats_SystemStats))
        Me.ElipBorder = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.grpSystemFSSS = New System.Windows.Forms.GroupBox()
        Me.lblSysInfoTextBox_NothingFSSS = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtIPAddress_varFSSS = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtOsVersion_varFSSS = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtOsInfos_varFSSS = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtHostName_varFSSS = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblSysInfoTextFSSS5 = New System.Windows.Forms.Label()
        Me.lblSysInfoTextFSSS4 = New System.Windows.Forms.Label()
        Me.lblSysInfoTextFSSS3 = New System.Windows.Forms.Label()
        Me.lblSysInfoTextFSSS2 = New System.Windows.Forms.Label()
        Me.lblSysInfoTextFSSS1 = New System.Windows.Forms.Label()
        Me.grpUsageFSSS = New System.Windows.Forms.GroupBox()
        Me.gpgbMYDStatus_varFSSS = New Bunifu.Framework.UI.BunifuGauge()
        Me.lblCPU_varFSSS = New System.Windows.Forms.Label()
        Me.lblSysInfoTextFSSS8 = New System.Windows.Forms.Label()
        Me.lblRAM_varFSSS = New System.Windows.Forms.Label()
        Me.lblRAMUsed_varFSSS = New System.Windows.Forms.Label()
        Me.lblSysInfoTextFSSS7 = New System.Windows.Forms.Label()
        Me.lblSysInfoTextFSSS6 = New System.Windows.Forms.Label()
        Me.grpSystemFSSS.SuspendLayout()
        Me.grpUsageFSSS.SuspendLayout()
        Me.SuspendLayout()
        '
        'ElipBorder
        '
        Me.ElipBorder.ElipseRadius = 5
        Me.ElipBorder.TargetControl = Me
        '
        'grpSystemFSSS
        '
        Me.grpSystemFSSS.Controls.Add(Me.lblSysInfoTextBox_NothingFSSS)
        Me.grpSystemFSSS.Controls.Add(Me.txtIPAddress_varFSSS)
        Me.grpSystemFSSS.Controls.Add(Me.txtOsVersion_varFSSS)
        Me.grpSystemFSSS.Controls.Add(Me.txtOsInfos_varFSSS)
        Me.grpSystemFSSS.Controls.Add(Me.txtHostName_varFSSS)
        Me.grpSystemFSSS.Controls.Add(Me.lblSysInfoTextFSSS5)
        Me.grpSystemFSSS.Controls.Add(Me.lblSysInfoTextFSSS4)
        Me.grpSystemFSSS.Controls.Add(Me.lblSysInfoTextFSSS3)
        Me.grpSystemFSSS.Controls.Add(Me.lblSysInfoTextFSSS2)
        Me.grpSystemFSSS.Controls.Add(Me.lblSysInfoTextFSSS1)
        Me.grpSystemFSSS.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.grpSystemFSSS.Location = New System.Drawing.Point(12, 12)
        Me.grpSystemFSSS.Name = "grpSystemFSSS"
        Me.grpSystemFSSS.Size = New System.Drawing.Size(406, 238)
        Me.grpSystemFSSS.TabIndex = 0
        Me.grpSystemFSSS.TabStop = False
        Me.grpSystemFSSS.Text = "System Information"
        '
        'lblSysInfoTextBox_NothingFSSS
        '
        Me.lblSysInfoTextBox_NothingFSSS.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblSysInfoTextBox_NothingFSSS.BorderColorIdle = System.Drawing.Color.Tomato
        Me.lblSysInfoTextBox_NothingFSSS.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblSysInfoTextBox_NothingFSSS.BorderThickness = 1
        Me.lblSysInfoTextBox_NothingFSSS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblSysInfoTextBox_NothingFSSS.Enabled = False
        Me.lblSysInfoTextBox_NothingFSSS.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblSysInfoTextBox_NothingFSSS.ForeColor = System.Drawing.Color.Black
        Me.lblSysInfoTextBox_NothingFSSS.isPassword = False
        Me.lblSysInfoTextBox_NothingFSSS.Location = New System.Drawing.Point(202, 196)
        Me.lblSysInfoTextBox_NothingFSSS.Margin = New System.Windows.Forms.Padding(5)
        Me.lblSysInfoTextBox_NothingFSSS.Name = "lblSysInfoTextBox_NothingFSSS"
        Me.lblSysInfoTextBox_NothingFSSS.Size = New System.Drawing.Size(48, 23)
        Me.lblSysInfoTextBox_NothingFSSS.TabIndex = 3
        Me.lblSysInfoTextBox_NothingFSSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtIPAddress_varFSSS
        '
        Me.txtIPAddress_varFSSS.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtIPAddress_varFSSS.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtIPAddress_varFSSS.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtIPAddress_varFSSS.BorderThickness = 1
        Me.txtIPAddress_varFSSS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIPAddress_varFSSS.Enabled = False
        Me.txtIPAddress_varFSSS.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIPAddress_varFSSS.ForeColor = System.Drawing.Color.Black
        Me.txtIPAddress_varFSSS.isPassword = False
        Me.txtIPAddress_varFSSS.Location = New System.Drawing.Point(202, 155)
        Me.txtIPAddress_varFSSS.Margin = New System.Windows.Forms.Padding(5)
        Me.txtIPAddress_varFSSS.Name = "txtIPAddress_varFSSS"
        Me.txtIPAddress_varFSSS.Size = New System.Drawing.Size(118, 23)
        Me.txtIPAddress_varFSSS.TabIndex = 3
        Me.txtIPAddress_varFSSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtOsVersion_varFSSS
        '
        Me.txtOsVersion_varFSSS.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtOsVersion_varFSSS.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtOsVersion_varFSSS.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtOsVersion_varFSSS.BorderThickness = 1
        Me.txtOsVersion_varFSSS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOsVersion_varFSSS.Enabled = False
        Me.txtOsVersion_varFSSS.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtOsVersion_varFSSS.ForeColor = System.Drawing.Color.Black
        Me.txtOsVersion_varFSSS.isPassword = False
        Me.txtOsVersion_varFSSS.Location = New System.Drawing.Point(202, 112)
        Me.txtOsVersion_varFSSS.Margin = New System.Windows.Forms.Padding(5)
        Me.txtOsVersion_varFSSS.Name = "txtOsVersion_varFSSS"
        Me.txtOsVersion_varFSSS.Size = New System.Drawing.Size(91, 23)
        Me.txtOsVersion_varFSSS.TabIndex = 3
        Me.txtOsVersion_varFSSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtOsInfos_varFSSS
        '
        Me.txtOsInfos_varFSSS.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtOsInfos_varFSSS.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtOsInfos_varFSSS.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtOsInfos_varFSSS.BorderThickness = 1
        Me.txtOsInfos_varFSSS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOsInfos_varFSSS.Enabled = False
        Me.txtOsInfos_varFSSS.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtOsInfos_varFSSS.ForeColor = System.Drawing.Color.Black
        Me.txtOsInfos_varFSSS.isPassword = False
        Me.txtOsInfos_varFSSS.Location = New System.Drawing.Point(202, 74)
        Me.txtOsInfos_varFSSS.Margin = New System.Windows.Forms.Padding(5)
        Me.txtOsInfos_varFSSS.Name = "txtOsInfos_varFSSS"
        Me.txtOsInfos_varFSSS.Size = New System.Drawing.Size(196, 23)
        Me.txtOsInfos_varFSSS.TabIndex = 3
        Me.txtOsInfos_varFSSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtHostName_varFSSS
        '
        Me.txtHostName_varFSSS.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtHostName_varFSSS.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtHostName_varFSSS.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtHostName_varFSSS.BorderThickness = 1
        Me.txtHostName_varFSSS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHostName_varFSSS.Enabled = False
        Me.txtHostName_varFSSS.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtHostName_varFSSS.ForeColor = System.Drawing.Color.Black
        Me.txtHostName_varFSSS.isPassword = False
        Me.txtHostName_varFSSS.Location = New System.Drawing.Point(202, 35)
        Me.txtHostName_varFSSS.Margin = New System.Windows.Forms.Padding(5)
        Me.txtHostName_varFSSS.Name = "txtHostName_varFSSS"
        Me.txtHostName_varFSSS.Size = New System.Drawing.Size(196, 23)
        Me.txtHostName_varFSSS.TabIndex = 3
        Me.txtHostName_varFSSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblSysInfoTextFSSS5
        '
        Me.lblSysInfoTextFSSS5.AutoSize = True
        Me.lblSysInfoTextFSSS5.ForeColor = System.Drawing.Color.Tomato
        Me.lblSysInfoTextFSSS5.Location = New System.Drawing.Point(115, 196)
        Me.lblSysInfoTextFSSS5.Name = "lblSysInfoTextFSSS5"
        Me.lblSysInfoTextFSSS5.Size = New System.Drawing.Size(79, 20)
        Me.lblSysInfoTextFSSS5.TabIndex = 1
        Me.lblSysInfoTextFSSS5.Text = "Country : "
        '
        'lblSysInfoTextFSSS4
        '
        Me.lblSysInfoTextFSSS4.AutoSize = True
        Me.lblSysInfoTextFSSS4.Location = New System.Drawing.Point(93, 155)
        Me.lblSysInfoTextFSSS4.Name = "lblSysInfoTextFSSS4"
        Me.lblSysInfoTextFSSS4.Size = New System.Drawing.Size(101, 20)
        Me.lblSysInfoTextFSSS4.TabIndex = 1
        Me.lblSysInfoTextFSSS4.Text = "IP Address :  "
        '
        'lblSysInfoTextFSSS3
        '
        Me.lblSysInfoTextFSSS3.AutoSize = True
        Me.lblSysInfoTextFSSS3.Location = New System.Drawing.Point(95, 112)
        Me.lblSysInfoTextFSSS3.Name = "lblSysInfoTextFSSS3"
        Me.lblSysInfoTextFSSS3.Size = New System.Drawing.Size(99, 20)
        Me.lblSysInfoTextFSSS3.TabIndex = 1
        Me.lblSysInfoTextFSSS3.Text = "OS Version : "
        '
        'lblSysInfoTextFSSS2
        '
        Me.lblSysInfoTextFSSS2.AutoSize = True
        Me.lblSysInfoTextFSSS2.Location = New System.Drawing.Point(6, 74)
        Me.lblSysInfoTextFSSS2.Name = "lblSysInfoTextFSSS2"
        Me.lblSysInfoTextFSSS2.Size = New System.Drawing.Size(188, 20)
        Me.lblSysInfoTextFSSS2.TabIndex = 1
        Me.lblSysInfoTextFSSS2.Text = "Operating System Infos : "
        '
        'lblSysInfoTextFSSS1
        '
        Me.lblSysInfoTextFSSS1.AutoSize = True
        Me.lblSysInfoTextFSSS1.Location = New System.Drawing.Point(51, 35)
        Me.lblSysInfoTextFSSS1.Name = "lblSysInfoTextFSSS1"
        Me.lblSysInfoTextFSSS1.Size = New System.Drawing.Size(143, 20)
        Me.lblSysInfoTextFSSS1.TabIndex = 1
        Me.lblSysInfoTextFSSS1.Text = "Computer Name : "
        '
        'grpUsageFSSS
        '
        Me.grpUsageFSSS.BackColor = System.Drawing.Color.Transparent
        Me.grpUsageFSSS.Controls.Add(Me.gpgbMYDStatus_varFSSS)
        Me.grpUsageFSSS.Controls.Add(Me.lblCPU_varFSSS)
        Me.grpUsageFSSS.Controls.Add(Me.lblSysInfoTextFSSS8)
        Me.grpUsageFSSS.Controls.Add(Me.lblRAM_varFSSS)
        Me.grpUsageFSSS.Controls.Add(Me.lblRAMUsed_varFSSS)
        Me.grpUsageFSSS.Controls.Add(Me.lblSysInfoTextFSSS7)
        Me.grpUsageFSSS.Controls.Add(Me.lblSysInfoTextFSSS6)
        Me.grpUsageFSSS.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.grpUsageFSSS.Location = New System.Drawing.Point(437, 12)
        Me.grpUsageFSSS.Name = "grpUsageFSSS"
        Me.grpUsageFSSS.Size = New System.Drawing.Size(187, 238)
        Me.grpUsageFSSS.TabIndex = 0
        Me.grpUsageFSSS.TabStop = False
        Me.grpUsageFSSS.Text = "System Usage"
        '
        'gpgbMYDStatus_varFSSS
        '
        Me.gpgbMYDStatus_varFSSS.BackgroundImage = CType(resources.GetObject("gpgbMYDStatus_varFSSS.BackgroundImage"), System.Drawing.Image)
        Me.gpgbMYDStatus_varFSSS.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.gpgbMYDStatus_varFSSS.ForeColor = System.Drawing.Color.Tomato
        Me.gpgbMYDStatus_varFSSS.Location = New System.Drawing.Point(31, 128)
        Me.gpgbMYDStatus_varFSSS.Margin = New System.Windows.Forms.Padding(6)
        Me.gpgbMYDStatus_varFSSS.Name = "gpgbMYDStatus_varFSSS"
        Me.gpgbMYDStatus_varFSSS.ProgressBgColor = System.Drawing.Color.Gray
        Me.gpgbMYDStatus_varFSSS.ProgressColor1 = System.Drawing.Color.Tomato
        Me.gpgbMYDStatus_varFSSS.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.gpgbMYDStatus_varFSSS.Size = New System.Drawing.Size(122, 83)
        Me.gpgbMYDStatus_varFSSS.Suffix = ""
        Me.gpgbMYDStatus_varFSSS.TabIndex = 2
        Me.gpgbMYDStatus_varFSSS.Thickness = 10
        Me.gpgbMYDStatus_varFSSS.Value = 0
        '
        'lblCPU_varFSSS
        '
        Me.lblCPU_varFSSS.AutoSize = True
        Me.lblCPU_varFSSS.ForeColor = System.Drawing.Color.Tomato
        Me.lblCPU_varFSSS.Location = New System.Drawing.Point(74, 215)
        Me.lblCPU_varFSSS.Name = "lblCPU_varFSSS"
        Me.lblCPU_varFSSS.Size = New System.Drawing.Size(29, 20)
        Me.lblCPU_varFSSS.TabIndex = 1
        Me.lblCPU_varFSSS.Text = "0%"
        '
        'lblSysInfoTextFSSS8
        '
        Me.lblSysInfoTextFSSS8.AutoSize = True
        Me.lblSysInfoTextFSSS8.Location = New System.Drawing.Point(50, 102)
        Me.lblSysInfoTextFSSS8.Name = "lblSysInfoTextFSSS8"
        Me.lblSysInfoTextFSSS8.Size = New System.Drawing.Size(53, 20)
        Me.lblSysInfoTextFSSS8.TabIndex = 1
        Me.lblSysInfoTextFSSS8.Text = "CPU : "
        '
        'lblRAM_varFSSS
        '
        Me.lblRAM_varFSSS.AutoSize = True
        Me.lblRAM_varFSSS.ForeColor = System.Drawing.Color.Tomato
        Me.lblRAM_varFSSS.Location = New System.Drawing.Point(109, 35)
        Me.lblRAM_varFSSS.Name = "lblRAM_varFSSS"
        Me.lblRAM_varFSSS.Size = New System.Drawing.Size(69, 20)
        Me.lblRAM_varFSSS.TabIndex = 1
        Me.lblRAM_varFSSS.Text = "4096 MB"
        '
        'lblRAMUsed_varFSSS
        '
        Me.lblRAMUsed_varFSSS.AutoSize = True
        Me.lblRAMUsed_varFSSS.ForeColor = System.Drawing.Color.Tomato
        Me.lblRAMUsed_varFSSS.Location = New System.Drawing.Point(109, 80)
        Me.lblRAMUsed_varFSSS.Name = "lblRAMUsed_varFSSS"
        Me.lblRAMUsed_varFSSS.Size = New System.Drawing.Size(69, 20)
        Me.lblRAMUsed_varFSSS.TabIndex = 1
        Me.lblRAMUsed_varFSSS.Text = "2048 MB"
        '
        'lblSysInfoTextFSSS7
        '
        Me.lblSysInfoTextFSSS7.AutoSize = True
        Me.lblSysInfoTextFSSS7.Location = New System.Drawing.Point(6, 77)
        Me.lblSysInfoTextFSSS7.Name = "lblSysInfoTextFSSS7"
        Me.lblSysInfoTextFSSS7.Size = New System.Drawing.Size(97, 20)
        Me.lblSysInfoTextFSSS7.TabIndex = 1
        Me.lblSysInfoTextFSSS7.Text = "RAM Used : "
        '
        'lblSysInfoTextFSSS6
        '
        Me.lblSysInfoTextFSSS6.AutoSize = True
        Me.lblSysInfoTextFSSS6.Location = New System.Drawing.Point(47, 35)
        Me.lblSysInfoTextFSSS6.Name = "lblSysInfoTextFSSS6"
        Me.lblSysInfoTextFSSS6.Size = New System.Drawing.Size(56, 20)
        Me.lblSysInfoTextFSSS6.TabIndex = 1
        Me.lblSysInfoTextFSSS6.Text = "RAM : "
        '
        'frmStats_SystemStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(636, 262)
        Me.Controls.Add(Me.grpUsageFSSS)
        Me.Controls.Add(Me.grpSystemFSSS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStats_SystemStats"
        Me.Text = "frmSystemStats"
        Me.grpSystemFSSS.ResumeLayout(False)
        Me.grpSystemFSSS.PerformLayout()
        Me.grpUsageFSSS.ResumeLayout(False)
        Me.grpUsageFSSS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElipBorder As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents grpUsageFSSS As GroupBox
    Friend WithEvents grpSystemFSSS As GroupBox
    Friend WithEvents gpgbMYDStatus_varFSSS As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents lblSysInfoTextFSSS1 As Label
    Friend WithEvents lblSysInfoTextFSSS5 As Label
    Friend WithEvents lblSysInfoTextFSSS4 As Label
    Friend WithEvents lblSysInfoTextFSSS3 As Label
    Friend WithEvents lblSysInfoTextFSSS2 As Label
    Friend WithEvents lblSysInfoTextBox_NothingFSSS As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtIPAddress_varFSSS As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtOsVersion_varFSSS As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtOsInfos_varFSSS As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtHostName_varFSSS As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblSysInfoTextFSSS8 As Label
    Friend WithEvents lblSysInfoTextFSSS7 As Label
    Friend WithEvents lblSysInfoTextFSSS6 As Label
    Friend WithEvents lblRAM_varFSSS As Label
    Friend WithEvents lblRAMUsed_varFSSS As Label
    Friend WithEvents lblCPU_varFSSS As Label
End Class
