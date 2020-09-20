'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmAbout
    Private Sub lblMySoftStudio_linkFA_Click(sender As Object, e As EventArgs) Handles lblMySoftStudio_linkFA.Click
        Process.Start("http://www.mysoftstudio.ml")
    End Sub

    Private Sub lblCopyrightFA_Click(sender As Object, e As EventArgs) Handles lblCopyrightFA.Click, Label1.Click

    End Sub

    Private Sub btnCloseF_Click(sender As Object, e As EventArgs) Handles btnCloseF.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class

