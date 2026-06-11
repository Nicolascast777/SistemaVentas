
--DROP PROC sp_RegistrarCompra;




--DROP TYPE dbo.EDetalle_Compra;



--CREATE TYPE dbo.EDetalle_Compra AS TABLE
--(
--    IdProducto INT NULL,
--    PrecioCompra DECIMAL(18,2) NULL,
--    PrecioVenta DECIMAL(18,2) NULL,
--    PorcentajeRendimiento DECIMAL(5,2) NULL,
--    Cantidad INT NULL,
--    MontoTotal DECIMAL(18,2) NULL
--);

ALTER TABLE DETALLE_VENTA
ADD PorcentajeRendimiento DECIMAL(5,2) NULL;

ALTER TABLE DETALLE_COMPRA
ADD PorcentajeRendimiento DECIMAL(5,2) NULL;

GO
ALTER TABLE NEGOCIO
ADD PorcentajeRendimientoGeneral DECIMAL(5,2) NULL;
GO

