Module ModuleTest
    Public Sub TestDossier()

        Dim unDossier As New Dossier
        Dim resultat As Double

        unDossier.LaDuree = 1
        unDossier.LeTaux = 15
        unDossier.LeMontant = 10000

        resultat = unDossier.getMensualite(unDossier.LaDuree, unDossier.LeMontant, unDossier.LeTaux)
        resultat = Math.Floor(resultat)

        Debug.Assert(resultat = 10125, "ça marche pas, vérifié la fonction getMensualité()")

    End Sub
    


End Module
