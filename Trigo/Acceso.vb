Imports System.Data.SqlClient
Public Class Acceso
    Private Sub Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirmaster()
        llenaComboBDD()
    End Sub
    Private _conUsu As String
    Public Property ConUsu() As String
        Get
            Return _conUsu
        End Get
        Set(value As String)
            _conUsu = value
        End Set
    End Property

    Private _codUsuario As String
    Public Property CodUsuario() As String
        Get
            Return _codUsuario
        End Get
        Set(ByVal value As String)
            _codUsuario = value
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
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        cerrarMaster()
        _conUsu = CbBaseDatos.Text
        _baseDatos = CbBaseDatos.Text
        abrirPrincipal()
        'ConexionUsuario(conusu)
        Try
            If usuarioRegistrado(TxUsuario.Text) = True Then
                Dim contra As String = clave(TxUsuario.Text)
                If contra.Equals(TxContraseña.Text) = True Then
                    Dim Trigo As New Trigo
                    _codUsuario = TxUsuario.Text
                    Hide()
                    Trigo.ShowDialog()
                Else
                    MsgBox("Contraseña incorrecta.", MsgBoxStyle.Critical)
                    TxContraseña.Text = ""
                    TxContraseña.Select()
                End If
            Else
                MsgBox("El usuario: " + TxUsuario.Text + " no se encuentra registrado.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub TxContraseña_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            cerrarMaster()
            _conUsu = CbBaseDatos.Text
            _baseDatos = CbBaseDatos.Text
            abrirPrincipal()
            'ConexionUsuario(conusu)
            Try
                If usuarioRegistrado(TxUsuario.Text) = True Then
                    Dim contra As String = clave(TxUsuario.Text)
                    If contra.Equals(TxContraseña.Text) = True Then
                        Dim Trigo As New Trigo
                        _codUsuario = TxUsuario.Text
                        Hide()
                        Trigo.ShowDialog()
                    Else
                        MsgBox("Contraseña incorrecta.", MsgBoxStyle.Critical)
                        TxContraseña.Text = ""
                        TxContraseña.Select()
                    End If
                Else
                    MsgBox("El usuario: " + TxUsuario.Text + " no se encuentra registrado.")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
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
        End With
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CambiarContraseña.ShowDialog()
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        SqlConnection.ClearAllPools()
        Me.Close()
    End Sub

End Class
