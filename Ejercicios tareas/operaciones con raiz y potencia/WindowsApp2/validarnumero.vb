Public Class validarnumero
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim valor As Int16

        If txtnumero.Text = "" Then
            MsgBox("escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtnumero.text) Then
            MsgBox("ingrese un valor numerico", vbInformation)
            txtnumero.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtnumero.Text)
            If valor = 0 Then
                MsgBox("numero cero", vbInformation)
            ElseIf valor > 0 Then
                MsgBox("Numero positivo")
            ElseIf valor < 0 Then
                MsgBox("numero negativo")
            End If


        End If
    End Sub
End Class