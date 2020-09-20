'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmStats_SystemStats
    Private Sub frmStats_SystemStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'IP  address

        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()

        'Add all variables

        txtHostName_varFSSS.Text = My.Computer.Name
        txtOsVersion_varFSSS.Text = My.Computer.Info.OSVersion
        txtOsInfos_varFSSS.Text = My.Computer.Info.OSFullName
        txtIPAddress_varFSSS.Text = strIPAddress
    End Sub
End Class

