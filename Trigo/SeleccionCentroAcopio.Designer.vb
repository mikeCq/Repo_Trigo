<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionCentroAcopio
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
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.BtSeleccionar = New System.Windows.Forms.Button()
        Me.DgCentrosAcopio = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxNombreCentro = New System.Windows.Forms.TextBox()
        CType(Me.DgCentrosAcopio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(465, 335)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(111, 43)
        Me.BtCancelar.TabIndex = 0
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'BtSeleccionar
        '
        Me.BtSeleccionar.Location = New System.Drawing.Point(331, 335)
        Me.BtSeleccionar.Name = "BtSeleccionar"
        Me.BtSeleccionar.Size = New System.Drawing.Size(111, 43)
        Me.BtSeleccionar.TabIndex = 0
        Me.BtSeleccionar.Text = "Seleccionar"
        Me.BtSeleccionar.UseVisualStyleBackColor = True
        '
        'DgCentrosAcopio
        '
        Me.DgCentrosAcopio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgCentrosAcopio.Location = New System.Drawing.Point(12, 65)
        Me.DgCentrosAcopio.Name = "DgCentrosAcopio"
        Me.DgCentrosAcopio.Size = New System.Drawing.Size(564, 264)
        Me.DgCentrosAcopio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Centro de Acopio :"
        '
        'TxNombreCentro
        '
        Me.TxNombreCentro.Location = New System.Drawing.Point(113, 22)
        Me.TxNombreCentro.Name = "TxNombreCentro"
        Me.TxNombreCentro.Size = New System.Drawing.Size(329, 20)
        Me.TxNombreCentro.TabIndex = 3
        '
        'SeleccionCentroAcopio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 390)
        Me.Controls.Add(Me.TxNombreCentro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgCentrosAcopio)
        Me.Controls.Add(Me.BtSeleccionar)
        Me.Controls.Add(Me.BtCancelar)
        Me.Name = "SeleccionCentroAcopio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Centro de Acopio"
        CType(Me.DgCentrosAcopio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtCancelar As Button
    Friend WithEvents BtSeleccionar As Button
    Friend WithEvents DgCentrosAcopio As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxNombreCentro As TextBox
End Class
