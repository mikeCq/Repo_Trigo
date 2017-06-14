Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ControlSalidas
    Dim resTon, valSalLib, valSalCon, deduccionGrandan, deduccionHumedad, deduccionImpurezas, deduccionPanzaB, deduccionPesoEsp, deduccionGranQ, calculoPanzaB, calculoHumedad, calculoPuntaNegra, calculaImpureza, calculaGranoDan, calculoGranQ, calculoPesoE As Double
    Dim compruebaSalidas As String
    Private Sub Salidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxIdBoleta.Select()
        llenarCombos()
        BtnNuevo_Click(sender, e)
        CargarData()
        DataGridPropiedades()
        ControlesSinTab()

    End Sub
    Private _codigoSalida As String
    Public Property codigoSalida() As String
        Get
            Return _codigoSalida
        End Get
        Set(ByVal value As String)
            _codigoSalida = value
        End Set
    End Property
    Private _Cachanilla As String
    Public Property Cachanilla() As String
        Get
            Return _Cachanilla
        End Get
        Set(value As String)
            _Cachanilla = value
        End Set
    End Property
    Private _cristalino As String
    Public Property MaizBlanco() As String
        Get
            Return _cristalino
        End Get
        Set(value As String)
            _cristalino = value
        End Set
    End Property
    Private Sub ControlesSinTab()
        BtnNuevo.TabStop = False
        BtnGuardar.TabStop = False
        BtnModificar.TabStop = False
        BtImprimir.TabStop = False
        BtnEliminar.TabStop = False
        BtnRestaurar.TabStop = False
        BtnSalir.TabStop = False
        DgBoletaSalidas.TabStop = False
    End Sub
    Private Sub BloqueoFases()
        If TxFolio.Text = "" And CbNombre.Text = "" And Val(TxBruto.Text) = 0 Then
            BtnSalir.TabStop = False
            DTPSalidas.Enabled = True
            TxIdBoleta.Enabled = True
            CbNombre.Enabled = True
            GbGrupoGrano.Enabled = True
            CbLugarExp.Enabled = True
            TxBruto.Enabled = False
            TxTara.Enabled = True
            TxNeto.Enabled = False
            GbCalidad.Enabled = False
            CbAcopio.Enabled = False
            CbAlmacen.Enabled = False
            CBContrato.Enabled = True
            CBConductor.Enabled = True
            TxPlacas.Enabled = True
            CBAnalista.Enabled = False
            BtImprimir.Enabled = False
            RBTCachanilla.Checked = False
            RBTCristalino.Checked = False
        ElseIf Val(TxBruto.Text) = 0 And CbAlmacen.Text = "" And CbAcopio.Text = "" Then
            TxTara.Enabled = False
            TxIdBoleta.Enabled = False
            TxBruto.Enabled = True
            GbCalidad.Enabled = False
            CBAnalista.Enabled = False
            CbLugarExp.Enabled = False
            DTPSalidas.Enabled = False
            CbNombre.Enabled = False
            GbGrupoGrano.Enabled = False
            CbAcopio.Enabled = True
            CbAlmacen.Enabled = True
            CBContrato.Enabled = False
            TxPlacas.Enabled = False
            CBConductor.Enabled = False
            BtImprimir.Enabled = False
        ElseIf TxFolio.Text <> "" And CBAnalista.Text = "" And Val(TxPesoEsp.Text) = 0 Then
            TxTara.Enabled = False
            TxIdBoleta.Enabled = False
            GbCalidad.Enabled = True
            CBAnalista.Enabled = True
            CbLugarExp.Enabled = False
            DTPSalidas.Enabled = False
            CbNombre.Enabled = False
            GbGrupoGrano.Enabled = False
            TxBruto.Enabled = False
            CbAcopio.Enabled = False
            CbAlmacen.Enabled = False
            CBContrato.Enabled = False
            TxPlacas.Enabled = False
            CBConductor.Enabled = False
            BtImprimir.Enabled = False
        ElseIf Val(TxBruto.Text) > 0 And Val(TxTotal.Text) > 0 Then
            TxTara.Enabled = False
            TxIdBoleta.Enabled = False
            TxBruto.Enabled = False
            GbCalidad.Enabled = False
            CBAnalista.Enabled = False
            CbLugarExp.Enabled = False
            DTPSalidas.Enabled = False
            CbNombre.Enabled = False
            GbGrupoGrano.Enabled = False
            CbAcopio.Enabled = False
            CbAlmacen.Enabled = False
            CBContrato.Enabled = False
            TxPlacas.Enabled = False
            CBConductor.Enabled = False
            BtImprimir.Enabled = True
        End If
    End Sub
    Private Sub calculos()

        deduccionGrandan = 0
        deduccionHumedad = 0
        deduccionImpurezas = 0
        deduccionGranQ = 0
        deduccionPesoEsp = 0

        calculaImpureza = 0
        deduccionGrandan = 0
        calculoHumedad = 0
        calculoGranQ = 0
        calculoPesoE = 0

        TxImpurezas.Text = FormatNumber(TxImpurezas.Text, 2)
        TxGranoDan.Text = FormatNumber(TxGranoDan.Text, 2)
        TxHumedad.Text = FormatNumber(TxHumedad.Text, 2)
        TxGranoQuebrado.Text = FormatNumber(TxGranoQuebrado.Text, 2)
        TxPesoEsp.Text = FormatNumber(TxPesoEsp.Text, 2)

        If Val(TxImpurezas.Text) > 2 And Val(TxImpurezas.Text) <= 8 Then
            Dim RI As Double = 0
            RI = CDbl(TxImpurezas.Text) - 2
            'Dim cmd As New SqlCommand("Sp_CalculoImpureza", cnn)
            'cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add(New SqlClient.SqlParameter("@Porcentaje", TxImpurezas.Text))
            'Dim da As New SqlClient.SqlDataAdapter(cmd)
            'Dim dt As New DataTable
            'da.Fill(dt)
            'Dim row As DataRow = dt.Rows(0)
            'deduccionImpurezas = row("deduccion")
            calculaImpureza = (((RI / 0.1) * 1) * CDbl(TxNeto.Text)) / 1000
            'calculaImpureza = (CDbl(TxNeto.Text) / 1000) * deduccionImpurezas
            ' ElseIf Val(TxImpurezas.Text) > 5 Then

        Else
            calculaImpureza = 0
        End If
        If Val(TxGranoDan.Text) > 5 And Val(TxGranoDan.Text) <= 10 Then
            Dim RG As Double = 0
            RG = CDbl(TxGranoDan.Text) - 5
            'Dim cmd As New SqlCommand("Sp_CalculoGranDan", cnn)
            'cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add(New SqlClient.SqlParameter("@Porcentaje", TxGranoDan.Text))
            'Dim da As New SqlClient.SqlDataAdapter(cmd)
            'Dim dt As New DataTable
            'da.Fill(dt)
            'Dim row As DataRow = dt.Rows(0)
            'deduccionGrandan = row("deduccion")
            calculaGranoDan = (((RG / 0.1) * 1) * CDbl(TxNeto.Text)) / 1000
            'ElseIf Val(TxGranoDan.Text) > 3.0 Then

        Else
            calculaGranoDan = 0
        End If
        If Val(TxHumedad.Text) > 14 And Val(TxHumedad.Text) <= 18 Then
            Dim RH As Double = 0
            RH = CDbl(TxHumedad.Text) - 14
            'Dim cmd As New SqlCommand("Sp_CalculoHumedad", cnn)
            'cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add(New SqlClient.SqlParameter("@Porcentaje", TxHumedad.Text))
            'Dim da As New SqlClient.SqlDataAdapter(cmd)
            'Dim dt As New DataTable
            'da.Fill(dt)
            'Dim row As DataRow = dt.Rows(0)
            'deduccionHumedad = row("deduccion")
            calculoHumedad = (((RH / 0.1) * 1.16) * CDbl(TxNeto.Text)) / 1000
            'calculoHumedad = (CDbl(TxNeto.Text) / 1000) * deduccionHumedad
            ' ElseIf Val(TxHumedad.Text) > 15.0 Then

        Else
            calculoHumedad = 0
        End If
        If Val(TxGranoQuebrado.Text) > 3.5 And Val(TxGranoQuebrado.Text) <= 10 Then
            Dim RG As Double = 0
            RG = CDbl(TxGranoQuebrado.Text) - 3.5
            'Dim cmd As New SqlCommand("Sp_CalculoGranoQueb", cnn)
            'cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add(New SqlClient.SqlParameter("@Porcentaje", TxGranoQuebrado.Text))
            'Dim da As New SqlClient.SqlDataAdapter(cmd)
            'Dim dt As New DataTable
            'da.Fill(dt)
            'Dim row As DataRow = dt.Rows(0)
            'deduccionGranQ = row("deduccion")
            calculoGranQ = (((RG / 0.1) * 1) * CDbl(TxNeto.Text)) / 1000

            ' ElseIf Val(TxGranoQuebrado.Text) > 3 Then

        Else
            calculoGranQ = 0
        End If
        If Val(TxPesoEsp.Text) > 70 Then
            Dim cmd As New SqlCommand("Sp_CalculoPesoEsp", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Porcentaje", TxPesoEsp.Text))
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim row As DataRow = dt.Rows(0)
            deduccionPesoEsp = row("deduccion")
            calculoPesoE = (CDbl(TxNeto.Text) / 1000) * deduccionPesoEsp

            ' ElseIf Val(TxGranoQuebrado.Text) > 3 Then
        Else
            calculoPesoE = 0
        End If
        TxDeducciones.Text = calculaGranoDan + calculoHumedad + calculaImpureza + calculoGranQ + calculoPesoE
        TxDeducciones.Text = FormatNumber(TxDeducciones.Text, 2)
        TxTotal.Text = Val(TxNeto.Text - TxDeducciones.Text)
        TxTotal.Text = FormatNumber(TxTotal.Text, 2)
    End Sub
    Private Sub BtImprimir_Click(sender As Object, e As EventArgs) Handles BtImprimir.Click
        If RBTCachanilla.Checked = True And RBTCristalino.Checked = False Then
            _Cachanilla = "X"
            _cristalino = " "
        ElseIf RBTCristalino.Checked = True And RBTCachanilla.Checked = False Then
            _cristalino = "X"
            _Cachanilla = " "
        End If
        _codigoSalida = TxFolio.Text
        ReporteBoletasSalidas.Show()
    End Sub
    Private Sub SoloNumerosTx(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTara.KeyPress, TxNeto.KeyPress, TxImpurezas.KeyPress, TxGranoDan.KeyPress, TxIdBoleta.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub
    Private Sub capacidadSilo() Handles CbAlmacen.SelectionChangeCommitted
        Dim cmd As New SqlCommand("Sp_PbAlmacen", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@idacopio", CbAcopio.SelectedValue))
        cmd.Parameters.Add(New SqlClient.SqlParameter("@idalmacen", CbAlmacen.SelectedValue))

        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)
        Dim row As DataRow = dt.Rows(0)
        PbSilos.Minimum = 0
        PbSilos.Maximum = row("capacidad")
        PbSilos.Value = row("tonentradas")
        LbToneladas.Text = FormatNumber(CStr(row("tonentradas")), 3)
        LbCapacidad.Text = FormatNumber(CStr(row("capacidad")), 3)
    End Sub
    Private Sub CambioControlPesoBruto(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            If Val(TxBruto.Text) > 0 Then
                TxNeto.Text = Val(TxBruto.Text - TxTara.Text)
                TxNeto.Text = FormatNumber(TxNeto.Text, 2)
            End If
            If Val(TxBruto.Text) > 0 And Val(TxNeto.Text) > 0 And Val(TxNeto.Text) > 0 And Val(TxPesoEsp.Text) > 0 Then calculos()
        End If
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim numeroBoleta As Integer = 0
        Dim estadoSalida As Integer = 0
        If verificaBoletaSalida(TxIdBoleta.Text) = True And TxFolio.Text = "" Then
            MessageBox.Show("El numero de boleta " & TxIdBoleta.Text & " ya existe", "Aviso")
        ElseIf salidaRegistrada(TxFolio.Text, estadoSalida) = True Then
            If TxFolio.Text = "" And CbNombre.Text <> "" Then
                If Val(TxTara.Text) = 0 Or CbLugarExp.Text = "" Or CBConductor.Text = "" Or TxPlacas.Text = "" Or (RBTCristalino.Checked = False And RBTCachanilla.Checked = False) Then
                    MessageBox.Show("Verifica campos en blanco", "Aviso")
                Else
                    Try
                        BloqueoFases()
                        Dim Fase1 As New SqlCommand("Sp_InsNueSalidasFase1", cnn)

                        Fase1.CommandType = CommandType.StoredProcedure

                        Fase1.Parameters.AddWithValue("@Consecutivo", generaCodigoSalida(TxFolio.Text))
                        Fase1.Parameters.AddWithValue("@numeroBoleta", TxIdBoleta.Text)
                        Fase1.Parameters.AddWithValue("@NomVendedor", CbNombre.SelectedValue)
                        Fase1.Parameters.AddWithValue("@domicilioProductor", "")
                        Fase1.Parameters.AddWithValue("@grupoGrano", IIf(RBTCachanilla.Checked = True, "AMARILLO", "BLANCO"))
                        Fase1.Parameters.AddWithValue("@lugarExpedicion", CbLugarExp.Text)
                        Fase1.Parameters.AddWithValue("@fechaPesaje", DTPSalidas.Text)
                        Fase1.Parameters.AddWithValue("@tara", (CDbl(TxTara.Text)) / 1000)
                        Fase1.Parameters.AddWithValue("@contratoComprador", CBContrato.SelectedValue)
                        Fase1.Parameters.AddWithValue("@conductorCam", UCase(CBConductor.Text))
                        Fase1.Parameters.AddWithValue("@placasConductor", UCase(TxPlacas.Text))
                        Fase1.Parameters.AddWithValue("@Estado", 0)

                        TxFolio.Text = Fase1.Parameters("@Consecutivo").Value.ToString()

                        Fase1.ExecuteNonQuery()
                        CargarData()
                        DataGridPropiedades()

                    Catch ex As Exception
                        MsgBox("Error", MsgBoxStyle.Critical)
                    End Try
                End If
            ElseIf TxFolio.Text <> "" And CbNombre.Text <> "" And Val(TxBruto.Text) > 0 And CbAcopio.Text <> "" And CbAlmacen.Text <> "" And Val(TxPesoEsp.Text) = 0 Then
                If Val(TxBruto.Text) = 0 Or Val(TxNeto.Text) = 0 Or CbAcopio.Text = "" Or CbAlmacen.Text = "" Then
                    MessageBox.Show("Verifica campos en blanco", "Aviso")
                Else
                    Try
                        BloqueoFases()
                        Dim Fase2 As New SqlCommand("Sp_InsNueSalidasFase2", cnn)

                        Fase2.CommandType = CommandType.StoredProcedure
                        Fase2.Parameters.AddWithValue("@Consecutivo", TxFolio.Text)
                        Fase2.Parameters.AddWithValue("@bruto", (CDbl(TxBruto.Text)) / 1000)
                        Fase2.Parameters.AddWithValue("@neto", (CDbl(TxNeto.Text)) / 1000)
                        Fase2.Parameters.AddWithValue("@CentroAcopio", CbAcopio.SelectedValue)
                        Fase2.Parameters.AddWithValue("@almacen", CbAlmacen.SelectedValue)

                        Fase2.ExecuteNonQuery()
                        CargarData()
                        DataGridPropiedades()
                        TxHumedad.Select()
                    Catch ex As Exception
                        MsgBox("Error", MsgBoxStyle.Critical)
                    End Try

                End If
            ElseIf TxFolio.Text <> "" And Val(TxTotal.Text) > 0 And CBAnalista.Text <> "" And Val(TxPesoEsp.Text) > 0 Then
                If TxImpurezas.Text = "" Or TxGranoDan.Text = "" Or TxGranoQuebrado.Text = "" Or TxHumedad.Text = "" Or Val(TxPesoEsp.Text) = 0 Or CBAnalista.Text = "" Then
                    MessageBox.Show("Verifica campos en blanco", "Aviso")
                Else
                    Try
                        BloqueoFases()
                        Dim Fase3 As New SqlCommand("Sp_InsNueSalidasFase3", cnn)

                        Fase3.CommandType = CommandType.StoredProcedure

                        Fase3.Parameters.AddWithValue("@Consecutivo", TxFolio.Text)
                        Fase3.Parameters.AddWithValue("@humedad", CDbl(TxHumedad.Text))
                        Fase3.Parameters.AddWithValue("@kilosXtonHum", FormatNumber(calculoHumedad, 2))
                        Fase3.Parameters.AddWithValue("@impurezas", CDbl(TxImpurezas.Text))
                        Fase3.Parameters.AddWithValue("@kilosXtonImp", FormatNumber(calculaImpureza, 2))
                        Fase3.Parameters.AddWithValue("@granoDanado", CDbl(TxGranoDan.Text))
                        Fase3.Parameters.AddWithValue("@kilosXtonGrDa", FormatNumber(calculaGranoDan, 2))
                        Fase3.Parameters.AddWithValue("@pesoEspecifico", CDbl(TxPesoEsp.Text))
                        Fase3.Parameters.AddWithValue("@kilosXtonPeEs", FormatNumber(calculoPesoE, 2))
                        Fase3.Parameters.AddWithValue("@granoQuebrado", CDbl(TxGranoQuebrado.Text))
                        Fase3.Parameters.AddWithValue("@kilosXtonGrQu", FormatNumber(calculoGranQ, 2))
                        Fase3.Parameters.AddWithValue("@deducciones", (CDbl(TxDeducciones.Text)) / 1000)
                        Fase3.Parameters.AddWithValue("@total", (CDbl(TxTotal.Text)) / 1000)
                        Fase3.Parameters.AddWithValue("@usuarioAnalista", CBAnalista.SelectedValue)
                        Fase3.Parameters.AddWithValue("@Estado", 1)

                        Fase3.ExecuteNonQuery()
                        CargarData()
                        DataGridPropiedades()
                        actualizaCapacidadSilo()
                        capacidadSilo()
                    Catch ex As Exception
                        MsgBox(ex, MsgBoxStyle.Critical)
                    End Try
                End If
            End If
        ElseIf TxFolio.Text <> "" Then
            MessageBox.Show("No se puede guardar esta boleta, ya se ha completado su registro.", "Aviso")
        Else
            MessageBox.Show("Campos vacios", "")
        End If
    End Sub
    Private Sub actualizaCapacidadSilo()
        Dim PesoNeto As Double = 0
        PesoNeto = CDbl(TxNeto.Text) / 1000
        Dim cmd As New SqlCommand("sp_ActCapacidadSilosSalidas", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@idacopio", CbAcopio.SelectedValue)
        cmd.Parameters.AddWithValue("@idalmacen", CbAlmacen.SelectedValue)
        cmd.Parameters.AddWithValue("@toneladasSal", PesoNeto)
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub SumaToneladasContrato()
        Dim cmd As New SqlCommand("sp_InsSumaEntradas", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@idcliente", CbNombre.SelectedValue)
        cmd.Parameters.AddWithValue("@identrada", TxFolio.Text)
        cmd.Parameters.AddWithValue("@toneladasEntradas", valSalCon)
        cmd.Parameters.AddWithValue("@toneladasLibres", valSalLib)
        cmd.Parameters.AddWithValue("@Caso", compruebaSalidas)
        cmd.ExecuteNonQuery()

        resTon = 0
        valSalLib = 0
        valSalCon = 0
        compruebaSalidas = ""
    End Sub
    Private Function CompruebaToneladasEntradas(ByRef compruebaEntradas As String) As String
        Dim cmd As New SqlCommand("sp_VerificaContratoEntradas", cnn)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@idcliente", CbNombre.SelectedValue))

        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)
        Dim row As DataRow = dt.Rows(0)
        compruebaEntradas = ""
        resTon = 0
        valSalLib = 0
        valSalCon = 0
        If row("aceptacontratolibre") = 0 Then

            If (row("toneladasentradas") + CDbl(TxNeto.Text)) < row("toneladascompras") Then
                resTon = row("toneladascompras") - (row("toneladasentradas") + CDbl(TxNeto.Text))
                If resTon <= 60000 Then
                    valSalCon = CDbl(TxNeto.Text)
                    valSalLib = 0
                    compruebaEntradas = "1" 'FALTAN 60 TONELADAS PARA COMPLETAR EL CONTRATO
                ElseIf resTon > 60000 Then
                    valSalCon = CDbl(TxNeto.Text)
                    valSalLib = 0
                    compruebaEntradas = "0" 'TIENE BASTANTE RANGO PARA LLEGAR AL LIMITE DE CONTRATO
                End If
            ElseIf (row("toneladasentradas") + CDbl(TxNeto.Text)) >= row("toneladascompras") Then
                resTon = (row("toneladasentradas") + CDbl(TxNeto.Text)) - row("toneladascompras")
                If resTon = 0 Then
                    valSalCon = CDbl(TxNeto.Text)
                    valSalLib = 0
                    compruebaEntradas = "4" 'SE COMPLETO EL CONTRATO SIN SOBRANTE 
                ElseIf resTon > 0 Then
                    valSalCon = CDbl(TxNeto.Text)
                    valSalLib = 0
                    compruebaEntradas = "5" 'SE COMPLETO EL CONTRATO CON SOBRANTE SIN CONTRATO LIBRE
                End If
            End If
        Else
            If (row("toneladasentradas") + CDbl(TxNeto.Text)) < row("toneladascompras") Then
                resTon = row("toneladascompras") - (row("toneladasentradas") + CDbl(TxNeto.Text))
                If resTon <= 60000 Then
                    valSalCon = CDbl(TxNeto.Text)
                    valSalLib = 0
                    compruebaEntradas = "1" 'FALTAN 60 TONELADAS PARA COMPLETAR EL CONTRATO
                ElseIf resTon > 60000 Then
                    valSalCon = CDbl(TxNeto.Text)
                    valSalLib = 0
                    compruebaEntradas = "0" 'TIENE BASTANTE RANGO PARA LLEGAR AL LIMITE DE CONTRATO
                End If
            ElseIf row("toneladasentradas") = row("toneladascompras") And row("toneladaslibresEntradas") > 0 Then
                valSalLib = CDbl(TxNeto.Text)
                valSalCon = row("toneladasentradas")
                compruebaEntradas = "6" 'SE AGREGA DIRECTAMENTE A LIBRES
            ElseIf (row("toneladasentradas") + CDbl(TxNeto.Text)) >= row("toneladascompras") Then
                resTon = (CDbl(TxNeto.Text)) + row("toneladasentradas") - (row("toneladascompras"))
                If resTon = 0 Then
                    valSalCon = CDbl(TxNeto.Text)
                    valSalLib = 0
                    compruebaEntradas = "2" 'SE COMPLETO EL CONTRATO
                ElseIf resTon > 0 Then
                    valSalLib = resTon
                    valSalCon = (CDbl(TxNeto.Text)) + row("toneladasentradas") - resTon
                    compruebaEntradas = "3" 'SE COMPLETO EL CONTRATO CON SOBRANTE PARA LIBRE
                End If
            End If

        End If

        Return compruebaEntradas
    End Function
    Private Sub DataGridPropiedades()
        DgBoletaSalidas.Columns("id_salida").Visible = False
        DgBoletaSalidas.Columns("numeroBoleta").HeaderText = "Boleta"
        DgBoletaSalidas.Columns("Nombre").HeaderText = "Nombre"
        DgBoletaSalidas.Columns("Bruto").HeaderText = "Peso Bruto"
        DgBoletaSalidas.Columns("Tara").HeaderText = "Tara"
        DgBoletaSalidas.Columns("Neto").HeaderText = "Peso Neto"
        DgBoletaSalidas.Columns("Fecha_Pesaje").HeaderText = "Fecha"
        DgBoletaSalidas.Columns("Estado").HeaderText = "Estado"

        DgBoletaSalidas.Columns("Bruto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgBoletaSalidas.Columns("Tara").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgBoletaSalidas.Columns("Neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DgBoletaSalidas.Columns("Bruto").DefaultCellStyle.Format = "###,##0.00"
        DgBoletaSalidas.Columns("Tara").DefaultCellStyle.Format = "###,##0.00"
        DgBoletaSalidas.Columns("Neto").DefaultCellStyle.Format = "###,##0.00"
    End Sub
    Private Sub seleccionarAlmacenXacopio() Handles CbAcopio.SelectionChangeCommitted

        Dim cmdllenaCbAlm As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet

        cmdllenaCbAlm = New SqlCommand("Sp_CbAlmacen")
        cmdllenaCbAlm.CommandType = CommandType.StoredProcedure
        cmdllenaCbAlm.Parameters.Add(New SqlClient.SqlParameter("@idacopio", CbAcopio.SelectedValue))
        cmdllenaCbAlm.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbAlm)
        ds = New DataSet()
        da.Fill(ds)
        CbAlmacen.DataSource = ds.Tables(0)
        CbAlmacen.DisplayMember = "nombre_almacen"
        CbAlmacen.ValueMember = "Id_almacen"
        CbAlmacen.SelectedIndex = -1

    End Sub

    Private Sub llenarCombos()

        Dim da As SqlDataAdapter
        Dim ds As DataSet

        Dim cmdllenaCbSil As SqlCommand

        cmdllenaCbSil = New SqlCommand("Sp_CbAcopio")
        cmdllenaCbSil.CommandType = CommandType.StoredProcedure
        cmdllenaCbSil.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbSil)
        ds = New DataSet()
        da.Fill(ds)
        CbAcopio.DataSource = ds.Tables(0)
        CbAcopio.DisplayMember = "NombreCentro"
        CbAcopio.ValueMember = "Id_CentroAcopio"
        CbAcopio.SelectedIndex = -1

        Dim cmdllenaCbCom As SqlCommand

        cmdllenaCbCom = New SqlCommand("Sp_CbCompradores")
        cmdllenaCbCom.CommandType = CommandType.StoredProcedure
        cmdllenaCbCom.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbCom)
        ds = New DataSet()
        da.Fill(ds)
        CbNombre.DataSource = ds.Tables(0)
        CbNombre.DisplayMember = "nombre_comprador"
        CbNombre.ValueMember = "Id_comprador"
        CbNombre.SelectedIndex = -1

        Dim cmdllenaCbAna As SqlCommand

        cmdllenaCbAna = New SqlCommand("sp_CbAnalista")
        cmdllenaCbAna.CommandType = CommandType.StoredProcedure
        cmdllenaCbAna.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbAna)
        ds = New DataSet()
        da.Fill(ds)
        CBAnalista.DataSource = ds.Tables(0)
        CBAnalista.DisplayMember = "nombre"
        CBAnalista.ValueMember = "Id_usuario"
        CBAnalista.SelectedIndex = -1

        Dim cmdllenaCbVen As SqlCommand

        cmdllenaCbVen = New SqlCommand("Sp_CbEmpresaSal")
        cmdllenaCbVen.CommandType = CommandType.StoredProcedure
        cmdllenaCbVen.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbVen)
        ds = New DataSet()
        da.Fill(ds)
        CbNombre.DataSource = ds.Tables(0)
        CbNombre.DisplayMember = "NombreVendedor"
        CbNombre.ValueMember = "Id_Empresa"
        CbNombre.SelectedIndex = -1

        Dim cmdllenaCbPro As SqlCommand

        cmdllenaCbPro = New SqlCommand("Sp_CbProductor")
        cmdllenaCbPro.CommandType = CommandType.StoredProcedure
        cmdllenaCbPro.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbPro)
        ds = New DataSet()
        da.Fill(ds)
        CBContrato.DataSource = ds.Tables(0)
        CBContrato.DisplayMember = "Nombre_Comprador"
        CBContrato.ValueMember = "Id_ContratoV"
        CBContrato.SelectedIndex = -1

        Dim cmdllenaCbEmp As SqlCommand

        cmdllenaCbEmp = New SqlCommand("sp_CbEmpresas")
        cmdllenaCbEmp.CommandType = CommandType.StoredProcedure
        cmdllenaCbEmp.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbEmp)
        ds = New DataSet()
        da.Fill(ds)
        CbLugarExp.DataSource = ds.Tables(0)
        CbLugarExp.DisplayMember = "RazonSocial"
        CbLugarExp.ValueMember = "Id_Empresa"
        CbLugarExp.SelectedIndex = -1
    End Sub
    Private Sub CargarData()
        DgBoletaSalidas.DataSource = ""
        Dim cmd As New SqlCommand("Sp_llenarDgSalidas", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable

        da.Fill(dt)
        DgBoletaSalidas.DataSource = dt
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxIdBoleta.Text = ""
        TxFolio.Text = ""
        DTPSalidas.Value = Now
        CbNombre.SelectedIndex = -1
        CbLugarExp.Text = ""
        CbLugarExp.SelectedIndex = -1
        TxBruto.Text = "0.00"
        TxTara.Text = "0.00"
        TxNeto.Text = "0.00"
        TxHumedad.Text = "0.00"
        TxImpurezas.Text = "0.00"
        TxGranoDan.Text = "0.00"
        TxGranoQuebrado.Text = "0.00"
        TxPesoEsp.Text = "0.00"
        TxDeducciones.Text = "0.00"
        TxTotal.Text = "0.00"
        CbAlmacen.SelectedIndex = -1
        CbAcopio.SelectedIndex = -1
        CBContrato.SelectedIndex = -1
        CBConductor.SelectedIndex = -1
        CBConductor.Text = ""
        TxPlacas.Text = ""
        CBAnalista.SelectedIndex = -1
        CargarData()
        DataGridPropiedades()
        BloqueoFases()
        PbSilos.Value = 0
        LbCapacidad.Text = "0.000"
        LbToneladas.Text = "0.000"
        BtnGuardar.Enabled = True
        TxIdBoleta.Select()
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim BuscarControlTrigo As New BuscarControlTrigo
        VarGlob.busqueda = "SAL"
        BuscarControlTrigo.ShowDialog()
        DgBoletaSalidas.DataSource = ""
        Dim codigoproductor As Object = BuscarControlTrigo.CodigoProductor
        If BuscarControlTrigo.CodigoProductor <> Nothing Then
            Dim cmd As New SqlCommand("sp_llenarDg_sal_prod", cnn)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@idproductor", BuscarControlTrigo.CodigoProductor))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)
            DgBoletaSalidas.DataSource = dt
            DataGridPropiedades()
        Else
            CargarData()
            DataGridPropiedades()
        End If
    End Sub
    Private Sub SeleccionProductor(sender As Object, e As EventArgs) Handles DgBoletaSalidas.DoubleClick
        If DgBoletaSalidas.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgBoletaSalidas Is Nothing Then
            Dim valorId As String

            valorId = CStr(DgBoletaSalidas.CurrentRow.Cells(0).Value)

            TxFolio.Text = valorId

            Dim cmd As New SqlCommand("sp_seleccionIdProdSal", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idsalida", valorId))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)
            Dim TipoGrano As String = ""
            CbNombre.SelectedValue = row("NombreVendedor")
            TxIdBoleta.Text = row("numeroboleta")
            CbLugarExp.Text = CStr(row("LugarExpedicion"))
            TipoGrano = CStr(row("GRUPOGRANO"))
            DTPSalidas.Value = row("Fecha_Pesaje")
            TxBruto.Text = FormatNumber(CStr((row("Bruto") * 1000)), 0)
            TxTara.Text = FormatNumber(CStr((row("Tara") * 1000)), 0)
            TxNeto.Text = FormatNumber(CStr((row("Neto") * 1000)), 0)
            TxHumedad.Text = FormatNumber(CStr(row("humedad")), 2)
            TxImpurezas.Text = FormatNumber(CStr(row("Impurezas")), 2)
            TxGranoDan.Text = FormatNumber(CStr(row("granoDanado")), 2)
            TxPesoEsp.Text = FormatNumber(CStr(row("pesoEspecifico")), 2)
            TxGranoQuebrado.Text = FormatNumber(CStr(row("granoQuebrado")), 2)
            TxDeducciones.Text = FormatNumber((row("Deducciones") * 1000), 2)
            TxTotal.Text = FormatNumber((row("Total") * 1000), 2)
            If CStr(row("id_centroacopio")) <> "" Then
                CbAcopio.SelectedValue = row("id_centroacopio")
                seleccionarAlmacenXacopio()
                CbAlmacen.SelectedValue = row("id_Almacen")
                capacidadSilo()
            Else
                CbAcopio.SelectedIndex = -1
                CbAlmacen.SelectedIndex = -1
                PbSilos.Value = 0
                LbCapacidad.Text = "0.000"
                LbToneladas.Text = "0.000"
            End If
            CBContrato.SelectedValue = row("contratoComprador")
            CBConductor.Text = CStr(row("conductorCam"))
            CBAnalista.SelectedValue = row("usuarioAnalista")
            TxPlacas.Text = CStr(row("placasConductor"))
            Select Case TipoGrano
                Case "AMARILLO"
                    RBTCachanilla.Checked = True
                Case "BLANCO"
                    RBTCristalino.Checked = True
            End Select
            BloqueoFases()
            'TxImpurezas.Text = FormatNumber(TxImpurezas.Text, 1)
            'TxGranoDan.Text = FormatNumber(TxGranoDan.Text, 1)
            'TxHumedad.Text = FormatNumber(TxHumedad.Text, 1)
            'TxPuntaNegra.Text = FormatNumber(TxPuntaNegra.Text, 2)
            'TxPesoEspecifico.Text = FormatNumber(TxPesoEspecifico.Text, 1)
            'TxPorcentajePB.Text = FormatNumber(TxPorcentajePB.Text, 1)
            'TxGranoQuebrado.Text = FormatNumber(TxGranoQuebrado.Text, 1)
            'TxGranoContraste.Text = FormatNumber(TxGranoContraste.Text, 2)
            'TxBruto.Text = FormatNumber(TxBruto.Text, 2)
            'TxTara.Text = FormatNumber(TxTara.Text, 2)
            'TxNeto.Text = FormatNumber(TxNeto.Text, 2)
            TxDeducciones.Text = FormatNumber(TxDeducciones.Text, 2)
            TxTotal.Text = FormatNumber(TxTotal.Text, 2)
            BtnGuardar.Enabled = True
        End If
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class