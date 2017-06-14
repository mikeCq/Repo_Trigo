Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class ContratosVentas
    Private Sub ContratosVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombos()
        CargarData()
        DataGridPropiedades()
        LimpiarCampos(sender, e)
        ControlesSinTab()
    End Sub
    Private Sub ControlesSinTab()
        BtnNuevo.TabStop = False
        BtnGuardar.TabStop = False
        BtnModificar.TabStop = False
        'BtnImprimir.TabStop = False
        BtnBuscar.TabStop = False
        BtnEliminar.TabStop = False
        BtnRestaurar.TabStop = False
        BtnSalir.TabStop = False
        DgContatoVenta.TabStop = False
    End Sub
    Private Sub LimpiarCampos(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxFolioComprador.Text = ""
        TxFolioContrato.Text = ""
        TxPrecioXtonelada.Text = ""
        TxToneladas.Text = ""
        CbNombreComprador.SelectedIndex = -1
        DtAlta.Value = Now
        DtLiquidacion.Value = "01/01/2000"
        CbMoneda.Text = ""
        CbMoneda.SelectedIndex = -1
        RbMaizContrato.Checked = False
        RbMaizLibre.Checked = False
        CargarData()
        DataGridPropiedades()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxPrecioXtonelada.Text = "" Or TxPrecioXtonelada.Text = "" Or CbNombreComprador.SelectedIndex = -1 Or DtAlta.Value = "01/01/1900" Or DtLiquidacion.Value = "01/01/2000" Then
            MessageBox.Show("Verifica campos en blanco", "Aviso")
        ElseIf contratoVentaReg(TxFolioContrato.Text) = True Then

            MessageBox.Show("Ya existe el contrato " + TxFolioContrato.Text + ".")

        Else
            Try
                Dim cmd As New SqlCommand("Sp_InsNueConVen", cnn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@Consecutivo", generaCodigoVenta(TxFolioContrato.Text))
                cmd.Parameters.AddWithValue("@id_comprador", CbNombreComprador.SelectedValue)
                cmd.Parameters.AddWithValue("@FechaAlta", DtAlta.Value)
                cmd.Parameters.AddWithValue("@toneladasventas", TxToneladas.Text)
                cmd.Parameters.AddWithValue("@precioXtonelada", TxPrecioXtonelada.Text)
                cmd.Parameters.AddWithValue("@Moneda", CbMoneda.SelectedValue)
                cmd.Parameters.AddWithValue("@id_temporada", CbTemporada.SelectedValue)
                cmd.Parameters.AddWithValue("@fechaLiquidacion", DtLiquidacion.Value)
                cmd.Parameters.AddWithValue("@tipoContrato", IIf(RbMaizContrato.Checked = True, 0, 1))
                cmd.Parameters.AddWithValue("@EstatusContrato", 0)

                cmd.Parameters.AddWithValue("@CodigoSiap", TBCodigoSIAP.Text)
                cmd.Parameters.AddWithValue("@CodigoSap", TBCodigoSAP.Text)
                cmd.Parameters.AddWithValue("@CodigoAserca", TBCodigoASERCA.Text)

                TxFolioContrato.Text = cmd.Parameters("@Consecutivo").Value.ToString()

                cmd.ExecuteNonQuery()
                CargarData()
                DataGridPropiedades()
                'bloquearCampos()

            Catch ex As Exception
                MsgBox("Error", MsgBoxStyle.Critical)
            End Try

        End If
    End Sub
    Private Sub CargarData()
        Dim cmd As New SqlCommand("sp_llenarDgContratoVe", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable

        da.Fill(dt)
        DgContatoVenta.DataSource = dt

    End Sub
    Private Sub DataGridPropiedades()
        DgContatoVenta.Columns("id_contratov").HeaderText = "ID Contrato"
        DgContatoVenta.Columns("Nombre_Comprador").HeaderText = "Nombre de Comprador"
        DgContatoVenta.Columns("ToneladasVentas").HeaderText = "Toneladas"
        DgContatoVenta.Columns("precioxtonelada").HeaderText = "Precio Por Tonelada"
        DgContatoVenta.Columns("Fechaalta").HeaderText = "Fecha de Alta"

        DgContatoVenta.Columns("ToneladasVentas").DefaultCellStyle.Format = "###,##0.000"
        DgContatoVenta.Columns("precioxtonelada").DefaultCellStyle.Format = "###,##0.00"

        DgContatoVenta.Columns("ToneladasVentas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DgContatoVenta.Columns("precioxtonelada").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight


    End Sub
    Private Sub cargarCombos()
        Dim cmdllenaCbCom As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet

        cmdllenaCbCom = New SqlCommand("Sp_CbCompradores")
        cmdllenaCbCom.CommandType = CommandType.StoredProcedure
        cmdllenaCbCom.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbCom)
        ds = New DataSet()
        da.Fill(ds)
        CbNombreComprador.DataSource = ds.Tables(0)
        CbNombreComprador.DisplayMember = "nombre_comprador"
        CbNombreComprador.ValueMember = "Id_comprador"
        CbNombreComprador.SelectedIndex = -1

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

        Dim cmdllenaTemp As SqlCommand

        cmdllenaTemp = New SqlCommand("sp_CbTemporadas")
        cmdllenaTemp.CommandType = CommandType.StoredProcedure
        cmdllenaTemp.Connection = cnn

        da = New SqlDataAdapter(cmdllenaTemp)
        ds = New DataSet()
        da.Fill(ds)
        CbTemporada.DataSource = ds.Tables(0)
        CbTemporada.DisplayMember = "temporada"
        CbTemporada.ValueMember = "idtemporada"
        CbTemporada.SelectedIndex = 0

    End Sub
    Private Sub CbNombreComprador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNombreComprador.SelectionChangeCommitted
        TxFolioComprador.Text = CbNombreComprador.SelectedValue
    End Sub
    Private Sub SeleccionProductor(sender As Object, e As EventArgs) Handles DgContatoVenta.DoubleClick
        Try
            Dim valorId As String

            valorId = CStr(DgContatoVenta.CurrentRow.Cells(0).Value)

            TxFolioContrato.Text = valorId

            Dim cmd As New SqlCommand("sp_SeleccionContratoV", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idcontratoV", valorId))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)

            TxFolioContrato.Text = CStr(row("id_contratoV"))
            DtAlta.Value = row("fechaAlta")
            TxFolioComprador.Text = CStr(row("id_comprador"))
            CbNombreComprador.SelectedValue = row("id_comprador")
            TxToneladas.Text = FormatNumber(CStr(row("toneladasventas")), 3)
            TxPrecioXtonelada.Text = FormatNumber(CStr(row("precioxtonelada")), 2)
            CbMoneda.SelectedValue = row("moneda")
            CbTemporada.Text = CStr(row("temporada"))
            DtLiquidacion.Value = row("fechaLiquidacion")
            If row("tipoContrato") = 0 Then
                RbMaizContrato.Checked = True
            Else
                RbMaizLibre.Checked = True

            End If
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()

    End Sub

End Class