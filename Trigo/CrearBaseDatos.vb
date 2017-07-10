Imports System.Data.SqlClient
Public Class CrearBaseDatos
    Public ConexionPrincipal As String '***** CONEXION A SERVIDOR PRINCIPAL 
    Private Sub CrearBaseDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        If TbNombre.Text = "" Then
            MsgBox("Ingresa un nombre para la base de datos", 1, "Aviso")
        Else
            Dim s As String = "CREATE DATABASE " & TbNombre.Text
            Dim cmd As New SqlCommand(s, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Base de datos creada con éxito", 1, "Aviso")
            cerrarPrincipal()
            ''-----CREAR TABLAS-----
            ConexionPrincipal = "Data Source=SERVER2008\SERVER12;Initial Catalog=" & TbNombre.Text & ";User ID=sa;Password=Usuario01"
            CrearTablas.CadenaConexion(ConexionPrincipal, TbNombre.Text)
            Close()
        End If
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()
    End Sub
    Private Sub Limpiar()

    End Sub
    Private Sub Cargar()
        TbNombre.Text = "TRIGO" + Now.Date.Day.ToString + Now.Date.Month.ToString + Now.Date.Year.ToString
    End Sub
End Class