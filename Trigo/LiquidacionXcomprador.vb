Imports System.Data.SqlClient
Public Class LiquidacionXcomprador
    Dim IdLiquidacionTotal As String
    Dim PrecioContrato As Double
    Dim Moneda As Integer
    Private Sub LiquidacionXcomprador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboBox()
        LlenarDGVsalidas()
        PropiedadesDGVSalidas()
    End Sub
    Private _codigoLiquidacionVenta As String
    Public Property codigoLiquidacionVenta() As String
        Get
            Return _codigoLiquidacionVenta
        End Get
        Set(value As String)
            _codigoLiquidacionVenta = value
        End Set
    End Property
    Private _tipoContrato As Integer
    Public Property tipoContrato() As Integer
        Get
            Return _tipoContrato
        End Get
        Set(value As Integer)
            _tipoContrato = value
        End Set
    End Property
    Private Sub PropiedadesDGVSalidas()
        If DGVSalidas.Columns("ChCol") Is Nothing Then
            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = ""
            checkBoxColumn.Width = 40
            checkBoxColumn.Name = "ChCol"
            DGVSalidas.Columns.Insert(11, checkBoxColumn)
        End If
        DGVSalidas.Columns("id_salida").Visible = False
        DGVSalidas.Columns("id_empresa").Visible = False
        DGVSalidas.Columns("razonsocial").Visible = False
        DGVSalidas.Columns("bruto").Visible = False
        DGVSalidas.Columns("Tara").Visible = False
        DGVSalidas.Columns("Total").ReadOnly = False

        DGVSalidas.Columns("Neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVSalidas.Columns("Deducciones").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVSalidas.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DGVSalidas.Columns("Bruto").DefaultCellStyle.Format = "###,##0.00"
        DGVSalidas.Columns("Tara").DefaultCellStyle.Format = "###,##0.00"
        DGVSalidas.Columns("Neto").DefaultCellStyle.Format = "###,##0.00"
        DGVSalidas.Columns("Deducciones").DefaultCellStyle.Format = "###,##0.00"
        DGVSalidas.Columns("Total").DefaultCellStyle.Format = "###,##0.00"
    End Sub
    Private Sub PropiedadesDGVSalidasSeleccionadas()
        Dim DGVTBCIdSalida As New DataGridViewTextBoxColumn
        DGVTBCIdSalida.Name = "id_salida"
        DGVTBCIdSalida.Visible = False
        DGVSalidasSeleccionadas.Columns.Insert(0, DGVTBCIdSalida)

        Dim DGVTBCIdBoleta As New DataGridViewTextBoxColumn
        DGVTBCIdBoleta.Name = "numeroBoleta"
        DGVTBCIdBoleta.HeaderText = "Boleta"
        DGVTBCIdBoleta.Width = 50
        DGVSalidasSeleccionadas.Columns.Insert(1, DGVTBCIdBoleta)

        Dim DGVTBCIdEmpresa As New DataGridViewTextBoxColumn
        DGVTBCIdEmpresa.Name = "id_empresa"
        DGVTBCIdEmpresa.Visible = False
        DGVSalidasSeleccionadas.Columns.Insert(2, DGVTBCIdEmpresa)

        Dim DGVTBCFecha As New DataGridViewTextBoxColumn
        DGVTBCFecha.HeaderText = "Fecha"
        DGVTBCFecha.Width = 70
        DGVTBCFecha.Name = "Fecha_Pesaje"
        DGVTBCFecha.Visible = False
        DGVSalidasSeleccionadas.Columns.Insert(3, DGVTBCFecha)

        Dim DGVTBCGrano As New DataGridViewTextBoxColumn()
        DGVTBCGrano.HeaderText = "Grano"
        DGVTBCGrano.Width = 75
        DGVTBCGrano.Name = "grupoGrano"
        DGVSalidasSeleccionadas.Columns.Insert(4, DGVTBCGrano)

        Dim DGVTBCNeto As New DataGridViewTextBoxColumn()
        DGVTBCNeto.HeaderText = "Neto"
        DGVTBCNeto.Width = 65
        DGVTBCNeto.Name = "Neto"
        DGVSalidasSeleccionadas.Columns.Insert(5, DGVTBCNeto)

        Dim DGVTBCDeducciones As New DataGridViewTextBoxColumn()
        DGVTBCDeducciones.HeaderText = "Deducciones"
        DGVTBCDeducciones.Width = 60
        DGVTBCDeducciones.Name = "Deducciones"
        DGVSalidasSeleccionadas.Columns.Insert(6, DGVTBCDeducciones)

        Dim DGVTBCTotal As New DataGridViewTextBoxColumn()
        DGVTBCTotal.HeaderText = "Total"
        DGVTBCTotal.Width = 70
        DGVTBCTotal.Name = "Total"
        DGVSalidasSeleccionadas.Columns.Insert(7, DGVTBCTotal)

        DGVSalidasSeleccionadas.Columns("Neto").DefaultCellStyle.Format = "###,##0.00"
        DGVSalidasSeleccionadas.Columns("Deducciones").DefaultCellStyle.Format = "###,##0.00"
        DGVSalidasSeleccionadas.Columns("Total").DefaultCellStyle.Format = "###,##0.00"

        DGVSalidasSeleccionadas.Columns("Neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVSalidasSeleccionadas.Columns("Deducciones").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVSalidasSeleccionadas.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub
    Private Sub PropiedadesDGVTotalLiquidado()
        DGVTotalLiquidado.Columns("IdVentaTotalComprador").Visible = False
        DGVTotalLiquidado.Columns("idContratoVenta").Visible = False
        DGVTotalLiquidado.Columns("Id_Comprador").Visible = False
        DGVTotalLiquidado.Columns("GrupoGrano").HeaderText = "Tipo Maiz"
        DGVTotalLiquidado.Columns("GrupoGrano").ReadOnly = True
        DGVTotalLiquidado.Columns("FechaVenta").HeaderText = "Fecha de Liquidacion"
        DGVTotalLiquidado.Columns("FechaVenta").ReadOnly = True
        DGVTotalLiquidado.Columns("TotalVentaContrato").HeaderText = "Total liquidado (Ton)"
        DGVTotalLiquidado.Columns("TotalVentaContrato").ReadOnly = True
        DGVTotalLiquidado.Columns("ImporteTotal").HeaderText = "Importe"
        DGVTotalLiquidado.Columns("ImporteTotal").ReadOnly = True
        DGVTotalLiquidado.Columns("Contrato").HeaderText = "Contrato"
        DGVTotalLiquidado.Columns("Contrato").ReadOnly = True
        DGVTotalLiquidado.Columns("NombreComprador").HeaderText = "Comprador"
        DGVTotalLiquidado.Columns("NombreComprador").ReadOnly = True
        DGVTotalLiquidado.Columns("TotalVentaContrato").DefaultCellStyle.Format = "###,##0.000"
        DGVTotalLiquidado.Columns("TotalVentaContrato").ReadOnly = True
        DGVTotalLiquidado.Columns("ImporteTotal").DefaultCellStyle.Format = "###,##0.00"
        DGVTotalLiquidado.Columns("ImporteTotal").ReadOnly = True
    End Sub
    Private Sub PropiedadesDGVTotalLiquidadoDetalle()
        DGVTotalLiquidadoDetalle.Columns("IdVentaComprador").Visible = False
        DGVTotalLiquidadoDetalle.Columns("IdSalida").Visible = False
        DGVTotalLiquidadoDetalle.Columns("IdComprador").Visible = False
        DGVTotalLiquidadoDetalle.Columns("NombreComprador").Visible = False
        DGVTotalLiquidadoDetalle.Columns("NumeroBoleta").HeaderText = "No. Boleta"
        DGVTotalLiquidadoDetalle.Columns("NumeroBoleta").ReadOnly = True
        DGVTotalLiquidadoDetalle.Columns("GrupoGrano").HeaderText = "Tipo Maiz"
        DGVTotalLiquidadoDetalle.Columns("GrupoGrano").ReadOnly = True
        DGVTotalLiquidadoDetalle.Columns("Neto").HeaderText = "Neto"
        DGVTotalLiquidadoDetalle.Columns("Neto").ReadOnly = True
        DGVTotalLiquidadoDetalle.Columns("Deduccion").HeaderText = "Deduccion"
        DGVTotalLiquidadoDetalle.Columns("Deduccion").ReadOnly = True
        DGVTotalLiquidadoDetalle.Columns("Total").HeaderText = "Total"
        DGVTotalLiquidadoDetalle.Columns("Total").ReadOnly = True
        DGVTotalLiquidadoDetalle.Columns("Neto").DefaultCellStyle.Format = "###,##0.00"
        DGVTotalLiquidadoDetalle.Columns("Neto").ReadOnly = True
        DGVTotalLiquidadoDetalle.Columns("Deduccion").DefaultCellStyle.Format = "###,##0.00"
        DGVTotalLiquidadoDetalle.Columns("Deduccion").ReadOnly = True
        DGVTotalLiquidadoDetalle.Columns("Total").DefaultCellStyle.Format = "###,##0.00"
        DGVTotalLiquidadoDetalle.Columns("Total").ReadOnly = True
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BTNNuevo.Click
        Limpiar()
        DesmarcarChecks()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click, Me.FormClosed
        Limpiar()
        Me.Close()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BTNImprimir.Click
        Imprimir()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BTNGuardar.Click
        Guardar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BTNBuscar.Click
        Buscar()
    End Sub
    Private Sub BTNAgregar_Click(sender As Object, e As EventArgs) Handles BTNAgregar.Click
        Agregar()
    End Sub
    '--------------METODOS---------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub LlenarComboBox()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        '------LLENAR CBTIPOMONEDA--------
        CBTipoMoneda.Items.Add("")
        CBTipoMoneda.Items.Add("DLS")
        CBTipoMoneda.Items.Add("MXN")
        '------LLENAR CBTIPOMONEDABL--------
        CBTipoMonedaBL.Items.Add("")
        CBTipoMonedaBL.Items.Add("DLS")
        CBTipoMonedaBL.Items.Add("MXN")
        '------LLENAR CBCOMPRADOR--------
        Dim CmdCBEmpresas As SqlCommand
        CmdCBEmpresas = New SqlCommand("sp_CbEmpresas")
        CmdCBEmpresas.CommandType = CommandType.StoredProcedure
        CmdCBEmpresas.Connection = cnn
        da = New SqlDataAdapter(CmdCBEmpresas)
        ds = New DataSet()
        da.Fill(ds)
        CBEmpresa.DataSource = ds.Tables(0)
        CBEmpresa.DisplayMember = "RazonSocial"
        CBEmpresa.ValueMember = "Id_Empresa"
        CBEmpresa.SelectedIndex = -1
        '------LLENAR CBCOMPRADORBL--------
        Dim CmdCBCompradorLB As SqlCommand
        CmdCBCompradorLB = New SqlCommand("sp_cbContratoLiquidacionesVenta")
        CmdCBCompradorLB.CommandType = CommandType.StoredProcedure
        CmdCBCompradorLB.Connection = cnn
        da = New SqlDataAdapter(CmdCBCompradorLB)
        ds = New DataSet()
        da.Fill(ds)
    End Sub
    Private Sub Limpiar()
        TBIdContrato.Text = ""
        TbEstatusContrato.Text = ""
        TBNombreComprador.Text = ""
        TBIdContrato.Text = ""
        NUDToneladasContrato.Value = 0
        NUDToneladasRestantes.Value = 0
        CBEmpresa.SelectedIndex = -1
        Moneda = -1
        TBTipoDeCambio.Text = ""
        NUDPrecioContrato.Value = 0.00
        TBPrecioPorTonelada.Text = ""
        TBImporte.Text = ""
        NUDToneladasSeleccionadas.Value = 0.00
        NUDTotalLiquidar.Value = 0.00
        'CBComprador.SelectedValue = -1
        CBTipoMoneda.SelectedItem = ""
        DGVSalidasSeleccionadas.Columns.Clear()
        DGVSalidasSeleccionadas.DataSource = Nothing
        '---PESTAÑA DE LIQUIDACION-------------------
        TBTipoDeCambioBL.Text = ""
        NUDPrecioContratoBL.Value = 0.00
        NUDTotalLiquidadoBL.Value = 0.00
        CBTipoMonedaBL.SelectedItem = ""
        TBPrecioPorToneladaBL.Text = ""
        TBImporteBL.Text = ""
        TBContratoBL.Text = ""
        TBMetodoPagoBL.Text = ""
        TBBancoBL.Text = ""
        TBUltimosDigitosBL.Text = ""
        RBTNContratoBL.Checked = False
        RBTNLibreBL.Checked = False
        'CBTipoMoneda.Items.Clear()
        'CBTipoMonedaBL.Items.Clear()
    End Sub
    Private Sub LlenarDGVsalidas()
        Dim cmd As New SqlCommand("sp_llenarDgvSalidas", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataSet()
        da.Fill(dt)
        DGVSalidas.DataSource = dt.Tables(0).DefaultView
    End Sub
    Private Sub Agregar()
        DGVSalidasSeleccionadas.Columns.Clear()
        DGVSalidasSeleccionadas.DataSource = Nothing
        PropiedadesDGVSalidasSeleccionadas()
        Dim Contador As Integer
        For Contador = 0 To DGVSalidas.RowCount - 1
            If DGVSalidas.Rows(Contador).Cells("ChCol").Value = True Then
                DGVSalidasSeleccionadas.Rows.Add(DGVSalidas.Rows(Contador).Cells("id_salida").Value.ToString(), DGVSalidas.Rows(Contador).Cells("numeroBoleta").Value, DGVSalidas.Rows(Contador).Cells("id_Empresa").Value.ToString(), DGVSalidas.Rows(Contador).Cells("Fecha_Pesaje").Value, DGVSalidas.Rows(Contador).Cells("grupoGrano").Value.ToString(), DGVSalidas.Rows(Contador).Cells("Neto").Value, DGVSalidas.Rows(Contador).Cells("Deducciones").Value, DGVSalidas.Rows(Contador).Cells("Total").Value)
            End If
        Next Contador
        Dim PuestosAcumulados As Double
        For Contador = 0 To DGVSalidasSeleccionadas.RowCount - 1
            PuestosAcumulados = PuestosAcumulados + DGVSalidasSeleccionadas.Rows(Contador).Cells("Total").Value
        Next Contador
        NUDTotalLiquidar.Value = PuestosAcumulados
        PuestosAcumulados = 0
    End Sub
    Private Sub DGVSalidas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSalidas.CellContentClick
        Dim Contador As Integer
        For Contador = 0 To DGVSalidas.RowCount - 1
            If DGVSalidas.Rows(Contador).Selected Then
                If DGVSalidas.Rows(Contador).Cells("ChCol").Value = False Then
                    DGVSalidas.Rows(Contador).Cells("ChCol").Value = True
                ElseIf DGVSalidas.Rows(Contador).Cells("ChCol").Value = True Then
                    DGVSalidas.Rows(Contador).Cells("ChCol").Value = False
                End If
            End If
        Next Contador
        ContarChecksMarcados()
    End Sub
    Private Sub ContarChecksMarcados()
        Dim PuestosAcumulados As Double
        For Each row As DataGridViewRow In DGVSalidas.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("ChCol").Value)
            If isSelected = True Then
                PuestosAcumulados = PuestosAcumulados + row.Cells("Total").Value.ToString()
            End If
        Next row
        NUDToneladasSeleccionadas.Value = PuestosAcumulados
        PuestosAcumulados = 0
    End Sub
    Private Sub DesmarcarChecks()
        For Contador = 0 To DGVSalidas.RowCount - 1
            If DGVSalidas.Rows(Contador).Cells("ChCol").Value = True Then
                DGVSalidas.Rows(Contador).Cells("ChCol").Value = False
            End If
        Next Contador
    End Sub
    Private Sub Guardar()
        Dim resultado As Boolean = False
        If DGVSalidasSeleccionadas.RowCount = 0 Then
            MessageBox.Show("No hay datos para guardar.")
        ElseIf VerificarVacios(resultado) = True Then
            MessageBox.Show("Verificar si tiene campos vacios", "Aviso")
        ElseIf NUDToneladasSeleccionadas.Value = NUDTotalLiquidar.Value Then
            IdLiquidacionTotal = ""

            Dim Contador As Integer
            IdLiquidacionTotal = generaCodigoLiquidacionVenta(IdLiquidacionTotal)
            For Contador = 0 To DGVSalidasSeleccionadas.RowCount - 1
                Dim CodigoLiquidacion As String = ""
                Dim cmd1 As New SqlCommand("sp_InsertarVentaResumen", cnn)
                cmd1.CommandType = CommandType.StoredProcedure
                cmd1.Parameters.Clear()
                cmd1.Parameters.AddWithValue("@IdVentaComprador", generaCodigoVentaResumen(CodigoLiquidacion))
                cmd1.Parameters.AddWithValue("@idSalida", DGVSalidasSeleccionadas.Rows(Contador).Cells("Id_Salida").Value.ToString)
                cmd1.Parameters.AddWithValue("@numeroBoleta", DGVSalidasSeleccionadas.Rows(Contador).Cells("numeroBoleta").Value)
                cmd1.Parameters.AddWithValue("@IdComprador", TBIdComprador.Text)
                cmd1.Parameters.AddWithValue("@NombreComprador", TBNombreComprador.Text)
                cmd1.Parameters.AddWithValue("@grupoGrano", DGVSalidasSeleccionadas.Rows(Contador).Cells("grupoGrano").Value.ToString())
                cmd1.Parameters.AddWithValue("@Neto", (CDbl(DGVSalidasSeleccionadas.Rows(Contador).Cells("Neto").Value)) / 1000)
                cmd1.Parameters.AddWithValue("@deduccion", (CDbl(DGVSalidasSeleccionadas.Rows(Contador).Cells("Deducciones").Value)) / 1000)
                cmd1.Parameters.AddWithValue("@Total", (CDbl(DGVSalidasSeleccionadas.Rows(Contador).Cells("Total").Value)) / 1000)
                cmd1.Parameters.AddWithValue("@moneda", IIf(CBTipoMoneda.Text = "DLS", 1, 2))
                cmd1.Parameters.AddWithValue("@IdVentaTotalComprador", IdLiquidacionTotal)
                cmd1.ExecuteNonQuery()
            Next Contador
            DGVSalidasSeleccionadas.Columns.Clear()
            For Contador = 0 To DGVSalidas.RowCount - 1
                If DGVSalidas.Rows(Contador).Cells("ChCol").Value = True Then
                    Dim cmd2 As New SqlCommand("sp_ActTotalComprador", cnn)
                    cmd2.CommandType = CommandType.StoredProcedure
                    cmd2.Parameters.AddWithValue("@idSalida", DGVSalidas.Rows(Contador).Cells("Id_Salida").Value.ToString)
                    cmd2.Parameters.AddWithValue("@TotalXliquidar", (CDbl(DGVSalidas.Rows(Contador).Cells("Total").Value)) / 1000)
                    cmd2.ExecuteNonQuery()
                End If
            Next Contador
            DGVSalidas.Columns.Clear()
            DGVSalidas.DataSource = Nothing
            LlenarDGVsalidas()
            PropiedadesDGVSalidas()
            Dim cmd4 As New SqlCommand("sp_InsertarVentaTotal", cnn)
            Dim TipoCambio, precioXTonMn, ImporteMn As Double
            TipoCambio = CDbl(IIf(TBTipoDeCambio.Text = "", 0, TBTipoDeCambio.Text))
            precioXTonMn = TBPrecioPorTonelada.Text
            ImporteMn = CDbl(TBImporte.Text)
            cmd4.CommandType = CommandType.StoredProcedure
            cmd4.Parameters.AddWithValue("@IdVentaTotalComprador", IdLiquidacionTotal)
            cmd4.Parameters.AddWithValue("@IdContratoVenta", TBIdContrato.Text)
            cmd4.Parameters.AddWithValue("@Idcomprador", TBIdComprador.Text)
            cmd4.Parameters.AddWithValue("@GrupoGrano", "AMARILLO")
            cmd4.Parameters.AddWithValue("@FechaVenta", Now)
            cmd4.Parameters.AddWithValue("@TotalVentaContrato", (NUDTotalLiquidar.Value / 1000))
            cmd4.Parameters.AddWithValue("@TipoDeCambio", TipoCambio)
            cmd4.Parameters.AddWithValue("@PrecioContrato", PrecioContrato)
            cmd4.Parameters.AddWithValue("@Moneda", IIf(CBTipoMoneda.Text = "DLS", 1, 2))
            cmd4.Parameters.AddWithValue("@PrecioToneladaMxn", TBPrecioPorTonelada.Text)
            cmd4.Parameters.AddWithValue("@ImporteTotal", ImporteMn)
            cmd4.Parameters.AddWithValue("@Contrato", TBContrato.Text)
            cmd4.Parameters.AddWithValue("@MetodoPago", TBMetodoPago.Text)
            cmd4.Parameters.AddWithValue("@Banco", TBBanco.Text)
            cmd4.Parameters.AddWithValue("@UltimosDigitos", TBUltimosDigitos.Text)
            cmd4.Parameters.AddWithValue("@ImporteLetra", UCase(letras(TBImporte.Text)))
            cmd4.Parameters.AddWithValue("@IdEmpresa", CBEmpresa.SelectedValue)
            cmd4.Parameters.AddWithValue("@IdTipoLiquidacion", IIf(RBTNSi.Checked = True, 0, 1))
            cmd4.ExecuteNonQuery()
            EstatusContrato()
            Dim cmd5 As New SqlCommand("sp_LlenarDGVTotalLiquidado", cnn)
            cmd5.CommandType = CommandType.StoredProcedure
            cmd5.Parameters.Add(New SqlClient.SqlParameter("@IdComprador", TBIdComprador.Text))
            Dim da5 As New SqlClient.SqlDataAdapter(cmd5)
            Dim dt5 As New DataSet()
            da5.Fill(dt5)
            DGVTotalLiquidado.DataSource = dt5.Tables(0).DefaultView
            PropiedadesDGVTotalLiquidado()
        Else
            MessageBox.Show("Las toneladas de boletas seleccionadas no coinciden con el total a liquidar, favor de verificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    Private Sub Buscar()
        Moneda = -1
        Dim BuscarCompradorLiquidacionVenta As New BuscarCompradorLiquidacionVenta
        BuscarCompradorLiquidacionVenta.ShowDialog()
        Dim CodigoComprador As Object = BuscarCompradorLiquidacionVenta.CodigoVenta

        If BuscarCompradorLiquidacionVenta.CodigoVenta <> Nothing Then
            LimpiarBusqueda()
            DesmarcarChecks()
            Dim cmd As New SqlCommand("sp_DatosContratoVenta", cnn)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@IdContratoVenta", BuscarCompradorLiquidacionVenta.CodigoVenta))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataSet()
            da.Fill(dt)

            TBIdContrato.Text = CStr(dt.Tables(0).Rows(0)("id_contratoV").ToString())
            TBIdComprador.Text = CStr(dt.Tables(0).Rows(0)("id_comprador").ToString())
            TBNombreComprador.Text = CStr(dt.Tables(0).Rows(0)("NombreComprador").ToString())
            NUDToneladasContrato.Value = CDbl(dt.Tables(0).Rows(0)("toneladasVentas").ToString())
            NUDToneladasRestantes.Value = CDbl(dt.Tables(0).Rows(0)("toneladasrestantes").ToString())
            PrecioContrato = CDbl(dt.Tables(0).Rows(0)("precioXtonelada").ToString())
            TbEstatusContrato.Text = IIf(dt.Tables(0).Rows(0)("EstatusContrato").ToString() = 0, "INCOMPLETO", "COMPLETO")
            Moneda = dt.Tables(0).Rows(0)("moneda").ToString()
            If dt.Tables(0).Rows(0)("TipoContrato").ToString() = 0 Then
                RBTNSi.Checked = True
            Else
                RBTNNo.Checked = True
            End If
            If Moneda = 1 Then
                CBTipoMoneda.SelectedItem = "DLS"
            Else
                CBTipoMoneda.SelectedItem = "MXN"
            End If
            CbMonedaVerificar()
            Dim cmd3 As New SqlCommand("sp_LlenaDGVTotalLiquidado", cnn)

            cmd3.CommandType = CommandType.StoredProcedure
            cmd3.Parameters.Add(New SqlClient.SqlParameter("@IdComprador", TBIdComprador.Text))

            Dim da3 As New SqlClient.SqlDataAdapter(cmd3)
            Dim dt3 As New DataSet()
            da3.Fill(dt3)
            Dim BanderaContrato As Integer
            If (dt3.Tables(0).Rows.Count = 0) Then

                BanderaContrato = 0
            Else
                BanderaContrato = dt.Tables(0).Rows(0)("EstatusContrato")
            End If
            If dt3.Tables(0).Rows.Count <> 0 Then
                TBNombreComprador.Text = dt3.Tables(0).Rows(0)("NombreComprador").ToString()
            Else
                TBNombreComprador.Text = dt.Tables(0).Rows(0)("NombreComprador").ToString()
            End If
            If BanderaContrato = 1 Then
                '    If RbNo.Checked = True Then
                '        RbContrato.Checked = True
                '        RbContrato.Enabled = True
                '        RbLibre.Checked = False
                '        RbLibre.Enabled = True
                '    Else
                '        RbContrato.Enabled = False
                '        RbLibre.Enabled = True
                '        RbContrato.Checked = False
                '        RbLibre.Checked = True
                '    End If
                'Else
                '    If RbSi.Checked = True Then
                '        RbContrato.Enabled = True
                '        RbLibre.Enabled = True
                '        RbContrato.Checked = True
                '        RbLibre.Checked = False
                '    Else
                '        RbContrato.Enabled = True
                '        RbLibre.Enabled = False
                '        RbContrato.Checked = True
                '        RbLibre.Checked = False
                '    End If
            End If
            DGVTotalLiquidado.DataSource = dt3.Tables(0).DefaultView
            PropiedadesDGVTotalLiquidado()
        End If
    End Sub
    Private Sub LimpiarBusqueda()
        TBTipoDeCambio.Text = ""
        NUDPrecioContrato.Value = 0.00
        TBPrecioPorTonelada.Text = ""
        TBImporte.Text = ""
        NUDToneladasSeleccionadas.Value = 0.00
        NUDTotalLiquidar.Value = 0.00
        CBTipoMoneda.SelectedItem = ""
        DGVSalidasSeleccionadas.Columns.Clear()
        DGVSalidasSeleccionadas.DataSource = Nothing
    End Sub
    Private Sub Imprimir()
        If TpBoletasXliquidar.Focus = True Then
            If DGVSalidasSeleccionadas.RowCount = 0 Then
                MessageBox.Show("No hay datos para imprimir.")
            Else
                _codigoLiquidacionVenta = IIf(IdLiquidacionTotal = Nothing, CStr(DGVTotalLiquidado.CurrentRow.Cells(0).Value), IdLiquidacionTotal)
                '_tipoContrato = IIf(RbContrato.Checked = True, 0, 1)
                Dim opc = MessageBox.Show("¿Desea imprimir el resumen de boletas?", "", MessageBoxButtons.YesNo)
                If opc = DialogResult.Yes Then
                    ReporteVentas.ShowDialog()
                    ReporteVentaResumen.ShowDialog()
                Else
                    ReporteVentas.ShowDialog()
                End If
            End If
        ElseIf TpBoletasLiquidadas.Focus = True Then
            If DGVTotalLiquidadoDetalle.RowCount = 0 Then
                MessageBox.Show("No hay datos para imprimir.")
            Else
                _codigoLiquidacionVenta = IIf(IdLiquidacionTotal = Nothing, CStr(DGVTotalLiquidado.CurrentRow.Cells(0).Value), IdLiquidacionTotal)
                '_tipoContrato = IIf(RbContratoLiquidado.Checked = True, 0, 1)
                Dim opc = MessageBox.Show("¿Desea imprimir el resumen de boletas?", "", MessageBoxButtons.YesNo)
                If opc = DialogResult.Yes Then
                    ReporteVentas.ShowDialog()
                    ReporteVentaResumen.ShowDialog()
                Else
                    ReporteVentas.ShowDialog()
                End If
            End If
        End If
    End Sub
    Private Sub EstatusContrato()
        Dim IdEstatusContrato As Integer
        Dim cmd As New SqlCommand("sp_ActEstatusContratoVenta", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Clear()
        cmd.Parameters.Add(New SqlClient.SqlParameter("@IdEstatusContrato", 0))
        cmd.Parameters.Add(New SqlClient.SqlParameter("@contrato", IdLiquidacionTotal))
        cmd.Parameters.Add(New SqlClient.SqlParameter("@sumapagado", NUDTotalLiquidar.Value))
        cmd.Parameters("@IdEstatusContrato").Direction = ParameterDirection.InputOutput
        cmd.ExecuteNonQuery()
        IdEstatusContrato = cmd.Parameters("@IdEstatusContrato").Value
        If IdEstatusContrato = 1 Then
            TbEstatusContrato.Text = "COMPLETO"
        Else
            TbEstatusContrato.Text = "INCOMPLETO"
        End If
    End Sub
    Private Sub BoletasLiquidadas(sender As Object, e As EventArgs) Handles DGVTotalLiquidado.DoubleClick
        DGVTotalLiquidadoDetalle.Columns.Clear()
        DGVTotalLiquidadoDetalle.DataSource = Nothing
        If DGVTotalLiquidado.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf DGVTotalLiquidado.CurrentRow IsNot Nothing Then
            Dim cmd3 As New SqlCommand("sp_LlenarDGVTotalLiquidadoDetalle", cnn)
            cmd3.CommandType = CommandType.StoredProcedure
            cmd3.Parameters.Add(New SqlClient.SqlParameter("@IdVentaTotalComprador", CStr(DGVTotalLiquidado.CurrentRow.Cells(0).Value)))
            Dim da3 As New SqlClient.SqlDataAdapter(cmd3)
            Dim dt3 As New DataSet()
            da3.Fill(dt3)
            DGVTotalLiquidadoDetalle.DataSource = dt3.Tables(0).DefaultView
            PropiedadesDGVTotalLiquidadoDetalle()

            Dim Tabla As New DataTable
            da3.Fill(Tabla)
            Dim row As DataRow = Tabla.Rows(0)
            '---------------------------------
            If row("IdTipoLiquidacion") = 0 Then
                RBTNContratoBL.Checked = True
            Else
                RBTNLibreBL.Checked = True
            End If
            '-----------------------------------------------
            'Dim cmd4 As New SqlCommand("sp_DatosTotalLiquidacion", cnn)
            'cmd4.CommandType = CommandType.StoredProcedure
            'cmd4.Parameters.Add(New SqlClient.SqlParameter("@idliquidacionT", CStr(DgLiquidacionesXTotal.CurrentRow.Cells(0).Value)))
            'Dim da4 As New SqlClient.SqlDataAdapter(cmd4)
            'Dim dt4 As New DataTable
            'da4.Fill(dt4)
            'Dim row As DataRow = dt4.Rows(0)
            ''---------------------------------
            'If row("IdTipoLiquidacion") = 0 Then
            '    RbContratoLiquidado.Checked = True
            'Else
            '    RbLibreLiquidado.Checked = True
            'End If
            ''-----------------------------------------------
            TBTipoDeCambioBL.Text = row("TipoDeCambio")
            NUDPrecioContratoBL.Value = row("PrecioContrato")
            NUDTotalLiquidadoBL.Value = row("TotalVentaContrato")
            CBTipoMonedaBL.SelectedItem = IIf(row("Moneda") = 1, "DLS", "MXN")
            TBPrecioPorToneladaBL.Text = row("PrecioToneladaMxn")
            TBImporteBL.Text = row("ImporteTotal")
            TBContratoBL.Text = CStr(row("Contrato"))
            TBMetodoPagoBL.Text = CStr(row("MetodoPago"))
            TBBancoBL.Text = CStr(row("Banco"))
            TBUltimosDigitosBL.Text = CStr(row("UltimosDigitos"))
        End If
    End Sub
    Private Sub CbMonedaVerificar()
        If CBTipoMoneda.SelectedItem = "DLS" Then
            TBPrecioPorTonelada.Text = ""
            NUDPrecioContrato.Value = PrecioContrato
            TBTipoDeCambio.Enabled = True
            TBPrecioPorTonelada.Enabled = False
        ElseIf CBTipoMoneda.SelectedItem = "MXN" Then
            TBPrecioPorTonelada.Text = PrecioContrato
            TBTipoDeCambio.Enabled = False
            TBPrecioPorTonelada.Enabled = True
            NUDPrecioContrato.Value = 0.00
        End If
    End Sub

    Private Sub CBTipoMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipoMoneda.SelectionChangeCommitted
        CbMonedaVerificar()
    End Sub
    Private Sub TBPrecioPorTonelada_TextChanged(sender As Object, e As PreviewKeyDownEventArgs) Handles TBTipoDeCambio.PreviewKeyDown, TBPrecioPorTonelada.PreviewKeyDown
        Dim tipoCambio As Double = 0
        Dim kilosAton As Double = 0
        Dim precioContrato As Double = 0
        Dim variable As Decimal
        If e.KeyCode = Keys.Enter Then
            If NUDTotalLiquidar.Value > 0 Then
                If CBTipoMoneda.Text = "MXN" Then
                    kilosAton = NUDTotalLiquidar.Value / 1000
                    TBImporte.Text = CDbl(TBPrecioPorTonelada.Text) * kilosAton
                    NUDPrecioContrato.Value = CDbl(TBPrecioPorTonelada.Text)
                    TBPrecioPorTonelada.Text = FormatNumber(Val(TBPrecioPorTonelada.Text), 2)
                    'TBPrecioPorTonelada.Text = Format(CType(variable, Decimal), "###0.###0")
                    TBImporte.Text = FormatNumber(Val(TBImporte.Text), 2)
                ElseIf CBTipoMoneda.Text = "DLS" Then
                    tipoCambio = CDbl(TBTipoDeCambio.Text)
                    precioContrato = NUDPrecioContrato.Value
                    kilosAton = NUDTotalLiquidar.Value / 1000
                    TBPrecioPorTonelada.Text = tipoCambio * NUDPrecioContrato.Value
                    variable = TBPrecioPorTonelada.Text
                    TBPrecioPorTonelada.Text = Format(CType(variable, Decimal), "###0.###0")
                    TBImporte.Text = TBPrecioPorTonelada.Text * kilosAton
                    TBImporte.Text = FormatNumber(Val(TBImporte.Text), 2)
                End If
            End If
        End If
        'TBPrecioPorTonelada.Text = FormatNumber(Val(variable), 2)
        'TBImporte.Text = FormatNumber(Val(TBImporte.Text), 2)
    End Sub
    Private Function VerificarVacios(ByVal valor As String) As Boolean
        Dim resultado As Boolean = False
        If CBTipoMoneda.SelectedItem = "DLS" Then
            If CBEmpresa.SelectedValue = Nothing Or NUDTotalLiquidar.Value = 0 Or TBTipoDeCambio.Text = "" Or TBImporte.Text = "" Then
                resultado = True
            End If
        End If
        If CBTipoMoneda.SelectedItem = "MXN" Then
            If CBEmpresa.SelectedValue = Nothing Or NUDTotalLiquidar.Value = 0 Or TBPrecioPorTonelada.Text = "" Or TBImporte.Text = "" Then
                resultado = True
            End If
        End If
        Return resultado
    End Function
End Class