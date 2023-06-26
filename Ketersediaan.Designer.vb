<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ketersediaan
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KetersediaanKamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterKamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENUUTAMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Jenis_Kamar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.No_Kamar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fasilitas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_Simpan = New System.Windows.Forms.Button()
        Me.BTN_Baru = New System.Windows.Forms.Button()
        Me.TB_NamaBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_KodeBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1047, 33)
        Me.MenuStrip1.TabIndex = 47
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
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(532, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(523, 60)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Menunggu Perubahan"
        '
        'ListView2
        '
        Me.ListView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(513, 322)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(524, 287)
        Me.ListView2.TabIndex = 45
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Jenis kamar"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "No Kamar"
        Me.ColumnHeader2.Width = 111
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.Width = 174
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 60)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Data Kamar"
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Jenis_Kamar, Me.No_Kamar, Me.Fasilitas, Me.Status})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 322)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(504, 287)
        Me.ListView1.TabIndex = 43
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
        Me.No_Kamar.Width = 111
        '
        'Fasilitas
        '
        Me.Fasilitas.Text = "Fasilitas"
        Me.Fasilitas.Width = 100
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 174
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(672, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 68)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Menu Utama"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_Simpan
        '
        Me.BTN_Simpan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Simpan.Location = New System.Drawing.Point(852, 156)
        Me.BTN_Simpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Simpan.Name = "BTN_Simpan"
        Me.BTN_Simpan.Size = New System.Drawing.Size(114, 62)
        Me.BTN_Simpan.TabIndex = 41
        Me.BTN_Simpan.Text = "Simpan"
        Me.BTN_Simpan.UseVisualStyleBackColor = True
        '
        'BTN_Baru
        '
        Me.BTN_Baru.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Baru.Location = New System.Drawing.Point(852, 84)
        Me.BTN_Baru.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Baru.Name = "BTN_Baru"
        Me.BTN_Baru.Size = New System.Drawing.Size(114, 62)
        Me.BTN_Baru.TabIndex = 40
        Me.BTN_Baru.Text = "Baru"
        Me.BTN_Baru.UseVisualStyleBackColor = True
        '
        'TB_NamaBarang
        '
        Me.TB_NamaBarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_NamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_NamaBarang.Location = New System.Drawing.Point(166, 129)
        Me.TB_NamaBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_NamaBarang.Name = "TB_NamaBarang"
        Me.TB_NamaBarang.Size = New System.Drawing.Size(440, 30)
        Me.TB_NamaBarang.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Status"
        '
        'TB_KodeBarang
        '
        Me.TB_KodeBarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_KodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_KodeBarang.Location = New System.Drawing.Point(165, 84)
        Me.TB_KodeBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_KodeBarang.Name = "TB_KodeBarang"
        Me.TB_KodeBarang.Size = New System.Drawing.Size(440, 30)
        Me.TB_KodeBarang.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 25)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "NO_Kamar"
        '
        'Ketersediaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 637)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_Simpan)
        Me.Controls.Add(Me.BTN_Baru)
        Me.Controls.Add(Me.TB_NamaBarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_KodeBarang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ketersediaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KetersediaanKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MENUUTAMAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Jenis_Kamar As ColumnHeader
    Friend WithEvents No_Kamar As ColumnHeader
    Friend WithEvents Fasilitas As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents BTN_Simpan As Button
    Friend WithEvents BTN_Baru As Button
    Friend WithEvents TB_NamaBarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_KodeBarang As TextBox
    Friend WithEvents Label1 As Label
End Class
