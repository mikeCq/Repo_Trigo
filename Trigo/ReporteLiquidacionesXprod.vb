Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteLiquidacionesXprod
    Private Sub ReporteLiquidacionesXprod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptLiquidacionProd As New RptLiquidacionesXproductor
        Dim codigo As String = liquidacionCalculosProd.codigoLiquidacionTP
        'RptLiquidacionProd.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
        'RptLiquidacionProd.SetParameterValue("@idliquidaciontprincipal", liquidacionCalculosProd.codigoLiquidacionTP)
        'CrLiquidacionProd.ReportSource = RptLiquidacionProd

        Try
            Dim da As New SqlCommand("sp_resumenVentasLiquidadas", cnn)
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
            'CrReport.Load(Application.StartupPath & "\RPT\RptEntradas.rpt")
            CrReport.Load("C:\Users\MSISTEMAS\Desktop\Desarrollo\Respositorio_Trigo\Trigo\RPT\RptLiquidacionesXproductor.rpt")
            CrReport.SetDataSource(ds)

            CrLiquidacionProd.ReportSource = CrReport
        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
        End Try

    End Sub
End Class