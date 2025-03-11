<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        MenuStrip1 = New MenuStrip()
        SistemToolStripMenuItem = New ToolStripMenuItem()
        AturProfilToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        LanggananToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        lblNomorPlat = New Label()
        txtNomorPlat = New TextBox()
        lblJenis = New Label()
        ComboBox1 = New ComboBox()
        btnMasuk = New Button()
        btnKeluar = New Button()
        lblBiayaParkir = New Label()
        PictureBox1 = New PictureBox()
        lblInformasi = New Label()
        lblTanggal = New Label()
        lblTanggalMuncul = New Label()
        lblJam = New Label()
        lblJamMuncul = New Label()
        lblKendaraanSedangParkir = New Label()
        DataGridView1 = New DataGridView()
        txtPlatMuncul = New TextBox()
        txtBiayaParkir = New TextBox()
        cbMotor = New CheckBox()
        cbMobil = New CheckBox()
        cbTaksi = New CheckBox()
        cbSepeda = New CheckBox()
        cbBisTruk = New CheckBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemToolStripMenuItem, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SistemToolStripMenuItem
        ' 
        SistemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AturProfilToolStripMenuItem, LogoutToolStripMenuItem})
        SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        SistemToolStripMenuItem.Size = New Size(67, 24)
        SistemToolStripMenuItem.Text = "Sistem"
        ' 
        ' AturProfilToolStripMenuItem
        ' 
        AturProfilToolStripMenuItem.Name = "AturProfilToolStripMenuItem"
        AturProfilToolStripMenuItem.Size = New Size(159, 26)
        AturProfilToolStripMenuItem.Text = "Atur Profil"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(159, 26)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LanggananToolStripMenuItem, LaporanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(67, 24)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' LanggananToolStripMenuItem
        ' 
        LanggananToolStripMenuItem.Name = "LanggananToolStripMenuItem"
        LanggananToolStripMenuItem.Size = New Size(165, 26)
        LanggananToolStripMenuItem.Text = "Langganan"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(165, 26)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BantuanToolStripMenuItem1, TentangToolStripMenuItem})
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(77, 24)
        BantuanToolStripMenuItem.Text = "Bantuan"
        ' 
        ' BantuanToolStripMenuItem1
        ' 
        BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        BantuanToolStripMenuItem1.Size = New Size(146, 26)
        BantuanToolStripMenuItem1.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(146, 26)
        TentangToolStripMenuItem.Text = "Tentang"
        ' 
        ' lblNomorPlat
        ' 
        lblNomorPlat.AutoSize = True
        lblNomorPlat.Location = New Point(12, 172)
        lblNomorPlat.Name = "lblNomorPlat"
        lblNomorPlat.Size = New Size(92, 20)
        lblNomorPlat.TabIndex = 2
        lblNomorPlat.Text = "Nomor Plat :"
        ' 
        ' txtNomorPlat
        ' 
        txtNomorPlat.BorderStyle = BorderStyle.FixedSingle
        txtNomorPlat.Location = New Point(126, 169)
        txtNomorPlat.Name = "txtNomorPlat"
        txtNomorPlat.Size = New Size(279, 27)
        txtNomorPlat.TabIndex = 3
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(12, 215)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(51, 20)
        lblJenis.TabIndex = 4
        lblJenis.Text = "Jenis : "
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi", "Sepeda", "Bis/Truk"})
        ComboBox1.Location = New Point(126, 212)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(139, 28)
        ComboBox1.TabIndex = 5
        ComboBox1.Text = "Pilih Jenis"
        ' 
        ' btnMasuk
        ' 
        btnMasuk.Location = New Point(126, 255)
        btnMasuk.Name = "btnMasuk"
        btnMasuk.Size = New Size(121, 32)
        btnMasuk.TabIndex = 6
        btnMasuk.Text = "Masuk"
        btnMasuk.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(284, 255)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(121, 32)
        btnKeluar.TabIndex = 7
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' lblBiayaParkir
        ' 
        lblBiayaParkir.AutoSize = True
        lblBiayaParkir.Location = New Point(12, 319)
        lblBiayaParkir.Name = "lblBiayaParkir"
        lblBiayaParkir.Size = New Size(96, 20)
        lblBiayaParkir.TabIndex = 8
        lblBiayaParkir.Text = "Biaya Parkir : "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._2931142_minimize_minus_remove_line_icon
        PictureBox1.Location = New Point(12, 392)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(393, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' lblInformasi
        ' 
        lblInformasi.AutoSize = True
        lblInformasi.Location = New Point(12, 443)
        lblInformasi.Name = "lblInformasi"
        lblInformasi.Size = New Size(75, 20)
        lblInformasi.TabIndex = 12
        lblInformasi.Text = "Informasi "
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(12, 476)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(68, 20)
        lblTanggal.TabIndex = 13
        lblTanggal.Text = "Tanggal :"
        ' 
        ' lblTanggalMuncul
        ' 
        lblTanggalMuncul.AutoSize = True
        lblTanggalMuncul.Location = New Point(76, 476)
        lblTanggalMuncul.Name = "lblTanggalMuncul"
        lblTanggalMuncul.Size = New Size(85, 20)
        lblTanggalMuncul.TabIndex = 14
        lblTanggalMuncul.Text = "12-34-5678"
        ' 
        ' lblJam
        ' 
        lblJam.AutoSize = True
        lblJam.Location = New Point(219, 476)
        lblJam.Name = "lblJam"
        lblJam.Size = New Size(46, 20)
        lblJam.TabIndex = 15
        lblJam.Text = "Jam : "
        ' 
        ' lblJamMuncul
        ' 
        lblJamMuncul.AutoSize = True
        lblJamMuncul.Location = New Point(259, 476)
        lblJamMuncul.Name = "lblJamMuncul"
        lblJamMuncul.Size = New Size(63, 20)
        lblJamMuncul.TabIndex = 16
        lblJamMuncul.Text = "00:00:00"
        ' 
        ' lblKendaraanSedangParkir
        ' 
        lblKendaraanSedangParkir.AutoSize = True
        lblKendaraanSedangParkir.Location = New Point(445, 172)
        lblKendaraanSedangParkir.Name = "lblKendaraanSedangParkir"
        lblKendaraanSedangParkir.Size = New Size(181, 20)
        lblKendaraanSedangParkir.TabIndex = 17
        lblKendaraanSedangParkir.Text = "Kendaraan sedang parkir :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(445, 195)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(343, 301)
        DataGridView1.TabIndex = 18
        ' 
        ' txtPlatMuncul
        ' 
        txtPlatMuncul.BorderStyle = BorderStyle.FixedSingle
        txtPlatMuncul.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPlatMuncul.Location = New Point(12, 31)
        txtPlatMuncul.Multiline = True
        txtPlatMuncul.Name = "txtPlatMuncul"
        txtPlatMuncul.Size = New Size(776, 120)
        txtPlatMuncul.TabIndex = 19
        txtPlatMuncul.Text = "R 6872 ZH"
        txtPlatMuncul.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBiayaParkir
        ' 
        txtBiayaParkir.BorderStyle = BorderStyle.FixedSingle
        txtBiayaParkir.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBiayaParkir.Location = New Point(126, 305)
        txtBiayaParkir.Multiline = True
        txtBiayaParkir.Name = "txtBiayaParkir"
        txtBiayaParkir.Size = New Size(279, 66)
        txtBiayaParkir.TabIndex = 20
        txtBiayaParkir.Text = "Rp 50.000"
        txtBiayaParkir.TextAlign = HorizontalAlignment.Center
        ' 
        ' cbMotor
        ' 
        cbMotor.AutoSize = True
        cbMotor.Location = New Point(18, 510)
        cbMotor.Name = "cbMotor"
        cbMotor.Size = New Size(72, 24)
        cbMotor.TabIndex = 21
        cbMotor.Text = "Motor"
        cbMotor.UseVisualStyleBackColor = True
        ' 
        ' cbMobil
        ' 
        cbMobil.AutoSize = True
        cbMobil.Location = New Point(92, 510)
        cbMobil.Name = "cbMobil"
        cbMobil.Size = New Size(70, 24)
        cbMobil.TabIndex = 22
        cbMobil.Text = "Mobil"
        cbMobil.UseVisualStyleBackColor = True
        ' 
        ' cbTaksi
        ' 
        cbTaksi.AutoSize = True
        cbTaksi.Location = New Point(168, 510)
        cbTaksi.Name = "cbTaksi"
        cbTaksi.Size = New Size(62, 24)
        cbTaksi.TabIndex = 23
        cbTaksi.Text = "Taksi"
        cbTaksi.UseVisualStyleBackColor = True
        ' 
        ' cbSepeda
        ' 
        cbSepeda.AutoSize = True
        cbSepeda.Location = New Point(236, 510)
        cbSepeda.Name = "cbSepeda"
        cbSepeda.Size = New Size(81, 24)
        cbSepeda.TabIndex = 24
        cbSepeda.Text = "Sepeda"
        cbSepeda.UseVisualStyleBackColor = True
        ' 
        ' cbBisTruk
        ' 
        cbBisTruk.AutoSize = True
        cbBisTruk.Location = New Point(323, 510)
        cbBisTruk.Name = "cbBisTruk"
        cbBisTruk.Size = New Size(83, 24)
        cbBisTruk.TabIndex = 25
        cbBisTruk.Text = "Bis/Truk"
        cbBisTruk.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 546)
        Controls.Add(cbBisTruk)
        Controls.Add(cbSepeda)
        Controls.Add(cbTaksi)
        Controls.Add(cbMobil)
        Controls.Add(cbMotor)
        Controls.Add(txtBiayaParkir)
        Controls.Add(txtPlatMuncul)
        Controls.Add(DataGridView1)
        Controls.Add(lblKendaraanSedangParkir)
        Controls.Add(lblJamMuncul)
        Controls.Add(lblJam)
        Controls.Add(lblTanggalMuncul)
        Controls.Add(lblTanggal)
        Controls.Add(lblInformasi)
        Controls.Add(PictureBox1)
        Controls.Add(lblBiayaParkir)
        Controls.Add(btnKeluar)
        Controls.Add(btnMasuk)
        Controls.Add(ComboBox1)
        Controls.Add(lblJenis)
        Controls.Add(txtNomorPlat)
        Controls.Add(lblNomorPlat)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIParkir - Form Utama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AturProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNomorPlat As Label
    Friend WithEvents txtNomorPlat As TextBox
    Friend WithEvents lblJenis As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnMasuk As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblBiayaParkir As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblInformasi As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblTanggalMuncul As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents lblJamMuncul As Label
    Friend WithEvents lblKendaraanSedangParkir As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtPlatMuncul As TextBox
    Friend WithEvents txtBiayaParkir As TextBox
    Friend WithEvents cbMotor As CheckBox
    Friend WithEvents cbMobil As CheckBox
    Friend WithEvents cbTaksi As CheckBox
    Friend WithEvents cbSepeda As CheckBox
    Friend WithEvents cbBisTruk As CheckBox
End Class
