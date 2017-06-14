Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class AutorizacionDiaria
    Private Sub AutorizacionDiaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        ObtenerClaveAutorizacion()
    End Sub
    Private Sub ObtenerClaveAutorizacion()
        Dim cmd As New SqlCommand("sp_SelAutorizacion", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@idusuario", VarGlob.idUsAutoriza))

        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        Dim row As DataRow = dt.Rows(0)
        TxClaveAutorizacion.Text = CStr(row("claveautorizacion"))
    End Sub
    Private Sub BtActualiza_Click(sender As Object, e As EventArgs) Handles BtActualiza.Click
        Dim cmd As New SqlCommand("sp_ActualizaClaveAutorizacion", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        ObtenerClaveAutorizacion()
    End Sub
    Private Sub Salir(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TxClaveAutorizacion.Text = ""
        VarGlob.idUsAutoriza = ""
    End Sub

End Class