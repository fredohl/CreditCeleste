Public Class Voiture
    '
    Private monNomVehicule As String    ' nom du nouveau véhicule
    Private monAgeVéhicule As String      ' Age du véhicule
    Private monAncienVéhicule As String    ' nom de l'ancien véhicule
    Private monDate1ereImmatriculation As String ' Date   ' date de 1ère immatriculation
    Private monAnnéeModèle As Integer            ' année modèle (millésime au 1 juillet)
    Private monNumImmat As String            ' numéro d'immatriculation     
    Private monNumeroSerie As String              ' numéro de série
    Private monPuisChevaux As Integer

    
    Sub New()
        ' constructeur

    End Sub

    Sub New(ByVal NouveauNomVéhicule As String)
        ' constructeur
        monNomVehicule = NouveauNomVéhicule


    End Sub
    Sub setAncienVehicule(ByVal AncienNomVehicule As String)

        monAncienVéhicule = AncienNomVehicule

    End Sub
    Function getAncienVehicule() As String

        Return (monAncienVéhicule)

    End Function
    Sub setNomVéhicule(ByVal NouveauNomVéhicule As String)
        ' constructeur
        monNomVehicule = NouveauNomVéhicule


    End Sub

    Function getNomVéhicule() As String

        Return (monNomVehicule)

    End Function
    Public Sub setAge(ByVal age As String)

        monAgeVéhicule = age

    End Sub

    Function getAge() As String

        getAge = monAgeVéhicule

    End Function

    Public Sub setbien(ByVal d1èreImmat As String, ByVal anneeMod As Integer, ByVal numImmat As String, ByVal numSerie As String, ByVal puiss As Integer)

        monDate1ereImmatriculation = d1èreImmat
        monAnnéeModèle = anneeMod
        monNumImmat = numImmat
        monNumeroSerie = numSerie
        monPuisChevaux = puiss

    End Sub

    Function get1ereImmat() As String ' Date

        Return (monDate1ereImmatriculation)

    End Function


    Function getNumImmat() As String

        Return (monNumImmat)

    End Function

    Function getAnnéeModèle() As Integer

        Return (monAnnéeModèle)

    End Function


    Function getNumeroSerie() As String

        Return (monNumeroSerie)

    End Function

    Function getPuisChevaux() As Integer

        Return (monPuisChevaux)

    End Function

End Class
