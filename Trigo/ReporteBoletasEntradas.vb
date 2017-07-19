Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteBoletasEntradas
    Private Sub ReporteBoletasEntradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '#####################################################################
        'Dim RptBoletasEntradas As New ReporteBoletaEntrada
        'RptBoletasEntradas.SetDatabaseLogon(VarGlob1.UserDB, VarGlob1.PasswordDB, VarGlob1.ServerDB, VarGlob1.DataBase)
        'RptBoletasEntradas.SetParameterValue("@identrada", ControlEntradas.codigoEntrada)
        'CrBoletaEntrada.ReportSource = RptBoletasEntradas
        'Dim daDatos As New OleDbDataAdapter
        'Dim dtDatos As New DataTable
        'Try
        '    Dim cmd As New SqlCommand("sp_ReporteBoletaEntrada1", cnn)

        '    cmd.CommandType = CommandType.StoredProcedure

        '    cmd.Parameters.AddWithValue("@idusuario", generaCodigoUsuario(idusuario))

        '    cmd.ExecuteNonQuery()
        '    da
        'Catch ex As Exception
        '    MsgBox("Error.", MsgBoxStyle.Critical)
        'End Try
        '####################################################################

        Try
            Dim da As New SqlCommand("sp_ReporteBoletaEntrada1", cnn)
            Dim Ruta As String = "\\192.168.10.30\trigo_docs\RPT\RptBoletaEntrada.rpt"
            da.CommandType = CommandType.StoredProcedure
            Dim NombreCampo As New SqlClient.SqlParameter()
            NombreCampo.ParameterName = "@identrada"
            NombreCampo.SqlDbType = SqlDbType.NVarChar
            NombreCampo.Value = ControlEntradas.codigoEntrada
            da.Parameters.Add(NombreCampo)
            Dim dasp_ReporteBoletaEntrada1 As New SqlClient.SqlDataAdapter()
            dasp_ReporteBoletaEntrada1.SelectCommand = da
            Dim ds As New DataTable
            dasp_ReporteBoletaEntrada1.Fill(ds)

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' Asigno el reporte 
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Ruta)
            CrReport.SetDataSource(ds)

            CrBoletaEntrada.ReportSource = CrReport
        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
        End Try

    End Sub
End Class