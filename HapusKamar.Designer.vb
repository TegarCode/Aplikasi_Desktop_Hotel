<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusKamar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTN_Simpan = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Jenis_Kamar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.No_Kamar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Harga = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fasilitas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TB_Satuan = New System.Windows.Forms.TextBox()
        Me.TB_Jenis = New System.Windows.Forms.TextBox()
        Me.TB_NamaBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_KodeBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_Simpan
        '
        Me.BTN_Simpan.BackColor = System.Drawing.Color.White
        Me.BTN_Simpan.Location = New System.Drawing.Point(651, 34)
        Me.BTN_Simpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Simpan.Name = "BTN_Simpan"
        Me.BTN_Simpan.Size = New System.Drawing.Size(112, 62)
        Me.BTN_Simpan.TabIndex = 22
        Me.BTN_Simpan.Text = "Simpan"
        Me.BTN_Simpan.UseVisualStyleBackColor = False
        '
        'btnkembali
        '
        Me.btnkembali.BackColor = System.Drawing.Color.White
        Me.btnkembali.Location = New System.Drawing.Point(651, 104)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(112, 42)
        Me.btnkembali.TabIndex = 23
        Me.btnkembali.Text = "KEMBALI"
        Me.btnkembali.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Jenis_Kamar, Me.No_Kamar, Me.Harga, Me.Fasilitas})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(10, 190)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(786, 377)
        Me.ListView1.TabIndex = 32
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Jenis_Kamar
        '
        Me.Jenis_Kamar.Text = "Jenis kamar"
        Me.Jenis_Kamar.Width = 120
        '
        'No_Kamar
        '
        Me.No_Kamar.Text = "No Kamar"
        Me.No_Kamar.Width = 220
        '
        'Harga
        '
        Me.Harga.Text = "Harga"
        Me.Harga.Width = 100
        '
        'Fasilitas
        '
        Me.Fasilitas.Text = "Fasilitas"
        Me.Fasilitas.Width = 100
        '
        'TB_Satuan
        '
        Me.TB_Satuan.BackColor = System.Drawing.Color.White
        Me.TB_Satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_Satuan.Location = New System.Drawing.Point(166, 150)
        Me.TB_Satuan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_Satuan.Name = "TB_Satuan"
        Me.TB_Satuan.Size = New System.Drawing.Size(438, 30)
        Me.TB_Satuan.TabIndex = 30
        '
        'TB_Jenis
        '
        Me.TB_Jenis.BackColor = System.Drawing.Color.White
        Me.TB_Jenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_Jenis.Location = New System.Drawing.Point(166, 104)
        Me.TB_Jenis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_Jenis.Name = "TB_Jenis"
        Me.TB_Jenis.Size = New System.Drawing.Size(319, 30)
        Me.TB_Jenis.TabIndex = 28
        '
        'TB_NamaBarang
        '
        Me.TB_NamaBarang.BackColor = System.Drawing.Color.White
        Me.TB_NamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_NamaBarang.Location = New System.Drawing.Point(166, 58)
        Me.TB_NamaBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_NamaBarang.Name = "TB_NamaBarang"
        Me.TB_NamaBarang.Size = New System.Drawing.Size(438, 30)
        Me.TB_NamaBarang.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(8, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 25)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Fasilitas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(8, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Harga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nomer Kamar"
        '
        'TB_KodeBarang
        '
        Me.TB_KodeBarang.BackColor = System.Drawing.Color.White
        Me.TB_KodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_KodeBarang.Location = New System.Drawing.Point(165, 13)
        Me.TB_KodeBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_KodeBarang.Name = "TB_KodeBarang"
        Me.TB_KodeBarang.Size = New System.Drawing.Size(438, 30)
        Me.TB_KodeBarang.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Jenis Kamar"
        '
        'HapusKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.BackgroundImage = Global.FinalProjek.My.Resources.Resources.wan_alyasa_hotel_2
        Me.ClientSize = New System.Drawing.Size(871, 592)
        Me.ControlBox = False
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TB_Satuan)
        Me.Controls.Add(Me.TB_Jenis)
        Me.Controls.Add(Me.TB_NamaBarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_KodeBarang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.BTN_Simpan)
        Me.Name = "HapusKamar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubah kamar"
        Me.TransparencyKey = System.Drawing.Color.Khaki
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_Simpan As Button
    Friend WithEvents btnkembali As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Jenis_Kamar As ColumnHeader
    Friend WithEvents No_Kamar As ColumnHeader
    Friend WithEvents Harga As ColumnHeader
    Friend WithEvents Fasilitas As ColumnHeader
    Friend WithEvents TB_Satuan As TextBox
    Friend WithEvents TB_Jenis As TextBox
    Friend WithEvents TB_NamaBarang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_KodeBarang As TextBox
    Friend WithEvents Label1 As Label
End Class
