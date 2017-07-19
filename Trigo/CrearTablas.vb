Imports System.Data.SqlClient
Module CrearTablas
    '----------------------------------
    Sub CadenaConexion(ByVal Cadena As String, ByVal BD As String)
        Try
            Dim conexion As New SqlConnection(Cadena)
            Dim BaseDatos = BD
            conexion.Open()
            'Tabla Almacen---
            Dim Query1 As String = "CREATE TABLE [dbo].[Almacen]([Id_Almacen] [varchar](10) NOT NULL,[Nombre_Almacen] [varchar](50) NULL,[tipoSilo] [varchar](10) NULL,[Capacidad] [decimal](7, 3) NULL,[id_Acopio] [varchar](10) NULL,[tonEntradas] [decimal](7, 3) NULL,PRIMARY KEY CLUSTERED ([Id_Almacen] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando1 As New SqlCommand(Query1, conexion)
            comando1.ExecuteNonQuery()
            'Tabla Calidad Grano Dañado---
            Dim Query2 As String = "CREATE TABLE [dbo].[CalidadGranoDan]([id_GranoDan] [int] IDENTITY(1,1) NOT NULL,[porcentajeGranoMin] [float] NULL,[porcentajeGranoMax] [float] NULL,[deduccion] [float] NULL,PRIMARY KEY CLUSTERED ([id_GranoDan] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando2 As New SqlCommand(Query2, conexion)
            comando2.ExecuteNonQuery()
            'Tabla Calidad Grano Quebrado---
            Dim Query3 As String = "CREATE TABLE [dbo].[CalidadGranoQueb]([id_GranoQue] [int] IDENTITY(1,1) NOT NULL,[PorcentajeGranoQuebMin] [float] NULL,[PorcentajeGranoQuebMax] [float] NULL,[deduccion] [float] NULL,PRIMARY KEY CLUSTERED ([id_GranoQue] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando3 As New SqlCommand(Query3, conexion)
            comando3.ExecuteNonQuery()
            'Tabla Calidad Humedad---
            Dim Query4 As String = "CREATE TABLE [dbo].[CalidadHumedad]([id_Humedad] [int] IDENTITY(1,1) NOT NULL,[PorcentajeHumedadMin] [float] NULL,[PorcentajeHumedadMax] [float] NULL,[deduccion] [float] NULL,PRIMARY KEY CLUSTERED ([id_Humedad] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando4 As New SqlCommand(Query4, conexion)
            comando4.ExecuteNonQuery()
            'Tabla Calidad Impurezas---
            Dim Query5 As String = "CREATE TABLE [dbo].[CalidadImpurezas]([idImpureza] [int] IDENTITY(1,1) NOT NULL,[PorcentajeImpurezaMin] [float] NULL,[PorcentajeImpurezaMax] [float] NULL,[deduccion] [float] NULL,PRIMARY KEY CLUSTERED ([idImpureza] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando5 As New SqlCommand(Query5, conexion)
            comando5.ExecuteNonQuery()
            'Tabla Calidad Panza Blanca---
            Dim Query6 As String = "CREATE TABLE [dbo].[CalidadPanzaBlanca]([id_PanzaBlan] [int] IDENTITY(1,1) NOT NULL,[PorcentajePanzaBlanMin] [float] NULL,[PorcentajePanzaBlanMax] [float] NULL,[deduccion] [float] NULL) ON [PRIMARY]"
            Dim comando6 As New SqlCommand(Query6, conexion)
            comando6.ExecuteNonQuery()
            'Tabla Calidad Peso Especifico---
            Dim Query7 As String = "CREATE TABLE [dbo].[CalidadPesoEsp]([id_PesoEsp] [int] IDENTITY(1,1) NOT NULL,[PorcentajePesoEspMin] [float] NULL,[PorcentajePesoEspMax] [float] NULL,[deduccion] [float] NULL,PRIMARY KEY CLUSTERED ([id_PesoEsp] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando7 As New SqlCommand(Query7, conexion)
            comando7.ExecuteNonQuery()
            'Tabla Calidad Punta Negra---
            Dim Query8 As String = "CREATE TABLE [dbo].[CalidadPuntaNeg]([id_PuntaNeg] [int] IDENTITY(1,1) NOT NULL,[PorcentajePuntaNegMin] [float] NULL,[PorcentajePuntaNegMax] [float] NULL,[deduccion] [float] NULL,PRIMARY KEY CLUSTERED ([id_PuntaNeg] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando8 As New SqlCommand(Query8, conexion)
            comando8.ExecuteNonQuery()
            'Tabla Centro Acopio---
            Dim Query9 As String = "CREATE TABLE [dbo].[CentroAcopio]([Id_CentroAcopio] [varchar](10) NOT NULL,[NombreCentro] [varchar](50) NULL,[FolioAserca] [varchar](11) NULL,[Calle] [varchar](50) NULL,[Numero] [numeric](6, 0) NULL,[Colonia] [varchar](50) NULL,[codigoPostal] [varchar](6) NULL,[ciudad] [varchar](50) NULL,[estado] [varchar](35) NULL,[CapacidadMax] [float] NULL,CONSTRAINT [PK__CentroAc__6DCED4DC4250068C] PRIMARY KEY CLUSTERED ([Id_CentroAcopio] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando9 As New SqlCommand(Query9, conexion)
            comando9.ExecuteNonQuery()
            'Tabla Certificado Calidad---
            Dim Query10 As String = "CREATE TABLE [dbo].[Certificado_Calidad]([Humedad] [numeric](2, 2) NULL,[Impureza] [numeric](2, 2) NULL,[Granos_Dañados] [numeric](2, 2) NULL,[Peso_Especifico] [numeric](3, 2) NULL,[Total_Deducciones] [numeric](3, 2) NULL,[Porcentaje_Pb] [numeric](3, 2) NULL) ON [PRIMARY]"
            Dim comando10 As New SqlCommand(Query10, conexion)
            comando10.ExecuteNonQuery()
            'Tabla Ciudades---
            Dim Query11 As String = "CREATE TABLE [dbo].[Ciudades]([Id_Ciudad] [varchar](10) NOT NULL,[Nombre_Ciudad] [varchar](50) NULL,[Descripcion] [varchar](150) NULL,PRIMARY KEY CLUSTERED ([Id_Ciudad] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando11 As New SqlCommand(Query11, conexion)
            comando11.ExecuteNonQuery()
            'Tabla Clientes---
            Dim Query12 As String = "CREATE TABLE [dbo].[Clientes]([Id_Cliente] [varchar](10) NOT NULL,[Nombre_Persona] [varchar](100) NULL,[Apellidos_Persona] [varchar](100) NULL,[Razon_Social] [varchar](100) NULL,[RFC_Cliente] [varchar](13) NULL,[Tipo_Persona] [varchar](1) NULL,[CURP_Cliente] [varchar](18) NULL,[Tipo_Identificacion] [varchar](18) NULL,[Identificacion_Cliente] [varchar](16) NULL,[Calle_Cliente] [varchar](50) NULL,[Numero_Domicilio] [varchar](6) NULL,[Colonia_Cliente] [varchar](50) NULL,[CPostal_Cliente] [varchar](5) NULL,[Ciudad_Cliente] [varchar](20) NULL,[Estado_Cliente] [varchar](20) NULL,[Telefono_Cliente] [varchar](13) NULL,[Celular_Cliente] [varchar](13) NULL,[Correo_Electronico] [varchar](max) NULL,[Fecha_Inicio_Operaciones] [datetime] NULL,[Folio_Acta_Cons] [int] NULL,[Fecha_Constitucion] [datetime] NULL,[Numero_Notario] [int] NULL,[Registro_Publico] [int] NULL,[Bajo_Numero_RPP] [int] NULL,[Folio_RPP] [int] NULL,[Libro_RPP] [int] NULL,[Folio_Mercantil_Elec] [varchar](10) NULL,[Fecha_FME] [datetime] NULL,[Representante_Legal] [varchar](10) NULL,PRIMARY KEY CLUSTERED ([Id_Cliente] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]"
            Dim comando12 As New SqlCommand(Query12, conexion)
            comando12.ExecuteNonQuery()
            'Tabla Colonias---
            Dim Query13 As String = "CREATE TABLE [dbo].[Colonias]([Id_Colonia] [varchar](10) NOT NULL,[Nombre_Colonia] [varchar](45) NULL,[Descripcion] [varchar](50) NULL,[Max_Ton_X_Ha] [float] NULL,[CP_Colonia] [varchar](5) NULL,PRIMARY KEY CLUSTERED ([Id_Colonia] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando13 As New SqlCommand(Query13, conexion)
            comando13.ExecuteNonQuery()
            'Tabla Compradores---
            Dim Query14 As String = "CREATE TABLE [dbo].[Compradores]([Id_Comprador] [varchar](10) NOT NULL,[Nombre_Comprador] [varchar](70) NULL,[RFC_Comprador] [varchar](13) NULL,[Calle_Comprador] [varchar](50) NULL,[Numero_Dom_Comprador] [varchar](5) NULL,[Colonia_Comprador] [varchar](50) NULL,[Ciudad_Comprador] [varchar](20) NULL,[Estado_Comprador] [varchar](20) NULL,[Codigo_Postal] [varchar](5) NULL,[Persona_Contacto] [varchar](70) NULL,[Telefono_Comprador] [varchar](13) NULL,[Celular_Comprador] [varchar](13) NULL,[Correo_Electronico] [varchar](max) NULL,PRIMARY KEY CLUSTERED ([Id_Comprador] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]"
            Dim comando14 As New SqlCommand(Query14, conexion)
            comando14.ExecuteNonQuery()
            'Tabla Conductores---
            Dim Query15 As String = "CREATE TABLE [dbo].[Conductores]([Id_Conductor] [varchar](10) NOT NULL,[Nombre_Conductor] [varchar](50) NULL,[Celular_Conductor] [varchar](13) NULL,PRIMARY KEY CLUSTERED ([Id_Conductor] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando15 As New SqlCommand(Query15, conexion)
            comando15.ExecuteNonQuery()
            'Tabla Contrato Compradores---
            Dim Query16 As String = "CREATE TABLE [dbo].[ContratosCompradores]([id_contrato] [varchar](10) NOT NULL,[fechaAlta] [date] NULL,[id_comprador] [varchar](10) NULL,[ToneladasContratadas] [float] NULL,[ToneladasSalidas] [float] NULL,[ToneladasLibresSalidas] [float] NULL,[precioXtonelada] [money] NULL,[id_Temporada] [varchar](10) NULL,[fechaLiquidacion] [date] NULL,[productoresSeleccionados] [varchar](max) NULL,[ToneladasAsignadas] [float] NULL,PRIMARY KEY CLUSTERED ([id_contrato] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]"
            Dim comando16 As New SqlCommand(Query16, conexion)
            comando16.ExecuteNonQuery()
            'Tabla Contratos Compras---
            Dim Query17 As String = "CREATE TABLE [dbo].[contratosCompras]([Id_ContratoC] [varchar](10) NOT NULL,[fechaAlta] [date] NULL,[Id_Cliente] [varchar](10) NULL,[toneladasCompras] [float] NULL,[toneladasEntradas] [float] NULL,[toneladaslibresEntradas] [float] NULL,[SuperficieComprometida] [float] NULL,[precioXtonelada] [money] NULL,[id_Temporada] [date] NULL,[fechaLiquidacion] [date] NULL,[lotesSeleccionados] [varchar](200) NULL,[AceptaContratoLibre] [int] NULL,[ToneladasRestanteE] [float] NULL,[Observaciones] [varchar](300) NULL,[Empresa] [varchar](70) NULL,[ApoderadoLegal] [varchar](70) NULL,[CentroAcopio] [varchar](70) NULL,[moneda] [int] NULL,[IdEstatusContrato] [int] NULL DEFAULT ((0)),PRIMARY KEY CLUSTERED ([Id_ContratoC] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando17 As New SqlCommand(Query17, conexion)
            comando17.ExecuteNonQuery()
            'Tabla Contratos Ventas---
            Dim Query18 As String = "CREATE TABLE [dbo].[contratosVentas]([Id_ContratoV] [varchar](10) NOT NULL,[fechaAlta] [date] NULL,[Id_Comprador] [varchar](10) NULL,[toneladasVentas] [varchar](10) NULL,[precioXtonelada] [varchar](10) NULL,[id_Temporada] [varchar](10) NULL,[fechaLiquidacion] [date] NULL,[moneda] [int] NULL,[TipoContrato] [int] NULL,[ToneladasRestantes] [float] NULL,[EstatusContrato] [int] NULL,[CodigoSiap] [varchar](20) NULL,[CodigoSap] [varchar](20) NULL,[CodigoAserca] [varchar](35) NULL,PRIMARY KEY CLUSTERED ([Id_ContratoV] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando18 As New SqlCommand(Query18, conexion)
            comando18.ExecuteNonQuery()
            'Tabla Control Embarques---
            Dim Query19 As String = "CREATE TABLE [dbo].[ControlEmbarques]([id_embarque] [varchar](10) NOT NULL,[numeroBoleta] [int] NULL,[nombreProductor] [varchar](10) NULL,[domicilioProductor] [varchar](200) NULL,[grupoGrano] [varchar](15) NULL,[lugarExpedicion] [varchar](50) NULL,[Fecha_Pesaje] [date] NULL,[Bruto] [decimal](10, 5) NULL,[Tara] [decimal](10, 5) NULL,[Neto] [decimal](10, 5) NULL,[humedad] [decimal](5, 2) NULL,[kilosXtonHum] [decimal](5, 2) NULL,[impurezas] [decimal](5, 2) NULL,[KilosXtonImp] [decimal](5, 2) NULL,[puntaNegra] [float] NULL,[KilosXtonPuNe] [float] NULL,[granoContraste] [float] NULL,[KilosXtonCon] [float] NULL,[granoDanado] [decimal](5, 2) NULL,[KilosXtonGrDa] [decimal](5, 2) NULL,[pesoEspecifico] [decimal](5, 2) NULL,[KilosXtonPeEs] [decimal](5, 2) NULL,[porcentajePB] [float] NULL,[KilosXtonPaBl] [float] NULL,[granoQuebrado] [decimal](5, 2) NULL,[KilosXtonGrQu] [decimal](5, 2) NULL,[Deducciones] [decimal](10, 5) NULL,[Total] [decimal](10, 5) NULL,[Id_CentroAcopio] [varchar](10) NULL,[id_almacen] [varchar](10) NULL,[contratoComprador] [varchar](10) NULL,[conductorCam] [varchar](70) NULL,[placasConductor] [varchar](13) NULL,[usuarioAnalista] [varchar](10) NULL,[LoteEmbarque] [varchar](50) NULL,[Estado] [int] NULL,[TotalXliquidar] [decimal](10, 5) NULL,CONSTRAINT [PK__ControlE__F092A715ABDBDD2B] PRIMARY KEY CLUSTERED ([id_embarque] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando19 As New SqlCommand(Query19, conexion)
            comando19.ExecuteNonQuery()
            'Tabla Control Entradas---
            Dim Query20 As String = "CREATE TABLE [dbo].[ControlEntradas]([id_entrada] [varchar](10) NOT NULL,[numeroBoleta] [int] NULL,[nombreProductor] [varchar](10) NULL,[domicilioProductor] [varchar](200) NULL,[grupoGrano] [varchar](15) NULL,[lugarExpedicion] [varchar](50) NULL,[Fecha_Pesaje] [date] NULL,[Bruto] [decimal](10, 5) NULL,[Tara] [decimal](10, 5) NULL,[Neto] [decimal](10, 5) NULL,[humedad] [decimal](5, 2) NULL,[kilosXtonHum] [float] NULL,[impurezas] [decimal](5, 2) NULL,[KilosXtonImp] [float] NULL,[granoDanado] [decimal](5, 2) NULL,[KilosXtonGrDa] [float] NULL,[pesoEspecifico] [decimal](5, 2) NULL,[KilosXtonPeEs] [float] NULL,[granoQuebrado] [decimal](5, 2) NULL,[KilosXtonGrQu] [float] NULL,[PuntaNegra] [decimal](5, 2) NULL,[KilosXtonPuNe] [float] NULL,[PanzaBlanca] [decimal](5, 2) NULL,[KilosXtonPaBl] [float] NULL,[Deducciones] [decimal](10, 5) NULL,[Total] [decimal](10, 5) NULL,[Id_CentroAcopio] [varchar](10) NULL,[id_almacen] [varchar](10) NULL,[contratoComprador] [varchar](10) NULL,[conductorCam] [varchar](70) NULL,[placasConductor] [varchar](13) NULL,[usuarioAnalista] [varchar](10) NULL,[Estado] [int] NULL,[LoteEntrada] [varchar](50) NULL,[TotalXliquidar] [decimal](10, 5) NULL,CONSTRAINT [PK__ControlE__167CD61B65D0F932] PRIMARY KEY CLUSTERED ([id_entrada] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando20 As New SqlCommand(Query20, conexion)
            comando20.ExecuteNonQuery()
            'Tabla Control Salidas---
            Dim Query21 As String = "CREATE TABLE [dbo].[ControlSalidas]([id_salida] [varchar](10) NOT NULL,[numeroBoleta] [int] NULL,[nombreVendedor] [varchar](10) NULL,[domicilioProductor] [varchar](200) NULL,[grupoGrano] [varchar](15) NULL,[lugarExpedicion] [varchar](50) NULL,[Fecha_Pesaje] [date] NULL,[Bruto] [decimal](10, 5) NULL,[Tara] [decimal](10, 5) NULL,[Neto] [decimal](10, 5) NULL,[humedad] [float] NULL,[kilosXtonHum] [float] NULL,[impurezas] [float] NULL,[KilosXtonImp] [float] NULL,[puntaNegra] [float] NULL,[KilosXtonPuNe] [float] NULL,[granoContraste] [float] NULL,[KilosXtonCon] [float] NULL,[granoDanado] [float] NULL,[KilosXtonGrDa] [float] NULL,[pesoEspecifico] [float] NULL,[KilosXtonPeEs] [float] NULL,[porcentajePB] [float] NULL,[KilosXtonPaBl] [float] NULL,[granoQuebrado] [float] NULL,[KilosXtonGrQu] [float] NULL,[Deducciones] [decimal](10, 5) NULL,[Total] [decimal](10, 5) NULL,[Id_CentroAcopio] [varchar](10) NULL,[id_almacen] [varchar](10) NULL,[contratoComprador] [varchar](10) NULL,[conductorCam] [varchar](70) NULL,[placasConductor] [varchar](13) NULL,[usuarioAnalista] [varchar](10) NULL,[Estado] [int] NULL,[TotalPorLiquidar] [decimal](7, 5) NULL,CONSTRAINT [PK__ControlS__167CD61B92B95223] PRIMARY KEY CLUSTERED ([id_salida] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando21 As New SqlCommand(Query21, conexion)
            comando21.ExecuteNonQuery()
            'Tabla Empresas---
            Dim Query22 As String = "CREATE TABLE [dbo].[Empresas]([Id_Empresa] [varchar](10) NOT NULL,[NombrePersona] [varchar](100) NULL,[ApellidosPersona] [varchar](100) NULL,[RazonSocial] [varchar](100) NULL,[RFC] [varchar](13) NULL,[TipoPersona] [varchar](1) NULL,[CURP] [varchar](18) NULL,[TipoIdentificacion] [varchar](18) NULL,[IdentificacionRepresentante] [varchar](16) NULL,[Calle] [varchar](50) NULL,[NumeroDomicilio] [varchar](6) NULL,[Colonia] [varchar](50) NULL,[CPostal] [varchar](5) NULL,[Ciudad] [varchar](20) NULL,[Estado] [varchar](20) NULL,[Telefono] [varchar](13) NULL,[Celular] [varchar](13) NULL,[CorreoElectronico] [varchar](max) NULL,[Fecha_Inicio_Operaciones] [datetime] NULL,[Folio_Acta_Cons] [int] NULL,[FechaConstitucion] [datetime] NULL,[NumeroNotario] [int] NULL,[RegistroPublico] [int] NULL,[Bajo_Numero_RPP] [int] NULL,[FolioRPP] [int] NULL,[LibroRPP] [int] NULL,[FolioMercantil_Elec] [varchar](10) NULL,[FechaFME] [datetime] NULL,[Representante_Legal] [varchar](10) NULL,PRIMARY KEY CLUSTERED ([Id_Empresa] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]"
            Dim comando22 As New SqlCommand(Query22, conexion)
            comando22.ExecuteNonQuery()
            'Tabla Grupos---
            Dim Query23 As String = "CREATE TABLE [dbo].[Grupos]([Id_Grupo] [varchar](10) NOT NULL,[Descripcion] [varchar](100) NULL,[Nombre] [varchar](100) NULL,PRIMARY KEY CLUSTERED ([Id_Grupo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando23 As New SqlCommand(Query23, conexion)
            comando23.ExecuteNonQuery()
            'Tabla LiquidacionesXproductor ---
            Dim Query24 As String = "CREATE TABLE [dbo].[LiquidacionesXproductor]([idLiquidacionP] [varchar](10) NOT NULL,[idInventario] [varchar](10) NULL,[numeroBoleta] [int] NULL,[idProductor] [varchar](10) NULL,[nombreProductor] [varchar](120) NULL,[grupoGrano] [varchar](15) NULL,[Neto] [decimal](7, 5) NULL,[deduccion] [decimal](7, 5) NULL,[Total] [decimal](7, 5) NULL,[moneda] [int] NULL,[idLiquidacionT] [varchar](10) NULL,PRIMARY KEY CLUSTERED ([idLiquidacionP] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando24 As New SqlCommand(Query24, conexion)
            comando24.ExecuteNonQuery()
            'Tabla LiquidacionTotalXprod---
            Dim Query25 As String = "CREATE TABLE [dbo].[LiquidacionTotalXprod]([idLiquidacionT] [varchar](10) NOT NULL,[idcontrato] [varchar](10) NULL,[idproductor] [varchar](10) NULL,[grupoGrano] [varchar](15) NULL,[fechaliquidacion] [date] NULL,[totalliquidacionContrato] [float] NULL,[totalliquidacionLibre] [float] NULL,[tipodecambio] [float] NULL,[precioContrato] [float] NULL,[moneda] [int] NULL,[precioXtonMxn] [float] NULL,[importeTotal] [float] NULL,[contrato] [varchar](40) NULL,[metodoPago] [varchar](30) NULL,[banco] [varchar](30) NULL,[ultimosDigitos] [varchar](4) NULL,[importeLetra] [varchar](100) NULL,[Idcomprador] [varchar](10) NULL,[tipoContrato] [varchar](8) NULL,[IdTipoLiquidacion] [int] NOT NULL DEFAULT ((0)),PRIMARY KEY CLUSTERED ([idLiquidacionT] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando25 As New SqlCommand(Query25, conexion)
            comando25.ExecuteNonQuery()
            'Tabla Lotes Seleccion---
            Dim Query26 As String = "CREATE TABLE [dbo].[LotesSeleccion]([idSeleccionados] [varchar](10) NOT NULL,[idproductor] [varchar](10) NULL,[idtierra] [varchar](10) NULL,[Idcontrato] [varchar](10) NULL) ON [PRIMARY]"
            Dim comando26 As New SqlCommand(Query26, conexion)
            comando26.ExecuteNonQuery()
            'Tabla Monedas---
            Dim Query27 As String = "CREATE TABLE [dbo].[Moneda]([idMoneda] [int] IDENTITY(1,1) NOT NULL,[nombreMoneda] [varchar](8) NULL,[tipo] [varchar](3) NULL,PRIMARY KEY CLUSTERED ([idMoneda] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando27 As New SqlCommand(Query27, conexion)
            comando27.ExecuteNonQuery()
            'Tabla ParametrosCalidad---
            Dim Query28 As String = "CREATE TABLE [dbo].[ParametrosCalidad]([idCalidad] [int] IDENTITY(1,1) NOT NULL,[NombreParametros] [varchar](16) NULL,[MinimoDeduccion] [float] NULL,[MaximoDeduccion] [float] NULL,PRIMARY KEY CLUSTERED ([idCalidad] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando28 As New SqlCommand(Query28, conexion)
            comando28.ExecuteNonQuery()
            'Tabla Pesaje---
            Dim Query29 As String = "CREATE TABLE [dbo].[Pesaje]([Fecha_Pesaje] [date] NULL,[Bruto] [numeric](10, 2) NULL,[Tara] [numeric](10, 2) NULL,[Neto] [numeric](10, 2) NULL,[Deducciones] [numeric](10, 2) NULL,[Peso_Neto] [numeric](10, 2) NULL) ON [PRIMARY]"
            Dim comando29 As New SqlCommand(Query29, conexion)
            comando29.ExecuteNonQuery()
            'Tabla productoresSeleccionC---
            Dim Query30 As String = "CREATE TABLE [dbo].[productoresSeleccionC]([id_Seleccion] [varchar](10) NOT NULL,[id_tierra] [varchar](10) NULL,[id_contratoC] [varchar](10) NULL,[id_cliente] [varchar](10) NULL,[nombre] [varchar](70) NULL,[toneladasSelect] [float] NULL,[id_compradorC] [varchar](10) NULL,PRIMARY KEY CLUSTERED ([id_Seleccion] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando30 As New SqlCommand(Query30, conexion)
            comando30.ExecuteNonQuery()
            'Tabla Silos---
            Dim Query31 As String = "CREATE TABLE [dbo].[Silos]([Id_Silo] [varchar](10) NOT NULL,[tipoSilo] [varchar](12) NULL,CONSTRAINT [PK__SILOS__F2F76C172B8776D6] PRIMARY KEY CLUSTERED ([Id_Silo] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando31 As New SqlCommand(Query31, conexion)
            comando31.ExecuteNonQuery()
            'Tabla solicitudesCompra---
            Dim Query32 As String = "CREATE TABLE [dbo].[solicitudesCompra]([id_solicitud] [varchar](10) NOT NULL,[NombreProductor] [varchar](70) NULL,[tipoPersona] [varchar](1) NULL,[nombreRepresentante] [varchar](70) NULL,[Predio] [varchar](15) NULL,[folioPredio] [varchar](12) NULL,[superficie] [float] NULL,[rfc] [varchar](13) NULL,[curp] [varchar](18) NULL,[empresa] [varchar](70) NULL,[apoderado] [varchar](70) NULL,[centroacopio] [varchar](50) NULL,CONSTRAINT [PK_solicitudesCompra] PRIMARY KEY CLUSTERED ([id_solicitud] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando32 As New SqlCommand(Query32, conexion)
            comando32.ExecuteNonQuery()
            'Tabla Temporadas---
            Dim Query33 As String = "CREATE TABLE [dbo].[Temporadas]([IdTemporada] [varchar](10) NOT NULL,[Temporada] [varchar](4) NULL,[estadoTemporada] [int] NULL,PRIMARY KEY CLUSTERED ([IdTemporada] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando33 As New SqlCommand(Query33, conexion)
            comando33.ExecuteNonQuery()
            'Tabla Tierras---
            Dim Query34 As String = "CREATE TABLE [dbo].[Tierras]([Id_Tierra] [varchar](10) NOT NULL,[Numero_Lote] [varchar](10) NULL,[Colonia] [varchar](10) NULL,[Id_Propietario] [varchar](10) NULL,[Folio_Lote] [varchar](13) NULL,[Superficie_Total] [float] NULL,[Superficie_Cultivable_total] [float] NULL,[Superficie_Cultivable_restante] [float] NULL,[Volumen] [float] NULL,[Latitud_Grados] [int] NULL,[Latitud_Horas] [int] NULL,[Latitud_Minutos] [decimal](18, 0) NULL,[Longitud_Grados] [int] NULL,[Longitud_Horas] [int] NULL,[Longitud_Minutos] [decimal](18, 0) NULL,[Numero_RPP] [int] NULL,[Folio_RPP] [int] NULL,[Libro_RPP] [int] NULL,[Fecha_RPP] [date] NULL,[Titulo_Agua] [varchar](15) NULL,[Regimen_Hidrico] [varchar](12) NULL,[Fecha_Titulo_Agua] [date] NULL,[Hectareas_prometidas] [float] NULL,[Hectareas_promRestante] [float] NULL,[Rendimiento] [float] NULL,[id_productor] [varchar](10) NULL,PRIMARY KEY CLUSTERED ([Id_Tierra] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando34 As New SqlCommand(Query34, conexion)
            comando34.ExecuteNonQuery()
            'Tabla Tipo_Usuario---
            Dim Query35 As String = "CREATE TABLE [dbo].[Tipo_Usuario]([Id_TipoUsuario] int] NOT NULL,[Nombre_tipoUsuario] [varchar](15) NULL,PRIMARY KEY CLUSTERED ([Id_TipoUsuario] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando35 As New SqlCommand(Query35, conexion)
            comando35.ExecuteNonQuery()
            'Tabla TipoLiquidacion---
            Dim Query36 As String = "CREATE TABLE [dbo].[TipoLiquidacion]([IdTipoLiquidacion] [int] IDENTITY(1,1) NOT NULL,[Descripcion] [varchar](20) NOT NULL,[Valor] [int] NOT NULL,PRIMARY KEY CLUSTERED ([IdTipoLiquidacion] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando36 As New SqlCommand(Query36, conexion)
            comando36.ExecuteNonQuery()
            'Tabla Unidades_Transporte---
            Dim Query37 As String = "CREATE TABLE [dbo].[Unidades_Transporte]([Id_Transporte] [varchar](10) NOT NULL,[Tipo] [varchar](15) NULL,[Placas] [varchar](12) NULL,[Id_Conductor] [varchar](10) NULL,PRIMARY KEY CLUSTERED ([Id_Transporte] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando37 As New SqlCommand(Query37, conexion)
            comando37.ExecuteNonQuery()
            'Tabla Usuarios---
            Dim Query38 As String = "CREATE TABLE [dbo].[Usuarios]([Id_Usuario] [varchar](10) NOT NULL,[Nombre] [varchar](50) NULL,[Usuario] [varchar](15) NULL,[Clave] [varchar](10) NULL,[Tipo] [int] NULL) ON [PRIMARY] SET ANSI_PADDING ON ALTER TABLE [dbo].[Usuarios] ADD [ClaveAutorizacion] [varchar](4) NULL PRIMARY KEY CLUSTERED ([Id_Usuario] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"
            Dim comando38 As New SqlCommand(Query38, conexion)
            comando38.ExecuteNonQuery()
            'Tabla Variedades---
            Dim Query39 As String = "CREATE TABLE [dbo].[Variedades]([Id_Variedad] [varchar](10) NOT NULL,[Nombre_Variedad] [varchar](20) NULL,[Descripcion] [varchar](50) NULL,[Caracteristicas] [varchar](max) NULL,PRIMARY KEY CLUSTERED ([Id_Variedad] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]"
            Dim comando39 As New SqlCommand(Query39, conexion)
            comando39.ExecuteNonQuery()
            'Tabla VentaComprador---
            Dim Query40 As String = "CREATE TABLE [dbo].[VentaComprador]([IdVentaComprador] [varchar](10) NOT NULL,[IdSalida] [varchar](10) NULL,[NumeroBoleta] [int] NULL,[IdComprador] [varchar](10) NULL,[NombreComprador] [varchar](120) NULL,[GrupoGrano] [varchar](15) NULL,[Neto] [decimal](7, 5) NULL,[Deduccion] [decimal](7, 5) NULL,[Total] [decimal](7, 5) NULL,[moneda] [int] NULL,[IdVentaTotalComprador] [varchar](10) NULL,PRIMARY KEY CLUSTERED ([IdVentaComprador] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando40 As New SqlCommand(Query40, conexion)
            comando40.ExecuteNonQuery()
            'Tabla VentaTotalComprador---
            Dim Query41 As String = "CREATE TABLE [dbo].[VentaTotalComprador]([IdVentaTotalComprador] [varchar](10) NOT NULL,[IdContratoVenta] [varchar](10) NULL,[Idcomprador] [varchar](10) NULL,[GrupoGrano] [varchar](15) NULL,[FechaVenta] [date] NULL,[TotalVentaContrato] [float] NULL,[TipoDeCambio] [float] NULL,[PrecioContrato] [float] NULL,[Moneda] [int] NULL,[PrecioToneladaMxn] [float] NULL,[ImporteTotal] [float] NULL,[Contrato] [varchar](40) NULL,[MetodoPago] [varchar](30) NULL,[Banco] [varchar](30) NULL,[UltimosDigitos] [varchar](4) NULL,[ImporteLetra] [varchar](100) NULL,[IdEmpresa] [varchar](10) NULL,[IdTipoLiquidacion] [int] NULL,PRIMARY KEY CLUSTERED ([IdVentaTotalComprador] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            Dim comando41 As New SqlCommand(Query41, conexion)
            comando41.ExecuteNonQuery()
            '---LLAVES FORANEAS--------------
            Dim Query42 As String = "ALTER TABLE [dbo].[Almacen]  WITH CHECK ADD  CONSTRAINT [FK_Almacen_CentroAcopio] FOREIGN KEY([id_Acopio]) REFERENCES [dbo].[CentroAcopio]([Id_CentroAcopio])"
            Dim comando42 As New SqlCommand(Query42, conexion)
            comando42.ExecuteNonQuery()

            Dim Query43 As String = "ALTER TABLE [dbo].[Almacen] CHECK CONSTRAINT [FK_Almacen_CentroAcopio]"
            Dim comando43 As New SqlCommand(Query43, conexion)
            comando43.ExecuteNonQuery()

            Dim Query44 As String = "ALTER TABLE [dbo].[Almacen]  WITH CHECK ADD  CONSTRAINT [FK_Almacen_Silos] FOREIGN KEY([tipoSilo]) REFERENCES [dbo].[Silos] ([Id_Silo])"
            Dim comando44 As New SqlCommand(Query44, conexion)
            comando44.ExecuteNonQuery()

            Dim Query45 As String = "ALTER TABLE [dbo].[Almacen] CHECK CONSTRAINT [FK_Almacen_Silos]"
            Dim comando45 As New SqlCommand(Query45, conexion)
            comando45.ExecuteNonQuery()

            Dim Query46 As String = "ALTER TABLE [dbo].[ContratosCompradores]  WITH CHECK ADD  CONSTRAINT [FK_ContratosCompradores_Compradores] FOREIGN KEY([id_comprador])REFERENCES [dbo].[Compradores] ([Id_Comprador])"
            Dim comando46 As New SqlCommand(Query46, conexion)
            comando46.ExecuteNonQuery()

            Dim Query47 As String = "ALTER TABLE [dbo].[ContratosCompradores] CHECK CONSTRAINT [FK_ContratosCompradores_Compradores]"
            Dim comando47 As New SqlCommand(Query47, conexion)
            comando47.ExecuteNonQuery()

            Dim Query48 As String = "ALTER TABLE [dbo].[contratosCompras]  WITH CHECK ADD  CONSTRAINT [FK_contratosCompras_CLIENTES1] FOREIGN KEY([Id_Cliente])REFERENCES [dbo].[Clientes] ([Id_Cliente])"
            Dim comando48 As New SqlCommand(Query48, conexion)
            comando48.ExecuteNonQuery()

            Dim Query49 As String = "ALTER TABLE [dbo].[contratosCompras] CHECK CONSTRAINT [FK_contratosCompras_CLIENTES1]"
            Dim comando49 As New SqlCommand(Query49, conexion)
            comando49.ExecuteNonQuery()

            Dim Query50 As String = "ALTER TABLE [dbo].[contratosVentas]  WITH CHECK ADD  CONSTRAINT [FK_contratosVentas_Compradores] FOREIGN KEY([Id_Comprador])REFERENCES [dbo].[Compradores] ([Id_Comprador])"
            Dim comando50 As New SqlCommand(Query50, conexion)
            comando50.ExecuteNonQuery()

            Dim Query51 As String = "ALTER TABLE [dbo].[contratosVentas] CHECK CONSTRAINT [FK_contratosVentas_Compradores]"
            Dim comando51 As New SqlCommand(Query51, conexion)
            comando51.ExecuteNonQuery()

            Dim Query52 As String = "ALTER TABLE [dbo].[ControlEmbarques]  WITH CHECK ADD  CONSTRAINT [FK_ControlEmbarques_CentroAcopio] FOREIGN KEY([Id_CentroAcopio])REFERENCES [dbo].[CentroAcopio] ([Id_CentroAcopio])"
            Dim comando52 As New SqlCommand(Query52, conexion)
            comando52.ExecuteNonQuery()

            Dim Query53 As String = "ALTER TABLE [dbo].[ControlEmbarques] CHECK CONSTRAINT [FK_ControlEmbarques_CentroAcopio]"
            Dim comando53 As New SqlCommand(Query53, conexion)
            comando53.ExecuteNonQuery()

            Dim Query54 As String = "ALTER TABLE [dbo].[ControlEmbarques]  WITH CHECK ADD  CONSTRAINT [FK_ControlEmbarques_contratosVentas] FOREIGN KEY([contratoComprador])REFERENCES [dbo].[contratosVentas] ([Id_ContratoV])"
            Dim comando54 As New SqlCommand(Query54, conexion)
            comando54.ExecuteNonQuery()

            Dim Query55 As String = "ALTER TABLE [dbo].[ControlEmbarques] CHECK CONSTRAINT [FK_ControlEmbarques_contratosVentas]"
            Dim comando55 As New SqlCommand(Query55, conexion)
            comando55.ExecuteNonQuery()

            Dim Query56 As String = "ALTER TABLE [dbo].[ControlEmbarques]  WITH CHECK ADD  CONSTRAINT [FK_ControlEmbarques_Usuarios] FOREIGN KEY([usuarioAnalista])REFERENCES [dbo].[Usuarios] ([Id_Usuario])"
            Dim comando56 As New SqlCommand(Query56, conexion)
            comando56.ExecuteNonQuery()

            Dim Query57 As String = "ALTER TABLE [dbo].[ControlEmbarques] CHECK CONSTRAINT [FK_ControlEmbarques_Usuarios]"
            Dim comando57 As New SqlCommand(Query57, conexion)
            comando57.ExecuteNonQuery()

            Dim Query58 As String = "ALTER TABLE [dbo].[ControlEntradas]  WITH CHECK ADD  CONSTRAINT [FK_ControlEntradas_CentroAcopio] FOREIGN KEY([Id_CentroAcopio])REFERENCES [dbo].[CentroAcopio] ([Id_CentroAcopio])"
            Dim comando58 As New SqlCommand(Query58, conexion)
            comando58.ExecuteNonQuery()

            Dim Query59 As String = "ALTER TABLE [dbo].[ControlEntradas] CHECK CONSTRAINT [FK_ControlEntradas_CentroAcopio]"
            Dim comando59 As New SqlCommand(Query59, conexion)
            comando59.ExecuteNonQuery()

            Dim Query60 As String = "ALTER TABLE [dbo].[ControlSalidas]  WITH CHECK ADD  CONSTRAINT [FK_ControlSalidas_CentroAcopio] FOREIGN KEY([Id_CentroAcopio])REFERENCES [dbo].[CentroAcopio] ([Id_CentroAcopio])"
            Dim comando60 As New SqlCommand(Query60, conexion)
            comando60.ExecuteNonQuery()

            Dim Query61 As String = "ALTER TABLE [dbo].[ControlSalidas] CHECK CONSTRAINT [FK_ControlSalidas_CentroAcopio]"
            Dim comando61 As New SqlCommand(Query61, conexion)
            comando61.ExecuteNonQuery()

            Dim Query62 As String = "ALTER TABLE [dbo].[ControlSalidas]  WITH CHECK ADD  CONSTRAINT [FK_ControlSalidas_contratosVentas] FOREIGN KEY([contratoComprador])REFERENCES [dbo].[contratosVentas] ([Id_ContratoV])"
            Dim comando62 As New SqlCommand(Query62, conexion)
            comando62.ExecuteNonQuery()

            Dim Query63 As String = "ALTER TABLE [dbo].[ControlSalidas] CHECK CONSTRAINT [FK_ControlSalidas_contratosVentas]"
            Dim comando63 As New SqlCommand(Query63, conexion)
            comando63.ExecuteNonQuery()

            Dim Query64 As String = "ALTER TABLE [dbo].[ControlSalidas]  WITH CHECK ADD  CONSTRAINT [FK_ControlSalidas_Empresas1] FOREIGN KEY([nombreVendedor])REFERENCES [dbo].[Empresas] ([Id_Empresa])"
            Dim comando64 As New SqlCommand(Query64, conexion)
            comando64.ExecuteNonQuery()

            Dim Query65 As String = "ALTER TABLE [dbo].[ControlSalidas] CHECK CONSTRAINT [FK_ControlSalidas_Empresas1]"
            Dim comando65 As New SqlCommand(Query65, conexion)
            comando65.ExecuteNonQuery()

            Dim Query66 As String = "ALTER TABLE [dbo].[ControlSalidas]  WITH CHECK ADD  CONSTRAINT [FK_ControlSalidas_Usuarios] FOREIGN KEY([usuarioAnalista])REFERENCES [dbo].[Usuarios] ([Id_Usuario])"
            Dim comando66 As New SqlCommand(Query66, conexion)
            comando66.ExecuteNonQuery()

            Dim Query67 As String = "ALTER TABLE [dbo].[ControlSalidas] CHECK CONSTRAINT [FK_ControlSalidas_Usuarios]"
            Dim comando67 As New SqlCommand(Query67, conexion)
            comando67.ExecuteNonQuery()

            Dim Query68 As String = "ALTER TABLE [dbo].[productoresSeleccionC]  WITH CHECK ADD  CONSTRAINT [FK_productoresSeleccionC_ContratosCompradores] FOREIGN KEY([id_compradorC])REFERENCES [dbo].[ContratosCompradores] ([id_contrato])"
            Dim comando68 As New SqlCommand(Query68, conexion)
            comando68.ExecuteNonQuery()

            Dim Query69 As String = "ALTER TABLE [dbo].[productoresSeleccionC] CHECK CONSTRAINT [FK_productoresSeleccionC_ContratosCompradores]"
            Dim comando69 As New SqlCommand(Query69, conexion)
            comando69.ExecuteNonQuery()

            Dim Query70 As String = "ALTER TABLE [dbo].[Tierras]  WITH CHECK ADD  CONSTRAINT [FK_Tierras_CLIENTES] FOREIGN KEY([Id_Propietario])REFERENCES [dbo].[Clientes] ([Id_Cliente])"
            Dim comando70 As New SqlCommand(Query70, conexion)
            comando70.ExecuteNonQuery()

            Dim Query71 As String = "ALTER TABLE [dbo].[Tierras] CHECK CONSTRAINT [FK_Tierras_CLIENTES]"
            Dim comando71 As New SqlCommand(Query71, conexion)
            comando71.ExecuteNonQuery()

            Dim Query72 As String = "ALTER TABLE [dbo].[Tierras]  WITH CHECK ADD  CONSTRAINT [FK_Tierras_COLONIAS] FOREIGN KEY([Colonia])REFERENCES [dbo].[Colonias] ([Id_Colonia])"
            Dim comando72 As New SqlCommand(Query72, conexion)
            comando72.ExecuteNonQuery()

            Dim Query73 As String = "ALTER TABLE [dbo].[Tierras] CHECK CONSTRAINT [FK_Tierras_COLONIAS]"
            Dim comando73 As New SqlCommand(Query73, conexion)
            comando73.ExecuteNonQuery()

            Dim Query74 As String = "ALTER TABLE [dbo].[Unidades_Transporte]  WITH CHECK ADD  CONSTRAINT [FK_UNIDADES_TRANSPORTE_Conductores1] FOREIGN KEY([Id_Conductor])REFERENCES [dbo].[Conductores] ([Id_Conductor])"
            Dim comando74 As New SqlCommand(Query74, conexion)
            comando74.ExecuteNonQuery()

            Dim Query75 As String = "ALTER TABLE [dbo].[Unidades_Transporte] CHECK CONSTRAINT [FK_UNIDADES_TRANSPORTE_Conductores1]"
            Dim comando75 As New SqlCommand(Query75, conexion)
            comando75.ExecuteNonQuery()

            Dim Query76 As String = "ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Tipo_Usuario] FOREIGN KEY([Tipo])REFERENCES [dbo].[Tipo_Usuario] ([Id_TipoUsuario])"
            Dim comando76 As New SqlCommand(Query76, conexion)
            comando76.ExecuteNonQuery()

            Dim Query77 As String = "ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Tipo_Usuario]"
            Dim comando77 As New SqlCommand(Query77, conexion)
            comando77.ExecuteNonQuery()
            '_LLENAR TABLAS BASICAS....
            Dim Query79 As String = "Insert into [dbo].[CalidadGranoDan] select porcentajeGranoMin,porcentajeGranoMax,deduccion from MAIZ.dbo.CalidadGranoDan"
            Dim comando79 As New SqlCommand(Query79, conexion)
            comando79.ExecuteNonQuery()

            Dim Query80 As String = "Insert into [dbo].[CalidadGranoQueb] select PorcentajeGranoQuebMin,PorcentajeGranoQuebMax,deduccion from MAIZ.dbo.CalidadGranoQueb"
            Dim comando80 As New SqlCommand(Query80, conexion)
            comando80.ExecuteNonQuery()

            Dim Query81 As String = "Insert into [dbo].[CalidadHumedad] select PorcentajeHumedadMin,PorcentajeHumedadMax,deduccion from MAIZ.dbo.CalidadHumedad"
            Dim comando81 As New SqlCommand(Query81, conexion)
            comando81.ExecuteNonQuery()

            Dim Query82 As String = "Insert into [dbo].[CalidadImpurezas] select PorcentajeImpurezaMin,PorcentajeImpurezaMax,deduccion from MAIZ.dbo.CalidadImpurezas"
            Dim comando82 As New SqlCommand(Query82, conexion)
            comando82.ExecuteNonQuery()

            Dim Query83 As String = "Insert into [dbo].[CalidadPesoEsp] select PorcentajePesoEspMin,PorcentajePesoEspMax,deduccion from MAIZ.dbo.CalidadPesoEsp"
            Dim comando83 As New SqlCommand(Query83, conexion)
            comando83.ExecuteNonQuery()

            Dim Query84 As String = "Insert into CentroAcopio select*from TRIGO.dbo.CentroAcopio"
            Dim comando84 As New SqlCommand(Query84, conexion)
            comando84.ExecuteNonQuery()

            Dim Query85 As String = "Insert into Ciudades select*from TRIGO.dbo.Ciudades"
            Dim comando85 As New SqlCommand(Query85, conexion)
            comando85.ExecuteNonQuery()

            Dim Query86 As String = "Insert into Clientes select*from TRIGO.dbo.Clientes"
            Dim comando86 As New SqlCommand(Query86, conexion)
            comando86.ExecuteNonQuery()

            Dim Query87 As String = "Insert into Colonias select*from TRIGO.dbo.Colonias"
            Dim comando87 As New SqlCommand(Query87, conexion)
            comando87.ExecuteNonQuery()

            Dim Query88 As String = "Insert into Compradores select*from TRIGO.dbo.Compradores"
            Dim comando88 As New SqlCommand(Query88, conexion)
            comando88.ExecuteNonQuery()

            Dim Query89 As String = "Insert into Empresas select*from TRIGO.dbo.Empresas"
            Dim comando89 As New SqlCommand(Query89, conexion)
            comando89.ExecuteNonQuery()

            Dim Query90 As String = "Insert into Moneda select nombreMoneda,tipo from TRIGO.dbo.Moneda"
            Dim comando90 As New SqlCommand(Query90, conexion)
            comando90.ExecuteNonQuery()

            Dim Query91 As String = "Insert into Silos select*from TRIGO.dbo.Silos"
            Dim comando91 As New SqlCommand(Query91, conexion)
            comando91.ExecuteNonQuery()

            Dim Query92 As String = "Insert into Temporadas select*from TRIGO.dbo.Temporadas"
            Dim comando92 As New SqlCommand(Query92, conexion)
            comando92.ExecuteNonQuery()

            Dim Query93 As String = "Insert into Tierras select*from TRIGO.dbo.Tierras"
            Dim comando93 As New SqlCommand(Query93, conexion)
            comando93.ExecuteNonQuery()

            Dim Query94 As String = "Insert into TipoLiquidacion select Descripcion,Valor from TRIGO.dbo.TipoLiquidacion"
            Dim comando94 As New SqlCommand(Query94, conexion)
            comando94.ExecuteNonQuery()

            Dim Query95 As String = "Insert into Tipo_Usuario select*from TRIGO.dbo.Tipo_Usuario"
            Dim comando95 As New SqlCommand(Query95, conexion)
            comando95.ExecuteNonQuery()

            Dim Query96 As String = "Insert into Usuarios select*from TRIGO.dbo.Usuarios"
            Dim comando96 As New SqlCommand(Query96, conexion)
            comando96.ExecuteNonQuery()

            Dim Query97 As String = "Insert into Almacen select*from TRIGO.dbo.Almacen"
            Dim comando97 As New SqlCommand(Query97, conexion)
            comando97.ExecuteNonQuery()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
