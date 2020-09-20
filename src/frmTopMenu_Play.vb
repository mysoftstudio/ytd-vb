'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmTopMenu_Play
    Private Sub frmTopMenu_Play_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set differents Objects to My.Settings
        lblVidName_varFTMPV.Text = My.Settings.ui_lbl_frmPlay_varVidName
        lblFilePathFTMPV_var.Text = My.Settings.ui_lbl_frmPlay_varVidPath
        lblFileFormatFTMPV_var.Text = My.Settings.ui_ftmd_lblVidFormat_varFTMD
        pgbAnimateFTMPV.Value = My.Settings.ui_lbl_frmPlay_varProgressBar

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
        lblVidName_varFTMPV.Text = My.Settings.ui_lbl_frmPlay_varVidName
        lblFilePathFTMPV_var.Text = My.Settings.ui_lbl_frmPlay_varVidPath
        lblFileFormatFTMPV_var.Text = My.Settings.ui_ftmd_lblVidFormat_varFTMD

    End Sub
End Class

