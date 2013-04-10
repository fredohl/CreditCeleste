Public Class frmSaisieBien

    Private Sub frmSaisieBien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblVehicule.Text = uneVoiture.getNomVéhicule()
        txtAnneeModele.Text = uneVoiture.getAnnéeModèle()
        txtd1ereImmat.Text = uneVoiture.get1ereImmat
        txtNumImmat.Text = uneVoiture.getNumImmat
        txtPuissance.Text = uneVoiture.getPuisChevaux
        txtNumSérie.Text = uneVoiture.getNumeroSerie
        '
    End Sub

    Private Sub cmdIntroduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIntroduction.Click
        '
        '
        ' affichage de la fenetre du bien
        '
        ' If fenIntro Is Nothing Then
        ' fenIntro = New frmIntroduction
        ' End If
        '
        '       fenIntro.Show()
        '
        '    Me.Close()

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

    Private Sub cmdEnr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnr.Click

        uneVoiture.setbien(txtd1ereImmat.Text, txtAnneeModele.Text, txtNumImmat.Text, txtNumSérie.Text, txtPuissance.Text)

    End Sub

    Private Sub btnDossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossier.Click
        Me.Dispose()

        frmDossier.Show()
    End Sub
End Class