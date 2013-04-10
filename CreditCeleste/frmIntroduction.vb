Public Class frmIntroduction

    Private Sub frmIntroduction_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Me.Dispose()
    End Sub

    Private Sub frmIntroduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim unVendeur As New Vendeur
        'unVendeur.nomVendeur = "toto"
        'MsgBox(unVendeur.nomVendeur)


        txtNouVhc.Text = uneVoiture.getNomVéhicule()
        txtAncVhc.Text = uneVoiture.getAncienVehicule()
        cbxVdr.Items.Clear()  ' on efface le contenu

        ' on rajoute les vendeurs

        For Each xVendeur As Vendeur In uneConcession.LesVendeurs
            ' cbxVdr.Items.Add(xVendeur)  ' ne marche pas  
            cbxVdr.Items.Add(xVendeur.getInfoVendeur)  '' ne marche pas , colle les champs, mettre espace
        Next
        '
        txtNom.Text = unClient.getNomClient
        txtPrenom.Text = unClient.getPrenomClient
        cbxIdent.Text = unClient.getCivilite



        Dim item As RadioButton
        Dim temp As String
        temp = uneVoiture.getAge
        For Each item In gbpAge.Controls
            If item.Text = temp Then
                item.Checked = True
            End If
        Next


        cbxVdr.Text = leNomVendeur
        ''
    End Sub

    Private Sub cmdEnr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnr.Click
        '
        ' enregistrement des données
        '
        uneVoiture.setNomVéhicule(txtNouVhc.Text)
        uneVoiture.setAncienVehicule(txtAncVhc.Text)
        'uneVoiture.
        '
        '  gestion des clients
        '
        unClient.setNomClient(txtNom.Text)
        unClient.setPrenomClient(txtPrenom.Text)
        unClient.setCivilite(cbxIdent.Text)
        For Each elementvendeur As String In cbxVdr.Controls
            If elementvendeur Then
                unDossier.infoVendeur.nomVendeur = elementvendeur
            End If
        Next

        '
        ' Gestion des vendeurs
        '
        leNomVendeur = cbxVdr.Text

        Dim item As RadioButton
        For Each item In gbpAge.Controls
            If item.Checked Then
                uneVoiture.setAge(item.Text)
            End If
        Next

        unDossier.infoClient.setNomClient(txtNom.Text)
        unDossier.infoClient.setPrenomClient(txtPrenom.Text)
        unDossier.infoClient.setCivilite(cbxIdent.Text)

        Dim temp As String
        temp = cbxVdr.Text
        unDossier.infoVendeur.setNomVendeur(temp)


        '
        ' writexml()
        '
        MsgBox("c'est enregistré")
    End Sub

    Private Sub cmdVoiture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVoiture.Click
        '
        ' affichage de la fenetre du bien
        '
        If fenSaisieBien Is Nothing Then
            fenSaisieBien = New frmSaisieBien
        End If

        frmSaisieBien.Show()
        '
        ' Me.Close()

        Me.Dispose()


    End Sub

    Private Sub txtNom_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNom.GotFocus
        If txtNom.Text.Contains("Saisir le nom") Then
            txtNom.Text = ""
        End If
    End Sub

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged

    End Sub

    Private Sub txtAncVhc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAncVhc.TextChanged

    End Sub

    Private Sub gbpAge_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbpAge.Enter

    End Sub

    Private Sub BtnDossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDossier.Click
        Me.Dispose()

        frmDossier.Show()
    End Sub

    Private Sub txtPrenom_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrenom.GotFocus
        If txtPrenom.Text.Contains("Saisir le prenom") Then
            txtPrenom.Text = ""
        End If
    End Sub
End Class
