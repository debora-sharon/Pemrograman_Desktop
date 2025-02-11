<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        GarisBatasToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        TimerWall = New Timer(components)
        StatusStrip1 = New StatusStrip()
        ToolStripStatusReady = New ToolStripStatusLabel()
        ToolStripStatusCurrent = New ToolStripStatusLabel()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        TimerElapsed = New Timer(components)
        lblPath = New Label()
        txtPath = New TextBox()
        btnBrowse = New Button()
        clbWallpaper = New CheckedListBox()
        lblInterval = New Label()
        cbPreview = New CheckBox()
        Label1 = New Label()
        cbInterval = New ComboBox()
        btnRun = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, GarisBatasToolStripMenuItem, ExitToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(46, 24)
        ToolStripMenuItem1.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(185, 26)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' GarisBatasToolStripMenuItem
        ' 
        GarisBatasToolStripMenuItem.Name = "GarisBatasToolStripMenuItem"
        GarisBatasToolStripMenuItem.Size = New Size(185, 26)
        GarisBatasToolStripMenuItem.Text = "Garis batas (-)"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(185, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(133, 26)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(133, 26)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' TimerWall
        ' 
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusReady, ToolStripStatusCurrent})
        StatusStrip1.Location = New Point(0, 472)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 26)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusReady
        ' 
        ToolStripStatusReady.Name = "ToolStripStatusReady"
        ToolStripStatusReady.Size = New Size(50, 20)
        ToolStripStatusReady.Text = "Ready"
        ' 
        ' ToolStripStatusCurrent
        ' 
        ToolStripStatusCurrent.Name = "ToolStripStatusCurrent"
        ToolStripStatusCurrent.Size = New Size(169, 20)
        ToolStripStatusCurrent.Text = "Current Wallpaper: none"
        ' 
        ' TimerElapsed
        ' 
        TimerElapsed.Interval = 1000
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Location = New Point(31, 50)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(86, 20)
        lblPath.TabIndex = 2
        lblPath.Text = "Folder Path:"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(123, 47)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(534, 27)
        txtPath.TabIndex = 3
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(674, 46)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 4
        btnBrowse.Text = "..."
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' clbWallpaper
        ' 
        clbWallpaper.FormattingEnabled = True
        clbWallpaper.Location = New Point(31, 132)
        clbWallpaper.Name = "clbWallpaper"
        clbWallpaper.Size = New Size(379, 312)
        clbWallpaper.TabIndex = 5
        ' 
        ' lblInterval
        ' 
        lblInterval.AutoSize = True
        lblInterval.Location = New Point(31, 109)
        lblInterval.Name = "lblInterval"
        lblInterval.Size = New Size(280, 20)
        lblInterval.TabIndex = 6
        lblInterval.Text = "Please select one or more pictures below"
        ' 
        ' cbPreview
        ' 
        cbPreview.AutoSize = True
        cbPreview.Checked = True
        cbPreview.CheckState = CheckState.Checked
        cbPreview.Location = New Point(434, 109)
        cbPreview.Name = "cbPreview"
        cbPreview.Size = New Size(128, 24)
        cbPreview.TabIndex = 7
        cbPreview.Text = "Preview Image"
        cbPreview.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(434, 407)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 20)
        Label1.TabIndex = 9
        Label1.Text = "Interval:"
        ' 
        ' cbInterval
        ' 
        cbInterval.FormattingEnabled = True
        cbInterval.Items.AddRange(New Object() {"10 secs", "30 secs", "1 minutes", "5 minutes", "10 minutes"})
        cbInterval.Location = New Point(501, 404)
        cbInterval.Name = "cbInterval"
        cbInterval.Size = New Size(151, 28)
        cbInterval.TabIndex = 10
        cbInterval.Text = "Select First"
        ' 
        ' btnRun
        ' 
        btnRun.Location = New Point(674, 404)
        btnRun.Name = "btnRun"
        btnRun.Size = New Size(94, 29)
        btnRun.TabIndex = 11
        btnRun.Text = "Run!"
        btnRun.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(434, 139)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(334, 259)
        Panel1.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(11, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(310, 229)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 498)
        Controls.Add(Panel1)
        Controls.Add(btnRun)
        Controls.Add(cbInterval)
        Controls.Add(Label1)
        Controls.Add(cbPreview)
        Controls.Add(lblInterval)
        Controls.Add(clbWallpaper)
        Controls.Add(btnBrowse)
        Controls.Add(txtPath)
        Controls.Add(lblPath)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Wallpaper Changer"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GarisBatasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerWall As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusCurrent As ToolStripStatusLabel
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TimerElapsed As Timer
    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents clbWallpaper As CheckedListBox
    Friend WithEvents lblInterval As Label
    Friend WithEvents cbPreview As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbInterval As ComboBox
    Friend WithEvents btnRun As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox

End Class
