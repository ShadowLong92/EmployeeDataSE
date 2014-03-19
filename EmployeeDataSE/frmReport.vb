Imports System.Text.RegularExpressions

Class frmReport

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.user
        Me.Text = "Laporan"
        MakeMdiParent()
        GenerateReport()
    End Sub

    Private Sub GenerateReport()
        Dim Report As String

        Report = Regex.Unescape("Staff ID: " + Id + " (" + Status + ")\n" + _
            "Nama: " + UserName + "\n" + _
            "No. Jabatan: " + NoJbt + "\n" + _
            "No. Pengenalan: " + UIC + "\n" + _
            "No. KWSP: " + KWSP + "\n" + _
            "Tarikh Dilantik: " + DateAppointed + "\n" + _
            "Pengesahan Lantikan: " + DateApproved + "\n" + _
            "Disahkan dalam Jawatan: " + Approved + "\n" + _
            "Pilihan Umur Persaraan: " + AgeChoicePensions + "\n" + _
            "Tarikh Persaraan Wajib: " + DatePensions + "\n" + _
            "Cuti yang Berkaitan: " + RelatedHoliday + "\n" + _
            "Tarikh Lahir: " + BDate + "\n" + _
            "Tempat Lahir: " + BAddress + "\n" + _
            "Alamat Rumah: " + Address + "\n" + _
            "Jantina: " + Sex + "\n" + _
            "Agama: " + Religion + "\n" + _
            "Waris 1: " + Waris1 + "\n" + _
            "Waris 2: " + Waris2 + "\n" + _
            "Kelayakan: " + Qualified + "\n\n" + _
            "Kursus - Kursus: \n" + KK + "\n\n" + _
            "APC: \n" + APC + "\n\n" + _
            "Tindakkan Tatatertib: \n" + TT + "\n\n" + _
            "Sejarah Lantikan: \n" + SL + "\n")

        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\Report.LOL", Report, False)
        ieReport.Navigate(My.Application.Info.DirectoryPath + "\Report.LOL")
    End Sub

    Private Sub tsmiPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiPrint.Click
        ieReport.ShowPrintDialog()
    End Sub

    Private Sub tsmiPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiPrintPreview.Click
        ieReport.ShowPrintPreviewDialog()
    End Sub
End Class