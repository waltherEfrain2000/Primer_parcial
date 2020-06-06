Public Class Calculadora

    Dim operacion As String
    Dim valorresultado As Nullable(Of Double) = Nothing
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim operador As Boolean
    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        evaluarpaconcatenar()
        caculos.Text &= "1"


    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        evaluarpaconcatenar()
        caculos.Text &= "2"
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        evaluarpaconcatenar()
        caculos.Text &= "3"
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        evaluarpaconcatenar()
        caculos.Text &= "4"
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        evaluarpaconcatenar()
        caculos.Text &= "5"
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        evaluarpaconcatenar()
        caculos.Text &= "6"
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click

        evaluarpaconcatenar()
        caculos.Text &= "7"
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        evaluarpaconcatenar()
        caculos.Text &= "8"
    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        evaluarpaconcatenar()
        caculos.Text &= "9"
    End Sub

    Private Sub b0_Click(sender As Object, e As EventArgs) Handles b0.Click
        evaluarpaconcatenar()
        caculos.Text &= "0"

    End Sub

    Private Sub bpunto_Click(sender As Object, e As EventArgs) Handles bpunto.Click
        evaluarpaconcatenar()
        If InStr(caculos.Text, ".", CompareMethod.Text) = 0 Then


            caculos.Text &= "."

        End If
    End Sub

    Private Sub bsuma_Click(sender As Object, e As EventArgs) Handles bsuma.Click
        evaluaroperacion()
        operacion = "+"
    End Sub
    Public Sub evaluaroperacion()

        operador = True
        valor2 = Val(caculos.Text)
        If valorresultado IsNot Nothing Then
            Select Case operacion
                Case "+"
                    valorresultado = valorresultado + valor2
                Case "-"
                    valorresultado -= valor2
                Case "*"
                    valorresultado *= valor2
                Case "/"
                    valorresultado /= valor2
            End Select
            caculos.Text = valorresultado
        Else
            valorresultado = valor2

        End If



    End Sub

    Private Sub bresta_Click(sender As Object, e As EventArgs) Handles bresta.Click
        evaluaroperacion()
        operacion = "-"
    End Sub

    Private Sub bmultiplicacion_Click(sender As Object, e As EventArgs) Handles bmultiplicacion.Click
        evaluaroperacion()
        operacion = "*"
    End Sub

    Private Sub bdivision_Click(sender As Object, e As EventArgs) Handles bdivision.Click
        evaluaroperacion()
        operacion = "/"
    End Sub

    Private Sub bigual_Click(sender As Object, e As EventArgs) Handles bigual.Click
        evaluaroperacion()
        operacion = ""
        ListBox.Items.Add(valorresultado)
    End Sub

    Public Sub evaluarpaconcatenar()
        If operador = True Then
            caculos.Text = ""
            operador = False
        ElseIf caculos.Text = "0" Then
            caculos.Text = ""
        End If
    End Sub

    Private Sub bclear_Click(sender As Object, e As EventArgs) Handles bclear.Click
        caculos.Clear()
        valor2 = Nothing
        valorresultado = Nothing
    End Sub

    Private Sub bhistory_Click(sender As Object, e As EventArgs) Handles bhistory.Click

        ListBox.Items.Clear()


    End Sub

    Private Sub bnose_Click(sender As Object, e As EventArgs) Handles bnose.Click
        evaluaroperacion()
        operacion = "+"
    End Sub

    Private Sub bnose_DoubleClick(sender As Object, e As EventArgs) Handles bnose.DoubleClick
        evaluaroperacion()
        operacion = "-"

    End Sub
End Class



