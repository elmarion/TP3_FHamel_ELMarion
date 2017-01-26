Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class frmPrincipal
    Private unePartie As New Jeu()
    Private _joueurs As New Dictionary(Of String, Joueur)
    Private _partieEncours As Boolean
    Private _lstInsulte As New List(Of String)

    Private Sub btnJoueur1_Click(sender As Object, e As EventArgs) Handles btnJoueur1.Click
        Dim continuepartie As Integer
        Dim frmLogin As frmLogin
        Dim AjouterJoueur As Boolean = True

        If _partieEncours Then
            TimerTour.Stop()
            continuepartie = MessageBox.Show("Voulez-vous Arrêter la partie en cours et choisir un autre joueur?", "Attention!", MessageBoxButtons.YesNo)
            If continuepartie = DialogResult.No Then
                AjouterJoueur = False
                TimerTour.Start()
            End If
        End If

        If AjouterJoueur Then
            frmLogin = New frmLogin(_joueurs)
            If frmLogin.ShowDialog() = DialogResult.OK Then
                unePartie.Joueur1 = frmLogin.DonnerJoueur()
                lblNomJoueur1.Text = unePartie.Joueur1.Login
            End If
        End If

    End Sub

    Private Sub btnJoueur2_Click(sender As Object, e As EventArgs) Handles btnJoueur2.Click
        Dim continuepartie As Integer
        Dim frmLogin As frmLogin
        Dim AjouterJoueur As Boolean = True

        If _partieEncours Then
            TimerTour.Stop()
            continuepartie = MessageBox.Show("Voulez-vous Arrêter la partie en cours et choisir un autre joueur?", "Attention!", MessageBoxButtons.YesNo)
            If continuepartie = DialogResult.No Then
                TimerTour.Start()
                AjouterJoueur = False
            End If
        End If

        frmLogin = New frmLogin(_joueurs)
        frmLogin.lblJoueur.Text = "Joueur 2"
        If frmLogin.ShowDialog() = DialogResult.OK Then
            unePartie.Joueur2 = frmLogin.DonnerJoueur()
            lblNomJoueur2.Text = unePartie.Joueur2.Login
        End If
    End Sub

    Private Sub btnNewPartie_Click(sender As Object, e As EventArgs) Handles btnNewPartie.Click
        Dim nouvellePartie As Boolean = True
        If _partieEncours Then
            TimerTour.Stop()
            Dim continuepartie As Integer = MessageBox.Show("Voulez-vous commencer une nouvelle partie?", "Attention!", MessageBoxButtons.YesNo)
            If continuepartie = DialogResult.No Then
                nouvellePartie = False
                TimerTour.Start()
            End If
        End If
        If nouvellePartie Then
            Try
                for each elem in _joueurs
                    elem.value.ViderCarte()
                Next
                unePartie.NouvellePartie()
                pbBatailleEnCours1.Visible = False
                pbBatailleEnCours2.Visible = False
                lblErreurGeneral.Text = ""
                InitialisationElement()
                _partieEncours = True
                unePartie.Joueur1.KeyPressAccept = False
                unePartie.Joueur2.KeyPressAccept = False
                TimerTour.Start()
                pbBatailleEnAttente1.Image = Nothing
                pbBatailleEnCours1.Image = Nothing
                pbBatailleEnCours2.Image = Nothing
            Catch ex As Exception
            lblErreurGeneral.Text = ex.Message
            End Try

        End If
    End Sub

    ''' <summary>
    ''' Initialisation des elements graphiques de la page
    ''' </summary>
    private Sub InitialisationElement()
        If unePartie.Joueur1.Deck.Count = 0 Then
            pbDeck1.Image = Nothing
        Else
            pbDeck1.Image = My.Resources.ResourceManager.GetObject("b1fv")
        End If
        If unePartie.Joueur2.Deck.Count = 0 Then
            pbDeck2.Image = Nothing
        Else
            pbDeck2.Image = My.Resources.ResourceManager.GetObject("b2fv")
        End If


        If unePartie.FileBatailleEnAttente1.Count > 0 Then
            pbBatailleEnAttente1.Image = unePartie.FileBatailleEnAttente1.Peek.ImageCarte
            pbBatailleEnAttente2.Image = unePartie.FileBatailleEnAttente2.Peek.ImageCarte
        Else
            pbBatailleEnAttente1.Image = Nothing
            pbBatailleEnAttente2.Image = Nothing
        End If

        if unepartie.Joueur1.WinDeck.count > 0 then
            pbWinDeck1.Image = unePartie.Joueur1.WinDeck.Peek.ImageCarte
        else
            pbWinDeck1.Image = Nothing
        End If
        if unepartie.Joueur2.WinDeck.count > 0 then
            pbWinDeck2.Image = unePartie.Joueur2.WinDeck.Peek.ImageCarte
        else
            pbWinDeck2.Image = Nothing
        End If

        If unePartie.Joueur2.KeyPressEarlyTimer > 0 Then
            lblTimeKeyP.Text = "Bloqué: " + unePartie.Joueur2.KeyPressEarlyTimer.ToString() + " tours"
        Else
            lblTimeKeyP.Text = ""
        End If
        If unePartie.Joueur1.KeyPressEarlyTimer > 0 Then
            LblTimeKeyQ.Text = "Bloqué: " + unePartie.Joueur1.KeyPressEarlyTimer.ToString() + " tours"
        Else
            LblTimeKeyQ.Text = ""
        End If


        lblNombreCarteJ1.Text = unePartie.Joueur1.Deck.Count.ToString
        lblNombreCarteJ2.Text = unePartie.Joueur2.Deck.Count.ToString

        lblCarteJoueeJ1.Text = unePartie.Joueur1.WinDeck.Count.ToString
        lblCarteJoueeJ2.Text = unePartie.Joueur2.WinDeck.Count.ToString

        lblCarteBataille1.Text = unePartie.PileBatailleEnCours1.Count.ToString
        lblCarteBataille2.Text = unePartie.PileBatailleEnCours2.Count.ToString

        lblnombreBataille.text = unePartie.FileBatailleEnAttente1.count.tostring()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("..\..\lesJoueurs.dat") Then
            Dim fic As New FileStream("..\..\lesJoueurs.dat", FileMode.Open)
            Dim binaryReader As New BinaryFormatter
            _joueurs = binaryReader.Deserialize(fic)
            fic.Close()
        End If

        _lstInsulte.Add(", tu as une face de produit pathologique liquide")
        _lstInsulte.Add(", tu es trop lent, ou juste paresseux?")
        _lstInsulte.Add(", LOOOOOSER!!!!")
        _lstInsulte.Add(", tu viens de où, de la planète des connes?")
        _lstInsulte.Add(", t'es tellement poche que s'est insultant pour le monde poche")

        lblNomJoueur1.Text = ""
        lblNomJoueur2.Text = ""
        lblTimeKeyP.Text = ""
        LblTimeKeyQ.Text = ""

        lblNombreCarteJ1.Text = ""
        lblNombreCarteJ2.Text = ""

        lblCarteJoueeJ1.Text = ""
        lblCarteJoueeJ2.Text = ""

        lblCarteBataille1.Text = ""
        lblCarteBataille2.Text = ""

        lblnombreBataille.Text = ""
    End Sub

    Private Sub TimerTour_Tick(sender As Object, e As EventArgs) Handles TimerTour.Tick     
        InitialisationElement()
        If unePartie.Joueur1.keypressEarlyTimer > 0 Then
            unePartie.Joueur1.keypressEarlyTimer -= 1
        End If
        If unePartie.Joueur2.keyPressEarlyTimer > 0 Then
            unePartie.Joueur2.keyPressEarlyTimer -= 1
        End If
        unePartie.Joueur1.KeyPressAccept = False
        unePartie.Joueur2.KeyPressAccept = False
        if not unepartie.PartieGagnee then
                unePartie.TournerCarte()
            if Not unePartie.Bataille then
                pbBatailleEnCours1.Visible = False
                pbBatailleEnCours2.Visible = False
                pbWinDeck1.Image = unePartie.Joueur1.WinDeck.Peek.ImageCarte
                pbWinDeck2.Image = unePartie.Joueur2.WinDeck.Peek.ImageCarte
                unePartie.DeroulementNormal()
            else
                pbBatailleEnCours1.Visible = True
                pbBatailleEnCours2.Visible = True
                pbBatailleEnCours1.Image = unePartie.PileBatailleEnCours1.peek.ImageCarte
                pbBatailleEnCours2.Image = unePartie.PileBatailleEnCours2.peek.ImageCarte
                unePartie.DeroulementAvecBataille()
                if unePartie.TimerStop then
                    TimerTour.Stop()
                End If
            End If
        Else
            TimerTour.Stop()
            _partieEncours = false
            MessageBox.Show(unePartie.JoueurGagnant.Login + " a gagné la partie ! " + unePartie.JoueurPerdant.Login + _lstInsulte(rnd.Next(0, _lstInsulte.Count -1)))
        End If
    End Sub

    Private Sub frmPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        TimerTour.Stop()
        Select Case e.KeyCode
            Case Keys.Q
                If unePartie.JoueurGagnantLaBataille(unePartie.Joueur1) Then
                     if unePartie.FileBatailleEnAttente1.count = 0 then
                        pbBatailleEnAttente2.Image = Nothing
                        pbBatailleEnAttente1.Image = Nothing
                        pbBatailleEnCours1.Visible = False
                        pbBatailleEnCours2.Visible = False
                     else
                        pbBatailleEnAttente1.Image = unePartie.FileBatailleEnAttente1.peek.ImageCarte
                        pbBatailleEnAttente2.Image = unePartie.FileBatailleEnAttente2.peek.ImageCarte
                    end if
                End If
                if unePartie.TimerStop then
                    TimerTour.Stop()
                else
                    TimerTour.Start()
                End If
            Case Keys.P
                If unePartie.JoueurGagnantLaBataille(unePartie.Joueur2) Then
                     if unePartie.FileBatailleEnAttente1.count = 0 then
                        pbBatailleEnAttente2.Image = Nothing
                        pbBatailleEnAttente1.Image = Nothing
                        pbBatailleEnCours1.Visible = False
                        pbBatailleEnCours2.Visible = False
                     else
                        pbBatailleEnAttente1.Image = unePartie.FileBatailleEnAttente1.peek.ImageCarte
                        pbBatailleEnAttente2.Image = unePartie.FileBatailleEnAttente2.peek.ImageCarte
                    end if
                End If
                if unePartie.TimerStop then
                    TimerTour.Stop()
                else
                    TimerTour.Start()
                End If
        End Select
    End Sub

    Private Sub btnStatistique_Click(sender As Object, e As EventArgs) Handles btnStatistique.Click
        Dim frmStatistiques As New frmStats(_joueurs)
        frmStatistiques.ShowDialog()
    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        for each elem in _joueurs
            elem.value.ViderCarte()
        Next
        Dim fic As New FileStream("..\..\lesJoueurs.dat", FileMode.Create)
        Dim bf As New BinaryFormatter
        bf.Serialize(fic, _joueurs)
        fic.Close()
    End Sub
End Class