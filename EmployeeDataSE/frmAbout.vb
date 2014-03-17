Public Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.Title
        Me.Icon = My.Resources.user
        lblTitle.Text = My.Application.Info.Title
        lblUpdate.Text = My.Application.Info.Title + " is up to date!"
        lblVersion.Text = My.Application.Info.Version.ToString
    End Sub

    Private Sub lnkEndUser_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkEndUser.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/ShadowLong92/EmployeeDataSE")
    End Sub

    Private Sub lnkLicense_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkLicense.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/ShadowLong92/EmployeeDataSE")
    End Sub

    Private Sub lnkPrivacy_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPrivacy.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/ShadowLong92/EmployeeDataSE")
    End Sub
End Class