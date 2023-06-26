Imports Oracle.DataAccess.Types
Imports Oracle.DataAccess.Client
Public Class HapusMember
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
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        ListView1.Items.Clear()
        cmd = New OracleCommand("SELECT ID_MEMBER, nama from TBLMEMBER", cn)
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
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        ListView1.Items.Clear()
        cmd = New OracleCommand("SELECT ID_MEMBER, nama from TBLMEMBER where ID_MEMBER='" & TB_KodeBarang.Text & "'", cn)
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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = New OracleCommand("delete tblmember where ID_MEMBER='" & TB_KodeBarang.Text &
        "'", cn)
        cmd.ExecuteNonQuery()

        'Digunakan untuk menampilkan data ke ListView setelah memasukkan data
        ListView1.Items.Clear()
        cmd = New OracleCommand("SELECT ID_MEMBER, nama from TBLMEMBER", cn)
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
        MsgBox("Data Berhasil Dihapus")
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
            If TypeOf ctr Is NumericUpDown Then
                ctr.Text = "0"
            End If
        Next
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Masters_member.Show()
        Me.Hide()
    End Sub

    Private Sub TB_KodeBarang_TextChanged(sender As Object, e As EventArgs) Handles TB_KodeBarang.TextChanged

    End Sub
End Class