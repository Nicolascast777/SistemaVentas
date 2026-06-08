--/* PROCEDIMIENTO ALMACENADO PARA REGISTRAR UNA VENTA*/

--Se crea parametro para el detalle de la ventda tipo tabla 
CREATE TYPE [DBO].[EDetalle_Venta] AS TABLE(
[IdProducto] INT NULL,
[PrecioVenta] DECIMAL(18,2) NULL,
[Cantidad] INT NULL,
[SubTotal] DECIMAL(18,2) NULL
)
GO

--/* PROCEDIMIENTO ALMACENADO PARA REGISTRAR UNA VENTA*/
CREATE PROCEDURE usp_RegistrarVenta(
@IdUsuario INT,
@TipoDocumento VARCHAR(500),
@NumeroDocumento VARCHAR(500),
@DocumentoCliente VARCHAR(500),
@NombreCliente VARCHAR(500),
@MontoPago DECIMAL(18,2),
@MontoCambio DECIMAL(18,2),
@MontoTotal DECIMAL(18,2),
@DetalleVenta [EDetalle_Venta] READONLY,
@Resultado BIT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
) 
AS
BEGIN
	BEGIN TRY
		
		DECLARE @idventa int = 0
		SET @Resultado = 1
		SET @Mensaje = ''

		BEGIN TRANSACTION REGISTRO_VENTA
		INSERT INTO VENTA(IdUsuario, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal)
		VALUES(@IdUsuario, @TipoDocumento, @NumeroDocumento, @DocumentoCliente, @NombreCliente, @MontoPago, @MontoCambio, @MontoTotal)

		SET @idventa = SCOPE_IDENTITY()

		INSERT INTO DETALLE_VENTA(IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal)
			SELECT @idventa, IdProducto, PrecioVenta, Cantidad,SubTotal FROM @DetalleVenta

		COMMIT TRANSACTION REGISTRO_VENTA
	
	END TRY
	
	BEGIN CATCH
		SET @Resultado = 0
		SET @Mensaje = ERROR_MESSAGE()
		ROLLBACK TRANSACTION REGISTRO_VENTA
	END CATCH
END
GO
