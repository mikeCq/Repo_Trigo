Imports System.Data.SqlClient
Public Class Acceso
    Private Sub Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()

    End Sub

    Private _codUsuario As String
    Public Property CodUsuario() As String
        Get
            Return _codUsuario
        End Get
        Set(ByVal value As String)
            _codUsuario = value
        End Set
    End Property
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If usuarioRegistrado(TxUsuario.Text) = True Then
                Dim contra As String = clave(TxUsuario.Text)
                If contra.Equals(TxContraseña.Text) = True Then
                    Dim Maiz As New Trigo
                    _codUsuario = TxUsuario.Text
                    Hide()
                    Maiz.ShowDialog()
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
            Try
                If usuarioRegistrado(TxUsuario.Text) = True Then
                    Dim contra As String = clave(TxUsuario.Text)
                    If contra.Equals(TxContraseña.Text) = True Then
                        Dim Maiz As New Trigo
                        _codUsuario = TxUsuario.Text
                        Hide()
                        Maiz.ShowDialog()
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
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CambiarContraseña.ShowDialog()
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        SqlConnection.ClearAllPools()
        Me.Close()
    End Sub

End Class
