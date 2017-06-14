Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteVentaResumen
    Private Sub ReporteVentaResumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptResumenVentas As New RptVentaResumen
        Dim codigo As String = LiquidacionXcomprador.codigoLiquidacionVenta
        rptResumenVentas.SetDatabaseLogon(VarGlob.UserDB, VarGlob.PasswordDB, VarGlob.ServerDB, VarGlob.DataBase)
        rptResumenVentas.SetParameterValue("@idLiquidacionResumen", codigo)
        CrLiquidacionVentaResumen.ReportSource = rptResumenVentas
    End Sub
End Class