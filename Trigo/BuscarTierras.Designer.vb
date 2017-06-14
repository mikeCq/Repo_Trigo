<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarTierras
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
        Me.DgBuscar = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxNumeroLote = New System.Windows.Forms.TextBox()
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.BtSeleccionar = New System.Windows.Forms.Button()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxFolioLote = New System.Windows.Forms.TextBox()
        CType(Me.DgBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgBuscar
        '
        Me.DgBuscar.AllowUserToAddRows = False
        Me.DgBuscar.AllowUserToDeleteRows = False
        Me.DgBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgBuscar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgBuscar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgBuscar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgBuscar.Location = New System.Drawing.Point(12, 97)
        Me.DgBuscar.MultiSelect = False
        Me.DgBuscar.Name = "DgBuscar"
        Me.DgBuscar.ReadOnly = True
        Me.DgBuscar.RowHeadersVisible = False
        Me.DgBuscar.RowHeadersWidth = 40
        Me.DgBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBuscar.Size = New System.Drawing.Size(602, 251)
        Me.DgBuscar.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Numero de Lote :"
        '
        'TxNumeroLote
        '
        Me.TxNumeroLote.Location = New System.Drawing.Point(107, 20)
        Me.TxNumeroLote.MaxLength = 10
        Me.TxNumeroLote.Name = "TxNumeroLote"
        Me.TxNumeroLote.Size = New System.Drawing.Size(94, 20)
        Me.TxNumeroLote.TabIndex = 0
        '
        'BtBuscar
        '
        Me.BtBuscar.Location = New System.Drawing.Point(519, 49)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(95, 23)
        Me.BtBuscar.TabIndex = 2
        Me.BtBuscar.Text = "Buscar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'BtSeleccionar
        '
        Me.BtSeleccionar.Location = New System.Drawing.Point(418, 354)
        Me.BtSeleccionar.Name = "BtSeleccionar"
        Me.BtSeleccionar.Size = New System.Drawing.Size(95, 36)
        Me.BtSeleccionar.TabIndex = 3
        Me.BtSeleccionar.Text = "Seleccionar"
        Me.BtSeleccionar.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(519, 354)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(95, 36)
        Me.BtCancelar.TabIndex = 4
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Folio de Lote :"
        '
        'TxFolioLote
        '
        Me.TxFolioLote.Location = New System.Drawing.Point(107, 46)
        Me.TxFolioLote.MaxLength = 13
        Me.TxFolioLote.Name = "TxFolioLote"
        Me.TxFolioLote.Size = New System.Drawing.Size(119, 20)
        Me.TxFolioLote.TabIndex = 1
        '
        'BuscarTierras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 402)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.BtSeleccionar)
        Me.Controls.Add(Me.BtBuscar)
        Me.Controls.Add(Me.TxFolioLote)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxNumeroLote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgBuscar)
        Me.Name = "BuscarTierras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Tierras"
        CType(Me.DgBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgBuscar As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxNumeroLote As TextBox
    Friend WithEvents BtBuscar As Button
    Friend WithEvents BtSeleccionar As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxFolioLote As TextBox
End Class
