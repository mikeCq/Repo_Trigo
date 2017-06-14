Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Public Class ContratosCompras
    Private codigoTierra As String
    Private supRestante, supRestanteIndi, rendimiento, hectareasprometidas, resRendimiento, sumatoneladas As Double
    Private Sub ContratosCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnNuevo_Click(sender, e)
        DtTemporada.CustomFormat = "yyyy"
        llenarCombos()
        NuSupComp.Controls(0).Visible = False
        NuToneladas.Controls(0).Visible = False
        TpCompraLibre.Parent = Nothing
        CargarData()
        DataGridPropiedadesContratos()
        DtFechaAlta.Focus()
        desbloqueacontroles()
    End Sub
    Private Sub controlesSinTab()
        GbListaContratos.TabStop = False
        GbSeleccion.TabStop = False
        BtSeleccionarLotes.TabStop = False

    End Sub
    Private Sub bloqueocontroles()
        If TxFolioContrato.Text <> "" And TxFolioProductor.Text <> "" Then
            GbDatosContrato.Enabled = False
            GbDatosLotes.Enabled = False
            GbContratoLibre.Enabled = False
            GbSeleccion.Enabled = False
        End If
    End Sub
    Private Sub desbloqueacontroles()
        If TxFolioContrato.Text = "" And TxFolioProductor.Text = "" Then
            GbDatosContrato.Enabled = True
            GbDatosLotes.Enabled = True
            GbContratoLibre.Enabled = True
            GbSeleccion.Enabled = True
        End If
    End Sub
    Private _codigoPropietario As String
    Public Property CodigoPropietario() As String
        Get
            Return _codigoPropietario
        End Get
        Set(ByVal value As String)
            _codigoPropietario = value
        End Set
    End Property
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Enter Then
            TxFolioProductor.Text = CbNombreProductor.SelectedValue
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function
    Private Sub llenarCombos()
        Dim cmdllenaCbCom As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet

        cmdllenaCbCom = New SqlCommand("Sp_CbPropietario")
        cmdllenaCbCom.CommandType = CommandType.StoredProcedure
        cmdllenaCbCom.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbCom)
        ds = New DataSet()
        da.Fill(ds)
        CbNombreProductor.DataSource = ds.Tables(0)
        CbNombreProductor.DisplayMember = "nombreProductor"
        CbNombreProductor.ValueMember = "Id_cliente"
        CbNombreProductor.SelectedIndex = -1

        Dim cmdllenaCMon As SqlCommand

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

    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxFolioContrato.Text = ""
        TxFolioProductor.Text = ""
        TxLotesSembrar.Text = ""
        TxEmpresa.Text = ""
        TxApoderado.Text = ""
        TxAcopio.Text = ""
        TxObservaciones.Text = ""
        DtFechaAlta.Value = Now
        CbNombreProductor.SelectedIndex = -1
        CbMoneda.SelectedIndex = -1
        CbMoneda.Text = ""
        TxLotesSembrar.Text = ""
        TxPrecioTonelada.Text = ""
        NuSupComp.Value = 0
        NuToneladas.Value = 0
        DtTemporada.Value = Now
        RbNoLibre.Checked = False
        RbSiLibre.Checked = False
        DtFechaliquidacion.Value = Now
        CargarDataLotes()
        desbloqueacontroles()
        CbNombreProductor.Select()
    End Sub
    Private Sub seleccionarLotes_Click(sender As Object, e As EventArgs) Handles BtSeleccionarLotes.Click
        If CbNombreProductor.SelectedValue = "" Then

            MessageBox.Show("No puedes seleccionar lotes sin seleccionar antes un Propietario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            Dim SumaLotes As Double = 0
            Dim LotesSelect As String = ""
            Dim msg As String = ""

            'Dim SupRestante As Decimal = 0
            For Each row As DataGridViewRow In DgSeleccionLotes.Rows
                Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("ChCol").Value)
                If isSelected = True Then
                    If verificaLoteAgregado(row.Cells("Numero_Lote").Value.ToString()) = False Then

                        If row.Cells("rendimiento").Value Is DBNull.Value Or row.Cells("Hectareas_promRestante").Value Is DBNull.Value Then

                            If row.Cells("rendimiento").Value Is DBNull.Value Then
                                row.Cells("rendimiento").Value = 0
                            End If

                            If row.Cells("Hectareas_promRestante").Value Is DBNull.Value Then
                                row.Cells("Hectareas_promRestante").Value = 0
                            End If

                        ElseIf row.Cells("Superficie_Cultivable_restante").Value < row.Cells("Hectareas_promRestante").Value Then
                            msg = msg & vbCrLf + row.Cells("Numero_Lote").Value.ToString & " con el folio " & row.Cells("Folio_Lote").Value.ToString
                        ElseIf row.Cells("rendimiento").Value > 0 And row.Cells("Hectareas_promRestante").Value > 0 Then

                            LotesSelect = LotesSelect & "/" & row.Cells("Numero_Lote").Value.ToString()
                            resRendimiento = (row.Cells("rendimiento").Value * row.Cells("Hectareas_promRestante").Value)
                            sumatoneladas = sumatoneladas + resRendimiento
                            hectareasprometidas = row.Cells("Hectareas_promRestante").Value
                            supRestante = row.Cells("Superficie_Cultivable_restante").Value - row.Cells("Hectareas_promRestante").Value
                            SumaLotes = SumaLotes + row.Cells("Hectareas_promRestante").Value.ToString()
                            codigoTierra = row.Cells("Id_Tierra").Value
                            rendimiento = row.Cells("rendimiento").Value

                        End If
                    End If
                End If
            Next
            If msg <> "" Then
                MessageBox.Show("Las Hectareas Prometidas no deben exceder a la Superficie Cultivable, favor de corregir los siguientes lotes:  " & msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf SumaLotes > 0 Then
                Dim aString As String = Replace(LTrim(LotesSelect), "/", ", ")
                Dim mychar() As Char = {", "}
                Dim NewString As String = aString.TrimStart(mychar)
                TxLotesSembrar.Text = TxLotesSembrar.Text & NewString & "."
                NuSupComp.Value = NuSupComp.Value + SumaLotes
                NuToneladas.Value = NuToneladas.Value + sumatoneladas
                sumatoneladas = 0
                resRendimiento = 0

            End If
        End If
    End Sub
    Private Function verificaLoteAgregado(ByVal loteVe As String) As Boolean
        Dim resultado As Boolean = False
        If TxLotesSembrar.Text.Contains(loteVe) Then
            resultado = True
        End If
        Return resultado
    End Function
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxFolioProductor.Text = "" Or TxLotesSembrar.Text = "" Or DtFechaAlta.Value = "01/01/1900" Or CbNombreProductor.SelectedIndex = -1 Or TxLotesSembrar.Text = "" Or TxPrecioTonelada.Text = "" Or NuSupComp.Value = 0 Or NuToneladas.Value = 0 Or DtFechaliquidacion.Value = "01/01/1900" Then
            MessageBox.Show("Verifica campos en blanco", "Aviso")
        ElseIf contratoCompraReg(TxFolioContrato.Text) = True Then
            MessageBox.Show("Ya existe la boleta " + TxFolioContrato.Text + ".")
        Else
            Dim opc As DialogResult = MessageBox.Show("¿Esta seguro de guardar los datos capturados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opc = DialogResult.Yes Then
                Try

                    Dim cmd As New SqlCommand("Sp_InsNueConCom", cnn)

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@idcontratocompra", generaCodigoContratoCom(TxFolioContrato.Text))
                    cmd.Parameters.AddWithValue("@fechaAlta", DtFechaAlta.Value)
                    cmd.Parameters.AddWithValue("@Id_Cliente", CbNombreProductor.SelectedValue)
                    cmd.Parameters.AddWithValue("@toneladasCompras", NuToneladas.Value)
                    cmd.Parameters.AddWithValue("@toneladasRestantesE", NuToneladas.Value)
                    cmd.Parameters.AddWithValue("@SuperficieComprometida", NuSupComp.Value)
                    cmd.Parameters.AddWithValue("@precioXtonelada", TxPrecioTonelada.Text)
                    cmd.Parameters.AddWithValue("@Moneda", CbMoneda.SelectedValue)
                    cmd.Parameters.AddWithValue("@id_Temporada", DtTemporada.Value)
                    cmd.Parameters.AddWithValue("@fechaLiquidacion", DtFechaliquidacion.Value)
                    cmd.Parameters.AddWithValue("@lotesSeleccionados", TxLotesSembrar.Text)
                    cmd.Parameters.AddWithValue("@AceptaLibre", IIf(RbNoLibre.Checked = False, 1, 0))
                    cmd.Parameters.AddWithValue("@Observaciones", TxObservaciones.Text)
                    cmd.Parameters.AddWithValue("@Empresa", TxEmpresa.Text)
                    cmd.Parameters.AddWithValue("@apoderado", TxApoderado.Text)
                    cmd.Parameters.AddWithValue("@acopio", TxAcopio.Text)
                    cmd.Parameters.AddWithValue("@estatusContrato", 0)

                    TxFolioContrato.Text = cmd.Parameters("@idcontratocompra").Value.ToString()

                    cmd.ExecuteNonQuery()

                    CargarData()
                    DataGridPropiedadesContratos()
                    insertaLotesSeleccionados()
                    ActualizaTierras()
                    CargarDataLotes()
                    BtnNuevo_Click(sender, e)
                Catch ex As Exception
                    MsgBox(ex, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub
    Private Sub insertaLotesSeleccionados()
        For Each row As DataGridViewRow In DgSeleccionLotes.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("ChCol").Value)
            If isSelected = True Then
                If verificaLoteAgregado(row.Cells("Numero_Lote").Value.ToString()) = True Then
                    Dim generaID As String = ""
                    Try
                        Dim cmd As New SqlCommand("sp_insLotesSeleccionados", cnn)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("@idseleccionados", generaIDseleccion(generaID))
                        cmd.Parameters.AddWithValue("@idtierra", row.Cells("Id_Tierra").Value.ToString())
                        cmd.Parameters.AddWithValue("@idproductor", TxFolioProductor.Text)
                        cmd.Parameters.AddWithValue("@idcontrato", TxFolioContrato.Text)

                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex, MsgBoxStyle.Critical)
                    End Try


                End If
            End If
        Next

    End Sub
    Private Sub ActualizaTierras()

        For Each row As DataGridViewRow In DgSeleccionLotes.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("ChCol").Value)
            If isSelected = True Then
                If verificaLoteAgregado(row.Cells("Numero_Lote").Value.ToString()) = True Then
                    supRestanteIndi = row.Cells("Superficie_Cultivable_restante").Value - row.Cells("Hectareas_promRestante").Value
                    Try
                        Dim cmd As New SqlCommand("sp_ActualizarSuperficieCultivable", cnn)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("@idtierra", row.Cells("Id_Tierra").Value.ToString())
                        cmd.Parameters.AddWithValue("@supRestante", supRestanteIndi)
                        cmd.Parameters.AddWithValue("@rendimiento", row.Cells("rendimiento").Value)
                        cmd.Parameters.AddWithValue("@hectareasprometidas", row.Cells("Hectareas_promRestante").Value)
                        cmd.ExecuteNonQuery()

                        supRestanteIndi = 0
                    Catch ex As Exception
                        MsgBox(ex, MsgBoxStyle.Critical)
                    End Try

                End If

            End If
        Next

        codigoTierra = ""
        supRestante = 0
        rendimiento = 0
        hectareasprometidas = 0

    End Sub
    Private Sub SeleccionLote(sender As Object, e As EventArgs) Handles DgContatoVenta.DoubleClick
        If DgContatoVenta.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgContatoVenta Is Nothing Then
            Dim valorId As String

            valorId = CStr(DgContatoVenta.CurrentRow.Cells(0).Value)

            TxFolioContrato.Text = valorId

            Dim cmd As New SqlCommand("Sp_SeleccionIdContratoCompras", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idcontratoc", valorId))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)

            TxFolioContrato.Text = CStr(row("id_contratoc"))
            DtFechaAlta.Value = row("fechaAlta")
            CbNombreProductor.SelectedValue = row("Id_Cliente")
            TxFolioProductor.Text = CbNombreProductor.SelectedValue
            NuToneladas.Value = row("toneladasCompras")
            NuSupComp.Value = row("SuperficieComprometida")
            TxPrecioTonelada.Text = row("precioXtonelada")
            CbMoneda.SelectedValue = row("moneda")
            DtTemporada.Value = CStr(row("id_Temporada"))
            DtFechaliquidacion.Value = CStr(row("fechaLiquidacion"))
            TxLotesSembrar.Text = CStr(row("lotesSeleccionados"))
            If row("AceptaContratoLibre") = 0 Then
                RbNoLibre.Checked = True
            Else
                RbSiLibre.Checked = True

            End If
            TxObservaciones.Text = CStr(row("Observaciones"))
            TxEmpresa.Text = CStr(row("Empresa"))
            TxApoderado.Text = CStr(row("ApoderadoLegal"))
            TxAcopio.Text = CStr(row("CentroAcopio"))
            DgSeleccionLotes.Columns.Clear()
            DgSeleccionLotes.Refresh()
            Dim cmd2 As New SqlCommand("sp_llenarDg_SeleccionLotes_x_productor", cnn)

            cmd2.CommandType = CommandType.StoredProcedure

            cmd2.Parameters.Add(New SqlClient.SqlParameter("@idcliente", CbNombreProductor.SelectedValue))
            cmd2.Parameters.Add(New SqlClient.SqlParameter("@idcontrato", TxFolioContrato.Text))

            Dim da1 As New SqlDataAdapter(cmd2)

            Dim dt1 As New DataTable

            da1.Fill(dt1)
            DgSeleccionLotes.DataSource = dt1
            DataGridPropiedadeslotesSeleccionados()
            bloqueocontroles()

        End If
    End Sub

    Private Sub CargarDataLotes()
        Dim cmd As New SqlCommand("sp_llenarDg_SeleccionLotes", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable

        da.Fill(dt)
        DgSeleccionLotes.DataSource = dt

        DataGridPropiedadeslotes()
        TxFolioProductor.Text = CbNombreProductor.SelectedValue
        TxFolioContrato.Text = ""
        TxLotesSembrar.Text = ""
        NuToneladas.Value = 0
        NuSupComp.Value = 0
        TxPrecioTonelada.Text = ""
        DtTemporada.Value = Now
        DtFechaliquidacion.Value = Now
    End Sub
    Private Sub CargarData()
        Dim cmd As New SqlCommand("Sp_llenarDgContratoCompras", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable

        da.Fill(dt)
        DgContatoVenta.DataSource = dt
    End Sub
    Private Sub Llenatextid()
        Dim dt As New DataTable
        Dim SqlCon As String = "Select max(Id_ContratoC)as Id_ContratoC from contratosCompras"
        Dim comnd As New SqlCommand(SqlCon, cnn)
        Dim drd As SqlDataReader

        drd = comnd.ExecuteReader()

        If drd.Read() Then
            TxFolioContrato.Text = drd.Item("Id_ContratoC").ToString()

        End If
        drd.Close()
    End Sub
    Private Sub DataGridPropiedadesContratos()
        DgContatoVenta.Columns("Id_ContratoC").HeaderText = "ID Contrato"
        DgContatoVenta.Columns("nombreProductor").HeaderText = "Nombre Productor"
        DgContatoVenta.Columns("SuperficieComprometida").HeaderText = "Superficie Comprometida"
        DgContatoVenta.Columns("precioXtonelada").HeaderText = "Precio por Tonelada"
        DgContatoVenta.Columns("id_Temporada").HeaderText = "Temporada"
        DgContatoVenta.Columns("fechaLiquidacion").HeaderText = "Fecha de Liquidacion"
    End Sub
    Private Sub CbNombreProductor_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CbNombreProductor.SelectionChangeCommitted
        TxFolioProductor.Text = CbNombreProductor.SelectedValue
    End Sub
    Private Sub nombreproductor(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbNombreProductor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
        End If
    End Sub
    Private Sub ImpContrato_Click(sender As Object, e As EventArgs) Handles ImpContrato.Click
        GeneraContrato1(TxFolioContrato.Text)
    End Sub
    'Private Sub BtnBuscarLote_Click(sender As Object, e As EventArgs) Handles BtnBuscarLote.Click
    '    If CbNombreProductor.SelectedValue = "" Then

    '        MessageBox.Show("No puedes seleccionar lotes sin seleccionar antes un Propietario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    '    Else

    '        _codigoPropietario = CbNombreProductor.SelectedValue
    '        Dim seleccionLotes As New SeleccionLotes
    '        seleccionLotes.ShowDialog()
    '        NuSupComp.Value = seleccionLotes.HectareaPrometida
    '        TxLotesSembrar.Text = seleccionLotes.LotesSeleccion
    '        NuToneladas.Value = seleccionLotes.SumaToneladas
    '        codigoTierra = seleccionLotes.CodigoTierra
    '        supRestante = seleccionLotes.SupRestante
    '        rendimiento = seleccionLotes.Rendimiento

    '    End If
    'End Sub
    Private Sub DataGridPropiedadeslotes()

        If DgSeleccionLotes.Columns("ChCol") Is Nothing Then

            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = ""
            checkBoxColumn.Width = 5
            checkBoxColumn.Name = "ChCol"
            DgSeleccionLotes.Columns.Insert(0, checkBoxColumn)

            Dim ColHectareasRest As New DataGridViewTextBoxColumn
            ColHectareasRest.HeaderText = "Hectareas Prometidas"
            ColHectareasRest.Width = 10
            ColHectareasRest.Name = "Hectareas_promRestante"
            DgSeleccionLotes.Columns.Insert(6, ColHectareasRest)

            Dim ColRendimiento As New DataGridViewTextBoxColumn()
            ColRendimiento.HeaderText = "Rendimiento"
            ColRendimiento.Width = 10
            ColRendimiento.Name = "rendimiento"
            DgSeleccionLotes.Columns.Insert(7, ColRendimiento)

        End If

        DgSeleccionLotes.Columns("Id_Tierra").HeaderText = "ID Tierra"
        DgSeleccionLotes.Columns("Numero_Lote").HeaderText = "Numero Lote"
        DgSeleccionLotes.Columns("colonia").HeaderText = "Colonia"
        DgSeleccionLotes.Columns("Folio_Lote").HeaderText = "Folio de Lote"
        DgSeleccionLotes.Columns("Superficie_Cultivable_restante").HeaderText = "Superficie Cultivable Restante"
        'DgSeleccionLotes.Columns("Hectareas_promRestante").HeaderText = "Hectareas Prometidas"
        'DgSeleccionLotes.Columns("rendimiento").HeaderText = "Rendimiento"

        DgSeleccionLotes.Columns("Id_Tierra").Visible = False

        DgSeleccionLotes.Columns("Id_Tierra").ReadOnly = True
        DgSeleccionLotes.Columns("Numero_Lote").ReadOnly = True
        DgSeleccionLotes.Columns("colonia").ReadOnly = True
        DgSeleccionLotes.Columns("Folio_Lote").ReadOnly = True
        DgSeleccionLotes.Columns("Superficie_Cultivable_restante").ReadOnly = True
        'DgSeleccionLotes.Columns("Hectareas_promRestante").ReadOnly = False
        'DgSeleccionLotes.Columns("rendimiento").ReadOnly = False
    End Sub
    Private Sub DataGridPropiedadeslotesSeleccionados()

        'If DgSeleccionLotes.Columns("ChCol") Is Nothing Then

        '    Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
        '    checkBoxColumn.HeaderText = ""
        '    checkBoxColumn.Width = 5
        '    checkBoxColumn.Name = "ChCol"
        '    DgSeleccionLotes.Columns.Insert(0, checkBoxColumn)

        '    Dim ColHectareasRest As New DataGridViewTextBoxColumn
        '    ColHectareasRest.HeaderText = "Hectareas Prometidas"
        '    ColHectareasRest.Width = 10
        '    ColHectareasRest.Name = "Hectareas_promRestante"
        '    DgSeleccionLotes.Columns.Insert(6, ColHectareasRest)

        '    Dim ColRendimiento As New DataGridViewTextBoxColumn()
        '    ColRendimiento.HeaderText = "Rendimiento"
        '    ColRendimiento.Width = 10
        '    ColRendimiento.Name = "rendimiento"
        '    DgSeleccionLotes.Columns.Insert(7, ColRendimiento)

        'End If
        DgSeleccionLotes.Columns("Id_Tierra").HeaderText = "ID Tierra"
        DgSeleccionLotes.Columns("Numero_Lote").HeaderText = "Numero Lote"
        DgSeleccionLotes.Columns("nombre_colonia").HeaderText = "Colonia"
        DgSeleccionLotes.Columns("Folio_Lote").HeaderText = "Folio de Lote"
        DgSeleccionLotes.Columns("Superficie_Cultivable_restante").HeaderText = "Superficie Cultivable Restante"
        'DgSeleccionLotes.Columns("Hectareas_promRestante").HeaderText = "Hectareas Prometidas"
        'DgSeleccionLotes.Columns("rendimiento").HeaderText = "Rendimiento"

        DgSeleccionLotes.Columns("Id_Tierra").Visible = False

        DgSeleccionLotes.Columns("Id_Tierra").ReadOnly = True
        DgSeleccionLotes.Columns("Numero_Lote").ReadOnly = True
        DgSeleccionLotes.Columns("nombre_colonia").ReadOnly = True
        DgSeleccionLotes.Columns("Folio_Lote").ReadOnly = True
        DgSeleccionLotes.Columns("Superficie_Cultivable_restante").ReadOnly = True
        'DgSeleccionLotes.Columns("Hectareas_promRestante").ReadOnly = False
        'DgSeleccionLotes.Columns("rendimiento").ReadOnly = False
    End Sub
    Private Sub DgSeleccionLotes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgSeleccionLotes.CellContentClick
        If DgSeleccionLotes.CurrentRow.Cells("ChCol").Value = False Then
            DgSeleccionLotes.CurrentRow.Cells("ChCol").Value = True
        ElseIf DgSeleccionLotes.CurrentRow.Cells("ChCol").Value = True Then
            DgSeleccionLotes.CurrentRow.Cells("ChCol").Value = False
        End If
    End Sub

    Private Sub Valid(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxPrecioTonelada.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub
    Private Sub DG_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgSeleccionLotes.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Valid
        AddHandler e.Control.KeyPress, AddressOf Valid
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Close()

    End Sub
End Class