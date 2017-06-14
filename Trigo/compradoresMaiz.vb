Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Public Class compradoresMaiz
    Private Sub comprasTrigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombos()
        DgProductores.Columns.Clear()
        DgSeleccionProductores.Columns.Clear()
        CargarDataProductores()
        DataGridProductoresPropiedades()
        DataGridPropiedadesSeleccionados()
        CargarDataContratos()
    End Sub
    Private Sub CargarDataProductores()
        DgSeleccionProductores.DataSource = ""
        Dim cmd As New SqlCommand("Sp_llenarDgProductores", cnn)

        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)
        DgSeleccionProductores.DataSource = dt
    End Sub
    Private Sub DataGridProductoresPropiedades()
        If DgSeleccionProductores.Columns("ChCol") Is Nothing Then
            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = ""
            checkBoxColumn.Width = 25
            checkBoxColumn.Name = "ChCol"
            DgSeleccionProductores.Columns.Insert(0, checkBoxColumn)

            Dim ColToneladasRest As New DataGridViewTextBoxColumn
            ColToneladasRest.HeaderText = "Toneladas "
            ColToneladasRest.Width = 60
            ColToneladasRest.Name = "Toneladas"
            DgSeleccionProductores.Columns.Insert(5, ColToneladasRest)

        End If
        DgSeleccionProductores.Columns("Id_ContratoC").Visible = False

        DgSeleccionProductores.Columns("Id_Cliente").Width = 80
        DgSeleccionProductores.Columns("NombreProductor").Width = 432
        DgSeleccionProductores.Columns("ToneladasRestanteE").Width = 80

        DgSeleccionProductores.Columns("Id_Cliente").ReadOnly = True
        DgSeleccionProductores.Columns("NombreProductor").ReadOnly = True
    End Sub
    Private Sub DataGridPropiedadesSeleccionados()
        If DgProductores.Columns("id_cliente") Is Nothing Then

            Dim colidSelec As New DataGridViewTextBoxColumn
            colidSelec.Name = "id_seleccion"
            colidSelec.Visible = False
            DgProductores.Columns.Insert(0, colidSelec)

            Dim colidContrato As New DataGridViewTextBoxColumn
            colidContrato.Name = "id_contratoC"
            colidContrato.Visible = False
            DgProductores.Columns.Insert(1, colidContrato)

            Dim colidcliente As New DataGridViewTextBoxColumn
            colidcliente.HeaderText = "Id Cliente"
            colidcliente.Width = 80
            colidcliente.Name = "id_cliente"
            DgProductores.Columns.Insert(2, colidcliente)

            Dim Colnombrecliente As New DataGridViewTextBoxColumn()
            Colnombrecliente.HeaderText = "Nombre"
            Colnombrecliente.Width = 400
            Colnombrecliente.Name = "Nombre"
            DgProductores.Columns.Insert(3, Colnombrecliente)

            Dim ColToneladas As New DataGridViewTextBoxColumn()
            ColToneladas.HeaderText = "Toneladas"
            ColToneladas.Width = 160
            ColToneladas.Name = "ToneladasSelec"
            DgProductores.Columns.Insert(4, ColToneladas)
        Else
            DgProductores.Columns("id_seleccion").Visible = False
            DgProductores.Columns("id_contratoC").Visible = False
            DgProductores.Columns("id_compradorC").Visible = False

            DgProductores.Columns("id_cliente").Width = 80
            DgProductores.Columns("nombre").Width = 400
            DgProductores.Columns("toneladasSelect").Width = 160

            DgProductores.Columns("id_cliente").HeaderText = "Id Cliente"
            DgProductores.Columns("nombre").HeaderText = "Nombre"
            DgProductores.Columns("toneladasSelect").HeaderText = "Toneladas"
        End If
    End Sub
    Private Sub CargarDataContratos()
        DgContatoComprador.DataSource = ""
        Dim cmd As New SqlCommand("sp_llenarDgContratoCompradores", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable

        da.Fill(dt)
        DgContatoComprador.DataSource = dt

    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        TxFolioContrato.Text = ""
        TxFolioComprador.Text = ""
        DtFechaAlta.Value = Now
        CbNombreComprador.Text = ""
        CbNombreComprador.SelectedIndex = -1
        TxPrecioTonelada.Text = ""
        TxToneladas.Text = ""
        DtTemporada.Value = Now
        DtFechaliquidacion.Value = "01/01/1900"
        DgProductores.Columns.Clear()
        DgProductores.DataSource = Nothing
        DgSeleccionProductores.Columns.Clear()
        CargarDataProductores()
        DataGridPropiedadesSeleccionados()
        CargarDataContratos()
        DataGridProductoresPropiedades()

    End Sub
    Private Sub llenarCombos()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim cmdllenaCbCom As SqlCommand

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
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If CbNombreComprador.Text = "" Or TxToneladas.Text = "" Or TxPrecioTonelada.Text = "" Then
            MessageBox.Show("Verifica campos en blanco", "Aviso")
        ElseIf coloniaRegistrado(TxFolioContrato.Text) = True Then

            MessageBox.Show("Ya existe la colonia " + TxFolioContrato.Text + ".")

        Else
            Try
                Dim validaTon As Integer
                If ValidacionTonelada(validaTon) > 0 Then
                    MessageBox.Show("Valor de Toneladas a asignar mayor a toneladas restantes", "Aviso")
                Else
                    If TxFolioContrato.Text = "" Then
                        Dim cmd As New SqlCommand("sp_InsNuevoContratoComprador", cnn)

                        cmd.CommandType = CommandType.StoredProcedure

                        cmd.Parameters.AddWithValue("@idcontrato", generaCodigoContratoComprador(TxFolioContrato.Text))
                        cmd.Parameters.AddWithValue("@fechaAlta", DtFechaAlta.Text)
                        cmd.Parameters.AddWithValue("@idcomprador", TxFolioComprador.Text)
                        cmd.Parameters.AddWithValue("@toneladasContratadas", TxToneladas.Text)
                        cmd.Parameters.AddWithValue("@precioXtonelada", TxPrecioTonelada.Text)
                        cmd.Parameters.AddWithValue("@idtemporada", DtTemporada.Value)
                        cmd.Parameters.AddWithValue("@fechaliquidacion", DtFechaliquidacion.Value)

                        TxFolioContrato.Text = cmd.Parameters("@idcontrato").Value.ToString()

                        cmd.ExecuteNonQuery()

                        ActualizaToneladas()
                        actualizatoneladasAsignadas()
                        insertSeleccionados()
                        DgSeleccionProductores.Columns.Clear()
                        CargarDataContratos()
                        CargarDataProductores()
                        DataGridProductoresPropiedades()
                    Else
                        ActualizaToneladas()
                        actualizatoneladasAsignadas()
                        insertSeleccionados()
                        CargarDataContratos()
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error", MsgBoxStyle.Critical)
            End Try

        End If
    End Sub
    Private Sub insertSeleccionados()
        For Each row As DataGridViewRow In DgProductores.Rows
            If row.Cells("id_seleccion").Value = "True" Then
                Dim cmd As New SqlCommand("sp_InsNueSeleccion", cnn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@idseleccion", generaCodigoSeleccion(row.Cells("id_seleccion").Value))
                cmd.Parameters.AddWithValue("@idcontrato", row.Cells("id_contratoC").Value)
                cmd.Parameters.AddWithValue("@idcliente", row.Cells("id_cliente").Value)
                cmd.Parameters.AddWithValue("@nombre", row.Cells("Nombre").Value)
                cmd.Parameters.AddWithValue("@toneladasSel", row.Cells("toneladasSelect").Value)
                cmd.Parameters.AddWithValue("@idcompradorC", TxFolioContrato.Text)
                cmd.ExecuteNonQuery()
            End If
        Next
    End Sub
    Private Sub ActualizaToneladas()
        Dim Resultado As Double
        For Each row As DataGridViewRow In DgSeleccionProductores.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("ChCol").Value)
            If isSelected = True Then
                If row.Cells("Toneladas").Value <= row.Cells("ToneladasRestanteE").Value Then
                    Resultado = 0
                    Resultado = row.Cells("ToneladasRestanteE").Value - row.Cells("Toneladas").Value

                    Dim cmd As New SqlCommand("sp_ActToneladasRest", cnn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@idcliente", row.Cells("Id_Cliente").Value.ToString())
                    cmd.Parameters.AddWithValue("@idcontratoc", row.Cells("Id_ContratoC").Value.ToString())
                    cmd.Parameters.AddWithValue("@TonsRest", Resultado)
                    cmd.ExecuteNonQuery()

                End If
            End If
        Next
    End Sub
    Private Sub actualizatoneladasAsignadas()
        Dim sumaToneladas As Double
        Dim cmd As New SqlCommand("sp_ActToneladasAsignadas", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@idcontratoC", TxFolioContrato.Text)
        cmd.Parameters.AddWithValue("@peso", SumaToneladasAsignadas(sumaToneladas))
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub CbNombreComprador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNombreComprador.SelectionChangeCommitted
        TxFolioComprador.Text = CbNombreComprador.SelectedValue
    End Sub
    Private Function ValidacionTonelada(ByVal validaTon As Integer) As Integer
        Dim resultado As Integer = 0
        For Each row As DataGridViewRow In DgSeleccionProductores.Rows
            If row.Cells("ToneladasRestanteE").Value < row.Cells("Toneladas").Value Then
                resultado = resultado + 1
            End If
        Next
        Return resultado
    End Function
    Private Function validaExcesoToneladas(ByVal Valida As String) As Boolean
        Dim resultado As Boolean = False
        Dim suma As Double = 0
        For Each row As DataGridViewRow In DgSeleccionProductores.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("ChCol").Value)
            If isSelected = True Then
                suma = suma + row.Cells("Toneladas").Value
            End If

        Next
        For Each row1 As DataGridViewRow In DgContatoComprador.Rows
            If row1.Cells("Id_Contrato").Value = TxFolioContrato.Text Then
                If suma > row1.Cells("toneladasContratadas").Value Then
                    resultado = True
                End If
            End If
        Next
        Return resultado
    End Function
    Private Function SumaToneladasAsignadas(ByVal sumaToneladas As Double) As Double
        Dim resultado As Double = 0
        For Each row As DataGridViewRow In DgProductores.Rows
            resultado = resultado + row.Cells("toneladasSelect").Value
        Next
        Return resultado
    End Function
    Private Sub seleccionarLotes_Click(sender As Object, e As EventArgs) Handles seleccionarLotes.Click
        If CbNombreComprador.SelectedValue = "" Then

            MessageBox.Show("No puedes seleccionar lotes sin seleccionar antes un Comprador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            If DgProductores.RowCount = 0 Then
                For Each row As DataGridViewRow In DgSeleccionProductores.Rows
                    Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("ChCol").Value)
                    Dim valida As Boolean = False
                    If isSelected = True Then
                        If row.Cells("Toneladas").Value = Nothing Then

                            MessageBox.Show("El campo de Toneladas esta vacio.")
                            Exit Sub
                        ElseIf validaExcesoToneladas(valida) = True Then

                            MessageBox.Show("Se esta excediendo la cantidad de toneladas contratadas", "Aviso")
                            Exit Sub
                        Else
                            If verificarAgregado(row.Cells("id_cliente").Value.ToString()) = False Then

                                'Dim dt As DataTable = DirectCast(DgProductores.DataSource, DataTable)

                                DgProductores.Rows.Add(row.Cells("ChCol").Value, row.Cells("Id_ContratoC").Value.ToString(), row.Cells("id_cliente").Value.ToString(), row.Cells("NombreProductor").Value.ToString(), row.Cells("Toneladas").Value)

                                'DgProductores.DataSource = dt
                                'DataGridPropiedadesSeleccionados()
                            End If
                        End If
                    End If
                Next
            Else
                For Each row As DataGridViewRow In DgSeleccionProductores.Rows
                    Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("ChCol").Value)
                    If isSelected = True Then
                        If row.Cells("Toneladas").Value = Nothing Then
                            MessageBox.Show("El campo de Toneladas esta vacio.")
                        Else

                            If verificarAgregado(row.Cells("id_cliente").Value.ToString()) = False Then
                                Dim dt As DataTable = DirectCast(DgProductores.DataSource, DataTable)

                                dt.Rows.Add(row.Cells("ChCol").Value, row.Cells("Id_ContratoC").Value.ToString(), row.Cells("id_cliente").Value.ToString(), row.Cells("NombreProductor").Value.ToString(), row.Cells("Toneladas").Value)

                                DgProductores.DataSource = dt
                                DataGridPropiedadesSeleccionados()
                            End If
                        End If
                    End If
                Next
            End If
        End If
    End Sub
    Private Function verificarAgregado(ByVal idcliente As String) As Boolean
        Dim resultado As Boolean = False
        For Each row As DataGridViewRow In DgProductores.Rows
            If idcliente = row.Cells("id_cliente").Value Then
                resultado = True
            End If
        Next
        Return resultado
    End Function
    Private Sub Valid(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxPrecioTonelada.KeyPress, TxToneladas.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub
    Private Sub DG_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgSeleccionProductores.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Valid
        AddHandler e.Control.KeyPress, AddressOf Valid
    End Sub
    Private Sub DgContatoComprador_CellContentClick(sender As Object, e As EventArgs) Handles DgContatoComprador.DoubleClick
        If DgContatoComprador.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgContatoComprador Is Nothing Then
            Dim valorId As String

            valorId = CStr(DgContatoComprador.CurrentRow.Cells(0).Value)

            TxFolioContrato.Text = valorId

            Dim cmd As New SqlCommand("sp_SeleccionContratoCompradores", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idContrado", valorId))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)

            DtFechaAlta.Value = CStr(row("fechaAlta"))
            TxFolioComprador.Text = CStr(row("id_comprador"))
            CbNombreComprador.SelectedValue = CStr(row("id_comprador"))
            TxToneladas.Text = row("ToneladasContratadas")
            TxPrecioTonelada.Text = CStr(row("precioXtonelada"))
            DtTemporada.Value = CStr(row("id_Temporada"))
            DtFechaliquidacion.Value = row("fechaLiquidacion")

            DgProductores.Columns.Clear()

            Dim cmd2 As New SqlCommand("sp_LlenarDgSeleccionados", cnn)

            cmd2.CommandType = CommandType.StoredProcedure

            cmd2.Parameters.Add(New SqlClient.SqlParameter("@idcompradorC", valorId))

            Dim da2 As New SqlClient.SqlDataAdapter(cmd2)
            Dim dt2 As New DataTable

            da2.Fill(dt2)

            DgProductores.DataSource = dt2
            DataGridPropiedadesSeleccionados()
        End If
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        BtnNuevo_Click(sender, e)
        Me.Close()
    End Sub
End Class