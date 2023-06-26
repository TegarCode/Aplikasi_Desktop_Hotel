Public Class HalamanAdmin
    Private Sub btnmember_Click(sender As Object, e As EventArgs)
        Masters_member.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Masters_member.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Ketersediaan.Show()
        Me.Hide()
    End Sub

    Private Sub MasterMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterMemberToolStripMenuItem.Click
        Masters_member.Show()
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

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_kamar_Click(sender As Object, e As EventArgs) Handles btn_kamar.Click
        Master_kamar.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Masters_member.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Ketersediaan.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LaporanTransaksi.Show()


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        LaporanMember.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        HalamanUtama.Show()
        Me.Hide()

    End Sub
End Class