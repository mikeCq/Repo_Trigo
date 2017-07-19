Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteBoletasEmbarque
    Private Sub ReporteBoletasEmbarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '###########################################################
        'Dim RptBoletasEmbarques As New ReporteBoletaEmbarque
        'RptBoletasEmbarques.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
        'RptBoletasEmbarques.SetParameterValue("@idembarque", ControlEmbarques.codigoEmbarque)
        'RptBoletasEmbarques.SetParameterValue("@MaizAmarillo", ControlEmbarques.MaizAmarillo)
        'RptBoletasEmbarques.SetParameterValue("@MaizBlanco", ControlEmbarques.MaizBlanco)

        'CrBoletaEmbarque.ReportSource = RptBoletasEmbarques
        '###########################################################

        Try
            Dim da As New SqlCommand("sp_ReporteBoletaEmbarque1", cnn)
            Dim Ruta As String = "\\192.168.10.30\trigo_docs\RPT\RptEntradas.rpt\RptBoletaEmbarque.rpt"
            da.CommandType = CommandType.StoredProcedure
            Dim NombreCampo As New SqlClient.SqlParameter()
            NombreCampo.ParameterName = "@idembarque"
            NombreCampo.SqlDbType = SqlDbType.NVarChar
            NombreCampo.Value = ControlEmbarques.codigoEmbarque
            da.Parameters.Add(NombreCampo)
            Dim dasp_ReporteBoletaEmbarque As New SqlClient.SqlDataAdapter()
            dasp_ReporteBoletaEmbarque.SelectCommand = da
            Dim ds As New DataTable
            dasp_ReporteBoletaEmbarque.Fill(ds)

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' Asigno el reporte 
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Ruta)
            CrReport.SetDataSource(ds)

            CrBoletaEmbarque.ReportSource = CrReport
        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
        End Try
    End Sub
End Class