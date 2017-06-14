Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class BuscarTierras
    Private Sub BuscarTierras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private _numeroLote As String
    Public Property NumeroLote() As String
        Get
            Return _numeroLote
        End Get
        Set(ByVal value As String)
            _numeroLote = value
        End Set
    End Property
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        Dim cmd As New SqlCommand("Sp_buscarTierra", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@numerolote", TxNumeroLote.Text)
        cmd.Parameters.AddWithValue("@foliolote", TxFolioLote.Text)


        cmd.ExecuteNonQuery()

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable

        da.Fill(dt)

        DgBuscar.DataSource = dt
    End Sub
    Private Sub buscarEntrer(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxFolioLote.KeyDown, TxNumeroLote.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim cmd As New SqlCommand("Sp_buscarTierra", cnn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@numerolote", TxNumeroLote.Text)
                cmd.Parameters.AddWithValue("@foliolote", TxFolioLote.Text)


                cmd.ExecuteNonQuery()

                Dim da As New SqlDataAdapter(cmd)

                Dim dt As New DataTable

                da.Fill(dt)

                DgBuscar.DataSource = dt
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar.Click, DgBuscar.DoubleClick
        If DgBuscar.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgBuscar Is Nothing Then
            _numeroLote = CStr(DgBuscar.CurrentRow.Cells(0).Value)
            Close()
        End If
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()
    End Sub
End Class