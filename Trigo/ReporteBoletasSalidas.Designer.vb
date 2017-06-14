<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteBoletasSalidas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CrBoletaSalida = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrBoletaSalida
        '
        Me.CrBoletaSalida.ActiveViewIndex = -1
        Me.CrBoletaSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrBoletaSalida.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrBoletaSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrBoletaSalida.Location = New System.Drawing.Point(0, 0)
        Me.CrBoletaSalida.Name = "CrBoletaSalida"
        Me.CrBoletaSalida.ShowCloseButton = False
        Me.CrBoletaSalida.ShowCopyButton = False
        Me.CrBoletaSalida.ShowGotoPageButton = False
        Me.CrBoletaSalida.ShowGroupTreeButton = False
        Me.CrBoletaSalida.ShowLogo = False
        Me.CrBoletaSalida.ShowPageNavigateButtons = False
        Me.CrBoletaSalida.ShowParameterPanelButton = False
        Me.CrBoletaSalida.ShowRefreshButton = False
        Me.CrBoletaSalida.ShowTextSearchButton = False
        Me.CrBoletaSalida.Size = New System.Drawing.Size(1188, 675)
        Me.CrBoletaSalida.TabIndex = 1
        Me.CrBoletaSalida.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteBoletasSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 675)
        Me.Controls.Add(Me.CrBoletaSalida)
        Me.Name = "ReporteBoletasSalidas"
        Me.Text = "ReporteBoletasSalidas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrBoletaSalida As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
