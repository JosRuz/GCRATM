Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clabe = txtCuenta.Text
        Pin = txtPin.Text
        Nom = txtNom.Text
        ApellP = txtApllP.Text
        ApellM = txtApllM.Text
        Telefono = txtTel.Text
        eMail = txtMail.Text

        Me.Hide()
        Form4.Show()
    End Sub
End Class