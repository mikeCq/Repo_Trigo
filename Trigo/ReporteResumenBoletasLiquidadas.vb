Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class ReporteResumenBoletasLiquidadas
    Private Sub ReporteResumenBoletasLiquidadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptBoletasLiq As New ReporteLiquidacionResumen
        Dim codigo As String = liquidacionCalculosProd.codigoLiquidacionTP
        RptBoletasLiq.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
        RptBoletasLiq.SetParameterValue("@idliquidacionTotal", codigo)
        CrResumenBoletas.ReportSource = RptBoletasLiq
    End Sub
End Class