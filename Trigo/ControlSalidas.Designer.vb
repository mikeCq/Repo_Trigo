<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlSalidas
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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.GbBoletasSalidas = New System.Windows.Forms.GroupBox()
        Me.DgBoletaSalidas = New System.Windows.Forms.DataGridView()
        Me.GbDatoEntrada = New System.Windows.Forms.GroupBox()
        Me.CbLugarExp = New System.Windows.Forms.ComboBox()
        Me.GbGrupoGrano = New System.Windows.Forms.GroupBox()
        Me.RBTCachanilla = New System.Windows.Forms.RadioButton()
        Me.RBTCristalino = New System.Windows.Forms.RadioButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.LbCapacidad = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LbToneladas = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PbSilos = New System.Windows.Forms.ProgressBar()
        Me.CbAcopio = New System.Windows.Forms.ComboBox()
        Me.CbAlmacen = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBAnalista = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GbCalidad = New System.Windows.Forms.GroupBox()
        Me.TxPesoEsp = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxTotal = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxDeducciones = New System.Windows.Forms.TextBox()
        Me.TxGranoDan = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxImpurezas = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxBruto = New System.Windows.Forms.TextBox()
        Me.TxNeto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxTara = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CbNombre = New System.Windows.Forms.ComboBox()
        Me.CBContrato = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxPlacas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBConductor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPSalidas = New System.Windows.Forms.DateTimePicker()
        Me.TxIdBoleta = New System.Windows.Forms.TextBox()
        Me.TxFolio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtImprimir = New System.Windows.Forms.Button()
        Me.TxGranoContraste = New System.Windows.Forms.TextBox()
        Me.TxPorcentajePB = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxHumedad = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GbBoletasSalidas.SuspendLayout()
        CType(Me.DgBoletaSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatoEntrada.SuspendLayout()
        Me.GbGrupoGrano.SuspendLayout()
        Me.GbCalidad.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.BtnSalir.Location = New System.Drawing.Point(428, 0)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(64, 59)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.BtnRestaurar.Location = New System.Drawing.Point(358, 0)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(64, 59)
        Me.BtnRestaurar.TabIndex = 5
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.BtnEliminar.Location = New System.Drawing.Point(288, 0)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(64, 59)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.BtnBuscar.Location = New System.Drawing.Point(498, 0)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(64, 59)
        Me.BtnBuscar.TabIndex = 7
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        Me.BtnBuscar.Visible = False
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.BtnModificar.Location = New System.Drawing.Point(148, 0)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(64, 59)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.BtnGuardar.Location = New System.Drawing.Point(78, 0)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(64, 59)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.BtnNuevo.Location = New System.Drawing.Point(8, 0)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(64, 59)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'GbBoletasSalidas
        '
        Me.GbBoletasSalidas.Controls.Add(Me.DgBoletaSalidas)
        Me.GbBoletasSalidas.Location = New System.Drawing.Point(656, 12)
        Me.GbBoletasSalidas.Name = "GbBoletasSalidas"
        Me.GbBoletasSalidas.Size = New System.Drawing.Size(580, 706)
        Me.GbBoletasSalidas.TabIndex = 0
        Me.GbBoletasSalidas.TabStop = False
        Me.GbBoletasSalidas.Text = "Boletas Ingresadas"
        '
        'DgBoletaSalidas
        '
        Me.DgBoletaSalidas.AllowUserToAddRows = False
        Me.DgBoletaSalidas.AllowUserToDeleteRows = False
        Me.DgBoletaSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgBoletaSalidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgBoletaSalidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgBoletaSalidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgBoletaSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBoletaSalidas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgBoletaSalidas.Location = New System.Drawing.Point(6, 21)
        Me.DgBoletaSalidas.MultiSelect = False
        Me.DgBoletaSalidas.Name = "DgBoletaSalidas"
        Me.DgBoletaSalidas.ReadOnly = True
        Me.DgBoletaSalidas.RowHeadersVisible = False
        Me.DgBoletaSalidas.RowHeadersWidth = 40
        Me.DgBoletaSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBoletaSalidas.Size = New System.Drawing.Size(568, 673)
        Me.DgBoletaSalidas.TabIndex = 0
        '
        'GbDatoEntrada
        '
        Me.GbDatoEntrada.Controls.Add(Me.CbLugarExp)
        Me.GbDatoEntrada.Controls.Add(Me.GbGrupoGrano)
        Me.GbDatoEntrada.Controls.Add(Me.Label27)
        Me.GbDatoEntrada.Controls.Add(Me.LbCapacidad)
        Me.GbDatoEntrada.Controls.Add(Me.Label26)
        Me.GbDatoEntrada.Controls.Add(Me.LbToneladas)
        Me.GbDatoEntrada.Controls.Add(Me.Label25)
        Me.GbDatoEntrada.Controls.Add(Me.PbSilos)
        Me.GbDatoEntrada.Controls.Add(Me.CbAcopio)
        Me.GbDatoEntrada.Controls.Add(Me.CbAlmacen)
        Me.GbDatoEntrada.Controls.Add(Me.Label7)
        Me.GbDatoEntrada.Controls.Add(Me.Label6)
        Me.GbDatoEntrada.Controls.Add(Me.CBAnalista)
        Me.GbDatoEntrada.Controls.Add(Me.Label21)
        Me.GbDatoEntrada.Controls.Add(Me.GbCalidad)
        Me.GbDatoEntrada.Controls.Add(Me.GroupBox3)
        Me.GbDatoEntrada.Controls.Add(Me.CbNombre)
        Me.GbDatoEntrada.Controls.Add(Me.CBContrato)
        Me.GbDatoEntrada.Controls.Add(Me.Label10)
        Me.GbDatoEntrada.Controls.Add(Me.TxPlacas)
        Me.GbDatoEntrada.Controls.Add(Me.Label9)
        Me.GbDatoEntrada.Controls.Add(Me.CBConductor)
        Me.GbDatoEntrada.Controls.Add(Me.Label8)
        Me.GbDatoEntrada.Controls.Add(Me.Label5)
        Me.GbDatoEntrada.Controls.Add(Me.Label4)
        Me.GbDatoEntrada.Controls.Add(Me.DTPSalidas)
        Me.GbDatoEntrada.Controls.Add(Me.TxIdBoleta)
        Me.GbDatoEntrada.Controls.Add(Me.TxFolio)
        Me.GbDatoEntrada.Controls.Add(Me.Label2)
        Me.GbDatoEntrada.Controls.Add(Me.Label3)
        Me.GbDatoEntrada.Controls.Add(Me.Label1)
        Me.GbDatoEntrada.Location = New System.Drawing.Point(8, 75)
        Me.GbDatoEntrada.Name = "GbDatoEntrada"
        Me.GbDatoEntrada.Size = New System.Drawing.Size(636, 643)
        Me.GbDatoEntrada.TabIndex = 1
        Me.GbDatoEntrada.TabStop = False
        Me.GbDatoEntrada.Text = "Datos de la Entrada de Trigo"
        '
        'CbLugarExp
        '
        Me.CbLugarExp.FormattingEnabled = True
        Me.CbLugarExp.Location = New System.Drawing.Point(150, 154)
        Me.CbLugarExp.Name = "CbLugarExp"
        Me.CbLugarExp.Size = New System.Drawing.Size(477, 24)
        Me.CbLugarExp.TabIndex = 3
        '
        'GbGrupoGrano
        '
        Me.GbGrupoGrano.Controls.Add(Me.RBTCachanilla)
        Me.GbGrupoGrano.Controls.Add(Me.RBTCristalino)
        Me.GbGrupoGrano.Location = New System.Drawing.Point(1, 103)
        Me.GbGrupoGrano.Name = "GbGrupoGrano"
        Me.GbGrupoGrano.Size = New System.Drawing.Size(630, 45)
        Me.GbGrupoGrano.TabIndex = 2
        Me.GbGrupoGrano.TabStop = False
        Me.GbGrupoGrano.Text = "Producto en Grano"
        '
        'RBTCachanilla
        '
        Me.RBTCachanilla.AutoSize = True
        Me.RBTCachanilla.Location = New System.Drawing.Point(129, 19)
        Me.RBTCachanilla.Name = "RBTCachanilla"
        Me.RBTCachanilla.Size = New System.Drawing.Size(86, 20)
        Me.RBTCachanilla.TabIndex = 1
        Me.RBTCachanilla.TabStop = True
        Me.RBTCachanilla.Text = "Cachanilla"
        Me.RBTCachanilla.UseVisualStyleBackColor = True
        '
        'RBTCristalino
        '
        Me.RBTCristalino.AutoSize = True
        Me.RBTCristalino.Location = New System.Drawing.Point(9, 19)
        Me.RBTCristalino.Name = "RBTCristalino"
        Me.RBTCristalino.Size = New System.Drawing.Size(80, 20)
        Me.RBTCristalino.TabIndex = 0
        Me.RBTCristalino.TabStop = True
        Me.RBTCristalino.Text = "Cristalino"
        Me.RBTCristalino.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(12, 409)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(102, 16)
        Me.Label27.TabIndex = 35
        Me.Label27.Text = "Capacidad Max:"
        '
        'LbCapacidad
        '
        Me.LbCapacidad.AutoSize = True
        Me.LbCapacidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCapacidad.Location = New System.Drawing.Point(151, 409)
        Me.LbCapacidad.Name = "LbCapacidad"
        Me.LbCapacidad.Size = New System.Drawing.Size(49, 19)
        Me.LbCapacidad.TabIndex = 34
        Me.LbCapacidad.Text = "0.000"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(229, 464)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(35, 16)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "Ton."
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbToneladas
        '
        Me.LbToneladas.AutoSize = True
        Me.LbToneladas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbToneladas.Location = New System.Drawing.Point(139, 464)
        Me.LbToneladas.Name = "LbToneladas"
        Me.LbToneladas.Size = New System.Drawing.Size(40, 16)
        Me.LbToneladas.TabIndex = 32
        Me.LbToneladas.Text = "0.000"
        Me.LbToneladas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(41, 425)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(73, 32)
        Me.Label25.TabIndex = 31
        Me.Label25.Text = "Capacidad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Silo:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PbSilos
        '
        Me.PbSilos.BackColor = System.Drawing.Color.Blue
        Me.PbSilos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PbSilos.Location = New System.Drawing.Point(120, 431)
        Me.PbSilos.Name = "PbSilos"
        Me.PbSilos.Size = New System.Drawing.Size(141, 30)
        Me.PbSilos.TabIndex = 30
        '
        'CbAcopio
        '
        Me.CbAcopio.FormattingEnabled = True
        Me.CbAcopio.Location = New System.Drawing.Point(120, 352)
        Me.CbAcopio.Name = "CbAcopio"
        Me.CbAcopio.Size = New System.Drawing.Size(144, 24)
        Me.CbAcopio.TabIndex = 5
        '
        'CbAlmacen
        '
        Me.CbAlmacen.FormattingEnabled = True
        Me.CbAlmacen.Location = New System.Drawing.Point(120, 381)
        Me.CbAlmacen.Name = "CbAlmacen"
        Me.CbAlmacen.Size = New System.Drawing.Size(144, 24)
        Me.CbAlmacen.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 32)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Centro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Acopio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Almacen:"
        '
        'CBAnalista
        '
        Me.CBAnalista.FormattingEnabled = True
        Me.CBAnalista.Location = New System.Drawing.Point(150, 613)
        Me.CBAnalista.Name = "CBAnalista"
        Me.CBAnalista.Size = New System.Drawing.Size(477, 24)
        Me.CBAnalista.TabIndex = 10
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(82, 616)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 16)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Analista:"
        '
        'GbCalidad
        '
        Me.GbCalidad.Controls.Add(Me.TextBox2)
        Me.GbCalidad.Controls.Add(Me.Label17)
        Me.GbCalidad.Controls.Add(Me.Label14)
        Me.GbCalidad.Controls.Add(Me.TxHumedad)
        Me.GbCalidad.Controls.Add(Me.TxGranoContraste)
        Me.GbCalidad.Controls.Add(Me.TxPorcentajePB)
        Me.GbCalidad.Controls.Add(Me.TextBox1)
        Me.GbCalidad.Controls.Add(Me.Label24)
        Me.GbCalidad.Controls.Add(Me.Label29)
        Me.GbCalidad.Controls.Add(Me.Label30)
        Me.GbCalidad.Controls.Add(Me.TxPesoEsp)
        Me.GbCalidad.Controls.Add(Me.Label18)
        Me.GbCalidad.Controls.Add(Me.Label20)
        Me.GbCalidad.Controls.Add(Me.TxTotal)
        Me.GbCalidad.Controls.Add(Me.Label22)
        Me.GbCalidad.Controls.Add(Me.TxDeducciones)
        Me.GbCalidad.Controls.Add(Me.TxGranoDan)
        Me.GbCalidad.Controls.Add(Me.Label16)
        Me.GbCalidad.Controls.Add(Me.Label15)
        Me.GbCalidad.Controls.Add(Me.TxImpurezas)
        Me.GbCalidad.Location = New System.Drawing.Point(276, 177)
        Me.GbCalidad.Name = "GbCalidad"
        Me.GbCalidad.Size = New System.Drawing.Size(360, 339)
        Me.GbCalidad.TabIndex = 5
        Me.GbCalidad.TabStop = False
        Me.GbCalidad.Text = "Certificado de Calidad"
        '
        'TxPesoEsp
        '
        Me.TxPesoEsp.Location = New System.Drawing.Point(120, 95)
        Me.TxPesoEsp.MaxLength = 6
        Me.TxPesoEsp.Name = "TxPesoEsp"
        Me.TxPesoEsp.Size = New System.Drawing.Size(122, 22)
        Me.TxPesoEsp.TabIndex = 4
        Me.TxPesoEsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 98)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 16)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "Peso Especifico:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(74, 251)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 18)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Total Deducciones:"
        '
        'TxTotal
        '
        Me.TxTotal.Enabled = False
        Me.TxTotal.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTotal.Location = New System.Drawing.Point(224, 282)
        Me.TxTotal.MaxLength = 9
        Me.TxTotal.Name = "TxTotal"
        Me.TxTotal.Size = New System.Drawing.Size(131, 35)
        Me.TxTotal.TabIndex = 9
        Me.TxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(153, 289)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 24)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "Total:"
        '
        'TxDeducciones
        '
        Me.TxDeducciones.Enabled = False
        Me.TxDeducciones.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDeducciones.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TxDeducciones.Location = New System.Drawing.Point(224, 248)
        Me.TxDeducciones.MaxLength = 7
        Me.TxDeducciones.Name = "TxDeducciones"
        Me.TxDeducciones.Size = New System.Drawing.Size(131, 25)
        Me.TxDeducciones.TabIndex = 8
        Me.TxDeducciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxGranoDan
        '
        Me.TxGranoDan.Location = New System.Drawing.Point(120, 70)
        Me.TxGranoDan.MaxLength = 6
        Me.TxGranoDan.Name = "TxGranoDan"
        Me.TxGranoDan.Size = New System.Drawing.Size(122, 22)
        Me.TxGranoDan.TabIndex = 2
        Me.TxGranoDan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Granos Dañados:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(44, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Impurezas:"
        '
        'TxImpurezas
        '
        Me.TxImpurezas.Location = New System.Drawing.Point(120, 45)
        Me.TxImpurezas.MaxLength = 6
        Me.TxImpurezas.Name = "TxImpurezas"
        Me.TxImpurezas.Size = New System.Drawing.Size(122, 22)
        Me.TxImpurezas.TabIndex = 1
        Me.TxImpurezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TxBruto)
        Me.GroupBox3.Controls.Add(Me.TxNeto)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TxTara)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 177)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(276, 161)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Peso del Grano"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 24)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Peso Bruto:"
        '
        'TxBruto
        '
        Me.TxBruto.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxBruto.Location = New System.Drawing.Point(137, 65)
        Me.TxBruto.MaxLength = 9
        Me.TxBruto.Name = "TxBruto"
        Me.TxBruto.Size = New System.Drawing.Size(124, 35)
        Me.TxBruto.TabIndex = 1
        Me.TxBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxNeto
        '
        Me.TxNeto.Enabled = False
        Me.TxNeto.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNeto.Location = New System.Drawing.Point(137, 114)
        Me.TxNeto.MaxLength = 9
        Me.TxNeto.Name = "TxNeto"
        Me.TxNeto.Size = New System.Drawing.Size(124, 35)
        Me.TxNeto.TabIndex = 2
        Me.TxNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(76, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 24)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Tara:"
        '
        'TxTara
        '
        Me.TxTara.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTara.Location = New System.Drawing.Point(137, 17)
        Me.TxTara.MaxLength = 9
        Me.TxTara.Name = "TxTara"
        Me.TxTara.Size = New System.Drawing.Size(124, 35)
        Me.TxTara.TabIndex = 0
        Me.TxTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 24)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Peso Neto:"
        '
        'CbNombre
        '
        Me.CbNombre.FormattingEnabled = True
        Me.CbNombre.Location = New System.Drawing.Point(150, 56)
        Me.CbNombre.Name = "CbNombre"
        Me.CbNombre.Size = New System.Drawing.Size(477, 24)
        Me.CbNombre.TabIndex = 1
        '
        'CBContrato
        '
        Me.CBContrato.FormattingEnabled = True
        Me.CBContrato.Location = New System.Drawing.Point(150, 522)
        Me.CBContrato.Name = "CBContrato"
        Me.CBContrato.Size = New System.Drawing.Size(477, 24)
        Me.CBContrato.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(58, 525)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Contrato con:"
        '
        'TxPlacas
        '
        Me.TxPlacas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxPlacas.Location = New System.Drawing.Point(150, 584)
        Me.TxPlacas.MaxLength = 13
        Me.TxPlacas.Name = "TxPlacas"
        Me.TxPlacas.Size = New System.Drawing.Size(123, 22)
        Me.TxPlacas.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(92, 587)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Placas:"
        '
        'CBConductor
        '
        Me.CBConductor.FormattingEnabled = True
        Me.CBConductor.Location = New System.Drawing.Point(150, 552)
        Me.CBConductor.Name = "CBConductor"
        Me.CBConductor.Size = New System.Drawing.Size(477, 24)
        Me.CBConductor.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 555)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nombre del Conductor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Lugar de Expedición:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha:"
        '
        'DTPSalidas
        '
        Me.DTPSalidas.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPSalidas.Location = New System.Drawing.Point(64, 22)
        Me.DTPSalidas.Name = "DTPSalidas"
        Me.DTPSalidas.Size = New System.Drawing.Size(92, 22)
        Me.DTPSalidas.TabIndex = 0
        '
        'TxIdBoleta
        '
        Me.TxIdBoleta.BackColor = System.Drawing.Color.White
        Me.TxIdBoleta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxIdBoleta.Location = New System.Drawing.Point(240, 22)
        Me.TxIdBoleta.MaxLength = 8
        Me.TxIdBoleta.Name = "TxIdBoleta"
        Me.TxIdBoleta.Size = New System.Drawing.Size(99, 22)
        Me.TxIdBoleta.TabIndex = 0
        Me.TxIdBoleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxFolio
        '
        Me.TxFolio.BackColor = System.Drawing.SystemColors.Control
        Me.TxFolio.Enabled = False
        Me.TxFolio.Location = New System.Drawing.Point(528, 22)
        Me.TxFolio.Name = "TxFolio"
        Me.TxFolio.Size = New System.Drawing.Size(99, 22)
        Me.TxFolio.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "FOLIO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(497, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del vendedor:"
        '
        'BtImprimir
        '
        Me.BtImprimir.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.BtImprimir.Location = New System.Drawing.Point(218, 0)
        Me.BtImprimir.Name = "BtImprimir"
        Me.BtImprimir.Size = New System.Drawing.Size(64, 59)
        Me.BtImprimir.TabIndex = 3
        Me.BtImprimir.Text = "Imprimir"
        Me.BtImprimir.UseVisualStyleBackColor = True
        '
        'TxGranoContraste
        '
        Me.TxGranoContraste.Enabled = False
        Me.TxGranoContraste.Location = New System.Drawing.Point(120, 170)
        Me.TxGranoContraste.MaxLength = 6
        Me.TxGranoContraste.Name = "TxGranoContraste"
        Me.TxGranoContraste.Size = New System.Drawing.Size(122, 22)
        Me.TxGranoContraste.TabIndex = 55
        '
        'TxPorcentajePB
        '
        Me.TxPorcentajePB.Location = New System.Drawing.Point(120, 120)
        Me.TxPorcentajePB.MaxLength = 6
        Me.TxPorcentajePB.Name = "TxPorcentajePB"
        Me.TxPorcentajePB.Size = New System.Drawing.Size(122, 22)
        Me.TxPorcentajePB.TabIndex = 51
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 145)
        Me.TextBox1.MaxLength = 6
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 22)
        Me.TextBox1.TabIndex = 53
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 172)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(107, 16)
        Me.Label24.TabIndex = 56
        Me.Label24.Text = "Grano Contraste:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(8, 147)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(107, 16)
        Me.Label29.TabIndex = 54
        Me.Label29.Text = "Grano Quebrado:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(6, 122)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(109, 16)
        Me.Label30.TabIndex = 52
        Me.Label30.Text = "% Panza Blanca:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(48, 197)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 16)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Humedad:"
        '
        'TxHumedad
        '
        Me.TxHumedad.Location = New System.Drawing.Point(120, 195)
        Me.TxHumedad.MaxLength = 6
        Me.TxHumedad.Name = "TxHumedad"
        Me.TxHumedad.Size = New System.Drawing.Size(122, 22)
        Me.TxHumedad.TabIndex = 58
        Me.TxHumedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(120, 20)
        Me.TextBox2.MaxLength = 6
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(122, 22)
        Me.TextBox2.TabIndex = 41
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(30, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 16)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Punta Negra:"
        '
        'ControlSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 725)
        Me.Controls.Add(Me.GbDatoEntrada)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnRestaurar)
        Me.Controls.Add(Me.BtImprimir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GbBoletasSalidas)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ControlSalidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Salidas de Maiz"
        Me.GbBoletasSalidas.ResumeLayout(False)
        CType(Me.DgBoletaSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatoEntrada.ResumeLayout(False)
        Me.GbDatoEntrada.PerformLayout()
        Me.GbGrupoGrano.ResumeLayout(False)
        Me.GbGrupoGrano.PerformLayout()
        Me.GbCalidad.ResumeLayout(False)
        Me.GbCalidad.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents GbBoletasSalidas As GroupBox
    Friend WithEvents GbDatoEntrada As GroupBox
    Friend WithEvents CBAnalista As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents GbCalidad As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CBContrato As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxPlacas As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CBConductor As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DTPSalidas As DateTimePicker
    Friend WithEvents TxFolio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgBoletaSalidas As DataGridView
    Friend WithEvents CbAcopio As ComboBox
    Friend WithEvents CbAlmacen As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxNeto As TextBox
    Friend WithEvents TxTara As TextBox
    Friend WithEvents TxTotal As TextBox
    Friend WithEvents TxDeducciones As TextBox
    Friend WithEvents TxGranoDan As TextBox
    Friend WithEvents TxImpurezas As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents LbCapacidad As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents LbToneladas As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents PbSilos As ProgressBar
    Friend WithEvents Label11 As Label
    Friend WithEvents TxBruto As TextBox
    Friend WithEvents BtImprimir As Button
    Friend WithEvents TxIdBoleta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbNombre As ComboBox
    Friend WithEvents GbGrupoGrano As GroupBox
    Friend WithEvents RBTCachanilla As RadioButton
    Friend WithEvents RBTCristalino As RadioButton
    Friend WithEvents TxPesoEsp As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CbLugarExp As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxHumedad As TextBox
    Friend WithEvents TxGranoContraste As TextBox
    Friend WithEvents TxPorcentajePB As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label17 As Label
End Class
