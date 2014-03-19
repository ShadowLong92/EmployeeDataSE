Public Class frmProfileAdvance

    Private Sub ProfileAdvanceBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileAdvanceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfileAdvanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeeDataSEDS)

    End Sub

    Private Sub frmProfileAdvance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.CutiBerkait' table. You can move, or remove it, as needed.
        Me.CutiBerkaitTableAdapter.Fill(Me.EmployeeDataSEDS.CutiBerkait)
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.UmurPencen' table. You can move, or remove it, as needed.
        Me.UmurPencenTableAdapter.Fill(Me.EmployeeDataSEDS.UmurPencen)
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.Jawatan' table. You can move, or remove it, as needed.
        Me.JawatanTableAdapter.Fill(Me.EmployeeDataSEDS.Jawatan)
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.StatusKerja' table. You can move, or remove it, as needed.
        Me.StatusKerjaTableAdapter.Fill(Me.EmployeeDataSEDS.StatusKerja)
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.ProfileAdvance' table. You can move, or remove it, as needed.
        Me.ProfileAdvanceTableAdapter.Fill(Me.EmployeeDataSEDS.ProfileAdvance)

        Me.Text = "Daftar Pekerja Baru (Teperinci)"
        Me.Icon = My.Resources.user
        MakeMdiParent()

        BindingNavigatorAddNewItem.PerformClick()
        TimeAutoFetch.Start()
    End Sub

    Private Sub TimeAutoFetch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeAutoFetch.Tick
        IDTextBox.Text = UID.ToString
        StatusComboBox.SelectedIndex = -1
        DisahkanDalamJawatanComboBox.SelectedIndex = -1
        PilihanUmurPersaraanComboBox.SelectedIndex = 0
        CutiYangBerkaitanComboBox.SelectedIndex = -1

        TimeAutoFetch.Stop()
    End Sub

    Private Sub PilihanUmurPersaraanComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihanUmurPersaraanComboBox.SelectedIndexChanged
        With TarikhPersaraanWajibDateTimePicker
            .Value = New Date(Now.Year + (Integer.Parse(PilihanUmurPersaraanComboBox.Text) - Age), BMonth, BDay)
        End With
    End Sub

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        Try
            ProfileAdvanceBindingNavigatorSaveItem.PerformClick()
            Dim NextSetp = MessageBox.Show("Profil sudah di simpan sepenuhnya! Tambah lagi?", "Berjaya!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            If NextSetp = Windows.Forms.DialogResult.Yes Then
                Me.Close()
                frmProfileBasic.Show()
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class