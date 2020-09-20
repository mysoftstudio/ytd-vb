Imports System.Net
Imports System.Net.Mail
Public Class frmFeedbacks

    Private Sub frmFeedbacks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnCloseF_Click_1(sender As Object, e As EventArgs) Handles btnCloseF.Click, btnClose.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub txtMotive_Pb_varF_TextChanged(sender As Object, e As EventArgs) Handles txtMotive_Pb_varF.TextChanged
        'Do Variables
    End Sub

    Private Sub Rating_varStars_onValueChanged(sender As Object, e As EventArgs) Handles Rating_varStars.onValueChanged
        'Set Text to hide Textbox
        If Rating_varStars.Value = 1 Then
            txtRank.Text = "1 Star / 5 Star"
        ElseIf Rating_varStars.Value = 2 Then
            txtRank.Text = "2 Star / 5 Star"
        ElseIf Rating_varStars.Value = 3 Then
            txtRank.Text = "3 Star / 5 Star"
        ElseIf Rating_varStars.Value = 4 Then
            txtRank.Text = "4 Star / 5 Star"
        ElseIf Rating_varStars.Value = 5 Then
            txtRank.Text = "5 Star / 5 Star"
        End If
    End Sub

    Private Sub dpdSocialNetF_onItemSelected(sender As Object, e As EventArgs) Handles dpdSocialNetF.onItemSelected
        'Set Text to hide Textbox
        If dpdSocialNetF.selectedIndex = 0 Then
            txtSocialNet.Text = "Skype : "
        ElseIf dpdSocialNetF.selectedIndex = 1 Then
            txtSocialNet.Text = "WhatsApp : "
        ElseIf dpdSocialNetF.selectedIndex = 2 Then
            txtSocialNet.Text = "Facebook : "
        ElseIf dpdSocialNetF.selectedIndex = 3 Then
            txtSocialNet.Text = "Messenger : "
        ElseIf dpdSocialNetF.selectedIndex = 4 Then
            txtSocialNet.Text = "Instagram : "
        ElseIf dpdSocialNetF.selectedIndex = 5 Then
            txtSocialNet.Text = "Twitter : "
        End If
    End Sub

    Private Sub btnSubmitF_Click(sender As Object, e As EventArgs) Handles btnSubmitF.Click
        If txtMotive_Pb_varF.Text = "" Or txtRank.Text = "" Or txtSocialUserF.Text = "" Then

            'Please Enteryour feedbacks
            MsgBox("Please Try to Enter your contacts or Your Feedbacks, don't forget to rate", MsgBoxStyle.Exclamation, "Empty Cases")
            txtSocialUserF.BorderColorFocused = Color.Tomato
        Else

            txtSocialUserF.BorderColorFocused = Color.FromArgb(0, 187, 125)

            'split hide text with good Text
            txtSocialUserF.Text = txtSocialNet.Text + " " + txtSocialUserF.Text
            txtMotive_Pb_varF.Text = txtMotive_Pb_varF.Text + vbNewLine + "=========================================" + vbNewLine + "Contact of " + My.Computer.Name + vbNewLine + "=========================================" + vbNewLine + "Email : " + txtEmailF.Text + vbNewLine + txtSocialUserF.Text + vbNewLine + My.Computer.Name + " Rated : " + txtRank.Text

            ' Then try to send
            Dim client As SmtpClient = New SmtpClient
            Dim mailMessage As MailMessage = New MailMessage
            mailMessage.To.Add("mysoftstudio.pro@gmail.com")
            mailMessage.Sender = New MailAddress("noreply-@mysoftstudio.de", "Feed Backs")
            mailMessage.From = New MailAddress("noreply-@mysoftstudio.de", "MySoft YouTube Downloader")
            mailMessage.Subject = "New FeedBack| Alert Please Respond| " + My.Computer.Name
            mailMessage.Body = txtMotive_Pb_varF.Text
            mailMessage.IsBodyHtml = False

            client.Host = "smtp.gmail.com"
            client.Port = Convert.ToInt16("587")
            client.UseDefaultCredentials = False
            client.EnableSsl = True
            client.Credentials = New NetworkCredential("onlinefranztech@gmail.com", "onlinefranztech2017")

            client.DeliveryMethod = SmtpDeliveryMethod.Network
            Try
                client.Send(mailMessage)
                MessageBox.Show("Thanks For Sending Us a feedback, We would answer you, fast as possible")
            Catch ex As Exception
                MessageBox.Show(("Error : " + ex.Message))
            End Try
        End If
    End Sub

    Private Sub txtEmailF_OnValueChanged(sender As Object, e As EventArgs) Handles txtEmailF.OnValueChanged
        If txtEmailF.Text.Contains("@") Or txtEmailF.Text.Contains("gmail") Then
            txtEmailF.BorderColorFocused = Color.FromArgb(0, 187, 125)
        Else
            txtEmailF.BorderColorFocused = Color.Tomato
        End If
    End Sub

End Class