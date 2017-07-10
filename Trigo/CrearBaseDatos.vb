Imports System.Data.SqlClient
Public Class CrearBaseDatos
    Private Sub CrearBaseDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbNombre.Text = ""
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click

        MsgBox("CREATE DATABASE '" & "TRIGO" & Year(Now) & "'")
        'Try
        '    consulta = New SqlCommand("CREATE DATABASE'" & "TRIGO" & Year(Now) & "'", cnn)
        '    respuesta = consulta.ExecuteReader
        '    respuesta.Close()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try


        'If TbNombre.Text = "" Then
        '    MsgBox("Ingresa un nombre para la base de datos", 1, "Aviso")
        'Else
        '    cerrarPrincipal()
        '    abrirmaster()
        '    Dim cmd As New SqlCommand("sp_CrearBaseDatos", cnnMaster)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.AddWithValue("@NombreBDD", TbNombre.Text)
        '    cmd.ExecuteNonQuery()
        '    MsgBox("Base de datos creada con exito", 1, "Aviso")
        '    cerrarMaster()
        '    abrirPrincipal()
        'End If
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()
    End Sub
End Class