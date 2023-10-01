Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim etat As New CrystalReport1
        Dim log As Byte()
        log = File.ReadAllBytes("D:\logo-citi.jpg")
        Dim l As New List(Of Document)
        Dim doc As New Document("Nous vous prions de le faire rapidement", "rien à signaler pour ceci", _
                                "rue CRTV Bonanjo douala", "CITI", 93, 258639745, 753698741, 78956, 78963, _
                                "Douala Brazzaville", "Couakam Njamen Guy Jeuner", "deux million cinq cent", "cfa", _
                                2500000, 56, 15986347, 74568, 85269, "Bonamoussadi terminus", "Onguene Daniel", log, _
                                True, False, False, True, True, False, False, False, True, "transfert", "Douala", "Yaoundé", "Tél. : (237) 33 42 42 72", _
                                "Tél. : (237) 22 21 27 77", "B.P 4571 - Douala, Cameroun", "B.P 7324 - Yaoundé, Cameroun", "BICEC")


        l.Add(doc)
        etat.SetDataSource(l)
        Me.CrystalReportViewer1.ReportSource = etat
    End Sub
End Class
