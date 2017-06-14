<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteVentaResumen
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
        Me.CrLiquidacionVentaResumen = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrLiquidacionVentaResumen
        '
        Me.CrLiquidacionVentaResumen.ActiveViewIndex = -1
        Me.CrLiquidacionVentaResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrLiquidacionVentaResumen.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrLiquidacionVentaResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrLiquidacionVentaResumen.Location = New System.Drawing.Point(0, 0)
        Me.CrLiquidacionVentaResumen.Name = "CrLiquidacionVentaResumen"
        Me.CrLiquidacionVentaResumen.ShowCloseButton = False
        Me.CrLiquidacionVentaResumen.ShowGroupTreeButton = False
        Me.CrLiquidacionVentaResumen.ShowLogo = False
        Me.CrLiquidacionVentaResumen.ShowParameterPanelButton = False
        Me.CrLiquidacionVentaResumen.ShowRefreshButton = False
        Me.CrLiquidacionVentaResumen.Size = New System.Drawing.Size(1014, 629)
        Me.CrLiquidacionVentaResumen.TabIndex = 3
        Me.CrLiquidacionVentaResumen.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteVentaResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 629)
        Me.Controls.Add(Me.CrLiquidacionVentaResumen)
        Me.Name = "ReporteVentaResumen"
        Me.Text = "ReporteVentaResumen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrLiquidacionVentaResumen As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
