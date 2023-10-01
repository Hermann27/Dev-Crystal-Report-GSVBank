Imports DAL
Imports Crt
Imports System.Data.SqlClient
Imports System.IO
Public Class ListeCitiBank
    Dim objet As New ClassConnexion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        With FormCitiBank
            .btnSave.Text = "Save"
            .ShowDialog()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub Affichage()
        Dim conn = objet.ConnexionBD("DJOUMDJEU-PC\SERVER2008", "SA", "@IUC-PA2", "BDTransfertEtranger")
        Dim OleAfficheAdapt As SqlDataAdapter
        Dim AfficheDs As New DataSet
        Dim AfficheTab As DataTable
        DGVCiti.Rows.Clear()
        Try
            OleAfficheAdapt = New SqlDataAdapter("SELECT * FROM TableCitiBank", conn)
            OleAfficheAdapt.Fill(AfficheDs)
            AfficheTab = AfficheDs.Tables(0)
            If AfficheTab.Rows.Count <> 0 Then
                DGVCiti.RowCount = AfficheTab.Rows.Count
                For i As Integer = 0 To AfficheTab.Rows.Count - 1
                    DGVCiti.Rows(i).Cells("identifiant").Value = AfficheTab.Rows(i).Item("identifiant")
                    DGVCiti.Rows(i).Cells("nomord").Value = AfficheTab.Rows(i).Item("nomord")
                    DGVCiti.Rows(i).Cells("adressord").Value = AfficheTab.Rows(i).Item("adressord")
                    DGVCiti.Rows(i).Cells("cdBankord").Value = AfficheTab.Rows(i).Item("cdBankord")
                    DGVCiti.Rows(i).Cells("numCpte").Value = AfficheTab.Rows(i).Item("numCpte")
                    DGVCiti.Rows(i).Cells("cdeAgenceOrd").Value = AfficheTab.Rows(i).Item("cdeAgenceOrd")

                    DGVCiti.Rows(i).Cells("ribOrd").Value = AfficheTab.Rows(i).Item("ribOrd")
                    DGVCiti.Rows(i).Cells("montantChif").Value = AfficheTab.Rows(i).Item("montantChif")
                    DGVCiti.Rows(i).Cells("devise").Value = AfficheTab.Rows(i).Item("devise")
                    DGVCiti.Rows(i).Cells("lettresOrd").Value = AfficheTab.Rows(i).Item("lettresOrd")
                    DGVCiti.Rows(i).Cells("nomBef").Value = AfficheTab.Rows(i).Item("nomBef")
                    DGVCiti.Rows(i).Cells("adressBef").Value = AfficheTab.Rows(i).Item("adressBef")

                    DGVCiti.Rows(i).Cells("cdbankBef").Value = AfficheTab.Rows(i).Item("cdbankBef")
                    DGVCiti.Rows(i).Cells("numCpteBef").Value = AfficheTab.Rows(i).Item("numCpteBef")
                    DGVCiti.Rows(i).Cells("cdAgenceBef").Value = AfficheTab.Rows(i).Item("cdAgenceBef")
                    DGVCiti.Rows(i).Cells("ribBef").Value = AfficheTab.Rows(i).Item("ribBef")
                    DGVCiti.Rows(i).Cells("nomBankBef").Value = AfficheTab.Rows(i).Item("nomBankBef")
                    DGVCiti.Rows(i).Cells("adresseBankBef").Value = AfficheTab.Rows(i).Item("adresseBankBef")

                    DGVCiti.Rows(i).Cells("detailSwiftBef").Value = AfficheTab.Rows(i).Item("detailSwiftBef")
                    DGVCiti.Rows(i).Cells("detailPaie").Value = AfficheTab.Rows(i).Item("detailPaie")
                    DGVCiti.Rows(i).Cells("typepaiement").Value = AfficheTab.Rows(i).Item("typepaiement")
                    DGVCiti.Rows(i).Cells("typeclients").Value = AfficheTab.Rows(i).Item("typeclient")
                    DGVCiti.Rows(i).Cells("typeEmetture").Value = AfficheTab.Rows(i).Item("typeEmetture")
                    DGVCiti.Rows(i).Cells("optionemeture").Value = AfficheTab.Rows(i).Item("optionemeture")
                    DGVCiti.Rows(i).Cells("numguichet").Value = AfficheTab.Rows(i).Item("numguichet")
                Next
            Else
                DGVCiti.DataSource = AfficheDs
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            conn.Open()
        End Try
    End Sub

    Public Sub ListeCitiBank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Affichage()
    End Sub

    Private Sub DGVCiti_Click(sender As Object, e As EventArgs) Handles DGVCiti.Click
        With FormCitiBank
            .btnSave.Text = "Modifier"
            If DGVCiti.SelectedRows.Count > 0 Then
                .txtnomD.Text = DGVCiti.SelectedRows(0).Cells(1).Value
                .txtadrD.Text = DGVCiti.SelectedRows(0).Cells(2).Value
                .txtBK.Text = DGVCiti.SelectedRows(0).Cells(3).Value
                .txtnCpte.Text = DGVCiti.SelectedRows(0).Cells(4).Value
                .txtCdag.Text = DGVCiti.SelectedRows(0).Cells(5).Value

                .txtRibord.Text = DGVCiti.SelectedRows(0).Cells(6).Value
                .txtmttChf.Text = DGVCiti.SelectedRows(0).Cells(7).Value
                .txtdevise.Text = DGVCiti.SelectedRows(0).Cells(8).Value
                .txtlettre.Text = DGVCiti.SelectedRows(0).Cells(9).Value
                .txtnomB.Text = DGVCiti.SelectedRows(0).Cells(10).Value

                .txtadreB.Text = DGVCiti.SelectedRows(0).Cells(11).Value
                .txtcdbkB.Text = DGVCiti.SelectedRows(0).Cells(12).Value
                .txtncptB.Text = DGVCiti.SelectedRows(0).Cells(13).Value
                .txtcdAgB.Text = DGVCiti.SelectedRows(0).Cells(14).Value
                .txtrib.Text = DGVCiti.SelectedRows(0).Cells(15).Value

                .txtnameBKB.Text = DGVCiti.SelectedRows(0).Cells(16).Value
                .txtadrBKb.Text = DGVCiti.SelectedRows(0).Cells(17).Value
                .txtdetailSB.Text = DGVCiti.SelectedRows(0).Cells(18).Value
                .txtdetailpaie.Text = DGVCiti.SelectedRows(0).Cells(19).Value
                .txtguichet.Text = DGVCiti.SelectedRows(0).Cells(24).Value
            End If
            .ShowDialog()
        End With
    End Sub

    Private Sub btnImprimer_Click(sender As Object, e As EventArgs) Handles btnImprimer.Click
        Try
            imprimerRDV()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub imprimerRDV()
        Dim dt As New DataTable
        With dt
            .Columns.Add("identifiant")
            .Columns.Add("nomord")
            .Columns.Add("adressord ")
            .Columns.Add("cdBankord")
            .Columns.Add("numCpte")
            .Columns.Add("cdeAgenceOrd")
            .Columns.Add("ribOrd")
            .Columns.Add("montantChif")
            .Columns.Add("devise")
            .Columns.Add("lettresOrd")
            .Columns.Add("nomBef")
            .Columns.Add("adressBef")
            .Columns.Add("cdbankBef")
            .Columns.Add("numCpteBef")
            .Columns.Add("cdAgenceBef")
            .Columns.Add("ribBef")
            .Columns.Add("nomBankBef")
            .Columns.Add("adresseBankBef")
            .Columns.Add("detailSwiftBef")
            .Columns.Add("detailPaie ")
            .Columns.Add("typepaiement")
            .Columns.Add("typeclients")
            .Columns.Add("typeEmetture")
            .Columns.Add("optionemeture")
            .Columns.Add("numguichet ")
            ' .Columns.Add("LogoBin")
        End With
        For Each dr As DataGridViewRow In Me.DGVCiti.Rows
            dt.Rows.Add(dr.Cells("identifiant").Value, _
                        dr.Cells("nomord").Value, _
                        dr.Cells("adressord").Value, _
                        dr.Cells("cdBankord").Value, _
                        dr.Cells("numCpte").Value, _
                        dr.Cells("cdeAgenceOrd").Value, _
                        dr.Cells("ribOrd").Value, _
                        dr.Cells("montantChif").Value, _
                        dr.Cells("devise").Value, _
                        dr.Cells("lettresOrd").Value, _
                        dr.Cells("nomBef").Value, _
                        dr.Cells("adressBef").Value, _
                        dr.Cells("cdbankBef").Value, _
                        dr.Cells("numCpteBef").Value, _
                        dr.Cells("cdAgenceBef").Value, _
                        dr.Cells("ribBef").Value, _
                        dr.Cells("nomBankBef").Value, _
                        dr.Cells("adresseBankBef").Value, _
                        dr.Cells("detailSwiftBef").Value, _
                        dr.Cells("detailPaie").Value, _
                        dr.Cells("typepaiement").Value, _
                        dr.Cells("typeclients").Value, _
                        dr.Cells("typeEmetture").Value, _
                        dr.Cells("optionemeture").Value, _
                        dr.Cells("numguichet").Value) ', _
            '  File.ReadAllBytes("Logo.jpg"))
            ' MsgBox(dr.Cells("numguichet").Value & " " & dr.Cells("detailPaie").Value)
        Next
        Dim log As Byte()
        log = File.ReadAllBytes("Logo.jpg")
        Dim l As New List(Of Document)
        Dim doc As New Document("Nous vous prions de le faire rapidement", "rien à signaler pour ceci", _
                                "rue CRTV Bonanjo douala", "CITI", 93, 258639745, 753698741, 78956, 78963, _
                                "Douala Brazzaville", "Djoumdjeu pougoue hermann junior", "deux million cinq cent", "cfa", _
                                2500000, 56, 15986347, 74568, 85269, "Bonamoussadi terminus", "Onguene Daniel", log, _
                                True, False, False, True, True, False, False, False, True, "transfert", "Douala", "Yaoundé", "Tél. : (237) 33 42 42 72", _
                                "Tél. : (237) 22 21 27 77", "B.P 4571 - Douala, Cameroun", "B.P 7324 - Yaoundé, Cameroun", "BICEC")

        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New CrystalReportBicec
        rptDoc.SetDataSource(dt)
        FormImpression.CrystalReportViewer1.ReportSource = rptDoc
        With FormImpression
            .IsMdiContainer = True
            .ShowDialog()
        End With
        FormImpression.Dispose()
    End Sub
End Class