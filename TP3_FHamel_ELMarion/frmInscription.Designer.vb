<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInscription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInscription))
        Me.txtlogin = New System.Windows.Forms.TextBox()
        Me.txtpsw1 = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblPsw = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtpsw2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLoginErreur = New System.Windows.Forms.Label()
        Me.lblMdpErreur = New System.Windows.Forms.Label()
        Me.lblJoueur = New System.Windows.Forms.Label()
        Me.lblerreurGeneral = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'txtlogin
        '
        Me.txtlogin.BackColor = System.Drawing.Color.LightGray
        Me.txtlogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlogin.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtlogin.Location = New System.Drawing.Point(34, 137)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(246, 23)
        Me.txtlogin.TabIndex = 0
        '
        'txtpsw1
        '
        Me.txtpsw1.BackColor = System.Drawing.Color.LightGray
        Me.txtpsw1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpsw1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtpsw1.Location = New System.Drawing.Point(34, 236)
        Me.txtpsw1.Name = "txtpsw1"
        Me.txtpsw1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpsw1.Size = New System.Drawing.Size(246, 23)
        Me.txtpsw1.TabIndex = 1
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = true
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Location = New System.Drawing.Point(28, 101)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(74, 24)
        Me.lblLogin.TabIndex = 4
        Me.lblLogin.Text = "Login :"
        '
        'lblPsw
        '
        Me.lblPsw.AutoSize = true
        Me.lblPsw.BackColor = System.Drawing.Color.Transparent
        Me.lblPsw.Location = New System.Drawing.Point(28, 200)
        Me.lblPsw.Name = "lblPsw"
        Me.lblPsw.Size = New System.Drawing.Size(147, 24)
        Me.lblPsw.TabIndex = 5
        Me.lblPsw.Text = "Mot de passe :"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Location = New System.Drawing.Point(324, 390)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(135, 36)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "S'inscrire"
        Me.btnOk.UseVisualStyleBackColor = false
        '
        'txtpsw2
        '
        Me.txtpsw2.BackColor = System.Drawing.Color.LightGray
        Me.txtpsw2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpsw2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtpsw2.Location = New System.Drawing.Point(34, 326)
        Me.txtpsw2.Name = "txtpsw2"
        Me.txtpsw2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpsw2.Size = New System.Drawing.Size(246, 23)
        Me.txtpsw2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(28, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = " Répéter Mot de passe :"
        '
        'lblLoginErreur
        '
        Me.lblLoginErreur.AutoSize = true
        Me.lblLoginErreur.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginErreur.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLoginErreur.ForeColor = System.Drawing.Color.Firebrick
        Me.lblLoginErreur.Location = New System.Drawing.Point(30, 169)
        Me.lblLoginErreur.Name = "lblLoginErreur"
        Me.lblLoginErreur.Size = New System.Drawing.Size(0, 17)
        Me.lblLoginErreur.TabIndex = 11
        '
        'lblMdpErreur
        '
        Me.lblMdpErreur.AutoSize = true
        Me.lblMdpErreur.BackColor = System.Drawing.Color.Transparent
        Me.lblMdpErreur.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMdpErreur.ForeColor = System.Drawing.Color.Firebrick
        Me.lblMdpErreur.Location = New System.Drawing.Point(30, 358)
        Me.lblMdpErreur.Name = "lblMdpErreur"
        Me.lblMdpErreur.Size = New System.Drawing.Size(0, 17)
        Me.lblMdpErreur.TabIndex = 12
        '
        'lblJoueur
        '
        Me.lblJoueur.AutoSize = true
        Me.lblJoueur.BackColor = System.Drawing.Color.Transparent
        Me.lblJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblJoueur.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblJoueur.Location = New System.Drawing.Point(42, 6)
        Me.lblJoueur.Name = "lblJoueur"
        Me.lblJoueur.Size = New System.Drawing.Size(220, 55)
        Me.lblJoueur.TabIndex = 13
        Me.lblJoueur.Text = "Joueur 1"
        '
        'lblerreurGeneral
        '
        Me.lblerreurGeneral.AutoSize = true
        Me.lblerreurGeneral.BackColor = System.Drawing.Color.Transparent
        Me.lblerreurGeneral.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblerreurGeneral.ForeColor = System.Drawing.Color.Firebrick
        Me.lblerreurGeneral.Location = New System.Drawing.Point(31, 71)
        Me.lblerreurGeneral.Name = "lblerreurGeneral"
        Me.lblerreurGeneral.Size = New System.Drawing.Size(0, 17)
        Me.lblerreurGeneral.TabIndex = 14
        '
        'frmInscription
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.lblerreurGeneral)
        Me.Controls.Add(Me.lblJoueur)
        Me.Controls.Add(Me.lblMdpErreur)
        Me.Controls.Add(Me.lblLoginErreur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpsw2)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblPsw)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.txtpsw1)
        Me.Controls.Add(Me.txtlogin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Name = "frmInscription"
        Me.Text = "Identifiez-vous!"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents txtlogin As TextBox
    Friend WithEvents txtpsw1 As TextBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblPsw As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents txtpsw2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLoginErreur As Label
    Friend WithEvents lblMdpErreur As Label
    Friend WithEvents lblJoueur As Label
    Friend WithEvents lblerreurGeneral As Label
End Class
