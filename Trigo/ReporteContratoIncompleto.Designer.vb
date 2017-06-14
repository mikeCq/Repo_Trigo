<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteEstatusContrato
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Btlimpiar = New System.Windows.Forms.Button()
        Me.BtGenerarReporte = New System.Windows.Forms.Button()
        Me.CBEstatusContrato = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CREstatusContrato = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Btlimpiar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtGenerarReporte)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CBEstatusContrato)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CREstatusContrato)
        Me.SplitContainer1.Size = New System.Drawing.Size(1312, 745)
        Me.SplitContainer1.SplitterDistance = 326
        Me.SplitContainer1.TabIndex = 0
        '
        'Btlimpiar
        '
        Me.Btlimpiar.Location = New System.Drawing.Point(10, 98)
        Me.Btlimpiar.Name = "Btlimpiar"
        Me.Btlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btlimpiar.TabIndex = 50
        Me.Btlimpiar.Text = "Limpiar"
        Me.Btlimpiar.UseVisualStyleBackColor = True
        '
        'BtGenerarReporte
        '
        Me.BtGenerarReporte.Location = New System.Drawing.Point(105, 98)
        Me.BtGenerarReporte.Name = "BtGenerarReporte"
        Me.BtGenerarReporte.Size = New System.Drawing.Size(100, 23)
        Me.BtGenerarReporte.TabIndex = 49
        Me.BtGenerarReporte.Text = "Generar Reporte"
        Me.BtGenerarReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtGenerarReporte.UseVisualStyleBackColor = True
        '
        'CBEstatusContrato
        '
        Me.CBEstatusContrato.FormattingEnabled = True
        Me.CBEstatusContrato.Location = New System.Drawing.Point(115, 52)
        Me.CBEstatusContrato.Name = "CBEstatusContrato"
        Me.CBEstatusContrato.Size = New System.Drawing.Size(198, 21)
        Me.CBEstatusContrato.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Estatus del Contrato"
        '
        'CREstatusContrato
        '
        Me.CREstatusContrato.ActiveViewIndex = -1
        Me.CREstatusContrato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CREstatusContrato.Cursor = System.Windows.Forms.Cursors.Default
        Me.CREstatusContrato.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CREstatusContrato.Location = New System.Drawing.Point(0, 0)
        Me.CREstatusContrato.Name = "CREstatusContrato"
        Me.CREstatusContrato.ShowCloseButton = False
        Me.CREstatusContrato.ShowGroupTreeButton = False
        Me.CREstatusContrato.ShowLogo = False
        Me.CREstatusContrato.ShowParameterPanelButton = False
        Me.CREstatusContrato.ShowRefreshButton = False
        Me.CREstatusContrato.Size = New System.Drawing.Size(982, 745)
        Me.CREstatusContrato.TabIndex = 2
        Me.CREstatusContrato.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteEstatusContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 745)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ReporteEstatusContrato"
        Me.Text = "ReporteContratoIncompleto"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents CREstatusContrato As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CBEstatusContrato As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btlimpiar As Button
    Friend WithEvents BtGenerarReporte As Button
End Class
