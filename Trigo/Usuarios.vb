Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombos()
        LimpiarCampos()
    End Sub
    Private Sub llenarCombos()
        Dim cmdllenaCbTipUsu As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet

        cmdllenaCbTipUsu = New SqlCommand("sp_CbTipoUsuario")
        cmdllenaCbTipUsu.CommandType = CommandType.StoredProcedure
        cmdllenaCbTipUsu.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbTipUsu)
        ds = New DataSet()
        da.Fill(ds)
        CBTipoUsuario.DataSource = ds.Tables(0)
        CBTipoUsuario.DisplayMember = "Nombre_tipousuario"
        CBTipoUsuario.ValueMember = "Id_tipousuario"
        CBTipoUsuario.SelectedIndex = -1
    End Sub
    Private Sub LimpiarCampos() Handles BtnNuevo.Click

        TxIdUsuario.Text = ""
        TxNombre.Text = ""
        Txusuario.Text = ""
        TxContraseña.Text = ""
        CBTipoUsuario.SelectedIndex = -1

    End Sub
    Private Sub Guardar(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim idusuario As String = ""
        If CBTipoUsuario.SelectedIndex = -1 Or TxNombre.Text = "" Or Txusuario.Text = "" Then
            MessageBox.Show("Verifica campos en blanco", "Aviso")
        ElseIf IdUsuRegistrado(TxIdUsuario.Text) = True Or usuarioRegistrado(Txusuario.Text) = True Then
            If TxIdUsuario.Text = "" Then

                MessageBox.Show("Ya existe el usuario " + Txusuario.Text + ".")

            Else

                MessageBox.Show("Ya existe el usuario " + TxIdUsuario.Text + ".")

            End If
        Else
            Try
                Dim cmd As New SqlCommand("Sp_InsNueUsu", cnn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@idusuario", generaCodigoUsuario(idusuario))
                cmd.Parameters.AddWithValue("@nombre", TxNombre.Text)
                cmd.Parameters.AddWithValue("@usuario", Txusuario.Text)
                cmd.Parameters.AddWithValue("@clave", TxContraseña.Text)
                cmd.Parameters.AddWithValue("@tipo", CBTipoUsuario.SelectedValue)

                TxIdUsuario.Text = cmd.Parameters("@idusuario").Value.ToString()

                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim BuscarUsuario As New BuscarUsuario
        BuscarUsuario.ShowDialog()
        LimpiarCampos()
        If BuscarUsuario.CodigoUsuario <> Nothing Then
            Dim cmd As New SqlCommand("sp_seleccionusuario", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@idusuario", BuscarUsuario.CodigoUsuario))

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)

            TxIdUsuario.Text = CStr(row("id_usuario"))
            TxNombre.Text = CStr(row("nombre"))
            Txusuario.Text = CStr(row("usuario"))
            TxContraseña.Text = CStr(row("clave"))
            CBTipoUsuario.SelectedValue = row("tipo")

        End If

    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Close()

    End Sub


End Class