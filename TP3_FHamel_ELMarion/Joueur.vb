<Serializable>
Public Class Joueur

    Private _deck As Stack(Of Carte)
    Private _winDeck As Stack(Of Carte)
    Private _login As String
    Private _psw As String
    Private _nbPartieGagnee As Integer
    Private _nbPartiePerdue As Integer
    Private _ratioVictoireDefaite As Double
    Private _keyPressEarlyTimer As Integer
    Private _keyPessAccept As Boolean

#Region "Get|Set"
    Public Property Ratio() As Double
        Get
            _ratioVictoireDefaite = _nbPartieGagnee / NbPartiePerdue
            Return _ratioVictoireDefaite
        End Get
        Set(ByVal value As Double)
            _ratioVictoireDefaite = value
        End Set
    End Property
    Public Property NbPartiePerdue() As Integer
        Get
            Return _nbPartiePerdue
        End Get
        Set(ByVal value As Integer)
            _nbPartiePerdue = value
        End Set
    End Property
    Public Property NbPartieGagnee() As Integer
        Get
            Return _nbPartieGagnee
        End Get
        Set(ByVal value As Integer)
            _nbPartieGagnee = value
        End Set
    End Property
    Public Property Psw() As String
        Get
            Return _psw
        End Get
        Set(ByVal value As String)
            _psw = value
        End Set
    End Property
    Public Property Login() As String
        Get
            Return _login
        End Get
        Set(ByVal value As String)
            _login = value
        End Set
    End Property
    Public Property WinDeck() As Stack(Of Carte)
        Get
            Return _winDeck
        End Get
        Set(ByVal value As Stack(Of Carte))
            _winDeck = value
        End Set
    End Property
    Public Property Deck() As Stack(Of Carte)
        Get
            Return _deck
        End Get
        Set(ByVal value As Stack(Of Carte))
            _deck = value
        End Set
    End Property

    Public Property KeyPressAccept() As Boolean
        Get
            Return _keyPessAccept
        End Get
        Set(ByVal value As Boolean)
            _keyPessAccept = value
        End Set
    End Property

    Public Property KeyPressEarlyTimer() As Integer
        Get
            Return _keypressEarlyTimer
        End Get
        Set(ByVal value As Integer)
            _keypressEarlyTimer = value
        End Set
    End Property

#End Region

    Public Sub New(pLogin As String, pPsw As String)
        Login = pLogin
        Psw = pPsw
        Deck = New Stack(Of Carte)
        WinDeck = New Stack(Of Carte)
        NbPartieGagnee = 0
        NbPartiePerdue = 0
        KeyPressAccept = false
        KeyPressEarlyTimer = 0
    End Sub

    ''' <summary>
    ''' Permet de vider Toutes les cartes du joueur
    ''' </summary>
    Public Sub ViderCarte()
        dim nbrCarteDeck As Integer = Deck.Count
        dim nbrCarteWinDeck As Integer = WinDeck.Count

        For index = 1 To nbrCarteDeck
            Deck.Pop
        Next
        For index = 1 To nbrCarteWinDeck
            WinDeck.Pop
        Next
    End Sub


    Public Overrides Function ToString() As String
	    Return String.Format(me.Login + " --> Parties gagnées : " + me.NbPartieGagnee.ToString + ",  Parties perdues : " + me.NbPartiePerdue.ToString)
	End Function

End Class
