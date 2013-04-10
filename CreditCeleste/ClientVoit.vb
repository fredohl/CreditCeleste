Imports clientCs
Public Class ClientVoit
    Inherits Client

    Private monCivilite As String
    Private etatDossier As String
    Private monDate As String
    Private monCpNaissance
    Public saVoiture As New Voiture

    Sub setCivilite(ByVal Civilite As String)

        monCivilite = Civilite

    End Sub

    Sub setEtatDossier(ByVal unEtatDossier As String)

        etatDossier = unEtatDossier

    End Sub

    Function getCivilite()
        Return (monCivilite)
    End Function


    Sub setDateNaissance(ByVal uneDate As String)
        monDate = uneDate
    End Sub

    Function getDateNaissance()
        Return monDate
    End Function

    Sub setCpNaissance(ByVal unCP As String)
        monCpNaissance = unCP
    End Sub

    Function getCpNaissance()
        Return monCpNaissance
    End Function


End Class
