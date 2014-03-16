Public Class frmEVProfileAdvance

    Private Sub ProfileAdvanceBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileAdvanceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfileAdvanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeeDataSEDS)

    End Sub

    Private Sub frmEVProfileAdvance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.ProfileAdvance' table. You can move, or remove it, as needed.
        Me.ProfileAdvanceTableAdapter.Fill(Me.EmployeeDataSEDS.ProfileAdvance)

        Me.Text = "Kemaskini dan Laporan Pekerja"
        Me.Icon = My.Resources.user

        Do Until SID = IDTextBox.Text
            BindingNavigatorMoveNextItem.PerformClick()
        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProfileAdvanceBindingNavigatorSaveItem.PerformClick()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Status = StatusTextBox.Text
        DateAppointed = TarikhDilantikDateTimePicker.Value.ToString("D")
        DateApproved = TarikhPengesahanLantikanDateTimePicker.Value.ToString("D")
        Approved = DisahkanDalamJawatanComboBox.Text
        AgeChoicePensions = PilihanUmurPersaraanComboBox.Text
        DatePensions = TarikhPersaraanWajibDateTimePicker.Value.ToString("D")
        RelatedHoliday = CutiYangBerkaitanComboBox.Text
        KK = KursusKursusTextBox.Text
        APC = APCTextBox.Text
        TT = TindakkanTatatertibTextBox.Text
        SL = SejarahLantikanTextBox.Text

        Me.Close()
        frmReport.Show()
    End Sub
End Class