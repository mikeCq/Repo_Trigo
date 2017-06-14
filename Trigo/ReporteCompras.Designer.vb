<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteCompras
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
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.CrComprasXproductor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CbProductor = New System.Windows.Forms.ComboBox()
        Me.Btlimpiar = New System.Windows.Forms.Button()
        Me.DTFinal = New System.Windows.Forms.DateTimePicker()
        Me.DTInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txpro = New System.Windows.Forms.Label()
        Me.BtGenerarReporte = New System.Windows.Forms.Button()
        Me.CbTipoContrato = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(371, 701)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'CrComprasXproductor
        '
        Me.CrComprasXproductor.ActiveViewIndex = -1
        Me.CrComprasXproductor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrComprasXproductor.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrComprasXproductor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrComprasXproductor.Location = New System.Drawing.Point(371, 0)
        Me.CrComprasXproductor.Name = "CrComprasXproductor"
        Me.CrComprasXproductor.ShowCloseButton = False
        Me.CrComprasXproductor.ShowGroupTreeButton = False
        Me.CrComprasXproductor.ShowLogo = False
        Me.CrComprasXproductor.ShowParameterPanelButton = False
        Me.CrComprasXproductor.ShowRefreshButton = False
        Me.CrComprasXproductor.Size = New System.Drawing.Size(808, 701)
        Me.CrComprasXproductor.TabIndex = 4
        Me.CrComprasXproductor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'CbProductor
        '
        Me.CbProductor.FormattingEnabled = True
        Me.CbProductor.Location = New System.Drawing.Point(73, 67)
        Me.CbProductor.Name = "CbProductor"
        Me.CbProductor.Size = New System.Drawing.Size(279, 21)
        Me.CbProductor.TabIndex = 32
        '
        'Btlimpiar
        '
        Me.Btlimpiar.Location = New System.Drawing.Point(12, 187)
        Me.Btlimpiar.Name = "Btlimpiar"
        Me.Btlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btlimpiar.TabIndex = 29
        Me.Btlimpiar.Text = "Limpiar"
        Me.Btlimpiar.UseVisualStyleBackColor = True
        '
        'DTFinal
        '
        Me.DTFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFinal.Location = New System.Drawing.Point(197, 131)
        Me.DTFinal.Name = "DTFinal"
        Me.DTFinal.Size = New System.Drawing.Size(97, 20)
        Me.DTFinal.TabIndex = 27
        Me.DTFinal.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DTInicio
        '
        Me.DTInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTInicio.Location = New System.Drawing.Point(73, 131)
        Me.DTInicio.Name = "DTInicio"
        Me.DTInicio.Size = New System.Drawing.Size(97, 20)
        Me.DTInicio.TabIndex = 25
        Me.DTInicio.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "al"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Contrato :"
        '
        'Txpro
        '
        Me.Txpro.AutoSize = True
        Me.Txpro.Location = New System.Drawing.Point(12, 70)
        Me.Txpro.Name = "Txpro"
        Me.Txpro.Size = New System.Drawing.Size(59, 13)
        Me.Txpro.TabIndex = 26
        Me.Txpro.Text = "Productor :"
        '
        'BtGenerarReporte
        '
        Me.BtGenerarReporte.Location = New System.Drawing.Point(247, 187)
        Me.BtGenerarReporte.Name = "BtGenerarReporte"
        Me.BtGenerarReporte.Size = New System.Drawing.Size(100, 23)
        Me.BtGenerarReporte.TabIndex = 28
        Me.BtGenerarReporte.Text = "Generar Reporte"
        Me.BtGenerarReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtGenerarReporte.UseVisualStyleBackColor = True
        '
        'CbTipoContrato
        '
        Me.CbTipoContrato.FormattingEnabled = True
        Me.CbTipoContrato.Items.AddRange(New Object() {"02AXCPV1608066", "LIBRE"})
        Me.CbTipoContrato.Location = New System.Drawing.Point(73, 101)
        Me.CbTipoContrato.Name = "CbTipoContrato"
        Me.CbTipoContrato.Size = New System.Drawing.Size(184, 21)
        Me.CbTipoContrato.TabIndex = 33
        '
        'ReporteCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 701)
        Me.Controls.Add(Me.CbTipoContrato)
        Me.Controls.Add(Me.CbProductor)
        Me.Controls.Add(Me.Btlimpiar)
        Me.Controls.Add(Me.DTFinal)
        Me.Controls.Add(Me.DTInicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txpro)
        Me.Controls.Add(Me.BtGenerarReporte)
        Me.Controls.Add(Me.CrComprasXproductor)
        Me.Controls.Add(Me.Splitter1)
        Me.Name = "ReporteCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte de Compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents CrComprasXproductor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CbProductor As ComboBox
    Friend WithEvents Btlimpiar As Button
    Friend WithEvents DTFinal As DateTimePicker
    Friend WithEvents DTInicio As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txpro As Label
    Friend WithEvents BtGenerarReporte As Button
    Friend WithEvents CbTipoContrato As ComboBox
End Class
