Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteBoletasSalidas
    Private Sub ReporteBoletasSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptBoletasSalidas As New ReporteBoletaSalida
        RptBoletasSalidas.SetDatabaseLogon(VarGlob.UserDB, VarGlob.PasswordDB, VarGlob.ServerDB, VarGlob.DataBase)
        RptBoletasSalidas.SetParameterValue("@idsalida", ControlSalidas.codigoSalida)
        RptBoletasSalidas.SetParameterValue("@MaizAmarillo", ControlSalidas.MaizAmarillo)
        RptBoletasSalidas.SetParameterValue("@MaizBlanco", ControlSalidas.MaizBlanco)

        CrBoletaSalida.ReportSource = RptBoletasSalidas
    End Sub
End Class