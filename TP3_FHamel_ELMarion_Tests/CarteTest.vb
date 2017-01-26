Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP3_FHamel_ELMarion


<TestClass()> Public Class CarteTest

    <TestMethod()> Public Sub CreerCarte()
        Dim neufPique As New Carte(9, Sorte.Pique)
        Assert.IsNotNull(neufPique)
        Assert.AreEqual(neufPique.Valeur, 9)
        Assert.AreEqual(neufPique.SorteCarte, Sorte.Pique)
    End Sub

End Class