'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Imports System.Runtime.InteropServices
Public Class frmPlay
    'Variable to Change Sound //
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_UP As UInteger = &HA
    Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
    Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8
    Public Sub sub_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(-2, -2)
        AxVLCPlugin21.Visible = False ' Hide VLC
        lblTextFPV1.Text = "No Video to play"
        NotifyIconDownFinish.BalloonTipTitle = "Playing Video on MySoft YouTube Downloader"
        NotifyIconDownFinish.BalloonTipText = "Unable to read video file, please try to check for a new version. An error occured, please declare a bug"

        NotifyIconDownFinish.ShowBalloonTip(0)
    End Sub

    Private Sub picBackFontFPS2_Click(sender As Object, e As EventArgs) Handles picBackFontFPS2.Click, btnImportFPV.Click
        ' Open File Dialog (Path) of The Video
        OpenFileDialog.Filter = "(*.mp4) |*.mp4"
        NotifyIconDownFinish.BalloonTipTitle = "Playing Video on MySoft YouTube Downloader"
        NotifyIconDownFinish.BalloonTipText = "Unable to read video file, please try to check for a new version. An error occured, please declare a bug"

        NotifyIconDownFinish.ShowBalloonTip(0)

        Try
            If OpenFileDialog.ShowDialog() = DialogResult.OK Then
                AxVLCPlugin21.Visible = True ' Show VLC
                AxVLCPlugin21.playlist.add(OpenFileDialog.FileName)
                Process.Start(OpenFileDialog.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex)

        End Try
    End Sub

    Private Sub imgbtnFPS_Play_Click(sender As Object, e As EventArgs) Handles imgbtnFPS_Play.Click, btnPlayFPS.Click
        Try
            'Play playlist
            AxVLCPlugin21.playlist.play()
            imgbtnFPS_Pause.Visible = True

            imgbtnFPS_Play.Visible = False
        Catch ex As Exception
            MsgBox(ex)

        End Try
    End Sub

    Private Sub imgbtnFPS_Pause_Click(sender As Object, e As EventArgs) Handles imgbtnFPS_Pause.Click
        imgbtnFPS_Pause.Visible = False
        imgbtnFPS_Play.Visible = True
    End Sub

    Private Sub imgbtnFPV_Setting_Click(sender As Object, e As EventArgs) Handles imgbtnFPV_Setting.Click
        frmSettings.Show()
    End Sub

    Private Sub imgbtnFPS_VolumeDown_Click(sender As Object, e As EventArgs) Handles imgbtnFPS_VolumeDown.Click
        'Reduce/low Volume
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
    End Sub

    Private Sub imgbtnFPS_VolumeUp_Click(sender As Object, e As EventArgs) Handles imgbtnFPS_VolumeUp.Click
        'Add Volume
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
    End Sub
End Class

