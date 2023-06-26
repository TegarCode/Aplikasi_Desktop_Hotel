Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Public Class LaporanTransaksi
    Dim crypt As New CrystalReport1
    Dim user As String = "SYSTEM"
    Dim pass As String = "SYSTEM"
    Private Sub cari_Click(sender As Object, e As EventArgs) Handles cari.Click
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

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crypt.SetDatabaseLogon(user, pass)
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.ReportSource = crypt
        TextBox1.Text = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class