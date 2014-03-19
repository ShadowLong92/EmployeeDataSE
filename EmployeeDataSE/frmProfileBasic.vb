Public Class frmProfileBasic

    Private Sub ProfileBasicBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileBasicBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfileBasicBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeeDataSEDS)

    End Sub

    Private Sub frmProfileBasic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.Kelayakan' table. You can move, or remove it, as needed.
        Me.KelayakanTableAdapter.Fill(Me.EmployeeDataSEDS.Kelayakan)
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.Agama' table. You can move, or remove it, as needed.
        Me.AgamaTableAdapter.Fill(Me.EmployeeDataSEDS.Agama)
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.Jantina' table. You can move, or remove it, as needed.
        Me.JantinaTableAdapter.Fill(Me.EmployeeDataSEDS.Jantina)
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.ProfileBasic' table. You can move, or remove it, as needed.
        Me.ProfileBasicTableAdapter.Fill(Me.EmployeeDataSEDS.ProfileBasic)

        Me.Text = "Daftar Pekerja Baru (Profil)"
        Me.Icon = My.Resources.user
        MakeMdiParent()

        BindingNavigatorAddNewItem.PerformClick()

        'Interface load glitch
        TimerId.Start()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        With TarikhLahirDateTimePicker
            Age = Date.Now.Year - .Value.Year
            BDay = .Value.Day
            BMonth = .Value.Month
        End With

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

    Private Sub TimerId_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerId.Tick
        IDTextBox.Text = UniqueId().ToString
        NoJbtTextBox.Text = "250"
        TarikhLahirDateTimePicker.Value = Date.Now
        JantinaComboBox.SelectedIndex = 0
        AgamaComboBox.SelectedIndex = 0
        KelayakanComboBox.SelectedIndex = 0

        TimerId.Stop()
    End Sub
End Class