<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculo_numeros
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
        Me.txtnumeros = New System.Windows.Forms.TextBox()
        Me.iniciar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpares = New System.Windows.Forms.TextBox()
        Me.txtimpar = New System.Windows.Forms.TextBox()
        Me.txtpositivos = New System.Windows.Forms.TextBox()
        Me.txtnegativos = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtsuma = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese la cantidad de numeros a calcular"
        '
        'txtnumeros
        '
        Me.txtnumeros.Location = New System.Drawing.Point(313, 36)
        Me.txtnumeros.Name = "txtnumeros"
        Me.txtnumeros.Size = New System.Drawing.Size(100, 20)
        Me.txtnumeros.TabIndex = 1
        '
        'iniciar
        '
        Me.iniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.iniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iniciar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.iniciar.Location = New System.Drawing.Point(231, 71)
        Me.iniciar.Name = "iniciar"
        Me.iniciar.Size = New System.Drawing.Size(75, 23)
        Me.iniciar.TabIndex = 2
        Me.iniciar.Text = "iniciar"
        Me.iniciar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Malgun Gothic Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(410, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 196)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sus numero ingresados son :"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 25)
        Me.ComboBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.txtsuma)
        Me.GroupBox2.Controls.Add(Me.txttotal)
        Me.GroupBox2.Controls.Add(Me.txtnegativos)
        Me.GroupBox2.Controls.Add(Me.txtpositivos)
        Me.GroupBox2.Controls.Add(Me.txtimpar)
        Me.GroupBox2.Controls.Add(Me.txtpares)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(30, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 260)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Caracteristicas de sus numeros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "sus numeros pares"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "sus numeros impares"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "sus numeros positivos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "sus numeros negativos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "total de numeros"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "suma de los numeros"
        '
        'txtpares
        '
        Me.txtpares.Enabled = False
        Me.txtpares.Location = New System.Drawing.Point(183, 43)
        Me.txtpares.Name = "txtpares"
        Me.txtpares.Size = New System.Drawing.Size(100, 23)
        Me.txtpares.TabIndex = 6
        '
        'txtimpar
        '
        Me.txtimpar.Enabled = False
        Me.txtimpar.Location = New System.Drawing.Point(183, 73)
        Me.txtimpar.Name = "txtimpar"
        Me.txtimpar.Size = New System.Drawing.Size(100, 23)
        Me.txtimpar.TabIndex = 7
        '
        'txtpositivos
        '
        Me.txtpositivos.Enabled = False
        Me.txtpositivos.Location = New System.Drawing.Point(183, 112)
        Me.txtpositivos.Name = "txtpositivos"
        Me.txtpositivos.Size = New System.Drawing.Size(100, 23)
        Me.txtpositivos.TabIndex = 8
        '
        'txtnegativos
        '
        Me.txtnegativos.Enabled = False
        Me.txtnegativos.Location = New System.Drawing.Point(183, 147)
        Me.txtnegativos.Name = "txtnegativos"
        Me.txtnegativos.Size = New System.Drawing.Size(100, 23)
        Me.txtnegativos.TabIndex = 9
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(183, 181)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 23)
        Me.txttotal.TabIndex = 10
        '
        'txtsuma
        '
        Me.txtsuma.Enabled = False
        Me.txtsuma.Location = New System.Drawing.Point(183, 215)
        Me.txtsuma.Name = "txtsuma"
        Me.txtsuma.Size = New System.Drawing.Size(100, 23)
        Me.txtsuma.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(478, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Restart"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'calculo_numeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(693, 417)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.iniciar)
        Me.Controls.Add(Me.txtnumeros)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "calculo_numeros"
        Me.Text = "calculo_numeros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnumeros As TextBox
    Friend WithEvents iniciar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtsuma As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtnegativos As TextBox
    Friend WithEvents txtpositivos As TextBox
    Friend WithEvents txtimpar As TextBox
    Friend WithEvents txtpares As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
