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

        remoto = True
        Dim BANCA As String
        BANCA = cbBanco.SelectedItem
        banco = BANCA
        Select Case BANCA
            Case "GRC Private"
                sql = "Select * from Cliente where CLABE='" & clabe & "' and pin='" & Pin & "'"
            Case "CRM"
                sql = "Select * from Cuentas where NoCuenta='" & clabe & "' and NIP='" & Pin & "'"
            Case "Wolves"
                sql = "Select * From CLIENTE where ID_CLIENTE='" & clabe & "' and NIP='" & Pin & "'"
            Case "Rinobanco"
                sql = "Select * From Cliente where id='" & clabe & "'"
            Case "Paybank"
                sql = "Select * From Cuenta where id_Cuenta='" & clabe & "' and Nip='" & Pin & "'"
            Case "money cash"
                sql = ""
            Case "MSC"
                sql = "Select * From cliente where id cuentasbancarias='" & clabe & "'"
            Case "FEDIMA"
                sql = "Select * From Cuenta Bancaria where ID_cuenta='" & clabe & "' and NIP='" & Pin & "'"
            Case "Bank Bros"
                sql = "Select * From Cuentas where NoCuenta='" & clabe & "'"
            Case "AVA"
                sql = "Select * From Cuenta where ID_Cuenta='" & clabe & "' and NIP='" & Pin & "'"
            Case "SCORPIO"
                sql = "Select * From Tarjeta where idCli='" & clabe & "' and Pin='" & Pin & "'"
        End Select
        ConexionRemota(BANCA)
        Conectar()

        com = New SqlCommand(sql, conexion)
        dr = com.ExecuteReader

        If dr.Read Then
            clabe = dr(0)
            Me.Hide()
            Form5.Show()
        Else
            MsgBox("Credenciales incorrectas")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remoto = False
        Me.cbBanco.Text = Me.cbBanco.Items(0).ToString
    End Sub
End Class