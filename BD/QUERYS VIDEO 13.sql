--QUERYS VIDEO 12
CREATE TABLE DETALL_VENTA(
idDetalleVenta INT)


CREATE TABLE NEGOCIO(
IdNegocio INT PRIMARY KEY,
Nombre VARCHAR(50),
NIT VARCHAR(60),
Direccion VARCHAR(60),
Logo varbinary(max) NULL
)

SELECT IdNegocio, Nombre, NIT, Direccion, Logo FROM NEGOCIO WHERE IdNegocio = 1 

--INSERT INTO NEGOCIO (IdNegocio, Nombre, NIT, Direccion) VALUES (1, 'Estudiantes ADSO 28', '89000000', 'SALOMIA-CEAI')

