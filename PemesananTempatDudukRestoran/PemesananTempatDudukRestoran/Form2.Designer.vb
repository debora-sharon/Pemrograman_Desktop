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
        Label1 = New Label()
        lblKursi = New Label()
        pbDuaKursi = New PictureBox()
        Label2 = New Label()
        pbEmpatKursi = New PictureBox()
        pbEnamKursi = New PictureBox()
        pbDelapanKursi = New PictureBox()
        btnNext = New Button()
        CType(pbDuaKursi, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbEmpatKursi, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbEnamKursi, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbDelapanKursi, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Britannic Bold", 12F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 22)
        Label1.TabIndex = 0
        ' 
        ' lblKursi
        ' 
        lblKursi.AutoSize = True
        lblKursi.Location = New Point(12, 44)
        lblKursi.Name = "lblKursi"
        lblKursi.Size = New Size(0, 20)
        lblKursi.TabIndex = 1
        ' 
        ' pbDuaKursi
        ' 
        pbDuaKursi.BackgroundImage = My.Resources.Resources._2kursi
        pbDuaKursi.BackgroundImageLayout = ImageLayout.Stretch
        pbDuaKursi.Location = New Point(96, 135)
        pbDuaKursi.Name = "pbDuaKursi"
        pbDuaKursi.Size = New Size(200, 250)
        pbDuaKursi.TabIndex = 2
        pbDuaKursi.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Britannic Bold", 20F)
        Label2.Location = New Point(177, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(317, 37)
        Label2.TabIndex = 3
        Label2.Text = "Silahkan Pilih Kursi"
        ' 
        ' pbEmpatKursi
        ' 
        pbEmpatKursi.BackgroundImage = My.Resources.Resources._4kursi
        pbEmpatKursi.BackgroundImageLayout = ImageLayout.Stretch
        pbEmpatKursi.Location = New Point(401, 135)
        pbEmpatKursi.Name = "pbEmpatKursi"
        pbEmpatKursi.Size = New Size(200, 250)
        pbEmpatKursi.TabIndex = 4
        pbEmpatKursi.TabStop = False
        ' 
        ' pbEnamKursi
        ' 
        pbEnamKursi.BackgroundImage = My.Resources.Resources._6kursi
        pbEnamKursi.BackgroundImageLayout = ImageLayout.Stretch
        pbEnamKursi.Location = New Point(96, 462)
        pbEnamKursi.Name = "pbEnamKursi"
        pbEnamKursi.Size = New Size(200, 250)
        pbEnamKursi.TabIndex = 5
        pbEnamKursi.TabStop = False
        ' 
        ' pbDelapanKursi
        ' 
        pbDelapanKursi.BackgroundImage = My.Resources.Resources._8kursi
        pbDelapanKursi.BackgroundImageLayout = ImageLayout.Stretch
        pbDelapanKursi.Location = New Point(401, 462)
        pbDelapanKursi.Name = "pbDelapanKursi"
        pbDelapanKursi.Size = New Size(200, 250)
        pbDelapanKursi.TabIndex = 6
        pbDelapanKursi.TabStop = False
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(585, 751)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(94, 29)
        btnNext.TabIndex = 7
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(712, 814)
        Controls.Add(btnNext)
        Controls.Add(pbDelapanKursi)
        Controls.Add(pbEnamKursi)
        Controls.Add(pbEmpatKursi)
        Controls.Add(Label2)
        Controls.Add(pbDuaKursi)
        Controls.Add(lblKursi)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form Pemesanan Tempat Duduk"
        CType(pbDuaKursi, ComponentModel.ISupportInitialize).EndInit()
        CType(pbEmpatKursi, ComponentModel.ISupportInitialize).EndInit()
        CType(pbEnamKursi, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDelapanKursi, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblKursi As Label
    Friend WithEvents pbDuaKursi As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pbEmpatKursi As PictureBox
    Friend WithEvents pbEnamKursi As PictureBox
    Friend WithEvents pbDelapanKursi As PictureBox
    Friend WithEvents btnNext As Button
End Class
