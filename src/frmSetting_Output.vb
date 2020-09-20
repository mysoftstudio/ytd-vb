'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmSetting_Output
    Private Sub frmSetting_Output_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Auto Generate settings as form Load
        ckbFSO_KeepOrig_FileName.Checked = My.Settings.ckbFSO_KeepOrig_FileName
        ckbFSO_Overwrite_IfExist.Checked = My.Settings.ckbFSO_Overwrite_IfExist
        ckbFSO_SaveVidThumbnail.Checked = My.Settings.ckbFSO_SaveVidThumbnail
        txtFilePathFSO.Text = My.Settings.txtFilePathFSO
    End Sub

    Private Sub autosave_frmClose(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'AutoSave
        If My.Settings.ckbFSA_AutoSaveSets = True Then
            My.Settings.ckbFSO_KeepOrig_FileName = ckbFSO_KeepOrig_FileName.Checked
            My.Settings.ckbFSO_Overwrite_IfExist = ckbFSO_Overwrite_IfExist.Checked
            My.Settings.ckbFSO_SaveVidThumbnail = ckbFSO_SaveVidThumbnail.Checked
            My.Settings.txtFilePathFSO = txtFilePathFSO.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnSaveFSO_Click(sender As Object, e As EventArgs) Handles btnSaveFSO.Click
        'Save Settings
        My.Settings.ckbFSO_KeepOrig_FileName = ckbFSO_KeepOrig_FileName.Checked
        My.Settings.ckbFSO_Overwrite_IfExist = ckbFSO_Overwrite_IfExist.Checked
        My.Settings.ckbFSO_SaveVidThumbnail = ckbFSO_SaveVidThumbnail.Checked
        My.Settings.txtFilePathFSO = txtFilePathFSO.Text
        My.Settings.Save()
    End Sub

    Private Sub btnGetPremiumFSO_Click(sender As Object, e As EventArgs)
        frmSettings.Close()
        frmPremium.Show()
        Process.Start("http://www.mysoftstudio.ml")
        'Komm Gleich
    End Sub

    Private Sub btnMainInfoFSO_Click(sender As Object, e As EventArgs) Handles btnMainInfoFSO.Click
        'Display Help // According to Article
        Dim result As Integer = MessageBox.Show("Please choose a path where your video download should to be save !" & vbNewLine & " Thanks For Using MySoft YouTube Download | MySoftudio | Franz Nkemaka" & vbNewLine & " If you Wishes more Help and Guide ? would you want to know more ? ", " Information - File Setting MySoft YouTube Downloader", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            frmHelp.Show()
        End If
    End Sub

    Private Sub btnSelectPathFSO_Click(sender As Object, e As EventArgs) Handles btnSelectPathFSO.Click
        'File Dialog
        If FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            txtFilePathFSO.Text = FolderBrowserDialog.SelectedPath
        Else
            txtFilePathFSO.Text = "C:\Users\" & My.Computer.Name & "\Downloads"
        End If
    End Sub
End Class

