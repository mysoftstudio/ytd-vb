'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmUpdates

    Dim LogReader As String

    '    '#####################################-------------------To Change  the Position of the Application ----------------------------------------##############################
    Dim x, y As Integer
    Dim newpoint As New Point

    Private Sub Move_Mouse_axis(sender As Object, e As MouseEventArgs) Handles pnlTopMenu.MouseDown
        'Assign axis
        x = Control.MousePosition.X = Me.Location.X
        y = Control.MousePosition.Y = Me.Location.Y
    End Sub

    Private Sub Move_Mouse(sender As Object, e As MouseEventArgs) Handles pnlTopMenu.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    '#####################################--------******-----------End of Change  the Position of the Application ------------*******--------------##############################
    '    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================


    Private Sub btnCloseTM_Click(sender As Object, e As EventArgs) Handles btnCloseTM.Click
        Me.Close()
        frmMain.Show()
    End Sub


    Private Sub btnCheckUpdates_varFU_Click(sender As Object, e As EventArgs) Handles btnCheckUpdates_varFU.Click
        'Load Process
        pgbChecking_varFU.Visible = True

        'Msgbox (Error)
        MsgBox("Unable to Connect to  Server, please try to check for updates in our website." + vbNewLine + "If You wish you can download the recent Software, but that may be the same Version. ", MsgBoxStyle.Information, "Error Connection With Server")
        NotifyIconDownFinish.BalloonTipTitle = "Updating MySoft YouTube Downloader"
        NotifyIconDownFinish.BalloonTipText = "Unable to connect to server, please try to update manually"
        NotifyIconDownFinish.BalloonTipIcon = ToolTipIcon.Info
        NotifyIconDownFinish.ShowBalloonTip(0)
        'Load Website
        Process.Start("http://www.mysoftstudio.ml/2017/10/mysoft-youtube-downloader.html")


        'Visibility of other ...
        btnCheckUpdates_varFU.Visible = False
        btnUpdate_varFU.Visible = True
        pgbChecking_varFU.Visible = False
        picNewVersion_VarFU.Visible = True

    End Sub

    Private Sub btnUpdate_varFU_Click(sender As Object, e As EventArgs) Handles btnUpdate_varFU.Click

        wbbDownloadNewVersion_varFU.Navigate("https://www.dropbox.com/sh/3388k1ph9vldijj/AABqbglszWV330uxBJ4lYaSDa?dl=1")
        '//////Update Changes
        pgbChecking_varFU.Visible = True
        NotifyIconDownFinish.BalloonTipTitle = "Updating MySoft YouTube Downloader"
        NotifyIconDownFinish.BalloonTipText = "Trying to Update Software, please check your Download File"
        NotifyIconDownFinish.BalloonTipIcon = ToolTipIcon.Info
        NotifyIconDownFinish.ShowBalloonTip(0)

    End Sub

    ''' <summary>
    ''' As Form Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set Start Position
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - 665, Screen.PrimaryScreen.WorkingArea.Height - 402)

        NotifyIconDownFinish.BalloonTipTitle = "Updating MySoft YouTube Downloader"
        NotifyIconDownFinish.BalloonTipText = "Unable to connect to server, please try to update manually"
        NotifyIconDownFinish.BalloonTipIcon = ToolTipIcon.Info
        NotifyIconDownFinish.ShowBalloonTip(0)
        btnCheckUpdates_varFU.Visible = False
        btnUpdate_varFU.Visible = True


        btnUpdate_varFU.Visible = False
        btnCheckUpdates_varFU.Visible = True

    End Sub
    '
    'END FORM LOAD
    '
End Class

