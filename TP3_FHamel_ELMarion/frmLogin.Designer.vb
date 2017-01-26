<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblPsw = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtMdp = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.lblLoginErreur = New System.Windows.Forms.Label()
        Me.lblErreurMDP = New System.Windows.Forms.Label()
        Me.lblJoueur = New System.Windows.Forms.Label()
        Me.btnInscrire = New System.Windows.Forms.Button()
        Me.lblPasCompte = New System.Windows.Forms.Label()
        Me.lblErreurGeneral = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Location = New System.Drawing.Point(278, 324)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(144, 36)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "Connection"
        Me.btnOk.UseVisualStyleBackColor = false
        '
        'lblPsw
        '
        Me.lblPsw.AutoSize = true
        Me.lblPsw.BackColor = System.Drawing.Color.Transparent
        Me.lblPsw.Location = New System.Drawing.Point(243, 230)
        Me.lblPsw.Name = "lblPsw"
        Me.lblPsw.Size = New System.Drawing.Size(147, 24)
        Me.lblPsw.TabIndex = 8
        Me.lblPsw.Text = "Mot de passe :"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = true
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Location = New System.Drawing.Point(243, 124)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(74, 24)
        Me.lblLogin.TabIndex = 7
        Me.lblLogin.Text = "Login :"
        '
        'txtMdp
        '
        Me.txtMdp.BackColor = System.Drawing.Color.LightGray
        Me.txtMdp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMdp.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMdp.Location = New System.Drawing.Point(249, 266)
        Me.txtMdp.Name = "txtMdp"
        Me.txtMdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMdp.Size = New System.Drawing.Size(207, 23)
        Me.txtMdp.TabIndex = 6
        '
        'txtLogin
        '
        Me.txtLogin.BackColor = System.Drawing.Color.LightGray
        Me.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLogin.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtLogin.Location = New System.Drawing.Point(249, 160)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(207, 23)
        Me.txtLogin.TabIndex = 5
        '
        'lblLoginErreur
        '
        Me.lblLoginErreur.AutoSize = true
        Me.lblLoginErreur.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginErreur.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLoginErreur.ForeColor = System.Drawing.Color.Firebrick
        Me.lblLoginErreur.Location = New System.Drawing.Point(245, 192)
        Me.lblLoginErreur.Name = "lblLoginErreur"
        Me.lblLoginErreur.Size = New System.Drawing.Size(0, 17)
        Me.lblLoginErreur.TabIndex = 10
        '
        'lblErreurMDP
        '
        Me.lblErreurMDP.AutoSize = true
        Me.lblErreurMDP.BackColor = System.Drawing.Color.Transparent
        Me.lblErreurMDP.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblErreurMDP.ForeColor = System.Drawing.Color.Firebrick
        Me.lblErreurMDP.Location = New System.Drawing.Point(245, 298)
        Me.lblErreurMDP.Name = "lblErreurMDP"
        Me.lblErreurMDP.Size = New System.Drawing.Size(0, 17)
        Me.lblErreurMDP.TabIndex = 11
        '
        'lblJoueur
        '
        Me.lblJoueur.AutoSize = true
        Me.lblJoueur.BackColor = System.Drawing.Color.Transparent
        Me.lblJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblJoueur.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblJoueur.Location = New System.Drawing.Point(240, 23)
        Me.lblJoueur.Name = "lblJoueur"
        Me.lblJoueur.Size = New System.Drawing.Size(220, 55)
        Me.lblJoueur.TabIndex = 12
        Me.lblJoueur.Text = "Joueur 1"
        '
        'btnInscrire
        '
        Me.btnInscrire.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnInscrire.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInscrire.Location = New System.Drawing.Point(278, 399)
        Me.btnInscrire.Name = "btnInscrire"
        Me.btnInscrire.Size = New System.Drawing.Size(144, 36)
        Me.btnInscrire.TabIndex = 13
        Me.btnInscrire.Text = "S'inscrire"
        Me.btnInscrire.UseVisualStyleBackColor = false
        '
        'lblPasCompte
        '
        Me.lblPasCompte.AutoSize = true
        Me.lblPasCompte.BackColor = System.Drawing.Color.Transparent
        Me.lblPasCompte.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPasCompte.Location = New System.Drawing.Point(246, 375)
        Me.lblPasCompte.Name = "lblPasCompte"
        Me.lblPasCompte.Size = New System.Drawing.Size(167, 17)
        Me.lblPasCompte.TabIndex = 14
        Me.lblPasCompte.Text = "Vous n'avez pas de compte ?"
        '
        'lblErreurGeneral
        '
        Me.lblErreurGeneral.AutoSize = true
        Me.lblErreurGeneral.BackColor = System.Drawing.Color.Transparent
        Me.lblErreurGeneral.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblErreurGeneral.ForeColor = System.Drawing.Color.Firebrick
        Me.lblErreurGeneral.Location = New System.Drawing.Point(244, 95)
        Me.lblErreurGeneral.Name = "lblErreurGeneral"
        Me.lblErreurGeneral.Size = New System.Drawing.Size(0, 17)
        Me.lblErreurGeneral.TabIndex = 15
        '
        'frmLogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.lblErreurGeneral)
        Me.Controls.Add(Me.lblPasCompte)
        Me.Controls.Add(Me.btnInscrire)
        Me.Controls.Add(Me.lblJoueur)
        Me.Controls.Add(Me.lblErreurMDP)
        Me.Controls.Add(Me.lblLoginErreur)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblPsw)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.txtMdp)
        Me.Controls.Add(Me.txtLogin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmLogin"
        Me.Text = "Connecte-toi !"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents lblPsw As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtMdp As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents lblLoginErreur As Label
    Friend WithEvents lblErreurMDP As Label
    Friend WithEvents lblJoueur As Label
    Friend WithEvents btnInscrire As Button
    Friend WithEvents lblPasCompte As Label
    Friend WithEvents lblErreurGeneral As Label
End Class
