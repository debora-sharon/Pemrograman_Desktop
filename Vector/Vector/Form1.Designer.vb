<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        GroupBox1 = New GroupBox()
        ShapeIsian = New Panel()
        ShapeTepi = New Panel()
        NumericUpDown1 = New NumericUpDown()
        lblUkuran = New Label()
        RadioElipsIsi = New RadioButton()
        RadioKotakIsi = New RadioButton()
        RadioElips = New RadioButton()
        RadioKotak = New RadioButton()
        RadioGaris = New RadioButton()
        RadioBebas = New RadioButton()
        GroupBox2 = New GroupBox()
        btnGbrUlang = New Button()
        btnBersihkan = New Button()
        btnUndo = New Button()
        Warna6 = New Panel()
        Warna5 = New Panel()
        Warna4 = New Panel()
        Warna3 = New Panel()
        Warna2 = New Panel()
        Warna1 = New Panel()
        GroupBox3 = New GroupBox()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        BukaToolStripMenuItem = New ToolStripMenuItem()
        SimpanToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ShapeIsian)
        GroupBox1.Controls.Add(ShapeTepi)
        GroupBox1.Controls.Add(NumericUpDown1)
        GroupBox1.Controls.Add(lblUkuran)
        GroupBox1.Controls.Add(RadioElipsIsi)
        GroupBox1.Controls.Add(RadioKotakIsi)
        GroupBox1.Controls.Add(RadioElips)
        GroupBox1.Controls.Add(RadioKotak)
        GroupBox1.Controls.Add(RadioGaris)
        GroupBox1.Controls.Add(RadioBebas)
        GroupBox1.Dock = DockStyle.Left
        GroupBox1.Location = New Point(0, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(186, 453)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tools"
        ' 
        ' ShapeIsian
        ' 
        ShapeIsian.BackColor = Color.White
        ShapeIsian.Location = New Point(83, 379)
        ShapeIsian.Name = "ShapeIsian"
        ShapeIsian.Size = New Size(53, 50)
        ShapeIsian.TabIndex = 9
        ' 
        ' ShapeTepi
        ' 
        ShapeTepi.BackColor = Color.Black
        ShapeTepi.Location = New Point(24, 379)
        ShapeTepi.Name = "ShapeTepi"
        ShapeTepi.Size = New Size(53, 50)
        ShapeTepi.TabIndex = 8
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(17, 309)
        NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(150, 27)
        NumericUpDown1.TabIndex = 7
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblUkuran
        ' 
        lblUkuran.AutoSize = True
        lblUkuran.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUkuran.Location = New Point(19, 280)
        lblUkuran.Name = "lblUkuran"
        lblUkuran.Size = New Size(124, 20)
        lblUkuran.TabIndex = 6
        lblUkuran.Text = "Ukuran Garis Tepi"
        ' 
        ' RadioElipsIsi
        ' 
        RadioElipsIsi.AutoSize = True
        RadioElipsIsi.Location = New Point(24, 213)
        RadioElipsIsi.Name = "RadioElipsIsi"
        RadioElipsIsi.Size = New Size(79, 24)
        RadioElipsIsi.TabIndex = 5
        RadioElipsIsi.TabStop = True
        RadioElipsIsi.Text = "Elips Isi"
        RadioElipsIsi.UseVisualStyleBackColor = True
        ' 
        ' RadioKotakIsi
        ' 
        RadioKotakIsi.AutoSize = True
        RadioKotakIsi.Location = New Point(24, 178)
        RadioKotakIsi.Name = "RadioKotakIsi"
        RadioKotakIsi.Size = New Size(86, 24)
        RadioKotakIsi.TabIndex = 4
        RadioKotakIsi.TabStop = True
        RadioKotakIsi.Text = "Kotak Isi"
        RadioKotakIsi.UseVisualStyleBackColor = True
        ' 
        ' RadioElips
        ' 
        RadioElips.AutoSize = True
        RadioElips.Location = New Point(24, 143)
        RadioElips.Name = "RadioElips"
        RadioElips.Size = New Size(61, 24)
        RadioElips.TabIndex = 3
        RadioElips.TabStop = True
        RadioElips.Text = "Elips"
        RadioElips.UseVisualStyleBackColor = True
        ' 
        ' RadioKotak
        ' 
        RadioKotak.AutoSize = True
        RadioKotak.Location = New Point(24, 108)
        RadioKotak.Name = "RadioKotak"
        RadioKotak.Size = New Size(68, 24)
        RadioKotak.TabIndex = 2
        RadioKotak.TabStop = True
        RadioKotak.Text = "Kotak"
        RadioKotak.UseVisualStyleBackColor = True
        ' 
        ' RadioGaris
        ' 
        RadioGaris.AutoSize = True
        RadioGaris.Location = New Point(24, 73)
        RadioGaris.Name = "RadioGaris"
        RadioGaris.Size = New Size(63, 24)
        RadioGaris.TabIndex = 1
        RadioGaris.TabStop = True
        RadioGaris.Text = "Garis"
        RadioGaris.UseVisualStyleBackColor = True
        ' 
        ' RadioBebas
        ' 
        RadioBebas.AutoSize = True
        RadioBebas.Location = New Point(24, 38)
        RadioBebas.Name = "RadioBebas"
        RadioBebas.Size = New Size(70, 24)
        RadioBebas.TabIndex = 0
        RadioBebas.TabStop = True
        RadioBebas.Text = "Bebas"
        RadioBebas.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnGbrUlang)
        GroupBox2.Controls.Add(btnBersihkan)
        GroupBox2.Controls.Add(btnUndo)
        GroupBox2.Controls.Add(Warna6)
        GroupBox2.Controls.Add(Warna5)
        GroupBox2.Controls.Add(Warna4)
        GroupBox2.Controls.Add(Warna3)
        GroupBox2.Controls.Add(Warna2)
        GroupBox2.Controls.Add(Warna1)
        GroupBox2.Dock = DockStyle.Bottom
        GroupBox2.Location = New Point(186, 419)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(695, 62)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Warna"
        ' 
        ' btnGbrUlang
        ' 
        btnGbrUlang.Location = New Point(547, 25)
        btnGbrUlang.Name = "btnGbrUlang"
        btnGbrUlang.Size = New Size(136, 29)
        btnGbrUlang.TabIndex = 4
        btnGbrUlang.Text = "Gambarkan Ulang"
        btnGbrUlang.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.Location = New Point(374, 25)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(137, 29)
        btnBersihkan.TabIndex = 3
        btnBersihkan.Text = "Bersihkan Kanvas"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' btnUndo
        ' 
        btnUndo.Location = New Point(274, 25)
        btnUndo.Name = "btnUndo"
        btnUndo.Size = New Size(94, 29)
        btnUndo.TabIndex = 2
        btnUndo.Text = "Undo"
        btnUndo.UseVisualStyleBackColor = True
        ' 
        ' Warna6
        ' 
        Warna6.BackColor = Color.White
        Warna6.Location = New Point(202, 25)
        Warna6.Name = "Warna6"
        Warna6.Size = New Size(31, 29)
        Warna6.TabIndex = 1
        ' 
        ' Warna5
        ' 
        Warna5.BackColor = Color.Black
        Warna5.Location = New Point(165, 26)
        Warna5.Name = "Warna5"
        Warna5.Size = New Size(31, 29)
        Warna5.TabIndex = 1
        ' 
        ' Warna4
        ' 
        Warna4.BackColor = Color.Blue
        Warna4.Location = New Point(128, 26)
        Warna4.Name = "Warna4"
        Warna4.Size = New Size(31, 29)
        Warna4.TabIndex = 1
        ' 
        ' Warna3
        ' 
        Warna3.BackColor = Color.Green
        Warna3.Location = New Point(91, 26)
        Warna3.Name = "Warna3"
        Warna3.Size = New Size(31, 29)
        Warna3.TabIndex = 1
        ' 
        ' Warna2
        ' 
        Warna2.BackColor = Color.Yellow
        Warna2.Location = New Point(54, 25)
        Warna2.Name = "Warna2"
        Warna2.Size = New Size(31, 29)
        Warna2.TabIndex = 1
        ' 
        ' Warna1
        ' 
        Warna1.BackColor = Color.Red
        Warna1.Location = New Point(17, 25)
        Warna1.Name = "Warna1"
        Warna1.Size = New Size(31, 29)
        Warna1.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBox1)
        GroupBox3.Dock = DockStyle.Right
        GroupBox3.Location = New Point(666, 28)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(215, 391)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Objek"
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(3, 23)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(209, 365)
        TextBox1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(186, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(480, 391)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(881, 28)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BukaToolStripMenuItem, SimpanToolStripMenuItem, KeluarToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' BukaToolStripMenuItem
        ' 
        BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        BukaToolStripMenuItem.Size = New Size(142, 26)
        BukaToolStripMenuItem.Text = "Buka"
        ' 
        ' SimpanToolStripMenuItem
        ' 
        SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        SimpanToolStripMenuItem.Size = New Size(142, 26)
        SimpanToolStripMenuItem.Text = "Simpan"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(142, 26)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' frmUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(881, 481)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frmUtama"
        Text = "Corat - Coret Vector"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadioElipsIsi As RadioButton
    Friend WithEvents RadioKotakIsi As RadioButton
    Friend WithEvents RadioElips As RadioButton
    Friend WithEvents RadioKotak As RadioButton
    Friend WithEvents RadioGaris As RadioButton
    Friend WithEvents RadioBebas As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lblUkuran As Label
    Friend WithEvents ShapeIsian As Panel
    Friend WithEvents ShapeTepi As Panel
    Friend WithEvents btnUndo As Button
    Friend WithEvents Warna6 As Panel
    Friend WithEvents Warna5 As Panel
    Friend WithEvents Warna4 As Panel
    Friend WithEvents Warna3 As Panel
    Friend WithEvents Warna2 As Panel
    Friend WithEvents Warna1 As Panel
    Friend WithEvents btnGbrUlang As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents TextBox1 As TextBox

End Class
