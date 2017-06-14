Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReportesSalidas
    Private Sub ReportesSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CRSalidas.ReportSource = Nothing
        CRsalidas.Refresh()
        TxNumBoleta.Select()
        limpiarCampos()
        llenarCombos()
    End Sub
    Private Sub llenarCombos()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim cmdllenaCbPro As SqlCommand

        cmdllenaCbPro = New SqlCommand("Sp_CbCompradoresConContratoSalidas")
        cmdllenaCbPro.CommandType = CommandType.StoredProcedure
        cmdllenaCbPro.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbPro)
        ds = New DataSet()
        da.Fill(ds)
        CbComprador.DataSource = ds.Tables(0)
        CbComprador.DisplayMember = "Nombre_Comprador"
        CbComprador.ValueMember = "Id_ContratoV"
        CbComprador.SelectedIndex = -1
    End Sub
    Private Sub limpiarCampos() Handles Btlimpiar.Click
        TxNumBoleta.Text = ""
        DTInicio.Value = "01/01/1900"
        DTFinal.Value = "01/01/1900"
        CbComprador.SelectedIndex = -1
        CbComprador.Text = ""
        TxNumBoleta.Select()
    End Sub
    Private Sub generaReporte(sender As Object, e As EventArgs) Handles BtGenerarReporte.Click
        Dim RptSalidas As New ReporteSalidas
        If DTInicio.Value <= DTFinal.Value And DTFinal.Value >= DTInicio.Value Then
            RptSalidas.SetDatabaseLogon(VarGlob.UserDB, VarGlob.PasswordDB, VarGlob.ServerDB, VarGlob.DataBase)
            RptSalidas.SetParameterValue("@numboleta", TxNumBoleta.Text)
            RptSalidas.SetParameterValue("@comprador", IIf(CbComprador.SelectedValue = Nothing, "", CbComprador.SelectedValue))
            RptSalidas.SetParameterValue("@fechaini", DTInicio.Value)
            RptSalidas.SetParameterValue("@fechafin", DTFinal.Value)
            CRsalidas.ReportSource = RptSalidas
        Else
            MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final, ni la fecha final, menor que la fecha inicial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            limpiarCampos()
        End If
    End Sub
    Private Sub TxContraseña_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxNumBoleta.KeyDown, DTFinal.KeyDown, CbComprador.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim RptSalidas As New ReporteSalidas
                If DTInicio.Value <= DTFinal.Value And DTFinal.Value >= DTInicio.Value Then
                    RptSalidas.SetDatabaseLogon(VarGlob.UserDB, VarGlob.PasswordDB, VarGlob.ServerDB, VarGlob.DataBase)
                    RptSalidas.SetParameterValue("@numboleta", TxNumBoleta.Text)
                    RptSalidas.SetParameterValue("@comprador", IIf(CbComprador.SelectedValue = Nothing, "", CbComprador.SelectedValue))
                    RptSalidas.SetParameterValue("@fechaini", DTInicio.Value)
                    RptSalidas.SetParameterValue("@fechafin", DTFinal.Value)
                    CRsalidas.ReportSource = RptSalidas
                Else
                    MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final, ni la fecha final, menor que la fecha inicial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    limpiarCampos()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class