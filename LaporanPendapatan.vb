Imports System.Data.OracleClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Public Class LaporanPendapatan
    Dim crypt As New CrystalReport11
    Dim user As String = "SYSTEM"
    Dim pass As String = "SYSTEM"
    Dim total As Integer = 0
    Dim tanggal As String
    Dim ID As String
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        tanggal = Date.Today
        cmd = New OracleCommand("delete tblpemasukan where tanggal='" & tanggal &
        "'", cn)
        cmd.ExecuteNonQuery()
        CrystalReportViewer1.ReportSource = crypt
        crypt.SetDatabaseLogon(user, pass)
        cmd = New OracleCommand("select sum(total) from tbltransaksiku", cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        total = dr.Item(0)
        'MsgBox(total)
        cmd.Dispose()
        dr.Close()

        cmd = New OracleCommand("select ID_PEMBELI from tbltransaksiku", cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        ID = dr.Item(0)
        cmd.Dispose()
        dr.Close()

        cmd = New OracleCommand("insert into tblpemasukan values ('" & tanggal & "'
               ,'" & total & "', '" & ID & "')", cn)
        cmd.ExecuteNonQuery()
    End Sub
End Class