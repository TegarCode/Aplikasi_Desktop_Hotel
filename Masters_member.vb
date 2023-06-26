Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
Public Class Masters_member
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
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        ListView1.Items.Clear()
        cmd = New OracleCommand("SELECT ID_MEMBER, nama, pasword from TBLMEMBER", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
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
        cmd = New OracleCommand("insert into tblmember values ('" & TB_KodeBarang.Text & "'
               ,'" & TB_NamaBarang.Text & "','" & TB_Jenis.Text & "')", cn)
        cmd.ExecuteNonQuery()

        'Digunakan untuk menampilkan data ke ListView setelah memasukkan data
        ListView1.Items.Clear()
        cmd = New OracleCommand("SELECT ID_MEMBER, nama, pasword from TBLMEMBER", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
        MsgBox("Penambahan Sukses")
    End Sub

    Private Sub BTN_Ubah_Click(sender As Object, e As EventArgs) Handles BTN_Ubah.Click
        HapusMember.Show()
        Me.Hide()
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        HalamanAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub KetersediaanKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KetersediaanKamarToolStripMenuItem.Click
        Ketersediaan.Show()
        Me.Hide()
    End Sub

    Private Sub MasterKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterKamarToolStripMenuItem.Click
        Master_kamar.Show()
        Me.Hide()

    End Sub

    Private Sub MasterMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterMemberToolStripMenuItem.Click

    End Sub

    Private Sub MENUUTAMAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUUTAMAToolStripMenuItem.Click
        HalamanAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class