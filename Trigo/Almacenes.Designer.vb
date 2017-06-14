<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacenes
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
        Me.GBCentroAcopio = New System.Windows.Forms.GroupBox()
        Me.NuCapacidadCentro = New System.Windows.Forms.NumericUpDown()
        Me.TxNombreCentro = New System.Windows.Forms.TextBox()
        Me.TxIdAcopio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxCodigoPostal = New System.Windows.Forms.MaskedTextBox()
        Me.CbColonia = New System.Windows.Forms.ComboBox()
        Me.CbCiudad = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxNumeroCentro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxEstado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxCalleCentro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DgAcopio = New System.Windows.Forms.DataGridView()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TcAlmacen = New System.Windows.Forms.TabControl()
        Me.TbDatosAcopio = New System.Windows.Forms.TabPage()
        Me.TbDatoAlmacen = New System.Windows.Forms.TabPage()
        Me.DgAlmacen = New System.Windows.Forms.DataGridView()
        Me.GbAlmacen = New System.Windows.Forms.GroupBox()
        Me.NuCapacidadAlmacen = New System.Windows.Forms.NumericUpDown()
        Me.TxIdAlmacen = New System.Windows.Forms.TextBox()
        Me.CbTipoAlmacen = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxNomAlm = New System.Windows.Forms.TextBox()
        Me.BtActualiza = New System.Windows.Forms.Button()
        Me.TxFolioAserca = New System.Windows.Forms.TextBox()
        Me.GBCentroAcopio.SuspendLayout()
        CType(Me.NuCapacidadCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgAcopio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TcAlmacen.SuspendLayout()
        Me.TbDatosAcopio.SuspendLayout()
        Me.TbDatoAlmacen.SuspendLayout()
        CType(Me.DgAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbAlmacen.SuspendLayout()
        CType(Me.NuCapacidadAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBCentroAcopio
        '
        Me.GBCentroAcopio.Controls.Add(Me.TxFolioAserca)
        Me.GBCentroAcopio.Controls.Add(Me.NuCapacidadCentro)
        Me.GBCentroAcopio.Controls.Add(Me.TxNombreCentro)
        Me.GBCentroAcopio.Controls.Add(Me.TxIdAcopio)
        Me.GBCentroAcopio.Controls.Add(Me.Label5)
        Me.GBCentroAcopio.Controls.Add(Me.Label6)
        Me.GBCentroAcopio.Controls.Add(Me.Label8)
        Me.GBCentroAcopio.Controls.Add(Me.Label1)
        Me.GBCentroAcopio.Controls.Add(Me.GroupBox1)
        Me.GBCentroAcopio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBCentroAcopio.Location = New System.Drawing.Point(6, 7)
        Me.GBCentroAcopio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GBCentroAcopio.Name = "GBCentroAcopio"
        Me.GBCentroAcopio.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GBCentroAcopio.Size = New System.Drawing.Size(743, 203)
        Me.GBCentroAcopio.TabIndex = 7
        Me.GBCentroAcopio.TabStop = False
        '
        'NuCapacidadCentro
        '
        Me.NuCapacidadCentro.Enabled = False
        Me.NuCapacidadCentro.Location = New System.Drawing.Point(632, 22)
        Me.NuCapacidadCentro.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.NuCapacidadCentro.Name = "NuCapacidadCentro"
        Me.NuCapacidadCentro.Size = New System.Drawing.Size(100, 22)
        Me.NuCapacidadCentro.TabIndex = 5
        '
        'TxNombreCentro
        '
        Me.TxNombreCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNombreCentro.Location = New System.Drawing.Point(135, 96)
        Me.TxNombreCentro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxNombreCentro.MaxLength = 50
        Me.TxNombreCentro.Name = "TxNombreCentro"
        Me.TxNombreCentro.Size = New System.Drawing.Size(279, 22)
        Me.TxNombreCentro.TabIndex = 2
        '
        'TxIdAcopio
        '
        Me.TxIdAcopio.Enabled = False
        Me.TxIdAcopio.Location = New System.Drawing.Point(135, 27)
        Me.TxIdAcopio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxIdAcopio.Name = "TxIdAcopio"
        Me.TxIdAcopio.Size = New System.Drawing.Size(116, 22)
        Me.TxIdAcopio.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(503, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Capacidad Maxima:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Folio ASERCA:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 32)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nombre " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Centro de Acopio :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Centro de Acopio:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxCodigoPostal)
        Me.GroupBox1.Controls.Add(Me.CbColonia)
        Me.GroupBox1.Controls.Add(Me.CbCiudad)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxNumeroCentro)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxEstado)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TxCalleCentro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 82)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Domicilio"
        '
        'TxCodigoPostal
        '
        Me.TxCodigoPostal.Location = New System.Drawing.Point(107, 51)
        Me.TxCodigoPostal.Mask = "00000"
        Me.TxCodigoPostal.Name = "TxCodigoPostal"
        Me.TxCodigoPostal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxCodigoPostal.Size = New System.Drawing.Size(61, 22)
        Me.TxCodigoPostal.TabIndex = 3
        '
        'CbColonia
        '
        Me.CbColonia.FormattingEnabled = True
        Me.CbColonia.Location = New System.Drawing.Point(593, 22)
        Me.CbColonia.MaxLength = 50
        Me.CbColonia.Name = "CbColonia"
        Me.CbColonia.Size = New System.Drawing.Size(139, 24)
        Me.CbColonia.TabIndex = 2
        '
        'CbCiudad
        '
        Me.CbCiudad.FormattingEnabled = True
        Me.CbCiudad.Location = New System.Drawing.Point(236, 51)
        Me.CbCiudad.MaxLength = 50
        Me.CbCiudad.Name = "CbCiudad"
        Me.CbCiudad.Size = New System.Drawing.Size(150, 24)
        Me.CbCiudad.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(528, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Colonia :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(174, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Ciudad :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Codigo Postal :"
        '
        'TxNumeroCentro
        '
        Me.TxNumeroCentro.Location = New System.Drawing.Point(459, 22)
        Me.TxNumeroCentro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxNumeroCentro.MaxLength = 5
        Me.TxNumeroCentro.Name = "TxNumeroCentro"
        Me.TxNumeroCentro.Size = New System.Drawing.Size(63, 22)
        Me.TxNumeroCentro.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(392, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Numero :"
        '
        'TxEstado
        '
        Me.TxEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEstado.Location = New System.Drawing.Point(459, 52)
        Me.TxEstado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxEstado.Name = "TxEstado"
        Me.TxEstado.Size = New System.Drawing.Size(134, 22)
        Me.TxEstado.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(396, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Estado :"
        '
        'TxCalleCentro
        '
        Me.TxCalleCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCalleCentro.Location = New System.Drawing.Point(107, 22)
        Me.TxCalleCentro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxCalleCentro.MaxLength = 50
        Me.TxCalleCentro.Name = "TxCalleCentro"
        Me.TxCalleCentro.Size = New System.Drawing.Size(279, 22)
        Me.TxCalleCentro.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Calle :"
        '
        'DgAcopio
        '
        Me.DgAcopio.AllowUserToAddRows = False
        Me.DgAcopio.AllowUserToDeleteRows = False
        Me.DgAcopio.AllowUserToOrderColumns = True
        Me.DgAcopio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgAcopio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgAcopio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgAcopio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgAcopio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAcopio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgAcopio.Location = New System.Drawing.Point(6, 217)
        Me.DgAcopio.MultiSelect = False
        Me.DgAcopio.Name = "DgAcopio"
        Me.DgAcopio.ReadOnly = True
        Me.DgAcopio.RowHeadersVisible = False
        Me.DgAcopio.RowHeadersWidth = 40
        Me.DgAcopio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgAcopio.Size = New System.Drawing.Size(743, 130)
        Me.DgAcopio.TabIndex = 9
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(565, 1)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(87, 81)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(193, 1)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(87, 81)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestaurar.Location = New System.Drawing.Point(472, 1)
        Me.BtnRestaurar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(87, 81)
        Me.BtnRestaurar.TabIndex = 5
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(100, 1)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(87, 81)
        Me.BtnBuscar.TabIndex = 1
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(286, 1)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(87, 81)
        Me.BtnModificar.TabIndex = 3
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(379, 1)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(87, 82)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(7, 1)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(87, 81)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TcAlmacen
        '
        Me.TcAlmacen.Controls.Add(Me.TbDatosAcopio)
        Me.TcAlmacen.Controls.Add(Me.TbDatoAlmacen)
        Me.TcAlmacen.Location = New System.Drawing.Point(7, 119)
        Me.TcAlmacen.Name = "TcAlmacen"
        Me.TcAlmacen.SelectedIndex = 0
        Me.TcAlmacen.Size = New System.Drawing.Size(767, 385)
        Me.TcAlmacen.TabIndex = 10
        '
        'TbDatosAcopio
        '
        Me.TbDatosAcopio.Controls.Add(Me.GBCentroAcopio)
        Me.TbDatosAcopio.Controls.Add(Me.DgAcopio)
        Me.TbDatosAcopio.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDatosAcopio.Location = New System.Drawing.Point(4, 25)
        Me.TbDatosAcopio.Name = "TbDatosAcopio"
        Me.TbDatosAcopio.Padding = New System.Windows.Forms.Padding(3)
        Me.TbDatosAcopio.Size = New System.Drawing.Size(759, 356)
        Me.TbDatosAcopio.TabIndex = 0
        Me.TbDatosAcopio.Text = "Datos de Centro de Acopio"
        Me.TbDatosAcopio.UseVisualStyleBackColor = True
        '
        'TbDatoAlmacen
        '
        Me.TbDatoAlmacen.Controls.Add(Me.DgAlmacen)
        Me.TbDatoAlmacen.Controls.Add(Me.GbAlmacen)
        Me.TbDatoAlmacen.Location = New System.Drawing.Point(4, 25)
        Me.TbDatoAlmacen.Name = "TbDatoAlmacen"
        Me.TbDatoAlmacen.Padding = New System.Windows.Forms.Padding(3)
        Me.TbDatoAlmacen.Size = New System.Drawing.Size(759, 356)
        Me.TbDatoAlmacen.TabIndex = 1
        Me.TbDatoAlmacen.Text = "Datos de Almacen"
        Me.TbDatoAlmacen.UseVisualStyleBackColor = True
        '
        'DgAlmacen
        '
        Me.DgAlmacen.AllowUserToAddRows = False
        Me.DgAlmacen.AllowUserToDeleteRows = False
        Me.DgAlmacen.AllowUserToOrderColumns = True
        Me.DgAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgAlmacen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgAlmacen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgAlmacen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAlmacen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgAlmacen.Location = New System.Drawing.Point(6, 216)
        Me.DgAlmacen.MultiSelect = False
        Me.DgAlmacen.Name = "DgAlmacen"
        Me.DgAlmacen.ReadOnly = True
        Me.DgAlmacen.RowHeadersVisible = False
        Me.DgAlmacen.RowHeadersWidth = 40
        Me.DgAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgAlmacen.Size = New System.Drawing.Size(747, 130)
        Me.DgAlmacen.TabIndex = 11
        '
        'GbAlmacen
        '
        Me.GbAlmacen.Controls.Add(Me.NuCapacidadAlmacen)
        Me.GbAlmacen.Controls.Add(Me.TxIdAlmacen)
        Me.GbAlmacen.Controls.Add(Me.CbTipoAlmacen)
        Me.GbAlmacen.Controls.Add(Me.Label2)
        Me.GbAlmacen.Controls.Add(Me.Label7)
        Me.GbAlmacen.Controls.Add(Me.Label9)
        Me.GbAlmacen.Controls.Add(Me.Label3)
        Me.GbAlmacen.Controls.Add(Me.TxNomAlm)
        Me.GbAlmacen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbAlmacen.Location = New System.Drawing.Point(6, 6)
        Me.GbAlmacen.Name = "GbAlmacen"
        Me.GbAlmacen.Size = New System.Drawing.Size(747, 204)
        Me.GbAlmacen.TabIndex = 10
        Me.GbAlmacen.TabStop = False
        '
        'NuCapacidadAlmacen
        '
        Me.NuCapacidadAlmacen.Location = New System.Drawing.Point(95, 87)
        Me.NuCapacidadAlmacen.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.NuCapacidadAlmacen.Name = "NuCapacidadAlmacen"
        Me.NuCapacidadAlmacen.Size = New System.Drawing.Size(100, 22)
        Me.NuCapacidadAlmacen.TabIndex = 2
        '
        'TxIdAlmacen
        '
        Me.TxIdAlmacen.Enabled = False
        Me.TxIdAlmacen.Location = New System.Drawing.Point(95, 28)
        Me.TxIdAlmacen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxIdAlmacen.Name = "TxIdAlmacen"
        Me.TxIdAlmacen.Size = New System.Drawing.Size(110, 22)
        Me.TxIdAlmacen.TabIndex = 4
        '
        'CbTipoAlmacen
        '
        Me.CbTipoAlmacen.FormattingEnabled = True
        Me.CbTipoAlmacen.Location = New System.Drawing.Point(558, 55)
        Me.CbTipoAlmacen.Name = "CbTipoAlmacen"
        Me.CbTipoAlmacen.Size = New System.Drawing.Size(170, 24)
        Me.CbTipoAlmacen.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Id Almacen :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Capacidad :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(440, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo de Almacen :"
        '
        'TxNomAlm
        '
        Me.TxNomAlm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNomAlm.Location = New System.Drawing.Point(95, 58)
        Me.TxNomAlm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxNomAlm.Name = "TxNomAlm"
        Me.TxNomAlm.Size = New System.Drawing.Size(339, 22)
        Me.TxNomAlm.TabIndex = 0
        '
        'BtActualiza
        '
        Me.BtActualiza.Enabled = False
        Me.BtActualiza.Location = New System.Drawing.Point(649, 99)
        Me.BtActualiza.Name = "BtActualiza"
        Me.BtActualiza.Size = New System.Drawing.Size(121, 27)
        Me.BtActualiza.TabIndex = 11
        Me.BtActualiza.Text = "Actualizar"
        Me.BtActualiza.UseVisualStyleBackColor = True
        '
        'TxFolioAserca
        '
        Me.TxFolioAserca.Location = New System.Drawing.Point(135, 57)
        Me.TxFolioAserca.MaxLength = 11
        Me.TxFolioAserca.Name = "TxFolioAserca"
        Me.TxFolioAserca.Size = New System.Drawing.Size(100, 22)
        Me.TxFolioAserca.TabIndex = 13
        '
        'Almacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 510)
        Me.Controls.Add(Me.BtActualiza)
        Me.Controls.Add(Me.TcAlmacen)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnRestaurar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Almacenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Centro de Acopio"
        Me.GBCentroAcopio.ResumeLayout(False)
        Me.GBCentroAcopio.PerformLayout()
        CType(Me.NuCapacidadCentro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgAcopio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TcAlmacen.ResumeLayout(False)
        Me.TbDatosAcopio.ResumeLayout(False)
        Me.TbDatoAlmacen.ResumeLayout(False)
        CType(Me.DgAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbAlmacen.ResumeLayout(False)
        Me.GbAlmacen.PerformLayout()
        CType(Me.NuCapacidadAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents GBCentroAcopio As GroupBox
    Friend WithEvents TxIdAcopio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DgAcopio As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents TxNombreCentro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents NuCapacidadCentro As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxNumeroCentro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxCalleCentro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CbColonia As ComboBox
    Friend WithEvents CbCiudad As ComboBox
    Friend WithEvents TxEstado As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxCodigoPostal As MaskedTextBox
    Friend WithEvents TcAlmacen As TabControl
    Friend WithEvents TbDatosAcopio As TabPage
    Friend WithEvents TbDatoAlmacen As TabPage
    Friend WithEvents DgAlmacen As DataGridView
    Friend WithEvents GbAlmacen As GroupBox
    Friend WithEvents NuCapacidadAlmacen As NumericUpDown
    Friend WithEvents TxIdAlmacen As TextBox
    Friend WithEvents CbTipoAlmacen As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxNomAlm As TextBox
    Friend WithEvents BtActualiza As Button
    Friend WithEvents TxFolioAserca As TextBox
End Class
