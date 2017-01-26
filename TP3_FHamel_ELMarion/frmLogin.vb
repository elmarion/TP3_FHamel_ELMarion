Public Class frmLogin
    Private _joueurs As Dictionary(Of String, Joueur)
    Private _joueurLoggin As Joueur
    Private Sub btnInscrire_Click(sender As Object, e As EventArgs) Handles btnInscrire.Click
        Dim frmInscription As new frmInscription(_joueurs)
        if frmInscription.ShowDialog() = DialogResult.OK Then
            txtLogin.Text = frmInscription.DonnerCle()
            txtMdp.Focus()
        End If
    End Sub

    Public sub New(pjoueurs As Dictionary(Of String, Joueur))
        _joueurs = pjoueurs
        InitializeComponent()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtLogin.Text = "" OrElse txtMdp.Text = "" Then
            lblErreurGeneral.Text = "Toutes les cases doivent être remplies"
        ElseIf _joueurs.ContainsKey(txtLogin.Text)
            if _joueurs(txtLogin.Text).Psw = txtMdp.Text
                _joueurLoggin = _joueurs(txtLogin.Text)
                Me.DialogResult = DialogResult.OK
            End If
        Else
            lblLoginErreur.Text = "Ce compte n'existe pas"
        End If
    End Sub

    Public function DonnerJoueur As Joueur
        Return _joueurLoggin
    End function
End Class