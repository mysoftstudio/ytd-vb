Public Class frmNotify_PremiumPlay
    Private Sub btnOkNPP_Click(sender As Object, e As EventArgs) Handles btnOkNPP.Click
        Me.Hide()
    End Sub

    Private Sub frmNotify_PremiumPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub btnMoreInfos_Click(sender As Object, e As EventArgs) Handles btnMoreInfos.Click, btnMainInfoNPP.Click
        frmHelp.Show()


    End Sub

    Private Sub lblDontShow_Click(sender As Object, e As EventArgs) Handles lblDontShow.Click
        My.Settings.ui_premiumfeatures = False

    End Sub
End Class