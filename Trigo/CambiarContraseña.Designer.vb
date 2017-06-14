<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambiarContraseña))
        Me.TxUsuario = New System.Windows.Forms.TextBox()
        Me.TxContraseña = New System.Windows.Forms.TextBox()
        Me.LbContraseña = New System.Windows.Forms.Label()
        Me.LbNomUsu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxNuevaContra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxConfirmaContra = New System.Windows.Forms.TextBox()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.BtCorrecto = New System.Windows.Forms.Button()
        Me.BtIncorrecto = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxUsuario
        '
        Me.TxUsuario.CausesValidation = False
        Me.TxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxUsuario.Location = New System.Drawing.Point(215, 70)
        Me.TxUsuario.MaxLength = 15
        Me.TxUsuario.Name = "TxUsuario"
        Me.TxUsuario.Size = New System.Drawing.Size(155, 20)
        Me.TxUsuario.TabIndex = 3
        '
        'TxContraseña
        '
        Me.TxContraseña.CausesValidation = False
        Me.TxContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxContraseña.Location = New System.Drawing.Point(215, 120)
        Me.TxContraseña.MaxLength = 10
        Me.TxContraseña.Name = "TxContraseña"
        Me.TxContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxContraseña.Size = New System.Drawing.Size(155, 23)
        Me.TxContraseña.TabIndex = 4
        '
        'LbContraseña
        '
        Me.LbContraseña.AutoSize = True
        Me.LbContraseña.Location = New System.Drawing.Point(109, 125)
        Me.LbContraseña.Name = "LbContraseña"
        Me.LbContraseña.Size = New System.Drawing.Size(100, 13)
        Me.LbContraseña.TabIndex = 6
        Me.LbContraseña.Text = "Contraseña Actual :"
        '
        'LbNomUsu
        '
        Me.LbNomUsu.AutoSize = True
        Me.LbNomUsu.Location = New System.Drawing.Point(105, 73)
        Me.LbNomUsu.Name = "LbNomUsu"
        Me.LbNomUsu.Size = New System.Drawing.Size(104, 13)
        Me.LbNomUsu.TabIndex = 5
        Me.LbNomUsu.Text = "Nombre de Usuario :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nueva Contraseña :"
        '
        'TxNuevaContra
        '
        Me.TxNuevaContra.CausesValidation = False
        Me.TxNuevaContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxNuevaContra.Location = New System.Drawing.Point(215, 176)
        Me.TxNuevaContra.MaxLength = 10
        Me.TxNuevaContra.Name = "TxNuevaContra"
        Me.TxNuevaContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxNuevaContra.Size = New System.Drawing.Size(155, 23)
        Me.TxNuevaContra.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Confirma contraseña :"
        '
        'TxConfirmaContra
        '
        Me.TxConfirmaContra.CausesValidation = False
        Me.TxConfirmaContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxConfirmaContra.Location = New System.Drawing.Point(215, 228)
        Me.TxConfirmaContra.MaxLength = 10
        Me.TxConfirmaContra.Name = "TxConfirmaContra"
        Me.TxConfirmaContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxConfirmaContra.Size = New System.Drawing.Size(155, 23)
        Me.TxConfirmaContra.TabIndex = 9
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(307, 328)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(117, 23)
        Me.BtAceptar.TabIndex = 11
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(430, 328)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(117, 23)
        Me.BtCancelar.TabIndex = 11
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'BtCorrecto
        '
        Me.BtCorrecto.Enabled = False
        Me.BtCorrecto.Image = CType(resources.GetObject("BtCorrecto.Image"), System.Drawing.Image)
        Me.BtCorrecto.Location = New System.Drawing.Point(455, 222)
        Me.BtCorrecto.Name = "BtCorrecto"
        Me.BtCorrecto.Size = New System.Drawing.Size(50, 40)
        Me.BtCorrecto.TabIndex = 12
        Me.BtCorrecto.UseVisualStyleBackColor = True
        Me.BtCorrecto.Visible = False
        '
        'BtIncorrecto
        '
        Me.BtIncorrecto.Enabled = False
        Me.BtIncorrecto.Image = CType(resources.GetObject("BtIncorrecto.Image"), System.Drawing.Image)
        Me.BtIncorrecto.Location = New System.Drawing.Point(455, 222)
        Me.BtIncorrecto.Name = "BtIncorrecto"
        Me.BtIncorrecto.Size = New System.Drawing.Size(50, 40)
        Me.BtIncorrecto.TabIndex = 13
        Me.BtIncorrecto.UseVisualStyleBackColor = True
        Me.BtIncorrecto.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 369)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(474, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "La contraseña debe de tener como maximo 10 caracteres."
        '
        'CambiarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 398)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtIncorrecto)
        Me.Controls.Add(Me.BtCorrecto)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxConfirmaContra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxNuevaContra)
        Me.Controls.Add(Me.LbContraseña)
        Me.Controls.Add(Me.LbNomUsu)
        Me.Controls.Add(Me.TxUsuario)
        Me.Controls.Add(Me.TxContraseña)
        Me.Name = "CambiarContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cambiar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxUsuario As TextBox
    Friend WithEvents TxContraseña As TextBox
    Friend WithEvents LbContraseña As Label
    Friend WithEvents LbNomUsu As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxNuevaContra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxConfirmaContra As TextBox
    Friend WithEvents BtAceptar As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents BtCorrecto As Button
    Friend WithEvents BtIncorrecto As Button
    Friend WithEvents Label3 As Label
End Class
