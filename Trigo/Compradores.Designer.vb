<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compradores
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
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GBCompradores = New System.Windows.Forms.GroupBox()
        Me.GBContacto = New System.Windows.Forms.GroupBox()
        Me.TxCelular = New System.Windows.Forms.MaskedTextBox()
        Me.TxTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.TxCorreo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxContacto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GBDomicilio = New System.Windows.Forms.GroupBox()
        Me.TxNumero = New System.Windows.Forms.TextBox()
        Me.CbCiudad = New System.Windows.Forms.ComboBox()
        Me.CbColonia = New System.Windows.Forms.ComboBox()
        Me.TxCpostal = New System.Windows.Forms.MaskedTextBox()
        Me.TxEstado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxCalle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxRfc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxIdComprador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBCompradores.SuspendLayout()
        Me.GBContacto.SuspendLayout()
        Me.GBDomicilio.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 2)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(87, 84)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(106, 2)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(87, 84)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(201, 2)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(87, 84)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(295, 2)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(87, 84)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(390, 2)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(87, 84)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Location = New System.Drawing.Point(484, 2)
        Me.BtnRestaurar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(87, 84)
        Me.BtnRestaurar.TabIndex = 5
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(579, 2)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(87, 84)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'GBCompradores
        '
        Me.GBCompradores.Controls.Add(Me.GBContacto)
        Me.GBCompradores.Controls.Add(Me.GBDomicilio)
        Me.GBCompradores.Controls.Add(Me.TxRfc)
        Me.GBCompradores.Controls.Add(Me.Label3)
        Me.GBCompradores.Controls.Add(Me.TxNombre)
        Me.GBCompradores.Controls.Add(Me.Label2)
        Me.GBCompradores.Controls.Add(Me.TxIdComprador)
        Me.GBCompradores.Controls.Add(Me.Label1)
        Me.GBCompradores.Location = New System.Drawing.Point(15, 97)
        Me.GBCompradores.Name = "GBCompradores"
        Me.GBCompradores.Size = New System.Drawing.Size(739, 287)
        Me.GBCompradores.TabIndex = 7
        Me.GBCompradores.TabStop = False
        Me.GBCompradores.Text = "Datos del Comprador"
        '
        'GBContacto
        '
        Me.GBContacto.Controls.Add(Me.TxCelular)
        Me.GBContacto.Controls.Add(Me.TxTelefono)
        Me.GBContacto.Controls.Add(Me.TxCorreo)
        Me.GBContacto.Controls.Add(Me.Label13)
        Me.GBContacto.Controls.Add(Me.TxContacto)
        Me.GBContacto.Controls.Add(Me.Label12)
        Me.GBContacto.Controls.Add(Me.Label11)
        Me.GBContacto.Controls.Add(Me.Label10)
        Me.GBContacto.Location = New System.Drawing.Point(0, 199)
        Me.GBContacto.Name = "GBContacto"
        Me.GBContacto.Size = New System.Drawing.Size(739, 88)
        Me.GBContacto.TabIndex = 4
        Me.GBContacto.TabStop = False
        Me.GBContacto.Text = "Datos de Contacto"
        '
        'TxCelular
        '
        Me.TxCelular.Location = New System.Drawing.Point(110, 49)
        Me.TxCelular.Mask = "(999)000-0000"
        Me.TxCelular.Name = "TxCelular"
        Me.TxCelular.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxCelular.Size = New System.Drawing.Size(135, 22)
        Me.TxCelular.TabIndex = 2
        '
        'TxTelefono
        '
        Me.TxTelefono.BeepOnError = True
        Me.TxTelefono.Location = New System.Drawing.Point(594, 21)
        Me.TxTelefono.Mask = "(999)000-0000"
        Me.TxTelefono.Name = "TxTelefono"
        Me.TxTelefono.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxTelefono.Size = New System.Drawing.Size(135, 22)
        Me.TxTelefono.TabIndex = 1
        '
        'TxCorreo
        '
        Me.TxCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCorreo.Location = New System.Drawing.Point(372, 49)
        Me.TxCorreo.Name = "TxCorreo"
        Me.TxCorreo.Size = New System.Drawing.Size(357, 22)
        Me.TxCorreo.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(251, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 16)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Correo Electónico:"
        '
        'TxContacto
        '
        Me.TxContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxContacto.Location = New System.Drawing.Point(110, 21)
        Me.TxContacto.MaxLength = 100
        Me.TxContacto.Name = "TxContacto"
        Me.TxContacto.Size = New System.Drawing.Size(411, 22)
        Me.TxContacto.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(52, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Celular:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(529, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Telefono:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Contacto:"
        '
        'GBDomicilio
        '
        Me.GBDomicilio.Controls.Add(Me.TxNumero)
        Me.GBDomicilio.Controls.Add(Me.CbCiudad)
        Me.GBDomicilio.Controls.Add(Me.CbColonia)
        Me.GBDomicilio.Controls.Add(Me.TxCpostal)
        Me.GBDomicilio.Controls.Add(Me.TxEstado)
        Me.GBDomicilio.Controls.Add(Me.Label7)
        Me.GBDomicilio.Controls.Add(Me.Label6)
        Me.GBDomicilio.Controls.Add(Me.Label9)
        Me.GBDomicilio.Controls.Add(Me.Label5)
        Me.GBDomicilio.Controls.Add(Me.TxCalle)
        Me.GBDomicilio.Controls.Add(Me.Label8)
        Me.GBDomicilio.Controls.Add(Me.Label4)
        Me.GBDomicilio.Location = New System.Drawing.Point(0, 76)
        Me.GBDomicilio.Name = "GBDomicilio"
        Me.GBDomicilio.Size = New System.Drawing.Size(739, 117)
        Me.GBDomicilio.TabIndex = 3
        Me.GBDomicilio.TabStop = False
        Me.GBDomicilio.Text = "Domicilio"
        '
        'TxNumero
        '
        Me.TxNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNumero.Location = New System.Drawing.Point(613, 14)
        Me.TxNumero.Name = "TxNumero"
        Me.TxNumero.Size = New System.Drawing.Size(116, 22)
        Me.TxNumero.TabIndex = 1
        '
        'CbCiudad
        '
        Me.CbCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbCiudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbCiudad.FormattingEnabled = True
        Me.CbCiudad.Location = New System.Drawing.Point(379, 48)
        Me.CbCiudad.MaxLength = 20
        Me.CbCiudad.Name = "CbCiudad"
        Me.CbCiudad.Size = New System.Drawing.Size(163, 24)
        Me.CbCiudad.TabIndex = 3
        '
        'CbColonia
        '
        Me.CbColonia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbColonia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbColonia.FormattingEnabled = True
        Me.CbColonia.Location = New System.Drawing.Point(110, 48)
        Me.CbColonia.MaxLength = 50
        Me.CbColonia.Name = "CbColonia"
        Me.CbColonia.Size = New System.Drawing.Size(205, 24)
        Me.CbColonia.TabIndex = 2
        '
        'TxCpostal
        '
        Me.TxCpostal.Location = New System.Drawing.Point(421, 76)
        Me.TxCpostal.Mask = "00000"
        Me.TxCpostal.Name = "TxCpostal"
        Me.TxCpostal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxCpostal.Size = New System.Drawing.Size(121, 22)
        Me.TxCpostal.TabIndex = 5
        '
        'TxEstado
        '
        Me.TxEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxEstado.Location = New System.Drawing.Point(111, 76)
        Me.TxEstado.Name = "TxEstado"
        Me.TxEstado.Size = New System.Drawing.Size(204, 22)
        Me.TxEstado.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(321, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Ciudad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Colonia:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(322, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Codigo Postal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(550, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Numero:"
        '
        'TxCalle
        '
        Me.TxCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxCalle.Location = New System.Drawing.Point(110, 20)
        Me.TxCalle.MaxLength = 100
        Me.TxCalle.Name = "TxCalle"
        Me.TxCalle.Size = New System.Drawing.Size(432, 22)
        Me.TxCalle.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Estado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Calle:"
        '
        'TxRfc
        '
        Me.TxRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxRfc.Location = New System.Drawing.Point(613, 54)
        Me.TxRfc.Name = "TxRfc"
        Me.TxRfc.Size = New System.Drawing.Size(116, 22)
        Me.TxRfc.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(569, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "RFC:"
        '
        'TxNombre
        '
        Me.TxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxNombre.Location = New System.Drawing.Point(110, 54)
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.Size = New System.Drawing.Size(432, 22)
        Me.TxNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'TxIdComprador
        '
        Me.TxIdComprador.Enabled = False
        Me.TxIdComprador.Location = New System.Drawing.Point(111, 26)
        Me.TxIdComprador.MaxLength = 10
        Me.TxIdComprador.Name = "TxIdComprador"
        Me.TxIdComprador.Size = New System.Drawing.Size(100, 22)
        Me.TxIdComprador.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Comprador:"
        '
        'Compradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 396)
        Me.Controls.Add(Me.GBCompradores)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnRestaurar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Compradores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Compradores"
        Me.GBCompradores.ResumeLayout(False)
        Me.GBCompradores.PerformLayout()
        Me.GBContacto.ResumeLayout(False)
        Me.GBContacto.PerformLayout()
        Me.GBDomicilio.ResumeLayout(False)
        Me.GBDomicilio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents GBCompradores As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GBDomicilio As GroupBox
    Friend WithEvents TxEstado As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxCalle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxRfc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxIdComprador As TextBox
    Friend WithEvents GBContacto As GroupBox
    Friend WithEvents TxCorreo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxContacto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxCpostal As MaskedTextBox
    Friend WithEvents CbCiudad As ComboBox
    Friend WithEvents CbColonia As ComboBox
    Friend WithEvents TxCelular As MaskedTextBox
    Friend WithEvents TxTelefono As MaskedTextBox
    Friend WithEvents TxNumero As TextBox
End Class
