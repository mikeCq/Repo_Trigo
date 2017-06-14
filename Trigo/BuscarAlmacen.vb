Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class BuscarAlmacen
    Private Sub BuscarAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxAcopio.Select()
    End Sub
    Private _codigoCentro As String
    Public Property CodigoCentro() As String
        Get
            Return _codigoCentro
        End Get
        Set(ByVal value As String)
            _codigoCentro = value
        End Set
    End Property
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        Dim cmd As New SqlCommand("sp_buscarCentroAcopio", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@buscarcentro", TxAcopio.Text)
        cmd.Parameters.AddWithValue("@buscaralmacen", TxAlmacen.Text)
        cmd.Parameters.AddWithValue("@folioaserca", TxFolioAserca.Text)

        cmd.ExecuteNonQuery()

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        DgBuscar.DataSource = dt

        DataGridPropiedades()
    End Sub
    Private Sub DataGridPropiedades()

        DgBuscar.Columns("NombreCentro").HeaderText = "Centro de Acopio"
        DgBuscar.Columns("folioAserca").HeaderText = "Folio ASERCA"
        DgBuscar.Columns("capacidad").HeaderText = "Capacidad x Almacen"
        DgBuscar.Columns("nombre_almacen").HeaderText = "Almacen"
        DgBuscar.Columns("tiposilo").HeaderText = "Tipo de Silo"

        DgBuscar.Columns("Id_CentroAcopio").Visible = False
        DgBuscar.Columns("colonia").Visible = False
        DgBuscar.Columns("ciudad").Visible = False
        DgBuscar.Columns("estado").Visible = False
        DgBuscar.Columns("calle").Visible = False
        DgBuscar.Columns("numero").Visible = False
        DgBuscar.Columns("codigopostal").Visible = False
        DgBuscar.Columns("capacidadmax").Visible = False

    End Sub
    Private Sub Buscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxAcopio.KeyDown, TxAlmacen.KeyDown, TxFolioAserca.KeyDown
        If e.KeyCode = Keys.Enter Then

            BtBuscar_Click(sender, e)

        End If
    End Sub
    Private Sub BtSeleccion_Click(sender As Object, e As EventArgs) Handles BtSeleccion.Click, DgBuscar.DoubleClick
        If DgBuscar.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgBuscar Is Nothing Then
            _codigoCentro = CStr(DgBuscar.CurrentRow.Cells(0).Value)
            Close()
        End If
    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()
    End Sub

End Class