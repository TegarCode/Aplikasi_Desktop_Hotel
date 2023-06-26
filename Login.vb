Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "ADMIN" Then
            If TextBox2.Text = "ADMIN" Then
                HalamanAdmin.Show()
                Me.Hide()
            Else
                MsgBox("Ussername atau Password Salah")

            End If
        ElseIf TextBox1.Text = "OWNER" Then

            If TextBox2.Text = "OWNER" Then
                HalPemilik.Show()
                Me.Hide()
            Else
                MsgBox("Ussername atau Password Salah")
            End If
        Else
            MsgBox("Ussername atau Password Salah")
        End If


    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class