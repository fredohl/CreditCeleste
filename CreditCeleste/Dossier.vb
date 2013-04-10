Imports clientCs
Public Class Dossier

    Private numDossier As Integer
    Private montant As Double
    Private durée As Integer
    Private mensualité As Double
    Private taux As Double
    Private pourentComm As Double
    Private positionDossier As String
    Private leVdr As New Vendeur
    Private leClt As New ClientVoit


    Public Sub New()

    End Sub


    Function RecupClient()
        Return (leClt.getCivilite + leClt.getNomClient + leClt.getPrenomClient)

    End Function

    Function PositionScoringConnexion(ByVal unClient As clientCs.Client)

        Return ("acceptée")
        ' A changer par la suite

    End Function


    Function getPositionScoring()

        Return (positionDossier)

    End Function


    Function getCodeVendeur()

        Return (leVdr.getNomVendeur)

    End Function


    Function getMensualite()

        Return (mensualité)

    End Function

    Function getMensualite(ByVal uneDurée, ByVal unMontantFinancé, Optional ByVal unTaux = 12)

        Dim Men As Double
        taux = unTaux / 100
        Men = (unMontantFinancé * (taux / 12) / (1 - (1 + taux / 12) ^ -uneDurée))

        Return (Men)

    End Function



    Property LaDuree() As String
        Get
            Return durée
        End Get
        Set(ByVal uneDuree As String)
            durée = uneDuree
        End Set
    End Property

    Property LeMontant() As String
        Get
            Return montant
        End Get
        Set(ByVal unMontant As String)
            montant = unMontant
        End Set
    End Property
    Property infoVendeur() As Vendeur
        Get
            Return leVdr
        End Get
        Set(ByVal unVDR As Vendeur)
            leVdr = unVDR

        End Set
    End Property

    Property LeTaux() As Double
        Get
            Return taux
        End Get
        Set(ByVal unTaux As double)
            taux = unTaux

        End Set
    End Property

    Property infoClient() As ClientVoit
        Get
            Return leClt
        End Get
        Set(ByVal unClient As ClientVoit)
            unClient = leClt

        End Set
    End Property

    Property LeNumero() As String
        Get
            Return numDossier
        End Get
        Set(ByVal unNumero As String)
            numDossier = unNumero
        End Set
    End Property

    Property PositionDuDossier() As String
        Get
            Return positionDossier
        End Get
        Set(ByVal unePosition As String)
            positionDossier = unePosition
        End Set
    End Property

End Class
