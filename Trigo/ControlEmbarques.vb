Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ControlEmbarques
    Dim resTon, valEntLib, valEntCon, deduccionGrandan, deduccionHumedad, deduccionImpurezas, deduccionPanzaB, deduccionPesoEsp, deduccionGranQ, calculoPanzaB, calculoHumedad, calculoPuntaNegra, calculaImpureza, calculaGranoDan, calculoGranQ, calculoPesoE As Double
    Dim compruebaEntradas, idloteSeleccion As String
    Dim tipoContrato As Integer = 1
    Private Sub Embarques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxIdBoleta.Select()
        BtNuevo_Click(sender, e)
        llenarCombos()
        CargarData()
        DataGridPropiedades()
        BloqueoFases()
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
    Private _codigoEmbarque As String
    Public Property codigoEmbarque() As String
        Get
            Return _codigoEmbarque
        End Get
        Set(value As String)
            _codigoEmbarque = value
        End Set
    End Property
    Private _maizAmarillo As String
    Public Property MaizAmarillo() As String
        Get
            Return _maizAmarillo
        End Get
        Set(value As String)
            _maizAmarillo = value
        End Set
    End Property
    Private _maizBlanco As String
    Public Property MaizBlanco() As String
        Get
            Return _maizBlanco
        End Get
        Set(value As String)
            _maizBlanco = value
        End Set
    End Property
    Private Sub ControlesSinTab()
        BtNuevo.TabStop = False
        BtGuardar.TabStop = False
        BtnModificar.TabStop = False
        BtImprimir.TabStop = False
        BtnEliminar.TabStop = False
        BtnRestaurar.TabStop = False
        BtnSalir.TabStop = False
        DgBoletaEmbarque.TabStop = False
    End Sub
    Private Sub BtImprimir_Click(sender As Object, e As EventArgs) Handles BtImprimir.Click
        If RBMamarillo.Checked = True And RBMblanco.Checked = False Then
            _maizAmarillo = "X"
            _maizBlanco = " "
        ElseIf RBMblanco.Checked = True And RBMamarillo.Checked = False Then
            _maizBlanco = "X"
            _maizAmarillo = " "
        End If
        _codigoEmbarque = TxFolio.Text
        ReporteBoletasEmbarque.Show()
    End Sub
    Private Sub BloqueoFases()
        If TxFolio.Text = "" And CbNombre.Text = "" And Val(TxTara.Text) = 0 Then
            TxIdBoleta.Enabled = True
            TxFolio.Enabled = True
            CbNombre.Enabled = True
            CbLoteEmbarque.Enabled = False
            GbGrupoGrano.Enabled = False
            CbLugarExp.Enabled = True
            TxTara.Enabled = True
            TxBruto.Enabled = False
            GbCalidad.Enabled = False
            CBContrato.Enabled = False
            CBConductor.Enabled = True
            TxPlacas.Enabled = True
            CBAnalista.Enabled = False
            DTPEmbarques.Enabled = True
            BtImprimir.Enabled = False
            RBMamarillo.Checked = False
            RBMblanco.Checked = False
        ElseIf VAL(TxTara.Text) > 0 And Val(TxBruto.Text) = 0 Then
            TxIdBoleta.Enabled = False
            TxFolio.Enabled = False
            CbNombre.Enabled = False
            CbLoteEmbarque.Enabled = True
            GbGrupoGrano.Enabled = True
            CbLugarExp.Enabled = False
            TxTara.Enabled = False
            TxBruto.Enabled = True
            GbCalidad.Enabled = False
            CBContrato.Enabled = True
            CBConductor.Enabled = False
            TxPlacas.Enabled = False
            CBAnalista.Enabled = False
            DTPEmbarques.Enabled = False
            BtImprimir.Enabled = False
        ElseIf TxFolio.Text <> "" And CBAnalista.Text = "" And Val(TxBruto.Text) > 0 Then
            TxIdBoleta.Enabled = False
            TxBruto.Enabled = False
            TxFolio.Enabled = False
            GbCalidad.Enabled = True
            CBAnalista.Enabled = True
            CbLugarExp.Enabled = False
            DTPEmbarques.Enabled = False
            CbNombre.Enabled = False
            GbGrupoGrano.Enabled = False
            TxTara.Enabled = False
            CbLoteEmbarque.Enabled = False
            CBContrato.Enabled = False
            TxPlacas.Enabled = False
            CBConductor.Enabled = False
            BtImprimir.Enabled = False
        ElseIf VAL(TxBruto.Text) > 0 Then
            TxIdBoleta.Enabled = False
            TxBruto.Enabled = False
            TxFolio.Enabled = False
            GbCalidad.Enabled = False
            CBAnalista.Enabled = False
            CbLugarExp.Enabled = False
            DTPEmbarques.Enabled = False
            CbNombre.Enabled = False
            GbGrupoGrano.Enabled = False
            TxTara.Enabled = False
            CBContrato.Enabled = False
            TxPlacas.Enabled = False
            CBConductor.Enabled = False
            BtImprimir.Enabled = True
            CbLoteEmbarque.Enabled = False
        End If
    End Sub
    Private Sub TipoContratoEmbarque()
        Dim cmdllenaTipoContrato As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet

        cmdllenaTipoContrato = New SqlCommand("Sp_TipoContrato")
        cmdllenaTipoContrato.CommandType = CommandType.StoredProcedure
        cmdllenaTipoContrato.Parameters.Add(New SqlClient.SqlParameter("@IdContratoV", CBContrato.SelectedValue))
        cmdllenaTipoContrato.Connection = cnn
        da = New SqlDataAdapter(cmdllenaTipoContrato)
        ds = New DataSet()
        da.Fill(ds)
        tipoContrato = ds.Tables(0).Rows(0)("tipocontrato").ToString()
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
        End If
        If msgNo <> "" Then
            MessageBox.Show("Se excedio el maximo permitido en los siguientes parametros, no se permitira el paso a esta entrada: " & msgNo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            BtGuardar.Enabled = False
            Exit Sub
        ElseIf msg <> "" Then
            Dim verificaPermiso As New VerificaPermiso
            _mensajeParametrosAnalisis = "Los parametros de analisis no deben exceder el limite, se excedio en los siguientes parametros:  " & msg
            verificaPermiso.ShowDialog()
            Dim AutorizacionCorrecta As Object = verificaPermiso.AutorizacionCorrecta
            If AutorizacionCorrecta = True Then
                BtGuardar.Enabled = True
                MessageBox.Show("Se autorizo la entrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        'If (Val(TxImpurezas.Text) - 2) > 0 And (Val(TxImpurezas.Text) - 5) < 3 Then
        '    deduccionImpurezas = Val(TxImpurezas.Text) - 2
        '    calculaImpureza = (deduccionImpurezas / 0.1) * 1.16 * (CDbl(TxNeto.Text) / 1000)
        'End If
        'If (Val(TxHumedad.Text) - 14) > 0 And (Val(TxHumedad.Text) - 14) < 6 Then
        '    deduccionHumedad = Val(TxHumedad.Text) - 14
        '    calculoHumedad = (deduccionHumedad / 0.1) * 1.16 * (CDbl(TxNeto.Text) / 1000)
        'End If
        'If Val(TxGranoDan.Text - 5) > 0 And Val(TxGranoDan.Text - 5) < 10 Then
        '    deduccionGrandan = Val(TxHumedad.Text) - 5
        '    deduccionGrandan = (deduccionGrandan / 0.1) * 1.16 * (CDbl(TxNeto.Text) / 1000)
        'End If
        'If (Val(TxGranoQuebrado.Text) - 3.5) > 0 And (Val(TxGranoQuebrado.Text) - 3.5) < 7 Then
        '    deduccionGranQ = Val(TxHumedad.Text) - 3.5
        '    calculoGranQ = (deduccionGranQ / 0.1) * 1.16 * (CDbl(TxNeto.Text) / 1000)
        'End If
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

        Else
            calculoPesoE = 0
        End If

        TxDeducciones.Text = calculaGranoDan + calculoHumedad + calculaImpureza + calculoGranQ + calculoPesoE
        TxDeducciones.Text = FormatNumber(TxDeducciones.Text, 2)
        TxTotal.Text = FormatNumber(Val(TxNeto.Text - TxDeducciones.Text), 2)
    End Sub
    Private Sub SoloNumerosTxCalidad(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxBruto.KeyPress, TxTara.KeyPress, TxNeto.KeyPress, TxHumedad.KeyPress, TxImpurezas.KeyPress, TxGranoDan.KeyPress, TxIdBoleta.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub
    Private Sub CambioControlPesoBruto(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            If Val(TxBruto.Text) > 0 Then
                TxNeto.Text = FormatNumber(Val(TxBruto.Text - TxTara.Text), 2)
            End If
            If Val(TxHumedad.Text) > 0 And Val(TxImpurezas.Text) > 0 And Val(TxDeducciones.Text) And Val(TxTotal.Text) = 0 Then validacionParametros()
            If Val(TxHumedad.Text) > 0 And Val(TxImpurezas.Text) > 0 And Val(TxGranoDan.Text) > 0 And Val(TxGranoQuebrado.Text) > 0 And Val(TxPesoEsp.Text) > 0 Then calculos()

            End If
    End Sub
    Private Sub BtGuardar_Click(sender As Object, e As EventArgs) Handles BtGuardar.Click
        Dim numeroBoleta As Integer = 0
        Dim estadoEntrada As Integer = 0
        If verificaBoletaEmbarque(TxIdBoleta.Text) = True And TxFolio.Text = "" Then
            MessageBox.Show("El numero de boleta " & TxIdBoleta.Text & " ya existe", "Aviso")
        ElseIf embarqueRegistrada(TxFolio.Text, estadoEntrada) = True Then
            If TxFolio.Text = "" And CbNombre.Text <> "" Then
                If CbLugarExp.SelectedIndex = -1 And Val(TxTara.Text) = 0 And CBConductor.Text = "" And TxPlacas.Text = "" Then
                    MessageBox.Show("Verifica campos en blanco", "Aviso")
                Else
                    Try
                        BloqueoFases()
                        Dim Fase1 As New SqlCommand("Sp_InsNueEmbarqueFase1", cnn)

                        Fase1.CommandType = CommandType.StoredProcedure

                        Fase1.Parameters.AddWithValue("@Consecutivo", generaCodigoEmbarque(TxFolio.Text))
                        Fase1.Parameters.AddWithValue("@numeroBoleta", TxIdBoleta.Text)
                        Fase1.Parameters.AddWithValue("@NomProd", CbNombre.SelectedValue)
                        Fase1.Parameters.AddWithValue("@lugarExpedicion", CbLugarExp.Text)
                        Fase1.Parameters.AddWithValue("@fechaPesaje", DTPEmbarques.Text)
                        Fase1.Parameters.AddWithValue("@tara", CDbl(TxTara.Text) / 1000)
                        Fase1.Parameters.AddWithValue("@conductorCam", UCase(CBConductor.Text))
                        Fase1.Parameters.AddWithValue("@placasConductor", UCase(TxPlacas.Text))
                        Fase1.Parameters.AddWithValue("@Estado", 0)

                        TxFolio.Text = Fase1.Parameters("@Consecutivo").Value.ToString()

                        Fase1.ExecuteNonQuery()
                        CargarData()
                        DataGridPropiedades()
                        seleccionarLote()
                        TxBruto.Select()
                    Catch ex As Exception
                        MsgBox("Error", MsgBoxStyle.Critical)
                    End Try

                End If
            ElseIf TxFolio.Text <> "" And CbNombre.Text <> "" And val(Txtara.Text) > 0 And TxPlacas.Text <> "" And Val(TxBruto.Text) > 0 And val(TxNeto.Text) > 0 And val(TxHumedad.text) = 0 Then
                If CbLoteEmbarque.Text = "" Or (RBMamarillo.Checked = False And RBMblanco.Checked = False) Or CBContrato.SelectedValue = Nothing Or Val(TxNeto.Text) = 0 Then
                    MessageBox.Show("Verifica campos en blanco", "Aviso")
                Else
                    Try
                        BloqueoFases()
                        Dim Fase2 As New SqlCommand("Sp_InsNueEmbarqueFase2", cnn)

                        Fase2.CommandType = CommandType.StoredProcedure

                        Fase2.Parameters.AddWithValue("@Consecutivo", TxFolio.Text)
                        Fase2.Parameters.AddWithValue("@LoteColonia", CbLoteEmbarque.Text)
                        Fase2.Parameters.AddWithValue("@grupoGrano", IIf(RBMamarillo.Checked = True, "AMARILLO", "BLANCO"))
                        Fase2.Parameters.AddWithValue("@Bruto", (CDbl(TxBruto.Text)) / 1000)
                        Fase2.Parameters.AddWithValue("@Neto", (CDbl(TxNeto.Text)) / 1000)
                        Fase2.Parameters.AddWithValue("@contratoComprador", CBContrato.SelectedValue)

                        Fase2.ExecuteNonQuery()
                        CargarData()
                        DataGridPropiedades()
                        TxHumedad.Select()
                    Catch ex As Exception
                        MsgBox("Error", MsgBoxStyle.Critical)
                    End Try

                End If
            ElseIf TxFolio.Text <> "" And val(TxTotal.Text) > 0 And Val(TxBruto.Text) > 0 And (TxImpurezas.Text <> "" Or val(TxImpurezas.Text) > 0) And CBAnalista.SelectedValue <> Nothing Then
                If Val(TxHumedad.Text) = 0 Or Val(TxImpurezas.Text) = 0 Or Val(TxGranoDan.Text) = 0 Or Val(TxGranoQuebrado.Text) = 0 Or Val(TxPesoEsp.Text) = 0 Or CBAnalista.Text = "" Then
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
                        Dim Fase3 As New SqlCommand("Sp_InsNueEmbarqueFase3", cnn)

                        Fase3.CommandType = CommandType.StoredProcedure

                        Fase3.Parameters.AddWithValue("@Consecutivo", TxFolio.Text)
                        Fase3.Parameters.AddWithValue("@humedad", CDbl(TxHumedad.Text))
                        Fase3.Parameters.AddWithValue("@kilosXtonHum", CDbl(FormatNumber(calculoHumedad, 2)))
                        Fase3.Parameters.AddWithValue("@impurezas", CDbl(TxImpurezas.Text))
                        Fase3.Parameters.AddWithValue("@kilosXtonImp", CDbl(FormatNumber(calculaImpureza, 2)))
                        Fase3.Parameters.AddWithValue("@granoDanado", CDbl(TxGranoDan.Text))
                        Fase3.Parameters.AddWithValue("@kilosXtonGrDa", CDbl(FormatNumber(calculaGranoDan, 2)))
                        Fase3.Parameters.AddWithValue("@granoQuebrado", CDbl(TxGranoQuebrado.Text))
                        Fase3.Parameters.AddWithValue("@kilosXtonGrQu", CDbl(FormatNumber(calculoGranQ, 2)))
                        Fase3.Parameters.AddWithValue("@pesoEspecifico", CDbl(TxPesoEsp.Text))
                        Fase3.Parameters.AddWithValue("@kilosXtonPeEs", CDbl(FormatNumber(calculoPesoE, 2)))
                        Fase3.Parameters.AddWithValue("@deducciones", (CDbl(TxDeducciones.Text)) / 1000)
                        Fase3.Parameters.AddWithValue("@total", (CDbl(TxTotal.Text)) / 1000)
                        Fase3.Parameters.AddWithValue("@usuarioAnalista", CBAnalista.SelectedValue)
                        Fase3.Parameters.AddWithValue("@Estado", 1)

                        Fase3.ExecuteNonQuery()
                        TipoContratoEmbarque()
                        SumaToneladasContrato()
                        CargarData()
                        DataGridPropiedades()
                    Catch ex As Exception
                        MsgBox("Error", MsgBoxStyle.Critical)
                    End Try
                End If

            End If
        ElseIf TxFolio.Text <> "" Then

            MessageBox.Show("No se puede guardar esta boleta, ya se ha completado su registro.", "Aviso")
        Else
            MessageBox.Show("Campos vacios", "")
        End If
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
        tipoContrato = 0
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
            If tipoContrato = 0 Then

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
            Else
                valEntLib = (CDbl(TxNeto.Text) / 1000)
                valEntCon = row("toneladasentradas")
                compruebaEntradas = "6" 'SE AGREGA DIRECTAMENTE A LIBRES

            End If



        End If
        Return compruebaEntradas
    End Function
    Private Sub DataGridPropiedades()
        DgBoletaEmbarque.Columns("id_embarque").Visible = False
        DgBoletaEmbarque.Columns("numeroBoleta").HeaderText = "Boleta"
        DgBoletaEmbarque.Columns("Nombre").HeaderText = "Nombre"
        DgBoletaEmbarque.Columns("Bruto").HeaderText = "Peso Bruto"
        DgBoletaEmbarque.Columns("Tara").HeaderText = "Tara"
        DgBoletaEmbarque.Columns("Neto").HeaderText = "Peso Neto"
        DgBoletaEmbarque.Columns("Fecha_Pesaje").HeaderText = "Fecha"

        DgBoletaEmbarque.Columns("Bruto").DefaultCellStyle.Format = "###,##0.000"
        DgBoletaEmbarque.Columns("Tara").DefaultCellStyle.Format = "###,##0.000"
        DgBoletaEmbarque.Columns("Neto").DefaultCellStyle.Format = "###,##0.000"

    End Sub
    Private Sub BtNuevo_Click(sender As Object, e As EventArgs) Handles BtNuevo.Click

        TxFolio.Text = ""
        TxIdBoleta.Text = ""
        DTPEmbarques.Value = Now
        CbNombre.SelectedIndex = -1
        CbNombre.Text = ""
        CbLoteEmbarque.SelectedIndex = -1
        CbLoteEmbarque.Text = ""
        RBMamarillo.Checked = False
        RBMblanco.Checked = False
        CbLugarExp.Text = ""
        CbLugarExp.SelectedIndex = -1
        TxBruto.Text = "0"
        TxTara.Text = "0"
        TxNeto.Text = "0"
        TxHumedad.Text = "0.00"
        TxImpurezas.Text = "0.00"
        TxGranoDan.Text = "0.00"
        TxGranoQuebrado.Text = "0.00"
        TxPesoEsp.Text = "0.00"
        TxDeducciones.Text = "0"
        TxTotal.Text = "0"
        CBContrato.SelectedIndex = -1
        CBContrato.Text = ""
        CBConductor.SelectedIndex = -1
        CBConductor.Text = ""
        TxPlacas.Text = ""
        CBAnalista.SelectedIndex = -1
        CBAnalista.Text = ""
        CargarData()
        DataGridPropiedades()
        BloqueoFases()
        BtGuardar.Enabled = True
        TxIdBoleta.Select()
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
        CbLoteEmbarque.DataSource = ds.Tables(0)
        CbLoteEmbarque.DisplayMember = "LoteColonia"
        CbLoteEmbarque.ValueMember = "idproductor"
        CbLoteEmbarque.SelectedIndex = -1
    End Sub
    Private Sub llenarCombos()

        Dim da As SqlDataAdapter
        Dim ds As DataSet

        'Dim cmdllenaCbSil As SqlCommand

        'cmdllenaCbSil = New SqlCommand("Sp_CbAcopio")
        'cmdllenaCbSil.CommandType = CommandType.StoredProcedure
        'cmdllenaCbSil.Connection = cnn

        'da = New SqlDataAdapter(cmdllenaCbSil)
        'ds = New DataSet()
        'da.Fill(ds)
        'CbAcopio.DataSource = ds.Tables(0)
        'CbAcopio.DisplayMember = "NombreCentro"
        'CbAcopio.ValueMember = "Id_CentroAcopio"
        'CbAcopio.SelectedIndex = -1

        'Dim cmdllenaCbCom As SqlCommand

        'cmdllenaCbCom = New SqlCommand("Sp_CbCompradores")
        'cmdllenaCbCom.CommandType = CommandType.StoredProcedure
        'cmdllenaCbCom.Connection = cnn

        'da = New SqlDataAdapter(cmdllenaCbCom)
        'ds = New DataSet()
        'da.Fill(ds)
        'CBContrato.DataSource = ds.Tables(0)
        'CBContrato.DisplayMember = "nombre_comprador"
        'CBContrato.ValueMember = "Id_comprador"
        'CBContrato.SelectedIndex = -1

        Dim cmdllenaCbCom As SqlCommand

        cmdllenaCbCom = New SqlCommand("Sp_CbProductor")
        cmdllenaCbCom.CommandType = CommandType.StoredProcedure
        cmdllenaCbCom.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbCom)
        ds = New DataSet()
        da.Fill(ds)
        CBContrato.DataSource = ds.Tables(0)
        CBContrato.DisplayMember = "Nombre_Comprador"
        CBContrato.ValueMember = "Id_ContratoV"
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
        CBAnalista.DataSource = ds.Tables(0)
        CBAnalista.DisplayMember = "nombre"
        CBAnalista.ValueMember = "Id_usuario"
        CBAnalista.SelectedIndex = -1

        Dim cmdllenaCbPro As SqlCommand

        cmdllenaCbPro = New SqlCommand("Sp_CbPropietarioEntradas")
        cmdllenaCbPro.CommandType = CommandType.StoredProcedure
        cmdllenaCbPro.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbPro)
        ds = New DataSet()
        da.Fill(ds)
        CbNombre.DataSource = ds.Tables(0)
        CbNombre.DisplayMember = "nombreProductor"
        CbNombre.ValueMember = "Id_Cliente"
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
        Dim cmd As New SqlCommand("Sp_llenarDgEmbarques", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable

        da.Fill(dt)
        DgBoletaEmbarque.DataSource = dt

    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim BuscarControlTrigo As New BuscarControlTrigo
        VarGlob.busqueda = "EMB"
        BuscarControlTrigo.ShowDialog()
        DgBoletaEmbarque.DataSource = ""
        Dim codigoproductor As Object = BuscarControlTrigo.CodigoProductor
        If BuscarControlTrigo.CodigoProductor <> Nothing Then
            Dim cmd As New SqlCommand("sp_llenarDg_emb_prod", cnn)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@idproductor", BuscarControlTrigo.CodigoProductor))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)
            DgBoletaEmbarque.DataSource = dt
            DataGridPropiedades()
        Else
            CargarData()
            DataGridPropiedades()
        End If

    End Sub
    Private Sub SeleccionProductor(sender As Object, e As EventArgs) Handles DgBoletaEmbarque.DoubleClick
        If DgBoletaEmbarque.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgBoletaEmbarque Is Nothing Then
            Dim valorId As String

            valorId = CStr(DgBoletaEmbarque.CurrentRow.Cells(0).Value)

            TxFolio.Text = valorId

            Dim cmd As New SqlCommand("sp_seleccionIdProdEmb", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idembarque", valorId))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)
            Dim TipoGrano As String = ""
            Dim row As DataRow = dt.Rows(0)
            TxIdBoleta.Text = row("numeroboleta")
            CbNombre.SelectedValue = row("NombreProductor")
            'TxDomicilio.Text = CStr(row("DomicilioProductor"))
            CbLugarExp.Text = CStr(row("LugarExpedicion"))
            TipoGrano = CStr(row("GRUPOGRANO"))
            DTPEmbarques.Value = row("Fecha_Pesaje")
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
            CBContrato.SelectedValue = row("contratoComprador")
            CBConductor.Text = CStr(row("conductorCam"))
            CBAnalista.SelectedValue = row("usuarioAnalista")
            TxPlacas.Text = CStr(row("placasConductor"))
            Select Case TipoGrano
                Case "AMARILLO"
                    RBMamarillo.Checked = True
                Case "BLANCO"
                    RBMblanco.Checked = True
            End Select
            If CbNombre.Text <> "" Then
                seleccionarLote()
            End If
            CbLoteEmbarque.Text = CStr(row("LoteEmbarque"))
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

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Close()

    End Sub

End Class