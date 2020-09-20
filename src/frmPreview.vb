'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmPreview
    Private Sub frmPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblVidName_varFP.Text = My.Settings.lblVidName_varFTMD
        txt_UrlChange.Text = My.Settings.txtURL_varFD
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStopFP.Click
        webbNavigateURL.Navigate(Application.StartupPath & "\NoUrl.html")
    End Sub

    Private Sub txtURL_TextChanged(sender As Object, e As EventArgs) Handles txt_UrlChange.TextChanged
        Dim Original As String = My.Settings.txtURL_varFD
        ' Returns "Shipping List".
        Dim YouTube_Vid As String = Replace(Original, "watch?v=", "v/")
        txt_UrlChange.Text = YouTube_Vid
        My.Settings.direct_prev_link = YouTube_Vid
        My.Settings.Save()
        webbNavigateURL.Navigate(txt_UrlChange.Text)
    End Sub
End Class

