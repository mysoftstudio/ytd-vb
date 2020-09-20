Public Class frmNotify_PreniumPlaylist
    Private Sub btnOkNPL_Click(sender As Object, e As EventArgs) Handles btnOkNPL.Click
        Me.Hide()

    End Sub

    Private Sub btnGetPremiumNPL_Click(sender As Object, e As EventArgs) Handles btnGetPremiumNPL.Click
        'show Premium
        frmPremium.Show()
    End Sub

    Private Sub frmNotify_PreniumPlaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub lblDontShow_Click(sender As Object, e As EventArgs) Handles lblDontShow.Click
        My.Settings.ui_premiumfeatures = False
        Me.Hide()
    End Sub
End Class