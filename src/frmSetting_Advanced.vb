'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Imports System.Runtime.InteropServices
Public Class frmSetting_Advanced
    'Variable to Change Sound //
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_UP As UInteger = &HA
    Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
    Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8
    Private Sub frmSetting_Advanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Auto Generate settings as form Load
        ckbFSA_AddHistory.Checked = My.Settings.ckbFSA_AddHistory
        ckbFSA_AutoCkUpdates.Checked = My.Settings.ckbFSA_AutoCkUpdates
        ckbFSA_AutoSaveSets.Checked = My.Settings.ckbFSA_AutoSaveSets
        ckbFSA_PasteURLs.Checked = My.Settings.ckbFSA_PasteURLs
        ckbFSA_PreviewVid.Checked = My.Settings.ckbFSA_PreviewVid
        switchOffDownloadDoneFSA.Value = My.Settings.switchOffDownloadDoneFSA
        switchSoundEnableFSA.Value = My.Settings.switchSoundEnableFSA
    End Sub
    Private Sub btnSaveFSA_Click(sender As Object, e As EventArgs) Handles btnSaveFSA.Click
        'Auto Save
        My.Settings.ckbFSA_AutoSaveSets = ckbFSA_AutoSaveSets.Checked
        My.Settings.ckbFSA_AddHistory = ckbFSA_AddHistory.Checked
        My.Settings.ckbFSA_AutoCkUpdates = ckbFSA_AutoCkUpdates.Checked
        My.Settings.ckbFSA_PasteURLs = ckbFSA_PasteURLs.Checked
        My.Settings.ckbFSA_PreviewVid = ckbFSA_PreviewVid.Checked
        My.Settings.switchSoundEnableFSA = switchSoundEnableFSA.Value
        My.Settings.switchOffDownloadDoneFSA = switchOffDownloadDoneFSA.Value
        My.Settings.Save()
    End Sub

    Private Sub autosave_frmClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Auto Save Settings // If checked frmSetting_Advanced
        If ckbFSA_AutoSaveSets.Checked = True Then
            'Auto Save
            My.Settings.ckbFSA_AutoSaveSets = ckbFSA_AutoSaveSets.Checked
            My.Settings.ckbFSA_AddHistory = ckbFSA_AddHistory.Checked
            My.Settings.ckbFSA_AutoCkUpdates = ckbFSA_AutoCkUpdates.Checked
            My.Settings.ckbFSA_PasteURLs = ckbFSA_PasteURLs.Checked
            My.Settings.ckbFSA_PreviewVid = ckbFSA_PreviewVid.Checked
            My.Settings.switchSoundEnableFSA = switchSoundEnableFSA.Value
            My.Settings.switchOffDownloadDoneFSA = switchOffDownloadDoneFSA.Value
            My.Settings.Reset()
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnGetPremiumFSA_Click(sender As Object, e As EventArgs)
        frmSettings.Close()
        frmPremium.Show()
        Process.Start("http://www.mysoftstudio.ml")
        'Komm Gleich
    End Sub

    Private Sub btnMainInfoFSA_Click(sender As Object, e As EventArgs) Handles btnMainInfoFSA.Click
        'Display Help // According to Article
        Dim result As Integer = MessageBox.Show("In MySoft YouTube Download it is also possible to let it do everything alone. All Red features are unable, please try to Update if there is an Update else please upgrade to Premium. For example: Auto-Url Paste, would paste your URL automatically. " & vbNewLine & " Thanks For Using MySoft YouTube Download | MySoftudio | Franz Nkemaka" & vbNewLine & " If you Wishes more Help and Guide ? would you want to know more ? ", "About - Advanced Setting MySoft YouTube Downloader", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            frmHelp.Show()
        End If
    End Sub

    Private Sub switchSoundEnableFSA_OnValueChange(sender As Object, e As EventArgs) Handles switchSoundEnableFSA.OnValueChange
        ' activate or Disactivate  // As Value Change
        If switchSoundEnableFSA.Value = False Then
            SendMessage(Me.Handle, WM_APPCOMMAND, &H200EB0, APPCOMMAND_VOLUME_MUTE * &H10000)
        Else
        End If
    End Sub

    Private Sub btnAddSoundFSA_Click(sender As Object, e As EventArgs) Handles btnAddSoundFSA.Click
        'Add Volume
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
    End Sub

    Private Sub btnLowSoundFSA_Click(sender As Object, e As EventArgs) Handles btnLowSoundFSA.Click
        'Reduce/low Volume
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
    End Sub

    Private Sub switchOffDownloadDoneFSA_OnValueChange(sender As Object, e As EventArgs) Handles switchOffDownloadDoneFSA.OnValueChange
        'Komm Gleich
    End Sub
End Class

