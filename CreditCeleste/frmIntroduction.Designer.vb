<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntroduction
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
        Me.lblAppelle = New System.Windows.Forms.Label
        Me.cbxIdent = New System.Windows.Forms.ComboBox
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.txtPrenom = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAncVhc = New System.Windows.Forms.TextBox
        Me.txtNouVhc = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbxVdr = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.gbpAge = New System.Windows.Forms.GroupBox
        Me.rdbOcc5ep = New System.Windows.Forms.RadioButton
        Me.rdbOcc3a5 = New System.Windows.Forms.RadioButton
        Me.rdbOcc3 = New System.Windows.Forms.RadioButton
        Me.rdbNeuf = New System.Windows.Forms.RadioButton
        Me.cmdEnr = New System.Windows.Forms.Button
        Me.cmdCredit = New System.Windows.Forms.Button
        Me.cmdPlus = New System.Windows.Forms.Button
        Me.cmdVoiture = New System.Windows.Forms.Button
        Me.BtnDossier = New System.Windows.Forms.Button
        Me.gbpAge.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAppelle
        '
        Me.lblAppelle.AutoSize = True
        Me.lblAppelle.Location = New System.Drawing.Point(77, 29)
        Me.lblAppelle.Name = "lblAppelle"
        Me.lblAppelle.Size = New System.Drawing.Size(65, 13)
        Me.lblAppelle.TabIndex = 0
        Me.lblAppelle.Text = "Je m'appelle"
        '
        'cbxIdent
        '
        Me.cbxIdent.FormattingEnabled = True
        Me.cbxIdent.Items.AddRange(New Object() {"Mademoiselle", "Madame", "Monsieur"})
        Me.cbxIdent.Location = New System.Drawing.Point(35, 55)
        Me.cbxIdent.Name = "cbxIdent"
        Me.cbxIdent.Size = New System.Drawing.Size(149, 21)
        Me.cbxIdent.TabIndex = 1
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(35, 107)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(217, 20)
        Me.txtNom.TabIndex = 2
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(35, 157)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(217, 20)
        Me.txtPrenom.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Prénom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(656, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mon ancien véhicule"
        '
        'txtAncVhc
        '
        Me.txtAncVhc.Location = New System.Drawing.Point(593, 56)
        Me.txtAncVhc.Name = "txtAncVhc"
        Me.txtAncVhc.Size = New System.Drawing.Size(217, 20)
        Me.txtAncVhc.TabIndex = 7
        '
        'txtNouVhc
        '
        Me.txtNouVhc.Location = New System.Drawing.Point(320, 212)
        Me.txtNouVhc.Name = "txtNouVhc"
        Me.txtNouVhc.Size = New System.Drawing.Size(217, 20)
        Me.txtNouVhc.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(362, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mon Nouveau véhicule"
        '
        'cbxVdr
        '
        Me.cbxVdr.FormattingEnabled = True
        Me.cbxVdr.Items.AddRange(New Object() {"M. Armand Kreyder", "M. Sébastien Pasla", "Mme Annie Savapa"})
        Me.cbxVdr.Location = New System.Drawing.Point(35, 308)
        Me.cbxVdr.Name = "cbxVdr"
        Me.cbxVdr.Size = New System.Drawing.Size(149, 21)
        Me.cbxVdr.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Vendeur"
        '
        'gbpAge
        '
        Me.gbpAge.Controls.Add(Me.rdbOcc5ep)
        Me.gbpAge.Controls.Add(Me.rdbOcc3a5)
        Me.gbpAge.Controls.Add(Me.rdbOcc3)
        Me.gbpAge.Controls.Add(Me.rdbNeuf)
        Me.gbpAge.Location = New System.Drawing.Point(337, 255)
        Me.gbpAge.Name = "gbpAge"
        Me.gbpAge.Size = New System.Drawing.Size(200, 111)
        Me.gbpAge.TabIndex = 12
        Me.gbpAge.TabStop = False
        Me.gbpAge.Text = "Type"
        '
        'rdbOcc5ep
        '
        Me.rdbOcc5ep.AutoSize = True
        Me.rdbOcc5ep.Location = New System.Drawing.Point(26, 87)
        Me.rdbOcc5ep.Name = "rdbOcc5ep"
        Me.rdbOcc5ep.Size = New System.Drawing.Size(133, 17)
        Me.rdbOcc5ep.TabIndex = 3
        Me.rdbOcc5ep.TabStop = True
        Me.rdbOcc5ep.Text = "Occasion 5 ans et plus"
        Me.rdbOcc5ep.UseVisualStyleBackColor = True
        '
        'rdbOcc3a5
        '
        Me.rdbOcc3a5.AutoSize = True
        Me.rdbOcc3a5.Location = New System.Drawing.Point(25, 63)
        Me.rdbOcc3a5.Name = "rdbOcc3a5"
        Me.rdbOcc3a5.Size = New System.Drawing.Size(117, 17)
        Me.rdbOcc3a5.TabIndex = 2
        Me.rdbOcc3a5.TabStop = True
        Me.rdbOcc3a5.Text = "Occasion 3 à 5 ans"
        Me.rdbOcc3a5.UseVisualStyleBackColor = True
        '
        'rdbOcc3
        '
        Me.rdbOcc3.AutoSize = True
        Me.rdbOcc3.Location = New System.Drawing.Point(24, 38)
        Me.rdbOcc3.Name = "rdbOcc3"
        Me.rdbOcc3.Size = New System.Drawing.Size(105, 17)
        Me.rdbOcc3.TabIndex = 1
        Me.rdbOcc3.TabStop = True
        Me.rdbOcc3.Text = "Occasion - 3 ans"
        Me.rdbOcc3.UseVisualStyleBackColor = True
        '
        'rdbNeuf
        '
        Me.rdbNeuf.AutoSize = True
        Me.rdbNeuf.Location = New System.Drawing.Point(23, 16)
        Me.rdbNeuf.Name = "rdbNeuf"
        Me.rdbNeuf.Size = New System.Drawing.Size(48, 17)
        Me.rdbNeuf.TabIndex = 0
        Me.rdbNeuf.TabStop = True
        Me.rdbNeuf.Text = "Neuf"
        Me.rdbNeuf.UseVisualStyleBackColor = True
        '
        'cmdEnr
        '
        Me.cmdEnr.Location = New System.Drawing.Point(149, 432)
        Me.cmdEnr.Name = "cmdEnr"
        Me.cmdEnr.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnr.TabIndex = 13
        Me.cmdEnr.Text = "J'enregistre"
        Me.cmdEnr.UseVisualStyleBackColor = True
        '
        'cmdCredit
        '
        Me.cmdCredit.Location = New System.Drawing.Point(500, 432)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 14
        Me.cmdCredit.Text = "Crédit"
        Me.cmdCredit.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Location = New System.Drawing.Point(687, 432)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(75, 23)
        Me.cmdPlus.TabIndex = 15
        Me.cmdPlus.Text = "Plus"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdVoiture
        '
        Me.cmdVoiture.Location = New System.Drawing.Point(386, 432)
        Me.cmdVoiture.Name = "cmdVoiture"
        Me.cmdVoiture.Size = New System.Drawing.Size(75, 23)
        Me.cmdVoiture.TabIndex = 16
        Me.cmdVoiture.Text = "Voiture"
        Me.cmdVoiture.UseVisualStyleBackColor = True
        '
        'BtnDossier
        '
        Me.BtnDossier.Location = New System.Drawing.Point(260, 432)
        Me.BtnDossier.Name = "BtnDossier"
        Me.BtnDossier.Size = New System.Drawing.Size(75, 23)
        Me.BtnDossier.TabIndex = 17
        Me.BtnDossier.Text = "Dossier"
        Me.BtnDossier.UseVisualStyleBackColor = True
        '
        'frmIntroduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 467)
        Me.Controls.Add(Me.BtnDossier)
        Me.Controls.Add(Me.cmdVoiture)
        Me.Controls.Add(Me.cmdPlus)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdEnr)
        Me.Controls.Add(Me.gbpAge)
        Me.Controls.Add(Me.cbxVdr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNouVhc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAncVhc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.cbxIdent)
        Me.Controls.Add(Me.lblAppelle)
        Me.Name = "frmIntroduction"
        Me.Text = "Introduction - Crédit Celeste"
        Me.gbpAge.ResumeLayout(False)
        Me.gbpAge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAppelle As System.Windows.Forms.Label
    Friend WithEvents cbxIdent As System.Windows.Forms.ComboBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAncVhc As System.Windows.Forms.TextBox
    Friend WithEvents txtNouVhc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxVdr As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbpAge As System.Windows.Forms.GroupBox
    Friend WithEvents rdbOcc3a5 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOcc3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNeuf As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOcc5ep As System.Windows.Forms.RadioButton
    Friend WithEvents cmdEnr As System.Windows.Forms.Button
    Friend WithEvents cmdCredit As System.Windows.Forms.Button
    Friend WithEvents cmdPlus As System.Windows.Forms.Button
    Friend WithEvents cmdVoiture As System.Windows.Forms.Button
    Friend WithEvents BtnDossier As System.Windows.Forms.Button

End Class
