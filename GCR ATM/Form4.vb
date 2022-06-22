Imports System.Data.SqlClient
Public Class Form4

    Dim estado, municipio, calle, codigoP As String
    Dim numInt, numExt As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        estado = txtEstado.Text.ToUpper
        municipio = txtMunicipio.Text.ToUpper
        calle = txtCalle.Text.ToUpper
        numInt = Int(txtNumInt.Text)
        numExt = Int(txtNumExt.Text)

        sql = "insert into Cliente values ('" & clabe & "', '" & Nom & "', '" & ApellP & "', '" & ApellM & "', '" & Telefono & "', '" & eMail & "', '" & Pin & "'); insert into CuentaBancaria values ('" & clabe & "1" & "', 'pesos', '" & clabe & "', 0)"
        Conectar()
        com = New SqlCommand(sql, conexion)
        res = com.ExecuteNonQuery

        MsgBox("Registro guardado")

        Me.Hide()
        Form2.Show()
    End Sub

End Class