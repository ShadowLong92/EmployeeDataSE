Public Class frmProfileBasic

    Private Sub frmProfileBasic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.ProfileBasic' table. You can move, or remove it, as needed.
        Me.ProfileBasicTableAdapter.Fill(Me.EmployeeDataSEDS.ProfileBasic)
        Me.Text = "Daftar Pekerja Baru (Profil)"
        Me.Icon = My.Resources.user
        BindingNavigatorAddNewItem.PerformClick()
        TimeNewId.Start()

    End Sub

    Private Sub ProfileBasicBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileBasicBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfileBasicBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeeDataSEDS)

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If JantinaComboBox.SelectedIndex = 0 Or AgamaComboBox.SelectedIndex = 0 Then
            MessageBox.Show("Maklumat tidak lengkap!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ProfileBasicBindingNavigatorSaveItem.PerformClick()

        Me.Close()
        frmProfileAdvance.Show()
    End Sub

    Private Function UniqueId()
        Do Until ProfileBasicTableAdapter.ScalarQueryId(UID) Is Nothing = True
            UID += 1
        Loop

        Return UID

    End Function

    Private Sub TimeNewId_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeNewId.Tick
        IDTextBox.Text = UniqueId().ToString

        With JantinaComboBox.Items
            .Add(Choose)
            .Add("Lelaki")
            .Add("Perempuan")
        End With
        With AgamaComboBox.Items
            .Add(Choose)
            .Add("Islam")
            .Add("Buddha")
            .Add("Hindu")
            .Add("Kristian")
            .Add("Lain-lain")
        End With
        With KelayakanComboBox.Items
            .Add(Choose)
            .Add("SPM")
            .Add("Diploma")
            .Add("Ijazah")
            .Add("Master")
            .Add("PhD")
        End With

        JantinaComboBox.SelectedIndex = 0
        AgamaComboBox.SelectedIndex = 0
        KelayakanComboBox.SelectedIndex = 0

        TimeNewId.Stop()

    End Sub

End Class