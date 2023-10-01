Imports DAL
Imports System.Data.SqlClient
Public Class FormCitiBank
    Dim objt As New ClassConnexion
    Dim Con = objt.ConnexionBD("DJOUMDJEU-PC\SERVER2008", "SA", "@IUC-PA2", "BDTransfertEtranger")
    Dim connexion = objt.ConnexionBD("DJOUMDJEU-PC\SERVER2008", "SA", "@IUC-PA2", "BIJOU")
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Dim Valeur1 As String = ""
    Dim Valeur2 As String = ""
    Dim Valeur3 As String = ""
    Dim Valeur4 As String = ""
    Private Sub FormCitiBank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Query As String = "SELECT CT_Num FROM F_COMPTET"
            Dim Cmd As New SqlCommand(Query, connexion)
            Dim lecture As SqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While lecture.Read
                CombB.Items.Add(lecture("CT_Num").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Close()
            connexion.Open()
        End Try
    End Sub

    Private Sub CombB_SelectedValueChanged(sender As Object, e As EventArgs) Handles CombB.SelectedValueChanged
        Try
            Dim Query As String = "SELECT  C.CT_Num,b.BT_Intitule ,b.BT_Banque, b.BT_Guichet, b.BT_Compte, b.BT_Cle ," & _
            "b.N_Devise, b.BT_Adresse,b.BT_BIC,c.CT_Intitule,c.CT_Adresse FROM F_BANQUET b,F_COMPTET c WHERE b.CT_Num=c.CT_Num AND c.CT_Num='" & CombB.SelectedItem & "'"
            Dim Cmd As New SqlCommand(Query, connexion)
            Dim lecture As SqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While lecture.Read
                txtnomB.Text = lecture("CT_Intitule").ToString
                txtadreB.Text = lecture("CT_Adresse").ToString
                txtcdbkB.Text = lecture("BT_Banque").ToString
                txtncptB.Text = lecture("BT_Compte").ToString
                txtcdAgB.Text = lecture("BT_BIC").ToString
                txtrib.Text = lecture("BT_Cle").ToString
                txtnameBKB.Text = lecture("BT_Intitule").ToString
                txtadrBKb.Text = lecture("BT_Adresse").ToString
                txtguichet.Text = lecture("BT_Guichet").ToString
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Close()
            connexion.Open()
        End Try
    End Sub

    Private Sub chchB_CheckedChanged(sender As Object, e As EventArgs) Handles chchB.CheckedChanged
        If chchB.Checked = True Then
            Valeur1 = chchB.Text
            chtxf.Checked = False
            chT.Enabled = True
            chS.Enabled = True
        End If
    End Sub

    Private Sub chtxf_CheckedChanged(sender As Object, e As EventArgs) Handles chtxf.CheckedChanged
        If chtxf.Checked = True Then
            Valeur1 = chtxf.Text
            chchB.Checked = False
            chT.Enabled = True
            chS.Enabled = True
        End If
    End Sub
    Private Sub chT_CheckedChanged(sender As Object, e As EventArgs) Handles chT.CheckedChanged
        If chT.Checked = True Then
            Valeur2 = chT.Text
            chS.Checked = False
        End If
    End Sub
    Private Sub chS_CheckedChanged(sender As Object, e As EventArgs) Handles chS.CheckedChanged
        If chS.Checked = True Then
            Valeur2 = chS.Text
            chT.Checked = False
        End If
    End Sub

    Private Sub chclt_CheckedChanged(sender As Object, e As EventArgs) Handles chclt.CheckedChanged
        If chclt.Checked = True Then
            Valeur3 = chclt.Text
            chnclt.Checked = False
            chtypS.Checked = False
        End If
    End Sub

    Private Sub chnclt_CheckedChanged(sender As Object, e As EventArgs) Handles chnclt.CheckedChanged
        If chnclt.Checked = True Then
            Valeur3 = chnclt.Text
            chclt.Checked = False
            chtypS.Checked = False
        End If
    End Sub

    Private Sub chtypS_CheckedChanged(sender As Object, e As EventArgs) Handles chtypS.CheckedChanged
        If chtypS.Checked = True Then
            Valeur3 = chtypS.Text
            chclt.Checked = False
            chnclt.Checked = False
        End If
    End Sub

    Private Sub chEsp_CheckedChanged(sender As Object, e As EventArgs) Handles chEsp.CheckedChanged
        If chEsp.Checked = True Then
            Valeur4 = chEsp.Text
            chpCh.Checked = False
        End If
    End Sub

    Private Sub chpCh_CheckedChanged(sender As Object, e As EventArgs) Handles chpCh.CheckedChanged
        If chpCh.Checked = True Then
            Valeur4 = chpCh.Text
            chEsp.Checked = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Select Case btnSave.Text
            Case Is = "Save"
                insertion()
                Dim FrListe As New ListeCitiBank
                FrListe.ListeCitiBank_Load(sender, e)
            Case Is = "Modifier"

        End Select
    End Sub

    Sub insertion()
        Try
            Dim ch As String = txtc1.Text & txtc2.Text & txtc3.Text & txtc4.Text & txtc5.Text
            Dim QuerySave As String = "INSERT INTO TableCitiBank(" &
     "nomord, " &
     "adressord," &
     "cdBankord," &
     "numCpte," &
     "cdeAgenceOrd," &
      "ribOrd," &
      "montantChif," &
      "devise," &
      "lettresOrd," &
      "nomBef," &
      "adressBef," &
      "cdbankBef," &
      "numCpteBef," &
      "cdAgenceBef," &
      "ribBef," &
      "nomBankBef," &
      "adresseBankBef," &
      "detailSwiftBef," &
      "detailPaie," &
      "typepaiement," &
      "typeclient," &
      "typeEmetture," &
      "optionemeture," &
      "numguichet,IdSoc)VALUES('" & txtnomD.Text & "','" & txtadrD.Text & "','" & ch & "','" & txtnCpte.Text & _
      "','" & txtCdag.Text & "','" & txtRibord.Text & "','" & txtmttChf.Text & "'," & txtdevise.Text & _
      ",'" & txtlettre.Text & "','" & txtnomB.Text & "','" & txtadreB.Text & "','" & txtcdbkB.Text & "','" & _
      txtncptB.Text & "','" & txtcdAgB.Text & "','" & txtrib.Text & "','" & txtnameBKB.Text & "','" & txtadrBKb.Text & _
      "','" & txtdetailSB.Text & "','" & txtdetailpaie.Text & "','" & Valeur4 & "','" & Valeur3 & "','" & Valeur1 & _
      "','" & Valeur2 & "','" & txtguichet.Text & "',1)"
            MsgBox(QuerySave)
            Dim Cmd As New SqlCommand(QuerySave, Con)
            Cmd.ExecuteNonQuery()
            MsgBox("Enregistre effectué avec succès ", MsgBoxStyle.Information, "Virement bancaire de la Citi banque")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
            Con.Open()
        End Try
    End Sub
End Class
