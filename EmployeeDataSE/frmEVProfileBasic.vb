Imports System.Text.RegularExpressions

Public Class frmEVProfileBasic

    Private Sub ProfileBasicBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileBasicBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfileBasicBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeeDataSEDS)

    End Sub

    Private Sub frmEVProfileBasic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.Kelayakan' table. You can move, or remove it, as needed.
        Me.KelayakanTableAdapter.Fill(Me.EmployeeDataSEDS.Kelayakan)
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.Agama' table. You can move, or remove it, as needed.
        Me.AgamaTableAdapter.Fill(Me.EmployeeDataSEDS.Agama)
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.Jantina' table. You can move, or remove it, as needed.
        Me.JantinaTableAdapter.Fill(Me.EmployeeDataSEDS.Jantina)
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.ProfileBasic' table. You can move, or remove it, as needed.
        Me.ProfileBasicTableAdapter.Fill(Me.EmployeeDataSEDS.ProfileBasic)

        Me.Text = "Kemaskini dan Laporan Pekerja"
        Me.Icon = My.Resources.user
        MakeMdiParent()

        'Interface load glitch
        TimerIdSearch.Start()

    End Sub

    Private Sub TimerIdSearch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerIdSearch.Tick
        Do Until SID = IDTextBox.Text
            BindingNavigatorMoveNextItem.PerformClick()
        Loop

        TimerIdSearch.Stop()

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            ProfileBasicBindingNavigatorSaveItem.PerformClick()

            Dim Berjaya = MessageBox.Show(Regex.Unescape("Kemaskini telah berjaya!\nKemaskini maklumat seterusnya?"), "Kemaskini", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If Berjaya = Windows.Forms.DialogResult.Yes Then
                btnNext.PerformClick()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.InnerException, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

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