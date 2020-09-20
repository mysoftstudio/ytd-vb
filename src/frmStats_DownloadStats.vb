'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmStats_DownloadStats
    Private Sub frmStats_DownloadStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set differents Objects to My.Settings
        lblVidTitle_varFSDS.Text = My.Settings.ui_ftmd_lblVidName_varFTMD
        lblVidTotalSize_varFSDS.Text = My.Settings.ui_ftmd_lblVidSize_varFTMD
        lblStatus_varFSDS.Text = My.Settings.ui_ftmd_lblCurrentStatus_varFTMD
        lblSavingPath_varFSDS.Text = My.Settings.txtFilePathFSO
        lblDownSize_varFSDS.Text = My.Settings.ui_frm_varDownSize
        gpgbDownStatus_varFSDS.Value = My.Settings.gpgbDownloadProgressFTMD

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
        lblVidTitle_varFSDS.Text = My.Settings.ui_ftmd_lblVidName_varFTMD
        lblVidTotalSize_varFSDS.Text = My.Settings.ui_ftmd_lblVidSize_varFTMD
        lblStatus_varFSDS.Text = My.Settings.ui_ftmd_lblCurrentStatus_varFTMD
        lblSavingPath_varFSDS.Text = My.Settings.txtFilePathFSO
        lblDownSize_varFSDS.Text = My.Settings.ui_frm_varDownSize
        gpgbDownStatus_varFSDS.Value = My.Settings.gpgbDownloadProgressFTMD


        'For UI purpose 
        If lblStatus_varFSDS.Text = "" = False Then

            If lblStatus_varFSDS.Text = "Invalid URL" Or lblStatus_varFSDS.Text = "Please Change URL" Then
                lblStatus_varFSDS.ForeColor = Color.Tomato '// As Red

            ElseIf lblStatus_varFSDS.Text = "Verifying URL..." Or lblStatus_varFSDS.Text = "Checking Formats..." Or lblStatus_varFSDS.Text = "Download Request Sucessfully" Or lblStatus_varFSDS.Text = "Valid URL" Then
                lblStatus_varFSDS.ForeColor = Color.FromArgb(0, 187, 125) '// As Green
            End If
        End If
    End Sub

End Class

