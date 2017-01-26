Public Class Jeu
    Private _joueur1 As Joueur
    Private _joueur2 As Joueur
    Private _bataille As Boolean
    Private _fileBatailleEnAttente1 As Queue(Of Carte)
    Private _fileBatailleEnAttente2 As Queue(Of Carte)
    Private _pileBatailleEnCours1 As Stack(Of Carte)
    Private _pileBatailleEnCours2 As Stack(Of Carte)
    Private _pileJeuCarteComplet As Stack(Of Carte)
    Private _joueurGagnant As Joueur
    Private _joueurPerdant As Joueur
    Private _bTimerStop As Boolean

#Region "Get|Set"
    Public Property TimerStop() As Boolean
        Get
            Return _bTimerStop
        End Get
        Set(ByVal value As Boolean)
            _bTimerStop = value
        End Set
    End Property
    Public Property JoueurGagnant() As Joueur
        Get
            Return _joueurGagnant
        End Get
        Set(ByVal value As Joueur)
            _joueurGagnant = value
        End Set
    End Property
    Public Property JoueurPerdant() As Joueur
        Get
            Return _joueurPerdant
        End Get
        Set(ByVal value As Joueur)
            _joueurPerdant = value
        End Set
    End Property
    Public Property PileJeuCarteComplet() As Stack(Of Carte)
        Get
            Return _pileJeuCarteComplet
        End Get
        Set(ByVal value As Stack(Of Carte))
            _pileJeuCarteComplet = value
        End Set
    End Property
    Public Property PileBatailleEnCours2() As Stack(Of Carte)
        Get
            Return _pileBatailleEnCours2
        End Get
        Set(ByVal value As Stack(Of Carte))
            _pileBatailleEnCours2 = value
        End Set
    End Property
    Public Property PileBatailleEnCours1() As Stack(Of Carte)
        Get
            Return _pileBatailleEnCours1
        End Get
        Set(ByVal value As Stack(Of Carte))
            _pileBatailleEnCours1 = value
        End Set
    End Property
    Public Property FileBatailleEnAttente1() As Queue(Of Carte)
        Get
            Return _fileBatailleEnAttente1
        End Get
        Set(ByVal value As Queue(Of Carte))
            _fileBatailleEnAttente1 = value
        End Set
    End Property
    Public Property FileBatailleEnAttente2() As Queue(Of Carte)
    Get
        Return _fileBatailleEnAttente2
    End Get
    Set(ByVal value As Queue(Of Carte))
        _fileBatailleEnAttente2 = value
    End Set
    End Property
    Public Property Bataille() As Boolean
        Get
            Return _bataille
        End Get
        Set(ByVal value As Boolean)
            _bataille = value
        End Set
    End Property
    Public Property Joueur2() As Joueur
        Get
            Return _joueur2
        End Get
        Set(ByVal value As Joueur)
            _joueur2 = value
        End Set
    End Property
    Public Property Joueur1() As Joueur
        Get
            Return _joueur1
        End Get
        Set(ByVal value As Joueur)
            _joueur1 = value
        End Set
    End Property
#End Region

    Public Sub New()
        _fileBatailleEnAttente1 = New Queue(Of Carte)
        _fileBatailleEnAttente2 = New Queue(Of Carte)
        _pileBatailleEnCours1 = New Stack(Of Carte)
        _pileBatailleEnCours2 = New Stack(Of Carte)
        _pileJeuCarteComplet = New Stack(Of Carte)
    End Sub

    ''' <summary>
    ''' Crée une nouvelle partie et Efface tous des anciennes Parties
    ''' </summary>
    Public Sub NouvellePartie()
        If Joueur1 Is Nothing OrElse Joueur2 Is Nothing Then
            Throw New Exception("Vous devez sélectionner deux joueurs avant de commencer")
        ElseIf Joueur1.Login = Joueur2.Login Then
            Throw New Exception("Vous devez sélectionner deux joueurs différents avant de commencer")
        Else
            ViderCarteFileBataille()
            Bataille = false
            TimerStop = false
            CreerJeuDeCarte()
            Shuffle(PileJeuCarteComplet)
            DistribuerCarte(PileJeuCarteComplet)
        End If
    End Sub

    ''' <summary>
    ''' Permet de créer un jeu de 52 cartes complet.
    ''' </summary>
    Public Sub CreerJeuDeCarte()
        For index = 2 To 14
            PileJeuCarteComplet.Push(New Carte(index, Sorte.Carreau))
            PileJeuCarteComplet.Push(New Carte(index, Sorte.Coeur))
            PileJeuCarteComplet.Push(New Carte(index, Sorte.Pique))
            PileJeuCarteComplet.Push(New Carte(index, Sorte.Treffle))
        Next
    End Sub

    ''' <summary>
    ''' Distribut les cartes aux deux joueurs
    ''' </summary>
    ''' <param name="pileDeCarte">Prend une pile de carte</param>
    Public Sub DistribuerCarte(pileDeCarte As Stack(Of Carte))
        For index = 1 To (pileDeCarte.Count/2)
            Joueur1.Deck.Push(pileDeCarte.Pop)
            Joueur2.Deck.Push(pileDeCarte.Pop)
        Next
    End Sub

    ''' <summary>
    ''' Permet de brasser le jeu de carte
    ''' </summary>
    ''' <param name="pileDeCarte">Prend un pile de carte</param>
    Public Sub Shuffle(pileDeCarte As Stack(Of Carte))
        Dim lstCarte As New List(Of Carte)
        Dim nbrCarte As Integer = pileDeCarte.Count
        Dim nbrCarteRestante As Integer = pileDeCarte.Count - 1
        Dim indiceCarte As Integer
        For index = 1 To nbrCarte
            lstCarte.Add(pileDeCarte.Pop)
        Next

        For index = 1 To nbrCarte
            indiceCarte = rnd.Next(0, nbrCarteRestante)
            pileDeCarte.Push(lstCarte(indiceCarte))
            lstCarte.RemoveAt(indiceCarte)
            nbrCarteRestante -= 1
        Next
    End Sub

    ''' <summary>
    ''' Premet de tourner une carte à partir du Deck du joueur
    ''' La destination de la carte dépend si la partie est en état bataille
    ''' </summary>
    Public Sub TournerCarte()

        If Joueur1.Deck.Count = 0 Then
            SiDeckJoueurVide(Joueur1)
        End If
        If Joueur2.Deck.Count = 0 Then
            SiDeckJoueurVide(Joueur2)
        End If
        if Bataille then
            PileBatailleEnCours1.Push(Joueur1.Deck.Pop)
            PileBatailleEnCours2.Push(Joueur2.Deck.Pop)
        else
            Joueur1.WinDeck.Push(Joueur1.Deck.Pop)
            Joueur2.WinDeck.Push(Joueur2.Deck.Pop)
        End If
    End Sub

    ''' <summary>
    ''' Cette methode compare les cartes des deux joueurs 
    ''' pour déterminer qui remporte la carte de l'autre.
    ''' </summary>
    Public Sub DeroulementNormal()
        
        If Joueur1.WinDeck.Peek.Valeur > Joueur2.WinDeck.Peek.Valeur Then
            Joueur1.WinDeck.Push(Joueur2.WinDeck.Pop)
        ElseIf Joueur1.WinDeck.Peek.Valeur < Joueur2.WinDeck.Peek.Valeur Then
            Joueur2.WinDeck.Push(Joueur1.WinDeck.Pop)
        ElseIf Joueur1.WinDeck.Peek.Valeur = Joueur2.WinDeck.Peek.Valeur Then
            Bataille = true
            FileBatailleEnAttente1.Enqueue(Joueur1.WinDeck.Pop)
            FileBatailleEnAttente2.Enqueue(Joueur2.WinDeck.Pop)
        End If
    End Sub

    ''' <summary>
    ''' Cette methodes permet d'accepter l'entré de touche aux deux joueurs si l'une des cartes est identique à la valeur de la carte en bataille
    ''' </summary>
    Public Sub DeroulementAvecBataille()
        If PileBatailleEnCours1.Peek.Valeur = FileBatailleEnAttente1.Peek.Valeur AndAlso PileBatailleEnCours2.Peek.Valeur = FileBatailleEnAttente1.Peek.Valeur Then
            TimerStop = true
            Joueur1.KeyPressAccept = True
            Joueur2.KeyPressAccept = True
        ElseIf PileBatailleEnCours1.Peek.Valeur = PileBatailleEnCours2.Peek.Valeur Then
            FileBatailleEnAttente1.Enqueue(PileBatailleEnCours1.Pop)
            FileBatailleEnAttente2.Enqueue(PileBatailleEnCours2.Pop)
        Else
            If PileBatailleEnCours1.Peek.Valeur = FileBatailleEnAttente1.Peek.Valeur OrElse PileBatailleEnCours2.Peek.Valeur = FileBatailleEnAttente1.Peek.Valeur Then
                Joueur1.KeyPressAccept = True
                Joueur2.KeyPressAccept = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' Cette methode vide les cartes de la file et de la pile bataille
    ''' </summary>
    Public Sub ViderCarteFileBataille()
        Dim nbrCarte As Integer = FileBatailleEnAttente1.Count
        dim nbrCarte2 as integer = PileBatailleEnCours1.Count
        For index = 1 To nbrCarte
            FileBatailleEnAttente1.Dequeue()
            FileBatailleEnAttente2.Dequeue()
        Next

        For index = 1 To nbrCarte2
            PileBatailleEnCours1.Pop()
            PileBatailleEnCours2.Pop()
        Next
    End Sub


    ''' <summary>
    ''' Cette methode vérifie si le deck du joueur est vide
    ''' si oui, il brasse le sont WinDeck et le rajoute au deck
    ''' </summary>
    ''' <param name="pJoueur">Prend un joueur</param>
    Public Sub SiDeckJoueurVide(pJoueur As Joueur)

        Dim nbrCarteWindeck As Integer = pJoueur.WinDeck.Count

        For index = 1 To nbrCarteWindeck
            pJoueur.Deck.Push(pJoueur.WinDeck.Pop)
        Next
        Shuffle(pJoueur.Deck)
    End Sub

    ''' <summary>
    ''' Permet de déterminer un gagnant
    ''' </summary>
    ''' <returns>Retourne s'il a un gagnant ou non</returns>
    Public Function PartieGagnee() As Boolean
        If Joueur1.Deck.Count = 0 AndAlso Joueur1.WinDeck.Count = 0 Then
            Joueur1.NbPartiePerdue += 1
            Joueur2.NbPartieGagnee += 1
            JoueurGagnant = Joueur2
            JoueurPerdant = Joueur1
            Return True
        ElseIf Joueur2.Deck.Count = 0 AndAlso Joueur2.WinDeck.Count = 0 Then
            Joueur2.NbPartiePerdue += 1
            Joueur1.NbPartieGagnee += 1
            JoueurGagnant = Joueur1
            JoueurPerdant = Joueur2
            Return True
        End If
        Return False
    End Function


    ''' <summary>
    ''' Permet de valider si le joueur qui a appuyer sur une touche a gagné la bataille.
    ''' </summary>
    ''' <param name="unJoueur">Prend un joueur en Paramètre</param>
    ''' <returns>true si le joueur a remporté la bataille</returns>
    Public Function JoueurGagnantLaBataille(unJoueur as Joueur) as Boolean
        If unJoueur.KeyPressAccept AndAlso unJoueur.keyPressEarlyTimer = 0 Then
            TimerStop = false
            For index = 1 To PileBatailleEnCours1.Count
                unJoueur.WinDeck.Push(PileBatailleEnCours1.Pop)
                unJoueur.WinDeck.Push(PileBatailleEnCours2.Pop)
            Next
            unJoueur.WinDeck.Push(FileBatailleEnAttente1.Dequeue)
            unJoueur.WinDeck.Push(FileBatailleEnAttente2.Dequeue)
            unJoueur.KeyPressAccept = False
            unJoueur.KeyPressAccept = False

            if FileBatailleEnAttente1.count = 0 then
                Bataille = false
            End If
            return True
        Elseif unJoueur.KeyPressAccept
             TimerStop = true
             unJoueur.KeyPressEarlyTimer = 3
        else
             unJoueur.KeyPressEarlyTimer = 3
        End If
        return false
    End Function
End Class
