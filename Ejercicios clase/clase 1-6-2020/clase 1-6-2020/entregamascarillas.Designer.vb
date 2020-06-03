<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entregamascarillas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbdepartamento = New System.Windows.Forms.ComboBox()
        Me.btnsolicitar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdepartamentos = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnentregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtminucipios = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbdepartamento)
        Me.GroupBox1.Controls.Add(Me.btnsolicitar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtdepartamentos)
        Me.GroupBox1.Font = New System.Drawing.Font("Sweet Candy DEMO", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(22, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "cantidad por departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "cant. por departamento"
        '
        'cmbdepartamento
        '
        Me.cmbdepartamento.FormattingEnabled = True
        Me.cmbdepartamento.Location = New System.Drawing.Point(168, 152)
        Me.cmbdepartamento.Name = "cmbdepartamento"
        Me.cmbdepartamento.Size = New System.Drawing.Size(121, 26)
        Me.cmbdepartamento.TabIndex = 3
        '
        'btnsolicitar
        '
        Me.btnsolicitar.Location = New System.Drawing.Point(127, 99)
        Me.btnsolicitar.Name = "btnsolicitar"
        Me.btnsolicitar.Size = New System.Drawing.Size(75, 23)
        Me.btnsolicitar.TabIndex = 2
        Me.btnsolicitar.Text = "solicitar"
        Me.btnsolicitar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "cantidad de departamentos"
        '
        'txtdepartamentos
        '
        Me.txtdepartamentos.Location = New System.Drawing.Point(187, 47)
        Me.txtdepartamentos.Name = "txtdepartamentos"
        Me.txtdepartamentos.Size = New System.Drawing.Size(100, 25)
        Me.txtdepartamentos.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.btnentregar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtminucipios)
        Me.GroupBox2.Font = New System.Drawing.Font("Javanese Text", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(408, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 253)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Distribucion "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 157)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 32)
        Me.TextBox1.TabIndex = 8
        '
        'btnentregar
        '
        Me.btnentregar.Location = New System.Drawing.Point(119, 99)
        Me.btnentregar.Name = "btnentregar"
        Me.btnentregar.Size = New System.Drawing.Size(75, 23)
        Me.btnentregar.TabIndex = 7
        Me.btnentregar.Text = "Entrega"
        Me.btnentregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "cantidad de municipios"
        '
        'txtminucipios
        '
        Me.txtminucipios.Location = New System.Drawing.Point(179, 54)
        Me.txtminucipios.Name = "txtminucipios"
        Me.txtminucipios.Size = New System.Drawing.Size(100, 32)
        Me.txtminucipios.TabIndex = 5
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(603, 298)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(100, 20)
        Me.txtstock.TabIndex = 8
        '
        'entregamascarillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "entregamascarillas"
        Me.Text = "entregamascarillas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbdepartamento As ComboBox
    Friend WithEvents btnsolicitar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdepartamentos As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnentregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtminucipios As TextBox
    Friend WithEvents txtstock As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
