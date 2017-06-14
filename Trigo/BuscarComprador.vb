Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class BuscarComprador
    Private Sub BuscarComprador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxNomBus.Select()
    End Sub
    Private _codigoComprador As String
    Public Property CodigoComprador() As String
        Get
            Return _codigoComprador
        End Get
        Set(ByVal value As String)
            _codigoComprador = value
        End Set
    End Property
    Private Sub BtSeleccionComprador_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click

        Dim cmd As New SqlCommand("Sp_buscarCom", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@nombre", TxNomBus.Text)

            cmd.ExecuteNonQuery()

            Dim da As New SqlDataAdapter(cmd)

            Dim dt As New DataTable

            da.Fill(dt)

            DgBuscar.DataSource = dt

    End Sub
    Private Sub Buscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxNomBus.KeyDown

        If e.KeyCode = Keys.Enter Then

            BtSeleccionComprador_Click(sender, e)

        End If

    End Sub

    Private Sub BtSeleccion_Click(sender As Object, e As EventArgs) Handles BtSeleccion.Click, DgBuscar.DoubleClick
        If DgBuscar.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgBuscar Is Nothing
            _codigoComprador = CStr(DgBuscar.CurrentRow.Cells(0).Value)
            Close()
        End If
    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()

    End Sub

End Class