Public Class Form3
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class