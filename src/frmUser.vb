'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmUser
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblDontShow.Click
        'set settings as false
        My.Settings.ui_feedbacks = False

        'Close
        Me.Hide()
    End Sub

    Private Sub btnGetPremiumDM_Click(sender As Object, e As EventArgs) Handles btnGetPremiumDM.Click
        'Show Feedback
        frmFeedbacks.Show()
        'Close
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        'Close
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Close
        Me.Hide()
    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class

