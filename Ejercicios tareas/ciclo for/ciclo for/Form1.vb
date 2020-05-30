Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim t As Integer
        Dim i As Integer

        t = Val(textbox1.text)
        Label1.Font = New Font("Arial", 10, FontStyle.Bold)
        Label1.TextAlign = ContentAlignment.MiddleCenter
        Label1.Text = "TABLA DEL " & t & vbCrLf & vbCrLf
        For i = 1 To 10
            Label1.Text = Label1.Text & t & " * " & i & " = " & t * i & vbCrLf
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class
