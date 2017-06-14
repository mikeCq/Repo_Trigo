Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class ReporteResumenBoletasLiquidadas
    Private Sub ReporteResumenBoletasLiquidadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptBoletasLiq As New ReporteLiquidacionResumen
        Dim codigo As String = liquidacionCalculosProd.codigoLiquidacionTP
        RptBoletasLiq.SetDatabaseLogon(VarGlob.UserDB, VarGlob.PasswordDB, VarGlob.ServerDB, VarGlob.DataBase)
        RptBoletasLiq.SetParameterValue("@idliquidacionTotal", codigo)
        CrResumenBoletas.ReportSource = RptBoletasLiq
    End Sub
End Class