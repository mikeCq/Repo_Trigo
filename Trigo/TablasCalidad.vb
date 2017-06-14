Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class TablasCalidad
    Private Sub TablasCalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo(sender, e)
        CargarData()
        propiedadesGridGranoDan()
        propiedadesGridHumedad()
        propiedadesGridimpurezas()
        propiedadesGridGranoQueb()
        propiedadesGridPesoEsp()
        TablaSeleccion()
    End Sub
    Private Sub CargarData()
        Dim cmd As New SqlCommand("sp_LlenarDgGranoDan", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataSet
        da.Fill(dt)
        DgGranoDan.DataSource = dt.Tables(0).DefaultView


        Dim cmd1 As New SqlCommand("sp_LlenarDgGranoQueb", cnn)
        cmd1.CommandType = CommandType.StoredProcedure
        Dim da1 As New SqlDataAdapter(cmd1)
        Dim dt1 As New DataSet
        da1.Fill(dt1)
        DgGranoQue.DataSource = dt1.Tables(0).DefaultView


        Dim cmd2 As New SqlCommand("sp_LlenarDgCalidadHumedad", cnn)
        cmd2.CommandType = CommandType.StoredProcedure
        Dim da2 As New SqlDataAdapter(cmd2)
        Dim dt2 As New DataSet
        da2.Fill(dt2)
        DgHumedad.DataSource = dt2.Tables(0).DefaultView


        Dim cmd3 As New SqlCommand("sp_LlenarDgCalidadImpurezas", cnn)
        cmd3.CommandType = CommandType.StoredProcedure
        Dim da3 As New SqlDataAdapter(cmd3)
        Dim dt3 As New DataSet
        da3.Fill(dt3)
        DgImpurezas.DataSource = dt3.Tables(0).DefaultView

        Dim cmd4 As New SqlCommand("sp_LlenarDgPesoEsp", cnn)
        cmd4.CommandType = CommandType.StoredProcedure
        Dim da4 As New SqlDataAdapter(cmd4)
        Dim dt4 As New DataSet
        da4.Fill(dt4)
        DgPesoEsp.DataSource = dt4.Tables(0).DefaultView

    End Sub
    Private Sub SoloNumeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxDeduccion.KeyPress, TxPorcentaje.KeyPress, TxMinimo.KeyPress, TxMaximo.KeyPress, TextBox1.KeyPress, TxRangoIni2.KeyPress, TxRangoIni1.KeyPress, TxAumenta.KeyPress, TxRangoFin2.KeyPress, TxRangoFin1.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub
    Private Sub DG_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgGranoDan.EditingControlShowing, DgGranoQue.EditingControlShowing, DgHumedad.EditingControlShowing, DgImpurezas.EditingControlShowing, DgPesoEsp.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf SoloNumeros
        AddHandler e.Control.KeyPress, AddressOf SoloNumeros
    End Sub
    Private Sub propiedadesGridGranoDan()
        DgGranoDan.Columns("id_GranoDan").Visible = False
        DgGranoDan.Columns("porcentajegranoMin").HeaderText = "% Minimo"
        DgGranoDan.Columns("porcentajegranoMax").HeaderText = "% Maximo"
        DgGranoDan.Columns("deduccion").HeaderText = "Deducción Kg x Ton"
    End Sub
    Private Sub propiedadesGridHumedad()
        DgHumedad.Columns("id_Humedad").Visible = False
        DgHumedad.Columns("PorcentajeHumedadMin").HeaderText = "% Minimo"
        DgHumedad.Columns("PorcentajeHumedadMax").HeaderText = "% Maximo"
        DgHumedad.Columns("deduccion").HeaderText = "Deducción Kg x Ton"
    End Sub
    Private Sub propiedadesGridGranoQueb()
        DgGranoQue.Columns("id_GranoQue").Visible = False
        DgGranoQue.Columns("porcentajeGranoQuebMin").HeaderText = "% Minimo"
        DgGranoQue.Columns("porcentajeGranoQuebMax").HeaderText = "% Maximo"
        DgGranoQue.Columns("deduccion").HeaderText = "Deducción Kg x Ton"
    End Sub
    Private Sub propiedadesGridimpurezas()
        DgImpurezas.Columns("idImpureza").Visible = False
        DgImpurezas.Columns("porcentajeimpurezaMin").HeaderText = "% Minimo"
        DgImpurezas.Columns("porcentajeimpurezaMax").HeaderText = "% Maximo"
        DgImpurezas.Columns("deduccion").HeaderText = "Deducción Kg x Ton"
    End Sub
    Private Sub propiedadesGridPesoEsp()
        DgPesoEsp.Columns("id_PesoEsp").Visible = False
        DgPesoEsp.Columns("porcentajePesoEspMin").HeaderText = "% Minimo"
        DgPesoEsp.Columns("porcentajePesoEspMax").HeaderText = "% Maximo"
        DgPesoEsp.Columns("deduccion").HeaderText = "Deducción Kg x Ton"
    End Sub
    Private Sub TablaSeleccion() Handles TcTablaCalidad.Selecting
        TxTablaSeleccionada.Text = TcTablaCalidad.SelectedTab.Text


        Dim cmd As New SqlCommand("sp_seleccionaParametros", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@tabla", TcTablaCalidad.SelectedTab.Text))

        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)
        Dim row As DataRow = dt.Rows(0)

        TxMinimo.Text = CStr(row("minimodeduccion"))
        TxMaximo.Text = CStr(row("maximoDeduccion"))
    End Sub
    Private Sub Nuevo(sender As Object, e As EventArgs) Handles BtNuevo.Click
        TxPorcentaje.Text = ""
        TxDeduccion.Text = ""

        TxMinimo.Text = "0.00"
        TxMaximo.Text = "0.00"

        CargarData()
        propiedadesGridGranoDan()
        propiedadesGridHumedad()
        propiedadesGridimpurezas()
        propiedadesGridGranoQueb()
        propiedadesGridPesoEsp()
    End Sub
    Private Sub Guardar(sender As Object, e As EventArgs) Handles BtGuardar.Click
        If TxDeduccion.Text = "" Or TxPorcentaje.Text = "" Then
            MessageBox.Show("No se puede continuar con campos vacios.", "Aviso")
        Else
            Dim cmd As New SqlCommand("sp_InsTablaCalidad", cnn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Tabla", TxTablaSeleccionada.Text)
            cmd.Parameters.AddWithValue("@porcentaje", TxPorcentaje.Text)
            cmd.Parameters.AddWithValue("@deduccion", TxDeduccion.Text)

            cmd.ExecuteNonQuery()

            DefineParametrosCalidad()

            CargarData()
            propiedadesGridGranoDan()
            propiedadesGridHumedad()
            propiedadesGridimpurezas()
            propiedadesGridGranoQueb()
            propiedadesGridPesoEsp()

        End If
    End Sub
    Private Sub generaTabla() Handles Button1.Click
        Dim Rangoini1, Rangoini2, RangoFin1, RangoFin2, ResRan, Deduccion, ResDed As Double
        Dim Aumento As Double
        Dim deduccionMinimo, deduccionMaximo As Double

        Deduccion = Val(TxDeduccion.Text)
        deduccionMinimo = Val(TxMinimo.Text)
        deduccionMaximo = Val(TxMaximo.Text)

        ResRan = Val(TxRangoIni2.Text) - Val(TxRangoIni1.Text)

        Rangoini1 = Val(TxRangoIni1.Text)
        Rangoini2 = Val(TxRangoIni2.Text)

        RangoFin1 = Val(TxRangoFin1.Text)
        RangoFin2 = Val(TxRangoFin2.Text)

        Aumento = Val(TxAumenta.Text)

        While (Rangoini1 <= RangoFin1)
            ResDed = ResDed + Val(TxDeduccion.Text)
            Rangoini1 = Rangoini1 + Aumento
            Rangoini2 = Rangoini2 + ResRan
            If Deduccion <= deduccionMinimo Then
                MsgBox(ResDed & " , " & Rangoini1 & " , " & RangoFin1)
            ElseIf Deduccion >= deduccionMinimo And Deduccion <= deduccionMaximo Then

            End If

        End While

    End Sub
    Private Sub DefineParametrosCalidad()
        Dim cmd As New SqlCommand("sp_ActParametrosCalidad", cnn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@Tabla", TxTablaSeleccionada.Text)
        cmd.Parameters.AddWithValue("@minimo", TxMinimo.Text)
        cmd.Parameters.AddWithValue("@maximo", TxMaximo.Text)
        cmd.ExecuteNonQuery()

    End Sub
    Private Sub Actualizar(sender As Object, e As EventArgs) Handles BtActualizar.Click

        If TxTablaSeleccionada.Text = "Grano Dañado" Then
            For Each row As DataGridViewRow In DgGranoDan.Rows
                Dim cmd As New SqlCommand("sp_ActTablaCalidad", cnn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@IdTabla", row.Cells("id_granodan").Value)
                cmd.Parameters.AddWithValue("@Tabla", TxTablaSeleccionada.Text)
                cmd.Parameters.AddWithValue("@porcentaje", row.Cells("PorcentajeGranoDan").Value)
                cmd.Parameters.AddWithValue("@deduccion", row.Cells("Deduccion").Value)

                cmd.ExecuteNonQuery()

            Next
            CargarData()
            propiedadesGridGranoDan()
            propiedadesGridHumedad()
            propiedadesGridimpurezas()
            propiedadesGridGranoQueb()
            propiedadesGridPesoEsp()
        ElseIf TxTablaSeleccionada.Text = "Grano Quebrado" Then
            For Each row As DataGridViewRow In DgGranoQue.Rows
                Dim cmd As New SqlCommand("sp_ActTablaCalidad", cnn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@IdTabla", row.Cells("id_granoQueb").Value)
                cmd.Parameters.AddWithValue("@Tabla", TxTablaSeleccionada.Text)
                cmd.Parameters.AddWithValue("@porcentaje", row.Cells("PorcentajeGranoQueb").Value)
                cmd.Parameters.AddWithValue("@deduccion", row.Cells("deduccion").Value)

                cmd.ExecuteNonQuery()
            Next
            CargarData()
            propiedadesGridGranoDan()
            propiedadesGridHumedad()
            propiedadesGridimpurezas()
            propiedadesGridGranoQueb()
            propiedadesGridPesoEsp()
        ElseIf TxTablaSeleccionada.Text = "Humedad" Then
            For Each row As DataGridViewRow In DgHumedad.Rows
                Dim cmd As New SqlCommand("sp_ActTablaCalidad", cnn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@IdTabla", row.Cells("id_humedad").Value)
                cmd.Parameters.AddWithValue("@Tabla", TxTablaSeleccionada.Text)
                cmd.Parameters.AddWithValue("@porcentaje", row.Cells("porcentajehumedad").Value)
                cmd.Parameters.AddWithValue("@deduccion", row.Cells("deduccion").Value)

                cmd.ExecuteNonQuery()
            Next
            CargarData()
            propiedadesGridGranoDan()
            propiedadesGridHumedad()
            propiedadesGridimpurezas()
            propiedadesGridGranoQueb()
            propiedadesGridPesoEsp()
        ElseIf TxTablaSeleccionada.Text = "Impurezas" Then
            For Each row As DataGridViewRow In DgImpurezas.Rows
                Dim cmd As New SqlCommand("sp_ActTablaCalidad", cnn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@IdTabla", row.Cells("id_Impureza").Value)
                cmd.Parameters.AddWithValue("@Tabla", TxTablaSeleccionada.Text)
                cmd.Parameters.AddWithValue("@porcentaje", row.Cells("PorcentajeImpureza").Value)
                cmd.Parameters.AddWithValue("@deduccion", row.Cells("deduccion").Value)

                cmd.ExecuteNonQuery()
            Next
            CargarData()
            propiedadesGridGranoDan()
            propiedadesGridHumedad()
            propiedadesGridimpurezas()
            propiedadesGridGranoQueb()
            propiedadesGridPesoEsp()
        ElseIf TxTablaSeleccionada.Text = "Peso Especifico" Then
            For Each row As DataGridViewRow In DgPesoEsp.Rows
                Dim cmd As New SqlCommand("sp_ActTablaCalidad", cnn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@IdTabla", row.Cells("id_PesoEsp").Value)
                cmd.Parameters.AddWithValue("@Tabla", TxTablaSeleccionada.Text)
                cmd.Parameters.AddWithValue("@porcentaje", row.Cells("PorcentajePesoEsp").Value)
                cmd.Parameters.AddWithValue("@deduccion", row.Cells("deduccion").Value)

                cmd.ExecuteNonQuery()
            Next
            CargarData()
            propiedadesGridGranoDan()
            propiedadesGridHumedad()
            propiedadesGridimpurezas()
            propiedadesGridGranoQueb()
            propiedadesGridPesoEsp()
        End If

    End Sub
    Private Sub Eliminar(sender As Object, e As EventArgs) Handles BtEliminar.Click
        Dim opc As DialogResult = MessageBox.Show("¿Esta seguro de eliminar el dato seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If opc = DialogResult.Yes Then

            If TxTablaSeleccionada.Text = "Grano Dañado" Then
                Dim cmd As New SqlCommand("sp_EliTablaCalidad", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdTabla", DgGranoDan.CurrentRow.Cells(0).Value)
                cmd.Parameters.AddWithValue("@Tabla", TxTablaSeleccionada.Text)
                cmd.ExecuteNonQuery()
                CargarData()
                propiedadesGridGranoDan()
                propiedadesGridHumedad()
                propiedadesGridimpurezas()
                propiedadesGridGranoQueb()
                propiedadesGridPesoEsp()
            ElseIf TxTablaSeleccionada.Text = "Grano Quebrado" Then
                Dim cmd As New SqlCommand("sp_EliTablaCalidad", cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdTabla", DgGranoQue.CurrentRow.Cells(0).Value)
                cmd.Parameters.AddWithValue("@Tabla", TxTablaSeleccionada.Text)
                cmd.ExecuteNonQuery()
                CargarData()
                propiedadesGridGranoDan()
                propiedadesGridHumedad()
                propiedadesGridimpurezas()
                propiedadesGridGranoQueb()
                propiedadesGridPesoEsp()
            ElseIf TxTablaSeleccionada.Text = "Humedad" Then
                Dim cmd As New SqlCommand("sp_EliTablaCalidad", cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdTabla", DgHumedad.CurrentRow.Cells(0).Value)
                cmd.Parameters.AddWithValue("@Tabla", TxTablaSeleccionada.Text)
                cmd.ExecuteNonQuery()
                CargarData()
                propiedadesGridGranoDan()
                propiedadesGridHumedad()
                propiedadesGridimpurezas()
                propiedadesGridGranoQueb()
                propiedadesGridPesoEsp()
            ElseIf TxTablaSeleccionada.Text = "Impurezas" Then
                Dim cmd As New SqlCommand("sp_EliTablaCalidad", cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdTabla", DgImpurezas.CurrentRow.Cells(0).Value)
                cmd.Parameters.AddWithValue("@Tabla", TxTablaSeleccionada.Text)
                cmd.ExecuteNonQuery()
                CargarData()
                propiedadesGridGranoDan()
                propiedadesGridHumedad()
                propiedadesGridimpurezas()
                propiedadesGridGranoQueb()
                propiedadesGridPesoEsp()
            ElseIf TxTablaSeleccionada.Text = "Impurezas" Then
                Dim cmd As New SqlCommand("sp_EliTablaCalidad", cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdTabla", DgPesoEsp.CurrentRow.Cells(0).Value)
                cmd.Parameters.AddWithValue("@Tabla", TxTablaSeleccionada.Text)
                cmd.ExecuteNonQuery()
                CargarData()
                propiedadesGridGranoDan()
                propiedadesGridHumedad()
                propiedadesGridimpurezas()
                propiedadesGridGranoQueb()
                propiedadesGridPesoEsp()
            End If
        End If
    End Sub
    Private Sub cerrarVentana(sender As Object, e As EventArgs) Handles BtSalir.Click
        Close()
    End Sub
End Class