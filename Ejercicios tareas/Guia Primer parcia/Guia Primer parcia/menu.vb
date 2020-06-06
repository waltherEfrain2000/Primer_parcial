Public Class menu
    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarmenu()
    End Sub

    Private Sub ocultarmenu()
        Panelsubmenu.Visible = False
    End Sub
    Private actualform As Form = Nothing

    Private Sub mostrarforms(childform As Form)
        If actualform IsNot Nothing Then actualform.Close()
        actualform = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        PanelHijo.Controls.Add(childform)
        PanelHijo.Tag = childform
        childform.Show()


    End Sub

    Private Sub mostrarmenu(submenu As Panel)

        If submenu.Visible = False Then
            ocultarmenu()
            Panelsubmenu.Visible = True
        Else
            Panelsubmenu.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mostrarmenu(Panelsubmenu)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ocultarmenu()
        mostrarforms(New formula_cuadratica)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ocultarmenu()
        mostrarforms(New Calculadora)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ocultarmenu()
        mostrarforms(New _10Almacenes)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ocultarmenu()
        mostrarforms(New calculo_numeros)
    End Sub

    Private Sub PanelHijo_Paint(sender As Object, e As PaintEventArgs) Handles PanelHijo.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ocultarmenu()
        mostrarforms(New sueldo_determinado)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        ToolTip1.SetToolTip(Button1, "Menu desplegable haga click")
        ToolTip1.ToolTipTitle = "Hacer click"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        ToolTip1.SetToolTip(Button1, "Menu desplegable haga click")
        ToolTip1.ToolTipTitle = "Hacer click"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim OPC As DialogResult
        OPC = MessageBox.Show("¿Desea Seguir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If OPC = DialogResult.Yes Then
            Close()
        End If


    End Sub
End Class