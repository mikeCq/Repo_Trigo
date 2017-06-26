﻿Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteBoletasEntradas
    Private Sub ReporteBoletasEntradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptBoletasEntradas As New ReporteBoletaEntrada
        RptBoletasEntradas.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
        RptBoletasEntradas.SetParameterValue("@identrada", ControlEntradas.codigoEntrada)
        CrBoletaEntrada.ReportSource = RptBoletasEntradas
    End Sub
End Class