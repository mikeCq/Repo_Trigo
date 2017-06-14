Imports System.Data.SqlClient
Public Class ReporteEstatusContrato
    Private Sub ReporteEstatusContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombos()
        CREstatusContrato.ReportSource = Nothing
        CREstatusContrato.Refresh()
    End Sub
    Private Sub BtGenerarReporte_Click(sender As Object, e As EventArgs) Handles BtGenerarReporte.Click
        Dim RPTEstatusContrato As New RPTEstatusContrato
        If CBEstatusContrato.Text = "" Then
            MessageBox.Show("Seleccione un estatus.", "Aviso")
        Else
            RPTEstatusContrato.SetDatabaseLogon(VarGlob.UserDB, VarGlob.PasswordDB, VarGlob.ServerDB, VarGlob.DataBase)
            'RPTEstatusContrato.SetParameterValue("@IdCliente", IIf(CBComprador.SelectedValue = Nothing, "", CBEstatusContrato.SelectedValue))
            RPTEstatusContrato.SetParameterValue("@IdEstatus", CBEstatusContrato.SelectedValue)
            CREstatusContrato.ReportSource = RPTEstatusContrato
        End If

    End Sub
    Private Sub llenarCombos()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        'Dim cmdllenaCbPro As SqlCommand
        'cmdllenaCbPro = New SqlCommand("sp_NombreClientes")
        'cmdllenaCbPro.CommandType = CommandType.StoredProcedure
        'cmdllenaCbPro.Connection = cnn
        'da = New SqlDataAdapter(cmdllenaCbPro)
        'ds = New DataSet()
        'da.Fill(ds)
        'CBComprador.DataSource = ds.Tables(0)
        'CBComprador.DisplayMember = "Nombre"
        'CBComprador.ValueMember = "Id_Cliente"
        'CBComprador.SelectedIndex = -1

        Dim cmdllenaEstatus As SqlCommand
        cmdllenaEstatus = New SqlCommand("SP_CBESTATUS")
        cmdllenaEstatus.CommandType = CommandType.StoredProcedure
        cmdllenaEstatus.Connection = cnn
        da = New SqlDataAdapter(cmdllenaEstatus)
        ds = New DataSet()
        da.Fill(ds)
        CBEstatusContrato.DataSource = ds.Tables(0)
        CBEstatusContrato.DisplayMember = "ESTATUS"
        CBEstatusContrato.ValueMember = "ID"
        CBEstatusContrato.SelectedIndex = -1
    End Sub

    Private Sub Btlimpiar_Click(sender As Object, e As EventArgs) Handles Btlimpiar.Click
        CBEstatusContrato.Text = ""
        CBEstatusContrato.SelectedIndex = -1
        CREstatusContrato.ReportSource = Nothing
        CREstatusContrato.Refresh()
    End Sub

End Class