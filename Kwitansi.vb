Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Public Class Form15
    Dim crypt As New CrystalReport3
    Dim user As String = "SYSTEM"
    Dim pas As String = "SYSTEM"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CrystalReportViewer1.ReportSource = crypt
        If TextBox1.Text = "" Then
            'CrystalReportViewer1.SelectionFormula = "{tbltransaksiku.id_pembeli}"
            CrystalReportViewer1.SelectionFormula = "{tbltransaksiku.id_pembeli}={tbltransaksiku.id_pembeli} "
            CrystalReportViewer1.ReportSource = crypt
            CrystalReportViewer1.Refresh()
        Else
            CrystalReportViewer1.SelectionFormula = "{tbltransaksiku.id_pembeli} like '*" & TextBox1.Text & "*'"
            CrystalReportViewer1.ReportSource = crypt
            CrystalReportViewer1.Refresh()

        End If
    End Sub

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crypt.SetDatabaseLogon(user, pas)
        CrystalReportViewer1.ReportSource = crypt
        If TextBox1.Text = "" Then
            'CrystalReportViewer1.SelectionFormula = "{tbltransaksiku.id_pembeli}"
            CrystalReportViewer1.SelectionFormula = "{tbltransaksiku.id_pembeli}={tbltransaksiku.id_pembeli } "
            CrystalReportViewer1.ReportSource = crypt
            CrystalReportViewer1.Refresh()
        Else
            CrystalReportViewer1.SelectionFormula = "{tbltransaksiku.id_pembeli} like '*" & TextBox1.Text & "*'"
            CrystalReportViewer1.ReportSource = crypt
            CrystalReportViewer1.Refresh()
        End If

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class