<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuscarControlTrigo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.BtSeleccion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxNomBus = New System.Windows.Forms.TextBox()
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.DgBoletaIngresada = New System.Windows.Forms.DataGridView()
        CType(Me.DgBoletaIngresada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(512, 350)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(103, 44)
        Me.BtCancelar.TabIndex = 22
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'BtSeleccion
        '
        Me.BtSeleccion.Location = New System.Drawing.Point(403, 350)
        Me.BtSeleccion.Name = "BtSeleccion"
        Me.BtSeleccion.Size = New System.Drawing.Size(103, 44)
        Me.BtSeleccion.TabIndex = 21
        Me.BtSeleccion.Text = "Seleccionar"
        Me.BtSeleccion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre :"
        '
        'TxNomBus
        '
        Me.TxNomBus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNomBus.Location = New System.Drawing.Point(75, 33)
        Me.TxNomBus.Name = "TxNomBus"
        Me.TxNomBus.Size = New System.Drawing.Size(372, 20)
        Me.TxNomBus.TabIndex = 19
        '
        'BtBuscar
        '
        Me.BtBuscar.Location = New System.Drawing.Point(475, 33)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(97, 38)
        Me.BtBuscar.TabIndex = 20
        Me.BtBuscar.Text = "Buscar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'DgBoletaIngresada
        '
        Me.DgBoletaIngresada.AllowUserToAddRows = False
        Me.DgBoletaIngresada.AllowUserToDeleteRows = False
        Me.DgBoletaIngresada.AllowUserToOrderColumns = True
        Me.DgBoletaIngresada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgBoletaIngresada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgBoletaIngresada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgBoletaIngresada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgBoletaIngresada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBoletaIngresada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgBoletaIngresada.Location = New System.Drawing.Point(12, 77)
        Me.DgBoletaIngresada.MultiSelect = False
        Me.DgBoletaIngresada.Name = "DgBoletaIngresada"
        Me.DgBoletaIngresada.ReadOnly = True
        Me.DgBoletaIngresada.RowHeadersVisible = False
        Me.DgBoletaIngresada.RowHeadersWidth = 40
        Me.DgBoletaIngresada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBoletaIngresada.Size = New System.Drawing.Size(601, 267)
        Me.DgBoletaIngresada.TabIndex = 23
        '
        'BuscarControlTrigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 405)
        Me.Controls.Add(Me.DgBoletaIngresada)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.BtSeleccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxNomBus)
        Me.Controls.Add(Me.BtBuscar)
        Me.Name = "BuscarControlTrigo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar"
        CType(Me.DgBoletaIngresada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtCancelar As Button
    Friend WithEvents BtSeleccion As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxNomBus As TextBox
    Friend WithEvents BtBuscar As Button
    Friend WithEvents DgBoletaIngresada As DataGridView
End Class
