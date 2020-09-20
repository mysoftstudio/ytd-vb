'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmTopMenu_Preview
    Private Sub frmTopMenu_Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set VidName and VidSize
        lblVidName_varFTMP.Text = My.Settings.ui_ftmd_lblVidName_varFTMD
        lblVidSize_varFTMP.Text = My.Settings.ui_ftmd_lblVidSize_varFTMD
    End Sub
End Class

