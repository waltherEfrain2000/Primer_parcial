<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uso_de_Checkbox
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValorA = New System.Windows.Forms.TextBox()
        Me.txtValorB = New System.Windows.Forms.TextBox()
        Me.chbkSuma = New System.Windows.Forms.CheckBox()
        Me.chbxResta = New System.Windows.Forms.CheckBox()
        Me.chbxMulti = New System.Windows.Forms.CheckBox()
        Me.chbxDivision = New System.Windows.Forms.CheckBox()
        Me.chbxRaiz = New System.Windows.Forms.CheckBox()
        Me.chbxPotencia = New System.Windows.Forms.CheckBox()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.txtRespuestaResta = New System.Windows.Forms.TextBox()
        Me.txtRespuestaSuma = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRespuestaMulti = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRespuestaPotencia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRespuestaRaiz = New System.Windows.Forms.TextBox()
        Me.txtRespuestaDivi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor B"
        '
        'txtValorA
        '
        Me.txtValorA.Location = New System.Drawing.Point(102, 40)
        Me.txtValorA.Name = "txtValorA"
        Me.txtValorA.Size = New System.Drawing.Size(100, 20)
        Me.txtValorA.TabIndex = 2
        '
        'txtValorB
        '
        Me.txtValorB.Location = New System.Drawing.Point(102, 76)
        Me.txtValorB.Name = "txtValorB"
        Me.txtValorB.Size = New System.Drawing.Size(100, 20)
        Me.txtValorB.TabIndex = 3
        '
        'chbkSuma
        '
        Me.chbkSuma.AutoSize = True
        Me.chbkSuma.Location = New System.Drawing.Point(260, 39)
        Me.chbkSuma.Name = "chbkSuma"
        Me.chbkSuma.Size = New System.Drawing.Size(53, 17)
        Me.chbkSuma.TabIndex = 4
        Me.chbkSuma.Text = "Suma"
        Me.chbkSuma.UseVisualStyleBackColor = True
        '
        'chbxResta
        '
        Me.chbxResta.AutoSize = True
        Me.chbxResta.Location = New System.Drawing.Point(260, 62)
        Me.chbxResta.Name = "chbxResta"
        Me.chbxResta.Size = New System.Drawing.Size(54, 17)
        Me.chbxResta.TabIndex = 5
        Me.chbxResta.Text = "Resta"
        Me.chbxResta.UseVisualStyleBackColor = True
        '
        'chbxMulti
        '
        Me.chbxMulti.AutoSize = True
        Me.chbxMulti.Location = New System.Drawing.Point(260, 85)
        Me.chbxMulti.Name = "chbxMulti"
        Me.chbxMulti.Size = New System.Drawing.Size(90, 17)
        Me.chbxMulti.TabIndex = 6
        Me.chbxMulti.Text = "Multiplicación"
        Me.chbxMulti.UseVisualStyleBackColor = True
        '
        'chbxDivision
        '
        Me.chbxDivision.AutoSize = True
        Me.chbxDivision.Location = New System.Drawing.Point(354, 39)
        Me.chbxDivision.Name = "chbxDivision"
        Me.chbxDivision.Size = New System.Drawing.Size(63, 17)
        Me.chbxDivision.TabIndex = 7
        Me.chbxDivision.Text = "División"
        Me.chbxDivision.UseVisualStyleBackColor = True
        '
        'chbxRaiz
        '
        Me.chbxRaiz.AutoSize = True
        Me.chbxRaiz.Location = New System.Drawing.Point(354, 62)
        Me.chbxRaiz.Name = "chbxRaiz"
        Me.chbxRaiz.Size = New System.Drawing.Size(49, 17)
        Me.chbxRaiz.TabIndex = 8
        Me.chbxRaiz.Text = "Raíz"
        Me.chbxRaiz.UseVisualStyleBackColor = True
        '
        'chbxPotencia
        '
        Me.chbxPotencia.AutoSize = True
        Me.chbxPotencia.Location = New System.Drawing.Point(354, 85)
        Me.chbxPotencia.Name = "chbxPotencia"
        Me.chbxPotencia.Size = New System.Drawing.Size(68, 17)
        Me.chbxPotencia.TabIndex = 9
        Me.chbxPotencia.Text = "Potencia"
        Me.chbxPotencia.UseVisualStyleBackColor = True
        '
        'btnAccion
        '
        Me.btnAccion.Location = New System.Drawing.Point(113, 122)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(75, 23)
        Me.btnAccion.TabIndex = 10
        Me.btnAccion.Text = "Acción"
        Me.btnAccion.UseVisualStyleBackColor = True
        '
        'txtRespuestaResta
        '
        Me.txtRespuestaResta.Location = New System.Drawing.Point(102, 212)
        Me.txtRespuestaResta.Name = "txtRespuestaResta"
        Me.txtRespuestaResta.Size = New System.Drawing.Size(100, 20)
        Me.txtRespuestaResta.TabIndex = 15
        '
        'txtRespuestaSuma
        '
        Me.txtRespuestaSuma.Location = New System.Drawing.Point(102, 176)
        Me.txtRespuestaSuma.Name = "txtRespuestaSuma"
        Me.txtRespuestaSuma.Size = New System.Drawing.Size(100, 20)
        Me.txtRespuestaSuma.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Resta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Suma"
        '
        'txtRespuestaMulti
        '
        Me.txtRespuestaMulti.Location = New System.Drawing.Point(102, 248)
        Me.txtRespuestaMulti.Name = "txtRespuestaMulti"
        Me.txtRespuestaMulti.Size = New System.Drawing.Size(100, 20)
        Me.txtRespuestaMulti.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Multiplicación"
        '
        'txtRespuestaPotencia
        '
        Me.txtRespuestaPotencia.Location = New System.Drawing.Point(301, 251)
        Me.txtRespuestaPotencia.Name = "txtRespuestaPotencia"
        Me.txtRespuestaPotencia.Size = New System.Drawing.Size(100, 20)
        Me.txtRespuestaPotencia.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(223, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Potencia"
        '
        'txtRespuestaRaiz
        '
        Me.txtRespuestaRaiz.Location = New System.Drawing.Point(301, 215)
        Me.txtRespuestaRaiz.Name = "txtRespuestaRaiz"
        Me.txtRespuestaRaiz.Size = New System.Drawing.Size(100, 20)
        Me.txtRespuestaRaiz.TabIndex = 21
        '
        'txtRespuestaDivi
        '
        Me.txtRespuestaDivi.Location = New System.Drawing.Point(301, 179)
        Me.txtRespuestaDivi.Name = "txtRespuestaDivi"
        Me.txtRespuestaDivi.Size = New System.Drawing.Size(100, 20)
        Me.txtRespuestaDivi.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(223, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Raíz"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(223, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "División"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(260, 122)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 24
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Uso_de_Checkbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 313)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtRespuestaPotencia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRespuestaRaiz)
        Me.Controls.Add(Me.txtRespuestaDivi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRespuestaMulti)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRespuestaResta)
        Me.Controls.Add(Me.txtRespuestaSuma)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAccion)
        Me.Controls.Add(Me.chbxPotencia)
        Me.Controls.Add(Me.chbxRaiz)
        Me.Controls.Add(Me.chbxDivision)
        Me.Controls.Add(Me.chbxMulti)
        Me.Controls.Add(Me.chbxResta)
        Me.Controls.Add(Me.chbkSuma)
        Me.Controls.Add(Me.txtValorB)
        Me.Controls.Add(Me.txtValorA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Uso_de_Checkbox"
        Me.Text = "Uso_de_Checkbox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValorA As TextBox
    Friend WithEvents txtValorB As TextBox
    Friend WithEvents chbkSuma As CheckBox
    Friend WithEvents chbxResta As CheckBox
    Friend WithEvents chbxMulti As CheckBox
    Friend WithEvents chbxDivision As CheckBox
    Friend WithEvents chbxRaiz As CheckBox
    Friend WithEvents chbxPotencia As CheckBox
    Friend WithEvents btnAccion As Button

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles chbxRaiz.CheckedChanged

    End Sub

    Private Sub txtValorA_TextChanged(sender As Object, e As EventArgs) Handles txtValorA.TextChanged

    End Sub

    Friend WithEvents txtRespuestaResta As TextBox
    Friend WithEvents txtRespuestaSuma As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRespuestaMulti As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRespuestaPotencia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRespuestaRaiz As TextBox
    Friend WithEvents txtRespuestaDivi As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        'decalraicon de variables
        Dim valorA As Int16
        Dim ValorB As Int16
        Dim Suma As Int16
        Dim Resta As Int16
        Dim Multi As Int16
        Dim Divi As Int16
        Dim Raiz As Int16
        Dim Potencia As Int16

        'validaciones de numeros de primer texto
        If txtValorA.Text = "" Then
            MsgBox("Ingrese un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtValorA.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtValorA.Text = ""
        ElseIf IsNumeric(valorA) Then
            valorA = Val(txtValorA.Text)
        End If

        'validacion de numeros de segundo texto
        If txtValorB.Text = "" Then
            MsgBox("Ingrese un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtValorB.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtValorB.Text = ""
        ElseIf IsNumeric(ValorB) Then
            ValorB = Val(txtValorB.Text)
        End If

        'CheckBox de Suma
        If chbkSuma.Checked = True Then
            Suma = valorA + ValorB
            txtRespuestaSuma.Text = Suma
        End If

        'CheckBox de Resta
        If chbxResta.Checked = True Then
            Resta = valorA - ValorB
            txtRespuestaResta.Text = Resta
        End If

        'CheckBox de Multiplicacion
        If chbxMulti.Checked = True Then
            Multi = valorA * ValorB
            txtRespuestaMulti.Text = Multi
        End If

        'CheckBox de Division
        If ValorB = 0 Then
            MsgBox("Numero cero invalido", vbObjectError)
        End If

        If chbxDivision.Checked = True Then
            Divi = valorA / ValorB
            txtRespuestaDivi.Text = Divi
        End If

        'CheckBox de Raiz
        If chbxRaiz.Checked = True Then
            Raiz = valorA
            txtRespuestaRaiz.Text = Raiz
        End If

        'CheckBox de Potencia
        If chbxPotencia.Checked = True Then
            Potencia = valorA * valorA
            txtRespuestaPotencia.Text = Potencia
        End If

    End Sub

    Private Sub txtValorB_TextChanged(sender As Object, e As EventArgs) Handles txtValorB.TextChanged

    End Sub

    Friend WithEvents btnLimpiar As Button

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtValorA.Clear()
        txtValorB.Clear()

        txtRespuestaSuma.Clear()
        txtRespuestaResta.Clear()
        txtRespuestaMulti.Clear()
        txtRespuestaDivi.Clear()
        txtRespuestaRaiz.Clear()
        txtRespuestaPotencia.Clear()

    End Sub
End Class
