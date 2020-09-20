'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmStats

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

    '#####################################--------******-----------End of Change  the Position of the Application ------------*******--------------##############################
    '    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================

    '#####################################-------------------To Launch other Forms when clicked Ex. btnDownload = frmDoenload display in Panel (pnlDisplay)----------------------------------------##############################


    Private Sub btnDownloadStatsFS_Click(sender As Object, e As EventArgs) Handles btnDownloadStatsFS.Click

        'Display Form into Display Panel
        Dim frm As frmStats_DownloadStats = New frmStats_DownloadStats
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.WindowState = FormWindowState.Maximized
        pnlDisplayFS.Controls.Add(frm)
        frm.Show()

        'Show Seperator And Render the other button iddle Line color White
        If sepDownStatusFS.Visible = False Then
            sepDownStatusFS.Visible = True
        End If
        If sepSystemStatusFS.Visible = True Then
            sepSystemStatusFS.Visible = False
        End If
    End Sub

    Private Sub btnSystemStatsFS_Click(sender As Object, e As EventArgs) Handles btnSystemStatsFS.Click
        'Display Form into Display Panel// System Status
        Dim frm As frmStats_SystemStats = New frmStats_SystemStats
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.WindowState = FormWindowState.Maximized
        pnlDisplayFS.Controls.Add(frm)
        frm.Show()

        'Show Seperator and Render the other button iddle Line color White
        If sepSystemStatusFS.Visible = False Then
            sepSystemStatusFS.Visible = True
        End If
        If sepDownStatusFS.Visible = True Then
            sepDownStatusFS.Visible = False
        End If
    End Sub
    '#####################################--------******-----------End of Launch other Forms when clicked Ex. btnDownload = frmDoenload display in Panel (pnlDisplay) ------------*******--------------##############################
    '
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '#####################################-------------------Common utilities Used like : close, mininzed----------------------------------------##############################
    Private Sub btnCloseTM_Click_1(sender As Object, e As EventArgs) Handles btnCloseTM.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub btnUpgradeTM_Click(sender As Object, e As EventArgs) Handles btnUpgradeTM.Click
        'Show Premium Form
        frmPremium.Show()
    End Sub

    '#####################################--------******-----------End Of Common utilities Used like : close, mininzed------------*******--------------##############################


    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    ''' <summary>
    ''' As Form Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set Start Position : '665; 402
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - 665, Screen.PrimaryScreen.WorkingArea.Height - 402)



        'Display Form into Display Panel //Panel Download
        Dim frm As frmStats_DownloadStats = New frmStats_DownloadStats
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.WindowState = FormWindowState.Maximized
        pnlDisplayFS.Controls.Add(frm)
        frm.Show()
        'Show Seperator if not shown
        If sepDownStatusFS.Visible = False Then
            sepDownStatusFS.Visible = True
        End If
    End Sub
    '
    'END FORM LOAD
    '
End Class

