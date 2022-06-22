Imports System.Data.SqlClient
Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstFecha.Items.Clear()
        lstMonto.Items.Clear()
        lstTipo.Items.Clear()
        lstDescripcion.Items.Clear()

        Conectar()
        sql = "Select tipo, monto, fecha, descripcion from Historial where CLABE='" & clabe & "'"
        com = New SqlCommand(sql, conexion)
        dr = com.ExecuteReader
        While dr.Read
            lstTipo.Items.Add(dr(0))
            lstMonto.Items.Add(dr(1))
            lstFecha.Items.Add(dr(2))
            lstDescripcion.Items.Add(dr(3))
        End While
    End Sub
End Class