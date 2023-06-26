Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
Public Class Ketersediaan
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
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        'Digunakan untuk menampilkan data ke ListView setelah memasukkan data
        ListView1.Items.Clear()
        cmd = New OracleCommand("SELECT jenis_kamar, no_kamar, fasilitas , status from TBLKAMAR", cn)
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

        ListView2.Items.Clear()
        cmd = New OracleCommand("SELECT jenis_kamar, no_kamar,  status from TBLKAMAR where status like 'Antrian' or status like 'Check Out' ", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                ListView2.Items.Add(dr.Item(0))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item(2))

            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub BTN_Baru_Click(sender As Object, e As EventArgs) Handles BTN_Baru.Click
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
            If TypeOf ctr Is NumericUpDown Then
                ctr.Text = "0"
            End If
        Next
    End Sub

    Private Sub BTN_Simpan_Click(sender As Object, e As EventArgs) Handles BTN_Simpan.Click
        cmd = New OracleCommand("update tblkamar set Status='" & TB_NamaBarang.Text & "' 
        where no_kamar='" & TB_KodeBarang.Text & "'", cn)
        cmd.ExecuteNonQuery()
        'Digunakan untuk menampilkan data ke ListView setelah memasukkan data
        ListView1.Items.Clear()
        cmd = New OracleCommand("SELECT no_kamar, Jenis_kamar, fasilitas,status from TBLkamar", cn)
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
        ListView2.Items.Clear()
        cmd = New OracleCommand("SELECT jenis_kamar, no_kamar,  status from TBLKAMAR where status like 'Antrian' or status like 'Check Out' ", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                ListView2.Items.Add(dr.Item(0))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item(2))

            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HalamanAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BTN_Ubah_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub

    Private Sub MasterMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterMemberToolStripMenuItem.Click
        Masters_member.Show()
        Me.Hide()

    End Sub

    Private Sub MasterKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterKamarToolStripMenuItem.Click
        Master_kamar.Show()
        Me.Hide()

    End Sub

    Private Sub KetersediaanKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KetersediaanKamarToolStripMenuItem.Click

    End Sub

    Private Sub MENUUTAMAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUUTAMAToolStripMenuItem.Click
        HalamanAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class