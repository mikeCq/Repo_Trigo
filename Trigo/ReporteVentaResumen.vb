Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteVentaResumen
    Private Sub ReporteVentaResumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptResumenVentas As New RptVentaResumen
        Dim codigo As String = LiquidacionXcomprador.codigoLiquidacionVenta
        'rptResumenVentas.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
        'rptResumenVentas.SetParameterValue("@idLiquidacionResumen", codigo)
        'CrLiquidacionVentaResumen.ReportSource = rptResumenVentas
        Try
            Dim da As New SqlCommand("sp_resumenVentasLiquidadas", cnn)
            Dim Ruta As String = "\\192.168.10.30\trigo_docs\RPT\RptVentaResumen.rpt"
            da.CommandType = CommandType.StoredProcedure
            Dim IdLiquidacionResumen As New SqlClient.SqlParameter()


            IdLiquidacionResumen.ParameterName = "@idLiquidacionResumen"


            IdLiquidacionResumen.SqlDbType = SqlDbType.NVarChar


            IdLiquidacionResumen.Value = codigo


            da.Parameters.Add(IdLiquidacionResumen)


            Dim dasp_resumenVentasLiquidadas As New SqlClient.SqlDataAdapter()
            dasp_resumenVentasLiquidadas.SelectCommand = da
            Dim ds As New DataTable
            dasp_resumenVentasLiquidadas.Fill(ds)

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' Asigno el reporte 
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Ruta)
            'CrReport.Load("C:\Users\MSISTEMAS\Desktop\Desarrollo\Respositorio_Trigo\Trigo\RPT\RptVentaResumen.rpt")
            CrReport.SetDataSource(ds)

            CrLiquidacionVentaResumen.ReportSource = CrReport
        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
        End Try
    End Sub
End Class