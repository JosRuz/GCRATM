Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim monto As Double
        monto = txtMonto.Text
        Consultar()
        If monto < eldinero Then
            If banco = "GCR Private" Then
                Extraer(monto)
            Else
                monto = monto * -1
                AniadirInter(banco, monto)
            End If
            MsgBox("Pago realizado con exito")
            des = "Pago a " & cmbServicio.SelectedItem
            RegistrarMovimiento("Pago de servicio", monto)

            txtMonto.Clear()

            Me.Hide()
            Form5.Show()
        Else
            MsgBox("No tienes suficiente dinero en tu cuenta")
        End If

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        des = ""
    End Sub
End Class