<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarEmpresa
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
        Me.DgBuscar = New System.Windows.Forms.DataGridView()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.BtSeleccion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxNomBus = New System.Windows.Forms.TextBox()
        Me.BtBuscar = New System.Windows.Forms.Button()
        CType(Me.DgBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgBuscar
        '
        Me.DgBuscar.AllowUserToAddRows = False
        Me.DgBuscar.AllowUserToDeleteRows = False
        Me.DgBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgBuscar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgBuscar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgBuscar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgBuscar.Location = New System.Drawing.Point(12, 61)
        Me.DgBuscar.MultiSelect = False
        Me.DgBuscar.Name = "DgBuscar"
        Me.DgBuscar.ReadOnly = True
        Me.DgBuscar.RowHeadersVisible = False
        Me.DgBuscar.RowHeadersWidth = 40
        Me.DgBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBuscar.Size = New System.Drawing.Size(554, 219)
        Me.DgBuscar.TabIndex = 32
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(463, 286)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(103, 44)
        Me.BtCancelar.TabIndex = 31
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'BtSeleccion
        '
        Me.BtSeleccion.Location = New System.Drawing.Point(354, 286)
        Me.BtSeleccion.Name = "BtSeleccion"
        Me.BtSeleccion.Size = New System.Drawing.Size(103, 44)
        Me.BtSeleccion.TabIndex = 30
        Me.BtSeleccion.Text = "Seleccionar"
        Me.BtSeleccion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nombre :"
        '
        'TxNomBus
        '
        Me.TxNomBus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNomBus.Location = New System.Drawing.Point(69, 17)
        Me.TxNomBus.Name = "TxNomBus"
        Me.TxNomBus.Size = New System.Drawing.Size(372, 20)
        Me.TxNomBus.TabIndex = 28
        '
        'BtBuscar
        '
        Me.BtBuscar.Location = New System.Drawing.Point(469, 17)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(97, 38)
        Me.BtBuscar.TabIndex = 29
        Me.BtBuscar.Text = "Buscar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'BuscarEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 346)
        Me.Controls.Add(Me.DgBuscar)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.BtSeleccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxNomBus)
        Me.Controls.Add(Me.BtBuscar)
        Me.Name = "BuscarEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BuscarEmpresa"
        CType(Me.DgBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgBuscar As DataGridView
    Friend WithEvents BtCancelar As Button
    Friend WithEvents BtSeleccion As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxNomBus As TextBox
    Friend WithEvents BtBuscar As Button
End Class
