Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Almacenes
    Private Sub Almacenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NuCapacidadAlmacen.Controls(0).Visible = False
        NuCapacidadCentro.Controls(0).Visible = False
        llenarCombos()
        ControlBotones()
        abrir()
        CargarData()
        LimpiarControles()
        DataGridPropiedades()

    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim BuscarAlmacen As New BuscarAlmacen
        BuscarAlmacen.ShowDialog()
        Dim codigoproductor As Object = BuscarAlmacen.CodigoCentro
        If BuscarAlmacen.CodigoCentro <> Nothing Then
            Dim cmd As New SqlCommand("sp_seleccioncentro", cnn)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@idcentroacopio", BuscarAlmacen.CodigoCentro))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)

            TxIdAcopio.Text = CStr(row("id_centroacopio"))
            TxNombreCentro.Text = CStr(row("nombrecentro"))
            TxFolioAserca.Text = CStr(row("folioaserca"))
            TxCalleCentro.Text = CStr(row("calle"))
            TxNumeroCentro.Text = CStr(row("numero"))
            CbColonia.Text = CStr(row("colonia"))
            TxCodigoPostal.Text = CStr(row("codigopostal"))
            CbCiudad.Text = CStr(row("ciudad"))
            TxEstado.Text = CStr(row("estado"))
            NuCapacidadCentro.Value = row("capacidadmax")
            TxIdAlmacen.Text = CStr(row("id_almacen"))
            TxNomAlm.Text = CStr(row("nombre_almacen"))
            CbTipoAlmacen.SelectedValue = CStr(row("tiposilo"))
            NuCapacidadAlmacen.Value = row("capacidad")

            ControlBotones()
            bloquearCampos()
        Else
            CargarData()
            DataGridPropiedades()
        End If

    End Sub
    Public codigoCliente_ As String
    Public Property codigoCliente() As String
        Get
            Return codigoCliente_
        End Get
        Set(ByVal value As String)
            codigoCliente_ = value
        End Set
    End Property

    Private Sub ControlBotones()
        If TxIdAcopio.Text = "" Then

            BtnModificar.Enabled = False
            BtnEliminar.Enabled = False

        Else

            BtnModificar.Enabled = True
            BtnEliminar.Enabled = True

        End If
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxNomAlm.Text = "" Or TxFolioAserca.Text = "" Or TxNombreCentro.Text = "" Then
            MessageBox.Show("Verifica campos en blanco", "Aviso")
        ElseIf centroRegistrado(TxIdAcopio.Text, TxIdAlmacen.Text) = True Then

            MessageBox.Show("Ya existe el Centro de Acopio " + TxIdAcopio.Text + " con el Almacen " + TxIdAlmacen.Text + ".")

        Else
            Try
                If TxIdAcopio.Text = "" Then

                    Dim cmd As New SqlCommand("Sp_InsNueAcopio", cnn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@IdAcopio", generaCodigoAcopio(TxIdAcopio.Text))
                    cmd.Parameters.AddWithValue("@nomAcopio", TxNombreCentro.Text)
                    cmd.Parameters.AddWithValue("@folioAserca", TxFolioAserca.Text)
                    cmd.Parameters.AddWithValue("@calle", TxCalleCentro.Text)
                    cmd.Parameters.AddWithValue("@numero", TxNumeroCentro.Text)
                    cmd.Parameters.AddWithValue("@colonia", CbColonia.Text)
                    cmd.Parameters.AddWithValue("@codigoPostal", TxCodigoPostal.Text)
                    cmd.Parameters.AddWithValue("@ciudad", CbCiudad.Text)
                    cmd.Parameters.AddWithValue("@estado", TxEstado.Text)

                    Dim SumaCapacidad As Double = 0
                    SumaCapacidad = NuCapacidadCentro.Value + NuCapacidadAlmacen.Value
                    NuCapacidadCentro.Value = SumaCapacidad
                    cmd.Parameters.AddWithValue("@CapacidadMax", NuCapacidadCentro.Value)
                    cmd.ExecuteNonQuery()
                    TxIdAcopio.Text = cmd.Parameters("@IdAcopio").Value.ToString()

                    Dim cmd2 As New SqlCommand("Sp_InsNueALm", cnn)
                    cmd2.CommandType = CommandType.StoredProcedure
                    cmd2.Parameters.AddWithValue("@Consecutivo", generaCodigoAlmacen(TxIdAlmacen.Text))
                    cmd2.Parameters.AddWithValue("@NomAlm", TxNomAlm.Text)
                    cmd2.Parameters.AddWithValue("@TipoSilo", CbTipoAlmacen.SelectedValue)
                    cmd2.Parameters.AddWithValue("@Capacidad", NuCapacidadAlmacen.Value)
                    cmd2.Parameters.AddWithValue("@idAcopio", TxIdAcopio.Text)
                    cmd2.ExecuteNonQuery()
                    TxIdAcopio.Text = cmd2.Parameters("@Consecutivo").Value.ToString()
                    CargarData()
                    bloquearCampos()
                Else
                    Dim sumacapacidadtotal As Double
                    Dim cmd2 As New SqlCommand("Sp_InsNueALm", cnn)

                    cmd2.CommandType = CommandType.StoredProcedure

                    cmd2.Parameters.AddWithValue("@Consecutivo", generaCodigoAlmacen(TxIdAlmacen.Text))
                    cmd2.Parameters.AddWithValue("@NomAlm", TxNomAlm.Text)
                    cmd2.Parameters.AddWithValue("@TipoSilo", CbTipoAlmacen.SelectedValue)
                    cmd2.Parameters.AddWithValue("@Capacidad", NuCapacidadAlmacen.Value)
                    cmd2.Parameters.AddWithValue("@idAcopio", TxIdAcopio.Text)
                    cmd2.ExecuteNonQuery()
                    TxIdAcopio.Text = cmd2.Parameters("@Consecutivo").Value.ToString()
                    cargarDataAlm()

                    sumacapacidadtotal = NuCapacidadCentro.Value + NuCapacidadAlmacen.Value
                    NuCapacidadCentro.Value = sumacapacidadtotal
                    Dim cmd3 As New SqlCommand("sp_ActualizaCapacidadmax", cnn)

                    cmd3.CommandType = CommandType.StoredProcedure

                    cmd3.Parameters.AddWithValue("@idcentroacopio", TxIdAcopio.Text)
                    cmd3.Parameters.AddWithValue("@capacidadtotal", sumacapacidadtotal)
                    cmd3.ExecuteNonQuery()
                    CargarData()
                    bloquearCampos()
                End If
            Catch ex As Exception
                MsgBox(ex, MsgBoxStyle.Critical)
            End Try

        End If
        ControlBotones()
    End Sub
    Private Sub Llenatextid()
        If TxIdAcopio.Text = "" Then
            Dim dt As New DataTable
            Dim SqlCon As String = "Select max(id_centroAcopio)as id_centroAcopio from centroAcopio"
            Dim comnd As New SqlCommand(SqlCon, cnn)
            Dim drd As SqlDataReader

            drd = comnd.ExecuteReader()

            If drd.Read() Then
                TxIdAcopio.Text = drd.Item("id_centroAcopio").ToString()

            End If
            drd.Close()

        Else
            Dim dt As New DataTable
            Dim SqlCon As String = "Select max(id_almacen)as id_almacen from almacen"
            Dim comnd As New SqlCommand(SqlCon, cnn)
            Dim drd As SqlDataReader

            drd = comnd.ExecuteReader()

            If drd.Read() Then
                TxIdAlmacen.Text = drd.Item("Id_almacen").ToString()

            End If
            drd.Close()

        End If
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LimpiarControles()
        ControlBotones()
        DesbloquearCampos()
    End Sub
    Private Sub CargarData()
        Dim cmd As New SqlCommand("Sp_LlenarDgAcopio", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable

        da.Fill(dt)
        DgAcopio.DataSource = dt
    End Sub
    Private Sub DataGridPropiedades()
        DgAcopio.Columns("id_centroacopio").HeaderText = "ID Centro Acopio"
        DgAcopio.Columns("NombreCentro").HeaderText = "Nombre"
        DgAcopio.Columns("folioAserca").HeaderText = "Folio ASERCA"
        DgAcopio.Columns("capacidadMAX").HeaderText = "Capacidad Maxima"
        DgAcopio.Columns("colonia").HeaderText = "Colonia"
        DgAcopio.Columns("ciudad").HeaderText = "Ciudad"

    End Sub
    Private Sub GridAlmacenPropiedades()
        DgAlmacen.Columns("id_Almacen").HeaderText = "ID Almacen"
        DgAlmacen.Columns("nombre_almacen").HeaderText = "Nombre de Almacen"
        DgAlmacen.Columns("tiposilo").HeaderText = "Tipo de Almacen"
        DgAlmacen.Columns("capacidad").HeaderText = "Capacidad por Almacen"
    End Sub
    Private Sub LimpiarControles()

        TxIdAcopio.Text = ""
        TxFolioAserca.Text = ""
        TxNombreCentro.Text = ""
        NuCapacidadCentro.Value = 0
        TxCalleCentro.Text = ""
        TxNumeroCentro.Text = ""
        CbColonia.Text = ""
        TxCodigoPostal.Text = ""
        CbCiudad.Text = ""
        TxEstado.Text = ""
        TxIdAlmacen.Text = ""
        TxNomAlm.Text = ""
        CbTipoAlmacen.Text = ""
        NuCapacidadAlmacen.Value = 0
        CbColonia.SelectedIndex = -1
        CbCiudad.SelectedIndex = -1
        CbTipoAlmacen.SelectedIndex = -1
        DgAlmacen.Columns.Clear()

    End Sub
    Private Sub DgAcopio_CellMouseUp(sender As Object, e As EventArgs) Handles DgAcopio.CellMouseClick
        If DgAcopio.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgAcopio Is Nothing Then
            Dim valorId As String

            valorId = CStr(DgAcopio.CurrentRow.Cells(0).Value)

            TxIdAcopio.Text = valorId

            Dim cmd As New SqlCommand("sp_seleccionID", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idcentroAcopio", valorId))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)

            TxFolioAserca.Text = CStr(row("folioAserca"))

            TxNombreCentro.Text = CStr(row("nombrecentro"))
            TxCalleCentro.Text = CStr(row("Calle"))
            TxNumeroCentro.Text = CStr(row("Numero"))
            CbColonia.Text = CStr(row("Colonia"))
            TxCodigoPostal.Text = CStr(row("codigopostal"))
            CbCiudad.Text = CStr(row("ciudad"))
            TxEstado.Text = CStr(row("estado"))
            NuCapacidadCentro.Value = row("CapacidadMax")

            TxIdAlmacen.Text = ""
            TxNomAlm.Text = ""
            CbTipoAlmacen.Text = ""
            NuCapacidadAlmacen.Value = 0
            bloquearCampos()
            ControlBotones()
        End If
    End Sub
    Private Sub cargarDataAlm()
        Dim valorId As String

        valorId = TxIdAcopio.Text

        Dim cmd As New SqlCommand("sp_llenarAlmacenXacopio", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@idacopio", valorId))

        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)
        DgAlmacen.DataSource = dt

        GridAlmacenPropiedades()
    End Sub
    Private Sub SeleccionarAcopio(sender As Object, e As EventArgs) Handles DgAcopio.DoubleClick
        If DgAcopio.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgAcopio Is Nothing Then
            Dim valorId As String

            valorId = CStr(DgAcopio.CurrentRow.Cells(0).Value)

            TxIdAcopio.Text = valorId

            Dim cmd As New SqlCommand("sp_llenarAlmacenXacopio", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idacopio", valorId))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)
            DgAlmacen.DataSource = dt

            GridAlmacenPropiedades()

            TxIdAlmacen.Text = ""
            TxNomAlm.Text = ""
            CbTipoAlmacen.Text = ""
            NuCapacidadAlmacen.Value = 0
            TcAlmacen.SelectedIndex = 1
            GbAlmacen.Enabled = True
        End If

    End Sub
    Private Sub DgAlmacen_CellMouseUp(sender As Object, e As EventArgs) Handles DgAlmacen.CellMouseClick
        If DgAlmacen.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgAlmacen Is Nothing Then
            Dim valorId As String

            valorId = CStr(DgAlmacen.CurrentRow.Cells(0).Value)

            TxIdAlmacen.Text = valorId

            Dim cmd As New SqlCommand("sp_seleccionIDalmacen", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idalmacen", valorId))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)

            TxNomAlm.Text = CStr(row("nombre_almacen"))
            CbTipoAlmacen.Text = CStr(row("tiposilo"))
            NuCapacidadAlmacen.Value = CStr(row("capacidad"))

        End If
        bloquearCampos()
    End Sub

    Private Sub llenarCombos()

        Dim cmdllenaCbCol As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet

        cmdllenaCbCol = New SqlCommand("Sp_CbColonias")
        cmdllenaCbCol.CommandType = CommandType.StoredProcedure
        cmdllenaCbCol.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbCol)
        ds = New DataSet()
        da.Fill(ds)
        CbColonia.DataSource = ds.Tables(0)
        CbColonia.DisplayMember = "nombre_colonia"
        CbColonia.ValueMember = "Id_colonia"
        CbColonia.SelectedIndex = -1


        Dim cmdllenaCbCiu As SqlCommand

        cmdllenaCbCiu = New SqlCommand("Sp_CbCiudades")
        cmdllenaCbCiu.CommandType = CommandType.StoredProcedure
        cmdllenaCbCiu.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbCiu)
        ds = New DataSet()
        da.Fill(ds)
        CbCiudad.DataSource = ds.Tables(0)
        CbCiudad.DisplayMember = "nombre_ciudad"
        CbCiudad.ValueMember = "id_ciudad"
        CbCiudad.SelectedIndex = -1

        Dim cmdllenaCbSil As SqlCommand


        cmdllenaCbSil = New SqlCommand("Sp_CbSilos")
        cmdllenaCbSil.CommandType = CommandType.StoredProcedure
        cmdllenaCbSil.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbSil)
        ds = New DataSet()
        da.Fill(ds)
        CbTipoAlmacen.DataSource = ds.Tables(0)
        CbTipoAlmacen.DisplayMember = "tiposilo"
        CbTipoAlmacen.ValueMember = "id_silo"
        CbTipoAlmacen.SelectedIndex = -1

    End Sub
    Private Sub BtSeleccionCentro_Click(sender As Object, e As EventArgs)
        SeleccionCentroAcopio.ShowDialog()
    End Sub
    Private Sub TxCapacidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub
    Private Sub bloquearCampos()
        GbAlmacen.Enabled = False
        GBCentroAcopio.Enabled = False
    End Sub
    Private Sub DesbloquearCampos()
        GbAlmacen.Enabled = True
        GBCentroAcopio.Enabled = True
    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxIdAcopio.Text <> "" Or TxIdAlmacen.Text <> "" Then
            Dim opc As DialogResult = MsgBox("¿Desea modificar campos al registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

            If opc = DialogResult.Yes Then

                BtActualiza.Enabled = True
                DesbloquearCampos()

            ElseIf opc = DialogResult.No Then

            End If
        Else
            MessageBox.Show("No hay registros para modificar, vaya al boton buscar y seleccione el registro deseado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtActualiza_Click(sender As Object, e As EventArgs) Handles BtActualiza.Click
        Try
            Dim cmd As New SqlCommand("sp_ActualizarCentroAcopio", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@idcentroacopio", TxIdAcopio.Text)
            cmd.Parameters.AddWithValue("@folioaserca", TxFolioAserca.Text)
            cmd.Parameters.AddWithValue("@nombrecentro", TxNombreCentro.Text)
            cmd.Parameters.AddWithValue("@colonia", CbColonia.Text)
            cmd.Parameters.AddWithValue("@codigoPostal", TxCodigoPostal.Text)
            cmd.Parameters.AddWithValue("@ciudad", CbCiudad.Text)
            cmd.Parameters.AddWithValue("@estado", TxEstado.Text)
            cmd.Parameters.AddWithValue("@idalmacen", TxIdAlmacen.Text)
            cmd.Parameters.AddWithValue("@nombreAlmacen", TxNomAlm.Text)
            cmd.Parameters.AddWithValue("@tipoSilo", IIf(CbTipoAlmacen.SelectedValue = Nothing, CbTipoAlmacen.Text = "", CbTipoAlmacen.SelectedValue))
            cmd.Parameters.AddWithValue("@capacidad", NuCapacidadAlmacen.Value)

            cmd.ExecuteNonQuery()
            bloquearCampos()
            BtActualiza.Enabled = False
            ControlBotones()
            CargarData()
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class