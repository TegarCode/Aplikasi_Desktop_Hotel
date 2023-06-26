Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
Public Class UbahMember
    Dim cn As New OracleConnection
    Dim cmd As New OracleCommand
    Dim dr As OracleDataReader
    Sub koneksi()
        cn.Close()
        cn = New OracleConnection("data source=(DESCRIPTION = " &
        "(ADDRESS = (PROTOCOL = TCP)(HOST = LAPTOP-31QAL627)(PORT = 1521)) " &
        "(CONNECT_DATA = " &
        "(SERVER = DEDICATED) " &
        "(SERVICE_NAME = XE) " &
        ")" &
        "); user id = SYSTEM; password = SYSTEM;")
        cn.Open()
    End Sub
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        'Digunakan untuk menampilkan data ke ListView setelah memasukkan data
        ListView1.Items.Clear()
        cmd = New OracleCommand("SELECT id_pembeli, nama , tipe , fasilitas from tbltransaksiku ", cn)
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
            End While
            dr.Close()
        Else
            MsgBox("kososng")
        End If
        dr.Close()
        cmd.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = New OracleCommand("delete tbltransaksiku where id_pembeli='" & TB_KodeBarang.Text &
       "'", cn)
        cmd.ExecuteNonQuery()
        koneksi()
        'Digunakan untuk menampilkan data ke ListView setelah memasukkan data
        ListView1.Items.Clear()
        cmd = New OracleCommand("SELECT id_pembeli, nama , tipe , fasilitas from tbltransaksiku ", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub
End Class