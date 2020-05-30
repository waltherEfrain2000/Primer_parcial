Public Class Form1
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        'comentarios'

        'inicio
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim multiplicacion As Integer
        Dim division As Double

        valor1 = Val(txt1.Text)
        valor2 = Val(txt2.Text)


        'proceso
        suma = valor1 + valor2
        resta = valor1 - valor2
        multiplicacion = valor1 * valor2
        division = valor1 / valor2



        'salidas
        txt3.Text = suma
        rest.Text = resta
        multi.Text = multiplicacion
        If valor2 = 0 Then
            MsgBox("No se puede dividir por cero")
        ElseIf valor2 > 0 Then

            divi.Text = division

        End If


    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub bntlimpiar_Click(sender As Object, e As EventArgs) Handles bntlimpiar.Click
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
        rest.Clear()
        multi.Clear()
        divi.Clear()


    End Sub
End Class
