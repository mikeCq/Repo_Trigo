<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteResumenBoletasLiquidadas
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
        Me.CrResumenBoletas = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrResumenBoletas
        '
        Me.CrResumenBoletas.ActiveViewIndex = -1
        Me.CrResumenBoletas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrResumenBoletas.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrResumenBoletas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrResumenBoletas.Location = New System.Drawing.Point(0, 0)
        Me.CrResumenBoletas.Name = "CrResumenBoletas"
        Me.CrResumenBoletas.ShowCloseButton = False
        Me.CrResumenBoletas.ShowGroupTreeButton = False
        Me.CrResumenBoletas.ShowLogo = False
        Me.CrResumenBoletas.ShowParameterPanelButton = False
        Me.CrResumenBoletas.ShowRefreshButton = False
        Me.CrResumenBoletas.Size = New System.Drawing.Size(921, 622)
        Me.CrResumenBoletas.TabIndex = 2
        Me.CrResumenBoletas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteResumenBoletasLiquidadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 622)
        Me.Controls.Add(Me.CrResumenBoletas)
        Me.Name = "ReporteResumenBoletasLiquidadas"
        Me.Text = "Resumen de Boletas Liquidadas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrResumenBoletas As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
