<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccueil
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdIntroduction = New System.Windows.Forms.Button
        Me.cmdRelance = New System.Windows.Forms.Button
        Me.txtDossier = New System.Windows.Forms.TextBox
        Me.cmdEtude = New System.Windows.Forms.Button
        Me.btnDossier = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BIENVENUE AU CREDIT CELESTE"
        '
        'cmdIntroduction
        '
        Me.cmdIntroduction.Location = New System.Drawing.Point(72, 199)
        Me.cmdIntroduction.Name = "cmdIntroduction"
        Me.cmdIntroduction.Size = New System.Drawing.Size(75, 23)
        Me.cmdIntroduction.TabIndex = 16
        Me.cmdIntroduction.Text = "&Introduction"
        Me.cmdIntroduction.UseVisualStyleBackColor = True
        '
        'cmdRelance
        '
        Me.cmdRelance.Location = New System.Drawing.Point(494, 207)
        Me.cmdRelance.Name = "cmdRelance"
        Me.cmdRelance.Size = New System.Drawing.Size(75, 23)
        Me.cmdRelance.TabIndex = 17
        Me.cmdRelance.Text = "&Relance"
        Me.cmdRelance.UseVisualStyleBackColor = True
        '
        'txtDossier
        '
        Me.txtDossier.Location = New System.Drawing.Point(494, 236)
        Me.txtDossier.Name = "txtDossier"
        Me.txtDossier.Size = New System.Drawing.Size(140, 20)
        Me.txtDossier.TabIndex = 18
        Me.txtDossier.Text = "Saisir le numéro de dossier"
        '
        'cmdEtude
        '
        Me.cmdEtude.Location = New System.Drawing.Point(342, 199)
        Me.cmdEtude.Name = "cmdEtude"
        Me.cmdEtude.Size = New System.Drawing.Size(75, 23)
        Me.cmdEtude.TabIndex = 19
        Me.cmdEtude.Text = "&Etude"
        Me.cmdEtude.UseVisualStyleBackColor = True
        '
        'btnDossier
        '
        Me.btnDossier.Location = New System.Drawing.Point(196, 198)
        Me.btnDossier.Name = "btnDossier"
        Me.btnDossier.Size = New System.Drawing.Size(75, 23)
        Me.btnDossier.TabIndex = 20
        Me.btnDossier.Text = "&Dossier"
        Me.btnDossier.UseVisualStyleBackColor = True
        '
        'frmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 266)
        Me.Controls.Add(Me.btnDossier)
        Me.Controls.Add(Me.cmdEtude)
        Me.Controls.Add(Me.txtDossier)
        Me.Controls.Add(Me.cmdRelance)
        Me.Controls.Add(Me.cmdIntroduction)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAccueil"
        Me.Text = "frmAccueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdIntroduction As System.Windows.Forms.Button
    Friend WithEvents cmdRelance As System.Windows.Forms.Button
    Friend WithEvents txtDossier As System.Windows.Forms.TextBox
    Friend WithEvents cmdEtude As System.Windows.Forms.Button
    Friend WithEvents btnDossier As System.Windows.Forms.Button
End Class
