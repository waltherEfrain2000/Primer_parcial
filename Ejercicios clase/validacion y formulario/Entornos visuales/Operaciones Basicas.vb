Public Class Form1
    Private Sub txtvalor1(sender As Object, e As EventArgs) Handles txtvalorA.TextChanged

    End Sub

    Private Sub txtvalor2(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtsuma(sender As Object, e As EventArgs) Handles txtresultado.TextChanged

    End Sub

    Private Sub btnSuma(sender As Object, e As EventArgs) Handles btnAccionSuma.Click
        'comentario

        'inicio (decalracion de variables)
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer

        valor1 = Val(txtvalorA.Text)
        valor2 = Val(txtvalorB.Text)

        'Proceso
        suma = valor1 + valor2

        'salida
        txtresultado.Text = suma


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtresultadoResta.TextChanged

    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        'comentario

        'Incio
        Dim valorAresta As Integer
        Dim valorBresta As Integer
        Dim resta As Integer

        valorAresta = Val(txtvalorAresta.Text)
        valorBresta = Val(txtvalorBresta.Text)

        'Proceso
        resta = valorAresta - valorBresta

        'salida
        txtresultadoResta.Text = resta
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtvalorBresta.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtvalorAresta.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtvalorAmultiplicacion_TextChanged(sender As Object, e As EventArgs) Handles txtvalorAmultiplicacion.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        'comentario

        'Inicio
        Dim valorAmultiplicacion As Integer
        Dim valorBmultiplicacion As Integer
        Dim multiplicacion As Integer

        valorAmultiplicacion = Val(txtvalorAmultiplicacion.Text)
        valorBmultiplicacion = Val(txtvalorBmultiplicacion.Text)

        'Proceso
        multiplicacion = valorAmultiplicacion * valorBmultiplicacion

        'Salida
        txtresultadoMultiplicacion.Text = multiplicacion
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        'comentario

        'Inicio
        Dim valorAdivision As Integer
        Dim valorBdivision As Integer
        Dim division As Integer

        valorAdivision = Val(txtvalorAdivision.Text)
        valorBdivision = Val(txtvalorBdivision.Text)

        'Proceso
        division = valorAdivision / valorBdivision

        If valorBdivision = 0 Then

            MsgBox("Math Error")

        ElseIf valorBdivision <> 0 Then

            txtresuladoDivision.Text = division

        End If



    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtvalorA.Clear()
        txtvalorB.Clear()
        txtresultado.Clear()

        txtvalorAresta.Clear()
        txtvalorBresta.Clear()
        txtresultadoResta.Clear()

        txtvalorAmultiplicacion.Clear()
        txtvalorBmultiplicacion.Clear()
        txtresultadoMultiplicacion.Clear()

        txtvalorAdivision.Clear()
        txtvalorBdivision.Clear()
        txtresuladoDivision.Clear()

    End Sub
End Class