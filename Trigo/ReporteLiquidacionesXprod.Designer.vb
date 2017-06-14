<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteLiquidacionesXprod
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
        Me.CrLiquidacionProd = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrLiquidacionProd
        '
        Me.CrLiquidacionProd.ActiveViewIndex = -1
        Me.CrLiquidacionProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrLiquidacionProd.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrLiquidacionProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrLiquidacionProd.Location = New System.Drawing.Point(0, 0)
        Me.CrLiquidacionProd.Name = "CrLiquidacionProd"
        Me.CrLiquidacionProd.ShowCloseButton = False
        Me.CrLiquidacionProd.ShowGroupTreeButton = False
        Me.CrLiquidacionProd.ShowLogo = False
        Me.CrLiquidacionProd.ShowParameterPanelButton = False
        Me.CrLiquidacionProd.ShowRefreshButton = False
        Me.CrLiquidacionProd.Size = New System.Drawing.Size(1022, 689)
        Me.CrLiquidacionProd.TabIndex = 1
        Me.CrLiquidacionProd.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteLiquidacionesXprod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 689)
        Me.Controls.Add(Me.CrLiquidacionProd)
        Me.Name = "ReporteLiquidacionesXprod"
        Me.Text = "ReporteLiquidacionesXprod"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrLiquidacionProd As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
