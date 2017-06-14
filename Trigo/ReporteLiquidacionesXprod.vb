Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class ReporteLiquidacionesXprod
    Private Sub ReporteLiquidacionesXprod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptLiquidacionProd As New ReporteLiquidacionesXproductor
        Dim codigo As String = liquidacionCalculosProd.codigoLiquidacionTP
        RptLiquidacionProd.SetDatabaseLogon(VarGlob.UserDB, VarGlob.PasswordDB, VarGlob.ServerDB, VarGlob.DataBase)
        RptLiquidacionProd.SetParameterValue("@idliquidaciontprincipal", liquidacionCalculosProd.codigoLiquidacionTP)
        CrLiquidacionProd.ReportSource = RptLiquidacionProd
    End Sub

End Class