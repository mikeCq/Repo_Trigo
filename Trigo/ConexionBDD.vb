Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class ConexionBDD
    Private Sub ConexionBDD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtNuevo_Click(sender As Object, e As EventArgs) Handles BtNuevo.Click

    End Sub

    Private Sub BtGuardar_Click(sender As Object, e As EventArgs) Handles BtGuardar.Click
        Try
            Using cmd As New SqlCommand("SELECT dbo.Fn_ObtBaseDeDatos(@USUARIO)", cnn)
                cmd.Parameters.AddWithValue("@USUARIO", "")

                TxNombreBDD.Text = CStr(cmd.ExecuteScalar())

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        Close()
    End Sub
End Class