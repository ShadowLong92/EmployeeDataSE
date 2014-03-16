Public Class frmMainWindow

    Private Sub frmMainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.Title + " (Ver.: " + My.Application.Info.Version.ToString + ")"
        Me.Icon = My.Resources.user

        frmProfileBasic.MdiParent = Me
        frmProfileAdvance.MdiParent = Me
        frmSearchEmpId.MdiParent = Me
        frmEVProfileBasic.MdiParent = Me
        frmEVProfileAdvance.MdiParent = Me
        frmReport.MdiParent = Me

    End Sub

    Private Sub frmMainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim RageQuit = MessageBox.Show("Anda pasti mahu keluar?", "Logkeluar", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

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

    Private Sub tsmiRegNewWorker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiRegNewWorker.Click
        frmProfileBasic.Show()
    End Sub

    Private Sub KemasKiniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KemasKiniToolStripMenuItem.Click
        frmSearchEmpId.Show()
    End Sub

    Private Sub TimerRAM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRAM.Tick
        tsslRAM.Text = "Free physical RAM: " + Math.Round((My.Computer.Info.AvailablePhysicalMemory) / 1024 / 1024, 2).ToString + "MB"
    End Sub
End Class
