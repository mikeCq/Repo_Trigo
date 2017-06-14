Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class SeleccionCentroAcopio
    Private Sub SeleccionCentroAcopio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxNombreCentro.Focus()

    End Sub
    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar.Click

    End Sub
    Private Sub cargardata()

    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()
    End Sub


End Class