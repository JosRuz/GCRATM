Imports System.Data.SqlClient
Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clabe = txtCuenta.Text
        Pin = txtPin.Text

        sql = "Select * from Cliente where CLABE='" & clabe & "' and pin='" & Pin & "'"
        Conectar()
        com = New SqlCommand(sql, conexion)
        dr = com.ExecuteReader

        If dr.Read Then
            clabe = dr(0)
            Me.Hide()
            Form5.Show()
        Else
            MsgBox("No existes :(")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()
    End Sub

End Class