Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class BuscarUsuario
    Private Sub BuscarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private _codigoUsuario As String
    Public Property CodigoUsuario() As String
        Get
            Return _codigoUsuario
        End Get
        Set(ByVal value As String)
            _codigoUsuario = value
        End Set
    End Property
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click

        Dim cmd As New SqlCommand("sp_BuscarUsuario", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@usuario", TxUsuario.Text)

            cmd.ExecuteNonQuery()

            Dim da As New SqlDataAdapter(cmd)

            Dim dt As New DataTable

            da.Fill(dt)

            DgBuscarUsuario.DataSource = dt

            DataGridPropiedades()

    End Sub
    Private Sub DataGridPropiedades()
        DgBuscarUsuario.Columns("id_usuario").HeaderText = "Id Usuario"
        DgBuscarUsuario.Columns("Nombre").HeaderText = "Nombre"
        DgBuscarUsuario.Columns("usuario").HeaderText = "Usuario"
        DgBuscarUsuario.Columns("Tipo").HeaderText = "Tipo"
        'DgBuscarUsuario.Columns("id_usuario").Visible = False
    End Sub
    Private Sub Buscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxUsuario.KeyDown

        If e.KeyCode = Keys.Enter Then

            BtBuscar_Click(sender, e)

        End If

    End Sub
    Private Sub BtSeleccion_Click(sender As Object, e As EventArgs) Handles BtSeleccion.Click, DgBuscarUsuario.DoubleClick
        If DgBuscarUsuario.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgBuscarUsuario Is Nothing
            _codigoUsuario = CStr(DgBuscarUsuario.CurrentRow.Cells(0).Value)
            Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()

    End Sub

End Class