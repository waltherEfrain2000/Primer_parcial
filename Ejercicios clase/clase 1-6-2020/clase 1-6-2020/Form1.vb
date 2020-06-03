Public Class contador_y_contador
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim orden, precio, total, totalpagar As Integer

            orden = txtorden.Text

            For i = 1 To orden Step 1
                precio = InputBox("Ingresa el precio del platillo No." & i, "precio del platillo")

                totalpagar += precio


            Next
            total = totalpagar / orden
            txtpagar.Text = totalpagar

            txtindividual.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtindividual.Clear()
        txtorden.Clear()
        txtpagar.Clear()

    End Sub
End Class
