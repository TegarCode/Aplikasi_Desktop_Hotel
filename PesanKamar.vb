Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
Public Class PesanKamar
    Dim cn As New OracleConnection
    Dim cmd As New OracleCommand
    Dim dr As OracleDataReader
    Dim x As String
    Dim id As Integer
    Dim convert As Integer
    Dim member As String
    Dim pass As String
    Dim antrian As String



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


    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        member = ""
        pass = ""
        antrian = ""
        TxtId.Text = "Isi Jika ada"
        TxtPass.Text = "Isi Jika ada"
        koneksi()
        id = 0
        ListView1.Items.Clear()
        cmd = New OracleCommand("SELECT jenis_kamar, no_kamar from TBLKAMAR
        where status='Tersedia'", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
        CmbInap.Items.Add("1 Hari")
        CmbInap.Items.Add("2 Hari")
        CmbInap.Items.Add("3 Hari")
        CmbInap.Items.Add("4 Hari")
        CmbInap.Items.Add("5 Hari")
        CmbInap.Items.Add("6 Hari")
        CmbInap.Items.Add("7 Hari")

    End Sub
    Private Sub TxtNapem_Click(sender As Object, e As EventArgs) Handles TxtNapem.Click
        cmd = New OracleCommand("SELECT jenis_kamar, no_kamar, fasilitas , harga from TBLKAMAR ", cn)
        dr = cmd.ExecuteReader()
        x = ""
        While dr.Read()
            If dr.Item(1) = TxtNokam.Text Then
                TextBox2.Text = dr.Item(0)
                TxtFas.Text = dr.Item(2)
                TxtHarga.Text = dr.Item(3)
                x = TxtNokam.Text
            Else

            End If
        End While
        If x = TxtNokam.Text Then

        Else
            MsgBox("No Kamar Tidak Ada!")
        End If

        dr.Close()
        cmd.Dispose()
    End Sub
    Private Sub CmbInap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbInap.SelectedIndexChanged

        Select Case CmbInap.Text
            Case "1 Hari"
                TxtTobar.Text = 1 * Val(TxtHarga.Text)
            Case "2 Hari"
                TxtTobar.Text = 2 * Val(TxtHarga.Text)
            Case "3 Hari"
                TxtTobar.Text = 3 * Val(TxtHarga.Text)
            Case "4 Hari"
                TxtTobar.Text = 4 * Val(TxtHarga.Text)
            Case "5 Hari"
                TxtTobar.Text = 5 * Val(TxtHarga.Text)
            Case "6 Hari"
                TxtTobar.Text = 6 * Val(TxtHarga.Text)
            Case "7 Hari"
                TxtTobar.Text = 7 * Val(TxtHarga.Text)
        End Select
    End Sub

    Private Sub TxtNokam_TextChanged(sender As Object, e As EventArgs) Handles TxtNokam.TextChanged

    End Sub

    Private Sub TxtNapem_TextChanged(sender As Object, e As EventArgs) Handles TxtNapem.TextChanged

    End Sub

    Private Sub TxtTobar_TextChanged(sender As Object, e As EventArgs) Handles TxtTobar.TextChanged

    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        antrian = ""
        If member = TxtId.Text And pass = TxtPass.Text Then
            cmd = New OracleCommand("insert into tblTransaksiku values ('" & member & "'
        ,'" & TxtNapem.Text & "','" & TextBox2.Text & "','" & TxtFas.Text & "'
        ,'" & TxtHarga.Text & "','" & CmbInap.Text & "','" & TxtTobar.Text & "', '" & TxtNokam.Text & "')", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Penambahan Sukses!
kode pembayaran anda adalah '" & member &
"' Gunakan Saat Check in!")
        Else
            cmd = New OracleCommand("SELECT id_pembeli, max(substr(id_pembeli,2,2)) from TBLtransaksiku
                  where id_pembeli not like 'M%'
                  group by id_pembeli 
                  order by  max(substr(id_pembeli,2,2)) desc", cn)
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then
                convert = 0
                'convert = Val(dr.Item(0))
                id = 1 + dr.Item(1)
                antrian = "p" & id
                cmd = New OracleCommand("insert into tblTransaksiku values ('" & antrian & "'
        ,'" & TxtNapem.Text & "','" & TextBox2.Text & "','" & TxtFas.Text & "'
        ,'" & TxtHarga.Text & "','" & CmbInap.Text & "','" & TxtTobar.Text & "' , '" & TxtNokam.Text & "')", cn)
                cmd.ExecuteNonQuery()
            Else
                id = 1
                antrian = "p" & id
                cmd = New OracleCommand("insert into tblTransaksiku values ('" & antrian & "'
        ,'" & TxtNapem.Text & "','" & TextBox2.Text & "','" & TxtFas.Text & "'
        ,'" & TxtHarga.Text & "','" & CmbInap.Text & "','" & TxtTobar.Text & "' , '" & TxtNokam.Text & "')", cn)
                cmd.ExecuteNonQuery()
            End If
            dr.Close()
            cmd.Dispose()
            MsgBox("Penambahan Sukses!
kode pembayaran anda adalah '" & antrian &
"' Gunakan Saat Check in!")

        End If

        If TxtId.Text = member Then
            Form15.TextBox1.Text = member
            Form15.Show()
        Else
            Form15.TextBox1.Text = antrian
            Form15.Show()
        End If
        Form15.TextBox1.Text = antrian
        Form15.Show()


        cmd = New OracleCommand("update tblkamar set Status= 'Antrian' 
        where no_kamar='" & TxtNokam.Text & "'", cn)
        cmd.ExecuteNonQuery()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
            If TypeOf ctr Is ComboBox Then
                ctr.Text = ""

            End If
        Next
        TxtId.Text = "Isi Jika ada"
        TxtPass.Text = "Isi Jika ada"
        dr.Close()
        cmd.Dispose()

    End Sub

    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles TxtId.TextChanged

    End Sub

    Private Sub TxtId_Click(sender As Object, e As EventArgs) Handles TxtId.Click
        TxtId.Text = ""
        TxtPass.Text = ""
        TxtPass.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        convert = 0
        convert = Val(TxtTobar.Text)
        cmd = New OracleCommand("SELECT id_member, pasword from TBLmember  ", cn)
        dr = cmd.ExecuteReader()
        While dr.Read()
            If dr.Item(0) = TxtId.Text And dr.Item(1) = TxtPass.Text Then
                TxtTobar.Text = convert - (convert * 0.1)
                member = TxtId.Text
                pass = TxtPass.Text
            End If
        End While
        If TxtId.Text = member And TxtPass.Text = pass Then
            MsgBox("Anda Member! Dapatkan Diskon 10%!")
        Else
            MsgBox("Data Member salah!")
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub MenuUtamaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuUtamaToolStripMenuItem.Click

    End Sub

    Private Sub KembaliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KembaliToolStripMenuItem.Click
        HalamanUtama.Show()
        Me.Hide()

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class