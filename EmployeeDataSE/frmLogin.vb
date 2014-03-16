Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Logon to " + My.Application.Info.Title
        Me.Icon = My.Resources.user
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim cipherText As String = UserSql.ScalarQueryReturnPasswd(txtUserName.Text)
        Dim plainText As String = Nothing
        Dim password As String = txtPassWord.Text
        Dim wrapper As New Simple3Des(password)

        Try
            plainText = wrapper.DecryptData(cipherText)

            If txtUserName.Text = plainText Then
                Me.Hide()
                frmMainWindow.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid username or password, please try again.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Sub TestEncoding()
        Dim plainText As String = InputBox("Enter the plain text:")
        Dim password As String = InputBox("Enter the password:")

        Dim wrapper As New Simple3Des(password)
        Dim cipherText As String = wrapper.EncryptData(plainText)

        ' Save
        MsgBox("The cipher text is: " & cipherText)
        My.Computer.FileSystem.WriteAllText(
            My.Computer.FileSystem.SpecialDirectories.MyDocuments &
            "\cipherText.txt", cipherText, False)
    End Sub

    Sub TestDecoding()
        ' Read
        Dim cipherText As String = My.Computer.FileSystem.ReadAllText(
            My.Computer.FileSystem.SpecialDirectories.MyDocuments &
                "\cipherText.txt")

        Dim password As String = InputBox("Enter the password:")
        Dim wrapper As New Simple3Des(password)

        ' DecryptData throws if the wrong password is used. 
        Try
            Dim plainText As String = wrapper.DecryptData(cipherText)
            MsgBox("The plain text is: " & plainText)
        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox("The data could not be decrypted with the password.")
        End Try
    End Sub

End Class