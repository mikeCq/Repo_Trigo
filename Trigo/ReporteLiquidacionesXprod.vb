Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class ReporteLiquidacionesXprod
    Private Sub ReporteLiquidacionesXprod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptLiquidacionProd As New ReporteLiquidacionesXproductor
        Dim codigo As String = liquidacionCalculosProd.codigoLiquidacionTP
        RptLiquidacionProd.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
        RptLiquidacionProd.SetParameterValue("@idliquidaciontprincipal", liquidacionCalculosProd.codigoLiquidacionTP)
        CrLiquidacionProd.ReportSource = RptLiquidacionProd
    End Sub

End Class