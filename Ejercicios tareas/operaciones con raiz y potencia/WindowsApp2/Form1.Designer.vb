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
        Me.valor1 = New System.Windows.Forms.Label()
        Me.valor2 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rest = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.multi = New System.Windows.Forms.TextBox()
        Me.divi = New System.Windows.Forms.TextBox()
        Me.bntlimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(266, 77)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 0
        '
        'valor1
        '
        Me.valor1.AutoSize = True
        Me.valor1.Location = New System.Drawing.Point(202, 84)
        Me.valor1.Name = "valor1"
        Me.valor1.Size = New System.Drawing.Size(39, 13)
        Me.valor1.TabIndex = 1
        Me.valor1.Text = "valor 1"
        '
        'valor2
        '
        Me.valor2.AutoSize = True
        Me.valor2.Location = New System.Drawing.Point(202, 117)
        Me.valor2.Name = "valor2"
        Me.valor2.Size = New System.Drawing.Size(39, 13)
        Me.valor2.TabIndex = 2
        Me.valor2.Text = "valor 2"
        '
        'txt2
        '
        Me.txt2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt2.Location = New System.Drawing.Point(266, 117)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 3
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(183, 157)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 23)
        Me.btn.TabIndex = 4
        Me.btn.Text = "calcular"
        Me.btn.UseVisualStyleBackColor = True
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(266, 205)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(100, 20)
        Me.txt3.TabIndex = 5
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(278, 345)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 6
        Me.salir.Text = "salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(202, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "suma"
        '
        'rest
        '
        Me.rest.Location = New System.Drawing.Point(266, 243)
        Me.rest.Name = "rest"
        Me.rest.Size = New System.Drawing.Size(100, 20)
        Me.rest.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "resta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "multiplicacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(197, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Division"
        '
        'multi
        '
        Me.multi.Location = New System.Drawing.Point(266, 279)
        Me.multi.Name = "multi"
        Me.multi.Size = New System.Drawing.Size(100, 20)
        Me.multi.TabIndex = 12
        '
        'divi
        '
        Me.divi.Location = New System.Drawing.Point(266, 318)
        Me.divi.Name = "divi"
        Me.divi.Size = New System.Drawing.Size(100, 20)
        Me.divi.TabIndex = 13
        '
        'bntlimpiar
        '
        Me.bntlimpiar.Location = New System.Drawing.Point(336, 157)
        Me.bntlimpiar.Name = "bntlimpiar"
        Me.bntlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.bntlimpiar.TabIndex = 14
        Me.bntlimpiar.Text = "limpiar"
        Me.bntlimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bntlimpiar)
        Me.Controls.Add(Me.divi)
        Me.Controls.Add(Me.multi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rest)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.valor2)
        Me.Controls.Add(Me.valor1)
        Me.Controls.Add(Me.txt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents valor1 As Label
    Friend WithEvents valor2 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents btn As Button
    Friend WithEvents txt3 As TextBox
    Friend WithEvents salir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents rest As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents multi As TextBox
    Friend WithEvents divi As TextBox
    Friend WithEvents bntlimpiar As Button
End Class
