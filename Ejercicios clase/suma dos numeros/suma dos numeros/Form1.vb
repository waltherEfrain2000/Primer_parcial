Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'inicio
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer


        valor1 = Val(TextBox1.Text)
        valor2 = Val(TextBox2.Text)


        'proceso



        'salidas
        suma = valor1 + valor2
        TextBox3.Text = suma


    End Sub
End Class
