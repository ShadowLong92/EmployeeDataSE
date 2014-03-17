Public Class frmSearchEmpId

    Private Sub frmSearchEmpId_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSEDS.ProfileBasic' table. You can move, or remove it, as needed.
        Me.ProfileBasicTableAdapter.Fill(Me.EmployeeDataSEDS.ProfileBasic)
        Me.Icon = My.Resources.user
        Me.Text = "Kemaskini dan Laporan"
        MakeMdiParent()
    End Sub

    Private Sub lstName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstName.SelectedIndexChanged
        txtId.Text = (lstName.SelectedIndex + 1).ToString
    End Sub

    Private Sub numId_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstName.SelectedIndex = Integer.Parse(txtId.Text) - 1
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        SID = txtId.Text
        Me.Close()
        frmEVProfileBasic.Show()
    End Sub

End Class