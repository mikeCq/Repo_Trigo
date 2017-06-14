Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class BuscarCompradorLiquidacionVenta
    Private _codigoVenta As String
    Public Property CodigoVenta() As String
        Get
            Return _codigoVenta
        End Get
        Set(ByVal value As String)
            _codigoVenta = value
        End Set
    End Property
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim cmd As New SqlCommand("sp_LlenaDgCompradoresLiquidacionVentas", cnn)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Comprador", TbBuscarComprador.Text)
        cmd.ExecuteNonQuery()

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataSet

        da.Fill(dt)
        DGVCompradores.DataSource = dt.Tables(0).DefaultView

        ' propiedadesDataEntLiq()
        If DGVCompradores.RowCount > 0 Then DGVCompradores.Rows(0).Selected = False

    End Sub
    Private Sub TxProductor(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbBuscarComprador.KeyDown
        Dim cmd As New SqlCommand("sp_LlenaDgCompradoresLiquidacionVentas", cnn)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Comprador", TbBuscarComprador.Text)
        cmd.ExecuteNonQuery()

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataSet

        da.Fill(dt)
        DGVCompradores.DataSource = dt.Tables(0).DefaultView

        ' propiedadesDataEntLiq()
        If DGVCompradores.RowCount > 0 Then DGVCompradores.Rows(0).Selected = False

    End Sub
    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click, DGVCompradores.DoubleClick
        If DGVCompradores.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf DGVCompradores.CurrentRow IsNot Nothing Then
            _codigoVenta = CStr(DGVCompradores.CurrentRow.Cells(0).Value)
            Close()
        End If
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DGVCompradores.Columns.Clear()
        Close()
    End Sub

End Class