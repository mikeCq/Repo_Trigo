Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteVentas
    Private Sub ReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptReporteVentas As New RptVentaXcomprador
        Dim codigo As String = LiquidacionXcomprador.codigoLiquidacionVenta
        rptReporteVentas.SetDatabaseLogon(VarGlob.UserDB, VarGlob.PasswordDB, VarGlob.ServerDB, VarGlob.DataBase)
        rptReporteVentas.SetParameterValue("@idliquidacionVenta", codigo)
        CrLiquidacionVenta.ReportSource = rptReporteVentas
    End Sub
End Class