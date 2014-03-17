Module ReportVariable
    Public UID As Integer = 1
    Public Choose As String = "Sila Pilih..."
    Public SID As String = ""
    Public Age As Integer = 0

    ' Var Profile Basic
    Public Id As String
    Public UserName As String
    Public NoJbt As String
    Public UIC As String
    Public KWSP As String
    Public BDate As String
    Public BAddress As String
    Public Address As String
    Public Sex As String
    Public Religion As String
    Public Waris1 As String
    Public Waris2 As String
    Public Qualified As String

    ' Var Profile Advance
    Public Status As String
    Public DateAppointed As String
    Public DateApproved As String
    Public Approved As String
    Public AgeChoicePensions As String
    Public DatePensions As String
    Public RelatedHoliday As String
    Public KK As String
    Public APC As String
    Public TT As String
    Public SL As String

    Sub MakeMdiParent()
        frmProfileBasic.MdiParent = frmMainWindow
        frmProfileAdvance.MdiParent = frmMainWindow
        frmSearchEmpId.MdiParent = frmMainWindow
        frmEVProfileBasic.MdiParent = frmMainWindow
        frmEVProfileAdvance.MdiParent = frmMainWindow
        frmReport.MdiParent = frmMainWindow
    End Sub

End Module
