Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteResumenBoletasLiquidadas
    Private Sub ReporteResumenBoletasLiquidadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptBoletasLiq As New RptLiquidacionResumen
        Dim codigo As String = liquidacionCalculosProd.codigoLiquidacionTP
        'RptBoletasLiq.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
        'RptBoletasLiq.SetParameterValue("@idliquidacionTotal", codigo)
        'CrResumenBoletas.ReportSource = RptBoletasLiq

        Try
            Dim da As New SqlCommand("sp_resumenBoletasLiquidadas", cnn)
            da.CommandType = CommandType.StoredProcedure
            Dim IdLiquidacionTotal As New SqlClient.SqlParameter()


            IdLiquidacionTotal.ParameterName = "@idLiquidacionTotal"


            IdLiquidacionTotal.SqlDbType = SqlDbType.NVarChar


            IdLiquidacionTotal.Value = codigo


            da.Parameters.Add(IdLiquidacionTotal)


            Dim dasp_resumenBoletasLiquidadas As New SqlClient.SqlDataAdapter()
            dasp_resumenBoletasLiquidadas.SelectCommand = da
            Dim ds As New DataTable
            dasp_resumenBoletasLiquidadas.Fill(ds)

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' Asigno el reporte 
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\RPT\RptLiquidacionResumen.rpt")
            'CrReport.Load("C:\Users\MSISTEMAS\Desktop\Desarrollo\Respositorio_Trigo\Trigo\RPT\RptLiquidacionResumen.rpt")
            CrReport.SetDataSource(ds)

            CrResumenBoletas.ReportSource = CrReport
        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
        End Try

    End Sub
End Class