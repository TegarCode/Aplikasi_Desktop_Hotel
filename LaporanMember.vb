Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LaporanMember
    Dim crypt As New CrystalReport10
    Dim user As String = "SYSTEM"
    Dim pas As String = "SYSTEM"
    Dim convt As String = "M01"
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crypt.SetDatabaseLogon(user, pas)
        CrystalReportViewer1.ReportSource = crypt


    End Sub

    Private Sub cari_Click(sender As Object, e As EventArgs) Handles cari.Click
        CrystalReportViewer1.ReportSource = crypt
        If TextBox1.Text = "" Then
            'CrystalReportViewer1.SelectionFormula = "{tbltransaksiku.id_pembeli}"
            CrystalReportViewer1.SelectionFormula = "{tblmember.id_member}={tblmember.id_member} "
            CrystalReportViewer1.ReportSource = crypt
            CrystalReportViewer1.Refresh()
        Else
            CrystalReportViewer1.SelectionFormula = "{tblmember.id_member} like '*" & TextBox1.Text & "*'"
            CrystalReportViewer1.ReportSource = crypt
            CrystalReportViewer1.Refresh()

        End If
    End Sub
End Class