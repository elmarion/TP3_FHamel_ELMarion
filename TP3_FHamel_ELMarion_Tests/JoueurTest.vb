Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP3_FHamel_ELMarion

<TestClass()> Public Class JoueurTest

    <TestMethod()> Public Sub CreerJoueur()
        Dim unJoueur As New Joueur("Jean", "123")
        Assert.IsNotNull(unJoueur)
        Assert.AreEqual(unJoueur.Login, "Jean")
        Assert.AreEqual(unJoueur.Psw, "123")
        Assert.AreEqual(unJoueur.NbPartieGagnee, 0)
        Assert.AreEqual(unJoueur.NbPartiePerdue, 0)
        Assert.AreEqual(unJoueur.Deck.Count, 0)
        Assert.AreEqual(unJoueur.WinDeck.Count, 0)
    End Sub

    <TestMethod()> Public Sub ViderCarte()
        Dim unJoueur As New Joueur("Jean", "123")
        Dim neufPique As New Carte(9, Sorte.Pique)
        unJoueur.Deck.Push(neufPique)
        Assert.AreEqual(unJoueur.Deck.Count, 1)
        unJoueur.WinDeck.Push(neufPique)
        Assert.AreEqual(unJoueur.WinDeck.Count, 1)
        unJoueur.ViderCarte()
        Assert.AreEqual(unJoueur.Deck.Count, 0)
        Assert.AreEqual(unJoueur.WinDeck.Count, 0)
    End Sub

End Class