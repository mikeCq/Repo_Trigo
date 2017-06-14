<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
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
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.TCClientes = New System.Windows.Forms.TabControl()
        Me.TPFisicos = New System.Windows.Forms.TabPage()
        Me.GBFisicos = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxNumIdenti = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RbPasMexFisica = New System.Windows.Forms.RadioButton()
        Me.RbCarMilFisica = New System.Windows.Forms.RadioButton()
        Me.RbCreIneFisica = New System.Windows.Forms.RadioButton()
        Me.GBDatosContacto = New System.Windows.Forms.GroupBox()
        Me.BtAgrRep = New System.Windows.Forms.Button()
        Me.TxCelFisica = New System.Windows.Forms.MaskedTextBox()
        Me.TxTelfisica = New System.Windows.Forms.MaskedTextBox()
        Me.TxCorreoFisica = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GBDomicilio = New System.Windows.Forms.GroupBox()
        Me.TxNumDomFisica = New System.Windows.Forms.TextBox()
        Me.CbCiudadFisica = New System.Windows.Forms.ComboBox()
        Me.TxEstadoFisica = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbColoniaFisica = New System.Windows.Forms.ComboBox()
        Me.TxCpFisica = New System.Windows.Forms.TextBox()
        Me.TxCalleFisica = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxApellidos = New System.Windows.Forms.TextBox()
        Me.TxNombre = New System.Windows.Forms.TextBox()
        Me.TxCurp = New System.Windows.Forms.TextBox()
        Me.TxRfcFisico = New System.Windows.Forms.TextBox()
        Me.TxIdFisica = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TPMorales = New System.Windows.Forms.TabPage()
        Me.GbMorales = New System.Windows.Forms.GroupBox()
        Me.GBRepresentante = New System.Windows.Forms.GroupBox()
        Me.BtNueRep = New System.Windows.Forms.Button()
        Me.CbNomRep = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxNumIdeRep = New System.Windows.Forms.MaskedTextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.RbPasMexRep = New System.Windows.Forms.RadioButton()
        Me.RbCarMilRep = New System.Windows.Forms.RadioButton()
        Me.RbCreInerep = New System.Windows.Forms.RadioButton()
        Me.TxCurpRep = New System.Windows.Forms.TextBox()
        Me.TxRfcRep = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GBContacto = New System.Windows.Forms.GroupBox()
        Me.TxCelMoral = New System.Windows.Forms.MaskedTextBox()
        Me.TxTelMoral = New System.Windows.Forms.MaskedTextBox()
        Me.TxEmailMoral = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxCpostalMoral = New System.Windows.Forms.TextBox()
        Me.TxNumDomMoral = New System.Windows.Forms.TextBox()
        Me.CbCiuMoral = New System.Windows.Forms.ComboBox()
        Me.CbColmor = New System.Windows.Forms.ComboBox()
        Me.TxEdoMoral = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxCalleMoral = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GBActa = New System.Windows.Forms.GroupBox()
        Me.TxFolioRpp = New System.Windows.Forms.TextBox()
        Me.TxBajoNumero = New System.Windows.Forms.TextBox()
        Me.TxRegPublico = New System.Windows.Forms.TextBox()
        Me.TxNumNotario = New System.Windows.Forms.TextBox()
        Me.TxFolioAct = New System.Windows.Forms.TextBox()
        Me.DtFechaAct = New System.Windows.Forms.DateTimePicker()
        Me.DtFme = New System.Windows.Forms.DateTimePicker()
        Me.TxFme = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TxLibRpp = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DtIniOpe = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxRazonSocial = New System.Windows.Forms.TextBox()
        Me.TxRfcMoral = New System.Windows.Forms.TextBox()
        Me.TxIdMoral = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RbMoral = New System.Windows.Forms.RadioButton()
        Me.RbFisica = New System.Windows.Forms.RadioButton()
        Me.BtActualizar = New System.Windows.Forms.Button()
        Me.TCClientes.SuspendLayout()
        Me.TPFisicos.SuspendLayout()
        Me.GBFisicos.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GBDatosContacto.SuspendLayout()
        Me.GBDomicilio.SuspendLayout()
        Me.TPMorales.SuspendLayout()
        Me.GbMorales.SuspendLayout()
        Me.GBRepresentante.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GBContacto.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GBActa.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(9, 0)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(87, 84)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(195, 0)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(87, 84)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(102, 0)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(87, 84)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(288, 0)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(87, 84)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(381, 0)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(87, 84)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Location = New System.Drawing.Point(474, 0)
        Me.BtnRestaurar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(87, 84)
        Me.BtnRestaurar.TabIndex = 5
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(567, 0)
        Me.Salir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(87, 84)
        Me.Salir.TabIndex = 6
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'TCClientes
        '
        Me.TCClientes.Controls.Add(Me.TPFisicos)
        Me.TCClientes.Controls.Add(Me.TPMorales)
        Me.TCClientes.Location = New System.Drawing.Point(5, 159)
        Me.TCClientes.Name = "TCClientes"
        Me.TCClientes.SelectedIndex = 0
        Me.TCClientes.Size = New System.Drawing.Size(1071, 572)
        Me.TCClientes.TabIndex = 8
        '
        'TPFisicos
        '
        Me.TPFisicos.BackColor = System.Drawing.SystemColors.Control
        Me.TPFisicos.Controls.Add(Me.GBFisicos)
        Me.TPFisicos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TPFisicos.Location = New System.Drawing.Point(4, 25)
        Me.TPFisicos.Name = "TPFisicos"
        Me.TPFisicos.Padding = New System.Windows.Forms.Padding(3)
        Me.TPFisicos.Size = New System.Drawing.Size(1063, 543)
        Me.TPFisicos.TabIndex = 0
        Me.TPFisicos.Text = "Fisicas"
        '
        'GBFisicos
        '
        Me.GBFisicos.Controls.Add(Me.GroupBox5)
        Me.GBFisicos.Controls.Add(Me.GBDatosContacto)
        Me.GBFisicos.Controls.Add(Me.GBDomicilio)
        Me.GBFisicos.Controls.Add(Me.TxApellidos)
        Me.GBFisicos.Controls.Add(Me.TxNombre)
        Me.GBFisicos.Controls.Add(Me.TxCurp)
        Me.GBFisicos.Controls.Add(Me.TxRfcFisico)
        Me.GBFisicos.Controls.Add(Me.TxIdFisica)
        Me.GBFisicos.Controls.Add(Me.Label4)
        Me.GBFisicos.Controls.Add(Me.Label39)
        Me.GBFisicos.Controls.Add(Me.Label3)
        Me.GBFisicos.Controls.Add(Me.Label2)
        Me.GBFisicos.Controls.Add(Me.Label1)
        Me.GBFisicos.Location = New System.Drawing.Point(6, 6)
        Me.GBFisicos.Name = "GBFisicos"
        Me.GBFisicos.Size = New System.Drawing.Size(1057, 361)
        Me.GBFisicos.TabIndex = 1
        Me.GBFisicos.TabStop = False
        Me.GBFisicos.Text = "Datos del Cliente"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxNumIdenti)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.RbPasMexFisica)
        Me.GroupBox5.Controls.Add(Me.RbCarMilFisica)
        Me.GroupBox5.Controls.Add(Me.RbCreIneFisica)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 115)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1037, 53)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Identificación"
        '
        'TxNumIdenti
        '
        Me.TxNumIdenti.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNumIdenti.Location = New System.Drawing.Point(735, 20)
        Me.TxNumIdenti.MaxLength = 16
        Me.TxNumIdenti.Name = "TxNumIdenti"
        Me.TxNumIdenti.Size = New System.Drawing.Size(230, 22)
        Me.TxNumIdenti.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(575, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Numero de Identificación:"
        '
        'RbPasMexFisica
        '
        Me.RbPasMexFisica.AutoSize = True
        Me.RbPasMexFisica.Location = New System.Drawing.Point(404, 21)
        Me.RbPasMexFisica.Name = "RbPasMexFisica"
        Me.RbPasMexFisica.Size = New System.Drawing.Size(145, 20)
        Me.RbPasMexFisica.TabIndex = 2
        Me.RbPasMexFisica.TabStop = True
        Me.RbPasMexFisica.Text = "Pasaporte Mexicano"
        Me.RbPasMexFisica.UseVisualStyleBackColor = True
        '
        'RbCarMilFisica
        '
        Me.RbCarMilFisica.AutoSize = True
        Me.RbCarMilFisica.Location = New System.Drawing.Point(205, 21)
        Me.RbCarMilFisica.Name = "RbCarMilFisica"
        Me.RbCarMilFisica.Size = New System.Drawing.Size(105, 20)
        Me.RbCarMilFisica.TabIndex = 1
        Me.RbCarMilFisica.TabStop = True
        Me.RbCarMilFisica.Text = "Cartilla Militar"
        Me.RbCarMilFisica.UseVisualStyleBackColor = True
        '
        'RbCreIneFisica
        '
        Me.RbCreIneFisica.AutoSize = True
        Me.RbCreIneFisica.Location = New System.Drawing.Point(6, 21)
        Me.RbCreIneFisica.Name = "RbCreIneFisica"
        Me.RbCreIneFisica.Size = New System.Drawing.Size(112, 20)
        Me.RbCreIneFisica.TabIndex = 0
        Me.RbCreIneFisica.TabStop = True
        Me.RbCreIneFisica.Text = "Credencial INE"
        Me.RbCreIneFisica.UseVisualStyleBackColor = True
        '
        'GBDatosContacto
        '
        Me.GBDatosContacto.Controls.Add(Me.BtAgrRep)
        Me.GBDatosContacto.Controls.Add(Me.TxCelFisica)
        Me.GBDatosContacto.Controls.Add(Me.TxTelfisica)
        Me.GBDatosContacto.Controls.Add(Me.TxCorreoFisica)
        Me.GBDatosContacto.Controls.Add(Me.Label12)
        Me.GBDatosContacto.Controls.Add(Me.Label13)
        Me.GBDatosContacto.Controls.Add(Me.Label14)
        Me.GBDatosContacto.Location = New System.Drawing.Point(0, 269)
        Me.GBDatosContacto.Name = "GBDatosContacto"
        Me.GBDatosContacto.Size = New System.Drawing.Size(1037, 92)
        Me.GBDatosContacto.TabIndex = 7
        Me.GBDatosContacto.TabStop = False
        Me.GBDatosContacto.Text = "Datos de Contacto"
        '
        'BtAgrRep
        '
        Me.BtAgrRep.Location = New System.Drawing.Point(638, 21)
        Me.BtAgrRep.Name = "BtAgrRep"
        Me.BtAgrRep.Size = New System.Drawing.Size(119, 51)
        Me.BtAgrRep.TabIndex = 5
        Me.BtAgrRep.Text = "Agregar Representante"
        Me.BtAgrRep.UseVisualStyleBackColor = True
        Me.BtAgrRep.Visible = False
        '
        'TxCelFisica
        '
        Me.TxCelFisica.Location = New System.Drawing.Point(364, 49)
        Me.TxCelFisica.Mask = "(999)000-0000"
        Me.TxCelFisica.Name = "TxCelFisica"
        Me.TxCelFisica.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxCelFisica.Size = New System.Drawing.Size(174, 22)
        Me.TxCelFisica.TabIndex = 2
        '
        'TxTelfisica
        '
        Me.TxTelfisica.Location = New System.Drawing.Point(126, 49)
        Me.TxTelfisica.Mask = "(999)000-0000"
        Me.TxTelfisica.Name = "TxTelfisica"
        Me.TxTelfisica.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxTelfisica.Size = New System.Drawing.Size(174, 22)
        Me.TxTelfisica.TabIndex = 1
        '
        'TxCorreoFisica
        '
        Me.TxCorreoFisica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCorreoFisica.Location = New System.Drawing.Point(126, 21)
        Me.TxCorreoFisica.MaxLength = 200
        Me.TxCorreoFisica.Name = "TxCorreoFisica"
        Me.TxCorreoFisica.Size = New System.Drawing.Size(412, 22)
        Me.TxCorreoFisica.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(61, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Telefono:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(306, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Celular:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Correo Electrónico:"
        '
        'GBDomicilio
        '
        Me.GBDomicilio.Controls.Add(Me.TxNumDomFisica)
        Me.GBDomicilio.Controls.Add(Me.CbCiudadFisica)
        Me.GBDomicilio.Controls.Add(Me.TxEstadoFisica)
        Me.GBDomicilio.Controls.Add(Me.Label9)
        Me.GBDomicilio.Controls.Add(Me.Label8)
        Me.GBDomicilio.Controls.Add(Me.CbColoniaFisica)
        Me.GBDomicilio.Controls.Add(Me.TxCpFisica)
        Me.GBDomicilio.Controls.Add(Me.TxCalleFisica)
        Me.GBDomicilio.Controls.Add(Me.Label11)
        Me.GBDomicilio.Controls.Add(Me.Label10)
        Me.GBDomicilio.Controls.Add(Me.Label7)
        Me.GBDomicilio.Controls.Add(Me.Label6)
        Me.GBDomicilio.Location = New System.Drawing.Point(0, 174)
        Me.GBDomicilio.Name = "GBDomicilio"
        Me.GBDomicilio.Size = New System.Drawing.Size(1037, 89)
        Me.GBDomicilio.TabIndex = 6
        Me.GBDomicilio.TabStop = False
        Me.GBDomicilio.Text = "Domicilio"
        '
        'TxNumDomFisica
        '
        Me.TxNumDomFisica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNumDomFisica.Location = New System.Drawing.Point(545, 26)
        Me.TxNumDomFisica.MaxLength = 6
        Me.TxNumDomFisica.Name = "TxNumDomFisica"
        Me.TxNumDomFisica.Size = New System.Drawing.Size(100, 22)
        Me.TxNumDomFisica.TabIndex = 1
        '
        'CbCiudadFisica
        '
        Me.CbCiudadFisica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbCiudadFisica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbCiudadFisica.DropDownHeight = 100
        Me.CbCiudadFisica.FormattingEnabled = True
        Me.CbCiudadFisica.IntegralHeight = False
        Me.CbCiudadFisica.Location = New System.Drawing.Point(274, 53)
        Me.CbCiudadFisica.MaxDropDownItems = 6
        Me.CbCiudadFisica.MaxLength = 20
        Me.CbCiudadFisica.Name = "CbCiudadFisica"
        Me.CbCiudadFisica.Size = New System.Drawing.Size(204, 24)
        Me.CbCiudadFisica.TabIndex = 4
        '
        'TxEstadoFisica
        '
        Me.TxEstadoFisica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEstadoFisica.Location = New System.Drawing.Point(545, 53)
        Me.TxEstadoFisica.MaxLength = 20
        Me.TxEstadoFisica.Name = "TxEstadoFisica"
        Me.TxEstadoFisica.Size = New System.Drawing.Size(212, 22)
        Me.TxEstadoFisica.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(216, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Ciudad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(486, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Estado:"
        '
        'CbColoniaFisica
        '
        Me.CbColoniaFisica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbColoniaFisica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbColoniaFisica.DropDownHeight = 100
        Me.CbColoniaFisica.FormattingEnabled = True
        Me.CbColoniaFisica.IntegralHeight = False
        Me.CbColoniaFisica.Location = New System.Drawing.Point(729, 26)
        Me.CbColoniaFisica.MaxDropDownItems = 6
        Me.CbColoniaFisica.MaxLength = 50
        Me.CbColoniaFisica.Name = "CbColoniaFisica"
        Me.CbColoniaFisica.Size = New System.Drawing.Size(208, 24)
        Me.CbColoniaFisica.TabIndex = 2
        '
        'TxCpFisica
        '
        Me.TxCpFisica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCpFisica.Location = New System.Drawing.Point(105, 53)
        Me.TxCpFisica.MaxLength = 5
        Me.TxCpFisica.Name = "TxCpFisica"
        Me.TxCpFisica.Size = New System.Drawing.Size(101, 22)
        Me.TxCpFisica.TabIndex = 3
        '
        'TxCalleFisica
        '
        Me.TxCalleFisica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCalleFisica.Location = New System.Drawing.Point(105, 26)
        Me.TxCalleFisica.MaxLength = 50
        Me.TxCalleFisica.Name = "TxCalleFisica"
        Me.TxCalleFisica.Size = New System.Drawing.Size(373, 22)
        Me.TxCalleFisica.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Codigo Postal:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(668, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Colonia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(482, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Numero:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Calle:"
        '
        'TxApellidos
        '
        Me.TxApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxApellidos.Location = New System.Drawing.Point(547, 59)
        Me.TxApellidos.MaxLength = 100
        Me.TxApellidos.Name = "TxApellidos"
        Me.TxApellidos.Size = New System.Drawing.Size(418, 22)
        Me.TxApellidos.TabIndex = 2
        '
        'TxNombre
        '
        Me.TxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNombre.Location = New System.Drawing.Point(92, 59)
        Me.TxNombre.MaxLength = 100
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.Size = New System.Drawing.Size(363, 22)
        Me.TxNombre.TabIndex = 1
        '
        'TxCurp
        '
        Me.TxCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCurp.Location = New System.Drawing.Point(299, 87)
        Me.TxCurp.MaxLength = 18
        Me.TxCurp.Name = "TxCurp"
        Me.TxCurp.Size = New System.Drawing.Size(285, 22)
        Me.TxCurp.TabIndex = 4
        '
        'TxRfcFisico
        '
        Me.TxRfcFisico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxRfcFisico.Location = New System.Drawing.Point(92, 87)
        Me.TxRfcFisico.MaxLength = 13
        Me.TxRfcFisico.Name = "TxRfcFisico"
        Me.TxRfcFisico.Size = New System.Drawing.Size(147, 22)
        Me.TxRfcFisico.TabIndex = 3
        '
        'TxIdFisica
        '
        Me.TxIdFisica.Enabled = False
        Me.TxIdFisica.Location = New System.Drawing.Point(92, 31)
        Me.TxIdFisica.Name = "TxIdFisica"
        Me.TxIdFisica.Size = New System.Drawing.Size(122, 22)
        Me.TxIdFisica.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CURP:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(461, 62)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(77, 16)
        Me.Label39.TabIndex = 1
        Me.Label39.Text = "Apellido(s) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RFC :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre(s) :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id. Cliente:"
        '
        'TPMorales
        '
        Me.TPMorales.BackColor = System.Drawing.SystemColors.Control
        Me.TPMorales.Controls.Add(Me.GbMorales)
        Me.TPMorales.Location = New System.Drawing.Point(4, 25)
        Me.TPMorales.Name = "TPMorales"
        Me.TPMorales.Padding = New System.Windows.Forms.Padding(3)
        Me.TPMorales.Size = New System.Drawing.Size(1063, 543)
        Me.TPMorales.TabIndex = 1
        Me.TPMorales.Text = "Morales"
        '
        'GbMorales
        '
        Me.GbMorales.Controls.Add(Me.GBRepresentante)
        Me.GbMorales.Controls.Add(Me.GBContacto)
        Me.GbMorales.Controls.Add(Me.GroupBox3)
        Me.GbMorales.Controls.Add(Me.GBActa)
        Me.GbMorales.Controls.Add(Me.DtIniOpe)
        Me.GbMorales.Controls.Add(Me.Label24)
        Me.GbMorales.Controls.Add(Me.TxRazonSocial)
        Me.GbMorales.Controls.Add(Me.TxRfcMoral)
        Me.GbMorales.Controls.Add(Me.TxIdMoral)
        Me.GbMorales.Controls.Add(Me.Label26)
        Me.GbMorales.Controls.Add(Me.Label27)
        Me.GbMorales.Controls.Add(Me.Label28)
        Me.GbMorales.Location = New System.Drawing.Point(6, 6)
        Me.GbMorales.Name = "GbMorales"
        Me.GbMorales.Size = New System.Drawing.Size(1037, 534)
        Me.GbMorales.TabIndex = 0
        Me.GbMorales.TabStop = False
        Me.GbMorales.Text = "Datos del Cliente"
        '
        'GBRepresentante
        '
        Me.GBRepresentante.Controls.Add(Me.BtNueRep)
        Me.GBRepresentante.Controls.Add(Me.CbNomRep)
        Me.GBRepresentante.Controls.Add(Me.GroupBox2)
        Me.GBRepresentante.Controls.Add(Me.TxCurpRep)
        Me.GBRepresentante.Controls.Add(Me.TxRfcRep)
        Me.GBRepresentante.Controls.Add(Me.Label36)
        Me.GBRepresentante.Controls.Add(Me.Label37)
        Me.GBRepresentante.Controls.Add(Me.Label38)
        Me.GBRepresentante.Location = New System.Drawing.Point(0, 388)
        Me.GBRepresentante.Name = "GBRepresentante"
        Me.GBRepresentante.Size = New System.Drawing.Size(1037, 146)
        Me.GBRepresentante.TabIndex = 6
        Me.GBRepresentante.TabStop = False
        Me.GBRepresentante.Text = "Apoderado o Representante Legal "
        '
        'BtNueRep
        '
        Me.BtNueRep.Location = New System.Drawing.Point(602, 25)
        Me.BtNueRep.Name = "BtNueRep"
        Me.BtNueRep.Size = New System.Drawing.Size(72, 23)
        Me.BtNueRep.TabIndex = 1
        Me.BtNueRep.Text = "Nvo Rep"
        Me.BtNueRep.UseVisualStyleBackColor = True
        '
        'CbNomRep
        '
        Me.CbNomRep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbNomRep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbNomRep.DropDownHeight = 100
        Me.CbNomRep.DropDownWidth = 150
        Me.CbNomRep.FormattingEnabled = True
        Me.CbNomRep.IntegralHeight = False
        Me.CbNomRep.Location = New System.Drawing.Point(67, 25)
        Me.CbNomRep.MaxDropDownItems = 6
        Me.CbNomRep.MaxLength = 150
        Me.CbNomRep.Name = "CbNomRep"
        Me.CbNomRep.Size = New System.Drawing.Size(527, 24)
        Me.CbNomRep.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxNumIdeRep)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.RbPasMexRep)
        Me.GroupBox2.Controls.Add(Me.RbCarMilRep)
        Me.GroupBox2.Controls.Add(Me.RbCreInerep)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(0, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1037, 53)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Identificación"
        '
        'TxNumIdeRep
        '
        Me.TxNumIdeRep.Location = New System.Drawing.Point(801, 20)
        Me.TxNumIdeRep.Mask = "9999999999999999"
        Me.TxNumIdeRep.Name = "TxNumIdeRep"
        Me.TxNumIdeRep.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxNumIdeRep.Size = New System.Drawing.Size(230, 22)
        Me.TxNumIdeRep.TabIndex = 3
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(641, 23)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(154, 16)
        Me.Label35.TabIndex = 3
        Me.Label35.Text = "Numero de Identificación:"
        '
        'RbPasMexRep
        '
        Me.RbPasMexRep.AutoSize = True
        Me.RbPasMexRep.Location = New System.Drawing.Point(427, 21)
        Me.RbPasMexRep.Name = "RbPasMexRep"
        Me.RbPasMexRep.Size = New System.Drawing.Size(145, 20)
        Me.RbPasMexRep.TabIndex = 2
        Me.RbPasMexRep.TabStop = True
        Me.RbPasMexRep.Text = "Pasaporte Mexicano"
        Me.RbPasMexRep.UseVisualStyleBackColor = True
        '
        'RbCarMilRep
        '
        Me.RbCarMilRep.AutoSize = True
        Me.RbCarMilRep.Location = New System.Drawing.Point(212, 21)
        Me.RbCarMilRep.Name = "RbCarMilRep"
        Me.RbCarMilRep.Size = New System.Drawing.Size(105, 20)
        Me.RbCarMilRep.TabIndex = 1
        Me.RbCarMilRep.TabStop = True
        Me.RbCarMilRep.Text = "Cartilla Militar"
        Me.RbCarMilRep.UseVisualStyleBackColor = True
        '
        'RbCreInerep
        '
        Me.RbCreInerep.AutoSize = True
        Me.RbCreInerep.Location = New System.Drawing.Point(6, 21)
        Me.RbCreInerep.Name = "RbCreInerep"
        Me.RbCreInerep.Size = New System.Drawing.Size(112, 20)
        Me.RbCreInerep.TabIndex = 0
        Me.RbCreInerep.TabStop = True
        Me.RbCreInerep.Text = "Credencial INE"
        Me.RbCreInerep.UseVisualStyleBackColor = True
        '
        'TxCurpRep
        '
        Me.TxCurpRep.Enabled = False
        Me.TxCurpRep.Location = New System.Drawing.Point(322, 55)
        Me.TxCurpRep.MaxLength = 18
        Me.TxCurpRep.Name = "TxCurpRep"
        Me.TxCurpRep.Size = New System.Drawing.Size(272, 22)
        Me.TxCurpRep.TabIndex = 2
        '
        'TxRfcRep
        '
        Me.TxRfcRep.Enabled = False
        Me.TxRfcRep.Location = New System.Drawing.Point(67, 55)
        Me.TxRfcRep.MaxLength = 13
        Me.TxRfcRep.Name = "TxRfcRep"
        Me.TxRfcRep.Size = New System.Drawing.Size(186, 22)
        Me.TxRfcRep.TabIndex = 1
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(268, 58)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 16)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "CURP:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(22, 58)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(38, 16)
        Me.Label37.TabIndex = 11
        Me.Label37.Text = "RFC:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 28)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(57, 16)
        Me.Label38.TabIndex = 10
        Me.Label38.Text = "Nombre:"
        '
        'GBContacto
        '
        Me.GBContacto.Controls.Add(Me.TxCelMoral)
        Me.GBContacto.Controls.Add(Me.TxTelMoral)
        Me.GBContacto.Controls.Add(Me.TxEmailMoral)
        Me.GBContacto.Controls.Add(Me.Label15)
        Me.GBContacto.Controls.Add(Me.Label16)
        Me.GBContacto.Controls.Add(Me.Label17)
        Me.GBContacto.Location = New System.Drawing.Point(0, 322)
        Me.GBContacto.Name = "GBContacto"
        Me.GBContacto.Size = New System.Drawing.Size(1037, 60)
        Me.GBContacto.TabIndex = 5
        Me.GBContacto.TabStop = False
        Me.GBContacto.Text = "Datos de Contacto"
        '
        'TxCelMoral
        '
        Me.TxCelMoral.Location = New System.Drawing.Point(309, 29)
        Me.TxCelMoral.Mask = "(999)000-0000"
        Me.TxCelMoral.Name = "TxCelMoral"
        Me.TxCelMoral.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxCelMoral.Size = New System.Drawing.Size(174, 22)
        Me.TxCelMoral.TabIndex = 1
        '
        'TxTelMoral
        '
        Me.TxTelMoral.Location = New System.Drawing.Point(71, 29)
        Me.TxTelMoral.Mask = "(999)000-0000"
        Me.TxTelMoral.Name = "TxTelMoral"
        Me.TxTelMoral.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxTelMoral.Size = New System.Drawing.Size(174, 22)
        Me.TxTelMoral.TabIndex = 0
        '
        'TxEmailMoral
        '
        Me.TxEmailMoral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEmailMoral.Location = New System.Drawing.Point(610, 29)
        Me.TxEmailMoral.MaxLength = 200
        Me.TxEmailMoral.Name = "TxEmailMoral"
        Me.TxEmailMoral.Size = New System.Drawing.Size(421, 22)
        Me.TxEmailMoral.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 16)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Telefono:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(251, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 16)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Celular:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(489, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(119, 16)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Correo Electrónico:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxCpostalMoral)
        Me.GroupBox3.Controls.Add(Me.TxNumDomMoral)
        Me.GroupBox3.Controls.Add(Me.CbCiuMoral)
        Me.GroupBox3.Controls.Add(Me.CbColmor)
        Me.GroupBox3.Controls.Add(Me.TxEdoMoral)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.TxCalleMoral)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1037, 89)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Domicilio"
        '
        'TxCpostalMoral
        '
        Me.TxCpostalMoral.Location = New System.Drawing.Point(350, 53)
        Me.TxCpostalMoral.MaxLength = 5
        Me.TxCpostalMoral.Name = "TxCpostalMoral"
        Me.TxCpostalMoral.Size = New System.Drawing.Size(100, 22)
        Me.TxCpostalMoral.TabIndex = 3
        '
        'TxNumDomMoral
        '
        Me.TxNumDomMoral.Location = New System.Drawing.Point(550, 26)
        Me.TxNumDomMoral.MaxLength = 6
        Me.TxNumDomMoral.Name = "TxNumDomMoral"
        Me.TxNumDomMoral.Size = New System.Drawing.Size(100, 22)
        Me.TxNumDomMoral.TabIndex = 1
        '
        'CbCiuMoral
        '
        Me.CbCiuMoral.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbCiuMoral.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbCiuMoral.FormattingEnabled = True
        Me.CbCiuMoral.Location = New System.Drawing.Point(550, 53)
        Me.CbCiuMoral.MaxLength = 20
        Me.CbCiuMoral.Name = "CbCiuMoral"
        Me.CbCiuMoral.Size = New System.Drawing.Size(204, 24)
        Me.CbCiuMoral.TabIndex = 4
        '
        'CbColmor
        '
        Me.CbColmor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbColmor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbColmor.DropDownHeight = 100
        Me.CbColmor.FormattingEnabled = True
        Me.CbColmor.IntegralHeight = False
        Me.CbColmor.Location = New System.Drawing.Point(67, 53)
        Me.CbColmor.MaxDropDownItems = 6
        Me.CbColmor.MaxLength = 50
        Me.CbColmor.Name = "CbColmor"
        Me.CbColmor.Size = New System.Drawing.Size(178, 24)
        Me.CbColmor.TabIndex = 2
        '
        'TxEdoMoral
        '
        Me.TxEdoMoral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEdoMoral.Location = New System.Drawing.Point(819, 53)
        Me.TxEdoMoral.MaxLength = 20
        Me.TxEdoMoral.Name = "TxEdoMoral"
        Me.TxEdoMoral.Size = New System.Drawing.Size(212, 22)
        Me.TxEdoMoral.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(492, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 16)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Ciudad:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(760, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 16)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Estado:"
        '
        'TxCalleMoral
        '
        Me.TxCalleMoral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCalleMoral.Location = New System.Drawing.Point(67, 26)
        Me.TxCalleMoral.MaxLength = 50
        Me.TxCalleMoral.Name = "TxCalleMoral"
        Me.TxCalleMoral.Size = New System.Drawing.Size(414, 22)
        Me.TxCalleMoral.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(251, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 16)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Codigo Postal:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 16)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Colonia:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(487, 29)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(57, 16)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Numero:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(20, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 16)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Calle:"
        '
        'GBActa
        '
        Me.GBActa.Controls.Add(Me.TxFolioRpp)
        Me.GBActa.Controls.Add(Me.TxBajoNumero)
        Me.GBActa.Controls.Add(Me.TxRegPublico)
        Me.GBActa.Controls.Add(Me.TxNumNotario)
        Me.GBActa.Controls.Add(Me.TxFolioAct)
        Me.GBActa.Controls.Add(Me.DtFechaAct)
        Me.GBActa.Controls.Add(Me.DtFme)
        Me.GBActa.Controls.Add(Me.TxFme)
        Me.GBActa.Controls.Add(Me.Label34)
        Me.GBActa.Controls.Add(Me.Label33)
        Me.GBActa.Controls.Add(Me.TxLibRpp)
        Me.GBActa.Controls.Add(Me.Label32)
        Me.GBActa.Controls.Add(Me.Label31)
        Me.GBActa.Controls.Add(Me.Label30)
        Me.GBActa.Controls.Add(Me.Label29)
        Me.GBActa.Controls.Add(Me.Label41)
        Me.GBActa.Controls.Add(Me.Label40)
        Me.GBActa.Controls.Add(Me.Label25)
        Me.GBActa.Location = New System.Drawing.Point(0, 85)
        Me.GBActa.Name = "GBActa"
        Me.GBActa.Size = New System.Drawing.Size(1037, 136)
        Me.GBActa.TabIndex = 3
        Me.GBActa.TabStop = False
        Me.GBActa.Text = "Acta Constitutiva"
        '
        'TxFolioRpp
        '
        Me.TxFolioRpp.Location = New System.Drawing.Point(85, 87)
        Me.TxFolioRpp.MaxLength = 8
        Me.TxFolioRpp.Name = "TxFolioRpp"
        Me.TxFolioRpp.Size = New System.Drawing.Size(100, 22)
        Me.TxFolioRpp.TabIndex = 5
        '
        'TxBajoNumero
        '
        Me.TxBajoNumero.Location = New System.Drawing.Point(608, 57)
        Me.TxBajoNumero.MaxLength = 8
        Me.TxBajoNumero.Name = "TxBajoNumero"
        Me.TxBajoNumero.Size = New System.Drawing.Size(102, 22)
        Me.TxBajoNumero.TabIndex = 4
        '
        'TxRegPublico
        '
        Me.TxRegPublico.Location = New System.Drawing.Point(323, 57)
        Me.TxRegPublico.MaxLength = 4
        Me.TxRegPublico.Name = "TxRegPublico"
        Me.TxRegPublico.Size = New System.Drawing.Size(102, 22)
        Me.TxRegPublico.TabIndex = 3
        '
        'TxNumNotario
        '
        Me.TxNumNotario.Location = New System.Drawing.Point(85, 57)
        Me.TxNumNotario.MaxLength = 8
        Me.TxNumNotario.Name = "TxNumNotario"
        Me.TxNumNotario.Size = New System.Drawing.Size(100, 22)
        Me.TxNumNotario.TabIndex = 2
        '
        'TxFolioAct
        '
        Me.TxFolioAct.Location = New System.Drawing.Point(85, 29)
        Me.TxFolioAct.MaxLength = 6
        Me.TxFolioAct.Name = "TxFolioAct"
        Me.TxFolioAct.Size = New System.Drawing.Size(64, 22)
        Me.TxFolioAct.TabIndex = 0
        '
        'DtFechaAct
        '
        Me.DtFechaAct.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaAct.Location = New System.Drawing.Point(323, 29)
        Me.DtFechaAct.Name = "DtFechaAct"
        Me.DtFechaAct.Size = New System.Drawing.Size(102, 22)
        Me.DtFechaAct.TabIndex = 1
        '
        'DtFme
        '
        Me.DtFme.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFme.Location = New System.Drawing.Point(835, 85)
        Me.DtFme.Name = "DtFme"
        Me.DtFme.Size = New System.Drawing.Size(106, 22)
        Me.DtFme.TabIndex = 8
        '
        'TxFme
        '
        Me.TxFme.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFme.Location = New System.Drawing.Point(608, 85)
        Me.TxFme.MaxLength = 10
        Me.TxFme.Name = "TxFme"
        Me.TxFme.Size = New System.Drawing.Size(146, 22)
        Me.TxFme.TabIndex = 7
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(781, 88)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(48, 16)
        Me.Label34.TabIndex = 11
        Me.Label34.Text = "Fecha:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(436, 88)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(166, 16)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "Folio Mercantil Electrónico:"
        '
        'TxLibRpp
        '
        Me.TxLibRpp.Location = New System.Drawing.Point(322, 85)
        Me.TxLibRpp.MaxLength = 8
        Me.TxLibRpp.Name = "TxLibRpp"
        Me.TxLibRpp.Size = New System.Drawing.Size(103, 22)
        Me.TxLibRpp.TabIndex = 6
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(253, 88)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(63, 16)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Del Libro:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(501, 60)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(101, 16)
        Me.Label31.TabIndex = 3
        Me.Label31.Text = "Bajo el Numero:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(39, 88)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(40, 16)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Folio:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(191, 60)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(125, 16)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Registro Publico de:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(171, 32)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(146, 16)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Fecha de Constitucion :"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(35, 32)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(44, 16)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "Folio :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 60)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Notario No :"
        '
        'DtIniOpe
        '
        Me.DtIniOpe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtIniOpe.Location = New System.Drawing.Point(835, 57)
        Me.DtIniOpe.Name = "DtIniOpe"
        Me.DtIniOpe.Size = New System.Drawing.Size(109, 22)
        Me.DtIniOpe.TabIndex = 2
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(692, 62)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(137, 16)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Inicio de Operaciones:"
        '
        'TxRazonSocial
        '
        Me.TxRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxRazonSocial.Location = New System.Drawing.Point(101, 59)
        Me.TxRazonSocial.MaxLength = 100
        Me.TxRazonSocial.Name = "TxRazonSocial"
        Me.TxRazonSocial.Size = New System.Drawing.Size(394, 22)
        Me.TxRazonSocial.TabIndex = 0
        '
        'TxRfcMoral
        '
        Me.TxRfcMoral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxRfcMoral.Location = New System.Drawing.Point(539, 59)
        Me.TxRfcMoral.MaxLength = 13
        Me.TxRfcMoral.Name = "TxRfcMoral"
        Me.TxRfcMoral.Size = New System.Drawing.Size(147, 22)
        Me.TxRfcMoral.TabIndex = 1
        '
        'TxIdMoral
        '
        Me.TxIdMoral.Enabled = False
        Me.TxIdMoral.Location = New System.Drawing.Point(101, 24)
        Me.TxIdMoral.Name = "TxIdMoral"
        Me.TxIdMoral.Size = New System.Drawing.Size(122, 22)
        Me.TxIdMoral.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(501, 62)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(38, 16)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "RFC:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 62)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(89, 16)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Razon Social:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(25, 27)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(70, 16)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Id. Cliente:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RbMoral)
        Me.GroupBox4.Controls.Add(Me.RbFisica)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 91)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(272, 62)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Elegir Tipo de Cliente"
        '
        'RbMoral
        '
        Me.RbMoral.AutoSize = True
        Me.RbMoral.Location = New System.Drawing.Point(155, 28)
        Me.RbMoral.Name = "RbMoral"
        Me.RbMoral.Size = New System.Drawing.Size(110, 20)
        Me.RbMoral.TabIndex = 1
        Me.RbMoral.TabStop = True
        Me.RbMoral.Text = "Persona Moral"
        Me.RbMoral.UseVisualStyleBackColor = True
        '
        'RbFisica
        '
        Me.RbFisica.AutoSize = True
        Me.RbFisica.Location = New System.Drawing.Point(13, 28)
        Me.RbFisica.Name = "RbFisica"
        Me.RbFisica.Size = New System.Drawing.Size(113, 20)
        Me.RbFisica.TabIndex = 0
        Me.RbFisica.TabStop = True
        Me.RbFisica.Text = "Persona Física"
        Me.RbFisica.UseVisualStyleBackColor = True
        '
        'BtActualizar
        '
        Me.BtActualizar.Enabled = False
        Me.BtActualizar.Location = New System.Drawing.Point(950, 150)
        Me.BtActualizar.Name = "BtActualizar"
        Me.BtActualizar.Size = New System.Drawing.Size(118, 28)
        Me.BtActualizar.TabIndex = 9
        Me.BtActualizar.Text = "Actualizar"
        Me.BtActualizar.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 733)
        Me.Controls.Add(Me.BtActualizar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TCClientes)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.BtnRestaurar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Productores"
        Me.TCClientes.ResumeLayout(False)
        Me.TPFisicos.ResumeLayout(False)
        Me.GBFisicos.ResumeLayout(False)
        Me.GBFisicos.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GBDatosContacto.ResumeLayout(False)
        Me.GBDatosContacto.PerformLayout()
        Me.GBDomicilio.ResumeLayout(False)
        Me.GBDomicilio.PerformLayout()
        Me.TPMorales.ResumeLayout(False)
        Me.GbMorales.ResumeLayout(False)
        Me.GbMorales.PerformLayout()
        Me.GBRepresentante.ResumeLayout(False)
        Me.GBRepresentante.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GBContacto.ResumeLayout(False)
        Me.GBContacto.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GBActa.ResumeLayout(False)
        Me.GBActa.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents TCClientes As TabControl
    Friend WithEvents TPFisicos As TabPage
    Friend WithEvents TPMorales As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RbMoral As RadioButton
    Friend WithEvents RbFisica As RadioButton
    Friend WithEvents GBFisicos As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RbPasMexFisica As RadioButton
    Friend WithEvents RbCarMilFisica As RadioButton
    Friend WithEvents RbCreIneFisica As RadioButton
    Friend WithEvents GBDatosContacto As GroupBox
    Friend WithEvents TxCelFisica As MaskedTextBox
    Friend WithEvents TxTelfisica As MaskedTextBox
    Friend WithEvents TxCorreoFisica As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GBDomicilio As GroupBox
    Friend WithEvents CbCiudadFisica As ComboBox
    Friend WithEvents TxEstadoFisica As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CbColoniaFisica As ComboBox
    Friend WithEvents TxCpFisica As TextBox
    Friend WithEvents TxCalleFisica As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxApellidos As TextBox
    Friend WithEvents TxNombre As TextBox
    Friend WithEvents TxCurp As TextBox
    Friend WithEvents TxRfcFisico As TextBox
    Friend WithEvents TxIdFisica As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GbMorales As GroupBox
    Friend WithEvents GBRepresentante As GroupBox
    Friend WithEvents BtNueRep As Button
    Friend WithEvents CbNomRep As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxNumIdeRep As MaskedTextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents RbPasMexRep As RadioButton
    Friend WithEvents RbCarMilRep As RadioButton
    Friend WithEvents RbCreInerep As RadioButton
    Friend WithEvents TxCurpRep As TextBox
    Friend WithEvents TxRfcRep As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents GBContacto As GroupBox
    Friend WithEvents TxCelMoral As MaskedTextBox
    Friend WithEvents TxTelMoral As MaskedTextBox
    Friend WithEvents TxEmailMoral As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CbCiuMoral As ComboBox
    Friend WithEvents CbColmor As ComboBox
    Friend WithEvents TxEdoMoral As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TxCalleMoral As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents GBActa As GroupBox
    Friend WithEvents DtFechaAct As DateTimePicker
    Friend WithEvents DtFme As DateTimePicker
    Friend WithEvents TxFme As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents TxLibRpp As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents DtIniOpe As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents TxRazonSocial As TextBox
    Friend WithEvents TxRfcMoral As TextBox
    Friend WithEvents TxIdMoral As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents BtAgrRep As Button
    Friend WithEvents BtActualizar As Button
    Friend WithEvents TxNumDomFisica As TextBox
    Friend WithEvents TxNumDomMoral As TextBox
    Friend WithEvents TxCpostalMoral As TextBox
    Friend WithEvents TxNumIdenti As TextBox
    Friend WithEvents TxNumNotario As TextBox
    Friend WithEvents TxFolioAct As TextBox
    Friend WithEvents TxBajoNumero As TextBox
    Friend WithEvents TxRegPublico As TextBox
    Friend WithEvents TxFolioRpp As TextBox
End Class
