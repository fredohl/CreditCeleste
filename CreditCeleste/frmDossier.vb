Public Class frmDossier

    Private Sub TxtDuree_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDuree.TextChanged

    End Sub

    Private Sub frmDossier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TxtDuree.Text = unDossier.LaDuree
        TxtMontant.Text = unDossier.LeMontant
        If (TxtDuree.Text = 0 And TxtMontant.Text = 0) Then
            LblMensualite.Text = "0"
        Else
            LblMensualite.Text = unDossier.getMensualite(unDossier.LaDuree, unDossier.LeMontant)
        End If

        LblNum.Text = 8001

        LblClient.Text = unDossier.infoClient.getNomClient
        LblCoVendeur.Text = unDossier.infoVendeur.getInfoVendeur
        LblCivilite.Text = unDossier.infoClient.getCivilite
        LblPrenom.Text = unDossier.infoClient.getPrenomClient
        unDossier.PositionDuDossier = unDossier.PositionScoringConnexion(unClient)
        LblPositionDossier.Text = unDossier.PositionDuDossier

        'Appel la méthode TestDossier() dans le moduleTest pour les tests unitaires de la méthode getmensualité()
        TestDossier()


    End Sub

    Private Sub TxtMontant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMontant.TextChanged

    End Sub

    Private Sub btn_Fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Fermer.Click
        If Not IsNothing(fenIntro) Then
            'Si on en a pas déjà disposé
            If Not fenIntro.IsDisposed Then
                fenIntro.WindowState = FormWindowState.Normal  ' Optional
                fenIntro.BringToFront()  '  Optional
            Else
                fenIntro = New frmIntroduction
                fenIntro.Show()
            End If
        Else
            fenIntro = New frmIntroduction
            fenIntro.Show()
        End If
        '
        Me.Close()
    End Sub

    Private Sub btnCalcul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_Enr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Enr.Click
        unDossier.LaDuree = TxtDuree.Text
        unDossier.LeMontant = TxtMontant.Text 'utilisation de la property de Dossier
        unDossier.LeNumero = 8001


        Dim unResultat As Double

        If String.IsNullOrEmpty(TxtTaux.Text) Then
            unResultat = unDossier.getMensualite(unDossier.LaDuree, unDossier.LeMontant)
        Else
            unDossier.LeTaux = TxtTaux.Text
            unResultat = unDossier.getMensualite(unDossier.LaDuree, unDossier.LeMontant, unDossier.LeTaux)
        End If

        LblMensualite.Text = unResultat






    End Sub

    Private Sub BtnAccueil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAccueil.Click
        Me.Dispose()

        frmAccueil.Show()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class