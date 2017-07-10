Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteBoletasSalidas
    Private Sub ReporteBoletasSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim RptBoletasSalidas As New ReporteBoletaSalida
        'RptBoletasSalidas.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
        'RptBoletasSalidas.SetParameterValue("@idsalida", ControlSalidas.codigoSalida)
        'RptBoletasSalidas.SetParameterValue("@MaizAmarillo", ControlSalidas.Cachanilla)
        'RptBoletasSalidas.SetParameterValue("@MaizBlanco", ControlSalidas.Cristalino)

        'CrBoletaSalida.ReportSource = RptBoletasSalidas

        Try
            Dim da As New SqlCommand("sp_ReporteBoletaSalida1", cnn)
            da.CommandType = CommandType.StoredProcedure
            Dim NombreCampo As New SqlClient.SqlParameter()
            NombreCampo.ParameterName = "@idsalida"
            NombreCampo.SqlDbType = SqlDbType.NVarChar
            NombreCampo.Value = ControlSalidas.codigoSalida
            da.Parameters.Add(NombreCampo)
            Dim dasp_ReporteBoletaSalida As New SqlClient.SqlDataAdapter()
            dasp_ReporteBoletaSalida.SelectCommand = da
            Dim ds As New DataTable
            dasp_ReporteBoletaSalida.Fill(ds)

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' Asigno el reporte 
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\RPT\RptBoletaSalida.rpt")
            CrReport.SetDataSource(ds)

            CrBoletaSalida.ReportSource = CrReport
        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
        End Try
    End Sub
End Class