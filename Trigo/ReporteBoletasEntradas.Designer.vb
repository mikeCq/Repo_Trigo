<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteBoletasEntradas
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
        Me.CrBoletaEntrada = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrBoletaEntrada
        '
        Me.CrBoletaEntrada.ActiveViewIndex = -1
        Me.CrBoletaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrBoletaEntrada.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrBoletaEntrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrBoletaEntrada.Location = New System.Drawing.Point(0, 0)
        Me.CrBoletaEntrada.Name = "CrBoletaEntrada"
        Me.CrBoletaEntrada.ShowCloseButton = False
        Me.CrBoletaEntrada.ShowCopyButton = False
        Me.CrBoletaEntrada.ShowGotoPageButton = False
        Me.CrBoletaEntrada.ShowGroupTreeButton = False
        Me.CrBoletaEntrada.ShowLogo = False
        Me.CrBoletaEntrada.ShowPageNavigateButtons = False
        Me.CrBoletaEntrada.ShowParameterPanelButton = False
        Me.CrBoletaEntrada.ShowRefreshButton = False
        Me.CrBoletaEntrada.ShowTextSearchButton = False
        Me.CrBoletaEntrada.Size = New System.Drawing.Size(1188, 675)
        Me.CrBoletaEntrada.TabIndex = 0
        Me.CrBoletaEntrada.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteBoletasEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 675)
        Me.Controls.Add(Me.CrBoletaEntrada)
        Me.Name = "ReporteBoletasEntradas"
        Me.Text = "ReporteBoletasEntradas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrBoletaEntrada As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
