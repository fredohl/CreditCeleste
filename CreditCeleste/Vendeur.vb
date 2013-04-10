Public Class Vendeur

    Private monIdtVendeur As String
    Private monNomVendeur As String
    Private monPrenomVendeur As String


    Sub New()

    End Sub

    Sub New(ByVal idtVendeur As String, ByVal prenomVendeur As String, ByVal nomVendeur As String)
        monIdtVendeur = idtVendeur
        monPrenomVendeur = prenomVendeur
        monNomVendeur = nomVendeur
    End Sub
    Sub setVendeur(ByVal idtVendeur As String, ByVal prenomVendeur As String, ByVal nomVendeur As String)
        monIdtVendeur = idtVendeur
        monPrenomVendeur = prenomVendeur
        monNomVendeur = nomVendeur
    End Sub
    Sub setIdtVendeur(ByVal idtVendeur As String)
        ' 
        monIdtVendeur = idtVendeur
    End Sub

    Function getIdtVendeur()

        Return (monIdtVendeur)

    End Function


    Sub setPrenomVendeur(ByVal prenomVendeur As String)
        ' 
        monPrenomVendeur = prenomVendeur

    End Sub

    Sub setNomVendeur(ByVal nomVendeur As String)
        ' 
        monNomVendeur = nomVendeur

    End Sub

    Function getNomVendeur() As String

        Return (monNomVendeur)

    End Function

    Function getInfoVendeur() As String

        ' Return (monIdtVendeur + monNomVendeur + monPrenomVendeur)  ' donner d'abord cette forme, pour le corriger

        Return (monIdtVendeur + " " + monNomVendeur + " " + monPrenomVendeur)


    End Function

    '' en utilisant une propriété
    '
    Property nomVendeur() As String
        Get
            Return monNomVendeur
        End Get
        Set(ByVal Value As String)
            monNomVendeur = Value
        End Set
    End Property
End Class



