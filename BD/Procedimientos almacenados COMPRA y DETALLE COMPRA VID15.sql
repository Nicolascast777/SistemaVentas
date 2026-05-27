--// EL SIGUIENTE PROCESO ES PARA REGISTRAR UNA COMPRA A UN PROVEEDOR

--SE CREARA UN PARAMETRO COMO TIPO TABLA, COMO CUANDO CREO PARAMETROS O VARIABLES INT, VARCHAR, BIT, ETC.
-- Y ESTE RECIBIRA LO QUE LE PASE DESDE EL CODIGO, LE PASARE UN DATATABLE

CREATE TYPE [DBO].[EDetalle_Compra] AS TABLE (
	[IdProducto] INT NULL,
	[PrecioCompra] DECIMAL(18,2),
	[PrecioVenta] DECIMAL(18,2),
	[Cantidad] INT NULL,
	[MontoTotal] DECIMAL(18,2) NULL
)
GO

CREATE PROCEDURE sp_RegistrarCompra(
	@IdUsuario INT,
	@IdProveedor INT,
	@TipoSoporte VARCHAR(500),
	@NumeroDocumento VARCHAR(500),
	@MontoTotal DECIMAL(18,2),
	@DetalleCompra [EDetalle_compra] READONLY,
	@Resultado BIT OUTPUT,
	@Mensaje VARCHAR(500) OUTPUT
	)
AS
BEGIN

	BEGIN TRY
	--se declara id de la compra
		DECLARE @idcompra INT = 0
		SET @Resultado = 1
		SET @Mensaje = ''

		--Se usan transacciones, si no hay problema con ninguna de los comandos, se completan.
		--la columna "TipoDocumento" deberia de cambiar su nombre a "TipoSoporte"
		BEGIN TRANSACTION registro
		
		--Inserto compra
			INSERT INTO COMPRA(IdUsuario,IdProveedor,TipoDocumento,NumeroDocumento,MontoTotal)
			VALUES(	@IdUsuario,@IdProveedor,@TipoSoporte, @NumeroDocumento,@MontoTotal)
		--Busco el id de la compra, es identity. El siguiente comando funciona si se ejecuta inmediatamente despues de hacer un INSERT.
			SET @idcompra = SCOPE_IDENTITY()

		--Inserto detalle de la compra.		
			INSERT INTO DETALLE_COMPRA(IdCompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad, MontoTotal) 
			SELECT @idcompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal FROM @DetalleCompra

		--TAMBIEN SE DEBE ACTUALIZAR LA TABLA DE PRODUCTO, pues se debe actualizar su precio venta, precio compra y el stock. Por lo anterior se hace un INNER JOIN.
			UPDATE produ SET produ.STOCK = produ.STOCK + DetaCompra.Cantidad,
			produ.precioCompra = DetaCompra.PrecioCompra,
			produ.PrecioVenta = DetaCompra.PrecioVenta
			FROM PRODUCTO produ
			INNER JOIN @DetalleCompra DetaCompra ON DetaCompra.IdProducto = produ.IdProducto

		--Si todo esta OK, se guarda permanentemente en la BD.
		commit TRANSACTION registro

	END TRY
	
	BEGIN CATCH
	--No se registrara la compra si hay un problema con alguno de los comandos
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback TRANSACTION registro
	END CATCH

END