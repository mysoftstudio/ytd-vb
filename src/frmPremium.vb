'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmPremium
    Private Sub frmPremium_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub btnGetPremiumDM_Click(sender As Object, e As EventArgs)
        Process.Start("http://www.mysoftstudio.ml/p/buy.html")
        Process.Start("http://www.mysoftstudio.ml/2017/10/mysoft-youtube-downloader.html")
        Me.Hide()
    End Sub
    Private Sub PictureBox13_Click_1(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Me.Hide()
    End Sub
End Class

