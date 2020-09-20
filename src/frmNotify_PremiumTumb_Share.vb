Public Class frmNotify_PremiumTumb_Share

    Private Sub btnOkNPS_Click(sender As Object, e As EventArgs) Handles btnOkNPS.Click
        Me.Hide()
    End Sub

    Private Sub frmNotify_PremiumTumb_Share_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub lblDontShow_Click(sender As Object, e As EventArgs) Handles lblDontShow.Click
        My.Settings.ui_premiumfeatures = False
        Me.Hide()
    End Sub
End Class