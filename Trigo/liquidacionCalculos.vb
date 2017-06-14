Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class liquidacionCalculosProd
    Dim IdLiquidacionTotal As String
    Dim PrecioContrato As Double
    Dim Moneda As Integer
    Private Sub liquidacionCalculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        propiedadesDataProdSelec()
        NuContrato.Controls(0).Visible = False
        NuLibre.Controls(0).Visible = False
        NuPrecioContrato.Controls(0).Visible = False
        NuTonSeleccion.Controls(0).Visible = False
        RbContrato.Checked = False
        RbLibre.Checked = False
        llenarCombos()
        BtNuevo_Click(sender, e)
    End Sub
    Private _codigoLiquidacionTP As String
    Public Property codigoLiquidacionTP() As String
        Get
            Return _codigoLiquidacionTP
        End Get
        Set(value As String)
            _codigoLiquidacionTP = value
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
    Private Sub SoloNumerosTxCalidad(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub
    Private Sub llenarCombos()

        Dim cmdllenaCMon As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet

        cmdllenaCMon = New SqlCommand("sp_CbMoneda")
        cmdllenaCMon.CommandType = CommandType.StoredProcedure
        cmdllenaCMon.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCMon)
        ds = New DataSet()
        da.Fill(ds)
        CbMoneda.DataSource = ds.Tables(0)
        CbMoneda.DisplayMember = "tipo"
        CbMoneda.ValueMember = "idmoneda"
        CbMoneda.SelectedIndex = -1


        Dim cmdllenaCMonliq As SqlCommand

        cmdllenaCMonliq = New SqlCommand("sp_CbMoneda")
        cmdllenaCMonliq.CommandType = CommandType.StoredProcedure
        cmdllenaCMonliq.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCMonliq)
        ds = New DataSet()
        da.Fill(ds)
        CbMonedaLiquidado.DataSource = ds.Tables(0)
        CbMonedaLiquidado.DisplayMember = "tipo"
        CbMonedaLiquidado.ValueMember = "idmoneda"
        CbMonedaLiquidado.SelectedIndex = -1


        Dim cmdllenaCbComprador As SqlCommand

        cmdllenaCbComprador = New SqlCommand("sp_cbCompradoresContrato")
        cmdllenaCbComprador.CommandType = CommandType.StoredProcedure
        cmdllenaCbComprador.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbComprador)
        ds = New DataSet()
        da.Fill(ds)
        CbComprador.DataSource = ds.Tables(0)
        CbComprador.DisplayMember = "Nombre_Comprador"
        CbComprador.ValueMember = "Id_Comprador"
        CbComprador.SelectedIndex = -1

        Dim cmdllenaCbCompradorLiq As SqlCommand

        cmdllenaCbCompradorLiq = New SqlCommand("sp_cbCompradoresContrato")
        cmdllenaCbCompradorLiq.CommandType = CommandType.StoredProcedure
        cmdllenaCbCompradorLiq.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbCompradorLiq)
        ds = New DataSet()
        da.Fill(ds)

        CbCompradorLiquidado.DataSource = ds.Tables(0)
        CbCompradorLiquidado.DisplayMember = "Nombre_Comprador"
        CbCompradorLiquidado.ValueMember = "Id_Comprador"
        CbCompradorLiquidado.SelectedIndex = -1
    End Sub
    Private Sub BtNuevo_Click(sender As Object, e As EventArgs) Handles BtNuevo.Click
        PrecioContrato = 0
        Moneda = -1
        RbContrato.Checked = False
        RbLibre.Checked = False
        NuContrato.Value = 0
        NuLibre.Value = 0
        NuPrecioContrato.Value = 0
        NuTonSeleccion.Value = 0
        NuTotalLiquidar.Value = 0
        TxProductor.Text = ""
        TxIDcontratoC.Text = ""
        TxTipoCambio.Text = ""
        TxPrecioXtonMn.Text = 0
        TxImporte.Text = ""
        TxPrecioXtonLiquidado.Text = ""
        TxImporteLiquidado.Text = ""
        TxTipoCambioLiquidado.Text = ""
        CbMoneda.SelectedIndex = -1
        CbMoneda.Text = ""
        CbComprador.SelectedIndex = -1
        CbComprador.Text = ""
        TxNombreProductor.Text = ""
        TxEstatusContrato.Text = ""
        NuPrecioContratoLiquidado.Value = 0
        CbMonedaLiquidado.SelectedIndex = -1
        CbMonedaLiquidado.Text = ""
        CbCompradorLiquidado.SelectedIndex = -1
        CbCompradorLiquidado.Text = ""
        TxContratoLiquidado.Text = ""
        TxMetodoPagoLiquidado.Text = ""
        TxBancoLiquidado.Text = ""
        TxUltimosDigitosLiquidado.Text = ""
        NuTotalLiquidado.Value = 0
        RbNo.Checked = False
        RbSi.Checked = False
        RbContratoLiquidado.Checked = False
        RbLibreLiquidado.Checked = False
        DgEntradasLiq.Columns.Clear()
        DgEntradasLiq.DataSource = Nothing
        DgSeleccionLiquidaciones.Columns.Clear()
        DgSeleccionLiquidaciones.DataSource = Nothing
        propiedadesDataProdSelec()
        DgLiquidacionesXBoleta.Columns.Clear()
        DgLiquidacionesXBoleta.DataSource = Nothing
        DgLiquidacionesXTotal.Columns.Clear()
        DgLiquidacionesXTotal.DataSource = Nothing
    End Sub
    Private Sub propiedadesDataProdSelec()

        Dim colidentrada As New DataGridViewTextBoxColumn
        colidentrada.Name = "IdInventario"
        colidentrada.Visible = False
        DgSeleccionLiquidaciones.Columns.Insert(0, colidentrada)

        Dim colidboleta As New DataGridViewTextBoxColumn
        colidboleta.Name = "numeroBoleta"
        colidboleta.HeaderText = "Boleta"
        colidboleta.Width = 50
        DgSeleccionLiquidaciones.Columns.Insert(1, colidboleta)

        Dim colIdProductor As New DataGridViewTextBoxColumn
        colIdProductor.Name = "IdProductor"
        colIdProductor.Visible = False
        DgSeleccionLiquidaciones.Columns.Insert(2, colIdProductor)

        Dim colidfecha As New DataGridViewTextBoxColumn
        colidfecha.HeaderText = "Fecha"
        colidfecha.Width = 70
        colidfecha.Name = "Fecha_Pesaje"
        colidfecha.Visible = False
        DgSeleccionLiquidaciones.Columns.Insert(3, colidfecha)

        Dim ColGrano As New DataGridViewTextBoxColumn()
        ColGrano.HeaderText = "Grano"
        ColGrano.Width = 75
        ColGrano.Name = "grupoGrano"
        DgSeleccionLiquidaciones.Columns.Insert(4, ColGrano)

        Dim Colneto As New DataGridViewTextBoxColumn()
        Colneto.HeaderText = "Neto"
        Colneto.Width = 65
        Colneto.Name = "Neto"
        DgSeleccionLiquidaciones.Columns.Insert(5, Colneto)

        Dim Coldeducciones As New DataGridViewTextBoxColumn()
        Coldeducciones.HeaderText = "Deducciones"
        Coldeducciones.Width = 60
        Coldeducciones.Name = "Deducciones"
        DgSeleccionLiquidaciones.Columns.Insert(6, Coldeducciones)

        Dim Coltotal As New DataGridViewTextBoxColumn()
        Coltotal.HeaderText = "Total"
        Coltotal.Width = 70
        Coltotal.Name = "Total"
        DgSeleccionLiquidaciones.Columns.Insert(7, Coltotal)

        DgSeleccionLiquidaciones.Columns("Neto").DefaultCellStyle.Format = "###,##0.00"
        DgSeleccionLiquidaciones.Columns("Deducciones").DefaultCellStyle.Format = "###,##0.00"
        DgSeleccionLiquidaciones.Columns("Total").DefaultCellStyle.Format = "###,##0.00"

        DgSeleccionLiquidaciones.Columns("Neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgSeleccionLiquidaciones.Columns("Deducciones").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgSeleccionLiquidaciones.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub
    Private Sub propiedadesDataEntLiq()
        If DgSeleccionLiquidaciones.Columns("ChCol") Is Nothing Then
            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = ""
            checkBoxColumn.Width = 40
            checkBoxColumn.Name = "ChCol"
            DgEntradasLiq.Columns.Insert(13, checkBoxColumn)
        End If
        DgEntradasLiq.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
        DgEntradasLiq.Columns("IdInventario").Visible = False
        DgEntradasLiq.Columns("Id_cliente").Visible = False
        DgEntradasLiq.Columns("Bruto").Visible = False
        DgEntradasLiq.Columns("Tara").Visible = False
        DgEntradasLiq.Columns("conductorCam").Visible = False
        DgEntradasLiq.Columns("placasConductor").Visible = False
        DgEntradasLiq.Columns("nombreProductor").Visible = False
        DgEntradasLiq.Columns("numeroBoleta").ReadOnly = True
        DgEntradasLiq.Columns("Id_cliente").ReadOnly = True
        DgEntradasLiq.Columns("Fecha_Pesaje").ReadOnly = True
        DgEntradasLiq.Columns("grupoGrano").ReadOnly = True
        DgEntradasLiq.Columns("Bruto").ReadOnly = True
        DgEntradasLiq.Columns("Tara").ReadOnly = True
        DgEntradasLiq.Columns("Neto").ReadOnly = True
        DgEntradasLiq.Columns("conductorCam").ReadOnly = True
        DgEntradasLiq.Columns("placasConductor").ReadOnly = True
        DgEntradasLiq.Columns("Deducciones").ReadOnly = True
        DgEntradasLiq.Columns("Total").ReadOnly = False
        DgEntradasLiq.Columns("numeroBoleta").HeaderText = "Boleta"
        DgEntradasLiq.Columns("Fecha_Pesaje").HeaderText = "Fecha"
        DgEntradasLiq.Columns("grupoGrano").HeaderText = "Grano"
        DgEntradasLiq.Columns("Bruto").HeaderText = "Bruto"
        DgEntradasLiq.Columns("Tara").HeaderText = "Tara"
        DgEntradasLiq.Columns("Neto").HeaderText = "Neto"
        DgEntradasLiq.Columns("conductorCam").HeaderText = "Conductor"
        DgEntradasLiq.Columns("placasConductor").HeaderText = "Placas"
        DgEntradasLiq.Columns("Deducciones").HeaderText = "Total Deducciones"
        DgEntradasLiq.Columns("Total").HeaderText = "Total"
        DgEntradasLiq.Columns("numeroBoleta").Width = 100
        DgEntradasLiq.Columns("Fecha_Pesaje").Width = 100
        DgEntradasLiq.Columns("grupoGrano").Width = 100
        DgEntradasLiq.Columns("Bruto").Width = 100
        DgEntradasLiq.Columns("Tara").Width = 100
        DgEntradasLiq.Columns("Neto").Width = 100
        DgEntradasLiq.Columns("conductorCam").Width = 110
        DgEntradasLiq.Columns("placasConductor").Width = 90
        DgEntradasLiq.Columns("Deducciones").Width = 100
        DgEntradasLiq.Columns("Total").Width = 110
        DgEntradasLiq.Columns("Neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgEntradasLiq.Columns("Deducciones").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgEntradasLiq.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgEntradasLiq.Columns("Bruto").DefaultCellStyle.Format = "###,##0.00"
        DgEntradasLiq.Columns("Tara").DefaultCellStyle.Format = "###,##0.00"
        DgEntradasLiq.Columns("Neto").DefaultCellStyle.Format = "###,##0.00"
        DgEntradasLiq.Columns("Deducciones").DefaultCellStyle.Format = "###,##0.00"
        DgEntradasLiq.Columns("Total").DefaultCellStyle.Format = "###,##0.00"
        DgEntradasLiq.ClearSelection()
    End Sub
    Private Sub propiedadesDgLiquidacionTotal()
        DgLiquidacionesXTotal.Columns("idLiquidacionT").Visible = False
        DgLiquidacionesXTotal.Columns("idcontrato").Visible = False
        DgLiquidacionesXTotal.Columns("idproductor").Visible = False
        DgLiquidacionesXTotal.Columns("nombreProductor").Visible = False
        DgLiquidacionesXTotal.Columns("grupoGrano").HeaderText = "Tipo Maiz"
        DgLiquidacionesXTotal.Columns("fechaliquidacion").HeaderText = "Fecha de Liquidacion"
        DgLiquidacionesXTotal.Columns("totalliquidacionContrato").HeaderText = "Total liquidado (Ton)"
        DgLiquidacionesXTotal.Columns("importeTotal").HeaderText = "Importe"
        DgLiquidacionesXTotal.Columns("contrato").HeaderText = "Contrato"
        DgLiquidacionesXTotal.Columns("Nombre_Comprador").HeaderText = "Comprador"
        DgLiquidacionesXTotal.Columns("totalliquidacionContrato").DefaultCellStyle.Format = "###,##0.000"
        DgLiquidacionesXTotal.Columns("importeTotal").DefaultCellStyle.Format = "###,##0.00"
    End Sub
    Private Sub propiedadesDgLiquidacionesXBoleta()
        DgLiquidacionesXBoleta.Columns("idLiquidacionP").Visible = False
        DgLiquidacionesXBoleta.Columns("idInventario").Visible = False
        DgLiquidacionesXBoleta.Columns("idProductor").Visible = False
        DgLiquidacionesXBoleta.Columns("nombreProductor").Visible = False
        DgLiquidacionesXBoleta.Columns("numeroBoleta").HeaderText = "No. Boleta"
        DgLiquidacionesXBoleta.Columns("grupoGrano").HeaderText = "Tipo Maiz"
        DgLiquidacionesXBoleta.Columns("Neto").HeaderText = "Neto"
        DgLiquidacionesXBoleta.Columns("deduccion").HeaderText = "Deduccion"
        DgLiquidacionesXBoleta.Columns("Total").HeaderText = "Total"
        DgLiquidacionesXBoleta.Columns("Neto").DefaultCellStyle.Format = "###,##0.00"
        DgLiquidacionesXBoleta.Columns("deduccion").DefaultCellStyle.Format = "###,##0.00"
        DgLiquidacionesXBoleta.Columns("Total").DefaultCellStyle.Format = "###,##0.00"
    End Sub
    Private Sub TxBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        PrecioContrato = 0
        Moneda = -1
        Dim BuscarEntradaLiq As New BuscarEntradaLiq
        BuscarEntradaLiq.ShowDialog()
        Dim codigoproductor As Object = BuscarEntradaLiq.CodigoProductor
        If BuscarEntradaLiq.CodigoProductor <> Nothing Then
            DgLiquidacionesXBoleta.Columns.Clear()
            DgLiquidacionesXBoleta.DataSource = Nothing
            DgSeleccionLiquidaciones.Columns.Clear()
            DgSeleccionLiquidaciones.DataSource = Nothing
            DgEntradasLiq.Columns.Clear()
            DgEntradasLiq.DataSource = Nothing
            Dim cmd As New SqlCommand("sp_llenarDgEntradasliq", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@productor", BuscarEntradaLiq.CodigoProductor))
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataSet()
            da.Fill(dt)
            DgEntradasLiq.DataSource = dt.Tables(0).DefaultView
            propiedadesDataEntLiq()
            Dim cmd2 As New SqlCommand("Sp_DatosContratoLiquidacion", cnn)
            cmd2.CommandType = CommandType.StoredProcedure
            cmd2.Parameters.Add(New SqlClient.SqlParameter("@idcliente", BuscarEntradaLiq.CodigoProductor))
            Dim da2 As New SqlClient.SqlDataAdapter(cmd2)
            Dim dt2 As New DataSet()
            da2.Fill(dt2)
            TxIDcontratoC.Text = CStr(dt2.Tables(0).Rows(0)("id_contratoC").ToString())
            TxProductor.Text = CStr(dt2.Tables(0).Rows(0)("id_cliente").ToString())
            PrecioContrato = CDbl(dt2.Tables(0).Rows(0)("precioXtonelada").ToString())
            NuContrato.Value = CDbl(dt2.Tables(0).Rows(0)("toneladascompras").ToString())
            NuLibre.Value = CDbl(dt2.Tables(0).Rows(0)("toneladaslibresentradas").ToString())
            TxEstatusContrato.Text = IIf(dt2.Tables(0).Rows(0)("IdEstatusContrato").ToString() = 0, "INCOMPLETO", "COMPLETO")
            Moneda = dt2.Tables(0).Rows(0)("moneda").ToString()
            If dt2.Tables(0).Rows(0)("AceptaContratoLibre").ToString() = 1 Then
                RbSi.Checked = True
            Else
                RbNo.Checked = True
            End If
            Dim cmd3 As New SqlCommand("sp_llenaDgLiquidacionTotal", cnn)
            cmd3.CommandType = CommandType.StoredProcedure
            cmd3.Parameters.Add(New SqlClient.SqlParameter("@idproductor", BuscarEntradaLiq.CodigoProductor))
            Dim da3 As New SqlClient.SqlDataAdapter(cmd3)
            Dim dt3 As New DataSet()
            da3.Fill(dt3)
            Dim BanderaContrato As Integer
            If (dt3.Tables(0).Rows.Count = 0) Then
                BanderaContrato = 0
            Else
                BanderaContrato = dt2.Tables(0).Rows(0)("IdEstatusContrato")
            End If
            If dt3.Tables(0).Rows.Count <> 0 Then
                TxNombreProductor.Text = dt3.Tables(0).Rows(0)("nombreProductor").ToString()
            Else
                TxNombreProductor.Text = dt.Tables(0).Rows(0)("nombreProductor").ToString()
            End If
            If BanderaContrato = 1 Then
                If RbNo.Checked = True Then
                    RbContrato.Checked = True
                    RbContrato.Enabled = True
                    RbLibre.Checked = False
                    RbLibre.Enabled = True
                Else
                    RbContrato.Enabled = False
                    RbLibre.Enabled = True
                    RbContrato.Checked = False
                    RbLibre.Checked = True
                End If
            Else
                If RbSi.Checked = True Then
                    RbContrato.Enabled = True
                    RbLibre.Enabled = True
                    RbContrato.Checked = True
                    RbLibre.Checked = False
                Else
                    RbContrato.Enabled = True
                    RbLibre.Enabled = False
                    RbContrato.Checked = True
                    RbLibre.Checked = False
                End If
            End If
            DgLiquidacionesXTotal.DataSource = dt3.Tables(0).DefaultView
            propiedadesDgLiquidacionTotal()
            ContratoOLibre()
            VerificarSiSePuedeLiquidar()
        End If
    End Sub
    Private Sub BtGuardar_Click(sender As Object, e As EventArgs) Handles BtGuardar.Click
        If DgEntradasLiq.RowCount = 0 Then
            MessageBox.Show("No hay datos para guardar.")
        ElseIf NuTonSeleccion.Value = NuTotalLiquidar.Value Then
            IdLiquidacionTotal = ""
            Dim Contador As Integer
            IdLiquidacionTotal = generaCodigoLiquidacionT(IdLiquidacionTotal)
            For Contador = 0 To DgSeleccionLiquidaciones.RowCount - 1
                Dim CodigoLiquidacion As String = ""
                Dim cmd1 As New SqlCommand("sp_InsLiquidacionXproductor", cnn)
                cmd1.CommandType = CommandType.StoredProcedure

                cmd1.Parameters.Clear()
                cmd1.Parameters.AddWithValue("@idLiquidacionP", generaCodigoLiquidacionP(CodigoLiquidacion))
                cmd1.Parameters.AddWithValue("@idInventario", DgSeleccionLiquidaciones.Rows(Contador).Cells("IdInventario").Value.ToString)
                cmd1.Parameters.AddWithValue("@numeroBoleta", DgSeleccionLiquidaciones.Rows(Contador).Cells("numeroBoleta").Value)
                cmd1.Parameters.AddWithValue("@idProductor", DgSeleccionLiquidaciones.Rows(Contador).Cells("IdProductor").Value.ToString())
                cmd1.Parameters.AddWithValue("@nombreProductor", TxNombreProductor.Text)
                cmd1.Parameters.AddWithValue("@grupoGrano", DgSeleccionLiquidaciones.Rows(Contador).Cells("grupoGrano").Value.ToString())
                cmd1.Parameters.AddWithValue("@Neto", (CDbl(DgSeleccionLiquidaciones.Rows(Contador).Cells("Neto").Value)) / 1000)
                cmd1.Parameters.AddWithValue("@deduccion", (CDbl(DgSeleccionLiquidaciones.Rows(Contador).Cells("Deducciones").Value)) / 1000)
                cmd1.Parameters.AddWithValue("@Total", (CDbl(DgSeleccionLiquidaciones.Rows(Contador).Cells("Total").Value)) / 1000)
                cmd1.Parameters.AddWithValue("@idLiquidacionT", IdLiquidacionTotal)

                cmd1.ExecuteNonQuery()

            Next Contador
            DgSeleccionLiquidaciones.Columns.Clear()

            For Contador = 0 To DgEntradasLiq.RowCount - 1
                If DgEntradasLiq.Rows(Contador).Cells("ChCol").Value = True Then
                    Dim cmd2 As New SqlCommand("sp_ActTotalXliquidarProductor", cnn)

                    cmd2.CommandType = CommandType.StoredProcedure

                    cmd2.Parameters.AddWithValue("@idinventario", DgEntradasLiq.Rows(Contador).Cells("IdInventario").Value.ToString)
                    cmd2.Parameters.AddWithValue("@TotalXliquidar", (CDbl(DgEntradasLiq.Rows(Contador).Cells("Total").Value)) / 1000)
                    cmd2.ExecuteNonQuery()
                End If
            Next Contador

            DgEntradasLiq.Columns.Clear()
            DgEntradasLiq.DataSource = Nothing

            Dim cmd3 As New SqlCommand("sp_llenarDgEntradasliq", cnn)

            cmd3.CommandType = CommandType.StoredProcedure
            cmd3.Parameters.Add(New SqlClient.SqlParameter("@productor", TxProductor.Text))

            Dim da1 As New SqlClient.SqlDataAdapter(cmd3)
            Dim dt1 As New DataSet()
            da1.Fill(dt1)

            DgEntradasLiq.DataSource = dt1.Tables(0).DefaultView
            propiedadesDataEntLiq()

            Dim cmd4 As New SqlCommand("sp_InsLiquidacionTotXprod", cnn)

            Dim TipoCambio, precioXTonMn, ImporteMn As Double
            TipoCambio = CDbl(IIf(TxTipoCambio.Text = "", 0, TxTipoCambio.Text))
            precioXTonMn = TxPrecioXtonMn.Text
            ImporteMn = CDbl(TxImporte.Text)

            cmd4.CommandType = CommandType.StoredProcedure

            cmd4.Parameters.AddWithValue("@idLiquidacionT", IdLiquidacionTotal)
            cmd4.Parameters.AddWithValue("@idcontrato", TxIDcontratoC.Text)
            cmd4.Parameters.AddWithValue("@idproductor", TxProductor.Text)
            cmd4.Parameters.AddWithValue("@grupoGrano", "AMARILLO")
            cmd4.Parameters.AddWithValue("@fechaliquidacion", Now)
            cmd4.Parameters.AddWithValue("@totalliquidacionContrato", (NuTotalLiquidar.Value / 1000))
            cmd4.Parameters.AddWithValue("@totalliquidacionLibre", (NuTotalLiquidar.Value / 1000))
            cmd4.Parameters.AddWithValue("@tipodecambio", TipoCambio)
            cmd4.Parameters.AddWithValue("@precioContrato", NuPrecioContrato.Value)
            cmd4.Parameters.AddWithValue("@moneda", CbMoneda.SelectedValue)
            cmd4.Parameters.AddWithValue("@precioXtonMxn", precioXTonMn)
            cmd4.Parameters.AddWithValue("@importeTotal", ImporteMn)
            cmd4.Parameters.AddWithValue("@contrato", IIf(RbContrato.Checked = True, TxFolioContrato.Text, "LIBRE"))
            cmd4.Parameters.AddWithValue("@metodoPago", TxMetodoPago.Text)
            cmd4.Parameters.AddWithValue("@banco", TxBanco.Text)
            cmd4.Parameters.AddWithValue("@ultimosDigitos", TxUltimosDigitos.Text)
            cmd4.Parameters.AddWithValue("@importeLetra", UCase(letras(TxImporte.Text)))
            cmd4.Parameters.AddWithValue("@idcomprador", CbComprador.SelectedValue)
            cmd4.Parameters.AddWithValue("@tipoContrato", IIf(RbContrato.Checked = True, 0, 1))
            cmd4.Parameters.AddWithValue("@idTipoLiquidacion", IIf(RbContrato.Checked = True, 0, 1))

            cmd4.ExecuteNonQuery()
            EstatusContrato()


            Dim cmd5 As New SqlCommand("sp_llenaDgLiquidacionTotal", cnn)

            cmd5.CommandType = CommandType.StoredProcedure
            cmd5.Parameters.Add(New SqlClient.SqlParameter("@idproductor", TxProductor.Text))

            Dim da5 As New SqlClient.SqlDataAdapter(cmd5)
            Dim dt5 As New DataSet()
            da5.Fill(dt5)

            DgLiquidacionesXTotal.DataSource = dt5.Tables(0).DefaultView
            propiedadesDgLiquidacionTotal()
        Else
            MessageBox.Show("Las toneladas de boletas seleccionadas no coinciden con el total a liquidar, favor de verificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
        CbMonedaVerificar()
        LimpiarGuardar()
    End Sub
    Private Sub EstatusContrato()
        Dim IdEstatusContrato As Integer
        Dim cmd As New SqlCommand("sp_ActEstatusContrato", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Clear()
        cmd.Parameters.Add(New SqlClient.SqlParameter("@IdEstatusContrato", 0))
        cmd.Parameters.Add(New SqlClient.SqlParameter("@contrato", IdLiquidacionTotal))
        cmd.Parameters.Add(New SqlClient.SqlParameter("@sumapagado", NuTotalLiquidar.Value))
        cmd.Parameters("@IdEstatusContrato").Direction = ParameterDirection.InputOutput
        cmd.ExecuteNonQuery()
        IdEstatusContrato = cmd.Parameters("@IdEstatusContrato").Value
        If IdEstatusContrato = 1 Then
            TxEstatusContrato.Text = "COMPLETO"
        Else
            TxEstatusContrato.Text = "INCOMPLETO"
        End If
    End Sub
    Private Sub LimpiarGuardar()
        NuTonSeleccion.Value = 0.00
        NuTotalLiquidar.Value = 0.00
        CbComprador.SelectedValue = -1
        RbContratoLiquidado.Checked = False
        RbLibreLiquidado.Checked = False
        TxTipoCambioLiquidado.Text = ""
        TxTipoCambio.Text = ""
        NuPrecioContratoLiquidado.Value = 0.00
        NuPrecioContrato.Value = 0.00
        TxPrecioXtonLiquidado.Text = ""
        TxPrecioXtonMn.Text = ""
        TxImporteLiquidado.Text = ""
        TxImporte.Text = ""
        CbCompradorLiquidado.SelectedValue = -1
        CbComprador.SelectedValue = -1
        TxContratoLiquidado.Text = ""
        TxMetodoPagoLiquidado.Text = ""
        TxBancoLiquidado.Text = ""
        TxUltimosDigitosLiquidado.Text = ""
        '-----------------------------------
    End Sub

    Private Sub BtOperaciones_Click(sender As Object, e As EventArgs) Handles BtImprimir.Click
        If TpBoletasXliquidar.Focus = True Then
            If DgSeleccionLiquidaciones.RowCount = 0 Then
                MessageBox.Show("No hay datos para imprimir.")
            Else
                _codigoLiquidacionTP = IIf(IdLiquidacionTotal = Nothing, CStr(DgLiquidacionesXTotal.CurrentRow.Cells(0).Value), IdLiquidacionTotal)
                _tipoContrato = IIf(RbContrato.Checked = True, 0, 1)
                Dim opc = MessageBox.Show("¿Desea imprimir el resumen de boletas?", "", MessageBoxButtons.YesNo)
                If opc = DialogResult.Yes Then
                    ReporteLiquidacionesXprod.ShowDialog()
                    ReporteResumenBoletasLiquidadas.ShowDialog()
                Else
                    ReporteLiquidacionesXprod.ShowDialog()
                End If
            End If
        ElseIf TpBoletasLiquidadas.Focus = True Then
            If DgLiquidacionesXBoleta.RowCount = 0 Then
                MessageBox.Show("No hay datos para imprimir.")
            Else
                _codigoLiquidacionTP = IIf(IdLiquidacionTotal = Nothing, CStr(DgLiquidacionesXTotal.CurrentRow.Cells(0).Value), IdLiquidacionTotal)
                _tipoContrato = IIf(RbContratoLiquidado.Checked = True, 0, 1)
                Dim opc = MessageBox.Show("¿Desea imprimir el resumen de boletas?", "", MessageBoxButtons.YesNo)
                If opc = DialogResult.Yes Then
                    ReporteLiquidacionesXprod.ShowDialog()
                    ReporteResumenBoletasLiquidadas.ShowDialog()
                Else
                    ReporteLiquidacionesXprod.ShowDialog()
                End If
            End If
        End If
    End Sub
    Private Sub BtAgregar(sender As Object, e As EventArgs) Handles BtAgregarSeleccion.Click
        Agregar()
    End Sub
    Private Sub Agregar()
        DgSeleccionLiquidaciones.Columns.Clear()
        DgSeleccionLiquidaciones.DataSource = Nothing
        propiedadesDataProdSelec()
        Dim Contador As Integer

        For Contador = 0 To DgEntradasLiq.RowCount - 1
            If DgEntradasLiq.Rows(Contador).Cells("ChCol").Value = True Then

                DgSeleccionLiquidaciones.Rows.Add(DgEntradasLiq.Rows(Contador).Cells("IdInventario").Value.ToString(), DgEntradasLiq.Rows(Contador).Cells("numeroBoleta").Value, DgEntradasLiq.Rows(Contador).Cells("Id_cliente").Value.ToString(), DgEntradasLiq.Rows(Contador).Cells("Fecha_Pesaje").Value, DgEntradasLiq.Rows(Contador).Cells("grupoGrano").Value.ToString(), DgEntradasLiq.Rows(Contador).Cells("Neto").Value, DgEntradasLiq.Rows(Contador).Cells("Deducciones").Value, DgEntradasLiq.Rows(Contador).Cells("Total").Value)

            End If
        Next Contador

        Dim PuestosAcumulados As Double
        For Contador = 0 To DgSeleccionLiquidaciones.RowCount - 1

            PuestosAcumulados = PuestosAcumulados + DgSeleccionLiquidaciones.Rows(Contador).Cells("Total").Value

        Next Contador
        NuTotalLiquidar.Value = PuestosAcumulados
        PuestosAcumulados = 0
    End Sub
    Private Function verificarAgregado(ByVal idcliente As String) As Boolean
        Dim resultado As Boolean = False
        For Each row As DataGridViewRow In DgSeleccionLiquidaciones.Rows
            If idcliente = row.Cells("id_entrada").Value Then
                resultado = True
            End If
        Next
        Return resultado
    End Function
    Private Sub DgSeleccionLotes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgEntradasLiq.CellContentClick
        Dim Contador As Integer
        For Contador = 0 To DgEntradasLiq.RowCount - 1
            If DgEntradasLiq.Rows(Contador).Selected Then
                If DgEntradasLiq.Rows(Contador).Cells("ChCol").Value = False Then
                    DgEntradasLiq.Rows(Contador).Cells("ChCol").Value = True
                ElseIf DgEntradasLiq.Rows(Contador).Cells("ChCol").Value = True Then
                    DgEntradasLiq.Rows(Contador).Cells("ChCol").Value = False
                End If
            End If
        Next Contador

        ContarChecksMarcados()
    End Sub

    Private Sub ContarChecksMarcados()
        Dim PuestosAcumulados As Double

        For Each row As DataGridViewRow In DgEntradasLiq.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("ChCol").Value)
            If isSelected = True Then
                PuestosAcumulados = PuestosAcumulados + row.Cells("Total").Value.ToString()
            End If
        Next row
        NuTonSeleccion.Value = PuestosAcumulados
        PuestosAcumulados = 0
    End Sub
    Private Sub BoletasLiquidadas(sender As Object, e As EventArgs) Handles DgLiquidacionesXTotal.DoubleClick
        DgLiquidacionesXBoleta.Columns.Clear()
        DgLiquidacionesXBoleta.DataSource = Nothing

        If DgLiquidacionesXTotal.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf DgLiquidacionesXTotal.CurrentRow IsNot Nothing Then
            Dim cmd3 As New SqlCommand("sp_llenaDgBoletasLiquidadas", cnn)

            cmd3.CommandType = CommandType.StoredProcedure
            cmd3.Parameters.Add(New SqlClient.SqlParameter("@idliquidacionT", CStr(DgLiquidacionesXTotal.CurrentRow.Cells(0).Value)))

            Dim da3 As New SqlClient.SqlDataAdapter(cmd3)
            Dim dt3 As New DataSet()

            da3.Fill(dt3)
            DgLiquidacionesXBoleta.DataSource = dt3.Tables(0).DefaultView
            propiedadesDgLiquidacionesXBoleta()

            Dim cmd4 As New SqlCommand("sp_DatosTotalLiquidacion", cnn)

            cmd4.CommandType = CommandType.StoredProcedure
            cmd4.Parameters.Add(New SqlClient.SqlParameter("@idliquidacionT", CStr(DgLiquidacionesXTotal.CurrentRow.Cells(0).Value)))

            Dim da4 As New SqlClient.SqlDataAdapter(cmd4)
            Dim dt4 As New DataTable

            da4.Fill(dt4)
            Dim row As DataRow = dt4.Rows(0)
            '---------------------------------
            If row("IdTipoLiquidacion") = 0 Then
                RbContratoLiquidado.Checked = True
            Else
                RbLibreLiquidado.Checked = True
            End If
            '-----------------------------------------------
            TxTipoCambioLiquidado.Text = row("tipodecambio")
            NuPrecioContratoLiquidado.Value = row("preciocontrato")
            NuTotalLiquidado.Value = row("totalContratoTon")
            CbMonedaLiquidado.SelectedValue = row("moneda")
            TxPrecioXtonLiquidado.Text = row("precioXtonMxn")
            TxImporteLiquidado.Text = row("importeTotal")
            CbCompradorLiquidado.SelectedValue = CStr(row("idcomprador"))
            TxContratoLiquidado.Text = CStr(row("contrato"))
            TxMetodoPagoLiquidado.Text = CStr(row("metodopago"))
            TxBancoLiquidado.Text = CStr(row("banco"))
            TxUltimosDigitosLiquidado.Text = CStr(row("ultimosdigitos"))
        End If
    End Sub
    Private Sub ContratoOlibre(sender As Object, e As EventArgs) Handles RbContrato.CheckedChanged ', RbLibre.CheckedChanged        
        If RbLibre.Checked = True Then
            TxTipoCambio.Enabled = False
            TxTipoCambio.Text = ""
            NuPrecioContrato.Value = 0
            TxPrecioXtonMn.Enabled = True
            TxPrecioXtonMn.Text = ""
            CbMoneda.Enabled = True
            CbMoneda.SelectedValue = 2
            TxImporte.Text = ""
        Else
            TxPrecioXtonMn.Enabled = False
            TxPrecioXtonMn.Text = ""
            TxTipoCambio.Enabled = True
            TxImporte.Text = ""
            NuPrecioContrato.Value = PrecioContrato
            CbMoneda.SelectedValue = Moneda
            CbMoneda.Enabled = False
            NuPrecioContrato.Enabled = False
        End If
    End Sub
    Private Sub CbMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMoneda.SelectionChangeCommitted
        CbMonedaVerificar()
    End Sub
    Private Sub CbMonedaVerificar()
        If CbMoneda.SelectedValue = 1 Then
            NuPrecioContrato.Value = PrecioContrato
            TxTipoCambio.Enabled = True
            TxPrecioXtonMn.Enabled = False
        ElseIf CbMoneda.SelectedValue = 2 Then
            TxTipoCambio.Enabled = False
            TxPrecioXtonMn.Enabled = True
            NuPrecioContrato.Value = 0.00
        End If
    End Sub

    Private Sub ContratoOLibre()
        If RbSi.Checked = True And RbContrato.Checked = True Or RbSi.Checked = True And RbLibre.Checked = True Then
            If RbContrato.Checked = False And RbLibre.Checked = True Then
                TxTipoCambio.Enabled = False
                TxTipoCambio.Text = ""
                NuPrecioContrato.Value = 0
                TxPrecioXtonMn.Enabled = True
                TxPrecioXtonMn.Text = ""
                CbMoneda.Enabled = True
                CbMoneda.SelectedValue = -1
                TxImporte.Text = ""
            ElseIf RbContrato.Checked = True And RbLibre.Checked = False Then
                TxPrecioXtonMn.Enabled = False
                TxPrecioXtonMn.Text = ""
                TxTipoCambio.Enabled = True
                TxImporte.Text = ""
                NuPrecioContrato.Value = PrecioContrato
                CbMoneda.SelectedValue = Moneda
                CbMoneda.Enabled = False
                NuPrecioContrato.Enabled = False
            End If
        ElseIf RbSi.Checked = False And RbLibre.Checked = True Then
            MessageBox.Show("El Productor no tiene contrato libre", "Aviso")
            RbContrato.Checked = False
            RbLibre.Checked = False
        Else
            If RbContrato.Checked = False And RbLibre.Checked = True Then
                TxTipoCambio.Enabled = False
                TxTipoCambio.Text = ""
                NuPrecioContrato.Value = 0
                TxPrecioXtonMn.Enabled = True
                TxPrecioXtonMn.Text = ""
                CbMoneda.Enabled = True
                CbMoneda.SelectedValue = -1
                TxImporte.Text = ""
            ElseIf RbContrato.Checked = True And RbLibre.Checked = False Then
                TxPrecioXtonMn.Enabled = False
                TxPrecioXtonMn.Text = ""
                TxTipoCambio.Enabled = True
                TxImporte.Text = ""
                NuPrecioContrato.Value = PrecioContrato
                CbMoneda.SelectedValue = Moneda
                CbMoneda.Enabled = False
                NuPrecioContrato.Enabled = False
            End If
        End If
    End Sub

    Private Sub TxPrecioXtonMn_TextChanged(sender As Object, e As PreviewKeyDownEventArgs) Handles TxPrecioXtonMn.PreviewKeyDown
        Dim tipoCambio As Double = 0
        Dim kilosAton As Double = 0
        Dim precioContrato As Double = 0
        If e.KeyCode = Keys.Enter Then
            If NuTotalLiquidar.Value > 0 Then
                If RbContrato.Checked = False And RbLibre.Checked = True Then
                    kilosAton = NuTotalLiquidar.Value / 1000
                    TxImporte.Text = CDbl(TxPrecioXtonMn.Text) * kilosAton
                    NuPrecioContrato.Value = CDbl(TxPrecioXtonMn.Text)
                    TxPrecioXtonMn.Text = FormatNumber(Val(TxPrecioXtonMn.Text), 2)
                    TxImporte.Text = FormatNumber(Val(TxImporte.Text), 2)
                End If
            End If
        End If
    End Sub
    Private Sub TxTipoCambio_TextChanged(sender As Object, e As PreviewKeyDownEventArgs) Handles TxTipoCambio.PreviewKeyDown
        Dim variable As Decimal
        If e.KeyCode = Keys.Enter Then
            If NuTotalLiquidar.Value > 0 Then
                If RbContrato.Checked = True And RbLibre.Checked = False Then
                    Dim tipoCambio As Double = 0
                    Dim kilosAton As Double = 0
                    Dim precioContrato As Double = 0
                    tipoCambio = CDbl(TxTipoCambio.Text)
                    precioContrato = NuPrecioContrato.Value
                    kilosAton = NuTotalLiquidar.Value / 1000
                    TxPrecioXtonMn.Text = tipoCambio * NuPrecioContrato.Value
                    variable = TxPrecioXtonMn.Text
                    TxPrecioXtonMn.Text = Format(CType(variable, Decimal), "###0.###0")
                    TxImporte.Text = TxPrecioXtonMn.Text * kilosAton
                ElseIf CbMoneda.SelectedValue = 1 Then
                    Dim tipoCambio As Double = 0
                    Dim kilosAton As Double = 0
                    Dim precioContrato As Double = 0
                    tipoCambio = CDbl(TxTipoCambio.Text)
                    precioContrato = NuPrecioContrato.Value
                    kilosAton = NuTotalLiquidar.Value / 1000
                    TxPrecioXtonMn.Text = tipoCambio * NuPrecioContrato.Value
                    variable = TxPrecioXtonMn.Text
                    TxPrecioXtonMn.Text = Format(CType(variable, Decimal), "###0.###0")
                    TxImporte.Text = TxPrecioXtonMn.Text * kilosAton
                End If
            End If
        End If
        TxPrecioXtonMn.Text = FormatNumber(Val(variable), 2)
        TxImporte.Text = FormatNumber(Val(TxImporte.Text), 2)
    End Sub
    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        DgEntradasLiq.Columns.Clear()
        DgEntradasLiq.DataSource = Nothing
        Close()
    End Sub
    Private Sub VerificarSiSePuedeLiquidar()
        Dim SumaTotal As Double
        Dim resultadoDiferencia As Double
        Dim Diferencia As Double
        If DgLiquidacionesXTotal.Rows().Count = 0 Then
            For Contador = 0 To DgEntradasLiq.RowCount - 1
                DgEntradasLiq.Rows(Contador).Cells("ChCol").Value = True
                SumaTotal = SumaTotal + DgEntradasLiq.Rows(Contador).Cells("Total").Value.ToString()
                If SumaTotal >= NuContrato.Value Then
                    Diferencia = SumaTotal - NuContrato.Value
                    'MessageBox.Show("El Productor ha completado su contrato", "Aviso")
                    Dim opc = MessageBox.Show("El Productor ha completado su contrato, ¿Desea liquidar el total del contrato?", "Aviso", MessageBoxButtons.YesNo)
                    If opc = DialogResult.Yes Then
                        resultadoDiferencia = DgEntradasLiq.Rows(Contador).Cells("Total").Value.ToString() - Diferencia
                        DgEntradasLiq.Rows(Contador).Cells("Total").Value = resultadoDiferencia
                        DgEntradasLiq.Rows(Contador).Cells("ChCol").Value = True
                        Agregar()
                    Else
                        For Contador1 = 0 To DgEntradasLiq.RowCount - 1
                            DgEntradasLiq.Rows(Contador1).Cells("ChCol").Value = False
                        Next

                    End If
                    Exit For
                End If
            Next Contador
            If SumaTotal < NuContrato.Value Then
                For Contador1 = 0 To DgEntradasLiq.RowCount - 1
                    DgEntradasLiq.Rows(Contador1).Cells("ChCol").Value = False
                Next
            End If
            ContarChecksMarcados()
        End If
    End Sub
End Class
