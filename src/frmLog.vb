'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com
Public Class frmLog
    '#####################################-------------------To Change  the Position of the Application ----------------------------------------##############################
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

    Private Sub frmLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set Start Position : '570; 448
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - 570, Screen.PrimaryScreen.WorkingArea.Height - 448)

        'Load Log File
        Dim LogReader As String
        LogReader = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Log.txt")
        txtLogFile_varFL.Text = LogReader

        'Take Current Log
        txtLog.Text = My.Settings.ui_log
        txtLog.Text = txtLogFile_varFL.Text + vbNewLine + txtLog.Text
        'try Save
        Dim path As String = Application.StartupPath & "\Log.txt"
        System.IO.File.WriteAllText(path, txtLog.Text)


    End Sub

    Private Sub btnRefreshFL_Click(sender As Object, e As EventArgs) Handles btnRefreshFL.Click
        'Take Current Log
        txtLog.Text = My.Settings.ui_log
        txtLog.Text = txtLogFile_varFL.Text + vbNewLine + txtLog.Text

        'Load Log File
        Dim LogReader As String
        LogReader = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Log.txt")
        txtLogFile_varFL.Text = LogReader
    End Sub

    Private Sub btnSaveFL_Click(sender As Object, e As EventArgs) Handles btnSaveFL.Click

        'try Save
        Dim path As String = Application.StartupPath & "\Log.txt"
        System.IO.File.WriteAllText(path, txtLog.Text)
        'Load History
    End Sub

    Private Sub txtLog_TextChanged(sender As Object, e As EventArgs) Handles txtLog.TextChanged

    End Sub

    Private Sub btnUpgradeTM_Click(sender As Object, e As EventArgs) Handles btnUpgradeTM.Click
        'Show Premium Form
        frmPremium.Show()
    End Sub

    '#####################################--------******-----------End of Change  the Position of the Application ------------*******--------------##############################
    '    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================

    Private Sub btnCloseFL_Click(sender As Object, e As EventArgs) Handles btnCloseFL.Click
        Me.Close()
        frmMain.Show()

    End Sub
End Class
