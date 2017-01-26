Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP3_FHamel_ELMarion
'Imports System.Drawing.Bitmap

<TestClass()> Public Class JeuTest
    <TestMethod()> Public Sub NouvellePartie()
        Dim partie As New Jeu()
        partie.Joueur1 = New Joueur("bob", "12")
        partie.Joueur2 = New Joueur("bob2", "12")
        partie.NouvellePartie()
        Assert.IsNotNull(partie.Joueur1)
        Assert.IsNotNull(partie.Joueur1)
        Assert.AreEqual(partie.PileJeuCarteComplet.Count, 0)
        Assert.AreEqual(partie.Joueur1.Deck.Count, 26)
        Assert.AreEqual(partie.Joueur2.Deck.Count, 26)
    End Sub

    <TestMethod()> Public Sub CreerJeuDeCarte()
        Dim partie As New Jeu()
        partie.CreerJeuDeCarte()
        Assert.AreEqual(partie.PileJeuCarteComplet.Count, 52)

        Dim nbneufPique As Integer
        Dim nbNeuf As Integer
        For Each elem In partie.PileJeuCarteComplet.ToList
            If elem.Valeur = 9 Then
                nbNeuf += 1
                If elem.SorteCarte = Sorte.Pique AndAlso elem.Valeur = 9 Then
                    nbneufPique += 1
                End If
            End If
        Next
        Assert.AreEqual(nbNeuf, 4)
        Assert.AreEqual(nbneufPique, 1)
    End Sub
    <TestMethod()> Public Sub BrasserLesCartes()
        Dim partie As New Jeu()
        Dim autrejeuCartes As New Stack(Of Carte)
        Dim uneliste As New List(Of Carte)
        Dim Sibrasser As Boolean
        autrejeuCartes.Push(New Carte(2, sorte.Pique))
        autrejeuCartes.Push(New Carte(3, sorte.Pique))
        autrejeuCartes.Push(New Carte(4, sorte.Pique))
        autrejeuCartes.Push(New Carte(5, sorte.Pique))
        autrejeuCartes.Push(New Carte(6, sorte.Pique))
        autrejeuCartes.Push(New Carte(7, sorte.Pique))

        
        partie.Shuffle(autrejeuCartes)

        For index = 1 To autrejeuCartes.Count
            uneliste.Add(autrejeuCartes.Pop)
        Next
        If uneliste(0).Valeur <> 2 AndAlso uneliste(1).Valeur <> 3 AndAlso uneliste(2).Valeur <> 4 AndAlso uneliste(3).Valeur <> 5 AndAlso uneliste(4).Valeur <> 6 AndAlso uneliste(5).Valeur <> 7 Then
            Sibrasser = False
        Else
            Sibrasser = True
        End If

        Assert.AreEqual(Sibrasser, True)
    End Sub
    <TestMethod()> Public Sub DistribuerCartes()
        Dim partie As New Jeu()
        partie.Joueur1 = New Joueur("bob", "12")
        partie.Joueur2 = New Joueur("bob2", "12")

        partie.CreerJeuDeCarte()
        partie.DistribuerCarte(partie.PileJeuCarteComplet)
        Assert.AreEqual(partie.Joueur1.Deck.Count, 26)
        Assert.AreEqual(partie.Joueur2.Deck.Count, 26)

        Dim autrePartie As New Jeu()
        autrePartie.Joueur1 = New Joueur("bob", "12")
        autrePartie.Joueur2 = New Joueur("bob2", "12")
        Dim autrejeuCartes As New Stack(Of Carte)
        autrejeuCartes.Push(New Carte(2, sorte.Pique))
        autrejeuCartes.Push(New Carte(3, sorte.Pique))
        autrejeuCartes.Push(New Carte(4, sorte.Pique))
        autrejeuCartes.Push(New Carte(5, sorte.Pique))
        autrePartie.DistribuerCarte(autrejeuCartes)

        Assert.AreEqual(autrePartie.Joueur1.Deck.Peek.Valeur, 3)
        Assert.AreEqual(autrePartie.Joueur2.Deck.Peek.Valeur, 2)
        Assert.AreEqual(autrePartie.Joueur1.Deck.Peek.SorteCarte, sorte.Pique)
        Assert.AreEqual(autrePartie.Joueur2.Deck.Peek.SorteCarte, sorte.Pique)
    End Sub

    <TestMethod()> Public Sub TournerCarte()
        Dim partie As New Jeu()
        partie.Joueur1 = New Joueur("bob", "12")
        partie.Joueur2 = New Joueur("bob2", "12")
        partie.Joueur1.Deck.Push(New Carte(4, sorte.Pique))
        partie.Joueur2.Deck.Push(New Carte(5, sorte.Coeur))

        Assert.AreEqual(Partie.Joueur1.Deck.Peek.Valeur, 4)
        Assert.AreEqual(Partie.Joueur2.Deck.Peek.Valeur, 5)
        Assert.AreEqual(Partie.Joueur1.Deck.Peek.SorteCarte, sorte.Pique)
        Assert.AreEqual(Partie.Joueur2.Deck.Peek.SorteCarte, sorte.Coeur)

        partie.TournerCarte()

        Assert.AreEqual(Partie.Joueur1.WinDeck.Peek.Valeur, 4)
        Assert.AreEqual(Partie.Joueur2.WinDeck.Peek.Valeur, 5)
        Assert.AreEqual(Partie.Joueur1.WinDeck.Peek.SorteCarte, sorte.Pique)
        Assert.AreEqual(Partie.Joueur2.WinDeck.Peek.SorteCarte, sorte.Coeur)


        partie.Joueur1.Deck.Push(New Carte(8, sorte.Pique))
        partie.Joueur2.Deck.Push(New Carte(9, sorte.Coeur))

        partie.Bataille = True
        partie.TournerCarte()

        Assert.AreEqual(partie.PileBatailleEnCours1.Peek.Valeur, 8)
        Assert.AreEqual(Partie.PileBatailleEnCours2.Peek.Valeur, 9)
        Assert.AreEqual(Partie.PileBatailleEnCours1.Peek.SorteCarte, sorte.Pique)
        Assert.AreEqual(Partie.PileBatailleEnCours2.Peek.SorteCarte, sorte.Coeur)

    End Sub
    <TestMethod()> Public Sub DeclancherBataille()
        Dim partie As New Jeu()
        partie.Joueur1 = New Joueur("bob", "12")
        partie.Joueur2 = New Joueur("bob2", "12")
        partie.Joueur1.Deck.Push(New Carte(5, sorte.Pique))
        partie.Joueur2.Deck.Push(New Carte(5, sorte.Coeur))

        partie.TournerCarte()
        partie.DeroulementNormal()
        Assert.IsTrue(partie.Bataille)
        Assert.AreEqual(Partie.FileBatailleEnAttente1.Count, 1)
        Assert.AreEqual(Partie.FileBatailleEnAttente2.Count, 1)

        Dim autrePartie As New Jeu()
        autrePartie.Joueur1 = New Joueur("bob", "12")
        autrePartie.Joueur2 = New Joueur("bob2", "12")
        autrePartie.Joueur1.Deck.Push(New Carte(2, sorte.Pique))
        autrePartie.Joueur2.Deck.Push(New Carte(3, sorte.Coeur))
        autrePartie.Joueur1.Deck.Push(New Carte(6, sorte.Pique))
        autrePartie.Joueur2.Deck.Push(New Carte(8, sorte.Coeur))

        autrePartie.TournerCarte()
        autrePartie.DeroulementNormal()
        Assert.IsFalse(autrePartie.Bataille)
        autrePartie.TournerCarte()
        autrePartie.DeroulementNormal()
        Assert.IsFalse(autrePartie.Bataille)
    End Sub

    <TestMethod()> Public Sub TestDeroullementBataille()
        Dim partie As New Jeu()
        partie.Joueur1 = New Joueur("bob", "12")
        partie.Joueur2 = New Joueur("bob2", "12")
        partie.PileBatailleEnCours1.Push(New Carte(8, Sorte.Pique))
        partie.PileBatailleEnCours2.Push(New Carte(9, Sorte.Coeur))
        partie.FileBatailleEnAttente1.Enqueue(New Carte(8, Sorte.Treffle))
        partie.FileBatailleEnAttente2.Enqueue(New Carte(8, Sorte.Carreau))

        partie.Joueur1.KeyPressAccept = False
        partie.Joueur2.KeyPressAccept = False
        partie.DeroulementAvecBataille()

        Assert.IsTrue(partie.Joueur1.KeyPressAccept)
        Assert.IsTrue(partie.Joueur2.KeyPressAccept)


        Dim partie2 As New Jeu()
        partie2.Joueur1 = New Joueur("bob", "12")
        partie2.Joueur2 = New Joueur("bob2", "12")
        partie2.PileBatailleEnCours1.Push(New Carte(7, Sorte.Pique))
        partie2.PileBatailleEnCours2.Push(New Carte(9, Sorte.Coeur))
        partie2.FileBatailleEnAttente1.Enqueue(New Carte(8, Sorte.Treffle))
        partie2.FileBatailleEnAttente2.Enqueue(New Carte(8, Sorte.Carreau))
        partie2.Joueur1.KeyPressAccept = False
        partie2.Joueur2.KeyPressAccept = False
        partie2.DeroulementAvecBataille()

        Assert.IsFalse(partie2.Joueur1.KeyPressAccept)
        Assert.IsFalse(partie2.Joueur2.KeyPressAccept)

        Dim partie3 As New Jeu()
        partie3.Joueur1 = New Joueur("bob", "12")
        partie3.Joueur2 = New Joueur("bob2", "12")
        partie3.PileBatailleEnCours1.Push(New Carte(9, Sorte.Pique))
        partie3.PileBatailleEnCours2.Push(New Carte(9, Sorte.Coeur))
        partie3.FileBatailleEnAttente1.Enqueue(New Carte(8, Sorte.Treffle))
        partie3.FileBatailleEnAttente2.Enqueue(New Carte(8, Sorte.Carreau))
        partie3.Joueur1.KeyPressAccept = False
        partie3.Joueur2.KeyPressAccept = False
        partie3.DeroulementAvecBataille()

        Assert.IsFalse(partie3.Joueur1.KeyPressAccept)
        Assert.IsFalse(partie3.Joueur2.KeyPressAccept)
        Assert.AreEqual(partie3.FileBatailleEnAttente1.Count, 2)
        Assert.AreEqual(partie3.FileBatailleEnAttente2.Count, 2)

        Dim partie4 As New Jeu()
        partie4.Joueur1 = New Joueur("bob", "12")
        partie4.Joueur2 = New Joueur("bob2", "12")
        partie4.PileBatailleEnCours1.Push(New Carte(8, Sorte.Pique))
        partie4.PileBatailleEnCours2.Push(New Carte(8, Sorte.Coeur))
        partie4.FileBatailleEnAttente1.Enqueue(New Carte(8, Sorte.Treffle))
        partie4.FileBatailleEnAttente2.Enqueue(New Carte(8, Sorte.Carreau))

        partie4.Joueur1.KeyPressAccept = False
        partie4.Joueur2.KeyPressAccept = False
        partie4.DeroulementAvecBataille()

        Assert.IsTrue(partie4.TimerStop())
        Assert.IsTrue(partie4.Joueur1.KeyPressAccept)
        Assert.IsTrue(partie4.Joueur2.KeyPressAccept)
    End Sub

    <TestMethod()> Public Sub ViderCarteFilePileBataille()
        Dim partie As New Jeu()
        partie.Joueur1 = New Joueur("bob", "12")
        partie.Joueur2 = New Joueur("bob2", "12")
        partie.PileBatailleEnCours1.Push(New Carte(8, Sorte.Pique))
        partie.PileBatailleEnCours2.Push(New Carte(9, Sorte.Coeur))
        partie.PileBatailleEnCours1.Push(New Carte(2, Sorte.Pique))
        partie.PileBatailleEnCours2.Push(New Carte(2, Sorte.Coeur))
        partie.FileBatailleEnAttente1.Enqueue(New Carte(8, Sorte.Treffle))
        partie.FileBatailleEnAttente2.Enqueue(New Carte(8, Sorte.Carreau))
        partie.FileBatailleEnAttente1.Enqueue(New Carte(11, Sorte.Treffle))
        partie.FileBatailleEnAttente2.Enqueue(New Carte(11, Sorte.Carreau))

        partie.ViderCarteFileBataille()

        Assert.AreEqual(partie.PileBatailleEnCours1.Count, 0)
        Assert.AreEqual(partie.PileBatailleEnCours2.Count, 0)
        Assert.AreEqual(partie.FileBatailleEnAttente1.Count, 0)
        Assert.AreEqual(partie.FileBatailleEnAttente1.Count, 0)

    End Sub

    <TestMethod()> Public Sub SiDeckJoueurVide()
        Dim partie As New Jeu()
        Dim uneListe As New List(Of Carte)
        Dim SiBrasser As Boolean
        partie.Joueur1 = New Joueur("bob", "12")
        partie.Joueur1.WinDeck.Push(New Carte(2, Sorte.Carreau))
        partie.Joueur1.WinDeck.Push(New Carte(3, Sorte.Carreau))
        partie.Joueur1.WinDeck.Push(New Carte(4, Sorte.Carreau))
        partie.Joueur1.WinDeck.Push(New Carte(5, Sorte.Carreau))
        Assert.AreEqual(partie.Joueur1.Deck.Count, 0)
        Assert.AreEqual(partie.Joueur1.WinDeck.Peek.Valeur, 5)
        Assert.AreEqual(partie.Joueur1.WinDeck.Count, 4)
        partie.SiDeckJoueurVide(partie.Joueur1)
        Assert.AreEqual(partie.Joueur1.WinDeck.Count, 0)
        Assert.AreEqual(partie.Joueur1.Deck.Count, 4)

        For index = 1 To partie.Joueur1.Deck.Count
            uneListe.Add(partie.Joueur1.Deck.Pop)
        Next
        If uneListe(0).Valeur <> 5 AndAlso uneListe(1).Valeur <> 4 AndAlso uneListe(2).Valeur <> 3 AndAlso uneListe(3).Valeur <> 2 Then
            SiBrasser = False
        Else
            SiBrasser = True
        End If
        Assert.IsTrue(SiBrasser)
    End Sub

    <TestMethod()> Public Sub PartieGagnee()
        Dim partie As New Jeu()
        partie.Joueur1 = New Joueur("bob", "12")
        partie.Joueur2 = New Joueur("bob2", "12")
        partie.Joueur1.Deck.Push(New Carte(2, Sorte.Carreau))
        partie.Joueur1.Deck.Push(New Carte(3, Sorte.Carreau))
        partie.Joueur2.Deck.Push(New Carte(4, Sorte.Carreau))
        partie.Joueur2.Deck.Push(New Carte(5, Sorte.Carreau))
        Assert.IsFalse(partie.PartieGagnee())

        Dim partie2 As New Jeu()
        partie2.Joueur1 = New Joueur("bob", "12")
        partie2.Joueur2 = New Joueur("bob2", "12")
        partie2.Joueur1.WinDeck.Push(New Carte(2, Sorte.Carreau))
        partie2.Joueur1.WinDeck.Push(New Carte(3, Sorte.Carreau))
        partie2.Joueur2.WinDeck.Push(New Carte(4, Sorte.Carreau))
        partie2.Joueur2.WinDeck.Push(New Carte(5, Sorte.Carreau))
        Assert.IsFalse(partie2.PartieGagnee())

        Dim partie3 As New Jeu()
        partie3.Joueur1 = New Joueur("bob", "12")
        partie3.Joueur2 = New Joueur("bob2", "12")
        partie3.Joueur1.Deck.Push(New Carte(2, Sorte.Carreau))
        partie3.Joueur1.Deck.Push(New Carte(3, Sorte.Carreau))
        partie3.Joueur2.WinDeck.Push(New Carte(4, Sorte.Carreau))
        partie3.Joueur2.WinDeck.Push(New Carte(5, Sorte.Carreau))
        Assert.IsFalse(partie3.PartieGagnee())

        Dim partie4 As New Jeu()
        partie4.Joueur1 = New Joueur("bob", "12")
        partie4.Joueur2 = New Joueur("bob2", "12")
        partie4.Joueur2.WinDeck.Push(New Carte(4, Sorte.Carreau))
        partie4.Joueur2.WinDeck.Push(New Carte(5, Sorte.Carreau))
        Assert.IsTrue(partie4.PartieGagnee())

        Dim partie5 As New Jeu()
        partie5.Joueur1 = New Joueur("bob", "12")
        partie5.Joueur2 = New Joueur("bob2", "12")
        partie5.Joueur2.Deck.Push(New Carte(4, Sorte.Carreau))
        partie5.Joueur2.Deck.Push(New Carte(5, Sorte.Carreau))
        Assert.IsTrue(partie5.PartieGagnee())

    End Sub

    <TestMethod()> Public Sub JoueurGagnantLaBataille()
        Dim partie As New Jeu()
        partie.Joueur1 = New Joueur("bob", "12")
        partie.Joueur2 = New Joueur("bob2", "12")
        partie.PileBatailleEnCours1.Push(New Carte(6, Sorte.Pique))
        partie.PileBatailleEnCours2.Push(New Carte(9, Sorte.Coeur))
        partie.FileBatailleEnAttente1.Enqueue(New Carte(8, Sorte.Treffle))
        partie.FileBatailleEnAttente2.Enqueue(New Carte(8, Sorte.Carreau))

        partie.Joueur1.KeyPressAccept = False
        partie.Joueur2.KeyPressAccept = False
        Assert.IsFalse(partie.JoueurGagnantLaBataille(partie.Joueur1))
        Assert.AreEqual(partie.Joueur1.KeyPressEarlyTimer, 3)


        Dim partie2 As New Jeu()
        partie2.Joueur1 = New Joueur("bob", "12")
        partie2.Joueur2 = New Joueur("bob2", "12")
        partie2.PileBatailleEnCours1.Push(New Carte(8, Sorte.Pique))
        partie2.PileBatailleEnCours2.Push(New Carte(9, Sorte.Coeur))
        partie2.FileBatailleEnAttente1.Enqueue(New Carte(8, Sorte.Treffle))
        partie2.FileBatailleEnAttente2.Enqueue(New Carte(8, Sorte.Carreau))

        partie.Joueur1.KeyPressAccept = True
        partie.Joueur1.KeyPressEarlyTimer = 0
        Assert.IsTrue(partie.JoueurGagnantLaBataille(partie.Joueur1))
        Assert.AreEqual(partie.Joueur1.WinDeck.Count, 4)
    End Sub


End Class