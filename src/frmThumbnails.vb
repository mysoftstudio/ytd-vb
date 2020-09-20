'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmThumbnails
    Private Sub btnMainInfoFT_Click(sender As Object, e As EventArgs) Handles btnMainInfoFT.Click
        'Open Help
        frmHelp.Show()
    End Sub

    Private Sub btnSettingFT_Click(sender As Object, e As EventArgs) Handles btnSettingFT.Click
        'open Settings
        frmSettings.Show()
    End Sub

    Private Sub imgbtnSaveFT_Click(sender As Object, e As EventArgs) Handles imgbtnSaveFT.Click

    End Sub

    Private Sub frmThumbnails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Check Or Open Frm Premuim
        If My.Settings.ui_premiumfeatures = False Then
        Else
            frmNotify_PremiumTumb_Share.Show()
        End If
        ''Start Query if URL IS VALID
        Dim urlQueryStrPos As Integer
        urlQueryStrPos = My.Settings.txtURL_varFD.IndexOf("?v=")

        If urlQueryStrPos < 0 Then
            'False URL
            Me.picDefaultImage_varFT.Image = My.Resources.default_no_image
            Me.picLargeImage_varFT.Image = My.Resources.default_no_image
            Me.picImg1_varFT.Image = My.Resources.default_no_image
            Me.picImg2_varFT.Image = My.Resources.default_no_image

        Else
            'Correct

            'locate the start position of the video ID
            Dim youTubeVideoIdStartPos As Integer
            youTubeVideoIdStartPos = urlQueryStrPos + 3

            'extract the video id from the url string
            Dim youtubeVideoId As String
            youtubeVideoId = My.Settings.txtURL_varFD.Substring(youTubeVideoIdStartPos, 11)


            'Setting The URL Variables
            Dim smallThumbnailUrl As String
            Dim largeImageUrl As String
            Dim alternateThumbnailOneUrl As String
            Dim alternateThumbnailTwoUrl As String

            'Giving ID to variable
            smallThumbnailUrl = "http://img.youtube.com/vi/" & youtubeVideoId & "/default.jpg"
            largeImageUrl = "http://img.youtube.com/vi/" & youtubeVideoId & "/0.jpg"
            alternateThumbnailOneUrl = "http://img.youtube.com/vi/" & youtubeVideoId & "/1.jpg"
            alternateThumbnailTwoUrl = "http://img.youtube.com/vi/" & youtubeVideoId & "/3.jpg"
            'Loading Thumbnails
            Me.picDefaultImage_varFT.Load(smallThumbnailUrl)
            Me.picLargeImage_varFT.Load(largeImageUrl)
            Me.picImg1_varFT.Load(alternateThumbnailOneUrl)
            Me.picImg2_varFT.Load(alternateThumbnailTwoUrl)
        End If
    End Sub

    Private Sub btnRefreshFT_Click(sender As Object, e As EventArgs) Handles btnRefreshFT.Click
        ''Start Query if URL IS VALID
        Dim urlQueryStrPos As Integer
        urlQueryStrPos = My.Settings.txtURL_varFD.IndexOf("?v=")

        If urlQueryStrPos < 0 Then
            'False URL
        Else
            'Correct

            'locate the start position of the video ID
            Dim youTubeVideoIdStartPos As Integer
            youTubeVideoIdStartPos = urlQueryStrPos + 3

            'extract the video id from the url string
            Dim youtubeVideoId As String
            youtubeVideoId = My.Settings.txtURL_varFD.Substring(youTubeVideoIdStartPos, 11)


            'Setting The URL Variables
            Dim smallThumbnailUrl As String
            Dim largeImageUrl As String
            Dim alternateThumbnailOneUrl As String
            Dim alternateThumbnailTwoUrl As String

            'Giving ID to variable
            smallThumbnailUrl = "http://img.youtube.com/vi/" & youtubeVideoId & "/default.jpg"
            largeImageUrl = "http://img.youtube.com/vi/" & youtubeVideoId & "/0.jpg"
            alternateThumbnailOneUrl = "http://img.youtube.com/vi/" & youtubeVideoId & "/1.jpg"
            alternateThumbnailTwoUrl = "http://img.youtube.com/vi/" & youtubeVideoId & "/3.jpg"
            'Loading Thumbnails
            Me.picDefaultImage_varFT.Load(smallThumbnailUrl)
            Me.picLargeImage_varFT.Load(largeImageUrl)
            Me.picImg1_varFT.Load(alternateThumbnailOneUrl)
            Me.picImg2_varFT.Load(alternateThumbnailTwoUrl)
        End If
    End Sub
End Class

