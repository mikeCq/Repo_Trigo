Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Text.RegularExpressions
Public Class Empresas
    Dim modifica As Integer = 0
    Protected Friend GuardaRep As String = ""
    Protected Friend TipIde As String = ""
    Private Sub Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RbEmpresa.Checked = True
        llenarCombos()
        limpiarcampos()
        'TPRepresentante.Parent = Nothing1111

    End Sub
    Private Sub limpiarcampos()
        'LIMPIAR VALORES DE PESTAÑA FISICA
        TxIdFisica.Text = ""
        TxNombre.Text = ""
        TxApellidos.Text = ""
        TxRfcFisico.Text = ""
        TxCurp.Text = ""
        RbPasMexFisica.Checked = False
        RbCreIneFisica.Checked = False
        RbCarMilFisica.Checked = False
        TxNumIdenti.Text = ""
        TxCalleFisica.Text = ""
        TxNumDomFisica.Text = ""
        CbColoniaFisica.SelectedIndex = -1
        CbColoniaFisica.Text = ""
        TxCpFisica.Text = ""
        CbCiudadFisica.SelectedIndex = -1
        CbCiudadFisica.Text = ""
        TxEstadoFisica.Text = ""
        TxCorreoFisica.Text = ""
        TxTelfisica.Text = ""
        TxCelFisica.Text = ""
        'LIMPIAR VALORES DE PESTAÑA MORAL
        TxIdEmpresa.Text = ""
        TxRazonSocial.Text = ""
        TxRfcMoral.Text = ""
        DtIniOpe.Value = "01/01/1900"
        TxFolioAct.Text = ""
        DtFechaAct.Value = "01/01/1900"
        TxNumNotario.Text = ""
        TxRegPublico.Text = ""
        TxBajoNumero.Text = ""
        TxFolioRpp.Text = ""
        TxLibRpp.Text = ""
        TxFme.Text = ""
        DtFme.Value = "01/01/1900"
        TxCalleMoral.Text = ""
        TxNumEmpresa.Text = ""
        CbColmor.SelectedIndex = -1
        TxCpostalMoral.Text = ""
        CbCiuMoral.SelectedIndex = -1
        TxEdoMoral.Text = ""
        TxTelMoral.Text = ""
        TxCelMoral.Text = ""
        TxEmailMoral.Text = ""
        CbNomRep.SelectedIndex = -1
        CbNomRep.Text = ""
        TxRfcRep.Text = ""
        TxCurpRep.Text = ""
        RbCreInerep.Checked = False
        RbCarMilRep.Checked = False
        RbPasMexRep.Checked = False
        TxNumIdeRep.Text = ""
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
        CbColoniaFisica.DataSource = ds.Tables(0)
        CbColoniaFisica.DisplayMember = "nombre_colonia"
        CbColoniaFisica.ValueMember = "Id_colonia"
        CbColoniaFisica.SelectedIndex = -1

        CbColmor.DataSource = ds.Tables(0)
        CbColmor.DisplayMember = "nombre_colonia"
        CbColmor.ValueMember = "Id_colonia"
        CbColmor.SelectedIndex = -1

        Dim cmdllenaCbCiu As SqlCommand

        cmdllenaCbCiu = New SqlCommand("Sp_CbCiudades")
        cmdllenaCbCiu.CommandType = CommandType.StoredProcedure
        cmdllenaCbCiu.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbCiu)
        ds = New DataSet()
        da.Fill(ds)
        CbCiudadFisica.DataSource = ds.Tables(0)
        CbCiudadFisica.DisplayMember = "nombre_ciudad"
        CbCiudadFisica.ValueMember = "id_ciudad"
        CbCiudadFisica.SelectedIndex = -1

        CbCiuMoral.DataSource = ds.Tables(0)
        CbCiuMoral.DisplayMember = "nombre_ciudad"
        CbCiuMoral.ValueMember = "id_ciudad"
        CbCiuMoral.SelectedIndex = -1

        Dim cmdllenaCbRep As SqlCommand

        cmdllenaCbRep = New SqlCommand("Sp_CbRepresentante")
        cmdllenaCbRep.CommandType = CommandType.StoredProcedure
        cmdllenaCbRep.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbRep)
        ds = New DataSet()
        If da Is Nothing Then
            Exit Sub
        Else
            da.Fill(ds)
            CbNomRep.DataSource = ds.Tables(0)
            CbNomRep.DisplayMember = "nombreRepresentante"
            CbNomRep.ValueMember = "id_cliente"
            CbNomRep.SelectedIndex = -1
        End If

    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim opc As DialogResult = MessageBox.Show("¿Esta seguro de modificar los datos del registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            DesbloquearCampos()
            modifica = 1
        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxNumEmpresa.KeyPress, TxFolioAct.KeyPress, TxNumNotario.KeyPress, TxRegPublico.KeyPress, TxBajoNumero.KeyPress, TxFolioRpp.KeyPress, TxLibRpp.KeyPress, TxNumDomFisica.KeyPress
        Dim Cadena = ".0123456789S/NSsn"
        If InStr(Cadena, e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub RBTipoPersona() Handles RbEmpresa.CheckedChanged, RbRepresentante.CheckedChanged
        If RbEmpresa.Checked = True Then
            If TxIdFisica.Text <> "" Then
                TPRepresentante.Enabled = False
                TPEmpresa.Enabled = False
            Else
                TPRepresentante.Enabled = False
                TPEmpresa.Enabled = True
            End If
            TCEmpresa.SelectedIndex = 0
        ElseIf RbRepresentante.Checked = True Then
            If TxIdEmpresa.Text <> "" Then
                TPRepresentante.Enabled = False
                TPEmpresa.Enabled = False
            Else
                TPEmpresa.Enabled = False
                TPRepresentante.Enabled = True
            End If
            TCEmpresa.SelectedIndex = 1
        End If
    End Sub
    Private Sub Guardar() Handles BtnGuardar.Click
        If RbRepresentante.Checked = True And RbEmpresa.Checked = False Then
            If TxNombre.Text = "" Or TxApellidos.Text = "" Or TxRfcFisico.Text = "" Or TxCurp.Text = "" Or TxNumIdenti.Text = "" Or TxCalleFisica.Text = "" Or TxNumDomFisica.Text = "" Or CbColoniaFisica.Text = "" Or TxCpFisica.Text = "" Or CbCiudadFisica.Text = "" Or TxEstadoFisica.Text = "" Or TxCorreoFisica.Text = "" Or TxTelfisica.Text = "" Or TxCelFisica.Text = "" Then
                MessageBox.Show("Verifica campos en blanco", "Aviso")
            ElseIf clienteRegistrado(TxIdFisica.Text) = True And modifica = 0 Then

                MessageBox.Show("Ya existe el cliente " + TxIdFisica.Text + ".")
            ElseIf clienteRegistrado(TxIdFisica.Text) = True And modifica = 1 Then


            Else
                Try
                    Dim cmd As New SqlCommand("Sp_InsNueCliFis", cnn)

                    seleccionIdentificacionRepresentante()

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@Consecutivo", generaCodigoCliente(TxIdFisica.Text))
                    cmd.Parameters.AddWithValue("@nomper", TxNombre.Text)
                    cmd.Parameters.AddWithValue("@apeper", TxApellidos.Text)
                    cmd.Parameters.AddWithValue("@rfcper", TxRfcFisico.Text)
                    cmd.Parameters.AddWithValue("@tipper", "F")
                    cmd.Parameters.AddWithValue("@curp", TxCurp.Text)
                    cmd.Parameters.AddWithValue("@tipide", TipIde)
                    cmd.Parameters.AddWithValue("@idecli", TxNumIdenti.Text)
                    cmd.Parameters.AddWithValue("@calle", TxCalleFisica.Text)
                    cmd.Parameters.AddWithValue("@numdom", TxNumDomFisica.Text)
                    cmd.Parameters.AddWithValue("@colcli", CbColoniaFisica.Text)
                    cmd.Parameters.AddWithValue("@cpcli", TxCpFisica.Text)
                    cmd.Parameters.AddWithValue("@ciucli", CbCiudadFisica.Text)
                    cmd.Parameters.AddWithValue("@edocli", TxEstadoFisica.Text)
                    cmd.Parameters.AddWithValue("@telcli", TxTelfisica.Text)
                    cmd.Parameters.AddWithValue("@celcli", TxCelFisica.Text)
                    cmd.Parameters.AddWithValue("@email", TxCorreoFisica.Text)

                    TxIdFisica.Text = cmd.Parameters("@Consecutivo").Value.ToString()

                    cmd.ExecuteNonQuery()

                    bloquearCampos()

                Catch ex As Exception
                    MsgBox("Error", MsgBoxStyle.Critical)
                End Try

            End If
        Else
            If TxRazonSocial.Text = "" Or TxRfcMoral.Text = "" Or TxRfcMoral.Text = "" Or TxFolioAct.Text = "" Or TxNumNotario.Text = "" Or TxRegPublico.Text = "" Or TxBajoNumero.Text = "" Or TxFolioRpp.Text = "" Or TxFme.Text = "" Or TxCalleMoral.Text = "" Or TxNumEmpresa.Text = "" Or CbColmor.Text = "" Or TxCpostalMoral.Text = "" Or CbCiuMoral.Text = "" Or TxEdoMoral.Text = "" Or TxTelMoral.Text = "" Or TxCelMoral.Text = "" Or TxEmailMoral.Text = "" Or CbNomRep.Text = "" Or TxRfcRep.Text = "" Or TxCurpRep.Text = "" Or TxNumIdeRep.Text = "" Then
                MessageBox.Show("Verifica campos en blanco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf RepresentanteRegistrado(TxIdEmpresa.Text) = True And modifica = 0 Then

                MessageBox.Show("Ya existe el cliente " + TxIdEmpresa.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf RepresentanteRegistrado(TxIdEmpresa.Text) = True And modifica = 1 Then
                Actualiza()
                MessageBox.Show("Empresa actualizada con exito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Try
                    Dim cmd As New SqlCommand("Sp_InsNueEmpresa", cnn)

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@idEmpresa", generaCodigoEmpresa(TxIdEmpresa.Text))
                    cmd.Parameters.AddWithValue("@razsoc", TxRazonSocial.Text)
                    cmd.Parameters.AddWithValue("@tipper", "M")
                    cmd.Parameters.AddWithValue("@rfcper", TxRfcMoral.Text)
                    cmd.Parameters.AddWithValue("@Iniope", DtIniOpe.Value)
                    cmd.Parameters.AddWithValue("@FolAct", TxFolioAct.Text)
                    cmd.Parameters.AddWithValue("@FecAct", DtFechaAct.Value)
                    cmd.Parameters.AddWithValue("@numnot", TxNumNotario.Text)
                    cmd.Parameters.AddWithValue("@regpub", TxRegPublico.Text)
                    cmd.Parameters.AddWithValue("@bajrpp", TxBajoNumero.Text)
                    cmd.Parameters.AddWithValue("@folrpp", TxFolioRpp.Text)
                    cmd.Parameters.AddWithValue("@librpp", TxLibRpp.Text)
                    cmd.Parameters.AddWithValue("@folmer", TxFme.Text)
                    cmd.Parameters.AddWithValue("@fecfme", DtFme.Value)
                    cmd.Parameters.AddWithValue("@calle", TxCalleMoral.Text)
                    cmd.Parameters.AddWithValue("@numdom", TxNumEmpresa.Text)
                    cmd.Parameters.AddWithValue("@colcli", CbColmor.Text)
                    cmd.Parameters.AddWithValue("@cpcli", TxCpostalMoral.Text)
                    cmd.Parameters.AddWithValue("@ciucli", CbCiuMoral.Text)
                    cmd.Parameters.AddWithValue("@edocli", TxEdoMoral.Text)
                    cmd.Parameters.AddWithValue("@telcli", TxTelMoral.Text)
                    cmd.Parameters.AddWithValue("@celcli", TxCelMoral.Text)
                    cmd.Parameters.AddWithValue("@email", TxEmailMoral.Text)
                    cmd.Parameters.AddWithValue("@RepLeg", IIf(CbNomRep.SelectedValue = Nothing, TxIdFisica.Text, CbNomRep.SelectedValue))

                    TxIdEmpresa.Text = cmd.Parameters("@idEmpresa").Value.ToString()

                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex, MsgBoxStyle.Critical)
                End Try

            End If
        End If
    End Sub
    Private Sub BtAgrRep_Click(sender As Object, e As EventArgs) Handles BtAgregarRep.Click
        If GuardaRep = "Si" Then

            If TxNombre.Text = "" Or TxApellidos.Text = "" Or TxRfcFisico.Text = "" Or TxCurp.Text = "" Or TxNumIdenti.Text = "" Or TxCalleFisica.Text = "" Or TxNumDomFisica.Text = "" Or CbColoniaFisica.Text = "" Or TxCpFisica.Text = "" Or CbCiudadFisica.Text = "" Or TxEstadoFisica.Text = "" Or TxCorreoFisica.Text = "" Or TxTelfisica.Text = "" Or TxCelFisica.Text = "" Then
                MessageBox.Show("Verifica campos en blanco", "Aviso")
            ElseIf clienteRegistrado(TxIdFisica.Text) = True Then

                MessageBox.Show("Ya existe el cliente " + TxIdFisica.Text + ".")

            Else
                Try
                    Dim cmd As New SqlCommand("Sp_InsNueCliFis", cnn)

                    seleccionIdentificacionRepresentante()

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@Consecutivo", generaCodigoCliente(TxIdFisica.Text))
                    cmd.Parameters.AddWithValue("@nomper", TxNombre.Text)
                    cmd.Parameters.AddWithValue("@apeper", TxApellidos.Text)
                    cmd.Parameters.AddWithValue("@rfcper", TxRfcFisico.Text)
                    cmd.Parameters.AddWithValue("@tipper", "F")
                    cmd.Parameters.AddWithValue("@curp", TxCurp.Text)
                    cmd.Parameters.AddWithValue("@tipide", TipIde)
                    cmd.Parameters.AddWithValue("@idecli", TxNumIdenti.Text)
                    cmd.Parameters.AddWithValue("@calle", TxCalleFisica.Text)
                    cmd.Parameters.AddWithValue("@numdom", TxNumDomFisica.Text)
                    cmd.Parameters.AddWithValue("@colcli", CbColoniaFisica.Text)
                    cmd.Parameters.AddWithValue("@cpcli", TxCpFisica.Text)
                    cmd.Parameters.AddWithValue("@ciucli", CbCiudadFisica.Text)
                    cmd.Parameters.AddWithValue("@edocli", TxEstadoFisica.Text)
                    cmd.Parameters.AddWithValue("@telcli", TxTelfisica.Text)
                    cmd.Parameters.AddWithValue("@celcli", TxCelFisica.Text)
                    cmd.Parameters.AddWithValue("@email", TxCorreoFisica.Text)

                    cmd.ExecuteNonQuery()
                    CbNomRep_SelectedIndexChanged(sender, e)
                    bloquearCampos()
                    BtAgregarRep.Visible = False
                    RbRepresentante.Checked = True
                    GuardaRep = ""
                Catch ex As Exception
                    MsgBox("Error", MsgBoxStyle.Critical)
                End Try

            End If

        End If
    End Sub
    Private Sub Actualiza()
        Try
            Dim cmd As New SqlCommand("sp_ActualizaEmpresaM", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@idEmpresa", TxIdEmpresa.Text)
            cmd.Parameters.AddWithValue("@razonSocial", TxRazonSocial.Text)
            cmd.Parameters.AddWithValue("@Rfc", TxRfcMoral.Text)
            cmd.Parameters.AddWithValue("@inicioOperaciones", DtIniOpe.Value)
            cmd.Parameters.AddWithValue("@FolioActa", TxFolioAct.Text)
            cmd.Parameters.AddWithValue("@FechaActa", DtFechaAct.Value)
            cmd.Parameters.AddWithValue("@NumNotario", TxNumNotario.Text)
            cmd.Parameters.AddWithValue("@RegPublico", TxRegPublico.Text)
            cmd.Parameters.AddWithValue("@BajoNumeroRpp", TxBajoNumero.Text)
            cmd.Parameters.AddWithValue("@FolioRpp", TxFolioRpp.Text)
            cmd.Parameters.AddWithValue("@LibroRpp", TxLibRpp.Text)
            cmd.Parameters.AddWithValue("@Fme", TxFme.Text)
            cmd.Parameters.AddWithValue("@FechaFme", DtFme.Value)
            cmd.Parameters.AddWithValue("@calle", TxCalleMoral.Text)
            cmd.Parameters.AddWithValue("@numdom", TxNumEmpresa.Text)
            cmd.Parameters.AddWithValue("@Colonia", CbColmor.Text)
            cmd.Parameters.AddWithValue("@CPostal", TxCpostalMoral.Text)
            cmd.Parameters.AddWithValue("@Ciudad", CbCiuMoral.Text)
            cmd.Parameters.AddWithValue("@Estado", TxEdoMoral.Text)
            cmd.Parameters.AddWithValue("@Telefono", TxTelMoral.Text)
            cmd.Parameters.AddWithValue("@Celular", TxCelMoral.Text)
            cmd.Parameters.AddWithValue("@email", TxEmailMoral.Text)
            cmd.Parameters.AddWithValue("@RepresentanteLegal",CbNomRep.SelectedValue)
            cmd.ExecuteNonQuery()
            modifica = 0
            bloquearCampos()
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim BuscarEmpresa As New BuscarEmpresa
        BuscarEmpresa.ShowDialog()
        limpiarcampos()
        Dim codigoSeleccionado As Object = BuscarEmpresa.CodigoCliente
        If BuscarEmpresa.CodigoCliente <> Nothing Then
            Dim cmd As New SqlCommand("sp_seleccionempresas", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idempresa", BuscarEmpresa.CodigoCliente))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)
            If CStr(row("TipoPersona")) = "M" Then

                RbEmpresa.Checked = True

                TxIdEmpresa.Text = CStr(row("id_empresa"))
                TxRazonSocial.Text = CStr(row("razonSocial"))
                TxRfcMoral.Text = CStr(row("RFC"))
                DtIniOpe.Value = row("Fecha_Inicio_Operaciones")
                TxFolioAct.Text = CStr(row("Folio_Acta_Cons"))
                DtFechaAct.Value = row("FechaConstitucion")
                TxNumNotario.Text = CStr(row("NumeroNotario"))
                TxRegPublico.Text = CStr(row("RegistroPublico"))
                TxBajoNumero.Text = CStr(row("Bajo_Numero_RPP"))
                TxFolioRpp.Text = CStr(row("FolioRPP"))
                TxLibRpp.Text = CStr(row("LibroRPP"))
                TxFme.Text = CStr(row("FolioMercantil_Elec"))
                DtFme.Value = row("FechaFME")
                TxCalleMoral.Text = CStr(row("Calle"))
                TxNumEmpresa.Text = CStr(row("NumeroDomicilio"))
                CbColmor.Text = CStr(row("Colonia"))
                TxCpostalMoral.Text = CStr(row("cpostal"))
                CbCiuMoral.Text = CStr(row("Ciudad"))
                TxEdoMoral.Text = CStr(row("Estado"))
                TxTelMoral.Text = CStr(row("Telefono"))
                TxCelMoral.Text = CStr(row("Celular"))
                TxEmailMoral.Text = CStr(row("CorreoElectronico"))
                CbNomRep.SelectedValue = CStr(row("Representante_legal"))
                CbNomRep_SelectedIndexChanged(sender, e)
            End If
            bloquearCampos()
        ElseIf BuscarCliente.CodigoCliente = Nothing Then
            Exit Sub
        End If
    End Sub
    Private Sub BtNueRep_Click(sender As Object, e As EventArgs) Handles BtNueRep.Click
        If TxRazonSocial.Text = "" Or TxRfcMoral.Text = "" Or TxRfcMoral.Text = "" Or TxFolioAct.Text = "" Or TxNumNotario.Text = "" Or TxRegPublico.Text = "" Or TxBajoNumero.Text = "" Or TxFolioRpp.Text = "" Or TxFme.Text = "" Or TxCalleMoral.Text = "" Or TxNumEmpresa.Text = "" Or CbColmor.Text = "" Or TxCpostalMoral.Text = "" Or CbCiuMoral.Text = "" Or TxEdoMoral.Text = "" Or TxTelMoral.Text = "" Or TxCelMoral.Text = "" Or TxEmailMoral.Text = "" Then
            MessageBox.Show("Completa todos los campos anteriores para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            BtAgregarRep.Visible = True
            RbRepresentante.Checked = True
            GuardaRep = "Si"
        End If
    End Sub
    Private Sub seleccionIdentificacionRepresentante()
        Select Case True
            Case RbCarMilFisica.Checked
                TipIde = "Cartilla Militar"
            Case RbCreIneFisica.Checked
                TipIde = "Credencial INE"
            Case RbPasMexFisica.Checked
                TipIde = "Pasaporte Mexicano"
        End Select
    End Sub
    Public Sub bloquearCampos()
        If RbRepresentante.Checked = True And RbEmpresa.Checked = False Then
            TPRepresentante.Enabled = False
            TPEmpresa.Enabled = True
        ElseIf RbRepresentante.Checked = False And RbEmpresa.Checked = True And TxIdFisica.Text <> "" And TxIdEmpresa.Text = "" Then
            TPRepresentante.Enabled = False
            TPEmpresa.Enabled = True
        ElseIf RbRepresentante.Checked = False And RbEmpresa.Checked = True And TxIdFisica.Text <> "" And TxIdEmpresa.Text <> "" Then
            TPRepresentante.Enabled = False
            TPEmpresa.Enabled = False
        ElseIf RbRepresentante.Checked = False And RbEmpresa.Checked = True Then
            TPRepresentante.Enabled = True
            TPEmpresa.Enabled = False
        End If
    End Sub
    Private Sub CbNomRep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNomRep.SelectionChangeCommitted, CbNomRep.Click
        If CbNomRep.SelectedValue <> Nothing Then
            Dim cmd As New SqlCommand("sp_seleccionrepresentante", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idcliente", IIf(CbNomRep.SelectedValue = Nothing, TxIdFisica.Text, CbNomRep.SelectedValue)))

            Dim darep As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            darep.Fill(dt)

            Dim row As DataRow = dt.Rows(0)

            CbNomRep.Text = CStr(row("nombre_representante"))
            TxRfcRep.Text = CStr(row("RFC_representante"))
            TxCurpRep.Text = CStr(row("CURP_representante"))
            TxNumIdeRep.Text = CStr(row("Identificacion_representante"))
            TipIde = CStr(row("tipo_identificacion"))

            Select Case TipIde
                Case "Credencial INE"
                    RbCreInerep.Checked = True
                Case "Cartilla Militar"
                    RbCarMilRep.Checked = True
                Case "Pasaporte Mexicano"
                    RbPasMexRep.Checked = True
            End Select

            TipIde = ""
        End If

    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        limpiarcampos()
        DesbloquearCampos()
    End Sub
    Private Sub DesbloquearCampos()
        If RbRepresentante.Checked = True And RbEmpresa.Checked = False And TxIdEmpresa.Text = "" Then
            TPRepresentante.Enabled = True
            TPEmpresa.Enabled = False
        ElseIf RbRepresentante.Checked = False And RbEmpresa.Checked = True And TxIdFisica.Text = "" Then
            TPRepresentante.Enabled = False
            TPEmpresa.Enabled = True
        End If
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim resp As DialogResult

        If TxIdFisica.Text <> "" And TxIdEmpresa.Text = "" Then
            resp = MessageBox.Show("Esta seguro de eliminar el cliente :" + TxIdFisica.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If resp = DialogResult.Yes Then
                Try
                    Dim eliminar As New SqlCommand("Sp_EliminarEmpresa", cnn)

                    eliminar.CommandType = CommandType.StoredProcedure

                    eliminar.Parameters.AddWithValue("@Idempresa", TxIdFisica.Text)

                    eliminar.ExecuteNonQuery()

                    limpiarcampos()

                Catch ex As Exception

                End Try
            End If

        ElseIf TxIdEmpresa.Text <> "" And TxIdFisica.Text = "" Then
            resp = MessageBox.Show("Esta seguro de eliminar el cliente :" + TxIdEmpresa.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If resp = DialogResult.Yes Then
                Try
                    Dim eliminar As New SqlCommand("Sp_EliminarEmpresa", cnn)

                    eliminar.CommandType = CommandType.StoredProcedure

                    eliminar.Parameters.AddWithValue("@Idempresa", TxIdEmpresa.Text)

                    eliminar.ExecuteNonQuery()

                    limpiarcampos()

                Catch ex As Exception

                End Try
            End If
        End If

    End Sub
    Private PRCorEle As New Regex("\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b")
    Private Sub TxCorreoFisica_TextChanged(sender As Object, e As EventArgs) Handles TxEmailMoral.Leave
        If Not PRCorEle.IsMatch(TxCorreoFisica.Text) And TxCorreoFisica.Text <> "" Then
            MessageBox.Show("El correo no cuenta con el formato correcto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxCorreoFisica.Focus()
        End If
        If Not PRCorEle.IsMatch(TxEmailMoral.Text) And TxEmailMoral.Text <> "" Then
            MessageBox.Show("El correo no cuenta con el formato correcto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxEmailMoral.Focus()
        End If
    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

End Class