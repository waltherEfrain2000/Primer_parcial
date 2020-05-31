Public Class Validacion_de_Numeros
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Dim valor As Int16
        If txtNumero.Text = "" Then
            MsgBox("Ingrese un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtNumero.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtNumero.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtNumero.Text)
            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)
            ElseIf valor > 0 Then
                MsgBox("Numero Positivo")
            ElseIf valor < 0 Then
                MsgBox("Numeor Negativo")
            End If

        End If

    End Sub
End Class