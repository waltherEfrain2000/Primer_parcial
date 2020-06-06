<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.bhistory = New System.Windows.Forms.Button()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bigual = New System.Windows.Forms.Button()
        Me.bclear = New System.Windows.Forms.Button()
        Me.bsuma = New System.Windows.Forms.Button()
        Me.bresta = New System.Windows.Forms.Button()
        Me.bmultiplicacion = New System.Windows.Forms.Button()
        Me.bdivision = New System.Windows.Forms.Button()
        Me.bpunto = New System.Windows.Forms.Button()
        Me.b3 = New System.Windows.Forms.Button()
        Me.b6 = New System.Windows.Forms.Button()
        Me.b9 = New System.Windows.Forms.Button()
        Me.bnose = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b5 = New System.Windows.Forms.Button()
        Me.b8 = New System.Windows.Forms.Button()
        Me.b0 = New System.Windows.Forms.Button()
        Me.b1 = New System.Windows.Forms.Button()
        Me.b4 = New System.Windows.Forms.Button()
        Me.b7 = New System.Windows.Forms.Button()
        Me.caculos = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bhistory)
        Me.GroupBox1.Controls.Add(Me.ListBox)
        Me.GroupBox1.Location = New System.Drawing.Point(256, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 219)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'bhistory
        '
        Me.bhistory.Location = New System.Drawing.Point(1, 12)
        Me.bhistory.Name = "bhistory"
        Me.bhistory.Size = New System.Drawing.Size(176, 28)
        Me.bhistory.TabIndex = 1
        Me.bhistory.Text = "History"
        Me.bhistory.UseVisualStyleBackColor = True
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(4, 47)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(176, 160)
        Me.ListBox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.bigual)
        Me.GroupBox2.Controls.Add(Me.bclear)
        Me.GroupBox2.Controls.Add(Me.bsuma)
        Me.GroupBox2.Controls.Add(Me.bresta)
        Me.GroupBox2.Controls.Add(Me.bmultiplicacion)
        Me.GroupBox2.Controls.Add(Me.bdivision)
        Me.GroupBox2.Controls.Add(Me.bpunto)
        Me.GroupBox2.Controls.Add(Me.b3)
        Me.GroupBox2.Controls.Add(Me.b6)
        Me.GroupBox2.Controls.Add(Me.b9)
        Me.GroupBox2.Controls.Add(Me.bnose)
        Me.GroupBox2.Controls.Add(Me.b2)
        Me.GroupBox2.Controls.Add(Me.b5)
        Me.GroupBox2.Controls.Add(Me.b8)
        Me.GroupBox2.Controls.Add(Me.b0)
        Me.GroupBox2.Controls.Add(Me.b1)
        Me.GroupBox2.Controls.Add(Me.b4)
        Me.GroupBox2.Controls.Add(Me.b7)
        Me.GroupBox2.Controls.Add(Me.caculos)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(13, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 219)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'bigual
        '
        Me.bigual.Location = New System.Drawing.Point(160, 138)
        Me.bigual.Name = "bigual"
        Me.bigual.Size = New System.Drawing.Size(71, 64)
        Me.bigual.TabIndex = 18
        Me.bigual.Text = "="
        Me.bigual.UseVisualStyleBackColor = True
        '
        'bclear
        '
        Me.bclear.Location = New System.Drawing.Point(160, 68)
        Me.bclear.Name = "bclear"
        Me.bclear.Size = New System.Drawing.Size(71, 64)
        Me.bclear.TabIndex = 17
        Me.bclear.Text = "Clear"
        Me.bclear.UseVisualStyleBackColor = True
        '
        'bsuma
        '
        Me.bsuma.Location = New System.Drawing.Point(124, 173)
        Me.bsuma.Name = "bsuma"
        Me.bsuma.Size = New System.Drawing.Size(30, 29)
        Me.bsuma.TabIndex = 16
        Me.bsuma.Text = "+"
        Me.bsuma.UseVisualStyleBackColor = True
        '
        'bresta
        '
        Me.bresta.Location = New System.Drawing.Point(124, 138)
        Me.bresta.Name = "bresta"
        Me.bresta.Size = New System.Drawing.Size(30, 29)
        Me.bresta.TabIndex = 15
        Me.bresta.Text = "-"
        Me.bresta.UseVisualStyleBackColor = True
        '
        'bmultiplicacion
        '
        Me.bmultiplicacion.Location = New System.Drawing.Point(124, 103)
        Me.bmultiplicacion.Name = "bmultiplicacion"
        Me.bmultiplicacion.Size = New System.Drawing.Size(30, 29)
        Me.bmultiplicacion.TabIndex = 14
        Me.bmultiplicacion.Text = "*"
        Me.bmultiplicacion.UseVisualStyleBackColor = True
        '
        'bdivision
        '
        Me.bdivision.Location = New System.Drawing.Point(124, 68)
        Me.bdivision.Name = "bdivision"
        Me.bdivision.Size = New System.Drawing.Size(30, 29)
        Me.bdivision.TabIndex = 13
        Me.bdivision.Text = "/"
        Me.bdivision.UseVisualStyleBackColor = True
        '
        'bpunto
        '
        Me.bpunto.Location = New System.Drawing.Point(88, 173)
        Me.bpunto.Name = "bpunto"
        Me.bpunto.Size = New System.Drawing.Size(30, 29)
        Me.bpunto.TabIndex = 12
        Me.bpunto.Text = "."
        Me.bpunto.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(88, 138)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(30, 29)
        Me.b3.TabIndex = 11
        Me.b3.Text = "3"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b6
        '
        Me.b6.Location = New System.Drawing.Point(88, 103)
        Me.b6.Name = "b6"
        Me.b6.Size = New System.Drawing.Size(30, 29)
        Me.b6.TabIndex = 10
        Me.b6.Text = "6"
        Me.b6.UseVisualStyleBackColor = True
        '
        'b9
        '
        Me.b9.Location = New System.Drawing.Point(88, 68)
        Me.b9.Name = "b9"
        Me.b9.Size = New System.Drawing.Size(30, 29)
        Me.b9.TabIndex = 9
        Me.b9.Text = "9"
        Me.b9.UseVisualStyleBackColor = True
        '
        'bnose
        '
        Me.bnose.Location = New System.Drawing.Point(52, 173)
        Me.bnose.Name = "bnose"
        Me.bnose.Size = New System.Drawing.Size(30, 29)
        Me.bnose.TabIndex = 8
        Me.bnose.Text = "+/-"
        Me.bnose.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(52, 138)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(30, 29)
        Me.b2.TabIndex = 7
        Me.b2.Text = "2"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b5
        '
        Me.b5.Location = New System.Drawing.Point(52, 103)
        Me.b5.Name = "b5"
        Me.b5.Size = New System.Drawing.Size(30, 29)
        Me.b5.TabIndex = 6
        Me.b5.Text = "5"
        Me.b5.UseVisualStyleBackColor = True
        '
        'b8
        '
        Me.b8.Location = New System.Drawing.Point(52, 68)
        Me.b8.Name = "b8"
        Me.b8.Size = New System.Drawing.Size(30, 29)
        Me.b8.TabIndex = 5
        Me.b8.Text = "8"
        Me.b8.UseVisualStyleBackColor = True
        '
        'b0
        '
        Me.b0.Location = New System.Drawing.Point(16, 173)
        Me.b0.Name = "b0"
        Me.b0.Size = New System.Drawing.Size(30, 29)
        Me.b0.TabIndex = 4
        Me.b0.Text = "0"
        Me.b0.UseVisualStyleBackColor = True
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(16, 138)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(30, 29)
        Me.b1.TabIndex = 3
        Me.b1.Text = "1"
        Me.b1.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.Location = New System.Drawing.Point(16, 103)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(30, 29)
        Me.b4.TabIndex = 2
        Me.b4.Text = "4"
        Me.b4.UseVisualStyleBackColor = True
        '
        'b7
        '
        Me.b7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b7.Location = New System.Drawing.Point(16, 68)
        Me.b7.Name = "b7"
        Me.b7.Size = New System.Drawing.Size(30, 29)
        Me.b7.TabIndex = 1
        Me.b7.Text = "7"
        Me.b7.UseVisualStyleBackColor = True
        '
        'caculos
        '
        Me.caculos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.caculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.caculos.Location = New System.Drawing.Point(6, 20)
        Me.caculos.Name = "caculos"
        Me.caculos.Size = New System.Drawing.Size(225, 20)
        Me.caculos.TabIndex = 0
        Me.caculos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 289)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents caculos As TextBox
    Friend WithEvents bhistory As Button
    Friend WithEvents ListBox As ListBox
    Friend WithEvents bigual As Button
    Friend WithEvents bclear As Button
    Friend WithEvents bsuma As Button
    Friend WithEvents bresta As Button
    Friend WithEvents bmultiplicacion As Button
    Friend WithEvents bdivision As Button
    Friend WithEvents bpunto As Button
    Friend WithEvents b3 As Button
    Friend WithEvents b6 As Button
    Friend WithEvents b9 As Button
    Friend WithEvents bnose As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b5 As Button
    Friend WithEvents b8 As Button
    Friend WithEvents b0 As Button
    Friend WithEvents b1 As Button
    Friend WithEvents b4 As Button
    Friend WithEvents b7 As Button
End Class
