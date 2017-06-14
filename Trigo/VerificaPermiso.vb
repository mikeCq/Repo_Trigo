Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class VerificaPermiso
    Private _autorizacionCorrecta As Boolean = False
    Public Property AutorizacionCorrecta As Boolean
        Get
            Return _autorizacionCorrecta
        End Get
        Set(value As Boolean)
            _autorizacionCorrecta = value
        End Set
    End Property
    Private Sub VerificaPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxClaveAutorizacion.Select()
        Dim mensajeParametrosAnalisis As Object = ControlEntradas.MensajeParametrosAnalisis
        LbMensaje.Text = mensajeParametrosAnalisis
    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()
    End Sub
    Private Sub BtAutorizacion_Click(sender As Object, e As EventArgs) Handles BtAutorizacion.Click
        Try
            If claveAutorizacion(TxClaveAutorizacion.Text) = True Then

                _autorizacionCorrecta = True
                Me.Close()

            Else
                MsgBox("Clave Incorrecta.")
                TxClaveAutorizacion.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub BtAutorizacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxClaveAutorizacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If claveAutorizacion(TxClaveAutorizacion.Text) = True Then

                    _autorizacionCorrecta = True
                    Me.Close()

                Else
                    MsgBox("Clave Incorrecta.")
                    TxClaveAutorizacion.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

End Class