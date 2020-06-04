Imports System.ComponentModel

Public Class Menuprincipal
    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Dim OPC As DialogResult
        OPC = MessageBox.Show("¿Desea Seguir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If OPC = DialogResult.Yes Then
            Application.Exit()
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub maximizar_Click(sender As Object, e As EventArgs) Handles maximizar.Click
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Menuprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtnachostxtnachos_TextChanged(sender As Object, e As EventArgs) Handles txtnachostxtnachos.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        cbhamburguesa.Checked = True

    End Sub

    Private Sub cbhamburguesa_CheckedChanged(sender As Object, e As EventArgs) Handles cbhamburguesa.CheckedChanged
        txthamburguer.Enabled = True

        If cbhamburguesa.Checked = False Then
            txthamburguer.Clear()
            txthamburguer.Enabled = False



        End If
        Button1.Focus()
    End Sub

    Private Sub cknachos_CheckedChanged(sender As Object, e As EventArgs) Handles cknachos.CheckedChanged
        txtnachostxtnachos.Enabled = True

        If cknachos.Checked = False Then
            txtnachostxtnachos.Clear()
            txtnachostxtnachos.Enabled = False



        End If
        Button1.Focus()
    End Sub

    Private Sub ckpizza_CheckedChanged(sender As Object, e As EventArgs) Handles ckpizza.CheckedChanged
        txtpizza.Enabled = True

        If ckpizza.Checked = False Then
            txtpizza.Clear()
            txtpizza.Enabled = False



        End If
    End Sub

    Private Sub ckpollo_CheckedChanged(sender As Object, e As EventArgs) Handles ckpollo.CheckedChanged
        txtpollo.Enabled = True

        If ckpollo.Checked = False Then
            txtpollo.Clear()
            txtpollo.Enabled = False



        End If
        Button1.Focus()
    End Sub

    Private Sub ckcamarones_CheckedChanged(sender As Object, e As EventArgs) Handles ckcamarones.CheckedChanged
        txtcamarones.Enabled = True

        If ckcamarones.Checked = False Then
            txtcamarones.Clear()
            txtcamarones.Enabled = False



        End If
        Button1.Focus()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        cknachos.Checked = True
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ckpizza.Checked = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ckpollo.Checked = True
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        ckcamarones.Checked = True
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        ckaros.Checked = True
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        ckpapitas.Checked = True
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        ckensalada.Checked = True
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        cktortilla.Checked = True

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        ckcebolla.Checked = True

    End Sub

    Private Sub ckpapitas_CheckedChanged(sender As Object, e As EventArgs) Handles ckpapitas.CheckedChanged
        txtpapas.Enabled = True

        If ckpapitas.Checked = False Then
            txtpapas.Clear()
            txtpapas.Enabled = False



        End If
    End Sub

    Private Sub ckensalada_CheckedChanged(sender As Object, e As EventArgs) Handles ckensalada.CheckedChanged
        txtensalada.Enabled = True

        If ckensalada.Checked = False Then
            txtensalada.Clear()
            txtensalada.Enabled = False



        End If
    End Sub

    Private Sub ckaros_CheckedChanged(sender As Object, e As EventArgs) Handles ckaros.CheckedChanged
        txtaros.Enabled = True

        If ckaros.Checked = False Then
            txtaros.Clear()
            txtaros.Enabled = False



        End If
    End Sub

    Private Sub cktortilla_CheckedChanged(sender As Object, e As EventArgs) Handles cktortilla.CheckedChanged
        txttortillas.Enabled = True

        If cktortilla.Checked = False Then
            txttortillas.Clear()
            txttortillas.Enabled = False



        End If
    End Sub

    Private Sub ckcebolla_CheckedChanged(sender As Object, e As EventArgs) Handles ckcebolla.CheckedChanged
        txtcebolla.Enabled = True

        If ckcebolla.Checked = False Then
            txtcebolla.Clear()
            txtcebolla.Enabled = False



        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        ckcola.Checked = True
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        ckpepsi.Checked = True
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        ckcerveza.Checked = True
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        cknatural.Checked = True
    End Sub

    Private Sub ckcola_CheckedChanged(sender As Object, e As EventArgs) Handles ckcola.CheckedChanged
        txtcola.Enabled = True

        If ckcola.Checked = False Then
            txtcola.Clear()
            txtcola.Enabled = False



        End If
    End Sub

    Private Sub ckpepsi_CheckedChanged(sender As Object, e As EventArgs) Handles ckpepsi.CheckedChanged
        txtpepsi.Enabled = True

        If ckpepsi.Checked = False Then
            txtpepsi.Clear()
            txtpepsi.Enabled = False



        End If
    End Sub

    Private Sub ckcerveza_CheckedChanged(sender As Object, e As EventArgs) Handles ckcerveza.CheckedChanged
        txtcerveza.Enabled = True

        If ckcerveza.Checked = False Then
            txtcerveza.Clear()
            txtcerveza.Enabled = False



        End If
    End Sub

    Private Sub cknatural_CheckedChanged(sender As Object, e As EventArgs) Handles cknatural.CheckedChanged
        txtbebida.Enabled = True

        If cknatural.Checked = False Then
            txtbebida.Clear()
            txtbebida.Enabled = False



        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ComboBox1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim acumulador, total, acumuladorcc, totalc, acumuladorbebida, totalb As Integer
        Dim platilloHamburguesa, platilloNachos, platilloPizza, platilloPollo, platilloCamarones As Integer
        Dim cPapas, cEnsalda, cAros, cTortilla, cEncurtido As Integer
        Dim coca, pepsi, cerveza, natural, snack, c As Integer

        Try

            If Me.ValidateChildren And txthamburguer.Text <> String.Empty And txtnachostxtnachos.Text <> String.Empty And txtpizza.Text <> String.Empty And txtpollo.Text <> String.Empty And txtcamarones.Text <> String.Empty Then

            Else
                MessageBox.Show("Favor ingrese almenos un platillo fuerte SOMOS UN RESTAURANTE SERIO", "NO INGRESO PLATILLO FUERTE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        platilloHamburguesa = Val(txthamburguer.Text)
        platilloNachos = Val(txtnachostxtnachos.Text)
        platilloPizza = Val(txtpizza.Text)
        platilloPollo = Val(txtpollo.Text)
        platilloCamarones = Val(txtcamarones.Text)


        cPapas = Val(txtpapas.Text)
        cEnsalda = Val(txtensalada.Text)
        cAros = Val(txtaros.Text)
        cTortilla = Val(txttortillas.Text)
        cEncurtido = Val(txtcebolla.Text)

        coca = Val(txtcola.Text)
        pepsi = Val(txtpepsi.Text)
        cerveza = Val(txtcerveza.Text)
        natural = Val(txtbebida.Text)

        snack = Val(ComboBox1.Items.ToString)
        If cbhamburguesa.Checked = True Then
            acumulador = platilloHamburguesa * 100
            total = total + acumulador
        End If

        If cknachos.Checked = True Then
            acumulador = platilloNachos * 80
            total = total + acumulador
        End If


        If ckpizza.Checked = True Then
            acumulador = platilloPizza * 180
            total = total + acumulador

        End If


        If ckpollo.Checked = True Then
            acumulador = platilloPollo * 150
            total = total + acumulador
        End If


        If ckcamarones.Checked = True Then
            acumulador = platilloCamarones * 300
            totalc = totalc + acumulador
        End If


        If ckpapitas.Checked = True Then
            acumuladorcc = cPapas * 45
            totalc = totalc + acumuladorcc
        End If

        If ckensalada.Checked = True Then
            acumuladorcc = cEnsalda * 55
            totalc = totalc + acumuladorcc
        End If

        If ckaros.Checked = True Then
            acumuladorcc = cAros * 65
            totalc = totalc + acumuladorcc
        End If

        If cktortilla.Checked = True Then
            acumuladorcc = cTortilla * 25
            totalc = totalc + acumuladorcc
        End If

        If ckcebolla.Checked = True Then
            acumuladorcc = cEncurtido * 30
            totalc = totalc + acumuladorcc
        End If



        If ckcola.Checked = True Then
            acumuladorbebida = coca * 45
            totalb = totalb + acumuladorbebida
        End If


        If ckpepsi.Checked = True Then
            acumuladorbebida = pepsi * 45
            totalb = totalb + acumuladorbebida
        End If


        If ckcerveza.Checked = True Then
            acumuladorbebida = cerveza * 85
            totalb = totalb + acumuladorbebida
        End If

        If cknatural.Checked = True Then
            acumuladorbebida = natural * 15
            totalb = totalb + acumuladorbebida
        End If

        total = total + totalc + totalb

        If RadioButton1.Checked = True Then
            total = total + 45


        End If


        If CheckBox1.Checked = True Then


            Select Case snack
                Case 0
                    total = total + 25

                Case 1
                    total = total + 25
                Case 2
                    total = total + 25
                Case 3
                    total = total + 25
                Case 4
                    total = total + 25


                    c = c + 1
            End Select

        End If
        TextBox.Text = total
        Button4.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nombrecliente As String
        Dim cobro, vuelto, total As Integer

        Try
            'Si las casillas estan sin  ningun valor
            'Aplique a todos los elementos>  Producto sea diferente de vacio, precio sea diferente de vacio, Cantidad sea un valor entero
            If Me.ValidateChildren And TextBox.Text <> String.Empty Then


                For i = 1 To 1
                    nombrecliente = InputBox("Ingrese el nombre del usuario", "Nombre usuario")


                    While IsNumeric(nombrecliente)
                        MessageBox.Show("No se vale carnal solo ingresa tu nombre no numero ! ")
                        nombrecliente = InputBox("Ingrese el nombre del usuario", "Nombre usuario")
                    End While

                    clientee.Text = nombrecliente

                    cobro = InputBox("Ingrese el dinero del cliente", "dinero cliente")
                    total = Val(TextBox.Text)

                    While cobro < total





                        MessageBox.Show("el dinero que paga el cliente tiene que ser mayor a del gasto total lisento ;(", "Error en INGRESO DE COBRO", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                        cobro = InputBox("Ingrese el dinero del cliente", "dinero cliente")
                    End While




                    vuelto = cobro - total
                    MessageBox.Show("el cambio para el cliente es :" & vuelto, "Cambio cliente")


                    pago.Text = cobro
                    cambio.Text = vuelto

                Next

            Else
                MessageBox.Show("No hay selecionado ninguna comida", "Error en Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox.TextChanged

    End Sub

    Private Sub TextBox_Validating(sender As Object, e As CancelEventArgs) Handles TextBox.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OPC As DialogResult
        OPC = MessageBox.Show("¿Desea Seguir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If OPC = DialogResult.Yes Then
            Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox.Clear()
        clientee.Text = ""
        pago.Text = ""
        cambio.Text = ""
        cbhamburguesa.Checked = False
        cknachos.Checked = False
        ckpizza.Checked = False
        ckpollo.Checked = False
        ckcamarones.Checked = False
        ckpapitas.Checked = False
        ckensalada.Checked = False
        ckaros.Checked = False
        cktortilla.Checked = False
        ckcebolla.Checked = False
        ckcola.Checked = False
        ckpepsi.Checked = False
        ckcerveza.Checked = False
        cknatural.Checked = False

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        CheckBox1.Checked = False

    End Sub
End Class