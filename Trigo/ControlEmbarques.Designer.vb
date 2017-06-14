<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlEmbarques
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
        Me.BtGuardar = New System.Windows.Forms.Button()
        Me.BtNuevo = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DgBoletaEmbarque = New System.Windows.Forms.DataGridView()
        Me.GbDatoEntrada = New System.Windows.Forms.GroupBox()
        Me.CbLugarExp = New System.Windows.Forms.ComboBox()
        Me.CbLoteEmbarque = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GbGrupoGrano = New System.Windows.Forms.GroupBox()
        Me.RBMamarillo = New System.Windows.Forms.RadioButton()
        Me.RBMblanco = New System.Windows.Forms.RadioButton()
        Me.CbNombre = New System.Windows.Forms.ComboBox()
        Me.CBAnalista = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GbCalidad = New System.Windows.Forms.GroupBox()
        Me.TxPesoEsp = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxGranoDan = New System.Windows.Forms.TextBox()
        Me.TxHumedad = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxDeducciones = New System.Windows.Forms.TextBox()
        Me.TxImpurezas = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxTara = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxBruto = New System.Windows.Forms.TextBox()
        Me.TxNeto = New System.Windows.Forms.TextBox()
        Me.CBContrato = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxPlacas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBConductor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPEmbarques = New System.Windows.Forms.DateTimePicker()
        Me.TxFolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxIdBoleta = New System.Windows.Forms.TextBox()
        Me.TxDomicilio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtImprimir = New System.Windows.Forms.Button()
        Me.TxGranoContraste = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxPuntaNegra = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxPorcentajePB = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DgBoletaEmbarque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatoEntrada.SuspendLayout()
        Me.GbGrupoGrano.SuspendLayout()
        Me.GbCalidad.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(429, 0)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(64, 59)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Location = New System.Drawing.Point(359, 0)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(64, 59)
        Me.BtnRestaurar.TabIndex = 5
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(289, 0)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(64, 59)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(499, 0)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(64, 59)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        Me.BtnBuscar.Visible = False
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(149, 0)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(64, 59)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtGuardar
        '
        Me.BtGuardar.Location = New System.Drawing.Point(79, 0)
        Me.BtGuardar.Name = "BtGuardar"
        Me.BtGuardar.Size = New System.Drawing.Size(64, 59)
        Me.BtGuardar.TabIndex = 1
        Me.BtGuardar.Text = "Guardar"
        Me.BtGuardar.UseVisualStyleBackColor = True
        '
        'BtNuevo
        '
        Me.BtNuevo.Location = New System.Drawing.Point(9, 0)
        Me.BtNuevo.Name = "BtNuevo"
        Me.BtNuevo.Size = New System.Drawing.Size(64, 59)
        Me.BtNuevo.TabIndex = 0
        Me.BtNuevo.Text = "Nuevo"
        Me.BtNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DgBoletaEmbarque)
        Me.GroupBox5.Location = New System.Drawing.Point(657, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(580, 705)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Boletas Ingresadas"
        '
        'DgBoletaEmbarque
        '
        Me.DgBoletaEmbarque.AllowUserToAddRows = False
        Me.DgBoletaEmbarque.AllowUserToDeleteRows = False
        Me.DgBoletaEmbarque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgBoletaEmbarque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgBoletaEmbarque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgBoletaEmbarque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgBoletaEmbarque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBoletaEmbarque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgBoletaEmbarque.Location = New System.Drawing.Point(12, 19)
        Me.DgBoletaEmbarque.MultiSelect = False
        Me.DgBoletaEmbarque.Name = "DgBoletaEmbarque"
        Me.DgBoletaEmbarque.ReadOnly = True
        Me.DgBoletaEmbarque.RowHeadersVisible = False
        Me.DgBoletaEmbarque.RowHeadersWidth = 40
        Me.DgBoletaEmbarque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBoletaEmbarque.Size = New System.Drawing.Size(568, 681)
        Me.DgBoletaEmbarque.TabIndex = 25
        '
        'GbDatoEntrada
        '
        Me.GbDatoEntrada.Controls.Add(Me.CbLugarExp)
        Me.GbDatoEntrada.Controls.Add(Me.CbLoteEmbarque)
        Me.GbDatoEntrada.Controls.Add(Me.Label23)
        Me.GbDatoEntrada.Controls.Add(Me.Label6)
        Me.GbDatoEntrada.Controls.Add(Me.GbGrupoGrano)
        Me.GbDatoEntrada.Controls.Add(Me.CbNombre)
        Me.GbDatoEntrada.Controls.Add(Me.CBAnalista)
        Me.GbDatoEntrada.Controls.Add(Me.Label21)
        Me.GbDatoEntrada.Controls.Add(Me.GbCalidad)
        Me.GbDatoEntrada.Controls.Add(Me.GroupBox3)
        Me.GbDatoEntrada.Controls.Add(Me.CBContrato)
        Me.GbDatoEntrada.Controls.Add(Me.Label10)
        Me.GbDatoEntrada.Controls.Add(Me.TxPlacas)
        Me.GbDatoEntrada.Controls.Add(Me.Label9)
        Me.GbDatoEntrada.Controls.Add(Me.CBConductor)
        Me.GbDatoEntrada.Controls.Add(Me.Label8)
        Me.GbDatoEntrada.Controls.Add(Me.Label5)
        Me.GbDatoEntrada.Controls.Add(Me.Label4)
        Me.GbDatoEntrada.Controls.Add(Me.DTPEmbarques)
        Me.GbDatoEntrada.Controls.Add(Me.TxFolio)
        Me.GbDatoEntrada.Controls.Add(Me.Label1)
        Me.GbDatoEntrada.Controls.Add(Me.Label17)
        Me.GbDatoEntrada.Controls.Add(Me.TxIdBoleta)
        Me.GbDatoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GbDatoEntrada.Location = New System.Drawing.Point(9, 74)
        Me.GbDatoEntrada.Name = "GbDatoEntrada"
        Me.GbDatoEntrada.Size = New System.Drawing.Size(636, 643)
        Me.GbDatoEntrada.TabIndex = 7
        Me.GbDatoEntrada.TabStop = False
        Me.GbDatoEntrada.Text = "Datos de Embarque Directo de Maiz"
        '
        'CbLugarExp
        '
        Me.CbLugarExp.FormattingEnabled = True
        Me.CbLugarExp.Location = New System.Drawing.Point(150, 167)
        Me.CbLugarExp.Name = "CbLugarExp"
        Me.CbLugarExp.Size = New System.Drawing.Size(481, 24)
        Me.CbLugarExp.TabIndex = 4
        '
        'CbLoteEmbarque
        '
        Me.CbLoteEmbarque.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbLoteEmbarque.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbLoteEmbarque.FormattingEnabled = True
        Me.CbLoteEmbarque.Location = New System.Drawing.Point(150, 88)
        Me.CbLoteEmbarque.Name = "CbLoteEmbarque"
        Me.CbLoteEmbarque.Size = New System.Drawing.Size(247, 24)
        Me.CbLoteEmbarque.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(105, 91)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 16)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "Lote:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(496, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "ID :"
        '
        'GbGrupoGrano
        '
        Me.GbGrupoGrano.Controls.Add(Me.RBMamarillo)
        Me.GbGrupoGrano.Controls.Add(Me.RBMblanco)
        Me.GbGrupoGrano.Location = New System.Drawing.Point(0, 116)
        Me.GbGrupoGrano.Name = "GbGrupoGrano"
        Me.GbGrupoGrano.Size = New System.Drawing.Size(636, 45)
        Me.GbGrupoGrano.TabIndex = 3
        Me.GbGrupoGrano.TabStop = False
        Me.GbGrupoGrano.Text = "Producto en Grano (Maiz)"
        '
        'RBMamarillo
        '
        Me.RBMamarillo.AutoSize = True
        Me.RBMamarillo.Location = New System.Drawing.Point(129, 19)
        Me.RBMamarillo.Name = "RBMamarillo"
        Me.RBMamarillo.Size = New System.Drawing.Size(75, 20)
        Me.RBMamarillo.TabIndex = 1
        Me.RBMamarillo.TabStop = True
        Me.RBMamarillo.Text = "Amarillo"
        Me.RBMamarillo.UseVisualStyleBackColor = True
        '
        'RBMblanco
        '
        Me.RBMblanco.AutoSize = True
        Me.RBMblanco.Location = New System.Drawing.Point(9, 19)
        Me.RBMblanco.Name = "RBMblanco"
        Me.RBMblanco.Size = New System.Drawing.Size(68, 20)
        Me.RBMblanco.TabIndex = 0
        Me.RBMblanco.TabStop = True
        Me.RBMblanco.Text = "Blanco"
        Me.RBMblanco.UseVisualStyleBackColor = True
        '
        'CbNombre
        '
        Me.CbNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbNombre.DropDownHeight = 100
        Me.CbNombre.FormattingEnabled = True
        Me.CbNombre.IntegralHeight = False
        Me.CbNombre.Location = New System.Drawing.Point(150, 61)
        Me.CbNombre.MaxDropDownItems = 6
        Me.CbNombre.Name = "CbNombre"
        Me.CbNombre.Size = New System.Drawing.Size(481, 24)
        Me.CbNombre.TabIndex = 1
        '
        'CBAnalista
        '
        Me.CBAnalista.FormattingEnabled = True
        Me.CBAnalista.Location = New System.Drawing.Point(162, 613)
        Me.CBAnalista.Name = "CBAnalista"
        Me.CBAnalista.Size = New System.Drawing.Size(465, 24)
        Me.CBAnalista.TabIndex = 10
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label21.Location = New System.Drawing.Point(97, 614)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 16)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Analista:"
        '
        'GbCalidad
        '
        Me.GbCalidad.Controls.Add(Me.TxPorcentajePB)
        Me.GbCalidad.Controls.Add(Me.Label30)
        Me.GbCalidad.Controls.Add(Me.TxPuntaNegra)
        Me.GbCalidad.Controls.Add(Me.Label28)
        Me.GbCalidad.Controls.Add(Me.TextBox1)
        Me.GbCalidad.Controls.Add(Me.Label29)
        Me.GbCalidad.Controls.Add(Me.TxGranoContraste)
        Me.GbCalidad.Controls.Add(Me.Label24)
        Me.GbCalidad.Controls.Add(Me.TxPesoEsp)
        Me.GbCalidad.Controls.Add(Me.Label18)
        Me.GbCalidad.Controls.Add(Me.Label14)
        Me.GbCalidad.Controls.Add(Me.Label20)
        Me.GbCalidad.Controls.Add(Me.Label22)
        Me.GbCalidad.Controls.Add(Me.TxGranoDan)
        Me.GbCalidad.Controls.Add(Me.TxHumedad)
        Me.GbCalidad.Controls.Add(Me.Label16)
        Me.GbCalidad.Controls.Add(Me.TxTotal)
        Me.GbCalidad.Controls.Add(Me.Label15)
        Me.GbCalidad.Controls.Add(Me.TxDeducciones)
        Me.GbCalidad.Controls.Add(Me.TxImpurezas)
        Me.GbCalidad.Location = New System.Drawing.Point(276, 193)
        Me.GbCalidad.Name = "GbCalidad"
        Me.GbCalidad.Size = New System.Drawing.Size(360, 323)
        Me.GbCalidad.TabIndex = 6
        Me.GbCalidad.TabStop = False
        Me.GbCalidad.Text = "Certificado de Calidad"
        '
        'TxPesoEsp
        '
        Me.TxPesoEsp.Location = New System.Drawing.Point(127, 100)
        Me.TxPesoEsp.MaxLength = 6
        Me.TxPesoEsp.Name = "TxPesoEsp"
        Me.TxPesoEsp.Size = New System.Drawing.Size(122, 22)
        Me.TxPesoEsp.TabIndex = 4
        Me.TxPesoEsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label18.Location = New System.Drawing.Point(12, 101)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(109, 16)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "Peso Especifico:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(50, 215)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 16)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Humedad:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(75, 243)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 18)
        Me.Label20.TabIndex = 76
        Me.Label20.Text = "Total Deducciones:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(154, 281)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 24)
        Me.Label22.TabIndex = 73
        Me.Label22.Text = "Total:"
        '
        'TxGranoDan
        '
        Me.TxGranoDan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxGranoDan.Location = New System.Drawing.Point(127, 72)
        Me.TxGranoDan.MaxLength = 6
        Me.TxGranoDan.Name = "TxGranoDan"
        Me.TxGranoDan.Size = New System.Drawing.Size(122, 22)
        Me.TxGranoDan.TabIndex = 2
        Me.TxGranoDan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxHumedad
        '
        Me.TxHumedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxHumedad.Location = New System.Drawing.Point(127, 212)
        Me.TxHumedad.MaxLength = 6
        Me.TxHumedad.Name = "TxHumedad"
        Me.TxHumedad.Size = New System.Drawing.Size(122, 22)
        Me.TxHumedad.TabIndex = 0
        Me.TxHumedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label16.Location = New System.Drawing.Point(7, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(114, 16)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "Granos Dañados:"
        '
        'TxTotal
        '
        Me.TxTotal.Enabled = False
        Me.TxTotal.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTotal.Location = New System.Drawing.Point(220, 274)
        Me.TxTotal.MaxLength = 9
        Me.TxTotal.Name = "TxTotal"
        Me.TxTotal.Size = New System.Drawing.Size(131, 35)
        Me.TxTotal.TabIndex = 9
        Me.TxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label15.Location = New System.Drawing.Point(48, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 16)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Impurezas:"
        '
        'TxDeducciones
        '
        Me.TxDeducciones.Enabled = False
        Me.TxDeducciones.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDeducciones.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TxDeducciones.Location = New System.Drawing.Point(220, 240)
        Me.TxDeducciones.MaxLength = 7
        Me.TxDeducciones.Name = "TxDeducciones"
        Me.TxDeducciones.Size = New System.Drawing.Size(131, 25)
        Me.TxDeducciones.TabIndex = 8
        Me.TxDeducciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxImpurezas
        '
        Me.TxImpurezas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxImpurezas.Location = New System.Drawing.Point(127, 46)
        Me.TxImpurezas.MaxLength = 6
        Me.TxImpurezas.Name = "TxImpurezas"
        Me.TxImpurezas.Size = New System.Drawing.Size(122, 22)
        Me.TxImpurezas.TabIndex = 1
        Me.TxImpurezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxTara)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TxBruto)
        Me.GroupBox3.Controls.Add(Me.TxNeto)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(276, 182)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Peso del Grano"
        '
        'TxTara
        '
        Me.TxTara.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTara.Location = New System.Drawing.Point(142, 26)
        Me.TxTara.MaxLength = 9
        Me.TxTara.Name = "TxTara"
        Me.TxTara.Size = New System.Drawing.Size(124, 35)
        Me.TxTara.TabIndex = 76
        Me.TxTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(76, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 24)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Tara:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 24)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Peso Bruto:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 115)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 24)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Peso Neto:"
        '
        'TxBruto
        '
        Me.TxBruto.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxBruto.Location = New System.Drawing.Point(142, 67)
        Me.TxBruto.MaxLength = 9
        Me.TxBruto.Name = "TxBruto"
        Me.TxBruto.Size = New System.Drawing.Size(124, 35)
        Me.TxBruto.TabIndex = 0
        Me.TxBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxNeto
        '
        Me.TxNeto.Enabled = False
        Me.TxNeto.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNeto.Location = New System.Drawing.Point(142, 108)
        Me.TxNeto.MaxLength = 9
        Me.TxNeto.Name = "TxNeto"
        Me.TxNeto.Size = New System.Drawing.Size(124, 35)
        Me.TxNeto.TabIndex = 2
        Me.TxNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CBContrato
        '
        Me.CBContrato.FormattingEnabled = True
        Me.CBContrato.Location = New System.Drawing.Point(162, 522)
        Me.CBContrato.Name = "CBContrato"
        Me.CBContrato.Size = New System.Drawing.Size(465, 24)
        Me.CBContrato.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(70, 523)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Contrato con:"
        '
        'TxPlacas
        '
        Me.TxPlacas.Location = New System.Drawing.Point(162, 584)
        Me.TxPlacas.Name = "TxPlacas"
        Me.TxPlacas.Size = New System.Drawing.Size(111, 22)
        Me.TxPlacas.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(103, 585)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Placas:"
        '
        'CBConductor
        '
        Me.CBConductor.FormattingEnabled = True
        Me.CBConductor.Location = New System.Drawing.Point(162, 552)
        Me.CBConductor.Name = "CBConductor"
        Me.CBConductor.Size = New System.Drawing.Size(465, 24)
        Me.CBConductor.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(10, 553)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nombre del Conductor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Lugar de Expedición:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(7, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha:"
        '
        'DTPEmbarques
        '
        Me.DTPEmbarques.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.DTPEmbarques.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPEmbarques.Location = New System.Drawing.Point(61, 20)
        Me.DTPEmbarques.Name = "DTPEmbarques"
        Me.DTPEmbarques.Size = New System.Drawing.Size(95, 22)
        Me.DTPEmbarques.TabIndex = 1
        '
        'TxFolio
        '
        Me.TxFolio.BackColor = System.Drawing.SystemColors.Control
        Me.TxFolio.Enabled = False
        Me.TxFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFolio.Location = New System.Drawing.Point(531, 20)
        Me.TxFolio.Name = "TxFolio"
        Me.TxFolio.Size = New System.Drawing.Size(99, 22)
        Me.TxFolio.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(1, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Productor:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(205, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "FOLIO:"
        '
        'TxIdBoleta
        '
        Me.TxIdBoleta.BackColor = System.Drawing.Color.White
        Me.TxIdBoleta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxIdBoleta.Location = New System.Drawing.Point(263, 20)
        Me.TxIdBoleta.MaxLength = 8
        Me.TxIdBoleta.Name = "TxIdBoleta"
        Me.TxIdBoleta.Size = New System.Drawing.Size(99, 22)
        Me.TxIdBoleta.TabIndex = 0
        Me.TxIdBoleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxDomicilio
        '
        Me.TxDomicilio.Location = New System.Drawing.Point(596, 31)
        Me.TxDomicilio.Name = "TxDomicilio"
        Me.TxDomicilio.Size = New System.Drawing.Size(25, 20)
        Me.TxDomicilio.TabIndex = 3
        Me.TxDomicilio.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(569, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Domicilio:"
        Me.Label2.Visible = False
        '
        'BtImprimir
        '
        Me.BtImprimir.Location = New System.Drawing.Point(219, 0)
        Me.BtImprimir.Name = "BtImprimir"
        Me.BtImprimir.Size = New System.Drawing.Size(64, 59)
        Me.BtImprimir.TabIndex = 4
        Me.BtImprimir.Text = "Imprimir"
        Me.BtImprimir.UseVisualStyleBackColor = True
        '
        'TxGranoContraste
        '
        Me.TxGranoContraste.Enabled = False
        Me.TxGranoContraste.Location = New System.Drawing.Point(127, 184)
        Me.TxGranoContraste.MaxLength = 6
        Me.TxGranoContraste.Name = "TxGranoContraste"
        Me.TxGranoContraste.Size = New System.Drawing.Size(122, 22)
        Me.TxGranoContraste.TabIndex = 85
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(13, 186)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(108, 16)
        Me.Label24.TabIndex = 86
        Me.Label24.Text = "Grano Contraste:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 156)
        Me.TextBox1.MaxLength = 6
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 22)
        Me.TextBox1.TabIndex = 87
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(9, 158)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(112, 16)
        Me.Label29.TabIndex = 88
        Me.Label29.Text = "Grano Quebrado:"
        '
        'TxPuntaNegra
        '
        Me.TxPuntaNegra.Enabled = False
        Me.TxPuntaNegra.Location = New System.Drawing.Point(127, 18)
        Me.TxPuntaNegra.MaxLength = 6
        Me.TxPuntaNegra.Name = "TxPuntaNegra"
        Me.TxPuntaNegra.Size = New System.Drawing.Size(122, 22)
        Me.TxPuntaNegra.TabIndex = 89
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(35, 20)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(86, 16)
        Me.Label28.TabIndex = 90
        Me.Label28.Text = "Punta Negra:"
        '
        'TxPorcentajePB
        '
        Me.TxPorcentajePB.Location = New System.Drawing.Point(127, 128)
        Me.TxPorcentajePB.MaxLength = 6
        Me.TxPorcentajePB.Name = "TxPorcentajePB"
        Me.TxPorcentajePB.Size = New System.Drawing.Size(122, 22)
        Me.TxPorcentajePB.TabIndex = 91
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(12, 130)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(109, 16)
        Me.Label30.TabIndex = 92
        Me.Label30.Text = "% Panza Blanca:"
        '
        'ControlEmbarques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 724)
        Me.Controls.Add(Me.GbDatoEntrada)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnRestaurar)
        Me.Controls.Add(Me.BtImprimir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtGuardar)
        Me.Controls.Add(Me.BtNuevo)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxDomicilio)
        Me.KeyPreview = True
        Me.Name = "ControlEmbarques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Embarques"
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DgBoletaEmbarque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatoEntrada.ResumeLayout(False)
        Me.GbDatoEntrada.PerformLayout()
        Me.GbGrupoGrano.ResumeLayout(False)
        Me.GbGrupoGrano.PerformLayout()
        Me.GbCalidad.ResumeLayout(False)
        Me.GbCalidad.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtGuardar As Button
    Friend WithEvents BtNuevo As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GbDatoEntrada As GroupBox
    Friend WithEvents CBAnalista As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CBContrato As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxPlacas As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CBConductor As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DTPEmbarques As DateTimePicker
    Friend WithEvents TxFolio As TextBox
    Friend WithEvents TxDomicilio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbNombre As ComboBox
    Friend WithEvents DgBoletaEmbarque As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxBruto As TextBox
    Friend WithEvents TxNeto As TextBox
    Friend WithEvents GbCalidad As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TxGranoDan As TextBox
    Friend WithEvents TxHumedad As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxTotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxDeducciones As TextBox
    Friend WithEvents TxImpurezas As TextBox
    Friend WithEvents GbGrupoGrano As GroupBox
    Friend WithEvents RBMamarillo As RadioButton
    Friend WithEvents RBMblanco As RadioButton
    Friend WithEvents Label17 As Label
    Friend WithEvents TxIdBoleta As TextBox
    Friend WithEvents BtImprimir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CbLoteEmbarque As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TxPesoEsp As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CbLugarExp As ComboBox
    Friend WithEvents TxTara As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxGranoContraste As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TxPuntaNegra As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TxPorcentajePB As TextBox
    Friend WithEvents Label30 As Label
End Class
