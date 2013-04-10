Imports System.Data.SqlClient

Public Class frmAccueil

    Private Sub cmdIntroduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIntroduction.Click

        '
        ' affichage de la fenetre du bien
        '
        If fenIntro Is Nothing Then
            fenIntro = New frmIntroduction
        End If

        fenIntro.Show()
        '
        Me.Hide()   ' c'est la première fenêtre, il ne faut pas la fermer


    End Sub

    Private Sub frmAccueil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        '
        uneConcession = New Concession("Garage des Lilas", "65 rue des rossignols")
        '
        '  on rajoute les vendeurs
        '
        'M. Armand Kreyder
        'M.Sébastien(Pasla)
        ' Mme Annie Savapa
        gestionBdd()

        'Dim unVendeur As New vendeur

        'unVendeur.setIdtVendeur("M.")
        'unVendeur.setNomVendeur("KREYDER")
        'unVendeur.setPrenomVendeur("Armand")

        'Dim unAutreVendeur As New vendeur
        'unAutreVendeur.setVendeur("M.", "PASLA", "Sébastien")
        ''
        'Dim encoreUnAutreVendeur As New vendeur("Mme", "SAVAPA", "Annie")
        ''
        'uneConcession.lesVendeurs.Add(unVendeur)
        'uneConcession.lesVendeurs.Add(unAutreVendeur)
        'uneConcession.lesVendeurs.Add(encoreUnAutreVendeur)
        ''
        ''
        ''

    End Sub

    Sub gestionBdd()
        '' pour la connexion
        '    Dim strConnexion As String = "Data Source=Athena; Integrated Security=SSPI; Initial Catalog=kreyder-CreditCeleste"
        '        Dim strConnexion As String = "Data Source=172.16.12.99; Integrated Security=SSPI; Initial Catalog=kreyder-CreditCeleste"

        Dim strConnexion As String = "Data Source=172.16.12.99; User id=connEleveSio;password=mdpEleveSio; Initial Catalog=kreyder-CreditCeleste"


        '' c'est une connexion qui est sécurisé sur le réseau et par rapport à SQL
        '' deux modes de connexion : - authentification windows
        ''                           - authentification SQL (nom utilisateur SQL, mot de passe SQL)

        '' mettre en place la requete de la base de données
        '
        Dim strRequete As String = "SELECT NumVendeur, CidtVendeur, NomVendeur, PrenomVendeur FROM Vendeur"
        '
        ' on va essayer de se connecter
        '
        Try
            '
            ' on va utiliser un objet connexion'
            '
            Dim oConnexion As New SqlConnection(strConnexion)
            '
            ' on va utiliser un objet command pour executer la requete
            Dim oCommand As New SqlCommand(strRequete, oConnexion)
            '
            oConnexion.Open()  '' la base de donnée est ouverte, avec la requête ?
            '
            Dim oReader As SqlDataReader = oCommand.ExecuteReader
            '

            '
            While oReader.Read()   ' lecture d'un enregistrement
                ' Console.WriteLine(oReader.GetInt32(0)) ' lecture de la première cellule

                '  Dim unVendeur As New vendeur
                '  unVendeur.setVendeur(Trim(oReader.GetString(1)), oReader.GetValue(2), oReader(3))
                Dim unVendeur As New Vendeur(Trim(oReader.GetString(1)), oReader.GetValue(2), oReader(3))

                uneConcession.LesVendeurs.Add(unVendeur)
                '
                ' unVendeur = Nothing
                '
            End While

            oReader.Close()
            oConnexion.Close()

        Catch e As Exception

            Console.WriteLine("l'erreur suivante a été rencontrée: " + e.Message)

        End Try

        Dim rep As String = Console.ReadLine()  '' system("Pause")
    End Sub

    Private Sub btnDossier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossier.Click
        Try
            Me.Hide()

            frmDossier.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class