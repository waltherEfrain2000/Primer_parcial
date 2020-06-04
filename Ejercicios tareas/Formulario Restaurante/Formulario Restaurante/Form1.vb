Imports System.ComponentModel

Public Class User
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Application.Exit()
    End Sub

    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub maximizar_Click(sender As Object, e As EventArgs) Handles maximizar.Click
        WindowState = FormWindowState.Maximized

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WindowState = FormWindowState.Normal

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click



        'ValidateChildren  Botton
        'Validating     Cajas de texto
        Try
            'Si las casillas estan sin  ningun valor
            'Aplique a todos los elementos>  Producto sea diferente de vacio, precio sea diferente de vacio, Cantidad sea un valor entero
            If Me.ValidateChildren And TextBox1.Text <> String.Empty And MaskedTextBox1.Text <> String.Empty Then

            Else
                MessageBox.Show("Revise los datos ingresados", "Error en INGRESO DE USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            If TextBox1.Text = "Admin" And MaskedTextBox1.Text = "2000" Then
                Menuprincipal.Show()
                Me.Hide()
            Else
                MsgBox("INGRESE USUARIO Y CONTRASEÑA CORRECTA")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub MaskedTextBox1_Validating(sender As Object, e As CancelEventArgs) Handles MaskedTextBox1.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "la contraseña es obligatoria ")
        End If
    End Sub

    Private Sub MaskedTextBox1_MouseHover(sender As Object, e As EventArgs) Handles MaskedTextBox1.MouseHover
        ToolTip.SetToolTip(MaskedTextBox1, "Ingrese una contraseña")
        ToolTip.ToolTipTitle = "Contraseña"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        ToolTip.SetToolTip(TextBox1, "Ingrese el usuario")
        ToolTip.ToolTipTitle = "USUARIO"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
