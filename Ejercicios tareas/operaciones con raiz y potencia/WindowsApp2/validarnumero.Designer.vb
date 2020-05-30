<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class validarnumero
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
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(301, 154)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 0
        Me.btncalcular.Text = "calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(291, 128)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtnumero.TabIndex = 1
        '
        'validarnumero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.btncalcular)
        Me.Name = "validarnumero"
        Me.Text = "validarnumero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncalcular As Button
    Friend WithEvents txtnumero As TextBox
End Class
