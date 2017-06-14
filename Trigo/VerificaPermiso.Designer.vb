<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerificaPermiso
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
        Me.LbMensaje = New System.Windows.Forms.Label()
        Me.BtAutorizacion = New System.Windows.Forms.Button()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxClaveAutorizacion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LbMensaje
        '
        Me.LbMensaje.AutoSize = True
        Me.LbMensaje.Location = New System.Drawing.Point(68, 43)
        Me.LbMensaje.Name = "LbMensaje"
        Me.LbMensaje.Size = New System.Drawing.Size(108, 13)
        Me.LbMensaje.TabIndex = 0
        Me.LbMensaje.Text = "Mensaje Autorizacion"
        '
        'BtAutorizacion
        '
        Me.BtAutorizacion.Location = New System.Drawing.Point(330, 212)
        Me.BtAutorizacion.Name = "BtAutorizacion"
        Me.BtAutorizacion.Size = New System.Drawing.Size(92, 37)
        Me.BtAutorizacion.TabIndex = 1
        Me.BtAutorizacion.Text = "Autorizar"
        Me.BtAutorizacion.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(453, 212)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(92, 37)
        Me.BtCancelar.TabIndex = 1
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Teclee la clave proporcionada por el gerente si tiene autorizacion."
        '
        'TxClaveAutorizacion
        '
        Me.TxClaveAutorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxClaveAutorizacion.Location = New System.Drawing.Point(330, 165)
        Me.TxClaveAutorizacion.MaxLength = 4
        Me.TxClaveAutorizacion.Name = "TxClaveAutorizacion"
        Me.TxClaveAutorizacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxClaveAutorizacion.Size = New System.Drawing.Size(92, 26)
        Me.TxClaveAutorizacion.TabIndex = 3
        '
        'VerificaPermiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 261)
        Me.Controls.Add(Me.TxClaveAutorizacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.BtAutorizacion)
        Me.Controls.Add(Me.LbMensaje)
        Me.Name = "VerificaPermiso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Verifica Autorización"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbMensaje As Label
    Friend WithEvents BtAutorizacion As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxClaveAutorizacion As TextBox
End Class
