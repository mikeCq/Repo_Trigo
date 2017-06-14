<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContratosVentas
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
        Me.GbDatoContrato = New System.Windows.Forms.GroupBox()
        Me.CbNombreComprador = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbMaizLibre = New System.Windows.Forms.RadioButton()
        Me.RbMaizContrato = New System.Windows.Forms.RadioButton()
        Me.CbMoneda = New System.Windows.Forms.ComboBox()
        Me.DtLiquidacion = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbTemporada = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxPrecioXtonelada = New System.Windows.Forms.TextBox()
        Me.TxToneladas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtAlta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxFolioComprador = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxFolioContrato = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgContatoVenta = New System.Windows.Forms.DataGridView()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.LBCodigoSIAP = New System.Windows.Forms.Label()
        Me.LBCodigoSAP = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBCodigoSIAP = New System.Windows.Forms.TextBox()
        Me.TBCodigoSAP = New System.Windows.Forms.TextBox()
        Me.TBCodigoASERCA = New System.Windows.Forms.TextBox()
        Me.GbDatoContrato.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgContatoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbDatoContrato
        '
        Me.GbDatoContrato.Controls.Add(Me.CbNombreComprador)
        Me.GbDatoContrato.Controls.Add(Me.GroupBox3)
        Me.GbDatoContrato.Controls.Add(Me.DtAlta)
        Me.GbDatoContrato.Controls.Add(Me.Label4)
        Me.GbDatoContrato.Controls.Add(Me.TxFolioComprador)
        Me.GbDatoContrato.Controls.Add(Me.Label3)
        Me.GbDatoContrato.Controls.Add(Me.Label2)
        Me.GbDatoContrato.Controls.Add(Me.TxFolioContrato)
        Me.GbDatoContrato.Controls.Add(Me.Label1)
        Me.GbDatoContrato.Location = New System.Drawing.Point(15, 90)
        Me.GbDatoContrato.Name = "GbDatoContrato"
        Me.GbDatoContrato.Size = New System.Drawing.Size(549, 340)
        Me.GbDatoContrato.TabIndex = 0
        Me.GbDatoContrato.TabStop = False
        Me.GbDatoContrato.Text = "Datos del Contrato"
        '
        'CbNombreComprador
        '
        Me.CbNombreComprador.FormattingEnabled = True
        Me.CbNombreComprador.Location = New System.Drawing.Point(157, 83)
        Me.CbNombreComprador.Name = "CbNombreComprador"
        Me.CbNombreComprador.Size = New System.Drawing.Size(386, 24)
        Me.CbNombreComprador.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.LBCodigoSAP)
        Me.GroupBox3.Controls.Add(Me.TBCodigoASERCA)
        Me.GroupBox3.Controls.Add(Me.LBCodigoSIAP)
        Me.GroupBox3.Controls.Add(Me.TBCodigoSAP)
        Me.GroupBox3.Controls.Add(Me.CbMoneda)
        Me.GroupBox3.Controls.Add(Me.DtLiquidacion)
        Me.GroupBox3.Controls.Add(Me.RbMaizLibre)
        Me.GroupBox3.Controls.Add(Me.TBCodigoSIAP)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.CbTemporada)
        Me.GroupBox3.Controls.Add(Me.RbMaizContrato)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxPrecioXtonelada)
        Me.GroupBox3.Controls.Add(Me.TxToneladas)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 113)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(549, 227)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'RbMaizLibre
        '
        Me.RbMaizLibre.AutoSize = True
        Me.RbMaizLibre.Location = New System.Drawing.Point(369, 46)
        Me.RbMaizLibre.Name = "RbMaizLibre"
        Me.RbMaizLibre.Size = New System.Drawing.Size(107, 20)
        Me.RbMaizLibre.TabIndex = 7
        Me.RbMaizLibre.TabStop = True
        Me.RbMaizLibre.Text = "Contrato Libre"
        Me.RbMaizLibre.UseVisualStyleBackColor = True
        '
        'RbMaizContrato
        '
        Me.RbMaizContrato.AutoSize = True
        Me.RbMaizContrato.Location = New System.Drawing.Point(369, 18)
        Me.RbMaizContrato.Name = "RbMaizContrato"
        Me.RbMaizContrato.Size = New System.Drawing.Size(163, 20)
        Me.RbMaizContrato.TabIndex = 0
        Me.RbMaizContrato.TabStop = True
        Me.RbMaizContrato.Text = "Agricultura por Contrato"
        Me.RbMaizContrato.UseVisualStyleBackColor = True
        '
        'CbMoneda
        '
        Me.CbMoneda.FormattingEnabled = True
        Me.CbMoneda.Location = New System.Drawing.Point(286, 46)
        Me.CbMoneda.Name = "CbMoneda"
        Me.CbMoneda.Size = New System.Drawing.Size(62, 24)
        Me.CbMoneda.TabIndex = 3
        '
        'DtLiquidacion
        '
        Me.DtLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtLiquidacion.Location = New System.Drawing.Point(157, 104)
        Me.DtLiquidacion.Name = "DtLiquidacion"
        Me.DtLiquidacion.Size = New System.Drawing.Size(123, 22)
        Me.DtLiquidacion.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Fecha de Liquidación:"
        '
        'CbTemporada
        '
        Me.CbTemporada.Enabled = False
        Me.CbTemporada.FormattingEnabled = True
        Me.CbTemporada.Location = New System.Drawing.Point(157, 74)
        Me.CbTemporada.Name = "CbTemporada"
        Me.CbTemporada.Size = New System.Drawing.Size(123, 24)
        Me.CbTemporada.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(76, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Temporada:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Precio X Tonelada $:"
        '
        'TxPrecioXtonelada
        '
        Me.TxPrecioXtonelada.Location = New System.Drawing.Point(157, 46)
        Me.TxPrecioXtonelada.Name = "TxPrecioXtonelada"
        Me.TxPrecioXtonelada.Size = New System.Drawing.Size(123, 22)
        Me.TxPrecioXtonelada.TabIndex = 2
        Me.TxPrecioXtonelada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxToneladas
        '
        Me.TxToneladas.Location = New System.Drawing.Point(157, 18)
        Me.TxToneladas.Name = "TxToneladas"
        Me.TxToneladas.Size = New System.Drawing.Size(123, 22)
        Me.TxToneladas.TabIndex = 1
        Me.TxToneladas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(81, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Toneladas:"
        '
        'DtAlta
        '
        Me.DtAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtAlta.Location = New System.Drawing.Point(405, 27)
        Me.DtAlta.Name = "DtAlta"
        Me.DtAlta.Size = New System.Drawing.Size(138, 22)
        Me.DtAlta.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de Alta:"
        '
        'TxFolioComprador
        '
        Me.TxFolioComprador.Enabled = False
        Me.TxFolioComprador.Location = New System.Drawing.Point(157, 55)
        Me.TxFolioComprador.Name = "TxFolioComprador"
        Me.TxFolioComprador.Size = New System.Drawing.Size(100, 22)
        Me.TxFolioComprador.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre del Comprador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Folio del Comprador:"
        '
        'TxFolioContrato
        '
        Me.TxFolioContrato.Enabled = False
        Me.TxFolioContrato.Location = New System.Drawing.Point(157, 27)
        Me.TxFolioContrato.Name = "TxFolioContrato"
        Me.TxFolioContrato.Size = New System.Drawing.Size(100, 22)
        Me.TxFolioContrato.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio del Contrato:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgContatoVenta)
        Me.GroupBox1.Location = New System.Drawing.Point(570, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 289)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Contratos"
        '
        'DgContatoVenta
        '
        Me.DgContatoVenta.AllowUserToAddRows = False
        Me.DgContatoVenta.AllowUserToDeleteRows = False
        Me.DgContatoVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgContatoVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgContatoVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgContatoVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgContatoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgContatoVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgContatoVenta.Location = New System.Drawing.Point(6, 21)
        Me.DgContatoVenta.MultiSelect = False
        Me.DgContatoVenta.Name = "DgContatoVenta"
        Me.DgContatoVenta.ReadOnly = True
        Me.DgContatoVenta.RowHeadersVisible = False
        Me.DgContatoVenta.RowHeadersWidth = 40
        Me.DgContatoVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgContatoVenta.Size = New System.Drawing.Size(632, 319)
        Me.DgContatoVenta.TabIndex = 26
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(570, 2)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(105, 1)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(87, 81)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestaurar.Location = New System.Drawing.Point(477, 2)
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
        Me.BtnBuscar.Location = New System.Drawing.Point(291, 1)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(87, 81)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(198, 1)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(87, 81)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(384, 1)
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
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 1)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(87, 81)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'LBCodigoSIAP
        '
        Me.LBCodigoSIAP.AutoSize = True
        Me.LBCodigoSIAP.Location = New System.Drawing.Point(62, 138)
        Me.LBCodigoSIAP.Name = "LBCodigoSIAP"
        Me.LBCodigoSIAP.Size = New System.Drawing.Size(82, 16)
        Me.LBCodigoSIAP.TabIndex = 22
        Me.LBCodigoSIAP.Text = "Código SIAP"
        '
        'LBCodigoSAP
        '
        Me.LBCodigoSAP.AutoSize = True
        Me.LBCodigoSAP.Location = New System.Drawing.Point(62, 163)
        Me.LBCodigoSAP.Name = "LBCodigoSAP"
        Me.LBCodigoSAP.Size = New System.Drawing.Size(79, 16)
        Me.LBCodigoSAP.TabIndex = 23
        Me.LBCodigoSAP.Text = "Código SAP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Contrato ASERCA"
        '
        'TBCodigoSIAP
        '
        Me.TBCodigoSIAP.Location = New System.Drawing.Point(157, 132)
        Me.TBCodigoSIAP.Name = "TBCodigoSIAP"
        Me.TBCodigoSIAP.Size = New System.Drawing.Size(123, 22)
        Me.TBCodigoSIAP.TabIndex = 24
        '
        'TBCodigoSAP
        '
        Me.TBCodigoSAP.Location = New System.Drawing.Point(157, 160)
        Me.TBCodigoSAP.Name = "TBCodigoSAP"
        Me.TBCodigoSAP.Size = New System.Drawing.Size(123, 22)
        Me.TBCodigoSAP.TabIndex = 25
        '
        'TBCodigoASERCA
        '
        Me.TBCodigoASERCA.Location = New System.Drawing.Point(157, 188)
        Me.TBCodigoASERCA.Name = "TBCodigoASERCA"
        Me.TBCodigoASERCA.Size = New System.Drawing.Size(277, 22)
        Me.TBCodigoASERCA.TabIndex = 25
        '
        'ContratosVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 456)
        Me.Controls.Add(Me.GbDatoContrato)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnRestaurar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ContratosVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ContratosVentas"
        Me.GbDatoContrato.ResumeLayout(False)
        Me.GbDatoContrato.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgContatoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbDatoContrato As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DtLiquidacion As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents CbTemporada As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxPrecioXtonelada As TextBox
    Friend WithEvents TxToneladas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DtAlta As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TxFolioComprador As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxFolioContrato As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbNombreComprador As ComboBox
    Friend WithEvents DgContatoVenta As DataGridView
    Friend WithEvents CbMoneda As ComboBox
    Friend WithEvents RbMaizLibre As RadioButton
    Friend WithEvents RbMaizContrato As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents LBCodigoSAP As Label
    Friend WithEvents LBCodigoSIAP As Label
    Friend WithEvents TBCodigoSAP As TextBox
    Friend WithEvents TBCodigoSIAP As TextBox
    Friend WithEvents TBCodigoASERCA As TextBox
End Class
