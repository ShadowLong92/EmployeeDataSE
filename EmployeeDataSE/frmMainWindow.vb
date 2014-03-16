Public Class frmMainWindow

    Private Sub frmMainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.Title + " (Ver.: " + My.Application.Info.Version.ToString + ")"
        Me.Icon = My.Resources.user
    End Sub

    Private Sub frmMainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim RageQuit = MessageBox.Show("Are you sure want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

        If RageQuit = Windows.Forms.DialogResult.Yes Then
            frmLogin.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub tsmiExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiExit.Click
        Me.Close()
    End Sub

    Private Sub tsmiAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAbout.Click
        frmAbout.ShowDialog()
    End Sub

End Class
