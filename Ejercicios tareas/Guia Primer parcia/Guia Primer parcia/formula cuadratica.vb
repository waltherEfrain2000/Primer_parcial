Public Class formula_cuadratica
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, resultado As Double
        a = Val(txta.Text)
        b = Val(txtb.Text)
        c = Val(txtc.Text)

        resultado = (((-1) * b) + ((((b) ^ (2)) - (4 * a * c)) ^ (1 / 2))) / (2 * a)
        ta.Text = resultado


        resultado = (((-1) * b) - ((((b) ^ (2)) - (4 * a * c)) ^ (1 / 2))) / (2 * a)
        tb.Text = resultado

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txta.Clear()
        txtb.Clear()
        txtc.Clear()
        ta.Clear()
        tb.Clear()
    End Sub
End Class