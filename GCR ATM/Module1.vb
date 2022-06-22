Imports System.Data.SqlClient
Module Module1
    Public clabe, Nom, ApellP, ApellM, Telefono, eMail, Pin As String
    Public id_cuentaBancaria As String
    Public dinero As Double

    Public conexion As SqlConnection
    Public com As SqlCommand
    Public dr As SqlDataReader

    Public sql As String
    Public res As Integer

    Public eldinero As Double
    Public des As String
    Public tipo As String
    Public Sub Conectar()
        conexion = New SqlConnection
        conexion.ConnectionString = "server=(local);database=GCRPrivate; integrated security=true"
        conexion.Open()
    End Sub
    Public Sub Extraer(movimiento As Double)
        Consultar()
        movimiento = eldinero - movimiento

        sql = "Update CuentaBancaria set Estado=" & movimiento & " where CLABE='" & clabe & "'"
        Conectar()
        com = New SqlCommand(sql, conexion)
        res = com.ExecuteNonQuery
    End Sub

    Public Sub Aniadir(movimiento As Double)
        Consultar()
        movimiento = eldinero + movimiento

        sql = "Update CuentaBancaria set Estado=" & movimiento & " where CLABE='" & clabe & "'"
        Conectar()
        com = New SqlCommand(sql, conexion)
        res = com.ExecuteNonQuery
    End Sub
    Public Sub Consultar()
        Try
            sql = "select Estado from CuentaBancaria where CLABE='" & clabe & "'"
            Conectar()
            com = New SqlCommand(sql, conexion)
            dr = com.ExecuteReader

            dr.Read()
            eldinero = dr(0)

        Catch ex As Exception
            MsgBox("oh No, " & ex.Message)
        End Try
    End Sub

    Public Sub RegistrarMovimiento(mov As String, monto As Double)
        Dim hoy As Date
        hoy = Today

        sql = "Insert into Historial values ('" & clabe & "', '" & hoy & "', '" & mov & "', " & monto & ", '" & des & "')"
        Conectar()
        com = New SqlCommand(sql, conexion)
        res = com.ExecuteNonQuery

    End Sub
End Module
