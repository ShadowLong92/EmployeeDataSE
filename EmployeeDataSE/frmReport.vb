Class frmReport

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GenerateReport()
    End Sub

    Private Sub GenerateReport()
        Dim Report As String

        Report = "Staff ID: " + Id + " (" + Status + ")" + vbNewLine + vbNewLine + _
            "Nama: " + UserName + vbNewLine + _
            "No. Jabatan: " + NoJbt + vbNewLine + _
            "No. Pengenalan: " + UIC + vbNewLine + _
            "No. KWSP: " + KWSP + vbNewLine + _
            "Tarikh Dilantik: " + DateAppointed + vbNewLine + _
            "Pengesahan Lantikan: " + DateApproved + vbNewLine + _
            "Disahkan dalam Jawatan: " + Approved + vbNewLine + _
            "Pilihan Umur Persaraan: " + AgeChoicePensions + vbNewLine + _
            "Tarikh Persaraan Wajib: " + DatePensions + vbNewLine + _
            "Cuti yang Berkaitan: " + RelatedHoliday + vbNewLine + _
            "Tarikh Lahir: " + BDate + vbNewLine + _
            "Tempat Lahir: " + BAddress + vbNewLine + _
            "Alamat Rumah: " + Address + vbNewLine + _
            "Jantina: " + Sex + vbNewLine + _
            "Agama: " + Religion + vbNewLine + _
            "Waris 1: " + Waris1 + vbNewLine + _
            "Waris 2: " + Waris2 + vbNewLine + _
            "Kelayakan: " + Qualified + vbNewLine + _
            "Kursus - Kursus: " + KK + vbNewLine + _
            "APC: " + APC + vbNewLine + _
            "Tindakkan Tatatertib: " + TT + vbNewLine + _
            "Sejarah Lantikan: " + SL

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