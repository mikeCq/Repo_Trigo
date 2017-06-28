Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class ConexionBDD
    Private _conUsu As String
    Public Property ConUsu() As String
        Get
            Return _conUsu
        End Get
        Set(value As String)
            _conUsu = value
        End Set
    End Property
    Private _baseDatos As String
    Public Property BaseDatos() As String
        Get
            Return _baseDatos
        End Get
        Set(value As String)
            _baseDatos = value
        End Set
    End Property
    Private Sub ConexionBDD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cerrarPrincipal()
        abrirmaster()
        llenaComboBDD()
    End Sub
    Private Sub BtNuevo_Click(sender As Object, e As EventArgs) Handles BtNuevo.Click

    End Sub
    Private Sub BtGuardar_Click(sender As Object, e As EventArgs) Handles BtGuardar.Click
        cerrarMaster()
        _conUsu = CbBaseDatos.Text
        _baseDatos = CbBaseDatos.Text
        abrirPrincipal()
        MsgBox("Se ha cambiado la base de datos " & CbBaseDatos.Text & " con éxito!")
        Me.Close()
        'Try
        '    Using cmd As New SqlCommand("SELECT dbo.Fn_ObtBaseDeDatos(@USUARIO)", cnn)
        '        cmd.Parameters.AddWithValue("@USUARIO", "")

        '        TxNombreBDD.Text = CStr(cmd.ExecuteScalar())

        '    End Using
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub llenaComboBDD()
        Dim cmd As String = "SELECT name, database_id FROM sys.databases where name like '%'+'TRIGO'+'%'"
        Dim da As New SqlDataAdapter(cmd, cnnMaster)
        Dim ds As New DataSet
        da.Fill(ds)
        With Me.CbBaseDatos
            Me.CbBaseDatos.DataSource = ds.Tables(0)
            Me.CbBaseDatos.DisplayMember = "name"
            Me.CbBaseDatos.ValueMember = "database_id"
            Me.CbBaseDatos.SelectedIndex = CbBaseDatos.Items.Count - 1
        End With
    End Sub
    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        Close()
    End Sub
End Class