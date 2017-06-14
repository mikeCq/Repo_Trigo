Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class CambiarContraseña
    Private Sub CambiarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiaControles()
    End Sub
    Private Sub limpiaControles()
        BtCorrecto.Visible = False
        BtIncorrecto.Visible = False
        TxConfirmaContra.Text = ""
        TxContraseña.Text = ""
        TxNuevaContra.Text = ""
        TxUsuario.Text = ""
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        Try
            If usuarioRegistrado(TxUsuario.Text) = True Then
                Dim contra As String = clave(TxUsuario.Text)
                If contra.Equals(TxContraseña.Text) = True And TxNuevaContra.Text = TxConfirmaContra.Text Then

                    Dim cmd As New SqlCommand("sp_ActPasswordUsuario", cnn)

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@Usuario", TxUsuario.Text)
                    cmd.Parameters.AddWithValue("@Password", TxConfirmaContra.Text)

                    cmd.ExecuteNonQuery()

                    MsgBox("La contraseña del usuario " + TxUsuario.Text + " se ha modificado con exíto.")
                    Me.Close()
                ElseIf contra.Equals(TxContraseña.Text) = True And TxNuevaContra.Text <> TxConfirmaContra.Text Then
                    MsgBox("Las nuevas contraseñas no coinciden.", MsgBoxStyle.Critical)
                    TxNuevaContra.Text = ""
                    TxConfirmaContra.Text = ""
                    TxNuevaContra.Select()
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
    Private Sub verificaContraseña(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxConfirmaContra.KeyPress
        If TxConfirmaContra.Text = TxNuevaContra.Text Then
            BtCorrecto.Visible = True
            BtIncorrecto.Visible = False
        ElseIf TxConfirmaContra.Text <> TxNuevaContra.Text Then
            BtCorrecto.Visible = False
            BtIncorrecto.Visible = True
        End If
    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Me.Close()
    End Sub
End Class