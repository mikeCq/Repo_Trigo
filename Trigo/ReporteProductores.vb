Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteProductores
    Private Sub ReporteProductores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CRentradas.ReportSource = Nothing
        CRentradas.Refresh()
        TxNumBoleta.Select()
        limpiarCampos()
        llenarCombos()
    End Sub
    Private Sub llenarCombos()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim cmdllenaCbPro As SqlCommand

        cmdllenaCbPro = New SqlCommand("Sp_CbProductorEntradasReporte")
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
        TxNumBoleta.Text = ""
        CbProductor.Text = ""
        CbProductor.SelectedIndex = -1
        DTInicio.Value = "01/01/1900"
        DTFinal.Value = "01/01/1900"
    End Sub
    Private Sub generaReporte(sender As Object, e As EventArgs) Handles BtGenerarReporte.Click
        Try
            If DTInicio.Value <= DTFinal.Value And DTFinal.Value >= DTInicio.Value Then
                'RptEntradas.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
                'RptEntradas.SetParameterValue("@numboleta", TxNumBoleta.Text)
                'RptEntradas.SetParameterValue("@productor", IIf(CbProductor.SelectedValue = Nothing, "", CbProductor.SelectedValue))
                'RptEntradas.SetParameterValue("@fechaini", DTInicio.Value)
                'RptEntradas.SetParameterValue("@fechafin", DTFinal.Value)
                'CRentradas.ReportSource = RptEntradas
                Try
                    Dim da As New SqlCommand("SP_REPORTEENTRADAS", cnn)
                    da.CommandType = CommandType.StoredProcedure
                    Dim NumBoleta As New SqlClient.SqlParameter()
                    Dim idProductor As New SqlClient.SqlParameter()
                    Dim Fechainicial As New SqlClient.SqlParameter()
                    Dim FechaFinal As New SqlClient.SqlParameter()

                    NumBoleta.ParameterName = "@numBoleta"
                    idProductor.ParameterName = "@productor"
                    Fechainicial.ParameterName = "@fechaini"
                    FechaFinal.ParameterName = "@fechafin"

                    NumBoleta.SqlDbType = SqlDbType.NVarChar
                    idProductor.SqlDbType = SqlDbType.NVarChar
                    Fechainicial.SqlDbType = SqlDbType.Date
                    FechaFinal.SqlDbType = SqlDbType.Date

                    NumBoleta.Value = TxNumBoleta.Text
                    idProductor.Value = CbProductor.Text
                    Fechainicial.Value = DTInicio.Value
                    FechaFinal.Value = DTFinal.Value

                    da.Parameters.Add(NumBoleta)
                    da.Parameters.Add(idProductor)
                    da.Parameters.Add(Fechainicial)
                    da.Parameters.Add(FechaFinal)

                    Dim dasp_ReporteEntradas As New SqlClient.SqlDataAdapter()
                    dasp_ReporteEntradas.SelectCommand = da
                    Dim ds As New DataTable
                    dasp_ReporteEntradas.Fill(ds)

                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    ' Asigno el reporte 
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    'CrReport.Load(Application.StartupPath & "\RPT\RptEntradas.rpt")
                    CrReport.Load("C:\Users\MSISTEMAS\Desktop\Desarrollo\Respositorio_Trigo\Trigo\RPT\RptEntradas.rpt")
                    CrReport.SetDataSource(ds)

                    CRentradas.ReportSource = CrReport
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
    Private Sub TxContraseña_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxNumBoleta.KeyDown, DTFinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If DTInicio.Value <= DTFinal.Value And DTFinal.Value >= DTInicio.Value Then
                    'RptEntradas.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
                    'RptEntradas.SetParameterValue("@numboleta", TxNumBoleta.Text)
                    'RptEntradas.SetParameterValue("@productor", IIf(CbProductor.SelectedValue = Nothing, "", CbProductor.SelectedValue))
                    'RptEntradas.SetParameterValue("@fechaini", DTInicio.Value)
                    'RptEntradas.SetParameterValue("@fechafin", DTFinal.Value)
                    'CRentradas.ReportSource = RptEntradas

                    Try
                        Dim da As New SqlCommand("SP_REPORTEENTRADAS", cnn)
                        da.CommandType = CommandType.StoredProcedure
                        Dim NumBoleta As New SqlClient.SqlParameter()
                        Dim idProductor As New SqlClient.SqlParameter()
                        Dim Fechainicial As New SqlClient.SqlParameter()
                        Dim FechaFinal As New SqlClient.SqlParameter()

                        NumBoleta.ParameterName = "@numBoleta"
                        idProductor.ParameterName = "@productor"
                        Fechainicial.ParameterName = "@fechaini"
                        FechaFinal.ParameterName = "@fechafin"

                        NumBoleta.SqlDbType = SqlDbType.NVarChar
                        idProductor.SqlDbType = SqlDbType.NVarChar
                        Fechainicial.SqlDbType = SqlDbType.Date
                        FechaFinal.SqlDbType = SqlDbType.Date

                        NumBoleta.Value = TxNumBoleta.Text
                        idProductor.Value = CbProductor.Text
                        Fechainicial.Value = DTInicio.Value
                        FechaFinal.Value = DTFinal.Value

                        da.Parameters.Add(NumBoleta)
                        da.Parameters.Add(idProductor)
                        da.Parameters.Add(Fechainicial)
                        da.Parameters.Add(FechaFinal)

                        Dim dasp_ReporteEntradas As New SqlClient.SqlDataAdapter()
                        dasp_ReporteEntradas.SelectCommand = da
                        Dim ds As New DataTable
                        dasp_ReporteEntradas.Fill(ds)

                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        ' Asigno el reporte 
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        'CrReport.Load(Application.StartupPath & "\RPT\RptEntradas.rpt")
                        CrReport.Load("C:\Users\MSISTEMAS\Desktop\Desarrollo\Respositorio_Trigo\Trigo\RPT\RptEntradas.rpt")
                        CrReport.SetDataSource(ds)

                        CRentradas.ReportSource = CrReport
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