--Al inicio del video 12, se esta creando un procedimiento almacenado para proveedores pero se estan llamandos columnas que no existen en la tabla proveedor
--esas columnas se pueden agregar con este ALTER
ALTER TABLE Proveedor
ADD 
    Documento NVARCHAR(50) NOT NULL DEFAULT '',
    RazonSocial NVARCHAR(100) NOT NULL DEFAULT '',
    Estado BIT NOT NULL DEFAULT 1;