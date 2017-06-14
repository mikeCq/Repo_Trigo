Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteBoletasEntradas
    Private Sub ReporteBoletasEntradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptBoletasEntradas As New ReporteBoletaEntrada
        RptBoletasEntradas.SetDatabaseLogon(VarGlob.UserDB, VarGlob.PasswordDB, VarGlob.ServerDB, VarGlob.DataBase)
        RptBoletasEntradas.SetParameterValue("@identrada", ControlEntradas.codigoEntrada)
        RptBoletasEntradas.SetParameterValue("@MaizAmarillo", ControlEntradas.MaizAmarillo)
        RptBoletasEntradas.SetParameterValue("@MaizBlanco", ControlEntradas.MaizBlanco)

        CrBoletaEntrada.ReportSource = RptBoletasEntradas

    End Sub
End Class