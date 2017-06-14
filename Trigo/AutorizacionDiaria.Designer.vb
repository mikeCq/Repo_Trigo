<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutorizacionDiaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutorizacionDiaria))
        Me.TxClaveAutorizacion = New System.Windows.Forms.TextBox()
        Me.BtActualiza = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxClaveAutorizacion
        '
        Me.TxClaveAutorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxClaveAutorizacion.Location = New System.Drawing.Point(62, 42)
        Me.TxClaveAutorizacion.Name = "TxClaveAutorizacion"
        Me.TxClaveAutorizacion.ReadOnly = True
        Me.TxClaveAutorizacion.Size = New System.Drawing.Size(187, 80)
        Me.TxClaveAutorizacion.TabIndex = 0
        Me.TxClaveAutorizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtActualiza
        '
        Me.BtActualiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtActualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtActualiza.Image = CType(resources.GetObject("BtActualiza.Image"), System.Drawing.Image)
        Me.BtActualiza.Location = New System.Drawing.Point(255, 92)
        Me.BtActualiza.Name = "BtActualiza"
        Me.BtActualiza.Size = New System.Drawing.Size(30, 30)
        Me.BtActualiza.TabIndex = 1
        Me.BtActualiza.UseVisualStyleBackColor = True
        '
        'AutorizacionDiaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 162)
        Me.Controls.Add(Me.BtActualiza)
        Me.Controls.Add(Me.TxClaveAutorizacion)
        Me.Name = "AutorizacionDiaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Autorizacion Diaria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxClaveAutorizacion As TextBox
    Friend WithEvents BtActualiza As Button
End Class
