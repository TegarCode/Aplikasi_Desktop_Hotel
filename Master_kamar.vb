Imports System.Data.OracleClient

Public Class Master_kamar
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        cmd = New OracleCommand("SELECT jenis_kamar, no_kamar, harga , fasilitas from TBLKAMAR", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
            End While
            dr.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

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
        cmd = New OracleCommand("SELECT jenis_kamar, no_kamar, harga , fasilitas from TBLKAMAR", cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            If dr.Item(1) = TB_NamaBarang.Text Then
                MsgBox("NO Kamar Sudah Ada")
            Else
                cmd = New OracleCommand("insert into tblkamar values ('" & TB_KodeBarang.Text & "'
               ,'" & TB_NamaBarang.Text & "','" & TB_Jenis.Text & "','" & TB_Satuan.Text & "','Tersedia')", cn)
                cmd.ExecuteNonQuery()
                'Digunakan untuk menampilkan data ke ListView setelah memasukkan data
                ListView1.Items.Clear()
                cmd = New OracleCommand("SELECT jenis_kamar, no_kamar, harga , fasilitas from TBLKAMAR", cn)
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read()
                        ListView1.Items.Add(dr.Item(0))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
                    End While
                    dr.Close()
                    cmd.Dispose()
                End If
            End If
            dr.Close()
        Else



        End If



    End Sub

    Private Sub TB_KodeBarang_TextChanged(sender As Object, e As EventArgs) Handles TB_KodeBarang.TextChanged

    End Sub

    Private Sub TB_Jenis_TextChanged(sender As Object, e As EventArgs) Handles TB_Jenis.TextChanged

    End Sub

    Private Sub TB_Satuan_TextChanged(sender As Object, e As EventArgs) Handles TB_Satuan.TextChanged

    End Sub

    Private Sub BTN_Ubah_Click(sender As Object, e As EventArgs) Handles BTN_Ubah.Click
        UbahKamar.Show()
        Me.Hide()
    End Sub

    Private Sub btnmember_Click(sender As Object, e As EventArgs)
        Masters_member.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HalamanAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TB_NamaBarang_TextChanged(sender As Object, e As EventArgs) Handles TB_NamaBarang.TextChanged

    End Sub

    Private Sub KetersediaanKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KetersediaanKamarToolStripMenuItem.Click
        Ketersediaan.Show()
        Me.Hide()

    End Sub

    Private Sub MENUUTAMAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUUTAMAToolStripMenuItem.Click
        HalamanAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub MasterMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterMemberToolStripMenuItem.Click
        Masters_member.Show()
        Me.Hide()
    End Sub

    Private Sub MasterKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterKamarToolStripMenuItem.Click

    End Sub
End Class
