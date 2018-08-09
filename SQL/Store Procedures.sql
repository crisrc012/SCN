USE [BD_MegaCable]
GO
CREATE PROCEDURE SP_LISTAR_T_AlquilerEquipo
AS
SELECT [ID_AlquilerEquipo]
      ,[ID_InventarioEquipo]
      ,[ID_Contrato]
      ,[Monto_Mensual]
      ,[CantidadUnidades]
      ,[ID_Estado]
  FROM [dbo].[T_AlquilerEquipo]
GO
CREATE PROCEDURE SP_LISTAR_T_Articulo
AS
SELECT [ID_Articulo]
      ,[Nombre]
      ,[Direccion]
      ,[ID_Proveedor]
      ,[Unidad_Medida]
      ,[CostoCompra]
      ,[ID_Estado]
  FROM [dbo].[T_Articulo]
GO
CREATE PROCEDURE SP_LISTAR_T_AtencionTecnica
AS
SELECT [ID_AtencionTecnica]
      ,[ID_Contrato]
      ,[Fecha_Caso]
      ,[Averia_TV_Internet_Ambos]
      ,[Problema_Indicado_Cliente]
      ,[Pruebas_Realizadas_x_Telefono]
      ,[Averia_Resualta_telefono]
      ,[ID_OrdenTrabajo]
      ,[ID_Persona_Asistentete_telefonico]
      ,[ID_Estado]
  FROM [dbo].[T_AtencionTecnica]
GO
CREATE PROCEDURE SP_LISTAR_T_Cobro
AS
SELECT [ID_Factura]
      ,[ID_Contrato]
      ,[Fecha_Pago]
      ,[ID_ModalidadPago]
      ,[ID_Estado]
  FROM [dbo].[T_Cobro]
GO
CREATE PROCEDURE SP_LISTAR_T_Departamento
AS
SELECT [ID_Departamento]
      ,[Descripcion]
      ,[ID_Estado]
  FROM [dbo].[T_Departamento]
GO
CREATE PROCEDURE SP_LISTAR_T_Desconexion
AS
SELECT [ID_T_Desconexion]
      ,[ID_Contrato]
      ,[Fecha_Descone]
      ,[Motivo]
      ,[ID_OrdenTrabajo]
      ,[ID_Estado]
  FROM [dbo].[T_Desconexion]
GO
CREATE PROCEDURE SP_LISTAR_T_DetalleCobro
AS
SELECT [ID_DetalleCobro]
      ,[ID_Factura]
      ,[ID_AlquilerEquipo]
      ,[ID_servicios]
      ,[Descripcion]
      ,[Cantidad]
      ,[Neto]
      ,[ID_Estado]
  FROM [dbo].[T_DetalleCobro]
GO
CREATE PROCEDURE SP_LISTAR_T_Estados
AS
SELECT [ID_Estado]
      ,[Descripcion]
  FROM [dbo].[T_Estados]
GO
CREATE PROCEDURE SP_LISTAR_T_Internet_Tarifa
AS
SELECT [ID_Internet]
      ,[Descripcion]
      ,[Unidad]
      ,[Costo]
      ,[ID_Estado]
  FROM [dbo].[T_Internet_Tarifa]
GO
CREATE PROCEDURE SP_LISTAR_T_InventarioEquipo
AS
SELECT [ID_InventarioEquipo]
      ,[ID_Articulo]
      ,[Cantidad]
      ,[ID_Estado]
      ,[ID_Usuario]
  FROM [dbo].[T_InventarioEquipo]
GO
CREATE PROCEDURE SP_LISTAR_T_ModalidadPago
AS
SELECT [ID_ModalidadPago]
      ,[Descripcion]
      ,[ID_Estado]
  FROM [dbo].[T_ModalidadPago]
GO
CREATE PROCEDURE SP_LISTAR_T_MontoCobro
AS
SELECT [ID_MontoCobro]
      ,[ID_Factura]
      ,[Sub_Total]
      ,[I.V.I]
      ,[TotalPagar]
      ,[ID_Estado]
  FROM [dbo].[T_MontoCobro]
GO
CREATE PROCEDURE SP_LISTAR_T_OrdenTrabajo
AS
SELECT [ID_OrdenTrabajo]
      ,[ID_Tecnico]
      ,[ID_Estado]
  FROM [dbo].[T_OrdenTrabajo]
GO
CREATE PROCEDURE SP_LISTAR_T_Parametros
AS
SELECT [ID_T_Parametros]
      ,[ID_Usuario]
      ,[Nombre]
      ,[Valor]
      ,[Descripcion]
      ,[Fecha_Ingreso]
  FROM [dbo].[T_Parametros]
GO

--------------
CREATE PROCEDURE SP_LISTAR_T_Perfil
AS
SELECT [ID_Perfil]
      ,[Descripcion]
      ,[ID_Estado]
  FROM [dbo].[T_Perfil]
GO
CREATE PROCEDURE SP_INSERTAR_T_Perfil
(
	@Descripcion varchar(25),
	@ID_Estado char(1)
)
AS
INSERT INTO [dbo].[T_Perfil]
           ([Descripcion]
           ,[ID_Estado])
     VALUES
           (@Descripcion
           ,@ID_Estado);
-- Devuelve la última llave generada
SELECT MAX ([ID_Perfil])
FROM [dbo].[T_Perfil]
GO
CREATE PROCEDURE SP_MODIFICAR_T_Perfil
(
	@ID_Perfil int,
	@Descripcion varchar(25),
	@ID_Estado char
)
AS
UPDATE [dbo].[T_Perfil]
   SET [Descripcion] = @Descripcion,
   [ID_Estado] = @ID_Estado
 WHERE ID_Perfil = @ID_Perfil
GO
CREATE PROCEDURE SP_ELIMINAR_T_Perfil
(
	@ID_Perfil int
)
AS
DELETE FROM [dbo].[T_Perfil]
      WHERE ID_Perfil = @ID_Perfil
GO
----------- 

CREATE PROCEDURE SP_LISTAR_T_Persona
AS
SELECT [ID_Persona]
      ,[Cedula]
      ,[Nombre]
      ,[Apellido_1]
      ,[Apellido_2]
      ,[Direccion]
      ,[Correo]
      ,[Telefono]
      ,[Nacionalidad]
      ,[ID_Departamento]
      ,[Cliente]
      ,[Empleado]
      ,[ID_Region]
      ,[ID_Estado]
  FROM [dbo].[T_Persona]
GO
CREATE PROCEDURE SP_LISTAR_T_Proveedor
AS
SELECT [ID_Proveedor]
      ,[Cedula_Juridica]
      ,[Nombre]
      ,[Direccion]
      ,[Correo]
      ,[Telefono]
      ,[ID_Estado]
  FROM [dbo].[T_Proveedor]
GO
CREATE PROCEDURE SP_LISTAR_T_Region
AS
SELECT [ID_Region]
      ,[Descripcion]
      ,[Localizacion]
      ,[ID_Estado]
  FROM [dbo].[T_Region]
GO
CREATE PROCEDURE SP_LISTAR_T_Servicios
AS
SELECT [ID_servicios]
      ,[ID_TV]
      ,[ID_Internet]
      ,[ID_Estado]
  FROM [dbo].[T_Servicios]
GO
CREATE PROCEDURE SP_LISTAR_T_Suscripciones
AS
SELECT [ID_Contrato]
      ,[ID_PersonaCliente]
      ,[ID_servicios]
      ,[ID_PersonaEmpleado]
      ,[Fecha_Creacion]
      ,[Cantidad_TV]
      ,[ID_OrdenTrabajo]
      ,[ID_Estado]
  FROM [dbo].[T_Suscripciones]
GO
CREATE PROCEDURE SP_LISTAR_T_TV_Tarifa
AS
SELECT [ID_TV]
      ,[Descripcion]
      ,[Unidad]
      ,[Costo]
      ,[ID_Estado]
  FROM [dbo].[T_TV_Tarifa]
GO
CREATE PROCEDURE SP_LISTAR_T_Usuario
AS
SELECT [ID_Usuario]
      ,[ID_Persona]
      ,[Usuario]
      ,[Pass]
      ,[ID_Estado]
      ,[ID_Perfil]
  FROM [dbo].[T_Usuario]
GO
CREATE PROCEDURE SP_LISTAR_T_UsuarioPerfil
AS
SELECT [ID_Usuario]
      ,[ID_Perfil]
      ,[ID_Estado]
  FROM [dbo].[T_UsuarioPerfil]
GO
