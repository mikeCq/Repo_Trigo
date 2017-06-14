Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Trigo
    Private Sub Trigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tipoUsuario()
    End Sub
    Private _idUsuarioAutorizacion As String
    Public Property idUsuarioAutorizacion() As String
        Get
            Return _idUsuarioAutorizacion
        End Get
        Set(value As String)
            _idUsuarioAutorizacion = value
        End Set
    End Property
    Private Sub tipoUsuario()
        Dim infoUsuario As New Acceso
        Dim tipoUsuario As Object = Acceso.CodUsuario

        Dim cmd As New SqlCommand("sp_tipoUsuario", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@idusuario", tipoUsuario))
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        Dim row As DataRow = dt.Rows(0)

        SbNombreUsuario.Text = CStr(row("Nombre"))
        SbTipoUsuario.Text = CStr(row("Nombre_TipoUsuario"))
        SbIdUsuario.Text = CStr(row("id_usuario"))

        If CStr(row("id_tipoUsuario")) = 2 Or CStr(row("id_tipoUsuario")) = 3 Then
            UsuariosToolStripMenuItem.Enabled = False
            CertificadoDeCalidadToolStripMenuItem.Enabled = False
            AutorizacionDiariaToolStripMenuItem.Enabled = False
            CalculoDeLiquidaciónToolStripMenuItem.Enabled = False
            CalculoDeLiquidaciónPorCompradorToolStripMenuItem.Enabled = False
        End If
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Clientes.Show()
    End Sub
    Private Sub CiudadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadesToolStripMenuItem.Click
        Ciudades.ShowDialog()
    End Sub
    Private Sub TransportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransportesToolStripMenuItem.Click
        Transportes.ShowDialog()
    End Sub
    Private Sub ConductoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConductoresToolStripMenuItem.Click
        Conductores.ShowDialog()
    End Sub
    Private Sub AlmacenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenesToolStripMenuItem.Click
        Almacenes.ShowDialog()
    End Sub
    Private Sub ColoniasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColoniasToolStripMenuItem.Click
        Colonias.ShowDialog()
    End Sub
    Private Sub CompradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompradoresToolStripMenuItem.Click
        Compradores.ShowDialog()
    End Sub
    Private Sub SilosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Silos.ShowDialog()
    End Sub
    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Usuarios.ShowDialog()
    End Sub
    Private Sub EntradasDeTrigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasDeTrigoToolStripMenuItem.Click
        ControlEntradas.ShowDialog()
    End Sub
    Private Sub SalidasDeTrigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasDeTrigoToolStripMenuItem.Click
        ControlSalidas.ShowDialog()
    End Sub
    Private Sub EmbarquesDirectosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbarquesDirectosToolStripMenuItem.Click
        ControlEmbarques.ShowDialog()
    End Sub
    Private Sub ContratosDeTigoConCompradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratosDeTigoConCompradoresToolStripMenuItem.Click
        ContratosCompras.ShowDialog()
    End Sub
    Private Sub ContratosDeTrigoConCompradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratosDeTrigoConCompradoresToolStripMenuItem.Click
        ContratosVentas.ShowDialog()
    End Sub
    Private Sub TierrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TierrasToolStripMenuItem.Click
        Tierras.Show()
    End Sub
    Private Sub CalculoDeLiquidaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculoDeLiquidaciónToolStripMenuItem.Click
        liquidacionCalculosProd.ShowDialog()
    End Sub
    Private Sub CalculoDeLiquidaciónPorCompradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculoDeLiquidaciónPorCompradorToolStripMenuItem.Click
        LiquidacionXcomprador.ShowDialog()
    End Sub
    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        ReportesEntradas.ShowDialog()
    End Sub
    Private Sub SalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasToolStripMenuItem.Click
        ReportesSalidas.ShowDialog()
    End Sub
    Private Sub EmbarquesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbarquesToolStripMenuItem.Click
        ReportesEmbarquesXcomprador.ShowDialog()
    End Sub
    Private Sub ManualDeUusarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUusarioToolStripMenuItem.Click
        AyudaSistema.ShowDialog()
    End Sub
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Acercade.ShowDialog()
    End Sub
    Private Sub EnlaceABaseDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnlaceABaseDeToolStripMenuItem.Click
        GeneraFolios.ShowDialog()
    End Sub
    Private Sub ProductoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoresToolStripMenuItem.Click
        ReporteProductores.ShowDialog()
    End Sub
    Private Sub ContratosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratosToolStripMenuItem.Click
        ReporteContratos.ShowDialog()
    End Sub
    Private Sub LotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotesToolStripMenuItem.Click
        ReporteLotes.ShowDialog()
    End Sub
    Private Sub LiquidacionesCalculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiquidacionesCalculosToolStripMenuItem.Click
        liquidacionCalculosProd.ShowDialog()
    End Sub
    Private Sub EmbarquesPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbarquesPorClienteToolStripMenuItem.Click
        ReporteEmbarquesXcliente.ShowDialog()
    End Sub
    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem1.Click
        ReporteVentas.ShowDialog()
    End Sub
    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        ReporteCompras.ShowDialog()
    End Sub
    Private Sub ComprasDeTrigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasDeTrigoToolStripMenuItem.Click
        compradoresMaiz.ShowDialog()
    End Sub
    Private Sub VentasDeTrigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasDeTrigoToolStripMenuItem.Click
        ventasMaiz.ShowDialog()
    End Sub
    Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem.Click
        Empresas.ShowDialog()
    End Sub
    Private Sub CertificadoDeCalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificadoDeCalidadToolStripMenuItem.Click
        TablasCalidad.ShowDialog()
    End Sub
    Private Sub EntradasGlobalesPorProductorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasGlobalesPorProductorToolStripMenuItem.Click
        ReporteEntradasGlobalXprod.ShowDialog()
    End Sub
    Private Sub AutorizacionDiariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizacionDiariaToolStripMenuItem.Click
        VarGlob.idUsAutoriza = SbIdUsuario.Text
        AutorizacionDiaria.Show()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            SqlConnection.ClearAllPools()
            End
        ElseIf opc = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        SqlConnection.ClearAllPools()
        Me.Close()
    End Sub

    Private Sub EstatusDeContratosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstatusDeContratosToolStripMenuItem.Click
        ReporteEstatusContrato.ShowDialog()
    End Sub
End Class