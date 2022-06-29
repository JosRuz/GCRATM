Imports System.Data.SqlClient
Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lstDescripcion.Items.Clear()
        lstFecha.Items.Clear()
        lstMonto.Items.Clear()
        lstTipo.Items.Clear()
        Me.Close()
        Form5.Show()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstFecha.Items.Clear()
        lstMonto.Items.Clear()
        lstTipo.Items.Clear()
        lstDescripcion.Items.Clear()

        Dim campos As Integer

        Conectar()
        Select Case banco
            Case "GCR Private"
                sql = "Select tipo, monto, fecha, descripcion from Historial where CLABE='" & clabe & "'"
                campos = 4
            Case "CRM"
                sql = "Select Tipo, Monto From Movimientos where NoCuenta='" & clabe & "'"
                campos = 2
            Case "MSC"
                sql = "Select tipo de movimiento, monto movimiento, fecha From movimiento"
                campos = 3
            Case "Bank Bros"
                sql = "Select Tipo, Monto From Movimientos where NoCuenta='" & clabe & "'"
                campos = 2
        End Select
        com = New SqlCommand(sql, conexion)
        dr = com.ExecuteReader
        While dr.Read
            Select Case campos
                Case 2
                    lstTipo.Items.Add(dr(0))
                    lstMonto.Items.Add(dr(1))
                Case 3
                    lstTipo.Items.Add(dr(0))
                    lstMonto.Items.Add(dr(1))
                    lstFecha.Items.Add(dr(2))
                Case 4
                    lstTipo.Items.Add(dr(0))
                    lstMonto.Items.Add(dr(1))
                    lstFecha.Items.Add(dr(2))
                    lstDescripcion.Items.Add(dr(3))
            End Select
        End While
    End Sub
End Class