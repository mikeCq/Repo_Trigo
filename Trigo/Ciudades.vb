Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Ciudades
    Private Sub Ciudades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiarCampos()
        CargarData()
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxNombre.Text = "" Or TxDescripcion.Text = "" Then
            MessageBox.Show("Verifica campos en blanco", "Aviso")
        ElseIf ciudadRegistrado(TxIdCiudad.Text) = True Then

            MessageBox.Show("Ya existe el comprador " + TxIdCiudad.Text + ".")

        Else
            Try
                Dim DFMensajeProceso As FMSGPROv3 = New FMSGPROv3
                DFMensajeProceso.Show()
                Dim cmd As New SqlCommand("Sp_InsNueCiu", cnn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@Consecutivo", TxIdCiudad.Text)
                cmd.Parameters.AddWithValue("@NomCiu", TxNombre.Text)
                cmd.Parameters.AddWithValue("@descripcion", TxDescripcion.Text)

                cmd.ExecuteNonQuery()

                Llenatextid()
                CargarData()
                DFMensajeProceso.CerrarProcesoInmediato()
            Catch ex As Exception
                MsgBox("Error", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Sub Llenatextid()
        Dim dt As New DataTable
        Dim SqlCon As String = "Select max(Id_ciudad)as Id_ciudad from ciudades"
        Dim comnd As New SqlCommand(SqlCon, cnn)
        Dim drd As SqlDataReader

        drd = comnd.ExecuteReader()

        If drd.Read() Then
            TxIdCiudad.Text = drd.Item("Id_ciudad").ToString()
        End If
        drd.Close()
    End Sub
    Private Sub limpiarCampos()
        TxIdCiudad.Text = ""
        TxNombre.Text = ""
        TxDescripcion.Text = ""
    End Sub
    Private Sub CargarData()
        Dim cmd As New SqlCommand("sp_llenarDg_Ciudades", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable

        da.Fill(dt)
        DgCiudades.DataSource = dt
    End Sub
    Private Sub SeleccionCiudad(sender As Object, e As EventArgs) Handles DgCiudades.DoubleClick
        If DgCiudades.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgCiudades Is Nothing Then
            Dim valorId As String

            valorId = CStr(DgCiudades.CurrentRow.Cells(0).Value)

            TxIdCiudad.Text = valorId

            Dim cmd As New SqlCommand("sp_seleccionIdCiudad", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idciudad", valorId))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)

            TxNombre.Text = CStr(row("nombre_ciudad"))
            TxDescripcion.Text = CStr(row("Descripcion"))

        End If
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        limpiarCampos()
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class
