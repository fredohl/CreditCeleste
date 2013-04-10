<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDossier
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
        Me.TxtDuree = New System.Windows.Forms.TextBox
        Me.LblDuree = New System.Windows.Forms.Label
        Me.TxtMontant = New System.Windows.Forms.TextBox
        Me.LblMontant = New System.Windows.Forms.Label
        Me.btn_Enr = New System.Windows.Forms.Button
        Me.btn_Fermer = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblMensualite = New System.Windows.Forms.Label
        Me.BtnAccueil = New System.Windows.Forms.Button
        Me.LblNum = New System.Windows.Forms.Label
        Me.LblCoordonnées = New System.Windows.Forms.Label
        Me.lblVendeur = New System.Windows.Forms.Label
        Me.LblCoVendeur = New System.Windows.Forms.Label
        Me.LblClient = New System.Windows.Forms.Label
        Me.LblPrenom = New System.Windows.Forms.Label
        Me.LblCivilite = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtTaux = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblPositionDossier = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TxtDuree
        '
        Me.TxtDuree.Location = New System.Drawing.Point(27, 46)
        Me.TxtDuree.Name = "TxtDuree"
        Me.TxtDuree.Size = New System.Drawing.Size(100, 20)
        Me.TxtDuree.TabIndex = 0
        '
        'LblDuree
        '
        Me.LblDuree.AutoSize = True
        Me.LblDuree.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDuree.ForeColor = System.Drawing.Color.DarkRed
        Me.LblDuree.Location = New System.Drawing.Point(27, 27)
        Me.LblDuree.Name = "LblDuree"
        Me.LblDuree.Size = New System.Drawing.Size(98, 13)
        Me.LblDuree.TabIndex = 1
        Me.LblDuree.Text = "Saisir la Durée :"
        '
        'TxtMontant
        '
        Me.TxtMontant.Location = New System.Drawing.Point(30, 113)
        Me.TxtMontant.Name = "TxtMontant"
        Me.TxtMontant.Size = New System.Drawing.Size(100, 20)
        Me.TxtMontant.TabIndex = 2
        '
        'LblMontant
        '
        Me.LblMontant.AutoSize = True
        Me.LblMontant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontant.ForeColor = System.Drawing.Color.DarkRed
        Me.LblMontant.Location = New System.Drawing.Point(30, 94)
        Me.LblMontant.Name = "LblMontant"
        Me.LblMontant.Size = New System.Drawing.Size(109, 13)
        Me.LblMontant.TabIndex = 3
        Me.LblMontant.Text = "Saisir le montant :"
        '
        'btn_Enr
        '
        Me.btn_Enr.Location = New System.Drawing.Point(145, 274)
        Me.btn_Enr.Name = "btn_Enr"
        Me.btn_Enr.Size = New System.Drawing.Size(75, 23)
        Me.btn_Enr.TabIndex = 4
        Me.btn_Enr.Text = "J'enregistre"
        Me.btn_Enr.UseVisualStyleBackColor = True
        '
        'btn_Fermer
        '
        Me.btn_Fermer.Location = New System.Drawing.Point(270, 274)
        Me.btn_Fermer.Name = "btn_Fermer"
        Me.btn_Fermer.Size = New System.Drawing.Size(75, 23)
        Me.btn_Fermer.TabIndex = 5
        Me.btn_Fermer.Text = "Introduction"
        Me.btn_Fermer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(175, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "La mensualité est : "
        '
        'LblMensualite
        '
        Me.LblMensualite.AutoSize = True
        Me.LblMensualite.Location = New System.Drawing.Point(178, 211)
        Me.LblMensualite.Name = "LblMensualite"
        Me.LblMensualite.Size = New System.Drawing.Size(13, 13)
        Me.LblMensualite.TabIndex = 7
        Me.LblMensualite.Text = "0"
        '
        'BtnAccueil
        '
        Me.BtnAccueil.Location = New System.Drawing.Point(386, 274)
        Me.BtnAccueil.Name = "BtnAccueil"
        Me.BtnAccueil.Size = New System.Drawing.Size(75, 23)
        Me.BtnAccueil.TabIndex = 8
        Me.BtnAccueil.Text = "&Accueil"
        Me.BtnAccueil.UseVisualStyleBackColor = True
        '
        'LblNum
        '
        Me.LblNum.AutoSize = True
        Me.LblNum.Location = New System.Drawing.Point(461, 9)
        Me.LblNum.Name = "LblNum"
        Me.LblNum.Size = New System.Drawing.Size(0, 13)
        Me.LblNum.TabIndex = 9
        '
        'LblCoordonnées
        '
        Me.LblCoordonnées.AutoSize = True
        Me.LblCoordonnées.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCoordonnées.ForeColor = System.Drawing.Color.DarkRed
        Me.LblCoordonnées.Location = New System.Drawing.Point(379, 46)
        Me.LblCoordonnées.Name = "LblCoordonnées"
        Me.LblCoordonnées.Size = New System.Drawing.Size(170, 13)
        Me.LblCoordonnées.TabIndex = 10
        Me.LblCoordonnées.Text = "Les coordonnées du Client : "
        '
        'lblVendeur
        '
        Me.lblVendeur.AutoSize = True
        Me.lblVendeur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendeur.ForeColor = System.Drawing.Color.DarkRed
        Me.lblVendeur.Location = New System.Drawing.Point(382, 211)
        Me.lblVendeur.Name = "lblVendeur"
        Me.lblVendeur.Size = New System.Drawing.Size(62, 13)
        Me.lblVendeur.TabIndex = 14
        Me.lblVendeur.Text = "Vendeur :"
        '
        'LblCoVendeur
        '
        Me.LblCoVendeur.AutoSize = True
        Me.LblCoVendeur.Location = New System.Drawing.Point(382, 242)
        Me.LblCoVendeur.Name = "LblCoVendeur"
        Me.LblCoVendeur.Size = New System.Drawing.Size(0, 13)
        Me.LblCoVendeur.TabIndex = 15
        '
        'LblClient
        '
        Me.LblClient.AutoSize = True
        Me.LblClient.Location = New System.Drawing.Point(379, 113)
        Me.LblClient.Name = "LblClient"
        Me.LblClient.Size = New System.Drawing.Size(0, 13)
        Me.LblClient.TabIndex = 16
        '
        'LblPrenom
        '
        Me.LblPrenom.AutoSize = True
        Me.LblPrenom.Location = New System.Drawing.Point(379, 144)
        Me.LblPrenom.Name = "LblPrenom"
        Me.LblPrenom.Size = New System.Drawing.Size(0, 13)
        Me.LblPrenom.TabIndex = 17
        '
        'LblCivilite
        '
        Me.LblCivilite.AutoSize = True
        Me.LblCivilite.Location = New System.Drawing.Point(379, 77)
        Me.LblCivilite.Name = "LblCivilite"
        Me.LblCivilite.Size = New System.Drawing.Size(0, 13)
        Me.LblCivilite.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(27, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Saisir le taux : "
        '
        'TxtTaux
        '
        Me.TxtTaux.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTaux.Location = New System.Drawing.Point(30, 203)
        Me.TxtTaux.Name = "TxtTaux"
        Me.TxtTaux.Size = New System.Drawing.Size(100, 20)
        Me.TxtTaux.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(383, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Numero : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(620, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Etat Dossier : "
        '
        'LblPositionDossier
        '
        Me.LblPositionDossier.AutoSize = True
        Me.LblPositionDossier.Location = New System.Drawing.Point(623, 211)
        Me.LblPositionDossier.Name = "LblPositionDossier"
        Me.LblPositionDossier.Size = New System.Drawing.Size(0, 13)
        Me.LblPositionDossier.TabIndex = 23
        '
        'frmDossier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 309)
        Me.Controls.Add(Me.LblPositionDossier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTaux)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblCivilite)
        Me.Controls.Add(Me.LblPrenom)
        Me.Controls.Add(Me.LblClient)
        Me.Controls.Add(Me.LblCoVendeur)
        Me.Controls.Add(Me.lblVendeur)
        Me.Controls.Add(Me.LblCoordonnées)
        Me.Controls.Add(Me.LblNum)
        Me.Controls.Add(Me.BtnAccueil)
        Me.Controls.Add(Me.LblMensualite)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Fermer)
        Me.Controls.Add(Me.btn_Enr)
        Me.Controls.Add(Me.LblMontant)
        Me.Controls.Add(Me.TxtMontant)
        Me.Controls.Add(Me.LblDuree)
        Me.Controls.Add(Me.TxtDuree)
        Me.Name = "frmDossier"
        Me.Text = "Dossier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDuree As System.Windows.Forms.TextBox
    Friend WithEvents LblDuree As System.Windows.Forms.Label
    Friend WithEvents TxtMontant As System.Windows.Forms.TextBox
    Friend WithEvents LblMontant As System.Windows.Forms.Label
    Friend WithEvents btn_Enr As System.Windows.Forms.Button
    Friend WithEvents btn_Fermer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblMensualite As System.Windows.Forms.Label
    Friend WithEvents BtnAccueil As System.Windows.Forms.Button
    Friend WithEvents LblNum As System.Windows.Forms.Label
    Friend WithEvents LblCoordonnées As System.Windows.Forms.Label
    Friend WithEvents lblVendeur As System.Windows.Forms.Label
    Friend WithEvents LblCoVendeur As System.Windows.Forms.Label
    Friend WithEvents LblClient As System.Windows.Forms.Label
    Friend WithEvents LblPrenom As System.Windows.Forms.Label
    Friend WithEvents LblCivilite As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTaux As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblPositionDossier As System.Windows.Forms.Label
End Class
