'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmTopMenu_Download
    Private Sub frmTopMenu_Download_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Set differents Objects to My.Settings
        lblCurrentStatus_varFTMD.Text = My.Settings.ui_ftmd_lblCurrentStatus_varFTMD

        lblProgressValueFTMD_var.Text = My.Settings.lblProgressValueFTMD_var
        lblVidFormat_varFTMD.Text = My.Settings.ui_ftmd_lblVidFormat_varFTMD
        lblVidName_varFTMD.Text = My.Settings.ui_ftmd_lblVidName_varFTMD
        lblVidSize_varFTMD.Text = My.Settings.ui_ftmd_lblVidSize_varFTMD
#Disable Warning BC42025 ' Accès d’un membre partagé, d’un membre de constante, d’un membre enum ou d’un type imbriqué via une instance
        lblLastDownFTMD_var.Text = My.Settings.lblLastDownFTMD_var
#Enable Warning BC42025 ' Accès d’un membre partagé, d’un membre de constante, d’un membre enum ou d’un type imbriqué via une instance

        'Load Timer 
        TimerUI.Start()
    End Sub

    Private Sub TimerUI_Tick(sender As Object, e As EventArgs) Handles TimerUI.Tick
        pgbUI_Ac.Increment(1)
        'change ProgressBar Value
        If pgbUI_Ac.Value = 0 Then
            TimerUI.Start()
        ElseIf pgbUI_Ac.Value = 100 Then
            pgbUI_Ac.Value = 0
            TimerUI.Start()
        End If


        'Set differents Objects to My.Settings
        lblCurrentStatus_varFTMD.Text = My.Settings.ui_ftmd_lblCurrentStatus_varFTMD

        lblProgressValueFTMD_var.Text = My.Settings.lblProgressValueFTMD_var
        lblVidFormat_varFTMD.Text = My.Settings.ui_ftmd_lblVidFormat_varFTMD
        lblVidName_varFTMD.Text = My.Settings.ui_ftmd_lblVidName_varFTMD
        lblVidSize_varFTMD.Text = My.Settings.ui_ftmd_lblVidSize_varFTMD
        gpgbDownloadProgressFTMD.Value = My.Settings.gpgbDownloadProgressFTMD


        'For UI purpose 
        If lblCurrentStatus_varFTMD.Text = "" = False Then

            If lblCurrentStatus_varFTMD.Text = "Invalid URL" Or lblCurrentStatus_varFTMD.Text = "Please Change URL" Then
                lblCurrentStatus_varFTMD.ForeColor = Color.Tomato '// As Red
            Else
                lblCurrentStatus_varFTMD.ForeColor = Color.FromArgb(0, 187, 125) '// As Green
            End If
        End If
    End Sub
End Class

