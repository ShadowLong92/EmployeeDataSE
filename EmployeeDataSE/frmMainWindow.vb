Public Class frmMainWindow

    Private Sub frmMainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmMainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub tsmiExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiExit.Click
        Application.Exit()
    End Sub
End Class
