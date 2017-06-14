Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class BuscarEmpresa
    Private Sub BuscarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxNomBus.Select()

    End Sub
    Private _codigoCliente As String
    Public Property CodigoCliente() As String
        Get
            Return _codigoCliente
        End Get
        Set(ByVal value As String)
            _codigoCliente = value
        End Set
    End Property
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click

        Dim cmd As New SqlCommand("SP_BUSCAREMPRESAS", cnn)

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

            BtBuscar_Click(sender, e)

        End If

    End Sub

    Private Sub BtSeleccion_Click(sender As Object, e As EventArgs) Handles BtSeleccion.Click, DgBuscar.DoubleClick
        If DgBuscar.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgBuscar Is Nothing Then
            _codigoCliente = CStr(DgBuscar.CurrentRow.Cells(0).Value)
            Close()
        End If
    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click

        Close()

    End Sub
End Class