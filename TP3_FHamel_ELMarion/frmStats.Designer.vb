<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStats))
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lstJoueurs = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(167, 405)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(135, 36)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'lstJoueurs
        '
        Me.lstJoueurs.BackColor = System.Drawing.Color.LightBlue
        Me.lstJoueurs.FormattingEnabled = True
        Me.lstJoueurs.ItemHeight = 16
        Me.lstJoueurs.Location = New System.Drawing.Point(99, 48)
        Me.lstJoueurs.Name = "lstJoueurs"
        Me.lstJoueurs.Size = New System.Drawing.Size(278, 324)
        Me.lstJoueurs.TabIndex = 7
        '
        'frmStats
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnOk
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.lstJoueurs)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "frmStats"
        Me.Text = "Les meilleurs combattants"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents lstJoueurs As ListBox
End Class
