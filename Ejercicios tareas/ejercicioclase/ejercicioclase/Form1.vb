Public Class Form1
    Private Sub cksuma_CheckedChanged(sender As Object, e As EventArgs) Handles cksuma.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ckpotencia.CheckedChanged

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim numero1 As Integer
        Dim numero2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim multiplicacion As Integer
        Dim division As Double
        Dim potencia As Integer
        Dim raiz As Double
        Dim contador As Integer

        numero1 = Val(txt1.Text)
        numero2 = Val(txt2.Text)

        If txt1.Text = "" Then
            MsgBox("No se le ovide colocar el numero", vbInformation)
        ElseIf Not IsNumeric(txt1.text) Then
            MsgBox("Ingrese un valor numero correcto", vbInformation)
            txt1.Text = ""
        End If

        If cksuma.Checked Then
            contador = contador + 1
            suma = numero1 + numero2
            txtresultados.Text = suma

        Else

        End If
        If ckresta.Checked Then
            contador = contador + 1
            resta = numero1 - numero2
            txtresultados.Text = resta
        Else

        End If

        If ckmultiplicacion.Checked Then
            contador = contador + 1

            multiplicacion = numero1 * numero2
            txtresultados.Text = multiplicacion
        Else

        End If

        If ckdivision.Checked Then
            contador = contador + 1
            division = numero1 / numero2
            txtresultados.Text = division

        Else
        End If

        If ckpotencia.Checked Then
            contador = contador + 1
            potencia = numero1 ^ numero2
            txtresultados.Text = potencia

        Else

        End If


        If ckraiz.Checked Then
            contador = contador + 1
            raiz = Math.Sqrt(numero1)
            txtresultados.Text = raiz
        Else

        End If

        If contador > 1 Then
            MsgBox("No se puede realizar mas de una operacion")
            txtresultados.Text = ""
            txt1.Text = ""
            txt2.Text = ""
            cksuma.Checked = 0
            ckresta.Checked = 0
            ckmultiplicacion.Checked = 0
            ckdivision.Checked = 0
            ckpotencia.Checked = 0
            ckraiz.Checked = 0




        End If
    End Sub

    Private Sub txtresultados_TextChanged(sender As Object, e As EventArgs) Handles txtresultados.TextChanged

    End Sub

    Private Sub ckraiz_CheckedChanged(sender As Object, e As EventArgs) Handles ckraiz.CheckedChanged

    End Sub

    Private Sub ckdivision_CheckedChanged(sender As Object, e As EventArgs) Handles ckdivision.CheckedChanged

    End Sub

    Private Sub ckmultiplicacion_CheckedChanged(sender As Object, e As EventArgs) Handles ckmultiplicacion.CheckedChanged

    End Sub

    Private Sub ckresta_CheckedChanged(sender As Object, e As EventArgs) Handles ckresta.CheckedChanged

    End Sub

    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged

    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub
End Class
