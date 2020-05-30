<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ckmultiplicacion = New System.Windows.Forms.CheckBox()
        Me.ckdivision = New System.Windows.Forms.CheckBox()
        Me.ckpotencia = New System.Windows.Forms.CheckBox()
        Me.ckraiz = New System.Windows.Forms.CheckBox()
        Me.txtresultados = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(366, 56)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 0
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(366, 82)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 1
        '
        'cksuma
        '
        Me.cksuma.AutoSize = True
        Me.cksuma.Location = New System.Drawing.Point(305, 154)
        Me.cksuma.Name = "cksuma"
        Me.cksuma.Size = New System.Drawing.Size(53, 17)
        Me.cksuma.TabIndex = 2
        Me.cksuma.Text = "Suma"
        Me.cksuma.UseVisualStyleBackColor = True
        '
        'ckresta
        '
        Me.ckresta.AutoSize = True
        Me.ckresta.Location = New System.Drawing.Point(477, 154)
        Me.ckresta.Name = "ckresta"
        Me.ckresta.Size = New System.Drawing.Size(54, 17)
        Me.ckresta.TabIndex = 3
        Me.ckresta.Text = "Resta"
        Me.ckresta.UseVisualStyleBackColor = True
        '
        'ckmultiplicacion
        '
        Me.ckmultiplicacion.AutoSize = True
        Me.ckmultiplicacion.Location = New System.Drawing.Point(305, 177)
        Me.ckmultiplicacion.Name = "ckmultiplicacion"
        Me.ckmultiplicacion.Size = New System.Drawing.Size(90, 17)
        Me.ckmultiplicacion.TabIndex = 4
        Me.ckmultiplicacion.Text = "Multiplicacion"
        Me.ckmultiplicacion.UseVisualStyleBackColor = True
        '
        'ckdivision
        '
        Me.ckdivision.AutoSize = True
        Me.ckdivision.Location = New System.Drawing.Point(477, 177)
        Me.ckdivision.Name = "ckdivision"
        Me.ckdivision.Size = New System.Drawing.Size(63, 17)
        Me.ckdivision.TabIndex = 5
        Me.ckdivision.Text = "Division"
        Me.ckdivision.UseVisualStyleBackColor = True
        '
        'ckpotencia
        '
        Me.ckpotencia.AutoSize = True
        Me.ckpotencia.Location = New System.Drawing.Point(305, 200)
        Me.ckpotencia.Name = "ckpotencia"
        Me.ckpotencia.Size = New System.Drawing.Size(68, 17)
        Me.ckpotencia.TabIndex = 6
        Me.ckpotencia.Text = "Potencia"
        Me.ckpotencia.UseVisualStyleBackColor = True
        '
        'ckraiz
        '
        Me.ckraiz.AutoSize = True
        Me.ckraiz.Location = New System.Drawing.Point(477, 200)
        Me.ckraiz.Name = "ckraiz"
        Me.ckraiz.Size = New System.Drawing.Size(47, 17)
        Me.ckraiz.TabIndex = 7
        Me.ckraiz.Text = "Raiz"
        Me.ckraiz.UseVisualStyleBackColor = True
        '
        'txtresultados
        '
        Me.txtresultados.Location = New System.Drawing.Point(366, 223)
        Me.txtresultados.Name = "txtresultados"
        Me.txtresultados.Size = New System.Drawing.Size(100, 20)
        Me.txtresultados.TabIndex = 8
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(376, 264)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 9
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtresultados)
        Me.Controls.Add(Me.ckraiz)
        Me.Controls.Add(Me.ckpotencia)
        Me.Controls.Add(Me.ckdivision)
        Me.Controls.Add(Me.ckmultiplicacion)
        Me.Controls.Add(Me.ckresta)
        Me.Controls.Add(Me.cksuma)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents cksuma As CheckBox
    Friend WithEvents ckresta As CheckBox
    Friend WithEvents ckmultiplicacion As CheckBox
    Friend WithEvents ckdivision As CheckBox
    Friend WithEvents ckpotencia As CheckBox
    Friend WithEvents ckraiz As CheckBox
    Friend WithEvents txtresultados As TextBox
    Friend WithEvents btncalcular As Button
End Class
