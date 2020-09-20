Public Class Form1
    Dim np As New nowplaying
    Dim imp As New importmusic
    Dim playlist As New playlist
    Dim checkbuttonposition As Integer = 1
    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If sidepanel.Width = 275 Then
            hidesidepanel.Start()
            lbltitle.Hide()

        Else
            lbltitle.Show()
            showsidepanel.Start()
        End If
    End Sub

    Private Sub showsidepanel_Tick(sender As Object, e As EventArgs) Handles showsidepanel.Tick
        sidepanel.Width = sidepanel.Width + 60
        If sidepanel.Width = 275 Then
            showsidepanel.Stop()
        End If
    End Sub

    Private Sub hidesidepanel_Tick(sender As Object, e As EventArgs) Handles hidesidepanel.Tick
        sidepanel.Width = sidepanel.Width - 60
        If sidepanel.Width < 50 Then
            hidesidepanel.Stop()
        End If
    End Sub

    Private Sub btnnowplaying_Click(sender As Object, e As EventArgs) Handles btnnowplaying.Click
        Try
           
            np.BringToFront()
            checkbuttonposition = 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
      prgvol.Value = mplayer.settings.volume

            My.Settings.songsupdates = False
            My.Settings.Save()
            My.Settings.Reload()
        'checking if it's first time application is lunched!
            If My.Settings.firstrun = False Then
                'here settings or listboxes are reseting...
                My.Settings.lstname.Clear()
                My.Settings.Save()
                My.Settings.Reload()

                My.Settings.lsturl.Clear()
                My.Settings.Save()
                My.Settings.Reload()

                'here first time run setting is being disabled
                My.Settings.firstrun = True
                My.Settings.Save()
                My.Settings.Reload()
            End If

            mainpanel.Controls.Add(np)
            np.Dock = DockStyle.Fill

            mainpanel.Controls.Add(imp)
            imp.Dock = DockStyle.Fill

            mainpanel.Controls.Add(playlist)
            playlist.Dock = DockStyle.Fill

       
    End Sub

    Private Sub btnimpormusic_Click(sender As Object, e As EventArgs) Handles btnimpormusic.Click
        Try
            checkbuttonposition = 2
            imp.BringToFront()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub addplaylistitems()
        Dim checksongs As Integer = 0
        Try

            playlist.lstname.Items.Clear()
            playlist.lsturl.Items.Clear()
            mplayer.currentPlaylist.clear()
            'imports all songs from settings to listboxes
            For Each songspath As String In My.Settings.lsturl
                playlist.lsturl.Items.Add(songspath)
            Next

            For Each songsname As String In My.Settings.lstname
                playlist.lstname.Items.Add(songsname)
            Next

            playlist.lstname.SelectedIndex = 0
            playlist.lsturl.SelectedIndex = 0

        Catch ex As Exception

        End Try

        Try
            'add palylist in form
            If checksongs < playlist.lstname.Items.Count Then
                Do While checksongs < playlist.lstname.Items.Count
                    Dim pi As New playitem
                    playlist.mainpanel.Controls.Add(pi)
                    pi.Dock = DockStyle.Top
                    pi.BringToFront()
                    pi.lblsongtitle.Text = playlist.lstname.SelectedItem.ToString
                    pi.lblsongpath.Text = playlist.lsturl.SelectedItem.ToString
                    pi.lblid.Text = playlist.lstname.SelectedIndex.ToString
                    playlist.lstname.SelectedIndex = playlist.lstname.SelectedIndex + 1
                    playlist.lsturl.SelectedIndex = playlist.lsturl.SelectedIndex + 1
                    checksongs = checksongs + 1
                    If checksongs = playlist.lstname.Items.Count Then
                        Refresh_playlist.Close()
                        playlist.BringToFront()
                    End If
                Loop
            End If

        Catch ex As Exception

        End Try


        Try
            'add playlist to media player 
            Dim newPlayList As WMPLib.IWMPPlaylist = mplayer.playlistCollection.newPlaylist("soundsToPlay")
            If Windows.Forms.DialogResult.OK Then
                mplayer.Ctlcontrols.stop()
                mplayer.currentPlaylist.clear()

                For Each songs As String In My.Settings.lsturl
                    newPlayList.appendItem(mplayer.newMedia(songs))
                    mplayer.currentPlaylist = newPlayList
                    mplayer.Ctlcontrols.play()
                Next
            End If


        Catch ex As Exception

        End Try







    End Sub
    Private Sub btncplaylist_Click(sender As Object, e As EventArgs) Handles btncplaylist.Click
        Try
            checkbuttonposition = 3
            If My.Settings.songsupdates = True Then
                playlist.mainpanel.Controls.Clear()
                addplaylistitems()
                My.Settings.songsupdates = False
                My.Settings.Save()
                My.Settings.Reload()
            Else
                playlist.BringToFront()
           End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub checkbutton_Tick(sender As Object, e As EventArgs) Handles checkbutton.Tick
        Try
            If checkbuttonposition = 1 Then
                'cheching the color of now playing button
                btnnowplaying.BackColor = Color.FromArgb(0, 15, 26)
                btnimpormusic.BackColor = Color.FromArgb(32, 43, 61)
                btncplaylist.BackColor = Color.FromArgb(32, 43, 61)
            ElseIf checkbuttonposition = 2 Then
                btnnowplaying.BackColor = Color.FromArgb(32, 43, 61)
                'cheching the color of importmusic button
                btnimpormusic.BackColor = Color.FromArgb(0, 15, 26)
                btncplaylist.BackColor = Color.FromArgb(32, 43, 61)

            ElseIf checkbuttonposition = 3 Then

                btnnowplaying.BackColor = Color.FromArgb(32, 43, 61)
                btnimpormusic.BackColor = Color.FromArgb(32, 43, 61)
                'cheching the color of my playlist button
                btncplaylist.BackColor = Color.FromArgb(0, 15, 26)

            End If


        Catch ex As Exception

        End Try
    End Sub


  
    Private Sub seekbar_Tick(sender As Object, e As EventArgs) Handles seekbar.Tick
        Try

            'this timer will control the seek bar and status of mediaplayer
            prgseekbar.Maximum = mplayer.currentMedia.duration
            prgseekbar.Value = mplayer.Ctlcontrols.currentPosition

            lblcurrentpositio.Text = mplayer.Ctlcontrols.currentPositionString
            lbltotalmedia.Text = mplayer.currentMedia.durationString

        Catch ex As Exception

        End Try
    End Sub
    Dim seekbarmaximumwidth As Integer
    Private Sub checkpalyerstat_Tick(sender As Object, e As EventArgs) Handles checkpalyerstat.Tick
        Try
            If mplayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
                'this will start seekbar timer if media player is playing a song
                btnplay.Image = My.Resources.pause_48
                seekbar.Start()

            ElseIf mplayer.playState = WMPLib.WMPPlayState.wmppsPaused Then
                ' this will top the seekbar timer if media player is stop
                btnplay.Image = My.Resources.play_48
                seekbar.Stop()
            ElseIf mplayer.playState = WMPLib.WMPPlayState.wmppsStopped Then
                ' this will top the seekbar timer if media player is stop
                btnplay.Image = My.Resources.play_48
                prgseekbar.Value = 0
                lblcurrentpositio.Text = "00:00"
                lbltotalmedia.Text = "00:00"
                seekbar.Stop()
            Else
                ' this will top the seekbar timer if media player is stop
                btnplay.Image = My.Resources.play_48
                prgseekbar.Value = 0
                lblcurrentpositio.Text = "00:00"
                lbltotalmedia.Text = "00:00"
                seekbar.Stop()
            End If

            seekbarmaximumwidth = prgseekbar.Width
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mplayer_MediaChange(sender As Object, e As AxWMPLib._WMPOCXEvents_MediaChangeEvent) Handles mplayer.MediaChange
        Try
            Dim i As Integer
            For i = 0 To mplayer.currentPlaylist.count - 1
                If mplayer.currentMedia.isIdentical(mplayer.currentPlaylist.Item(i)) Then
                    playlist.lsturl.SelectedIndex = Str(i)
                    My.Settings.songid = Str(i)
                End If
            Next
            My.Settings.Save()
            My.Settings.Reload()
            prgseekbar.Value = 0
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnplay_Click(sender As Object, e As EventArgs) Handles btnplay.Click
        Try
            If mplayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
                mplayer.Ctlcontrols.pause()
            ElseIf mplayer.playState = WMPLib.WMPPlayState.wmppsPaused Then
                mplayer.Ctlcontrols.play()

            ElseIf My.Settings.lstname.Count = 0 Then
                checkbuttonposition = 2
                imp.BringToFront()
            Else


                mplayer.Ctlcontrols.play()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Dim loopmedia As Integer = 0
    Dim shufflemedia As Integer = 0
    Private Sub btnstop_Click(sender As Object, e As EventArgs) Handles btnstop.Click
        mplayer.Ctlcontrols.stop()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        mplayer.Ctlcontrols.next()
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        mplayer.Ctlcontrols.previous()
    End Sub

    Private Sub btnrepeat_Click(sender As Object, e As EventArgs) Handles btnrepeat.Click
        If loopmedia = 0 Then
            mplayer.settings.setMode("Loop", True)
            loopmedia = 1
            btnrepeat.Image = My.Resources.repeat_48_on
        Else
            mplayer.settings.setMode("Loop", False)
            loopmedia = 0
            btnrepeat.Image = My.Resources.repeat_48
        End If

    End Sub

    Private Sub btnshuffle_Click(sender As Object, e As EventArgs) Handles btnshuffle.Click
        If shufflemedia = 0 Then
            mplayer.settings.setMode("Shuffle", True)
            shufflemedia = 1
            btnshuffle.Image = My.Resources.shuffle_48_on
        Else
            mplayer.settings.setMode("Shuffle", False)
            shufflemedia = 0
            btnshuffle.Image = My.Resources.shuffle_48
        End If

    End Sub


    Private Sub btnvolume_Click(sender As Object, e As EventArgs) Handles btnvolume.Click
        If volumepanel.Width = 35 Then
            Do While volumepanel.Width < 195
                volumepanel.Width = volumepanel.Width + 5
            Loop
        Else
            Do While volumepanel.Width > 35
                volumepanel.Width = volumepanel.Width - 10
            Loop

        End If
    End Sub

    Private Sub btnjumpback_Click(sender As Object, e As EventArgs) Handles btnjumpback.Click
        Try
            mplayer.Ctlcontrols.currentPosition = mplayer.Ctlcontrols.currentPosition - 5
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnjumpforward_Click(sender As Object, e As EventArgs) Handles btnjumpforward.Click
        Try
            mplayer.Ctlcontrols.currentPosition = mplayer.Ctlcontrols.currentPosition + 5
        Catch ex As Exception

        End Try
    End Sub

    Private Sub prgvol_ValueChanged() Handles prgvol.ValueChanged
        Try
            mplayer.settings.volume = prgvol.Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Me.Refresh()
        Me.Close()
    End Sub

    Private Sub mplayer_Enter(sender As Object, e As EventArgs) Handles mplayer.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        About.ShowDialog()
    End Sub

#Region "Drag"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub toppanel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles toppanel.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub


    Private Sub toppanel_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles toppanel.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub toppanel_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles toppanel.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove

    End Sub
#End Region

    Private Sub btnjumpback_MouseDown(sender As Object, e As MouseEventArgs) Handles btnjumpback.MouseDown
        Try
            mplayer.Ctlcontrols.currentPosition = mplayer.Ctlcontrols.currentPosition - 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnjumpforward_MouseDown(sender As Object, e As MouseEventArgs) Handles btnjumpforward.MouseDown
        Try
            mplayer.Ctlcontrols.currentPosition = mplayer.Ctlcontrols.currentPosition + 1
        Catch ex As Exception

        End Try
    End Sub
End Class
