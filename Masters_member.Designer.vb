<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Masters_member
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ID_Member = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nama = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TB_Jenis = New System.Windows.Forms.TextBox()
        Me.TB_NamaBarang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_KodeBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_Simpan = New System.Windows.Forms.Button()
        Me.BTN_Baru = New System.Windows.Forms.Button()
        Me.BTN_Ubah = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KetersediaanKamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterKamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENUUTAMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID_Member, Me.Nama, Me.Password})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(6, 216)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(660, 377)
        Me.ListView1.TabIndex = 21
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID_Member
        '
        Me.ID_Member.Text = "ID Member"
        Me.ID_Member.Width = 120
        '
        'Nama
        '
        Me.Nama.Text = "Nama"
        Me.Nama.Width = 220
        '
        'Password
        '
        Me.Password.Text = "Password"
        Me.Password.Width = 100
        '
        'TB_Jenis
        '
        Me.TB_Jenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_Jenis.Location = New System.Drawing.Point(162, 141)
        Me.TB_Jenis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_Jenis.Name = "TB_Jenis"
        Me.TB_Jenis.Size = New System.Drawing.Size(438, 30)
        Me.TB_Jenis.TabIndex = 17
        '
        'TB_NamaBarang
        '
        Me.TB_NamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_NamaBarang.Location = New System.Drawing.Point(162, 95)
        Me.TB_NamaBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_NamaBarang.Name = "TB_NamaBarang"
        Me.TB_NamaBarang.Size = New System.Drawing.Size(438, 30)
        Me.TB_NamaBarang.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(4, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Pasword"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(4, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nama "
        '
        'TB_KodeBarang
        '
        Me.TB_KodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_KodeBarang.Location = New System.Drawing.Point(161, 50)
        Me.TB_KodeBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_KodeBarang.Name = "TB_KodeBarang"
        Me.TB_KodeBarang.Size = New System.Drawing.Size(438, 30)
        Me.TB_KodeBarang.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(4, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ID Member"
        '
        'BTN_Simpan
        '
        Me.BTN_Simpan.Location = New System.Drawing.Point(674, 122)
        Me.BTN_Simpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Simpan.Name = "BTN_Simpan"
        Me.BTN_Simpan.Size = New System.Drawing.Size(112, 62)
        Me.BTN_Simpan.TabIndex = 23
        Me.BTN_Simpan.Text = "Simpan"
        Me.BTN_Simpan.UseVisualStyleBackColor = True
        '
        'BTN_Baru
        '
        Me.BTN_Baru.Location = New System.Drawing.Point(674, 50)
        Me.BTN_Baru.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Baru.Name = "BTN_Baru"
        Me.BTN_Baru.Size = New System.Drawing.Size(112, 62)
        Me.BTN_Baru.TabIndex = 22
        Me.BTN_Baru.Text = "Baru"
        Me.BTN_Baru.UseVisualStyleBackColor = True
        '
        'BTN_Ubah
        '
        Me.BTN_Ubah.Location = New System.Drawing.Point(674, 194)
        Me.BTN_Ubah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Ubah.Name = "BTN_Ubah"
        Me.BTN_Ubah.Size = New System.Drawing.Size(112, 73)
        Me.BTN_Ubah.TabIndex = 24
        Me.BTN_Ubah.Text = "Hapus Member"
        Me.BTN_Ubah.UseVisualStyleBackColor = True
        '
        'btnkembali
        '
        Me.btnkembali.Location = New System.Drawing.Point(887, 46)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(144, 49)
        Me.btnkembali.TabIndex = 25
        Me.btnkembali.Text = "KEMBALI"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1043, 33)
        Me.MenuStrip1.TabIndex = 26
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
        'Masters_member
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 602)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.BTN_Ubah)
        Me.Controls.Add(Me.BTN_Simpan)
        Me.Controls.Add(Me.BTN_Baru)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TB_Jenis)
        Me.Controls.Add(Me.TB_NamaBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_KodeBarang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Masters_member"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master_Member"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ID_Member As ColumnHeader
    Friend WithEvents Nama As ColumnHeader
    Friend WithEvents Password As ColumnHeader
    Friend WithEvents TB_Jenis As TextBox
    Friend WithEvents TB_NamaBarang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_KodeBarang As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_Simpan As Button
    Friend WithEvents BTN_Baru As Button
    Friend WithEvents BTN_Ubah As Button
    Friend WithEvents btnkembali As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KetersediaanKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MENUUTAMAToolStripMenuItem As ToolStripMenuItem
End Class
