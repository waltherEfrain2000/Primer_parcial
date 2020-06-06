Public Class calculo_numeros
    Private Sub iniciar_Click(sender As Object, e As EventArgs) Handles iniciar.Click
        Dim numero, total As Int64
        Dim par, impar, positivo, negativo, suma, n As Integer

        total = Val(txtnumeros.Text)
        For i = 1 To total Step 1
            numero = InputBox("ingrese su  numero", "Ingreso de numeros")

            ComboBox1.Items.Add(numero)


            If numero = Int(numero / 2) * 2 Then
                par = par + 1
            Else
                impar = impar + 1
            End If

            If numero < 0 Then
                negativo = negativo + 1
            Else
                positivo = positivo + 1
            End If
            suma = suma + numero
        Next
        n = Val(txtnumeros.Text)
        txtimpar.Text = impar
        txtpares.Text = par
        txtnegativos.Text = negativo
        txtpositivos.Text = positivo
        txtsuma.Text = suma
        txttotal.Text = total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtimpar.Clear()
        txtnegativos.Clear()
        txtnumeros.Clear()
        txtpares.Clear()
        txtpositivos.Clear()
        txtsuma.Clear()
        txttotal.Clear()

        ComboBox1.Items.Clear()
    End Sub
End Class