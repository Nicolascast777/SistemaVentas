--  ** PROCEDIMIENTOS PARA PROVEEDOR ** --
CREATE PROC sp_RegistrarProveedor(
@Documento VARCHAR(50),
@RazonSocial VARCHAR(50),
@Correo VARCHAR(50),
@Telefono VARCHAR(50),
@Estado BIT,
@Resultado INT output,
@mensaje VARCHAR (500) output
) AS 
Begin
	Set @Resultado = 0
	Declare @IDPERSONA INT
	IF NOT EXISTS (SELECT * FROM Proveedor WHERE Documento = @Documento)
	BEGIN
		INSERT INTO Proveedor(Documento, RazonSocial, Correo, Telefono, Estado) Values
			(@Documento, @RazonSocial,@Correo, @Telefono, @Estado)

			SET @Resultado = SCOPE_IDENTITY()
			END
		ELSE
			SET @mensaje = 'El número de documento ya existe'
END
GO

CREATE PROC sp_ModificarProveedor(
@IdProveedor INT,
@Documento VARCHAR(50),
@RazonSocial VARCHAR(50),
@Correo VARCHAR(50),
@Telefono VARCHAR(50),
@Estado BIT,
@Resultado BIT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
) AS
BEGIN
	SET @Resultado = 1
	DECLARE @IDPERSONA INT
	IF NOT EXISTS (SELECT * FROM Proveedor WHERE Documento = @Documento AND IdProveedor != @IdProveedor)
	BEGIN
		UPDATE Proveedor SET 
		Documento = @Documento,
		RazonSocial = @RazonSocial,
		Correo = @RazonSocial,
		Telefono = @Telefono,
		Estado = @Estado
		WHERE IdProveedor = @IdProveedor
	END
	ELSE
		BEGIN
		SET @Resultado = 0
		SET @Mensaje = 'El número de documento ya existe'
	END
END
GO


CREATE PROC sp_EliminarProveedor(
@IdProveedor INT,
@Resultado BIT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
) AS
	BEGIN
		SET @Resultado = 1
		IF NOT EXISTS (SELECT * FROM Proveedor p
						INNER JOIN COMPRA c on p.IdProveedor = c.IdProveedor
						WHERE P.IdProveedor = @IdProveedor)
			BEGIN
				DELETE TOP(1) FROM PROVEEDOR WHERE IdProveedor = @IdProveedor
			END
		ELSE
			BEGIN
			SET @Resultado = 0
			SET @Mensaje = 'El proveedor se encuentra relacionado a una compra'
			END
	END
