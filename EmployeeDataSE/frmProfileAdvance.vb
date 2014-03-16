Public Class frmProfileAdvance

    Private Sub frmProfileAdvance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.ProfileAdvance' table. You can move, or remove it, as needed.
        Me.ProfileAdvanceTableAdapter.Fill(Me.EmployeeDataSEDS.ProfileAdvance)
        Me.Text = "Daftar Pekerja Baru (Teperinci)"
        Me.Icon = My.Resources.user
        BindingNavigatorAddNewItem.PerformClick()
        TimeAutoFetch.Start()
    End Sub

    Private Sub ProfileAdvanceBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileAdvanceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfileAdvanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeeDataSEDS)

    End Sub

    Private Sub TimeAutoFetch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeAutoFetch.Tick
        IDTextBox.Text = UID.ToString
        TimeAutoFetch.Stop()
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
            MessageBox.Show("Tidak sah!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class