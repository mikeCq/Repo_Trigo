Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteCompras
    Private Sub ReporteCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrComprasXproductor.ReportSource = Nothing
        CrComprasXproductor.Refresh()
        limpiarCampos()
        llenarCombos()
    End Sub
    Private Sub llenarCombos()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim cmdllenaCbPro As SqlCommand

        cmdllenaCbPro = New SqlCommand("sp_cproductoresConliquidaciones")
        cmdllenaCbPro.CommandType = CommandType.StoredProcedure
        cmdllenaCbPro.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbPro)
        ds = New DataSet()
        da.Fill(ds)
        CbProductor.DataSource = ds.Tables(0)
        CbProductor.DisplayMember = "nombreProductor"
        CbProductor.ValueMember = "Id_cliente"
        CbProductor.SelectedIndex = -1
    End Sub
    Private Sub limpiarCampos() Handles Btlimpiar.Click
        CbProductor.Text = ""
        CbProductor.SelectedIndex = -1
        DTInicio.Value = "01/01/1900"
        DTFinal.Value = "01/01/1900"
        CbTipoContrato.Text = ""
        CbTipoContrato.SelectedIndex = -1
    End Sub
    Private Sub generaReporte(sender As Object, e As EventArgs) Handles BtGenerarReporte.Click
        Try
            Dim RptReporteCompras As New RptComprasXproductor
            If DTInicio.Value <= DTFinal.Value And DTFinal.Value >= DTInicio.Value Then
                'RptReporteCompras.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
                'RptReporteCompras.SetParameterValue("@idproductor", IIf(CbProductor.SelectedValue = Nothing, "", CbProductor.SelectedValue))
                'RptReporteCompras.SetParameterValue("@tipoContrato", IIf(CbTipoContrato.Text = Nothing, "", CbTipoContrato.Text))
                'RptReporteCompras.SetParameterValue("@fechaini", DTInicio.Value)
                'RptReporteCompras.SetParameterValue("@fechafin", DTFinal.Value)
                'CrComprasXproductor.ReportSource = RptReporteCompras

                Try
                    Dim da As New SqlCommand("sp_ReporteCompras", cnn)
                    da.CommandType = CommandType.StoredProcedure
                    Dim TipoContrato As New SqlClient.SqlParameter()
                    Dim idProductor As New SqlClient.SqlParameter()
                    Dim Fechainicial As New SqlClient.SqlParameter()
                    Dim FechaFinal As New SqlClient.SqlParameter()

                    idProductor.ParameterName = "@idproductor"
                    TipoContrato.ParameterName = "@tipoContrato"
                    Fechainicial.ParameterName = "@fechaini"
                    FechaFinal.ParameterName = "@fechafin"

                    TipoContrato.SqlDbType = SqlDbType.NVarChar
                    idProductor.SqlDbType = SqlDbType.NVarChar
                    Fechainicial.SqlDbType = SqlDbType.Date
                    FechaFinal.SqlDbType = SqlDbType.Date

                    idProductor.Value = IIf(CbProductor.SelectedValue Is Nothing, "", CbProductor.SelectedValue)
                    TipoContrato.Value = IIf(CbTipoContrato.Text Is Nothing, "", CbTipoContrato.Text)
                    Fechainicial.Value = DTInicio.Value
                    FechaFinal.Value = DTFinal.Value

                    da.Parameters.Add(TipoContrato)
                    da.Parameters.Add(idProductor)
                    da.Parameters.Add(Fechainicial)
                    da.Parameters.Add(FechaFinal)

                    Dim dasp_ReporteCompras As New SqlClient.SqlDataAdapter()
                    dasp_ReporteCompras.SelectCommand = da
                    Dim ds As New DataTable
                    dasp_ReporteCompras.Fill(ds)

                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    ' Asigno el reporte 
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    'CrReport.Load(Application.StartupPath & "\RPT\RptEntradas.rpt")
                    CrReport.Load("C:\Users\MSISTEMAS\Desktop\Desarrollo\Respositorio_Trigo\Trigo\RPT\RptComprasXproductor.rpt")
                    CrReport.SetDataSource(ds)

                    CrComprasXproductor.ReportSource = CrReport
                Catch ex As Exception
                    MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
                End Try

            Else
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final, ni la fecha final, menor que la fecha inicial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub TxContraseña_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTFinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim RptReporteCompras As New RptComprasXproductor
                If DTInicio.Value <= DTFinal.Value And DTFinal.Value >= DTInicio.Value Then
                    'RptReporteCompras.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
                    'RptReporteCompras.SetParameterValue("@idproductor", IIf(CbProductor.SelectedValue = Nothing, "", CbProductor.SelectedValue))
                    'RptReporteCompras.SetParameterValue("@tipoContrato", IIf(CbTipoContrato.Text = Nothing, "", CbTipoContrato.Text))
                    'RptReporteCompras.SetParameterValue("@fechaini", DTInicio.Value)
                    'RptReporteCompras.SetParameterValue("@fechafin", DTFinal.Value)
                    'CrComprasXproductor.ReportSource = RptReporteCompras


                    Try
                        Dim da As New SqlCommand("sp_ReporteCompras", cnn)
                        da.CommandType = CommandType.StoredProcedure
                        Dim TipoContrato As New SqlClient.SqlParameter()
                        Dim idProductor As New SqlClient.SqlParameter()
                        Dim Fechainicial As New SqlClient.SqlParameter()
                        Dim FechaFinal As New SqlClient.SqlParameter()

                        idProductor.ParameterName = "@idproductor"
                        TipoContrato.ParameterName = "@tipoContrato"
                        Fechainicial.ParameterName = "@fechaini"
                        FechaFinal.ParameterName = "@fechafin"

                        TipoContrato.SqlDbType = SqlDbType.NVarChar
                        idProductor.SqlDbType = SqlDbType.NVarChar
                        Fechainicial.SqlDbType = SqlDbType.Date
                        FechaFinal.SqlDbType = SqlDbType.Date

                        idProductor.Value = IIf(CbProductor.SelectedValue Is Nothing, "", CbProductor.SelectedValue)
                        TipoContrato.Value = IIf(CbTipoContrato.Text Is Nothing, "", CbTipoContrato.Text)
                        Fechainicial.Value = DTInicio.Value
                        FechaFinal.Value = DTFinal.Value

                        da.Parameters.Add(TipoContrato)
                        da.Parameters.Add(idProductor)
                        da.Parameters.Add(Fechainicial)
                        da.Parameters.Add(FechaFinal)

                        Dim dasp_ReporteCompras As New SqlClient.SqlDataAdapter()
                        dasp_ReporteCompras.SelectCommand = da
                        Dim ds As New DataTable
                        dasp_ReporteCompras.Fill(ds)

                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        ' Asigno el reporte 
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        'CrReport.Load(Application.StartupPath & "\RPT\RptEntradas.rpt")
                        CrReport.Load("C:\Users\MSISTEMAS\Desktop\Desarrollo\Respositorio_Trigo\Trigo\RPT\RptComprasXproductor.rpt")
                        CrReport.SetDataSource(ds)

                        CrComprasXproductor.ReportSource = CrReport
                    Catch ex As Exception
                        MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
                    End Try

                Else
                    MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final, ni la fecha final, menor que la fecha inicial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    limpiarCampos()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class