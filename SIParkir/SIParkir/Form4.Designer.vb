<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        lblNamaPelanggan = New Label()
        txtNamaPelanggan = New TextBox()
        lblNomorPlat = New Label()
        txtNomorPlat = New TextBox()
        lblTarifLangganan = New Label()
        txtTarifLangganan = New TextBox()
        lblTglBerlaku = New Label()
        lblIdPelanggan = New Label()
        lblHasilIdPelanggan = New Label()
        lblJenis = New Label()
        ComboBox1 = New ComboBox()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        lblKendaraanTerdaftarLangganan = New Label()
        DataGridView1 = New DataGridView()
        btnTutup = New Button()
        DateTimePicker1 = New DateTimePicker()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNamaPelanggan
        ' 
        lblNamaPelanggan.AutoSize = True
        lblNamaPelanggan.Location = New Point(30, 30)
        lblNamaPelanggan.Name = "lblNamaPelanggan"
        lblNamaPelanggan.Size = New Size(133, 20)
        lblNamaPelanggan.TabIndex = 0
        lblNamaPelanggan.Text = "Nama Pelanggan : "
        ' 
        ' txtNamaPelanggan
        ' 
        txtNamaPelanggan.Location = New Point(169, 27)
        txtNamaPelanggan.Name = "txtNamaPelanggan"
        txtNamaPelanggan.Size = New Size(309, 27)
        txtNamaPelanggan.TabIndex = 1
        ' 
        ' lblNomorPlat
        ' 
        lblNomorPlat.AutoSize = True
        lblNomorPlat.Location = New Point(30, 80)
        lblNomorPlat.Name = "lblNomorPlat"
        lblNomorPlat.Size = New Size(92, 20)
        lblNomorPlat.TabIndex = 2
        lblNomorPlat.Text = "Nomor Plat :"
        ' 
        ' txtNomorPlat
        ' 
        txtNomorPlat.Location = New Point(169, 77)
        txtNomorPlat.Name = "txtNomorPlat"
        txtNomorPlat.Size = New Size(242, 27)
        txtNomorPlat.TabIndex = 3
        ' 
        ' lblTarifLangganan
        ' 
        lblTarifLangganan.AutoSize = True
        lblTarifLangganan.Location = New Point(30, 130)
        lblTarifLangganan.Name = "lblTarifLangganan"
        lblTarifLangganan.Size = New Size(118, 20)
        lblTarifLangganan.TabIndex = 4
        lblTarifLangganan.Text = "Tarif langganan :"
        ' 
        ' txtTarifLangganan
        ' 
        txtTarifLangganan.Location = New Point(169, 127)
        txtTarifLangganan.Name = "txtTarifLangganan"
        txtTarifLangganan.Size = New Size(242, 27)
        txtTarifLangganan.TabIndex = 5
        ' 
        ' lblTglBerlaku
        ' 
        lblTglBerlaku.AutoSize = True
        lblTglBerlaku.Location = New Point(30, 180)
        lblTglBerlaku.Name = "lblTglBerlaku"
        lblTglBerlaku.Size = New Size(115, 20)
        lblTglBerlaku.TabIndex = 6
        lblTglBerlaku.Text = "Berlaku hingga :"
        ' 
        ' lblIdPelanggan
        ' 
        lblIdPelanggan.AutoSize = True
        lblIdPelanggan.Location = New Point(514, 30)
        lblIdPelanggan.Name = "lblIdPelanggan"
        lblIdPelanggan.Size = New Size(104, 20)
        lblIdPelanggan.TabIndex = 8
        lblIdPelanggan.Text = "ID Pelanggan :"
        ' 
        ' lblHasilIdPelanggan
        ' 
        lblHasilIdPelanggan.AutoSize = True
        lblHasilIdPelanggan.Location = New Point(624, 30)
        lblHasilIdPelanggan.Name = "lblHasilIdPelanggan"
        lblHasilIdPelanggan.Size = New Size(0, 20)
        lblHasilIdPelanggan.TabIndex = 9
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(431, 80)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(47, 20)
        lblJenis.TabIndex = 10
        lblJenis.Text = "Jenis :"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi", "Sepeda", "Bis/Truk"})
        ComboBox1.Location = New Point(484, 77)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(128, 28)
        ComboBox1.TabIndex = 11
        ComboBox1.Text = "Pilih Jenis"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(431, 176)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 12
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(531, 176)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 29)
        btnEdit.TabIndex = 13
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(631, 176)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 14
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' lblKendaraanTerdaftarLangganan
        ' 
        lblKendaraanTerdaftarLangganan.AutoSize = True
        lblKendaraanTerdaftarLangganan.Location = New Point(30, 243)
        lblKendaraanTerdaftarLangganan.Name = "lblKendaraanTerdaftarLangganan"
        lblKendaraanTerdaftarLangganan.Size = New Size(223, 20)
        lblKendaraanTerdaftarLangganan.TabIndex = 15
        lblKendaraanTerdaftarLangganan.Text = "Kendaraan terdaftar langganan :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(30, 266)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(695, 119)
        DataGridView1.TabIndex = 16
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(631, 402)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(94, 29)
        btnTutup.TabIndex = 17
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(169, 175)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(242, 27)
        DateTimePicker1.TabIndex = 18
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(749, 450)
        Controls.Add(DateTimePicker1)
        Controls.Add(btnTutup)
        Controls.Add(DataGridView1)
        Controls.Add(lblKendaraanTerdaftarLangganan)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(btnTambah)
        Controls.Add(ComboBox1)
        Controls.Add(lblJenis)
        Controls.Add(lblHasilIdPelanggan)
        Controls.Add(lblIdPelanggan)
        Controls.Add(lblTglBerlaku)
        Controls.Add(txtTarifLangganan)
        Controls.Add(lblTarifLangganan)
        Controls.Add(txtNomorPlat)
        Controls.Add(lblNomorPlat)
        Controls.Add(txtNamaPelanggan)
        Controls.Add(lblNamaPelanggan)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIParkir - Langganan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNamaPelanggan As Label
    Friend WithEvents txtNamaPelanggan As TextBox
    Friend WithEvents lblNomorPlat As Label
    Friend WithEvents txtNomorPlat As TextBox
    Friend WithEvents lblTarifLangganan As Label
    Friend WithEvents txtTarifLangganan As TextBox
    Friend WithEvents lblTglBerlaku As Label
    Friend WithEvents lblIdPelanggan As Label
    Friend WithEvents lblHasilIdPelanggan As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents lblKendaraanTerdaftarLangganan As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTutup As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
