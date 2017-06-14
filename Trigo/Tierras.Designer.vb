<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tierras
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
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.TxVolumen = New System.Windows.Forms.TextBox()
        Me.NuSupCultivable = New System.Windows.Forms.NumericUpDown()
        Me.NuSupTotal = New System.Windows.Forms.NumericUpDown()
        Me.DtTitulo = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxTitulo = New System.Windows.Forms.TextBox()
        Me.TxRegimen = New System.Windows.Forms.TextBox()
        Me.TxCurp = New System.Windows.Forms.TextBox()
        Me.TxRfc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GbEscrituracion = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DTRpp = New System.Windows.Forms.DateTimePicker()
        Me.TxNumeroRPP = New System.Windows.Forms.TextBox()
        Me.TxFolioRPP = New System.Windows.Forms.TextBox()
        Me.TxLibroRPP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxWMinutos = New System.Windows.Forms.TextBox()
        Me.TxWHoras = New System.Windows.Forms.TextBox()
        Me.TxWGrados = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxNGrados = New System.Windows.Forms.TextBox()
        Me.TxNHoras = New System.Windows.Forms.TextBox()
        Me.TxNMinutos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBPropietario = New System.Windows.Forms.ComboBox()
        Me.CBColonia = New System.Windows.Forms.ComboBox()
        Me.TxFolio = New System.Windows.Forms.TextBox()
        Me.TxNoLote = New System.Windows.Forms.TextBox()
        Me.TxIdLote = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbDatos.SuspendLayout()
        CType(Me.NuSupCultivable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuSupTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbEscrituracion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.TxVolumen)
        Me.GbDatos.Controls.Add(Me.NuSupCultivable)
        Me.GbDatos.Controls.Add(Me.NuSupTotal)
        Me.GbDatos.Controls.Add(Me.DtTitulo)
        Me.GbDatos.Controls.Add(Me.Label18)
        Me.GbDatos.Controls.Add(Me.Label17)
        Me.GbDatos.Controls.Add(Me.Label16)
        Me.GbDatos.Controls.Add(Me.TxTitulo)
        Me.GbDatos.Controls.Add(Me.TxRegimen)
        Me.GbDatos.Controls.Add(Me.TxCurp)
        Me.GbDatos.Controls.Add(Me.TxRfc)
        Me.GbDatos.Controls.Add(Me.Label15)
        Me.GbDatos.Controls.Add(Me.Label14)
        Me.GbDatos.Controls.Add(Me.GbEscrituracion)
        Me.GbDatos.Controls.Add(Me.GroupBox2)
        Me.GbDatos.Controls.Add(Me.CBPropietario)
        Me.GbDatos.Controls.Add(Me.CBColonia)
        Me.GbDatos.Controls.Add(Me.TxFolio)
        Me.GbDatos.Controls.Add(Me.TxNoLote)
        Me.GbDatos.Controls.Add(Me.TxIdLote)
        Me.GbDatos.Controls.Add(Me.Label19)
        Me.GbDatos.Controls.Add(Me.Label7)
        Me.GbDatos.Controls.Add(Me.Label6)
        Me.GbDatos.Controls.Add(Me.Label5)
        Me.GbDatos.Controls.Add(Me.Label4)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Location = New System.Drawing.Point(12, 90)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(723, 417)
        Me.GbDatos.TabIndex = 7
        Me.GbDatos.TabStop = False
        Me.GbDatos.Text = "Datos del Lote"
        '
        'TxVolumen
        '
        Me.TxVolumen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxVolumen.Location = New System.Drawing.Point(127, 203)
        Me.TxVolumen.Name = "TxVolumen"
        Me.TxVolumen.Size = New System.Drawing.Size(100, 22)
        Me.TxVolumen.TabIndex = 31
        Me.TxVolumen.Visible = False
        '
        'NuSupCultivable
        '
        Me.NuSupCultivable.Location = New System.Drawing.Point(577, 172)
        Me.NuSupCultivable.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NuSupCultivable.Name = "NuSupCultivable"
        Me.NuSupCultivable.Size = New System.Drawing.Size(82, 22)
        Me.NuSupCultivable.TabIndex = 5
        Me.NuSupCultivable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuSupTotal
        '
        Me.NuSupTotal.Location = New System.Drawing.Point(353, 172)
        Me.NuSupTotal.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NuSupTotal.Name = "NuSupTotal"
        Me.NuSupTotal.Size = New System.Drawing.Size(82, 22)
        Me.NuSupTotal.TabIndex = 4
        Me.NuSupTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DtTitulo
        '
        Me.DtTitulo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTitulo.Location = New System.Drawing.Point(610, 387)
        Me.DtTitulo.Name = "DtTitulo"
        Me.DtTitulo.Size = New System.Drawing.Size(102, 22)
        Me.DtTitulo.TabIndex = 10
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(500, 392)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 16)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Fecha del Título:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(221, 392)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 16)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Titulo del Agua:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 392)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 16)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Régimen Hídrico:"
        '
        'TxTitulo
        '
        Me.TxTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxTitulo.Location = New System.Drawing.Point(324, 389)
        Me.TxTitulo.Name = "TxTitulo"
        Me.TxTitulo.Size = New System.Drawing.Size(162, 22)
        Me.TxTitulo.TabIndex = 9
        '
        'TxRegimen
        '
        Me.TxRegimen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxRegimen.Location = New System.Drawing.Point(119, 389)
        Me.TxRegimen.Name = "TxRegimen"
        Me.TxRegimen.Size = New System.Drawing.Size(91, 22)
        Me.TxRegimen.TabIndex = 8
        '
        'TxCurp
        '
        Me.TxCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCurp.Enabled = False
        Me.TxCurp.Location = New System.Drawing.Point(404, 143)
        Me.TxCurp.Name = "TxCurp"
        Me.TxCurp.Size = New System.Drawing.Size(308, 22)
        Me.TxCurp.TabIndex = 24
        '
        'TxRfc
        '
        Me.TxRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxRfc.Enabled = False
        Me.TxRfc.Location = New System.Drawing.Point(81, 143)
        Me.TxRfc.Name = "TxRfc"
        Me.TxRfc.Size = New System.Drawing.Size(201, 22)
        Me.TxRfc.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(351, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 16)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "CURP:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(37, 146)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 16)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "RFC:"
        '
        'GbEscrituracion
        '
        Me.GbEscrituracion.Controls.Add(Me.Label13)
        Me.GbEscrituracion.Controls.Add(Me.DTRpp)
        Me.GbEscrituracion.Controls.Add(Me.TxNumeroRPP)
        Me.GbEscrituracion.Controls.Add(Me.TxFolioRPP)
        Me.GbEscrituracion.Controls.Add(Me.TxLibroRPP)
        Me.GbEscrituracion.Controls.Add(Me.Label12)
        Me.GbEscrituracion.Controls.Add(Me.Label11)
        Me.GbEscrituracion.Controls.Add(Me.Label10)
        Me.GbEscrituracion.Location = New System.Drawing.Point(0, 309)
        Me.GbEscrituracion.Name = "GbEscrituracion"
        Me.GbEscrituracion.Size = New System.Drawing.Size(718, 72)
        Me.GbEscrituracion.TabIndex = 7
        Me.GbEscrituracion.TabStop = False
        Me.GbEscrituracion.Text = "Escrituración del Registro Público de la Propiedad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(556, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Fecha:"
        '
        'DTRpp
        '
        Me.DTRpp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTRpp.Location = New System.Drawing.Point(610, 29)
        Me.DTRpp.Name = "DTRpp"
        Me.DTRpp.Size = New System.Drawing.Size(102, 22)
        Me.DTRpp.TabIndex = 3
        '
        'TxNumeroRPP
        '
        Me.TxNumeroRPP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNumeroRPP.Location = New System.Drawing.Point(101, 29)
        Me.TxNumeroRPP.Name = "TxNumeroRPP"
        Me.TxNumeroRPP.Size = New System.Drawing.Size(69, 22)
        Me.TxNumeroRPP.TabIndex = 0
        '
        'TxFolioRPP
        '
        Me.TxFolioRPP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFolioRPP.Location = New System.Drawing.Point(256, 29)
        Me.TxFolioRPP.Name = "TxFolioRPP"
        Me.TxFolioRPP.Size = New System.Drawing.Size(69, 22)
        Me.TxFolioRPP.TabIndex = 1
        '
        'TxLibroRPP
        '
        Me.TxLibroRPP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxLibroRPP.Location = New System.Drawing.Point(443, 29)
        Me.TxLibroRPP.Name = "TxLibroRPP"
        Me.TxLibroRPP.Size = New System.Drawing.Size(69, 22)
        Me.TxLibroRPP.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Del Número:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(187, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Del Folio:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(374, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Del Libro:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxWMinutos)
        Me.GroupBox2.Controls.Add(Me.TxWHoras)
        Me.GroupBox2.Controls.Add(Me.TxWGrados)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxNGrados)
        Me.GroupBox2.Controls.Add(Me.TxNHoras)
        Me.GroupBox2.Controls.Add(Me.TxNMinutos)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(718, 72)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coordenadas del Lote"
        '
        'TxWMinutos
        '
        Me.TxWMinutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxWMinutos.Location = New System.Drawing.Point(634, 29)
        Me.TxWMinutos.Name = "TxWMinutos"
        Me.TxWMinutos.Size = New System.Drawing.Size(76, 22)
        Me.TxWMinutos.TabIndex = 5
        '
        'TxWHoras
        '
        Me.TxWHoras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxWHoras.Location = New System.Drawing.Point(552, 29)
        Me.TxWHoras.Name = "TxWHoras"
        Me.TxWHoras.Size = New System.Drawing.Size(76, 22)
        Me.TxWHoras.TabIndex = 4
        '
        'TxWGrados
        '
        Me.TxWGrados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxWGrados.Location = New System.Drawing.Point(470, 29)
        Me.TxWGrados.Name = "TxWGrados"
        Me.TxWGrados.Size = New System.Drawing.Size(76, 22)
        Me.TxWGrados.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Latitud N"
        '
        'TxNGrados
        '
        Me.TxNGrados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNGrados.Location = New System.Drawing.Point(80, 29)
        Me.TxNGrados.Name = "TxNGrados"
        Me.TxNGrados.Size = New System.Drawing.Size(75, 22)
        Me.TxNGrados.TabIndex = 0
        '
        'TxNHoras
        '
        Me.TxNHoras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNHoras.Location = New System.Drawing.Point(161, 29)
        Me.TxNHoras.Name = "TxNHoras"
        Me.TxNHoras.Size = New System.Drawing.Size(75, 22)
        Me.TxNHoras.TabIndex = 1
        '
        'TxNMinutos
        '
        Me.TxNMinutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNMinutos.Location = New System.Drawing.Point(242, 29)
        Me.TxNMinutos.Name = "TxNMinutos"
        Me.TxNMinutos.Size = New System.Drawing.Size(75, 22)
        Me.TxNMinutos.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(390, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Longitud W"
        '
        'CBPropietario
        '
        Me.CBPropietario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBPropietario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBPropietario.DropDownHeight = 100
        Me.CBPropietario.FormattingEnabled = True
        Me.CBPropietario.IntegralHeight = False
        Me.CBPropietario.Location = New System.Drawing.Point(81, 113)
        Me.CBPropietario.Name = "CBPropietario"
        Me.CBPropietario.Size = New System.Drawing.Size(631, 24)
        Me.CBPropietario.TabIndex = 2
        '
        'CBColonia
        '
        Me.CBColonia.DropDownHeight = 100
        Me.CBColonia.FormattingEnabled = True
        Me.CBColonia.IntegralHeight = False
        Me.CBColonia.Location = New System.Drawing.Point(81, 81)
        Me.CBColonia.Name = "CBColonia"
        Me.CBColonia.Size = New System.Drawing.Size(201, 24)
        Me.CBColonia.TabIndex = 1
        '
        'TxFolio
        '
        Me.TxFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFolio.Location = New System.Drawing.Point(127, 171)
        Me.TxFolio.Name = "TxFolio"
        Me.TxFolio.Size = New System.Drawing.Size(100, 22)
        Me.TxFolio.TabIndex = 3
        '
        'TxNoLote
        '
        Me.TxNoLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNoLote.Location = New System.Drawing.Point(81, 53)
        Me.TxNoLote.Name = "TxNoLote"
        Me.TxNoLote.Size = New System.Drawing.Size(100, 22)
        Me.TxNoLote.TabIndex = 0
        '
        'TxIdLote
        '
        Me.TxIdLote.Enabled = False
        Me.TxIdLote.Location = New System.Drawing.Point(81, 25)
        Me.TxIdLote.Name = "TxIdLote"
        Me.TxIdLote.Size = New System.Drawing.Size(100, 22)
        Me.TxIdLote.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(59, 206)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 16)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Volumen:"
        Me.Label19.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(441, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Superficie Cultivable:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(247, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Superficie Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Folio de ASERCA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Propietario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Colonia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Lote:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Tierra:"
        '
        'Tierras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 519)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnRestaurar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Tierras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "                  "
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.NuSupCultivable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuSupTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbEscrituracion.ResumeLayout(False)
        Me.GbEscrituracion.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents DtTitulo As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxTitulo As TextBox
    Friend WithEvents TxRegimen As TextBox
    Friend WithEvents TxCurp As TextBox
    Friend WithEvents TxRfc As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GbEscrituracion As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DTRpp As DateTimePicker
    Friend WithEvents TxNumeroRPP As TextBox
    Friend WithEvents TxFolioRPP As TextBox
    Friend WithEvents TxLibroRPP As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxWMinutos As TextBox
    Friend WithEvents TxWHoras As TextBox
    Friend WithEvents TxWGrados As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxNGrados As TextBox
    Friend WithEvents TxNHoras As TextBox
    Friend WithEvents TxNMinutos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CBPropietario As ComboBox
    Friend WithEvents CBColonia As ComboBox
    Friend WithEvents TxFolio As TextBox
    Friend WithEvents TxNoLote As TextBox
    Friend WithEvents TxIdLote As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NuSupTotal As NumericUpDown
    Friend WithEvents NuSupCultivable As NumericUpDown
    Friend WithEvents TxVolumen As TextBox
    Friend WithEvents Label19 As Label
End Class
