<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportesEntradas
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.CbProductor = New System.Windows.Forms.ComboBox()
        Me.Btlimpiar = New System.Windows.Forms.Button()
        Me.GbFiltros = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChFiltros = New System.Windows.Forms.CheckBox()
        Me.DTFinal = New System.Windows.Forms.DateTimePicker()
        Me.DTInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxNumBoleta = New System.Windows.Forms.TextBox()
        Me.Txpro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtGenerarReporte = New System.Windows.Forms.Button()
        Me.CRentradas = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GbFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.CbProductor)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Btlimpiar)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GbFiltros)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ChFiltros)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DTFinal)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DTInicio)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TxNumBoleta)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Txpro)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.BtGenerarReporte)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.CRentradas)
        Me.SplitContainer2.Size = New System.Drawing.Size(1527, 863)
        Me.SplitContainer2.SplitterDistance = 404
        Me.SplitContainer2.TabIndex = 1
        '
        'CbProductor
        '
        Me.CbProductor.FormattingEnabled = True
        Me.CbProductor.Location = New System.Drawing.Point(75, 112)
        Me.CbProductor.Name = "CbProductor"
        Me.CbProductor.Size = New System.Drawing.Size(279, 21)
        Me.CbProductor.TabIndex = 12
        '
        'Btlimpiar
        '
        Me.Btlimpiar.Location = New System.Drawing.Point(19, 597)
        Me.Btlimpiar.Name = "Btlimpiar"
        Me.Btlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btlimpiar.TabIndex = 5
        Me.Btlimpiar.Text = "Limpiar"
        Me.Btlimpiar.UseVisualStyleBackColor = True
        '
        'GbFiltros
        '
        Me.GbFiltros.Controls.Add(Me.TextBox9)
        Me.GbFiltros.Controls.Add(Me.TextBox8)
        Me.GbFiltros.Controls.Add(Me.TextBox7)
        Me.GbFiltros.Controls.Add(Me.TextBox6)
        Me.GbFiltros.Controls.Add(Me.TextBox5)
        Me.GbFiltros.Controls.Add(Me.TextBox4)
        Me.GbFiltros.Controls.Add(Me.TextBox3)
        Me.GbFiltros.Controls.Add(Me.TextBox2)
        Me.GbFiltros.Controls.Add(Me.Label11)
        Me.GbFiltros.Controls.Add(Me.Label10)
        Me.GbFiltros.Controls.Add(Me.Label7)
        Me.GbFiltros.Controls.Add(Me.Label9)
        Me.GbFiltros.Controls.Add(Me.Label6)
        Me.GbFiltros.Controls.Add(Me.Label8)
        Me.GbFiltros.Controls.Add(Me.Label5)
        Me.GbFiltros.Controls.Add(Me.Label4)
        Me.GbFiltros.Enabled = False
        Me.GbFiltros.Location = New System.Drawing.Point(16, 248)
        Me.GbFiltros.Name = "GbFiltros"
        Me.GbFiltros.Size = New System.Drawing.Size(338, 241)
        Me.GbFiltros.TabIndex = 11
        Me.GbFiltros.TabStop = False
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(113, 188)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(59, 20)
        Me.TextBox9.TabIndex = 3
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(113, 163)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(59, 20)
        Me.TextBox8.TabIndex = 3
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(113, 138)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(59, 20)
        Me.TextBox7.TabIndex = 3
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(113, 113)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(59, 20)
        Me.TextBox6.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(113, 88)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(59, 20)
        Me.TextBox5.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(113, 63)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(59, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(113, 38)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(59, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(113, 13)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(59, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Grano Quebrado :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Panza Blanca :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Grano Contraste :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Peso Especifico :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Punta Negra :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Grano Dañado :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Impureza :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Humedad :"
        '
        'ChFiltros
        '
        Me.ChFiltros.AutoSize = True
        Me.ChFiltros.Location = New System.Drawing.Point(16, 224)
        Me.ChFiltros.Name = "ChFiltros"
        Me.ChFiltros.Size = New System.Drawing.Size(110, 17)
        Me.ChFiltros.TabIndex = 10
        Me.ChFiltros.Text = "Filtros Adicionales"
        Me.ChFiltros.UseVisualStyleBackColor = True
        '
        'DTFinal
        '
        Me.DTFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFinal.Location = New System.Drawing.Point(202, 149)
        Me.DTFinal.Name = "DTFinal"
        Me.DTFinal.Size = New System.Drawing.Size(97, 20)
        Me.DTFinal.TabIndex = 3
        Me.DTFinal.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DTInicio
        '
        Me.DTInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTInicio.Location = New System.Drawing.Point(78, 149)
        Me.DTInicio.Name = "DTInicio"
        Me.DTInicio.Size = New System.Drawing.Size(97, 20)
        Me.DTInicio.TabIndex = 2
        Me.DTInicio.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "al"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Buscar del"
        '
        'TxNumBoleta
        '
        Me.TxNumBoleta.Location = New System.Drawing.Point(78, 76)
        Me.TxNumBoleta.Name = "TxNumBoleta"
        Me.TxNumBoleta.Size = New System.Drawing.Size(75, 20)
        Me.TxNumBoleta.TabIndex = 0
        '
        'Txpro
        '
        Me.Txpro.AutoSize = True
        Me.Txpro.Location = New System.Drawing.Point(14, 115)
        Me.Txpro.Name = "Txpro"
        Me.Txpro.Size = New System.Drawing.Size(59, 13)
        Me.Txpro.TabIndex = 2
        Me.Txpro.Text = "Productor :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No Boleta :"
        '
        'BtGenerarReporte
        '
        Me.BtGenerarReporte.Location = New System.Drawing.Point(254, 597)
        Me.BtGenerarReporte.Name = "BtGenerarReporte"
        Me.BtGenerarReporte.Size = New System.Drawing.Size(100, 23)
        Me.BtGenerarReporte.TabIndex = 4
        Me.BtGenerarReporte.Text = "Generar Reporte"
        Me.BtGenerarReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtGenerarReporte.UseVisualStyleBackColor = True
        '
        'CRentradas
        '
        Me.CRentradas.ActiveViewIndex = -1
        Me.CRentradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRentradas.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRentradas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRentradas.Location = New System.Drawing.Point(0, 0)
        Me.CRentradas.Name = "CRentradas"
        Me.CRentradas.ShowCloseButton = False
        Me.CRentradas.ShowGroupTreeButton = False
        Me.CRentradas.ShowLogo = False
        Me.CRentradas.ShowParameterPanelButton = False
        Me.CRentradas.ShowRefreshButton = False
        Me.CRentradas.Size = New System.Drawing.Size(1119, 863)
        Me.CRentradas.TabIndex = 0
        Me.CRentradas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReportesEntradas
        '
        Me.ClientSize = New System.Drawing.Size(1527, 863)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "ReportesEntradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte de Entradas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GbFiltros.ResumeLayout(False)
        Me.GbFiltros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents BtGenerarReporte As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CRentradas As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TxNumBoleta As TextBox
    Friend WithEvents Txpro As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DTFinal As DateTimePicker
    Friend WithEvents DTInicio As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents GbFiltros As GroupBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ChFiltros As CheckBox
    Friend WithEvents Btlimpiar As Button
    Friend WithEvents CbProductor As ComboBox
End Class
