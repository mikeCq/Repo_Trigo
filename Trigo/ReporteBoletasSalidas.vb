Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteBoletasSalidas
    Private Sub ReporteBoletasSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptBoletasSalidas As New ReporteBoletaSalida
        RptBoletasSalidas.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
        RptBoletasSalidas.SetParameterValue("@idsalida", ControlSalidas.codigoSalida)
        RptBoletasSalidas.SetParameterValue("@MaizAmarillo", ControlSalidas.Cachanilla)
        RptBoletasSalidas.SetParameterValue("@MaizBlanco", ControlSalidas.Cristalino)

        CrBoletaSalida.ReportSource = RptBoletasSalidas
    End Sub
End Class