'
'Copyright : © MySoft Studio - All rights Reserved @Franz Nkemaka
'Date      : 22 August 2017 ' started working on
'Author    : Franz Nkemaka
'Email     : franz@rigle.co , mysoftstudio.pro@gmail.com

Public Class frmHistory
    Dim Save As String = Application.StartupPath & "\History.txt"
    Dim Loadl As String = Application.StartupPath & "\History.txt"
    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load History
        RechargerLesDonnées(ListViewHistory_varFH, Loadl)


        'Notify 

    End Sub
    Private Sub btnRefreshFH_Click(sender As Object, e As EventArgs) Handles btnRefreshFH.Click, imgbtnFH_Refresh.Click

        'Autosave /////////////
        If My.Settings.ckbFSA_AddHistory = True Then
            'Auto Save
            SauvegarderLesDonnées(ListViewHistory_varFH, Save)
        Else
        End If
        'Load History
        RechargerLesDonnées(ListViewHistory_varFH, Loadl)
    End Sub


    '    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================

    '#####################################-------------------Save Data----------------------------------------##############################
    Private Sub btnSaveFH_Click(sender As Object, e As EventArgs) Handles btnSaveFH.Click, imgbtnFH_Save.Click
        'Auto Save
        SauvegarderLesDonnées(ListViewHistory_varFH, Save)

        'Choisir l'emplacement d'enregistrement des données.
        Using sauve As New SaveFileDialog()
            sauve.Filter = "Fichier texte|*.txt"
            If sauve.ShowDialog() = DialogResult.OK Then
                SauvegarderLesDonnées(ListViewHistory_varFH, sauve.FileName)
            End If
        End Using

        'Autosave /////////////
        If My.Settings.ckbFSA_AddHistory = True Then
            'Auto Save
            SauvegarderLesDonnées(ListViewHistory_varFH, Save)
        Else
        End If
    End Sub
    Sub SauvegarderLesDonnées(ByVal Liste As ListView, ByVal Fichier As String)

        Dim ItemSplit As String = "(*E*)" 'Pour séparer entre les éléments -> élément1(*E*)élémen2(*E*)élément3
        Dim ColonneSplit As String = "(*C*)" 'Pour séparer entre les valeurs -> Nom(*C*)Age(*C*)(*Couleur*)
        Dim Build As New Text.StringBuilder() 'Un outil très utile pour construire du string
        Dim nElement As Integer = Liste.Items.Count

        For Each element As ListViewItem In Liste.Items 'Pour chaque élément dans la ListView

            For i As Integer = 0 To Liste.Columns.Count - 1 'Pour chaque colonne dans un élément
                Build.Append(element.SubItems(i).Text) 'Ajouter la valeur du colonne dans le Build
                If (i < Liste.Columns.Count - 1) Then 'Si ce n'est pas la dernière colonne.
                    Build.Append(ColonneSplit) 'Ajouter le séparateur (*C*)
                End If
            Next

            Build.Append(ItemSplit) 'Séparer entre chaque élément -> David(*C*)25(*C*)Rouge(*E*)
        Next

        Try

            IO.File.WriteAllText(Fichier, Build.ToString()) 'écrir le build dans le fichier

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '#####################################--------******-----------End of Save Data ------------*******--------------##############################

    '    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================
    '===========================================================================================================================================================================

    '#####################################-------------------Recharge Data----------------------------------------##############################

    Private Sub btnExportFH_Click(sender As Object, e As EventArgs) Handles btnExportFH.Click, imgbtnFH_Export.Click
        'Choisir le fichier a recharger dans la ListView
        Using Ouvrir As New OpenFileDialog
            Ouvrir.Filter = "Texte|*.txt" 'Pour plusieurs extensions on fait: Texte|*.txt|Application|*.exe|Tous|*.*
            If Ouvrir.ShowDialog() = DialogResult.OK Then
                RechargerLesDonnées(ListViewHistory_varFH, Ouvrir.FileName)
            End If



            'Autosave /////////////
            If My.Settings.ckbFSA_AddHistory = True Then
                'Auto Save
                SauvegarderLesDonnées(ListViewHistory_varFH, Save)
            Else
            End If
        End Using
    End Sub

    'Méthode pour rechager les donénes depuis un fichier.
    Sub RechargerLesDonnées(ByVal Liste As ListView, ByVal Fichier As String)
        Liste.Items.Clear()
        Dim ItemSplit As String = "(*E*)"
        Dim ColonneSplit As String = "(*C*)"


        Try 'Au cas d'erreur
            If IO.File.Exists(Fichier) Then 'Si le fichier existe

                Dim LesDonnées As String = IO.File.ReadAllText(Fichier) 'Lire toute les données
                Dim LesElements() As String = LesDonnées.Split(New String() {ItemSplit}, StringSplitOptions.RemoveEmptyEntries) 'Séparer avec (*E*)

                For Each element As String In LesElements 'Pour chaque éléments dans LesElements()
                    If (element.Contains(ColonneSplit)) Then 'Si ça contient le séparateur (*C*)

                        Dim LesValeurs() As String = element.Split(New String() {ColonneSplit}, StringSplitOptions.None) 'Séparer avec (*C*)
                        Dim NouveauElement As New ListViewItem 'Nouveau élément a ajouter dans la ListView

                        For i As Integer = 0 To LesValeurs.Length - 1 'Pour chaque valeur dans  LesValeurs()
                            If i = 0 Then 'Si c'est la première valeur
                                NouveauElement.Text = LesValeurs(i) 'Ajouter la valeur dans la première colonne.
                            Else 'Si non l'ajouter dans les autres colonnes
                                NouveauElement.SubItems.Add(LesValeurs(i)) 'Si i = 1 donc c'est la deuxième colonne etc
                            End If
                        Next
                        Liste.Items.Add(NouveauElement) 'Ajouter l'élément a la ListView

                    End If
                Next


            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur")
        End Try

    End Sub
    Private Sub imgbtnFH_YouTubeSmall_Click(sender As Object, e As EventArgs) Handles imgbtnFH_YouTubeSmall.Click
        'Open YouTube
        Process.Start("http://www.youtube.com")
    End Sub

    Private Sub imgbtnFH_MoreInfos_Click(sender As Object, e As EventArgs) Handles imgbtnFH_MoreInfos.Click
        'show help
        frmHelp.Show()
    End Sub

    Private Sub imgbtnFH_Setting_Click(sender As Object, e As EventArgs) Handles imgbtnFH_Setting.Click
        'show setttings
        frmSettings.Show()
    End Sub

    Private Sub btnClearFH_Click(sender As Object, e As EventArgs) Handles btnClearFH.Click
        'Reset all text
        Dim path As String = Application.StartupPath & "\History.txt"
        System.IO.File.WriteAllText(path, "")
        'Load History
        RechargerLesDonnées(ListViewHistory_varFH, Loadl)
    End Sub
End Class

