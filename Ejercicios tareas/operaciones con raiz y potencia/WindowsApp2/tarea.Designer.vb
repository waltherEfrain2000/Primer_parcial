<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tarea
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
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.cksuma = New System.Windows.Forms.CheckBox()
        Me.ckresta = New System.Windows.Forms.CheckBox()
        Me.ckmulti = New System.Windows.Forms.CheckBox()
        Me.ckdivision = New System.Windows.Forms.CheckBox()
        Me.ckpotencia = New System.Windows.Forms.CheckBox()
        Me.ckraiz = New System.Windows.Forms.CheckBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.txtresultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(329, 49)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 0
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(329, 92)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 1
        '
        'cksuma
        '
        Me.cksuma.AutoSize = True
        Me.cksuma.Location = New System.Drawing.Point(159, 166)
        Me.cksuma.Name = "cksuma"
        Me.cksuma.Size = New System.Drawing.Size(51, 17)
        Me.cksuma.TabIndex = 2
        Me.cksuma.Text = "suma"
        Me.cksuma.UseVisualStyleBackColor = True
        '
        'ckresta
        '
        Me.ckresta.AutoSize = True
        Me.ckresta.Location = New System.Drawing.Point(216, 166)
        Me.ckresta.Name = "ckresta"
        Me.ckresta.Size = New System.Drawing.Size(54, 17)
        Me.ckresta.TabIndex = 3
        Me.ckresta.Text = "Resta"
        Me.ckresta.UseVisualStyleBackColor = True
        '
        'ckmulti
        '
        Me.ckmulti.AutoSize = True
        Me.ckmulti.Location = New System.Drawing.Point(276, 166)
        Me.ckmulti.Name = "ckmulti"
        Me.ckmulti.Size = New System.Drawing.Size(90, 17)
        Me.ckmulti.TabIndex = 4
        Me.ckmulti.Text = "Multiplicacion"
        Me.ckmulti.UseVisualStyleBackColor = True
        '
        'ckdivision
        '
        Me.ckdivision.AutoSize = True
        Me.ckdivision.Location = New System.Drawing.Point(372, 166)
        Me.ckdivision.Name = "ckdivision"
        Me.ckdivision.Size = New System.Drawing.Size(63, 17)
        Me.ckdivision.TabIndex = 5
        Me.ckdivision.Text = "Division"
        Me.ckdivision.UseVisualStyleBackColor = True
        '
        'ckpotencia
        '
        Me.ckpotencia.AutoSize = True
        Me.ckpotencia.Location = New System.Drawing.Point(441, 166)
        Me.ckpotencia.Name = "ckpotencia"
        Me.ckpotencia.Size = New System.Drawing.Size(67, 17)
        Me.ckpotencia.TabIndex = 6
        Me.ckpotencia.Text = "potencia"
        Me.ckpotencia.UseVisualStyleBackColor = True
        '
        'ckraiz
        '
        Me.ckraiz.AutoSize = True
        Me.ckraiz.Location = New System.Drawing.Point(514, 166)
        Me.ckraiz.Name = "ckraiz"
        Me.ckraiz.Size = New System.Drawing.Size(47, 17)
        Me.ckraiz.TabIndex = 7
        Me.ckraiz.Text = "Raiz"
        Me.ckraiz.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(338, 251)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 8
        Me.Btn1.Text = "calcular"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'txtresultado
        '
        Me.txtresultado.Location = New System.Drawing.Point(350, 215)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(100, 20)
        Me.txtresultado.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(294, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "resultado"
        '
        'tarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtresultado)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.ckraiz)
        Me.Controls.Add(Me.ckpotencia)
        Me.Controls.Add(Me.ckdivision)
        Me.Controls.Add(Me.ckmulti)
        Me.Controls.Add(Me.ckresta)
        Me.Controls.Add(Me.cksuma)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Name = "tarea"
        Me.Text = "tarea"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents cksuma As CheckBox
    Friend WithEvents ckresta As CheckBox
    Friend WithEvents ckmulti As CheckBox
    Friend WithEvents ckdivision As CheckBox
    Friend WithEvents ckpotencia As CheckBox
    Friend WithEvents ckraiz As CheckBox
    Friend WithEvents Btn1 As Button
    Friend WithEvents txtresultado As TextBox
    Friend WithEvents Label1 As Label
End Class
