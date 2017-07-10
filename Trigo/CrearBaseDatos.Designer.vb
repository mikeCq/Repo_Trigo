<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearBaseDatos
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
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(12, 9)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(44, 13)
        Me.LbNombre.TabIndex = 0
        Me.LbNombre.Text = "Nombre"
        '
        'TbNombre
        '
        Me.TbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNombre.Enabled = False
        Me.TbNombre.Location = New System.Drawing.Point(63, 9)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(209, 20)
        Me.TbNombre.TabIndex = 1
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(116, 35)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 2
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(197, 35)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtCancelar.TabIndex = 3
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'CrearBaseDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 71)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.TbNombre)
        Me.Controls.Add(Me.LbNombre)
        Me.Name = "CrearBaseDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear nueva base de datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbNombre As Label
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents BtAceptar As Button
    Friend WithEvents BtCancelar As Button
End Class
