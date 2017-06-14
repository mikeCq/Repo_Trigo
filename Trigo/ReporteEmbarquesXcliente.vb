Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class ReporteEmbarquesXcliente
    Private Sub ReportesEmbarques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CREmbarques.ReportSource = Nothing
        CREmbarques.Refresh()
        llenarCombos()
    End Sub
    Private Sub llenarCombos()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim cmdllenaCbPro As SqlCommand

        cmdllenaCbPro = New SqlCommand("Sp_CbPropietarioEntradas")
        cmdllenaCbPro.CommandType = CommandType.StoredProcedure
        cmdllenaCbPro.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbPro)
        ds = New DataSet()
        da.Fill(ds)
        CbProductor.DataSource = ds.Tables(0)
        CbProductor.DisplayMember = "nombreProductor"
        CbProductor.ValueMember = "Id_cliente"
        CbProductor.SelectedIndex = -1
    End Sub
    Private Sub limpiarCampos() Handles Btlimpiar.Click
        TxNumBoleta.Text = ""
        CbProductor.SelectedIndex = -1
        CbProductor.Text = ""
        DTInicio.Value = "01/01/1900"
        DTFinal.Value = "01/01/1900"
        TxNumBoleta.Select()
    End Sub
    Private Sub generaReporte(sender As Object, e As EventArgs) Handles BtGenerarReporte.Click
        Try
            Dim RptEmbarques As New ReporteEmbarques
            If DTInicio.Value <= DTFinal.Value And DTFinal.Value >= DTInicio.Value Then
                RptEmbarques.SetDatabaseLogon(VarGlob.UserDB, VarGlob.PasswordDB, VarGlob.ServerDB, VarGlob.DataBase)
                RptEmbarques.SetParameterValue("@numboleta", TxNumBoleta.Text)
                RptEmbarques.SetParameterValue("@productor", IIf(CbProductor.SelectedValue = Nothing, "", CbProductor.SelectedValue))
                RptEmbarques.SetParameterValue("@fechaini", DTInicio.Value)
                RptEmbarques.SetParameterValue("@fechafin", DTFinal.Value)
                CREmbarques.ReportSource = RptEmbarques
            Else
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final, ni la fecha final, menor que la fecha inicial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub TxContraseña_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxNumBoleta.KeyDown, DTFinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim RptEmbarques As New ReporteEmbarques
                If DTInicio.Value <= DTFinal.Value And DTFinal.Value >= DTInicio.Value Then
                    RptEmbarques.SetDatabaseLogon(VarGlob.UserDB, VarGlob.PasswordDB, VarGlob.ServerDB, VarGlob.DataBase)
                    RptEmbarques.SetParameterValue("@numboleta", TxNumBoleta.Text)
                    RptEmbarques.SetParameterValue("@productor", IIf(CbProductor.SelectedValue = Nothing, "", CbProductor.SelectedValue))
                    RptEmbarques.SetParameterValue("@fechaini", DTInicio.Value)
                    RptEmbarques.SetParameterValue("@fechafin", DTFinal.Value)
                    CREmbarques.ReportSource = RptEmbarques
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