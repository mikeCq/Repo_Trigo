<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarUsuario
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
        Me.DgBuscarUsuario = New System.Windows.Forms.DataGridView()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.BtSeleccion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxUsuario = New System.Windows.Forms.TextBox()
        Me.BtBuscar = New System.Windows.Forms.Button()
        CType(Me.DgBuscarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgBuscarUsuario
        '
        Me.DgBuscarUsuario.AllowUserToAddRows = False
        Me.DgBuscarUsuario.AllowUserToDeleteRows = False
        Me.DgBuscarUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgBuscarUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgBuscarUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgBuscarUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgBuscarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBuscarUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgBuscarUsuario.Location = New System.Drawing.Point(12, 69)
        Me.DgBuscarUsuario.MultiSelect = False
        Me.DgBuscarUsuario.Name = "DgBuscarUsuario"
        Me.DgBuscarUsuario.ReadOnly = True
        Me.DgBuscarUsuario.RowHeadersVisible = False
        Me.DgBuscarUsuario.RowHeadersWidth = 40
        Me.DgBuscarUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBuscarUsuario.Size = New System.Drawing.Size(499, 250)
        Me.DgBuscarUsuario.TabIndex = 16
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(416, 326)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(94, 37)
        Me.BtCancelar.TabIndex = 17
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'BtSeleccion
        '
        Me.BtSeleccion.Location = New System.Drawing.Point(297, 326)
        Me.BtSeleccion.Name = "BtSeleccion"
        Me.BtSeleccion.Size = New System.Drawing.Size(94, 37)
        Me.BtSeleccion.TabIndex = 17
        Me.BtSeleccion.Text = "Seleccionar"
        Me.BtSeleccion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Usuario: "
        '
        'TxUsuario
        '
        Me.TxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxUsuario.Location = New System.Drawing.Point(68, 21)
        Me.TxUsuario.MaxLength = 15
        Me.TxUsuario.Name = "TxUsuario"
        Me.TxUsuario.Size = New System.Drawing.Size(159, 20)
        Me.TxUsuario.TabIndex = 19
        '
        'BtBuscar
        '
        Me.BtBuscar.Location = New System.Drawing.Point(416, 12)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(94, 39)
        Me.BtBuscar.TabIndex = 20
        Me.BtBuscar.Text = "Buscar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'BuscarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 375)
        Me.Controls.Add(Me.BtBuscar)
        Me.Controls.Add(Me.TxUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtSeleccion)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.DgBuscarUsuario)
        Me.Name = "BuscarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Usuario"
        CType(Me.DgBuscarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgBuscarUsuario As DataGridView
    Friend WithEvents BtCancelar As Button
    Friend WithEvents BtSeleccion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxUsuario As TextBox
    Friend WithEvents BtBuscar As Button
End Class
