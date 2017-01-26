Public Class frmInscription
        Private _joueurs As Dictionary(Of String, Joueur)
        Private _cle As String
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtpsw1.Text = "" OrElse txtpsw2.Text = "" OrElse txtlogin.Text = "" Then
            lblerreurGeneral.Text = "Toutes les cases doivent être remplies"
            lblLoginErreur.Text = ""
            lblMdpErreur.Text = ""

        elseif _joueurs.Containskey(txtlogin.Text) Then
            lblLoginErreur.Text = "Ce nom d'utilisateur existe déjà"
            txtpsw1.Text = ""
            txtpsw2.Text = ""
            lblMdpErreur.Text = ""
            lblerreurGeneral.Text = ""
        Else
            If txtpsw1.Text = txtpsw2.Text Then
                _joueurs.Add(txtlogin.Text, New Joueur(txtlogin.Text, txtpsw1.Text))
                _cle = txtlogin.Text
                Me.DialogResult = DialogResult.OK
            Else
                lblMdpErreur.Text = "Les mots de passe ne concorde pas."
                lblLoginErreur.Text = ""
                lblerreurGeneral.Text = ""  
                txtpsw1.Text = ""
                txtpsw2.Text = "" 
            End If
        End If
    End Sub

    Public Sub New(pjoueurs As Dictionary(Of String, Joueur))
        _joueurs = pjoueurs
        InitializeComponent()
    End Sub

    Public Function DonnerCle() As String
        Return _cle
    End Function
End Class