Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Text.RegularExpressions
Public Class Clientes
    Protected Friend GuardaRep As String = ""
    Protected Friend tipide As String = ""
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RbFisica.Checked = True
        llenarCombos()
        DesbloquearCampos()
        limpiarcampos()
        'este es un comentario de pruebadfdsdfdsf
    End Sub
    Private Sub RBTipoPersona() Handles RbMoral.CheckedChanged, RbFisica.CheckedChanged
        If RbFisica.Checked = True Then
            If TxIdFisica.Text <> "" Then
                TPMorales.Enabled = False
                TPFisicos.Enabled = False
            Else
                TPMorales.Enabled = False
                TPFisicos.Enabled = True
            End If

            TCClientes.SelectedIndex = 0
        ElseIf RbMoral.Checked = True Then
            If TxIdMoral.Text <> "" Then
                TPFisicos.Enabled = False
                TPMorales.Enabled = False
            Else
                TPFisicos.Enabled = False
                TPMorales.Enabled = True
            End If

            TCClientes.SelectedIndex = 1
        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxNumDomFisica.KeyPress, TxNumDomMoral.KeyPress, TxFolioAct.KeyPress, TxNumNotario.KeyPress, TxRegPublico.KeyPress, TxBajoNumero.KeyPress, TxFolioRpp.KeyPress, TxLibRpp.KeyPress
        Dim Cadena = ".0123456789S/NSsn"
        If InStr(Cadena, e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub SoloTx(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxCpFisica.KeyPress, TxCpostalMoral.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub
    Private Sub validarfc() Handles TxRfcFisico.MouseUp
        If TxRfcFisico.Text <> String.Empty Then
            If Regex.IsMatch(TxRfcFisico.Text.Trim, "^([A-Z\s]{4})\d{6}([A-Z\w]{3})$") = False Then
                MsgBox("El Registro no es válido. El formato correcto es: LLLL######LL ó LLLL######LLL. L=Letra, #=Número.")
            End If
        End If
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If RbFisica.Checked = True And RbMoral.Checked = False Then
            If TxNombre.Text = "" Or TxApellidos.Text = "" Or TxRfcFisico.Text = "" Or TxCurp.Text = "" Or TxNumIdenti.Text = "" Or TxCalleFisica.Text = "" Or TxNumDomFisica.Text = "" Or CbColoniaFisica.Text = "" Or TxCpFisica.Text = "" Or CbCiudadFisica.Text = "" Or TxEstadoFisica.Text = "" Then
                MessageBox.Show("Verifica campos en blanco", "Aviso")
            ElseIf clienteRegistrado(TxIdFisica.Text) = True Then

                MessageBox.Show("Ya existe el cliente " + TxIdFisica.Text + ".")

            Else
                Try
                    Dim DFMensajeProceso As FMSGPROv3 = New FMSGPROv3
                    DFMensajeProceso.Show()
                    Dim cmd As New SqlCommand("Sp_InsNueCliFis", cnn)

                    seleccionIdentificacionFisica()

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@Consecutivo", generaCodigoCliente(TxIdFisica.Text))
                    cmd.Parameters.AddWithValue("@nomper", TxNombre.Text)
                    cmd.Parameters.AddWithValue("@apeper", TxApellidos.Text)
                    cmd.Parameters.AddWithValue("@rfcper", TxRfcFisico.Text)
                    cmd.Parameters.AddWithValue("@tipper", "F")
                    cmd.Parameters.AddWithValue("@curp", TxCurp.Text)
                    cmd.Parameters.AddWithValue("@tipide", tipide)
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

                    'Llenatextid()

                    bloquearCampos()
                    DFMensajeProceso.CerrarProcesoInmediato()
                Catch ex As Exception
                    MsgBox(ex, MsgBoxStyle.Critical)
                End Try

            End If
        Else
            If TxRazonSocial.Text = "" Or TxRfcMoral.Text = "" Or TxRfcMoral.Text = "" Or TxFolioAct.Text = "" Or TxNumNotario.Text = "" Or TxRegPublico.Text = "" Or TxBajoNumero.Text = "" Or TxFme.Text = "" Or TxCalleMoral.Text = "" Or TxNumDomMoral.Text = "" Or CbColmor.Text = "" Or TxCpostalMoral.Text = "" Or CbCiuMoral.Text = "" Or TxEdoMoral.Text = "" Or CbNomRep.Text = "" Or TxRfcRep.Text = "" Or TxCurpRep.Text = "" Or TxNumIdeRep.Text = "" Then
                MessageBox.Show("Verifica campos en blanco", "Aviso")
            ElseIf clienteRegistrado(TxIdMoral.Text) = True Then

                MessageBox.Show("Ya existe el cliente " + TxIdMoral.Text + ".")

            Else
                Try
                    Dim DFMensajeProceso As FMSGPROv3 = New FMSGPROv3
                    DFMensajeProceso.Show()

                    Dim cmd As New SqlCommand("Sp_InsNueCliMor", cnn)

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@Consecutivo", generaCodigoCliente(TxIdMoral.Text))
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
                    cmd.Parameters.AddWithValue("@numdom", TxNumDomMoral.Text)
                    cmd.Parameters.AddWithValue("@colcli", CbColmor.Text)
                    cmd.Parameters.AddWithValue("@cpcli", TxCpostalMoral.Text)
                    cmd.Parameters.AddWithValue("@ciucli", CbCiuMoral.Text)
                    cmd.Parameters.AddWithValue("@edocli", TxEdoMoral.Text)
                    cmd.Parameters.AddWithValue("@telcli", TxTelMoral.Text)
                    cmd.Parameters.AddWithValue("@celcli", TxCelMoral.Text)
                    cmd.Parameters.AddWithValue("@email", TxEmailMoral.Text)
                    cmd.Parameters.AddWithValue("@RepLeg", IIf(CbNomRep.SelectedValue = Nothing, TxIdFisica.Text, CbNomRep.SelectedValue))

                    TxIdMoral.Text = cmd.Parameters("@Consecutivo").Value.ToString()

                    cmd.ExecuteNonQuery()

                    'Llenatextid()
                    bloquearCampos()
                    tipide = ""
                    DFMensajeProceso.CerrarProcesoInmediato()
                Catch ex As Exception
                    MsgBox(ex, MsgBoxStyle.Critical)
                End Try

            End If

        End If
    End Sub
    Private Sub Modificar(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxIdFisica.Text <> "" Or TxIdMoral.Text <> "" Then
            Dim opc As DialogResult = MsgBox("¿Desea modificar campos al registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

            If opc = DialogResult.Yes Then

                BtActualizar.Enabled = True
                DesbloquearCampos()

            ElseIf opc = DialogResult.No Then

            End If
        Else
            MessageBox.Show("No hay registros para modificar, vaya al boton buscar y seleccione el registro deseado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub BtActualizar_Click(sender As Object, e As EventArgs) Handles BtActualizar.Click

        Dim cmd As New SqlCommand("sp_seleccionActualizacion", cnn)

        cmd.Parameters.Add(New SqlClient.SqlParameter("@idcliente", IIf(TxIdFisica.Text <> "", TxIdFisica.Text, TxIdMoral.Text)))

        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        Dim row As DataRow = dt.Rows(0)

        If CStr(row("Tipo_Persona")) = "F" Then


            Dim cmd2 As New SqlCommand("sp_ActualizacionFisico", cnn)

            cmd2.CommandType = CommandType.StoredProcedure

            seleccionIdentificacionFisica()

            cmd2.Parameters.AddWithValue("@idcliente", IIf(TxIdMoral.Text <> "", TxIdMoral.Text, TxIdFisica.Text))
            cmd2.Parameters.AddWithValue("@nombre", TxNombre.Text)
            cmd2.Parameters.AddWithValue("@apellidos", TxApellidos.Text)
            cmd2.Parameters.AddWithValue("@rfc", TxRfcFisico.Text)
            cmd2.Parameters.AddWithValue("@curp", TxCurp.Text)
            cmd2.Parameters.AddWithValue("@tipoIdentificacion", tipide)
            cmd2.Parameters.AddWithValue("@identificacionCliente", TxNumIdenti.Text)
            cmd2.Parameters.AddWithValue("@calle", TxCalleFisica.Text)
            cmd2.Parameters.AddWithValue("@numDomicilio", TxNumDomFisica.Text)
            cmd2.Parameters.AddWithValue("@colonia", CbColoniaFisica.Text)
            cmd2.Parameters.AddWithValue("@cpostal", TxCpFisica.Text)
            cmd2.Parameters.AddWithValue("@ciudad", CbCiudadFisica.Text)
            cmd2.Parameters.AddWithValue("@estado", TxEstadoFisica.Text)
            cmd2.Parameters.AddWithValue("@telefono", TxTelfisica.Text)
            cmd2.Parameters.AddWithValue("@celular", TxCelFisica.Text)
            cmd2.Parameters.AddWithValue("@correoElectronico", TxCorreoFisica.Text)

            cmd2.ExecuteNonQuery()

            tipide = ""
            BtActualizar.Enabled = False
            bloquearCampos()
        ElseIf CStr(row("Tipo_Persona")) = "M" Then

            Dim cmd3 As New SqlCommand("sp_ActualizacionMoral", cnn)

            cmd3.CommandType = CommandType.StoredProcedure


            cmd3.Parameters.AddWithValue("@idcliente", IIf(TxIdMoral.Text <> "", TxIdMoral.Text, TxIdFisica.Text))
            cmd3.Parameters.AddWithValue("@razonSocial", TxRazonSocial.Text)
            cmd3.Parameters.AddWithValue("@rfc", TxRfcMoral.Text)
            cmd3.Parameters.AddWithValue("@calle", TxCalleMoral.Text)
            cmd3.Parameters.AddWithValue("@numDomicilio", TxNumDomMoral.Text)
            cmd3.Parameters.AddWithValue("@colonia", CbColmor.Text)
            cmd3.Parameters.AddWithValue("@cpostal", TxCpostalMoral.Text)
            cmd3.Parameters.AddWithValue("@ciudad", CbCiuMoral.Text)
            cmd3.Parameters.AddWithValue("@estado", TxEdoMoral.Text)
            cmd3.Parameters.AddWithValue("@telefono", TxTelMoral.Text)
            cmd3.Parameters.AddWithValue("@celular", TxCelMoral.Text)
            cmd3.Parameters.AddWithValue("@correoElectronico", TxEmailMoral.Text)
            cmd3.Parameters.AddWithValue("@fechaInicioOperaciones", DtIniOpe.Value)
            cmd3.Parameters.AddWithValue("@FolioActaCons", TxFolioAct.Text)
            cmd3.Parameters.AddWithValue("@FechaConstitucion", DtFechaAct.Value)
            cmd3.Parameters.AddWithValue("@NumeroNotario", TxNumNotario.Text)
            cmd3.Parameters.AddWithValue("@RegistroPublico", TxRegPublico.Text)
            cmd3.Parameters.AddWithValue("@BajoNumeroRPP", TxBajoNumero.Text)
            cmd3.Parameters.AddWithValue("@FolioRPP", TxFolioRpp.Text)
            cmd3.Parameters.AddWithValue("@LibroRPP", TxLibRpp.Text)
            cmd3.Parameters.AddWithValue("@FME", TxFme.Text)
            cmd3.Parameters.AddWithValue("@Fecha_FME", DtFme.Value)
            cmd3.Parameters.AddWithValue("@RepresentanteLegal", CbNomRep.SelectedValue)

            cmd3.ExecuteNonQuery()

            BtActualizar.Enabled = False
            bloquearCampos()

        End If

    End Sub
    Private Sub BtAgrRep_Click(sender As Object, e As EventArgs) Handles BtAgrRep.Click
        If GuardaRep = "Si" Then

            If TxNombre.Text = "" Or TxApellidos.Text = "" Or TxRfcFisico.Text = "" Or TxCurp.Text = "" Or TxNumIdenti.Text = "" Or TxCalleFisica.Text = "" Or TxNumDomFisica.Text = "" Or CbColoniaFisica.Text = "" Or TxCpFisica.Text = "" Or CbCiudadFisica.Text = "" Or TxEstadoFisica.Text = "" Or TxCorreoFisica.Text = "" Or TxTelfisica.Text = "" Or TxCelFisica.Text = "" Then
                MessageBox.Show("Verifica campos en blanco", "Aviso")
            ElseIf clienteRegistrado(TxIdFisica.Text) = True Then

                MessageBox.Show("Ya existe el cliente " + TxIdFisica.Text + ".")

            Else
                Try
                    Dim cmd As New SqlCommand("Sp_InsNueCliFis", cnn)

                    seleccionIdentificacionFisica()

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@Consecutivo", generaCodigoCliente(TxIdFisica.Text))
                    cmd.Parameters.AddWithValue("@nomper", TxNombre.Text)
                    cmd.Parameters.AddWithValue("@apeper", TxApellidos.Text)
                    cmd.Parameters.AddWithValue("@rfcper", TxRfcFisico.Text)
                    cmd.Parameters.AddWithValue("@tipper", "F")
                    cmd.Parameters.AddWithValue("@curp", TxCurp.Text)
                    cmd.Parameters.AddWithValue("@tipide", tipide)
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

                    'Llenatextid()
                    CbNomRep_SelectedIndexChanged(sender, e)
                    bloquearCampos()
                    BtAgrRep.Visible = False
                    RbMoral.Checked = True
                    GuardaRep = ""
                Catch ex As Exception
                    MsgBox("Error", MsgBoxStyle.Critical)
                End Try

            End If

        End If
    End Sub
    Private Sub Llenatextid()
        If RbFisica.Checked = True And RbMoral.Checked = False Then

            Dim dt As New DataTable
            Dim SqlCon As String = "Select max(id_cliente)As id_cliente from clientes"
            Dim comnd As New SqlCommand(SqlCon, cnn)
            Dim drd As SqlDataReader

            drd = comnd.ExecuteReader()

            If drd.Read() Then
                TxIdFisica.Text = drd.Item("Id_cliente").ToString()

            End If
            drd.Close()
        ElseIf RbFisica.Checked = False And RbMoral.Checked = True Then
            Dim dt As New DataTable
            Dim SqlCon As String = "Select max(id_cliente)As id_cliente from clientes"
            Dim comnd As New SqlCommand(SqlCon, cnn)
            Dim drd As SqlDataReader

            drd = comnd.ExecuteReader()

            If drd.Read() Then
                TxIdMoral.Text = drd.Item("Id_cliente").ToString()

            End If
            drd.Close()
        End If
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        limpiarcampos()
        llenarCombos()
        DesbloquearCampos()
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim BuscarCliente As New BuscarCliente
        BuscarCliente.ShowDialog()
        limpiarcampos()
        Dim codigoSeleccionado As Object = BuscarCliente.CodigoCliente
        If BuscarCliente.CodigoCliente <> Nothing Then
            Dim cmd As New SqlCommand("sp_seleccioncliente", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idcliente", BuscarCliente.CodigoCliente))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)
            If CStr(row("Tipo_Persona")) = "F" Then

                RbFisica.Checked = True

                TxIdFisica.Text = CStr(row("id_cliente"))
                TxNombre.Text = CStr(row("nombre_persona"))
                TxApellidos.Text = CStr(row("apellidos_persona"))
                TxRfcFisico.Text = CStr(row("RFC_Cliente"))
                TxCurp.Text = CStr(row("CURP_Cliente"))
                tipide = CStr(row("tipo_identificacion"))
                TxNumIdenti.Text = CStr(row("Identificacion_Cliente"))
                TxCalleFisica.Text = CStr(row("Calle_Cliente"))
                TxNumDomFisica.Text = CStr(row("Numero_Domicilio"))
                CbColoniaFisica.Text = CStr(row("Colonia_Cliente"))
                TxCpFisica.Text = CStr(row("cpostal_cliente"))
                CbCiudadFisica.Text = CStr(row("Ciudad_Cliente"))
                TxEstadoFisica.Text = CStr(row("Estado_Cliente"))
                TxTelfisica.Text = CStr(row("Telefono_Cliente"))
                TxCelFisica.Text = CStr(row("Celular_Cliente"))
                TxCorreoFisica.Text = CStr(row("Correo_Electronico"))
                Select Case tipide
                    Case "Credencial INE"
                        RbCreIneFisica.Checked = True
                    Case "Cartilla Militar"
                        RbCarMilFisica.Checked = True
                    Case "Pasaporte Mexicano"
                        RbPasMexFisica.Checked = True
                End Select

                tipide = ""

            ElseIf CStr(row("Tipo_Persona")) = "M" Then

                RbMoral.Checked = True

                TxIdMoral.Text = CStr(row("id_cliente"))
                TxRazonSocial.Text = CStr(row("razon_social"))
                TxRfcMoral.Text = CStr(row("RFC_Cliente"))
                DtIniOpe.Value = row("Fecha_Inicio_Operaciones")
                TxFolioAct.Text = CStr(row("Folio_Acta_Cons"))
                DtFechaAct.Value = row("Fecha_Constitucion")
                TxNumNotario.Text = CStr(row("Numero_Notario"))
                TxRegPublico.Text = CStr(row("Registro_Publico"))
                TxBajoNumero.Text = CStr(row("Bajo_Numero_RPP"))
                TxFolioRpp.Text = CStr(row("Folio_RPP"))
                TxLibRpp.Text = CStr(row("Libro_RPP"))
                TxFme.Text = CStr(row("Folio_Mercantil_Elec"))
                DtFme.Value = row("Fecha_FME")
                TxCalleMoral.Text = CStr(row("Calle_Cliente"))
                TxNumDomMoral.Text = CStr(row("Numero_Domicilio"))
                CbColmor.Text = CStr(row("Colonia_Cliente"))
                TxCpostalMoral.Text = CStr(row("cpostal_cliente"))
                CbCiuMoral.Text = CStr(row("Ciudad_Cliente"))
                TxEdoMoral.Text = CStr(row("Estado_Cliente"))
                TxTelMoral.Text = CStr(row("Telefono_Cliente"))
                TxCelMoral.Text = CStr(row("Celular_Cliente"))
                TxEmailMoral.Text = CStr(row("Correo_Electronico"))
                CbNomRep.SelectedValue = CStr(row("Representante_legal"))
                CbNomRep_SelectedIndexChanged(sender, e)
            End If
            bloquearCampos()
        ElseIf BuscarCliente.CodigoCliente = Nothing Then
            Exit Sub
        End If
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
        TxIdMoral.Text = ""
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
        TxNumDomMoral.Text = ""
        CbColmor.SelectedIndex = -1
        CbColmor.Text = ""
        TxCpostalMoral.Text = ""
        CbCiuMoral.SelectedIndex = -1
        CbCiuMoral.Text = ""
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

        BtActualizar.Enabled = False
    End Sub
    Private Sub llenarCombos()
        '############################################################################
        Dim cmdllenaCbColFis As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet

        cmdllenaCbColFis = New SqlCommand("Sp_CbColonias")
        cmdllenaCbColFis.CommandType = CommandType.StoredProcedure
        cmdllenaCbColFis.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbColFis)
        ds = New DataSet()
        da.Fill(ds)
        CbColoniaFisica.DataSource = ds.Tables(0)
        CbColoniaFisica.DisplayMember = "nombre_colonia"
        CbColoniaFisica.ValueMember = "Id_colonia"
        CbColoniaFisica.SelectedIndex = -1

        '############################################################################
        Dim cmdllenaCbColMor As SqlCommand

        cmdllenaCbColMor = New SqlCommand("Sp_CbColonias")
        cmdllenaCbColMor.CommandType = CommandType.StoredProcedure
        cmdllenaCbColMor.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbColMor)
        ds = New DataSet()
        da.Fill(ds)
        CbColmor.DataSource = ds.Tables(0)
        CbColmor.DisplayMember = "nombre_colonia"
        CbColmor.ValueMember = "Id_colonia"
        CbColmor.SelectedIndex = -1

        '############################################################################
        Dim cmdllenaCbCiuFis As SqlCommand

        cmdllenaCbCiuFis = New SqlCommand("Sp_CbCiudades")
        cmdllenaCbCiuFis.CommandType = CommandType.StoredProcedure
        cmdllenaCbCiuFis.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbCiuFis)
        ds = New DataSet()
        da.Fill(ds)
        CbCiudadFisica.DataSource = ds.Tables(0)
        CbCiudadFisica.DisplayMember = "nombre_ciudad"
        CbCiudadFisica.ValueMember = "id_ciudad"
        CbCiudadFisica.SelectedIndex = -1
        '############################################################################
        Dim cmdllenaCbCiuMor As SqlCommand

        cmdllenaCbCiuMor = New SqlCommand("Sp_CbCiudades")
        cmdllenaCbCiuMor.CommandType = CommandType.StoredProcedure
        cmdllenaCbCiuMor.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbCiuMor)
        ds = New DataSet()
        da.Fill(ds)

        CbCiuMoral.DataSource = ds.Tables(0)
        CbCiuMoral.DisplayMember = "nombre_ciudad"
        CbCiuMoral.ValueMember = "id_ciudad"
        CbCiuMoral.SelectedIndex = -1

        '###########################################################################
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
    Private Sub seleccionIdentificacionFisica()
        Select Case True
            Case RbCarMilFisica.Checked
                tipide = "Cartilla Militar"
            Case RbCreIneFisica.Checked
                tipide = "Credencial INE"
            Case RbPasMexFisica.Checked
                tipide = "Pasaporte Mexicano"
        End Select
    End Sub
    Private Sub BtNueRep_Click_1(sender As Object, e As EventArgs) Handles BtNueRep.Click
        If TxRazonSocial.Text = "" Or TxRfcMoral.Text = "" Or TxRfcMoral.Text = "" Or TxFolioAct.Text = "" Or TxNumNotario.Text = "" Or TxRegPublico.Text = "" Or TxBajoNumero.Text = "" Or TxFolioRpp.Text = "" Or TxFme.Text = "" Or TxCalleMoral.Text = "" Or TxNumDomMoral.Text = "" Or CbColmor.Text = "" Or TxCpostalMoral.Text = "" Or CbCiuMoral.Text = "" Or TxEdoMoral.Text = "" Then
            MessageBox.Show("Completa todos los campos anteriores para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            BtAgrRep.Visible = True
            RbFisica.Checked = True
            GuardaRep = "Si"
        End If
    End Sub
    Public Sub bloquearCampos()
        If RbFisica.Checked = True And RbMoral.Checked = False Then
            TPFisicos.Enabled = False
            TPMorales.Enabled = True
        ElseIf RbFisica.Checked = False And RbMoral.Checked = True And TxIdFisica.Text <> "" And TxIdMoral.Text = "" Then
            TPFisicos.Enabled = False
            TPMorales.Enabled = True
        ElseIf RbFisica.Checked = False And RbMoral.Checked = True And TxIdFisica.Text <> "" And TxIdMoral.Text <> "" Then
            TPFisicos.Enabled = False
            TPMorales.Enabled = False
        ElseIf RbFisica.Checked = False And RbMoral.Checked = True Then
            TPFisicos.Enabled = True
            TPMorales.Enabled = False
        End If
    End Sub
    Private Sub DesbloquearCampos()

        If RbFisica.Checked = True And RbMoral.Checked = False And TxIdMoral.Text = "" Then
            TPFisicos.Enabled = True
            TPMorales.Enabled = False

        ElseIf RbFisica.Checked = False And RbMoral.Checked = True And TxIdFisica.Text = "" Then
            TPFisicos.Enabled = False
            TPMorales.Enabled = True

        End If

    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim resp As DialogResult

        If TxIdFisica.Text <> "" And TxIdMoral.Text = "" Then
            resp = MessageBox.Show("Esta seguro de eliminar el cliente :" + TxIdFisica.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If resp = DialogResult.Yes Then
                Try
                    Dim eliminar As New SqlCommand("Sp_EliCli", cnn)
                    eliminar.CommandType = CommandType.StoredProcedure
                    eliminar.Parameters.AddWithValue("@Id_cliente", TxIdFisica.Text)
                    eliminar.ExecuteNonQuery()

                    limpiarcampos()

                Catch ex As Exception

                End Try
            End If

        ElseIf TxIdMoral.Text <> "" And TxIdFisica.Text = "" Then
            resp = MessageBox.Show("Esta seguro de eliminar el cliente :" + TxIdMoral.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If resp = DialogResult.Yes Then
                Try
                    Dim eliminar As New SqlCommand("Sp_EliCli", cnn)
                    eliminar.CommandType = CommandType.StoredProcedure
                    eliminar.Parameters.AddWithValue("@Id_cliente", TxIdMoral.Text)
                    eliminar.ExecuteNonQuery()

                    limpiarcampos()

                Catch ex As Exception

                End Try
            End If
        End If

    End Sub

    Private Sub CbNomRep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNomRep.SelectionChangeCommitted ', CbNomRep.ValueMemberChanged
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
        tipide = CStr(row("tipo_identificacion"))

        Select Case tipide
            Case "Credencial INE"
                RbCreInerep.Checked = True
            Case "Cartilla Militar"
                RbCarMilRep.Checked = True
            Case "Pasaporte Mexicano"
                RbPasMexRep.Checked = True
        End Select

        tipide = ""

    End Sub
    Private Sub CbNomRep_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbNomRep.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim cmd As New SqlCommand("sp_seleccionrepresentante", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idcliente", CbNomRep.SelectedValue))

            Dim darep As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            darep.Fill(dt)

            Dim row As DataRow = dt.Rows(0)
            CbNomRep.Text = CStr(row("nombre_representante"))
            TxRfcRep.Text = CStr(row("RFC_representante"))
            TxCurpRep.Text = CStr(row("CURP_representante"))
            TxNumIdeRep.Text = CStr(row("Identificacion_representante"))
            tipide = CStr(row("tipo_identificacion"))

            Select Case tipide
                Case "Credencial INE"
                    RbCreInerep.Checked = True
                Case "Cartilla Militar"
                    RbCarMilRep.Checked = True
                Case "Pasaporte Mexicano"
                    RbPasMexRep.Checked = True
            End Select

            tipide = ""
        End If

    End Sub
    Private PRCorEle As New Regex("\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b")
    Private Sub TxCorreoFisica_TextChanged(sender As Object, e As EventArgs) Handles TxCorreoFisica.Leave, TxEmailMoral.Leave
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

        If (TxNombre.Text <> "" And TxNombre.Enabled = True) Or (TxRazonSocial.Text <> "" And TxRazonSocial.Enabled = True) Then

            Dim opc = MessageBox.Show("¿Desea salir sin guardar posibles cambios en el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If opc = DialogResult.Yes Then
                Me.Close()
            ElseIf opc = DialogResult.No Then
                'BtnGuardar_Click(sender, e)
            End If
        Else

            Close()

        End If


    End Sub
End Class