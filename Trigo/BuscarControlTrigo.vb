Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class BuscarControlTrigo
    Private Sub BuscarControlTrigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxNomBus.Select()

    End Sub
    Private _codigoProductor As String
    Public Property CodigoProductor() As String
        Get
            Return _codigoProductor
        End Get
        Set(ByVal value As String)
            _codigoProductor = value
        End Set
    End Property

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click

        Dim cmd As New SqlCommand("Sp_buscarCli", cnn)

            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@TabOri", VarGlob.busqueda)
            cmd.Parameters.AddWithValue("@nombre", TxNomBus.Text)

            cmd.ExecuteNonQuery()

            Dim da As New SqlDataAdapter(cmd)

            Dim dt As New DataTable

            da.Fill(dt)

            DgBoletaIngresada.DataSource = dt
            DataGridPropiedades()

    End Sub
    Private Sub BtSeleccion_Click(sender As Object, e As EventArgs) Handles BtSeleccion.Click, DgBoletaIngresada.DoubleClick
        If DgBoletaIngresada.RowCount = 0 Then
            MessageBox.Show("No hay nada para seleccionar.")
        ElseIf Not DgBoletaIngresada Is Nothing

            _codigoProductor = CStr(DgBoletaIngresada.CurrentRow.Cells(0).Value)
            VarGlob.busqueda = ""
            DgBoletaIngresada.DataSource = ""
            Close()
        End If
    End Sub
    Private Sub Buscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxNomBus.KeyDown

        If e.KeyCode = Keys.Enter Then

            BtBuscar_Click(sender, e)

        End If

    End Sub
    Private Sub DataGridPropiedades()
        DgBoletaIngresada.Columns("Id_Cliente").HeaderText = "ID Productor"
        DgBoletaIngresada.Columns("Nombre").HeaderText = "Nombre"
    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        VarGlob.busqueda = ""
        DgBoletaIngresada.DataSource = ""
        Close()

    End Sub
End Class