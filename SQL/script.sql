use [master]
go
create database [BD_MegaCable]
go
use [BD_MegaCable]
go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		CREATE TABLE [dbo].[T_Estados]
		(
			[ID_Estado] [char] (1) NOT NULL,			
			[Descripcion] [varchar](25) NOT NULL,
	
			CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
			(
				[ID_Estado] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Estados]
		ADD CONSTRAINT UC_Descripcion_Est UNIQUE ([Descripcion])
Go
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[T_Departamento]
		(
			[ID_Departamento] [int] IDENTITY(1,1) NOT NULL,			
			[Descripcion] [varchar](25) NOT NULL,
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
			(
				[ID_Departamento] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Departamento]
		ADD CONSTRAINT UC_Descripcion_Depar UNIQUE ([Descripcion])
GO

		ALTER TABLE [dbo].[T_Departamento]  WITH NOCHECK ADD  CONSTRAINT FK_Departamento_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		CREATE TABLE [dbo].[T_Region]
		(
			[ID_Region] [int] IDENTITY(1,1) NOT NULL,			
			[Descripcion] [varchar](25) NOT NULL,
			[Localizacion] [varchar](25) NOT NULL,
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_Region] PRIMARY KEY CLUSTERED 
			(
				[ID_Region] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Region]
		ADD CONSTRAINT UC_Descripcion_Region UNIQUE ([Descripcion])
GO
		ALTER TABLE [dbo].[T_Region]
		ADD CONSTRAINT UC_Localizacion_Region UNIQUE ([Localizacion])
go

		ALTER TABLE [dbo].[T_Region]  WITH NOCHECK ADD  CONSTRAINT FK_Region_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		CREATE TABLE [dbo].[T_Persona]
		(
			[ID_Persona] [int] IDENTITY(1,1) NOT NULL,			
			[Cedula] [varchar](15) NOT NULL,
			[Nombre] [varchar](25) NOT NULL,
			[Apellido_1] [varchar](25) NOT NULL,
			[Apellido_2] [varchar](25) NOT NULL,
			[Direccion] [varchar](255) NOT NULL,
			[Correo] [varchar](40) NOT NULL,
			[Telefono] [varchar](9) NOT NULL,
			[Nacionalidad] [varchar](25) NOT NULL,
			[ID_Departamento] [int] NOT NULL,
			[Cliente] [bit] NOT NULL,
			[Empleado] [bit] NOT NULL,
			[ID_Region] [int] NOT NULL,
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
			(
				[ID_Persona] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Persona]
		ADD CONSTRAINT UC_Cedula_Persona UNIQUE ([Cedula])
GO
		ALTER TABLE [dbo].[T_Persona]
		ADD CONSTRAINT UC_Correo_Persona UNIQUE ([Correo])
go

		ALTER TABLE [dbo].[T_Persona]  WITH NOCHECK ADD  CONSTRAINT FK_Persona_Departa FOREIGN KEY(ID_Departamento)
		REFERENCES [dbo].[T_Departamento] (ID_Departamento)
Go
		ALTER TABLE [dbo].[T_Persona]  WITH NOCHECK ADD  CONSTRAINT FK_Persona_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		CREATE TABLE [dbo].[T_Perfil]
		(
			[ID_Perfil] [int] IDENTITY(1,1) NOT NULL,			
			[Descripcion] [varchar](25) NOT NULL,
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
			(
				[ID_Perfil] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Perfil]
		ADD CONSTRAINT UC_Descripcion_Perfil UNIQUE ([Descripcion])
GO

		ALTER TABLE [dbo].[T_Perfil]  WITH NOCHECK ADD  CONSTRAINT FK_Perfil_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		CREATE TABLE [dbo].[T_Usuario]
		(
			[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,	
			[ID_Persona] [int] NOT NULL,		
			[Usuario] [varchar](15) NOT NULL,
			[Pass] [varchar](32) NOT NULL,
			[ID_Estado] [char] (1) NOT NULL,
			[ID_Perfil] [int] NOT NULL
			CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
			(
				[ID_Usuario] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Usuario]
		ADD CONSTRAINT UC_Usuario_Usuario UNIQUE ([Usuario])
GO

         	ALTER TABLE [dbo].[T_Usuario]  WITH NOCHECK ADD  CONSTRAINT FK_Usuario_Perfil FOREIGN KEY(ID_Perfil)
		REFERENCES [dbo].[T_Perfil] (ID_Perfil)
Go
		ALTER TABLE [dbo].[T_Usuario]  WITH NOCHECK ADD  CONSTRAINT FK_Usuario_Persona FOREIGN KEY(ID_Persona)
		REFERENCES [dbo].[T_Persona] (ID_Persona)
Go
		ALTER TABLE [dbo].[T_Usuario]  WITH NOCHECK ADD  CONSTRAINT FK_Usuario_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		CREATE TABLE [dbo].[T_UsuarioPerfil]
		(
			[ID_Usuario] [int] NOT NULL,	
			[ID_Perfil] [int] NOT NULL,	
			[ID_Estado] [char] (1) NOT NULL	
		)

GO

		ALTER TABLE [dbo].[T_UsuarioPerfil]  WITH NOCHECK ADD  CONSTRAINT FK_UsuarioPerfil_Usuario FOREIGN KEY(ID_Usuario)
		REFERENCES [dbo].[T_Usuario] (ID_Usuario)
Go
		ALTER TABLE [dbo].[T_UsuarioPerfil]  WITH NOCHECK ADD  CONSTRAINT FK_UsuarioPerfil_Perfil FOREIGN KEY(ID_Perfil)
		REFERENCES [dbo].[T_Perfil] (ID_Perfil)
Go
		ALTER TABLE [dbo].[T_UsuarioPerfil]  WITH NOCHECK ADD  CONSTRAINT FK_UsuarioPerfil_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			

		CREATE TABLE [dbo].[T_TV_Tarifa]
		(
			[ID_TV] [int] IDENTITY(1,1) NOT NULL,
			[Descripcion] [varchar](25) NOT NULL,			
			[Unidad] [varchar](25) NOT NULL,
			[Costo] [money] NOT NULL,
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_TV] PRIMARY KEY CLUSTERED 
			(
				[ID_TV] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_TV_Tarifa]
		ADD CONSTRAINT UC_Descripcion_TV_Tarifa UNIQUE ([Descripcion])
GO

		ALTER TABLE [dbo].[T_TV_Tarifa]  WITH NOCHECK ADD  CONSTRAINT FK_TV_Tarifa_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_Internet_Tarifa]
		(
			[ID_Internet] [int] IDENTITY(1,1) NOT NULL,
			[Descripcion] [varchar](25) NOT NULL,			
			[Unidad] [varchar](25) NOT NULL,
			[Costo] [money] NOT NULL,
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_Internet] PRIMARY KEY CLUSTERED 
			(
				[ID_Internet] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Internet_Tarifa]
		ADD CONSTRAINT UC_Descripcion_Internet UNIQUE ([Descripcion])
GO

		ALTER TABLE [dbo].[T_Internet_Tarifa]  WITH NOCHECK ADD  CONSTRAINT FK_Internet_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	CREATE TABLE [dbo].[T_Servicios]
		(
			[ID_servicios] [int] IDENTITY(1,1) NOT NULL,
			[ID_TV] [int] NOT NULL,			
			[ID_Internet] [int] NOT NULL,
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_servicios] PRIMARY KEY CLUSTERED 
			(
				[ID_servicios] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_servicios]  WITH NOCHECK ADD  CONSTRAINT FK_servicios_TV FOREIGN KEY(ID_TV)
		REFERENCES [dbo].[T_TV_Tarifa] (ID_TV)
Go
		ALTER TABLE [dbo].[T_servicios]  WITH NOCHECK ADD  CONSTRAINT FK_servicios_Internet FOREIGN KEY(ID_Internet)
		REFERENCES [dbo].[T_Internet_Tarifa] (ID_Internet)
Go

		ALTER TABLE [dbo].[T_servicios]  WITH NOCHECK ADD  CONSTRAINT FK_servicios_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_ModalidadPago]
		(
			[ID_ModalidadPago] [int] IDENTITY(1,1) NOT NULL,
			[Descripcion] [varchar](25) NOT NULL,			
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_ModalidadPago] PRIMARY KEY CLUSTERED 
			(
				[ID_ModalidadPago] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_ModalidadPago]
		ADD CONSTRAINT UC_Descripcion_ModalidadPago UNIQUE ([Descripcion])
GO

		ALTER TABLE [dbo].[T_ModalidadPago]  WITH NOCHECK ADD  CONSTRAINT FK_ModalidadPago_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_Suscripciones]
		(
			[ID_Contrato] [int] IDENTITY(1,1) NOT NULL,
			[ID_PersonaCliente] [int] NOT NULL,
			[ID_servicios] [int] NOT NULL,
			[ID_PersonaEmpleado] [int] NOT NULL,
			[Fecha_Creacion] [date] NOT NULL,		
			[Cantidad_TV] [int] NOT NULL,
			[ID_OrdenTrabajo] [int] NOT NULL,
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_Contrato] PRIMARY KEY CLUSTERED 
			(
				[ID_Contrato] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Suscripciones]  WITH NOCHECK ADD  CONSTRAINT FK_Suscripciones_PersonaCliente FOREIGN KEY(ID_PersonaCliente)
		REFERENCES [dbo].[T_Persona] (ID_Persona)
Go
		ALTER TABLE [dbo].[T_Suscripciones]  WITH NOCHECK ADD  CONSTRAINT FK_Suscripciones_servicios FOREIGN KEY(ID_servicios)
		REFERENCES [dbo].[T_servicios] (ID_servicios)
Go
		ALTER TABLE [dbo].[T_Suscripciones]  WITH NOCHECK ADD  CONSTRAINT FK_Suscripciones_PersonaEmpleado FOREIGN KEY(ID_PersonaEmpleado)
		REFERENCES [dbo].[T_Persona] (ID_Persona)
Go

		ALTER TABLE [dbo].[T_Suscripciones]  WITH NOCHECK ADD  CONSTRAINT FK_Suscripciones_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_Cobro]
		(
			[ID_Factura] [int] IDENTITY(1,1) NOT NULL,
			[ID_Contrato] [int] NOT NULL,
			[Fecha_Pago] [date] NOT NULL,
			[ID_ModalidadPago] [int] NOT NULL,
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
			(
				[ID_Factura] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Cobro]  WITH NOCHECK ADD  CONSTRAINT FK_Cobro_Contrato FOREIGN KEY(ID_Contrato)
		REFERENCES [dbo].[T_Suscripciones] (ID_Contrato)
Go
		ALTER TABLE [dbo].[T_Cobro]  WITH NOCHECK ADD  CONSTRAINT FK_Cobro_ModalidadPago FOREIGN KEY(ID_ModalidadPago)
		REFERENCES [dbo].[T_ModalidadPago] (ID_ModalidadPago)
Go
		ALTER TABLE [dbo].[T_Cobro]  WITH NOCHECK ADD  CONSTRAINT FK_Cobro_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_Proveedor]
		(
			[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
			[Cedula_Juridica] [varchar](15) NOT NULL,
			[Nombre] [varchar](45) NOT NULL,
			[Direccion] [varchar](255) NOT NULL,	
			[Correo] [varchar](40) NOT NULL,	
			[Telefono] [varchar](9) NOT NULL,		
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
			(
				[ID_Proveedor] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Proveedor]
		ADD CONSTRAINT UC_Cedula_Juridica_Proveedor UNIQUE ([Cedula_Juridica])
GO
		ALTER TABLE [dbo].[T_Proveedor]
		ADD CONSTRAINT UC_Nombre_Proveedor UNIQUE ([Nombre])
GO
		ALTER TABLE [dbo].[T_Proveedor]
		ADD CONSTRAINT UC_Correo_Proveedor UNIQUE ([Correo])
GO
		ALTER TABLE [dbo].[T_Proveedor]  WITH NOCHECK ADD  CONSTRAINT FK_Proveedor_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_Articulo]
		(
			[ID_Articulo] [int] IDENTITY(1,1) NOT NULL,
			[Nombre] [varchar](25) NOT NULL,
			[Direccion] [varchar](255) NOT NULL,	
			[ID_Proveedor] [int] NOT NULL,
			[Unidad_Medida] [varchar](15) NOT NULL,	
			[CostoCompra] [money] NOT NULL,		
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_Articulo] PRIMARY KEY CLUSTERED 
			(
				[ID_Articulo] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Articulo]  WITH NOCHECK ADD  CONSTRAINT FK_Articulo_Proveedor FOREIGN KEY(ID_Proveedor)
		REFERENCES [dbo].[T_Proveedor] (ID_Proveedor)
Go
		ALTER TABLE [dbo].[T_Articulo]  WITH NOCHECK ADD  CONSTRAINT FK_Articulo_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go



-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_InventarioEquipo]
		(
			[ID_InventarioEquipo] [int] IDENTITY(1,1) NOT NULL,
			[ID_Articulo] [int] NOT NULL,
			[Cantidad] [int] NOT NULL,	
			[ID_Estado] [char] (1) NOT NULL,
			[ID_Usuario] [int] NOT NULL
			CONSTRAINT [PK_InventarioEquipo] PRIMARY KEY CLUSTERED 
			(
				[ID_InventarioEquipo] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_InventarioEquipo]  WITH NOCHECK ADD  CONSTRAINT FK_InventarioEquipo_Articulo FOREIGN KEY(ID_Articulo)
		REFERENCES [dbo].[T_Articulo] (ID_Articulo)
Go
		ALTER TABLE [dbo].[T_InventarioEquipo]  WITH NOCHECK ADD  CONSTRAINT FK_InventarioEquipo_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go
                ALTER TABLE [dbo].[T_InventarioEquipo]  WITH NOCHECK ADD  CONSTRAINT FK_InventarioEquipo_Usuario FOREIGN KEY(ID_Usuario)
		REFERENCES [dbo].[T_Usuario] (ID_Usuario)
Go
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_ArquilerEquipo]
		(
			[ID_ArquilerEquipo] [int] IDENTITY(1,1) NOT NULL,
			[ID_InventarioEquipo] [int] NOT NULL,
			[ID_Contrato] [int] NOT NULL,
			[Monto_Mensual] [money] NOT NULL,
			[CantidadUnidades] [int] NOT NULL,	
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_ArquilerEquipo] PRIMARY KEY CLUSTERED 
			(
				[ID_ArquilerEquipo] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_ArquilerEquipo]  WITH NOCHECK ADD  CONSTRAINT FK_ArquilerEquipo_InventarioEquipo FOREIGN KEY(ID_InventarioEquipo)
		REFERENCES [dbo].[T_InventarioEquipo] (ID_InventarioEquipo)
Go
		ALTER TABLE [dbo].[T_ArquilerEquipo]  WITH NOCHECK ADD  CONSTRAINT FK_ArquilerEquipo_Contrato FOREIGN KEY(ID_Contrato)
		REFERENCES [dbo].[T_Suscripciones] (ID_Contrato)
Go
		ALTER TABLE [dbo].[T_ArquilerEquipo]  WITH NOCHECK ADD  CONSTRAINT FK_ArquilerEquipo_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_DetalleCobro]
		(
			[ID_DetalleCobro] [int] IDENTITY(1,1) NOT NULL,
			[ID_Factura] [int] NOT NULL,
			[ID_ArquilerEquipo] [int] NOT NULL,
			[ID_servicios] [int] NOT NULL,
			[Descripcion] [nvarchar](30) NOT NULL,	
			[Cantidad] [int] NOT NULL,	
			[Neto] [money] NOT NULL,
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_DetalleCobro] PRIMARY KEY CLUSTERED 
			(
				[ID_DetalleCobro] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_DetalleCobro]  WITH NOCHECK ADD  CONSTRAINT FK_DetalleCobro_Factura FOREIGN KEY(ID_Factura)
		REFERENCES [dbo].[T_Cobro] (ID_Factura)
Go
		ALTER TABLE [dbo].[T_DetalleCobro]  WITH NOCHECK ADD  CONSTRAINT FK_DetalleCobro_ArquilerEquipo FOREIGN KEY(ID_ArquilerEquipo)
		REFERENCES [dbo].[T_ArquilerEquipo] (ID_ArquilerEquipo)
Go
		ALTER TABLE [dbo].[T_DetalleCobro]  WITH NOCHECK ADD  CONSTRAINT FK_DetalleCobro_servicios FOREIGN KEY(ID_servicios)
		REFERENCES [dbo].[T_servicios] (ID_servicios)
Go
		ALTER TABLE [dbo].[T_DetalleCobro]  WITH NOCHECK ADD  CONSTRAINT FK_DetalleCobro_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_MontoCobro]
		(
			[ID_MontoCobro] [int] IDENTITY(1,1) NOT NULL,
			[ID_Factura] [int] NOT NULL,
			[Sub_Total] [Money] NOT NULL,
			[I.V.I] [Money] NOT NULL,
			[TotalPagar] [money] NOT NULL,	
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_MontoCobro] PRIMARY KEY CLUSTERED 
			(
				[ID_MontoCobro] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_MontoCobro]  WITH NOCHECK ADD  CONSTRAINT FK_MontoCobro_Factura FOREIGN KEY(ID_Factura)
		REFERENCES [dbo].[T_Cobro] (ID_Factura)
Go
		ALTER TABLE [dbo].[T_MontoCobro]  WITH NOCHECK ADD  CONSTRAINT FK_MontoCobro_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_OrdenTrabajo]
		(
			[ID_OrdenTrabajo] [int] IDENTITY(1,1) NOT NULL,
			[ID_Tecnico] [int] NOT NULL,
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_OrdenTrabajo] PRIMARY KEY CLUSTERED 
			(
				[ID_OrdenTrabajo] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_OrdenTrabajo]  WITH NOCHECK ADD  CONSTRAINT FK_OrdenTrabajo_Tecnico FOREIGN KEY(ID_Tecnico)
		REFERENCES [dbo].[T_Persona] (ID_Persona)--- Los que son iguales a técnicos
Go
		ALTER TABLE [dbo].[T_OrdenTrabajo]  WITH NOCHECK ADD  CONSTRAINT FK_OrdenTrabajo_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_AtencionTecnica]
		(
			[ID_AtencionTecnica] [int] IDENTITY(1,1) NOT NULL,
			[ID_Contrato] [int] NOT NULL,
			[Fecha_Caso] [date] NOT NULL,
			[Averia_TV_Internet_Ambos] [nvarchar](20) NOT NULL,
			[Problema_Indicado_Cliente] [nvarchar](255) NOT NULL,
			[Pruebas_Realizadas_x_Telefono] [nvarchar](255) NOT NULL,
			[Averia_Resualta_telefono] [char] (1) NOT NULL, -- S=Si,N=No
			[ID_OrdenTrabajo] [int] NOT NULL,
			[ID_Persona_Asistentete_telefonico] [int] NOT NULL,--- Asistentete_telefonico
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_AtencionTecnica] PRIMARY KEY CLUSTERED 
			(
				[ID_AtencionTecnica] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_AtencionTecnica]  WITH NOCHECK ADD  CONSTRAINT FK_AtencionTecnica_Contrato FOREIGN KEY(ID_Contrato)
		REFERENCES [dbo].[T_Suscripciones] (ID_Contrato)
go
		ALTER TABLE [dbo].[T_AtencionTecnica]  WITH NOCHECK ADD  CONSTRAINT FK_AtencionTecnica_OrdenTrabajo FOREIGN KEY(ID_OrdenTrabajo)
		REFERENCES [dbo].[T_OrdenTrabajo] (ID_OrdenTrabajo)
Go
		ALTER TABLE [dbo].[T_AtencionTecnica]  WITH NOCHECK ADD  CONSTRAINT FK_AtencionTecnica_Asistentete_telefonico FOREIGN KEY(ID_Persona_Asistentete_telefonico)
		REFERENCES [dbo].[T_Persona] (ID_Persona)--- Los que son iguales a Asistentete_télefonico
Go
		ALTER TABLE [dbo].[T_AtencionTecnica]  WITH NOCHECK ADD  CONSTRAINT FK_AtencionTecnica_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_Desconexion]
		(
			[ID_T_Desconexion] [int] IDENTITY(1,1) NOT NULL,
			[ID_Contrato] [int] NOT NULL,
			[Fecha_Descone] [date] NOT NULL,
			[Motivo] [nvarchar](20) NOT NULL,
			[ID_OrdenTrabajo] [int] NOT NULL,
			[ID_Estado] [char] (1) NOT NULL
			CONSTRAINT [PK_T_Desconexion] PRIMARY KEY CLUSTERED 
			(
				[ID_T_Desconexion] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Desconexion]  WITH NOCHECK ADD  CONSTRAINT FK_Desconexion_Contrato FOREIGN KEY(ID_Contrato)
		REFERENCES [dbo].[T_Suscripciones] (ID_Contrato)
go
		ALTER TABLE [dbo].[T_Desconexion]  WITH NOCHECK ADD  CONSTRAINT FK_Desconexion_OrdenTrabajo FOREIGN KEY(ID_OrdenTrabajo)
		REFERENCES [dbo].[T_OrdenTrabajo] (ID_OrdenTrabajo)
Go
		ALTER TABLE [dbo].[T_Desconexion]  WITH NOCHECK ADD  CONSTRAINT FK_Desconexion_Estados FOREIGN KEY(ID_Estado)
		REFERENCES [dbo].[T_Estados] (ID_Estado)
Go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			CREATE TABLE [dbo].[T_Parametros]
		(
			[ID_T_Parametros] [int] IDENTITY(1,1) NOT NULL,
			[ID_Usuario] [int] NOT NULL,
			[Nombre] [varchar](25) NOT NULL,
			[Valor] [varchar](25) NOT NULL,
			[Descripcion] [varchar] (30) NOT NULL,
			[Fecha_Ingreso] [date] NOT NULL,
			CONSTRAINT [PK_T_Parametros] PRIMARY KEY CLUSTERED 
			(
				[ID_T_Parametros] ASC
			)
		) ON [PRIMARY]

GO

		ALTER TABLE [dbo].[T_Parametros]  WITH NOCHECK ADD  CONSTRAINT FK_Parametros_Usuario FOREIGN KEY(ID_Usuario)
		REFERENCES [dbo].[T_Usuario] (ID_Usuario)
GO


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------           Se crea en esta linea para no tener errores   -----------------------------------------------------------------------------------

		ALTER TABLE [dbo].[T_Suscripciones]  WITH NOCHECK ADD  CONSTRAINT FK_Suscripciones_OrdenTrabajo FOREIGN KEY(ID_OrdenTrabajo)
		REFERENCES [dbo].[T_OrdenTrabajo] (ID_OrdenTrabajo)
Go
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
