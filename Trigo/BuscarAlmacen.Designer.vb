<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarAlmacen
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
        Me.BtSeleccion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxAcopio = New System.Windows.Forms.TextBox()
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.DgBuscar = New System.Windows.Forms.DataGridView()
        Me.TxAlmacen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxFolioAserca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DgBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(699, 412)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(103, 44)
        Me.BtCancelar.TabIndex = 18
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'BtSeleccion
        '
        Me.BtSeleccion.Location = New System.Drawing.Point(590, 412)
        Me.BtSeleccion.Name = "BtSeleccion"
        Me.BtSeleccion.Size = New System.Drawing.Size(103, 44)
        Me.BtSeleccion.TabIndex = 17
        Me.BtSeleccion.Text = "Seleccionar"
        Me.BtSeleccion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Centro Acopio :"
        '
        'TxAcopio
        '
        Me.TxAcopio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAcopio.Location = New System.Drawing.Point(93, 35)
        Me.TxAcopio.Name = "TxAcopio"
        Me.TxAcopio.Size = New System.Drawing.Size(266, 20)
        Me.TxAcopio.TabIndex = 15
        '
        'BtBuscar
        '
        Me.BtBuscar.Location = New System.Drawing.Point(705, 51)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(97, 38)
        Me.BtBuscar.TabIndex = 16
        Me.BtBuscar.Text = "Buscar"
        Me.BtBuscar.UseVisualStyleBackColor = True
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
        Me.DgBuscar.Location = New System.Drawing.Point(12, 104)
        Me.DgBuscar.MultiSelect = False
        Me.DgBuscar.Name = "DgBuscar"
        Me.DgBuscar.ReadOnly = True
        Me.DgBuscar.RowHeadersVisible = False
        Me.DgBuscar.RowHeadersWidth = 40
        Me.DgBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBuscar.Size = New System.Drawing.Size(790, 302)
        Me.DgBuscar.TabIndex = 14
        '
        'TxAlmacen
        '
        Me.TxAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxAlmacen.Location = New System.Drawing.Point(93, 61)
        Me.TxAlmacen.Name = "TxAlmacen"
        Me.TxAlmacen.Size = New System.Drawing.Size(190, 20)
        Me.TxAlmacen.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Almacen :"
        '
        'TxFolioAserca
        '
        Me.TxFolioAserca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFolioAserca.Location = New System.Drawing.Point(93, 9)
        Me.TxFolioAserca.Name = "TxFolioAserca"
        Me.TxFolioAserca.Size = New System.Drawing.Size(93, 20)
        Me.TxFolioAserca.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Folio ASERCA :"
        '
        'BuscarAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 468)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.BtSeleccion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxAlmacen)
        Me.Controls.Add(Me.TxFolioAserca)
        Me.Controls.Add(Me.TxAcopio)
        Me.Controls.Add(Me.BtBuscar)
        Me.Controls.Add(Me.DgBuscar)
        Me.Name = "BuscarAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Almacen"
        CType(Me.DgBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtCancelar As Button
    Friend WithEvents BtSeleccion As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxAcopio As TextBox
    Friend WithEvents BtBuscar As Button
    Friend WithEvents DgBuscar As DataGridView
    Friend WithEvents TxAlmacen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxFolioAserca As TextBox
    Friend WithEvents Label3 As Label
End Class
