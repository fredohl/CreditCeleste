Imports clientCs


Public Class Concession

    Private monNomConcession As String
    Private monAdresseConcession As String

    Public LesVendeurs As New List(Of Vendeur)
    Public lesVoitures As New List(Of Voiture)
    Public lesClients As New List(Of ClientVoit)


    Sub New()

    End Sub
    Sub New(ByVal nomConcession As String, ByVal adresseConcession As String)
        ' constructeur
        monNomConcession = nomConcession
        monAdresseConcession = adresseConcession
        lesVoitures = Nothing

        ' constructeur
    End Sub

    Sub New(ByVal nomConcession As String, ByVal adresseConcession As String, ByVal lesVdrSaisis As List(Of Vendeur))
        ' constructeur
        monNomConcession = nomConcession
        monAdresseConcession = adresseConcession
        LesVendeurs = lesVdrSaisis
        ' constructeur
    End Sub

End Class
