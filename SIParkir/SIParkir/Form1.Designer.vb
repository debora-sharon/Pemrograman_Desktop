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
        lblUsernameLogin = New Label()
        txtUsernameLogin = New TextBox()
        lblPasswordLogin = New Label()
        txtPasswordLogin = New TextBox()
        btnKeluar = New Button()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' lblUsernameLogin
        ' 
        lblUsernameLogin.AutoSize = True
        lblUsernameLogin.Location = New Point(89, 84)
        lblUsernameLogin.Name = "lblUsernameLogin"
        lblUsernameLogin.Size = New Size(82, 20)
        lblUsernameLogin.TabIndex = 0
        lblUsernameLogin.Text = "Username :"
        ' 
        ' txtUsernameLogin
        ' 
        txtUsernameLogin.Location = New Point(213, 81)
        txtUsernameLogin.Name = "txtUsernameLogin"
        txtUsernameLogin.Size = New Size(225, 27)
        txtUsernameLogin.TabIndex = 1
        ' 
        ' lblPasswordLogin
        ' 
        lblPasswordLogin.AutoSize = True
        lblPasswordLogin.Location = New Point(89, 135)
        lblPasswordLogin.Name = "lblPasswordLogin"
        lblPasswordLogin.Size = New Size(77, 20)
        lblPasswordLogin.TabIndex = 2
        lblPasswordLogin.Text = "Password :"
        ' 
        ' txtPasswordLogin
        ' 
        txtPasswordLogin.Location = New Point(213, 132)
        txtPasswordLogin.Name = "txtPasswordLogin"
        txtPasswordLogin.Size = New Size(225, 27)
        txtPasswordLogin.TabIndex = 3
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(333, 186)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(105, 35)
        btnKeluar.TabIndex = 4
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(213, 186)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(105, 35)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(551, 282)
        Controls.Add(btnLogin)
        Controls.Add(btnKeluar)
        Controls.Add(txtPasswordLogin)
        Controls.Add(lblPasswordLogin)
        Controls.Add(txtUsernameLogin)
        Controls.Add(lblUsernameLogin)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIParkir - Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsernameLogin As Label
    Friend WithEvents txtUsernameLogin As TextBox
    Friend WithEvents lblPasswordLogin As Label
    Friend WithEvents txtPasswordLogin As TextBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnLogin As Button

End Class
