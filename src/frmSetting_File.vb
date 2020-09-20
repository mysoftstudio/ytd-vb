'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmSetting_File
    Private Sub frmSetting_File_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Auto Generate settings as form Load
        txtFileNameFSF.Text = My.Settings.txtFileNameFSF
        switchOriginal_YoutubeTileFSF.Value = My.Settings.switchOriginal_YoutubeTileFSF
    End Sub
    Private Sub autosave_close(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If My.Settings.ckbFSA_AutoSaveSets = True Then
            My.Settings.txtFileNameFSF = txtFileNameFSF.Text
            My.Settings.switchOriginal_YoutubeTileFSF = switchOriginal_YoutubeTileFSF.Value
            My.Settings.Save()
        End If
    End Sub
    Private Sub btnMainInfoFSF_Click(sender As Object, e As EventArgs) Handles btnMainInfoFSL.Click
        'Display Help // According to Article
        Dim result As Integer = MessageBox.Show("In MySoft YouTube Download it is also possible to change your download file Name Ex. MySoft YouTube Downloader. All Red features are unable, please try to Update if there is an Update else please upgrade to Premium. It is not obliged you could also leave it as sans (it will do it automatically...).  " & vbNewLine & " Thanks For Using MySoft YouTube Download | MySoftudio | Franz Nkemaka" & vbNewLine & " If you Wishes more Help and Guide ? would you want to know more ? ", "About - Advanced Setting MySoft YouTube Downloader", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            frmHelp.Show()
        End If
    End Sub

    Private Sub btnGetPremiumFSL_Click(sender As Object, e As EventArgs)
        frmSettings.Close()
        frmPremium.Show()
        Process.Start("http://www.mysoftstudio.ml")
        'Komm Gleich
    End Sub

    Private Sub btnSaveFSL_Click(sender As Object, e As EventArgs) Handles btnSaveFSL.Click
        My.Settings.txtFileNameFSF = txtFileNameFSF.Text
        My.Settings.switchOriginal_YoutubeTileFSF = switchOriginal_YoutubeTileFSF.Value
        My.Settings.Save()
    End Sub

    Private Sub btnNameInfoFSL_Click(sender As Object, e As EventArgs) Handles btnNameInfoFSL.Click
        MsgBox("Please don't write special characters like : /, \, '', #, &, $,§, etc. if not it software would crash or fail." & vbNewLine & " Thanks For Using MySoft YouTube Download | MySoftudio | Franz Nkemaka", MsgBoxStyle.Information, "Information - File Setting MySoft YouTube Downloader")
    End Sub

    Private Sub switchOriginal_YoutubeTileFSF_OnValueChange(sender As Object, e As EventArgs) Handles switchOriginal_YoutubeTileFSF.OnValueChange
        If My.Settings.switchOriginal_YoutubeTileFSF = True Then
            txtFileNameFSF.Text = My.Settings.ui_ftmd_lblVidName_varFTMD
        Else
            'Do Nothing
        End If
    End Sub
End Class

