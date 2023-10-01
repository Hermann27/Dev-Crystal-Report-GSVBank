Public Class Document
    Property NomSoc As String
    Property BPSoc1 As String
    Property BPSoc2 As String
    Property TelSoc1 As String
    Property TelSoc2 As String
    Property VilleSoc1 As String
    Property VilleSoc2 As String
    Property TitreDoc As String
    Property Client As Boolean = False
    Property NonClient As Boolean
    Property Staff As Boolean
    Property ChecBan As Boolean
    Property transfert As Boolean
    Property telex As Boolean
    Property swift As Boolean
    Property espece As Boolean
    Property cheque As Boolean
    Property logo As Byte()
    Property ordNom As String
    Property adrord As String

    Property codeban As Integer
    Property codeagence As Integer
    Property numcomp As Integer
    Property rib As Integer
    Property montChiffre As Integer
    Property devise As String
    Property montLettre As String
    Property beneficiaire As String
    Property adrBeneficiaire As String
    Property codebanBene As Integer
    Property codeagenceBene As Integer
    Property numcompBene As Integer
    Property numcomphors As Integer
    Property ribBene As Integer

    Property nomBan As String
    Property adrBan As String
    Property detSwift As String
    Property detPaie As String

    Sub New(detpaie As String, detswift As String, adrban As String, nomban As String, ribBene As Integer, _
            numcomphors As Integer, numcompBene As Integer, codeagenceBene As Integer, codebanbene As Integer, _
            adrbeneficiaire As String, beneficiaire As String, montLettre As String, devise As String, _
            montChiffre As Integer, rib As Integer, numcomp As Integer, codeagence As Integer, codeban As Integer, _
            adrord As String, ordNom As String, logo As Byte(), cheque As Boolean, espece As Boolean, swift As Boolean, _
            telex As Boolean, transfert As Boolean, checban As Boolean, staff As Boolean, nonclient As Boolean, _
            client As Boolean, titredoc As String, villesoc1 As String, villesoc2 As String, telsoc1 As String, _
            telsoc2 As String, bpsoc1 As String, bpsoc2 As String, nomsoc As String)
        Me.adrBan = adrban
        Me.adrBeneficiaire = adrbeneficiaire
        Me.adrord = adrord
        Me.beneficiaire = beneficiaire
        Me.BPSoc1 = bpsoc1
        Me.BPSoc2 = bpsoc2
        Me.ChecBan = checban
        Me.cheque = cheque
        Me.Client = client
        Me.codeagence = codeagence
        Me.codeagenceBene = codeagenceBene
        Me.codeban = codeban
        Me.codebanBene = codebanbene
        Me.detPaie = detpaie
        Me.detSwift = detswift
        Me.devise = devise
        Me.espece = espece
        Me.logo = logo
        Me.montChiffre = montChiffre
        Me.montLettre = montLettre
        Me.nomBan = nomban
        Me.NomSoc = nomsoc
        Me.NonClient = nonclient
        Me.numcomp = numcomp
        Me.numcompBene = numcompBene
        Me.numcomphors = numcomphors
        Me.ordNom = ordNom
        Me.rib = rib
        Me.ribBene = ribBene
        Me.Staff = staff
        Me.swift = swift
        Me.telex = telex
        Me.TelSoc1 = telsoc1
        Me.TelSoc2 = telsoc2
        Me.TitreDoc = titredoc
        Me.transfert = transfert
        Me.VilleSoc1 = villesoc1
        Me.VilleSoc2 = villesoc2

    End Sub


End Class
