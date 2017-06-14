<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarEntradaLiq
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxBuscarProductor = New System.Windows.Forms.TextBox()
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.BtSeleccionar = New System.Windows.Forms.Button()
        Me.DgEntLiq = New System.Windows.Forms.DataGridView()
        CType(Me.DgEntLiq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Productor :"
        '
        'TxBuscarProductor
        '
        Me.TxBuscarProductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxBuscarProductor.Location = New System.Drawing.Point(77, 18)
        Me.TxBuscarProductor.Name = "TxBuscarProductor"
        Me.TxBuscarProductor.Size = New System.Drawing.Size(406, 20)
        Me.TxBuscarProductor.TabIndex = 12
        '
        'BtBuscar
        '
        Me.BtBuscar.Location = New System.Drawing.Point(546, 18)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(97, 38)
        Me.BtBuscar.TabIndex = 13
        Me.BtBuscar.Text = "Buscar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(546, 439)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(97, 38)
        Me.BtCancelar.TabIndex = 13
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'BtSeleccionar
        '
        Me.BtSeleccionar.Location = New System.Drawing.Point(443, 439)
        Me.BtSeleccionar.Name = "BtSeleccionar"
        Me.BtSeleccionar.Size = New System.Drawing.Size(97, 38)
        Me.BtSeleccionar.TabIndex = 13
        Me.BtSeleccionar.Text = "Seleccionar"
        Me.BtSeleccionar.UseVisualStyleBackColor = True
        '
        'DgEntLiq
        '
        Me.DgEntLiq.AllowUserToAddRows = False
        Me.DgEntLiq.AllowUserToDeleteRows = False
        Me.DgEntLiq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgEntLiq.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgEntLiq.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgEntLiq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgEntLiq.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgEntLiq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgEntLiq.GridColor = System.Drawing.Color.Khaki
        Me.DgEntLiq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgEntLiq.Location = New System.Drawing.Point(12, 79)
        Me.DgEntLiq.MultiSelect = False
        Me.DgEntLiq.Name = "DgEntLiq"
        Me.DgEntLiq.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgEntLiq.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgEntLiq.RowHeadersVisible = False
        Me.DgEntLiq.RowHeadersWidth = 40
        Me.DgEntLiq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgEntLiq.Size = New System.Drawing.Size(631, 354)
        Me.DgEntLiq.TabIndex = 18
        '
        'BuscarEntradaLiq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 489)
        Me.Controls.Add(Me.DgEntLiq)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxBuscarProductor)
        Me.Controls.Add(Me.BtSeleccionar)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.BtBuscar)
        Me.Name = "BuscarEntradaLiq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Productor"
        CType(Me.DgEntLiq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TxBuscarProductor As TextBox
    Friend WithEvents BtBuscar As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents BtSeleccionar As Button
    Friend WithEvents DgEntLiq As DataGridView
End Class
