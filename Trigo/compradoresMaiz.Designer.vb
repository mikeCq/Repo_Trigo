<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class compradoresMaiz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(compradoresMaiz))
        Me.ImpContrato = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpCompraNormal = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DgSeleccionProductores = New System.Windows.Forms.DataGridView()
        Me.seleccionarLotes = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxToneladas = New System.Windows.Forms.TextBox()
        Me.TxPrecioTonelada = New System.Windows.Forms.TextBox()
        Me.CbNombreComprador = New System.Windows.Forms.ComboBox()
        Me.DtTemporada = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxFolioComprador = New System.Windows.Forms.TextBox()
        Me.DtFechaliquidacion = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxFolioContrato = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgProductores = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgContatoComprador = New System.Windows.Forms.DataGridView()
        Me.TpCompraLibre = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DgContratosLibre = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TpCompraNormal.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DgSeleccionProductores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgProductores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgContatoComprador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpCompraLibre.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DgContratosLibre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImpContrato
        '
        Me.ImpContrato.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpContrato.Location = New System.Drawing.Point(406, 2)
        Me.ImpContrato.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ImpContrato.Name = "ImpContrato"
        Me.ImpContrato.Size = New System.Drawing.Size(95, 74)
        Me.ImpContrato.TabIndex = 16
        Me.ImpContrato.Text = "Imprimir"
        Me.ImpContrato.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ImpContrato.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(709, 2)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(95, 74)
        Me.BtnSalir.TabIndex = 15
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(103, 2)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(95, 74)
        Me.BtnGuardar.TabIndex = 10
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestaurar.Location = New System.Drawing.Point(608, 2)
        Me.BtnRestaurar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(95, 74)
        Me.BtnRestaurar.TabIndex = 14
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(305, 2)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(95, 74)
        Me.BtnBuscar.TabIndex = 12
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(204, 2)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(95, 74)
        Me.BtnModificar.TabIndex = 11
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(507, 2)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(95, 74)
        Me.BtnEliminar.TabIndex = 13
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(2, 2)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(95, 74)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TpCompraNormal)
        Me.TabControl1.Controls.Add(Me.TpCompraLibre)
        Me.TabControl1.Location = New System.Drawing.Point(2, 83)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1413, 520)
        Me.TabControl1.TabIndex = 0
        '
        'TpCompraNormal
        '
        Me.TpCompraNormal.Controls.Add(Me.GroupBox7)
        Me.TpCompraNormal.Controls.Add(Me.GroupBox2)
        Me.TpCompraNormal.Controls.Add(Me.GroupBox3)
        Me.TpCompraNormal.Controls.Add(Me.GroupBox1)
        Me.TpCompraNormal.Location = New System.Drawing.Point(4, 22)
        Me.TpCompraNormal.Name = "TpCompraNormal"
        Me.TpCompraNormal.Padding = New System.Windows.Forms.Padding(3)
        Me.TpCompraNormal.Size = New System.Drawing.Size(1405, 494)
        Me.TpCompraNormal.TabIndex = 0
        Me.TpCompraNormal.Text = "Compra Normal"
        Me.TpCompraNormal.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DgSeleccionProductores)
        Me.GroupBox7.Controls.Add(Me.seleccionarLotes)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 227)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(726, 260)
        Me.GroupBox7.TabIndex = 29
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Seleccion de Productores"
        '
        'DgSeleccionProductores
        '
        Me.DgSeleccionProductores.AllowUserToAddRows = False
        Me.DgSeleccionProductores.AllowUserToDeleteRows = False
        Me.DgSeleccionProductores.AllowUserToResizeColumns = False
        Me.DgSeleccionProductores.AllowUserToResizeRows = False
        Me.DgSeleccionProductores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgSeleccionProductores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgSeleccionProductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgSeleccionProductores.Location = New System.Drawing.Point(8, 19)
        Me.DgSeleccionProductores.Name = "DgSeleccionProductores"
        Me.DgSeleccionProductores.RowHeadersVisible = False
        Me.DgSeleccionProductores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgSeleccionProductores.Size = New System.Drawing.Size(680, 228)
        Me.DgSeleccionProductores.TabIndex = 0
        '
        'seleccionarLotes
        '
        Me.seleccionarLotes.BackColor = System.Drawing.Color.White
        Me.seleccionarLotes.BackgroundImage = CType(resources.GetObject("seleccionarLotes.BackgroundImage"), System.Drawing.Image)
        Me.seleccionarLotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.seleccionarLotes.Location = New System.Drawing.Point(692, 19)
        Me.seleccionarLotes.Name = "seleccionarLotes"
        Me.seleccionarLotes.Size = New System.Drawing.Size(27, 26)
        Me.seleccionarLotes.TabIndex = 30
        Me.seleccionarLotes.Tag = "Agrega los productores."
        Me.seleccionarLotes.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxToneladas)
        Me.GroupBox2.Controls.Add(Me.TxPrecioTonelada)
        Me.GroupBox2.Controls.Add(Me.CbNombreComprador)
        Me.GroupBox2.Controls.Add(Me.DtTemporada)
        Me.GroupBox2.Controls.Add(Me.DtFechaAlta)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxFolioComprador)
        Me.GroupBox2.Controls.Add(Me.DtFechaliquidacion)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxFolioContrato)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(726, 215)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Contrato"
        '
        'TxToneladas
        '
        Me.TxToneladas.Location = New System.Drawing.Point(164, 84)
        Me.TxToneladas.MaxLength = 10
        Me.TxToneladas.Name = "TxToneladas"
        Me.TxToneladas.Size = New System.Drawing.Size(96, 20)
        Me.TxToneladas.TabIndex = 1
        '
        'TxPrecioTonelada
        '
        Me.TxPrecioTonelada.Location = New System.Drawing.Point(410, 84)
        Me.TxPrecioTonelada.MaxLength = 10
        Me.TxPrecioTonelada.Name = "TxPrecioTonelada"
        Me.TxPrecioTonelada.Size = New System.Drawing.Size(96, 20)
        Me.TxPrecioTonelada.TabIndex = 2
        '
        'CbNombreComprador
        '
        Me.CbNombreComprador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CbNombreComprador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbNombreComprador.DropDownHeight = 100
        Me.CbNombreComprador.FormattingEnabled = True
        Me.CbNombreComprador.IntegralHeight = False
        Me.CbNombreComprador.ItemHeight = 13
        Me.CbNombreComprador.Location = New System.Drawing.Point(164, 53)
        Me.CbNombreComprador.Name = "CbNombreComprador"
        Me.CbNombreComprador.Size = New System.Drawing.Size(555, 21)
        Me.CbNombreComprador.TabIndex = 0
        '
        'DtTemporada
        '
        Me.DtTemporada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtTemporada.Location = New System.Drawing.Point(164, 113)
        Me.DtTemporada.Name = "DtTemporada"
        Me.DtTemporada.Size = New System.Drawing.Size(73, 20)
        Me.DtTemporada.TabIndex = 3
        '
        'DtFechaAlta
        '
        Me.DtFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaAlta.Location = New System.Drawing.Point(616, 20)
        Me.DtFechaAlta.Name = "DtFechaAlta"
        Me.DtFechaAlta.Size = New System.Drawing.Size(103, 20)
        Me.DtFechaAlta.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(516, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de Alta:"
        '
        'TxFolioComprador
        '
        Me.TxFolioComprador.Enabled = False
        Me.TxFolioComprador.Location = New System.Drawing.Point(410, 19)
        Me.TxFolioComprador.Name = "TxFolioComprador"
        Me.TxFolioComprador.Size = New System.Drawing.Size(100, 20)
        Me.TxFolioComprador.TabIndex = 6
        '
        'DtFechaliquidacion
        '
        Me.DtFechaliquidacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaliquidacion.Location = New System.Drawing.Point(410, 113)
        Me.DtFechaliquidacion.Name = "DtFechaliquidacion"
        Me.DtFechaliquidacion.Size = New System.Drawing.Size(116, 20)
        Me.DtFechaliquidacion.TabIndex = 4
        Me.DtFechaliquidacion.Value = New Date(2016, 6, 2, 17, 13, 42, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(5, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre del Comprador:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(266, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Fecha de Liquidación:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(270, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Folio del Comprador:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(75, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Temporada:"
        '
        'TxFolioContrato
        '
        Me.TxFolioContrato.Enabled = False
        Me.TxFolioContrato.Location = New System.Drawing.Point(164, 19)
        Me.TxFolioContrato.Name = "TxFolioContrato"
        Me.TxFolioContrato.Size = New System.Drawing.Size(100, 20)
        Me.TxFolioContrato.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(271, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Precio X Tonelada $:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(42, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio del Contrato:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(79, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Toneladas :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgProductores)
        Me.GroupBox3.Location = New System.Drawing.Point(738, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(656, 260)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Productores Seleccionados"
        '
        'DgProductores
        '
        Me.DgProductores.AllowUserToAddRows = False
        Me.DgProductores.AllowUserToDeleteRows = False
        Me.DgProductores.AllowUserToResizeColumns = False
        Me.DgProductores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgProductores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgProductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgProductores.Location = New System.Drawing.Point(7, 19)
        Me.DgProductores.Name = "DgProductores"
        Me.DgProductores.ReadOnly = True
        Me.DgProductores.RowHeadersVisible = False
        Me.DgProductores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgProductores.Size = New System.Drawing.Size(643, 228)
        Me.DgProductores.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgContatoComprador)
        Me.GroupBox1.Location = New System.Drawing.Point(738, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 215)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Contratos"
        '
        'DgContatoComprador
        '
        Me.DgContatoComprador.AllowUserToAddRows = False
        Me.DgContatoComprador.AllowUserToDeleteRows = False
        Me.DgContatoComprador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgContatoComprador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgContatoComprador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgContatoComprador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgContatoComprador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgContatoComprador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgContatoComprador.Location = New System.Drawing.Point(6, 21)
        Me.DgContatoComprador.MultiSelect = False
        Me.DgContatoComprador.Name = "DgContatoComprador"
        Me.DgContatoComprador.ReadOnly = True
        Me.DgContatoComprador.RowHeadersVisible = False
        Me.DgContatoComprador.RowHeadersWidth = 40
        Me.DgContatoComprador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgContatoComprador.Size = New System.Drawing.Size(644, 188)
        Me.DgContatoComprador.TabIndex = 0
        '
        'TpCompraLibre
        '
        Me.TpCompraLibre.Controls.Add(Me.GroupBox8)
        Me.TpCompraLibre.Controls.Add(Me.GroupBox5)
        Me.TpCompraLibre.Controls.Add(Me.GroupBox4)
        Me.TpCompraLibre.Controls.Add(Me.GroupBox6)
        Me.TpCompraLibre.Location = New System.Drawing.Point(4, 22)
        Me.TpCompraLibre.Name = "TpCompraLibre"
        Me.TpCompraLibre.Padding = New System.Windows.Forms.Padding(3)
        Me.TpCompraLibre.Size = New System.Drawing.Size(1405, 494)
        Me.TpCompraLibre.TabIndex = 1
        Me.TpCompraLibre.Text = "Compra Libre"
        Me.TpCompraLibre.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button2)
        Me.GroupBox8.Controls.Add(Me.DataGridView2)
        Me.GroupBox8.Location = New System.Drawing.Point(561, 267)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(656, 307)
        Me.GroupBox8.TabIndex = 30
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Seleccion de lotes"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 26)
        Me.Button2.TabIndex = 30
        Me.Button2.Tag = "Agrega los lotes."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridView2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DataGridView2.Location = New System.Drawing.Point(39, 21)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 40
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(611, 279)
        Me.DataGridView2.TabIndex = 28
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.ComboBox3)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.TextBox8)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.TextBox9)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 267)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(549, 150)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(420, 109)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(123, 20)
        Me.DateTimePicker3.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(279, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Fecha de Liquidación:"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(138, 109)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(132, 21)
        Me.ComboBox3.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(57, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Temporada:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Precio X Tonelada $:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(138, 81)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 17
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(472, 56)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(71, 20)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(138, 53)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(78, 20)
        Me.TextBox8.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(62, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Toneladas:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(309, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Superficie Comprometida:"
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(138, 25)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(405, 20)
        Me.TextBox9.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Lotes a Sembrar:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox2)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.TextBox10)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.TextBox11)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(549, 255)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Contrato"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DropDownHeight = 100
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.IntegralHeight = False
        Me.ComboBox2.ItemHeight = 13
        Me.ComboBox2.Location = New System.Drawing.Point(150, 83)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(386, 21)
        Me.ComboBox2.TabIndex = 11
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(433, 27)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker4.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(335, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Fecha de Alta:"
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(150, 55)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Nombre del Productor:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(23, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Folio del Productor:"
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Location = New System.Drawing.Point(150, 27)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(30, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Folio del Contrato:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DgContratosLibre)
        Me.GroupBox6.Location = New System.Drawing.Point(561, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(656, 255)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Listado de Contratos"
        '
        'DgContratosLibre
        '
        Me.DgContratosLibre.AllowUserToAddRows = False
        Me.DgContratosLibre.AllowUserToDeleteRows = False
        Me.DgContratosLibre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgContratosLibre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgContratosLibre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgContratosLibre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgContratosLibre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgContratosLibre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgContratosLibre.Location = New System.Drawing.Point(6, 21)
        Me.DgContratosLibre.MultiSelect = False
        Me.DgContratosLibre.Name = "DgContratosLibre"
        Me.DgContratosLibre.ReadOnly = True
        Me.DgContratosLibre.RowHeadersVisible = False
        Me.DgContratosLibre.RowHeadersWidth = 40
        Me.DgContratosLibre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgContratosLibre.Size = New System.Drawing.Size(644, 228)
        Me.DgContratosLibre.TabIndex = 27
        '
        'compradoresMaiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1421, 609)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ImpContrato)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnRestaurar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Name = "compradoresMaiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Compradores"
        Me.TabControl1.ResumeLayout(False)
        Me.TpCompraNormal.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DgSeleccionProductores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgProductores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgContatoComprador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpCompraLibre.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DgContratosLibre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImpContrato As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpCompraNormal As TabPage
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents seleccionarLotes As Button
    Friend WithEvents TxPrecioTonelada As TextBox
    Friend WithEvents DtTemporada As DateTimePicker
    Friend WithEvents DtFechaliquidacion As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CbNombreComprador As ComboBox
    Friend WithEvents DtFechaAlta As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TxFolioComprador As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxFolioContrato As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgContatoComprador As DataGridView
    Friend WithEvents TpCompraLibre As TabPage
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DgContratosLibre As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxToneladas As TextBox
    Friend WithEvents DgProductores As DataGridView
    Friend WithEvents DgSeleccionProductores As DataGridView
End Class
