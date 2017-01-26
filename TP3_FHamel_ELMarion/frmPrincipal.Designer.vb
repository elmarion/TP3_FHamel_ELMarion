<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.btnJoueur1 = New System.Windows.Forms.Button()
        Me.btnJoueur2 = New System.Windows.Forms.Button()
        Me.btnNewPartie = New System.Windows.Forms.Button()
        Me.pbDeck1 = New System.Windows.Forms.PictureBox()
        Me.pbDeck2 = New System.Windows.Forms.PictureBox()
        Me.pbWinDeck2 = New System.Windows.Forms.PictureBox()
        Me.pbWinDeck1 = New System.Windows.Forms.PictureBox()
        Me.pbBatailleEnCours1 = New System.Windows.Forms.PictureBox()
        Me.lblErreurGeneral = New System.Windows.Forms.Label()
        Me.lblNomJoueur1 = New System.Windows.Forms.Label()
        Me.lblNomJoueur2 = New System.Windows.Forms.Label()
        Me.lblNombreCarteJ1 = New System.Windows.Forms.Label()
        Me.lblNombreCarteJ2 = New System.Windows.Forms.Label()
        Me.lblCarteJoueeJ1 = New System.Windows.Forms.Label()
        Me.lblCarteJoueeJ2 = New System.Windows.Forms.Label()
        Me.TimerTour = New System.Windows.Forms.Timer(Me.components)
        Me.pbBatailleEnCours2 = New System.Windows.Forms.PictureBox()
        Me.lblCarteBataille1 = New System.Windows.Forms.Label()
        Me.lblCarteBataille2 = New System.Windows.Forms.Label()
        Me.lblTimeKeyP = New System.Windows.Forms.Label()
        Me.LblTimeKeyQ = New System.Windows.Forms.Label()
        Me.pbBatailleEnAttente1 = New System.Windows.Forms.PictureBox()
        Me.btnStatistique = New System.Windows.Forms.Button()
        Me.pbBatailleEnAttente2 = New System.Windows.Forms.PictureBox()
        Me.lblnombreBataille = New System.Windows.Forms.Label()
        CType(Me.pbDeck1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbDeck2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbWinDeck2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbWinDeck1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbBatailleEnCours1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbBatailleEnCours2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbBatailleEnAttente1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbBatailleEnAttente2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnJoueur1
        '
        Me.btnJoueur1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnJoueur1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnJoueur1.Location = New System.Drawing.Point(49, 12)
        Me.btnJoueur1.Name = "btnJoueur1"
        Me.btnJoueur1.Size = New System.Drawing.Size(135, 36)
        Me.btnJoueur1.TabIndex = 5
        Me.btnJoueur1.Text = "Joueur 1"
        Me.btnJoueur1.UseVisualStyleBackColor = false
        '
        'btnJoueur2
        '
        Me.btnJoueur2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnJoueur2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnJoueur2.Location = New System.Drawing.Point(489, 12)
        Me.btnJoueur2.Name = "btnJoueur2"
        Me.btnJoueur2.Size = New System.Drawing.Size(135, 36)
        Me.btnJoueur2.TabIndex = 6
        Me.btnJoueur2.Text = "Joueur 2"
        Me.btnJoueur2.UseVisualStyleBackColor = false
        '
        'btnNewPartie
        '
        Me.btnNewPartie.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnNewPartie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewPartie.Location = New System.Drawing.Point(228, 12)
        Me.btnNewPartie.Name = "btnNewPartie"
        Me.btnNewPartie.Size = New System.Drawing.Size(214, 36)
        Me.btnNewPartie.TabIndex = 7
        Me.btnNewPartie.Text = "Nouvelle Partie"
        Me.btnNewPartie.UseVisualStyleBackColor = false
        '
        'pbDeck1
        '
        Me.pbDeck1.BackColor = System.Drawing.Color.Transparent
        Me.pbDeck1.Location = New System.Drawing.Point(81, 132)
        Me.pbDeck1.Name = "pbDeck1"
        Me.pbDeck1.Size = New System.Drawing.Size(72, 96)
        Me.pbDeck1.TabIndex = 8
        Me.pbDeck1.TabStop = false
        '
        'pbDeck2
        '
        Me.pbDeck2.BackColor = System.Drawing.Color.Transparent
        Me.pbDeck2.Location = New System.Drawing.Point(519, 132)
        Me.pbDeck2.Name = "pbDeck2"
        Me.pbDeck2.Size = New System.Drawing.Size(72, 96)
        Me.pbDeck2.TabIndex = 9
        Me.pbDeck2.TabStop = False
        '
        'pbWinDeck2
        '
        Me.pbWinDeck2.BackColor = System.Drawing.Color.Transparent
        Me.pbWinDeck2.Location = New System.Drawing.Point(389, 143)
        Me.pbWinDeck2.Name = "pbWinDeck2"
        Me.pbWinDeck2.Size = New System.Drawing.Size(72, 96)
        Me.pbWinDeck2.TabIndex = 10
        Me.pbWinDeck2.TabStop = False
        '
        'pbWinDeck1
        '
        Me.pbWinDeck1.BackColor = System.Drawing.Color.Transparent
        Me.pbWinDeck1.Location = New System.Drawing.Point(206, 143)
        Me.pbWinDeck1.Name = "pbWinDeck1"
        Me.pbWinDeck1.Size = New System.Drawing.Size(72, 96)
        Me.pbWinDeck1.TabIndex = 11
        Me.pbWinDeck1.TabStop = False
        '
        'pbBatailleEnCours1
        '
        Me.pbBatailleEnCours1.BackColor = System.Drawing.Color.Transparent
        Me.pbBatailleEnCours1.Location = New System.Drawing.Point(248, 165)
        Me.pbBatailleEnCours1.Name = "pbBatailleEnCours1"
        Me.pbBatailleEnCours1.Size = New System.Drawing.Size(72, 96)
        Me.pbBatailleEnCours1.TabIndex = 12
        Me.pbBatailleEnCours1.TabStop = False
        '
        'lblErreurGeneral
        '
        Me.lblErreurGeneral.AutoSize = True
        Me.lblErreurGeneral.BackColor = System.Drawing.Color.Transparent
        Me.lblErreurGeneral.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErreurGeneral.ForeColor = System.Drawing.Color.Firebrick
        Me.lblErreurGeneral.Location = New System.Drawing.Point(225, 63)
        Me.lblErreurGeneral.Name = "lblErreurGeneral"
        Me.lblErreurGeneral.Size = New System.Drawing.Size(0, 21)
        Me.lblErreurGeneral.TabIndex = 16
        '
        'lblNomJoueur1
        '
        Me.lblNomJoueur1.AutoSize = True
        Me.lblNomJoueur1.BackColor = System.Drawing.Color.Transparent
        Me.lblNomJoueur1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomJoueur1.ForeColor = System.Drawing.Color.Black
        Me.lblNomJoueur1.Location = New System.Drawing.Point(68, 79)
        Me.lblNomJoueur1.Name = "lblNomJoueur1"
        Me.lblNomJoueur1.Size = New System.Drawing.Size(101, 21)
        Me.lblNomJoueur1.TabIndex = 17
        Me.lblNomJoueur1.Text = "NomJoueur1"
        Me.lblNomJoueur1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNomJoueur2
        '
        Me.lblNomJoueur2.AutoSize = True
        Me.lblNomJoueur2.BackColor = System.Drawing.Color.Transparent
        Me.lblNomJoueur2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomJoueur2.ForeColor = System.Drawing.Color.Black
        Me.lblNomJoueur2.Location = New System.Drawing.Point(505, 84)
        Me.lblNomJoueur2.Name = "lblNomJoueur2"
        Me.lblNomJoueur2.Size = New System.Drawing.Size(101, 21)
        Me.lblNomJoueur2.TabIndex = 18
        Me.lblNomJoueur2.Text = "NomJoueur2"
        Me.lblNomJoueur2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNombreCarteJ1
        '
        Me.lblNombreCarteJ1.AutoSize = True
        Me.lblNombreCarteJ1.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCarteJ1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCarteJ1.ForeColor = System.Drawing.Color.Black
        Me.lblNombreCarteJ1.Location = New System.Drawing.Point(103, 112)
        Me.lblNombreCarteJ1.Name = "lblNombreCarteJ1"
        Me.lblNombreCarteJ1.Size = New System.Drawing.Size(19, 21)
        Me.lblNombreCarteJ1.TabIndex = 19
        Me.lblNombreCarteJ1.Text = "0"
        '
        'lblNombreCarteJ2
        '
        Me.lblNombreCarteJ2.AutoSize = True
        Me.lblNombreCarteJ2.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCarteJ2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCarteJ2.ForeColor = System.Drawing.Color.Black
        Me.lblNombreCarteJ2.Location = New System.Drawing.Point(546, 112)
        Me.lblNombreCarteJ2.Name = "lblNombreCarteJ2"
        Me.lblNombreCarteJ2.Size = New System.Drawing.Size(19, 21)
        Me.lblNombreCarteJ2.TabIndex = 20
        Me.lblNombreCarteJ2.Text = "0"
        '
        'lblCarteJoueeJ1
        '
        Me.lblCarteJoueeJ1.AutoSize = True
        Me.lblCarteJoueeJ1.BackColor = System.Drawing.Color.Transparent
        Me.lblCarteJoueeJ1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarteJoueeJ1.ForeColor = System.Drawing.Color.Black
        Me.lblCarteJoueeJ1.Location = New System.Drawing.Point(235, 112)
        Me.lblCarteJoueeJ1.Name = "lblCarteJoueeJ1"
        Me.lblCarteJoueeJ1.Size = New System.Drawing.Size(19, 21)
        Me.lblCarteJoueeJ1.TabIndex = 21
        Me.lblCarteJoueeJ1.Text = "0"
        '
        'lblCarteJoueeJ2
        '
        Me.lblCarteJoueeJ2.AutoSize = True
        Me.lblCarteJoueeJ2.BackColor = System.Drawing.Color.Transparent
        Me.lblCarteJoueeJ2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarteJoueeJ2.ForeColor = System.Drawing.Color.Black
        Me.lblCarteJoueeJ2.Location = New System.Drawing.Point(422, 112)
        Me.lblCarteJoueeJ2.Name = "lblCarteJoueeJ2"
        Me.lblCarteJoueeJ2.Size = New System.Drawing.Size(19, 21)
        Me.lblCarteJoueeJ2.TabIndex = 22
        Me.lblCarteJoueeJ2.Text = "0"
        '
        'TimerTour
        '
        Me.TimerTour.Interval = 900
        '
        'pbBatailleEnCours2
        '
        Me.pbBatailleEnCours2.BackColor = System.Drawing.Color.Transparent
        Me.pbBatailleEnCours2.Location = New System.Drawing.Point(350, 165)
        Me.pbBatailleEnCours2.Name = "pbBatailleEnCours2"
        Me.pbBatailleEnCours2.Size = New System.Drawing.Size(72, 96)
        Me.pbBatailleEnCours2.TabIndex = 23
        Me.pbBatailleEnCours2.TabStop = False
        '
        'lblCarteBataille1
        '
        Me.lblCarteBataille1.AutoSize = True
        Me.lblCarteBataille1.BackColor = System.Drawing.Color.Transparent
        Me.lblCarteBataille1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarteBataille1.ForeColor = System.Drawing.Color.Black
        Me.lblCarteBataille1.Location = New System.Drawing.Point(271, 269)
        Me.lblCarteBataille1.Name = "lblCarteBataille1"
        Me.lblCarteBataille1.Size = New System.Drawing.Size(19, 21)
        Me.lblCarteBataille1.TabIndex = 24
        Me.lblCarteBataille1.Text = "0"
        '
        'lblCarteBataille2
        '
        Me.lblCarteBataille2.AutoSize = True
        Me.lblCarteBataille2.BackColor = System.Drawing.Color.Transparent
        Me.lblCarteBataille2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarteBataille2.ForeColor = System.Drawing.Color.Black
        Me.lblCarteBataille2.Location = New System.Drawing.Point(372, 264)
        Me.lblCarteBataille2.Name = "lblCarteBataille2"
        Me.lblCarteBataille2.Size = New System.Drawing.Size(19, 21)
        Me.lblCarteBataille2.TabIndex = 25
        Me.lblCarteBataille2.Text = "0"
        '
        'lblTimeKeyP
        '
        Me.lblTimeKeyP.AutoSize = True
        Me.lblTimeKeyP.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeKeyP.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeKeyP.ForeColor = System.Drawing.Color.Black
        Me.lblTimeKeyP.Location = New System.Drawing.Point(501, 240)
        Me.lblTimeKeyP.Name = "lblTimeKeyP"
        Me.lblTimeKeyP.Size = New System.Drawing.Size(119, 21)
        Me.lblTimeKeyP.TabIndex = 27
        Me.lblTimeKeyP.Text = "Bloqué: 3 tours"
        '
        'LblTimeKeyQ
        '
        Me.LblTimeKeyQ.AutoSize = True
        Me.LblTimeKeyQ.BackColor = System.Drawing.Color.Transparent
        Me.LblTimeKeyQ.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimeKeyQ.ForeColor = System.Drawing.Color.Black
        Me.LblTimeKeyQ.Location = New System.Drawing.Point(61, 240)
        Me.LblTimeKeyQ.Name = "LblTimeKeyQ"
        Me.LblTimeKeyQ.Size = New System.Drawing.Size(119, 21)
        Me.LblTimeKeyQ.TabIndex = 26
        Me.LblTimeKeyQ.Text = "Bloqué: 3 tours"
        '
        'pbBatailleEnAttente1
        '
        Me.pbBatailleEnAttente1.BackColor = System.Drawing.Color.Transparent
        Me.pbBatailleEnAttente1.Location = New System.Drawing.Point(284, 289)
        Me.pbBatailleEnAttente1.Name = "pbBatailleEnAttente1"
        Me.pbBatailleEnAttente1.Size = New System.Drawing.Size(72, 96)
        Me.pbBatailleEnAttente1.TabIndex = 28
        Me.pbBatailleEnAttente1.TabStop = False
        '
        'btnStatistique
        '
        Me.btnStatistique.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnStatistique.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStatistique.Location = New System.Drawing.Point(227, 409)
        Me.btnStatistique.Name = "btnStatistique"
        Me.btnStatistique.Size = New System.Drawing.Size(214, 36)
        Me.btnStatistique.TabIndex = 29
        Me.btnStatistique.Text = "Statistiques"
        Me.btnStatistique.UseVisualStyleBackColor = False
        '
        'pbBatailleEnAttente2
        '
        Me.pbBatailleEnAttente2.BackColor = System.Drawing.Color.Transparent
        Me.pbBatailleEnAttente2.Location = New System.Drawing.Point(319, 289)
        Me.pbBatailleEnAttente2.Name = "pbBatailleEnAttente2"
        Me.pbBatailleEnAttente2.Size = New System.Drawing.Size(72, 96)
        Me.pbBatailleEnAttente2.TabIndex = 30
        Me.pbBatailleEnAttente2.TabStop = False
        '
        'lblnombreBataille
        '
        Me.lblnombreBataille.AutoSize = True
        Me.lblnombreBataille.BackColor = System.Drawing.Color.Transparent
        Me.lblnombreBataille.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreBataille.ForeColor = System.Drawing.Color.Black
        Me.lblnombreBataille.Location = New System.Drawing.Point(325, 388)
        Me.lblnombreBataille.Name = "lblnombreBataille"
        Me.lblnombreBataille.Size = New System.Drawing.Size(19, 21)
        Me.lblnombreBataille.TabIndex = 31
        Me.lblnombreBataille.Text = "0"
        '
        'frmPrincipal
        '
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(682, 453)
        Me.Controls.Add(Me.lblnombreBataille)
        Me.Controls.Add(Me.pbBatailleEnAttente2)
        Me.Controls.Add(Me.btnStatistique)
        Me.Controls.Add(Me.pbBatailleEnAttente1)
        Me.Controls.Add(Me.lblTimeKeyP)
        Me.Controls.Add(Me.LblTimeKeyQ)
        Me.Controls.Add(Me.lblCarteBataille2)
        Me.Controls.Add(Me.lblCarteBataille1)
        Me.Controls.Add(Me.pbBatailleEnCours2)
        Me.Controls.Add(Me.lblCarteJoueeJ2)
        Me.Controls.Add(Me.lblCarteJoueeJ1)
        Me.Controls.Add(Me.lblNombreCarteJ2)
        Me.Controls.Add(Me.lblNombreCarteJ1)
        Me.Controls.Add(Me.lblNomJoueur2)
        Me.Controls.Add(Me.lblNomJoueur1)
        Me.Controls.Add(Me.lblErreurGeneral)
        Me.Controls.Add(Me.pbBatailleEnCours1)
        Me.Controls.Add(Me.pbWinDeck1)
        Me.Controls.Add(Me.pbWinDeck2)
        Me.Controls.Add(Me.pbDeck2)
        Me.Controls.Add(Me.pbDeck1)
        Me.Controls.Add(Me.btnNewPartie)
        Me.Controls.Add(Me.btnJoueur2)
        Me.Controls.Add(Me.btnJoueur1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.KeyPreview = true
        Me.Name = "frmPrincipal"
        CType(Me.pbDeck1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbDeck2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbWinDeck2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbWinDeck1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbBatailleEnCours1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbBatailleEnCours2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbBatailleEnAttente1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbBatailleEnAttente2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents btnJoueur1 As Button
    Friend WithEvents btnJoueur2 As Button
    Friend WithEvents btnNewPartie As Button
    Friend WithEvents pbDeck1 As PictureBox
    Friend WithEvents pbDeck2 As PictureBox
    Friend WithEvents pbWinDeck2 As PictureBox
    Friend WithEvents pbWinDeck1 As PictureBox
    Friend WithEvents pbBatailleEnCours1 As PictureBox
    Friend WithEvents lblErreurGeneral As Label
    Friend WithEvents lblNomJoueur1 As Label
    Friend WithEvents lblNomJoueur2 As Label
    Friend WithEvents lblNombreCarteJ1 As Label
    Friend WithEvents lblNombreCarteJ2 As Label
    Friend WithEvents lblCarteJoueeJ1 As Label
    Friend WithEvents lblCarteJoueeJ2 As Label
    Friend WithEvents TimerTour As Timer
    Friend WithEvents pbBatailleEnCours2 As PictureBox
    Friend WithEvents lblCarteBataille1 As Label
    Friend WithEvents lblCarteBataille2 As Label
    Friend WithEvents lblTimeKeyP As Label
    Friend WithEvents LblTimeKeyQ As Label
    Friend WithEvents pbBatailleEnAttente1 As PictureBox
    Friend WithEvents btnStatistique As Button
    Friend WithEvents pbBatailleEnAttente2 As PictureBox
    Friend WithEvents lblnombreBataille As Label
End Class
