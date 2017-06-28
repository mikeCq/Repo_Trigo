<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConexionBDD
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxUsuario = New System.Windows.Forms.TextBox()
        Me.TxConexion = New System.Windows.Forms.TextBox()
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.BtGuardar = New System.Windows.Forms.Button()
        Me.BtNuevo = New System.Windows.Forms.Button()
        Me.CbBaseDatos = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Usuario:"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Conexion:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre de base de datos:"
        '
        'TxUsuario
        '
        Me.TxUsuario.Location = New System.Drawing.Point(216, 196)
        Me.TxUsuario.Name = "TxUsuario"
        Me.TxUsuario.Size = New System.Drawing.Size(142, 20)
        Me.TxUsuario.TabIndex = 1
        Me.TxUsuario.Visible = False
        '
        'TxConexion
        '
        Me.TxConexion.Location = New System.Drawing.Point(216, 222)
        Me.TxConexion.Name = "TxConexion"
        Me.TxConexion.Size = New System.Drawing.Size(142, 20)
        Me.TxConexion.TabIndex = 1
        Me.TxConexion.Visible = False
        '
        'BtSalir
        '
        Me.BtSalir.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.BtSalir.Location = New System.Drawing.Point(204, 12)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(71, 40)
        Me.BtSalir.TabIndex = 9
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'BtGuardar
        '
        Me.BtGuardar.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.BtGuardar.Location = New System.Drawing.Point(107, 12)
        Me.BtGuardar.Name = "BtGuardar"
        Me.BtGuardar.Size = New System.Drawing.Size(71, 40)
        Me.BtGuardar.TabIndex = 8
        Me.BtGuardar.Text = "Guardar"
        Me.BtGuardar.UseVisualStyleBackColor = True
        '
        'BtNuevo
        '
        Me.BtNuevo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.BtNuevo.Location = New System.Drawing.Point(12, 12)
        Me.BtNuevo.Name = "BtNuevo"
        Me.BtNuevo.Size = New System.Drawing.Size(71, 40)
        Me.BtNuevo.TabIndex = 7
        Me.BtNuevo.Text = "Nuevo"
        Me.BtNuevo.UseVisualStyleBackColor = True
        '
        'CbBaseDatos
        '
        Me.CbBaseDatos.FormattingEnabled = True
        Me.CbBaseDatos.Location = New System.Drawing.Point(216, 124)
        Me.CbBaseDatos.Name = "CbBaseDatos"
        Me.CbBaseDatos.Size = New System.Drawing.Size(142, 21)
        Me.CbBaseDatos.TabIndex = 11
        '
        'ConexionBDD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 249)
        Me.Controls.Add(Me.CbBaseDatos)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.BtGuardar)
        Me.Controls.Add(Me.BtNuevo)
        Me.Controls.Add(Me.TxConexion)
        Me.Controls.Add(Me.TxUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConexionBDD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Conexion a base de datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxUsuario As TextBox
    Friend WithEvents TxConexion As TextBox
    Friend WithEvents BtSalir As Button
    Friend WithEvents BtGuardar As Button
    Friend WithEvents BtNuevo As Button
    Friend WithEvents CbBaseDatos As ComboBox
End Class
