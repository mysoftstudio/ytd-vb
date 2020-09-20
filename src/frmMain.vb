' <summary>
'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com
' </summary>

Public Class frmMain

    'Variable to Change Sound //
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load frmUser/ Feedbacks
        If My.Settings.ui_feedbacks = True Then
            frmUser.Show()
        Else
            'Do Nothing
        End If

        'frmMain Load
        My.Settings.lblVidName_varFTMD = My.Settings.ui_ftmd_lblVidName_varFTMD
        My.Settings.lblVidFormat_varFTMD = My.Settings.ui_ftmd_lblVidFormat_varFTMD
        My.Settings.lblVidSize_varFTMD = My.Settings.ui_ftmd_lblVidSize_varFTMD

        'Display UserName/E-Mail / HostName 
        lblHostName.Text = My.Computer.Name
        pnlHomeDisplay.Visible = True
        'Display Color Transition
        '##########' Top (Text Welcome)
        If pgbColorWelcomeTP.Value = 0 Then
            timDisplayColorWelcomeTP.Start()
        ElseIf pgbColorWelcomeTP.Value = 100 Then
            timDisplayColorWelcomeTP.Start()
        End If

        'UI switch on / off
        SwitchHomeStatus.Value = My.Settings.switchHomeTutoMain

        'Display Color Transition
        '##########' Top and Main Menu
        If pgbColorTP_MM.Value = 0 Then
            timDisplayColoTP_MM.Start()
        ElseIf pgbColorTP_MM.Value = 100 Then
            timDisplayColoTP_MM.Start()
        End If

        'Display Timer Interval bzw. Color Transition TP and MM
        timDisplayColoTP_MM.Interval = 1
        pgbColorTP_MM.Increment(10)


        If My.Settings.switchHomeTutoFSG = True Then
            pnlDisplay.Visible = False
            pnlHomeDisplay.Visible = True
        Else
            'Display Form into Display Panel//Top Display Download Progress or Selected Index
            Dim frmTop As frmTopMenu_Download = New frmTopMenu_Download
            frmTop.TopLevel = False
            frmTop.FormBorderStyle = FormBorderStyle.None
            frmTop.WindowState = FormWindowState.Maximized
            pnlTop.Controls.Add(frmTop)
            frmTop.TimerUI.Start()
            frmTop.Show()

            'Display Form into Display Panel
            Dim frm As frmDownload = New frmDownload
            frm.TopLevel = False
            frm.FormBorderStyle = FormBorderStyle.None
            frm.WindowState = FormWindowState.Maximized
            pnlDisplay.Controls.Add(frm)
            frm.Show()
            pnlDisplay.Visible = True
            pnlHomeDisplay.Visible = False
        End If
    End Sub
    '

    'END FORM LOAD
    '
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================

    '#####################################-------------------To Change  the Position of the Application ----------------------------------------##############################
    Dim x, y As Integer
    Dim newpoint As New Point
    Private Sub Move_Mouse_axis(sender As Object, e As MouseEventArgs) Handles pnlTopMenu.MouseDown, pnlMainMenu.MouseDown, pnlDisplay.MouseDown, pnlHomeDisplay.MouseDown
        'Assign axis
        x = Control.MousePosition.X = Me.Location.X
        y = Control.MousePosition.Y = Me.Location.Y
    End Sub

    Private Sub Move_Mouse(sender As Object, e As MouseEventArgs) Handles pnlTopMenu.MouseMove, pnlMainMenu.MouseMove, pnlDisplay.MouseMove, pnlHomeDisplay.MouseMove
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
    Private Sub Move_Mouse_axisA(sender As Object, e As MouseEventArgs) Handles pnlDisplay.MouseDown
        'Assign axis
        x = Control.MousePosition.X = Me.Location.X
        y = Control.MousePosition.Y = Me.Location.Y
    End Sub

    Private Sub Move_MouseC(sender As Object, e As MouseEventArgs) Handles pnlDisplay.MouseMove
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
    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownloadMM.Click, picTutorialImgSMg2.Click, picTutorialImgSMg5.Click
        Dim frmTop As frmTopMenu_Download = New frmTopMenu_Download
        frmTop.TopLevel = False
        frmTop.FormBorderStyle = FormBorderStyle.None
        frmTop.WindowState = FormWindowState.Maximized
        pnlTop.Controls.Add(frmTop)
        frmTop.TimerUI.Start()
        frmTop.Show()

        'change Value of Top, without a var of Current Chosed Form

        'Cancel Or Change Current Available Panel
        pnlHomeDisplay.Visible = False
        pnlDisplay.Visible = True

        'Display Form into Display Panel
        Dim frm As frmDownload = New frmDownload
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.WindowState = FormWindowState.Maximized
        pnlDisplay.Controls.Add(frm)
        frm.Show()

        'Check Or Open Frm Premuim
        If My.Settings.ui_premiumfeatures = True Then
            frmNotify_PreniumPlaylist.Show()
        End If
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreviewMM.Click, picTutorialImgSMg3.Click

        'Display Form into Display Panel//Top Display Progress or Selected Index
        Dim frmTop As frmTopMenu_Preview = New frmTopMenu_Preview
        frmTop.TopLevel = False
        frmTop.FormBorderStyle = FormBorderStyle.None
        frmTop.WindowState = FormWindowState.Maximized
        pnlTop.Controls.Add(frmTop)
        frmTop.Show()

        'Cancel Or Change Current Available Panel
        pnlHomeDisplay.Visible = False
        pnlDisplay.Visible = True

        'Display Form into Display Panel
        Dim frm As frmPreview = New frmPreview
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.WindowState = FormWindowState.Maximized
        pnlDisplay.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnThumbnails_Click(sender As Object, e As EventArgs) Handles btnThumbnailsMM.Click


        'Display  Form into Display Panel// Top
        Dim frmTop As frmTopMenu_Thumbnails = New frmTopMenu_Thumbnails
        frmTop.TopLevel = False
        frmTop.FormBorderStyle = FormBorderStyle.None
        frmTop.WindowState = FormWindowState.Maximized
        pnlTop.Controls.Add(frmTop)
        frmTop.Show()

        'Cancel Or Change Current Available Panel
        pnlHomeDisplay.Visible = False
        pnlDisplay.Visible = True

        'Display Form into Display Panel
        Dim frm As frmThumbnails = New frmThumbnails
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.WindowState = FormWindowState.Maximized
        pnlDisplay.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnShare_Click(sender As Object, e As EventArgs) Handles btnShareMM.Click, picTutorialImgSM6.Click, picTutorialImgSM5.Click
        'Check Or Open Frm Premuim
        If My.Settings.ui_premiumfeatures = True Then
            frmNotify_PremiumTumb_Share.Show()
        End If

        'Display  Form into Display Panel// Top
        Dim frmTop As frmTopMenu_Share = New frmTopMenu_Share
        frmTop.TopLevel = False
        frmTop.FormBorderStyle = FormBorderStyle.None
        frmTop.WindowState = FormWindowState.Maximized
        pnlTop.Controls.Add(frmTop)
        frmTop.Show()

        'Cancel Or Change Current Available Panel
        pnlHomeDisplay.Visible = False
        pnlDisplay.Visible = True

        '        Display Form into Display Panel
        Dim frm As frmShare = New frmShare
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.WindowState = FormWindowState.Maximized
        pnlDisplay.Controls.Add(frm)
        frm.Show()
    End Sub
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistoryMM.Click, picTutorialImgSM2.Click
        'Display Form into Display Panel//Top Display Download Progress or Selected Index
        Dim frmTop As frmTopMenu_Download = New frmTopMenu_Download
        frmTop.TopLevel = False
        frmTop.FormBorderStyle = FormBorderStyle.None
        frmTop.WindowState = FormWindowState.Maximized
        pnlTop.Controls.Add(frmTop)
        frmTop.Show()

        'Cancel Or Change Current Available Panel
        pnlHomeDisplay.Visible = False
        pnlDisplay.Visible = True

        'Display Form into Display Panel
        Dim frm As frmHistory = New frmHistory
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.WindowState = FormWindowState.Maximized
        pnlDisplay.Controls.Add(frm)
        frm.Show()
    End Sub
    Private Sub btnPlayVid_Click(sender As Object, e As EventArgs) Handles btnPlayVidMM.Click
        'Check Or Open Frm Premuim
        If My.Settings.ui_premiumfeatures = True Then
            frmNotify_PremiumPlay.Show()
        End If


        'Display  Form into Display Panel// Top
        Dim frmTop As frmTopMenu_Play = New frmTopMenu_Play
        frmTop.TopLevel = False
        frmTop.FormBorderStyle = FormBorderStyle.None
        frmTop.WindowState = FormWindowState.Maximized
        pnlTop.Controls.Add(frmTop)
        frmTop.Show()

        'Cancel Or Change Current Available Panel
        pnlHomeDisplay.Visible = False
        pnlDisplay.Visible = True
        pnlDisplay.Controls.Clear()
        'Display Form into Display Panel
        Dim frm1 As New frmPlay
        frm1.TopLevel = False
        frm1.FormBorderStyle = FormBorderStyle.None
        frm1.WindowState = FormWindowState.Maximized

        pnlDisplay.Controls.Add(frm1)
        frm1.Show()
    End Sub
    Private Sub btnHomeMM_Click(sender As Object, e As EventArgs) Handles btnHomeMM.Click

        'Check if switcher is true or false to activate /disactivate Home Display
        'UI switch on / off
        SwitchHomeStatus.Value = My.Settings.switchHomeTutoMain

        If My.Settings.switchHomeTutoFSG = True And My.Settings.switchHomeTutoMain = True Then
            pnlDisplay.Visible = False
            pnlHomeDisplay.Visible = True
        Else

            pnlDisplay.Visible = True
            pnlHomeDisplay.Visible = False
        End If

        'To Display Text If Activate or Not

        If SwitchHomeStatus.Value = False Then
            ToolTipForm.ToolTipIcon = ToolTipIcon.Warning
            ToolTipForm.ToolTipTitle = "Please Re-activate the Switch Home Menu"
            ToolTipForm.SetToolTip(Me.btnHomeMM, "Please go On  Setting Menu >> 'Home' >>")
        Else
            ToolTipForm.SetToolTip(Me.btnHomeMM, "Home Menu")
        End If
    End Sub

    '#####################################--------******-----------End of Launch other Forms when clicked Ex. btnDownload = frmDoenload display in Panel (pnlDisplay) ------------*******--------------##############################
    '
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================

    '#####################################-------------------To Set Different Color Transition + Variables + Timers + Pgbs----------------------------------------##############################
    ''' 
    Private Sub timDisplayColorWelcomeTP_Tick(sender As Object, e As EventArgs) Handles timDisplayColorWelcomeTP.Tick
        'Welcome Menu
        'Display transitional color in the different Labels
        pgbColorWelcomeTP.Increment(1)
        trsDisplayColorWelcomeTP.ProgessValue = pgbColorWelcomeTP.Value
        lblWelcomeTP.ForeColor = trsDisplayColorWelcomeTP.Value
        lblWelcomeTP1.ForeColor = trsDisplayColorWelcomeTP.Value
        lblWelcomeTP2.ForeColor = trsDisplayColorWelcomeTP.Value

        'Check If Finish and if it´'s the case then keep restarting till new Command
        If pgbColorWelcomeTP.Value = 100 Then
            pgbColorWelcomeTP.Value = 0
        ElseIf pgbColorWelcomeTP.Value = 50 Then
            trsDisplayColorWelcomeTP.Color1 = Color.FromArgb(0, 187, 125)
            trsDisplayColorWelcomeTP.Color2 = Color.White
        End If
    End Sub

    Private Sub timDisplayColoTP_MM_Tick(sender As Object, e As EventArgs) Handles timDisplayColoTP_MM.Tick
        pgbColorTP_MM.Increment(1)
        trsDisplayColoTP_MM.ProgessValue = pgbColorTP_MM.Value
        'MM = Main Menu
        pnlMainMenu.GradientTopLeft = trsDisplayColoTP_MM.Value
        pnlMainMenu.GradientTopRight = trsDisplayColoTP_MM.Value
        pnlMainMenu.GradientBottomLeft = trsDisplayColoTP_MM.Value
        pnlMainMenu.GradientBottomRight = trsDisplayColoTP_MM.Value

        btnVersionInfosMM.BackColor = trsDisplayColoTP_MM.Value

        'TP = Top
        pnlTop.GradientTopLeft = trsDisplayColoTP_MM.Value
        pnlTop.GradientTopRight = trsDisplayColoTP_MM.Value
        pnlTop.GradientBottomLeft = trsDisplayColoTP_MM.Value
        pnlTop.GradientBottomRight = trsDisplayColoTP_MM.Value

        'Use generated Color from transition as Backcolor
        If pgbColorTP_MM.Value <= 100 Then
            pnlTop.BackColor = pnlTop.GradientTopRight
            pnlMainMenu.BackColor = pnlMainMenu.GradientTopRight

            'Enable Backcolor and give it to Button (MainMenu)
            btnDownloadMM.BackColor = trsDisplayColoTP_MM.Value
            btnPreviewMM.BackColor = trsDisplayColoTP_MM.Value
            btnThumbnailsMM.BackColor = trsDisplayColoTP_MM.Value
            btnShareMM.BackColor = trsDisplayColoTP_MM.Value
            btnHistoryMM.BackColor = trsDisplayColoTP_MM.Value
            btnPlayVidMM.BackColor = trsDisplayColoTP_MM.Value
            btnVersionInfosMM.BackColor = trsDisplayColoTP_MM.Value

            'Enable Color and give it to Button as hover color
            btnDownloadMM.OnHovercolor = trsDisplayColoTP_MM.Value
            btnPreviewMM.OnHovercolor = trsDisplayColoTP_MM.Value
            btnThumbnailsMM.OnHovercolor = trsDisplayColoTP_MM.Value
            btnShareMM.OnHovercolor = trsDisplayColoTP_MM.Value
            btnHistoryMM.OnHovercolor = trsDisplayColoTP_MM.Value
            btnPlayVidMM.OnHovercolor = trsDisplayColoTP_MM.Value

        End If
        ' Stop and delete Progressbar Value + Timer
        If pgbColorTP_MM.Value = 100 Then
            timDisplayColoTP_MM.Stop()
            pgbColorTP_MM.Value = 0


            'Hovercolor = Button Hover Color
            Dim HoverColor As Color = Color.FromArgb(47, 87, 140)

            'Re-Place Button Hover Color As Default 
            btnDownloadMM.OnHovercolor = Color.FromArgb(47, 87, 140)
            btnPreviewMM.OnHovercolor = HoverColor
            btnThumbnailsMM.OnHovercolor = HoverColor
            btnShareMM.OnHovercolor = HoverColor
            btnHistoryMM.OnHovercolor = HoverColor
            btnPlayVidMM.OnHovercolor = HoverColor
        End If
    End Sub
    Private Sub lblWelcome_Hover(sender As Object, e As EventArgs) Handles lblWelcomeTP2.MouseHover, lblWelcomeTP1.MouseHover, lblWelcomeTP.MouseHover
        'Stop Timer and reset ForeColor
        timDisplayColorWelcomeTP.Stop()
        pgbColorWelcomeTP.Value = 0
        lblWelcomeTP.ForeColor = Color.White
        lblWelcomeTP1.ForeColor = Color.White
        lblWelcomeTP2.ForeColor = Color.White

        'Hide Slider Menu 
        If pnlSlideMenu.Visible = True Then
            pnlSlideMenu.Visible = False
            picSortUpSM.Visible = False
        End If
    End Sub

    '#####################################--------******-----------End OfTo Set Different Color Transition + Variables + Timers + Pgbs------------*******--------------##############################
    '
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================

    '#####################################-------------------Common utilities Used like : close, mininzed----------------------------------------##############################

    Private Sub btnMinimizedTM_Click(sender As Object, e As EventArgs) Handles btnMinimizedTM.Click
        'To Minimized Me
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub btnClosePaneTM_Click(sender As Object, e As EventArgs) Handles btnClosePaneTM.Click
        'To Hide and Get Icon Notyfication
        Me.Hide()
        NotifyIconFrmHide.Visible = True
    End Sub
    Private Sub NotifyIconFrmHide_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIconFrmHide.MouseDoubleClick
        'Show Application if Double clicked/ and checked if already open or not 
        '/* Setting
        If Application.OpenForms().OfType(Of frmSettings).Any Then
            frmSettings.Close()
            Me.Show()
        End If
    End Sub
    Private Sub btnSlideMenu_Click(sender As Object, e As EventArgs) Handles btnSlideMenuTM.Click
        'To Check if Menu is Already Slide or Not if it is the case then Close and vice versa
        If pnlSlideMenu.Visible = False Then
            pnlSlideMenu.Visible = True
            picSortUpSM.Visible = True
        Else
            pnlSlideMenu.Visible = False
            picSortUpSM.Visible = False
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCloseTM.Click
        'Check if Download is Downloading
        If My.Settings.gpgbDownloadProgressFTMD < 1 And Not 0 Then

            Dim result As Integer = MessageBox.Show("Are You Sure You Want to Stop Current Download ?" & vbNewLine & "Exiting Will stop all current Processes and Downloads.", "Exit Application", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                'Cose All Software
                Me.Close()
            End If
        Else
            'Cose All Software
            Me.Close()
        End If
    End Sub
    Private Sub SettingsSM_Click(sender As Object, e As EventArgs) Handles lblSettingsSM.Click, btnSettingsSM.Click
        frmSettings.Show()
    End Sub
    Private Sub StatsSM_Click(sender As Object, e As EventArgs) Handles lblStatsSM.Click, btnStatsSM.Click
        frmStats.Show()
    End Sub

    Private Sub UpdatesSM_Click(sender As Object, e As EventArgs) Handles lblUpdatesSM.Click, btnCkUpdatesSM.Click
        frmUpdates.Show()
    End Sub

    Private Sub AboutSM_Click(sender As Object, e As EventArgs) Handles lblAboutSM.Click, btnAboutSM.Click
        Me.Hide()
        frmAbout.Show()
        NotifyIconFrmHide.Visible = True
    End Sub

    Private Sub HelpSM_Click(sender As Object, e As EventArgs) Handles btnHelpSM.Click, lblHelpSM.Click
        frmHelp.Show()
    End Sub

    Private Sub LogFile_Click(sender As Object, e As EventArgs) Handles lblLogSM.Click, btnLogSM.Click
        frmLog.Show()
    End Sub

    Private Sub btnGetPremiumDM_Click(sender As Object, e As EventArgs) Handles btnGetPremiumDM.Click, btnUpgradeTM.Click
        'Show Premium Form
        frmPremium.Show()
    End Sub
    Private Sub FeedbackSM_Click(sender As Object, e As EventArgs) Handles btnFeedbackSM.Click, lblFeedbackSM.Click
        'Activate Feedbacks Secretly
        My.Settings.ui_feedbacks = True
        frmFeedbacks.Show()
        NotifyIconFrmHide.Visible = True
    End Sub
    Private Sub SwitchHomeStatus_Click(sender As Object, e As EventArgs) Handles SwitchHomeStatus.Click
        'UI switch on / off
        SwitchHomeStatus.Value = My.Settings.switchHomeTutoMain
        My.Settings.switchHomeTutoMain = SwitchHomeStatus.Value
        If My.Settings.switchHomeTutoMain = False Then
            My.Settings.switchHomeTutoFSG = False
            My.Settings.Save()
        Else
            My.Settings.switchHomeTutoFSG = True

            My.Settings.Save()
        End If


        'Display Form into Display Panel//Top Display Download Progress or Selected Index
        Dim frmTop As frmTopMenu_Download = New frmTopMenu_Download
        frmTop.TopLevel = False
        frmTop.FormBorderStyle = FormBorderStyle.None
        frmTop.WindowState = FormWindowState.Maximized
        pnlTop.Controls.Add(frmTop)
        frmTop.Show()

        'change Value of Top, without a var of Current Chosed Form

        'Cancel Or Change Current Available Panel
        pnlHomeDisplay.Visible = False
        pnlDisplay.Visible = True

        'Display Form into Display Panel
        Dim frm As frmDownload = New frmDownload
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.WindowState = FormWindowState.Maximized
        pnlDisplay.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub picTutorialImgSMg1_Click(sender As Object, e As EventArgs) Handles picTutorialImgSMg1.Click
        Process.Start("http://www.youtube.com")
    End Sub

    Private Sub YouTube_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Process.Start("http://www.youtube.com")
    End Sub
    Private Sub btnVersionInfosMM_Click(sender As Object, e As EventArgs) Handles btnVersionInfosMM.Click
        'Show About
        frmAbout.Show()
    End Sub

    Private Sub btnUserTM_Click(sender As Object, e As EventArgs) Handles btnUserTM.Click, btnThemeTM.Click
        'Show that it is unaviable
        NotifyIcon.BalloonTipText = "Sorry this fonction is not available in this Version"
        NotifyIcon.ShowBalloonTip(0)
    End Sub
    Private Sub imgInfos_Click(sender As Object, e As EventArgs) Handles imgInfos.Click, imgInfosPremium.Click
        'Show frmHelp
        frmHelp.Show()
    End Sub

    Private Sub imgAvatarMM_Click(sender As Object, e As EventArgs) Handles imgAvatarMM.Click
        'Activate Feedbacks Secretly
        My.Settings.ui_feedbacks = True
        My.Settings.ui_premiumfeatures = True
    End Sub

    Private Sub btnGiftTM_Click(sender As Object, e As EventArgs) Handles btnGiftTM.Click
        'komm Gleich
        'Activate Feedbacks Secretly
        My.Settings.ui_feedbacks = True
        My.Settings.ui_premiumfeatures = True
    End Sub

    Private Sub HideSlideMenu_OnHover(sender As Object, e As EventArgs) Handles pnlMainMenu.MouseHover, lblHostName.MouseHover, imgAvatarMM.MouseHover, btnVersionInfosMM.MouseHover, btnThumbnailsMM.MouseHover, btnShareMM.MouseHover, btnPreviewMM.MouseHover, btnPlayVidMM.MouseHover, btnHomeMM.MouseHover, btnHistoryMM.MouseHover, btnDownloadMM.MouseHover, pnlDisplay.MouseHover, pnlHomeDisplay.MouseHover, grpPremiumHM.MouseHover, grpTutorialHM.MouseHover
        'Hide Slider Menu if It is Visible
        If pnlSlideMenu.Visible = True Then
            pnlSlideMenu.Visible = False
            picSortUpSM.Visible = False
        End If
    End Sub
    '#####################################--------******-----------End Of Common utilities Used like : close, mininzed------------*******--------------##############################
End Class


'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com
