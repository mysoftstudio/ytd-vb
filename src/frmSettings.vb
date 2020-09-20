'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmSettings
    Private Sub btnCloseTM_Click(sender As Object, e As EventArgs) Handles btnCloseTM.Click
        Me.Close()
        frmMain.Show()
    End Sub
    '#####################################-------------------To Change  the Position of the Application ----------------------------------------##############################
    Dim x, y As Integer
    Dim newpoint As New Point
    Private Sub Move_Mouse_axis(sender As Object, e As MouseEventArgs) Handles pnlTopMenu.MouseDown, pnlMainMenu.MouseDown, pnlDisplayHM.MouseDown
        'Assign axis
        x = Control.MousePosition.X = Me.Location.X
        y = Control.MousePosition.Y = Me.Location.Y
    End Sub

    Private Sub Move_Mouse(sender As Object, e As MouseEventArgs) Handles pnlTopMenu.MouseMove, pnlMainMenu.MouseMove, pnlDisplayHM.MouseMove
        'Use axis to move main
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
    '----------------------------------------Change For Display Center-------------------------------------
    Private Sub Move_Mouse_axisA(sender As Object, e As MouseEventArgs) Handles pnlDisplayHM.MouseDown
        'Assign axis
        x = Control.MousePosition.X = Me.Location.X
        y = Control.MousePosition.Y = Me.Location.Y
    End Sub

    Private Sub Move_MouseC(sender As Object, e As MouseEventArgs) Handles pnlDisplayHM.MouseMove
        'Use axis to move main
        If e.Button = Windows.Forms.MouseButtons.Middle Then
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
    Private Sub btnGeneralMM_Click(sender As Object, e As EventArgs) Handles btnGeneralMM.Click
        'Display Form into Display Panel
        Dim frm As frmSetting_General = New frmSetting_General
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.WindowState = FormWindowState.Maximized
        pnlDisplayHM.Controls.Add(frm)
        frm.Show()
    End Sub
    Private Sub btnOutputMM_Click(sender As Object, e As EventArgs) Handles btnOutputMM.Click
        'Display Form into Display Panel
        Dim frm As frmSetting_Output = New frmSetting_Output
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.WindowState = FormWindowState.Maximized
        pnlDisplayHM.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnAdvancedMM_Click(sender As Object, e As EventArgs) Handles btnAdvancedMM.Click
        'Display Form into Display Panel
        Dim frm As frmSetting_Advanced = New frmSetting_Advanced
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.WindowState = FormWindowState.Maximized
        pnlDisplayHM.Controls.Add(frm)
        frm.Show()

    End Sub



    Private Sub btnFileMM_Click(sender As Object, e As EventArgs) Handles btnFileMM.Click
        'Display Form into Display Panel
        Dim frm As frmSetting_File = New frmSetting_File
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.WindowState = FormWindowState.Maximized
        pnlDisplayHM.Controls.Add(frm)
        frm.Show()
    End Sub
    '#####################################--------******-----------End of Launch other Forms when clicked Ex. btnDownload = frmDoenload display in Panel (pnlDisplay) ------------*******--------------##############################
    '
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    ''' <summary>
    ''' As Form Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set Start Position : '681; 441
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - 680, Screen.PrimaryScreen.WorkingArea.Height - 442)
    End Sub
    '
    'END FORM LOAD
    '
End Class

