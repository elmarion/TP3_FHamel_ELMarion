

Public Enum Sorte
    Carreau
    Pique
    Coeur
    Treffle
End Enum

<Serializable>
Public Class Carte
    Private _valeur As Integer
    Private _sorteCarte As Sorte
    Private _imageCarte As Image

#Region "Get|Set"
    Public Property ImageCarte() As Image
        Get
            Return _imageCarte
        End Get
        Set(ByVal value As Image)
            _imageCarte = value
        End Set
    End Property
    Public Property SorteCarte() As Sorte
        Get
            Return _sorteCarte
        End Get
        Set(ByVal value As Sorte)
            _sorteCarte = value
        End Set
    End Property

    Public Property Valeur() As Integer
        Get
            Return _valeur
        End Get
        Set(ByVal value As Integer)

            If value >= 2 AndAlso value <= 14 Then
                _valeur = value
            Else
                Throw New Exception("Cette valeur n'est pas dans un jeu de carte !")
            End If
        End Set
    End Property
#End Region

    Public Sub New(pValeur As Integer, pSorte As Sorte)
        Valeur = pValeur
        SorteCarte = pSorte
        ImageCarte = My.Resources.ResourceManager.GetObject(Me.ToString())
    End Sub

    Public Overrides Function ToString() As String
        Dim chaine As String = "_"
        Select Case Valeur
            Case 11
                chaine = "V"
            Case 12
                chaine = "D"
            Case 13
                chaine = "R"
            Case 14
                chaine = "A"
            Case Else
                chaine += Valeur.ToString()
        End Select

        Select Case SorteCarte
            Case Sorte.Carreau
                chaine += "CA"
            Case Sorte.Coeur
                chaine += "CO"
            Case Sorte.Pique
                chaine += "PI"
            Case Else
                chaine += "TR"
        End Select

        Return chaine
    End Function
End Class
