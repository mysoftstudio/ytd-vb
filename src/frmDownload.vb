'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Imports YoutubeExtractor
Imports System.Net
Public Class frmDownload
    Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Dim frmTMD As New frmTopMenu_Download()
    Dim frmTop As frmTopMenu_Download = New frmTopMenu_Download
    Dim frmMain As New frmMain()


    'Declaring our first Variables of different Forms to open
    'Variables Package
    Dim wc As WebClient
    Dim strArrayLinks(), strArrayExts(), strDefTitle, strFullPath, numberOfCharacters As String


    Private Sub frmDownload_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Result - Completed Task//
        If My.Computer.Clipboard.ContainsText Then
            picMarkFD_Copie.Visible = True
        Else
        End If
        If txtURL_varFD.Text.Length >= 1 Then
            picMarkFD_Paste.Visible = True
        Else
        End If




        'Hide Download Features if Download Link ist not Request//
        Dim NoText = "Not Available"
        lblVidFormat_varFD.Text = NoText
        lblVidName_varFD.Text = NoText
        lblVidPlaylist_varFD.Text = NoText
        lblVidSize_varFD.Text = NoText
        lblVidUrl_varFD.Text = NoText
        Dim FontColorRed As Color = Color.Tomato
        lblVidFormat_varFD.ForeColor = FontColorRed
        lblVidName_varFD.ForeColor = FontColorRed
        lblVidPlaylist_varFD.ForeColor = FontColorRed
        lblVidSize_varFD.ForeColor = FontColorRed
        lblVidUrl_varFD.ForeColor = FontColorRed

        ' Check is Auto paste URl is checked if it is the case paste automatically
        If My.Settings.ckbFSA_PasteURLs = True Then
            txtURL_varFD.Text = ""
            txtURL_varFD.Text = My.Computer.Clipboard.GetText()
        Else
            'Do nothing
        End If

    End Sub

    Private Sub imgbtnPasteFD_Click(sender As Object, e As EventArgs) Handles imgbtnPasteFD.Click
        'Auto Url Paste// Check Settings
        txtURL_varFD.Text = My.Computer.Clipboard.GetText()
        'Komm Gleich
    End Sub

    Private Sub frmDownload_click(sender As Object, e As EventArgs) Handles MyBase.Click
        'Auto Url Paste// Check Settings
        txtURL_varFD.Text = My.Computer.Clipboard.GetText()
        'Komm Gleich
    End Sub

    Private Sub llblClear_varFD_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblClear_varFD.LinkClicked
        Clipboard.Clear()
        txtURL_varFD.Text = ""
    End Sub

    Private Sub llblActualise_varFD_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblActualise_varFD.LinkClicked
        'Actualise link//
        txtURL_varFD.Text = My.Computer.Clipboard.GetText()

    End Sub

    Private Sub llblPaste_varFD_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblPaste_varFD.LinkClicked
        'Paste link//
        txtURL_varFD.Text = My.Computer.Clipboard.GetText()
    End Sub

    Private Sub btnMainInfoFD_Click(sender As Object, e As EventArgs) Handles btnMainInfoFD.Click
        frmHelp.Show()
    End Sub

    Private Sub cbbQuality_strFD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbQuality_strFD.SelectedIndexChanged
        'Change Quality according to setiings
        If My.Settings.dpdVidQualityFSG = 1 Then
            cbbQuality_strFD.SelectedIndex = 5
        ElseIf My.Settings.dpdVidQualityFSG = 2 Then
            cbbQuality_strFD.SelectedIndex = 0
        ElseIf My.Settings.dpdVidQualityFSG = 3 Then
            cbbQuality_strFD.SelectedIndex = 12
        ElseIf My.Settings.dpdVidQualityFSG = 4 Then
            cbbQuality_strFD.SelectedIndex = 1
        ElseIf My.Settings.dpdVidQualityFSG = 5 Then
            cbbQuality_strFD.SelectedIndex = 3
        ElseIf My.Settings.dpdVidQualityFSG = 6 Then
            cbbQuality_strFD.SelectedIndex = 4
        End If
    End Sub

    Private Sub cbbFormat_strFD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbFormat_strFD.SelectedIndexChanged
        'Change Format according to setting
        If My.Settings.dpdVidFormatFSG = 0 Then
            cbbFormat_strFD.SelectedIndex = 0
        ElseIf My.Settings.dpdVidFormatFSG = 1 Then
            cbbFormat_strFD.SelectedIndex = 3
        ElseIf My.Settings.dpdVidFormatFSG = 2 Then
            cbbFormat_strFD.SelectedIndex = 1
        End If
    End Sub

    Private Sub auto_actualise_format_frmDHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover, gpbVidUrlFD.MouseHover, gpbVidInfosFD.MouseHover
        If gpbVidInfosFD.Visible = True Then '//do a value to change if not would crash!!!
            'Check (Setting to String) and change current dpd value (My.setting) // Format 
            If My.Settings.dpdVidFormatFSG = 0 Then
                cbbFormat_strFD.SelectedIndex = 0
            ElseIf My.Settings.dpdVidFormatFSG = 1 Then
                cbbFormat_strFD.SelectedIndex = 3
            ElseIf My.Settings.dpdVidFormatFSG = 2 Then
                cbbFormat_strFD.SelectedIndex = 1
            End If

            'Change Quality according to setiings // quality
            If My.Settings.dpdVidQualityFSG = 0 Then
                My.Settings.dpdVidQualityFSG = 2
                cbbQuality_strFD.SelectedIndex = 0

            End If
            If My.Settings.dpdVidQualityFSG = 1 Then
                cbbQuality_strFD.SelectedIndex = 5
            ElseIf My.Settings.dpdVidQualityFSG = 2 Then
                cbbQuality_strFD.SelectedIndex = 0
            ElseIf My.Settings.dpdVidQualityFSG = 3 Then
                cbbQuality_strFD.SelectedIndex = 12
            ElseIf My.Settings.dpdVidQualityFSG = 4 Then
                cbbQuality_strFD.SelectedIndex = 1
            ElseIf My.Settings.dpdVidQualityFSG = 5 Then
                cbbQuality_strFD.SelectedIndex = 3
            ElseIf My.Settings.dpdVidQualityFSG = 6 Then
                cbbQuality_strFD.SelectedIndex = 4
            End If
        End If
    End Sub

    Private Sub imgbtnDownloadFD_Click(sender As Object, e As EventArgs) Handles imgbtnDownloadFD.Click





        frmTMD.lblCurrentStatus_varFTMD.ForeColor = Color.FromArgb(0, 187, 125) '// As Green
        frmTMD.lblCurrentStatus_varFTMD.Text = "Valid URL"
        frmMain.pnlTop.Controls.Clear()





    End Sub

    Private Sub btnDownloadFD_Click(sender As Object, e As EventArgs) Handles btnDownloadFD.Click
        'btn Download
        wc = New WebClient()
        AddHandler wc.DownloadProgressChanged, AddressOf DownloadProgress
        AddHandler wc.DownloadFileCompleted, AddressOf DownloadCompleted


        'Path
        If My.Settings.txtFileNameFSF = "" Then
            strFullPath = My.Settings.txtFilePathFSO & "\" & strDefTitle & strArrayExts(cbbFormat_strFD.SelectedIndex)
            wc.DownloadFileAsync(New Uri(strArrayLinks(cbbQuality_strFD.SelectedIndex)), strFullPath)
        Else
            strFullPath = My.Settings.txtFilePathFSO & "\" & My.Settings.txtFileNameFSF & strArrayExts(cbbFormat_strFD.SelectedIndex)
            wc.DownloadFileAsync(New Uri(strArrayLinks(cbbQuality_strFD.SelectedIndex)), strFullPath)
        End If
    End Sub
    Private Sub DownloadProgress(sender As Object, e As DownloadProgressChangedEventArgs)
        '//////Download Progress
        'Launch Progress bar
        My.Settings.gpgbDownloadProgressFTMD = e.ProgressPercentage
        My.Settings.lblProgressValueFTMD_var = String.Format("{0} MB's / {1} MB's", (e.BytesReceived / 1024D / 1024D).ToString("0.00"), (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00"))
        My.Settings.ui_ftmd_lblVidSize_varFTMD = String.Format("{0} MB", (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00"))
        My.Settings.ui_frm_varDownSize = String.Format("{0} MB", (e.BytesReceived / 1024D / 1024D).ToString("0.00"))

        'For UI Purpose
        If My.Settings.gpgbDownloadProgressFTMD = 1 Then
            My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Checking For Path..."
        ElseIf My.Settings.gpgbDownloadProgressFTMD = 2 Then
            My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Checking For Server..."
        ElseIf My.Settings.gpgbDownloadProgressFTMD = 3 Then
            My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Respond Accepted, Loading..."
        ElseIf My.Settings.gpgbDownloadProgressFTMD = 5 Then
            My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Setting Resolution..."
        ElseIf My.Settings.gpgbDownloadProgressFTMD = 6 Then
            My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Downloading..."
        ElseIf My.Settings.gpgbDownloadProgressFTMD = 97 Then
            My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Saving to Path... : " + My.Settings.txtFilePathFSO
        ElseIf My.Settings.gpgbDownloadProgressFTMD = 100 Then
            My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Download Sucessfully Completed"

        End If
        My.Settings.ui_log = Today.Now() + " : " + "Download Started..."

    End Sub
    Private Sub DownloadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs)
        '//////Download Completed
        NotifyIconDownFinish.BalloonTipText = "Please Check Your Video at " + My.Settings.txtFilePathFSO
        NotifyIconDownFinish.BalloonTipIcon = ToolTipIcon.Info
        NotifyIconDownFinish.ShowBalloonTip(0)

        '//set image Download Visible
        If My.Settings.lblCurrentStatus_varFTMD.Contains("Down") Then

            picMarkFD_Download.Visible = True

        Else

            picMarkFD_Download.Visible = False
        End If
#Disable Warning BC42025 ' Accès d’un membre partagé, d’un membre de constante, d’un membre enum ou d’un type imbriqué via une instance
        My.Settings.lblLastDownFTMD_var = Today.Now()
#Enable Warning BC42025 ' Accès d’un membre partagé, d’un membre de constante, d’un membre enum ou d’un type imbriqué via une instance

        'Add History
        Dim fr As frmHistory = New frmHistory
        Dim i As ListViewItem
        i = fr.ListViewHistory_varFH.Items.Add(My.Settings.lblLastDownFTMD_var) ' Date Time
        i.SubItems.Add("YouTube") ' Source 
        i.SubItems.Add(My.Settings.txtURL_varFD) ' Video URL 
        i.SubItems.Add(My.Settings.lblVidSize_varFTMD) ' Size
        i.SubItems.Add(My.Settings.lblVidFormat_varFTMD) ' Format
        i.SubItems.Add("Not Available") ' Quality
        i.SubItems.Add(My.Settings.ui_ftmd_lblVidName_varFTMD) ' Video Title
        i.SubItems.Add(My.Settings.txtFilePathFSO) ' Path

        Dim sauve As String = Application.StartupPath & "\History.txt"
        SauvegarderLesDonnées(fr.ListViewHistory_varFH, sauve)
        My.Settings.ui_log = Today.Now() + " : " + "Download Completed"



        'Try to Start video automatically
        '   Process.Start(My.Settings.txtFilePathFSO + "\" + My.Settings.txtFileNameFSF + My.Settings.lblVidFormat_varFTMD)
    End Sub
    Private Sub btnSettingFD_Click(sender As Object, e As EventArgs) Handles btnSettingFD.Click
        frmSettings.Show()
    End Sub

    Private Sub btnClearAll_FD_Click(sender As Object, e As EventArgs) Handles btnClearAll_FD.Click
        'Ask before Deleting
        Dim result As Integer = MessageBox.Show("Are You Sure You Want to Reset or Clear All Values ?" & vbNewLine & "Clearing all Values will reset all srings Ex. Reset Download Value.", "Clearing All Values", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            'Reclear all settings
            My.Settings.lblCurrentStatus_varFTMD = ""
            My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = ""
            My.Settings.ui_ftmd_lblLastDownFTMD_var = ""
            My.Settings.ui_ftmd_lblProgressValueFTMD_var = ""
            My.Settings.ui_ftmd_lblVidFormat_varFTMD = ""
            My.Settings.ui_ftmd_lblVidName_varFTMD = ""
            My.Settings.ui_ftmd_lblVidSize_varFTMD = ""
            My.Settings.gpgbDownloadProgressFTMD = 0
        End If
    End Sub

    Private Sub imgYouTubeBigFD_Click(sender As Object, e As EventArgs) Handles imgYouTubeBigFD.Click
        Process.Start("http://www.youtube.com")

    End Sub

    Private Sub txtURL_varFD_OnValueChanged(sender As Object, e As EventArgs) Handles txtURL_varFD.OnValueChanged

        'As Url Paste Check Variable
        If txtURL_varFD.Text.Contains("https://") OrElse txtURL_varFD.Text.Contains("youtu.be") OrElse txtURL_varFD.Text.Contains("youtube.com") Then
            'UI Change Text / Valid (to my settings ) 
            My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Valid URL"
            My.Settings.ui_log = Today.Now() + " : " + "Valid URL Please Request Download"
            My.Settings.txtURL_varFD = txtURL_varFD.Text

        Else
            If txtURL_varFD.Text = "" Then
            Else

                MsgBox("Invalid URL :" + txtURL_varFD.Text & vbNewLine & "Please Change URL, try a URl like" & vbNewLine & "https://www.youtube.com/watch?v=EKs1wxYP5Pc" + " OR " & vbNewLine & "http://youtu.be/EKs1wxYP5Pc" & vbNewLine & "Thanks For Your Comprehension | Thanks for choosing Us", MsgBoxStyle.Information, "Invalid URL")
                'UI Change Text / Invalid (to my settings )
                My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Invalid URL"
                My.Settings.ui_log = Today.Now() + " : " + "Invalid URL Please change URL"

            End If

        End If
        'Check URL For Premium Features 
        If txtURL_varFD.Text.Contains("list") Then
            frmNotify_PreniumPlaylist.Show()
            'Notify if it is from playlist
            lblVidPlaylist_varFD.Text = "Yes"
            lblVidPlaylist_varFD.ForeColor = Color.FromArgb(0, 187, 125)
        Else
            lblVidPlaylist_varFD.Text = "No"
            lblVidPlaylist_varFD.ForeColor = Color.Tomato
        End If
    End Sub

    Private Sub btnReqDownLinkFD_Click(sender As Object, e As EventArgs) Handles btnReqDownLinkFD.Click
        If txtURL_varFD.Text.Length <= 11 Then
            If txtURL_varFD.Text = "" Then
            Else
                MsgBox("Please Enter a Valid YouTube URL to Download it" & vbNewLine & "Ex. 'https://www.youtube.com/watch?v=Q4BotUUxj3k'", MsgBoxStyle.Exclamation, "Invalid URL - Please Change URL")
                'Change text to set to Invalid URL
                My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Please Change URL"

            End If


        Else
            If txtURL_varFD.Text.Contains("https://") Or txtURL_varFD.Text.Contains("youtu.be") Or txtURL_varFD.Text.Contains("youtube.com") = True Then
                'UI Change Text / Valid (to my settings ) 
                My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Valid URL"

                Dim vInfos As IEnumerable(Of VideoInfo)
                vInfos = DownloadUrlResolver.GetDownloadUrls(txtURL_varFD.Text, False)
                cbbFormat_strFD.Items.Clear()
                cbbQuality_strFD.Items.Clear()

                'UI Change Text / Valid (to my settings ) 
                My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Verifying URL..."

                Dim listDL As New List(Of String)
                Dim listExt As New List(Of String)
                Dim blnFlag As Boolean = True
                For Each vi As VideoInfo In vInfos
                    If blnFlag = True Then
                        strDefTitle = vi.Title
                        blnFlag = False
                    End If

                    Dim strQuality As String
                    Dim strFormat As String
                    strQuality = "Resoultion: " & vi.Resolution
                    cbbQuality_strFD.Items.Add(strQuality)
                    strFormat = " Format: " & vi.VideoExtension
                    cbbFormat_strFD.Items.Add(strFormat)

                    'If the video has a decrypted signature, decrypt it
                    If vi.RequiresDecryption Then
                        DownloadUrlResolver.DecryptDownloadUrl(vi)
                    End If

                    'UI Change Text / Valid (to my settings ) 
                    My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Checking Formats..."


                    listDL.Add(vi.DownloadUrl)
                    listExt.Add(vi.VideoExtension)

                    'Change Format according to setting
                Next
                strArrayLinks = listDL.ToArray
                strArrayExts = listExt.ToArray
                gpbVidInfosFD.Visible = True
                My.Settings.ui_log = Today.Now() + " : " + "Download Request Sucessfully  Please Download Your Video"

                'UI Change Text / Valid (to my settings ) 
                My.Settings.ui_ftmd_lblCurrentStatus_varFTMD = "Download Request Sucessfully "

                'Check (Setting to String) and change current dpd value (My.setting) // Format 
                If My.Settings.dpdVidFormatFSG = 0 Then
                    cbbFormat_strFD.SelectedIndex = 0
                    lblVidFormat_varFD.Text = ".Mp4"
                    My.Settings.ui_ftmd_lblVidFormat_varFTMD = ".Mp4"
                    lblVidFormat_varFD.ForeColor = Color.FromArgb(0, 187, 125)
                ElseIf My.Settings.dpdVidFormatFSG = 1 Then
                    cbbFormat_strFD.SelectedIndex = 3
                    lblVidFormat_varFD.Text = ".3gp"
                    My.Settings.ui_ftmd_lblVidFormat_varFTMD = ".3gp"
                    lblVidFormat_varFD.ForeColor = Color.FromArgb(0, 187, 125)
                ElseIf My.Settings.dpdVidFormatFSG = 2 Then
                    cbbFormat_strFD.SelectedIndex = 1
                    lblVidFormat_varFD.Text = ".Webm"
                    My.Settings.ui_ftmd_lblVidFormat_varFTMD = ".webm"
                    lblVidFormat_varFD.ForeColor = Color.FromArgb(0, 187, 125)
                End If

                'Change Quality according to setiings // quality
                If My.Settings.dpdVidQualityFSG = 0 Then
                    My.Settings.dpdVidQualityFSG = 2
                    cbbQuality_strFD.SelectedIndex = 0

                End If
                If My.Settings.dpdVidQualityFSG = 1 Then

                    cbbQuality_strFD.SelectedIndex = 5
                ElseIf My.Settings.dpdVidQualityFSG = 2 Then
                    cbbQuality_strFD.SelectedIndex = 0
                ElseIf My.Settings.dpdVidQualityFSG = 3 Then
                    cbbQuality_strFD.SelectedIndex = 12
                ElseIf My.Settings.dpdVidQualityFSG = 4 Then
                    cbbQuality_strFD.SelectedIndex = 1
                ElseIf My.Settings.dpdVidQualityFSG = 5 Then
                    cbbQuality_strFD.SelectedIndex = 3
                ElseIf My.Settings.dpdVidQualityFSG = 6 Then
                    cbbQuality_strFD.SelectedIndex = 4
                End If

                If txtURL_varFD.Text.Contains("list") Then

                    frmNotify_PreniumPlaylist.Show()
                Else
                    'Notify if it is from playlist
                    lblVidPlaylist_varFD.Text = "No"
                End If

                ' Now Set the different Varaibles 
                lblVidName_varFD.Text = strDefTitle
                lblVidUrl_varFD.Text = txtURL_varFD.Text
                lblVidUrl_varFD.ForeColor = Color.FromArgb(0, 187, 125)
                lblVidName_varFD.ForeColor = Color.FromArgb(0, 187, 125)
                My.Settings.ui_ftmd_lblVidName_varFTMD = strDefTitle
                'Give Video Name to Avoid Overwrite ##########New Upgrade

                My.Settings.txtFileNameFSF = strDefTitle

                btnDownloadFD.Visible = True
            Else
                'Do Nothing
            End If

            picMarkFD_Paste.Visible = True
        End If
    End Sub
    '//////////Test Save 
    Sub SauvegarderLesDonnées(ByVal Liste As ListView, ByVal Fichier As String)

        Dim ItemSplit As String = "(*E*)" 'Pour séparer entre les éléments -> élément1(*E*)élémen2(*E*)élément3
        Dim ColonneSplit As String = "(*C*)" 'Pour séparer entre les valeurs -> Nom(*C*)Age(*C*)(*Couleur*)
        Dim Build As New Text.StringBuilder() 'Un outil très utile pour construire du string
        Dim nElement As Integer = Liste.Items.Count

        For Each element As ListViewItem In Liste.Items 'Pour chaque élément dans la ListView

            For i As Integer = 0 To Liste.Columns.Count - 1 'Pour chaque colonne dans un élément
                Build.Append(element.SubItems(i).Text) 'Ajouter la valeur du colonne dans le Build
                If (i < Liste.Columns.Count - 1) Then 'Si ce n'est pas la dernière colonne.
                    Build.Append(ColonneSplit) 'Ajouter le séparateur (*C*)
                End If
            Next

            Build.Append(ItemSplit) 'Séparer entre chaque élément -> David(*C*)25(*C*)Rouge(*E*)
        Next
        Try
            IO.File.WriteAllText(Fichier, Build.ToString()) 'écrir le build dans le fichier
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur")
        End Try
    End Sub
End Class

