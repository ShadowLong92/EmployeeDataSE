Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Login ke " + My.Application.Info.Title
        Me.Icon = My.Resources.user
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        UserID = txtUserName.Text

        Dim cipherText As String = UserSql.ScalarQueryReturnPasswd(UserID)
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

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtPassWord_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassWord.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLogin.PerformClick()
        End If
    End Sub

End Class