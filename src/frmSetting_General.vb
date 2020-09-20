'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmSetting_General
    Dim frmMain As New frmMain

    Private Sub frmSetting_General_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Selected Settings
        dpdVidFormatFSG.selectedIndex = 2

        'Auto Generate settings as form Load
        dpdVidFormatFSG.selectedIndex = My.Settings.dpdVidFormatFSG
        dpdVidQualityFSG.selectedIndex = My.Settings.dpdVidQualityFSG
        My.Settings.switchHomeTutoFSG = switchHomeTutoFSG.Value
        switchHomeTutoFSG.Value = My.Settings.switchHomeTutoFSG

    End Sub

    Private Sub autosave_frmClose(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Auto Save
        If My.Settings.ckbFSA_AutoSaveSets = True Then
            My.Settings.dpdVidFormatFSG = dpdVidFormatFSG.selectedIndex
            My.Settings.dpdVidQualityFSG = dpdVidQualityFSG.selectedIndex
            My.Settings.switchHomeTutoFSG = switchHomeTutoFSG.Value
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnSaveFSG_Click(sender As Object, e As EventArgs) Handles btnSaveFSG.Click
        'Save Settings
        My.Settings.dpdVidFormatFSG = dpdVidFormatFSG.selectedIndex
        My.Settings.dpdVidQualityFSG = dpdVidQualityFSG.selectedIndex
        My.Settings.switchHomeTutoFSG = switchHomeTutoFSG.Value
        My.Settings.Save()
    End Sub

    Private Sub btnGetPremiumFSG_Click(sender As Object, e As EventArgs)
        frmSettings.Close()
        frmPremium.Show()
        Process.Start("http://www.mysoftstudio.ml")
        'Komm Gleich
    End Sub

    Private Sub btnMainInfoFSG_Click(sender As Object, e As EventArgs) Handles btnMainInfoFSG.Click
        'Display Help // According to Article
        Dim result As Integer = MessageBox.Show("Please choose a path where your video download should to be save !" & vbNewLine & " Thanks For Using MySoft YouTube Download | MySoftudio | Franz Nkemaka" & vbNewLine & " If you Wishes more Help and Guide ? would you want to know more ? ", " Information - General Setting MySoft YouTube Downloader", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            frmHelp.Show()
        End If
    End Sub

    Private Sub btnFontInfoFSG_Click(sender As Object, e As EventArgs) Handles btnFontInfoFSG.Click
        MsgBox("Please in this version ;1.0 it is difficult to do this changes so we advice you to leave it as default ", MsgBoxStyle.Information, "Appearence - General Setting MySoft YouTube Downloader")
    End Sub

    Private Sub btnVidInfoFSG_Click(sender As Object, e As EventArgs) Handles btnVidInfoFSG.Click
        MsgBox("Please select your desired video Quality and Format and please notice that this would depend on your video !. MySoft YouTube Downloader do not limit users. All free and if you like please Upgrade to premium or Donate ", MsgBoxStyle.Information, "Video Settings - General Setting MySoft YouTube Downloader")
    End Sub

    Private Sub switchHomeTutoFSG_OnValueChange(sender As Object, e As EventArgs) Handles switchHomeTutoFSG.OnValueChange



        If My.Settings.switchHomeTutoFSG = False Then
            My.Settings.switchHomeTutoMain = True
            My.Settings.switchHomeTutoFSG = True


        Else
            My.Settings.switchHomeTutoMain = False
            My.Settings.switchHomeTutoFSG = False



        End If
        My.Settings.Save()
    End Sub

    Private Sub dpdVidQualityFSG_onItemSelected(sender As Object, e As EventArgs) Handles dpdVidQualityFSG.onItemSelected
        'Change Quality according to setiings // quality
        If My.Settings.dpdVidQualityFSG = 0 Then
            My.Settings.dpdVidQualityFSG = 2
            My.Settings.cbbQuality_strFD = 0

        End If
        If My.Settings.dpdVidQualityFSG = 1 Then
            My.Settings.cbbQuality_strFD = 5
        ElseIf My.Settings.dpdVidQualityFSG = 2 Then
            My.Settings.cbbQuality_strFD = 0
        ElseIf My.Settings.dpdVidQualityFSG = 3 Then
            My.Settings.cbbQuality_strFD = 12
        ElseIf My.Settings.dpdVidQualityFSG = 4 Then
            My.Settings.cbbQuality_strFD = 1
        ElseIf My.Settings.dpdVidQualityFSG = 5 Then
            My.Settings.cbbQuality_strFD = 3
        ElseIf My.Settings.dpdVidQualityFSG = 6 Then
            My.Settings.cbbQuality_strFD = 4
        End If
    End Sub

    Private Sub dpdVidFormatFSG_onItemSelected(sender As Object, e As EventArgs) Handles dpdVidFormatFSG.onItemSelected
        'Check (Setting to String) and change current dpd value (My.setting) // Format 
        If My.Settings.dpdVidFormatFSG = 0 Then
            My.Settings.cbbFormat_strFD = 0
        ElseIf My.Settings.dpdVidFormatFSG = 1 Then
            My.Settings.cbbFormat_strFD = 3
        ElseIf My.Settings.dpdVidFormatFSG = 2 Then
            My.Settings.cbbFormat_strFD = 1
        End If
    End Sub
End Class

