<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteBoletasEmbarque
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
        Me.CrBoletaEmbarque = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrBoletaEmbarque
        '
        Me.CrBoletaEmbarque.ActiveViewIndex = -1
        Me.CrBoletaEmbarque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrBoletaEmbarque.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrBoletaEmbarque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrBoletaEmbarque.Location = New System.Drawing.Point(0, 0)
        Me.CrBoletaEmbarque.Name = "CrBoletaEmbarque"
        Me.CrBoletaEmbarque.ShowCloseButton = False
        Me.CrBoletaEmbarque.ShowCopyButton = False
        Me.CrBoletaEmbarque.ShowGotoPageButton = False
        Me.CrBoletaEmbarque.ShowGroupTreeButton = False
        Me.CrBoletaEmbarque.ShowLogo = False
        Me.CrBoletaEmbarque.ShowPageNavigateButtons = False
        Me.CrBoletaEmbarque.ShowParameterPanelButton = False
        Me.CrBoletaEmbarque.ShowRefreshButton = False
        Me.CrBoletaEmbarque.ShowTextSearchButton = False
        Me.CrBoletaEmbarque.Size = New System.Drawing.Size(1188, 675)
        Me.CrBoletaEmbarque.TabIndex = 1
        Me.CrBoletaEmbarque.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteBoletasEmbarque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 675)
        Me.Controls.Add(Me.CrBoletaEmbarque)
        Me.Name = "ReporteBoletasEmbarque"
        Me.Text = "ReporteBoletasEmbarque"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrBoletaEmbarque As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
