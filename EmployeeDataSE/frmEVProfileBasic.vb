Public Class frmEVProfileBasic

    Private Sub ProfileBasicBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileBasicBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfileBasicBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeeDataSEDS)

    End Sub

    Private Sub frmEVProfileBasic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.ProfileBasic' table. You can move, or remove it, as needed.
        Me.ProfileBasicTableAdapter.Fill(Me.EmployeeDataSEDS.ProfileBasic)

        Me.Text = "Kemaskini dan Laporan Pekerja"
        Me.Icon = My.Resources.user

        Do Until SID = IDTextBox.Text
            BindingNavigatorMoveNextItem.PerformClick()
        Loop

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

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If JantinaComboBox.SelectedIndex <= 0 Or AgamaComboBox.SelectedIndex <= 0 Then
            MessageBox.Show("Maklumat tidak lengkap!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ProfileBasicBindingNavigatorSaveItem.PerformClick()

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Id = IDTextBox.Text
        UserName = NamaPegawaiTextBox.Text
        NoJbt = NoJbtTextBox.Text
        UIC = NoPengenalanTextBox.Text
        KWSP = NoKWSPTextBox.Text
        BDate = TarikhLahirDateTimePicker.Value.ToString("D")
        BAddress = TempatLahirTextBox.Text
        Address = AlamatRumahTextBox.Text
        Sex = JantinaComboBox.Text
        Religion = AgamaComboBox.Text
        Waris1 = Waris1TextBox.Text
        Waris2 = Waris2TextBox.Text
        Qualified = KelayakanComboBox.Text

        Me.Close()
        frmEVProfileAdvance.Show()
    End Sub
End Class