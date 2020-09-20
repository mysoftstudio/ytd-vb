'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmHelp
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

    Private Sub btnAboutFH_Click(sender As Object, e As EventArgs) Handles btnAboutFH.Click
        Me.Close()
        frmAbout.Show()
    End Sub

    Private Sub FeedbackFH_click(sender As Object, e As EventArgs) Handles btnMailUS_ContactFH.Click, btnFeedback_contactFH.Click
        Me.Close()
        frmFeedbacks.Show()
        Process.Start("http://www.mysoftstudio.ml/#contact")
    End Sub

    Private Sub btnMoreInfosFH_Click(sender As Object, e As EventArgs) Handles btnMoreInfosFH.Click
        Process.Start("http://www.mysoftstudio.ml")
    End Sub

    Private Sub btnCloseF_Click(sender As Object, e As EventArgs) Handles btnCloseF.Click
        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub lblMySoftStudio_linkFH_Click(sender As Object, e As EventArgs) Handles lblMySoftStudio_linkFH.Click
        Process.Start("http://www.mysoftstudio.ml")
    End Sub

    Private Sub MailAddres_Click(sender As Object, e As EventArgs) Handles MailTo_FH.Click
        Process.Start("http://www.mysoftstudio.ml/#contact")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Process.Start(Application.StartupPath & "\Help.html")
    End Sub

    Private Sub mshover_UI(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Dim fnt As Font

        fnt = Label1.Font

        Label1.Font = New Font(fnt.Name, 14)
        Label1.ForeColor = Color.FromArgb(0, 187, 125)

    End Sub

    Private Sub btnUpgradeTM_Click(sender As Object, e As EventArgs) Handles btnUpgradeTM.Click
        'Show form  premium 
        frmPremium.Show()
    End Sub

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Help Page
        WebBrowser1.Navigate(Application.StartupPath & "\Help.html")

        'set Start Position : 799; 565
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - 799, Screen.PrimaryScreen.WorkingArea.Height - 565)

    End Sub
End Class

