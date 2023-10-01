<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeCitiBank
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

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
        Me.DGVCiti = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.identifiant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adressord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdBankord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numCpte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdeAgenceOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ribOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montantChif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.devise = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lettresOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomBef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adressBef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdbankBef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numCpteBef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdAgenceBef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ribBef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomBankBef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adresseBankBef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detailSwiftBef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detailPaie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typepaiement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typeclients = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typeEmetture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.optionemeture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numguichet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImprimer = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        CType(Me.DGVCiti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVCiti
        '
        Me.DGVCiti.AllowUserToAddRows = False
        Me.DGVCiti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVCiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVCiti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.identifiant, Me.nomord, Me.adressord, Me.cdBankord, Me.numCpte, Me.cdeAgenceOrd, Me.ribOrd, Me.montantChif, Me.devise, Me.lettresOrd, Me.nomBef, Me.adressBef, Me.cdbankBef, Me.numCpteBef, Me.cdAgenceBef, Me.ribBef, Me.nomBankBef, Me.adresseBankBef, Me.detailSwiftBef, Me.detailPaie, Me.typepaiement, Me.typeclients, Me.typeEmetture, Me.optionemeture, Me.numguichet})
        Me.DGVCiti.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
        Me.DGVCiti.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.DGVCiti.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGVCiti.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGVCiti.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGVCiti.Location = New System.Drawing.Point(14, 12)
        Me.DGVCiti.Name = "DGVCiti"
        Me.DGVCiti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGVCiti.Size = New System.Drawing.Size(1330, 597)
        Me.DGVCiti.StateCommon.Background.Color1 = System.Drawing.SystemColors.InactiveCaptionText
        Me.DGVCiti.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.DGVCiti.TabIndex = 0
        '
        'identifiant
        '
        Me.identifiant.HeaderText = "Identifiant"
        Me.identifiant.Name = "identifiant"
        Me.identifiant.Width = 90
        '
        'nomord
        '
        Me.nomord.HeaderText = "D'ordre de Nom"
        Me.nomord.Name = "nomord"
        Me.nomord.Width = 121
        '
        'adressord
        '
        Me.adressord.HeaderText = "Adresse Donneur"
        Me.adressord.Name = "adressord"
        Me.adressord.Width = 126
        '
        'cdBankord
        '
        Me.cdBankord.HeaderText = "Code banque donneur"
        Me.cdBankord.Name = "cdBankord"
        Me.cdBankord.Width = 155
        '
        'numCpte
        '
        Me.numCpte.HeaderText = "Numero Compte"
        Me.numCpte.Name = "numCpte"
        Me.numCpte.Width = 126
        '
        'cdeAgenceOrd
        '
        Me.cdeAgenceOrd.HeaderText = "Code agence donneur"
        Me.cdeAgenceOrd.Name = "cdeAgenceOrd"
        Me.cdeAgenceOrd.Width = 153
        '
        'ribOrd
        '
        Me.ribOrd.HeaderText = "Rib du donneur d'ordre"
        Me.ribOrd.Name = "ribOrd"
        Me.ribOrd.Width = 159
        '
        'montantChif
        '
        Me.montantChif.HeaderText = "Montant en chiffre"
        Me.montantChif.Name = "montantChif"
        Me.montantChif.Width = 135
        '
        'devise
        '
        Me.devise.HeaderText = "Devise"
        Me.devise.Name = "devise"
        Me.devise.Width = 70
        '
        'lettresOrd
        '
        Me.lettresOrd.HeaderText = "Lettres du donneur"
        Me.lettresOrd.Name = "lettresOrd"
        Me.lettresOrd.Width = 136
        '
        'nomBef
        '
        Me.nomBef.HeaderText = "Nom du bénéficiaire"
        Me.nomBef.Name = "nomBef"
        Me.nomBef.Width = 144
        '
        'adressBef
        '
        Me.adressBef.HeaderText = "Adresse du bénéficiaire"
        Me.adressBef.Name = "adressBef"
        Me.adressBef.Width = 158
        '
        'cdbankBef
        '
        Me.cdbankBef.HeaderText = "Code banque bénéficiaire"
        Me.cdbankBef.Name = "cdbankBef"
        Me.cdbankBef.Width = 171
        '
        'numCpteBef
        '
        Me.numCpteBef.HeaderText = "Numéro Compte bénéficiaire"
        Me.numCpteBef.Name = "numCpteBef"
        Me.numCpteBef.Width = 190
        '
        'cdAgenceBef
        '
        Me.cdAgenceBef.HeaderText = "Code agence bénéficiaire"
        Me.cdAgenceBef.Name = "cdAgenceBef"
        Me.cdAgenceBef.Width = 169
        '
        'ribBef
        '
        Me.ribBef.HeaderText = "Rib du bénéficiaire"
        Me.ribBef.Name = "ribBef"
        Me.ribBef.Width = 134
        '
        'nomBankBef
        '
        Me.nomBankBef.HeaderText = "Nom banque du bénéficiaire"
        Me.nomBankBef.Name = "nomBankBef"
        Me.nomBankBef.Width = 187
        '
        'adresseBankBef
        '
        Me.adresseBankBef.HeaderText = "Adresse banque bénéficiaire"
        Me.adresseBankBef.Name = "adresseBankBef"
        Me.adresseBankBef.Width = 184
        '
        'detailSwiftBef
        '
        Me.detailSwiftBef.HeaderText = "Détails Swift bénéficiaire"
        Me.detailSwiftBef.Name = "detailSwiftBef"
        Me.detailSwiftBef.Width = 164
        '
        'detailPaie
        '
        Me.detailPaie.HeaderText = "Détails sur le paiement"
        Me.detailPaie.Name = "detailPaie"
        Me.detailPaie.Width = 155
        '
        'typepaiement
        '
        Me.typepaiement.HeaderText = "Type de paiement"
        Me.typepaiement.Name = "typepaiement"
        Me.typepaiement.Width = 131
        '
        'typeclients
        '
        Me.typeclients.HeaderText = "Type de Personne"
        Me.typeclients.Name = "typeclients"
        Me.typeclients.Width = 130
        '
        'typeEmetture
        '
        Me.typeEmetture.HeaderText = "Type d'emetture"
        Me.typeEmetture.Name = "typeEmetture"
        Me.typeEmetture.Width = 123
        '
        'optionemeture
        '
        Me.optionemeture.HeaderText = "Option d'emie"
        Me.optionemeture.Name = "optionemeture"
        Me.optionemeture.Width = 112
        '
        'numguichet
        '
        Me.numguichet.HeaderText = "Numéro du guichet"
        Me.numguichet.Name = "numguichet"
        Me.numguichet.Width = 140
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(399, 614)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(227, 21)
        Me.TextBox1.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 618)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Zone de Recherche"
        '
        'btnImprimer
        '
        Me.btnImprimer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnImprimer.BackgroundImage = Global.GSVBancaire.My.Resources.Resources.agt_print
        Me.btnImprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimer.ForeColor = System.Drawing.Color.BlueViolet
        Me.btnImprimer.Location = New System.Drawing.Point(686, 609)
        Me.btnImprimer.Name = "btnImprimer"
        Me.btnImprimer.Size = New System.Drawing.Size(125, 30)
        Me.btnImprimer.TabIndex = 36
        Me.btnImprimer.Text = "     Imprimer"
        Me.btnImprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimer.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.BackgroundImage = Global.GSVBancaire.My.Resources.Resources.btSupprimer32
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.BlueViolet
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(983, 609)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(126, 30)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Fermer"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnAjouter.BackgroundImage = Global.GSVBancaire.My.Resources.Resources.profil_etendu
        Me.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.Color.BlueViolet
        Me.btnAjouter.Location = New System.Drawing.Point(834, 609)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(125, 30)
        Me.btnAjouter.TabIndex = 34
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'ListeCitiBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1366, 623)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnImprimer)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.DGVCiti)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbonAppMenu
        Me.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar
        Me.Name = "ListeCitiBank"
        Me.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StateCommon.Border.Color2 = System.Drawing.Color.Maroon
        Me.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StateCommon.Header.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StateCommon.Header.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.Text = "LISTE DES DEMANDES DE TOUS LES TRANSFERT ETRANGER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVCiti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVCiti As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnImprimer As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents identifiant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomord As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adressord As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdBankord As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numCpte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdeAgenceOrd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ribOrd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents montantChif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents devise As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lettresOrd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomBef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adressBef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdbankBef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numCpteBef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdAgenceBef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ribBef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomBankBef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adresseBankBef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detailSwiftBef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detailPaie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents typepaiement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents typeclients As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents typeEmetture As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents optionemeture As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numguichet As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
