Public Class sueldo_determinado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sueldo, deduccion, total As Double

        sueldo = Val(TextBox1.Text)

        If sueldo < 16582.62 Then
            MessageBox.Show("su sueldo esta excento de deduccion ", "sueldo excento!")
            deduccion = sueldo

            TextBox2.Text = deduccion
            TextBox3.Text = 0
            TextBox4.Text = deduccion
        Else

        End If

        If sueldo > 16582.62 And sueldo < 23536.661 Then
            MessageBox.Show("su sueldo tiene un 15% de deduccion", "sueldo con deduccion")
            deduccion = sueldo * 0.15

            total = sueldo - deduccion
            TextBox2.Text = sueldo
            TextBox3.Text = deduccion
            TextBox4.Text = total
        Else

        End If
        If sueldo > 23536.62 And sueldo < 50317.69 Then
            MessageBox.Show("su sueldo tiene un 20% de deduccion", "sueldo con deduccion")
            deduccion = sueldo * 0.2


            total = sueldo - deduccion
            TextBox2.Text = sueldo
            TextBox3.Text = deduccion
            TextBox4.Text = total
        Else

        End If

        If sueldo > 50317.7 Then
            MessageBox.Show("su sueldo tiene un 25% de deduccion", "sueldo con deduccion")
            deduccion = sueldo * 0.25

            total = sueldo - deduccion
            TextBox2.Text = sueldo
            TextBox3.Text = deduccion
            TextBox4.Text = total
        Else

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub
End Class