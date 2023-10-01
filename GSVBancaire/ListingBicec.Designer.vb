<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeBICECS
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
        Me.DGVBicec = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.identifiant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomagce = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typetransfert = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numCpteOdre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdagence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdBankordre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomdonneur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adressOrdre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deviseTransfert = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monttdevise = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monttFcfa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnttlettre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typefrais = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modifV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombenf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adressebenf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paysbenf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomBankbenf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adressBKbenf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paysBank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cdbank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nucptebenf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ribbenf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ibanbenf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DGVBicec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVBicec
        '
        Me.DGVBicec.AllowUserToAddRows = False
        Me.DGVBicec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGVBicec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.identifiant, Me.nomagce, Me.typetransfert, Me.numCpteOdre, Me.cdagence, Me.cdBankordre, Me.rib, Me.nomdonneur, Me.adressOrdre, Me.deviseTransfert, Me.monttdevise, Me.monttFcfa, Me.mnttlettre, Me.typefrais, Me.modifV, Me.nombenf, Me.adressebenf, Me.paysbenf, Me.nomBankbenf, Me.adressBKbenf, Me.paysBank, Me.Cdbank, Me.nucptebenf, Me.ribbenf, Me.ibanbenf})
        Me.DGVBicec.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
        Me.DGVBicec.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.DGVBicec.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGVBicec.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGVBicec.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.DGVBicec.Location = New System.Drawing.Point(14, 0)
        Me.DGVBicec.Name = "DGVBicec"
        Me.DGVBicec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGVBicec.Size = New System.Drawing.Size(1330, 604)
        Me.DGVBicec.StateCommon.Background.Color1 = System.Drawing.SystemColors.InactiveCaptionText
        Me.DGVBicec.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.DGVBicec.TabIndex = 0
        '
        'identifiant
        '
        Me.identifiant.HeaderText = "Identifiant"
        Me.identifiant.Name = "identifiant"
        Me.identifiant.Width = 90
        '
        'nomagce
        '
        Me.nomagce.HeaderText = "Nom de l'agence ordre"
        Me.nomagce.Name = "nomagce"
        Me.nomagce.Width = 157
        '
        'typetransfert
        '
        Me.typetransfert.HeaderText = "Type de Transfert"
        Me.typetransfert.Name = "typetransfert"
        Me.typetransfert.Width = 128
        '
        'numCpteOdre
        '
        Me.numCpteOdre.HeaderText = "Numéro du Compte Ordre"
        Me.numCpteOdre.Name = "numCpteOdre"
        Me.numCpteOdre.Width = 176
        '
        'cdagence
        '
        Me.cdagence.HeaderText = "Code de l'agence"
        Me.cdagence.Name = "cdagence"
        Me.cdagence.Width = 127
        '
        'cdBankordre
        '
        Me.cdBankordre.HeaderText = "Code banque Ordre"
        Me.cdBankordre.Name = "cdBankordre"
        Me.cdBankordre.Width = 140
        '
        'rib
        '
        Me.rib.HeaderText = "Rib du donneur d'ordre"
        Me.rib.Name = "rib"
        Me.rib.Width = 159
        '
        'nomdonneur
        '
        Me.nomdonneur.HeaderText = "Nom du donneur Ordre"
        Me.nomdonneur.Name = "nomdonneur"
        Me.nomdonneur.Width = 161
        '
        'adressOrdre
        '
        Me.adressOrdre.HeaderText = "Adresse du donneur Ordre"
        Me.adressOrdre.Name = "adressOrdre"
        Me.adressOrdre.Width = 175
        '
        'deviseTransfert
        '
        Me.deviseTransfert.HeaderText = "Devise du Transfert"
        Me.deviseTransfert.Name = "deviseTransfert"
        Me.deviseTransfert.Width = 137
        '
        'monttdevise
        '
        Me.monttdevise.HeaderText = "Montant Correspond à la devise"
        Me.monttdevise.Name = "monttdevise"
        Me.monttdevise.Width = 204
        '
        'monttFcfa
        '
        Me.monttFcfa.HeaderText = "Montant en FCFA"
        Me.monttFcfa.Name = "monttFcfa"
        Me.monttFcfa.Width = 129
        '
        'mnttlettre
        '
        Me.mnttlettre.HeaderText = "Montant en lettre"
        Me.mnttlettre.Name = "mnttlettre"
        Me.mnttlettre.Width = 128
        '
        'typefrais
        '
        Me.typefrais.HeaderText = "Type de frais(*)"
        Me.typefrais.Name = "typefrais"
        Me.typefrais.Width = 116
        '
        'modifV
        '
        Me.modifV.HeaderText = "Modif du Virement"
        Me.modifV.Name = "modifV"
        Me.modifV.Width = 136
        '
        'nombenf
        '
        Me.nombenf.HeaderText = "Nom du bénéficiaire"
        Me.nombenf.Name = "nombenf"
        Me.nombenf.Width = 144
        '
        'adressebenf
        '
        Me.adressebenf.HeaderText = "Adresse du bénéficiaire"
        Me.adressebenf.Name = "adressebenf"
        Me.adressebenf.Width = 158
        '
        'paysbenf
        '
        Me.paysbenf.HeaderText = "Pays du bénéficiaire"
        Me.paysbenf.Name = "paysbenf"
        Me.paysbenf.Width = 141
        '
        'nomBankbenf
        '
        Me.nomBankbenf.HeaderText = "Banque du bénéficiaire"
        Me.nomBankbenf.Name = "nomBankbenf"
        Me.nomBankbenf.Width = 157
        '
        'adressBKbenf
        '
        Me.adressBKbenf.HeaderText = "Adresse Banque du bénéficiaire"
        Me.adressBKbenf.Name = "adressBKbenf"
        Me.adressBKbenf.Width = 201
        '
        'paysBank
        '
        Me.paysBank.HeaderText = "Pays de la Banque"
        Me.paysBank.Name = "paysBank"
        Me.paysBank.Width = 131
        '
        'Cdbank
        '
        Me.Cdbank.HeaderText = "Code de la banque"
        Me.Cdbank.Name = "Cdbank"
        Me.Cdbank.Width = 135
        '
        'nucptebenf
        '
        Me.nucptebenf.HeaderText = "Numéro Compte bénéficiaire"
        Me.nucptebenf.Name = "nucptebenf"
        Me.nucptebenf.Width = 190
        '
        'ribbenf
        '
        Me.ribbenf.HeaderText = "RIB du bénéficiaire"
        Me.ribbenf.Name = "ribbenf"
        Me.ribbenf.Width = 134
        '
        'ibanbenf
        '
        Me.ibanbenf.HeaderText = "IBAN Compte bancaire"
        Me.ibanbenf.Name = "ibanbenf"
        Me.ibanbenf.Width = 157
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.BackgroundImage = Global.GSVBancaire.My.Resources.Resources.profil_etendu
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.BlueViolet
        Me.Button1.Location = New System.Drawing.Point(834, 609)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 30)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Ajouter"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button3.BackgroundImage = Global.GSVBancaire.My.Resources.Resources.agt_print
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.BlueViolet
        Me.Button3.Location = New System.Drawing.Point(686, 609)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 30)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "     Imprimer"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ListeBICECS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1366, 623)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGVBicec)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbonAppMenu
        Me.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar
        Me.Name = "ListeBICECS"
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
        CType(Me.DGVBicec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVBicec As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents identifiant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomagce As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents typetransfert As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numCpteOdre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdagence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdBankordre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rib As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomdonneur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adressOrdre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deviseTransfert As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monttdevise As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monttFcfa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mnttlettre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents typefrais As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modifV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombenf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adressebenf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paysbenf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomBankbenf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adressBKbenf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paysBank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cdbank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nucptebenf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ribbenf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ibanbenf As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
