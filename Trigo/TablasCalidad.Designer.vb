<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TablasCalidad
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
        Me.BtNuevo = New System.Windows.Forms.Button()
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.BtGuardar = New System.Windows.Forms.Button()
        Me.BtActualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxDeduccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxPorcentaje = New System.Windows.Forms.TextBox()
        Me.TcTablaCalidad = New System.Windows.Forms.TabControl()
        Me.TpHumedad = New System.Windows.Forms.TabPage()
        Me.DgHumedad = New System.Windows.Forms.DataGridView()
        Me.TpImpurezas = New System.Windows.Forms.TabPage()
        Me.DgImpurezas = New System.Windows.Forms.DataGridView()
        Me.TpGranoDan = New System.Windows.Forms.TabPage()
        Me.DgGranoDan = New System.Windows.Forms.DataGridView()
        Me.TpGranoQue = New System.Windows.Forms.TabPage()
        Me.DgGranoQue = New System.Windows.Forms.DataGridView()
        Me.TpPesoEsp = New System.Windows.Forms.TabPage()
        Me.DgPesoEsp = New System.Windows.Forms.DataGridView()
        Me.TxMaximo = New System.Windows.Forms.TextBox()
        Me.TxMinimo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxTablaSeleccionada = New System.Windows.Forms.TextBox()
        Me.BtEliminar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TxRangoIni1 = New System.Windows.Forms.TextBox()
        Me.TxRangoIni2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxAumenta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxRangoFin1 = New System.Windows.Forms.TextBox()
        Me.TxRangoFin2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TcTablaCalidad.SuspendLayout()
        Me.TpHumedad.SuspendLayout()
        CType(Me.DgHumedad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpImpurezas.SuspendLayout()
        CType(Me.DgImpurezas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpGranoDan.SuspendLayout()
        CType(Me.DgGranoDan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpGranoQue.SuspendLayout()
        CType(Me.DgGranoQue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpPesoEsp.SuspendLayout()
        CType(Me.DgPesoEsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtNuevo
        '
        Me.BtNuevo.Location = New System.Drawing.Point(12, 12)
        Me.BtNuevo.Name = "BtNuevo"
        Me.BtNuevo.Size = New System.Drawing.Size(63, 59)
        Me.BtNuevo.TabIndex = 3
        Me.BtNuevo.Text = "Nuevo"
        Me.BtNuevo.UseVisualStyleBackColor = True
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(288, 12)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(63, 59)
        Me.BtSalir.TabIndex = 7
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'BtGuardar
        '
        Me.BtGuardar.Location = New System.Drawing.Point(81, 12)
        Me.BtGuardar.Name = "BtGuardar"
        Me.BtGuardar.Size = New System.Drawing.Size(63, 59)
        Me.BtGuardar.TabIndex = 4
        Me.BtGuardar.Text = "Guardar"
        Me.BtGuardar.UseVisualStyleBackColor = True
        '
        'BtActualizar
        '
        Me.BtActualizar.Location = New System.Drawing.Point(150, 12)
        Me.BtActualizar.Name = "BtActualizar"
        Me.BtActualizar.Size = New System.Drawing.Size(63, 59)
        Me.BtActualizar.TabIndex = 5
        Me.BtActualizar.Text = "Actualizar"
        Me.BtActualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(576, 584)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "% Inicial :"
        '
        'TxDeduccion
        '
        Me.TxDeduccion.Location = New System.Drawing.Point(603, 191)
        Me.TxDeduccion.Name = "TxDeduccion"
        Me.TxDeduccion.Size = New System.Drawing.Size(51, 20)
        Me.TxDeduccion.TabIndex = 1
        Me.TxDeduccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(532, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Deduccion :"
        '
        'TxPorcentaje
        '
        Me.TxPorcentaje.Location = New System.Drawing.Point(633, 581)
        Me.TxPorcentaje.Name = "TxPorcentaje"
        Me.TxPorcentaje.Size = New System.Drawing.Size(61, 20)
        Me.TxPorcentaje.TabIndex = 0
        Me.TxPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TcTablaCalidad
        '
        Me.TcTablaCalidad.Controls.Add(Me.TpHumedad)
        Me.TcTablaCalidad.Controls.Add(Me.TpImpurezas)
        Me.TcTablaCalidad.Controls.Add(Me.TpGranoDan)
        Me.TcTablaCalidad.Controls.Add(Me.TpGranoQue)
        Me.TcTablaCalidad.Controls.Add(Me.TpPesoEsp)
        Me.TcTablaCalidad.Location = New System.Drawing.Point(12, 207)
        Me.TcTablaCalidad.Name = "TcTablaCalidad"
        Me.TcTablaCalidad.SelectedIndex = 0
        Me.TcTablaCalidad.Size = New System.Drawing.Size(450, 513)
        Me.TcTablaCalidad.TabIndex = 2
        '
        'TpHumedad
        '
        Me.TpHumedad.Controls.Add(Me.DgHumedad)
        Me.TpHumedad.Location = New System.Drawing.Point(4, 22)
        Me.TpHumedad.Name = "TpHumedad"
        Me.TpHumedad.Padding = New System.Windows.Forms.Padding(3)
        Me.TpHumedad.Size = New System.Drawing.Size(442, 487)
        Me.TpHumedad.TabIndex = 0
        Me.TpHumedad.Text = "Humedad"
        Me.TpHumedad.UseVisualStyleBackColor = True
        '
        'DgHumedad
        '
        Me.DgHumedad.AllowUserToAddRows = False
        Me.DgHumedad.AllowUserToDeleteRows = False
        Me.DgHumedad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgHumedad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgHumedad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgHumedad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgHumedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgHumedad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgHumedad.Location = New System.Drawing.Point(0, 0)
        Me.DgHumedad.MultiSelect = False
        Me.DgHumedad.Name = "DgHumedad"
        Me.DgHumedad.RowHeadersVisible = False
        Me.DgHumedad.RowHeadersWidth = 40
        Me.DgHumedad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgHumedad.Size = New System.Drawing.Size(441, 487)
        Me.DgHumedad.TabIndex = 0
        '
        'TpImpurezas
        '
        Me.TpImpurezas.Controls.Add(Me.DgImpurezas)
        Me.TpImpurezas.Location = New System.Drawing.Point(4, 22)
        Me.TpImpurezas.Name = "TpImpurezas"
        Me.TpImpurezas.Padding = New System.Windows.Forms.Padding(3)
        Me.TpImpurezas.Size = New System.Drawing.Size(442, 487)
        Me.TpImpurezas.TabIndex = 1
        Me.TpImpurezas.Text = "Impurezas"
        Me.TpImpurezas.UseVisualStyleBackColor = True
        '
        'DgImpurezas
        '
        Me.DgImpurezas.AllowUserToAddRows = False
        Me.DgImpurezas.AllowUserToDeleteRows = False
        Me.DgImpurezas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgImpurezas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgImpurezas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgImpurezas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgImpurezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgImpurezas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgImpurezas.Location = New System.Drawing.Point(-1, 0)
        Me.DgImpurezas.MultiSelect = False
        Me.DgImpurezas.Name = "DgImpurezas"
        Me.DgImpurezas.RowHeadersVisible = False
        Me.DgImpurezas.RowHeadersWidth = 40
        Me.DgImpurezas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgImpurezas.Size = New System.Drawing.Size(441, 487)
        Me.DgImpurezas.TabIndex = 18
        '
        'TpGranoDan
        '
        Me.TpGranoDan.Controls.Add(Me.DgGranoDan)
        Me.TpGranoDan.Location = New System.Drawing.Point(4, 22)
        Me.TpGranoDan.Name = "TpGranoDan"
        Me.TpGranoDan.Padding = New System.Windows.Forms.Padding(3)
        Me.TpGranoDan.Size = New System.Drawing.Size(442, 487)
        Me.TpGranoDan.TabIndex = 2
        Me.TpGranoDan.Text = "Grano Dañado"
        Me.TpGranoDan.UseVisualStyleBackColor = True
        '
        'DgGranoDan
        '
        Me.DgGranoDan.AllowUserToAddRows = False
        Me.DgGranoDan.AllowUserToDeleteRows = False
        Me.DgGranoDan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgGranoDan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgGranoDan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgGranoDan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgGranoDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgGranoDan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgGranoDan.Location = New System.Drawing.Point(-1, 0)
        Me.DgGranoDan.MultiSelect = False
        Me.DgGranoDan.Name = "DgGranoDan"
        Me.DgGranoDan.RowHeadersVisible = False
        Me.DgGranoDan.RowHeadersWidth = 40
        Me.DgGranoDan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgGranoDan.Size = New System.Drawing.Size(441, 487)
        Me.DgGranoDan.TabIndex = 19
        '
        'TpGranoQue
        '
        Me.TpGranoQue.Controls.Add(Me.DgGranoQue)
        Me.TpGranoQue.Location = New System.Drawing.Point(4, 22)
        Me.TpGranoQue.Name = "TpGranoQue"
        Me.TpGranoQue.Padding = New System.Windows.Forms.Padding(3)
        Me.TpGranoQue.Size = New System.Drawing.Size(442, 487)
        Me.TpGranoQue.TabIndex = 3
        Me.TpGranoQue.Text = "Grano Quebrado"
        Me.TpGranoQue.UseVisualStyleBackColor = True
        '
        'DgGranoQue
        '
        Me.DgGranoQue.AllowUserToAddRows = False
        Me.DgGranoQue.AllowUserToDeleteRows = False
        Me.DgGranoQue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgGranoQue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgGranoQue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgGranoQue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgGranoQue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgGranoQue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgGranoQue.Location = New System.Drawing.Point(0, 0)
        Me.DgGranoQue.MultiSelect = False
        Me.DgGranoQue.Name = "DgGranoQue"
        Me.DgGranoQue.RowHeadersVisible = False
        Me.DgGranoQue.RowHeadersWidth = 40
        Me.DgGranoQue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgGranoQue.Size = New System.Drawing.Size(441, 487)
        Me.DgGranoQue.TabIndex = 20
        '
        'TpPesoEsp
        '
        Me.TpPesoEsp.Controls.Add(Me.DgPesoEsp)
        Me.TpPesoEsp.Location = New System.Drawing.Point(4, 22)
        Me.TpPesoEsp.Margin = New System.Windows.Forms.Padding(2)
        Me.TpPesoEsp.Name = "TpPesoEsp"
        Me.TpPesoEsp.Padding = New System.Windows.Forms.Padding(2)
        Me.TpPesoEsp.Size = New System.Drawing.Size(442, 487)
        Me.TpPesoEsp.TabIndex = 4
        Me.TpPesoEsp.Text = "Peso Especifico"
        Me.TpPesoEsp.UseVisualStyleBackColor = True
        '
        'DgPesoEsp
        '
        Me.DgPesoEsp.AllowUserToAddRows = False
        Me.DgPesoEsp.AllowUserToDeleteRows = False
        Me.DgPesoEsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgPesoEsp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgPesoEsp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgPesoEsp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgPesoEsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgPesoEsp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgPesoEsp.Location = New System.Drawing.Point(0, 0)
        Me.DgPesoEsp.MultiSelect = False
        Me.DgPesoEsp.Name = "DgPesoEsp"
        Me.DgPesoEsp.RowHeadersVisible = False
        Me.DgPesoEsp.RowHeadersWidth = 40
        Me.DgPesoEsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgPesoEsp.Size = New System.Drawing.Size(441, 487)
        Me.DgPesoEsp.TabIndex = 1
        '
        'TxMaximo
        '
        Me.TxMaximo.Location = New System.Drawing.Point(813, 317)
        Me.TxMaximo.MaxLength = 8
        Me.TxMaximo.Name = "TxMaximo"
        Me.TxMaximo.Size = New System.Drawing.Size(61, 20)
        Me.TxMaximo.TabIndex = 25
        Me.TxMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxMinimo
        '
        Me.TxMinimo.Location = New System.Drawing.Point(813, 291)
        Me.TxMinimo.MaxLength = 8
        Me.TxMinimo.Name = "TxMinimo"
        Me.TxMinimo.Size = New System.Drawing.Size(61, 20)
        Me.TxMinimo.TabIndex = 26
        Me.TxMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(673, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "% Maximo con deducción :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(676, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "% Minimo con deducción :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tabla :"
        '
        'TxTablaSeleccionada
        '
        Me.TxTablaSeleccionada.Location = New System.Drawing.Point(83, 87)
        Me.TxTablaSeleccionada.Name = "TxTablaSeleccionada"
        Me.TxTablaSeleccionada.ReadOnly = True
        Me.TxTablaSeleccionada.Size = New System.Drawing.Size(86, 20)
        Me.TxTablaSeleccionada.TabIndex = 12
        '
        'BtEliminar
        '
        Me.BtEliminar.Location = New System.Drawing.Point(219, 12)
        Me.BtEliminar.Name = "BtEliminar"
        Me.BtEliminar.Size = New System.Drawing.Size(63, 59)
        Me.BtEliminar.TabIndex = 6
        Me.BtEliminar.Text = "Eliminar"
        Me.BtEliminar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(700, 584)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "% Final :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(752, 581)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(61, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxRangoIni1
        '
        Me.TxRangoIni1.Location = New System.Drawing.Point(603, 89)
        Me.TxRangoIni1.Name = "TxRangoIni1"
        Me.TxRangoIni1.Size = New System.Drawing.Size(51, 20)
        Me.TxRangoIni1.TabIndex = 0
        Me.TxRangoIni1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxRangoIni2
        '
        Me.TxRangoIni2.Location = New System.Drawing.Point(679, 89)
        Me.TxRangoIni2.Name = "TxRangoIni2"
        Me.TxRangoIni2.Size = New System.Drawing.Size(51, 20)
        Me.TxRangoIni2.TabIndex = 1
        Me.TxRangoIni2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(522, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Rango Inicial :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(542, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Aumenta :"
        '
        'TxAumenta
        '
        Me.TxAumenta.Location = New System.Drawing.Point(603, 165)
        Me.TxAumenta.Name = "TxAumenta"
        Me.TxAumenta.Size = New System.Drawing.Size(51, 20)
        Me.TxAumenta.TabIndex = 0
        Me.TxAumenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(660, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "a"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(527, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Rango Final :"
        '
        'TxRangoFin1
        '
        Me.TxRangoFin1.Location = New System.Drawing.Point(603, 124)
        Me.TxRangoFin1.Name = "TxRangoFin1"
        Me.TxRangoFin1.Size = New System.Drawing.Size(51, 20)
        Me.TxRangoFin1.TabIndex = 0
        Me.TxRangoFin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxRangoFin2
        '
        Me.TxRangoFin2.Location = New System.Drawing.Point(679, 124)
        Me.TxRangoFin2.Name = "TxRangoFin2"
        Me.TxRangoFin2.Size = New System.Drawing.Size(51, 20)
        Me.TxRangoFin2.TabIndex = 1
        Me.TxRangoFin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(660, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "a"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(885, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TablasCalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 728)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxMaximo)
        Me.Controls.Add(Me.BtNuevo)
        Me.Controls.Add(Me.TxMinimo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtEliminar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.BtGuardar)
        Me.Controls.Add(Me.BtActualizar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxRangoFin2)
        Me.Controls.Add(Me.TxRangoIni2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TxDeduccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxTablaSeleccionada)
        Me.Controls.Add(Me.TxRangoFin1)
        Me.Controls.Add(Me.TxAumenta)
        Me.Controls.Add(Me.TxRangoIni1)
        Me.Controls.Add(Me.TxPorcentaje)
        Me.Controls.Add(Me.TcTablaCalidad)
        Me.Name = "TablasCalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tablas De Calidad"
        Me.TcTablaCalidad.ResumeLayout(False)
        Me.TpHumedad.ResumeLayout(False)
        CType(Me.DgHumedad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpImpurezas.ResumeLayout(False)
        CType(Me.DgImpurezas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpGranoDan.ResumeLayout(False)
        CType(Me.DgGranoDan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpGranoQue.ResumeLayout(False)
        CType(Me.DgGranoQue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpPesoEsp.ResumeLayout(False)
        CType(Me.DgPesoEsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtNuevo As Button
    Friend WithEvents BtSalir As Button
    Friend WithEvents BtGuardar As Button
    Friend WithEvents BtActualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxDeduccion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxPorcentaje As TextBox
    Friend WithEvents TcTablaCalidad As TabControl
    Friend WithEvents TpHumedad As TabPage
    Friend WithEvents DgHumedad As DataGridView
    Friend WithEvents TpImpurezas As TabPage
    Friend WithEvents DgImpurezas As DataGridView
    Friend WithEvents TpGranoDan As TabPage
    Friend WithEvents DgGranoDan As DataGridView
    Friend WithEvents TpGranoQue As TabPage
    Friend WithEvents DgGranoQue As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TxTablaSeleccionada As TextBox
    Friend WithEvents BtEliminar As Button
    Friend WithEvents TpPesoEsp As TabPage
    Friend WithEvents DgPesoEsp As DataGridView
    Friend WithEvents TxMaximo As TextBox
    Friend WithEvents TxMinimo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TxRangoIni1 As TextBox
    Friend WithEvents TxRangoIni2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxAumenta As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxRangoFin1 As TextBox
    Friend WithEvents TxRangoFin2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
End Class
