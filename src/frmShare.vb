'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmShare
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Private Sub btnMainInfoFS_Click(sender As Object, e As EventArgs) Handles btnMainInfoFS.Click
        'Open Help
        frmHelp.Show()
    End Sub

    Private Sub btnSettingFS_Click(sender As Object, e As EventArgs) Handles btnSettingFS.Click
        'open Settings
        frmSettings.Show()
    End Sub

    Private Sub frmShare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Give txtURL (my.settings) to txtDirectDownLink
        txtDirectDownLink_varFS.Text = My.Settings.txtURL_varFD

    End Sub

    Private Sub txtDirectDownLink_varFS_OnValueChanged(sender As Object, e As EventArgs) Handles txtDirectDownLink_varFS.OnValueChanged
        'Paste url to en.savefrom.net from My,settings
        txtDirectDownLink_varFS.Text = "http://en.savefrom.net/#url=" + My.Settings.txtURL_varFD
        If txtDirectDownLink_varFS.Text.Contains("v") Then
            Try
                'QR CODE GENERATOR
                picAndroidPreview_varFS.Image = QR_Generator.Encode(My.Settings.direct_prev_link)
                picDirectDownLink_varFS.Image = QR_Generator.Encode(txtDirectDownLink_varFS.Text)
            Catch ex As Exception
                'Error
                MsgBox(ex.Message)
            End Try
        Else
            'Wrong URL do Nothing
        End If
    End Sub

    Private Sub btnSaveDDL_FS_Click(sender As Object, e As EventArgs) Handles btnSaveDDL_FS.Click
        'Open Path
        SaveFileDialogQR_Code_DDL.ShowDialog()
    End Sub

    Private Sub btnSaveAP_FS_Click(sender As Object, e As EventArgs) Handles btnSaveAP_FS.Click
        'Open Path
        SaveFileDialogQR_Code_AP.ShowDialog()
    End Sub

    Private Sub SaveFileDialogQR_Code_AP_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialogQR_Code_AP.FileOk
        'Try to Save Picture
        Try
            Dim img As New Bitmap(picAndroidPreview_varFS.Image)
            img.Save(SaveFileDialogQR_Code_AP.FileName, Imaging.ImageFormat.Png)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveFileDialogQR_Code_DDL_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialogQR_Code_DDL.FileOk
        'Try to Save Picture
        Try
            Dim img As New Bitmap(picDirectDownLink_varFS.Image)
            img.Save(SaveFileDialogQR_Code_AP.FileName, Imaging.ImageFormat.Png)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub imgbtnSaveFS_Click(sender As Object, e As EventArgs) Handles imgbtnSaveFS.Click
        'Open Path
        SaveFileDialogQR_Code_AP.ShowDialog()
    End Sub
End Class

