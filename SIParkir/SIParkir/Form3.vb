﻿Imports MySql.Data.MySqlClient
Public Class frmProfil
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtPassBaru.Text = txtConfPass.Text Then
            Dim sql As String = "update users set password='" & txtPassBaru.Text & "'where username='" & pengguna & "'"
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            If myCommand.ExecuteNonQuery = 1 Then
                MsgBox("Password berhasil diganti, silahkan login ulang!")
                frmLogin.txtPassword.Clear()
                frmLogin.txtUsername.Clear()
                Me.Close()
                frmUtama.Close()
                frmLogin.txtUsername.Focus()
                frmLogin.ShowDialog()
            End If
        ElseIf txtConfPass.Text <> "" Then
            MsgBox("Password tidak sama!")
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub frmProfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = pengguna
        txtPassBaru.Text = ppassword
    End Sub

    Private Sub frmProfil_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnSimpan.PerformClick()
        End If
    End Sub
End Class