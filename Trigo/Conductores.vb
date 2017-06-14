Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Conductores
    Private Sub Conductores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        limpiarcampos()
        CargarData()

    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxNombreConductor.Text = "" Or TxCelular.Text = "" Then
            MessageBox.Show("Verifica campos en blanco", "Aviso")
        ElseIf conductorRegistrado(TxIdConductor.Text) = True Then

            MessageBox.Show("Ya existe el Conductor " + TxIdConductor.Text + ".")

        Else
            Try
                Dim cmd As New SqlCommand("Sp_InsNueCon", cnn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@Consecutivo", TxIdConductor.Text)
                cmd.Parameters.AddWithValue("@NombreConductor", TxNombreConductor.Text)
                cmd.Parameters.AddWithValue("@celular", TxCelular.Text)

                cmd.ExecuteNonQuery()

                Llenatextid()
                CargarData()
            Catch ex As Exception
                MsgBox("Error", MsgBoxStyle.Critical)
            End Try

        End If
    End Sub
    Private Sub Llenatextid()

        Dim dt As New DataTable
        Dim SqlCon As String = "Select max(Id_conductor)as id_conductor from conductores"
        Dim comnd As New SqlCommand(SqlCon, cnn)
        Dim drd As SqlDataReader
        drd = comnd.ExecuteReader()
        If drd.Read() Then
            TxIdConductor.Text = drd.Item("Id_conductor").ToString()
        End If
        drd.Close()

    End Sub
    Private Sub CargarData()

        Dim cmd As New SqlCommand("sp_llenarDgConductores", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DgConductores.DataSource = dt

    End Sub
    Private Sub seleccionConductor() Handles DgConductores.DoubleClick
        If DgConductores.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgConductores Is Nothing Then
            Dim valorId As String

            valorId = CStr(DgConductores.CurrentRow.Cells(0).Value)

            TxIdConductor.Text = valorId

            Dim cmd As New SqlCommand("sp_seleccionIdConductor", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idconductor", valorId))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)

            TxIdConductor.Text = CStr(row("id_conductor"))
            TxNombreConductor.Text = CStr(row("nombre_conductor"))
            TxCelular.Text = CStr(row("celular_conductor"))

        End If
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        limpiarcampos()
    End Sub
    Private Sub limpiarcampos()
        TxIdConductor.Text = ""
        TxNombreConductor.Text = ""
        TxCelular.Text = ""
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()

    End Sub


End Class