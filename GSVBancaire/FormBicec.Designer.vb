<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBicec
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtpays = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcdBic = New System.Windows.Forms.TextBox()
        Me.txtnomBanK = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtadressBank = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtpaysbenf = New System.Windows.Forms.TextBox()
        Me.Cmbbenf = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbenef = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtadressbenf = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtadresseD = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtnomD = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnCpteD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmodif = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CheckB = New System.Windows.Forms.CheckBox()
        Me.CheckS = New System.Windows.Forms.CheckBox()
        Me.CheckO = New System.Windows.Forms.CheckBox()
        Me.txtmttlettre = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtmttdfcfa = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtmttdevise = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Cmbdev = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckP = New System.Windows.Forms.CheckBox()
        Me.CheckV = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnomAgec = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtiban = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtrib = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnQte = New System.Windows.Forms.Button()
        Me.btnSup = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Location = New System.Drawing.Point(4, 241)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(675, 185)
        Me.Panel4.TabIndex = 49
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.txtpays)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtcdBic)
        Me.GroupBox3.Controls.Add(Me.txtnomBanK)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtadressBank)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(662, 162)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BANQUE DU BENEFICIAIRE (ne pas remseigner en cas de demande de chèque en devise)"
        '
        'txtpays
        '
        Me.txtpays.Enabled = False
        Me.txtpays.Location = New System.Drawing.Point(450, 52)
        Me.txtpays.Name = "txtpays"
        Me.txtpays.Size = New System.Drawing.Size(172, 20)
        Me.txtpays.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(345, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Pays"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(345, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Code BIC (SWIFT) :"
        '
        'txtcdBic
        '
        Me.txtcdBic.Location = New System.Drawing.Point(449, 24)
        Me.txtcdBic.Name = "txtcdBic"
        Me.txtcdBic.Size = New System.Drawing.Size(173, 20)
        Me.txtcdBic.TabIndex = 50
        '
        'txtnomBanK
        '
        Me.txtnomBanK.Enabled = False
        Me.txtnomBanK.Location = New System.Drawing.Point(77, 26)
        Me.txtnomBanK.Name = "txtnomBanK"
        Me.txtnomBanK.Size = New System.Drawing.Size(255, 20)
        Me.txtnomBanK.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Nom "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Adresse "
        '
        'txtadressBank
        '
        Me.txtadressBank.Enabled = False
        Me.txtadressBank.Location = New System.Drawing.Point(77, 52)
        Me.txtadressBank.Name = "txtadressBank"
        Me.txtadressBank.Size = New System.Drawing.Size(255, 20)
        Me.txtadressBank.TabIndex = 48
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtpaysbenf)
        Me.GroupBox2.Controls.Add(Me.Cmbbenf)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtbenef)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtadressbenf)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 246)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BENEFICIAIRE"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(18, 165)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(105, 13)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Code du Bénéficiaire"
        '
        'txtpaysbenf
        '
        Me.txtpaysbenf.Enabled = False
        Me.txtpaysbenf.Location = New System.Drawing.Point(135, 128)
        Me.txtpaysbenf.Name = "txtpaysbenf"
        Me.txtpaysbenf.Size = New System.Drawing.Size(147, 20)
        Me.txtpaysbenf.TabIndex = 45
        '
        'Cmbbenf
        '
        Me.Cmbbenf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbbenf.FormattingEnabled = True
        Me.Cmbbenf.Location = New System.Drawing.Point(135, 162)
        Me.Cmbbenf.Name = "Cmbbenf"
        Me.Cmbbenf.Size = New System.Drawing.Size(175, 21)
        Me.Cmbbenf.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Pays du bénéficiaire"
        '
        'txtbenef
        '
        Me.txtbenef.Enabled = False
        Me.txtbenef.Location = New System.Drawing.Point(135, 65)
        Me.txtbenef.Name = "txtbenef"
        Me.txtbenef.Size = New System.Drawing.Size(269, 20)
        Me.txtbenef.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Nom de Bénéficiaire"
        '
        'txtadressbenf
        '
        Me.txtadressbenf.Enabled = False
        Me.txtadressbenf.Location = New System.Drawing.Point(135, 97)
        Me.txtadressbenf.Name = "txtadressbenf"
        Me.txtadressbenf.Size = New System.Drawing.Size(269, 20)
        Me.txtadressbenf.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Adresse du Bénéficiaire"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Location = New System.Drawing.Point(5, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(674, 235)
        Me.Panel2.TabIndex = 53
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox4.Controls.Add(Me.txtadresseD)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtnomD)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtnCpteD)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtmodif)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.txtmttlettre)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtmttdfcfa)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtmttdevise)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Cmbdev)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Location = New System.Drawing.Point(5, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox4.Size = New System.Drawing.Size(647, 217)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DONNEUR D'ORDRE"
        '
        'txtadresseD
        '
        Me.txtadresseD.Location = New System.Drawing.Point(170, 121)
        Me.txtadresseD.Name = "txtadresseD"
        Me.txtadresseD.Size = New System.Drawing.Size(161, 20)
        Me.txtadresseD.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Adresse  du donneur              :"
        '
        'txtnomD
        '
        Me.txtnomD.Location = New System.Drawing.Point(170, 95)
        Me.txtnomD.Name = "txtnomD"
        Me.txtnomD.Size = New System.Drawing.Size(161, 20)
        Me.txtnomD.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Nom du donneur                    :"
        '
        'txtnCpteD
        '
        Me.txtnCpteD.Location = New System.Drawing.Point(170, 69)
        Me.txtnCpteD.Name = "txtnCpteD"
        Me.txtnCpteD.Size = New System.Drawing.Size(161, 20)
        Me.txtnCpteD.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "N° de Compte du donneur      :"
        '
        'txtmodif
        '
        Me.txtmodif.Location = New System.Drawing.Point(350, 151)
        Me.txtmodif.Multiline = True
        Me.txtmodif.Name = "txtmodif"
        Me.txtmodif.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtmodif.Size = New System.Drawing.Size(257, 48)
        Me.txtmodif.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(347, 132)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Modif du virement :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CheckB)
        Me.GroupBox5.Controls.Add(Me.CheckS)
        Me.GroupBox5.Controls.Add(Me.CheckO)
        Me.GroupBox5.Location = New System.Drawing.Point(350, 47)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(257, 53)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Type de frais (*)"
        '
        'CheckB
        '
        Me.CheckB.AutoSize = True
        Me.CheckB.Location = New System.Drawing.Point(28, 20)
        Me.CheckB.Name = "CheckB"
        Me.CheckB.Size = New System.Drawing.Size(48, 17)
        Me.CheckB.TabIndex = 2
        Me.CheckB.Text = "BEN"
        Me.CheckB.UseVisualStyleBackColor = True
        '
        'CheckS
        '
        Me.CheckS.AutoSize = True
        Me.CheckS.Location = New System.Drawing.Point(189, 19)
        Me.CheckS.Name = "CheckS"
        Me.CheckS.Size = New System.Drawing.Size(48, 17)
        Me.CheckS.TabIndex = 1
        Me.CheckS.Text = "SHA"
        Me.CheckS.UseVisualStyleBackColor = True
        '
        'CheckO
        '
        Me.CheckO.AutoSize = True
        Me.CheckO.Location = New System.Drawing.Point(110, 19)
        Me.CheckO.Name = "CheckO"
        Me.CheckO.Size = New System.Drawing.Size(50, 17)
        Me.CheckO.TabIndex = 0
        Me.CheckO.Text = "OUR"
        Me.CheckO.UseVisualStyleBackColor = True
        '
        'txtmttlettre
        '
        Me.txtmttlettre.Location = New System.Drawing.Point(120, 155)
        Me.txtmttlettre.Multiline = True
        Me.txtmttlettre.Name = "txtmttlettre"
        Me.txtmttlettre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtmttlettre.Size = New System.Drawing.Size(211, 48)
        Me.txtmttlettre.TabIndex = 42
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 155)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Montant en lettres"
        '
        'txtmttdfcfa
        '
        Me.txtmttdfcfa.Location = New System.Drawing.Point(170, 44)
        Me.txtmttdfcfa.Name = "txtmttdfcfa"
        Me.txtmttdfcfa.Size = New System.Drawing.Size(161, 20)
        Me.txtmttdfcfa.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(153, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Pour un montant en  FCFA de :"
        '
        'txtmttdevise
        '
        Me.txtmttdevise.Location = New System.Drawing.Point(170, 20)
        Me.txtmttdevise.Name = "txtmttdevise"
        Me.txtmttdevise.Size = New System.Drawing.Size(161, 20)
        Me.txtmttdevise.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(158, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Pour un montant en  devise de :"
        '
        'Cmbdev
        '
        Me.Cmbdev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbdev.FormattingEnabled = True
        Me.Cmbdev.Location = New System.Drawing.Point(460, 16)
        Me.Cmbdev.Name = "Cmbdev"
        Me.Cmbdev.Size = New System.Drawing.Size(147, 21)
        Me.Cmbdev.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(347, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 13)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Devise du Transfert"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtnomAgec)
        Me.Panel1.Location = New System.Drawing.Point(686, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 363)
        Me.Panel1.TabIndex = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.CheckP)
        Me.GroupBox1.Controls.Add(Me.CheckV)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 45)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paiement Par :"
        '
        'CheckP
        '
        Me.CheckP.AutoSize = True
        Me.CheckP.Location = New System.Drawing.Point(152, 17)
        Me.CheckP.Name = "CheckP"
        Me.CheckP.Size = New System.Drawing.Size(135, 17)
        Me.CheckP.TabIndex = 1
        Me.CheckP.Text = "Emission de Chèque (*)"
        Me.CheckP.UseVisualStyleBackColor = True
        '
        'CheckV
        '
        Me.CheckV.AutoSize = True
        Me.CheckV.Location = New System.Drawing.Point(64, 17)
        Me.CheckV.Name = "CheckV"
        Me.CheckV.Size = New System.Drawing.Size(67, 17)
        Me.CheckV.TabIndex = 0
        Me.CheckV.Text = "Virement"
        Me.CheckV.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nom de l'agence"
        '
        'txtnomAgec
        '
        Me.txtnomAgec.BackColor = System.Drawing.Color.White
        Me.txtnomAgec.Location = New System.Drawing.Point(118, 62)
        Me.txtnomAgec.Multiline = True
        Me.txtnomAgec.Name = "txtnomAgec"
        Me.txtnomAgec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtnomAgec.Size = New System.Drawing.Size(249, 23)
        Me.txtnomAgec.TabIndex = 27
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.txtiban)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.txtrib)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 79)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(613, 80)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Compte du bénéficiaire (*) :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(28, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(238, 13)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Identifiant international de compte bancaire-IBAN"
        '
        'txtiban
        '
        Me.txtiban.Location = New System.Drawing.Point(272, 46)
        Me.txtiban.Name = "txtiban"
        Me.txtiban.Size = New System.Drawing.Size(167, 20)
        Me.txtiban.TabIndex = 60
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(28, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(211, 13)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Identifiant national de compte bancaire-RIB"
        '
        'txtrib
        '
        Me.txtrib.Location = New System.Drawing.Point(241, 20)
        Me.txtrib.Name = "txtrib"
        Me.txtrib.Size = New System.Drawing.Size(198, 20)
        Me.txtrib.TabIndex = 58
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Navy
        Me.btnSave.Image = Global.GSVBancaire.My.Resources.Resources.ok
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(720, 376)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 29)
        Me.btnSave.TabIndex = 55
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnQte
        '
        Me.btnQte.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnQte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQte.ForeColor = System.Drawing.Color.Navy
        Me.btnQte.Image = Global.GSVBancaire.My.Resources.Resources.button_cancel
        Me.btnQte.Location = New System.Drawing.Point(1002, 376)
        Me.btnQte.Name = "btnQte"
        Me.btnQte.Size = New System.Drawing.Size(129, 29)
        Me.btnQte.TabIndex = 52
        Me.btnQte.Text = "Fermer"
        Me.btnQte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQte.UseVisualStyleBackColor = False
        '
        'btnSup
        '
        Me.btnSup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSup.ForeColor = System.Drawing.Color.Navy
        Me.btnSup.Image = Global.GSVBancaire.My.Resources.Resources.eraser
        Me.btnSup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSup.Location = New System.Drawing.Point(861, 376)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.Size = New System.Drawing.Size(129, 29)
        Me.btnSup.TabIndex = 51
        Me.btnSup.Text = "Supprimer"
        Me.btnSup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSup.UseVisualStyleBackColor = False
        '
        'FormBicec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1165, 438)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnQte)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSup)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FormBicec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBicec"
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpays As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcdBic As System.Windows.Forms.TextBox
    Friend WithEvents txtnomBanK As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtadressBank As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtpaysbenf As System.Windows.Forms.TextBox
    Friend WithEvents Cmbbenf As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbenef As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtadressbenf As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtadresseD As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtnomD As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtnCpteD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmodif As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckB As System.Windows.Forms.CheckBox
    Friend WithEvents CheckS As System.Windows.Forms.CheckBox
    Friend WithEvents CheckO As System.Windows.Forms.CheckBox
    Friend WithEvents txtmttlettre As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtmttdfcfa As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtmttdevise As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Cmbdev As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnQte As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckP As System.Windows.Forms.CheckBox
    Friend WithEvents CheckV As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnomAgec As System.Windows.Forms.TextBox
    Friend WithEvents btnSup As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtiban As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtrib As System.Windows.Forms.TextBox
End Class
