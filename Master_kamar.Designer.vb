<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Master_kamar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_KodeBarang = New System.Windows.Forms.TextBox()
        Me.TB_Satuan = New System.Windows.Forms.TextBox()
        Me.TB_Jenis = New System.Windows.Forms.TextBox()
        Me.TB_NamaBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Jenis_Kamar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.No_Kamar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Harga = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fasilitas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTN_Simpan = New System.Windows.Forms.Button()
        Me.BTN_Ubah = New System.Windows.Forms.Button()
        Me.BTN_Baru = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CachedCrystalReport11 = New FinalProjek.CachedCrystalReport1()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KetersediaanKamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterKamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENUUTAMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(1, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jenis Kamar"
        '
        'TB_KodeBarang
        '
        Me.TB_KodeBarang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_KodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_KodeBarang.Location = New System.Drawing.Point(159, 33)
        Me.TB_KodeBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_KodeBarang.Name = "TB_KodeBarang"
        Me.TB_KodeBarang.Size = New System.Drawing.Size(438, 30)
        Me.TB_KodeBarang.TabIndex = 2
        '
        'TB_Satuan
        '
        Me.TB_Satuan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_Satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_Satuan.Location = New System.Drawing.Point(159, 175)
        Me.TB_Satuan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_Satuan.Name = "TB_Satuan"
        Me.TB_Satuan.Size = New System.Drawing.Size(438, 30)
        Me.TB_Satuan.TabIndex = 8
        '
        'TB_Jenis
        '
        Me.TB_Jenis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_Jenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_Jenis.Location = New System.Drawing.Point(159, 129)
        Me.TB_Jenis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_Jenis.Name = "TB_Jenis"
        Me.TB_Jenis.Size = New System.Drawing.Size(319, 30)
        Me.TB_Jenis.TabIndex = 6
        '
        'TB_NamaBarang
        '
        Me.TB_NamaBarang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_NamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_NamaBarang.Location = New System.Drawing.Point(159, 83)
        Me.TB_NamaBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_NamaBarang.Name = "TB_NamaBarang"
        Me.TB_NamaBarang.Size = New System.Drawing.Size(438, 30)
        Me.TB_NamaBarang.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(1, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fasilitas"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(1, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Harga"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(1, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nomer Kamar"
        '
        'ListView1
        '
        Me.ListView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Jenis_Kamar, Me.No_Kamar, Me.Harga, Me.Fasilitas})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 215)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(786, 412)
        Me.ListView1.TabIndex = 12
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
        'BTN_Simpan
        '
        Me.BTN_Simpan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Simpan.Location = New System.Drawing.Point(845, 123)
        Me.BTN_Simpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Simpan.Name = "BTN_Simpan"
        Me.BTN_Simpan.Size = New System.Drawing.Size(112, 63)
        Me.BTN_Simpan.TabIndex = 15
        Me.BTN_Simpan.Text = "Simpan"
        Me.BTN_Simpan.UseVisualStyleBackColor = True
        '
        'BTN_Ubah
        '
        Me.BTN_Ubah.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Ubah.Location = New System.Drawing.Point(825, 227)
        Me.BTN_Ubah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Ubah.Name = "BTN_Ubah"
        Me.BTN_Ubah.Size = New System.Drawing.Size(150, 73)
        Me.BTN_Ubah.TabIndex = 14
        Me.BTN_Ubah.Text = "Ubah/Hapus"
        Me.BTN_Ubah.UseVisualStyleBackColor = True
        '
        'BTN_Baru
        '
        Me.BTN_Baru.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Baru.Location = New System.Drawing.Point(845, 38)
        Me.BTN_Baru.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Baru.Name = "BTN_Baru"
        Me.BTN_Baru.Size = New System.Drawing.Size(112, 70)
        Me.BTN_Baru.TabIndex = 13
        Me.BTN_Baru.Text = "Baru"
        Me.BTN_Baru.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(857, 524)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 65)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Menu Utama"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(139, 33)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuAdminToolStripMenuItem
        '
        Me.MenuAdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterMemberToolStripMenuItem, Me.KetersediaanKamarToolStripMenuItem, Me.MasterKamarToolStripMenuItem, Me.MENUUTAMAToolStripMenuItem})
        Me.MenuAdminToolStripMenuItem.Name = "MenuAdminToolStripMenuItem"
        Me.MenuAdminToolStripMenuItem.Size = New System.Drawing.Size(131, 29)
        Me.MenuAdminToolStripMenuItem.Text = "Menu Admin"
        '
        'MasterMemberToolStripMenuItem
        '
        Me.MasterMemberToolStripMenuItem.Name = "MasterMemberToolStripMenuItem"
        Me.MasterMemberToolStripMenuItem.Size = New System.Drawing.Size(269, 34)
        Me.MasterMemberToolStripMenuItem.Text = "Master Member"
        '
        'KetersediaanKamarToolStripMenuItem
        '
        Me.KetersediaanKamarToolStripMenuItem.Name = "KetersediaanKamarToolStripMenuItem"
        Me.KetersediaanKamarToolStripMenuItem.Size = New System.Drawing.Size(269, 34)
        Me.KetersediaanKamarToolStripMenuItem.Text = "Ketersediaan Kamar"
        '
        'MasterKamarToolStripMenuItem
        '
        Me.MasterKamarToolStripMenuItem.Name = "MasterKamarToolStripMenuItem"
        Me.MasterKamarToolStripMenuItem.Size = New System.Drawing.Size(269, 34)
        Me.MasterKamarToolStripMenuItem.Text = "Master Kamar"
        '
        'MENUUTAMAToolStripMenuItem
        '
        Me.MENUUTAMAToolStripMenuItem.Name = "MENUUTAMAToolStripMenuItem"
        Me.MENUUTAMAToolStripMenuItem.Size = New System.Drawing.Size(269, 34)
        Me.MENUUTAMAToolStripMenuItem.Text = "MENU UTAMA"
        '
        'Master_kamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 635)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_Simpan)
        Me.Controls.Add(Me.BTN_Ubah)
        Me.Controls.Add(Me.BTN_Baru)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TB_Satuan)
        Me.Controls.Add(Me.TB_Jenis)
        Me.Controls.Add(Me.TB_NamaBarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_KodeBarang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Master_kamar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Kamar"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TB_KodeBarang As TextBox
    Friend WithEvents TB_Satuan As TextBox
    Friend WithEvents TB_Jenis As TextBox
    Friend WithEvents TB_NamaBarang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Jenis_Kamar As ColumnHeader
    Friend WithEvents No_Kamar As ColumnHeader
    Friend WithEvents Harga As ColumnHeader
    Friend WithEvents Fasilitas As ColumnHeader
    Friend WithEvents BTN_Simpan As Button
    Friend WithEvents BTN_Ubah As Button
    Friend WithEvents BTN_Baru As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CachedCrystalReport11 As CachedCrystalReport1
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KetersediaanKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MENUUTAMAToolStripMenuItem As ToolStripMenuItem
End Class
