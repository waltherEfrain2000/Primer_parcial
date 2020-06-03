Public Class entregamascarillas
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnsolicitar_Click(sender As Object, e As EventArgs) Handles btnsolicitar.Click
        Dim departamentos, mascarillas As Integer
        departamentos = Val(txtdepartamentos.Text)

        If departamentos <> 18 Then
            MessageBox.Show("Honduras solo tiene 18 departamentos ", "error Departamento ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtdepartamentos.Clear()
        Else


            For i = 1 To departamentos Step 1
                Do
                    mascarillas = InputBox("ingrese la cantidad de mascarillas del departamento : " & i, "Ingresar")

                Loop While (mascarillas < 0 Or mascarillas > 10000)
                cmbdepartamento.Items.Add(mascarillas)
            Next

        End If


    End Sub

    Private Sub cmbdepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdepartamento.SelectedIndexChanged

    End Sub

    Private Sub entregamascarillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbdepartamento.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnentregar_Click(sender As Object, e As EventArgs) Handles btnentregar.Click
        Dim iddepartamento, municipios, canEntera, fujomascariilas, flujomunicipios, prueba As Integer
        Dim itemdepartamento As Integer
        iddepartamento = cmbdepartamento.SelectedIndex
        itemdepartamento = cmbdepartamento.SelectedItem.ToString
        municipios = Val(txtminucipios.Text)


        Select Case iddepartamento
            Case 0
                TextBox1.Text = "atlatida"
                txtminucipios.Text = 8
                municipios = Val(txtminucipios.Text)
                fujomascariilas = itemdepartamento * 0.9
                flujomunicipios = municipios * 0.4
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (fujomascariilas = itemdepartamento And flujomunicipios = municipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End While
                Next

            Case 1
                TextBox1.Text = "colon"
                txtminucipios.Text = 10
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                fujomascariilas = itemdepartamento * 0.9
                flujomunicipios = municipios * 0.4
                prueba = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios municipios", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next

            Case 2
                TextBox1.Text = "comayagua"
                txtminucipios.Text = 21
                municipios = Val(txtminucipios.Text)
                prueba = itemdepartamento
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios municipios", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next
            Case 3
                TextBox1.Text = "copan"
                txtminucipios.Text = 23
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next
            Case 4
                TextBox1.Text = "cortes"
                txtminucipios.Text = 12
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next

            Case 5
                TextBox1.Text = "Choluteca"
                txtminucipios.Text = 16
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next
            Case 6
                TextBox1.Text = "EL paraiso"
                txtminucipios.Text = 19
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next
            Case 7
                TextBox1.Text = "Francisco Morazan"
                txtminucipios.Text = 28
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next
            Case 8
                TextBox1.Text = "Gracias a Dios"
                txtminucipios.Text = 6
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next
            Case 9
                TextBox1.Text = "intibuca"
                txtminucipios.Text = 17
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next
            Case 10
                TextBox1.Text = "islas de la bahia"
                txtminucipios.Text = 4
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next
            Case 11
                TextBox1.Text = "La paz "
                txtminucipios.Text = 19
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next
            Case 12
                TextBox1.Text = "lempira"
                txtminucipios.Text = 28
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next
            Case 13
                TextBox1.Text = "ocotepeque"
                txtminucipios.Text = 16
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next

            Case 14
                TextBox1.Text = "olancho"
                txtminucipios.Text = 23
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next
            Case 15
                TextBox1.Text = "santa barbara"
                txtminucipios.Text = 28
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next
            Case 16
                TextBox1.Text = "valle"
                txtminucipios.Text = 9
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next
            Case 17
                TextBox1.Text = "yoro"
                txtminucipios.Text = 11
                municipios = Val(txtminucipios.Text)
                txtstock.Text = itemdepartamento
                For i = 1 To municipios Step 1
                    While (itemdepartamento > 0)
                        canEntera = InputBox("ingrese la cantidad a entegrar", "entrega de mascarillas")
                        If (itemdepartamento > canEntera) Then
                            municipios += 1
                            itemdepartamento -= canEntera
                            txtstock.Text = itemdepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                        If (itemdepartamento < fujomascariilas And municipios > flujomunicipios) Then
                            MessageBox.Show("Sea mas equitativo con las mascarillas faltan varios departamentos", "error entrega ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End While
                Next

        End Select
        txtstock.Text = itemdepartamento
    End Sub
End Class