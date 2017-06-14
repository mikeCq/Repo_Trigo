<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteVentas
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
        Me.CrLiquidacionVenta = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrLiquidacionVenta
        '
        Me.CrLiquidacionVenta.ActiveViewIndex = -1
        Me.CrLiquidacionVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrLiquidacionVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrLiquidacionVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrLiquidacionVenta.Location = New System.Drawing.Point(0, 0)
        Me.CrLiquidacionVenta.Name = "CrLiquidacionVenta"
        Me.CrLiquidacionVenta.ShowCloseButton = False
        Me.CrLiquidacionVenta.ShowGroupTreeButton = False
        Me.CrLiquidacionVenta.ShowLogo = False
        Me.CrLiquidacionVenta.ShowParameterPanelButton = False
        Me.CrLiquidacionVenta.ShowRefreshButton = False
        Me.CrLiquidacionVenta.Size = New System.Drawing.Size(877, 559)
        Me.CrLiquidacionVenta.TabIndex = 2
        Me.CrLiquidacionVenta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 559)
        Me.Controls.Add(Me.CrLiquidacionVenta)
        Me.Name = "ReporteVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ReporteVentas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrLiquidacionVenta As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
