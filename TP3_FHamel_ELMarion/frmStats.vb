Public Class frmStats
    Private _joueurs As Dictionary(Of String, Joueur)
    Public Sub New(pjoueurs As Dictionary(Of String, Joueur))
        _joueurs = pjoueurs
        InitializeComponent()
    End Sub
    Private Sub frmStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tempolstJoueurs As New List(Of Joueur)
        
        For each elem In _joueurs
            If elem.Value.NbPartieGagnee <> 0 AndAlso elem.Value.NbPartiePerdue <> 0 Then
            elem.Value.Ratio = elem.Value.NbPartieGagnee / (elem.Value.NbPartiePerdue + elem.Value.NbPartieGagnee)
            tempolstJoueurs.Add(elem.Value)
            End If
        Next
        tempolstJoueurs.Sort(Function(x,y) x.Ratio.CompareTo(y.Ratio))

        For index = tempolstJoueurs.count -1 To 0 Step -1
            lstJoueurs.Items.Add(tempolstJoueurs(index)).ToString()
        Next        
    End Sub
End Class