Public Class factura
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txt5.Text = ""
        txt6.Text = ""
        CheckBox1.Checked = 0
        CheckBox2.Checked = 0

        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False


        Try
            For Each ctl As Control In Me.Controls
                If TypeOf ctl Is ComboBox Then
                    ctl.Text = ""
                End If
            Next
        Catch ex As Exception
            MsgBox("se ha producido un error vuelva pronto")

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim total As Double
        Const terceraEdad As Double = 0.15
        Const clienteregular As Double = 0.2
        Const tarjetaCredito As Double = 0.1
        Const diversasCompras As Double = 0.08
        Const publicogeneral As Double = 0.05
        Const clientepremium As Double = 0.25
        Dim subtotal, subtotal1, descuentototal, isv As Double




        valor1 = Val(txt1.Text)
        valor2 = Val(txt2.Text)

        If txt1.Text = "" Then
            MsgBox(" No se le ovide colocar el precio unitario", vbInformation)
        ElseIf Not IsNumeric(txt1.Text) Then
            MsgBox(" Ingrese un valorcorrecto ", vbInformation)
            txt1.Text = ""
        End If

        If txt2.Text = "" Then
            MsgBox(" No se le ovide colocar la cantidad ", vbInformation)
        ElseIf Not IsNumeric(txt2.Text) Then
            MsgBox(" Ingrese un valor de cantidad validad ", vbInformation)
            txt2.Text = ""
        End If
        subtotal = valor1 * valor2


        If ComboBox1.Text = "Descuento Tercera Edad" Then

            descuentototal = subtotal * terceraEdad
            subtotal1 = subtotal - descuentototal
            isv = subtotal1 * 0.15
            total = subtotal1 + isv


            txt3.Text = subtotal
            txt4.Text = descuentototal
            txt5.Text = isv
            txt6.Text = total
            Button2.Visible = True

        Else


        End If

        If ComboBox1.Text = "Descuento Cliente regular" Then

            descuentototal = subtotal * clienteregular
            subtotal1 = subtotal - descuentototal
            isv = subtotal1 * 0.15
            total = subtotal1 + isv


            txt3.Text = subtotal
            txt4.Text = descuentototal
            txt5.Text = isv
            txt6.Text = total
            Button2.Visible = True

        Else


        End If


        If ComboBox1.Text = "Descuento Tarjeta de credito" Then

            descuentototal = subtotal * tarjetaCredito
            subtotal1 = subtotal - descuentototal
            isv = subtotal1 * 0.15
            total = subtotal1 + isv


            txt3.Text = subtotal
            txt4.Text = descuentototal
            txt5.Text = isv
            txt6.Text = total
            Button2.Visible = True

        Else


        End If

        If ComboBox1.Text = "Descuento Diversas compras" Then

            descuentototal = subtotal * diversasCompras
            subtotal1 = subtotal - descuentototal
            isv = subtotal1 * 0.15
            total = subtotal1 + isv


            txt3.Text = subtotal
            txt4.Text = descuentototal
            txt5.Text = isv
            txt6.Text = total
            Button2.Visible = True
        Else


        End If

        If ComboBox1.Text = "Descuento Publico general" Then

            descuentototal = subtotal * publicogeneral
            subtotal1 = subtotal - descuentototal
            isv = subtotal1 * 0.15
            total = subtotal1 + isv


            txt3.Text = subtotal
            txt4.Text = descuentototal
            txt5.Text = isv
            txt6.Text = total
            Button2.Visible = True

        Else


        End If

        If ComboBox1.Text = "Descuento cliente premiun" Then

            descuentototal = subtotal * clientepremium
            subtotal1 = subtotal - descuentototal
            isv = subtotal1 * 0.15
            total = subtotal1 + isv


            txt3.Text = subtotal
            txt4.Text = descuentototal
            txt5.Text = isv
            txt6.Text = total
            Button2.Visible = True

        Else


        End If

        If ComboBox2.Text = "el 15% de impuesto" Then
            subtotal1 = subtotal * 0.15
            subtotal = subtotal + subtotal1
            isv = subtotal * 0.15
            total = subtotal + isv

            txt3.Text = subtotal
            txt4.Text = "no hay descuento"
            txt5.Text = isv
            txt6.Text = total
            Button2.Visible = True





        End If

        If ComboBox2.Text = "el 17% de impuesto" Then
            subtotal1 = subtotal * 0.17
            subtotal = subtotal + subtotal1
            isv = subtotal * 0.15
            total = subtotal + isv

            txt3.Text = subtotal
            txt4.Text = "no hay descuento"
            txt5.Text = isv
            txt6.Text = total
            Button2.Visible = True





        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'ComboBox1.Items.Add("Descuento Tercera Edad")
        'ComboBox1.Items.Add("Descuento Cliente regular")
        'ComboBox1.Items.Add("Descuento Tarjeta de credito")
        'ComboBox1.Items.Add("Descuento Diversas compras")
        'ComboBox1.Items.Add("Descuento Publico general")
        'ComboBox1.Items.Add("Descuento cliente premiun")
        CheckBox2.Enabled = False
        ComboBox1.Enabled = True



    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        '  ComboBox2.Items.Add("el 15% de impuesto")
        ' ComboBox2.Items.Add("el 17% de impuesto")
        CheckBox1.Enabled = False
        ComboBox2.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
