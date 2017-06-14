Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class BuscarEntradaLiq
    Private _codigoProductor As String
    Public Property CodigoProductor() As String
        Get
            Return _codigoProductor
        End Get
        Set(ByVal value As String)
            _codigoProductor = value
        End Set
    End Property
    Private Sub propiedadesDataEntLiq()

        DgEntLiq.Columns("id_cliente").Visible = False

        DgEntLiq.Columns("nombreProductor").HeaderText = "Productor"
        'DgEntradasLiq.Columns("nombreProductor").Width = 40

        DgEntLiq.Columns("Domicilio").HeaderText = "Domicilio"
        'DgEntradasLiq.Columns("Domicilio").Width = 60

        DgEntLiq.Columns("Colonia_Cliente").HeaderText = "Colonia"
        'DgEntradasLiq.Columns("Colonia_Cliente").Width = 65

    End Sub
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        Dim cmd As New SqlCommand("sp_clientesEntradasLiq", cnn)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@productor", TxBuscarProductor.Text)
        cmd.ExecuteNonQuery()

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataSet

        da.Fill(dt)
        DgEntLiq.DataSource = dt.Tables(0).DefaultView

        propiedadesDataEntLiq()
        If DgEntLiq.RowCount > 0 Then DgEntLiq.Rows(0).Selected = False

    End Sub
    Private Sub Txproductor(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxBuscarProductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim cmd As New SqlCommand("sp_clientesEntradasLiq", cnn)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@productor", TxBuscarProductor.Text)
            cmd.ExecuteNonQuery()

            Dim da As New SqlDataAdapter(cmd)

            Dim dt As New DataSet

            da.Fill(dt)
            DgEntLiq.DataSource = dt.Tables(0).DefaultView

            propiedadesDataEntLiq()
            If DgEntLiq.RowCount > 0 Then DgEntLiq.Rows(0).Selected = False
        End If
    End Sub
    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar.Click, DgEntLiq.DoubleClick
        If DgEntLiq.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf DgEntLiq.CurrentRow IsNot Nothing Then
            _codigoProductor = CStr(DgEntLiq.CurrentRow.Cells(0).Value)
            Close()
        End If
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        DgEntLiq.Columns.Clear()
        Close()
    End Sub


End Class