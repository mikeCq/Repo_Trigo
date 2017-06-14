Imports System.Data.Sql
Imports System.Data.SqlClient
Module conexion

    Public cnn As SqlConnection
    Public consulta As SqlCommand
    Public respuesta As SqlDataReader

    Sub abrir()
        Try
            cnn = New SqlConnection(VarGlob.ConexionPrincipal)

            cnn.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub
    '#######################SE COMPRUEBA EXISTENCIA DE USUARIO Y CONTRASEÑA CORRECTA##############################################
    Function IdUsuRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            consulta = New SqlCommand("select * from usuarios where  id_usuario ='" & nombreUsuario & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            consulta = New SqlCommand("select * from usuarios where  usuario ='" & nombreUsuario & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado

    End Function
    Function clave(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select clave from usuarios where usuario = '" & nombreUsuario & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = respuesta.Item("clave")
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function claveAutorizacion(ByVal claveaut As String) As Boolean
        Dim resultado As Boolean = False
        Try
            consulta = New SqlCommand("select top 1 ClaveAutorizacion  from usuarios where Tipo  = 1", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If claveaut = respuesta.Item("ClaveAutorizacion") Then
                    resultado = True
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    '########################## COMPRUEBA AÑO DE TEMPORADA Y SU ESTADO #############################################
    'Function CompruebaTemporada(ByVal temporada As String) As Boolean
    '    Dim resultado As Boolean = False
    '    Try
    '        consulta = New SqlCommand("select max(temporada) as temporada from temporadas")
    '    Catch ex As Exception

    '    End Try
    'End Function

    '########################## COMPRUEBA EXISTENCIA DE REGISTROS CON CAMPO LLAVE #############################################
    Function centroRegistrado(ByVal identidicadorAcopio As String, ByVal identificadorAlmacen As String) As Boolean
        Dim resultado As Boolean
        Try

            consulta = New SqlCommand("Select  ca.Id_CentroAcopio , al.Id_Almacen  from CentroAcopio CA inner join Almacen AL On ca.Id_CentroAcopio = al.id_Acopio where ca.Id_CentroAcopio =  '" & identidicadorAcopio & "' And al.Id_Almacen ='" & identificadorAlmacen & "' ", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function clienteRegistrado(ByVal identificadorCliente As String) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select id_cliente from clientes where id_cliente = '" & identificadorCliente & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function RepresentanteRegistrado(ByVal identificadorRepresentante As String) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select id_Empresa from Empresas where id_Empresa = '" & identificadorRepresentante & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function compradorRegistrado(ByVal identificadorComprador As String) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select id_comprador from compradores where id_comprador = '" & identificadorComprador & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function entradaRegistrada(ByVal identificadorEntrada As String, ByVal estado As Integer) As Boolean
        Dim resultado As Boolean = False
        Try
            consulta = New SqlCommand("select id_entrada, estado from ControlEntradas where id_entrada = '" & identificadorEntrada & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("estado") = 0 Then
                    resultado = True
                End If
            Else
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function salidaRegistrada(ByVal identificadorSalida As String, ByVal estado As Integer) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select id_salida, estado from ControlSalidas where id_salida = '" & identificadorSalida & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("estado") = 0 Then
                    resultado = True
                End If
            Else
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function embarqueRegistrada(ByVal identificadorEmbarque As String, ByVal estado As Integer) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select id_embarque, estado from Controlembarques where id_embarque = '" & identificadorEmbarque & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("estado") = 0 Then
                    resultado = True
                End If
            Else
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function contratoVentaReg(ByVal identificadorConVen As String) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select id_contratoV from contratosVentas where id_contratoV = '" & identificadorConVen & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function contratoCompraReg(ByVal identificadorConCom As String) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select id_contratoC from contratosCompras where id_contratoC = '" & identificadorConCom & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function LoteRegistrado(ByVal identificadorlote As String) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select id_tierra from tierras where id_tierra = '" & identificadorlote & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function ciudadRegistrado(ByVal identificadorciudad As String) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select id_ciudad from ciudades where id_ciudad = '" & identificadorciudad & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function coloniaRegistrado(ByVal identificadorcolonia As String) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select id_colonia from colonias where id_colonia = '" & identificadorcolonia & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function conductorRegistrado(ByVal identificadorConductor As String) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select id_conductor from conductores where id_conductor = '" & identificadorConductor & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function verificaBoletaEntrada(ByVal Boleta As String) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select numeroBoleta from controlEntradas where numeroBoleta = '" & Boleta & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function verificaBoletaSalida(ByVal Boleta As String) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select numeroBoleta from controlSalidas where numeroBoleta = '" & Boleta & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function verificaBoletaEmbarque(ByVal Boleta As String) As Boolean
        Dim resultado As Boolean
        Try
            consulta = New SqlCommand("select numeroBoleta from controlEmbarques where numeroBoleta = '" & Boleta & "'", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    '##################################################### GENERA ID DE CAMPOS LLAVE ####################################################################################
    Function generaCodigoSalida(ByVal codigoSalida As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(id_salida,4,7)) as id_salida from controlsalidas", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("id_salida") Is DBNull.Value Then
                    resultado = "SAL" & Format(1, "000000#")
                Else
                    resultado = "SAL" & (Format(respuesta.Item("id_salida") + 1, "000000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoBoletaEntrada(ByVal codigoBoleta As Integer) As Integer
        Dim resultado As Integer = 0
        Try
            consulta = New SqlCommand("select max(numeroboleta) as numeroBoleta from controlentradas", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("numeroBoleta") Is DBNull.Value Then
                    resultado = 1
                Else
                    resultado = respuesta.Item("numeroBoleta") + 1
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoEntrada(ByVal codigoEntrada As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(id_entrada,4,7)) as id_entrada from controlentradas", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("id_entrada") Is DBNull.Value Then
                    resultado = "ENT" & Format(1, "000000#")
                Else
                    resultado = "ENT" & (Format(respuesta.Item("id_entrada") + 1, "000000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoEmbarque(ByVal codigoEmbarque As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(id_embarque,4,7)) as id_embarque from controlembarques", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("id_embarque") Is DBNull.Value Then
                    resultado = "EMB" & Format(1, "000000#")
                Else
                    resultado = "EMB" & (Format(respuesta.Item("id_embarque") + 1, "000000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoBoletaSalida(ByVal codigoBoleta As Integer) As Integer
        Dim resultado As Integer = 0
        Try
            consulta = New SqlCommand("select max(numeroboleta) as numeroBoleta from controlsalidas", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("numeroBoleta") Is DBNull.Value Then
                    resultado = 1
                Else
                    resultado = respuesta.Item("numeroBoleta") + 1
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoBoletaEmbarque(ByVal codigoBoleta As Integer) As Integer
        Dim resultado As Integer = 0
        Try
            consulta = New SqlCommand("select max(numeroboleta) as numeroBoleta from controlembarques", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("numeroBoleta") Is DBNull.Value Then
                    resultado = 1
                Else
                    resultado = respuesta.Item("numeroBoleta") + 1
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoUsuario(ByVal idusuario As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(id_usuario,3,4)) as id_usuario from usuarios", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("id_usuario") Is DBNull.Value Then
                    resultado = "US" & Format(1, "000#")
                Else
                    resultado = "US" & (Format(respuesta.Item("id_usuario") + 1, "000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoEmpresa(ByVal idempresa As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(id_empresa,4,4)) as id_empresa from empresas", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("id_empresa") Is DBNull.Value Then
                    resultado = "EMP" & Format(1, "000#")
                Else
                    resultado = "EMP" & (Format(respuesta.Item("id_empresa") + 1, "000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoCliente(ByVal idcliente As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(id_cliente,4,5)) as id_cliente from clientes", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("id_cliente") Is DBNull.Value Then
                    resultado = "CLI" & Format(1, "0000#")
                Else
                    resultado = "CLI" & (Format(respuesta.Item("id_cliente") + 1, "0000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoTierra(ByVal idtierra As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(id_tierra,4,5)) as id_tierra from tierras", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("id_tierra") Is DBNull.Value Then
                    resultado = "LOT" & Format(1, "0000#")
                Else
                    resultado = "LOT" & (Format(respuesta.Item("id_tierra") + 1, "0000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoContratoCom(ByVal idContratoC As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(id_contratoc,4,5)) as id_contratoc from contratosCompras", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("id_contratoc") Is DBNull.Value Then
                    resultado = "CCO" & Format(1, "0000#")
                Else
                    resultado = "CCO" & (Format(respuesta.Item("id_contratoc") + 1, "0000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoContratoComprador(ByVal codigoContratoComprador As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(id_contrato,4,7)) as id_contrato from ContratosCompradores", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("id_contrato") Is DBNull.Value Then
                    resultado = "COC" & Format(1, "000000#")
                Else
                    resultado = "COC" & (Format(respuesta.Item("id_contrato") + 1, "000000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoSeleccion(ByVal codigoSeleccion As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(id_seleccion) as id_seleccion from productoresSeleccionC", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("id_seleccion") Is DBNull.Value Then
                    resultado = Format(1, "000000#")
                Else
                    resultado = (Format(respuesta.Item("id_seleccion") + 1, "000000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaIDseleccion(ByVal codigoSeleccion As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(idseleccionados,4,5)) as idseleccionados from lotesseleccion", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("idseleccionados") Is DBNull.Value Then
                    resultado = "SEL" & Format(1, "0000#")
                Else
                    resultado = "SEL" & (Format(respuesta.Item("idseleccionados") + 1, "0000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoVenta(ByVal idventa As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(Id_ContratoV,4,7)) as Id_ContratoV from contratosventas", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("Id_ContratoV") Is DBNull.Value Then
                    resultado = "CVE" & Format(1, "000000#")
                Else
                    resultado = "CVE" & (Format(respuesta.Item("Id_ContratoV") + 1, "000000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaIDComprador(ByVal codigoComprador As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(id_comprador,4,5)) as id_comprador from compradores", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("id_comprador") Is DBNull.Value Then
                    resultado = "COM" & Format(1, "0000#")
                Else
                    resultado = "COM" & (Format(respuesta.Item("id_comprador") + 1, "0000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoLiquidacionP(ByVal codigoLiquidacion As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(idLiquidacionP,4,7)) as idLiquidacionP from LiquidacionesXproductor", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("idLiquidacionP") Is DBNull.Value Then
                    resultado = "LIP" & Format(1, "000000#")
                Else
                    resultado = "LIP" & (Format(respuesta.Item("idLiquidacionP") + 1, "000000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoLiquidacionT(ByVal codigoLiquidacion As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(idLiquidacionT,4,7)) as idLiquidacionT from LiquidacionTotalXprod", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("idLiquidacionT") Is DBNull.Value Then
                    resultado = "LPT" & Format(1, "000000#")
                Else
                    resultado = "LPT" & (Format(respuesta.Item("idLiquidacionT") + 1, "000000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoVentaResumen(ByVal codigoLiquidacion As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(IdVentaComprador,4,7)) as IdVentaComprador from VentaComprador", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("IdVentaComprador") Is DBNull.Value Then
                    resultado = "LVP" & Format(1, "000000#")
                Else
                    resultado = "LVP" & (Format(respuesta.Item("IdVentaComprador") + 1, "000000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoLiquidacionVenta(ByVal codigoLiquidacion As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(IdVentaTotalComprador,4,7)) as IdVentaTotalComprador from VentaTotalComprador", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("IdVentaTotalComprador") Is DBNull.Value Then
                    resultado = "LVT" & Format(1, "000000#")
                Else
                    resultado = "LVT" & (Format(respuesta.Item("IdVentaTotalComprador") + 1, "000000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoAcopio(ByVal idAcopio As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(id_centroAcopio,4,5)) as id_centroAcopio from CentroAcopio", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("id_centroAcopio") Is DBNull.Value Then
                    resultado = "ACO" & Format(1, "0000#")
                Else
                    resultado = "ACO" & (Format(respuesta.Item("id_centroacopio") + 1, "0000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function generaCodigoAlmacen(ByVal idAlmacen As String) As String
        Dim resultado As String = ""
        Try
            consulta = New SqlCommand("select max(substring(id_Almacen,4,5)) as id_Almacen from Almacen", cnn)
            respuesta = consulta.ExecuteReader
            If respuesta.Read Then
                If respuesta.Item("id_Almacen") Is DBNull.Value Then
                    resultado = "ALM" & Format(1, "0000#")
                Else
                    resultado = "ALM" & (Format(respuesta.Item("id_Almacen") + 1, "0000#"))
                End If
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
End Module

