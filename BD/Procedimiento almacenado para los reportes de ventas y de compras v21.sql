--Procedimiento almacenado para los reportes de ventas y de compras
CREATE PROC sp_ReporteCompras(
    @fechainicio VARCHAR(10),
    @fechafin VARCHAR(10),
    @idproveedor INT
)
AS
BEGIN

    SET DATEFORMAT dmy;
    SELECT
        CONVERT(CHAR(10), c.FechaRegistro, 103) AS FechaRegistro, c.TipoDocumento, c.NumeroDocumento, c.MontoTotal,
        u.NombreCompleto AS UsuarioRegistro,
        pr.Documento AS DocumentoProveedor, pr.RazonSocial,
        p.Codigo AS CodigoProducto, p.Nombre AS NombreProducto, ca.Descripcion AS Categoria, dc.PrecioCompra, dc.PrecioVenta, dc.Cantidad, dc.MontoTotal AS SubTotal
    FROM COMPRA c
        INNER JOIN USUARIO u ON u.IdUsuario = c.IdUsuario
        INNER JOIN PROVEEDOR pr ON pr.IdProveedor = c.IdProveedor
        INNER JOIN DETALLE_COMPRA dc ON dc.IdCompra = c.IdCompra
        INNER JOIN PRODUCTO p ON p.IdProducto = dc.IdProducto
        INNER JOIN CATEGORIA ca ON ca.IdCategoria = p.IdCategoria
    WHERE CONVERT(DATE, c.FechaRegistro) BETWEEN @fechainicio AND @fechafin
        AND pr.IdProveedor = IIF(@idproveedor = 0, pr.IdProveedor, @idproveedor)
END
GO


CREATE PROC sp_ReporteVentas(
    @fechainicio VARCHAR(10),
    @fechafin VARCHAR(10)
)
AS
BEGIN

    SET DATEFORMAT dmy;
    SELECT
        CONVERT(CHAR(10), v.FechaRegistro, 103) AS FechaRegistro, v.TipoDocumento, v.NumeroDocumento, v.MontoTotal,
        u.NombreCompleto AS UsuarioRegistro,
        v.DocumentoCliente, v.NombreCliente,
        p.Codigo [CodigoProducto], p.Nombre [NombreProducto], ca.Descripcion AS Categoria, dv.PrecioVenta, dv.Cantidad, dv.SubTotal
    FROM VENTA v
        INNER JOIN USUARIO u ON u.IdUsuario = v.IdUsuario
        INNER JOIN DETALLE_VENTA dv ON dv.IdVenta = v.IdVenta
        INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
        INNER JOIN CATEGORIA ca ON ca.IdCategoria = p.IdCategoria
    WHERE CONVERT(DATE, v.FechaRegistro) BETWEEN @fechainicio AND @fechafin

END
GO
