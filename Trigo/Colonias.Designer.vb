<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Colonias
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
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GBColonias = New System.Windows.Forms.GroupBox()
        Me.NuMaxTon = New System.Windows.Forms.NumericUpDown()
        Me.TxCodigoPostal = New System.Windows.Forms.MaskedTextBox()
        Me.TxDescripcion = New System.Windows.Forms.TextBox()
        Me.TxNombre = New System.Windows.Forms.TextBox()
        Me.TxIdColonia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgColonias = New System.Windows.Forms.DataGridView()
        Me.GBColonias.SuspendLayout()
        CType(Me.NuMaxTon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgColonias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 2)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 68)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(93, 2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 68)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(174, 2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 68)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(255, 2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 68)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(336, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 68)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Location = New System.Drawing.Point(417, 2)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(75, 68)
        Me.BtnRestaurar.TabIndex = 5
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(498, 2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 68)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'GBColonias
        '
        Me.GBColonias.Controls.Add(Me.NuMaxTon)
        Me.GBColonias.Controls.Add(Me.TxCodigoPostal)
        Me.GBColonias.Controls.Add(Me.TxDescripcion)
        Me.GBColonias.Controls.Add(Me.TxNombre)
        Me.GBColonias.Controls.Add(Me.TxIdColonia)
        Me.GBColonias.Controls.Add(Me.Label5)
        Me.GBColonias.Controls.Add(Me.Label4)
        Me.GBColonias.Controls.Add(Me.Label3)
        Me.GBColonias.Controls.Add(Me.Label2)
        Me.GBColonias.Controls.Add(Me.Label1)
        Me.GBColonias.Location = New System.Drawing.Point(12, 82)
        Me.GBColonias.Name = "GBColonias"
        Me.GBColonias.Size = New System.Drawing.Size(561, 148)
        Me.GBColonias.TabIndex = 7
        Me.GBColonias.TabStop = False
        Me.GBColonias.Text = "Datos de la Colonia"
        '
        'NuMaxTon
        '
        Me.NuMaxTon.DecimalPlaces = 2
        Me.NuMaxTon.Location = New System.Drawing.Point(228, 113)
        Me.NuMaxTon.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.NuMaxTon.Name = "NuMaxTon"
        Me.NuMaxTon.Size = New System.Drawing.Size(104, 22)
        Me.NuMaxTon.TabIndex = 4
        '
        'TxCodigoPostal
        '
        Me.TxCodigoPostal.Location = New System.Drawing.Point(486, 56)
        Me.TxCodigoPostal.Mask = "00000"
        Me.TxCodigoPostal.Name = "TxCodigoPostal"
        Me.TxCodigoPostal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxCodigoPostal.Size = New System.Drawing.Size(68, 22)
        Me.TxCodigoPostal.TabIndex = 1
        '
        'TxDescripcion
        '
        Me.TxDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxDescripcion.Location = New System.Drawing.Point(148, 84)
        Me.TxDescripcion.Name = "TxDescripcion"
        Me.TxDescripcion.Size = New System.Drawing.Size(406, 22)
        Me.TxDescripcion.TabIndex = 2
        '
        'TxNombre
        '
        Me.TxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNombre.Location = New System.Drawing.Point(148, 56)
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.Size = New System.Drawing.Size(233, 22)
        Me.TxNombre.TabIndex = 0
        '
        'TxIdColonia
        '
        Me.TxIdColonia.Enabled = False
        Me.TxIdColonia.Location = New System.Drawing.Point(148, 26)
        Me.TxIdColonia.Name = "TxIdColonia"
        Me.TxIdColonia.Size = New System.Drawing.Size(100, 22)
        Me.TxIdColonia.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Maximo de Toneladas por Hectárea:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(387, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Codigo Postal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de la Colonia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id. Colonia:"
        '
        'DgColonias
        '
        Me.DgColonias.AllowUserToAddRows = False
        Me.DgColonias.AllowUserToDeleteRows = False
        Me.DgColonias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgColonias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgColonias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgColonias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgColonias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgColonias.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgColonias.Location = New System.Drawing.Point(12, 236)
        Me.DgColonias.MultiSelect = False
        Me.DgColonias.Name = "DgColonias"
        Me.DgColonias.ReadOnly = True
        Me.DgColonias.RowHeadersVisible = False
        Me.DgColonias.RowHeadersWidth = 40
        Me.DgColonias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgColonias.Size = New System.Drawing.Size(561, 154)
        Me.DgColonias.TabIndex = 17
        '
        'Colonias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 402)
        Me.Controls.Add(Me.DgColonias)
        Me.Controls.Add(Me.GBColonias)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnRestaurar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Colonias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Colonias"
        Me.GBColonias.ResumeLayout(False)
        Me.GBColonias.PerformLayout()
        CType(Me.NuMaxTon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgColonias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents GBColonias As GroupBox
    Friend WithEvents TxDescripcion As TextBox
    Friend WithEvents TxNombre As TextBox
    Friend WithEvents TxIdColonia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NuMaxTon As NumericUpDown
    Friend WithEvents TxCodigoPostal As MaskedTextBox
    Friend WithEvents DgColonias As DataGridView
End Class
