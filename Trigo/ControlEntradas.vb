Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ControlEntradas
    Dim resTon, valEntLib, valEntCon, deduccionGrandan, deduccionHumedad, deduccionImpurezas, deduccionPanzaB, deduccionPesoEsp, deduccionGranQ, calculoPanzaB, calculoHumedad, calculoPuntaNegra, calculaImpureza, calculaGranoDan, calculoGranQ, calculoPesoE As Double
    Dim compruebaEntradas, idloteSeleccion As String
    Private Sub Entradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxIdBoleta.Select()
        llenarCombos()
        BtNuevo_Click(sender, e)
        CargarData()
        DataGridPropiedades()
        BtGuardar.Enabled = True
        ControlesSinTab()
    End Sub
    Private _mensajeParametrosAnalisis As String
    Public Property MensajeParametrosAnalisis As String
        Get
            Return _mensajeParametrosAnalisis
        End Get
        Set(value As String)
            _mensajeParametrosAnalisis = value
        End Set
    End Property
    Private _codigoEntrada As String
    Public Property codigoEntrada() As String
        Get
            Return _codigoEntrada
        End Get
        Set(value As String)
            _codigoEntrada = value
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
        BtNuevo.TabStop = False
        BtGuardar.TabStop = False
        BtModificar.TabStop = False
        BtImprimir.TabStop = False
        BtEliminar.TabStop = False
        BtRestaurar.TabStop = False
        BtSalir.TabStop = False
        DgBoletaIngresada.TabStop = False
    End Sub
    Private Sub BloqueoFases()
        If TxFolio.Text = "" And CbNombre.Text = "" And Val(TxBruto.Text) = 0 Then
            TxIdBoleta.Enabled = True
            CbLugarExp.Enabled = True
            DTPEntradas.Enabled = True
            CbNombre.Enabled = True
            GbGrupoGrano.Enabled = True
            TxBruto.Enabled = True
            TxPlacas.Enabled = True
            CBConductor.Enabled = True
            CbLoteEntrada.Enabled = True
            TxTara.Enabled = False
            GbCalidad.Enabled = False
            CbAnalista.Enabled = False
            CbAcopio.Enabled = False
            CbAlmacen.Enabled = False
            CBContrato.Enabled = True
            BtImprimir.Enabled = False
            RBTCachanilla.Checked = False
            RBTCristalino.Checked = False

        ElseIf Val(TxBruto.Text) > 0 And CbAnalista.Text = "" And CbAcopio.Text = "" Then
            GbCalidad.Enabled = True
            CbAnalista.Enabled = True
            TxTara.Enabled = False
            TxIdBoleta.Enabled = False
            CbLugarExp.Enabled = False
            DTPEntradas.Enabled = False
            CbNombre.Enabled = False
            GbGrupoGrano.Enabled = False
            TxBruto.Enabled = False
            CbAcopio.Enabled = False
            CbAlmacen.Enabled = False
            CBContrato.Enabled = False
            TxPlacas.Enabled = False
            CBConductor.Enabled = False
            BtImprimir.Enabled = False
            CbLoteEntrada.Enabled = False
        ElseIf TxFolio.Text <> "" And CbAnalista.Text <> "" And Val(TxTara.Text) = 0 Then
            TxTara.Enabled = True
            CbAcopio.Enabled = True
            CbAlmacen.Enabled = True
            TxIdBoleta.Enabled = False
            GbCalidad.Enabled = False
            CbAnalista.Enabled = False
            CbLugarExp.Enabled = False
            DTPEntradas.Enabled = False
            CbNombre.Enabled = False
            GbGrupoGrano.Enabled = False
            TxBruto.Enabled = False
            CBContrato.Enabled = False
            TxPlacas.Enabled = False
            CBConductor.Enabled = False
            BtImprimir.Enabled = False
            CbLoteEntrada.Enabled = False
        ElseIf Val(TxTara.Text) > 0 Then
            TxTara.Enabled = False
            TxIdBoleta.Enabled = False
            GbCalidad.Enabled = False
            CbAnalista.Enabled = False
            CbLugarExp.Enabled = False
            DTPEntradas.Enabled = False
            CbNombre.Enabled = False
            GbGrupoGrano.Enabled = False
            TxBruto.Enabled = False
            CbAcopio.Enabled = False
            CbAlmacen.Enabled = False
            CBContrato.Enabled = False
            TxPlacas.Enabled = False
            CBConductor.Enabled = False
            CbLoteEntrada.Enabled = False
            BtImprimir.Enabled = True
        End If
    End Sub
    Private Sub BtImprimir_Click(sender As Object, e As EventArgs) Handles BtImprimir.Click
        If RBTCachanilla.Checked = True And RBTCristalino.Checked = False Then
            _Cachanilla = "X"
            _cristalino = " "
        ElseIf RBTCristalino.Checked = True And RBTCachanilla.Checked = False Then
            _cristalino = "X"
            _Cachanilla = " "
        End If
        _codigoEntrada = TxFolio.Text
        ReporteBoletasEntradas.Show()
    End Sub
    Private Sub validacionParametros()
        Dim msg As String = ""
        Dim msgNo As String = ""

        If Val(TxImpurezas.Text) > 6 And Val(TxImpurezas.Text) <= 8 Then
            msg = msg & vbCrLf + "% Impurezas : " & Val(TxImpurezas.Text)
        ElseIf Val(TxImpurezas.Text) > 8 Then
            msgNo = msgNo & vbCrLf + "% Impurezas : " & Val(TxImpurezas.Text)
        End If
        If Val(TxHumedad.Text) > 15.1 And Val(TxHumedad.Text) <= 16 Then
            msg = msg & vbCrLf + "% Humedad : " & Val(TxHumedad.Text)
        ElseIf Val(TxHumedad.Text) > 16 Then
            msgNo = msgNo & vbCrLf + "% Humedad : " & Val(TxHumedad.Text)
        End If
        If Val(TxGranoDan.Text) > 8 And Val(TxGranoDan.Text) <= 10 Then
            msg = msg & vbCrLf + "% Grano Dañado : " & Val(TxGranoDan.Text)
        ElseIf Val(TxGranoDan.Text) > 10 Then
            msgNo = msgNo & vbCrLf + "% Grano Dañado : " & Val(TxGranoDan.Text)
        End If
        If Val(TxGranoQuebrado.Text) >= 7 And Val(TxGranoQuebrado.Text) <= 10 Then
            msg = msg & vbCrLf + "% Grano Quebrado : " & Val(TxGranoQuebrado.Text)
        ElseIf Val(TxGranoQuebrado.Text) > 10 Then
            msgNo = msgNo & vbCrLf + "% Grano Quebrado : " & Val(TxGranoQuebrado.Text)
        ElseIf Val(TxPesoEsp.Text) < 70 Then
            msgNo = msgNo & vbCrLf + "% Peso Especifico : " & Val(TxPesoEsp.Text)
        End If
        If msgNo <> "" Then
            MessageBox.Show("Se excedio el maximo o minimo permitido en los siguientes parametros, no se permitira el paso a esta entrada: " & msgNo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            BtGuardar.Enabled = False
            Exit Sub
        ElseIf msg <> "" Then
            Dim verificaPermiso As New VerificaPermiso
            _mensajeParametrosAnalisis = "Los parametros de analisis no deben exceder el limite maximo o minimo, se excedio en los siguientes parametros:  " & msg
            verificaPermiso.ShowDialog()
            Dim AutorizacionCorrecta As Object = verificaPermiso.AutorizacionCorrecta
            If AutorizacionCorrecta = True Then
                BtGuardar.Enabled = True
                MessageBox.Show("Se autorizo la entrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CbAcopio.Select()
            Else
                BtGuardar.Enabled = False
            End If

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

    Private Sub BtModificar_Click(sender As Object, e As EventArgs) Handles BtModificar.Click

    End Sub

    Private Sub SoloNumerosTxCalidad(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxBruto.KeyPress, TxTara.KeyPress, TxNeto.KeyPress, TxImpurezas.KeyPress, TxGranoDan.KeyPress, TxIdBoleta.KeyPress, TxPesoEsp.KeyPress
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
            If Val(TxTara.Text) > 0 Then
                TxNeto.Text = Val(TxBruto.Text - TxTara.Text)
                TxNeto.Text = FormatNumber(TxNeto.Text, 2)
            End If

            If Val(TxImpurezas.Text) > 0 And (TxHumedad.Text) > 0 And (TxGranoDan.Text) > 0 And Val(TxGranoQuebrado.Text) > 0 And Val(TxPesoEsp.Text) > 0 And Val(TxTara.Text) = 0 And Val(TxNeto.Text) = 0 And CbAcopio.SelectedValue = "" Then validacionParametros()
            If Val(TxTara.Text) > 0 And Val(TxNeto.Text) > 0 And CbAcopio.SelectedIndex = -1 Then
                calculos()
            End If
        End If
    End Sub
    Private Sub BtGuardar_Click(sender As Object, e As EventArgs) Handles BtGuardar.Click
        Dim numeroBoleta As Integer = 0
        Dim estadoEntrada As Integer = 0
        If verificaBoletaEntrada(TxIdBoleta.Text) = True And TxFolio.Text = "" Then
            MessageBox.Show("El numero de boleta " & TxIdBoleta.Text & " ya existe", "Aviso")
        ElseIf entradaRegistrada(TxFolio.Text, estadoEntrada) = True Then
            If TxFolio.Text = "" And CbNombre.Text <> "" Then
                If Val(TxBruto.Text) = 0 Or CbLugarExp.Text = "" Or CBConductor.Text = "" Or TxPlacas.Text = "" Or CbLoteEntrada.SelectedValue = Nothing Or CbLoteEntrada.Text = "" Or TxIdBoleta.Text = "" Or (RBTCristalino.Checked = False And RBTCachanilla.Checked = False) Then
                    MessageBox.Show("Verifica campos en blanco", "Aviso")
                Else
                    Try
                        BloqueoFases()
                        Dim Fase1 As New SqlCommand("Sp_InsNueEntradaFase1", cnn)

                        Fase1.CommandType = CommandType.StoredProcedure

                        Fase1.Parameters.AddWithValue("@Consecutivo", generaCodigoEntrada(TxFolio.Text))
                        Fase1.Parameters.AddWithValue("@numeroBoleta", TxIdBoleta.Text)
                        Fase1.Parameters.AddWithValue("@NomProd", CbNombre.SelectedValue)
                        Fase1.Parameters.AddWithValue("@LoteColonia", CbLoteEntrada.Text)
                        Fase1.Parameters.AddWithValue("@domicilioProductor", "")
                        Fase1.Parameters.AddWithValue("@grupoGrano", IIf(RBTCachanilla.Checked = True, "AMARILLO", "BLANCO"))
                        Fase1.Parameters.AddWithValue("@lugarExpedicion", CbLugarExp.Text)
                        Fase1.Parameters.AddWithValue("@fechaPesaje", DTPEntradas.Text)
                        Fase1.Parameters.AddWithValue("@bruto", (CDbl(TxBruto.Text) / 1000))
                        Fase1.Parameters.AddWithValue("@conductorCam", UCase(CBConductor.Text))
                        Fase1.Parameters.AddWithValue("@placasConductor", UCase(TxPlacas.Text))
                        Fase1.Parameters.AddWithValue("@Estado", 0)

                        TxFolio.Text = Fase1.Parameters("@Consecutivo").Value.ToString()

                        Fase1.ExecuteNonQuery()
                        CargarData()
                        DataGridPropiedades()
                        TxHumedad.Select()
                    Catch ex As Exception
                        MsgBox("Error", MsgBoxStyle.Critical)
                    End Try
                End If
            ElseIf TxFolio.Text <> "" And CbNombre.Text <> "" And Val(TxBruto.Text) > 0 And TxPlacas.Text <> "" And Val(TxTara.Text) = 0 And Val(TxNeto.Text) = 0 Then
                If Val(TxImpurezas.Text) = 0 Or Val(TxGranoDan.Text) = 0 Or Val(TxGranoQuebrado.Text) = 0 Or Val(TxHumedad.Text) = 0 Or CbAnalista.Text = "" Or Val(TxPesoEsp.Text) = 0 Then
                    MessageBox.Show("Verifica campos en blanco", "Aviso")
                Else

                    Try
                        BloqueoFases()
                        Dim Fase2 As New SqlCommand("Sp_InsNueEntradaFase2", cnn)

                        Fase2.CommandType = CommandType.StoredProcedure

                        Fase2.Parameters.AddWithValue("@Consecutivo", TxFolio.Text)
                        Fase2.Parameters.AddWithValue("@humedad", CDbl(TxHumedad.Text))
                        Fase2.Parameters.AddWithValue("@impurezas", CDbl(TxImpurezas.Text))
                        Fase2.Parameters.AddWithValue("@granoDanado", CDbl(TxGranoDan.Text))
                        Fase2.Parameters.AddWithValue("@pesoEspecifico", CDbl(TxPesoEsp.Text))
                        Fase2.Parameters.AddWithValue("@granoQuebrado", CDbl(TxGranoQuebrado.Text))
                        Fase2.Parameters.AddWithValue("@usuarioAnalista", CbAnalista.SelectedValue)

                        Fase2.ExecuteNonQuery()
                        CargarData()
                        DataGridPropiedades()
                        TxTara.Select()
                    Catch ex As Exception
                        MsgBox("Error", MsgBoxStyle.Critical)
                    End Try
                End If
            ElseIf TxFolio.Text <> "" And Val(TxTotal.Text) > 0 And CbAnalista.Text <> "" Then
                If Val(TxTara.Text) = 0 Or Val(TxTara.Text) = 0 Or CbAcopio.SelectedValue = "" Or CbAlmacen.SelectedValue = "" Then

                    MessageBox.Show("Verifica campos vacios", "Aviso")

                Else
                    CompruebaToneladasEntradas(compruebaEntradas)

                    If compruebaEntradas = 1 Then
                        MessageBox.Show("Restan " & FormatNumber(resTon, 2) & " Kilogramos para completar contrato de " & CbNombre.Text & ".", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf compruebaEntradas = 2 Then
                        MessageBox.Show("Se completo el contrato, las proximas entradas iran a contrato libre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf compruebaEntradas = 3 Then
                        MessageBox.Show("Se ha completado el contrato, se agregaran " & FormatNumber(resTon, 2) & " Kilogramosa a contrato libre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf compruebaEntradas = 4 Then
                        MessageBox.Show("Se ha completado el contrato para " & CbNombre.Text & ", no cuenta con contrato libre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf compruebaEntradas = 5 Then

                        Dim opc As DialogResult = MsgBox("Se ha excedido el contrato para " & CbNombre.Text & " con " & FormatNumber(resTon, 2) & " kilos y no cuenta con contrato libre. ¿Enviar a bodega?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Aviso")
                        If opc = DialogResult.Yes Then

                        ElseIf opc = DialogResult.No Then

                            Exit Sub

                        End If
                    ElseIf compruebaEntradas = 7 Then
                        MessageBox.Show("Se ha excedido el contrato para " & CbNombre.Text & ", no cuenta con contrato libre, no se acepta otra entrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    End If

                    Try
                        BloqueoFases()
                        Dim Fase3 As New SqlCommand("Sp_InsNueEntradaFase3", cnn)

                        Fase3.CommandType = CommandType.StoredProcedure

                        Fase3.Parameters.AddWithValue("@Consecutivo", TxFolio.Text)
                        Fase3.Parameters.AddWithValue("@tara", (CDbl(TxTara.Text)) / 1000)
                        Fase3.Parameters.AddWithValue("@neto", (CDbl(TxNeto.Text)) / 1000)
                        Fase3.Parameters.AddWithValue("@kilosXtonHum", CDbl(FormatNumber(calculoHumedad, 2)))
                        Fase3.Parameters.AddWithValue("@kilosXtonImp", CDbl(FormatNumber(calculaImpureza, 2)))
                        Fase3.Parameters.AddWithValue("@kilosXtonGrDa", CDbl(FormatNumber(calculaGranoDan, 2)))
                        Fase3.Parameters.AddWithValue("@kilosXtonGrQu", CDbl(FormatNumber(calculoGranQ, 2)))
                        Fase3.Parameters.AddWithValue("@kilosXtonPeEs", CDbl(FormatNumber(calculoPesoE, 2)))
                        Fase3.Parameters.AddWithValue("@deducciones", (CDbl(TxDeducciones.Text)) / 1000)
                        Fase3.Parameters.AddWithValue("@CentroAcopio", CbAcopio.SelectedValue)
                        Fase3.Parameters.AddWithValue("@almacen", CbAlmacen.SelectedValue)
                        Fase3.Parameters.AddWithValue("@total", (CDbl(TxTotal.Text)) / 1000)
                        Fase3.Parameters.AddWithValue("@Estado", 1)

                        Fase3.ExecuteNonQuery()
                        SumaToneladasContrato()
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
        Dim cmd As New SqlCommand("sp_ActCapacidadSilos", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@idacopio", CbAcopio.SelectedValue)
        cmd.Parameters.AddWithValue("@idalmacen", CbAlmacen.SelectedValue)
        cmd.Parameters.AddWithValue("@toneladasEnt", PesoNeto)
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub SumaToneladasContrato()
        Dim cmd As New SqlCommand("sp_InsSumaEntradas", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@idcliente", CbNombre.SelectedValue)
        cmd.Parameters.AddWithValue("@identrada", TxFolio.Text)
        cmd.Parameters.AddWithValue("@toneladasEntradas", valEntCon)
        cmd.Parameters.AddWithValue("@toneladasLibres", valEntLib)
        cmd.Parameters.AddWithValue("@Caso", compruebaEntradas)
        cmd.ExecuteNonQuery()

        resTon = 0
        valEntLib = 0
        valEntCon = 0
        compruebaEntradas = ""
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
        valEntLib = 0
        valEntCon = 0
        If row("aceptacontratolibre") = 0 Then

            If (row("toneladasentradas") + (CDbl(TxNeto.Text) / 1000)) < row("toneladascompras") Then
                resTon = row("toneladascompras") - (row("toneladasentradas") + (CDbl(TxNeto.Text) / 1000))
                If resTon <= 60 Then
                    valEntCon = (CDbl(TxNeto.Text) / 1000)
                    valEntLib = 0
                    compruebaEntradas = "1" 'FALTAN 60 TONELADAS PARA COMPLETAR EL CONTRATO
                ElseIf resTon > 60 Then
                    valEntCon = (CDbl(TxNeto.Text) / 1000)
                    valEntLib = 0
                    compruebaEntradas = "0" 'TIENE BASTANTE RANGO PARA LLEGAR AL LIMITE DE CONTRATO
                End If
            ElseIf (row("toneladasentradas") + (CDbl(TxNeto.Text) / 1000)) >= row("toneladascompras") Then
                resTon = (row("toneladasentradas") + (CDbl(TxNeto.Text) / 1000)) - row("toneladascompras")
                If resTon = 0 Then
                    valEntCon = (CDbl(TxNeto.Text) / 1000)
                    valEntLib = 0
                    compruebaEntradas = "4" 'SE COMPLETO EL CONTRATO SIN SOBRANTE 
                ElseIf resTon > 0 Then
                    valEntCon = (CDbl(TxNeto.Text) / 1000)
                    valEntLib = 0
                    compruebaEntradas = "5" 'SE COMPLETO EL CONTRATO CON SOBRANTE SIN CONTRATO LIBRE
                End If
            End If
        Else
            If (row("toneladasentradas") + (CDbl(TxNeto.Text) / 1000)) < row("toneladascompras") Then
                resTon = row("toneladascompras") - (row("toneladasentradas") + (CDbl(TxNeto.Text) / 1000))
                If resTon <= 60 Then
                    valEntCon = (CDbl(TxNeto.Text) / 1000)
                    valEntLib = 0
                    compruebaEntradas = "1" 'FALTAN 60 TONELADAS PARA COMPLETAR EL CONTRATO
                ElseIf resTon > 60 Then
                    valEntCon = (CDbl(TxNeto.Text) / 1000)
                    valEntLib = 0
                    compruebaEntradas = "0" 'TIENE BASTANTE RANGO PARA LLEGAR AL LIMITE DE CONTRATO
                End If
            ElseIf row("toneladasentradas") = row("toneladascompras") And row("toneladaslibresEntradas") > 0 Then
                valEntLib = (CDbl(TxNeto.Text) / 1000)
                valEntCon = row("toneladasentradas")
                compruebaEntradas = "6" 'SE AGREGA DIRECTAMENTE A LIBRES
            ElseIf (row("toneladasentradas") + (CDbl(TxNeto.Text) / 1000)) >= row("toneladascompras") Then
                resTon = (CDbl(TxNeto.Text) / 1000) + row("toneladasentradas") - (row("toneladascompras"))
                If resTon = 0 Then
                    valEntCon = (CDbl(TxNeto.Text) / 1000)
                    valEntLib = 0
                    compruebaEntradas = "2" 'SE COMPLETO EL CONTRATO
                ElseIf resTon > 0 Then
                    valEntLib = resTon
                    valEntCon = (CDbl(TxNeto.Text) / 1000) + row("toneladasentradas") - resTon
                    compruebaEntradas = "3" 'SE COMPLETO EL CONTRATO CON SOBRANTE PARA LIBRE
                End If
            End If

        End If
        Return compruebaEntradas
    End Function
    Private Sub BtNuevo_Click(sender As Object, e As EventArgs) Handles BtNuevo.Click
        TxIdBoleta.Text = ""
        TxFolio.Text = ""
        DTPEntradas.Value = Now
        CbNombre.SelectedIndex = -1
        CbLoteEntrada.SelectedIndex = -1
        CbLoteEntrada.Text = ""
        TxDomicilio.Text = ""
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
        CbAnalista.SelectedIndex = -1
        CargarData()
        DataGridPropiedades()
        BloqueoFases()
        PbSilos.Value = 0
        LbCapacidad.Text = "0.000"
        LbToneladas.Text = "0.000"
        BtGuardar.Enabled = True
        TxIdBoleta.Select()
    End Sub
    Private Sub DataGridPropiedades()
        DgBoletaIngresada.Columns("id_entrada").Visible = False
        DgBoletaIngresada.Columns("numeroBoleta").HeaderText = "Boleta"
        DgBoletaIngresada.Columns("Nombre").HeaderText = "Nombre"
        DgBoletaIngresada.Columns("Bruto").HeaderText = "Peso Bruto"
        DgBoletaIngresada.Columns("Tara").HeaderText = "Tara"
        DgBoletaIngresada.Columns("Neto").HeaderText = "Peso Neto"
        DgBoletaIngresada.Columns("Fecha_Pesaje").HeaderText = "Fecha"
        DgBoletaIngresada.Columns("Estado").HeaderText = "Estado"

        DgBoletaIngresada.Columns("Bruto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgBoletaIngresada.Columns("Tara").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgBoletaIngresada.Columns("Neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DgBoletaIngresada.Columns("Bruto").DefaultCellStyle.Format = "#,###,##0.00"
        DgBoletaIngresada.Columns("Tara").DefaultCellStyle.Format = "#,###,##0.00"
        DgBoletaIngresada.Columns("Neto").DefaultCellStyle.Format = "#,###,##0.00"
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
    Private Sub seleccionarLote() Handles CbNombre.SelectionChangeCommitted

        Dim cmdllenaLote As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet

        cmdllenaLote = New SqlCommand("sp_LoteEntrada")
        cmdllenaLote.CommandType = CommandType.StoredProcedure
        cmdllenaLote.Parameters.Add(New SqlClient.SqlParameter("@idproductor", CbNombre.SelectedValue))
        cmdllenaLote.Connection = cnn

        da = New SqlDataAdapter(cmdllenaLote)
        ds = New DataSet()
        da.Fill(ds)
        CbLoteEntrada.DataSource = ds.Tables(0)
        CbLoteEntrada.DisplayMember = "LoteColonia"
        CbLoteEntrada.ValueMember = "idproductor"
        CbLoteEntrada.SelectedIndex = -1
        'idloteSeleccion = ds.Tables(0).Rows(0)("idSeleccionados").ToString()
        'CbLoteEntrada.SelectedIndex = -1
        'CbLoteEntrada.Text = ""
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
        CBContrato.DataSource = ds.Tables(0)
        CBContrato.DisplayMember = "nombre_comprador"
        CBContrato.ValueMember = "Id_comprador"
        CBContrato.SelectedIndex = -1

        Dim cmdllenaCbCon As SqlCommand

        cmdllenaCbCon = New SqlCommand("Sp_CbConductores")
        cmdllenaCbCon.CommandType = CommandType.StoredProcedure
        cmdllenaCbCon.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbCon)
        ds = New DataSet()
        da.Fill(ds)
        CBConductor.DataSource = ds.Tables(0)
        CBConductor.DisplayMember = "nombre_conductor"
        CBConductor.ValueMember = "Id_conductor"
        CBConductor.SelectedIndex = -1

        Dim cmdllenaCbAna As SqlCommand

        cmdllenaCbAna = New SqlCommand("sp_CbAnalista")
        cmdllenaCbAna.CommandType = CommandType.StoredProcedure
        cmdllenaCbAna.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbAna)
        ds = New DataSet()
        da.Fill(ds)
        CbAnalista.DataSource = ds.Tables(0)
        CbAnalista.DisplayMember = "nombre"
        CbAnalista.ValueMember = "Id_usuario"
        CbAnalista.SelectedIndex = -1

        Dim cmdllenaCbPro As SqlCommand

        cmdllenaCbPro = New SqlCommand("Sp_CbPropietarioEntradas")
        cmdllenaCbPro.CommandType = CommandType.StoredProcedure
        cmdllenaCbPro.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbPro)
        ds = New DataSet()
        da.Fill(ds)
        CbNombre.DataSource = ds.Tables(0)
        CbNombre.DisplayMember = "nombreProductor"
        CbNombre.ValueMember = "Id_cliente"
        CbNombre.SelectedIndex = -1

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
        Dim cmd As New SqlCommand("Sp_llenarDgEntradas", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable

        da.Fill(dt)
        DgBoletaIngresada.DataSource = dt

    End Sub
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        Dim BuscarControlTrigo As New BuscarControlTrigo
        VarGlob.busqueda = "ENT"
        BuscarControlTrigo.ShowDialog()
        DgBoletaIngresada.DataSource = ""
        Dim codigoproductor As Object = BuscarControlTrigo.CodigoProductor
        If BuscarControlTrigo.CodigoProductor <> Nothing Then
            Dim cmd As New SqlCommand("sp_llenarDg_ent_prod", cnn)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@idproductor", BuscarControlTrigo.CodigoProductor))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataSet

            da.Fill(dt)
            DgBoletaIngresada.DataSource = dt.Tables(0).DefaultView
            DataGridPropiedades()
        Else
            CargarData()
            DataGridPropiedades()
        End If
    End Sub

    Private Sub SeleccionProductor(sender As Object, e As EventArgs) Handles DgBoletaIngresada.DoubleClick
        If DgBoletaIngresada.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgBoletaIngresada Is Nothing Then
            Dim valorId As String

            valorId = CStr(DgBoletaIngresada.CurrentRow.Cells(0).Value)

            TxFolio.Text = valorId

            Dim cmd As New SqlCommand("sp_seleccionIdProdEnt", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@identrada", valorId))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)
            Dim TipoGrano As String = ""
            Dim row As DataRow = dt.Rows(0)
            TxIdBoleta.Text = row("numeroboleta")
            CbNombre.SelectedValue = row("NombreProductor")
            TxDomicilio.Text = CStr(row("DomicilioProductor"))
            CbLugarExp.Text = CStr(row("LugarExpedicion"))
            TipoGrano = CStr(row("GRUPOGRANO"))
            DTPEntradas.Value = row("Fecha_Pesaje")
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
            CbAnalista.SelectedValue = row("usuarioAnalista")
            TxPlacas.Text = CStr(row("placasConductor"))
            Select Case TipoGrano
                Case "AMARILLO"
                    RBTCachanilla.Checked = True
                Case "BLANCO"
                    RBTCristalino.Checked = True
            End Select
            CbLoteEntrada.Text = CStr(row("LoteEntrada"))
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
            BtGuardar.Enabled = True
        End If
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click

        Close()

    End Sub

End Class