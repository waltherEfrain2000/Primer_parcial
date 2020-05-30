Public Class tarea
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click

        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim multiplicacion As Integer
        Dim division As Double
        Dim potencia As Double
        Dim raiz As Double

        valor1 = Val(txt1.Text)
        valor2 = Val(txt2.Text)

        If txt1.Text = "" And txt2.Text = "" Then
            MsgBox("escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txt1.Text) Then
            MsgBox("ingrese un valor numerico", vbInformation)
            txt1.Text = ""
            txt2.Text = ""

        ElseIf Not IsNumeric(txt2.Text) Then
            MsgBox("ingrese un valor numerico", vbInformation)
            txt2.Text = ""
            txt1.Text = ""
        End If

        If cksuma.Checked Then
            suma = valor1 + valor2
            txtresultado.Text = suma
        Else

        End If

        If ckresta.Checked Then
            resta = valor1 - valor2
            txtresultado.Text = resta
        Else

        End If

        If ckmulti.Checked Then
            multiplicacion = valor1 * valor2
            txtresultado.Text = multiplicacion
        End If

        If ckdivision.Checked Then
            division = valor1 / valor2
            If valor2 = 0 Then
                MsgBox("No se puede dividir por cero")
            ElseIf valor2 > 0 Then

                txtresultado.Text = division

            End If



        End If

        If ckpotencia.Checked Then
            potencia = valor1 ^ valor2
            txtresultado.Text = potencia
        Else

        End If

        If ckraiz.Checked Then
            raiz = Math.Sqrt(valor1)
            txtresultado.Text = raiz
        Else

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class