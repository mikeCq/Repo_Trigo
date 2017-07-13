Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteVentas
    Private Sub ReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptReporteVentas As New RptVentaXcomprador
        Dim codigo As String = LiquidacionXcomprador.codigoLiquidacionVenta
        'rptReporteVentas.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
        'rptReporteVentas.SetParameterValue("@idliquidacionVenta", codigo)
        'CrLiquidacionVenta.ReportSource = rptReporteVentas

        Try
            Dim da As New SqlCommand("sp_reporteVentaLiquidacion", cnn)
            da.CommandType = CommandType.StoredProcedure
            Dim IdLiquidacionVenta As New SqlClient.SqlParameter()


            IdLiquidacionVenta.ParameterName = "@IdLiquidacionVenta"


            IdLiquidacionVenta.SqlDbType = SqlDbType.NVarChar


            IdLiquidacionVenta.Value = codigo


            da.Parameters.Add(IdLiquidacionVenta)


            Dim dasp_reporteVentaLiquidacion As New SqlClient.SqlDataAdapter()
            dasp_reporteVentaLiquidacion.SelectCommand = da
            Dim ds As New DataTable
            dasp_reporteVentaLiquidacion.Fill(ds)

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' Asigno el reporte 
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\RPT\RptVentaXcomprador.rpt")
            'CrReport.Load("C:\Users\MSISTEMAS\Desktop\Desarrollo\Respositorio_Trigo\Trigo\RPT\RptVentaXcomprador.rpt")
            CrReport.SetDataSource(ds)

            CrLiquidacionVenta.ReportSource = CrReport
        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
        End Try

    End Sub
End Class