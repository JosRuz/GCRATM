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

    Public remoto As Boolean
    Public banco As String

    Public BancoEXTinciio As String

    Public Sub Conectar()
        If remoto = True Then
            ConexionRemota(banco)
        Else
            conexion = New SqlConnection
            conexion.ConnectionString = "server=(local);database=GCRPrivate; integrated security=true"
            conexion.Open()
        End If

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
        Dim hoy As String
        hoy = Today

        sql = "Insert into Historial values ('" & clabe & "', '06/23/2022', '" & mov & "', " & monto & ", '" & des & "')"
        Conectar()
        com = New SqlCommand(sql, conexion)
        res = com.ExecuteNonQuery

    End Sub

    Public Sub ConexionRemota(banco)
        conexion = New SqlConnection

        Select Case banco
            Case "GCR Private"
                conexion.ConnectionString = "server=tcp:DESKTOP-8SDVA09,1433;database=GCRPrivate; integrated security=false; user id=josue; password=1234;"
            Case "CRM"
                conexion.ConnectionString = "server=tcp:DESKTOP-CT3ITH8,1433;database=CRM; integrated security=false; user=sa; password=12345"
            Case "Wolves"
                MsgBox("El banco que está intentando accesar se encuentra inaccesible por el momento, este es un problema ajeno a GCR Private el banco de tus sueños")
            Case "Rinobanco"
                conexion.ConnectionString = "server=LUIS-GUIRON,1433;database=RINOBANCO; integrated security=false; user=sa; password=1234"
            Case "Paybank"
                conexion.ConnectionString = "server=tcp:DESKTOP-214QSUU,1433;database=Banco; integrated security=false; user=sa; password=1234"
            Case "money cash"
                conexion.ConnectionString = "server=tcp:DESKTOP-OQQ747E,1433;database=moneycash; integrated security=false; user=money; password=1234"
            Case "MSC"
                conexion.ConnectionString = "server=DESKTOP-RQORV2P,1433;database=Proyecto; integrated security=false; user=miguel; password=1234"
            Case "FEDIMA"
                conexion.ConnectionString = "server=LAPTOP-Q39G94J8,1433;database=______; integrated security=false; user=Marian; password=1234"
            Case "Bank Bros"
                MsgBox("El banco que está intentando accesar se encuentra inaccesible por el momento, este es un problema ajeno a GCR Private el banco de tus sueños")
            Case "AVA"
                conexion.ConnectionString = "server=tcp:DESKTOP-LJEOQSA,1433;database=BancoAVA; integrated security=false; user=sa1; password=123"
            Case "SCORPIO"
                conexion.ConnectionString = "server=tcp:DESKTOP-MK42GT4,1433;database=BANCO; integrated security=false; user=sa; password=1433"
            Case "BancoW"
                conexion.ConnectionString = "server=LAPTOP-GHOUL,1433;database=______; integrated security=false; user=362M; password=1234"
        End Select
        conexion.Open()
    End Sub

    Public Sub AniadirInter(cantidad)

    End Sub

    Public Sub ExtraerInter(cantidad)

    End Sub


End Module
