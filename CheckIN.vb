Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
Public Class CheckIN
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
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub TxtNokam_TextChanged(sender As Object, e As EventArgs) Handles TxtNokam.TextChanged

    End Sub

    Private Sub TxtTobar_TextChanged(sender As Object, e As EventArgs) Handles TxtTobar.TextChanged

    End Sub

    Private Sub CmbInap_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtHarga_TextChanged(sender As Object, e As EventArgs) Handles TxtHarga.TextChanged

    End Sub

    Private Sub TxtFas_TextChanged(sender As Object, e As EventArgs) Handles TxtFas.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TxtNapem_TextChanged(sender As Object, e As EventArgs) Handles TxtNapem.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        cmd = New OracleCommand("SELECT nama, tipe,  fasilitas, harga, lama_menginap, total, no_kamar from TBLtransaksiku 
        where id_pembeli = '" & TextBox1.Text & "' ", cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            TxtNokam.Text = dr.Item(6)
            TxtNapem.Text = dr.Item(0)
            TextBox2.Text = dr.Item(1)
            TxtFas.Text = dr.Item(2)
            TxtHarga.Text = dr.Item(3)
            TextBox3.Text = dr.Item(4)
            TxtTobar.Text = dr.Item(5)
        Else
            MsgBox("Data Kamar Tidak ada!
Pastikan ID Transaksi yang Anda Masukkan Sudah Benar!")



        End If

        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New OracleCommand("SELECT Status from TBLkamar 
        where no_kamar = '" & TxtNokam.Text & "' ", cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.Item(0) = "Check In" Then
            MsgBox("Anda Sudah Check In!")
        ElseIf dr.Item(0) = "Antrian" Then
            MsgBox("Pemesanan anda sedang kami proses silahkan hubungi admin!")

        ElseIf dr.Item(0) = "Dipesan" Then
            cmd = New OracleCommand("update tblkamar set Status= 'Check In' 
        where no_kamar='" & TxtNokam.Text & "' AND status = 'Dipesan'", cn)
            MsgBox("Cheeck In Berhasil")
            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Else
            MsgBox("Data anda tidak ada silahkan lakukan pemesanan")

        End If
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
            If TypeOf ctr Is ComboBox Then
                ctr.Text = ""

            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = New OracleCommand("SELECT Status from TBLkamar 
        where no_kamar = '" & TxtNokam.Text & "' ", cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            If dr.Item(0) = "Check In" Then
                cmd = New OracleCommand("update tblkamar set Status= 'Check Out' 
                where no_kamar='" & TxtNokam.Text & "' AND status = 'Check In'", cn)
                cmd.ExecuteNonQuery()
            ElseIf dr.Item(0) = "Check Out" Then
                MsgBox("Anda Sudah Check Out")
            Else
                MsgBox("Data anda tidak ada/saalh!")
            End If
        Else
            MsgBox("Data Anda tidak ada/salah")

        End If
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
            If TypeOf ctr Is ComboBox Then
                ctr.Text = ""
            End If


        Next
        cmd.Dispose()
        dr.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HalamanUtama.Show()
        Me.Hide()

    End Sub
End Class