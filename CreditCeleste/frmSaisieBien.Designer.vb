<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaisieBien
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblVehicule = New System.Windows.Forms.Label
        Me.txtd1ereImmat = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAnneeModele = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNumImmat = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNumSérie = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPuissance = New System.Windows.Forms.TextBox
        Me.cmdEnr = New System.Windows.Forms.Button
        Me.cmdIntroduction = New System.Windows.Forms.Button
        Me.btnDossier = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblVehicule)
        Me.GroupBox1.Location = New System.Drawing.Point(172, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 111)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mon Nouveau Véhicule"
        '
        'lblVehicule
        '
        Me.lblVehicule.AutoSize = True
        Me.lblVehicule.Location = New System.Drawing.Point(30, 33)
        Me.lblVehicule.Name = "lblVehicule"
        Me.lblVehicule.Size = New System.Drawing.Size(85, 13)
        Me.lblVehicule.TabIndex = 0
        Me.lblVehicule.Text = "nom du véhicule"
        '
        'txtd1ereImmat
        '
        Me.txtd1ereImmat.Location = New System.Drawing.Point(16, 222)
        Me.txtd1ereImmat.Name = "txtd1ereImmat"
        Me.txtd1ereImmat.Size = New System.Drawing.Size(129, 20)
        Me.txtd1ereImmat.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "date de 1ère immatriculation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "année Modèle"
        '
        'txtAnneeModele
        '
        Me.txtAnneeModele.Location = New System.Drawing.Point(180, 222)
        Me.txtAnneeModele.Name = "txtAnneeModele"
        Me.txtAnneeModele.Size = New System.Drawing.Size(75, 20)
        Me.txtAnneeModele.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "numéro d'immatriculation"
        '
        'txtNumImmat
        '
        Me.txtNumImmat.Location = New System.Drawing.Point(290, 222)
        Me.txtNumImmat.Name = "txtNumImmat"
        Me.txtNumImmat.Size = New System.Drawing.Size(123, 20)
        Me.txtNumImmat.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(445, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "numéro de série"
        '
        'txtNumSérie
        '
        Me.txtNumSérie.Location = New System.Drawing.Point(446, 222)
        Me.txtNumSérie.Name = "txtNumSérie"
        Me.txtNumSérie.Size = New System.Drawing.Size(215, 20)
        Me.txtNumSérie.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(694, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "puissance"
        '
        'txtPuissance
        '
        Me.txtPuissance.Location = New System.Drawing.Point(695, 222)
        Me.txtPuissance.Name = "txtPuissance"
        Me.txtPuissance.Size = New System.Drawing.Size(77, 20)
        Me.txtPuissance.TabIndex = 10
        '
        'cmdEnr
        '
        Me.cmdEnr.Location = New System.Drawing.Point(246, 318)
        Me.cmdEnr.Name = "cmdEnr"
        Me.cmdEnr.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnr.TabIndex = 14
        Me.cmdEnr.Text = "J'enregistre"
        Me.cmdEnr.UseVisualStyleBackColor = True
        '
        'cmdIntroduction
        '
        Me.cmdIntroduction.Location = New System.Drawing.Point(348, 318)
        Me.cmdIntroduction.Name = "cmdIntroduction"
        Me.cmdIntroduction.Size = New System.Drawing.Size(75, 23)
        Me.cmdIntroduction.TabIndex = 15
        Me.cmdIntroduction.Text = "&Introduction"
        Me.cmdIntroduction.UseVisualStyleBackColor = True
        '
        'btnDossier
        '
        Me.btnDossier.Location = New System.Drawing.Point(461, 318)
        Me.btnDossier.Name = "btnDossier"
        Me.btnDossier.Size = New System.Drawing.Size(75, 23)
        Me.btnDossier.TabIndex = 16
        Me.btnDossier.Text = "&Dossier"
        Me.btnDossier.UseVisualStyleBackColor = True
        '
        'frmSaisieBien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 379)
        Me.Controls.Add(Me.btnDossier)
        Me.Controls.Add(Me.cmdIntroduction)
        Me.Controls.Add(Me.cmdEnr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPuissance)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumSérie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNumImmat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAnneeModele)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtd1ereImmat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSaisieBien"
        Me.Text = "frmSaisieBien"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtd1ereImmat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAnneeModele As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumImmat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNumSérie As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPuissance As System.Windows.Forms.TextBox
    Friend WithEvents cmdEnr As System.Windows.Forms.Button
    Friend WithEvents cmdIntroduction As System.Windows.Forms.Button
    Friend WithEvents lblVehicule As System.Windows.Forms.Label
    Friend WithEvents btnDossier As System.Windows.Forms.Button
End Class
