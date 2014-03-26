Public Class frmPassword

    Private Sub UserBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeeDataSEDS)

    End Sub

    Private Sub frmPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.EmployeeDataSEDS.User)
        Me.UserBindingSource.Filter = "UserName = '" + UserID + "'"

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If PasswordTextBox.Text = txtRePassword.Text And (PasswordTextBox.Text <> Nothing Or txtRePassword.Text <> Nothing) Then
            Dim plainText As String = UserID
            Dim password As String = PasswordTextBox.Text

            Dim wrapper As New Simple3Des(password)
            Dim cipherText As String = wrapper.EncryptData(plainText)

            PasswordTextBox.Text = cipherText
            txtRePassword.Text = cipherText

            UserBindingNavigatorSaveItem.PerformClick()
            MessageBox.Show("Kata laluan telah di tukar!", "Siap", MessageBoxButtons.OK)
            Me.Close()
        Else
            MessageBox.Show("Kata laluan tidak sama!", "Salah", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class